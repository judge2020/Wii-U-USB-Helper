// Decompiled with JetBrains decompiler
// Type: A.c7790279ae51d5c2ddf66e645bbeeef44
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace A
{
  public class c7790279ae51d5c2ddf66e645bbeeef44 : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private PictureBox c5c88963d6e9c4dae998f5bdc712deec4;
    private RadLabel ce940872bf2d542451e120044788d9340;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadButton c28cccb4bc1305f639acf2d457aeedad8;
    private RadButton cae781a73bef396115e799be2de31a889;
    private RadButton cded3584b859653b46e45a2c4d1355b61;

    public c7790279ae51d5c2ddf66e645bbeeef44()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    private void ce2ea68eb9c0d4049a372275378d48be5(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      Process.Start(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10926));
    }

    private void c06317803f48c1236bc5ea52bf9957d11(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      string text = Clipboard.GetText();
      c1b0822c22b951c8a567b56dd01e313bf.ca8d3f090040777e16dd5611bef37f89e(text, c27603360ccc8374975348defb9eee9fc.keysPub);
      if (c1b0822c22b951c8a567b56dd01e313bf.c727abdef873c71ae15e67e1b27e2ad96)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c7790279ae51d5c2ddf66e645bbeeef44.c06317803f48c1236bc5ea52bf9957d11);
            }
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11027));
            Settings.Default.DonationKey = text;
            Settings.Default.Save();
            ((Form) this).Close();
            break;
        }
      }
      else
      {
        int num1 = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11090));
      }
    }

    private void c8f58c48bbf5302abec3fc5b0e7bdeea3(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Form) this).Close();
    }

    private void cb7c994047ade504e7c0c6943a293e190(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((RadElement) ((RadTitleBarElement) this.get_FormElement().get_TitleBar()).get_CloseButton()).set_Visibility((ElementVisibility) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8548));
      Timer timer = new Timer();
      timer.Interval = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8552);
      EventHandler eventHandler = (EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) => ((Control) this.cded3584b859653b46e45a2c4d1355b61).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8760) != 0);
      timer.Tick += eventHandler;
      timer.Start();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c7790279ae51d5c2ddf66e645bbeeef44.Dispose);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cc6cbceca58ac4c7d5b081bb13e46a2b0.c6804baa30a51e813a45fabcfa2b27b79()));
      this.c5c88963d6e9c4dae998f5bdc712deec4 = new PictureBox();
      this.ce940872bf2d542451e120044788d9340 = new RadLabel();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.c28cccb4bc1305f639acf2d457aeedad8 = new RadButton();
      this.cae781a73bef396115e799be2de31a889 = new RadButton();
      this.cded3584b859653b46e45a2c4d1355b61 = new RadButton();
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).BeginInit();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).BeginInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.c28cccb4bc1305f639acf2d457aeedad8).BeginInit();
      ((ISupportInitialize) this.cae781a73bef396115e799be2de31a889).BeginInit();
      ((ISupportInitialize) this.cded3584b859653b46e45a2c4d1355b61).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      this.c5c88963d6e9c4dae998f5bdc712deec4.Image = (Image) c27603360ccc8374975348defb9eee9fc.logo;
      this.c5c88963d6e9c4dae998f5bdc712deec4.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8556), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8560));
      this.c5c88963d6e9c4dae998f5bdc712deec4.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11217);
      this.c5c88963d6e9c4dae998f5bdc712deec4.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8564), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8568));
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8572);
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8576) != 0;
      ((Control) this.ce940872bf2d542451e120044788d9340).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8580), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8584), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8588), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8592));
      ((Control) this.ce940872bf2d542451e120044788d9340).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8596), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8600));
      ((Control) this.ce940872bf2d542451e120044788d9340).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10090);
      ((Control) this.ce940872bf2d542451e120044788d9340).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8604), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8608));
      ((Control) this.ce940872bf2d542451e120044788d9340).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8612);
      ((Control) this.ce940872bf2d542451e120044788d9340).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11240);
      ((RadControl) this.ce940872bf2d542451e120044788d9340).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8616), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8620), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8624), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8628));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8632), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8636));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8640), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8644));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8648);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = componentResourceManager.GetString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11317));
      this.cd036f2b2868b103e71bd7b4fbe25a603.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8652));
      ((RadControl) this.cd036f2b2868b103e71bd7b4fbe25a603).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8656), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8660));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11346);
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8664), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8668));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8672);
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11365);
      ((RadControl) this.c28cccb4bc1305f639acf2d457aeedad8).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Click += new EventHandler(this.ce2ea68eb9c0d4049a372275378d48be5);
      ((Control) this.cae781a73bef396115e799be2de31a889).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8676), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8680));
      ((Control) this.cae781a73bef396115e799be2de31a889).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11396);
      ((Control) this.cae781a73bef396115e799be2de31a889).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8684), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8688));
      ((Control) this.cae781a73bef396115e799be2de31a889).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8692);
      ((Control) this.cae781a73bef396115e799be2de31a889).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11423);
      ((RadControl) this.cae781a73bef396115e799be2de31a889).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cae781a73bef396115e799be2de31a889).Click += new EventHandler(this.c06317803f48c1236bc5ea52bf9957d11);
      ((Control) this.cded3584b859653b46e45a2c4d1355b61).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8696) != 0;
      ((Control) this.cded3584b859653b46e45a2c4d1355b61).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8700), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8704));
      ((Control) this.cded3584b859653b46e45a2c4d1355b61).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11466);
      ((Control) this.cded3584b859653b46e45a2c4d1355b61).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8708), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8712));
      ((Control) this.cded3584b859653b46e45a2c4d1355b61).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8716);
      ((Control) this.cded3584b859653b46e45a2c4d1355b61).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11483);
      ((RadControl) this.cded3584b859653b46e45a2c4d1355b61).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cded3584b859653b46e45a2c4d1355b61).Click += new EventHandler(this.c8f58c48bbf5302abec3fc5b0e7bdeea3);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8720), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(8724));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8728));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8732), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8736));
      ((Control) this).Controls.Add((Control) this.cded3584b859653b46e45a2c4d1355b61);
      ((Control) this).Controls.Add((Control) this.cae781a73bef396115e799be2de31a889);
      ((Control) this).Controls.Add((Control) this.c28cccb4bc1305f639acf2d457aeedad8);
      ((Control) this).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((Control) this).Controls.Add((Control) this.ce940872bf2d542451e120044788d9340);
      ((Control) this).Controls.Add((Control) this.c5c88963d6e9c4dae998f5bdc712deec4);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8740));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11508);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8744) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8748) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8752);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11531);
      ((Form) this).Load += new EventHandler(this.cb7c994047ade504e7c0c6943a293e190);
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).EndInit();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).EndInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.c28cccb4bc1305f639acf2d457aeedad8).EndInit();
      ((ISupportInitialize) this.cae781a73bef396115e799be2de31a889).EndInit();
      ((ISupportInitialize) this.cded3584b859653b46e45a2c4d1355b61).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8756) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
