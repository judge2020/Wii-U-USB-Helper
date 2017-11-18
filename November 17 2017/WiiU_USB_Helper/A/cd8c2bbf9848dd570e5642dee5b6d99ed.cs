using System;
using System.IO;
using System.Runtime.CompilerServices;
using Alphaleonis.Win32.Filesystem;

namespace A
{
	// Token: 0x02000096 RID: 150
	internal class cd8c2bbf9848dd570e5642dee5b6d99ed : cf7c96734e58d8de9864e1ea854bc2b7b
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x0002232C File Offset: 0x0002052C
		public cd8c2bbf9848dd570e5642dee5b6d99ed(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, bool c07532d90fa519783a3736afc4d48beb9)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9352));
			RuntimeHelpers.InitializeArray(array, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c76142dc84b35b1cce6b53cd6188e99f3).FieldHandle);
			this.cbf102f7273566eb5ed18a59967c5f877 = array;
			base..ctor(c804bc52f7f79bffee6fd394ef382eb76, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41706), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41719), c07532d90fa519783a3736afc4d48beb9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9356) != 0);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00022388 File Offset: 0x00020588
		public override bool cab66f65884757b260d3cede7f6adcb72()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9292) != 0;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000223A0 File Offset: 0x000205A0
		public override string c725acc3eddb72d7ac90f323bc7845e34()
		{
			string c0d6c37d812d5d4b610705a6421056252 = base.c725acc3eddb72d7ac90f323bc7845e34();
			string c0d6c37d812d5d4b610705a64210562522;
			if (!base.FullScreen)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd8c2bbf9848dd570e5642dee5b6d99ed.c725acc3eddb72d7ac90f323bc7845e34()).MethodHandle;
				}
				c0d6c37d812d5d4b610705a64210562522 = "";
			}
			else
			{
				c0d6c37d812d5d4b610705a64210562522 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41320);
			}
			return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, c0d6c37d812d5d4b610705a64210562522);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000223EC File Offset: 0x000205EC
		public override string c9ad9e3ddcd7e5e324cd01b2dfad9f78d()
		{
			return Path.Combine(base.cbc2836ea62c32bc8df1f63f72af3a491, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41670));
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00022414 File Offset: 0x00020614
		public override bool c1313a3694d9d4cbd109dd5b1b1fe94b1()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9296) != 0;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0002242C File Offset: 0x0002062C
		public override string c010f80182206bd1b4a523f2e99f7657a()
		{
			return Path.Combine(base.c4d68e2c283dbf2783383a0a1d0aaa75a, this.cbd119e33552f6e7eda45b0c64e636c3a.caf5c2281268b0d9649319527ceb47238(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41691));
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00022464 File Offset: 0x00020664
		protected override void c0af5c4e148a68a530b83d61893c72e0e(bool c3c7497942acfe55b365013a6254dd980)
		{
			if (!File.Exists(this.c010f80182206bd1b4a523f2e99f7657a()))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd8c2bbf9848dd570e5642dee5b6d99ed.c0af5c4e148a68a530b83d61893c72e0e(bool)).MethodHandle;
				}
				base.c4b1d0ff2a4e5958927cf4a855fe65dab(c3c7497942acfe55b365013a6254dd980);
				BinaryReader binaryReader = new BinaryReader(File.Open(base.c2bde6b24c3a9f7e1c4da8f930b4419a9(), (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9300)));
				try
				{
					FileStream fileStream = File.Create(this.c010f80182206bd1b4a523f2e99f7657a());
					try
					{
						cf7c96734e58d8de9864e1ea854bc2b7b.c2b2a1122416abf41d177f55ba843a0cc(binaryReader.BaseStream, this.cbf102f7273566eb5ed18a59967c5f877);
						binaryReader.BaseStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9304), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9308));
						byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9312));
						binaryReader.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9316), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9320));
						Array.Reverse(array);
						IntPtr intPtr = (IntPtr)((long)((int)BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9324)) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9328)));
						binaryReader.BaseStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9332), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9336));
						byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)intPtr);
						binaryReader.Read(array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9340), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array2));
						fileStream.Write(array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9344), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array2));
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
			base.c54f221133eb526d693ab1f91ea0d82db(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9348) != 0);
		}

		// Token: 0x04000284 RID: 644
		private readonly byte[] cbf102f7273566eb5ed18a59967c5f877;
	}
}
