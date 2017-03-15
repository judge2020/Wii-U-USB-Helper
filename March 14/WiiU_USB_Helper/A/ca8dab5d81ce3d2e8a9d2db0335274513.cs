// Decompiled with JetBrains decompiler
// Type: A.ca8dab5d81ce3d2e8a9d2db0335274513
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class ca8dab5d81ce3d2e8a9d2db0335274513 : RadForm
  {
    private List<c4cd3182c1a92620e92b027ad11674ef9> cf7f3424df4d3a290ce38d1d0ebd605b4;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadListView cd1f843e42a66d99c7be2b2990a7005c3;
    private RadGroupBox c0b6ff62997904dd44189c4cb17f2ab15;
    private RadButton ceaa840c956974ca188494a71cc14878f;
    private RadTextBoxControl cdf4f936649fd7e5caeee05e0dab9c79e;
    private RadLabel cee9946355c6a614ff90b875d32801e38;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;

    public ca8dab5d81ce3d2e8a9d2db0335274513(List<c4cd3182c1a92620e92b027ad11674ef9> c23e0d8bc302a7d276ede38dd60c5f65a)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      this.cf7f3424df4d3a290ce38d1d0ebd605b4 = c23e0d8bc302a7d276ede38dd60c5f65a;
      using (List<c4cd3182c1a92620e92b027ad11674ef9>.Enumerator enumerator = c23e0d8bc302a7d276ede38dd60c5f65a.GetEnumerator())
      {
        while (enumerator.MoveNext())
          this.cfedd66ddc7da5e60f6b0b5a9cffe6071(enumerator.Current, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11284) != 0);
label_4:
        switch (4)
        {
          case 0:
            goto label_4;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ca8dab5d81ce3d2e8a9d2db0335274513.\u002Ector);
            break;
        }
      }
    }

    private void cfedd66ddc7da5e60f6b0b5a9cffe6071(c4cd3182c1a92620e92b027ad11674ef9 c9b9116b008baa62f087a5f18ff5513b9, bool cac8da65f67ca1adf0c0ec773c172e552)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ca8dab5d81ce3d2e8a9d2db0335274513.c4a7d6ef7470544794265a4766d92a639 c4a7d6ef7470544794265a4766d92a639 = new ca8dab5d81ce3d2e8a9d2db0335274513.c4a7d6ef7470544794265a4766d92a639();
      // ISSUE: reference to a compiler-generated field
      c4a7d6ef7470544794265a4766d92a639.c9b9116b008baa62f087a5f18ff5513b9 = c9b9116b008baa62f087a5f18ff5513b9;
      if (!cac8da65f67ca1adf0c0ec773c172e552)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ca8dab5d81ce3d2e8a9d2db0335274513.cfedd66ddc7da5e60f6b0b5a9cffe6071);
            }
            // ISSUE: reference to a compiler-generated method
            if (this.cf7f3424df4d3a290ce38d1d0ebd605b4.Any<c4cd3182c1a92620e92b027ad11674ef9>(new Func<c4cd3182c1a92620e92b027ad11674ef9, bool>(c4a7d6ef7470544794265a4766d92a639.c321dec0d21a62189fca2e2447a1a877d)))
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  return;
              }
            }
            else
              break;
        }
      }
      // ISSUE: reference to a compiler-generated field
      ListViewDataItem listViewDataItem = new ListViewDataItem((object) c4a7d6ef7470544794265a4766d92a639.c9b9116b008baa62f087a5f18ff5513b9);
      // ISSUE: reference to a compiler-generated field
      c4cd3182c1a92620e92b027ad11674ef9 c9b9116b008baa62f087a5f18ff5513b9_1 = c4a7d6ef7470544794265a4766d92a639.c9b9116b008baa62f087a5f18ff5513b9;
      listViewDataItem.set_Tag((object) c9b9116b008baa62f087a5f18ff5513b9_1);
      this.cd1f843e42a66d99c7be2b2990a7005c3.get_Items().Add(listViewDataItem);
      if (cac8da65f67ca1adf0c0ec773c172e552)
        return;
