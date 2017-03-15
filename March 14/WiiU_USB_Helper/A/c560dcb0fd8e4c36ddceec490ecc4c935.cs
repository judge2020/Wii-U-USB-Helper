// Decompiled with JetBrains decompiler
// Type: A.c560dcb0fd8e4c36ddceec490ecc4c935
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A
{
  internal class c560dcb0fd8e4c36ddceec490ecc4c935 : cc6dede17deea63b67c3e0eb84bf12bb3
  {
    public c560dcb0fd8e4c36ddceec490ecc4c935(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
      : base(c36dd98eb0c08ea087627a40c6663c9a8, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6003), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6022))
    {
    }

    protected override string cbd49da1b139537c117237fef73cb00a6()
    {
      return Path.Combine(this.c04b4e6eaf974f76e23c9533b68fbee41, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5969));
    }

    protected override string cb85dafae1f67c1dc25305f1961a9680a()
    {
      string path = Path.Combine(this.cc231da0e30fca48cdd3646bf8f7d1a3d, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5788), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5996));
      if (!Directory.Exists(path))
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c560dcb0fd8e4c36ddceec490ecc4c935.cb85dafae1f67c1dc25305f1961a9680a);
            }
            return "";
        }
      }
      else
      {
        string[] files = Directory.GetFiles(path);
        if (!((IEnumerable<string>) files).Any<string>())
          return "";
label_6:
        switch (6)
        {
          case 0:
            goto label_6;
          default:
            return files[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7443)];
        }
      }
    }

    protected override void c066333ce3593d90c58c8de0f5232ec28()
    {
      base.c066333ce3593d90c58c8de0f5232ec28();
      this.ccf65faa6e27f93aff8feac8d628ba99a();
    }
  }
}
