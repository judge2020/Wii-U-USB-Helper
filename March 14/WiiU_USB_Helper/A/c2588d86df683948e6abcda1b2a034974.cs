// Decompiled with JetBrains decompiler
// Type: A.c2588d86df683948e6abcda1b2a034974
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace A
{
  internal static class c2588d86df683948e6abcda1b2a034974
  {
    private static readonly byte[][] c239b6eff7d01f6b4925592323fae65a3 = c74e4db5e3993d3704c71dcceb87429cb.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2868));
    internal const int c6df28230b00b25bc7b1dcc255f575ae5 = 65536;
    private const int c2b9d9dac36166d776e8063b1c9110aa5 = 64512;
    private const int c3a0fedeedf162afc833116eaccaba84f = 1024;
    private const int c626ff4a38800681ef59e2492c748ba01 = 256;
    private const int cb907c61ba3097a5bef673617f5461342 = 3;

    public static c7a45ac90c7f59eb3c9c267df34f789f4 c27d633604e642e25b89209d64298ce21(byte[] c4d66af9ff72d1a843bbfaba344ad375d, byte[] c0b4208fa44d57e11308b8816c2d771ca, int c030b1c8f29f62c1298386dd17a13eb3c, byte[] cca76947157f6ec86b4babf9451d03287, byte cc4a314a023c5328994ee2c9a3b74ca41)
    {
      byte[] numArray1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2312));
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2316);
      int num = (int) cc4a314a023c5328994ee2c9a3b74ca41;
      numArray1[index] = (byte) num;
      byte[] c6b78934ae77e0d5ca49f4525627346f9 = numArray1;
      SHA1 shA1 = SHA1.Create();
      byte[] cc0048e297270ca267c121e581b301b2b1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2320));
      Buffer.BlockCopy((Array) c4d66af9ff72d1a843bbfaba344ad375d, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2324), (Array) cc0048e297270ca267c121e581b301b2b1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2328), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2332));
      byte[] numArray2 = c2588d86df683948e6abcda1b2a034974.c14516839f75b82a18f7bfb61ce12d397(cc0048e297270ca267c121e581b301b2b1, cca76947157f6ec86b4babf9451d03287, c6b78934ae77e0d5ca49f4525627346f9);
      numArray2[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2336)] ^= cc4a314a023c5328994ee2c9a3b74ca41;
      int srcOffset1 = c030b1c8f29f62c1298386dd17a13eb3c % cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2340) * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2344);
      int srcOffset2 = (cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2348) + c030b1c8f29f62c1298386dd17a13eb3c / cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2352) % cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2356)) * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2360);
      int srcOffset3 = (cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2364) + c030b1c8f29f62c1298386dd17a13eb3c / cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2368) % cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2372)) * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2376);
      int srcOffset4 = c030b1c8f29f62c1298386dd17a13eb3c / cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2380) % cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2384) * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2388);
      byte[] ccf028ef488ad163ff8a1fdd07540a235_1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2392));
      byte[] c38c40125530d67d2b30bfa5afa385b41_1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2396));
      byte[] ccf028ef488ad163ff8a1fdd07540a235_2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2400));
      byte[] c38c40125530d67d2b30bfa5afa385b41_2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2404));
      Buffer.BlockCopy((Array) numArray2, srcOffset1, (Array) ccf028ef488ad163ff8a1fdd07540a235_1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2408), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2412));
      Buffer.BlockCopy((Array) numArray2, srcOffset1, (Array) c6b78934ae77e0d5ca49f4525627346f9, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2416), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2420));
      byte[] cc0048e297270ca267c121e581b301b2b2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2424));
      Buffer.BlockCopy((Array) c4d66af9ff72d1a843bbfaba344ad375d, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2428), (Array) cc0048e297270ca267c121e581b301b2b2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2432), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2436));
      byte[] buffer1 = c2588d86df683948e6abcda1b2a034974.c14516839f75b82a18f7bfb61ce12d397(cc0048e297270ca267c121e581b301b2b2, cca76947157f6ec86b4babf9451d03287, c6b78934ae77e0d5ca49f4525627346f9);
      byte[] hash1 = shA1.ComputeHash(buffer1);
      if (!ccbda8e2370d034604647d744ba7d67ed.c9da387a0620d0fb76794f0636febd9bd(ccf028ef488ad163ff8a1fdd07540a235_1, hash1))
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c27d633604e642e25b89209d64298ce21);
            }
            return (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2440);
        }
      }
      else
      {
        if (c030b1c8f29f62c1298386dd17a13eb3c % cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2444) == 0)
        {
label_6:
          switch (2)
          {
            case 0:
              goto label_6;
            default:
              byte[] buffer2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2448));
              Buffer.BlockCopy((Array) numArray2, srcOffset1, (Array) buffer2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2452), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2456));
              Buffer.BlockCopy((Array) numArray2, srcOffset2, (Array) c38c40125530d67d2b30bfa5afa385b41_1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2460), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2464));
              if (!ccbda8e2370d034604647d744ba7d67ed.c9da387a0620d0fb76794f0636febd9bd(shA1.ComputeHash(buffer2), c38c40125530d67d2b30bfa5afa385b41_1))
              {
label_8:
                switch (5)
                {
                  case 0:
                    goto label_8;
                  default:
                    return (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2468);
                }
              }
              else
                break;
          }
        }
        if (c030b1c8f29f62c1298386dd17a13eb3c % cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2472) == 0)
        {
label_11:
          switch (1)
          {
            case 0:
              goto label_11;
            default:
              byte[] buffer2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2476));
              Buffer.BlockCopy((Array) numArray2, srcOffset2, (Array) buffer2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2480), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2484));
              Buffer.BlockCopy((Array) numArray2, srcOffset3, (Array) ccf028ef488ad163ff8a1fdd07540a235_2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2488), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2492));
              byte[] hash2 = shA1.ComputeHash(buffer2);
              if (!ccbda8e2370d034604647d744ba7d67ed.c9da387a0620d0fb76794f0636febd9bd(ccf028ef488ad163ff8a1fdd07540a235_2, hash2))
              {
label_13:
                switch (1)
                {
                  case 0:
                    goto label_13;
                  default:
                    return (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2496);
                }
              }
              else
                break;
          }
        }
        if (c030b1c8f29f62c1298386dd17a13eb3c % cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2500) != 0)
        {
label_16:
          switch (3)
          {
            case 0:
              goto label_16;
            default:
              return (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2504);
          }
        }
        else
        {
          byte[] buffer2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2508));
          Buffer.BlockCopy((Array) numArray2, srcOffset3, (Array) buffer2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2512), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2516));
          Buffer.BlockCopy((Array) c0b4208fa44d57e11308b8816c2d771ca, srcOffset4, (Array) c38c40125530d67d2b30bfa5afa385b41_2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2520), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2524));
          if (ccbda8e2370d034604647d744ba7d67ed.c9da387a0620d0fb76794f0636febd9bd(shA1.ComputeHash(buffer2), c38c40125530d67d2b30bfa5afa385b41_2))
            return (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2532);
