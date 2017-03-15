// Decompiled with JetBrains decompiler
// Type: A.cce1cf1e0b6971ed6f7ef86a83b0959b6
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;
using Nus_Helper_Shared_Core.NusHelper.Saves;
using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using WIIU_Downloader.Forms;

namespace A
{
  public class cce1cf1e0b6971ed6f7ef86a83b0959b6 : cba6aa8f767d2e8dfbca2d43d7148c173
  {
    public c29f686fe3fab48150f240b6f3fa06309 c021af74163c4256c2ba294bd770252ff = new c29f686fe3fab48150f240b6f3fa06309();
    public c29f686fe3fab48150f240b6f3fa06309 c7f3b9801a398a5769c88b58550967da7 = new c29f686fe3fab48150f240b6f3fa06309();
    public c29f686fe3fab48150f240b6f3fa06309 cee7644d811ec48c3e6a2526d09e8524b = new c29f686fe3fab48150f240b6f3fa06309();
    private c0c29f108584f137c614f55b15004c742 c6af0b7782708f8a46a7213103f93fa58;

    public List<ce64fe4baff0b285aaecd02e2cae2ea2c> Updates { get; } = new List<ce64fe4baff0b285aaecd02e2cae2ea2c>();

    public string c98811397437cb243dba328d121c6f691
    {
      get
      {
        string str1;
        if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(this.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338)))
        {
label_1:
          switch (6)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.get_c98811397437cb243dba328d121c6f691);
              }
              if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(this.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345)))
              {
label_5:
                switch (1)
                {
                  case 0:
                    goto label_5;
                  default:
                    str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1352);
                    break;
                }
              }
              else
              {
                str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1357);
                break;
              }
          }
        }
        else
          str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1362);
        string str2 = str1;
        if (this.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(152))
          return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1452), (object) str2, (object) this.ProductId);
