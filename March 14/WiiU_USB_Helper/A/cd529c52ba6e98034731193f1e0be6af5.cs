// Decompiled with JetBrains decompiler
// Type: A.cd529c52ba6e98034731193f1e0be6af5
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class cd529c52ba6e98034731193f1e0be6af5 : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadProgressBar cc32c2a8957385c95d1017b66f5ffe5dc;
    private RadLabel c36dd98eb0c08ea087627a40c6663c9a8;
    private RadLabel ca5a2b6669f9034e5fc384b9781cd6dd6;
    private RadButton c3768da1c9e17b9980d03acca3e5a19a9;
    private RadLabel c5539dab8a40e8d2e2a7b970e134631c8;

    public event EventHandler c0d9efa80e829b2df6f87a574df10245a
    {
      add
      {
        EventHandler eventHandler = this.c0d9efa80e829b2df6f87a574df10245a;
        EventHandler comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.c0d9efa80e829b2df6f87a574df10245a, ccec4ca58265155a131af0c4ef76e5c60.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (1)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cd529c52ba6e98034731193f1e0be6af5.add_c0d9efa80e829b2df6f87a574df10245a);
            break;
        }
      }
      remove
      {
        EventHandler eventHandler = this.c0d9efa80e829b2df6f87a574df10245a;
        EventHandler comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.c0d9efa80e829b2df6f87a574df10245a, ccec4ca58265155a131af0c4ef76e5c60.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Remove((Delegate) comparand, (Delegate) value)), comparand);
        }
        while (eventHandler != comparand);
