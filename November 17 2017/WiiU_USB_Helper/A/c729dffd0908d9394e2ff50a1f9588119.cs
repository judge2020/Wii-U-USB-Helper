using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Alphaleonis.Win32.Filesystem;
using Telerik.WinControls.Zip;

namespace A
{
	// Token: 0x02000005 RID: 5
	public static class c729dffd0908d9394e2ff50a1f9588119
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002440 File Offset: 0x00000640
		public static void c69bf8280727747918cb0bd4499e9adf4(string cdb43528d5e5a70b8801ab74795c78e66, string cba76a39de77da530172391108797878f, string c1139a34319f573b5050d06fd97623321)
		{
			if (Directory.Exists(c1139a34319f573b5050d06fd97623321))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c729dffd0908d9394e2ff50a1f9588119.c69bf8280727747918cb0bd4499e9adf4(string, string, string)).MethodHandle;
				}
				Directory.Delete(c1139a34319f573b5050d06fd97623321, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16) != 0);
			}
			Directory.CreateDirectory(c1139a34319f573b5050d06fd97623321);
			c729dffd0908d9394e2ff50a1f9588119.c9adbf6ea434c8e2357d1a9524958f2b1(cdb43528d5e5a70b8801ab74795c78e66);
			FileStream fileStream = File.OpenRead(cba76a39de77da530172391108797878f);
			try
			{
				ZipArchive zipArchive = new ZipArchive(fileStream, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(20), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(24) != 0, null, null, c729dffd0908d9394e2ff50a1f9588119.c0444edf2805620c67bc9b189269ccda5);
				try
				{
					string[] array = c885752f0ba103b0c8ad11bede25dddd4.cab55a050df275722227783d6686266c9;
					ZipArchiveEntry entry = zipArchive.GetEntry(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(199));
					try
					{
						StreamReader streamReader = new StreamReader(entry.Open());
						try
						{
							string text = streamReader.ReadToEnd();
							string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(28));
							array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(32)] = Environment.NewLine;
							array = text.Split(array2, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(36));
						}
						finally
						{
							if (streamReader != null)
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
								((IDisposable)streamReader).Dispose();
							}
						}
					}
					finally
					{
						if (entry != null)
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
							entry.Dispose();
						}
					}
					byte[] array3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(40));
					int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(44);
					string[] array4 = array;
					for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(48); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array4); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(120))
					{
						string text2 = array4[i];
						char[] array5 = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(52));
						array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(56)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(60);
						string[] array6 = text2.Split(array5);
						string c0d6c37d812d5d4b610705a6421056252 = array6[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(64)];
						string text3 = array6[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(68)];
						string[] array7 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(72));
						array7[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(76)] = c1139a34319f573b5050d06fd97623321;
						array7[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(80)] = text3;
						string text4 = Path.Combine(array7);
						string[] array8 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(84));
						array8[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(88)] = cdb43528d5e5a70b8801ab74795c78e66;
						array8[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(92)] = text3;
						string text5 = Path.Combine(array8);
						Path.GetDirectoryName(text4);
						MD5 md = MD5.Create();
						try
						{
							if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(228)))
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
								if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(235)))
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
									if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(242)))
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
									}
									else
									{
										Directory.CreateDirectory(text4);
									}
								}
								else
								{
									c729dffd0908d9394e2ff50a1f9588119.c29f68c8b1a1122357d221ee4b0fb9151(text5, array6[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(112)]);
									File.Copy(text5, text4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(116) != 0);
								}
							}
							else
							{
								FileStream fileStream2 = File.Create(text4);
								try
								{
									ZipArchiveEntry entry2 = zipArchive.GetEntry(text3);
									try
									{
										Stream stream = entry2.Open();
										try
										{
											do
											{
												num = stream.Read(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(96), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array3));
												fileStream2.Write(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(100), num);
											}
											while (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(104));
											for (;;)
											{
												switch (6)
												{
												case 0:
													continue;
												}
												break;
											}
										}
										finally
										{
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
												((IDisposable)stream).Dispose();
											}
										}
									}
									finally
									{
										if (entry2 != null)
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
											entry2.Dispose();
										}
									}
								}
								finally
								{
									if (fileStream2 != null)
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
										((IDisposable)fileStream2).Dispose();
									}
								}
								c729dffd0908d9394e2ff50a1f9588119.c29f68c8b1a1122357d221ee4b0fb9151(text4, array6[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(108)]);
							}
						}
						finally
						{
							if (md != null)
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
								((IDisposable)md).Dispose();
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
					if (zipArchive != null)
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
						zipArchive.Dispose();
					}
				}
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
					((IDisposable)fileStream).Dispose();
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000289C File Offset: 0x00000A9C
		private static void c29f68c8b1a1122357d221ee4b0fb9151(string c32053d44c8d1dcaa73f780b2a239314c, string cc8729ebee56d7cf0df2fe5d61754b62b)
		{
			MD5 md = MD5.Create();
			try
			{
				FileStream fileStream = File.OpenRead(c32053d44c8d1dcaa73f780b2a239314c);
				try
				{
					if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Convert.ToBase64String(md.ComputeHash(fileStream)), cc8729ebee56d7cf0df2fe5d61754b62b))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c729dffd0908d9394e2ff50a1f9588119.c29f68c8b1a1122357d221ee4b0fb9151(string, string)).MethodHandle;
						}
						throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(249));
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
			}
			finally
			{
				if (md != null)
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
					((IDisposable)md).Dispose();
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002940 File Offset: 0x00000B40
		private static List<c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd> cb130c91f32dffeb73220d6114b014cfe(string cad48e7cec482eb202b35baba9979de2f)
		{
			c729dffd0908d9394e2ff50a1f9588119.c328f3d368129fbb01ec067fc43227e95 c328f3d368129fbb01ec067fc43227e = new c729dffd0908d9394e2ff50a1f9588119.c328f3d368129fbb01ec067fc43227e95();
			c328f3d368129fbb01ec067fc43227e.c6f2ec23481719c5898c15ae331557a1e = new Uri(cad48e7cec482eb202b35baba9979de2f);
			return new DirectoryInfo(cad48e7cec482eb202b35baba9979de2f).GetDirectories(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(144), (SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(124)).Select(new Func<DirectoryInfo, c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd>(c328f3d368129fbb01ec067fc43227e.cb1d3a1a4b4821ff825a62d01c5b3bac7)).ToList<c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd>();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000299C File Offset: 0x00000B9C
		private static List<c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd> c9adbf6ea434c8e2357d1a9524958f2b1(string cad48e7cec482eb202b35baba9979de2f)
		{
			c729dffd0908d9394e2ff50a1f9588119.c412663b5ceae4986c23b895ade9e5399 c412663b5ceae4986c23b895ade9e = new c729dffd0908d9394e2ff50a1f9588119.c412663b5ceae4986c23b895ade9e5399();
			c412663b5ceae4986c23b895ade9e.c6f2ec23481719c5898c15ae331557a1e = new Uri(cad48e7cec482eb202b35baba9979de2f);
			return new DirectoryInfo(cad48e7cec482eb202b35baba9979de2f).GetFiles(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(144), (SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(128)).Select(new Func<FileInfo, c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd>(c412663b5ceae4986c23b895ade9e.cf4b8126c20edf30c7884dc7ac2a3bde6)).ToList<c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd>();
		}

		// Token: 0x04000003 RID: 3
		private static readonly EncryptionSettings c0444edf2805620c67bc9b189269ccda5 = new DefaultEncryptionSettings
		{
			Password = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(286)
		};

		// Token: 0x020000E9 RID: 233
		public class c025dc1adb6b7d328dec2123dfd8b50bd
		{
			// Token: 0x0600084E RID: 2126 RVA: 0x0005A100 File Offset: 0x00058300
			public c025dc1adb6b7d328dec2123dfd8b50bd(string cd582535e4a69040c2d2ee1c95e24a7a1, string c76a132a1ad5daed4757368925e1385ef)
			{
				this.ce276ca17b9aedc99eee5fd13544f4989 = cd582535e4a69040c2d2ee1c95e24a7a1;
				this.c6aaa5018a403f6deaa5e64b2461159b0 = c76a132a1ad5daed4757368925e1385ef;
			}

			// Token: 0x0600084F RID: 2127 RVA: 0x0005A124 File Offset: 0x00058324
			public override bool Equals(object obj)
			{
				if (obj is c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd.Equals(object)).MethodHandle;
					}
					return c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(((c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd)obj).c6aaa5018a403f6deaa5e64b2461159b0, this.c6aaa5018a403f6deaa5e64b2461159b0);
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29788) != 0;
			}

			// Token: 0x040005D7 RID: 1495
			public string ce276ca17b9aedc99eee5fd13544f4989;

			// Token: 0x040005D8 RID: 1496
			public string c6aaa5018a403f6deaa5e64b2461159b0;
		}

		// Token: 0x020000EA RID: 234
		[CompilerGenerated]
		private sealed class c328f3d368129fbb01ec067fc43227e95
		{
			// Token: 0x06000851 RID: 2129 RVA: 0x0005A184 File Offset: 0x00058384
			internal c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd cb1d3a1a4b4821ff825a62d01c5b3bac7(DirectoryInfo ced17f5fac5de96d8d690dac7cea067a7)
			{
				return new c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd(ced17f5fac5de96d8d690dac7cea067a7.FullName, this.c6f2ec23481719c5898c15ae331557a1e.MakeRelativeUri(new Uri(ced17f5fac5de96d8d690dac7cea067a7.FullName)).OriginalString);
			}

			// Token: 0x040005D9 RID: 1497
			public Uri c6f2ec23481719c5898c15ae331557a1e;
		}

		// Token: 0x020000EB RID: 235
		[CompilerGenerated]
		private sealed class c412663b5ceae4986c23b895ade9e5399
		{
			// Token: 0x06000853 RID: 2131 RVA: 0x0005A1D4 File Offset: 0x000583D4
			internal c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd cf4b8126c20edf30c7884dc7ac2a3bde6(FileInfo ced17f5fac5de96d8d690dac7cea067a7)
			{
				return new c729dffd0908d9394e2ff50a1f9588119.c025dc1adb6b7d328dec2123dfd8b50bd(ced17f5fac5de96d8d690dac7cea067a7.FullName, this.c6f2ec23481719c5898c15ae331557a1e.MakeRelativeUri(new Uri(ced17f5fac5de96d8d690dac7cea067a7.FullName)).OriginalString);
			}

			// Token: 0x040005DA RID: 1498
			public Uri c6f2ec23481719c5898c15ae331557a1e;
		}
	}
}
