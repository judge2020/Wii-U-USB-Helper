// Decompiled with JetBrains decompiler
// Type: A.c58509175cbe634f2808d2fefd16ab8d3
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace A
{
  internal class c58509175cbe634f2808d2fefd16ab8d3 : RadForm
  {
    public List<ce64fe4baff0b285aaecd02e2cae2ea2c> cb917dff3a4bc5ccb946b4a838034a862;
    private RadButton cb986ff8bb5fd141228be375bfc60bdc6;
    private RadButton c7cca1c8ca71c2cf05bdd35a4bbdd30d5;
    private RadCheckedListBox c04ec098e0966ffd0b1a10f49441db094;
    private RadGroupBox c3e6103514481615fe8ff93d3bf1b3603;
    private RadLabel c95ef98fe47240003ef4672097ba17b78;
    private RadLabel c3375300769682315777e854716124324;

    public c58509175cbe634f2808d2fefd16ab8d3(IEnumerable<ce64fe4baff0b285aaecd02e2cae2ea2c> c1c0fd38914d2630ff1a82119e1950d3c, bool c0d59b6e3336027fba937015623892add)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      IEnumerator<ce64fe4baff0b285aaecd02e2cae2ea2c> enumerator = c1c0fd38914d2630ff1a82119e1950d3c.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          ce64fe4baff0b285aaecd02e2cae2ea2c current = enumerator.Current;
          ListViewDataItemCollection items = ((RadListView) this.c04ec098e0966ffd0b1a10f49441db094).get_Items();
          ListViewDataItem listViewDataItem = new ListViewDataItem(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18536), (object) current.Version, (object) current.Size));
          ce64fe4baff0b285aaecd02e2cae2ea2c ce64fe4baff0b285aaecd02e2cae2ea2c = current;
          listViewDataItem.set_Tag((object) ce64fe4baff0b285aaecd02e2cae2ea2c);
          Color cfed4875cfd556dd488b4a4d828cb7bc5 = current.cfed4875cfd556dd488b4a4d828cb7bc5;
          listViewDataItem.set_ForeColor(cfed4875cfd556dd488b4a4d828cb7bc5);
          int num;
          if (c0d59b6e3336027fba937015623892add)
          {
label_3:
            switch (4)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c58509175cbe634f2808d2fefd16ab8d3.\u002Ector);
                }
                num = current.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11608) ? 1 : 0;
                break;
            }
          }
          else
            num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11612);
          listViewDataItem.set_Enabled(num != 0);
          items.Add(listViewDataItem);
        }
