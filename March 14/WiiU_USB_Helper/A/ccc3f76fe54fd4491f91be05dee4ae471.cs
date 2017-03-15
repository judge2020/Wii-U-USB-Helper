// Decompiled with JetBrains decompiler
// Type: A.ccc3f76fe54fd4491f91be05dee4ae471
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class ccc3f76fe54fd4491f91be05dee4ae471
  {
    [JsonProperty("icons")]
    public cee2d478c241f49568077f0b781df8ad5 Icons { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("required")]
    public bool Required { get; set; }

    [JsonProperty("type")]
    public int Type { get; set; }
  }
}
