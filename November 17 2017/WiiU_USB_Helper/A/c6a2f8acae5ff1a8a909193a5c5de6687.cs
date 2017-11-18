using System;
using System.IO;
using NusHelper;

namespace A
{
	// Token: 0x02000037 RID: 55
	public class c6a2f8acae5ff1a8a909193a5c5de6687 : c6114b34ba4893a53ebb4b599e0e2e3fc
	{
		// Token: 0x0600016E RID: 366 RVA: 0x0000E924 File Offset: 0x0000CB24
		public c6a2f8acae5ff1a8a909193a5c5de6687(string c12d0d8e4a348d50592ec186ea66a67ef, TitleId c6446be850d2de5f37330117509aacef1, string cc3f904a2c5ba8f87204592c77530a0a6, byte[] c2bdc0253794dde45b70b2d85ceddacde, DataSize c5db06f710879d10bd98fa2c1adf0deb8, string cb9752ebbe18b2ad5c3dc365914dc024b, string c8bb3ca4a8bf4e6d064eef316d02aab52, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42) : base(c12d0d8e4a348d50592ec186ea66a67ef, c6446be850d2de5f37330117509aacef1, cc3f904a2c5ba8f87204592c77530a0a6, c2bdc0253794dde45b70b2d85ceddacde, c5db06f710879d10bd98fa2c1adf0deb8, c8bb3ca4a8bf4e6d064eef316d02aab52, cd6f1966a966a6f1dabeb755aded4df42)
		{
			base.Version = cb9752ebbe18b2ad5c3dc365914dc024b;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000E94C File Offset: 0x0000CB4C
		public override string c2dd75b8c3673fb76f16dea7e88c83243
		{
			get
			{
				return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(base.c2dd75b8c3673fb76f16dea7e88c83243, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6418));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000E974 File Offset: 0x0000CB74
		public override string OutputPath
		{
			get
			{
				switch (base.System)
				{
				case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
				{
					string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3872));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3876)] = base.OutputPath;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3880)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2568);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3884)] = base.Region;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3888)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6437);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3892)] = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(base.c1423b4c96c3a4da08669ce24059dd34a, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6452), base.Version));
					return Path.Combine(array);
				}
				case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
				{
					string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3896));
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3900)] = base.OutputPath;
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3904)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613);
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3908)] = base.Region;
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3912)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6437);
					array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3916)] = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(base.c1423b4c96c3a4da08669ce24059dd34a, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6452), base.Version));
					return Path.Combine(array2);
				}
				case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000EAFC File Offset: 0x0000CCFC
		public override string ToString()
		{
			string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6467);
			object[] array = c03afd7759879ce2659a1d311b66f5509.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3920));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3924)] = base.Name;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3928)] = base.Version;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3932)] = base.Size;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3936)] = base.Region;
			return string.Format(format, array);
		}
	}
}
