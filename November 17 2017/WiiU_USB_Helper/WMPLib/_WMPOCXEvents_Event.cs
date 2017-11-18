using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	// Token: 0x020000E6 RID: 230
	[CompilerGenerated]
	[ComEventInterface(typeof(_WMPOCXEvents), typeof(_WMPOCXEvents))]
	[TypeIdentifier("6bf52a50-394a-11d3-b153-00c04f79faa6", "WMPLib._WMPOCXEvents_Event")]
	[ComImport]
	public interface _WMPOCXEvents_Event
	{
		// Token: 0x06000846 RID: 2118
		void _VtblGap1_2();

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000847 RID: 2119
		// (remove) Token: 0x06000848 RID: 2120
		event _WMPOCXEvents_PlayStateChangeEventHandler PlayStateChange;
	}
}
