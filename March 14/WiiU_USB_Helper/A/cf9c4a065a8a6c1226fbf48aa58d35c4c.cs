// Decompiled with JetBrains decompiler
// Type: A.cf9c4a065a8a6c1226fbf48aa58d35c4c
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace A
{
  public class cf9c4a065a8a6c1226fbf48aa58d35c4c : RadForm
  {
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadLabel ce940872bf2d542451e120044788d9340;
    private RadButton c29bf6738c646d838e9cdcf62ff40de3e;
    private RadButton c12d28910164726c79867b2e79c4aee19;
    private RadButton c5339f73c615a619b17b98364e2e21b26;
    private RadLabel c544236c90282c9157c1c7d7d9ff1369c;
    private CheckBox cf54730b88e303046bcf3fd2016d7c2ae;
    private RadTextBox c0770534b75ebeea0c4e695dfdb7677d0;

    public cf9c4a065a8a6c1226fbf48aa58d35c4c()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    private void ceb6e8f274118b60ea044721548bda583(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      Settings.Default.Region = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338);
      this.c7123d89915c6aa3a96e182bf91e8ae83();
    }

    private void c80f4505adb74ddd6523d8e6d6e405abd(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      Settings.Default.Region = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9240);
      this.c7123d89915c6aa3a96e182bf91e8ae83();
    }

    private void cd2c7c860cbada7fa6de4dfff3d3d1809(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      Settings.Default.Region = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345);
      this.c7123d89915c6aa3a96e182bf91e8ae83();
    }

    private void c433ead157ec312dc1c7442dfb31b87f4(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((RadElement) ((RadTitleBarElement) this.get_FormElement().get_TitleBar()).get_CloseButton()).set_Visibility((ElementVisibility) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19582));
      if (!cdf6c91719eae5a38c64a7fd64afdf5e1.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8320)))
        return;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cf9c4a065a8a6c1226fbf48aa58d35c4c.c433ead157ec312dc1c7442dfb31b87f4);
          }
          this.c7123d89915c6aa3a96e182bf91e8ae83();
          break;
      }
    }

    private void c7123d89915c6aa3a96e182bf91e8ae83()
    {
      if (this.cf54730b88e303046bcf3fd2016d7c2ae.Checked)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cf9c4a065a8a6c1226fbf48aa58d35c4c.c7123d89915c6aa3a96e182bf91e8ae83);
            }
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34830));
            Settings.Default.Save();
            ((Form) this).Close();
            break;
        }
      }
      else
      {
        int num1 = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35556));
      }
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cf9c4a065a8a6c1226fbf48aa58d35c4c.Dispose);
            }
            if (this.ce2dde71ac55aad4a9ce23a50ce61cd89 != null)
            {
label_5:
              switch (3)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c3b63cea46f59641a33e1a00816176f21.c6804baa30a51e813a45fabcfa2b27b79()));
      this.ce940872bf2d542451e120044788d9340 = new RadLabel();
      this.c29bf6738c646d838e9cdcf62ff40de3e = new RadButton();
      this.c12d28910164726c79867b2e79c4aee19 = new RadButton();
      this.c5339f73c615a619b17b98364e2e21b26 = new RadButton();
      this.c544236c90282c9157c1c7d7d9ff1369c = new RadLabel();
      this.cf54730b88e303046bcf3fd2016d7c2ae = new CheckBox();
      this.c0770534b75ebeea0c4e695dfdb7677d0 = new RadTextBox();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).BeginInit();
      ((ISupportInitialize) this.c29bf6738c646d838e9cdcf62ff40de3e).BeginInit();
      ((ISupportInitialize) this.c12d28910164726c79867b2e79c4aee19).BeginInit();
      ((ISupportInitialize) this.c5339f73c615a619b17b98364e2e21b26).BeginInit();
      ((ISupportInitialize) this.c544236c90282c9157c1c7d7d9ff1369c).BeginInit();
      ((ISupportInitialize) this.c0770534b75ebeea0c4e695dfdb7677d0).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.ce940872bf2d542451e120044788d9340).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19586), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19590));
      ((Control) this.ce940872bf2d542451e120044788d9340).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10090);
      ((Control) this.ce940872bf2d542451e120044788d9340).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19594), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19598));
      ((Control) this.ce940872bf2d542451e120044788d9340).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19602);
      ((Control) this.ce940872bf2d542451e120044788d9340).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35665);
      ((RadControl) this.ce940872bf2d542451e120044788d9340).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c29bf6738c646d838e9cdcf62ff40de3e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19606), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19610));
      ((Control) this.c29bf6738c646d838e9cdcf62ff40de3e).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35782);
      ((Control) this.c29bf6738c646d838e9cdcf62ff40de3e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19614), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19618));
      ((Control) this.c29bf6738c646d838e9cdcf62ff40de3e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19622);
      ((Control) this.c29bf6738c646d838e9cdcf62ff40de3e).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345);
      ((RadControl) this.c29bf6738c646d838e9cdcf62ff40de3e).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c29bf6738c646d838e9cdcf62ff40de3e).Click += new EventHandler(this.cd2c7c860cbada7fa6de4dfff3d3d1809);
      ((Control) this.c12d28910164726c79867b2e79c4aee19).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19626), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19630));
      ((Control) this.c12d28910164726c79867b2e79c4aee19).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35795);
      ((Control) this.c12d28910164726c79867b2e79c4aee19).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19634), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19638));
      ((Control) this.c12d28910164726c79867b2e79c4aee19).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19642);
      ((Control) this.c12d28910164726c79867b2e79c4aee19).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338);
      ((RadControl) this.c12d28910164726c79867b2e79c4aee19).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c12d28910164726c79867b2e79c4aee19).Click += new EventHandler(this.ceb6e8f274118b60ea044721548bda583);
      ((Control) this.c5339f73c615a619b17b98364e2e21b26).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19646), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19650));
      ((Control) this.c5339f73c615a619b17b98364e2e21b26).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35808);
      ((Control) this.c5339f73c615a619b17b98364e2e21b26).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19654), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19658));
      ((Control) this.c5339f73c615a619b17b98364e2e21b26).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19662);
      ((Control) this.c5339f73c615a619b17b98364e2e21b26).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9240);
      ((RadControl) this.c5339f73c615a619b17b98364e2e21b26).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c5339f73c615a619b17b98364e2e21b26).Click += new EventHandler(this.c80f4505adb74ddd6523d8e6d6e405abd);
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).ForeColor = Color.Red;
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19666), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19670));
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18789);
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19674), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19678));
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19682);
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35821);
      ((RadControl) this.c544236c90282c9157c1c7d7d9ff1369c).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.cf54730b88e303046bcf3fd2016d7c2ae.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19686) != 0;
      this.cf54730b88e303046bcf3fd2016d7c2ae.ForeColor = Color.Red;
      this.cf54730b88e303046bcf3fd2016d7c2ae.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19690), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19694));
      this.cf54730b88e303046bcf3fd2016d7c2ae.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35944);
      this.cf54730b88e303046bcf3fd2016d7c2ae.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19698), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19702));
      this.cf54730b88e303046bcf3fd2016d7c2ae.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19706);
      this.cf54730b88e303046bcf3fd2016d7c2ae.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(35971);
      this.cf54730b88e303046bcf3fd2016d7c2ae.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19710) != 0;
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19714) != 0;
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).ForeColor = Color.FromArgb(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19718), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19722), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19726));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19730), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19734));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19738), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19742));
      ((RadTextBoxBase) this.c0770534b75ebeea0c4e695dfdb7677d0).set_Multiline(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19746) != 0);
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13503);
      ((RadTextBoxBase) this.c0770534b75ebeea0c4e695dfdb7677d0).set_ReadOnly(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19750) != 0);
      ((RadElement) ((RadControl) this.c0770534b75ebeea0c4e695dfdb7677d0).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19754), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19758)));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19762), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19766));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19770);
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Text = componentResourceManager.GetString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(36016));
      ((RadControl) this.c0770534b75ebeea0c4e695dfdb7677d0).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(19774), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(19778));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19782));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19786), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19790));
      ((Control) this).Controls.Add((Control) this.c0770534b75ebeea0c4e695dfdb7677d0);
      ((Control) this).Controls.Add((Control) this.cf54730b88e303046bcf3fd2016d7c2ae);
      ((Control) this).Controls.Add((Control) this.c544236c90282c9157c1c7d7d9ff1369c);
      ((Control) this).Controls.Add((Control) this.c5339f73c615a619b17b98364e2e21b26);
      ((Control) this).Controls.Add((Control) this.c12d28910164726c79867b2e79c4aee19);
      ((Control) this).Controls.Add((Control) this.c29bf6738c646d838e9cdcf62ff40de3e);
      ((Control) this).Controls.Add((Control) this.ce940872bf2d542451e120044788d9340);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19794));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(36049);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19798) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19802) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19806);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(36070);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Form) this).Load += new EventHandler(this.c433ead157ec312dc1c7442dfb31b87f4);
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).EndInit();
      ((ISupportInitialize) this.c29bf6738c646d838e9cdcf62ff40de3e).EndInit();
      ((ISupportInitialize) this.c12d28910164726c79867b2e79c4aee19).EndInit();
      ((ISupportInitialize) this.c5339f73c615a619b17b98364e2e21b26).EndInit();
      ((ISupportInitialize) this.c544236c90282c9157c1c7d7d9ff1369c).EndInit();
      ((ISupportInitialize) this.c0770534b75ebeea0c4e695dfdb7677d0).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19810) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
