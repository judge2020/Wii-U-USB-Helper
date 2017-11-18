using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x02000017 RID: 23
	public static class c61e2736b998bdf598f9e1f9d90eb5547
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00004EFC File Offset: 0x000030FC
		public static bool c2d3f26433491ff35cdc3587b8acfa19d(this RadListView c82dd34236c6c1a53878feade40e0b3a1, c6114b34ba4893a53ebb4b599e0e2e3fc c6b7fbe462f43433d64916e9273f7e5d1)
		{
			c61e2736b998bdf598f9e1f9d90eb5547.cff5620ddc9d136287a978b82aad558e2 cff5620ddc9d136287a978b82aad558e = new c61e2736b998bdf598f9e1f9d90eb5547.cff5620ddc9d136287a978b82aad558e2();
			cff5620ddc9d136287a978b82aad558e.c6b7fbe462f43433d64916e9273f7e5d1 = c6b7fbe462f43433d64916e9273f7e5d1;
			return c82dd34236c6c1a53878feade40e0b3a1.Items.Any(new Func<ListViewDataItem, bool>(cff5620ddc9d136287a978b82aad558e.c7182ddc6fbf852639d52cb3d393864b9));
		}

		// Token: 0x020000EF RID: 239
		[CompilerGenerated]
		private sealed class cff5620ddc9d136287a978b82aad558e2
		{
			// Token: 0x06000860 RID: 2144 RVA: 0x0005AA7C File Offset: 0x00058C7C
			internal bool c7182ddc6fbf852639d52cb3d393864b9(ListViewDataItem cdeb883c40f9a2378d88e71037beec6cb)
			{
				return cdeb883c40f9a2378d88e71037beec6cb.Value == this.c6b7fbe462f43433d64916e9273f7e5d1;
			}

			// Token: 0x040005E7 RID: 1511
			public c6114b34ba4893a53ebb4b599e0e2e3fc c6b7fbe462f43433d64916e9273f7e5d1;
		}
	}
}
