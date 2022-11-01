﻿namespace XwRemote.Settings
{
    partial class GlobalSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.dividerPanel1 = new DividerPanel.DividerPanel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.faTabStrip1 = new FarsiLibrary.Win.FATabStrip();
            this.tabSecurity = new FarsiLibrary.Win.FATabStripItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPasswordRepeat = new System.Windows.Forms.TextBox();
            this.butRemovePass = new System.Windows.Forms.Button();
            this.butSetPassword = new System.Windows.Forms.Button();
            this.textMasterPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabFTP = new FarsiLibrary.Win.FATabStripItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.textFixedFolder = new System.Windows.Forms.TextBox();
            this.radioFixed = new System.Windows.Forms.RadioButton();
            this.radioLastUsed = new System.Windows.Forms.RadioButton();
            this.radioMyComputer = new System.Windows.Forms.RadioButton();
            this.radioDesktop = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabSSH = new FarsiLibrary.Win.FATabStripItem();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAutoAcceptKeys = new System.Windows.Forms.CheckBox();
            this.checkBoxCorrectFocus = new System.Windows.Forms.CheckBox();
            this.sshFontSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInterface = new FarsiLibrary.Win.FATabStripItem();
            this.checkCloseToTray = new System.Windows.Forms.CheckBox();
            this.checkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dividerPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).BeginInit();
            this.faTabStrip1.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.tabFTP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSSH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sshFontSize)).BeginInit();
            this.tabInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderDescription = "在这里进行一些全局配置";
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.settings;
            this.dialogHeader1.HeaderTitle = "XwRemote 配置";
            this.dialogHeader1.Location = new System.Drawing.Point(0, 0);
            this.dialogHeader1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dialogHeader1.Name = "dialogHeader1";
            this.dialogHeader1.Size = new System.Drawing.Size(636, 50);
            this.dialogHeader1.TabIndex = 0;
            // 
            // dividerPanel1
            // 
            this.dividerPanel1.AllowDrop = true;
            this.dividerPanel1.BorderSide = System.Windows.Forms.Border3DSide.Top;
            this.dividerPanel1.Controls.Add(this.butCancel);
            this.dividerPanel1.Controls.Add(this.butOK);
            this.dividerPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dividerPanel1.Location = new System.Drawing.Point(0, 403);
            this.dividerPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.dividerPanel1.Name = "dividerPanel1";
            this.dividerPanel1.Size = new System.Drawing.Size(636, 62);
            this.dividerPanel1.TabIndex = 14;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(507, 14);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(112, 32);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(386, 14);
            this.butOK.Margin = new System.Windows.Forms.Padding(4);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(112, 32);
            this.butOK.TabIndex = 0;
            this.butOK.Text = "保存";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            this.butOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butOK_KeyDown);
            // 
            // faTabStrip1
            // 
            this.faTabStrip1.AlwaysShowClose = false;
            this.faTabStrip1.AlwaysShowMenuGlyph = false;
            this.faTabStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faTabStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.faTabStrip1.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabSecurity,
            this.tabFTP,
            this.tabSSH,
            this.tabInterface});
            this.faTabStrip1.Location = new System.Drawing.Point(0, 50);
            this.faTabStrip1.Name = "faTabStrip1";
            this.faTabStrip1.SelectedItem = this.tabInterface;
            this.faTabStrip1.Size = new System.Drawing.Size(636, 353);
            this.faTabStrip1.TabIndex = 15;
            this.faTabStrip1.Text = "faTabStrip1";
            // 
            // tabSecurity
            // 
            this.tabSecurity.CanClose = false;
            this.tabSecurity.Controls.Add(this.label6);
            this.tabSecurity.Controls.Add(this.label5);
            this.tabSecurity.Controls.Add(this.label4);
            this.tabSecurity.Controls.Add(this.label3);
            this.tabSecurity.Controls.Add(this.textPasswordRepeat);
            this.tabSecurity.Controls.Add(this.butRemovePass);
            this.tabSecurity.Controls.Add(this.butSetPassword);
            this.tabSecurity.Controls.Add(this.textMasterPassword);
            this.tabSecurity.Controls.Add(this.label2);
            this.tabSecurity.IsDrawn = true;
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(634, 313);
            this.tabSecurity.TabIndex = 0;
            this.tabSecurity.Title = "安全";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "注意：如果忘记密码将丢失所有配置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "请妥善保管主密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "设置主密码用于加密所有服务器配置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "再次输入";
            // 
            // textPasswordRepeat
            // 
            this.textPasswordRepeat.Location = new System.Drawing.Point(274, 165);
            this.textPasswordRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.textPasswordRepeat.Name = "textPasswordRepeat";
            this.textPasswordRepeat.Size = new System.Drawing.Size(340, 27);
            this.textPasswordRepeat.TabIndex = 1;
            this.textPasswordRepeat.UseSystemPasswordChar = true;
            // 
            // butRemovePass
            // 
            this.butRemovePass.Location = new System.Drawing.Point(333, 244);
            this.butRemovePass.Margin = new System.Windows.Forms.Padding(4);
            this.butRemovePass.Name = "butRemovePass";
            this.butRemovePass.Size = new System.Drawing.Size(284, 32);
            this.butRemovePass.TabIndex = 3;
            this.butRemovePass.Text = "移除密码";
            this.butRemovePass.UseVisualStyleBackColor = true;
            this.butRemovePass.Click += new System.EventHandler(this.butRemovePass_Click);
            // 
            // butSetPassword
            // 
            this.butSetPassword.Location = new System.Drawing.Point(20, 244);
            this.butSetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.butSetPassword.Name = "butSetPassword";
            this.butSetPassword.Size = new System.Drawing.Size(291, 32);
            this.butSetPassword.TabIndex = 2;
            this.butSetPassword.Text = "设置密码";
            this.butSetPassword.UseVisualStyleBackColor = true;
            this.butSetPassword.Click += new System.EventHandler(this.butSetPassword_Click);
            // 
            // textMasterPassword
            // 
            this.textMasterPassword.Location = new System.Drawing.Point(274, 127);
            this.textMasterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textMasterPassword.Name = "textMasterPassword";
            this.textMasterPassword.Size = new System.Drawing.Size(340, 27);
            this.textMasterPassword.TabIndex = 0;
            this.textMasterPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "主密码";
            // 
            // tabFTP
            // 
            this.tabFTP.CanClose = false;
            this.tabFTP.Controls.Add(this.groupBox1);
            this.tabFTP.Controls.Add(this.textBox1);
            this.tabFTP.Image = global::XwRemote.Properties.Resources.ftp;
            this.tabFTP.IsDrawn = true;
            this.tabFTP.Name = "tabFTP";
            this.tabFTP.Size = new System.Drawing.Size(634, 313);
            this.tabFTP.TabIndex = 1;
            this.tabFTP.Title = "文件路径";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseFolder);
            this.groupBox1.Controls.Add(this.textFixedFolder);
            this.groupBox1.Controls.Add(this.radioFixed);
            this.groupBox1.Controls.Add(this.radioLastUsed);
            this.groupBox1.Controls.Add(this.radioMyComputer);
            this.groupBox1.Controls.Add(this.radioDesktop);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(624, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始路径";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(510, 58);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(104, 29);
            this.btnBrowseFolder.TabIndex = 4;
            this.btnBrowseFolder.Text = "浏览";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // textFixedFolder
            // 
            this.textFixedFolder.Location = new System.Drawing.Point(12, 60);
            this.textFixedFolder.Margin = new System.Windows.Forms.Padding(4);
            this.textFixedFolder.Name = "textFixedFolder";
            this.textFixedFolder.Size = new System.Drawing.Size(490, 27);
            this.textFixedFolder.TabIndex = 3;
            // 
            // radioFixed
            // 
            this.radioFixed.AutoSize = true;
            this.radioFixed.Location = new System.Drawing.Point(416, 28);
            this.radioFixed.Margin = new System.Windows.Forms.Padding(4);
            this.radioFixed.Name = "radioFixed";
            this.radioFixed.Size = new System.Drawing.Size(86, 25);
            this.radioFixed.TabIndex = 3;
            this.radioFixed.TabStop = true;
            this.radioFixed.Text = "自定义";
            this.radioFixed.UseVisualStyleBackColor = true;
            this.radioFixed.CheckedChanged += new System.EventHandler(this.radioFixed_CheckedChanged);
            // 
            // radioLastUsed
            // 
            this.radioLastUsed.AutoSize = true;
            this.radioLastUsed.Location = new System.Drawing.Point(285, 28);
            this.radioLastUsed.Margin = new System.Windows.Forms.Padding(4);
            this.radioLastUsed.Name = "radioLastUsed";
            this.radioLastUsed.Size = new System.Drawing.Size(103, 25);
            this.radioLastUsed.TabIndex = 2;
            this.radioLastUsed.TabStop = true;
            this.radioLastUsed.Text = "上次使用";
            this.radioLastUsed.UseVisualStyleBackColor = true;
            // 
            // radioMyComputer
            // 
            this.radioMyComputer.AutoSize = true;
            this.radioMyComputer.Location = new System.Drawing.Point(12, 28);
            this.radioMyComputer.Margin = new System.Windows.Forms.Padding(4);
            this.radioMyComputer.Name = "radioMyComputer";
            this.radioMyComputer.Size = new System.Drawing.Size(103, 25);
            this.radioMyComputer.TabIndex = 0;
            this.radioMyComputer.TabStop = true;
            this.radioMyComputer.Text = "我的电脑";
            this.radioMyComputer.UseVisualStyleBackColor = true;
            // 
            // radioDesktop
            // 
            this.radioDesktop.AutoSize = true;
            this.radioDesktop.Location = new System.Drawing.Point(168, 28);
            this.radioDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.radioDesktop.Name = "radioDesktop";
            this.radioDesktop.Size = new System.Drawing.Size(69, 25);
            this.radioDesktop.TabIndex = 1;
            this.radioDesktop.TabStop = true;
            this.radioDesktop.Text = "桌面";
            this.radioDesktop.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 0;
            // 
            // tabSSH
            // 
            this.tabSSH.CanClose = false;
            this.tabSSH.Controls.Add(this.label7);
            this.tabSSH.Controls.Add(this.checkBoxAutoAcceptKeys);
            this.tabSSH.Controls.Add(this.checkBoxCorrectFocus);
            this.tabSSH.Controls.Add(this.sshFontSize);
            this.tabSSH.Controls.Add(this.label1);
            this.tabSSH.IsDrawn = true;
            this.tabSSH.Name = "tabSSH";
            this.tabSSH.Size = new System.Drawing.Size(634, 313);
            this.tabSSH.TabIndex = 2;
            this.tabSSH.Title = "SSH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "请根据您的 DPI 设置合适的字体大小";
            // 
            // checkBoxAutoAcceptKeys
            // 
            this.checkBoxAutoAcceptKeys.Checked = true;
            this.checkBoxAutoAcceptKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoAcceptKeys.Location = new System.Drawing.Point(88, 72);
            this.checkBoxAutoAcceptKeys.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAutoAcceptKeys.Name = "checkBoxAutoAcceptKeys";
            this.checkBoxAutoAcceptKeys.Size = new System.Drawing.Size(408, 47);
            this.checkBoxAutoAcceptKeys.TabIndex = 3;
            this.checkBoxAutoAcceptKeys.Text = "尝试自动接受密钥";
            this.checkBoxAutoAcceptKeys.UseVisualStyleBackColor = true;
            // 
            // checkBoxCorrectFocus
            // 
            this.checkBoxCorrectFocus.Checked = true;
            this.checkBoxCorrectFocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCorrectFocus.Location = new System.Drawing.Point(88, 127);
            this.checkBoxCorrectFocus.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCorrectFocus.Name = "checkBoxCorrectFocus";
            this.checkBoxCorrectFocus.Size = new System.Drawing.Size(408, 47);
            this.checkBoxCorrectFocus.TabIndex = 2;
            this.checkBoxCorrectFocus.Text = "尝试自动配置Putty，如有问题请禁用该选项";
            this.checkBoxCorrectFocus.UseVisualStyleBackColor = true;
            // 
            // sshFontSize
            // 
            this.sshFontSize.Location = new System.Drawing.Point(88, 17);
            this.sshFontSize.Name = "sshFontSize";
            this.sshFontSize.Size = new System.Drawing.Size(69, 27);
            this.sshFontSize.TabIndex = 1;
            this.sshFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "字体大小";
            // 
            // tabInterface
            // 
            this.tabInterface.CanClose = false;
            this.tabInterface.Controls.Add(this.checkCloseToTray);
            this.tabInterface.Controls.Add(this.checkMinimizeToTray);
            this.tabInterface.IsDrawn = true;
            this.tabInterface.Name = "tabInterface";
            this.tabInterface.Selected = true;
            this.tabInterface.Size = new System.Drawing.Size(634, 332);
            this.tabInterface.TabIndex = 3;
            this.tabInterface.Title = "系统";
            // 
            // checkCloseToTray
            // 
            this.checkCloseToTray.AutoSize = true;
            this.checkCloseToTray.Checked = true;
            this.checkCloseToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCloseToTray.Location = new System.Drawing.Point(309, 21);
            this.checkCloseToTray.Margin = new System.Windows.Forms.Padding(4);
            this.checkCloseToTray.Name = "checkCloseToTray";
            this.checkCloseToTray.Size = new System.Drawing.Size(172, 25);
            this.checkCloseToTray.TabIndex = 4;
            this.checkCloseToTray.Text = "关闭时显示到托盘";
            this.checkCloseToTray.UseVisualStyleBackColor = true;
            // 
            // checkMinimizeToTray
            // 
            this.checkMinimizeToTray.AutoSize = true;
            this.checkMinimizeToTray.Checked = true;
            this.checkMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMinimizeToTray.Location = new System.Drawing.Point(34, 21);
            this.checkMinimizeToTray.Margin = new System.Windows.Forms.Padding(4);
            this.checkMinimizeToTray.Name = "checkMinimizeToTray";
            this.checkMinimizeToTray.Size = new System.Drawing.Size(138, 25);
            this.checkMinimizeToTray.TabIndex = 3;
            this.checkMinimizeToTray.Text = "最小化至托盘";
            this.checkMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // GlobalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(636, 465);
            this.Controls.Add(this.faTabStrip1);
            this.Controls.Add(this.dividerPanel1);
            this.Controls.Add(this.dialogHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global Settings";
            this.dividerPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).EndInit();
            this.faTabStrip1.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            this.tabFTP.ResumeLayout(false);
            this.tabFTP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSSH.ResumeLayout(false);
            this.tabSSH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sshFontSize)).EndInit();
            this.tabInterface.ResumeLayout(false);
            this.tabInterface.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private DividerPanel.DividerPanel dividerPanel1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOK;
        private FarsiLibrary.Win.FATabStrip faTabStrip1;
        private FarsiLibrary.Win.FATabStripItem tabFTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox textFixedFolder;
        private System.Windows.Forms.RadioButton radioFixed;
        private System.Windows.Forms.RadioButton radioLastUsed;
        private System.Windows.Forms.RadioButton radioDesktop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton radioMyComputer;
        private FarsiLibrary.Win.FATabStripItem tabSSH;
        private System.Windows.Forms.NumericUpDown sshFontSize;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.FATabStripItem tabSecurity;
        private System.Windows.Forms.TextBox textMasterPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butRemovePass;
        private System.Windows.Forms.Button butSetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPasswordRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCorrectFocus;
        private FarsiLibrary.Win.FATabStripItem tabInterface;
        private System.Windows.Forms.CheckBox checkCloseToTray;
        private System.Windows.Forms.CheckBox checkMinimizeToTray;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxAutoAcceptKeys;
    }
}