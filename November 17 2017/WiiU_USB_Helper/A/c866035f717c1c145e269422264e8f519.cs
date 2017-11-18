using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using NusHelper;

namespace A
{
	// Token: 0x02000064 RID: 100
	public sealed class c866035f717c1c145e269422264e8f519
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x000105A0 File Offset: 0x0000E7A0
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x000105B4 File Offset: 0x0000E7B4
		public c8d217bce073ddc882212f4d0e016403a DownloadSpeed { get; private set; } = new c8d217bce073ddc882212f4d0e016403a((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4176)));

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x000105C8 File Offset: 0x0000E7C8
		// (set) Token: 0x060002BA RID: 698 RVA: 0x000105DC File Offset: 0x0000E7DC
		public Exception LastError { get; private set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002BB RID: 699 RVA: 0x000105F0 File Offset: 0x0000E7F0
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00010604 File Offset: 0x0000E804
		public ulong MaximumSpeed { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00010618 File Offset: 0x0000E818
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0001062C File Offset: 0x0000E82C
		public DataSize TotalDataDownloaded { get; set; } = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4180)));

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00010640 File Offset: 0x0000E840
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00010654 File Offset: 0x0000E854
		public DataSize TotalDownloadedCurrentGame { get; set; } = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4184)));

		// Token: 0x060002C1 RID: 705 RVA: 0x00010668 File Offset: 0x0000E868
		public void c6df10fc1a659b98aae79de69cd590bc0()
		{
			this.c7a9bdfb9a734963885e9cb6d7f3ce1cb = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3940) != 0);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00010688 File Offset: 0x0000E888
		public void cb54d43ee5504749c66adaebe67c46d9a()
		{
			this.TotalDataDownloaded = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3944)));
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000106AC File Offset: 0x0000E8AC
		public byte[] cd13dfe553208f0b407836d345c6897d0(string c80cb7b5c7ed3120dee341dfb2dca6ee0)
		{
			HttpWebRequest httpWebRequest = c866035f717c1c145e269422264e8f519.c8257b06554692528e80f1d91f9c4d7b0(c80cb7b5c7ed3120dee341dfb2dca6ee0);
			if (this.c00dacc5708b46f842a758e6902713b32)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.cd13dfe553208f0b407836d345c6897d0(string)).MethodHandle;
				}
				httpWebRequest.Accept = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6540);
			}
			httpWebRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1298);
			this.c7a9bdfb9a734963885e9cb6d7f3ce1cb = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3948) != 0);
			httpWebRequest.Timeout = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3952);
			WebResponse response = httpWebRequest.GetResponse();
			byte[] result;
			try
			{
				Stream responseStream = response.GetResponseStream();
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					try
					{
						int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3956);
						do
						{
							byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3960));
							num = responseStream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3964), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
							memoryStream.Write(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3968), num);
							if (!this.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
							{
								goto IL_101;
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
						while (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3972));
						for (;;)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						IL_101:
						memoryStream.Flush();
						result = memoryStream.ToArray();
					}
					finally
					{
						if (memoryStream != null)
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
							((IDisposable)memoryStream).Dispose();
						}
					}
				}
				finally
				{
					if (responseStream != null)
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
						((IDisposable)responseStream).Dispose();
					}
				}
			}
			finally
			{
				if (response != null)
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
					((IDisposable)response).Dispose();
				}
			}
			return result;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00010834 File Offset: 0x0000EA34
		public byte[] ce6c42f61b99e68e887c5144af04cb04e(string c80cb7b5c7ed3120dee341dfb2dca6ee0)
		{
			return this.cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6573), Convert.ToBase64String(Encoding.UTF8.GetBytes(c80cb7b5c7ed3120dee341dfb2dca6ee0))));
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00010874 File Offset: 0x0000EA74
		public byte[] cf974603cc086c68eafb242ca5199a108(string c80cb7b5c7ed3120dee341dfb2dca6ee0)
		{
			string c4d6abdac9d3efb16a0adcf6a56cd5ad = c67726bc94fb4dd43c5c00e863a4fed19.cd78b75c0acd1a4205371a6b84b5b766a(c80cb7b5c7ed3120dee341dfb2dca6ee0);
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(c4d6abdac9d3efb16a0adcf6a56cd5ad))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.cf974603cc086c68eafb242ca5199a108(string)).MethodHandle;
				}
				byte[] c6f8140eb9b80b7c7ef08f7739ee3e6fc = new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6678), Convert.ToBase64String(Encoding.UTF8.GetBytes(c80cb7b5c7ed3120dee341dfb2dca6ee0))));
				MD5 md = MD5.Create();
				try
				{
					byte[] array = c67726bc94fb4dd43c5c00e863a4fed19.c353a913dc85db968cb2573b633591514(c4d6abdac9d3efb16a0adcf6a56cd5ad);
					if (cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(md.ComputeHash(array), c6f8140eb9b80b7c7ef08f7739ee3e6fc))
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
						return array;
					}
				}
				finally
				{
					if (md != null)
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
						((IDisposable)md).Dispose();
					}
				}
			}
			MemoryStream memoryStream = new MemoryStream(this.cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6773), Convert.ToBase64String(Encoding.UTF8.GetBytes(c80cb7b5c7ed3120dee341dfb2dca6ee0)))));
			byte[] result;
			try
			{
				ZipArchive zipArchive = new ZipArchive(memoryStream);
				try
				{
					ZipArchiveEntry entry = zipArchive.GetEntry(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6884));
					byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)(checked((IntPtr)entry.Length)));
					Stream stream = entry.Open();
					try
					{
						stream.Read(array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3976), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array2));
					}
					finally
					{
						if (stream != null)
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
							((IDisposable)stream).Dispose();
						}
					}
					c67726bc94fb4dd43c5c00e863a4fed19.cf1655422b15b29ae420a5500448a3df7(new Uri(c80cb7b5c7ed3120dee341dfb2dca6ee0), array2);
					result = array2;
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
				if (memoryStream != null)
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
					((IDisposable)memoryStream).Dispose();
				}
			}
			return result;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00010A4C File Offset: 0x0000EC4C
		public void c0ddecd1ce433b283de66e0c68db8aa47(string c80cb7b5c7ed3120dee341dfb2dca6ee0, string c970b31fe4f307e557ac948e45eecc894, ulong c44c933e43e1bdf07c304e84bb03e905d, c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b c07c3565a571a5c9a77b8a9011194fe31, WebProxy ce24dc441194d5a798fa9060d2dbb280f, byte[] c0412f9309baf06438554911feccbba06 = null, byte[] cf3e794b4e35654543c0dcab929fac071 = null, byte c80f81f5bbd2eba3291ab3323340a6287 = 0, long c9874e40afecbf8775b45b3f3741f8deb = 0L)
		{
			c866035f717c1c145e269422264e8f519.c27ba0872d93f343523745dd284ce14d1 c27ba0872d93f343523745dd284ce14d = new c866035f717c1c145e269422264e8f519.c27ba0872d93f343523745dd284ce14d1();
			c27ba0872d93f343523745dd284ce14d.c4404a159870bf55bb6f111e66e59e82d = this;
			c27ba0872d93f343523745dd284ce14d.c9874e40afecbf8775b45b3f3741f8deb = c9874e40afecbf8775b45b3f3741f8deb;
			c27ba0872d93f343523745dd284ce14d.c0412f9309baf06438554911feccbba06 = c0412f9309baf06438554911feccbba06;
			c27ba0872d93f343523745dd284ce14d.cf3e794b4e35654543c0dcab929fac071 = cf3e794b4e35654543c0dcab929fac071;
			c27ba0872d93f343523745dd284ce14d.c80f81f5bbd2eba3291ab3323340a6287 = c80f81f5bbd2eba3291ab3323340a6287;
			c27ba0872d93f343523745dd284ce14d.c80cb7b5c7ed3120dee341dfb2dca6ee0 = c80cb7b5c7ed3120dee341dfb2dca6ee0;
			c27ba0872d93f343523745dd284ce14d.ce24dc441194d5a798fa9060d2dbb280f = ce24dc441194d5a798fa9060d2dbb280f;
			if (c07c3565a571a5c9a77b8a9011194fe31 == (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3980))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.c0ddecd1ce433b283de66e0c68db8aa47(string, string, ulong, c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b, WebProxy, byte[], byte[], byte, long)).MethodHandle;
				}
				c44c933e43e1bdf07c304e84bb03e905d = c44c933e43e1bdf07c304e84bb03e905d / (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3984)) * (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3988));
			}
			this.c7a9bdfb9a734963885e9cb6d7f3ce1cb = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3992) != 0);
			this.DownloadSpeed = new c8d217bce073ddc882212f4d0e016403a((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3996)));
			this.TotalDataDownloaded = c2b143215f0b748bfd5403c104882d48e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.TotalDataDownloaded, new DataSize(c44c933e43e1bdf07c304e84bb03e905d));
			this.TotalDownloadedCurrentGame = c2b143215f0b748bfd5403c104882d48e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.TotalDownloadedCurrentGame, new DataSize(c44c933e43e1bdf07c304e84bb03e905d));
			this.ca1f98284d85db4b6387638f9475ca34c = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4000)));
			this.cfbecb9d15eb2e0206d3429f99ccec846 = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4004));
			this.c69e81bd914d6b7f88cb547858adadac1 = new DateTime((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4008));
			c27ba0872d93f343523745dd284ce14d.c040c3a040dd73963402cce104c47ba6e = (long)c44c933e43e1bdf07c304e84bb03e905d;
			if (c6a5e9b85d86b4e098a511017a1073d71.c4e279d2507652407e1d6d8d867af8361)
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
				if (c44c933e43e1bdf07c304e84bb03e905d == 0UL)
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
					if (c07c3565a571a5c9a77b8a9011194fe31 == (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4012))
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
						if (c27ba0872d93f343523745dd284ce14d.c9874e40afecbf8775b45b3f3741f8deb > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4016))
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
							c866035f717c1c145e269422264e8f519.cb5f1d6f94f6048e9767f280fca8c3c65 cb5f1d6f94f6048e9767f280fca8c3c = new c866035f717c1c145e269422264e8f519.cb5f1d6f94f6048e9767f280fca8c3c65();
							cb5f1d6f94f6048e9767f280fca8c3c.c8c38354cddaefb45b9cfcd9ed2838c37 = c27ba0872d93f343523745dd284ce14d;
							int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4020);
							List<Thread> list = new List<Thread>();
							long num2 = cb5f1d6f94f6048e9767f280fca8c3c.c8c38354cddaefb45b9cfcd9ed2838c37.c9874e40afecbf8775b45b3f3741f8deb / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4024);
							if (num2 < (long)num)
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
								num = (int)num2;
							}
							long num3 = num2 / (long)num;
							if (File.Exists(c970b31fe4f307e557ac948e45eecc894))
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
								File.Delete(c970b31fe4f307e557ac948e45eecc894);
							}
							cb5f1d6f94f6048e9767f280fca8c3c.c7a4e30c89f71c54e2739ec9bd70c5e17 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4028) != 0);
							c866035f717c1c145e269422264e8f519.cdffd9d0ad667de618f76351a3e788bc8 cdffd9d0ad667de618f76351a3e788bc = new c866035f717c1c145e269422264e8f519.cdffd9d0ad667de618f76351a3e788bc8();
							cdffd9d0ad667de618f76351a3e788bc.c9def284befdb85aa51808c134f9b5700 = cb5f1d6f94f6048e9767f280fca8c3c;
							cdffd9d0ad667de618f76351a3e788bc.c32053d44c8d1dcaa73f780b2a239314c = File.Create(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c970b31fe4f307e557ac948e45eecc894, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6899)), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4032));
							try
							{
								for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4036); i < num; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4052))
								{
									c866035f717c1c145e269422264e8f519.cdf5601963cd46c84f5f35898b2b6ba9f cdf5601963cd46c84f5f35898b2b6ba9f = new c866035f717c1c145e269422264e8f519.cdf5601963cd46c84f5f35898b2b6ba9f();
									cdf5601963cd46c84f5f35898b2b6ba9f.c248e670c92c8bf286ec14bc40a071437 = cdffd9d0ad667de618f76351a3e788bc;
									cdf5601963cd46c84f5f35898b2b6ba9f.cf5f63a1d2bd272cd393bf389d6f7bc6c = num3;
									if (i == num - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4040))
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
										cdf5601963cd46c84f5f35898b2b6ba9f.cf5f63a1d2bd272cd393bf389d6f7bc6c += num2 % num3;
									}
									cdf5601963cd46c84f5f35898b2b6ba9f.c4f37c170b0d73977de6e507efa87aef0 = num3 * (long)i * (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4044);
									cdf5601963cd46c84f5f35898b2b6ba9f.c7ea27eb926fc7ae0def28ee0acc0925f = (int)num3 * i;
									if (cdf5601963cd46c84f5f35898b2b6ba9f.c4f37c170b0d73977de6e507efa87aef0 > cdf5601963cd46c84f5f35898b2b6ba9f.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c9874e40afecbf8775b45b3f3741f8deb)
									{
										IL_387:
										using (List<Thread>.Enumerator enumerator = list.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												Thread thread = enumerator.Current;
												thread.Start();
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
										using (List<Thread>.Enumerator enumerator = list.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												Thread thread2 = enumerator.Current;
												thread2.Join();
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
										if (cdffd9d0ad667de618f76351a3e788bc.c32053d44c8d1dcaa73f780b2a239314c.Length != cdffd9d0ad667de618f76351a3e788bc.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c9874e40afecbf8775b45b3f3741f8deb)
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
											cdffd9d0ad667de618f76351a3e788bc.c9def284befdb85aa51808c134f9b5700.c7a4e30c89f71c54e2739ec9bd70c5e17 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4056) != 0);
										}
										goto IL_468;
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
									cdf5601963cd46c84f5f35898b2b6ba9f.cff295fe6eeed6a9aa8184e6d752caccd = WebRequest.CreateHttp(cdf5601963cd46c84f5f35898b2b6ba9f.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c80cb7b5c7ed3120dee341dfb2dca6ee0);
									cdf5601963cd46c84f5f35898b2b6ba9f.cff295fe6eeed6a9aa8184e6d752caccd.AddRange(cdf5601963cd46c84f5f35898b2b6ba9f.c4f37c170b0d73977de6e507efa87aef0);
									cdf5601963cd46c84f5f35898b2b6ba9f.cff295fe6eeed6a9aa8184e6d752caccd.Proxy = cdf5601963cd46c84f5f35898b2b6ba9f.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.ce24dc441194d5a798fa9060d2dbb280f;
									Thread item = new Thread(new ThreadStart(cdf5601963cd46c84f5f35898b2b6ba9f.ca75f7dd8ef8c8e9938b5b8413a7e2024))
									{
										IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4048) != 0)
									};
									list.Add(item);
								}
								for (;;)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									goto IL_387;
								}
							}
							finally
							{
								if (cdffd9d0ad667de618f76351a3e788bc.c32053d44c8d1dcaa73f780b2a239314c != null)
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
									((IDisposable)cdffd9d0ad667de618f76351a3e788bc.c32053d44c8d1dcaa73f780b2a239314c).Dispose();
								}
							}
							IL_468:
							if (!this.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
							if (!cb5f1d6f94f6048e9767f280fca8c3c.c7a4e30c89f71c54e2739ec9bd70c5e17)
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
								File.Move(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c970b31fe4f307e557ac948e45eecc894, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6899)), c970b31fe4f307e557ac948e45eecc894);
								return;
							}
							return;
						}
					}
				}
			}
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(c27ba0872d93f343523745dd284ce14d.c80cb7b5c7ed3120dee341dfb2dca6ee0);
			httpWebRequest.Proxy = c27ba0872d93f343523745dd284ce14d.ce24dc441194d5a798fa9060d2dbb280f;
			httpWebRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1298);
			httpWebRequest.AddRange((long)c44c933e43e1bdf07c304e84bb03e905d);
			httpWebRequest.Timeout = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4060);
			httpWebRequest.ReadWriteTimeout = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4064);
			int num4 = (int)(c44c933e43e1bdf07c304e84bb03e905d / (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4068)));
			WebResponse response = httpWebRequest.GetResponse();
			try
			{
				c866035f717c1c145e269422264e8f519.cfd2fc94585e13e556b13d7ba10b89029 cfd2fc94585e13e556b13d7ba10b = new c866035f717c1c145e269422264e8f519.cfd2fc94585e13e556b13d7ba10b89029();
				cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d = c27ba0872d93f343523745dd284ce14d;
				cfd2fc94585e13e556b13d7ba10b.c565daece2dc931752577548359a0df1f = response.ContentLength + (long)c44c933e43e1bdf07c304e84bb03e905d;
				cb83d7b9bc2570649b0e380bddf8cf193 cb83d7b9bc2570649b0e380bddf8cf = new cb83d7b9bc2570649b0e380bddf8cf193(response.GetResponseStream());
				try
				{
					int num5;
					if (!c6a5e9b85d86b4e098a511017a1073d71.cd97926c82fa3cae54a0afb338e5ca487)
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
						num5 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4072);
					}
					else
					{
						num5 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4076);
					}
					int bufferSize = num5;
					FileStream fileStream = new FileStream(c970b31fe4f307e557ac948e45eecc894, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4080), (FileAccess)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4084), (FileShare)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4088), bufferSize);
					try
					{
						fileStream.Seek((long)c44c933e43e1bdf07c304e84bb03e905d, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4092));
						while (this.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
							if (cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d.c040c3a040dd73963402cce104c47ba6e >= cfd2fc94585e13e556b13d7ba10b.c565daece2dc931752577548359a0df1f)
							{
								for (;;)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									goto IL_7B2;
								}
							}
							else
							{
								byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4096));
								cb83d7b9bc2570649b0e380bddf8cf.cbb05c341b78362a11ddbebf38c4ef001 = (long)this.MaximumSpeed;
								long num6 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4100);
								if (c07c3565a571a5c9a77b8a9011194fe31 == (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4104))
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
									Stream c73f1dae9f6f82bed94bc7a9992b = cb83d7b9bc2570649b0e380bddf8cf;
									int cc076fd568f4bb05b6e433b9eb4ab0a = (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array);
									Action<int> cbdc7cc0d6622352a1f9b4e17711e1ff;
									if ((cbdc7cc0d6622352a1f9b4e17711e1ff = cfd2fc94585e13e556b13d7ba10b.c07d96df25e149ee1b99babd4357e18e6) == null)
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
										cbdc7cc0d6622352a1f9b4e17711e1ff = (cfd2fc94585e13e556b13d7ba10b.c07d96df25e149ee1b99babd4357e18e6 = new Action<int>(cfd2fc94585e13e556b13d7ba10b.cba636138275c2dd0c2b85744495ab87a));
									}
									array = c73f1dae9f6f82bed94bc7a9992b.ca580c34a1cbbccc3f8ca98b598c4a2a4(cc076fd568f4bb05b6e433b9eb4ab0a, cbdc7cc0d6622352a1f9b4e17711e1ff);
									if ((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array) < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4108))
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
										throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6916));
									}
									if (c6a5e9b85d86b4e098a511017a1073d71.cc55f7f0034df77b96f2d07b4452a2c71)
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
										if (c57022ba9c2a08b010c87dd03dad49fd5.c7a2b6d9b6de2eef86001b4f09f404e16(array, cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d.c0412f9309baf06438554911feccbba06, num4, cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d.cf3e794b4e35654543c0dcab929fac071, cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d.c80f81f5bbd2eba3291ab3323340a6287) == (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4112))
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
											throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6961));
										}
									}
									num4 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4116);
									num6 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4120);
								}
								else
								{
									num6 = (long)cb83d7b9bc2570649b0e380bddf8cf.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4124), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
									cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d.c040c3a040dd73963402cce104c47ba6e = cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d.c040c3a040dd73963402cce104c47ba6e + num6;
									this.cc34519cf479993998f6d3aff664d927c(new c5f62eb0f1d1c3ecb64334326833347f1(num6, cfd2fc94585e13e556b13d7ba10b.cd3aa05b3892ae47fb648e5d17884d75d.c040c3a040dd73963402cce104c47ba6e, cfd2fc94585e13e556b13d7ba10b.c565daece2dc931752577548359a0df1f));
								}
								if (num6 == 0L)
								{
									break;
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
								fileStream.Write(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4128), (int)num6);
							}
						}
						IL_7B2:
						fileStream.Flush();
					}
					finally
					{
						if (fileStream != null)
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
							((IDisposable)fileStream).Dispose();
						}
					}
				}
				finally
				{
					if (cb83d7b9bc2570649b0e380bddf8cf != null)
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
						((IDisposable)cb83d7b9bc2570649b0e380bddf8cf).Dispose();
					}
				}
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
					((IDisposable)response).Dispose();
				}
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000112EC File Offset: 0x0000F4EC
		public string c90d21f0d803ed867f4420adf5ed63604(string c80cb7b5c7ed3120dee341dfb2dca6ee0)
		{
			return Encoding.UTF8.GetString(this.cd13dfe553208f0b407836d345c6897d0(c80cb7b5c7ed3120dee341dfb2dca6ee0));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00011310 File Offset: 0x0000F510
		public string c8fde2f16b504e6f2d61ca9ffff7c28f6(string c80cb7b5c7ed3120dee341dfb2dca6ee0)
		{
			string result;
			try
			{
				result = this.c90d21f0d803ed867f4420adf5ed63604(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6573), Convert.ToBase64String(Encoding.UTF8.GetBytes(c80cb7b5c7ed3120dee341dfb2dca6ee0))));
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0001136C File Offset: 0x0000F56C
		public void cd1905a0bc7e6a242577c1788a70bfbc1()
		{
			this.TotalDataDownloaded = c3722f2ce35676c2ce539bc2eb02390db.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.TotalDataDownloaded, this.TotalDownloadedCurrentGame);
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060002CA RID: 714 RVA: 0x00011398 File Offset: 0x0000F598
		// (remove) Token: 0x060002CB RID: 715 RVA: 0x000113E8 File Offset: 0x0000F5E8
		internal event EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> c2484bd018cc259ebf6256e671a3c8276
		{
			[CompilerGenerated]
			add
			{
				EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
				EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> value2 = c34f8cb9d1011c541152eb13b528c52c0.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c5f62eb0f1d1c3ecb64334326833347f1>>(ref this.c2484bd018cc259ebf6256e671a3c8276, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.add_c2484bd018cc259ebf6256e671a3c8276(EventHandler<c5f62eb0f1d1c3ecb64334326833347f1>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
				EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> value2 = c34f8cb9d1011c541152eb13b528c52c0.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c5f62eb0f1d1c3ecb64334326833347f1>>(ref this.c2484bd018cc259ebf6256e671a3c8276, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.remove_c2484bd018cc259ebf6256e671a3c8276(EventHandler<c5f62eb0f1d1c3ecb64334326833347f1>)).MethodHandle;
				}
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00011438 File Offset: 0x0000F638
		internal static void c5855ad2b508187b1ec66bb34f916806c(string c80cb7b5c7ed3120dee341dfb2dca6ee0, string c970b31fe4f307e557ac948e45eecc894, byte[] c0412f9309baf06438554911feccbba06, byte[] cf3e794b4e35654543c0dcab929fac071, IEnumerable<int> cb22c586622992796ac77b798c95fb0ad)
		{
			IEnumerator<int> enumerator = cb22c586622992796ac77b798c95fb0ad.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					long num2 = (long)(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4132) * num);
					HttpWebRequest httpWebRequest = c866035f717c1c145e269422264e8f519.c8257b06554692528e80f1d91f9c4d7b0(c80cb7b5c7ed3120dee341dfb2dca6ee0);
					httpWebRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1298);
					httpWebRequest.AddRange(num2);
					WebResponse response = httpWebRequest.GetResponse();
					try
					{
						Stream responseStream = response.GetResponseStream();
						try
						{
							FileStream fileStream = new FileStream(c970b31fe4f307e557ac948e45eecc894, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4136), (FileAccess)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4140), (FileShare)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4144));
							try
							{
								fileStream.Seek(num2, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4148));
								byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4152));
								array = responseStream.ca580c34a1cbbccc3f8ca98b598c4a2a4((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array), c36027b6f11f325bce777cd631b4b9a1c.cab55a050df275722227783d6686266c9);
								fileStream.Write(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4156), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
								fileStream.Flush();
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
									if (!true)
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.c5855ad2b508187b1ec66bb34f916806c(string, string, byte[], byte[], IEnumerable<int>)).MethodHandle;
									}
									((IDisposable)fileStream).Dispose();
								}
							}
						}
						finally
						{
							if (responseStream != null)
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
								((IDisposable)responseStream).Dispose();
							}
						}
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

		// Token: 0x060002CD RID: 717 RVA: 0x00011608 File Offset: 0x0000F808
		internal void c4f3230a32332493721e2920c018c45f2()
		{
			this.TotalDownloadedCurrentGame = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4160)));
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001162C File Offset: 0x0000F82C
		private static HttpWebRequest c8257b06554692528e80f1d91f9c4d7b0(string cfe300fe688845689ab9526c0dc53da7e)
		{
			string host = new Uri(cfe300fe688845689ab9526c0dc53da7e).Host;
			IPAddress ipaddress = ce07c379a1090dd9de869aa5e3a694e98.c0897719f18e7612f358bd6cef2208dd8(host);
			HttpWebRequest httpWebRequest = c306d0f4edb8d9dba0e2099a0ed0662c3.cd24593c859565ebb8c9faabbc5c75bef(WebRequest.Create(cfe300fe688845689ab9526c0dc53da7e.Replace(host, ipaddress.ToString())));
			httpWebRequest.Host = host;
			return httpWebRequest;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00011678 File Offset: 0x0000F878
		private void cc34519cf479993998f6d3aff664d927c(c5f62eb0f1d1c3ecb64334326833347f1 cdf15457ee4816989343b6e6e96dd4cfe)
		{
			DataSize c0d6c37d812d5d4b610705a6421056252 = new DataSize((ulong)cdf15457ee4816989343b6e6e96dd4cfe.c7f66143e0b6a08dbc4ecd81a8956f41e);
			this.c5c77d9e8a9b8cbc9cd27de99f990bc4b = DateTime.Now;
			this.TotalDownloadedCurrentGame = c2b143215f0b748bfd5403c104882d48e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.TotalDownloadedCurrentGame, c0d6c37d812d5d4b610705a6421056252);
			this.TotalDataDownloaded = c2b143215f0b748bfd5403c104882d48e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.TotalDataDownloaded, c0d6c37d812d5d4b610705a6421056252);
			this.ca1f98284d85db4b6387638f9475ca34c = c2b143215f0b748bfd5403c104882d48e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.ca1f98284d85db4b6387638f9475ca34c, c0d6c37d812d5d4b610705a6421056252);
			this.cfbecb9d15eb2e0206d3429f99ccec846 = c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(DateTime.Now, this.c69e81bd914d6b7f88cb547858adadac1);
			if (this.cfbecb9d15eb2e0206d3429f99ccec846.TotalSeconds >= cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(4164))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.cc34519cf479993998f6d3aff664d927c(c5f62eb0f1d1c3ecb64334326833347f1)).MethodHandle;
				}
				this.DownloadSpeed = new c8d217bce073ddc882212f4d0e016403a(this.ca1f98284d85db4b6387638f9475ca34c, this.cfbecb9d15eb2e0206d3429f99ccec846);
				this.ca1f98284d85db4b6387638f9475ca34c = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4172)));
				this.c69e81bd914d6b7f88cb547858adadac1 = DateTime.Now;
			}
			EventHandler<c5f62eb0f1d1c3ecb64334326833347f1> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
			if (eventHandler == null)
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
				return;
			}
			eventHandler.BeginInvoke(this, cdf15457ee4816989343b6e6e96dd4cfe, null, c297b6130075fc34fa606ad0c12ed51a8.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x0400018D RID: 397
		public bool c00dacc5708b46f842a758e6902713b32;

		// Token: 0x0400018E RID: 398
		[CompilerGenerated]
		private c8d217bce073ddc882212f4d0e016403a ceea29b8dcc363e6f7643e0731a944917;

		// Token: 0x0400018F RID: 399
		[CompilerGenerated]
		private Exception c8a880270d7e6e32938ebb42a45492fcc;

		// Token: 0x04000190 RID: 400
		[CompilerGenerated]
		private ulong c7722e658ee128a8bbf32251552823847;

		// Token: 0x04000191 RID: 401
		[CompilerGenerated]
		private DataSize c380c6bd7f5c7f31461b41d40197eb8de;

		// Token: 0x04000192 RID: 402
		[CompilerGenerated]
		private DataSize ceffcadaae969febe5331023bb4e497bb;

		// Token: 0x04000193 RID: 403
		internal volatile bool c7a9bdfb9a734963885e9cb6d7f3ce1cb = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4188) != 0;

		// Token: 0x04000195 RID: 405
		private const int c2c01dc9367cd7baef73a3a6fda5c6565 = 1;

		// Token: 0x04000196 RID: 406
		private TimeSpan cfbecb9d15eb2e0206d3429f99ccec846 = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4192));

		// Token: 0x04000197 RID: 407
		private DateTime c5c77d9e8a9b8cbc9cd27de99f990bc4b = new DateTime((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4196));

		// Token: 0x04000198 RID: 408
		private DateTime c69e81bd914d6b7f88cb547858adadac1 = new DateTime((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4200));

		// Token: 0x04000199 RID: 409
		private DataSize ca1f98284d85db4b6387638f9475ca34c = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4204)));

		// Token: 0x0400019A RID: 410
		private object c7a81f71ef8260e77a1373074920de5e8 = new object();

		// Token: 0x02000107 RID: 263
		public enum c42cdf34b156232e923e120d1e027381b
		{
			// Token: 0x0400062D RID: 1581
			c83a2c44c2139bee1c0f6e8bf4440a55c,
			// Token: 0x0400062E RID: 1582
			c54a8e5fa7ea3bcbe4102f7910c3b41d6
		}

		// Token: 0x02000108 RID: 264
		[CompilerGenerated]
		private sealed class cdf5601963cd46c84f5f35898b2b6ba9f
		{
			// Token: 0x060008AB RID: 2219 RVA: 0x0005C1F4 File Offset: 0x0005A3F4
			internal void ca75f7dd8ef8c8e9938b5b8413a7e2024()
			{
				WebResponse webResponse = c1839979d60cc898291d1e0394101d91f.cab55a050df275722227783d6686266c9;
				Stream stream = c5db4cd6c2448810607b45eaf35a53573.cab55a050df275722227783d6686266c9;
				try
				{
					long num = this.c4f37c170b0d73977de6e507efa87aef0;
					webResponse = this.cff295fe6eeed6a9aa8184e6d752caccd.GetResponse();
					stream = webResponse.GetResponseStream();
					int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30072);
					while (!this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c7a4e30c89f71c54e2739ec9bd70c5e17)
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
						if (!this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
						{
							break;
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
						if ((long)num2 >= this.cf5f63a1d2bd272cd393bf389d6f7bc6c)
						{
							for (;;)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								goto IL_31E;
							}
						}
						else
						{
							Stream c73f1dae9f6f82bed94bc7a9992b = stream;
							int cc076fd568f4bb05b6e433b9eb4ab0a = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30076);
							Action<int> cbdc7cc0d6622352a1f9b4e17711e1ff;
							if ((cbdc7cc0d6622352a1f9b4e17711e1ff = this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.cac9765e7f8695e8272de3db1470e0933) == null)
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
									RuntimeMethodHandle runtimeMethodHandle = methodof(c866035f717c1c145e269422264e8f519.cdf5601963cd46c84f5f35898b2b6ba9f.ca75f7dd8ef8c8e9938b5b8413a7e2024()).MethodHandle;
								}
								cbdc7cc0d6622352a1f9b4e17711e1ff = (this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.cac9765e7f8695e8272de3db1470e0933 = new Action<int>(this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.cdb15dbdeff8c60fd8257a5caa8816bc1));
							}
							byte[] array = c73f1dae9f6f82bed94bc7a9992b.ca580c34a1cbbccc3f8ca98b598c4a2a4(cc076fd568f4bb05b6e433b9eb4ab0a, cbdc7cc0d6622352a1f9b4e17711e1ff);
							if ((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30080))
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
								if (c6a5e9b85d86b4e098a511017a1073d71.cc55f7f0034df77b96f2d07b4452a2c71)
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
									byte[] c77685ee4f17464bac5cfafb994e6d = array;
									byte[] c0412f9309baf06438554911feccbba = this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c0412f9309baf06438554911feccbba06;
									int num3 = this.c7ea27eb926fc7ae0def28ee0acc0925f;
									this.c7ea27eb926fc7ae0def28ee0acc0925f = num3 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30084);
									if (c57022ba9c2a08b010c87dd03dad49fd5.c7a2b6d9b6de2eef86001b4f09f404e16(c77685ee4f17464bac5cfafb994e6d, c0412f9309baf06438554911feccbba, num3, this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.cf3e794b4e35654543c0dcab929fac071, this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c80f81f5bbd2eba3291ab3323340a6287) == (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30088))
									{
										for (;;)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											goto IL_164;
										}
									}
								}
								object c7a81f71ef8260e77a1373074920de5e = this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.c7a81f71ef8260e77a1373074920de5e8;
								bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30092) != 0;
								try
								{
									Monitor.Enter(c7a81f71ef8260e77a1373074920de5e, ref flag);
									this.c248e670c92c8bf286ec14bc40a071437.c32053d44c8d1dcaa73f780b2a239314c.Seek(num, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30096));
									this.c248e670c92c8bf286ec14bc40a071437.c32053d44c8d1dcaa73f780b2a239314c.Write(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30100), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
								}
								finally
								{
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
										Monitor.Exit(c7a81f71ef8260e77a1373074920de5e);
									}
								}
								num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30104);
								num = this.c4f37c170b0d73977de6e507efa87aef0 + (long)(num2 * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30108));
								continue;
							}
							IL_164:
							this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c040c3a040dd73963402cce104c47ba6e = this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c040c3a040dd73963402cce104c47ba6e - (long)((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
							if (stream != null)
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
								stream.Dispose();
							}
							if (webResponse != null)
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
								webResponse.Dispose();
							}
							HttpWebRequest httpWebRequest = WebRequest.CreateHttp(this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c80cb7b5c7ed3120dee341dfb2dca6ee0);
							httpWebRequest.Proxy = this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.ce24dc441194d5a798fa9060d2dbb280f;
							httpWebRequest.AddRange(num);
							webResponse = httpWebRequest.GetResponse();
							stream = webResponse.GetResponseStream();
						}
					}
					IL_31E:;
				}
				catch
				{
					this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c7a4e30c89f71c54e2739ec9bd70c5e17 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30112) != 0);
				}
				finally
				{
					if (webResponse != null)
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
						webResponse.Dispose();
					}
					if (stream != null)
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
						stream.Dispose();
					}
				}
			}

			// Token: 0x0400062F RID: 1583
			public long c4f37c170b0d73977de6e507efa87aef0;

			// Token: 0x04000630 RID: 1584
			public HttpWebRequest cff295fe6eeed6a9aa8184e6d752caccd;

			// Token: 0x04000631 RID: 1585
			public int c7ea27eb926fc7ae0def28ee0acc0925f;

			// Token: 0x04000632 RID: 1586
			public long cf5f63a1d2bd272cd393bf389d6f7bc6c;

			// Token: 0x04000633 RID: 1587
			public c866035f717c1c145e269422264e8f519.cdffd9d0ad667de618f76351a3e788bc8 c248e670c92c8bf286ec14bc40a071437;
		}

		// Token: 0x02000109 RID: 265
		[CompilerGenerated]
		private sealed class c27ba0872d93f343523745dd284ce14d1
		{
			// Token: 0x060008AD RID: 2221 RVA: 0x0005C5C8 File Offset: 0x0005A7C8
			internal void cdb15dbdeff8c60fd8257a5caa8816bc1(int c5a80fb156f3771771f8e6da78b353399)
			{
				this.c040c3a040dd73963402cce104c47ba6e += (long)c5a80fb156f3771771f8e6da78b353399;
				this.c4404a159870bf55bb6f111e66e59e82d.cc34519cf479993998f6d3aff664d927c(new c5f62eb0f1d1c3ecb64334326833347f1((long)c5a80fb156f3771771f8e6da78b353399, this.c040c3a040dd73963402cce104c47ba6e, this.c9874e40afecbf8775b45b3f3741f8deb));
			}

			// Token: 0x04000634 RID: 1588
			public long c040c3a040dd73963402cce104c47ba6e;

			// Token: 0x04000635 RID: 1589
			public long c9874e40afecbf8775b45b3f3741f8deb;

			// Token: 0x04000636 RID: 1590
			public byte[] c0412f9309baf06438554911feccbba06;

			// Token: 0x04000637 RID: 1591
			public byte[] cf3e794b4e35654543c0dcab929fac071;

			// Token: 0x04000638 RID: 1592
			public byte c80f81f5bbd2eba3291ab3323340a6287;

			// Token: 0x04000639 RID: 1593
			public string c80cb7b5c7ed3120dee341dfb2dca6ee0;

			// Token: 0x0400063A RID: 1594
			public WebProxy ce24dc441194d5a798fa9060d2dbb280f;

			// Token: 0x0400063B RID: 1595
			public c866035f717c1c145e269422264e8f519 c4404a159870bf55bb6f111e66e59e82d;

			// Token: 0x0400063C RID: 1596
			public Action<int> cac9765e7f8695e8272de3db1470e0933;
		}

		// Token: 0x0200010A RID: 266
		[CompilerGenerated]
		private sealed class cdffd9d0ad667de618f76351a3e788bc8
		{
			// Token: 0x0400063D RID: 1597
			public FileStream c32053d44c8d1dcaa73f780b2a239314c;

			// Token: 0x0400063E RID: 1598
			public c866035f717c1c145e269422264e8f519.cb5f1d6f94f6048e9767f280fca8c3c65 c9def284befdb85aa51808c134f9b5700;
		}

		// Token: 0x0200010B RID: 267
		[CompilerGenerated]
		private sealed class cb5f1d6f94f6048e9767f280fca8c3c65
		{
			// Token: 0x0400063F RID: 1599
			public bool c7a4e30c89f71c54e2739ec9bd70c5e17;

			// Token: 0x04000640 RID: 1600
			public c866035f717c1c145e269422264e8f519.c27ba0872d93f343523745dd284ce14d1 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x0200010C RID: 268
		[CompilerGenerated]
		private sealed class cfd2fc94585e13e556b13d7ba10b89029
		{
			// Token: 0x060008B1 RID: 2225 RVA: 0x0005C640 File Offset: 0x0005A840
			internal void cba636138275c2dd0c2b85744495ab87a(int c5a80fb156f3771771f8e6da78b353399)
			{
				this.cd3aa05b3892ae47fb648e5d17884d75d.c040c3a040dd73963402cce104c47ba6e = this.cd3aa05b3892ae47fb648e5d17884d75d.c040c3a040dd73963402cce104c47ba6e + (long)c5a80fb156f3771771f8e6da78b353399;
				this.cd3aa05b3892ae47fb648e5d17884d75d.c4404a159870bf55bb6f111e66e59e82d.cc34519cf479993998f6d3aff664d927c(new c5f62eb0f1d1c3ecb64334326833347f1((long)c5a80fb156f3771771f8e6da78b353399, this.cd3aa05b3892ae47fb648e5d17884d75d.c040c3a040dd73963402cce104c47ba6e, this.c565daece2dc931752577548359a0df1f));
			}

			// Token: 0x04000641 RID: 1601
			public long c565daece2dc931752577548359a0df1f;

			// Token: 0x04000642 RID: 1602
			public c866035f717c1c145e269422264e8f519.c27ba0872d93f343523745dd284ce14d1 cd3aa05b3892ae47fb648e5d17884d75d;

			// Token: 0x04000643 RID: 1603
			public Action<int> c07d96df25e149ee1b99babd4357e18e6;
		}
	}
}
