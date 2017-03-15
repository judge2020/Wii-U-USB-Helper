// Decompiled with JetBrains decompiler
// Type: A.cfdc97586078fe0abfe50aa3f3f0b6a00
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System.Runtime.InteropServices;

namespace A
{
  internal static class cfdc97586078fe0abfe50aa3f3f0b6a00
  {
    public const uint cd373a766cb256db66899152a5dd8beda = 2147483648;
    public const uint c852509fef50b0504b620c30cff98bdc0 = 1;

    [DllImport("kernel32.dll", EntryPoint = "SetThreadExecutionState")]
    public static extern uint c1610d9088efb2cefe9c41d21c5a4cc5d(uint ca0cabe5ba6d3b74bf181051baebc878b);
  }
}
