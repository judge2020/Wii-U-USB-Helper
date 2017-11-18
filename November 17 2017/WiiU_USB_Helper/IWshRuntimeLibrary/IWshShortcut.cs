using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x020000DB RID: 219
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[DefaultMember("FullName")]
	[TypeIdentifier]
	[CompilerGenerated]
	[ComImport]
	public interface IWshShortcut
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000827 RID: 2087
		[DispId(0)]
		string FullName { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000828 RID: 2088
		// (set) Token: 0x06000829 RID: 2089
		[DispId(1000)]
		string Arguments { [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600082A RID: 2090
		// (set) Token: 0x0600082B RID: 2091
		[DispId(1001)]
		string Description { [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x0600082C RID: 2092
		void _VtblGap1_2();

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600082D RID: 2093
		// (set) Token: 0x0600082E RID: 2094
		[DispId(1003)]
		string IconLocation { [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x0600082F RID: 2095
		void _VtblGap2_1();

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000830 RID: 2096
		// (set) Token: 0x06000831 RID: 2097
		[DispId(1005)]
		string TargetPath { [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000832 RID: 2098
		void _VtblGap3_2();

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000833 RID: 2099
		// (set) Token: 0x06000834 RID: 2100
		[DispId(1007)]
		string WorkingDirectory { [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000835 RID: 2101
		void _VtblGap4_1();

		// Token: 0x06000836 RID: 2102
		[DispId(2001)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Save();
	}
}
