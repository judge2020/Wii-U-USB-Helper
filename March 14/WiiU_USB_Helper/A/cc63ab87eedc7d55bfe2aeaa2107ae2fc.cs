// Decompiled with JetBrains decompiler
// Type: A.cc63ab87eedc7d55bfe2aeaa2107ae2fc
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace A
{
  public class cc63ab87eedc7d55bfe2aeaa2107ae2fc : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadListView c65f861b1ada795332daa927090b1b14c;

    public cc63ab87eedc7d55bfe2aeaa2107ae2fc()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    private void cf33e0560c2c6e3e3e092c0b7031d4cd9(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      IEnumerator enumerator = ThemeResolutionService.GetAvailableThemes().GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          Theme theme = c02b2fecc9b0ef6addf52de0dd5ccd69c.cc50e3aad2c922bb7d7e65938629ab7b5(enumerator.Current);
          string str = theme.get_Name();
          bool flag = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8852) != 0;
          if ((int) str[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8856)] == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8860))
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
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (cc63ab87eedc7d55bfe2aeaa2107ae2fc.cf33e0560c2c6e3e3e092c0b7031d4cd9);
                }
                str = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(str.Substring(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8864)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11622));
                flag = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8868) != 0;
                break;
            }
          }
          ListViewDataItem listViewDataItem1 = new ListViewDataItem(str);
          // ISSUE: variable of a boxed type
          __Boxed<cc63ab87eedc7d55bfe2aeaa2107ae2fc.cea0e74da2ae5d7bba498be9a015788b7> local = (ValueType) new cc63ab87eedc7d55bfe2aeaa2107ae2fc.cea0e74da2ae5d7bba498be9a015788b7()
          {
            c090e9be3adeefa4f775e2db1df3a5e76 = flag,
            c877d54a69c33c3dc31908396e4e7c29e = theme
          };
          listViewDataItem1.set_Tag((object) local);
          ListViewDataItem listViewDataItem2 = listViewDataItem1;
          if (flag)
          {
label_8:
            switch (6)
            {
              case 0:
                goto label_8;
              default:
                listViewDataItem2.set_ForeColor(Color.DarkOrange);
                break;
            }
          }
          this.c65f861b1ada795332daa927090b1b14c.get_Items().Add(listViewDataItem2);
        }
label_12:
        switch (2)
        {
          case 0:
            goto label_12;
        }
      }
      finally
      {
        IDisposable disposable = c338061a69ddbf07990b7731aba45a615.cc50e3aad2c922bb7d7e65938629ab7b5((object) enumerator);
        if (disposable != null)
        {
label_15:
          switch (1)
          {
            case 0:
              goto label_15;
            default:
              disposable.Dispose();
              break;
          }
        }
      }
    }

    private void c6267a7184934e7c44769628c778a0948(object c5382ad5461e274fda51b358802fc3910, ListViewItemEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      cc63ab87eedc7d55bfe2aeaa2107ae2fc.cea0e74da2ae5d7bba498be9a015788b7 tag = (cc63ab87eedc7d55bfe2aeaa2107ae2fc.cea0e74da2ae5d7bba498be9a015788b7) c9572d7ff9cd6a116e4a6f248ca68a831.get_Item().get_Tag();
      if (tag.c090e9be3adeefa4f775e2db1df3a5e76)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cc63ab87eedc7d55bfe2aeaa2107ae2fc.c6267a7184934e7c44769628c778a0948);
            }
            if (!c1b0822c22b951c8a567b56dd01e313bf.c727abdef873c71ae15e67e1b27e2ad96)
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11651));
                  return;
              }
            }
            else
              break;
        }
      }
      Settings.Default.ThemeName = tag.c877d54a69c33c3dc31908396e4e7c29e.get_Name();
      Settings.Default.Save();
      int num1 = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11929));
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cc63ab87eedc7d55bfe2aeaa2107ae2fc.Dispose);
            }
            if (this.ce2dde71ac55aad4a9ce23a50ce61cd89 != null)
            {
label_5:
              switch (1)
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
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.c65f861b1ada795332daa927090b1b14c = new RadListView();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.c65f861b1ada795332daa927090b1b14c).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8872) != 0;
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8876);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8880), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8884));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8888), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8892));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8896);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12038);
      this.cd036f2b2868b103e71bd7b4fbe25a603.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8900));
      ((Control) this.c65f861b1ada795332daa927090b1b14c).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8904);
      ((Control) this.c65f861b1ada795332daa927090b1b14c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8908), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8912));
      ((Control) this.c65f861b1ada795332daa927090b1b14c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12081);
      this.c65f861b1ada795332daa927090b1b14c.set_SelectLastAddedItem(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8916) != 0);
      ((Control) this.c65f861b1ada795332daa927090b1b14c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8920), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8924));
      ((Control) this.c65f861b1ada795332daa927090b1b14c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8928);
      ((Control) this.c65f861b1ada795332daa927090b1b14c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      // ISSUE: method pointer
      this.c65f861b1ada795332daa927090b1b14c.add_ItemMouseClick(new ListViewItemEventHandler((object) this, __methodptr(c6267a7184934e7c44769628c778a0948)));
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8932), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8936));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8940));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8944), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8948));
      ((Control) this).Controls.Add((Control) this.c65f861b1ada795332daa927090b1b14c);
      ((Control) this).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8952));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12125);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8956));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8960) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8964) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8968);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12154);
      ((Form) this).Load += new EventHandler(this.cf33e0560c2c6e3e3e092c0b7031d4cd9);
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.c65f861b1ada795332daa927090b1b14c).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8972) != 0);
    }

    internal struct cea0e74da2ae5d7bba498be9a015788b7
    {
      public Theme c877d54a69c33c3dc31908396e4e7c29e;
      public bool c090e9be3adeefa4f775e2db1df3a5e76;
    }
  }
}
