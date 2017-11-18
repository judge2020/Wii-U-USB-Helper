using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using IWshRuntimeLibrary;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Taskbar;
using Newtonsoft.Json;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI.Gauges;
using WIIU_Downloader.Forms;
using WIIU_Downloader.Properties;

namespace A
{
	// Token: 0x020000D5 RID: 213
	public class cb6cc9a5b122137bc5f2718f61ab49e59 : RadForm
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x0003F3B0 File Offset: 0x0003D5B0
		public cb6cc9a5b122137bc5f2718f61ab49e59()
		{
			if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44884)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59..ctor()).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95266));
				Application.Restart();
			}
			this.c82b8091adcf720aa7a90631953c644c8();
			c6a5e9b85d86b4e098a511017a1073d71.c1f84333d7942c2315ee42eb2b5f59625 += this.cdc13f3e230d3484c2cb0667c567d126f;
			base.WindowState = (FormWindowState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29456);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29460);
			if (c479e8db4c3904e6e9ba81ae22ea4843e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.WindowPosition, Rectangle.Empty))
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
				if (cb6cc9a5b122137bc5f2718f61ab49e59.ccaa54655e0c110587703ca98c7d41205(Settings.Default.WindowPosition))
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
					base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29464);
					base.DesktopBounds = Settings.Default.WindowPosition;
					base.WindowState = Settings.Default.WindowState;
					goto IL_1CF;
				}
			}
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29468);
			base.Size = Settings.Default.WindowPosition.Size;
			IL_1CF:
			RadDock radDock = this.ced92a8662e50218f546ae6bb0a312b4f;
			FloatingWindowEventHandler floatingWindowEventHandler;
			if ((floatingWindowEventHandler = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c52b9e3bd962ece1172c4c36e3840aaf2) == null)
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
				floatingWindowEventHandler = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c52b9e3bd962ece1172c4c36e3840aaf2 = new FloatingWindowEventHandler(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c7a8d8de37df3035006f19352e82bcbb0));
			}
			radDock.FloatingWindowCreated += floatingWindowEventHandler;
			RadDock radDock2 = this.ceda6b294518e1db9b1aa8a671392c806;
			FloatingWindowEventHandler floatingWindowEventHandler2;
			if ((floatingWindowEventHandler2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8f81c225be543b6d4865a6b2c75fdf1a) == null)
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
				floatingWindowEventHandler2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8f81c225be543b6d4865a6b2c75fdf1a = new FloatingWindowEventHandler(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c4e32127ace5a8628ca17f573dc81e1fd));
			}
			radDock2.FloatingWindowCreated += floatingWindowEventHandler2;
			this.cbe7fa4761f85da94859280c8565879f4.MouseDoubleClick += new MouseEventHandler(cb6cc9a5b122137bc5f2718f61ab49e59.c931bc94d391c5d80e9ebdbb9da1fe0da);
			this.cb4a1967318bc2f47a2a97d027e20d00f.MouseDoubleClick += new MouseEventHandler(cb6cc9a5b122137bc5f2718f61ab49e59.c931bc94d391c5d80e9ebdbb9da1fe0da);
			this.cf79908ea7fb179e130decfd49ac2942e.MouseDoubleClick += new MouseEventHandler(cb6cc9a5b122137bc5f2718f61ab49e59.c931bc94d391c5d80e9ebdbb9da1fe0da);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0003F698 File Offset: 0x0003D898
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			FormWindowState windowState = base.WindowState;
			if (windowState != FormWindowState.Normal)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.OnClosed(EventArgs)).MethodHandle;
				}
				if (windowState != (FormWindowState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19812))
				{
					Settings.Default.WindowState = (FormWindowState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19816);
					goto IL_69;
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
			Settings.Default.WindowState = base.WindowState;
			IL_69:
			base.Visible = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19820) != 0);
			base.WindowState = (FormWindowState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19824);
			Settings.Default.WindowPosition = base.DesktopBounds;
			Settings.Default.Save();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0003F750 File Offset: 0x0003D950
		protected unsafe override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19828))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ProcessCmdKey(Message*, Keys)).MethodHandle;
				}
				this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Select();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19832) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19836))
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
				this.c19ea03710ebcce9d9618141875fa6b4b.Select();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19840) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19844))
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
				this.c96d38c3849e994101ac7564a97ee637d.Select();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19848) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19852))
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
				this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Select();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19856) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19860))
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
				this.c3cc59d9c7d75e7586fc9064eea5aa1be.Select();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19864) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19868))
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
				this.c38e15f9793026f5c07a201f09952a0ac.Select();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19872) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19876))
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
				this.c5cedfdbf9e879295d762e0b02d960d33.Select();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19880) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19884))
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
				c6a5e9b85d86b4e098a511017a1073d71.cc55f7f0034df77b96f2d07b4452a2c71 = ((c6a5e9b85d86b4e098a511017a1073d71.cc55f7f0034df77b96f2d07b4452a2c71 ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19888));
				string c0d6c37d812d5d4b610705a6421056252 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69636);
				string c0d6c37d812d5d4b610705a64210562522;
				if (!c6a5e9b85d86b4e098a511017a1073d71.cc55f7f0034df77b96f2d07b4452a2c71)
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
					c0d6c37d812d5d4b610705a64210562522 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69663);
				}
				else
				{
					c0d6c37d812d5d4b610705a64210562522 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69680);
				}
				RadMessageBox.Show(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, c0d6c37d812d5d4b610705a64210562522));
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19892) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19896))
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
				c6a5e9b85d86b4e098a511017a1073d71.cd97926c82fa3cae54a0afb338e5ca487 = ((c6a5e9b85d86b4e098a511017a1073d71.cd97926c82fa3cae54a0afb338e5ca487 ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19900));
				string c0d6c37d812d5d4b610705a64210562523 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69695);
				string c0d6c37d812d5d4b610705a64210562524;
				if (!c6a5e9b85d86b4e098a511017a1073d71.cd97926c82fa3cae54a0afb338e5ca487)
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
					c0d6c37d812d5d4b610705a64210562524 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69663);
				}
				else
				{
					c0d6c37d812d5d4b610705a64210562524 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69680);
				}
				RadMessageBox.Show(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a64210562523, c0d6c37d812d5d4b610705a64210562524));
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19904) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19908))
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
				this.c90fe97b27e47a56fbdfb26d97ff3fbe0.Focus();
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19912) != 0;
			}
			if (keyData == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19916))
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
				this.cf6348eb630c0b01e77b8f83ec7151d96.Focus();
				try
				{
					IEnumerable<ListViewDataItem> items = this.cf6348eb630c0b01e77b8f83ec7151d96.Items;
					Func<ListViewDataItem, bool> predicate;
					if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c7319557ff7465b7526e153ddda2f4833) == null)
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
						predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c7319557ff7465b7526e153ddda2f4833 = new Func<ListViewDataItem, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c0b200bdc74e4e436b5ad6fb525313077));
					}
					ListViewDataItem listViewDataItem = items.First(predicate);
					this.cf6348eb630c0b01e77b8f83ec7151d96.ListViewElement.EnsureItemVisible(listViewDataItem);
					this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItem = listViewDataItem;
				}
				catch
				{
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19920) != 0;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0003FA7C File Offset: 0x0003DC7C
		private static string OutputPath { get; } = Path.Combine(Settings.Default.Path, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613));

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0003FA90 File Offset: 0x0003DC90
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x0003FAA4 File Offset: 0x0003DCA4
		private bool CurrentlyDownloading { get; set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0003FAB8 File Offset: 0x0003DCB8
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x0003FACC File Offset: 0x0003DCCC
		private c60797b4f8bfa489df1954dcdc88ad77d frmWait { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0003FAE0 File Offset: 0x0003DCE0
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x0003FAF4 File Offset: 0x0003DCF4
		private int IndexGameCurrentlyDownloaded { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0003FB08 File Offset: 0x0003DD08
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0003FB1C File Offset: 0x0003DD1C
		private List<Platform> Platforms { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0003FB30 File Offset: 0x0003DD30
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x0003FB44 File Offset: 0x0003DD44
		private WebProxy Proxy { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0003FB58 File Offset: 0x0003DD58
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x0003FB6C File Offset: 0x0003DD6C
		private c5409344e1c2b74fa8c9a4d620ccb8d48 SelectedGame { get; set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0003FB80 File Offset: 0x0003DD80
		private List<c6114b34ba4893a53ebb4b599e0e2e3fc> TitlesToCopy { get; } = new List<c6114b34ba4893a53ebb4b599e0e2e3fc>();

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0003FB94 File Offset: 0x0003DD94
		private List<c6114b34ba4893a53ebb4b599e0e2e3fc> TitlesToDownload { get; } = new List<c6114b34ba4893a53ebb4b599e0e2e3fc>();

		// Token: 0x06000767 RID: 1895 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
		private static Color cc213bd6b56f3c82ebc38eabf78e72386(c6114b34ba4893a53ebb4b599e0e2e3fc c6b7fbe462f43433d64916e9273f7e5d1)
		{
			if (c6b7fbe462f43433d64916e9273f7e5d1.DiscOnly)
			{
				return Color.LightGoldenrodYellow;
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
			if (!true)
			{
				RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc213bd6b56f3c82ebc38eabf78e72386(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
			}
			if (c6b7fbe462f43433d64916e9273f7e5d1.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19924))
			{
				return Color.Green;
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
			if (c6b7fbe462f43433d64916e9273f7e5d1.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19928))
			{
				return Color.DarkOrange;
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
			if (!ThemeResolutionService.ApplicationThemeName.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69726)))
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
				return Color.Black;
			}
			return Color.White;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0003FC60 File Offset: 0x0003DE60
		private static void cf9c50c376f7589fb13d15a3b0a2bd920(c5409344e1c2b74fa8c9a4d620ccb8d48 c6fcdfcca42c1aeed647bdea8d9051572)
		{
			if (c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cf9c50c376f7589fb13d15a3b0a2bd920(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				return;
			}
			if (c6fcdfcca42c1aeed647bdea8d9051572.c66201ce2763de795655e645e059b6451)
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
				c6e4901274630d05cbbf6924f95d2edfb c1b244cd4be573ae37f8e3f6fd69b891f = c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f;
				Image image;
				if (c6fcdfcca42c1aeed647bdea8d9051572.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19932))
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
					image = cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image, c6faa5467be1a4874657b372a49b7c927.hasUpdate);
				}
				else
				{
					image = cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image, c6faa5467be1a4874657b372a49b7c927.hasUpdateOk);
				}
				c1b244cd4be573ae37f8e3f6fd69b891f.Image = image;
			}
			if (c6fcdfcca42c1aeed647bdea8d9051572.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
				c6e4901274630d05cbbf6924f95d2edfb c1b244cd4be573ae37f8e3f6fd69b891f2 = c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f;
				Image image2;
				if (c6fcdfcca42c1aeed647bdea8d9051572.Dlc.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19936))
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
					image2 = cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image, c6faa5467be1a4874657b372a49b7c927.hasDLC);
				}
				else
				{
					image2 = cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image, c6faa5467be1a4874657b372a49b7c927.hasDLCOk);
				}
				c1b244cd4be573ae37f8e3f6fd69b891f2.Image = image2;
			}
			switch (c6fcdfcca42c1aeed647bdea8d9051572.System)
			{
			case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
				c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image = cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image, c6faa5467be1a4874657b372a49b7c927.tag3ds);
				break;
			case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
				c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image = cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image, c6faa5467be1a4874657b372a49b7c927.tagWiiU);
				break;
			case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
				throw new NotImplementedException();
			}
			if (c6fcdfcca42c1aeed647bdea8d9051572.c69ce979c7f0d69fc5bdbed5a8bb3804f)
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
				c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image = cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image, c6faa5467be1a4874657b372a49b7c927.newTag);
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0003FE3C File Offset: 0x0003E03C
		private static bool ce3811080ab0cfeda119c5345a894cda0(string cc9f36ab8599957a993eea667b1cca61f)
		{
			bool result;
			try
			{
				Directory.GetAccessControl(cc9f36ab8599957a993eea667b1cca61f);
				result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19940) != 0);
			}
			catch (UnauthorizedAccessException)
			{
				result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19944) != 0);
			}
			return result;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0003FE80 File Offset: 0x0003E080
		private static void c9c62825250b277ed85c9a4930df9d3d1()
		{
			c67726bc94fb4dd43c5c00e863a4fed19.c026aee694fa251c8a3860993dce5e0db(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69735));
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		private static void cafc7445bc88f604abf9415d0369712be(c5409344e1c2b74fa8c9a4d620ccb8d48 c6fcdfcca42c1aeed647bdea8d9051572)
		{
			if (!cacd6f8420e56d296adef754f4a362ae7.c3fcf5c54f75fc17c7e5ebe876702d817)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cafc7445bc88f604abf9415d0369712be(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69740));
				return;
			}
			if (!c6fcdfcca42c1aeed647bdea8d9051572.c1083de0b8d92c5fcbdd7005111d34bb9)
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
				return;
			}
			try
			{
				cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b = c6fcdfcca42c1aeed647bdea8d9051572.c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19948) != 0);
				if (!cf7c96734e58d8de9864e1ea854bc2b7b.c529da0940d4ea14c178fe93b48b61b96)
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
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70020));
				}
				else
				{
					string text = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70342));
					string text2 = Path.Combine(text, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c6fcdfcca42c1aeed647bdea8d9051572.TitleId.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70353)));
					Directory.CreateDirectory(text);
					MemoryStream memoryStream = new MemoryStream(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c6fcdfcca42c1aeed647bdea8d9051572.IconUrl));
					try
					{
						FileStream fileStream = File.Create(text2);
						try
						{
							cbdb71b60ec0ae0ebae5950cc72976b68.c8a36cb9052e7932c0f930a1ccef40254(c32037f571be75ec9395b718eab8129e7.cd24593c859565ebb8c9faabbc5c75bef(Image.FromStream(memoryStream)), fileStream, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19952), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19956) != 0);
						}
						finally
						{
							if (fileStream != null)
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
								((IDisposable)fileStream).Dispose();
							}
						}
					}
					finally
					{
						if (memoryStream != null)
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
							((IDisposable)memoryStream).Dispose();
						}
					}
					cb6cc9a5b122137bc5f2718f61ab49e59.c48d94023cc7eea15910ed31b4e97ce6f(c6114b34ba4893a53ebb4b599e0e2e3fc.cdcb3a73ed076ade5e36c8c8a410f82aa(c6fcdfcca42c1aeed647bdea8d9051572.Name), Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19960)), cf7c96734e58d8de9864e1ea854bc2b7b.c9ad9e3ddcd7e5e324cd01b2dfad9f78d(), text2, c6fcdfcca42c1aeed647bdea8d9051572.Name, cf7c96734e58d8de9864e1ea854bc2b7b.c725acc3eddb72d7ac90f323bc7845e34());
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70362));
				}
			}
			catch (Exception ex)
			{
				RadMessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000400AC File Offset: 0x0003E2AC
		private static void c48d94023cc7eea15910ed31b4e97ce6f(string cb88cb13e083109e8b9ea69dc7d7dd62d, string cf953a2e3cc52afceb7bf7959e338a97d, string c093b1b7247ec93e3b486c5563c110866, string ccd6d2d2c4b509bcdc8fd9a327d2fe222, string c9a1d53a52573cd619e583426889bec4c, string c9197930d1c0db813352b85301cede199)
		{
			string pathLink = Path.Combine(cf953a2e3cc52afceb7bf7959e338a97d, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cb88cb13e083109e8b9ea69dc7d7dd62d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70423)));
			WshShell wshShell = ca43cac8d5e8aa63a63cf766deb576910.cd24593c859565ebb8c9faabbc5c75bef(Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70432)))));
			if (cb6cc9a5b122137bc5f2718f61ab49e59.c23431b066782f5245f26984f24cc029d.ca434e07f49207bc8d8ae6d6f508d6eac == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c48d94023cc7eea15910ed31b4e97ce6f(string, string, string, string, string, string)).MethodHandle;
				}
				cb6cc9a5b122137bc5f2718f61ab49e59.c23431b066782f5245f26984f24cc029d.ca434e07f49207bc8d8ae6d6f508d6eac = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert((CSharpBinderFlags)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19964), Type.GetTypeFromHandle(c64ce647c8ab1838f855eb5fdeea4d7ae.cde4d1aeffe0e705b07e1b3d74e931465()), Type.GetTypeFromHandle(c2555811fe1bbe3f7c849a1a259769b09.cde4d1aeffe0e705b07e1b3d74e931465())));
			}
			IWshShortcut wshShortcut = cb6cc9a5b122137bc5f2718f61ab49e59.c23431b066782f5245f26984f24cc029d.ca434e07f49207bc8d8ae6d6f508d6eac.Target(cb6cc9a5b122137bc5f2718f61ab49e59.c23431b066782f5245f26984f24cc029d.ca434e07f49207bc8d8ae6d6f508d6eac, wshShell.CreateShortcut(pathLink));
			wshShortcut.Arguments = c9197930d1c0db813352b85301cede199;
			wshShortcut.Description = c9a1d53a52573cd619e583426889bec4c;
			wshShortcut.IconLocation = ccd6d2d2c4b509bcdc8fd9a327d2fe222;
			wshShortcut.TargetPath = c093b1b7247ec93e3b486c5563c110866;
			wshShortcut.WorkingDirectory = Path.GetDirectoryName(c093b1b7247ec93e3b486c5563c110866);
			wshShortcut.Save();
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000401A0 File Offset: 0x0003E3A0
		private static bool c5c48bfb3019784ac92b83653ab34e32a(string cc9f36ab8599957a993eea667b1cca61f)
		{
			if (!string.IsNullOrEmpty(cc9f36ab8599957a993eea667b1cca61f))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(string)).MethodHandle;
				}
				if (Directory.Exists(cc9f36ab8599957a993eea667b1cca61f))
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
					return cb6cc9a5b122137bc5f2718f61ab49e59.ce3811080ab0cfeda119c5345a894cda0(cc9f36ab8599957a993eea667b1cca61f);
				}
			}
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19968) != 0;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000401F4 File Offset: 0x0003E3F4
		private static bool c3c3fdb0497dbe1080a567a755ee044d4(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7)
		{
			bool result;
			try
			{
				result = c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cbc47e314a0f1d7d5f1d07b50ba2bb8c7.Substring(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19972), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19976)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70505));
			}
			catch
			{
				result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19980) != 0);
			}
			return result;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00040254 File Offset: 0x0003E454
		private static bool ccaa54655e0c110587703ca98c7d41205(Rectangle c58cab73e14302dab350a5aebeedf8f7b)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cb354b1af13f28aa61abe418886451f86 cb354b1af13f28aa61abe418886451f = new cb6cc9a5b122137bc5f2718f61ab49e59.cb354b1af13f28aa61abe418886451f86();
			cb354b1af13f28aa61abe418886451f.c58cab73e14302dab350a5aebeedf8f7b = c58cab73e14302dab350a5aebeedf8f7b;
			return Screen.AllScreens.Any(new Func<Screen, bool>(cb354b1af13f28aa61abe418886451f.c7efbba997c9425782270845900488a29));
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00040288 File Offset: 0x0003E488
		private static Image c4559f07b5d31d239dcd2d70962c1e2e6(Image c18664fa0c39bdb6c49983e409cd6de08, Image c72d6fd3f54b18d69e7326349f3fc3915)
		{
			Bitmap bitmap = new Bitmap(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19984), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19988));
			Image result;
			try
			{
				Graphics graphics = Graphics.FromImage(bitmap);
				try
				{
					graphics.InterpolationMode = (InterpolationMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19992);
					graphics.DrawImage(c18664fa0c39bdb6c49983e409cd6de08, new PointF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19996), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(20000)));
					graphics.DrawImage(c72d6fd3f54b18d69e7326349f3fc3915, new PointF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(20004), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(20008)));
					graphics.Save();
				}
				finally
				{
					if (graphics != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c4559f07b5d31d239dcd2d70962c1e2e6(Image, Image)).MethodHandle;
						}
						((IDisposable)graphics).Dispose();
					}
				}
				try
				{
					MemoryStream stream = new MemoryStream();
					bitmap.Save(stream, ImageFormat.Bmp);
					result = Image.FromStream(stream);
				}
				catch
				{
					result = cafec3579a55ef0ba5bcc1f341243b3ba.cab55a050df275722227783d6686266c9;
				}
			}
			finally
			{
				if (bitmap != null)
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
					((IDisposable)bitmap).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000403A0 File Offset: 0x0003E5A0
		private static void c50ec04c4631f5c7886b66d5bd3d32241(string cad48e7cec482eb202b35baba9979de2f, string c2e59f973437ea79c9b95a2c0ce2d33db)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70514),
					Arguments = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70529), cad48e7cec482eb202b35baba9979de2f, c2e59f973437ea79c9b95a2c0ce2d33db),
					UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20012) != 0),
					Verb = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10436)
				}
			}.Start();
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00040414 File Offset: 0x0003E614
		private static void c931bc94d391c5d80e9ebdbb9da1fe0da(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			PictureBox pictureBox = c2f00bfe25139e82d533630d75e9d4ec1.cd24593c859565ebb8c9faabbc5c75bef(cd7b28952603b35a45c555982e677363a);
			if (pictureBox.Image != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c931bc94d391c5d80e9ebdbb9da1fe0da(object, EventArgs)).MethodHandle;
				}
				new c68525722ec1c851086937cebaadd5aba(pictureBox.Image).ShowDialog();
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0004045C File Offset: 0x0003E65C
		private static bool c1429a6dc344ce1d6f1cdeb4f895f60dc(bool c1895ad36e6f8c1136a5cd470065c05df)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
			{
				Title = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70568),
				IsFolderPicker = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20016) != 0)
			};
			while (commonOpenFileDialog.ShowDialog() != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20020))
			{
				if (cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(commonOpenFileDialog.FileName))
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
					Settings.Default.ExtractFolder = commonOpenFileDialog.FileName;
					Settings.Default.Save();
					return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20028) != 0;
				}
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
			if (!true)
			{
				RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1429a6dc344ce1d6f1cdeb4f895f60dc(bool)).MethodHandle;
			}
			return (c1895ad36e6f8c1136a5cd470065c05df ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20024);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0004050C File Offset: 0x0003E70C
		private static bool c130125f48ba039b5fcd9946712efb476(bool c1895ad36e6f8c1136a5cd470065c05df)
		{
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70657));
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
			{
				IsFolderPicker = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20032) != 0),
				Title = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(70967)
			};
			while (commonOpenFileDialog.ShowDialog() != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20036))
			{
				if (cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(commonOpenFileDialog.FileName))
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
					DirectoryInfo directoryInfo = new DirectoryInfo(commonOpenFileDialog.FileName);
					string path = commonOpenFileDialog.FileName;
					if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(directoryInfo.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613)))
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
						if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(directoryInfo.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71046)))
						{
							goto IL_101;
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
					path = directoryInfo.Parent.FullName;
					IL_101:
					Settings.Default.Path = path;
					Settings.Default.Save();
					return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20044) != 0;
				}
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
				RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c130125f48ba039b5fcd9946712efb476(bool)).MethodHandle;
			}
			return (c1895ad36e6f8c1136a5cd470065c05df ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20040);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00040640 File Offset: 0x0003E840
		private static void cfe0e4c92c49b7fdb2a89905d7374714b()
		{
			if (!Settings.Default.ShowEmulatorDataWarning)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cfe0e4c92c49b7fdb2a89905d7374714b()).MethodHandle;
				}
				return;
			}
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71063));
			Settings.Default.ShowEmulatorDataWarning = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20048) != 0);
			Settings.Default.Save();
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000406A8 File Offset: 0x0003E8A8
		private static void cc5c57405ebb88aff3ea74e2576a29bb0(TimeSpan cf1cc9bc7f20e07f3b88f8be0de09f98a, RadLabel c1139a34319f573b5050d06fd97623321)
		{
			string text;
			if (cf1cc9bc7f20e07f3b88f8be0de09f98a.TotalSeconds <= cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(20052))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc5c57405ebb88aff3ea74e2576a29bb0(TimeSpan, RadLabel)).MethodHandle;
				}
				text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71853);
			}
			else
			{
				text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71900), cf1cc9bc7f20e07f3b88f8be0de09f98a.Hours, cf1cc9bc7f20e07f3b88f8be0de09f98a.Minutes, cf1cc9bc7f20e07f3b88f8be0de09f98a.Seconds);
			}
			c1139a34319f573b5050d06fd97623321.Text = text;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00040730 File Offset: 0x0003E930
		private static void c396bb5650d2a017f9cd444c7c9996cba()
		{
			try
			{
				string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71941));
				string c0d6c37d812d5d4b610705a6421056252 = new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(71964));
				SHA256 sha = SHA256.Create();
				try
				{
					if (File.Exists(path))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c396bb5650d2a017f9cd444c7c9996cba()).MethodHandle;
						}
						if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Convert.ToBase64String(sha.ComputeHash(File.ReadAllBytes(path))), c0d6c37d812d5d4b610705a6421056252))
						{
							goto IL_CD;
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
					}
					byte[] array = new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72065));
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Convert.ToBase64String(sha.ComputeHash(array)), c0d6c37d812d5d4b610705a6421056252))
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
						File.WriteAllBytes(path, array);
					}
					IL_CD:;
				}
				finally
				{
					if (sha != null)
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
						((IDisposable)sha).Dispose();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00040844 File Offset: 0x0003EA44
		private void c97771ef24da9591c965bc884a27c01c0(c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1)
		{
			this.c7a8112437fc6661ae742d22be70531e6(c6b7fbe462f43433d64916e9273f7e5d1);
			try
			{
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c97771ef24da9591c965bc884a27c01c0(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
					}
					if (!this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.c2d3f26433491ff35cdc3587b8acfa19d(c6b7fbe462f43433d64916e9273f7e5d1.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>()))
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
						if (c6b7fbe462f43433d64916e9273f7e5d1.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20060))
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
							if (RadMessageBox.Show(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72164), c6b7fbe462f43433d64916e9273f7e5d1), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72352), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20064)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20068))
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
								this.c7a8112437fc6661ae742d22be70531e6(c6b7fbe462f43433d64916e9273f7e5d1.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>());
							}
						}
					}
				}
				if (c6b7fbe462f43433d64916e9273f7e5d1.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
					if (!this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.c2d3f26433491ff35cdc3587b8acfa19d(c6b7fbe462f43433d64916e9273f7e5d1.Dlc))
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
						if (c6b7fbe462f43433d64916e9273f7e5d1.Dlc.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20072))
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
						}
						else if (RadMessageBox.Show(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72375), c6b7fbe462f43433d64916e9273f7e5d1), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72555), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20076)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20080))
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
							this.c7a8112437fc6661ae742d22be70531e6(c6b7fbe462f43433d64916e9273f7e5d1.Dlc);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00040A00 File Offset: 0x0003EC00
		private ListViewDataItem cddf0b14fb7ade8f11695210af254e750(c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1, RadListView c82dd34236c6c1a53878feade40e0b3a1)
		{
			ListViewDataItem listViewDataItem = new ListViewDataItem(c6b7fbe462f43433d64916e9273f7e5d1)
			{
				Tag = c6b7fbe462f43433d64916e9273f7e5d1
			};
			listViewDataItem.Group = this.c3b8d58494a1935b104c4727552adea4e(c6b7fbe462f43433d64916e9273f7e5d1);
			listViewDataItem.ForeColor = cb6cc9a5b122137bc5f2718f61ab49e59.cc213bd6b56f3c82ebc38eabf78e72386(c6b7fbe462f43433d64916e9273f7e5d1);
			c82dd34236c6c1a53878feade40e0b3a1.Items.Add(listViewDataItem);
			listViewDataItem[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20084)] = c6b7fbe462f43433d64916e9273f7e5d1.Name;
			listViewDataItem[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20088)] = c6b7fbe462f43433d64916e9273f7e5d1.Region;
			listViewDataItem[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20092)] = c6b7fbe462f43433d64916e9273f7e5d1.Size;
			listViewDataItem[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20096)] = c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c6b7fbe462f43433d64916e9273f7e5d1.cce55c1c54594dc99c5eedaa006793af4, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72572));
			ListViewDataItem listViewDataItem2 = listViewDataItem;
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20100);
			object obj;
			if (!c6b7fbe462f43433d64916e9273f7e5d1.c66201ce2763de795655e645e059b6451)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cddf0b14fb7ade8f11695210af254e750(c5409344e1c2b74fa8c9a4d620ccb8d48, RadListView)).MethodHandle;
				}
				obj = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72575);
			}
			else if (c6b7fbe462f43433d64916e9273f7e5d1.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20104))
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
				obj = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72580);
			}
			else
			{
				obj = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72587);
			}
			listViewDataItem2[num] = obj;
			ListViewDataItem listViewDataItem3 = listViewDataItem;
			int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20108);
			object obj2;
			if (!c6b7fbe462f43433d64916e9273f7e5d1.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
				obj2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72575);
			}
			else if (c6b7fbe462f43433d64916e9273f7e5d1.Dlc.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20112))
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
				obj2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72580);
			}
			else
			{
				obj2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72587);
			}
			listViewDataItem3[num2] = obj2;
			return listViewDataItem;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00040BB8 File Offset: 0x0003EDB8
		private void cced076417085a35a106849899c95b63e(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			if (this.TitlesToCopy.Contains(c804bc52f7f79bffee6fd394ef382eb76))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cced076417085a35a106849899c95b63e(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				return;
			}
			this.TitlesToCopy.Add(c804bc52f7f79bffee6fd394ef382eb76);
			ListViewDataItem listViewDataItem = new ListViewDataItem(c804bc52f7f79bffee6fd394ef382eb76)
			{
				Tag = c804bc52f7f79bffee6fd394ef382eb76
			};
			this.c3f17fb9a80a6565749e0532cfc37cf36.Items.Add(listViewDataItem);
			this.c65cf7cdc28eee52d9c7a54f014164e29();
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00040C20 File Offset: 0x0003EE20
		private void c7a8112437fc6661ae742d22be70531e6(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c41fa807328813b496156bdf17273ae5f c41fa807328813b496156bdf17273ae5f = new cb6cc9a5b122137bc5f2718f61ab49e59.c41fa807328813b496156bdf17273ae5f();
			c41fa807328813b496156bdf17273ae5f.c4404a159870bf55bb6f111e66e59e82d = this;
			c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76 = c804bc52f7f79bffee6fd394ef382eb76;
			if (c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76.DiscOnly)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c7a8112437fc6661ae742d22be70531e6(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72598));
				return;
			}
			if (c579af5100c3e117f64e502931598c510.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(new DateTime(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20116), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20120), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20124)), DateTime.Today))
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
				if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72918)))
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
					if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72951)))
					{
						goto IL_101;
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
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72984));
			}
			IL_101:
			if (!this.TitlesToDownload.Contains(c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76))
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
				cb6cc9a5b122137bc5f2718f61ab49e59.c1c4d6e3a4f6f10a11499584c3e806c0f c1c4d6e3a4f6f10a11499584c3e806c0f = new cb6cc9a5b122137bc5f2718f61ab49e59.c1c4d6e3a4f6f10a11499584c3e806c0f();
				c1c4d6e3a4f6f10a11499584c3e806c0f.c8c38354cddaefb45b9cfcd9ed2838c37 = c41fa807328813b496156bdf17273ae5f;
				if (c1c4d6e3a4f6f10a11499584c3e806c0f.c8c38354cddaefb45b9cfcd9ed2838c37.c804bc52f7f79bffee6fd394ef382eb76.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20128))
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
					if (Settings.Default.ShowHaxchiWarning)
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
						if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73228), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73542), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20132)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20136))
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
							return;
						}
						Settings.Default.ShowHaxchiWarning = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20140) != 0);
						Settings.Default.Save();
					}
				}
				this.TitlesToDownload.Add(c1c4d6e3a4f6f10a11499584c3e806c0f.c8c38354cddaefb45b9cfcd9ed2838c37.c804bc52f7f79bffee6fd394ef382eb76);
				c1c4d6e3a4f6f10a11499584c3e806c0f.cdeb883c40f9a2378d88e71037beec6cb = new ListViewDataItem
				{
					Tag = c1c4d6e3a4f6f10a11499584c3e806c0f.c8c38354cddaefb45b9cfcd9ed2838c37.c804bc52f7f79bffee6fd394ef382eb76
				};
				try
				{
					Task.Run(new Action(c1c4d6e3a4f6f10a11499584c3e806c0f.c212528870534101e461716cfd74c73cb));
				}
				catch
				{
				}
				this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items.Add(c1c4d6e3a4f6f10a11499584c3e806c0f.cdeb883c40f9a2378d88e71037beec6cb);
				this.c44272853dcc0c97ee7511d3b33f129b2.ButtonElement.BorderElement.ForeColor = Color.Green;
				if (this.c3594d8d99bfd6c1696f290e195f9566d == null)
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
					this.c3594d8d99bfd6c1696f290e195f9566d = new System.Windows.Forms.Timer
					{
						Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20144)
					};
					this.c3594d8d99bfd6c1696f290e195f9566d.Tick += this.cc915e6ec0e26138209bcfec4ab620d06;
					this.c3594d8d99bfd6c1696f290e195f9566d.Start();
				}
				this.c3594d8d99bfd6c1696f290e195f9566d.Start();
				c1c4d6e3a4f6f10a11499584c3e806c0f.cdeb883c40f9a2378d88e71037beec6cb[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20148)] = c1c4d6e3a4f6f10a11499584c3e806c0f.c8c38354cddaefb45b9cfcd9ed2838c37.c804bc52f7f79bffee6fd394ef382eb76.ToString();
				this.cf198d0c85e4a43bf5b54955c482f8c3a();
				if (this.CurrentlyDownloading)
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
					this.cc86ba4499172993cc63947e93cc907ae.c4459ea1028b880865dae5dd23da9f3f2();
				}
				this.c9b5265c0946a689327a8c65feda18f1e();
			}
			c5409344e1c2b74fa8c9a4d620ccb8d48 selectedGame = this.SelectedGame;
			bool flag;
			if (selectedGame == null)
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
				flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20152) != 0);
			}
			else
			{
				flag = ((selectedGame.cdafb32c110213e85fda6c89dc227c65b(c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20156));
			}
			if (flag)
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
				return;
			}
			if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76) != null)
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
				this.cb3f03a694ca97a057d1693262571d407.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20160) != 0);
				return;
			}
			if (c9d462d6bfbf0a4267f7ed91db470887c.c0b398ab350e72b0d64d512bae8520b85(c41fa807328813b496156bdf17273ae5f.c804bc52f7f79bffee6fd394ef382eb76) != null)
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
				this.c5de69d272cb033f108f47623f7fef008.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20164) != 0);
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00040FEC File Offset: 0x0003F1EC
		private ListViewDataItemGroup c3b8d58494a1935b104c4727552adea4e(c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1)
		{
			if (c6b7fbe462f43433d64916e9273f7e5d1.c1083de0b8d92c5fcbdd7005111d34bb9)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c3b8d58494a1935b104c4727552adea4e(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				return this.c41ff0acde4c428a9801876721bc993da;
			}
			if (c6b7fbe462f43433d64916e9273f7e5d1.c4e0b93cdfeb7fcd14340ea604aca37b3)
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
				return this.c022aac4c0d71a1c532b6e20993d403e9;
			}
			switch (c6b7fbe462f43433d64916e9273f7e5d1.ca435006c85356cb7385a782de8889a0a)
			{
			case c59ff87f6bdc69ff3440c18f170633236.c75de07cf35dca1805ba630578576f097:
				return this.c69fce1dee9acfb2f37ac6bb69ebad9b2;
			case c59ff87f6bdc69ff3440c18f170633236.c5aa713eacee5b6b8a97c2fe89c08b5bc:
				return this.c48c1bf2682234ca34e16ef1a566c6ec4;
			case c59ff87f6bdc69ff3440c18f170633236.c08d15a5b99c94345141e1274e0123138:
				return this.c58d55bb55866f0df1e08f95c03606f75;
			default:
				return this.c69fce1dee9acfb2f37ac6bb69ebad9b2;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00041070 File Offset: 0x0003F270
		private void c378715701ee8260c9bb7219736966809(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (c3c9260886a6db15de49329a9f5b9836c.ToggleState != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20168))
			{
				this.cdd5db1f29d0ec718d4917636a4927fbb = c6a3c5358df047f49ab73958b4e189649.cab55a050df275722227783d6686266c9;
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
			if (!true)
			{
				RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c378715701ee8260c9bb7219736966809(object, StateChangedEventArgs)).MethodHandle;
			}
			DriveInfo driveInfo = c5409344e1c2b74fa8c9a4d620ccb8d48.cb0b8fdc8df7e4723501037a4f8491959(new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20172))));
			if (driveInfo == null)
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
				this.ce77148f56a941930515ae05ee4a8abba.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20176) != 0);
				return;
			}
			this.cdd5db1f29d0ec718d4917636a4927fbb = driveInfo;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000410F4 File Offset: 0x0003F2F4
		private void ce0e5fd9cc8060ae197f8ae35c41dfcd9(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			this.c46742982780fe1e9a0b84ddd2570741b.Enabled = this.c727375dbbb6f023ed693138c5ee33ab6.Checked;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0004111C File Offset: 0x0003F31C
		private void ce04eaa7ac05ba8ddbee1441d01873f57(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (!this.c3835898c84d997df76aaf879a4b094f3)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ce04eaa7ac05ba8ddbee1441d01873f57(object, EventArgs)).MethodHandle;
				}
				this.cc95703410337f219db3f5a5b7aca7df6();
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0004114C File Offset: 0x0003F34C
		private void cc3e78c0fea944a488374c9fd40bc314e(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			Settings.Default.ForceUpdates = this.c162efdf2cfee9dcaab42750eaecc63aa.Checked;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00041174 File Offset: 0x0003F374
		private void c152d0e8c2af774bf3f79889348d9d8b0(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			Settings.Default.ForceUpdatesCitra = this.c205802b28402610c81760457c1ed80d0.Checked;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0004119C File Offset: 0x0003F39C
		private void c6a2b7530c9df83f8f246ecf6946f92a0(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			Settings.Default.ForceUpdatesDolphin = this.c7a7e4684ac13bfb11ce1a11695b1329c.Checked;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000411C4 File Offset: 0x0003F3C4
		private void c60e4ed149dee2755b668382a3e3ca5e6(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (this.c99bd3ea85b6a1aa87f929de1fca32ff1.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c60e4ed149dee2755b668382a3e3ca5e6(object, StateChangedEventArgs)).MethodHandle;
				}
				this.c69103ed6bfb59dc17e3aed75cdbe979d.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20180) != 0);
				this.c69103ed6bfb59dc17e3aed75cdbe979d.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20184) != 0);
				this.cc80b541ea0aecdb8c28ad57f43ca8ab8 = (c14cf1f200b737cded2756d6ab302a149)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20188);
				return;
			}
			this.cc80b541ea0aecdb8c28ad57f43ca8ab8 = (c14cf1f200b737cded2756d6ab302a149)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20192);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00041240 File Offset: 0x0003F440
		private void cce20dac3f9bbb99e6fbff8559b2fd0d6(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (!this.c3835898c84d997df76aaf879a4b094f3)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cce20dac3f9bbb99e6fbff8559b2fd0d6(object, EventArgs)).MethodHandle;
				}
				this.cc95703410337f219db3f5a5b7aca7df6();
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00041270 File Offset: 0x0003F470
		private void c01e6473071d863fe1a739382fc8d376c(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (!this.c3835898c84d997df76aaf879a4b094f3)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c01e6473071d863fe1a739382fc8d376c(object, EventArgs)).MethodHandle;
				}
				this.cc95703410337f219db3f5a5b7aca7df6();
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000412A0 File Offset: 0x0003F4A0
		private void c73c22814d7fa1fd851612f41479c894d(object cd7b28952603b35a45c555982e677363a, StateChangingEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (!this.c49e0e1006d938106f4f6b78dc1a9fbe9.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c73c22814d7fa1fd851612f41479c894d(object, StateChangingEventArgs)).MethodHandle;
				}
				if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
				{
					if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
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
						cb6cc9a5b122137bc5f2718f61ab49e59.c1429a6dc344ce1d6f1cdeb4f895f60dc(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20196) != 0);
					}
					if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
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
						c3c9260886a6db15de49329a9f5b9836c.Cancel = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20200) != 0);
					}
					return;
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
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00041358 File Offset: 0x0003F558
		private void c694317428fbb7e36b5efb11c71449e36(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (this.c63371175f2a9c38a0ecc286c5d95503f.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c694317428fbb7e36b5efb11c71449e36(object, StateChangedEventArgs)).MethodHandle;
				}
				if (!File.Exists(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73559)))
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
					File.WriteAllText(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73559), "");
				}
			}
			if (!this.c63371175f2a9c38a0ecc286c5d95503f.Checked)
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
				if (File.Exists(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73559)))
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
					File.Delete(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73559));
				}
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00041408 File Offset: 0x0003F608
		private void cad7892a5b5850df41662303d49978c03(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0004141C File Offset: 0x0003F61C
		private void c7e5eb63afb6a31a6e590df5dc9c2972b(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00041430 File Offset: 0x0003F630
		private void ca0d429b70b1e389837bf8684a5e44a42(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00041444 File Offset: 0x0003F644
		private void ce1e40100ea973724c526522d5aefb3f5(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (this.cef9cf59a04a9a091015a8a429a716577.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ce1e40100ea973724c526522d5aefb3f5(object, StateChangedEventArgs)).MethodHandle;
				}
				this.c69103ed6bfb59dc17e3aed75cdbe979d.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20204) != 0);
				this.c99bd3ea85b6a1aa87f929de1fca32ff1.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20208) != 0);
				this.cc80b541ea0aecdb8c28ad57f43ca8ab8 = (c14cf1f200b737cded2756d6ab302a149)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20212);
				return;
			}
			this.cc80b541ea0aecdb8c28ad57f43ca8ab8 = (c14cf1f200b737cded2756d6ab302a149)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20216);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000414C0 File Offset: 0x0003F6C0
		private void c20c8eaf0b59e2d6201e982fd1850c5a2(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (this.c69103ed6bfb59dc17e3aed75cdbe979d.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c20c8eaf0b59e2d6201e982fd1850c5a2(object, StateChangedEventArgs)).MethodHandle;
				}
				this.cef9cf59a04a9a091015a8a429a716577.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20220) != 0);
				this.c99bd3ea85b6a1aa87f929de1fca32ff1.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20224) != 0);
				this.cc80b541ea0aecdb8c28ad57f43ca8ab8 = (c14cf1f200b737cded2756d6ab302a149)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20228);
				return;
			}
			this.cc80b541ea0aecdb8c28ad57f43ca8ab8 = (c14cf1f200b737cded2756d6ab302a149)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20232);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0004153C File Offset: 0x0003F73C
		private void c603848762fc7eb0fcf8f3f3d277c3617(object cd7b28952603b35a45c555982e677363a, StateChangingEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (!this.c15ef48f6d131106befa105251dceaed9.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c603848762fc7eb0fcf8f3f3d277c3617(object, StateChangingEventArgs)).MethodHandle;
				}
				if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
				{
					if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
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
						cb6cc9a5b122137bc5f2718f61ab49e59.c1429a6dc344ce1d6f1cdeb4f895f60dc(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20236) != 0);
					}
					if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
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
						c3c9260886a6db15de49329a9f5b9836c.Cancel = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20240) != 0);
					}
					return;
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
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000415F4 File Offset: 0x0003F7F4
		private void cee2e51bb5eab78cdd45f76a34f95c720(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (!this.c3835898c84d997df76aaf879a4b094f3)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cee2e51bb5eab78cdd45f76a34f95c720(object, EventArgs)).MethodHandle;
				}
				this.cc95703410337f219db3f5a5b7aca7df6();
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00041624 File Offset: 0x0003F824
		private void cc4d16b6616f3d5d05a738e5ea3fb3aea(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			Settings.Default.CompactView = this.c8839ab017cc506ca34b8277549d5d1bc.Checked;
			Settings.Default.Save();
			if (this.c8839ab017cc506ca34b8277549d5d1bc.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc4d16b6616f3d5d05a738e5ea3fb3aea(object, StateChangedEventArgs)).MethodHandle;
				}
				this.cf6348eb630c0b01e77b8f83ec7151d96.ViewType = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20244);
				this.cf6348eb630c0b01e77b8f83ec7151d96.FullRowSelect = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20248) != 0);
			}
			else
			{
				this.cf6348eb630c0b01e77b8f83ec7151d96.ViewType = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20252);
				this.cf6348eb630c0b01e77b8f83ec7151d96.ItemSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20256), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20260));
			}
			this.cf6348eb630c0b01e77b8f83ec7151d96.MultiSelect = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20264) != 0);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000416F4 File Offset: 0x0003F8F4
		private void cf3a7c99bda96700d24204145b8f9224e()
		{
			try
			{
				this.c6fcdfcca42c1aeed647bdea8d9051572.Exit();
				this.c6fcdfcca42c1aeed647bdea8d9051572.Dispose();
			}
			catch
			{
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0004172C File Offset: 0x0003F92C
		private void c9dd7b0ce008201ebbbde1a6f5efce8b2(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.CurrentlyDownloading)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c9dd7b0ce008201ebbbde1a6f5efce8b2(object, EventArgs)).MethodHandle;
				}
				if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73580), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43643), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20268)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20272))
				{
					this.cc86ba4499172993cc63947e93cc907ae.cee8e4d5e35198ca7f4b76be49e2197b2();
					Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20276));
					this.c2145c40faa659435327807e52afa590a(this, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73643));
					return;
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
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000417C4 File Offset: 0x0003F9C4
		private void c131392ec9dca3467407275cf845d6393(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c7cf210e27d5e29bd47df57d8ff9bac8b();
			this.c9b5265c0946a689327a8c65feda18f1e();
			this.c1a9805b730a3a6a37657fc751e3ceb86(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20280) != 0);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000417F0 File Offset: 0x0003F9F0
		private void c1c9ad4b0ea487c500c73ad7001b2405a(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(73684), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74010), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20284)) != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20288))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1c9ad4b0ea487c500c73ad7001b2405a(object, EventArgs)).MethodHandle;
				}
				return;
			}
			IEnumerator<ListViewDataItem> enumerator = this.cf6348eb630c0b01e77b8f83ec7151d96.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(listViewDataItem.Tag);
					if (c5409344e1c2b74fa8c9a4d620ccb8d.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
						if (c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20292))
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
							if (listViewDataItem.Visible)
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
								this.c7a8112437fc6661ae742d22be70531e6(c5409344e1c2b74fa8c9a4d620ccb8d.Dlc);
							}
						}
					}
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

		// Token: 0x06000794 RID: 1940 RVA: 0x00041910 File Offset: 0x0003FB10
		private void c1eb40e45ebf05c87479967d92c9ec46b(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74029), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74010), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20296)) != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20300))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1eb40e45ebf05c87479967d92c9ec46b(object, EventArgs)).MethodHandle;
				}
				return;
			}
			bool flag = RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74361), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74468), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20304)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20308);
			IEnumerator<ListViewDataItem> enumerator = this.cf6348eb630c0b01e77b8f83ec7151d96.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(listViewDataItem.Tag);
					if (c5409344e1c2b74fa8c9a4d620ccb8d.c66201ce2763de795655e645e059b6451)
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
						if (listViewDataItem.Visible)
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
							if (flag)
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
								IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687> updates = c5409344e1c2b74fa8c9a4d620ccb8d.Updates;
								Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool> predicate;
								if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc8c43d1af6636c636e140290812816fa) == null)
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
									predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc8c43d1af6636c636e140290812816fa = new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c08c9c96211ea4e8e3e42e5f4c8589b31));
								}
								IEnumerator<c6a2f8acae5ff1a8a909193a5c5de6687> enumerator2 = updates.Where(predicate).GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										c6a2f8acae5ff1a8a909193a5c5de6687 c804bc52f7f79bffee6fd394ef382eb = enumerator2.Current;
										this.c7a8112437fc6661ae742d22be70531e6(c804bc52f7f79bffee6fd394ef382eb);
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
									continue;
								}
								finally
								{
									if (enumerator2 != null)
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
										enumerator2.Dispose();
									}
								}
							}
							if (c5409344e1c2b74fa8c9a4d620ccb8d.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20312))
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
								this.c7a8112437fc6661ae742d22be70531e6(c5409344e1c2b74fa8c9a4d620ccb8d.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>());
							}
						}
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
						switch (7)
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

		// Token: 0x06000795 RID: 1941 RVA: 0x00041B34 File Offset: 0x0003FD34
		private void c56cc0c5c480212a401c0bc17afce6898(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c7a8112437fc6661ae742d22be70531e6(this.SelectedGame.Dlc);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00041B58 File Offset: 0x0003FD58
		private void cdaad2ea6d47c15cad7ec0b16bc936799(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c97771ef24da9591c965bc884a27c01c0(this.SelectedGame);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00041B74 File Offset: 0x0003FD74
		private void ccf2b1010cea1c8156ca5b89f27cc2943(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c1f6179bdc03861e26477b7826da4fb8c c1f6179bdc03861e26477b7826da4fb8c = new c1f6179bdc03861e26477b7826da4fb8c(this.SelectedGame.Updates, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20316) != 0);
			if (c1f6179bdc03861e26477b7826da4fb8c.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20320))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ccf2b1010cea1c8156ca5b89f27cc2943(object, EventArgs)).MethodHandle;
				}
				return;
			}
			using (List<c6a2f8acae5ff1a8a909193a5c5de6687>.Enumerator enumerator = c1f6179bdc03861e26477b7826da4fb8c.c9f4bf79f56cd07529ca7850385fa2cb4.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c6a2f8acae5ff1a8a909193a5c5de6687 c804bc52f7f79bffee6fd394ef382eb = enumerator.Current;
					this.c7a8112437fc6661ae742d22be70531e6(c804bc52f7f79bffee6fd394ef382eb);
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
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00041C20 File Offset: 0x0003FE20
		private void ce75111fc74988c4776e5776984577e60(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new ceda1a4b2f7ba934babe5c69c42dc13cb().Show();
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00041C38 File Offset: 0x0003FE38
		private void c7fe14ddf04f7ee8e583bf37990fec9e2(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c130125f48ba039b5fcd9946712efb476(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20324) != 0);
			this.c110f83bd8d18c031953a502b6ae828da();
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00041C60 File Offset: 0x0003FE60
		private void cbe6a82acf5234fe320a0119d8147877c(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			Settings.Default.Region = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44884);
			this.c1c2aeea8a80fa3add16ae3005883e936 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20328) != 0);
			Settings.Default.EUR = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20332) != 0);
			Settings.Default.USA = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20336) != 0);
			Settings.Default.JPN = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20340) != 0);
			Settings.Default.Save();
			Application.Restart();
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		private void ce0c813ae5c7eb54e61cc1a68c344545f(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new cbd0eae57acbba026bbb08db06c98751a().ShowDialog();
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00041D04 File Offset: 0x0003FF04
		private void c2d862b0ed0ee9ed3261c13f0f6e20ce7(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			Settings.Default.TicketsPath = "";
			Settings.Default.TicketsPath3DS = "";
			Settings.Default.Save();
			Application.Restart();
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00041D44 File Offset: 0x0003FF44
		private void c46b6ded173670d3a80a210dd349eb95a(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c3835898c84d997df76aaf879a4b094f3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20344) != 0);
			IEnumerator<ListViewDataItem> enumerator = this.c379f097df981d80284e646aa1f74b28f.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					listViewDataItem.CheckState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20348);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c46b6ded173670d3a80a210dd349eb95a(object, EventArgs)).MethodHandle;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			this.c3835898c84d997df76aaf879a4b094f3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20352) != 0);
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00041DE8 File Offset: 0x0003FFE8
		private void c6e71cd26dcbf85d46dc8c3001cd3752d(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			ListViewDataItem[] array = this.c3f17fb9a80a6565749e0532cfc37cf36.Items.ToArray<ListViewDataItem>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20356); i < (int)c78c1657645b1911f37c2a4deace4af26.cfeb04651f165d0166e7c10ab1acf8b28(array); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20360))
			{
				ListViewDataItem listViewDataItem = array[i];
				this.c75edf037172ea3a5f8a77f6bb63d4606(cbc9910ec460ac1fe039be11b08e94c10.c0b398ab350e72b0d64d512bae8520b85(listViewDataItem.Tag));
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
			if (!true)
			{
				RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c6e71cd26dcbf85d46dc8c3001cd3752d(object, EventArgs)).MethodHandle;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00041E5C File Offset: 0x0004005C
		private void cf7a0fca06451c5ceb443e96632459aec(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c127c6c3e1f77cb695a754ccf2106b43f.UncheckAllItems();
			this.ca3616b09795098887eec9ba9fcfc049d = c6796fc6346bbdc3177a3b8efa277eed9.cab55a050df275722227783d6686266c9;
			this.c575f8d12fcef3eee352ca96a41736b5c();
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00041E8C File Offset: 0x0004008C
		private void c2032ee1e85a2f156d937f89f47b1ac61(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			ListViewDataItem[] array = this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items.ToArray<ListViewDataItem>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20364); i < (int)c78c1657645b1911f37c2a4deace4af26.cfeb04651f165d0166e7c10ab1acf8b28(array); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20368))
			{
				ListViewDataItem listViewDataItem = array[i];
				this.ca2c48e1c97d1d33cc1892702fc491b36(cbc9910ec460ac1fe039be11b08e94c10.c0b398ab350e72b0d64d512bae8520b85(listViewDataItem.Tag));
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
			if (!true)
			{
				RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c2032ee1e85a2f156d937f89f47b1ac61(object, EventArgs)).MethodHandle;
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00041F00 File Offset: 0x00040100
		private void c829f936818d72c3eb4aacf68d39b895c(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.caf1e1e92e15cc9c50d8c4dac5e34266b();
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00041F14 File Offset: 0x00040114
		private void c59daad4d0d489ca640da8a9dcab54037(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c84ebcf0d1ef4a18ca7ef0a37d6dcbb1c(this.SelectedGame);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00041F30 File Offset: 0x00040130
		private void c939d28c93745c95d3b5bf3ac112a96c8(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74507), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74010), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20372)) != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20376))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c939d28c93745c95d3b5bf3ac112a96c8(object, EventArgs)).MethodHandle;
				}
				return;
			}
			IEnumerable<ListViewDataItem> items = this.cf6348eb630c0b01e77b8f83ec7151d96.Items;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c63f33e8f89d96d80d38c0da7f52e1438) == null)
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
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c63f33e8f89d96d80d38c0da7f52e1438 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c08d0c5532539f7aae7b00d966f397d72));
			}
			IEnumerator<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerator = items.Select(selector).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = enumerator.Current;
					if (c5409344e1c2b74fa8c9a4d620ccb8d.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20380))
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
						this.cced076417085a35a106849899c95b63e(c5409344e1c2b74fa8c9a4d620ccb8d);
					}
					if (c5409344e1c2b74fa8c9a4d620ccb8d.c66201ce2763de795655e645e059b6451)
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
						IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687> updates = c5409344e1c2b74fa8c9a4d620ccb8d.Updates;
						Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool> predicate;
						if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cb360df602e74404e389766e9e0dd0224) == null)
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
							predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cb360df602e74404e389766e9e0dd0224 = new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c4757dd0c01455f08cf52ffada7396aaf));
						}
						IEnumerator<c6a2f8acae5ff1a8a909193a5c5de6687> enumerator2 = updates.Where(predicate).GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								c6a2f8acae5ff1a8a909193a5c5de6687 c804bc52f7f79bffee6fd394ef382eb = enumerator2.Current;
								this.cced076417085a35a106849899c95b63e(c804bc52f7f79bffee6fd394ef382eb);
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
						}
						finally
						{
							if (enumerator2 != null)
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
								enumerator2.Dispose();
							}
						}
					}
					if (c5409344e1c2b74fa8c9a4d620ccb8d.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
						if (c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20384))
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
							this.cced076417085a35a106849899c95b63e(c5409344e1c2b74fa8c9a4d620ccb8d.Dlc);
						}
					}
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
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			this.cffa7e6b0340f88d9369da7a34ef65631.Select();
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00042144 File Offset: 0x00040344
		private void c88c83bbde198c9e9c5f166fe5128ead0(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c17819fd2f02b4bdee7ab4eb871adeba6(this.SelectedGame);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00042160 File Offset: 0x00040360
		private void cc2a434874b29b4ef1d599598fd8507c1(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new c39b800e9e165a3cdc1c56c51ebe12109().ShowDialog();
			this.ca81e1fe6a4bc9fd553aee66fb6701460();
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00042180 File Offset: 0x00040380
		private void c00d6c996c548514fc38ac4b99fe3c27c(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74687), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74010), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20388)) != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20392))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c00d6c996c548514fc38ac4b99fe3c27c(object, EventArgs)).MethodHandle;
				}
				return;
			}
			IEnumerator<ListViewDataItem> enumerator = this.cf6348eb630c0b01e77b8f83ec7151d96.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(listViewDataItem.Tag);
					if (c5409344e1c2b74fa8c9a4d620ccb8d.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20396))
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
						if (listViewDataItem.Visible)
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
							this.c7a8112437fc6661ae742d22be70531e6(c5409344e1c2b74fa8c9a4d620ccb8d);
						}
					}
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
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0004227C File Offset: 0x0004047C
		private void c9aadbc86d6e2965d6532ff561c9cceb2(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c967e6f900acf8fed69dd58fc13e618c9.GoBack();
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00042298 File Offset: 0x00040498
		private void c60cc4d729f0c6d7754e2af0d1babdfeb(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c967e6f900acf8fed69dd58fc13e618c9.GoForward();
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000422B4 File Offset: 0x000404B4
		private void c25c7c79e0dbbc3cd5d073f5e0141bca0(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new c731c16c7615c797b8a75d5b2f24d3462().ShowDialog();
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000422D0 File Offset: 0x000404D0
		private void cc692586b9a07cbb247e4552d99de7046(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
			{
				Description = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(74975)
			};
			if (folderBrowserDialog.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20400))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc692586b9a07cbb247e4552d99de7046(object, EventArgs)).MethodHandle;
				}
				return;
			}
			cd72f04463e23d86b88073a95b804555a cd72f04463e23d86b88073a95b804555a = new cd72f04463e23d86b88073a95b804555a(folderBrowserDialog.SelectedPath);
			if (cd72f04463e23d86b88073a95b804555a.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20404))
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
				return;
			}
			this.c9368dc60d61608581f0b9ed666b65c81(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75052));
			this.c9cce42bf08ecabb93b709c62348f4ff2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20408) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20412) != 0, cd72f04463e23d86b88073a95b804555a.cae64f5cf1ac3ad308dcd6ea8285230ae);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0004237C File Offset: 0x0004057C
		private void cf09ccc59960d259ede0f18187b1fdb6d(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c3f17fb9a80a6565749e0532cfc37cf36.Items.Count == 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cf09ccc59960d259ede0f18187b1fdb6d(object, EventArgs)).MethodHandle;
				}
				return;
			}
			DriveInfo driveInfo = c5409344e1c2b74fa8c9a4d620ccb8d48.cb0b8fdc8df7e4723501037a4f8491959(c37b2bca41403d2a6ec54c69d55e5f9fe.cb93115e3b63933899699d0ee8696f152(this.c43ac0965f3c4dba40288724acda79152.Tag));
			if (driveInfo == null)
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
				return;
			}
			this.c9d78729909faa38b314f6ed7efbe7249(this.TitlesToCopy, driveInfo, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20416) != 0);
			bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20420) != 0;
			bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20424) != 0;
			IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> titlesToCopy = this.TitlesToCopy;
			Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool> predicate;
			if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc53f80c4538f6e1010c9a4167579abe3) == null)
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
				predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc53f80c4538f6e1010c9a4167579abe3 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c6ce73e96e9da1843ba1216cfa6bceda0));
			}
			IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> source = titlesToCopy.Where(predicate);
			Func<c6114b34ba4893a53ebb4b599e0e2e3fc, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c56c1239b07d600adc83f6b7cea418469) == null)
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
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c56c1239b07d600adc83f6b7cea418469 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c8975447f46218c48859d2ef5d5011b34));
			}
			this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, source.Select(selector).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
			this.c6e71cd26dcbf85d46dc8c3001cd3752d(null, caa194a1ddc67cd543957fd94f509f2e3.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0004248C File Offset: 0x0004068C
		private void c37f2415d586dd1e5bba1923ca88250e1(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new cb4d5146fc66b3a1cbe77decc1a582315().ShowDialog();
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000424A8 File Offset: 0x000406A8
		private void ccfd66d8bba9699c3973c18405427396f(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c72e7acdf474b857eac13b63d8d3e3e7f == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ccfd66d8bba9699c3973c18405427396f(object, EventArgs)).MethodHandle;
				}
				this.cfd9d1ce6346fca6179c64dac7f391035();
				return;
			}
			Process.Start(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75133), string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75158), this.c72e7acdf474b857eac13b63d8d3e3e7f));
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00042504 File Offset: 0x00040704
		private void cd75e34eb827c4a4c0feef3e62f16a79d(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c37b3d3a9ef4a26c65a3fac4aa3cda6c2(this.SelectedGame);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00042520 File Offset: 0x00040720
		private void cb1aed5a5240e442510f74197c00a9c4f(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c9e3b15e0906fc28b9aaaafda91843cfe c9e3b15e0906fc28b9aaaafda91843cfe = new c9e3b15e0906fc28b9aaaafda91843cfe(new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20428))));
			if (c9e3b15e0906fc28b9aaaafda91843cfe.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20432))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cb1aed5a5240e442510f74197c00a9c4f(object, EventArgs)).MethodHandle;
				}
				return;
			}
			DriveInfo cdeb88a4da0e27c7f39e2cad0c950f4b = c9e3b15e0906fc28b9aaaafda91843cfe.cdeb88a4da0e27c7f39e2cad0c950f4b0;
			if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cdeb88a4da0e27c7f39e2cad0c950f4b.DriveFormat, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75201)))
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
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75212));
				return;
			}
			cd4880843d42f3dd634ca35c8e909b573.c45cbdcfae4ad6f5a5c450c69a0162043(cdeb88a4da0e27c7f39e2cad0c950f4b.Name);
			RadMessageBox.Show(c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75442), Environment.NewLine, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75477)));
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000425EC File Offset: 0x000407EC
		private void c467b2fc7bb773f6709802a939045b730(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c110f83bd8d18c031953a502b6ae828da();
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00042600 File Offset: 0x00040800
		private void cc2a1f57bc16b4bcf52c3c192348e0138(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c67726bc94fb4dd43c5c00e863a4fed19.c026aee694fa251c8a3860993dce5e0db(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75703));
			this.c35f460bf0c1f6e62670cd9395b72682d = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20436) != 0);
			this.c2ab6323e26beb0b86b8b422636721d57();
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00042634 File Offset: 0x00040834
		private void ccd62e364815390bbb848c58f7def8ab7(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cdf32f0a375040bc60f0ded44a792e0a6 cdf32f0a375040bc60f0ded44a792e0a = new cb6cc9a5b122137bc5f2718f61ab49e59.cdf32f0a375040bc60f0ded44a792e0a6();
			if (this.c72e7acdf474b857eac13b63d8d3e3e7f == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ccd62e364815390bbb848c58f7def8ab7(object, EventArgs)).MethodHandle;
				}
				this.cfd9d1ce6346fca6179c64dac7f391035();
				return;
			}
			cb99844a1fcc49eab64ce3660c283758b cb99844a1fcc49eab64ce3660c283758b = new cb99844a1fcc49eab64ce3660c283758b(this.SelectedGame);
			if (cb99844a1fcc49eab64ce3660c283758b.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20440))
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
				return;
			}
			cdf32f0a375040bc60f0ded44a792e0a.c561c2db76c5bf8c95a684eca3517d61c = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75716), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20444) != 0);
			new Thread(new ThreadStart(cdf32f0a375040bc60f0ded44a792e0a.cc9ac36d3abf185356de0029fb836d8bb))
			{
				IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20448) != 0)
			}.Start();
			try
			{
				this.SelectedGame.c478c8f7708269b920f3c23fa293a94a4(this.c72e7acdf474b857eac13b63d8d3e3e7f, cb99844a1fcc49eab64ce3660c283758b.cd94ded741fa1bbd88aacb9287dc5e8e0.Timestamp);
			}
			catch (Exception ex)
			{
				cdf32f0a375040bc60f0ded44a792e0a.c561c2db76c5bf8c95a684eca3517d61c.cc5957c0b466d791dc387469fda39883c();
				this.c9368dc60d61608581f0b9ed666b65c81(ex.Message);
				return;
			}
			cdf32f0a375040bc60f0ded44a792e0a.c561c2db76c5bf8c95a684eca3517d61c.cc5957c0b466d791dc387469fda39883c();
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00042734 File Offset: 0x00040934
		private void cf2cb748148424966970fef3131895f95(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c127c6c3e1f77cb695a754ccf2106b43f.CheckedItems.Count == 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cf2cb748148424966970fef3131895f95(object, EventArgs)).MethodHandle;
				}
				return;
			}
			this.ca3616b09795098887eec9ba9fcfc049d = new List<string>();
			string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75811);
			Action c594146923b42642ebf4bf2a5cd = new Action(this.c41ab7cb021389d67f820a4e6d136a0a8);
			Action<Exception> c62f902d27574ffccbd029fee23622bc;
			if ((c62f902d27574ffccbd029fee23622bc = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ca959f24de86dab07680f4ec36d48af9e) == null)
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
				c62f902d27574ffccbd029fee23622bc = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ca959f24de86dab07680f4ec36d48af9e = new Action<Exception>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c5ef7b9b105ad41a8072e66d0c1e4bbc5));
			}
			new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
			this.c575f8d12fcef3eee352ca96a41736b5c();
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000427CC File Offset: 0x000409CC
		private void c2cc49f6b986ba13f09446e8d35411d25(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new c7c007275b51212e933d033b54fbe44b3().Show();
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000427E4 File Offset: 0x000409E4
		private void c598b5676f6823cf69a247e0d3e806397(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cce1e6fcd67afaa0e95eb5dee25a94515 cce1e6fcd67afaa0e95eb5dee25a = new cb6cc9a5b122137bc5f2718f61ab49e59.cce1e6fcd67afaa0e95eb5dee25a94515();
			if (this.c3f17fb9a80a6565749e0532cfc37cf36.Items.Count == 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c598b5676f6823cf69a247e0d3e806397(object, EventArgs)).MethodHandle;
				}
				return;
			}
			if (this.c72e7acdf474b857eac13b63d8d3e3e7f == null)
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
				this.cfd9d1ce6346fca6179c64dac7f391035();
				return;
			}
			cce1e6fcd67afaa0e95eb5dee25a.c5e8120bc8b766299fe0bcc91f6157eef = "";
			string text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75890), Environment.NewLine);
			bool c9b75f6ba06c0e9f0da24aef64cde37be = RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75921), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76073), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20452)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20456);
			using (List<c6114b34ba4893a53ebb4b599e0e2e3fc>.Enumerator enumerator = this.TitlesToCopy.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					cb6cc9a5b122137bc5f2718f61ab49e59.c685bf7254eda9d1411413f148ffb165a c685bf7254eda9d1411413f148ffb165a = new cb6cc9a5b122137bc5f2718f61ab49e59.c685bf7254eda9d1411413f148ffb165a();
					c685bf7254eda9d1411413f148ffb165a.c8c38354cddaefb45b9cfcd9ed2838c37 = cce1e6fcd67afaa0e95eb5dee25a;
					c685bf7254eda9d1411413f148ffb165a.c804bc52f7f79bffee6fd394ef382eb76 = enumerator.Current;
					cb6cc9a5b122137bc5f2718f61ab49e59.c5e4797f4ce9e34831973cb603673efb2 c5e4797f4ce9e34831973cb603673efb = new cb6cc9a5b122137bc5f2718f61ab49e59.c5e4797f4ce9e34831973cb603673efb2();
					c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700 = c685bf7254eda9d1411413f148ffb165a;
					if (c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76.System != (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20460))
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
						return;
					}
					c5e4797f4ce9e34831973cb603673efb.c42063d8f921755d50e79dca93da13b1e = new ce391dfcb046d82715408fa23d60a1773(c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76);
					c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76.c73e931bf51a4d212e8590fc4d679e319 += c5e4797f4ce9e34831973cb603673efb.c657cd7722c063e0ef7e83435e76abd2e;
					c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76.c34927e088ba152d38122e3c8e996a65a += c5e4797f4ce9e34831973cb603673efb.cb06240638a7d13446f162b2ba3654e33;
					c5e4797f4ce9e34831973cb603673efb.c42063d8f921755d50e79dca93da13b1e.cef7287fbe1fe3ee7d4fea0b652d5b687 += c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c1827e6033bcc6ad62d3ed7803c5b84d5;
					if (this.c72e7acdf474b857eac13b63d8d3e3e7f == null)
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
						string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76088);
						Action c594146923b42642ebf4bf2a5cd = new Action(this.cc87c16985640f5664dee0e6099a22353);
						Action<Exception> c62f902d27574ffccbd029fee23622bc;
						if ((c62f902d27574ffccbd029fee23622bc = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c021ac2a9345f0890318d6f438dc6387a) == null)
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
							c62f902d27574ffccbd029fee23622bc = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c021ac2a9345f0890318d6f438dc6387a = new Action<Exception>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.ca16d97a139d8986524628137f7750e10));
						}
						new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
					}
					c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76.cc8422328d62b00ae26fa035b02f819ff(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20464) != 0, this.c72e7acdf474b857eac13b63d8d3e3e7f, c9b75f6ba06c0e9f0da24aef64cde37be);
					c5e4797f4ce9e34831973cb603673efb.c42063d8f921755d50e79dca93da13b1e.ShowDialog();
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c5e8120bc8b766299fe0bcc91f6157eef, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5736)))
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
						if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76) != null)
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
							c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76).c4e0b93cdfeb7fcd14340ea604aca37b3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20468) != 0);
						}
					}
					text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76203), c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76, c5e4797f4ce9e34831973cb603673efb.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c5e8120bc8b766299fe0bcc91f6157eef, Environment.NewLine));
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
			this.c9368dc60d61608581f0b9ed666b65c81(text);
			this.c9cce42bf08ecabb93b709c62348f4ff2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20472) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20476) != 0, c8a61d9c08bd6da5c20c60d8c809c49fd.cab55a050df275722227783d6686266c9);
			this.c6e71cd26dcbf85d46dc8c3001cd3752d(null, caa194a1ddc67cd543957fd94f509f2e3.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00042B2C File Offset: 0x00040D2C
		private void c8440989ae77b9ada82708025cea33344(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			try
			{
				Uri address = new Uri(this.ccc6197ad0cf795a9587c66570a9dfb79.Text);
				NetworkCredential credentials = new NetworkCredential(this.cb0cfae55913822d197dd756dceb3d6aa.Text, this.cb5a0a2daffea489d9502568fc2558386.Text);
				WebProxy proxy = new WebProxy
				{
					Address = address,
					Credentials = credentials
				};
				HttpWebRequest httpWebRequest = c306d0f4edb8d9dba0e2099a0ed0662c3.cd24593c859565ebb8c9faabbc5c75bef(WebRequest.Create(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76232)));
				httpWebRequest.Proxy = proxy;
				httpWebRequest.Timeout = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20480);
				httpWebRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1298);
				WebResponse response = httpWebRequest.GetResponse();
				try
				{
					this.Proxy = proxy;
				}
				finally
				{
					if (response != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c8440989ae77b9ada82708025cea33344(object, EventArgs)).MethodHandle;
						}
						((IDisposable)response).Dispose();
					}
				}
				this.c85837e3848f514b3ef5efaee2f6dde4c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76277);
				this.c85837e3848f514b3ef5efaee2f6dde4c.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.caf1e1e92e15cc9c50d8c4dac5e34266b();
				RadMessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00042C50 File Offset: 0x00040E50
		private void c6118596dd3f8efcb0c76a074fd9eb2d3(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cafc7445bc88f604abf9415d0369712be(this.SelectedGame);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00042C6C File Offset: 0x00040E6C
		private void ce2e1ec9350d6e598880368b32a4cc937(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c1429a6dc344ce1d6f1cdeb4f895f60dc(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20484) != 0);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00042C8C File Offset: 0x00040E8C
		private void c3a4175617cd6da91db15b0a0feea4b91(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			new c4be875c999e24029765c8ed7fc59e17c().ShowDialog();
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00042CA8 File Offset: 0x00040EA8
		private void c0ac34b2eab8aae7ce17981775cc306b4(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c3835898c84d997df76aaf879a4b094f3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20488) != 0);
			IEnumerator<ListViewDataItem> enumerator = this.c379f097df981d80284e646aa1f74b28f.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					listViewDataItem.CheckState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20492);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c0ac34b2eab8aae7ce17981775cc306b4(object, EventArgs)).MethodHandle;
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
			this.c3835898c84d997df76aaf879a4b094f3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20496) != 0);
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00042D4C File Offset: 0x00040F4C
		private void cfee694ddfb488d683b8b21ceb17beb3e()
		{
			Task.Run(new Action(this.c9e54a5a14ca3e7f63c498f923811fb8c));
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00042D70 File Offset: 0x00040F70
		private void c65cf7cdc28eee52d9c7a54f014164e29()
		{
			DataSize dataSize = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20500)));
			IEnumerable<ListViewDataItem> items = this.c3f17fb9a80a6565749e0532cfc37cf36.Items;
			DataSize seed = dataSize;
			Func<DataSize, ListViewDataItem, DataSize> func;
			if ((func = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cb0e415e85109685e470211693b3dd4b2) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c65cf7cdc28eee52d9c7a54f014164e29()).MethodHandle;
				}
				func = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cb0e415e85109685e470211693b3dd4b2 = new Func<DataSize, ListViewDataItem, DataSize>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c43692df72e16d70dcd3a575233f1f578));
			}
			dataSize = items.Aggregate(seed, func);
			this.c43ac0965f3c4dba40288724acda79152.Text = dataSize.ToString();
			this.c43ac0965f3c4dba40288724acda79152.Tag = dataSize;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00042E04 File Offset: 0x00041004
		private void cf198d0c85e4a43bf5b54955c482f8c3a()
		{
			DataSize dataSize = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20504)));
			IEnumerable<ListViewDataItem> items = this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items;
			DataSize seed = dataSize;
			Func<DataSize, ListViewDataItem, DataSize> func;
			if ((func = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c350718b93e7970fdb3eda9ccf8ecabe5) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cf198d0c85e4a43bf5b54955c482f8c3a()).MethodHandle;
				}
				func = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c350718b93e7970fdb3eda9ccf8ecabe5 = new Func<DataSize, ListViewDataItem, DataSize>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c67429de1995268adb717acff29ce5f97));
			}
			dataSize = items.Aggregate(seed, func);
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.Text = dataSize.ToString();
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00042E88 File Offset: 0x00041088
		private void c9d78729909faa38b314f6ed7efbe7249(IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> c16546efd28d5dd2556d0339ea76d004e, DriveInfo c85fa46dee7ef9473f93c9fb47da11f4d, bool c772c2a45dacf5b536932a18299457e5a)
		{
			string text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75890), Environment.NewLine);
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20508);
			Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool> predicate;
			if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c256239c0f98c6d157046ffa4e54ff3b1) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c9d78729909faa38b314f6ed7efbe7249(IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc>, DriveInfo, bool)).MethodHandle;
				}
				predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c256239c0f98c6d157046ffa4e54ff3b1 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c3531ff89c66d4ee1fa757811d51bb953));
			}
			if (c16546efd28d5dd2556d0339ea76d004e.Any(predicate))
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
				cb4e425f2d70132d57f01f6cf60a868ac.c2c5c44b01ed5eae110838fea588a0da6(c85fa46dee7ef9473f93c9fb47da11f4d);
			}
			IEnumerator<c6114b34ba4893a53ebb4b599e0e2e3fc> enumerator = c16546efd28d5dd2556d0339ea76d004e.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = enumerator.Current;
					string text2 = c6114b34ba4893a53ebb4b599e0e2e3fc.c8c3deb15f04d4b9ff701a9696f2e64fa(c772c2a45dacf5b536932a18299457e5a, c85fa46dee7ef9473f93c9fb47da11f4d);
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5736)))
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
						num += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20512);
						if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(c6114b34ba4893a53ebb4b599e0e2e3fc) != null)
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
							c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(c6114b34ba4893a53ebb4b599e0e2e3fc).c4e0b93cdfeb7fcd14340ea604aca37b3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20516) != 0);
						}
					}
					else
					{
						text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76203), c6114b34ba4893a53ebb4b599e0e2e3fc, text2, Environment.NewLine));
					}
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
			text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76284), num, Environment.NewLine));
			this.c9368dc60d61608581f0b9ed666b65c81(text);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00043018 File Offset: 0x00041218
		private void c9b5265c0946a689327a8c65feda18f1e()
		{
			Control control = this.c44272853dcc0c97ee7511d3b33f129b2;
			bool enabled;
			if (this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items.Count > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20520))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c9b5265c0946a689327a8c65feda18f1e()).MethodHandle;
				}
				enabled = ((this.CurrentlyDownloading ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20524));
			}
			else
			{
				enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20528) != 0);
			}
			control.Enabled = enabled;
			if (!this.c44272853dcc0c97ee7511d3b33f129b2.Enabled)
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
				System.Windows.Forms.Timer timer = this.c3594d8d99bfd6c1696f290e195f9566d;
				if (timer == null)
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
					return;
				}
				timer.Stop();
				return;
			}
			else
			{
				System.Windows.Forms.Timer timer2 = this.c3594d8d99bfd6c1696f290e195f9566d;
				if (timer2 == null)
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
					return;
				}
				timer2.Start();
				return;
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000430D4 File Offset: 0x000412D4
		private ulong c79f39c7b8facf7b3a81962666364425c(string c080fc526914529016145ec8ceb99b498)
		{
			ulong num = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20532));
			IEnumerator<FileInfo> enumerator = new DirectoryInfo(c080fc526914529016145ec8ceb99b498).EnumerateFiles(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(144), (SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20536)).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					FileInfo fileInfo = enumerator.Current;
					num += (ulong)fileInfo.Length;
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c79f39c7b8facf7b3a81962666364425c(string)).MethodHandle;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			return num;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00043174 File Offset: 0x00041374
		private void c60f180121f06f6ac5b243f9dffce2925(object cd7b28952603b35a45c555982e677363a, ListViewItemEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.CurrentlyDownloading)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c60f180121f06f6ac5b243f9dffce2925(object, ListViewItemEventArgs)).MethodHandle;
				}
				if (this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.SelectedIndex <= this.IndexGameCurrentlyDownloaded)
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
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76367));
					return;
				}
			}
			this.ca2c48e1c97d1d33cc1892702fc491b36(cbc9910ec460ac1fe039be11b08e94c10.c0b398ab350e72b0d64d512bae8520b85(cdf15457ee4816989343b6e6e96dd4cfe.Item.Tag));
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000431F0 File Offset: 0x000413F0
		private void c110b1e19b2f4e6f0da5b732697a3e834(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cc6ddb28650737a29456a9f365e377768();
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00043204 File Offset: 0x00041404
		private void c5f0d5273034638f564895306db94c95a(object cd7b28952603b35a45c555982e677363a, c8e60ceced0ce323f661e853233d10ec2 cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cae5ee452199c860967abd212b5080bde cae5ee452199c860967abd212b5080bde = new cb6cc9a5b122137bc5f2718f61ab49e59.cae5ee452199c860967abd212b5080bde();
			cae5ee452199c860967abd212b5080bde.c4404a159870bf55bb6f111e66e59e82d = this;
			cae5ee452199c860967abd212b5080bde.cdf15457ee4816989343b6e6e96dd4cfe = cdf15457ee4816989343b6e6e96dd4cfe;
			cae5ee452199c860967abd212b5080bde.cd7b28952603b35a45c555982e677363a = cd7b28952603b35a45c555982e677363a;
			try
			{
				base.Invoke(new Action(cae5ee452199c860967abd212b5080bde.c211ffcc277f4111750a08f8b62b94863));
			}
			catch
			{
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00043258 File Offset: 0x00041458
		private byte[] c1ea55cbd3cc08e542bac463cec6ba4b0(string c878e0ab6d968bb7599d1376f4540b91e)
		{
			string path = Path.Combine(cb6cc9a5b122137bc5f2718f61ab49e59.cc6a1f532cec9e354b03aa188eb0dd582, c67726bc94fb4dd43c5c00e863a4fed19.cd78b75c0acd1a4205371a6b84b5b766a(c878e0ab6d968bb7599d1376f4540b91e));
			if (cb6cc9a5b122137bc5f2718f61ab49e59.c3c3fdb0497dbe1080a567a755ee044d4(c878e0ab6d968bb7599d1376f4540b91e))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1ea55cbd3cc08e542bac463cec6ba4b0(string)).MethodHandle;
				}
				if (c878e0ab6d968bb7599d1376f4540b91e.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63471)))
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
					this.c3749f3cf1df50ff24b9a048e0b822d9a = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20540) != 0);
				}
				if (c878e0ab6d968bb7599d1376f4540b91e.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63551)))
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
					this.cbeb7ed06c872d430df3d8ec783ae0dd9 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20544) != 0);
				}
				c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = new c866035f717c1c145e269422264e8f519();
				try
				{
					byte[] array;
					if (!this.c3749f3cf1df50ff24b9a048e0b822d9a)
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
						if (!this.cbeb7ed06c872d430df3d8ec783ae0dd9)
						{
							array = c866035f717c1c145e269422264e8f.cd13dfe553208f0b407836d345c6897d0(c878e0ab6d968bb7599d1376f4540b91e);
							goto IL_E8;
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
					array = c866035f717c1c145e269422264e8f.cf974603cc086c68eafb242ca5199a108(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c878e0ab6d968bb7599d1376f4540b91e, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76501)));
					IL_E8:
					Directory.CreateDirectory(cb6cc9a5b122137bc5f2718f61ab49e59.cc6a1f532cec9e354b03aa188eb0dd582);
					File.WriteAllBytes(path, array);
					return array;
				}
				catch
				{
					if (File.Exists(path))
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
						this.c9368dc60d61608581f0b9ed666b65c81(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76510), c878e0ab6d968bb7599d1376f4540b91e));
						return File.ReadAllBytes(path);
					}
					this.c9368dc60d61608581f0b9ed666b65c81(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76870), c878e0ab6d968bb7599d1376f4540b91e));
					return c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
				}
			}
			if (File.Exists(c878e0ab6d968bb7599d1376f4540b91e))
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
				try
				{
					return File.ReadAllBytes(c878e0ab6d968bb7599d1376f4540b91e);
				}
				catch
				{
					return c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
				}
			}
			return null;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0004340C File Offset: 0x0004160C
		private void c575f8d12fcef3eee352ca96a41736b5c()
		{
			this.c3835898c84d997df76aaf879a4b094f3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20548) != 0);
			IEnumerable<ListViewDataItem> items = this.c379f097df981d80284e646aa1f74b28f.Items;
			Func<ListViewDataItem, bool> predicate;
			if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c14a37f86e80fd0fc08c4e2726469556f) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c575f8d12fcef3eee352ca96a41736b5c()).MethodHandle;
				}
				predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c14a37f86e80fd0fc08c4e2726469556f = new Func<ListViewDataItem, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c85ffc645cab879aefaa206fe42dd44e1));
			}
			IEnumerable<ListViewDataItem> source = items.Where(predicate);
			Func<ListViewDataItem, Platform> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c89474dbeb18c14e5eafb920da4268f6f) == null)
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
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c89474dbeb18c14e5eafb920da4268f6f = new Func<ListViewDataItem, Platform>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c8f24a5b77c478cbffb50c1e3269ab9f8));
			}
			this.Platforms = source.Select(selector).ToList<Platform>();
			this.cf6348eb630c0b01e77b8f83ec7151d96.FilterDescriptors.Clear();
			this.cf6348eb630c0b01e77b8f83ec7151d96.FilterPredicate = new Predicate<ListViewDataItem>(this.cc7b9d3eeecabdf2ae8090177cd524edc);
			this.cf6348eb630c0b01e77b8f83ec7151d96.FilterDescriptors.Add(new FilterDescriptor(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(77192), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20552), this.c90fe97b27e47a56fbdfb26d97ff3fbe0.Text));
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00043510 File Offset: 0x00041710
		private void c508f49cabf39151edc36d47c2315637b(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cc95703410337f219db3f5a5b7aca7df6();
			this.c140aadf765c4d07d6ee3fccbfde7124c.Stop();
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00043530 File Offset: 0x00041730
		private void c6934eb62b1aa43c73cec1b8e11879613(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (!this.c140aadf765c4d07d6ee3fccbfde7124c.Enabled)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c6934eb62b1aa43c73cec1b8e11879613(object, EventArgs)).MethodHandle;
				}
				this.c140aadf765c4d07d6ee3fccbfde7124c.Start();
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0004356C File Offset: 0x0004176C
		private void c68a5194f0daf9053499a3429fb0c0e8a(cbdbecb4f2aabec5734fa1432e4548f8e c12d0d8e4a348d50592ec186ea66a67ef, c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c00a6690bc16529620e74de9a3a557882 c00a6690bc16529620e74de9a3a = new cb6cc9a5b122137bc5f2718f61ab49e59.c00a6690bc16529620e74de9a3a557882();
			c00a6690bc16529620e74de9a3a.c4404a159870bf55bb6f111e66e59e82d = this;
			c00a6690bc16529620e74de9a3a.c12d0d8e4a348d50592ec186ea66a67ef = c12d0d8e4a348d50592ec186ea66a67ef;
			c00a6690bc16529620e74de9a3a.c6b7fbe462f43433d64916e9273f7e5d1 = c6b7fbe462f43433d64916e9273f7e5d1;
			try
			{
				if (base.IsDisposed)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c68a5194f0daf9053499a3429fb0c0e8a(cbdbecb4f2aabec5734fa1432e4548f8e, c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
					}
				}
				else
				{
					base.Invoke(new Action(c00a6690bc16529620e74de9a3a.c0c8e0e278c75b9dfeb449ee2e029ee91));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000435E0 File Offset: 0x000417E0
		private void c90920141366a2a6842000aa35290ab9a()
		{
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20556);
			int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20560);
			int num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20564);
			Bitmap bitmap = c32037f571be75ec9395b718eab8129e7.cd24593c859565ebb8c9faabbc5c75bef(this.c6a2b595cc5d4feecae7d4d122a8f1dce.Image);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20568); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20588); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20584))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20572); j < bitmap.Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20580); j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20576))
				{
					Color pixel = bitmap.GetPixel(i, j);
					num += (int)pixel.R;
					num2 += (int)pixel.G;
					num3 += (int)pixel.B;
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c90920141366a2a6842000aa35290ab9a()).MethodHandle;
				}
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
			num /= bitmap.Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20592) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20596);
			num2 /= bitmap.Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20600) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20604);
			num3 /= bitmap.Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20608) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20612);
			this.cd9cc6282fcad129739eed0b12b013814.BackColor = Color.FromArgb(num, num2, num3);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00043750 File Offset: 0x00041950
		private Tuple<byte[], byte[]> ca6e352f57a488cb7377fcf40db08f322()
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cf4f59705acff7d6c16d20af8f0dcebf0 cf4f59705acff7d6c16d20af8f0dcebf = new cb6cc9a5b122137bc5f2718f61ab49e59.cf4f59705acff7d6c16d20af8f0dcebf0();
			cf4f59705acff7d6c16d20af8f0dcebf.c4404a159870bf55bb6f111e66e59e82d = this;
			if (Settings.Default.TicketsPath.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63136)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ca6e352f57a488cb7377fcf40db08f322()).MethodHandle;
				}
				Settings.Default.TicketsPath = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63500);
			}
			if (Settings.Default.TicketsPath3DS.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(77201)))
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
				Settings.Default.TicketsPath3DS = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(63578);
			}
			cf4f59705acff7d6c16d20af8f0dcebf.cb71ed553427ab25a7e93785c401bf15e = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
			cf4f59705acff7d6c16d20af8f0dcebf.cbae86ce8e86f685d425d3909090f56be = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
			string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(77236);
			Action c594146923b42642ebf4bf2a5cd = new Action(cf4f59705acff7d6c16d20af8f0dcebf.ccb5cd4689f49400c04253c2402e3fe24);
			Action<Exception> c62f902d27574ffccbd029fee23622bc;
			if ((c62f902d27574ffccbd029fee23622bc = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ce478c958697fb63174570d8d10921200) == null)
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
				c62f902d27574ffccbd029fee23622bc = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ce478c958697fb63174570d8d10921200 = new Action<Exception>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c0734b272b50d324ac454449b645ee740));
			}
			new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
			while (cf4f59705acff7d6c16d20af8f0dcebf.cb71ed553427ab25a7e93785c401bf15e == null)
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
				if (cf4f59705acff7d6c16d20af8f0dcebf.cbae86ce8e86f685d425d3909090f56be != null)
				{
					for (;;)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						goto IL_1DC;
					}
				}
				else
				{
					c3dc6b208b04533a4c84b7a3aea9612f3 c3dc6b208b04533a4c84b7a3aea9612f = new c3dc6b208b04533a4c84b7a3aea9612f3();
					if (c3dc6b208b04533a4c84b7a3aea9612f.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20616))
					{
						break;
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
					Settings.Default.TicketsPath = c3dc6b208b04533a4c84b7a3aea9612f.FileLocationWiiU;
					Settings.Default.TicketsPath3DS = c3dc6b208b04533a4c84b7a3aea9612f.FileLocation3DS;
					string cfeefea196000bed18adf05bf7727db2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(77236);
					Action c594146923b42642ebf4bf2a5cd2;
					if ((c594146923b42642ebf4bf2a5cd2 = cf4f59705acff7d6c16d20af8f0dcebf.c07d96df25e149ee1b99babd4357e18e6) == null)
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
						c594146923b42642ebf4bf2a5cd2 = (cf4f59705acff7d6c16d20af8f0dcebf.c07d96df25e149ee1b99babd4357e18e6 = new Action(cf4f59705acff7d6c16d20af8f0dcebf.c090e9fe83fd515f795500c243fc80a65));
					}
					Action<Exception> c62f902d27574ffccbd029fee23622bc2;
					if ((c62f902d27574ffccbd029fee23622bc2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cb586fcea3bcf9e289fa2fc85e7e5ae0a) == null)
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
						c62f902d27574ffccbd029fee23622bc2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cb586fcea3bcf9e289fa2fc85e7e5ae0a = new Action<Exception>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c386e7468680f3e9f02be60e48f79771a));
					}
					new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db2, c594146923b42642ebf4bf2a5cd2, c62f902d27574ffccbd029fee23622bc2);
				}
			}
			IL_1DC:
			return new Tuple<byte[], byte[]>(cf4f59705acff7d6c16d20af8f0dcebf.cb71ed553427ab25a7e93785c401bf15e, cf4f59705acff7d6c16d20af8f0dcebf.cbae86ce8e86f685d425d3909090f56be);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0004394C File Offset: 0x00041B4C
		private void cc3ddcea0d3be09242a6a70c83078277f(byte[] c9988e9149bd917de22f7dc2c221b9d7d, byte[] c65c46ee7f4d22fa8744eccd79a92d8c9)
		{
			c8784a7e2bcf638ea1c74b1ace708bc68.cd592dd20bfa39eaca9a12ea4ce689194(this, c9988e9149bd917de22f7dc2c221b9d7d, c65c46ee7f4d22fa8744eccd79a92d8c9);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00043970 File Offset: 0x00041B70
		private void c4f8661f01524a79ccd84da7f25fdbc9c()
		{
			if (!c6a5e9b85d86b4e098a511017a1073d71.NewTitles.Any<c5409344e1c2b74fa8c9a4d620ccb8d48>())
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c4f8661f01524a79ccd84da7f25fdbc9c()).MethodHandle;
				}
				return;
			}
			c2dcabb874d69fc0fa9d819b6f090913a c2dcabb874d69fc0fa9d819b6f090913a = new c2dcabb874d69fc0fa9d819b6f090913a(c6a5e9b85d86b4e098a511017a1073d71.NewTitles);
			if (c2dcabb874d69fc0fa9d819b6f090913a.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20708))
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
				return;
			}
			using (List<c6114b34ba4893a53ebb4b599e0e2e3fc>.Enumerator enumerator = c2dcabb874d69fc0fa9d819b6f090913a.ce6df48bc5c345177ae4bfdd429a85275.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c6114b34ba4893a53ebb4b599e0e2e3fc c0d6c37d812d5d4b610705a6421056252 = enumerator.Current;
					this.c97771ef24da9591c965bc884a27c01c0(c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(c0d6c37d812d5d4b610705a6421056252));
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
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00043A2C File Offset: 0x00041C2C
		private void c57e4d69109179ae799fcc3c93e008923()
		{
			if (!c6a5e9b85d86b4e098a511017a1073d71.NewUpdates.Any<c6a2f8acae5ff1a8a909193a5c5de6687>())
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c57e4d69109179ae799fcc3c93e008923()).MethodHandle;
				}
				return;
			}
			c2dcabb874d69fc0fa9d819b6f090913a c2dcabb874d69fc0fa9d819b6f090913a = new c2dcabb874d69fc0fa9d819b6f090913a(c6a5e9b85d86b4e098a511017a1073d71.NewUpdates);
			if (c2dcabb874d69fc0fa9d819b6f090913a.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20712))
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
				return;
			}
			using (List<c6114b34ba4893a53ebb4b599e0e2e3fc>.Enumerator enumerator = c2dcabb874d69fc0fa9d819b6f090913a.ce6df48bc5c345177ae4bfdd429a85275.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb = enumerator.Current;
					this.c7a8112437fc6661ae742d22be70531e6(c804bc52f7f79bffee6fd394ef382eb);
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
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00043AE0 File Offset: 0x00041CE0
		private void c17819fd2f02b4bdee7ab4eb871adeba6(c5409344e1c2b74fa8c9a4d620ccb8d48 c6fcdfcca42c1aeed647bdea8d9051572)
		{
			if (c6fcdfcca42c1aeed647bdea8d9051572.c1083de0b8d92c5fcbdd7005111d34bb9)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c17819fd2f02b4bdee7ab4eb871adeba6(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				ce4b7cebb3f485cb02cc067c8025138ec ce4b7cebb3f485cb02cc067c8025138ec = new ce4b7cebb3f485cb02cc067c8025138ec();
				if (ce4b7cebb3f485cb02cc067c8025138ec.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20716))
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
					if (ce4b7cebb3f485cb02cc067c8025138ec.ccdb284ad7eb1048caa52502bf58fec3b)
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
						this.c2bdd5ac8d329224157ba17be0e08f285(c6fcdfcca42c1aeed647bdea8d9051572);
					}
					else
					{
						new c2c4b14fe5e90291f1e89570e7696c8a0(c6fcdfcca42c1aeed647bdea8d9051572).ShowDialog();
					}
				}
			}
			else
			{
				this.c2bdd5ac8d329224157ba17be0e08f285(c6fcdfcca42c1aeed647bdea8d9051572);
			}
			bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20720) != 0;
			bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20724) != 0;
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c69d6ff666734eacfed9a7120ff37e230) == null)
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
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c69d6ff666734eacfed9a7120ff37e230 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c04e3fdb263cf9b601580e217e745707b));
			}
			this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, selectedItems.Select(selector).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00043BC0 File Offset: 0x00041DC0
		private void c5169ad0b0f27e90b026e527bef772b18(List<c6114b34ba4893a53ebb4b599e0e2e3fc> c7cb97743dc03d0fb72a099064ab22b7f)
		{
			this.IndexGameCurrentlyDownloaded = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20728);
			cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = new cdb02a77cadec7790d5c7c433ab736a12(this.Proxy, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20732) != 0);
			this.cc86ba4499172993cc63947e93cc907ae = cdb02a77cadec7790d5c7c433ab736a;
			this.cc86ba4499172993cc63947e93cc907ae.c426ff9b72fe5e4a2968bc46e8012f149(cd2aafbed56deec6e2406db1545b7c5a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c7bab6db345839f9cf49d38f3cb6052bd.Value) * (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20736)));
			this.CurrentlyDownloading = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20740) != 0);
			cdb02a77cadec7790d5c7c433ab736a.c2484bd018cc259ebf6256e671a3c8276 += this.c1e413998dc3ccfe6b32327be02662ff2;
			cdb02a77cadec7790d5c7c433ab736a.c2c07e1cf16bbdc4cb1fad47219919ebb += this.c2145c40faa659435327807e52afa590a;
			cdb02a77cadec7790d5c7c433ab736a.c3c19cd1faced39a079a0f0b404062ad6 += this.c7cbd0510b5e74ad76df8250ae89f2a35;
			cdb02a77cadec7790d5c7c433ab736a.cdcc2c8329c5e63d415472bd3bd0a99aa += this.c5f0d5273034638f564895306db94c95a;
			cdb02a77cadec7790d5c7c433ab736a.cd5841496c51e4ccda38bf5370111aeaa(c7cb97743dc03d0fb72a099064ab22b7f, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20744), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20748));
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00043C9C File Offset: 0x00041E9C
		private void cbef1c47350bfe240624acc48226915ee()
		{
			cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b = this.SelectedGame.c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20752) != 0);
			if (cf7c96734e58d8de9864e1ea854bc2b7b == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cbef1c47350bfe240624acc48226915ee()).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(78947));
				return;
			}
			try
			{
				this.SelectedGame.c37b3d3a9ef4a26c65a3fac4aa3cda6c2(cf7c96734e58d8de9864e1ea854bc2b7b);
			}
			catch (Exception ex)
			{
				RadMessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00043D20 File Offset: 0x00041F20
		private void c811e29a2a9751be70a187d431f6b376d(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (Settings.Default.Path.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(79072)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c811e29a2a9751be70a187d431f6b376d(object, EventArgs)).MethodHandle;
				}
				if (Settings.Default.ShowProgramFilesWarning)
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
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(79099));
					DialogResult dialogResult = RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(79613), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(79833), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20756));
					if (dialogResult != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20760))
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
						if (dialogResult != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20764))
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
							if (dialogResult != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20768))
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
							}
						}
						else
						{
							string text = Path.Combine(Settings.Default.Path, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613));
							string text2 = Path.Combine(Settings.Default.Path, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2568));
							bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20772) != 0;
							for (;;)
							{
								flag = cb6cc9a5b122137bc5f2718f61ab49e59.c130125f48ba039b5fcd9946712efb476(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20776) != 0);
								if (flag)
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
									if (cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.Path))
									{
										break;
									}
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
							if (Directory.Exists(text))
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
								cb6cc9a5b122137bc5f2718f61ab49e59.c50ec04c4631f5c7886b66d5bd3d32241(text, Settings.Default.Path);
							}
							if (Directory.Exists(text2))
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
								cb6cc9a5b122137bc5f2718f61ab49e59.c50ec04c4631f5c7886b66d5bd3d32241(text2, Settings.Default.Path);
							}
						}
					}
					else
					{
						Settings.Default.ShowProgramFilesWarning = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20780) != 0);
						Settings.Default.Save();
					}
				}
			}
			Tuple<byte[], byte[]> tuple = this.ca6e352f57a488cb7377fcf40db08f322();
			bool flag2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20784) != 0;
			for (;;)
			{
				bool flag3;
				if (tuple.Item1 == null)
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
					flag3 = (tuple.Item2 == null);
				}
				else
				{
					flag3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20800) != 0);
				}
				if (!flag3 || !flag2)
				{
					break;
				}
				if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(79866), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80110), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20788)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20792))
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
					tuple = this.ca6e352f57a488cb7377fcf40db08f322();
				}
				else
				{
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80125));
					flag2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20796) != 0);
				}
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
			if (flag2)
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
				this.cc3ddcea0d3be09242a6a70c83078277f(tuple.Item1, tuple.Item2);
				return;
			}
			base.Close();
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00044000 File Offset: 0x00042200
		private void c0b694a0c76e196ff0cc0ea126d5d2132(object cd7b28952603b35a45c555982e677363a, ListViewItemEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c75edf037172ea3a5f8a77f6bb63d4606(cbc9910ec460ac1fe039be11b08e94c10.c0b398ab350e72b0d64d512bae8520b85(cdf15457ee4816989343b6e6e96dd4cfe.Item.Tag));
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0004402C File Offset: 0x0004222C
		private void c06f881e6ffa3b5413e6973e52b65e084(object cd7b28952603b35a45c555982e677363a, ListViewItemMouseEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (cdf15457ee4816989343b6e6e96dd4cfe.OriginalEventArgs.Button != (MouseButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20804))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c06f881e6ffa3b5413e6973e52b65e084(object, ListViewItemMouseEventArgs)).MethodHandle;
				}
				return;
			}
			c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(cdf15457ee4816989343b6e6e96dd4cfe.Item.Tag);
			if (c5409344e1c2b74fa8c9a4d620ccb8d == null)
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
				return;
			}
			if (this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems.Count < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20808))
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
				this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItem = cdf15457ee4816989343b6e6e96dd4cfe.Item;
			}
			if (this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems.Count == 0)
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
				return;
			}
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cfcada26af097addb7b97c2e60d5413ea) == null)
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
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cfcada26af097addb7b97c2e60d5413ea = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c904a79cd1c3c7fb2c7971e67d9194ea5));
			}
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerable = selectedItems.Select(selector);
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> source = enumerable;
			Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool> predicate;
			if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c59ca3ca71c6ec9f808b538200b92b284) == null)
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
				predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c59ca3ca71c6ec9f808b538200b92b284 = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c04e09580067f73696197d6dc82046dfd));
			}
			if (source.All(predicate))
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
				this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20812)].Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80234);
			}
			else
			{
				IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> source2 = enumerable;
				Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool> predicate2;
				if ((predicate2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ce64c184dbf4b91de56ac330e12dfeb7b) == null)
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
					predicate2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ce64c184dbf4b91de56ac330e12dfeb7b = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c2eafd60cfa9e2e3cc476e7b1ae8e0379));
				}
				if (source2.All(predicate2))
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
					this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20816)].Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80269);
				}
				else
				{
					this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20820)].Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80304);
				}
			}
			RadElement radElement = this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20824)];
			bool enabled;
			if (c5409344e1c2b74fa8c9a4d620ccb8d.c66201ce2763de795655e645e059b6451)
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
				enabled = (this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems.Count == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20828));
			}
			else
			{
				enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20832) != 0);
			}
			radElement.Enabled = enabled;
			RadElement radElement2 = this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20836)];
			bool enabled2;
			if (c5409344e1c2b74fa8c9a4d620ccb8d.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
				enabled2 = (this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems.Count == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20840));
			}
			else
			{
				enabled2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20844) != 0);
			}
			radElement2.Enabled = enabled2;
			RadElement radElement3 = this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20848)];
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> source3 = enumerable;
			Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool> predicate3;
			if ((predicate3 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8a5dad7e8409ed476a592b4cdd83a869) == null)
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
				predicate3 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8a5dad7e8409ed476a592b4cdd83a869 = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cea23548873696b0afef3cc763011361c));
			}
			radElement3.Enabled = ((source3.Any(predicate3) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20852));
			this.cd454afeeb1c83386a9b8902a8439978e.Show(cdf15457ee4816989343b6e6e96dd4cfe.OriginalEventArgs.X + base.Location.X + this.cf6348eb630c0b01e77b8f83ec7151d96.Location.X, cdf15457ee4816989343b6e6e96dd4cfe.OriginalEventArgs.Y + base.Location.Y + this.cf6348eb630c0b01e77b8f83ec7151d96.Location.Y + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20856));
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000443E8 File Offset: 0x000425E8
		private void ce7e09133ebcea2d89b7e0bb84c9c6418(object cd7b28952603b35a45c555982e677363a, KeyEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (cdf15457ee4816989343b6e6e96dd4cfe.KeyCode == (Keys)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20860))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ce7e09133ebcea2d89b7e0bb84c9c6418(object, KeyEventArgs)).MethodHandle;
				}
				this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems.Clear();
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00044430 File Offset: 0x00042630
		private void c3e04b8d1c785f8020038f4f6d843443b(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			ListViewDataItem selectedItem = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItem;
			object c0d6c37d812d5d4b610705a6421056252;
			if (selectedItem == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c3e04b8d1c785f8020038f4f6d843443b(object, EventArgs)).MethodHandle;
				}
				c0d6c37d812d5d4b610705a6421056252 = null;
			}
			else
			{
				c0d6c37d812d5d4b610705a6421056252 = selectedItem.Tag;
			}
			c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(c0d6c37d812d5d4b610705a6421056252);
			if (c5409344e1c2b74fa8c9a4d620ccb8d == null)
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
				return;
			}
			this.SelectedGame = c5409344e1c2b74fa8c9a4d620ccb8d;
			this.cf95ba3b48fd484ff24b6901d8a9a1280();
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00044490 File Offset: 0x00042690
		private void c1127135e52b49dbb1176673ee95a02d2(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			ListViewDetailColumn listViewDetailColumn = this.cf6348eb630c0b01e77b8f83ec7151d96.Columns[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20864)];
			float num = (float)(this.cf6348eb630c0b01e77b8f83ec7151d96.Width - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20868));
			IEnumerable<ListViewDetailColumn> columns = this.cf6348eb630c0b01e77b8f83ec7151d96.Columns;
			Func<ListViewDetailColumn, float> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c6ea66a9f1aef4739db8a8bcee6ce6e5a) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1127135e52b49dbb1176673ee95a02d2(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c6ea66a9f1aef4739db8a8bcee6ce6e5a = new Func<ListViewDetailColumn, float>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c3be19c24a1842274bfe30042cdf9a2a2));
			}
			listViewDetailColumn.Width = num - (columns.Sum(selector) - this.cf6348eb630c0b01e77b8f83ec7151d96.Columns[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20872)].Width);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00044548 File Offset: 0x00042748
		private void c97141158cfd040afae6eabee5859b4b5(object cd7b28952603b35a45c555982e677363a, ListViewItemEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (!this.c3835898c84d997df76aaf879a4b094f3)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c97141158cfd040afae6eabee5859b4b5(object, ListViewItemEventArgs)).MethodHandle;
				}
				this.cc95703410337f219db3f5a5b7aca7df6();
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00044578 File Offset: 0x00042778
		private void c529a381d00bec906dde0444fe8d27e4e(object cd7b28952603b35a45c555982e677363a, ListViewItemMouseEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (c7e6ad38b7784702e42cb4ef41fe79435.c0b398ab350e72b0d64d512bae8520b85(cdf15457ee4816989343b6e6e96dd4cfe.Item) != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c529a381d00bec906dde0444fe8d27e4e(object, ListViewItemMouseEventArgs)).MethodHandle;
				}
				this.c3835898c84d997df76aaf879a4b094f3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20876) != 0);
				IEnumerator<ListViewDataItem> enumerator = this.c379f097df981d80284e646aa1f74b28f.Items.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ListViewDataItem listViewDataItem = enumerator.Current;
						ToggleState checkState;
						if (listViewDataItem.Group != cdf15457ee4816989343b6e6e96dd4cfe.Item)
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
							checkState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20880);
						}
						else
						{
							checkState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20884);
						}
						listViewDataItem.CheckState = checkState;
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
				this.c3835898c84d997df76aaf879a4b094f3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20888) != 0);
			}
			this.cc95703410337f219db3f5a5b7aca7df6();
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00044664 File Offset: 0x00042864
		private void c27dcea2a74a59af163e39efd99316482(c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1, bool c6ed1ea768a6d1654ce6b0a854efc6d1d, bool c1673b05fa4d67821fdfe1632daa99752 = true)
		{
			c6b7fbe462f43433d64916e9273f7e5d1.c4e0b93cdfeb7fcd14340ea604aca37b3 = c6ed1ea768a6d1654ce6b0a854efc6d1d;
			if (c1673b05fa4d67821fdfe1632daa99752)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c27dcea2a74a59af163e39efd99316482(c5409344e1c2b74fa8c9a4d620ccb8d48, bool, bool)).MethodHandle;
				}
				this.c9cce42bf08ecabb93b709c62348f4ff2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20892) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20896) != 0, c8a61d9c08bd6da5c20c60d8c809c49fd.cab55a050df275722227783d6686266c9);
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000446B0 File Offset: 0x000428B0
		private void c7193231abd62b0b8353859ca7c98332e(object cd7b28952603b35a45c555982e677363a, FormClosingEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c4961cd4ecad2ed77ffc251826242e162)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c7193231abd62b0b8353859ca7c98332e(object, FormClosingEventArgs)).MethodHandle;
				}
				this.cf3a7c99bda96700d24204145b8f9224e();
			}
			try
			{
				Settings.Default.ForceUpdates = this.c162efdf2cfee9dcaab42750eaecc63aa.Checked;
				Settings.Default.ForceUpdatesCitra = this.c205802b28402610c81760457c1ed80d0.Checked;
				Settings.Default.ForceUpdatesDolphin = this.c7a7e4684ac13bfb11ce1a11695b1329c.Checked;
				Settings.Default.ShowCFW = this.c92d48e7b56cd690ea66ba42d3db5e722.Checked;
				Settings.Default.ShowLegit = this.c992db60513feabfee7066ab96aec9a64.Checked;
				Settings.Default.ShowEvents = this.c821c2394e2dbac0ba1c2982eeb77d30d.Checked;
				if (!this.c1c2aeea8a80fa3add16ae3005883e936)
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
					Settings.Default.EUR = this.c140ccd2b676242ee7992f31d621ad05b.Checked;
					Settings.Default.JPN = this.c693a1e47df92a82ced2b7ad96d5fae58.Checked;
					Settings.Default.USA = this.ca462c61c0669b9dd1d247bbdb465239d.Checked;
					Settings.Default.KOR = this.ca4bbd9e42efba9cc6ffad5fab3161776.Checked;
				}
				Settings @default = Settings.Default;
				string separator = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80383);
				IEnumerable<Platform> platforms = this.Platforms;
				Func<Platform, int> selector;
				if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c799b67388b617ad6f54d773710b2dfca) == null)
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
					selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c799b67388b617ad6f54d773710b2dfca = new Func<Platform, int>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c5bf7e57139a29132952037691a172dc8));
				}
				@default.Platforms = string.Join<int>(separator, platforms.Select(selector).ToArray<int>());
				Settings.Default.Save();
				this.c55186724d1c08cd6a25ee04b8c3f1f00();
				c6114b34ba4893a53ebb4b599e0e2e3fc.c30fb6614ee092b8ded8b858aba8f900b();
			}
			catch
			{
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00044880 File Offset: 0x00042A80
		private void c15bca37ae5115bafce5fc70ebfd7dcd4(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20900);
			timer.Tick += this.c4436f9c03d38e917f156f645d72cde07;
			timer.Start();
			c9f6bd73e0994a8a3cafc60b84130cfec c9f6bd73e0994a8a3cafc60b84130cfec = new c9f6bd73e0994a8a3cafc60b84130cfec();
			c9f6bd73e0994a8a3cafc60b84130cfec.cbf92447b2ba6ced5726222eb6a0494f4 += this.cc8ee126021d25c73e288b76d2e9394a5;
			try
			{
				string xml = new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80386));
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				IEnumerator enumerator = xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80503)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object c0d6c37d812d5d4b610705a6421056252 = enumerator.Current;
						XmlNode xmlNode = c75fdfaf36a6cfd5544847dc9c3b8c6fc.cd24593c859565ebb8c9faabbc5c75bef(c0d6c37d812d5d4b610705a6421056252);
						this.c127c6c3e1f77cb695a754ccf2106b43f.Items.Add(new ListViewDataItem
						{
							Text = xmlNode.FirstChild.InnerText,
							Tag = uint.Parse(xmlNode.Attributes[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80514)].InnerText)
						});
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c15bca37ae5115bafce5fc70ebfd7dcd4(object, EventArgs)).MethodHandle;
					}
				}
				finally
				{
					IDisposable disposable = c2f4016fa04d8c2b2a9dba60e295715d5.c0b398ab350e72b0d64d512bae8520b85(enumerator);
					if (disposable != null)
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
						disposable.Dispose();
					}
				}
			}
			catch
			{
			}
			c9f6bd73e0994a8a3cafc60b84130cfec.c95773ca90449404a230e51c912cabff1(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20904) != 0);
			this.c46742982780fe1e9a0b84ddd2570741b.Value = DateTime.Now;
			this.c46742982780fe1e9a0b84ddd2570741b.MinDate = DateTime.Now;
			this.c46742982780fe1e9a0b84ddd2570741b.Format = (DateTimePickerFormat)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20908);
			this.c46742982780fe1e9a0b84ddd2570741b.CustomFormat = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80519);
			this.Text = c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.Text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80552), Settings.Default.Region);
			this.Platforms = new List<Platform>();
			if (string.IsNullOrEmpty(Settings.Default.Platforms))
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
				this.Platforms.AddRange(Enum.GetValues(Type.GetTypeFromHandle(ceba9f9e0e6a262196f1a06078a90f071.cde4d1aeffe0e705b07e1b3d74e931465())).Cast<Platform>());
			}
			else
			{
				try
				{
					List<Platform> platforms = this.Platforms;
					string platforms2 = Settings.Default.Platforms;
					char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20912));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20916)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20920);
					IEnumerable<string> source = platforms2.Split(array);
					Func<string, Platform> selector;
					if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ca12b4f7917d76c94794483fbd5e2acbf) == null)
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
						selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ca12b4f7917d76c94794483fbd5e2acbf = new Func<string, Platform>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.ca0d5c3eed7668e9014a7c64d0a237a20));
					}
					platforms.AddRange(source.Select(selector));
					if (!this.Platforms.Contains((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20924)))
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
						this.Platforms.Add((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20928));
					}
					if (!this.Platforms.Contains((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20932)))
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
						this.Platforms.Add((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20936));
					}
					if (!this.Platforms.Contains((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20940)))
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
						this.Platforms.Add((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20944));
					}
					if (!this.Platforms.Contains((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20948)))
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
						this.Platforms.Add((Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20952));
					}
				}
				catch
				{
					Settings.Default.Platforms = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
				}
			}
			int[] array2 = caf27e0a24607a2eca61ed1ed85da5ae6.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20956));
			RuntimeHelpers.InitializeArray(array2, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c4db36fee190d5c3abbd68f9d5dc4bd96).FieldHandle);
			Func<int, Platform> selector2;
			if ((selector2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c2a3c1d5520476e33dd9044e5d58c645f) == null)
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
				selector2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c2a3c1d5520476e33dd9044e5d58c645f = new Func<int, Platform>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c8044c989f4c38a3fd60da0926b6600c6));
			}
			List<Platform> list = array2.Select(selector2).ToList<Platform>();
			int[] array3 = caf27e0a24607a2eca61ed1ed85da5ae6.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20960));
			RuntimeHelpers.InitializeArray(array3, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c66b9f6d4df8e7bed41415727e85b21a8).FieldHandle);
			Func<int, Platform> selector3;
			if ((selector3 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c3afa6fb34611e2ec622f202fcdc6bc33) == null)
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
				selector3 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c3afa6fb34611e2ec622f202fcdc6bc33 = new Func<int, Platform>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cb6e95c3b908972bc82242f7f8759d1ad));
			}
			List<Platform> list2 = array3.Select(selector3).ToList<Platform>();
			ListViewDataItemGroup listViewDataItemGroup = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80593));
			ListViewDataItemGroup listViewDataItemGroup2 = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39814));
			this.c379f097df981d80284e646aa1f74b28f.EnableCustomGrouping = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20964) != 0);
			this.c379f097df981d80284e646aa1f74b28f.EnableGrouping = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20968) != 0);
			this.c379f097df981d80284e646aa1f74b28f.ShowGroups = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20972) != 0);
			this.c379f097df981d80284e646aa1f74b28f.Groups.Add(listViewDataItemGroup);
			this.c379f097df981d80284e646aa1f74b28f.Groups.Add(listViewDataItemGroup2);
			string[] names = Enum.GetNames(Type.GetTypeFromHandle(ceba9f9e0e6a262196f1a06078a90f071.cde4d1aeffe0e705b07e1b3d74e931465()));
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20976); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(names); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20996))
			{
				string text = names[i];
				ListViewDataItem listViewDataItem = new ListViewDataItem(text.Replace((char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20980), (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20984)));
				listViewDataItem.Tag = Enum.Parse(Type.GetTypeFromHandle(ceba9f9e0e6a262196f1a06078a90f071.cde4d1aeffe0e705b07e1b3d74e931465()), text);
				ToggleState checkState;
				if (!this.Platforms.Contains(c7bdaa15a71638fae3d1aa48c0e87d724.cb93115e3b63933899699d0ee8696f152(Enum.Parse(Type.GetTypeFromHandle(ceba9f9e0e6a262196f1a06078a90f071.cde4d1aeffe0e705b07e1b3d74e931465()), text))))
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
					checkState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20988);
				}
				else
				{
					checkState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20992);
				}
				listViewDataItem.CheckState = checkState;
				ListViewDataItem listViewDataItem2 = listViewDataItem;
				if (list.Contains(c7bdaa15a71638fae3d1aa48c0e87d724.cb93115e3b63933899699d0ee8696f152(listViewDataItem2.Tag)))
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
					listViewDataItem2.Group = listViewDataItemGroup;
				}
				if (list2.Contains(c7bdaa15a71638fae3d1aa48c0e87d724.cb93115e3b63933899699d0ee8696f152(listViewDataItem2.Tag)))
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
					listViewDataItem2.Group = listViewDataItemGroup2;
				}
				if (listViewDataItem2.Group != null)
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
					this.c379f097df981d80284e646aa1f74b28f.Items.Add(listViewDataItem2);
				}
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
			RadMessageBox.ShowInTaskbar = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21000) != 0);
			if (ApplicationDeployment.IsNetworkDeployed)
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
				Version currentVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
				this.Text = c023ef59998c1544cc2d1887c8e5ee879.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.Text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80604), currentVersion);
			}
			else if (c34ce0b034187983362ba58cc8c72233a.c0b9a995f9c2313cad22315173d49b769 != null)
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
				this.Text = c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.Text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80604), c34ce0b034187983362ba58cc8c72233a.c0b9a995f9c2313cad22315173d49b769);
			}
			if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.Path))
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
				if (!cb6cc9a5b122137bc5f2718f61ab49e59.c130125f48ba039b5fcd9946712efb476(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21004) != 0))
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
					base.Close();
					return;
				}
			}
			this.c9202010bbeb5a869433736d6d3edf68b.BackColor = this.BackColor;
			this.cda319ea417b6d72e15e4f08944f4e8f2.Select();
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21008)].Click += this.c660478eb1d4c9a8ab1a719eba1e756b8;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21012)].Click += this.c987aacae5e2ccd4cc1f0084fa917113c;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21016)].Click += this.c8624f687d68bddc9adb46168a608b18c;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21020)].Click += this.c933bb98cdba6bc05f6775c4a7ba8a2c5;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21024)].Click += this.cd5d34597fafed2e4985bdf674079e756;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21028)].Click += this.c89b5ad120452a01519974885050b937f;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21032)].Click += this.c627b6bdd07378a346cb727b5dacb30cb;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21036)].Click += this.cfd269e58e537ee2e80442a0247011817;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21040)].Click += this.cc68b36a834add29a8f2b56744b63bcd8;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21044)].Click += this.c0d95b2e7366ba7692514c594645a4ee5;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21048)].Click += this.ca9174cea51819e2c953e6e2d729e3482;
			this.cd454afeeb1c83386a9b8902a8439978e.Items[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21052)].Click += this.cefc28ae88c464bc2fc0158a446b05a41;
			this.cf6348eb630c0b01e77b8f83ec7151d96.Groups.Add(this.c41ff0acde4c428a9801876721bc993da);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Groups.Add(this.c022aac4c0d71a1c532b6e20993d403e9);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Groups.Add(this.c58d55bb55866f0df1e08f95c03606f75);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Groups.Add(this.c48c1bf2682234ca34e16ef1a566c6ec4);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Groups.Add(this.c69fce1dee9acfb2f37ac6bb69ebad9b2);
			this.c811e29a2a9751be70a187d431f6b376d(this, caa194a1ddc67cd543957fd94f509f2e3.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000452D8 File Offset: 0x000434D8
		private void c00550c458f3820261378f8287f48178c(object cd7b28952603b35a45c555982e677363a, c797ec1388c1af11408ef86282cc1652a cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c3fa9894a956fdd3bdbb07868f084de7d c3fa9894a956fdd3bdbb07868f084de7d = new cb6cc9a5b122137bc5f2718f61ab49e59.c3fa9894a956fdd3bdbb07868f084de7d();
			c3fa9894a956fdd3bdbb07868f084de7d.c4404a159870bf55bb6f111e66e59e82d = this;
			c3fa9894a956fdd3bdbb07868f084de7d.cdf15457ee4816989343b6e6e96dd4cfe = cdf15457ee4816989343b6e6e96dd4cfe;
			try
			{
				base.Invoke(new Action(c3fa9894a956fdd3bdbb07868f084de7d.ce371869618e7f44a30be714e1d62f04c));
				cd6f39abd79a47a0ec253339ea309aaed.c0b398ab350e72b0d64d512bae8520b85(cd7b28952603b35a45c555982e677363a).cfa21bb8cd0447cf1c81dd418c08ca898 -= this.c00550c458f3820261378f8287f48178c;
			}
			catch
			{
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0004533C File Offset: 0x0004353C
		private void cb0663c83842cabe396de5563ce2e0ca7(object cd7b28952603b35a45c555982e677363a, c797ec1388c1af11408ef86282cc1652a cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c95c08abb7a43bf613f6fde7fe87bb289 c95c08abb7a43bf613f6fde7fe87bb = new cb6cc9a5b122137bc5f2718f61ab49e59.c95c08abb7a43bf613f6fde7fe87bb289();
			c95c08abb7a43bf613f6fde7fe87bb.c4404a159870bf55bb6f111e66e59e82d = this;
			c95c08abb7a43bf613f6fde7fe87bb.cdf15457ee4816989343b6e6e96dd4cfe = cdf15457ee4816989343b6e6e96dd4cfe;
			try
			{
				base.Invoke(new Action(c95c08abb7a43bf613f6fde7fe87bb.c09e98b7e51e2b70d06987f42d6e4ee90));
				cd6f39abd79a47a0ec253339ea309aaed.c0b398ab350e72b0d64d512bae8520b85(cd7b28952603b35a45c555982e677363a).cfa21bb8cd0447cf1c81dd418c08ca898 -= this.cb0663c83842cabe396de5563ce2e0ca7;
			}
			catch
			{
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000453A0 File Offset: 0x000435A0
		private void c4d576329fd7ff68c89940db18c5ea705(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.SelectedGame == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c4d576329fd7ff68c89940db18c5ea705(object, EventArgs)).MethodHandle;
				}
				return;
			}
			DialogResult dialogResult = RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80615), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80817), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21056));
			Image image;
			if (dialogResult != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21060))
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
				if (dialogResult != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21064))
				{
					return;
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
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					CheckFileExists = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21068) != 0),
					Filter = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(80842)
				};
				if (openFileDialog.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21072))
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
					return;
				}
				image = Image.FromStream(new MemoryStream(File.ReadAllBytes(openFileDialog.FileName)));
				this.c0e1873c97ed5c28183d8a02dcecefe22.Image = image;
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					image.Save(memoryStream, ImageFormat.Png);
					c67726bc94fb4dd43c5c00e863a4fed19.cf1655422b15b29ae420a5500448a3df7(new Uri(this.SelectedGame.c5665d7b9f8d8c4130a023e2e716f86bb), memoryStream.ToArray());
					return;
				}
				finally
				{
					if (memoryStream != null)
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
						((IDisposable)memoryStream).Dispose();
					}
				}
			}
			byte[] array = c105c88e162b3faac8e1371ca90f921c5.c6b97de98e92251ea724e41d5b38c2e89(this.SelectedGame.c5665d7b9f8d8c4130a023e2e716f86bb, TimeSpan.Zero);
			if (array == null)
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
				return;
			}
			image = Image.FromStream(new MemoryStream(array));
			this.c0e1873c97ed5c28183d8a02dcecefe22.Image = image;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0004553C File Offset: 0x0004373C
		private void c37b3d3a9ef4a26c65a3fac4aa3cda6c2(c5409344e1c2b74fa8c9a4d620ccb8d48 c6fcdfcca42c1aeed647bdea8d9051572)
		{
			if (!c6fcdfcca42c1aeed647bdea8d9051572.c1083de0b8d92c5fcbdd7005111d34bb9)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c37b3d3a9ef4a26c65a3fac4aa3cda6c2(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				if (c6fcdfcca42c1aeed647bdea8d9051572.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21076))
				{
					this.cbef1c47350bfe240624acc48226915ee();
					bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21112) != 0;
					bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21116) != 0;
					c5409344e1c2b74fa8c9a4d620ccb8d48[] array = c049d2fd5839d8f87efe26223b47d7e92.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21120));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21124)] = c6fcdfcca42c1aeed647bdea8d9051572;
					this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, array.ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
					return;
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
				cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b = c6fcdfcca42c1aeed647bdea8d9051572.c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21080) != 0);
				if (cf7c96734e58d8de9864e1ea854bc2b7b == null)
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
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81018));
					return;
				}
				if (!this.CurrentlyDownloading)
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
					if (c6fcdfcca42c1aeed647bdea8d9051572.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21084))
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
						if (c6fcdfcca42c1aeed647bdea8d9051572.Size.TotalBytes < (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21088)))
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
							RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81125));
							cf7c96734e58d8de9864e1ea854bc2b7b.c37b3d3a9ef4a26c65a3fac4aa3cda6c2();
							bool c7fce42bedd63c230a93e4fd9929be81b2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21092) != 0;
							bool c772c2a45dacf5b536932a18299457e5a2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21096) != 0;
							c5409344e1c2b74fa8c9a4d620ccb8d48[] array2 = c049d2fd5839d8f87efe26223b47d7e92.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21100));
							array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21104)] = c6fcdfcca42c1aeed647bdea8d9051572;
							this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b2, c772c2a45dacf5b536932a18299457e5a2, array2.ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
							return;
						}
					}
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81228));
				this.c97771ef24da9591c965bc884a27c01c0(c6fcdfcca42c1aeed647bdea8d9051572);
				this.c5387a02757dbf6c1f7add91e8f83a37d.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21108) != 0);
				if (!this.CurrentlyDownloading)
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
					this.cc6ddb28650737a29456a9f365e377768();
					return;
				}
			}
			else
			{
				this.cbef1c47350bfe240624acc48226915ee();
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00045714 File Offset: 0x00043914
		private void ca6c86a0f813cb3fa848bb71af3c248e8()
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c08836558b43d118f4045e307eb6c9221 c08836558b43d118f4045e307eb6c = new cb6cc9a5b122137bc5f2718f61ab49e59.c08836558b43d118f4045e307eb6c9221();
			c08836558b43d118f4045e307eb6c.c4404a159870bf55bb6f111e66e59e82d = this;
			this.cf7f61cc59e2808aad0d77629a4b89af8 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21128) != 0);
			c08836558b43d118f4045e307eb6c.c3b711929d76da2da5e4dfd39ca14682f = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21132);
			IEnumerator<ListViewDataItem> enumerator = this.cf6348eb630c0b01e77b8f83ec7151d96.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					cb6cc9a5b122137bc5f2718f61ab49e59.c0cf082517811518034f0a0f661056f40 c0cf082517811518034f0a0f661056f = new cb6cc9a5b122137bc5f2718f61ab49e59.c0cf082517811518034f0a0f661056f40();
					c0cf082517811518034f0a0f661056f.c8c38354cddaefb45b9cfcd9ed2838c37 = c08836558b43d118f4045e307eb6c;
					c0cf082517811518034f0a0f661056f.cdaf1e048076cb48032279ef3fd414f27 = enumerator.Current;
					try
					{
						cb6cc9a5b122137bc5f2718f61ab49e59.cbd44e8f42a43b6040860da776d7c6472 cbd44e8f42a43b6040860da776d7c = new cb6cc9a5b122137bc5f2718f61ab49e59.cbd44e8f42a43b6040860da776d7c6472();
						cbd44e8f42a43b6040860da776d7c.c9def284befdb85aa51808c134f9b5700 = c0cf082517811518034f0a0f661056f;
						cbd44e8f42a43b6040860da776d7c.c6fcdfcca42c1aeed647bdea8d9051572 = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(cbd44e8f42a43b6040860da776d7c.c9def284befdb85aa51808c134f9b5700.cdaf1e048076cb48032279ef3fd414f27.Tag);
						if (cbd44e8f42a43b6040860da776d7c.c6fcdfcca42c1aeed647bdea8d9051572 == null)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ca6c86a0f813cb3fa848bb71af3c248e8()).MethodHandle;
							}
							return;
						}
						if (cbd44e8f42a43b6040860da776d7c.c6fcdfcca42c1aeed647bdea8d9051572.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21136))
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
							cbd44e8f42a43b6040860da776d7c.c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image = c6faa5467be1a4874657b372a49b7c927.dsiwareicon;
							cb6cc9a5b122137bc5f2718f61ab49e59.cf9c50c376f7589fb13d15a3b0a2bd920(cbd44e8f42a43b6040860da776d7c.c6fcdfcca42c1aeed647bdea8d9051572);
							base.Invoke(new Action(cbd44e8f42a43b6040860da776d7c.c44cfccccf8c1a797734b1a7af677947b));
						}
						else
						{
							while (cbd44e8f42a43b6040860da776d7c.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c3b711929d76da2da5e4dfd39ca14682f > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21144))
							{
								Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21140));
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
							int c3b711929d76da2da5e4dfd39ca14682f = cbd44e8f42a43b6040860da776d7c.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c3b711929d76da2da5e4dfd39ca14682f;
							cbd44e8f42a43b6040860da776d7c.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c3b711929d76da2da5e4dfd39ca14682f = c3b711929d76da2da5e4dfd39ca14682f + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21148);
							Task.Run(new Action(cbd44e8f42a43b6040860da776d7c.c1ce94f2a4a69cbbb198191b6fc2017ce));
						}
					}
					catch
					{
					}
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

		// Token: 0x060007E1 RID: 2017 RVA: 0x00045910 File Offset: 0x00043B10
		private void cc6ddb28650737a29456a9f365e377768()
		{
			this.c1a9805b730a3a6a37657fc751e3ceb86(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21152) != 0);
			this.CurrentlyDownloading = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21156) != 0);
			this.c7cb15ecb80bee59937d269db8297ea4b.Items.Clear();
			this.c9b5265c0946a689327a8c65feda18f1e();
			this.ced92a8662e50218f546ae6bb0a312b4f.ActiveWindow = this.c6c532de73864b060a67b00a40a009091;
			if (this.c727375dbbb6f023ed693138c5ee33ab6.Checked)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc6ddb28650737a29456a9f365e377768()).MethodHandle;
				}
				if (this.c46742982780fe1e9a0b84ddd2570741b.Value.CompareTo(DateTime.Now) > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21160))
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
					this.c44272853dcc0c97ee7511d3b33f129b2.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21164) != 0);
					this.c803b89929a29613f5751f6463377a31b.Start();
					return;
				}
			}
			this.c43a1c590b53a1a8387d498f47eededc3();
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000459E4 File Offset: 0x00043BE4
		private void c6cbaf2b6329c21ba2ed2db7bade8d600(IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> cd05d010db0ff3f8dc02e7335853b35e0)
		{
			IEnumerator<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerator = cd05d010db0ff3f8dc02e7335853b35e0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = enumerator.Current;
					c5409344e1c2b74fa8c9a4d620ccb8d.c6cbaf2b6329c21ba2ed2db7bade8d600();
					if (this.SelectedGame == c5409344e1c2b74fa8c9a4d620ccb8d)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c6cbaf2b6329c21ba2ed2db7bade8d600(IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48>)).MethodHandle;
						}
						if (c5409344e1c2b74fa8c9a4d620ccb8d.c1083de0b8d92c5fcbdd7005111d34bb9)
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
							this.c9f93268106946d0f8f04d9f7de77339a.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21168) != 0);
						}
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
			this.c9cce42bf08ecabb93b709c62348f4ff2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21172) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21176) != 0, cd05d010db0ff3f8dc02e7335853b35e0.ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00045AB0 File Offset: 0x00043CB0
		private void c1e413998dc3ccfe6b32327be02662ff2(object cd7b28952603b35a45c555982e677363a, ce91c3ee3b6503970820b59a90b300d72 c3c9260886a6db15de49329a9f5b9836c)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c9af8b2d91f68d81794ed34dc6cdb6e85 c9af8b2d91f68d81794ed34dc6cdb6e = new cb6cc9a5b122137bc5f2718f61ab49e59.c9af8b2d91f68d81794ed34dc6cdb6e85();
			c9af8b2d91f68d81794ed34dc6cdb6e.c4404a159870bf55bb6f111e66e59e82d = this;
			c9af8b2d91f68d81794ed34dc6cdb6e.c3c9260886a6db15de49329a9f5b9836c = c3c9260886a6db15de49329a9f5b9836c;
			try
			{
				if (base.InvokeRequired)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1e413998dc3ccfe6b32327be02662ff2(object, ce91c3ee3b6503970820b59a90b300d72)).MethodHandle;
					}
					base.BeginInvoke(new Action(c9af8b2d91f68d81794ed34dc6cdb6e.c4f1457ae0a2f7c83dc7efb1d1e37078d));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00045B18 File Offset: 0x00043D18
		private void cfd1ddf550d109e29508a7cb185b2c3e1(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			ce07c379a1090dd9de869aa5e3a694e98.cfca2dddcfdc97adcbab805e0dc800dec();
			c835740eb09051bccacfad4c551fdd155 c835740eb09051bccacfad4c551fdd = new c835740eb09051bccacfad4c551fdd155(null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21180) != 0);
			if (!Settings.Default.ForceUpdates)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cfd1ddf550d109e29508a7cb185b2c3e1(object, EventArgs)).MethodHandle;
				}
				if (!c835740eb09051bccacfad4c551fdd.c529da0940d4ea14c178fe93b48b61b96)
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
					RadMessageBox.Show(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81494), c835740eb09051bccacfad4c551fdd.cbc2836ea62c32bc8df1f63f72af3a491));
					return;
				}
			}
			c8b671fda31f88dc7c7875175126002f3 c8b671fda31f88dc7c7875175126002f = new c8b671fda31f88dc7c7875175126002f3(null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21184) != 0);
			if (!Settings.Default.ForceUpdatesCitra)
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
				if (!c8b671fda31f88dc7c7875175126002f.c529da0940d4ea14c178fe93b48b61b96)
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
					RadMessageBox.Show(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81646), c8b671fda31f88dc7c7875175126002f.cbc2836ea62c32bc8df1f63f72af3a491));
					return;
				}
			}
			if (this.c6fcdfcca42c1aeed647bdea8d9051572 == null)
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
				new Thread(new ThreadStart(this.c4f7d1cac3439bfa5747dd6dd79854764))
				{
					IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21188) != 0)
				}.Start();
				return;
			}
			this.c6fcdfcca42c1aeed647bdea8d9051572.cbdd7a75e348cb852622ecf3ce3761260();
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00045C40 File Offset: 0x00043E40
		private void c506bacf3bce3e30da3af6c9365ea3022(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (c43fd6e7f5e2958791aec6138672a52a4.ce1ba8ac5aaeae3c74a8e94a4ff0ac997())
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c506bacf3bce3e30da3af6c9365ea3022(object, EventArgs)).MethodHandle;
				}
				return;
			}
			new c1d7da5fb47c4831665780b1b86ae5a04().ShowDialog();
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00045C78 File Offset: 0x00043E78
		private void c684fc3529b79867444efc32a422d8cfe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.ceba9cb62acaa388b04961473f99877eb ceba9cb62acaa388b04961473f99877eb = new cb6cc9a5b122137bc5f2718f61ab49e59.ceba9cb62acaa388b04961473f99877eb();
			if (this.c72e7acdf474b857eac13b63d8d3e3e7f == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c684fc3529b79867444efc32a422d8cfe(object, EventArgs)).MethodHandle;
				}
				this.cfd9d1ce6346fca6179c64dac7f391035();
				return;
			}
			cc4e5a353b4d3481f87ee2fb6c6fb3ec9 cc4e5a353b4d3481f87ee2fb6c6fb3ec = new cc4e5a353b4d3481f87ee2fb6c6fb3ec9();
			if (cc4e5a353b4d3481f87ee2fb6c6fb3ec.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21192))
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
				return;
			}
			ceba9cb62acaa388b04961473f99877eb.c561c2db76c5bf8c95a684eca3517d61c = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81800), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21196) != 0);
			try
			{
				new Thread(new ThreadStart(ceba9cb62acaa388b04961473f99877eb.cc6a3f126d7c2bf1b60d6e64d13d22ded))
				{
					IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21200) != 0)
				}.Start();
				this.SelectedGame.c9a85391d186628655535db1f9c4d3bbc(this.c72e7acdf474b857eac13b63d8d3e3e7f, cc4e5a353b4d3481f87ee2fb6c6fb3ec.c31b5179e91518e056df31f49ab65715a);
			}
			catch (c8fe0c6e7a752b4c1e7ccb99b428ad373)
			{
				ceba9cb62acaa388b04961473f99877eb.c561c2db76c5bf8c95a684eca3517d61c.cc5957c0b466d791dc387469fda39883c();
				this.c9368dc60d61608581f0b9ed666b65c81(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81899));
				return;
			}
			catch (Exception ex)
			{
				ceba9cb62acaa388b04961473f99877eb.c561c2db76c5bf8c95a684eca3517d61c.cc5957c0b466d791dc387469fda39883c();
				this.c9368dc60d61608581f0b9ed666b65c81(ex.Message);
				return;
			}
			ceba9cb62acaa388b04961473f99877eb.c561c2db76c5bf8c95a684eca3517d61c.cc5957c0b466d791dc387469fda39883c();
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00045D98 File Offset: 0x00043F98
		private void c76c6c493d77de47494b871ad9913137c(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.SelectedGame.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().cf08369cbb3a626a84f05ff893b78fed7(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(81992), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21204) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21208) != 0, null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21212) != 0);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00045DF0 File Offset: 0x00043FF0
		private void c937ea4c031b5753b3e08428dc02f5cea(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = this.cc86ba4499172993cc63947e93cc907ae;
			if (cdb02a77cadec7790d5c7c433ab736a == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c937ea4c031b5753b3e08428dc02f5cea(object, EventArgs)).MethodHandle;
				}
				return;
			}
			cdb02a77cadec7790d5c7c433ab736a.c426ff9b72fe5e4a2968bc46e8012f149(cd2aafbed56deec6e2406db1545b7c5a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c7bab6db345839f9cf49d38f3cb6052bd.Value) * (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21216)));
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00045E40 File Offset: 0x00044040
		private void cc95703410337f219db3f5a5b7aca7df6()
		{
			this.c575f8d12fcef3eee352ca96a41736b5c();
			this.c58d55bb55866f0df1e08f95c03606f75.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82009), this.c58d55bb55866f0df1e08f95c03606f75.Items.Count);
			this.c41ff0acde4c428a9801876721bc993da.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82042), this.c41ff0acde4c428a9801876721bc993da.Items.Count);
			this.c022aac4c0d71a1c532b6e20993d403e9.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82093), this.c022aac4c0d71a1c532b6e20993d403e9.Items.Count);
			this.c48c1bf2682234ca34e16ef1a566c6ec4.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82150), this.c48c1bf2682234ca34e16ef1a566c6ec4.Items.Count);
			this.c69fce1dee9acfb2f37ac6bb69ebad9b2.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82203), this.c69fce1dee9acfb2f37ac6bb69ebad9b2.Items.Count);
			this.c06f4d49c4cd7969e514a4b3649e010c9.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82244), this.cf6348eb630c0b01e77b8f83ec7151d96.Items.Count);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00045FA0 File Offset: 0x000441A0
		private void c75edf037172ea3a5f8a77f6bb63d4606(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c5fe8a571ca3377e5a24fe8e769bc8d25 c5fe8a571ca3377e5a24fe8e769bc8d = new cb6cc9a5b122137bc5f2718f61ab49e59.c5fe8a571ca3377e5a24fe8e769bc8d25();
			c5fe8a571ca3377e5a24fe8e769bc8d.c804bc52f7f79bffee6fd394ef382eb76 = c804bc52f7f79bffee6fd394ef382eb76;
			this.TitlesToCopy.Remove(c5fe8a571ca3377e5a24fe8e769bc8d.c804bc52f7f79bffee6fd394ef382eb76);
			this.c3f17fb9a80a6565749e0532cfc37cf36.Items.Remove(this.c3f17fb9a80a6565749e0532cfc37cf36.Items.First(new Func<ListViewDataItem, bool>(c5fe8a571ca3377e5a24fe8e769bc8d.cc7548541ae564588f4a2204df2a6e8e3)));
			this.c65cf7cdc28eee52d9c7a54f014164e29();
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0004600C File Offset: 0x0004420C
		private void ca2c48e1c97d1d33cc1892702fc491b36(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.ce0c512d7c52b3814ee231b12a3adb557 ce0c512d7c52b3814ee231b12a3adb = new cb6cc9a5b122137bc5f2718f61ab49e59.ce0c512d7c52b3814ee231b12a3adb557();
			ce0c512d7c52b3814ee231b12a3adb.c804bc52f7f79bffee6fd394ef382eb76 = c804bc52f7f79bffee6fd394ef382eb76;
			this.TitlesToDownload.Remove(ce0c512d7c52b3814ee231b12a3adb.c804bc52f7f79bffee6fd394ef382eb76);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items.Remove(this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items.First(new Func<ListViewDataItem, bool>(ce0c512d7c52b3814ee231b12a3adb.cdcef1d1089ec61f3faf12e4e4b38a439)));
			this.cf198d0c85e4a43bf5b54955c482f8c3a();
			this.c9b5265c0946a689327a8c65feda18f1e();
			if (this.CurrentlyDownloading)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ca2c48e1c97d1d33cc1892702fc491b36(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				this.cc86ba4499172993cc63947e93cc907ae.c4459ea1028b880865dae5dd23da9f3f2();
			}
			if (this.SelectedGame != null)
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
				if (!this.SelectedGame.cdafb32c110213e85fda6c89dc227c65b(ce0c512d7c52b3814ee231b12a3adb.c804bc52f7f79bffee6fd394ef382eb76))
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
					return;
				}
			}
			if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(ce0c512d7c52b3814ee231b12a3adb.c804bc52f7f79bffee6fd394ef382eb76) != null)
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
				this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21220) != 0);
				return;
			}
			if (c9d462d6bfbf0a4267f7ed91db470887c.c0b398ab350e72b0d64d512bae8520b85(ce0c512d7c52b3814ee231b12a3adb.c804bc52f7f79bffee6fd394ef382eb76) != null)
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
				this.c5de69d272cb033f108f47623f7fef008.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21224) != 0);
				return;
			}
			this.cb3f03a694ca97a057d1693262571d407.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21228) != 0);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00046150 File Offset: 0x00044350
		private void c110f83bd8d18c031953a502b6ae828da()
		{
			this.cf7f61cc59e2808aad0d77629a4b89af8 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21232) != 0);
			Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21236));
			try
			{
				cb6cc9a5b122137bc5f2718f61ab49e59.c48d3e7e50fe1b61a60e967225f65ce0c c48d3e7e50fe1b61a60e967225f65ce0c = new cb6cc9a5b122137bc5f2718f61ab49e59.c48d3e7e50fe1b61a60e967225f65ce0c();
				c48d3e7e50fe1b61a60e967225f65ce0c.c1e9648e54295aa0c92cd31a9812e8b5d = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
				c48d3e7e50fe1b61a60e967225f65ce0c.c9913ed79662a90a996cbddf5b4c4e906 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
				string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82287);
				Action c594146923b42642ebf4bf2a5cd = new Action(c48d3e7e50fe1b61a60e967225f65ce0c.c60d43931a57fead4f3888acfa2f734a2);
				Action<Exception> c62f902d27574ffccbd029fee23622bc;
				if ((c62f902d27574ffccbd029fee23622bc = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c9231adfd2578224b772bcbb5e0ed809c) == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c110f83bd8d18c031953a502b6ae828da()).MethodHandle;
					}
					c62f902d27574ffccbd029fee23622bc = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c9231adfd2578224b772bcbb5e0ed809c = new Action<Exception>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c068280f4eb2e9ef6b4f47814d570c404));
				}
				new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
				this.cc3ddcea0d3be09242a6a70c83078277f(c48d3e7e50fe1b61a60e967225f65ce0c.c1e9648e54295aa0c92cd31a9812e8b5d, c48d3e7e50fe1b61a60e967225f65ce0c.c9913ed79662a90a996cbddf5b4c4e906);
			}
			catch
			{
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00046214 File Offset: 0x00044414
		private void cfc2df6b6486b61419b97946792123536()
		{
			string[] array = c67726bc94fb4dd43c5c00e863a4fed19.c8334ccea7202097a0899b9cb1fac251e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69735));
			if (array == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cfc2df6b6486b61419b97946792123536()).MethodHandle;
				}
				return;
			}
			string[] array2 = array;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21240); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array2); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21252))
			{
				TitleId titleId = new TitleId(array2[i]);
				if (c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.ContainsKey(new TitleId(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId.FullGame))))
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
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[new TitleId(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId.FullGame))];
					switch (titleId.IdType)
					{
					case c4646e2a6e2ad7e5620e9ecf229259217.cf3ffecff4696059f416ae6bc384a621a:
						if (c5409344e1c2b74fa8c9a4d620ccb8d.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21248))
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
							this.c7a8112437fc6661ae742d22be70531e6(c5409344e1c2b74fa8c9a4d620ccb8d);
						}
						break;
					case c4646e2a6e2ad7e5620e9ecf229259217.cfcd2a9c7ebb0515632c1fccbd0310e52:
						if (c5409344e1c2b74fa8c9a4d620ccb8d.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
							if (c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21244))
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
								this.c7a8112437fc6661ae742d22be70531e6(c5409344e1c2b74fa8c9a4d620ccb8d.Dlc);
							}
						}
						break;
					}
				}
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

		// Token: 0x060007EE RID: 2030 RVA: 0x00046370 File Offset: 0x00044570
		private void c55186724d1c08cd6a25ee04b8c3f1f00()
		{
			string c4d6abdac9d3efb16a0adcf6a56cd5ad = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69735);
			IEnumerable<ListViewDataItem> items = this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items;
			Func<ListViewDataItem, string> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8bc108fd9a86db21d2a240acaa5436b0) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c55186724d1c08cd6a25ee04b8c3f1f00()).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8bc108fd9a86db21d2a240acaa5436b0 = new Func<ListViewDataItem, string>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c32f80e2d854b7bdef204520a20cfdbc0));
			}
			c67726bc94fb4dd43c5c00e863a4fed19.c6be8a9a2e62443fd1e448c28bd8dad3e(c4d6abdac9d3efb16a0adcf6a56cd5ad, items.Select(selector).ToArray<string>());
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000463DC File Offset: 0x000445DC
		private void c1a9805b730a3a6a37657fc751e3ceb86(bool c21cd2fee205450d551f3da31d90a5abf)
		{
			this.c76617ddf050ef873ce43173d73fd39fb.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			this.c0b3afb12bff80cf464a5e9a17f791e36.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			this.cfac791f2ebab9d5414b01ffa03f31c07.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			Control control = this.c024a788ba27b0be6afa45229820c2905;
			bool enabled;
			if (!this.c3749f3cf1df50ff24b9a048e0b822d9a)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1a9805b730a3a6a37657fc751e3ceb86(bool)).MethodHandle;
				}
				enabled = this.cbeb7ed06c872d430df3d8ec783ae0dd9;
			}
			else
			{
				enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21256) != 0);
			}
			control.Enabled = enabled;
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			this.cecf676325d3b342f93a03b1b9170b253.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Enabled = c21cd2fee205450d551f3da31d90a5abf;
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Enabled = c21cd2fee205450d551f3da31d90a5abf;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00046490 File Offset: 0x00044690
		private void c84ebcf0d1ef4a18ca7ef0a37d6dcbb1c(c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1)
		{
			c9f09e7c9177b659947793f836fb406ba c9f09e7c9177b659947793f836fb406ba = c6b7fbe462f43433d64916e9273f7e5d1.cb22daca7b90d08a80c30fb487368db8c();
			if (c9f09e7c9177b659947793f836fb406ba == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c84ebcf0d1ef4a18ca7ef0a37d6dcbb1c(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				return;
			}
			if (c9f09e7c9177b659947793f836fb406ba.c29ba96361e8b79c561c2b396fd54760a)
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
				this.cced076417085a35a106849899c95b63e(c6b7fbe462f43433d64916e9273f7e5d1);
			}
			if (c9f09e7c9177b659947793f836fb406ba.c0e676a00eeebd45f592e232d614e45fc)
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
				using (List<c6a2f8acae5ff1a8a909193a5c5de6687>.Enumerator enumerator = c9f09e7c9177b659947793f836fb406ba.ce3a858deff0367f9060c2df25425c742.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						c6a2f8acae5ff1a8a909193a5c5de6687 c804bc52f7f79bffee6fd394ef382eb = enumerator.Current;
						this.cced076417085a35a106849899c95b63e(c804bc52f7f79bffee6fd394ef382eb);
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
			}
			if (c9f09e7c9177b659947793f836fb406ba.c699c8bc0a4d81b873957798fbfb86a1e)
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
				this.cced076417085a35a106849899c95b63e(c6b7fbe462f43433d64916e9273f7e5d1.Dlc);
			}
			this.ced92a8662e50218f546ae6bb0a312b4f.ActiveWindow = this.cffa7e6b0340f88d9369da7a34ef65631;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00046570 File Offset: 0x00044770
		private void c2bdd5ac8d329224157ba17be0e08f285(c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1)
		{
			cf73c09f4e7123594c77f50f36eff3418 cf73c09f4e7123594c77f50f36eff = new cf73c09f4e7123594c77f50f36eff3418(c6b7fbe462f43433d64916e9273f7e5d1, (WhatToAction)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21260));
			if (cf73c09f4e7123594c77f50f36eff.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21264))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c2bdd5ac8d329224157ba17be0e08f285(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				return;
			}
			if (cf73c09f4e7123594c77f50f36eff.CopyDlc)
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
				c6b7fbe462f43433d64916e9273f7e5d1.Dlc.c3e9844232914e2f1ccf3d192ecfca2bd();
			}
			if (cf73c09f4e7123594c77f50f36eff.CopyGame)
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
				c6b7fbe462f43433d64916e9273f7e5d1.c3e9844232914e2f1ccf3d192ecfca2bd();
			}
			if (cf73c09f4e7123594c77f50f36eff.CopyUpdate)
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
				using (List<c6a2f8acae5ff1a8a909193a5c5de6687>.Enumerator enumerator = cf73c09f4e7123594c77f50f36eff.c9f4bf79f56cd07529ca7850385fa2cb4.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						c6a2f8acae5ff1a8a909193a5c5de6687 c6a2f8acae5ff1a8a909193a5c5de = enumerator.Current;
						c6a2f8acae5ff1a8a909193a5c5de.c3e9844232914e2f1ccf3d192ecfca2bd();
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
				}
			}
			bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21268) != 0;
			bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21272) != 0;
			c5409344e1c2b74fa8c9a4d620ccb8d48[] array = c049d2fd5839d8f87efe26223b47d7e92.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21276));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21280)] = c6b7fbe462f43433d64916e9273f7e5d1;
			this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, new List<c5409344e1c2b74fa8c9a4d620ccb8d48>(array));
			this.cf95ba3b48fd484ff24b6901d8a9a1280();
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000466A4 File Offset: 0x000448A4
		private void c9368dc60d61608581f0b9ed666b65c81(string cfeefea196000bed18adf05bf7727db15)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cb517ca393ca1d7c5b9752f5faf9e7342 cb517ca393ca1d7c5b9752f5faf9e = new cb6cc9a5b122137bc5f2718f61ab49e59.cb517ca393ca1d7c5b9752f5faf9e7342();
			cb517ca393ca1d7c5b9752f5faf9e.c4404a159870bf55bb6f111e66e59e82d = this;
			cb517ca393ca1d7c5b9752f5faf9e.cfeefea196000bed18adf05bf7727db15 = cfeefea196000bed18adf05bf7727db15;
			base.Invoke(new MethodInvoker(cb517ca393ca1d7c5b9752f5faf9e.c2a2ee1fbb3c7da931aac719c272fe2fb));
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000466DC File Offset: 0x000448DC
		private void c2ab6323e26beb0b86b8b422636721d57()
		{
			this.c9368dc60d61608581f0b9ed666b65c81(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82368));
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000466FC File Offset: 0x000448FC
		private bool cc7b9d3eeecabdf2ae8090177cd524edc(ListViewDataItem cdaf1e048076cb48032279ef3fd414f27)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c860fb806500f615dda89ece894c97127 c860fb806500f615dda89ece894c = new cb6cc9a5b122137bc5f2718f61ab49e59.c860fb806500f615dda89ece894c97127();
			c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(cdaf1e048076cb48032279ef3fd414f27.Tag);
			if (c5409344e1c2b74fa8c9a4d620ccb8d == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc7b9d3eeecabdf2ae8090177cd524edc(ListViewDataItem)).MethodHandle;
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21284) != 0;
			}
			cb6cc9a5b122137bc5f2718f61ab49e59.c860fb806500f615dda89ece894c97127 c860fb806500f615dda89ece894c2 = c860fb806500f615dda89ece894c;
			string text = c5409344e1c2b74fa8c9a4d620ccb8d.Name.Trim().ToLower();
			char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21288));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21292)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21296);
			c860fb806500f615dda89ece894c2.ce56c4d37037c859fea445fea7f3c46b3 = text.Split(array);
			if (c5409344e1c2b74fa8c9a4d620ccb8d.CfwOnly)
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
				if (!this.c92d48e7b56cd690ea66ba42d3db5e722.Checked)
				{
					goto IL_2E6;
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
			if (!c5409344e1c2b74fa8c9a4d620ccb8d.CfwOnly)
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
				if (!this.c992db60513feabfee7066ab96aec9a64.Checked)
				{
					goto IL_2E6;
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
			}
			if (c5409344e1c2b74fa8c9a4d620ccb8d.Name.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82475)))
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
				if (!this.c821c2394e2dbac0ba1c2982eeb77d30d.Checked)
				{
					goto IL_2E6;
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
			if (!this.c140ccd2b676242ee7992f31d621ad05b.Checked)
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
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3752)))
				{
					goto IL_2E6;
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
			if (!this.ca462c61c0669b9dd1d247bbdb465239d.Checked)
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
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
				{
					goto IL_2E6;
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
			}
			if (!this.ca4bbd9e42efba9cc6ffad5fab3161776.Checked)
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
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47158)))
				{
					goto IL_2E6;
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
			if (!this.c693a1e47df92a82ced2b7ad96d5fae58.Checked)
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
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46688)))
				{
					goto IL_2E6;
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
			}
			if (this.Platforms.Contains(c5409344e1c2b74fa8c9a4d620ccb8d.Platform))
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
				if (this.ca3616b09795098887eec9ba9fcfc049d != null)
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
					if (!this.ca3616b09795098887eec9ba9fcfc049d.Contains(c5409344e1c2b74fa8c9a4d620ccb8d.EshopId))
					{
						goto IL_2E6;
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
				string text2 = this.c90fe97b27e47a56fbdfb26d97ff3fbe0.Text.Trim().ToLower();
				char[] array2 = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21300));
				array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21304)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21308);
				return text2.Split(array2).All(new Func<string, bool>(c860fb806500f615dda89ece894c.cd1502936a09bf7cccd7e0aeb79a8eeb6));
			}
			IL_2E6:
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21312) != 0;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000469FC File Offset: 0x00044BFC
		private void cfd9d1ce6346fca6179c64dac7f391035()
		{
			this.c9368dc60d61608581f0b9ed666b65c81(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82502));
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00046A1C File Offset: 0x00044C1C
		private void c43a1c590b53a1a8387d498f47eededc3()
		{
			try
			{
				TaskbarManager.Instance.SetProgressState(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21316));
			}
			catch
			{
			}
			this.c5169ad0b0f27e90b026e527bef772b18(this.TitlesToDownload);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00046A60 File Offset: 0x00044C60
		private void c7cf210e27d5e29bd47df57d8ff9bac8b()
		{
			this.CurrentlyDownloading = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21320) != 0);
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c803b89929a29613f5751f6463377a31b.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21324) != 0);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00046AAC File Offset: 0x00044CAC
		private void c2145c40faa659435327807e52afa590a(object cd7b28952603b35a45c555982e677363a, string c3d57b353c405c58b3e7b1741fb443d42)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.c03e1373e570a2ba4e081181081af3669 c03e1373e570a2ba4e081181081af = new cb6cc9a5b122137bc5f2718f61ab49e59.c03e1373e570a2ba4e081181081af3669();
			c03e1373e570a2ba4e081181081af.c4404a159870bf55bb6f111e66e59e82d = this;
			c03e1373e570a2ba4e081181081af.c3d57b353c405c58b3e7b1741fb443d42 = c3d57b353c405c58b3e7b1741fb443d42;
			try
			{
				if (base.InvokeRequired)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c2145c40faa659435327807e52afa590a(object, string)).MethodHandle;
					}
					base.Invoke(new Action(c03e1373e570a2ba4e081181081af.c59f6083c978c3fd39a8769f19cd035b7));
				}
				else
				{
					this.c7cb15ecb80bee59937d269db8297ea4b.Items.Add(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82768), this.c7cb15ecb80bee59937d269db8297ea4b.Items.Count + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21328), c03e1373e570a2ba4e081181081af.c3d57b353c405c58b3e7b1741fb443d42));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00046B68 File Offset: 0x00044D68
		private void c03c403525214a1ccc261589c0d641a8f(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c46742982780fe1e9a0b84ddd2570741b.Value.CompareTo(DateTime.Now);
			if (this.c46742982780fe1e9a0b84ddd2570741b.Value.CompareTo(DateTime.Now) > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21332))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c03c403525214a1ccc261589c0d641a8f(object, EventArgs)).MethodHandle;
				}
				this.c3e2b0edd5c4db8fcb6c60a419bd93842.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82785), c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c46742982780fe1e9a0b84ddd2570741b.Value, DateTime.Now).ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82802)));
				return;
			}
			this.c7cf210e27d5e29bd47df57d8ff9bac8b();
			this.c43a1c590b53a1a8387d498f47eededc3();
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00046C30 File Offset: 0x00044E30
		private void ca8fb93f9f85cf180016d71fb0715e1b8(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			try
			{
				c6114b34ba4893a53ebb4b599e0e2e3fc.c30fb6614ee092b8ded8b858aba8f900b();
			}
			catch
			{
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00046C58 File Offset: 0x00044E58
		private void caf1e1e92e15cc9c50d8c4dac5e34266b()
		{
			this.c85837e3848f514b3ef5efaee2f6dde4c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82823);
			this.c85837e3848f514b3ef5efaee2f6dde4c.ForeColor = Color.Red;
			this.Proxy = cf2b4a9dbe434b6a0557e32d5575d4dca.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00046C9C File Offset: 0x00044E9C
		private void ca81e1fe6a4bc9fd553aee66fb6701460()
		{
			if (cacd6f8420e56d296adef754f4a362ae7.c3fcf5c54f75fc17c7e5ebe876702d817)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ca81e1fe6a4bc9fd553aee66fb6701460()).MethodHandle;
				}
				this.c465fcdfe56a0a674011dbc560d792469.ForeColor = Color.Green;
				this.c465fcdfe56a0a674011dbc560d792469.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82838);
				this.c6ebb696cd62bce16aa5fc8555508c41b.Text = cacd6f8420e56d296adef754f4a362ae7.Donator.Email;
				this.c35cb28ad4c137d6a5c2019389c2b9e68.Text = cacd6f8420e56d296adef754f4a362ae7.Donator.DonationDate;
				return;
			}
			this.c465fcdfe56a0a674011dbc560d792469.ForeColor = Color.Red;
			this.c465fcdfe56a0a674011dbc560d792469.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82895);
			this.c6ebb696cd62bce16aa5fc8555508c41b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c35cb28ad4c137d6a5c2019389c2b9e68.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00046D78 File Offset: 0x00044F78
		private void c9cce42bf08ecabb93b709c62348f4ff2(bool c7fce42bedd63c230a93e4fd9929be81b = false, bool c772c2a45dacf5b536932a18299457e5a = true, List<c5409344e1c2b74fa8c9a4d620ccb8d48> cbbdf286def619cf67a5d9fb8d7d18430 = null)
		{
			this.cf6348eb630c0b01e77b8f83ec7151d96.BeginUpdate();
			IEnumerator<ListViewDataItem> enumerator = this.cf6348eb630c0b01e77b8f83ec7151d96.Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(listViewDataItem.Tag);
					if (cbbdf286def619cf67a5d9fb8d7d18430 != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c9cce42bf08ecabb93b709c62348f4ff2(bool, bool, List<c5409344e1c2b74fa8c9a4d620ccb8d48>)).MethodHandle;
						}
						if (!cbbdf286def619cf67a5d9fb8d7d18430.Contains(c5409344e1c2b74fa8c9a4d620ccb8d))
						{
							continue;
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
					if (c772c2a45dacf5b536932a18299457e5a)
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
						c5409344e1c2b74fa8c9a4d620ccb8d.c7ff9b69ed99c1e935069737f80db9054();
						if (c5409344e1c2b74fa8c9a4d620ccb8d.c66201ce2763de795655e645e059b6451)
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
							using (List<c6a2f8acae5ff1a8a909193a5c5de6687>.Enumerator enumerator2 = c5409344e1c2b74fa8c9a4d620ccb8d.Updates.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									c6a2f8acae5ff1a8a909193a5c5de6687 c6a2f8acae5ff1a8a909193a5c5de = enumerator2.Current;
									c6a2f8acae5ff1a8a909193a5c5de.c7ff9b69ed99c1e935069737f80db9054();
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
						}
						if (c5409344e1c2b74fa8c9a4d620ccb8d.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
							c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.c7ff9b69ed99c1e935069737f80db9054();
						}
						listViewDataItem.Group = this.c3b8d58494a1935b104c4727552adea4e(c5409344e1c2b74fa8c9a4d620ccb8d);
						listViewDataItem[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21336)] = c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d.cce55c1c54594dc99c5eedaa006793af4, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72572));
						ListViewDataItem listViewDataItem2 = listViewDataItem;
						int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21340);
						object obj;
						if (!c5409344e1c2b74fa8c9a4d620ccb8d.c66201ce2763de795655e645e059b6451)
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
							obj = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72575);
						}
						else if (c5409344e1c2b74fa8c9a4d620ccb8d.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21344))
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
							obj = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72580);
						}
						else
						{
							obj = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72587);
						}
						listViewDataItem2[num] = obj;
						ListViewDataItem listViewDataItem3 = listViewDataItem;
						int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21348);
						object obj2;
						if (!c5409344e1c2b74fa8c9a4d620ccb8d.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
							obj2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72575);
						}
						else if (c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21352))
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
							obj2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72580);
						}
						else
						{
							obj2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(72587);
						}
						listViewDataItem3[num2] = obj2;
						if (c7fce42bedd63c230a93e4fd9929be81b)
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
							cb6cc9a5b122137bc5f2718f61ab49e59.cf9c50c376f7589fb13d15a3b0a2bd920(c5409344e1c2b74fa8c9a4d620ccb8d);
							listViewDataItem.Image = c5409344e1c2b74fa8c9a4d620ccb8d.c1b244cd4be573ae37f8e3f6fd69b891f.Image;
						}
					}
					listViewDataItem.ForeColor = cb6cc9a5b122137bc5f2718f61ab49e59.cc213bd6b56f3c82ebc38eabf78e72386(c5409344e1c2b74fa8c9a4d620ccb8d);
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
			this.cc95703410337f219db3f5a5b7aca7df6();
			this.cfee694ddfb488d683b8b21ceb17beb3e();
			this.cf6348eb630c0b01e77b8f83ec7151d96.EndUpdate();
			this.cf95ba3b48fd484ff24b6901d8a9a1280();
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0004705C File Offset: 0x0004525C
		private void cf95ba3b48fd484ff24b6901d8a9a1280()
		{
			if (this.SelectedGame == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cf95ba3b48fd484ff24b6901d8a9a1280()).MethodHandle;
				}
				return;
			}
			this.c0e1873c97ed5c28183d8a02dcecefe22.Image = cafec3579a55ef0ba5bcc1f341243b3ba.cab55a050df275722227783d6686266c9;
			this.c9f93268106946d0f8f04d9f7de77339a.Enabled = this.SelectedGame.c1083de0b8d92c5fcbdd7005111d34bb9;
			this.c381071419ced61a1622e530e0c8d1688.Text = this.SelectedGame.Size.ToString();
			this.c47b614ac867932e76ad37c381b0fe8c6.ForeColor = this.SelectedGame.c1987926a4691c2e0ac2736e17b520743;
			this.c47b614ac867932e76ad37c381b0fe8c6.LabelElement.ToolTipText = this.SelectedGame.c4f12a532280022aa0ac2a03a0cc1d3a1;
			this.c218e0ce0f7d843f536a409b942e4ca6d.ForeColor = this.SelectedGame.c22c41eb1f56c720cea56d55e8a170036;
			this.c218e0ce0f7d843f536a409b942e4ca6d.LabelElement.ToolTipText = this.SelectedGame.c539c0378720ce4c2c66259e201a75f54;
			this.c204af998c7bd7e41658b068560e69a22.Text = this.SelectedGame.TitleId.ToSplitString();
			this.c11bba70fac0494286e0d3ef67e7108a8.Enabled = (this.SelectedGame.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21356));
			this.cb88959703fad6c1e125b370dc1b1d628.Enabled = (this.SelectedGame.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21360));
			try
			{
				this.c967e6f900acf8fed69dd58fc13e618c9.Url = new Uri(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82944), HttpUtility.UrlEncode(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.SelectedGame.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83023).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6249), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6252))))), (UriKind)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21364));
			}
			catch
			{
			}
			Control control = this.cb3f03a694ca97a057d1693262571d407;
			string text;
			if (this.SelectedGame.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21368))
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
				if (!this.SelectedGame.c9e33774c6343e7c7fe83022678b014ae)
				{
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83045);
					goto IL_22F;
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
			text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83036);
			IL_22F:
			control.Text = text;
			if (this.SelectedGame.c66201ce2763de795655e645e059b6451)
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
				this.c3b1862ccc73a74157a0aa2e808890118.Text = this.SelectedGame.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().Size.ToString();
				this.c68fb0560502ff7bad26efa6cf163c845.LabelElement.ToolTipText = this.SelectedGame.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().c539c0378720ce4c2c66259e201a75f54;
				this.c68fb0560502ff7bad26efa6cf163c845.ForeColor = this.SelectedGame.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().c22c41eb1f56c720cea56d55e8a170036;
				this.c7897cd9c092dc3138c4daed47b35970b.ForeColor = this.SelectedGame.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().c1987926a4691c2e0ac2736e17b520743;
				this.c7897cd9c092dc3138c4daed47b35970b.LabelElement.ToolTipText = this.SelectedGame.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().c4f12a532280022aa0ac2a03a0cc1d3a1;
				Control control2 = this.c973e711e4ba0b9bf06b636bdbabddad0;
				string c0d6c37d812d5d4b610705a6421056252 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83060);
				cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b = this.SelectedGame.c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21372) != 0);
				string c0d6c37d812d5d4b610705a64210562522;
				if (cf7c96734e58d8de9864e1ea854bc2b7b == null)
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
					c0d6c37d812d5d4b610705a64210562522 = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
				}
				else
				{
					c0d6c37d812d5d4b610705a64210562522 = cf7c96734e58d8de9864e1ea854bc2b7b.cd432dc5c6962dc6093ffdf141c495abd().ToString();
				}
				control2.Text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, c0d6c37d812d5d4b610705a64210562522);
				this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21376) != 0);
				this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83065);
			}
			else
			{
				this.c7897cd9c092dc3138c4daed47b35970b.ForeColor = Color.Gray;
				this.c68fb0560502ff7bad26efa6cf163c845.ForeColor = Color.Gray;
				this.c973e711e4ba0b9bf06b636bdbabddad0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
				this.c3b1862ccc73a74157a0aa2e808890118.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
				this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83088);
				this.c7897cd9c092dc3138c4daed47b35970b.LabelElement.ToolTipText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83088);
				this.c68fb0560502ff7bad26efa6cf163c845.LabelElement.ToolTipText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83088);
				this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21380) != 0);
			}
			if (this.SelectedGame.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
				this.c98fc23ab6c8b6356924ad18312dd43db.Text = this.SelectedGame.Dlc.Size.ToString();
				this.c8720232fcccea592194b8028025cef8b.ForeColor = this.SelectedGame.Dlc.c1987926a4691c2e0ac2736e17b520743;
				this.c8720232fcccea592194b8028025cef8b.LabelElement.ToolTipText = this.SelectedGame.Dlc.c4f12a532280022aa0ac2a03a0cc1d3a1;
				this.c8d2bc6d98c482abe32079c696410b384.ForeColor = this.SelectedGame.c22c41eb1f56c720cea56d55e8a170036;
				this.c8d2bc6d98c482abe32079c696410b384.LabelElement.ToolTipText = this.SelectedGame.c539c0378720ce4c2c66259e201a75f54;
				this.c5de69d272cb033f108f47623f7fef008.Enabled = ((this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.c2d3f26433491ff35cdc3587b8acfa19d(this.SelectedGame.Dlc) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21384));
				this.c5de69d272cb033f108f47623f7fef008.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83127);
			}
			else
			{
				this.c8720232fcccea592194b8028025cef8b.ForeColor = Color.Gray;
				this.c8720232fcccea592194b8028025cef8b.LabelElement.ToolTipText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83144);
				this.c8d2bc6d98c482abe32079c696410b384.ForeColor = Color.Gray;
				this.c8d2bc6d98c482abe32079c696410b384.LabelElement.ToolTipText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83144);
				this.c98fc23ab6c8b6356924ad18312dd43db.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
				this.c5de69d272cb033f108f47623f7fef008.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83144);
				this.c5de69d272cb033f108f47623f7fef008.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21388) != 0);
			}
			this.cb890309788bc92be17b6a235de6f886c.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21392) != 0);
			Control control3 = this.cb3f03a694ca97a057d1693262571d407;
			bool enabled;
			if (!this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.c2d3f26433491ff35cdc3587b8acfa19d(this.SelectedGame))
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
				enabled = ((this.SelectedGame.DiscOnly ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21396));
			}
			else
			{
				enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21400) != 0);
			}
			control3.Enabled = enabled;
			this.c96836d00d3b2ff6ba296617dd93ac7d1.Text = this.SelectedGame.Name;
			if (this.SelectedGame.CfwOnly)
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
				this.c96836d00d3b2ff6ba296617dd93ac7d1.Text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c96836d00d3b2ff6ba296617dd93ac7d1.Text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5713));
			}
			if (this.SelectedGame.DiscOnly)
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
				this.c96836d00d3b2ff6ba296617dd93ac7d1.Text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c96836d00d3b2ff6ba296617dd93ac7d1.Text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83177));
			}
			Control control4 = this.cff69c812b578b7c94cbd35be243af026;
			bool enabled2;
			if (this.SelectedGame.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21404))
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
				if (!this.SelectedGame.c66201ce2763de795655e645e059b6451)
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
					if (this.SelectedGame.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
						enabled2 = (this.SelectedGame.Dlc.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21408));
						goto IL_7EE;
					}
					enabled2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21412) != 0);
					goto IL_7EE;
				}
			}
			enabled2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21416) != 0);
			IL_7EE:
			control4.Enabled = enabled2;
			Control control5 = this.ceed5d76836a72a0a0356175e703e6aa6;
			bool enabled3;
			if (this.SelectedGame.ca435006c85356cb7385a782de8889a0a == c59ff87f6bdc69ff3440c18f170633236.c75de07cf35dca1805ba630578576f097)
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
				if (!this.SelectedGame.c1083de0b8d92c5fcbdd7005111d34bb9)
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
					if (!this.SelectedGame.c66201ce2763de795655e645e059b6451)
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
						if (this.SelectedGame.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
							enabled3 = (this.SelectedGame.Dlc.ca435006c85356cb7385a782de8889a0a > (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21420));
							goto IL_8A2;
						}
						enabled3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21424) != 0);
						goto IL_8A2;
					}
				}
			}
			enabled3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21428) != 0);
			IL_8A2:
			control5.Enabled = enabled3;
			this.c9202010bbeb5a869433736d6d3edf68b.Text = "";
			this.cbe7fa4761f85da94859280c8565879f4.Image = cafec3579a55ef0ba5bcc1f341243b3ba.cab55a050df275722227783d6686266c9;
			this.cb4a1967318bc2f47a2a97d027e20d00f.Image = cafec3579a55ef0ba5bcc1f341243b3ba.cab55a050df275722227783d6686266c9;
			this.cf79908ea7fb179e130decfd49ac2942e.Image = cafec3579a55ef0ba5bcc1f341243b3ba.cab55a050df275722227783d6686266c9;
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.Image = c6faa5467be1a4874657b372a49b7c927.banner;
			PictureBox pictureBox = this.c03e15e05f6410711c2d29af150da73bc;
			Image image;
			if (this.SelectedGame.System != ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
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
				if (this.SelectedGame.System != (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21432))
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
					image = cafec3579a55ef0ba5bcc1f341243b3ba.cab55a050df275722227783d6686266c9;
				}
				else
				{
					image = c6faa5467be1a4874657b372a49b7c927.logoWiiU;
				}
			}
			else
			{
				image = c6faa5467be1a4874657b372a49b7c927.logo3ds;
			}
			pictureBox.Image = image;
			this.SelectedGame.c0bc5b046c46ca1090fa7a9ae47e299ea(new Action<cbdbecb4f2aabec5734fa1432e4548f8e, c5409344e1c2b74fa8c9a4d620ccb8d48>(this.c68a5194f0daf9053499a3429fb0c0e8a));
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000479F0 File Offset: 0x00045BF0
		private void ca13142555fa95005ae606653620ba25f(ulong c870f09a03fcd42fab9aef6249ddf6756)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cb2069e67c6643bfdffabf9f9e920acdf cb2069e67c6643bfdffabf9f9e920acdf = new cb6cc9a5b122137bc5f2718f61ab49e59.cb2069e67c6643bfdffabf9f9e920acdf();
			cb2069e67c6643bfdffabf9f9e920acdf.c4404a159870bf55bb6f111e66e59e82d = this;
			cb2069e67c6643bfdffabf9f9e920acdf.c870f09a03fcd42fab9aef6249ddf6756 = c870f09a03fcd42fab9aef6249ddf6756;
			base.Invoke(new MethodInvoker(cb2069e67c6643bfdffabf9f9e920acdf.c8f83ca666babb7f02388d7079dd000a0));
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00047A28 File Offset: 0x00045C28
		private void cd0d84c91f10ed076a8e182e6a0dcf4ee(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			c6a5e9b85d86b4e098a511017a1073d71.c4e279d2507652407e1d6d8d867af8361 = this.c792ef639cb88d2161a4888ab19e4d1f3.Checked;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00047A48 File Offset: 0x00045C48
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.Dispose(bool)).MethodHandle;
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

		// Token: 0x06000802 RID: 2050 RVA: 0x00047A90 File Offset: 0x00045C90
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c66944218dc6924b147fbc6b0f72a424f = new Container();
			ListViewDetailColumn listViewDetailColumn = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51927), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45454));
			ListViewDetailColumn listViewDetailColumn2 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51953), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46477));
			ListViewDetailColumn listViewDetailColumn3 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83226), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45445));
			ListViewDetailColumn listViewDetailColumn4 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83243), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83260));
			ListViewDetailColumn listViewDetailColumn5 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83281), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48113));
			ListViewDetailColumn listViewDetailColumn6 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83298), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48151));
			ListViewDetailColumn listViewDetailColumn7 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51927), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51927));
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c2555811fe1bbe3f7c849a1a259769b09.cde4d1aeffe0e705b07e1b3d74e931465()));
			AutoHideGroup autoHideGroup = new AutoHideGroup();
			AutoHideGroup autoHideGroup2 = new AutoHideGroup();
			this.cf8cb420d295db38024b73fbf777f57ea = new DockWindowPlaceholder();
			this.cba695b1387526cc2dbaf8bc082358792 = new DockWindowPlaceholder();
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0 = new RadTextBox();
			this.cf6348eb630c0b01e77b8f83ec7151d96 = new RadListView();
			this.c55dae0c1480836020900dbf1801fc283 = new OpenFileDialog();
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c = new RadLabel();
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2 = new RadListView();
			this.c15cfb8d25fc93dd1b55a4ea47493c187 = new RadLabel();
			this.cde07a8d8f3fe5ea1f59833c2ca019b46 = new RadLabel();
			this.c06f4d49c4cd7969e514a4b3649e010c9 = new RadLabel();
			this.c9df3025f0563abbb25d17e41a7657e81 = new RadGroupBox();
			this.c5387a02757dbf6c1f7add91e8f83a37d = new RadCheckBox();
			this.c49e0e1006d938106f4f6b78dc1a9fbe9 = new RadCheckBox();
			this.c46742982780fe1e9a0b84ddd2570741b = new DateTimePicker();
			this.c9cab24920274230a73629880e3d2f54d = new RadButton();
			this.c3e2b0edd5c4db8fcb6c60a419bd93842 = new RadLabel();
			this.c15ef48f6d131106befa105251dceaed9 = new RadCheckBox();
			this.ce77148f56a941930515ae05ee4a8abba = new RadCheckBox();
			this.c69103ed6bfb59dc17e3aed75cdbe979d = new RadCheckBox();
			this.cef9cf59a04a9a091015a8a429a716577 = new RadCheckBox();
			this.c727375dbbb6f023ed693138c5ee33ab6 = new RadCheckBox();
			this.c99bd3ea85b6a1aa87f929de1fca32ff1 = new RadCheckBox();
			this.c1afd523200a21e6b7132517361aba805 = new RadGroupBox();
			this.c13964aec72502e7656b1ae19a819aff9 = new RadLabel();
			this.c271cb122814a1639c9b4c33232d68a4b = new RadProgressBar();
			this.c73a9fa38c32073af376cb816c1f090ff = new RadLabel();
			this.c7bab6db345839f9cf49d38f3cb6052bd = new RadSpinEditor();
			this.ca65c4bbf27dcaa72b8d1adc74336c0af = new RadButton();
			this.c7cb15ecb80bee59937d269db8297ea4b = new RadListView();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29 = new RadGroupBox();
			this.ceed5d76836a72a0a0356175e703e6aa6 = new RadButton();
			this.cff69c812b578b7c94cbd35be243af026 = new RadButton();
			this.c5de69d272cb033f108f47623f7fef008 = new RadButton();
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb = new Label();
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b = new RadButton();
			this.cb3f03a694ca97a057d1693262571d407 = new RadButton();
			this.c96836d00d3b2ff6ba296617dd93ac7d1 = new RadLabel();
			this.cc88cf84905313ad542b0916fffeca13a = new RadGroupBox();
			this.c5ef121095a54af022617ead3cdccfecd = new RadLabel();
			this.c5c0da2c4ace7b32f1e7344aa4557ff66 = new RadProgressBar();
			this.cbb0b4fa2ccd34211c18c0710f18f2c81 = new RadGroupBox();
			this.c334cd5fa87833f636046cdbd48987d99 = new RadLabel();
			this.c70e980dd6de0ea664d1165b0bab9c505 = new RadProgressBar();
			this.ced92a8662e50218f546ae6bb0a312b4f = new RadDock();
			this.cffa7e6b0340f88d9369da7a34ef65631 = new ToolWindow();
			this.c3f17fb9a80a6565749e0532cfc37cf36 = new RadListView();
			this.c7a3b11fb7f169020337311c6c740f967 = new RadButton();
			this.cf5e6e788cc75cc8a2930ca14db8241d0 = new RadButton();
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0 = new RadButton();
			this.cd09b52c3ae35fea01e57c925cb0b9ada = new RadGroupBox();
			this.c43ac0965f3c4dba40288724acda79152 = new RadLabel();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.c052ccf41a3ad1f787a00eeef2d674c87 = new RadLabel();
			this.ce101c2d73f85a684f9dce02f36f4b13d = new ToolTabStrip();
			this.cd9cc6282fcad129739eed0b12b013814 = new ToolWindow();
			this.c6a2b595cc5d4feecae7d4d122a8f1dce = new PictureBox();
			this.c822d3bd636ef45abd026eb08950f0fcc = new RadSplitContainer();
			this.c3734340a6bb7f4279e55914719952804 = new DocumentContainer();
			this.caab8d6cd57c54c842169d92d82ff1eb4 = new DocumentTabStrip();
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b = new ToolWindow();
			this.c2cf916b4dc1582084d9fe6ddbeff235f = new RadGroupBox();
			this.c992db60513feabfee7066ab96aec9a64 = new CheckBox();
			this.c821c2394e2dbac0ba1c2982eeb77d30d = new CheckBox();
			this.c92d48e7b56cd690ea66ba42d3db5e722 = new CheckBox();
			this.c8839ab017cc506ca34b8277549d5d1bc = new RadCheckBox();
			this.c5a37947f2bfc099265b4ef9252b00763 = new RadGroupBox();
			this.cdfa7a89b1b84c54d18b8677922f3bb6f = new RadButton();
			this.c19ea03710ebcce9d9618141875fa6b4b = new ToolWindow();
			this.c0717e8606cc1780a278c591545ce83ab = new RadGroupBox();
			this.c379f097df981d80284e646aa1f74b28f = new RadCheckedListBox();
			this.c0e7bde0280df56351440f1954d87e7a9 = new RadButton();
			this.c53ab326bd7d17bbcadde4355d8fe4bfc = new RadButton();
			this.c0ae86718cfb509f45e535dd79ebdeb1c = new RadGroupBox();
			this.ca4bbd9e42efba9cc6ffad5fab3161776 = new RadCheckBox();
			this.c693a1e47df92a82ced2b7ad96d5fae58 = new RadCheckBox();
			this.ca462c61c0669b9dd1d247bbdb465239d = new RadCheckBox();
			this.c140ccd2b676242ee7992f31d621ad05b = new RadCheckBox();
			this.c96d38c3849e994101ac7564a97ee637d = new ToolWindow();
			this.c959a761dc775e86d2402435397545a98 = new RadGroupBox();
			this.c127c6c3e1f77cb695a754ccf2106b43f = new RadCheckedListBox();
			this.c771aaa5176d35a275b87f16a926f5c2f = new RadButton();
			this.c556ce890ae6cca856126c0a40a422ad2 = new RadButton();
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82 = new ToolWindow();
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455 = new RadGroupBox();
			this.c30ff40a26c3b8d3f5b34356c58f244ee = new RadLabel();
			this.cf070b8f366fa5e362b202a68723dd024 = new RadGroupBox();
			this.c63371175f2a9c38a0ecc286c5d95503f = new RadCheckBox();
			this.c7fbe090bab86fb6fbed0140fe13b50ac = new RadGroupBox();
			this.c85837e3848f514b3ef5efaee2f6dde4c = new RadLabel();
			this.cd130fbdce9a854f33033b953b07b1d27 = new RadLabel();
			this.c42691c651c912f80ce2a6783758e6eeb = new RadButton();
			this.c8dc32f35e68597fe4c6daa5fe1df3f09 = new RadButton();
			this.c6f49ef988d94b37c11e87121dc8cf655 = new RadTextBox();
			this.cb0cfae55913822d197dd756dceb3d6aa = new RadTextBox();
			this.cb5a0a2daffea489d9502568fc2558386 = new RadLabel();
			this.c7c0d0e61cda4b5dbf992885ec7aab275 = new RadLabel();
			this.ccc6197ad0cf795a9587c66570a9dfb79 = new RadTextBox();
			this.cdf2e782b37313a443dabb661cd0cbf24 = new RadLabel();
			this.c3cc59d9c7d75e7586fc9064eea5aa1be = new ToolWindow();
			this.c1d6115076623e59322dfdd1bdc07fa83 = new RadGroupBox();
			this.c226f954145921ae178aa3238c5370176 = new RadButton();
			this.c4e15dbb60549d511732b8608a9a1cf24 = new RadLabel();
			this.cf852cda1e32cfb76a067c73ed3f9a113 = new RadGroupBox();
			this.c7a7e4684ac13bfb11ce1a11695b1329c = new RadCheckBox();
			this.c54df7c8ea1f37706a137b19cef6a157e = new RadGroupBox();
			this.c205802b28402610c81760457c1ed80d0 = new RadCheckBox();
			this.cf1ae3eee5cba489bc07bd471e11bf801 = new RadGroupBox();
			this.c162efdf2cfee9dcaab42750eaecc63aa = new RadCheckBox();
			this.c38e15f9793026f5c07a201f09952a0ac = new ToolWindow();
			this.cdedfb80afbadf1c14d75db35b86905a8 = new RadGroupBox();
			this.ce25356b1de1570ee1fe025c0f0fa0184 = new RadGroupBox();
			this.c87804958e268f3cb46688274d00bc3db = new RadButton();
			this.c35cb28ad4c137d6a5c2019389c2b9e68 = new RadLabel();
			this.c465fcdfe56a0a674011dbc560d792469 = new RadLabel();
			this.c915497b12593334e8fb5c8d1bfd58b57 = new RadLabel();
			this.c6ebb696cd62bce16aa5fc8555508c41b = new RadLabel();
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa = new RadLabel();
			this.ce0fe1e4b5ecdeb355970bf03e357723f = new RadLabel();
			this.c9f60413a79860ab64226aafde0051b03 = new RadLabel();
			this.c60e2ae96cffa51442fc8ac176e5d69f8 = new RadGroupBox();
			this.c026bf40f928f3d6dba737111fdffa7ed = new RadButton();
			this.cc8460cb9e09be1126c93cb8f02503f12 = new RadGroupBox();
			this.cd6742e70357ccb343e58ca4375bee4c3 = new RadButton();
			this.c5cedfdbf9e879295d762e0b02d960d33 = new ToolWindow();
			this.cf5b92d2f29e108857463d090ea17802d = new RadGroupBox();
			this.cd792ac67bdacd5b7947dd1479f77c2a6 = new RadButton();
			this.cda159acd49537066b3d75532496a4850 = new RadGroupBox();
			this.cc655eded9d507adf5a9405e457f9a40f = new RadButton();
			this.c1bd04ef35d363a76d3290f9f227223a5 = new ToolTabStrip();
			this.cc50c89ea5530ed17711416cbd3400578 = new ToolWindow();
			this.c1f9e38a0e4349cfdda72516b7373c3cd = new RadGroupBox();
			this.ceda6b294518e1db9b1aa8a671392c806 = new RadDock();
			this.cda319ea417b6d72e15e4f08944f4e8f2 = new ToolWindow();
			this.cb890309788bc92be17b6a235de6f886c = new RadButton();
			this.c9f93268106946d0f8f04d9f7de77339a = new RadButton();
			this.c03e15e05f6410711c2d29af150da73bc = new PictureBox();
			this.c9202010bbeb5a869433736d6d3edf68b = new RadTextBoxControl();
			this.c0e1873c97ed5c28183d8a02dcecefe22 = new PictureBox();
			this.ca094553b15c925802480db99005bd4f2 = new DocumentContainer();
			this.cffa2856f157615c723fc0174e0315a48 = new DocumentTabStrip();
			this.c007c0aae2cf1cee4a2629495a37dd783 = new ToolWindow();
			this.cdc574dc7748c88d6861d4bfabdc95272 = new RadGroupBox();
			this.cc9e45bbdf6ee9b81212ed24a210aab07 = new Label();
			this.ce2c7d9939c522d450f3df76cfe177c8f = new RadListView();
			this.cfcf06297d6af778ba0b09395fc2f7071 = new PictureBox();
			this.c0d57030f623a2ce3ac47f346eded8eb2 = new Label();
			this.c2578bdf3f76dc6df3ad590d55e5c99e8 = new Label();
			this.c9ee36b748e08e7ea591f948c93e868a5 = new RadListView();
			this.c4f35dae606400f2b70610e42660e5131 = new RadProgressBar();
			this.cc8daf5b987048692fcf54da7b699bd9c = new RadListView();
			this.c93a94181f2cea21a98fefb0ba7e8888b = new Label();
			this.ca43fdd1563fb00ad7902f923e2ce29db = new Label();
			this.c3191af20f951facba574896ab849a5b5 = new ToolWindow();
			this.cf79908ea7fb179e130decfd49ac2942e = new PictureBox();
			this.cbe7fa4761f85da94859280c8565879f4 = new PictureBox();
			this.cb4a1967318bc2f47a2a97d027e20d00f = new PictureBox();
			this.ce19c3ed732501121cc7e733f03a750f1 = new ToolWindow();
			this.c967e6f900acf8fed69dd58fc13e618c9 = new WebBrowser();
			this.ccdf1215dbbeff396ea40c3a50d46f8dc = new RadGroupBox();
			this.c3f8308a31f7480c02b875629e4488e2a = new RadButton();
			this.c99be52e02415fc82eaf415e375961a97 = new RadButton();
			this.c58e2356c3b19fdffdd0eecbb202437e5 = new ToolWindow();
			this.c81df6c6c9171f63a101b1da4f2500688 = new RadListView();
			this.c74635a9b2ff9984a78057f893291fc48 = new RadLabel();
			this.cf60098683d0bc0735fa1599dc81f52fc = new ToolWindow();
			this.cae387d07ee04501426ac62a7b81ce88f = new RadLabel();
			this.c11bba70fac0494286e0d3ef67e7108a8 = new RadButton();
			this.cb88959703fad6c1e125b370dc1b1d628 = new RadButton();
			this.ca6c1cea062503a0a580756cf1f1f0961 = new RadGroupBox();
			this.c973e711e4ba0b9bf06b636bdbabddad0 = new RadLabel();
			this.c8d2bc6d98c482abe32079c696410b384 = new RadLabel();
			this.c68fb0560502ff7bad26efa6cf163c845 = new RadLabel();
			this.c218e0ce0f7d843f536a409b942e4ca6d = new RadLabel();
			this.c8720232fcccea592194b8028025cef8b = new RadLabel();
			this.cb93ef748a37f709d32047aef13f1cb0a = new RadLabel();
			this.c874864d6030318b57d3af642035e90e5 = new RadLabel();
			this.c804e4fd2d6278fa319994b7cce512f68 = new RadLabel();
			this.c129f9645be9dc9fb646c5432e51db9a5 = new RadLabel();
			this.c362e39f066aef56acd25812b83e7da57 = new RadLabel();
			this.c98fc23ab6c8b6356924ad18312dd43db = new RadLabel();
			this.c204af998c7bd7e41658b068560e69a22 = new RadLabel();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c7897cd9c092dc3138c4daed47b35970b = new RadLabel();
			this.c47b614ac867932e76ad37c381b0fe8c6 = new RadLabel();
			this.c3b1862ccc73a74157a0aa2e808890118 = new RadLabel();
			this.ca6b7aa9283df8df606f49cc81dbca4d7 = new RadLabel();
			this.c381071419ced61a1622e530e0c8d1688 = new RadLabel();
			this.c15d9090b6a70d3a3c645fff30223e3a5 = new RadLabel();
			this.cb0d70167e184f5c28c15730dd468edc2 = new ToolTabStrip();
			this.c6c532de73864b060a67b00a40a009091 = new ToolWindow();
			this.c58dec0fd4ceda5728f3fb895644e1c63 = new RadPageView();
			this.cee9eb68f8e87aee9d3246553c1d77f82 = new RadPageViewPage();
			this.c079fc63031b6f053e2045ae7ae07e1b8 = new RadGroupBox();
			this.c894f9612229ef238e4f9c9e3ae42d770 = new RadPageViewPage();
			this.c47acf5fcb77b27cd38425547b69e3df9 = new RadGroupBox();
			this.c9543becb27e7606550f9caf5bdf6dd21 = new RadLabel();
			this.c792ef639cb88d2161a4888ab19e4d1f3 = new RadCheckBox();
			this.cf9531a8c30cdd17c740548976f7893c0 = new RadLabel();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c9386d302f4616a427d7ea57e8f99a6d9 = new RadGroupBox();
			this.c26a23c3f9ed64e91c418484270f55fcc = new RadLabel();
			this.c1bde3fed671b57fd27277d86860af4b4 = new RadRadialGauge();
			this.c5ee538c657dedc06e93850b6ffbbd1a8 = new RadialGaugeArc();
			this.c1aea5f84fd6633c457c8188e0a4cb66d = new RadialGaugeArc();
			this.c699a8df7a1718523a4d403193e720975 = new RadialGaugeLabels();
			this.ce9f9a0ea862f54052f446c5db845d608 = new RadialGaugeTicks();
			this.c916dbf43fc7aaf3f0148c42b0a7171f7 = new RadialGaugeSingleLabel();
			this.c3e55eccc22a105d650a95dea151c61b6 = new ToolTabStrip();
			this.c54d116beac1eab6bafbc29b67aa5a8c4 = new ToolTabStrip();
			this.c3c76741a19a037775bafe388a8df4e2c = new ToolWindow();
			this.c6731bd6914a59a695a058df2d9c821b2 = new RadPanel();
			this.c2178d80825cd9ab2c18a9dcd6884ee14 = new RadButton();
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7 = new RadButton();
			this.cecf676325d3b342f93a03b1b9170b253 = new RadButton();
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d = new RadButton();
			this.c44272853dcc0c97ee7511d3b33f129b2 = new RadButton();
			this.ce6b37312f4b81e855d0cdd0d77839251 = new ToolWindow();
			this.c05e314fec562b708421366d517bc1760 = new RadPanel();
			this.c9188c69fd7c8eaf15dce43ea16f40d88 = new RadButton();
			this.c8c4836eaf51bf51ad4029bcfa65e3070 = new RadButton();
			this.c024a788ba27b0be6afa45229820c2905 = new RadButton();
			this.c76617ddf050ef873ce43173d73fd39fb = new RadButton();
			this.cfac791f2ebab9d5414b01ffa03f31c07 = new RadButton();
			this.c0b3afb12bff80cf464a5e9a17f791e36 = new RadButton();
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78 = new ToolWindow();
			this.cbec87db2de27d1830a4fdb08e4b15303 = new RadPanel();
			this.c644e6368b8418e14b419ec82c299f737 = new RadButton();
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf = new RadButton();
			this.c4bc6833c750722a6e897796adbb7c79c = new RadButton();
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b = new RadButton();
			this.cbbbc92bbbc47247d382886e66cbe134e = new RadButton();
			this.cd454afeeb1c83386a9b8902a8439978e = new RadContextMenu(this.c66944218dc6924b147fbc6b0f72a424f);
			this.cb3dc29b65c72a11c969484cf0866c7be = new RadMenuItem();
			this.c7453b0e9791e5c45a84a845d8794227d = new RadMenuItem();
			this.cbb443da1d1aa99f7840f31f118e97f4f = new RadMenuItem();
			this.ca37fea2b0a0ec984ab56530130949795 = new RadMenuItem();
			this.c163902e6bdd8bcfb3dbca9008354fb43 = new RadMenuItem();
			this.c8fd7fc32e0c93a70bfee119de0883219 = new RadMenuItem();
			this.cff967d75cf03cf4d5c9b5233a561f33c = new RadMenuItem();
			this.cd111a8d957d26fad50953d63cca2d714 = new RadMenuItem();
			this.c5f880f9d0456e05bb289f7acd4a88315 = new RadMenuItem();
			this.ca3bf14633756b73f7289598debc2742c = new RadMenuItem();
			this.c95472e45e18203ec5db262009ed54799 = new RadMenuItem();
			this.cd90b4bdf15f292928e266702461954cd = new RadMenuItem();
			this.c140aadf765c4d07d6ee3fccbfde7124c = new System.Windows.Forms.Timer(this.c66944218dc6924b147fbc6b0f72a424f);
			this.cbd120a78c4a62a94400d69af3d3fc776 = new System.Windows.Forms.Timer(this.c66944218dc6924b147fbc6b0f72a424f);
			this.c803b89929a29613f5751f6463377a31b = new System.Windows.Forms.Timer(this.c66944218dc6924b147fbc6b0f72a424f);
			this.ce9e5aa178e2af36d04f863bccc94f85b = new RadLabel();
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.BeginInit();
			this.cf6348eb630c0b01e77b8f83ec7151d96.BeginInit();
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.BeginInit();
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.BeginInit();
			this.c15cfb8d25fc93dd1b55a4ea47493c187.BeginInit();
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.BeginInit();
			this.c06f4d49c4cd7969e514a4b3649e010c9.BeginInit();
			this.c9df3025f0563abbb25d17e41a7657e81.BeginInit();
			this.c9df3025f0563abbb25d17e41a7657e81.SuspendLayout();
			this.c5387a02757dbf6c1f7add91e8f83a37d.BeginInit();
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.BeginInit();
			this.c9cab24920274230a73629880e3d2f54d.BeginInit();
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.BeginInit();
			this.c15ef48f6d131106befa105251dceaed9.BeginInit();
			this.ce77148f56a941930515ae05ee4a8abba.BeginInit();
			this.c69103ed6bfb59dc17e3aed75cdbe979d.BeginInit();
			this.cef9cf59a04a9a091015a8a429a716577.BeginInit();
			this.c727375dbbb6f023ed693138c5ee33ab6.BeginInit();
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.BeginInit();
			this.c1afd523200a21e6b7132517361aba805.BeginInit();
			this.c1afd523200a21e6b7132517361aba805.SuspendLayout();
			this.c13964aec72502e7656b1ae19a819aff9.BeginInit();
			this.c271cb122814a1639c9b4c33232d68a4b.BeginInit();
			this.c73a9fa38c32073af376cb816c1f090ff.BeginInit();
			this.c7bab6db345839f9cf49d38f3cb6052bd.BeginInit();
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.BeginInit();
			this.c7cb15ecb80bee59937d269db8297ea4b.BeginInit();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.BeginInit();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.SuspendLayout();
			this.ceed5d76836a72a0a0356175e703e6aa6.BeginInit();
			this.cff69c812b578b7c94cbd35be243af026.BeginInit();
			this.c5de69d272cb033f108f47623f7fef008.BeginInit();
			this.c5de69d272cb033f108f47623f7fef008.SuspendLayout();
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.BeginInit();
			this.cb3f03a694ca97a057d1693262571d407.BeginInit();
			this.c96836d00d3b2ff6ba296617dd93ac7d1.BeginInit();
			this.cc88cf84905313ad542b0916fffeca13a.BeginInit();
			this.cc88cf84905313ad542b0916fffeca13a.SuspendLayout();
			this.c5ef121095a54af022617ead3cdccfecd.BeginInit();
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.BeginInit();
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.BeginInit();
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.SuspendLayout();
			this.c334cd5fa87833f636046cdbd48987d99.BeginInit();
			this.c70e980dd6de0ea664d1165b0bab9c505.BeginInit();
			this.ced92a8662e50218f546ae6bb0a312b4f.BeginInit();
			this.ced92a8662e50218f546ae6bb0a312b4f.SuspendLayout();
			this.cffa7e6b0340f88d9369da7a34ef65631.SuspendLayout();
			this.c3f17fb9a80a6565749e0532cfc37cf36.BeginInit();
			this.c7a3b11fb7f169020337311c6c740f967.BeginInit();
			this.cf5e6e788cc75cc8a2930ca14db8241d0.BeginInit();
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.BeginInit();
			this.cd09b52c3ae35fea01e57c925cb0b9ada.BeginInit();
			this.cd09b52c3ae35fea01e57c925cb0b9ada.SuspendLayout();
			this.c43ac0965f3c4dba40288724acda79152.BeginInit();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			this.c052ccf41a3ad1f787a00eeef2d674c87.BeginInit();
			this.ce101c2d73f85a684f9dce02f36f4b13d.BeginInit();
			this.ce101c2d73f85a684f9dce02f36f4b13d.SuspendLayout();
			this.cd9cc6282fcad129739eed0b12b013814.SuspendLayout();
			((ISupportInitialize)this.c6a2b595cc5d4feecae7d4d122a8f1dce).BeginInit();
			this.c822d3bd636ef45abd026eb08950f0fcc.BeginInit();
			this.c822d3bd636ef45abd026eb08950f0fcc.SuspendLayout();
			this.c3734340a6bb7f4279e55914719952804.BeginInit();
			this.c3734340a6bb7f4279e55914719952804.SuspendLayout();
			this.caab8d6cd57c54c842169d92d82ff1eb4.BeginInit();
			this.caab8d6cd57c54c842169d92d82ff1eb4.SuspendLayout();
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.SuspendLayout();
			this.c2cf916b4dc1582084d9fe6ddbeff235f.BeginInit();
			this.c2cf916b4dc1582084d9fe6ddbeff235f.SuspendLayout();
			this.c8839ab017cc506ca34b8277549d5d1bc.BeginInit();
			this.c5a37947f2bfc099265b4ef9252b00763.BeginInit();
			this.c5a37947f2bfc099265b4ef9252b00763.SuspendLayout();
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.BeginInit();
			this.c19ea03710ebcce9d9618141875fa6b4b.SuspendLayout();
			this.c0717e8606cc1780a278c591545ce83ab.BeginInit();
			this.c0717e8606cc1780a278c591545ce83ab.SuspendLayout();
			this.c379f097df981d80284e646aa1f74b28f.BeginInit();
			this.c0e7bde0280df56351440f1954d87e7a9.BeginInit();
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.BeginInit();
			this.c0ae86718cfb509f45e535dd79ebdeb1c.BeginInit();
			this.c0ae86718cfb509f45e535dd79ebdeb1c.SuspendLayout();
			this.ca4bbd9e42efba9cc6ffad5fab3161776.BeginInit();
			this.c693a1e47df92a82ced2b7ad96d5fae58.BeginInit();
			this.ca462c61c0669b9dd1d247bbdb465239d.BeginInit();
			this.c140ccd2b676242ee7992f31d621ad05b.BeginInit();
			this.c96d38c3849e994101ac7564a97ee637d.SuspendLayout();
			this.c959a761dc775e86d2402435397545a98.BeginInit();
			this.c959a761dc775e86d2402435397545a98.SuspendLayout();
			this.c127c6c3e1f77cb695a754ccf2106b43f.BeginInit();
			this.c771aaa5176d35a275b87f16a926f5c2f.BeginInit();
			this.c556ce890ae6cca856126c0a40a422ad2.BeginInit();
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.SuspendLayout();
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.BeginInit();
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.SuspendLayout();
			this.c30ff40a26c3b8d3f5b34356c58f244ee.BeginInit();
			this.cf070b8f366fa5e362b202a68723dd024.BeginInit();
			this.cf070b8f366fa5e362b202a68723dd024.SuspendLayout();
			this.c63371175f2a9c38a0ecc286c5d95503f.BeginInit();
			this.c7fbe090bab86fb6fbed0140fe13b50ac.BeginInit();
			this.c7fbe090bab86fb6fbed0140fe13b50ac.SuspendLayout();
			this.c85837e3848f514b3ef5efaee2f6dde4c.BeginInit();
			this.cd130fbdce9a854f33033b953b07b1d27.BeginInit();
			this.c42691c651c912f80ce2a6783758e6eeb.BeginInit();
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.BeginInit();
			this.c6f49ef988d94b37c11e87121dc8cf655.BeginInit();
			this.cb0cfae55913822d197dd756dceb3d6aa.BeginInit();
			this.cb5a0a2daffea489d9502568fc2558386.BeginInit();
			this.c7c0d0e61cda4b5dbf992885ec7aab275.BeginInit();
			this.ccc6197ad0cf795a9587c66570a9dfb79.BeginInit();
			this.cdf2e782b37313a443dabb661cd0cbf24.BeginInit();
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.SuspendLayout();
			this.c1d6115076623e59322dfdd1bdc07fa83.BeginInit();
			this.c1d6115076623e59322dfdd1bdc07fa83.SuspendLayout();
			this.c226f954145921ae178aa3238c5370176.BeginInit();
			this.c4e15dbb60549d511732b8608a9a1cf24.BeginInit();
			this.cf852cda1e32cfb76a067c73ed3f9a113.BeginInit();
			this.cf852cda1e32cfb76a067c73ed3f9a113.SuspendLayout();
			this.c7a7e4684ac13bfb11ce1a11695b1329c.BeginInit();
			this.c54df7c8ea1f37706a137b19cef6a157e.BeginInit();
			this.c54df7c8ea1f37706a137b19cef6a157e.SuspendLayout();
			this.c205802b28402610c81760457c1ed80d0.BeginInit();
			this.cf1ae3eee5cba489bc07bd471e11bf801.BeginInit();
			this.cf1ae3eee5cba489bc07bd471e11bf801.SuspendLayout();
			this.c162efdf2cfee9dcaab42750eaecc63aa.BeginInit();
			this.c38e15f9793026f5c07a201f09952a0ac.SuspendLayout();
			this.cdedfb80afbadf1c14d75db35b86905a8.BeginInit();
			this.cdedfb80afbadf1c14d75db35b86905a8.SuspendLayout();
			this.ce25356b1de1570ee1fe025c0f0fa0184.BeginInit();
			this.ce25356b1de1570ee1fe025c0f0fa0184.SuspendLayout();
			this.c87804958e268f3cb46688274d00bc3db.BeginInit();
			this.c35cb28ad4c137d6a5c2019389c2b9e68.BeginInit();
			this.c465fcdfe56a0a674011dbc560d792469.BeginInit();
			this.c915497b12593334e8fb5c8d1bfd58b57.BeginInit();
			this.c6ebb696cd62bce16aa5fc8555508c41b.BeginInit();
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa.BeginInit();
			this.ce0fe1e4b5ecdeb355970bf03e357723f.BeginInit();
			this.c9f60413a79860ab64226aafde0051b03.BeginInit();
			this.c60e2ae96cffa51442fc8ac176e5d69f8.BeginInit();
			this.c60e2ae96cffa51442fc8ac176e5d69f8.SuspendLayout();
			this.c026bf40f928f3d6dba737111fdffa7ed.BeginInit();
			this.cc8460cb9e09be1126c93cb8f02503f12.BeginInit();
			this.cc8460cb9e09be1126c93cb8f02503f12.SuspendLayout();
			this.cd6742e70357ccb343e58ca4375bee4c3.BeginInit();
			this.c5cedfdbf9e879295d762e0b02d960d33.SuspendLayout();
			this.cf5b92d2f29e108857463d090ea17802d.BeginInit();
			this.cf5b92d2f29e108857463d090ea17802d.SuspendLayout();
			this.cd792ac67bdacd5b7947dd1479f77c2a6.BeginInit();
			this.cda159acd49537066b3d75532496a4850.BeginInit();
			this.cda159acd49537066b3d75532496a4850.SuspendLayout();
			this.cc655eded9d507adf5a9405e457f9a40f.BeginInit();
			this.c1bd04ef35d363a76d3290f9f227223a5.BeginInit();
			this.c1bd04ef35d363a76d3290f9f227223a5.SuspendLayout();
			this.cc50c89ea5530ed17711416cbd3400578.SuspendLayout();
			this.c1f9e38a0e4349cfdda72516b7373c3cd.BeginInit();
			this.c1f9e38a0e4349cfdda72516b7373c3cd.SuspendLayout();
			this.ceda6b294518e1db9b1aa8a671392c806.BeginInit();
			this.ceda6b294518e1db9b1aa8a671392c806.SuspendLayout();
			this.cda319ea417b6d72e15e4f08944f4e8f2.SuspendLayout();
			this.cb890309788bc92be17b6a235de6f886c.BeginInit();
			this.c9f93268106946d0f8f04d9f7de77339a.BeginInit();
			((ISupportInitialize)this.c03e15e05f6410711c2d29af150da73bc).BeginInit();
			this.c9202010bbeb5a869433736d6d3edf68b.BeginInit();
			((ISupportInitialize)this.c0e1873c97ed5c28183d8a02dcecefe22).BeginInit();
			this.ca094553b15c925802480db99005bd4f2.BeginInit();
			this.ca094553b15c925802480db99005bd4f2.SuspendLayout();
			this.cffa2856f157615c723fc0174e0315a48.BeginInit();
			this.cffa2856f157615c723fc0174e0315a48.SuspendLayout();
			this.c007c0aae2cf1cee4a2629495a37dd783.SuspendLayout();
			this.cdc574dc7748c88d6861d4bfabdc95272.BeginInit();
			this.cdc574dc7748c88d6861d4bfabdc95272.SuspendLayout();
			this.ce2c7d9939c522d450f3df76cfe177c8f.BeginInit();
			((ISupportInitialize)this.cfcf06297d6af778ba0b09395fc2f7071).BeginInit();
			this.c9ee36b748e08e7ea591f948c93e868a5.BeginInit();
			this.c4f35dae606400f2b70610e42660e5131.BeginInit();
			this.cc8daf5b987048692fcf54da7b699bd9c.BeginInit();
			this.c3191af20f951facba574896ab849a5b5.SuspendLayout();
			((ISupportInitialize)this.cf79908ea7fb179e130decfd49ac2942e).BeginInit();
			((ISupportInitialize)this.cbe7fa4761f85da94859280c8565879f4).BeginInit();
			((ISupportInitialize)this.cb4a1967318bc2f47a2a97d027e20d00f).BeginInit();
			this.ce19c3ed732501121cc7e733f03a750f1.SuspendLayout();
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.BeginInit();
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.SuspendLayout();
			this.c3f8308a31f7480c02b875629e4488e2a.BeginInit();
			this.c99be52e02415fc82eaf415e375961a97.BeginInit();
			this.c58e2356c3b19fdffdd0eecbb202437e5.SuspendLayout();
			this.c81df6c6c9171f63a101b1da4f2500688.BeginInit();
			this.c81df6c6c9171f63a101b1da4f2500688.SuspendLayout();
			this.c74635a9b2ff9984a78057f893291fc48.BeginInit();
			this.cf60098683d0bc0735fa1599dc81f52fc.SuspendLayout();
			this.cae387d07ee04501426ac62a7b81ce88f.BeginInit();
			this.c11bba70fac0494286e0d3ef67e7108a8.BeginInit();
			this.cb88959703fad6c1e125b370dc1b1d628.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.SuspendLayout();
			this.c973e711e4ba0b9bf06b636bdbabddad0.BeginInit();
			this.c8d2bc6d98c482abe32079c696410b384.BeginInit();
			this.c68fb0560502ff7bad26efa6cf163c845.BeginInit();
			this.c218e0ce0f7d843f536a409b942e4ca6d.BeginInit();
			this.c8720232fcccea592194b8028025cef8b.BeginInit();
			this.cb93ef748a37f709d32047aef13f1cb0a.BeginInit();
			this.c874864d6030318b57d3af642035e90e5.BeginInit();
			this.c804e4fd2d6278fa319994b7cce512f68.BeginInit();
			this.c129f9645be9dc9fb646c5432e51db9a5.BeginInit();
			this.c362e39f066aef56acd25812b83e7da57.BeginInit();
			this.c98fc23ab6c8b6356924ad18312dd43db.BeginInit();
			this.c204af998c7bd7e41658b068560e69a22.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.c7897cd9c092dc3138c4daed47b35970b.BeginInit();
			this.c47b614ac867932e76ad37c381b0fe8c6.BeginInit();
			this.c3b1862ccc73a74157a0aa2e808890118.BeginInit();
			this.ca6b7aa9283df8df606f49cc81dbca4d7.BeginInit();
			this.c381071419ced61a1622e530e0c8d1688.BeginInit();
			this.c15d9090b6a70d3a3c645fff30223e3a5.BeginInit();
			this.cb0d70167e184f5c28c15730dd468edc2.BeginInit();
			this.cb0d70167e184f5c28c15730dd468edc2.SuspendLayout();
			this.c6c532de73864b060a67b00a40a009091.SuspendLayout();
			this.c58dec0fd4ceda5728f3fb895644e1c63.BeginInit();
			this.c58dec0fd4ceda5728f3fb895644e1c63.SuspendLayout();
			this.cee9eb68f8e87aee9d3246553c1d77f82.SuspendLayout();
			this.c079fc63031b6f053e2045ae7ae07e1b8.BeginInit();
			this.c079fc63031b6f053e2045ae7ae07e1b8.SuspendLayout();
			this.c894f9612229ef238e4f9c9e3ae42d770.SuspendLayout();
			this.c47acf5fcb77b27cd38425547b69e3df9.BeginInit();
			this.c47acf5fcb77b27cd38425547b69e3df9.SuspendLayout();
			this.c9543becb27e7606550f9caf5bdf6dd21.BeginInit();
			this.c792ef639cb88d2161a4888ab19e4d1f3.BeginInit();
			this.cf9531a8c30cdd17c740548976f7893c0.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			this.c9386d302f4616a427d7ea57e8f99a6d9.BeginInit();
			this.c9386d302f4616a427d7ea57e8f99a6d9.SuspendLayout();
			this.c26a23c3f9ed64e91c418484270f55fcc.BeginInit();
			this.c1bde3fed671b57fd27277d86860af4b4.BeginInit();
			this.c3e55eccc22a105d650a95dea151c61b6.BeginInit();
			this.c3e55eccc22a105d650a95dea151c61b6.SuspendLayout();
			this.c54d116beac1eab6bafbc29b67aa5a8c4.BeginInit();
			this.c54d116beac1eab6bafbc29b67aa5a8c4.SuspendLayout();
			this.c3c76741a19a037775bafe388a8df4e2c.SuspendLayout();
			this.c6731bd6914a59a695a058df2d9c821b2.BeginInit();
			this.c6731bd6914a59a695a058df2d9c821b2.SuspendLayout();
			this.c2178d80825cd9ab2c18a9dcd6884ee14.BeginInit();
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.BeginInit();
			this.cecf676325d3b342f93a03b1b9170b253.BeginInit();
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.BeginInit();
			this.c44272853dcc0c97ee7511d3b33f129b2.BeginInit();
			this.ce6b37312f4b81e855d0cdd0d77839251.SuspendLayout();
			this.c05e314fec562b708421366d517bc1760.BeginInit();
			this.c05e314fec562b708421366d517bc1760.SuspendLayout();
			this.c9188c69fd7c8eaf15dce43ea16f40d88.BeginInit();
			this.c8c4836eaf51bf51ad4029bcfa65e3070.BeginInit();
			this.c024a788ba27b0be6afa45229820c2905.BeginInit();
			this.c76617ddf050ef873ce43173d73fd39fb.BeginInit();
			this.cfac791f2ebab9d5414b01ffa03f31c07.BeginInit();
			this.c0b3afb12bff80cf464a5e9a17f791e36.BeginInit();
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.SuspendLayout();
			this.cbec87db2de27d1830a4fdb08e4b15303.BeginInit();
			this.cbec87db2de27d1830a4fdb08e4b15303.SuspendLayout();
			this.c644e6368b8418e14b419ec82c299f737.BeginInit();
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.BeginInit();
			this.c4bc6833c750722a6e897796adbb7c79c.BeginInit();
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.BeginInit();
			this.cbbbc92bbbc47247d382886e66cbe134e.BeginInit();
			this.ce9e5aa178e2af36d04f863bccc94f85b.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.cf8cb420d295db38024b73fbf777f57ea.AutoHideSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21436), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21440));
			this.cf8cb420d295db38024b73fbf777f57ea.DockWindowName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83315);
			this.cf8cb420d295db38024b73fbf777f57ea.DockWindowText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83340);
			this.cf8cb420d295db38024b73fbf777f57ea.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21444));
			this.cf8cb420d295db38024b73fbf777f57ea.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21448), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21452));
			this.cf8cb420d295db38024b73fbf777f57ea.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83373);
			this.cf8cb420d295db38024b73fbf777f57ea.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21456);
			this.cf8cb420d295db38024b73fbf777f57ea.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21460), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21464));
			this.cf8cb420d295db38024b73fbf777f57ea.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83373);
			this.cba695b1387526cc2dbaf8bc082358792.AutoHideSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21468), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21472));
			this.cba695b1387526cc2dbaf8bc082358792.DockWindowName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83418);
			this.cba695b1387526cc2dbaf8bc082358792.DockWindowText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83435);
			this.cba695b1387526cc2dbaf8bc082358792.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21476));
			this.cba695b1387526cc2dbaf8bc082358792.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21480), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21484));
			this.cba695b1387526cc2dbaf8bc082358792.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83456);
			this.cba695b1387526cc2dbaf8bc082358792.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21488);
			this.cba695b1387526cc2dbaf8bc082358792.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21492), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21496));
			this.cba695b1387526cc2dbaf8bc082358792.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83456);
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21500);
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21504), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21508));
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.MinimumSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21512), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21516));
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83501);
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.NullText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83524);
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21520), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21524));
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21532));
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21536);
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.TextChanged += this.c6934eb62b1aa43c73cec1b8e11879613;
			this.cf6348eb630c0b01e77b8f83ec7151d96.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21540) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21544) != 0);
			listViewDetailColumn.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45454);
			listViewDetailColumn.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21548);
			listViewDetailColumn2.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46477);
			listViewDetailColumn2.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21552);
			listViewDetailColumn3.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45445);
			listViewDetailColumn3.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21556);
			listViewDetailColumn4.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83260);
			listViewDetailColumn4.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21560);
			listViewDetailColumn5.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48113);
			listViewDetailColumn5.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21564);
			listViewDetailColumn6.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48151);
			listViewDetailColumn6.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21568);
			ListViewColumnCollection columns = this.cf6348eb630c0b01e77b8f83ec7151d96.Columns;
			ListViewDetailColumn[] array = c6188cbae417ac84374cf19bfcad5d59b.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21572));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21576)] = listViewDetailColumn;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21580)] = listViewDetailColumn2;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21584)] = listViewDetailColumn3;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21588)] = listViewDetailColumn4;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21592)] = listViewDetailColumn5;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21596)] = listViewDetailColumn6;
			columns.AddRange(array);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21600);
			this.cf6348eb630c0b01e77b8f83ec7151d96.EnableColumnSort = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21604) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.EnableSorting = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21608) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21612));
			this.cf6348eb630c0b01e77b8f83ec7151d96.FullRowSelect = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21616) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.ItemSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21620), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21624));
			this.cf6348eb630c0b01e77b8f83ec7151d96.KeyboardSearchEnabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21628) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21632), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21636));
			this.cf6348eb630c0b01e77b8f83ec7151d96.MultiSelect = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21640) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83543);
			this.cf6348eb630c0b01e77b8f83ec7151d96.SelectLastAddedItem = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21644) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.ShowGroups = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21648) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21652), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21656));
			this.cf6348eb630c0b01e77b8f83ec7151d96.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21660);
			this.cf6348eb630c0b01e77b8f83ec7151d96.UseCompatibleTextRendering = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21664) != 0);
			this.cf6348eb630c0b01e77b8f83ec7151d96.ViewType = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21668);
			this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItemChanged += this.c3e04b8d1c785f8020038f4f6d843443b;
			this.cf6348eb630c0b01e77b8f83ec7151d96.ItemMouseUp += new ListViewItemMouseEventHandler(this.c06f881e6ffa3b5413e6973e52b65e084);
			this.cf6348eb630c0b01e77b8f83ec7151d96.SizeChanged += this.c1127135e52b49dbb1176673ee95a02d2;
			this.cf6348eb630c0b01e77b8f83ec7151d96.KeyUp += this.ce7e09133ebcea2d89b7e0bb84c9c6418;
			this.c55dae0c1480836020900dbf1801fc283.FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83560);
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21672);
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21676), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21680));
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47387);
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21684), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21688));
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21692);
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83577);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.AllowColumnReorder = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21696) != 0);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.AllowColumnResize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21700) != 0);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21704) != 0);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21708) != 0);
			listViewDetailColumn7.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51927);
			listViewDetailColumn7.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21712);
			ListViewColumnCollection columns2 = this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Columns;
			ListViewDetailColumn[] array2 = c6188cbae417ac84374cf19bfcad5d59b.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21716));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21720)] = listViewDetailColumn7;
			columns2.AddRange(array2);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21724);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(21728));
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.ItemSpacing = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21732);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21736), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21740));
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83654);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.ShowColumnHeaders = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21744) != 0);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21748), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21752));
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21756);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.ViewType = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21760);
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.ItemMouseDoubleClick += new ListViewItemEventHandler(this.c60f180121f06f6ac5b243f9dffce2925);
			this.c15cfb8d25fc93dd1b55a4ea47493c187.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21764);
			this.c15cfb8d25fc93dd1b55a4ea47493c187.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21768), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21772));
			this.c15cfb8d25fc93dd1b55a4ea47493c187.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83669);
			this.c15cfb8d25fc93dd1b55a4ea47493c187.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21776), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21780));
			this.c15cfb8d25fc93dd1b55a4ea47493c187.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21784);
			this.c15cfb8d25fc93dd1b55a4ea47493c187.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83694);
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21788);
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21792), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21796));
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83733);
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21800), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21804));
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21808);
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83754);
			this.c06f4d49c4cd7969e514a4b3649e010c9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21812);
			this.c06f4d49c4cd7969e514a4b3649e010c9.ForeColor = Color.Green;
			this.c06f4d49c4cd7969e514a4b3649e010c9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21816), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21820));
			this.c06f4d49c4cd7969e514a4b3649e010c9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83763);
			this.c06f4d49c4cd7969e514a4b3649e010c9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21824), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21828));
			this.c06f4d49c4cd7969e514a4b3649e010c9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21832);
			this.c06f4d49c4cd7969e514a4b3649e010c9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83780);
			this.c9df3025f0563abbb25d17e41a7657e81.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21836);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c5387a02757dbf6c1f7add91e8f83a37d);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c49e0e1006d938106f4f6b78dc1a9fbe9);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c46742982780fe1e9a0b84ddd2570741b);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c9cab24920274230a73629880e3d2f54d);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c3e2b0edd5c4db8fcb6c60a419bd93842);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c15ef48f6d131106befa105251dceaed9);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.ce77148f56a941930515ae05ee4a8abba);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c69103ed6bfb59dc17e3aed75cdbe979d);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.cef9cf59a04a9a091015a8a429a716577);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c727375dbbb6f023ed693138c5ee33ab6);
			this.c9df3025f0563abbb25d17e41a7657e81.Controls.Add(this.c99bd3ea85b6a1aa87f929de1fca32ff1);
			this.c9df3025f0563abbb25d17e41a7657e81.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21840);
			this.c9df3025f0563abbb25d17e41a7657e81.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83815);
			this.c9df3025f0563abbb25d17e41a7657e81.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21844), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21848));
			this.c9df3025f0563abbb25d17e41a7657e81.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83900);
			this.c9df3025f0563abbb25d17e41a7657e81.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21852), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21856));
			this.c9df3025f0563abbb25d17e41a7657e81.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21860);
			this.c9df3025f0563abbb25d17e41a7657e81.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83815);
			this.c5387a02757dbf6c1f7add91e8f83a37d.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21864);
			this.c5387a02757dbf6c1f7add91e8f83a37d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21868), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21872));
			this.c5387a02757dbf6c1f7add91e8f83a37d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83925);
			this.c5387a02757dbf6c1f7add91e8f83a37d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21876), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21880));
			this.c5387a02757dbf6c1f7add91e8f83a37d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21884);
			this.c5387a02757dbf6c1f7add91e8f83a37d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83964);
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21888);
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21892), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21896));
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83999);
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21900), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21904));
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21908);
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84014);
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.ToggleStateChanging += new StateChangingEventHandler(this.c73c22814d7fa1fd851612f41479c894d);
			this.c46742982780fe1e9a0b84ddd2570741b.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21912);
			this.c46742982780fe1e9a0b84ddd2570741b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21916), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21920));
			this.c46742982780fe1e9a0b84ddd2570741b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84037);
			this.c46742982780fe1e9a0b84ddd2570741b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21924), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21928));
			this.c46742982780fe1e9a0b84ddd2570741b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21932);
			this.c9cab24920274230a73629880e3d2f54d.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21936);
			this.c9cab24920274230a73629880e3d2f54d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21940), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21944));
			this.c9cab24920274230a73629880e3d2f54d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84052);
			this.c9cab24920274230a73629880e3d2f54d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21948), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21952));
			this.c9cab24920274230a73629880e3d2f54d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21956);
			this.c9cab24920274230a73629880e3d2f54d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43643);
			this.c9cab24920274230a73629880e3d2f54d.Click += this.c131392ec9dca3467407275cf845d6393;
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21960);
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21964), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21968));
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84079);
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21972), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21976));
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21980);
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c15ef48f6d131106befa105251dceaed9.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21984);
			this.c15ef48f6d131106befa105251dceaed9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21988), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21992));
			this.c15ef48f6d131106befa105251dceaed9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84102);
			this.c15ef48f6d131106befa105251dceaed9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(21996), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22000));
			this.c15ef48f6d131106befa105251dceaed9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22004);
			this.c15ef48f6d131106befa105251dceaed9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84121);
			this.c15ef48f6d131106befa105251dceaed9.ToggleStateChanging += new StateChangingEventHandler(this.c603848762fc7eb0fcf8f3f3d277c3617);
			this.ce77148f56a941930515ae05ee4a8abba.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22008);
			this.ce77148f56a941930515ae05ee4a8abba.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22012), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22016));
			this.ce77148f56a941930515ae05ee4a8abba.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84134);
			this.ce77148f56a941930515ae05ee4a8abba.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22024));
			this.ce77148f56a941930515ae05ee4a8abba.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22028);
			this.ce77148f56a941930515ae05ee4a8abba.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84157);
			this.ce77148f56a941930515ae05ee4a8abba.ToggleStateChanged += new StateChangedEventHandler(this.c378715701ee8260c9bb7219736966809);
			this.c69103ed6bfb59dc17e3aed75cdbe979d.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22032);
			this.c69103ed6bfb59dc17e3aed75cdbe979d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22036), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22040));
			this.c69103ed6bfb59dc17e3aed75cdbe979d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84178);
			this.c69103ed6bfb59dc17e3aed75cdbe979d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22044), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22048));
			this.c69103ed6bfb59dc17e3aed75cdbe979d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22052);
			this.c69103ed6bfb59dc17e3aed75cdbe979d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84195);
			this.c69103ed6bfb59dc17e3aed75cdbe979d.ToggleStateChanged += new StateChangedEventHandler(this.c20c8eaf0b59e2d6201e982fd1850c5a2);
			this.cef9cf59a04a9a091015a8a429a716577.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22056);
			this.cef9cf59a04a9a091015a8a429a716577.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22064));
			this.cef9cf59a04a9a091015a8a429a716577.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84206);
			this.cef9cf59a04a9a091015a8a429a716577.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22072));
			this.cef9cf59a04a9a091015a8a429a716577.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22076);
			this.cef9cf59a04a9a091015a8a429a716577.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84229);
			this.cef9cf59a04a9a091015a8a429a716577.ToggleStateChanged += new StateChangedEventHandler(this.ce1e40100ea973724c526522d5aefb3f5);
			this.c727375dbbb6f023ed693138c5ee33ab6.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22080);
			this.c727375dbbb6f023ed693138c5ee33ab6.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22088));
			this.c727375dbbb6f023ed693138c5ee33ab6.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84248);
			this.c727375dbbb6f023ed693138c5ee33ab6.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22096));
			this.c727375dbbb6f023ed693138c5ee33ab6.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22100);
			this.c727375dbbb6f023ed693138c5ee33ab6.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84265);
			this.c727375dbbb6f023ed693138c5ee33ab6.ToggleStateChanged += new StateChangedEventHandler(this.ce0e5fd9cc8060ae197f8ae35c41dfcd9);
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22104);
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22108), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22112));
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84290);
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22116), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22120));
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22124);
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84315);
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.ToggleStateChanged += new StateChangedEventHandler(this.c60e4ed149dee2755b668382a3e3ca5e6);
			this.c1afd523200a21e6b7132517361aba805.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22128);
			this.c1afd523200a21e6b7132517361aba805.Controls.Add(this.c13964aec72502e7656b1ae19a819aff9);
			this.c1afd523200a21e6b7132517361aba805.Controls.Add(this.c271cb122814a1639c9b4c33232d68a4b);
			this.c1afd523200a21e6b7132517361aba805.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22132);
			this.c1afd523200a21e6b7132517361aba805.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84334);
			this.c1afd523200a21e6b7132517361aba805.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22136), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22140));
			this.c1afd523200a21e6b7132517361aba805.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84353);
			this.c1afd523200a21e6b7132517361aba805.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22144));
			this.c1afd523200a21e6b7132517361aba805.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22148), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22152));
			this.c1afd523200a21e6b7132517361aba805.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22156);
			this.c1afd523200a21e6b7132517361aba805.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84334);
			this.c13964aec72502e7656b1ae19a819aff9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22160);
			this.c13964aec72502e7656b1ae19a819aff9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22164), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22168));
			this.c13964aec72502e7656b1ae19a819aff9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84382);
			this.c13964aec72502e7656b1ae19a819aff9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22172), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22176));
			this.c13964aec72502e7656b1ae19a819aff9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22180);
			this.c13964aec72502e7656b1ae19a819aff9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84405);
			this.c271cb122814a1639c9b4c33232d68a4b.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22184);
			this.c271cb122814a1639c9b4c33232d68a4b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22188), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22192));
			this.c271cb122814a1639c9b4c33232d68a4b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84434);
			this.c271cb122814a1639c9b4c33232d68a4b.ShowProgressIndicators = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22196) != 0);
			this.c271cb122814a1639c9b4c33232d68a4b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22200), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22204));
			this.c271cb122814a1639c9b4c33232d68a4b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22208);
			this.c271cb122814a1639c9b4c33232d68a4b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43636);
			this.c73a9fa38c32073af376cb816c1f090ff.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22212);
			this.c73a9fa38c32073af376cb816c1f090ff.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22216), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22220));
			this.c73a9fa38c32073af376cb816c1f090ff.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84461);
			this.c73a9fa38c32073af376cb816c1f090ff.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22224), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22228));
			this.c73a9fa38c32073af376cb816c1f090ff.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22232);
			this.c73a9fa38c32073af376cb816c1f090ff.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84480);
			this.c7bab6db345839f9cf49d38f3cb6052bd.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22236);
			this.c7bab6db345839f9cf49d38f3cb6052bd.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22240), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22244));
			RadSpinEditor radSpinEditor = this.c7bab6db345839f9cf49d38f3cb6052bd;
			int[] array3 = caf27e0a24607a2eca61ed1ed85da5ae6.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22248));
			array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22252)] = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22256);
			radSpinEditor.Maximum = new decimal(array3);
			this.c7bab6db345839f9cf49d38f3cb6052bd.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84515);
			this.c7bab6db345839f9cf49d38f3cb6052bd.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22260), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22264));
			this.c7bab6db345839f9cf49d38f3cb6052bd.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22268);
			this.c7bab6db345839f9cf49d38f3cb6052bd.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22272) != 0);
			this.c7bab6db345839f9cf49d38f3cb6052bd.ValueChanged += this.c937ea4c031b5753b3e08428dc02f5cea;
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22276);
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22280), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22284));
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84538);
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22288), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22292));
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22296);
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84561);
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.Click += this.c9dd7b0ce008201ebbbde1a6f5efce8b2;
			this.c7cb15ecb80bee59937d269db8297ea4b.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22300);
			this.c7cb15ecb80bee59937d269db8297ea4b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22308));
			this.c7cb15ecb80bee59937d269db8297ea4b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84574);
			this.c7cb15ecb80bee59937d269db8297ea4b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22316));
			this.c7cb15ecb80bee59937d269db8297ea4b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22320);
			this.c7cb15ecb80bee59937d269db8297ea4b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22324);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22328) != 0);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.ceed5d76836a72a0a0356175e703e6aa6);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.cff69c812b578b7c94cbd35be243af026);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.c5de69d272cb033f108f47623f7fef008);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.cc7cfe1f97976a18c5fdb3961a2e14b9b);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Controls.Add(this.cb3f03a694ca97a057d1693262571d407);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22332);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84587);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22336), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22340));
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48158);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22344), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22348));
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22352);
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84587);
			this.ceed5d76836a72a0a0356175e703e6aa6.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49994);
			this.ceed5d76836a72a0a0356175e703e6aa6.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22356);
			this.ceed5d76836a72a0a0356175e703e6aa6.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22360);
			this.ceed5d76836a72a0a0356175e703e6aa6.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22364) != 0);
			this.ceed5d76836a72a0a0356175e703e6aa6.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84602)));
			this.ceed5d76836a72a0a0356175e703e6aa6.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22368), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22372));
			this.ceed5d76836a72a0a0356175e703e6aa6.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84633);
			this.ceed5d76836a72a0a0356175e703e6aa6.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22376));
			this.ceed5d76836a72a0a0356175e703e6aa6.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22380), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22384));
			this.ceed5d76836a72a0a0356175e703e6aa6.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22388);
			this.ceed5d76836a72a0a0356175e703e6aa6.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84652);
			this.ceed5d76836a72a0a0356175e703e6aa6.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22392);
			this.ceed5d76836a72a0a0356175e703e6aa6.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22396);
			this.ceed5d76836a72a0a0356175e703e6aa6.Click += this.c88c83bbde198c9e9c5f166fe5128ead0;
			this.cff69c812b578b7c94cbd35be243af026.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84667);
			this.cff69c812b578b7c94cbd35be243af026.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22400);
			this.cff69c812b578b7c94cbd35be243af026.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22404);
			this.cff69c812b578b7c94cbd35be243af026.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22408) != 0);
			this.cff69c812b578b7c94cbd35be243af026.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84688)));
			this.cff69c812b578b7c94cbd35be243af026.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22412), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22416));
			this.cff69c812b578b7c94cbd35be243af026.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84715);
			this.cff69c812b578b7c94cbd35be243af026.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22420));
			this.cff69c812b578b7c94cbd35be243af026.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22424), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22428));
			this.cff69c812b578b7c94cbd35be243af026.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22432);
			this.cff69c812b578b7c94cbd35be243af026.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84730);
			this.cff69c812b578b7c94cbd35be243af026.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22436);
			this.cff69c812b578b7c94cbd35be243af026.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22440);
			this.cff69c812b578b7c94cbd35be243af026.Click += this.c59daad4d0d489ca640da8a9dcab54037;
			this.c5de69d272cb033f108f47623f7fef008.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84753);
			this.c5de69d272cb033f108f47623f7fef008.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22444);
			this.c5de69d272cb033f108f47623f7fef008.Controls.Add(this.cd6793e893e7cbd3d9a5d7b2a95ad24eb);
			this.c5de69d272cb033f108f47623f7fef008.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22448);
			this.c5de69d272cb033f108f47623f7fef008.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22452) != 0);
			this.c5de69d272cb033f108f47623f7fef008.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84768)));
			this.c5de69d272cb033f108f47623f7fef008.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22456), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22460));
			this.c5de69d272cb033f108f47623f7fef008.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84799);
			this.c5de69d272cb033f108f47623f7fef008.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22464));
			this.c5de69d272cb033f108f47623f7fef008.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22468), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22472));
			this.c5de69d272cb033f108f47623f7fef008.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22476);
			this.c5de69d272cb033f108f47623f7fef008.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83127);
			this.c5de69d272cb033f108f47623f7fef008.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22480);
			this.c5de69d272cb033f108f47623f7fef008.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22484);
			this.c5de69d272cb033f108f47623f7fef008.Click += this.c56cc0c5c480212a401c0bc17afce6898;
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22488) != 0);
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.BackColor = Color.Transparent;
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.ForeColor = Color.Red;
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22492), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22496));
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84818);
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22504));
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22508);
			this.cd6793e893e7cbd3d9a5d7b2a95ad24eb.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84831);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84850);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22512);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22516);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22520) != 0);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84871)));
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22524), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22528));
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84908);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22532));
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22536), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22540));
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22544);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83065);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22548);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22552);
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.Click += this.ccf2b1010cea1c8156ca5b89f27cc2943;
			this.cb3f03a694ca97a057d1693262571d407.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84933);
			this.cb3f03a694ca97a057d1693262571d407.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22556);
			this.cb3f03a694ca97a057d1693262571d407.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22560);
			this.cb3f03a694ca97a057d1693262571d407.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22564) != 0);
			this.cb3f03a694ca97a057d1693262571d407.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84942)));
			this.cb3f03a694ca97a057d1693262571d407.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22568), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22572));
			this.cb3f03a694ca97a057d1693262571d407.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84975);
			this.cb3f03a694ca97a057d1693262571d407.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22576));
			this.cb3f03a694ca97a057d1693262571d407.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22580), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22584));
			this.cb3f03a694ca97a057d1693262571d407.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22588);
			this.cb3f03a694ca97a057d1693262571d407.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83036);
			this.cb3f03a694ca97a057d1693262571d407.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22592);
			this.cb3f03a694ca97a057d1693262571d407.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22596);
			this.cb3f03a694ca97a057d1693262571d407.Click += this.cdaad2ea6d47c15cad7ec0b16bc936799;
			this.c96836d00d3b2ff6ba296617dd93ac7d1.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22600) != 0);
			this.c96836d00d3b2ff6ba296617dd93ac7d1.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22604);
			this.c96836d00d3b2ff6ba296617dd93ac7d1.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(22608));
			this.c96836d00d3b2ff6ba296617dd93ac7d1.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22612), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22616));
			this.c96836d00d3b2ff6ba296617dd93ac7d1.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84996);
			this.c96836d00d3b2ff6ba296617dd93ac7d1.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22620), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22624));
			this.c96836d00d3b2ff6ba296617dd93ac7d1.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22628);
			this.c96836d00d3b2ff6ba296617dd93ac7d1.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85013);
			this.c96836d00d3b2ff6ba296617dd93ac7d1.UseMnemonic = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22632) != 0);
			this.cc88cf84905313ad542b0916fffeca13a.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22636);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c5ef121095a54af022617ead3cdccfecd);
			this.cc88cf84905313ad542b0916fffeca13a.Controls.Add(this.c5c0da2c4ace7b32f1e7344aa4557ff66);
			this.cc88cf84905313ad542b0916fffeca13a.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22640);
			this.cc88cf84905313ad542b0916fffeca13a.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85018);
			this.cc88cf84905313ad542b0916fffeca13a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22644), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22648));
			this.cc88cf84905313ad542b0916fffeca13a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48126);
			this.cc88cf84905313ad542b0916fffeca13a.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22652));
			this.cc88cf84905313ad542b0916fffeca13a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22656), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22660));
			this.cc88cf84905313ad542b0916fffeca13a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22664);
			this.cc88cf84905313ad542b0916fffeca13a.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85018);
			this.c5ef121095a54af022617ead3cdccfecd.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22668);
			this.c5ef121095a54af022617ead3cdccfecd.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22672), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22676));
			this.c5ef121095a54af022617ead3cdccfecd.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85043);
			this.c5ef121095a54af022617ead3cdccfecd.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22680), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22684));
			this.c5ef121095a54af022617ead3cdccfecd.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22688);
			this.c5ef121095a54af022617ead3cdccfecd.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84405);
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22692);
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22696), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22700));
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85064);
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.ShowProgressIndicators = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22704) != 0);
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22708), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22712));
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22716);
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43636);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22720);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Controls.Add(this.c334cd5fa87833f636046cdbd48987d99);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Controls.Add(this.c70e980dd6de0ea664d1165b0bab9c505);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22724);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85077);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22728), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22732));
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85102);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22736));
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22740), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22744));
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22748);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85077);
			this.c334cd5fa87833f636046cdbd48987d99.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22752);
			this.c334cd5fa87833f636046cdbd48987d99.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22756), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22760));
			this.c334cd5fa87833f636046cdbd48987d99.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43680);
			this.c334cd5fa87833f636046cdbd48987d99.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22764), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22768));
			this.c334cd5fa87833f636046cdbd48987d99.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22772);
			this.c334cd5fa87833f636046cdbd48987d99.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84405);
			this.c70e980dd6de0ea664d1165b0bab9c505.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22776);
			this.c70e980dd6de0ea664d1165b0bab9c505.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22784));
			this.c70e980dd6de0ea664d1165b0bab9c505.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85139);
			this.c70e980dd6de0ea664d1165b0bab9c505.ShowProgressIndicators = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22788) != 0);
			this.c70e980dd6de0ea664d1165b0bab9c505.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22792), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22796));
			this.c70e980dd6de0ea664d1165b0bab9c505.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22800);
			this.c70e980dd6de0ea664d1165b0bab9c505.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43636);
			this.ced92a8662e50218f546ae6bb0a312b4f.ActiveWindow = this.cffa7e6b0340f88d9369da7a34ef65631;
			this.ced92a8662e50218f546ae6bb0a312b4f.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22804) != 0);
			this.ced92a8662e50218f546ae6bb0a312b4f.Controls.Add(this.ce101c2d73f85a684f9dce02f36f4b13d);
			this.ced92a8662e50218f546ae6bb0a312b4f.Controls.Add(this.c822d3bd636ef45abd026eb08950f0fcc);
			this.ced92a8662e50218f546ae6bb0a312b4f.Controls.Add(this.c54d116beac1eab6bafbc29b67aa5a8c4);
			this.ced92a8662e50218f546ae6bb0a312b4f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22808);
			this.ced92a8662e50218f546ae6bb0a312b4f.IsCleanUpTarget = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22812) != 0);
			this.ced92a8662e50218f546ae6bb0a312b4f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22816), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22820));
			this.ced92a8662e50218f546ae6bb0a312b4f.MainDocumentContainer = this.c3734340a6bb7f4279e55914719952804;
			this.ced92a8662e50218f546ae6bb0a312b4f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85176);
			this.ced92a8662e50218f546ae6bb0a312b4f.Orientation = (Orientation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22824);
			this.ced92a8662e50218f546ae6bb0a312b4f.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22828), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22832));
			autoHideGroup.Windows.Add(this.cf8cb420d295db38024b73fbf777f57ea);
			autoHideGroup2.Windows.Add(this.cba695b1387526cc2dbaf8bc082358792);
			this.ced92a8662e50218f546ae6bb0a312b4f.SerializableAutoHideContainer.RightAutoHideGroups.Add(autoHideGroup);
			this.ced92a8662e50218f546ae6bb0a312b4f.SerializableAutoHideContainer.RightAutoHideGroups.Add(autoHideGroup2);
			this.ced92a8662e50218f546ae6bb0a312b4f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22836), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22840));
			this.ced92a8662e50218f546ae6bb0a312b4f.SplitterWidth = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22844);
			this.ced92a8662e50218f546ae6bb0a312b4f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22848);
			this.ced92a8662e50218f546ae6bb0a312b4f.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22852) != 0);
			this.ced92a8662e50218f546ae6bb0a312b4f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85193);
			this.cffa7e6b0340f88d9369da7a34ef65631.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.cffa7e6b0340f88d9369da7a34ef65631.Controls.Add(this.c3f17fb9a80a6565749e0532cfc37cf36);
			this.cffa7e6b0340f88d9369da7a34ef65631.Controls.Add(this.c7a3b11fb7f169020337311c6c740f967);
			this.cffa7e6b0340f88d9369da7a34ef65631.Controls.Add(this.cf5e6e788cc75cc8a2930ca14db8241d0);
			this.cffa7e6b0340f88d9369da7a34ef65631.Controls.Add(this.cf0b8ec03421b7b69f3c98a253e0ccdb0);
			this.cffa7e6b0340f88d9369da7a34ef65631.Controls.Add(this.cd09b52c3ae35fea01e57c925cb0b9ada);
			this.cffa7e6b0340f88d9369da7a34ef65631.Controls.Add(this.c052ccf41a3ad1f787a00eeef2d674c87);
			this.cffa7e6b0340f88d9369da7a34ef65631.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22856);
			this.cffa7e6b0340f88d9369da7a34ef65631.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(22860));
			this.cffa7e6b0340f88d9369da7a34ef65631.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22864), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22868));
			this.cffa7e6b0340f88d9369da7a34ef65631.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83418);
			this.cffa7e6b0340f88d9369da7a34ef65631.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22872);
			this.cffa7e6b0340f88d9369da7a34ef65631.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22876), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22880));
			this.cffa7e6b0340f88d9369da7a34ef65631.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83435);
			this.cffa7e6b0340f88d9369da7a34ef65631.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22884);
			this.c3f17fb9a80a6565749e0532cfc37cf36.AllowColumnReorder = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22888) != 0);
			this.c3f17fb9a80a6565749e0532cfc37cf36.AllowColumnResize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22892) != 0);
			this.c3f17fb9a80a6565749e0532cfc37cf36.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22896) != 0);
			this.c3f17fb9a80a6565749e0532cfc37cf36.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22900) != 0);
			this.c3f17fb9a80a6565749e0532cfc37cf36.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22904);
			this.c3f17fb9a80a6565749e0532cfc37cf36.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(22908));
			this.c3f17fb9a80a6565749e0532cfc37cf36.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22912), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22916));
			this.c3f17fb9a80a6565749e0532cfc37cf36.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85210);
			this.c3f17fb9a80a6565749e0532cfc37cf36.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22920), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22924));
			this.c3f17fb9a80a6565749e0532cfc37cf36.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22928);
			this.c3f17fb9a80a6565749e0532cfc37cf36.ItemMouseDoubleClick += new ListViewItemEventHandler(this.c0b694a0c76e196ff0cc0ea126d5d2132);
			this.c7a3b11fb7f169020337311c6c740f967.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22932);
			this.c7a3b11fb7f169020337311c6c740f967.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22940));
			this.c7a3b11fb7f169020337311c6c740f967.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85225);
			this.c7a3b11fb7f169020337311c6c740f967.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22944), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22948));
			this.c7a3b11fb7f169020337311c6c740f967.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22952);
			this.c7a3b11fb7f169020337311c6c740f967.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85248);
			this.c7a3b11fb7f169020337311c6c740f967.Click += this.c598b5676f6823cf69a247e0d3e806397;
			this.cf5e6e788cc75cc8a2930ca14db8241d0.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22956);
			this.cf5e6e788cc75cc8a2930ca14db8241d0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22960), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22964));
			this.cf5e6e788cc75cc8a2930ca14db8241d0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85273);
			this.cf5e6e788cc75cc8a2930ca14db8241d0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22968), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22972));
			this.cf5e6e788cc75cc8a2930ca14db8241d0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22976);
			this.cf5e6e788cc75cc8a2930ca14db8241d0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85308);
			this.cf5e6e788cc75cc8a2930ca14db8241d0.Click += this.ccfd66d8bba9699c3973c18405427396f;
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22980);
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22984), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22988));
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85397);
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22992), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(22996));
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23000);
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84667);
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.Click += this.cf09ccc59960d259ede0f18187b1fdb6d;
			this.cd09b52c3ae35fea01e57c925cb0b9ada.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23004);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Controls.Add(this.c43ac0965f3c4dba40288724acda79152);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23008);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23012), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23016));
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85428);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23024));
			this.cd09b52c3ae35fea01e57c925cb0b9ada.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23028);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.c43ac0965f3c4dba40288724acda79152.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23032);
			this.c43ac0965f3c4dba40288724acda79152.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23036), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23040));
			this.c43ac0965f3c4dba40288724acda79152.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85455);
			this.c43ac0965f3c4dba40288724acda79152.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23044), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23048));
			this.c43ac0965f3c4dba40288724acda79152.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23052);
			this.c43ac0965f3c4dba40288724acda79152.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83754);
			this.c4553ed186725b714efcccc71bbe10a0f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23056);
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23064));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23072));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23076);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85480);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23080);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23088));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23096));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23100);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85511);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c6e71cd26dcbf85d46dc8c3001cd3752d;
			this.c052ccf41a3ad1f787a00eeef2d674c87.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23104);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23108), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23112));
			this.c052ccf41a3ad1f787a00eeef2d674c87.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49484);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23116), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23120));
			this.c052ccf41a3ad1f787a00eeef2d674c87.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23124);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85522);
			this.ce101c2d73f85a684f9dce02f36f4b13d.CanUpdateChildIndex = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23128) != 0);
			this.ce101c2d73f85a684f9dce02f36f4b13d.CaptionVisible = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23132) != 0);
			this.ce101c2d73f85a684f9dce02f36f4b13d.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23136) != 0);
			this.ce101c2d73f85a684f9dce02f36f4b13d.Controls.Add(this.cd9cc6282fcad129739eed0b12b013814);
			this.ce101c2d73f85a684f9dce02f36f4b13d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23140), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23144));
			this.ce101c2d73f85a684f9dce02f36f4b13d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85591);
			this.ce101c2d73f85a684f9dce02f36f4b13d.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23148), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23152));
			this.ce101c2d73f85a684f9dce02f36f4b13d.SelectedIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23156);
			this.ce101c2d73f85a684f9dce02f36f4b13d.ShowItemToolTips = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23160) != 0);
			this.ce101c2d73f85a684f9dce02f36f4b13d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23164), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23168));
			this.ce101c2d73f85a684f9dce02f36f4b13d.SizeInfo.AbsoluteSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23172), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23176));
			this.ce101c2d73f85a684f9dce02f36f4b13d.SizeInfo.SplitterCorrection = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23180), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23184));
			this.ce101c2d73f85a684f9dce02f36f4b13d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23188);
			this.ce101c2d73f85a684f9dce02f36f4b13d.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23192) != 0);
			this.cd9cc6282fcad129739eed0b12b013814.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.cd9cc6282fcad129739eed0b12b013814.Controls.Add(this.c6a2b595cc5d4feecae7d4d122a8f1dce);
			this.cd9cc6282fcad129739eed0b12b013814.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23196);
			this.cd9cc6282fcad129739eed0b12b013814.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(23200));
			this.cd9cc6282fcad129739eed0b12b013814.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23204), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23208));
			this.cd9cc6282fcad129739eed0b12b013814.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85618);
			this.cd9cc6282fcad129739eed0b12b013814.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23212);
			this.cd9cc6282fcad129739eed0b12b013814.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23216), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23220));
			this.cd9cc6282fcad129739eed0b12b013814.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85618);
			this.cd9cc6282fcad129739eed0b12b013814.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23224);
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23228);
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.Image = c6faa5467be1a4874657b372a49b7c927.banner;
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.ImageLocation = "";
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.ImeMode = (ImeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23232);
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23236), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23240));
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85641);
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23244), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23248));
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23252);
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23256);
			this.c6a2b595cc5d4feecae7d4d122a8f1dce.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23260) != 0);
			this.c822d3bd636ef45abd026eb08950f0fcc.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23264) != 0);
			this.c822d3bd636ef45abd026eb08950f0fcc.Controls.Add(this.c3734340a6bb7f4279e55914719952804);
			this.c822d3bd636ef45abd026eb08950f0fcc.Controls.Add(this.c1bd04ef35d363a76d3290f9f227223a5);
			this.c822d3bd636ef45abd026eb08950f0fcc.Controls.Add(this.cb0d70167e184f5c28c15730dd468edc2);
			this.c822d3bd636ef45abd026eb08950f0fcc.Controls.Add(this.c3e55eccc22a105d650a95dea151c61b6);
			this.c822d3bd636ef45abd026eb08950f0fcc.IsCleanUpTarget = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23268) != 0);
			this.c822d3bd636ef45abd026eb08950f0fcc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23272), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23276));
			this.c822d3bd636ef45abd026eb08950f0fcc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85658);
			this.c822d3bd636ef45abd026eb08950f0fcc.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23280));
			this.c822d3bd636ef45abd026eb08950f0fcc.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23288));
			this.c822d3bd636ef45abd026eb08950f0fcc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23292), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23296));
			this.c822d3bd636ef45abd026eb08950f0fcc.SizeInfo.AbsoluteSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23300), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23304));
			this.c822d3bd636ef45abd026eb08950f0fcc.SizeInfo.SplitterCorrection = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23308), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23312));
			this.c822d3bd636ef45abd026eb08950f0fcc.SplitterWidth = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23316);
			this.c822d3bd636ef45abd026eb08950f0fcc.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23320);
			this.c822d3bd636ef45abd026eb08950f0fcc.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23324) != 0);
			this.c3734340a6bb7f4279e55914719952804.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23328) != 0);
			this.c3734340a6bb7f4279e55914719952804.Controls.Add(this.caab8d6cd57c54c842169d92d82ff1eb4);
			this.c3734340a6bb7f4279e55914719952804.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85695);
			this.c3734340a6bb7f4279e55914719952804.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23332), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23336));
			this.c3734340a6bb7f4279e55914719952804.SizeInfo.AbsoluteSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23344));
			this.c3734340a6bb7f4279e55914719952804.SizeInfo.SizeMode = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23348);
			this.c3734340a6bb7f4279e55914719952804.SizeInfo.SplitterCorrection = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23352), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23356));
			this.c3734340a6bb7f4279e55914719952804.SplitterWidth = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23360);
			this.caab8d6cd57c54c842169d92d82ff1eb4.CanUpdateChildIndex = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23364) != 0);
			this.caab8d6cd57c54c842169d92d82ff1eb4.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23368) != 0);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Controls.Add(this.c3c5d23dd6cecab0bcd4e0600a2ca234b);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Controls.Add(this.c19ea03710ebcce9d9618141875fa6b4b);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Controls.Add(this.c96d38c3849e994101ac7564a97ee637d);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Controls.Add(this.c3d83fff74bf1b63d7b3ac872c2b3cc82);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Controls.Add(this.c3cc59d9c7d75e7586fc9064eea5aa1be);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Controls.Add(this.c38e15f9793026f5c07a201f09952a0ac);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Controls.Add(this.c5cedfdbf9e879295d762e0b02d960d33);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23372), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23376));
			this.caab8d6cd57c54c842169d92d82ff1eb4.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85732);
			this.caab8d6cd57c54c842169d92d82ff1eb4.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23380), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23384));
			this.caab8d6cd57c54c842169d92d82ff1eb4.SelectedIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23388);
			this.caab8d6cd57c54c842169d92d82ff1eb4.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23392), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23396));
			this.caab8d6cd57c54c842169d92d82ff1eb4.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23400);
			this.caab8d6cd57c54c842169d92d82ff1eb4.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23404) != 0);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.AutoScroll = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23408) != 0);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Controls.Add(this.c2cf916b4dc1582084d9fe6ddbeff235f);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.DefaultFloatingSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23412), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23416));
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23420);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(23424));
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23428), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23432));
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85767);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23436);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23440), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23444));
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85790);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23448);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23452);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23456) != 0);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c992db60513feabfee7066ab96aec9a64);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c821c2394e2dbac0ba1c2982eeb77d30d);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c92d48e7b56cd690ea66ba42d3db5e722);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.cf6348eb630c0b01e77b8f83ec7151d96);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c8839ab017cc506ca34b8277549d5d1bc);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c06f4d49c4cd7969e514a4b3649e010c9);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c92ab20cb1038469a6ddf6e1b4c5d8d5c);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c2fb6dd895d1ff7ecd48bea8f8087cbe2);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c5a37947f2bfc099265b4ef9252b00763);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Controls.Add(this.c90fe97b27e47a56fbdfb26d97ff3fbe0);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23460);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85805);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23464), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23468));
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48202);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23472), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23476));
			this.c2cf916b4dc1582084d9fe6ddbeff235f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23480);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85805);
			this.c992db60513feabfee7066ab96aec9a64.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23484);
			this.c992db60513feabfee7066ab96aec9a64.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23488) != 0);
			this.c992db60513feabfee7066ab96aec9a64.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23492) != 0);
			this.c992db60513feabfee7066ab96aec9a64.CheckState = (CheckState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23496);
			this.c992db60513feabfee7066ab96aec9a64.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23504));
			this.c992db60513feabfee7066ab96aec9a64.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85816);
			this.c992db60513feabfee7066ab96aec9a64.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23508), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23512));
			this.c992db60513feabfee7066ab96aec9a64.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23516);
			this.c992db60513feabfee7066ab96aec9a64.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85841);
			this.c992db60513feabfee7066ab96aec9a64.UseVisualStyleBackColor = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23520) != 0);
			this.c992db60513feabfee7066ab96aec9a64.CheckedChanged += this.cad7892a5b5850df41662303d49978c03;
			this.c821c2394e2dbac0ba1c2982eeb77d30d.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23524);
			this.c821c2394e2dbac0ba1c2982eeb77d30d.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23528) != 0);
			this.c821c2394e2dbac0ba1c2982eeb77d30d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23532), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23536));
			this.c821c2394e2dbac0ba1c2982eeb77d30d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85854);
			this.c821c2394e2dbac0ba1c2982eeb77d30d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23544));
			this.c821c2394e2dbac0ba1c2982eeb77d30d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23548);
			this.c821c2394e2dbac0ba1c2982eeb77d30d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85885);
			this.c821c2394e2dbac0ba1c2982eeb77d30d.UseVisualStyleBackColor = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23552) != 0);
			this.c821c2394e2dbac0ba1c2982eeb77d30d.CheckedChanged += this.c7e5eb63afb6a31a6e590df5dc9c2972b;
			this.c92d48e7b56cd690ea66ba42d3db5e722.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23556);
			this.c92d48e7b56cd690ea66ba42d3db5e722.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23560) != 0);
			this.c92d48e7b56cd690ea66ba42d3db5e722.Checked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23564) != 0);
			this.c92d48e7b56cd690ea66ba42d3db5e722.CheckState = (CheckState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23568);
			this.c92d48e7b56cd690ea66ba42d3db5e722.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23572), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23576));
			this.c92d48e7b56cd690ea66ba42d3db5e722.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85902);
			this.c92d48e7b56cd690ea66ba42d3db5e722.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23580), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23584));
			this.c92d48e7b56cd690ea66ba42d3db5e722.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23588);
			this.c92d48e7b56cd690ea66ba42d3db5e722.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85931);
			this.c92d48e7b56cd690ea66ba42d3db5e722.UseVisualStyleBackColor = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23592) != 0);
			this.c92d48e7b56cd690ea66ba42d3db5e722.CheckedChanged += this.ca0d429b70b1e389837bf8684a5e44a42;
			this.c8839ab017cc506ca34b8277549d5d1bc.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23596) != 0);
			this.c8839ab017cc506ca34b8277549d5d1bc.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23600);
			this.c8839ab017cc506ca34b8277549d5d1bc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23604), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23608));
			this.c8839ab017cc506ca34b8277549d5d1bc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85940);
			this.c8839ab017cc506ca34b8277549d5d1bc.RightToLeft = (RightToLeft)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23612);
			this.c8839ab017cc506ca34b8277549d5d1bc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23616), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23620));
			this.c8839ab017cc506ca34b8277549d5d1bc.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23624);
			this.c8839ab017cc506ca34b8277549d5d1bc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85969);
			this.c8839ab017cc506ca34b8277549d5d1bc.ToggleStateChanged += new StateChangedEventHandler(this.cc4d16b6616f3d5d05a738e5ea3fb3aea);
			this.c5a37947f2bfc099265b4ef9252b00763.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23628);
			this.c5a37947f2bfc099265b4ef9252b00763.Controls.Add(this.c15cfb8d25fc93dd1b55a4ea47493c187);
			this.c5a37947f2bfc099265b4ef9252b00763.Controls.Add(this.cdfa7a89b1b84c54d18b8677922f3bb6f);
			this.c5a37947f2bfc099265b4ef9252b00763.Controls.Add(this.cde07a8d8f3fe5ea1f59833c2ca019b46);
			this.c5a37947f2bfc099265b4ef9252b00763.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23632);
			this.c5a37947f2bfc099265b4ef9252b00763.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.c5a37947f2bfc099265b4ef9252b00763.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23636), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23640));
			this.c5a37947f2bfc099265b4ef9252b00763.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85996);
			this.c5a37947f2bfc099265b4ef9252b00763.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23644), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23648));
			this.c5a37947f2bfc099265b4ef9252b00763.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23652);
			this.c5a37947f2bfc099265b4ef9252b00763.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23656);
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23660), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23664));
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52830);
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23668), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23672));
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23676);
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86021);
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.Click += this.c2032ee1e85a2f156d937f89f47b1ac61;
			this.c19ea03710ebcce9d9618141875fa6b4b.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c19ea03710ebcce9d9618141875fa6b4b.Controls.Add(this.c0717e8606cc1780a278c591545ce83ab);
			this.c19ea03710ebcce9d9618141875fa6b4b.Controls.Add(this.c0ae86718cfb509f45e535dd79ebdeb1c);
			this.c19ea03710ebcce9d9618141875fa6b4b.DefaultFloatingSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23680), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23684));
			this.c19ea03710ebcce9d9618141875fa6b4b.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23688);
			this.c19ea03710ebcce9d9618141875fa6b4b.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(23692));
			this.c19ea03710ebcce9d9618141875fa6b4b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23696), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23700));
			this.c19ea03710ebcce9d9618141875fa6b4b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86034);
			this.c19ea03710ebcce9d9618141875fa6b4b.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23704);
			this.c19ea03710ebcce9d9618141875fa6b4b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23708), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23712));
			this.c19ea03710ebcce9d9618141875fa6b4b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86057);
			this.c19ea03710ebcce9d9618141875fa6b4b.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23716);
			this.c0717e8606cc1780a278c591545ce83ab.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23720);
			this.c0717e8606cc1780a278c591545ce83ab.Controls.Add(this.c379f097df981d80284e646aa1f74b28f);
			this.c0717e8606cc1780a278c591545ce83ab.Controls.Add(this.c0e7bde0280df56351440f1954d87e7a9);
			this.c0717e8606cc1780a278c591545ce83ab.Controls.Add(this.c53ab326bd7d17bbcadde4355d8fe4bfc);
			this.c0717e8606cc1780a278c591545ce83ab.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23724);
			this.c0717e8606cc1780a278c591545ce83ab.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86072);
			this.c0717e8606cc1780a278c591545ce83ab.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23728), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23732));
			this.c0717e8606cc1780a278c591545ce83ab.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86230);
			this.c0717e8606cc1780a278c591545ce83ab.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23736), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23740));
			this.c0717e8606cc1780a278c591545ce83ab.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23744);
			this.c0717e8606cc1780a278c591545ce83ab.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86072);
			this.c379f097df981d80284e646aa1f74b28f.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23748) != 0);
			this.c379f097df981d80284e646aa1f74b28f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23752);
			this.c379f097df981d80284e646aa1f74b28f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23756), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23760));
			this.c379f097df981d80284e646aa1f74b28f.Margin = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23764), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23768), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23772), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23776));
			this.c379f097df981d80284e646aa1f74b28f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86257);
			this.c379f097df981d80284e646aa1f74b28f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23784));
			this.c379f097df981d80284e646aa1f74b28f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23788);
			this.c379f097df981d80284e646aa1f74b28f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43485);
			this.c379f097df981d80284e646aa1f74b28f.ItemMouseUp += new ListViewItemMouseEventHandler(this.c529a381d00bec906dde0444fe8d27e4e);
			this.c379f097df981d80284e646aa1f74b28f.ItemCheckedChanged += new ListViewItemEventHandler(this.c97141158cfd040afae6eabee5859b4b5);
			this.c0e7bde0280df56351440f1954d87e7a9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23792);
			this.c0e7bde0280df56351440f1954d87e7a9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23796), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23800));
			this.c0e7bde0280df56351440f1954d87e7a9.Margin = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23804), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23808), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23812), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23816));
			this.c0e7bde0280df56351440f1954d87e7a9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67505);
			this.c0e7bde0280df56351440f1954d87e7a9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23820), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23824));
			this.c0e7bde0280df56351440f1954d87e7a9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23828);
			this.c0e7bde0280df56351440f1954d87e7a9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67528);
			this.c0e7bde0280df56351440f1954d87e7a9.Click += this.c46b6ded173670d3a80a210dd349eb95a;
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23832);
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23836), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23840));
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.Margin = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23844), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23848), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23852), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23856));
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86282);
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23860), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23864));
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23868);
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86303);
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.Click += this.c0ac34b2eab8aae7ce17981775cc306b4;
			this.c0ae86718cfb509f45e535dd79ebdeb1c.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23872);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Controls.Add(this.ca4bbd9e42efba9cc6ffad5fab3161776);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Controls.Add(this.c693a1e47df92a82ced2b7ad96d5fae58);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Controls.Add(this.ca462c61c0669b9dd1d247bbdb465239d);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Controls.Add(this.c140ccd2b676242ee7992f31d621ad05b);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23876);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86328);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23880), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23884));
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86343);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23888), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23892));
			this.c0ae86718cfb509f45e535dd79ebdeb1c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23896);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86328);
			this.ca4bbd9e42efba9cc6ffad5fab3161776.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23900);
			this.ca4bbd9e42efba9cc6ffad5fab3161776.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23904), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23908));
			this.ca4bbd9e42efba9cc6ffad5fab3161776.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86370);
			this.ca4bbd9e42efba9cc6ffad5fab3161776.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23912), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23916));
			this.ca4bbd9e42efba9cc6ffad5fab3161776.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23920);
			this.ca4bbd9e42efba9cc6ffad5fab3161776.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47158);
			this.ca4bbd9e42efba9cc6ffad5fab3161776.CheckStateChanged += this.c01e6473071d863fe1a739382fc8d376c;
			this.c693a1e47df92a82ced2b7ad96d5fae58.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23924);
			this.c693a1e47df92a82ced2b7ad96d5fae58.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23928), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23932));
			this.c693a1e47df92a82ced2b7ad96d5fae58.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86383);
			this.c693a1e47df92a82ced2b7ad96d5fae58.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23940));
			this.c693a1e47df92a82ced2b7ad96d5fae58.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23944);
			this.c693a1e47df92a82ced2b7ad96d5fae58.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86396);
			this.c693a1e47df92a82ced2b7ad96d5fae58.CheckStateChanged += this.cce20dac3f9bbb99e6fbff8559b2fd0d6;
			this.ca462c61c0669b9dd1d247bbdb465239d.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23948);
			this.ca462c61c0669b9dd1d247bbdb465239d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23952), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23956));
			this.ca462c61c0669b9dd1d247bbdb465239d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86403);
			this.ca462c61c0669b9dd1d247bbdb465239d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23960), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23964));
			this.ca462c61c0669b9dd1d247bbdb465239d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23968);
			this.ca462c61c0669b9dd1d247bbdb465239d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759);
			this.ca462c61c0669b9dd1d247bbdb465239d.CheckStateChanged += this.cee2e51bb5eab78cdd45f76a34f95c720;
			this.c140ccd2b676242ee7992f31d621ad05b.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23972);
			this.c140ccd2b676242ee7992f31d621ad05b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23976), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23980));
			this.c140ccd2b676242ee7992f31d621ad05b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86416);
			this.c140ccd2b676242ee7992f31d621ad05b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23984), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23988));
			this.c140ccd2b676242ee7992f31d621ad05b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23992);
			this.c140ccd2b676242ee7992f31d621ad05b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3752);
			this.c140ccd2b676242ee7992f31d621ad05b.CheckStateChanged += this.ce04eaa7ac05ba8ddbee1441d01873f57;
			this.c96d38c3849e994101ac7564a97ee637d.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c96d38c3849e994101ac7564a97ee637d.Controls.Add(this.c959a761dc775e86d2402435397545a98);
			this.c96d38c3849e994101ac7564a97ee637d.Controls.Add(this.c771aaa5176d35a275b87f16a926f5c2f);
			this.c96d38c3849e994101ac7564a97ee637d.Controls.Add(this.c556ce890ae6cca856126c0a40a422ad2);
			this.c96d38c3849e994101ac7564a97ee637d.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(23996);
			this.c96d38c3849e994101ac7564a97ee637d.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(24000));
			this.c96d38c3849e994101ac7564a97ee637d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24004), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24008));
			this.c96d38c3849e994101ac7564a97ee637d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86429);
			this.c96d38c3849e994101ac7564a97ee637d.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24012);
			this.c96d38c3849e994101ac7564a97ee637d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24016), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24020));
			this.c96d38c3849e994101ac7564a97ee637d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86466);
			this.c96d38c3849e994101ac7564a97ee637d.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24024);
			this.c959a761dc775e86d2402435397545a98.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24028);
			this.c959a761dc775e86d2402435397545a98.Controls.Add(this.c127c6c3e1f77cb695a754ccf2106b43f);
			this.c959a761dc775e86d2402435397545a98.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24032);
			this.c959a761dc775e86d2402435397545a98.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86497);
			this.c959a761dc775e86d2402435397545a98.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24036), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24040));
			this.c959a761dc775e86d2402435397545a98.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86508);
			this.c959a761dc775e86d2402435397545a98.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24044), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24048));
			this.c959a761dc775e86d2402435397545a98.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24052);
			this.c959a761dc775e86d2402435397545a98.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86497);
			this.c127c6c3e1f77cb695a754ccf2106b43f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24056);
			this.c127c6c3e1f77cb695a754ccf2106b43f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24064));
			this.c127c6c3e1f77cb695a754ccf2106b43f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86535);
			this.c127c6c3e1f77cb695a754ccf2106b43f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24072));
			this.c127c6c3e1f77cb695a754ccf2106b43f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24076);
			this.c127c6c3e1f77cb695a754ccf2106b43f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52010);
			this.c771aaa5176d35a275b87f16a926f5c2f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24080);
			this.c771aaa5176d35a275b87f16a926f5c2f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24088));
			this.c771aaa5176d35a275b87f16a926f5c2f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86562);
			this.c771aaa5176d35a275b87f16a926f5c2f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24096));
			this.c771aaa5176d35a275b87f16a926f5c2f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24100);
			this.c771aaa5176d35a275b87f16a926f5c2f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86607);
			this.c771aaa5176d35a275b87f16a926f5c2f.Click += this.cf2cb748148424966970fef3131895f95;
			this.c556ce890ae6cca856126c0a40a422ad2.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24104);
			this.c556ce890ae6cca856126c0a40a422ad2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24108), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24112));
			this.c556ce890ae6cca856126c0a40a422ad2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86662);
			this.c556ce890ae6cca856126c0a40a422ad2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24116), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24120));
			this.c556ce890ae6cca856126c0a40a422ad2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24124);
			this.c556ce890ae6cca856126c0a40a422ad2.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86697);
			this.c556ce890ae6cca856126c0a40a422ad2.Click += this.cf7a0fca06451c5ceb443e96632459aec;
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Controls.Add(this.c3a0c73f7b32d3a3c4d6231ee4ca82455);
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Controls.Add(this.cf070b8f366fa5e362b202a68723dd024);
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Controls.Add(this.c7fbe090bab86fb6fbed0140fe13b50ac);
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24128);
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(24132));
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24136), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24140));
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86728);
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24144);
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24148), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24152));
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86769);
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24156);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24160);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.Controls.Add(this.c30ff40a26c3b8d3f5b34356c58f244ee);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24164);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86804);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24168), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24172));
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86837);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24176), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24180), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24184), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24188));
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24192), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24196));
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24200);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86804);
			this.c30ff40a26c3b8d3f5b34356c58f244ee.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24204) != 0);
			this.c30ff40a26c3b8d3f5b34356c58f244ee.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24208);
			this.c30ff40a26c3b8d3f5b34356c58f244ee.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24212), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24216));
			this.c30ff40a26c3b8d3f5b34356c58f244ee.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86864);
			this.c30ff40a26c3b8d3f5b34356c58f244ee.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24220), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24224));
			this.c30ff40a26c3b8d3f5b34356c58f244ee.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24228);
			this.c30ff40a26c3b8d3f5b34356c58f244ee.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43485);
			this.cf070b8f366fa5e362b202a68723dd024.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24232);
			this.cf070b8f366fa5e362b202a68723dd024.Controls.Add(this.c63371175f2a9c38a0ecc286c5d95503f);
			this.cf070b8f366fa5e362b202a68723dd024.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24236);
			this.cf070b8f366fa5e362b202a68723dd024.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86901);
			this.cf070b8f366fa5e362b202a68723dd024.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24240), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24244));
			this.cf070b8f366fa5e362b202a68723dd024.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86916);
			this.cf070b8f366fa5e362b202a68723dd024.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24248), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24252));
			this.cf070b8f366fa5e362b202a68723dd024.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24256);
			this.cf070b8f366fa5e362b202a68723dd024.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86901);
			this.c63371175f2a9c38a0ecc286c5d95503f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24260), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24264));
			this.c63371175f2a9c38a0ecc286c5d95503f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86943);
			this.c63371175f2a9c38a0ecc286c5d95503f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24268), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24272));
			this.c63371175f2a9c38a0ecc286c5d95503f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24276);
			this.c63371175f2a9c38a0ecc286c5d95503f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86980);
			this.c63371175f2a9c38a0ecc286c5d95503f.ToggleStateChanged += new StateChangedEventHandler(this.c694317428fbb7e36b5efb11c71449e36);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24280);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.c85837e3848f514b3ef5efaee2f6dde4c);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.cd130fbdce9a854f33033b953b07b1d27);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.c42691c651c912f80ce2a6783758e6eeb);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.c8dc32f35e68597fe4c6daa5fe1df3f09);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.c6f49ef988d94b37c11e87121dc8cf655);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.cb0cfae55913822d197dd756dceb3d6aa);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.cb5a0a2daffea489d9502568fc2558386);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.c7c0d0e61cda4b5dbf992885ec7aab275);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.ccc6197ad0cf795a9587c66570a9dfb79);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Controls.Add(this.cdf2e782b37313a443dabb661cd0cbf24);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24284);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87073);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24288), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24292));
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87094);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24296), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24300));
			this.c7fbe090bab86fb6fbed0140fe13b50ac.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24304);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87073);
			this.c85837e3848f514b3ef5efaee2f6dde4c.ForeColor = Color.Red;
			this.c85837e3848f514b3ef5efaee2f6dde4c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24308), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24312));
			this.c85837e3848f514b3ef5efaee2f6dde4c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87121);
			this.c85837e3848f514b3ef5efaee2f6dde4c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24316), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24320));
			this.c85837e3848f514b3ef5efaee2f6dde4c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24324);
			this.c85837e3848f514b3ef5efaee2f6dde4c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82823);
			this.cd130fbdce9a854f33033b953b07b1d27.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24328), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24332));
			this.cd130fbdce9a854f33033b953b07b1d27.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87150);
			this.cd130fbdce9a854f33033b953b07b1d27.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24336), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24340));
			this.cd130fbdce9a854f33033b953b07b1d27.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24344);
			this.cd130fbdce9a854f33033b953b07b1d27.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87171);
			this.c42691c651c912f80ce2a6783758e6eeb.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24348);
			this.c42691c651c912f80ce2a6783758e6eeb.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24352), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24356));
			this.c42691c651c912f80ce2a6783758e6eeb.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87200);
			this.c42691c651c912f80ce2a6783758e6eeb.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24360), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24364));
			this.c42691c651c912f80ce2a6783758e6eeb.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24368);
			this.c42691c651c912f80ce2a6783758e6eeb.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85511);
			this.c42691c651c912f80ce2a6783758e6eeb.Click += this.c829f936818d72c3eb4aacf68d39b895c;
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24372);
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24376), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24380));
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87227);
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24384), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24388));
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24392);
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(76277);
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.Click += this.c8440989ae77b9ada82708025cea33344;
			this.c6f49ef988d94b37c11e87121dc8cf655.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24396);
			this.c6f49ef988d94b37c11e87121dc8cf655.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24400), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24404));
			this.c6f49ef988d94b37c11e87121dc8cf655.MinimumSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24408), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24412));
			this.c6f49ef988d94b37c11e87121dc8cf655.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53921);
			this.c6f49ef988d94b37c11e87121dc8cf655.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24416), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24420));
			this.c6f49ef988d94b37c11e87121dc8cf655.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24424), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24428));
			this.c6f49ef988d94b37c11e87121dc8cf655.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24432);
			this.cb0cfae55913822d197dd756dceb3d6aa.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24436), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24440));
			this.cb0cfae55913822d197dd756dceb3d6aa.MinimumSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24444), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24448));
			this.cb0cfae55913822d197dd756dceb3d6aa.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87250);
			this.cb0cfae55913822d197dd756dceb3d6aa.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24452), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24456));
			this.cb0cfae55913822d197dd756dceb3d6aa.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24460), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24464));
			this.cb0cfae55913822d197dd756dceb3d6aa.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24468);
			this.cb5a0a2daffea489d9502568fc2558386.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24472);
			this.cb5a0a2daffea489d9502568fc2558386.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24476), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24480));
			this.cb5a0a2daffea489d9502568fc2558386.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87273);
			this.cb5a0a2daffea489d9502568fc2558386.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24484), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24488));
			this.cb5a0a2daffea489d9502568fc2558386.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24492);
			this.cb5a0a2daffea489d9502568fc2558386.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87306);
			this.c7c0d0e61cda4b5dbf992885ec7aab275.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24496), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24500));
			this.c7c0d0e61cda4b5dbf992885ec7aab275.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87327);
			this.c7c0d0e61cda4b5dbf992885ec7aab275.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24504), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24508));
			this.c7c0d0e61cda4b5dbf992885ec7aab275.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24512);
			this.c7c0d0e61cda4b5dbf992885ec7aab275.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87348);
			this.ccc6197ad0cf795a9587c66570a9dfb79.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24516);
			this.ccc6197ad0cf795a9587c66570a9dfb79.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24520), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24524));
			this.ccc6197ad0cf795a9587c66570a9dfb79.MinimumSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24532));
			this.ccc6197ad0cf795a9587c66570a9dfb79.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87369);
			this.ccc6197ad0cf795a9587c66570a9dfb79.NullText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87392);
			this.ccc6197ad0cf795a9587c66570a9dfb79.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24536), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24540));
			this.ccc6197ad0cf795a9587c66570a9dfb79.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24544), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24548));
			this.ccc6197ad0cf795a9587c66570a9dfb79.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24552);
			this.cdf2e782b37313a443dabb661cd0cbf24.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24556), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24560));
			this.cdf2e782b37313a443dabb661cd0cbf24.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87443);
			this.cdf2e782b37313a443dabb661cd0cbf24.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24564), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24568));
			this.cdf2e782b37313a443dabb661cd0cbf24.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24572);
			this.cdf2e782b37313a443dabb661cd0cbf24.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87464);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Controls.Add(this.c1d6115076623e59322dfdd1bdc07fa83);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Controls.Add(this.cf852cda1e32cfb76a067c73ed3f9a113);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Controls.Add(this.c54df7c8ea1f37706a137b19cef6a157e);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Controls.Add(this.cf1ae3eee5cba489bc07bd471e11bf801);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24576);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(24580));
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24584), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24588));
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87475);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24592);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24596), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24600));
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87506);
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24604);
			this.c1d6115076623e59322dfdd1bdc07fa83.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24608);
			this.c1d6115076623e59322dfdd1bdc07fa83.Controls.Add(this.c226f954145921ae178aa3238c5370176);
			this.c1d6115076623e59322dfdd1bdc07fa83.Controls.Add(this.c4e15dbb60549d511732b8608a9a1cf24);
			this.c1d6115076623e59322dfdd1bdc07fa83.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24612);
			this.c1d6115076623e59322dfdd1bdc07fa83.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87533);
			this.c1d6115076623e59322dfdd1bdc07fa83.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24616), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24620));
			this.c1d6115076623e59322dfdd1bdc07fa83.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87566);
			this.c1d6115076623e59322dfdd1bdc07fa83.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24624), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24628));
			this.c1d6115076623e59322dfdd1bdc07fa83.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24632);
			this.c1d6115076623e59322dfdd1bdc07fa83.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87533);
			this.c226f954145921ae178aa3238c5370176.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24636);
			this.c226f954145921ae178aa3238c5370176.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24640);
			this.c226f954145921ae178aa3238c5370176.Image = c6faa5467be1a4874657b372a49b7c927.icnPlay;
			this.c226f954145921ae178aa3238c5370176.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24644), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24648));
			this.c226f954145921ae178aa3238c5370176.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60176);
			this.c226f954145921ae178aa3238c5370176.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24652));
			this.c226f954145921ae178aa3238c5370176.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24656), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24660));
			this.c226f954145921ae178aa3238c5370176.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24664);
			this.c226f954145921ae178aa3238c5370176.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87593);
			this.c226f954145921ae178aa3238c5370176.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24668);
			this.c226f954145921ae178aa3238c5370176.Click += this.cfd1ddf550d109e29508a7cb185b2c3e1;
			this.c4e15dbb60549d511732b8608a9a1cf24.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24672), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24676));
			this.c4e15dbb60549d511732b8608a9a1cf24.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87632);
			this.c4e15dbb60549d511732b8608a9a1cf24.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24680), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24684));
			this.c4e15dbb60549d511732b8608a9a1cf24.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24688);
			this.c4e15dbb60549d511732b8608a9a1cf24.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87653);
			this.cf852cda1e32cfb76a067c73ed3f9a113.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24692);
			this.cf852cda1e32cfb76a067c73ed3f9a113.Controls.Add(this.c7a7e4684ac13bfb11ce1a11695b1329c);
			this.cf852cda1e32cfb76a067c73ed3f9a113.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24696);
			this.cf852cda1e32cfb76a067c73ed3f9a113.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87776);
			this.cf852cda1e32cfb76a067c73ed3f9a113.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24700), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24704));
			this.cf852cda1e32cfb76a067c73ed3f9a113.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87791);
			this.cf852cda1e32cfb76a067c73ed3f9a113.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24708), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24712));
			this.cf852cda1e32cfb76a067c73ed3f9a113.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24716);
			this.cf852cda1e32cfb76a067c73ed3f9a113.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87776);
			this.c7a7e4684ac13bfb11ce1a11695b1329c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24720), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24724));
			this.c7a7e4684ac13bfb11ce1a11695b1329c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87818);
			this.c7a7e4684ac13bfb11ce1a11695b1329c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24728), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24732));
			this.c7a7e4684ac13bfb11ce1a11695b1329c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24736);
			this.c7a7e4684ac13bfb11ce1a11695b1329c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87861);
			this.c7a7e4684ac13bfb11ce1a11695b1329c.ToggleStateChanged += new StateChangedEventHandler(this.c6a2b7530c9df83f8f246ecf6946f92a0);
			this.c54df7c8ea1f37706a137b19cef6a157e.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24740);
			this.c54df7c8ea1f37706a137b19cef6a157e.Controls.Add(this.c205802b28402610c81760457c1ed80d0);
			this.c54df7c8ea1f37706a137b19cef6a157e.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24744);
			this.c54df7c8ea1f37706a137b19cef6a157e.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87918);
			this.c54df7c8ea1f37706a137b19cef6a157e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24748), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24752));
			this.c54df7c8ea1f37706a137b19cef6a157e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48288);
			this.c54df7c8ea1f37706a137b19cef6a157e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24756), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24760));
			this.c54df7c8ea1f37706a137b19cef6a157e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24764);
			this.c54df7c8ea1f37706a137b19cef6a157e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87918);
			this.c205802b28402610c81760457c1ed80d0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24768), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24772));
			this.c205802b28402610c81760457c1ed80d0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87929);
			this.c205802b28402610c81760457c1ed80d0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24776), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24780));
			this.c205802b28402610c81760457c1ed80d0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24784);
			this.c205802b28402610c81760457c1ed80d0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(87968);
			this.c205802b28402610c81760457c1ed80d0.ToggleStateChanged += new StateChangedEventHandler(this.c152d0e8c2af774bf3f79889348d9d8b0);
			this.cf1ae3eee5cba489bc07bd471e11bf801.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24788);
			this.cf1ae3eee5cba489bc07bd471e11bf801.Controls.Add(this.c162efdf2cfee9dcaab42750eaecc63aa);
			this.cf1ae3eee5cba489bc07bd471e11bf801.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24792);
			this.cf1ae3eee5cba489bc07bd471e11bf801.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88021);
			this.cf1ae3eee5cba489bc07bd471e11bf801.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24796), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24800));
			this.cf1ae3eee5cba489bc07bd471e11bf801.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88030);
			this.cf1ae3eee5cba489bc07bd471e11bf801.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24804), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24808));
			this.cf1ae3eee5cba489bc07bd471e11bf801.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24812);
			this.cf1ae3eee5cba489bc07bd471e11bf801.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88021);
			this.c162efdf2cfee9dcaab42750eaecc63aa.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24816), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24820));
			this.c162efdf2cfee9dcaab42750eaecc63aa.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88057);
			this.c162efdf2cfee9dcaab42750eaecc63aa.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24824), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24828));
			this.c162efdf2cfee9dcaab42750eaecc63aa.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24832);
			this.c162efdf2cfee9dcaab42750eaecc63aa.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88094);
			this.c162efdf2cfee9dcaab42750eaecc63aa.ToggleStateChanged += new StateChangedEventHandler(this.cc3e78c0fea944a488374c9fd40bc314e);
			this.c38e15f9793026f5c07a201f09952a0ac.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c38e15f9793026f5c07a201f09952a0ac.Controls.Add(this.cdedfb80afbadf1c14d75db35b86905a8);
			this.c38e15f9793026f5c07a201f09952a0ac.Controls.Add(this.c60e2ae96cffa51442fc8ac176e5d69f8);
			this.c38e15f9793026f5c07a201f09952a0ac.Controls.Add(this.cc8460cb9e09be1126c93cb8f02503f12);
			this.c38e15f9793026f5c07a201f09952a0ac.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24836);
			this.c38e15f9793026f5c07a201f09952a0ac.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(24840));
			this.c38e15f9793026f5c07a201f09952a0ac.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24844), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24848));
			this.c38e15f9793026f5c07a201f09952a0ac.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88145);
			this.c38e15f9793026f5c07a201f09952a0ac.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24852);
			this.c38e15f9793026f5c07a201f09952a0ac.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24856), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24860));
			this.c38e15f9793026f5c07a201f09952a0ac.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88174);
			this.c38e15f9793026f5c07a201f09952a0ac.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24864);
			this.cdedfb80afbadf1c14d75db35b86905a8.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24868);
			this.cdedfb80afbadf1c14d75db35b86905a8.Controls.Add(this.ce25356b1de1570ee1fe025c0f0fa0184);
			this.cdedfb80afbadf1c14d75db35b86905a8.Controls.Add(this.c9f60413a79860ab64226aafde0051b03);
			this.cdedfb80afbadf1c14d75db35b86905a8.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24872);
			this.cdedfb80afbadf1c14d75db35b86905a8.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54159);
			this.cdedfb80afbadf1c14d75db35b86905a8.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24876), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24880));
			this.cdedfb80afbadf1c14d75db35b86905a8.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88195);
			this.cdedfb80afbadf1c14d75db35b86905a8.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24884), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24888));
			this.cdedfb80afbadf1c14d75db35b86905a8.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24892);
			this.cdedfb80afbadf1c14d75db35b86905a8.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54159);
			this.ce25356b1de1570ee1fe025c0f0fa0184.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24896);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Controls.Add(this.c87804958e268f3cb46688274d00bc3db);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Controls.Add(this.c35cb28ad4c137d6a5c2019389c2b9e68);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Controls.Add(this.c465fcdfe56a0a674011dbc560d792469);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Controls.Add(this.c915497b12593334e8fb5c8d1bfd58b57);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Controls.Add(this.c6ebb696cd62bce16aa5fc8555508c41b);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Controls.Add(this.ce2fbd05cd70c5cd49621c2fcd64f54fa);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Controls.Add(this.ce0fe1e4b5ecdeb355970bf03e357723f);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24900);
			this.ce25356b1de1570ee1fe025c0f0fa0184.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24904), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24908));
			this.ce25356b1de1570ee1fe025c0f0fa0184.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88222);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24912), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24916));
			this.ce25356b1de1570ee1fe025c0f0fa0184.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24920);
			this.ce25356b1de1570ee1fe025c0f0fa0184.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.c87804958e268f3cb46688274d00bc3db.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24924);
			this.c87804958e268f3cb46688274d00bc3db.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(24928), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24932), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24936), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24940));
			this.c87804958e268f3cb46688274d00bc3db.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24944), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24948));
			this.c87804958e268f3cb46688274d00bc3db.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(53625);
			this.c87804958e268f3cb46688274d00bc3db.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24952), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24956));
			this.c87804958e268f3cb46688274d00bc3db.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24960);
			this.c87804958e268f3cb46688274d00bc3db.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88249);
			this.c87804958e268f3cb46688274d00bc3db.Click += this.cc2a434874b29b4ef1d599598fd8507c1;
			this.c35cb28ad4c137d6a5c2019389c2b9e68.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24964), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24968));
			this.c35cb28ad4c137d6a5c2019389c2b9e68.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88302);
			this.c35cb28ad4c137d6a5c2019389c2b9e68.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24972), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24976));
			this.c35cb28ad4c137d6a5c2019389c2b9e68.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24980);
			this.c35cb28ad4c137d6a5c2019389c2b9e68.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c465fcdfe56a0a674011dbc560d792469.ForeColor = Color.Red;
			this.c465fcdfe56a0a674011dbc560d792469.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24984), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24988));
			this.c465fcdfe56a0a674011dbc560d792469.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88331);
			this.c465fcdfe56a0a674011dbc560d792469.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24992), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24996));
			this.c465fcdfe56a0a674011dbc560d792469.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25000);
			this.c465fcdfe56a0a674011dbc560d792469.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88364);
			this.c915497b12593334e8fb5c8d1bfd58b57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25004), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25008));
			this.c915497b12593334e8fb5c8d1bfd58b57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88409);
			this.c915497b12593334e8fb5c8d1bfd58b57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25012), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25016));
			this.c915497b12593334e8fb5c8d1bfd58b57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25020);
			this.c915497b12593334e8fb5c8d1bfd58b57.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88430);
			this.c6ebb696cd62bce16aa5fc8555508c41b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25024), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25028));
			this.c6ebb696cd62bce16aa5fc8555508c41b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88461);
			this.c6ebb696cd62bce16aa5fc8555508c41b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25032), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25036));
			this.c6ebb696cd62bce16aa5fc8555508c41b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25040);
			this.c6ebb696cd62bce16aa5fc8555508c41b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25044), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25048));
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88492);
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25052), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25056));
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25060);
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88513);
			this.ce0fe1e4b5ecdeb355970bf03e357723f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25064), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25068));
			this.ce0fe1e4b5ecdeb355970bf03e357723f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88544);
			this.ce0fe1e4b5ecdeb355970bf03e357723f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25072), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25076));
			this.ce0fe1e4b5ecdeb355970bf03e357723f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25080);
			this.ce0fe1e4b5ecdeb355970bf03e357723f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88565);
			this.c9f60413a79860ab64226aafde0051b03.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25088));
			this.c9f60413a79860ab64226aafde0051b03.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88600);
			this.c9f60413a79860ab64226aafde0051b03.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25096));
			this.c9f60413a79860ab64226aafde0051b03.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25100);
			this.c9f60413a79860ab64226aafde0051b03.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88565);
			this.c60e2ae96cffa51442fc8ac176e5d69f8.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25104);
			this.c60e2ae96cffa51442fc8ac176e5d69f8.Controls.Add(this.c026bf40f928f3d6dba737111fdffa7ed);
			this.c60e2ae96cffa51442fc8ac176e5d69f8.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25108);
			this.c60e2ae96cffa51442fc8ac176e5d69f8.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88621);
			this.c60e2ae96cffa51442fc8ac176e5d69f8.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25112), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25116));
			this.c60e2ae96cffa51442fc8ac176e5d69f8.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88680);
			this.c60e2ae96cffa51442fc8ac176e5d69f8.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25120));
			this.c60e2ae96cffa51442fc8ac176e5d69f8.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25124), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25128));
			this.c60e2ae96cffa51442fc8ac176e5d69f8.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25132);
			this.c60e2ae96cffa51442fc8ac176e5d69f8.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88621);
			this.c026bf40f928f3d6dba737111fdffa7ed.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25136);
			this.c026bf40f928f3d6dba737111fdffa7ed.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25140);
			this.c026bf40f928f3d6dba737111fdffa7ed.Image = c6faa5467be1a4874657b372a49b7c927.path3347;
			this.c026bf40f928f3d6dba737111fdffa7ed.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25144), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25148));
			this.c026bf40f928f3d6dba737111fdffa7ed.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88707);
			this.c026bf40f928f3d6dba737111fdffa7ed.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25152));
			this.c026bf40f928f3d6dba737111fdffa7ed.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25156), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25160));
			this.c026bf40f928f3d6dba737111fdffa7ed.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25164);
			this.c026bf40f928f3d6dba737111fdffa7ed.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88736);
			this.c026bf40f928f3d6dba737111fdffa7ed.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25168);
			this.c026bf40f928f3d6dba737111fdffa7ed.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25172);
			this.c026bf40f928f3d6dba737111fdffa7ed.Click += this.c3a4175617cd6da91db15b0a0feea4b91;
			this.cc8460cb9e09be1126c93cb8f02503f12.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25176);
			this.cc8460cb9e09be1126c93cb8f02503f12.Controls.Add(this.cd6742e70357ccb343e58ca4375bee4c3);
			this.cc8460cb9e09be1126c93cb8f02503f12.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25180);
			this.cc8460cb9e09be1126c93cb8f02503f12.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88773);
			this.cc8460cb9e09be1126c93cb8f02503f12.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25184), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25188));
			this.cc8460cb9e09be1126c93cb8f02503f12.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88796);
			this.cc8460cb9e09be1126c93cb8f02503f12.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25192));
			this.cc8460cb9e09be1126c93cb8f02503f12.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25196), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25200));
			this.cc8460cb9e09be1126c93cb8f02503f12.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25204);
			this.cc8460cb9e09be1126c93cb8f02503f12.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88773);
			this.cd6742e70357ccb343e58ca4375bee4c3.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25208);
			this.cd6742e70357ccb343e58ca4375bee4c3.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25212);
			this.cd6742e70357ccb343e58ca4375bee4c3.Image = c6faa5467be1a4874657b372a49b7c927.icnBug;
			this.cd6742e70357ccb343e58ca4375bee4c3.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25216), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25220));
			this.cd6742e70357ccb343e58ca4375bee4c3.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88823);
			this.cd6742e70357ccb343e58ca4375bee4c3.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25224));
			this.cd6742e70357ccb343e58ca4375bee4c3.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25228), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25232));
			this.cd6742e70357ccb343e58ca4375bee4c3.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25236);
			this.cd6742e70357ccb343e58ca4375bee4c3.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88844);
			this.cd6742e70357ccb343e58ca4375bee4c3.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25240);
			this.cd6742e70357ccb343e58ca4375bee4c3.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25244);
			this.cd6742e70357ccb343e58ca4375bee4c3.Click += this.ce75111fc74988c4776e5776984577e60;
			this.c5cedfdbf9e879295d762e0b02d960d33.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c5cedfdbf9e879295d762e0b02d960d33.Controls.Add(this.cf5b92d2f29e108857463d090ea17802d);
			this.c5cedfdbf9e879295d762e0b02d960d33.Controls.Add(this.cda159acd49537066b3d75532496a4850);
			this.c5cedfdbf9e879295d762e0b02d960d33.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25248);
			this.c5cedfdbf9e879295d762e0b02d960d33.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(25252));
			this.c5cedfdbf9e879295d762e0b02d960d33.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25256), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25260));
			this.c5cedfdbf9e879295d762e0b02d960d33.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88873);
			this.c5cedfdbf9e879295d762e0b02d960d33.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25264);
			this.c5cedfdbf9e879295d762e0b02d960d33.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25268), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25272));
			this.c5cedfdbf9e879295d762e0b02d960d33.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88890);
			this.c5cedfdbf9e879295d762e0b02d960d33.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25276);
			this.cf5b92d2f29e108857463d090ea17802d.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25280);
			this.cf5b92d2f29e108857463d090ea17802d.Controls.Add(this.cd792ac67bdacd5b7947dd1479f77c2a6);
			this.cf5b92d2f29e108857463d090ea17802d.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25284);
			this.cf5b92d2f29e108857463d090ea17802d.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88899);
			this.cf5b92d2f29e108857463d090ea17802d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25288), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25292));
			this.cf5b92d2f29e108857463d090ea17802d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88952);
			this.cf5b92d2f29e108857463d090ea17802d.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25296));
			this.cf5b92d2f29e108857463d090ea17802d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25300), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25304));
			this.cf5b92d2f29e108857463d090ea17802d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25308);
			this.cf5b92d2f29e108857463d090ea17802d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88899);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25312);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25316);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Image = c6faa5467be1a4874657b372a49b7c927.icnSd;
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25320), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25324));
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55849);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25328));
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25332), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25336));
			this.cd792ac67bdacd5b7947dd1479f77c2a6.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25340);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55874);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25344);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25348);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Click += this.cb1aed5a5240e442510f74197c00a9c4f;
			this.cda159acd49537066b3d75532496a4850.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25352);
			this.cda159acd49537066b3d75532496a4850.Controls.Add(this.cc655eded9d507adf5a9405e457f9a40f);
			this.cda159acd49537066b3d75532496a4850.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25356);
			this.cda159acd49537066b3d75532496a4850.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88979);
			this.cda159acd49537066b3d75532496a4850.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25360), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25364));
			this.cda159acd49537066b3d75532496a4850.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88996);
			this.cda159acd49537066b3d75532496a4850.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25368));
			this.cda159acd49537066b3d75532496a4850.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25372), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25376));
			this.cda159acd49537066b3d75532496a4850.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25380);
			this.cda159acd49537066b3d75532496a4850.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(88979);
			this.cc655eded9d507adf5a9405e457f9a40f.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25384);
			this.cc655eded9d507adf5a9405e457f9a40f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25388);
			this.cc655eded9d507adf5a9405e457f9a40f.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89023)));
			this.cc655eded9d507adf5a9405e457f9a40f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25392), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25396));
			this.cc655eded9d507adf5a9405e457f9a40f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89050);
			this.cc655eded9d507adf5a9405e457f9a40f.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25400));
			this.cc655eded9d507adf5a9405e457f9a40f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25404), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25408));
			this.cc655eded9d507adf5a9405e457f9a40f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25412);
			this.cc655eded9d507adf5a9405e457f9a40f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62544);
			this.cc655eded9d507adf5a9405e457f9a40f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25416);
			this.cc655eded9d507adf5a9405e457f9a40f.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25420);
			this.cc655eded9d507adf5a9405e457f9a40f.Click += this.c506bacf3bce3e30da3af6c9365ea3022;
			this.c1bd04ef35d363a76d3290f9f227223a5.CanUpdateChildIndex = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25424) != 0);
			this.c1bd04ef35d363a76d3290f9f227223a5.Controls.Add(this.cc50c89ea5530ed17711416cbd3400578);
			this.c1bd04ef35d363a76d3290f9f227223a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25428), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25432));
			this.c1bd04ef35d363a76d3290f9f227223a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89065);
			this.c1bd04ef35d363a76d3290f9f227223a5.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25436), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25440));
			this.c1bd04ef35d363a76d3290f9f227223a5.SelectedIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25444);
			this.c1bd04ef35d363a76d3290f9f227223a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25448), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25452));
			this.c1bd04ef35d363a76d3290f9f227223a5.SizeInfo.AbsoluteSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25456), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25460));
			this.c1bd04ef35d363a76d3290f9f227223a5.SizeInfo.SplitterCorrection = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25464), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25468));
			this.c1bd04ef35d363a76d3290f9f227223a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25472);
			this.c1bd04ef35d363a76d3290f9f227223a5.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25476) != 0);
			this.cc50c89ea5530ed17711416cbd3400578.AutoScroll = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25480) != 0);
			this.cc50c89ea5530ed17711416cbd3400578.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.cc50c89ea5530ed17711416cbd3400578.Controls.Add(this.c1f9e38a0e4349cfdda72516b7373c3cd);
			this.cc50c89ea5530ed17711416cbd3400578.Controls.Add(this.ca6c1cea062503a0a580756cf1f1f0961);
			this.cc50c89ea5530ed17711416cbd3400578.Controls.Add(this.c1fbb1a3b10ef0c49ba689bd6ae606d29);
			this.cc50c89ea5530ed17711416cbd3400578.Controls.Add(this.c96836d00d3b2ff6ba296617dd93ac7d1);
			this.cc50c89ea5530ed17711416cbd3400578.DefaultFloatingSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25484), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25488));
			this.cc50c89ea5530ed17711416cbd3400578.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25492);
			this.cc50c89ea5530ed17711416cbd3400578.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(25496));
			this.cc50c89ea5530ed17711416cbd3400578.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25504));
			this.cc50c89ea5530ed17711416cbd3400578.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89092);
			this.cc50c89ea5530ed17711416cbd3400578.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25508);
			this.cc50c89ea5530ed17711416cbd3400578.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25512), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25516));
			this.cc50c89ea5530ed17711416cbd3400578.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49381);
			this.cc50c89ea5530ed17711416cbd3400578.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25520);
			this.c1f9e38a0e4349cfdda72516b7373c3cd.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25524);
			this.c1f9e38a0e4349cfdda72516b7373c3cd.Controls.Add(this.ceda6b294518e1db9b1aa8a671392c806);
			this.c1f9e38a0e4349cfdda72516b7373c3cd.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25528);
			this.c1f9e38a0e4349cfdda72516b7373c3cd.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89117);
			this.c1f9e38a0e4349cfdda72516b7373c3cd.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25532), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25536));
			this.c1f9e38a0e4349cfdda72516b7373c3cd.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49202);
			this.c1f9e38a0e4349cfdda72516b7373c3cd.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25544));
			this.c1f9e38a0e4349cfdda72516b7373c3cd.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25548);
			this.c1f9e38a0e4349cfdda72516b7373c3cd.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89117);
			this.ceda6b294518e1db9b1aa8a671392c806.ActiveWindow = this.cda319ea417b6d72e15e4f08944f4e8f2;
			this.ceda6b294518e1db9b1aa8a671392c806.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25552) != 0);
			this.ceda6b294518e1db9b1aa8a671392c806.Controls.Add(this.ca094553b15c925802480db99005bd4f2);
			this.ceda6b294518e1db9b1aa8a671392c806.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25556);
			this.ceda6b294518e1db9b1aa8a671392c806.DocumentManager.ActiveDocumentMenuSortOrder = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25560);
			this.ceda6b294518e1db9b1aa8a671392c806.IsCleanUpTarget = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25564) != 0);
			this.ceda6b294518e1db9b1aa8a671392c806.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25568), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25572));
			this.ceda6b294518e1db9b1aa8a671392c806.MainDocumentContainer = this.ca094553b15c925802480db99005bd4f2;
			this.ceda6b294518e1db9b1aa8a671392c806.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89128);
			this.ceda6b294518e1db9b1aa8a671392c806.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25576), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25580));
			this.ceda6b294518e1db9b1aa8a671392c806.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25584), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25588));
			this.ceda6b294518e1db9b1aa8a671392c806.SplitterWidth = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25592);
			this.ceda6b294518e1db9b1aa8a671392c806.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25596);
			this.ceda6b294518e1db9b1aa8a671392c806.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25600) != 0);
			this.ceda6b294518e1db9b1aa8a671392c806.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89145);
			this.cda319ea417b6d72e15e4f08944f4e8f2.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.cda319ea417b6d72e15e4f08944f4e8f2.Controls.Add(this.cb890309788bc92be17b6a235de6f886c);
			this.cda319ea417b6d72e15e4f08944f4e8f2.Controls.Add(this.c9f93268106946d0f8f04d9f7de77339a);
			this.cda319ea417b6d72e15e4f08944f4e8f2.Controls.Add(this.c03e15e05f6410711c2d29af150da73bc);
			this.cda319ea417b6d72e15e4f08944f4e8f2.Controls.Add(this.c9202010bbeb5a869433736d6d3edf68b);
			this.cda319ea417b6d72e15e4f08944f4e8f2.Controls.Add(this.c0e1873c97ed5c28183d8a02dcecefe22);
			this.cda319ea417b6d72e15e4f08944f4e8f2.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25604);
			this.cda319ea417b6d72e15e4f08944f4e8f2.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(25608));
			this.cda319ea417b6d72e15e4f08944f4e8f2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25612), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25616));
			this.cda319ea417b6d72e15e4f08944f4e8f2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89162);
			this.cda319ea417b6d72e15e4f08944f4e8f2.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25620);
			this.cda319ea417b6d72e15e4f08944f4e8f2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25624), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25628));
			this.cda319ea417b6d72e15e4f08944f4e8f2.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49381);
			this.cda319ea417b6d72e15e4f08944f4e8f2.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25632);
			this.cb890309788bc92be17b6a235de6f886c.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89187);
			this.cb890309788bc92be17b6a235de6f886c.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25636);
			this.cb890309788bc92be17b6a235de6f886c.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25640);
			this.cb890309788bc92be17b6a235de6f886c.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25644) != 0);
			this.cb890309788bc92be17b6a235de6f886c.Image = c6faa5467be1a4874657b372a49b7c927.icnPlay;
			this.cb890309788bc92be17b6a235de6f886c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25648), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25652));
			this.cb890309788bc92be17b6a235de6f886c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89216);
			this.cb890309788bc92be17b6a235de6f886c.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25656));
			this.cb890309788bc92be17b6a235de6f886c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25660), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25664));
			this.cb890309788bc92be17b6a235de6f886c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25668);
			this.cb890309788bc92be17b6a235de6f886c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89231);
			this.cb890309788bc92be17b6a235de6f886c.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25672);
			this.cb890309788bc92be17b6a235de6f886c.Click += this.cd75e34eb827c4a4c0feef3e62f16a79d;
			this.c9f93268106946d0f8f04d9f7de77339a.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89262);
			this.c9f93268106946d0f8f04d9f7de77339a.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25676);
			this.c9f93268106946d0f8f04d9f7de77339a.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25680);
			this.c9f93268106946d0f8f04d9f7de77339a.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25684) != 0);
			this.c9f93268106946d0f8f04d9f7de77339a.Image = c6faa5467be1a4874657b372a49b7c927.dlc;
			this.c9f93268106946d0f8f04d9f7de77339a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25688), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25692));
			this.c9f93268106946d0f8f04d9f7de77339a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89303);
			this.c9f93268106946d0f8f04d9f7de77339a.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25696));
			this.c9f93268106946d0f8f04d9f7de77339a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25700), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25704));
			this.c9f93268106946d0f8f04d9f7de77339a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25708);
			this.c9f93268106946d0f8f04d9f7de77339a.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89326);
			this.c9f93268106946d0f8f04d9f7de77339a.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25712);
			this.c9f93268106946d0f8f04d9f7de77339a.Click += this.c6118596dd3f8efcb0c76a074fd9eb2d3;
			this.c03e15e05f6410711c2d29af150da73bc.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25716);
			this.c03e15e05f6410711c2d29af150da73bc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25720), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25724));
			this.c03e15e05f6410711c2d29af150da73bc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89367);
			this.c03e15e05f6410711c2d29af150da73bc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25728), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25732));
			this.c03e15e05f6410711c2d29af150da73bc.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25736);
			this.c03e15e05f6410711c2d29af150da73bc.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25740);
			this.c03e15e05f6410711c2d29af150da73bc.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25744) != 0);
			this.c9202010bbeb5a869433736d6d3edf68b.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25748);
			this.c9202010bbeb5a869433736d6d3edf68b.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89390), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(25752), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25756), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25760), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25764));
			this.c9202010bbeb5a869433736d6d3edf68b.IsReadOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25768) != 0);
			this.c9202010bbeb5a869433736d6d3edf68b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25772), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25776));
			this.c9202010bbeb5a869433736d6d3edf68b.Multiline = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25780) != 0);
			this.c9202010bbeb5a869433736d6d3edf68b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89405);
			this.c9202010bbeb5a869433736d6d3edf68b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25784), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25788));
			this.c9202010bbeb5a869433736d6d3edf68b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25792);
			this.c0e1873c97ed5c28183d8a02dcecefe22.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25796);
			this.c0e1873c97ed5c28183d8a02dcecefe22.ImeMode = (ImeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25800);
			this.c0e1873c97ed5c28183d8a02dcecefe22.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25804), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25808));
			this.c0e1873c97ed5c28183d8a02dcecefe22.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89420);
			this.c0e1873c97ed5c28183d8a02dcecefe22.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25812), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25816));
			this.c0e1873c97ed5c28183d8a02dcecefe22.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25820);
			this.c0e1873c97ed5c28183d8a02dcecefe22.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25824);
			this.c0e1873c97ed5c28183d8a02dcecefe22.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25828) != 0);
			this.c0e1873c97ed5c28183d8a02dcecefe22.DoubleClick += this.c4d576329fd7ff68c89940db18c5ea705;
			this.ca094553b15c925802480db99005bd4f2.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25832) != 0);
			this.ca094553b15c925802480db99005bd4f2.Controls.Add(this.cffa2856f157615c723fc0174e0315a48);
			this.ca094553b15c925802480db99005bd4f2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89435);
			this.ca094553b15c925802480db99005bd4f2.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25836), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25840));
			this.ca094553b15c925802480db99005bd4f2.SizeInfo.SizeMode = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25844);
			this.ca094553b15c925802480db99005bd4f2.SplitterWidth = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25848);
			this.cffa2856f157615c723fc0174e0315a48.CanUpdateChildIndex = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25852) != 0);
			this.cffa2856f157615c723fc0174e0315a48.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25856) != 0);
			this.cffa2856f157615c723fc0174e0315a48.Controls.Add(this.cda319ea417b6d72e15e4f08944f4e8f2);
			this.cffa2856f157615c723fc0174e0315a48.Controls.Add(this.c007c0aae2cf1cee4a2629495a37dd783);
			this.cffa2856f157615c723fc0174e0315a48.Controls.Add(this.c3191af20f951facba574896ab849a5b5);
			this.cffa2856f157615c723fc0174e0315a48.Controls.Add(this.ce19c3ed732501121cc7e733f03a750f1);
			this.cffa2856f157615c723fc0174e0315a48.Controls.Add(this.c58e2356c3b19fdffdd0eecbb202437e5);
			this.cffa2856f157615c723fc0174e0315a48.Controls.Add(this.cf60098683d0bc0735fa1599dc81f52fc);
			this.cffa2856f157615c723fc0174e0315a48.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25860), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25864));
			this.cffa2856f157615c723fc0174e0315a48.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89472);
			this.cffa2856f157615c723fc0174e0315a48.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25868), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25872));
			this.cffa2856f157615c723fc0174e0315a48.SelectedIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25876);
			this.cffa2856f157615c723fc0174e0315a48.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25880), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25884));
			this.cffa2856f157615c723fc0174e0315a48.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25888);
			this.cffa2856f157615c723fc0174e0315a48.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25892) != 0);
			this.c007c0aae2cf1cee4a2629495a37dd783.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c007c0aae2cf1cee4a2629495a37dd783.Controls.Add(this.cdc574dc7748c88d6861d4bfabdc95272);
			this.c007c0aae2cf1cee4a2629495a37dd783.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25896);
			this.c007c0aae2cf1cee4a2629495a37dd783.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(25900));
			this.c007c0aae2cf1cee4a2629495a37dd783.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25904), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25908));
			this.c007c0aae2cf1cee4a2629495a37dd783.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89507);
			this.c007c0aae2cf1cee4a2629495a37dd783.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25912);
			this.c007c0aae2cf1cee4a2629495a37dd783.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25916), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25920));
			this.c007c0aae2cf1cee4a2629495a37dd783.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89534);
			this.c007c0aae2cf1cee4a2629495a37dd783.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25924);
			this.cdc574dc7748c88d6861d4bfabdc95272.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25928);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.cc9e45bbdf6ee9b81212ed24a210aab07);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.ce2c7d9939c522d450f3df76cfe177c8f);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.cfcf06297d6af778ba0b09395fc2f7071);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.c0d57030f623a2ce3ac47f346eded8eb2);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.c2578bdf3f76dc6df3ad590d55e5c99e8);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.c9ee36b748e08e7ea591f948c93e868a5);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.c4f35dae606400f2b70610e42660e5131);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.cc8daf5b987048692fcf54da7b699bd9c);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.c93a94181f2cea21a98fefb0ba7e8888b);
			this.cdc574dc7748c88d6861d4bfabdc95272.Controls.Add(this.ca43fdd1563fb00ad7902f923e2ce29db);
			this.cdc574dc7748c88d6861d4bfabdc95272.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25932);
			this.cdc574dc7748c88d6861d4bfabdc95272.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89545);
			this.cdc574dc7748c88d6861d4bfabdc95272.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25940));
			this.cdc574dc7748c88d6861d4bfabdc95272.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89574);
			this.cdc574dc7748c88d6861d4bfabdc95272.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25944));
			this.cdc574dc7748c88d6861d4bfabdc95272.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25948), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25952));
			this.cdc574dc7748c88d6861d4bfabdc95272.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25956);
			this.cdc574dc7748c88d6861d4bfabdc95272.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89545);
			this.cc9e45bbdf6ee9b81212ed24a210aab07.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25960);
			this.cc9e45bbdf6ee9b81212ed24a210aab07.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25964) != 0);
			this.cc9e45bbdf6ee9b81212ed24a210aab07.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25968), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25972));
			this.cc9e45bbdf6ee9b81212ed24a210aab07.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89601);
			this.cc9e45bbdf6ee9b81212ed24a210aab07.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25976), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25980));
			this.cc9e45bbdf6ee9b81212ed24a210aab07.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25984);
			this.cc9e45bbdf6ee9b81212ed24a210aab07.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89616);
			this.ce2c7d9939c522d450f3df76cfe177c8f.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25988) != 0);
			this.ce2c7d9939c522d450f3df76cfe177c8f.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25992);
			this.ce2c7d9939c522d450f3df76cfe177c8f.HorizontalScrollState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(25996);
			this.ce2c7d9939c522d450f3df76cfe177c8f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26000), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26004));
			this.ce2c7d9939c522d450f3df76cfe177c8f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89635);
			this.ce2c7d9939c522d450f3df76cfe177c8f.SelectLastAddedItem = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26008) != 0);
			this.ce2c7d9939c522d450f3df76cfe177c8f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26012), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26016));
			this.ce2c7d9939c522d450f3df76cfe177c8f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26020);
			this.ce2c7d9939c522d450f3df76cfe177c8f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.cfcf06297d6af778ba0b09395fc2f7071.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26024);
			this.cfcf06297d6af778ba0b09395fc2f7071.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26028), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26032));
			this.cfcf06297d6af778ba0b09395fc2f7071.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89660);
			this.cfcf06297d6af778ba0b09395fc2f7071.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26036), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26040));
			this.cfcf06297d6af778ba0b09395fc2f7071.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26044);
			this.cfcf06297d6af778ba0b09395fc2f7071.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26048);
			this.cfcf06297d6af778ba0b09395fc2f7071.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26052) != 0);
			this.c0d57030f623a2ce3ac47f346eded8eb2.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26056);
			this.c0d57030f623a2ce3ac47f346eded8eb2.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26060) != 0);
			this.c0d57030f623a2ce3ac47f346eded8eb2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26064), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26068));
			this.c0d57030f623a2ce3ac47f346eded8eb2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89677);
			this.c0d57030f623a2ce3ac47f346eded8eb2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26072), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26076));
			this.c0d57030f623a2ce3ac47f346eded8eb2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26080);
			this.c0d57030f623a2ce3ac47f346eded8eb2.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(86497);
			this.c2578bdf3f76dc6df3ad590d55e5c99e8.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26084);
			this.c2578bdf3f76dc6df3ad590d55e5c99e8.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26088) != 0);
			this.c2578bdf3f76dc6df3ad590d55e5c99e8.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26096));
			this.c2578bdf3f76dc6df3ad590d55e5c99e8.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47521);
			this.c2578bdf3f76dc6df3ad590d55e5c99e8.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26100), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26104));
			this.c2578bdf3f76dc6df3ad590d55e5c99e8.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26108);
			this.c2578bdf3f76dc6df3ad590d55e5c99e8.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89692);
			this.c9ee36b748e08e7ea591f948c93e868a5.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26112) != 0);
			this.c9ee36b748e08e7ea591f948c93e868a5.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26116);
			this.c9ee36b748e08e7ea591f948c93e868a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26120), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26124));
			this.c9ee36b748e08e7ea591f948c93e868a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89705);
			this.c9ee36b748e08e7ea591f948c93e868a5.SelectLastAddedItem = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26128) != 0);
			this.c9ee36b748e08e7ea591f948c93e868a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26132), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26136));
			this.c9ee36b748e08e7ea591f948c93e868a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26140);
			this.c9ee36b748e08e7ea591f948c93e868a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.c4f35dae606400f2b70610e42660e5131.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26144);
			this.c4f35dae606400f2b70610e42660e5131.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26148), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26152));
			this.c4f35dae606400f2b70610e42660e5131.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89722);
			this.c4f35dae606400f2b70610e42660e5131.ProgressOrientation = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26156);
			this.c4f35dae606400f2b70610e42660e5131.ShowProgressIndicators = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26160) != 0);
			this.c4f35dae606400f2b70610e42660e5131.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26164), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26168));
			this.c4f35dae606400f2b70610e42660e5131.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26172);
			this.c4f35dae606400f2b70610e42660e5131.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43636);
			this.cc8daf5b987048692fcf54da7b699bd9c.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26176) != 0);
			this.cc8daf5b987048692fcf54da7b699bd9c.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26180);
			this.cc8daf5b987048692fcf54da7b699bd9c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26184), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26188));
			this.cc8daf5b987048692fcf54da7b699bd9c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89737);
			this.cc8daf5b987048692fcf54da7b699bd9c.SelectLastAddedItem = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26192) != 0);
			this.cc8daf5b987048692fcf54da7b699bd9c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26196), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26200));
			this.cc8daf5b987048692fcf54da7b699bd9c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26204);
			this.cc8daf5b987048692fcf54da7b699bd9c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.c93a94181f2cea21a98fefb0ba7e8888b.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26208);
			this.c93a94181f2cea21a98fefb0ba7e8888b.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26212) != 0);
			this.c93a94181f2cea21a98fefb0ba7e8888b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26216), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26220));
			this.c93a94181f2cea21a98fefb0ba7e8888b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89766);
			this.c93a94181f2cea21a98fefb0ba7e8888b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26224), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26228));
			this.c93a94181f2cea21a98fefb0ba7e8888b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26232);
			this.c93a94181f2cea21a98fefb0ba7e8888b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89779);
			this.ca43fdd1563fb00ad7902f923e2ce29db.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26236);
			this.ca43fdd1563fb00ad7902f923e2ce29db.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26240) != 0);
			this.ca43fdd1563fb00ad7902f923e2ce29db.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26244), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26248));
			this.ca43fdd1563fb00ad7902f923e2ce29db.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89790);
			this.ca43fdd1563fb00ad7902f923e2ce29db.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26252), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26256));
			this.ca43fdd1563fb00ad7902f923e2ce29db.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26260);
			this.ca43fdd1563fb00ad7902f923e2ce29db.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89803);
			this.c3191af20f951facba574896ab849a5b5.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c3191af20f951facba574896ab849a5b5.Controls.Add(this.cf79908ea7fb179e130decfd49ac2942e);
			this.c3191af20f951facba574896ab849a5b5.Controls.Add(this.cbe7fa4761f85da94859280c8565879f4);
			this.c3191af20f951facba574896ab849a5b5.Controls.Add(this.cb4a1967318bc2f47a2a97d027e20d00f);
			this.c3191af20f951facba574896ab849a5b5.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26264);
			this.c3191af20f951facba574896ab849a5b5.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(26268));
			this.c3191af20f951facba574896ab849a5b5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26272), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26276));
			this.c3191af20f951facba574896ab849a5b5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89848);
			this.c3191af20f951facba574896ab849a5b5.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26280);
			this.c3191af20f951facba574896ab849a5b5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26288));
			this.c3191af20f951facba574896ab849a5b5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89877);
			this.c3191af20f951facba574896ab849a5b5.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26292);
			this.cf79908ea7fb179e130decfd49ac2942e.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26296);
			this.cf79908ea7fb179e130decfd49ac2942e.ImeMode = (ImeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26300);
			this.cf79908ea7fb179e130decfd49ac2942e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26308));
			this.cf79908ea7fb179e130decfd49ac2942e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89900);
			this.cf79908ea7fb179e130decfd49ac2942e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26316));
			this.cf79908ea7fb179e130decfd49ac2942e.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26320);
			this.cf79908ea7fb179e130decfd49ac2942e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26324);
			this.cf79908ea7fb179e130decfd49ac2942e.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26328) != 0);
			this.cbe7fa4761f85da94859280c8565879f4.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26332);
			this.cbe7fa4761f85da94859280c8565879f4.ImeMode = (ImeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26336);
			this.cbe7fa4761f85da94859280c8565879f4.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26344));
			this.cbe7fa4761f85da94859280c8565879f4.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89921);
			this.cbe7fa4761f85da94859280c8565879f4.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26348), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26352));
			this.cbe7fa4761f85da94859280c8565879f4.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26356);
			this.cbe7fa4761f85da94859280c8565879f4.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26360);
			this.cbe7fa4761f85da94859280c8565879f4.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26364) != 0);
			this.cb4a1967318bc2f47a2a97d027e20d00f.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26368);
			this.cb4a1967318bc2f47a2a97d027e20d00f.ImeMode = (ImeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26372);
			this.cb4a1967318bc2f47a2a97d027e20d00f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26376), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26380));
			this.cb4a1967318bc2f47a2a97d027e20d00f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89942);
			this.cb4a1967318bc2f47a2a97d027e20d00f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26384), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26388));
			this.cb4a1967318bc2f47a2a97d027e20d00f.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26392);
			this.cb4a1967318bc2f47a2a97d027e20d00f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26396);
			this.cb4a1967318bc2f47a2a97d027e20d00f.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26400) != 0);
			this.ce19c3ed732501121cc7e733f03a750f1.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.ce19c3ed732501121cc7e733f03a750f1.Controls.Add(this.c967e6f900acf8fed69dd58fc13e618c9);
			this.ce19c3ed732501121cc7e733f03a750f1.Controls.Add(this.ccdf1215dbbeff396ea40c3a50d46f8dc);
			this.ce19c3ed732501121cc7e733f03a750f1.DefaultFloatingSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26404), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26408));
			this.ce19c3ed732501121cc7e733f03a750f1.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26412);
			this.ce19c3ed732501121cc7e733f03a750f1.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(26416));
			this.ce19c3ed732501121cc7e733f03a750f1.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26420), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26424));
			this.ce19c3ed732501121cc7e733f03a750f1.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89963);
			this.ce19c3ed732501121cc7e733f03a750f1.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26428);
			this.ce19c3ed732501121cc7e733f03a750f1.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26432), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26436));
			this.ce19c3ed732501121cc7e733f03a750f1.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89978);
			this.ce19c3ed732501121cc7e733f03a750f1.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26440);
			this.c967e6f900acf8fed69dd58fc13e618c9.AllowWebBrowserDrop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26444) != 0);
			this.c967e6f900acf8fed69dd58fc13e618c9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26448);
			this.c967e6f900acf8fed69dd58fc13e618c9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26452), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26456));
			this.c967e6f900acf8fed69dd58fc13e618c9.MinimumSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26460), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26464));
			this.c967e6f900acf8fed69dd58fc13e618c9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(89999);
			this.c967e6f900acf8fed69dd58fc13e618c9.ScriptErrorsSuppressed = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26468) != 0);
			this.c967e6f900acf8fed69dd58fc13e618c9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26472), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26476));
			this.c967e6f900acf8fed69dd58fc13e618c9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26480);
			this.c967e6f900acf8fed69dd58fc13e618c9.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26484) != 0);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26488);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26492) != 0);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.Controls.Add(this.c3f8308a31f7480c02b875629e4488e2a);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.Controls.Add(this.c99be52e02415fc82eaf415e375961a97);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26496);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90020);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26504));
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90037);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26508), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26512));
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26516);
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90020);
			this.c3f8308a31f7480c02b875629e4488e2a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26520), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26524));
			this.c3f8308a31f7480c02b875629e4488e2a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90062);
			this.c3f8308a31f7480c02b875629e4488e2a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26532));
			this.c3f8308a31f7480c02b875629e4488e2a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26536);
			this.c3f8308a31f7480c02b875629e4488e2a.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90081);
			this.c3f8308a31f7480c02b875629e4488e2a.Click += this.c60cc4d729f0c6d7754e2af0d1babdfeb;
			this.c99be52e02415fc82eaf415e375961a97.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26544));
			this.c99be52e02415fc82eaf415e375961a97.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90084);
			this.c99be52e02415fc82eaf415e375961a97.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26548), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26552));
			this.c99be52e02415fc82eaf415e375961a97.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26556);
			this.c99be52e02415fc82eaf415e375961a97.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90103);
			this.c99be52e02415fc82eaf415e375961a97.Click += this.c9aadbc86d6e2965d6532ff561c9cceb2;
			this.c58e2356c3b19fdffdd0eecbb202437e5.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c58e2356c3b19fdffdd0eecbb202437e5.Controls.Add(this.c81df6c6c9171f63a101b1da4f2500688);
			this.c58e2356c3b19fdffdd0eecbb202437e5.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26560);
			this.c58e2356c3b19fdffdd0eecbb202437e5.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(26564));
			this.c58e2356c3b19fdffdd0eecbb202437e5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26568), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26572));
			this.c58e2356c3b19fdffdd0eecbb202437e5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90106);
			this.c58e2356c3b19fdffdd0eecbb202437e5.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26576);
			this.c58e2356c3b19fdffdd0eecbb202437e5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26580), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26584));
			this.c58e2356c3b19fdffdd0eecbb202437e5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90127);
			this.c58e2356c3b19fdffdd0eecbb202437e5.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26588);
			this.c81df6c6c9171f63a101b1da4f2500688.Controls.Add(this.c74635a9b2ff9984a78057f893291fc48);
			this.c81df6c6c9171f63a101b1da4f2500688.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26592);
			this.c81df6c6c9171f63a101b1da4f2500688.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26596), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26600));
			this.c81df6c6c9171f63a101b1da4f2500688.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90140);
			this.c81df6c6c9171f63a101b1da4f2500688.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26604), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26608));
			this.c81df6c6c9171f63a101b1da4f2500688.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26612);
			this.c81df6c6c9171f63a101b1da4f2500688.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.c74635a9b2ff9984a78057f893291fc48.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26616) != 0);
			this.c74635a9b2ff9984a78057f893291fc48.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26620);
			this.c74635a9b2ff9984a78057f893291fc48.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26624), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26628));
			this.c74635a9b2ff9984a78057f893291fc48.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49704);
			this.c74635a9b2ff9984a78057f893291fc48.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26632), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26636));
			this.c74635a9b2ff9984a78057f893291fc48.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26640);
			this.c74635a9b2ff9984a78057f893291fc48.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90159);
			this.cf60098683d0bc0735fa1599dc81f52fc.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.cf60098683d0bc0735fa1599dc81f52fc.Controls.Add(this.cae387d07ee04501426ac62a7b81ce88f);
			this.cf60098683d0bc0735fa1599dc81f52fc.Controls.Add(this.c11bba70fac0494286e0d3ef67e7108a8);
			this.cf60098683d0bc0735fa1599dc81f52fc.Controls.Add(this.cb88959703fad6c1e125b370dc1b1d628);
			this.cf60098683d0bc0735fa1599dc81f52fc.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26644);
			this.cf60098683d0bc0735fa1599dc81f52fc.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(26648));
			this.cf60098683d0bc0735fa1599dc81f52fc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26652), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26656));
			this.cf60098683d0bc0735fa1599dc81f52fc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90216);
			this.cf60098683d0bc0735fa1599dc81f52fc.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26660);
			this.cf60098683d0bc0735fa1599dc81f52fc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26664), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26668));
			this.cf60098683d0bc0735fa1599dc81f52fc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90247);
			this.cf60098683d0bc0735fa1599dc81f52fc.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26672);
			this.cae387d07ee04501426ac62a7b81ce88f.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26676);
			this.cae387d07ee04501426ac62a7b81ce88f.ForeColor = Color.Red;
			this.cae387d07ee04501426ac62a7b81ce88f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26680), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26684));
			this.cae387d07ee04501426ac62a7b81ce88f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90272);
			this.cae387d07ee04501426ac62a7b81ce88f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26688), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26692));
			this.cae387d07ee04501426ac62a7b81ce88f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26696);
			this.cae387d07ee04501426ac62a7b81ce88f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90291);
			this.c11bba70fac0494286e0d3ef67e7108a8.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26700);
			this.c11bba70fac0494286e0d3ef67e7108a8.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26704);
			this.c11bba70fac0494286e0d3ef67e7108a8.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90300)));
			this.c11bba70fac0494286e0d3ef67e7108a8.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26708), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26712));
			this.c11bba70fac0494286e0d3ef67e7108a8.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90341);
			this.c11bba70fac0494286e0d3ef67e7108a8.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26716));
			this.c11bba70fac0494286e0d3ef67e7108a8.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26720), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26724));
			this.c11bba70fac0494286e0d3ef67e7108a8.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26728);
			this.c11bba70fac0494286e0d3ef67e7108a8.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90370);
			this.c11bba70fac0494286e0d3ef67e7108a8.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26732);
			this.c11bba70fac0494286e0d3ef67e7108a8.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26736);
			this.c11bba70fac0494286e0d3ef67e7108a8.Click += this.ccd62e364815390bbb848c58f7def8ab7;
			this.cb88959703fad6c1e125b370dc1b1d628.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26740);
			this.cb88959703fad6c1e125b370dc1b1d628.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26744);
			this.cb88959703fad6c1e125b370dc1b1d628.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90395)));
			this.cb88959703fad6c1e125b370dc1b1d628.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26748), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26752));
			this.cb88959703fad6c1e125b370dc1b1d628.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90434);
			this.cb88959703fad6c1e125b370dc1b1d628.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26756));
			this.cb88959703fad6c1e125b370dc1b1d628.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26760), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26764));
			this.cb88959703fad6c1e125b370dc1b1d628.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26768);
			this.cb88959703fad6c1e125b370dc1b1d628.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90461);
			this.cb88959703fad6c1e125b370dc1b1d628.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26772);
			this.cb88959703fad6c1e125b370dc1b1d628.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26776);
			this.cb88959703fad6c1e125b370dc1b1d628.Click += this.c684fc3529b79867444efc32a422d8cfe;
			this.ca6c1cea062503a0a580756cf1f1f0961.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26780);
			this.ca6c1cea062503a0a580756cf1f1f0961.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26784) != 0);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c973e711e4ba0b9bf06b636bdbabddad0);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c8d2bc6d98c482abe32079c696410b384);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c68fb0560502ff7bad26efa6cf163c845);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c218e0ce0f7d843f536a409b942e4ca6d);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c8720232fcccea592194b8028025cef8b);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.cb93ef748a37f709d32047aef13f1cb0a);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c874864d6030318b57d3af642035e90e5);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c804e4fd2d6278fa319994b7cce512f68);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c129f9645be9dc9fb646c5432e51db9a5);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c362e39f066aef56acd25812b83e7da57);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c98fc23ab6c8b6356924ad18312dd43db);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c204af998c7bd7e41658b068560e69a22);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c7897cd9c092dc3138c4daed47b35970b);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c47b614ac867932e76ad37c381b0fe8c6);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c3b1862ccc73a74157a0aa2e808890118);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.ca6b7aa9283df8df606f49cc81dbca4d7);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c381071419ced61a1622e530e0c8d1688);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c15d9090b6a70d3a3c645fff30223e3a5);
			this.ca6c1cea062503a0a580756cf1f1f0961.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26788);
			this.ca6c1cea062503a0a580756cf1f1f0961.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90484);
			this.ca6c1cea062503a0a580756cf1f1f0961.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26792), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26796));
			this.ca6c1cea062503a0a580756cf1f1f0961.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48088);
			this.ca6c1cea062503a0a580756cf1f1f0961.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26800), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26804));
			this.ca6c1cea062503a0a580756cf1f1f0961.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26808);
			this.ca6c1cea062503a0a580756cf1f1f0961.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90484);
			this.c973e711e4ba0b9bf06b636bdbabddad0.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26812) != 0);
			this.c973e711e4ba0b9bf06b636bdbabddad0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26816), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26820));
			this.c973e711e4ba0b9bf06b636bdbabddad0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90513);
			this.c973e711e4ba0b9bf06b636bdbabddad0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26824), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26828));
			this.c973e711e4ba0b9bf06b636bdbabddad0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26832);
			this.c973e711e4ba0b9bf06b636bdbabddad0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c973e711e4ba0b9bf06b636bdbabddad0.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26836);
			this.c8d2bc6d98c482abe32079c696410b384.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26840), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26844));
			this.c8d2bc6d98c482abe32079c696410b384.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90552);
			this.c8d2bc6d98c482abe32079c696410b384.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26848), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26852));
			this.c8d2bc6d98c482abe32079c696410b384.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26856);
			this.c8d2bc6d98c482abe32079c696410b384.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69418);
			this.c68fb0560502ff7bad26efa6cf163c845.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26860), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26864));
			this.c68fb0560502ff7bad26efa6cf163c845.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90583);
			this.c68fb0560502ff7bad26efa6cf163c845.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26868), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26872));
			this.c68fb0560502ff7bad26efa6cf163c845.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26876);
			this.c68fb0560502ff7bad26efa6cf163c845.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48113);
			this.c218e0ce0f7d843f536a409b942e4ca6d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26880), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26884));
			this.c218e0ce0f7d843f536a409b942e4ca6d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90620);
			this.c218e0ce0f7d843f536a409b942e4ca6d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26888), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26892));
			this.c218e0ce0f7d843f536a409b942e4ca6d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26896);
			this.c218e0ce0f7d843f536a409b942e4ca6d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48079);
			this.c8720232fcccea592194b8028025cef8b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26900), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26904));
			this.c8720232fcccea592194b8028025cef8b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90653);
			this.c8720232fcccea592194b8028025cef8b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26908), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26912));
			this.c8720232fcccea592194b8028025cef8b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26916);
			this.c8720232fcccea592194b8028025cef8b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69418);
			this.cb93ef748a37f709d32047aef13f1cb0a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26920), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26924));
			this.cb93ef748a37f709d32047aef13f1cb0a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90684);
			this.cb93ef748a37f709d32047aef13f1cb0a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26928), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26932));
			this.cb93ef748a37f709d32047aef13f1cb0a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26936);
			this.cb93ef748a37f709d32047aef13f1cb0a.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90705);
			this.c874864d6030318b57d3af642035e90e5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26940), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26944));
			this.c874864d6030318b57d3af642035e90e5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90752);
			this.c874864d6030318b57d3af642035e90e5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26948), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26952));
			this.c874864d6030318b57d3af642035e90e5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26956);
			this.c874864d6030318b57d3af642035e90e5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90773);
			this.c804e4fd2d6278fa319994b7cce512f68.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26960), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26964));
			this.c804e4fd2d6278fa319994b7cce512f68.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90836);
			this.c804e4fd2d6278fa319994b7cce512f68.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26968), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26972));
			this.c804e4fd2d6278fa319994b7cce512f68.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26976);
			this.c804e4fd2d6278fa319994b7cce512f68.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c129f9645be9dc9fb646c5432e51db9a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26980), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26984));
			this.c129f9645be9dc9fb646c5432e51db9a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62504);
			this.c129f9645be9dc9fb646c5432e51db9a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26988), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26992));
			this.c129f9645be9dc9fb646c5432e51db9a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(26996);
			this.c129f9645be9dc9fb646c5432e51db9a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90861);
			this.c362e39f066aef56acd25812b83e7da57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27000), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27004));
			this.c362e39f066aef56acd25812b83e7da57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42983);
			this.c362e39f066aef56acd25812b83e7da57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27008), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27012));
			this.c362e39f066aef56acd25812b83e7da57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27016);
			this.c362e39f066aef56acd25812b83e7da57.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90878);
			this.c98fc23ab6c8b6356924ad18312dd43db.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27024));
			this.c98fc23ab6c8b6356924ad18312dd43db.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90897);
			this.c98fc23ab6c8b6356924ad18312dd43db.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27028), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27032));
			this.c98fc23ab6c8b6356924ad18312dd43db.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27036);
			this.c98fc23ab6c8b6356924ad18312dd43db.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c204af998c7bd7e41658b068560e69a22.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27040), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27044));
			this.c204af998c7bd7e41658b068560e69a22.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90918);
			this.c204af998c7bd7e41658b068560e69a22.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27048), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27052));
			this.c204af998c7bd7e41658b068560e69a22.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27056);
			this.c204af998c7bd7e41658b068560e69a22.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27064));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27072));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27076);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90939);
			this.c7897cd9c092dc3138c4daed47b35970b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27080), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27084));
			this.c7897cd9c092dc3138c4daed47b35970b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90960);
			this.c7897cd9c092dc3138c4daed47b35970b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27088), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27092));
			this.c7897cd9c092dc3138c4daed47b35970b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27096);
			this.c7897cd9c092dc3138c4daed47b35970b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48113);
			this.c47b614ac867932e76ad37c381b0fe8c6.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27100), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27104));
			this.c47b614ac867932e76ad37c381b0fe8c6.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90997);
			this.c47b614ac867932e76ad37c381b0fe8c6.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27108), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27112));
			this.c47b614ac867932e76ad37c381b0fe8c6.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27116);
			this.c47b614ac867932e76ad37c381b0fe8c6.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48079);
			this.c3b1862ccc73a74157a0aa2e808890118.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27120), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27124));
			this.c3b1862ccc73a74157a0aa2e808890118.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91030);
			this.c3b1862ccc73a74157a0aa2e808890118.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27128), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27132));
			this.c3b1862ccc73a74157a0aa2e808890118.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27136);
			this.c3b1862ccc73a74157a0aa2e808890118.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27140), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27144));
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65350);
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27148), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27152));
			this.ca6b7aa9283df8df606f49cc81dbca4d7.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27156);
			this.ca6b7aa9283df8df606f49cc81dbca4d7.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91057);
			this.c381071419ced61a1622e530e0c8d1688.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27160), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27164));
			this.c381071419ced61a1622e530e0c8d1688.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91084);
			this.c381071419ced61a1622e530e0c8d1688.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27168), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27172));
			this.c381071419ced61a1622e530e0c8d1688.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27176);
			this.c381071419ced61a1622e530e0c8d1688.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27180), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27184));
			this.c15d9090b6a70d3a3c645fff30223e3a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47331);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27188), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27192));
			this.c15d9090b6a70d3a3c645fff30223e3a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27196);
			this.c15d9090b6a70d3a3c645fff30223e3a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91107);
			this.cb0d70167e184f5c28c15730dd468edc2.CanUpdateChildIndex = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27200) != 0);
			this.cb0d70167e184f5c28c15730dd468edc2.Controls.Add(this.c6c532de73864b060a67b00a40a009091);
			this.cb0d70167e184f5c28c15730dd468edc2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27204), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27208));
			this.cb0d70167e184f5c28c15730dd468edc2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91130);
			this.cb0d70167e184f5c28c15730dd468edc2.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27212), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27216));
			this.cb0d70167e184f5c28c15730dd468edc2.SelectedIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27220);
			this.cb0d70167e184f5c28c15730dd468edc2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27224), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27228));
			this.cb0d70167e184f5c28c15730dd468edc2.SizeInfo.AbsoluteSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27232), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27236));
			this.cb0d70167e184f5c28c15730dd468edc2.SizeInfo.SplitterCorrection = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27240), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27244));
			this.cb0d70167e184f5c28c15730dd468edc2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27248);
			this.cb0d70167e184f5c28c15730dd468edc2.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27252) != 0);
			this.c6c532de73864b060a67b00a40a009091.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c6c532de73864b060a67b00a40a009091.Controls.Add(this.c58dec0fd4ceda5728f3fb895644e1c63);
			this.c6c532de73864b060a67b00a40a009091.DefaultFloatingSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27256), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27260));
			this.c6c532de73864b060a67b00a40a009091.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27264);
			this.c6c532de73864b060a67b00a40a009091.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27268));
			this.c6c532de73864b060a67b00a40a009091.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27272), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27276));
			this.c6c532de73864b060a67b00a40a009091.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83315);
			this.c6c532de73864b060a67b00a40a009091.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27280);
			this.c6c532de73864b060a67b00a40a009091.RightToLeft = (RightToLeft)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27284);
			this.c6c532de73864b060a67b00a40a009091.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27288), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27292));
			this.c6c532de73864b060a67b00a40a009091.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(83340);
			this.c6c532de73864b060a67b00a40a009091.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27296);
			this.c58dec0fd4ceda5728f3fb895644e1c63.Controls.Add(this.cee9eb68f8e87aee9d3246553c1d77f82);
			this.c58dec0fd4ceda5728f3fb895644e1c63.Controls.Add(this.c894f9612229ef238e4f9c9e3ae42d770);
			this.c58dec0fd4ceda5728f3fb895644e1c63.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27300);
			this.c58dec0fd4ceda5728f3fb895644e1c63.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27308));
			this.c58dec0fd4ceda5728f3fb895644e1c63.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91157);
			this.c58dec0fd4ceda5728f3fb895644e1c63.SelectedPage = this.cee9eb68f8e87aee9d3246553c1d77f82;
			this.c58dec0fd4ceda5728f3fb895644e1c63.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27316));
			this.c58dec0fd4ceda5728f3fb895644e1c63.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27320);
			this.c58dec0fd4ceda5728f3fb895644e1c63.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91182);
			c059558d2e53120bf2323dbfa6c2de7fd.cd24593c859565ebb8c9faabbc5c75bef(this.c58dec0fd4ceda5728f3fb895644e1c63.GetChildAt(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27324))).StripButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27328);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.c079fc63031b6f053e2045ae7ae07e1b8);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.ca65c4bbf27dcaa72b8d1adc74336c0af);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.c1afd523200a21e6b7132517361aba805);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.cbb0b4fa2ccd34211c18c0710f18f2c81);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.cc88cf84905313ad542b0916fffeca13a);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.c9df3025f0563abbb25d17e41a7657e81);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27332), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27336));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42436);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27344));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43693);
			this.c079fc63031b6f053e2045ae7ae07e1b8.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27348);
			this.c079fc63031b6f053e2045ae7ae07e1b8.Controls.Add(this.c7cb15ecb80bee59937d269db8297ea4b);
			this.c079fc63031b6f053e2045ae7ae07e1b8.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27352);
			this.c079fc63031b6f053e2045ae7ae07e1b8.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91185);
			this.c079fc63031b6f053e2045ae7ae07e1b8.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27356), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27360));
			this.c079fc63031b6f053e2045ae7ae07e1b8.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91216);
			this.c079fc63031b6f053e2045ae7ae07e1b8.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27364), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27368));
			this.c079fc63031b6f053e2045ae7ae07e1b8.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27372);
			this.c079fc63031b6f053e2045ae7ae07e1b8.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91185);
			this.c894f9612229ef238e4f9c9e3ae42d770.Controls.Add(this.c47acf5fcb77b27cd38425547b69e3df9);
			this.c894f9612229ef238e4f9c9e3ae42d770.Controls.Add(this.c9386d302f4616a427d7ea57e8f99a6d9);
			this.c894f9612229ef238e4f9c9e3ae42d770.Controls.Add(this.c26a23c3f9ed64e91c418484270f55fcc);
			this.c894f9612229ef238e4f9c9e3ae42d770.Controls.Add(this.c1bde3fed671b57fd27277d86860af4b4);
			this.c894f9612229ef238e4f9c9e3ae42d770.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27376), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27380));
			this.c894f9612229ef238e4f9c9e3ae42d770.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91229);
			this.c894f9612229ef238e4f9c9e3ae42d770.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27384), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27388));
			this.c894f9612229ef238e4f9c9e3ae42d770.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91262);
			this.c47acf5fcb77b27cd38425547b69e3df9.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27392);
			this.c47acf5fcb77b27cd38425547b69e3df9.Controls.Add(this.c9543becb27e7606550f9caf5bdf6dd21);
			this.c47acf5fcb77b27cd38425547b69e3df9.Controls.Add(this.c792ef639cb88d2161a4888ab19e4d1f3);
			this.c47acf5fcb77b27cd38425547b69e3df9.Controls.Add(this.cf9531a8c30cdd17c740548976f7893c0);
			this.c47acf5fcb77b27cd38425547b69e3df9.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			this.c47acf5fcb77b27cd38425547b69e3df9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27396);
			this.c47acf5fcb77b27cd38425547b69e3df9.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91273);
			this.c47acf5fcb77b27cd38425547b69e3df9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27400), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27404));
			this.c47acf5fcb77b27cd38425547b69e3df9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91294);
			this.c47acf5fcb77b27cd38425547b69e3df9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27408), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27412));
			this.c47acf5fcb77b27cd38425547b69e3df9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27416);
			this.c47acf5fcb77b27cd38425547b69e3df9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91273);
			this.c9543becb27e7606550f9caf5bdf6dd21.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27420), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27424));
			this.c9543becb27e7606550f9caf5bdf6dd21.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91321);
			this.c9543becb27e7606550f9caf5bdf6dd21.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27428), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27432));
			this.c9543becb27e7606550f9caf5bdf6dd21.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27436);
			this.c9543becb27e7606550f9caf5bdf6dd21.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91342);
			this.c792ef639cb88d2161a4888ab19e4d1f3.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27440), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27444), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27448));
			this.c792ef639cb88d2161a4888ab19e4d1f3.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27452), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27456));
			this.c792ef639cb88d2161a4888ab19e4d1f3.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91467);
			this.c792ef639cb88d2161a4888ab19e4d1f3.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27460), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27464));
			this.c792ef639cb88d2161a4888ab19e4d1f3.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27468);
			this.c792ef639cb88d2161a4888ab19e4d1f3.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91494);
			this.c792ef639cb88d2161a4888ab19e4d1f3.ToggleStateChanged += new StateChangedEventHandler(this.cd0d84c91f10ed076a8e182e6a0dcf4ee);
			this.cf9531a8c30cdd17c740548976f7893c0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27472), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27476));
			this.cf9531a8c30cdd17c740548976f7893c0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91529);
			this.cf9531a8c30cdd17c740548976f7893c0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27480), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27484));
			this.cf9531a8c30cdd17c740548976f7893c0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27488);
			this.cf9531a8c30cdd17c740548976f7893c0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91550);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27492), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27496));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27504));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27508);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91665);
			this.c9386d302f4616a427d7ea57e8f99a6d9.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27512);
			this.c9386d302f4616a427d7ea57e8f99a6d9.Controls.Add(this.c73a9fa38c32073af376cb816c1f090ff);
			this.c9386d302f4616a427d7ea57e8f99a6d9.Controls.Add(this.c7bab6db345839f9cf49d38f3cb6052bd);
			this.c9386d302f4616a427d7ea57e8f99a6d9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27516);
			this.c9386d302f4616a427d7ea57e8f99a6d9.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91807);
			this.c9386d302f4616a427d7ea57e8f99a6d9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27520), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27524));
			this.c9386d302f4616a427d7ea57e8f99a6d9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91848);
			this.c9386d302f4616a427d7ea57e8f99a6d9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27532));
			this.c9386d302f4616a427d7ea57e8f99a6d9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27536);
			this.c9386d302f4616a427d7ea57e8f99a6d9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91807);
			this.c26a23c3f9ed64e91c418484270f55fcc.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27540) != 0);
			this.c26a23c3f9ed64e91c418484270f55fcc.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27544);
			this.c26a23c3f9ed64e91c418484270f55fcc.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27548), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27552), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27556), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27560));
			this.c26a23c3f9ed64e91c418484270f55fcc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27564), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27568));
			this.c26a23c3f9ed64e91c418484270f55fcc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43654);
			this.c26a23c3f9ed64e91c418484270f55fcc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27572), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27576));
			this.c26a23c3f9ed64e91c418484270f55fcc.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27580);
			this.c26a23c3f9ed64e91c418484270f55fcc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91875);
			this.c26a23c3f9ed64e91c418484270f55fcc.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27584);
			this.c1bde3fed671b57fd27277d86860af4b4.BackColor = Color.White;
			this.c1bde3fed671b57fd27277d86860af4b4.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27588) != 0);
			this.c1bde3fed671b57fd27277d86860af4b4.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27592);
			RadItemCollection items = this.c1bde3fed671b57fd27277d86860af4b4.Items;
			RadItem[] array4 = c3a8284beade9d83b57fa5dda3b4c8767.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27596));
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27600)] = this.c5ee538c657dedc06e93850b6ffbbd1a8;
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27604)] = this.c1aea5f84fd6633c457c8188e0a4cb66d;
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27608)] = this.c699a8df7a1718523a4d403193e720975;
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27612)] = this.ce9f9a0ea862f54052f446c5db845d608;
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27616)] = this.c916dbf43fc7aaf3f0148c42b0a7171f7;
			items.AddRange(array4);
			this.c1bde3fed671b57fd27277d86860af4b4.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27620), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27624));
			this.c1bde3fed671b57fd27277d86860af4b4.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91892);
			this.c1bde3fed671b57fd27277d86860af4b4.RangeEnd = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(27628);
			this.c1bde3fed671b57fd27277d86860af4b4.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27636), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27640));
			this.c1bde3fed671b57fd27277d86860af4b4.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27644);
			this.c1bde3fed671b57fd27277d86860af4b4.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91913);
			this.c1bde3fed671b57fd27277d86860af4b4.Value = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27648);
			this.c5ee538c657dedc06e93850b6ffbbd1a8.BackColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27652), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27656), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27660));
			this.c5ee538c657dedc06e93850b6ffbbd1a8.BackColor2 = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27664), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27668), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27672));
			this.c5ee538c657dedc06e93850b6ffbbd1a8.BindEndRange = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27676) != 0);
			this.c5ee538c657dedc06e93850b6ffbbd1a8.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91944);
			this.c5ee538c657dedc06e93850b6ffbbd1a8.Radius = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(27680);
			this.c5ee538c657dedc06e93850b6ffbbd1a8.RangeEnd = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(27688);
			this.c5ee538c657dedc06e93850b6ffbbd1a8.Width = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(27696);
			this.c1aea5f84fd6633c457c8188e0a4cb66d.BackColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27704), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27708), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27712));
			this.c1aea5f84fd6633c457c8188e0a4cb66d.BackColor2 = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27716), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27720), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27724));
			this.c1aea5f84fd6633c457c8188e0a4cb66d.BindStartRange = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27728) != 0);
			this.c1aea5f84fd6633c457c8188e0a4cb66d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(91975);
			this.c1aea5f84fd6633c457c8188e0a4cb66d.Radius = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(27732);
			this.c1aea5f84fd6633c457c8188e0a4cb66d.RangeEnd = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(27740);
			this.c1aea5f84fd6633c457c8188e0a4cb66d.Width = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(27748);
			this.c699a8df7a1718523a4d403193e720975.DrawText = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27756) != 0);
			this.c699a8df7a1718523a4d403193e720975.LabelFontSize = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27760);
			this.c699a8df7a1718523a4d403193e720975.LabelRadiusPercentage = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27764);
			this.c699a8df7a1718523a4d403193e720975.LabelsCount = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27768);
			this.c699a8df7a1718523a4d403193e720975.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92006);
			this.ce9f9a0ea862f54052f446c5db845d608.CircleTicks = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27772) != 0);
			this.ce9f9a0ea862f54052f446c5db845d608.DrawText = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27776) != 0);
			this.ce9f9a0ea862f54052f446c5db845d608.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92043);
			this.ce9f9a0ea862f54052f446c5db845d608.TickColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27784), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27788));
			this.ce9f9a0ea862f54052f446c5db845d608.TicksCount = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27792);
			this.ce9f9a0ea862f54052f446c5db845d608.TicksLenghtPercentage = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27796);
			this.ce9f9a0ea862f54052f446c5db845d608.TicksOffset = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27800);
			this.ce9f9a0ea862f54052f446c5db845d608.TicksRadiusPercentage = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27804);
			this.ce9f9a0ea862f54052f446c5db845d608.TickThickness = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27808);
			this.c916dbf43fc7aaf3f0148c42b0a7171f7.BindValue = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27812) != 0);
			this.c916dbf43fc7aaf3f0148c42b0a7171f7.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27816), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27820), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27824));
			this.c916dbf43fc7aaf3f0148c42b0a7171f7.LabelText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(77192);
			this.c916dbf43fc7aaf3f0148c42b0a7171f7.LocationPercentage = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27828), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27832));
			this.c916dbf43fc7aaf3f0148c42b0a7171f7.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92078);
			this.c3e55eccc22a105d650a95dea151c61b6.CanUpdateChildIndex = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27836) != 0);
			this.c3e55eccc22a105d650a95dea151c61b6.Controls.Add(this.cffa7e6b0340f88d9369da7a34ef65631);
			this.c3e55eccc22a105d650a95dea151c61b6.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27840), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27844));
			this.c3e55eccc22a105d650a95dea151c61b6.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92125);
			this.c3e55eccc22a105d650a95dea151c61b6.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27848), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27852));
			this.c3e55eccc22a105d650a95dea151c61b6.SelectedIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27856);
			this.c3e55eccc22a105d650a95dea151c61b6.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27860), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27864));
			this.c3e55eccc22a105d650a95dea151c61b6.SizeInfo.AbsoluteSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27868), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27872));
			this.c3e55eccc22a105d650a95dea151c61b6.SizeInfo.SplitterCorrection = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27876), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27880));
			this.c3e55eccc22a105d650a95dea151c61b6.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27884);
			this.c3e55eccc22a105d650a95dea151c61b6.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27888) != 0);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.CanUpdateChildIndex = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27892) != 0);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.CausesValidation = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27896) != 0);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.Controls.Add(this.c3c76741a19a037775bafe388a8df4e2c);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.Controls.Add(this.ce6b37312f4b81e855d0cdd0d77839251);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.Controls.Add(this.c71a1b4cbd86109c91a0a8ea0d53e0b78);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27900), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27904));
			this.c54d116beac1eab6bafbc29b67aa5a8c4.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92152);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.RootElement.MinSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27908), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27912));
			this.c54d116beac1eab6bafbc29b67aa5a8c4.SelectedIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27916);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27920), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27924));
			this.c54d116beac1eab6bafbc29b67aa5a8c4.SizeInfo.AbsoluteSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27928), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27932));
			this.c54d116beac1eab6bafbc29b67aa5a8c4.SizeInfo.SplitterCorrection = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27940));
			this.c54d116beac1eab6bafbc29b67aa5a8c4.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27944);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27948) != 0);
			this.c3c76741a19a037775bafe388a8df4e2c.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c3c76741a19a037775bafe388a8df4e2c.Controls.Add(this.c6731bd6914a59a695a058df2d9c821b2);
			this.c3c76741a19a037775bafe388a8df4e2c.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27952);
			this.c3c76741a19a037775bafe388a8df4e2c.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(27956));
			this.c3c76741a19a037775bafe388a8df4e2c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27960), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27964));
			this.c3c76741a19a037775bafe388a8df4e2c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92179);
			this.c3c76741a19a037775bafe388a8df4e2c.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27968);
			this.c3c76741a19a037775bafe388a8df4e2c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27972), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27976));
			this.c3c76741a19a037775bafe388a8df4e2c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(90020);
			this.c3c76741a19a037775bafe388a8df4e2c.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27980);
			this.c6731bd6914a59a695a058df2d9c821b2.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27984) != 0);
			this.c6731bd6914a59a695a058df2d9c821b2.Controls.Add(this.c2178d80825cd9ab2c18a9dcd6884ee14);
			this.c6731bd6914a59a695a058df2d9c821b2.Controls.Add(this.cbbad8dfe2b75a2868b9ac41cb6fb62b7);
			this.c6731bd6914a59a695a058df2d9c821b2.Controls.Add(this.cecf676325d3b342f93a03b1b9170b253);
			this.c6731bd6914a59a695a058df2d9c821b2.Controls.Add(this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d);
			this.c6731bd6914a59a695a058df2d9c821b2.Controls.Add(this.c44272853dcc0c97ee7511d3b33f129b2);
			this.c6731bd6914a59a695a058df2d9c821b2.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27988);
			this.c6731bd6914a59a695a058df2d9c821b2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27992), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(27996));
			this.c6731bd6914a59a695a058df2d9c821b2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92202);
			this.c6731bd6914a59a695a058df2d9c821b2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28000), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28004));
			this.c6731bd6914a59a695a058df2d9c821b2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28008);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92221);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28012);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28016);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92248)));
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28024));
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92291);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28028));
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28032), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28036));
			this.c2178d80825cd9ab2c18a9dcd6884ee14.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28040);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92221);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28044);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28048);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.Click += this.cbe6a82acf5234fe320a0119d8147877c;
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92322);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28052);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28056);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Image = c6faa5467be1a4874657b372a49b7c927.icnTicket;
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28064));
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92369);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28068));
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28072), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28076));
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28080);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92322);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28084);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28088);
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.Click += this.c2d862b0ed0ee9ed3261c13f0f6e20ce7;
			this.cecf676325d3b342f93a03b1b9170b253.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92400);
			this.cecf676325d3b342f93a03b1b9170b253.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28092);
			this.cecf676325d3b342f93a03b1b9170b253.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28096);
			this.cecf676325d3b342f93a03b1b9170b253.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92445)));
			this.cecf676325d3b342f93a03b1b9170b253.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28100), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28104));
			this.cecf676325d3b342f93a03b1b9170b253.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92488);
			this.cecf676325d3b342f93a03b1b9170b253.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28108));
			this.cecf676325d3b342f93a03b1b9170b253.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28112), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28116));
			this.cecf676325d3b342f93a03b1b9170b253.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28120);
			this.cecf676325d3b342f93a03b1b9170b253.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92400);
			this.cecf676325d3b342f93a03b1b9170b253.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28124);
			this.cecf676325d3b342f93a03b1b9170b253.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28128);
			this.cecf676325d3b342f93a03b1b9170b253.Click += this.c7fe14ddf04f7ee8e583bf37990fec9e2;
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92519);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28132);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28136);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92568)));
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28140), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28144));
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92619);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28148));
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28152), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28156));
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28160);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92519);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28164);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28168);
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.Click += this.ce2e1ec9350d6e598880368b32a4cc937;
			this.c44272853dcc0c97ee7511d3b33f129b2.AccessibleName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92658);
			this.c44272853dcc0c97ee7511d3b33f129b2.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28172);
			this.c44272853dcc0c97ee7511d3b33f129b2.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28176);
			this.c44272853dcc0c97ee7511d3b33f129b2.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28180) != 0);
			this.c44272853dcc0c97ee7511d3b33f129b2.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92693)));
			this.c44272853dcc0c97ee7511d3b33f129b2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28184), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28188));
			this.c44272853dcc0c97ee7511d3b33f129b2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92734);
			this.c44272853dcc0c97ee7511d3b33f129b2.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28192));
			this.c44272853dcc0c97ee7511d3b33f129b2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28196), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28200));
			this.c44272853dcc0c97ee7511d3b33f129b2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28204);
			this.c44272853dcc0c97ee7511d3b33f129b2.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92763);
			this.c44272853dcc0c97ee7511d3b33f129b2.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28208);
			this.c44272853dcc0c97ee7511d3b33f129b2.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28212);
			this.c44272853dcc0c97ee7511d3b33f129b2.Click += this.c110b1e19b2f4e6f0da5b732697a3e834;
			this.ce6b37312f4b81e855d0cdd0d77839251.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.ce6b37312f4b81e855d0cdd0d77839251.Controls.Add(this.c05e314fec562b708421366d517bc1760);
			this.ce6b37312f4b81e855d0cdd0d77839251.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28216);
			this.ce6b37312f4b81e855d0cdd0d77839251.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(28220));
			this.ce6b37312f4b81e855d0cdd0d77839251.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28224), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28228));
			this.ce6b37312f4b81e855d0cdd0d77839251.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92800);
			this.ce6b37312f4b81e855d0cdd0d77839251.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28232);
			this.ce6b37312f4b81e855d0cdd0d77839251.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28236), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28240));
			this.ce6b37312f4b81e855d0cdd0d77839251.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92823);
			this.ce6b37312f4b81e855d0cdd0d77839251.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28244);
			this.c05e314fec562b708421366d517bc1760.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28248) != 0);
			this.c05e314fec562b708421366d517bc1760.Controls.Add(this.c9188c69fd7c8eaf15dce43ea16f40d88);
			this.c05e314fec562b708421366d517bc1760.Controls.Add(this.c8c4836eaf51bf51ad4029bcfa65e3070);
			this.c05e314fec562b708421366d517bc1760.Controls.Add(this.c024a788ba27b0be6afa45229820c2905);
			this.c05e314fec562b708421366d517bc1760.Controls.Add(this.c76617ddf050ef873ce43173d73fd39fb);
			this.c05e314fec562b708421366d517bc1760.Controls.Add(this.cfac791f2ebab9d5414b01ffa03f31c07);
			this.c05e314fec562b708421366d517bc1760.Controls.Add(this.c0b3afb12bff80cf464a5e9a17f791e36);
			this.c05e314fec562b708421366d517bc1760.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28252);
			this.c05e314fec562b708421366d517bc1760.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28256), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28260));
			this.c05e314fec562b708421366d517bc1760.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92852);
			this.c05e314fec562b708421366d517bc1760.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28264), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28268));
			this.c05e314fec562b708421366d517bc1760.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28272);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28276);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28280);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92871)));
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28288));
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92904);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28292));
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28296), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28300));
			this.c9188c69fd7c8eaf15dce43ea16f40d88.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28304);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92925);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28308);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28312);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.Click += this.c939d28c93745c95d3b5bf3ac112a96c8;
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28316);
			this.c8c4836eaf51bf51ad4029bcfa65e3070.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28320);
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92942)));
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28324), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28328));
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(92983);
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28332));
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28336), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28340));
			this.c8c4836eaf51bf51ad4029bcfa65e3070.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28344);
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93012);
			this.c8c4836eaf51bf51ad4029bcfa65e3070.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28348);
			this.c8c4836eaf51bf51ad4029bcfa65e3070.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28352);
			this.c8c4836eaf51bf51ad4029bcfa65e3070.Click += this.cc692586b9a07cbb247e4552d99de7046;
			this.c024a788ba27b0be6afa45229820c2905.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28356);
			this.c024a788ba27b0be6afa45229820c2905.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28360);
			this.c024a788ba27b0be6afa45229820c2905.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28364) != 0);
			this.c024a788ba27b0be6afa45229820c2905.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93039)));
			this.c024a788ba27b0be6afa45229820c2905.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28368), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28372));
			this.c024a788ba27b0be6afa45229820c2905.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93072);
			this.c024a788ba27b0be6afa45229820c2905.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28376));
			this.c024a788ba27b0be6afa45229820c2905.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28380), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28384));
			this.c024a788ba27b0be6afa45229820c2905.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28388);
			this.c024a788ba27b0be6afa45229820c2905.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93093);
			this.c024a788ba27b0be6afa45229820c2905.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28392);
			this.c024a788ba27b0be6afa45229820c2905.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28396);
			this.c024a788ba27b0be6afa45229820c2905.Click += this.c467b2fc7bb773f6709802a939045b730;
			this.c76617ddf050ef873ce43173d73fd39fb.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28400);
			this.c76617ddf050ef873ce43173d73fd39fb.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28404);
			this.c76617ddf050ef873ce43173d73fd39fb.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93108)));
			this.c76617ddf050ef873ce43173d73fd39fb.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28408), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28412));
			this.c76617ddf050ef873ce43173d73fd39fb.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93149);
			this.c76617ddf050ef873ce43173d73fd39fb.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28416));
			this.c76617ddf050ef873ce43173d73fd39fb.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28420), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28424));
			this.c76617ddf050ef873ce43173d73fd39fb.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28428);
			this.c76617ddf050ef873ce43173d73fd39fb.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93178);
			this.c76617ddf050ef873ce43173d73fd39fb.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28432);
			this.c76617ddf050ef873ce43173d73fd39fb.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28436);
			this.c76617ddf050ef873ce43173d73fd39fb.Click += this.c00d6c996c548514fc38ac4b99fe3c27c;
			this.cfac791f2ebab9d5414b01ffa03f31c07.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28440);
			this.cfac791f2ebab9d5414b01ffa03f31c07.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28444);
			this.cfac791f2ebab9d5414b01ffa03f31c07.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93205)));
			this.cfac791f2ebab9d5414b01ffa03f31c07.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28448), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28452));
			this.cfac791f2ebab9d5414b01ffa03f31c07.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93250);
			this.cfac791f2ebab9d5414b01ffa03f31c07.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28456));
			this.cfac791f2ebab9d5414b01ffa03f31c07.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28460), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28464));
			this.cfac791f2ebab9d5414b01ffa03f31c07.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28468);
			this.cfac791f2ebab9d5414b01ffa03f31c07.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93283);
			this.cfac791f2ebab9d5414b01ffa03f31c07.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28472);
			this.cfac791f2ebab9d5414b01ffa03f31c07.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28476);
			this.cfac791f2ebab9d5414b01ffa03f31c07.Click += this.c1eb40e45ebf05c87479967d92c9ec46b;
			this.c0b3afb12bff80cf464a5e9a17f791e36.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28480);
			this.c0b3afb12bff80cf464a5e9a17f791e36.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28484);
			this.c0b3afb12bff80cf464a5e9a17f791e36.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93314)));
			this.c0b3afb12bff80cf464a5e9a17f791e36.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28488), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28492));
			this.c0b3afb12bff80cf464a5e9a17f791e36.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93353);
			this.c0b3afb12bff80cf464a5e9a17f791e36.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28496));
			this.c0b3afb12bff80cf464a5e9a17f791e36.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28504));
			this.c0b3afb12bff80cf464a5e9a17f791e36.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28508);
			this.c0b3afb12bff80cf464a5e9a17f791e36.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93380);
			this.c0b3afb12bff80cf464a5e9a17f791e36.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28512);
			this.c0b3afb12bff80cf464a5e9a17f791e36.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28516);
			this.c0b3afb12bff80cf464a5e9a17f791e36.Click += this.c1c9ad4b0ea487c500c73ad7001b2405a;
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.Caption = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.Controls.Add(this.cbec87db2de27d1830a4fdb08e4b15303);
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.DocumentButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28520);
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(28524));
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28532));
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93413);
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.PreviousDockState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28536);
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28544));
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93436);
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.ToolCaptionButtons = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28548);
			this.cbec87db2de27d1830a4fdb08e4b15303.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28552) != 0);
			this.cbec87db2de27d1830a4fdb08e4b15303.Controls.Add(this.c644e6368b8418e14b419ec82c299f737);
			this.cbec87db2de27d1830a4fdb08e4b15303.Controls.Add(this.cf5d79d3392d0d6eaf324b0a5f5056bcf);
			this.cbec87db2de27d1830a4fdb08e4b15303.Controls.Add(this.c4bc6833c750722a6e897796adbb7c79c);
			this.cbec87db2de27d1830a4fdb08e4b15303.Controls.Add(this.cb09b86c1fbedefa3ac5a95cfddb64e3b);
			this.cbec87db2de27d1830a4fdb08e4b15303.Controls.Add(this.cbbbc92bbbc47247d382886e66cbe134e);
			this.cbec87db2de27d1830a4fdb08e4b15303.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28556);
			this.cbec87db2de27d1830a4fdb08e4b15303.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28560), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28564));
			this.cbec87db2de27d1830a4fdb08e4b15303.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93447);
			this.cbec87db2de27d1830a4fdb08e4b15303.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28568), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28572));
			this.cbec87db2de27d1830a4fdb08e4b15303.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28576);
			this.c644e6368b8418e14b419ec82c299f737.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28580);
			this.c644e6368b8418e14b419ec82c299f737.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28584);
			this.c644e6368b8418e14b419ec82c299f737.Image = c6faa5467be1a4874657b372a49b7c927.path3;
			this.c644e6368b8418e14b419ec82c299f737.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28588), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28592));
			this.c644e6368b8418e14b419ec82c299f737.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93466);
			this.c644e6368b8418e14b419ec82c299f737.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28596));
			this.c644e6368b8418e14b419ec82c299f737.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28600), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28604));
			this.c644e6368b8418e14b419ec82c299f737.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28608);
			this.c644e6368b8418e14b419ec82c299f737.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93483);
			this.c644e6368b8418e14b419ec82c299f737.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28612);
			this.c644e6368b8418e14b419ec82c299f737.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28616);
			this.c644e6368b8418e14b419ec82c299f737.Click += this.c37f2415d586dd1e5bba1923ca88250e1;
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28620);
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28624);
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93504)));
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28628), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28632));
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93543);
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28636));
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28640), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28644));
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28648);
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93570);
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28652);
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28656);
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.Click += this.c25c7c79e0dbbc3cd5d073f5e0141bca0;
			this.c4bc6833c750722a6e897796adbb7c79c.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28660);
			this.c4bc6833c750722a6e897796adbb7c79c.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28664);
			this.c4bc6833c750722a6e897796adbb7c79c.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93611)));
			this.c4bc6833c750722a6e897796adbb7c79c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28668), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28672));
			this.c4bc6833c750722a6e897796adbb7c79c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93654);
			this.c4bc6833c750722a6e897796adbb7c79c.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28676));
			this.c4bc6833c750722a6e897796adbb7c79c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28680), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28684));
			this.c4bc6833c750722a6e897796adbb7c79c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28688);
			this.c4bc6833c750722a6e897796adbb7c79c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93685);
			this.c4bc6833c750722a6e897796adbb7c79c.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28692);
			this.c4bc6833c750722a6e897796adbb7c79c.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28696);
			this.c4bc6833c750722a6e897796adbb7c79c.Click += this.c2cc49f6b986ba13f09446e8d35411d25;
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28700);
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28704);
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93712)));
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28708), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28712));
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93753);
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28716));
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28720), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28724));
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28728);
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93782);
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28732);
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28736);
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.Click += this.cc2a1f57bc16b4bcf52c3c192348e0138;
			this.cbbbc92bbbc47247d382886e66cbe134e.Anchor = (AnchorStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28740);
			this.cbbbc92bbbc47247d382886e66cbe134e.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28744);
			this.cbbbc92bbbc47247d382886e66cbe134e.Image = ca6e34a5383a8565e533c4418201e12dd.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93807)));
			this.cbbbc92bbbc47247d382886e66cbe134e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28748), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28752));
			this.cbbbc92bbbc47247d382886e66cbe134e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93848);
			this.cbbbc92bbbc47247d382886e66cbe134e.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28756));
			this.cbbbc92bbbc47247d382886e66cbe134e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28760), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28764));
			this.cbbbc92bbbc47247d382886e66cbe134e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28768);
			this.cbbbc92bbbc47247d382886e66cbe134e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93877);
			this.cbbbc92bbbc47247d382886e66cbe134e.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28772);
			this.cbbbc92bbbc47247d382886e66cbe134e.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28776);
			this.cbbbc92bbbc47247d382886e66cbe134e.Click += this.ce0c813ae5c7eb54e61cc1a68c344545f;
			RadItemCollection items2 = this.cd454afeeb1c83386a9b8902a8439978e.Items;
			RadItem[] array5 = c3a8284beade9d83b57fa5dda3b4c8767.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28780));
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28784)] = this.cb3dc29b65c72a11c969484cf0866c7be;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28788)] = this.c7453b0e9791e5c45a84a845d8794227d;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28792)] = this.cbb443da1d1aa99f7840f31f118e97f4f;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28796)] = this.ca37fea2b0a0ec984ab56530130949795;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28800)] = this.c163902e6bdd8bcfb3dbca9008354fb43;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28804)] = this.c8fd7fc32e0c93a70bfee119de0883219;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28808)] = this.cff967d75cf03cf4d5c9b5233a561f33c;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28812)] = this.cd111a8d957d26fad50953d63cca2d714;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28816)] = this.c5f880f9d0456e05bb289f7acd4a88315;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28820)] = this.ca3bf14633756b73f7289598debc2742c;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28824)] = this.c95472e45e18203ec5db262009ed54799;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28828)] = this.cd90b4bdf15f292928e266702461954cd;
			items2.AddRange(array5);
			this.cb3dc29b65c72a11c969484cf0866c7be.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93902);
			this.cb3dc29b65c72a11c969484cf0866c7be.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93923);
			this.c7453b0e9791e5c45a84a845d8794227d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93956);
			this.c7453b0e9791e5c45a84a845d8794227d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(93981);
			this.cbb443da1d1aa99f7840f31f118e97f4f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94012);
			this.cbb443da1d1aa99f7840f31f118e97f4f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94031);
			this.ca37fea2b0a0ec984ab56530130949795.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94056);
			this.ca37fea2b0a0ec984ab56530130949795.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(84667);
			this.c163902e6bdd8bcfb3dbca9008354fb43.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94073);
			this.c163902e6bdd8bcfb3dbca9008354fb43.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49994);
			this.c8fd7fc32e0c93a70bfee119de0883219.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94094);
			this.c8fd7fc32e0c93a70bfee119de0883219.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94125);
			this.cff967d75cf03cf4d5c9b5233a561f33c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94160);
			this.cff967d75cf03cf4d5c9b5233a561f33c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94199);
			this.cd111a8d957d26fad50953d63cca2d714.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94242);
			this.cd111a8d957d26fad50953d63cca2d714.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94261);
			this.c5f880f9d0456e05bb289f7acd4a88315.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94320);
			this.c5f880f9d0456e05bb289f7acd4a88315.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94337);
			this.ca3bf14633756b73f7289598debc2742c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94346);
			this.ca3bf14633756b73f7289598debc2742c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94373);
			this.c95472e45e18203ec5db262009ed54799.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94416);
			this.c95472e45e18203ec5db262009ed54799.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94443);
			this.cd90b4bdf15f292928e266702461954cd.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94486);
			this.cd90b4bdf15f292928e266702461954cd.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94511);
			this.c140aadf765c4d07d6ee3fccbfde7124c.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28832);
			this.c140aadf765c4d07d6ee3fccbfde7124c.Tick += this.c508f49cabf39151edc36d47c2315637b;
			this.cbd120a78c4a62a94400d69af3d3fc776.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28836) != 0);
			this.cbd120a78c4a62a94400d69af3d3fc776.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28840);
			this.cbd120a78c4a62a94400d69af3d3fc776.Tick += this.ca8fb93f9f85cf180016d71fb0715e1b8;
			this.c803b89929a29613f5751f6463377a31b.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28844);
			this.c803b89929a29613f5751f6463377a31b.Tick += this.c03c403525214a1ccc261589c0d641a8f;
			this.ce9e5aa178e2af36d04f863bccc94f85b.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28848) != 0);
			this.ce9e5aa178e2af36d04f863bccc94f85b.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28852);
			this.ce9e5aa178e2af36d04f863bccc94f85b.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47290), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(28856), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28860), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28864), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28868));
			this.ce9e5aa178e2af36d04f863bccc94f85b.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28872), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28876), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28880));
			this.ce9e5aa178e2af36d04f863bccc94f85b.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28884), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28888));
			this.ce9e5aa178e2af36d04f863bccc94f85b.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94590);
			this.ce9e5aa178e2af36d04f863bccc94f85b.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28892), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28896));
			this.ce9e5aa178e2af36d04f863bccc94f85b.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28900);
			this.ce9e5aa178e2af36d04f863bccc94f85b.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94609);
			this.ce9e5aa178e2af36d04f863bccc94f85b.UseMnemonic = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28904) != 0);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(28908), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(28912));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28916);
			base.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28920) != 0);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28924), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28928));
			base.Controls.Add(this.ced92a8662e50218f546ae6bb0a312b4f);
			base.Controls.Add(this.ce9e5aa178e2af36d04f863bccc94f85b);
			this.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28932), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28940));
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.KeyPreview = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28944) != 0);
			this.MinimumSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28948), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28952));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94811);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28956) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28960);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94840);
			base.FormClosing += this.c7193231abd62b0b8353859ca7c98332e;
			base.Load += this.c15bca37ae5115bafce5fc70ebfd7dcd4;
			this.c90fe97b27e47a56fbdfb26d97ff3fbe0.EndInit();
			this.cf6348eb630c0b01e77b8f83ec7151d96.EndInit();
			this.c92ab20cb1038469a6ddf6e1b4c5d8d5c.EndInit();
			this.c2fb6dd895d1ff7ecd48bea8f8087cbe2.EndInit();
			this.c15cfb8d25fc93dd1b55a4ea47493c187.EndInit();
			this.cde07a8d8f3fe5ea1f59833c2ca019b46.EndInit();
			this.c06f4d49c4cd7969e514a4b3649e010c9.EndInit();
			this.c9df3025f0563abbb25d17e41a7657e81.EndInit();
			this.c9df3025f0563abbb25d17e41a7657e81.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28964) != 0);
			this.c9df3025f0563abbb25d17e41a7657e81.PerformLayout();
			this.c5387a02757dbf6c1f7add91e8f83a37d.EndInit();
			this.c49e0e1006d938106f4f6b78dc1a9fbe9.EndInit();
			this.c9cab24920274230a73629880e3d2f54d.EndInit();
			this.c3e2b0edd5c4db8fcb6c60a419bd93842.EndInit();
			this.c15ef48f6d131106befa105251dceaed9.EndInit();
			this.ce77148f56a941930515ae05ee4a8abba.EndInit();
			this.c69103ed6bfb59dc17e3aed75cdbe979d.EndInit();
			this.cef9cf59a04a9a091015a8a429a716577.EndInit();
			this.c727375dbbb6f023ed693138c5ee33ab6.EndInit();
			this.c99bd3ea85b6a1aa87f929de1fca32ff1.EndInit();
			this.c1afd523200a21e6b7132517361aba805.EndInit();
			this.c1afd523200a21e6b7132517361aba805.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28968) != 0);
			this.c1afd523200a21e6b7132517361aba805.PerformLayout();
			this.c13964aec72502e7656b1ae19a819aff9.EndInit();
			this.c271cb122814a1639c9b4c33232d68a4b.EndInit();
			this.c73a9fa38c32073af376cb816c1f090ff.EndInit();
			this.c7bab6db345839f9cf49d38f3cb6052bd.EndInit();
			this.ca65c4bbf27dcaa72b8d1adc74336c0af.EndInit();
			this.c7cb15ecb80bee59937d269db8297ea4b.EndInit();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.EndInit();
			this.c1fbb1a3b10ef0c49ba689bd6ae606d29.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28972) != 0);
			this.ceed5d76836a72a0a0356175e703e6aa6.EndInit();
			this.cff69c812b578b7c94cbd35be243af026.EndInit();
			this.c5de69d272cb033f108f47623f7fef008.EndInit();
			this.c5de69d272cb033f108f47623f7fef008.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28976) != 0);
			this.c5de69d272cb033f108f47623f7fef008.PerformLayout();
			this.cc7cfe1f97976a18c5fdb3961a2e14b9b.EndInit();
			this.cb3f03a694ca97a057d1693262571d407.EndInit();
			this.c96836d00d3b2ff6ba296617dd93ac7d1.EndInit();
			this.cc88cf84905313ad542b0916fffeca13a.EndInit();
			this.cc88cf84905313ad542b0916fffeca13a.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28980) != 0);
			this.cc88cf84905313ad542b0916fffeca13a.PerformLayout();
			this.c5ef121095a54af022617ead3cdccfecd.EndInit();
			this.c5c0da2c4ace7b32f1e7344aa4557ff66.EndInit();
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.EndInit();
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28984) != 0);
			this.cbb0b4fa2ccd34211c18c0710f18f2c81.PerformLayout();
			this.c334cd5fa87833f636046cdbd48987d99.EndInit();
			this.c70e980dd6de0ea664d1165b0bab9c505.EndInit();
			this.ced92a8662e50218f546ae6bb0a312b4f.EndInit();
			this.ced92a8662e50218f546ae6bb0a312b4f.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28988) != 0);
			this.cffa7e6b0340f88d9369da7a34ef65631.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28992) != 0);
			this.cffa7e6b0340f88d9369da7a34ef65631.PerformLayout();
			this.c3f17fb9a80a6565749e0532cfc37cf36.EndInit();
			this.c7a3b11fb7f169020337311c6c740f967.EndInit();
			this.cf5e6e788cc75cc8a2930ca14db8241d0.EndInit();
			this.cf0b8ec03421b7b69f3c98a253e0ccdb0.EndInit();
			this.cd09b52c3ae35fea01e57c925cb0b9ada.EndInit();
			this.cd09b52c3ae35fea01e57c925cb0b9ada.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28996) != 0);
			this.cd09b52c3ae35fea01e57c925cb0b9ada.PerformLayout();
			this.c43ac0965f3c4dba40288724acda79152.EndInit();
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			this.c052ccf41a3ad1f787a00eeef2d674c87.EndInit();
			this.ce101c2d73f85a684f9dce02f36f4b13d.EndInit();
			this.ce101c2d73f85a684f9dce02f36f4b13d.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29000) != 0);
			this.cd9cc6282fcad129739eed0b12b013814.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29004) != 0);
			((ISupportInitialize)this.c6a2b595cc5d4feecae7d4d122a8f1dce).EndInit();
			this.c822d3bd636ef45abd026eb08950f0fcc.EndInit();
			this.c822d3bd636ef45abd026eb08950f0fcc.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29008) != 0);
			this.c3734340a6bb7f4279e55914719952804.EndInit();
			this.c3734340a6bb7f4279e55914719952804.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29012) != 0);
			this.caab8d6cd57c54c842169d92d82ff1eb4.EndInit();
			this.caab8d6cd57c54c842169d92d82ff1eb4.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29016) != 0);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29020) != 0);
			this.c3c5d23dd6cecab0bcd4e0600a2ca234b.PerformLayout();
			this.c2cf916b4dc1582084d9fe6ddbeff235f.EndInit();
			this.c2cf916b4dc1582084d9fe6ddbeff235f.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29024) != 0);
			this.c2cf916b4dc1582084d9fe6ddbeff235f.PerformLayout();
			this.c8839ab017cc506ca34b8277549d5d1bc.EndInit();
			this.c5a37947f2bfc099265b4ef9252b00763.EndInit();
			this.c5a37947f2bfc099265b4ef9252b00763.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29028) != 0);
			this.c5a37947f2bfc099265b4ef9252b00763.PerformLayout();
			this.cdfa7a89b1b84c54d18b8677922f3bb6f.EndInit();
			this.c19ea03710ebcce9d9618141875fa6b4b.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29032) != 0);
			this.c0717e8606cc1780a278c591545ce83ab.EndInit();
			this.c0717e8606cc1780a278c591545ce83ab.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29036) != 0);
			this.c379f097df981d80284e646aa1f74b28f.EndInit();
			this.c0e7bde0280df56351440f1954d87e7a9.EndInit();
			this.c53ab326bd7d17bbcadde4355d8fe4bfc.EndInit();
			this.c0ae86718cfb509f45e535dd79ebdeb1c.EndInit();
			this.c0ae86718cfb509f45e535dd79ebdeb1c.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29040) != 0);
			this.c0ae86718cfb509f45e535dd79ebdeb1c.PerformLayout();
			this.ca4bbd9e42efba9cc6ffad5fab3161776.EndInit();
			this.c693a1e47df92a82ced2b7ad96d5fae58.EndInit();
			this.ca462c61c0669b9dd1d247bbdb465239d.EndInit();
			this.c140ccd2b676242ee7992f31d621ad05b.EndInit();
			this.c96d38c3849e994101ac7564a97ee637d.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29044) != 0);
			this.c959a761dc775e86d2402435397545a98.EndInit();
			this.c959a761dc775e86d2402435397545a98.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29048) != 0);
			this.c127c6c3e1f77cb695a754ccf2106b43f.EndInit();
			this.c771aaa5176d35a275b87f16a926f5c2f.EndInit();
			this.c556ce890ae6cca856126c0a40a422ad2.EndInit();
			this.c3d83fff74bf1b63d7b3ac872c2b3cc82.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29052) != 0);
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.EndInit();
			this.c3a0c73f7b32d3a3c4d6231ee4ca82455.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29056) != 0);
			this.c30ff40a26c3b8d3f5b34356c58f244ee.EndInit();
			this.cf070b8f366fa5e362b202a68723dd024.EndInit();
			this.cf070b8f366fa5e362b202a68723dd024.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29060) != 0);
			this.cf070b8f366fa5e362b202a68723dd024.PerformLayout();
			this.c63371175f2a9c38a0ecc286c5d95503f.EndInit();
			this.c7fbe090bab86fb6fbed0140fe13b50ac.EndInit();
			this.c7fbe090bab86fb6fbed0140fe13b50ac.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29064) != 0);
			this.c7fbe090bab86fb6fbed0140fe13b50ac.PerformLayout();
			this.c85837e3848f514b3ef5efaee2f6dde4c.EndInit();
			this.cd130fbdce9a854f33033b953b07b1d27.EndInit();
			this.c42691c651c912f80ce2a6783758e6eeb.EndInit();
			this.c8dc32f35e68597fe4c6daa5fe1df3f09.EndInit();
			this.c6f49ef988d94b37c11e87121dc8cf655.EndInit();
			this.cb0cfae55913822d197dd756dceb3d6aa.EndInit();
			this.cb5a0a2daffea489d9502568fc2558386.EndInit();
			this.c7c0d0e61cda4b5dbf992885ec7aab275.EndInit();
			this.ccc6197ad0cf795a9587c66570a9dfb79.EndInit();
			this.cdf2e782b37313a443dabb661cd0cbf24.EndInit();
			this.c3cc59d9c7d75e7586fc9064eea5aa1be.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29068) != 0);
			this.c1d6115076623e59322dfdd1bdc07fa83.EndInit();
			this.c1d6115076623e59322dfdd1bdc07fa83.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29072) != 0);
			this.c1d6115076623e59322dfdd1bdc07fa83.PerformLayout();
			this.c226f954145921ae178aa3238c5370176.EndInit();
			this.c4e15dbb60549d511732b8608a9a1cf24.EndInit();
			this.cf852cda1e32cfb76a067c73ed3f9a113.EndInit();
			this.cf852cda1e32cfb76a067c73ed3f9a113.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29076) != 0);
			this.cf852cda1e32cfb76a067c73ed3f9a113.PerformLayout();
			this.c7a7e4684ac13bfb11ce1a11695b1329c.EndInit();
			this.c54df7c8ea1f37706a137b19cef6a157e.EndInit();
			this.c54df7c8ea1f37706a137b19cef6a157e.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29080) != 0);
			this.c54df7c8ea1f37706a137b19cef6a157e.PerformLayout();
			this.c205802b28402610c81760457c1ed80d0.EndInit();
			this.cf1ae3eee5cba489bc07bd471e11bf801.EndInit();
			this.cf1ae3eee5cba489bc07bd471e11bf801.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29084) != 0);
			this.cf1ae3eee5cba489bc07bd471e11bf801.PerformLayout();
			this.c162efdf2cfee9dcaab42750eaecc63aa.EndInit();
			this.c38e15f9793026f5c07a201f09952a0ac.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29088) != 0);
			this.cdedfb80afbadf1c14d75db35b86905a8.EndInit();
			this.cdedfb80afbadf1c14d75db35b86905a8.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29092) != 0);
			this.cdedfb80afbadf1c14d75db35b86905a8.PerformLayout();
			this.ce25356b1de1570ee1fe025c0f0fa0184.EndInit();
			this.ce25356b1de1570ee1fe025c0f0fa0184.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29096) != 0);
			this.ce25356b1de1570ee1fe025c0f0fa0184.PerformLayout();
			this.c87804958e268f3cb46688274d00bc3db.EndInit();
			this.c35cb28ad4c137d6a5c2019389c2b9e68.EndInit();
			this.c465fcdfe56a0a674011dbc560d792469.EndInit();
			this.c915497b12593334e8fb5c8d1bfd58b57.EndInit();
			this.c6ebb696cd62bce16aa5fc8555508c41b.EndInit();
			this.ce2fbd05cd70c5cd49621c2fcd64f54fa.EndInit();
			this.ce0fe1e4b5ecdeb355970bf03e357723f.EndInit();
			this.c9f60413a79860ab64226aafde0051b03.EndInit();
			this.c60e2ae96cffa51442fc8ac176e5d69f8.EndInit();
			this.c60e2ae96cffa51442fc8ac176e5d69f8.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29100) != 0);
			this.c026bf40f928f3d6dba737111fdffa7ed.EndInit();
			this.cc8460cb9e09be1126c93cb8f02503f12.EndInit();
			this.cc8460cb9e09be1126c93cb8f02503f12.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29104) != 0);
			this.cd6742e70357ccb343e58ca4375bee4c3.EndInit();
			this.c5cedfdbf9e879295d762e0b02d960d33.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29108) != 0);
			this.cf5b92d2f29e108857463d090ea17802d.EndInit();
			this.cf5b92d2f29e108857463d090ea17802d.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29112) != 0);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.EndInit();
			this.cda159acd49537066b3d75532496a4850.EndInit();
			this.cda159acd49537066b3d75532496a4850.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29116) != 0);
			this.cc655eded9d507adf5a9405e457f9a40f.EndInit();
			this.c1bd04ef35d363a76d3290f9f227223a5.EndInit();
			this.c1bd04ef35d363a76d3290f9f227223a5.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29120) != 0);
			this.cc50c89ea5530ed17711416cbd3400578.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29124) != 0);
			this.cc50c89ea5530ed17711416cbd3400578.PerformLayout();
			this.c1f9e38a0e4349cfdda72516b7373c3cd.EndInit();
			this.c1f9e38a0e4349cfdda72516b7373c3cd.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29128) != 0);
			this.ceda6b294518e1db9b1aa8a671392c806.EndInit();
			this.ceda6b294518e1db9b1aa8a671392c806.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29132) != 0);
			this.cda319ea417b6d72e15e4f08944f4e8f2.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29136) != 0);
			this.cda319ea417b6d72e15e4f08944f4e8f2.PerformLayout();
			this.cb890309788bc92be17b6a235de6f886c.EndInit();
			this.c9f93268106946d0f8f04d9f7de77339a.EndInit();
			((ISupportInitialize)this.c03e15e05f6410711c2d29af150da73bc).EndInit();
			this.c9202010bbeb5a869433736d6d3edf68b.EndInit();
			((ISupportInitialize)this.c0e1873c97ed5c28183d8a02dcecefe22).EndInit();
			this.ca094553b15c925802480db99005bd4f2.EndInit();
			this.ca094553b15c925802480db99005bd4f2.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29140) != 0);
			this.cffa2856f157615c723fc0174e0315a48.EndInit();
			this.cffa2856f157615c723fc0174e0315a48.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29144) != 0);
			this.c007c0aae2cf1cee4a2629495a37dd783.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29148) != 0);
			this.cdc574dc7748c88d6861d4bfabdc95272.EndInit();
			this.cdc574dc7748c88d6861d4bfabdc95272.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29152) != 0);
			this.cdc574dc7748c88d6861d4bfabdc95272.PerformLayout();
			this.ce2c7d9939c522d450f3df76cfe177c8f.EndInit();
			((ISupportInitialize)this.cfcf06297d6af778ba0b09395fc2f7071).EndInit();
			this.c9ee36b748e08e7ea591f948c93e868a5.EndInit();
			this.c4f35dae606400f2b70610e42660e5131.EndInit();
			this.cc8daf5b987048692fcf54da7b699bd9c.EndInit();
			this.c3191af20f951facba574896ab849a5b5.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29156) != 0);
			((ISupportInitialize)this.cf79908ea7fb179e130decfd49ac2942e).EndInit();
			((ISupportInitialize)this.cbe7fa4761f85da94859280c8565879f4).EndInit();
			((ISupportInitialize)this.cb4a1967318bc2f47a2a97d027e20d00f).EndInit();
			this.ce19c3ed732501121cc7e733f03a750f1.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29160) != 0);
			this.ce19c3ed732501121cc7e733f03a750f1.PerformLayout();
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.EndInit();
			this.ccdf1215dbbeff396ea40c3a50d46f8dc.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29164) != 0);
			this.c3f8308a31f7480c02b875629e4488e2a.EndInit();
			this.c99be52e02415fc82eaf415e375961a97.EndInit();
			this.c58e2356c3b19fdffdd0eecbb202437e5.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29168) != 0);
			this.c81df6c6c9171f63a101b1da4f2500688.EndInit();
			this.c81df6c6c9171f63a101b1da4f2500688.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29172) != 0);
			this.c74635a9b2ff9984a78057f893291fc48.EndInit();
			this.cf60098683d0bc0735fa1599dc81f52fc.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29176) != 0);
			this.cf60098683d0bc0735fa1599dc81f52fc.PerformLayout();
			this.cae387d07ee04501426ac62a7b81ce88f.EndInit();
			this.c11bba70fac0494286e0d3ef67e7108a8.EndInit();
			this.cb88959703fad6c1e125b370dc1b1d628.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29180) != 0);
			this.ca6c1cea062503a0a580756cf1f1f0961.PerformLayout();
			this.c973e711e4ba0b9bf06b636bdbabddad0.EndInit();
			this.c8d2bc6d98c482abe32079c696410b384.EndInit();
			this.c68fb0560502ff7bad26efa6cf163c845.EndInit();
			this.c218e0ce0f7d843f536a409b942e4ca6d.EndInit();
			this.c8720232fcccea592194b8028025cef8b.EndInit();
			this.cb93ef748a37f709d32047aef13f1cb0a.EndInit();
			this.c874864d6030318b57d3af642035e90e5.EndInit();
			this.c804e4fd2d6278fa319994b7cce512f68.EndInit();
			this.c129f9645be9dc9fb646c5432e51db9a5.EndInit();
			this.c362e39f066aef56acd25812b83e7da57.EndInit();
			this.c98fc23ab6c8b6356924ad18312dd43db.EndInit();
			this.c204af998c7bd7e41658b068560e69a22.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.c7897cd9c092dc3138c4daed47b35970b.EndInit();
			this.c47b614ac867932e76ad37c381b0fe8c6.EndInit();
			this.c3b1862ccc73a74157a0aa2e808890118.EndInit();
			this.ca6b7aa9283df8df606f49cc81dbca4d7.EndInit();
			this.c381071419ced61a1622e530e0c8d1688.EndInit();
			this.c15d9090b6a70d3a3c645fff30223e3a5.EndInit();
			this.cb0d70167e184f5c28c15730dd468edc2.EndInit();
			this.cb0d70167e184f5c28c15730dd468edc2.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29184) != 0);
			this.c6c532de73864b060a67b00a40a009091.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29188) != 0);
			this.c58dec0fd4ceda5728f3fb895644e1c63.EndInit();
			this.c58dec0fd4ceda5728f3fb895644e1c63.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29192) != 0);
			this.cee9eb68f8e87aee9d3246553c1d77f82.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29196) != 0);
			this.c079fc63031b6f053e2045ae7ae07e1b8.EndInit();
			this.c079fc63031b6f053e2045ae7ae07e1b8.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29200) != 0);
			this.c894f9612229ef238e4f9c9e3ae42d770.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29204) != 0);
			this.c47acf5fcb77b27cd38425547b69e3df9.EndInit();
			this.c47acf5fcb77b27cd38425547b69e3df9.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29208) != 0);
			this.c47acf5fcb77b27cd38425547b69e3df9.PerformLayout();
			this.c9543becb27e7606550f9caf5bdf6dd21.EndInit();
			this.c792ef639cb88d2161a4888ab19e4d1f3.EndInit();
			this.cf9531a8c30cdd17c740548976f7893c0.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			this.c9386d302f4616a427d7ea57e8f99a6d9.EndInit();
			this.c9386d302f4616a427d7ea57e8f99a6d9.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29212) != 0);
			this.c9386d302f4616a427d7ea57e8f99a6d9.PerformLayout();
			this.c26a23c3f9ed64e91c418484270f55fcc.EndInit();
			this.c1bde3fed671b57fd27277d86860af4b4.EndInit();
			this.c3e55eccc22a105d650a95dea151c61b6.EndInit();
			this.c3e55eccc22a105d650a95dea151c61b6.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29216) != 0);
			this.c54d116beac1eab6bafbc29b67aa5a8c4.EndInit();
			this.c54d116beac1eab6bafbc29b67aa5a8c4.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29220) != 0);
			this.c3c76741a19a037775bafe388a8df4e2c.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29224) != 0);
			this.c3c76741a19a037775bafe388a8df4e2c.PerformLayout();
			this.c6731bd6914a59a695a058df2d9c821b2.EndInit();
			this.c6731bd6914a59a695a058df2d9c821b2.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29228) != 0);
			this.c2178d80825cd9ab2c18a9dcd6884ee14.EndInit();
			this.cbbad8dfe2b75a2868b9ac41cb6fb62b7.EndInit();
			this.cecf676325d3b342f93a03b1b9170b253.EndInit();
			this.c6bcfc0dfb1f1b6c5a918f7deb9f5c65d.EndInit();
			this.c44272853dcc0c97ee7511d3b33f129b2.EndInit();
			this.ce6b37312f4b81e855d0cdd0d77839251.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29232) != 0);
			this.ce6b37312f4b81e855d0cdd0d77839251.PerformLayout();
			this.c05e314fec562b708421366d517bc1760.EndInit();
			this.c05e314fec562b708421366d517bc1760.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29236) != 0);
			this.c9188c69fd7c8eaf15dce43ea16f40d88.EndInit();
			this.c8c4836eaf51bf51ad4029bcfa65e3070.EndInit();
			this.c024a788ba27b0be6afa45229820c2905.EndInit();
			this.c76617ddf050ef873ce43173d73fd39fb.EndInit();
			this.cfac791f2ebab9d5414b01ffa03f31c07.EndInit();
			this.c0b3afb12bff80cf464a5e9a17f791e36.EndInit();
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29240) != 0);
			this.c71a1b4cbd86109c91a0a8ea0d53e0b78.PerformLayout();
			this.cbec87db2de27d1830a4fdb08e4b15303.EndInit();
			this.cbec87db2de27d1830a4fdb08e4b15303.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29244) != 0);
			this.c644e6368b8418e14b419ec82c299f737.EndInit();
			this.cf5d79d3392d0d6eaf324b0a5f5056bcf.EndInit();
			this.c4bc6833c750722a6e897796adbb7c79c.EndInit();
			this.cb09b86c1fbedefa3ac5a95cfddb64e3b.EndInit();
			this.cbbbc92bbbc47247d382886e66cbe134e.EndInit();
			this.ce9e5aa178e2af36d04f863bccc94f85b.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29248) != 0);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00058258 File Offset: 0x00056458
		[CompilerGenerated]
		private void cdc13f3e230d3484c2cb0667c567d126f(object cb0d7b0b893a41a39e281ddc32fc698bd, Exception cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cc3193a346319ba838998a577b49cb598 cc3193a346319ba838998a577b49cb = new cb6cc9a5b122137bc5f2718f61ab49e59.cc3193a346319ba838998a577b49cb598();
			cc3193a346319ba838998a577b49cb.cdf15457ee4816989343b6e6e96dd4cfe = cdf15457ee4816989343b6e6e96dd4cfe;
			base.Invoke(new Action(cc3193a346319ba838998a577b49cb.c07c44897f9b88fceda73ef0fe01fb6b8));
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00058288 File Offset: 0x00056488
		[CompilerGenerated]
		private void cc915e6ec0e26138209bcfec4ab620d06(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			if (this.c44272853dcc0c97ee7511d3b33f129b2.ButtonElement.BorderElement.Visibility == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29252))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc915e6ec0e26138209bcfec4ab620d06(object, EventArgs)).MethodHandle;
				}
				this.c44272853dcc0c97ee7511d3b33f129b2.ButtonElement.BorderElement.Visibility = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29256);
				return;
			}
			this.c44272853dcc0c97ee7511d3b33f129b2.ButtonElement.BorderElement.Visibility = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29260);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00058318 File Offset: 0x00056518
		[CompilerGenerated]
		private void c41ab7cb021389d67f820a4e6d136a0a8()
		{
			try
			{
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29264));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29268)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29272)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4940);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29276)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4945);
				string[] array2 = array;
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29280); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array2); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29288))
				{
					string arg = array2[i];
					string text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(94873), arg);
					IEnumerator<ListViewDataItem> enumerator = this.c127c6c3e1f77cb695a754ccf2106b43f.CheckedItems.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ListViewDataItem listViewDataItem = enumerator.Current;
							text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95017), cf2286880ac0e60eb4b73f505e8420fff.cb93115e3b63933899699d0ee8696f152(listViewDataItem.Tag)));
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
						if (!true)
						{
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c41ab7cb021389d67f820a4e6d136a0a8()).MethodHandle;
						}
					}
					finally
					{
						if (enumerator != null)
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
							enumerator.Dispose();
						}
					}
					using (List<ca7d80640c79713d3597dbccf9d1ce061>.Enumerator enumerator2 = JsonConvert.DeserializeObject<cccbcf6fe2efffb5320bcac8e43429d84>(Encoding.UTF8.GetString(new c866035f717c1c145e269422264e8f519
					{
						c00dacc5708b46f842a758e6902713b32 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29284) != 0)
					}.cf974603cc086c68eafb242ca5199a108(text))).Contents.Content.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ca7d80640c79713d3597dbccf9d1ce061 ca7d80640c79713d3597dbccf9d1ce = enumerator2.Current;
							this.ca3616b09795098887eec9ba9fcfc049d.Add(ca7d80640c79713d3597dbccf9d1ce.Title.Id.ToString());
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
					}
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
			}
			catch
			{
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00058548 File Offset: 0x00056748
		[CompilerGenerated]
		private void cc87c16985640f5664dee0e6099a22353()
		{
			Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29292));
			while (this.c72e7acdf474b857eac13b63d8d3e3e7f == null)
			{
				Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29296));
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
				RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cc87c16985640f5664dee0e6099a22353()).MethodHandle;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00058590 File Offset: 0x00056790
		[CompilerGenerated]
		private void c9e54a5a14ca3e7f63c498f923811fb8c()
		{
			try
			{
				this.c6ffd3b8d6029fa7bcb5c50efea95b86f = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29300));
				string text = Path.Combine(Settings.Default.Path, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613));
				string text2 = Path.Combine(Settings.Default.Path, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2568));
				if (Directory.Exists(text))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c9e54a5a14ca3e7f63c498f923811fb8c()).MethodHandle;
					}
					this.c6ffd3b8d6029fa7bcb5c50efea95b86f += this.c79f39c7b8facf7b3a81962666364425c(text);
				}
				if (Directory.Exists(text2))
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
					this.c6ffd3b8d6029fa7bcb5c50efea95b86f += this.c79f39c7b8facf7b3a81962666364425c(text2);
				}
				if (this.c6ffd3b8d6029fa7bcb5c50efea95b86f == 0UL)
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
					this.c6ffd3b8d6029fa7bcb5c50efea95b86f += (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29304));
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00058690 File Offset: 0x00056890
		[CompilerGenerated]
		private void c14ecdf9b0ba28abdd321d705875d351d()
		{
			this.frmWait.ShowDialog();
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000586B0 File Offset: 0x000568B0
		[CompilerGenerated]
		private void c7cbd0510b5e74ad76df8250ae89f2a35(object cb0d7b0b893a41a39e281ddc32fc698bd, ca4d60b23ae6cb20ad43302467e6dc9e1 c26822581df016083af37ec10f7059fe9)
		{
			cb6cc9a5b122137bc5f2718f61ab49e59.cdbb18f05d7e7d49d8fdf09a1c7da6b61 cdbb18f05d7e7d49d8fdf09a1c7da6b = new cb6cc9a5b122137bc5f2718f61ab49e59.cdbb18f05d7e7d49d8fdf09a1c7da6b61();
			cdbb18f05d7e7d49d8fdf09a1c7da6b.c4404a159870bf55bb6f111e66e59e82d = this;
			cdbb18f05d7e7d49d8fdf09a1c7da6b.c26822581df016083af37ec10f7059fe9 = c26822581df016083af37ec10f7059fe9;
			try
			{
				base.Invoke(new Action(cdbb18f05d7e7d49d8fdf09a1c7da6b.c6cd9e1056fc8582598a1f332ed982fe1));
			}
			catch
			{
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000586FC File Offset: 0x000568FC
		[CompilerGenerated]
		private void c4436f9c03d38e917f156f645d72cde07(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			this.ca13142555fa95005ae606653620ba25f(this.c6ffd3b8d6029fa7bcb5c50efea95b86f);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00058718 File Offset: 0x00056918
		[CompilerGenerated]
		private void cc8ee126021d25c73e288b76d2e9394a5(object cb0d7b0b893a41a39e281ddc32fc698bd, IPAddress cb689e652eac22c54ef570b384f0df229)
		{
			this.c499a936dcf58ee5e0196d68d13371fb0 = DateTime.Now;
			this.c72e7acdf474b857eac13b63d8d3e3e7f = cb689e652eac22c54ef570b384f0df229;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0005873C File Offset: 0x0005693C
		[CompilerGenerated]
		private void c660478eb1d4c9a8ab1a719eba1e756b8(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc610c1995eec8152fee9408d305f1d7a) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c660478eb1d4c9a8ab1a719eba1e756b8(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc610c1995eec8152fee9408d305f1d7a = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c70e424dbaa97f38cc72865245fc8bf19));
			}
			IEnumerator<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerator = selectedItems.Select(selector).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d = enumerator.Current;
					this.c97771ef24da9591c965bc884a27c01c0(c6b7fbe462f43433d64916e9273f7e5d);
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
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000587E4 File Offset: 0x000569E4
		[CompilerGenerated]
		private void c987aacae5e2ccd4cc1f0084fa917113c(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			c1f6179bdc03861e26477b7826da4fb8c c1f6179bdc03861e26477b7826da4fb8c = new c1f6179bdc03861e26477b7826da4fb8c(c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29308)].Tag).Updates, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29312) != 0);
			if (c1f6179bdc03861e26477b7826da4fb8c.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29316))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c987aacae5e2ccd4cc1f0084fa917113c(object, EventArgs)).MethodHandle;
				}
				return;
			}
			using (List<c6a2f8acae5ff1a8a909193a5c5de6687>.Enumerator enumerator = c1f6179bdc03861e26477b7826da4fb8c.c9f4bf79f56cd07529ca7850385fa2cb4.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c6a2f8acae5ff1a8a909193a5c5de6687 c804bc52f7f79bffee6fd394ef382eb = enumerator.Current;
					this.c7a8112437fc6661ae742d22be70531e6(c804bc52f7f79bffee6fd394ef382eb);
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
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000588B4 File Offset: 0x00056AB4
		[CompilerGenerated]
		private void c8624f687d68bddc9adb46168a608b18c(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			this.c7a8112437fc6661ae742d22be70531e6(c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29320)].Tag).Dlc);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000588FC File Offset: 0x00056AFC
		[CompilerGenerated]
		private void c933bb98cdba6bc05f6775c4a7ba8a2c5(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8649e8f2b795f35e45bb3680481157bf) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c933bb98cdba6bc05f6775c4a7ba8a2c5(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c8649e8f2b795f35e45bb3680481157bf = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cc4a9016bbc390fa4463dfb96c0168358));
			}
			IEnumerator<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerator = selectedItems.Select(selector).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d = enumerator.Current;
					this.c84ebcf0d1ef4a18ca7ef0a37d6dcbb1c(c6b7fbe462f43433d64916e9273f7e5d);
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
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000589A4 File Offset: 0x00056BA4
		[CompilerGenerated]
		private void cd5d34597fafed2e4985bdf674079e756(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c0e5747ada7acf9134a69bb4d1cd83cea) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cd5d34597fafed2e4985bdf674079e756(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c0e5747ada7acf9134a69bb4d1cd83cea = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c48aea6b9a353e8c4852ddca58109a147));
			}
			c5409344e1c2b74fa8c9a4d620ccb8d48[] array = selectedItems.Select(selector).ToArray<c5409344e1c2b74fa8c9a4d620ccb8d48>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29324); i < (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(array); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29328))
			{
				c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = array[i];
				this.c17819fd2f02b4bdee7ab4eb871adeba6(c5409344e1c2b74fa8c9a4d620ccb8d);
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
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00058A3C File Offset: 0x00056C3C
		[CompilerGenerated]
		private void c89b5ad120452a01519974885050b937f(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c660c26253103e1ce5a3ced8cdd2935c8) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c89b5ad120452a01519974885050b937f(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c660c26253103e1ce5a3ced8cdd2935c8 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c2cf41f7a5984135c471dc5295043a10f));
			}
			c5409344e1c2b74fa8c9a4d620ccb8d48[] array = selectedItems.Select(selector).ToArray<c5409344e1c2b74fa8c9a4d620ccb8d48>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29332); i < (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(array); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29344))
			{
				c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d = array[i];
				this.c27dcea2a74a59af163e39efd99316482(c6b7fbe462f43433d64916e9273f7e5d, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29336) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29340) != 0);
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
			this.cf95ba3b48fd484ff24b6901d8a9a1280();
			bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29348) != 0;
			bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29352) != 0;
			IEnumerable<ListViewDataItem> selectedItems2 = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector2;
			if ((selector2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c863b6a67569d4c3b12369b657dddc388) == null)
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
				selector2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c863b6a67569d4c3b12369b657dddc388 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cc698aabfe64b0b1311ab399842442c2f));
			}
			this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, selectedItems2.Select(selector2).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00058B4C File Offset: 0x00056D4C
		[CompilerGenerated]
		private void c627b6bdd07378a346cb727b5dacb30cb(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c530e61cac61ffd657166a095c2200064) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c627b6bdd07378a346cb727b5dacb30cb(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c530e61cac61ffd657166a095c2200064 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c04d1d68ae7422f870e0bff1e653145ea));
			}
			c5409344e1c2b74fa8c9a4d620ccb8d48[] array = selectedItems.Select(selector).ToArray<c5409344e1c2b74fa8c9a4d620ccb8d48>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29356); i < (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(array); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29368))
			{
				c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d = array[i];
				this.c27dcea2a74a59af163e39efd99316482(c6b7fbe462f43433d64916e9273f7e5d, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29360) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29364) != 0);
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
			this.cf95ba3b48fd484ff24b6901d8a9a1280();
			bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29372) != 0;
			bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29376) != 0;
			IEnumerable<ListViewDataItem> selectedItems2 = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector2;
			if ((selector2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cbe4eabc073d9073f29ffaca2349733ff) == null)
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
				selector2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cbe4eabc073d9073f29ffaca2349733ff = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.ca38bba8f9f0a71bbb34732845239448e));
			}
			this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, selectedItems2.Select(selector2).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00058C5C File Offset: 0x00056E5C
		[CompilerGenerated]
		private void cfd269e58e537ee2e80442a0247011817(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cfd269e58e537ee2e80442a0247011817(object, EventArgs)).MethodHandle;
				}
				cb6cc9a5b122137bc5f2718f61ab49e59.c1429a6dc344ce1d6f1cdeb4f895f60dc(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29380) != 0);
			}
			if (!cb6cc9a5b122137bc5f2718f61ab49e59.c5c48bfb3019784ac92b83653ab34e32a(Settings.Default.ExtractFolder))
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
				this.c9368dc60d61608581f0b9ed666b65c81(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95042));
				return;
			}
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ceaa126b0df32615fa8595fdba511b09d) == null)
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
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ceaa126b0df32615fa8595fdba511b09d = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c87b1c48ba55392119ad015b50ea9e3e4));
			}
			IEnumerator<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerator = selectedItems.Select(selector).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = enumerator.Current;
					if (c5409344e1c2b74fa8c9a4d620ccb8d.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29384))
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
						cf73c09f4e7123594c77f50f36eff3418 cf73c09f4e7123594c77f50f36eff = new cf73c09f4e7123594c77f50f36eff3418(c5409344e1c2b74fa8c9a4d620ccb8d, (WhatToAction)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29388));
						if (cf73c09f4e7123594c77f50f36eff.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29392))
						{
							continue;
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
						if (cf73c09f4e7123594c77f50f36eff.CopyDlc)
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
							c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.cf08369cbb3a626a84f05ff893b78fed7(Settings.Default.ExtractFolder, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29396) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29400) != 0, null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29404) != 0);
						}
						if (cf73c09f4e7123594c77f50f36eff.CopyGame)
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
							c5409344e1c2b74fa8c9a4d620ccb8d.cf08369cbb3a626a84f05ff893b78fed7(Settings.Default.ExtractFolder, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29408) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29412) != 0, null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29416) != 0);
						}
						if (!cf73c09f4e7123594c77f50f36eff.CopyUpdate)
						{
							continue;
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
						using (List<c6a2f8acae5ff1a8a909193a5c5de6687>.Enumerator enumerator2 = cf73c09f4e7123594c77f50f36eff.c9f4bf79f56cd07529ca7850385fa2cb4.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								c6a2f8acae5ff1a8a909193a5c5de6687 c6a2f8acae5ff1a8a909193a5c5de = enumerator2.Current;
								c6a2f8acae5ff1a8a909193a5c5de.cf08369cbb3a626a84f05ff893b78fed7(Settings.Default.ExtractFolder, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29420) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29424) != 0, null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29428) != 0);
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
							continue;
						}
					}
					if (c5409344e1c2b74fa8c9a4d620ccb8d.System == ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
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
						cf73c09f4e7123594c77f50f36eff3418 cf73c09f4e7123594c77f50f36eff2 = new cf73c09f4e7123594c77f50f36eff3418(c5409344e1c2b74fa8c9a4d620ccb8d, (WhatToAction)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29432));
						if (cf73c09f4e7123594c77f50f36eff2.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29436))
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
							if (cf73c09f4e7123594c77f50f36eff2.CopyDlc)
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
								c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.c2845e22243014eee92c54eee0c15c904(Settings.Default.ExtractFolder, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d.Dlc.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3591)));
							}
							if (cf73c09f4e7123594c77f50f36eff2.CopyGame)
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
								c5409344e1c2b74fa8c9a4d620ccb8d.c2845e22243014eee92c54eee0c15c904(Settings.Default.ExtractFolder, c5409344e1c2b74fa8c9a4d620ccb8d.Name);
							}
							if (cf73c09f4e7123594c77f50f36eff2.CopyUpdate)
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
								using (List<c6a2f8acae5ff1a8a909193a5c5de6687>.Enumerator enumerator2 = cf73c09f4e7123594c77f50f36eff2.c9f4bf79f56cd07529ca7850385fa2cb4.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										c6a2f8acae5ff1a8a909193a5c5de6687 c6a2f8acae5ff1a8a909193a5c5de2 = enumerator2.Current;
										c6a2f8acae5ff1a8a909193a5c5de2.c2845e22243014eee92c54eee0c15c904(Settings.Default.ExtractFolder, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95079), c6a2f8acae5ff1a8a909193a5c5de2.Name, c6a2f8acae5ff1a8a909193a5c5de2.Version));
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
							}
						}
					}
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

		// Token: 0x06000814 RID: 2068 RVA: 0x00059084 File Offset: 0x00057284
		[CompilerGenerated]
		private void cc68b36a834add29a8f2b56744b63bcd8(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			this.c37b3d3a9ef4a26c65a3fac4aa3cda6c2(c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29440)].Tag));
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000590C4 File Offset: 0x000572C4
		[CompilerGenerated]
		private void c0d95b2e7366ba7692514c594645a4ee5(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c4b1cb080985977e03c029fd9bf237f6d) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c0d95b2e7366ba7692514c594645a4ee5(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c4b1cb080985977e03c029fd9bf237f6d = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c12b341c2d889c91606ab0b24f017f13f));
			}
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> source = selectedItems.Select(selector);
			Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool> predicate;
			if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ceec59c2fe3bd6c604ef0a368895c4faf) == null)
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
				predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ceec59c2fe3bd6c604ef0a368895c4faf = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c47ccc6e28ccf7c3bad03d0a2c792c35c));
			}
			this.c6cbaf2b6329c21ba2ed2db7bade8d600(source.Where(predicate));
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00059150 File Offset: 0x00057350
		[CompilerGenerated]
		private void ca9174cea51819e2c953e6e2d729e3482(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c309b3bccd5f06eb0ab8395c9a07415b4) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.ca9174cea51819e2c953e6e2d729e3482(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c309b3bccd5f06eb0ab8395c9a07415b4 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cb03d13fbbd29d40737c2400090329f39));
			}
			IEnumerator<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerator = selectedItems.Select(selector).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = enumerator.Current;
					new c2c4b14fe5e90291f1e89570e7696c8a0(c5409344e1c2b74fa8c9a4d620ccb8d).ShowDialog();
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
			bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29444) != 0;
			bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29448) != 0;
			IEnumerable<ListViewDataItem> selectedItems2 = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector2;
			if ((selector2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c21bf57a9834e2cb0bf4b5681cf0e89c3) == null)
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
				selector2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c21bf57a9834e2cb0bf4b5681cf0e89c3 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c3f534ced576a55b678eab5ad413c0855));
			}
			this.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, selectedItems2.Select(selector2).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0005925C File Offset: 0x0005745C
		[CompilerGenerated]
		private void cefc28ae88c464bc2fc0158a446b05a41(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			IEnumerable<ListViewDataItem> selectedItems = this.cf6348eb630c0b01e77b8f83ec7151d96.SelectedItems;
			Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector;
			if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdf5e65e04f47cbb36af4c55c534bb6b1) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cefc28ae88c464bc2fc0158a446b05a41(object, EventArgs)).MethodHandle;
				}
				selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdf5e65e04f47cbb36af4c55c534bb6b1 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c769885015d28865485193f39776a7dcf));
			}
			IEnumerator<c5409344e1c2b74fa8c9a4d620ccb8d48> enumerator = selectedItems.Select(selector).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d = enumerator.Current;
					new c4661923ed4f88392e3827d508c62c12a(c6b7fbe462f43433d64916e9273f7e5d).ShowDialog();
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
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00059308 File Offset: 0x00057508
		[CompilerGenerated]
		private void c4f7d1cac3439bfa5747dd6dd79854764()
		{
			this.c4961cd4ecad2ed77ffc251826242e162 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29452) != 0);
			this.c6fcdfcca42c1aeed647bdea8d9051572 = new c35f868ba35d5c51ce5a72f140870f944();
			this.c6fcdfcca42c1aeed647bdea8d9051572.Run();
		}

		// Token: 0x0400047C RID: 1148
		private const string ca72237f9c5fd9208b7829f025d7c22ad = "Powered by Willzor's wiiuusbhelper.com (No Wii U found, please launch Wii U USB Helper Transfer Tool)";

		// Token: 0x0400047D RID: 1149
		private const string c9d2787280a02ca18a47b4bc7010d48a4 = "Powered by Willzor's wiiuusbhelper.com (Connected to your Wii U!)";

		// Token: 0x0400047E RID: 1150
		private const int c03bf84775555a1c3eb395d38300067bd = 4000;

		// Token: 0x0400047F RID: 1151
		private static readonly string cc6a1f532cec9e354b03aa188eb0dd582 = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29472)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44554));

		// Token: 0x04000480 RID: 1152
		private readonly ListViewDataItemGroup c58d55bb55866f0df1e08f95c03606f75 = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95120));

		// Token: 0x04000481 RID: 1153
		private readonly ListViewDataItemGroup c48c1bf2682234ca34e16ef1a566c6ec4 = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95141));

		// Token: 0x04000482 RID: 1154
		private readonly ListViewDataItemGroup c022aac4c0d71a1c532b6e20993d403e9 = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95182));

		// Token: 0x04000483 RID: 1155
		private readonly ListViewDataItemGroup c69fce1dee9acfb2f37ac6bb69ebad9b2 = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5157));

		// Token: 0x04000484 RID: 1156
		private readonly ListViewDataItemGroup c41ff0acde4c428a9801876721bc993da = new ListViewDataItemGroup(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95227));

		// Token: 0x04000485 RID: 1157
		private c14cf1f200b737cded2756d6ab302a149 cc80b541ea0aecdb8c28ad57f43ca8ab8;

		// Token: 0x04000486 RID: 1158
		private cdb02a77cadec7790d5c7c433ab736a12 cc86ba4499172993cc63947e93cc907ae;

		// Token: 0x04000487 RID: 1159
		private ulong c6ffd3b8d6029fa7bcb5c50efea95b86f;

		// Token: 0x04000488 RID: 1160
		private bool c3835898c84d997df76aaf879a4b094f3;

		// Token: 0x04000489 RID: 1161
		private bool c35f460bf0c1f6e62670cd9395b72682d;

		// Token: 0x0400048A RID: 1162
		private bool c1c2aeea8a80fa3add16ae3005883e936;

		// Token: 0x0400048B RID: 1163
		private bool c4961cd4ecad2ed77ffc251826242e162;

		// Token: 0x0400048C RID: 1164
		private bool c878d41acf36ac7e5031cd3a429e41059;

		// Token: 0x0400048D RID: 1165
		private bool cbeb7ed06c872d430df3d8ec783ae0dd9;

		// Token: 0x0400048E RID: 1166
		private bool c3749f3cf1df50ff24b9a048e0b822d9a;

		// Token: 0x0400048F RID: 1167
		private volatile bool cf7f61cc59e2808aad0d77629a4b89af8;

		// Token: 0x04000490 RID: 1168
		private DriveInfo cdd5db1f29d0ec718d4917636a4927fbb;

		// Token: 0x04000491 RID: 1169
		private List<string> ca3616b09795098887eec9ba9fcfc049d;

		// Token: 0x04000492 RID: 1170
		private c35f868ba35d5c51ce5a72f140870f944 c6fcdfcca42c1aeed647bdea8d9051572;

		// Token: 0x04000493 RID: 1171
		private DateTime c499a936dcf58ee5e0196d68d13371fb0 = DateTime.MinValue;

		// Token: 0x04000494 RID: 1172
		private IPAddress c72e7acdf474b857eac13b63d8d3e3e7f;

		// Token: 0x04000495 RID: 1173
		[CompilerGenerated]
		private static readonly string cd27aaa3b9dbe2ffd3cdb46f868c5d6a6;

		// Token: 0x04000496 RID: 1174
		[CompilerGenerated]
		private bool c4b451f7ca43aaf668208412d6c324b99;

		// Token: 0x04000497 RID: 1175
		[CompilerGenerated]
		private c60797b4f8bfa489df1954dcdc88ad77d c451bcbacea0a3492e17f2c12a8d5f01d;

		// Token: 0x04000498 RID: 1176
		[CompilerGenerated]
		private int cb979256242c67dbe12331cf01ffd0500;

		// Token: 0x04000499 RID: 1177
		[CompilerGenerated]
		private List<Platform> c7e9a5e2e9b058f4b9874149076ab52cf;

		// Token: 0x0400049A RID: 1178
		[CompilerGenerated]
		private WebProxy c5a670722d2afd6ebe91a0b2e45e7067e;

		// Token: 0x0400049B RID: 1179
		[CompilerGenerated]
		private c5409344e1c2b74fa8c9a4d620ccb8d48 c14aa0a00865ecc09eb055745764a8698;

		// Token: 0x0400049C RID: 1180
		[CompilerGenerated]
		private readonly List<c6114b34ba4893a53ebb4b599e0e2e3fc> c5aa7f919f8683794df52c90c384037fa;

		// Token: 0x0400049D RID: 1181
		[CompilerGenerated]
		private readonly List<c6114b34ba4893a53ebb4b599e0e2e3fc> c5f1b8c74324d5f811194d282d9757549;

		// Token: 0x0400049E RID: 1182
		private System.Windows.Forms.Timer c3594d8d99bfd6c1696f290e195f9566d;

		// Token: 0x0400049F RID: 1183
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x040004A0 RID: 1184
		private RadButton c44272853dcc0c97ee7511d3b33f129b2;

		// Token: 0x040004A1 RID: 1185
		private RadTextBox c90fe97b27e47a56fbdfb26d97ff3fbe0;

		// Token: 0x040004A2 RID: 1186
		private RadListView cf6348eb630c0b01e77b8f83ec7151d96;

		// Token: 0x040004A3 RID: 1187
		private OpenFileDialog c55dae0c1480836020900dbf1801fc283;

		// Token: 0x040004A4 RID: 1188
		private RadButton c2178d80825cd9ab2c18a9dcd6884ee14;

		// Token: 0x040004A5 RID: 1189
		private RadButton c6bcfc0dfb1f1b6c5a918f7deb9f5c65d;

		// Token: 0x040004A6 RID: 1190
		private RadButton cecf676325d3b342f93a03b1b9170b253;

		// Token: 0x040004A7 RID: 1191
		private RadLabel c92ab20cb1038469a6ddf6e1b4c5d8d5c;

		// Token: 0x040004A8 RID: 1192
		private RadListView c2fb6dd895d1ff7ecd48bea8f8087cbe2;

		// Token: 0x040004A9 RID: 1193
		private RadLabel c15cfb8d25fc93dd1b55a4ea47493c187;

		// Token: 0x040004AA RID: 1194
		private RadLabel cde07a8d8f3fe5ea1f59833c2ca019b46;

		// Token: 0x040004AB RID: 1195
		private PictureBox c6a2b595cc5d4feecae7d4d122a8f1dce;

		// Token: 0x040004AC RID: 1196
		private RadButton cbbad8dfe2b75a2868b9ac41cb6fb62b7;

		// Token: 0x040004AD RID: 1197
		private RadGroupBox c9df3025f0563abbb25d17e41a7657e81;

		// Token: 0x040004AE RID: 1198
		private RadCheckBox cef9cf59a04a9a091015a8a429a716577;

		// Token: 0x040004AF RID: 1199
		private RadCheckBox c99bd3ea85b6a1aa87f929de1fca32ff1;

		// Token: 0x040004B0 RID: 1200
		private RadGroupBox c1afd523200a21e6b7132517361aba805;

		// Token: 0x040004B1 RID: 1201
		private RadLabel c13964aec72502e7656b1ae19a819aff9;

		// Token: 0x040004B2 RID: 1202
		private RadButton ca65c4bbf27dcaa72b8d1adc74336c0af;

		// Token: 0x040004B3 RID: 1203
		private RadProgressBar c271cb122814a1639c9b4c33232d68a4b;

		// Token: 0x040004B4 RID: 1204
		private RadListView c7cb15ecb80bee59937d269db8297ea4b;

		// Token: 0x040004B5 RID: 1205
		private PictureBox c0e1873c97ed5c28183d8a02dcecefe22;

		// Token: 0x040004B6 RID: 1206
		private PictureBox cf79908ea7fb179e130decfd49ac2942e;

		// Token: 0x040004B7 RID: 1207
		private PictureBox cb4a1967318bc2f47a2a97d027e20d00f;

		// Token: 0x040004B8 RID: 1208
		private PictureBox cbe7fa4761f85da94859280c8565879f4;

		// Token: 0x040004B9 RID: 1209
		private RadLabel c96836d00d3b2ff6ba296617dd93ac7d1;

		// Token: 0x040004BA RID: 1210
		private RadLabel c06f4d49c4cd7969e514a4b3649e010c9;

		// Token: 0x040004BB RID: 1211
		private RadGroupBox c1fbb1a3b10ef0c49ba689bd6ae606d29;

		// Token: 0x040004BC RID: 1212
		private RadButton cff69c812b578b7c94cbd35be243af026;

		// Token: 0x040004BD RID: 1213
		private RadButton cc7cfe1f97976a18c5fdb3961a2e14b9b;

		// Token: 0x040004BE RID: 1214
		private RadButton cb3f03a694ca97a057d1693262571d407;

		// Token: 0x040004BF RID: 1215
		private RadGroupBox cbb0b4fa2ccd34211c18c0710f18f2c81;

		// Token: 0x040004C0 RID: 1216
		private RadLabel c334cd5fa87833f636046cdbd48987d99;

		// Token: 0x040004C1 RID: 1217
		private RadProgressBar c70e980dd6de0ea664d1165b0bab9c505;

		// Token: 0x040004C2 RID: 1218
		private RadCheckBox c69103ed6bfb59dc17e3aed75cdbe979d;

		// Token: 0x040004C3 RID: 1219
		private RadButton c5de69d272cb033f108f47623f7fef008;

		// Token: 0x040004C4 RID: 1220
		private Label cd6793e893e7cbd3d9a5d7b2a95ad24eb;

		// Token: 0x040004C5 RID: 1221
		private RadGroupBox cc88cf84905313ad542b0916fffeca13a;

		// Token: 0x040004C6 RID: 1222
		private RadLabel c5ef121095a54af022617ead3cdccfecd;

		// Token: 0x040004C7 RID: 1223
		private RadProgressBar c5c0da2c4ace7b32f1e7344aa4557ff66;

		// Token: 0x040004C8 RID: 1224
		private RadDock ced92a8662e50218f546ae6bb0a312b4f;

		// Token: 0x040004C9 RID: 1225
		private ToolWindow c3c5d23dd6cecab0bcd4e0600a2ca234b;

		// Token: 0x040004CA RID: 1226
		private DocumentContainer c3734340a6bb7f4279e55914719952804;

		// Token: 0x040004CB RID: 1227
		private ToolWindow cc50c89ea5530ed17711416cbd3400578;

		// Token: 0x040004CC RID: 1228
		private RadPanel c6731bd6914a59a695a058df2d9c821b2;

		// Token: 0x040004CD RID: 1229
		private ToolWindow c6c532de73864b060a67b00a40a009091;

		// Token: 0x040004CE RID: 1230
		private DocumentTabStrip caab8d6cd57c54c842169d92d82ff1eb4;

		// Token: 0x040004CF RID: 1231
		private RadGroupBox c2cf916b4dc1582084d9fe6ddbeff235f;

		// Token: 0x040004D0 RID: 1232
		private ToolWindow c3c76741a19a037775bafe388a8df4e2c;

		// Token: 0x040004D1 RID: 1233
		private RadGroupBox c079fc63031b6f053e2045ae7ae07e1b8;

		// Token: 0x040004D2 RID: 1234
		private ToolWindow ce6b37312f4b81e855d0cdd0d77839251;

		// Token: 0x040004D3 RID: 1235
		private RadPanel c05e314fec562b708421366d517bc1760;

		// Token: 0x040004D4 RID: 1236
		private RadButton c76617ddf050ef873ce43173d73fd39fb;

		// Token: 0x040004D5 RID: 1237
		private RadButton cfac791f2ebab9d5414b01ffa03f31c07;

		// Token: 0x040004D6 RID: 1238
		private RadButton c0b3afb12bff80cf464a5e9a17f791e36;

		// Token: 0x040004D7 RID: 1239
		private RadButton cdfa7a89b1b84c54d18b8677922f3bb6f;

		// Token: 0x040004D8 RID: 1240
		private RadButton c024a788ba27b0be6afa45229820c2905;

		// Token: 0x040004D9 RID: 1241
		private ToolWindow c71a1b4cbd86109c91a0a8ea0d53e0b78;

		// Token: 0x040004DA RID: 1242
		private RadPanel cbec87db2de27d1830a4fdb08e4b15303;

		// Token: 0x040004DB RID: 1243
		private RadButton cbbbc92bbbc47247d382886e66cbe134e;

		// Token: 0x040004DC RID: 1244
		private WebBrowser c967e6f900acf8fed69dd58fc13e618c9;

		// Token: 0x040004DD RID: 1245
		private RadGroupBox c1f9e38a0e4349cfdda72516b7373c3cd;

		// Token: 0x040004DE RID: 1246
		private RadDock ceda6b294518e1db9b1aa8a671392c806;

		// Token: 0x040004DF RID: 1247
		private ToolWindow ce19c3ed732501121cc7e733f03a750f1;

		// Token: 0x040004E0 RID: 1248
		private DocumentContainer ca094553b15c925802480db99005bd4f2;

		// Token: 0x040004E1 RID: 1249
		private DocumentTabStrip cffa2856f157615c723fc0174e0315a48;

		// Token: 0x040004E2 RID: 1250
		private ToolWindow cda319ea417b6d72e15e4f08944f4e8f2;

		// Token: 0x040004E3 RID: 1251
		private ToolWindow c3191af20f951facba574896ab849a5b5;

		// Token: 0x040004E4 RID: 1252
		private RadGroupBox ccdf1215dbbeff396ea40c3a50d46f8dc;

		// Token: 0x040004E5 RID: 1253
		private RadButton c99be52e02415fc82eaf415e375961a97;

		// Token: 0x040004E6 RID: 1254
		private RadButton c3f8308a31f7480c02b875629e4488e2a;

		// Token: 0x040004E7 RID: 1255
		private RadGroupBox c5a37947f2bfc099265b4ef9252b00763;

		// Token: 0x040004E8 RID: 1256
		private RadButton c8c4836eaf51bf51ad4029bcfa65e3070;

		// Token: 0x040004E9 RID: 1257
		private RadButton cb09b86c1fbedefa3ac5a95cfddb64e3b;

		// Token: 0x040004EA RID: 1258
		private RadSplitContainer c822d3bd636ef45abd026eb08950f0fcc;

		// Token: 0x040004EB RID: 1259
		private ToolTabStrip c1bd04ef35d363a76d3290f9f227223a5;

		// Token: 0x040004EC RID: 1260
		private ToolTabStrip cb0d70167e184f5c28c15730dd468edc2;

		// Token: 0x040004ED RID: 1261
		private ToolTabStrip c54d116beac1eab6bafbc29b67aa5a8c4;

		// Token: 0x040004EE RID: 1262
		private ToolWindow cffa7e6b0340f88d9369da7a34ef65631;

		// Token: 0x040004EF RID: 1263
		private RadGroupBox cd09b52c3ae35fea01e57c925cb0b9ada;

		// Token: 0x040004F0 RID: 1264
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x040004F1 RID: 1265
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;

		// Token: 0x040004F2 RID: 1266
		private RadLabel c43ac0965f3c4dba40288724acda79152;

		// Token: 0x040004F3 RID: 1267
		private RadListView c3f17fb9a80a6565749e0532cfc37cf36;

		// Token: 0x040004F4 RID: 1268
		private RadLabel c052ccf41a3ad1f787a00eeef2d674c87;

		// Token: 0x040004F5 RID: 1269
		private RadButton cf0b8ec03421b7b69f3c98a253e0ccdb0;

		// Token: 0x040004F6 RID: 1270
		private ToolTabStrip c3e55eccc22a105d650a95dea151c61b6;

		// Token: 0x040004F7 RID: 1271
		private RadButton ceed5d76836a72a0a0356175e703e6aa6;

		// Token: 0x040004F8 RID: 1272
		private RadButton c4bc6833c750722a6e897796adbb7c79c;

		// Token: 0x040004F9 RID: 1273
		private CheckBox c92d48e7b56cd690ea66ba42d3db5e722;

		// Token: 0x040004FA RID: 1274
		private CheckBox c992db60513feabfee7066ab96aec9a64;

		// Token: 0x040004FB RID: 1275
		private CheckBox c821c2394e2dbac0ba1c2982eeb77d30d;

		// Token: 0x040004FC RID: 1276
		private RadContextMenu cd454afeeb1c83386a9b8902a8439978e;

		// Token: 0x040004FD RID: 1277
		private RadMenuItem cb3dc29b65c72a11c969484cf0866c7be;

		// Token: 0x040004FE RID: 1278
		private RadMenuItem c7453b0e9791e5c45a84a845d8794227d;

		// Token: 0x040004FF RID: 1279
		private RadMenuItem cbb443da1d1aa99f7840f31f118e97f4f;

		// Token: 0x04000500 RID: 1280
		private RadMenuItem ca37fea2b0a0ec984ab56530130949795;

		// Token: 0x04000501 RID: 1281
		private RadMenuItem c163902e6bdd8bcfb3dbca9008354fb43;

		// Token: 0x04000502 RID: 1282
		private RadMenuItem c8fd7fc32e0c93a70bfee119de0883219;

		// Token: 0x04000503 RID: 1283
		private RadButton cf5d79d3392d0d6eaf324b0a5f5056bcf;

		// Token: 0x04000504 RID: 1284
		private RadTextBoxControl c9202010bbeb5a869433736d6d3edf68b;

		// Token: 0x04000505 RID: 1285
		private ToolWindow c007c0aae2cf1cee4a2629495a37dd783;

		// Token: 0x04000506 RID: 1286
		private Label c2578bdf3f76dc6df3ad590d55e5c99e8;

		// Token: 0x04000507 RID: 1287
		private PictureBox cfcf06297d6af778ba0b09395fc2f7071;

		// Token: 0x04000508 RID: 1288
		private Label c93a94181f2cea21a98fefb0ba7e8888b;

		// Token: 0x04000509 RID: 1289
		private RadProgressBar c4f35dae606400f2b70610e42660e5131;

		// Token: 0x0400050A RID: 1290
		private RadListView cc8daf5b987048692fcf54da7b699bd9c;

		// Token: 0x0400050B RID: 1291
		private Label ca43fdd1563fb00ad7902f923e2ce29db;

		// Token: 0x0400050C RID: 1292
		private Label c0d57030f623a2ce3ac47f346eded8eb2;

		// Token: 0x0400050D RID: 1293
		private RadListView c9ee36b748e08e7ea591f948c93e868a5;

		// Token: 0x0400050E RID: 1294
		private ToolWindow c58e2356c3b19fdffdd0eecbb202437e5;

		// Token: 0x0400050F RID: 1295
		private RadListView c81df6c6c9171f63a101b1da4f2500688;

		// Token: 0x04000510 RID: 1296
		private RadLabel c74635a9b2ff9984a78057f893291fc48;

		// Token: 0x04000511 RID: 1297
		private RadGroupBox cdc574dc7748c88d6861d4bfabdc95272;

		// Token: 0x04000512 RID: 1298
		private System.Windows.Forms.Timer c140aadf765c4d07d6ee3fccbfde7124c;

		// Token: 0x04000513 RID: 1299
		private RadButton c9188c69fd7c8eaf15dce43ea16f40d88;

		// Token: 0x04000514 RID: 1300
		private Label cc9e45bbdf6ee9b81212ed24a210aab07;

		// Token: 0x04000515 RID: 1301
		private RadListView ce2c7d9939c522d450f3df76cfe177c8f;

		// Token: 0x04000516 RID: 1302
		private System.Windows.Forms.Timer cbd120a78c4a62a94400d69af3d3fc776;

		// Token: 0x04000517 RID: 1303
		private RadCheckBox c8839ab017cc506ca34b8277549d5d1bc;

		// Token: 0x04000518 RID: 1304
		private RadButton c7a3b11fb7f169020337311c6c740f967;

		// Token: 0x04000519 RID: 1305
		private RadMenuItem cff967d75cf03cf4d5c9b5233a561f33c;

		// Token: 0x0400051A RID: 1306
		private RadMenuItem cd111a8d957d26fad50953d63cca2d714;

		// Token: 0x0400051B RID: 1307
		private RadButton cd6742e70357ccb343e58ca4375bee4c3;

		// Token: 0x0400051C RID: 1308
		private RadCheckBox ce77148f56a941930515ae05ee4a8abba;

		// Token: 0x0400051D RID: 1309
		private RadCheckBox c15ef48f6d131106befa105251dceaed9;

		// Token: 0x0400051E RID: 1310
		private ToolWindow c19ea03710ebcce9d9618141875fa6b4b;

		// Token: 0x0400051F RID: 1311
		private RadCheckedListBox c379f097df981d80284e646aa1f74b28f;

		// Token: 0x04000520 RID: 1312
		private RadButton c0e7bde0280df56351440f1954d87e7a9;

		// Token: 0x04000521 RID: 1313
		private RadButton c53ab326bd7d17bbcadde4355d8fe4bfc;

		// Token: 0x04000522 RID: 1314
		private RadGroupBox c0ae86718cfb509f45e535dd79ebdeb1c;

		// Token: 0x04000523 RID: 1315
		private RadCheckBox c693a1e47df92a82ced2b7ad96d5fae58;

		// Token: 0x04000524 RID: 1316
		private RadCheckBox ca462c61c0669b9dd1d247bbdb465239d;

		// Token: 0x04000525 RID: 1317
		private RadCheckBox c140ccd2b676242ee7992f31d621ad05b;

		// Token: 0x04000526 RID: 1318
		private RadGroupBox c0717e8606cc1780a278c591545ce83ab;

		// Token: 0x04000527 RID: 1319
		private RadLabel c73a9fa38c32073af376cb816c1f090ff;

		// Token: 0x04000528 RID: 1320
		private RadSpinEditor c7bab6db345839f9cf49d38f3cb6052bd;

		// Token: 0x04000529 RID: 1321
		private RadCheckBox c727375dbbb6f023ed693138c5ee33ab6;

		// Token: 0x0400052A RID: 1322
		private RadLabel c3e2b0edd5c4db8fcb6c60a419bd93842;

		// Token: 0x0400052B RID: 1323
		private System.Windows.Forms.Timer c803b89929a29613f5751f6463377a31b;

		// Token: 0x0400052C RID: 1324
		private RadButton c9cab24920274230a73629880e3d2f54d;

		// Token: 0x0400052D RID: 1325
		private RadButton cb890309788bc92be17b6a235de6f886c;

		// Token: 0x0400052E RID: 1326
		private RadButton cf5e6e788cc75cc8a2930ca14db8241d0;

		// Token: 0x0400052F RID: 1327
		private ToolTabStrip ce101c2d73f85a684f9dce02f36f4b13d;

		// Token: 0x04000530 RID: 1328
		private ToolWindow cd9cc6282fcad129739eed0b12b013814;

		// Token: 0x04000531 RID: 1329
		private RadLabel ce9e5aa178e2af36d04f863bccc94f85b;

		// Token: 0x04000532 RID: 1330
		private ToolWindow c3d83fff74bf1b63d7b3ac872c2b3cc82;

		// Token: 0x04000533 RID: 1331
		private RadGroupBox c7fbe090bab86fb6fbed0140fe13b50ac;

		// Token: 0x04000534 RID: 1332
		private RadButton c8dc32f35e68597fe4c6daa5fe1df3f09;

		// Token: 0x04000535 RID: 1333
		private RadTextBox c6f49ef988d94b37c11e87121dc8cf655;

		// Token: 0x04000536 RID: 1334
		private RadTextBox cb0cfae55913822d197dd756dceb3d6aa;

		// Token: 0x04000537 RID: 1335
		private RadLabel cb5a0a2daffea489d9502568fc2558386;

		// Token: 0x04000538 RID: 1336
		private RadLabel c7c0d0e61cda4b5dbf992885ec7aab275;

		// Token: 0x04000539 RID: 1337
		private RadTextBox ccc6197ad0cf795a9587c66570a9dfb79;

		// Token: 0x0400053A RID: 1338
		private RadLabel cdf2e782b37313a443dabb661cd0cbf24;

		// Token: 0x0400053B RID: 1339
		private RadButton c42691c651c912f80ce2a6783758e6eeb;

		// Token: 0x0400053C RID: 1340
		private RadLabel c85837e3848f514b3ef5efaee2f6dde4c;

		// Token: 0x0400053D RID: 1341
		private RadLabel cd130fbdce9a854f33033b953b07b1d27;

		// Token: 0x0400053E RID: 1342
		private RadGroupBox cdedfb80afbadf1c14d75db35b86905a8;

		// Token: 0x0400053F RID: 1343
		private RadGroupBox ce25356b1de1570ee1fe025c0f0fa0184;

		// Token: 0x04000540 RID: 1344
		private RadLabel c35cb28ad4c137d6a5c2019389c2b9e68;

		// Token: 0x04000541 RID: 1345
		private RadLabel c915497b12593334e8fb5c8d1bfd58b57;

		// Token: 0x04000542 RID: 1346
		private RadLabel c6ebb696cd62bce16aa5fc8555508c41b;

		// Token: 0x04000543 RID: 1347
		private RadLabel ce2fbd05cd70c5cd49621c2fcd64f54fa;

		// Token: 0x04000544 RID: 1348
		private RadLabel ce0fe1e4b5ecdeb355970bf03e357723f;

		// Token: 0x04000545 RID: 1349
		private RadLabel c465fcdfe56a0a674011dbc560d792469;

		// Token: 0x04000546 RID: 1350
		private RadLabel c9f60413a79860ab64226aafde0051b03;

		// Token: 0x04000547 RID: 1351
		private RadButton c87804958e268f3cb46688274d00bc3db;

		// Token: 0x04000548 RID: 1352
		private PictureBox c03e15e05f6410711c2d29af150da73bc;

		// Token: 0x04000549 RID: 1353
		private RadButton cb88959703fad6c1e125b370dc1b1d628;

		// Token: 0x0400054A RID: 1354
		private ToolWindow cf60098683d0bc0735fa1599dc81f52fc;

		// Token: 0x0400054B RID: 1355
		private RadButton c11bba70fac0494286e0d3ef67e7108a8;

		// Token: 0x0400054C RID: 1356
		private RadLabel cae387d07ee04501426ac62a7b81ce88f;

		// Token: 0x0400054D RID: 1357
		private DateTimePicker c46742982780fe1e9a0b84ddd2570741b;

		// Token: 0x0400054E RID: 1358
		private RadCheckBox c49e0e1006d938106f4f6b78dc1a9fbe9;

		// Token: 0x0400054F RID: 1359
		private ToolWindow c3cc59d9c7d75e7586fc9064eea5aa1be;

		// Token: 0x04000550 RID: 1360
		private RadGroupBox cf1ae3eee5cba489bc07bd471e11bf801;

		// Token: 0x04000551 RID: 1361
		private RadCheckBox c162efdf2cfee9dcaab42750eaecc63aa;

		// Token: 0x04000552 RID: 1362
		private RadPageView c58dec0fd4ceda5728f3fb895644e1c63;

		// Token: 0x04000553 RID: 1363
		private RadPageViewPage cee9eb68f8e87aee9d3246553c1d77f82;

		// Token: 0x04000554 RID: 1364
		private RadPageViewPage c894f9612229ef238e4f9c9e3ae42d770;

		// Token: 0x04000555 RID: 1365
		private RadGroupBox c9386d302f4616a427d7ea57e8f99a6d9;

		// Token: 0x04000556 RID: 1366
		private RadRadialGauge c1bde3fed671b57fd27277d86860af4b4;

		// Token: 0x04000557 RID: 1367
		private RadialGaugeArc c5ee538c657dedc06e93850b6ffbbd1a8;

		// Token: 0x04000558 RID: 1368
		private RadialGaugeArc c1aea5f84fd6633c457c8188e0a4cb66d;

		// Token: 0x04000559 RID: 1369
		private RadialGaugeLabels c699a8df7a1718523a4d403193e720975;

		// Token: 0x0400055A RID: 1370
		private RadialGaugeTicks ce9f9a0ea862f54052f446c5db845d608;

		// Token: 0x0400055B RID: 1371
		private RadialGaugeSingleLabel c916dbf43fc7aaf3f0148c42b0a7171f7;

		// Token: 0x0400055C RID: 1372
		private RadLabel c26a23c3f9ed64e91c418484270f55fcc;

		// Token: 0x0400055D RID: 1373
		private RadGroupBox c54df7c8ea1f37706a137b19cef6a157e;

		// Token: 0x0400055E RID: 1374
		private RadCheckBox c205802b28402610c81760457c1ed80d0;

		// Token: 0x0400055F RID: 1375
		private RadMenuItem c5f880f9d0456e05bb289f7acd4a88315;

		// Token: 0x04000560 RID: 1376
		private RadMenuItem c95472e45e18203ec5db262009ed54799;

		// Token: 0x04000561 RID: 1377
		private ToolWindow c38e15f9793026f5c07a201f09952a0ac;

		// Token: 0x04000562 RID: 1378
		private RadGroupBox c60e2ae96cffa51442fc8ac176e5d69f8;

		// Token: 0x04000563 RID: 1379
		private RadButton c026bf40f928f3d6dba737111fdffa7ed;

		// Token: 0x04000564 RID: 1380
		private RadGroupBox cc8460cb9e09be1126c93cb8f02503f12;

		// Token: 0x04000565 RID: 1381
		private RadGroupBox c1d6115076623e59322dfdd1bdc07fa83;

		// Token: 0x04000566 RID: 1382
		private RadButton c226f954145921ae178aa3238c5370176;

		// Token: 0x04000567 RID: 1383
		private RadLabel c4e15dbb60549d511732b8608a9a1cf24;

		// Token: 0x04000568 RID: 1384
		private RadCheckBox c5387a02757dbf6c1f7add91e8f83a37d;

		// Token: 0x04000569 RID: 1385
		private RadMenuItem ca3bf14633756b73f7289598debc2742c;

		// Token: 0x0400056A RID: 1386
		private RadGroupBox cf070b8f366fa5e362b202a68723dd024;

		// Token: 0x0400056B RID: 1387
		private RadCheckBox c63371175f2a9c38a0ecc286c5d95503f;

		// Token: 0x0400056C RID: 1388
		private ToolWindow c5cedfdbf9e879295d762e0b02d960d33;

		// Token: 0x0400056D RID: 1389
		private RadGroupBox cda159acd49537066b3d75532496a4850;

		// Token: 0x0400056E RID: 1390
		private RadButton cc655eded9d507adf5a9405e457f9a40f;

		// Token: 0x0400056F RID: 1391
		private RadButton c9f93268106946d0f8f04d9f7de77339a;

		// Token: 0x04000570 RID: 1392
		private RadGroupBox cf5b92d2f29e108857463d090ea17802d;

		// Token: 0x04000571 RID: 1393
		private RadButton cd792ac67bdacd5b7947dd1479f77c2a6;

		// Token: 0x04000572 RID: 1394
		private ToolWindow c96d38c3849e994101ac7564a97ee637d;

		// Token: 0x04000573 RID: 1395
		private RadButton c556ce890ae6cca856126c0a40a422ad2;

		// Token: 0x04000574 RID: 1396
		private RadButton c771aaa5176d35a275b87f16a926f5c2f;

		// Token: 0x04000575 RID: 1397
		private RadGroupBox c959a761dc775e86d2402435397545a98;

		// Token: 0x04000576 RID: 1398
		private RadCheckedListBox c127c6c3e1f77cb695a754ccf2106b43f;

		// Token: 0x04000577 RID: 1399
		private RadButton c644e6368b8418e14b419ec82c299f737;

		// Token: 0x04000578 RID: 1400
		private RadGroupBox cf852cda1e32cfb76a067c73ed3f9a113;

		// Token: 0x04000579 RID: 1401
		private RadCheckBox c7a7e4684ac13bfb11ce1a11695b1329c;

		// Token: 0x0400057A RID: 1402
		private RadGroupBox c3a0c73f7b32d3a3c4d6231ee4ca82455;

		// Token: 0x0400057B RID: 1403
		private RadLabel c30ff40a26c3b8d3f5b34356c58f244ee;

		// Token: 0x0400057C RID: 1404
		private RadMenuItem cd90b4bdf15f292928e266702461954cd;

		// Token: 0x0400057D RID: 1405
		private DockWindowPlaceholder cf8cb420d295db38024b73fbf777f57ea;

		// Token: 0x0400057E RID: 1406
		private DockWindowPlaceholder cba695b1387526cc2dbaf8bc082358792;

		// Token: 0x0400057F RID: 1407
		private RadCheckBox ca4bbd9e42efba9cc6ffad5fab3161776;

		// Token: 0x04000580 RID: 1408
		private RadGroupBox ca6c1cea062503a0a580756cf1f1f0961;

		// Token: 0x04000581 RID: 1409
		private RadLabel c973e711e4ba0b9bf06b636bdbabddad0;

		// Token: 0x04000582 RID: 1410
		private RadLabel c8d2bc6d98c482abe32079c696410b384;

		// Token: 0x04000583 RID: 1411
		private RadLabel c68fb0560502ff7bad26efa6cf163c845;

		// Token: 0x04000584 RID: 1412
		private RadLabel c218e0ce0f7d843f536a409b942e4ca6d;

		// Token: 0x04000585 RID: 1413
		private RadLabel c8720232fcccea592194b8028025cef8b;

		// Token: 0x04000586 RID: 1414
		private RadLabel cb93ef748a37f709d32047aef13f1cb0a;

		// Token: 0x04000587 RID: 1415
		private RadLabel c874864d6030318b57d3af642035e90e5;

		// Token: 0x04000588 RID: 1416
		private RadLabel c804e4fd2d6278fa319994b7cce512f68;

		// Token: 0x04000589 RID: 1417
		private RadLabel c129f9645be9dc9fb646c5432e51db9a5;

		// Token: 0x0400058A RID: 1418
		private RadLabel c362e39f066aef56acd25812b83e7da57;

		// Token: 0x0400058B RID: 1419
		private RadLabel c98fc23ab6c8b6356924ad18312dd43db;

		// Token: 0x0400058C RID: 1420
		private RadLabel c204af998c7bd7e41658b068560e69a22;

		// Token: 0x0400058D RID: 1421
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x0400058E RID: 1422
		private RadLabel c7897cd9c092dc3138c4daed47b35970b;

		// Token: 0x0400058F RID: 1423
		private RadLabel c47b614ac867932e76ad37c381b0fe8c6;

		// Token: 0x04000590 RID: 1424
		private RadLabel c3b1862ccc73a74157a0aa2e808890118;

		// Token: 0x04000591 RID: 1425
		private RadLabel ca6b7aa9283df8df606f49cc81dbca4d7;

		// Token: 0x04000592 RID: 1426
		private RadLabel c381071419ced61a1622e530e0c8d1688;

		// Token: 0x04000593 RID: 1427
		private RadLabel c15d9090b6a70d3a3c645fff30223e3a5;

		// Token: 0x04000594 RID: 1428
		private RadGroupBox c47acf5fcb77b27cd38425547b69e3df9;

		// Token: 0x04000595 RID: 1429
		private RadLabel c9543becb27e7606550f9caf5bdf6dd21;

		// Token: 0x04000596 RID: 1430
		private RadCheckBox c792ef639cb88d2161a4888ab19e4d1f3;

		// Token: 0x04000597 RID: 1431
		private RadLabel cf9531a8c30cdd17c740548976f7893c0;

		// Token: 0x04000598 RID: 1432
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;

		// Token: 0x0200016F RID: 367
		[CompilerGenerated]
		private sealed class cc3193a346319ba838998a577b49cb598
		{
			// Token: 0x060009BA RID: 2490 RVA: 0x00060E8C File Offset: 0x0005F08C
			internal void c07c44897f9b88fceda73ef0fe01fb6b8()
			{
				RadMessageBox.Show(this.cdf15457ee4816989343b6e6e96dd4cfe.Message);
			}

			// Token: 0x04000752 RID: 1874
			public Exception cdf15457ee4816989343b6e6e96dd4cfe;
		}

		// Token: 0x02000171 RID: 369
		[CompilerGenerated]
		private static class c23431b066782f5245f26984f24cc029d
		{
			// Token: 0x04000790 RID: 1936
			public static CallSite<Func<CallSite, object, IWshShortcut>> ca434e07f49207bc8d8ae6d6f508d6eac;
		}

		// Token: 0x02000172 RID: 370
		[CompilerGenerated]
		private sealed class cb354b1af13f28aa61abe418886451f86
		{
			// Token: 0x060009FA RID: 2554 RVA: 0x00061734 File Offset: 0x0005F934
			internal bool c7efbba997c9425782270845900488a29(Screen c455a4a764b32504656a45afd4f65ac4e)
			{
				return c455a4a764b32504656a45afd4f65ac4e.WorkingArea.IntersectsWith(this.c58cab73e14302dab350a5aebeedf8f7b);
			}

			// Token: 0x04000791 RID: 1937
			public Rectangle c58cab73e14302dab350a5aebeedf8f7b;
		}

		// Token: 0x02000173 RID: 371
		[CompilerGenerated]
		private sealed class c41fa807328813b496156bdf17273ae5f
		{
			// Token: 0x04000792 RID: 1938
			public c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76;

			// Token: 0x04000793 RID: 1939
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000174 RID: 372
		[CompilerGenerated]
		private sealed class c1c4d6e3a4f6f10a11499584c3e806c0f
		{
			// Token: 0x060009FD RID: 2557 RVA: 0x00061784 File Offset: 0x0005F984
			internal void c212528870534101e461716cfd74c73cb()
			{
				try
				{
					byte[] buffer = new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(this.c8c38354cddaefb45b9cfcd9ed2838c37.c804bc52f7f79bffee6fd394ef382eb76.c804df2385fde29e562ce6680eeff8d7e.IconUrl);
					cb6cc9a5b122137bc5f2718f61ab49e59.cfa3bb36624f7d5bae708287cb64148ef cfa3bb36624f7d5bae708287cb64148ef = new cb6cc9a5b122137bc5f2718f61ab49e59.cfa3bb36624f7d5bae708287cb64148ef();
					cfa3bb36624f7d5bae708287cb64148ef.c9def284befdb85aa51808c134f9b5700 = this;
					cfa3bb36624f7d5bae708287cb64148ef.c333ed2a81cf0ecb57f633609e7509589 = new MemoryStream(buffer);
					try
					{
						this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.Invoke(new MethodInvoker(cfa3bb36624f7d5bae708287cb64148ef.c0eed69c3dc1f9accbb2bfeb6d34c3695));
					}
					finally
					{
						if (cfa3bb36624f7d5bae708287cb64148ef.c333ed2a81cf0ecb57f633609e7509589 != null)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c1c4d6e3a4f6f10a11499584c3e806c0f.c212528870534101e461716cfd74c73cb()).MethodHandle;
							}
							((IDisposable)cfa3bb36624f7d5bae708287cb64148ef.c333ed2a81cf0ecb57f633609e7509589).Dispose();
						}
					}
				}
				catch
				{
				}
			}

			// Token: 0x04000794 RID: 1940
			public ListViewDataItem cdeb883c40f9a2378d88e71037beec6cb;

			// Token: 0x04000795 RID: 1941
			public cb6cc9a5b122137bc5f2718f61ab49e59.c41fa807328813b496156bdf17273ae5f c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x02000175 RID: 373
		[CompilerGenerated]
		private sealed class cfa3bb36624f7d5bae708287cb64148ef
		{
			// Token: 0x060009FF RID: 2559 RVA: 0x00061850 File Offset: 0x0005FA50
			internal void c0eed69c3dc1f9accbb2bfeb6d34c3695()
			{
				this.c9def284befdb85aa51808c134f9b5700.cdeb883c40f9a2378d88e71037beec6cb.Image = new Bitmap(Image.FromStream(this.c333ed2a81cf0ecb57f633609e7509589), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30876), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30880));
			}

			// Token: 0x04000796 RID: 1942
			public MemoryStream c333ed2a81cf0ecb57f633609e7509589;

			// Token: 0x04000797 RID: 1943
			public cb6cc9a5b122137bc5f2718f61ab49e59.c1c4d6e3a4f6f10a11499584c3e806c0f c9def284befdb85aa51808c134f9b5700;
		}

		// Token: 0x02000176 RID: 374
		[CompilerGenerated]
		private sealed class cdf32f0a375040bc60f0ded44a792e0a6
		{
			// Token: 0x06000A01 RID: 2561 RVA: 0x000618A8 File Offset: 0x0005FAA8
			internal void cc9ac36d3abf185356de0029fb836d8bb()
			{
				this.c561c2db76c5bf8c95a684eca3517d61c.ShowDialog();
			}

			// Token: 0x04000798 RID: 1944
			public c60797b4f8bfa489df1954dcdc88ad77d c561c2db76c5bf8c95a684eca3517d61c;
		}

		// Token: 0x02000177 RID: 375
		[CompilerGenerated]
		private sealed class c5e4797f4ce9e34831973cb603673efb2
		{
			// Token: 0x06000A03 RID: 2563 RVA: 0x000618D8 File Offset: 0x0005FAD8
			internal void c657cd7722c063e0ef7e83435e76abd2e(object cb0d7b0b893a41a39e281ddc32fc698bd, ce91c3ee3b6503970820b59a90b300d72 cc9e29b4882949498e9a3064a0ebb8954)
			{
				this.c42063d8f921755d50e79dca93da13b1e.cbb155dfe4a555990bbe58cf1ebb59b8a(cc9e29b4882949498e9a3064a0ebb8954.GameProgress, cc9e29b4882949498e9a3064a0ebb8954.Speed);
				this.c42063d8f921755d50e79dca93da13b1e.ca61af680c0200b2535f929a71dff69ad(cc9e29b4882949498e9a3064a0ebb8954.TotalEta);
			}

			// Token: 0x06000A04 RID: 2564 RVA: 0x00061914 File Offset: 0x0005FB14
			internal void cb06240638a7d13446f162b2ba3654e33(object cb0d7b0b893a41a39e281ddc32fc698bd, c8e60ceced0ce323f661e853233d10ec2 cc9e29b4882949498e9a3064a0ebb8954)
			{
				this.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c5e8120bc8b766299fe0bcc91f6157eef = cc9e29b4882949498e9a3064a0ebb8954.Message;
				this.c9def284befdb85aa51808c134f9b5700.c804bc52f7f79bffee6fd394ef382eb76.c9717eaf5eb988da4fe5da4cda0a9ff85();
				this.c42063d8f921755d50e79dca93da13b1e.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x04000799 RID: 1945
			public ce391dfcb046d82715408fa23d60a1773 c42063d8f921755d50e79dca93da13b1e;

			// Token: 0x0400079A RID: 1946
			public cb6cc9a5b122137bc5f2718f61ab49e59.c685bf7254eda9d1411413f148ffb165a c9def284befdb85aa51808c134f9b5700;
		}

		// Token: 0x02000178 RID: 376
		[CompilerGenerated]
		private sealed class cce1e6fcd67afaa0e95eb5dee25a94515
		{
			// Token: 0x0400079B RID: 1947
			public string c5e8120bc8b766299fe0bcc91f6157eef;
		}

		// Token: 0x02000179 RID: 377
		[CompilerGenerated]
		private sealed class c685bf7254eda9d1411413f148ffb165a
		{
			// Token: 0x06000A07 RID: 2567 RVA: 0x0006197C File Offset: 0x0005FB7C
			internal void c1827e6033bcc6ad62d3ed7803c5b84d5(object cb0d7b0b893a41a39e281ddc32fc698bd, EventArgs cc9e29b4882949498e9a3064a0ebb8954)
			{
				this.c804bc52f7f79bffee6fd394ef382eb76.ccb6712cd0fa61825a747636fb485fe52();
			}

			// Token: 0x0400079C RID: 1948
			public c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76;

			// Token: 0x0400079D RID: 1949
			public cb6cc9a5b122137bc5f2718f61ab49e59.cce1e6fcd67afaa0e95eb5dee25a94515 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x0200017A RID: 378
		[CompilerGenerated]
		private sealed class cae5ee452199c860967abd212b5080bde
		{
			// Token: 0x06000A09 RID: 2569 RVA: 0x000619A8 File Offset: 0x0005FBA8
			internal void c211ffcc277f4111750a08f8b62b94863()
			{
				IEnumerator<c6114b34ba4893a53ebb4b599e0e2e3fc> enumerator;
				if (!this.cdf15457ee4816989343b6e6e96dd4cfe.Error)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cae5ee452199c860967abd212b5080bde.c211ffcc277f4111750a08f8b62b94863()).MethodHandle;
					}
					try
					{
						cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = c6bfe236c0809f12bf71cf01d39a9da3f.cd24593c859565ebb8c9faabbc5c75bef(this.cd7b28952603b35a45c555982e677363a);
						if (cdb02a77cadec7790d5c7c433ab736a.MaxSpeed > (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30884)))
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
							new WebClient().UploadValuesAsync(new Uri(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99265)), new NameValueCollection
							{
								{
									ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99370),
									cdb02a77cadec7790d5c7c433ab736a.MaxSpeed.ToString()
								}
							});
						}
					}
					catch
					{
					}
					this.c4404a159870bf55bb6f111e66e59e82d.c7cb15ecb80bee59937d269db8297ea4b.Items.Clear();
					this.c4404a159870bf55bb6f111e66e59e82d.c1bde3fed671b57fd27277d86860af4b4.Value = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(30888);
					this.c4404a159870bf55bb6f111e66e59e82d.c26a23c3f9ed64e91c418484270f55fcc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99381);
					this.c4404a159870bf55bb6f111e66e59e82d.c271cb122814a1639c9b4c33232d68a4b.Value1 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30892);
					this.c4404a159870bf55bb6f111e66e59e82d.c5c0da2c4ace7b32f1e7344aa4557ff66.Value1 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30896);
					this.c4404a159870bf55bb6f111e66e59e82d.c5ef121095a54af022617ead3cdccfecd.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
					this.c4404a159870bf55bb6f111e66e59e82d.c70e980dd6de0ea664d1165b0bab9c505.Value1 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30900);
					this.c4404a159870bf55bb6f111e66e59e82d.c334cd5fa87833f636046cdbd48987d99.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
					this.c4404a159870bf55bb6f111e66e59e82d.c13964aec72502e7656b1ae19a819aff9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
					this.c4404a159870bf55bb6f111e66e59e82d.cbb0b4fa2ccd34211c18c0710f18f2c81.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(85077);
					if (this.c4404a159870bf55bb6f111e66e59e82d.cdd5db1f29d0ec718d4917636a4927fbb != null)
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
						cb6cc9a5b122137bc5f2718f61ab49e59 cb6cc9a5b122137bc5f2718f61ab49e = this.c4404a159870bf55bb6f111e66e59e82d;
						IEnumerable<ListViewDataItem> items = this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items;
						Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc> selector;
						if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c6521cdf49f13d39c6711489bafba8310) == null)
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
							selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c6521cdf49f13d39c6711489bafba8310 = new Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cd39252a696373b0d120d4f216b1af14f));
						}
						IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> source = items.Select(selector);
						Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool> predicate;
						if ((predicate = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c48af06d734949ddfa5c04a3c4a210432) == null)
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
							predicate = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c48af06d734949ddfa5c04a3c4a210432 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c9f9362aeaf39a8b1f8d92acf9b9c3c12));
						}
						cb6cc9a5b122137bc5f2718f61ab49e.c9d78729909faa38b314f6ed7efbe7249(source.Where(predicate).ToList<c6114b34ba4893a53ebb4b599e0e2e3fc>(), this.c4404a159870bf55bb6f111e66e59e82d.cdd5db1f29d0ec718d4917636a4927fbb, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30904) != 0);
					}
					if (this.c4404a159870bf55bb6f111e66e59e82d.c15ef48f6d131106befa105251dceaed9.Checked)
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
						IEnumerable<ListViewDataItem> items2 = this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items;
						Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc> selector2;
						if ((selector2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c88f04bd586fb0135e4acb9b26cac27b4) == null)
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
							selector2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c88f04bd586fb0135e4acb9b26cac27b4 = new Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c376942f4865138498eeb55932142e5fd));
						}
						IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> source2 = items2.Select(selector2);
						Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool> predicate2;
						if ((predicate2 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cfbcf49129989c30f7c0b800199536bf5) == null)
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
							predicate2 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cfbcf49129989c30f7c0b800199536bf5 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.ceffeef016a90edae8a884678fc12360a));
						}
						enumerator = source2.Where(predicate2).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = enumerator.Current;
								c6114b34ba4893a53ebb4b599e0e2e3fc.cf08369cbb3a626a84f05ff893b78fed7(Settings.Default.ExtractFolder, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30908) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30912) != 0, null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30916) != 0);
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
									switch (7)
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
					if (this.c4404a159870bf55bb6f111e66e59e82d.c49e0e1006d938106f4f6b78dc1a9fbe9.Checked)
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
						IEnumerable<ListViewDataItem> items3 = this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items;
						Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc> selector3;
						if ((selector3 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c71f14f3b4ed32161e2a9bef3d097e7df) == null)
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
							selector3 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c71f14f3b4ed32161e2a9bef3d097e7df = new Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.ca375ccb0e3f8d970cb576b515d6fe8d8));
						}
						IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> source3 = items3.Select(selector3);
						Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool> predicate3;
						if ((predicate3 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c10f8d57224f269c699325002acb3a2d8) == null)
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
							predicate3 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c10f8d57224f269c699325002acb3a2d8 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cd0d87fa591c12ff6b9954e4bb4aaca45));
						}
						enumerator = source3.Where(predicate3).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc2 = enumerator.Current;
								if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(c6114b34ba4893a53ebb4b599e0e2e3fc2) != null)
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
									c6114b34ba4893a53ebb4b599e0e2e3fc2.c2845e22243014eee92c54eee0c15c904(Settings.Default.ExtractFolder, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(95079), c6114b34ba4893a53ebb4b599e0e2e3fc2.Name, c6114b34ba4893a53ebb4b599e0e2e3fc2.Version));
								}
								else if (c9d462d6bfbf0a4267f7ed91db470887c.c0b398ab350e72b0d64d512bae8520b85(c6114b34ba4893a53ebb4b599e0e2e3fc2) != null)
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
									c6114b34ba4893a53ebb4b599e0e2e3fc2.c2845e22243014eee92c54eee0c15c904(Settings.Default.ExtractFolder, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c6114b34ba4893a53ebb4b599e0e2e3fc2.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3591)));
								}
								else
								{
									c6114b34ba4893a53ebb4b599e0e2e3fc2.c2845e22243014eee92c54eee0c15c904(Settings.Default.ExtractFolder, c6114b34ba4893a53ebb4b599e0e2e3fc2.Name);
								}
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
					}
					if (this.c4404a159870bf55bb6f111e66e59e82d.c5387a02757dbf6c1f7add91e8f83a37d.Checked)
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
						cb6cc9a5b122137bc5f2718f61ab49e59 cb6cc9a5b122137bc5f2718f61ab49e2 = this.c4404a159870bf55bb6f111e66e59e82d;
						IEnumerable<ListViewDataItem> items4 = this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items;
						Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc> selector4;
						if ((selector4 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c28c6588d86ac25c37879e2e944c0dba2) == null)
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
							selector4 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c28c6588d86ac25c37879e2e944c0dba2 = new Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c7f9f2ac0725bae0f4fbdbbc6b3cf972b));
						}
						IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> source4 = items4.Select(selector4);
						Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool> predicate4;
						if ((predicate4 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ce170f6ee6a3e426328c26c6a603568e8) == null)
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
							predicate4 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.ce170f6ee6a3e426328c26c6a603568e8 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c70c15d491ab5272ec33c94c468fb400b));
						}
						IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> source5 = source4.Where(predicate4);
						Func<c6114b34ba4893a53ebb4b599e0e2e3fc, c5409344e1c2b74fa8c9a4d620ccb8d48> selector5;
						if ((selector5 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c5e9d608f68401b2b3abc62d22bebf544) == null)
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
							selector5 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c5e9d608f68401b2b3abc62d22bebf544 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c06b6284e99716505ccc4627a309e89a8));
						}
						cb6cc9a5b122137bc5f2718f61ab49e2.c6cbaf2b6329c21ba2ed2db7bade8d600(source5.Select(selector5));
					}
					switch (this.c4404a159870bf55bb6f111e66e59e82d.cc80b541ea0aecdb8c28ad57f43ca8ab8 - (c14cf1f200b737cded2756d6ab302a149)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30920))
					{
					case 0:
						Application.SetSuspendState((PowerState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30940) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30944) != 0);
						break;
					case 1:
						Process.Start(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99400), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99417));
						break;
					case 2:
						Application.SetSuspendState((PowerState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30924), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30928) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30932) != 0);
						break;
					}
					this.c4404a159870bf55bb6f111e66e59e82d.c9368dc60d61608581f0b9ed666b65c81(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99432));
				}
				cb6cc9a5b122137bc5f2718f61ab49e59 cb6cc9a5b122137bc5f2718f61ab49e3 = this.c4404a159870bf55bb6f111e66e59e82d;
				bool c7fce42bedd63c230a93e4fd9929be81b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30948) != 0;
				bool c772c2a45dacf5b536932a18299457e5a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30952) != 0;
				IEnumerable<ListViewDataItem> items5 = this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items;
				Func<ListViewDataItem, bool> predicate5;
				if ((predicate5 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c1a9270e20a011be8a20fe40a19f35801) == null)
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
					predicate5 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c1a9270e20a011be8a20fe40a19f35801 = new Func<ListViewDataItem, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c9cb94c6baff030a4f02e97349942a844));
				}
				IEnumerable<ListViewDataItem> source6 = items5.Where(predicate5);
				Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48> selector6;
				if ((selector6 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c6de494c2c74fe329fab6b91322bdee03) == null)
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
					selector6 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c6de494c2c74fe329fab6b91322bdee03 = new Func<ListViewDataItem, c5409344e1c2b74fa8c9a4d620ccb8d48>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c9dfed82e3b5ec34a222426d869eec009));
				}
				cb6cc9a5b122137bc5f2718f61ab49e3.c9cce42bf08ecabb93b709c62348f4ff2(c7fce42bedd63c230a93e4fd9929be81b, c772c2a45dacf5b536932a18299457e5a, source6.Select(selector6).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>());
				IEnumerable<ListViewDataItem> source7 = this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items.ToArray<ListViewDataItem>();
				Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc> selector7;
				if ((selector7 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cea92505f3f31d2f4ebbf19f41bbc7424) == null)
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
					selector7 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cea92505f3f31d2f4ebbf19f41bbc7424 = new Func<ListViewDataItem, c6114b34ba4893a53ebb4b599e0e2e3fc>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c952c6730e00372d22e86a2fabdb8f721));
				}
				IEnumerable<c6114b34ba4893a53ebb4b599e0e2e3fc> source8 = source7.Select(selector7);
				Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool> predicate6;
				if ((predicate6 = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc341695325278e219b6123bdd68eebd2) == null)
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
					predicate6 = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cc341695325278e219b6123bdd68eebd2 = new Func<c6114b34ba4893a53ebb4b599e0e2e3fc, bool>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.cb7ed7c437587cfc6e47728c7034ec446));
				}
				enumerator = source8.Where(predicate6).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb = enumerator.Current;
						this.c4404a159870bf55bb6f111e66e59e82d.ca2c48e1c97d1d33cc1892702fc491b36(c804bc52f7f79bffee6fd394ef382eb);
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
				this.c4404a159870bf55bb6f111e66e59e82d.c1a9805b730a3a6a37657fc751e3ceb86(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30956) != 0);
				try
				{
					TaskbarManager.Instance.SetProgressState(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30960));
				}
				catch
				{
				}
				this.c4404a159870bf55bb6f111e66e59e82d.CurrentlyDownloading = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30964) != 0);
				this.c4404a159870bf55bb6f111e66e59e82d.c9b5265c0946a689327a8c65feda18f1e();
				this.c4404a159870bf55bb6f111e66e59e82d.cf95ba3b48fd484ff24b6901d8a9a1280();
			}

			// Token: 0x0400079E RID: 1950
			public c8e60ceced0ce323f661e853233d10ec2 cdf15457ee4816989343b6e6e96dd4cfe;

			// Token: 0x0400079F RID: 1951
			public object cd7b28952603b35a45c555982e677363a;

			// Token: 0x040007A0 RID: 1952
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200017B RID: 379
		[CompilerGenerated]
		private sealed class c00a6690bc16529620e74de9a3a557882
		{
			// Token: 0x06000A0B RID: 2571 RVA: 0x00062224 File Offset: 0x00060424
			internal void c0c8e0e278c75b9dfeb449ee2e029ee91()
			{
				if (this.c12d0d8e4a348d50592ec186ea66a67ef != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c00a6690bc16529620e74de9a3a557882.c0c8e0e278c75b9dfeb449ee2e029ee91()).MethodHandle;
					}
					if (this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame == this.c6b7fbe462f43433d64916e9273f7e5d1)
					{
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.RatingInfo != null)
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
							this.c4404a159870bf55bb6f111e66e59e82d.cfcf06297d6af778ba0b09395fc2f7071.ImageLocation = this.c12d0d8e4a348d50592ec186ea66a67ef.RatingInfo.Rating.Icons.Icon[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30968)].Url;
						}
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.StarRatingInfo != null)
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
							this.c4404a159870bf55bb6f111e66e59e82d.c4f35dae606400f2b70610e42660e5131.Value1 = (int)(this.c12d0d8e4a348d50592ec186ea66a67ef.StarRatingInfo.Score * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(30972));
						}
						else
						{
							this.c4404a159870bf55bb6f111e66e59e82d.c4f35dae606400f2b70610e42660e5131.Value1 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30980);
						}
						Control c804e4fd2d6278fa319994b7cce512f = this.c4404a159870bf55bb6f111e66e59e82d.c804e4fd2d6278fa319994b7cce512f68;
						string text;
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.NumberOfPlayers == null)
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
							text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661);
						}
						else
						{
							text = this.c12d0d8e4a348d50592ec186ea66a67ef.NumberOfPlayers.c9923984bbcd35cab01b4f524fb06ba16();
						}
						c804e4fd2d6278fa319994b7cce512f.Text = text;
						this.c4404a159870bf55bb6f111e66e59e82d.cc8daf5b987048692fcf54da7b699bd9c.Items.Clear();
						this.c4404a159870bf55bb6f111e66e59e82d.c81df6c6c9171f63a101b1da4f2500688.Items.Clear();
						this.c4404a159870bf55bb6f111e66e59e82d.c9ee36b748e08e7ea591f948c93e868a5.Items.Clear();
						this.c4404a159870bf55bb6f111e66e59e82d.ce2c7d9939c522d450f3df76cfe177c8f.Items.Clear();
						c480a47b700b08811151497a080069323 playStyles = this.c12d0d8e4a348d50592ec186ea66a67ef.PlayStyles;
						bool flag;
						if (playStyles == null)
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
							flag = (null != null);
						}
						else
						{
							flag = (playStyles.PlayStyle[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30984)].Controllers != null);
						}
						if (flag)
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
							using (List<c917f36174285ae8be4b419849165b6f8>.Enumerator enumerator = this.c12d0d8e4a348d50592ec186ea66a67ef.PlayStyles.PlayStyle[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30988)].Controllers.Controller.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									c917f36174285ae8be4b419849165b6f8 c917f36174285ae8be4b419849165b6f = enumerator.Current;
									this.c4404a159870bf55bb6f111e66e59e82d.cc8daf5b987048692fcf54da7b699bd9c.Items.Add(c917f36174285ae8be4b419849165b6f.Name);
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
						}
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.Genres != null)
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
							using (List<c36b9340677bb6c50a561f64be5925efa>.Enumerator enumerator2 = this.c12d0d8e4a348d50592ec186ea66a67ef.Genres.Genre.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									c36b9340677bb6c50a561f64be5925efa c36b9340677bb6c50a561f64be5925efa = enumerator2.Current;
									this.c4404a159870bf55bb6f111e66e59e82d.c9ee36b748e08e7ea591f948c93e868a5.Items.Add(c36b9340677bb6c50a561f64be5925efa.Name);
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
							}
						}
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.Movies != null)
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
							using (List<ceaf02aeeb578404b88907d58ccbca101>.Enumerator enumerator3 = this.c12d0d8e4a348d50592ec186ea66a67ef.Movies.Movie.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									ceaf02aeeb578404b88907d58ccbca101 ceaf02aeeb578404b88907d58ccbca = enumerator3.Current;
									ListViewDataItem listViewDataItem = new ListViewDataItem(ceaf02aeeb578404b88907d58ccbca.Name)
									{
										Tag = ceaf02aeeb578404b88907d58ccbca
									};
									this.c4404a159870bf55bb6f111e66e59e82d.c81df6c6c9171f63a101b1da4f2500688.Items.Add(listViewDataItem);
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
						}
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.Languages != null)
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
							ListViewDataItemCollection items = this.c4404a159870bf55bb6f111e66e59e82d.ce2c7d9939c522d450f3df76cfe177c8f.Items;
							IEnumerable<cb5efed8fc8338f060f0a22f597211902> language = this.c12d0d8e4a348d50592ec186ea66a67ef.Languages.Language;
							Func<cb5efed8fc8338f060f0a22f597211902, ListViewDataItem> selector;
							if ((selector = cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c79a8c6aa2dd0e306841e216e929c240e) == null)
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
								selector = (cb6cc9a5b122137bc5f2718f61ab49e59.<>c.c79a8c6aa2dd0e306841e216e929c240e = new Func<cb5efed8fc8338f060f0a22f597211902, ListViewDataItem>(cb6cc9a5b122137bc5f2718f61ab49e59.<>c.cdfab1996eb8651828de2a4469aa3481e.c56e660b9b444104b11aeccb10be43868));
							}
							items.AddRange(language.Select(selector).ToArray<ListViewDataItem>());
						}
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.Description != null)
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
							Control c9202010bbeb5a869433736d6d3edf68b = this.c4404a159870bf55bb6f111e66e59e82d.c9202010bbeb5a869433736d6d3edf68b;
							string description = this.c12d0d8e4a348d50592ec186ea66a67ef.Description;
							string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30992));
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30996)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99497);
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31000)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99508);
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31004)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99519);
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31008)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99528);
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31012)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99541);
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31016)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11207);
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31020)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99550);
							c9202010bbeb5a869433736d6d3edf68b.Text = description.c101c3ac509a256ea4f07e70c3d1ca1a4(array, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11210)).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99561), Environment.NewLine).c9923984bbcd35cab01b4f524fb06ba16();
						}
						else
						{
							this.c4404a159870bf55bb6f111e66e59e82d.c9202010bbeb5a869433736d6d3edf68b.Text = "";
						}
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.Copyright != null)
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
							if (this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31024))
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
								RadTextBoxControl c9202010bbeb5a869433736d6d3edf68b2 = this.c4404a159870bf55bb6f111e66e59e82d.c9202010bbeb5a869433736d6d3edf68b;
								c9202010bbeb5a869433736d6d3edf68b2.Text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c9202010bbeb5a869433736d6d3edf68b2.Text, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99566), Environment.NewLine, Environment.NewLine, this.c12d0d8e4a348d50592ec186ea66a67ef.Copyright.Text));
							}
						}
						if (this.c6b7fbe462f43433d64916e9273f7e5d1.c9e33774c6343e7c7fe83022678b014ae)
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
							RadTextBoxControl c9202010bbeb5a869433736d6d3edf68b3 = this.c4404a159870bf55bb6f111e66e59e82d.c9202010bbeb5a869433736d6d3edf68b;
							c9202010bbeb5a869433736d6d3edf68b3.Text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c9202010bbeb5a869433736d6d3edf68b3.Text, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99615), Environment.NewLine, Environment.NewLine));
						}
						this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.c37137df1274eeaf494a83b79943d89e2.cfa21bb8cd0447cf1c81dd418c08ca898 += this.c4404a159870bf55bb6f111e66e59e82d.cb0663c83842cabe396de5563ce2e0ca7;
						if (this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31028))
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
							if (this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31032))
							{
								c105c88e162b3faac8e1371ca90f921c5 c37137df1274eeaf494a83b79943d89e = this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.c37137df1274eeaf494a83b79943d89e2;
								string cbc47e314a0f1d7d5f1d07b50ba2bb8c;
								if ((cbc47e314a0f1d7d5f1d07b50ba2bb8c = this.c12d0d8e4a348d50592ec186ea66a67ef.CustomCoverUrl) == null)
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
									cbc47e314a0f1d7d5f1d07b50ba2bb8c = this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.c5665d7b9f8d8c4130a023e2e716f86bb;
								}
								c37137df1274eeaf494a83b79943d89e.c142384818e91b48255429b5c59e8b8c7(cbc47e314a0f1d7d5f1d07b50ba2bb8c, TimeSpan.FromDays(cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(31044)));
								goto IL_808;
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
						}
						c105c88e162b3faac8e1371ca90f921c5 c37137df1274eeaf494a83b79943d89e2 = this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.c37137df1274eeaf494a83b79943d89e2;
						string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99777);
						object arg;
						if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3752)))
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
							if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46688)))
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
								arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
							}
							else
							{
								arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3766);
							}
						}
						else
						{
							arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3776);
						}
						c37137df1274eeaf494a83b79943d89e2.c142384818e91b48255429b5c59e8b8c7(string.Format(format, arg, this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.ProductId), TimeSpan.FromDays(cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(31036)));
						IL_808:
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.BannerUrl != null)
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
							this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.c43a36c2ec69a55ef18526fe33b26814a.cfa21bb8cd0447cf1c81dd418c08ca898 += this.c4404a159870bf55bb6f111e66e59e82d.c00550c458f3820261378f8287f48178c;
							this.c4404a159870bf55bb6f111e66e59e82d.SelectedGame.c43a36c2ec69a55ef18526fe33b26814a.c142384818e91b48255429b5c59e8b8c7(this.c12d0d8e4a348d50592ec186ea66a67ef.BannerUrl, TimeSpan.FromDays(cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(31052)));
						}
						else
						{
							this.c4404a159870bf55bb6f111e66e59e82d.c6a2b595cc5d4feecae7d4d122a8f1dce.Image = c6faa5467be1a4874657b372a49b7c927.banner;
						}
						this.c4404a159870bf55bb6f111e66e59e82d.c90920141366a2a6842000aa35290ab9a();
						if (this.c12d0d8e4a348d50592ec186ea66a67ef.Screenshots != null)
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
							if (this.c12d0d8e4a348d50592ec186ea66a67ef.Screenshots.Screenshot.Count >= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31060))
							{
								this.c4404a159870bf55bb6f111e66e59e82d.cbe7fa4761f85da94859280c8565879f4.ImageLocation = this.c12d0d8e4a348d50592ec186ea66a67ef.Screenshots.Screenshot[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31064)].ImageUrl[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31068)].Value;
								this.c4404a159870bf55bb6f111e66e59e82d.cb4a1967318bc2f47a2a97d027e20d00f.ImageLocation = this.c12d0d8e4a348d50592ec186ea66a67ef.Screenshots.Screenshot[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31072)].ImageUrl[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31076)].Value;
								this.c4404a159870bf55bb6f111e66e59e82d.cf79908ea7fb179e130decfd49ac2942e.ImageLocation = this.c12d0d8e4a348d50592ec186ea66a67ef.Screenshots.Screenshot[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31080)].ImageUrl[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31084)].Value;
								return;
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
						}
						return;
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
			}

			// Token: 0x040007A1 RID: 1953
			public cbdbecb4f2aabec5734fa1432e4548f8e c12d0d8e4a348d50592ec186ea66a67ef;

			// Token: 0x040007A2 RID: 1954
			public c5409344e1c2b74fa8c9a4d620ccb8d48 c6b7fbe462f43433d64916e9273f7e5d1;

			// Token: 0x040007A3 RID: 1955
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200017C RID: 380
		[CompilerGenerated]
		private sealed class cf4f59705acff7d6c16d20af8f0dcebf0
		{
			// Token: 0x06000A0D RID: 2573 RVA: 0x00062C58 File Offset: 0x00060E58
			internal void ccb5cd4689f49400c04253c2402e3fe24()
			{
				this.cb71ed553427ab25a7e93785c401bf15e = this.c4404a159870bf55bb6f111e66e59e82d.c1ea55cbd3cc08e542bac463cec6ba4b0(Settings.Default.TicketsPath);
				this.cbae86ce8e86f685d425d3909090f56be = this.c4404a159870bf55bb6f111e66e59e82d.c1ea55cbd3cc08e542bac463cec6ba4b0(Settings.Default.TicketsPath3DS);
			}

			// Token: 0x06000A0E RID: 2574 RVA: 0x00062CA8 File Offset: 0x00060EA8
			internal void c090e9fe83fd515f795500c243fc80a65()
			{
				this.cb71ed553427ab25a7e93785c401bf15e = this.c4404a159870bf55bb6f111e66e59e82d.c1ea55cbd3cc08e542bac463cec6ba4b0(Settings.Default.TicketsPath);
				this.cbae86ce8e86f685d425d3909090f56be = this.c4404a159870bf55bb6f111e66e59e82d.c1ea55cbd3cc08e542bac463cec6ba4b0(Settings.Default.TicketsPath3DS);
			}

			// Token: 0x040007A4 RID: 1956
			public byte[] cb71ed553427ab25a7e93785c401bf15e;

			// Token: 0x040007A5 RID: 1957
			public byte[] cbae86ce8e86f685d425d3909090f56be;

			// Token: 0x040007A6 RID: 1958
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;

			// Token: 0x040007A7 RID: 1959
			public Action c07d96df25e149ee1b99babd4357e18e6;
		}

		// Token: 0x0200017D RID: 381
		[CompilerGenerated]
		private sealed class cdbb18f05d7e7d49d8fdf09a1c7da6b61
		{
			// Token: 0x06000A10 RID: 2576 RVA: 0x00062D0C File Offset: 0x00060F0C
			internal void c6cd9e1056fc8582598a1f332ed982fe1()
			{
				try
				{
					this.c4404a159870bf55bb6f111e66e59e82d.IndexGameCurrentlyDownloaded = this.c26822581df016083af37ec10f7059fe9.Index;
					if (this.c4404a159870bf55bb6f111e66e59e82d.IndexGameCurrentlyDownloaded > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31088))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cdbb18f05d7e7d49d8fdf09a1c7da6b61.c6cd9e1056fc8582598a1f332ed982fe1()).MethodHandle;
						}
						this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items[this.c4404a159870bf55bb6f111e66e59e82d.IndexGameCurrentlyDownloaded - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31092)].ForeColor = Color.Green;
					}
					this.c4404a159870bf55bb6f111e66e59e82d.c2fb6dd895d1ff7ecd48bea8f8087cbe2.Items[this.c4404a159870bf55bb6f111e66e59e82d.IndexGameCurrentlyDownloaded].ForeColor = Color.Orange;
					this.c4404a159870bf55bb6f111e66e59e82d.cbb0b4fa2ccd34211c18c0710f18f2c81.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99870), this.c26822581df016083af37ec10f7059fe9.Title);
				}
				catch
				{
				}
			}

			// Token: 0x040007A8 RID: 1960
			public ca4d60b23ae6cb20ad43302467e6dc9e1 c26822581df016083af37ec10f7059fe9;

			// Token: 0x040007A9 RID: 1961
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200017E RID: 382
		[CompilerGenerated]
		private sealed class c3fa9894a956fdd3bdbb07868f084de7d
		{
			// Token: 0x06000A12 RID: 2578 RVA: 0x00062E28 File Offset: 0x00061028
			internal void ce371869618e7f44a30be714e1d62f04c()
			{
				this.c4404a159870bf55bb6f111e66e59e82d.c6a2b595cc5d4feecae7d4d122a8f1dce.Image = this.cdf15457ee4816989343b6e6e96dd4cfe.cac284206d35391c088895a9ff8e73b2f;
				this.c4404a159870bf55bb6f111e66e59e82d.c90920141366a2a6842000aa35290ab9a();
			}

			// Token: 0x040007AA RID: 1962
			public c797ec1388c1af11408ef86282cc1652a cdf15457ee4816989343b6e6e96dd4cfe;

			// Token: 0x040007AB RID: 1963
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200017F RID: 383
		[CompilerGenerated]
		private sealed class c95c08abb7a43bf613f6fde7fe87bb289
		{
			// Token: 0x06000A14 RID: 2580 RVA: 0x00062E70 File Offset: 0x00061070
			internal void c09e98b7e51e2b70d06987f42d6e4ee90()
			{
				this.c4404a159870bf55bb6f111e66e59e82d.c0e1873c97ed5c28183d8a02dcecefe22.Image = this.cdf15457ee4816989343b6e6e96dd4cfe.cac284206d35391c088895a9ff8e73b2f;
			}

			// Token: 0x040007AC RID: 1964
			public c797ec1388c1af11408ef86282cc1652a cdf15457ee4816989343b6e6e96dd4cfe;

			// Token: 0x040007AD RID: 1965
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000180 RID: 384
		[CompilerGenerated]
		private sealed class c0cf082517811518034f0a0f661056f40
		{
			// Token: 0x040007AE RID: 1966
			public ListViewDataItem cdaf1e048076cb48032279ef3fd414f27;

			// Token: 0x040007AF RID: 1967
			public cb6cc9a5b122137bc5f2718f61ab49e59.c08836558b43d118f4045e307eb6c9221 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x02000181 RID: 385
		[CompilerGenerated]
		private sealed class cbd44e8f42a43b6040860da776d7c6472
		{
			// Token: 0x06000A17 RID: 2583 RVA: 0x00062EC0 File Offset: 0x000610C0
			internal void c44cfccccf8c1a797734b1a7af677947b()
			{
				this.c9def284befdb85aa51808c134f9b5700.cdaf1e048076cb48032279ef3fd414f27.Image = this.c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image;
			}

			// Token: 0x06000A18 RID: 2584 RVA: 0x00062EF0 File Offset: 0x000610F0
			internal void c1ce94f2a4a69cbbb198191b6fc2017ce()
			{
				try
				{
					if (this.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cf7f61cc59e2808aad0d77629a4b89af8)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cbd44e8f42a43b6040860da776d7c6472.c1ce94f2a4a69cbbb198191b6fc2017ce()).MethodHandle;
						}
						return;
					}
					string text = c67726bc94fb4dd43c5c00e863a4fed19.cd78b75c0acd1a4205371a6b84b5b766a(this.c6fcdfcca42c1aeed647bdea8d9051572.IconUrl);
					string text2 = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, text);
					if (!c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(text))
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
						MemoryStream memoryStream = new MemoryStream(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(this.c6fcdfcca42c1aeed647bdea8d9051572.IconUrl));
						try
						{
							new Bitmap(Image.FromStream(memoryStream), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31096), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31100)).Save(text2, ImageFormat.Png);
						}
						finally
						{
							if (memoryStream != null)
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
								((IDisposable)memoryStream).Dispose();
							}
						}
					}
					MemoryStream stream = new MemoryStream(File.ReadAllBytes(text2));
					this.c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image = Image.FromStream(stream);
					cb6cc9a5b122137bc5f2718f61ab49e59.cf9c50c376f7589fb13d15a3b0a2bd920(this.c6fcdfcca42c1aeed647bdea8d9051572);
					Control c4404a159870bf55bb6f111e66e59e82d = this.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d;
					Action method;
					if ((method = this.c07d96df25e149ee1b99babd4357e18e6) == null)
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
						method = (this.c07d96df25e149ee1b99babd4357e18e6 = new Action(this.c4345cad105b8f102080124f1132a7939));
					}
					c4404a159870bf55bb6f111e66e59e82d.Invoke(method);
				}
				catch
				{
				}
				int c3b711929d76da2da5e4dfd39ca14682f = this.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c3b711929d76da2da5e4dfd39ca14682f;
				this.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c3b711929d76da2da5e4dfd39ca14682f = c3b711929d76da2da5e4dfd39ca14682f - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31104);
			}

			// Token: 0x06000A19 RID: 2585 RVA: 0x000630A8 File Offset: 0x000612A8
			internal void c4345cad105b8f102080124f1132a7939()
			{
				this.c9def284befdb85aa51808c134f9b5700.cdaf1e048076cb48032279ef3fd414f27.Image = this.c6fcdfcca42c1aeed647bdea8d9051572.c1b244cd4be573ae37f8e3f6fd69b891f.Image;
			}

			// Token: 0x040007B0 RID: 1968
			public c5409344e1c2b74fa8c9a4d620ccb8d48 c6fcdfcca42c1aeed647bdea8d9051572;

			// Token: 0x040007B1 RID: 1969
			public cb6cc9a5b122137bc5f2718f61ab49e59.c0cf082517811518034f0a0f661056f40 c9def284befdb85aa51808c134f9b5700;

			// Token: 0x040007B2 RID: 1970
			public Action c07d96df25e149ee1b99babd4357e18e6;
		}

		// Token: 0x02000182 RID: 386
		[CompilerGenerated]
		private sealed class c08836558b43d118f4045e307eb6c9221
		{
			// Token: 0x040007B3 RID: 1971
			public int c3b711929d76da2da5e4dfd39ca14682f;

			// Token: 0x040007B4 RID: 1972
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000183 RID: 387
		[CompilerGenerated]
		private sealed class c9af8b2d91f68d81794ed34dc6cdb6e85
		{
			// Token: 0x06000A1C RID: 2588 RVA: 0x00063100 File Offset: 0x00061300
			internal void c4f1457ae0a2f7c83dc7efb1d1e37078d()
			{
				this.c4404a159870bf55bb6f111e66e59e82d.c70e980dd6de0ea664d1165b0bab9c505.Value1 = this.c3c9260886a6db15de49329a9f5b9836c.GameProgress;
				this.c4404a159870bf55bb6f111e66e59e82d.c271cb122814a1639c9b4c33232d68a4b.Value1 = this.c3c9260886a6db15de49329a9f5b9836c.TotalProgress;
				try
				{
					TaskbarManager.Instance.SetProgressValue(this.c3c9260886a6db15de49329a9f5b9836c.TotalProgress, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31108));
				}
				catch
				{
				}
				cb6cc9a5b122137bc5f2718f61ab49e59.cc5c57405ebb88aff3ea74e2576a29bb0(this.c3c9260886a6db15de49329a9f5b9836c.GameEta, this.c4404a159870bf55bb6f111e66e59e82d.c334cd5fa87833f636046cdbd48987d99);
				cb6cc9a5b122137bc5f2718f61ab49e59.cc5c57405ebb88aff3ea74e2576a29bb0(this.c3c9260886a6db15de49329a9f5b9836c.TotalEta, this.c4404a159870bf55bb6f111e66e59e82d.c13964aec72502e7656b1ae19a819aff9);
				cb6cc9a5b122137bc5f2718f61ab49e59.cc5c57405ebb88aff3ea74e2576a29bb0(this.c3c9260886a6db15de49329a9f5b9836c.FileEta, this.c4404a159870bf55bb6f111e66e59e82d.c5ef121095a54af022617ead3cdccfecd);
				this.c4404a159870bf55bb6f111e66e59e82d.c5c0da2c4ace7b32f1e7344aa4557ff66.Value1 = this.c3c9260886a6db15de49329a9f5b9836c.FileProgress;
				this.c4404a159870bf55bb6f111e66e59e82d.c1bde3fed671b57fd27277d86860af4b4.Value = this.c3c9260886a6db15de49329a9f5b9836c.Speed.c5d7bf84d590334ae5c615432db3d63e7 * (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31112)) / cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(31116);
				this.c4404a159870bf55bb6f111e66e59e82d.c26a23c3f9ed64e91c418484270f55fcc.Text = this.c3c9260886a6db15de49329a9f5b9836c.Speed.ToString();
			}

			// Token: 0x040007B5 RID: 1973
			public ce91c3ee3b6503970820b59a90b300d72 c3c9260886a6db15de49329a9f5b9836c;

			// Token: 0x040007B6 RID: 1974
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000184 RID: 388
		[CompilerGenerated]
		private sealed class ceba9cb62acaa388b04961473f99877eb
		{
			// Token: 0x06000A1E RID: 2590 RVA: 0x00063270 File Offset: 0x00061470
			internal void cc6a3f126d7c2bf1b60d6e64d13d22ded()
			{
				this.c561c2db76c5bf8c95a684eca3517d61c.ShowDialog();
			}

			// Token: 0x040007B7 RID: 1975
			public c60797b4f8bfa489df1954dcdc88ad77d c561c2db76c5bf8c95a684eca3517d61c;
		}

		// Token: 0x02000185 RID: 389
		[CompilerGenerated]
		private sealed class c5fe8a571ca3377e5a24fe8e769bc8d25
		{
			// Token: 0x06000A20 RID: 2592 RVA: 0x000632A0 File Offset: 0x000614A0
			internal bool cc7548541ae564588f4a2204df2a6e8e3(ListViewDataItem cdeb883c40f9a2378d88e71037beec6cb)
			{
				return cdeb883c40f9a2378d88e71037beec6cb.Tag == this.c804bc52f7f79bffee6fd394ef382eb76;
			}

			// Token: 0x040007B8 RID: 1976
			public c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76;
		}

		// Token: 0x02000186 RID: 390
		[CompilerGenerated]
		private sealed class ce0c512d7c52b3814ee231b12a3adb557
		{
			// Token: 0x06000A22 RID: 2594 RVA: 0x000632D4 File Offset: 0x000614D4
			internal bool cdcef1d1089ec61f3faf12e4e4b38a439(ListViewDataItem cdeb883c40f9a2378d88e71037beec6cb)
			{
				return cdeb883c40f9a2378d88e71037beec6cb.Tag == this.c804bc52f7f79bffee6fd394ef382eb76;
			}

			// Token: 0x040007B9 RID: 1977
			public c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76;
		}

		// Token: 0x02000187 RID: 391
		[CompilerGenerated]
		private sealed class c48d3e7e50fe1b61a60e967225f65ce0c
		{
			// Token: 0x06000A24 RID: 2596 RVA: 0x00063308 File Offset: 0x00061508
			internal void c60d43931a57fead4f3888acfa2f734a2()
			{
				if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.TicketsPath, ""))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.c48d3e7e50fe1b61a60e967225f65ce0c.c60d43931a57fead4f3888acfa2f734a2()).MethodHandle;
					}
					this.c1e9648e54295aa0c92cd31a9812e8b5d = new c866035f717c1c145e269422264e8f519().cf974603cc086c68eafb242ca5199a108(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.TicketsPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99907)));
				}
				if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.TicketsPath3DS, ""))
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
					this.c9913ed79662a90a996cbddf5b4c4e906 = new c866035f717c1c145e269422264e8f519().cf974603cc086c68eafb242ca5199a108(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.TicketsPath3DS, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99907)));
				}
			}

			// Token: 0x040007BA RID: 1978
			public byte[] c1e9648e54295aa0c92cd31a9812e8b5d;

			// Token: 0x040007BB RID: 1979
			public byte[] c9913ed79662a90a996cbddf5b4c4e906;
		}

		// Token: 0x02000188 RID: 392
		[CompilerGenerated]
		private sealed class cb517ca393ca1d7c5b9752f5faf9e7342
		{
			// Token: 0x06000A26 RID: 2598 RVA: 0x000633E4 File Offset: 0x000615E4
			internal void c2a2ee1fbb3c7da931aac719c272fe2fb()
			{
				this.c4404a159870bf55bb6f111e66e59e82d.BringToFront();
				RadMessageBox.Show(this.cfeefea196000bed18adf05bf7727db15);
			}

			// Token: 0x040007BC RID: 1980
			public string cfeefea196000bed18adf05bf7727db15;

			// Token: 0x040007BD RID: 1981
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000189 RID: 393
		[CompilerGenerated]
		private sealed class c860fb806500f615dda89ece894c97127
		{
			// Token: 0x06000A28 RID: 2600 RVA: 0x00063420 File Offset: 0x00061620
			internal bool cd1502936a09bf7cccd7e0aeb79a8eeb6(string ced17f5fac5de96d8d690dac7cea067a7)
			{
				cb6cc9a5b122137bc5f2718f61ab49e59.cd9ad0257feee92e515ee32be03d89a26 cd9ad0257feee92e515ee32be03d89a = new cb6cc9a5b122137bc5f2718f61ab49e59.cd9ad0257feee92e515ee32be03d89a26();
				cd9ad0257feee92e515ee32be03d89a.ced17f5fac5de96d8d690dac7cea067a7 = ced17f5fac5de96d8d690dac7cea067a7;
				return this.ce56c4d37037c859fea445fea7f3c46b3.Any(new Func<string, bool>(cd9ad0257feee92e515ee32be03d89a.cbcb199b59159e0b7aa7cbb33cb5ab9e1));
			}

			// Token: 0x040007BE RID: 1982
			public string[] ce56c4d37037c859fea445fea7f3c46b3;
		}

		// Token: 0x0200018A RID: 394
		[CompilerGenerated]
		private sealed class cd9ad0257feee92e515ee32be03d89a26
		{
			// Token: 0x06000A2A RID: 2602 RVA: 0x00063468 File Offset: 0x00061668
			internal bool cbcb199b59159e0b7aa7cbb33cb5ab9e1(string c9c0572bf543aa5457384eff53093bc47)
			{
				return c9c0572bf543aa5457384eff53093bc47.Contains(this.ced17f5fac5de96d8d690dac7cea067a7);
			}

			// Token: 0x040007BF RID: 1983
			public string ced17f5fac5de96d8d690dac7cea067a7;
		}

		// Token: 0x0200018B RID: 395
		[CompilerGenerated]
		private sealed class c03e1373e570a2ba4e081181081af3669
		{
			// Token: 0x06000A2C RID: 2604 RVA: 0x00063498 File Offset: 0x00061698
			internal void c59f6083c978c3fd39a8769f19cd035b7()
			{
				this.c4404a159870bf55bb6f111e66e59e82d.c7cb15ecb80bee59937d269db8297ea4b.Items.Add(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(82768), this.c4404a159870bf55bb6f111e66e59e82d.c7cb15ecb80bee59937d269db8297ea4b.Items.Count + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31120), this.c3d57b353c405c58b3e7b1741fb443d42));
			}

			// Token: 0x040007C0 RID: 1984
			public string c3d57b353c405c58b3e7b1741fb443d42;

			// Token: 0x040007C1 RID: 1985
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200018C RID: 396
		[CompilerGenerated]
		private sealed class cb2069e67c6643bfdffabf9f9e920acdf
		{
			// Token: 0x06000A2E RID: 2606 RVA: 0x00063514 File Offset: 0x00061714
			internal void c8f83ca666babb7f02388d7079dd000a0()
			{
				if (c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(DateTime.Now, this.c4404a159870bf55bb6f111e66e59e82d.c499a936dcf58ee5e0196d68d13371fb0).TotalMilliseconds > cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(31124))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb6cc9a5b122137bc5f2718f61ab49e59.cb2069e67c6643bfdffabf9f9e920acdf.c8f83ca666babb7f02388d7079dd000a0()).MethodHandle;
					}
					this.c4404a159870bf55bb6f111e66e59e82d.c72e7acdf474b857eac13b63d8d3e3e7f = c2582c4b138328468a34a28a74fc5bc5f.cab55a050df275722227783d6686266c9;
				}
				Control ce9e5aa178e2af36d04f863bccc94f85b = this.c4404a159870bf55bb6f111e66e59e82d.ce9e5aa178e2af36d04f863bccc94f85b;
				string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99918);
				object arg;
				if (this.c4404a159870bf55bb6f111e66e59e82d.c72e7acdf474b857eac13b63d8d3e3e7f != null)
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
					arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(99963);
				}
				else
				{
					arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(100095);
				}
				object arg2;
				if (this.c870f09a03fcd42fab9aef6249ddf6756 <= (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(31132)))
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
					arg2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(100299);
				}
				else
				{
					arg2 = new DataSize(this.c870f09a03fcd42fab9aef6249ddf6756).ToString();
				}
				ce9e5aa178e2af36d04f863bccc94f85b.Text = string.Format(format, arg, arg2);
			}

			// Token: 0x040007C2 RID: 1986
			public ulong c870f09a03fcd42fab9aef6249ddf6756;

			// Token: 0x040007C3 RID: 1987
			public cb6cc9a5b122137bc5f2718f61ab49e59 c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
