namespace HTCFZ.HTC_OTA_Downloader
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_get_info = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text_device_locale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_device_version = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_device_model = new System.Windows.Forms.TextBox();
            this.text_device_cid = new System.Windows.Forms.TextBox();
            this.text_device_taskid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.check_option_curl = new System.Windows.Forms.CheckBox();
            this.check_option_china = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_bfc_check = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.text_bfc_sku = new System.Windows.Forms.TextBox();
            this.text_bfc_main = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.text_bfc_model = new System.Windows.Forms.TextBox();
            this.text_bfc_cid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_main = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_get_info);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.check_option_curl);
            this.tabPage1.Controls.Add(this.check_option_china);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(312, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_get_info
            // 
            this.button_get_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_get_info.Location = new System.Drawing.Point(6, 326);
            this.button_get_info.Name = "button_get_info";
            this.button_get_info.Size = new System.Drawing.Size(300, 55);
            this.button_get_info.TabIndex = 3;
            this.button_get_info.Tag = "GET";
            this.button_get_info.Text = "GET";
            this.button_get_info.UseVisualStyleBackColor = true;
            this.button_get_info.Click += new System.EventHandler(this.Button_get_info_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.text_device_locale, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.text_device_version, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_device_model, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_device_cid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_device_taskid, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // text_device_locale
            // 
            this.text_device_locale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_device_locale.Location = new System.Drawing.Point(88, 165);
            this.text_device_locale.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_device_locale.Name = "text_device_locale";
            this.text_device_locale.Size = new System.Drawing.Size(212, 25);
            this.text_device_locale.TabIndex = 6;
            this.text_device_locale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_device_locale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Download);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = " Locale:";
            // 
            // text_device_version
            // 
            this.text_device_version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_device_version.Location = new System.Drawing.Point(88, 85);
            this.text_device_version.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_device_version.Name = "text_device_version";
            this.text_device_version.Size = new System.Drawing.Size(212, 25);
            this.text_device_version.TabIndex = 3;
            this.text_device_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_device_version.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Download);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Task ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "    CID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "  Model:";
            // 
            // text_device_model
            // 
            this.text_device_model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_device_model.Location = new System.Drawing.Point(88, 5);
            this.text_device_model.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_device_model.Name = "text_device_model";
            this.text_device_model.Size = new System.Drawing.Size(212, 25);
            this.text_device_model.TabIndex = 1;
            this.text_device_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_device_model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Download);
            // 
            // text_device_cid
            // 
            this.text_device_cid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_device_cid.Location = new System.Drawing.Point(88, 45);
            this.text_device_cid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_device_cid.Name = "text_device_cid";
            this.text_device_cid.Size = new System.Drawing.Size(212, 25);
            this.text_device_cid.TabIndex = 2;
            this.text_device_cid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_device_cid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Download);
            // 
            // text_device_taskid
            // 
            this.text_device_taskid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_device_taskid.Location = new System.Drawing.Point(88, 125);
            this.text_device_taskid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_device_taskid.Name = "text_device_taskid";
            this.text_device_taskid.Size = new System.Drawing.Size(212, 25);
            this.text_device_taskid.TabIndex = 5;
            this.text_device_taskid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_device_taskid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Download);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(3, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Optional";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // check_option_curl
            // 
            this.check_option_curl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_option_curl.AutoSize = true;
            this.check_option_curl.Location = new System.Drawing.Point(14, 266);
            this.check_option_curl.Name = "check_option_curl";
            this.check_option_curl.Size = new System.Drawing.Size(235, 22);
            this.check_option_curl.TabIndex = 4;
            this.check_option_curl.Text = "Generate cURL command line";
            this.check_option_curl.UseVisualStyleBackColor = true;
            // 
            // check_option_china
            // 
            this.check_option_china.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_option_china.AutoSize = true;
            this.check_option_china.Location = new System.Drawing.Point(14, 238);
            this.check_option_china.Name = "check_option_china";
            this.check_option_china.Size = new System.Drawing.Size(259, 22);
            this.check_option_china.TabIndex = 3;
            this.check_option_china.Text = "For China region device (URL)";
            this.check_option_china.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_bfc_check);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(312, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Brute-Force Check";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_bfc_check
            // 
            this.button_bfc_check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_bfc_check.Location = new System.Drawing.Point(6, 326);
            this.button_bfc_check.Name = "button_bfc_check";
            this.button_bfc_check.Size = new System.Drawing.Size(300, 55);
            this.button_bfc_check.TabIndex = 4;
            this.button_bfc_check.Tag = "Check";
            this.button_bfc_check.Text = "Check";
            this.button_bfc_check.UseVisualStyleBackColor = true;
            this.button_bfc_check.Click += new System.EventHandler(this.Button_bfc_check_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.text_bfc_sku, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.text_bfc_main, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.text_bfc_model, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.text_bfc_cid, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 160);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // text_bfc_sku
            // 
            this.text_bfc_sku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_bfc_sku.Location = new System.Drawing.Point(88, 125);
            this.text_bfc_sku.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_bfc_sku.Name = "text_bfc_sku";
            this.text_bfc_sku.Size = new System.Drawing.Size(212, 25);
            this.text_bfc_sku.TabIndex = 4;
            this.text_bfc_sku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_bfc_sku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Bruteforce);
            // 
            // text_bfc_main
            // 
            this.text_bfc_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_bfc_main.Location = new System.Drawing.Point(88, 85);
            this.text_bfc_main.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_bfc_main.Name = "text_bfc_main";
            this.text_bfc_main.Size = new System.Drawing.Size(212, 25);
            this.text_bfc_main.TabIndex = 3;
            this.text_bfc_main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_bfc_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Bruteforce);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "   Main:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "    CID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "  Model:";
            // 
            // text_bfc_model
            // 
            this.text_bfc_model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_bfc_model.Location = new System.Drawing.Point(88, 5);
            this.text_bfc_model.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_bfc_model.Name = "text_bfc_model";
            this.text_bfc_model.Size = new System.Drawing.Size(212, 25);
            this.text_bfc_model.TabIndex = 1;
            this.text_bfc_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_bfc_model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Bruteforce);
            // 
            // text_bfc_cid
            // 
            this.text_bfc_cid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_bfc_cid.Location = new System.Drawing.Point(88, 45);
            this.text_bfc_cid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.text_bfc_cid.Name = "text_bfc_cid";
            this.text_bfc_cid.Size = new System.Drawing.Size(212, 25);
            this.text_bfc_cid.TabIndex = 2;
            this.text_bfc_cid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_bfc_cid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Bruteforce);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "    SKU:";
            // 
            // text_main
            // 
            this.text_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
            this.text_main.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_main.ForeColor = System.Drawing.Color.White;
            this.text_main.Location = new System.Drawing.Point(337, 12);
            this.text_main.Multiline = true;
            this.text_main.Name = "text_main";
            this.text_main.ReadOnly = true;
            this.text_main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_main.Size = new System.Drawing.Size(385, 418);
            this.text_main.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(11, 441);
            this.progressBar.Margin = new System.Windows.Forms.Padding(1);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(711, 30);
            this.progressBar.TabIndex = 2;
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.text_main);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmGUI";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTC OTA Downloader";
            this.Load += new System.EventHandler(this.FmGUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_device_version;
        private System.Windows.Forms.TextBox text_device_model;
        private System.Windows.Forms.TextBox text_device_cid;
        private System.Windows.Forms.TextBox text_device_taskid;
        private System.Windows.Forms.TextBox text_main;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_device_locale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_option_china;
        private System.Windows.Forms.CheckBox check_option_curl;
        private System.Windows.Forms.Button button_get_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox text_bfc_main;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_bfc_model;
        private System.Windows.Forms.TextBox text_bfc_cid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_bfc_sku;
        private System.Windows.Forms.Button button_bfc_check;
    }
}

