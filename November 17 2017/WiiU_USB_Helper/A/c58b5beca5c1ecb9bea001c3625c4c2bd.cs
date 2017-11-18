using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace A
{
	// Token: 0x020000B0 RID: 176
	public class c58b5beca5c1ecb9bea001c3625c4c2bd
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x00028960 File Offset: 0x00026B60
		public c58b5beca5c1ecb9bea001c3625c4c2bd(ManagementObject cad48e7cec482eb202b35baba9979de2f)
		{
			this.c0b4ef23aff0cc4347f56b6a7c8d5ee1b = cad48e7cec482eb202b35baba9979de2f;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0002897C File Offset: 0x00026B7C
		public ulong c101c28c2d54da703ed80188aa973633a
		{
			get
			{
				return ulong.Parse(this.c0b4ef23aff0cc4347f56b6a7c8d5ee1b.Properties[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45445)].Value.ToString());
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000289C0 File Offset: 0x00026BC0
		public bool cd39272962c3838d12a48d26d68d98062
		{
			get
			{
				if (File.Exists(this.c9fe4d48be834ba1f9472187325d01f77))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c58b5beca5c1ecb9bea001c3625c4c2bd.get_cd39272962c3838d12a48d26d68d98062()).MethodHandle;
					}
					return File.Exists(this.c2f2af28e5c1902dc6b6f7e30212ddc16);
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11352) != 0;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00028A0C File Offset: 0x00026C0C
		public string c23f0837a5deedf1e034031b99889e0e9
		{
			get
			{
				return this.c0b4ef23aff0cc4347f56b6a7c8d5ee1b.Properties[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45454)].Value.ToString();
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00028A48 File Offset: 0x00026C48
		public string c9fe4d48be834ba1f9472187325d01f77
		{
			get
			{
				return Path.Combine(this.ceab5b7abb10583fc226e8459ce78bc86, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41926));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00028A70 File Offset: 0x00026C70
		public string c9e49e5c969ad906ec9672089eb81eca9
		{
			get
			{
				return this.c0b4ef23aff0cc4347f56b6a7c8d5ee1b.Properties[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45463)].Value.ToString();
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00028AAC File Offset: 0x00026CAC
		public string c2f2af28e5c1902dc6b6f7e30212ddc16
		{
			get
			{
				return Path.Combine(this.ceab5b7abb10583fc226e8459ce78bc86, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41941));
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00028AD4 File Offset: 0x00026CD4
		public byte[] c91169e1269bf69984f9ccbbc2c3515b9()
		{
			if (!this.cd39272962c3838d12a48d26d68d98062)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c58b5beca5c1ecb9bea001c3625c4c2bd.c91169e1269bf69984f9ccbbc2c3515b9()).MethodHandle;
				}
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45486));
			}
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11356));
			Buffer.BlockCopy(File.ReadAllBytes(this.c9fe4d48be834ba1f9472187325d01f77), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11360), array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11364), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11368));
			byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11372));
			Buffer.BlockCopy(File.ReadAllBytes(this.c2f2af28e5c1902dc6b6f7e30212ddc16), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11376), array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11380), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11384));
			byte[] result = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				aesCryptoServiceProvider.Key = array;
				aesCryptoServiceProvider.IV = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11388));
				aesCryptoServiceProvider.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11392);
				aesCryptoServiceProvider.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11396);
				ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor();
				try
				{
					result = cryptoTransform.TransformFinalBlock(array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11400), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11404));
				}
				finally
				{
					if (cryptoTransform != null)
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
						cryptoTransform.Dispose();
					}
				}
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

		// Token: 0x060005E4 RID: 1508 RVA: 0x00028C58 File Offset: 0x00026E58
		public void c3fddf291e4b6c2a03d7ebf77941879b5(string c1139a34319f573b5050d06fd97623321, string ce70d2a20eb8d02825563339fb4666754 = null)
		{
			c58b5beca5c1ecb9bea001c3625c4c2bd.c5521a6488a1b70c9643dc86280039da2 c5521a6488a1b70c9643dc86280039da = new c58b5beca5c1ecb9bea001c3625c4c2bd.c5521a6488a1b70c9643dc86280039da2();
			File.WriteAllBytes(c58b5beca5c1ecb9bea001c3625c4c2bd.ce5995ecb319e817983162ce09707a889, c6faa5467be1a4874657b372a49b7c927.wfsdump);
			c5521a6488a1b70c9643dc86280039da.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45529), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11408) != 0);
			Process process = new Process();
			Process process2 = process;
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = c58b5beca5c1ecb9bea001c3625c4c2bd.ce5995ecb319e817983162ce09707a889;
			processStartInfo.UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11412) != 0);
			ProcessStartInfo processStartInfo2 = processStartInfo;
			string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45598);
			object[] array = c03afd7759879ce2659a1d311b66f5509.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11416));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11420)] = this.c23f0837a5deedf1e034031b99889e0e9;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11424)] = c1139a34319f573b5050d06fd97623321;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11428)] = this.c9fe4d48be834ba1f9472187325d01f77;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11432)] = this.c2f2af28e5c1902dc6b6f7e30212ddc16;
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11436);
			object obj;
			if (ce70d2a20eb8d02825563339fb4666754 == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c58b5beca5c1ecb9bea001c3625c4c2bd.c3fddf291e4b6c2a03d7ebf77941879b5(string, string)).MethodHandle;
				}
				obj = "";
			}
			else
			{
				obj = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45715), ce70d2a20eb8d02825563339fb4666754);
			}
			array[num] = obj;
			processStartInfo2.Arguments = string.Format(format, array);
			processStartInfo.Verb = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10436);
			processStartInfo.CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11440) != 0);
			processStartInfo.WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11444);
			process2.StartInfo = processStartInfo;
			Process process3 = process;
			process3.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11448) != 0);
			process3.Exited += c5521a6488a1b70c9643dc86280039da.c67701db9b8e1edb3e3dcf7ac9c306efc;
			try
			{
				process3.Start();
				c5521a6488a1b70c9643dc86280039da.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
			}
			catch
			{
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00028E04 File Offset: 0x00027004
		public void cf75119406f595a9c0c866f4d485a223d(byte[] c90a182aae2aef766c80448bfcb86b5fd, byte[] cfc6093d20f784def22b47f630e65b053)
		{
			Directory.CreateDirectory(this.ceab5b7abb10583fc226e8459ce78bc86);
			File.WriteAllBytes(this.c9fe4d48be834ba1f9472187325d01f77, c90a182aae2aef766c80448bfcb86b5fd);
			File.WriteAllBytes(this.c2f2af28e5c1902dc6b6f7e30212ddc16, cfc6093d20f784def22b47f630e65b053);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00028E40 File Offset: 0x00027040
		public void c1fa9a501f0fdd231f7052d7b9291f9dc()
		{
			this.c026aee694fa251c8a3860993dce5e0db(this.c9fe4d48be834ba1f9472187325d01f77);
			this.c026aee694fa251c8a3860993dce5e0db(this.c2f2af28e5c1902dc6b6f7e30212ddc16);
			try
			{
				Directory.Delete(this.ceab5b7abb10583fc226e8459ce78bc86, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11452) != 0);
			}
			catch
			{
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00028E98 File Offset: 0x00027098
		private static string ce5995ecb319e817983162ce09707a889
		{
			get
			{
				return Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45740));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00028EC0 File Offset: 0x000270C0
		private string ceab5b7abb10583fc226e8459ce78bc86
		{
			get
			{
				return Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, this.ce20e9414c6ca4f7d08acbf939ab9c4d2);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00028EE4 File Offset: 0x000270E4
		private string ce20e9414c6ca4f7d08acbf939ab9c4d2
		{
			get
			{
				return c67726bc94fb4dd43c5c00e863a4fed19.cd78b75c0acd1a4205371a6b84b5b766a(this.c9e49e5c969ad906ec9672089eb81eca9);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00028F00 File Offset: 0x00027100
		private void c026aee694fa251c8a3860993dce5e0db(string c32053d44c8d1dcaa73f780b2a239314c)
		{
			if (File.Exists(c32053d44c8d1dcaa73f780b2a239314c))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c58b5beca5c1ecb9bea001c3625c4c2bd.c026aee694fa251c8a3860993dce5e0db(string)).MethodHandle;
				}
				File.Delete(c32053d44c8d1dcaa73f780b2a239314c);
			}
		}

		// Token: 0x04000328 RID: 808
		private readonly ManagementObject c0b4ef23aff0cc4347f56b6a7c8d5ee1b;

		// Token: 0x02000148 RID: 328
		[CompilerGenerated]
		private sealed class c5521a6488a1b70c9643dc86280039da2
		{
			// Token: 0x06000962 RID: 2402 RVA: 0x0005F8E8 File Offset: 0x0005DAE8
			internal void c67701db9b8e1edb3e3dcf7ac9c306efc(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x040006F2 RID: 1778
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;
		}
	}
}
