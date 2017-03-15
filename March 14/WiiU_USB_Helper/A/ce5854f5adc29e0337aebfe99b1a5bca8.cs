// Decompiled with JetBrains decompiler
// Type: A.ce5854f5adc29e0337aebfe99b1a5bca8
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;
using NusHelper.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace A
{
  internal static class ce5854f5adc29e0337aebfe99b1a5bca8
  {
    private static List<string> cd4d4c7ba92dcaa2aaf13cbb09eb13f69 = new List<string>();
    private static ZipArchive c596c8f9796b97969a6f9523caa7a0ada = c90f926c711eace1bc7dc6b5d504657f7.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    internal static string cb15a68fade93b1826672d59de27db300;

    public static void c65035f1404133de248e0c7c2f45a2015(cc6dede17deea63b67c3e0eb84bf12bb3 c5a5bec978796537a0d12234195422a66)
    {
      if (ce5854f5adc29e0337aebfe99b1a5bca8.cd4d4c7ba92dcaa2aaf13cbb09eb13f69.Contains(c5a5bec978796537a0d12234195422a66.Name))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ce5854f5adc29e0337aebfe99b1a5bca8.c65035f1404133de248e0c7c2f45a2015);
            break;
        }
      }
      else
      {
        try
        {
          MemoryStream memoryStream = new MemoryStream(new WebClient().DownloadData(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6532), (object) ce5854f5adc29e0337aebfe99b1a5bca8.cb15a68fade93b1826672d59de27db300, (object) c5a5bec978796537a0d12234195422a66.Name)));
          try
          {
            string c04b4e6eaf974f76e23c9533b68fbee41 = c5a5bec978796537a0d12234195422a66.c04b4e6eaf974f76e23c9533b68fbee41;
            ZipArchive c304f0c59f8dabe63096431c21840354a = new ZipArchive((Stream) memoryStream);
            try
            {
              c304f0c59f8dabe63096431c21840354a.c1ef43517fe46d1aae09999031095582d(c04b4e6eaf974f76e23c9533b68fbee41, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7592) != 0);
            }
            finally
            {
              if (c304f0c59f8dabe63096431c21840354a != null)
              {
label_8:
                switch (6)
                {
                  case 0:
                    goto label_8;
                  default:
                    c304f0c59f8dabe63096431c21840354a.Dispose();
                    break;
                }
              }
            }
          }
          finally
          {
            if (memoryStream != null)
            {
label_13:
              switch (5)
              {
                case 0:
                  goto label_13;
                default:
                  memoryStream.Dispose();
                  break;
              }
            }
          }
          ce5854f5adc29e0337aebfe99b1a5bca8.cd4d4c7ba92dcaa2aaf13cbb09eb13f69.Add(c5a5bec978796537a0d12234195422a66.Name);
        }
        catch
        {
        }
      }
    }

    public static string ce83efcfc372f32421bf32ee8b6cecd16()
    {
      return new WebClient().DownloadString(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6583), (object) ce5854f5adc29e0337aebfe99b1a5bca8.cb15a68fade93b1826672d59de27db300));
    }

    public static string c1e514ac30a4b56c9748b3ce62a5a469a()
    {
      return new WebClient().DownloadString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6634));
    }

    public static void c7f03fa9bb757fa534920cd996453263b()
    {
      if (ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada == null)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ce5854f5adc29e0337aebfe99b1a5bca8.c7f03fa9bb757fa534920cd996453263b);
            break;
        }
      }
      else
      {
        ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada.Dispose();
        ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada = c90f926c711eace1bc7dc6b5d504657f7.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
    }

    private static void c640618ad16ed20426b905e12873f7e3e()
    {
      if (ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada != null)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ce5854f5adc29e0337aebfe99b1a5bca8.c640618ad16ed20426b905e12873f7e3e);
            break;
        }
      }
      else
        ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada = new ZipArchive((Stream) new MemoryStream(new WebClient().DownloadData(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6749), (object) ce5854f5adc29e0337aebfe99b1a5bca8.cb15a68fade93b1826672d59de27db300))));
    }

    private static string c8f5d4b7b8097bfabcda636cb4772c3dc(this ZipArchiveEntry ccc5b7a75b49697be2f86a8c41c8ef464)
    {
      TextReader textReader = (TextReader) new StreamReader(ccc5b7a75b49697be2f86a8c41c8ef464.Open());
      try
      {
        return textReader.ReadToEnd();
      }
      finally
      {
        if (textReader != null)
        {
label_3:
          switch (1)
          {
            case 0:
              goto label_3;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (ce5854f5adc29e0337aebfe99b1a5bca8.c8f5d4b7b8097bfabcda636cb4772c3dc);
              }
              textReader.Dispose();
              break;
          }
        }
      }
    }

    public static void c0214ec4c13f796bcbdce789486041ca5(string ca07972acde10926c077adb10e0e60439)
    {
      ce5854f5adc29e0337aebfe99b1a5bca8.c640618ad16ed20426b905e12873f7e3e();
      IEnumerator<DbRow> enumerator = JsonConvert.DeserializeObject<IEnumerable<DbRow>>(ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada.GetEntry(ca07972acde10926c077adb10e0e60439).c8f5d4b7b8097bfabcda636cb4772c3dc()).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          DbRow current = enumerator.Current;
          if (!ca377ebace9a9e1ffac7b0c5a9158e838.c9b242add560e8c892442a59369df92f3.ContainsKey(current.TitleId))
          {
label_3:
            switch (2)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (ce5854f5adc29e0337aebfe99b1a5bca8.c0214ec4c13f796bcbdce789486041ca5);
                }
                ca377ebace9a9e1ffac7b0c5a9158e838.c9b242add560e8c892442a59369df92f3.Add(current.TitleId, new c2e2f19e8cde9983e4129b4a047c9f5c6.cf960775278a7e7028668e3ca5dd866d1()
                {
                  c64ccfce653a8bd2c7c7ffb6b8d91766f = current.Size,
                  c27f5df1dc5d80dd0c87cd29e7cef11b8 = current.TitleId
                });
                continue;
            }
          }
        }
