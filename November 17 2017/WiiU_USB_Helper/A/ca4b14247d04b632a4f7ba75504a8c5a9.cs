using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A
{
	// Token: 0x02000095 RID: 149
	internal class ca4b14247d04b632a4f7ba75504a8c5a9 : cf7c96734e58d8de9864e1ea854bc2b7b
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x00022140 File Offset: 0x00020340
		public ca4b14247d04b632a4f7ba75504a8c5a9(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, bool c07532d90fa519783a3736afc4d48beb9) : base(c804bc52f7f79bffee6fd394ef382eb76, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41602), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41621), c07532d90fa519783a3736afc4d48beb9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9288) != 0)
		{
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00022178 File Offset: 0x00020378
		public override bool cab66f65884757b260d3cede7f6adcb72()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9260) != 0;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00022190 File Offset: 0x00020390
		public override string c9ad9e3ddcd7e5e324cd01b2dfad9f78d()
		{
			return Path.Combine(base.cbc2836ea62c32bc8df1f63f72af3a491, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41575));
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000221B8 File Offset: 0x000203B8
		public override bool c1313a3694d9d4cbd109dd5b1b1fe94b1()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9264) != 0;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000221D0 File Offset: 0x000203D0
		public override string c010f80182206bd1b4a523f2e99f7657a()
		{
			string path = Path.Combine(base.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6884), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13097));
			if (!Directory.Exists(path))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ca4b14247d04b632a4f7ba75504a8c5a9.c010f80182206bd1b4a523f2e99f7657a()).MethodHandle;
				}
				return "";
			}
			string[] files = Directory.GetFiles(path);
			if (files.Any<string>())
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
				return files[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9268)];
			}
			return "";
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00022258 File Offset: 0x00020458
		protected override void c0af5c4e148a68a530b83d61893c72e0e(bool c3c7497942acfe55b365013a6254dd980)
		{
			if (!base.c8a01a4300b89e645a23909a3d4f8ec38)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ca4b14247d04b632a4f7ba75504a8c5a9.c0af5c4e148a68a530b83d61893c72e0e(bool)).MethodHandle;
				}
				if (this.cbd119e33552f6e7eda45b0c64e636c3a.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9272))
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
					IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> files = this.cbd119e33552f6e7eda45b0c64e636c3a.c88e4a51a8d0b3e7d29a28576dde32c38().Files;
					Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate;
					if ((predicate = ca4b14247d04b632a4f7ba75504a8c5a9.<>c.c5e57be654d50df4c034b8f0b917ceb75) == null)
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
						predicate = (ca4b14247d04b632a4f7ba75504a8c5a9.<>c.c5e57be654d50df4c034b8f0b917ceb75 = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(ca4b14247d04b632a4f7ba75504a8c5a9.<>c.cdfab1996eb8651828de2a4469aa3481e.c92707acfd7a1449956d17201cacf60d9));
					}
					IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> c4af034c05fd55c7c0ca5b56577ddd3b = files.Where(predicate);
					this.cbd119e33552f6e7eda45b0c64e636c3a.cf08369cbb3a626a84f05ff893b78fed7(base.c4d68e2c283dbf2783383a0a1d0aaa75a, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9276) != 0, c3c7497942acfe55b365013a6254dd980, c4af034c05fd55c7c0ca5b56577ddd3b, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9280) != 0);
				}
			}
			base.c54f221133eb526d693ab1f91ea0d82db(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9284) != 0);
		}
	}
}
