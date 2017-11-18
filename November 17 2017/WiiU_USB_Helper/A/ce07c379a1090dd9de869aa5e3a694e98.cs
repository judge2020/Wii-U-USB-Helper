using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using NusHelper.Server;

namespace A
{
	// Token: 0x02000087 RID: 135
	internal static class ce07c379a1090dd9de869aa5e3a694e98
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00018A00 File Offset: 0x00016C00
		private static string c37c4015a8adb151849e6ce2d2cb00262
		{
			get
			{
				return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9801), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00018A28 File Offset: 0x00016C28
		public static List<cbfa477cacc0f7b226e325a3d45e91591> c2bc36dd5b2f881cf591e4912315784fa()
		{
			List<cbfa477cacc0f7b226e325a3d45e91591> result;
			try
			{
				result = JsonConvert.DeserializeObject<List<cbfa477cacc0f7b226e325a3d45e91591>>(new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9844)));
			}
			catch
			{
				result = new List<cbfa477cacc0f7b226e325a3d45e91591>();
			}
			return result;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00018A74 File Offset: 0x00016C74
		public static long c9ccba43590455ccade6137d4511b2261(string cfe300fe688845689ab9526c0dc53da7e)
		{
			WebRequest webRequest = WebRequest.Create(cfe300fe688845689ab9526c0dc53da7e);
			webRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9933);
			WebResponse response = webRequest.GetResponse();
			long contentLength;
			try
			{
				contentLength = response.ContentLength;
			}
			finally
			{
				if (response != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c9ccba43590455ccade6137d4511b2261(string)).MethodHandle;
					}
					((IDisposable)response).Dispose();
				}
			}
			return contentLength;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00018ADC File Offset: 0x00016CDC
		public static IPAddress c0897719f18e7612f358bd6cef2208dd8(string c255f4caa45f28c011d1f149459a396f4)
		{
			object obj = ce07c379a1090dd9de869aa5e3a694e98.cf3f143059b535e94f871f2bd3a61f33e;
			bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6260) != 0;
			IPAddress result;
			try
			{
				Monitor.Enter(obj, ref flag);
				c255f4caa45f28c011d1f149459a396f4 = c255f4caa45f28c011d1f149459a396f4.ToLower();
				if (!ce07c379a1090dd9de869aa5e3a694e98.c253fabe18cea9b8ad12c502c81d0df76.ContainsKey(c255f4caa45f28c011d1f149459a396f4))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c0897719f18e7612f358bd6cef2208dd8(string)).MethodHandle;
					}
					ce07c379a1090dd9de869aa5e3a694e98.c253fabe18cea9b8ad12c502c81d0df76.Add(c255f4caa45f28c011d1f149459a396f4, IPAddress.Parse(new WebClient().DownloadString(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9942), Convert.ToBase64String(Encoding.UTF8.GetBytes(c255f4caa45f28c011d1f149459a396f4))))));
				}
				result = ce07c379a1090dd9de869aa5e3a694e98.c253fabe18cea9b8ad12c502c81d0df76[c255f4caa45f28c011d1f149459a396f4];
			}
			finally
			{
				if (flag)
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
					Monitor.Exit(obj);
				}
			}
			return result;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00018BAC File Offset: 0x00016DAC
		public static List<string> c0e3f1d536ae7128b270bd0913dbe2faf()
		{
			List<string> result;
			try
			{
				string text = new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10045), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1)).ToUpper();
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6264));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6268)] = Environment.NewLine;
				result = new List<string>(text.Split(array, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6272)));
			}
			catch
			{
				result = new List<string>();
			}
			return result;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00018C3C File Offset: 0x00016E3C
		internal static void ca1590def1ff8bdbed62121a24e1f5074(cf7c96734e58d8de9864e1ea854bc2b7b c6cfe4a6a4a47430d95db2df361685474)
		{
			ce07c379a1090dd9de869aa5e3a694e98.cbb7b853fb2f4a0004e552accbf453dd3 cbb7b853fb2f4a0004e552accbf453dd = new ce07c379a1090dd9de869aa5e3a694e98.cbb7b853fb2f4a0004e552accbf453dd3();
			cbb7b853fb2f4a0004e552accbf453dd.c6cfe4a6a4a47430d95db2df361685474 = c6cfe4a6a4a47430d95db2df361685474;
			if (ce07c379a1090dd9de869aa5e3a694e98.c3cf603f6e81092119821afa424c69f97.Contains(cbb7b853fb2f4a0004e552accbf453dd.c6cfe4a6a4a47430d95db2df361685474.Name))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.ca1590def1ff8bdbed62121a24e1f5074(cf7c96734e58d8de9864e1ea854bc2b7b)).MethodHandle;
				}
				return;
			}
			try
			{
				ce07c379a1090dd9de869aa5e3a694e98.c4b8164c686e3d2f06e9420f9418b8b1f c4b8164c686e3d2f06e9420f9418b8b1f = new ce07c379a1090dd9de869aa5e3a694e98.c4b8164c686e3d2f06e9420f9418b8b1f();
				c4b8164c686e3d2f06e9420f9418b8b1f.c8c38354cddaefb45b9cfcd9ed2838c37 = cbb7b853fb2f4a0004e552accbf453dd;
				c4b8164c686e3d2f06e9420f9418b8b1f.c42063d8f921755d50e79dca93da13b1e = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6276) != 0);
				WebClient webClient = new WebClient();
				webClient.DownloadProgressChanged += c4b8164c686e3d2f06e9420f9418b8b1f.c6f4a396f645a1f28c3c759f5b5894d40;
				webClient.DownloadDataCompleted += c4b8164c686e3d2f06e9420f9418b8b1f.c1b512a1a29b6209d3ed0bd4105efaa1e;
				webClient.DownloadDataAsync(new Uri(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10187), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1, c4b8164c686e3d2f06e9420f9418b8b1f.c8c38354cddaefb45b9cfcd9ed2838c37.c6cfe4a6a4a47430d95db2df361685474.Name)));
				c4b8164c686e3d2f06e9420f9418b8b1f.c42063d8f921755d50e79dca93da13b1e.ShowDialog();
			}
			catch
			{
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00018D34 File Offset: 0x00016F34
		internal static void cfca2dddcfdc97adcbab805e0dc800dec()
		{
			if (cd4880843d42f3dd634ca35c8e909b573.c11bdf64ad0975b79d5b6ecdc14c43d2b(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10238)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.cfca2dddcfdc97adcbab805e0dc800dec()).MethodHandle;
				}
				if (!Environment.Is64BitOperatingSystem)
				{
					return;
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
				if (cd4880843d42f3dd634ca35c8e909b573.c6addde80fdae96d016a0062f003f210a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10238)))
				{
					return;
				}
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			ce07c379a1090dd9de869aa5e3a694e98.c393930c5a0282c2307dadca99f6fd2c7(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10265));
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00018DAC File Offset: 0x00016FAC
		private static void c0054684a527edd6ca0b3d5607f1d05b7(string c32053d44c8d1dcaa73f780b2a239314c)
		{
			try
			{
				if (File.Exists(c32053d44c8d1dcaa73f780b2a239314c))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c0054684a527edd6ca0b3d5607f1d05b7(string)).MethodHandle;
					}
					File.Delete(c32053d44c8d1dcaa73f780b2a239314c);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00018DF4 File Offset: 0x00016FF4
		internal static void cd77410813e3b3b3daf462e4390ee5c85()
		{
			ce07c379a1090dd9de869aa5e3a694e98.cb1fd1979106181e6e3cfcf596976d13e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10294), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10319), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10352));
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00018E2C File Offset: 0x0001702C
		internal static void c393930c5a0282c2307dadca99f6fd2c7(string ce7d298d73bab0df9bcfdc208996dceec)
		{
			ce07c379a1090dd9de869aa5e3a694e98.c1436faa124596e997dd9983c87548548 c1436faa124596e997dd9983c = new ce07c379a1090dd9de869aa5e3a694e98.c1436faa124596e997dd9983c87548548();
			c1436faa124596e997dd9983c.c8edf82fa75ab2f0f09b0f8cb21fde0e1 = Path.Combine(Path.GetTempPath(), ce7d298d73bab0df9bcfdc208996dceec);
			cd4880843d42f3dd634ca35c8e909b573.c378cdebefe84e39cd3de9fc6cd731412(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10385), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1, ce7d298d73bab0df9bcfdc208996dceec), c1436faa124596e997dd9983c.c8edf82fa75ab2f0f09b0f8cb21fde0e1);
			Process process = new Process();
			process.StartInfo.FileName = c1436faa124596e997dd9983c.c8edf82fa75ab2f0f09b0f8cb21fde0e1;
			process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6280) != 0);
			process.StartInfo.UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6284) != 0);
			process.StartInfo.Verb = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10436);
			process.Exited += c1436faa124596e997dd9983c.c0f00a6da5665b5f0901efd68df3c6368;
			process.Start();
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00018EEC File Offset: 0x000170EC
		private static void cb1fd1979106181e6e3cfcf596976d13e(string c291a3113d789da8336fb7ffb2deb53a9, string c6381760d29731fec80abae4a80423fcc, string cddd1324ad1994f29c395a48d2fc8185d)
		{
			if (cd4880843d42f3dd634ca35c8e909b573.c11bdf64ad0975b79d5b6ecdc14c43d2b(c291a3113d789da8336fb7ffb2deb53a9))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.cb1fd1979106181e6e3cfcf596976d13e(string, string, string)).MethodHandle;
				}
				if (!Environment.Is64BitOperatingSystem)
				{
					return;
				}
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (cd4880843d42f3dd634ca35c8e909b573.c6addde80fdae96d016a0062f003f210a(c291a3113d789da8336fb7ffb2deb53a9))
				{
					return;
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
			ce07c379a1090dd9de869aa5e3a694e98.c393930c5a0282c2307dadca99f6fd2c7(c6381760d29731fec80abae4a80423fcc);
			ce07c379a1090dd9de869aa5e3a694e98.c393930c5a0282c2307dadca99f6fd2c7(cddd1324ad1994f29c395a48d2fc8185d);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00018F4C File Offset: 0x0001714C
		internal static void cab8c8e6baeeece0377ea7c17d5d504a0()
		{
			ce07c379a1090dd9de869aa5e3a694e98.cb1fd1979106181e6e3cfcf596976d13e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10447), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10472), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10513));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00018F84 File Offset: 0x00017184
		internal static void cd12bcf8ad68acf6c29b3f1686e86e24f()
		{
			if (!cd4880843d42f3dd634ca35c8e909b573.c11bdf64ad0975b79d5b6ecdc14c43d2b(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10554)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.cd12bcf8ad68acf6c29b3f1686e86e24f()).MethodHandle;
				}
				ce07c379a1090dd9de869aa5e3a694e98.c393930c5a0282c2307dadca99f6fd2c7(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10579));
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00018FCC File Offset: 0x000171CC
		public static string ce211b250ea6ec27024cfcbfb7c26421c()
		{
			return new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10620), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1));
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00019000 File Offset: 0x00017200
		public static string c5dcf0bfbd36c5db7403808eb5e33ce30()
		{
			return new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10671));
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00019028 File Offset: 0x00017228
		public static void cd0aaf0323cfd397657b21a5c8f1b3111()
		{
			if (ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37 == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.cd0aaf0323cfd397657b21a5c8f1b3111()).MethodHandle;
				}
				return;
			}
			ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37.Dispose();
			ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37 = c7a3191126c90592123a88b5ac225d222.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00019064 File Offset: 0x00017264
		private static void c79305a6c079adba5c877ac431eeb119a(MemoryStream cad48e7cec482eb202b35baba9979de2f)
		{
			MemoryStream memoryStream = new MemoryStream();
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				aesCryptoServiceProvider.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6288);
				aesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10788));
				aesCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10817));
				byte[] buffer = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6292));
				int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6296);
				CryptoStream cryptoStream = new CryptoStream(cad48e7cec482eb202b35baba9979de2f, aesCryptoServiceProvider.CreateDecryptor(), (CryptoStreamMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6300));
				try
				{
					do
					{
						num = cryptoStream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6308));
						memoryStream.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6312), num);
					}
					while (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6316));
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c79305a6c079adba5c877ac431eeb119a(MemoryStream)).MethodHandle;
					}
				}
				finally
				{
					if (cryptoStream != null)
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
						((IDisposable)cryptoStream).Dispose();
					}
				}
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
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
					((IDisposable)aesCryptoServiceProvider).Dispose();
				}
			}
			ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37 = new ZipArchive(memoryStream);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000191A8 File Offset: 0x000173A8
		private static void c4674819729e1e8231a0d3c409a154e30(string cc10a16cecb499939161dd5db4430ff77)
		{
			string path = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10848));
			string path2 = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10857));
			byte[] array = new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(ce07c379a1090dd9de869aa5e3a694e98.c37c4015a8adb151849e6ce2d2cb00262);
			MemoryStream memoryStream = new MemoryStream(array);
			try
			{
				ce07c379a1090dd9de869aa5e3a694e98.c79305a6c079adba5c877ac431eeb119a(memoryStream);
			}
			finally
			{
				if (memoryStream != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c4674819729e1e8231a0d3c409a154e30(string)).MethodHandle;
					}
					((IDisposable)memoryStream).Dispose();
				}
			}
			File.WriteAllText(path, cc10a16cecb499939161dd5db4430ff77);
			File.WriteAllBytes(path2, array);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001924C File Offset: 0x0001744C
		private static void c75544c0a507308b75bb7932eb07f7ecb()
		{
			if (ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37 != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c75544c0a507308b75bb7932eb07f7ecb()).MethodHandle;
				}
				return;
			}
			HttpWebRequest httpWebRequest = c306d0f4edb8d9dba0e2099a0ed0662c3.cd24593c859565ebb8c9faabbc5c75bef(WebRequest.Create(ce07c379a1090dd9de869aa5e3a694e98.c37c4015a8adb151849e6ce2d2cb00262));
			string path = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10848));
			string text = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10857));
			httpWebRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9933);
			WebResponse response = httpWebRequest.GetResponse();
			try
			{
				string text2 = response.Headers[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10862)];
				long num = long.Parse(response.Headers[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10871)]);
				if (File.Exists(path))
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
						if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(File.ReadAllText(path), text2))
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
							if (num == new FileInfo(text).Length)
							{
								MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(text));
								try
								{
									ce07c379a1090dd9de869aa5e3a694e98.c79305a6c079adba5c877ac431eeb119a(memoryStream);
									return;
								}
								finally
								{
									if (memoryStream != null)
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
										((IDisposable)memoryStream).Dispose();
									}
								}
								goto IL_15B;
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
						}
						ce07c379a1090dd9de869aa5e3a694e98.c4674819729e1e8231a0d3c409a154e30(text2);
						return;
					}
				}
				IL_15B:
				ce07c379a1090dd9de869aa5e3a694e98.c4674819729e1e8231a0d3c409a154e30(text2);
			}
			finally
			{
				if (response != null)
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
					((IDisposable)response).Dispose();
				}
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000193EC File Offset: 0x000175EC
		private static string c8426f333ff101f4265bb5a3683b78c01(this ZipArchiveEntry c3d57b353c405c58b3e7b1741fb443d42)
		{
			TextReader textReader = new StreamReader(c3d57b353c405c58b3e7b1741fb443d42.Open());
			string result;
			try
			{
				result = textReader.ReadToEnd();
			}
			finally
			{
				if (textReader != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(ZipArchiveEntry.c8426f333ff101f4265bb5a3683b78c01()).MethodHandle;
					}
					((IDisposable)textReader).Dispose();
				}
			}
			return result;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00019440 File Offset: 0x00017640
		public static void c7fa50420699e204537941d08eea98ec4(string ce7d298d73bab0df9bcfdc208996dceec)
		{
			ce07c379a1090dd9de869aa5e3a694e98.c75544c0a507308b75bb7932eb07f7ecb();
			IEnumerator<DbRow> enumerator = JsonConvert.DeserializeObject<IEnumerable<DbRow>>(ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37.GetEntry(ce7d298d73bab0df9bcfdc208996dceec).c8426f333ff101f4265bb5a3683b78c01()).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DbRow dbRow = enumerator.Current;
					if (!c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282.ContainsKey(dbRow.TitleId))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c7fa50420699e204537941d08eea98ec4(string)).MethodHandle;
						}
						c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282.Add(dbRow.TitleId, new cdb02a77cadec7790d5c7c433ab736a12.cfbcf84e3bd62575a5abcb876df342eb4
						{
							c029cb26b0aae604f5c2d4c53cbc49f62 = dbRow.Size,
							cced90bbc7aa0995aa10924a12b207d73 = dbRow.TitleId
						});
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
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001951C File Offset: 0x0001771C
		public static void c140148ec07c360a403ba7395ace7bc19(string ce7d298d73bab0df9bcfdc208996dceec)
		{
			ce07c379a1090dd9de869aa5e3a694e98.c75544c0a507308b75bb7932eb07f7ecb();
			IEnumerable<DbRow> source = JsonConvert.DeserializeObject<IEnumerable<DbRow>>(ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37.GetEntry(ce7d298d73bab0df9bcfdc208996dceec).c8426f333ff101f4265bb5a3683b78c01());
			Func<DbRow, bool> predicate;
			if ((predicate = ce07c379a1090dd9de869aa5e3a694e98.<>c.c176f5d7fe328675eddceaa782418a4e9) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c140148ec07c360a403ba7395ace7bc19(string)).MethodHandle;
				}
				predicate = (ce07c379a1090dd9de869aa5e3a694e98.<>c.c176f5d7fe328675eddceaa782418a4e9 = new Func<DbRow, bool>(ce07c379a1090dd9de869aa5e3a694e98.<>c.cdfab1996eb8651828de2a4469aa3481e.cfc73baf3517d7e85614de5d6ce454e6b));
			}
			IEnumerator<DbRow> enumerator = source.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DbRow dbRow = enumerator.Current;
					c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7.Add(dbRow.TitleId, dbRow);
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
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000195E4 File Offset: 0x000177E4
		public static void c639a106f7d220ed90d0c1210ca33d844()
		{
			string text = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5880));
			if (Directory.Exists(text))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c639a106f7d220ed90d0c1210ca33d844()).MethodHandle;
				}
				return;
			}
			Directory.CreateDirectory(text);
			cd4880843d42f3dd634ca35c8e909b573.c1ed128e8bdc7109d913800afc41fb9f6(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10900), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1), text);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00019654 File Offset: 0x00017854
		public static void c5f35610ada9f2e6fa922772ed7be1a01(string ce7d298d73bab0df9bcfdc208996dceec)
		{
			ce07c379a1090dd9de869aa5e3a694e98.c75544c0a507308b75bb7932eb07f7ecb();
			IEnumerator<DbRow> enumerator = JsonConvert.DeserializeObject<IEnumerable<DbRow>>(ce07c379a1090dd9de869aa5e3a694e98.c31c1cc86ca59db88cf81b855c1264d37.GetEntry(ce7d298d73bab0df9bcfdc208996dceec).c8426f333ff101f4265bb5a3683b78c01()).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DbRow dbRow = enumerator.Current;
					if (!c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.ContainsKey(dbRow.TitleId))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c5f35610ada9f2e6fa922772ed7be1a01(string)).MethodHandle;
						}
						c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.Add(dbRow.TitleId, new List<cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e>());
					}
					c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea[dbRow.TitleId].Add(new cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e
					{
						c029cb26b0aae604f5c2d4c53cbc49f62 = dbRow.Size,
						cced90bbc7aa0995aa10924a12b207d73 = dbRow.TitleId,
						c0b9a995f9c2313cad22315173d49b769 = dbRow.Version
					});
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
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00019764 File Offset: 0x00017964
		public static string[] c14433fd00664056e4068455a5dbab2a4()
		{
			string text = new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10941), ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1));
			string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6320));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6324)] = Environment.NewLine;
			return text.Split(array, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6328));
		}

		// Token: 0x04000253 RID: 595
		private static readonly List<string> c3cf603f6e81092119821afa424c69f97 = new List<string>();

		// Token: 0x04000254 RID: 596
		private static ZipArchive c31c1cc86ca59db88cf81b855c1264d37;

		// Token: 0x04000255 RID: 597
		internal static string cb738a85c88d0291dd4f7bfc618a306e1;

		// Token: 0x04000256 RID: 598
		private static Dictionary<string, IPAddress> c253fabe18cea9b8ad12c502c81d0df76 = new Dictionary<string, IPAddress>();

		// Token: 0x04000257 RID: 599
		private static object cf3f143059b535e94f871f2bd3a61f33e = new object();

		// Token: 0x0200011C RID: 284
		[CompilerGenerated]
		private sealed class c4b8164c686e3d2f06e9420f9418b8b1f
		{
			// Token: 0x060008C8 RID: 2248 RVA: 0x0005CD34 File Offset: 0x0005AF34
			internal void c6f4a396f645a1f28c3c759f5b5894d40(object cb0d7b0b893a41a39e281ddc32fc698bd, DownloadProgressChangedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.c42063d8f921755d50e79dca93da13b1e.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe.ProgressPercentage);
			}

			// Token: 0x060008C9 RID: 2249 RVA: 0x0005CD54 File Offset: 0x0005AF54
			internal void c1b512a1a29b6209d3ed0bd4105efaa1e(object cb0d7b0b893a41a39e281ddc32fc698bd, DownloadDataCompletedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				MemoryStream memoryStream = new MemoryStream(cdf15457ee4816989343b6e6e96dd4cfe.Result);
				try
				{
					string cbc2836ea62c32bc8df1f63f72af3a = this.c8c38354cddaefb45b9cfcd9ed2838c37.c6cfe4a6a4a47430d95db2df361685474.cbc2836ea62c32bc8df1f63f72af3a491;
					ZipArchive zipArchive = new ZipArchive(memoryStream);
					try
					{
						zipArchive.c811907eb2abb4733dea06da0e2bcc423(cbc2836ea62c32bc8df1f63f72af3a, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30200) != 0);
					}
					finally
					{
						if (zipArchive != null)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(ce07c379a1090dd9de869aa5e3a694e98.c4b8164c686e3d2f06e9420f9418b8b1f.c1b512a1a29b6209d3ed0bd4105efaa1e(object, DownloadDataCompletedEventArgs)).MethodHandle;
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
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						((IDisposable)memoryStream).Dispose();
					}
				}
				ce07c379a1090dd9de869aa5e3a694e98.c3cf603f6e81092119821afa424c69f97.Add(this.c8c38354cddaefb45b9cfcd9ed2838c37.c6cfe4a6a4a47430d95db2df361685474.Name);
				this.c42063d8f921755d50e79dca93da13b1e.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x0400066E RID: 1646
			public c60797b4f8bfa489df1954dcdc88ad77d c42063d8f921755d50e79dca93da13b1e;

			// Token: 0x0400066F RID: 1647
			public ce07c379a1090dd9de869aa5e3a694e98.cbb7b853fb2f4a0004e552accbf453dd3 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x0200011D RID: 285
		[CompilerGenerated]
		private sealed class cbb7b853fb2f4a0004e552accbf453dd3
		{
			// Token: 0x04000670 RID: 1648
			public cf7c96734e58d8de9864e1ea854bc2b7b c6cfe4a6a4a47430d95db2df361685474;
		}

		// Token: 0x0200011E RID: 286
		[CompilerGenerated]
		private sealed class c1436faa124596e997dd9983c87548548
		{
			// Token: 0x060008CC RID: 2252 RVA: 0x0005CE38 File Offset: 0x0005B038
			internal void c0f00a6da5665b5f0901efd68df3c6368(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				ce07c379a1090dd9de869aa5e3a694e98.c0054684a527edd6ca0b3d5607f1d05b7(this.c8edf82fa75ab2f0f09b0f8cb21fde0e1);
			}

			// Token: 0x04000671 RID: 1649
			public string c8edf82fa75ab2f0f09b0f8cb21fde0e1;
		}
	}
}
