using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x02000010 RID: 16
	[CompilerGenerated]
	[DefaultMember("FullName")]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	[ComImport]
	public interface IWshShortcut
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005B RID: 91
		[DispId(0)]
		string FullName { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600005C RID: 92
		void _VtblGap1_2();

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005D RID: 93
		// (set) Token: 0x0600005E RID: 94
		[DispId(1001)]
		string Description { [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x0600005F RID: 95
		void _VtblGap2_2();

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000060 RID: 96
		// (set) Token: 0x06000061 RID: 97
		[DispId(1003)]
		string IconLocation { [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000062 RID: 98
		void _VtblGap3_1();

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000063 RID: 99
		// (set) Token: 0x06000064 RID: 100
		[DispId(1005)]
		string TargetPath { [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000065 RID: 101
		void _VtblGap4_2();

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000066 RID: 102
		// (set) Token: 0x06000067 RID: 103
		[DispId(1007)]
		string WorkingDirectory { [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000068 RID: 104
		void _VtblGap5_1();

		// Token: 0x06000069 RID: 105
		[DispId(2001)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Save();
	}
}