label_19:
          switch (2)
          {
            case 0:
              goto label_19;
            default:
              return (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2528);
          }
        }
      }
    }

    public static List<caaa166a921d0019973aa328703a03e82> cbb3ace1592255ee999c58d40ead84915(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c2588d86df683948e6abcda1b2a034974.cd34f8d6ce56492d5511e1f6372063361 cd34f8d6ce56492d5511e1f6372063361_1 = new c2588d86df683948e6abcda1b2a034974.cd34f8d6ce56492d5511e1f6372063361();
      // ISSUE: reference to a compiler-generated field
      cd34f8d6ce56492d5511e1f6372063361_1.c36dd98eb0c08ea087627a40c6663c9a8 = c36dd98eb0c08ea087627a40c6663c9a8;
      // ISSUE: reference to a compiler-generated field
      string str1 = Path.Combine(cd34f8d6ce56492d5511e1f6372063361_1.c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2456));
      // ISSUE: reference to a compiler-generated field
      string str2 = Path.Combine(cd34f8d6ce56492d5511e1f6372063361_1.c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2475));
      if (File.Exists(str1))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.cbb3ace1592255ee999c58d40ead84915);
            }
            // ISSUE: reference to a compiler-generated field
            if (cd34f8d6ce56492d5511e1f6372063361_1.c36dd98eb0c08ea087627a40c6663c9a8.Ticket == null)
            {
label_5:
              switch (5)
              {
                case 0:
                  goto label_5;
                default:
                  if (!File.Exists(str2))
                  {
label_7:
                    switch (3)
                    {
                      case 0:
                        goto label_7;
                      default:
                        goto label_8;
                    }
                  }
                  else
                    break;
              }
            }
            if (!File.Exists(str1))
            {
label_10:
              switch (1)
              {
                case 0:
                  goto label_10;
                default:
                  caaa166a921d0019973aa328703a03e82[] caaa166a921d0019973aa328703a03e82Array = ccc8f15722e4774192057c57cfb989ca5.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2552));
                  int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2556);
                  caaa166a921d0019973aa328703a03e82 caaa166a921d0019973aa328703a03e82 = new caaa166a921d0019973aa328703a03e82((ccc0082396339666e15f34a6614404a47) null, new List<int>(), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2560) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2564) != 0);
                  caaa166a921d0019973aa328703a03e82Array[index] = caaa166a921d0019973aa328703a03e82;
                  return ((IEnumerable<caaa166a921d0019973aa328703a03e82>) caaa166a921d0019973aa328703a03e82Array).ToList<caaa166a921d0019973aa328703a03e82>();
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              cff72ea250ac36ea03abde33ff61b7565 cff72ea250ac36ea03abde33ff61b7565 = cff72ea250ac36ea03abde33ff61b7565.cb5009c1058eaad54842d9bead8e530a2(str1, cd34f8d6ce56492d5511e1f6372063361_1.c36dd98eb0c08ea087627a40c6663c9a8.System);
              // ISSUE: variable of a compiler-generated type
              c2588d86df683948e6abcda1b2a034974.cd34f8d6ce56492d5511e1f6372063361 cd34f8d6ce56492d5511e1f6372063361_2 = cd34f8d6ce56492d5511e1f6372063361_1;
              // ISSUE: reference to a compiler-generated field
              c1d5d0d4f9464e1d296ba85cf189ecad6 c1d5d0d4f9464e1d296ba85cf189ecad6 = cd34f8d6ce56492d5511e1f6372063361_1.c36dd98eb0c08ea087627a40c6663c9a8.Ticket;
              if (c1d5d0d4f9464e1d296ba85cf189ecad6 == null)
              {
label_13:
                switch (3)
                {
                  case 0:
                    goto label_13;
                  default:
                    // ISSUE: reference to a compiler-generated field
                    c1d5d0d4f9464e1d296ba85cf189ecad6 = c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(str2, cd34f8d6ce56492d5511e1f6372063361_1.c36dd98eb0c08ea087627a40c6663c9a8.System);
                    break;
                }
              }
              // ISSUE: reference to a compiler-generated field
              cd34f8d6ce56492d5511e1f6372063361_2.cf4bda5ff792273657c9c9f651b67192e = c1d5d0d4f9464e1d296ba85cf189ecad6;
              // ISSUE: reference to a compiler-generated method
              return ((IEnumerable<ccc0082396339666e15f34a6614404a47>) cff72ea250ac36ea03abde33ff61b7565.c7294cb7c91944988432faebdd13ef3a8).Select<ccc0082396339666e15f34a6614404a47, caaa166a921d0019973aa328703a03e82>(new Func<ccc0082396339666e15f34a6614404a47, caaa166a921d0019973aa328703a03e82>(cd34f8d6ce56492d5511e1f6372063361_1.cda97b5e2e1ed58a9d460c9c0161c5716)).ToList<caaa166a921d0019973aa328703a03e82>();
            }
        }
      }
