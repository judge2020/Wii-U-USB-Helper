using System;
using System.IO;
using System.Threading;

namespace A
{
	// Token: 0x02000071 RID: 113
	internal class cb83d7b9bc2570649b0e380bddf8cf193 : Stream
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00014F48 File Offset: 0x00013148
		public cb83d7b9bc2570649b0e380bddf8cf193(Stream c84ce20aad4b5d2427f15dd9ec820338e) : this(c84ce20aad4b5d2427f15dd9ec820338e, (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4928))
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00014F68 File Offset: 0x00013168
		public cb83d7b9bc2570649b0e380bddf8cf193(Stream c84ce20aad4b5d2427f15dd9ec820338e, long c456a6b51fa6bfe3af99eabb77a5d252b)
		{
			if (c84ce20aad4b5d2427f15dd9ec820338e == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb83d7b9bc2570649b0e380bddf8cf193..ctor(Stream, long)).MethodHandle;
				}
				throw new ArgumentNullException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9341));
			}
			if (c456a6b51fa6bfe3af99eabb77a5d252b < (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4932))
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
				throw new ArgumentOutOfRangeException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9362), c456a6b51fa6bfe3af99eabb77a5d252b, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9405));
			}
			this.ca581cf8d1381552243c10e78209a9159 = c84ce20aad4b5d2427f15dd9ec820338e;
			this.cf3cef5ddc4ebe2b89d9eb28486081d27 = c456a6b51fa6bfe3af99eabb77a5d252b;
			this.c161ba0e88c0a1646484e5d7752926e6c = this.c3ba4ce5e08580756d875440a0fe32ecd;
			this.c3eb9816284a1674a3e7353370cc2df84 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4936);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0001500C File Offset: 0x0001320C
		public override bool CanRead
		{
			get
			{
				return this.ca581cf8d1381552243c10e78209a9159.CanRead;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00015028 File Offset: 0x00013228
		public override bool CanSeek
		{
			get
			{
				return this.ca581cf8d1381552243c10e78209a9159.CanSeek;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00015044 File Offset: 0x00013244
		public override bool CanWrite
		{
			get
			{
				return this.ca581cf8d1381552243c10e78209a9159.CanWrite;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00015060 File Offset: 0x00013260
		public override long Length
		{
			get
			{
				return this.ca581cf8d1381552243c10e78209a9159.Length;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0001507C File Offset: 0x0001327C
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00015090 File Offset: 0x00013290
		public long cbb05c341b78362a11ddbebf38c4ef001
		{
			get
			{
				return this.cf3cef5ddc4ebe2b89d9eb28486081d27;
			}
			set
			{
				if (this.cbb05c341b78362a11ddbebf38c4ef001 != value)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb83d7b9bc2570649b0e380bddf8cf193.set_cbb05c341b78362a11ddbebf38c4ef001(long)).MethodHandle;
					}
					this.cf3cef5ddc4ebe2b89d9eb28486081d27 = value;
					this.c171e7a874e76c5327cbd452e66125a75();
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000150C8 File Offset: 0x000132C8
		// (set) Token: 0x0600033C RID: 828 RVA: 0x000150E4 File Offset: 0x000132E4
		public override long Position
		{
			get
			{
				return this.ca581cf8d1381552243c10e78209a9159.Position;
			}
			set
			{
				this.ca581cf8d1381552243c10e78209a9159.Position = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00015100 File Offset: 0x00013300
		protected long c3ba4ce5e08580756d875440a0fe32ecd
		{
			get
			{
				return (long)Environment.TickCount;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00015118 File Offset: 0x00013318
		public override void Flush()
		{
			this.ca581cf8d1381552243c10e78209a9159.Flush();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00015130 File Offset: 0x00013330
		public override int Read(byte[] buffer, int offset, int count)
		{
			this.cf4a54d827d38d19e9f709554c810097f(count);
			return this.ca581cf8d1381552243c10e78209a9159.Read(buffer, offset, count);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00015154 File Offset: 0x00013354
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.ca581cf8d1381552243c10e78209a9159.Seek(offset, origin);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00015170 File Offset: 0x00013370
		public override void SetLength(long value)
		{
			this.ca581cf8d1381552243c10e78209a9159.SetLength(value);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001518C File Offset: 0x0001338C
		public override string ToString()
		{
			return this.ca581cf8d1381552243c10e78209a9159.ToString();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000151A8 File Offset: 0x000133A8
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.cf4a54d827d38d19e9f709554c810097f(count);
			this.ca581cf8d1381552243c10e78209a9159.Write(buffer, offset, count);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000151CC File Offset: 0x000133CC
		protected void c171e7a874e76c5327cbd452e66125a75()
		{
			if (this.c3ba4ce5e08580756d875440a0fe32ecd - this.c161ba0e88c0a1646484e5d7752926e6c > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4896))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb83d7b9bc2570649b0e380bddf8cf193.c171e7a874e76c5327cbd452e66125a75()).MethodHandle;
				}
				this.c3eb9816284a1674a3e7353370cc2df84 = (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4900);
				this.c161ba0e88c0a1646484e5d7752926e6c = this.c3ba4ce5e08580756d875440a0fe32ecd;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00015228 File Offset: 0x00013428
		protected void cf4a54d827d38d19e9f709554c810097f(int cbaf98471c6f5128290df74166515c55e)
		{
			if (this.cf3cef5ddc4ebe2b89d9eb28486081d27 > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4904))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb83d7b9bc2570649b0e380bddf8cf193.cf4a54d827d38d19e9f709554c810097f(int)).MethodHandle;
				}
				if (cbaf98471c6f5128290df74166515c55e > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4908))
				{
					this.c3eb9816284a1674a3e7353370cc2df84 += (long)cbaf98471c6f5128290df74166515c55e;
					long num = this.c3ba4ce5e08580756d875440a0fe32ecd - this.c161ba0e88c0a1646484e5d7752926e6c;
					if (num > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4912))
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
						if (this.c3eb9816284a1674a3e7353370cc2df84 * (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4916) / num > this.cf3cef5ddc4ebe2b89d9eb28486081d27)
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
							int num2 = (int)(this.c3eb9816284a1674a3e7353370cc2df84 * (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4920) / this.cf3cef5ddc4ebe2b89d9eb28486081d27 - num);
							if (num2 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4924))
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
								try
								{
									Thread.Sleep(num2);
								}
								catch (ThreadAbortException)
								{
								}
								this.c171e7a874e76c5327cbd452e66125a75();
							}
						}
					}
					return;
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
		}

		// Token: 0x040001E0 RID: 480
		public const long c23e3b71963ba5a81a681318be7104f09 = 0L;

		// Token: 0x040001E1 RID: 481
		private readonly Stream ca581cf8d1381552243c10e78209a9159;

		// Token: 0x040001E2 RID: 482
		private long c3eb9816284a1674a3e7353370cc2df84;

		// Token: 0x040001E3 RID: 483
		private long cf3cef5ddc4ebe2b89d9eb28486081d27;

		// Token: 0x040001E4 RID: 484
		private long c161ba0e88c0a1646484e5d7752926e6c;
	}
}
