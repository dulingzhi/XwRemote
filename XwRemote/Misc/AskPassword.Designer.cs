namespace XwRemote.Misc
{
    partial class AskPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskPassword));
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(106, 96);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(390, 28);
            this.PasswordBox.TabIndex = 0;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderDescription = "请输入主密码";
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.xwremote1;
            this.dialogHeader1.HeaderTitle = "配置已加密";
            this.dialogHeader1.Location = new System.Drawing.Point(0, 0);
            this.dialogHeader1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dialogHeader1.Name = "dialogHeader1";
            this.dialogHeader1.Size = new System.Drawing.Size(513, 69);
            this.dialogHeader1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "主密码";
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(174, 155);
            this.butOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(159, 51);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "确定";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(342, 155);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(156, 51);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // AskPassword
            // 
            this.AcceptButton = this.butOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(513, 223);
            this.ControlBox = false;
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dialogHeader1);
            this.Controls.Add(this.PasswordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AskPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XwRemote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox PasswordBox;
        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
    }
}