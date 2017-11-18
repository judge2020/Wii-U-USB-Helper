using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using Nus_Helper_Shared_Core;

namespace Updater
{
	// Token: 0x02000008 RID: 8
	public partial class frmError : Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003E02 File Offset: 0x00002002
		public frmError(Exception ex)
		{
			this.InitializeComponent();
			this.txterror.Text = ex.ToString();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003E24 File Offset: 0x00002024
		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtEmail.Text))
			{
				if (!this.IsValidEmail(this.txtEmail.Text))
				{
					MessageBox.Show("You must specify a valid email address, otherwise we can't reply to you!");
					return;
				}
				SafeMailSender safeMailSender = new SafeMailSender("support@wiiuusbhelper.com", "Updater crash", this.txterror.Text, this.txtEmail.Text.Trim());
				safeMailSender.MailSent += delegate(object s, string result)
				{
					base.Invoke(new Action(delegate
					{
						MessageBox.Show(result);
						this.Close();
					}));
				};
				try
				{
					safeMailSender.Send();
					this.button1.Text = "Sending...";
					this.button1.Enabled = false;
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("An error occured while sending your request. {0}", ex.Message));
					return;
				}
			}
			base.Close();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003EF8 File Offset: 0x000020F8
		private bool IsValidEmail(string email)
		{
			bool result;
			try
			{
				result = (new MailAddress(email).Address == email);
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
