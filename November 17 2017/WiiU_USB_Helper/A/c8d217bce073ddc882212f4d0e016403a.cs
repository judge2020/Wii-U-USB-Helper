using System;
using NusHelper;

namespace A
{
	// Token: 0x02000067 RID: 103
	public struct c8d217bce073ddc882212f4d0e016403a
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x000117CC File Offset: 0x0000F9CC
		public c8d217bce073ddc882212f4d0e016403a(DataSize cf00748d6ac598f8f622ffaa4f409f181, TimeSpan c031757185888c4022f83af05ad88e157)
		{
			this.c5d7bf84d590334ae5c615432db3d63e7 = (ulong)(cf00748d6ac598f8f622ffaa4f409f181.TotalBytes / c031757185888c4022f83af05ad88e157.TotalSeconds);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000117F8 File Offset: 0x0000F9F8
		public c8d217bce073ddc882212f4d0e016403a(ulong caf60e72ea0e2ef1eff0efd30b124aad1)
		{
			this.c5d7bf84d590334ae5c615432db3d63e7 = caf60e72ea0e2ef1eff0efd30b124aad1;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001180C File Offset: 0x0000FA0C
		public static DataSize c4fc62fd4d0132366a965ec34b69311af(c8d217bce073ddc882212f4d0e016403a cb3eb5100b01bc6a1cc4e693d47b35a15, TimeSpan c031757185888c4022f83af05ad88e157)
		{
			return new DataSize((ulong)(cb3eb5100b01bc6a1cc4e693d47b35a15.c5d7bf84d590334ae5c615432db3d63e7 * c031757185888c4022f83af05ad88e157.TotalSeconds));
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00011834 File Offset: 0x0000FA34
		public static TimeSpan cbe80e56ef3666affaf313331b8104f2d(DataSize cf00748d6ac598f8f622ffaa4f409f181, c8d217bce073ddc882212f4d0e016403a cb3eb5100b01bc6a1cc4e693d47b35a15)
		{
			if (cb3eb5100b01bc6a1cc4e693d47b35a15.c5d7bf84d590334ae5c615432db3d63e7 == 0UL)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8d217bce073ddc882212f4d0e016403a.cbe80e56ef3666affaf313331b8104f2d(DataSize, c8d217bce073ddc882212f4d0e016403a)).MethodHandle;
				}
				return new TimeSpan((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4208));
			}
			return TimeSpan.FromSeconds(cf00748d6ac598f8f622ffaa4f409f181.TotalBytes / cb3eb5100b01bc6a1cc4e693d47b35a15.c5d7bf84d590334ae5c615432db3d63e7);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00011888 File Offset: 0x0000FA88
		public c8d217bce073ddc882212f4d0e016403a c2fa1e81c0d6ac4921b15a1079bf1e7d4(c8d217bce073ddc882212f4d0e016403a c78a30060e7f56cfb1dc5bc34b62cf5a2)
		{
			return new c8d217bce073ddc882212f4d0e016403a((this.c5d7bf84d590334ae5c615432db3d63e7 + c78a30060e7f56cfb1dc5bc34b62cf5a2.c5d7bf84d590334ae5c615432db3d63e7) / (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4212)));
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000118B4 File Offset: 0x0000FAB4
		public override string ToString()
		{
			return c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cac2386e3558afe9fea7e694788feaf60.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this, TimeSpan.FromSeconds(cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(4216))), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6988));
		}

		// Token: 0x0400019F RID: 415
		public readonly ulong c5d7bf84d590334ae5c615432db3d63e7;
	}
}
