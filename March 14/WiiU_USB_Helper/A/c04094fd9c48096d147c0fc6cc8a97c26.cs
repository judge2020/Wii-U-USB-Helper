// Decompiled with JetBrains decompiler
// Type: A.c04094fd9c48096d147c0fc6cc8a97c26
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;

namespace A
{
  internal class c04094fd9c48096d147c0fc6cc8a97c26
  {
    private readonly int c47a9146d1014bb72cd47d1d86f478946 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1056);
    private volatile bool cd528e9653c3e99bcf8a9c0618be3d70c;
    private FtpWebRequest cf9ab7e2d200ed1dbb4d85b42bc23c907;
    private FtpWebResponse c251e4e79667dce2b7e0d303888793f82;
    private Stream c726221599dd0a14b16c3b3676f2d0048;
    private string c1657f8056cf5faa10d7576214d31759f;
    private string c982200975a4743f36bcca3ea92e0ce62;
    private string ccde54a3bb79d33ec851620ec7cedfdd1;

    public c9d5fc374dcd742d4aee7811bbe7ee2e1 TransferStatus { get; private set; } = new c9d5fc374dcd742d4aee7811bbe7ee2e1(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3307), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1048) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1052));

    public event EventHandler<long> c4c08c39a077a638c4b79d4fc8b3bb982
    {
      add
      {
        EventHandler<long> eventHandler = this.c4c08c39a077a638c4b79d4fc8b3bb982;
        EventHandler<long> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.c4c08c39a077a638c4b79d4fc8b3bb982, c35ebbdc0ef6c536668ed8f7ac5a9c99d.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (1)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.add_c4c08c39a077a638c4b79d4fc8b3bb982);
            break;
        }
      }
      remove
      {
        EventHandler<long> eventHandler = this.c4c08c39a077a638c4b79d4fc8b3bb982;
        EventHandler<long> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.c4c08c39a077a638c4b79d4fc8b3bb982, c35ebbdc0ef6c536668ed8f7ac5a9c99d.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (7)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.remove_c4c08c39a077a638c4b79d4fc8b3bb982);
            break;
        }
      }
    }

    public event EventHandler cbdde249c8efe2db9f4c800e918171ca4
    {
      add
      {
        EventHandler eventHandler = this.cbdde249c8efe2db9f4c800e918171ca4;
        EventHandler comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.cbdde249c8efe2db9f4c800e918171ca4, ccec4ca58265155a131af0c4ef76e5c60.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (7)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.add_cbdde249c8efe2db9f4c800e918171ca4);
            break;
        }
      }
      remove
      {
        EventHandler eventHandler = this.cbdde249c8efe2db9f4c800e918171ca4;
        EventHandler comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.cbdde249c8efe2db9f4c800e918171ca4, ccec4ca58265155a131af0c4ef76e5c60.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (2)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.remove_cbdde249c8efe2db9f4c800e918171ca4);
            break;
        }
      }
    }

    public c04094fd9c48096d147c0fc6cc8a97c26(string c12c23f5f95a9ea7b138eb817663c73f9, string c39b18e88e1df776d3d30e6520bff3f7e, string cfb6ea09e97f9d6d70a9eaaeb395b8a5b)
    {
      this.c1657f8056cf5faa10d7576214d31759f = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3340), c12c23f5f95a9ea7b138eb817663c73f9);
      this.ccde54a3bb79d33ec851620ec7cedfdd1 = c39b18e88e1df776d3d30e6520bff3f7e;
      this.c982200975a4743f36bcca3ea92e0ce62 = cfb6ea09e97f9d6d70a9eaaeb395b8a5b;
    }

    public void cf8139dc61d96e4a9ff8b1dc5cf060de9()
    {
      this.TransferStatus = new c9d5fc374dcd742d4aee7811bbe7ee2e1(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3190), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(868) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(872));
      this.cd528e9653c3e99bcf8a9c0618be3d70c = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(876) != 0;
    }

    public bool caa5178323cfcbb426e4cf0a8f58e6e73()
    {
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3221));
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907.Timeout = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(880);
      try
      {
        this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
      }
      catch (Exception ex)
      {
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(884) != 0;
      }
      finally
      {
        FtpWebResponse c251e4e79667dce2b7e0d303888793f82 = this.c251e4e79667dce2b7e0d303888793f82;
        if (c251e4e79667dce2b7e0d303888793f82 == null)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.caa5178323cfcbb426e4cf0a8f58e6e73);
              }
              break;
          }
        }
        else
          c251e4e79667dce2b7e0d303888793f82.Close();
      }
      return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(888) != 0;
    }

    public void ca9c1bc9739b4b81bba62ac0261bb028a(string c2a83b55f8e1425908da87fdb83039c9e)
    {
      try
      {
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c2a83b55f8e1425908da87fdb83039c9e, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3230));
        this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
        this.c251e4e79667dce2b7e0d303888793f82.Close();
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public void ca0f0ce4a1c83bf79f0422b8a25b09420(string ce2427b9ed5cc18fdd43c8aa287deeb36)
    {
      try
      {
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(ce2427b9ed5cc18fdd43c8aa287deeb36, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3237));
        this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
        this.c251e4e79667dce2b7e0d303888793f82.Close();
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public List<string> c34f0899e3d6a177675473e2188e353e9(string c6fbaa3632df796ac87418d1d25616c78)
    {
      List<string> stringList1 = new List<string>();
      try
      {
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c6fbaa3632df796ac87418d1d25616c78, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3221));
        FtpWebResponse ftpWebResponse = this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
        try
        {
          Stream stream = this.c726221599dd0a14b16c3b3676f2d0048 = this.c251e4e79667dce2b7e0d303888793f82.GetResponseStream();
          try
          {
            StreamReader streamReader = new StreamReader(this.c726221599dd0a14b16c3b3676f2d0048);
            try
            {
              List<string> stringList2 = stringList1;
              string end = streamReader.ReadToEnd();
              string[] separator = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(892));
              int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(896);
              string newLine = Environment.NewLine;
              separator[index] = newLine;
              int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(900);
              string[] strArray = end.Split(separator, (StringSplitOptions) num);
              stringList2.AddRange((IEnumerable<string>) strArray);
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.ToString());
            }
            finally
            {
              if (streamReader != null)
              {
label_7:
                switch (2)
                {
                  case 0:
                    goto label_7;
                  default:
                    if (1 == 0)
                    {
                      // ISSUE: method reference
                      RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c34f0899e3d6a177675473e2188e353e9);
                    }
                    streamReader.Dispose();
                    break;
                }
              }
            }
          }
          finally
          {
            if (stream != null)
            {
label_13:
              switch (1)
              {
                case 0:
                  goto label_13;
                default:
                  stream.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (ftpWebResponse != null)
          {
label_17:
            switch (1)
            {
              case 0:
                goto label_17;
              default:
                ftpWebResponse.Dispose();
                break;
            }
          }
        }
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        return stringList1;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      return stringList1;
    }

    public void c8b39d3db1677ce855c3723d93d97bed5(string c6fbaa3632df796ac87418d1d25616c78, string c87c3d2a609d07eb52c0fd1f9c3239541)
    {
      FileStream fileStream = System.IO.File.Create(c87c3d2a609d07eb52c0fd1f9c3239541);
      try
      {
        ZipArchive c87c3d2a609d07eb52c0fd1f9c3239541_1 = new ZipArchive((Stream) fileStream, (ZipArchiveMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(904));
        try
        {
          this.cfd1a309254cc808f5890e43f137c02e9(c6fbaa3632df796ac87418d1d25616c78, c87c3d2a609d07eb52c0fd1f9c3239541_1, "");
        }
        finally
        {
          if (c87c3d2a609d07eb52c0fd1f9c3239541_1 != null)
          {
label_4:
            switch (2)
            {
              case 0:
                goto label_4;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c8b39d3db1677ce855c3723d93d97bed5);
                }
                c87c3d2a609d07eb52c0fd1f9c3239541_1.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (fileStream != null)
        {
label_10:
          switch (7)
          {
            case 0:
              goto label_10;
            default:
              fileStream.Dispose();
              break;
          }
        }
      }
    }

    public void c5f4444185fc7474cb2691fc9fc4fac52(string c2822f4360754691c182735fb151143a5, string c90ecf8c568e33c598057d6c4893308fb)
    {
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c2822f4360754691c182735fb151143a5, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3246));
      FtpWebResponse ftpWebResponse = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
      try
      {
        Stream responseStream = ftpWebResponse.GetResponseStream();
        try
        {
          FileStream fileStream = new FileStream(c90ecf8c568e33c598057d6c4893308fb, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(908));
          try
          {
            byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(this.c47a9146d1014bb72cd47d1d86f478946);
            int count = responseStream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(912), this.c47a9146d1014bb72cd47d1d86f478946);
            try
            {
              for (; count > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(924); count = responseStream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(920), this.c47a9146d1014bb72cd47d1d86f478946))
                fileStream.Write(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(916), count);
label_7:
              switch (2)
              {
                case 0:
                  goto label_7;
                default:
                  if (1 == 0)
                  {
                    // ISSUE: method reference
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c5f4444185fc7474cb2691fc9fc4fac52);
                    break;
                  }
                  break;
              }
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.ToString());
            }
          }
          finally
          {
            if (fileStream != null)
            {
label_12:
              switch (5)
              {
                case 0:
                  goto label_12;
                default:
                  fileStream.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (responseStream != null)
          {
label_16:
            switch (5)
            {
              case 0:
                goto label_16;
              default:
                responseStream.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (ftpWebResponse != null)
        {
label_20:
          switch (2)
          {
            case 0:
              goto label_20;
            default:
              ftpWebResponse.Dispose();
              break;
          }
        }
      }
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    public void cfd1a309254cc808f5890e43f137c02e9(string c6fbaa3632df796ac87418d1d25616c78, ZipArchive c87c3d2a609d07eb52c0fd1f9c3239541, string c6913cb3477be2a511351a11ed60d2faf)
    {
      using (List<string>.Enumerator enumerator = this.c34f0899e3d6a177675473e2188e353e9(c6fbaa3632df796ac87418d1d25616c78).GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          string current = enumerator.Current;
          string str = Path.Combine(c6913cb3477be2a511351a11ed60d2faf, current);
          if (c04094fd9c48096d147c0fc6cc8a97c26.cf01f5a9e534681208f2245321ff1e118(current))
          {
label_3:
            switch (3)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.cfd1a309254cc808f5890e43f137c02e9);
                }
                this.cfd1a309254cc808f5890e43f137c02e9(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(Path.Combine(c6fbaa3632df796ac87418d1d25616c78, current), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241)), c87c3d2a609d07eb52c0fd1f9c3239541, str);
                continue;
            }
          }
          else
            this.c5f4444185fc7474cb2691fc9fc4fac52(Path.Combine(c6fbaa3632df796ac87418d1d25616c78, current), c87c3d2a609d07eb52c0fd1f9c3239541, str);
        }
label_9:
        switch (7)
        {
          case 0:
            goto label_9;
        }
      }
    }

    public string c262d2bb792413133f8869e5b2fe0e97a(string c577dd1a8f414bdf4c694f7c9e3ef4cbb)
    {
      try
      {
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c577dd1a8f414bdf4c694f7c9e3ef4cbb, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3255));
        this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
        this.c726221599dd0a14b16c3b3676f2d0048 = this.c251e4e79667dce2b7e0d303888793f82.GetResponseStream();
        StreamReader streamReader = new StreamReader(this.c726221599dd0a14b16c3b3676f2d0048);
        string str = cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        try
        {
          str = streamReader.ReadToEnd();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
        }
        streamReader.Close();
        this.c726221599dd0a14b16c3b3676f2d0048.Close();
        this.c251e4e79667dce2b7e0d303888793f82.Close();
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        return str;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      return "";
    }

    public string cc12ebcdc7d285fc61aa31e2bd4a7e6a5(string c577dd1a8f414bdf4c694f7c9e3ef4cbb)
    {
      try
      {
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c577dd1a8f414bdf4c694f7c9e3ef4cbb, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3264));
        this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
        this.c726221599dd0a14b16c3b3676f2d0048 = this.c251e4e79667dce2b7e0d303888793f82.GetResponseStream();
        StreamReader streamReader = new StreamReader(this.c726221599dd0a14b16c3b3676f2d0048);
        string str = cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        try
        {
          while (streamReader.Peek() != cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(928))
            str = streamReader.ReadToEnd();
label_4:
          switch (3)
          {
            case 0:
              goto label_4;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.cc12ebcdc7d285fc61aa31e2bd4a7e6a5);
                break;
              }
              break;
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
        }
        streamReader.Close();
        this.c726221599dd0a14b16c3b3676f2d0048.Close();
        this.c251e4e79667dce2b7e0d303888793f82.Close();
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        return str;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      return "";
    }

    public void cd395f43c7b4aed52f1eab3336b46d09d(string c2520861fbcb28967a4556a89c4431680, string c9364c870bc590db7bc31494ca727cbe5)
    {
      try
      {
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c9364c870bc590db7bc31494ca727cbe5, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3273));
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907.RenameTo = c9364c870bc590db7bc31494ca727cbe5;
        this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
        this.c251e4e79667dce2b7e0d303888793f82.Close();
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public void c9c0adb229f51515bcd4e3d625df2cca5()
    {
      try
      {
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6("", c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3286));
        this.c251e4e79667dce2b7e0d303888793f82 = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
        this.c251e4e79667dce2b7e0d303888793f82.Close();
        this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public void c7e9a1a89ad511eff9ee78dcc872bf0b0(string c2822f4360754691c182735fb151143a5, ZipArchiveEntry ccc5b7a75b49697be2f86a8c41c8ef464)
    {
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c2822f4360754691c182735fb151143a5, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3295));
      Stream requestStream = this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetRequestStream();
      try
      {
        Stream stream = ccc5b7a75b49697be2f86a8c41c8ef464.Open();
        try
        {
          byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(this.c47a9146d1014bb72cd47d1d86f478946);
          int count = stream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(932), this.c47a9146d1014bb72cd47d1d86f478946);
          try
          {
            while (count != 0)
            {
label_6:
              switch (1)
              {
                case 0:
                  goto label_6;
                default:
                  if (1 == 0)
                  {
                    // ISSUE: method reference
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c7e9a1a89ad511eff9ee78dcc872bf0b0);
                  }
                  if (!this.cd528e9653c3e99bcf8a9c0618be3d70c)
                  {
                    requestStream.Write(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(936), count);
                    count = stream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(940), this.c47a9146d1014bb72cd47d1d86f478946);
                    this.cd99fa2d129e91a242e3a692f95805d63((long) count);
                    continue;
                  }
label_10:
                  switch (1)
                  {
                    case 0:
                      goto label_10;
                    default:
                      goto label_22;
                  }
              }
            }
          }
          catch (Exception ex)
          {
            if (c9d21716677494f54265a78ebb0c71eb9.cc50e3aad2c922bb7d7e65938629ab7b5((object) ex) == null)
            {
label_12:
              switch (1)
              {
                case 0:
                  goto label_12;
                default:
                  this.TransferStatus = new c9d5fc374dcd742d4aee7811bbe7ee2e1(ex.Message, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(944) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(948));
                  break;
              }
            }
          }
        }
        finally
        {
          if (stream != null)
          {
label_15:
            switch (6)
            {
              case 0:
                goto label_15;
              default:
                stream.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (requestStream != null)
        {
label_19:
          switch (6)
          {
            case 0:
              goto label_19;
            default:
              requestStream.Dispose();
              break;
          }
        }
      }
label_22:
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    public void c7e9a1a89ad511eff9ee78dcc872bf0b0(string c2822f4360754691c182735fb151143a5, string c90ecf8c568e33c598057d6c4893308fb)
    {
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c2822f4360754691c182735fb151143a5, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3295));
      Stream requestStream = this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetRequestStream();
      try
      {
        FileStream fileStream = new FileStream(c90ecf8c568e33c598057d6c4893308fb, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(952));
        try
        {
          byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(this.c47a9146d1014bb72cd47d1d86f478946);
          int count = fileStream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(956), this.c47a9146d1014bb72cd47d1d86f478946);
          try
          {
            while (count != 0)
            {
label_6:
              switch (6)
              {
                case 0:
                  goto label_6;
                default:
                  if (1 == 0)
                  {
                    // ISSUE: method reference
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c7e9a1a89ad511eff9ee78dcc872bf0b0);
                  }
                  if (!this.cd528e9653c3e99bcf8a9c0618be3d70c)
                  {
                    requestStream.Write(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(960), count);
                    count = fileStream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(964), this.c47a9146d1014bb72cd47d1d86f478946);
                    this.cd99fa2d129e91a242e3a692f95805d63((long) count);
                    continue;
                  }
label_10:
                  switch (5)
                  {
                    case 0:
                      goto label_10;
                    default:
                      goto label_22;
                  }
              }
            }
          }
          catch (Exception ex)
          {
            if (c9d21716677494f54265a78ebb0c71eb9.cc50e3aad2c922bb7d7e65938629ab7b5((object) ex) == null)
            {
label_12:
              switch (4)
              {
                case 0:
                  goto label_12;
                default:
                  this.TransferStatus = new c9d5fc374dcd742d4aee7811bbe7ee2e1(ex.Message, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(968) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(972));
                  break;
              }
            }
          }
        }
        finally
        {
          if (fileStream != null)
          {
label_15:
            switch (5)
            {
              case 0:
                goto label_15;
              default:
                fileStream.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (requestStream != null)
        {
label_19:
          switch (2)
          {
            case 0:
              goto label_19;
            default:
              requestStream.Dispose();
              break;
          }
        }
      }
label_22:
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    public void c095cd7bbf623afbcb447f02cc3fccf44(string cd77edac42519e037e492eeff371fd283, ZipArchive c304f0c59f8dabe63096431c21840354a)
    {
      this.ca9c1bc9739b4b81bba62ac0261bb028a(cd77edac42519e037e492eeff371fd283);
      List<string> stringList = new List<string>();
      IEnumerator<ZipArchiveEntry> enumerator1 = c304f0c59f8dabe63096431c21840354a.Entries.GetEnumerator();
      try
      {
        while (enumerator1.MoveNext())
        {
          string directoryName = Path.GetDirectoryName(enumerator1.Current.FullName);
          if (!stringList.Contains(directoryName))
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
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c095cd7bbf623afbcb447f02cc3fccf44);
                }
                stringList.Add(directoryName);
                string str1 = directoryName;
                char[] chArray = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(976));
                int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(980);
                int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(984);
                chArray[index1] = (char) num;
                string[] strArray = str1.Split(chArray);
                string str2 = cd77edac42519e037e492eeff371fd283;
                string[] c33ad1bd311fd4b32b85377e9e15a9d93_1 = strArray;
                int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(988);
                while (index2 < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93_1))
                {
                  string c33ad1bd311fd4b32b85377e9e15a9d93_2 = c33ad1bd311fd4b32b85377e9e15a9d93_1[index2];
                  str2 = c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(str2, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241), c33ad1bd311fd4b32b85377e9e15a9d93_2);
                  this.ca9c1bc9739b4b81bba62ac0261bb028a(str2);
                  index2 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(992);
                }