label_8:
      caaa166a921d0019973aa328703a03e82[] caaa166a921d0019973aa328703a03e82Array1 = ccc8f15722e4774192057c57cfb989ca5.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2536));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2540);
      caaa166a921d0019973aa328703a03e82 caaa166a921d0019973aa328703a03e82_1 = new caaa166a921d0019973aa328703a03e82((ccc0082396339666e15f34a6614404a47) null, new List<int>(), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2544) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2548) != 0);
      caaa166a921d0019973aa328703a03e82Array1[index1] = caaa166a921d0019973aa328703a03e82_1;
      return ((IEnumerable<caaa166a921d0019973aa328703a03e82>) caaa166a921d0019973aa328703a03e82Array1).ToList<caaa166a921d0019973aa328703a03e82>();
    }

    public static void c03bff1a5038e7a38c54d74793ba546a1(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      if (c36dd98eb0c08ea087627a40c6663c9a8.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2568))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c03bff1a5038e7a38c54d74793ba546a1);
            }
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5452));
        }
      }
      else
      {
        ccc0082396339666e15f34a6614404a47[] c7294cb7c91944988432faebdd13ef3a8 = cff72ea250ac36ea03abde33ff61b7565.cb5009c1058eaad54842d9bead8e530a2(File.ReadAllBytes(Path.Combine(c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2456))), (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2572)).c7294cb7c91944988432faebdd13ef3a8;
        int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2576);
        while (index < (int) c2a0c2ae96e14c3951c8dd08f53fe4024.c572aba370be49804cbdb0b35312bea94(c7294cb7c91944988432faebdd13ef3a8))
        {
          ccc0082396339666e15f34a6614404a47 ccc0082396339666e15f34a6614404a47 = c7294cb7c91944988432faebdd13ef3a8[index];
          string str = Path.Combine(c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(ccc0082396339666e15f34a6614404a47.ContentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)));
          string c33ad1bd311fd4b32b85377e9e15a9d93 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5525);
          string cbd5721758c154f07ec12342ad5bd9770 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c33ad1bd311fd4b32b85377e9e15a9d93);
          byte[] c9536899c8db7d9fc10b867798a27bf8c = c36dd98eb0c08ea087627a40c6663c9a8.c9536899c8db7d9fc10b867798a27bf8c;
          byte[] c6b78934ae77e0d5ca49f4525627346f9 = c2588d86df683948e6abcda1b2a034974.ce6fc7d00c6cb9c106441e8a21d20c41e(ccc0082396339666e15f34a6614404a47.Index);
          c2588d86df683948e6abcda1b2a034974.c50491654f74af91fee5f3cfeeae6578d(str, cbd5721758c154f07ec12342ad5bd9770, c9536899c8db7d9fc10b867798a27bf8c, c6b78934ae77e0d5ca49f4525627346f9);
          index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2580);
        }
