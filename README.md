# HTC OTA Downloader

HTC's OTA fetching will turn over to **com.htc.checkinprovider**, and it will send a HTTPS POST request.
- https://andchin-2.htc.com/htcfotacheckin/rest/checkin
- https://andchin-2.htccomm.com.cn/htcfotacheckin/rest/checkin *(china only)*

**Request** *(mark out sensitive information)*
```HTTP
POST /htcfotacheckin/rest/checkin HTTP/1.1
User-Agent: Android-Checkin/8.0
Content-type: application/json
x-active-g: DivadGS38Omatump76
Host: andchin-2.htc.com
Connection: Keep-Alive
Accept-Encoding: gzip
Content-Length: 998

{
	"country": "TW",
	"adminArea": "***",
	"locality": "***",
	"zip": "***",
	"sub_locality": "***",
	"statusCode": ***,
	"digest": "6fa1cd74c9afee3c23d0e81db39f152",
	"locale": "zh_TW_#Hant",
	"imei": "***",
	"timeZone": "GMT+08:00",
	"timeStamp": 1532269488377,
	"mFlag": "0",
	"aaReport": "com",
	"currentOS": "aos",
	"mAct": "ee2494566635c51e61ecb8cac1ad3c2b84b47b264fa57fbc689647c56ae5e8aa",
	"mNos": "NA,NA",
	"model_number": "htc_pmeuhl",
	"last_checkin_msec": "1532084894745",
	"checkin": {
		"build": {
			"carrier": "htc",
			"product": "htc_pme",
			"revision": "0",
			"serialno": "***",
			"bootloader": "1.0.0.0000",
			"radio": "1.0.U010241a@61226_79.07_F",
			"firmware_version": "2.41.709.73 8.0_g CL857212 release-keys",
			"changelist": "857212",
			"build_type": "user",
			"build_taskid": "511209"
		},
		"client_version": "A8.0(M)",
		"cid": "HTC__621",
		"checkin_type": "Manual",
		"mcc_mnc": "46692",
		"sim_mcc_mnc": "46692",
		"connection_media": "Wifi",
		"mid": "2PS620000"
	},
	"x1": "36595BBF0B310E58AFA7C13B28AA98D111D81A8E51774011E21E6009E8627740",
	"retryType": "0"
}
```

**Response**
```HTTP
HTTP/1.1 200 OK
Server: Apache-Coyote/1.1
Date: Sun, 22 Jul 2018 14:24:48 GMT
Accept-Ranges: bytes
Server: Noelios-Restlet-Engine/1.1.6
Content-Type: application/json;charset=UTF-8
Content-Length: 1876
Connection: Keep-alive

{
	"time_msec": "1532269488896",
	"stats_ok": true,
	"reason": "FOTAUPDATE_NO_ERROR",
	"group": "public",
	"checkinId": "b9b86038-3405-47ac-955c-bc223a2d354d",
	"deviceId": "450f5743df90b4b1a34e531f386c2a2013a60ec163ee299990a127f85a7d9241",
	"rule_id": "35780",
	"intent": [{
		"extra": [{
			"name": "promptMessage",
			"value": "軟體更新: 3.16.709.3 (1.64 GB)"
		}, {
			"name": "promptFeature",
			"value": "軟體更新: 3.16.709.3 (1.64 GB)\n\n本次系統更新將會包含多項重要的改善:\n- Android 8.0 Oreo 更新。\n- 系統增強."
		}, {
			"name": "promptVersion",
			"value": "軟體更新: 3.16.709.3 (1.64 GB)\n\n本次系統更新將會包含多項重要的改善:\n- Android 8.0 Oreo 更新。\n- 系統增強.\n\n請注意!此更新並不會刪除任何資料，建議您使用免費的Wi-Fi連接下載此更新，若使用手機資料連線則可能須要支付額外的網路商費用。如有疑問，請透過以下網址 http://www.htc.com/  與HTC 客服聯繫。"
		}, {
			"name": "promptSize",
			"value": "1.64 GB"
		}, {
			"name": "preloadSize",
			"value": "274.87 MB"
		}, {
			"name": "optional",
			"value": "false"
		}, {
			"name": "promptMinutes",
			"value": "30,..."
		}, {
			"name": "timeoutSeconds",
			"value": "120"
		}, {
			"name": "force_update",
			"value": "false"
		}, {
			"name": "updateDelay",
			"value": "3"
		}, {
			"name": "downloadViaWifiOnly",
			"value": "false"
		}],
		"action": "android.server.checkin.FOTA_UPDATE",
		"data_uri": "http://fotadl.htc.com/secure/OTA_PERFUME_UHL_O80_SENSE90GP_MR_hTC_Asia_TW_3.16.709.3_R1-2.41.709.73_release_5196641w4lmj50mv7k4fxl.zip/surl:kid=23,et=1532355888,h=41944BE1AC20F5B3DDB9220B7881A2D7",
		"enc_type": "NO",
		"pkgFileName": "OTA_PERFUME_UHL_O80_SENSE90GP_MR_hTC_Asia_TW_3.16.709.3_R1-2.41.709.73_release_5196641w4lmj50mv7k4fxl.zip",
		"imageId": "45206",
		"secure_uri": "true",
		"OSType": "aos",
		"cnSenseInfo": {
			"cnSenseVersion": "7.4.9",
			"cnSenseTime": "1514947765497"
		},
		"force_receive_reply": "false"
	}],
	"reason2": "aos:FOTAUPDATE_NO_ERROR;cos:FOTACANCEL_NO_MATCH_RULE;"
}
```
### Package downloading
```HTTP
GET /secure/OTA_PERFUME_UHL_O80_SENSE90GP_MR_hTC_Asia_TW_3.16.709.3_R1-2.41.709.73_release_5196641w4lmj50mv7k4fxl.zip/surl:kid=23,et=1532355888,h=41944BE1AC20F5B3DDB9220B7881A2D7 HTTP/1.1
User-Agent: Android-Checkin/8.0
htc1s: 488896************1532269
Host: fotadl.htc.com
Connection: Keep-Alive
Accept-Encoding: gzip
```
# Description

