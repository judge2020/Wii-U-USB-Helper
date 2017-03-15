// Decompiled with JetBrains decompiler
// Type: A.c29f686fe3fab48150f240b6f3fa06309
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace A
{
  public sealed class c29f686fe3fab48150f240b6f3fa06309 : cee3593822ec8de8fac12bd472c140bd6
  {
    public Image Image { get; set; }

    public event EventHandler<c08d29affad9d3e42fb3f986fdfc029ee> c5846ace0cdb1d06c3c6526c2cd7db94c
    {
      add
      {
        EventHandler<c08d29affad9d3e42fb3f986fdfc029ee> eventHandler = this.c5846ace0cdb1d06c3c6526c2cd7db94c;
        EventHandler<c08d29affad9d3e42fb3f986fdfc029ee> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c08d29affad9d3e42fb3f986fdfc029ee>>(ref this.c5846ace0cdb1d06c3c6526c2cd7db94c, c21a387cec3f28994dc91df06b1496275.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c29f686fe3fab48150f240b6f3fa06309.add_c5846ace0cdb1d06c3c6526c2cd7db94c);
            break;
        }
      }
      remove
      {
        EventHandler<c08d29affad9d3e42fb3f986fdfc029ee> eventHandler = this.c5846ace0cdb1d06c3c6526c2cd7db94c;
        EventHandler<c08d29affad9d3e42fb3f986fdfc029ee> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c08d29affad9d3e42fb3f986fdfc029ee>>(ref this.c5846ace0cdb1d06c3c6526c2cd7db94c, c21a387cec3f28994dc91df06b1496275.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c29f686fe3fab48150f240b6f3fa06309.remove_c5846ace0cdb1d06c3c6526c2cd7db94c);
            break;
        }
      }
    }

    public void cf94a1c9fccab23f0d9a24711be16790b(string c7927af27b9cde3902e98e8d96c5a3200, TimeSpan ca2bb951e2e970e4642fef40082379a8a)
    {
      this.cf512b3e8313fdb213dc7a4004bdfe582 += new EventHandler<c17920230a4ceab76f3391befe7afb5be>(this.c659717876a16d09e22ad6ead2cc8b9e9);
      base.c2e10d9445ababd1acc717e3d07e4d331(c7927af27b9cde3902e98e8d96c5a3200, ca2bb951e2e970e4642fef40082379a8a);
    }

    public override void c2e10d9445ababd1acc717e3d07e4d331(string c7927af27b9cde3902e98e8d96c5a3200, TimeSpan ca2bb951e2e970e4642fef40082379a8a)
    {
      this.cf512b3e8313fdb213dc7a4004bdfe582 += new EventHandler<c17920230a4ceab76f3391befe7afb5be>(this.c8e31c30e0d5532c5413eeedc7aa2acc3);
      base.c2e10d9445ababd1acc717e3d07e4d331(c7927af27b9cde3902e98e8d96c5a3200, ca2bb951e2e970e4642fef40082379a8a);
    }

    private void c8e31c30e0d5532c5413eeedc7aa2acc3(object c5382ad5461e274fda51b358802fc3910, c17920230a4ceab76f3391befe7afb5be c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cf512b3e8313fdb213dc7a4004bdfe582 -= new EventHandler<c17920230a4ceab76f3391befe7afb5be>(this.c8e31c30e0d5532c5413eeedc7aa2acc3);
      try
      {
        this.Image = Image.FromStream((Stream) new MemoryStream(c9572d7ff9cd6a116e4a6f248ca68a831.cf7729f9f30f23a67def5796e192d889f));
      }
      catch (Exception ex)
      {
        if (!File.Exists(c9572d7ff9cd6a116e4a6f248ca68a831.c00207f79bccd6049f533316afb259ae7))
          return;
label_3:
        switch (6)
        {
          case 0:
            goto label_3;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c29f686fe3fab48150f240b6f3fa06309.c8e31c30e0d5532c5413eeedc7aa2acc3);
            }
            File.Delete(c9572d7ff9cd6a116e4a6f248ca68a831.c00207f79bccd6049f533316afb259ae7);
            return;
        }
      }
      // ISSUE: reference to a compiler-generated field
      EventHandler<c08d29affad9d3e42fb3f986fdfc029ee> c5846ace0cdb1d06c3c6526c2cd7db94c = this.c5846ace0cdb1d06c3c6526c2cd7db94c;
      if (c5846ace0cdb1d06c3c6526c2cd7db94c == null)
      {
label_8:
        switch (1)
        {
          case 0:
            goto label_8;
        }
      }
      else
      {
        c08d29affad9d3e42fb3f986fdfc029ee e = new c08d29affad9d3e42fb3f986fdfc029ee(this.Image);
        c5846ace0cdb1d06c3c6526c2cd7db94c((object) this, e);
      }
    }

    private void c659717876a16d09e22ad6ead2cc8b9e9(object c5382ad5461e274fda51b358802fc3910, c17920230a4ceab76f3391befe7afb5be c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cf512b3e8313fdb213dc7a4004bdfe582 -= new EventHandler<c17920230a4ceab76f3391befe7afb5be>(this.c659717876a16d09e22ad6ead2cc8b9e9);
      if (!c9572d7ff9cd6a116e4a6f248ca68a831.cc56fd643dd4663700103c4d765b46fec)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c29f686fe3fab48150f240b6f3fa06309.c659717876a16d09e22ad6ead2cc8b9e9);
            }
            MemoryStream memoryStream1 = new MemoryStream(c9572d7ff9cd6a116e4a6f248ca68a831.cf7729f9f30f23a67def5796e192d889f);
            try
            {
              MemoryStream memoryStream2 = new MemoryStream();
              try
              {
                new Bitmap(Image.FromStream((Stream) memoryStream1), new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7504), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7508))).Save((Stream) memoryStream2, ImageFormat.Png);
                File.WriteAllBytes(c9572d7ff9cd6a116e4a6f248ca68a831.c00207f79bccd6049f533316afb259ae7, memoryStream2.ToArray());
                this.Image = Image.FromStream((Stream) memoryStream2);
                break;
              }
              catch (Exception ex)
              {
                if (!File.Exists(c9572d7ff9cd6a116e4a6f248ca68a831.c00207f79bccd6049f533316afb259ae7))
                  return;
label_8:
                switch (4)
                {
                  case 0:
                    goto label_8;
                  default:
                    File.Delete(c9572d7ff9cd6a116e4a6f248ca68a831.c00207f79bccd6049f533316afb259ae7);
                    return;
                }
              }
            }
            finally
            {
              if (memoryStream1 != null)
              {
label_11:
                switch (3)
                {
                  case 0:
                    goto label_11;
                  default:
                    memoryStream1.Dispose();
                    break;
                }
              }
            }
        }
      }
      else
        this.Image = Image.FromStream((Stream) new MemoryStream(c9572d7ff9cd6a116e4a6f248ca68a831.cf7729f9f30f23a67def5796e192d889f));
      // ISSUE: reference to a compiler-generated field
      EventHandler<c08d29affad9d3e42fb3f986fdfc029ee> c5846ace0cdb1d06c3c6526c2cd7db94c = this.c5846ace0cdb1d06c3c6526c2cd7db94c;
      if (c5846ace0cdb1d06c3c6526c2cd7db94c == null)
      {
label_16:
        switch (7)
        {
          case 0:
            goto label_16;
        }
      }
      else
      {
        c08d29affad9d3e42fb3f986fdfc029ee e = new c08d29affad9d3e42fb3f986fdfc029ee(this.Image);
        c5846ace0cdb1d06c3c6526c2cd7db94c((object) this, e);
      }
    }
  }
}
