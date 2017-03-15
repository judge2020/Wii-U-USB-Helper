// Decompiled with JetBrains decompiler
// Type: A.c40ece8fa5bfed221fc1f86983d53de2d
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class c40ece8fa5bfed221fc1f86983d53de2d : RadForm
  {
    private const int c1586a501c7fe463475ad5dc6bad65ebf = 7;
    private const int c5c22cc7360cc66766aebea8fe14d4816 = 8;
    private const int cc67705ba59b257e23c944c97effcbd5a = 1;
    private const int c8cbe7c808feedb913cd3d2ace15ccdcf = 0;
    private const int cd86cda1d8b8e267a8501da421df0a259 = 4;
    private const int c0e05fd7f6fb41e45fe952fd6d985f37d = 5;
    private const int c73f2afed741b82ce34de3f681804b119 = 6;
    private const int c4b1ebe859362a2f9b8f5509b0da168d9 = 277;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private System.Windows.Forms.Timer c6808cde2d6195d4f4340d06e157f93dc;
    private RichTextBox cb699020b026175cc5df5d433ca4c4f39;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadLabel cee9946355c6a614ff90b875d32801e38;

    public c40ece8fa5bfed221fc1f86983d53de2d()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    [DllImport("user32.dll", EntryPoint = "GetScrollInfo")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool c2b8efeae1ce14510607336c5c05a3b60(IntPtr c870672649790fcf310e5f2229b6d2b64, int c5850db2b999442396827a94f05e69e61, ref c40ece8fa5bfed221fc1f86983d53de2d.c6c2c5006e1d17734fb069b6ef030e403 c753eeddff10b1c3b9723a02b75b0c244);

    private static void c9c50d5c14e5e4f42b9e64fd813aa9c99(IntPtr ca6000dc6da4fb8c191a910e7d6f18ec6, int cd54f49505efdb83127de9f5029a97c06)
    {
      c40ece8fa5bfed221fc1f86983d53de2d.c6c2c5006e1d17734fb069b6ef030e403 c753eeddff10b1c3b9723a02b75b0c244 = new c40ece8fa5bfed221fc1f86983d53de2d.c6c2c5006e1d17734fb069b6ef030e403();
      c753eeddff10b1c3b9723a02b75b0c244.c7998cf459ffe48f7b920f83016bc017d = (uint) Marshal.SizeOf((object) c753eeddff10b1c3b9723a02b75b0c244);
      c753eeddff10b1c3b9723a02b75b0c244.ce9f99440e90c3b3efd36cde8367f5121 = (uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9912);
      c40ece8fa5bfed221fc1f86983d53de2d.c2b8efeae1ce14510607336c5c05a3b60(ca6000dc6da4fb8c191a910e7d6f18ec6, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9916), ref c753eeddff10b1c3b9723a02b75b0c244);
      c753eeddff10b1c3b9723a02b75b0c244.cc9b36c30ebab2d2720b2be10a83701ef += cd54f49505efdb83127de9f5029a97c06;
      c40ece8fa5bfed221fc1f86983d53de2d.cd4fa24178d06d40b7b9eadf84aaf404a(ca6000dc6da4fb8c191a910e7d6f18ec6, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9920), ref c753eeddff10b1c3b9723a02b75b0c244, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9924) != 0);
      IntPtr cb43134d350dd0175b48bc888afbdd361 = new IntPtr(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9928) + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9932) * c753eeddff10b1c3b9723a02b75b0c244.cc9b36c30ebab2d2720b2be10a83701ef);
      IntPtr c2e8b20fe4362911f2f3d01c0ecae5e42 = new IntPtr(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9936));
      c40ece8fa5bfed221fc1f86983d53de2d.c7c92f45c2a5b4947a4dfb2b8181b805d(ca6000dc6da4fb8c191a910e7d6f18ec6, (uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9940), cb43134d350dd0175b48bc888afbdd361, c2e8b20fe4362911f2f3d01c0ecae5e42);
    }

    [DllImport("User32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
    private static extern IntPtr c7c92f45c2a5b4947a4dfb2b8181b805d(IntPtr c5426ca9dcc0d24fd77550a86c472ad5b, uint c12271b4173397a6ab729968a6ca46364, IntPtr cb43134d350dd0175b48bc888afbdd361, IntPtr c2e8b20fe4362911f2f3d01c0ecae5e42);

    [DllImport("user32.dll", EntryPoint = "SetScrollInfo")]
    private static extern int cd4fa24178d06d40b7b9eadf84aaf404a(IntPtr c870672649790fcf310e5f2229b6d2b64, int c5850db2b999442396827a94f05e69e61, [In] ref c40ece8fa5bfed221fc1f86983d53de2d.c6c2c5006e1d17734fb069b6ef030e403 c753eeddff10b1c3b9723a02b75b0c244, bool ca1860355c1d79354cb71b35dbf8b479d);

    private void cfaf86d6c9d3f90e10df77bd7dbbe1511(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      List<string> stringList = new List<string>();
      this.cb699020b026175cc5df5d433ca4c4f39.BackColor = ((Control) this).BackColor;
      string str1 = new WebClient().DownloadString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6634));
      char[] separator = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9944));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9948);
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9952);
      separator[index1] = (char) num1;
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9956);
      string[] c33ad1bd311fd4b32b85377e9e15a9d93_1 = str1.Split(separator, (StringSplitOptions) num2);
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9960);
      while (index2 < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93_1))
      {
        string c33ad1bd311fd4b32b85377e9e15a9d93_2 = c33ad1bd311fd4b32b85377e9e15a9d93_1[index2];
        if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93_2.Substring(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9964), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9968)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15255)))
        {
label_2:
          switch (2)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c40ece8fa5bfed221fc1f86983d53de2d.cfaf86d6c9d3f90e10df77bd7dbbe1511);
              }
              c33ad1bd311fd4b32b85377e9e15a9d93_2 = c33ad1bd311fd4b32b85377e9e15a9d93_2.Substring(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9972));
              stringList.Add(c33ad1bd311fd4b32b85377e9e15a9d93_2);
              break;
          }
        }
        RichTextBox cb699020b026175cc5df5d433ca4c4f39 = this.cb699020b026175cc5df5d433ca4c4f39;
        string str2 = c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(cb699020b026175cc5df5d433ca4c4f39.Text, c33ad1bd311fd4b32b85377e9e15a9d93_2, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6958));
        cb699020b026175cc5df5d433ca4c4f39.Text = str2;
        index2 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9976);
      }
