using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	// Token: 0x020000E2 RID: 226
	[Guid("9104D1AB-80C9-4FED-ABF0-2E6417A6DF14")]
	[TypeIdentifier]
	[CompilerGenerated]
	[ComImport]
	public interface IWMPSettings
	{
		// Token: 0x06000841 RID: 2113
		void _VtblGap1_17();

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000842 RID: 2114
		// (set) Token: 0x06000843 RID: 2115
		[DispId(107)]
		int volume { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
