// Decompiled with JetBrains decompiler
// Type: A.c641344460c4912d7feb758c824455611
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace A
{
  internal class c641344460c4912d7feb758c824455611
  {
    internal const uint ce556f2f0ac76833faf2bcfd80daf4d18 = 1024;
    internal const uint cd8b6e9c2c00234f8a313611d3c368d55 = 64;
    internal const int cad8651ec94ddaeacbde291283489b6e2 = 0;
    private static bool c529872859e945c44f6eb1bcaacef5665;

    [DllImport("kernel32.dll", EntryPoint = "SetLastError")]
    internal static extern void c3d7563bff4ecdd56049cdfd38f0f5386(uint c761cffd94740ceffae893540f416d37a);

    [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
    internal static extern int c23d67fe6d320d261324285cd768bf36a(IntPtr c2ddcdfe82d17b8d40b7b196c13fc1bef);

    [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
    internal static extern IntPtr c7666d7701d7abaf8a6a001fc165e96a1(uint c382221e89c46e1e4e4bdc4c457ab1a77, int cb5b5dcce16b7e4c29cc4018f7b3568ea, uint c50ea0292a1735c8d897bcd55a58fff2f);

    [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId")]
    internal static extern uint cf85c937755512220cba894a03bedec89();

    [DllImport("kernel32.dll", EntryPoint = "LoadLibrary", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern IntPtr c5a9708bee1469edcba59ccdc93da2f2f(string c7c3e15c7f38d84f63b902daf21202899);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern c641344460c4912d7feb758c824455611.c91e118e3a45af5c0d6fee9db3de9620d c8257a2dddcd3bd474200d98b76be47f9(IntPtr c403ccf237067820a7bc9f36d029bf668, string c2f9cc1cbbde92aac07b6b4305b5c9bf4);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern c641344460c4912d7feb758c824455611.cafcead622bd6635890689ac9fa2bda26 c19ab0c242931b2ea754cd1257a876b61(IntPtr c403ccf237067820a7bc9f36d029bf668, string c2f9cc1cbbde92aac07b6b4305b5c9bf4);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern c641344460c4912d7feb758c824455611.caeda98354efd0b427c75be62b9aeca9e c5747bdb6ffe514e4fa3e3645ddf42056(IntPtr c403ccf237067820a7bc9f36d029bf668, string c2f9cc1cbbde92aac07b6b4305b5c9bf4);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern c641344460c4912d7feb758c824455611.c41a95f971d5376a2454735397b904ffc c79e60bc7d7e335ace7775466c5649d03(IntPtr c403ccf237067820a7bc9f36d029bf668, string c2f9cc1cbbde92aac07b6b4305b5c9bf4);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern c641344460c4912d7feb758c824455611.c7a1295ea2288c5d71a2424088eb45f51 ce1539e37fd29012e72bc85e018d4b245(IntPtr c403ccf237067820a7bc9f36d029bf668, string c2f9cc1cbbde92aac07b6b4305b5c9bf4);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern c641344460c4912d7feb758c824455611.ca4a5537a838ee0fbcfce0100e41ca7a8 cfd9eef77f13c58e7f4b2f04cbfc03c72(IntPtr c403ccf237067820a7bc9f36d029bf668, string c2f9cc1cbbde92aac07b6b4305b5c9bf4);

    private static int ccb6273a8b2397a5892d3056fbee91b64(IntPtr c29b74951fd829635e1abf420c03aabfa, IntPtr c2e8b20fe4362911f2f3d01c0ecae5e42)
    {
      string[] strArray1 = c1a43086d62c5283435ed501dd585a1b1.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20278));
      strArray1[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20282)] = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37010);
      string[] strArray2 = strArray1;
      string strA = c641344460c4912d7feb758c824455611.c3a682445611677a5256c207af9546ed5(c29b74951fd829635e1abf420c03aabfa);
      string[] c33ad1bd311fd4b32b85377e9e15a9d93 = strArray2;
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20286);
      while (index < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93))
      {
        string strB = c33ad1bd311fd4b32b85377e9e15a9d93[index];
        if (string.Compare(strA, strB, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20290) != 0) == 0)
        {
label_2:
          switch (7)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c641344460c4912d7feb758c824455611.ccb6273a8b2397a5892d3056fbee91b64);
              }
              c641344460c4912d7feb758c824455611.c529872859e945c44f6eb1bcaacef5665 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20294) != 0;
              return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20298);
          }
        }
        else
          index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20302);
      }
