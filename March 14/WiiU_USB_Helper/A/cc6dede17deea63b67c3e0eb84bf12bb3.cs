// Decompiled with JetBrains decompiler
// Type: A.cc6dede17deea63b67c3e0eb84bf12bb3
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace A
{
  public abstract class cc6dede17deea63b67c3e0eb84bf12bb3
  {
    protected readonly cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8;

    public string Name { get; }

    public string Url { get; }

    internal string cc231da0e30fca48cdd3646bf8f7d1a3d
    {
      get
      {
        return Path.Combine(this.c24e473def534920571d33a53d489a74c, this.c36dd98eb0c08ea087627a40c6663c9a8.c0f5bf28fdcef3397fbbb3ca192f34d08());
      }
    }

    internal string c04b4e6eaf974f76e23c9533b68fbee41
    {
      get
      {
        string[] strArray = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7214));
        int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7218);
        string c732b50196f5356e32577e23df14751e4 = ca377ebace9a9e1ffac7b0c5a9158e838.c732b50196f5356e32577e23df14751e4;
        strArray[index1] = c732b50196f5356e32577e23df14751e4;
        int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7222);
        string str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1277);
        strArray[index2] = str1;
        int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7226);
        string str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5581);
        strArray[index3] = str2;
        int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7230);
        string name = this.Name;
        strArray[index4] = name;
        int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7234);
        string str3 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5600);
        strArray[index5] = str3;
        return Path.Combine(strArray);
      }
    }

    internal string c24e473def534920571d33a53d489a74c
    {
      get
      {
        string[] strArray = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7238));
        int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7242);
        string c732b50196f5356e32577e23df14751e4 = ca377ebace9a9e1ffac7b0c5a9158e838.c732b50196f5356e32577e23df14751e4;
        strArray[index1] = c732b50196f5356e32577e23df14751e4;
        int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7246);
        string str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1277);
        strArray[index2] = str1;
        int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7250);
        string str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5581);
        strArray[index3] = str2;
        int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7254);
        string name = this.Name;
        strArray[index4] = name;
        int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7258);
        string str3 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1547);
        strArray[index5] = str3;
        return Path.Combine(strArray);
      }
    }

    internal string c04fe02607dc9aab4a2e6b3af13f258d6
    {
      get
      {
        return Path.Combine(ca377ebace9a9e1ffac7b0c5a9158e838.c732b50196f5356e32577e23df14751e4, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1277), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5581), this.Name);
      }
    }

    internal cc6dede17deea63b67c3e0eb84bf12bb3(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, string ca07972acde10926c077adb10e0e60439, string c7927af27b9cde3902e98e8d96c5a3200)
    {
      this.c36dd98eb0c08ea087627a40c6663c9a8 = c36dd98eb0c08ea087627a40c6663c9a8;
      this.Name = ca07972acde10926c077adb10e0e60439;
      if (!Directory.Exists(this.c04fe02607dc9aab4a2e6b3af13f258d6))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.\u002Ector);
            }
            Directory.CreateDirectory(this.c04fe02607dc9aab4a2e6b3af13f258d6);
            break;
        }
      }
      if (!Directory.Exists(this.c24e473def534920571d33a53d489a74c))
      {
label_6:
        switch (6)
        {
          case 0:
            goto label_6;
          default:
            Directory.CreateDirectory(this.c24e473def534920571d33a53d489a74c);
            break;
        }
      }
      if (!Directory.Exists(this.c04b4e6eaf974f76e23c9533b68fbee41))
      {
label_9:
        switch (5)
        {
          case 0:
            goto label_9;
          default:
            Directory.CreateDirectory(this.c04b4e6eaf974f76e23c9533b68fbee41);
            break;
        }
      }
      this.Url = c7927af27b9cde3902e98e8d96c5a3200;
      ce5854f5adc29e0337aebfe99b1a5bca8.c65035f1404133de248e0c7c2f45a2015(this);
    }

    public virtual void c754046fef40adf702b22895f45ed9448()
    {
      if (this.c36dd98eb0c08ea087627a40c6663c9a8.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7210))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.c754046fef40adf702b22895f45ed9448);
            }
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5534));
        }
      }
      else
      {
        this.c066333ce3593d90c58c8de0f5232ec28();
        this.cf402976abf697f20b90a1d90f202a52f(this.c6e4c2dbbfbe9271a983623cbea8ca50a());
      }
    }

    private void cf402976abf697f20b90a1d90f202a52f(string cc3f7e3711bcb3b0194dfc8ae00e78cd9)
    {
      Process process = new Process();
      process.StartInfo.FileName = this.cbd49da1b139537c117237fef73cb00a6();
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7262);
      process.EnableRaisingEvents = num != 0;
      process.StartInfo.Arguments = cc3f7e3711bcb3b0194dfc8ae00e78cd9;
      process.StartInfo.WorkingDirectory = this.c24e473def534920571d33a53d489a74c;
      process.StartInfo.UseShellExecute = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7266) != 0;
      process.StartInfo.RedirectStandardOutput = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7270) != 0;
      process.Start();
    }

    protected static long c154fcb89e592cf024eb397302d3d5069(Stream c0cb2cc3c8ec2a27273c7cabb9024894b, byte[] ca2cafadc9a3add0d9eed564e0c6f1474)
    {
      long position = c0cb2cc3c8ec2a27273c7cabb9024894b.Position;
      byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7274));
      cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7278);
      cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7282);
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7286);
      int index1;
      int index2;
      do
      {
        int num2 = c0cb2cc3c8ec2a27273c7cabb9024894b.Read(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7290), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
        index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7294);
        index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7298);
        while (index2 < num2)
        {
          num1 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7302);
          if ((int) numArray[index2] == (int) ca2cafadc9a3add0d9eed564e0c6f1474[index1])
          {
label_3:
            switch (6)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.c154fcb89e592cf024eb397302d3d5069);
                }
                index1 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7306);
                break;
            }
          }
          else
            index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7310);
          if (index1 != (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(ca2cafadc9a3add0d9eed564e0c6f1474))
          {
label_9:
            switch (4)
            {
              case 0:
                goto label_9;
              default:
                index2 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7314);
                continue;
            }
          }
          else
            goto label_13;
        }
