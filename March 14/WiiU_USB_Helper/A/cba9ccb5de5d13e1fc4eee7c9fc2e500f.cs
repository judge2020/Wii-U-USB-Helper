// Decompiled with JetBrains decompiler
// Type: A.cba9ccb5de5d13e1fc4eee7c9fc2e500f
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class cba9ccb5de5d13e1fc4eee7c9fc2e500f
  {
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
