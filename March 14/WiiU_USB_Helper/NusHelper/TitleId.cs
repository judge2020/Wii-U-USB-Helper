// Decompiled with JetBrains decompiler
// Type: NusHelper.TitleId
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using A;
using System;

namespace NusHelper
{
  public class TitleId : IEquatable<TitleId>
  {
    public readonly string IdRaw;
    private const string DlcLow3DS = "0004000C";
    private const string DlcLowWiiu = "0005000C";
    private const string GameLow3DS = "00040000";
    private const string GameLowDsi = "00048004";
    private const string GameLowWiiu = "00050000";
    private const string UpdateLow3DS = "0004000E";
    private const string UpdateLowWiiu = "0005000E";
    private caff792dac5a5e2f17b0e81e59bba386d System;

    public TitleId FullDlc
    {
      get
      {
        return new TitleId((this.System == caff792dac5a5e2f17b0e81e59bba386d.c775c038fd6c16a603893aa5cf81dd68c ? "0005000C" : "0004000C") + this.High);
      }
    }

    public TitleId FullGame
    {
      get
      {
        return new TitleId((this.System == caff792dac5a5e2f17b0e81e59bba386d.c775c038fd6c16a603893aa5cf81dd68c ? "00050000" : "00040000") + this.High);
      }
    }

    public TitleId FullUpdate
    {
      get
      {
        return new TitleId((this.System == caff792dac5a5e2f17b0e81e59bba386d.c775c038fd6c16a603893aa5cf81dd68c ? "0005000E" : "0004000E") + this.High);
      }
    }

    public cfcd12ee63ba7d661f4ab310574290bf9 IdType { get; }

    internal string High { get; set; }

    public TitleId(string id)
    {
      id = id.ToUpper();
      this.IdRaw = id.Substring(0, 16);
      string c6b3a8e204bc8a56126ccc5bdce46b0e4 = id.Substring(0, 8);
      // ISSUE: reference to a compiler-generated method
      uint num = c88dfcbdfa12cefbcbf499f943fb3b8dd.c72c098248e635ac871fa1dde1ab90fc3(c6b3a8e204bc8a56126ccc5bdce46b0e4);
      if (num <= 668895184U)
      {
        if ((int) num != 307253171)
        {
          if ((int) num != 407918885)
          {
            if ((int) num == 668895184 && c6b3a8e204bc8a56126ccc5bdce46b0e4 == "0004000C")
            {
              this.System = caff792dac5a5e2f17b0e81e59bba386d.cd640a3b52f646cee482c685f1e6d0f8b;
              this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c171a4a3dc0f5f061bd920529c13faa2a;
              goto label_21;
            }
          }
          else if (c6b3a8e204bc8a56126ccc5bdce46b0e4 == "0005000E")
          {
            this.System = caff792dac5a5e2f17b0e81e59bba386d.c775c038fd6c16a603893aa5cf81dd68c;
            this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c67e3dde1b06befbd68123cff88fcb6f5;
            goto label_21;
          }
        }
        else if (c6b3a8e204bc8a56126ccc5bdce46b0e4 == "0005000C")
        {
          this.System = caff792dac5a5e2f17b0e81e59bba386d.c775c038fd6c16a603893aa5cf81dd68c;
          this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c171a4a3dc0f5f061bd920529c13faa2a;
          goto label_21;
        }
      }
      else if (num <= 2583915261U)
      {
        if ((int) num != 769560898)
        {
          if ((int) num == -1711052035 && c6b3a8e204bc8a56126ccc5bdce46b0e4 == "00048004")
          {
            this.System = caff792dac5a5e2f17b0e81e59bba386d.cd640a3b52f646cee482c685f1e6d0f8b;
            this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c47054f4f67fcb5279cce97c91dc1ecae;
            goto label_21;
          }
        }
        else if (c6b3a8e204bc8a56126ccc5bdce46b0e4 == "0004000E")
        {
          this.System = caff792dac5a5e2f17b0e81e59bba386d.cd640a3b52f646cee482c685f1e6d0f8b;
          this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c67e3dde1b06befbd68123cff88fcb6f5;
          goto label_21;
        }
      }
      else if ((int) num != -1159865287)
      {
        if ((int) num == -1018178730 && c6b3a8e204bc8a56126ccc5bdce46b0e4 == "00050000")
        {
          this.System = caff792dac5a5e2f17b0e81e59bba386d.c775c038fd6c16a603893aa5cf81dd68c;
          this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c9506d0fd83bf15f08302a35bc6ce2547;
          goto label_21;
        }
      }
      else if (c6b3a8e204bc8a56126ccc5bdce46b0e4 == "00040000")
      {
        this.System = caff792dac5a5e2f17b0e81e59bba386d.cd640a3b52f646cee482c685f1e6d0f8b;
        this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c5bd441811e30d66d625f3698ee4f5eb0;
        goto label_21;
      }
      this.System = caff792dac5a5e2f17b0e81e59bba386d.c775c038fd6c16a603893aa5cf81dd68c;
      this.IdType = cfcd12ee63ba7d661f4ab310574290bf9.c6a853f1d95f1fc61958e11bb94af37f3;
label_21:
      this.High = id.Substring(8, 8);
    }

    public static explicit operator TitleId(string id)
    {
      return new TitleId(id);
    }

    public static implicit operator string(TitleId id)
    {
      return id.IdRaw;
    }

    public bool Equals(TitleId other)
    {
      if (other != null)
        return other.IdRaw == this.IdRaw;
      return false;
    }

    public override bool Equals(object other)
    {
      if (other is TitleId)
        return ((TitleId) other).IdRaw == this.IdRaw;
      return false;
    }

    public override int GetHashCode()
    {
      return this.IdRaw.GetHashCode();
    }

    public string ToSplitString()
    {
      return this.IdRaw.Insert(8, "-");
    }

    public override string ToString()
    {
      return this.IdRaw;
    }
  }
}
