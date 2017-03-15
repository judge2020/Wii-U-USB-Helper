// Decompiled with JetBrains decompiler
// Type: Updater.Properties.Resources
// Assembly: Updater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7FC3B5C5-5FF7-42B2-B7F0-8C213AAF0FEC
// Assembly location: C:\Users\hunte\Documents\DECompiles\Updater.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Updater.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Updater.Properties.Resources.resourceMan == null)
          Updater.Properties.Resources.resourceMan = new ResourceManager("Updater.Properties.Resources", typeof (Updater.Properties.Resources).Assembly);
        return Updater.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Updater.Properties.Resources.resourceCulture;
      }
      set
      {
        Updater.Properties.Resources.resourceCulture = value;
      }
    }

    internal static Bitmap Back
    {
      get
      {
        return (Bitmap) Updater.Properties.Resources.ResourceManager.GetObject("Back", Updater.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap squares
    {
      get
      {
        return (Bitmap) Updater.Properties.Resources.ResourceManager.GetObject("squares", Updater.Properties.Resources.resourceCulture);
      }
    }

    internal Resources()
    {
    }
  }
}
