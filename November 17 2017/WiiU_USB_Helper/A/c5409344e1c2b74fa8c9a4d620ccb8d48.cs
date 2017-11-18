using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using NusHelper;
using Nus_Helper_Shared_Core.NusHelper.Saves;
using WIIU_Downloader.Forms;

namespace A
{
	// Token: 0x02000032 RID: 50
	public class c5409344e1c2b74fa8c9a4d620ccb8d48 : c6114b34ba4893a53ebb4b599e0e2e3fc
	{
		// Token: 0x06000109 RID: 265 RVA: 0x0000B390 File Offset: 0x00009590
		public c5409344e1c2b74fa8c9a4d620ccb8d48(string c12d0d8e4a348d50592ec186ea66a67ef, TitleId c6446be850d2de5f37330117509aacef1, string cc3f904a2c5ba8f87204592c77530a0a6, byte[] c2bdc0253794dde45b70b2d85ceddacde, DataSize c5db06f710879d10bd98fa2c1adf0deb8, List<c6a2f8acae5ff1a8a909193a5c5de6687> c92fb5cbad19cbe61a70530d7d55afe0d, string c29717b7b66eb189bc1ff5d53d5d8996d, string cbb24cd140aab56af3ac752e44409cccb, string cecfa8f9dff98cd32dc6af9f323a3c2b8, string c8bb3ca4a8bf4e6d064eef316d02aab52, Platform c6be080890f79103c80f5a5b56ac19566, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42) : base(c12d0d8e4a348d50592ec186ea66a67ef, c6446be850d2de5f37330117509aacef1, cc3f904a2c5ba8f87204592c77530a0a6, c2bdc0253794dde45b70b2d85ceddacde, c5db06f710879d10bd98fa2c1adf0deb8, c8bb3ca4a8bf4e6d064eef316d02aab52, cd6f1966a966a6f1dabeb755aded4df42)
		{
			this.EshopId = c29717b7b66eb189bc1ff5d53d5d8996d;
			this.IconUrl = cecfa8f9dff98cd32dc6af9f323a3c2b8;
			this.ProductId = cbb24cd140aab56af3ac752e44409cccb;
			this.Updates = c92fb5cbad19cbe61a70530d7d55afe0d;
			base.Platform = c6be080890f79103c80f5a5b56ac19566;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000B47C File Offset: 0x0000967C
		static c5409344e1c2b74fa8c9a4d620ccb8d48()
		{
			// Note: this type is marked as 'beforefieldinit'.
			string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3328));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3332)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4940);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3336)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3340)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4945);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3344)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4950);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3348)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4955);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3352)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4960);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3356)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4965);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3360)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4970);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3364)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4975);
			c5409344e1c2b74fa8c9a4d620ccb8d48.c50721383f70b6a6dadd78ed12933cc14 = array;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000B578 File Offset: 0x00009778
		public string cae8945ad667defbe7c150465d2c8aaba
		{
			get
			{
				if (!base.c9e33774c6343e7c7fe83022678b014ae)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.get_cae8945ad667defbe7c150465d2c8aaba()).MethodHandle;
					}
					throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3665));
				}
				switch (base.Platform - (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3132))
				{
				case 0:
					return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cb8f9f33f826be3eada7ba28d67e79858, this.ProductId);
				case 1:
					return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c91e9c5e7cdfb0a4fd8543c41610549aa, this.ProductId);
				case 2:
					return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c32a66bf3a7bd33b219d209058a47e358, this.ProductId);
				case 3:
					return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c26bf6445cf9a81da1e4a43a03a72443b, this.ProductId);
				default:
					throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3665));
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000B64C File Offset: 0x0000984C
		public string c5665d7b9f8d8c4130a023e2e716f86bb
		{
			get
			{
				string text;
				if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(base.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3752)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.get_c5665d7b9f8d8c4130a023e2e716f86bb()).MethodHandle;
					}
					if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(base.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
						text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3766);
					}
					else
					{
						text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
					}
				}
				else
				{
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3776);
				}
				string arg = text;
				if (base.System != (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3136))
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
					return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3781), arg, this.ProductId);
				}
				return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3866), arg, this.ProductId);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000B730 File Offset: 0x00009930
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000B744 File Offset: 0x00009944
		public c2b8ef1783ae572d19956814809070e24 Dlc { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000B758 File Offset: 0x00009958
		public string EshopId { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000B76C File Offset: 0x0000996C
		public bool c4d60b04b76c0a6507055b66cfeaf6b6b
		{
			get
			{
				return this.Dlc != c80a45304a7306046b0892e514c366d37.cab55a050df275722227783d6686266c9;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000B788 File Offset: 0x00009988
		public bool c66201ce2763de795655e645e059b6451
		{
			get
			{
				return this.Updates.Count > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3140);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000B7B0 File Offset: 0x000099B0
		public string IconUrl { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000B7C4 File Offset: 0x000099C4
		public bool c69ce979c7f0d69fc5bdbed5a8bb3804f
		{
			get
			{
				return c6a5e9b85d86b4e098a511017a1073d71.cba492c136fe5dbb7b4a1e75e12490067.Contains(this);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000B7E0 File Offset: 0x000099E0
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000B808 File Offset: 0x00009A08
		public bool c4e0b93cdfeb7fcd14340ea604aca37b3
		{
			get
			{
				return c6114b34ba4893a53ebb4b599e0e2e3fc.c3951e863fae538ba58761ebada43ea0e.Contains(base.TitleId.IdRaw);
			}
			set
			{
				bool flag = c6114b34ba4893a53ebb4b599e0e2e3fc.c3951e863fae538ba58761ebada43ea0e.Contains(base.TitleId.IdRaw);
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.set_c4e0b93cdfeb7fcd14340ea604aca37b3(bool)).MethodHandle;
					}
					if (!value)
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
						c6114b34ba4893a53ebb4b599e0e2e3fc.c3951e863fae538ba58761ebada43ea0e.Remove(base.TitleId.IdRaw);
						return;
					}
				}
				if ((flag ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3144) && value)
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
					c6114b34ba4893a53ebb4b599e0e2e3fc.c3951e863fae538ba58761ebada43ea0e.Add(base.TitleId.IdRaw);
				}
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000B8A0 File Offset: 0x00009AA0
		public c4c1cf20119750bfee2a0bb499f990883 c9defc57488e57eae7e78baf97af93d96()
		{
			switch (base.Platform - (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3148))
			{
			case 0:
				return new cb4e425f2d70132d57f01f6cf60a868ac(this);
			case 1:
				return new cb4e425f2d70132d57f01f6cf60a868ac(this);
			case 2:
				return new c36ae571439d6691c1084666cd8f1610a(this);
			case 3:
				return new c53b58dec2861b92890ecfc33be7c9308(this);
			default:
				return null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		public override string OutputPath
		{
			get
			{
				switch (base.System)
				{
				case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
				{
					string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3152));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3156)] = base.OutputPath;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3160)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2568);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3164)] = base.Region;
					int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3168);
					string text;
					if (!base.CfwOnly)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.get_OutputPath()).MethodHandle;
						}
						text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3961);
					}
					else
					{
						text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3972);
					}
					array[num] = text;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3172)] = base.c1423b4c96c3a4da08669ce24059dd34a;
					return Path.Combine(array);
				}
				case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
				{
					string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3176));
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3180)] = base.OutputPath;
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3184)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613);
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3188)] = base.Region;
					int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3192);
					string text2;
					if (!base.CfwOnly)
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
						text2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3961);
					}
					else
					{
						text2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3972);
					}
					array2[num2] = text2;
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3196)] = base.c1423b4c96c3a4da08669ce24059dd34a;
					return Path.Combine(array2);
				}
				case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000BA88 File Offset: 0x00009C88
		public string ProductId { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000BA9C File Offset: 0x00009C9C
		public List<c6a2f8acae5ff1a8a909193a5c5de6687> Updates { get; } = new List<c6a2f8acae5ff1a8a909193a5c5de6687>();

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000BAB0 File Offset: 0x00009CB0
		private string c10f63366dff6d3b0598848e499e3783d
		{
			get
			{
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3200));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3204)] = base.OutputPath;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3208)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3212)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3983);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3216)] = base.Region;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3220)] = base.c1423b4c96c3a4da08669ce24059dd34a;
				return Path.Combine(array);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000BB44 File Offset: 0x00009D44
		public string c0a5daa72a0577c4aa15ab8798f850b7a
		{
			get
			{
				string c0d6c37d812d5d4b610705a6421056252 = "";
				switch (this.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().ca435006c85356cb7385a782de8889a0a)
				{
				case c59ff87f6bdc69ff3440c18f170633236.c75de07cf35dca1805ba630578576f097:
					c0d6c37d812d5d4b610705a6421056252 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4045);
					break;
				case c59ff87f6bdc69ff3440c18f170633236.c5aa713eacee5b6b8a97c2fe89c08b5bc:
					c0d6c37d812d5d4b610705a6421056252 = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4104), this.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>().cce55c1c54594dc99c5eedaa006793af4);
					break;
				case c59ff87f6bdc69ff3440c18f170633236.c08d15a5b99c94345141e1274e0123138:
					c0d6c37d812d5d4b610705a6421056252 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3994);
					break;
				}
				int num = this.Updates.Count<c6a2f8acae5ff1a8a909193a5c5de6687>();
				IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687> updates = this.Updates;
				Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool> predicate;
				if ((predicate = c5409344e1c2b74fa8c9a4d620ccb8d48.<>c.c9091d9169fdb3e771e7004723292e3e4) == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.get_c0a5daa72a0577c4aa15ab8798f850b7a()).MethodHandle;
					}
					predicate = (c5409344e1c2b74fa8c9a4d620ccb8d48.<>c.c9091d9169fdb3e771e7004723292e3e4 = new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(c5409344e1c2b74fa8c9a4d620ccb8d48.<>c.cdfab1996eb8651828de2a4469aa3481e.c3a37ac1b787f24951c86e8d51e033f7e));
				}
				int num2 = updates.Count(predicate);
				return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4189), num2, num));
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000BC4C File Offset: 0x00009E4C
		public void c6cbaf2b6329c21ba2ed2db7bade8d600()
		{
			cf7c96734e58d8de9864e1ea854bc2b7b cf7c96734e58d8de9864e1ea854bc2b7b = base.c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3224) != 0);
			if (cf7c96734e58d8de9864e1ea854bc2b7b == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.c6cbaf2b6329c21ba2ed2db7bade8d600()).MethodHandle;
				}
				return;
			}
			cf7c96734e58d8de9864e1ea854bc2b7b.ce08d3fcff1ec6badc424f2432fc6e909();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000BC88 File Offset: 0x00009E88
		public void c2afb00aa7adf167aeb365693e260c662(string c85fa46dee7ef9473f93c9fb47da11f4d, string ce7d298d73bab0df9bcfdc208996dceec)
		{
			c5409344e1c2b74fa8c9a4d620ccb8d48.c01126c98134d44fc522c760452b4ab88 c01126c98134d44fc522c760452b4ab = new c5409344e1c2b74fa8c9a4d620ccb8d48.c01126c98134d44fc522c760452b4ab88();
			c01126c98134d44fc522c760452b4ab.c85fa46dee7ef9473f93c9fb47da11f4d = c85fa46dee7ef9473f93c9fb47da11f4d;
			c01126c98134d44fc522c760452b4ab.ce7d298d73bab0df9bcfdc208996dceec = ce7d298d73bab0df9bcfdc208996dceec;
			c01126c98134d44fc522c760452b4ab.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4210), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3228) != 0);
			c01126c98134d44fc522c760452b4ab.ca2502c0473b61cbe22fc8828fa69e39b = Path.Combine(Path.GetTempPath(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4305));
			Directory.CreateDirectory(c01126c98134d44fc522c760452b4ab.ca2502c0473b61cbe22fc8828fa69e39b);
			Directory.CreateDirectory(c01126c98134d44fc522c760452b4ab.c85fa46dee7ef9473f93c9fb47da11f4d);
			base.c232388e2d78eeebd51589f4bd158ad0f(c01126c98134d44fc522c760452b4ab.ca2502c0473b61cbe22fc8828fa69e39b, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3232) != 0);
			cd4880843d42f3dd634ca35c8e909b573.cc9ff642c53c06a69106c76874bd71e34(c01126c98134d44fc522c760452b4ab.ca2502c0473b61cbe22fc8828fa69e39b);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4334),
				WorkingDirectory = c01126c98134d44fc522c760452b4ab.ca2502c0473b61cbe22fc8828fa69e39b,
				Arguments = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4357)
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3236) != 0);
			process.Exited += c01126c98134d44fc522c760452b4ab.c6303fa05e9c5a6707df4a5c6a792f84d;
			process.Start();
			c01126c98134d44fc522c760452b4ab.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		public List<SaveDescription> c6a83d4e684fcad568643a49c6ab6bbbf()
		{
			List<SaveDescription> list = new List<SaveDescription>();
			if (!Directory.Exists(this.c10f63366dff6d3b0598848e499e3783d))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.c6a83d4e684fcad568643a49c6ab6bbbf()).MethodHandle;
				}
				return list;
			}
			IEnumerable<FileInfo> source = new DirectoryInfo(this.c10f63366dff6d3b0598848e499e3783d).EnumerateFiles();
			Func<FileInfo, bool> predicate;
			if ((predicate = c5409344e1c2b74fa8c9a4d620ccb8d48.<>c.c60f25d797a27bc929b58d37a2b3286cd) == null)
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
				predicate = (c5409344e1c2b74fa8c9a4d620ccb8d48.<>c.c60f25d797a27bc929b58d37a2b3286cd = new Func<FileInfo, bool>(c5409344e1c2b74fa8c9a4d620ccb8d48.<>c.cdfab1996eb8651828de2a4469aa3481e.c0995cfb44cec5cc1475cfe18c992522a));
			}
			IEnumerator<FileInfo> enumerator = source.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					FileInfo fileInfo = enumerator.Current;
					try
					{
						FileStream fileStream = File.Open(fileInfo.FullName, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3240));
						try
						{
							ZipArchive zipArchive = new ZipArchive(fileStream, (ZipArchiveMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3244));
							try
							{
								StreamReader streamReader = new StreamReader(zipArchive.GetEntry(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4438)).Open());
								try
								{
									list.Add(JsonConvert.DeserializeObject<SaveDescription>(streamReader.ReadToEnd()));
								}
								finally
								{
									if (streamReader != null)
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
										((IDisposable)streamReader).Dispose();
									}
								}
							}
							finally
							{
								if (zipArchive != null)
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
									((IDisposable)zipArchive).Dispose();
								}
							}
						}
						finally
						{
							if (fileStream != null)
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
								((IDisposable)fileStream).Dispose();
							}
						}
					}
					catch
					{
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
			return list;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000BF58 File Offset: 0x0000A158
		public void c9a85391d186628655535db1f9c4d3bbc(IPAddress cb689e652eac22c54ef570b384f0df229, string c9a1d53a52573cd619e583426889bec4c)
		{
			if (!Directory.Exists(this.c10f63366dff6d3b0598848e499e3783d))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.c9a85391d186628655535db1f9c4d3bbc(IPAddress, string)).MethodHandle;
				}
				Directory.CreateDirectory(this.c10f63366dff6d3b0598848e499e3783d);
			}
			string text = ((long)DateTime.UtcNow.Subtract(new DateTime(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3248), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3252), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3256))).TotalSeconds).ToString();
			string text2 = Path.Combine(this.c10f63366dff6d3b0598848e499e3783d, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4457)));
			try
			{
				c4cd44b7f0ea7b2eedfa2e91d4fd51a09.c23bc14d19fb4d13e1a6b4ea7bc2d11fd(this, cb689e652eac22c54ef570b384f0df229, text2);
			}
			catch
			{
				if (File.Exists(text2))
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
					File.Delete(text2);
				}
				throw;
			}
			if (!File.Exists(text2))
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
			FileStream fileStream = File.Open(text2, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3260), (FileAccess)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3264));
			try
			{
				ZipArchive zipArchive = new ZipArchive(fileStream, (ZipArchiveMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3268));
				try
				{
					StreamWriter streamWriter = new StreamWriter(zipArchive.CreateEntry(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4438)).Open());
					try
					{
						string value = JsonConvert.SerializeObject(new SaveDescription
						{
							Description = c9a1d53a52573cd619e583426889bec4c,
							Timestamp = text,
							Region = base.Region,
							Name = base.Name,
							TitleId = base.TitleId.IdRaw
						});
						streamWriter.Write(value);
					}
					finally
					{
						if (streamWriter != null)
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
							((IDisposable)streamWriter).Dispose();
						}
					}
				}
				finally
				{
					if (zipArchive != null)
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
						((IDisposable)zipArchive).Dispose();
					}
				}
			}
			finally
			{
				if (fileStream != null)
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
					((IDisposable)fileStream).Dispose();
				}
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000C164 File Offset: 0x0000A364
		public void c478c8f7708269b920f3c23fa293a94a4(IPAddress cb689e652eac22c54ef570b384f0df229, string c96439509c811cfeabba554b4aeddfe4d)
		{
			string cebde33105e7bc56f018312406bb67aae = Path.Combine(this.c10f63366dff6d3b0598848e499e3783d, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c96439509c811cfeabba554b4aeddfe4d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4457)));
			c4cd44b7f0ea7b2eedfa2e91d4fd51a09.c68ab30dee2e91d4605491213bc03a867(this, cb689e652eac22c54ef570b384f0df229, cebde33105e7bc56f018312406bb67aae);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		public static DriveInfo cb0b8fdc8df7e4723501037a4f8491959(DataSize c5db06f710879d10bd98fa2c1adf0deb8)
		{
			c9e3b15e0906fc28b9aaaafda91843cfe c9e3b15e0906fc28b9aaaafda91843cfe = new c9e3b15e0906fc28b9aaaafda91843cfe(c5db06f710879d10bd98fa2c1adf0deb8);
			if (c9e3b15e0906fc28b9aaaafda91843cfe.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3272))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.cb0b8fdc8df7e4723501037a4f8491959(DataSize)).MethodHandle;
				}
				return c9e3b15e0906fc28b9aaaafda91843cfe.cdeb88a4da0e27c7f39e2cad0c950f4b0;
			}
			return null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		private string c92fab9dc425f30f85b5340a2954ad11a(string c40a40b0f6b49ceff754199eea6a7defe)
		{
			try
			{
				int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3276);
				c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = new c866035f717c1c145e269422264e8f519
				{
					c00dacc5708b46f842a758e6902713b32 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3280) != 0)
				};
				if (base.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3284))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.c92fab9dc425f30f85b5340a2954ad11a(string)).MethodHandle;
					}
					if (base.c9e33774c6343e7c7fe83022678b014ae)
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
					}
					else
					{
						string text = c866035f717c1c145e269422264e8f.c8fde2f16b504e6f2d61ca9ffff7c28f6(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4559), c40a40b0f6b49ceff754199eea6a7defe, this.EshopId));
						if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ""))
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
							return text;
						}
						while (i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(c5409344e1c2b74fa8c9a4d620ccb8d48.c50721383f70b6a6dadd78ed12933cc14))
						{
							if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d48.c50721383f70b6a6dadd78ed12933cc14[i], c40a40b0f6b49ceff754199eea6a7defe))
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
								text = c866035f717c1c145e269422264e8f.c8fde2f16b504e6f2d61ca9ffff7c28f6(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4559), c5409344e1c2b74fa8c9a4d620ccb8d48.c50721383f70b6a6dadd78ed12933cc14[i], this.EshopId));
								if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ""))
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
									return text;
								}
							}
							i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3288);
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
						goto IL_164;
					}
				}
				return c866035f717c1c145e269422264e8f.c90d21f0d803ed867f4420adf5ed63604(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4466), base.TitleId.IdRaw));
			}
			catch
			{
			}
			IL_164:
			return null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000C374 File Offset: 0x0000A574
		public void c0bc5b046c46ca1090fa7a9ae47e299ea(Action<cbdbecb4f2aabec5734fa1432e4548f8e, c5409344e1c2b74fa8c9a4d620ccb8d48> c229d7a19122c4db63ba68d1fc0e06cbe)
		{
			c5409344e1c2b74fa8c9a4d620ccb8d48.ccbe168e3788903266812112d64610c9a ccbe168e3788903266812112d64610c9a = new c5409344e1c2b74fa8c9a4d620ccb8d48.ccbe168e3788903266812112d64610c9a();
			ccbe168e3788903266812112d64610c9a.c4404a159870bf55bb6f111e66e59e82d = this;
			ccbe168e3788903266812112d64610c9a.c229d7a19122c4db63ba68d1fc0e06cbe = c229d7a19122c4db63ba68d1fc0e06cbe;
			Task.Run(new Action(ccbe168e3788903266812112d64610c9a.c66810916fd417317e2c6fb057927d1cb));
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		public bool cdafb32c110213e85fda6c89dc227c65b(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			if (c804bc52f7f79bffee6fd394ef382eb76 != this)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.cdafb32c110213e85fda6c89dc227c65b(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				if (this.c66201ce2763de795655e645e059b6451)
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
					if (c804bc52f7f79bffee6fd394ef382eb76 == this.Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>())
					{
						goto IL_72;
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
				if (this.c4d60b04b76c0a6507055b66cfeaf6b6b)
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
					return c804bc52f7f79bffee6fd394ef382eb76 == this.Dlc;
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3292) != 0;
			}
			IL_72:
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3296) != 0;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000C434 File Offset: 0x0000A634
		public override string ToString()
		{
			string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4707);
			object[] array = c03afd7759879ce2659a1d311b66f5509.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3300));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3304)] = base.Name;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3308)] = base.Size;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3312)] = base.Region;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3316)] = base.cce55c1c54594dc99c5eedaa006793af4;
			return string.Format(format, array);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		public c9f09e7c9177b659947793f836fb406ba cb22daca7b90d08a80c30fb487368db8c()
		{
			cf73c09f4e7123594c77f50f36eff3418 cf73c09f4e7123594c77f50f36eff = new cf73c09f4e7123594c77f50f36eff3418(this, (WhatToAction)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3320));
			if (cf73c09f4e7123594c77f50f36eff.ShowDialog() != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3324))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.cb22daca7b90d08a80c30fb487368db8c()).MethodHandle;
				}
				return null;
			}
			return new c9f09e7c9177b659947793f836fb406ba
			{
				c699c8bc0a4d81b873957798fbfb86a1e = cf73c09f4e7123594c77f50f36eff.CopyDlc,
				c0e676a00eeebd45f592e232d614e45fc = cf73c09f4e7123594c77f50f36eff.CopyUpdate,
				c29ba96361e8b79c561c2b396fd54760a = cf73c09f4e7123594c77f50f36eff.CopyGame,
				ce3a858deff0367f9060c2df25425c742 = cf73c09f4e7123594c77f50f36eff.c9f4bf79f56cd07529ca7850385fa2cb4
			};
		}

		// Token: 0x040000AC RID: 172
		private readonly string cb8f9f33f826be3eada7ba28d67e79858 = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4752), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1);

		// Token: 0x040000AD RID: 173
		private readonly string c91e9c5e7cdfb0a4fd8543c41610549aa = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4809), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1);

		// Token: 0x040000AE RID: 174
		private readonly string c32a66bf3a7bd33b219d209058a47e358 = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4852), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1);

		// Token: 0x040000AF RID: 175
		private readonly string c26bf6445cf9a81da1e4a43a03a72443b = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4897), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1);

		// Token: 0x040000B0 RID: 176
		private static readonly string[] c50721383f70b6a6dadd78ed12933cc14;

		// Token: 0x040000B1 RID: 177
		private cbdbecb4f2aabec5734fa1432e4548f8e c43172dab1587e4fe45c10d98843b2114;

		// Token: 0x040000B2 RID: 178
		[CompilerGenerated]
		private c2b8ef1783ae572d19956814809070e24 c331cd080bfd59ef2f38a2880e82a9b2d;

		// Token: 0x040000B3 RID: 179
		[CompilerGenerated]
		private readonly string ccc2ea647394109ebd5ca2f25f70ffdc0;

		// Token: 0x040000B4 RID: 180
		[CompilerGenerated]
		private readonly string c2b1a043610db3c15cd65c83cfc108eb3;

		// Token: 0x040000B5 RID: 181
		[CompilerGenerated]
		private readonly string c56ee366aeb75b7381730d9f3f2f5119b;

		// Token: 0x040000B6 RID: 182
		[CompilerGenerated]
		private readonly List<c6a2f8acae5ff1a8a909193a5c5de6687> cf9e248b055d130c55431ef8e9dd191a5;

		// Token: 0x040000B7 RID: 183
		public c6e4901274630d05cbbf6924f95d2edfb c43a36c2ec69a55ef18526fe33b26814a = new c6e4901274630d05cbbf6924f95d2edfb();

		// Token: 0x040000B8 RID: 184
		public c6e4901274630d05cbbf6924f95d2edfb c37137df1274eeaf494a83b79943d89e2 = new c6e4901274630d05cbbf6924f95d2edfb();

		// Token: 0x040000B9 RID: 185
		public c6e4901274630d05cbbf6924f95d2edfb c1b244cd4be573ae37f8e3f6fd69b891f = new c6e4901274630d05cbbf6924f95d2edfb();

		// Token: 0x020000FD RID: 253
		[CompilerGenerated]
		private sealed class c01126c98134d44fc522c760452b4ab88
		{
			// Token: 0x06000889 RID: 2185 RVA: 0x0005B160 File Offset: 0x00059360
			internal void c6303fa05e9c5a6707df4a5c6a792f84d(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
				string destinationFileName = Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.ce7d298d73bab0df9bcfdc208996dceec, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97067)));
				FileSystem.MoveFile(Path.Combine(this.ca2502c0473b61cbe22fc8828fa69e39b, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5470)), destinationFileName, (UIOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29932));
				cf7c96734e58d8de9864e1ea854bc2b7b.c54f221133eb526d693ab1f91ea0d82db(this.ca2502c0473b61cbe22fc8828fa69e39b, "", cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29936) != 0);
			}

			// Token: 0x04000602 RID: 1538
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;

			// Token: 0x04000603 RID: 1539
			public string c85fa46dee7ef9473f93c9fb47da11f4d;

			// Token: 0x04000604 RID: 1540
			public string ce7d298d73bab0df9bcfdc208996dceec;

			// Token: 0x04000605 RID: 1541
			public string ca2502c0473b61cbe22fc8828fa69e39b;
		}

		// Token: 0x020000FE RID: 254
		[CompilerGenerated]
		private sealed class ccbe168e3788903266812112d64610c9a
		{
			// Token: 0x0600088B RID: 2187 RVA: 0x0005B1F8 File Offset: 0x000593F8
			internal void c66810916fd417317e2c6fb057927d1cb()
			{
				if (this.c4404a159870bf55bb6f111e66e59e82d.c43172dab1587e4fe45c10d98843b2114 == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c5409344e1c2b74fa8c9a4d620ccb8d48.ccbe168e3788903266812112d64610c9a.c66810916fd417317e2c6fb057927d1cb()).MethodHandle;
					}
					string c40a40b0f6b49ceff754199eea6a7defe = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4945);
					if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(46688)))
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
						if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(47158)))
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
							c40a40b0f6b49ceff754199eea6a7defe = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97076);
						}
						else
						{
							string twoLetterISOLanguageName = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
							if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(twoLetterISOLanguageName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11611)))
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
								if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(twoLetterISOLanguageName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11616)))
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
									if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(twoLetterISOLanguageName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11621)))
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
										if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(twoLetterISOLanguageName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11626)))
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
											if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(twoLetterISOLanguageName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11631)))
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
												string text;
												if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
													text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4940);
												}
												else
												{
													text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
												}
												c40a40b0f6b49ceff754199eea6a7defe = text;
											}
											else
											{
												string text2;
												if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
													text2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4975);
												}
												else
												{
													text2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97081);
												}
												c40a40b0f6b49ceff754199eea6a7defe = text2;
											}
										}
										else
										{
											string text3;
											if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
												text3 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
											}
											else
											{
												text3 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4965);
											}
											c40a40b0f6b49ceff754199eea6a7defe = text3;
										}
									}
									else
									{
										string text4;
										if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
											text4 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
										}
										else
										{
											text4 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4955);
										}
										c40a40b0f6b49ceff754199eea6a7defe = text4;
									}
								}
								else
								{
									string text5;
									if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
										text5 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
									}
									else
									{
										text5 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4960);
									}
									c40a40b0f6b49ceff754199eea6a7defe = text5;
								}
							}
							else
							{
								string text6;
								if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c4404a159870bf55bb6f111e66e59e82d.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
									text6 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4940);
								}
								else
								{
									text6 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
								}
								c40a40b0f6b49ceff754199eea6a7defe = text6;
							}
						}
					}
					string text7 = this.c4404a159870bf55bb6f111e66e59e82d.c92fab9dc425f30f85b5340a2954ad11a(c40a40b0f6b49ceff754199eea6a7defe);
					if (text7 != null)
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
						try
						{
							this.c4404a159870bf55bb6f111e66e59e82d.c43172dab1587e4fe45c10d98843b2114 = JsonConvert.DeserializeObject<cb86c13d418bd11a875872ab250b5f8d9>(text7).Title;
						}
						catch
						{
						}
					}
				}
				if (this.c4404a159870bf55bb6f111e66e59e82d.c43172dab1587e4fe45c10d98843b2114 != null)
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
					this.c229d7a19122c4db63ba68d1fc0e06cbe(this.c4404a159870bf55bb6f111e66e59e82d.c43172dab1587e4fe45c10d98843b2114, this.c4404a159870bf55bb6f111e66e59e82d);
				}
			}

			// Token: 0x04000606 RID: 1542
			public Action<cbdbecb4f2aabec5734fa1432e4548f8e, c5409344e1c2b74fa8c9a4d620ccb8d48> c229d7a19122c4db63ba68d1fc0e06cbe;

			// Token: 0x04000607 RID: 1543
			public c5409344e1c2b74fa8c9a4d620ccb8d48 c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
