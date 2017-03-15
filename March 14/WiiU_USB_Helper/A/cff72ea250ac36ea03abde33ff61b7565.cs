// Decompiled with JetBrains decompiler
// Type: A.cff72ea250ac36ea03abde33ff61b7565
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A
{
  public sealed class cff72ea250ac36ea03abde33ff61b7565 : IDisposable
  {
    private byte[] cb332a07498e0c504d765640b57db0b81 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7174));
    private byte[] cf01f01207811d3368c712dba9dbe5a1b = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7178));
    private byte[] cf2005b6097758fa657c9531b2ca95b5a = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7182));
    private byte[] c6b057cf8b204ab17aa700c4d575bf715 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7186));
    private uint cf16d1b64e1470cd193054669523fdef1 = (uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7190);
    private uint cf5e8094d0c37f18609dd0536f0524928;
    private ushort c0e26fade4a49b9f408fe6ec813e5f15e;
    private byte c337a6b5ec126b21b500bc2912cbfc7e3;
    private List<ccc0082396339666e15f34a6614404a47> cbd700f96bbaaaa963c6d2f6aa39f165d;
    private ushort ca149aff7e8a126eb921602d392695943;
    private ushort c694077c8d4a1934a5d1b356738320fa9;
    private ushort c8fdad25f16793b825632e0bfb005f2ee;
    private byte cf5a024639ea867e8f32f004aae2fa94d;
    private ushort ce3227a5d87e1c12f0f273c6db2a1a1c1;
    private byte cad0b4da36c168ce8f003edb641919c13;
    private uint cd07bdeb939bc9174aa825299724595f0;
    private byte c6cad7f4d560376fdb80b8ae5bef0c5ed;
    private bool cb33f3ce3ce41ea6319b249210f2b8ee0;

    public byte[] Certificate1 { get; } = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7166));

    public byte[] Certificate2 { get; } = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7170));

    public static byte[] c40d1039b6a1304ab16a685f19118f41b
    {
      get
      {
        return cb3ee0be46e53f0d59cf7ae8039f9406d.c33f9baf5a3187b31f73e8486294078b2;
      }
    }

    public ccc0082396339666e15f34a6614404a47[] c7294cb7c91944988432faebdd13ef3a8
    {
      get
      {
        return this.cbd700f96bbaaaa963c6d2f6aa39f165d.ToArray();
      }
      set
      {
        this.cbd700f96bbaaaa963c6d2f6aa39f165d = new List<ccc0082396339666e15f34a6614404a47>((IEnumerable<ccc0082396339666e15f34a6614404a47>) value);
        this.NumOfContents = (ushort) (int) c2a0c2ae96e14c3951c8dd08f53fe4024.c572aba370be49804cbdb0b35312bea94(value);
      }
    }

    public ushort NumOfContents { get; private set; }

    public ulong TitleId { get; set; }

    public ushort TitleVersion { get; set; }

    public DataSize c96156587eb364978ad5a188620ce8cec
    {
      get
      {
        DataSize dataSize = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6910));
        ccc0082396339666e15f34a6614404a47[] c7294cb7c91944988432faebdd13ef3a8 = this.c7294cb7c91944988432faebdd13ef3a8;
        DataSize seed = dataSize;
        Func<DataSize, ccc0082396339666e15f34a6614404a47, DataSize> func = cff72ea250ac36ea03abde33ff61b7565.\u003C\u003Ec.c0118eb799d11950c49086a73801781e4;
        if (func == null)
        {
label_1:
          switch (6)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cff72ea250ac36ea03abde33ff61b7565.get_c96156587eb364978ad5a188620ce8cec);
              }
              func = cff72ea250ac36ea03abde33ff61b7565.\u003C\u003Ec.c0118eb799d11950c49086a73801781e4 = new Func<DataSize, ccc0082396339666e15f34a6614404a47, DataSize>(cff72ea250ac36ea03abde33ff61b7565.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c22d7fc4f68be929d07a56555e807abf3);
              break;
          }
        }
        return ((IEnumerable<ccc0082396339666e15f34a6614404a47>) c7294cb7c91944988432faebdd13ef3a8).Aggregate<ccc0082396339666e15f34a6614404a47, DataSize>(seed, func);
      }
    }

    ~cff72ea250ac36ea03abde33ff61b7565()
    {
      this.c22706695d1a9686d352d2bbbb66af499(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6902) != 0);
    }

    public void Dispose()
    {
      this.c22706695d1a9686d352d2bbbb66af499(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6898) != 0);
      GC.SuppressFinalize((object) this);
    }

    private void c22706695d1a9686d352d2bbbb66af499(bool c5c8455317717a4ae1fd04f0fba6f4bee)
    {
      if (c5c8455317717a4ae1fd04f0fba6f4bee)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cff72ea250ac36ea03abde33ff61b7565.c22706695d1a9686d352d2bbbb66af499);
            }
            if (!this.cb33f3ce3ce41ea6319b249210f2b8ee0)
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  this.c6b057cf8b204ab17aa700c4d575bf715 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cf01f01207811d3368c712dba9dbe5a1b = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cb332a07498e0c504d765640b57db0b81 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cf2005b6097758fa657c9531b2ca95b5a = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  this.cbd700f96bbaaaa963c6d2f6aa39f165d.Clear();
                  this.cbd700f96bbaaaa963c6d2f6aa39f165d = c32ac248027c9e8261b9ba45b4db5e7ed.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  break;
              }
            }
            else
              break;
        }
      }
      this.cb33f3ce3ce41ea6319b249210f2b8ee0 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6906) != 0;
    }

    public static cff72ea250ac36ea03abde33ff61b7565 cb5009c1058eaad54842d9bead8e530a2(string c7d8842643cbffce7d3862ffbf1292d71, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      return cff72ea250ac36ea03abde33ff61b7565.cb5009c1058eaad54842d9bead8e530a2(File.ReadAllBytes(c7d8842643cbffce7d3862ffbf1292d71), cf48069439fdaca88d5122269390eb989);
    }

    public static cff72ea250ac36ea03abde33ff61b7565 cb5009c1058eaad54842d9bead8e530a2(byte[] c21f1aeda07f460789b59dc4a6d226105, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      cff72ea250ac36ea03abde33ff61b7565 cff72ea250ac36ea03abde33ff61b7565 = new cff72ea250ac36ea03abde33ff61b7565();
      MemoryStream memoryStream = new MemoryStream(c21f1aeda07f460789b59dc4a6d226105);
      try
      {
        cff72ea250ac36ea03abde33ff61b7565.c10afed81f56897d9980d4f05b9b9ec54((Stream) memoryStream, cf48069439fdaca88d5122269390eb989);
      }
      catch
      {
        memoryStream.Dispose();
        throw;
      }
      memoryStream.Dispose();
      return cff72ea250ac36ea03abde33ff61b7565;
    }

    private void c10afed81f56897d9980d4f05b9b9ec54(Stream c21f1aeda07f460789b59dc4a6d226105, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      c21f1aeda07f460789b59dc4a6d226105.Seek((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6914), (SeekOrigin) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6918));
      byte[] buffer1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6922));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6926), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6930));
      this.cf16d1b64e1470cd193054669523fdef1 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6934)));
      c21f1aeda07f460789b59dc4a6d226105.Read(this.c6b057cf8b204ab17aa700c4d575bf715, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6938), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.c6b057cf8b204ab17aa700c4d575bf715));
      c21f1aeda07f460789b59dc4a6d226105.Read(this.cf01f01207811d3368c712dba9dbe5a1b, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6942), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.cf01f01207811d3368c712dba9dbe5a1b));
      c21f1aeda07f460789b59dc4a6d226105.Read(this.cb332a07498e0c504d765640b57db0b81, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6946), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.cb332a07498e0c504d765640b57db0b81));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6950), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6954));
      this.c6cad7f4d560376fdb80b8ae5bef0c5ed = buffer1[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6958)];
      this.c337a6b5ec126b21b500bc2912cbfc7e3 = buffer1[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6962)];
      this.cad0b4da36c168ce8f003edb641919c13 = buffer1[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6966)];
      this.cf5a024639ea867e8f32f004aae2fa94d = buffer1[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6970)];
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6974), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6978));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6982), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6986));
      this.TitleId = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt64(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6990)));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6994), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(6998));
      this.cd07bdeb939bc9174aa825299724595f0 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7002)));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7006), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7010));
      this.ca149aff7e8a126eb921602d392695943 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7014)));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7018), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7022));
      this.c694077c8d4a1934a5d1b356738320fa9 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7026)));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7030), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7034));
      this.ce3227a5d87e1c12f0f273c6db2a1a1c1 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7038)));
      c21f1aeda07f460789b59dc4a6d226105.Read(this.cf2005b6097758fa657c9531b2ca95b5a, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7042), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.cf2005b6097758fa657c9531b2ca95b5a));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7046), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7050));
      this.cf5e8094d0c37f18609dd0536f0524928 = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7054)));
      c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7058), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7062));
      this.TitleVersion = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7066)));
      this.NumOfContents = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7070)));
      this.c0e26fade4a49b9f408fe6ec813e5f15e = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7074)));
      this.c8fdad25f16793b825632e0bfb005f2ee = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7078)));
      c21f1aeda07f460789b59dc4a6d226105.Position = (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7082);
      this.cbd700f96bbaaaa963c6d2f6aa39f165d = new List<ccc0082396339666e15f34a6614404a47>();
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7086);
      while (num < (int) this.NumOfContents)
      {
        ccc0082396339666e15f34a6614404a47 ccc0082396339666e15f34a6614404a47;
        if (cf48069439fdaca88d5122269390eb989 == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7090))
        {
label_2:
          switch (4)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cff72ea250ac36ea03abde33ff61b7565.c10afed81f56897d9980d4f05b9b9ec54);
              }
              c2edf667a99180a98bbfd7e14f8ea1e18 c2edf667a99180a98bbfd7e14f8ea1e18 = new c2edf667a99180a98bbfd7e14f8ea1e18();
              byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7094));
              c2edf667a99180a98bbfd7e14f8ea1e18.Hash = numArray;
              ccc0082396339666e15f34a6614404a47 = (ccc0082396339666e15f34a6614404a47) c2edf667a99180a98bbfd7e14f8ea1e18;
              break;
          }
        }
        else
        {
          c75f5de7b80fe7844b6d58b00022bcaf5 c75f5de7b80fe7844b6d58b00022bcaf5 = new c75f5de7b80fe7844b6d58b00022bcaf5();
          byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7098));
          c75f5de7b80fe7844b6d58b00022bcaf5.Hash = numArray;
          ccc0082396339666e15f34a6614404a47 = (ccc0082396339666e15f34a6614404a47) c75f5de7b80fe7844b6d58b00022bcaf5;
        }
        c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7102), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7106));
        ccc0082396339666e15f34a6614404a47.ContentId = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt32(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7110)));
        ccc0082396339666e15f34a6614404a47.Index = ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7114)));
        ccc0082396339666e15f34a6614404a47.c937760863341d8781f86cc88a951c751 = (c7fcc581584086d18c24ec12ebfa8f37a) ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt16(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7118)));
        c21f1aeda07f460789b59dc4a6d226105.Read(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7122), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7126));
        ccc0082396339666e15f34a6614404a47.Size = new DataSize(ccbda8e2370d034604647d744ba7d67ed.c6404b9d7e4d0919b78064f8f3b59faba(BitConverter.ToUInt64(buffer1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7130))));
        c21f1aeda07f460789b59dc4a6d226105.Read(ccc0082396339666e15f34a6614404a47.Hash, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7134), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(ccc0082396339666e15f34a6614404a47.Hash));
        this.cbd700f96bbaaaa963c6d2f6aa39f165d.Add(ccc0082396339666e15f34a6614404a47);
        if (cf48069439fdaca88d5122269390eb989 == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7138))
        {
label_8:
          switch (7)
          {
            case 0:
              goto label_8;
            default:
              byte[] buffer2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7142));
              c21f1aeda07f460789b59dc4a6d226105.Read(buffer2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7146), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7150));
              break;
          }
        }
        num += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7154);
      }
label_12:
      switch (4)
      {
        case 0:
          goto label_12;
        default:
          c21f1aeda07f460789b59dc4a6d226105.Read(this.Certificate1, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7158), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.Certificate1));
          c21f1aeda07f460789b59dc4a6d226105.Read(this.Certificate2, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7162), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(this.Certificate2));
          break;
      }
    }
  }
}
