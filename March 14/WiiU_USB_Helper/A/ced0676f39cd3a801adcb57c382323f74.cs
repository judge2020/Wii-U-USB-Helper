// Decompiled with JetBrains decompiler
// Type: A.ced0676f39cd3a801adcb57c382323f74
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Nus_Helper_Shared_Core.NusHelper.Saves;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class ced0676f39cd3a801adcb57c382323f74 : RadForm
  {
    public SaveDescription cff7d080c674720b9970ada1d15664bae;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadCheckedListBox cb3c967a4e6cf495568653a52ceb14328;
    private RadButton c0176f1387d535312426e54c226ddcc7c;
    private RadButton c3768da1c9e17b9980d03acca3e5a19a9;

    public ced0676f39cd3a801adcb57c382323f74(cce1cf1e0b6971ed6f7ef86a83b0959b6 c3cab5319dc016deb050deb101e927b2f)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      using (List<SaveDescription>.Enumerator enumerator = c3cab5319dc016deb050deb101e927b2f.cc92e9063ce7b3dea6513edf1666bf319().GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          SaveDescription current = enumerator.Current;
          ListViewDataItem listViewDataItem1 = new ListViewDataItem();
          SaveDescription saveDescription = current;
          listViewDataItem1.set_Tag((object) saveDescription);
          ListViewDataItem listViewDataItem2 = listViewDataItem1;
          ((RadListView) this.cb3c967a4e6cf495568653a52ceb14328).get_Items().Add(listViewDataItem2);
          listViewDataItem2.set_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8276), (object) ced0676f39cd3a801adcb57c382323f74.c6355ec3c0017ba7731a7218c91f2705a(double.Parse(current.Timestamp)).ToShortDateString());
          listViewDataItem2.set_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8280), (object) current.Description);
        }
label_4:
        switch (1)
        {
          case 0:
            goto label_4;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ced0676f39cd3a801adcb57c382323f74.\u002Ector);
            break;
        }
      }
    }

    public static DateTime c6355ec3c0017ba7731a7218c91f2705a(double c06c1717d18accb1edbd6c548afb5a181)
    {
      return new DateTime(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8092), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8096), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8100), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8104), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8108), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8112), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8116), (DateTimeKind) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8120)).AddSeconds(c06c1717d18accb1edbd6c548afb5a181).ToLocalTime();
    }

    private void ceb162dd7db5d84f34ee6527e5849eccc(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c0b0ec230efcb9fd3edd68575d78901a4(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (((ReadOnlyCollection<ListViewDataItem>) ((RadListView) this.cb3c967a4e6cf495568653a52ceb14328).get_CheckedItems()).Count != 0)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ced0676f39cd3a801adcb57c382323f74.c0b0ec230efcb9fd3edd68575d78901a4);
            }
            if (((ReadOnlyCollection<ListViewDataItem>) ((RadListView) this.cb3c967a4e6cf495568653a52ceb14328).get_CheckedItems()).Count > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8124))
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              this.cff7d080c674720b9970ada1d15664bae = c0e09ff753a299877908593d4ff3896d5.cc50e3aad2c922bb7d7e65938629ab7b5(((ReadOnlyCollection<ListViewDataItem>) ((RadListView) this.cb3c967a4e6cf495568653a52ceb14328).get_CheckedItems())[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8128)].get_Tag());
              ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8132);
              ((Form) this).Close();
              return;
            }
        }
      }
      int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9536));
    }

    private void cd3ea5f6f49b3d27138c3508cc5d825bb(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8136);
      ((Form) this).Close();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ced0676f39cd3a801adcb57c382323f74.Dispose);
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
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9583), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9600));
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9609), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9626));
      this.cb3c967a4e6cf495568653a52ceb14328 = new RadCheckedListBox();
      this.c0176f1387d535312426e54c226ddcc7c = new RadButton();
      this.c3768da1c9e17b9980d03acca3e5a19a9 = new RadButton();
      ((ISupportInitialize) this.cb3c967a4e6cf495568653a52ceb14328).BeginInit();
      ((ISupportInitialize) this.c0176f1387d535312426e54c226ddcc7c).BeginInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      viewDetailColumn1.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9600));
      viewDetailColumn2.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9626));
      viewDetailColumn2.set_Width(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8140));
      ListViewColumnCollection columns = ((RadListView) this.cb3c967a4e6cf495568653a52ceb14328).get_Columns();
      ListViewDetailColumn[] viewDetailColumnArray = ccfba36ada6e0fbc3be319dd8ce6669d8.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8144));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8148);
      ListViewDetailColumn viewDetailColumn3 = viewDetailColumn1;
      viewDetailColumnArray[index1] = viewDetailColumn3;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8152);
      ListViewDetailColumn viewDetailColumn4 = viewDetailColumn2;
      viewDetailColumnArray[index2] = viewDetailColumn4;
      columns.AddRange(viewDetailColumnArray);
      ((Control) this.cb3c967a4e6cf495568653a52ceb14328).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8156);
      ((RadListView) this.cb3c967a4e6cf495568653a52ceb14328).set_ItemSpacing(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8160));
      ((Control) this.cb3c967a4e6cf495568653a52ceb14328).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8164), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8168));
      ((Control) this.cb3c967a4e6cf495568653a52ceb14328).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9649);
      ((Control) this.cb3c967a4e6cf495568653a52ceb14328).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8172), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8176));
      ((Control) this.cb3c967a4e6cf495568653a52ceb14328).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8180);
      ((Control) this.cb3c967a4e6cf495568653a52ceb14328).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9666);
      ((RadListView) this.cb3c967a4e6cf495568653a52ceb14328).set_ViewType((ListViewType) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8184));
      ((Control) this.c0176f1387d535312426e54c226ddcc7c).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8188);
      ((Control) this.c0176f1387d535312426e54c226ddcc7c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8192), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8196));
      ((Control) this.c0176f1387d535312426e54c226ddcc7c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9703);
      ((Control) this.c0176f1387d535312426e54c226ddcc7c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8200), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8204));
      ((Control) this.c0176f1387d535312426e54c226ddcc7c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8208);
      ((Control) this.c0176f1387d535312426e54c226ddcc7c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9722);
      ((Control) this.c0176f1387d535312426e54c226ddcc7c).Click += new EventHandler(this.c0b0ec230efcb9fd3edd68575d78901a4);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8212);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8216), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8220));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7473);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8224), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8228));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8232);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9737);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Click += new EventHandler(this.cd3ea5f6f49b3d27138c3508cc5d825bb);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8236), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8240));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8244));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8248), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8252));
      ((Control) this).Controls.Add((Control) this.cb3c967a4e6cf495568653a52ceb14328);
      ((Control) this).Controls.Add((Control) this.c0176f1387d535312426e54c226ddcc7c);
      ((Control) this).Controls.Add((Control) this.c3768da1c9e17b9980d03acca3e5a19a9);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8256));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9750);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8260) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8264) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8268);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9775);
      ((Form) this).Load += new EventHandler(this.ceb162dd7db5d84f34ee6527e5849eccc);
      ((ISupportInitialize) this.cb3c967a4e6cf495568653a52ceb14328).EndInit();
      ((ISupportInitialize) this.c0176f1387d535312426e54c226ddcc7c).EndInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8272) != 0);
    }
  }
}
