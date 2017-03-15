// Decompiled with JetBrains decompiler
// Type: A.c080cfc6ad1dbb46ae8cbd29bbf8919e2
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
  public class c080cfc6ad1dbb46ae8cbd29bbf8919e2 : RadForm
  {
    public List<cce1cf1e0b6971ed6f7ef86a83b0959b6> ce5be2c2084a0a5097f4942fe5b6d67b4;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadButton ca75cf6b554bca20b242f951643c4d424;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadButton c51175a4a3b6b11c0eee765ad7effd076;
    private RadGroupBox c0b6ff62997904dd44189c4cb17f2ab15;
    private RadLabel cee9946355c6a614ff90b875d32801e38;
    private RadCheckedListBox c315ebf3de36e7a50ea2c550cda4eaba1;

    public c080cfc6ad1dbb46ae8cbd29bbf8919e2(List<cce1cf1e0b6971ed6f7ef86a83b0959b6> c36d889c4f7b28f030e8381c5f3641d74)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      using (List<cce1cf1e0b6971ed6f7ef86a83b0959b6>.Enumerator enumerator = c36d889c4f7b28f030e8381c5f3641d74.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          cce1cf1e0b6971ed6f7ef86a83b0959b6 current = enumerator.Current;
          ListViewDataItemCollection items = ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_Items();
          ListViewDataItem listViewDataItem = new ListViewDataItem((object) current);
          cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = current;
          listViewDataItem.set_Tag((object) cce1cf1e0b6971ed6f7ef86a83b0959b6);
          items.Add(listViewDataItem);
        }
label_4:
        switch (6)
        {
          case 0:
            goto label_4;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c080cfc6ad1dbb46ae8cbd29bbf8919e2.\u002Ector);
            break;
        }
      }
    }

    private void c73a91aa5e28f9899f28a0eb26c625fd5(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      IEnumerator<ListViewDataItem> enumerator = ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_Items().GetEnumerator();
      try
      {
        while (((IEnumerator) enumerator).MoveNext())
          enumerator.Current.set_CheckState((ToggleState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10848));
label_4:
        switch (4)
        {
          case 0:
            goto label_4;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c080cfc6ad1dbb46ae8cbd29bbf8919e2.c73a91aa5e28f9899f28a0eb26c625fd5);
            break;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_9:
          switch (2)
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
      ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10852);
      ListViewDataItemCollection items = ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_Items();
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, bool> predicate = c080cfc6ad1dbb46ae8cbd29bbf8919e2.\u003C\u003Ec.cc0f52a4ee47913287ae94acda1344091;
      if (predicate == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c080cfc6ad1dbb46ae8cbd29bbf8919e2.cf93b4b8c40f46dbd89b416a232d361f0);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            predicate = c080cfc6ad1dbb46ae8cbd29bbf8919e2.\u003C\u003Ec.cc0f52a4ee47913287ae94acda1344091 = new Func<ListViewDataItem, bool>(c080cfc6ad1dbb46ae8cbd29bbf8919e2.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cf66d9a5232f225b2b25e26995dc35e8c);
            break;
        }
      }
      IEnumerable<ListViewDataItem> source = ((IEnumerable<ListViewDataItem>) items).Where<ListViewDataItem>(predicate);
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector = c080cfc6ad1dbb46ae8cbd29bbf8919e2.\u003C\u003Ec.c9e0ce7ad368fb9b6abacaf7b7af4ee11;
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
            selector = c080cfc6ad1dbb46ae8cbd29bbf8919e2.\u003C\u003Ec.c9e0ce7ad368fb9b6abacaf7b7af4ee11 = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c080cfc6ad1dbb46ae8cbd29bbf8919e2.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cdd770b6876472fe66f2095f51ce2e093);
            break;
        }
      }
      this.ce5be2c2084a0a5097f4942fe5b6d67b4 = source.Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector).ToList<cce1cf1e0b6971ed6f7ef86a83b0959b6>();
      ((Form) this).Close();
    }

    private void cb56b11ce4ade631a7106e629654b04c4(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void cda0083ff2d7ad8dc5a378909d229a0b0(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c080cfc6ad1dbb46ae8cbd29bbf8919e2.Dispose);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c2af734756c2d6bd28a48005deacf05b6.c6804baa30a51e813a45fabcfa2b27b79()));
      this.ca75cf6b554bca20b242f951643c4d424 = new RadButton();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.c51175a4a3b6b11c0eee765ad7effd076 = new RadButton();
      this.c0b6ff62997904dd44189c4cb17f2ab15 = new RadGroupBox();
      this.cee9946355c6a614ff90b875d32801e38 = new RadLabel();
      this.c315ebf3de36e7a50ea2c550cda4eaba1 = new RadCheckedListBox();
      ((ISupportInitialize) this.ca75cf6b554bca20b242f951643c4d424).BeginInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.c51175a4a3b6b11c0eee765ad7effd076).BeginInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).BeginInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).SuspendLayout();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).BeginInit();
      ((ISupportInitialize) this.c315ebf3de36e7a50ea2c550cda4eaba1).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10856);
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10860), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10864));
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15903);
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10868), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10872));
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10876);
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16652);
      ((RadControl) this.ca75cf6b554bca20b242f951643c4d424).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Click += new EventHandler(this.cf93b4b8c40f46dbd89b416a232d361f0);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10880) != 0;
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10884);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10888), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10892));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10896), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10900));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10904);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16685);
      this.cd036f2b2868b103e71bd7b4fbe25a603.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10908));
      ((RadControl) this.cd036f2b2868b103e71bd7b4fbe25a603).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10912);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10916), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10920));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16429);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10924), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10928));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10932);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16452);
      ((RadControl) this.c51175a4a3b6b11c0eee765ad7effd076).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Click += new EventHandler(this.c73a91aa5e28f9899f28a0eb26c625fd5);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10936);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10940);
      this.c0b6ff62997904dd44189c4cb17f2ab15.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10944), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10948));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14902);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10952), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10956));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10960);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935);
      ((RadControl) this.c0b6ff62997904dd44189c4cb17f2ab15).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Click += new EventHandler(this.cda0083ff2d7ad8dc5a378909d229a0b0);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10964), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10968));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12323);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10972), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10976));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10980);
      ((RadControl) this.cee9946355c6a614ff90b875d32801e38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10984);
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10988), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10992));
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15793);
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10996), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11000));
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11004);
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7221);
      ((RadControl) this.c315ebf3de36e7a50ea2c550cda4eaba1).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11008), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11012));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11016));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11020), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11024));
      ((Control) this).Controls.Add((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1);
      ((Control) this).Controls.Add((Control) this.c51175a4a3b6b11c0eee765ad7effd076);
      ((Control) this).Controls.Add((Control) this.ca75cf6b554bca20b242f951643c4d424);
      ((Control) this).Controls.Add((Control) this.c0b6ff62997904dd44189c4cb17f2ab15);
      ((Control) this).Controls.Add((Control) this.cee9946355c6a614ff90b875d32801e38);
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16835);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11028));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11032) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11036);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16860);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Form) this).Load += new EventHandler(this.cb56b11ce4ade631a7106e629654b04c4);
      ((ISupportInitialize) this.ca75cf6b554bca20b242f951643c4d424).EndInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.c51175a4a3b6b11c0eee765ad7effd076).EndInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).EndInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11040) != 0);
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).EndInit();
      ((ISupportInitialize) this.c315ebf3de36e7a50ea2c550cda4eaba1).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11044) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
