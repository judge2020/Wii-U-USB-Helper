// Decompiled with JetBrains decompiler
// Type: A.cba6aa8f767d2e8dfbca2d43d7148c173
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Microsoft.VisualBasic.FileIO;
using NusHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace A
{
  public abstract class cba6aa8f767d2e8dfbca2d43d7148c173
  {
    private static string c96d3a8c111985758b9e8c23f458a5cf9 = Path.Combine(c6a07387c2f827de6ca155929a5452624.CachePath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2871));
    private static string ca4049804a6ae4db9373cdd10c16e9b08 = Path.Combine(c6a07387c2f827de6ca155929a5452624.CachePath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2894));
    private static string c40611bb7e13fc8b2313decf79d8a7bad = Path.Combine(c6a07387c2f827de6ca155929a5452624.CachePath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2917));
    private static string ca4f44371cce09a02b7490a27054dbf02 = Path.Combine(c6a07387c2f827de6ca155929a5452624.CachePath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2924));
    private DateTime cdef87411c5692b61fa14499905795332 = DateTime.MinValue;
    public string c3e44ecba2cc05a921770e798b38b0d77;
    public bool c01b0607eff3104877812c454678313d9;
    public byte[] c9536899c8db7d9fc10b867798a27bf8c;
    protected static List<string> c0fff13d9b7de393267a3b3d54a50e81f;
    internal const int c6df28230b00b25bc7b1dcc255f575ae5 = 65536;
    private const int c2b9d9dac36166d776e8063b1c9110aa5 = 64512;
    private const int c3a0fedeedf162afc833116eaccaba84f = 1024;
    private cb48a6650cad6d81c80da89dfe58b703a c3c5af4fcc9ae412f05eb5bde3fe30427;
    private c04094fd9c48096d147c0fc6cc8a97c26 cca23d7b2a91be5252f701fdb103c7f16;

    public virtual string OutputPath { get; } = ca377ebace9a9e1ffac7b0c5a9158e838.c732b50196f5356e32577e23df14751e4;

    public int c38dee32ccaa64d9ac65631acafd39f04
    {
      get
      {
        return c2e2f19e8cde9983e4129b4a047c9f5c6.ced8387ade389cd60272293a2558a4364(this.ce4e8a9e708b2d179e6d61ae42efeed76(), (long) this.Size.TotalBytes);
      }
    }

    public bool CfwOnly { get; set; }

    public bool CustomTitle { get; set; }

    public cb48a6650cad6d81c80da89dfe58b703a c7adb0b831ae9d44c1bc321f4993f8d5d
    {
      get
      {
        if (c745d89fddb05a30e8ef1babd26557977.c1df95097ffa57d753c5fe1353cf65e86(DateTime.Now, this.cdef87411c5692b61fa14499905795332).TotalSeconds <= cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(292))
        {
label_1:
          switch (5)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.get_c7adb0b831ae9d44c1bc321f4993f8d5d);
              }
              return this.c3c5af4fcc9ae412f05eb5bde3fe30427;
          }
        }
        else
        {
          this.cdef87411c5692b61fa14499905795332 = DateTime.Now;
          this.c3c5af4fcc9ae412f05eb5bde3fe30427 = this.c291c6bb8b6e1a373030523d15db983f9();
          return this.c3c5af4fcc9ae412f05eb5bde3fe30427;
        }
      }
    }

    public Platform Platform { get; internal set; }

    public caff792dac5a5e2f17b0e81e59bba386d System { get; internal set; }

    public string c62c40cf74825a86f2ba018c8a07f11e2
    {
      get
      {
        return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1855), (object) this.RootDownloadLocation, (object) this.TitleId);
      }
    }

    public bool Hidden { get; set; }

    public string Name { get; set; }

    public string Region { get; private set; }

    public DataSize Size { get; private set; }

    public byte[] TicketArray { get; set; }

    public c1d5d0d4f9464e1d296ba85cf189ecad6 Ticket { get; set; }

    public TitleId TitleId { get; }

    public cff72ea250ac36ea03abde33ff61b7565 Tmd { get; set; }

    public bool CurrentlyDownloaded { get; internal set; }

    public bool CurrentlyUploaded { get; internal set; }

    public Color cfed4875cfd556dd488b4a4d828cb7bc5
    {
      get
      {
        switch (this.c7adb0b831ae9d44c1bc321f4993f8d5d)
        {
          case cb48a6650cad6d81c80da89dfe58b703a.c83db08052b4defd7f123a5703adcaf4a:
            return Color.Red;
          case cb48a6650cad6d81c80da89dfe58b703a.ca4635737d0de96678db48b9d01ce5b3a:
            return Color.Orange;
          case cb48a6650cad6d81c80da89dfe58b703a.ccbbe095bbcb593f1ae7554d054de8de1:
            return Color.Green;
          default:
            return Color.Red;
        }
      }
    }

    public string c1cd3f03faaa582cb55a64d18b0c07fb3
    {
      get
      {
        switch (this.c7adb0b831ae9d44c1bc321f4993f8d5d)
        {
          case cb48a6650cad6d81c80da89dfe58b703a.c83db08052b4defd7f123a5703adcaf4a:
            return c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2111);
          case cb48a6650cad6d81c80da89dfe58b703a.ca4635737d0de96678db48b9d01ce5b3a:
            return c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2036);
          case cb48a6650cad6d81c80da89dfe58b703a.ccbbe095bbcb593f1ae7554d054de8de1:
            return c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1963);
          default:
            return c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2111);
        }
      }
    }

    public string Version { get; protected set; }

    protected string c6de6c5dc546a67d110feb8f495ab222d
    {
      get
      {
        return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2241), (object) cba6aa8f767d2e8dfbca2d43d7148c173.c134c073db1c5675227938edebbefc4bd(this.Name), (object) this.TitleId);
      }
    }

    public virtual string ce7a5964b7f9ba43afcebe1e7d79151c7
    {
      get
      {
        return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2694), (object) cba6aa8f767d2e8dfbca2d43d7148c173.cad087c9dfcaf00cb38757d0c5997cbf0(this.c6de6c5dc546a67d110feb8f495ab222d), (object) this.Region);
      }
    }

    private string RootDownloadLocation { get; }

    public event EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> c943f81e9c8c38b48def08f2dd55c66db
    {
      add
      {
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> eventHandler = this.c943f81e9c8c38b48def08f2dd55c66db;
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1>>(ref this.c943f81e9c8c38b48def08f2dd55c66db, ca408cbeba71e5c7363d19a2e923c7a15.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.add_c943f81e9c8c38b48def08f2dd55c66db);
            break;
        }
      }
      remove
      {
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> eventHandler = this.c943f81e9c8c38b48def08f2dd55c66db;
        EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1>>(ref this.c943f81e9c8c38b48def08f2dd55c66db, ca408cbeba71e5c7363d19a2e923c7a15.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.remove_c943f81e9c8c38b48def08f2dd55c66db);
            break;
        }
      }
    }

    public event EventHandler<cdf40c9764a014ff068a86edd8ace4556> c31cd36c62c73b80a1d5c5ab19a9c6298
    {
      add
      {
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> eventHandler = this.c31cd36c62c73b80a1d5c5ab19a9c6298;
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<cdf40c9764a014ff068a86edd8ace4556>>(ref this.c31cd36c62c73b80a1d5c5ab19a9c6298, c5aecac2c863682cde0d9124db3d790db.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.add_c31cd36c62c73b80a1d5c5ab19a9c6298);
            break;
        }
      }
      remove
      {
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> eventHandler = this.c31cd36c62c73b80a1d5c5ab19a9c6298;
        EventHandler<cdf40c9764a014ff068a86edd8ace4556> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<cdf40c9764a014ff068a86edd8ace4556>>(ref this.c31cd36c62c73b80a1d5c5ab19a9c6298, c5aecac2c863682cde0d9124db3d790db.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.remove_c31cd36c62c73b80a1d5c5ab19a9c6298);
            break;
        }
      }
    }

    protected cba6aa8f767d2e8dfbca2d43d7148c173(string c407606821fe6034b43e547a4ca232678, TitleId ca1f653cd83e17dfea7eb1317167e710f, string cd47a8862dc253a9ef4c1baa0b8cbdb0a, byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc, DataSize c395088e62cfd02fd835b335ee398e70c, string cd6d3c2c981fd22369f3efc24e5ed5fa1, caff792dac5a5e2f17b0e81e59bba386d cf48069439fdaca88d5122269390eb989)
    {
      this.Name = c407606821fe6034b43e547a4ca232678;
      this.TitleId = ca1f653cd83e17dfea7eb1317167e710f;
      this.Region = cd47a8862dc253a9ef4c1baa0b8cbdb0a;
      this.TicketArray = c9d02e186a6ec2baccf2d2d1ffb9a59dc;
      if (this.TicketArray != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.\u002Ector);
            }
            this.Ticket = c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(c9d02e186a6ec2baccf2d2d1ffb9a59dc, cf48069439fdaca88d5122269390eb989);
            break;
        }
      }
      this.Size = c395088e62cfd02fd835b335ee398e70c;
      this.RootDownloadLocation = cd6d3c2c981fd22369f3efc24e5ed5fa1;
      this.System = cf48069439fdaca88d5122269390eb989;
    }

    private long ce4e8a9e708b2d179e6d61ae42efeed76()
    {
      if (!Directory.Exists(this.OutputPath))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.ce4e8a9e708b2d179e6d61ae42efeed76);
            }
            return (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(288);
        }
      }
      else
      {
        string[] files = Directory.GetFiles(this.OutputPath);
        // ISSUE: reference to a compiler-generated field
        Func<string, long> selector = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c34ebc70055911f0b8bcfa30692ae93d4;
        if (selector == null)
        {
label_6:
          switch (1)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              selector = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c34ebc70055911f0b8bcfa30692ae93d4 = new Func<string, long>(cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c299d6c30a5593886c59c44053d530b56);
              break;
          }
        }
        return ((IEnumerable<string>) files).Sum<string>(selector);
      }
    }

    public void cf3c2ef6791ee577bd0d826b0b9bfb71e(string ce339ec8e4e59ae4d366ecde058dba451, string c6137549fa9273d62aada9a197f891199)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      cba6aa8f767d2e8dfbca2d43d7148c173.c8cc1aa7fa026785f1d2fee10ab913fcd c8cc1aa7fa026785f1d2fee10ab913fcd = new cba6aa8f767d2e8dfbca2d43d7148c173.c8cc1aa7fa026785f1d2fee10ab913fcd();
      // ISSUE: reference to a compiler-generated field
      c8cc1aa7fa026785f1d2fee10ab913fcd.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      c8cc1aa7fa026785f1d2fee10ab913fcd.ce339ec8e4e59ae4d366ecde058dba451 = ce339ec8e4e59ae4d366ecde058dba451;
      // ISSUE: reference to a compiler-generated field
      c8cc1aa7fa026785f1d2fee10ab913fcd.c6137549fa9273d62aada9a197f891199 = c6137549fa9273d62aada9a197f891199;
      // ISSUE: reference to a compiler-generated field
      c8cc1aa7fa026785f1d2fee10ab913fcd.c5ddd7e5ab9732ccdfe59d4296192e4ea = Path.Combine(Directory.GetParent(this.OutputPath).FullName, this.TitleId.IdRaw);
      // ISSUE: reference to a compiler-generated field
      Directory.Move(this.OutputPath, c8cc1aa7fa026785f1d2fee10ab913fcd.c5ddd7e5ab9732ccdfe59d4296192e4ea);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      Process process = this.cbfa23c4459341657a2937d6d03b78af8(c8cc1aa7fa026785f1d2fee10ab913fcd.ce339ec8e4e59ae4d366ecde058dba451, c8cc1aa7fa026785f1d2fee10ab913fcd.c6137549fa9273d62aada9a197f891199, c8cc1aa7fa026785f1d2fee10ab913fcd.c5ddd7e5ab9732ccdfe59d4296192e4ea);
      // ISSUE: reference to a compiler-generated field
      c8cc1aa7fa026785f1d2fee10ab913fcd.c95c88ea8b0e6ffe0e90d31a476f68494 = new ca5f1a19f078eb23ced887c232d971b13(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1870));
      process.Start();
      // ISSUE: reference to a compiler-generated method
      EventHandler eventHandler = new EventHandler(c8cc1aa7fa026785f1d2fee10ab913fcd.c41f0eafc815093c1b320a943e2247952);
      process.Exited += eventHandler;
      // ISSUE: reference to a compiler-generated field
      int num = (int) ((Form) c8cc1aa7fa026785f1d2fee10ab913fcd.c95c88ea8b0e6ffe0e90d31a476f68494).ShowDialog();
    }

    public void ca5649281440802bb4aae634896917d91()
    {
      this.cdef87411c5692b61fa14499905795332 = DateTime.MinValue;
    }

    public static void c6d91cde991f19838328340579625e3f3()
    {
      cba6aa8f767d2e8dfbca2d43d7148c173.c0fff13d9b7de393267a3b3d54a50e81f = new List<string>();
      if (!c6a07387c2f827de6ca155929a5452624.c7a7544eb248515de6a83cc809877afc6(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2140)))
        return;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c6d91cde991f19838328340579625e3f3);
          }
          cba6aa8f767d2e8dfbca2d43d7148c173.c0fff13d9b7de393267a3b3d54a50e81f.AddRange((IEnumerable<string>) c6a07387c2f827de6ca155929a5452624.c79f3734e186fa26ca45e21833e734d4e(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2140)));
          break;
      }
    }

    public static void cfa0952d727a09330dbc279563d1f513d()
    {
      c6a07387c2f827de6ca155929a5452624.cc0d9971a7869dcbc8bb5a89e4f263c2a(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2140), cba6aa8f767d2e8dfbca2d43d7148c173.c0fff13d9b7de393267a3b3d54a50e81f.ToArray());
    }

    public void cecb1b80e8fb53dc45867899e11c353bb()
    {
      c04094fd9c48096d147c0fc6cc8a97c26 cca23d7b2a91be5252f701fdb103c7f16 = this.cca23d7b2a91be5252f701fdb103c7f16;
      if (cca23d7b2a91be5252f701fdb103c7f16 == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.cecb1b80e8fb53dc45867899e11c353bb);
            }
            break;
        }
      }
      else
        cca23d7b2a91be5252f701fdb103c7f16.cf8139dc61d96e4a9ff8b1dc5cf060de9();
    }

    public void ce36b56601ac755d86f10b78a71a426e9()
    {
      // ISSUE: reference to a compiler-generated field
      this.c31cd36c62c73b80a1d5c5ab19a9c6298 = c09607f0c10e6386fa08abe36570d5418.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      // ISSUE: reference to a compiler-generated field
      this.c943f81e9c8c38b48def08f2dd55c66db = ce956a477987ef3580211c6863869551d.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    public string c67a77144991678dc8a5c260dc2993b06(bool c9fa97f64d5af3c34a9bbdb0637e49788, DriveInfo c1d3a5479c48c7cb0167d214743c23580)
    {
      if (c9fa97f64d5af3c34a9bbdb0637e49788)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c67a77144991678dc8a5c260dc2993b06);
            }
            if (!this.c57fc08bf13e98f7bb3429ed7685c7ca0())
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  return c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2159);
              }
            }
            else
              break;
        }
      }
      string name = c1d3a5479c48c7cb0167d214743c23580.Name;
      string path2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2196);
      string ce7a5964b7f9ba43afcebe1e7d79151c7 = this.ce7a5964b7f9ba43afcebe1e7d79151c7;
      string c33ad1bd311fd4b32b85377e9e15a9d93;
      if (!this.CfwOnly)
      {
label_8:
        switch (2)
        {
          case 0:
            goto label_8;
          default:
            c33ad1bd311fd4b32b85377e9e15a9d93 = "";
            break;
        }
      }
      else
        c33ad1bd311fd4b32b85377e9e15a9d93 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2213);
      string path3 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(ce7a5964b7f9ba43afcebe1e7d79151c7, c33ad1bd311fd4b32b85377e9e15a9d93);
      string str = Path.Combine(name, path2, path3);
      if (Directory.Exists(str))
      {
label_12:
        switch (4)
        {
          case 0:
            goto label_12;
          default:
            Directory.Delete(str, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(300) != 0);
            break;
        }
      }
      Directory.CreateDirectory(str);
      if (this.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(304))
      {
label_15:
        switch (1)
        {
          case 0:
            goto label_15;
          default:
            try
            {
              FileSystem.CopyDirectory(this.OutputPath, str, (UIOption) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(308));
            }
            catch (Exception ex)
            {
              return ex.Message;
            }
            return c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2236);
        }
      }
      else
      {
        this.cf3c2ef6791ee577bd0d826b0b9bfb71e(str, this.Name);
        return c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2236);
      }
    }

    public bool ca0f0ce4a1c83bf79f0422b8a25b09420()
    {
      this.ca5649281440802bb4aae634896917d91();
      try
      {
        Directory.Delete(this.OutputPath, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(312) != 0);
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(316) != 0;
      }
      catch (Exception ex)
      {
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(320) != 0;
      }
    }

    public string c0f5bf28fdcef3397fbbb3ca192f34d08()
    {
      if (c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5((object) this) == null)
        return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2260), (object) cba6aa8f767d2e8dfbca2d43d7148c173.c134c073db1c5675227938edebbefc4bd(this.ToString()));
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c0f5bf28fdcef3397fbbb3ca192f34d08);
          }
          return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2241), (object) cba6aa8f767d2e8dfbca2d43d7148c173.c134c073db1c5675227938edebbefc4bd(this.Name), (object) c67d9b6a5467c9d75d08709b59a091266.cc8e287d5350b43026d33bb80beb131a0((object) this).ProductId);
      }
    }

    public void c754046fef40adf702b22895f45ed9448(cc6dede17deea63b67c3e0eb84bf12bb3 c5a5bec978796537a0d12234195422a66)
    {
      c5a5bec978796537a0d12234195422a66.c754046fef40adf702b22895f45ed9448();
    }

    public cc6dede17deea63b67c3e0eb84bf12bb3 c37fb779a19244202a98c4e2c8832a407()
    {
      Platform platform = this.Platform;
      if (platform <= (Platform) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(324))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c37fb779a19244202a98c4e2c8832a407);
            }
            if (platform == (Platform) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(328))
              return (cc6dede17deea63b67c3e0eb84bf12bb3) new c2f239dc25375b30b02725c7f40300703(this);