label_10:
        switch (6)
        {
          case 0:
            goto label_10;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_13:
          switch (3)
          {
            case 0:
              goto label_13;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
    }

    private void c73a91aa5e28f9899f28a0eb26c625fd5(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      IEnumerator<ListViewDataItem> enumerator = ((RadListView) this.c04ec098e0966ffd0b1a10f49441db094).get_Items().GetEnumerator();
      try
      {
        while (((IEnumerator) enumerator).MoveNext())
          enumerator.Current.set_CheckState((ToggleState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11428));
label_4:
        switch (2)
        {
          case 0:
            goto label_4;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c58509175cbe634f2808d2fefd16ab8d3.c73a91aa5e28f9899f28a0eb26c625fd5);
            break;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_9:
          switch (5)
          {
            case 0:
              goto label_9;
            default:
              ((IDisposable) enumerator).Dispose();
              break;
          }
        }
      }
    }

    private void cf93b4b8c40f46dbd89b416a232d361f0(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11432);
      ListViewDataItemCollection items = ((RadListView) this.c04ec098e0966ffd0b1a10f49441db094).get_Items();
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, bool> predicate = c58509175cbe634f2808d2fefd16ab8d3.\u003C\u003Ec.c8a5d0d96543166e412a0138bc8c79ecc;
      if (predicate == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c58509175cbe634f2808d2fefd16ab8d3.cf93b4b8c40f46dbd89b416a232d361f0);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            predicate = c58509175cbe634f2808d2fefd16ab8d3.\u003C\u003Ec.c8a5d0d96543166e412a0138bc8c79ecc = new Func<ListViewDataItem, bool>(c58509175cbe634f2808d2fefd16ab8d3.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cec618fa38ed8716670f3b5ec46dd32c4);
            break;
        }
      }
      IEnumerable<ListViewDataItem> source = ((IEnumerable<ListViewDataItem>) items).Where<ListViewDataItem>(predicate);
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, ce64fe4baff0b285aaecd02e2cae2ea2c> selector = c58509175cbe634f2808d2fefd16ab8d3.\u003C\u003Ec.cc12525f371daa270dfa7aaf5589af289;
      if (selector == null)
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
            selector = c58509175cbe634f2808d2fefd16ab8d3.\u003C\u003Ec.cc12525f371daa270dfa7aaf5589af289 = new Func<ListViewDataItem, ce64fe4baff0b285aaecd02e2cae2ea2c>(c58509175cbe634f2808d2fefd16ab8d3.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c8d4ffdfc6563bf0f4ab221ad7d07e165);
            break;
        }
      }
      this.cb917dff3a4bc5ccb946b4a838034a862 = source.Select<ListViewDataItem, ce64fe4baff0b285aaecd02e2cae2ea2c>(selector).ToList<ce64fe4baff0b285aaecd02e2cae2ea2c>();
      ((Form) this).Close();
    }

    private void c138ccb40d607129c8cc7e7de877df233(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void cfb5cf413352ed4044535eb4a62d2e98f()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c88268b74f5ce364f3970b8bd3f051a39.c6804baa30a51e813a45fabcfa2b27b79()));
      this.c04ec098e0966ffd0b1a10f49441db094 = new RadCheckedListBox();
      this.c95ef98fe47240003ef4672097ba17b78 = new RadLabel();
      this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5 = new RadButton();
      this.c3e6103514481615fe8ff93d3bf1b3603 = new RadGroupBox();
      this.c3375300769682315777e854716124324 = new RadLabel();
      this.cb986ff8bb5fd141228be375bfc60bdc6 = new RadButton();
      ((ISupportInitialize) this.c04ec098e0966ffd0b1a10f49441db094).BeginInit();
      ((ISupportInitialize) this.c95ef98fe47240003ef4672097ba17b78).BeginInit();
      ((ISupportInitialize) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).BeginInit();
      ((ISupportInitialize) this.c3e6103514481615fe8ff93d3bf1b3603).BeginInit();
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).SuspendLayout();
      ((ISupportInitialize) this.c3375300769682315777e854716124324).BeginInit();
      ((ISupportInitialize) this.cb986ff8bb5fd141228be375bfc60bdc6).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((RadListView) this.c04ec098e0966ffd0b1a10f49441db094).set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11436) != 0);
      ((Control) this.c04ec098e0966ffd0b1a10f49441db094).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11440);
      ((Control) this.c04ec098e0966ffd0b1a10f49441db094).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11444), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11448));
      ((Control) this.c04ec098e0966ffd0b1a10f49441db094).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18170);
      ((Control) this.c04ec098e0966ffd0b1a10f49441db094).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11452), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11456));
      ((Control) this.c04ec098e0966ffd0b1a10f49441db094).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11460);
      ((Control) this.c04ec098e0966ffd0b1a10f49441db094).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7221);
      ((RadControl) this.c04ec098e0966ffd0b1a10f49441db094).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c95ef98fe47240003ef4672097ba17b78).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11464), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11468));
      ((Control) this.c95ef98fe47240003ef4672097ba17b78).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18195);
      ((Control) this.c95ef98fe47240003ef4672097ba17b78).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11472), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11476));
      ((Control) this.c95ef98fe47240003ef4672097ba17b78).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11480);
      ((Control) this.c95ef98fe47240003ef4672097ba17b78).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18216);
      ((RadControl) this.c95ef98fe47240003ef4672097ba17b78).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11484);
      ((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11488), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11492));
      ((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18378);
      ((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11496), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11500));
      ((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11504);
      ((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14002);
      ((RadControl) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).Click += new EventHandler(this.cf93b4b8c40f46dbd89b416a232d361f0);
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11508);
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).Controls.Add((Control) this.c95ef98fe47240003ef4672097ba17b78);
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11512);
      this.c3e6103514481615fe8ff93d3bf1b3603.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935));
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11516), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11520));
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18399);
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11524), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11528));
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11532);
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935);
      ((RadControl) this.c3e6103514481615fe8ff93d3bf1b3603).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c3375300769682315777e854716124324).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11536), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11540));
      ((Control) this.c3375300769682315777e854716124324).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18426);
      ((Control) this.c3375300769682315777e854716124324).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11544), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11548));
      ((Control) this.c3375300769682315777e854716124324).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11552);
      ((RadControl) this.c3375300769682315777e854716124324).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cb986ff8bb5fd141228be375bfc60bdc6).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11556);
      ((Control) this.cb986ff8bb5fd141228be375bfc60bdc6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11560), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11564));
      ((Control) this.cb986ff8bb5fd141228be375bfc60bdc6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18447);
      ((Control) this.cb986ff8bb5fd141228be375bfc60bdc6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11568), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11572));
      ((Control) this.cb986ff8bb5fd141228be375bfc60bdc6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11576);
      ((Control) this.cb986ff8bb5fd141228be375bfc60bdc6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16452);
      ((RadControl) this.cb986ff8bb5fd141228be375bfc60bdc6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cb986ff8bb5fd141228be375bfc60bdc6).Click += new EventHandler(this.c73a91aa5e28f9899f28a0eb26c625fd5);
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11580), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11584));
      ((Control) this).Controls.Add((Control) this.c04ec098e0966ffd0b1a10f49441db094);
      ((Control) this).Controls.Add((Control) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5);
      ((Control) this).Controls.Add((Control) this.c3e6103514481615fe8ff93d3bf1b3603);
      ((Control) this).Controls.Add((Control) this.c3375300769682315777e854716124324);
      ((Control) this).Controls.Add((Control) this.cb986ff8bb5fd141228be375bfc60bdc6);
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18472);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11588));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11592) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11596);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18505);
      ((Form) this).Load += new EventHandler(this.c138ccb40d607129c8cc7e7de877df233);
      ((ISupportInitialize) this.c04ec098e0966ffd0b1a10f49441db094).EndInit();
      ((ISupportInitialize) this.c95ef98fe47240003ef4672097ba17b78).EndInit();
      ((ISupportInitialize) this.c7cca1c8ca71c2cf05bdd35a4bbdd30d5).EndInit();
      ((ISupportInitialize) this.c3e6103514481615fe8ff93d3bf1b3603).EndInit();
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11600) != 0);
      ((Control) this.c3e6103514481615fe8ff93d3bf1b3603).PerformLayout();
      ((ISupportInitialize) this.c3375300769682315777e854716124324).EndInit();
      ((ISupportInitialize) this.cb986ff8bb5fd141228be375bfc60bdc6).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11604) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
