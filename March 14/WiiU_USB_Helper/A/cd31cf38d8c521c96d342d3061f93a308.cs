// Decompiled with JetBrains decompiler
// Type: A.cd31cf38d8c521c96d342d3061f93a308
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
  public class cd31cf38d8c521c96d342d3061f93a308 : RadForm
  {
    private string cf2e6b21e14fafa61b5a2b344f91a56be;
    private cba6aa8f767d2e8dfbca2d43d7148c173 c9b6fd817b83756e2074587b1d851a7ec;
    private bool c908d515d095834d9c3113aeefddfa924;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadListView cee13cbfa6dfc4c406eae547699bdd423;
    private PictureBox c5c88963d6e9c4dae998f5bdc712deec4;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadLabel cee9946355c6a614ff90b875d32801e38;

    public cd31cf38d8c521c96d342d3061f93a308(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8, string c22af1bc581e420a524b3e4a36ef39fc4 = null)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      this.c9b6fd817b83756e2074587b1d851a7ec = c36dd98eb0c08ea087627a40c6663c9a8;
      this.cf2e6b21e14fafa61b5a2b344f91a56be = c22af1bc581e420a524b3e4a36ef39fc4;
      this.c908d515d095834d9c3113aeefddfa924 = (object) c22af1bc581e420a524b3e4a36ef39fc4 == (object) cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    private void c84e00bc2d39f4eb09aca57e788615893(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      cd31cf38d8c521c96d342d3061f93a308.c27056cd57129900556ae86d1910d69fd c27056cd57129900556ae86d1910d69fd = new cd31cf38d8c521c96d342d3061f93a308.c27056cd57129900556ae86d1910d69fd();
      // ISSUE: reference to a compiler-generated field
      c27056cd57129900556ae86d1910d69fd.ccb669e105f1c11f33e60c076fc8cca42 = this;
      if (this.cf2e6b21e14fafa61b5a2b344f91a56be != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cd31cf38d8c521c96d342d3061f93a308.c84e00bc2d39f4eb09aca57e788615893);
            }
            if (!Directory.Exists(this.cf2e6b21e14fafa61b5a2b344f91a56be))
            {
label_5:
              switch (3)
              {
                case 0:
                  goto label_5;
              }
            }
            else
              goto label_10;
        }
      }
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
      folderBrowserDialog1.Description = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12183), (object) this.c9b6fd817b83756e2074587b1d851a7ec);
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8976);
      folderBrowserDialog1.ShowNewFolderButton = num != 0;
      FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog1;
      if (folderBrowserDialog2.ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8980))
      {
label_7:
        switch (4)
        {
          case 0:
            goto label_7;
          default:
            ((Form) this).Close();
            return;
        }
      }
      else
        this.cf2e6b21e14fafa61b5a2b344f91a56be = folderBrowserDialog2.SelectedPath;
