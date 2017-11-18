using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	// Token: 0x020000E1 RID: 225
	[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
	[CompilerGenerated]
	[TypeIdentifier]
	[ComImport]
	public interface IWMPPlayer4 : IWMPCore3
	{
		// Token: 0x0600083A RID: 2106
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void close();

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600083B RID: 2107
		// (set) Token: 0x0600083C RID: 2108
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x0600083D RID: 2109
		void _VtblGap1_1();

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600083E RID: 2110
		[DispId(10)]
		WMPPlayState playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600083F RID: 2111
		[DispId(4)]
		IWMPControls controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000840 RID: 2112
		[DispId(5)]
		IWMPSettings settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