label_10:
        switch (3)
        {
          case 0:
            goto label_10;
          default:
            return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1367), (object) str2, (object) this.ProductId);
        }
      }
    }

    public cc0c47a7e733f93eb16513fe84807edf3 Dlc { get; set; }

    public string EshopId { get; private set; }

    public bool cf062de84cde10d9e953c8091a0e1b42b
    {
      get
      {
        return this.Dlc > ce7d9fed342678496b021e8c63d0a2068.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
    }

    public bool c2485b5906efc569b1c867e5c900b2e4e
    {
      get
      {
        return this.Updates.Count > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(156);
      }
    }

    public string IconUrl { get; private set; }

    public bool cd61c5f51f587495941f329dc6bffec54
    {
      get
      {
        return cba6aa8f767d2e8dfbca2d43d7148c173.c0fff13d9b7de393267a3b3d54a50e81f.Contains(this.TitleId.IdRaw);
      }
      set
      {
        bool flag = cba6aa8f767d2e8dfbca2d43d7148c173.c0fff13d9b7de393267a3b3d54a50e81f.Contains(this.TitleId.IdRaw);
        if (flag)
        {
label_1:
          switch (5)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.set_cd61c5f51f587495941f329dc6bffec54);
              }
              if (!value)
              {
label_5:
                switch (4)
                {
                  case 0:
                    goto label_5;
                  default:
                    cba6aa8f767d2e8dfbca2d43d7148c173.c0fff13d9b7de393267a3b3d54a50e81f.Remove(this.TitleId.IdRaw);
                    return;
                }
              }
              else
                break;
          }
        }
        if (!((flag ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(160) & value))
          return;
label_8:
        switch (6)
        {
          case 0:
            goto label_8;
          default:
            cba6aa8f767d2e8dfbca2d43d7148c173.c0fff13d9b7de393267a3b3d54a50e81f.Add(this.TitleId.IdRaw);
            break;
        }
      }
    }

    public override string OutputPath
    {
      get
      {
        string[] strArray = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(164));
        int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(168);
        string outputPath = base.OutputPath;
        strArray[index1] = outputPath;
        int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(172);
        string str1;
        if (this.System != (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(176))
        {
label_1:
          switch (2)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.get_OutputPath);
              }
              str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1260);
              break;
          }
        }
        else
          str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1277);
        strArray[index2] = str1;
        int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(180);
        string region = this.Region;
        strArray[index3] = region;
        int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(184);
        string str2;
        if (!this.CfwOnly)
        {
label_7:
          switch (4)
          {
            case 0:
              goto label_7;
            default:
              str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1547);
              break;
          }
        }
        else
          str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1558);
        strArray[index4] = str2;
        int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(188);
        string c6de6c5dc546a67d110feb8f495ab222d = this.c6de6c5dc546a67d110feb8f495ab222d;
        strArray[index5] = c6de6c5dc546a67d110feb8f495ab222d;
        return Path.Combine(strArray);
      }
    }

    public string ProductId { get; }

    private string c81c9ebcab7e87d87b3e99d7df2c1b1eb
    {
      get
      {
        string[] strArray = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(200));
        int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(204);
        string outputPath = base.OutputPath;
        strArray[index1] = outputPath;
        int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(208);
        string str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1277);
        strArray[index2] = str1;
        int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(212);
        string str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1588);
        strArray[index3] = str2;
        int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(216);
        string region = this.Region;
        strArray[index4] = region;
        int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(220);
        string c6de6c5dc546a67d110feb8f495ab222d = this.c6de6c5dc546a67d110feb8f495ab222d;
        strArray[index5] = c6de6c5dc546a67d110feb8f495ab222d;
        return Path.Combine(strArray);
      }
    }

    public string c4654bf96b305503a608a75dba19b18db
    {
      get
      {
        string c33ad1bd311fd4b32b85377e9e15a9d93 = "";
        switch (this.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>().c7adb0b831ae9d44c1bc321f4993f8d5d)
        {
          case cb48a6650cad6d81c80da89dfe58b703a.c83db08052b4defd7f123a5703adcaf4a:
            c33ad1bd311fd4b32b85377e9e15a9d93 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1659);
            break;
          case cb48a6650cad6d81c80da89dfe58b703a.ca4635737d0de96678db48b9d01ce5b3a:
            c33ad1bd311fd4b32b85377e9e15a9d93 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1718);
            break;
          case cb48a6650cad6d81c80da89dfe58b703a.ccbbe095bbcb593f1ae7554d054de8de1:
            c33ad1bd311fd4b32b85377e9e15a9d93 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1608);
            break;
        }
        int num1 = this.Updates.Count<ce64fe4baff0b285aaecd02e2cae2ea2c>();
        List<ce64fe4baff0b285aaecd02e2cae2ea2c> updates = this.Updates;
        Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool> predicate = cce1cf1e0b6971ed6f7ef86a83b0959b6.\u003C\u003Ec.c66c4da5801e23a5b12207a259ce6920d;
        if (predicate == null)
        {
label_5:
          switch (3)
          {
            case 0:
              goto label_5;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.get_c4654bf96b305503a608a75dba19b18db);
              }
              predicate = cce1cf1e0b6971ed6f7ef86a83b0959b6.\u003C\u003Ec.c66c4da5801e23a5b12207a259ce6920d = new Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool>(cce1cf1e0b6971ed6f7ef86a83b0959b6.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c01ef0533dbe34ec966171ac21d3d6df7);
              break;
          }
        }
        int num2 = updates.Count<ce64fe4baff0b285aaecd02e2cae2ea2c>(predicate);
        return cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93, string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1789), (object) num2, (object) num1));
      }
    }

    public cce1cf1e0b6971ed6f7ef86a83b0959b6(string c407606821fe6034b43e547a4ca232678, TitleId ca1f653cd83e17dfea7eb1317167e710f, string cd47a8862dc253a9ef4c1baa0b8cbdb0a, byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc, DataSize c395088e62cfd02fd835b335ee398e70c, List<ce64fe4baff0b285aaecd02e2cae2ea2c> c1c0fd38914d2630ff1a82119e1950d3c, string c8ea0d2bc63a0d403ae799e873a620804, string cfb63332989391b98905b7a94ebf04984, string cc1c44caa4197df0c6f6003dbdc9ec527, string cd6d3c2c981fd22369f3efc24e5ed5fa1, Platform c52c8dc350dc0c0e6bc024a39734e6231, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
      : base(c407606821fe6034b43e547a4ca232678, ca1f653cd83e17dfea7eb1317167e710f, cd47a8862dc253a9ef4c1baa0b8cbdb0a, c9d02e186a6ec2baccf2d2d1ffb9a59dc, c395088e62cfd02fd835b335ee398e70c, cd6d3c2c981fd22369f3efc24e5ed5fa1, cf48069439fdaca88d5122269390eb989)
    {
      this.EshopId = c8ea0d2bc63a0d403ae799e873a620804;
      this.IconUrl = cc1c44caa4197df0c6f6003dbdc9ec527;
      this.ProductId = cfb63332989391b98905b7a94ebf04984;
      this.Updates = c1c0fd38914d2630ff1a82119e1950d3c;
      this.Platform = c52c8dc350dc0c0e6bc024a39734e6231;
    }

    public List<SaveDescription> cc92e9063ce7b3dea6513edf1666bf319()
    {
      List<SaveDescription> saveDescriptionList = new List<SaveDescription>();
      if (Directory.Exists(this.c81c9ebcab7e87d87b3e99d7df2c1b1eb))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.cc92e9063ce7b3dea6513edf1666bf319);
            }
            IEnumerable<FileInfo> source = new DirectoryInfo(this.c81c9ebcab7e87d87b3e99d7df2c1b1eb).EnumerateFiles();
            // ISSUE: reference to a compiler-generated field
            Func<FileInfo, bool> predicate = cce1cf1e0b6971ed6f7ef86a83b0959b6.\u003C\u003Ec.c24cc264d4f2980d53aaaa8f528066c55;
            if (predicate == null)
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  predicate = cce1cf1e0b6971ed6f7ef86a83b0959b6.\u003C\u003Ec.c24cc264d4f2980d53aaaa8f528066c55 = new Func<FileInfo, bool>(cce1cf1e0b6971ed6f7ef86a83b0959b6.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c3e31b4e4debb2a0d937ba368d3f10485);
                  break;
              }
            }
            IEnumerator<FileInfo> enumerator = source.Where<FileInfo>(predicate).GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                FileInfo current = enumerator.Current;
                try
                {
                  FileStream fileStream = System.IO.File.Open(current.FullName, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(192));
                  try
                  {
                    ZipArchive zipArchive = new ZipArchive((Stream) fileStream, (ZipArchiveMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(196));
                    try
                    {
                      StreamReader streamReader = new StreamReader(zipArchive.GetEntry(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1569)).Open());
                      try
                      {
                        saveDescriptionList.Add(JsonConvert.DeserializeObject<SaveDescription>(streamReader.ReadToEnd()));
                      }
                      finally
                      {
                        if (streamReader != null)
                        {
label_15:
                          switch (5)
                          {
                            case 0:
                              goto label_15;
                            default:
                              streamReader.Dispose();
                              break;
                          }
                        }
                      }
                    }
                    finally
                    {
                      if (zipArchive != null)
                      {
label_19:
                        switch (7)
                        {
                          case 0:
                            goto label_19;
                          default:
                            zipArchive.Dispose();
                            break;
                        }
                      }
                    }
                  }
                  finally
                  {
                    if (fileStream != null)
                    {
label_23:
                      switch (3)
                      {
                        case 0:
                          goto label_23;
                        default:
                          fileStream.Dispose();
                          break;
                      }
                    }
                  }
                }
                catch
                {
                }
              }
