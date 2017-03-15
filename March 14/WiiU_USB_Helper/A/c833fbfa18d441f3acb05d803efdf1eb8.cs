// Decompiled with JetBrains decompiler
// Type: A.c833fbfa18d441f3acb05d803efdf1eb8
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Reflection;
using System.Text;

namespace A
{
  internal class c833fbfa18d441f3acb05d803efdf1eb8
  {
    internal static readonly byte[] c01781c79efcf91c12ac73fb560856eda;

    static c833fbfa18d441f3acb05d803efdf1eb8()
    {
      if (c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda != null)
        return;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c833fbfa18d441f3acb05d803efdf1eb8.\u002Ecctor);
          }
          byte[] bytes = Convert.FromBase64String("V2lpVV9VU0JfSGVscGVyJA==");
          c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda = c9654c418e330d33bb3f6a61645043740.cd1cc5106b3801905def21c597971969e(97L, Assembly.GetExecutingAssembly().GetManifestResourceStream(Encoding.UTF8.GetString(bytes, 0, bytes.Length)));
          break;
      }
    }

    internal static string c702a9e4555297107d7c7901aa91e5540(int cecb96267e559a56c4f543488b117e4fc)
    {
      int count;
      if (((int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & 128) == 0)
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540);
            }
            count = (int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc];
            ++cecb96267e559a56c4f543488b117e4fc;
            break;
        }
      }
      else if (((int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & 64) == 0)
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
          default:
            count = ((int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & -129) << 8 | (int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 1];
            cecb96267e559a56c4f543488b117e4fc += 2;
            break;
        }
      }
      else
      {
        count = ((int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & -193) << 24 | (int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 1] << 16 | (int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 2] << 8 | (int) c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 3];
        cecb96267e559a56c4f543488b117e4fc += 4;
      }
      if (count >= 1)
        return string.Intern(Encoding.Unicode.GetString(c833fbfa18d441f3acb05d803efdf1eb8.c01781c79efcf91c12ac73fb560856eda, cecb96267e559a56c4f543488b117e4fc, count));
label_10:
      switch (2)
      {
        case 0:
          goto label_10;
        default:
          return string.Empty;
      }
    }
  }
}
