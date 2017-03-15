// Decompiled with JetBrains decompiler
// Type: A.c9b4e1fcff1aee20085c67df2c0a7bbbe
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class c9b4e1fcff1aee20085c67df2c0a7bbbe
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