A **checkin request** will need **Unix Timestamp** (millisecond), device's **IMEI**, **SN**, **Firmware Version**, and a variable named **X1**.

## X1:
This is a **SHA-256** checksum from **Timestamp** (millisecond), **IMEI** and **SN**.
```
Timestamp: 1532271615570
SN: CC55TYG07414
IMEI: 357290062810490
```
### Method
```Csharp
private string getX1()
{
    string time = TimeStamp.ToString();
    int shift_value = 0;
    for (int i = 4; i <= time.Length; i++)
    {
        if (time[time.Length - i] != '0')
        {
            shift_value = (int)char.GetNumericValue(time[time.Length - i]);
            break;
        }
    }
    string time_head = time.Substring(0, time.Length - shift_value);
    string time_tail = time.Substring(time.Length - shift_value);
    return sha256(time_tail + SN + IMEI + time_head);
}
```
```
shift_value = 7 (last char not '0')
time_head = 1532271
time_tail = 615570

Before: 615570CC55TYG074143572900628104901532271
After: 2A5F5E0CA9E96AA598AFAC189CCFA9893D1E63026ADD64D5F35F691CFF0C2430
```

### Customized Request
```HTTP
POST /htcfotacheckin/rest/checkin HTTP/1.1
User-Agent: Android-Checkin/8.0
Content-type: application/json
x-active-g: DivadGS38Omatump76
Host: andchin-2.htc.com

{
	"imei": "357290062810490",
	"timeStamp": 1532271615570,
	"model_number": "htc_pmeuhl",
	"checkin": {
		"build": {
			"serialno": "CC55TYG07414",
			"firmware_version": "2.41.709.73",
		},
		"client_version": "A8.0(M)",
		"cid": "HTC__621",
		"checkin_type": "Manual",
	},
	"x1": "2A5F5E0CA9E96AA598AFAC189CCFA9893D1E63026ADD64D5F35F691CFF0C2430",
}
```

Now, we can create a specific information to query a specific OTA package, but in some OTA  that has a **secure_uri**, it need a HEADER named **htc1s** to validate.

## htc1s:
A plain text contain **SN** and **time_msec** from checkin response.
```
time_msec: 1532274255306
SN: CC55TYG07414
```
### Method
```Csharp
public string getHTC1S(long timestamp)
{
    string htc1s = SN + timestamp;
    if (timestamp <= 0)
        return htc1s;
    for (long i = timestamp % 10; ; i = timestamp % 10)
    {
        if (i == 0)
            timestamp /= 10;
        else
        {
            int index = htc1s.Length - (int)i;
            return htc1s.Substring(index) + htc1s.Remove(index);
        }
    }
}
```
```
index = (25 - 6) = 19
orig_htc1s: CC55TYG074141532274 255306
post_htc1s: 255306 CC55TYG074141532274
```
### Download Request
```HTTP
GET /secure/OTA_PERFUME_UHL_O80_SENSE90GP_MR_hTC_Asia_TW_3.16.709.3_R1-2.41.709.73_release_5196641w4lmj50mv7k4fxl.zip/surl:kid=77,et=1532360655,h=48767015CF592C14A6B869AD646D661E HTTP/1.1
User-Agent: Android-Checkin/8.0
htc1s: 255306CC55TYG074141532274
Host: fotadl.htc.com
```
