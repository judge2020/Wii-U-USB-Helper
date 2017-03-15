// Decompiled with JetBrains decompiler
// Type: A.ce14b607699e6a65abad7d2ea38b8725a
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class ce14b607699e6a65abad7d2ea38b8725a : RadForm
  {
    public DriveInfo c4d595b6fd113bbabb11c077e4814d125;
    private DataSize c455e86272ab65224a448d277db9ec29e;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadListView c8ef199d7e39da482aae82a10f7717dee;
    private RadLabel ce940872bf2d542451e120044788d9340;

    public ce14b607699e6a65abad7d2ea38b8725a(DataSize c018ed819fab46c246401a24bfca0a2de)
    {
      this.\u002Ector();
      this.c455e86272ab65224a448d277db9ec29e = c018ed819fab46c246401a24bfca0a2de;
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    public static IEnumerable<DriveInfo> c15f47840c5561dfb457102bb66cb92f5()
    {
      DriveInfo[] drives = DriveInfo.GetDrives();
      // ISSUE: reference to a compiler-generated field
      Func<DriveInfo, bool> predicate = ce14b607699e6a65abad7d2ea38b8725a.\u003C\u003Ec.c6f21967be2e2bf8983a0ab8f6f02fc46;
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ce14b607699e6a65abad7d2ea38b8725a.c15f47840c5561dfb457102bb66cb92f5);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            predicate = ce14b607699e6a65abad7d2ea38b8725a.\u003C\u003Ec.c6f21967be2e2bf8983a0ab8f6f02fc46 = new Func<DriveInfo, bool>(ce14b607699e6a65abad7d2ea38b8725a.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cc6109fad0ff716b68c6e5a51b0403961);
            break;
        }
      }
      return (IEnumerable<DriveInfo>) new List<DriveInfo>(((IEnumerable<DriveInfo>) drives).Where<DriveInfo>(predicate));
    }

    private void c902bb62a3664a9925a96fdddf5f5588b(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      IEnumerator<DriveInfo> enumerator = ce14b607699e6a65abad7d2ea38b8725a.c15f47840c5561dfb457102bb66cb92f5().GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          DriveInfo current = enumerator.Current;
          if (current.IsReady)
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
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (ce14b607699e6a65abad7d2ea38b8725a.c902bb62a3664a9925a96fdddf5f5588b);
                }
                this.c8ef199d7e39da482aae82a10f7717dee.BeginEdit();
                ListViewDataItem listViewDataItem = new ListViewDataItem(current.Name);
                Bitmap icnDisk = c27603360ccc8374975348defb9eee9fc.icnDisk;
                listViewDataItem.set_Image((Image) icnDisk);
                DriveInfo driveInfo = current;
                listViewDataItem.set_Tag((object) driveInfo);
                int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11288);
                listViewDataItem.set_ImageAlignment((ContentAlignment) num1);
                int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11292);
                listViewDataItem.set_TextAlignment((ContentAlignment) num2);
                int num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11296);
                listViewDataItem.set_TextImageRelation((TextImageRelation) num3);
                this.c8ef199d7e39da482aae82a10f7717dee.get_Items().Add(listViewDataItem);
                this.c8ef199d7e39da482aae82a10f7717dee.EndEdit();
                continue;
            }
          }
        }
label_8:
        switch (3)
        {
          case 0:
            goto label_8;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_11:
          switch (5)
          {
            case 0:
              goto label_11;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
    }

    private void c8949ab17747248c16b15595d6e0503a4(object c5382ad5461e274fda51b358802fc3910, ListViewItemEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      DriveInfo driveInfo = cfb3c6254fa85999608c2342171d3bfc3.cc8e287d5350b43026d33bb80beb131a0(c9572d7ff9cd6a116e4a6f248ca68a831.get_Item().get_Tag());
      if ((ulong) driveInfo.TotalSize < this.c455e86272ab65224a448d277db9ec29e.TotalBytes)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ce14b607699e6a65abad7d2ea38b8725a.c8949ab17747248c16b15595d6e0503a4);
            }
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17484));
            break;
        }
      }
      else if ((ulong) driveInfo.AvailableFreeSpace < this.c455e86272ab65224a448d277db9ec29e.TotalBytes)
      {
label_6:
        switch (1)
        {
          case 0:
            goto label_6;
          default:
            int num = (int) RadMessageBox.Show(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17614), (object) new DataSize(this.c455e86272ab65224a448d277db9ec29e.TotalBytes - (ulong) driveInfo.AvailableFreeSpace)));
            if (RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17818), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17941), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11300)) != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11304))
              break;
label_8:
            switch (1)
            {
              case 0:
                goto label_8;
              default:
                Process.Start(driveInfo.Name);
                return;
            }
        }
      }
      else
      {
        this.c4d595b6fd113bbabb11c077e4814d125 = driveInfo;
        ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11308);
        ((Form) this).Close();
      }
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ce14b607699e6a65abad7d2ea38b8725a.Dispose);
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
      this.c8ef199d7e39da482aae82a10f7717dee = new RadListView();
      this.ce940872bf2d542451e120044788d9340 = new RadLabel();
      ((ISupportInitialize) this.c8ef199d7e39da482aae82a10f7717dee).BeginInit();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      this.c8ef199d7e39da482aae82a10f7717dee.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11312) != 0);
      this.c8ef199d7e39da482aae82a10f7717dee.set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11316) != 0);
      ((Control) this.c8ef199d7e39da482aae82a10f7717dee).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11320);
      this.c8ef199d7e39da482aae82a10f7717dee.set_FullRowSelect(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11324) != 0);
      this.c8ef199d7e39da482aae82a10f7717dee.set_ItemSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11328), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11332)));
      ((Control) this.c8ef199d7e39da482aae82a10f7717dee).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11336), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11340));
      ((Control) this.c8ef199d7e39da482aae82a10f7717dee).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17970);
      ((Control) this.c8ef199d7e39da482aae82a10f7717dee).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11344), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11348));
      ((Control) this.c8ef199d7e39da482aae82a10f7717dee).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11352);
      ((Control) this.c8ef199d7e39da482aae82a10f7717dee).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      ((RadControl) this.c8ef199d7e39da482aae82a10f7717dee).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c8ef199d7e39da482aae82a10f7717dee.set_ViewType((ListViewType) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11356));
      // ISSUE: method pointer
      this.c8ef199d7e39da482aae82a10f7717dee.add_ItemMouseDoubleClick(new ListViewItemEventHandler((object) this, __methodptr(c8949ab17747248c16b15595d6e0503a4)));
      ((Control) this.ce940872bf2d542451e120044788d9340).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11360);
      ((Control) this.ce940872bf2d542451e120044788d9340).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11364), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11368));
      ((Control) this.ce940872bf2d542451e120044788d9340).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10090);
      ((Control) this.ce940872bf2d542451e120044788d9340).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11372), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11376));
      ((Control) this.ce940872bf2d542451e120044788d9340).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11380);
      ((Control) this.ce940872bf2d542451e120044788d9340).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(17989);
      ((RadControl) this.ce940872bf2d542451e120044788d9340).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11384), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11388));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11392));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11396), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11400));
      ((Control) this).Controls.Add((Control) this.c8ef199d7e39da482aae82a10f7717dee);
      ((Control) this).Controls.Add((Control) this.ce940872bf2d542451e120044788d9340);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11404));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18082);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11408));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11412) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11416) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11420);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18111);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Form) this).Load += new EventHandler(this.c902bb62a3664a9925a96fdddf5f5588b);
      ((ISupportInitialize) this.c8ef199d7e39da482aae82a10f7717dee).EndInit();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11424) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
