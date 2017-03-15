// Decompiled with JetBrains decompiler
// Type: A.c9ec21ca508b9d24510492d903b79d70c
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace A
{
  public static class c9ec21ca508b9d24510492d903b79d70c
  {
    public static void c1ef43517fe46d1aae09999031095582d(this ZipArchive c304f0c59f8dabe63096431c21840354a, string c7b7b987852b7c9c33f0208b22027445b, bool c0fd5fd3ede2aba7e2a048bfdd8e4f936)
    {
      if (!c0fd5fd3ede2aba7e2a048bfdd8e4f936)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c9ec21ca508b9d24510492d903b79d70c.c1ef43517fe46d1aae09999031095582d);
            }
            c304f0c59f8dabe63096431c21840354a.ExtractToDirectory(c7b7b987852b7c9c33f0208b22027445b);
            break;
        }
      }
      else
      {
        IEnumerator<ZipArchiveEntry> enumerator = c304f0c59f8dabe63096431c21840354a.Entries.GetEnumerator();
        try
        {
          while (enumerator.MoveNext())
          {
            ZipArchiveEntry current = enumerator.Current;
            string str = Path.Combine(c7b7b987852b7c9c33f0208b22027445b, current.FullName);
            if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(current.Name, ""))
            {
label_8:
              switch (6)
              {
                case 0:
                  goto label_8;
                default:
                  Directory.CreateDirectory(Path.GetDirectoryName(str));
                  continue;
              }
            }
            else
              current.ExtractToFile(str, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(24) != 0);
          }
label_12:
          switch (2)
          {
            case 0:
              goto label_12;
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_15:
            switch (3)
            {
              case 0:
                goto label_15;
              default:
                enumerator.Dispose();
                break;
            }
          }
        }
      }
    }
  }
}