label_8:
      switch (2)
      {
        case 0:
          goto label_8;
        default:
          using (List<string>.Enumerator enumerator = stringList.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              this.cb699020b026175cc5df5d433ca4c4f39.Find(enumerator.Current);
              this.cb699020b026175cc5df5d433ca4c4f39.SelectionColor = Color.Gold;
            }
label_13:
            switch (7)
            {
              case 0:
                goto label_13;
            }
          }
          this.cb699020b026175cc5df5d433ca4c4f39.SelectAll();
          this.cb699020b026175cc5df5d433ca4c4f39.SelectionAlignment = (HorizontalAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9980);
          this.c6808cde2d6195d4f4340d06e157f93dc.Start();
          break;
      }
    }

    private void c4e53619ab2000559ce6cfce18a19dcf5(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      c40ece8fa5bfed221fc1f86983d53de2d.c9c50d5c14e5e4f42b9e64fd813aa9c99(this.cb699020b026175cc5df5d433ca4c4f39.Handle, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9984));
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c40ece8fa5bfed221fc1f86983d53de2d.Dispose);
            }
            if (this.ce2dde71ac55aad4a9ce23a50ce61cd89 != null)
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  this.ce2dde71ac55aad4a9ce23a50ce61cd89.Dispose();
                  break;
              }
            }
            else
              break;
        }
      }
      base.Dispose(disposing);
    }

    private void cfb5cf413352ed4044535eb4a62d2e98f()
    {
      this.ce2dde71ac55aad4a9ce23a50ce61cd89 = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cd7273e3ff82b27fb0fe5f0856f9e1874.c6804baa30a51e813a45fabcfa2b27b79()));
      this.c6808cde2d6195d4f4340d06e157f93dc = new System.Windows.Forms.Timer(this.ce2dde71ac55aad4a9ce23a50ce61cd89);
      this.cb699020b026175cc5df5d433ca4c4f39 = new RichTextBox();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.cee9946355c6a614ff90b875d32801e38 = new RadLabel();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      this.c6808cde2d6195d4f4340d06e157f93dc.Interval = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9988);
      this.c6808cde2d6195d4f4340d06e157f93dc.Tick += new EventHandler(this.c4e53619ab2000559ce6cfce18a19dcf5);
      this.cb699020b026175cc5df5d433ca4c4f39.BorderStyle = (BorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9992);
      this.cb699020b026175cc5df5d433ca4c4f39.Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9996);
      this.cb699020b026175cc5df5d433ca4c4f39.Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15258), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10000), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10004), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10008), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10012));
      this.cb699020b026175cc5df5d433ca4c4f39.ForeColor = Color.White;
      this.cb699020b026175cc5df5d433ca4c4f39.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10016), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10020));
      this.cb699020b026175cc5df5d433ca4c4f39.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15273);
      this.cb699020b026175cc5df5d433ca4c4f39.ReadOnly = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10024) != 0;
      this.cb699020b026175cc5df5d433ca4c4f39.ScrollBars = (RichTextBoxScrollBars) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10028);
      this.cb699020b026175cc5df5d433ca4c4f39.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10032), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10036));
      this.cb699020b026175cc5df5d433ca4c4f39.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10040);
      this.cb699020b026175cc5df5d433ca4c4f39.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10044) != 0;
      this.cb699020b026175cc5df5d433ca4c4f39.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15288);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10048) != 0;
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10052);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10056), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10060));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10064), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10068));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10072);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15331);
      this.cd036f2b2868b103e71bd7b4fbe25a603.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10076));
      ((RadControl) this.cd036f2b2868b103e71bd7b4fbe25a603).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10080) != 0;
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10084);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10088), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10092));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12323);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10096), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10100));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10104);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15543);
      this.cee9946355c6a614ff90b875d32801e38.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10108));
      ((RadControl) this.cee9946355c6a614ff90b875d32801e38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10112), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10116));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10120));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10124), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10128));
      ((Control) this).Controls.Add((Control) this.cb699020b026175cc5df5d433ca4c4f39);
      ((Control) this).Controls.Add((Control) this.cee9946355c6a614ff90b875d32801e38);
      ((Control) this).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10132));
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15624);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10136) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10140) != 0);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15651);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Form) this).Load += new EventHandler(this.cfaf86d6c9d3f90e10df77bd7dbbe1511);
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10144) != 0);
    }

    private enum ce5a3fe696815367fc3fc69292d1195a2
    {
      c66d796500e91a69a4b403e08cd48b68d,
      c1498846e646d8c9373645f9fba5df4b8,
      cb5077460e44e5dead89322ab8b36b60f,
      ca1c9f393de74316348cb4a726e43b9f7,
    }

    private enum cf23721ecfe3849124ba4cfbb75c67cc2
    {
      cde4ba515111a64dfc4b0592c28574b10 = 1,
      cca8dd5497a70f3668d36b5c479926887 = 2,
      ce7f48a19b5eba0eb201977c66241e01f = 4,
      c08109e1b3ca0a2675e89fa3daf1f588c = 8,
      ce439541cdf8c48a282ed70871792f56f = 16,
      c4b2c0edaafdd0db28b2239d372be88f4 = 23,
    }

    private struct c6c2c5006e1d17734fb069b6ef030e403
    {
      public uint c7998cf459ffe48f7b920f83016bc017d;
      public uint ce9f99440e90c3b3efd36cde8367f5121;
      public int c21aca22e0a95452b71be5788f5767ab5;
      public int ce5a475d6fa9db36e8fb260d26159b287;
      public uint c5389642c57bf6f2bffeccafb67144e64;
      public int cc9b36c30ebab2d2720b2be10a83701ef;
      public int c5b36b9e3efb71b8ec66e2c5d1e542f8f;
    }
  }
}
