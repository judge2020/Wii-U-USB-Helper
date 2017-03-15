// Decompiled with JetBrains decompiler
// Type: A.ce64fe4baff0b285aaecd02e2cae2ea2c
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NusHelper;
using System;
using System.IO;

namespace A
{
  public class ce64fe4baff0b285aaecd02e2cae2ea2c : cba6aa8f767d2e8dfbca2d43d7148c173
  {
    public override string ce7a5964b7f9ba43afcebe1e7d79151c7
    {
      get
      {
        return cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(base.ce7a5964b7f9ba43afcebe1e7d79151c7, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2949));
      }
    }

    public override string OutputPath
    {
      get
      {
        string[] strArray = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(600));
        int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(604);
        string outputPath = base.OutputPath;
        strArray[index1] = outputPath;
        int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(608);
        string str1;
        if (this.System != (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(612))
        {
label_1:
          switch (2)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (ce64fe4baff0b285aaecd02e2cae2ea2c.get_OutputPath);
              }
              str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1260);
              break;
          }
        }
        else
          str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1277);
        strArray[index2] = str1;
        int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(616);
        string region = this.Region;
        strArray[index3] = region;
        int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(620);
        string str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2968);
        strArray[index4] = str2;
        int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(624);
        string str3 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(this.c6de6c5dc546a67d110feb8f495ab222d, string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2983), (object) this.Version));
        strArray[index5] = str3;
        return Path.Combine(strArray);
      }
    }

    public ce64fe4baff0b285aaecd02e2cae2ea2c(string c407606821fe6034b43e547a4ca232678, TitleId ca1f653cd83e17dfea7eb1317167e710f, string cd47a8862dc253a9ef4c1baa0b8cbdb0a, byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc, DataSize c395088e62cfd02fd835b335ee398e70c, string c2c4ae15422a94d502e209edd80a1eca1, string cd6d3c2c981fd22369f3efc24e5ed5fa1, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
      : base(c407606821fe6034b43e547a4ca232678, ca1f653cd83e17dfea7eb1317167e710f, cd47a8862dc253a9ef4c1baa0b8cbdb0a, c9d02e186a6ec2baccf2d2d1ffb9a59dc, c395088e62cfd02fd835b335ee398e70c, cd6d3c2c981fd22369f3efc24e5ed5fa1, cf48069439fdaca88d5122269390eb989)
    {
      this.Version = c2c4ae15422a94d502e209edd80a1eca1;
    }

    public override string ToString()
    {
      string format = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2998);
      object[] objArray = c75c1f93673bbfb801467a150b6a0a9b7.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(628));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(632);
      string name = this.Name;
      objArray[index1] = (object) name;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(636);
      string version = this.Version;
      objArray[index2] = (object) version;
      int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(640);
      // ISSUE: variable of a boxed type
      __Boxed<DataSize> size = (ValueType) this.Size;
      objArray[index3] = (object) size;
      int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(644);
      string region = this.Region;
      objArray[index4] = (object) region;
      return string.Format(format, objArray);
    }
  }
}
