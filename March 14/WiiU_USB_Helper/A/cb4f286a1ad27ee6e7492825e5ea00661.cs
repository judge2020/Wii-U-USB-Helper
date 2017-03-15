// Decompiled with JetBrains decompiler
// Type: A.cb4f286a1ad27ee6e7492825e5ea00661
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.IO;
using System.Threading;

namespace A
{
  internal class cb4f286a1ad27ee6e7492825e5ea00661 : Stream
  {
    public const long c79c7f7d0b837b9632300a19435681d55 = 0;
    private Stream cb604825d157ff76186bb7ff585d0bf9a;
    private long caed8902242ff7d1b5849f90493d0ae2c;
    private long c3293a09e69a9b6f224efaa252e7a1ca9;
    private long c3480a76a8d5e08f0f69d38dc343deb1d;

    public override bool CanRead
    {
      get
      {
        return this.cb604825d157ff76186bb7ff585d0bf9a.CanRead;
      }
    }

    public override bool CanSeek
    {
      get
      {
        return this.cb604825d157ff76186bb7ff585d0bf9a.CanSeek;
      }
    }

    public override bool CanWrite
    {
      get
      {
        return this.cb604825d157ff76186bb7ff585d0bf9a.CanWrite;
      }
    }

    public override long Length
    {
      get
      {
        return this.cb604825d157ff76186bb7ff585d0bf9a.Length;
      }
    }

    public long cdae04474aa6e84a6bc0973a77cd67e7b
    {
      get
      {
        return this.c3293a09e69a9b6f224efaa252e7a1ca9;
      }
      set
      {
        if (this.cdae04474aa6e84a6bc0973a77cd67e7b == value)
          return;
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cb4f286a1ad27ee6e7492825e5ea00661.set_cdae04474aa6e84a6bc0973a77cd67e7b);
            }
            this.c3293a09e69a9b6f224efaa252e7a1ca9 = value;
            this.c00b9a605f9a089ff3df03b945ee13780();
            break;
        }
      }
    }

    public override long Position
    {
      get
      {
        return this.cb604825d157ff76186bb7ff585d0bf9a.Position;
      }
      set
      {
        this.cb604825d157ff76186bb7ff585d0bf9a.Position = value;
      }
    }

    protected long c3e6f5d94f4475c89fc4ab195d2925df2
    {
      get
      {
        return (long) Environment.TickCount;
      }
    }

    public cb4f286a1ad27ee6e7492825e5ea00661(Stream cfc2da8ca89ab2c8d200543155a36fe77)
      : this(cfc2da8ca89ab2c8d200543155a36fe77, (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1472))
    {
    }

    public cb4f286a1ad27ee6e7492825e5ea00661(Stream cfc2da8ca89ab2c8d200543155a36fe77, long c4d1f1f00acb41522a2775875a6a643d4)
    {
      if (cfc2da8ca89ab2c8d200543155a36fe77 == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cb4f286a1ad27ee6e7492825e5ea00661.\u002Ector);
            }
            throw new ArgumentNullException(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5214));
        }
      }
      else if (c4d1f1f00acb41522a2775875a6a643d4 < (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1476))
      {
label_6:
        switch (2)
        {
          case 0:
            goto label_6;
          default:
            throw new ArgumentOutOfRangeException(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5235), (object) c4d1f1f00acb41522a2775875a6a643d4, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5278));
        }
      }
      else
      {
        this.cb604825d157ff76186bb7ff585d0bf9a = cfc2da8ca89ab2c8d200543155a36fe77;
        this.c3293a09e69a9b6f224efaa252e7a1ca9 = c4d1f1f00acb41522a2775875a6a643d4;
        this.c3480a76a8d5e08f0f69d38dc343deb1d = this.c3e6f5d94f4475c89fc4ab195d2925df2;
        this.caed8902242ff7d1b5849f90493d0ae2c = (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1480);
      }
    }

    public override void Flush()
    {
      this.cb604825d157ff76186bb7ff585d0bf9a.Flush();
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      this.ccda78132f468a051956c14bd1b15e222(count);
      return this.cb604825d157ff76186bb7ff585d0bf9a.Read(buffer, offset, count);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      return this.cb604825d157ff76186bb7ff585d0bf9a.Seek(offset, origin);
    }

    public override void SetLength(long value)
    {
      this.cb604825d157ff76186bb7ff585d0bf9a.SetLength(value);
    }

    public override string ToString()
    {
      return this.cb604825d157ff76186bb7ff585d0bf9a.ToString();
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      this.ccda78132f468a051956c14bd1b15e222(count);
      this.cb604825d157ff76186bb7ff585d0bf9a.Write(buffer, offset, count);
    }

    protected void c00b9a605f9a089ff3df03b945ee13780()
    {
      if (this.c3e6f5d94f4475c89fc4ab195d2925df2 - this.c3480a76a8d5e08f0f69d38dc343deb1d <= (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1440))
        return;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cb4f286a1ad27ee6e7492825e5ea00661.c00b9a605f9a089ff3df03b945ee13780);
          }
          this.caed8902242ff7d1b5849f90493d0ae2c = (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1444);
          this.c3480a76a8d5e08f0f69d38dc343deb1d = this.c3e6f5d94f4475c89fc4ab195d2925df2;
          break;
      }
    }

    protected void ccda78132f468a051956c14bd1b15e222(int cdd8e48c11ac1e9f97030c3165a66377c)
    {
      if (this.c3293a09e69a9b6f224efaa252e7a1ca9 <= (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1448))
        return;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cb4f286a1ad27ee6e7492825e5ea00661.ccda78132f468a051956c14bd1b15e222);
          }
          if (cdd8e48c11ac1e9f97030c3165a66377c <= cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1452))
          {
label_5:
            switch (6)
            {
              case 0:
                goto label_5;
              default:
                return;
            }
          }
          else
          {
            this.caed8902242ff7d1b5849f90493d0ae2c = this.caed8902242ff7d1b5849f90493d0ae2c + (long) cdd8e48c11ac1e9f97030c3165a66377c;
            long num = this.c3e6f5d94f4475c89fc4ab195d2925df2 - this.c3480a76a8d5e08f0f69d38dc343deb1d;
            if (num <= (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1456))
              break;
label_8:
            switch (5)
            {
              case 0:
                goto label_8;
              default:
                if (this.caed8902242ff7d1b5849f90493d0ae2c * (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1460) / num <= this.c3293a09e69a9b6f224efaa252e7a1ca9)
                  return;
label_10:
                switch (2)
                {
                  case 0:
                    goto label_10;
                  default:
                    int millisecondsTimeout = (int) (this.caed8902242ff7d1b5849f90493d0ae2c * (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1464) / this.c3293a09e69a9b6f224efaa252e7a1ca9 - num);
                    if (millisecondsTimeout <= cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(1468))
                      return;
label_12:
                    switch (6)
                    {
                      case 0:
                        goto label_12;
                      default:
                        try
                        {
                          Thread.Sleep(millisecondsTimeout);
                        }
                        catch (ThreadAbortException ex)
                        {
                        }
                        this.c00b9a605f9a089ff3df03b945ee13780();
                        return;
                    }
                }
            }
          }
      }
    }
  }
}
