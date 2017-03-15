// Decompiled with JetBrains decompiler
// Type: A.cfd95a277f4e8e0f3410cd92c0ae4f453
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class cfd95a277f4e8e0f3410cd92c0ae4f453 : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadLabel ce940872bf2d542451e120044788d9340;
    private RadButton c343fc3a72c2772b2c17357af34357ce7;
    private RadGroupBox cd21917de552da0d5fa4c6079cd71111f;
    private RadTextBox c0770534b75ebeea0c4e695dfdb7677d0;
    private RadLabel cee9946355c6a614ff90b875d32801e38;
    private RadButton c6b7d903aa965d47e2f39fa93f9aa3134;
    private RadTextBox cb276241d1e50eb308cf7227c14ad5562;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadPageView c241ce5265d52b769010f0f4dec3536aa;
    private RadPageViewPage c74bbb9a2042fa4be9844ab1f8b42123a;
    private RadPageViewPage c912ac08a9e3c8cff62b674fc43aac10c;
    private RadGroupBox c8827d4c0d7431a9890c547ec78a2c02c;
    private RadLabel c38925728235576f0c42cd968bde792d6;
    private PictureBox c5c88963d6e9c4dae998f5bdc712deec4;
    private RadButton c3768da1c9e17b9980d03acca3e5a19a9;
    private RadLabel c0bc74edb9773f357b639b398786841b3;
    private RadGroupBox c0b6ff62997904dd44189c4cb17f2ab15;
    private RadLabel ced6aa7f9911c4707f69ec112a4e51672;
    private RadTextBox cdf4f936649fd7e5caeee05e0dab9c79e;
    private RadLabel c8af15fc87ff7fad3b7d70b37794c0516;
    private RadLabel c9e453c2e79f4fc55124ccb1fd3603902;
    private RadLabel c0b8c323aae75c040334498c5efcb96f4;
    private RadLabel cba34b2a0111f6e5bc303375f968bc295;

    public string FileLocation3DS { get; set; }

    public string FileLocationWiiU { get; set; }

    public cfd95a277f4e8e0f3410cd92c0ae4f453()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    private void c5acf3c4f284b5afb9980bb8347ebc8f3(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text = ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text.Trim();
      if (((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text.Contains(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12487)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cfd95a277f4e8e0f3410cd92c0ae4f453.c5acf3c4f284b5afb9980bb8347ebc8f3);
            }
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12524));
            ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text = "";
            break;
        }
      }
      else
      {
        WebClient webClient = new WebClient();
        try
        {
          webClient.DownloadData(((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text);
          this.FileLocationWiiU = ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Text;
          ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9124);
          ((Form) this).Close();
        }
        catch
        {
          int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12668));
        }
      }
    }

    private void c61399fae139b88bc52e6803c31a207ed(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void cd3ea5f6f49b3d27138c3508cc5d825bb(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9128);
      openFileDialog1.CheckFileExists = num1 != 0;
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9132);
      openFileDialog1.Multiselect = num2 != 0;
      string str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12771);
      openFileDialog1.Filter = str;
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9136))
        return;
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cfd95a277f4e8e0f3410cd92c0ae4f453.cd3ea5f6f49b3d27138c3508cc5d825bb);
          }
          ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9140);
          this.FileLocationWiiU = openFileDialog2.FileName;
          ((Form) this).Close();
          break;
      }
    }

    private void c0a6ea2a725f4eff55eb6f116b2de4d29(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Text.Contains(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12487)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cfd95a277f4e8e0f3410cd92c0ae4f453.c0a6ea2a725f4eff55eb6f116b2de4d29);
            }
            this.FileLocationWiiU = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12822);
            break;
        }
      }
      if (((Control) this.cb276241d1e50eb308cf7227c14ad5562).Text.Contains(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12877)))
      {
label_6:
        switch (1)
        {
          case 0:
            goto label_6;
          default:
            this.FileLocation3DS = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12912);
            break;
        }
      }
      if (!cdf6c91719eae5a38c64a7fd64afdf5e1.c1df95097ffa57d753c5fe1353cf65e86(this.FileLocation3DS, ""))
      {
label_9:
        switch (3)
        {
          case 0:
            goto label_9;
          default:
            if (!cdf6c91719eae5a38c64a7fd64afdf5e1.c1df95097ffa57d753c5fe1353cf65e86(this.FileLocationWiiU, ""))
              return;
label_11:
            switch (4)
            {
              case 0:
                goto label_11;
            }
        }
      }
      ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9144);
      ((Form) this).Close();
    }

    private void c1fcdbfc04fd168efe84fba3c0e084c1e(object c5382ad5461e274fda51b358802fc3910, DragEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      string[] strArray = c54cc06f28a486fa672661b4612df355a.cc8e287d5350b43026d33bb80beb131a0(c9572d7ff9cd6a116e4a6f248ca68a831.Data.GetData(DataFormats.FileDrop));
      if (System.IO.File.Exists(strArray[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9148)]))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cfd95a277f4e8e0f3410cd92c0ae4f453.c1fcdbfc04fd168efe84fba3c0e084c1e);
            }
            ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9152);
            this.FileLocationWiiU = strArray[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9156)];
            ((Form) this).Close();
            break;
        }
      }
      else
      {
        int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12965));
      }
    }

    private void c1bdb6e9770ae1a2fccca40cdff494718(object c5382ad5461e274fda51b358802fc3910, DragEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      DragEventArgs dragEventArgs = c9572d7ff9cd6a116e4a6f248ca68a831;
      int num;
      if (!c9572d7ff9cd6a116e4a6f248ca68a831.Data.GetDataPresent(DataFormats.FileDrop))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cfd95a277f4e8e0f3410cd92c0ae4f453.c1bdb6e9770ae1a2fccca40cdff494718);
            }
            num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9160);
            break;
        }
      }
      else
        num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9164);
      dragEventArgs.Effect = (DragDropEffects) num;
    }

    private void c8edc0f40b39e3691b789472da5235597(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c9127b5297405b1c5f38e2ec8ff21fcac(object c5382ad5461e274fda51b358802fc3910, PaintEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
    }

    private void c3859ea2dc24cf2d88ba96db2ee219683(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cfd95a277f4e8e0f3410cd92c0ae4f453.Dispose);
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
      this.ce940872bf2d542451e120044788d9340 = new RadLabel();
      this.c343fc3a72c2772b2c17357af34357ce7 = new RadButton();
      this.cd21917de552da0d5fa4c6079cd71111f = new RadGroupBox();
      this.c0770534b75ebeea0c4e695dfdb7677d0 = new RadTextBox();
      this.c9e453c2e79f4fc55124ccb1fd3603902 = new RadLabel();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.cba34b2a0111f6e5bc303375f968bc295 = new RadLabel();
      this.cb276241d1e50eb308cf7227c14ad5562 = new RadTextBox();
      this.c6b7d903aa965d47e2f39fa93f9aa3134 = new RadButton();
      this.cee9946355c6a614ff90b875d32801e38 = new RadLabel();
      this.c241ce5265d52b769010f0f4dec3536aa = new RadPageView();
      this.c74bbb9a2042fa4be9844ab1f8b42123a = new RadPageViewPage();
      this.c912ac08a9e3c8cff62b674fc43aac10c = new RadPageViewPage();
      this.c8827d4c0d7431a9890c547ec78a2c02c = new RadGroupBox();
      this.c0b8c323aae75c040334498c5efcb96f4 = new RadLabel();
      this.c38925728235576f0c42cd968bde792d6 = new RadLabel();
      this.c5c88963d6e9c4dae998f5bdc712deec4 = new PictureBox();
      this.c3768da1c9e17b9980d03acca3e5a19a9 = new RadButton();
      this.c0bc74edb9773f357b639b398786841b3 = new RadLabel();
      this.c0b6ff62997904dd44189c4cb17f2ab15 = new RadGroupBox();
      this.ced6aa7f9911c4707f69ec112a4e51672 = new RadLabel();
      this.cdf4f936649fd7e5caeee05e0dab9c79e = new RadTextBox();
      this.c8af15fc87ff7fad3b7d70b37794c0516 = new RadLabel();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).BeginInit();
      ((ISupportInitialize) this.c343fc3a72c2772b2c17357af34357ce7).BeginInit();
      ((ISupportInitialize) this.cd21917de552da0d5fa4c6079cd71111f).BeginInit();
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).SuspendLayout();
      ((ISupportInitialize) this.c0770534b75ebeea0c4e695dfdb7677d0).BeginInit();
      ((ISupportInitialize) this.c9e453c2e79f4fc55124ccb1fd3603902).BeginInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.cba34b2a0111f6e5bc303375f968bc295).BeginInit();
      ((ISupportInitialize) this.cb276241d1e50eb308cf7227c14ad5562).BeginInit();
      ((ISupportInitialize) this.c6b7d903aa965d47e2f39fa93f9aa3134).BeginInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).BeginInit();
      ((ISupportInitialize) this.c241ce5265d52b769010f0f4dec3536aa).BeginInit();
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).SuspendLayout();
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).SuspendLayout();
      ((Control) this.c912ac08a9e3c8cff62b674fc43aac10c).SuspendLayout();
      ((ISupportInitialize) this.c8827d4c0d7431a9890c547ec78a2c02c).BeginInit();
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).SuspendLayout();
      ((ISupportInitialize) this.c0b8c323aae75c040334498c5efcb96f4).BeginInit();
      ((ISupportInitialize) this.c38925728235576f0c42cd968bde792d6).BeginInit();
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).BeginInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).BeginInit();
      ((ISupportInitialize) this.c0bc74edb9773f357b639b398786841b3).BeginInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).BeginInit();
      ((ISupportInitialize) this.ced6aa7f9911c4707f69ec112a4e51672).BeginInit();
      ((ISupportInitialize) this.cdf4f936649fd7e5caeee05e0dab9c79e).BeginInit();
      ((ISupportInitialize) this.c8af15fc87ff7fad3b7d70b37794c0516).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.ce940872bf2d542451e120044788d9340).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9168) != 0;
      ((Control) this.ce940872bf2d542451e120044788d9340).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9172);
      ((Control) this.ce940872bf2d542451e120044788d9340).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9176), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9180), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9184), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9188));
      ((Control) this.ce940872bf2d542451e120044788d9340).ForeColor = Color.FromArgb(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9192), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9196), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9200));
      ((Control) this.ce940872bf2d542451e120044788d9340).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9204), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9208));
      ((Control) this.ce940872bf2d542451e120044788d9340).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10090);
      ((Control) this.ce940872bf2d542451e120044788d9340).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9212), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9216));
      ((Control) this.ce940872bf2d542451e120044788d9340).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9220);
      ((Control) this.ce940872bf2d542451e120044788d9340).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13068);
      this.ce940872bf2d542451e120044788d9340.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9224));
      ((Control) this.c343fc3a72c2772b2c17357af34357ce7).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9228), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9232));
      ((Control) this.c343fc3a72c2772b2c17357af34357ce7).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13376);
      ((Control) this.c343fc3a72c2772b2c17357af34357ce7).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9236), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9240));
      ((Control) this.c343fc3a72c2772b2c17357af34357ce7).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9244);
      ((Control) this.c343fc3a72c2772b2c17357af34357ce7).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13399);
      ((RadControl) this.c343fc3a72c2772b2c17357af34357ce7).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c343fc3a72c2772b2c17357af34357ce7).Click += new EventHandler(this.c5acf3c4f284b5afb9980bb8347ebc8f3);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9248);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).AllowDrop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9252) != 0;
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.c0770534b75ebeea0c4e695dfdb7677d0);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.c9e453c2e79f4fc55124ccb1fd3603902);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.cee9946355c6a614ff90b875d32801e38);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.cba34b2a0111f6e5bc303375f968bc295);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.cb276241d1e50eb308cf7227c14ad5562);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9256);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9260), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9264), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9268), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9272));
      this.cd21917de552da0d5fa4c6079cd71111f.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13431));
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9276), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9280));
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13478);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9284), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9288));
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9292);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13431);
      ((RadControl) this.cd21917de552da0d5fa4c6079cd71111f).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9296), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9300));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13503);
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9304), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9308));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9312);
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13526);
      ((RadControl) this.c0770534b75ebeea0c4e695dfdb7677d0).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).TextChanged += new EventHandler(this.c3859ea2dc24cf2d88ba96db2ee219683);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9316), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9320), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9324), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9328));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9332), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9336));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13621);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9340), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9344));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9348);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13640);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9352), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9356), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9360), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9364));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9368), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9372));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9376), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9380));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9384);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13794);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9388), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9392), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9396), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9400));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9404), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9408));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13819);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9412), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9416));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9420);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13838);
      ((Control) this.cb276241d1e50eb308cf7227c14ad5562).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9424), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9428));
      ((Control) this.cb276241d1e50eb308cf7227c14ad5562).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13865);
      ((Control) this.cb276241d1e50eb308cf7227c14ad5562).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9432), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9436));
      ((Control) this.cb276241d1e50eb308cf7227c14ad5562).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9440);
      ((Control) this.cb276241d1e50eb308cf7227c14ad5562).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13888);
      ((RadControl) this.cb276241d1e50eb308cf7227c14ad5562).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9444), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9448));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13981);
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9452), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9456));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9460);
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14002);
      ((RadControl) this.c6b7d903aa965d47e2f39fa93f9aa3134).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Click += new EventHandler(this.c0a6ea2a725f4eff55eb6f116b2de4d29);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9464), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9468), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9472), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9476));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).ForeColor = Color.Green;
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9480), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9484));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Margin = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9488), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9492), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9496), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9500));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12323);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9504), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9508));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9512);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14007);
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).Controls.Add((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a);
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).Controls.Add((Control) this.c912ac08a9e3c8cff62b674fc43aac10c);
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9516);
      this.c241ce5265d52b769010f0f4dec3536aa.set_ItemSizeMode((PageViewItemSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9520));
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9524), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9528));
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14056);
      this.c241ce5265d52b769010f0f4dec3536aa.set_SelectedPage(this.c74bbb9a2042fa4be9844ab1f8b42123a);
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9532), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9536));
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9540);
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14081);
      this.c241ce5265d52b769010f0f4dec3536aa.set_ViewMode((PageViewMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9544));
      this.c241ce5265d52b769010f0f4dec3536aa.add_SelectedPageChanged(new EventHandler(this.c8edc0f40b39e3691b789472da5235597));
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).Controls.Add((Control) this.cd21917de552da0d5fa4c6079cd71111f);
      this.c74bbb9a2042fa4be9844ab1f8b42123a.set_ItemSize(new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9548), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9552)));
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9556), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9560));
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14130);
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9564), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9568));
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14163);
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).Paint += new PaintEventHandler(this.c9127b5297405b1c5f38e2ec8ff21fcac);
      ((Control) this.c912ac08a9e3c8cff62b674fc43aac10c).Controls.Add((Control) this.c8827d4c0d7431a9890c547ec78a2c02c);
      this.c912ac08a9e3c8cff62b674fc43aac10c.set_ItemSize(new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9572), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9576)));
      ((Control) this.c912ac08a9e3c8cff62b674fc43aac10c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9580), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9584));
      ((Control) this.c912ac08a9e3c8cff62b674fc43aac10c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14212);
      ((Control) this.c912ac08a9e3c8cff62b674fc43aac10c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9588), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9592));
      ((Control) this.c912ac08a9e3c8cff62b674fc43aac10c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14245);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9596);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c0b8c323aae75c040334498c5efcb96f4);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c38925728235576f0c42cd968bde792d6);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c5c88963d6e9c4dae998f5bdc712deec4);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c3768da1c9e17b9980d03acca3e5a19a9);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c0bc74edb9773f357b639b398786841b3);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c0b6ff62997904dd44189c4cb17f2ab15);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.ced6aa7f9911c4707f69ec112a4e51672);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c8af15fc87ff7fad3b7d70b37794c0516);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9600);
      this.c8827d4c0d7431a9890c547ec78a2c02c.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14278));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9604), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9608));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14311);
      this.c8827d4c0d7431a9890c547ec78a2c02c.set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9612)));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9616), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9620));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9624);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14278);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9628), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9632), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9636), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9640));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).ForeColor = Color.FromArgb(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9644), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9648), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9652));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9656), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9660));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14336);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9664), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9668));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9672);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14355);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9676), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9680));
      ((Control) this.c38925728235576f0c42cd968bde792d6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14533);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9684), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9688));
      ((Control) this.c38925728235576f0c42cd968bde792d6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9692);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14552);
      this.c5c88963d6e9c4dae998f5bdc712deec4.Image = (Image) c27603360ccc8374975348defb9eee9fc.filestruct;
      this.c5c88963d6e9c4dae998f5bdc712deec4.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9696), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9700));
      this.c5c88963d6e9c4dae998f5bdc712deec4.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11217);
      this.c5c88963d6e9c4dae998f5bdc712deec4.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9704), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9708));
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9712);
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9716) != 0;
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9720), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9724));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7473);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9728), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9732));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9736);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14750);
      ((RadControl) this.c3768da1c9e17b9980d03acca3e5a19a9).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Click += new EventHandler(this.cd3ea5f6f49b3d27138c3508cc5d825bb);
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9740), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9744));
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14769);
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9748), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9752));
      ((Control) this.c0bc74edb9773f357b639b398786841b3).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9756);
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14782);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9760);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).AllowDrop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9764) != 0;
      this.c0b6ff62997904dd44189c4cb17f2ab15.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14881));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9768), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9772));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14902);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9776), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9780));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9784);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14881);
      ((RadControl) this.c0b6ff62997904dd44189c4cb17f2ab15).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).DragDrop += new DragEventHandler(this.c1fcdbfc04fd168efe84fba3c0e084c1e);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).DragEnter += new DragEventHandler(this.c1bdb6e9770ae1a2fccca40cdff494718);
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9788), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9792));
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14927);
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9796), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9800));
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9804);
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14940);
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9808), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9812));
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15084);
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9816), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9820));
      ((Control) this.cdf4f936649fd7e5caeee05e0dab9c79e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9824);
      ((RadControl) this.cdf4f936649fd7e5caeee05e0dab9c79e).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9828), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9832));
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15097);
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9836), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9840));
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9844);
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15110);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9848), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9852));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9856));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9860), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9864));
      ((Control) this).Controls.Add((Control) this.c241ce5265d52b769010f0f4dec3536aa);
      ((Control) this).Controls.Add((Control) this.c343fc3a72c2772b2c17357af34357ce7);
      ((Control) this).Controls.Add((Control) this.ce940872bf2d542451e120044788d9340);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9868));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15217);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9872));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9876) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9880) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9884);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15242);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Form) this).Load += new EventHandler(this.c61399fae139b88bc52e6803c31a207ed);
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).EndInit();
      ((ISupportInitialize) this.c343fc3a72c2772b2c17357af34357ce7).EndInit();
      ((ISupportInitialize) this.cd21917de552da0d5fa4c6079cd71111f).EndInit();
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9888) != 0);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).PerformLayout();
      ((ISupportInitialize) this.c0770534b75ebeea0c4e695dfdb7677d0).EndInit();
      ((ISupportInitialize) this.c9e453c2e79f4fc55124ccb1fd3603902).EndInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.cba34b2a0111f6e5bc303375f968bc295).EndInit();
      ((ISupportInitialize) this.cb276241d1e50eb308cf7227c14ad5562).EndInit();
      ((ISupportInitialize) this.c6b7d903aa965d47e2f39fa93f9aa3134).EndInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).EndInit();
      ((ISupportInitialize) this.c241ce5265d52b769010f0f4dec3536aa).EndInit();
      ((Control) this.c241ce5265d52b769010f0f4dec3536aa).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9892) != 0);
      ((Control) this.c74bbb9a2042fa4be9844ab1f8b42123a).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9896) != 0);
      ((Control) this.c912ac08a9e3c8cff62b674fc43aac10c).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9900) != 0);
      ((ISupportInitialize) this.c8827d4c0d7431a9890c547ec78a2c02c).EndInit();
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9904) != 0);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).PerformLayout();
      ((ISupportInitialize) this.c0b8c323aae75c040334498c5efcb96f4).EndInit();
      ((ISupportInitialize) this.c38925728235576f0c42cd968bde792d6).EndInit();
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).EndInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).EndInit();
      ((ISupportInitialize) this.c0bc74edb9773f357b639b398786841b3).EndInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).EndInit();
      ((ISupportInitialize) this.ced6aa7f9911c4707f69ec112a4e51672).EndInit();
      ((ISupportInitialize) this.cdf4f936649fd7e5caeee05e0dab9c79e).EndInit();
      ((ISupportInitialize) this.c8af15fc87ff7fad3b7d70b37794c0516).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9908) != 0);
    }
  }
}
