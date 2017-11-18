using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000CC RID: 204
	public class c2dcabb874d69fc0fa9d819b6f090913a : RadForm
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x0003B924 File Offset: 0x00039B24
		public c2dcabb874d69fc0fa9d819b6f090913a(IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> ced140292448e7d8aef4edc4f70ce2f68)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			this.cee54c856c7e63e5fbea3d765715af7a0.EnableGrouping = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18692) != 0);
			this.cee54c856c7e63e5fbea3d765715af7a0.EnableCustomGrouping = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18696) != 0);
			this.cee54c856c7e63e5fbea3d765715af7a0.Groups.Add(this.c8b5351bcd9529148d9c20a4d3016644c);
			this.cee54c856c7e63e5fbea3d765715af7a0.Groups.Add(this.c21daf0dead243880b90f2869d76d96fa);
			this.cee54c856c7e63e5fbea3d765715af7a0.ShowGroups = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18700) != 0);
			this.cee54c856c7e63e5fbea3d765715af7a0.BeginUpdate();
			IEnumerator<c6114b34ba4893a53ebb4b599e0e2e3fc> enumerator = ced140292448e7d8aef4edc4f70ce2f68.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = enumerator.Current;
					ListViewDataItem listViewDataItem = new ListViewDataItem(c6114b34ba4893a53ebb4b599e0e2e3fc)
					{
						Tag = c6114b34ba4893a53ebb4b599e0e2e3fc
					};
					switch (c6114b34ba4893a53ebb4b599e0e2e3fc.System)
					{
					case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
						listViewDataItem.Group = this.c21daf0dead243880b90f2869d76d96fa;
						break;
					case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
						listViewDataItem.Group = this.c8b5351bcd9529148d9c20a4d3016644c;
						break;
					case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
						throw new NotImplementedException();
					}
					this.cee54c856c7e63e5fbea3d765715af7a0.Items.Add(listViewDataItem);
				}
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c2dcabb874d69fc0fa9d819b6f090913a..ctor(IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc>)).MethodHandle;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			this.cee54c856c7e63e5fbea3d765715af7a0.EndUpdate();
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0003BAA8 File Offset: 0x00039CA8
		private void c46b6ded173670d3a80a210dd349eb95a(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			IEnumerator<ListViewDataItem> enumerator = this.cee54c856c7e63e5fbea3d765715af7a0.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					listViewDataItem.CheckState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18492);
				}
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c2dcabb874d69fc0fa9d819b6f090913a.c46b6ded173670d3a80a210dd349eb95a(object, EventArgs)).MethodHandle;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0003BB28 File Offset: 0x00039D28
		private void cfb9fd2addd333e8c28d4aff66027ee10(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18496);
			IEnumerable<ListViewDataItem> items = this.cee54c856c7e63e5fbea3d765715af7a0.Items;
			Func<ListViewDataItem, bool> predicate;
			if ((predicate = c2dcabb874d69fc0fa9d819b6f090913a.<>c.c5e57be654d50df4c034b8f0b917ceb75) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c2dcabb874d69fc0fa9d819b6f090913a.cfb9fd2addd333e8c28d4aff66027ee10(object, EventArgs)).MethodHandle;
				}
				predicate = (c2dcabb874d69fc0fa9d819b6f090913a.<>c.c5e57be654d50df4c034b8f0b917ceb75 = new Func<ListViewDataItem, bool>(c2dcabb874d69fc0fa9d819b6f090913a.<>c.cdfab1996eb8651828de2a4469aa3481e.c260a4e5b41a46c03e63c8edf1d68a71d));
			}
			IEnumerable<ListViewDataItem> source = items.Where(predicate);
			Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc> selector;
			if ((selector = c2dcabb874d69fc0fa9d819b6f090913a.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0) == null)
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
				selector = (c2dcabb874d69fc0fa9d819b6f090913a.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0 = new Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc>(c2dcabb874d69fc0fa9d819b6f090913a.<>c.cdfab1996eb8651828de2a4469aa3481e.c470230449815585289b3d2488f87d060));
			}
			this.ce6df48bc5c345177ae4bfdd429a85275 = source.Select(selector).ToList<c6114b34ba4893a53ebb4b599e0e2e3fc>();
			base.Close();
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0003BBD0 File Offset: 0x00039DD0
		private void c6d0397d2250c9ecf046445c763f77bd6(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		private void cfe3005275a0939c292416bac39c0a22c(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0003BBF0 File Offset: 0x00039DF0
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c2dcabb874d69fc0fa9d819b6f090913a.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0003BC38 File Offset: 0x00039E38
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(ce6dc88dfca19f804f028b036903dc09b.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.ceefeeb905146bf2684e227ccf9dcbb43 = new RadButton();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c0e7bde0280df56351440f1954d87e7a9 = new RadButton();
			this.ca6c1cea062503a0a580756cf1f1f0961 = new RadGroupBox();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.cee54c856c7e63e5fbea3d765715af7a0 = new RadCheckedListBox();
			this.ceefeeb905146bf2684e227ccf9dcbb43.BeginInit();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c0e7bde0280df56351440f1954d87e7a9.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.SuspendLayout();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.cee54c856c7e63e5fbea3d765715af7a0.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.ceefeeb905146bf2684e227ccf9dcbb43.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18500);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18504), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18508));
			this.ceefeeb905146bf2684e227ccf9dcbb43.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66988);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18512), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18516));
			this.ceefeeb905146bf2684e227ccf9dcbb43.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18520);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67593);
			this.ceefeeb905146bf2684e227ccf9dcbb43.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Click += this.cfb9fd2addd333e8c28d4aff66027ee10;
			this.c4553ed186725b714efcccc71bbe10a0f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18524) != 0);
			this.c4553ed186725b714efcccc71bbe10a0f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18528);
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18532), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18536));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18544));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18548);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67626);
			this.c4553ed186725b714efcccc71bbe10a0f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18552);
			this.c4553ed186725b714efcccc71bbe10a0f.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c0e7bde0280df56351440f1954d87e7a9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18556);
			this.c0e7bde0280df56351440f1954d87e7a9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18560), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18564));
			this.c0e7bde0280df56351440f1954d87e7a9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67505);
			this.c0e7bde0280df56351440f1954d87e7a9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18568), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18572));
			this.c0e7bde0280df56351440f1954d87e7a9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18576);
			this.c0e7bde0280df56351440f1954d87e7a9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67528);
			this.c0e7bde0280df56351440f1954d87e7a9.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c0e7bde0280df56351440f1954d87e7a9.Click += this.c46b6ded173670d3a80a210dd349eb95a;
			this.ca6c1cea062503a0a580756cf1f1f0961.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18580);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			this.ca6c1cea062503a0a580756cf1f1f0961.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18584);
			this.ca6c1cea062503a0a580756cf1f1f0961.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.ca6c1cea062503a0a580756cf1f1f0961.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18588), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18592));
			this.ca6c1cea062503a0a580756cf1f1f0961.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48088);
			this.ca6c1cea062503a0a580756cf1f1f0961.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18596), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18600));
			this.ca6c1cea062503a0a580756cf1f1f0961.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18604);
			this.ca6c1cea062503a0a580756cf1f1f0961.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.ca6c1cea062503a0a580756cf1f1f0961.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.ca6c1cea062503a0a580756cf1f1f0961.Click += this.cfe3005275a0939c292416bac39c0a22c;
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18608), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18612));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18616), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18620));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18624);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.cee54c856c7e63e5fbea3d765715af7a0.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18628);
			this.cee54c856c7e63e5fbea3d765715af7a0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18632), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18636));
			this.cee54c856c7e63e5fbea3d765715af7a0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66878);
			this.cee54c856c7e63e5fbea3d765715af7a0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18640), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18644));
			this.cee54c856c7e63e5fbea3d765715af7a0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18648);
			this.cee54c856c7e63e5fbea3d765715af7a0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43485);
			this.cee54c856c7e63e5fbea3d765715af7a0.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18652), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18656));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18660);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18664), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18668));
			base.Controls.Add(this.cee54c856c7e63e5fbea3d765715af7a0);
			base.Controls.Add(this.c0e7bde0280df56351440f1954d87e7a9);
			base.Controls.Add(this.ceefeeb905146bf2684e227ccf9dcbb43);
			base.Controls.Add(this.ca6c1cea062503a0a580756cf1f1f0961);
			base.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67776);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18672));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18676) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18680);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67801);
			base.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			base.Load += this.c6d0397d2250c9ecf046445c763f77bd6;
			this.ceefeeb905146bf2684e227ccf9dcbb43.EndInit();
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c0e7bde0280df56351440f1954d87e7a9.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18684) != 0);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.cee54c856c7e63e5fbea3d765715af7a0.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18688) != 0);
			base.PerformLayout();
		}

		// Token: 0x04000433 RID: 1075
		public List<c6114b34ba4893a53ebb4b599e0e2e3fc> ce6df48bc5c345177ae4bfdd429a85275;

		// Token: 0x04000434 RID: 1076
		private readonly ListViewDataItemGroup c21daf0dead243880b90f2869d76d96fa = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67844));

		// Token: 0x04000435 RID: 1077
		private readonly ListViewDataItemGroup c8b5351bcd9529148d9c20a4d3016644c = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67851));

		// Token: 0x04000436 RID: 1078
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000437 RID: 1079
		private RadButton ceefeeb905146bf2684e227ccf9dcbb43;

		// Token: 0x04000438 RID: 1080
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x04000439 RID: 1081
		private RadButton c0e7bde0280df56351440f1954d87e7a9;

		// Token: 0x0400043A RID: 1082
		private RadGroupBox ca6c1cea062503a0a580756cf1f1f0961;

		// Token: 0x0400043B RID: 1083
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x0400043C RID: 1084
		private RadCheckedListBox cee54c856c7e63e5fbea3d765715af7a0;
	}
}