label_9:
                switch (4)
                {
                  case 0:
                    goto label_9;
                  default:
                    continue;
                }
            }
          }
        }
label_11:
        switch (3)
        {
          case 0:
            goto label_11;
        }
      }
      finally
      {
        if (enumerator1 != null)
        {
label_13:
          switch (3)
          {
            case 0:
              goto label_13;
            default:
              enumerator1.Dispose();
              break;
          }
        }
      }
      IEnumerator<ZipArchiveEntry> enumerator2 = c304f0c59f8dabe63096431c21840354a.Entries.GetEnumerator();
      try
      {
        while (enumerator2.MoveNext())
        {
          ZipArchiveEntry current = enumerator2.Current;
          if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(current.FullName, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1569)))
          {
label_19:
            switch (1)
            {
              case 0:
                goto label_19;
              default:
                string str = Path.Combine(cd77edac42519e037e492eeff371fd283, current.FullName.Replace(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3304), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241)));
                if (!c04094fd9c48096d147c0fc6cc8a97c26.cf01f5a9e534681208f2245321ff1e118(str))
                {
label_21:
                  switch (3)
                  {
                    case 0:
                      goto label_21;
                    default:
                      this.c7e9a1a89ad511eff9ee78dcc872bf0b0(str, current);
                      continue;
                  }
                }
                else
                  continue;
            }
          }
        }