label_2:
        switch (3)
        {
          case 0:
            goto label_2;
          default:
            if (1 != 0)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cd529c52ba6e98034731193f1e0be6af5.remove_c0d9efa80e829b2df6f87a574df10245a);
            break;
        }
      }
    }

    public cd529c52ba6e98034731193f1e0be6af5(string c36dd98eb0c08ea087627a40c6663c9a8)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Text = c36dd98eb0c08ea087627a40c6663c9a8;
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

    public void cf90b7e3388072aaef91751754e0f9da8(TimeSpan c90049187e289e3799fa866138e5467c5)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      ((Control) this).BeginInvoke((Delegate) new Action(new cd529c52ba6e98034731193f1e0be6af5.c33074352cb8015a348785b8f3b43743e()
      {
        ccb669e105f1c11f33e60c076fc8cca42 = this,
        c90049187e289e3799fa866138e5467c5 = c90049187e289e3799fa866138e5467c5
      }.c1e09f4f5296bc0512546d203857adb44));
    }

    public void c60035c0c530873b09465c1353f865a11(int c60589c08d922b17012df7976242829e0, cbd9d23875bab012857e040a881a1cf4c cd4227f7784d7614c9fb9985ea0ec696e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      ((Control) this).BeginInvoke((Delegate) new Action(new cd529c52ba6e98034731193f1e0be6af5.ccb6850a9f697d0653c3688b47923a787()
      {
        ccb669e105f1c11f33e60c076fc8cca42 = this,
        c60589c08d922b17012df7976242829e0 = c60589c08d922b17012df7976242829e0,
        cd4227f7784d7614c9fb9985ea0ec696e = cd4227f7784d7614c9fb9985ea0ec696e
      }.c0001ccb35596c966af9030b59c5952a6));
    }

    private void cf65f1f5cd5b0e5f46b26ab51b65aa678(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((RadElement) ((RadTitleBarElement) this.get_FormElement().get_TitleBar()).get_CloseButton()).set_Visibility((ElementVisibility) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7820));
    }

    private void cd3ea5f6f49b3d27138c3508cc5d825bb(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler c0d9efa80e829b2df6f87a574df10245a = this.c0d9efa80e829b2df6f87a574df10245a;
      if (c0d9efa80e829b2df6f87a574df10245a == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cd529c52ba6e98034731193f1e0be6af5.cd3ea5f6f49b3d27138c3508cc5d825bb);
            }
            break;
        }
      }
      else
      {
        EventArgs c20c00b8e97bb4c0fb2b7ac6facf98b91 = c3978a42df3e901949e27aa5a5768ff04.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        c0d9efa80e829b2df6f87a574df10245a((object) this, c20c00b8e97bb4c0fb2b7ac6facf98b91);
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cd529c52ba6e98034731193f1e0be6af5.Dispose);
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
      this.cc32c2a8957385c95d1017b66f5ffe5dc = new RadProgressBar();
      this.c36dd98eb0c08ea087627a40c6663c9a8 = new RadLabel();
      this.ca5a2b6669f9034e5fc384b9781cd6dd6 = new RadLabel();
      this.c3768da1c9e17b9980d03acca3e5a19a9 = new RadButton();
      this.c5539dab8a40e8d2e2a7b970e134631c8 = new RadLabel();
      ((ISupportInitialize) this.cc32c2a8957385c95d1017b66f5ffe5dc).BeginInit();
      ((ISupportInitialize) this.c36dd98eb0c08ea087627a40c6663c9a8).BeginInit();
      ((ISupportInitialize) this.ca5a2b6669f9034e5fc384b9781cd6dd6).BeginInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).BeginInit();
      ((ISupportInitialize) this.c5539dab8a40e8d2e2a7b970e134631c8).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.cc32c2a8957385c95d1017b66f5ffe5dc).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7824), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7828));
      ((Control) this.cc32c2a8957385c95d1017b66f5ffe5dc).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7362);
      this.cc32c2a8957385c95d1017b66f5ffe5dc.set_ShowProgressIndicators(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7832) != 0);
      ((Control) this.cc32c2a8957385c95d1017b66f5ffe5dc).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7836), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7840));
      ((Control) this.cc32c2a8957385c95d1017b66f5ffe5dc).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7844);
      ((Control) this.cc32c2a8957385c95d1017b66f5ffe5dc).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7393);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7848) != 0;
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7852);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(7856), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7860), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7864), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7868));
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7872), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7876));
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7417);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7880), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7884));
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7888);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      this.c36dd98eb0c08ea087627a40c6663c9a8.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7892));
      this.c36dd98eb0c08ea087627a40c6663c9a8.set_UseMnemonic(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7896) != 0);
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7900), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7904));
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7447);
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7908), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7912));
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7916);
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7464);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7920), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7924));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7473);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7928), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7932));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7936);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7494);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Click += new EventHandler(this.cd3ea5f6f49b3d27138c3508cc5d825bb);
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7940), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7944));
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7505);
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7948), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7952));
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7956);
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7518);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(7960), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(7964));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7968));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7972), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7976));
      ((Control) this).Controls.Add((Control) this.c5539dab8a40e8d2e2a7b970e134631c8);
      ((Control) this).Controls.Add((Control) this.c3768da1c9e17b9980d03acca3e5a19a9);
      ((Control) this).Controls.Add((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6);
      ((Control) this).Controls.Add((Control) this.c36dd98eb0c08ea087627a40c6663c9a8);
      ((Control) this).Controls.Add((Control) this.cc32c2a8957385c95d1017b66f5ffe5dc);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7980));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7525);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7984) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7988) != 0);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7554);
      ((Form) this).Load += new EventHandler(this.cf65f1f5cd5b0e5f46b26ab51b65aa678);
      ((ISupportInitialize) this.cc32c2a8957385c95d1017b66f5ffe5dc).EndInit();
      ((ISupportInitialize) this.c36dd98eb0c08ea087627a40c6663c9a8).EndInit();
      ((ISupportInitialize) this.ca5a2b6669f9034e5fc384b9781cd6dd6).EndInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).EndInit();
      ((ISupportInitialize) this.c5539dab8a40e8d2e2a7b970e134631c8).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7992) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
