using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Nus_Helper_Shared_Core
{
	// Token: 0x02000002 RID: 2
	public class SafeMailSender
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public SafeMailSender(string from, string subject, string message, string reply_to = "")
		{
			this._subject = subject;
			this._message = message;
			this._reply_to = reply_to;
			this._from = from;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00000278
		// (remove) Token: 0x06000003 RID: 3 RVA: 0x000020B0 File Offset: 0x000002B0
		public event EventHandler<string> MailSent;

		// Token: 0x06000004 RID: 4 RVA: 0x000020E5 File Offset: 0x000002E5
		public void Send()
		{
			Task.Run(delegate
			{
				try
				{
					string @string = Encoding.UTF8.GetString(new WebClient().UploadValues("https://support.wiiuusbhelper.com/sendEmail.php", new NameValueCollection
					{
						{
							"from",
							this._from
						},
						{
							"subject",
							this._subject
						},
						{
							"message",
							this._message
						},
						{
							"reply-to",
							this._reply_to
						}
					}));
					this.MailSent(this, @string);
				}
				catch (Exception ex)
				{
					EventHandler<string> mailSent = this.MailSent;
					if (mailSent != null)
					{
						mailSent(this, ex.ToString());
					}
				}
			});
		}

		// Token: 0x04000002 RID: 2
		private string _from;

		// Token: 0x04000003 RID: 3
		private string _message;

		// Token: 0x04000004 RID: 4
		private string _reply_to;

		// Token: 0x04000005 RID: 5
		private string _subject;
	}
}
