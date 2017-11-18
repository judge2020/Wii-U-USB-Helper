using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using NusHelper;

namespace A
{
	// Token: 0x0200006B RID: 107
	public sealed class cdb02a77cadec7790d5c7c433ab736a12 : IDisposable
	{
		// Token: 0x060002FB RID: 763 RVA: 0x00012FF4 File Offset: 0x000111F4
		public cdb02a77cadec7790d5c7c433ab736a12(WebProxy ce24dc441194d5a798fa9060d2dbb280f, bool c5dd24d45bfce24b9e8be95faf583a57f)
		{
			this.Proxy = ce24dc441194d5a798fa9060d2dbb280f;
			this.cb7762fb41a493a6f997f412f649a0329.c2484bd018cc259ebf6256e671a3c8276 += this.cf42e21f8b7db0862d132e3d64cb60517;
			NetworkChange.NetworkAvailabilityChanged += this.c43f489ac452c51fa8331b93ba4f7dc8f;
			this.c321f8ef465ab9851c8a86d35fb2d50ee = c5dd24d45bfce24b9e8be95faf583a57f;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000130D0 File Offset: 0x000112D0
		// (set) Token: 0x060002FD RID: 765 RVA: 0x000130E4 File Offset: 0x000112E4
		public WebProxy Proxy { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000130F8 File Offset: 0x000112F8
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0001310C File Offset: 0x0001130C
		public ulong MaxSpeed { get; private set; }

		// Token: 0x06000300 RID: 768 RVA: 0x00013120 File Offset: 0x00011320
		public void cee8e4d5e35198ca7f4b76be49e2197b2()
		{
			this.c7a9bdfb9a734963885e9cb6d7f3ce1cb = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4464) != 0);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00013140 File Offset: 0x00011340
		public void cd5841496c51e4ccda38bf5370111aeaa(List<c6114b34ba4893a53ebb4b599e0e2e3fc> c7cb97743dc03d0fb72a099064ab22b7f, int ca1a2f9f9f9c7757c9274972b860ab7ed = 100, int cee63b46889063a0c746dc1d3cf7f8f22 = 10000)
		{
			cdb02a77cadec7790d5c7c433ab736a12.caa07e13c0d531cbcefd934659c70ad9d caa07e13c0d531cbcefd934659c70ad9d = new cdb02a77cadec7790d5c7c433ab736a12.caa07e13c0d531cbcefd934659c70ad9d();
			caa07e13c0d531cbcefd934659c70ad9d.c4404a159870bf55bb6f111e66e59e82d = this;
			caa07e13c0d531cbcefd934659c70ad9d.c7cb97743dc03d0fb72a099064ab22b7f = c7cb97743dc03d0fb72a099064ab22b7f;
			caa07e13c0d531cbcefd934659c70ad9d.ca1a2f9f9f9c7757c9274972b860ab7ed = ca1a2f9f9f9c7757c9274972b860ab7ed;
			caa07e13c0d531cbcefd934659c70ad9d.cee63b46889063a0c746dc1d3cf7f8f22 = cee63b46889063a0c746dc1d3cf7f8f22;
			new Thread(new ThreadStart(caa07e13c0d531cbcefd934659c70ad9d.c24433587b917aa7c0bae63023e7f8daa))
			{
				IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4468) != 0),
				ApartmentState = (ApartmentState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4472),
				Priority = (ThreadPriority)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4476)
			}.Start();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000131B4 File Offset: 0x000113B4
		private void c268b4f612048303c4bc575760fc231a7(List<c6114b34ba4893a53ebb4b599e0e2e3fc> c7cb97743dc03d0fb72a099064ab22b7f)
		{
			this.cfeb99b55e59ebb9cb4ba611be417cf07 = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4480)));
			this.c73569ee2f306fe263b933db69d9fb3ae = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4484));
			this.ce2f70a07064e7ed505ec5d5912f546d7 = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4488));
			this.ccbd3b9b643dfe0abb0fb025f1da88352 = new c8d217bce073ddc882212f4d0e016403a((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4492)));
			this.c67eb813750e73f4f477d8784e8fb3136 = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4496)));
			this.c4374f30f82c40e6f571bb5452a62e538 = c7cb97743dc03d0fb72a099064ab22b7f;
			this.c4459ea1028b880865dae5dd23da9f3f2();
			for (int i = this.c473196d6b6fa0a8a22810645c051fa48; i < c7cb97743dc03d0fb72a099064ab22b7f.Count; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4516))
			{
				EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> eventHandler = this.c3c19cd1faced39a079a0f0b404062ad6;
				if (eventHandler == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.c268b4f612048303c4bc575760fc231a7(List<c6114b34ba4893a53ebb4b599e0e2e3fc>)).MethodHandle;
					}
				}
				else
				{
					eventHandler(this, new ca4d60b23ae6cb20ad43302467e6dc9e1(c7cb97743dc03d0fb72a099064ab22b7f[i], i));
				}
				this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7274), this.c473196d6b6fa0a8a22810645c051fa48 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4500), c7cb97743dc03d0fb72a099064ab22b7f.Count));
				bool flag = this.cc011f854571435a5714db0147ca4a3b8(c7cb97743dc03d0fb72a099064ab22b7f[i]) == (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4504);
				c7cb97743dc03d0fb72a099064ab22b7f[i].CurrentlyDownloaded = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4508) != 0);
				c7cb97743dc03d0fb72a099064ab22b7f[i].c7ff9b69ed99c1e935069737f80db9054();
				if (!flag)
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
					return;
				}
				if (!this.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
				this.c473196d6b6fa0a8a22810645c051fa48 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4512);
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

		// Token: 0x06000303 RID: 771 RVA: 0x0001335C File Offset: 0x0001155C
		public void c4459ea1028b880865dae5dd23da9f3f2()
		{
			this.c67eb813750e73f4f477d8784e8fb3136 = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4520)));
			using (List<c6114b34ba4893a53ebb4b599e0e2e3fc>.Enumerator enumerator = this.c4374f30f82c40e6f571bb5452a62e538.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = enumerator.Current;
					if (c6114b34ba4893a53ebb4b599e0e2e3fc.c9e33774c6343e7c7fe83022678b014ae)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.c4459ea1028b880865dae5dd23da9f3f2()).MethodHandle;
						}
						this.c67eb813750e73f4f477d8784e8fb3136 = c74ddf543ad3fdf34a89cbcc13426fc52.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c67eb813750e73f4f477d8784e8fb3136, (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4524)));
					}
					else
					{
						this.c67eb813750e73f4f477d8784e8fb3136 = c2b143215f0b748bfd5403c104882d48e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c67eb813750e73f4f477d8784e8fb3136, this.c07780748190fb218a76a2d5c97840a4a(c6114b34ba4893a53ebb4b599e0e2e3fc, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4528) != 0).c4287d6f1112583ecb2415036eb13e39d);
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
			}
			this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7355), this.c67eb813750e73f4f477d8784e8fb3136));
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00013460 File Offset: 0x00011660
		public void c426ff9b72fe5e4a2968bc46e8012f149(ulong caf60e72ea0e2ef1eff0efd30b124aad1)
		{
			this.cb7762fb41a493a6f997f412f649a0329.MaximumSpeed = caf60e72ea0e2ef1eff0efd30b124aad1;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0001347C File Offset: 0x0001167C
		public void Dispose()
		{
			this.cae0d2bce79432f2d195176e3df8302d5(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4532) != 0);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000134A0 File Offset: 0x000116A0
		~cdb02a77cadec7790d5c7c433ab736a12()
		{
			this.cae0d2bce79432f2d195176e3df8302d5(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4536) != 0);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000134D8 File Offset: 0x000116D8
		private static int cfd18337e96368f224e9e36f94eb07d73(DataSize cd4a134e922131b8761e21403285a2054, DataSize c8fce7316339febf2617106c18d157d94)
		{
			int num = (int)Math.Floor(c8fce7316339febf2617106c18d157d94.TotalBytes / cd4a134e922131b8761e21403285a2054.TotalBytes * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(4540));
			if (num < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4548))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.cfd18337e96368f224e9e36f94eb07d73(DataSize, DataSize)).MethodHandle;
				}
				num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4552);
			}
			if (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4556))
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
				num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4560);
			}
			return num;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00013560 File Offset: 0x00011760
		public static int cfd18337e96368f224e9e36f94eb07d73(long cda563c7675ea4085e6d9f75f51122d90, long c5c062ad437d48370652bc9f60a7054af)
		{
			if (c5c062ad437d48370652bc9f60a7054af == 0L)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.cfd18337e96368f224e9e36f94eb07d73(long, long)).MethodHandle;
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4564);
			}
			int result;
			try
			{
				int num = (int)Math.Floor((double)cda563c7675ea4085e6d9f75f51122d90 / (double)c5c062ad437d48370652bc9f60a7054af * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(4568));
				if (num < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4576))
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
					num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4580);
				}
				if (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4584))
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
					num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4588);
				}
				result = num;
			}
			catch
			{
				result = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4592);
			}
			return result;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00013614 File Offset: 0x00011814
		private void c6a5a6769b44a8e7794512ebf426f0e2c(string c50a614622192a0e8dcc457d46badac6a)
		{
			this.cb7762fb41a493a6f997f412f649a0329.c6df10fc1a659b98aae79de69cd590bc0();
			throw new c18bd75190a2fc901d12b96d4b630e464(c50a614622192a0e8dcc457d46badac6a);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00013634 File Offset: 0x00011834
		private void cae0d2bce79432f2d195176e3df8302d5(bool c823f5e692f6c5fba6e9a906c177cfac4)
		{
			this.c2edd31d0b9632ab69e10dbd8c5046918 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4596) != 0);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00013654 File Offset: 0x00011854
		private void c43f489ac452c51fa8331b93ba4f7dc8f(object cd7b28952603b35a45c555982e677363a, NetworkAvailabilityEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.ca1ea45d8ce30b1687680ee2eb3447b07 = cdf15457ee4816989343b6e6e96dd4cfe.IsAvailable;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00013674 File Offset: 0x00011874
		private void cf42e21f8b7db0862d132e3d64cb60517(object cd7b28952603b35a45c555982e677363a, c5f62eb0f1d1c3ecb64334326833347f1 cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = cae9a580a7e1dfb09ee42135a2efe1fb7.cd24593c859565ebb8c9faabbc5c75bef(cd7b28952603b35a45c555982e677363a);
			if (!this.ca1ea45d8ce30b1687680ee2eb3447b07)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.cf42e21f8b7db0862d132e3d64cb60517(object, c5f62eb0f1d1c3ecb64334326833347f1)).MethodHandle;
				}
				this.c6a5a6769b44a8e7794512ebf426f0e2c(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7406));
			}
			if (!this.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
				this.cb7762fb41a493a6f997f412f649a0329.c6df10fc1a659b98aae79de69cd590bc0();
			}
			this.ccbd3b9b643dfe0abb0fb025f1da88352 = c866035f717c1c145e269422264e8f.DownloadSpeed;
			ulong c5d7bf84d590334ae5c615432db3d63e = this.ccbd3b9b643dfe0abb0fb025f1da88352.c5d7bf84d590334ae5c615432db3d63e7;
			if (c5d7bf84d590334ae5c615432db3d63e > this.MaxSpeed)
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
				this.MaxSpeed = c5d7bf84d590334ae5c615432db3d63e;
			}
			try
			{
				this.ce2f70a07064e7ed505ec5d5912f546d7 = c7d35d8aac83dc5d10cf8f860b6e578b7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cfeb99b55e59ebb9cb4ba611be417cf07.Diff(c866035f717c1c145e269422264e8f.TotalDownloadedCurrentGame), this.ccbd3b9b643dfe0abb0fb025f1da88352);
				this.c73569ee2f306fe263b933db69d9fb3ae = c7d35d8aac83dc5d10cf8f860b6e578b7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c67eb813750e73f4f477d8784e8fb3136.Diff(c866035f717c1c145e269422264e8f.TotalDataDownloaded), this.ccbd3b9b643dfe0abb0fb025f1da88352);
				this.c2b9b4e1f5e4b994659fcc4723787e0f4 = c7d35d8aac83dc5d10cf8f860b6e578b7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(new DataSize((ulong)cdf15457ee4816989343b6e6e96dd4cfe.c5c7575bc6459f43445b74464676adad4).Diff(new DataSize((ulong)cdf15457ee4816989343b6e6e96dd4cfe.c2dc6e4447867c8120cd323841b96b019)), this.ccbd3b9b643dfe0abb0fb025f1da88352);
				this.c49897c739864c4655555c937ee1d0c95 = cdb02a77cadec7790d5c7c433ab736a12.cfd18337e96368f224e9e36f94eb07d73(this.cfeb99b55e59ebb9cb4ba611be417cf07, c866035f717c1c145e269422264e8f.TotalDownloadedCurrentGame);
				this.c8936be422d4aeb1e68061d8637a2cbd1 = cdb02a77cadec7790d5c7c433ab736a12.cfd18337e96368f224e9e36f94eb07d73(this.c67eb813750e73f4f477d8784e8fb3136, c866035f717c1c145e269422264e8f.TotalDataDownloaded);
				this.c688e06284a7965a52f4a7b26bc877b39 = (int)((double)cdf15457ee4816989343b6e6e96dd4cfe.c2dc6e4447867c8120cd323841b96b019 / (double)cdf15457ee4816989343b6e6e96dd4cfe.c5c7575bc6459f43445b74464676adad4 * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(4600));
				this.c8160e04268f05e1c04cc4d34bf0e3a14(this.c49897c739864c4655555c937ee1d0c95, this.c8936be422d4aeb1e68061d8637a2cbd1, this.c688e06284a7965a52f4a7b26bc877b39, this.ce2f70a07064e7ed505ec5d5912f546d7, this.c73569ee2f306fe263b933db69d9fb3ae, this.c2b9b4e1f5e4b994659fcc4723787e0f4, this.ccbd3b9b643dfe0abb0fb025f1da88352, c0e041e021e04e712883cd11308c15013.cab55a050df275722227783d6686266c9);
			}
			catch
			{
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00013844 File Offset: 0x00011A44
		private void c15c723f93928ba4ee7360965f6aeebfe(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, cbcbdbfc95367bfec4c11b371d883aa2d cad48e7cec482eb202b35baba9979de2f, string c54a7d6cb5c0c0420ac46560b5c93cf03)
		{
			this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7431));
			string text = Path.Combine(c54a7d6cb5c0c0420ac46560b5c93cf03, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6278));
			if (c804bc52f7f79bffee6fd394ef382eb76.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4608))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.c15c723f93928ba4ee7360965f6aeebfe(c6114b34ba4893a53ebb4b599e0e2e3fc, cbcbdbfc95367bfec4c11b371d883aa2d, string)).MethodHandle;
				}
				this.cb7762fb41a493a6f997f412f649a0329.c0ddecd1ce433b283de66e0c68db8aa47(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7478), c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a), text, (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4612)), (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4616), this.Proxy, null, null, (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4620), (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4624));
				return;
			}
			BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4628)));
			try
			{
				binaryWriter.Write(cad48e7cec482eb202b35baba9979de2f.Certificate1);
				binaryWriter.Write(cad48e7cec482eb202b35baba9979de2f.Certificate2);
				binaryWriter.Write(cbcbdbfc95367bfec4c11b371d883aa2d.c7c9e64eb219414d7c09bdb5b31c98d84);
			}
			finally
			{
				if (binaryWriter != null)
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
					((IDisposable)binaryWriter).Dispose();
				}
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00013964 File Offset: 0x00011B64
		private cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92 cb9382161ae79e5f7311ff0adf39ab78f(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, cd161c587b229cb9747bf073c6e98b0b9 c50dd5211ea3389d85952f7ad5dfd7675, string c158ce8059478abee6d499bdc639f98e0, cdb02a77cadec7790d5c7c433ab736a12.c5daa42f7ee40f8c4df8d6140f0cbe2ba c061cbd9e75960edd394031c7a5d843ed, ulong ce1d9b2b16796a3430ee2f474fb406ca7 = 0UL)
		{
			string c0d6c37d812d5d4b610705a6421056252 = c50dd5211ea3389d85952f7ad5dfd7675.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293));
			string c0d6c37d812d5d4b610705a64210562522;
			if (c061cbd9e75960edd394031c7a5d843ed != cdb02a77cadec7790d5c7c433ab736a12.c5daa42f7ee40f8c4df8d6140f0cbe2ba.c3335864481ae04f85ec1bafc5f4898f9)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.cb9382161ae79e5f7311ff0adf39ab78f(c6114b34ba4893a53ebb4b599e0e2e3fc, cd161c587b229cb9747bf073c6e98b0b9, string, cdb02a77cadec7790d5c7c433ab736a12.c5daa42f7ee40f8c4df8d6140f0cbe2ba, ulong)).MethodHandle;
				}
				c0d6c37d812d5d4b610705a64210562522 = "";
			}
			else
			{
				c0d6c37d812d5d4b610705a64210562522 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308);
			}
			string text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c0d6c37d812d5d4b610705a6421056252, c0d6c37d812d5d4b610705a64210562522);
			this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7493), text));
			if (this.Proxy != null)
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
				this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7552), this.Proxy.Address));
			}
			if (c061cbd9e75960edd394031c7a5d843ed == cdb02a77cadec7790d5c7c433ab736a12.c5daa42f7ee40f8c4df8d6140f0cbe2ba.c3335864481ae04f85ec1bafc5f4898f9)
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
				this.cb7762fb41a493a6f997f412f649a0329.c0ddecd1ce433b283de66e0c68db8aa47(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a, text), c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c158ce8059478abee6d499bdc639f98e0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308)), ce1d9b2b16796a3430ee2f474fb406ca7, (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4632), this.Proxy, null, null, (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4636), (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4640));
			}
			else if (c50dd5211ea3389d85952f7ad5dfd7675.c5a0797ee67f90b4af0433c5d7ee00865)
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
				this.cb7762fb41a493a6f997f412f649a0329.c0ddecd1ce433b283de66e0c68db8aa47(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a, text), c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c158ce8059478abee6d499bdc639f98e0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)), ce1d9b2b16796a3430ee2f474fb406ca7, (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4644), this.Proxy, File.ReadAllBytes(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c158ce8059478abee6d499bdc639f98e0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308))), c804bc52f7f79bffee6fd394ef382eb76.Ticket.cc0eab3c8af7b4aa29c084139a1df3c14, (byte)c50dd5211ea3389d85952f7ad5dfd7675.Index, (long)c50dd5211ea3389d85952f7ad5dfd7675.Size.TotalBytes);
			}
			else
			{
				this.cb7762fb41a493a6f997f412f649a0329.c0ddecd1ce433b283de66e0c68db8aa47(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a, text), c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c158ce8059478abee6d499bdc639f98e0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)), ce1d9b2b16796a3430ee2f474fb406ca7, (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4648), this.Proxy, null, null, (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4652), (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4656));
			}
			if (!this.cb7762fb41a493a6f997f412f649a0329.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
				return (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4660);
			}
			return (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4664);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00013BB0 File Offset: 0x00011DB0
		private c9538952b0224ea717b33e0e4e7ae98c5 c6a17d278b91e8b236e17e76d379fa706(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7583));
			string text = Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6259));
			if (c804bc52f7f79bffee6fd394ef382eb76.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4668))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.c6a17d278b91e8b236e17e76d379fa706(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(c804bc52f7f79bffee6fd394ef382eb76) != null)
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
					if (c804bc52f7f79bffee6fd394ef382eb76.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4672))
					{
						for (;;)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							goto IL_8D;
						}
					}
				}
				if (!c804bc52f7f79bffee6fd394ef382eb76.cf7f2b1967398c4cc0c607544f80499bc)
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
					this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7690));
					File.WriteAllBytes(text, c804bc52f7f79bffee6fd394ef382eb76.TicketArray);
					return c804bc52f7f79bffee6fd394ef382eb76.Ticket;
				}
				this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7725));
				byte[] array = File.ReadAllBytes(Path.Combine(Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5880)), c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5895))));
				c804bc52f7f79bffee6fd394ef382eb76.TicketArray = array;
				File.WriteAllBytes(text, array);
				c804bc52f7f79bffee6fd394ef382eb76.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(c804bc52f7f79bffee6fd394ef382eb76.TicketArray, c804bc52f7f79bffee6fd394ef382eb76.System);
				return c804bc52f7f79bffee6fd394ef382eb76.Ticket;
			}
			IL_8D:
			this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7620));
			this.cb7762fb41a493a6f997f412f649a0329.c0ddecd1ce433b283de66e0c68db8aa47(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7675), c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a), text, (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4676)), (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4680), this.Proxy, null, null, (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4684), (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4688));
			c804bc52f7f79bffee6fd394ef382eb76.TicketArray = File.ReadAllBytes(text);
			c804bc52f7f79bffee6fd394ef382eb76.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(text, c804bc52f7f79bffee6fd394ef382eb76.System);
			return c804bc52f7f79bffee6fd394ef382eb76.Ticket;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00013DB0 File Offset: 0x00011FB0
		private cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92 cdbd1fc07b3867c10a942bfaca73063be(c5409344e1c2b74fa8c9a4d620ccb8d48 c804bc52f7f79bffee6fd394ef382eb76)
		{
			new cd7b202d59bd5ce2d0b930d9b35e3a37d(c804bc52f7f79bffee6fd394ef382eb76).ShowDialog();
			return (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4692);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00013DD8 File Offset: 0x00011FD8
		private void cbf3cb8135cbff928c26565e1aebcb37d(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			try
			{
				new WebClient().DownloadDataAsync(new Uri(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7792), c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw)));
			}
			catch
			{
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00013E2C File Offset: 0x0001202C
		private cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92 cc011f854571435a5714db0147ca4a3b8(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			c59ff87f6bdc69ff3440c18f170633236 ca435006c85356cb7385a782de8889a0a = c804bc52f7f79bffee6fd394ef382eb76.ca435006c85356cb7385a782de8889a0a;
			this.cb7762fb41a493a6f997f412f649a0329.c4f3230a32332493721e2920c018c45f2();
			this.cbf3cb8135cbff928c26565e1aebcb37d(c804bc52f7f79bffee6fd394ef382eb76);
			this.ce2f70a07064e7ed505ec5d5912f546d7 = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4696));
			this.c2b9b4e1f5e4b994659fcc4723787e0f4 = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4700));
			this.ccbd3b9b643dfe0abb0fb025f1da88352 = new c8d217bce073ddc882212f4d0e016403a((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4704)));
			c804bc52f7f79bffee6fd394ef382eb76.CurrentlyDownloaded = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4708) != 0);
			if (!Directory.Exists(c804bc52f7f79bffee6fd394ef382eb76.OutputPath))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.cc011f854571435a5714db0147ca4a3b8(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				Directory.CreateDirectory(c804bc52f7f79bffee6fd394ef382eb76.OutputPath);
			}
			if (c804bc52f7f79bffee6fd394ef382eb76.c9e33774c6343e7c7fe83022678b014ae)
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
				return this.cdbd1fc07b3867c10a942bfaca73063be(c933d8f390d7a245458355cef338c6754.cd24593c859565ebb8c9faabbc5c75bef(c804bc52f7f79bffee6fd394ef382eb76));
			}
			cbcbdbfc95367bfec4c11b371d883aa2d cbcbdbfc95367bfec4c11b371d883aa2d = this.c07780748190fb218a76a2d5c97840a4a(c804bc52f7f79bffee6fd394ef382eb76, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4712) != 0);
			c9538952b0224ea717b33e0e4e7ae98c5 c9538952b0224ea717b33e0e4e7ae98c = this.c6a17d278b91e8b236e17e76d379fa706(c804bc52f7f79bffee6fd394ef382eb76);
			if (c804bc52f7f79bffee6fd394ef382eb76.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4716))
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
				this.c15c723f93928ba4ee7360965f6aeebfe(c804bc52f7f79bffee6fd394ef382eb76, cbcbdbfc95367bfec4c11b371d883aa2d, c804bc52f7f79bffee6fd394ef382eb76.OutputPath);
			}
			this.cfeb99b55e59ebb9cb4ba611be417cf07 = cbcbdbfc95367bfec4c11b371d883aa2d.c4287d6f1112583ecb2415036eb13e39d;
			this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7911), this.cfeb99b55e59ebb9cb4ba611be417cf07));
			this.c8160e04268f05e1c04cc4d34bf0e3a14(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4720), this.c8936be422d4aeb1e68061d8637a2cbd1, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4724), this.ce2f70a07064e7ed505ec5d5912f546d7, this.c73569ee2f306fe263b933db69d9fb3ae, this.c2b9b4e1f5e4b994659fcc4723787e0f4, new c8d217bce073ddc882212f4d0e016403a((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4728))), c804bc52f7f79bffee6fd394ef382eb76);
			int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4732);
			while (i < (int)cbcbdbfc95367bfec4c11b371d883aa2d.NumOfContents)
			{
				if (!this.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
					return (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4736);
				}
				for (;;)
				{
					string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7950);
					object[] array = c03afd7759879ce2659a1d311b66f5509.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4740));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4744)] = i + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4748);
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4752)] = cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].ContentId;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4756)] = cbcbdbfc95367bfec4c11b371d883aa2d.NumOfContents;
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4760)] = cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].Size;
					this.cc96240731d0e22ec03446ef0617e66ba(string.Format(format, array));
					string text = Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)));
					ulong num = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4764));
					if (File.Exists(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8049))))
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
						this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8074));
						File.Delete(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8049)));
					}
					if (File.Exists(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299))))
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
						num = (ulong)new FileInfo(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299))).Length;
						this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8149));
						if (num == cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].Size.TotalBytes)
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
							this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8224));
							if (cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].c5a0797ee67f90b4af0433c5d7ee00865)
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
								if (!File.Exists(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308))))
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
									this.cb9382161ae79e5f7311ff0adf39ab78f(c804bc52f7f79bffee6fd394ef382eb76, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i], text, (cdb02a77cadec7790d5c7c433ab736a12.c5daa42f7ee40f8c4df8d6140f0cbe2ba)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4768), (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4772)));
								}
							}
							c34a3d9f5ce2884877848eea58fbbe484 c34a3d9f5ce2884877848eea58fbbe = c57022ba9c2a08b010c87dd03dad49fd5.c5de63ff71186576ca30d6f96f1edfe90(c804bc52f7f79bffee6fd394ef382eb76, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i], c9538952b0224ea717b33e0e4e7ae98c.cc0eab3c8af7b4aa29c084139a1df3c14);
							if (!c34a3d9f5ce2884877848eea58fbbe.c39b80b0856616d219a502e68001f5ea0)
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
								if (cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].c5a0797ee67f90b4af0433c5d7ee00865)
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
									if (c804bc52f7f79bffee6fd394ef382eb76.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4776))
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
										this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8285), c34a3d9f5ce2884877848eea58fbbe.cfdba12bccc3315cf7f9431d22eea48a9.Count, c34a3d9f5ce2884877848eea58fbbe.cfdba12bccc3315cf7f9431d22eea48a9.Count * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4780)));
										this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8400));
										string c0d6c37d812d5d4b610705a6421056252 = cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293));
										c866035f717c1c145e269422264e8f519.c5855ad2b508187b1ec66bb34f916806c(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a, c0d6c37d812d5d4b610705a6421056252), c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)), File.ReadAllBytes(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308))), c804bc52f7f79bffee6fd394ef382eb76.Ticket.cc0eab3c8af7b4aa29c084139a1df3c14, c34a3d9f5ce2884877848eea58fbbe.cfdba12bccc3315cf7f9431d22eea48a9);
										continue;
									}
								}
								this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8554));
								File.Delete(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)));
								continue;
							}
							goto IL_591;
						}
						else
						{
							if (cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].Size.TotalBytes < num)
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
								this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8751));
								File.Delete(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299)));
								continue;
							}
							DataSize dataSize = new DataSize(num);
							this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8891), dataSize));
						}
					}
					try
					{
						cbec968781acf39706554079a117314a2.c8fef9bc53cc01081565ec1c04d455277((uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4784));
						this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8972));
						if (cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].c5a0797ee67f90b4af0433c5d7ee00865)
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
							this.cb9382161ae79e5f7311ff0adf39ab78f(c804bc52f7f79bffee6fd394ef382eb76, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i], text, (cdb02a77cadec7790d5c7c433ab736a12.c5daa42f7ee40f8c4df8d6140f0cbe2ba)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4788), (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4792)));
						}
						if (this.cb9382161ae79e5f7311ff0adf39ab78f(c804bc52f7f79bffee6fd394ef382eb76, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i], text, (cdb02a77cadec7790d5c7c433ab736a12.c5daa42f7ee40f8c4df8d6140f0cbe2ba)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4796), num) == (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4800))
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
							return (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4804);
						}
						if (this.c321f8ef465ab9851c8a86d35fb2d50ee)
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
							if (cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].c5a0797ee67f90b4af0433c5d7ee00865)
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
								if (ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4808))
								{
									for (;;)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										goto IL_788;
									}
								}
							}
							this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9017));
							if (!c57022ba9c2a08b010c87dd03dad49fd5.c5de63ff71186576ca30d6f96f1edfe90(c804bc52f7f79bffee6fd394ef382eb76, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i], c9538952b0224ea717b33e0e4e7ae98c.cc0eab3c8af7b4aa29c084139a1df3c14).c39b80b0856616d219a502e68001f5ea0)
							{
								c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = this.cb7762fb41a493a6f997f412f649a0329;
								c866035f717c1c145e269422264e8f.TotalDataDownloaded = c3722f2ce35676c2ce539bc2eb02390db.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c866035f717c1c145e269422264e8f.TotalDataDownloaded, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].Size);
								c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f2 = this.cb7762fb41a493a6f997f412f649a0329;
								c866035f717c1c145e269422264e8f2.TotalDownloadedCurrentGame = c3722f2ce35676c2ce539bc2eb02390db.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c866035f717c1c145e269422264e8f2.TotalDownloadedCurrentGame, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].Size);
								continue;
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
						}
						IL_788:
						break;
					}
					catch (Exception ex)
					{
						this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9060), i + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4812), cbcbdbfc95367bfec4c11b371d883aa2d.NumOfContents));
						this.cc96240731d0e22ec03446ef0617e66ba(ex.Message);
						c804bc52f7f79bffee6fd394ef382eb76.CurrentlyDownloaded = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4816) != 0);
						this.c6a5a6769b44a8e7794512ebf426f0e2c(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9143), ex.Message));
					}
					goto IL_8AC;
				}
				IL_8B1:
				i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4820);
				continue;
				IL_591:
				this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(8690));
				c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f3 = this.cb7762fb41a493a6f997f412f649a0329;
				c866035f717c1c145e269422264e8f3.TotalDownloadedCurrentGame = c74ddf543ad3fdf34a89cbcc13426fc52.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c866035f717c1c145e269422264e8f3.TotalDownloadedCurrentGame, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].Size.TotalBytes);
				c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f4 = this.cb7762fb41a493a6f997f412f649a0329;
				c866035f717c1c145e269422264e8f4.TotalDataDownloaded = c2b143215f0b748bfd5403c104882d48e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c866035f717c1c145e269422264e8f4.TotalDataDownloaded, cbcbdbfc95367bfec4c11b371d883aa2d.ca41cd3b028585a369298639868832973[i].Size);
				goto IL_8B1;
				IL_8AC:
				GC.Collect();
				goto IL_8B1;
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
			this.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9200), c804bc52f7f79bffee6fd394ef382eb76.TitleId, cbcbdbfc95367bfec4c11b371d883aa2d.TitleVersion));
			this.c8160e04268f05e1c04cc4d34bf0e3a14(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4824), this.c8936be422d4aeb1e68061d8637a2cbd1, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4828), new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4832)), this.c73569ee2f306fe263b933db69d9fb3ae, new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4836)), this.ccbd3b9b643dfe0abb0fb025f1da88352, c804bc52f7f79bffee6fd394ef382eb76);
			return (cdb02a77cadec7790d5c7c433ab736a12.c0ea9c760767564d4c7e17267d5fa6f92)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4840);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000147B4 File Offset: 0x000129B4
		private cbcbdbfc95367bfec4c11b371d883aa2d c07780748190fb218a76a2d5c97840a4a(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, bool cd6b94927c7fbde83cc72106a0e3ee52d = true)
		{
			this.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9277));
			string path = Path.Combine(c804bc52f7f79bffee6fd394ef382eb76.OutputPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767));
			if (!cd6b94927c7fbde83cc72106a0e3ee52d)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.c07780748190fb218a76a2d5c97840a4a(c6114b34ba4893a53ebb4b599e0e2e3fc, bool)).MethodHandle;
				}
				if (c804bc52f7f79bffee6fd394ef382eb76.Tmd != null)
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
					return c804bc52f7f79bffee6fd394ef382eb76.Tmd;
				}
			}
			c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = new c866035f717c1c145e269422264e8f519();
			byte[] array = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
			try
			{
				if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(c804bc52f7f79bffee6fd394ef382eb76) != null)
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
					array = c866035f717c1c145e269422264e8f.cd13dfe553208f0b407836d345c6897d0(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1314), c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a, c804bc52f7f79bffee6fd394ef382eb76.Version));
				}
				else
				{
					array = c866035f717c1c145e269422264e8f.cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c804bc52f7f79bffee6fd394ef382eb76.cf25635e89f76877f4315886ba0dfe61a, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1286)));
				}
				c804bc52f7f79bffee6fd394ef382eb76.Tmd = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(array, c804bc52f7f79bffee6fd394ef382eb76.System);
			}
			catch (Exception)
			{
				this.c6a5a6769b44a8e7794512ebf426f0e2c(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9314));
			}
			if (cd6b94927c7fbde83cc72106a0e3ee52d)
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
				File.WriteAllBytes(path, array);
			}
			return c804bc52f7f79bffee6fd394ef382eb76.Tmd;
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000314 RID: 788 RVA: 0x000148F0 File Offset: 0x00012AF0
		// (remove) Token: 0x06000315 RID: 789 RVA: 0x00014940 File Offset: 0x00012B40
		public event EventHandler<string> c2c07e1cf16bbdc4cb1fad47219919ebb
		{
			[CompilerGenerated]
			add
			{
				EventHandler<string> eventHandler = this.c2c07e1cf16bbdc4cb1fad47219919ebb;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = cb137dbf62cacb3d6d5a05e5cc026608a.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.c2c07e1cf16bbdc4cb1fad47219919ebb, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.add_c2c07e1cf16bbdc4cb1fad47219919ebb(EventHandler<string>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<string> eventHandler = this.c2c07e1cf16bbdc4cb1fad47219919ebb;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = cb137dbf62cacb3d6d5a05e5cc026608a.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.c2c07e1cf16bbdc4cb1fad47219919ebb, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.remove_c2c07e1cf16bbdc4cb1fad47219919ebb(EventHandler<string>)).MethodHandle;
				}
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000316 RID: 790 RVA: 0x00014990 File Offset: 0x00012B90
		// (remove) Token: 0x06000317 RID: 791 RVA: 0x000149E0 File Offset: 0x00012BE0
		public event EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> c3c19cd1faced39a079a0f0b404062ad6
		{
			[CompilerGenerated]
			add
			{
				EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> eventHandler = this.c3c19cd1faced39a079a0f0b404062ad6;
				EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> value2 = caef9f826c1bb5ec01aa968d5ea37c616.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1>>(ref this.c3c19cd1faced39a079a0f0b404062ad6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.add_c3c19cd1faced39a079a0f0b404062ad6(EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> eventHandler = this.c3c19cd1faced39a079a0f0b404062ad6;
				EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1> value2 = caef9f826c1bb5ec01aa968d5ea37c616.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1>>(ref this.c3c19cd1faced39a079a0f0b404062ad6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.remove_c3c19cd1faced39a079a0f0b404062ad6(EventHandler<ca4d60b23ae6cb20ad43302467e6dc9e1>)).MethodHandle;
				}
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000318 RID: 792 RVA: 0x00014A30 File Offset: 0x00012C30
		// (remove) Token: 0x06000319 RID: 793 RVA: 0x00014A80 File Offset: 0x00012C80
		public event EventHandler<c8e60ceced0ce323f661e853233d10ec2> cdcc2c8329c5e63d415472bd3bd0a99aa
		{
			[CompilerGenerated]
			add
			{
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler = this.cdcc2c8329c5e63d415472bd3bd0a99aa;
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c8e60ceced0ce323f661e853233d10ec2> value2 = ceb2cf459e5f1c83fa9071b906b061820.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c8e60ceced0ce323f661e853233d10ec2>>(ref this.cdcc2c8329c5e63d415472bd3bd0a99aa, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.add_cdcc2c8329c5e63d415472bd3bd0a99aa(EventHandler<c8e60ceced0ce323f661e853233d10ec2>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler = this.cdcc2c8329c5e63d415472bd3bd0a99aa;
				EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c8e60ceced0ce323f661e853233d10ec2> value2 = ceb2cf459e5f1c83fa9071b906b061820.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c8e60ceced0ce323f661e853233d10ec2>>(ref this.cdcc2c8329c5e63d415472bd3bd0a99aa, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.remove_cdcc2c8329c5e63d415472bd3bd0a99aa(EventHandler<c8e60ceced0ce323f661e853233d10ec2>)).MethodHandle;
				}
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600031A RID: 794 RVA: 0x00014AD0 File Offset: 0x00012CD0
		// (remove) Token: 0x0600031B RID: 795 RVA: 0x00014B20 File Offset: 0x00012D20
		public event EventHandler<ce91c3ee3b6503970820b59a90b300d72> c2484bd018cc259ebf6256e671a3c8276
		{
			[CompilerGenerated]
			add
			{
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ce91c3ee3b6503970820b59a90b300d72> value2 = cac2c857819b151ab47474f5ab0c4c8a9.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ce91c3ee3b6503970820b59a90b300d72>>(ref this.c2484bd018cc259ebf6256e671a3c8276, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.add_c2484bd018cc259ebf6256e671a3c8276(EventHandler<ce91c3ee3b6503970820b59a90b300d72>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
				EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ce91c3ee3b6503970820b59a90b300d72> value2 = cac2c857819b151ab47474f5ab0c4c8a9.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ce91c3ee3b6503970820b59a90b300d72>>(ref this.c2484bd018cc259ebf6256e671a3c8276, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.remove_c2484bd018cc259ebf6256e671a3c8276(EventHandler<ce91c3ee3b6503970820b59a90b300d72>)).MethodHandle;
				}
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00014B70 File Offset: 0x00012D70
		private void c8160e04268f05e1c04cc4d34bf0e3a14(int c4f93ba5cb13973cc7550acdf5c8a6bea, int c271cb122814a1639c9b4c33232d68a4b, int c13e304b00591f2c797e3856730c47e6e, TimeSpan c401b7441ddb3aa43878c7c4b97752638, TimeSpan c600a4a1c8a0019963319f5fca826f0e7, TimeSpan c134046cec2f5972d4d005d048fd3540f, c8d217bce073ddc882212f4d0e016403a cef94e12d085457557bbcac9bef54a336, c6114b34ba4893a53ebb4b599e0e2e3fc cb389d4cb83e6d78b194a2bee76aead9f)
		{
			if (c558b1384e26aa4f6a6f45fe8364fe1a2.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(DateTime.Now, this.c96c035bc271c56c4d986f916e13c075f).TotalSeconds < cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(4844))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.c8160e04268f05e1c04cc4d34bf0e3a14(int, int, int, TimeSpan, TimeSpan, TimeSpan, c8d217bce073ddc882212f4d0e016403a, c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				return;
			}
			this.c96c035bc271c56c4d986f916e13c075f = DateTime.Now;
			EventHandler<ce91c3ee3b6503970820b59a90b300d72> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
			if (eventHandler == null)
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
				return;
			}
			eventHandler(this, new ce91c3ee3b6503970820b59a90b300d72(c4f93ba5cb13973cc7550acdf5c8a6bea, c271cb122814a1639c9b4c33232d68a4b, c13e304b00591f2c797e3856730c47e6e, c401b7441ddb3aa43878c7c4b97752638, c600a4a1c8a0019963319f5fca826f0e7, c134046cec2f5972d4d005d048fd3540f, cef94e12d085457557bbcac9bef54a336, cb389d4cb83e6d78b194a2bee76aead9f));
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00014BF8 File Offset: 0x00012DF8
		private void cc96240731d0e22ec03446ef0617e66ba(string c3d57b353c405c58b3e7b1741fb443d42)
		{
			EventHandler<string> eventHandler = this.c2c07e1cf16bbdc4cb1fad47219919ebb;
			if (eventHandler == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.cc96240731d0e22ec03446ef0617e66ba(string)).MethodHandle;
				}
				return;
			}
			eventHandler(this, c3d57b353c405c58b3e7b1741fb443d42);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00014C2C File Offset: 0x00012E2C
		private void c64db9bc8e26edcceaa2cbac5c0631d92(string caa8e258c52513a9c340665e36eabb297, bool ceaf5c4c1b21e209e4b267f37b2d7ef3e)
		{
			EventHandler<c8e60ceced0ce323f661e853233d10ec2> eventHandler = this.cdcc2c8329c5e63d415472bd3bd0a99aa;
			if (eventHandler == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.c64db9bc8e26edcceaa2cbac5c0631d92(string, bool)).MethodHandle;
				}
				return;
			}
			eventHandler(this, new c8e60ceced0ce323f661e853233d10ec2(caa8e258c52513a9c340665e36eabb297, ceaf5c4c1b21e209e4b267f37b2d7ef3e, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4852)));
		}

		// Token: 0x040001AF RID: 431
		public int c473196d6b6fa0a8a22810645c051fa48;

		// Token: 0x040001B0 RID: 432
		private volatile bool c7a9bdfb9a734963885e9cb6d7f3ce1cb = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4856) != 0;

		// Token: 0x040001B1 RID: 433
		private const double c21d0af8e154049749bc58355b9d02867 = 0.1;

		// Token: 0x040001B2 RID: 434
		[CompilerGenerated]
		private WebProxy c5a670722d2afd6ebe91a0b2e45e7067e;

		// Token: 0x040001B3 RID: 435
		[CompilerGenerated]
		private ulong c0efe58f0a11572e883c208ca92f48bc3;

		// Token: 0x040001B4 RID: 436
		private readonly c866035f717c1c145e269422264e8f519 cb7762fb41a493a6f997f412f649a0329 = new c866035f717c1c145e269422264e8f519();

		// Token: 0x040001B5 RID: 437
		private volatile bool ca1ea45d8ce30b1687680ee2eb3447b07 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4860) != 0;

		// Token: 0x040001B6 RID: 438
		private List<c6114b34ba4893a53ebb4b599e0e2e3fc> c4374f30f82c40e6f571bb5452a62e538;

		// Token: 0x040001B7 RID: 439
		private bool c321f8ef465ab9851c8a86d35fb2d50ee;

		// Token: 0x040001B8 RID: 440
		private c8d217bce073ddc882212f4d0e016403a ccbd3b9b643dfe0abb0fb025f1da88352;

		// Token: 0x040001B9 RID: 441
		private TimeSpan c2b9b4e1f5e4b994659fcc4723787e0f4;

		// Token: 0x040001BA RID: 442
		private int c688e06284a7965a52f4a7b26bc877b39;

		// Token: 0x040001BB RID: 443
		private TimeSpan ce2f70a07064e7ed505ec5d5912f546d7 = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4864));

		// Token: 0x040001BC RID: 444
		private int c49897c739864c4655555c937ee1d0c95;

		// Token: 0x040001BD RID: 445
		private bool c2edd31d0b9632ab69e10dbd8c5046918;

		// Token: 0x040001BE RID: 446
		private TimeSpan c73569ee2f306fe263b933db69d9fb3ae = new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4868));

		// Token: 0x040001BF RID: 447
		private int c8936be422d4aeb1e68061d8637a2cbd1;

		// Token: 0x040001C0 RID: 448
		private DataSize cfeb99b55e59ebb9cb4ba611be417cf07 = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4872)));

		// Token: 0x040001C1 RID: 449
		private DataSize c67eb813750e73f4f477d8784e8fb3136 = new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4876)));

		// Token: 0x040001C2 RID: 450
		private DateTime c96c035bc271c56c4d986f916e13c075f = DateTime.MinValue;

		// Token: 0x0200010E RID: 270
		public struct cfbcf84e3bd62575a5abcb876df342eb4
		{
			// Token: 0x04000647 RID: 1607
			public DataSize c029cb26b0aae604f5c2d4c53cbc49f62;

			// Token: 0x04000648 RID: 1608
			public TitleId cced90bbc7aa0995aa10924a12b207d73;
		}

		// Token: 0x0200010F RID: 271
		public struct c88be22e7b98870bdaf063358234dbd5e
		{
			// Token: 0x04000649 RID: 1609
			public DataSize c029cb26b0aae604f5c2d4c53cbc49f62;

			// Token: 0x0400064A RID: 1610
			public TitleId cced90bbc7aa0995aa10924a12b207d73;

			// Token: 0x0400064B RID: 1611
			public string c0b9a995f9c2313cad22315173d49b769;

			// Token: 0x0400064C RID: 1612
			public string c00bbf2c37f24662356c32f585e666e5a;

			// Token: 0x0400064D RID: 1613
			public string cc0eab3c8af7b4aa29c084139a1df3c14;
		}

		// Token: 0x02000110 RID: 272
		private enum c5daa42f7ee40f8c4df8d6140f0cbe2ba
		{
			// Token: 0x0400064F RID: 1615
			c3335864481ae04f85ec1bafc5f4898f9,
			// Token: 0x04000650 RID: 1616
			c46f48a49be6ee0f89feb9c2311c0031b
		}

		// Token: 0x02000111 RID: 273
		private enum c0ea9c760767564d4c7e17267d5fa6f92
		{
			// Token: 0x04000652 RID: 1618
			cc8c2ceb85ff44f36dd8f5a73251ea1af,
			// Token: 0x04000653 RID: 1619
			c6889450a48d299ebf2287450e166d567
		}

		// Token: 0x02000112 RID: 274
		[CompilerGenerated]
		private sealed class caa07e13c0d531cbcefd934659c70ad9d
		{
			// Token: 0x060008B5 RID: 2229 RVA: 0x0005C6DC File Offset: 0x0005A8DC
			internal void c24433587b917aa7c0bae63023e7f8daa()
			{
				bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30116) != 0;
				this.c4404a159870bf55bb6f111e66e59e82d.c473196d6b6fa0a8a22810645c051fa48 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30120);
				int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30124);
				string arg = "";
				while (flag)
				{
					try
					{
						this.c4404a159870bf55bb6f111e66e59e82d.cb7762fb41a493a6f997f412f649a0329.cd1905a0bc7e6a242577c1788a70bfbc1();
						this.c4404a159870bf55bb6f111e66e59e82d.c268b4f612048303c4bc575760fc231a7(this.c7cb97743dc03d0fb72a099064ab22b7f);
						flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30128) != 0);
					}
					catch (Exception ex)
					{
						arg = ex.Message;
						this.c4404a159870bf55bb6f111e66e59e82d.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97727), ex.Message));
						this.c4404a159870bf55bb6f111e66e59e82d.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97750), num + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30132), this.ca1a2f9f9f9c7757c9274972b860ab7ed));
						this.c4404a159870bf55bb6f111e66e59e82d.cc96240731d0e22ec03446ef0617e66ba(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97793), this.cee63b46889063a0c746dc1d3cf7f8f22));
						num += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30136);
						if (num < this.ca1a2f9f9f9c7757c9274972b860ab7ed)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(cdb02a77cadec7790d5c7c433ab736a12.caa07e13c0d531cbcefd934659c70ad9d.c24433587b917aa7c0bae63023e7f8daa()).MethodHandle;
							}
							if (this.c4404a159870bf55bb6f111e66e59e82d.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
								bool flag2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30140) != 0;
								int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30144);
								while (flag2)
								{
									num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30148);
									Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30152));
									if (num2 >= this.cee63b46889063a0c746dc1d3cf7f8f22)
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
										flag2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30156) != 0);
									}
									if (!this.c4404a159870bf55bb6f111e66e59e82d.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
									{
										IL_1C2:
										flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30160) != 0);
										goto IL_208;
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
								for (;;)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									goto IL_1C2;
								}
							}
						}
						this.c4404a159870bf55bb6f111e66e59e82d.cc96240731d0e22ec03446ef0617e66ba(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97830));
						this.c4404a159870bf55bb6f111e66e59e82d.c7a9bdfb9a734963885e9cb6d7f3ce1cb = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30164) != 0);
						flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30168) != 0);
						IL_208:;
					}
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
				cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = this.c4404a159870bf55bb6f111e66e59e82d;
				string caa8e258c52513a9c340665e36eabb;
				if (!this.c4404a159870bf55bb6f111e66e59e82d.c7a9bdfb9a734963885e9cb6d7f3ce1cb)
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
					caa8e258c52513a9c340665e36eabb = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97947), arg);
				}
				else
				{
					caa8e258c52513a9c340665e36eabb = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97994);
				}
				cdb02a77cadec7790d5c7c433ab736a.c64db9bc8e26edcceaa2cbac5c0631d92(caa8e258c52513a9c340665e36eabb, (this.c4404a159870bf55bb6f111e66e59e82d.c7a9bdfb9a734963885e9cb6d7f3ce1cb ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30172));
			}

			// Token: 0x04000654 RID: 1620
			public List<c6114b34ba4893a53ebb4b599e0e2e3fc> c7cb97743dc03d0fb72a099064ab22b7f;

			// Token: 0x04000655 RID: 1621
			public int ca1a2f9f9f9c7757c9274972b860ab7ed;

			// Token: 0x04000656 RID: 1622
			public int cee63b46889063a0c746dc1d3cf7f8f22;

			// Token: 0x04000657 RID: 1623
			public cdb02a77cadec7790d5c7c433ab736a12 c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
