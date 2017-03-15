// Decompiled with JetBrains decompiler
// Type: A.cebcb894f95824d04686ff6457fffe6f6
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace A
{
  internal static class cebcb894f95824d04686ff6457fffe6f6
  {
    public static void c511b6ca6e77b32ed7196fd2769163cb7(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, IPAddress cc993020431218dd1868140562b121eea, string cbc474cc35735e4b53e351da14c803500)
    {
      if (c36dd98eb0c08ea087627a40c6663c9a8.TitleId.IdType != (cfcd12ee63ba7d661f4ab310574290bf9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(0))
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cebcb894f95824d04686ff6457fffe6f6.c511b6ca6e77b32ed7196fd2769163cb7);
            }
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1));
        }
      }
      else if (c36dd98eb0c08ea087627a40c6663c9a8.System != (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(4))
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
          default:
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(64));
        }
      }
      else
      {
        c04094fd9c48096d147c0fc6cc8a97c26 c04094fd9c48096d147c0fc6cc8a97c26 = new c04094fd9c48096d147c0fc6cc8a97c26(cc993020431218dd1868140562b121eea.ToString(), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(159), "");
        string c6fbaa3632df796ac87418d1d25616c78_1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(178);
        if (!c04094fd9c48096d147c0fc6cc8a97c26.c34f0899e3d6a177675473e2188e353e9(c6fbaa3632df796ac87418d1d25616c78_1).Contains(c36dd98eb0c08ea087627a40c6663c9a8.TitleId.High.ToLower()))
        {
label_9:
          switch (1)
          {
            case 0:
              goto label_9;
            default:
              throw new c9d98206b36522903c9380884ee3ed7a2();
          }
        }
        else
        {
          string c6fbaa3632df796ac87418d1d25616c78_2 = c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(178), c36dd98eb0c08ea087627a40c6663c9a8.TitleId.High.ToLower(), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241));
          string c87c3d2a609d07eb52c0fd1f9c3239541 = cbc474cc35735e4b53e351da14c803500;
          c04094fd9c48096d147c0fc6cc8a97c26.c8b39d3db1677ce855c3723d93d97bed5(c6fbaa3632df796ac87418d1d25616c78_2, c87c3d2a609d07eb52c0fd1f9c3239541);
        }
      }
    }

    public static void c8fb9e99bf156aede0447a0cb9aa01934(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, IPAddress cc993020431218dd1868140562b121eea, string cbc474cc35735e4b53e351da14c803500)
    {
      if (c36dd98eb0c08ea087627a40c6663c9a8.TitleId.IdType != (cfcd12ee63ba7d661f4ab310574290bf9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cebcb894f95824d04686ff6457fffe6f6.c8fb9e99bf156aede0447a0cb9aa01934);
            }
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1));
        }
      }
      else if (c36dd98eb0c08ea087627a40c6663c9a8.System != (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12))
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(64));
        }
      }
      else
      {
        c04094fd9c48096d147c0fc6cc8a97c26 c04094fd9c48096d147c0fc6cc8a97c26 = new c04094fd9c48096d147c0fc6cc8a97c26(cc993020431218dd1868140562b121eea.ToString(), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(159), "");
        FileStream fileStream = System.IO.File.Open(cbc474cc35735e4b53e351da14c803500, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16));
        try
        {
          ZipArchive c304f0c59f8dabe63096431c21840354a = new ZipArchive((Stream) fileStream, (ZipArchiveMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20));
          try
          {
            c04094fd9c48096d147c0fc6cc8a97c26.c095cd7bbf623afbcb447f02cc3fccf44(c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(178), c36dd98eb0c08ea087627a40c6663c9a8.TitleId.High.ToLower(), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241)), c304f0c59f8dabe63096431c21840354a);
          }
          finally
          {
            if (c304f0c59f8dabe63096431c21840354a != null)
            {
label_12:
              switch (7)
              {
                case 0:
                  goto label_12;
                default:
                  c304f0c59f8dabe63096431c21840354a.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (fileStream != null)
          {
label_16:
            switch (6)
            {
              case 0:
                goto label_16;
              default:
                fileStream.Dispose();
                break;
            }
          }
        }
      }
    }
  }
}
