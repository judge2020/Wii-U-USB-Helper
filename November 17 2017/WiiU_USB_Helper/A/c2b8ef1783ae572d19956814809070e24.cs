using System;
using System.IO;
using NusHelper;

namespace A
{
	// Token: 0x0200002E RID: 46
	public class c2b8ef1783ae572d19956814809070e24 : c6114b34ba4893a53ebb4b599e0e2e3fc
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000A540 File Offset: 0x00008740
		public c2b8ef1783ae572d19956814809070e24(string c12d0d8e4a348d50592ec186ea66a67ef, TitleId c6446be850d2de5f37330117509aacef1, string cc3f904a2c5ba8f87204592c77530a0a6, byte[] c2bdc0253794dde45b70b2d85ceddacde, DataSize c5db06f710879d10bd98fa2c1adf0deb8, string c8bb3ca4a8bf4e6d064eef316d02aab52, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42) : base(c12d0d8e4a348d50592ec186ea66a67ef, c6446be850d2de5f37330117509aacef1, cc3f904a2c5ba8f87204592c77530a0a6, c2bdc0253794dde45b70b2d85ceddacde, c5db06f710879d10bd98fa2c1adf0deb8, c8bb3ca4a8bf4e6d064eef316d02aab52, cd6f1966a966a6f1dabeb755aded4df42)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000A560 File Offset: 0x00008760
		public override string c2dd75b8c3673fb76f16dea7e88c83243
		{
			get
			{
				return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(base.c2dd75b8c3673fb76f16dea7e88c83243, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3591));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000A588 File Offset: 0x00008788
		public override string OutputPath
		{
			get
			{
				switch (base.System)
				{
				case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
				{
					string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3084));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3088)] = base.OutputPath;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3092)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2568);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3096)] = base.Region;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3100)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3604);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3104)] = base.c1423b4c96c3a4da08669ce24059dd34a;
					return Path.Combine(array);
				}
				case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
				{
					string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3108));
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3112)] = base.OutputPath;
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3116)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613);
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3120)] = base.Region;
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3124)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3604);
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3128)] = base.c1423b4c96c3a4da08669ce24059dd34a;
					return Path.Combine(array2);
				}
				case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000A6CC File Offset: 0x000088CC
		public override string ToString()
		{
			return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3622), base.Name, base.Size, base.Region);
		}
	}
}
