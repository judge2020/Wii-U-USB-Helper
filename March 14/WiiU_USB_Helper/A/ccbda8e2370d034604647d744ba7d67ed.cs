// Decompiled with JetBrains decompiler
// Type: A.ccbda8e2370d034604647d744ba7d67ed
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace A
{
  internal static class ccbda8e2370d034604647d744ba7d67ed
  {
    public static int c4a770faab4e0250a4f6ca937bfe48e0a(int c9fcc805b87262573c93e1fb866e48e51, int cabfb6ddc4d36b7043a89ecfa6d8e3b6b)
    {
      if (c9fcc805b87262573c93e1fb866e48e51 % cabfb6ddc4d36b7043a89ecfa6d8e3b6b != 0)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ccbda8e2370d034604647d744ba7d67ed.c4a770faab4e0250a4f6ca937bfe48e0a);
            }
            c9fcc805b87262573c93e1fb866e48e51 += cabfb6ddc4d36b7043a89ecfa6d8e3b6b - c9fcc805b87262573c93e1fb866e48e51 % cabfb6ddc4d36b7043a89ecfa6d8e3b6b;
            break;
        }
      }
      return c9fcc805b87262573c93e1fb866e48e51;
    }

    public static bool c9da387a0620d0fb76794f0636febd9bd(byte[] ccf028ef488ad163ff8a1fdd07540a235, byte[] c38c40125530d67d2b30bfa5afa385b41)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ccbda8e2370d034604647d744ba7d67ed.cf494460ab5c267042a042ad6591e4483 cf494460ab5c267042a042ad6591e4483 = new ccbda8e2370d034604647d744ba7d67ed.cf494460ab5c267042a042ad6591e4483();
      // ISSUE: reference to a compiler-generated field
      cf494460ab5c267042a042ad6591e4483.c38c40125530d67d2b30bfa5afa385b41 = c38c40125530d67d2b30bfa5afa385b41;
      // ISSUE: reference to a compiler-generated field
      if ((int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(ccf028ef488ad163ff8a1fdd07540a235) == (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(cf494460ab5c267042a042ad6591e4483.c38c40125530d67d2b30bfa5afa385b41))
      {
        // ISSUE: reference to a compiler-generated method
        return (((IEnumerable<byte>) ccf028ef488ad163ff8a1fdd07540a235).Where<byte>(new Func<byte, int, bool>(cf494460ab5c267042a042ad6591e4483.c21f39c237e10c59e7a54097ee965fe76)).Any<byte>() ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(120);
      }
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ccbda8e2370d034604647d744ba7d67ed.c9da387a0620d0fb76794f0636febd9bd);
          }
          return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(116) != 0;
      }
    }

    public static ushort c6404b9d7e4d0919b78064f8f3b59faba(ushort c9fcc805b87262573c93e1fb866e48e51)
    {
      return (ushort) IPAddress.HostToNetworkOrder((short) c9fcc805b87262573c93e1fb866e48e51);
    }

    public static uint c6404b9d7e4d0919b78064f8f3b59faba(uint c9fcc805b87262573c93e1fb866e48e51)
    {
      return (uint) IPAddress.HostToNetworkOrder((int) c9fcc805b87262573c93e1fb866e48e51);
    }

    public static ulong c6404b9d7e4d0919b78064f8f3b59faba(ulong c9fcc805b87262573c93e1fb866e48e51)
    {
      return (ulong) IPAddress.HostToNetworkOrder((long) c9fcc805b87262573c93e1fb866e48e51);
    }
  }
}
