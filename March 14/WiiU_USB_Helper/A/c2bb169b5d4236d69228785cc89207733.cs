// Decompiled with JetBrains decompiler
// Type: A.c2bb169b5d4236d69228785cc89207733
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Microsoft.VisualBasic.FileIO;
using NusHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace A
{
  public class c2bb169b5d4236d69228785cc89207733 : RadForm
  {
    private readonly string c63c0ca8007eeb7a469e1da8be16a13e9;
    private readonly Dictionary<TitleId, cce1cf1e0b6971ed6f7ef86a83b0959b6> cf6f34441876141f7c039043a0533fa6f;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadCheckedListBox c315ebf3de36e7a50ea2c550cda4eaba1;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadLabel cee9946355c6a614ff90b875d32801e38;
    private RadButton ca75cf6b554bca20b242f951643c4d424;
    private RadGroupBox c0b6ff62997904dd44189c4cb17f2ab15;
    private RadLabel c38925728235576f0c42cd968bde792d6;
    private RadLabel cba34b2a0111f6e5bc303375f968bc295;
    private RadButton c51175a4a3b6b11c0eee765ad7effd076;
    private RadLabel c0b8c323aae75c040334498c5efcb96f4;
    private RadLabel c9e453c2e79f4fc55124ccb1fd3603902;

    public c2bb169b5d4236d69228785cc89207733(string ce6bdde62a2324ba2240563e706e2d49a, Dictionary<TitleId, cce1cf1e0b6971ed6f7ef86a83b0959b6> c8081e7b23c9b7a2c1932218177f9033b)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      this.c63c0ca8007eeb7a469e1da8be16a13e9 = ce6bdde62a2324ba2240563e706e2d49a;
      this.cf6f34441876141f7c039043a0533fa6f = c8081e7b23c9b7a2c1932218177f9033b;
    }

    private void c73a91aa5e28f9899f28a0eb26c625fd5(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      IEnumerator<ListViewDataItem> enumerator = ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_Items().GetEnumerator();
      try
      {
        while (((IEnumerator) enumerator).MoveNext())
          enumerator.Current.set_CheckState((ToggleState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10148));
label_4:
        switch (3)
        {
          case 0:
            goto label_4;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c2bb169b5d4236d69228785cc89207733.c73a91aa5e28f9899f28a0eb26c625fd5);
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
      ListViewDataItemCollection items = ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_Items();
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, bool> predicate = c2bb169b5d4236d69228785cc89207733.\u003C\u003Ec.c3dde63024774c9d6a2267213c54e21a5;
      if (predicate == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2bb169b5d4236d69228785cc89207733.cf93b4b8c40f46dbd89b416a232d361f0);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            predicate = c2bb169b5d4236d69228785cc89207733.\u003C\u003Ec.c3dde63024774c9d6a2267213c54e21a5 = new Func<ListViewDataItem, bool>(c2bb169b5d4236d69228785cc89207733.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c245a3c39946ec1c95ca94d9869c4f82d);
            break;
        }
      }
      IEnumerator<ListViewDataItem> enumerator = ((IEnumerable<ListViewDataItem>) items).Where<ListViewDataItem>(predicate).GetEnumerator();
      try
      {
        while (((IEnumerator) enumerator).MoveNext())
        {
          Tuple<string, cba6aa8f767d2e8dfbca2d43d7148c173> tuple = c6ed76dbd51df83645ab39eaa1eff2b91.cc50e3aad2c922bb7d7e65938629ab7b5(enumerator.Current.get_Tag());
          FileSystem.MoveDirectory(tuple.Item1, tuple.Item2.OutputPath, (UIOption) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10152));
          tuple.Item2.ca5649281440802bb4aae634896917d91();
        }
label_9:
        switch (2)
        {
          case 0:
            goto label_9;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_11:
          switch (3)
          {
            case 0:
              goto label_11;
            default:
              ((IDisposable) enumerator).Dispose();
              break;
          }
        }
      }
      ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10156);
      ((Form) this).Close();
    }

    private void c6f9e28dce46d00214020200ce5c6bfbe(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Collection<SortDescriptor>) ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_SortDescriptors()).Add(new SortDescriptor(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15676), (ListSortDirection) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10160)));
      string[] directories = Directory.GetDirectories(this.c63c0ca8007eeb7a469e1da8be16a13e9);
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10164);
      while (index < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(directories))
      {
        string path1 = directories[index];
        string str = Path.Combine(path1, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2456));
        if (File.Exists(str))
        {
label_2:
          switch (1)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c2bb169b5d4236d69228785cc89207733.c6f9e28dce46d00214020200ce5c6bfbe);
              }
              TitleId titleId = new TitleId(cff72ea250ac36ea03abde33ff61b7565.cb5009c1058eaad54842d9bead8e530a2(str, (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10168)).TitleId.ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15687)));
              if (this.cf6f34441876141f7c039043a0533fa6f.ContainsKey(titleId.FullGame))
              {
label_6:
                switch (5)
                {
                  case 0:
                    goto label_6;
                  default:
                    cba6aa8f767d2e8dfbca2d43d7148c173 cba6aa8f767d2e8dfbca2d43d7148c173 = ca8f39da86e7b333d7240f7f58b938e54.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                    switch (titleId.IdType)
                    {
                      case cfcd12ee63ba7d661f4ab310574290bf9.c67e3dde1b06befbd68123cff88fcb6f5:
                        cba6aa8f767d2e8dfbca2d43d7148c173 = (cba6aa8f767d2e8dfbca2d43d7148c173) this.cf6f34441876141f7c039043a0533fa6f[titleId.FullGame].Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>();
                        break;
                      case cfcd12ee63ba7d661f4ab310574290bf9.c9506d0fd83bf15f08302a35bc6ce2547:
                        cba6aa8f767d2e8dfbca2d43d7148c173 = (cba6aa8f767d2e8dfbca2d43d7148c173) this.cf6f34441876141f7c039043a0533fa6f[titleId.FullGame];
                        break;
                      case cfcd12ee63ba7d661f4ab310574290bf9.c171a4a3dc0f5f061bd920529c13faa2a:
                        cba6aa8f767d2e8dfbca2d43d7148c173 = (cba6aa8f767d2e8dfbca2d43d7148c173) this.cf6f34441876141f7c039043a0533fa6f[titleId.FullGame].Dlc;
                        break;
                    }
                    if (cba6aa8f767d2e8dfbca2d43d7148c173 != null)
                    {
label_13:
                      switch (2)
                      {
                        case 0:
                          goto label_13;
                        default:
                          if (!Directory.Exists(cba6aa8f767d2e8dfbca2d43d7148c173.OutputPath))
                          {
label_15:
                            switch (7)
                            {
                              case 0:
                                goto label_15;
                              default:
                                ListViewDataItem listViewDataItem = new ListViewDataItem((object) cba6aa8f767d2e8dfbca2d43d7148c173);
                                Tuple<string, cba6aa8f767d2e8dfbca2d43d7148c173> tuple = new Tuple<string, cba6aa8f767d2e8dfbca2d43d7148c173>(path1, cba6aa8f767d2e8dfbca2d43d7148c173);
                                listViewDataItem.set_Tag((object) tuple);
                                ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_Items().Add(listViewDataItem);
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
              }
              else
                break;
          }
        }
        index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10172);
      }
label_19:
      switch (7)
      {
        case 0:
          goto label_19;
        default:
          if (((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).get_Items().get_Count() != 0)
          {
label_21:
            switch (2)
            {
              case 0:
                goto label_21;
              default:
                return;
            }
          }
          else
          {
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15694));
            ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10176);
            ((Form) this).Close();
            break;
          }
      }
    }

    private void cb42fd5251475b82666a24ad0ee4d65c6(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void cda0083ff2d7ad8dc5a378909d229a0b0(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c6867c328266a684e255f3e845159490f(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void cde47dfcc2c5f0f43f25fde9825b1bff9(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c68466370159591d103d317ff138cc2d1(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void cf7db0bc1157d74354f9f6496a296c24f(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c055f9c481300eac610c0c54370bb4fc2(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c40834fe6e096f5f7d2c61d5d194bc8bf(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c2bb169b5d4236d69228785cc89207733.Dispose);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cfd932400aa2acc273e255df4b5e4a6af.c6804baa30a51e813a45fabcfa2b27b79()));
      this.c315ebf3de36e7a50ea2c550cda4eaba1 = new RadCheckedListBox();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.cee9946355c6a614ff90b875d32801e38 = new RadLabel();
      this.ca75cf6b554bca20b242f951643c4d424 = new RadButton();
      this.c0b6ff62997904dd44189c4cb17f2ab15 = new RadGroupBox();
      this.c0b8c323aae75c040334498c5efcb96f4 = new RadLabel();
      this.c9e453c2e79f4fc55124ccb1fd3603902 = new RadLabel();
      this.c38925728235576f0c42cd968bde792d6 = new RadLabel();
      this.cba34b2a0111f6e5bc303375f968bc295 = new RadLabel();
      this.c51175a4a3b6b11c0eee765ad7effd076 = new RadButton();
      ((ISupportInitialize) this.c315ebf3de36e7a50ea2c550cda4eaba1).BeginInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).BeginInit();
      ((ISupportInitialize) this.ca75cf6b554bca20b242f951643c4d424).BeginInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).BeginInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).SuspendLayout();
      ((ISupportInitialize) this.c0b8c323aae75c040334498c5efcb96f4).BeginInit();
      ((ISupportInitialize) this.c9e453c2e79f4fc55124ccb1fd3603902).BeginInit();
      ((ISupportInitialize) this.c38925728235576f0c42cd968bde792d6).BeginInit();
      ((ISupportInitialize) this.cba34b2a0111f6e5bc303375f968bc295).BeginInit();
      ((ISupportInitialize) this.c51175a4a3b6b11c0eee765ad7effd076).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10180) != 0);
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10184);
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10188), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10192));
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15793);
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10196), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10200));
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10204);
      ((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7221);
      ((RadControl) this.c315ebf3de36e7a50ea2c550cda4eaba1).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((RadListView) this.c315ebf3de36e7a50ea2c550cda4eaba1).add_SelectedItemChanged(new EventHandler(this.cb42fd5251475b82666a24ad0ee4d65c6));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10208), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10212));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10216), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10220));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10224);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15812);
      ((RadControl) this.cd036f2b2868b103e71bd7b4fbe25a603).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Click += new EventHandler(this.c6867c328266a684e255f3e845159490f);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10228), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10232));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12323);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10236), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10240));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10244);
      ((RadControl) this.cee9946355c6a614ff90b875d32801e38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Click += new EventHandler(this.cde47dfcc2c5f0f43f25fde9825b1bff9);
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10248);
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10252), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10256));
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15903);
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10260), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10264));
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10268);
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15922);
      ((RadControl) this.ca75cf6b554bca20b242f951643c4d424).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ca75cf6b554bca20b242f951643c4d424).Click += new EventHandler(this.cf93b4b8c40f46dbd89b416a232d361f0);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10272);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c0b8c323aae75c040334498c5efcb96f4);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c9e453c2e79f4fc55124ccb1fd3603902);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c38925728235576f0c42cd968bde792d6);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cba34b2a0111f6e5bc303375f968bc295);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10276);
      this.c0b6ff62997904dd44189c4cb17f2ab15.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10280), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10284));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14902);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10288), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10292));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10296);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935);
      ((RadControl) this.c0b6ff62997904dd44189c4cb17f2ab15).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Click += new EventHandler(this.cda0083ff2d7ad8dc5a378909d229a0b0);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10300), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10304));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14336);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10308), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10312));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10316);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15944);
      ((RadControl) this.c0b8c323aae75c040334498c5efcb96f4).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Click += new EventHandler(this.c40834fe6e096f5f7d2c61d5d194bc8bf);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10320), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10324));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13621);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10328), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10332));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10336);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16071);
      ((RadControl) this.c9e453c2e79f4fc55124ccb1fd3603902).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Click += new EventHandler(this.c055f9c481300eac610c0c54370bb4fc2);
      ((Control) this.c38925728235576f0c42cd968bde792d6).ForeColor = Color.Red;
      ((Control) this.c38925728235576f0c42cd968bde792d6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10340), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10344));
      ((Control) this.c38925728235576f0c42cd968bde792d6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14533);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10348), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10352));
      ((Control) this.c38925728235576f0c42cd968bde792d6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10356);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16223);
      ((RadControl) this.c38925728235576f0c42cd968bde792d6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c38925728235576f0c42cd968bde792d6).Click += new EventHandler(this.cf7db0bc1157d74354f9f6496a296c24f);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10360), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10364));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13819);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10368), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10372));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10376);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16342);
      ((RadControl) this.cba34b2a0111f6e5bc303375f968bc295).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Click += new EventHandler(this.c68466370159591d103d317ff138cc2d1);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10380);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10384), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10388));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16429);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10392), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10396));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10400);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16452);
      ((RadControl) this.c51175a4a3b6b11c0eee765ad7effd076).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Click += new EventHandler(this.c73a91aa5e28f9899f28a0eb26c625fd5);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10404), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10408));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10412));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10416), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10420));
      ((Control) this).Controls.Add((Control) this.c315ebf3de36e7a50ea2c550cda4eaba1);
      ((Control) this).Controls.Add((Control) this.c51175a4a3b6b11c0eee765ad7effd076);
      ((Control) this).Controls.Add((Control) this.ca75cf6b554bca20b242f951643c4d424);
      ((Control) this).Controls.Add((Control) this.c0b6ff62997904dd44189c4cb17f2ab15);
      ((Control) this).Controls.Add((Control) this.cee9946355c6a614ff90b875d32801e38);
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10424), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10428));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16473);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10432));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10436) != 0);
      ((RadElement) ((RadFormControlBase) this).get_RootElement()).set_MaxSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10440), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10444)));
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10448);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16492);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Form) this).Load += new EventHandler(this.c6f9e28dce46d00214020200ce5c6bfbe);
      ((ISupportInitialize) this.c315ebf3de36e7a50ea2c550cda4eaba1).EndInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).EndInit();
      ((ISupportInitialize) this.ca75cf6b554bca20b242f951643c4d424).EndInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).EndInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10452) != 0);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).PerformLayout();
      ((ISupportInitialize) this.c0b8c323aae75c040334498c5efcb96f4).EndInit();
      ((ISupportInitialize) this.c9e453c2e79f4fc55124ccb1fd3603902).EndInit();
      ((ISupportInitialize) this.c38925728235576f0c42cd968bde792d6).EndInit();
      ((ISupportInitialize) this.cba34b2a0111f6e5bc303375f968bc295).EndInit();
      ((ISupportInitialize) this.c51175a4a3b6b11c0eee765ad7effd076).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10456) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