label_12:
        switch (4)
        {
          case 0:
            goto label_12;
        }
label_13:
        if (num2 > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7318))
        {
label_14:
          switch (1)
          {
            case 0:
              goto label_14;
            default:
              continue;
          }
        }
        else
          goto label_17;
      }
      while (index1 != (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(ca2cafadc9a3add0d9eed564e0c6f1474));
label_16:
      switch (2)
      {
        case 0:
          goto label_16;
      }
label_17:
      c0cb2cc3c8ec2a27273c7cabb9024894b.Seek(position + (long) num1 - (long) (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(ca2cafadc9a3add0d9eed564e0c6f1474), (SeekOrigin) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7322));
      return position + (long) index2 - (long) (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(ca2cafadc9a3add0d9eed564e0c6f1474);
    }

    protected void c04cfcac61652be3faa2a62c8ddeabf3d()
    {
      string path1 = Path.Combine(c6a07387c2f827de6ca155929a5452624.CachePath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5607));
      if (!File.Exists(path1))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.c04cfcac61652be3faa2a62c8ddeabf3d);
            }
            File.WriteAllBytes(path1, c27603360ccc8374975348defb9eee9fc.rpl2elf);
            break;
        }
      }
      int num1 = (int) ((Form) new cd31cf38d8c521c96d342d3061f93a308(this.c36dd98eb0c08ea087627a40c6663c9a8, this.c24e473def534920571d33a53d489a74c)).ShowDialog();
      Process process = new Process();
      string path2 = this.c30490081128eba70b0d93f9cb031447e();
      string str = this.c55a5d8ae0323b4832e546dcec3994ea5();
      process.StartInfo.FileName = path1;
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7326);
      process.EnableRaisingEvents = num2 != 0;
      process.StartInfo.CreateNoWindow = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7330) != 0;
      process.StartInfo.Arguments = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5630), (object) path2, (object) str);
      process.StartInfo.WorkingDirectory = Path.GetDirectoryName(path2);
      process.StartInfo.UseShellExecute = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7334) != 0;
      process.Start();
      process.WaitForExit();
    }

    protected virtual string c6e4c2dbbfbe9271a983623cbea8ca50a()
    {
      return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5653), (object) this.cb85dafae1f67c1dc25305f1961a9680a());
    }

    protected string c55a5d8ae0323b4832e546dcec3994ea5()
    {
      return cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(this.c30490081128eba70b0d93f9cb031447e(), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5664));
    }

    protected abstract string cbd49da1b139537c117237fef73cb00a6();

    protected abstract string cb85dafae1f67c1dc25305f1961a9680a();

    protected string c30490081128eba70b0d93f9cb031447e()
    {
      string path = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(Path.Combine(this.cc231da0e30fca48cdd3646bf8f7d1a3d, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5673)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3304));
      if (!Directory.Exists(path))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.c30490081128eba70b0d93f9cb031447e);
            }
            return "";
        }
      }
      else
      {
        string[] files = Directory.GetFiles(path);
        // ISSUE: reference to a compiler-generated field
        Func<string, bool> predicate = cc6dede17deea63b67c3e0eb84bf12bb3.\u003C\u003Ec.c40b411f1a9fca2336edc82cb0b6b423d;
        if (predicate == null)
        {
label_6:
          switch (5)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              predicate = cc6dede17deea63b67c3e0eb84bf12bb3.\u003C\u003Ec.c40b411f1a9fca2336edc82cb0b6b423d = new Func<string, bool>(cc6dede17deea63b67c3e0eb84bf12bb3.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c4296efff91852571b367a1a3c14656a8);
              break;
          }
        }
        List<string> list = ((IEnumerable<string>) files).Where<string>(predicate).ToList<string>();
        if (list.Any<string>())
          return list[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7338)];
