namespace Updater
{
	// Token: 0x02000007 RID: 7
	public partial class frmBanned : global::System.Windows.Forms.Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003810 File Offset: 0x00001A10
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003830 File Offset: 0x00001A30
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Updater.frmBanned));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtId = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 48f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(25, 18);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(568, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "ACCESS DENIED";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(91, 101);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(415, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "You have been banned from using the application since your IP has a record of abuse.";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(23, 152);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(235, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "If you think this is an error please contact us at : \r\n ";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.label4.Location = new global::System.Drawing.Point(254, 152);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(233, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "wiiu_usb_helper_inquiries@outlook.com";
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(23, 175);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(157, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Do not forget to mention this id :";
			this.txtId.BackColor = global::System.Drawing.Color.Black;
			this.txtId.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtId.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.txtId.Location = new global::System.Drawing.Point(190, 172);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new global::System.Drawing.Size(248, 20);
			this.txtId.TabIndex = 5;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Red;
			this.label6.Location = new global::System.Drawing.Point(150, 215);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(316, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "WE WILL ONLY REPLY TO LEGITIMATE REQUESTS.";
			this.label7.AutoSize = true;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(23, 127);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(570, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "In order to provide the best service possible, we check your IP against a database which records abuse on the Internet.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(616, 256);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.txtId);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmBanned";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Access denied";
			base.Load += new global::System.EventHandler(this.frmBanned_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000023 RID: 35
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.TextBox txtId;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label7;
	}
}