label_8:
        switch (1)
        {
          case 0:
            goto label_8;
        }
      }
    }

    private static byte[] c857c62b75ac43a015244e43ae89c5b34(string c5efeaa77d5f77f11209a6f9c11f51988, byte[] c4d45c6e468d9560ee4f9dd32ffb3d8b8, byte[] c6b78934ae77e0d5ca49f4525627346f9)
    {
      SHA256 shA256 = SHA256.Create();
      AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider();
      try
      {
        cryptoServiceProvider.Key = c4d45c6e468d9560ee4f9dd32ffb3d8b8;
        cryptoServiceProvider.IV = c6b78934ae77e0d5ca49f4525627346f9;
        cryptoServiceProvider.Padding = (PaddingMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2584);
        FileStream fileStream = File.Open(c5efeaa77d5f77f11209a6f9c11f51988, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2588));
        try
        {
          CryptoStream cryptoStream = new CryptoStream((Stream) fileStream, cryptoServiceProvider.CreateDecryptor(), (CryptoStreamMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2592));
          try
          {
            return shA256.ComputeHash((Stream) cryptoStream);
          }
          finally
          {
            if (cryptoStream != null)
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  if (1 == 0)
                  {
                    // ISSUE: method reference
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c857c62b75ac43a015244e43ae89c5b34);
                  }
                  cryptoStream.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (fileStream != null)
          {
label_11:
            switch (4)
            {
              case 0:
                goto label_11;
              default:
                fileStream.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (cryptoServiceProvider != null)
        {
label_15:
          switch (5)
          {
            case 0:
              goto label_15;
            default:
              cryptoServiceProvider.Dispose();
              break;
          }
        }
      }
    }

    public static caaa166a921d0019973aa328703a03e82 c9e4c8c42ea50a26d6276799eb717fc27(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, ccc0082396339666e15f34a6614404a47 ca0d69c1f5075ba97fb3e0bfe64a9d6f6, byte[] c57e74a2744636b8048786c468c19be38)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c2588d86df683948e6abcda1b2a034974.c96ea0f005869aeebb7feaffca9d2073f c96ea0f005869aeebb7feaffca9d2073f = new c2588d86df683948e6abcda1b2a034974.c96ea0f005869aeebb7feaffca9d2073f();
      // ISSUE: reference to a compiler-generated field
      c96ea0f005869aeebb7feaffca9d2073f.c57e74a2744636b8048786c468c19be38 = c57e74a2744636b8048786c468c19be38;
      // ISSUE: reference to a compiler-generated field
      c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6 = ca0d69c1f5075ba97fb3e0bfe64a9d6f6;
      List<int> c3020c3c4c17965a898c5a3dfb4f8e829 = new List<int>();
      // ISSUE: reference to a compiler-generated field
      string path1 = Path.Combine(c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6.ContentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)));
      // ISSUE: reference to a compiler-generated field
      string path2 = Path.Combine(c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6.ContentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761)));
      // ISSUE: reference to a compiler-generated field
      if (!c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6.ce7bc51cbabe7bd4fb4dac2e71e260e4f)
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c9e4c8c42ea50a26d6276799eb717fc27);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (c2588d86df683948e6abcda1b2a034974.c598d44fa5616d2ce79c0b9fcdd528ef3(c36dd98eb0c08ea087627a40c6663c9a8, c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6, c96ea0f005869aeebb7feaffca9d2073f.c57e74a2744636b8048786c468c19be38))
            {
              // ISSUE: reference to a compiler-generated field
              return new caaa166a921d0019973aa328703a03e82(c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6, new List<int>(), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2604) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2608) != 0);
            }
