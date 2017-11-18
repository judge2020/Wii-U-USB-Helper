using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	// Token: 0x020000DD RID: 221
	[Guid("74C09E02-F828-11D2-A74B-00A0C905F36E")]
	[TypeIdentifier]
	[CompilerGenerated]
	[ComImport]
	public interface IWMPControls
	{
		// Token: 0x06000837 RID: 2103
		void _VtblGap1_1();

		// Token: 0x06000838 RID: 2104
		[DispId(51)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void play();

		// Token: 0x06000839 RID: 2105
		[DispId(52)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void stop();
	}
}
