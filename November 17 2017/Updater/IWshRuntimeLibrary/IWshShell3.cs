using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[TypeIdentifier]
	[ComImport]
	public interface IWshShell3 : IWshShell2
	{
		// Token: 0x06000059 RID: 89
		void _VtblGap1_4();

		// Token: 0x0600005A RID: 90
		[DispId(1002)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([MarshalAs(UnmanagedType.BStr)] [In] string PathLink);
	}
}
