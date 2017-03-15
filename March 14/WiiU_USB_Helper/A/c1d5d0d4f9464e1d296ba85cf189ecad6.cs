// Decompiled with JetBrains decompiler
// Type: A.c1d5d0d4f9464e1d296ba85cf189ecad6
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.IO;
using System.Security.Cryptography;

namespace A
{
  public sealed class c1d5d0d4f9464e1d296ba85cf189ecad6 : IDisposable
  {
    private byte[] cc4236b56c28405a636b38b9c0e32aedb = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3172));
    private byte[] c11175c83c4321ba4c6f6b5dca85d08b4 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3176));
    private byte[] cb332a07498e0c504d765640b57db0b81 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3180));
    private byte[] cd40e8f5cfa7ff1e575d2b2df54d26b03 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3184));
    private byte[] cf01f01207811d3368c712dba9dbe5a1b = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3188));
    private byte[] c460eed69d3ca9133517b06ce7481609d = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3192));
    private byte[] c6b057cf8b204ab17aa700c4d575bf715 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3196));
    private uint cf16d1b64e1470cd193054669523fdef1 = (uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3200);
    private byte[] cc7771125736fa2f38a2adfefd8bb8851 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3204));
    private ushort cc937476ecef672e2522a5cc26af8e65a = (ushort) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3208);
    private byte[] c722811738fefa691a79554c73a607002 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3212));
    private byte[] c1b1e40362bbe418219390cc3950cfda7 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3216));
    private static readonly byte[] cabfe068702038015f4703791b7ef6e30;
    private static readonly byte[] c95e59949d06dd580cc7c567bf2106fa6;
    private static readonly byte[] cef9a583ad6058e74acfe9e0aa425a26c;
    private byte c7edfe8a413def3846ab51fd3c3f1d166;
    private uint c4be4333d10a42f1002dc715c49af40fe;
    private uint cfc5209ffbc08ec0260f1390a3af232fe;
    private byte c4fab59a9e0aa4ec6b40159e95d286f22;
    private byte c694077c8d4a1934a5d1b356738320fa9;
    private ushort c8fdad25f16793b825632e0bfb005f2ee;
    private bool c30f8c4d2f719f9dff08782f0e85f4c84;
    private uint c04cdc4ad38d6905d4262a0dd31528825;
    private ulong c084fb42a87baab2dd51268053d66a9be;
    private byte c7e0781ef4993378b090dbd6e763b015d;
    private ulong c9663ae027151753c12e10b067208bb79;
    private bool cb33f3ce3ce41ea6319b249210f2b8ee0;

    public ushort NumOfDlc { get; set; }

    public ulong TicketId { get; set; }

    public byte[] c80d617f05b7f95017df4cba82652d0dd
    {
      get
      {
        return this.cc4236b56c28405a636b38b9c0e32aedb;
      }
      set
      {
        this.cc4236b56c28405a636b38b9c0e32aedb = value;
        this.TitleKeyChanged = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2872) != 0;
        this.c30f8c4d2f719f9dff08782f0e85f4c84 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2876) != 0;
      }
    }

    public bool TitleKeyChanged { get; private set; }

    static c1d5d0d4f9464e1d296ba85cf189ecad6()
    {
      byte[] numArray1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3220));
      int cecb96267e559a56c4f543488b117e4fc1 = 3224;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) numArray1, cecb96267e559a56c4f543488b117e4fc1);
      c1d5d0d4f9464e1d296ba85cf189ecad6.cabfe068702038015f4703791b7ef6e30 = numArray1;
      byte[] numArray2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3398));
      int cecb96267e559a56c4f543488b117e4fc2 = 3402;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) numArray2, cecb96267e559a56c4f543488b117e4fc2);
      c1d5d0d4f9464e1d296ba85cf189ecad6.c95e59949d06dd580cc7c567bf2106fa6 = numArray2;
      byte[] numArray3 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(4252));
      int cecb96267e559a56c4f543488b117e4fc3 = 4256;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) numArray3, cecb96267e559a56c4f543488b117e4fc3);
      c1d5d0d4f9464e1d296ba85cf189ecad6.cef9a583ad6058e74acfe9e0aa425a26c = numArray3;
    }

    ~c1d5d0d4f9464e1d296ba85cf189ecad6()
    {
      this.c22706695d1a9686d352d2bbbb66af499(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2988) != 0);
    }

    public static byte[] cd95d6179fbfbb8343ee6b7e86eddb263(string cac83d790d2d2338b8ce9359a4e4b138d, string cca76947157f6ec86b4babf9451d03287, int cac034974376ddcc70096673200b313b9)
    {
      return c1d5d0d4f9464e1d296ba85cf189ecad6.c2fd2694adf304edaf52013c6957ff152(cac83d790d2d2338b8ce9359a4e4b138d, cca76947157f6ec86b4babf9451d03287, cac034974376ddcc70096673200b313b9, c1d5d0d4f9464e1d296ba85cf189ecad6.cef9a583ad6058e74acfe9e0aa425a26c, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2880) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2884) != 0);
    }

    public static byte[] cfbf162b4311a1d065e7071c4a8cd2925(string cac83d790d2d2338b8ce9359a4e4b138d, string cca76947157f6ec86b4babf9451d03287, int cac034974376ddcc70096673200b313b9, bool c75d672735c090ce4bf122776bf7c43bc = false, bool c5352faecc19d3946516b5b09e1cfa6db = false)
    {
      return c1d5d0d4f9464e1d296ba85cf189ecad6.c2fd2694adf304edaf52013c6957ff152(cac83d790d2d2338b8ce9359a4e4b138d, cca76947157f6ec86b4babf9451d03287, cac034974376ddcc70096673200b313b9, c1d5d0d4f9464e1d296ba85cf189ecad6.c95e59949d06dd580cc7c567bf2106fa6, c75d672735c090ce4bf122776bf7c43bc, c5352faecc19d3946516b5b09e1cfa6db);
    }

    internal static byte[] cae2e9bf4acb15138d7a2e5dcb60b24d7(string c31c500531f6507b8c51a9c0e67802c8b)
    {
      int length = c31c500531f6507b8c51a9c0e67802c8b.Length;
      byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(length / cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2888));
      int startIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2892);
      while (startIndex < length)
      {
        numArray[startIndex / cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2896)] = Convert.ToByte(c31c500531f6507b8c51a9c0e67802c8b.Substring(startIndex, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2900)), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2904));
        startIndex += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2908);
      }
