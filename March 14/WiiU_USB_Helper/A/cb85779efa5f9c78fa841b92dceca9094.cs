// Decompiled with JetBrains decompiler
// Type: A.cb85779efa5f9c78fa841b92dceca9094
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Reflection;
using System.Text;

namespace A
{
  internal class cb85779efa5f9c78fa841b92dceca9094
  {
    internal static readonly byte[] c01781c79efcf91c12ac73fb560856eda;
    internal readonly int c94d7d3929ab24e50a1d9c5279e0ca34c;

    static cb85779efa5f9c78fa841b92dceca9094()
    {
      if (cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda != null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cb85779efa5f9c78fa841b92dceca9094.\u002Ecctor);
          }
          byte[] bytes = Convert.FromBase64String("V2lpVV9VU0JfSGVscGVyJQ==");
          cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda = c9654c418e330d33bb3f6a61645043740.cd1cc5106b3801905def21c597971969e(97L, Assembly.GetExecutingAssembly().GetManifestResourceStream(Encoding.UTF8.GetString(bytes, 0, bytes.Length)));
          break;
      }
    }

    internal static int c4f3ad310245f8f6e7d32122c50c48ab1(int cecb96267e559a56c4f543488b117e4fc)
    {
      return BitConverter.ToInt32(cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda, cecb96267e559a56c4f543488b117e4fc);
    }

    internal static long cb412cf3dc05e57942e780487cc05dc6b(int cecb96267e559a56c4f543488b117e4fc)
    {
      return BitConverter.ToInt64(cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda, cecb96267e559a56c4f543488b117e4fc);
    }

    internal static float c8c83a3807da60b9f032d40f2b5665e27(int cecb96267e559a56c4f543488b117e4fc)
    {
      return BitConverter.ToSingle(cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda, cecb96267e559a56c4f543488b117e4fc);
    }

    internal static double cc355471519aa13f05c72ce1708ca5624(int cecb96267e559a56c4f543488b117e4fc)
    {
      return BitConverter.ToDouble(cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda, cecb96267e559a56c4f543488b117e4fc);
    }

    internal static void c4139b678b1d9d2901dd7edcf69793526(Array cb3a6a37cb8a58347d8f60b4581ab632f, int cecb96267e559a56c4f543488b117e4fc)
    {
      int count;
      if (((int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & 128) == 0)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526);
            }
            count = (int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc];
            ++cecb96267e559a56c4f543488b117e4fc;
            break;
        }
      }
      else if (((int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & 64) == 0)
      {
label_6:
        switch (1)
        {
          case 0:
            goto label_6;
          default:
            count = ((int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & -129) << 8 | (int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 1];
            cecb96267e559a56c4f543488b117e4fc += 2;
            break;
        }
      }
      else
      {
        count = ((int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc] & -193) << 24 | (int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 1] << 16 | (int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 2] << 8 | (int) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda[cecb96267e559a56c4f543488b117e4fc + 3];
        cecb96267e559a56c4f543488b117e4fc += 4;
      }
      if (count < 1)
      {
label_10:
        switch (5)
        {
          case 0:
            goto label_10;
        }
      }
      else
        Buffer.BlockCopy((Array) cb85779efa5f9c78fa841b92dceca9094.c01781c79efcf91c12ac73fb560856eda, cecb96267e559a56c4f543488b117e4fc, cb3a6a37cb8a58347d8f60b4581ab632f, 0, count);
    }
  }
}
