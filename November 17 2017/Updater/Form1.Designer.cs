namespace Updater
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000034D8 File Offset: 0x000016D8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000034F8 File Offset: 0x000016F8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Updater.Form1));
			this.pgBar = new global::ProgressBarEx.ProgressBarEx();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pgBar.BackColor = global::System.Drawing.Color.Transparent;
			this.pgBar.BackgroundColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.pgBar.Font = new global::System.Drawing.Font("Segoe UI Black", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.pgBar.ForeColor = global::System.Drawing.Color.White;
			this.pgBar.GradiantColor = global::System.Drawing.Color.Black;
			this.pgBar.GradiantPosition = global::ProgressBarEx.ProgressBarEx.GradiantArea.Center;
			this.pgBar.Image = null;
			this.pgBar.Location = new global::System.Drawing.Point(102, 31);
			this.pgBar.Name = "pgBar";
			this.pgBar.ProgressColor = global::System.Drawing.Color.Cyan;
			this.pgBar.ShowPercentage = true;
			this.pgBar.Size = new global::System.Drawing.Size(342, 23);
			this.pgBar.Text = "progressBarEx1";
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Updater.Properties.Resources.logo;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(100, 78);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Updater.Properties.Resources.bg;
			base.ClientSize = new global::System.Drawing.Size(450, 82);
			base.Controls.Add(this.pgBar);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Installer";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001D RID: 29
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001E RID: 30
		private global::ProgressBarEx.ProgressBarEx pgBar;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
