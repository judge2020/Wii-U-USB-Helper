using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000C4 RID: 196
	public class c1d7da5fb47c4831665780b1b86ae5a04 : RadForm
	{
		// Token: 0x060006E4 RID: 1764 RVA: 0x00035A3C File Offset: 0x00033C3C
		public c1d7da5fb47c4831665780b1b86ae5a04()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00035A58 File Offset: 0x00033C58
		public c1d7da5fb47c4831665780b1b86ae5a04(string c8cb81c1d7b44b62690aaecca72a22b50) : this()
		{
			this.c7548576fb42101c87d662504b0b269a2 = c8cb81c1d7b44b62690aaecca72a22b50;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00035A74 File Offset: 0x00033C74
		private void c064a0b0c8b43d3439d0664e45ae17098(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.Close();
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00035A88 File Offset: 0x00033C88
		private void c8624ec00a460453da7b1405b8346a4c5(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			DateTime dateTime = new DateTime(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16076), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16080), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16088), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16096)).ToLocalTime();
			DateTime dateTime2 = new DateTime(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16100), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16104), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16108), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16112), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16116), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16120)).ToLocalTime();
			this.c8f53cf14f79e09da0155d11df6746273.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60876), dateTime.ToShortTimeString(), dateTime2.ToShortTimeString());
			this.ca225603f90c80559315f7f70650082cd.MinDate = DateTime.Now.AddDays(cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(16124));
			this.ca225603f90c80559315f7f70650082cd.DateTimePickerElement.ShowTimePicker = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16132) != 0);
			this.ca225603f90c80559315f7f70650082cd.Format = (DateTimePickerFormat)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16136);
			this.ca225603f90c80559315f7f70650082cd.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
			cc7431c51899b916476c330598db18ed2.c0b398ab350e72b0d64d512bae8520b85(this.ca225603f90c80559315f7f70650082cd.DateTimePickerElement.CurrentBehavior).DropDownMinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16140), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16144));
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00035C10 File Offset: 0x00033E10
		private bool c89b358ed9915cd9520b8f0686f846082(string cb07f192fd82b2df266a3dc555bfa4a8c)
		{
			bool result;
			try
			{
				result = c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(new MailAddress(cb07f192fd82b2df266a3dc555bfa4a8c).Address, cb07f192fd82b2df266a3dc555bfa4a8c);
			}
			catch
			{
				result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16148) != 0);
			}
			return result;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00035C54 File Offset: 0x00033E54
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new cc699ab73a45b4cd7a2e7076df2cf126e().ShowDialog();
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00035C70 File Offset: 0x00033E70
		private void c63e21c6c40ddaf3c8ddb760c8db33bc0(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00035C80 File Offset: 0x00033E80
		private void c18f5ad753944d1bcf2958bc4f2ef83e5(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c1d7da5fb47c4831665780b1b86ae5a04.ce4d665af4c6b2a5da6bd414156283a1d ce4d665af4c6b2a5da6bd414156283a1d = new c1d7da5fb47c4831665780b1b86ae5a04.ce4d665af4c6b2a5da6bd414156283a1d();
			ce4d665af4c6b2a5da6bd414156283a1d.c4404a159870bf55bb6f111e66e59e82d = this;
			this.c27f701090694564c1f319d5605e9744e.Text = this.c27f701090694564c1f319d5605e9744e.Text.Trim();
			if (this.c27f701090694564c1f319d5605e9744e.Text.Length < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16152))
			{
				for (;;)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c1d7da5fb47c4831665780b1b86ae5a04.c18f5ad753944d1bcf2958bc4f2ef83e5(object, EventArgs)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50552));
				return;
			}
			if (!this.c89b358ed9915cd9520b8f0686f846082(this.c8a05c92f77763b22cbd205811e828e9e.Text))
			{
				for (;;)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61166));
				return;
			}
			string text = this.c27f701090694564c1f319d5605e9744e.Text.Trim();
			if (this.c856f1720cf68b0b88a486b9383b4248d.Checked)
			{
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				text = c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, Environment.NewLine, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61312), TimeZoneInfo.ConvertTimeFromUtc(this.ca225603f90c80559315f7f70650082cd.Value.ToUniversalTime(), TimeZoneInfo.FindSystemTimeZoneById(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61415)))));
			}
			if (this.c7548576fb42101c87d662504b0b269a2 != null)
			{
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				text = c009279a45243b14127222aa793e3eb2e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, Environment.NewLine, Environment.NewLine, this.c7548576fb42101c87d662504b0b269a2);
			}
			c80c398cf4e6b2fb091b88536098e2d6b c80c398cf4e6b2fb091b88536098e2d6b = new c80c398cf4e6b2fb091b88536098e2d6b(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61458), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61509), text, this.c8a05c92f77763b22cbd205811e828e9e.Text.Trim());
			ce4d665af4c6b2a5da6bd414156283a1d.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61536), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16156) != 0);
			c80c398cf4e6b2fb091b88536098e2d6b.c5d9ebe1d817df2cbd911e6ff282ee099 += ce4d665af4c6b2a5da6bd414156283a1d.c9f248b26419aaa9a4e82d4a452400181;
			c80c398cf4e6b2fb091b88536098e2d6b.c6ab500c9dee17a8b7221ca64ea543b6d();
			ce4d665af4c6b2a5da6bd414156283a1d.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00035E68 File Offset: 0x00034068
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c1d7da5fb47c4831665780b1b86ae5a04.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
				{
					for (;;)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00035EB0 File Offset: 0x000340B0
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cf84308e6d808d5bbedd8dbe0a8775cbd.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.c592f692f8daf7265b8c262403f950fb2 = new PictureBox();
			this.cde04604bc941a29effc5e70b9bec7abf = new RadButton();
			this.c80dc0c21b9c29539eabce849089ab43c = new RadButton();
			this.c27f701090694564c1f319d5605e9744e = new RadTextBox();
			this.c8a05c92f77763b22cbd205811e828e9e = new RadTextBox();
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d = new RadLabel();
			this.c7ec1f8ef4425fd983e05da9fcb205ade = new RadLabel();
			this.cc322a26d8faeea856bbff3807a162463 = new RadLabel();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.ca6c1cea062503a0a580756cf1f1f0961 = new RadGroupBox();
			this.ca225603f90c80559315f7f70650082cd = new RadDateTimePicker();
			this.c362e39f066aef56acd25812b83e7da57 = new RadLabel();
			this.c856f1720cf68b0b88a486b9383b4248d = new RadCheckBox();
			this.c8f53cf14f79e09da0155d11df6746273 = new RadLabel();
			((ISupportInitialize)this.c592f692f8daf7265b8c262403f950fb2).BeginInit();
			this.cde04604bc941a29effc5e70b9bec7abf.BeginInit();
			this.c80dc0c21b9c29539eabce849089ab43c.BeginInit();
			this.c27f701090694564c1f319d5605e9744e.BeginInit();
			this.c8a05c92f77763b22cbd205811e828e9e.BeginInit();
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.BeginInit();
			this.c7ec1f8ef4425fd983e05da9fcb205ade.BeginInit();
			this.cc322a26d8faeea856bbff3807a162463.BeginInit();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.SuspendLayout();
			this.ca225603f90c80559315f7f70650082cd.BeginInit();
			this.c362e39f066aef56acd25812b83e7da57.BeginInit();
			this.c856f1720cf68b0b88a486b9383b4248d.BeginInit();
			this.c8f53cf14f79e09da0155d11df6746273.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c592f692f8daf7265b8c262403f950fb2.Image = c6faa5467be1a4874657b372a49b7c927.logo;
			this.c592f692f8daf7265b8c262403f950fb2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16160), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16164));
			this.c592f692f8daf7265b8c262403f950fb2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51457);
			this.c592f692f8daf7265b8c262403f950fb2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16168), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16172));
			this.c592f692f8daf7265b8c262403f950fb2.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16176);
			this.c592f692f8daf7265b8c262403f950fb2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16180);
			this.c592f692f8daf7265b8c262403f950fb2.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16184) != 0);
			this.cde04604bc941a29effc5e70b9bec7abf.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16188), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16192));
			this.cde04604bc941a29effc5e70b9bec7abf.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51688);
			this.cde04604bc941a29effc5e70b9bec7abf.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16196), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16200));
			this.cde04604bc941a29effc5e70b9bec7abf.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16204);
			this.cde04604bc941a29effc5e70b9bec7abf.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51711);
			this.cde04604bc941a29effc5e70b9bec7abf.Click += this.c064a0b0c8b43d3439d0664e45ae17098;
			this.c80dc0c21b9c29539eabce849089ab43c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16208), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16212));
			this.c80dc0c21b9c29539eabce849089ab43c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51648);
			this.c80dc0c21b9c29539eabce849089ab43c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16216), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16220));
			this.c80dc0c21b9c29539eabce849089ab43c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16224);
			this.c80dc0c21b9c29539eabce849089ab43c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51669);
			this.c80dc0c21b9c29539eabce849089ab43c.Click += this.c18f5ad753944d1bcf2958bc4f2ef83e5;
			this.c27f701090694564c1f319d5605e9744e.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16228) != 0);
			this.c27f701090694564c1f319d5605e9744e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16232), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16236));
			this.c27f701090694564c1f319d5605e9744e.Multiline = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16240) != 0);
			this.c27f701090694564c1f319d5605e9744e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51627);
			this.c27f701090694564c1f319d5605e9744e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16244), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16248));
			this.c27f701090694564c1f319d5605e9744e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16252);
			this.c8a05c92f77763b22cbd205811e828e9e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16256), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16260));
			this.c8a05c92f77763b22cbd205811e828e9e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51610);
			this.c8a05c92f77763b22cbd205811e828e9e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16264), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16268));
			this.c8a05c92f77763b22cbd205811e828e9e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16272);
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16276), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16280));
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51568);
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16288));
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16292);
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51593);
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16296), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16300));
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51494);
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16308));
			this.c7ec1f8ef4425fd983e05da9fcb205ade.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16312);
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61595);
			this.cc322a26d8faeea856bbff3807a162463.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16316), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16320));
			this.cc322a26d8faeea856bbff3807a162463.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51156);
			this.cc322a26d8faeea856bbff3807a162463.ShowItemToolTips = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16324) != 0);
			this.cc322a26d8faeea856bbff3807a162463.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16328), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16332));
			this.cc322a26d8faeea856bbff3807a162463.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16336);
			this.cc322a26d8faeea856bbff3807a162463.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61650);
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16344));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16348), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16352));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16356);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61769);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(16360), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16364), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16368), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16372));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16376), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16380));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16384), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16388));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16392);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50221);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.ForeColor = Color.Red;
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16396), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16400));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16404), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16408));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16412);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(61800);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16416), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16420));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16424), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16428));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16432);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62146);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			this.ca6c1cea062503a0a580756cf1f1f0961.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16436);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c8f53cf14f79e09da0155d11df6746273);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.ca225603f90c80559315f7f70650082cd);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c362e39f066aef56acd25812b83e7da57);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c856f1720cf68b0b88a486b9383b4248d);
			this.ca6c1cea062503a0a580756cf1f1f0961.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62227);
			this.ca6c1cea062503a0a580756cf1f1f0961.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16440), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16444));
			this.ca6c1cea062503a0a580756cf1f1f0961.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48088);
			this.ca6c1cea062503a0a580756cf1f1f0961.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16448), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16452));
			this.ca6c1cea062503a0a580756cf1f1f0961.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16456);
			this.ca6c1cea062503a0a580756cf1f1f0961.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62227);
			this.ca225603f90c80559315f7f70650082cd.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16460), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16464));
			this.ca225603f90c80559315f7f70650082cd.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62262);
			this.ca225603f90c80559315f7f70650082cd.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16468), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16472));
			this.ca225603f90c80559315f7f70650082cd.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16476);
			this.ca225603f90c80559315f7f70650082cd.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16480) != 0);
			this.ca225603f90c80559315f7f70650082cd.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62283);
			this.ca225603f90c80559315f7f70650082cd.Value = new DateTime(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16484), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16488), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16492), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16496), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16504), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16508));
			this.ca225603f90c80559315f7f70650082cd.ValueChanged += this.c63e21c6c40ddaf3c8ddb760c8db33bc0;
			this.c362e39f066aef56acd25812b83e7da57.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(16512), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16516), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16520), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16524));
			this.c362e39f066aef56acd25812b83e7da57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16532));
			this.c362e39f066aef56acd25812b83e7da57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42983);
			this.c362e39f066aef56acd25812b83e7da57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16536), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16540));
			this.c362e39f066aef56acd25812b83e7da57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16544);
			this.c362e39f066aef56acd25812b83e7da57.Text = componentResourceManager.GetString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62336));
			this.c856f1720cf68b0b88a486b9383b4248d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16548), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16552));
			this.c856f1720cf68b0b88a486b9383b4248d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62365);
			this.c856f1720cf68b0b88a486b9383b4248d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16556), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16560));
			this.c856f1720cf68b0b88a486b9383b4248d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16564);
			this.c856f1720cf68b0b88a486b9383b4248d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62392);
			this.c8f53cf14f79e09da0155d11df6746273.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16568), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16572));
			this.c8f53cf14f79e09da0155d11df6746273.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62479);
			this.c8f53cf14f79e09da0155d11df6746273.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16576), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16580));
			this.c8f53cf14f79e09da0155d11df6746273.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16584);
			this.c8f53cf14f79e09da0155d11df6746273.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62504);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(16588), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(16592));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16596);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16600), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16604));
			base.Controls.Add(this.ca6c1cea062503a0a580756cf1f1f0961);
			base.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			base.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			base.Controls.Add(this.cc322a26d8faeea856bbff3807a162463);
			base.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			base.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			base.Controls.Add(this.c592f692f8daf7265b8c262403f950fb2);
			base.Controls.Add(this.cde04604bc941a29effc5e70b9bec7abf);
			base.Controls.Add(this.c80dc0c21b9c29539eabce849089ab43c);
			base.Controls.Add(this.c27f701090694564c1f319d5605e9744e);
			base.Controls.Add(this.c8a05c92f77763b22cbd205811e828e9e);
			base.Controls.Add(this.cf5e2be23bd773eb6fca2c7e8ea20a44d);
			base.Controls.Add(this.c7ec1f8ef4425fd983e05da9fcb205ade);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16608);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62523);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16612) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16616) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16620);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62544);
			base.Load += this.c8624ec00a460453da7b1405b8346a4c5;
			((ISupportInitialize)this.c592f692f8daf7265b8c262403f950fb2).EndInit();
			this.cde04604bc941a29effc5e70b9bec7abf.EndInit();
			this.c80dc0c21b9c29539eabce849089ab43c.EndInit();
			this.c27f701090694564c1f319d5605e9744e.EndInit();
			this.c8a05c92f77763b22cbd205811e828e9e.EndInit();
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.EndInit();
			this.c7ec1f8ef4425fd983e05da9fcb205ade.EndInit();
			this.cc322a26d8faeea856bbff3807a162463.EndInit();
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16624) != 0);
			this.ca6c1cea062503a0a580756cf1f1f0961.PerformLayout();
			this.ca225603f90c80559315f7f70650082cd.EndInit();
			this.c362e39f066aef56acd25812b83e7da57.EndInit();
			this.c856f1720cf68b0b88a486b9383b4248d.EndInit();
			this.c8f53cf14f79e09da0155d11df6746273.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16628) != 0);
			base.PerformLayout();
		}

		// Token: 0x040003D1 RID: 977
		private string c7548576fb42101c87d662504b0b269a2;

		// Token: 0x040003D2 RID: 978
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x040003D3 RID: 979
		private PictureBox c592f692f8daf7265b8c262403f950fb2;

		// Token: 0x040003D4 RID: 980
		private RadButton cde04604bc941a29effc5e70b9bec7abf;

		// Token: 0x040003D5 RID: 981
		private RadButton c80dc0c21b9c29539eabce849089ab43c;

		// Token: 0x040003D6 RID: 982
		private RadTextBox c27f701090694564c1f319d5605e9744e;

		// Token: 0x040003D7 RID: 983
		private RadTextBox c8a05c92f77763b22cbd205811e828e9e;

		// Token: 0x040003D8 RID: 984
		private RadLabel cf5e2be23bd773eb6fca2c7e8ea20a44d;

		// Token: 0x040003D9 RID: 985
		private RadLabel c7ec1f8ef4425fd983e05da9fcb205ade;

		// Token: 0x040003DA RID: 986
		private RadLabel cc322a26d8faeea856bbff3807a162463;

		// Token: 0x040003DB RID: 987
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x040003DC RID: 988
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x040003DD RID: 989
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;

		// Token: 0x040003DE RID: 990
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;

		// Token: 0x040003DF RID: 991
		private RadGroupBox ca6c1cea062503a0a580756cf1f1f0961;

		// Token: 0x040003E0 RID: 992
		private RadDateTimePicker ca225603f90c80559315f7f70650082cd;

		// Token: 0x040003E1 RID: 993
		private RadLabel c362e39f066aef56acd25812b83e7da57;

		// Token: 0x040003E2 RID: 994
		private RadCheckBox c856f1720cf68b0b88a486b9383b4248d;

		// Token: 0x040003E3 RID: 995
		private RadLabel c8f53cf14f79e09da0155d11df6746273;

		// Token: 0x0200015E RID: 350
		[CompilerGenerated]
		private sealed class ce4d665af4c6b2a5da6bd414156283a1d
		{
			// Token: 0x06000990 RID: 2448 RVA: 0x00060690 File Offset: 0x0005E890
			internal void c9f248b26419aaa9a4e82d4a452400181(object cb0d7b0b893a41a39e281ddc32fc698bd, string ccb00690a4dbd11fab9ea8415c60a3154)
			{
				c1d7da5fb47c4831665780b1b86ae5a04.c238f86964de9b3b194d7712fd02a4921 c238f86964de9b3b194d7712fd02a = new c1d7da5fb47c4831665780b1b86ae5a04.c238f86964de9b3b194d7712fd02a4921();
				c238f86964de9b3b194d7712fd02a.c8c38354cddaefb45b9cfcd9ed2838c37 = this;
				c238f86964de9b3b194d7712fd02a.ccb00690a4dbd11fab9ea8415c60a3154 = ccb00690a4dbd11fab9ea8415c60a3154;
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
				this.c4404a159870bf55bb6f111e66e59e82d.Invoke(new Action(c238f86964de9b3b194d7712fd02a.c96104c7506d4733f5a333739d8ac8488));
			}

			// Token: 0x0400071B RID: 1819
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;

			// Token: 0x0400071C RID: 1820
			public c1d7da5fb47c4831665780b1b86ae5a04 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200015F RID: 351
		[CompilerGenerated]
		private sealed class c238f86964de9b3b194d7712fd02a4921
		{
			// Token: 0x06000992 RID: 2450 RVA: 0x000606EC File Offset: 0x0005E8EC
			internal void c96104c7506d4733f5a333739d8ac8488()
			{
				RadMessageBox.Show(this.ccb00690a4dbd11fab9ea8415c60a3154);
				this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.Close();
			}

			// Token: 0x0400071D RID: 1821
			public string ccb00690a4dbd11fab9ea8415c60a3154;

			// Token: 0x0400071E RID: 1822
			public c1d7da5fb47c4831665780b1b86ae5a04.ce4d665af4c6b2a5da6bd414156283a1d c8c38354cddaefb45b9cfcd9ed2838c37;
		}
	}
}