label_9:
        switch (3)
        {
          case 0:
            goto label_9;
          default:
            return "";
        }
      }
    }

    private static void c08d45e6b634b230032108519707e8121(string c91bdea4c2158733ad8ad5be54c93bfe3)
    {
      string[] directories = Directory.GetDirectories(c91bdea4c2158733ad8ad5be54c93bfe3);
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7342);
      while (index < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(directories))
      {
        string str = directories[index];
        cc6dede17deea63b67c3e0eb84bf12bb3.c08d45e6b634b230032108519707e8121(str);
        if ((IntPtr) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(Directory.GetFiles(str)) == IntPtr.Zero)
        {
label_2:
          switch (3)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.c08d45e6b634b230032108519707e8121);
              }
              if ((IntPtr) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(Directory.GetDirectories(str)) == IntPtr.Zero)
              {
label_6:
                switch (4)
                {
                  case 0:
                    goto label_6;
                  default:
                    Directory.Delete(str, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7346) != 0);
                    break;
                }
              }
              else
                break;
          }
        }
        index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7350);
      }
label_10:
      switch (3)
      {
        case 0:
          goto label_10;
      }
    }

    protected void ccf65faa6e27f93aff8feac8d628ba99a()
    {
      string c33ad1bd311fd4b32b85377e9e15a9d93 = this.cb85dafae1f67c1dc25305f1961a9680a();
      string[] files = Directory.GetFiles(this.cc231da0e30fca48cdd3646bf8f7d1a3d, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(5682), (SearchOption) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7354));
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7358);
      while (index < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(files))
      {
        string str = files[index];
        if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(str, c33ad1bd311fd4b32b85377e9e15a9d93))
        {
label_2:
          switch (3)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.ccf65faa6e27f93aff8feac8d628ba99a);
              }
              try
              {
                File.Delete(str);
                break;
              }
              catch
              {
                break;
              }
          }
        }
        index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7362);
      }
label_10:
      switch (1)
      {
        case 0:
          goto label_10;
        default:
          cc6dede17deea63b67c3e0eb84bf12bb3.c08d45e6b634b230032108519707e8121(this.cc231da0e30fca48cdd3646bf8f7d1a3d);
          break;
      }
    }

    protected virtual void c066333ce3593d90c58c8de0f5232ec28()
    {
      if (File.Exists(this.cb85dafae1f67c1dc25305f1961a9680a()))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cc6dede17deea63b67c3e0eb84bf12bb3.c066333ce3593d90c58c8de0f5232ec28);
            }
            if (new FileInfo(this.cb85dafae1f67c1dc25305f1961a9680a()).Length != 0L)
              return;
label_5:
            switch (6)
            {
              case 0:
                goto label_5;
            }
        }
      }
      int num = (int) ((Form) new cd31cf38d8c521c96d342d3061f93a308(this.c36dd98eb0c08ea087627a40c6663c9a8, this.c24e473def534920571d33a53d489a74c)).ShowDialog();
    }
  }
}
