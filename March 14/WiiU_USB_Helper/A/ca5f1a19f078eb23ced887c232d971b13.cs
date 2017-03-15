// Decompiled with JetBrains decompiler
// Type: A.ca5f1a19f078eb23ced887c232d971b13
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class ca5f1a19f078eb23ced887c232d971b13 : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadLabel ccfb56050e85e2ede0742937922e5842b;
    private PictureBox c5c88963d6e9c4dae998f5bdc712deec4;

    public ca5f1a19f078eb23ced887c232d971b13(string c74359205abcb0d3c69ba3393bd045531)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).Text = c74359205abcb0d3c69ba3393bd045531;
    }

    public void ce064f93ebcf9a6f22e14fc4dbf62aa2c()
    {
      try
      {
        ((Control) this).BeginInvoke((Delegate) new Action(((Form) this).Close));
      }
      catch
      {
      }
    }

    private void cf216b9bed6ae555ba43c3aceabc0d37d(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((RadElement) ((RadTitleBarElement) this.get_FormElement().get_TitleBar()).get_CloseButton()).set_Visibility((ElementVisibility) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11616));
    }

    private void c3f1cb1d14e732cf716cf348b12079a56(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).Location = new Point(((Control) this).Width / cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11620) - ((Control) this.ccfb56050e85e2ede0742937922e5842b).Width / cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11624), ((Control) this.ccfb56050e85e2ede0742937922e5842b).Location.Y);
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ca5f1a19f078eb23ced887c232d971b13.Dispose);
            }
            if (this.ce2dde71ac55aad4a9ce23a50ce61cd89 != null)
            {
label_5:
              switch (6)
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
      this.ccfb56050e85e2ede0742937922e5842b = new RadLabel();
      this.c5c88963d6e9c4dae998f5bdc712deec4 = new PictureBox();
      ((ISupportInitialize) this.ccfb56050e85e2ede0742937922e5842b).BeginInit();
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11628), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11632));
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18557);
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11636), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11640));
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11644);
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18557);
      ((Control) this.ccfb56050e85e2ede0742937922e5842b).SizeChanged += new EventHandler(this.c3f1cb1d14e732cf716cf348b12079a56);
      this.c5c88963d6e9c4dae998f5bdc712deec4.Image = (Image) c27603360ccc8374975348defb9eee9fc.squares;
      this.c5c88963d6e9c4dae998f5bdc712deec4.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11648), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11652));
      this.c5c88963d6e9c4dae998f5bdc712deec4.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11217);
      this.c5c88963d6e9c4dae998f5bdc712deec4.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11656), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11660));
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11664);
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11668) != 0;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11672), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11676));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11680));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11684), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11688));
      ((Control) this).Controls.Add((Control) this.c5c88963d6e9c4dae998f5bdc712deec4);
      ((Control) this).Controls.Add((Control) this.ccfb56050e85e2ede0742937922e5842b);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11692));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18578);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11696) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11700) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11704);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18593);
      ((Form) this).Load += new EventHandler(this.cf216b9bed6ae555ba43c3aceabc0d37d);
      ((ISupportInitialize) this.ccfb56050e85e2ede0742937922e5842b).EndInit();
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11708) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
