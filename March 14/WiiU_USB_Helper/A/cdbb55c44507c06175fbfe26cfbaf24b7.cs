// Decompiled with JetBrains decompiler
// Type: A.cdbb55c44507c06175fbfe26cfbaf24b7
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls.UI;

namespace A
{
  public static class cdbb55c44507c06175fbfe26cfbaf24b7
  {
    public static bool c1de2c5d31ef8b332ef39d04f3d8a5a6c(this RadListView cc6435b78a93f22a72c53f47773ba2802, cba6aa8f767d2e8dfbca2d43d7148c173 c89cbac13be511053120093fce8049319)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<ListViewDataItem>) cc6435b78a93f22a72c53f47773ba2802.get_Items()).Any<ListViewDataItem>(new Func<ListViewDataItem, bool>(new cdbb55c44507c06175fbfe26cfbaf24b7.c5f5283cb11e791fd6e487302e3f29105()
      {
        c89cbac13be511053120093fce8049319 = c89cbac13be511053120093fce8049319
      }.c1cbde9497c6754721d3d4a4bb3005fb1));
    }
  }
}
