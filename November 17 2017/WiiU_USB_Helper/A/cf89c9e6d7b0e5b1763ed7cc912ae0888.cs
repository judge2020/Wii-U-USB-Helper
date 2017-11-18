using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace A
{
	// Token: 0x0200008E RID: 142
	internal static class cf89c9e6d7b0e5b1763ed7cc912ae0888
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x0001EE28 File Offset: 0x0001D028
		static cf89c9e6d7b0e5b1763ed7cc912ae0888()
		{
			// Note: this type is marked as 'beforefieldinit'.
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8720));
			RuntimeHelpers.InitializeArray(array, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c939e49e2d4024ac735e538f27f6aebdd).FieldHandle);
			cf89c9e6d7b0e5b1763ed7cc912ae0888.cc6593e7abf59045117b5eaae6e486653 = array;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001EE98 File Offset: 0x0001D098
		public static void c81c1785d857580ada7295fc6b335cab7(byte[] c5202a0249b3d2bed6d5063f3930fb443, byte[] cad83d5894302992ae418fe3ccc7f5709, byte[] c271a832e629a79991d9eda7a270cb125, byte[] c55d05c706d58344e2a18e3c98b1ba4d5, bool c3845bc9a03102d4d22f3bc5d254b0572)
		{
			c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c271a832e629a79991d9eda7a270cb125));
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7840);
				rijndaelManaged.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7844);
				rijndaelManaged.KeySize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7848);
				rijndaelManaged.BlockSize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7852);
				rijndaelManaged.Key = c5202a0249b3d2bed6d5063f3930fb443;
				rijndaelManaged.IV = cad83d5894302992ae418fe3ccc7f5709;
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.c81c1785d857580ada7295fc6b335cab7(byte[], byte[], byte[], byte[], bool)).MethodHandle;
					}
					ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
					try
					{
						cryptoTransform.TransformBlock(c271a832e629a79991d9eda7a270cb125, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7856), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c271a832e629a79991d9eda7a270cb125), c55d05c706d58344e2a18e3c98b1ba4d5, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7860));
						goto IL_10A;
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
				ICryptoTransform cryptoTransform2 = rijndaelManaged.CreateDecryptor();
				try
				{
					cryptoTransform2.TransformBlock(c271a832e629a79991d9eda7a270cb125, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7864), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c271a832e629a79991d9eda7a270cb125), c55d05c706d58344e2a18e3c98b1ba4d5, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7868));
				}
				finally
				{
					if (cryptoTransform2 != null)
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
						cryptoTransform2.Dispose();
					}
				}
				IL_10A:
				rijndaelManaged.Clear();
			}
			catch (CryptographicException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001F010 File Offset: 0x0001D210
		public static long[] c2169a03f6cbfa0e350dc62c7b054927c(string ce45c5b6fac2082a765564b3531536e77, string cbfb58f2b64b5eb60853fe2c60f3254aa, bool c3845bc9a03102d4d22f3bc5d254b0572)
		{
			BinaryReader binaryReader = new BinaryReader(File.OpenRead(ce45c5b6fac2082a765564b3531536e77));
			long[] result;
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(cbfb58f2b64b5eb60853fe2c60f3254aa));
				try
				{
					long[] array = c7d3574a77921a6ff7a379b199b50889f.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7872));
					binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7876)));
					byte[] array2 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7880));
					binaryWriter.Write(array2);
					int[,] array3 = new int[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7884), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7888)];
					byte b = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7892);
					while ((int)b < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8008))
					{
						array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7896), (int)b] = (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7900) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7904) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7908) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7912) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7916) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7920) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7924) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7928) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7932) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7936) * (int)b];
						if (array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7940), (int)b] == 0)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.c2169a03f6cbfa0e350dc62c7b054927c(string, string, bool)).MethodHandle;
							}
							array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7944), (int)b] = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7948);
						}
						else
						{
							array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7952), (int)b] = ((int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7956) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7960) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7964) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7968) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7972) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7976) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7980) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7984) * (int)b] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7988) + (int)array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7992) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7996) * (int)b]) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8000);
						}
						b = (byte)((int)b + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8004));
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
					Console.WriteLine();
					array3 = cf89c9e6d7b0e5b1763ed7cc912ae0888.caf1f25527c572731e866005deefb2e2a(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8012));
					byte[][] array4 = c721f2ce58e4fe22f32427210a1521f49.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8016));
					List<int> list = new List<int>();
					long num = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8020);
					int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8024);
					for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8028); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8132); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8128))
					{
						if (array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8032), i] != 0)
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
							binaryWriter.Write(binaryReader.ReadBytes((int)((long)array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8036), i] - num)));
							num += (long)array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8040), i] - num;
							array4[i] = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8044) * array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8048), i]);
							num += (long)(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8052) * array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8056), i]);
							for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8060); j < array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8124), i]; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8120))
							{
								if (array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8064) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8068) * j] == 0)
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
									list.Add(((int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8072) * j] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8076) + (int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8080) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8084) * j] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8088) + (int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8092) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8096) * j] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8100) + (int)array4[i][cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8104) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8108) * j]) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8112));
									num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8116);
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
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					Console.WriteLine();
					int[] array5 = list.ToArray();
					array5 = cf89c9e6d7b0e5b1763ed7cc912ae0888.caf1f25527c572731e866005deefb2e2a(array5, (int)cf6f120af387fdadacd350a0ba653ecce.cfeb04651f165d0166e7c10ab1acf8b28(array5));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8136)] = (long)array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8140)];
					byte[] array6 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8144));
					int num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8148);
					byte[] array7 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8152));
					byte[] array8 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8156));
					byte[] array9 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8160));
					byte[] array10 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8164));
					int num4 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8168);
					long num5 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8172);
					int num6 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8176);
					for (int k = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8180); k < (int)cf6f120af387fdadacd350a0ba653ecce.cfeb04651f165d0166e7c10ab1acf8b28(array5); k += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8336))
					{
						long num7 = (long)array5[k] - num;
						long num8 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8184);
						do
						{
							num8 = num7 - num5;
							Stream baseStream = binaryReader.BaseStream;
							byte[] buffer = array10;
							int offset = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8188);
							int count;
							if ((long)((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array10)) >= num8)
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
								count = (int)num8;
							}
							else
							{
								count = (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array10);
							}
							num4 = baseStream.Read(buffer, offset, count);
							binaryWriter.BaseStream.Write(array10, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8192), num4);
							num5 += (long)num4;
						}
						while (num8 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8196));
						for (;;)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						num += (long)array5[k] - num;
						binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8200)));
						byte[] array11 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8204));
						binaryWriter.Write(array11);
						binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8208)));
						byte[] array12 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8212));
						binaryWriter.Write(array12);
						for (int l = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8216); l < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8232); l += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8228))
						{
							if (l < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8220))
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
								array6[l] = array12[l];
							}
							else
							{
								array6[l] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8224);
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
						binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8236)));
						binaryReader.BaseStream.Read(array9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8240), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array9));
						long num9 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8244) * (long)((int)array9[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8248)] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8252) + (int)array9[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8256)] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8260) + (int)array9[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8264)] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8268) + (int)array9[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8272)]);
						binaryWriter.Write(array9);
						num += (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8276);
						num += num9;
						byte[] array13 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8280));
						cf89c9e6d7b0e5b1763ed7cc912ae0888.c81c1785d857580ada7295fc6b335cab7(cf89c9e6d7b0e5b1763ed7cc912ae0888.cc6593e7abf59045117b5eaae6e486653, array6, array11, array13, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8284) != 0);
						while (num9 >= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8324))
						{
							if (num3 == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8288))
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
								num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8292);
								num6 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8296);
							}
							num3 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8300);
							binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8304)));
							array6 = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8308));
							binaryWriter.Write(array6);
							binaryWriter.Write(binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8312)));
							binaryReader.BaseStream.Read(array7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8316), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array7));
							cf89c9e6d7b0e5b1763ed7cc912ae0888.c81c1785d857580ada7295fc6b335cab7(array13, array6, array7, array8, c3845bc9a03102d4d22f3bc5d254b0572);
							binaryWriter.Write(array8);
							num9 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8320);
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
						array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8328)] = num - array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8332)];
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
						long num10;
						if (num > cebbdeae8341a51f374f3ef4c993a069a.c2485e25639b965f9b26a461c0945f99a(8340))
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
							num10 = cebbdeae8341a51f374f3ef4c993a069a.c2485e25639b965f9b26a461c0945f99a(8348) - num;
						}
						else
						{
							num10 = cebbdeae8341a51f374f3ef4c993a069a.c2485e25639b965f9b26a461c0945f99a(8356) - num;
						}
						num6 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8364);
						num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8368);
						while (num10 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8404))
						{
							if (num3 == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8372))
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
								num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8376);
								num6 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8380);
							}
							num3 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8384);
							long num11;
							if (num10 <= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8388))
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
								num11 = num10;
							}
							else
							{
								num11 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8392);
							}
							long num12 = num11;
							binaryWriter.Write(cf89c9e6d7b0e5b1763ed7cc912ae0888.c97b154fd19344a2744f4bc20e1322144, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8396), (int)num12);
							num10 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8400);
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
							switch (4)
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
						switch (7)
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

		// Token: 0x06000480 RID: 1152 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		public static void cf08369cbb3a626a84f05ff893b78fed7(string c70f1064222fa2c281974a7b7a2035e61)
		{
			cf89c9e6d7b0e5b1763ed7cc912ae0888.c587932ee94a2bd6bca978c6b3a2320b2 c587932ee94a2bd6bca978c6b3a2320b = new cf89c9e6d7b0e5b1763ed7cc912ae0888.c587932ee94a2bd6bca978c6b3a2320b2();
			cf89c9e6d7b0e5b1763ed7cc912ae0888.c6bfb275608269b46a1d7dccf02be88be = c70f1064222fa2c281974a7b7a2035e61;
			c587932ee94a2bd6bca978c6b3a2320b.c10e40f176a7c45a7e75eade1e2b60989 = cf89c9e6d7b0e5b1763ed7cc912ae0888.ce362dad08469800138e4441814ef5cd5(Path.Combine(cf89c9e6d7b0e5b1763ed7cc912ae0888.c6bfb275608269b46a1d7dccf02be88be, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39933)));
			c587932ee94a2bd6bca978c6b3a2320b.c93624d72c8f5f77734cc8379342e5b14 = Path.Combine(cf89c9e6d7b0e5b1763ed7cc912ae0888.c6bfb275608269b46a1d7dccf02be88be, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1421));
			string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39962);
			Action c594146923b42642ebf4bf2a5cd = new Action(c587932ee94a2bd6bca978c6b3a2320b.c8a0baf45726075952376a6489b0849bd);
			Action<Exception> c62f902d27574ffccbd029fee23622bc;
			if ((c62f902d27574ffccbd029fee23622bc = cf89c9e6d7b0e5b1763ed7cc912ae0888.<>c.c723c96c208fa47fa8ba728866ff24b7d) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.cf08369cbb3a626a84f05ff893b78fed7(string)).MethodHandle;
				}
				c62f902d27574ffccbd029fee23622bc = (cf89c9e6d7b0e5b1763ed7cc912ae0888.<>c.c723c96c208fa47fa8ba728866ff24b7d = new Action<Exception>(cf89c9e6d7b0e5b1763ed7cc912ae0888.<>c.cdfab1996eb8651828de2a4469aa3481e.cd54342f3369f498c5279d63febaaf234));
			}
			new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001FB98 File Offset: 0x0001DD98
		public static void ceb1c46f076bd981606ebddc12d96d32a(Stream cad48e7cec482eb202b35baba9979de2f, string cbfb58f2b64b5eb60853fe2c60f3254aa, byte[] c10e40f176a7c45a7e75eade1e2b60989, byte[] c5202a0249b3d2bed6d5063f3930fb443, byte[] cad83d5894302992ae418fe3ccc7f5709)
		{
			BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(cbfb58f2b64b5eb60853fe2c60f3254aa));
			try
			{
				int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8408) * (int)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8412)] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8416) * (int)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8420)] + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8424) * (int)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8428)] + (int)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8432)];
				long num2 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8436);
				long num3 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8440);
				byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8444));
				byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8448));
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8452); i < num; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8580))
				{
					long num4 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8456) * ((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8460) * (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8464) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8468)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8472) * (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8476) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8480)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8484) * (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8488) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8492)]) + (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8496) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8500)]));
					long num5 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8504) * ((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8508) * (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8512) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8516)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8520) * (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8524) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8528)]) + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8532) * (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8536) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8540)]) + (long)((ulong)c10e40f176a7c45a7e75eade1e2b60989[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8544) + i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8548)]));
					for (num3 = num4 - num2; num3 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8556); num3 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8552))
					{
						binaryWriter.Write(cf89c9e6d7b0e5b1763ed7cc912ae0888.c97b154fd19344a2744f4bc20e1322144);
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.ceb1c46f076bd981606ebddc12d96d32a(Stream, string, byte[], byte[], byte[])).MethodHandle;
					}
					for (num3 = num5; num3 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8576); num3 -= (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8572))
					{
						cad48e7cec482eb202b35baba9979de2f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8560), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8564));
						cf89c9e6d7b0e5b1763ed7cc912ae0888.c81c1785d857580ada7295fc6b335cab7(c5202a0249b3d2bed6d5063f3930fb443, cad83d5894302992ae418fe3ccc7f5709, array, array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8568) != 0);
						binaryWriter.Write(array2);
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
					num2 = num4 + num5;
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
			finally
			{
				if (binaryWriter != null)
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
					((IDisposable)binaryWriter).Dispose();
				}
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
		private static byte[] c6f45d37cbdd36668756d2f723a7fa069(int c5db06f710879d10bd98fa2c1adf0deb8)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(c5db06f710879d10bd98fa2c1adf0deb8);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8584); i < c5db06f710879d10bd98fa2c1adf0deb8; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8592))
			{
				array[i] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8588);
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
				RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.c6f45d37cbdd36668756d2f723a7fa069(int)).MethodHandle;
			}
			return array;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001FEFC File Offset: 0x0001E0FC
		private static byte[] ce362dad08469800138e4441814ef5cd5(string c62c4d7a60cd5625d5b0123ff80498539)
		{
			BinaryReader binaryReader = new BinaryReader(File.OpenRead(c62c4d7a60cd5625d5b0123ff80498539));
			byte[] result;
			try
			{
				result = binaryReader.ReadBytes(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8596));
			}
			finally
			{
				if (binaryReader != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.ce362dad08469800138e4441814ef5cd5(string)).MethodHandle;
					}
					((IDisposable)binaryReader).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001FF5C File Offset: 0x0001E15C
		private static int[,] caf1f25527c572731e866005deefb2e2a(int[,] c82dd34236c6c1a53878feade40e0b3a1, int c5db06f710879d10bd98fa2c1adf0deb8)
		{
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8600);
			int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8604);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8608); i < c5db06f710879d10bd98fa2c1adf0deb8; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8676))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8612); j < c5db06f710879d10bd98fa2c1adf0deb8 - i; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8624))
				{
					if (c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8616), j] > num)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.caf1f25527c572731e866005deefb2e2a(int[,], int)).MethodHandle;
						}
						num = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8620), j];
						num2 = j;
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
				int num3 = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8628), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8632)];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8636), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8640)] = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8644), num2];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8648), num2] = num3;
				num3 = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8652), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8656)];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8660), c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8664)] = c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8668), num2];
				c82dd34236c6c1a53878feade40e0b3a1[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8672), num2] = num3;
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

		// Token: 0x06000485 RID: 1157 RVA: 0x000200E8 File Offset: 0x0001E2E8
		private static int[] caf1f25527c572731e866005deefb2e2a(int[] c82dd34236c6c1a53878feade40e0b3a1, int c5db06f710879d10bd98fa2c1adf0deb8)
		{
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8680);
			int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8684);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8688); i < c5db06f710879d10bd98fa2c1adf0deb8; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8708))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8692); j < c5db06f710879d10bd98fa2c1adf0deb8 - i; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8696))
				{
					if (c82dd34236c6c1a53878feade40e0b3a1[j] > num)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.caf1f25527c572731e866005deefb2e2a(int[], int)).MethodHandle;
						}
						num = c82dd34236c6c1a53878feade40e0b3a1[j];
						num2 = j;
					}
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
				int num3 = c82dd34236c6c1a53878feade40e0b3a1[c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8700)];
				c82dd34236c6c1a53878feade40e0b3a1[c5db06f710879d10bd98fa2c1adf0deb8 - i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8704)] = c82dd34236c6c1a53878feade40e0b3a1[num2];
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

		// Token: 0x04000274 RID: 628
		public const int cfe18f8bc1847cc07490928f559b3ec23 = 512;

		// Token: 0x04000275 RID: 629
		public const int c1da12f26dea52f19ec1cd0233934f050 = 262144000;

		// Token: 0x04000276 RID: 630
		public const int c835fd3db442ba83ed5ff9b490a1ad282 = 32768;

		// Token: 0x04000277 RID: 631
		public static bool ca32d5aa7f4c11b7e56851254a695a0ac = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8712) != 0;

		// Token: 0x04000278 RID: 632
		public static string c892281e6812e57d545409e1054a3fa54 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1567);

		// Token: 0x04000279 RID: 633
		public static string c6bfb275608269b46a1d7dccf02be88be = "";

		// Token: 0x0400027A RID: 634
		private static readonly byte[] c97b154fd19344a2744f4bc20e1322144 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8716));

		// Token: 0x0400027B RID: 635
		private static readonly byte[] cc6593e7abf59045117b5eaae6e486653;

		// Token: 0x02000131 RID: 305
		[CompilerGenerated]
		private sealed class c587932ee94a2bd6bca978c6b3a2320b2
		{
			// Token: 0x06000920 RID: 2336 RVA: 0x0005E658 File Offset: 0x0005C858
			internal void c8a0baf45726075952376a6489b0849bd()
			{
				List<string> list = new List<string>();
				int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30500);
				while (File.Exists(Path.Combine(cf89c9e6d7b0e5b1763ed7cc912ae0888.c6bfb275608269b46a1d7dccf02be88be, c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98699), string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1499), num += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30504)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1512)))))
				{
					list.Add(Path.Combine(cf89c9e6d7b0e5b1763ed7cc912ae0888.c6bfb275608269b46a1d7dccf02be88be, c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98699), string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1499), num), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1512))));
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf89c9e6d7b0e5b1763ed7cc912ae0888.c587932ee94a2bd6bca978c6b3a2320b2.c8a0baf45726075952376a6489b0849bd()).MethodHandle;
				}
				IEnumerable<string> source = list;
				Func<string, Stream> selector;
				if ((selector = cf89c9e6d7b0e5b1763ed7cc912ae0888.<>c.c315b26ee101a00dd7c1dbaa3c5b7ce73) == null)
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
					selector = (cf89c9e6d7b0e5b1763ed7cc912ae0888.<>c.c315b26ee101a00dd7c1dbaa3c5b7ce73 = new Func<string, Stream>(cf89c9e6d7b0e5b1763ed7cc912ae0888.<>c.cdfab1996eb8651828de2a4469aa3481e.c01c1efc55c86c02af2cc033e8c2c07a2));
				}
				List<Stream> list2 = source.Select(selector).ToList<Stream>();
				list2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30508)].Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30512), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30516));
				c3391b519887d487f90639994067a0eca c3391b519887d487f90639994067a0eca = new c3391b519887d487f90639994067a0eca(list2);
				try
				{
					cf89c9e6d7b0e5b1763ed7cc912ae0888.ceb1c46f076bd981606ebddc12d96d32a(c3391b519887d487f90639994067a0eca, this.c93624d72c8f5f77734cc8379342e5b14, this.c10e40f176a7c45a7e75eade1e2b60989, File.ReadAllBytes(Path.Combine(cf89c9e6d7b0e5b1763ed7cc912ae0888.c6bfb275608269b46a1d7dccf02be88be, cf89c9e6d7b0e5b1763ed7cc912ae0888.c892281e6812e57d545409e1054a3fa54)), cf89c9e6d7b0e5b1763ed7cc912ae0888.c6f45d37cbdd36668756d2f723a7fa069(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30520)));
				}
				finally
				{
					if (c3391b519887d487f90639994067a0eca != null)
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
						((IDisposable)c3391b519887d487f90639994067a0eca).Dispose();
					}
				}
				using (List<string>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string path = enumerator.Current;
						File.Delete(path);
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
				cf89c9e6d7b0e5b1763ed7cc912ae0888.c2169a03f6cbfa0e350dc62c7b054927c(this.c93624d72c8f5f77734cc8379342e5b14, Path.Combine(cf89c9e6d7b0e5b1763ed7cc912ae0888.c6bfb275608269b46a1d7dccf02be88be, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98708)), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30524) != 0);
				File.Delete(this.c93624d72c8f5f77734cc8379342e5b14);
			}

			// Token: 0x040006AE RID: 1710
			public string c93624d72c8f5f77734cc8379342e5b14;

			// Token: 0x040006AF RID: 1711
			public byte[] c10e40f176a7c45a7e75eade1e2b60989;
		}
	}
}
