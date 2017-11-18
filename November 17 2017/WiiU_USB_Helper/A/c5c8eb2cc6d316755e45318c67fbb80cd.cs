using System;
using System.IO;
using System.Runtime.CompilerServices;
using Alphaleonis.Win32.Filesystem;

namespace A
{
	// Token: 0x02000094 RID: 148
	internal class c5c8eb2cc6d316755e45318c67fbb80cd : cf7c96734e58d8de9864e1ea854bc2b7b
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00021E50 File Offset: 0x00020050
		public c5c8eb2cc6d316755e45318c67fbb80cd(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, bool c07532d90fa519783a3736afc4d48beb9)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9252));
			RuntimeHelpers.InitializeArray(array, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.cec68662f497c29da77b56e33e9ed18c3).FieldHandle);
			this.c78108154432f6e416ebff67e346001ca = array;
			base..ctor(c804bc52f7f79bffee6fd394ef382eb76, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41521), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41532), c07532d90fa519783a3736afc4d48beb9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9256) != 0);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00021EAC File Offset: 0x000200AC
		public override bool cab66f65884757b260d3cede7f6adcb72()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9176) != 0;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00021EC4 File Offset: 0x000200C4
		public override string c9ad9e3ddcd7e5e324cd01b2dfad9f78d()
		{
			return Path.Combine(base.cbc2836ea62c32bc8df1f63f72af3a491, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41487));
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00021EEC File Offset: 0x000200EC
		public override bool c1313a3694d9d4cbd109dd5b1b1fe94b1()
		{
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9180) != 0;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00021F04 File Offset: 0x00020104
		public override string c010f80182206bd1b4a523f2e99f7657a()
		{
			return Path.Combine(base.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41506));
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00021F2C File Offset: 0x0002012C
		protected override void c0af5c4e148a68a530b83d61893c72e0e(bool c3c7497942acfe55b365013a6254dd980)
		{
			if (!File.Exists(this.c010f80182206bd1b4a523f2e99f7657a()))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c5c8eb2cc6d316755e45318c67fbb80cd.c0af5c4e148a68a530b83d61893c72e0e(bool)).MethodHandle;
				}
				base.c4b1d0ff2a4e5958927cf4a855fe65dab(c3c7497942acfe55b365013a6254dd980);
				BinaryReader binaryReader = new BinaryReader(File.Open(base.c2bde6b24c3a9f7e1c4da8f930b4419a9(), (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9184)));
				try
				{
					FileStream fileStream = File.Create(this.c010f80182206bd1b4a523f2e99f7657a());
					try
					{
						cf7c96734e58d8de9864e1ea854bc2b7b.c2b2a1122416abf41d177f55ba843a0cc(binaryReader.BaseStream, this.c78108154432f6e416ebff67e346001ca);
						binaryReader.BaseStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9188), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9192));
						byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9196));
						binaryReader.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9200), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9204));
						Array.Reverse(array);
						long num = (long)((int)BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9208)) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9212) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9216));
						binaryReader.BaseStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9220), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9224));
						Stream stream = fileStream;
						byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9228));
						RuntimeHelpers.InitializeArray(array2, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.cc46f89b08888bb87b87e2b1361fcc5e9).FieldHandle);
						stream.Write(array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9232), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9236));
						byte[] array3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)(checked((IntPtr)num)));
						binaryReader.Read(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9240), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array3));
						fileStream.Write(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9244), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array3));
					}
					finally
					{
						if (fileStream != null)
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
			}
			base.c54f221133eb526d693ab1f91ea0d82db(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9248) != 0);
		}

		// Token: 0x04000283 RID: 643
		private readonly byte[] c78108154432f6e416ebff67e346001ca;
	}
}
