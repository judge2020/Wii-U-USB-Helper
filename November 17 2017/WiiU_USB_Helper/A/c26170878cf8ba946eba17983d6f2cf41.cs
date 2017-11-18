using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A
{
	// Token: 0x02000093 RID: 147
	internal class c26170878cf8ba946eba17983d6f2cf41 : cf7c96734e58d8de9864e1ea854bc2b7b
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00021C88 File Offset: 0x0001FE88
		public c26170878cf8ba946eba17983d6f2cf41(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, bool c07532d90fa519783a3736afc4d48beb9) : base(c804bc52f7f79bffee6fd394ef382eb76, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41433), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41448), c07532d90fa519783a3736afc4d48beb9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9172) != 0)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00021CC0 File Offset: 0x0001FEC0
		public override bool cab66f65884757b260d3cede7f6adcb72()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9152) != 0;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00021CD8 File Offset: 0x0001FED8
		public override string c9ad9e3ddcd7e5e324cd01b2dfad9f78d()
		{
			return Path.Combine(base.cbc2836ea62c32bc8df1f63f72af3a491, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41386));
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00021D00 File Offset: 0x0001FF00
		public override bool c1313a3694d9d4cbd109dd5b1b1fe94b1()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9156) != 0;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00021D18 File Offset: 0x0001FF18
		public override string c010f80182206bd1b4a523f2e99f7657a()
		{
			return Path.Combine(base.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6884), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41409), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41418));
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00021D58 File Offset: 0x0001FF58
		protected override void c0af5c4e148a68a530b83d61893c72e0e(bool c3c7497942acfe55b365013a6254dd980)
		{
			ce07c379a1090dd9de869aa5e3a694e98.cd12bcf8ad68acf6c29b3f1686e86e24f();
			if (!base.c8a01a4300b89e645a23909a3d4f8ec38)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c26170878cf8ba946eba17983d6f2cf41.c0af5c4e148a68a530b83d61893c72e0e(bool)).MethodHandle;
				}
				if (this.cbd119e33552f6e7eda45b0c64e636c3a.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9160))
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
					IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> files = this.cbd119e33552f6e7eda45b0c64e636c3a.c88e4a51a8d0b3e7d29a28576dde32c38().Files;
					Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate;
					if ((predicate = c26170878cf8ba946eba17983d6f2cf41.<>c.c5e57be654d50df4c034b8f0b917ceb75) == null)
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
						predicate = (c26170878cf8ba946eba17983d6f2cf41.<>c.c5e57be654d50df4c034b8f0b917ceb75 = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(c26170878cf8ba946eba17983d6f2cf41.<>c.cdfab1996eb8651828de2a4469aa3481e.c92707acfd7a1449956d17201cacf60d9));
					}
					IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> c4af034c05fd55c7c0ca5b56577ddd3b = files.Where(predicate);
					Directory.CreateDirectory(Path.Combine(base.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6884), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41409)));
					this.cbd119e33552f6e7eda45b0c64e636c3a.cf08369cbb3a626a84f05ff893b78fed7(base.c4d68e2c283dbf2783383a0a1d0aaa75a, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9164) != 0, c3c7497942acfe55b365013a6254dd980, c4af034c05fd55c7c0ca5b56577ddd3b, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9168) != 0);
				}
			}
		}
	}
}