label_5:
            switch (7)
            {
              case 0:
                goto label_5;
              default:
                // ISSUE: reference to a compiler-generated field
                return new caaa166a921d0019973aa328703a03e82(c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6, new List<int>(), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2596) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2600) != 0);
            }
        }
      }
      else if (!File.Exists(path2))
      {
label_9:
        switch (2)
        {
          case 0:
            goto label_9;
          default:
            // ISSUE: reference to a compiler-generated field
            return new caaa166a921d0019973aa328703a03e82(c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6, c3020c3c4c17965a898c5a3dfb4f8e829, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2612) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2616) != 0);
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        c96ea0f005869aeebb7feaffca9d2073f.c0b4208fa44d57e11308b8816c2d771ca = File.ReadAllBytes(path2);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (!ccbda8e2370d034604647d744ba7d67ed.c9da387a0620d0fb76794f0636febd9bd(SHA1.Create().ComputeHash(c96ea0f005869aeebb7feaffca9d2073f.c0b4208fa44d57e11308b8816c2d771ca), c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6.Hash))
        {
label_12:
          switch (4)
          {
            case 0:
              goto label_12;
            default:
              // ISSUE: reference to a compiler-generated field
              return new caaa166a921d0019973aa328703a03e82(c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6, c3020c3c4c17965a898c5a3dfb4f8e829, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2620) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2624) != 0);
          }
        }
        else
        {
          FileStream fileStream = File.OpenRead(path1);
          try
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            c2588d86df683948e6abcda1b2a034974.c106acc4c3410a4edbc7df411de20797f c106acc4c3410a4edbc7df411de20797f = new c2588d86df683948e6abcda1b2a034974.c106acc4c3410a4edbc7df411de20797f();
            // ISSUE: reference to a compiler-generated field
            c106acc4c3410a4edbc7df411de20797f.c10051687c186d4463c40ec142db943cf = c96ea0f005869aeebb7feaffca9d2073f;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            int cb6783c1e06b5b5ba172fbe70f583493d = (int) (c106acc4c3410a4edbc7df411de20797f.c10051687c186d4463c40ec142db943cf.ca0d69c1f5075ba97fb3e0bfe64a9d6f6.Size.TotalBytes / (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2628));
            int num1 = (int) Math.Ceiling((double) cb6783c1e06b5b5ba172fbe70f583493d / cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(2632));
            int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2640);
            // ISSUE: reference to a compiler-generated field
            c106acc4c3410a4edbc7df411de20797f.c9d39e682b58e6d2d518070602d0e7536 = Enumerable.Repeat<bool>(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2644) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2648)).ToArray<bool>();
            // ISSUE: reference to a compiler-generated field
            c106acc4c3410a4edbc7df411de20797f.c51735914d2bc630935867d47ac6c60c2 = Enumerable.Repeat<List<int>>(new List<int>(), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2652)).ToArray<List<int>>();
            Thread[] threadArray = c8c77e074ebc8e73a5914b5a5d2cdaab5.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2656));
            int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2660);
            while (index1 < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2672))
            {
              if (c2588d86df683948e6abcda1b2a034974.c239b6eff7d01f6b4925592323fae65a3[index1] == null)
              {
label_17:
                switch (1)
                {
                  case 0:
                    goto label_17;
                  default:
                    c2588d86df683948e6abcda1b2a034974.c239b6eff7d01f6b4925592323fae65a3[index1] = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2664));
                    break;
                }
              }
              index1 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2668);
            }
label_21:
            switch (1)
            {
              case 0:
                goto label_21;
              default:
                int num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2676);
                while (num3 < num1)
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: variable of a compiler-generated type
                  c2588d86df683948e6abcda1b2a034974.c477a468a28a5edd3baf90291914f2e8e c477a468a28a5edd3baf90291914f2e8e = new c2588d86df683948e6abcda1b2a034974.c477a468a28a5edd3baf90291914f2e8e();
                  // ISSUE: reference to a compiler-generated field
                  c477a468a28a5edd3baf90291914f2e8e.c5bf0273358253d4f13533201842261a2 = c106acc4c3410a4edbc7df411de20797f;
                  // ISSUE: reference to a compiler-generated field
                  c477a468a28a5edd3baf90291914f2e8e.ced428221745ca666eeebe3f3899a1e2d = c2588d86df683948e6abcda1b2a034974.c00cbc621caee374a8e66962f37968426(cb6783c1e06b5b5ba172fbe70f583493d, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2680), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2684));
                  // ISSUE: reference to a compiler-generated field
                  cb6783c1e06b5b5ba172fbe70f583493d -= c477a468a28a5edd3baf90291914f2e8e.ced428221745ca666eeebe3f3899a1e2d.Item2;
                  int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2688);
                  while (index2 < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2712))
                  {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    c2588d86df683948e6abcda1b2a034974.c17e3504cad399f62e20159f213a735ce c17e3504cad399f62e20159f213a735ce = new c2588d86df683948e6abcda1b2a034974.c17e3504cad399f62e20159f213a735ce();
                    // ISSUE: reference to a compiler-generated field
                    c17e3504cad399f62e20159f213a735ce.c0b31be131ba828ae1b2523532b069f6b = c477a468a28a5edd3baf90291914f2e8e;
                    // ISSUE: reference to a compiler-generated field
                    c17e3504cad399f62e20159f213a735ce.cada60f5a00344a6c6cce405c946290f3 = index2;
                    // ISSUE: reference to a compiler-generated field
                    c17e3504cad399f62e20159f213a735ce.c74981f86c3ba163595d51d77e274f502 = num2;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    c17e3504cad399f62e20159f213a735ce.c0b31be131ba828ae1b2523532b069f6b.c5bf0273358253d4f13533201842261a2.c9d39e682b58e6d2d518070602d0e7536[index2] = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2692) != 0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    c17e3504cad399f62e20159f213a735ce.c0b31be131ba828ae1b2523532b069f6b.c5bf0273358253d4f13533201842261a2.c51735914d2bc630935867d47ac6c60c2[index2] = new List<int>();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    fileStream.Read(c2588d86df683948e6abcda1b2a034974.c239b6eff7d01f6b4925592323fae65a3[index2], cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2696), c17e3504cad399f62e20159f213a735ce.c0b31be131ba828ae1b2523532b069f6b.ced428221745ca666eeebe3f3899a1e2d.Item1[index2] * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2700));
                    if (c2588d86df683948e6abcda1b2a034974.c239b6eff7d01f6b4925592323fae65a3[index2].Length != 0)
                    {
label_25:
                      switch (6)
                      {
                        case 0:
                          goto label_25;
                        default:
                          // ISSUE: reference to a compiler-generated method
                          threadArray[index2] = new Thread(new ThreadStart(c17e3504cad399f62e20159f213a735ce.cbe370fcf2f552307bc29cb613af8a076));
                          threadArray[index2].Start();
                          break;
                      }
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      c17e3504cad399f62e20159f213a735ce.c0b31be131ba828ae1b2523532b069f6b.c5bf0273358253d4f13533201842261a2.c9d39e682b58e6d2d518070602d0e7536[index2] = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2704) != 0;
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      c17e3504cad399f62e20159f213a735ce.c0b31be131ba828ae1b2523532b069f6b.c5bf0273358253d4f13533201842261a2.c51735914d2bc630935867d47ac6c60c2[index2] = new List<int>();
                    }
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    num2 += c17e3504cad399f62e20159f213a735ce.c0b31be131ba828ae1b2523532b069f6b.ced428221745ca666eeebe3f3899a1e2d.Item1[index2];
                    index2 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2708);
                  }
