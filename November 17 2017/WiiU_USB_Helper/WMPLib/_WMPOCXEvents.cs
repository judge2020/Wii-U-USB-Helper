using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	// Token: 0x020000E5 RID: 229
	[InterfaceType(2)]
	[TypeIdentifier]
	[CompilerGenerated]
	[Guid("6BF52A51-394A-11D3-B153-00C04F79FAA6")]
	[ComImport]
	public interface _WMPOCXEvents
	{
		// Token: 0x06000844 RID: 2116
		void _VtblGap1_1();

		// Token: 0x06000845 RID: 2117
		[DispId(5101)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayStateChange([In] int NewState);
	}
}
