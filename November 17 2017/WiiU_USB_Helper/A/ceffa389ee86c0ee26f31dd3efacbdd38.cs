using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A
{
	// Token: 0x02000010 RID: 16
	internal class ceffa389ee86c0ee26f31dd3efacbdd38
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000033D8 File Offset: 0x000015D8
		static ceffa389ee86c0ee26f31dd3efacbdd38()
		{
			if (ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125 == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ceffa389ee86c0ee26f31dd3efacbdd38..cctor()).MethodHandle;
				}
				string text = "V2lpVV9VU0JfSGVscGVyJA==";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125 = c89d5f69592ed6ff3f4bcbdf0f7037053.c401a548304a40239ab7b93ba833c083c(97L, manifestResourceStream);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003458 File Offset: 0x00001658
		internal static string c5dd75c94760bfb37727a44ddc794d278(int c6d90c75477d966c1350c18dcdfa11588)
		{
			int num;
			if ((ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & 128) == 0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(int)).MethodHandle;
				}
				num = (int)ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588];
				c6d90c75477d966c1350c18dcdfa11588++;
			}
			else if ((ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & 64) == 0)
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
				num = ((int)ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & -129) << 8;
				num |= (int)ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 1];
				c6d90c75477d966c1350c18dcdfa11588 += 2;
			}
			else
			{
				num = ((int)ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588] & -193) << 24;
				num |= (int)ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 1] << 16;
				num |= (int)ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 2] << 8;
				num |= (int)ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125[c6d90c75477d966c1350c18dcdfa11588 + 3];
				c6d90c75477d966c1350c18dcdfa11588 += 4;
			}
			if (num < 1)
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
				return string.Empty;
			}
			string @string = Encoding.Unicode.GetString(ceffa389ee86c0ee26f31dd3efacbdd38.c271a832e629a79991d9eda7a270cb125, c6d90c75477d966c1350c18dcdfa11588, num);
			return string.Intern(@string);
		}

		// Token: 0x04000016 RID: 22
		internal static readonly byte[] c271a832e629a79991d9eda7a270cb125;
	}
}
