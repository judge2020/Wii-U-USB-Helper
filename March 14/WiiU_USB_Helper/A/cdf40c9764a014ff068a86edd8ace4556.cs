// Decompiled with JetBrains decompiler
// Type: A.cdf40c9764a014ff068a86edd8ace4556
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;

namespace A
{
  public class cdf40c9764a014ff068a86edd8ace4556 : EventArgs
  {
    public TimeSpan FileEta { get; }

    public int FileProgress { get; }

    public TimeSpan GameEta { get; }

    public int GameProgress { get; }

    public cbd9d23875bab012857e040a881a1cf4c Speed { get; }

    public cba6aa8f767d2e8dfbca2d43d7148c173 Title { get; }

    public TimeSpan TotalEta { get; }

    public int TotalProgress { get; }

    internal cdf40c9764a014ff068a86edd8ace4556(int c513f564856e9f3cf22ac673a10f8ec00, int cb3f163354910027d74cbe03948379428, int c74d61e7591b45923504f4d3b6f4b6e45, TimeSpan c49e6dd84e5eb86285ff5ac0327122f72, TimeSpan cb27e0c364da45dbb1af103f393079549, TimeSpan ca4159c8c6231b15e576b10731d67bfe9, cbd9d23875bab012857e040a881a1cf4c cd4227f7784d7614c9fb9985ea0ec696e, cba6aa8f767d2e8dfbca2d43d7148c173 cc6727014e1b7263240d223d71de35d59)
    {
      this.GameProgress = c513f564856e9f3cf22ac673a10f8ec00;
      this.TotalProgress = cb3f163354910027d74cbe03948379428;
      this.GameEta = c49e6dd84e5eb86285ff5ac0327122f72;
      this.TotalEta = cb27e0c364da45dbb1af103f393079549;
      this.Speed = cd4227f7784d7614c9fb9985ea0ec696e;
      this.FileEta = ca4159c8c6231b15e576b10731d67bfe9;
      this.FileProgress = c74d61e7591b45923504f4d3b6f4b6e45;
      this.Title = cc6727014e1b7263240d223d71de35d59;
    }
  }
}
