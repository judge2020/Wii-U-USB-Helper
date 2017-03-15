// Decompiled with JetBrains decompiler
// Type: A.c2e2f19e8cde9983e4129b4a047c9f5c6
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace A
{
  public sealed class c2e2f19e8cde9983e4129b4a047c9f5c6 : IDisposable
  {
    private volatile bool c98121138e08fe305a49d43c2d31e32da = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1400) != 0;
    private readonly c1787c51468b07dafcfbe2abfbc5bb04b cfdbc00290f9a2617783a0caa76803ce4 = new c1787c51468b07dafcfbe2abfbc5bb04b();
    private volatile bool c298a69d7f984777878b3936eca6b7d44 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1404) != 0;
    private TimeSpan c8b201ed08a7e267f9cb88025238d9efd = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1408));
    private TimeSpan c5c8bf6422ca66783e52a629fda4e241d = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1412));
    private DataSize c4fa3aaa8644e447de6ff8c8694b343af = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1416));
    private DataSize c663ca8762f0c0ed5fd3c6d31cbc33d8d = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1420));
    private DateTime c2f3e36c9b99b1e79ac276030c411aeaa = DateTime.MinValue;
    public int c228748f2f48ebe809fc8b8da8e874ee7;
    private const int cef4d90b8a0dcbd2e365f7d5fd7fba686 = 1;
    private List<cba6aa8f767d2e8dfbca2d43d7148c173> c2b20f3705a59037621be04b7f458bb6d;
    private bool cd61d164adaa2fd3a52759b1736ae4947;
    private cbd9d23875bab012857e040a881a1cf4c c6a461a219d82299312681f235c5bb94f;
    private TimeSpan cba4be6d7c5d21ffdb112fbad41f013f0;
    private int c827a85d17e8f7066f9e60736e754017a;
    private int c8657fef6fae0fd7fff26ecab361d2ca2;
    private bool cb33f3ce3ce41ea6319b249210f2b8ee0;
    private int c2853be4118c9ee30af7cc03fb8989ef0;

    public WebProxy Proxy { get; set; }

    public event EventHandler<string> ca7b3d3646c1ef6f0d20e46cd000e997a
    {
      add
      {
        EventHandler<string> eventHandler = this.ca7b3d3646c1ef6f0d20e46cd000e997a;
        EventHandler<string> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.ca7b3d3646c1ef6f0d20e46cd000e997a, cca6a2dc0744ec9ccbfcc5b97e4172f03.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.add_ca7b3d3646c1ef6f0d20e46cd000e997a);
            break;
        }
      }
      remove
      {
        EventHandler<string> eventHandler = this.ca7b3d3646c1ef6f0d20e46cd000e997a;
        EventHandler<string> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.ca7b3d3646c1ef6f0d20e46cd000e997a, cca6a2dc0744ec9ccbfcc5b97e4172f03.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.remove_ca7b3d3646c1ef6f0d20e46cd000e997a);
            break;
        }
      }
    }

    public event EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4> ce805193897570a50f04c96b162564f8f
    {
      add
      {
        EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4> eventHandler = this.ce805193897570a50f04c96b162564f8f;
        EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4>>(ref this.ce805193897570a50f04c96b162564f8f, cd0c16f0815ce104353e116af526c8edb.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (6)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.add_ce805193897570a50f04c96b162564f8f);
            break;
        }
      }
      remove
      {
        EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4> eventHandler = this.ce805193897570a50f04c96b162564f8f;
        EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4>>(ref this.ce805193897570a50f04c96b162564f8f, cd0c16f0815ce104353e116af526c8edb.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.remove_ce805193897570a50f04c96b162564f8f);
            break;
        }
      }
    }

    public event EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> c60346b7eb87c5b6c53ae83177066862b
    {
      add
      {
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> eventHandler = this.c60346b7eb87c5b6c53ae83177066862b;
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1>>(ref this.c60346b7eb87c5b6c53ae83177066862b, ca408cbeba71e5c7363d19a2e923c7a15.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (5)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.add_c60346b7eb87c5b6c53ae83177066862b);
            break;
        }
      }
      remove
      {
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> eventHandler = this.c60346b7eb87c5b6c53ae83177066862b;
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1>>(ref this.c60346b7eb87c5b6c53ae83177066862b, ca408cbeba71e5c7363d19a2e923c7a15.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.remove_c60346b7eb87c5b6c53ae83177066862b);
            break;
        }
      }
    }

    public event EventHandler<cdf40c9764a014ff068a86edd8ace4556> cacb2e6beade608d802439f475aa2171a
    {
      add
      {
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> eventHandler = this.cacb2e6beade608d802439f475aa2171a;
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<cdf40c9764a014ff068a86edd8ace4556>>(ref this.cacb2e6beade608d802439f475aa2171a, c5aecac2c863682cde0d9124db3d790db.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.add_cacb2e6beade608d802439f475aa2171a);
            break;
        }
      }
      remove
      {
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> eventHandler = this.cacb2e6beade608d802439f475aa2171a;
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<cdf40c9764a014ff068a86edd8ace4556>>(ref this.cacb2e6beade608d802439f475aa2171a, c5aecac2c863682cde0d9124db3d790db.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.remove_cacb2e6beade608d802439f475aa2171a);
            break;
        }
      }
    }

    public c2e2f19e8cde9983e4129b4a047c9f5c6(WebProxy c95fd60ec173f22eb3f4a4bffcea0bd2c, bool c0cde769ce8b24fa94cfc4c7282b3e156)
    {
      this.Proxy = c95fd60ec173f22eb3f4a4bffcea0bd2c;
      this.cfdbc00290f9a2617783a0caa76803ce4.cacb2e6beade608d802439f475aa2171a += new EventHandler<cce0509605dd49f167e15968bcebcf85e>(this.c08544bc79440c40e33d3f54328488359);
      NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(this.c2f246b4713764812207eb08fd27362f8);
      this.cd61d164adaa2fd3a52759b1736ae4947 = c0cde769ce8b24fa94cfc4c7282b3e156;
    }

    ~c2e2f19e8cde9983e4129b4a047c9f5c6()
    {
      this.c22706695d1a9686d352d2bbbb66af499(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1120) != 0);
    }

    public void cede7d54d5e26788af0d6a69eca29fa85()
    {
      this.c98121138e08fe305a49d43c2d31e32da = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1060) != 0;
    }

    public void cd8b923b0d22ab0a178b88c37e9d3994a(List<cba6aa8f767d2e8dfbca2d43d7148c173> c8081e7b23c9b7a2c1932218177f9033b, int c15a9bc40a3108519ac5699b6c3ff504b = 100, int cceacb25f65612e1fd95a145daa4c731a = 10000)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Thread thread = new Thread(new ThreadStart(new c2e2f19e8cde9983e4129b4a047c9f5c6.cc9357eb23a4f828fe4260bce580b160b()
      {
        ccb669e105f1c11f33e60c076fc8cca42 = this,
        c8081e7b23c9b7a2c1932218177f9033b = c8081e7b23c9b7a2c1932218177f9033b,
        c15a9bc40a3108519ac5699b6c3ff504b = c15a9bc40a3108519ac5699b6c3ff504b,
        cceacb25f65612e1fd95a145daa4c731a = cceacb25f65612e1fd95a145daa4c731a
      }.cbefcce46edc48d018878612599a5aa6c));
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1064);
      thread.IsBackground = num != 0;
      thread.Start();
    }

    private void c0fb18e9d24e742375cdc4e6495681c9f(List<cba6aa8f767d2e8dfbca2d43d7148c173> c8081e7b23c9b7a2c1932218177f9033b)
    {
      this.c4fa3aaa8644e447de6ff8c8694b343af = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1068));
      this.c5c8bf6422ca66783e52a629fda4e241d = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1072));
      this.c8b201ed08a7e267f9cb88025238d9efd = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1076));
      this.c6a461a219d82299312681f235c5bb94f = new cbd9d23875bab012857e040a881a1cf4c((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1080));
      this.c663ca8762f0c0ed5fd3c6d31cbc33d8d = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1084));
      this.c2b20f3705a59037621be04b7f458bb6d = c8081e7b23c9b7a2c1932218177f9033b;
      this.c3a2a56c07789f3efbf5efbd6ef8ea3f5();
      int c228748f2f48ebe809fc8b8da8e874ee7 = this.c228748f2f48ebe809fc8b8da8e874ee7;
      while (c228748f2f48ebe809fc8b8da8e874ee7 < c8081e7b23c9b7a2c1932218177f9033b.Count)
      {
        // ISSUE: reference to a compiler-generated field
        EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4> ce805193897570a50f04c96b162564f8f = this.ce805193897570a50f04c96b162564f8f;
        if (ce805193897570a50f04c96b162564f8f == null)
        {
label_2:
          switch (7)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.c0fb18e9d24e742375cdc4e6495681c9f);
              }
              break;
          }
        }
        else
        {
          c7f5d91bc3961f40a7d6fb86e445fe3a4 e = new c7f5d91bc3961f40a7d6fb86e445fe3a4(c8081e7b23c9b7a2c1932218177f9033b[c228748f2f48ebe809fc8b8da8e874ee7], c228748f2f48ebe809fc8b8da8e874ee7);
          ce805193897570a50f04c96b162564f8f((object) this, e);
        }
        this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3353), (object) (this.c228748f2f48ebe809fc8b8da8e874ee7 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1088)), (object) c8081e7b23c9b7a2c1932218177f9033b.Count));
        int num = this.ce27c00764646de6f4d4aeae5b6a54cd5(c8081e7b23c9b7a2c1932218177f9033b[c228748f2f48ebe809fc8b8da8e874ee7]) == (c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1092) ? 1 : 0;
        c8081e7b23c9b7a2c1932218177f9033b[c228748f2f48ebe809fc8b8da8e874ee7].CurrentlyDownloaded = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1096) != 0;
        c8081e7b23c9b7a2c1932218177f9033b[c228748f2f48ebe809fc8b8da8e874ee7].ca5649281440802bb4aae634896917d91();
        if (num == 0)
        {
label_8:
          switch (1)
          {
            case 0:
              goto label_8;
            default:
              return;
          }
        }
        else if (!this.c98121138e08fe305a49d43c2d31e32da)
        {
label_11:
          switch (3)
          {
            case 0:
              goto label_11;
            default:
              return;
          }
        }
        else
        {
          this.c228748f2f48ebe809fc8b8da8e874ee7 = this.c228748f2f48ebe809fc8b8da8e874ee7 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1100);
          c228748f2f48ebe809fc8b8da8e874ee7 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1104);
        }
      }
