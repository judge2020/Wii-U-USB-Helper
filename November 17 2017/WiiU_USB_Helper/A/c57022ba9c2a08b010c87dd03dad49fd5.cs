using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace A
{
	// Token: 0x02000076 RID: 118
	internal static class c57022ba9c2a08b010c87dd03dad49fd5
	{
		// Token: 0x0600034D RID: 845 RVA: 0x000154F4 File Offset: 0x000136F4
		public static c330c9d7d3b3430f9e77f4c768d333599 c7a2b6d9b6de2eef86001b4f09f404e16(byte[] c77685ee4f17464bac5cfafb994e6d964, byte[] c0412f9309baf06438554911feccbba06, int c89f74ee6929428753b61a10155b54ad4, byte[] c0ae48386f017a7b0f2f09804789f3cac, byte c80f81f5bbd2eba3291ab3323340a6287)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4964));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4968)] = c80f81f5bbd2eba3291ab3323340a6287;
			byte[] array2 = array;
			SHA1 sha = SHA1.Create();
			byte[] array3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4972));
			Buffer.BlockCopy(c77685ee4f17464bac5cfafb994e6d964, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4976), array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4980), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4984));
			byte[] array4 = c57022ba9c2a08b010c87dd03dad49fd5.c4e9cee3c7bbdcba067acbf3bfeeed7a0(array3, c0ae48386f017a7b0f2f09804789f3cac, array2);
			byte[] array5 = array4;
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4988);
			array5[num] ^= c80f81f5bbd2eba3291ab3323340a6287;
			int srcOffset = c89f74ee6929428753b61a10155b54ad4 % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4992) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4996);
			int srcOffset2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5000) + c89f74ee6929428753b61a10155b54ad4 / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5004) % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5008)) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5012);
			int srcOffset3 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5016) + c89f74ee6929428753b61a10155b54ad4 / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5020) % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5024)) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5028);
			int srcOffset4 = c89f74ee6929428753b61a10155b54ad4 / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5032) % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5036) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5040);
			byte[] array6 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5044));
			byte[] array7 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5048));
			byte[] array8 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5052));
			byte[] array9 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5056));
			Buffer.BlockCopy(array4, srcOffset, array6, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5064));
			Buffer.BlockCopy(array4, srcOffset, array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5072));
			byte[] array10 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5076));
			Buffer.BlockCopy(c77685ee4f17464bac5cfafb994e6d964, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5080), array10, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5088));
			byte[] buffer = c57022ba9c2a08b010c87dd03dad49fd5.c4e9cee3c7bbdcba067acbf3bfeeed7a0(array10, c0ae48386f017a7b0f2f09804789f3cac, array2);
			byte[] array11 = sha.ComputeHash(buffer);
			if (!cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(array6, array11))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.c7a2b6d9b6de2eef86001b4f09f404e16(byte[], byte[], int, byte[], byte)).MethodHandle;
				}
				return (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5092);
			}
			if (c89f74ee6929428753b61a10155b54ad4 % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5096) == 0)
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
				byte[] array12 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5100));
				Buffer.BlockCopy(array4, srcOffset, array12, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5104), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5108));
				Buffer.BlockCopy(array4, srcOffset2, array7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5112), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5116));
				array11 = sha.ComputeHash(array12);
				if (!cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(array11, array7))
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
					return (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5120);
				}
			}
			if (c89f74ee6929428753b61a10155b54ad4 % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5124) == 0)
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
				byte[] array13 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5128));
				Buffer.BlockCopy(array4, srcOffset2, array13, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5132), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5136));
				Buffer.BlockCopy(array4, srcOffset3, array8, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5140), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5144));
				array11 = sha.ComputeHash(array13);
				if (!cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(array8, array11))
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
					return (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5148);
				}
			}
			if (c89f74ee6929428753b61a10155b54ad4 % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5152) != 0)
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
				return (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5156);
			}
			byte[] array14 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5160));
			Buffer.BlockCopy(array4, srcOffset3, array14, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5164), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5168));
			Buffer.BlockCopy(c0412f9309baf06438554911feccbba06, srcOffset4, array9, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5172), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5176));
			array11 = sha.ComputeHash(array14);
			if (!cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(array11, array9))
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
				return (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5180);
			}
			return (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5184);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000158FC File Offset: 0x00013AFC
		public static List<c34a3d9f5ce2884877848eea58fbbe484> c5e3af937cfcc28c36e94943c630f21ff(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			c57022ba9c2a08b010c87dd03dad49fd5.cba660dd0323f43f4ba5a582cc732a0c2 cba660dd0323f43f4ba5a582cc732a0c = new c57022ba9c2a08b010c87dd03dad49fd5.cba660dd0323f43f4ba5a582cc732a0c2();
			cba660dd0323f43f4ba5a582cc732a0c.c804bc52f7f79bffee6fd394ef382eb76 = c804bc52f7f79bffee6fd394ef382eb76;
			string text = Path.Combine(cba660dd0323f43f4ba5a582cc732a0c.c804bc52f7f79bffee6fd394ef382eb76.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767));
			string text2 = Path.Combine(cba660dd0323f43f4ba5a582cc732a0c.c804bc52f7f79bffee6fd394ef382eb76.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6259));
			if (File.Exists(text))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.c5e3af937cfcc28c36e94943c630f21ff(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				if (cba660dd0323f43f4ba5a582cc732a0c.c804bc52f7f79bffee6fd394ef382eb76.Ticket == null)
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
					if (!File.Exists(text2))
					{
						for (;;)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							goto IL_99;
						}
					}
				}
				if (!File.Exists(text))
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
					c34a3d9f5ce2884877848eea58fbbe484[] array = cc51e80bc690cf4fb71f993ca0910160b.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5204));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5208)] = new c34a3d9f5ce2884877848eea58fbbe484(null, new List<int>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5212) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5216) != 0);
					return array.ToList<c34a3d9f5ce2884877848eea58fbbe484>();
				}
				cbcbdbfc95367bfec4c11b371d883aa2d cbcbdbfc95367bfec4c11b371d883aa2d = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(text, cba660dd0323f43f4ba5a582cc732a0c.c804bc52f7f79bffee6fd394ef382eb76.System);
				c57022ba9c2a08b010c87dd03dad49fd5.cba660dd0323f43f4ba5a582cc732a0c2 cba660dd0323f43f4ba5a582cc732a0c2 = cba660dd0323f43f4ba5a582cc732a0c;
				c9538952b0224ea717b33e0e4e7ae98c5 c855425d26a0aed3e30c9ad5e80dd10c;
				if ((c855425d26a0aed3e30c9ad5e80dd10c = cba660dd0323f43f4ba5a582cc732a0c.c804bc52f7f79bffee6fd394ef382eb76.Ticket) == null)
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
					c855425d26a0aed3e30c9ad5e80dd10c = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(text2, cba660dd0323f43f4ba5a582cc732a0c.c804bc52f7f79bffee6fd394ef382eb76.System);
				}
				cba660dd0323f43f4ba5a582cc732a0c2.c855425d26a0aed3e30c9ad5e80dd10c8 = c855425d26a0aed3e30c9ad5e80dd10c;
				return cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973.Select(new Func<cd161c587b229cb9747bf073c6e98b0b9, c34a3d9f5ce2884877848eea58fbbe484>(cba660dd0323f43f4ba5a582cc732a0c.cf3a4b33fecc1589ad5f378a7c30019d0)).ToList<c34a3d9f5ce2884877848eea58fbbe484>();
			}
			IL_99:
			c34a3d9f5ce2884877848eea58fbbe484[] array2 = cc51e80bc690cf4fb71f993ca0910160b.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5188));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5192)] = new c34a3d9f5ce2884877848eea58fbbe484(null, new List<int>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5196) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5200) != 0);
			return array2.ToList<c34a3d9f5ce2884877848eea58fbbe484>();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00015AB4 File Offset: 0x00013CB4
		public static void ce54da5b923f645cd77a4f414f498ca17(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			if (c804bc52f7f79bffee6fd394ef382eb76.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5220))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.ce54da5b923f645cd77a4f414f498ca17(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9579));
			}
			cd161c587b229cb9747bf073c6e98b0b9[] ca41cd3b028585a369298639868832973 = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(File.ReadAllBytes(Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767))), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5224)).ca41cd3b028585a369298639868832973;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5228); i < (int)c6039f0790413b5e04707059b16777215.cfeb04651f165d0166e7c10ab1acf8b28(ca41cd3b028585a369298639868832973); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5232))
			{
				cd161c587b229cb9747bf073c6e98b0b9 cd161c587b229cb9747bf073c6e98b0b = ca41cd3b028585a369298639868832973[i];
				string text = Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cd161c587b229cb9747bf073c6e98b0b.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)));
				c57022ba9c2a08b010c87dd03dad49fd5.cd8c05f8ee5845927bf5dc1d0a11b1540(text, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9652)), c804bc52f7f79bffee6fd394ef382eb76.c88d6390a80f08a2c7ac4a268c95a94a2, c57022ba9c2a08b010c87dd03dad49fd5.c38e32510b20dfabf58482fbd3ac0cc25(cd161c587b229cb9747bf073c6e98b0b.Index));
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
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00015BDC File Offset: 0x00013DDC
		private static byte[] c55721d9bdfe5721b9a0cd06a0920e4a4(string c32053d44c8d1dcaa73f780b2a239314c, byte[] c5202a0249b3d2bed6d5063f3930fb443, byte[] cad83d5894302992ae418fe3ccc7f5709)
		{
			SHA256 sha = SHA256.Create();
			byte[] result;
			try
			{
				AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
				try
				{
					aesCryptoServiceProvider.Key = c5202a0249b3d2bed6d5063f3930fb443;
					aesCryptoServiceProvider.IV = cad83d5894302992ae418fe3ccc7f5709;
					aesCryptoServiceProvider.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5236);
					FileStream fileStream = File.Open(c32053d44c8d1dcaa73f780b2a239314c, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5240));
					try
					{
						CryptoStream cryptoStream = new CryptoStream(fileStream, aesCryptoServiceProvider.CreateDecryptor(), (CryptoStreamMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5244));
						try
						{
							result = sha.ComputeHash(cryptoStream);
						}
						finally
						{
							if (cryptoStream != null)
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
									RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.c55721d9bdfe5721b9a0cd06a0920e4a4(string, byte[], byte[])).MethodHandle;
								}
								((IDisposable)cryptoStream).Dispose();
							}
						}
					}
					finally
					{
						if (fileStream != null)
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
							((IDisposable)fileStream).Dispose();
						}
					}
				}
				finally
				{
					if (aesCryptoServiceProvider != null)
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
						((IDisposable)aesCryptoServiceProvider).Dispose();
					}
				}
			}
			finally
			{
				if (sha != null)
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
					((IDisposable)sha).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00015CE0 File Offset: 0x00013EE0
		public static c34a3d9f5ce2884877848eea58fbbe484 c5de63ff71186576ca30d6f96f1edfe90(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, cd161c587b229cb9747bf073c6e98b0b9 c415370939c7835fef80fc1256dee96a0, byte[] cf3e794b4e35654543c0dcab929fac071)
		{
			c57022ba9c2a08b010c87dd03dad49fd5.cf9fb18fccc2deb33dbf79bf201e2fbc6 cf9fb18fccc2deb33dbf79bf201e2fbc = new c57022ba9c2a08b010c87dd03dad49fd5.cf9fb18fccc2deb33dbf79bf201e2fbc6();
			cf9fb18fccc2deb33dbf79bf201e2fbc.cf3e794b4e35654543c0dcab929fac071 = cf3e794b4e35654543c0dcab929fac071;
			cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0 = c415370939c7835fef80fc1256dee96a0;
			List<int> list = new List<int>();
			string path = Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)));
			string path2 = Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308)));
			if (!cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0.c5a0797ee67f90b4af0433c5d7ee00865)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.c5de63ff71186576ca30d6f96f1edfe90(c6114b34ba4893a53ebb4b599e0e2e3fc, cd161c587b229cb9747bf073c6e98b0b9, byte[])).MethodHandle;
				}
				if (!c57022ba9c2a08b010c87dd03dad49fd5.cc74f870bc608559b33d8b72a4dc792f9(c804bc52f7f79bffee6fd394ef382eb76, cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0, cf9fb18fccc2deb33dbf79bf201e2fbc.cf3e794b4e35654543c0dcab929fac071))
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
					return new c34a3d9f5ce2884877848eea58fbbe484(cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0, new List<int>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5248) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5252) != 0);
				}
				return new c34a3d9f5ce2884877848eea58fbbe484(cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0, new List<int>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5256) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5260) != 0);
			}
			else
			{
				if (!File.Exists(path2))
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
					return new c34a3d9f5ce2884877848eea58fbbe484(cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0, list, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5264) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5268) != 0);
				}
				cf9fb18fccc2deb33dbf79bf201e2fbc.c0412f9309baf06438554911feccbba06 = File.ReadAllBytes(path2);
				if (!cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(SHA1.Create().ComputeHash(cf9fb18fccc2deb33dbf79bf201e2fbc.c0412f9309baf06438554911feccbba06), cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0.Hash))
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
					return new c34a3d9f5ce2884877848eea58fbbe484(cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0, list, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5272) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5276) != 0);
				}
				FileStream fileStream = File.OpenRead(path);
				try
				{
					c57022ba9c2a08b010c87dd03dad49fd5.caa14b5abb94da95dce278cd2899ee923 caa14b5abb94da95dce278cd2899ee = new c57022ba9c2a08b010c87dd03dad49fd5.caa14b5abb94da95dce278cd2899ee923();
					caa14b5abb94da95dce278cd2899ee.c8c38354cddaefb45b9cfcd9ed2838c37 = cf9fb18fccc2deb33dbf79bf201e2fbc;
					int num = (int)(caa14b5abb94da95dce278cd2899ee.c8c38354cddaefb45b9cfcd9ed2838c37.c415370939c7835fef80fc1256dee96a0.Size.TotalBytes / (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5280)));
					int num2 = (int)Math.Ceiling((double)num / cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(5284));
					int num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5292);
					caa14b5abb94da95dce278cd2899ee.cde88314e16e7bb5a55d88a707ca55fab = Enumerable.Repeat<bool>(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5296) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5300)).ToArray<bool>();
					caa14b5abb94da95dce278cd2899ee.c4c20b928cada33135a59cb7fcb256285 = Enumerable.Repeat<List<int>>(new List<int>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5304)).ToArray<List<int>>();
					Thread[] array = c1cc547a61522fa932c5dfb9e3eae719c.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5308));
					for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5312); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5324); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5320))
					{
						if (c57022ba9c2a08b010c87dd03dad49fd5.cc147b89ff1277e3eee847ace82ca7210[i] == null)
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
							c57022ba9c2a08b010c87dd03dad49fd5.cc147b89ff1277e3eee847ace82ca7210[i] = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5316));
						}
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
					for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5328); j < num2; j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5380))
					{
						c57022ba9c2a08b010c87dd03dad49fd5.ccf806cef399ff7d46cfcbfb8288b77ef ccf806cef399ff7d46cfcbfb8288b77ef = new c57022ba9c2a08b010c87dd03dad49fd5.ccf806cef399ff7d46cfcbfb8288b77ef();
						ccf806cef399ff7d46cfcbfb8288b77ef.c9def284befdb85aa51808c134f9b5700 = caa14b5abb94da95dce278cd2899ee;
						ccf806cef399ff7d46cfcbfb8288b77ef.cb6f83369480c118e665eca5c7dfb5fc0 = c57022ba9c2a08b010c87dd03dad49fd5.ce2c84344283c38f379659fccf6e7d5dc(num, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5332), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5336));
						num -= ccf806cef399ff7d46cfcbfb8288b77ef.cb6f83369480c118e665eca5c7dfb5fc0.Item2;
						for (int k = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5340); k < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5364); k += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5360))
						{
							c57022ba9c2a08b010c87dd03dad49fd5.c56862ec2ab39b4f939ee37095d066a3d c56862ec2ab39b4f939ee37095d066a3d = new c57022ba9c2a08b010c87dd03dad49fd5.c56862ec2ab39b4f939ee37095d066a3d();
							c56862ec2ab39b4f939ee37095d066a3d.c248e670c92c8bf286ec14bc40a071437 = ccf806cef399ff7d46cfcbfb8288b77ef;
							c56862ec2ab39b4f939ee37095d066a3d.cc4d7b4a30b1d020931ad10f9f5ad01c7 = k;
							c56862ec2ab39b4f939ee37095d066a3d.c3efd14b2a8d5177dd2c2c21768185bd1 = num3;
							c56862ec2ab39b4f939ee37095d066a3d.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.cde88314e16e7bb5a55d88a707ca55fab[k] = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5344) != 0);
							c56862ec2ab39b4f939ee37095d066a3d.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c4c20b928cada33135a59cb7fcb256285[k] = new List<int>();
							fileStream.Read(c57022ba9c2a08b010c87dd03dad49fd5.cc147b89ff1277e3eee847ace82ca7210[k], cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5348), c56862ec2ab39b4f939ee37095d066a3d.c248e670c92c8bf286ec14bc40a071437.cb6f83369480c118e665eca5c7dfb5fc0.Item1[k] * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5352));
							if (c57022ba9c2a08b010c87dd03dad49fd5.cc147b89ff1277e3eee847ace82ca7210[k].Length != 0)
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
								array[k] = new Thread(new ThreadStart(c56862ec2ab39b4f939ee37095d066a3d.ce51a462e66ecd24fbcf98933804ce392));
								array[k].Start();
							}
							else
							{
								c56862ec2ab39b4f939ee37095d066a3d.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.cde88314e16e7bb5a55d88a707ca55fab[k] = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5356) != 0);
								c56862ec2ab39b4f939ee37095d066a3d.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c4c20b928cada33135a59cb7fcb256285[k] = new List<int>();
							}
							num3 += c56862ec2ab39b4f939ee37095d066a3d.c248e670c92c8bf286ec14bc40a071437.cb6f83369480c118e665eca5c7dfb5fc0.Item1[k];
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
						while (!c57022ba9c2a08b010c87dd03dad49fd5.c2713e14237d6c64be172584b4cd9ae4f(ccf806cef399ff7d46cfcbfb8288b77ef.c9def284befdb85aa51808c134f9b5700.cde88314e16e7bb5a55d88a707ca55fab))
						{
							Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5368));
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
						List<int>[] c4c20b928cada33135a59cb7fcb = ccf806cef399ff7d46cfcbfb8288b77ef.c9def284befdb85aa51808c134f9b5700.c4c20b928cada33135a59cb7fcb256285;
						for (int l = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5372); l < (int)c010f4bbb702bfc027c5ced536fe0e55d.cfeb04651f165d0166e7c10ab1acf8b28(c4c20b928cada33135a59cb7fcb); l += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5376))
						{
							List<int> collection = c4c20b928cada33135a59cb7fcb[l];
							list.AddRange(collection);
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
					}
					for (;;)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				finally
				{
					if (fileStream != null)
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
						((IDisposable)fileStream).Dispose();
					}
				}
				return new c34a3d9f5ce2884877848eea58fbbe484(cf9fb18fccc2deb33dbf79bf201e2fbc.c415370939c7835fef80fc1256dee96a0, list, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5384) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5388) != 0);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00016298 File Offset: 0x00014498
		public static byte[] c4e9cee3c7bbdcba067acbf3bfeeed7a0(byte[] c50dd5211ea3389d85952f7ad5dfd7675, byte[] c0ae48386f017a7b0f2f09804789f3cac, byte[] cad83d5894302992ae418fe3ccc7f5709)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5392);
			rijndaelManaged.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5396);
			rijndaelManaged.KeySize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5400);
			rijndaelManaged.BlockSize = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5404);
			rijndaelManaged.Key = c0ae48386f017a7b0f2f09804789f3cac;
			rijndaelManaged.IV = cad83d5894302992ae418fe3ccc7f5709;
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c50dd5211ea3389d85952f7ad5dfd7675));
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor();
			MemoryStream memoryStream = new MemoryStream(c50dd5211ea3389d85952f7ad5dfd7675);
			try
			{
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, (CryptoStreamMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5408));
				try
				{
					cryptoStream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5412), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c50dd5211ea3389d85952f7ad5dfd7675));
				}
				finally
				{
					if (cryptoStream != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.c4e9cee3c7bbdcba067acbf3bfeeed7a0(byte[], byte[], byte[])).MethodHandle;
						}
						((IDisposable)cryptoStream).Dispose();
					}
				}
			}
			finally
			{
				if (memoryStream != null)
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
					((IDisposable)memoryStream).Dispose();
				}
			}
			return array;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00016398 File Offset: 0x00014598
		public static void cd8c05f8ee5845927bf5dc1d0a11b1540(string c97ddfca8484d510fe07a3664c22ac560, string ceb8de8cba06e416bba04212fa62b1559, byte[] c5202a0249b3d2bed6d5063f3930fb443, byte[] cad83d5894302992ae418fe3ccc7f5709)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5416));
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				aesCryptoServiceProvider.Key = c5202a0249b3d2bed6d5063f3930fb443;
				aesCryptoServiceProvider.IV = cad83d5894302992ae418fe3ccc7f5709;
				aesCryptoServiceProvider.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5420);
				FileStream fileStream = File.Open(c97ddfca8484d510fe07a3664c22ac560, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5424));
				try
				{
					FileStream fileStream2 = File.Create(ceb8de8cba06e416bba04212fa62b1559);
					try
					{
						CryptoStream cryptoStream = new CryptoStream(fileStream, aesCryptoServiceProvider.CreateDecryptor(), (CryptoStreamMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5428));
						try
						{
							int num;
							do
							{
								num = cryptoStream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5432), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
								fileStream2.Write(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5436), num);
							}
							while (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5440));
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.cd8c05f8ee5845927bf5dc1d0a11b1540(string, string, byte[], byte[])).MethodHandle;
							}
						}
						finally
						{
							if (cryptoStream != null)
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
								((IDisposable)cryptoStream).Dispose();
							}
						}
					}
					finally
					{
						if (fileStream2 != null)
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
							((IDisposable)fileStream2).Dispose();
						}
					}
				}
				finally
				{
					if (fileStream != null)
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
						((IDisposable)fileStream).Dispose();
					}
				}
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
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
					((IDisposable)aesCryptoServiceProvider).Dispose();
				}
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000164EC File Offset: 0x000146EC
		private static bool c2713e14237d6c64be172584b4cd9ae4f(bool[] c0fb74d2e3a5545417567f85ac2ea2fa2)
		{
			Func<bool, bool> predicate;
			if ((predicate = c57022ba9c2a08b010c87dd03dad49fd5.<>c.cb1c367a979b54b0a2871942a3547acef) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.c2713e14237d6c64be172584b4cd9ae4f(bool[])).MethodHandle;
				}
				predicate = (c57022ba9c2a08b010c87dd03dad49fd5.<>c.cb1c367a979b54b0a2871942a3547acef = new Func<bool, bool>(c57022ba9c2a08b010c87dd03dad49fd5.<>c.cdfab1996eb8651828de2a4469aa3481e.ceb627e643120ddb238cff523b02504f2));
			}
			return c0fb74d2e3a5545417567f85ac2ea2fa2.All(predicate);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00016534 File Offset: 0x00014734
		private static List<int> c502d2cae1c812200527c4a223dd4b392(byte[] cba6918dcf419affbc80c9444e4bbddd7, byte[] c0412f9309baf06438554911feccbba06, int c9b3cfc083895823297a7028f455453f6, int cc076fd568f4bb05b6e433b9eb4ab0a25, byte[] c0ae48386f017a7b0f2f09804789f3cac, byte c80f81f5bbd2eba3291ab3323340a6287)
		{
			List<int> list = new List<int>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5444); i < cc076fd568f4bb05b6e433b9eb4ab0a25; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5468))
			{
				byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5448));
				Buffer.BlockCopy(cba6918dcf419affbc80c9444e4bbddd7, i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5452), array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5456), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5460));
				if (c57022ba9c2a08b010c87dd03dad49fd5.c7a2b6d9b6de2eef86001b4f09f404e16(array, c0412f9309baf06438554911feccbba06, i + c9b3cfc083895823297a7028f455453f6, c0ae48386f017a7b0f2f09804789f3cac, c80f81f5bbd2eba3291ab3323340a6287) == (c330c9d7d3b3430f9e77f4c768d333599)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5464))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.c502d2cae1c812200527c4a223dd4b392(byte[], byte[], int, int, byte[], byte)).MethodHandle;
					}
					list.Add(i + c9b3cfc083895823297a7028f455453f6);
				}
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
			return list;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000165E8 File Offset: 0x000147E8
		private static byte[] c38e32510b20dfabf58482fbd3ac0cc25(ushort c495a48f0aebe7c42738c327c27ca1bf3)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5472));
			byte[] bytes = BitConverter.GetBytes(c495a48f0aebe7c42738c327c27ca1bf3);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5476)] = bytes[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5480)];
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5484)] = bytes[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5488)];
			return array;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00016640 File Offset: 0x00014840
		private static bool cc74f870bc608559b33d8b72a4dc792f9(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, cd161c587b229cb9747bf073c6e98b0b9 c50dd5211ea3389d85952f7ad5dfd7675, byte[] c0ae48386f017a7b0f2f09804789f3cac)
		{
			string text = Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c50dd5211ea3389d85952f7ad5dfd7675.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)));
			byte[] cad83d5894302992ae418fe3ccc7f = c57022ba9c2a08b010c87dd03dad49fd5.c38e32510b20dfabf58482fbd3ac0cc25(c50dd5211ea3389d85952f7ad5dfd7675.Index);
			byte[] c20fab7e86d17e97f35dc746ef5fadd;
			if (c804bc52f7f79bffee6fd394ef382eb76.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5492))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.cc74f870bc608559b33d8b72a4dc792f9(c6114b34ba4893a53ebb4b599e0e2e3fc, cd161c587b229cb9747bf073c6e98b0b9, byte[])).MethodHandle;
				}
				byte[] array = File.ReadAllBytes(text);
				Array.Resize<byte>(ref array, cd4880843d42f3dd634ca35c8e909b573.cf79687ad3d8e4d386d79f5d02ba7e00f((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5496)));
				byte[] buffer = c57022ba9c2a08b010c87dd03dad49fd5.c4e9cee3c7bbdcba067acbf3bfeeed7a0(array, c0ae48386f017a7b0f2f09804789f3cac, cad83d5894302992ae418fe3ccc7f);
				c20fab7e86d17e97f35dc746ef5fadd = SHA1.Create().ComputeHash(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5500), (int)c50dd5211ea3389d85952f7ad5dfd7675.Size.TotalBytes);
			}
			else
			{
				if (c804bc52f7f79bffee6fd394ef382eb76.System != ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
				{
					throw new NotImplementedException();
				}
				for (;;)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				c20fab7e86d17e97f35dc746ef5fadd = c57022ba9c2a08b010c87dd03dad49fd5.c55721d9bdfe5721b9a0cd06a0920e4a4(text, c0ae48386f017a7b0f2f09804789f3cac, cad83d5894302992ae418fe3ccc7f);
			}
			return cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(c20fab7e86d17e97f35dc746ef5fadd, c50dd5211ea3389d85952f7ad5dfd7675.Hash);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001676C File Offset: 0x0001496C
		private static Tuple<int[], int> ce2c84344283c38f379659fccf6e7d5dc(int c156254c493646516c641d0e674d3e550, int cb6f83369480c118e665eca5c7dfb5fc0, int ca9d88eaa10483efeb67d84354c0f386e)
		{
			int[] array = Enumerable.Repeat<int>(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5504), cb6f83369480c118e665eca5c7dfb5fc0).ToArray<int>();
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5508);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5512); i < cb6f83369480c118e665eca5c7dfb5fc0; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5516))
			{
				int num2 = c57022ba9c2a08b010c87dd03dad49fd5.ca112baba98b54166466b5a86a17182e9(c156254c493646516c641d0e674d3e550, ca9d88eaa10483efeb67d84354c0f386e);
				num += num2;
				array[i] = num2;
				c156254c493646516c641d0e674d3e550 -= num2;
			}
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
				RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.ce2c84344283c38f379659fccf6e7d5dc(int, int, int)).MethodHandle;
			}
			return new Tuple<int[], int>(array, num);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000167F0 File Offset: 0x000149F0
		private static int ca112baba98b54166466b5a86a17182e9(int c7c2b264dabe6af7c14e50f838643b4e1, int c27e8b882560f303ef094d35a3ddf28a6)
		{
			if (c27e8b882560f303ef094d35a3ddf28a6 <= c7c2b264dabe6af7c14e50f838643b4e1)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c57022ba9c2a08b010c87dd03dad49fd5.ca112baba98b54166466b5a86a17182e9(int, int)).MethodHandle;
				}
				return c27e8b882560f303ef094d35a3ddf28a6;
			}
			return c7c2b264dabe6af7c14e50f838643b4e1;
		}

		// Token: 0x040001F0 RID: 496
		private static readonly byte[][] cc147b89ff1277e3eee847ace82ca7210 = c721f2ce58e4fe22f32427210a1521f49.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(5520));

		// Token: 0x040001F1 RID: 497
		internal const int c05703b8abafafe0ad2876ab064990881 = 65536;

		// Token: 0x040001F2 RID: 498
		private const int c7db6200c0e930ede190ff400f8dbfffb = 64512;

		// Token: 0x040001F3 RID: 499
		private const int cf413f4da95d802f104d39ef786bc4a98 = 1024;

		// Token: 0x040001F4 RID: 500
		private const int cf439881bdce4791ee86667f6fa45accc = 256;

		// Token: 0x040001F5 RID: 501
		private const int c99dd025cdd5787bb451c46a7dc74574d = 3;

		// Token: 0x02000114 RID: 276
		[CompilerGenerated]
		private sealed class cba660dd0323f43f4ba5a582cc732a0c2
		{
			// Token: 0x060008B9 RID: 2233 RVA: 0x0005CAA4 File Offset: 0x0005ACA4
			internal c34a3d9f5ce2884877848eea58fbbe484 cf3a4b33fecc1589ad5f378a7c30019d0(cd161c587b229cb9747bf073c6e98b0b9 c415370939c7835fef80fc1256dee96a0)
			{
				return c57022ba9c2a08b010c87dd03dad49fd5.c5de63ff71186576ca30d6f96f1edfe90(this.c804bc52f7f79bffee6fd394ef382eb76, c415370939c7835fef80fc1256dee96a0, this.c855425d26a0aed3e30c9ad5e80dd10c8.cc0eab3c8af7b4aa29c084139a1df3c14);
			}

			// Token: 0x0400065A RID: 1626
			public c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76;

			// Token: 0x0400065B RID: 1627
			public c9538952b0224ea717b33e0e4e7ae98c5 c855425d26a0aed3e30c9ad5e80dd10c8;
		}

		// Token: 0x02000115 RID: 277
		[CompilerGenerated]
		private sealed class caa14b5abb94da95dce278cd2899ee923
		{
			// Token: 0x0400065C RID: 1628
			public List<int>[] c4c20b928cada33135a59cb7fcb256285;

			// Token: 0x0400065D RID: 1629
			public bool[] cde88314e16e7bb5a55d88a707ca55fab;

			// Token: 0x0400065E RID: 1630
			public c57022ba9c2a08b010c87dd03dad49fd5.cf9fb18fccc2deb33dbf79bf201e2fbc6 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x02000116 RID: 278
		[CompilerGenerated]
		private sealed class c56862ec2ab39b4f939ee37095d066a3d
		{
			// Token: 0x060008BC RID: 2236 RVA: 0x0005CAF4 File Offset: 0x0005ACF4
			internal void ce51a462e66ecd24fbcf98933804ce392()
			{
				this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c4c20b928cada33135a59cb7fcb256285[this.cc4d7b4a30b1d020931ad10f9f5ad01c7] = c57022ba9c2a08b010c87dd03dad49fd5.c502d2cae1c812200527c4a223dd4b392(c57022ba9c2a08b010c87dd03dad49fd5.cc147b89ff1277e3eee847ace82ca7210[this.cc4d7b4a30b1d020931ad10f9f5ad01c7], this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c0412f9309baf06438554911feccbba06, this.c3efd14b2a8d5177dd2c2c21768185bd1, this.c248e670c92c8bf286ec14bc40a071437.cb6f83369480c118e665eca5c7dfb5fc0.Item1[this.cc4d7b4a30b1d020931ad10f9f5ad01c7], this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.cf3e794b4e35654543c0dcab929fac071, (byte)this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.c8c38354cddaefb45b9cfcd9ed2838c37.c415370939c7835fef80fc1256dee96a0.Index);
				this.c248e670c92c8bf286ec14bc40a071437.c9def284befdb85aa51808c134f9b5700.cde88314e16e7bb5a55d88a707ca55fab[this.cc4d7b4a30b1d020931ad10f9f5ad01c7] = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30184) != 0);
			}

			// Token: 0x0400065F RID: 1631
			public int cc4d7b4a30b1d020931ad10f9f5ad01c7;

			// Token: 0x04000660 RID: 1632
			public int c3efd14b2a8d5177dd2c2c21768185bd1;

			// Token: 0x04000661 RID: 1633
			public c57022ba9c2a08b010c87dd03dad49fd5.ccf806cef399ff7d46cfcbfb8288b77ef c248e670c92c8bf286ec14bc40a071437;
		}

		// Token: 0x02000117 RID: 279
		[CompilerGenerated]
		private sealed class cf9fb18fccc2deb33dbf79bf201e2fbc6
		{
			// Token: 0x04000662 RID: 1634
			public byte[] c0412f9309baf06438554911feccbba06;

			// Token: 0x04000663 RID: 1635
			public byte[] cf3e794b4e35654543c0dcab929fac071;

			// Token: 0x04000664 RID: 1636
			public cd161c587b229cb9747bf073c6e98b0b9 c415370939c7835fef80fc1256dee96a0;
		}

		// Token: 0x02000118 RID: 280
		[CompilerGenerated]
		private sealed class ccf806cef399ff7d46cfcbfb8288b77ef
		{
			// Token: 0x04000665 RID: 1637
			public Tuple<int[], int> cb6f83369480c118e665eca5c7dfb5fc0;

			// Token: 0x04000666 RID: 1638
			public c57022ba9c2a08b010c87dd03dad49fd5.caa14b5abb94da95dce278cd2899ee923 c9def284befdb85aa51808c134f9b5700;
		}
	}
}