label_24:
        switch (5)
        {
          case 0:
            goto label_24;
        }
      }
      finally
      {
        if (enumerator2 != null)
        {
label_27:
          switch (2)
          {
            case 0:
              goto label_27;
            default:
              enumerator2.Dispose();
              break;
          }
        }
      }
    }

    public void c2843f10415d25d6e73f1e461c3504951(string cd77edac42519e037e492eeff371fd283, string ccfbb9d344c54858673dc9a7a9aa0db0d)
    {
      FileInfo[] files = new DirectoryInfo(ccfbb9d344c54858673dc9a7a9aa0db0d).GetFiles();
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(996);
      while (index < (int) c2b6234da605e6ef3f8efa302cc198535.c572aba370be49804cbdb0b35312bea94(files))
      {
        FileInfo fileInfo = files[index];
        if (!this.cd528e9653c3e99bcf8a9c0618be3d70c)
        {
label_2:
          switch (5)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c2843f10415d25d6e73f1e461c3504951);
              }
              try
              {
                this.c7e9a1a89ad511eff9ee78dcc872bf0b0(Path.Combine(cd77edac42519e037e492eeff371fd283, fileInfo.Name), fileInfo.FullName);
              }
              catch (Exception ex)
              {
                this.TransferStatus = new c9d5fc374dcd742d4aee7811bbe7ee2e1(ex.Message, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1000) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1004));
              }
              index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1008);
              continue;
          }
        }
        else
          goto label_11;
      }