label_10:
      this.cf2e6b21e14fafa61b5a2b344f91a56be = Path.Combine(this.cf2e6b21e14fafa61b5a2b344f91a56be, this.c9b6fd817b83756e2074587b1d851a7ec.c0f5bf28fdcef3397fbbb3ca192f34d08());
      Directory.CreateDirectory(this.cf2e6b21e14fafa61b5a2b344f91a56be);
      ((RadElement) ((RadTitleBarElement) this.get_FormElement().get_TitleBar()).get_CloseButton()).set_Visibility((ElementVisibility) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8984));
      // ISSUE: reference to a compiler-generated field
      c27056cd57129900556ae86d1910d69fd.c5ddd7e5ab9732ccdfe59d4296192e4ea = Path.Combine(Directory.GetParent(this.c9b6fd817b83756e2074587b1d851a7ec.OutputPath).FullName, this.c9b6fd817b83756e2074587b1d851a7ec.TitleId.IdRaw);
      // ISSUE: reference to a compiler-generated field
      Directory.Move(this.c9b6fd817b83756e2074587b1d851a7ec.OutputPath, c27056cd57129900556ae86d1910d69fd.c5ddd7e5ab9732ccdfe59d4296192e4ea);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      c27056cd57129900556ae86d1910d69fd.c0be14e1739b80b30554c70677cf2befe = this.c9b6fd817b83756e2074587b1d851a7ec.c109d863a3d11449fb3acdb694a4a225f(c27056cd57129900556ae86d1910d69fd.c5ddd7e5ab9732ccdfe59d4296192e4ea);
      // ISSUE: reference to a compiler-generated field
      c27056cd57129900556ae86d1910d69fd.c0be14e1739b80b30554c70677cf2befe.OutputDataReceived += (DataReceivedEventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        cd31cf38d8c521c96d342d3061f93a308.ca5a8a372c06e696443832a0ffd7b18f4 ca5a8a372c06e696443832a0ffd7b18f4 = new cd31cf38d8c521c96d342d3061f93a308.ca5a8a372c06e696443832a0ffd7b18f4();
        // ISSUE: reference to a compiler-generated field
        ca5a8a372c06e696443832a0ffd7b18f4.ccb669e105f1c11f33e60c076fc8cca42 = this;
        // ISSUE: reference to a compiler-generated field
        ca5a8a372c06e696443832a0ffd7b18f4.c35ef8b45dc1b4f9c689c88c6aa3b9c3c = c35ef8b45dc1b4f9c689c88c6aa3b9c3c;
        try
        {
          // ISSUE: reference to a compiler-generated method
          ((Control) this).Invoke((Delegate) new Action(ca5a8a372c06e696443832a0ffd7b18f4.c990ef7548158ac22bf5dde6ce4992e21));
        }
        catch
        {
        }
      });
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      c27056cd57129900556ae86d1910d69fd.c0be14e1739b80b30554c70677cf2befe.Exited += new EventHandler(c27056cd57129900556ae86d1910d69fd.c556217aeb46116b40858fa2206433a31);
      // ISSUE: reference to a compiler-generated field
      c27056cd57129900556ae86d1910d69fd.c0be14e1739b80b30554c70677cf2befe.Start();
      // ISSUE: reference to a compiler-generated field
      c27056cd57129900556ae86d1910d69fd.c0be14e1739b80b30554c70677cf2befe.BeginOutputReadLine();
    }

    private void cdb90506134ebaee9b57a944a08d9bf4a(string c907075ebe7f1c4b189f6eae5161c381b, string c2307e7449ac922bd5ff0571e4dfa7ab7)
    {
      if (!Directory.Exists(c907075ebe7f1c4b189f6eae5161c381b))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (cd31cf38d8c521c96d342d3061f93a308.cdb90506134ebaee9b57a944a08d9bf4a);
          }
          FileSystem.MoveDirectory(c907075ebe7f1c4b189f6eae5161c381b, c2307e7449ac922bd5ff0571e4dfa7ab7, (UIOption) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8988));
          break;
      }
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (cd31cf38d8c521c96d342d3061f93a308.Dispose);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c7ac8dbf316e203189758d0e77f2a745d.c6804baa30a51e813a45fabcfa2b27b79()));
      this.cee13cbfa6dfc4c406eae547699bdd423 = new RadListView();
      this.c5c88963d6e9c4dae998f5bdc712deec4 = new PictureBox();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.cee9946355c6a614ff90b875d32801e38 = new RadLabel();
      ((ISupportInitialize) this.cee13cbfa6dfc4c406eae547699bdd423).BeginInit();
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).BeginInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.cee13cbfa6dfc4c406eae547699bdd423).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8992);
      ((Control) this.cee13cbfa6dfc4c406eae547699bdd423).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8996), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9000));
      ((Control) this.cee13cbfa6dfc4c406eae547699bdd423).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      ((Control) this.cee13cbfa6dfc4c406eae547699bdd423).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9004), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9008));
      ((Control) this.cee13cbfa6dfc4c406eae547699bdd423).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9012);
      ((Control) this.cee13cbfa6dfc4c406eae547699bdd423).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      this.c5c88963d6e9c4dae998f5bdc712deec4.Image = (Image) c27603360ccc8374975348defb9eee9fc.squares;
      this.c5c88963d6e9c4dae998f5bdc712deec4.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9016), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9020));
      this.c5c88963d6e9c4dae998f5bdc712deec4.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11217);
      this.c5c88963d6e9c4dae998f5bdc712deec4.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9024), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9028));
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9032);
      this.c5c88963d6e9c4dae998f5bdc712deec4.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9036) != 0;
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9040), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9044));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9048), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9052));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9056);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12250);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9060), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9064));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12323);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9068), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9072));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9076);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12342);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9080), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(9084));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9088));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9092), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9096));
      ((Control) this).Controls.Add((Control) this.cee9946355c6a614ff90b875d32801e38);
      ((Control) this).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((Control) this).Controls.Add((Control) this.c5c88963d6e9c4dae998f5bdc712deec4);
      ((Control) this).Controls.Add((Control) this.cee13cbfa6dfc4c406eae547699bdd423);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9100));
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12437);
      ((Control) this).Padding = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9104));
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9108) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9112) != 0);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12456);
      ((Form) this).Load += new EventHandler(this.c84e00bc2d39f4eb09aca57e788615893);
      ((ISupportInitialize) this.cee13cbfa6dfc4c406eae547699bdd423).EndInit();
      ((ISupportInitialize) this.c5c88963d6e9c4dae998f5bdc712deec4).EndInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(9116) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
