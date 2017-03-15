// Decompiled with JetBrains decompiler
// Type: A.c1787c51468b07dafcfbe2abfbc5bb04b
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace A
{
  internal sealed class c1787c51468b07dafcfbe2abfbc5bb04b
  {
    internal volatile bool c98121138e08fe305a49d43c2d31e32da = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(836) != 0;
    private TimeSpan c240001d6c6df2274751f492fbafa772b = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(840));
    private DateTime c1f554a8b9b59f631037340e6a56d40d1 = new DateTime((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(844));
    private DateTime c6835e44cac8cc067fdeca96ce788f9a2 = new DateTime((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(848));
    private DataSize c3307ab98afdd056d6b80df7ac1825a8e = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(852));
    public bool c4700aeff9b13b4b7244deff95e8e8033;
    private const int c8402cd76ec823d7821d6840aa8ac0ba9 = 1;

    public cbd9d23875bab012857e040a881a1cf4c DownloadSpeed { get; private set; } = new cbd9d23875bab012857e040a881a1cf4c((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(824));

    public DataSize TotalDataDownloaded { get; set; } = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(828));

    public DataSize TotalDownloadedCurrentGame { get; set; } = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(832));

    public Exception LastError { get; private set; }

    public ulong MaximumSpeed { get; set; }

    internal event EventHandler<cce0509605dd49f167e15968bcebcf85e> cacb2e6beade608d802439f475aa2171a
    {
      add
      {
        EventHandler<cce0509605dd49f167e15968bcebcf85e> eventHandler = this.cacb2e6beade608d802439f475aa2171a;
        EventHandler<cce0509605dd49f167e15968bcebcf85e> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<cce0509605dd49f167e15968bcebcf85e>>(ref this.cacb2e6beade608d802439f475aa2171a, c5e904606fd01cf624f051eb8df379e32.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (4)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1787c51468b07dafcfbe2abfbc5bb04b.add_cacb2e6beade608d802439f475aa2171a);
            break;
        }
      }
      remove
      {
        EventHandler<cce0509605dd49f167e15968bcebcf85e> eventHandler = this.cacb2e6beade608d802439f475aa2171a;
        EventHandler<cce0509605dd49f167e15968bcebcf85e> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<cce0509605dd49f167e15968bcebcf85e>>(ref this.cacb2e6beade608d802439f475aa2171a, c5e904606fd01cf624f051eb8df379e32.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (4)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1787c51468b07dafcfbe2abfbc5bb04b.remove_cacb2e6beade608d802439f475aa2171a);
            break;
        }
      }
    }

    public void c0b5aa75dde138a808d16485f58cfd187()
    {
      this.c98121138e08fe305a49d43c2d31e32da = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(648) != 0;
    }

    public void c130dfcf0d400f0a9dc246d8eb41ffc01()
    {
      this.TotalDataDownloaded = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(652));
    }

    public byte[] cfe99310765b0f6b96322192129ed2876(string c95e2a07ecd4457dc6dc17d3d63fe63b3)
    {
      HttpWebRequest httpWebRequest = ce6f57d5474e6cfc49a8cf815a40f0eb6.cc8e287d5350b43026d33bb80beb131a0((object) WebRequest.Create(c95e2a07ecd4457dc6dc17d3d63fe63b3));
      if (this.c4700aeff9b13b4b7244deff95e8e8033)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1787c51468b07dafcfbe2abfbc5bb04b.cfe99310765b0f6b96322192129ed2876);
            }
            httpWebRequest.Accept = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3071);
            break;
        }
      }
      httpWebRequest.Method = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3104);
      this.c98121138e08fe305a49d43c2d31e32da = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(656) != 0;
      httpWebRequest.Timeout = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(660);
      WebResponse response = httpWebRequest.GetResponse();
      try
      {
        Stream responseStream = response.GetResponseStream();
        try
        {
          MemoryStream memoryStream = new MemoryStream();
          try
          {
            cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(664);
            int count;
            do
            {
              byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(668));
              count = responseStream.Read(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(672), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
              memoryStream.Write(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(676), count);
              if (this.c98121138e08fe305a49d43c2d31e32da)
              {
label_10:
                switch (4)
                {
                  case 0:
                    goto label_10;
                  default:
                    continue;
                }
              }
              else
                goto label_13;
            }
            while (count > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(680));
label_12:
            switch (5)
            {
              case 0:
                goto label_12;
            }
label_13:
            memoryStream.Flush();
            return memoryStream.ToArray();
          }
          finally
          {
            if (memoryStream != null)
            {
label_15:
              switch (1)
              {
                case 0:
                  goto label_15;
                default:
                  memoryStream.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (responseStream != null)
          {
label_19:
            switch (6)
            {
              case 0:
                goto label_19;
              default:
                responseStream.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (response != null)
        {
label_23:
          switch (5)
          {
            case 0:
              goto label_23;
            default:
              response.Dispose();
              break;
          }
        }
      }
    }

    public void c5f02731f6dde03392e1da59787d3bf48(string c95e2a07ecd4457dc6dc17d3d63fe63b3, string c6137549fa9273d62aada9a197f891199, ulong cdc3bfc6cc44e95cd6b60d3fa3826bd89, c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9 c07efc19a95dba1c8d489bdf0a241ff1b, WebProxy c95fd60ec173f22eb3f4a4bffcea0bd2c, byte[] c0b4208fa44d57e11308b8816c2d771ca = null, byte[] c57e74a2744636b8048786c468c19be38 = null, byte cc4a314a023c5328994ee2c9a3b74ca41 = 0)
    {
      if (c07efc19a95dba1c8d489bdf0a241ff1b == (c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(684))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1787c51468b07dafcfbe2abfbc5bb04b.c5f02731f6dde03392e1da59787d3bf48);
            }
            cdc3bfc6cc44e95cd6b60d3fa3826bd89 = cdc3bfc6cc44e95cd6b60d3fa3826bd89 / (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(688) * (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(692);
            break;
        }
      }
      this.c98121138e08fe305a49d43c2d31e32da = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(696) != 0;
      this.DownloadSpeed = new cbd9d23875bab012857e040a881a1cf4c((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(700));
      this.TotalDataDownloaded = c1b08adba6a0a61a0b8be9e8ac706cf34.c1df95097ffa57d753c5fe1353cf65e86(this.TotalDataDownloaded, new DataSize(cdc3bfc6cc44e95cd6b60d3fa3826bd89));
      this.TotalDownloadedCurrentGame = c1b08adba6a0a61a0b8be9e8ac706cf34.c1df95097ffa57d753c5fe1353cf65e86(this.TotalDownloadedCurrentGame, new DataSize(cdc3bfc6cc44e95cd6b60d3fa3826bd89));
      this.c3307ab98afdd056d6b80df7ac1825a8e = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(704));
      this.c240001d6c6df2274751f492fbafa772b = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(708));
      this.c6835e44cac8cc067fdeca96ce788f9a2 = new DateTime((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(712));
      HttpWebRequest httpWebRequest = ce6f57d5474e6cfc49a8cf815a40f0eb6.cc8e287d5350b43026d33bb80beb131a0((object) WebRequest.Create(c95e2a07ecd4457dc6dc17d3d63fe63b3));
      if (c95fd60ec173f22eb3f4a4bffcea0bd2c != null)
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            httpWebRequest.Proxy = (IWebProxy) c95fd60ec173f22eb3f4a4bffcea0bd2c;
            break;
        }
      }
      httpWebRequest.Method = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3104);
      httpWebRequest.AddRange((long) cdc3bfc6cc44e95cd6b60d3fa3826bd89);
      long ccc4bc0730cf4488d207f1e2381621296 = (long) cdc3bfc6cc44e95cd6b60d3fa3826bd89;
      httpWebRequest.Timeout = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(716);
      httpWebRequest.ReadWriteTimeout = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(720);
      int c030b1c8f29f62c1298386dd17a13eb3c = (int) (cdc3bfc6cc44e95cd6b60d3fa3826bd89 / (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(724));
      WebResponse response = httpWebRequest.GetResponse();
      try
      {
        long c7389a359a3a4bfdc5a86642e84835b06 = response.ContentLength + (long) cdc3bfc6cc44e95cd6b60d3fa3826bd89;
        cb4f286a1ad27ee6e7492825e5ea00661 c0cb2cc3c8ec2a27273c7cabb9024894b = new cb4f286a1ad27ee6e7492825e5ea00661(response.GetResponseStream());
        try
        {
          FileStream fileStream = new FileStream(c6137549fa9273d62aada9a197f891199, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(728), (FileAccess) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(732), (FileShare) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(736));
          try
          {
            fileStream.Seek((long) cdc3bfc6cc44e95cd6b60d3fa3826bd89, (SeekOrigin) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(740));
            while (this.c98121138e08fe305a49d43c2d31e32da)
            {
label_26:
              switch (7)
              {
                case 0:
                  goto label_26;
                default:
                  if (ccc4bc0730cf4488d207f1e2381621296 < c7389a359a3a4bfdc5a86642e84835b06)
                  {
                    byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(744));
                    c0cb2cc3c8ec2a27273c7cabb9024894b.cdae04474aa6e84a6bc0973a77cd67e7b = (long) this.MaximumSpeed;
                    long num = (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(748);
                    long c9fc7a42d443e002aa0d3acfed739f6ff;
                    if (c07efc19a95dba1c8d489bdf0a241ff1b == (c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(752))
                    {
label_13:
                      switch (6)
                      {
                        case 0:
                          goto label_13;
                        default:
                          numArray = c0cb2cc3c8ec2a27273c7cabb9024894b.c36cd4a2bacc924bf7516a05bcbaad8c3((int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
                          if ((int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray) < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(756))
                          {
label_15:
                            switch (3)
                            {
                              case 0:
                                goto label_15;
                              default:
                                throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3111));
                            }
                          }
                          else if (c2588d86df683948e6abcda1b2a034974.c27d633604e642e25b89209d64298ce21(numArray, c0b4208fa44d57e11308b8816c2d771ca, c030b1c8f29f62c1298386dd17a13eb3c, c57e74a2744636b8048786c468c19be38, cc4a314a023c5328994ee2c9a3b74ca41) == (c7a45ac90c7f59eb3c9c267df34f789f4) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(760))
                          {
label_18:
                            switch (5)
                            {
                              case 0:
                                goto label_18;
                              default:
                                throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3156));
                            }
                          }
                          else
                          {
                            c030b1c8f29f62c1298386dd17a13eb3c += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(764);
                            c9fc7a42d443e002aa0d3acfed739f6ff = (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(768);
                            break;
                          }
                      }
                    }
                    else
                      c9fc7a42d443e002aa0d3acfed739f6ff = (long) c0cb2cc3c8ec2a27273c7cabb9024894b.Read(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(772), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
                    ccc4bc0730cf4488d207f1e2381621296 += c9fc7a42d443e002aa0d3acfed739f6ff;
                    if (c9fc7a42d443e002aa0d3acfed739f6ff != 0L)
                    {
label_23:
                      switch (1)
                      {
                        case 0:
                          goto label_23;
                        default:
                          fileStream.Write(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(776), (int) c9fc7a42d443e002aa0d3acfed739f6ff);
                          this.c38bddc513e52c7e19ab8cecfa5a6c735(new cce0509605dd49f167e15968bcebcf85e(c9fc7a42d443e002aa0d3acfed739f6ff, ccc4bc0730cf4488d207f1e2381621296, c7389a359a3a4bfdc5a86642e84835b06));
                          continue;
                      }
                    }
                    else
                      goto label_29;
                  }
                  else
                  {
label_28:
                    switch (6)
                    {
                      case 0:
                        goto label_28;
                      default:
                        goto label_29;
                    }
                  }
              }
            }
label_29:
            fileStream.Flush();
          }
          finally
          {
            if (fileStream != null)
            {
label_31:
              switch (4)
              {
                case 0:
                  goto label_31;
                default:
                  fileStream.Dispose();
                  break;
              }
            }
          }
        }
        finally
        {
          if (c0cb2cc3c8ec2a27273c7cabb9024894b != null)
          {
label_35:
            switch (4)
            {
              case 0:
                goto label_35;
              default:
                c0cb2cc3c8ec2a27273c7cabb9024894b.Dispose();
                break;
            }
          }
        }
      }
      finally
      {
        if (response != null)
        {
label_39:
          switch (4)
          {
            case 0:
              goto label_39;
            default:
              response.Dispose();
              break;
          }
        }
      }
    }

    public string c8bcd354e13406e1beb37ee2eb32909c0(string c95e2a07ecd4457dc6dc17d3d63fe63b3)
    {
      return Encoding.UTF8.GetString(this.cfe99310765b0f6b96322192129ed2876(c95e2a07ecd4457dc6dc17d3d63fe63b3));
    }

    internal static void c8e4c35fed92a50e8c7fb5b0b7a07cbdc(string c95e2a07ecd4457dc6dc17d3d63fe63b3, string c6137549fa9273d62aada9a197f891199, byte[] c0b4208fa44d57e11308b8816c2d771ca, byte[] c57e74a2744636b8048786c468c19be38, IEnumerable<int> c37c71403a7984342453e6a73ab7f352c)
    {
      IEnumerator<int> enumerator = c37c71403a7984342453e6a73ab7f352c.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          long offset = (long) (cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(780) * enumerator.Current);
          HttpWebRequest httpWebRequest = ce6f57d5474e6cfc49a8cf815a40f0eb6.cc8e287d5350b43026d33bb80beb131a0((object) WebRequest.Create(c95e2a07ecd4457dc6dc17d3d63fe63b3));
          string str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3104);
          httpWebRequest.Method = str;
          long range = offset;
          httpWebRequest.AddRange(range);
          WebResponse response = httpWebRequest.GetResponse();
          try
          {
            Stream responseStream = response.GetResponseStream();
            try
            {
              FileStream fileStream = new FileStream(c6137549fa9273d62aada9a197f891199, (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(784), (FileAccess) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(788), (FileShare) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(792));
              try
              {
                fileStream.Seek(offset, (SeekOrigin) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(796));
                byte[] c33ad1bd311fd4b32b85377e9e15a9d93 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(800));
                byte[] numArray = responseStream.c36cd4a2bacc924bf7516a05bcbaad8c3((int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93));
                fileStream.Write(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(804), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
                fileStream.Flush();
              }
              finally
              {
                if (fileStream != null)
                {
label_7:
                  switch (4)
                  {
                    case 0:
                      goto label_7;
                    default:
                      if (1 == 0)
                      {
                        // ISSUE: method reference
                        RuntimeMethodHandle runtimeMethodHandle = __methodref (c1787c51468b07dafcfbe2abfbc5bb04b.c8e4c35fed92a50e8c7fb5b0b7a07cbdc);
                      }
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
label_13:
                switch (7)
                {
                  case 0:
                    goto label_13;
                  default:
                    responseStream.Dispose();
                    break;
                }
              }
            }
          }
          finally
          {
            if (response != null)
            {
label_17:
              switch (5)
              {
                case 0:
                  goto label_17;
                default:
                  response.Dispose();
                  break;
              }
            }
          }
        }
label_21:
        switch (2)
        {
          case 0:
            goto label_21;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_24:
          switch (1)
          {
            case 0:
              goto label_24;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
    }

    internal void c0d0b3fb678a4ae77b7f402328a0d52da()
    {
      this.TotalDownloadedCurrentGame = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(808));
    }

    private void c38bddc513e52c7e19ab8cecfa5a6c735(cce0509605dd49f167e15968bcebcf85e c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      DataSize c33ad1bd311fd4b32b85377e9e15a9d93 = new DataSize((ulong) c9572d7ff9cd6a116e4a6f248ca68a831.cd8195cb10d2c3b7d30051a1f20a12103);
      this.c1f554a8b9b59f631037340e6a56d40d1 = DateTime.Now;
      this.TotalDownloadedCurrentGame = c1b08adba6a0a61a0b8be9e8ac706cf34.c1df95097ffa57d753c5fe1353cf65e86(this.TotalDownloadedCurrentGame, c33ad1bd311fd4b32b85377e9e15a9d93);
      this.TotalDataDownloaded = c1b08adba6a0a61a0b8be9e8ac706cf34.c1df95097ffa57d753c5fe1353cf65e86(this.TotalDataDownloaded, c33ad1bd311fd4b32b85377e9e15a9d93);
      this.c3307ab98afdd056d6b80df7ac1825a8e = c1b08adba6a0a61a0b8be9e8ac706cf34.c1df95097ffa57d753c5fe1353cf65e86(this.c3307ab98afdd056d6b80df7ac1825a8e, c33ad1bd311fd4b32b85377e9e15a9d93);
      this.c240001d6c6df2274751f492fbafa772b = c745d89fddb05a30e8ef1babd26557977.c1df95097ffa57d753c5fe1353cf65e86(DateTime.Now, this.c6835e44cac8cc067fdeca96ce788f9a2);
      if (this.c240001d6c6df2274751f492fbafa772b.TotalSeconds <= cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(812))
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1787c51468b07dafcfbe2abfbc5bb04b.c38bddc513e52c7e19ab8cecfa5a6c735);
            break;
        }
      }
      else
      {
        this.DownloadSpeed = new cbd9d23875bab012857e040a881a1cf4c(this.c3307ab98afdd056d6b80df7ac1825a8e, this.c240001d6c6df2274751f492fbafa772b);
        this.c3307ab98afdd056d6b80df7ac1825a8e = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(820));
        this.c6835e44cac8cc067fdeca96ce788f9a2 = DateTime.Now;
        // ISSUE: reference to a compiler-generated field
        EventHandler<cce0509605dd49f167e15968bcebcf85e> cacb2e6beade608d802439f475aa2171a = this.cacb2e6beade608d802439f475aa2171a;
        if (cacb2e6beade608d802439f475aa2171a == null)
        {
label_5:
          switch (5)
          {
            case 0:
              goto label_5;
          }
        }
        else
        {
          cce0509605dd49f167e15968bcebcf85e e = c9572d7ff9cd6a116e4a6f248ca68a831;
          cacb2e6beade608d802439f475aa2171a((object) this, e);
        }
      }
    }

    public enum ce84a4208254784277dfd28133c1498c9
    {
      cf2a4f7f1728d6c7efff8518707e59c97,
      c3eff61705e74c2852db238c9ee389897,
    }
  }
}
