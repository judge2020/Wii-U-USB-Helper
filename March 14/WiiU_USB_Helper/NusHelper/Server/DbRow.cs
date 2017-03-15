// Decompiled with JetBrains decompiler
// Type: NusHelper.Server.DbRow
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

namespace NusHelper.Server
{
  public sealed class DbRow
  {
    public bool DiscOnly { get; set; }

    public string EshopId { get; set; }

    public string IconUrl { get; set; }

    public string Name { get; set; }

    public Platform Platform { get; set; }

    public bool PreLoad { get; set; }

    public string ProductCode { get; set; }

    public string Region { get; set; }

    public DataSize Size { get; set; }

    public TitleId TitleId { get; set; }

    public string Version { get; set; }
  }
}
