using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000C7 RID: 199
	public class c3dc6b208b04533a4c84b7a3aea9612f3 : RadForm
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x000380EC File Offset: 0x000362EC
		public c3dc6b208b04533a4c84b7a3aea9612f3()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0003811C File Offset: 0x0003631C
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x00038130 File Offset: 0x00036330
		public string FileLocation3DS { get; set; } = "";

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00038144 File Offset: 0x00036344
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00038158 File Offset: 0x00036358
		public string FileLocationWiiU { get; set; } = "";

		// Token: 0x06000702 RID: 1794 RVA: 0x0003816C File Offset: 0x0003636C
		private void c5bbfa4d40c3bce17c418540936e003ca(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cff1cd87872f0aa9f3216076ebfc60411.Text = this.cff1cd87872f0aa9f3216076ebfc60411.Text.Trim();
			if (this.cff1cd87872f0aa9f3216076ebfc60411.Text.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63136)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3dc6b208b04533a4c84b7a3aea9612f3.c5bbfa4d40c3bce17c418540936e003ca(object, EventArgs)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63173));
				this.cff1cd87872f0aa9f3216076ebfc60411.Text = "";
				return;
			}
			c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = new c866035f717c1c145e269422264e8f519();
			try
			{
				c866035f717c1c145e269422264e8f.cd13dfe553208f0b407836d345c6897d0(this.cff1cd87872f0aa9f3216076ebfc60411.Text);
				this.FileLocationWiiU = this.cff1cd87872f0aa9f3216076ebfc60411.Text;
				base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17096);
				base.Close();
			}
			catch
			{
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63317));
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00038260 File Offset: 0x00036460
		private void cdf58e8590a72e7e37063f6c5ac1635bf(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00038270 File Offset: 0x00036470
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				CheckFileExists = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17100) != 0),
				Multiselect = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17104) != 0),
				Filter = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63420)
			};
			if (openFileDialog.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17108))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3dc6b208b04533a4c84b7a3aea9612f3.c5219955baedc5bea94f35915314962fe(object, EventArgs)).MethodHandle;
				}
				base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17112);
				this.FileLocationWiiU = openFileDialog.FileName;
				base.Close();
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00038300 File Offset: 0x00036500
		private void cf523cd48ec147583d93fc0796120676f(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c6f49ef988d94b37c11e87121dc8cf655.Text.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63471)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3dc6b208b04533a4c84b7a3aea9612f3.cf523cd48ec147583d93fc0796120676f(object, EventArgs)).MethodHandle;
				}
				this.FileLocationWiiU = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63500);
			}
			if (this.c845247cae081f96bc4701a9fe6ba3cdd.Text.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63551)))
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
				this.FileLocation3DS = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63578);
			}
			if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.FileLocation3DS, ""))
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
				if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.FileLocationWiiU, ""))
				{
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63627));
					return;
				}
				for (;;)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17116);
			base.Close();
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00038400 File Offset: 0x00036600
		private void c99e6cbbfe89a639680c6a3b558098bdd(object cd7b28952603b35a45c555982e677363a, DragEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			string[] array = c3dabc61d794f91548c16dc424947af9e.cd24593c859565ebb8c9faabbc5c75bef(cdf15457ee4816989343b6e6e96dd4cfe.Data.GetData(DataFormats.FileDrop));
			if (File.Exists(array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17120)]))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3dc6b208b04533a4c84b7a3aea9612f3.c99e6cbbfe89a639680c6a3b558098bdd(object, DragEventArgs)).MethodHandle;
				}
				base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17124);
				this.FileLocationWiiU = array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17128)];
				base.Close();
				return;
			}
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63769));
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00038490 File Offset: 0x00036690
		private void ce87ecd11bd26926cc9d3cf9e9597e69b(object cd7b28952603b35a45c555982e677363a, DragEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			DragDropEffects effect;
			if (!cdf15457ee4816989343b6e6e96dd4cfe.Data.GetDataPresent(DataFormats.FileDrop))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3dc6b208b04533a4c84b7a3aea9612f3.ce87ecd11bd26926cc9d3cf9e9597e69b(object, DragEventArgs)).MethodHandle;
				}
				effect = (DragDropEffects)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17132);
			}
			else
			{
				effect = (DragDropEffects)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17136);
			}
			cdf15457ee4816989343b6e6e96dd4cfe.Effect = effect;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000384E4 File Offset: 0x000366E4
		private void c2639a655a431b8ae166d6e155632ede7(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000384F4 File Offset: 0x000366F4
		private void c411ed5ec78722dd13a824caf22b5a5a4(object cd7b28952603b35a45c555982e677363a, PaintEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00038504 File Offset: 0x00036704
		private void c9b9340c1897638c816f7c97a4b47c75f(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00038514 File Offset: 0x00036714
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				for (;;)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3dc6b208b04533a4c84b7a3aea9612f3.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0003855C File Offset: 0x0003675C
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c15d9090b6a70d3a3c645fff30223e3a5 = new RadLabel();
			this.c5be6dc6a46fb3c429f407a0bd94ae00a = new RadButton();
			this.cc88cf84905313ad542b0916fffeca13a = new RadGroupBox();
			this.c6f49ef988d94b37c11e87121dc8cf655 = new RadTextBox();
			this.c129f9645be9dc9fb646c5432e51db9a5 = new RadLabel();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c845247cae081f96bc4701a9fe6ba3cdd = new RadTextBox();
			this.c226f954145921ae178aa3238c5370176 = new RadButton();
			this.ccbb46cbb0c94f616726f6fe2c6382b04 = new RadPageView();
			this.cee9eb68f8e87aee9d3246553c1d77f82 = new RadPageViewPage();
			this.c9bdeb87a4d379c2ee399a4438fe91509 = new RadPageViewPage();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29 = new RadGroupBox();
			this.c052ccf41a3ad1f787a00eeef2d674c87 = new RadLabel();
			this.c362e39f066aef56acd25812b83e7da57 = new RadLabel();
			this.c1e664eedc77244516df32f78879cbd6a = new PictureBox();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.ca6b7aa9283df8df606f49cc81dbca4d7 = new RadLabel();
			this.ca6c1cea062503a0a580756cf1f1f0961 = new RadGroupBox();
			this.ccc5dacf15ebade6b686a05805934f475 = new RadLabel();
			this.cff1cd87872f0aa9f3216076ebfc60411 = new RadTextBox();
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18 = new RadLabel();
			this.c15d9090b6a70d3a3c645fff30223e3a5.BeginInit();
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.BeginInit();
			this.cc88cf84905313ad542b0916fffeca13a.BeginInit();
			this.cc88cf84905313ad542b0916fffeca13a.SuspendLayout();
			this.c6f49ef988d94b37c11e87121dc8cf655.BeginInit();
			this.c129f9645be9dc9fb646c5432e51db9a5.BeginInit();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			this.c845247cae081f96bc4701a9fe6ba3cdd.BeginInit();
			this.c226f954145921ae178aa3238c5370176.BeginInit();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.BeginInit();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SuspendLayout();
			this.cee9eb68f8e87aee9d3246553c1d77f82.SuspendLayout();
			this.c9bdeb87a4d379c2ee399a4438fe91509.SuspendLayout();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.BeginInit();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.SuspendLayout();
			this.c052ccf41a3ad1f787a00eeef2d674c87.BeginInit();
			this.c362e39f066aef56acd25812b83e7da57.BeginInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).BeginInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			this.ca6b7aa9283df8df606f49cc81dbca4d7.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.BeginInit();
			this.ccc5dacf15ebade6b686a05805934f475.BeginInit();
			this.cff1cd87872f0aa9f3216076ebfc60411.BeginInit();
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c15d9090b6a70d3a3c645fff30223e3a5.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17140) != 0);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17144);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17148), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17152), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17156), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17160));
			this.c15d9090b6a70d3a3c645fff30223e3a5.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17164), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17168), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17172));
			this.c15d9090b6a70d3a3c645fff30223e3a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17176), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17180));
			this.c15d9090b6a70d3a3c645fff30223e3a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47331);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17184), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17188));
			this.c15d9090b6a70d3a3c645fff30223e3a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17192);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63872);
			this.c15d9090b6a70d3a3c645fff30223e3a5.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17196);
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17200), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17204));
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64180);
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17208), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17212));
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17216);
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64203);
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.Click += this.c5bbfa4d40c3bce17c418540936e003ca;
			this.cc88cf84905313ad542b0916fffeca13a.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17220);
			this.cc88cf84905313ad542b0916fffeca13a.AllowDrop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17224) != 0);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c6f49ef988d94b37c11e87121dc8cf655);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c129f9645be9dc9fb646c5432e51db9a5);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c845247cae081f96bc4701a9fe6ba3cdd);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c226f954145921ae178aa3238c5370176);
			this.cc88cf84905313ad542b0916fffeca13a.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17228);
			this.cc88cf84905313ad542b0916fffeca13a.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17232), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17236), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17240), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17244));
			this.cc88cf84905313ad542b0916fffeca13a.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64235);
			this.cc88cf84905313ad542b0916fffeca13a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17248), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17252));
			this.cc88cf84905313ad542b0916fffeca13a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48126);
			this.cc88cf84905313ad542b0916fffeca13a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17256), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17260));
			this.cc88cf84905313ad542b0916fffeca13a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17264);
			this.cc88cf84905313ad542b0916fffeca13a.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64235);
			this.cc88cf84905313ad542b0916fffeca13a.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c6f49ef988d94b37c11e87121dc8cf655.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17268), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17272));
			this.c6f49ef988d94b37c11e87121dc8cf655.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53921);
			this.c6f49ef988d94b37c11e87121dc8cf655.NullText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64282);
			this.c6f49ef988d94b37c11e87121dc8cf655.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17276), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17280));
			this.c6f49ef988d94b37c11e87121dc8cf655.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17284);
			this.c6f49ef988d94b37c11e87121dc8cf655.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c6f49ef988d94b37c11e87121dc8cf655.TextChanged += this.c9b9340c1897638c816f7c97a4b47c75f;
			this.c129f9645be9dc9fb646c5432e51db9a5.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17288), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17292), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17296), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17300));
			this.c129f9645be9dc9fb646c5432e51db9a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17308));
			this.c129f9645be9dc9fb646c5432e51db9a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62504);
			this.c129f9645be9dc9fb646c5432e51db9a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17316));
			this.c129f9645be9dc9fb646c5432e51db9a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17320);
			this.c129f9645be9dc9fb646c5432e51db9a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64377);
			this.c4553ed186725b714efcccc71bbe10a0f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17324), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17328), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17332), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17336));
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17344));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17348), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17352));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17356);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64531);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17360), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17364), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17368), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17372));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.ForeColor = Color.Green;
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17376), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17380));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Margin = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17384), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17388), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17392), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17396));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17400), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17404));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17408);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64618);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17412), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17416), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17420), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17424));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17428), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17432));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17436), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17440));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17444);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64667);
			this.c845247cae081f96bc4701a9fe6ba3cdd.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17448), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17452));
			this.c845247cae081f96bc4701a9fe6ba3cdd.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64694);
			this.c845247cae081f96bc4701a9fe6ba3cdd.NullText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64717);
			this.c845247cae081f96bc4701a9fe6ba3cdd.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17456), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17460));
			this.c845247cae081f96bc4701a9fe6ba3cdd.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17464);
			this.c845247cae081f96bc4701a9fe6ba3cdd.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c226f954145921ae178aa3238c5370176.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17468), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17472));
			this.c226f954145921ae178aa3238c5370176.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60176);
			this.c226f954145921ae178aa3238c5370176.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17476), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17480));
			this.c226f954145921ae178aa3238c5370176.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17484);
			this.c226f954145921ae178aa3238c5370176.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50059);
			this.c226f954145921ae178aa3238c5370176.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c226f954145921ae178aa3238c5370176.Click += this.cf523cd48ec147583d93fc0796120676f;
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Controls.Add(this.cee9eb68f8e87aee9d3246553c1d77f82);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Controls.Add(this.c9bdeb87a4d379c2ee399a4438fe91509);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17488);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.ItemSizeMode = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17492);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17496), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17500));
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42194);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SelectedPage = this.cee9eb68f8e87aee9d3246553c1d77f82;
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17504), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17508));
			this.ccbb46cbb0c94f616726f6fe2c6382b04.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17512);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64810);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.ViewMode = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17516);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SelectedPageChanged += this.c2639a655a431b8ae166d6e155632ede7;
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.cc88cf84905313ad542b0916fffeca13a);
			this.cee9eb68f8e87aee9d3246553c1d77f82.ItemSize = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17520), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17524));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17532));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42436);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17536), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17540));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64859);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Paint += this.c411ed5ec78722dd13a824caf22b5a5a4;
			this.c9bdeb87a4d379c2ee399a4438fe91509.Controls.Add(this.c1fbb1a3b10ef0c49ba689bd6ae606d29);
			this.c9bdeb87a4d379c2ee399a4438fe91509.ItemSize = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17544), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17548));
			this.c9bdeb87a4d379c2ee399a4438fe91509.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17552), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17556));
			this.c9bdeb87a4d379c2ee399a4438fe91509.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42921);
			this.c9bdeb87a4d379c2ee399a4438fe91509.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17560), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17564));
			this.c9bdeb87a4d379c2ee399a4438fe91509.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64908);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17568);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.c052ccf41a3ad1f787a00eeef2d674c87);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.c362e39f066aef56acd25812b83e7da57);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.c1e664eedc77244516df32f78879cbd6a);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.ca6b7aa9283df8df606f49cc81dbca4d7);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.ca6c1cea062503a0a580756cf1f1f0961);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.ccc5dacf15ebade6b686a05805934f475);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.cff1cd87872f0aa9f3216076ebfc60411);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.c7f9bbe185ff77df9c14fa6ccdbe6aa18);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17572);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64941);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17576), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17580));
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48158);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17584));
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17588), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17592));
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17596);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64941);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17600), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17604), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17608), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17612));
			this.c052ccf41a3ad1f787a00eeef2d674c87.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17616), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17620), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17624));
			this.c052ccf41a3ad1f787a00eeef2d674c87.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17628), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17632));
			this.c052ccf41a3ad1f787a00eeef2d674c87.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49484);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17636), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17640));
			this.c052ccf41a3ad1f787a00eeef2d674c87.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17644);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64974);
			this.c362e39f066aef56acd25812b83e7da57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17648), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17652));
			this.c362e39f066aef56acd25812b83e7da57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42983);
			this.c362e39f066aef56acd25812b83e7da57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17656), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17660));
			this.c362e39f066aef56acd25812b83e7da57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17664);
			this.c362e39f066aef56acd25812b83e7da57.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65152);
			this.c1e664eedc77244516df32f78879cbd6a.Image = c6faa5467be1a4874657b372a49b7c927.filestruct;
			this.c1e664eedc77244516df32f78879cbd6a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17668), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17672));
			this.c1e664eedc77244516df32f78879cbd6a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43700);
			this.c1e664eedc77244516df32f78879cbd6a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17676), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17680));
			this.c1e664eedc77244516df32f78879cbd6a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17684);
			this.c1e664eedc77244516df32f78879cbd6a.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17688) != 0);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17692), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17696));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17700), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17704));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17708);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55830);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17712), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17716));
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65350);
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17720), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17724));
			this.ca6b7aa9283df8df606f49cc81dbca4d7.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17728);
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65363);
			this.ca6c1cea062503a0a580756cf1f1f0961.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17732);
			this.ca6c1cea062503a0a580756cf1f1f0961.AllowDrop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17736) != 0);
			this.ca6c1cea062503a0a580756cf1f1f0961.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65462);
			this.ca6c1cea062503a0a580756cf1f1f0961.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17740), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17744));
			this.ca6c1cea062503a0a580756cf1f1f0961.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48088);
			this.ca6c1cea062503a0a580756cf1f1f0961.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17748), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17752));
			this.ca6c1cea062503a0a580756cf1f1f0961.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17756);
			this.ca6c1cea062503a0a580756cf1f1f0961.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65462);
			this.ca6c1cea062503a0a580756cf1f1f0961.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.ca6c1cea062503a0a580756cf1f1f0961.DragDrop += this.c99e6cbbfe89a639680c6a3b558098bdd;
			this.ca6c1cea062503a0a580756cf1f1f0961.DragEnter += this.ce87ecd11bd26926cc9d3cf9e9597e69b;
			this.ccc5dacf15ebade6b686a05805934f475.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17760), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17764));
			this.ccc5dacf15ebade6b686a05805934f475.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65483);
			this.ccc5dacf15ebade6b686a05805934f475.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17768), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17772));
			this.ccc5dacf15ebade6b686a05805934f475.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17776);
			this.ccc5dacf15ebade6b686a05805934f475.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65496);
			this.cff1cd87872f0aa9f3216076ebfc60411.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17784));
			this.cff1cd87872f0aa9f3216076ebfc60411.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65640);
			this.cff1cd87872f0aa9f3216076ebfc60411.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17788), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17792));
			this.cff1cd87872f0aa9f3216076ebfc60411.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17796);
			this.cff1cd87872f0aa9f3216076ebfc60411.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17800), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17804));
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65653);
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17808), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17812));
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17816);
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65666);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17820), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17824));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17828);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17832), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17836));
			base.Controls.Add(this.ccbb46cbb0c94f616726f6fe2c6382b04);
			base.Controls.Add(this.c5be6dc6a46fb3c429f407a0bd94ae00a);
			base.Controls.Add(this.c15d9090b6a70d3a3c645fff30223e3a5);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17840);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65773);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17844));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17848) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17852) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17856);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65798);
			base.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			base.Load += this.cdf58e8590a72e7e37063f6c5ac1635bf;
			this.c15d9090b6a70d3a3c645fff30223e3a5.EndInit();
			this.c5be6dc6a46fb3c429f407a0bd94ae00a.EndInit();
			this.cc88cf84905313ad542b0916fffeca13a.EndInit();
			this.cc88cf84905313ad542b0916fffeca13a.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17860) != 0);
			this.cc88cf84905313ad542b0916fffeca13a.PerformLayout();
			this.c6f49ef988d94b37c11e87121dc8cf655.EndInit();
			this.c129f9645be9dc9fb646c5432e51db9a5.EndInit();
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			this.c845247cae081f96bc4701a9fe6ba3cdd.EndInit();
			this.c226f954145921ae178aa3238c5370176.EndInit();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.EndInit();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17864) != 0);
			this.cee9eb68f8e87aee9d3246553c1d77f82.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17868) != 0);
			this.c9bdeb87a4d379c2ee399a4438fe91509.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17872) != 0);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.EndInit();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17876) != 0);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.PerformLayout();
			this.c052ccf41a3ad1f787a00eeef2d674c87.EndInit();
			this.c362e39f066aef56acd25812b83e7da57.EndInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).EndInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			this.ca6b7aa9283df8df606f49cc81dbca4d7.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.EndInit();
			this.ccc5dacf15ebade6b686a05805934f475.EndInit();
			this.cff1cd87872f0aa9f3216076ebfc60411.EndInit();
			this.c7f9bbe185ff77df9c14fa6ccdbe6aa18.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17880) != 0);
		}

		// Token: 0x040003F5 RID: 1013
		[CompilerGenerated]
		private string cae028b4ae0aa1881d03fa531d27844d4;

		// Token: 0x040003F6 RID: 1014
		[CompilerGenerated]
		private string c266d4ff10408185a7a8e5d01593ff3c6;

		// Token: 0x040003F7 RID: 1015
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x040003F8 RID: 1016
		private RadLabel c15d9090b6a70d3a3c645fff30223e3a5;

		// Token: 0x040003F9 RID: 1017
		private RadButton c5be6dc6a46fb3c429f407a0bd94ae00a;

		// Token: 0x040003FA RID: 1018
		private RadGroupBox cc88cf84905313ad542b0916fffeca13a;

		// Token: 0x040003FB RID: 1019
		private RadTextBox c6f49ef988d94b37c11e87121dc8cf655;

		// Token: 0x040003FC RID: 1020
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x040003FD RID: 1021
		private RadButton c226f954145921ae178aa3238c5370176;

		// Token: 0x040003FE RID: 1022
		private RadTextBox c845247cae081f96bc4701a9fe6ba3cdd;

		// Token: 0x040003FF RID: 1023
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x04000400 RID: 1024
		private RadPageView ccbb46cbb0c94f616726f6fe2c6382b04;

		// Token: 0x04000401 RID: 1025
		private RadPageViewPage cee9eb68f8e87aee9d3246553c1d77f82;

		// Token: 0x04000402 RID: 1026
		private RadPageViewPage c9bdeb87a4d379c2ee399a4438fe91509;

		// Token: 0x04000403 RID: 1027
		private RadGroupBox c1fbb1a3b10ef0c49ba689bd6ae606d29;

		// Token: 0x04000404 RID: 1028
		private RadLabel c362e39f066aef56acd25812b83e7da57;

		// Token: 0x04000405 RID: 1029
		private PictureBox c1e664eedc77244516df32f78879cbd6a;

		// Token: 0x04000406 RID: 1030
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;

		// Token: 0x04000407 RID: 1031
		private RadLabel ca6b7aa9283df8df606f49cc81dbca4d7;

		// Token: 0x04000408 RID: 1032
		private RadGroupBox ca6c1cea062503a0a580756cf1f1f0961;

		// Token: 0x04000409 RID: 1033
		private RadLabel ccc5dacf15ebade6b686a05805934f475;

		// Token: 0x0400040A RID: 1034
		private RadTextBox cff1cd87872f0aa9f3216076ebfc60411;

		// Token: 0x0400040B RID: 1035
		private RadLabel c7f9bbe185ff77df9c14fa6ccdbe6aa18;

		// Token: 0x0400040C RID: 1036
		private RadLabel c129f9645be9dc9fb646c5432e51db9a5;

		// Token: 0x0400040D RID: 1037
		private RadLabel c052ccf41a3ad1f787a00eeef2d674c87;

		// Token: 0x0400040E RID: 1038
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;
	}
}
