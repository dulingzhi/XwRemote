namespace XwRemote.Misc
{
    partial class SendError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendError));
            this.ReportBox = new System.Windows.Forms.TextBox();
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // ReportBox
            // 
            this.ReportBox.AcceptsReturn = true;
            this.ReportBox.AcceptsTab = true;
            this.ReportBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBox.Location = new System.Drawing.Point(18, 108);
            this.ReportBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportBox.Multiline = true;
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportBox.Size = new System.Drawing.Size(1096, 392);
            this.ReportBox.TabIndex = 0;
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderDescription = "发现未知错误，您可以简单描述使用场景并反馈给我们";
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.redhealp;
            this.dialogHeader1.HeaderTitle = "发现错误";
            this.dialogHeader1.Location = new System.Drawing.Point(0, 0);
            this.dialogHeader1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dialogHeader1.Name = "dialogHeader1";
            this.dialogHeader1.Size = new System.Drawing.Size(1134, 69);
            this.dialogHeader1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(850, 706);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(266, 32);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消，不发送";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(572, 706);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(266, 32);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "发送并关闭";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.AcceptsReturn = true;
            this.CommentBox.AcceptsTab = true;
            this.CommentBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentBox.Location = new System.Drawing.Point(18, 537);
            this.CommentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommentBox.Size = new System.Drawing.Size(1096, 145);
            this.CommentBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 515);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "请简要描述出现场景";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "请检查自动生成的错误报告内容是否包含敏感信息，包括但不限于主机名、账号密码等等";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SendError
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1134, 755);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dialogHeader1);
            this.Controls.Add(this.ReportBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报告错误";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendError_FormClosing);
            this.Load += new System.EventHandler(this.SendError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReportBox;
        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}