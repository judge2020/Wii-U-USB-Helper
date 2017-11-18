using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace A
{
	// Token: 0x0200001B RID: 27
	internal static class c1988464babaf8772429b21b1be6aead2
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00005684 File Offset: 0x00003884
		public static void c2ad4c7b7bd715502a30ad38fb8cedce2(string c9ee5d0e059de6242d29e3c2faa703baf)
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			Directory.SetCurrentDirectory(c9ee5d0e059de6242d29e3c2faa703baf);
			try
			{
				c1988464babaf8772429b21b1be6aead2.c9906b86078f717fd800032f03ec94b92 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(588) != 0);
				c1988464babaf8772429b21b1be6aead2.cb570cd535cb3d4ffb52c4ff14d65a34b = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(592) != 0);
				c1988464babaf8772429b21b1be6aead2.ce4de00f2feab4d90d09679bb9696b006(c1988464babaf8772429b21b1be6aead2.cc2fb3b7a6bb5b474d4ac08f66bad315b);
				long[] c21f7ce7552eb7b177363a316aaddd = c1988464babaf8772429b21b1be6aead2.c1eecc0f4fc542084ce2a00ac76962a68(c1988464babaf8772429b21b1be6aead2.c5a43b946af40528b7d0eeac53a9abaa4, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1421), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(596) != 0);
				byte[] c10e40f176a7c45a7e75eade1e2b = c1988464babaf8772429b21b1be6aead2.c34f3a6e3bbf56ed2757904a419f741c8(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1421), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1450), c21f7ce7552eb7b177363a316aaddd);
				File.Delete(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1421));
				c1988464babaf8772429b21b1be6aead2.ce41afb30f8b10e0071e083ed56dbcc1f(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1450), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1473), c1988464babaf8772429b21b1be6aead2.cc6593e7abf59045117b5eaae6e486653, c1988464babaf8772429b21b1be6aead2.c6f45d37cbdd36668756d2f723a7fa069((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c1988464babaf8772429b21b1be6aead2.cc6593e7abf59045117b5eaae6e486653)), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(600) != 0, c10e40f176a7c45a7e75eade1e2b);
				File.Delete(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1450));
				c1988464babaf8772429b21b1be6aead2.cf8019cf9080340500f402186cceceb20(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1473));
				File.Delete(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1473));
			}
			catch
			{
				Directory.SetCurrentDirectory(currentDirectory);
				throw;
			}
			finally
			{
				Directory.SetCurrentDirectory(currentDirectory);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000057C0 File Offset: 0x000039C0
		private static byte[] c81c1785d857580ada7295fc6b335cab7(byte[] c5202a0249b3d2bed6d5063f3930fb443, byte[] cad83d5894302992ae418fe3ccc7f5709, byte[] c271a832e629a79991d9eda7a270cb125, bool c3845bc9a03102d4d22f3bc5d254b0572)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c271a832e629a79991d9eda7a270cb125));
			byte[] result;
			try
			{
				AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider
				{
					Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(604),
					Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(608),
					KeySize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(612),
					BlockSize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(616),
					Key = c5202a0249b3d2bed6d5063f3930fb443,
					IV = cad83d5894302992ae418fe3ccc7f5709
				};
				if (c3845bc9a03102d4d22f3bc5d254b0572)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(byte[], byte[], byte[], bool)).MethodHandle;
					}
					ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor();
					try
					{
						array = cryptoTransform.TransformFinalBlock(c271a832e629a79991d9eda7a270cb125, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(620), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c271a832e629a79991d9eda7a270cb125));
						goto IL_F3;
					}
					finally
					{
						if (cryptoTransform != null)
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
							cryptoTransform.Dispose();
						}
					}
				}
				ICryptoTransform cryptoTransform2 = aesCryptoServiceProvider.CreateDecryptor();
				try
				{
					array = cryptoTransform2.TransformFinalBlock(c271a832e629a79991d9eda7a270cb125, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(624), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c271a832e629a79991d9eda7a270cb125));
				}
				finally
				{
					if (cryptoTransform2 != null)
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
						cryptoTransform2.Dispose();
					}
				}
				IL_F3:
				aesCryptoServiceProvider.Clear();
				result = array;
			}
			catch
			{
				throw;
			}
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000058F8 File Offset: 0x00003AF8
		private static byte[] c6f45d37cbdd36668756d2f723a7fa069(int c5db06f710879d10bd98fa2c1adf0deb8)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(c5db06f710879d10bd98fa2c1adf0deb8);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(628); i < c5db06f710879d10bd98fa2c1adf0deb8; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(636))
			{
				array[i] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(632);
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
			if (!true)
			{
				RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.c6f45d37cbdd36668756d2f723a7fa069(int)).MethodHandle;
			}
			return array;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005950 File Offset: 0x00003B50
		private static bool c03f502bc82e489033cee2a23300d43ac(byte[] cdf7b6e156ce647cd6bbf8048d6de9618, byte[] c0aeaa1e984891adfd86eb4739fd1a720)
		{
			if ((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cdf7b6e156ce647cd6bbf8048d6de9618) == (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c0aeaa1e984891adfd86eb4739fd1a720))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(byte[], byte[])).MethodHandle;
				}
				return c1988464babaf8772429b21b1be6aead2.c0d4d8b7dc2a369373b3a57084674c652(cdf7b6e156ce647cd6bbf8048d6de9618, c0aeaa1e984891adfd86eb4739fd1a720, (long)((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cdf7b6e156ce647cd6bbf8048d6de9618))) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(640);
			}
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(644) != 0;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000059B0 File Offset: 0x00003BB0
		private static void ce4de00f2feab4d90d09679bb9696b006(string cc2fb3b7a6bb5b474d4ac08f66bad315b)
		{
			MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(cc2fb3b7a6bb5b474d4ac08f66bad315b));
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(648));
			byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(652));
			RuntimeHelpers.InitializeArray(array2, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c086875ea5810d73f52f10661a2984370).FieldHandle);
			byte[] c0aeaa1e984891adfd86eb4739fd1a = array2;
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(656);
			while ((long)num < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(684))
			{
				memoryStream.Position = (long)num;
				memoryStream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(660), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(664));
				if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array, c0aeaa1e984891adfd86eb4739fd1a))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.ce4de00f2feab4d90d09679bb9696b006(string)).MethodHandle;
					}
					memoryStream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(668), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(672));
					Encoding.UTF8.GetString(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(676), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
					IL_10B:
					byte[] array3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(688));
					byte[] array4 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(692));
					Array.Clear(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(696), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(700));
					byte[] array5 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(704));
					RuntimeHelpers.InitializeArray(array5, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c76fec836f59fabbd70bf01771bbfe663).FieldHandle);
					byte[] c0aeaa1e984891adfd86eb4739fd1a2 = array5;
					byte[] array6 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(708));
					RuntimeHelpers.InitializeArray(array6, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c96382f781a5ab54a4408c94fa8efb137).FieldHandle);
					byte[] c0aeaa1e984891adfd86eb4739fd1a3 = array6;
					int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(712);
					while ((long)num2 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(740))
					{
						memoryStream.Position = (long)num2;
						memoryStream.Read(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(716), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(720));
						if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array3, c0aeaa1e984891adfd86eb4739fd1a2))
						{
							goto IL_1EA;
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
						if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array3, c0aeaa1e984891adfd86eb4739fd1a3))
						{
							for (;;)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								goto IL_1EA;
							}
						}
						IL_21B:
						num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(736);
						continue;
						IL_1EA:
						memoryStream.Seek((long)(num2 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(724)), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(728));
						memoryStream.WriteByte((byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(732));
						goto IL_21B;
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
					if (c1988464babaf8772429b21b1be6aead2.c9906b86078f717fd800032f03ec94b92)
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
						Array.Clear(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(744), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(748));
						Array.Clear(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(752), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(756));
						byte[] array7 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(760));
						RuntimeHelpers.InitializeArray(array7, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.ce81b6a6d502c9fee92eb30f1d5b06f9f).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a4 = array7;
						byte[] array8 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(764));
						array8[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(768)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(772);
						array8[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(776)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(780);
						byte[] buffer = array8;
						int num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(784);
						while ((long)num3 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(812))
						{
							memoryStream.Position = (long)num3;
							memoryStream.Read(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(788), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(792));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array4, c0aeaa1e984891adfd86eb4739fd1a4))
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
								memoryStream.Seek((long)num3, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(796));
								memoryStream.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(800), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(804));
							}
							num3 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(808);
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
						byte[] array9 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(816));
						RuntimeHelpers.InitializeArray(array9, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c03b28d065011ac791cad8fd17ea9c266).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a5 = array9;
						byte[] array10 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(820));
						array10[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(824)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(828);
						byte[] buffer2 = array10;
						int num4 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(832);
						while ((long)num4 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(864))
						{
							memoryStream.Position = (long)num4;
							memoryStream.Read(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(836), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(840));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array4, c0aeaa1e984891adfd86eb4739fd1a5))
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
								memoryStream.Seek((long)(num4 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(844)), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(848));
								memoryStream.Write(buffer2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(852), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(856));
							}
							num4 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(860);
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
						byte[] array11 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(868));
						RuntimeHelpers.InitializeArray(array11, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c0d85de3c7501a350ff4ae6ae5594e8d7).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a6 = array11;
						byte[] array12 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(872));
						RuntimeHelpers.InitializeArray(array12, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c0b2805f205d75a84fa97533cd77b98b3).FieldHandle);
						byte[] buffer3 = array12;
						int num5 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(876);
						while ((long)num5 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(908))
						{
							memoryStream.Position = (long)num5;
							memoryStream.Read(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(880), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(884));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array3, c0aeaa1e984891adfd86eb4739fd1a6))
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
								memoryStream.Seek((long)(num5 - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(888)), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(892));
								memoryStream.Write(buffer3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(896), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(900));
							}
							num5 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(904);
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
						byte[] array13 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(912));
						RuntimeHelpers.InitializeArray(array13, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c2ca46631a145339a2adf86d361d568c4).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a7 = array13;
						byte[] array14 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(916));
						RuntimeHelpers.InitializeArray(array14, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.ceb23ee1a459869ed46def06fd635b313).FieldHandle);
						byte[] buffer4 = array14;
						int num6 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(920);
						while ((long)num6 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(948))
						{
							memoryStream.Position = (long)num6;
							memoryStream.Read(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(924), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(928));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array3, c0aeaa1e984891adfd86eb4739fd1a7))
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
								memoryStream.Seek((long)num6, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(932));
								memoryStream.Write(buffer4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(940));
							}
							num6 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(944);
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
						byte[] array15 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(952));
						RuntimeHelpers.InitializeArray(array15, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c8817811a395dc0ad297f135a392d6a80).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a8 = array15;
						byte[] array16 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(956));
						array16[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(960)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(964);
						byte[] c0aeaa1e984891adfd86eb4739fd1a9 = array16;
						byte[] array17 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(968));
						array17[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(972)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(976);
						byte[] buffer5 = array17;
						int num7 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(980);
						while ((long)num7 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1028))
						{
							memoryStream.Position = (long)num7;
							memoryStream.Read(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(984), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(988));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array4, c0aeaa1e984891adfd86eb4739fd1a8))
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
								memoryStream.Seek((long)(num7 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(992)), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(996));
								memoryStream.Read(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1000), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1004));
								if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array3, c0aeaa1e984891adfd86eb4739fd1a9))
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
									memoryStream.Seek((long)(num7 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1008)), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1012));
									memoryStream.Write(buffer5, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1016), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1020));
								}
							}
							num7 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1024);
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
					}
					if (c1988464babaf8772429b21b1be6aead2.cb570cd535cb3d4ffb52c4ff14d65a34b)
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
						Array.Clear(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1032), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1036));
						Array.Clear(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1040), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1044));
						byte[] array18 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1048));
						RuntimeHelpers.InitializeArray(array18, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c1f8d22a8cb17fcdbaca17ccb4a9cc4f9).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a10 = array18;
						byte[] array19 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1052));
						array19[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1056)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1060);
						byte[] buffer6 = array19;
						int num8 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1064);
						while ((long)num8 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1096))
						{
							memoryStream.Position = (long)num8;
							memoryStream.Read(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1072));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array4, c0aeaa1e984891adfd86eb4739fd1a10))
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
								memoryStream.Seek((long)(num8 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1076)), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1080));
								memoryStream.Write(buffer6, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1088));
							}
							num8 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1092);
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
						byte[] array20 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1100));
						RuntimeHelpers.InitializeArray(array20, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.ca6bef31700ada4424c1e2a092d28f164).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a11 = array20;
						byte[] array21 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1104));
						RuntimeHelpers.InitializeArray(array21, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.cde7de41141e3729de00de4c614eb66b1).FieldHandle);
						byte[] buffer7 = array21;
						int num9 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1108);
						while ((long)num9 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1136))
						{
							memoryStream.Position = (long)num9;
							memoryStream.Read(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1112), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1116));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array4, c0aeaa1e984891adfd86eb4739fd1a11))
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
								memoryStream.Seek((long)num9, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1120));
								memoryStream.Write(buffer7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1124), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1128));
							}
							num9 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1132);
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
						byte[] array22 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1140));
						RuntimeHelpers.InitializeArray(array22, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c57ee506d5af36add35c7ef0fb1aefdb7).FieldHandle);
						byte[] c0aeaa1e984891adfd86eb4739fd1a12 = array22;
						byte[] array23 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1144));
						RuntimeHelpers.InitializeArray(array23, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c5610283565ab96da123a1d2f32d81491).FieldHandle);
						byte[] buffer8 = array23;
						int num10 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1148);
						while ((long)num10 < memoryStream.Length - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1176))
						{
							memoryStream.Position = (long)num10;
							memoryStream.Read(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1152), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1156));
							if (c1988464babaf8772429b21b1be6aead2.c03f502bc82e489033cee2a23300d43ac(array3, c0aeaa1e984891adfd86eb4739fd1a12))
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
								memoryStream.Seek((long)num10, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1160));
								memoryStream.Write(buffer8, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1164), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1168));
							}
							num10 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1172);
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
					}
					FileStream fileStream = File.OpenWrite(cc2fb3b7a6bb5b474d4ac08f66bad315b);
					memoryStream.WriteTo(fileStream);
					fileStream.Close();
					memoryStream.Close();
					return;
				}
				num += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(680);
			}
			for (;;)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				goto IL_10B;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00006540 File Offset: 0x00004740
		private static void ce41afb30f8b10e0071e083ed56dbcc1f(string ce45c5b6fac2082a765564b3531536e77, string cbfb58f2b64b5eb60853fe2c60f3254aa, byte[] c5202a0249b3d2bed6d5063f3930fb443, byte[] cad83d5894302992ae418fe3ccc7f5709, bool c3845bc9a03102d4d22f3bc5d254b0572, byte[] c10e40f176a7c45a7e75eade1e2b60989)
		{
			BinaryReader binaryReader = new BinaryReader(File.OpenRead(ce45c5b6fac2082a765564b3531536e77));
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(cbfb58f2b64b5eb60853fe2c60f3254aa));
				try
				{
					if (c3845bc9a03102d4d22f3bc5d254b0572)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.ce41afb30f8b10e0071e083ed56dbcc1f(string, string, byte[], byte[], bool, byte[])).MethodHandle;
						}
						binaryWriter.Write(c10e40f176a7c45a7e75eade1e2b60989);
					}
					byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1180));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1184)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1188);
					byte[] array2 = array;
					byte[] array3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1192));
					int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1196);
					int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1200);
					long num3 = binaryReader.BaseStream.Length;
					do
					{
						if (num == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1204))
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
							num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1208);
							num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1212);
						}
						num += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1216);
						BinaryReader binaryReader2 = binaryReader;
						int count;
						if (num3 <= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1220))
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
							count = (int)num3;
						}
						else
						{
							count = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1224);
						}
						array3 = binaryReader2.ReadBytes(count);
						if (binaryWriter.BaseStream.Position >= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1228))
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
							cad83d5894302992ae418fe3ccc7f5709 = array2;
						}
						if (c3845bc9a03102d4d22f3bc5d254b0572)
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
							if (binaryWriter.BaseStream.Position < (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1232))
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
								array3 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb443, cad83d5894302992ae418fe3ccc7f5709, array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1236) != 0);
							}
						}
						if (c3845bc9a03102d4d22f3bc5d254b0572)
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
							if (binaryWriter.BaseStream.Position >= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1240))
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
								array3 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb443, array2, array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1244) != 0);
								byte[] array4 = array2;
								int num4 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1248);
								array4[num4] = (byte)((int)array4[num4] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1252));
								if (array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1256)] == 0)
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
									byte[] array5 = array2;
									int num5 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1260);
									array5[num5] = (byte)((int)array5[num5] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1264));
									if (array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1268)] == 0)
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
										byte[] array6 = array2;
										int num6 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1272);
										array6[num6] = (byte)((int)array6[num6] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1276));
										if (array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1280)] == 0)
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
											byte[] array7 = array2;
											int num7 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1284);
											array7[num7] = (byte)((int)array7[num7] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1288));
										}
									}
								}
							}
						}
						if (!c3845bc9a03102d4d22f3bc5d254b0572)
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
							if (binaryWriter.BaseStream.Position < (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1292))
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
								array3 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb443, cad83d5894302992ae418fe3ccc7f5709, array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1296) != 0);
							}
						}
						if (!c3845bc9a03102d4d22f3bc5d254b0572)
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
							if (binaryWriter.BaseStream.Position >= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1300))
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
								array3 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb443, cad83d5894302992ae418fe3ccc7f5709, array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1304) != 0);
								byte[] array8 = array2;
								int num8 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1308);
								array8[num8] = (byte)((int)array8[num8] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1312));
								if (array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1316)] == 0)
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
									byte[] array9 = array2;
									int num9 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1320);
									array9[num9] = (byte)((int)array9[num9] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1324));
									if (array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1328)] == 0)
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
										byte[] array10 = array2;
										int num10 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1332);
										array10[num10] = (byte)((int)array10[num10] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1336));
										if (array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1340)] == 0)
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
											byte[] array11 = array2;
											int num11 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1344);
											array11[num11] = (byte)((int)array11[num11] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1348));
										}
									}
								}
							}
						}
						binaryWriter.Write(array3);
						num3 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1352);
					}
					while (num3 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1356));
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
				finally
				{
					if (binaryWriter != null)
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
						((IDisposable)binaryWriter).Dispose();
					}
				}
			}
			finally
			{
				if (binaryReader != null)
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
					((IDisposable)binaryReader).Dispose();
				}
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000069D8 File Offset: 0x00004BD8
		private static long[] c1eecc0f4fc542084ce2a00ac76962a68(string ce45c5b6fac2082a765564b3531536e77, string cbfb58f2b64b5eb60853fe2c60f3254aa, bool c3845bc9a03102d4d22f3bc5d254b0572)
		{
			BinaryReader binaryReader = new BinaryReader(File.OpenRead(ce45c5b6fac2082a765564b3531536e77));
			long[] result;
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(cbfb58f2b64b5eb60853fe2c60f3254aa));
				try
				{
					long[] array = c7d3574a77921a6ff7a379b199b50889f.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1360));
					binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1364)));
					byte[] array2 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1368));
					binaryWriter.Write(array2);
					int[,] array3 = new int[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1372), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1376)];
					byte b = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1380);
					while ((int)b < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1496))
					{
						array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1384), (int)b] = (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1388) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1392) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1396) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1400) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1404) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1408) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1412) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1416) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1420) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1424) * (int)b];
						if (array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1428), (int)b] == 0)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.c1eecc0f4fc542084ce2a00ac76962a68(string, string, bool)).MethodHandle;
							}
							array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1432), (int)b] = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1436);
						}
						else
						{
							array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1440), (int)b] = ((int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1444) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1448) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1452) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1456) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1460) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1464) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1468) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1472) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1476) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1480) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1484) * (int)b]) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1488);
						}
						b = (byte)((int)b + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1492));
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
					array3 = c1988464babaf8772429b21b1be6aead2.caf1f25527c572731e866005deefb2e2a(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1500));
					byte[][] array4 = c721f2ce58e4fe22f32427210a1521f49.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1504));
					List<int> list = new List<int>();
					long num = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1508);
					int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1512);
					for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1516); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1620); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1616))
					{
						if (array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1520), i] != 0)
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
							binaryWriter.Write(binaryReader.ReadBytes((int)((long)array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1524), i] - num)));
							num += (long)array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1528), i] - num;
							array4[i] = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1532) * array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1536), i]);
							num += (long)(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1540) * array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1544), i]);
							for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1548); j < array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1612), i]; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1608))
							{
								if (array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1552) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1556) * j] == 0)
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
									list.Add(((int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1560) * j] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1564) + (int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1568) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1572) * j] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1576) + (int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1580) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1584) * j] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1588) + (int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1592) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1596) * j]) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1600));
									num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1604);
								}
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
							binaryWriter.Write(array4[i]);
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
					int[] array5 = list.ToArray();
					array5 = c1988464babaf8772429b21b1be6aead2.caf1f25527c572731e866005deefb2e2a(array5, (int)cf6f120af387fdadacd350a0ba653ecce.cfeb04651f165d0166e7c10ab1acf8b28(array5));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1624)] = (long)array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1628)];
					byte[] array6 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1632));
					byte[] array7 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1636));
					byte[] array8 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1640));
					int num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1644);
					int num4 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1648);
					int k = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1652);
					IL_977:
					while (k < (int)cf6f120af387fdadacd350a0ba653ecce.cfeb04651f165d0166e7c10ab1acf8b28(array5))
					{
						binaryWriter.Write(binaryReader.ReadBytes((int)((long)array5[k] - num)));
						num += (long)array5[k] - num;
						binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1656)));
						byte[] array9 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1660));
						binaryWriter.Write(array9);
						binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1664)));
						byte[] array10 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1668));
						binaryWriter.Write(array10);
						for (int l = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1672); l < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1688); l += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1684))
						{
							if (l < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1676))
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
								array6[l] = array10[l];
							}
							else
							{
								array6[l] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1680);
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
						binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1692)));
						byte[] array11 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1696));
						long num5 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1700) * (long)((int)array11[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1704)] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1708) + (int)array11[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1712)] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1716) + (int)array11[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1720)] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1724) + (int)array11[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1728)]);
						binaryWriter.Write(array11);
						num += (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1732);
						num += num5;
						byte[] c5202a0249b3d2bed6d5063f3930fb = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c1988464babaf8772429b21b1be6aead2.cc6593e7abf59045117b5eaae6e486653, array6, array9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1736) != 0);
						byte[] array12 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1740));
						while (num5 >= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1832))
						{
							if (num3 == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1744))
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
								num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1748);
								num4 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1752);
							}
							num3 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1756);
							if (c3845bc9a03102d4d22f3bc5d254b0572)
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
								Array.Clear(array6, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1760), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1764));
								array7 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1768));
								array8 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb, array6, array7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1772) != 0);
								binaryWriter.Write(array8);
								if (binaryReader.BaseStream.Position >= binaryReader.BaseStream.Length)
								{
									goto IL_94D;
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
								Array.Copy(array8, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1776), array6, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1784));
								array12 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1788));
								array12 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb, array6, array12, c3845bc9a03102d4d22f3bc5d254b0572);
							}
							else
							{
								Array.Clear(array6, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1792), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1796));
								array8 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1800));
								array7 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb, array6, array8, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1804) != 0);
								binaryWriter.Write(array7);
								if (binaryReader.BaseStream.Position >= binaryReader.BaseStream.Length)
								{
									goto IL_94D;
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
								Array.Copy(array8, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1808), array6, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1812), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1816));
								array12 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1820));
								array12 = c1988464babaf8772429b21b1be6aead2.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb, array6, array12, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1824) != 0);
							}
							binaryWriter.Write(array12);
							num5 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1828);
							continue;
							IL_94D:
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1836)] = num - array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1840)];
							k += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1844);
							goto IL_977;
						}
						for (;;)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							goto IL_94D;
						}
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
					if (c3845bc9a03102d4d22f3bc5d254b0572)
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
						long num6;
						if (num > cebbdeae8341a51f374f3ef4c993a069a.c2485e25639b965f9b26a461c0945f99a(1848))
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
							num6 = cebbdeae8341a51f374f3ef4c993a069a.c2485e25639b965f9b26a461c0945f99a(1856) - num;
						}
						else
						{
							num6 = cebbdeae8341a51f374f3ef4c993a069a.c2485e25639b965f9b26a461c0945f99a(1864) - num;
						}
						num4 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1872);
						num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1876);
						while (num6 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1908))
						{
							if (num3 == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1880))
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
								num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1884);
								num4 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1888);
							}
							num3 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1892);
							BinaryWriter binaryWriter2 = binaryWriter;
							int c5db06f710879d10bd98fa2c1adf0deb;
							if (num6 <= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1896))
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
								c5db06f710879d10bd98fa2c1adf0deb = (int)num6;
							}
							else
							{
								c5db06f710879d10bd98fa2c1adf0deb = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1900);
							}
							binaryWriter2.Write(c1988464babaf8772429b21b1be6aead2.c6f45d37cbdd36668756d2f723a7fa069(c5db06f710879d10bd98fa2c1adf0deb));
							num6 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1904);
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
						result = c7f31033c1d41fe8d956894a8434bbdc2.cab55a050df275722227783d6686266c9;
					}
					else
					{
						result = array;
					}
				}
				finally
				{
					if (binaryWriter != null)
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
						((IDisposable)binaryWriter).Dispose();
					}
				}
			}
			finally
			{
				if (binaryReader != null)
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
					((IDisposable)binaryReader).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000085 RID: 133
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memcmp")]
		private static extern int c0d4d8b7dc2a369373b3a57084674c652(byte[] cdf7b6e156ce647cd6bbf8048d6de9618, byte[] c0aeaa1e984891adfd86eb4739fd1a720, long cc076fd568f4bb05b6e433b9eb4ab0a25);

		// Token: 0x06000086 RID: 134 RVA: 0x000074F4 File Offset: 0x000056F4
		private static byte[] c34f3a6e3bbf56ed2757904a419f741c8(string ce45c5b6fac2082a765564b3531536e77, string cbfb58f2b64b5eb60853fe2c60f3254aa, long[] c21f7ce7552eb7b177363a316aaddd362)
		{
			BinaryReader binaryReader = new BinaryReader(File.OpenRead(ce45c5b6fac2082a765564b3531536e77));
			byte[] result;
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(cbfb58f2b64b5eb60853fe2c60f3254aa));
				try
				{
					byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1912));
					for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1916); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1928); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1924))
					{
						array[i] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1920);
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.c34f3a6e3bbf56ed2757904a419f741c8(string, string, long[])).MethodHandle;
					}
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1932)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1936);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1940)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1944);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1948)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1952);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1956)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1960);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1964)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1968);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1972)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1976);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1980)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1984);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1988)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1992);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(1996)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2000);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2004)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2008);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2012)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2016);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2020)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2024);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2028)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2032);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2036)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2040);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2044)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2048);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2052)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2056);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2060)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2064);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2068)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2072);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2076)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2080);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2084)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2088);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2092)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2096);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2100)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2104);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2108)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2112);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2116)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2120);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2124)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2128);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2132)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2136);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2140)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2144);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2148)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2152);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2156)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2160);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2164)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2168);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2172)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2176);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2180)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2184);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2188)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2192);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2196)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2200);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2204)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2208);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2212)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2216);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2220)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2224)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2228) / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2232));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2236)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2240)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2244) / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2248) % (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2252));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2256)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2260)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2264) / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2268) % (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2272));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2276)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2280)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2284) % (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2288));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2292)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2296)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2300) / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2304));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2308)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2312)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2316) / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2320) % (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2324));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2328)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2332)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2336) / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2340) % (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2344));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2348)] = (byte)(c21f7ce7552eb7b177363a316aaddd362[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2352)] / (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2356) % (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2360));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2364)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2368);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2372)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2376);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2380)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2384);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2388)] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2392);
					int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2396) * (int)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2400)] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2404) * (int)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2408)] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2412) * (int)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2416)] + (int)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2420)];
					long num2 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2424);
					long num3 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2428);
					for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2432); j < num; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2556))
					{
						long num4 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2436) * ((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2440) * (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2444) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2448)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2452) * (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2456) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2460)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2464) * (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2468) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2472)]) + (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2476) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2480)]));
						long num5 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2484) * ((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2488) * (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2492) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2496)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2500) * (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2504) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2508)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2512) * (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2516) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2520)]) + (long)((ulong)array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2524) + j * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2528)]));
						for (num3 = num4 - num2; num3 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2540); num3 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2536))
						{
							binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2532));
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
						for (num3 = num5; num3 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2552); num3 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2548))
						{
							binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2544)));
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
						num2 = num4 + num5;
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
					result = array;
				}
				finally
				{
					if (binaryWriter != null)
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
						((IDisposable)binaryWriter).Dispose();
					}
				}
			}
			finally
			{
				if (binaryReader != null)
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
					((IDisposable)binaryReader).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007D7C File Offset: 0x00005F7C
		private static int[,] caf1f25527c572731e866005deefb2e2a(int[,] c82dd34236c6c1a53878feade40e0b3a1, int c5db06f710879d10bd98fa2c1adf0deb8)
		{
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2560);
			int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2564);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2568); i < c5db06f710879d10bd98fa2c1adf0deb8; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2636))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2572); j < c5db06f710879d10bd98fa2c1adf0deb8 - i; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2584))
				{
					if (c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2576), j] > num)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.caf1f25527c572731e866005deefb2e2a(int[,], int)).MethodHandle;
						}
						num = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2580), j];
						num2 = j;
					}
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
				int num3 = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2588), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2592)];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2596), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2600)] = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2604), num2];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2608), num2] = num3;
				num3 = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2612), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2616)];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2620), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2624)] = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2628), num2];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2632), num2] = num3;
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
			return c82dd34236c6c1a53878feade40e0b3a1;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007F08 File Offset: 0x00006108
		private static int[] caf1f25527c572731e866005deefb2e2a(int[] c82dd34236c6c1a53878feade40e0b3a1, int c5db06f710879d10bd98fa2c1adf0deb8)
		{
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2640);
			int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2644);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2648); i < c5db06f710879d10bd98fa2c1adf0deb8; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2668))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2652); j < c5db06f710879d10bd98fa2c1adf0deb8 - i; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2656))
				{
					if (c82dd34236c6c1a53878feade40e0b3a1[j] > num)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.caf1f25527c572731e866005deefb2e2a(int[], int)).MethodHandle;
						}
						num = c82dd34236c6c1a53878feade40e0b3a1[j];
						num2 = j;
					}
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
				int num3 = c82dd34236c6c1a53878feade40e0b3a1[c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2660)];
				c82dd34236c6c1a53878feade40e0b3a1[c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2664)] = c82dd34236c6c1a53878feade40e0b3a1[num2];
				c82dd34236c6c1a53878feade40e0b3a1[num2] = num3;
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
			return c82dd34236c6c1a53878feade40e0b3a1;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007FD4 File Offset: 0x000061D4
		private static void cf8019cf9080340500f402186cceceb20(string c62c4d7a60cd5625d5b0123ff80498539)
		{
			BinaryReader binaryReader = new BinaryReader(File.OpenRead(c62c4d7a60cd5625d5b0123ff80498539));
			try
			{
				long num = binaryReader.BaseStream.Length;
				int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2672);
				do
				{
					BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(c009279a45243b14127222aa793e3eb2e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Directory.GetCurrentDirectory(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1488), string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1499), num2), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1512))));
					BinaryReader binaryReader2 = binaryReader;
					int count;
					if (num <= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2676))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c1988464babaf8772429b21b1be6aead2.cf8019cf9080340500f402186cceceb20(string)).MethodHandle;
						}
						count = (int)num;
					}
					else
					{
						count = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2680);
					}
					binaryWriter.Write(binaryReader2.ReadBytes(count));
					num -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2684);
					num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2688);
				}
				while (num > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2692));
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
				if (binaryReader != null)
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
					((IDisposable)binaryReader).Dispose();
				}
			}
		}

		// Token: 0x0400004B RID: 75
		public const int cfe18f8bc1847cc07490928f559b3ec23 = 512;

		// Token: 0x0400004C RID: 76
		public const int c1da12f26dea52f19ec1cd0233934f050 = 262144000;

		// Token: 0x0400004D RID: 77
		public const int c835fd3db442ba83ed5ff9b490a1ad282 = 32768;

		// Token: 0x0400004E RID: 78
		public static bool c31af1fd148c03c30d1f444d8e9d39507 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2696) != 0;

		// Token: 0x0400004F RID: 79
		public static bool c3845bc9a03102d4d22f3bc5d254b0572 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2700) != 0;

		// Token: 0x04000050 RID: 80
		public static string cc2fb3b7a6bb5b474d4ac08f66bad315b = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1521);

		// Token: 0x04000051 RID: 81
		public static bool c9906b86078f717fd800032f03ec94b92 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2704) != 0;

		// Token: 0x04000052 RID: 82
		public static bool cf9fda59b2d9cb31db55d59595b0eda40 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2708) != 0;

		// Token: 0x04000053 RID: 83
		public static bool ceeca9890172b581074df3b42bcf98648 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2712) != 0;

		// Token: 0x04000054 RID: 84
		public static string c5a43b946af40528b7d0eeac53a9abaa4 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1550);

		// Token: 0x04000055 RID: 85
		public static bool ca32d5aa7f4c11b7e56851254a695a0ac = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2716) != 0;

		// Token: 0x04000056 RID: 86
		public static bool ca15854f5e9b88464fed5783612f86845 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2720) != 0;

		// Token: 0x04000057 RID: 87
		public static string c892281e6812e57d545409e1054a3fa54 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1567);

		// Token: 0x04000058 RID: 88
		public static bool cf44874ba76f054e7bd2aef3643d6c0b4 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2724) != 0;

		// Token: 0x04000059 RID: 89
		public static string c6bfb275608269b46a1d7dccf02be88be = "";

		// Token: 0x0400005A RID: 90
		public static bool c4d3f9a7e2d97322164c61f1d2b0e0f1e = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2728) != 0;

		// Token: 0x0400005B RID: 91
		public static bool cb570cd535cb3d4ffb52c4ff14d65a34b = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2732) != 0;

		// Token: 0x0400005C RID: 92
		public static bool cbadfe2b8e9cb2da0340b214fa55a0ff3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2736) != 0;

		// Token: 0x0400005D RID: 93
		public static byte[] cc6593e7abf59045117b5eaae6e486653 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2740));

		// Token: 0x0400005E RID: 94
		public static string c4920ca25c3bccd6c08ee85d91212d759 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1598);
	}
}
