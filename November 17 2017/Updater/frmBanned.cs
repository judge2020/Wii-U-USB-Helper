using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Updater
{
	// Token: 0x02000007 RID: 7
	public partial class frmBanned : Form
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000037A4 File Offset: 0x000019A4
		public frmBanned(string id)
		{
			this.InitializeComponent();
			this.txtId.Text = id + ":" + this.GetIp();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000037CE File Offset: 0x000019CE
		private void frmBanned_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000037D0 File Offset: 0x000019D0
		private string GetIp()
		{
			string result;
			try
			{
				result = new WebClient().DownloadString("http://icanhazip.com/").Trim();
			}
			catch
			{
				result = "";
			}
			return result;
		}
	}
}
