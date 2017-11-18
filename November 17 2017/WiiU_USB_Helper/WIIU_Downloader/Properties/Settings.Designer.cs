using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using A;

namespace WIIU_Downloader.Properties
{
	// Token: 0x020000B2 RID: 178
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x000298A4 File Offset: 0x00027AA4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000298B8 File Offset: 0x00027AB8
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x000298E0 File Offset: 0x00027AE0
		[DefaultSettingValue("NONE")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string Region
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46477)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46477)] = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00029900 File Offset: 0x00027B00
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00029928 File Offset: 0x00027B28
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool Cleanup
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46490)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46490)] = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00029950 File Offset: 0x00027B50
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00029978 File Offset: 0x00027B78
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string Path
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46505)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46505)] = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00029998 File Offset: 0x00027B98
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x000299C0 File Offset: 0x00027BC0
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string TicketsPath
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46514)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46514)] = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000299E0 File Offset: 0x00027BE0
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00029A08 File Offset: 0x00027C08
		[DefaultSettingValue("DarkBlue")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ThemeName
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46537)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46537)] = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00029A28 File Offset: 0x00027C28
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00029A50 File Offset: 0x00027C50
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool CompactView
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46556)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46556)] = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00029A78 File Offset: 0x00027C78
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00029AA0 File Offset: 0x00027CA0
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ShowLegit
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46579)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46579)] = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00029AC8 File Offset: 0x00027CC8
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00029AF0 File Offset: 0x00027CF0
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ShowCFW
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46598)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46598)] = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00029B18 File Offset: 0x00027D18
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00029B40 File Offset: 0x00027D40
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool ShowEvents
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46613)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46613)] = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00029B68 File Offset: 0x00027D68
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00029B90 File Offset: 0x00027D90
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public long LastNewsDate
		{
			get
			{
				return c6426b5527f7b8ff53998d27f92a31eb8.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46634)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46634)] = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00029BB8 File Offset: 0x00027DB8
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00029BE0 File Offset: 0x00027DE0
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string TicketsPath3DS
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46659)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46659)] = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00029C00 File Offset: 0x00027E00
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00029C28 File Offset: 0x00027E28
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool EUR
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3752)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3752)] = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00029C50 File Offset: 0x00027E50
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00029C78 File Offset: 0x00027E78
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool JPN
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46688)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46688)] = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00029CA0 File Offset: 0x00027EA0
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00029CC8 File Offset: 0x00027EC8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool USA
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)] = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00029CF0 File Offset: 0x00027EF0
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00029D18 File Offset: 0x00027F18
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string CemuExecutable
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46695)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46695)] = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00029D38 File Offset: 0x00027F38
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00029D60 File Offset: 0x00027F60
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string ExtractFolder
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46724)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46724)] = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00029D80 File Offset: 0x00027F80
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00029DA8 File Offset: 0x00027FA8
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string DonationKey
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46751)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46751)] = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00029DC8 File Offset: 0x00027FC8
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00029DF0 File Offset: 0x00027FF0
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int LaunchCount
		{
			get
			{
				return c5fed986b8e824b23e15a0cc51d8fcff1.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46774)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46774)] = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00029E18 File Offset: 0x00028018
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00029E40 File Offset: 0x00028040
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string Platforms
		{
			get
			{
				return c65bd087778fe433bb71e2f8427aab961.cd24593c859565ebb8c9faabbc5c75bef(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46797)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46797)] = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00029E60 File Offset: 0x00028060
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00029E88 File Offset: 0x00028088
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("0, 0, 0, 0")]
		public Rectangle WindowPosition
		{
			get
			{
				return cd9b4e7f42bf296df98c06187d4387ec0.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46816)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46816)] = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00029EB0 File Offset: 0x000280B0
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00029ED8 File Offset: 0x000280D8
		[UserScopedSetting]
		[DefaultSettingValue("Normal")]
		[DebuggerNonUserCode]
		public FormWindowState WindowState
		{
			get
			{
				return c83965a78c2b6c13eb008938f29c806cf.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46845)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46845)] = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00029F00 File Offset: 0x00028100
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00029F28 File Offset: 0x00028128
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ForceUpdates
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46868)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46868)] = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00029F50 File Offset: 0x00028150
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00029F78 File Offset: 0x00028178
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ShowHaxchiWarning
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46893)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46893)] = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00029FA0 File Offset: 0x000281A0
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00029FC8 File Offset: 0x000281C8
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool ForceUpdatesCitra
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46928)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46928)] = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00029FF0 File Offset: 0x000281F0
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0002A018 File Offset: 0x00028218
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ShowEmulatorDataWarning
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46963)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46963)] = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0002A040 File Offset: 0x00028240
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0002A068 File Offset: 0x00028268
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ShowProgramFilesWarning
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47010)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47010)] = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0002A090 File Offset: 0x00028290
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0002A0B8 File Offset: 0x000282B8
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ShowCitraWarning
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47057)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47057)] = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0002A0E0 File Offset: 0x000282E0
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0002A108 File Offset: 0x00028308
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool Show552Warning
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47090)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47090)] = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002A130 File Offset: 0x00028330
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0002A158 File Offset: 0x00028358
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ForceUpdatesDolphin
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47119)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47119)] = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0002A180 File Offset: 0x00028380
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0002A1A8 File Offset: 0x000283A8
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool KOR
		{
			get
			{
				return c857777604d3e02c3531d964ce79ea231.cb93115e3b63933899699d0ee8696f152(this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47158)]);
			}
			set
			{
				this[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47158)] = value;
			}
		}

		// Token: 0x0400032B RID: 811
		private static Settings defaultInstance = cb81303dc74fae215ab7acc21aed468fa.cd24593c859565ebb8c9faabbc5c75bef(SettingsBase.Synchronized(new Settings()));
	}
}
