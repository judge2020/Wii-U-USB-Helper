using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace A
{
	// Token: 0x02000029 RID: 41
	public static class cd4880843d42f3dd634ca35c8e909b573
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00009BAC File Offset: 0x00007DAC
		public static int cf79687ad3d8e4d386d79f5d02ba7e00f(int c9d67569497391dd55a54875dcfb8fb1c, int c39a7f585667d01e0c9b43a5fc70a862d)
		{
			if (c9d67569497391dd55a54875dcfb8fb1c % c39a7f585667d01e0c9b43a5fc70a862d != 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd4880843d42f3dd634ca35c8e909b573.cf79687ad3d8e4d386d79f5d02ba7e00f(int, int)).MethodHandle;
				}
				c9d67569497391dd55a54875dcfb8fb1c += c39a7f585667d01e0c9b43a5fc70a862d - c9d67569497391dd55a54875dcfb8fb1c % c39a7f585667d01e0c9b43a5fc70a862d;
			}
			return c9d67569497391dd55a54875dcfb8fb1c;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00009BE0 File Offset: 0x00007DE0
		public static bool c8518de460ad2904ffe3ce945c07d2a14(byte[] c20fab7e86d17e97f35dc746ef5fadd34, byte[] c6f8140eb9b80b7c7ef08f7739ee3e6fc)
		{
			cd4880843d42f3dd634ca35c8e909b573.c22b6038dbdd6ae475329544ff00cef92 c22b6038dbdd6ae475329544ff00cef = new cd4880843d42f3dd634ca35c8e909b573.c22b6038dbdd6ae475329544ff00cef92();
			c22b6038dbdd6ae475329544ff00cef.c6f8140eb9b80b7c7ef08f7739ee3e6fc = c6f8140eb9b80b7c7ef08f7739ee3e6fc;
			if ((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c20fab7e86d17e97f35dc746ef5fadd34) != (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c22b6038dbdd6ae475329544ff00cef.c6f8140eb9b80b7c7ef08f7739ee3e6fc))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(byte[], byte[])).MethodHandle;
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3032) != 0;
			}
			return (c20fab7e86d17e97f35dc746ef5fadd34.Where(new Func<byte, int, bool>(c22b6038dbdd6ae475329544ff00cef.c4dcbb4b8d02ea2bd42c4f85022d1646a)).Any<byte>() ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3036);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00009C58 File Offset: 0x00007E58
		public static bool c11bdf64ad0975b79d5b6ecdc14c43d2b(string ce7d298d73bab0df9bcfdc208996dceec)
		{
			return File.Exists(Path.Combine(Environment.SystemDirectory, ce7d298d73bab0df9bcfdc208996dceec));
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00009C7C File Offset: 0x00007E7C
		public static bool c6addde80fdae96d016a0062f003f210a(string ce7d298d73bab0df9bcfdc208996dceec)
		{
			return File.Exists(Path.Combine(Environment.GetEnvironmentVariable(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3238)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3251), ce7d298d73bab0df9bcfdc208996dceec));
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public static ushort c0dba4641303499c84a0f24e0e2c8c9e2(ushort c9d67569497391dd55a54875dcfb8fb1c)
		{
			return (ushort)IPAddress.HostToNetworkOrder((short)c9d67569497391dd55a54875dcfb8fb1c);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00009CD0 File Offset: 0x00007ED0
		public static uint c0dba4641303499c84a0f24e0e2c8c9e2(uint c9d67569497391dd55a54875dcfb8fb1c)
		{
			return (uint)IPAddress.HostToNetworkOrder((int)c9d67569497391dd55a54875dcfb8fb1c);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public static ulong c0dba4641303499c84a0f24e0e2c8c9e2(ulong c9d67569497391dd55a54875dcfb8fb1c)
		{
			return (ulong)IPAddress.HostToNetworkOrder((long)c9d67569497391dd55a54875dcfb8fb1c);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00009D00 File Offset: 0x00007F00
		internal static byte[] c6507f192257143b77a08ca9528ea8b8c(string cc901f99e7a87dca0f2ac8493fdaccc66)
		{
			int length = cc901f99e7a87dca0f2ac8493fdaccc66.Length;
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(length / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3040));
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3044); i < length; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3060))
			{
				array[i / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3048)] = Convert.ToByte(cc901f99e7a87dca0f2ac8493fdaccc66.Substring(i, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3052)), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3056));
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
			if (!true)
			{
				RuntimeMethodHandle runtimeMethodHandle = methodof(cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(string)).MethodHandle;
			}
			return array;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00009D90 File Offset: 0x00007F90
		public static void c1ed128e8bdc7109d913800afc41fb9f6(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7, string c70f1064222fa2c281974a7b7a2035e61)
		{
			cd4880843d42f3dd634ca35c8e909b573.cfb82f5c3b7143a767d460a75fe3b9785 cfb82f5c3b7143a767d460a75fe3b = new cd4880843d42f3dd634ca35c8e909b573.cfb82f5c3b7143a767d460a75fe3b9785();
			cfb82f5c3b7143a767d460a75fe3b.cbc47e314a0f1d7d5f1d07b50ba2bb8c7 = cbc47e314a0f1d7d5f1d07b50ba2bb8c7;
			cfb82f5c3b7143a767d460a75fe3b.c70f1064222fa2c281974a7b7a2035e61 = c70f1064222fa2c281974a7b7a2035e61;
			string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3268);
			Action c594146923b42642ebf4bf2a5cd = new Action(cfb82f5c3b7143a767d460a75fe3b.c232ec2a596abde5b71918252f2dc8e1a);
			Action<Exception> c62f902d27574ffccbd029fee23622bc;
			if ((c62f902d27574ffccbd029fee23622bc = cd4880843d42f3dd634ca35c8e909b573.<>c.cf5a0480636f167cfae17d2df284f064b) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd4880843d42f3dd634ca35c8e909b573.c1ed128e8bdc7109d913800afc41fb9f6(string, string)).MethodHandle;
				}
				c62f902d27574ffccbd029fee23622bc = (cd4880843d42f3dd634ca35c8e909b573.<>c.cf5a0480636f167cfae17d2df284f064b = new Action<Exception>(cd4880843d42f3dd634ca35c8e909b573.<>c.cdfab1996eb8651828de2a4469aa3481e.c157a16ca6e2810f023ca46a312e0eb0e));
			}
			new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00009E04 File Offset: 0x00008004
		public static byte[] cfd0ad27a03ce2d8cb73f1bd25bc74952(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7)
		{
			cd4880843d42f3dd634ca35c8e909b573.c463401ba90e6893fad21618b6bfb1062 c463401ba90e6893fad21618b6bfb = new cd4880843d42f3dd634ca35c8e909b573.c463401ba90e6893fad21618b6bfb1062();
			c463401ba90e6893fad21618b6bfb.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3329), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3064) != 0);
			WebClient webClient = new WebClient();
			c463401ba90e6893fad21618b6bfb.c9a7c261c312ca4cca339a489147a87a1 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
			webClient.DownloadProgressChanged += c463401ba90e6893fad21618b6bfb.c25ebc6168aea6e6734b21dc1845b78e7;
			webClient.DownloadDataCompleted += c463401ba90e6893fad21618b6bfb.cb25ea9a3872cba9413ea245077b2aae4;
			webClient.DownloadDataAsync(new Uri(cbc47e314a0f1d7d5f1d07b50ba2bb8c7));
			c463401ba90e6893fad21618b6bfb.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
			return c463401ba90e6893fad21618b6bfb.c9a7c261c312ca4cca339a489147a87a1;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00009E8C File Offset: 0x0000808C
		public static void c378cdebefe84e39cd3de9fc6cd731412(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7, string c2e59f973437ea79c9b95a2c0ce2d33db)
		{
			cd4880843d42f3dd634ca35c8e909b573.ccf0f52b59cc8758227224a9a5c9c38a9 ccf0f52b59cc8758227224a9a5c9c38a = new cd4880843d42f3dd634ca35c8e909b573.ccf0f52b59cc8758227224a9a5c9c38a9();
			ccf0f52b59cc8758227224a9a5c9c38a.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3329), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3068) != 0);
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += ccf0f52b59cc8758227224a9a5c9c38a.c5ac3aa98e95b9a66d752b6ea3f177f45;
			webClient.DownloadFileCompleted += ccf0f52b59cc8758227224a9a5c9c38a.c840389edaa96401b6eb7db8d8ba99555;
			webClient.DownloadFileAsync(new Uri(cbc47e314a0f1d7d5f1d07b50ba2bb8c7), c2e59f973437ea79c9b95a2c0ce2d33db);
			ccf0f52b59cc8758227224a9a5c9c38a.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00009F04 File Offset: 0x00008104
		public static void c45cbdcfae4ad6f5a5c450c69a0162043(string c70f1064222fa2c281974a7b7a2035e61)
		{
			cd4880843d42f3dd634ca35c8e909b573.c1ed128e8bdc7109d913800afc41fb9f6(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3436), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1), c70f1064222fa2c281974a7b7a2035e61);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00009F30 File Offset: 0x00008130
		public static void cc9ff642c53c06a69106c76874bd71e34(string c70f1064222fa2c281974a7b7a2035e61)
		{
			cd4880843d42f3dd634ca35c8e909b573.c1ed128e8bdc7109d913800afc41fb9f6(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3491), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1), c70f1064222fa2c281974a7b7a2035e61);
		}

		// Token: 0x020000F7 RID: 247
		[CompilerGenerated]
		private sealed class c22b6038dbdd6ae475329544ff00cef92
		{
			// Token: 0x06000878 RID: 2168 RVA: 0x0005AF08 File Offset: 0x00059108
			internal bool c4dcbb4b8d02ea2bd42c4f85022d1646a(byte c0d301987ae5e67ad4f8ccfb9e2edb469, int cd5961f5606cd76e95b9b6611f7dd165e)
			{
				return ((c0d301987ae5e67ad4f8ccfb9e2edb469 == this.c6f8140eb9b80b7c7ef08f7739ee3e6fc[cd5961f5606cd76e95b9b6611f7dd165e]) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29920);
			}

			// Token: 0x040005F7 RID: 1527
			public byte[] c6f8140eb9b80b7c7ef08f7739ee3e6fc;
		}

		// Token: 0x020000F8 RID: 248
		[CompilerGenerated]
		private sealed class cfb82f5c3b7143a767d460a75fe3b9785
		{
			// Token: 0x0600087A RID: 2170 RVA: 0x0005AF40 File Offset: 0x00059140
			internal void c232ec2a596abde5b71918252f2dc8e1a()
			{
				MemoryStream memoryStream = new MemoryStream(cd4880843d42f3dd634ca35c8e909b573.cfd0ad27a03ce2d8cb73f1bd25bc74952(this.cbc47e314a0f1d7d5f1d07b50ba2bb8c7));
				try
				{
					ZipArchive zipArchive = new ZipArchive(memoryStream);
					try
					{
						zipArchive.c811907eb2abb4733dea06da0e2bcc423(this.c70f1064222fa2c281974a7b7a2035e61, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29924) != 0);
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
							if (!true)
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(cd4880843d42f3dd634ca35c8e909b573.cfb82f5c3b7143a767d460a75fe3b9785.c232ec2a596abde5b71918252f2dc8e1a()).MethodHandle;
							}
							((IDisposable)zipArchive).Dispose();
						}
					}
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

			// Token: 0x040005F8 RID: 1528
			public string cbc47e314a0f1d7d5f1d07b50ba2bb8c7;

			// Token: 0x040005F9 RID: 1529
			public string c70f1064222fa2c281974a7b7a2035e61;
		}

		// Token: 0x020000FA RID: 250
		[CompilerGenerated]
		private sealed class c463401ba90e6893fad21618b6bfb1062
		{
			// Token: 0x0600087F RID: 2175 RVA: 0x0005B038 File Offset: 0x00059238
			internal void c25ebc6168aea6e6734b21dc1845b78e7(object cb0d7b0b893a41a39e281ddc32fc698bd, DownloadProgressChangedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe.ProgressPercentage);
			}

			// Token: 0x06000880 RID: 2176 RVA: 0x0005B058 File Offset: 0x00059258
			internal void cb25ea9a3872cba9413ea245077b2aae4(object cb0d7b0b893a41a39e281ddc32fc698bd, DownloadDataCompletedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.c9a7c261c312ca4cca339a489147a87a1 = cdf15457ee4816989343b6e6e96dd4cfe.Result;
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x040005FC RID: 1532
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;

			// Token: 0x040005FD RID: 1533
			public byte[] c9a7c261c312ca4cca339a489147a87a1;
		}

		// Token: 0x020000FB RID: 251
		[CompilerGenerated]
		private sealed class ccf0f52b59cc8758227224a9a5c9c38a9
		{
			// Token: 0x06000882 RID: 2178 RVA: 0x0005B094 File Offset: 0x00059294
			internal void c5ac3aa98e95b9a66d752b6ea3f177f45(object cb0d7b0b893a41a39e281ddc32fc698bd, DownloadProgressChangedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe.ProgressPercentage);
			}

			// Token: 0x06000883 RID: 2179 RVA: 0x0005B0B4 File Offset: 0x000592B4
			internal void c840389edaa96401b6eb7db8d8ba99555(object cb0d7b0b893a41a39e281ddc32fc698bd, AsyncCompletedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x040005FE RID: 1534
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;
		}
	}
}
