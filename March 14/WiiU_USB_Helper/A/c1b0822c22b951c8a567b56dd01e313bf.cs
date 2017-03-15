// Decompiled with JetBrains decompiler
// Type: A.c1b0822c22b951c8a567b56dd01e313bf
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;
using NusHelper.Server;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Telerik.WinControls;

namespace A
{
  public static class c1b0822c22b951c8a567b56dd01e313bf
  {
    private const int ceed7c78c1c5095d2ffa73b127aff2a04 = 4;

    public static cd1a6b8a2145a47d233d2d260c0456822 Donator { get; private set; }

    public static bool c727abdef873c71ae15e67e1b27e2ad96
    {
      get
      {
        return c1b0822c22b951c8a567b56dd01e313bf.Donator > ccc7b045552fc87fbdab912aa66ab1ec9.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
    }

    public static bool c542b07bca4ac71d6066fe0b566b1b3f9(int c5d5948a8274478b580d4ed74dfde289d, string c4d45c6e468d9560ee4f9dd32ffb3d8b8, string c7f1167054f65d0aecb089c8af12d98ea)
    {
      c1b0822c22b951c8a567b56dd01e313bf.ca8d3f090040777e16dd5611bef37f89e(c4d45c6e468d9560ee4f9dd32ffb3d8b8, c7f1167054f65d0aecb089c8af12d98ea);
      if (!c1b0822c22b951c8a567b56dd01e313bf.c727abdef873c71ae15e67e1b27e2ad96)
        return (c5d5948a8274478b580d4ed74dfde289d < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7536) ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7540);
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b0822c22b951c8a567b56dd01e313bf.c542b07bca4ac71d6066fe0b566b1b3f9);
          }
          return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7532) != 0;
      }
    }

    public static void ca8d3f090040777e16dd5611bef37f89e(string caa6efd81a7f2c6711705ce24b86e0cec, string c7f1167054f65d0aecb089c8af12d98ea)
    {
      if (caa6efd81a7f2c6711705ce24b86e0cec == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b0822c22b951c8a567b56dd01e313bf.ca8d3f090040777e16dd5611bef37f89e);
            }
            c1b0822c22b951c8a567b56dd01e313bf.Donator = ccc7b045552fc87fbdab912aa66ab1ec9.c20c00b8e97bb4c0fb2b7ac6facf98b91;
            break;
        }
      }
      else
      {
        byte[] c33ad1bd311fd4b32b85377e9e15a9d93;
        try
        {
          c33ad1bd311fd4b32b85377e9e15a9d93 = Convert.FromBase64String(caa6efd81a7f2c6711705ce24b86e0cec);
        }
        catch
        {
          c1b0822c22b951c8a567b56dd01e313bf.Donator = ccc7b045552fc87fbdab912aa66ab1ec9.c20c00b8e97bb4c0fb2b7ac6facf98b91;
          return;
        }
        if ((int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93) != cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7544))
        {
label_8:
          switch (5)
          {
            case 0:
              goto label_8;
            default:
              c1b0822c22b951c8a567b56dd01e313bf.Donator = ccc7b045552fc87fbdab912aa66ab1ec9.c20c00b8e97bb4c0fb2b7ac6facf98b91;
              break;
          }
        }
        else
        {
          byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7548));
          byte[] signature = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7552));
          Buffer.BlockCopy((Array) c33ad1bd311fd4b32b85377e9e15a9d93, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7556), (Array) buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7560), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7564));
          Buffer.BlockCopy((Array) c33ad1bd311fd4b32b85377e9e15a9d93, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7568), (Array) signature, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7572), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7576));
          RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider();
          try
          {
            cryptoServiceProvider.FromXmlString(c7f1167054f65d0aecb089c8af12d98ea);
            cd1a6b8a2145a47d233d2d260c0456822 cd1a6b8a2145a47d233d2d260c0456822;
            if (!cryptoServiceProvider.VerifyData(buffer, (object) CryptoConfig.MapNameToOID(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6168)), signature))
            {
label_12:
              switch (5)
              {
                case 0:
                  goto label_12;
                default:
                  cd1a6b8a2145a47d233d2d260c0456822 = ccc7b045552fc87fbdab912aa66ab1ec9.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  break;
              }
            }
            else
              cd1a6b8a2145a47d233d2d260c0456822 = c1b0822c22b951c8a567b56dd01e313bf.cf7ac64bd99d3f7417d1046d18c2067d9(caa6efd81a7f2c6711705ce24b86e0cec);
            c1b0822c22b951c8a567b56dd01e313bf.Donator = cd1a6b8a2145a47d233d2d260c0456822;
          }
          finally
          {
            if (cryptoServiceProvider != null)
            {
label_17:
              switch (7)
              {
                case 0:
                  goto label_17;
                default:
                  cryptoServiceProvider.Dispose();
                  break;
              }
            }
          }
        }
      }
    }

    private static cd1a6b8a2145a47d233d2d260c0456822 cf7ac64bd99d3f7417d1046d18c2067d9(string caa6efd81a7f2c6711705ce24b86e0cec)
    {
      KeyValidationResponse validationResponse = JsonConvert.DeserializeObject<KeyValidationResponse>(Encoding.UTF8.GetString(new WebClient().UploadValues(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6177), new NameValueCollection()
      {
        {
          c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6298),
          caa6efd81a7f2c6711705ce24b86e0cec
        }
      })));
      if (validationResponse.Accepted)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b0822c22b951c8a567b56dd01e313bf.cf7ac64bd99d3f7417d1046d18c2067d9);
            }
            return new cd1a6b8a2145a47d233d2d260c0456822(validationResponse.Email, validationResponse.Key, validationResponse.DonationDate);
        }
      }
      else
      {
        int num = (int) RadMessageBox.Show(validationResponse.Message);
        return (cd1a6b8a2145a47d233d2d260c0456822) null;
      }
    }
  }
}
