using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Nus_Helper_Shared_Core.NusHelper.Saves;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000BA RID: 186
	public class cb99844a1fcc49eab64ce3660c283758b : RadForm
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x000300B4 File Offset: 0x0002E2B4
		public cb99844a1fcc49eab64ce3660c283758b(c5409344e1c2b74fa8c9a4d620ccb8d48 c6fcdfcca42c1aeed647bdea8d9051572)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			using (List<SaveDescription>.Enumerator enumerator = c6fcdfcca42c1aeed647bdea8d9051572.c6a83d4e684fcad568643a49c6ab6bbbf().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SaveDescription saveDescription = enumerator.Current;
					ListViewDataItem listViewDataItem = new ListViewDataItem
					{
						Tag = saveDescription
					};
					this.c4e5654776d3751c05c86f05414813e91.Items.Add(listViewDataItem);
					listViewDataItem[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13976)] = cb99844a1fcc49eab64ce3660c283758b.cf6c9d35d7ef7344aaed414d512533c5e(double.Parse(saveDescription.Timestamp)).ToShortDateString();
					listViewDataItem[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13980)] = saveDescription.Description;
				}
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb99844a1fcc49eab64ce3660c283758b..ctor(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0003018C File Offset: 0x0002E38C
		public static DateTime cf6c9d35d7ef7344aaed414d512533c5e(double ca6e7ae28488a488bba23e6130c1e6cec)
		{
			DateTime result = new DateTime(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13792), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13796), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13800), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13804), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13808), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13812), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13816), (DateTimeKind)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13820));
			result = result.AddSeconds(ca6e7ae28488a488bba23e6130c1e6cec).ToLocalTime();
			return result;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00030208 File Offset: 0x0002E408
		private void c90644c6a8ecc6e49ed693dfc3dea0737(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00030218 File Offset: 0x0002E418
		private void c0b961a93651ab95be91c5bbe046e48f0(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c4e5654776d3751c05c86f05414813e91.CheckedItems.Count != 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb99844a1fcc49eab64ce3660c283758b.c0b961a93651ab95be91c5bbe046e48f0(object, EventArgs)).MethodHandle;
				}
				if (this.c4e5654776d3751c05c86f05414813e91.CheckedItems.Count <= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13824))
				{
					this.cd94ded741fa1bbd88aacb9287dc5e8e0 = cd5c77ebaa36f6ef23c774856f1ca8a47.c0b398ab350e72b0d64d512bae8520b85(this.c4e5654776d3751c05c86f05414813e91.CheckedItems[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13828)].Tag);
					base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13832);
					base.Close();
					return;
				}
				for (;;)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51880));
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000302D8 File Offset: 0x0002E4D8
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13836);
			base.Close();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000302FC File Offset: 0x0002E4FC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb99844a1fcc49eab64ce3660c283758b.Dispose(bool)).MethodHandle;
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

		// Token: 0x06000699 RID: 1689 RVA: 0x00030344 File Offset: 0x0002E544
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ListViewDetailColumn listViewDetailColumn = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51927), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51944));
			ListViewDetailColumn listViewDetailColumn2 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51953), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51970));
			this.c4e5654776d3751c05c86f05414813e91 = new RadCheckedListBox();
			this.c2c8d44779f98bfe24d29fc0ee952d02d = new RadButton();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.c4e5654776d3751c05c86f05414813e91.BeginInit();
			this.c2c8d44779f98bfe24d29fc0ee952d02d.BeginInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			listViewDetailColumn.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51944);
			listViewDetailColumn2.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51970);
			listViewDetailColumn2.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13840);
			ListViewColumnCollection columns = this.c4e5654776d3751c05c86f05414813e91.Columns;
			ListViewDetailColumn[] array = c6188cbae417ac84374cf19bfcad5d59b.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13844));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13848)] = listViewDetailColumn;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13852)] = listViewDetailColumn2;
			columns.AddRange(array);
			this.c4e5654776d3751c05c86f05414813e91.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13856);
			this.c4e5654776d3751c05c86f05414813e91.ItemSpacing = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13860);
			this.c4e5654776d3751c05c86f05414813e91.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13864), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13868));
			this.c4e5654776d3751c05c86f05414813e91.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51993);
			this.c4e5654776d3751c05c86f05414813e91.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13872), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13876));
			this.c4e5654776d3751c05c86f05414813e91.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13880);
			this.c4e5654776d3751c05c86f05414813e91.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52010);
			this.c4e5654776d3751c05c86f05414813e91.ViewType = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13884);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13888);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13892), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13896));
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52047);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13900), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13904));
			this.c2c8d44779f98bfe24d29fc0ee952d02d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13908);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52066);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Click += this.c0b961a93651ab95be91c5bbe046e48f0;
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13912);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13916), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13920));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13924), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13928));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13932);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52081);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13936), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13940));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13944);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13948), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13952));
			base.Controls.Add(this.c4e5654776d3751c05c86f05414813e91);
			base.Controls.Add(this.c2c8d44779f98bfe24d29fc0ee952d02d);
			base.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13956);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52094);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13960) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13964) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13968);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52119);
			base.Load += this.c90644c6a8ecc6e49ed693dfc3dea0737;
			this.c4e5654776d3751c05c86f05414813e91.EndInit();
			this.c2c8d44779f98bfe24d29fc0ee952d02d.EndInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13972) != 0);
		}

		// Token: 0x04000384 RID: 900
		public SaveDescription cd94ded741fa1bbd88aacb9287dc5e8e0;

		// Token: 0x04000385 RID: 901
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000386 RID: 902
		private RadCheckedListBox c4e5654776d3751c05c86f05414813e91;

		// Token: 0x04000387 RID: 903
		private RadButton c2c8d44779f98bfe24d29fc0ee952d02d;

		// Token: 0x04000388 RID: 904
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;
	}
}