label_28:
              switch (4)
              {
                case 0:
                  goto label_28;
              }
            }
            finally
            {
              if (enumerator != null)
              {
label_30:
                switch (7)
                {
                  case 0:
                    goto label_30;
                  default:
                    enumerator.Dispose();
                    break;
                }
              }
            }
        }
      }
      return saveDescriptionList;
    }

    public void c5c286a0a03836226fa1828dd64728e88(IPAddress cc993020431218dd1868140562b121eea, string cf5dabd31a6c1c97006e22153160c9e81)
    {
      if (!Directory.Exists(this.c81c9ebcab7e87d87b3e99d7df2c1b1eb))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.c5c286a0a03836226fa1828dd64728e88);
            }
            Directory.CreateDirectory(this.c81c9ebcab7e87d87b3e99d7df2c1b1eb);
            break;
        }
      }
      string c33ad1bd311fd4b32b85377e9e15a9d93 = ((long) DateTime.UtcNow.Subtract(new DateTime(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(224), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(228), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(232))).TotalSeconds).ToString();
      string str1 = Path.Combine(this.c81c9ebcab7e87d87b3e99d7df2c1b1eb, cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1599)));
      try
      {
        cebcb894f95824d04686ff6457fffe6f6.c511b6ca6e77b32ed7196fd2769163cb7((cba6aa8f767d2e8dfbca2d43d7148c173) this, cc993020431218dd1868140562b121eea, str1);
      }
      catch
      {
        if (System.IO.File.Exists(str1))
        {
label_8:
          switch (4)
          {
            case 0:
              goto label_8;
            default:
              System.IO.File.Delete(str1);
              break;
          }
        }
        throw;
      }
      if (!System.IO.File.Exists(str1))
        return;
