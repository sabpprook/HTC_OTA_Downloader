namespace HTC_OTA_Downloader
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.text_cidnum = new System.Windows.Forms.TextBox();
            this.text_version = new System.Windows.Forms.TextBox();
            this.text_model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_execute = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.text_json = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.text_cidnum);
            this.groupBox.Controls.Add(this.text_version);
            this.groupBox.Controls.Add(this.text_model);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.groupBox.Location = new System.Drawing.Point(12, 13);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(410, 144);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Information";
            // 
            // text_cidnum
            // 
            this.text_cidnum.Location = new System.Drawing.Point(135, 104);
            this.text_cidnum.Name = "text_cidnum";
            this.text_cidnum.Size = new System.Drawing.Size(250, 26);
            this.text_cidnum.TabIndex = 5;
            this.text_cidnum.Text = "HTC__621";
            this.text_cidnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_version
            // 
            this.text_version.Location = new System.Drawing.Point(135, 66);
            this.text_version.Name = "text_version";
            this.text_version.Size = new System.Drawing.Size(250, 26);
            this.text_version.TabIndex = 4;
            this.text_version.Text = "2.41.709.73";
            this.text_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_model
            // 
            this.text_model.Location = new System.Drawing.Point(135, 28);
            this.text_model.Name = "text_model";
            this.text_model.Size = new System.Drawing.Size(250, 26);
            this.text_model.TabIndex = 3;
            this.text_model.Text = "htc_pmeuhl";
            this.text_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // btn_execute
            // 
            this.btn_execute.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btn_execute.Location = new System.Drawing.Point(12, 165);
            this.btn_execute.Margin = new System.Windows.Forms.Padding(4);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(280, 50);
            this.btn_execute.TabIndex = 1;
            this.btn_execute.TabStop = false;
            this.btn_execute.Text = "EXECUTE";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 459);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(410, 40);
            this.progressBar.TabIndex = 2;
            // 
            // text_json
            // 
            this.text_json.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_json.Location = new System.Drawing.Point(12, 222);
            this.text_json.Multiline = true;
            this.text_json.Name = "text_json";
            this.text_json.ReadOnly = true;
            this.text_json.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_json.Size = new System.Drawing.Size(410, 231);
            this.text_json.TabIndex = 6;
            this.text_json.TextChanged += new System.EventHandler(this.text_json_TextChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(305, 165);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(124, 22);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "China Varient";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.text_json);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmGUI";
            this.Text = "HTC OTA Downloader";
            this.SizeChanged += new System.EventHandler(this.fmGUI_SizeChanged);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_cidnum;
        private System.Windows.Forms.TextBox text_version;
        private System.Windows.Forms.TextBox text_model;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox text_json;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

