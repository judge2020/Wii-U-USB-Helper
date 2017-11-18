using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CommonCompressors;
using Microsoft.VisualBasic.FileIO;
using NusHelper;

namespace A
{
	// Token: 0x0200008D RID: 141
	internal class c8b671fda31f88dc7c7875175126002f3 : cf7c96734e58d8de9864e1ea854bc2b7b
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x0001E42C File Offset: 0x0001C62C
		public c8b671fda31f88dc7c7875175126002f3(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, bool c07532d90fa519783a3736afc4d48beb9) : base(c804bc52f7f79bffee6fd394ef382eb76, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39426), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39888), c07532d90fa519783a3736afc4d48beb9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7836) != 0)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0001E464 File Offset: 0x0001C664
		public override void c37b3d3a9ef4a26c65a3fac4aa3cda6c2()
		{
			ce07c379a1090dd9de869aa5e3a694e98.cd12bcf8ad68acf6c29b3f1686e86e24f();
			this.c7b0056810caa739dca9f6974d350b678();
			this.c1add8d63ef8501f3f59df9167bc45133(c6a5e9b85d86b4e098a511017a1073d71.cfc010356f4abbfd6616a07cb36c09d69, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39291));
			this.c1add8d63ef8501f3f59df9167bc45133(c6a5e9b85d86b4e098a511017a1073d71.cca9ff917fe281ce8adb390af187767ba, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39336));
			this.c1add8d63ef8501f3f59df9167bc45133(c6a5e9b85d86b4e098a511017a1073d71.c7526f0cd997f7f6664e00009cd5c18a1, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39381));
			this.c0af5c4e148a68a530b83d61893c72e0e(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7644) != 0);
			base.c57d8c53c26088bcba39b12aebd5cfb69(this.c725acc3eddb72d7ac90f323bc7845e34());
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		private void c1add8d63ef8501f3f59df9167bc45133(c5409344e1c2b74fa8c9a4d620ccb8d48 cd01b667eed28e4e5eefe8d16ba575231, string cf915a2bb7d73eb4759b989313c2fa8ca)
		{
			c8b671fda31f88dc7c7875175126002f3.c7af2929b95cebbf713cc2782d79ce539 c7af2929b95cebbf713cc2782d79ce = new c8b671fda31f88dc7c7875175126002f3.c7af2929b95cebbf713cc2782d79ce539();
			c7af2929b95cebbf713cc2782d79ce.cd01b667eed28e4e5eefe8d16ba575231 = cd01b667eed28e4e5eefe8d16ba575231;
			c7af2929b95cebbf713cc2782d79ce.cf915a2bb7d73eb4759b989313c2fa8ca = cf915a2bb7d73eb4759b989313c2fa8ca;
			string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7648));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7652)] = Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7656));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7660)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39426);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7664)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39437);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7668)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39446);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7672)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39511);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7676)] = c7af2929b95cebbf713cc2782d79ce.cd01b667eed28e4e5eefe8d16ba575231.TitleId.Low.ToLower();
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7680)] = c7af2929b95cebbf713cc2782d79ce.cd01b667eed28e4e5eefe8d16ba575231.TitleId.High.ToLower();
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7684)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6884);
			string text = Path.Combine(array);
			Directory.CreateDirectory(text);
			c7af2929b95cebbf713cc2782d79ce.ccc0dd489e3d37d708f40781b5cf22ecb = Path.Combine(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39522));
			if (File.Exists(c7af2929b95cebbf713cc2782d79ce.ccc0dd489e3d37d708f40781b5cf22ecb))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8b671fda31f88dc7c7875175126002f3.c1add8d63ef8501f3f59df9167bc45133(c5409344e1c2b74fa8c9a4d620ccb8d48, string)).MethodHandle;
				}
				return;
			}
			cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = new cdb02a77cadec7790d5c7c433ab736a12(null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7688) != 0);
			c7af2929b95cebbf713cc2782d79ce.cfe60371517f0baf9152d2203b196e54f = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39559), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7692) != 0);
			cdb02a77cadec7790d5c7c433ab736a.cdcc2c8329c5e63d415472bd3bd0a99aa += c7af2929b95cebbf713cc2782d79ce.c1cdffbf9bd26317bef9180007145b553;
			cdb02a77cadec7790d5c7c433ab736a.c2484bd018cc259ebf6256e671a3c8276 += c7af2929b95cebbf713cc2782d79ce.ce94c30fb4a2f146bc236229dce2655f7;
			c6114b34ba4893a53ebb4b599e0e2e3fc[] array2 = c4ac7b1ff726812ebb6cc8b1485582880.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7696));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7700)] = c7af2929b95cebbf713cc2782d79ce.cd01b667eed28e4e5eefe8d16ba575231;
			cdb02a77cadec7790d5c7c433ab736a.cd5841496c51e4ccda38bf5370111aeaa(array2.ToList<c6114b34ba4893a53ebb4b599e0e2e3fc>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7704), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7708));
			c7af2929b95cebbf713cc2782d79ce.cfe60371517f0baf9152d2203b196e54f.ShowDialog();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001E6EC File Offset: 0x0001C8EC
		private void c7b0056810caa739dca9f6974d350b678()
		{
			c8b671fda31f88dc7c7875175126002f3.c6f0b80c988eb5b63c15273a164c35f37 c6f0b80c988eb5b63c15273a164c35f = new c8b671fda31f88dc7c7875175126002f3.c6f0b80c988eb5b63c15273a164c35f37();
			c6f0b80c988eb5b63c15273a164c35f.c19b7656a3c5703a5e5e43cfd6140a025 = Path.Combine(Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7712)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39426), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39638), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39653));
			if (File.Exists(c6f0b80c988eb5b63c15273a164c35f.c19b7656a3c5703a5e5e43cfd6140a025))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8b671fda31f88dc7c7875175126002f3.c7b0056810caa739dca9f6974d350b678()).MethodHandle;
				}
				return;
			}
			cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = new cdb02a77cadec7790d5c7c433ab736a12(null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7716) != 0);
			c6f0b80c988eb5b63c15273a164c35f.cfe60371517f0baf9152d2203b196e54f = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39684), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7720) != 0);
			cdb02a77cadec7790d5c7c433ab736a.cdcc2c8329c5e63d415472bd3bd0a99aa += c6f0b80c988eb5b63c15273a164c35f.cc2545731f3e245706fab298da1b5ed1d;
			cdb02a77cadec7790d5c7c433ab736a.c2484bd018cc259ebf6256e671a3c8276 += c6f0b80c988eb5b63c15273a164c35f.c0798ad715914593a3e95d768b1cd8dbc;
			c6114b34ba4893a53ebb4b599e0e2e3fc[] array = c4ac7b1ff726812ebb6cc8b1485582880.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7724));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7728)] = c6a5e9b85d86b4e098a511017a1073d71.c99ac45cfb12f02773ff8738dcbee1a4a;
			cdb02a77cadec7790d5c7c433ab736a.cd5841496c51e4ccda38bf5370111aeaa(array.ToList<c6114b34ba4893a53ebb4b599e0e2e3fc>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7732), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7736));
			c6f0b80c988eb5b63c15273a164c35f.cfe60371517f0baf9152d2203b196e54f.ShowDialog();
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001E80C File Offset: 0x0001CA0C
		public override string c725acc3eddb72d7ac90f323bc7845e34()
		{
			return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38952), this.c010f80182206bd1b4a523f2e99f7657a());
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001E834 File Offset: 0x0001CA34
		public override string c9ad9e3ddcd7e5e324cd01b2dfad9f78d()
		{
			return Path.Combine(base.cbc2836ea62c32bc8df1f63f72af3a491, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39763));
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001E85C File Offset: 0x0001CA5C
		public override string c010f80182206bd1b4a523f2e99f7657a()
		{
			return Path.Combine(base.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39788));
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0001E884 File Offset: 0x0001CA84
		private string c38acdd33137605ebbf7a1767bd949d62
		{
			get
			{
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7740));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7744)] = Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7748));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7752)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39426);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7756)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39805);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7760)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39814);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7764)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39446);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7768)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39446);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7772)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39511);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7776)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39839);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7780)] = this.cbd119e33552f6e7eda45b0c64e636c3a.TitleId.High.ToLower();
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7784)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6884);
				return Path.Combine(array);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		private string cdcc3f8e7b02e807e3041a6bda34d9f4b
		{
			get
			{
				return Path.Combine(this.c38acdd33137605ebbf7a1767bd949d62, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39856));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
		private string ce53c24f42ea6dfa45a2a71fcd9bacb2b
		{
			get
			{
				return Path.Combine(this.c38acdd33137605ebbf7a1767bd949d62, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39863));
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001EA00 File Offset: 0x0001CC00
		public override void c6b3ff55a7c487618bd5b51ee9721b004()
		{
			try
			{
				Directory.Delete(this.c38acdd33137605ebbf7a1767bd949d62, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7788) != 0);
			}
			catch
			{
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001EA3C File Offset: 0x0001CC3C
		private void cfc63ab3b1163a0d9652d90e11edccd66(bool c3c7497942acfe55b365013a6254dd980)
		{
			if (c9f447140d3c9c692fc73eba21d436e1c.c0b398ab350e72b0d64d512bae8520b85(this.cbd119e33552f6e7eda45b0c64e636c3a) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8b671fda31f88dc7c7875175126002f3.cfc63ab3b1163a0d9652d90e11edccd66(bool)).MethodHandle;
				}
				return;
			}
			if (c3c7497942acfe55b365013a6254dd980)
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
			c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = c933d8f390d7a245458355cef338c6754.cd24593c859565ebb8c9faabbc5c75bef(this.cbd119e33552f6e7eda45b0c64e636c3a);
			if (!c5409344e1c2b74fa8c9a4d620ccb8d.c66201ce2763de795655e645e059b6451)
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
			if (cc986a36f7534edc08e2f8221002d522a.c13b4c491030e28a0f262267b54ab959c(c5409344e1c2b74fa8c9a4d620ccb8d.Updates[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7792)]))
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
			bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7796) != 0;
			try
			{
				IEnumerable<c6a2f8acae5ff1a8a909193a5c5de6687> updates = c5409344e1c2b74fa8c9a4d620ccb8d.Updates;
				Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool> predicate;
				if ((predicate = c8b671fda31f88dc7c7875175126002f3.<>c.cad52d22cfbb45f7b30370360574ffaa4) == null)
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
					predicate = (c8b671fda31f88dc7c7875175126002f3.<>c.cad52d22cfbb45f7b30370360574ffaa4 = new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(c8b671fda31f88dc7c7875175126002f3.<>c.cdfab1996eb8651828de2a4469aa3481e.c182f4c12f929ded7ae046d6571c88423));
				}
				c6a2f8acae5ff1a8a909193a5c5de6687 c6a2f8acae5ff1a8a909193a5c5de = updates.Last(predicate);
				if (!Directory.Exists(this.c38acdd33137605ebbf7a1767bd949d62))
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
					Directory.CreateDirectory(this.c38acdd33137605ebbf7a1767bd949d62);
				}
				else if (this.c1313a3694d9d4cbd109dd5b1b1fe94b1())
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
					if (File.Exists(this.cdcc3f8e7b02e807e3041a6bda34d9f4b))
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
						flag = c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(File.ReadAllText(this.cdcc3f8e7b02e807e3041a6bda34d9f4b), c6a2f8acae5ff1a8a909193a5c5de.Version);
					}
				}
				if (!flag)
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
					if (!c3c7497942acfe55b365013a6254dd980)
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
						c6a2f8acae5ff1a8a909193a5c5de.c232388e2d78eeebd51589f4bd158ad0f(this.c38acdd33137605ebbf7a1767bd949d62, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7800) != 0);
						FileSystem.RenameFile(Path.Combine(this.c38acdd33137605ebbf7a1767bd949d62, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39788)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39863));
						File.WriteAllText(this.cdcc3f8e7b02e807e3041a6bda34d9f4b, c6a2f8acae5ff1a8a909193a5c5de.Version);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001EC20 File Offset: 0x0001CE20
		public override ulong cd432dc5c6962dc6093ffdf141c495abd()
		{
			ulong result;
			try
			{
				result = ulong.Parse(File.ReadAllText(this.cdcc3f8e7b02e807e3041a6bda34d9f4b));
			}
			catch
			{
				result = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7804));
			}
			return result;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001EC68 File Offset: 0x0001CE68
		public override DataSize c59792486d0bd6862618a19710cb7f523()
		{
			DataSize result;
			try
			{
				result = new DataSize((ulong)new FileInfo(this.ce53c24f42ea6dfa45a2a71fcd9bacb2b).Length);
			}
			catch
			{
				result = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7808)));
			}
			return result;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		protected override void c0af5c4e148a68a530b83d61893c72e0e(bool c3c7497942acfe55b365013a6254dd980)
		{
			if (!base.c8a01a4300b89e645a23909a3d4f8ec38)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8b671fda31f88dc7c7875175126002f3.c0af5c4e148a68a530b83d61893c72e0e(bool)).MethodHandle;
				}
				string text = Path.Combine(base.c4d68e2c283dbf2783383a0a1d0aaa75a, this.cbd119e33552f6e7eda45b0c64e636c3a.TitleId.IdRaw);
				if (Directory.Exists(text))
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
					Directory.Delete(text, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7812) != 0);
				}
				c933d8f390d7a245458355cef338c6754.cd24593c859565ebb8c9faabbc5c75bef(this.cbd119e33552f6e7eda45b0c64e636c3a).c232388e2d78eeebd51589f4bd158ad0f(text, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7816) != 0);
				string name = new DirectoryInfo(base.ce62321b4e96fa914081f8f8cc2f87d3c).Name;
				if (Directory.Exists(Path.Combine(base.c4d68e2c283dbf2783383a0a1d0aaa75a, name)))
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
					Directory.Delete(Path.Combine(base.c4d68e2c283dbf2783383a0a1d0aaa75a, name), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7820) != 0);
				}
				FileSystem.RenameDirectory(text, name);
			}
			this.cfc63ab3b1163a0d9652d90e11edccd66(c3c7497942acfe55b365013a6254dd980);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001EDB0 File Offset: 0x0001CFB0
		public override bool c1313a3694d9d4cbd109dd5b1b1fe94b1()
		{
			if (File.Exists(this.ce53c24f42ea6dfa45a2a71fcd9bacb2b))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8b671fda31f88dc7c7875175126002f3.c1313a3694d9d4cbd109dd5b1b1fe94b1()).MethodHandle;
				}
				return new FileInfo(this.ce53c24f42ea6dfa45a2a71fcd9bacb2b).Length > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7824);
			}
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7828) != 0;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001EE10 File Offset: 0x0001D010
		public override bool cab66f65884757b260d3cede7f6adcb72()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7832) != 0;
		}

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		private sealed class c7af2929b95cebbf713cc2782d79ce539
		{
			// Token: 0x06000910 RID: 2320 RVA: 0x0005DF48 File Offset: 0x0005C148
			internal void c1cdffbf9bd26317bef9180007145b553(object cd020a9448b1902e4410f2e9f4a256959, c8e60ceced0ce323f661e853233d10ec2 c920e624ed3f68a7518020d25dc06be2d)
			{
				c8b671fda31f88dc7c7875175126002f3.ce05cba0f2d5c7f12ca0753def7aabfea ce05cba0f2d5c7f12ca0753def7aabfea = new c8b671fda31f88dc7c7875175126002f3.ce05cba0f2d5c7f12ca0753def7aabfea();
				ce05cba0f2d5c7f12ca0753def7aabfea.c8c38354cddaefb45b9cfcd9ed2838c37 = this;
				Path.Combine(Path.GetTempPath(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5470));
				this.cd01b667eed28e4e5eefe8d16ba575231.c2845e22243014eee92c54eee0c15c904(Path.GetTempPath(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5297));
				ce05cba0f2d5c7f12ca0753def7aabfea.c54a7d6cb5c0c0420ac46560b5c93cf03 = Path.GetTempPath();
				cd4880843d42f3dd634ca35c8e909b573.cc9ff642c53c06a69106c76874bd71e34(ce05cba0f2d5c7f12ca0753def7aabfea.c54a7d6cb5c0c0420ac46560b5c93cf03);
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = Path.Combine(ce05cba0f2d5c7f12ca0753def7aabfea.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5286)),
					WorkingDirectory = ce05cba0f2d5c7f12ca0753def7aabfea.c54a7d6cb5c0c0420ac46560b5c93cf03
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30420) != 0);
				process.Exited += ce05cba0f2d5c7f12ca0753def7aabfea.c85662697034d6bab77fa1af3adc2930f;
				process.Start();
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x0005E01C File Offset: 0x0005C21C
			internal void ce94c30fb4a2f146bc236229dce2655f7(object cb0d7b0b893a41a39e281ddc32fc698bd, ce91c3ee3b6503970820b59a90b300d72 cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cfe60371517f0baf9152d2203b196e54f.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe.GameProgress);
			}

			// Token: 0x040006A2 RID: 1698
			public c5409344e1c2b74fa8c9a4d620ccb8d48 cd01b667eed28e4e5eefe8d16ba575231;

			// Token: 0x040006A3 RID: 1699
			public string cf915a2bb7d73eb4759b989313c2fa8ca;

			// Token: 0x040006A4 RID: 1700
			public string ccc0dd489e3d37d708f40781b5cf22ecb;

			// Token: 0x040006A5 RID: 1701
			public c60797b4f8bfa489df1954dcdc88ad77d cfe60371517f0baf9152d2203b196e54f;
		}

		// Token: 0x0200012D RID: 301
		[CompilerGenerated]
		private sealed class ce05cba0f2d5c7f12ca0753def7aabfea
		{
			// Token: 0x06000913 RID: 2323 RVA: 0x0005E050 File Offset: 0x0005C250
			internal void c85662697034d6bab77fa1af3adc2930f(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				try
				{
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						FileName = Path.Combine(this.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97133)),
						WorkingDirectory = this.c54a7d6cb5c0c0420ac46560b5c93cf03,
						Arguments = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98253), this.c8c38354cddaefb45b9cfcd9ed2838c37.cf915a2bb7d73eb4759b989313c2fa8ca)
					};
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Exited += this.c3bcddfb62c08f16f3b846e869ec59bc4;
					process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30424) != 0);
					process.Start();
				}
				catch
				{
				}
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x0005E100 File Offset: 0x0005C300
			internal void c3bcddfb62c08f16f3b846e869ec59bc4(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				string path = Path.Combine(this.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39522));
				FileStream fileStream = File.Create(this.c8c38354cddaefb45b9cfcd9ed2838c37.ccc0dd489e3d37d708f40781b5cf22ecb);
				try
				{
					FileStream fileStream2 = File.Open(path, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30428));
					try
					{
						fileStream2.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30432), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30436));
						int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30440);
						while ((long)num < fileStream2.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30448))
						{
							int num2 = fileStream2.ReadByte();
							fileStream.WriteByte((byte)num2);
							num += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30444);
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c8b671fda31f88dc7c7875175126002f3.ce05cba0f2d5c7f12ca0753def7aabfea.c3bcddfb62c08f16f3b846e869ec59bc4(object, EventArgs)).MethodHandle;
						}
					}
					finally
					{
						if (fileStream2 != null)
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
							((IDisposable)fileStream2).Dispose();
						}
					}
				}
				finally
				{
					if (fileStream != null)
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
						((IDisposable)fileStream).Dispose();
					}
				}
				this.c8c38354cddaefb45b9cfcd9ed2838c37.cfe60371517f0baf9152d2203b196e54f.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x040006A6 RID: 1702
			public string c54a7d6cb5c0c0420ac46560b5c93cf03;

			// Token: 0x040006A7 RID: 1703
			public c8b671fda31f88dc7c7875175126002f3.c7af2929b95cebbf713cc2782d79ce539 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x0200012E RID: 302
		[CompilerGenerated]
		private sealed class cdfe092796793745a1ce1d64d233593bd
		{
			// Token: 0x06000916 RID: 2326 RVA: 0x0005E230 File Offset: 0x0005C430
			internal void c5c7926839ce9dae1f459bd78e95bfb23(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				try
				{
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						FileName = Path.Combine(this.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97133)),
						WorkingDirectory = this.c54a7d6cb5c0c0420ac46560b5c93cf03,
						Arguments = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98368)
					};
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Exited += this.c7f2530bd7c7bd7773b987578c4088df0;
					process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30452) != 0);
					process.Start();
				}
				catch
				{
				}
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x0005E2CC File Offset: 0x0005C4CC
			internal void c7f2530bd7c7bd7773b987578c4088df0(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97133),
					WorkingDirectory = this.c54a7d6cb5c0c0420ac46560b5c93cf03,
					Arguments = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98522)
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30456) != 0);
				process.Exited += this.c1ba471e7e0d48232a37646b1ed0039a7;
				process.Start();
			}

			// Token: 0x06000918 RID: 2328 RVA: 0x0005E348 File Offset: 0x0005C548
			internal void c1ba471e7e0d48232a37646b1ed0039a7(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				string path = Path.Combine(this.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98637), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98666));
				byte[] buffer = new LZ11().Decompress(File.ReadAllBytes(path));
				Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30460)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39426), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39638)));
				FileStream fileStream = File.Create(this.c8c38354cddaefb45b9cfcd9ed2838c37.c19b7656a3c5703a5e5e43cfd6140a025);
				try
				{
					MemoryStream memoryStream = new MemoryStream(buffer);
					try
					{
						memoryStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30464), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30468));
						fileStream.Write(c45ab3113ea09209e9f00b6f5f2beea47.c277aeed55c5fcb223240f078ce05c2e0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30472), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c45ab3113ea09209e9f00b6f5f2beea47.c277aeed55c5fcb223240f078ce05c2e0));
						for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30476); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30484); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30480))
						{
							int num = memoryStream.ReadByte();
							fileStream.WriteByte((byte)num);
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c8b671fda31f88dc7c7875175126002f3.cdfe092796793745a1ce1d64d233593bd.c1ba471e7e0d48232a37646b1ed0039a7(object, EventArgs)).MethodHandle;
						}
						fileStream.Write(c45ab3113ea09209e9f00b6f5f2beea47.c53d022dd05da782de06207ef49e1606b, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30488), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c45ab3113ea09209e9f00b6f5f2beea47.c53d022dd05da782de06207ef49e1606b));
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
				finally
				{
					if (fileStream != null)
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
						((IDisposable)fileStream).Dispose();
					}
				}
				this.c8c38354cddaefb45b9cfcd9ed2838c37.cfe60371517f0baf9152d2203b196e54f.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x040006A8 RID: 1704
			public string c54a7d6cb5c0c0420ac46560b5c93cf03;

			// Token: 0x040006A9 RID: 1705
			public c8b671fda31f88dc7c7875175126002f3.c6f0b80c988eb5b63c15273a164c35f37 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x0200012F RID: 303
		[CompilerGenerated]
		private sealed class c6f0b80c988eb5b63c15273a164c35f37
		{
			// Token: 0x0600091A RID: 2330 RVA: 0x0005E500 File Offset: 0x0005C700
			internal void cc2545731f3e245706fab298da1b5ed1d(object cd020a9448b1902e4410f2e9f4a256959, c8e60ceced0ce323f661e853233d10ec2 c920e624ed3f68a7518020d25dc06be2d)
			{
				c8b671fda31f88dc7c7875175126002f3.cdfe092796793745a1ce1d64d233593bd cdfe092796793745a1ce1d64d233593bd = new c8b671fda31f88dc7c7875175126002f3.cdfe092796793745a1ce1d64d233593bd();
				cdfe092796793745a1ce1d64d233593bd.c8c38354cddaefb45b9cfcd9ed2838c37 = this;
				Path.Combine(Path.GetTempPath(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5470));
				c6a5e9b85d86b4e098a511017a1073d71.c99ac45cfb12f02773ff8738dcbee1a4a.c2845e22243014eee92c54eee0c15c904(Path.GetTempPath(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5297));
				cdfe092796793745a1ce1d64d233593bd.c54a7d6cb5c0c0420ac46560b5c93cf03 = Path.GetTempPath();
				cd4880843d42f3dd634ca35c8e909b573.cc9ff642c53c06a69106c76874bd71e34(cdfe092796793745a1ce1d64d233593bd.c54a7d6cb5c0c0420ac46560b5c93cf03);
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = Path.Combine(cdfe092796793745a1ce1d64d233593bd.c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5286)),
					WorkingDirectory = cdfe092796793745a1ce1d64d233593bd.c54a7d6cb5c0c0420ac46560b5c93cf03
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30492) != 0);
				process.Exited += cdfe092796793745a1ce1d64d233593bd.c5c7926839ce9dae1f459bd78e95bfb23;
				process.Start();
			}

			// Token: 0x0600091B RID: 2331 RVA: 0x0005E5D4 File Offset: 0x0005C7D4
			internal void c0798ad715914593a3e95d768b1cd8dbc(object cb0d7b0b893a41a39e281ddc32fc698bd, ce91c3ee3b6503970820b59a90b300d72 cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cfe60371517f0baf9152d2203b196e54f.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe.GameProgress);
			}

			// Token: 0x040006AA RID: 1706
			public string c19b7656a3c5703a5e5e43cfd6140a025;

			// Token: 0x040006AB RID: 1707
			public c60797b4f8bfa489df1954dcdc88ad77d cfe60371517f0baf9152d2203b196e54f;
		}
	}
}