label_10:
      switch (6)
      {
        case 0:
          goto label_10;
      }
label_11:
      this.c9c0adb229f51515bcd4e3d625df2cca5();
      // ISSUE: reference to a compiler-generated field
      EventHandler cbdde249c8efe2db9f4c800e918171ca4 = this.cbdde249c8efe2db9f4c800e918171ca4;
      if (cbdde249c8efe2db9f4c800e918171ca4 == null)
      {
label_12:
        switch (5)
        {
          case 0:
            goto label_12;
        }
      }
      else
      {
        EventArgs c20c00b8e97bb4c0fb2b7ac6facf98b91 = c3978a42df3e901949e27aa5a5768ff04.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        cbdde249c8efe2db9f4c800e918171ca4((object) this, c20c00b8e97bb4c0fb2b7ac6facf98b91);
      }
    }

    public void c5883efd4c9664470f8e935e4af5f9504(string cd77edac42519e037e492eeff371fd283, string ccfbb9d344c54858673dc9a7a9aa0db0d)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Thread thread = new Thread(new ThreadStart(new c04094fd9c48096d147c0fc6cc8a97c26.cc23ae8b26fc63c3ae4d299a2cc93e616()
      {
        ccb669e105f1c11f33e60c076fc8cca42 = this,
        cd77edac42519e037e492eeff371fd283 = cd77edac42519e037e492eeff371fd283,
        ccfbb9d344c54858673dc9a7a9aa0db0d = ccfbb9d344c54858673dc9a7a9aa0db0d
      }.c730edf835197b7a49a33adfc88e5f98c));
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1012);
      thread.IsBackground = num != 0;
      thread.Start();
    }

    private static bool cf01f5a9e534681208f2245321ff1e118(string ca07972acde10926c077adb10e0e60439)
    {
      return cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(Path.GetExtension(ca07972acde10926c077adb10e0e60439), string.Empty);
    }

    private FtpWebRequest cb54c6fd12da56fbe39c4902c549f3ab6(string c2822f4360754691c182735fb151143a5, string cd1c22e14162b6937c74122e0e3549f6c)
    {
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = cf409401214588d27275613b23cb1ee0c.cc8e287d5350b43026d33bb80beb131a0((object) WebRequest.Create(c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(this.c1657f8056cf5faa10d7576214d31759f, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241), c2822f4360754691c182735fb151143a5)));
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907.Credentials = (ICredentials) new NetworkCredential(this.ccde54a3bb79d33ec851620ec7cedfdd1, this.c982200975a4743f36bcca3ea92e0ce62);
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907.UseBinary = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1016) != 0;
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907.UsePassive = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1020) != 0;
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907.KeepAlive = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1024) != 0;
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907.Method = cd1c22e14162b6937c74122e0e3549f6c;
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907.Timeout = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1028);
      return this.cf9ab7e2d200ed1dbb4d85b42bc23c907;
    }

    private void c5f4444185fc7474cb2691fc9fc4fac52(string c2822f4360754691c182735fb151143a5, ZipArchive c304f0c59f8dabe63096431c21840354a, string cd882bdfcde69377e6616f3b1f8b305c6)
    {
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = this.cb54c6fd12da56fbe39c4902c549f3ab6(c2822f4360754691c182735fb151143a5, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3246));
      FtpWebResponse ftpWebResponse = ceaf1b992c2813313944864deeda8dead.cc8e287d5350b43026d33bb80beb131a0((object) this.cf9ab7e2d200ed1dbb4d85b42bc23c907.GetResponse());
      try
      {
        Stream responseStream = ftpWebResponse.GetResponseStream();
        try
        {
          Stream stream = c304f0c59f8dabe63096431c21840354a.CreateEntry(cd882bdfcde69377e6616f3b1f8b305c6).Open();
          try
          {
            byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(this.c47a9146d1014bb72cd47d1d86f478946);
            int count = responseStream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1032), this.c47a9146d1014bb72cd47d1d86f478946);
            try
            {
              for (; count > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1044); count = responseStream.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1040), this.c47a9146d1014bb72cd47d1d86f478946))
                stream.Write(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1036), count);
