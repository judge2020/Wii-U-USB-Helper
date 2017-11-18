using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace A
{
	// Token: 0x02000014 RID: 20
	internal class c89d5f69592ed6ff3f4bcbdf0f7037053
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00003B30 File Offset: 0x00001D30
		static c89d5f69592ed6ff3f4bcbdf0f7037053()
		{
			c89d5f69592ed6ff3f4bcbdf0f7037053.c14dfdc85800157019e7dd884bf04d960 = int.MaxValue;
			c89d5f69592ed6ff3f4bcbdf0f7037053.cd40283a4b246c6f84e9e37ff2511d0c2 = int.MinValue;
			c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996 = new MemoryStream(0);
			c89d5f69592ed6ff3f4bcbdf0f7037053.c0587223a24e4d62e7b3549cbe842f85b = new MemoryStream(0);
			c89d5f69592ed6ff3f4bcbdf0f7037053.c054b8474782b4bef5c5a62314db61034 = new object();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003B9C File Offset: 0x00001D9C
		private static string c7d47f21a6884443b03f611284654298e(Assembly cef915bfc85cde811eb7a4f50b9498613)
		{
			string text = cef915bfc85cde811eb7a4f50b9498613.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c89d5f69592ed6ff3f4bcbdf0f7037053.c7d47f21a6884443b03f611284654298e(Assembly)).MethodHandle;
				}
				text = text.Substring(0, num);
			}
			return text;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003BE0 File Offset: 0x00001DE0
		private static byte[] c29cdac8057cbee305a5e99e172c69a1f(Assembly cef915bfc85cde811eb7a4f50b9498613)
		{
			try
			{
				string fullName = cef915bfc85cde811eb7a4f50b9498613.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c89d5f69592ed6ff3f4bcbdf0f7037053.c29cdac8057cbee305a5e99e172c69a1f(Assembly)).MethodHandle;
					}
					num = fullName.IndexOf("publickeytoken=");
				}
				if (num < 0)
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
					return c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
				}
				num += 15;
				if (fullName[num] != 'n')
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
					if (fullName[num] != 'N')
					{
						string s = fullName.Substring(num, 16);
						long value = long.Parse(s, NumberStyles.HexNumber);
						byte[] bytes = BitConverter.GetBytes(value);
						Array.Reverse(bytes);
						return bytes;
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
				return c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003CC8 File Offset: 0x00001EC8
		internal static byte[] cbb2323ac68bfb13b5b9c9b586e931cf5(Stream c4ac53312696a695598f597ba1b30f186)
		{
			byte[] result;
			lock (c89d5f69592ed6ff3f4bcbdf0f7037053.c054b8474782b4bef5c5a62314db61034)
			{
				result = c89d5f69592ed6ff3f4bcbdf0f7037053.c0672414e5d09571e91128867e2e80860(97L, c4ac53312696a695598f597ba1b30f186);
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003D08 File Offset: 0x00001F08
		internal static byte[] c401a548304a40239ab7b93ba833c083c(long c705299e88d7d7af8d0681f39338861e6, Stream c4ac53312696a695598f597ba1b30f186)
		{
			byte[] result;
			try
			{
				result = c89d5f69592ed6ff3f4bcbdf0f7037053.cbb2323ac68bfb13b5b9c9b586e931cf5(c4ac53312696a695598f597ba1b30f186);
			}
			catch (HostProtectionException)
			{
				result = c89d5f69592ed6ff3f4bcbdf0f7037053.c0672414e5d09571e91128867e2e80860(97L, c4ac53312696a695598f597ba1b30f186);
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003D40 File Offset: 0x00001F40
		internal static byte[] c0672414e5d09571e91128867e2e80860(long c705299e88d7d7af8d0681f39338861e6, Stream c4ac53312696a695598f597ba1b30f186)
		{
			Stream stream = c4ac53312696a695598f597ba1b30f186;
			MemoryStream cab55a050df275722227783d6686266c = c335974ac49c4dace165f55e8c9d94b68.cab55a050df275722227783d6686266c9;
			for (int i = 1; i < 4; i++)
			{
				c4ac53312696a695598f597ba1b30f186.ReadByte();
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
				RuntimeMethodHandle runtimeMethodHandle = methodof(c89d5f69592ed6ff3f4bcbdf0f7037053.c0672414e5d09571e91128867e2e80860(long, Stream)).MethodHandle;
			}
			ushort num = (ushort)c4ac53312696a695598f597ba1b30f186.ReadByte();
			num = ~num;
			if ((num & 2) != 0)
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
				DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(8);
				c4ac53312696a695598f597ba1b30f186.Read(array, 0, 8);
				descryptoServiceProvider.IV = array;
				byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(8);
				c4ac53312696a695598f597ba1b30f186.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				for (int j = 0; j < (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array3); j++)
				{
					byte b = array3[j];
					if (b != 0)
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
						flag = false;
						IL_D2:
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
							array2 = c89d5f69592ed6ff3f4bcbdf0f7037053.c29cdac8057cbee305a5e99e172c69a1f(Assembly.GetExecutingAssembly());
						}
						descryptoServiceProvider.Key = array2;
						if (c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996 == null)
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
							if (c89d5f69592ed6ff3f4bcbdf0f7037053.c14dfdc85800157019e7dd884bf04d960 == 2147483647)
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
								c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996.Capacity = (int)c4ac53312696a695598f597ba1b30f186.Length;
							}
							else
							{
								c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996.Capacity = c89d5f69592ed6ff3f4bcbdf0f7037053.c14dfdc85800157019e7dd884bf04d960;
							}
						}
						c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996.Position = 0L;
						ICryptoTransform cryptoTransform = descryptoServiceProvider.CreateDecryptor();
						int inputBlockSize = cryptoTransform.InputBlockSize;
						int outputBlockSize = cryptoTransform.OutputBlockSize;
						byte[] array4 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cryptoTransform.OutputBlockSize);
						byte[] array5 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cryptoTransform.InputBlockSize);
						int num2 = (int)c4ac53312696a695598f597ba1b30f186.Position;
						while ((long)(num2 + inputBlockSize) < c4ac53312696a695598f597ba1b30f186.Length)
						{
							c4ac53312696a695598f597ba1b30f186.Read(array5, 0, inputBlockSize);
							int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
							c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996.Write(array4, 0, count);
							num2 += inputBlockSize;
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
						c4ac53312696a695598f597ba1b30f186.Read(array5, 0, (int)(c4ac53312696a695598f597ba1b30f186.Length - (long)num2));
						byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(c4ac53312696a695598f597ba1b30f186.Length - (long)num2));
						c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996.Write(array6, 0, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array6));
						stream = c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996;
						stream.Position = 0L;
						cab55a050df275722227783d6686266c = c89d5f69592ed6ff3f4bcbdf0f7037053.cef6b5aa3ab29d75822b0eb43df610996;
						goto IL_251;
					}
				}
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					goto IL_D2;
				}
			}
			IL_251:
			if ((num & 8) != 0)
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
				if (c89d5f69592ed6ff3f4bcbdf0f7037053.c0587223a24e4d62e7b3549cbe842f85b == null)
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
					if (c89d5f69592ed6ff3f4bcbdf0f7037053.cd40283a4b246c6f84e9e37ff2511d0c2 == -2147483648)
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
						c89d5f69592ed6ff3f4bcbdf0f7037053.c0587223a24e4d62e7b3549cbe842f85b.Capacity = (int)stream.Length * 2;
					}
					else
					{
						c89d5f69592ed6ff3f4bcbdf0f7037053.c0587223a24e4d62e7b3549cbe842f85b.Capacity = c89d5f69592ed6ff3f4bcbdf0f7037053.cd40283a4b246c6f84e9e37ff2511d0c2;
					}
				}
				c89d5f69592ed6ff3f4bcbdf0f7037053.c0587223a24e4d62e7b3549cbe842f85b.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(num3);
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer, 0, num3);
					if (num4 > 0)
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
						c89d5f69592ed6ff3f4bcbdf0f7037053.c0587223a24e4d62e7b3549cbe842f85b.Write(buffer, 0, num4);
					}
				}
				while (num4 >= num3);
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				cab55a050df275722227783d6686266c = c89d5f69592ed6ff3f4bcbdf0f7037053.c0587223a24e4d62e7b3549cbe842f85b;
			}
			if (cab55a050df275722227783d6686266c != null)
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
				return cab55a050df275722227783d6686266c.ToArray();
			}
			byte[] array7 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)(checked((IntPtr)(unchecked(c4ac53312696a695598f597ba1b30f186.Length - c4ac53312696a695598f597ba1b30f186.Position)))));
			c4ac53312696a695598f597ba1b30f186.Read(array7, 0, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array7));
			return array7;
		}

		// Token: 0x04000023 RID: 35
		private static readonly object c054b8474782b4bef5c5a62314db61034;

		// Token: 0x04000024 RID: 36
		private static readonly int c14dfdc85800157019e7dd884bf04d960;

		// Token: 0x04000025 RID: 37
		private static readonly int cd40283a4b246c6f84e9e37ff2511d0c2;

		// Token: 0x04000026 RID: 38
		private static readonly MemoryStream cef6b5aa3ab29d75822b0eb43df610996 = c335974ac49c4dace165f55e8c9d94b68.cab55a050df275722227783d6686266c9;

		// Token: 0x04000027 RID: 39
		private static readonly MemoryStream c0587223a24e4d62e7b3549cbe842f85b = c335974ac49c4dace165f55e8c9d94b68.cab55a050df275722227783d6686266c9;

		// Token: 0x04000028 RID: 40
		private static readonly byte c705299e88d7d7af8d0681f39338861e6;
	}
}
