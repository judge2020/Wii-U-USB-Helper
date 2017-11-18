using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A
{
	// Token: 0x02000082 RID: 130
	public static class c67726bc94fb4dd43c5c00e863a4fed19
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0001828C File Offset: 0x0001648C
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x000182A0 File Offset: 0x000164A0
		public static string CachePath { get; private set; }

		// Token: 0x060003AA RID: 938 RVA: 0x000182B4 File Offset: 0x000164B4
		public static void c026aee694fa251c8a3860993dce5e0db(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(c4d6abdac9d3efb16a0adcf6a56cd5ad0))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c67726bc94fb4dd43c5c00e863a4fed19.c026aee694fa251c8a3860993dce5e0db(string)).MethodHandle;
				}
				File.Delete(c4d6abdac9d3efb16a0adcf6a56cd5ad0.c7a31e9c385568f6ebeffa48a4bb5b995());
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000182EC File Offset: 0x000164EC
		public static bool c005d865de5ac02579ca8398dd0288abf(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			return File.Exists(c4d6abdac9d3efb16a0adcf6a56cd5ad0.c7a31e9c385568f6ebeffa48a4bb5b995());
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00018308 File Offset: 0x00016508
		public static byte[] c4c076c3a237621789378691b14b8de64(Uri c878e0ab6d968bb7599d1376f4540b91e, TimeSpan c4d599a5909490aa7a123c02887140b4d)
		{
			byte[] result;
			try
			{
				string text = c878e0ab6d968bb7599d1376f4540b91e.ce20e9414c6ca4f7d08acbf939ab9c4d2().c7a31e9c385568f6ebeffa48a4bb5b995();
				if (!text.cecbc8cc8d63b6ddbce37ff002ecc2d64(c4d599a5909490aa7a123c02887140b4d))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c67726bc94fb4dd43c5c00e863a4fed19.c4c076c3a237621789378691b14b8de64(Uri, TimeSpan)).MethodHandle;
					}
					result = File.ReadAllBytes(text);
				}
				else
				{
					try
					{
						byte[] array = new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c878e0ab6d968bb7599d1376f4540b91e.ToString());
						File.WriteAllBytes(text, array);
						result = array;
					}
					catch
					{
						byte[] array2;
						if (!File.Exists(text))
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
							array2 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
						}
						else
						{
							array2 = File.ReadAllBytes(text);
						}
						result = array2;
					}
				}
			}
			catch
			{
				result = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
			}
			return result;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000183BC File Offset: 0x000165BC
		public static void c38e847351547b2e0fce587bbbe528a52(Uri c878e0ab6d968bb7599d1376f4540b91e, TimeSpan c4d599a5909490aa7a123c02887140b4d, Action<ca4dbe4e221059deb4f3786c044e4860a> cf3dd00ca7428b66c1434cbe365594419)
		{
			c67726bc94fb4dd43c5c00e863a4fed19.c44c7076fe64a192c69cedc04bf1181f0 c44c7076fe64a192c69cedc04bf1181f = new c67726bc94fb4dd43c5c00e863a4fed19.c44c7076fe64a192c69cedc04bf1181f0();
			c44c7076fe64a192c69cedc04bf1181f.c878e0ab6d968bb7599d1376f4540b91e = c878e0ab6d968bb7599d1376f4540b91e;
			c44c7076fe64a192c69cedc04bf1181f.cf3dd00ca7428b66c1434cbe365594419 = cf3dd00ca7428b66c1434cbe365594419;
			c44c7076fe64a192c69cedc04bf1181f.c158ce8059478abee6d499bdc639f98e0 = c44c7076fe64a192c69cedc04bf1181f.c878e0ab6d968bb7599d1376f4540b91e.ce20e9414c6ca4f7d08acbf939ab9c4d2().c7a31e9c385568f6ebeffa48a4bb5b995();
			if (c44c7076fe64a192c69cedc04bf1181f.c158ce8059478abee6d499bdc639f98e0.cecbc8cc8d63b6ddbce37ff002ecc2d64(c4d599a5909490aa7a123c02887140b4d))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c67726bc94fb4dd43c5c00e863a4fed19.c38e847351547b2e0fce587bbbe528a52(Uri, TimeSpan, Action<ca4dbe4e221059deb4f3786c044e4860a>)).MethodHandle;
				}
				Task.Run(new Action(c44c7076fe64a192c69cedc04bf1181f.c24d6e73816a9f9ff2a4e9cd917e02b8b));
				return;
			}
			if (new FileInfo(c44c7076fe64a192c69cedc04bf1181f.c158ce8059478abee6d499bdc639f98e0).Length > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6188))
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
				c44c7076fe64a192c69cedc04bf1181f.cf3dd00ca7428b66c1434cbe365594419(new ca4dbe4e221059deb4f3786c044e4860a(File.ReadAllBytes(c44c7076fe64a192c69cedc04bf1181f.c158ce8059478abee6d499bdc639f98e0), c44c7076fe64a192c69cedc04bf1181f.c158ce8059478abee6d499bdc639f98e0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6192) != 0));
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00018488 File Offset: 0x00016688
		public static byte[] c353a913dc85db968cb2573b633591514(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(c4d6abdac9d3efb16a0adcf6a56cd5ad0))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c67726bc94fb4dd43c5c00e863a4fed19.c353a913dc85db968cb2573b633591514(string)).MethodHandle;
				}
				return File.ReadAllBytes(c4d6abdac9d3efb16a0adcf6a56cd5ad0.c7a31e9c385568f6ebeffa48a4bb5b995());
			}
			return null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000184C4 File Offset: 0x000166C4
		public static byte[] c353a913dc85db968cb2573b633591514(Uri c07967aec6497164d467dc076f097dc53)
		{
			return c67726bc94fb4dd43c5c00e863a4fed19.c353a913dc85db968cb2573b633591514(c07967aec6497164d467dc076f097dc53.ce20e9414c6ca4f7d08acbf939ab9c4d2());
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000184E0 File Offset: 0x000166E0
		public static string[] c8334ccea7202097a0899b9cb1fac251e(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(c4d6abdac9d3efb16a0adcf6a56cd5ad0))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c67726bc94fb4dd43c5c00e863a4fed19.c8334ccea7202097a0899b9cb1fac251e(string)).MethodHandle;
				}
				return File.ReadAllLines(c4d6abdac9d3efb16a0adcf6a56cd5ad0.c7a31e9c385568f6ebeffa48a4bb5b995());
			}
			return null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0001851C File Offset: 0x0001671C
		public static string cd78b75c0acd1a4205371a6b84b5b766a(string cbe300171c6507f5b690a394f92443471)
		{
			return BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.Unicode.GetBytes(cbe300171c6507f5b690a394f92443471))).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9661), "");
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00018568 File Offset: 0x00016768
		public static void cf1655422b15b29ae420a5500448a3df7(Uri c07967aec6497164d467dc076f097dc53, byte[] c271a832e629a79991d9eda7a270cb125)
		{
			File.WriteAllBytes(c07967aec6497164d467dc076f097dc53.ce20e9414c6ca4f7d08acbf939ab9c4d2().c7a31e9c385568f6ebeffa48a4bb5b995(), c271a832e629a79991d9eda7a270cb125);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001858C File Offset: 0x0001678C
		public static void c6be8a9a2e62443fd1e448c28bd8dad3e(string c4d6abdac9d3efb16a0adcf6a56cd5ad0, string[] c53baebb425df32451b0002a8be539d1d)
		{
			File.WriteAllLines(c4d6abdac9d3efb16a0adcf6a56cd5ad0.c7a31e9c385568f6ebeffa48a4bb5b995(), c53baebb425df32451b0002a8be539d1d);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000185A8 File Offset: 0x000167A8
		internal static string c7a31e9c385568f6ebeffa48a4bb5b995(this string c73f1dae9f6f82bed94bc7a9992b25324)
		{
			return c67726bc94fb4dd43c5c00e863a4fed19.cbeff2319e7bc1b72710ece7be344c7c9(c73f1dae9f6f82bed94bc7a9992b25324);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000185C0 File Offset: 0x000167C0
		internal static string c65e5337290a53cf1f002f108c8acc47e(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(c4d6abdac9d3efb16a0adcf6a56cd5ad0))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c67726bc94fb4dd43c5c00e863a4fed19.c65e5337290a53cf1f002f108c8acc47e(string)).MethodHandle;
				}
				return File.ReadAllText(c4d6abdac9d3efb16a0adcf6a56cd5ad0.c7a31e9c385568f6ebeffa48a4bb5b995());
			}
			return null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000185FC File Offset: 0x000167FC
		internal static void c92d03d65be2d0258da80fddaecea1a40(string c57020db068931b2d17397a06bc961256)
		{
			c67726bc94fb4dd43c5c00e863a4fed19.CachePath = c57020db068931b2d17397a06bc961256;
			if (!Directory.Exists(c67726bc94fb4dd43c5c00e863a4fed19.CachePath))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c67726bc94fb4dd43c5c00e863a4fed19.c92d03d65be2d0258da80fddaecea1a40(string)).MethodHandle;
				}
				Directory.CreateDirectory(c67726bc94fb4dd43c5c00e863a4fed19.CachePath);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00018644 File Offset: 0x00016844
		internal static string ce20e9414c6ca4f7d08acbf939ab9c4d2(this Uri c73f1dae9f6f82bed94bc7a9992b25324)
		{
			return c67726bc94fb4dd43c5c00e863a4fed19.cd78b75c0acd1a4205371a6b84b5b766a(c73f1dae9f6f82bed94bc7a9992b25324.AbsoluteUri);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00018660 File Offset: 0x00016860
		private static bool cecbc8cc8d63b6ddbce37ff002ecc2d64(this string c73f1dae9f6f82bed94bc7a9992b25324, TimeSpan c4d599a5909490aa7a123c02887140b4d)
		{
			if (File.Exists(c73f1dae9f6f82bed94bc7a9992b25324))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(string.cecbc8cc8d63b6ddbce37ff002ecc2d64(TimeSpan)).MethodHandle;
				}
				return ca2a06a7bbbf1c79d260cf7606ea77ea5.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(DateTime.Now, new FileInfo(c73f1dae9f6f82bed94bc7a9992b25324).LastWriteTime), c4d599a5909490aa7a123c02887140b4d);
			}
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6196) != 0;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000186B8 File Offset: 0x000168B8
		private static string cbeff2319e7bc1b72710ece7be344c7c9(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			return Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, c4d6abdac9d3efb16a0adcf6a56cd5ad0);
		}

		// Token: 0x0400023E RID: 574
		[CompilerGenerated]
		private static string ca45c421a8790d611d88acb261d78aab7;

		// Token: 0x0200011B RID: 283
		[CompilerGenerated]
		private sealed class c44c7076fe64a192c69cedc04bf1181f0
		{
			// Token: 0x060008C6 RID: 2246 RVA: 0x0005CCA8 File Offset: 0x0005AEA8
			internal void c24d6e73816a9f9ff2a4e9cd917e02b8b()
			{
				c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = new c866035f717c1c145e269422264e8f519();
				try
				{
					byte[] array = c866035f717c1c145e269422264e8f.cd13dfe553208f0b407836d345c6897d0(this.c878e0ab6d968bb7599d1376f4540b91e.ToString());
					File.WriteAllBytes(this.c158ce8059478abee6d499bdc639f98e0, array);
					this.cf3dd00ca7428b66c1434cbe365594419(new ca4dbe4e221059deb4f3786c044e4860a(array, this.c158ce8059478abee6d499bdc639f98e0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30196) != 0));
				}
				catch
				{
					File.Delete(this.c158ce8059478abee6d499bdc639f98e0);
				}
			}

			// Token: 0x0400066B RID: 1643
			public Uri c878e0ab6d968bb7599d1376f4540b91e;

			// Token: 0x0400066C RID: 1644
			public string c158ce8059478abee6d499bdc639f98e0;

			// Token: 0x0400066D RID: 1645
			public Action<ca4dbe4e221059deb4f3786c044e4860a> cf3dd00ca7428b66c1434cbe365594419;
		}
	}
}
