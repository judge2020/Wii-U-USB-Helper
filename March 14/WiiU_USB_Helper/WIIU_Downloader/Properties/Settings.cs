// Decompiled with JetBrains decompiler
// Type: WIIU_Downloader.Properties.Settings
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using A;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WIIU_Downloader.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = ca8a2f58d866cea146e6d61278e0aa5ff.cc8e287d5350b43026d33bb80beb131a0((object) SettingsBase.Synchronized((SettingsBase) new Settings()));

    public static Settings Default
    {
      get
      {
        return Settings.defaultInstance;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("NONE")]
    public string Region
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9029)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9029)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    public bool Cleanup
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9042)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9042)] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string Path
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9057)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9057)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    [UserScopedSetting]
    public string TicketsPath
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9066)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9066)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("DarkBlue")]
    [UserScopedSetting]
    public string ThemeName
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9089)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9089)] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool CompactView
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9108)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9108)] = (object) value;
      }
    }

    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool ShowLegit
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9131)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9131)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    public bool ShowCFW
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9150)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9150)] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool ShowEvents
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9165)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9165)] = (object) value;
      }
    }

    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public long LastNewsDate
    {
      get
      {
        return c33c634c50cc6464a23a4f62c1101bd70.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9186)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9186)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string TicketsPath3DS
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9211)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9211)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    public bool EUR
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("False")]
    public bool JPN
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9240)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9240)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool USA
    {
      get
      {
        return cdf0edc906c30d35f54fbfa71f6a32a71.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string CemuExecutable
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9247)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9247)] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string ExtractFolder
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9276)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9276)] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string DonationKey
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9303)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9303)] = (object) value;
      }
    }

    [DefaultSettingValue("0")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public int LaunchCount
    {
      get
      {
        return ce02e38bcdaaa630ded0aa7945bfafc0f.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9326)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9326)] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string Platforms
    {
      get
      {
        return c736644a47cdd7c5feff9eb2950d5aad4.cc8e287d5350b43026d33bb80beb131a0(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9349)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9349)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("0, 0, 0, 0")]
    [DebuggerNonUserCode]
    public Rectangle WindowPosition
    {
      get
      {
        return cfc83a21d627a0c057ad642f88a7c9c2b.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9368)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9368)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("Normal")]
    [DebuggerNonUserCode]
    public FormWindowState WindowState
    {
      get
      {
        return c76e02490e53a6a5c9c5eb656b9ae843e.c266cc793747f741ea3de85f7a5f5e6a8(this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9397)]);
      }
      set
      {
        this[c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9397)] = (object) value;
      }
    }
  }
}
