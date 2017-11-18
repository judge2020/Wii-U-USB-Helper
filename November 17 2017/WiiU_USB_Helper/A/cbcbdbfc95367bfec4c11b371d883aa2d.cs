using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using NusHelper;

namespace A
{
	// Token: 0x0200007A RID: 122
	public sealed class cbcbdbfc95367bfec4c11b371d883aa2d : IDisposable
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0001736C File Offset: 0x0001556C
		public static byte[] c7c9e64eb219414d7c09bdb5b31c98d84
		{
			get
			{
				return c078ad73b059127d18da3574cc8cee77b.c2b8a70cc72f6f4176d96111a189b667d;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00017380 File Offset: 0x00015580
		public byte[] Certificate1 { get; } = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6128));

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00017394 File Offset: 0x00015594
		public byte[] Certificate2 { get; } = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6132));

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000173A8 File Offset: 0x000155A8
		// (set) Token: 0x06000376 RID: 886 RVA: 0x000173C4 File Offset: 0x000155C4
		public cd161c587b229cb9747bf073c6e98b0b9[] ca41cd3b028585a369298639868832973
		{
			get
			{
				return this.c02d236f30e203f7ad2e0a29221eb04d7.ToArray();
			}
			set
			{
				this.c02d236f30e203f7ad2e0a29221eb04d7 = new List<cd161c587b229cb9747bf073c6e98b0b9>(value);
				this.NumOfContents = (ushort)((int)c6039f0790413b5e04707059b16777215.cfeb04651f165d0166e7c10ab1acf8b28(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000377 RID: 887 RVA: 0x000173F0 File Offset: 0x000155F0
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00017404 File Offset: 0x00015604
		public ushort NumOfContents { get; private set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00017418 File Offset: 0x00015618
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0001742C File Offset: 0x0001562C
		public ulong TitleId { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00017440 File Offset: 0x00015640
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00017454 File Offset: 0x00015654
		public ushort TitleVersion { get; set; }

		// Token: 0x0600037D RID: 893 RVA: 0x00017468 File Offset: 0x00015668
		private void cc45242a6bfb904bfaee72c49be80e3d3(Stream c21f2904773eb8a90fbf89a701a12ff1f, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			c21f2904773eb8a90fbf89a701a12ff1f.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5860), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5864));
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5868));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5872), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5876));
			this.cd40e90e41f0d55bd91526fa91bf126e1 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5880)));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(this.c6d8263cd82dd2c7e5e2d10e0b598b5bb, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5884), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.c6d8263cd82dd2c7e5e2d10e0b598b5bb));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(this.ca71f41bee74122c1cd3d529695502221, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5888), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.ca71f41bee74122c1cd3d529695502221));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(this.c81661f7e6893011ccd7398cab0c2bdb1, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5892), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.c81661f7e6893011ccd7398cab0c2bdb1));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5896), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5900));
			this.c4035753616cbdf1ac123b7183bf2b112 = array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5904)];
			this.c99d18b985796ff7de8071cdbe64d17f8 = array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5908)];
			this.cdc6c8af27d850c8d1aca20796dac2bbb = array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5912)];
			this.c82a30178fe60f52988d186860151ff20 = array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5916)];
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5920), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5924));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5928), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5932));
			this.TitleId = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt64(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5936)));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5940), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5944));
			this.c85a9f1fd52b11c4c7b31217c482a3e08 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5948)));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5952), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5956));
			this.cb641727e9d4aaba1e3f5f87ed2d9de1a = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5960)));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5964), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5968));
			this.cc59fdfacadc539774e0000d4479405c0 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5972)));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5976), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5980));
			this.c692cc2cd6b2479b444c984d25e25f082 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5984)));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(this.cceb58a567da3955f65dd8980b8581b7c, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5988), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.cceb58a567da3955f65dd8980b8581b7c));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5992), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5996));
			this.c98644df94eb0f65a4150303b6bd422f8 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6000)));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6004), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6008));
			this.TitleVersion = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6012)));
			this.NumOfContents = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6016)));
			this.c297d8fe7cc5360250337b71fbdb95fc4 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6020)));
			this.c7d19792aab0f4db1d784f98bd121f6a0 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6024)));
			c21f2904773eb8a90fbf89a701a12ff1f.Position = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6028);
			this.c02d236f30e203f7ad2e0a29221eb04d7 = new List<cd161c587b229cb9747bf073c6e98b0b9>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6032); i < (int)this.NumOfContents; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6100))
			{
				cd161c587b229cb9747bf073c6e98b0b9 cd161c587b229cb9747bf073c6e98b0b;
				if (cd6f1966a966a6f1dabeb755aded4df42 == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6036))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cbcbdbfc95367bfec4c11b371d883aa2d.cc45242a6bfb904bfaee72c49be80e3d3(Stream, ceee61848167c1ade885c85db30acc060)).MethodHandle;
					}
					cd161c587b229cb9747bf073c6e98b0b = new cb2b30fcb045ddafaa1632429689f0bfd
					{
						Hash = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6040))
					};
				}
				else
				{
					if (cd6f1966a966a6f1dabeb755aded4df42 != ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
					{
						throw new NotImplementedException();
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
					cd161c587b229cb9747bf073c6e98b0b = new cf102f47e92574fa2f6d6be0ff8bdb8e5
					{
						Hash = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6044))
					};
				}
				c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6048), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6052));
				cd161c587b229cb9747bf073c6e98b0b.ContentId = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6056)));
				cd161c587b229cb9747bf073c6e98b0b.Index = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6060)));
				cd161c587b229cb9747bf073c6e98b0b.c0209aefcfe7e6dc9ad7719a0fa0b263d = (c96210b78306751464b80046e2be9150e)cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6064)));
				c21f2904773eb8a90fbf89a701a12ff1f.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6072));
				cd161c587b229cb9747bf073c6e98b0b.Size = new DataSize(cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt64(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6076))));
				c21f2904773eb8a90fbf89a701a12ff1f.Read(cd161c587b229cb9747bf073c6e98b0b.Hash, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6080), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cd161c587b229cb9747bf073c6e98b0b.Hash));
				this.c02d236f30e203f7ad2e0a29221eb04d7.Add(cd161c587b229cb9747bf073c6e98b0b);
				if (cd6f1966a966a6f1dabeb755aded4df42 == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6084))
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
					byte[] buffer = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6088));
					c21f2904773eb8a90fbf89a701a12ff1f.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6096));
				}
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
			c21f2904773eb8a90fbf89a701a12ff1f.Read(this.Certificate1, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6104), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.Certificate1));
			c21f2904773eb8a90fbf89a701a12ff1f.Read(this.Certificate2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6108), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.Certificate2));
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00017A60 File Offset: 0x00015C60
		public void Dispose()
		{
			this.cae0d2bce79432f2d195176e3df8302d5(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6112) != 0);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00017A84 File Offset: 0x00015C84
		~cbcbdbfc95367bfec4c11b371d883aa2d()
		{
			this.cae0d2bce79432f2d195176e3df8302d5(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6116) != 0);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00017ABC File Offset: 0x00015CBC
		private void cae0d2bce79432f2d195176e3df8302d5(bool c823f5e692f6c5fba6e9a906c177cfac4)
		{
			if (c823f5e692f6c5fba6e9a906c177cfac4)
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(cbcbdbfc95367bfec4c11b371d883aa2d.cae0d2bce79432f2d195176e3df8302d5(bool)).MethodHandle;
				}
				if (!this.c2edd31d0b9632ab69e10dbd8c5046918)
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
					this.c6d8263cd82dd2c7e5e2d10e0b598b5bb = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.ca71f41bee74122c1cd3d529695502221 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.c81661f7e6893011ccd7398cab0c2bdb1 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.cceb58a567da3955f65dd8980b8581b7c = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.c02d236f30e203f7ad2e0a29221eb04d7.Clear();
					this.c02d236f30e203f7ad2e0a29221eb04d7 = c7074496366fec9eff2cb1805eba432af.cab55a050df275722227783d6686266c9;
				}
			}
			this.c2edd31d0b9632ab69e10dbd8c5046918 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6120) != 0);
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00017B44 File Offset: 0x00015D44
		public DataSize c4287d6f1112583ecb2415036eb13e39d
		{
			get
			{
				DataSize dataSize = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6124)));
				IEnumerable<cd161c587b229cb9747bf073c6e98b0b9> ca41cd3b028585a369298639868832973 = this.ca41cd3b028585a369298639868832973;
				DataSize seed = dataSize;
				Func<DataSize, cd161c587b229cb9747bf073c6e98b0b9, DataSize> func;
				if ((func = cbcbdbfc95367bfec4c11b371d883aa2d.<>c.cb9aca7a6fcaa056652ce908401298b5e) == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cbcbdbfc95367bfec4c11b371d883aa2d.get_c4287d6f1112583ecb2415036eb13e39d()).MethodHandle;
					}
					func = (cbcbdbfc95367bfec4c11b371d883aa2d.<>c.cb9aca7a6fcaa056652ce908401298b5e = new Func<DataSize, cd161c587b229cb9747bf073c6e98b0b9, DataSize>(cbcbdbfc95367bfec4c11b371d883aa2d.<>c.cdfab1996eb8651828de2a4469aa3481e.c17aa5f652584f11bf163b3b1c0b69827));
				}
				return ca41cd3b028585a369298639868832973.Aggregate(seed, func);
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00017BA8 File Offset: 0x00015DA8
		public static cbcbdbfc95367bfec4c11b371d883aa2d cca035b5773e1c7bd4eb2ebb87879807e(string ce29a958ba9520b3308a8bc42d9dcf137, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			return cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(File.ReadAllBytes(ce29a958ba9520b3308a8bc42d9dcf137), cd6f1966a966a6f1dabeb755aded4df42);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00017BC8 File Offset: 0x00015DC8
		public static cbcbdbfc95367bfec4c11b371d883aa2d cca035b5773e1c7bd4eb2ebb87879807e(byte[] c21f2904773eb8a90fbf89a701a12ff1f, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			cbcbdbfc95367bfec4c11b371d883aa2d cbcbdbfc95367bfec4c11b371d883aa2d = new cbcbdbfc95367bfec4c11b371d883aa2d();
			MemoryStream memoryStream = new MemoryStream(c21f2904773eb8a90fbf89a701a12ff1f);
			try
			{
				cbcbdbfc95367bfec4c11b371d883aa2d.cc45242a6bfb904bfaee72c49be80e3d3(memoryStream, cd6f1966a966a6f1dabeb755aded4df42);
			}
			catch
			{
				memoryStream.Dispose();
				throw;
			}
			memoryStream.Dispose();
			return cbcbdbfc95367bfec4c11b371d883aa2d;
		}

		// Token: 0x0400021A RID: 538
		[CompilerGenerated]
		private readonly byte[] c429296b47f7856a3fe37392df52583e9;

		// Token: 0x0400021B RID: 539
		[CompilerGenerated]
		private readonly byte[] ca13efc22479a62fa4044ce13051de347;

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		private ushort c01cf1d51e0d1b7bf74d3ed18ba67d6ed;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private ulong cf7880c184a0785b1e8389c16e9919cf0;

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		private ushort c86cb3bbedd6959074feb69d872ce2b62;

		// Token: 0x0400021F RID: 543
		private uint c98644df94eb0f65a4150303b6bd422f8;

		// Token: 0x04000220 RID: 544
		private ushort c297d8fe7cc5360250337b71fbdb95fc4;

		// Token: 0x04000221 RID: 545
		private byte c99d18b985796ff7de8071cdbe64d17f8;

		// Token: 0x04000222 RID: 546
		private List<cd161c587b229cb9747bf073c6e98b0b9> c02d236f30e203f7ad2e0a29221eb04d7;

		// Token: 0x04000223 RID: 547
		private ushort cb641727e9d4aaba1e3f5f87ed2d9de1a;

		// Token: 0x04000224 RID: 548
		private byte[] c81661f7e6893011ccd7398cab0c2bdb1 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6136));

		// Token: 0x04000225 RID: 549
		private byte[] ca71f41bee74122c1cd3d529695502221 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6140));

		// Token: 0x04000226 RID: 550
		private ushort cc59fdfacadc539774e0000d4479405c0;

		// Token: 0x04000227 RID: 551
		private ushort c7d19792aab0f4db1d784f98bd121f6a0;

		// Token: 0x04000228 RID: 552
		private byte c82a30178fe60f52988d186860151ff20;

		// Token: 0x04000229 RID: 553
		private ushort c692cc2cd6b2479b444c984d25e25f082;

		// Token: 0x0400022A RID: 554
		private byte[] cceb58a567da3955f65dd8980b8581b7c = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6144));

		// Token: 0x0400022B RID: 555
		private byte[] c6d8263cd82dd2c7e5e2d10e0b598b5bb = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6148));

		// Token: 0x0400022C RID: 556
		private uint cd40e90e41f0d55bd91526fa91bf126e1 = (uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6152);

		// Token: 0x0400022D RID: 557
		private byte cdc6c8af27d850c8d1aca20796dac2bbb;

		// Token: 0x0400022E RID: 558
		private uint c85a9f1fd52b11c4c7b31217c482a3e08;

		// Token: 0x0400022F RID: 559
		private byte c4035753616cbdf1ac123b7183bf2b112;

		// Token: 0x04000230 RID: 560
		private bool c2edd31d0b9632ab69e10dbd8c5046918;
	}
}