label_12:
      switch (2)
      {
        case 0:
          goto label_12;
        default:
          FileStream fileStream = System.IO.File.Open(str1, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(236), (FileAccess) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(240));
          try
          {
            ZipArchive zipArchive = new ZipArchive((Stream) fileStream, (ZipArchiveMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(244));
            try
            {
              StreamWriter streamWriter = new StreamWriter(zipArchive.CreateEntry(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1569)).Open());
              try
              {
                SaveDescription saveDescription = new SaveDescription();
                saveDescription.Description = cf5dabd31a6c1c97006e22153160c9e81;
                saveDescription.Timestamp = c33ad1bd311fd4b32b85377e9e15a9d93;
                string region = this.Region;
                saveDescription.Region = region;
                string name = this.Name;
                saveDescription.Name = name;
                string idRaw = this.TitleId.IdRaw;
                saveDescription.TitleId = idRaw;
                string str2 = JsonConvert.SerializeObject((object) saveDescription);
                streamWriter.Write(str2);
                break;
              }
              finally
              {
                if (streamWriter != null)
                {
label_18:
                  switch (3)
                  {
                    case 0:
                      goto label_18;
                    default:
                      streamWriter.Dispose();
                      break;
                  }
                }
              }
            }
            finally
            {
              if (zipArchive != null)
              {
label_22:
                switch (4)
                {
                  case 0:
                    goto label_22;
                  default:
                    zipArchive.Dispose();
                    break;
                }
              }
            }
          }
          finally
          {
            if (fileStream != null)
            {
label_26:
              switch (2)
              {
                case 0:
                  goto label_26;
                default:
                  fileStream.Dispose();
                  break;
              }
            }
          }
      }
    }

    public void c8437a524abfdc6166da7d43f19b1b01f(IPAddress cc993020431218dd1868140562b121eea, string cb66fa020f0a564c521f45c45a1a89383)
    {
      string cbc474cc35735e4b53e351da14c803500 = Path.Combine(this.c81c9ebcab7e87d87b3e99d7df2c1b1eb, cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(cb66fa020f0a564c521f45c45a1a89383, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1599)));
      cebcb894f95824d04686ff6457fffe6f6.c8fb9e99bf156aede0447a0cb9aa01934((cba6aa8f767d2e8dfbca2d43d7148c173) this, cc993020431218dd1868140562b121eea, cbc474cc35735e4b53e351da14c803500);
    }

    public static DriveInfo ca075787b36b06b9d1b25036d8fd4559d(DataSize c395088e62cfd02fd835b335ee398e70c)
    {
      ce14b607699e6a65abad7d2ea38b8725a ce14b607699e6a65abad7d2ea38b8725a = new ce14b607699e6a65abad7d2ea38b8725a(c395088e62cfd02fd835b335ee398e70c);
      if (((Form) ce14b607699e6a65abad7d2ea38b8725a).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(248))
        return (DriveInfo) null;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.ca075787b36b06b9d1b25036d8fd4559d);
          }
          return ce14b607699e6a65abad7d2ea38b8725a.c4d595b6fd113bbabb11c077e4814d125;
      }
    }

    public void ce9797d2d22ac7c2f896a63451420d43d(Action<c0c29f108584f137c614f55b15004c742, cce1cf1e0b6971ed6f7ef86a83b0959b6> c9b0daebe412d054fc6163e9f4238ba50)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      new Thread(new ThreadStart(new cce1cf1e0b6971ed6f7ef86a83b0959b6.c556fc9072173374d306e6c9943df117f()
      {
        ccb669e105f1c11f33e60c076fc8cca42 = this,
        c9b0daebe412d054fc6163e9f4238ba50 = c9b0daebe412d054fc6163e9f4238ba50
      }.c1b66cfbe12999e32cb533edd88788920)).Start();
    }

    public bool cd2d93bc97fb6620c2b12a80a66e62291(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      if (c36dd98eb0c08ea087627a40c6663c9a8 != this)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.cd2d93bc97fb6620c2b12a80a66e62291);
            }
            if (this.c2485b5906efc569b1c867e5c900b2e4e)
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  if (c36dd98eb0c08ea087627a40c6663c9a8 != this.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>())
                  {
label_7:
                    switch (5)
                    {
                      case 0:
                        goto label_7;
                    }
                  }
                  else
                    goto label_12;
              }
            }
            if (!this.cf062de84cde10d9e953c8091a0e1b42b)
              return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(252) != 0;
