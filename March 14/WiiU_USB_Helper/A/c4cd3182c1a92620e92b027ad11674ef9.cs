// Decompiled with JetBrains decompiler
// Type: A.c4cd3182c1a92620e92b027ad11674ef9
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;
using NusHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace A
{
  public sealed class c4cd3182c1a92620e92b027ad11674ef9
  {
    private c6129afa4402302c2a80ba8a6c17a4ec1 cf537d3e7745eb38a61f701a46216e614;

    public string c0344195c5dcec47703262019eec927f2
    {
      get
      {
        return this.c4007db3f763a1560b1c531388509f224.description;
      }
    }

    public string c55abd5c899c7ea6191fd271110833073
    {
      get
      {
        return this.c4007db3f763a1560b1c531388509f224.download_location;
      }
    }

    public string Location { get; private set; }

    public string c80d3600743543b4d9ff71a8fbc9acf6d
    {
      get
      {
        return this.c4007db3f763a1560b1c531388509f224.name;
      }
    }

    public List<TitleId> ccf55a79e65fd796f8cb46b4e92f79a1d
    {
      get
      {
        string str = new WebClient().DownloadString(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(this.Location, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6837)));
        char[] chArray = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7608));
        int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7612);
        int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7616);
        chArray[index] = (char) num;
        string[] strArray = str.Split(chArray);
        Func<string, bool> predicate = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c8440c0f5df84e5d8d53e762aad06c66d;
        if (predicate == null)
        {
label_1:
          switch (5)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c4cd3182c1a92620e92b027ad11674ef9.get_ccf55a79e65fd796f8cb46b4e92f79a1d);
              }
              predicate = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c8440c0f5df84e5d8d53e762aad06c66d = new Func<string, bool>(c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c2c11c57ca2170e4a76ebc37cc5688e32);
              break;
          }
        }
        IEnumerable<string> source = ((IEnumerable<string>) strArray).Where<string>(predicate);
        Func<string, TitleId> selector = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c489e2ea03d692d1fc67e75291295369c;
        if (selector == null)
        {
label_6:
          switch (6)
          {
            case 0:
              goto label_6;
            default:
              selector = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c489e2ea03d692d1fc67e75291295369c = new Func<string, TitleId>(c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.ca24b70b66a00ff3999449d923188d049);
              break;
          }
        }
        return source.Select<string, TitleId>(selector).ToList<TitleId>();
      }
    }

    private c6129afa4402302c2a80ba8a6c17a4ec1 c4007db3f763a1560b1c531388509f224
    {
      get
      {
        c6129afa4402302c2a80ba8a6c17a4ec1 cf537d3e7745eb38a61f701a46216e614 = this.cf537d3e7745eb38a61f701a46216e614;
        if (cf537d3e7745eb38a61f701a46216e614 != null)
          return cf537d3e7745eb38a61f701a46216e614;
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c4cd3182c1a92620e92b027ad11674ef9.get_c4007db3f763a1560b1c531388509f224);
            }
            return this.cf537d3e7745eb38a61f701a46216e614 = JsonConvert.DeserializeObject<c6129afa4402302c2a80ba8a6c17a4ec1>(new WebClient().DownloadString(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(this.Location, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6929))));
        }
      }
    }

    public c4cd3182c1a92620e92b027ad11674ef9(string c5272f076b419bee04eaa2f4ef6b812d1)
    {
      this.Location = c5272f076b419bee04eaa2f4ef6b812d1;
      if (!cdf6c91719eae5a38c64a7fd64afdf5e1.c1df95097ffa57d753c5fe1353cf65e86(c5272f076b419bee04eaa2f4ef6b812d1.Substring(c5272f076b419bee04eaa2f4ef6b812d1.Length - cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7628)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241)))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c4cd3182c1a92620e92b027ad11674ef9.\u002Ector);
          }
          this.Location = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(this.Location, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(241));
          break;
      }
    }

    public static bool c2818ab45b4841acf151bc0cfd9282673(string c7927af27b9cde3902e98e8d96c5a3200)
    {
      try
      {
        new WebClient().DownloadString(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c7927af27b9cde3902e98e8d96c5a3200, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6858)));
        new WebClient().DownloadString(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c7927af27b9cde3902e98e8d96c5a3200, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6889)));
      }
      catch (Exception ex)
      {
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7620) != 0;
      }
      return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7624) != 0;
    }

    public static List<c4cd3182c1a92620e92b027ad11674ef9> cb5009c1058eaad54842d9bead8e530a2()
    {
      if (!c6a07387c2f827de6ca155929a5452624.c7a7544eb248515de6a83cc809877afc6(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6918)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c4cd3182c1a92620e92b027ad11674ef9.cb5009c1058eaad54842d9bead8e530a2);
            }
            return new List<c4cd3182c1a92620e92b027ad11674ef9>();
        }
      }
      else
      {
        string[] strArray = c6a07387c2f827de6ca155929a5452624.c79f3734e186fa26ca45e21833e734d4e(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6918));
        // ISSUE: reference to a compiler-generated field
        Func<string, c4cd3182c1a92620e92b027ad11674ef9> selector = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c1354a7865895e7a740608665e05c9e60;
        if (selector == null)
        {
label_6:
          switch (2)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              selector = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c1354a7865895e7a740608665e05c9e60 = new Func<string, c4cd3182c1a92620e92b027ad11674ef9>(c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.ca974f25f00bfdfeef523c33e694cc1fc);
              break;
          }
        }
        return ((IEnumerable<string>) strArray).Select<string, c4cd3182c1a92620e92b027ad11674ef9>(selector).ToList<c4cd3182c1a92620e92b027ad11674ef9>();
      }
    }

    public static void cb6adf0c73c9376d391adb646e5fc3866(IEnumerable<c4cd3182c1a92620e92b027ad11674ef9> c23e0d8bc302a7d276ede38dd60c5f65a)
    {
      string c9a465051c588cdd36e3ac168b6fd7267 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6918);
      IEnumerable<c4cd3182c1a92620e92b027ad11674ef9> source = c23e0d8bc302a7d276ede38dd60c5f65a;
      // ISSUE: reference to a compiler-generated field
      Func<c4cd3182c1a92620e92b027ad11674ef9, string> selector = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c0a2200ac44801c8385b5d99af0116aa0;
      if (selector == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c4cd3182c1a92620e92b027ad11674ef9.cb6adf0c73c9376d391adb646e5fc3866);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            selector = c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c0a2200ac44801c8385b5d99af0116aa0 = new Func<c4cd3182c1a92620e92b027ad11674ef9, string>(c4cd3182c1a92620e92b027ad11674ef9.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c12404d27a2d1a0fd9ddbd43e164ee9c2);
            break;
        }
      }
      string[] array = source.Select<c4cd3182c1a92620e92b027ad11674ef9, string>(selector).ToArray<string>();
      c6a07387c2f827de6ca155929a5452624.cc0d9971a7869dcbc8bb5a89e4f263c2a(c9a465051c588cdd36e3ac168b6fd7267, array);
    }

    public override string ToString()
    {
      return this.c80d3600743543b4d9ff71a8fbc9acf6d;
    }
  }
}
