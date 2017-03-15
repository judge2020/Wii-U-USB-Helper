// Decompiled with JetBrains decompiler
// Type: A.c0c29f108584f137c614f55b15004c742
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  public class c0c29f108584f137c614f55b15004c742
  {
    [JsonProperty("aoc_available")]
    public bool AocAvailable { get; set; }

    [JsonProperty("banner_url")]
    public string BannerUrl { get; set; }

    [JsonProperty("copyright")]
    public c75deaf18e0ab7affef156d50093cdb0c Copyright { get; set; }

    [JsonProperty("custom_cover_url")]
    public string CustomCoverUrl { get; set; }

    [JsonProperty("data_size")]
    public long DataSize { get; set; }

    [JsonProperty("demo_available")]
    public bool DemoAvailable { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("display_genre")]
    public string DisplayGenre { get; set; }

    [JsonProperty("download_card_sales")]
    public c7fc7a68576d08dd60f2d49fd91572072 DownloadCardSales { get; set; }

    [JsonProperty("download_code_sales")]
    public bool DownloadCodeSales { get; set; }

    [JsonProperty("eshop_sales")]
    public bool EshopSales { get; set; }

    [JsonProperty("features")]
    public c25ef6bb53bed613b759e041249d95973 Features { get; set; }

    [JsonProperty("formal_name")]
    public string FormalName { get; set; }

    [JsonProperty("genres")]
    public c79ad8cf5bf4b6688ca47c535279b41e3 Genres { get; set; }

    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("in_app_purchase")]
    public bool InAppPurchase { get; set; }

    [JsonProperty("keywords")]
    public c9f129ae39e326db65314987d7364277a Keywords { get; set; }

    [JsonProperty("languages")]
    public cf6e6a7764b0b53b187f050e35f6ca912 Languages { get; set; }

    [JsonProperty("movies")]
    public ca9bdcc933fba327f28da88ba905bec9c Movies { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("new")]
    public bool New { get; set; }

    [JsonProperty("number_of_players")]
    public string NumberOfPlayers { get; set; }

    [JsonProperty("platform")]
    public c91db8c022e2a7015af390f068a6acc82 Platform { get; set; }

    [JsonProperty("play_styles")]
    public ca7c0585e1ec86da306c70dd1c1b3fc2a PlayStyles { get; set; }

    [JsonProperty("preference")]
    public c68345c1d2a3907630d8bb2b7c43dfe8a Preference { get; set; }

    [JsonProperty("product_code")]
    public string ProductCode { get; set; }

    [JsonProperty("public")]
    public bool Public { get; set; }

    [JsonProperty("publisher")]
    public cd2bf7f1d85258eb2d5095641b833c3de Publisher { get; set; }

    [JsonProperty("rating_info")]
    public cb520af621e92d2d0d069f641ebc2e5fe RatingInfo { get; set; }

    [JsonProperty("release_date_on_eshop")]
    public string ReleaseDateOnEshop { get; set; }

    [JsonProperty("release_date_on_retail")]
    public string ReleaseDateOnRetail { get; set; }

    [JsonProperty("retail_sales")]
    public bool RetailSales { get; set; }

    [JsonProperty("screenshots")]
    public cf0f8bc05a1f6f6e102d281b24fe6c9da Screenshots { get; set; }

    [JsonProperty("star_rating_info")]
    public c9156cbddd5e7ad30d02afcc5d90e556f StarRatingInfo { get; set; }

    [JsonProperty("ticket_available")]
    public bool TicketAvailable { get; set; }

    [JsonProperty("top_image")]
    public c94382f5eb163554a4b317b05f89fbc03 TopImage { get; set; }

    [JsonProperty("web_sales")]
    public bool WebSales { get; set; }

    [JsonProperty("web_sites")]
    public c9232640dab095d439cb8e76202d50d79 WebSites { get; set; }
  }
}
