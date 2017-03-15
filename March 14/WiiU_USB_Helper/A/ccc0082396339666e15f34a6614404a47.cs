// Decompiled with JetBrains decompiler
// Type: A.ccc0082396339666e15f34a6614404a47
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NusHelper;

namespace A
{
  public abstract class ccc0082396339666e15f34a6614404a47
  {
    protected ushort c978841a06a7092f8157ae6ef563d3a81;

    public uint ContentId { get; set; }

    public abstract byte[] Hash { get; set; }

    public bool ce7bc51cbabe7bd4fb4dac2e71e260e4f
    {
      get
      {
        return ((int) this.c978841a06a7092f8157ae6ef563d3a81 & cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7194)) > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7198);
      }
    }

    public ushort Index { get; set; }

    public DataSize Size { get; set; }

    public c7fcc581584086d18c24ec12ebfa8f37a c937760863341d8781f86cc88a951c751
    {
      get
      {
        return (c7fcc581584086d18c24ec12ebfa8f37a) this.c978841a06a7092f8157ae6ef563d3a81;
      }
      set
      {
        this.c978841a06a7092f8157ae6ef563d3a81 = (ushort) value;
      }
    }
  }
}
