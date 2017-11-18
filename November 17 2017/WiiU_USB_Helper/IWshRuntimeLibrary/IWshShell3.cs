using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x020000DA RID: 218
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[CompilerGenerated]
	[TypeIdentifier]
	[ComImport]
	public interface IWshShell3 : IWshShell2
	{
		// Token: 0x06000825 RID: 2085
		void _VtblGap1_4();

		// Token: 0x06000826 RID: 2086
		[DispId(1002)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([MarshalAs(UnmanagedType.BStr)] [In] string PathLink);
	}
}
