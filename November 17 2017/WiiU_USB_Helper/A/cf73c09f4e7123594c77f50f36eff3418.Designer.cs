using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WIIU_Downloader.Forms;

namespace A
{
	// Token: 0x020000D1 RID: 209
	public class cf73c09f4e7123594c77f50f36eff3418 : RadForm
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x0003E4C0 File Offset: 0x0003C6C0
		public cf73c09f4e7123594c77f50f36eff3418(c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1, WhatToAction c21c0267cb55d358b5e842c4f76bdb69d)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			bool flag;
			if (c21c0267cb55d358b5e842c4f76bdb69d != WhatToAction.Copy)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf73c09f4e7123594c77f50f36eff3418..ctor(c5409344e1c2b74fa8c9a4d620ccb8d48, WhatToAction)).MethodHandle;
				}
				flag = (c21c0267cb55d358b5e842c4f76bdb69d == (WhatToAction)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19684));
			}
			else
			{
				flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19688) != 0);
			}
			this.cf38f712f785553642b0d58ee2bf5a26f = flag;
			this.cc80b541ea0aecdb8c28ad57f43ca8ab8 = c21c0267cb55d358b5e842c4f76bdb69d;
			this.c804bc52f7f79bffee6fd394ef382eb76.Text = c6b7fbe462f43433d64916e9273f7e5d1.Name;
			this.c37349fc05fe3d1b830be8a46c71970f7 = c6b7fbe462f43433d64916e9273f7e5d1;
			this.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69479), c21c0267cb55d358b5e842c4f76bdb69d);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69502), Enum.GetName(Type.GetTypeFromHandle(ce918f9187f6feb5c61edb19a684b744e.cde4d1aeffe0e705b07e1b3d74e931465()), c21c0267cb55d358b5e842c4f76bdb69d).ToLower());
			if (this.cf38f712f785553642b0d58ee2bf5a26f)
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
				this.cd65a6c8231d20c5f0fa49e0ccf498192.Enabled = (c6b7fbe462f43433d64916e9273f7e5d1.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19692));
				Control control = this.c05efd743a6cf51d04078fbb1be078004;
				bool enabled;
				if (c6b7fbe462f43433d64916e9273f7e5d1.c66201ce2763de795655e645e059b6451)
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
					IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687> updates = c6b7fbe462f43433d64916e9273f7e5d1.Updates;
					Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool> predicate;
					if ((predicate = cf73c09f4e7123594c77f50f36eff3418.<>c.c5e57be654d50df4c034b8f0b917ceb75) == null)
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
						predicate = (cf73c09f4e7123594c77f50f36eff3418.<>c.c5e57be654d50df4c034b8f0b917ceb75 = new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(cf73c09f4e7123594c77f50f36eff3418.<>c.cdfab1996eb8651828de2a4469aa3481e.c274418e179704d28ef33fa997ccb3b31));
					}
					enabled = updates.Any(predicate);
				}
				else
				{
					enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19696) != 0);
				}
				control.Enabled = enabled;
				Control control2 = this.c381384b05f80907c5181f9c6898ce93f;
				bool enabled2;
				if (c6b7fbe462f43433d64916e9273f7e5d1.Dlc != null)
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
					enabled2 = (c6b7fbe462f43433d64916e9273f7e5d1.Dlc.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19700));
				}
				else
				{
					enabled2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19704) != 0);
				}
				control2.Enabled = enabled2;
			}
			else
			{
				this.cd65a6c8231d20c5f0fa49e0ccf498192.Enabled = (c6b7fbe462f43433d64916e9273f7e5d1.ca435006c85356cb7385a782de8889a0a > (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19708));
				Control control3 = this.c05efd743a6cf51d04078fbb1be078004;
				bool enabled3;
				if (c6b7fbe462f43433d64916e9273f7e5d1.c66201ce2763de795655e645e059b6451)
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
					IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687> updates2 = c6b7fbe462f43433d64916e9273f7e5d1.Updates;
					Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool> predicate2;
					if ((predicate2 = cf73c09f4e7123594c77f50f36eff3418.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0) == null)
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
						predicate2 = (cf73c09f4e7123594c77f50f36eff3418.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0 = new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(cf73c09f4e7123594c77f50f36eff3418.<>c.cdfab1996eb8651828de2a4469aa3481e.ce5bad3b64394b8e2dbe22df44624f70e));
					}
					enabled3 = updates2.Any(predicate2);
				}
				else
				{
					enabled3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19712) != 0);
				}
				control3.Enabled = enabled3;
				Control control4 = this.c381384b05f80907c5181f9c6898ce93f;
				bool enabled4;
				if (c6b7fbe462f43433d64916e9273f7e5d1.Dlc != null)
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
					enabled4 = (c6b7fbe462f43433d64916e9273f7e5d1.Dlc.ca435006c85356cb7385a782de8889a0a > (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19716));
				}
				else
				{
					enabled4 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19720) != 0);
				}
				control4.Enabled = enabled4;
			}
			base.Opacity = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(19724);
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0003E74C File Offset: 0x0003C94C
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0003E760 File Offset: 0x0003C960
		public bool CopyDlc { get; set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0003E774 File Offset: 0x0003C974
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x0003E788 File Offset: 0x0003C988
		public bool CopyGame { get; set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0003E79C File Offset: 0x0003C99C
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x0003E7B0 File Offset: 0x0003C9B0
		public bool CopyUpdate { get; set; }

		// Token: 0x0600074A RID: 1866 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		private void c76afc53365af9f8550a017f574a9a7cc(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (!this.c05efd743a6cf51d04078fbb1be078004.Checked)
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf73c09f4e7123594c77f50f36eff3418.c76afc53365af9f8550a017f574a9a7cc(object, StateChangedEventArgs)).MethodHandle;
				}
				return;
			}
			this.cf28a48c56d2d62de2a876a01f7fc2dbf();
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0003E7FC File Offset: 0x0003C9FC
		private void cf28a48c56d2d62de2a876a01f7fc2dbf()
		{
			c1f6179bdc03861e26477b7826da4fb8c c1f6179bdc03861e26477b7826da4fb8c = new c1f6179bdc03861e26477b7826da4fb8c(this.c37349fc05fe3d1b830be8a46c71970f7.Updates, this.cf38f712f785553642b0d58ee2bf5a26f);
			if (c1f6179bdc03861e26477b7826da4fb8c.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19440))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf73c09f4e7123594c77f50f36eff3418.cf28a48c56d2d62de2a876a01f7fc2dbf()).MethodHandle;
				}
				this.c9f4bf79f56cd07529ca7850385fa2cb4 = c1f6179bdc03861e26477b7826da4fb8c.c9f4bf79f56cd07529ca7850385fa2cb4;
				return;
			}
			this.c05efd743a6cf51d04078fbb1be078004.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19444) != 0);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0003E86C File Offset: 0x0003CA6C
		private void c0e7f0a484e4b62fa584c30893a1fcb39(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.cd65a6c8231d20c5f0fa49e0ccf498192.Enabled)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf73c09f4e7123594c77f50f36eff3418.c0e7f0a484e4b62fa584c30893a1fcb39(object, EventArgs)).MethodHandle;
				}
				this.c60a6a0413c84a2ad44fb358bece69693 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19448);
			}
			if (this.c381384b05f80907c5181f9c6898ce93f.Enabled)
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
				this.c60a6a0413c84a2ad44fb358bece69693 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19452);
			}
			if (this.c05efd743a6cf51d04078fbb1be078004.Enabled)
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
				this.c60a6a0413c84a2ad44fb358bece69693 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19456);
			}
			if (!this.cf38f712f785553642b0d58ee2bf5a26f)
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
				base.Opacity = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(19460);
				return;
			}
			if (this.c60a6a0413c84a2ad44fb358bece69693 == 0)
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
				base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19468);
				base.Close();
			}
			if (this.c60a6a0413c84a2ad44fb358bece69693 != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19472))
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
				base.Opacity = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(19476);
				return;
			}
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19484);
			this.CopyGame = this.cd65a6c8231d20c5f0fa49e0ccf498192.Enabled;
			if (this.c05efd743a6cf51d04078fbb1be078004.Enabled)
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
				this.cf28a48c56d2d62de2a876a01f7fc2dbf();
				this.CopyUpdate = (this.c9f4bf79f56cd07529ca7850385fa2cb4 != cf3218b8adf29f173dcfe848adf64aa6d.cab55a050df275722227783d6686266c9);
			}
			this.CopyDlc = this.c381384b05f80907c5181f9c6898ce93f.Enabled;
			base.Close();
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0003E9FC File Offset: 0x0003CBFC
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19488);
			this.CopyGame = this.cd65a6c8231d20c5f0fa49e0ccf498192.Checked;
			this.CopyUpdate = this.c05efd743a6cf51d04078fbb1be078004.Checked;
			this.CopyDlc = this.c381384b05f80907c5181f9c6898ce93f.Checked;
			base.Close();
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0003EA58 File Offset: 0x0003CC58
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf73c09f4e7123594c77f50f36eff3418.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0003EAA0 File Offset: 0x0003CCA0
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c15d9090b6a70d3a3c645fff30223e3a5 = new RadLabel();
			this.cd65a6c8231d20c5f0fa49e0ccf498192 = new RadCheckBox();
			this.c05efd743a6cf51d04078fbb1be078004 = new RadCheckBox();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.c381384b05f80907c5181f9c6898ce93f = new RadCheckBox();
			this.c804bc52f7f79bffee6fd394ef382eb76 = new RadLabel();
			this.c15d9090b6a70d3a3c645fff30223e3a5.BeginInit();
			this.cd65a6c8231d20c5f0fa49e0ccf498192.BeginInit();
			this.c05efd743a6cf51d04078fbb1be078004.BeginInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			this.c381384b05f80907c5181f9c6898ce93f.BeginInit();
			this.c804bc52f7f79bffee6fd394ef382eb76.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c15d9090b6a70d3a3c645fff30223e3a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19492), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19496));
			this.c15d9090b6a70d3a3c645fff30223e3a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47331);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19504));
			this.c15d9090b6a70d3a3c645fff30223e3a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19508);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69274);
			this.cd65a6c8231d20c5f0fa49e0ccf498192.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19512), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19516));
			this.cd65a6c8231d20c5f0fa49e0ccf498192.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69347);
			this.cd65a6c8231d20c5f0fa49e0ccf498192.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19520), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19524));
			this.cd65a6c8231d20c5f0fa49e0ccf498192.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19528);
			this.cd65a6c8231d20c5f0fa49e0ccf498192.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48079);
			this.c05efd743a6cf51d04078fbb1be078004.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19532), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19536));
			this.c05efd743a6cf51d04078fbb1be078004.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69370);
			this.c05efd743a6cf51d04078fbb1be078004.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19544));
			this.c05efd743a6cf51d04078fbb1be078004.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19548);
			this.c05efd743a6cf51d04078fbb1be078004.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48113);
			this.c05efd743a6cf51d04078fbb1be078004.ToggleStateChanged += new StateChangedEventHandler(this.c76afc53365af9f8550a017f574a9a7cc);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19552), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19556));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19560), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19564));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19568);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50059);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			this.c381384b05f80907c5181f9c6898ce93f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19572), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19576));
			this.c381384b05f80907c5181f9c6898ce93f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69397);
			this.c381384b05f80907c5181f9c6898ce93f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19580), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19584));
			this.c381384b05f80907c5181f9c6898ce93f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19588);
			this.c381384b05f80907c5181f9c6898ce93f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69418);
			this.c804bc52f7f79bffee6fd394ef382eb76.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19592) != 0);
			this.c804bc52f7f79bffee6fd394ef382eb76.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19596);
			this.c804bc52f7f79bffee6fd394ef382eb76.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19600), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19604), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19608), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19612));
			this.c804bc52f7f79bffee6fd394ef382eb76.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19616), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19620));
			this.c804bc52f7f79bffee6fd394ef382eb76.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39511);
			this.c804bc52f7f79bffee6fd394ef382eb76.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19624), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19628));
			this.c804bc52f7f79bffee6fd394ef382eb76.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19632);
			this.c804bc52f7f79bffee6fd394ef382eb76.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47387);
			this.c804bc52f7f79bffee6fd394ef382eb76.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19636);
			this.c804bc52f7f79bffee6fd394ef382eb76.UseMnemonic = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19640) != 0);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19644), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19648));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19652);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19656), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19660));
			base.Controls.Add(this.c804bc52f7f79bffee6fd394ef382eb76);
			base.Controls.Add(this.c381384b05f80907c5181f9c6898ce93f);
			base.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			base.Controls.Add(this.c05efd743a6cf51d04078fbb1be078004);
			base.Controls.Add(this.cd65a6c8231d20c5f0fa49e0ccf498192);
			base.Controls.Add(this.c15d9090b6a70d3a3c645fff30223e3a5);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19664);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69425);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19668) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19672) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19676);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69452);
			base.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(64222);
			base.Load += this.c0e7f0a484e4b62fa584c30893a1fcb39;
			this.c15d9090b6a70d3a3c645fff30223e3a5.EndInit();
			this.cd65a6c8231d20c5f0fa49e0ccf498192.EndInit();
			this.c05efd743a6cf51d04078fbb1be078004.EndInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			this.c381384b05f80907c5181f9c6898ce93f.EndInit();
			this.c804bc52f7f79bffee6fd394ef382eb76.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19680) != 0);
			base.PerformLayout();
		}

		// Token: 0x0400045F RID: 1119
		private WhatToAction cc80b541ea0aecdb8c28ad57f43ca8ab8;

		// Token: 0x04000460 RID: 1120
		private readonly c5409344e1c2b74fa8c9a4d620ccb8d48 c37349fc05fe3d1b830be8a46c71970f7;

		// Token: 0x04000461 RID: 1121
		private readonly bool cf38f712f785553642b0d58ee2bf5a26f;

		// Token: 0x04000462 RID: 1122
		private int c60a6a0413c84a2ad44fb358bece69693;

		// Token: 0x04000463 RID: 1123
		public List<c6a2f8acae5ff1a8a909193a5c5de6687> c9f4bf79f56cd07529ca7850385fa2cb4;

		// Token: 0x04000464 RID: 1124
		[CompilerGenerated]
		private bool c9159494e14149fd03b05fa1df6cb731b;

		// Token: 0x04000465 RID: 1125
		[CompilerGenerated]
		private bool c0691e22b3b5dc1b748bbcb30a1d0afdd;

		// Token: 0x04000466 RID: 1126
		[CompilerGenerated]
		private bool c38f928a4f7b83a9304f8d260ff316a05;

		// Token: 0x04000467 RID: 1127
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000468 RID: 1128
		private RadLabel c15d9090b6a70d3a3c645fff30223e3a5;

		// Token: 0x04000469 RID: 1129
		private RadCheckBox cd65a6c8231d20c5f0fa49e0ccf498192;

		// Token: 0x0400046A RID: 1130
		private RadCheckBox c05efd743a6cf51d04078fbb1be078004;

		// Token: 0x0400046B RID: 1131
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;

		// Token: 0x0400046C RID: 1132
		private RadCheckBox c381384b05f80907c5181f9c6898ce93f;

		// Token: 0x0400046D RID: 1133
		private RadLabel c804bc52f7f79bffee6fd394ef382eb76;
	}
}
