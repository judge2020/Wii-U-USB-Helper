// Decompiled with JetBrains decompiler
// Type: A.cb520af621e92d2d0d069f641ebc2e5fe
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class cb520af621e92d2d0d069f641ebc2e5fe
  {
    [JsonProperty("descriptors")]
    public c9f6f2530565bf2c7a05f7f7a30c4a19e Descriptors { get; set; }

    [JsonProperty("rating")]
    public c3d2a32ac680c944edd20ad4c2623a1cd Rating { get; set; }

    [JsonProperty("rating_system")]
    public cfaf4f412d216d73229b4c3e21bed1e85 RatingSystem { get; set; }
  }
}