label_15:
      switch (7)
      {
        case 0:
          goto label_15;
      }
    }

    public void c3a2a56c07789f3efbf5efbd6ef8ea3f5()
    {
      this.c663ca8762f0c0ed5fd3c6d31cbc33d8d = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1108));
      using (List<cba6aa8f767d2e8dfbca2d43d7148c173>.Enumerator enumerator = this.c2b20f3705a59037621be04b7f458bb6d.GetEnumerator())
      {
        while (enumerator.MoveNext())
          this.c663ca8762f0c0ed5fd3c6d31cbc33d8d = c1b08adba6a0a61a0b8be9e8ac706cf34.c1df95097ffa57d753c5fe1353cf65e86(this.c663ca8762f0c0ed5fd3c6d31cbc33d8d, this.c5acec3be4b5f89479fbba2abbbbdbbf6(enumerator.Current, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1112) != 0).c96156587eb364978ad5a188620ce8cec);
label_4:
        switch (6)
        {
          case 0:
            goto label_4;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.c3a2a56c07789f3efbf5efbd6ef8ea3f5);
              break;
            }
            break;
        }
      }
      this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3434), (object) this.c663ca8762f0c0ed5fd3c6d31cbc33d8d));
    }

    public void ccca69f3508da99605b80cc92c45f56bb(ulong c671aaf4f714f01fb2ce91badf6ede298)
    {
      this.cfdbc00290f9a2617783a0caa76803ce4.MaximumSpeed = c671aaf4f714f01fb2ce91badf6ede298;
    }

    public void Dispose()
    {
      this.c22706695d1a9686d352d2bbbb66af499(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1116) != 0);
      GC.SuppressFinalize((object) this);
    }

    private static int ced8387ade389cd60272293a2558a4364(DataSize cb241bfa7a546a83bcdc9bb72a7dff1b1, DataSize c0f844dfc65d78960b0b2faadb7898c95)
    {
      int num = (int) Math.Floor((double) c0f844dfc65d78960b0b2faadb7898c95.TotalBytes / (double) cb241bfa7a546a83bcdc9bb72a7dff1b1.TotalBytes * cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(1124));
      if (num < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1132))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.ced8387ade389cd60272293a2558a4364);
            }
            num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1136);
            break;
        }
      }
      if (num > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1140))
      {
label_6:
        switch (2)
        {
          case 0:
            goto label_6;
          default:
            num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1144);
            break;
        }
      }
      return num;
    }

    public static int ced8387ade389cd60272293a2558a4364(long c95d4953467d4cb51a13f3ded39a0fc62, long ce73ad97252a237b60f697c07927da222)
    {
      if (ce73ad97252a237b60f697c07927da222 == 0L)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.ced8387ade389cd60272293a2558a4364);
            }
            return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1148);
        }
      }
      else
      {
        int num = (int) Math.Floor((double) c95d4953467d4cb51a13f3ded39a0fc62 / (double) ce73ad97252a237b60f697c07927da222 * cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(1152));
        if (num < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1160))
        {
label_6:
          switch (1)
          {
            case 0:
              goto label_6;
            default:
              num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1164);
              break;
          }
        }
        if (num > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1168))
        {
label_9:
          switch (1)
          {
            case 0:
              goto label_9;
            default:
              num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1172);
              break;
          }
        }
        return num;
      }
    }

    private void ca9421c3af47f4e9ba32891eda2b04b0c(string c19de1cc86d37bd2abca9c0f07f35feb4)
    {
      this.cfdbc00290f9a2617783a0caa76803ce4.c0b5aa75dde138a808d16485f58cfd187();
      throw new cd2f044317b8351417a6ddcd59b1fb481(c19de1cc86d37bd2abca9c0f07f35feb4);
    }

    private void c22706695d1a9686d352d2bbbb66af499(bool c5c8455317717a4ae1fd04f0fba6f4bee)
    {
      this.cb33f3ce3ce41ea6319b249210f2b8ee0 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1176) != 0;
    }

    private void c2f246b4713764812207eb08fd27362f8(object c5382ad5461e274fda51b358802fc3910, NetworkAvailabilityEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c298a69d7f984777878b3936eca6b7d44 = c9572d7ff9cd6a116e4a6f248ca68a831.IsAvailable;
    }

    private void c08544bc79440c40e33d3f54328488359(object c5382ad5461e274fda51b358802fc3910, cce0509605dd49f167e15968bcebcf85e c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      c1787c51468b07dafcfbe2abfbc5bb04b c1787c51468b07dafcfbe2abfbc5bb04b = c715971c4c70e46ebcfcc7e99bf2f595c.cc8e287d5350b43026d33bb80beb131a0(c5382ad5461e274fda51b358802fc3910);
      if (!this.c298a69d7f984777878b3936eca6b7d44)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.c08544bc79440c40e33d3f54328488359);
            }
            this.ca9421c3af47f4e9ba32891eda2b04b0c(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3485));
            break;
        }
      }
      if (!this.c98121138e08fe305a49d43c2d31e32da)
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
          default:
            this.cfdbc00290f9a2617783a0caa76803ce4.c0b5aa75dde138a808d16485f58cfd187();
            break;
        }
      }
      this.c6a461a219d82299312681f235c5bb94f = c1787c51468b07dafcfbe2abfbc5bb04b.DownloadSpeed;
      try
      {
        this.c8b201ed08a7e267f9cb88025238d9efd = c3396223b6b12dc01b64bb7afa266307e.c1df95097ffa57d753c5fe1353cf65e86(this.c4fa3aaa8644e447de6ff8c8694b343af.Diff(c1787c51468b07dafcfbe2abfbc5bb04b.TotalDownloadedCurrentGame), this.c6a461a219d82299312681f235c5bb94f);
        this.c5c8bf6422ca66783e52a629fda4e241d = c3396223b6b12dc01b64bb7afa266307e.c1df95097ffa57d753c5fe1353cf65e86(this.c663ca8762f0c0ed5fd3c6d31cbc33d8d.Diff(c1787c51468b07dafcfbe2abfbc5bb04b.TotalDataDownloaded), this.c6a461a219d82299312681f235c5bb94f);
        this.cba4be6d7c5d21ffdb112fbad41f013f0 = c3396223b6b12dc01b64bb7afa266307e.c1df95097ffa57d753c5fe1353cf65e86(new DataSize((ulong) c9572d7ff9cd6a116e4a6f248ca68a831.c4a678d3420df887f38c4b7b806c92ed9).Diff(new DataSize((ulong) c9572d7ff9cd6a116e4a6f248ca68a831.cb32d701bbe9ba5aeb8c53e327ef7438b)), this.c6a461a219d82299312681f235c5bb94f);
        this.c8657fef6fae0fd7fff26ecab361d2ca2 = c2e2f19e8cde9983e4129b4a047c9f5c6.ced8387ade389cd60272293a2558a4364(this.c4fa3aaa8644e447de6ff8c8694b343af, c1787c51468b07dafcfbe2abfbc5bb04b.TotalDownloadedCurrentGame);
        this.c2853be4118c9ee30af7cc03fb8989ef0 = c2e2f19e8cde9983e4129b4a047c9f5c6.ced8387ade389cd60272293a2558a4364(this.c663ca8762f0c0ed5fd3c6d31cbc33d8d, c1787c51468b07dafcfbe2abfbc5bb04b.TotalDataDownloaded);
        this.c827a85d17e8f7066f9e60736e754017a = (int) ((double) c9572d7ff9cd6a116e4a6f248ca68a831.cb32d701bbe9ba5aeb8c53e327ef7438b / (double) c9572d7ff9cd6a116e4a6f248ca68a831.c4a678d3420df887f38c4b7b806c92ed9 * cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(1180));
        this.c2766b636f6ad26a17259faeb4a9dd9fc(this.c8657fef6fae0fd7fff26ecab361d2ca2, this.c2853be4118c9ee30af7cc03fb8989ef0, this.c827a85d17e8f7066f9e60736e754017a, this.c8b201ed08a7e267f9cb88025238d9efd, this.c5c8bf6422ca66783e52a629fda4e241d, this.cba4be6d7c5d21ffdb112fbad41f013f0, this.c6a461a219d82299312681f235c5bb94f, ca8f39da86e7b333d7240f7f58b938e54.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      }
      catch
      {
      }
    }

    private void c6ac298cc3e17b7fa1b0a14e89065e97b(cff72ea250ac36ea03abde33ff61b7565 c907075ebe7f1c4b189f6eae5161c381b, string ce339ec8e4e59ae4d366ecde058dba451)
    {
      this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3510));
      BinaryWriter binaryWriter = new BinaryWriter((Stream) System.IO.File.Open(Path.Combine(ce339ec8e4e59ae4d366ecde058dba451, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2726)), (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1188)));
      try
      {
        binaryWriter.Write(c907075ebe7f1c4b189f6eae5161c381b.Certificate1);
        binaryWriter.Write(c907075ebe7f1c4b189f6eae5161c381b.Certificate2);
        binaryWriter.Write(cff72ea250ac36ea03abde33ff61b7565.c40d1039b6a1304ab16a685f19118f41b);
      }
      finally
      {
        if (binaryWriter != null)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.c6ac298cc3e17b7fa1b0a14e89065e97b);
              }
              binaryWriter.Dispose();
              break;
          }
        }
      }
    }

    private c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027 ca098f3569ff30fc6a7aa88bdd935682e(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, ccc0082396339666e15f34a6614404a47 cc0048e297270ca267c121e581b301b2b, string c577dd1a8f414bdf4c694f7c9e3ef4cbb, c2e2f19e8cde9983e4129b4a047c9f5c6.c9f3a7e2b8919612af3bedd821bbe7079 c9c02db2a164203d42add7670d9b9a606, ulong cfa8908fe7863ff78aa784e63376a3ef6 = 0)
    {
      string c33ad1bd311fd4b32b85377e9e15a9d93_1 = cc0048e297270ca267c121e581b301b2b.ContentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747));
      string c33ad1bd311fd4b32b85377e9e15a9d93_2;
      if (c9c02db2a164203d42add7670d9b9a606 != c2e2f19e8cde9983e4129b4a047c9f5c6.c9f3a7e2b8919612af3bedd821bbe7079.c9873fd1470856dc65f185641b5a8b0bd)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.ca098f3569ff30fc6a7aa88bdd935682e);
            }
            if (!c36dd98eb0c08ea087627a40c6663c9a8.CustomTitle)
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  c33ad1bd311fd4b32b85377e9e15a9d93_2 = "";
                  break;
              }
            }
            else
            {
              c33ad1bd311fd4b32b85377e9e15a9d93_2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752);
              break;
            }
        }
      }
      else
        c33ad1bd311fd4b32b85377e9e15a9d93_2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761);
      string str = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93_1, c33ad1bd311fd4b32b85377e9e15a9d93_2);
      this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3557), (object) str));
      if (this.Proxy != null)
      {
label_10:
        switch (7)
        {
          case 0:
            goto label_10;
          default:
            this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3616), (object) this.Proxy.Address));
            break;
        }
      }
      if (c36dd98eb0c08ea087627a40c6663c9a8.CustomTitle)
      {
label_13:
        switch (5)
        {
          case 0:
            goto label_13;
          default:
            if (c9c02db2a164203d42add7670d9b9a606 == c2e2f19e8cde9983e4129b4a047c9f5c6.c9f3a7e2b8919612af3bedd821bbe7079.c9873fd1470856dc65f185641b5a8b0bd)
            {
label_15:
              switch (4)
              {
                case 0:
                  goto label_15;
                default:
                  this.cfdbc00290f9a2617783a0caa76803ce4.c5f02731f6dde03392e1da59787d3bf48(c9845e9fdb9bb1e03d7debbbd57953daa.ca83128d40ffa17be7a4361e67e85365c(c36dd98eb0c08ea087627a40c6663c9a8, str), cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c577dd1a8f414bdf4c694f7c9e3ef4cbb, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761)), (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1192), (c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1196), this.Proxy, (byte[]) null, (byte[]) null, (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1200));
                  goto label_24;
              }
            }
            else
              break;
        }
      }
      if (c9c02db2a164203d42add7670d9b9a606 == c2e2f19e8cde9983e4129b4a047c9f5c6.c9f3a7e2b8919612af3bedd821bbe7079.c9873fd1470856dc65f185641b5a8b0bd)
      {
label_18:
        switch (5)
        {
          case 0:
            goto label_18;
          default:
            this.cfdbc00290f9a2617783a0caa76803ce4.c5f02731f6dde03392e1da59787d3bf48(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c36dd98eb0c08ea087627a40c6663c9a8.c62c40cf74825a86f2ba018c8a07f11e2, str), cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c577dd1a8f414bdf4c694f7c9e3ef4cbb, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761)), cfa8908fe7863ff78aa784e63376a3ef6, (c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1204), this.Proxy, (byte[]) null, (byte[]) null, (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1208));
            break;
        }
      }
      else if (cc0048e297270ca267c121e581b301b2b.ce7bc51cbabe7bd4fb4dac2e71e260e4f)
      {
label_21:
        switch (1)
        {
          case 0:
            goto label_21;
          default:
            this.cfdbc00290f9a2617783a0caa76803ce4.c5f02731f6dde03392e1da59787d3bf48(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c36dd98eb0c08ea087627a40c6663c9a8.c62c40cf74825a86f2ba018c8a07f11e2, str), cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c577dd1a8f414bdf4c694f7c9e3ef4cbb, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)), cfa8908fe7863ff78aa784e63376a3ef6, (c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1212), this.Proxy, System.IO.File.ReadAllBytes(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c577dd1a8f414bdf4c694f7c9e3ef4cbb, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761))), c36dd98eb0c08ea087627a40c6663c9a8.Ticket.c80d617f05b7f95017df4cba82652d0dd, (byte) cc0048e297270ca267c121e581b301b2b.Index);
            break;
        }
      }
      else
        this.cfdbc00290f9a2617783a0caa76803ce4.c5f02731f6dde03392e1da59787d3bf48(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c36dd98eb0c08ea087627a40c6663c9a8.c62c40cf74825a86f2ba018c8a07f11e2, str), cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c577dd1a8f414bdf4c694f7c9e3ef4cbb, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)), cfa8908fe7863ff78aa784e63376a3ef6, (c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1216), this.Proxy, (byte[]) null, (byte[]) null, (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1220));
