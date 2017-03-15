// Decompiled with JetBrains decompiler
// Type: A.cee3593822ec8de8fac12bd472c140bd6
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Threading;

namespace A
{
  public abstract class cee3593822ec8de8fac12bd472c140bd6
  {
    protected event EventHandler<c17920230a4ceab76f3391befe7afb5be> cf512b3e8313fdb213dc7a4004bdfe582
    {
      add
      {
        EventHandler<c17920230a4ceab76f3391befe7afb5be> eventHandler = this.cf512b3e8313fdb213dc7a4004bdfe582;
        EventHandler<c17920230a4ceab76f3391befe7afb5be> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c17920230a4ceab76f3391befe7afb5be>>(ref this.cf512b3e8313fdb213dc7a4004bdfe582, c002d8baad38191162b8825efcd557406.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (3)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cee3593822ec8de8fac12bd472c140bd6.add_cf512b3e8313fdb213dc7a4004bdfe582);
            break;
        }
      }
      remove
      {
        EventHandler<c17920230a4ceab76f3391befe7afb5be> eventHandler = this.cf512b3e8313fdb213dc7a4004bdfe582;
        EventHandler<c17920230a4ceab76f3391befe7afb5be> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c17920230a4ceab76f3391befe7afb5be>>(ref this.cf512b3e8313fdb213dc7a4004bdfe582, c002d8baad38191162b8825efcd557406.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (3)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cee3593822ec8de8fac12bd472c140bd6.remove_cf512b3e8313fdb213dc7a4004bdfe582);
            break;
        }
      }
    }

    public static byte[] ccefa4e680ce6690d29bb083197d0983e(string c7927af27b9cde3902e98e8d96c5a3200, TimeSpan c8c62c158e9c07f1b196f6f255dd0740f)
    {
      if (!Uri.IsWellFormedUriString(c7927af27b9cde3902e98e8d96c5a3200, (UriKind) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7512)))
        return (byte[]) null;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cee3593822ec8de8fac12bd472c140bd6.ccefa4e680ce6690d29bb083197d0983e);
          }
          return c6a07387c2f827de6ca155929a5452624.ca344ce84e54eae1aaf7aad18845e6af4(new Uri(c7927af27b9cde3902e98e8d96c5a3200), c8c62c158e9c07f1b196f6f255dd0740f);
      }
    }

    public virtual void c2e10d9445ababd1acc717e3d07e4d331(string c7927af27b9cde3902e98e8d96c5a3200, TimeSpan c8c62c158e9c07f1b196f6f255dd0740f)
    {
      if (!Uri.IsWellFormedUriString(c7927af27b9cde3902e98e8d96c5a3200, (UriKind) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7516)))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cee3593822ec8de8fac12bd472c140bd6.c2e10d9445ababd1acc717e3d07e4d331);
            break;
        }
      }
      else
        c6a07387c2f827de6ca155929a5452624.c1f527b2b4106d3462a4dcb965c44086e(new Uri(c7927af27b9cde3902e98e8d96c5a3200), c8c62c158e9c07f1b196f6f255dd0740f, (Action<c17920230a4ceab76f3391befe7afb5be>) (c9572d7ff9cd6a116e4a6f248ca68a831 =>
        {
          // ISSUE: reference to a compiler-generated field
          EventHandler<c17920230a4ceab76f3391befe7afb5be> cf512b3e8313fdb213dc7a4004bdfe582 = this.cf512b3e8313fdb213dc7a4004bdfe582;
          if (cf512b3e8313fdb213dc7a4004bdfe582 == null)
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
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (cee3593822ec8de8fac12bd472c140bd6.c7664706680b470866ab8ff40086b08d5);
                }
                break;
            }
          }
          else
          {
            c17920230a4ceab76f3391befe7afb5be e = c9572d7ff9cd6a116e4a6f248ca68a831;
            cf512b3e8313fdb213dc7a4004bdfe582((object) this, e);
          }
        }));
    }
  }
}
