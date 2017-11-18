using System;
using System.IO;

namespace A
{
	// Token: 0x0200000F RID: 15
	public static class cd478a04c48829d6f807d37c0e6d1cb58
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00003280 File Offset: 0x00001480
		public static byte[] cb35de7f46e1bfb93038835711aa19705(this BinaryReader c8fc75a6183c2bf461cb7ac2efd645cf4, int c0aea6afefa0b359db23b567ca305333c)
		{
			byte[] array = c8fc75a6183c2bf461cb7ac2efd645cf4.ReadBytes(c0aea6afefa0b359db23b567ca305333c);
			if ((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array) != c0aea6afefa0b359db23b567ca305333c)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(BinaryReader.cb35de7f46e1bfb93038835711aa19705(int)).MethodHandle;
				}
				throw new EndOfStreamException(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1148), c0aea6afefa0b359db23b567ca305333c, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array)));
			}
			return array;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000032E4 File Offset: 0x000014E4
		public static short c098917df2bc90b8f4a4863b177fb351a(this BinaryReader c8fc75a6183c2bf461cb7ac2efd645cf4)
		{
			return BitConverter.ToInt16(c8fc75a6183c2bf461cb7ac2efd645cf4.cb35de7f46e1bfb93038835711aa19705(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(200)).c82b6cb4fb4558e6fa6a36e2b0c82c6d1(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(204));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000331C File Offset: 0x0000151C
		public static int cf4db36623042c83be97a6ec33e7b6a16(this BinaryReader c8fc75a6183c2bf461cb7ac2efd645cf4)
		{
			return BitConverter.ToInt32(c8fc75a6183c2bf461cb7ac2efd645cf4.cb35de7f46e1bfb93038835711aa19705(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(208)).c82b6cb4fb4558e6fa6a36e2b0c82c6d1(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(212));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003354 File Offset: 0x00001554
		public static ushort cb77856d9a3eaa6df87e1f00bb4fd5167(this BinaryReader c8fc75a6183c2bf461cb7ac2efd645cf4)
		{
			return BitConverter.ToUInt16(c8fc75a6183c2bf461cb7ac2efd645cf4.cb35de7f46e1bfb93038835711aa19705(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(216)).c82b6cb4fb4558e6fa6a36e2b0c82c6d1(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(220));
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000338C File Offset: 0x0000158C
		public static uint c3ec653d42b27774123bc8da327735803(this BinaryReader c8fc75a6183c2bf461cb7ac2efd645cf4)
		{
			return BitConverter.ToUInt32(c8fc75a6183c2bf461cb7ac2efd645cf4.cb35de7f46e1bfb93038835711aa19705(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(224)).c82b6cb4fb4558e6fa6a36e2b0c82c6d1(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(228));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000033C4 File Offset: 0x000015C4
		public static byte[] c82b6cb4fb4558e6fa6a36e2b0c82c6d1(this byte[] c4c8d433ecb1e7f29d5ade708913c0891)
		{
			Array.Reverse(c4c8d433ecb1e7f29d5ade708913c0891);
			return c4c8d433ecb1e7f29d5ade708913c0891;
		}
	}
}
