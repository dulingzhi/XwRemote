namespace XwRemote.Misc
{
    partial class Scanner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner));
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.ipAddressControlFrom = new IPAddressControlLib.IPAddressControl();
            this.ipAddressControlTo = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartNoARP = new System.Windows.Forms.Button();
            this.listViewHosts = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textTcpPorts = new System.Windows.Forms.TextBox();
            this.checkTcpPorts = new System.Windows.Forms.CheckBox();
            this.Pump = new System.Windows.Forms.Timer(this.components);
            this.checkBoxHideDead = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericTestTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkDNS = new System.Windows.Forms.CheckBox();
            this.checkNetBios = new System.Windows.Forms.CheckBox();
            this.buttonStartARP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericTestTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderDescription = "尝试发现网络中可以连接的主机";
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.magnifier;
            this.dialogHeader1.HeaderTitle = "网络扫描";
            this.dialogHeader1.Location = new System.Drawing.Point(0, 0);
            this.dialogHeader1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dialogHeader1.Name = "dialogHeader1";
            this.dialogHeader1.Size = new System.Drawing.Size(1510, 69);
            this.dialogHeader1.TabIndex = 1;
            // 
            // ipAddressControlFrom
            // 
            this.ipAddressControlFrom.AllowInternalTab = false;
            this.ipAddressControlFrom.AutoHeight = true;
            this.ipAddressControlFrom.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControlFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControlFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControlFrom.Location = new System.Drawing.Point(142, 82);
            this.ipAddressControlFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControlFrom.MinimumSize = new System.Drawing.Size(141, 28);
            this.ipAddressControlFrom.Name = "ipAddressControlFrom";
            this.ipAddressControlFrom.ReadOnly = false;
            this.ipAddressControlFrom.Size = new System.Drawing.Size(212, 28);
            this.ipAddressControlFrom.TabIndex = 2;
            this.ipAddressControlFrom.Text = "...";
            this.ipAddressControlFrom.TextChanged += new System.EventHandler(this.ipAddressControlFrom_TextChanged);
            // 
            // ipAddressControlTo
            // 
            this.ipAddressControlTo.AllowInternalTab = false;
            this.ipAddressControlTo.AutoHeight = true;
            this.ipAddressControlTo.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControlTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControlTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControlTo.Location = new System.Drawing.Point(315, 82);
            this.ipAddressControlTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControlTo.MinimumSize = new System.Drawing.Size(141, 28);
            this.ipAddressControlTo.Name = "ipAddressControlTo";
            this.ipAddressControlTo.ReadOnly = false;
            this.ipAddressControlTo.Size = new System.Drawing.Size(212, 28);
            this.ipAddressControlTo.TabIndex = 3;
            this.ipAddressControlTo.Text = "...";
            this.ipAddressControlTo.TextChanged += new System.EventHandler(this.ipAddressControlTo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP 起始";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "至";
            // 
            // buttonStartNoARP
            // 
            this.buttonStartNoARP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartNoARP.Location = new System.Drawing.Point(1078, 118);
            this.buttonStartNoARP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartNoARP.Name = "buttonStartNoARP";
            this.buttonStartNoARP.Size = new System.Drawing.Size(414, 30);
            this.buttonStartNoARP.TabIndex = 6;
            this.buttonStartNoARP.Text = "开始";
            this.buttonStartNoARP.UseVisualStyleBackColor = true;
            this.buttonStartNoARP.Click += new System.EventHandler(this.buttonStart_NoARP_Click);
            // 
            // listViewHosts
            // 
            this.listViewHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHosts.HideSelection = false;
            this.listViewHosts.Location = new System.Drawing.Point(18, 179);
            this.listViewHosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewHosts.Name = "listViewHosts";
            this.listViewHosts.Size = new System.Drawing.Size(1472, 768);
            this.listViewHosts.TabIndex = 7;
            this.listViewHosts.UseCompatibleStateImageBehavior = false;
            this.listViewHosts.View = System.Windows.Forms.View.Details;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(18, 155);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1474, 15);
            this.progressBar.TabIndex = 8;
            // 
            // textTcpPorts
            // 
            this.textTcpPorts.Location = new System.Drawing.Point(766, 82);
            this.textTcpPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTcpPorts.Name = "textTcpPorts";
            this.textTcpPorts.Size = new System.Drawing.Size(301, 28);
            this.textTcpPorts.TabIndex = 10;
            // 
            // checkTcpPorts
            // 
            this.checkTcpPorts.AutoSize = true;
            this.checkTcpPorts.Location = new System.Drawing.Point(632, 84);
            this.checkTcpPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkTcpPorts.Name = "checkTcpPorts";
            this.checkTcpPorts.Size = new System.Drawing.Size(124, 22);
            this.checkTcpPorts.TabIndex = 9;
            this.checkTcpPorts.Text = "检查端口号";
            this.checkTcpPorts.UseVisualStyleBackColor = true;
            this.checkTcpPorts.CheckedChanged += new System.EventHandler(this.checkTcpPorts_CheckedChanged);
            // 
            // Pump
            // 
            this.Pump.Tick += new System.EventHandler(this.Pump_Tick);
            // 
            // checkBoxHideDead
            // 
            this.checkBoxHideDead.AutoSize = true;
            this.checkBoxHideDead.Checked = true;
            this.checkBoxHideDead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHideDead.Location = new System.Drawing.Point(315, 120);
            this.checkBoxHideDead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHideDead.Name = "checkBoxHideDead";
            this.checkBoxHideDead.Size = new System.Drawing.Size(133, 22);
            this.checkBoxHideDead.TabIndex = 11;
            this.checkBoxHideDead.Text = "隐藏无效 IP";
            this.checkBoxHideDead.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "超时 (ms)";
            // 
            // numericTestTimeout
            // 
            this.numericTestTimeout.Location = new System.Drawing.Point(766, 119);
            this.numericTestTimeout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericTestTimeout.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTestTimeout.Name = "numericTestTimeout";
            this.numericTestTimeout.Size = new System.Drawing.Size(303, 28);
            this.numericTestTimeout.TabIndex = 13;
            this.numericTestTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericMaxThreads
            // 
            this.numericMaxThreads.Location = new System.Drawing.Point(142, 119);
            this.numericMaxThreads.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericMaxThreads.Name = "numericMaxThreads";
            this.numericMaxThreads.Size = new System.Drawing.Size(130, 28);
            this.numericMaxThreads.TabIndex = 15;
            this.numericMaxThreads.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "最大线程数";
            // 
            // checkDNS
            // 
            this.checkDNS.AutoSize = true;
            this.checkDNS.Checked = true;
            this.checkDNS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDNS.Location = new System.Drawing.Point(466, 86);
            this.checkDNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDNS.Name = "checkDNS";
            this.checkDNS.Size = new System.Drawing.Size(106, 22);
            this.checkDNS.TabIndex = 16;
            this.checkDNS.Text = "检查 DNS";
            this.checkDNS.UseVisualStyleBackColor = true;
            // 
            // checkNetBios
            // 
            this.checkNetBios.AutoSize = true;
            this.checkNetBios.Checked = true;
            this.checkNetBios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNetBios.Location = new System.Drawing.Point(466, 120);
            this.checkNetBios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkNetBios.Name = "checkNetBios";
            this.checkNetBios.Size = new System.Drawing.Size(142, 22);
            this.checkNetBios.TabIndex = 17;
            this.checkNetBios.Text = "检查 NetBIOS";
            this.checkNetBios.UseVisualStyleBackColor = true;
            // 
            // buttonStartARP
            // 
            this.buttonStartARP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartARP.Location = new System.Drawing.Point(1078, 80);
            this.buttonStartARP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartARP.Name = "buttonStartARP";
            this.buttonStartARP.Size = new System.Drawing.Size(414, 30);
            this.buttonStartARP.TabIndex = 18;
            this.buttonStartARP.Text = "开始";
            this.buttonStartARP.UseVisualStyleBackColor = true;
            this.buttonStartARP.Click += new System.EventHandler(this.buttonStart_ARP_Click);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 965);
            this.Controls.Add(this.buttonStartARP);
            this.Controls.Add(this.checkNetBios);
            this.Controls.Add(this.checkDNS);
            this.Controls.Add(this.numericMaxThreads);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericTestTimeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxHideDead);
            this.Controls.Add(this.textTcpPorts);
            this.Controls.Add(this.checkTcpPorts);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listViewHosts);
            this.Controls.Add(this.buttonStartNoARP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddressControlTo);
            this.Controls.Add(this.ipAddressControlFrom);
            this.Controls.Add(this.dialogHeader1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Scanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XwRemote 网络扫描";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scanner_FormClosing);
            this.Load += new System.EventHandler(this.Scanner_Load);
            this.Resize += new System.EventHandler(this.Scanner_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericTestTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private IPAddressControlLib.IPAddressControl ipAddressControlFrom;
        private IPAddressControlLib.IPAddressControl ipAddressControlTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartNoARP;
        private System.Windows.Forms.ListView listViewHosts;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textTcpPorts;
        private System.Windows.Forms.CheckBox checkTcpPorts;
        private System.Windows.Forms.Timer Pump;
        private System.Windows.Forms.CheckBox checkBoxHideDead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericTestTimeout;
        private System.Windows.Forms.NumericUpDown numericMaxThreads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkDNS;
        private System.Windows.Forms.CheckBox checkNetBios;
        private System.Windows.Forms.Button buttonStartARP;
    }
}