label_30:
                  switch (6)
                  {
                    case 0:
                      goto label_30;
                    default:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      while (!c2588d86df683948e6abcda1b2a034974.caab975766c04dfae7efd2150dc8ed4ed(c477a468a28a5edd3baf90291914f2e8e.c5bf0273358253d4f13533201842261a2.c9d39e682b58e6d2d518070602d0e7536))
                        Thread.Sleep(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2716));
label_33:
                      switch (3)
                      {
                        case 0:
                          goto label_33;
                        default:
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          List<int>[] c51735914d2bc630935867d47ac6c60c2 = c477a468a28a5edd3baf90291914f2e8e.c5bf0273358253d4f13533201842261a2.c51735914d2bc630935867d47ac6c60c2;
                          int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2720);
                          while (index3 < (int) c408b30399180d31b1d06f7e411bbd348.c572aba370be49804cbdb0b35312bea94(c51735914d2bc630935867d47ac6c60c2))
                          {
                            List<int> intList = c51735914d2bc630935867d47ac6c60c2[index3];
                            c3020c3c4c17965a898c5a3dfb4f8e829.AddRange((IEnumerable<int>) intList);
                            index3 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2724);
                          }
label_37:
                          switch (2)
                          {
                            case 0:
                              goto label_37;
                            default:
                              num3 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2728);
                              continue;
                          }
                      }
                  }
                }