label_24:
      if (this.cfdbc00290f9a2617783a0caa76803ce4.c98121138e08fe305a49d43c2d31e32da)
        return (c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1228);
label_25:
      switch (2)
      {
        case 0:
          goto label_25;
        default:
          return (c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1224);
      }
    }

    private c1d5d0d4f9464e1d296ba85cf189ecad6 c730a6652d0d171e3c4dbaa74687473bc(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3647));
      string str = Path.Combine(c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2475));
      if (c50c5ab6d2aca52507a5f6d83f26a1a97.cc50e3aad2c922bb7d7e65938629ab7b5((object) c36dd98eb0c08ea087627a40c6663c9a8) != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.c730a6652d0d171e3c4dbaa74687473bc);
            }
            if (c36dd98eb0c08ea087627a40c6663c9a8.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1232))
            {
label_5:
              switch (4)
              {
                case 0:
                  goto label_5;
                default:
                  this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3684));
                  this.cfdbc00290f9a2617783a0caa76803ce4.c5f02731f6dde03392e1da59787d3bf48(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3739), (object) c36dd98eb0c08ea087627a40c6663c9a8.c62c40cf74825a86f2ba018c8a07f11e2), str, (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1236), (c1787c51468b07dafcfbe2abfbc5bb04b.ce84a4208254784277dfd28133c1498c9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1240), this.Proxy, (byte[]) null, (byte[]) null, (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1244));
                  c36dd98eb0c08ea087627a40c6663c9a8.TicketArray = System.IO.File.ReadAllBytes(str);
                  c36dd98eb0c08ea087627a40c6663c9a8.Ticket = c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(str, c36dd98eb0c08ea087627a40c6663c9a8.System);
                  return c36dd98eb0c08ea087627a40c6663c9a8.Ticket;
              }
            }
            else
              break;
        }
      }
      if (!c36dd98eb0c08ea087627a40c6663c9a8.c01b0607eff3104877812c454678313d9)
      {
label_8:
        switch (6)
        {
          case 0:
            goto label_8;
          default:
            this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3754));
            System.IO.File.WriteAllBytes(str, c36dd98eb0c08ea087627a40c6663c9a8.TicketArray);
            return c36dd98eb0c08ea087627a40c6663c9a8.Ticket;
        }
      }
      else
      {
        this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3789));
        byte[] bytes = this.cfdbc00290f9a2617783a0caa76803ce4.cfe99310765b0f6b96322192129ed2876(c36dd98eb0c08ea087627a40c6663c9a8.c3e44ecba2cc05a921770e798b38b0d77);
        c36dd98eb0c08ea087627a40c6663c9a8.TicketArray = bytes;
        System.IO.File.WriteAllBytes(str, bytes);
        c36dd98eb0c08ea087627a40c6663c9a8.Ticket = c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(c36dd98eb0c08ea087627a40c6663c9a8.TicketArray, c36dd98eb0c08ea087627a40c6663c9a8.System);
        return c36dd98eb0c08ea087627a40c6663c9a8.Ticket;
      }
    }

    private c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027 ce27c00764646de6f4d4aeae5b6a54cd5(cba6aa8f767d2e8dfbca2d43d7148c173 c3cab5319dc016deb050deb101e927b2f)
    {
      this.cfdbc00290f9a2617783a0caa76803ce4.c0d0b3fb678a4ae77b7f402328a0d52da();
      this.c8b201ed08a7e267f9cb88025238d9efd = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1248));
      this.cba4be6d7c5d21ffdb112fbad41f013f0 = new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1252));
      this.c6a461a219d82299312681f235c5bb94f = new cbd9d23875bab012857e040a881a1cf4c((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1256));
      c3cab5319dc016deb050deb101e927b2f.CurrentlyDownloaded = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1260) != 0;
      if (!Directory.Exists(c3cab5319dc016deb050deb101e927b2f.OutputPath))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.ce27c00764646de6f4d4aeae5b6a54cd5);
            }
            Directory.CreateDirectory(c3cab5319dc016deb050deb101e927b2f.OutputPath);
            break;
        }
      }
      cff72ea250ac36ea03abde33ff61b7565 c907075ebe7f1c4b189f6eae5161c381b = this.c5acec3be4b5f89479fbba2abbbbdbbf6(c3cab5319dc016deb050deb101e927b2f, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1264) != 0);
      c1d5d0d4f9464e1d296ba85cf189ecad6 c1d5d0d4f9464e1d296ba85cf189ecad6 = this.c730a6652d0d171e3c4dbaa74687473bc(c3cab5319dc016deb050deb101e927b2f);
      if (c3cab5319dc016deb050deb101e927b2f.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1268))
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            this.c6ac298cc3e17b7fa1b0a14e89065e97b(c907075ebe7f1c4b189f6eae5161c381b, c3cab5319dc016deb050deb101e927b2f.OutputPath);
            break;
        }
      }
      this.c4fa3aaa8644e447de6ff8c8694b343af = c907075ebe7f1c4b189f6eae5161c381b.c96156587eb364978ad5a188620ce8cec;
      this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3856), (object) this.c4fa3aaa8644e447de6ff8c8694b343af));
      this.c2766b636f6ad26a17259faeb4a9dd9fc(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1272), this.c2853be4118c9ee30af7cc03fb8989ef0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1276), this.c8b201ed08a7e267f9cb88025238d9efd, this.c5c8bf6422ca66783e52a629fda4e241d, this.cba4be6d7c5d21ffdb112fbad41f013f0, new cbd9d23875bab012857e040a881a1cf4c((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1280)), c3cab5319dc016deb050deb101e927b2f);
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1284);
      while (index1 < (int) c907075ebe7f1c4b189f6eae5161c381b.NumOfContents)
      {
        if (!this.c98121138e08fe305a49d43c2d31e32da)
        {
label_10:
          switch (5)
          {
            case 0:
              goto label_10;
            default:
              return (c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1288);
          }
        }
        else
        {
          while (true)
          {
            string format = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3895);
            object[] objArray = c75c1f93673bbfb801467a150b6a0a9b7.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1292));
            int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1296);
            // ISSUE: variable of a boxed type
            __Boxed<int> local = (ValueType) (index1 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1300));
            objArray[index2] = (object) local;
            int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1304);
            // ISSUE: variable of a boxed type
            __Boxed<uint> contentId = (ValueType) c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].ContentId;
            objArray[index3] = (object) contentId;
            int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1308);
            // ISSUE: variable of a boxed type
            __Boxed<ushort> numOfContents = (ValueType) c907075ebe7f1c4b189f6eae5161c381b.NumOfContents;
            objArray[index4] = (object) numOfContents;
            int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1312);
            // ISSUE: variable of a boxed type
            __Boxed<DataSize> size = (ValueType) c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].Size;
            objArray[index5] = (object) size;
            this.ce859329e4d96fbd68666fbba38f313cb(string.Format(format, objArray));
            string str = Path.Combine(c3cab5319dc016deb050deb101e927b2f.OutputPath, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].ContentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747)));
            ulong num1 = (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1316);
            if (System.IO.File.Exists(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752))))
            {
label_13:
              switch (2)
              {
                case 0:
                  goto label_13;
                default:
                  num1 = (ulong) new FileInfo(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752))).Length;
                  this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3994));
                  if ((long) num1 == (long) c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].Size.TotalBytes)
                  {
label_15:
                    switch (6)
                    {
                      case 0:
                        goto label_15;
                      default:
                        this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4069));
                        if (c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].ce7bc51cbabe7bd4fb4dac2e71e260e4f)
                        {
label_17:
                          switch (4)
                          {
                            case 0:
                              goto label_17;
                            default:
                              if (!System.IO.File.Exists(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761))))
                              {
label_19:
                                switch (5)
                                {
                                  case 0:
                                    goto label_19;
                                  default:
                                    int num2 = (int) this.ca098f3569ff30fc6a7aa88bdd935682e(c3cab5319dc016deb050deb101e927b2f, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1], str, (c2e2f19e8cde9983e4129b4a047c9f5c6.c9f3a7e2b8919612af3bedd821bbe7079) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1320), (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1324));
                                    break;
                                }
                              }
                              else
                                break;
                          }
                        }
                        caaa166a921d0019973aa328703a03e82 caaa166a921d0019973aa328703a03e82 = c2588d86df683948e6abcda1b2a034974.c9e4c8c42ea50a26d6276799eb717fc27(c3cab5319dc016deb050deb101e927b2f, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1], c1d5d0d4f9464e1d296ba85cf189ecad6.c80d617f05b7f95017df4cba82652d0dd);
                        if (!caaa166a921d0019973aa328703a03e82.c0e379d486d73ea79071e2291e7d54f2b)
                        {
label_22:
                          switch (4)
                          {
                            case 0:
                              goto label_22;
                            default:
                              if (c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].ce7bc51cbabe7bd4fb4dac2e71e260e4f)
                              {
label_24:
                                switch (5)
                                {
                                  case 0:
                                    goto label_24;
                                  default:
                                    this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4130), (object) caaa166a921d0019973aa328703a03e82.c1d53f99644fff009a5829ee8ab7fc8ab.Count, (object) (caaa166a921d0019973aa328703a03e82.c1d53f99644fff009a5829ee8ab7fc8ab.Count * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1328))));
                                    this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4245));
                                    string c33ad1bd311fd4b32b85377e9e15a9d93 = c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].ContentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747));
                                    c1787c51468b07dafcfbe2abfbc5bb04b.c8e4c35fed92a50e8c7fb5b0b7a07cbdc(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c3cab5319dc016deb050deb101e927b2f.c62c40cf74825a86f2ba018c8a07f11e2, c33ad1bd311fd4b32b85377e9e15a9d93), cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)), System.IO.File.ReadAllBytes(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761))), c3cab5319dc016deb050deb101e927b2f.Ticket.c80d617f05b7f95017df4cba82652d0dd, (IEnumerable<int>) caaa166a921d0019973aa328703a03e82.c1d53f99644fff009a5829ee8ab7fc8ab);
                                    continue;
                                }
                              }
                              else
                              {
                                this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4399));
                                System.IO.File.Delete(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)));
                                continue;
                              }
                          }
                        }
                        else
                          goto label_27;
                    }
                  }
                  else if (c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].Size.TotalBytes < num1)
                  {
label_29:
                    switch (3)
                    {
                      case 0:
                        goto label_29;
                      default:
                        this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4596));
                        System.IO.File.Delete(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752)));
                        continue;
                    }
                  }
                  else
                  {
                    this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4736), (object) new DataSize(num1)));
                    break;
                  }
              }
            }
            try
            {
              int num2 = (int) cfdc97586078fe0abfe50aa3f3f0b6a00.c1610d9088efb2cefe9c41d21c5a4cc5d((uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1332));
              this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4817));
              if (c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].ce7bc51cbabe7bd4fb4dac2e71e260e4f)
              {
label_34:
                switch (1)
                {
                  case 0:
                    goto label_34;
                  default:
                    int num3 = (int) this.ca098f3569ff30fc6a7aa88bdd935682e(c3cab5319dc016deb050deb101e927b2f, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1], str, (c2e2f19e8cde9983e4129b4a047c9f5c6.c9f3a7e2b8919612af3bedd821bbe7079) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1336), (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1340));
                    break;
                }
              }
              if (this.ca098f3569ff30fc6a7aa88bdd935682e(c3cab5319dc016deb050deb101e927b2f, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1], str, (c2e2f19e8cde9983e4129b4a047c9f5c6.c9f3a7e2b8919612af3bedd821bbe7079) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1344), num1) == (c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1348))
              {
label_37:
                switch (6)
                {
                  case 0:
                    goto label_37;
                  default:
                    return (c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1352);
                }
              }
              else if (!this.cd61d164adaa2fd3a52759b1736ae4947)
              {
label_40:
                switch (3)
                {
                  case 0:
                    goto label_40;
                  default:
                    goto label_46;
                }
              }
              else
              {
                this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4862));
                if (c2588d86df683948e6abcda1b2a034974.c9e4c8c42ea50a26d6276799eb717fc27(c3cab5319dc016deb050deb101e927b2f, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1], c1d5d0d4f9464e1d296ba85cf189ecad6.c80d617f05b7f95017df4cba82652d0dd).c0e379d486d73ea79071e2291e7d54f2b)
                {
label_42:
                  switch (5)
                  {
                    case 0:
                      goto label_42;
                    default:
                      goto label_46;
                  }
                }
                else
                {
                  c1787c51468b07dafcfbe2abfbc5bb04b cfdbc00290f9a2617783a0caa76803ce4_1 = this.cfdbc00290f9a2617783a0caa76803ce4;
                  DataSize dataSize1 = cb3b3c210b64dbf324f4709adbd2293b7.c1df95097ffa57d753c5fe1353cf65e86(cfdbc00290f9a2617783a0caa76803ce4_1.TotalDataDownloaded, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].Size);
                  cfdbc00290f9a2617783a0caa76803ce4_1.TotalDataDownloaded = dataSize1;
                  c1787c51468b07dafcfbe2abfbc5bb04b cfdbc00290f9a2617783a0caa76803ce4_2 = this.cfdbc00290f9a2617783a0caa76803ce4;
                  DataSize dataSize2 = cb3b3c210b64dbf324f4709adbd2293b7.c1df95097ffa57d753c5fe1353cf65e86(cfdbc00290f9a2617783a0caa76803ce4_2.TotalDownloadedCurrentGame, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].Size);
                  cfdbc00290f9a2617783a0caa76803ce4_2.TotalDownloadedCurrentGame = dataSize2;
                }
              }
            }
            catch (Exception ex)
            {
              this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4905), (object) (index1 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1356)), (object) c907075ebe7f1c4b189f6eae5161c381b.NumOfContents));
              this.ce859329e4d96fbd68666fbba38f313cb(ex.Message);
              c3cab5319dc016deb050deb101e927b2f.CurrentlyDownloaded = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1360) != 0;
              this.ca9421c3af47f4e9ba32891eda2b04b0c(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4988), ex.Message));
              goto label_45;
            }
          }
