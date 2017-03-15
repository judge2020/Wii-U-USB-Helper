// Decompiled with JetBrains decompiler
// Type: A.cdbc99a48928ffee3d676afdba59fd654
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
  public class cdbc99a48928ffee3d676afdba59fd654 : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private WebBrowser ca22f98a4e98b135e7144807dfaea4c5f;

    public cdbc99a48928ffee3d676afdba59fd654()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    private void cf69d576a20a7aba45b420deed6e19350(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.ca22f98a4e98b135e7144807dfaea4c5f.DocumentTitleChanged += (EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) => ((Control) this).Text = this.ca22f98a4e98b135e7144807dfaea4c5f.DocumentTitle);
    }

    private void c2c11fa995d252ef9d0932869da64d9c0(object c5382ad5461e274fda51b358802fc3910, WebBrowserNavigatingEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      c9572d7ff9cd6a116e4a6f248ca68a831.Cancel = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8764) != 0;
      Process.Start(c9572d7ff9cd6a116e4a6f248ca68a831.Url.ToString());
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cdbc99a48928ffee3d676afdba59fd654.Dispose);
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
      this.ca22f98a4e98b135e7144807dfaea4c5f = new WebBrowser();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      this.ca22f98a4e98b135e7144807dfaea4c5f.Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8768);
      this.ca22f98a4e98b135e7144807dfaea4c5f.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8772), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8776));
      this.ca22f98a4e98b135e7144807dfaea4c5f.MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8780), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8784));
      this.ca22f98a4e98b135e7144807dfaea4c5f.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9420);
      this.ca22f98a4e98b135e7144807dfaea4c5f.ScriptErrorsSuppressed = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8788) != 0;
      this.ca22f98a4e98b135e7144807dfaea4c5f.ScrollBarsEnabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8792) != 0;
      this.ca22f98a4e98b135e7144807dfaea4c5f.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8796), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8800));
      this.ca22f98a4e98b135e7144807dfaea4c5f.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8804);
      this.ca22f98a4e98b135e7144807dfaea4c5f.Url = new Uri(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11548), (UriKind) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8808));
      this.ca22f98a4e98b135e7144807dfaea4c5f.Navigating += new WebBrowserNavigatingEventHandler(this.c2c11fa995d252ef9d0932869da64d9c0);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8812), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8816));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8820));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8824), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8828));
      ((Control) this).Controls.Add((Control) this.ca22f98a4e98b135e7144807dfaea4c5f);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8832));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11607);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8836) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8840) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8844);
      ((Control) this).Text = "";
      ((Form) this).Load += new EventHandler(this.cf69d576a20a7aba45b420deed6e19350);
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8848) != 0);
    }
  }
}
