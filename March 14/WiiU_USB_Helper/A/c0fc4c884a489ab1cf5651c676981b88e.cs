// Decompiled with JetBrains decompiler
// Type: A.c0fc4c884a489ab1cf5651c676981b88e
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class c0fc4c884a489ab1cf5651c676981b88e
  {
    [JsonProperty("controllers")]
    public c6209113007a9ad14856270d1b7d6283f Controllers { get; set; }

    [JsonProperty("features")]
    public c4966496e72141c4079228dd9259d5890 Features { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
  }
}
