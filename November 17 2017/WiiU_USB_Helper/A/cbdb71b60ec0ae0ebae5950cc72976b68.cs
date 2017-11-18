using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace A
{
	// Token: 0x020000A7 RID: 167
	public static class cbdb71b60ec0ae0ebae5950cc72976b68
	{
		// Token: 0x06000587 RID: 1415 RVA: 0x00024884 File Offset: 0x00022A84
		public static bool c8a36cb9052e7932c0f930a1ccef40254(Bitmap cb6f3687efcc8c16c7732aba51bd9d607, Stream c1139a34319f573b5050d06fd97623321, int c5db06f710879d10bd98fa2c1adf0deb8 = 16, bool c9e1d13b088ec66a8939e93461cfe1714 = false)
		{
			if (cb6f3687efcc8c16c7732aba51bd9d607 == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cbdb71b60ec0ae0ebae5950cc72976b68.c8a36cb9052e7932c0f930a1ccef40254(Bitmap, Stream, int, bool)).MethodHandle;
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9864) != 0;
			}
			float num = (float)c5db06f710879d10bd98fa2c1adf0deb8;
			float num2 = (float)c5db06f710879d10bd98fa2c1adf0deb8;
			if (c9e1d13b088ec66a8939e93461cfe1714)
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
				if (cb6f3687efcc8c16c7732aba51bd9d607.Width > cb6f3687efcc8c16c7732aba51bd9d607.Height)
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
					num2 = (float)cb6f3687efcc8c16c7732aba51bd9d607.Height / (float)cb6f3687efcc8c16c7732aba51bd9d607.Width * (float)c5db06f710879d10bd98fa2c1adf0deb8;
				}
				else
				{
					num = (float)cb6f3687efcc8c16c7732aba51bd9d607.Width / (float)cb6f3687efcc8c16c7732aba51bd9d607.Height * (float)c5db06f710879d10bd98fa2c1adf0deb8;
				}
			}
			Bitmap bitmap = new Bitmap(cb6f3687efcc8c16c7732aba51bd9d607, new Size((int)num, (int)num2));
			if (bitmap == null)
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
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9868) != 0;
			}
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				bitmap.Save(memoryStream, ImageFormat.Png);
				BinaryWriter binaryWriter = new BinaryWriter(c1139a34319f573b5050d06fd97623321);
				if (c1139a34319f573b5050d06fd97623321 != null)
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
					if (binaryWriter != null)
					{
						binaryWriter.Write((byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9876));
						binaryWriter.Write((byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9880));
						binaryWriter.Write((short)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9884));
						binaryWriter.Write((short)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9888));
						binaryWriter.Write((byte)num);
						binaryWriter.Write((byte)num2);
						binaryWriter.Write((byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9892));
						binaryWriter.Write((byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9896));
						binaryWriter.Write((short)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9900));
						binaryWriter.Write((short)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9904));
						binaryWriter.Write((int)memoryStream.Length);
						binaryWriter.Write(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9908));
						binaryWriter.Write(memoryStream.ToArray());
						binaryWriter.Flush();
						goto IL_1D7;
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
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9872) != 0;
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
			IL_1D7:
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9912) != 0;
		}
	}
}
