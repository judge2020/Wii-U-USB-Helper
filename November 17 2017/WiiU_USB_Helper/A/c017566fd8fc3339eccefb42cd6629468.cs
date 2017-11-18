using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Alphaleonis.Win32.Filesystem;
using NusHelper;
using Telerik.WinControls;

namespace A
{
	// Token: 0x02000016 RID: 22
	internal class c017566fd8fc3339eccefb42cd6629468
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000040B4 File Offset: 0x000022B4
		public c017566fd8fc3339eccefb42cd6629468(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			if (c804bc52f7f79bffee6fd394ef382eb76.System != (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(584))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468..ctor(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1348));
			}
			this.cbd119e33552f6e7eda45b0c64e636c3a = c804bc52f7f79bffee6fd394ef382eb76;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600003D RID: 61 RVA: 0x00004140 File Offset: 0x00002340
		// (remove) Token: 0x0600003E RID: 62 RVA: 0x00004190 File Offset: 0x00002390
		public event EventHandler<bool> c18f6de0e227e0d96c5e4f9bda37723c6
		{
			[CompilerGenerated]
			add
			{
				EventHandler<bool> eventHandler = this.c18f6de0e227e0d96c5e4f9bda37723c6;
				EventHandler<bool> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<bool> value2 = c51fed6788035d97ec4961514c1d89a4e.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<bool>>(ref this.c18f6de0e227e0d96c5e4f9bda37723c6, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.add_c18f6de0e227e0d96c5e4f9bda37723c6(EventHandler<bool>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<bool> eventHandler = this.c18f6de0e227e0d96c5e4f9bda37723c6;
				EventHandler<bool> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<bool> value2 = c51fed6788035d97ec4961514c1d89a4e.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<bool>>(ref this.c18f6de0e227e0d96c5e4f9bda37723c6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.remove_c18f6de0e227e0d96c5e4f9bda37723c6(EventHandler<bool>)).MethodHandle;
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600003F RID: 63 RVA: 0x000041E0 File Offset: 0x000023E0
		// (remove) Token: 0x06000040 RID: 64 RVA: 0x00004230 File Offset: 0x00002430
		public event EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> c2484bd018cc259ebf6256e671a3c8276
		{
			[CompilerGenerated]
			add
			{
				EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
				EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> value2 = cf32eaa8aee6acfe2b63f83d3ff5e4fc7.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a>>(ref this.c2484bd018cc259ebf6256e671a3c8276, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.add_c2484bd018cc259ebf6256e671a3c8276(EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
				EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> value2 = cf32eaa8aee6acfe2b63f83d3ff5e4fc7.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a>>(ref this.c2484bd018cc259ebf6256e671a3c8276, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.remove_c2484bd018cc259ebf6256e671a3c8276(EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a>)).MethodHandle;
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004280 File Offset: 0x00002480
		public byte[] cc85b988b622afd8b85847f6752187a18(c362f27bc84ea5b6692418fbdaf79e992 ce610c706ab780feeb207292bde3e1874, ulong c950cf8c6c54af51a6f82b6c1b2494e2d = 0UL)
		{
			if (this.c885531b0499fd81a1e93bb42e1608cbe != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.cc85b988b622afd8b85847f6752187a18(c362f27bc84ea5b6692418fbdaf79e992, ulong)).MethodHandle;
				}
				if (this.c29b2fe8806f7fe8601254900aad02ffe != null)
				{
					goto IL_7E;
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
			}
			this.c885531b0499fd81a1e93bb42e1608cbe = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cbd119e33552f6e7eda45b0c64e636c3a.cf25635e89f76877f4315886ba0dfe61a, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1286))), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(356));
			this.c29b2fe8806f7fe8601254900aad02ffe = this.ccc5256014a5209af170f362a861339fd();
			IL_7E:
			if (!ce610c706ab780feeb207292bde3e1874.c9129297003e298db78ceb4ec7765d937)
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
				if (!ce610c706ab780feeb207292bde3e1874.c7b4ce553a3c25a637311d7b27df95266)
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
					MemoryStream memoryStream = new MemoryStream();
					try
					{
						this.c67b14247d4bdc14eacec0bca76efbddd(ce610c706ab780feeb207292bde3e1874, memoryStream, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(360) != 0, c950cf8c6c54af51a6f82b6c1b2494e2d);
						return memoryStream.ToArray();
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
				}
			}
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000437C File Offset: 0x0000257C
		public void cf8303f52fb0afdb6f4459d0d7676c874(string c85fa46dee7ef9473f93c9fb47da11f4d, bool c3c7497942acfe55b365013a6254dd980 = false, List<c362f27bc84ea5b6692418fbdaf79e992> c4af034c05fd55c7c0ca5b56577ddd3b0 = null, bool c5daff30a59a4f0ecddf2276180e3bbad = false)
		{
			c017566fd8fc3339eccefb42cd6629468.cba285c073acd8ef3f387911bbcba725e cba285c073acd8ef3f387911bbcba725e = new c017566fd8fc3339eccefb42cd6629468.cba285c073acd8ef3f387911bbcba725e();
			cba285c073acd8ef3f387911bbcba725e.c4404a159870bf55bb6f111e66e59e82d = this;
			cba285c073acd8ef3f387911bbcba725e.c3c7497942acfe55b365013a6254dd980 = c3c7497942acfe55b365013a6254dd980;
			cba285c073acd8ef3f387911bbcba725e.c4af034c05fd55c7c0ca5b56577ddd3b0 = c4af034c05fd55c7c0ca5b56577ddd3b0;
			cba285c073acd8ef3f387911bbcba725e.c5daff30a59a4f0ecddf2276180e3bbad = c5daff30a59a4f0ecddf2276180e3bbad;
			cba285c073acd8ef3f387911bbcba725e.c85fa46dee7ef9473f93c9fb47da11f4d = c85fa46dee7ef9473f93c9fb47da11f4d;
			Task.Run(new Action(cba285c073acd8ef3f387911bbcba725e.cdc0bfd186689bdc55d5e12c87303dc9a));
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000043 RID: 67 RVA: 0x000043C8 File Offset: 0x000025C8
		// (remove) Token: 0x06000044 RID: 68 RVA: 0x00004418 File Offset: 0x00002618
		public event EventHandler<Exception> c1f84333d7942c2315ee42eb2b5f59625
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Exception> eventHandler = this.c1f84333d7942c2315ee42eb2b5f59625;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = c4752e9f82839b466091b53b1b27929cc.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.c1f84333d7942c2315ee42eb2b5f59625, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.add_c1f84333d7942c2315ee42eb2b5f59625(EventHandler<Exception>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Exception> eventHandler = this.c1f84333d7942c2315ee42eb2b5f59625;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = c4752e9f82839b466091b53b1b27929cc.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.c1f84333d7942c2315ee42eb2b5f59625, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.remove_c1f84333d7942c2315ee42eb2b5f59625(EventHandler<Exception>)).MethodHandle;
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004468 File Offset: 0x00002668
		private void c67b14247d4bdc14eacec0bca76efbddd(c362f27bc84ea5b6692418fbdaf79e992 c32053d44c8d1dcaa73f780b2a239314c, Stream c5299246c0d6ad37a1d897529d28013a8, bool c3c7497942acfe55b365013a6254dd980, ulong c950cf8c6c54af51a6f82b6c1b2494e2d = 0UL)
		{
			if (this.c885531b0499fd81a1e93bb42e1608cbe.ca41cd3b028585a369298639868832973[(int)c32053d44c8d1dcaa73f780b2a239314c.c8cd86a941e9dcf502ef598e3fac37842].c5a0797ee67f90b4af0433c5d7ee00865)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.c67b14247d4bdc14eacec0bca76efbddd(c362f27bc84ea5b6692418fbdaf79e992, Stream, bool, ulong)).MethodHandle;
				}
				this.cba28b6499f4b812f0db5e165a775346b(c32053d44c8d1dcaa73f780b2a239314c, c5299246c0d6ad37a1d897529d28013a8, c3c7497942acfe55b365013a6254dd980, c950cf8c6c54af51a6f82b6c1b2494e2d);
				return;
			}
			this.c109b5359d0aaf103dd2c1b1f34ac3e5f(c32053d44c8d1dcaa73f780b2a239314c, c5299246c0d6ad37a1d897529d28013a8, c3c7497942acfe55b365013a6254dd980, c950cf8c6c54af51a6f82b6c1b2494e2d);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000044BC File Offset: 0x000026BC
		private void cba28b6499f4b812f0db5e165a775346b(c362f27bc84ea5b6692418fbdaf79e992 c32053d44c8d1dcaa73f780b2a239314c, Stream cd71e80179d90ddfa912f9073fd73503f, bool c3c7497942acfe55b365013a6254dd980, ulong c950cf8c6c54af51a6f82b6c1b2494e2d = 0UL)
		{
			uint contentId = this.c885531b0499fd81a1e93bb42e1608cbe.ca41cd3b028585a369298639868832973[(int)c32053d44c8d1dcaa73f780b2a239314c.c8cd86a941e9dcf502ef598e3fac37842].ContentId;
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(364));
			ulong num = (ulong)c32053d44c8d1dcaa73f780b2a239314c.c6d90c75477d966c1350c18dcdfa11588;
			ulong num2 = (ulong)c32053d44c8d1dcaa73f780b2a239314c.c5db06f710879d10bd98fa2c1adf0deb8;
			ulong num3 = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(368));
			ulong num4 = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(372));
			ulong num5 = num / (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(376)) * (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(380));
			int num6 = (int)(num5 / (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(384)));
			ulong num7 = num - num / (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(388)) * (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(392));
			if (num7 + num2 > num4)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.cba28b6499f4b812f0db5e165a775346b(c362f27bc84ea5b6692418fbdaf79e992, Stream, bool, ulong)).MethodHandle;
				}
				num4 -= num7;
			}
			Stream stream = c5db4cd6c2448810607b45eaf35a53573.cab55a050df275722227783d6686266c9;
			if (c3c7497942acfe55b365013a6254dd980)
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
				HttpWebRequest httpWebRequest = c306d0f4edb8d9dba0e2099a0ed0662c3.cd24593c859565ebb8c9faabbc5c75bef(WebRequest.Create(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cbd119e33552f6e7eda45b0c64e636c3a.cf25635e89f76877f4315886ba0dfe61a, contentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)))));
				httpWebRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1298);
				httpWebRequest.AddRange((long)num5);
				stream = httpWebRequest.GetResponse().GetResponseStream();
			}
			else
			{
				stream = this.cddbff8ae6a8f01e9f12ad1cd97ba12a6[contentId];
			}
			byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(396));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(400)] = (byte)c32053d44c8d1dcaa73f780b2a239314c.c8cd86a941e9dcf502ef598e3fac37842;
			byte[] array3 = array2;
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				aesCryptoServiceProvider.Key = this.c29b2fe8806f7fe8601254900aad02ffe.cc0eab3c8af7b4aa29c084139a1df3c14;
				aesCryptoServiceProvider.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(404);
				aesCryptoServiceProvider.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(408);
				aesCryptoServiceProvider.IV = array3;
				if (!c3c7497942acfe55b365013a6254dd980)
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
					stream.Seek((long)num5, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(412));
				}
				while (num2 > (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(488)))
				{
					if (num4 > num2)
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
						num4 = num2;
					}
					stream.ca580c34a1cbbccc3f8ca98b598c4a2a4(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(416));
					byte[] array4 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(420));
					array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(424)] = (byte)c32053d44c8d1dcaa73f780b2a239314c.c8cd86a941e9dcf502ef598e3fac37842;
					array3 = array4;
					c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(428));
					ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor(this.c29b2fe8806f7fe8601254900aad02ffe.cc0eab3c8af7b4aa29c084139a1df3c14, array3);
					byte[] array5;
					try
					{
						array5 = cryptoTransform.TransformFinalBlock(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(432), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(436));
					}
					finally
					{
						if (cryptoTransform != null)
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
							cryptoTransform.Dispose();
						}
					}
					byte[] array6 = array5;
					int num8 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(440);
					array6[num8] ^= (byte)c32053d44c8d1dcaa73f780b2a239314c.c8cd86a941e9dcf502ef598e3fac37842;
					Buffer.BlockCopy(array5, num6 % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(444) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(448), array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(452), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(456));
					ICryptoTransform cryptoTransform2 = aesCryptoServiceProvider.CreateDecryptor(this.c29b2fe8806f7fe8601254900aad02ffe.cc0eab3c8af7b4aa29c084139a1df3c14, array3);
					try
					{
						cryptoTransform2.TransformBlock(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(460), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(464), this.c9dc643fe48e4ad36d3eb030770446bd3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(468));
					}
					finally
					{
						if (cryptoTransform2 != null)
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
							cryptoTransform2.Dispose();
						}
					}
					num2 -= num4;
					cd71e80179d90ddfa912f9073fd73503f.Write(this.c9dc643fe48e4ad36d3eb030770446bd3, (int)num7, (int)num4);
					this.c0b08fabe91f511cc1f60265a864b1a27 += num4;
					if (c950cf8c6c54af51a6f82b6c1b2494e2d > (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(472)))
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
						if (this.c0b08fabe91f511cc1f60265a864b1a27 >= c950cf8c6c54af51a6f82b6c1b2494e2d)
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
							goto IL_409;
						}
					}
					this.c784dd754090c060929375583252746af();
					num3 += num4;
					num6 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(476);
					if (num7 != 0UL)
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
						num4 = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(480));
						num7 = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(484));
					}
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
			finally
			{
				if (aesCryptoServiceProvider != null)
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
					((IDisposable)aesCryptoServiceProvider).Dispose();
				}
			}
			IL_409:
			if (c3c7497942acfe55b365013a6254dd980)
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
				stream.Close();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004934 File Offset: 0x00002B34
		private void c109b5359d0aaf103dd2c1b1f34ac3e5f(c362f27bc84ea5b6692418fbdaf79e992 c32053d44c8d1dcaa73f780b2a239314c, Stream cd71e80179d90ddfa912f9073fd73503f, bool c3c7497942acfe55b365013a6254dd980, ulong c950cf8c6c54af51a6f82b6c1b2494e2d = 0UL)
		{
			uint contentId = this.c885531b0499fd81a1e93bb42e1608cbe.ca41cd3b028585a369298639868832973[(int)c32053d44c8d1dcaa73f780b2a239314c.c8cd86a941e9dcf502ef598e3fac37842].ContentId;
			ulong num = (ulong)c32053d44c8d1dcaa73f780b2a239314c.c6d90c75477d966c1350c18dcdfa11588;
			ulong num2 = (ulong)c32053d44c8d1dcaa73f780b2a239314c.c5db06f710879d10bd98fa2c1adf0deb8;
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(492));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(496)] = (byte)c32053d44c8d1dcaa73f780b2a239314c.c8cd86a941e9dcf502ef598e3fac37842;
			byte[] rgbIV = array;
			Stream stream = c5db4cd6c2448810607b45eaf35a53573.cab55a050df275722227783d6686266c9;
			if (c3c7497942acfe55b365013a6254dd980)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.c109b5359d0aaf103dd2c1b1f34ac3e5f(c362f27bc84ea5b6692418fbdaf79e992, Stream, bool, ulong)).MethodHandle;
				}
				HttpWebRequest httpWebRequest = c306d0f4edb8d9dba0e2099a0ed0662c3.cd24593c859565ebb8c9faabbc5c75bef(WebRequest.Create(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cbd119e33552f6e7eda45b0c64e636c3a.cf25635e89f76877f4315886ba0dfe61a, contentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)))));
				httpWebRequest.AddRange((long)num);
				stream = httpWebRequest.GetResponse().GetResponseStream();
			}
			else
			{
				stream = this.cddbff8ae6a8f01e9f12ad1cd97ba12a6[contentId];
			}
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				aesCryptoServiceProvider.Key = this.c29b2fe8806f7fe8601254900aad02ffe.cc0eab3c8af7b4aa29c084139a1df3c14;
				aesCryptoServiceProvider.Mode = (CipherMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(500);
				aesCryptoServiceProvider.Padding = (PaddingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(504);
				if (!c3c7497942acfe55b365013a6254dd980)
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
					stream.Seek((long)num, (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(508));
				}
				int num3 = (int)this.c027248ef084ab6bee69bfd6135656b14((long)num2, (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(512));
				if (c950cf8c6c54af51a6f82b6c1b2494e2d > (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(516)))
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
					long num4 = this.c027248ef084ab6bee69bfd6135656b14((long)c950cf8c6c54af51a6f82b6c1b2494e2d, (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(520));
					if (num4 < (long)num3)
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
						num3 = (int)num4;
					}
				}
				byte[] inputBuffer = stream.ca580c34a1cbbccc3f8ca98b598c4a2a4(num3, new Action<int>(this.c40af70d4ed6f373906ec64ac0f7aebd4));
				ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor(this.c29b2fe8806f7fe8601254900aad02ffe.cc0eab3c8af7b4aa29c084139a1df3c14, rgbIV);
				byte[] buffer;
				try
				{
					buffer = cryptoTransform.TransformFinalBlock(inputBuffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(524), num3);
				}
				finally
				{
					if (cryptoTransform != null)
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
						cryptoTransform.Dispose();
					}
				}
				if (c950cf8c6c54af51a6f82b6c1b2494e2d > (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(528)))
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
					cd71e80179d90ddfa912f9073fd73503f.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(532), num3);
				}
				else
				{
					cd71e80179d90ddfa912f9073fd73503f.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(536), (int)num2);
				}
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
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
					((IDisposable)aesCryptoServiceProvider).Dispose();
				}
			}
			if (c3c7497942acfe55b365013a6254dd980)
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
				stream.Close();
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004BD4 File Offset: 0x00002DD4
		private c9538952b0224ea717b33e0e4e7ae98c5 ccc5256014a5209af170f362a861339fd()
		{
			if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(this.cbd119e33552f6e7eda45b0c64e636c3a) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.ccc5256014a5209af170f362a861339fd()).MethodHandle;
				}
				if (this.cbd119e33552f6e7eda45b0c64e636c3a.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(540))
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
				}
				else
				{
					if (this.cbd119e33552f6e7eda45b0c64e636c3a.cf7f2b1967398c4cc0c607544f80499bc)
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
						return c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(this.cbd119e33552f6e7eda45b0c64e636c3a.cad1dd58d3844f8fa6ceed9a0fcd16398), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(548));
					}
					return c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(this.cbd119e33552f6e7eda45b0c64e636c3a.TicketArray, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(552));
				}
			}
			return c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cbd119e33552f6e7eda45b0c64e636c3a.cf25635e89f76877f4315886ba0dfe61a, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1305))), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(544));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004CC4 File Offset: 0x00002EC4
		private cbcbdbfc95367bfec4c11b371d883aa2d c08a93a874cdae61541a8cd5f748c4739()
		{
			if (c106502e6ccd440ff8b0d7b5b50a2000f.c0b398ab350e72b0d64d512bae8520b85(this.cbd119e33552f6e7eda45b0c64e636c3a) != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.c08a93a874cdae61541a8cd5f748c4739()).MethodHandle;
				}
				return cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1314), this.cbd119e33552f6e7eda45b0c64e636c3a.cf25635e89f76877f4315886ba0dfe61a, this.cbd119e33552f6e7eda45b0c64e636c3a.Version)), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(556));
			}
			return cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1335), this.cbd119e33552f6e7eda45b0c64e636c3a.cf25635e89f76877f4315886ba0dfe61a)), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(560));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004D7C File Offset: 0x00002F7C
		private long c027248ef084ab6bee69bfd6135656b14(long c70fc31445695e2a675e44e4f11ea7103, long cef95478f9e4fb75b05a42d51ed169f61)
		{
			if (c70fc31445695e2a675e44e4f11ea7103 % cef95478f9e4fb75b05a42d51ed169f61 == 0L)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.c027248ef084ab6bee69bfd6135656b14(long, long)).MethodHandle;
				}
				return c70fc31445695e2a675e44e4f11ea7103;
			}
			return (c70fc31445695e2a675e44e4f11ea7103 / cef95478f9e4fb75b05a42d51ed169f61 + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(564)) * cef95478f9e4fb75b05a42d51ed169f61;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004DB4 File Offset: 0x00002FB4
		private string cd9433df3ca5e6c0a9a165c7f6ad984fb(string c32053d44c8d1dcaa73f780b2a239314c)
		{
			return Path.Combine(this.cbd119e33552f6e7eda45b0c64e636c3a.OutputPath, c32053d44c8d1dcaa73f780b2a239314c);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004DD8 File Offset: 0x00002FD8
		private void c784dd754090c060929375583252746af()
		{
			EventHandler<cb776ccbd2397a5ddcfe3bb11c2bfd36a> eventHandler = this.c2484bd018cc259ebf6256e671a3c8276;
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.c784dd754090c060929375583252746af()).MethodHandle;
				}
				return;
			}
			cb776ccbd2397a5ddcfe3bb11c2bfd36a e;
			ca586c9ed3aaf55eb207e6b8467a2df58.c6333b8d01cc2ac0ec4fe13624a14dfc7(ref e);
			e.cc75ff7623fa1e4172cff7feeaceb8ac3 = (int)(this.c0b08fabe91f511cc1f60265a864b1a27 / this.c174f534fb48141ad1c4f21fcf4e1b7b8 * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(568));
			e.ca424de47305c1cb0470d71886e5608b7 = this.ccf044cc4b61e7a0bc7fed3a666ebfefb;
			e.c82f9321951ff1698040cad92b2bbe3d4 = this.c05e3ab8a89c88b4de1ea3d9d43343763;
			eventHandler(this, e);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004E54 File Offset: 0x00003054
		private void c8454895e0f062fb9fcaccea2b5ca2048()
		{
			using (Dictionary<uint, Stream>.ValueCollection.Enumerator enumerator = this.cddbff8ae6a8f01e9f12ad1cd97ba12a6.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Stream stream = enumerator.Current;
					try
					{
						stream.Close();
					}
					catch
					{
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.c8454895e0f062fb9fcaccea2b5ca2048()).MethodHandle;
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004ED8 File Offset: 0x000030D8
		[CompilerGenerated]
		private void c40af70d4ed6f373906ec64ac0f7aebd4(int cb33f553f7c7f34a5756caf2131d668f5)
		{
			this.c0b08fabe91f511cc1f60265a864b1a27 += (ulong)((long)cb33f553f7c7f34a5756caf2131d668f5);
			this.c784dd754090c060929375583252746af();
		}

		// Token: 0x0400002F RID: 47
		private readonly c6114b34ba4893a53ebb4b599e0e2e3fc cbd119e33552f6e7eda45b0c64e636c3a;

		// Token: 0x04000030 RID: 48
		private readonly byte[] c9dc643fe48e4ad36d3eb030770446bd3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(576));

		// Token: 0x04000031 RID: 49
		private readonly Dictionary<uint, Stream> cddbff8ae6a8f01e9f12ad1cd97ba12a6 = new Dictionary<uint, Stream>();

		// Token: 0x04000032 RID: 50
		private int ccf044cc4b61e7a0bc7fed3a666ebfefb;

		// Token: 0x04000033 RID: 51
		private ce462f8df7ccb876a2d3bd500ac1c174f c368e6359da2107905f36cac53ec5e1f7;

		// Token: 0x04000034 RID: 52
		private c9538952b0224ea717b33e0e4e7ae98c5 c29b2fe8806f7fe8601254900aad02ffe;

		// Token: 0x04000035 RID: 53
		private cbcbdbfc95367bfec4c11b371d883aa2d c885531b0499fd81a1e93bb42e1608cbe;

		// Token: 0x04000036 RID: 54
		private int c05e3ab8a89c88b4de1ea3d9d43343763;

		// Token: 0x04000037 RID: 55
		private ulong c174f534fb48141ad1c4f21fcf4e1b7b8;

		// Token: 0x04000038 RID: 56
		private ulong c0b08fabe91f511cc1f60265a864b1a27;

		// Token: 0x04000039 RID: 57
		private byte[] c86dfb2286ae5def51371c4c9652de376 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(580));

		// Token: 0x020000ED RID: 237
		[CompilerGenerated]
		private sealed class cba285c073acd8ef3f387911bbcba725e
		{
			// Token: 0x06000858 RID: 2136 RVA: 0x0005A264 File Offset: 0x00058464
			internal void cdc0bfd186689bdc55d5e12c87303dc9a()
			{
				if (this.c4404a159870bf55bb6f111e66e59e82d.c885531b0499fd81a1e93bb42e1608cbe != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c017566fd8fc3339eccefb42cd6629468.cba285c073acd8ef3f387911bbcba725e.cdc0bfd186689bdc55d5e12c87303dc9a()).MethodHandle;
					}
					if (this.c4404a159870bf55bb6f111e66e59e82d.c29b2fe8806f7fe8601254900aad02ffe != null)
					{
						goto IL_E8;
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
				}
				if (this.c3c7497942acfe55b365013a6254dd980)
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
					this.c4404a159870bf55bb6f111e66e59e82d.c885531b0499fd81a1e93bb42e1608cbe = this.c4404a159870bf55bb6f111e66e59e82d.c08a93a874cdae61541a8cd5f748c4739();
					this.c4404a159870bf55bb6f111e66e59e82d.c29b2fe8806f7fe8601254900aad02ffe = this.c4404a159870bf55bb6f111e66e59e82d.ccc5256014a5209af170f362a861339fd();
				}
				else
				{
					this.c4404a159870bf55bb6f111e66e59e82d.c29b2fe8806f7fe8601254900aad02ffe = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(this.c4404a159870bf55bb6f111e66e59e82d.cd9433df3ca5e6c0a9a165c7f6ad984fb(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6259)), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29792));
					this.c4404a159870bf55bb6f111e66e59e82d.c885531b0499fd81a1e93bb42e1608cbe = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(this.c4404a159870bf55bb6f111e66e59e82d.cd9433df3ca5e6c0a9a165c7f6ad984fb(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767)), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29796));
				}
				IL_E8:
				try
				{
					if (this.c4404a159870bf55bb6f111e66e59e82d.c368e6359da2107905f36cac53ec5e1f7 == null)
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
						this.c4404a159870bf55bb6f111e66e59e82d.c368e6359da2107905f36cac53ec5e1f7 = this.c4404a159870bf55bb6f111e66e59e82d.cbd119e33552f6e7eda45b0c64e636c3a.c88e4a51a8d0b3e7d29a28576dde32c38();
					}
					IEnumerator<c362f27bc84ea5b6692418fbdaf79e992> enumerator;
					if (this.c4af034c05fd55c7c0ca5b56577ddd3b0 != c9277957ec33e30c99670585a602bf767.cab55a050df275722227783d6686266c9 & this.c5daff30a59a4f0ecddf2276180e3bbad)
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
						IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> files = this.c4404a159870bf55bb6f111e66e59e82d.c368e6359da2107905f36cac53ec5e1f7.Files;
						Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate;
						if ((predicate = c017566fd8fc3339eccefb42cd6629468.<>c.cf5a0480636f167cfae17d2df284f064b) == null)
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
							predicate = (c017566fd8fc3339eccefb42cd6629468.<>c.cf5a0480636f167cfae17d2df284f064b = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(c017566fd8fc3339eccefb42cd6629468.<>c.cdfab1996eb8651828de2a4469aa3481e.c5cd64ca9882fde0a8e2b92c759104044));
						}
						enumerator = files.Where(predicate).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								c362f27bc84ea5b6692418fbdaf79e992 item = enumerator.Current;
								if (!this.c4af034c05fd55c7c0ca5b56577ddd3b0.Contains(item))
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
									this.c4af034c05fd55c7c0ca5b56577ddd3b0.Add(item);
								}
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
						}
						finally
						{
							if (enumerator != null)
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
								enumerator.Dispose();
							}
						}
					}
					List<c362f27bc84ea5b6692418fbdaf79e992> files2;
					if ((files2 = this.c4af034c05fd55c7c0ca5b56577ddd3b0) == null)
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
						files2 = this.c4404a159870bf55bb6f111e66e59e82d.c368e6359da2107905f36cac53ec5e1f7.Files;
					}
					List<c362f27bc84ea5b6692418fbdaf79e992> list = files2;
					IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> source = list;
					Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate2;
					if ((predicate2 = c017566fd8fc3339eccefb42cd6629468.<>c.cbf8962d6e1e941f75a2e60a10c7a979a) == null)
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
						predicate2 = (c017566fd8fc3339eccefb42cd6629468.<>c.cbf8962d6e1e941f75a2e60a10c7a979a = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(c017566fd8fc3339eccefb42cd6629468.<>c.cdfab1996eb8651828de2a4469aa3481e.ccb15708df931bd70f686ba69f31b1d1a));
					}
					enumerator = source.Where(predicate2).GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							c362f27bc84ea5b6692418fbdaf79e992 c362f27bc84ea5b6692418fbdaf79e = enumerator.Current;
							Directory.CreateDirectory(Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, c362f27bc84ea5b6692418fbdaf79e.c347713f85ec9fc7a92bc7ca07b2612a0));
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
					}
					finally
					{
						if (enumerator != null)
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
							enumerator.Dispose();
						}
					}
					IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> source2 = list;
					Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate3;
					if ((predicate3 = c017566fd8fc3339eccefb42cd6629468.<>c.c2798cb63f5b7b5878224be3ad411633e) == null)
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
						predicate3 = (c017566fd8fc3339eccefb42cd6629468.<>c.c2798cb63f5b7b5878224be3ad411633e = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(c017566fd8fc3339eccefb42cd6629468.<>c.cdfab1996eb8651828de2a4469aa3481e.c3e7dfb55984acbc0b3fdaf4df007688a));
					}
					enumerator = source2.Where(predicate3).GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							c362f27bc84ea5b6692418fbdaf79e992 c362f27bc84ea5b6692418fbdaf79e2 = enumerator.Current;
							this.c4404a159870bf55bb6f111e66e59e82d.c174f534fb48141ad1c4f21fcf4e1b7b8 = this.c4404a159870bf55bb6f111e66e59e82d.c174f534fb48141ad1c4f21fcf4e1b7b8 + (ulong)c362f27bc84ea5b6692418fbdaf79e2.c5db06f710879d10bd98fa2c1adf0deb8;
							this.c4404a159870bf55bb6f111e66e59e82d.c05e3ab8a89c88b4de1ea3d9d43343763 = this.c4404a159870bf55bb6f111e66e59e82d.c05e3ab8a89c88b4de1ea3d9d43343763 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29800);
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
					finally
					{
						if (enumerator != null)
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
							enumerator.Dispose();
						}
					}
					try
					{
						if (!this.c3c7497942acfe55b365013a6254dd980)
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
							cd161c587b229cb9747bf073c6e98b0b9[] ca41cd3b028585a369298639868832973 = this.c4404a159870bf55bb6f111e66e59e82d.c885531b0499fd81a1e93bb42e1608cbe.ca41cd3b028585a369298639868832973;
							for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29804); i < (int)c6039f0790413b5e04707059b16777215.cfeb04651f165d0166e7c10ab1acf8b28(ca41cd3b028585a369298639868832973); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29812))
							{
								cd161c587b229cb9747bf073c6e98b0b9 cd161c587b229cb9747bf073c6e98b0b = ca41cd3b028585a369298639868832973[i];
								this.c4404a159870bf55bb6f111e66e59e82d.cddbff8ae6a8f01e9f12ad1cd97ba12a6.Add(cd161c587b229cb9747bf073c6e98b0b.ContentId, File.Open(this.c4404a159870bf55bb6f111e66e59e82d.cd9433df3ca5e6c0a9a165c7f6ad984fb(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cd161c587b229cb9747bf073c6e98b0b.ContentId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1293)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299))), (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29808)));
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
					}
					catch
					{
						RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(96656));
						this.c4404a159870bf55bb6f111e66e59e82d.c8454895e0f062fb9fcaccea2b5ca2048();
						EventHandler<bool> c18f6de0e227e0d96c5e4f9bda37723c = this.c4404a159870bf55bb6f111e66e59e82d.c18f6de0e227e0d96c5e4f9bda37723c6;
						if (c18f6de0e227e0d96c5e4f9bda37723c == null)
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
						}
						else
						{
							c18f6de0e227e0d96c5e4f9bda37723c(this.c4404a159870bf55bb6f111e66e59e82d, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29816) != 0);
						}
						return;
					}
					IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> source3 = list;
					Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate4;
					if ((predicate4 = c017566fd8fc3339eccefb42cd6629468.<>c.c7cf4f8f62b37d451a0692dcf02c60fed) == null)
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
						predicate4 = (c017566fd8fc3339eccefb42cd6629468.<>c.c7cf4f8f62b37d451a0692dcf02c60fed = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(c017566fd8fc3339eccefb42cd6629468.<>c.cdfab1996eb8651828de2a4469aa3481e.cf137ba8b3957ae3d9ea05c190ca6cb2a));
					}
					enumerator = source3.Where(predicate4).GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							c362f27bc84ea5b6692418fbdaf79e992 c362f27bc84ea5b6692418fbdaf79e3 = enumerator.Current;
							if (((int)c362f27bc84ea5b6692418fbdaf79e3.cfe230e1aa93fc352e9311fa549f61ffb & cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29820)) == 0)
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
								c362f27bc84ea5b6692418fbdaf79e3.c6d90c75477d966c1350c18dcdfa11588 *= (uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29824);
							}
							try
							{
								Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, c362f27bc84ea5b6692418fbdaf79e3.c347713f85ec9fc7a92bc7ca07b2612a0)));
							}
							catch
							{
							}
							FileStream fileStream = File.Create(Path.Combine(this.c85fa46dee7ef9473f93c9fb47da11f4d, c362f27bc84ea5b6692418fbdaf79e3.c347713f85ec9fc7a92bc7ca07b2612a0));
							try
							{
								this.c4404a159870bf55bb6f111e66e59e82d.c67b14247d4bdc14eacec0bca76efbddd(c362f27bc84ea5b6692418fbdaf79e3, fileStream, this.c3c7497942acfe55b365013a6254dd980, (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29828)));
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
							this.c4404a159870bf55bb6f111e66e59e82d.ccf044cc4b61e7a0bc7fed3a666ebfefb = this.c4404a159870bf55bb6f111e66e59e82d.ccf044cc4b61e7a0bc7fed3a666ebfefb + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29832);
							this.c4404a159870bf55bb6f111e66e59e82d.c784dd754090c060929375583252746af();
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
					}
					finally
					{
						if (enumerator != null)
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
							enumerator.Dispose();
						}
					}
					this.c4404a159870bf55bb6f111e66e59e82d.c8454895e0f062fb9fcaccea2b5ca2048();
					EventHandler<bool> c18f6de0e227e0d96c5e4f9bda37723c2 = this.c4404a159870bf55bb6f111e66e59e82d.c18f6de0e227e0d96c5e4f9bda37723c6;
					if (c18f6de0e227e0d96c5e4f9bda37723c2 == null)
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
					}
					else
					{
						c18f6de0e227e0d96c5e4f9bda37723c2(this.c4404a159870bf55bb6f111e66e59e82d, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29836) != 0);
					}
				}
				catch (Exception e)
				{
					this.c4404a159870bf55bb6f111e66e59e82d.c8454895e0f062fb9fcaccea2b5ca2048();
					EventHandler<Exception> c1f84333d7942c2315ee42eb2b5f = this.c4404a159870bf55bb6f111e66e59e82d.c1f84333d7942c2315ee42eb2b5f59625;
					if (c1f84333d7942c2315ee42eb2b5f == null)
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
					}
					else
					{
						c1f84333d7942c2315ee42eb2b5f(this.c4404a159870bf55bb6f111e66e59e82d, e);
					}
				}
			}

			// Token: 0x040005DD RID: 1501
			public bool c3c7497942acfe55b365013a6254dd980;

			// Token: 0x040005DE RID: 1502
			public List<c362f27bc84ea5b6692418fbdaf79e992> c4af034c05fd55c7c0ca5b56577ddd3b0;

			// Token: 0x040005DF RID: 1503
			public bool c5daff30a59a4f0ecddf2276180e3bbad;

			// Token: 0x040005E0 RID: 1504
			public string c85fa46dee7ef9473f93c9fb47da11f4d;

			// Token: 0x040005E1 RID: 1505
			public c017566fd8fc3339eccefb42cd6629468 c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
