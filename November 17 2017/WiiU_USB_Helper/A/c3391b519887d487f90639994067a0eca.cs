using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace A
{
	// Token: 0x020000A4 RID: 164
	internal class c3391b519887d487f90639994067a0eca : Stream
	{
		// Token: 0x06000561 RID: 1377 RVA: 0x00022FA4 File Offset: 0x000211A4
		public c3391b519887d487f90639994067a0eca(IList<Stream> c5cef8bb9c8c07a0e724607c3e72ca5ad) : this(c5cef8bb9c8c07a0e724607c3e72ca5ad, c4493e89f07af29c0ae1a8002cf7b7233.cab55a050df275722227783d6686266c9)
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00022FC0 File Offset: 0x000211C0
		public c3391b519887d487f90639994067a0eca(IList<Stream> c5cef8bb9c8c07a0e724607c3e72ca5ad, IList<int> c2640f8ea4c8f9515edabfc74f55658b5)
		{
			if (c5cef8bb9c8c07a0e724607c3e72ca5ad == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca..ctor(IList<Stream>, IList<int>)).MethodHandle;
				}
				throw new ArgumentNullException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41856));
			}
			this.c74fb567a0c23e6c5f09557452c3c57a7 = c5cef8bb9c8c07a0e724607c3e72ca5ad;
			this.c5a33feabbab527f9991c9151f2fda3f8 = c2640f8ea4c8f9515edabfc74f55658b5;
			if (c5cef8bb9c8c07a0e724607c3e72ca5ad.Count > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9420))
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
				int num = this.cd8e4638d450f17f70e62eebfb492658e;
				this.cd8e4638d450f17f70e62eebfb492658e = num + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9424);
				this.c59f7857147924c30b6327ed466cf45da = c5cef8bb9c8c07a0e724607c3e72ca5ad[num];
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00023060 File Offset: 0x00021260
		public IList<Stream> cb081fe1e596491cbbec559c537d35002
		{
			get
			{
				return this.c74fb567a0c23e6c5f09557452c3c57a7;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00023074 File Offset: 0x00021274
		public override void Flush()
		{
			if (this.c59f7857147924c30b6327ed466cf45da != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca.Flush()).MethodHandle;
				}
				this.c59f7857147924c30b6327ed466cf45da.Flush();
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000230A8 File Offset: 0x000212A8
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new InvalidOperationException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41764));
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000230C8 File Offset: 0x000212C8
		public override void SetLength(long value)
		{
			this.c2e2695f06cef280ca1bc117a6e3ac70b = value;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000230DC File Offset: 0x000212DC
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9360);
			int num2 = offset;
			while (count > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9372))
			{
				int num3 = this.c59f7857147924c30b6327ed466cf45da.Read(buffer, num2, count);
				num += num3;
				num2 += num3;
				this.cbbc57d2858bd5d7bd79ba776f8c90591 += (long)num3;
				if (num3 <= count)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca.Read(byte[], int, int)).MethodHandle;
					}
					count -= num3;
				}
				if (count > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9364))
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
					if (this.cd8e4638d450f17f70e62eebfb492658e >= this.c74fb567a0c23e6c5f09557452c3c57a7.Count)
					{
						return num;
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
					IList<Stream> list = this.c74fb567a0c23e6c5f09557452c3c57a7;
					int num4 = this.cd8e4638d450f17f70e62eebfb492658e;
					this.cd8e4638d450f17f70e62eebfb492658e = num4 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9368);
					this.c59f7857147924c30b6327ed466cf45da = list[num4];
				}
			}
			for (;;)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				return num;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000231C0 File Offset: 0x000213C0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			c3391b519887d487f90639994067a0eca.c897de0c6adf1801c796ac2d7d6831905 c897de0c6adf1801c796ac2d7d = new c3391b519887d487f90639994067a0eca.c897de0c6adf1801c796ac2d7d6831905();
			c897de0c6adf1801c796ac2d7d.c4404a159870bf55bb6f111e66e59e82d = this;
			c897de0c6adf1801c796ac2d7d.cc076fd568f4bb05b6e433b9eb4ab0a25 = count;
			c897de0c6adf1801c796ac2d7d.cf3dd00ca7428b66c1434cbe365594419 = callback;
			c897de0c6adf1801c796ac2d7d.c3e9115244d3ee160cb7786db790cbbc9 = buffer;
			c897de0c6adf1801c796ac2d7d.c2a7c7d10f25663bcd8bbee896d07150a = new c3391b519887d487f90639994067a0eca.ca1411689b5345286330bcad1f973d8ec(state);
			if (c897de0c6adf1801c796ac2d7d.cc076fd568f4bb05b6e433b9eb4ab0a25 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9376))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca.BeginRead(byte[], int, int, AsyncCallback, object)).MethodHandle;
				}
				c3391b519887d487f90639994067a0eca.cb3f405c8df506557201ace11d10df102 cb3f405c8df506557201ace11d10df = new c3391b519887d487f90639994067a0eca.cb3f405c8df506557201ace11d10df102();
				cb3f405c8df506557201ace11d10df.c8c38354cddaefb45b9cfcd9ed2838c37 = c897de0c6adf1801c796ac2d7d;
				cb3f405c8df506557201ace11d10df.c20a96a64a6efb7b36a336c0320346e94 = offset;
				cb3f405c8df506557201ace11d10df.ce6b8eae3fadffc5cf43f503af7796545 = c08ae7287a6b4840c7ea72b303075d019.cab55a050df275722227783d6686266c9;
				cb3f405c8df506557201ace11d10df.ce6b8eae3fadffc5cf43f503af7796545 = new AsyncCallback(cb3f405c8df506557201ace11d10df.c01724316518b9f7ebe58698f839bf92e);
				this.c59f7857147924c30b6327ed466cf45da.BeginRead(cb3f405c8df506557201ace11d10df.c8c38354cddaefb45b9cfcd9ed2838c37.c3e9115244d3ee160cb7786db790cbbc9, cb3f405c8df506557201ace11d10df.c20a96a64a6efb7b36a336c0320346e94, cb3f405c8df506557201ace11d10df.c8c38354cddaefb45b9cfcd9ed2838c37.cc076fd568f4bb05b6e433b9eb4ab0a25, cb3f405c8df506557201ace11d10df.ce6b8eae3fadffc5cf43f503af7796545, state);
			}
			else
			{
				c897de0c6adf1801c796ac2d7d.c2a7c7d10f25663bcd8bbee896d07150a.CompletedSynchronously = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9380) != 0);
				c897de0c6adf1801c796ac2d7d.c2a7c7d10f25663bcd8bbee896d07150a.cc65b9abb0a148380ed2a74a09107366c();
				c897de0c6adf1801c796ac2d7d.c2a7c7d10f25663bcd8bbee896d07150a.IsCompleted = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9384) != 0);
				c897de0c6adf1801c796ac2d7d.cf3dd00ca7428b66c1434cbe365594419(c897de0c6adf1801c796ac2d7d.c2a7c7d10f25663bcd8bbee896d07150a);
			}
			return c897de0c6adf1801c796ac2d7d.c2a7c7d10f25663bcd8bbee896d07150a;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000232D4 File Offset: 0x000214D4
		public override int EndRead(IAsyncResult asyncResult)
		{
			asyncResult.AsyncWaitHandle.WaitOne();
			c3391b519887d487f90639994067a0eca.ca1411689b5345286330bcad1f973d8ec ca1411689b5345286330bcad1f973d8ec = (c3391b519887d487f90639994067a0eca.ca1411689b5345286330bcad1f973d8ec)asyncResult;
			if (ca1411689b5345286330bcad1f973d8ec.Exception != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca.EndRead(IAsyncResult)).MethodHandle;
				}
				throw ca1411689b5345286330bcad1f973d8ec.Exception;
			}
			return ca1411689b5345286330bcad1f973d8ec.c1effc665c6a479cf4122a5a96b2b3be5;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00023324 File Offset: 0x00021524
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new InvalidOperationException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41811));
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00023344 File Offset: 0x00021544
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new InvalidOperationException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41811));
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00023364 File Offset: 0x00021564
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (this.c5a33feabbab527f9991c9151f2fda3f8 == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca.Dispose(bool)).MethodHandle;
				}
				IEnumerator<Stream> enumerator = this.cb081fe1e596491cbbec559c537d35002.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Stream stream = enumerator.Current;
						stream.Dispose();
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
					return;
				}
				finally
				{
					if (enumerator != null)
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
						enumerator.Dispose();
					}
				}
			}
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9388); i < this.cb081fe1e596491cbbec559c537d35002.Count; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9392))
			{
				this.cb081fe1e596491cbbec559c537d35002[i].Dispose();
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00023438 File Offset: 0x00021638
		public override bool CanRead
		{
			get
			{
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9396) != 0;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00023450 File Offset: 0x00021650
		public override bool CanSeek
		{
			get
			{
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9400) != 0;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00023468 File Offset: 0x00021668
		public override bool CanWrite
		{
			get
			{
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9404) != 0;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00023480 File Offset: 0x00021680
		public override long Length
		{
			get
			{
				if (this.c2e2695f06cef280ca1bc117a6e3ac70b == (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9408))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca.get_Length()).MethodHandle;
					}
					this.c2e2695f06cef280ca1bc117a6e3ac70b = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9412);
					IEnumerator<Stream> enumerator = this.c74fb567a0c23e6c5f09557452c3c57a7.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Stream stream = enumerator.Current;
							this.c2e2695f06cef280ca1bc117a6e3ac70b += stream.Length;
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
				}
				return this.c2e2695f06cef280ca1bc117a6e3ac70b;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00023538 File Offset: 0x00021738
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0002354C File Offset: 0x0002174C
		public override long Position
		{
			get
			{
				return this.cbbc57d2858bd5d7bd79ba776f8c90591;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x040002BB RID: 699
		private readonly IList<Stream> c74fb567a0c23e6c5f09557452c3c57a7;

		// Token: 0x040002BC RID: 700
		private readonly IList<int> c5a33feabbab527f9991c9151f2fda3f8;

		// Token: 0x040002BD RID: 701
		private int cd8e4638d450f17f70e62eebfb492658e;

		// Token: 0x040002BE RID: 702
		private Stream c59f7857147924c30b6327ed466cf45da;

		// Token: 0x040002BF RID: 703
		private long c2e2695f06cef280ca1bc117a6e3ac70b = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9416);

		// Token: 0x040002C0 RID: 704
		private long cbbc57d2858bd5d7bd79ba776f8c90591;

		// Token: 0x02000137 RID: 311
		internal class ca1411689b5345286330bcad1f973d8ec : IAsyncResult
		{
			// Token: 0x06000934 RID: 2356 RVA: 0x0005EADC File Offset: 0x0005CCDC
			public ca1411689b5345286330bcad1f973d8ec(object cc0477df710b000bc022191818689a493)
			{
				this.c47500d302998ede9ecdffe8040d995b5 = cc0477df710b000bc022191818689a493;
				this.c1b4b166f5f51f574849f4690ce337167 = new ManualResetEvent(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30540) != 0);
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x06000935 RID: 2357 RVA: 0x0005EB0C File Offset: 0x0005CD0C
			// (set) Token: 0x06000936 RID: 2358 RVA: 0x0005EB20 File Offset: 0x0005CD20
			public bool IsCompleted { get; internal set; }

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x06000937 RID: 2359 RVA: 0x0005EB34 File Offset: 0x0005CD34
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return this.c1b4b166f5f51f574849f4690ce337167;
				}
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x06000938 RID: 2360 RVA: 0x0005EB48 File Offset: 0x0005CD48
			public object AsyncState
			{
				get
				{
					return this.c47500d302998ede9ecdffe8040d995b5;
				}
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x06000939 RID: 2361 RVA: 0x0005EB5C File Offset: 0x0005CD5C
			// (set) Token: 0x0600093A RID: 2362 RVA: 0x0005EB70 File Offset: 0x0005CD70
			public bool CompletedSynchronously { get; internal set; }

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x0600093B RID: 2363 RVA: 0x0005EB84 File Offset: 0x0005CD84
			// (set) Token: 0x0600093C RID: 2364 RVA: 0x0005EB98 File Offset: 0x0005CD98
			public Exception Exception { get; internal set; }

			// Token: 0x0600093D RID: 2365 RVA: 0x0005EBAC File Offset: 0x0005CDAC
			internal void cc65b9abb0a148380ed2a74a09107366c()
			{
				this.c1b4b166f5f51f574849f4690ce337167.Set();
			}

			// Token: 0x040006BE RID: 1726
			private readonly object c47500d302998ede9ecdffe8040d995b5;

			// Token: 0x040006BF RID: 1727
			[CompilerGenerated]
			private bool c7d93788a838a77d6c282c29e852140d1;

			// Token: 0x040006C0 RID: 1728
			[CompilerGenerated]
			private bool c438a2039f84b50343c58483905655467;

			// Token: 0x040006C1 RID: 1729
			[CompilerGenerated]
			private Exception c140e66f0dd63e7fbdf9a0577d1aa6184;

			// Token: 0x040006C2 RID: 1730
			private readonly ManualResetEvent c1b4b166f5f51f574849f4690ce337167;

			// Token: 0x040006C3 RID: 1731
			public int c1effc665c6a479cf4122a5a96b2b3be5;
		}

		// Token: 0x02000138 RID: 312
		[CompilerGenerated]
		private sealed class c897de0c6adf1801c796ac2d7d6831905
		{
			// Token: 0x040006C4 RID: 1732
			public c3391b519887d487f90639994067a0eca.ca1411689b5345286330bcad1f973d8ec c2a7c7d10f25663bcd8bbee896d07150a;

			// Token: 0x040006C5 RID: 1733
			public int cc076fd568f4bb05b6e433b9eb4ab0a25;

			// Token: 0x040006C6 RID: 1734
			public AsyncCallback cf3dd00ca7428b66c1434cbe365594419;

			// Token: 0x040006C7 RID: 1735
			public byte[] c3e9115244d3ee160cb7786db790cbbc9;

			// Token: 0x040006C8 RID: 1736
			public c3391b519887d487f90639994067a0eca c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000139 RID: 313
		[CompilerGenerated]
		private sealed class cb3f405c8df506557201ace11d10df102
		{
			// Token: 0x06000940 RID: 2368 RVA: 0x0005EBF0 File Offset: 0x0005CDF0
			internal void c01724316518b9f7ebe58698f839bf92e(IAsyncResult ca30f7556a77e52c5c3c5dcd85666edce)
			{
				try
				{
					int num = this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.c59f7857147924c30b6327ed466cf45da.EndRead(ca30f7556a77e52c5c3c5dcd85666edce);
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.c1effc665c6a479cf4122a5a96b2b3be5 += num;
					this.c20a96a64a6efb7b36a336c0320346e94 += num;
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cbbc57d2858bd5d7bd79ba776f8c90591 = this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cbbc57d2858bd5d7bd79ba776f8c90591 + (long)num;
					if (num <= this.c8c38354cddaefb45b9cfcd9ed2838c37.cc076fd568f4bb05b6e433b9eb4ab0a25)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c3391b519887d487f90639994067a0eca.cb3f405c8df506557201ace11d10df102.c01724316518b9f7ebe58698f839bf92e(IAsyncResult)).MethodHandle;
						}
						this.c8c38354cddaefb45b9cfcd9ed2838c37.cc076fd568f4bb05b6e433b9eb4ab0a25 = this.c8c38354cddaefb45b9cfcd9ed2838c37.cc076fd568f4bb05b6e433b9eb4ab0a25 - num;
					}
					if (this.c8c38354cddaefb45b9cfcd9ed2838c37.cc076fd568f4bb05b6e433b9eb4ab0a25 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30544))
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
						if (this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cd8e4638d450f17f70e62eebfb492658e >= this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.c74fb567a0c23e6c5f09557452c3c57a7.Count)
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
							this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.CompletedSynchronously = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30548) != 0);
							this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.cc65b9abb0a148380ed2a74a09107366c();
							this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.IsCompleted = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30552) != 0);
							this.c8c38354cddaefb45b9cfcd9ed2838c37.cf3dd00ca7428b66c1434cbe365594419(this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a);
						}
						else
						{
							c3391b519887d487f90639994067a0eca c4404a159870bf55bb6f111e66e59e82d = this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d;
							IList<Stream> c74fb567a0c23e6c5f09557452c3c57a = this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.c74fb567a0c23e6c5f09557452c3c57a7;
							c3391b519887d487f90639994067a0eca c4404a159870bf55bb6f111e66e59e82d2 = this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d;
							int cd8e4638d450f17f70e62eebfb492658e = this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cd8e4638d450f17f70e62eebfb492658e;
							c4404a159870bf55bb6f111e66e59e82d2.cd8e4638d450f17f70e62eebfb492658e = cd8e4638d450f17f70e62eebfb492658e + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30556);
							c4404a159870bf55bb6f111e66e59e82d.c59f7857147924c30b6327ed466cf45da = c74fb567a0c23e6c5f09557452c3c57a[cd8e4638d450f17f70e62eebfb492658e];
							this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.c59f7857147924c30b6327ed466cf45da.BeginRead(this.c8c38354cddaefb45b9cfcd9ed2838c37.c3e9115244d3ee160cb7786db790cbbc9, this.c20a96a64a6efb7b36a336c0320346e94, this.c8c38354cddaefb45b9cfcd9ed2838c37.cc076fd568f4bb05b6e433b9eb4ab0a25, this.ce6b8eae3fadffc5cf43f503af7796545, ca30f7556a77e52c5c3c5dcd85666edce.AsyncState);
						}
					}
					else
					{
						this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.CompletedSynchronously = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30560) != 0);
						this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.cc65b9abb0a148380ed2a74a09107366c();
						this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.IsCompleted = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30564) != 0);
						this.c8c38354cddaefb45b9cfcd9ed2838c37.cf3dd00ca7428b66c1434cbe365594419(this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a);
					}
				}
				catch (Exception exception)
				{
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.Exception = exception;
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.CompletedSynchronously = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30568) != 0);
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.cc65b9abb0a148380ed2a74a09107366c();
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a.IsCompleted = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30572) != 0);
					this.c8c38354cddaefb45b9cfcd9ed2838c37.cf3dd00ca7428b66c1434cbe365594419(this.c8c38354cddaefb45b9cfcd9ed2838c37.c2a7c7d10f25663bcd8bbee896d07150a);
				}
			}

			// Token: 0x040006C9 RID: 1737
			public int c20a96a64a6efb7b36a336c0320346e94;

			// Token: 0x040006CA RID: 1738
			public AsyncCallback ce6b8eae3fadffc5cf43f503af7796545;

			// Token: 0x040006CB RID: 1739
			public c3391b519887d487f90639994067a0eca.c897de0c6adf1801c796ac2d7d6831905 c8c38354cddaefb45b9cfcd9ed2838c37;
		}
	}
}