label_27:
          this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(4535));
          c1787c51468b07dafcfbe2abfbc5bb04b cfdbc00290f9a2617783a0caa76803ce4_3 = this.cfdbc00290f9a2617783a0caa76803ce4;
          DataSize dataSize3 = c5839b4118a820b542e621e778c78cc44.c1df95097ffa57d753c5fe1353cf65e86(cfdbc00290f9a2617783a0caa76803ce4_3.TotalDownloadedCurrentGame, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].Size.TotalBytes);
          cfdbc00290f9a2617783a0caa76803ce4_3.TotalDownloadedCurrentGame = dataSize3;
          c1787c51468b07dafcfbe2abfbc5bb04b cfdbc00290f9a2617783a0caa76803ce4_4 = this.cfdbc00290f9a2617783a0caa76803ce4;
          DataSize dataSize4 = c1b08adba6a0a61a0b8be9e8ac706cf34.c1df95097ffa57d753c5fe1353cf65e86(cfdbc00290f9a2617783a0caa76803ce4_4.TotalDataDownloaded, c907075ebe7f1c4b189f6eae5161c381b.c7294cb7c91944988432faebdd13ef3a8[index1].Size);
          cfdbc00290f9a2617783a0caa76803ce4_4.TotalDataDownloaded = dataSize4;
          goto label_46;