label_7:
              switch (2)
              {
                case 0:
                  goto label_7;
                default:
                  if (1 == 0)
                  {
                    // ISSUE: method reference
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.c5f4444185fc7474cb2691fc9fc4fac52);
                    break;
                  }
                  break;
              }
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.ToString());
            }
          }
          finally
          {
            if (stream != null)
            {
label_12:
              switch (6)
              {
                case 0:
                  goto label_12;
                default:
                  stream.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (responseStream != null)
          {
label_16:
            switch (7)
            {
              case 0:
                goto label_16;
              default:
                responseStream.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (ftpWebResponse != null)
        {
label_20:
          switch (7)
          {
            case 0:
              goto label_20;
            default:
              ftpWebResponse.Dispose();
              break;
          }
        }
      }
      this.cf9ab7e2d200ed1dbb4d85b42bc23c907 = c0ed9f9150e9d273d02b22485fb2ac326.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    private void cd99fa2d129e91a242e3a692f95805d63(long c0a3512c3067db548f04cacafc1355ee2)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<long> c4c08c39a077a638c4b79d4fc8b3bb982 = this.c4c08c39a077a638c4b79d4fc8b3bb982;
      if (c4c08c39a077a638c4b79d4fc8b3bb982 == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c04094fd9c48096d147c0fc6cc8a97c26.cd99fa2d129e91a242e3a692f95805d63);
            }
            break;
        }
      }
      else
      {
        long e = c0a3512c3067db548f04cacafc1355ee2;
        c4c08c39a077a638c4b79d4fc8b3bb982((object) this, e);
      }
    }
  }
}