label_8:
      switch (4)
      {
        case 0:
          goto label_8;
        default:
          return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20306);
      }
    }

    [DllImport("user32.dll", EntryPoint = "GetClassName", CharSet = CharSet.Auto)]
    internal static extern int c214ea9b0b694715cded3a61b4c6200b9(IntPtr c5426ca9dcc0d24fd77550a86c472ad5b, StringBuilder c917467742d6c8b7752ab3163f6415b9f, int c3225dc2779ec92a2a6c7b477765cea81);

    internal static string c3a682445611677a5256c207af9546ed5(IntPtr c870672649790fcf310e5f2229b6d2b64)
    {
      StringBuilder c917467742d6c8b7752ab3163f6415b9f = new StringBuilder(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20310));
      c641344460c4912d7feb758c824455611.c214ea9b0b694715cded3a61b4c6200b9(c870672649790fcf310e5f2229b6d2b64, c917467742d6c8b7752ab3163f6415b9f, c917467742d6c8b7752ab3163f6415b9f.Capacity);
      return c917467742d6c8b7752ab3163f6415b9f.ToString();
    }

    internal static void c384b68a3ce05d01196ef82b6e76bbcf2()
    {
      if (!c641344460c4912d7feb758c824455611.c6db46787f6fab7e9aab7f2014ec69cb1())
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c641344460c4912d7feb758c824455611.c384b68a3ce05d01196ef82b6e76bbcf2);
          }
          throw new Exception(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37042), (object) c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37025)));
      }
    }

    internal static bool c6db46787f6fab7e9aab7f2014ec69cb1()
    {
      try
      {
        if (Debugger.IsAttached)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c641344460c4912d7feb758c824455611.c6db46787f6fab7e9aab7f2014ec69cb1);
              }
              return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20314) != 0;
          }
        }
        else
        {
          IntPtr c403ccf237067820a7bc9f36d029bf668 = c641344460c4912d7feb758c824455611.c5a9708bee1469edcba59ccdc93da2f2f(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37169));
          c641344460c4912d7feb758c824455611.c41a95f971d5376a2454735397b904ffc c41a95f971d5376a2454735397b904ffc = c641344460c4912d7feb758c824455611.c79e60bc7d7e335ace7775466c5649d03(c403ccf237067820a7bc9f36d029bf668, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37194));
          if (c41a95f971d5376a2454735397b904ffc != null)
          {
label_6:
            switch (2)
            {
              case 0:
                goto label_6;
              default:
                if (c41a95f971d5376a2454735397b904ffc() != 0)
                {
label_8:
                  switch (5)
                  {
                    case 0:
                      goto label_8;
                    default:
                      return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20318) != 0;
                  }
                }
                else
                  break;
            }
          }
          IntPtr num1 = c641344460c4912d7feb758c824455611.c7666d7701d7abaf8a6a001fc165e96a1((uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20322), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20326), c641344460c4912d7feb758c824455611.cf85c937755512220cba894a03bedec89());
          if (c1eb05145274034fc69a3292a824f7c0b.c1df95097ffa57d753c5fe1353cf65e86(num1, IntPtr.Zero))
          {
label_11:
            switch (3)
            {
              case 0:
                goto label_11;
              default:
                try
                {
                  c641344460c4912d7feb758c824455611.caeda98354efd0b427c75be62b9aeca9e caeda98354efd0b427c75be62b9aeca9e = c641344460c4912d7feb758c824455611.c5747bdb6ffe514e4fa3e3645ddf42056(c403ccf237067820a7bc9f36d029bf668, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37229));
                  if (caeda98354efd0b427c75be62b9aeca9e != null)
                  {
label_13:
                    switch (2)
                    {
                      case 0:
                        goto label_13;
                      default:
                        int pbDebuggerPresent = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20330);
                        if (caeda98354efd0b427c75be62b9aeca9e(num1, ref pbDebuggerPresent) != 0)
                        {
label_15:
                          switch (7)
                          {
                            case 0:
                              goto label_15;
                            default:
                              if (pbDebuggerPresent != 0)
                              {
label_17:
                                switch (1)
                                {
                                  case 0:
                                    goto label_17;
                                  default:
                                    return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20334) != 0;
                                }
                              }
                              else
                                break;
                          }
                        }
                        else
                          break;
                    }
                  }
                  else
                    break;
                }
                finally
                {
                  c641344460c4912d7feb758c824455611.c23d67fe6d320d261324285cd768bf36a(num1);
                }
            }
          }
          bool flag = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20338) != 0;
          try
          {
            c641344460c4912d7feb758c824455611.c23d67fe6d320d261324285cd768bf36a(new IntPtr(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20342)));
          }
          catch
          {
            flag = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20346) != 0;
          }
          if (flag)
          {
label_24:
            switch (7)
            {
              case 0:
                goto label_24;
              default:
                return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20350) != 0;
            }
          }
          else
          {
            try
            {
              c641344460c4912d7feb758c824455611.ca4a5537a838ee0fbcfce0100e41ca7a8 ca4a5537a838ee0fbcfce0100e41ca7a8 = c641344460c4912d7feb758c824455611.cfd9eef77f13c58e7f4b2f04cbfc03c72(c641344460c4912d7feb758c824455611.c5a9708bee1469edcba59ccdc93da2f2f(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37282)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(37303));
              if (ca4a5537a838ee0fbcfce0100e41ca7a8 != null)
              {
label_27:
                switch (3)
                {
                  case 0:
                    goto label_27;
                  default:
                    c641344460c4912d7feb758c824455611.c529872859e945c44f6eb1bcaacef5665 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20354) != 0;
                    int num2 = ca4a5537a838ee0fbcfce0100e41ca7a8(new c641344460c4912d7feb758c824455611.c3a180c21af1ab77668f0a09d89798d7a(c641344460c4912d7feb758c824455611.ccb6273a8b2397a5892d3056fbee91b64), IntPtr.Zero);
                    if (c641344460c4912d7feb758c824455611.c529872859e945c44f6eb1bcaacef5665)
                    {
label_29:
                      switch (1)
                      {
                        case 0:
                          goto label_29;
                        default:
                          return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20358) != 0;
                      }
                    }
                    else
                      break;
                }
              }
            }
            catch
            {
            }
          }
        }
      }
      catch
      {
      }
      return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(20362) != 0;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal class c3e7c2f409994275562939c83dffbccce
    {
      internal IntPtr ce1b905517bfd849f6b6f1d9543b5daca;
      internal IntPtr c9bbc58cf99fddfb24e719d2bf1072ac5;
      internal IntPtr c136c574556f59cc8a09dc5f9fb5974bc;
      internal IntPtr c58c6be44cc40c415e436d95e8ba02285;
      internal IntPtr c3aee439d71954ed920411172b9a36577;
      internal IntPtr cf00c142fea1757b39646cf13b1460a8c;
    }

    internal delegate int c91e118e3a45af5c0d6fee9db3de9620d(IntPtr ProcessHandle, int ProcessInformationClass, c641344460c4912d7feb758c824455611.c3e7c2f409994275562939c83dffbccce ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

    internal delegate int cafcead622bd6635890689ac9fa2bda26(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

    internal delegate int c41a95f971d5376a2454735397b904ffc();

    internal delegate void c7a1295ea2288c5d71a2424088eb45f51([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

    internal delegate int caeda98354efd0b427c75be62b9aeca9e(IntPtr hProcess, ref int pbDebuggerPresent);

    internal delegate int c3a180c21af1ab77668f0a09d89798d7a(IntPtr wnd, IntPtr lParam);

    internal delegate int ca4a5537a838ee0fbcfce0100e41ca7a8(c641344460c4912d7feb758c824455611.c3a180c21af1ab77668f0a09d89798d7a lpEnumFunc, IntPtr lParam);
  }
}
