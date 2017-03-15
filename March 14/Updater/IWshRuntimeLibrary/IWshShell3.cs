// Decompiled with JetBrains decompiler
// Type: IWshRuntimeLibrary.IWshShell3
// Assembly: Updater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7FC3B5C5-5FF7-42B2-B7F0-8C213AAF0FEC
// Assembly location: C:\Users\hunte\Documents\DECompiles\Updater.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
  [CompilerGenerated]
  [Guid("41904400-BE18-11D3-A28B-00104BD35090")]
  [TypeIdentifier]
  [ComImport]
  public interface IWshShell3 : IWshShell2
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_4();

    [DispId(1002)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    object CreateShortcut([MarshalAs(UnmanagedType.BStr), In] string PathLink);
  }
}
