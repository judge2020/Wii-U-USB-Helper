// Decompiled with JetBrains decompiler
// Type: A.c68345c1d2a3907630d8bb2b7c43dfe8a
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class c68345c1d2a3907630d8bb2b7c43dfe8a
  {
    [JsonProperty("play_style")]
    public c416a1238acc81f778b3a91e68f62e6cc PlayStyle { get; set; }

    [JsonProperty("target_player")]
    public c5c01416ebf8abb000284fb663db097e9 TargetPlayer { get; set; }
  }
}