label_9:
            switch (6)
            {
              case 0:
                goto label_9;
              default:
                return c36dd98eb0c08ea087627a40c6663c9a8 == this.Dlc;
            }
        }
      }
label_12:
      return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(256) != 0;
    }

    public override string ToString()
    {
      string format = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1810);
      object[] objArray = c75c1f93673bbfb801467a150b6a0a9b7.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(260));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(264);
      string name = this.Name;
      objArray[index1] = (object) name;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(268);
      // ISSUE: variable of a boxed type
      __Boxed<DataSize> size = (ValueType) this.Size;
      objArray[index2] = (object) size;
      int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(272);
      string region = this.Region;
      objArray[index3] = (object) region;
      int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(276);
      // ISSUE: variable of a boxed type
      __Boxed<int> c38dee32ccaa64d9ac65631acafd39f04 = (ValueType) this.c38dee32ccaa64d9ac65631acafd39f04;
      objArray[index4] = (object) c38dee32ccaa64d9ac65631acafd39f04;
      return string.Format(format, objArray);
    }

    public ca167c1c151adfd56785ba09bfd59360f c9008a71c59aaea253e594b6dc2131318()
    {
      c5ac1c83c6771f1d2ec2730d47af7105b c5ac1c83c6771f1d2ec2730d47af7105b = new c5ac1c83c6771f1d2ec2730d47af7105b(this, (WhatToAction) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(280));
      if (((Form) c5ac1c83c6771f1d2ec2730d47af7105b).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(284))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cce1cf1e0b6971ed6f7ef86a83b0959b6.c9008a71c59aaea253e594b6dc2131318);
            }
            return (ca167c1c151adfd56785ba09bfd59360f) null;
        }
      }
      else
      {
        ca167c1c151adfd56785ba09bfd59360f ca167c1c151adfd56785ba09bfd59360f = new ca167c1c151adfd56785ba09bfd59360f();
        int num1 = c5ac1c83c6771f1d2ec2730d47af7105b.CopyDlc ? 1 : 0;
        ca167c1c151adfd56785ba09bfd59360f.cd3417c2b7b6160d6ba39fd665a563500 = num1 != 0;
        int num2 = c5ac1c83c6771f1d2ec2730d47af7105b.CopyUpdate ? 1 : 0;
        ca167c1c151adfd56785ba09bfd59360f.cec1cee4ccee706b13118e0e0c2415b43 = num2 != 0;
        int num3 = c5ac1c83c6771f1d2ec2730d47af7105b.CopyGame ? 1 : 0;
        ca167c1c151adfd56785ba09bfd59360f.ce6597316994d4dd99ff0504acc6d6648 = num3 != 0;
        List<ce64fe4baff0b285aaecd02e2cae2ea2c> cb917dff3a4bc5ccb946b4a838034a862 = c5ac1c83c6771f1d2ec2730d47af7105b.cb917dff3a4bc5ccb946b4a838034a862;
        ca167c1c151adfd56785ba09bfd59360f.cde4b372b03cbbac0bb98de6e528db6d4 = cb917dff3a4bc5ccb946b4a838034a862;
        return ca167c1c151adfd56785ba09bfd59360f;
      }
    }
  }
}
