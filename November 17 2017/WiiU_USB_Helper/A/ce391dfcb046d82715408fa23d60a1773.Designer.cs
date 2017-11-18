using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000A9 RID: 169
	public class ce391dfcb046d82715408fa23d60a1773 : RadForm
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x00024DE4 File Offset: 0x00022FE4
		public ce391dfcb046d82715408fa23d60a1773(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			c5409344e1c2b74fa8c9a4d620ccb8d48 c804df2385fde29e562ce6680eeff8d7e = c804bc52f7f79bffee6fd394ef382eb76.c804df2385fde29e562ce6680eeff8d7e;
			this.c7e89fd9e6642579956d1f909f4cbf1e9.ImageLocation = c804df2385fde29e562ce6680eeff8d7e.IconUrl;
			this.c804bc52f7f79bffee6fd394ef382eb76.Text = c804bc52f7f79bffee6fd394ef382eb76.Name;
			GraphicsPath graphicsPath = new GraphicsPath();
			try
			{
				graphicsPath.AddEllipse(new Rectangle(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10268), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10272), this.c7e89fd9e6642579956d1f909f4cbf1e9.Width - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10276), this.c7e89fd9e6642579956d1f909f4cbf1e9.Height - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10280)));
				this.c7e89fd9e6642579956d1f909f4cbf1e9.Region = new Region(graphicsPath);
			}
			finally
			{
				if (graphicsPath != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce391dfcb046d82715408fa23d60a1773..ctor(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
					}
					((IDisposable)graphicsPath).Dispose();
				}
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600058D RID: 1421 RVA: 0x00024EC4 File Offset: 0x000230C4
		// (remove) Token: 0x0600058E RID: 1422 RVA: 0x00024F14 File Offset: 0x00023114
		public event EventHandler cef7287fbe1fe3ee7d4fea0b652d5b687
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.cef7287fbe1fe3ee7d4fea0b652d5b687;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.cef7287fbe1fe3ee7d4fea0b652d5b687, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce391dfcb046d82715408fa23d60a1773.add_cef7287fbe1fe3ee7d4fea0b652d5b687(EventHandler)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.cef7287fbe1fe3ee7d4fea0b652d5b687;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.cef7287fbe1fe3ee7d4fea0b652d5b687, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce391dfcb046d82715408fa23d60a1773.remove_cef7287fbe1fe3ee7d4fea0b652d5b687(EventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00024F64 File Offset: 0x00023164
		public void cc5957c0b466d791dc387469fda39883c()
		{
			try
			{
				base.BeginInvoke(new Action(base.Close));
			}
			catch
			{
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00024F9C File Offset: 0x0002319C
		public void ca61af680c0200b2535f929a71dff69ad(TimeSpan cf1cc9bc7f20e07f3b88f8be0de09f98a)
		{
			ce391dfcb046d82715408fa23d60a1773.c15a4044309c0d4f4e4037bc0ba43b8b6 c15a4044309c0d4f4e4037bc0ba43b8b = new ce391dfcb046d82715408fa23d60a1773.c15a4044309c0d4f4e4037bc0ba43b8b6();
			c15a4044309c0d4f4e4037bc0ba43b8b.c4404a159870bf55bb6f111e66e59e82d = this;
			c15a4044309c0d4f4e4037bc0ba43b8b.cf1cc9bc7f20e07f3b88f8be0de09f98a = cf1cc9bc7f20e07f3b88f8be0de09f98a;
			base.BeginInvoke(new Action(c15a4044309c0d4f4e4037bc0ba43b8b.c5097ecd7774779d65a8be1bd6396716a));
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00024FD4 File Offset: 0x000231D4
		public void cbb155dfe4a555990bbe58cf1ebb59b8a(int cdc2df70fc41ec746908194e6c2324250, c8d217bce073ddc882212f4d0e016403a cef94e12d085457557bbcac9bef54a336)
		{
			ce391dfcb046d82715408fa23d60a1773.c970b0acb9a610449c43c434e790c518a c970b0acb9a610449c43c434e790c518a = new ce391dfcb046d82715408fa23d60a1773.c970b0acb9a610449c43c434e790c518a();
			c970b0acb9a610449c43c434e790c518a.c4404a159870bf55bb6f111e66e59e82d = this;
			c970b0acb9a610449c43c434e790c518a.cdc2df70fc41ec746908194e6c2324250 = cdc2df70fc41ec746908194e6c2324250;
			c970b0acb9a610449c43c434e790c518a.cef94e12d085457557bbcac9bef54a336 = cef94e12d085457557bbcac9bef54a336;
			base.BeginInvoke(new Action(c970b0acb9a610449c43c434e790c518a.c5d1d6ba7b7c3cbd8b7c0d32f6a54c699));
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00025014 File Offset: 0x00023214
		private void c8daf247a347fb120cdbc8f43e7b24bbd(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.FormElement.TitleBar.CloseButton.Visibility = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10004);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00025048 File Offset: 0x00023248
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			EventHandler eventHandler = this.cef7287fbe1fe3ee7d4fea0b652d5b687;
			if (eventHandler == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce391dfcb046d82715408fa23d60a1773.c5219955baedc5bea94f35915314962fe(object, EventArgs)).MethodHandle;
				}
				return;
			}
			eventHandler(this, caa194a1ddc67cd543957fd94f509f2e3.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00025080 File Offset: 0x00023280
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce391dfcb046d82715408fa23d60a1773.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000250C8 File Offset: 0x000232C8
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c85ea689075639e9b68e63c0631f9c4ba = new RadProgressBar();
			this.c804bc52f7f79bffee6fd394ef382eb76 = new RadLabel();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.c26a23c3f9ed64e91c418484270f55fcc = new RadLabel();
			this.c334cd5fa87833f636046cdbd48987d99 = new RadLabel();
			this.c1e664eedc77244516df32f78879cbd6a = new PictureBox();
			this.c7e89fd9e6642579956d1f909f4cbf1e9 = new PictureBox();
			this.c90e121b7434f8af2291ea96c07d8818e = new PictureBox();
			this.c85ea689075639e9b68e63c0631f9c4ba.BeginInit();
			this.c804bc52f7f79bffee6fd394ef382eb76.BeginInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			this.c26a23c3f9ed64e91c418484270f55fcc.BeginInit();
			this.c334cd5fa87833f636046cdbd48987d99.BeginInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).BeginInit();
			((ISupportInitialize)this.c7e89fd9e6642579956d1f909f4cbf1e9).BeginInit();
			((ISupportInitialize)this.c90e121b7434f8af2291ea96c07d8818e).BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c85ea689075639e9b68e63c0631f9c4ba.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10008), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10012));
			this.c85ea689075639e9b68e63c0631f9c4ba.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43605);
			this.c85ea689075639e9b68e63c0631f9c4ba.ShowProgressIndicators = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10016) != 0);
			this.c85ea689075639e9b68e63c0631f9c4ba.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10024));
			this.c85ea689075639e9b68e63c0631f9c4ba.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10028);
			this.c85ea689075639e9b68e63c0631f9c4ba.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43636);
			this.c804bc52f7f79bffee6fd394ef382eb76.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10032) != 0);
			this.c804bc52f7f79bffee6fd394ef382eb76.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10036);
			this.c804bc52f7f79bffee6fd394ef382eb76.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10040), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10044), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10048), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10052));
			this.c804bc52f7f79bffee6fd394ef382eb76.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10056), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10060));
			this.c804bc52f7f79bffee6fd394ef382eb76.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39511);
			this.c804bc52f7f79bffee6fd394ef382eb76.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10064), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10068));
			this.c804bc52f7f79bffee6fd394ef382eb76.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10072);
			this.c804bc52f7f79bffee6fd394ef382eb76.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c804bc52f7f79bffee6fd394ef382eb76.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10076);
			this.c804bc52f7f79bffee6fd394ef382eb76.UseMnemonic = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10080) != 0);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10088));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10096));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10100);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43643);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			this.c26a23c3f9ed64e91c418484270f55fcc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10104), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10108));
			this.c26a23c3f9ed64e91c418484270f55fcc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43654);
			this.c26a23c3f9ed64e91c418484270f55fcc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10112), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10116));
			this.c26a23c3f9ed64e91c418484270f55fcc.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10120);
			this.c26a23c3f9ed64e91c418484270f55fcc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43671);
			this.c334cd5fa87833f636046cdbd48987d99.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10124), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10128));
			this.c334cd5fa87833f636046cdbd48987d99.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43680);
			this.c334cd5fa87833f636046cdbd48987d99.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10132), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10136));
			this.c334cd5fa87833f636046cdbd48987d99.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10140);
			this.c334cd5fa87833f636046cdbd48987d99.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43693);
			this.c1e664eedc77244516df32f78879cbd6a.Image = c6faa5467be1a4874657b372a49b7c927.icnWiiU;
			this.c1e664eedc77244516df32f78879cbd6a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10144), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10148));
			this.c1e664eedc77244516df32f78879cbd6a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43700);
			this.c1e664eedc77244516df32f78879cbd6a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10152), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10156));
			this.c1e664eedc77244516df32f78879cbd6a.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10160);
			this.c1e664eedc77244516df32f78879cbd6a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10164);
			this.c1e664eedc77244516df32f78879cbd6a.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10168) != 0);
			this.c7e89fd9e6642579956d1f909f4cbf1e9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10172), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10176));
			this.c7e89fd9e6642579956d1f909f4cbf1e9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43723);
			this.c7e89fd9e6642579956d1f909f4cbf1e9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10180), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10184));
			this.c7e89fd9e6642579956d1f909f4cbf1e9.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10188);
			this.c7e89fd9e6642579956d1f909f4cbf1e9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10192);
			this.c7e89fd9e6642579956d1f909f4cbf1e9.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10196) != 0);
			this.c90e121b7434f8af2291ea96c07d8818e.Image = c6faa5467be1a4874657b372a49b7c927._220__2_;
			this.c90e121b7434f8af2291ea96c07d8818e.InitialImage = cafec3579a55ef0ba5bcc1f341243b3ba.cab55a050df275722227783d6686266c9;
			this.c90e121b7434f8af2291ea96c07d8818e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10200), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10204));
			this.c90e121b7434f8af2291ea96c07d8818e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43738);
			this.c90e121b7434f8af2291ea96c07d8818e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10208), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10212));
			this.c90e121b7434f8af2291ea96c07d8818e.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10216);
			this.c90e121b7434f8af2291ea96c07d8818e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10220);
			this.c90e121b7434f8af2291ea96c07d8818e.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10224) != 0);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10228), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10232));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10236);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10240), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10244));
			base.Controls.Add(this.c26a23c3f9ed64e91c418484270f55fcc);
			base.Controls.Add(this.c90e121b7434f8af2291ea96c07d8818e);
			base.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			base.Controls.Add(this.c7e89fd9e6642579956d1f909f4cbf1e9);
			base.Controls.Add(this.c1e664eedc77244516df32f78879cbd6a);
			base.Controls.Add(this.c334cd5fa87833f636046cdbd48987d99);
			base.Controls.Add(this.c804bc52f7f79bffee6fd394ef382eb76);
			base.Controls.Add(this.c85ea689075639e9b68e63c0631f9c4ba);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10248);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43761);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10252) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10256) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10260);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43790);
			base.Load += this.c8daf247a347fb120cdbc8f43e7b24bbd;
			this.c85ea689075639e9b68e63c0631f9c4ba.EndInit();
			this.c804bc52f7f79bffee6fd394ef382eb76.EndInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			this.c26a23c3f9ed64e91c418484270f55fcc.EndInit();
			this.c334cd5fa87833f636046cdbd48987d99.EndInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).EndInit();
			((ISupportInitialize)this.c7e89fd9e6642579956d1f909f4cbf1e9).EndInit();
			((ISupportInitialize)this.c90e121b7434f8af2291ea96c07d8818e).EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10264) != 0);
			base.PerformLayout();
		}

		// Token: 0x040002D2 RID: 722
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x040002D3 RID: 723
		private RadProgressBar c85ea689075639e9b68e63c0631f9c4ba;

		// Token: 0x040002D4 RID: 724
		private RadLabel c804bc52f7f79bffee6fd394ef382eb76;

		// Token: 0x040002D5 RID: 725
		private RadLabel c26a23c3f9ed64e91c418484270f55fcc;

		// Token: 0x040002D6 RID: 726
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;

		// Token: 0x040002D7 RID: 727
		private RadLabel c334cd5fa87833f636046cdbd48987d99;

		// Token: 0x040002D8 RID: 728
		private PictureBox c1e664eedc77244516df32f78879cbd6a;

		// Token: 0x040002D9 RID: 729
		private PictureBox c7e89fd9e6642579956d1f909f4cbf1e9;

		// Token: 0x040002DA RID: 730
		private PictureBox c90e121b7434f8af2291ea96c07d8818e;

		// Token: 0x0200013F RID: 319
		[CompilerGenerated]
		private sealed class c15a4044309c0d4f4e4037bc0ba43b8b6
		{
			// Token: 0x0600094D RID: 2381 RVA: 0x0005F198 File Offset: 0x0005D398
			internal void c5097ecd7774779d65a8be1bd6396716a()
			{
				Control c334cd5fa87833f636046cdbd48987d = this.c4404a159870bf55bb6f111e66e59e82d.c334cd5fa87833f636046cdbd48987d99;
				string text;
				if (this.cf1cc9bc7f20e07f3b88f8be0de09f98a.TotalSeconds <= cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(30580))
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce391dfcb046d82715408fa23d60a1773.c15a4044309c0d4f4e4037bc0ba43b8b6.c5097ecd7774779d65a8be1bd6396716a()).MethodHandle;
					}
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71853);
				}
				else
				{
					text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71900), this.cf1cc9bc7f20e07f3b88f8be0de09f98a.Hours, this.cf1cc9bc7f20e07f3b88f8be0de09f98a.Minutes, this.cf1cc9bc7f20e07f3b88f8be0de09f98a.Seconds);
				}
				c334cd5fa87833f636046cdbd48987d.Text = text;
			}

			// Token: 0x040006D9 RID: 1753
			public TimeSpan cf1cc9bc7f20e07f3b88f8be0de09f98a;

			// Token: 0x040006DA RID: 1754
			public ce391dfcb046d82715408fa23d60a1773 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000140 RID: 320
		[CompilerGenerated]
		private sealed class c970b0acb9a610449c43c434e790c518a
		{
			// Token: 0x0600094F RID: 2383 RVA: 0x0005F250 File Offset: 0x0005D450
			internal void c5d1d6ba7b7c3cbd8b7c0d32f6a54c699()
			{
				if (this.cdc2df70fc41ec746908194e6c2324250 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30588))
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce391dfcb046d82715408fa23d60a1773.c970b0acb9a610449c43c434e790c518a.c5d1d6ba7b7c3cbd8b7c0d32f6a54c699()).MethodHandle;
					}
					this.cdc2df70fc41ec746908194e6c2324250 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30592);
				}
				this.c4404a159870bf55bb6f111e66e59e82d.c85ea689075639e9b68e63c0631f9c4ba.Value1 = this.cdc2df70fc41ec746908194e6c2324250;
				this.c4404a159870bf55bb6f111e66e59e82d.c26a23c3f9ed64e91c418484270f55fcc.Text = this.cef94e12d085457557bbcac9bef54a336.ToString();
			}

			// Token: 0x040006DB RID: 1755
			public int cdc2df70fc41ec746908194e6c2324250;

			// Token: 0x040006DC RID: 1756
			public c8d217bce073ddc882212f4d0e016403a cef94e12d085457557bbcac9bef54a336;

			// Token: 0x040006DD RID: 1757
			public ce391dfcb046d82715408fa23d60a1773 c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
