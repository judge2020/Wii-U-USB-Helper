// Decompiled with JetBrains decompiler
// Type: A.c6a07387c2f827de6ca155929a5452624
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace A
{
  public static class c6a07387c2f827de6ca155929a5452624
  {
    public static string CachePath { get; private set; }

    public static void c6122b55a0f5768d890cfe4cf2c0b6543(string c9a465051c588cdd36e3ac168b6fd7267)
    {
      if (!c6a07387c2f827de6ca155929a5452624.c7a7544eb248515de6a83cc809877afc6(c9a465051c588cdd36e3ac168b6fd7267))
        return;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.c6122b55a0f5768d890cfe4cf2c0b6543);
          }
          System.IO.File.Delete(c9a465051c588cdd36e3ac168b6fd7267.c4cd0d9584c1880c171f6ff263d43aa58());
          break;
      }
    }

    public static bool c7a7544eb248515de6a83cc809877afc6(string c9a465051c588cdd36e3ac168b6fd7267)
    {
      return System.IO.File.Exists(c9a465051c588cdd36e3ac168b6fd7267.c4cd0d9584c1880c171f6ff263d43aa58());
    }

    public static byte[] ca344ce84e54eae1aaf7aad18845e6af4(Uri c5272f076b419bee04eaa2f4ef6b812d1, TimeSpan ca2bb951e2e970e4642fef40082379a8a)
    {
      try
      {
        string str = c5272f076b419bee04eaa2f4ef6b812d1.cf61a19d592b3654c508b5ccc3dd12c85().c4cd0d9584c1880c171f6ff263d43aa58();
        if (!str.cc6f5d101c7a499221879c4e0031d7bf4(ca2bb951e2e970e4642fef40082379a8a))
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.ca344ce84e54eae1aaf7aad18845e6af4);
              }
              return System.IO.File.ReadAllBytes(str);
          }
        }
        else
        {
          try
          {
            byte[] bytes = new WebClient().DownloadData(c5272f076b419bee04eaa2f4ef6b812d1);
            System.IO.File.WriteAllBytes(str, bytes);
            return bytes;
          }
          catch
          {
            byte[] numArray;
            if (!System.IO.File.Exists(str))
            {
label_7:
              switch (4)
              {
                case 0:
                  goto label_7;
                default:
                  numArray = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                  break;
              }
            }
            else
              numArray = System.IO.File.ReadAllBytes(str);
            return numArray;
          }
        }
      }
      catch
      {
        return c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      }
    }

    public static void c1f527b2b4106d3462a4dcb965c44086e(Uri c5272f076b419bee04eaa2f4ef6b812d1, TimeSpan ca2bb951e2e970e4642fef40082379a8a, Action<c17920230a4ceab76f3391befe7afb5be> c311a63c62e57ca17ec37c1a14cf9ac19)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c6a07387c2f827de6ca155929a5452624.cf7e33069b351ddafd7938e8a0c1ced18 cf7e33069b351ddafd7938e8a0c1ced18 = new c6a07387c2f827de6ca155929a5452624.cf7e33069b351ddafd7938e8a0c1ced18();
      // ISSUE: reference to a compiler-generated field
      cf7e33069b351ddafd7938e8a0c1ced18.c311a63c62e57ca17ec37c1a14cf9ac19 = c311a63c62e57ca17ec37c1a14cf9ac19;
      // ISSUE: reference to a compiler-generated field
      cf7e33069b351ddafd7938e8a0c1ced18.c577dd1a8f414bdf4c694f7c9e3ef4cbb = c5272f076b419bee04eaa2f4ef6b812d1.cf61a19d592b3654c508b5ccc3dd12c85().c4cd0d9584c1880c171f6ff263d43aa58();
      // ISSUE: reference to a compiler-generated field
      if (cf7e33069b351ddafd7938e8a0c1ced18.c577dd1a8f414bdf4c694f7c9e3ef4cbb.cc6f5d101c7a499221879c4e0031d7bf4(ca2bb951e2e970e4642fef40082379a8a))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.c1f527b2b4106d3462a4dcb965c44086e);
            }
            WebClient webClient = new WebClient();
            // ISSUE: reference to a compiler-generated method
            webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(cf7e33069b351ddafd7938e8a0c1ced18.c077113c25994f30bded7b73874cd9dea);
            try
            {
              webClient.DownloadDataAsync(c5272f076b419bee04eaa2f4ef6b812d1);
              break;
            }
            catch
            {
              break;
            }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (new FileInfo(cf7e33069b351ddafd7938e8a0c1ced18.c577dd1a8f414bdf4c694f7c9e3ef4cbb).Length <= (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7520))
          return;
