namespace Updater
{
	// Token: 0x02000008 RID: 8
	public partial class frmError : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003F30 File Offset: 0x00002130
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003F50 File Offset: 0x00002150
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Updater.frmError));
			this.label1 = new global::System.Windows.Forms.Label();
			this.txterror = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtEmail = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(45, 27);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(301, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "I am very sorry but the installer has encountered a critical error.\r\n";
			this.txterror.Location = new global::System.Drawing.Point(48, 54);
			this.txterror.Multiline = true;
			this.txterror.Name = "txterror";
			this.txterror.ReadOnly = true;
			this.txterror.Size = new global::System.Drawing.Size(298, 136);
			this.txterror.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(45, 209);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(307, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Please leave your email below if you wish to require assistance :";
			this.txtEmail.Location = new global::System.Drawing.Point(48, 226);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new global::System.Drawing.Size(298, 20);
			this.txtEmail.TabIndex = 3;
			this.button1.Location = new global::System.Drawing.Point(158, 263);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(390, 301);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.txtEmail);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.txterror);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmError";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "An error has occured";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002C RID: 44
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.TextBox txterror;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.TextBox txtEmail;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button button1;
	}
}