label_40:
                switch (1)
                {
                  case 0:
                    goto label_40;
                }
            }
          }
          finally
          {
            if (fileStream != null)
            {
label_42:
              switch (5)
              {
                case 0:
                  goto label_42;
                default:
                  fileStream.Dispose();
                  break;
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          return new caaa166a921d0019973aa328703a03e82(c96ea0f005869aeebb7feaffca9d2073f.ca0d69c1f5075ba97fb3e0bfe64a9d6f6, c3020c3c4c17965a898c5a3dfb4f8e829, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2732) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2736) != 0);
        }
      }
    }

    public static byte[] c14516839f75b82a18f7bfb61ce12d397(byte[] cc0048e297270ca267c121e581b301b2b, byte[] cca76947157f6ec86b4babf9451d03287, byte[] c6b78934ae77e0d5ca49f4525627346f9)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2740);
      rijndaelManaged.Mode = (CipherMode) num1;
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2744);
      rijndaelManaged.Padding = (PaddingMode) num2;
      int num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2748);
      rijndaelManaged.KeySize = num3;
      int num4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2752);
      rijndaelManaged.BlockSize = num4;
      byte[] numArray1 = cca76947157f6ec86b4babf9451d03287;
      rijndaelManaged.Key = numArray1;
      byte[] numArray2 = c6b78934ae77e0d5ca49f4525627346f9;
      rijndaelManaged.IV = numArray2;
      byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4((int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(cc0048e297270ca267c121e581b301b2b));
      ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
      MemoryStream memoryStream = new MemoryStream(cc0048e297270ca267c121e581b301b2b);
      try
      {
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, (CryptoStreamMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2756));
        try
        {
          cryptoStream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2760), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(cc0048e297270ca267c121e581b301b2b));
        }
        finally
        {
          if (cryptoStream != null)
          {
label_4:
            switch (6)
            {
              case 0:
                goto label_4;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c14516839f75b82a18f7bfb61ce12d397);
                }
                cryptoStream.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
label_10:
          switch (7)
          {
            case 0:
              goto label_10;
            default:
              memoryStream.Dispose();
              break;
          }
        }
      }
      return buffer;
    }

    public static void c50491654f74af91fee5f3cfeeae6578d(string c23287ae0b6fa4e8b690cd27f34a9455a, string cbd5721758c154f07ec12342ad5bd9770, byte[] c4d45c6e468d9560ee4f9dd32ffb3d8b8, byte[] c6b78934ae77e0d5ca49f4525627346f9)
    {
      byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2764));
      AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider();
      try
      {
        cryptoServiceProvider.Key = c4d45c6e468d9560ee4f9dd32ffb3d8b8;
        cryptoServiceProvider.IV = c6b78934ae77e0d5ca49f4525627346f9;
        cryptoServiceProvider.Padding = (PaddingMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2768);
        FileStream fileStream1 = File.Open(c23287ae0b6fa4e8b690cd27f34a9455a, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2772));
        try
        {
          FileStream fileStream2 = File.Create(cbd5721758c154f07ec12342ad5bd9770);
          try
          {
            CryptoStream cryptoStream = new CryptoStream((Stream) fileStream1, cryptoServiceProvider.CreateDecryptor(), (CryptoStreamMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2776));
            try
            {
              int count;
              do
              {
                count = cryptoStream.Read(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2780), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
                fileStream2.Write(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2784), count);
              }
              while (count > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2788));
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  if (1 != 0)
                    break;
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c50491654f74af91fee5f3cfeeae6578d);
                  break;
              }
            }
            finally
            {
              if (cryptoStream != null)
              {
label_10:
                switch (7)
                {
                  case 0:
                    goto label_10;
                  default:
                    cryptoStream.Dispose();
                    break;
                }
              }
            }
          }
          finally
          {
            if (fileStream2 != null)
            {
label_14:
              switch (5)
              {
                case 0:
                  goto label_14;
                default:
                  fileStream2.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (fileStream1 != null)
          {
label_18:
            switch (2)
            {
              case 0:
                goto label_18;
              default:
                fileStream1.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (cryptoServiceProvider != null)
        {
label_22:
          switch (5)
          {
            case 0:
              goto label_22;
            default:
              cryptoServiceProvider.Dispose();
              break;
          }
        }
      }
    }

    private static bool caab975766c04dfae7efd2150dc8ed4ed(bool[] cf6f17570f4ad52d09d03b05679dd5503)
    {
      bool[] flagArray = cf6f17570f4ad52d09d03b05679dd5503;
      // ISSUE: reference to a compiler-generated field
      Func<bool, bool> predicate = c2588d86df683948e6abcda1b2a034974.\u003C\u003Ec.c0f5f99261138b054e8c6532cd38cd0da;
      if (predicate == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.caab975766c04dfae7efd2150dc8ed4ed);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            predicate = c2588d86df683948e6abcda1b2a034974.\u003C\u003Ec.c0f5f99261138b054e8c6532cd38cd0da = new Func<bool, bool>(c2588d86df683948e6abcda1b2a034974.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cc91678673758e3d19117bcdbde27e86d);
            break;
        }
      }
      return ((IEnumerable<bool>) flagArray).All<bool>(predicate);
    }

    private static List<int> c45d8f35056fd13e400750abcde176cb2(byte[] cc53fcfd55e071893e0e37273745408d6, byte[] c0b4208fa44d57e11308b8816c2d771ca, int ca1828d23b5d9f25b7344301deefaadfa, int c5d5948a8274478b580d4ed74dfde289d, byte[] cca76947157f6ec86b4babf9451d03287, byte cc4a314a023c5328994ee2c9a3b74ca41)
    {
      List<int> intList = new List<int>();
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2792);
      while (num < c5d5948a8274478b580d4ed74dfde289d)
      {
        byte[] c4d66af9ff72d1a843bbfaba344ad375d = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2796));
        Buffer.BlockCopy((Array) cc53fcfd55e071893e0e37273745408d6, num * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2800), (Array) c4d66af9ff72d1a843bbfaba344ad375d, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2804), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2808));
        if (c2588d86df683948e6abcda1b2a034974.c27d633604e642e25b89209d64298ce21(c4d66af9ff72d1a843bbfaba344ad375d, c0b4208fa44d57e11308b8816c2d771ca, num + ca1828d23b5d9f25b7344301deefaadfa, cca76947157f6ec86b4babf9451d03287, cc4a314a023c5328994ee2c9a3b74ca41) == (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2812))
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c45d8f35056fd13e400750abcde176cb2);
              }
              intList.Add(num + ca1828d23b5d9f25b7344301deefaadfa);
              break;
          }
        }
        num += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2816);
      }
