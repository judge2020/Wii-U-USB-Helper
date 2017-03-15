// Decompiled with JetBrains decompiler
// Type: A.caaa166a921d0019973aa328703a03e82
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace A
{
  public struct caaa166a921d0019973aa328703a03e82
  {
    public readonly List<int> c1d53f99644fff009a5829ee8ab7fc8ab;
    public readonly bool c278dde83450f5d3032448e81071ec8ef;
    public readonly bool c1a602168ddb487942517e64ddbf4a167;
    private readonly ccc0082396339666e15f34a6614404a47 c0bcd71dd099a4fcfee4551b3d12e48c9;

    public bool c0e379d486d73ea79071e2291e7d54f2b
    {
      get
      {
        if (!this.c278dde83450f5d3032448e81071ec8ef)
        {
label_1:
          switch (5)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (caaa166a921d0019973aa328703a03e82.get_c0e379d486d73ea79071e2291e7d54f2b);
              }
              if (!this.c1a602168ddb487942517e64ddbf4a167)
              {
label_5:
                switch (4)
                {
                  case 0:
                    goto label_5;
                  default:
                    return (this.c1d53f99644fff009a5829ee8ab7fc8ab.Any<int>() ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2304);
                }
              }
              else
                break;
          }
        }
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2308) != 0;
      }
    }

    public caaa166a921d0019973aa328703a03e82(ccc0082396339666e15f34a6614404a47 cc0048e297270ca267c121e581b301b2b, List<int> c3020c3c4c17965a898c5a3dfb4f8e829, bool c162f06884c960d2f219f2025350cc258, bool c80ffb3be91bd54887b2f3dd0f41d1657)
    {
      this.c0bcd71dd099a4fcfee4551b3d12e48c9 = cc0048e297270ca267c121e581b301b2b;
      this.c1d53f99644fff009a5829ee8ab7fc8ab = c3020c3c4c17965a898c5a3dfb4f8e829;
      this.c1a602168ddb487942517e64ddbf4a167 = c162f06884c960d2f219f2025350cc258;
      this.c278dde83450f5d3032448e81071ec8ef = c80ffb3be91bd54887b2f3dd0f41d1657;
    }

    public override string ToString()
    {
      return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5391), (object) this.c0bcd71dd099a4fcfee4551b3d12e48c9.ContentId, (object) this.c1d53f99644fff009a5829ee8ab7fc8ab.Count);
    }
  }
}