label_5:
            switch (5)
            {
              case 0:
                goto label_5;
              default:
                if (platform == (Platform) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(332))
                  return (cc6dede17deea63b67c3e0eb84bf12bb3) new c2f239dc25375b30b02725c7f40300703(this);
label_7:
                switch (2)
                {
                  case 0:
                    goto label_7;
                }
            }
        }
      }
      else
      {
        if (platform == (Platform) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(336))
          return (cc6dede17deea63b67c3e0eb84bf12bb3) new c2f239dc25375b30b02725c7f40300703(this);
label_9:
        switch (6)
        {
          case 0:
            goto label_9;
          default:
            switch (platform - cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(340))
            {
              case Platform.Unknown:
                return (cc6dede17deea63b67c3e0eb84bf12bb3) new c5897cd50b058541621db862614b9c57c(this);
              case (Platform) 1:
                return (cc6dede17deea63b67c3e0eb84bf12bb3) new c6b77ba122628e02788f74fe0f89197d9(this);
              case (Platform) 2:
                return (cc6dede17deea63b67c3e0eb84bf12bb3) new c2f239dc25375b30b02725c7f40300703(this);
              default:
                if (platform == (Platform) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(344))
                  return (cc6dede17deea63b67c3e0eb84bf12bb3) new c560dcb0fd8e4c36ddceec490ecc4c935(this);
label_12:
                switch (6)
                {
                  case 0:
                    goto label_12;
                }
            }
        }
      }
      return (cc6dede17deea63b67c3e0eb84bf12bb3) null;
    }

    public Process c109d863a3d11449fb3acdb694a4a225f(string c5ddd7e5ab9732ccdfe59d4296192e4ea)
    {
      if (this.System != (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(348))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c109d863a3d11449fb3acdb694a4a225f);
            }
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2289));
        }
      }
      else if (this.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(352))
      {
label_6:
        switch (3)
        {
          case 0:
            goto label_6;
          default:
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2372));
        }
      }
      else
      {
        if (!System.IO.File.Exists(cba6aa8f767d2e8dfbca2d43d7148c173.c96d3a8c111985758b9e8c23f458a5cf9))
        {
label_9:
          switch (2)
          {
            case 0:
              goto label_9;
            default:
              System.IO.File.WriteAllBytes(cba6aa8f767d2e8dfbca2d43d7148c173.c96d3a8c111985758b9e8c23f458a5cf9, c27603360ccc8374975348defb9eee9fc.CDecrypt);
              break;
          }
        }
        if (!System.IO.File.Exists(cba6aa8f767d2e8dfbca2d43d7148c173.ca4f44371cce09a02b7490a27054dbf02))
        {
label_12:
          switch (3)
          {
            case 0:
              goto label_12;
            default:
              System.IO.File.WriteAllBytes(cba6aa8f767d2e8dfbca2d43d7148c173.ca4f44371cce09a02b7490a27054dbf02, c27603360ccc8374975348defb9eee9fc.libeay32);
              break;
          }
        }
        if (!System.IO.File.Exists(cba6aa8f767d2e8dfbca2d43d7148c173.c40611bb7e13fc8b2313decf79d8a7bad))
        {
label_15:
          switch (6)
          {
            case 0:
              goto label_15;
            default:
              System.IO.File.WriteAllBytes(cba6aa8f767d2e8dfbca2d43d7148c173.c40611bb7e13fc8b2313decf79d8a7bad, cf9652be11ede2a4c45b6e00796c8c7d3.c19a1d756523dcffcbe22a7ac46c513f6(this.System));
              break;
          }
        }
        string str = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2419), (object) Path.Combine(c5ddd7e5ab9732ccdfe59d4296192e4ea, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2456)), (object) Path.Combine(c5ddd7e5ab9732ccdfe59d4296192e4ea, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2475)), (object) cba6aa8f767d2e8dfbca2d43d7148c173.c40611bb7e13fc8b2313decf79d8a7bad);
        Process process = new Process();
        process.StartInfo.FileName = cba6aa8f767d2e8dfbca2d43d7148c173.c96d3a8c111985758b9e8c23f458a5cf9;
        int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(356);
        process.EnableRaisingEvents = num != 0;
        process.StartInfo.CreateNoWindow = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(360) != 0;
        process.StartInfo.Arguments = str;
        process.StartInfo.WorkingDirectory = c5ddd7e5ab9732ccdfe59d4296192e4ea;
        process.StartInfo.UseShellExecute = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(364) != 0;
        process.StartInfo.RedirectStandardOutput = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(368) != 0;
        return process;
      }
    }

    private Process cbfa23c4459341657a2937d6d03b78af8(string c98073220ef30b96c2fde20d0e2fc4c43, string c6137549fa9273d62aada9a197f891199, string c3eb2a09f67ab8531ae209f155f9b5815)
    {
      if (this.System != caff792dac5a5e2f17b0e81e59bba386d.cd640a3b52f646cee482c685f1e6d0f8b)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.cbfa23c4459341657a2937d6d03b78af8);
            }
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2494));
        }
      }
      else if (this.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(372))
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            throw new Exception(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2372));
        }
      }
      else
      {
        if (!System.IO.File.Exists(cba6aa8f767d2e8dfbca2d43d7148c173.ca4049804a6ae4db9373cdd10c16e9b08))
        {
label_9:
          switch (1)
          {
            case 0:
              goto label_9;
            default:
              System.IO.File.WriteAllBytes(cba6aa8f767d2e8dfbca2d43d7148c173.ca4049804a6ae4db9373cdd10c16e9b08, c27603360ccc8374975348defb9eee9fc.makecia);
              break;
          }
        }
        string str = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2571), (object) c3eb2a09f67ab8531ae209f155f9b5815, (object) c98073220ef30b96c2fde20d0e2fc4c43, (object) this.TitleId.IdRaw);
        Process process = new Process();
        process.StartInfo.FileName = cba6aa8f767d2e8dfbca2d43d7148c173.ca4049804a6ae4db9373cdd10c16e9b08;
        int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(376);
        process.EnableRaisingEvents = num != 0;
        process.StartInfo.CreateNoWindow = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(380) != 0;
        process.StartInfo.Arguments = str;
        process.StartInfo.WorkingDirectory = c98073220ef30b96c2fde20d0e2fc4c43;
        process.StartInfo.UseShellExecute = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(384) != 0;
        process.StartInfo.RedirectStandardOutput = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(388) != 0;
        return process;
      }
    }

    public void c383b419adeff39108be6b9097bc3c315(bool c9fa97f64d5af3c34a9bbdb0637e49788, IPAddress c822a74f59886365c6601e3f4fcf03497)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      cba6aa8f767d2e8dfbca2d43d7148c173.ca7521e4b9d369cd29cba615069a63fcf ca7521e4b9d369cd29cba615069a63fcf1 = new cba6aa8f767d2e8dfbca2d43d7148c173.ca7521e4b9d369cd29cba615069a63fcf();
      // ISSUE: reference to a compiler-generated field
      ca7521e4b9d369cd29cba615069a63fcf1.ccb669e105f1c11f33e60c076fc8cca42 = this;
      if (this.System != (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(392))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c383b419adeff39108be6b9097bc3c315);
            break;
        }
      }
      else
      {
        this.CurrentlyUploaded = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(396) != 0;
        if (c9fa97f64d5af3c34a9bbdb0637e49788)
        {
label_5:
          switch (5)
          {
            case 0:
              goto label_5;
            default:
              if (!this.c57fc08bf13e98f7bb3429ed7685c7ca0())
              {
label_7:
                switch (2)
                {
                  case 0:
                    goto label_7;
                  default:
                    // ISSUE: reference to a compiler-generated field
                    EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> c943f81e9c8c38b48def08f2dd55c66db = this.c943f81e9c8c38b48def08f2dd55c66db;
                    if (c943f81e9c8c38b48def08f2dd55c66db == null)
                    {
label_9:
                      switch (2)
                      {
                        case 0:
                          goto label_9;
                      }
                    }
                    else
                    {
                      c9d5fc374dcd742d4aee7811bbe7ee2e1 e = new c9d5fc374dcd742d4aee7811bbe7ee2e1(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2159), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(400) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(404));
                      c943f81e9c8c38b48def08f2dd55c66db((object) this, e);
                      break;
                    }
                }
              }
              else
                break;
          }
        }
        string ce7a5964b7f9ba43afcebe1e7d79151c7 = this.ce7a5964b7f9ba43afcebe1e7d79151c7;
        string c33ad1bd311fd4b32b85377e9e15a9d93;
        if (!this.CfwOnly)
        {
label_12:
          switch (7)
          {
            case 0:
              goto label_12;
            default:
              c33ad1bd311fd4b32b85377e9e15a9d93 = "";
              break;
          }
        }
        else
          c33ad1bd311fd4b32b85377e9e15a9d93 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2213);
        string path2 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(ce7a5964b7f9ba43afcebe1e7d79151c7, c33ad1bd311fd4b32b85377e9e15a9d93);
        // ISSUE: variable of a compiler-generated type
        cba6aa8f767d2e8dfbca2d43d7148c173.ca7521e4b9d369cd29cba615069a63fcf ca7521e4b9d369cd29cba615069a63fcf2 = ca7521e4b9d369cd29cba615069a63fcf1;
        FileInfo[] files = new DirectoryInfo(this.OutputPath).GetFiles();
        // ISSUE: reference to a compiler-generated field
        Func<FileInfo, long> selector = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c1c273c05644572377198e196c981c229;
        if (selector == null)
        {
label_16:
          switch (2)
          {
            case 0:
              goto label_16;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              selector = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c1c273c05644572377198e196c981c229 = new Func<FileInfo, long>(cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c64366e9bf44b2dda7418d31fe32e5474);
              break;
          }
        }
        long num = ((IEnumerable<FileInfo>) files).Sum<FileInfo>(selector);
        // ISSUE: reference to a compiler-generated field
        ca7521e4b9d369cd29cba615069a63fcf2.cf9b681c49844213568e188bc27a57ec6 = num;
        string str = Path.Combine(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2610), path2);
        this.cca23d7b2a91be5252f701fdb103c7f16 = new c04094fd9c48096d147c0fc6cc8a97c26(c822a74f59886365c6601e3f4fcf03497.ToString(), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(159), "");
        if (!this.cca23d7b2a91be5252f701fdb103c7f16.caa5178323cfcbb426e4cf0a8f58e6e73())
        {
label_19:
          switch (6)
          {
            case 0:
              goto label_19;
            default:
              // ISSUE: reference to a compiler-generated field
              EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> c943f81e9c8c38b48def08f2dd55c66db = this.c943f81e9c8c38b48def08f2dd55c66db;
              if (c943f81e9c8c38b48def08f2dd55c66db == null)
              {
label_21:
                switch (1)
                {
                  case 0:
                    goto label_21;
                }
              }
              else
              {
                c9d5fc374dcd742d4aee7811bbe7ee2e1 e = new c9d5fc374dcd742d4aee7811bbe7ee2e1(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2635), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(408) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(412));
                c943f81e9c8c38b48def08f2dd55c66db((object) this, e);
                break;
              }
          }
        }
        this.cca23d7b2a91be5252f701fdb103c7f16.ca9c1bc9739b4b81bba62ac0261bb028a(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2610));
        this.cca23d7b2a91be5252f701fdb103c7f16.ca9c1bc9739b4b81bba62ac0261bb028a(str);
        this.cca23d7b2a91be5252f701fdb103c7f16.cbdde249c8efe2db9f4c800e918171ca4 += (EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c9572d7ff9cd6a116e4a6f248ca68a831) =>
        {
          this.CurrentlyUploaded = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(592) != 0;
          if (!this.cca23d7b2a91be5252f701fdb103c7f16.TransferStatus.Error)
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
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c804bd9b30344b8466c2506725dd4da3c);
                }
                if (c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5((object) this) != null)
                {
label_5:
                  switch (2)
                  {
                    case 0:
                      goto label_5;
                    default:
                      c67d9b6a5467c9d75d08709b59a091266.cc8e287d5350b43026d33bb80beb131a0((object) this).cd61c5f51f587495941f329dc6bffec54 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(596) != 0;
                      break;
                  }
                }
                else
                  break;
            }
          }
          // ISSUE: reference to a compiler-generated field
          EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> c943f81e9c8c38b48def08f2dd55c66db = this.c943f81e9c8c38b48def08f2dd55c66db;
          if (c943f81e9c8c38b48def08f2dd55c66db == null)
          {
label_8:
            switch (6)
            {
              case 0:
                goto label_8;
            }
          }
          else
          {
            c9d5fc374dcd742d4aee7811bbe7ee2e1 transferStatus = this.cca23d7b2a91be5252f701fdb103c7f16.TransferStatus;
            c943f81e9c8c38b48def08f2dd55c66db((object) this, transferStatus);
          }
        });
        // ISSUE: reference to a compiler-generated field
        ca7521e4b9d369cd29cba615069a63fcf1.c9ce33a46b790927bbf14a181cb488769 = (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(416);
        // ISSUE: reference to a compiler-generated field
        ca7521e4b9d369cd29cba615069a63fcf1.c4837629a73585e38d28545ef63f1bbbd = DateTime.Now;
        // ISSUE: reference to a compiler-generated field
        ca7521e4b9d369cd29cba615069a63fcf1.cc35ca7a1bfc4225de20be7aac6700c2b = (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(420);
        // ISSUE: reference to a compiler-generated method
        this.cca23d7b2a91be5252f701fdb103c7f16.c4c08c39a077a638c4b79d4fc8b3bb982 += new EventHandler<long>(ca7521e4b9d369cd29cba615069a63fcf1.c71d1cc080859596b2a223189ab44fa5b);
        try
        {
          this.cca23d7b2a91be5252f701fdb103c7f16.c5883efd4c9664470f8e935e4af5f9504(str, this.OutputPath);
        }
        catch (Exception ex)
        {
          // ISSUE: reference to a compiler-generated field
          EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1> c943f81e9c8c38b48def08f2dd55c66db = this.c943f81e9c8c38b48def08f2dd55c66db;
          if (c943f81e9c8c38b48def08f2dd55c66db == null)
          {
label_26:
            switch (4)
            {
              case 0:
                goto label_26;
            }
          }
          else
          {
            c9d5fc374dcd742d4aee7811bbe7ee2e1 e = new c9d5fc374dcd742d4aee7811bbe7ee2e1(ex.Message, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(424) != 0, (c1287c46b305fa65517e5b77a5334b29e) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(428));
            c943f81e9c8c38b48def08f2dd55c66db((object) this, e);
          }
        }
      }
    }

    public static string c134c073db1c5675227938edebbefc4bd(string cd882bdfcde69377e6616f3b1f8b305c6)
    {
      cd882bdfcde69377e6616f3b1f8b305c6 = cd882bdfcde69377e6616f3b1f8b305c6.Replace(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2713), "");
      char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
      string seed = cd882bdfcde69377e6616f3b1f8b305c6;
      // ISSUE: reference to a compiler-generated field
      Func<string, char, string> func = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.ca79b089876fe3501ea30d017ea7b1bb3;
      if (func == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c134c073db1c5675227938edebbefc4bd);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            func = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.ca79b089876fe3501ea30d017ea7b1bb3 = new Func<string, char, string>(cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cc860d7cb6989cca89200c26767094fa5);
            break;
        }
      }
      return ((IEnumerable<char>) invalidFileNameChars).Aggregate<char, string>(seed, func);
    }

    private static string cad087c9dfcaf00cb38757d0c5997cbf0(string cd882bdfcde69377e6616f3b1f8b305c6)
    {
      string cb65dfb0bc05cf5ef055e18ba40b6708a1 = cd882bdfcde69377e6616f3b1f8b305c6;
      char[] c271ba7f7c31693e03900ad5bd1dc3e63_1 = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(432));
      int cecb96267e559a56c4f543488b117e4fc1 = 436;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) c271ba7f7c31693e03900ad5bd1dc3e63_1, cecb96267e559a56c4f543488b117e4fc1);
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(453);
      string cb65dfb0bc05cf5ef055e18ba40b6708a2 = cb65dfb0bc05cf5ef055e18ba40b6708a1.cd8c423e132c5a4156f5bc7d54bf37e47(c271ba7f7c31693e03900ad5bd1dc3e63_1, (char) num1);
      char[] c271ba7f7c31693e03900ad5bd1dc3e63_2 = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(457));
      int cecb96267e559a56c4f543488b117e4fc2 = 461;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) c271ba7f7c31693e03900ad5bd1dc3e63_2, cecb96267e559a56c4f543488b117e4fc2);
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(468);
      string cb65dfb0bc05cf5ef055e18ba40b6708a3 = cb65dfb0bc05cf5ef055e18ba40b6708a2.cd8c423e132c5a4156f5bc7d54bf37e47(c271ba7f7c31693e03900ad5bd1dc3e63_2, (char) num2);
      char[] c271ba7f7c31693e03900ad5bd1dc3e63_3 = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(472));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(476);
      int num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(480);
      c271ba7f7c31693e03900ad5bd1dc3e63_3[index1] = (char) num3;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(484);
      int num4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(488);
      c271ba7f7c31693e03900ad5bd1dc3e63_3[index2] = (char) num4;
      int num5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(492);
      string cb65dfb0bc05cf5ef055e18ba40b6708a4 = cb65dfb0bc05cf5ef055e18ba40b6708a3.cd8c423e132c5a4156f5bc7d54bf37e47(c271ba7f7c31693e03900ad5bd1dc3e63_3, (char) num5);
      char[] c271ba7f7c31693e03900ad5bd1dc3e63_4 = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(496));
      int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(500);
      int num6 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(504);
      c271ba7f7c31693e03900ad5bd1dc3e63_4[index3] = (char) num6;
      int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(508);
      int num7 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(512);
      c271ba7f7c31693e03900ad5bd1dc3e63_4[index4] = (char) num7;
      int num8 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(516);
      string cb65dfb0bc05cf5ef055e18ba40b6708a5 = cb65dfb0bc05cf5ef055e18ba40b6708a4.cd8c423e132c5a4156f5bc7d54bf37e47(c271ba7f7c31693e03900ad5bd1dc3e63_4, (char) num8);
      char[] c271ba7f7c31693e03900ad5bd1dc3e63_5 = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(520));
      int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(524);
      int num9 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(528);
      c271ba7f7c31693e03900ad5bd1dc3e63_5[index5] = (char) num9;
      int index6 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(532);
      int num10 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(536);
      c271ba7f7c31693e03900ad5bd1dc3e63_5[index6] = (char) num10;
      int num11 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(540);
      return cb65dfb0bc05cf5ef055e18ba40b6708a5.cd8c423e132c5a4156f5bc7d54bf37e47(c271ba7f7c31693e03900ad5bd1dc3e63_5, (char) num11).Replace(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2716), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2719));
    }

    private cb48a6650cad6d81c80da89dfe58b703a c291c6bb8b6e1a373030523d15db983f9()
    {
      if (!Directory.Exists(this.OutputPath))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c291c6bb8b6e1a373030523d15db983f9);
            }
            return (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(544);
        }
      }
      else
      {
        if (System.IO.File.Exists(Path.Combine(this.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2456))))
        {
label_6:
          switch (2)
          {
            case 0:
              goto label_6;
            default:
              if (System.IO.File.Exists(Path.Combine(this.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2475))))
              {
label_8:
                switch (4)
                {
                  case 0:
                    goto label_8;
                  default:
                    if (this.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(548))
                    {
label_10:
                      switch (4)
                      {
                        case 0:
                          goto label_10;
                        default:
                          if (!System.IO.File.Exists(Path.Combine(this.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2726))))
                          {
label_12:
                            switch (7)
                            {
                              case 0:
                                goto label_12;
                              default:
                                goto label_13;
                            }
                          }
                          else
                            break;
                      }
                    }
                    ccc0082396339666e15f34a6614404a47[] c7294cb7c91944988432faebdd13ef3a8 = cff72ea250ac36ea03abde33ff61b7565.cb5009c1058eaad54842d9bead8e530a2(Path.Combine(this.OutputPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2456)), this.System).c7294cb7c91944988432faebdd13ef3a8;
                    int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(556);
                    while (index < (int) c2a0c2ae96e14c3951c8dd08f53fe4024.c572aba370be49804cbdb0b35312bea94(c7294cb7c91944988432faebdd13ef3a8))
                    {
                      ccc0082396339666e15f34a6614404a47 ccc0082396339666e15f34a6614404a47 = c7294cb7c91944988432faebdd13ef3a8[index];
                      string outputPath1 = this.OutputPath;
                      uint contentId = ccc0082396339666e15f34a6614404a47.ContentId;
                      string path2_1 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(contentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2752));
                      string str = Path.Combine(outputPath1, path2_1);
                      if (!System.IO.File.Exists(str))
                      {
label_16:
                        switch (1)
                        {
                          case 0:
                            goto label_16;
                          default:
                            return (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(560);
                        }
                      }
                      else if (new FileInfo(str).Length != (long) ccc0082396339666e15f34a6614404a47.Size.TotalBytes.c9436aadb49f0566ae96927a598183da4((uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(564)))
                      {
label_19:
                        switch (2)
                        {
                          case 0:
                            goto label_19;
                          default:
                            return (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(568);
                        }
                      }
                      else
                      {
                        if (ccc0082396339666e15f34a6614404a47.ce7bc51cbabe7bd4fb4dac2e71e260e4f)
                        {
label_22:
                          switch (7)
                          {
                            case 0:
                              goto label_22;
                            default:
                              string outputPath2 = this.OutputPath;
                              contentId = ccc0082396339666e15f34a6614404a47.ContentId;
                              string path2_2 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(contentId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2747)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2761));
                              if (!System.IO.File.Exists(Path.Combine(outputPath2, path2_2)))
                              {
label_24:
                                switch (2)
                                {
                                  case 0:
                                    goto label_24;
                                  default:
                                    return (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(572);
                                }
                              }
                              else
                                break;
                          }
                        }
                        index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(576);
                      }
                    }
label_28:
                    switch (1)
                    {
                      case 0:
                        goto label_28;
                      default:
                        return (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(580);
                    }
                }
              }
              else
                break;
          }
        }