label_8:
      switch (4)
      {
        case 0:
          goto label_8;
        default:
          return intList;
      }
    }

    private static byte[] ce6fc7d00c6cb9c106441e8a21d20c41e(ushort c870854cf88818df19809c642ea8bd146)
    {
      byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2820));
      byte[] bytes = BitConverter.GetBytes(c870854cf88818df19809c642ea8bd146);
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2824);
      int num1 = (int) bytes[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2828)];
      numArray[index1] = (byte) num1;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2832);
      int num2 = (int) bytes[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2836)];
      numArray[index2] = (byte) num2;
      return numArray;
    }

    private static bool c598d44fa5616d2ce79c0b9fcdd528ef3(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, ccc0082396339666e15f34a6614404a47 cc0048e297270ca267c121e581b301b2b, byte[] cca76947157f6ec86b4babf9451d03287)
    {
      string str = Path.Combine(c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(cc0048e297270ca267c121e581b301b2b.ContentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)));
      byte[] c6b78934ae77e0d5ca49f4525627346f9 = c2588d86df683948e6abcda1b2a034974.ce6fc7d00c6cb9c106441e8a21d20c41e(cc0048e297270ca267c121e581b301b2b.Index);
      byte[] ccf028ef488ad163ff8a1fdd07540a235;
      if (c36dd98eb0c08ea087627a40c6663c9a8.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2840))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c598d44fa5616d2ce79c0b9fcdd528ef3);
            }
            byte[] array = File.ReadAllBytes(str);
            Array.Resize<byte>(ref array, ccbda8e2370d034604647d744ba7d67ed.c4a770faab4e0250a4f6ca937bfe48e0a((int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(array), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2844)));
            ccf028ef488ad163ff8a1fdd07540a235 = SHA1.Create().ComputeHash(c2588d86df683948e6abcda1b2a034974.c14516839f75b82a18f7bfb61ce12d397(array, cca76947157f6ec86b4babf9451d03287, c6b78934ae77e0d5ca49f4525627346f9), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2848), (int) cc0048e297270ca267c121e581b301b2b.Size.TotalBytes);
            break;
        }
      }
      else
        ccf028ef488ad163ff8a1fdd07540a235 = c2588d86df683948e6abcda1b2a034974.c857c62b75ac43a015244e43ae89c5b34(str, cca76947157f6ec86b4babf9451d03287, c6b78934ae77e0d5ca49f4525627346f9);
      return ccbda8e2370d034604647d744ba7d67ed.c9da387a0620d0fb76794f0636febd9bd(ccf028ef488ad163ff8a1fdd07540a235, cc0048e297270ca267c121e581b301b2b.Hash);
    }

    private static Tuple<int[], int> c00cbc621caee374a8e66962f37968426(int cb6783c1e06b5b5ba172fbe70f583493d, int ced428221745ca666eeebe3f3899a1e2d, int c60612a83bb19149c40c28356616e0395)
    {
      int[] array = Enumerable.Repeat<int>(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2852), ced428221745ca666eeebe3f3899a1e2d).ToArray<int>();
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2856);
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2860);
      while (index < ced428221745ca666eeebe3f3899a1e2d)
      {
        int num2 = c2588d86df683948e6abcda1b2a034974.cd0110929c0ae1c97d03d275700043ef5(cb6783c1e06b5b5ba172fbe70f583493d, c60612a83bb19149c40c28356616e0395);
        num1 += num2;
        array[index] = num2;
        cb6783c1e06b5b5ba172fbe70f583493d -= num2;
        index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2864);
      }
label_3:
      switch (6)
      {
        case 0:
          goto label_3;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.c00cbc621caee374a8e66962f37968426);
          }
          return new Tuple<int[], int>(array, num1);
      }
    }

    private static int cd0110929c0ae1c97d03d275700043ef5(int cb65dfb0bc05cf5ef055e18ba40b6708a, int c3f5d520841f3db81672ed6d8abac3012)
    {
      if (c3f5d520841f3db81672ed6d8abac3012 > cb65dfb0bc05cf5ef055e18ba40b6708a)
        return cb65dfb0bc05cf5ef055e18ba40b6708a;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2588d86df683948e6abcda1b2a034974.cd0110929c0ae1c97d03d275700043ef5);
          }
          return c3f5d520841f3db81672ed6d8abac3012;
      }
    }
  }
}