label_3:
      switch (7)
      {
        case 0:
          goto label_3;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1d5d0d4f9464e1d296ba85cf189ecad6.cae2e9bf4acb15138d7a2e5dcb60b24d7);
          }
          return numArray;
      }
    }

    private static byte[] c2fd2694adf304edaf52013c6957ff152(string cac83d790d2d2338b8ce9359a4e4b138d, string cca76947157f6ec86b4babf9451d03287, int cac034974376ddcc70096673200b313b9, byte[] c914b21881ac3be4499e0587f702c85b8, bool c75d672735c090ce4bf122776bf7c43bc = false, bool c5352faecc19d3946516b5b09e1cfa6db = false)
    {
      byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc = cfe692819c6957a6eec4970c3560cea3d.cc8e287d5350b43026d33bb80beb131a0(c914b21881ac3be4499e0587f702c85b8.Clone());
      byte[] numArray1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2912));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2916);
      int num1 = (int) (byte) (cac034974376ddcc70096673200b313b9 >> cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2920));
      numArray1[index1] = (byte) num1;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2924);
      int num2 = (int) (byte) cac034974376ddcc70096673200b313b9;
      numArray1[index2] = (byte) num2;
      byte[] c33ad1bd311fd4b32b85377e9e15a9d93_1 = c1d5d0d4f9464e1d296ba85cf189ecad6.cae2e9bf4acb15138d7a2e5dcb60b24d7(cac83d790d2d2338b8ce9359a4e4b138d);
      byte[] c33ad1bd311fd4b32b85377e9e15a9d93_2 = c1d5d0d4f9464e1d296ba85cf189ecad6.cae2e9bf4acb15138d7a2e5dcb60b24d7(cca76947157f6ec86b4babf9451d03287);
      int srcOffset = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2928);
      byte[] numArray2 = c9d02e186a6ec2baccf2d2d1ffb9a59dc;
      int dstOffset = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2932);
      int count = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2936);
      Buffer.BlockCopy((Array) numArray1, srcOffset, (Array) numArray2, dstOffset, count);
      Buffer.BlockCopy((Array) c33ad1bd311fd4b32b85377e9e15a9d93_1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2940), (Array) c9d02e186a6ec2baccf2d2d1ffb9a59dc, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2944), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93_1));
      Buffer.BlockCopy((Array) c33ad1bd311fd4b32b85377e9e15a9d93_2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2948), (Array) c9d02e186a6ec2baccf2d2d1ffb9a59dc, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2952), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93_2));
      if (c75d672735c090ce4bf122776bf7c43bc)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1d5d0d4f9464e1d296ba85cf189ecad6.c2fd2694adf304edaf52013c6957ff152);
            }
            c1d5d0d4f9464e1d296ba85cf189ecad6.c69222ec77209d59eb0edb047d0427ec5(ref c9d02e186a6ec2baccf2d2d1ffb9a59dc);
            break;
        }
      }
      if (c5352faecc19d3946516b5b09e1cfa6db)
      {
label_6:
        switch (6)
        {
          case 0:
            goto label_6;
          default:
            c1d5d0d4f9464e1d296ba85cf189ecad6.c6e08d22b6cb6afe0733755b22121db0c(ref c9d02e186a6ec2baccf2d2d1ffb9a59dc);
            break;
        }
      }
      return c9d02e186a6ec2baccf2d2d1ffb9a59dc;
    }

    private static void c69222ec77209d59eb0edb047d0427ec5(ref byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc)
    {
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2956);
      while (num < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2972))
      {
        c9d02e186a6ec2baccf2d2d1ffb9a59dc[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2960) + num] = (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2964);
        num += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2968);
      }
