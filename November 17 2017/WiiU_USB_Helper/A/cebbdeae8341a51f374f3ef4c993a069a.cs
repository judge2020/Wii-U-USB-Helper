using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A
{
	// Token: 0x0200000E RID: 14
	internal class cebbdeae8341a51f374f3ef4c993a069a
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000030B0 File Offset: 0x000012B0
		static cebbdeae8341a51f374f3ef4c993a069a()
		{
			if (cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125 == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cebbdeae8341a51f374f3ef4c993a069a..cctor()).MethodHandle;
				}
				string text = "V2lpVV9VU0JfSGVscGVyJQ==";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125 = c89d5f69592ed6ff3f4bcbdf0f7037053.c401a548304a40239ab7b93ba833c083c(97L, manifestResourceStream);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003130 File Offset: 0x00001330
		internal static int c6bc1c09ec46e3a402ca1f5ca208c573e(int c6d90c75477d966c1350c18dcdfa11588)
		{
			return BitConverter.ToInt32(cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125, c6d90c75477d966c1350c18dcdfa11588);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000314C File Offset: 0x0000134C
		internal static long c2485e25639b965f9b26a461c0945f99a(int c6d90c75477d966c1350c18dcdfa11588)
		{
			return BitConverter.ToInt64(cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125, c6d90c75477d966c1350c18dcdfa11588);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003168 File Offset: 0x00001368
		internal static float cabf61ab14a85b3360133efd96ff22140(int c6d90c75477d966c1350c18dcdfa11588)
		{
			return BitConverter.ToSingle(cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125, c6d90c75477d966c1350c18dcdfa11588);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003184 File Offset: 0x00001384
		internal static double c939ab866f16e312f9914e20d87206d56(int c6d90c75477d966c1350c18dcdfa11588)
		{
			return BitConverter.ToDouble(cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125, c6d90c75477d966c1350c18dcdfa11588);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000031A0 File Offset: 0x000013A0
		internal static void c36d93c177c8976734c00ce47d98f9328(Array cdb862103d49a15aef471e2adba75e6a0, int c6d90c75477d966c1350c18dcdfa11588)
		{
			int num;
			if ((cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & 128) == 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cebbdeae8341a51f374f3ef4c993a069a.c36d93c177c8976734c00ce47d98f9328(Array, int)).MethodHandle;
				}
				num = (int)cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588];
				c6d90c75477d966c1350c18dcdfa11588++;
			}
			else if ((cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & 64) == 0)
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
				num = ((int)cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & -129) << 8;
				num |= (int)cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 1];
				c6d90c75477d966c1350c18dcdfa11588 += 2;
			}
			else
			{
				num = ((int)cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & -193) << 24;
				num |= (int)cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 1] << 16;
				num |= (int)cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 2] << 8;
				num |= (int)cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 3];
				c6d90c75477d966c1350c18dcdfa11588 += 4;
			}
			if (num < 1)
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
				return;
			}
			Buffer.BlockCopy(cebbdeae8341a51f374f3ef4c993a069a.c271a832e629a79991d9eda7a270cb125, c6d90c75477d966c1350c18dcdfa11588, cdb862103d49a15aef471e2adba75e6a0, 0, num);
		}

		// Token: 0x04000014 RID: 20
		internal static readonly byte[] c271a832e629a79991d9eda7a270cb125;

		// Token: 0x04000015 RID: 21
		internal readonly int c705299e88d7d7af8d0681f39338861e6;
	}
}
