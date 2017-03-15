// Decompiled with JetBrains decompiler
// Type: A.cdd32ada064099893bcca8d7064e9eb28
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace A
{
  public static class cdd32ada064099893bcca8d7064e9eb28
  {
    public static ulong c9436aadb49f0566ae96927a598183da4(this ulong cb65dfb0bc05cf5ef055e18ba40b6708a, uint c67a82c0dea80e7f9640d4375b5d53ab8)
    {
      if ((long) (cb65dfb0bc05cf5ef055e18ba40b6708a % (ulong) c67a82c0dea80e7f9640d4375b5d53ab8) != 0L)
        return (cb65dfb0bc05cf5ef055e18ba40b6708a / (ulong) c67a82c0dea80e7f9640d4375b5d53ab8 + (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(28)) * (ulong) c67a82c0dea80e7f9640d4375b5d53ab8;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cdd32ada064099893bcca8d7064e9eb28.c9436aadb49f0566ae96927a598183da4);
          }
          return cb65dfb0bc05cf5ef055e18ba40b6708a;
      }
    }

    public static byte[] c36cd4a2bacc924bf7516a05bcbaad8c3(this Stream c0cb2cc3c8ec2a27273c7cabb9024894b, int c5d5948a8274478b580d4ed74dfde289d)
    {
      byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(c5d5948a8274478b580d4ed74dfde289d);
      int offset = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(32);
      do
      {
        int num = c0cb2cc3c8ec2a27273c7cabb9024894b.Read(buffer, offset, c5d5948a8274478b580d4ed74dfde289d - offset);
        if (num != 0)
        {
label_2:
          switch (2)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cdd32ada064099893bcca8d7064e9eb28.c36cd4a2bacc924bf7516a05bcbaad8c3);
              }
              offset += num;
              continue;
          }
        }
        else
          goto label_7;
      }
      while (offset < c5d5948a8274478b580d4ed74dfde289d);
label_6:
      switch (4)
      {
        case 0:
          goto label_6;
      }
label_7:
      return buffer;
    }

    public static string c73eaa3c5bffa20f4ba9b23e1aecad741(this string c907075ebe7f1c4b189f6eae5161c381b)
    {
      return Regex.Replace(c907075ebe7f1c4b189f6eae5161c381b, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(244), "");
    }

    public static string cd8c423e132c5a4156f5bc7d54bf37e47(this string cb65dfb0bc05cf5ef055e18ba40b6708a, string[] c271ba7f7c31693e03900ad5bd1dc3e63, string caa1f18b9ade969f8a4076560a72c7d50)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<string>) c271ba7f7c31693e03900ad5bd1dc3e63).Aggregate<string, string>(cb65dfb0bc05cf5ef055e18ba40b6708a, new Func<string, string, string>(new cdd32ada064099893bcca8d7064e9eb28.c59e0c05431cce051960dfeb54f0f1ac4()
      {
        caa1f18b9ade969f8a4076560a72c7d50 = caa1f18b9ade969f8a4076560a72c7d50
      }.cbbae3a69ba4410ab5332f972fffcc58f));
    }

    public static string cd8c423e132c5a4156f5bc7d54bf37e47(this string cb65dfb0bc05cf5ef055e18ba40b6708a, char[] c271ba7f7c31693e03900ad5bd1dc3e63, char caa1f18b9ade969f8a4076560a72c7d50)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<char>) c271ba7f7c31693e03900ad5bd1dc3e63).Aggregate<char, string>(cb65dfb0bc05cf5ef055e18ba40b6708a, new Func<string, char, string>(new cdd32ada064099893bcca8d7064e9eb28.ca156d20d68ba067d0c03a74490168e93()
      {
        caa1f18b9ade969f8a4076560a72c7d50 = caa1f18b9ade969f8a4076560a72c7d50
      }.cbbae3a69ba4410ab5332f972fffcc58f));
    }

    public static string c3100bc3b9543cafe2203042a8514759a(this string cb65dfb0bc05cf5ef055e18ba40b6708a)
    {
      return cb65dfb0bc05cf5ef055e18ba40b6708a.Replace(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(259), (object) Environment.NewLine, (object) Environment.NewLine), string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(272), (object) Environment.NewLine));
    }
  }
}