label_3:
      switch (3)
      {
        case 0:
          goto label_3;
        default:
          if (1 != 0)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (c1d5d0d4f9464e1d296ba85cf189ecad6.c69222ec77209d59eb0edb047d0427ec5);
          break;
      }
    }

    private static void c6e08d22b6cb6afe0733755b22121db0c(ref byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc)
    {
      Buffer.BlockCopy((Array) c1d5d0d4f9464e1d296ba85cf189ecad6.cabfe068702038015f4703791b7ef6e30, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2976), (Array) c9d02e186a6ec2baccf2d2d1ffb9a59dc, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2980), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(c1d5d0d4f9464e1d296ba85cf189ecad6.cabfe068702038015f4703791b7ef6e30));
    }

    public void Dispose()
    {
      this.c22706695d1a9686d352d2bbbb66af499(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2984) != 0);
      GC.SuppressFinalize((object) this);
    }

    private void c22706695d1a9686d352d2bbbb66af499(bool c5c8455317717a4ae1fd04f0fba6f4bee)
    {
      if (c5c8455317717a4ae1fd04f0fba6f4bee)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1d5d0d4f9464e1d296ba85cf189ecad6.c22706695d1a9686d352d2bbbb66af499);
            }
            if (!this.cb33f3ce3ce41ea6319b249210f2b8ee0)
            {
label_5:
              switch (2)
              {
                case 0:
                  goto label_5;
                default:
                  this.cc4236b56c28405a636b38b9c0e32aedb = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cd40e8f5cfa7ff1e575d2b2df54d26b03 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.c6b057cf8b204ab17aa700c4d575bf715 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cf01f01207811d3368c712dba9dbe5a1b = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cb332a07498e0c504d765640b57db0b81 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cc7771125736fa2f38a2adfefd8bb8851 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.c11175c83c4321ba4c6f6b5dca85d08b4 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.c722811738fefa691a79554c73a607002 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.c1b1e40362bbe418219390cc3950cfda7 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.c460eed69d3ca9133517b06ce7481609d = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  break;
              }
            }
            else
              break;
        }
      }
      this.cb33f3ce3ce41ea6319b249210f2b8ee0 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2992) != 0;
    }

    public static c1d5d0d4f9464e1d296ba85cf189ecad6 cb5009c1058eaad54842d9bead8e530a2(string c53d89c5b35d5bdbea9ee89f27dfa09d0, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      return c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(File.ReadAllBytes(c53d89c5b35d5bdbea9ee89f27dfa09d0), cf48069439fdaca88d5122269390eb989);
    }

    public static c1d5d0d4f9464e1d296ba85cf189ecad6 cb5009c1058eaad54842d9bead8e530a2(byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      c1d5d0d4f9464e1d296ba85cf189ecad6 c1d5d0d4f9464e1d296ba85cf189ecad6 = new c1d5d0d4f9464e1d296ba85cf189ecad6();
      MemoryStream memoryStream = new MemoryStream(c9d02e186a6ec2baccf2d2d1ffb9a59dc);
      try
      {
        c1d5d0d4f9464e1d296ba85cf189ecad6.c7eaa42ccff07d4e895624385a579ec2f((Stream) memoryStream, cf48069439fdaca88d5122269390eb989);
      }
      catch
      {
        memoryStream.Dispose();
        throw;
      }
      memoryStream.Dispose();
      return c1d5d0d4f9464e1d296ba85cf189ecad6;
    }

    private void c901626e29eaf2d47a5c088fce6ce3627(caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      byte[] numArray1 = cf9652be11ede2a4c45b6e00796c8c7d3.c19a1d756523dcffcbe22a7ac46c513f6(cf48069439fdaca88d5122269390eb989);
      byte[] bytes = BitConverter.GetBytes(ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(this.c084fb42a87baab2dd51268053d66a9be));
      Array.Resize<byte>(ref bytes, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(2996));
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3000);
      rijndaelManaged.Mode = (CipherMode) num1;
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3004);
      rijndaelManaged.Padding = (PaddingMode) num2;
      int num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3008);
      rijndaelManaged.KeySize = num3;
      int num4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3012);
      rijndaelManaged.BlockSize = num4;
      byte[] numArray2 = numArray1;
      rijndaelManaged.Key = numArray2;
      byte[] numArray3 = bytes;
      rijndaelManaged.IV = numArray3;
      ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
      MemoryStream memoryStream = new MemoryStream(this.c11175c83c4321ba4c6f6b5dca85d08b4);
      ICryptoTransform transform = decryptor;
      int num5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3016);
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, transform, (CryptoStreamMode) num5);
      byte[] cc4236b56c28405a636b38b9c0e32aedb = this.cc4236b56c28405a636b38b9c0e32aedb;
      int offset = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3020);
      int count = (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.cc4236b56c28405a636b38b9c0e32aedb);
      cryptoStream.Read(cc4236b56c28405a636b38b9c0e32aedb, offset, count);
      cryptoStream.Dispose();
      memoryStream.Dispose();
      decryptor.Dispose();
      rijndaelManaged.Clear();
    }

    private void c7eaa42ccff07d4e895624385a579ec2f(Stream c8ab331ddf6a723e37869c2676690ba86, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      c8ab331ddf6a723e37869c2676690ba86.Seek((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3024), (SeekOrigin) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3028));
      byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3032));
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3036), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3040));
      this.cf16d1b64e1470cd193054669523fdef1 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3044)));
      c8ab331ddf6a723e37869c2676690ba86.Read(this.c6b057cf8b204ab17aa700c4d575bf715, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3048), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.c6b057cf8b204ab17aa700c4d575bf715));
      c8ab331ddf6a723e37869c2676690ba86.Read(this.cf01f01207811d3368c712dba9dbe5a1b, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3052), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.cf01f01207811d3368c712dba9dbe5a1b));
      c8ab331ddf6a723e37869c2676690ba86.Read(this.cb332a07498e0c504d765640b57db0b81, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3056), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.cb332a07498e0c504d765640b57db0b81));
      c8ab331ddf6a723e37869c2676690ba86.Read(this.cc7771125736fa2f38a2adfefd8bb8851, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3060), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.cc7771125736fa2f38a2adfefd8bb8851));
      c8ab331ddf6a723e37869c2676690ba86.Read(this.c11175c83c4321ba4c6f6b5dca85d08b4, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3064), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.c11175c83c4321ba4c6f6b5dca85d08b4));
      this.c7e0781ef4993378b090dbd6e763b015d = (byte) c8ab331ddf6a723e37869c2676690ba86.ReadByte();
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3068), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3072));
      this.TicketId = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt64(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3076)));
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3080), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3084));
      this.c4be4333d10a42f1002dc715c49af40fe = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3088)));
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3092), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3096));
      this.c084fb42a87baab2dd51268053d66a9be = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt64(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3100)));
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3104), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3108));
      this.cc937476ecef672e2522a5cc26af8e65a = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3112)));
      this.NumOfDlc = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3116)));
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3120), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3124));
      this.c9663ae027151753c12e10b067208bb79 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt64(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3128)));
      this.c694077c8d4a1934a5d1b356738320fa9 = (byte) c8ab331ddf6a723e37869c2676690ba86.ReadByte();
      this.c7edfe8a413def3846ab51fd3c3f1d166 = (byte) c8ab331ddf6a723e37869c2676690ba86.ReadByte();
      this.c4fab59a9e0aa4ec6b40159e95d286f22 = this.c7edfe8a413def3846ab51fd3c3f1d166;
      c8ab331ddf6a723e37869c2676690ba86.Read(this.c722811738fefa691a79554c73a607002, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3132), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.c722811738fefa691a79554c73a607002));
      c8ab331ddf6a723e37869c2676690ba86.Read(this.c1b1e40362bbe418219390cc3950cfda7, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3136), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.c1b1e40362bbe418219390cc3950cfda7));
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3140), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3144));
      this.c8fdad25f16793b825632e0bfb005f2ee = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3148)));
      c8ab331ddf6a723e37869c2676690ba86.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3152), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3156));
      this.cfc5209ffbc08ec0260f1390a3af232fe = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3160)));
      this.c04cdc4ad38d6905d4262a0dd31528825 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3164)));
      c8ab331ddf6a723e37869c2676690ba86.Read(this.c460eed69d3ca9133517b06ce7481609d, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(3168), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.c460eed69d3ca9133517b06ce7481609d));
      this.c901626e29eaf2d47a5c088fce6ce3627(cf48069439fdaca88d5122269390eb989);
    }

    private void c40156b72c0d1978294da599c08be0083(caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      this.c11175c83c4321ba4c6f6b5dca85d08b4 = this.cd40e8f5cfa7ff1e575d2b2df54d26b03;
      this.c901626e29eaf2d47a5c088fce6ce3627(cf48069439fdaca88d5122269390eb989);
    }
  }
}
