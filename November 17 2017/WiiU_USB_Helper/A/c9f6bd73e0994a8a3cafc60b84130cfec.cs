using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace A
{
	// Token: 0x02000070 RID: 112
	public sealed class c9f6bd73e0994a8a3cafc60b84130cfec
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600032E RID: 814 RVA: 0x00014E00 File Offset: 0x00013000
		// (remove) Token: 0x0600032F RID: 815 RVA: 0x00014E50 File Offset: 0x00013050
		public event EventHandler<IPAddress> cbf92447b2ba6ced5726222eb6a0494f4
		{
			[CompilerGenerated]
			add
			{
				EventHandler<IPAddress> eventHandler = this.cbf92447b2ba6ced5726222eb6a0494f4;
				EventHandler<IPAddress> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<IPAddress> value2 = c54de386538266832a225034a9373a064.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<IPAddress>>(ref this.cbf92447b2ba6ced5726222eb6a0494f4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9f6bd73e0994a8a3cafc60b84130cfec.add_cbf92447b2ba6ced5726222eb6a0494f4(EventHandler<IPAddress>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<IPAddress> eventHandler = this.cbf92447b2ba6ced5726222eb6a0494f4;
				EventHandler<IPAddress> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<IPAddress> value2 = c54de386538266832a225034a9373a064.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<IPAddress>>(ref this.cbf92447b2ba6ced5726222eb6a0494f4, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9f6bd73e0994a8a3cafc60b84130cfec.remove_cbf92447b2ba6ced5726222eb6a0494f4(EventHandler<IPAddress>)).MethodHandle;
				}
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00014EA0 File Offset: 0x000130A0
		public void c95773ca90449404a230e51c912cabff1(bool ce069568f7616a35f0299e2e48a9aeb86)
		{
			c9f6bd73e0994a8a3cafc60b84130cfec.cc737912e8cd8b434e481af0dbbc354e1 cc737912e8cd8b434e481af0dbbc354e = new c9f6bd73e0994a8a3cafc60b84130cfec.cc737912e8cd8b434e481af0dbbc354e1();
			cc737912e8cd8b434e481af0dbbc354e.c4404a159870bf55bb6f111e66e59e82d = this;
			cc737912e8cd8b434e481af0dbbc354e.ce069568f7616a35f0299e2e48a9aeb86 = ce069568f7616a35f0299e2e48a9aeb86;
			new Thread(new ThreadStart(cc737912e8cd8b434e481af0dbbc354e.cc72414daedfcd01a79566f94d633ea3c))
			{
				IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4880) != 0)
			}.Start();
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00014EE8 File Offset: 0x000130E8
		public void c95155aaac6dbe5d54fdbb132d6c984dd()
		{
			this.c56e18e603ce3e5189c0438cf163721e0 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4884) != 0);
			this.c0ed1af3ccfd6bd51fcf9cc8ea7e37fc4.Close();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00014F14 File Offset: 0x00013114
		private void c72a88fa95924fc8cb30faff0d90bc97c(IPAddress cb689e652eac22c54ef570b384f0df229)
		{
			EventHandler<IPAddress> eventHandler = this.cbf92447b2ba6ced5726222eb6a0494f4;
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c9f6bd73e0994a8a3cafc60b84130cfec.c72a88fa95924fc8cb30faff0d90bc97c(IPAddress)).MethodHandle;
				}
				return;
			}
			eventHandler(this, cb689e652eac22c54ef570b384f0df229);
		}

		// Token: 0x040001DC RID: 476
		private const string c9691c2cf40c6a1814e23d6dd1208a212 = "HELLO FROM WIIU!";

		// Token: 0x040001DD RID: 477
		private volatile bool c56e18e603ce3e5189c0438cf163721e0 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4888) != 0;

		// Token: 0x040001DE RID: 478
		private readonly UdpClient c0ed1af3ccfd6bd51fcf9cc8ea7e37fc4 = new UdpClient(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4892));

		// Token: 0x02000113 RID: 275
		[CompilerGenerated]
		private sealed class cc737912e8cd8b434e481af0dbbc354e1
		{
			// Token: 0x060008B7 RID: 2231 RVA: 0x0005C994 File Offset: 0x0005AB94
			internal void cc72414daedfcd01a79566f94d633ea3c()
			{
				IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30176));
				while (this.c4404a159870bf55bb6f111e66e59e82d.c56e18e603ce3e5189c0438cf163721e0)
				{
					byte[] bytes;
					try
					{
						bytes = this.c4404a159870bf55bb6f111e66e59e82d.c0ed1af3ccfd6bd51fcf9cc8ea7e37fc4.Receive(ref ipendPoint);
					}
					catch (Exception)
					{
						return;
					}
					if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Encoding.ASCII.GetString(bytes), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98031)))
					{
						continue;
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c9f6bd73e0994a8a3cafc60b84130cfec.cc737912e8cd8b434e481af0dbbc354e1.cc72414daedfcd01a79566f94d633ea3c()).MethodHandle;
					}
					if (this.c4404a159870bf55bb6f111e66e59e82d.c56e18e603ce3e5189c0438cf163721e0)
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
						this.c4404a159870bf55bb6f111e66e59e82d.c72a88fa95924fc8cb30faff0d90bc97c(ipendPoint.Address);
					}
					if (!this.ce069568f7616a35f0299e2e48a9aeb86)
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
						this.c4404a159870bf55bb6f111e66e59e82d.c56e18e603ce3e5189c0438cf163721e0 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30180) != 0);
						continue;
					}
				}
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					return;
				}
			}

			// Token: 0x04000658 RID: 1624
			public bool ce069568f7616a35f0299e2e48a9aeb86;

			// Token: 0x04000659 RID: 1625
			public c9f6bd73e0994a8a3cafc60b84130cfec c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