label_8:
      switch (1)
      {
        case 0:
          goto label_8;
        default:
          // ISSUE: reference to a compiler-generated field
          this.cf7f3424df4d3a290ce38d1d0ebd605b4.Add(c4a7d6ef7470544794265a4766d92a639.c9b9116b008baa62f087a5f18ff5513b9);
          break;
      }
    }

    private void cc067706f898221edfb932cc0fbf28ca1(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (!c4cd3182c1a92620e92b027ad11674ef9.c2818ab45b4841acf151bc0cfd9282673(((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ca8dab5d81ce3d2e8a9d2db0335274513.cc067706f898221edfb932cc0fbf28ca1);
            }
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16903));
            break;
        }
      }
      else
        this.cfedd66ddc7da5e60f6b0b5a9cffe6071(new c4cd3182c1a92620e92b027ad11674ef9(((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11048) != 0);
    }

    private void c0e6784edbde9022161a29ac467b4c73d(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c627fa68eab5b64ee6b24da313f6a4447(object c5382ad5461e274fda51b358802fc3910, ListViewItemEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.ce0acc4b78349686436079de062eef014(ccd4a5e95b67661279323579b4aa1e4a0.cc50e3aad2c922bb7d7e65938629ab7b5(c9572d7ff9cd6a116e4a6f248ca68a831.get_Item().get_Tag()));
    }

    private void ce0acc4b78349686436079de062eef014(c4cd3182c1a92620e92b027ad11674ef9 c9b9116b008baa62f087a5f18ff5513b9)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ca8dab5d81ce3d2e8a9d2db0335274513.c876a11add61abdb9617d04b515a32cfd c876a11add61abdb9617d04b515a32cfd = new ca8dab5d81ce3d2e8a9d2db0335274513.c876a11add61abdb9617d04b515a32cfd();
      // ISSUE: reference to a compiler-generated field
      c876a11add61abdb9617d04b515a32cfd.c9b9116b008baa62f087a5f18ff5513b9 = c9b9116b008baa62f087a5f18ff5513b9;
      // ISSUE: reference to a compiler-generated field
      this.cf7f3424df4d3a290ce38d1d0ebd605b4.Remove(c876a11add61abdb9617d04b515a32cfd.c9b9116b008baa62f087a5f18ff5513b9);
      // ISSUE: reference to a compiler-generated method
      this.cd1f843e42a66d99c7be2b2990a7005c3.get_Items().Remove(((IEnumerable<ListViewDataItem>) this.cd1f843e42a66d99c7be2b2990a7005c3.get_Items()).First<ListViewDataItem>(new Func<ListViewDataItem, bool>(c876a11add61abdb9617d04b515a32cfd.cb314c529c9673f4b1f20719d3c2dca0c)));
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ca8dab5d81ce3d2e8a9d2db0335274513.Dispose);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c9b4090f9607a8252f041a249fe420068.c6804baa30a51e813a45fabcfa2b27b79()));
      this.cd1f843e42a66d99c7be2b2990a7005c3 = new RadListView();
      this.c0b6ff62997904dd44189c4cb17f2ab15 = new RadGroupBox();
      this.cdf4f936649fd7e5caeee05e0dab9c79e = new RadTextBoxControl();
      this.ceaa840c956974ca188494a71cc14878f = new RadButton();
      this.cee9946355c6a614ff90b875d32801e38 = new RadLabel();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      ((ISupportInitialize) this.cd1f843e42a66d99c7be2b2990a7005c3).BeginInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).BeginInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).SuspendLayout();
      ((ISupportInitialize) this.cdf4f936649fd7e5caeee05e0dab9c79e).BeginInit();
      ((ISupportInitialize) this.ceaa840c956974ca188494a71cc14878f).BeginInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).BeginInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      this.cd1f843e42a66d99c7be2b2990a7005c3.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11052) != 0);
      this.cd1f843e42a66d99c7be2b2990a7005c3.set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11056) != 0);
      ((Control) this.cd1f843e42a66d99c7be2b2990a7005c3).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11060);
      this.cd1f843e42a66d99c7be2b2990a7005c3.set_FullRowSelect(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11064) != 0);
      this.cd1f843e42a66d99c7be2b2990a7005c3.set_ItemSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11068), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11072)));
      ((Control) this.cd1f843e42a66d99c7be2b2990a7005c3).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11076), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11080));
      ((Control) this.cd1f843e42a66d99c7be2b2990a7005c3).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16962);
      ((RadControl) this.cd1f843e42a66d99c7be2b2990a7005c3).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11084)));
      ((Control) this.cd1f843e42a66d99c7be2b2990a7005c3).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11088), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11092));
      ((Control) this.cd1f843e42a66d99c7be2b2990a7005c3).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11096);
      ((Control) this.cd1f843e42a66d99c7be2b2990a7005c3).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11100) != 0;
      ((Control) this.cd1f843e42a66d99c7be2b2990a7005c3).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      ((RadControl) this.cd1f843e42a66d99c7be2b2990a7005c3).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.cd1f843e42a66d99c7be2b2990a7005c3.set_ViewType((ListViewType) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11104));
      // ISSUE: method pointer
      this.cd1f843e42a66d99c7be2b2990a7005c3.add_ItemMouseDoubleClick(new ListViewItemEventHandler((object) this, __methodptr(c627fa68eab5b64ee6b24da313f6a4447)));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11108);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.ceaa840c956974ca188494a71cc14878f);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11112);
      this.c0b6ff62997904dd44189c4cb17f2ab15.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16977));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11116), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11120));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14902);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11124), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11128));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11132);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16977);
      ((RadControl) this.c0b6ff62997904dd44189c4cb17f2ab15).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11136);
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11140), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11144));
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15084);
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11148), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11152));
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11156);
      ((RadControl) this.cdf4f936649fd7e5caeee05e0dab9c79e).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ceaa840c956974ca188494a71cc14878f).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11160);
      ((Control) this.ceaa840c956974ca188494a71cc14878f).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11164), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11168));
      ((Control) this.ceaa840c956974ca188494a71cc14878f).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17010);
      ((Control) this.ceaa840c956974ca188494a71cc14878f).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11172), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11176));
      ((Control) this.ceaa840c956974ca188494a71cc14878f).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11180);
      ((Control) this.ceaa840c956974ca188494a71cc14878f).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17023);
      ((RadControl) this.ceaa840c956974ca188494a71cc14878f).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ceaa840c956974ca188494a71cc14878f).Click += new EventHandler(this.cc067706f898221edfb932cc0fbf28ca1);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11184) != 0;
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11188);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).ForeColor = Color.Orange;
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11192), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11196));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12323);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11200), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11204));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11208);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17030);
      this.cee9946355c6a614ff90b875d32801e38.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11212));
      ((RadControl) this.cee9946355c6a614ff90b875d32801e38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11216) != 0;
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11220);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11224), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11228));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11232), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11236));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11240);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17282);
      this.cd036f2b2868b103e71bd7b4fbe25a603.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11244));
      ((RadControl) this.cd036f2b2868b103e71bd7b4fbe25a603).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11248), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11252));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11256));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11260), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11264));
      ((Control) this).Controls.Add((Control) this.cd1f843e42a66d99c7be2b2990a7005c3);
      ((Control) this).Controls.Add((Control) this.cee9946355c6a614ff90b875d32801e38);
      ((Control) this).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((Control) this).Controls.Add((Control) this.c0b6ff62997904dd44189c4cb17f2ab15);
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17430);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11268));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11272) != 0);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17445);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Form) this).Load += new EventHandler(this.c0e6784edbde9022161a29ac467b4c73d);
      ((ISupportInitialize) this.cd1f843e42a66d99c7be2b2990a7005c3).EndInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).EndInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11276) != 0);
      ((ISupportInitialize) this.cdf4f936649fd7e5caeee05e0dab9c79e).EndInit();
      ((ISupportInitialize) this.ceaa840c956974ca188494a71cc14878f).EndInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).EndInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11280) != 0);
    }
  }
}
