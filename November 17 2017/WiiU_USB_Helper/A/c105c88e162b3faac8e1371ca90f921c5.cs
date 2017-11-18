using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace A
{
	// Token: 0x02000080 RID: 128
	public abstract class c105c88e162b3faac8e1371ca90f921c5
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x000180FC File Offset: 0x000162FC
		public static byte[] c6b97de98e92251ea724e41d5b38c2e89(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7, TimeSpan c929df155ecd6dd74ba075703fc44dff3)
		{
			if (Uri.IsWellFormedUriString(cbc47e314a0f1d7d5f1d07b50ba2bb8c7, (UriKind)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6180)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c105c88e162b3faac8e1371ca90f921c5.c6b97de98e92251ea724e41d5b38c2e89(string, TimeSpan)).MethodHandle;
				}
				return c67726bc94fb4dd43c5c00e863a4fed19.c4c076c3a237621789378691b14b8de64(new Uri(cbc47e314a0f1d7d5f1d07b50ba2bb8c7), c929df155ecd6dd74ba075703fc44dff3);
			}
			return null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00018140 File Offset: 0x00016340
		public virtual void c142384818e91b48255429b5c59e8b8c7(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7, TimeSpan c929df155ecd6dd74ba075703fc44dff3)
		{
			if (!Uri.IsWellFormedUriString(cbc47e314a0f1d7d5f1d07b50ba2bb8c7, (UriKind)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6184)))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c105c88e162b3faac8e1371ca90f921c5.c142384818e91b48255429b5c59e8b8c7(string, TimeSpan)).MethodHandle;
				}
				return;
			}
			c67726bc94fb4dd43c5c00e863a4fed19.c38e847351547b2e0fce587bbbe528a52(new Uri(cbc47e314a0f1d7d5f1d07b50ba2bb8c7), c929df155ecd6dd74ba075703fc44dff3, new Action<ca4dbe4e221059deb4f3786c044e4860a>(this.cda5e8b16476d06ee406ff817946cee72));
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060003A4 RID: 932 RVA: 0x00018190 File Offset: 0x00016390
		// (remove) Token: 0x060003A5 RID: 933 RVA: 0x000181E0 File Offset: 0x000163E0
		protected event EventHandler<ca4dbe4e221059deb4f3786c044e4860a> cec41dce7fd7f95a99bbdd1673e6fd941
		{
			[CompilerGenerated]
			add
			{
				EventHandler<ca4dbe4e221059deb4f3786c044e4860a> eventHandler = this.cec41dce7fd7f95a99bbdd1673e6fd941;
				EventHandler<ca4dbe4e221059deb4f3786c044e4860a> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ca4dbe4e221059deb4f3786c044e4860a> value2 = c4b906a77eb43d4e563dda0eefd63f53e.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ca4dbe4e221059deb4f3786c044e4860a>>(ref this.cec41dce7fd7f95a99bbdd1673e6fd941, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c105c88e162b3faac8e1371ca90f921c5.add_cec41dce7fd7f95a99bbdd1673e6fd941(EventHandler<ca4dbe4e221059deb4f3786c044e4860a>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<ca4dbe4e221059deb4f3786c044e4860a> eventHandler = this.cec41dce7fd7f95a99bbdd1673e6fd941;
				EventHandler<ca4dbe4e221059deb4f3786c044e4860a> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ca4dbe4e221059deb4f3786c044e4860a> value2 = c4b906a77eb43d4e563dda0eefd63f53e.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<ca4dbe4e221059deb4f3786c044e4860a>>(ref this.cec41dce7fd7f95a99bbdd1673e6fd941, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c105c88e162b3faac8e1371ca90f921c5.remove_cec41dce7fd7f95a99bbdd1673e6fd941(EventHandler<ca4dbe4e221059deb4f3786c044e4860a>)).MethodHandle;
				}
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00018230 File Offset: 0x00016430
		[CompilerGenerated]
		private void cda5e8b16476d06ee406ff817946cee72(ca4dbe4e221059deb4f3786c044e4860a cdf15457ee4816989343b6e6e96dd4cfe)
		{
			EventHandler<ca4dbe4e221059deb4f3786c044e4860a> eventHandler = this.cec41dce7fd7f95a99bbdd1673e6fd941;
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c105c88e162b3faac8e1371ca90f921c5.cda5e8b16476d06ee406ff817946cee72(ca4dbe4e221059deb4f3786c044e4860a)).MethodHandle;
				}
				return;
			}
			eventHandler(this, cdf15457ee4816989343b6e6e96dd4cfe);
		}
	}
}
