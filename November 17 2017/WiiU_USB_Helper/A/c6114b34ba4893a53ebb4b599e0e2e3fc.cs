using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using Telerik.WinControls;

namespace A
{
	// Token: 0x02000036 RID: 54
	public abstract class c6114b34ba4893a53ebb4b599e0e2e3fc
	{
		// Token: 0x06000127 RID: 295 RVA: 0x0000C544 File Offset: 0x0000A744
		protected c6114b34ba4893a53ebb4b599e0e2e3fc(string c12d0d8e4a348d50592ec186ea66a67ef, TitleId c6446be850d2de5f37330117509aacef1, string cc3f904a2c5ba8f87204592c77530a0a6, byte[] c2bdc0253794dde45b70b2d85ceddacde, DataSize c5db06f710879d10bd98fa2c1adf0deb8, string c8bb3ca4a8bf4e6d064eef316d02aab52, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			this.Name = c12d0d8e4a348d50592ec186ea66a67ef;
			this.TitleId = c6446be850d2de5f37330117509aacef1;
			this.Region = cc3f904a2c5ba8f87204592c77530a0a6;
			this.TicketArray = c2bdc0253794dde45b70b2d85ceddacde;
			if (this.TicketArray != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc..ctor(string, TitleId, string, byte[], DataSize, string, ceee61848167c1ade885c85db30acc060)).MethodHandle;
				}
				this.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(c2bdc0253794dde45b70b2d85ceddacde, cd6f1966a966a6f1dabeb755aded4df42);
			}
			this.Size = c5db06f710879d10bd98fa2c1adf0deb8;
			this.RootDownloadLocation = c8bb3ca4a8bf4e6d064eef316d02aab52;
			this.System = cd6f1966a966a6f1dabeb755aded4df42;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		public int cce55c1c54594dc99c5eedaa006793af4
		{
			get
			{
				if (!this.c9e33774c6343e7c7fe83022678b014ae)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.get_cce55c1c54594dc99c5eedaa006793af4()).MethodHandle;
					}
					return cdb02a77cadec7790d5c7c433ab736a12.cfd18337e96368f224e9e36f94eb07d73(this.ce72dde540f1a33d33b690563b4b6907a(), (long)this.Size.TotalBytes);
				}
				if (this.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3368))
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
					return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3372);
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3376);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000C650 File Offset: 0x0000A850
		public bool c9e33774c6343e7c7fe83022678b014ae
		{
			get
			{
				if (this.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3380))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.get_c9e33774c6343e7c7fe83022678b014ae()).MethodHandle;
					}
					if (this.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3384))
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
						if (this.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3388))
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
							return this.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3392);
						}
					}
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3396) != 0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		public c5409344e1c2b74fa8c9a4d620ccb8d48 c804df2385fde29e562ce6680eeff8d7e
		{
			get
			{
				c5409344e1c2b74fa8c9a4d620ccb8d48 result;
				try
				{
					result = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[this.TitleId.FullGame];
				}
				catch
				{
					result = cb6125d5348736aea8498a2c9c6354bc4.cab55a050df275722227783d6686266c9;
				}
				return result;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000C728 File Offset: 0x0000A928
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000C73C File Offset: 0x0000A93C
		public bool CfwOnly { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000C750 File Offset: 0x0000A950
		public c59ff87f6bdc69ff3440c18f170633236 ca435006c85356cb7385a782de8889a0a
		{
			get
			{
				if (c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(DateTime.Now, this.c86afb23ad91bc7b787933e88a6e0ee86).TotalSeconds <= cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(3400))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.get_ca435006c85356cb7385a782de8889a0a()).MethodHandle;
					}
					return this.c9b4b3ff036c43766ecdc83ecf3f4ad37;
				}
				this.c86afb23ad91bc7b787933e88a6e0ee86 = DateTime.Now;
				this.c9b4b3ff036c43766ecdc83ecf3f4ad37 = this.c958787bfab27c1e592e8bcf275a4254e();
				return this.c9b4b3ff036c43766ecdc83ecf3f4ad37;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
		public Platform Platform { get; internal set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000C800 File Offset: 0x0000AA00
		public ceee61848167c1ade885c85db30acc060 System { get; internal set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000C814 File Offset: 0x0000AA14
		public string cf25635e89f76877f4315886ba0dfe61a
		{
			get
			{
				return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4980), this.RootDownloadLocation, this.TitleId);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000C844 File Offset: 0x0000AA44
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000C858 File Offset: 0x0000AA58
		public bool Hidden { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000C86C File Offset: 0x0000AA6C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000C880 File Offset: 0x0000AA80
		public string Name { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000C894 File Offset: 0x0000AA94
		public virtual string OutputPath { get; } = c6a5e9b85d86b4e098a511017a1073d71.c2eaf0dbe8bd11ef4cc2db5c557fe1f2f;

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		public string c2ad07a436599cb91427b2e5fc8b7d4e5
		{
			get
			{
				return Path.Combine(Directory.GetParent(this.OutputPath).FullName, this.TitleId.IdRaw);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
		public string Region { get; private set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000C908 File Offset: 0x0000AB08
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000C91C File Offset: 0x0000AB1C
		public DataSize Size { get; private set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000C930 File Offset: 0x0000AB30
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000C944 File Offset: 0x0000AB44
		public byte[] TicketArray { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000C958 File Offset: 0x0000AB58
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000C96C File Offset: 0x0000AB6C
		public c9538952b0224ea717b33e0e4e7ae98c5 Ticket { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000C980 File Offset: 0x0000AB80
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000C994 File Offset: 0x0000AB94
		public bool DiscOnly { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		public TitleId TitleId { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		public cbcbdbfc95367bfec4c11b371d883aa2d Tmd { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public bool CurrentlyDownloaded { get; internal set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000CA20 File Offset: 0x0000AC20
		public bool CurrentlyUploaded { get; internal set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000CA34 File Offset: 0x0000AC34
		public Color c1987926a4691c2e0ac2736e17b520743
		{
			get
			{
				switch (this.ca435006c85356cb7385a782de8889a0a)
				{
				case c59ff87f6bdc69ff3440c18f170633236.c75de07cf35dca1805ba630578576f097:
					return Color.Red;
				case c59ff87f6bdc69ff3440c18f170633236.c5aa713eacee5b6b8a97c2fe89c08b5bc:
					return Color.Orange;
				case c59ff87f6bdc69ff3440c18f170633236.c08d15a5b99c94345141e1274e0123138:
					return Color.Green;
				default:
					return Color.Red;
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000CA80 File Offset: 0x0000AC80
		public string c4f12a532280022aa0ac2a03a0cc1d3a1
		{
			get
			{
				switch (this.ca435006c85356cb7385a782de8889a0a)
				{
				case c59ff87f6bdc69ff3440c18f170633236.c75de07cf35dca1805ba630578576f097:
					return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5157);
				case c59ff87f6bdc69ff3440c18f170633236.c5aa713eacee5b6b8a97c2fe89c08b5bc:
					return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5068), this.cce55c1c54594dc99c5eedaa006793af4);
				case c59ff87f6bdc69ff3440c18f170633236.c08d15a5b99c94345141e1274e0123138:
					return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4995);
				default:
					return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5157);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		public Color c22c41eb1f56c720cea56d55e8a170036
		{
			get
			{
				if (!this.c1083de0b8d92c5fcbdd7005111d34bb9)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.get_c22c41eb1f56c720cea56d55e8a170036()).MethodHandle;
					}
					return Color.Gray;
				}
				return Color.Green;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000CB30 File Offset: 0x0000AD30
		public string c539c0378720ce4c2c66259e201a75f54
		{
			get
			{
				if (!this.c1083de0b8d92c5fcbdd7005111d34bb9)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.get_c539c0378720ce4c2c66259e201a75f54()).MethodHandle;
					}
					return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5186);
				}
				return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5221);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000CB74 File Offset: 0x0000AD74
		public bool c1083de0b8d92c5fcbdd7005111d34bb9
		{
			get
			{
				if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this) != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.get_c1083de0b8d92c5fcbdd7005111d34bb9()).MethodHandle;
					}
					cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b = this.c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3408) != 0);
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
						return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3412) != 0;
					}
					return cf7c96734e58d8de9864e1ea854bc2b7b.c8a01a4300b89e645a23909a3d4f8ec38;
				}
				else if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(this) != null)
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
					cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b2 = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[this.TitleId.FullGame].c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3416) != 0);
					if (cf7c96734e58d8de9864e1ea854bc2b7b2 == null)
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
						return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3420) != 0;
					}
					return cf7c96734e58d8de9864e1ea854bc2b7b2.c1313a3694d9d4cbd109dd5b1b1fe94b1();
				}
				else
				{
					if (c9d462d6bfbf0a4267f7ed91db470887c.c0b398ab350e72b0d64d512bae8520b85(this) == null)
					{
						return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3432) != 0;
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
					cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b3 = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[this.TitleId.FullGame].c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3424) != 0);
					if (cf7c96734e58d8de9864e1ea854bc2b7b3 == null)
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
						return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3428) != 0;
					}
					return cf7c96734e58d8de9864e1ea854bc2b7b3.cab66f65884757b260d3cede7f6adcb72();
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
		public string Version { get; protected set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		protected string c1423b4c96c3a4da08669ce24059dd34a
		{
			get
			{
				return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5248), c6114b34ba4893a53ebb4b599e0e2e3fc.cdcb3a73ed076ade5e36c8c8a410f82aa(this.Name), this.TitleId);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000CD00 File Offset: 0x0000AF00
		public virtual string c2dd75b8c3673fb76f16dea7e88c83243
		{
			get
			{
				return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5267), c6114b34ba4893a53ebb4b599e0e2e3fc.cf51776884010aa67599a1ffba5f14c9c(this.c1423b4c96c3a4da08669ce24059dd34a), this.Region);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000CD38 File Offset: 0x0000AF38
		private string RootDownloadLocation { get; }

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000154 RID: 340 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		// (remove) Token: 0x06000155 RID: 341 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public event EventHandler<c8e60ceced0ce323f661e853233d10ec2> c34927e088ba152d38122e3c8e996a65a
		{
			[CompilerGenerated]
			add
			{
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler = this.c34927e088ba152d38122e3c8e996a65a;
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c8e60ceced0ce323f661e853233d10ec2> value2 = ceb2cf459e5f1c83fa9071b906b061820.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c8e60ceced0ce323f661e853233d10ec2>>(ref this.c34927e088ba152d38122e3c8e996a65a, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.add_c34927e088ba152d38122e3c8e996a65a(EventHandler<c8e60ceced0ce323f661e853233d10ec2>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler = this.c34927e088ba152d38122e3c8e996a65a;
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c8e60ceced0ce323f661e853233d10ec2> value2 = ceb2cf459e5f1c83fa9071b906b061820.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c8e60ceced0ce323f661e853233d10ec2>>(ref this.c34927e088ba152d38122e3c8e996a65a, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.remove_c34927e088ba152d38122e3c8e996a65a(EventHandler<c8e60ceced0ce323f661e853233d10ec2>)).MethodHandle;
				}
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000156 RID: 342 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		// (remove) Token: 0x06000157 RID: 343 RVA: 0x0000CE3C File Offset: 0x0000B03C
		public event EventHandler<ce91c3ee3b6503970820b59a90b300d72> c73e931bf51a4d212e8590fc4d679e319
		{
			[CompilerGenerated]
			add
			{
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler = this.c73e931bf51a4d212e8590fc4d679e319;
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ce91c3ee3b6503970820b59a90b300d72> value2 = cac2c857819b151ab47474f5ab0c4c8a9.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ce91c3ee3b6503970820b59a90b300d72>>(ref this.c73e931bf51a4d212e8590fc4d679e319, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.add_c73e931bf51a4d212e8590fc4d679e319(EventHandler<ce91c3ee3b6503970820b59a90b300d72>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler = this.c73e931bf51a4d212e8590fc4d679e319;
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ce91c3ee3b6503970820b59a90b300d72> value2 = cac2c857819b151ab47474f5ab0c4c8a9.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ce91c3ee3b6503970820b59a90b300d72>>(ref this.c73e931bf51a4d212e8590fc4d679e319, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.remove_c73e931bf51a4d212e8590fc4d679e319(EventHandler<ce91c3ee3b6503970820b59a90b300d72>)).MethodHandle;
				}
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000CE8C File Offset: 0x0000B08C
		private long ce72dde540f1a33d33b690563b4b6907a()
		{
			if (!Directory.Exists(this.OutputPath))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.ce72dde540f1a33d33b690563b4b6907a()).MethodHandle;
				}
				return (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3436);
			}
			IEnumerable<string> files = Directory.GetFiles(this.OutputPath);
			Func<string, long> selector;
			if ((selector = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c86759aa98369b4e70e1d68f72a49c45f) == null)
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
				selector = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c86759aa98369b4e70e1d68f72a49c45f = new Func<string, long>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.c157e63cf329c31d61fda91a70f06d456));
			}
			return files.Sum(selector);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000CF08 File Offset: 0x0000B108
		public void c232388e2d78eeebd51589f4bd158ad0f(string c54a7d6cb5c0c0420ac46560b5c93cf03, bool c59ed465e3c07dd59a33c1597b6c3a016 = false)
		{
			c6114b34ba4893a53ebb4b599e0e2e3fc.cf3b3704f3dacfd1286a5e94e4c301737 cf3b3704f3dacfd1286a5e94e4c = new c6114b34ba4893a53ebb4b599e0e2e3fc.cf3b3704f3dacfd1286a5e94e4c301737();
			cf3b3704f3dacfd1286a5e94e4c.c54a7d6cb5c0c0420ac46560b5c93cf03 = c54a7d6cb5c0c0420ac46560b5c93cf03;
			cf3b3704f3dacfd1286a5e94e4c.c59ed465e3c07dd59a33c1597b6c3a016 = c59ed465e3c07dd59a33c1597b6c3a016;
			if (this.System != ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c232388e2d78eeebd51589f4bd158ad0f(string, bool)).MethodHandle;
				}
				return;
			}
			if (!Directory.Exists(cf3b3704f3dacfd1286a5e94e4c.c54a7d6cb5c0c0420ac46560b5c93cf03))
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
				Directory.CreateDirectory(cf3b3704f3dacfd1286a5e94e4c.c54a7d6cb5c0c0420ac46560b5c93cf03);
			}
			cf3b3704f3dacfd1286a5e94e4c.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4210), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3440) != 0);
			cd4880843d42f3dd634ca35c8e909b573.cc9ff642c53c06a69106c76874bd71e34(cf3b3704f3dacfd1286a5e94e4c.c54a7d6cb5c0c0420ac46560b5c93cf03);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5286),
				WorkingDirectory = cf3b3704f3dacfd1286a5e94e4c.c54a7d6cb5c0c0420ac46560b5c93cf03,
				CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3444) != 0),
				WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3448)
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3452) != 0);
			process.Exited += cf3b3704f3dacfd1286a5e94e4c.c070dfac8e6997927ef05537edbfdc7e0;
			this.c2845e22243014eee92c54eee0c15c904(cf3b3704f3dacfd1286a5e94e4c.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5297));
			process.Start();
			cf3b3704f3dacfd1286a5e94e4c.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000D03C File Offset: 0x0000B23C
		public void c0d8d1156c87ee2b6e1e13902fdfb7c22(string c85fa46dee7ef9473f93c9fb47da11f4d, bool c6507e2985c9bc79551226cd524f60fbc, bool cc6df64457da5b0b4e60242e9be86a526, bool c95cde87a8c7284b9136d7fc11a4c3eb5)
		{
			c6114b34ba4893a53ebb4b599e0e2e3fc.c72616e5fb409104ebc86b36449b44160 c72616e5fb409104ebc86b36449b = new c6114b34ba4893a53ebb4b599e0e2e3fc.c72616e5fb409104ebc86b36449b44160();
			c72616e5fb409104ebc86b36449b.c85fa46dee7ef9473f93c9fb47da11f4d = c85fa46dee7ef9473f93c9fb47da11f4d;
			c72616e5fb409104ebc86b36449b.c95cde87a8c7284b9136d7fc11a4c3eb5 = c95cde87a8c7284b9136d7fc11a4c3eb5;
			c72616e5fb409104ebc86b36449b.cc6df64457da5b0b4e60242e9be86a526 = cc6df64457da5b0b4e60242e9be86a526;
			c72616e5fb409104ebc86b36449b.c6507e2985c9bc79551226cd524f60fbc = c6507e2985c9bc79551226cd524f60fbc;
			if (this.System != ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c0d8d1156c87ee2b6e1e13902fdfb7c22(string, bool, bool, bool)).MethodHandle;
				}
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5306));
			}
			Directory.CreateDirectory(c72616e5fb409104ebc86b36449b.c85fa46dee7ef9473f93c9fb47da11f4d);
			c72616e5fb409104ebc86b36449b.cfe60371517f0baf9152d2203b196e54f = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5393), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3456) != 0);
			c72616e5fb409104ebc86b36449b.ce8ec543fa6943b1b52f7e5ff7f4131f0 = Path.Combine(Path.GetTempPath(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5470));
			this.c2845e22243014eee92c54eee0c15c904(c72616e5fb409104ebc86b36449b.c85fa46dee7ef9473f93c9fb47da11f4d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5297));
			cd4880843d42f3dd634ca35c8e909b573.cc9ff642c53c06a69106c76874bd71e34(c72616e5fb409104ebc86b36449b.c85fa46dee7ef9473f93c9fb47da11f4d);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = Path.Combine(c72616e5fb409104ebc86b36449b.c85fa46dee7ef9473f93c9fb47da11f4d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5286)),
				WorkingDirectory = c72616e5fb409104ebc86b36449b.c85fa46dee7ef9473f93c9fb47da11f4d
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3460) != 0);
			process.Exited += c72616e5fb409104ebc86b36449b.c26983afe56b7574346516a0e15315a99;
			process.Start();
			c72616e5fb409104ebc86b36449b.cfe60371517f0baf9152d2203b196e54f.ShowDialog();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000D184 File Offset: 0x0000B384
		public void c2845e22243014eee92c54eee0c15c904(string c8b8fabe20694b61835dba656f466c97c, string c970b31fe4f307e557ac948e45eecc894)
		{
			c6114b34ba4893a53ebb4b599e0e2e3fc.c6369a16e814d3f71e5cf7639cf86ddc1 c6369a16e814d3f71e5cf7639cf86ddc = new c6114b34ba4893a53ebb4b599e0e2e3fc.c6369a16e814d3f71e5cf7639cf86ddc1();
			c6369a16e814d3f71e5cf7639cf86ddc.c4404a159870bf55bb6f111e66e59e82d = this;
			c6369a16e814d3f71e5cf7639cf86ddc.c8b8fabe20694b61835dba656f466c97c = c8b8fabe20694b61835dba656f466c97c;
			c6369a16e814d3f71e5cf7639cf86ddc.c970b31fe4f307e557ac948e45eecc894 = c970b31fe4f307e557ac948e45eecc894;
			if (Directory.Exists(this.c2ad07a436599cb91427b2e5fc8b7d4e5))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c2845e22243014eee92c54eee0c15c904(string, string)).MethodHandle;
				}
				FileSystem.DeleteDirectory(this.c2ad07a436599cb91427b2e5fc8b7d4e5, (DeleteDirectoryOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3464));
			}
			FileSystem.RenameDirectory(this.OutputPath, this.TitleId.IdRaw);
			string text = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5487));
			File.WriteAllBytes(text, c6faa5467be1a4874657b372a49b7c927.makecia);
			string arguments = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5510), this.c2ad07a436599cb91427b2e5fc8b7d4e5, c6369a16e814d3f71e5cf7639cf86ddc.c8b8fabe20694b61835dba656f466c97c, this.TitleId.IdRaw);
			Process process = new Process();
			process.StartInfo.FileName = text;
			process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3468) != 0);
			process.StartInfo.CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3472) != 0);
			process.StartInfo.WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3476);
			process.StartInfo.UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3480) != 0);
			process.StartInfo.Arguments = arguments;
			process.StartInfo.RedirectStandardOutput = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3484) != 0);
			process.StartInfo.WorkingDirectory = c6369a16e814d3f71e5cf7639cf86ddc.c8b8fabe20694b61835dba656f466c97c;
			c6369a16e814d3f71e5cf7639cf86ddc.c561c2db76c5bf8c95a684eca3517d61c = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5549), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3488) != 0);
			process.OutputDataReceived += c6369a16e814d3f71e5cf7639cf86ddc.ca8cb41b99cdd5e3ce85ecf7ed0fc62f0;
			process.Start();
			process.BeginOutputReadLine();
			process.Exited += c6369a16e814d3f71e5cf7639cf86ddc.c70220581fee8ba54da1b05205805707c;
			c6369a16e814d3f71e5cf7639cf86ddc.c561c2db76c5bf8c95a684eca3517d61c.ShowDialog();
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000D35C File Offset: 0x0000B55C
		public void c7ff9b69ed99c1e935069737f80db9054()
		{
			this.c86afb23ad91bc7b787933e88a6e0ee86 = DateTime.MinValue;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000D374 File Offset: 0x0000B574
		public static void c547b9b2c939170ad144a18e7dbded18d()
		{
			c6114b34ba4893a53ebb4b599e0e2e3fc.c3951e863fae538ba58761ebada43ea0e = new List<string>();
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5640)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c547b9b2c939170ad144a18e7dbded18d()).MethodHandle;
				}
				c6114b34ba4893a53ebb4b599e0e2e3fc.c3951e863fae538ba58761ebada43ea0e.AddRange(c67726bc94fb4dd43c5c00e863a4fed19.c8334ccea7202097a0899b9cb1fac251e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5640)));
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		public static void c30fb6614ee092b8ded8b858aba8f900b()
		{
			c67726bc94fb4dd43c5c00e863a4fed19.c6be8a9a2e62443fd1e448c28bd8dad3e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5640), c6114b34ba4893a53ebb4b599e0e2e3fc.c3951e863fae538ba58761ebada43ea0e.ToArray());
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		public void ccb6712cd0fa61825a747636fb485fe52()
		{
			c4a0c1729f34b9cf7da2405086f4c0853 c4a0c1729f34b9cf7da2405086f4c = this.c0c42780bfe6c1baab84cf3c2584fc47e;
			if (c4a0c1729f34b9cf7da2405086f4c == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.ccb6712cd0fa61825a747636fb485fe52()).MethodHandle;
				}
				return;
			}
			c4a0c1729f34b9cf7da2405086f4c.c6889450a48d299ebf2287450e166d567();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D42C File Offset: 0x0000B62C
		public void c9717eaf5eb988da4fe5da4cda0a9ff85()
		{
			this.c73e931bf51a4d212e8590fc4d679e319 = cac579ba5cf0ea954e6c065f0b18896a1.cab55a050df275722227783d6686266c9;
			this.c34927e088ba152d38122e3c8e996a65a = cb9d1d8b8ac2f5a3d7f75c3364c2dca5d.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000D450 File Offset: 0x0000B650
		public string c8c3deb15f04d4b9ff701a9696f2e64fa(bool cbce25b445a5e71ee42efcf2afddd6998, DriveInfo cb33decdc9e5663a9827f5479abd1bd77)
		{
			string text = Path.Combine(Path.GetTempPath(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4305));
			Directory.CreateDirectory(text);
			if (cbce25b445a5e71ee42efcf2afddd6998)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c8c3deb15f04d4b9ff701a9696f2e64fa(bool, DriveInfo)).MethodHandle;
				}
				if (!this.cc2ef74f5750f463aaf8c5509a893d76d())
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
					return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5659);
				}
			}
			string name = cb33decdc9e5663a9827f5479abd1bd77.Name;
			string path = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5696);
			string c2dd75b8c3673fb76f16dea7e88c = this.c2dd75b8c3673fb76f16dea7e88c83243;
			string c0d6c37d812d5d4b610705a6421056252;
			if (!this.CfwOnly)
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
				c0d6c37d812d5d4b610705a6421056252 = "";
			}
			else
			{
				c0d6c37d812d5d4b610705a6421056252 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5713);
			}
			string text2 = Path.Combine(name, path, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c2dd75b8c3673fb76f16dea7e88c, c0d6c37d812d5d4b610705a6421056252));
			if (Directory.Exists(text2))
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
				Directory.Delete(text2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3492) != 0);
			}
			Directory.CreateDirectory(text2);
			if (this.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3496))
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
				try
				{
					FileSystem.CopyDirectory(this.OutputPath, text2, (UIOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3500));
				}
				catch (Exception ex)
				{
					return ex.Message;
				}
				return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5736);
			}
			this.c2845e22243014eee92c54eee0c15c904(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5297));
			FileSystem.MoveFile(Path.Combine(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5470)), Path.Combine(text2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5741)), (UIOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3504));
			return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5736);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		public bool c3e9844232914e2f1ccf3d192ecfca2bd()
		{
			this.c7ff9b69ed99c1e935069737f80db9054();
			bool result;
			try
			{
				Directory.Delete(this.OutputPath, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3508) != 0);
				result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3512) != 0);
			}
			catch (Exception)
			{
				result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3516) != 0);
			}
			return result;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000D644 File Offset: 0x0000B844
		public string caf5c2281268b0d9649319527ceb47238()
		{
			if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this) != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.caf5c2281268b0d9649319527ceb47238()).MethodHandle;
				}
				return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5248), c6114b34ba4893a53ebb4b599e0e2e3fc.cdcb3a73ed076ade5e36c8c8a410f82aa(this.Name), c933d8f390d7a245458355cef338c6754.cd24593c859565ebb8c9faabbc5c75bef(this).ProductId);
			}
			return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5760), c6114b34ba4893a53ebb4b599e0e2e3fc.cdcb3a73ed076ade5e36c8c8a410f82aa(this.ToString()));
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		public void c37b3d3a9ef4a26c65a3fac4aa3cda6c2(cf7c96734e58d8de9864e1ea854bc2b7b c6cfe4a6a4a47430d95db2df361685474)
		{
			c6cfe4a6a4a47430d95db2df361685474.c37b3d3a9ef4a26c65a3fac4aa3cda6c2();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public cf7c96734e58d8de9864e1ea854bc2b7b c04a799c99dd357cf35ae2407537c3d1c(bool c07532d90fa519783a3736afc4d48beb9)
		{
			if (this.DiscOnly)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c04a799c99dd357cf35ae2407537c3d1c(bool)).MethodHandle;
				}
				return null;
			}
			Platform platform = this.Platform;
			if (platform <= (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3520))
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
				if (platform <= (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3524))
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
					if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3528))
					{
						return new c835740eb09051bccacfad4c551fdd155(this, c07532d90fa519783a3736afc4d48beb9);
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
					switch (platform - (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3532))
					{
					case 0:
						return new c8b671fda31f88dc7c7875175126002f3(this, c07532d90fa519783a3736afc4d48beb9);
					case 2:
						return new cf4e7e017a810e8941867929a8a86f8da(this, c07532d90fa519783a3736afc4d48beb9);
					case 3:
						return new cf4e7e017a810e8941867929a8a86f8da(this, c07532d90fa519783a3736afc4d48beb9);
					case 4:
						return new c8b671fda31f88dc7c7875175126002f3(this, c07532d90fa519783a3736afc4d48beb9);
					}
				}
				else
				{
					if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3536))
					{
						return new c835740eb09051bccacfad4c551fdd155(this, c07532d90fa519783a3736afc4d48beb9);
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
					if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3540))
					{
						return new c8b671fda31f88dc7c7875175126002f3(this, c07532d90fa519783a3736afc4d48beb9);
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
					if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3544))
					{
						return new c8b671fda31f88dc7c7875175126002f3(this, c07532d90fa519783a3736afc4d48beb9);
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
			else if (platform <= (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3548))
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
				if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3552))
				{
					return new c835740eb09051bccacfad4c551fdd155(this, c07532d90fa519783a3736afc4d48beb9);
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
				if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3556))
				{
					return new c835740eb09051bccacfad4c551fdd155(this, c07532d90fa519783a3736afc4d48beb9);
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
			else
			{
				switch (platform - (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3560))
				{
				case 0:
					return new c5c8eb2cc6d316755e45318c67fbb80cd(this, c07532d90fa519783a3736afc4d48beb9);
				case 1:
					return new cd8c2bbf9848dd570e5642dee5b6d99ed(this, c07532d90fa519783a3736afc4d48beb9);
				case 2:
					return new c835740eb09051bccacfad4c551fdd155(this, c07532d90fa519783a3736afc4d48beb9);
				case 3:
				case 4:
				case 5:
					break;
				case 6:
					return new c26170878cf8ba946eba17983d6f2cf41(this, c07532d90fa519783a3736afc4d48beb9);
				case 7:
					return new ca4b14247d04b632a4f7ba75504a8c5a9(this, c07532d90fa519783a3736afc4d48beb9);
				case 8:
					return new c92405b00606e9a36e1850edbf7e174fe(this, c07532d90fa519783a3736afc4d48beb9);
				default:
					if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3564))
					{
						return new c8b671fda31f88dc7c7875175126002f3(this, c07532d90fa519783a3736afc4d48beb9);
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
					if (platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3568))
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
						return new c8b671fda31f88dc7c7875175126002f3(this, c07532d90fa519783a3736afc4d48beb9);
					}
					break;
				}
			}
			return null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000D91C File Offset: 0x0000BB1C
		public ce462f8df7ccb876a2d3bd500ac1c174f c88e4a51a8d0b3e7d29a28576dde32c38()
		{
			if (this.System != (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3572))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c88e4a51a8d0b3e7d29a28576dde32c38()).MethodHandle;
				}
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5789));
			}
			cbcbdbfc95367bfec4c11b371d883aa2d cbcbdbfc95367bfec4c11b371d883aa2d = c5722de6752cb94166a4c3e58241e2212.cab55a050df275722227783d6686266c9;
			if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(this) != null)
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
				cbcbdbfc95367bfec4c11b371d883aa2d = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1314), this.cf25635e89f76877f4315886ba0dfe61a, this.Version)), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3576));
			}
			else
			{
				cbcbdbfc95367bfec4c11b371d883aa2d = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1335), this.cf25635e89f76877f4315886ba0dfe61a)), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3580));
			}
			c9538952b0224ea717b33e0e4e7ae98c5 c9538952b0224ea717b33e0e4e7ae98c = c739e18b10ae91f31263efa30389db279.cab55a050df275722227783d6686266c9;
			if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(this) == null)
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
				if (this.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3584))
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
				}
				else
				{
					if (this.cf7f2b1967398c4cc0c607544f80499bc)
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
						c9538952b0224ea717b33e0e4e7ae98c = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(File.ReadAllBytes(Path.Combine(Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5880)), c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.TitleId.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5895)))), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3592));
						goto IL_1CD;
					}
					c9538952b0224ea717b33e0e4e7ae98c = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(this.TicketArray, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3596));
					goto IL_1CD;
				}
			}
			c9538952b0224ea717b33e0e4e7ae98c = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cf25635e89f76877f4315886ba0dfe61a, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1305))), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3588));
			IL_1CD:
			byte[] array = new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cf25635e89f76877f4315886ba0dfe61a, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3600)].ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293))));
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			ce462f8df7ccb876a2d3bd500ac1c174f result;
			try
			{
				aesCryptoServiceProvider.Key = c9538952b0224ea717b33e0e4e7ae98c.cc0eab3c8af7b4aa29c084139a1df3c14;
				aesCryptoServiceProvider.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3604);
				aesCryptoServiceProvider.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3608);
				aesCryptoServiceProvider.IV = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3612));
				c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
				result = new ce462f8df7ccb876a2d3bd500ac1c174f(aesCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3616), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array)));
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
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
					((IDisposable)aesCryptoServiceProvider).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		public bool cf08369cbb3a626a84f05ff893b78fed7(string c9d540c3971096f8ee896226bd938ca99, bool c39287c15a6e8c6c70cc44cbd62c7f22d, bool c3c7497942acfe55b365013a6254dd980 = false, IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> c4af034c05fd55c7c0ca5b56577ddd3b0 = null, bool c5daff30a59a4f0ecddf2276180e3bbad = false)
		{
			c6114b34ba4893a53ebb4b599e0e2e3fc.cd94ec51495d1952fa80e7b8d227f2850 cd94ec51495d1952fa80e7b8d227f = new c6114b34ba4893a53ebb4b599e0e2e3fc.cd94ec51495d1952fa80e7b8d227f2850();
			cd94ec51495d1952fa80e7b8d227f.ccb00690a4dbd11fab9ea8415c60a3154 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3620) != 0);
			c6a5e9b85d86b4e098a511017a1073d71.ccb05366fd81f08047514caf61a20fda3 = this;
			if (c39287c15a6e8c6c70cc44cbd62c7f22d)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.cf08369cbb3a626a84f05ff893b78fed7(string, bool, bool, IEnumerable<c362f27bc84ea5b6692418fbdaf79e992>, bool)).MethodHandle;
				}
				c9d540c3971096f8ee896226bd938ca99 = Path.Combine(c9d540c3971096f8ee896226bd938ca99, this.caf5c2281268b0d9649319527ceb47238());
			}
			if (this.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3624))
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
				c6114b34ba4893a53ebb4b599e0e2e3fc.ceaf9648bc8d12c66c89febb937601441 ceaf9648bc8d12c66c89febb = new c6114b34ba4893a53ebb4b599e0e2e3fc.ceaf9648bc8d12c66c89febb937601441();
				ceaf9648bc8d12c66c89febb.c8c38354cddaefb45b9cfcd9ed2838c37 = cd94ec51495d1952fa80e7b8d227f;
				try
				{
					DriveInfo driveInfo = new DriveInfo(Path.GetPathRoot(c9d540c3971096f8ee896226bd938ca99));
					if (driveInfo.AvailableFreeSpace < (long)this.Size.TotalBytes)
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
						RadMessageBox.Show(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5904), driveInfo.Name, new DataSize(this.Size.TotalBytes - (ulong)driveInfo.AvailableFreeSpace)));
						return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3628) != 0;
					}
				}
				catch
				{
				}
				Directory.CreateDirectory(c9d540c3971096f8ee896226bd938ca99);
				if (this.c9e33774c6343e7c7fe83022678b014ae)
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
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6013));
					return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3632) != 0;
				}
				ceaf9648bc8d12c66c89febb.cf80aed8e439da0ff41b571df22072ddc = new c8d41fc16c10f4ac30e6f0def27b49dc2(this);
				c017566fd8fc3339eccefb42cd6629468 c017566fd8fc3339eccefb42cd = new c017566fd8fc3339eccefb42cd6629468(this);
				c017566fd8fc3339eccefb42cd.c2484bd018cc259ebf6256e671a3c8276 += ceaf9648bc8d12c66c89febb.c8a0baf45726075952376a6489b0849bd;
				ceaf9648bc8d12c66c89febb.c076678ab058c983518e4c635945a760a = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3636) != 0);
				c017566fd8fc3339eccefb42cd.c18f6de0e227e0d96c5e4f9bda37723c6 += ceaf9648bc8d12c66c89febb.cb5c5dc63dec7ae750c20fe977d91825b;
				c017566fd8fc3339eccefb42cd.c1f84333d7942c2315ee42eb2b5f59625 += ceaf9648bc8d12c66c89febb.ccba7eb6ccd9b362f9f8438af8ee19946;
				if (c4af034c05fd55c7c0ca5b56577ddd3b0 != null)
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
					c017566fd8fc3339eccefb42cd.cf8303f52fb0afdb6f4459d0d7676c874(c9d540c3971096f8ee896226bd938ca99, c3c7497942acfe55b365013a6254dd980, c4af034c05fd55c7c0ca5b56577ddd3b0.ToList<c362f27bc84ea5b6692418fbdaf79e992>(), c5daff30a59a4f0ecddf2276180e3bbad);
				}
				else
				{
					c017566fd8fc3339eccefb42cd.cf8303f52fb0afdb6f4459d0d7676c874(c9d540c3971096f8ee896226bd938ca99, c3c7497942acfe55b365013a6254dd980, null, c5daff30a59a4f0ecddf2276180e3bbad);
				}
				if (!ceaf9648bc8d12c66c89febb.c076678ab058c983518e4c635945a760a)
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
					ceaf9648bc8d12c66c89febb.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
				}
				try
				{
					if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this) != cb6125d5348736aea8498a2c9c6354bc4.cab55a050df275722227783d6686266c9 && c39287c15a6e8c6c70cc44cbd62c7f22d)
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
						if (!c9d540c3971096f8ee896226bd938ca99.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6086)))
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
							string path = Path.Combine(c9d540c3971096f8ee896226bd938ca99, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6105), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6114));
							if (File.Exists(path))
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
								XmlDocument xmlDocument = new XmlDocument();
								xmlDocument.LoadXml(File.ReadAllText(path));
								string innerText = xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6131))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3640)].InnerText;
								string name = new DirectoryInfo(c9d540c3971096f8ee896226bd938ca99).Name;
								string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3644));
								array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3648)] = name.Substring(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3652), name.IndexOf(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6156)));
								array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3656)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6156);
								array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3660)] = c933d8f390d7a245458355cef338c6754.cd24593c859565ebb8c9faabbc5c75bef(this).ProductId;
								array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3664)] = innerText.Substring(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3668));
								array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3672)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6159);
								string newName = ccde0986d32f242f41bfd66f082dce0ff.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(array);
								FileSystem.RenameDirectory(c9d540c3971096f8ee896226bd938ca99, newName);
							}
						}
					}
					goto IL_3A7;
				}
				catch
				{
					goto IL_3A7;
				}
			}
			if (this.System == ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
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
				c6a5e9b85d86b4e098a511017a1073d71.ccb05366fd81f08047514caf61a20fda3 = c0e041e021e04e712883cd11308c15013.cab55a050df275722227783d6686266c9;
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3676) != 0;
			}
			IL_3A7:
			c6a5e9b85d86b4e098a511017a1073d71.ccb05366fd81f08047514caf61a20fda3 = c0e041e021e04e712883cd11308c15013.cab55a050df275722227783d6686266c9;
			return cd94ec51495d1952fa80e7b8d227f.ccb00690a4dbd11fab9ea8415c60a3154;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		private void c363c53af07db4bf75c8d083a8983d695(string cad48e7cec482eb202b35baba9979de2f, string c2e59f973437ea79c9b95a2c0ce2d33db)
		{
			if (Directory.Exists(cad48e7cec482eb202b35baba9979de2f))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c363c53af07db4bf75c8d083a8983d695(string, string)).MethodHandle;
				}
				FileSystem.MoveDirectory(cad48e7cec482eb202b35baba9979de2f, c2e59f973437ea79c9b95a2c0ce2d33db, (UIOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3680));
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000E030 File Offset: 0x0000C230
		public void cc8422328d62b00ae26fa035b02f819ff(bool cbce25b445a5e71ee42efcf2afddd6998, IPAddress cd353e77cfdd9eca27f92063fe478cfdc, bool c9b75f6ba06c0e9f0da24aef64cde37be)
		{
			c6114b34ba4893a53ebb4b599e0e2e3fc.c2d6117ce0419e7d96a2573a1e16d9f8e c2d6117ce0419e7d96a2573a1e16d9f8e = new c6114b34ba4893a53ebb4b599e0e2e3fc.c2d6117ce0419e7d96a2573a1e16d9f8e();
			c2d6117ce0419e7d96a2573a1e16d9f8e.c4404a159870bf55bb6f111e66e59e82d = this;
			c2d6117ce0419e7d96a2573a1e16d9f8e.c9b75f6ba06c0e9f0da24aef64cde37be = c9b75f6ba06c0e9f0da24aef64cde37be;
			if (this.System != (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3684))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.cc8422328d62b00ae26fa035b02f819ff(bool, IPAddress, bool)).MethodHandle;
				}
				return;
			}
			this.CurrentlyUploaded = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3688) != 0);
			if (cbce25b445a5e71ee42efcf2afddd6998)
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
				if (!this.cc2ef74f5750f463aaf8c5509a893d76d())
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
					EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler = this.c34927e088ba152d38122e3c8e996a65a;
					if (eventHandler == null)
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
					}
					else
					{
						eventHandler(this, new c8e60ceced0ce323f661e853233d10ec2(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5659), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3692) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3696)));
					}
				}
			}
			c6114b34ba4893a53ebb4b599e0e2e3fc.c2d6117ce0419e7d96a2573a1e16d9f8e c2d6117ce0419e7d96a2573a1e16d9f8e2 = c2d6117ce0419e7d96a2573a1e16d9f8e;
			string c2dd75b8c3673fb76f16dea7e88c = this.c2dd75b8c3673fb76f16dea7e88c83243;
			string c0d6c37d812d5d4b610705a6421056252;
			if (!this.CfwOnly)
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
				c0d6c37d812d5d4b610705a6421056252 = "";
			}
			else
			{
				c0d6c37d812d5d4b610705a6421056252 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5713);
			}
			c2d6117ce0419e7d96a2573a1e16d9f8e2.c8e678ca35a7e295b3347019d7486cf98 = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c2dd75b8c3673fb76f16dea7e88c, c0d6c37d812d5d4b610705a6421056252);
			c6114b34ba4893a53ebb4b599e0e2e3fc.c2d6117ce0419e7d96a2573a1e16d9f8e c2d6117ce0419e7d96a2573a1e16d9f8e3 = c2d6117ce0419e7d96a2573a1e16d9f8e;
			IEnumerable<FileInfo> files = new DirectoryInfo(this.OutputPath).GetFiles();
			Func<FileInfo, long> selector;
			if ((selector = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cf8c842ae84cf7e8c46449f199b15f052) == null)
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
				selector = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cf8c842ae84cf7e8c46449f199b15f052 = new Func<FileInfo, long>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.c5cc4bac56d94dc74142c5a4db86215c2));
			}
			c2d6117ce0419e7d96a2573a1e16d9f8e3.c03ec28224fb1f0e4d63350b629e7520b = files.Sum(selector);
			string text = Path.Combine(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6162), c2d6117ce0419e7d96a2573a1e16d9f8e.c8e678ca35a7e295b3347019d7486cf98);
			this.c0c42780bfe6c1baab84cf3c2584fc47e = new c4a0c1729f34b9cf7da2405086f4c0853(cd353e77cfdd9eca27f92063fe478cfdc.ToString(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1063), "");
			if (!this.c0c42780bfe6c1baab84cf3c2584fc47e.c4275fb0a38c52fbd88cf4f2b6c5659da())
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
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler2 = this.c34927e088ba152d38122e3c8e996a65a;
				if (eventHandler2 == null)
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
				}
				else
				{
					eventHandler2(this, new c8e60ceced0ce323f661e853233d10ec2(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6187), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3700) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3704)));
				}
			}
			this.c0c42780bfe6c1baab84cf3c2584fc47e.cbb7a4a6d58a8a360abcf15e1aae3eb6e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6162));
			this.c0c42780bfe6c1baab84cf3c2584fc47e.cbb7a4a6d58a8a360abcf15e1aae3eb6e(text);
			this.c0c42780bfe6c1baab84cf3c2584fc47e.c3dc25cbd6cf2e00bfcf0b299e3cd1eaa += c2d6117ce0419e7d96a2573a1e16d9f8e.c55729d8caddbf512c2b61b306b4deae8;
			c2d6117ce0419e7d96a2573a1e16d9f8e.ce807717d71793a02526c0b1b0b23746f = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3708);
			c2d6117ce0419e7d96a2573a1e16d9f8e.ce74862f85140216f3a300712e5eab158 = DateTime.Now;
			c2d6117ce0419e7d96a2573a1e16d9f8e.c2bc6dde17e54f4478afdae9d8eecd10c = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3712));
			this.c0c42780bfe6c1baab84cf3c2584fc47e.cdc6a6882963655f3dac51fd371d2e6bb += c2d6117ce0419e7d96a2573a1e16d9f8e.c5f6c19cef2054323c0629e9694fcd9bf;
			try
			{
				this.c0c42780bfe6c1baab84cf3c2584fc47e.ccc0709f01e7727f761fd4044909cf094(text, this.OutputPath);
			}
			catch (Exception ex)
			{
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler3 = this.c34927e088ba152d38122e3c8e996a65a;
				if (eventHandler3 == null)
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
				}
				else
				{
					eventHandler3(this, new c8e60ceced0ce323f661e853233d10ec2(ex.Message, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3716) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3720)));
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		public static string cdcb3a73ed076ade5e36c8c8a410f82aa(string cc9f36ab8599957a993eea667b1cca61f)
		{
			cc9f36ab8599957a993eea667b1cca61f = cc9f36ab8599957a993eea667b1cca61f.Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6246), "");
			IEnumerable<char> invalidFileNameChars = Path.GetInvalidFileNameChars();
			string seed = cc9f36ab8599957a993eea667b1cca61f;
			Func<string, char, string> func;
			if ((func = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c496e905846f6e68ad9f533ec7b528b54) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.cdcb3a73ed076ade5e36c8c8a410f82aa(string)).MethodHandle;
				}
				func = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c496e905846f6e68ad9f533ec7b528b54 = new Func<string, char, string>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.c7daa4b4c81cea7368dab884bcee22a28));
			}
			return invalidFileNameChars.Aggregate(seed, func);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000E35C File Offset: 0x0000C55C
		private static string cf51776884010aa67599a1ffba5f14c9c(string cc9f36ab8599957a993eea667b1cca61f)
		{
			char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3724));
			RuntimeHelpers.InitializeArray(array, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c4a86379cf092da858b943dfdfb0a1a39).FieldHandle);
			string c7c2b264dabe6af7c14e50f838643b4e = cc9f36ab8599957a993eea667b1cca61f.c101c3ac509a256ea4f07e70c3d1ca1a4(array, (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3728));
			char[] array2 = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3732));
			RuntimeHelpers.InitializeArray(array2, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c9084901dd8c7f06a64773e17ac73c06d).FieldHandle);
			string c7c2b264dabe6af7c14e50f838643b4e2 = c7c2b264dabe6af7c14e50f838643b4e.c101c3ac509a256ea4f07e70c3d1ca1a4(array2, (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3736));
			char[] array3 = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3740));
			array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3744)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3748);
			array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3752)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3756);
			string c7c2b264dabe6af7c14e50f838643b4e3 = c7c2b264dabe6af7c14e50f838643b4e2.c101c3ac509a256ea4f07e70c3d1ca1a4(array3, (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3760));
			char[] array4 = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3764));
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3768)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3772);
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3776)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3780);
			string c7c2b264dabe6af7c14e50f838643b4e4 = c7c2b264dabe6af7c14e50f838643b4e3.c101c3ac509a256ea4f07e70c3d1ca1a4(array4, (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3784));
			char[] array5 = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3788));
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3792)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3796);
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3800)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3804);
			return c7c2b264dabe6af7c14e50f838643b4e4.c101c3ac509a256ea4f07e70c3d1ca1a4(array5, (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3808)).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6249), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6252));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		private c59ff87f6bdc69ff3440c18f170633236 c958787bfab27c1e592e8bcf275a4254e()
		{
			if (!Directory.Exists(this.OutputPath))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c958787bfab27c1e592e8bcf275a4254e()).MethodHandle;
				}
				return (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3812);
			}
			if (File.Exists(Path.Combine(this.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767))))
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
				if (File.Exists(Path.Combine(this.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6259))))
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
					if (this.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3816))
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
						if (!File.Exists(Path.Combine(this.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6278))))
						{
							for (;;)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								goto IL_DA;
							}
						}
					}
					if (c9d462d6bfbf0a4267f7ed91db470887c.c0b398ab350e72b0d64d512bae8520b85(this) == null)
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
						if (this.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3824))
						{
							goto IL_1B8;
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
					byte[] buffer = new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cf25635e89f76877f4315886ba0dfe61a, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1286)));
					MD5 md = MD5.Create();
					try
					{
						IEnumerable<byte> first = md.ComputeHash(buffer);
						byte[] second = md.ComputeHash(File.ReadAllBytes(Path.Combine(this.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767))));
						if (!first.SequenceEqual(second))
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
							return (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3828);
						}
					}
					finally
					{
						if (md != null)
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
							((IDisposable)md).Dispose();
						}
					}
					IL_1B8:
					cd161c587b229cb9747bf073c6e98b0b9[] ca41cd3b028585a369298639868832973 = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(Path.Combine(this.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767)), this.System).ca41cd3b028585a369298639868832973;
					for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3832); i < (int)c6039f0790413b5e04707059b16777215.cfeb04651f165d0166e7c10ab1acf8b28(ca41cd3b028585a369298639868832973); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3852))
					{
						cd161c587b229cb9747bf073c6e98b0b9 cd161c587b229cb9747bf073c6e98b0b = ca41cd3b028585a369298639868832973[i];
						string text = Path.Combine(this.OutputPath, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cd161c587b229cb9747bf073c6e98b0b.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)));
						if (!File.Exists(text))
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
							return (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3836);
						}
						if (new FileInfo(text).Length != (long)cd161c587b229cb9747bf073c6e98b0b.Size.TotalBytes.c1b35eb4afe78a76f3cc20ee16741e8dc((uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3840)))
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
							return (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3844);
						}
						if (cd161c587b229cb9747bf073c6e98b0b.c5a0797ee67f90b4af0433c5d7ee00865)
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
							if (!File.Exists(Path.Combine(this.OutputPath, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cd161c587b229cb9747bf073c6e98b0b.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308)))))
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
								return (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3848);
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
					return (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3856);
				}
			}
			IL_DA:
			return (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3820);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000E84C File Offset: 0x0000CA4C
		private bool cc2ef74f5750f463aaf8c5509a893d76d()
		{
			c6114b34ba4893a53ebb4b599e0e2e3fc.cc751c6854e69459c391ffa856c0c146b cc751c6854e69459c391ffa856c0c146b = new c6114b34ba4893a53ebb4b599e0e2e3fc.cc751c6854e69459c391ffa856c0c146b();
			cc751c6854e69459c391ffa856c0c146b.c4404a159870bf55bb6f111e66e59e82d = this;
			cc751c6854e69459c391ffa856c0c146b.ce266b790b0737da827f9b964ef9c04aa = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6315), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3860) != 0);
			cc751c6854e69459c391ffa856c0c146b.cbe300171c6507f5b690a394f92443471 = c40ad917810501e1b7f5c1d6caa3f80c4.cab55a050df275722227783d6686266c9;
			new Thread(new ThreadStart(cc751c6854e69459c391ffa856c0c146b.c1622bb21ae47c5c3d17ea9f94c467dc7))
			{
				IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3864) != 0)
			}.Start();
			cc751c6854e69459c391ffa856c0c146b.ce266b790b0737da827f9b964ef9c04aa.ShowDialog();
			if (cc751c6854e69459c391ffa856c0c146b.cbe300171c6507f5b690a394f92443471 == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.cc2ef74f5750f463aaf8c5509a893d76d()).MethodHandle;
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3868) != 0;
			}
			IEnumerable<c34a3d9f5ce2884877848eea58fbbe484> cbe300171c6507f5b690a394f = cc751c6854e69459c391ffa856c0c146b.cbe300171c6507f5b690a394f92443471;
			Func<c34a3d9f5ce2884877848eea58fbbe484, bool> predicate;
			if ((predicate = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c56c1239b07d600adc83f6b7cea418469) == null)
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
				predicate = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c56c1239b07d600adc83f6b7cea418469 = new Func<c34a3d9f5ce2884877848eea58fbbe484, bool>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.cb2693e36379f97eeeb923fd01496421f));
			}
			return cbe300171c6507f5b690a394f.All(predicate);
		}

		// Token: 0x040000E3 RID: 227
		internal const int c05703b8abafafe0ad2876ab064990881 = 65536;

		// Token: 0x040000E4 RID: 228
		private const int c7db6200c0e930ede190ff400f8dbfffb = 64512;

		// Token: 0x040000E5 RID: 229
		private const int cf413f4da95d802f104d39ef786bc4a98 = 1024;

		// Token: 0x040000E6 RID: 230
		protected static List<string> c3951e863fae538ba58761ebada43ea0e;

		// Token: 0x040000E7 RID: 231
		private DateTime c86afb23ad91bc7b787933e88a6e0ee86 = DateTime.MinValue;

		// Token: 0x040000E8 RID: 232
		private c59ff87f6bdc69ff3440c18f170633236 c9b4b3ff036c43766ecdc83ecf3f4ad37;

		// Token: 0x040000E9 RID: 233
		private c4a0c1729f34b9cf7da2405086f4c0853 c0c42780bfe6c1baab84cf3c2584fc47e;

		// Token: 0x040000EA RID: 234
		public byte[] c88d6390a80f08a2c7ac4a268c95a94a2;

		// Token: 0x040000EB RID: 235
		public string cad1dd58d3844f8fa6ceed9a0fcd16398;

		// Token: 0x040000EC RID: 236
		public string cc0eab3c8af7b4aa29c084139a1df3c14;

		// Token: 0x040000ED RID: 237
		public bool cf7f2b1967398c4cc0c607544f80499bc;

		// Token: 0x040000EE RID: 238
		[CompilerGenerated]
		private bool cd88e7c4405569543a1aeab41b2c0862e;

		// Token: 0x040000EF RID: 239
		[CompilerGenerated]
		private Platform c67b336659ebc6a358f37a2dd07da345e;

		// Token: 0x040000F0 RID: 240
		[CompilerGenerated]
		private ceee61848167c1ade885c85db30acc060 ce8f5c281166462b616b6fcf87ea5db2e;

		// Token: 0x040000F1 RID: 241
		[CompilerGenerated]
		private bool c8fd2168c0b24cf6683baf93e977dec2b;

		// Token: 0x040000F2 RID: 242
		[CompilerGenerated]
		private string c7c4a2eb69dbaeafc270bce8e84ade7cb;

		// Token: 0x040000F3 RID: 243
		[CompilerGenerated]
		private readonly string cd27aaa3b9dbe2ffd3cdb46f868c5d6a6;

		// Token: 0x040000F4 RID: 244
		[CompilerGenerated]
		private string caf4f0fbd4e636f24f03bfcd218239c6f;

		// Token: 0x040000F5 RID: 245
		[CompilerGenerated]
		private DataSize c2bff306fd1553fbbcd992268ce4d4e46;

		// Token: 0x040000F6 RID: 246
		[CompilerGenerated]
		private byte[] c3c86591896d09b0325cf221d2f1eb66a;

		// Token: 0x040000F7 RID: 247
		[CompilerGenerated]
		private c9538952b0224ea717b33e0e4e7ae98c5 c77d5fd9a8eddd2112ef9cf8fb05511d4;

		// Token: 0x040000F8 RID: 248
		[CompilerGenerated]
		private bool cdd28272ef14548c4e1b10b9c7506a8e8;

		// Token: 0x040000F9 RID: 249
		[CompilerGenerated]
		private readonly TitleId cf7880c184a0785b1e8389c16e9919cf0;

		// Token: 0x040000FA RID: 250
		[CompilerGenerated]
		private cbcbdbfc95367bfec4c11b371d883aa2d cc5911b0281feffbf9588097cef424d77;

		// Token: 0x040000FB RID: 251
		[CompilerGenerated]
		private bool cfe7c115c960e3d14fff9ce774cd98ee3;

		// Token: 0x040000FC RID: 252
		[CompilerGenerated]
		private bool ca99a9415730d71a213d8b4100a5e97e8;

		// Token: 0x040000FD RID: 253
		[CompilerGenerated]
		private string c5f4c16c48de87a1692069352498bec38;

		// Token: 0x040000FE RID: 254
		[CompilerGenerated]
		private readonly string cc71870b54b9a4ea66de76ae6203b3a48;

		// Token: 0x02000100 RID: 256
		[CompilerGenerated]
		private sealed class cf3b3704f3dacfd1286a5e94e4c301737
		{
			// Token: 0x06000897 RID: 2199 RVA: 0x0005B740 File Offset: 0x00059940
			internal void c070dfac8e6997927ef05537edbfdc7e0(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				try
				{
					File.Delete(Path.Combine(this.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5470)));
					IEnumerable<FileInfo> files = new DirectoryInfo(this.c54a7d6cb5c0c0420ac46560b5c93cf03).GetFiles();
					Func<FileInfo, bool> predicate;
					if ((predicate = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.caf46ef29ad62e42be4851b9846a6c834) == null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.cf3b3704f3dacfd1286a5e94e4c301737.c070dfac8e6997927ef05537edbfdc7e0(object, EventArgs)).MethodHandle;
						}
						predicate = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.caf46ef29ad62e42be4851b9846a6c834 = new Func<FileInfo, bool>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.cc56c1bb58fffc661bcbdb53dd41196f4));
					}
					IEnumerable<FileInfo> source = files.Where(predicate);
					Func<FileInfo, long> keySelector;
					if ((keySelector = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c0ff139a2bc8be687a91fb84e73b45b3b) == null)
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
						keySelector = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c0ff139a2bc8be687a91fb84e73b45b3b = new Func<FileInfo, long>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.c2666d3b58f9ba7774fa369ea7378499e));
					}
					string name = source.OrderByDescending(keySelector).ElementAt(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29968)).Name;
					ProcessStartInfo processStartInfo2;
					if (this.c59ed465e3c07dd59a33c1597b6c3a016)
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
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97103);
						processStartInfo.WorkingDirectory = this.c54a7d6cb5c0c0420ac46560b5c93cf03;
						processStartInfo.Arguments = name;
						processStartInfo.CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29972) != 0);
						processStartInfo2 = processStartInfo;
						processStartInfo.WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29976);
					}
					else
					{
						ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
						processStartInfo3.FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97122);
						processStartInfo3.WorkingDirectory = this.c54a7d6cb5c0c0420ac46560b5c93cf03;
						processStartInfo3.Arguments = name;
						processStartInfo3.CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29980) != 0);
						processStartInfo2 = processStartInfo3;
						processStartInfo3.WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29984);
					}
					ProcessStartInfo startInfo = processStartInfo2;
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Exited += this.c374a7df11c72b7b7c3d524dfb4963bd6;
					process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29988) != 0);
					process.Start();
				}
				catch (Exception ex)
				{
					RadMessageBox.Show(ex.ToString());
					this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
				}
			}

			// Token: 0x06000898 RID: 2200 RVA: 0x0005B918 File Offset: 0x00059B18
			internal void c374a7df11c72b7b7c3d524dfb4963bd6(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				cf7c96734e58d8de9864e1ea854bc2b7b.c54f221133eb526d693ab1f91ea0d82db(this.c54a7d6cb5c0c0420ac46560b5c93cf03, Path.Combine(this.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39788)), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29992) != 0);
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x04000611 RID: 1553
			public string c54a7d6cb5c0c0420ac46560b5c93cf03;

			// Token: 0x04000612 RID: 1554
			public bool c59ed465e3c07dd59a33c1597b6c3a016;

			// Token: 0x04000613 RID: 1555
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;
		}

		// Token: 0x02000101 RID: 257
		[CompilerGenerated]
		private sealed class c72616e5fb409104ebc86b36449b44160
		{
			// Token: 0x0600089A RID: 2202 RVA: 0x0005B974 File Offset: 0x00059B74
			internal void c26983afe56b7574346516a0e15315a99(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				try
				{
					File.Delete(this.ce8ec543fa6943b1b52f7e5ff7f4131f0);
					IEnumerable<FileInfo> files = new DirectoryInfo(this.c85fa46dee7ef9473f93c9fb47da11f4d).GetFiles();
					Func<FileInfo, bool> predicate;
					if ((predicate = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c680aa9ba50bd3f38911c48203d30bdaf) == null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c72616e5fb409104ebc86b36449b44160.c26983afe56b7574346516a0e15315a99(object, EventArgs)).MethodHandle;
						}
						predicate = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c680aa9ba50bd3f38911c48203d30bdaf = new Func<FileInfo, bool>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.c6c37f204dbe02b90403aa5f80274db3c));
					}
					IEnumerable<FileInfo> source = files.Where(predicate);
					Func<FileInfo, long> keySelector;
					if ((keySelector = c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c1271b8dedc37571a955affc63969f529) == null)
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
						keySelector = (c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.c1271b8dedc37571a955affc63969f529 = new Func<FileInfo, long>(c6114b34ba4893a53ebb4b599e0e2e3fc.<>c.cdfab1996eb8651828de2a4469aa3481e.cb773b99aaa307d8f5f19364f4b786dd5));
					}
					string name = source.OrderByDescending(keySelector).ElementAt(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29996)).Name;
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97133);
					processStartInfo.WorkingDirectory = this.c85fa46dee7ef9473f93c9fb47da11f4d;
					string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97156);
					object arg;
					if (!this.c95cde87a8c7284b9136d7fc11a4c3eb5)
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
						arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97187);
					}
					else
					{
						arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97194);
					}
					processStartInfo.Arguments = string.Format(format, arg, name);
					processStartInfo.CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30000) != 0);
					processStartInfo.WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30004);
					ProcessStartInfo processStartInfo2 = processStartInfo;
					if (this.cc6df64457da5b0b4e60242e9be86a526)
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
						if (this.c95cde87a8c7284b9136d7fc11a4c3eb5)
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
							throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97201));
						}
						ProcessStartInfo processStartInfo3 = processStartInfo2;
						processStartInfo3.Arguments = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(processStartInfo3.Arguments, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97256));
					}
					if (this.c6507e2985c9bc79551226cd524f60fbc)
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
						ProcessStartInfo processStartInfo4 = processStartInfo2;
						processStartInfo4.Arguments = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(processStartInfo4.Arguments, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97379));
					}
					Process process = new Process();
					process.StartInfo = processStartInfo2;
					process.Exited += this.cac97e58d1bb6faedcdc1fa7554ef9784;
					process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30008) != 0);
					process.Start();
				}
				catch
				{
				}
			}

			// Token: 0x0600089B RID: 2203 RVA: 0x0005BB8C File Offset: 0x00059D8C
			internal void cac97e58d1bb6faedcdc1fa7554ef9784(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				Directory.CreateDirectory(Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(40243)));
				Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(40243));
				Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97468));
				ProcessStartInfo processStartInfo = new ProcessStartInfo
				{
					FileName = Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97133)),
					WorkingDirectory = this.c85fa46dee7ef9473f93c9fb47da11f4d,
					Arguments = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97479)
				};
				if (this.cc6df64457da5b0b4e60242e9be86a526)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c72616e5fb409104ebc86b36449b44160.cac97e58d1bb6faedcdc1fa7554ef9784(object, EventArgs)).MethodHandle;
					}
					ProcessStartInfo processStartInfo2 = processStartInfo;
					processStartInfo2.Arguments = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(processStartInfo2.Arguments, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97490));
				}
				if (this.c6507e2985c9bc79551226cd524f60fbc)
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
					ProcessStartInfo processStartInfo3 = processStartInfo;
					processStartInfo3.Arguments = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(processStartInfo3.Arguments, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97640));
				}
				Process process = new Process();
				process.StartInfo = processStartInfo;
				process.Exited += this.c8e9bd1e87a13d7740aeab2811c596ecb;
				process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30012) != 0);
				process.Start();
			}

			// Token: 0x0600089C RID: 2204 RVA: 0x0005BCD8 File Offset: 0x00059ED8
			internal void c8e9bd1e87a13d7740aeab2811c596ecb(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				FileInfo[] files = new DirectoryInfo(this.c85fa46dee7ef9473f93c9fb47da11f4d).GetFiles();
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30016); i < (int)c74808c84b2bffe4869b9b9d484057f82.cfeb04651f165d0166e7c10ab1acf8b28(files); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30020))
				{
					File.Delete(files[i].FullName);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c72616e5fb409104ebc86b36449b44160.c8e9bd1e87a13d7740aeab2811c596ecb(object, EventArgs)).MethodHandle;
				}
				this.cfe60371517f0baf9152d2203b196e54f.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x04000614 RID: 1556
			public string ce8ec543fa6943b1b52f7e5ff7f4131f0;

			// Token: 0x04000615 RID: 1557
			public string c85fa46dee7ef9473f93c9fb47da11f4d;

			// Token: 0x04000616 RID: 1558
			public bool c95cde87a8c7284b9136d7fc11a4c3eb5;

			// Token: 0x04000617 RID: 1559
			public bool cc6df64457da5b0b4e60242e9be86a526;

			// Token: 0x04000618 RID: 1560
			public bool c6507e2985c9bc79551226cd524f60fbc;

			// Token: 0x04000619 RID: 1561
			public c60797b4f8bfa489df1954dcdc88ad77d cfe60371517f0baf9152d2203b196e54f;
		}

		// Token: 0x02000102 RID: 258
		[CompilerGenerated]
		private sealed class c6369a16e814d3f71e5cf7639cf86ddc1
		{
			// Token: 0x0600089E RID: 2206 RVA: 0x0005BD60 File Offset: 0x00059F60
			internal void ca8cb41b99cdd5e3ce85ecf7ed0fc62f0(object cb0d7b0b893a41a39e281ddc32fc698bd, DataReceivedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				try
				{
					int cdc2df70fc41ec746908194e6c = (int)((double)long.Parse(cdf15457ee4816989343b6e6e96dd4cfe.Data) / this.c4404a159870bf55bb6f111e66e59e82d.Size.TotalBytes * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(30024));
					this.c561c2db76c5bf8c95a684eca3517d61c.cf1cbd6c013fa578db4f915226e6472b7(cdc2df70fc41ec746908194e6c);
				}
				catch
				{
				}
			}

			// Token: 0x0600089F RID: 2207 RVA: 0x0005BDC8 File Offset: 0x00059FC8
			internal void c70220581fee8ba54da1b05205805707c(object cb0d7b0b893a41a39e281ddc32fc698bd, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				FileSystem.RenameDirectory(this.c4404a159870bf55bb6f111e66e59e82d.c2ad07a436599cb91427b2e5fc8b7d4e5, new DirectoryInfo(this.c4404a159870bf55bb6f111e66e59e82d.OutputPath).Name);
				string text = Path.Combine(this.c8b8fabe20694b61835dba656f466c97c, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c6114b34ba4893a53ebb4b599e0e2e3fc.cdcb3a73ed076ade5e36c8c8a410f82aa(this.c970b31fe4f307e557ac948e45eecc894), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97067)));
				if (File.Exists(text))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c6369a16e814d3f71e5cf7639cf86ddc1.c70220581fee8ba54da1b05205805707c(object, EventArgs)).MethodHandle;
					}
					File.Delete(text);
				}
				File.Move(Path.Combine(this.c8b8fabe20694b61835dba656f466c97c, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.TitleId.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97067))), text);
				this.c561c2db76c5bf8c95a684eca3517d61c.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x0400061A RID: 1562
			public c60797b4f8bfa489df1954dcdc88ad77d c561c2db76c5bf8c95a684eca3517d61c;

			// Token: 0x0400061B RID: 1563
			public string c8b8fabe20694b61835dba656f466c97c;

			// Token: 0x0400061C RID: 1564
			public string c970b31fe4f307e557ac948e45eecc894;

			// Token: 0x0400061D RID: 1565
			public c6114b34ba4893a53ebb4b599e0e2e3fc c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000103 RID: 259
		[CompilerGenerated]
		private sealed class ceaf9648bc8d12c66c89febb937601441
		{
			// Token: 0x060008A1 RID: 2209 RVA: 0x0005BEA8 File Offset: 0x0005A0A8
			internal void c8a0baf45726075952376a6489b0849bd(object cb0d7b0b893a41a39e281ddc32fc698bd, cb776ccbd2397a5ddcfe3bb11c2bfd36a cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe);
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x0005BEC4 File Offset: 0x0005A0C4
			internal void cb5c5dc63dec7ae750c20fe977d91825b(object cb0d7b0b893a41a39e281ddc32fc698bd, bool cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.c8c38354cddaefb45b9cfcd9ed2838c37.ccb00690a4dbd11fab9ea8415c60a3154 = cdf15457ee4816989343b6e6e96dd4cfe;
				this.c076678ab058c983518e4c635945a760a = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30032) != 0);
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x0005BEF8 File Offset: 0x0005A0F8
			internal void ccba7eb6ccd9b362f9f8438af8ee19946(object cb0d7b0b893a41a39e281ddc32fc698bd, Exception cdf15457ee4816989343b6e6e96dd4cfe)
			{
				RadMessageBox.Show(c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97022), cdf15457ee4816989343b6e6e96dd4cfe));
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x0400061E RID: 1566
			public c8d41fc16c10f4ac30e6f0def27b49dc2 cf80aed8e439da0ff41b571df22072ddc;

			// Token: 0x0400061F RID: 1567
			public bool c076678ab058c983518e4c635945a760a;

			// Token: 0x04000620 RID: 1568
			public c6114b34ba4893a53ebb4b599e0e2e3fc.cd94ec51495d1952fa80e7b8d227f2850 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x02000104 RID: 260
		[CompilerGenerated]
		private sealed class cd94ec51495d1952fa80e7b8d227f2850
		{
			// Token: 0x04000621 RID: 1569
			public bool ccb00690a4dbd11fab9ea8415c60a3154;
		}

		// Token: 0x02000105 RID: 261
		[CompilerGenerated]
		private sealed class c2d6117ce0419e7d96a2573a1e16d9f8e
		{
			// Token: 0x060008A6 RID: 2214 RVA: 0x0005BF54 File Offset: 0x0005A154
			internal void c55729d8caddbf512c2b61b306b4deae8(object cb0d7b0b893a41a39e281ddc32fc698bd, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.c4404a159870bf55bb6f111e66e59e82d.CurrentlyUploaded = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30036) != 0);
				if (!this.c4404a159870bf55bb6f111e66e59e82d.c0c42780bfe6c1baab84cf3c2584fc47e.TransferStatus.Error)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c2d6117ce0419e7d96a2573a1e16d9f8e.c55729d8caddbf512c2b61b306b4deae8(object, EventArgs)).MethodHandle;
					}
					if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this.c4404a159870bf55bb6f111e66e59e82d) != null)
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
						c933d8f390d7a245458355cef338c6754.cd24593c859565ebb8c9faabbc5c75bef(this.c4404a159870bf55bb6f111e66e59e82d).c4e0b93cdfeb7fcd14340ea604aca37b3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30040) != 0);
					}
					if (this.c9b75f6ba06c0e9f0da24aef64cde37be)
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
						this.c4404a159870bf55bb6f111e66e59e82d.c0c42780bfe6c1baab84cf3c2584fc47e.c0278fefdcda956b0326d374499bb002b(this.c8e678ca35a7e295b3347019d7486cf98);
					}
				}
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> c34927e088ba152d38122e3c8e996a65a = this.c4404a159870bf55bb6f111e66e59e82d.c34927e088ba152d38122e3c8e996a65a;
				if (c34927e088ba152d38122e3c8e996a65a == null)
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
				c34927e088ba152d38122e3c8e996a65a(this.c4404a159870bf55bb6f111e66e59e82d, this.c4404a159870bf55bb6f111e66e59e82d.c0c42780bfe6c1baab84cf3c2584fc47e.TransferStatus);
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x0005C038 File Offset: 0x0005A238
			internal void c5f6c19cef2054323c0629e9694fcd9bf(object cb0d7b0b893a41a39e281ddc32fc698bd, long cdf15457ee4816989343b6e6e96dd4cfe)
			{
				try
				{
					this.ce807717d71793a02526c0b1b0b23746f += cdf15457ee4816989343b6e6e96dd4cfe;
					this.c2bc6dde17e54f4478afdae9d8eecd10c += (ulong)cdf15457ee4816989343b6e6e96dd4cfe;
					if (c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(DateTime.Now, this.ce74862f85140216f3a300712e5eab158).TotalSeconds < cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(30044))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c6114b34ba4893a53ebb4b599e0e2e3fc.c2d6117ce0419e7d96a2573a1e16d9f8e.c5f6c19cef2054323c0629e9694fcd9bf(object, long)).MethodHandle;
						}
						return;
					}
					c8d217bce073ddc882212f4d0e016403a c8d217bce073ddc882212f4d0e016403a = new c8d217bce073ddc882212f4d0e016403a(new DataSize(this.c2bc6dde17e54f4478afdae9d8eecd10c), c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(DateTime.Now, this.ce74862f85140216f3a300712e5eab158));
					int num = (int)((double)this.ce807717d71793a02526c0b1b0b23746f / (double)this.c03ec28224fb1f0e4d63350b629e7520b * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(30052));
					if (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30060))
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
						num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30064);
					}
					TimeSpan timeSpan = c7d35d8aac83dc5d10cf8f860b6e578b7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(new DataSize((ulong)(this.c03ec28224fb1f0e4d63350b629e7520b - this.ce807717d71793a02526c0b1b0b23746f)), c8d217bce073ddc882212f4d0e016403a);
					EventHandler<ce91c3ee3b6503970820b59a90b300d72> c73e931bf51a4d212e8590fc4d679e = this.c4404a159870bf55bb6f111e66e59e82d.c73e931bf51a4d212e8590fc4d679e319;
					if (c73e931bf51a4d212e8590fc4d679e == null)
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
					}
					else
					{
						c73e931bf51a4d212e8590fc4d679e(this.c4404a159870bf55bb6f111e66e59e82d, new ce91c3ee3b6503970820b59a90b300d72(num, num, num, timeSpan, timeSpan, timeSpan, c8d217bce073ddc882212f4d0e016403a, this.c4404a159870bf55bb6f111e66e59e82d));
					}
				}
				catch
				{
				}
				this.ce74862f85140216f3a300712e5eab158 = DateTime.Now;
				this.c2bc6dde17e54f4478afdae9d8eecd10c = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30068));
			}

			// Token: 0x04000622 RID: 1570
			public bool c9b75f6ba06c0e9f0da24aef64cde37be;

			// Token: 0x04000623 RID: 1571
			public string c8e678ca35a7e295b3347019d7486cf98;

			// Token: 0x04000624 RID: 1572
			public long ce807717d71793a02526c0b1b0b23746f;

			// Token: 0x04000625 RID: 1573
			public ulong c2bc6dde17e54f4478afdae9d8eecd10c;

			// Token: 0x04000626 RID: 1574
			public DateTime ce74862f85140216f3a300712e5eab158;

			// Token: 0x04000627 RID: 1575
			public long c03ec28224fb1f0e4d63350b629e7520b;

			// Token: 0x04000628 RID: 1576
			public c6114b34ba4893a53ebb4b599e0e2e3fc c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000106 RID: 262
		[CompilerGenerated]
		private sealed class cc751c6854e69459c391ffa856c0c146b
		{
			// Token: 0x060008A9 RID: 2217 RVA: 0x0005C1B4 File Offset: 0x0005A3B4
			internal void c1622bb21ae47c5c3d17ea9f94c467dc7()
			{
				this.cbe300171c6507f5b690a394f92443471 = c57022ba9c2a08b010c87dd03dad49fd5.c5e3af937cfcc28c36e94943c630f21ff(this.c4404a159870bf55bb6f111e66e59e82d);
				this.ce266b790b0737da827f9b964ef9c04aa.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x04000629 RID: 1577
			public List<c34a3d9f5ce2884877848eea58fbbe484> cbe300171c6507f5b690a394f92443471;

			// Token: 0x0400062A RID: 1578
			public c60797b4f8bfa489df1954dcdc88ad77d ce266b790b0737da827f9b964ef9c04aa;

			// Token: 0x0400062B RID: 1579
			public c6114b34ba4893a53ebb4b599e0e2e3fc c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
