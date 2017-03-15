// Decompiled with JetBrains decompiler
// Type: A.c6b6cd1274db5c3760ebd273284d15464
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace A
{
  public sealed class c6b6cd1274db5c3760ebd273284d15464
  {
    private volatile bool c4f91062ac554299318646c37ae1bd16d = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1432) != 0;
    private UdpClient c34c89bee529e504401fe391ff8243d81 = new UdpClient(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1436));
    private const string c78b7a5036e897563444ded7fb1693aae = "HELLO FROM WIIU!";

    public event EventHandler<IPAddress> c216fa6b5069ca26468baa8aeee5f77bc
    {
      add
      {
        EventHandler<IPAddress> eventHandler = this.c216fa6b5069ca26468baa8aeee5f77bc;
        EventHandler<IPAddress> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<IPAddress>>(ref this.c216fa6b5069ca26468baa8aeee5f77bc, ccf5318a380c513adbbab57743c46425c.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6b6cd1274db5c3760ebd273284d15464.add_c216fa6b5069ca26468baa8aeee5f77bc);
            break;
        }
      }
      remove
      {
        EventHandler<IPAddress> eventHandler = this.c216fa6b5069ca26468baa8aeee5f77bc;
        EventHandler<IPAddress> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<IPAddress>>(ref this.c216fa6b5069ca26468baa8aeee5f77bc, ccf5318a380c513adbbab57743c46425c.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6b6cd1274db5c3760ebd273284d15464.remove_c216fa6b5069ca26468baa8aeee5f77bc);
            break;
        }
      }
    }

    public void cf7908bdf1ba3f188e6255a17595c90c9(bool c7ceb41b0e0344fe8cf5ac0cfb523cdb3)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Thread thread = new Thread(new ThreadStart(new c6b6cd1274db5c3760ebd273284d15464.c968b83dcb6a70a1a6325fb0a7d32cb6c()
      {
        ccb669e105f1c11f33e60c076fc8cca42 = this,
        c7ceb41b0e0344fe8cf5ac0cfb523cdb3 = c7ceb41b0e0344fe8cf5ac0cfb523cdb3
      }.c522ead302109371ae42292107135d246));
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1424);
      thread.IsBackground = num != 0;
      thread.Start();
    }

    public void c5434ee3bcfd63c0e82b7bf977619f848()
    {
      this.c4f91062ac554299318646c37ae1bd16d = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1428) != 0;
      this.c34c89bee529e504401fe391ff8243d81.Close();
    }

    private void cdb4d323aba70eb34365e40a2a5a58617(IPAddress cc993020431218dd1868140562b121eea)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<IPAddress> c216fa6b5069ca26468baa8aeee5f77bc = this.c216fa6b5069ca26468baa8aeee5f77bc;
      if (c216fa6b5069ca26468baa8aeee5f77bc == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c6b6cd1274db5c3760ebd273284d15464.cdb4d323aba70eb34365e40a2a5a58617);
            }
            break;
        }
      }
      else
      {
        IPAddress e = cc993020431218dd1868140562b121eea;
        c216fa6b5069ca26468baa8aeee5f77bc((object) this, e);
      }
    }
  }
}
