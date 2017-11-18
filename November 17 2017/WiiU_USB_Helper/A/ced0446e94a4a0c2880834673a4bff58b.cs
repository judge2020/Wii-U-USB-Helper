using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace A
{
	// Token: 0x02000023 RID: 35
	public static class ced0446e94a4a0c2880834673a4bff58b
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000088D8 File Offset: 0x00006AD8
		public static ulong c1b35eb4afe78a76f3cc20ee16741e8dc(this ulong c7c2b264dabe6af7c14e50f838643b4e1, uint c39db3508b7db8c34106016ab020464d2)
		{
			if (c7c2b264dabe6af7c14e50f838643b4e1 % (ulong)c39db3508b7db8c34106016ab020464d2 == 0UL)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ulong.c1b35eb4afe78a76f3cc20ee16741e8dc(uint)).MethodHandle;
				}
				return c7c2b264dabe6af7c14e50f838643b4e1;
			}
			return (c7c2b264dabe6af7c14e50f838643b4e1 / (ulong)c39db3508b7db8c34106016ab020464d2 + (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2908))) * (ulong)c39db3508b7db8c34106016ab020464d2;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008914 File Offset: 0x00006B14
		public static byte[] ca580c34a1cbbccc3f8ca98b598c4a2a4(this Stream c73f1dae9f6f82bed94bc7a9992b25324, int cc076fd568f4bb05b6e433b9eb4ab0a25, Action<int> cbdc7cc0d6622352a1f9b4e17711e1ff8 = null)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cc076fd568f4bb05b6e433b9eb4ab0a25);
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2912);
			do
			{
				int num2 = c73f1dae9f6f82bed94bc7a9992b25324.Read(array, num, cc076fd568f4bb05b6e433b9eb4ab0a25 - num);
				if (num2 == 0)
				{
					return array;
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(Stream.ca580c34a1cbbccc3f8ca98b598c4a2a4(int, Action<int>)).MethodHandle;
				}
				num += num2;
				if (cbdc7cc0d6622352a1f9b4e17711e1ff8 != null)
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
					cbdc7cc0d6622352a1f9b4e17711e1ff8(num2);
				}
			}
			while (num < cc076fd568f4bb05b6e433b9eb4ab0a25);
			for (;;)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			return array;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008980 File Offset: 0x00006B80
		public static void ca580c34a1cbbccc3f8ca98b598c4a2a4(this Stream c73f1dae9f6f82bed94bc7a9992b25324, byte[] c9a7c261c312ca4cca339a489147a87a1, int cc076fd568f4bb05b6e433b9eb4ab0a25)
		{
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2916);
			do
			{
				int num2 = c73f1dae9f6f82bed94bc7a9992b25324.Read(c9a7c261c312ca4cca339a489147a87a1, num, cc076fd568f4bb05b6e433b9eb4ab0a25 - num);
				if (num2 == 0)
				{
					return;
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(Stream.ca580c34a1cbbccc3f8ca98b598c4a2a4(byte[], int)).MethodHandle;
				}
				num += num2;
			}
			while (num < cc076fd568f4bb05b6e433b9eb4ab0a25);
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

		// Token: 0x060000B1 RID: 177 RVA: 0x000089D0 File Offset: 0x00006BD0
		public static string c9923984bbcd35cab01b4f524fb06ba16(this string cad48e7cec482eb202b35baba9979de2f)
		{
			return Regex.Replace(cad48e7cec482eb202b35baba9979de2f, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1786), "");
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000089F8 File Offset: 0x00006BF8
		public static string c101c3ac509a256ea4f07e70c3d1ca1a4(this string c7c2b264dabe6af7c14e50f838643b4e1, string[] c1a1c44fa6c68b6d8fbdef63e5723a5ef, string c4720c572d777f5602bfd2394f21e0d1b)
		{
			ced0446e94a4a0c2880834673a4bff58b.cd19304438f2b300be3d8799120cd3365 cd19304438f2b300be3d8799120cd = new ced0446e94a4a0c2880834673a4bff58b.cd19304438f2b300be3d8799120cd3365();
			cd19304438f2b300be3d8799120cd.c4720c572d777f5602bfd2394f21e0d1b = c4720c572d777f5602bfd2394f21e0d1b;
			return c1a1c44fa6c68b6d8fbdef63e5723a5ef.Aggregate(c7c2b264dabe6af7c14e50f838643b4e1, new Func<string, string, string>(cd19304438f2b300be3d8799120cd.c0d29dd47f41cf5a0ba3da0e82acc18a2));
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00008A28 File Offset: 0x00006C28
		public static string c101c3ac509a256ea4f07e70c3d1ca1a4(this string c7c2b264dabe6af7c14e50f838643b4e1, char[] c1a1c44fa6c68b6d8fbdef63e5723a5ef, char c4720c572d777f5602bfd2394f21e0d1b)
		{
			ced0446e94a4a0c2880834673a4bff58b.c2d2b1ae9a310d12b9a21ac381158d895 c2d2b1ae9a310d12b9a21ac381158d = new ced0446e94a4a0c2880834673a4bff58b.c2d2b1ae9a310d12b9a21ac381158d895();
			c2d2b1ae9a310d12b9a21ac381158d.c4720c572d777f5602bfd2394f21e0d1b = c4720c572d777f5602bfd2394f21e0d1b;
			return c1a1c44fa6c68b6d8fbdef63e5723a5ef.Aggregate(c7c2b264dabe6af7c14e50f838643b4e1, new Func<string, char, string>(c2d2b1ae9a310d12b9a21ac381158d.c0d29dd47f41cf5a0ba3da0e82acc18a2));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008A58 File Offset: 0x00006C58
		public static string c5d5b270be5852dca434f488b5043605c(this string c7c2b264dabe6af7c14e50f838643b4e1)
		{
			return c7c2b264dabe6af7c14e50f838643b4e1.Replace(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1801), Environment.NewLine, Environment.NewLine), string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1814), Environment.NewLine));
		}

		// Token: 0x020000F0 RID: 240
		[CompilerGenerated]
		private sealed class cd19304438f2b300be3d8799120cd3365
		{
			// Token: 0x06000862 RID: 2146 RVA: 0x0005AAB0 File Offset: 0x00058CB0
			internal string c0d29dd47f41cf5a0ba3da0e82acc18a2(string c8fce7316339febf2617106c18d157d94, string cb632c138aed494261b4e9fc76a1d7eda)
			{
				return c8fce7316339febf2617106c18d157d94.Replace(cb632c138aed494261b4e9fc76a1d7eda, this.c4720c572d777f5602bfd2394f21e0d1b);
			}

			// Token: 0x040005E8 RID: 1512
			public string c4720c572d777f5602bfd2394f21e0d1b;
		}

		// Token: 0x020000F1 RID: 241
		[CompilerGenerated]
		private sealed class c2d2b1ae9a310d12b9a21ac381158d895
		{
			// Token: 0x06000864 RID: 2148 RVA: 0x0005AAE0 File Offset: 0x00058CE0
			internal string c0d29dd47f41cf5a0ba3da0e82acc18a2(string c8fce7316339febf2617106c18d157d94, char cb632c138aed494261b4e9fc76a1d7eda)
			{
				return c8fce7316339febf2617106c18d157d94.Replace(cb632c138aed494261b4e9fc76a1d7eda, this.c4720c572d777f5602bfd2394f21e0d1b);
			}

			// Token: 0x040005E9 RID: 1513
			public char c4720c572d777f5602bfd2394f21e0d1b;
		}
	}
}
