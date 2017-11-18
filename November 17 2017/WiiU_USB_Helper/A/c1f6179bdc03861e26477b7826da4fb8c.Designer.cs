using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000CE RID: 206
	internal class c1f6179bdc03861e26477b7826da4fb8c : RadForm
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x0003CCB0 File Offset: 0x0003AEB0
		public c1f6179bdc03861e26477b7826da4fb8c(IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687> c92fb5cbad19cbe61a70530d7d55afe0d, bool c4e408bf1083df4857971241b2d176d89)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			IEnumerator<c6a2f8acae5ff1a8a909193a5c5de6687> enumerator = c92fb5cbad19cbe61a70530d7d55afe0d.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c6a2f8acae5ff1a8a909193a5c5de6687 c6a2f8acae5ff1a8a909193a5c5de = enumerator.Current;
					ListViewDataItemCollection items = this.ca0de944ebae052a45eeb8692ad5156be.Items;
					ListViewDataItem listViewDataItem = new ListViewDataItem(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69134), c6a2f8acae5ff1a8a909193a5c5de.Version, c6a2f8acae5ff1a8a909193a5c5de.Size));
					listViewDataItem.Tag = c6a2f8acae5ff1a8a909193a5c5de;
					listViewDataItem.ForeColor = c6a2f8acae5ff1a8a909193a5c5de.c1987926a4691c2e0ac2736e17b520743;
					bool enabled;
					if (c4e408bf1083df4857971241b2d176d89)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c1f6179bdc03861e26477b7826da4fb8c..ctor(IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687>, bool)).MethodHandle;
						}
						enabled = (c6a2f8acae5ff1a8a909193a5c5de.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19060));
					}
					else
					{
						enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19064) != 0);
					}
					listViewDataItem.Enabled = enabled;
					items.Add(listViewDataItem);
				}
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003CDB0 File Offset: 0x0003AFB0
		private void c46b6ded173670d3a80a210dd349eb95a(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			IEnumerable<ListViewDataItem> items = this.ca0de944ebae052a45eeb8692ad5156be.Items;
			Func<ListViewDataItem, bool> predicate;
			if ((predicate = c1f6179bdc03861e26477b7826da4fb8c.<>c.ce9e58ff3492c7ce54d17214d8beaab5c) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c1f6179bdc03861e26477b7826da4fb8c.c46b6ded173670d3a80a210dd349eb95a(object, EventArgs)).MethodHandle;
				}
				predicate = (c1f6179bdc03861e26477b7826da4fb8c.<>c.ce9e58ff3492c7ce54d17214d8beaab5c = new Func<ListViewDataItem, bool>(c1f6179bdc03861e26477b7826da4fb8c.<>c.cdfab1996eb8651828de2a4469aa3481e.cdc3c855861f1779d4bbf25842714e04a));
			}
			IEnumerator<ListViewDataItem> enumerator = items.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					listViewDataItem.CheckState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18880);
				}
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0003CE60 File Offset: 0x0003B060
		private void cfb9fd2addd333e8c28d4aff66027ee10(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18884);
			IEnumerable<ListViewDataItem> items = this.ca0de944ebae052a45eeb8692ad5156be.Items;
			Func<ListViewDataItem, bool> predicate;
			if ((predicate = c1f6179bdc03861e26477b7826da4fb8c.<>c.c6ef5f159df1e335193dc671bc70dd746) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c1f6179bdc03861e26477b7826da4fb8c.cfb9fd2addd333e8c28d4aff66027ee10(object, EventArgs)).MethodHandle;
				}
				predicate = (c1f6179bdc03861e26477b7826da4fb8c.<>c.c6ef5f159df1e335193dc671bc70dd746 = new Func<ListViewDataItem, bool>(c1f6179bdc03861e26477b7826da4fb8c.<>c.cdfab1996eb8651828de2a4469aa3481e.cab4307be021731622b0d119e719409b4));
			}
			IEnumerable<ListViewDataItem> source = items.Where(predicate);
			Func<ListViewDataItem, c6a2f8acae5ff1a8a909193a5c5de6687> selector;
			if ((selector = c1f6179bdc03861e26477b7826da4fb8c.<>c.cf8ddd996ae65bdc404e242283e9c5c6b) == null)
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
				selector = (c1f6179bdc03861e26477b7826da4fb8c.<>c.cf8ddd996ae65bdc404e242283e9c5c6b = new Func<ListViewDataItem, c6a2f8acae5ff1a8a909193a5c5de6687>(c1f6179bdc03861e26477b7826da4fb8c.<>c.cdfab1996eb8651828de2a4469aa3481e.c76c7cba21f26cb4144dbebe95992a3be));
			}
			this.c9f4bf79f56cd07529ca7850385fa2cb4 = source.Select(selector).ToList<c6a2f8acae5ff1a8a909193a5c5de6687>();
			base.Close();
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0003CF08 File Offset: 0x0003B108
		private void c804c1b760bb440e63e90caea905746bd(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0003CF18 File Offset: 0x0003B118
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c9b35f78180c1b651efd32ed8ddd8b683.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.ca0de944ebae052a45eeb8692ad5156be = new RadCheckedListBox();
			this.cf90d956881ae51fef5294b4df13f69ec = new RadLabel();
			this.c146acf0b8ff7b9d6b7732ac20bd7c536 = new RadButton();
			this.c20519e39631afca245cc38ddc3d0f4f4 = new RadGroupBox();
			this.c807876d4a2a152f379070d951d5554eb = new RadLabel();
			this.ce711a67bbea498a7b984ce49d2f48977 = new RadButton();
			this.ca0de944ebae052a45eeb8692ad5156be.BeginInit();
			this.cf90d956881ae51fef5294b4df13f69ec.BeginInit();
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.BeginInit();
			this.c20519e39631afca245cc38ddc3d0f4f4.BeginInit();
			this.c20519e39631afca245cc38ddc3d0f4f4.SuspendLayout();
			this.c807876d4a2a152f379070d951d5554eb.BeginInit();
			this.ce711a67bbea498a7b984ce49d2f48977.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.ca0de944ebae052a45eeb8692ad5156be.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18888) != 0);
			this.ca0de944ebae052a45eeb8692ad5156be.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18892);
			this.ca0de944ebae052a45eeb8692ad5156be.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18896), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18900));
			this.ca0de944ebae052a45eeb8692ad5156be.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68768);
			this.ca0de944ebae052a45eeb8692ad5156be.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18904), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18908));
			this.ca0de944ebae052a45eeb8692ad5156be.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18912);
			this.ca0de944ebae052a45eeb8692ad5156be.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43485);
			this.ca0de944ebae052a45eeb8692ad5156be.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.cf90d956881ae51fef5294b4df13f69ec.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18916), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18920));
			this.cf90d956881ae51fef5294b4df13f69ec.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68793);
			this.cf90d956881ae51fef5294b4df13f69ec.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18924), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18928));
			this.cf90d956881ae51fef5294b4df13f69ec.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18932);
			this.cf90d956881ae51fef5294b4df13f69ec.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68814);
			this.cf90d956881ae51fef5294b4df13f69ec.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18936);
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18940), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18944));
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68976);
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18948), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18952));
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18956);
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50059);
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.Click += this.cfb9fd2addd333e8c28d4aff66027ee10;
			this.c20519e39631afca245cc38ddc3d0f4f4.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18960);
			this.c20519e39631afca245cc38ddc3d0f4f4.Controls.Add(this.cf90d956881ae51fef5294b4df13f69ec);
			this.c20519e39631afca245cc38ddc3d0f4f4.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18964);
			this.c20519e39631afca245cc38ddc3d0f4f4.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.c20519e39631afca245cc38ddc3d0f4f4.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18968), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18972));
			this.c20519e39631afca245cc38ddc3d0f4f4.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68997);
			this.c20519e39631afca245cc38ddc3d0f4f4.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18976), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18980));
			this.c20519e39631afca245cc38ddc3d0f4f4.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18984);
			this.c20519e39631afca245cc38ddc3d0f4f4.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.c20519e39631afca245cc38ddc3d0f4f4.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c807876d4a2a152f379070d951d5554eb.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18988), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18992));
			this.c807876d4a2a152f379070d951d5554eb.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69024);
			this.c807876d4a2a152f379070d951d5554eb.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18996), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19000));
			this.c807876d4a2a152f379070d951d5554eb.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19004);
			this.c807876d4a2a152f379070d951d5554eb.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.ce711a67bbea498a7b984ce49d2f48977.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19008);
			this.ce711a67bbea498a7b984ce49d2f48977.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19012), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19016));
			this.ce711a67bbea498a7b984ce49d2f48977.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69045);
			this.ce711a67bbea498a7b984ce49d2f48977.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19024));
			this.ce711a67bbea498a7b984ce49d2f48977.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19028);
			this.ce711a67bbea498a7b984ce49d2f48977.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67528);
			this.ce711a67bbea498a7b984ce49d2f48977.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.ce711a67bbea498a7b984ce49d2f48977.Click += this.c46b6ded173670d3a80a210dd349eb95a;
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19032), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19036));
			base.Controls.Add(this.ca0de944ebae052a45eeb8692ad5156be);
			base.Controls.Add(this.c146acf0b8ff7b9d6b7732ac20bd7c536);
			base.Controls.Add(this.c20519e39631afca245cc38ddc3d0f4f4);
			base.Controls.Add(this.c807876d4a2a152f379070d951d5554eb);
			base.Controls.Add(this.ce711a67bbea498a7b984ce49d2f48977);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69070);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19040));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19044) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19048);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69103);
			base.Load += this.c804c1b760bb440e63e90caea905746bd;
			this.ca0de944ebae052a45eeb8692ad5156be.EndInit();
			this.cf90d956881ae51fef5294b4df13f69ec.EndInit();
			this.c146acf0b8ff7b9d6b7732ac20bd7c536.EndInit();
			this.c20519e39631afca245cc38ddc3d0f4f4.EndInit();
			this.c20519e39631afca245cc38ddc3d0f4f4.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19052) != 0);
			this.c20519e39631afca245cc38ddc3d0f4f4.PerformLayout();
			this.c807876d4a2a152f379070d951d5554eb.EndInit();
			this.ce711a67bbea498a7b984ce49d2f48977.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19056) != 0);
			base.PerformLayout();
		}

		// Token: 0x04000444 RID: 1092
		private RadButton ce711a67bbea498a7b984ce49d2f48977;

		// Token: 0x04000445 RID: 1093
		private RadButton c146acf0b8ff7b9d6b7732ac20bd7c536;

		// Token: 0x04000446 RID: 1094
		private RadCheckedListBox ca0de944ebae052a45eeb8692ad5156be;

		// Token: 0x04000447 RID: 1095
		private RadGroupBox c20519e39631afca245cc38ddc3d0f4f4;

		// Token: 0x04000448 RID: 1096
		private RadLabel cf90d956881ae51fef5294b4df13f69ec;

		// Token: 0x04000449 RID: 1097
		private RadLabel c807876d4a2a152f379070d951d5554eb;

		// Token: 0x0400044A RID: 1098
		public List<c6a2f8acae5ff1a8a909193a5c5de6687> c9f4bf79f56cd07529ca7850385fa2cb4;
	}
}
