using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace A
{
	// Token: 0x020000BD RID: 189
	public class c39b800e9e165a3cdc1c56c51ebe12109 : RadForm
	{
		// Token: 0x060006A5 RID: 1701 RVA: 0x000311A4 File Offset: 0x0002F3A4
		public c39b800e9e165a3cdc1c56c51ebe12109()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000311C0 File Offset: 0x0002F3C0
		private void cc2a434874b29b4ef1d599598fd8507c1(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			try
			{
				Process.Start(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53257));
			}
			catch
			{
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000311F8 File Offset: 0x0002F3F8
		private void cf3906fff00cf36bf0b21750b1f6089a4(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			string text = Clipboard.GetText().Trim();
			cacd6f8420e56d296adef754f4a362ae7.c8e7d70a80813b008e509638f262462f8(text, c6faa5467be1a4874657b372a49b7c927.keysPub);
			if (cacd6f8420e56d296adef754f4a362ae7.c3fcf5c54f75fc17c7e5ebe876702d817)
			{
				for (;;)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c39b800e9e165a3cdc1c56c51ebe12109.cf3906fff00cf36bf0b21750b1f6089a4(object, EventArgs)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53358));
				Settings.Default.DonationKey = text;
				Settings.Default.Save();
				base.Close();
				return;
			}
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53421));
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00031288 File Offset: 0x0002F488
		private void c08f79f19b3c10be63558f4a1eb9f9f6e(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.Close();
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0003129C File Offset: 0x0002F49C
		private void c6e320f18f0448e2a693faa7dc209d179(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.FormElement.TitleBar.CloseButton.Visibility = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14248);
			Timer timer = new Timer();
			timer.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14252);
			timer.Tick += this.cd063f892431b13c02d849d87d202815b;
			timer.Start();
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000312FC File Offset: 0x0002F4FC
		private void cfb303f644e0e273ff69672d0f5b913d8(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14256), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14260));
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00031328 File Offset: 0x0002F528
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				for (;;)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c39b800e9e165a3cdc1c56c51ebe12109.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00031370 File Offset: 0x0002F570
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cae9f7ebe05c911b4071cd0b20cd93187.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.c1e664eedc77244516df32f78879cbd6a = new PictureBox();
			this.c15d9090b6a70d3a3c645fff30223e3a5 = new RadLabel();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c87804958e268f3cb46688274d00bc3db = new RadButton();
			this.c2c59563e236252031bde3dd9ede0c9a4 = new RadButton();
			this.c8262294e5d0037867d56242c1cad781d = new RadButton();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c6f49ef988d94b37c11e87121dc8cf655 = new RadTextBox();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).BeginInit();
			this.c15d9090b6a70d3a3c645fff30223e3a5.BeginInit();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c87804958e268f3cb46688274d00bc3db.BeginInit();
			this.c2c59563e236252031bde3dd9ede0c9a4.BeginInit();
			this.c8262294e5d0037867d56242c1cad781d.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.c6f49ef988d94b37c11e87121dc8cf655.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c1e664eedc77244516df32f78879cbd6a.Image = c6faa5467be1a4874657b372a49b7c927.logo;
			this.c1e664eedc77244516df32f78879cbd6a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14264), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14268));
			this.c1e664eedc77244516df32f78879cbd6a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43700);
			this.c1e664eedc77244516df32f78879cbd6a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14272), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14276));
			this.c1e664eedc77244516df32f78879cbd6a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14280);
			this.c1e664eedc77244516df32f78879cbd6a.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14284) != 0);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14288), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14292), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14296), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14300));
			this.c15d9090b6a70d3a3c645fff30223e3a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14308));
			this.c15d9090b6a70d3a3c645fff30223e3a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47331);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14316));
			this.c15d9090b6a70d3a3c645fff30223e3a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14320);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53548);
			this.c15d9090b6a70d3a3c645fff30223e3a5.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c4553ed186725b714efcccc71bbe10a0f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14324), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14328), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14332), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14336));
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14344));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14348), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14352));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14356);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = componentResourceManager.GetString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42299));
			this.c4553ed186725b714efcccc71bbe10a0f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14360);
			this.c4553ed186725b714efcccc71bbe10a0f.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c87804958e268f3cb46688274d00bc3db.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14364), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14368));
			this.c87804958e268f3cb46688274d00bc3db.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53625);
			this.c87804958e268f3cb46688274d00bc3db.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14372), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14376));
			this.c87804958e268f3cb46688274d00bc3db.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14380);
			this.c87804958e268f3cb46688274d00bc3db.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53644);
			this.c87804958e268f3cb46688274d00bc3db.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c87804958e268f3cb46688274d00bc3db.Click += this.cc2a434874b29b4ef1d599598fd8507c1;
			this.c2c59563e236252031bde3dd9ede0c9a4.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14384), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14388));
			this.c2c59563e236252031bde3dd9ede0c9a4.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53675);
			this.c2c59563e236252031bde3dd9ede0c9a4.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14392), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14396));
			this.c2c59563e236252031bde3dd9ede0c9a4.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14400);
			this.c2c59563e236252031bde3dd9ede0c9a4.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53702);
			this.c2c59563e236252031bde3dd9ede0c9a4.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c2c59563e236252031bde3dd9ede0c9a4.Click += this.cf3906fff00cf36bf0b21750b1f6089a4;
			this.c8262294e5d0037867d56242c1cad781d.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14404) != 0);
			this.c8262294e5d0037867d56242c1cad781d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14408), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14412));
			this.c8262294e5d0037867d56242c1cad781d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53747);
			this.c8262294e5d0037867d56242c1cad781d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14416), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14420));
			this.c8262294e5d0037867d56242c1cad781d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14424);
			this.c8262294e5d0037867d56242c1cad781d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53764);
			this.c8262294e5d0037867d56242c1cad781d.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c8262294e5d0037867d56242c1cad781d.Click += this.c08f79f19b3c10be63558f4a1eb9f9f6e;
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14428), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14432), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14436), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14440));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14444), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14448), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14452));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14456), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14460));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14464), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14468));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14472);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53789);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Click += this.cfb303f644e0e273ff69672d0f5b913d8;
			this.c6f49ef988d94b37c11e87121dc8cf655.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14476), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14480));
			this.c6f49ef988d94b37c11e87121dc8cf655.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53921);
			this.c6f49ef988d94b37c11e87121dc8cf655.ReadOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14484) != 0);
			this.c6f49ef988d94b37c11e87121dc8cf655.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14488), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14492));
			this.c6f49ef988d94b37c11e87121dc8cf655.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14496);
			this.c6f49ef988d94b37c11e87121dc8cf655.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53257);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14504));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14508), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14512));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14516);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53944);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14520), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14524));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14528);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14532), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14536));
			base.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			base.Controls.Add(this.c6f49ef988d94b37c11e87121dc8cf655);
			base.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			base.Controls.Add(this.c8262294e5d0037867d56242c1cad781d);
			base.Controls.Add(this.c2c59563e236252031bde3dd9ede0c9a4);
			base.Controls.Add(this.c87804958e268f3cb46688274d00bc3db);
			base.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			base.Controls.Add(this.c15d9090b6a70d3a3c645fff30223e3a5);
			base.Controls.Add(this.c1e664eedc77244516df32f78879cbd6a);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14540);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54136);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14544) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14548) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14552);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54159);
			base.Load += this.c6e320f18f0448e2a693faa7dc209d179;
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).EndInit();
			this.c15d9090b6a70d3a3c645fff30223e3a5.EndInit();
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c87804958e268f3cb46688274d00bc3db.EndInit();
			this.c2c59563e236252031bde3dd9ede0c9a4.EndInit();
			this.c8262294e5d0037867d56242c1cad781d.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.c6f49ef988d94b37c11e87121dc8cf655.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14556) != 0);
			base.PerformLayout();
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00031D68 File Offset: 0x0002FF68
		[CompilerGenerated]
		private void cd063f892431b13c02d849d87d202815b(object cb0d7b0b893a41a39e281ddc32fc698bd, EventArgs c26822581df016083af37ec10f7059fe9)
		{
			this.c8262294e5d0037867d56242c1cad781d.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14560) != 0);
		}

		// Token: 0x04000392 RID: 914
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000393 RID: 915
		private PictureBox c1e664eedc77244516df32f78879cbd6a;

		// Token: 0x04000394 RID: 916
		private RadLabel c15d9090b6a70d3a3c645fff30223e3a5;

		// Token: 0x04000395 RID: 917
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x04000396 RID: 918
		private RadButton c87804958e268f3cb46688274d00bc3db;

		// Token: 0x04000397 RID: 919
		private RadButton c2c59563e236252031bde3dd9ede0c9a4;

		// Token: 0x04000398 RID: 920
		private RadButton c8262294e5d0037867d56242c1cad781d;

		// Token: 0x04000399 RID: 921
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x0400039A RID: 922
		private RadTextBox c6f49ef988d94b37c11e87121dc8cf655;

		// Token: 0x0400039B RID: 923
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;
	}
}
