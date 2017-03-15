// Decompiled with JetBrains decompiler
// Type: A.cbd9d23875bab012857e040a881a1cf4c
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NusHelper;
using System;
using System.Runtime.CompilerServices;

namespace A
{
  public struct cbd9d23875bab012857e040a881a1cf4c
  {
    public readonly ulong c9eb7047107143e53f0d8d11adb0f4ea3;

    public cbd9d23875bab012857e040a881a1cf4c(DataSize c018ed819fab46c246401a24bfca0a2de, TimeSpan cbc292fa325e94790e6c150e51d2fe07c)
    {
      this.c9eb7047107143e53f0d8d11adb0f4ea3 = (ulong) ((double) c018ed819fab46c246401a24bfca0a2de.TotalBytes / cbc292fa325e94790e6c150e51d2fe07c.TotalSeconds);
    }

    public cbd9d23875bab012857e040a881a1cf4c(ulong c671aaf4f714f01fb2ce91badf6ede298)
    {
      this.c9eb7047107143e53f0d8d11adb0f4ea3 = c671aaf4f714f01fb2ce91badf6ede298;
    }

    [SpecialName]
    public static DataSize cc8c37a4d1df791f2a2848001577305c5(cbd9d23875bab012857e040a881a1cf4c c1702fd767aac6c8bee7d29fefdbc637d, TimeSpan cbc292fa325e94790e6c150e51d2fe07c)
    {
      return new DataSize((ulong) ((double) c1702fd767aac6c8bee7d29fefdbc637d.c9eb7047107143e53f0d8d11adb0f4ea3 * cbc292fa325e94790e6c150e51d2fe07c.TotalSeconds));
    }

    [SpecialName]
    public static TimeSpan cec79878e9d2dc4f8744f79477e74ae81(DataSize c018ed819fab46c246401a24bfca0a2de, cbd9d23875bab012857e040a881a1cf4c c1702fd767aac6c8bee7d29fefdbc637d)
    {
      return TimeSpan.FromSeconds((double) (c018ed819fab46c246401a24bfca0a2de.TotalBytes / c1702fd767aac6c8bee7d29fefdbc637d.c9eb7047107143e53f0d8d11adb0f4ea3));
    }

    public cbd9d23875bab012857e040a881a1cf4c c37400c974c66cbcb81903bc0bc3e0ba7(cbd9d23875bab012857e040a881a1cf4c c5668e2f30f5b67537d52ac3f12892834)
    {
      return new cbd9d23875bab012857e040a881a1cf4c((this.c9eb7047107143e53f0d8d11adb0f4ea3 + c5668e2f30f5b67537d52ac3f12892834.c9eb7047107143e53f0d8d11adb0f4ea3) / (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(856));
    }

    public override string ToString()
    {
      return c1bbcad09f7d3f69ee1d8850af68486c5.c1df95097ffa57d753c5fe1353cf65e86((object) c4bc21fff1211818d530573d3a446c381.c1df95097ffa57d753c5fe1353cf65e86(this, TimeSpan.FromSeconds(cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(860))), (object) c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3183));
    }
  }
}
