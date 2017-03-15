// Decompiled with JetBrains decompiler
// Type: A.c9156cbddd5e7ad30d02afcc5d90e556f
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class c9156cbddd5e7ad30d02afcc5d90e556f
  {
    [JsonProperty("conditional_ratings")]
    public c84e982887bf9da3143846a815f622ce3 ConditionalRatings { get; set; }

    [JsonProperty("score")]
    public double Score { get; set; }

    [JsonProperty("star1")]
    public int Star1 { get; set; }

    [JsonProperty("star2")]
    public int Star2 { get; set; }

    [JsonProperty("star3")]
    public int Star3 { get; set; }

    [JsonProperty("star4")]
    public int Star4 { get; set; }

    [JsonProperty("star5")]
    public int Star5 { get; set; }

    [JsonProperty("votes")]
    public int Votes { get; set; }
  }
}
