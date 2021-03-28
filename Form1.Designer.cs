namespace C0710_ChatRoom_Server
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.btnShack = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnStartListen = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSendMsgAll = new System.Windows.Forms.Button();
            this.btnShackAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboClient
            // 
            this.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(528, 40);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(207, 20);
            this.cboClient.TabIndex = 37;
            // 
            // btnShack
            // 
            this.btnShack.Location = new System.Drawing.Point(315, 11);
            this.btnShack.Name = "btnShack";
            this.btnShack.Size = new System.Drawing.Size(75, 23);
            this.btnShack.TabIndex = 36;
            this.btnShack.Text = "闪屏";
            this.btnShack.UseVisualStyleBackColor = true;
            this.btnShack.Click += new System.EventHandler(this.btnShack_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(351, 375);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 35;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(270, 376);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 34;
            this.btnChooseFile.Text = "选择文件";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(29, 376);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(235, 21);
            this.txtFilePath.TabIndex = 33;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(435, 375);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 32;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(29, 260);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(481, 109);
            this.txtInput.TabIndex = 31;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(29, 40);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(481, 201);
            this.txtShow.TabIndex = 30;
            // 
            // btnStartListen
            // 
            this.btnStartListen.Location = new System.Drawing.Point(234, 12);
            this.btnStartListen.Name = "btnStartListen";
            this.btnStartListen.Size = new System.Drawing.Size(75, 23);
            this.btnStartListen.TabIndex = 29;
            this.btnStartListen.Text = "开始监听";
            this.btnStartListen.UseVisualStyleBackColor = true;
            this.btnStartListen.Click += new System.EventHandler(this.btnStartListen_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(179, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 21);
            this.txtPort.TabIndex = 28;
            this.txtPort.Text = "10001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "Port：";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(29, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(109, 21);
            this.txtIP.TabIndex = 26;
            this.txtIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "IP：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(435, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSendMsgAll
            // 
            this.btnSendMsgAll.Location = new System.Drawing.Point(518, 374);
            this.btnSendMsgAll.Name = "btnSendMsgAll";
            this.btnSendMsgAll.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsgAll.TabIndex = 39;
            this.btnSendMsgAll.Text = "群发消息";
            this.btnSendMsgAll.UseVisualStyleBackColor = true;
            this.btnSendMsgAll.Click += new System.EventHandler(this.btnSendMsgAll_Click);
            // 
            // btnShackAll
            // 
            this.btnShackAll.Location = new System.Drawing.Point(396, 10);
            this.btnShackAll.Name = "btnShackAll";
            this.btnShackAll.Size = new System.Drawing.Size(75, 23);
            this.btnShackAll.TabIndex = 40;
            this.btnShackAll.Text = "群闪屏";
            this.btnShackAll.UseVisualStyleBackColor = true;
            this.btnShackAll.Click += new System.EventHandler(this.btnShackAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 438);
            this.Controls.Add(this.btnShackAll);
            this.Controls.Add(this.btnSendMsgAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboClient);
            this.Controls.Add(this.btnShack);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnStartListen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.Button btnShack;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnStartListen;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSendMsgAll;
        private System.Windows.Forms.Button btnShackAll;
    }
}

