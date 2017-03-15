// Decompiled with JetBrains decompiler
// Type: A.c91db8c022e2a7015af390f068a6acc82
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class c91db8c022e2a7015af390f068a6acc82
  {
    [JsonProperty("category")]
    public int Category { get; set; }

    [JsonProperty("device")]
    public string Device { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
  }
}
