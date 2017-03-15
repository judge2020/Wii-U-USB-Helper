// Decompiled with JetBrains decompiler
// Type: A.cfc23b4d5fc3d2e35bfc8c831516f74f0
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class cfc23b4d5fc3d2e35bfc8c831516f74f0
  {
    [JsonProperty("banner_url")]
    public string BannerUrl { get; set; }

    [JsonProperty("files")]
    public cc52536ea90ab73af54d1e8695431313d Files { get; set; }

    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("new")]
    public bool New { get; set; }

    [JsonProperty("rating_info")]
    public cd56a691cf8fb7f569c385e2b4a9e52d7 RatingInfo { get; set; }
  }
}
