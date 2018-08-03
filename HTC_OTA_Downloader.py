import requests
import time
import hashlib
from tqdm import tqdm

def getX1():
    t = str(timestamp)
    shift_value = 0
    for i in range(4, len(t)):
        tmp = t[len(t) - i]
        if tmp != '0':
            shift_value = int(tmp, 36)
            break
    time_head = t[:len(t) - shift_value]
    time_tail = t[len(t) - shift_value:]
    data = time_tail + SN + IMEI + time_head
    h = hashlib.sha256()
    h.update(data.encode('ascii'))
    return h.hexdigest().upper()

def getHTC1S():
    t = int(time_ms)
    tmp = SN + str(time_ms)
    if t <= 0:
        return tmp
    while True:
        i = t % 10
        if i == 0:
            t = t / 10
        else:
            index = int(len(tmp) - i)
            return tmp[index:] + tmp[:index]

def checkin():
    headers = {
        'User-Agent': 'Android-Checkin/8.0',
        'x-active-g': 'DivadGS38Omatump76'
    }
    queryjson = {
        'imei': IMEI,
        'timeStamp': timestamp,
        'model_number': model,
        'checkin': {
            'build': {
                'serialno': SN,
                'firmware_version': version
            },
            'client_version': 'A8.0(M)',
            'cid': cidnum,
            'checkin_type': 'Manual'
        },
        'x1': getX1()
    }
    r = requests.post(chkUrl, headers=headers, json=queryjson)
    return r.json()

def getOTAPkg():
    headers = {
        'User-Agent': 'Android-Checkin/8.0',
        'htc1s': htc1s
    }
    r = requests.get(uri, headers=headers, stream=True)
    total_size = int(r.headers['Content-Length'])
    pbar = tqdm(total=total_size, unit="B", unit_scale=True, ncols=100)
    with open(pkg, 'wb') as f:
        for chunk in r.iter_content(chunk_size=1024 * 1024):
            f.write(chunk)
            pbar.update(len(chunk))
        pbar.close()
    f.close()

checkinUrl = 'https://andchin-2.htc.com/htcfotacheckin/rest/checkin'
checkinUrlCN = 'https://andchin-2.htccomm.com.cn/htcfotacheckin/rest/checkin'

SN = 'CC55TYG07414'
IMEI = '357290062810490'
timestamp = int(time.time() * 1000)

china = input(">> China Variant? (Y/n): ")

if china.upper() == 'Y':
    chkUrl = checkinUrlCN
else:
    chkUrl = checkinUrl

model = input(">> Model: ")
version = input(">> Version: ")
cidnum = input(">> CID: ")

#model = 'htc_pmeuhl'
#version = '2.41.709.73'
#cidnum = 'HTC__621'

response = checkin()
#print(response)

if 'intent' in response:
    intent = response['intent'][0]
    if 'data_uri' in intent:
        uri = intent['data_uri']
        pkg = intent['pkgFileName']
        for extra in intent['extra']:
            if extra['name'] == 'promptSize':
                size = extra['value']
                break
        time_ms = response['time_msec']
        htc1s = getHTC1S()
        print('>> FILE: ' + pkg)
        print('>> SIZE: ' + size)
        input("Press ENTER to download...")
        getOTAPkg()
    else:
        print('ERROR!!!')
else:
    print('ERROR!!!')