label_45:
          GC.Collect();
label_46:
          index1 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1364);
        }
      }
label_48:
      switch (3)
      {
        case 0:
          goto label_48;
        default:
          this.ce859329e4d96fbd68666fbba38f313cb(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5045), (object) c3cab5319dc016deb050deb101e927b2f.TitleId, (object) c907075ebe7f1c4b189f6eae5161c381b.TitleVersion));
          this.c2766b636f6ad26a17259faeb4a9dd9fc(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1368), this.c2853be4118c9ee30af7cc03fb8989ef0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1372), new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1376)), this.c5c8bf6422ca66783e52a629fda4e241d, new TimeSpan((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1380)), this.c6a461a219d82299312681f235c5bb94f, c3cab5319dc016deb050deb101e927b2f);
          return (c2e2f19e8cde9983e4129b4a047c9f5c6.cb5aaa7388e4130086d74bcf9dde5c027) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1384);
      }
    }

    private cff72ea250ac36ea03abde33ff61b7565 c5acec3be4b5f89479fbba2abbbbdbbf6(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, bool cb193fdc4c860ea6fabec9e4c27c4c496 = true)
    {
      this.ce859329e4d96fbd68666fbba38f313cb(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5122));
      string path = Path.Combine(c36dd98eb0c08ea087627a40c6663c9a8.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2456));
      if (!cb193fdc4c860ea6fabec9e4c27c4c496)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.c5acec3be4b5f89479fbba2abbbbdbbf6);
            }
            if (c36dd98eb0c08ea087627a40c6663c9a8.Tmd != null)
            {
label_5:
              switch (5)
              {
                case 0:
                  goto label_5;
                default:
                  return c36dd98eb0c08ea087627a40c6663c9a8.Tmd;
              }
            }
            else
              break;
        }
      }
      c1787c51468b07dafcfbe2abfbc5bb04b c1787c51468b07dafcfbe2abfbc5bb04b = new c1787c51468b07dafcfbe2abfbc5bb04b();
      byte[] numArray1 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      try
      {
        if (c50c5ab6d2aca52507a5f6d83f26a1a97.cc50e3aad2c922bb7d7e65938629ab7b5((object) c36dd98eb0c08ea087627a40c6663c9a8) != null)
        {
label_9:
          switch (5)
          {
            case 0:
              goto label_9;
            default:
              numArray1 = c1787c51468b07dafcfbe2abfbc5bb04b.cfe99310765b0f6b96322192129ed2876(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5159), (object) c36dd98eb0c08ea087627a40c6663c9a8.c62c40cf74825a86f2ba018c8a07f11e2, (object) c36dd98eb0c08ea087627a40c6663c9a8.Version));
              break;
          }
        }
        else
        {
          byte[] numArray2;
          if (!c36dd98eb0c08ea087627a40c6663c9a8.CustomTitle)
          {
label_12:
            switch (6)
            {
              case 0:
                goto label_12;
              default:
                numArray2 = c1787c51468b07dafcfbe2abfbc5bb04b.cfe99310765b0f6b96322192129ed2876(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c36dd98eb0c08ea087627a40c6663c9a8.c62c40cf74825a86f2ba018c8a07f11e2, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5180)));
                break;
            }
          }
          else
            numArray2 = c1787c51468b07dafcfbe2abfbc5bb04b.cfe99310765b0f6b96322192129ed2876(c9845e9fdb9bb1e03d7debbbd57953daa.cb7d0da9171f9af8ce4271b196826eed3(c36dd98eb0c08ea087627a40c6663c9a8));
          numArray1 = numArray2;
        }
        c36dd98eb0c08ea087627a40c6663c9a8.Tmd = cff72ea250ac36ea03abde33ff61b7565.cb5009c1058eaad54842d9bead8e530a2(numArray1, c36dd98eb0c08ea087627a40c6663c9a8.System);
      }
      catch (Exception ex)
      {
        this.ca9421c3af47f4e9ba32891eda2b04b0c(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5187));
      }
      if (cb193fdc4c860ea6fabec9e4c27c4c496)
      {
label_19:
        switch (2)
        {
          case 0:
            goto label_19;
          default:
            System.IO.File.WriteAllBytes(path, numArray1);
            break;
        }
      }
      return c36dd98eb0c08ea087627a40c6663c9a8.Tmd;
    }

    private void c2766b636f6ad26a17259faeb4a9dd9fc(int cad00ab40cb2712e58ebb1e237b2902f6, int cf7bf7ed27e5378895056f9c4e22fa991, int c38855cffe45bdc8557bd9e2e5041a0ae, TimeSpan c15a70e09ef637944b33360cad947e6f8, TimeSpan c1a10455bb6f332140269e81daadbeb4e, TimeSpan c2cba9756b63f71221e008346083c3112, cbd9d23875bab012857e040a881a1cf4c cd4227f7784d7614c9fb9985ea0ec696e, cba6aa8f767d2e8dfbca2d43d7148c173 c6820e32c59a21c847a054559226e6762)
    {
      if (c745d89fddb05a30e8ef1babd26557977.c1df95097ffa57d753c5fe1353cf65e86(DateTime.Now, this.c2f3e36c9b99b1e79ac276030c411aeaa).TotalSeconds < cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(1388))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.c2766b636f6ad26a17259faeb4a9dd9fc);
            break;
        }
      }
      else
      {
        this.c2f3e36c9b99b1e79ac276030c411aeaa = DateTime.Now;
        // ISSUE: reference to a compiler-generated field
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> cacb2e6beade608d802439f475aa2171a = this.cacb2e6beade608d802439f475aa2171a;
        if (cacb2e6beade608d802439f475aa2171a == null)
        {
label_5:
          switch (3)
          {
            case 0:
              goto label_5;
          }
        }
        else
        {
          cdf40c9764a014ff068a86edd8ace4556 e = new cdf40c9764a014ff068a86edd8ace4556(cad00ab40cb2712e58ebb1e237b2902f6, cf7bf7ed27e5378895056f9c4e22fa991, c38855cffe45bdc8557bd9e2e5041a0ae, c15a70e09ef637944b33360cad947e6f8, c1a10455bb6f332140269e81daadbeb4e, c2cba9756b63f71221e008346083c3112, cd4227f7784d7614c9fb9985ea0ec696e, c6820e32c59a21c847a054559226e6762);
          cacb2e6beade608d802439f475aa2171a((object) this, e);
        }
      }
    }

    private void ce859329e4d96fbd68666fbba38f313cb(string ccc5b7a75b49697be2f86a8c41c8ef464)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<string> ca7b3d3646c1ef6f0d20e46cd000e997a = this.ca7b3d3646c1ef6f0d20e46cd000e997a;
      if (ca7b3d3646c1ef6f0d20e46cd000e997a == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.ce859329e4d96fbd68666fbba38f313cb);
            }
            break;
        }
      }
      else
      {
        string e = ccc5b7a75b49697be2f86a8c41c8ef464;
        ca7b3d3646c1ef6f0d20e46cd000e997a((object) this, e);
      }
    }

    private void cb4b065e87379a7bfe93ee11b8e3a0662(string c922876a56e5a2b0075ab065bf7b06279, bool c535cb6a065f5d46dcb7ba37e4a6a068d)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> c60346b7eb87c5b6c53ae83177066862b = this.c60346b7eb87c5b6c53ae83177066862b;
      if (c60346b7eb87c5b6c53ae83177066862b == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2e2f19e8cde9983e4129b4a047c9f5c6.cb4b065e87379a7bfe93ee11b8e3a0662);
            }
            break;
        }
      }
      else
      {
        c9d5fc374dcd742d4aee7811bbe7ee2e1 e = new c9d5fc374dcd742d4aee7811bbe7ee2e1(c922876a56e5a2b0075ab065bf7b06279, c535cb6a065f5d46dcb7ba37e4a6a068d, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1396));
        c60346b7eb87c5b6c53ae83177066862b((object) this, e);
      }
    }

    public struct cf960775278a7e7028668e3ca5dd866d1
    {
      public DataSize c64ccfce653a8bd2c7c7ffb6b8d91766f;
      public TitleId c27f5df1dc5d80dd0c87cd29e7cef11b8;
    }

    public struct cc8cce23c9cabc8c74f6621804b209224
    {
      public DataSize c64ccfce653a8bd2c7c7ffb6b8d91766f;
      public TitleId c27f5df1dc5d80dd0c87cd29e7cef11b8;
      public string c907ca8ffa30661318a7e29e77519ea57;
      public string c330284c85ae4e7d7fee01a9e716b656b;
      public string c80d617f05b7f95017df4cba82652d0dd;
    }

    private enum c9f3a7e2b8919612af3bedd821bbe7079
    {
      c9873fd1470856dc65f185641b5a8b0bd,
      cad93249d33c32af507ddf1b3cf10aaf1,
    }

    private enum cb5aaa7388e4130086d74bcf9dde5c027
    {
      c2abe6be3a06921ab3fe8ff9de9b37856,
      cf8139dc61d96e4a9ff8b1dc5cf060de9,
    }
  }
}