label_13:
        return (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(552);
      }
    }

    private bool c57fc08bf13e98f7bb3429ed7685c7ca0()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      cba6aa8f767d2e8dfbca2d43d7148c173.c308f49b656d791bd52c93519e8b92eb3 c308f49b656d791bd52c93519e8b92eb3 = new cba6aa8f767d2e8dfbca2d43d7148c173.c308f49b656d791bd52c93519e8b92eb3();
      // ISSUE: reference to a compiler-generated field
      c308f49b656d791bd52c93519e8b92eb3.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      c308f49b656d791bd52c93519e8b92eb3.c31c280f4988e4fcbea6c5483ca246ab4 = new ca5f1a19f078eb23ced887c232d971b13(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2768));
      // ISSUE: reference to a compiler-generated field
      c308f49b656d791bd52c93519e8b92eb3.c167a113bd726afb8f5126bcdea0af0e0 = c376b56c026e38d1ad7d29034f2d920b8.c20c00b8e97bb4c0fb2b7ac6facf98b91;
      // ISSUE: reference to a compiler-generated method
      Thread thread = new Thread(new ThreadStart(c308f49b656d791bd52c93519e8b92eb3.c0f783d777102c11c6775b8cbcea1d273));
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(584);
      thread.IsBackground = num1 != 0;
      thread.Start();
      // ISSUE: reference to a compiler-generated field
      int num2 = (int) ((Form) c308f49b656d791bd52c93519e8b92eb3.c31c280f4988e4fcbea6c5483ca246ab4).ShowDialog();
      // ISSUE: reference to a compiler-generated field
      if (c308f49b656d791bd52c93519e8b92eb3.c167a113bd726afb8f5126bcdea0af0e0 == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cba6aa8f767d2e8dfbca2d43d7148c173.c57fc08bf13e98f7bb3429ed7685c7ca0);
            }
            return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(588) != 0;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        List<caaa166a921d0019973aa328703a03e82> c167a113bd726afb8f5126bcdea0af0e0 = c308f49b656d791bd52c93519e8b92eb3.c167a113bd726afb8f5126bcdea0af0e0;
        // ISSUE: reference to a compiler-generated field
        Func<caaa166a921d0019973aa328703a03e82, bool> predicate = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c8548f8884d5c71d23b282f3748591356;
        if (predicate == null)
        {
label_6:
          switch (1)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              predicate = cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c8548f8884d5c71d23b282f3748591356 = new Func<caaa166a921d0019973aa328703a03e82, bool>(cba6aa8f767d2e8dfbca2d43d7148c173.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c34ae57cba24246738c30e645648215b4);
              break;
          }
        }
        return c167a113bd726afb8f5126bcdea0af0e0.All<caaa166a921d0019973aa328703a03e82>(predicate);
      }
    }
  }
}
