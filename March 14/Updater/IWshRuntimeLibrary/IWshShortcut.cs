// Decompiled with JetBrains decompiler
// Type: IWshRuntimeLibrary.IWshShortcut
// Assembly: Updater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7FC3B5C5-5FF7-42B2-B7F0-8C213AAF0FEC
// Assembly location: C:\Users\hunte\Documents\DECompiles\Updater.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
  [CompilerGenerated]
  [Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
  [TypeIdentifier]
  [ComImport]
  public interface IWshShortcut
  {
    [DispId(0)]
    [IndexerName("FullName")]
    string this[] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1001)]
    string Description { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(1003)]
    string IconLocation { [DispId(1003), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1003), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(1005)]
    string TargetPath { [DispId(1005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(1007)]
    string WorkingDirectory { [DispId(1007), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1007), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_2();

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap2_2();

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap3_1();

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap4_2();

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap5_1();

    [DispId(2001)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Save();
  }
}
