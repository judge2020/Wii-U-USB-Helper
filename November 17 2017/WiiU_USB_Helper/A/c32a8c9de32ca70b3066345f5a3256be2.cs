using System;
using System.IO;

namespace A
{
	// Token: 0x0200000A RID: 10
	public static class c32a8c9de32ca70b3066345f5a3256be2
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002D8C File Offset: 0x00000F8C
		public static ulong c79f39c7b8facf7b3a81962666364425c(string c70f1064222fa2c281974a7b7a2035e61)
		{
			ulong num = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(160));
			try
			{
				string[] files = Directory.GetFiles(c70f1064222fa2c281974a7b7a2035e61, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(898), (SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(164));
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(168); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(files); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(172))
				{
					string fileName = files[i];
					num += (ulong)new FileInfo(fileName).Length;
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c32a8c9de32ca70b3066345f5a3256be2.c79f39c7b8facf7b3a81962666364425c(string)).MethodHandle;
				}
			}
			catch
			{
			}
			return num;
		}

		// Token: 0x0400000E RID: 14
		public const int ce7c60a72b2550b1593ca731447a80b68 = 3000000;
	}
}
