using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000CD RID: 205
	public class c9e3b15e0906fc28b9aaaafda91843cfe : RadForm
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x0003C390 File Offset: 0x0003A590
		public c9e3b15e0906fc28b9aaaafda91843cfe(DataSize cf00748d6ac598f8f622ffaa4f409f181)
		{
			this.c99bd0308629665f2e3e03ee7beb41a5c = cf00748d6ac598f8f622ffaa4f409f181;
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0003C3B0 File Offset: 0x0003A5B0
		public static IEnumerable<DriveInfo> cc3d4a7300777c20f24e5baac6770deaf(bool c5794576365d456b1f51dbe353ec8af0a)
		{
			if (c5794576365d456b1f51dbe353ec8af0a)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9e3b15e0906fc28b9aaaafda91843cfe.cc3d4a7300777c20f24e5baac6770deaf(bool)).MethodHandle;
				}
				IEnumerable<DriveInfo> drives = DriveInfo.GetDrives();
				Func<DriveInfo, bool> predicate;
				if ((predicate = c9e3b15e0906fc28b9aaaafda91843cfe.<>c.c7319557ff7465b7526e153ddda2f4833) == null)
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
					predicate = (c9e3b15e0906fc28b9aaaafda91843cfe.<>c.c7319557ff7465b7526e153ddda2f4833 = new Func<DriveInfo, bool>(c9e3b15e0906fc28b9aaaafda91843cfe.<>c.cdfab1996eb8651828de2a4469aa3481e.c5a3950dc40d1f7f43478dd247328776b));
				}
				return new List<DriveInfo>(drives.Where(predicate));
			}
			IEnumerable<DriveInfo> drives2 = DriveInfo.GetDrives();
			Func<DriveInfo, bool> predicate2;
			if ((predicate2 = c9e3b15e0906fc28b9aaaafda91843cfe.<>c.cfc47a8c640f100d7af4810c58ccf3f40) == null)
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
				predicate2 = (c9e3b15e0906fc28b9aaaafda91843cfe.<>c.cfc47a8c640f100d7af4810c58ccf3f40 = new Func<DriveInfo, bool>(c9e3b15e0906fc28b9aaaafda91843cfe.<>c.cdfab1996eb8651828de2a4469aa3481e.cabac63052ffbf40e6a72daafe307a782));
			}
			return new List<DriveInfo>(drives2.Where(predicate2));
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0003C44C File Offset: 0x0003A64C
		private void c5c790c82bfb0468f7633a8303c571cf9(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			this.cc03532800ff1d794cf0667d76bee6416((this.cdf59729e0718800a452366420285ba91.Checked ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18704));
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0003C478 File Offset: 0x0003A678
		private void cad78f016da5613e77dc3f2692e1da488(object cd7b28952603b35a45c555982e677363a, object c3c9260886a6db15de49329a9f5b9836c)
		{
			base.Invoke(new MethodInvoker(this.c2cddd6c0ca7c92a9d1e8636adb213a7a));
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0003C49C File Offset: 0x0003A69C
		private void c921c06a681d0046a5490a660d8ca5ad6(object cd7b28952603b35a45c555982e677363a, FormClosingEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			try
			{
				this.cc1842125aaca3b1253209e38b94a489c.EventArrived -= new EventArrivedEventHandler(this.cad78f016da5613e77dc3f2692e1da488);
				this.cc1842125aaca3b1253209e38b94a489c.Dispose();
			}
			catch
			{
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003C4E0 File Offset: 0x0003A6E0
		private void c2113afe3356f61bca9ac106f22578079(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cc03532800ff1d794cf0667d76bee6416(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18708) != 0);
			try
			{
				this.cc1842125aaca3b1253209e38b94a489c = new ManagementEventWatcher();
				WqlEventQuery query = new WqlEventQuery(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67860));
				this.cc1842125aaca3b1253209e38b94a489c.EventArrived += new EventArrivedEventHandler(this.cad78f016da5613e77dc3f2692e1da488);
				this.cc1842125aaca3b1253209e38b94a489c.Query = query;
				this.cc1842125aaca3b1253209e38b94a489c.Start();
			}
			catch
			{
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0003C560 File Offset: 0x0003A760
		private void c6e4fbda580b7712acf135beb79f24edb(object cd7b28952603b35a45c555982e677363a, ListViewItemEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			DriveInfo driveInfo = c9b488f95d44a9906937aa2d2b556e79d.cd24593c859565ebb8c9faabbc5c75bef(cdf15457ee4816989343b6e6e96dd4cfe.Item.Tag);
			if (driveInfo.TotalSize < (long)this.c99bd0308629665f2e3e03ee7beb41a5c.TotalBytes)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9e3b15e0906fc28b9aaaafda91843cfe.c6e4fbda580b7712acf135beb79f24edb(object, ListViewItemEventArgs)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68010));
				return;
			}
			if (driveInfo.AvailableFreeSpace < (long)this.c99bd0308629665f2e3e03ee7beb41a5c.TotalBytes)
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
				DataSize dataSize = new DataSize(this.c99bd0308629665f2e3e03ee7beb41a5c.TotalBytes - (ulong)driveInfo.AvailableFreeSpace);
				RadMessageBox.Show(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68140), dataSize));
				if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68344), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68467), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18712)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18716))
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
					Process.Start(driveInfo.Name);
					return;
				}
			}
			else
			{
				this.cdeb88a4da0e27c7f39e2cad0c950f4b0 = driveInfo;
				base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18720);
				base.Close();
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0003C694 File Offset: 0x0003A894
		private void cc03532800ff1d794cf0667d76bee6416(bool c5794576365d456b1f51dbe353ec8af0a)
		{
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.Items.Clear();
			IEnumerator<DriveInfo> enumerator = c9e3b15e0906fc28b9aaaafda91843cfe.cc3d4a7300777c20f24e5baac6770deaf(c5794576365d456b1f51dbe353ec8af0a).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DriveInfo driveInfo = enumerator.Current;
					if (driveInfo.IsReady)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c9e3b15e0906fc28b9aaaafda91843cfe.cc03532800ff1d794cf0667d76bee6416(bool)).MethodHandle;
						}
						this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.BeginEdit();
						ListViewDataItem listViewDataItem = new ListViewDataItem(driveInfo.Name)
						{
							Image = c6faa5467be1a4874657b372a49b7c927.icnDisk,
							Tag = driveInfo,
							ImageAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18724),
							TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18728),
							TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18732)
						};
						this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.Items.Add(listViewDataItem);
						this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.EndEdit();
					}
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
						switch (1)
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

		// Token: 0x0600072C RID: 1836 RVA: 0x0003C7AC File Offset: 0x0003A9AC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9e3b15e0906fc28b9aaaafda91843cfe.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c = new RadListView();
			this.c15d9090b6a70d3a3c645fff30223e3a5 = new RadLabel();
			this.cdf59729e0718800a452366420285ba91 = new RadCheckBox();
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.BeginInit();
			this.c15d9090b6a70d3a3c645fff30223e3a5.BeginInit();
			this.cdf59729e0718800a452366420285ba91.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18736) != 0);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18740) != 0);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18744);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.FullRowSelect = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18748) != 0);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.ItemSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18752), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18756));
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18760), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18764));
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68496);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18768), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18772));
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18776);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.ViewType = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18780);
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.ItemMouseDoubleClick += new ListViewItemEventHandler(this.c6e4fbda580b7712acf135beb79f24edb);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18784);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18788), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18792));
			this.c15d9090b6a70d3a3c645fff30223e3a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47331);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18796), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18800));
			this.c15d9090b6a70d3a3c645fff30223e3a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18804);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68515);
			this.c15d9090b6a70d3a3c645fff30223e3a5.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.cdf59729e0718800a452366420285ba91.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18808);
			this.cdf59729e0718800a452366420285ba91.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18812), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18816));
			this.cdf59729e0718800a452366420285ba91.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68608);
			this.cdf59729e0718800a452366420285ba91.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18820), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18824));
			this.cdf59729e0718800a452366420285ba91.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18828);
			this.cdf59729e0718800a452366420285ba91.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68639);
			this.cdf59729e0718800a452366420285ba91.ToggleStateChanged += new StateChangedEventHandler(this.c5c790c82bfb0468f7633a8303c571cf9);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18832), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18836));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18840);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18844), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18848));
			base.Controls.Add(this.c5e9c7c4cce46fc17adea3b83aa6d6e9c);
			base.Controls.Add(this.cdf59729e0718800a452366420285ba91);
			base.Controls.Add(this.c15d9090b6a70d3a3c645fff30223e3a5);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18852);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68680);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18856));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18860) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18864) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18868);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(68709);
			base.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			base.FormClosing += this.c921c06a681d0046a5490a660d8ca5ad6;
			base.Load += this.c2113afe3356f61bca9ac106f22578079;
			this.c5e9c7c4cce46fc17adea3b83aa6d6e9c.EndInit();
			this.c15d9090b6a70d3a3c645fff30223e3a5.EndInit();
			this.cdf59729e0718800a452366420285ba91.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18872) != 0);
			base.PerformLayout();
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003CC84 File Offset: 0x0003AE84
		[CompilerGenerated]
		private void c2cddd6c0ca7c92a9d1e8636adb213a7a()
		{
			this.cc03532800ff1d794cf0667d76bee6416((this.cdf59729e0718800a452366420285ba91.Checked ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18876));
		}

		// Token: 0x0400043D RID: 1085
		public DriveInfo cdeb88a4da0e27c7f39e2cad0c950f4b0;

		// Token: 0x0400043E RID: 1086
		private DataSize c99bd0308629665f2e3e03ee7beb41a5c;

		// Token: 0x0400043F RID: 1087
		private ManagementEventWatcher cc1842125aaca3b1253209e38b94a489c;

		// Token: 0x04000440 RID: 1088
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000441 RID: 1089
		private RadListView c5e9c7c4cce46fc17adea3b83aa6d6e9c;

		// Token: 0x04000442 RID: 1090
		private RadLabel c15d9090b6a70d3a3c645fff30223e3a5;

		// Token: 0x04000443 RID: 1091
		private RadCheckBox cdf59729e0718800a452366420285ba91;
	}
}
