// Decompiled with JetBrains decompiler
// Type: A.cf737d5fc357269cf79a2cfd9f8ae6a86
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class cf737d5fc357269cf79a2cfd9f8ae6a86
  {
    [JsonProperty("dimension")]
    public string Dimension { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("movie_url")]
    public string MovieUrl { get; set; }

    [JsonProperty("play_time_sec")]
    public int PlayTimeSec { get; set; }

    [JsonProperty("quality")]
    public string Quality { get; set; }

    [JsonProperty("width")]
    public int Width { get; set; }
  }
}
