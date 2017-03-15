// Decompiled with JetBrains decompiler
// Type: A.c9654c418e330d33bb3f6a61645043740
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace A
{
  internal class c9654c418e330d33bb3f6a61645043740
  {
    private static readonly MemoryStream cc894a1bd974202896bb4271f940b47ba = cb340211dab5e5cad862474535531b3fb.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    private static readonly MemoryStream c9eda15cf80fff9318c8c21fbca205f58 = cb340211dab5e5cad862474535531b3fb.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    private static readonly int c18393f272475a5a63e643687f7f9e4f2 = int.MaxValue;
    private static readonly int c01552ca16663ec31f968e0ecd31680f2 = int.MinValue;
    private static readonly object ccfd842bf2944d8f8d0bf327693b16cfa;
    private static readonly byte c94d7d3929ab24e50a1d9c5279e0ca34c;

    static c9654c418e330d33bb3f6a61645043740()
    {
      c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba = new MemoryStream(0);
      c9654c418e330d33bb3f6a61645043740.c9eda15cf80fff9318c8c21fbca205f58 = new MemoryStream(0);
      c9654c418e330d33bb3f6a61645043740.ccfd842bf2944d8f8d0bf327693b16cfa = new object();
    }

    private static string cca9585fd78213e351689cf36fd7b5d4d(Assembly cf71eb905db0c5ca5cc4263aed3658084)
    {
      string str = cf71eb905db0c5ca5cc4263aed3658084.FullName;
      int length = str.IndexOf(',');
      if (length >= 0)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c9654c418e330d33bb3f6a61645043740.cca9585fd78213e351689cf36fd7b5d4d);
            }
            str = str.Substring(0, length);
            break;
        }
      }
      return str;
    }

    private static byte[] c1ddc000be9484a84934c477ccb3f8f34(Assembly cf71eb905db0c5ca5cc4263aed3658084)
    {
      try
      {
        string fullName = cf71eb905db0c5ca5cc4263aed3658084.FullName;
        int num = fullName.IndexOf("PublicKeyToken=");
        if (num < 0)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c9654c418e330d33bb3f6a61645043740.c1ddc000be9484a84934c477ccb3f8f34);
              }
              num = fullName.IndexOf("publickeytoken=");
              break;
          }
        }
        if (num < 0)
        {
label_6:
          switch (5)
          {
            case 0:
              goto label_6;
            default:
              return c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
          }
        }
        else
        {
          int startIndex = num + 15;
          if ((int) fullName[startIndex] != 110)
          {
label_9:
            switch (5)
            {
              case 0:
                goto label_9;
              default:
                if ((int) fullName[startIndex] == 78)
                {
label_11:
                  switch (5)
                  {
                    case 0:
                      goto label_11;
                  }
                }
                else
                {
                  byte[] bytes = BitConverter.GetBytes(long.Parse(fullName.Substring(startIndex, 16), NumberStyles.HexNumber));
                  Array.Reverse((Array) bytes);
                  return bytes;
                }
            }
          }
          return c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        }
      }
      catch
      {
      }
      return (byte[]) null;
    }

    internal static byte[] c6cec9570274a9c3b27abce09e7ebd8d0(Stream c90e7c90ead6c95222c8a43ceed60a2b1)
    {
      lock (c9654c418e330d33bb3f6a61645043740.ccfd842bf2944d8f8d0bf327693b16cfa)
        return c9654c418e330d33bb3f6a61645043740.cd28247e67c0c72bed8d3bd7d2f376ddb(97L, c90e7c90ead6c95222c8a43ceed60a2b1);
    }

    internal static byte[] cd1cc5106b3801905def21c597971969e(long c94d7d3929ab24e50a1d9c5279e0ca34c, Stream c90e7c90ead6c95222c8a43ceed60a2b1)
    {
      try
      {
        return c9654c418e330d33bb3f6a61645043740.c6cec9570274a9c3b27abce09e7ebd8d0(c90e7c90ead6c95222c8a43ceed60a2b1);
      }
      catch (HostProtectionException ex)
      {
        return c9654c418e330d33bb3f6a61645043740.cd28247e67c0c72bed8d3bd7d2f376ddb(97L, c90e7c90ead6c95222c8a43ceed60a2b1);
      }
    }

    internal static byte[] cd28247e67c0c72bed8d3bd7d2f376ddb(long c94d7d3929ab24e50a1d9c5279e0ca34c, Stream c90e7c90ead6c95222c8a43ceed60a2b1)
    {
      Stream stream = c90e7c90ead6c95222c8a43ceed60a2b1;
      MemoryStream memoryStream = cb340211dab5e5cad862474535531b3fb.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      for (int index = 1; index < 4; ++index)
        c90e7c90ead6c95222c8a43ceed60a2b1.ReadByte();
label_3:
      switch (3)
      {
        case 0:
          goto label_3;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c9654c418e330d33bb3f6a61645043740.cd28247e67c0c72bed8d3bd7d2f376ddb);
          }
          ushort num1 = ~(ushort) c90e7c90ead6c95222c8a43ceed60a2b1.ReadByte();
          if (((int) num1 & 2) != 0)
          {
label_7:
            switch (6)
            {
              case 0:
                goto label_7;
              default:
                DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                byte[] buffer1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(8);
                c90e7c90ead6c95222c8a43ceed60a2b1.Read(buffer1, 0, 8);
                cryptoServiceProvider.IV = buffer1;
                byte[] buffer2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(8);
                c90e7c90ead6c95222c8a43ceed60a2b1.Read(buffer2, 0, 8);
                bool flag = true;
                byte[] c33ad1bd311fd4b32b85377e9e15a9d93 = buffer2;
                for (int index = 0; index < (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93); ++index)
                {
                  if ((int) c33ad1bd311fd4b32b85377e9e15a9d93[index] != 0)
                  {
label_10:
                    switch (7)
                    {
                      case 0:
                        goto label_10;
                      default:
                        flag = false;
                        goto label_15;
                    }
                  }
                }
label_14:
                switch (5)
                {
                  case 0:
                    goto label_14;
                }
label_15:
                if (flag)
                {
label_16:
                  switch (1)
                  {
                    case 0:
                      goto label_16;
                    default:
                      buffer2 = c9654c418e330d33bb3f6a61645043740.c1ddc000be9484a84934c477ccb3f8f34(Assembly.GetExecutingAssembly());
                      break;
                  }
                }
                cryptoServiceProvider.Key = buffer2;
                if (c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba == null)
                {
label_19:
                  switch (6)
                  {
                    case 0:
                      goto label_19;
                    default:
                      if (c9654c418e330d33bb3f6a61645043740.c18393f272475a5a63e643687f7f9e4f2 == int.MaxValue)
                      {
label_21:
                        switch (6)
                        {
                          case 0:
                            goto label_21;
                          default:
                            c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba.Capacity = (int) c90e7c90ead6c95222c8a43ceed60a2b1.Length;
                            break;
                        }
                      }
                      else
                      {
                        c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba.Capacity = c9654c418e330d33bb3f6a61645043740.c18393f272475a5a63e643687f7f9e4f2;
                        break;
                      }
                  }
                }
                c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba.Position = 0L;
                ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor();
                int inputBlockSize = decryptor.InputBlockSize;
                int outputBlockSize = decryptor.OutputBlockSize;
                byte[] numArray1 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(decryptor.OutputBlockSize);
                byte[] numArray2 = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(decryptor.InputBlockSize);
                int position = (int) c90e7c90ead6c95222c8a43ceed60a2b1.Position;
                while ((long) (position + inputBlockSize) < c90e7c90ead6c95222c8a43ceed60a2b1.Length)
                {
                  c90e7c90ead6c95222c8a43ceed60a2b1.Read(numArray2, 0, inputBlockSize);
                  int count = decryptor.TransformBlock(numArray2, 0, inputBlockSize, numArray1, 0);
                  c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba.Write(numArray1, 0, count);
                  position += inputBlockSize;
                }
label_27:
                switch (7)
                {
                  case 0:
                    goto label_27;
                  default:
                    c90e7c90ead6c95222c8a43ceed60a2b1.Read(numArray2, 0, (int) (c90e7c90ead6c95222c8a43ceed60a2b1.Length - (long) position));
                    byte[] numArray3 = decryptor.TransformFinalBlock(numArray2, 0, (int) (c90e7c90ead6c95222c8a43ceed60a2b1.Length - (long) position));
                    c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba.Write(numArray3, 0, (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray3));
                    stream = (Stream) c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba;
                    stream.Position = 0L;
                    memoryStream = c9654c418e330d33bb3f6a61645043740.cc894a1bd974202896bb4271f940b47ba;
                    break;
                }
            }
          }
          if (((int) num1 & 8) != 0)
          {
label_30:
            switch (3)
            {
              case 0:
                goto label_30;
              default:
                if (c9654c418e330d33bb3f6a61645043740.c9eda15cf80fff9318c8c21fbca205f58 == null)
                {
label_32:
                  switch (7)
                  {
                    case 0:
                      goto label_32;
                    default:
                      if (c9654c418e330d33bb3f6a61645043740.c01552ca16663ec31f968e0ecd31680f2 == int.MinValue)
                      {
label_34:
                        switch (2)
                        {
                          case 0:
                            goto label_34;
                          default:
                            c9654c418e330d33bb3f6a61645043740.c9eda15cf80fff9318c8c21fbca205f58.Capacity = (int) stream.Length * 2;
                            break;
                        }
                      }
                      else
                      {
                        c9654c418e330d33bb3f6a61645043740.c9eda15cf80fff9318c8c21fbca205f58.Capacity = c9654c418e330d33bb3f6a61645043740.c01552ca16663ec31f968e0ecd31680f2;
                        break;
                      }
                  }
                }
                c9654c418e330d33bb3f6a61645043740.c9eda15cf80fff9318c8c21fbca205f58.Position = 0L;
                DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
                int num2 = 1000;
                byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(num2);
                int count;
                do
                {
                  count = deflateStream.Read(buffer, 0, num2);
                  if (count > 0)
                  {
label_39:
                    switch (4)
                    {
                      case 0:
                        goto label_39;
                      default:
                        c9654c418e330d33bb3f6a61645043740.c9eda15cf80fff9318c8c21fbca205f58.Write(buffer, 0, count);
                        break;
                    }
                  }
                }
                while (count >= num2);
label_42:
                switch (2)
                {
                  case 0:
                    goto label_42;
                  default:
                    memoryStream = c9654c418e330d33bb3f6a61645043740.c9eda15cf80fff9318c8c21fbca205f58;
                    break;
                }
            }
          }
          if (memoryStream != null)
          {
label_45:
            switch (4)
            {
              case 0:
                goto label_45;
              default:
                return memoryStream.ToArray();
            }
          }
          else
          {
            byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4((int) checked ((IntPtr) unchecked (c90e7c90ead6c95222c8a43ceed60a2b1.Length - c90e7c90ead6c95222c8a43ceed60a2b1.Position)));
            c90e7c90ead6c95222c8a43ceed60a2b1.Read(numArray, 0, (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
            return numArray;
          }
      }
    }
  }
}
