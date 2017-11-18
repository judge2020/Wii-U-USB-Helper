using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace A
{
	// Token: 0x02000077 RID: 119
	public sealed class c9538952b0224ea717b33e0e4e7ae98c5 : IDisposable
	{
		// Token: 0x0600035B RID: 859 RVA: 0x00016934 File Offset: 0x00014B34
		static c9538952b0224ea717b33e0e4e7ae98c5()
		{
			// Note: this type is marked as 'beforefieldinit'.
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5848));
			RuntimeHelpers.InitializeArray(array, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.cee87278db6afdebbe2379a151ecf4138).FieldHandle);
			c9538952b0224ea717b33e0e4e7ae98c5.c8952915cce70842fb04133ed8025ed96 = array;
			byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5852));
			RuntimeHelpers.InitializeArray(array2, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c1f5cce8df0ff22c1c0cba4273cd08810).FieldHandle);
			c9538952b0224ea717b33e0e4e7ae98c5.c87f42786776f6f0c1dfef25927e79e2e = array2;
			byte[] array3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5856));
			RuntimeHelpers.InitializeArray(array3, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c234537ae19a515064934b9c8510c0864).FieldHandle);
			c9538952b0224ea717b33e0e4e7ae98c5.c7ec1a0d67842d8d38fc2c8b4d8b9212e = array3;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000169A4 File Offset: 0x00014BA4
		// (set) Token: 0x0600035D RID: 861 RVA: 0x000169B8 File Offset: 0x00014BB8
		public ushort NumOfDlc { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000169CC File Offset: 0x00014BCC
		// (set) Token: 0x0600035F RID: 863 RVA: 0x000169E0 File Offset: 0x00014BE0
		public ulong TicketId { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000169F4 File Offset: 0x00014BF4
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00016A08 File Offset: 0x00014C08
		public byte[] cc0eab3c8af7b4aa29c084139a1df3c14
		{
			get
			{
				return this.c747c287e1773b86956d0768f3b3a0142;
			}
			set
			{
				this.c747c287e1773b86956d0768f3b3a0142 = value;
				this.TitleKeyChanged = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5524) != 0);
				this.c418b6046b26a3f60fc5a3ba605052f70 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5528) != 0);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00016A3C File Offset: 0x00014C3C
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00016A50 File Offset: 0x00014C50
		public bool TitleKeyChanged { get; private set; }

		// Token: 0x06000364 RID: 868 RVA: 0x00016A64 File Offset: 0x00014C64
		public static byte[] c96134dbaf770717cf693cafad29ba9e3(string c27519c95be088959ebe6258bb5d81619, string c0ae48386f017a7b0f2f09804789f3cac, int ced06ff8ca1ccc2106f830c2e9f49b2fd)
		{
			return c9538952b0224ea717b33e0e4e7ae98c5.c9514d0ce0a07c6ba764b745b99684bed(c27519c95be088959ebe6258bb5d81619, c0ae48386f017a7b0f2f09804789f3cac, ced06ff8ca1ccc2106f830c2e9f49b2fd, c9538952b0224ea717b33e0e4e7ae98c5.c7ec1a0d67842d8d38fc2c8b4d8b9212e, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5532) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5536) != 0);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00016A94 File Offset: 0x00014C94
		public static byte[] ca2730dc934b9cae0800f2e13849880ee(string c27519c95be088959ebe6258bb5d81619, string c0ae48386f017a7b0f2f09804789f3cac, int ced06ff8ca1ccc2106f830c2e9f49b2fd, bool caf73c099aed321573aa1ebe9ab57f838 = false, bool c47540eab3d63a717db38ffc3705de5e0 = false)
		{
			return c9538952b0224ea717b33e0e4e7ae98c5.c9514d0ce0a07c6ba764b745b99684bed(c27519c95be088959ebe6258bb5d81619, c0ae48386f017a7b0f2f09804789f3cac, ced06ff8ca1ccc2106f830c2e9f49b2fd, c9538952b0224ea717b33e0e4e7ae98c5.c87f42786776f6f0c1dfef25927e79e2e, caf73c099aed321573aa1ebe9ab57f838, c47540eab3d63a717db38ffc3705de5e0);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00016AB4 File Offset: 0x00014CB4
		private static byte[] c9514d0ce0a07c6ba764b745b99684bed(string c27519c95be088959ebe6258bb5d81619, string c0ae48386f017a7b0f2f09804789f3cac, int ced06ff8ca1ccc2106f830c2e9f49b2fd, byte[] cdb43528d5e5a70b8801ab74795c78e66, bool caf73c099aed321573aa1ebe9ab57f838 = false, bool c47540eab3d63a717db38ffc3705de5e0 = false)
		{
			byte[] array = cf39ba1cc0203f3f17ac1b306844a12cd.cd24593c859565ebb8c9faabbc5c75bef(cdb43528d5e5a70b8801ab74795c78e66.Clone());
			byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5540));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5544)] = (byte)(ced06ff8ca1ccc2106f830c2e9f49b2fd >> cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5548));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5552)] = (byte)ced06ff8ca1ccc2106f830c2e9f49b2fd;
			byte[] array3 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(c27519c95be088959ebe6258bb5d81619);
			byte[] array4 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(c0ae48386f017a7b0f2f09804789f3cac);
			Buffer.BlockCopy(array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5556), array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5560), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5564));
			Buffer.BlockCopy(array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5568), array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5572), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array3));
			Buffer.BlockCopy(array4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5576), array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5580), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array4));
			if (caf73c099aed321573aa1ebe9ab57f838)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9538952b0224ea717b33e0e4e7ae98c5.c9514d0ce0a07c6ba764b745b99684bed(string, string, int, byte[], bool, bool)).MethodHandle;
				}
				c9538952b0224ea717b33e0e4e7ae98c5.c6cfa7911bc9ec3451622850faf97d511(ref array);
			}
			if (c47540eab3d63a717db38ffc3705de5e0)
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
				c9538952b0224ea717b33e0e4e7ae98c5.c3af43459f642f5007bb120ebfecbff08(ref array);
			}
			return array;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00016BBC File Offset: 0x00014DBC
		private unsafe static void c6cfa7911bc9ec3451622850faf97d511(ref byte[] c2bdc0253794dde45b70b2d85ceddacde)
		{
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5584); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5600); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5596))
			{
				c2bdc0253794dde45b70b2d85ceddacde[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5588) + i] = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5592);
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
				RuntimeMethodHandle runtimeMethodHandle = methodof(c9538952b0224ea717b33e0e4e7ae98c5.c6cfa7911bc9ec3451622850faf97d511(byte[]*)).MethodHandle;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00016C1C File Offset: 0x00014E1C
		private static void c3af43459f642f5007bb120ebfecbff08(ref byte[] c2bdc0253794dde45b70b2d85ceddacde)
		{
			Buffer.BlockCopy(c9538952b0224ea717b33e0e4e7ae98c5.c8952915cce70842fb04133ed8025ed96, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5604), c2bdc0253794dde45b70b2d85ceddacde, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5608), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c9538952b0224ea717b33e0e4e7ae98c5.c8952915cce70842fb04133ed8025ed96));
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00016C58 File Offset: 0x00014E58
		public void Dispose()
		{
			this.cae0d2bce79432f2d195176e3df8302d5(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5612) != 0);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00016C7C File Offset: 0x00014E7C
		~c9538952b0224ea717b33e0e4e7ae98c5()
		{
			this.cae0d2bce79432f2d195176e3df8302d5(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5616) != 0);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00016CB4 File Offset: 0x00014EB4
		private void cae0d2bce79432f2d195176e3df8302d5(bool c823f5e692f6c5fba6e9a906c177cfac4)
		{
			if (c823f5e692f6c5fba6e9a906c177cfac4)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9538952b0224ea717b33e0e4e7ae98c5.cae0d2bce79432f2d195176e3df8302d5(bool)).MethodHandle;
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
					this.c747c287e1773b86956d0768f3b3a0142 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.c8ccda0951f8311a7996396a4d7611e06 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.c6d8263cd82dd2c7e5e2d10e0b598b5bb = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.ca71f41bee74122c1cd3d529695502221 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.c81661f7e6893011ccd7398cab0c2bdb1 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.cdbbdaca556c355c16ad13eb165325ee5 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.c3b21cff419d05c502401d65956acadaa = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.cee4551c3466dc35266b1051e6f0f7e6e = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.cd548c6a3267574766ed229998c699ef7 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					this.ce378d559b4a17102c54e23a2a6a63810 = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
				}
			}
			this.c2edd31d0b9632ab69e10dbd8c5046918 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5620) != 0);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00016D6C File Offset: 0x00014F6C
		public static c9538952b0224ea717b33e0e4e7ae98c5 cca035b5773e1c7bd4eb2ebb87879807e(string cb455303fb850eca2b1608811f20582a4, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			return c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(File.ReadAllBytes(cb455303fb850eca2b1608811f20582a4), cd6f1966a966a6f1dabeb755aded4df42);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00016D8C File Offset: 0x00014F8C
		public static c9538952b0224ea717b33e0e4e7ae98c5 cca035b5773e1c7bd4eb2ebb87879807e(byte[] c2bdc0253794dde45b70b2d85ceddacde, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			c9538952b0224ea717b33e0e4e7ae98c5 c9538952b0224ea717b33e0e4e7ae98c = new c9538952b0224ea717b33e0e4e7ae98c5();
			MemoryStream memoryStream = new MemoryStream(c2bdc0253794dde45b70b2d85ceddacde);
			try
			{
				c9538952b0224ea717b33e0e4e7ae98c.c52bff31729043cd09c61064cf2981618(memoryStream, cd6f1966a966a6f1dabeb755aded4df42);
			}
			catch
			{
				memoryStream.Dispose();
				throw;
			}
			memoryStream.Dispose();
			return c9538952b0224ea717b33e0e4e7ae98c;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00016DD0 File Offset: 0x00014FD0
		private void c7ef395874a7d8c05bd949b547364e369(ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			byte[] key = c31aa9226ef7f3a555c5e2de139fd03ac.c9ee19cb0686a194e2e232bd47a932d9f(cd6f1966a966a6f1dabeb755aded4df42);
			byte[] bytes = BitConverter.GetBytes(cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(this.c7124ab9355099a3844d3ea08bfa3258d));
			Array.Resize<byte>(ref bytes, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5624));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5628);
			rijndaelManaged.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5632);
			rijndaelManaged.KeySize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5636);
			rijndaelManaged.BlockSize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5640);
			rijndaelManaged.Key = key;
			rijndaelManaged.IV = bytes;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			MemoryStream memoryStream = new MemoryStream(this.c3b21cff419d05c502401d65956acadaa);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, (CryptoStreamMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5644));
			cryptoStream.Read(this.c747c287e1773b86956d0768f3b3a0142, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5648), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.c747c287e1773b86956d0768f3b3a0142));
			cryptoStream.Dispose();
			memoryStream.Dispose();
			cryptoTransform.Dispose();
			rijndaelManaged.Clear();
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00016EC0 File Offset: 0x000150C0
		private void c52bff31729043cd09c61064cf2981618(Stream cb4ac25127cebac0b10158477138f1430, ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			cb4ac25127cebac0b10158477138f1430.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5652), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5656));
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5660));
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5664), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5668));
			this.cd40e90e41f0d55bd91526fa91bf126e1 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5672)));
			cb4ac25127cebac0b10158477138f1430.Read(this.c6d8263cd82dd2c7e5e2d10e0b598b5bb, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5676), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.c6d8263cd82dd2c7e5e2d10e0b598b5bb));
			cb4ac25127cebac0b10158477138f1430.Read(this.ca71f41bee74122c1cd3d529695502221, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5680), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.ca71f41bee74122c1cd3d529695502221));
			cb4ac25127cebac0b10158477138f1430.Read(this.c81661f7e6893011ccd7398cab0c2bdb1, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5684), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.c81661f7e6893011ccd7398cab0c2bdb1));
			cb4ac25127cebac0b10158477138f1430.Read(this.cdbbdaca556c355c16ad13eb165325ee5, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5688), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.cdbbdaca556c355c16ad13eb165325ee5));
			cb4ac25127cebac0b10158477138f1430.Read(this.c3b21cff419d05c502401d65956acadaa, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5692), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.c3b21cff419d05c502401d65956acadaa));
			this.cec8d5c6fe477aa93db9a2aba33630000 = (byte)cb4ac25127cebac0b10158477138f1430.ReadByte();
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5696), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5700));
			this.TicketId = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt64(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5704)));
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5708), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5712));
			this.c0a0db5858777c5490c926c0e7ea9f004 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5716)));
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5720), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5724));
			this.c7124ab9355099a3844d3ea08bfa3258d = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt64(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5728)));
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5732), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5736));
			this.cb08c7768e97b2c0554555951840931c1 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5740)));
			this.NumOfDlc = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5744)));
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5748), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5752));
			this.ce396605d12e8d66a987377d1914fcb79 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt64(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5756)));
			this.cc59fdfacadc539774e0000d4479405c0 = (byte)cb4ac25127cebac0b10158477138f1430.ReadByte();
			this.c4cea6cb05f734f2353a3931a17037336 = (byte)cb4ac25127cebac0b10158477138f1430.ReadByte();
			this.ca3a59b204caca14f0f8842bd82350479 = this.c4cea6cb05f734f2353a3931a17037336;
			cb4ac25127cebac0b10158477138f1430.Read(this.cee4551c3466dc35266b1051e6f0f7e6e, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5760), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.cee4551c3466dc35266b1051e6f0f7e6e));
			cb4ac25127cebac0b10158477138f1430.Read(this.cd548c6a3267574766ed229998c699ef7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5764), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.cd548c6a3267574766ed229998c699ef7));
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5768), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5772));
			this.c7d19792aab0f4db1d784f98bd121f6a0 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt16(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5776)));
			cb4ac25127cebac0b10158477138f1430.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5784));
			this.c46504ce2d9d1749d70a09332535ac2b5 = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5788)));
			this.c8f658c2bc8102ad3f94f11d5d2edcd9b = cd4880843d42f3dd634ca35c8e909b573.c0dba4641303499c84a0f24e0e2c8c9e2(BitConverter.ToUInt32(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5792)));
			cb4ac25127cebac0b10158477138f1430.Read(this.ce378d559b4a17102c54e23a2a6a63810, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5796), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.ce378d559b4a17102c54e23a2a6a63810));
			this.c7ef395874a7d8c05bd949b547364e369(cd6f1966a966a6f1dabeb755aded4df42);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0001729C File Offset: 0x0001549C
		private void c98c03b6a8b0241618f8774ec8912c68a(ceee61848167c1ade885c85db30acc060 cd6f1966a966a6f1dabeb755aded4df42)
		{
			this.c3b21cff419d05c502401d65956acadaa = this.c8ccda0951f8311a7996396a4d7611e06;
			this.c7ef395874a7d8c05bd949b547364e369(cd6f1966a966a6f1dabeb755aded4df42);
		}

		// Token: 0x040001F6 RID: 502
		[CompilerGenerated]
		private ushort ca153148f7d08521a1095fc048bbd4207;

		// Token: 0x040001F7 RID: 503
		[CompilerGenerated]
		private ulong c7bd4a14a2dcd74909c69ff63f47d9c5c;

		// Token: 0x040001F8 RID: 504
		[CompilerGenerated]
		private bool ca730cedcced3b65c1a25e4857e98a33b;

		// Token: 0x040001F9 RID: 505
		private static readonly byte[] c8952915cce70842fb04133ed8025ed96;

		// Token: 0x040001FA RID: 506
		private static readonly byte[] c87f42786776f6f0c1dfef25927e79e2e;

		// Token: 0x040001FB RID: 507
		private static readonly byte[] c7ec1a0d67842d8d38fc2c8b4d8b9212e;

		// Token: 0x040001FC RID: 508
		private byte c4cea6cb05f734f2353a3931a17037336;

		// Token: 0x040001FD RID: 509
		private uint c0a0db5858777c5490c926c0e7ea9f004;

		// Token: 0x040001FE RID: 510
		private byte[] c747c287e1773b86956d0768f3b3a0142 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5800));

		// Token: 0x040001FF RID: 511
		private uint c46504ce2d9d1749d70a09332535ac2b5;

		// Token: 0x04000200 RID: 512
		private byte[] c3b21cff419d05c502401d65956acadaa = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5804));

		// Token: 0x04000201 RID: 513
		private byte[] c81661f7e6893011ccd7398cab0c2bdb1 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5808));

		// Token: 0x04000202 RID: 514
		private byte[] c8ccda0951f8311a7996396a4d7611e06 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5812));

		// Token: 0x04000203 RID: 515
		private byte ca3a59b204caca14f0f8842bd82350479;

		// Token: 0x04000204 RID: 516
		private byte[] ca71f41bee74122c1cd3d529695502221 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5816));

		// Token: 0x04000205 RID: 517
		private byte cc59fdfacadc539774e0000d4479405c0;

		// Token: 0x04000206 RID: 518
		private ushort c7d19792aab0f4db1d784f98bd121f6a0;

		// Token: 0x04000207 RID: 519
		private byte[] ce378d559b4a17102c54e23a2a6a63810 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5820));

		// Token: 0x04000208 RID: 520
		private bool c418b6046b26a3f60fc5a3ba605052f70;

		// Token: 0x04000209 RID: 521
		private byte[] c6d8263cd82dd2c7e5e2d10e0b598b5bb = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5824));

		// Token: 0x0400020A RID: 522
		private uint cd40e90e41f0d55bd91526fa91bf126e1 = (uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5828);

		// Token: 0x0400020B RID: 523
		private uint c8f658c2bc8102ad3f94f11d5d2edcd9b;

		// Token: 0x0400020C RID: 524
		private ulong c7124ab9355099a3844d3ea08bfa3258d;

		// Token: 0x0400020D RID: 525
		private byte[] cdbbdaca556c355c16ad13eb165325ee5 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5832));

		// Token: 0x0400020E RID: 526
		private byte cec8d5c6fe477aa93db9a2aba33630000;

		// Token: 0x0400020F RID: 527
		private ushort cb08c7768e97b2c0554555951840931c1 = (ushort)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5836);

		// Token: 0x04000210 RID: 528
		private ulong ce396605d12e8d66a987377d1914fcb79;

		// Token: 0x04000211 RID: 529
		private byte[] cee4551c3466dc35266b1051e6f0f7e6e = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5840));

		// Token: 0x04000212 RID: 530
		private byte[] cd548c6a3267574766ed229998c699ef7 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5844));

		// Token: 0x04000213 RID: 531
		private bool c2edd31d0b9632ab69e10dbd8c5046918;
	}
}