label_8:
        switch (5)
        {
          case 0:
            goto label_8;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            cf7e33069b351ddafd7938e8a0c1ced18.c311a63c62e57ca17ec37c1a14cf9ac19(new c17920230a4ceab76f3391befe7afb5be(System.IO.File.ReadAllBytes(cf7e33069b351ddafd7938e8a0c1ced18.c577dd1a8f414bdf4c694f7c9e3ef4cbb), cf7e33069b351ddafd7938e8a0c1ced18.c577dd1a8f414bdf4c694f7c9e3ef4cbb, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7524) != 0));
            break;
        }
      }
    }

    public static byte[] c7e86f20e653b3be58c4720bce6b60eb8(string c9a465051c588cdd36e3ac168b6fd7267)
    {
      if (!c6a07387c2f827de6ca155929a5452624.c7a7544eb248515de6a83cc809877afc6(c9a465051c588cdd36e3ac168b6fd7267))
        return (byte[]) null;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.c7e86f20e653b3be58c4720bce6b60eb8);
          }
          return System.IO.File.ReadAllBytes(c9a465051c588cdd36e3ac168b6fd7267.c4cd0d9584c1880c171f6ff263d43aa58());
      }
    }

    public static byte[] c7e86f20e653b3be58c4720bce6b60eb8(Uri ceb45b4a241880521548745128dab6f81)
    {
      return c6a07387c2f827de6ca155929a5452624.c7e86f20e653b3be58c4720bce6b60eb8(ceb45b4a241880521548745128dab6f81.cf61a19d592b3654c508b5ccc3dd12c85());
    }

    public static string[] c79f3734e186fa26ca45e21833e734d4e(string c9a465051c588cdd36e3ac168b6fd7267)
    {
      if (!c6a07387c2f827de6ca155929a5452624.c7a7544eb248515de6a83cc809877afc6(c9a465051c588cdd36e3ac168b6fd7267))
        return (string[]) null;
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.c79f3734e186fa26ca45e21833e734d4e);
          }
          return System.IO.File.ReadAllLines(c9a465051c588cdd36e3ac168b6fd7267.c4cd0d9584c1880c171f6ff263d43aa58());
      }
    }

    public static string c0ca814604d039e0f6b588afe1062db9b(string c167a113bd726afb8f5126bcdea0af0e0)
    {
      return BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.Unicode.GetBytes(c167a113bd726afb8f5126bcdea0af0e0))).Replace(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165), "");
    }

    public static void cafcbd78f0cd6b1f81f0258dccfdc655f(Uri ceb45b4a241880521548745128dab6f81, byte[] c01781c79efcf91c12ac73fb560856eda)
    {
      System.IO.File.WriteAllBytes(ceb45b4a241880521548745128dab6f81.cf61a19d592b3654c508b5ccc3dd12c85().c4cd0d9584c1880c171f6ff263d43aa58(), c01781c79efcf91c12ac73fb560856eda);
    }

    public static void cc0d9971a7869dcbc8bb5a89e4f263c2a(string c9a465051c588cdd36e3ac168b6fd7267, string[] c892d9691e5cd0f3972a4f99a86cd7efa)
    {
      System.IO.File.WriteAllLines(c9a465051c588cdd36e3ac168b6fd7267.c4cd0d9584c1880c171f6ff263d43aa58(), c892d9691e5cd0f3972a4f99a86cd7efa);
    }

    internal static string c4cd0d9584c1880c171f6ff263d43aa58(this string c0cb2cc3c8ec2a27273c7cabb9024894b)
    {
      return c6a07387c2f827de6ca155929a5452624.c4c46c1956e64bf96c695957e1ffb2c73(c0cb2cc3c8ec2a27273c7cabb9024894b);
    }

    internal static string c04af3588427e456339afcfe60e9f6302(string c9a465051c588cdd36e3ac168b6fd7267)
    {
      if (!c6a07387c2f827de6ca155929a5452624.c7a7544eb248515de6a83cc809877afc6(c9a465051c588cdd36e3ac168b6fd7267))
        return (string) null;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.c04af3588427e456339afcfe60e9f6302);
          }
          return System.IO.File.ReadAllText(c9a465051c588cdd36e3ac168b6fd7267.c4cd0d9584c1880c171f6ff263d43aa58());
      }
    }

    internal static void c5673db9ceda1345589497796ee375f9b(string cafeef976033d79a53d893342947f0c71)
    {
      c6a07387c2f827de6ca155929a5452624.CachePath = cafeef976033d79a53d893342947f0c71;
      if (Directory.Exists(c6a07387c2f827de6ca155929a5452624.CachePath))
        return;
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.c5673db9ceda1345589497796ee375f9b);
          }
          Directory.CreateDirectory(c6a07387c2f827de6ca155929a5452624.CachePath);
          break;
      }
    }

    internal static string cf61a19d592b3654c508b5ccc3dd12c85(this Uri c0cb2cc3c8ec2a27273c7cabb9024894b)
    {
      return c6a07387c2f827de6ca155929a5452624.c0ca814604d039e0f6b588afe1062db9b(c0cb2cc3c8ec2a27273c7cabb9024894b.AbsoluteUri);
    }

    private static bool cc6f5d101c7a499221879c4e0031d7bf4(this string c0cb2cc3c8ec2a27273c7cabb9024894b, TimeSpan ca2bb951e2e970e4642fef40082379a8a)
    {
      if (!System.IO.File.Exists(c0cb2cc3c8ec2a27273c7cabb9024894b))
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7528) != 0;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c6a07387c2f827de6ca155929a5452624.cc6f5d101c7a499221879c4e0031d7bf4);
          }
          return c1546ed34f657ad810d4d753d2f51c8f4.c1df95097ffa57d753c5fe1353cf65e86(c745d89fddb05a30e8ef1babd26557977.c1df95097ffa57d753c5fe1353cf65e86(DateTime.Now, new FileInfo(c0cb2cc3c8ec2a27273c7cabb9024894b).LastWriteTime), ca2bb951e2e970e4642fef40082379a8a);
      }
    }

    private static string c4c46c1956e64bf96c695957e1ffb2c73(string c9a465051c588cdd36e3ac168b6fd7267)
    {
      return Path.Combine(c6a07387c2f827de6ca155929a5452624.CachePath, c9a465051c588cdd36e3ac168b6fd7267);
    }
  }
}
