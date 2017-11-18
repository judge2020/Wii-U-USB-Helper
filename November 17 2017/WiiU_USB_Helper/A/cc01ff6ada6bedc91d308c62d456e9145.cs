using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Threading;

namespace A
{
	// Token: 0x020000AF RID: 175
	public static class cc01ff6ada6bedc91d308c62d456e9145
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060005D7 RID: 1495 RVA: 0x000287A4 File Offset: 0x000269A4
		// (remove) Token: 0x060005D8 RID: 1496 RVA: 0x000287F0 File Offset: 0x000269F0
		public static event EventHandler c08129d1d925ceeb2c940e56d105daf73
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = cc01ff6ada6bedc91d308c62d456e9145.c08129d1d925ceeb2c940e56d105daf73;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref cc01ff6ada6bedc91d308c62d456e9145.c08129d1d925ceeb2c940e56d105daf73, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc01ff6ada6bedc91d308c62d456e9145.add_c08129d1d925ceeb2c940e56d105daf73(EventHandler)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = cc01ff6ada6bedc91d308c62d456e9145.c08129d1d925ceeb2c940e56d105daf73;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref cc01ff6ada6bedc91d308c62d456e9145.c08129d1d925ceeb2c940e56d105daf73, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc01ff6ada6bedc91d308c62d456e9145.remove_c08129d1d925ceeb2c940e56d105daf73(EventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0002883C File Offset: 0x00026A3C
		public static void c8fb9472a0ed26842fb80c89d8f70efd8(Action<c58b5beca5c1ecb9bea001c3625c4c2bd> c39e0b353d083e53eaa317dd874c3f788)
		{
			cc01ff6ada6bedc91d308c62d456e9145.c3f9f6ffc2254f1d7fb5fb920c716e9c7 c3f9f6ffc2254f1d7fb5fb920c716e9c = new cc01ff6ada6bedc91d308c62d456e9145.c3f9f6ffc2254f1d7fb5fb920c716e9c7();
			c3f9f6ffc2254f1d7fb5fb920c716e9c.c39e0b353d083e53eaa317dd874c3f788 = c39e0b353d083e53eaa317dd874c3f788;
			c3f9f6ffc2254f1d7fb5fb920c716e9c.c97f3244b031cd38c5a51b327fc40ce7c = c9f84a2d5c3aeb9ad49e9f0dd5c2a4c14.cab55a050df275722227783d6686266c9;
			c3f9f6ffc2254f1d7fb5fb920c716e9c.c97f3244b031cd38c5a51b327fc40ce7c = new EventHandler(c3f9f6ffc2254f1d7fb5fb920c716e9c.c70df49d088e72dc088d80230f15ec421);
			cc01ff6ada6bedc91d308c62d456e9145.c08129d1d925ceeb2c940e56d105daf73 += c3f9f6ffc2254f1d7fb5fb920c716e9c.c97f3244b031cd38c5a51b327fc40ce7c;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0002887C File Offset: 0x00026A7C
		public static List<c58b5beca5c1ecb9bea001c3625c4c2bd> c3af868858cbc76d482da65738fb27150()
		{
			List<c58b5beca5c1ecb9bea001c3625c4c2bd> result = new List<c58b5beca5c1ecb9bea001c3625c4c2bd>();
			try
			{
				ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher(new WqlObjectQuery(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45236))).Get();
				return result;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000288C8 File Offset: 0x00026AC8
		public static void c989c20ef726e1d32fea3d9e52aa0d23c()
		{
			try
			{
				if (cc01ff6ada6bedc91d308c62d456e9145.cbafb8a87d51a69f9a2eb39de10347d0f)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cc01ff6ada6bedc91d308c62d456e9145.c989c20ef726e1d32fea3d9e52aa0d23c()).MethodHandle;
					}
				}
				else
				{
					cc01ff6ada6bedc91d308c62d456e9145.cbafb8a87d51a69f9a2eb39de10347d0f = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11348) != 0);
					ManagementEventWatcher managementEventWatcher = new ManagementEventWatcher(new WqlEventQuery(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45295)));
					EventArrivedEventHandler value;
					if ((value = cc01ff6ada6bedc91d308c62d456e9145.<>c.c5e57be654d50df4c034b8f0b917ceb75) == null)
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
						value = (cc01ff6ada6bedc91d308c62d456e9145.<>c.c5e57be654d50df4c034b8f0b917ceb75 = new EventArrivedEventHandler(cc01ff6ada6bedc91d308c62d456e9145.<>c.cdfab1996eb8651828de2a4469aa3481e.c10971d8fd38153863d6646b8600d3b5c));
					}
					managementEventWatcher.EventArrived += value;
					managementEventWatcher.Start();
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000326 RID: 806
		private static int c10664e498a85185393410c03ddb02138;

		// Token: 0x04000327 RID: 807
		private static bool cbafb8a87d51a69f9a2eb39de10347d0f;

		// Token: 0x02000146 RID: 326
		[CompilerGenerated]
		private sealed class c3f9f6ffc2254f1d7fb5fb920c716e9c7
		{
			// Token: 0x0600095D RID: 2397 RVA: 0x0005F7DC File Offset: 0x0005D9DC
			internal void c70df49d088e72dc088d80230f15ec421(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
			{
				if (cc01ff6ada6bedc91d308c62d456e9145.c3af868858cbc76d482da65738fb27150().Count > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30608))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cc01ff6ada6bedc91d308c62d456e9145.c3f9f6ffc2254f1d7fb5fb920c716e9c7.c70df49d088e72dc088d80230f15ec421(object, EventArgs)).MethodHandle;
					}
					cc01ff6ada6bedc91d308c62d456e9145.c08129d1d925ceeb2c940e56d105daf73 -= this.c97f3244b031cd38c5a51b327fc40ce7c;
					Action<c58b5beca5c1ecb9bea001c3625c4c2bd> action = this.c39e0b353d083e53eaa317dd874c3f788;
					if (action == null)
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
						return;
					}
					action(cc01ff6ada6bedc91d308c62d456e9145.c3af868858cbc76d482da65738fb27150().Last<c58b5beca5c1ecb9bea001c3625c4c2bd>());
				}
			}

			// Token: 0x040006EE RID: 1774
			public EventHandler c97f3244b031cd38c5a51b327fc40ce7c;

			// Token: 0x040006EF RID: 1775
			public Action<c58b5beca5c1ecb9bea001c3625c4c2bd> c39e0b353d083e53eaa317dd874c3f788;
		}
	}
}
