// Decompiled with JetBrains decompiler
// Type: A.cbb595cd1ce73bd1b906cfc6ca8385bb8
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
  public class cbb595cd1ce73bd1b906cfc6ca8385bb8 : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private WebBrowser ca22f98a4e98b135e7144807dfaea4c5f;

    public cbb595cd1ce73bd1b906cfc6ca8385bb8()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    private void c71dd6a4fa00fefbdc1d18831cbbc7db3(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cbb595cd1ce73bd1b906cfc6ca8385bb8.Dispose);
            }
            if (this.ce2dde71ac55aad4a9ce23a50ce61cd89 != null)
            {
label_5:
              switch (2)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c913eb3dccbb6a5c1c3983fbc02a0ba42.c6804baa30a51e813a45fabcfa2b27b79()));
      this.ca22f98a4e98b135e7144807dfaea4c5f = new WebBrowser();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      this.ca22f98a4e98b135e7144807dfaea4c5f.Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8024);
      this.ca22f98a4e98b135e7144807dfaea4c5f.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8028), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8032));
      this.ca22f98a4e98b135e7144807dfaea4c5f.MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8036), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8040));
      this.ca22f98a4e98b135e7144807dfaea4c5f.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9420);
      this.ca22f98a4e98b135e7144807dfaea4c5f.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8044), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8048));
      this.ca22f98a4e98b135e7144807dfaea4c5f.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8052);
      this.ca22f98a4e98b135e7144807dfaea4c5f.Url = new Uri(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9443), (UriKind) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8056));
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8060), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8064));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8068));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8072), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8076));
      ((Control) this).Controls.Add((Control) this.ca22f98a4e98b135e7144807dfaea4c5f);
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9500);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8080) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8084);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9513);
      ((Form) this).Load += new EventHandler(this.c71dd6a4fa00fefbdc1d18831cbbc7db3);
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8088) != 0);
    }
  }
}