label_8:
        switch (1)
        {
          case 0:
            goto label_8;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_11:
          switch (2)
          {
            case 0:
              goto label_11;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
    }

    public static void ceae08d24d0dbe36cdaaee1ada2839662(string ca07972acde10926c077adb10e0e60439)
    {
      ce5854f5adc29e0337aebfe99b1a5bca8.c640618ad16ed20426b905e12873f7e3e();
      IEnumerator<DbRow> enumerator = JsonConvert.DeserializeObject<IEnumerable<DbRow>>(ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada.GetEntry(ca07972acde10926c077adb10e0e60439).c8f5d4b7b8097bfabcda636cb4772c3dc()).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          DbRow current = enumerator.Current;
          ca377ebace9a9e1ffac7b0c5a9158e838.c6cb7f1dc1e8dcf6340fd2d8879ea2986.Add(current.TitleId, current);
        }
label_4:
        switch (1)
        {
          case 0:
            goto label_4;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ce5854f5adc29e0337aebfe99b1a5bca8.ceae08d24d0dbe36cdaaee1ada2839662);
            break;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_9:
          switch (5)
          {
            case 0:
              goto label_9;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
    }

    public static void c7178752d228151f6af4c89b8f576c144(string ca07972acde10926c077adb10e0e60439)
    {
      ce5854f5adc29e0337aebfe99b1a5bca8.c640618ad16ed20426b905e12873f7e3e();
      IEnumerator<DbRow> enumerator = JsonConvert.DeserializeObject<IEnumerable<DbRow>>(ce5854f5adc29e0337aebfe99b1a5bca8.c596c8f9796b97969a6f9523caa7a0ada.GetEntry(ca07972acde10926c077adb10e0e60439).c8f5d4b7b8097bfabcda636cb4772c3dc()).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          DbRow current = enumerator.Current;
          if (!ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574.ContainsKey(current.TitleId))
          {
label_3:
            switch (1)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (ce5854f5adc29e0337aebfe99b1a5bca8.c7178752d228151f6af4c89b8f576c144);
                }
                ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574.Add(current.TitleId, new List<c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224>());
                break;
            }
          }
          ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574[current.TitleId].Add(new c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224()
          {
            c64ccfce653a8bd2c7c7ffb6b8d91766f = current.Size,
            c27f5df1dc5d80dd0c87cd29e7cef11b8 = current.TitleId,
            c907ca8ffa30661318a7e29e77519ea57 = current.Version
          });
        }
label_9:
        switch (5)
        {
          case 0:
            goto label_9;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_12:
          switch (3)
          {
            case 0:
              goto label_12;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
    }

    public static string[] c1e27c0dc1c60ab8daa499958f09057fc()
    {
      string str = new WebClient().DownloadString(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6788), (object) ce5854f5adc29e0337aebfe99b1a5bca8.cb15a68fade93b1826672d59de27db300));
      string[] separator = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7596));
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7600);
      string newLine = Environment.NewLine;
      separator[index] = newLine;
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7604);
      return str.Split(separator, (StringSplitOptions) num);
    }
  }
}
