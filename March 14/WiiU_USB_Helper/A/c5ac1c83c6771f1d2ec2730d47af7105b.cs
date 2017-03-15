// Decompiled with JetBrains decompiler
// Type: A.c5ac1c83c6771f1d2ec2730d47af7105b
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Forms;

namespace A
{
  public class c5ac1c83c6771f1d2ec2730d47af7105b : RadForm
  {
    public List<ce64fe4baff0b285aaecd02e2cae2ea2c> cb917dff3a4bc5ccb946b4a838034a862;
    private WhatToAction cf03615c721382f9adb018993489259dd;
    private cce1cf1e0b6971ed6f7ef86a83b0959b6 c96b8e6f4e9f5e44b2fe699369d544613;
    private bool c081ad20c5e4d89c184edf191af8142ba;
    private int cffb0a622b0a01edd74f87e3dd6ecabe7;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadLabel ce940872bf2d542451e120044788d9340;
    private RadCheckBox cd4db08d2fcf3456a34306eebd4dc7244;
    private RadCheckBox ccfeb6fdd817438a960ed83fed86bda50;
    private RadButton c3768da1c9e17b9980d03acca3e5a19a9;
    private RadCheckBox c9454a5157d9a45a9ac8ddd9ea1de4a2c;
    private RadLabel c36dd98eb0c08ea087627a40c6663c9a8;

    public bool CopyDlc { get; set; }

    public bool CopyGame { get; set; }

    public bool CopyUpdate { get; set; }

    public c5ac1c83c6771f1d2ec2730d47af7105b(cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319, WhatToAction c98e063588d8667f7cd2ff9e5891866fd)
    {
      this.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      int num1;
      if (c98e063588d8667f7cd2ff9e5891866fd != WhatToAction.Copy)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c5ac1c83c6771f1d2ec2730d47af7105b.\u002Ector);
            }
            num1 = c98e063588d8667f7cd2ff9e5891866fd == (WhatToAction) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11956) ? 1 : 0;
            break;
        }
      }
      else
        num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11960);
      this.c081ad20c5e4d89c184edf191af8142ba = num1 != 0;
      this.cf03615c721382f9adb018993489259dd = c98e063588d8667f7cd2ff9e5891866fd;
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Text = c89cbac13be511053120093fce8049319.Name;
      this.c96b8e6f4e9f5e44b2fe699369d544613 = c89cbac13be511053120093fce8049319;
      ((Control) this).Text = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18856), (object) c98e063588d8667f7cd2ff9e5891866fd);
      ((Control) this.ce940872bf2d542451e120044788d9340).Text = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18879), (object) Enum.GetName(Type.GetTypeFromHandle(c1967f7e2d2a97b97b6d65efb2b601f3e.c6804baa30a51e813a45fabcfa2b27b79()), (object) c98e063588d8667f7cd2ff9e5891866fd).ToLower());
      if (this.c081ad20c5e4d89c184edf191af8142ba)
      {
label_7:
        switch (2)
        {
          case 0:
            goto label_7;
          default:
            ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Enabled = c89cbac13be511053120093fce8049319.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11964);
            RadCheckBox ccfeb6fdd817438a960ed83fed86bda50 = this.ccfeb6fdd817438a960ed83fed86bda50;
            int num2;
            if (c89cbac13be511053120093fce8049319.c2485b5906efc569b1c867e5c900b2e4e)
            {
label_9:
              switch (1)
              {
                case 0:
                  goto label_9;
                default:
                  List<ce64fe4baff0b285aaecd02e2cae2ea2c> updates = c89cbac13be511053120093fce8049319.Updates;
                  // ISSUE: reference to a compiler-generated field
                  Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool> predicate = c5ac1c83c6771f1d2ec2730d47af7105b.\u003C\u003Ec.c56ecc1d647404f5e2c4554f0ef3b419f;
                  if (predicate == null)
                  {
label_11:
                    switch (4)
                    {
                      case 0:
                        goto label_11;
                      default:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        predicate = c5ac1c83c6771f1d2ec2730d47af7105b.\u003C\u003Ec.c56ecc1d647404f5e2c4554f0ef3b419f = new Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool>(c5ac1c83c6771f1d2ec2730d47af7105b.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cc89a5ac07fd01e620922a666b59cd3fe);
                        break;
                    }
                  }
                  num2 = updates.Any<ce64fe4baff0b285aaecd02e2cae2ea2c>(predicate) ? 1 : 0;
                  break;
              }
            }
            else
              num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11968);
            ((Control) ccfeb6fdd817438a960ed83fed86bda50).Enabled = num2 != 0;
            RadCheckBox c9454a5157d9a45a9ac8ddd9ea1de4a2c = this.c9454a5157d9a45a9ac8ddd9ea1de4a2c;
            int num3;
            if (c89cbac13be511053120093fce8049319.Dlc != null)
            {
label_16:
              switch (2)
              {
                case 0:
                  goto label_16;
                default:
                  num3 = c89cbac13be511053120093fce8049319.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11972) ? 1 : 0;
                  break;
              }
            }
            else
              num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11976);
            ((Control) c9454a5157d9a45a9ac8ddd9ea1de4a2c).Enabled = num3 != 0;
            break;
        }
      }
      else
      {
        ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Enabled = (uint) c89cbac13be511053120093fce8049319.c7adb0b831ae9d44c1bc321f4993f8d5d > (uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11980);
        RadCheckBox ccfeb6fdd817438a960ed83fed86bda50 = this.ccfeb6fdd817438a960ed83fed86bda50;
        int num2;
        if (c89cbac13be511053120093fce8049319.c2485b5906efc569b1c867e5c900b2e4e)
        {
label_21:
          switch (5)
          {
            case 0:
              goto label_21;
            default:
              List<ce64fe4baff0b285aaecd02e2cae2ea2c> updates = c89cbac13be511053120093fce8049319.Updates;
              // ISSUE: reference to a compiler-generated field
              Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool> predicate = c5ac1c83c6771f1d2ec2730d47af7105b.\u003C\u003Ec.cd8eb5ab47043e58b9ae39d42f7bcb156;
              if (predicate == null)
              {
label_23:
                switch (6)
                {
                  case 0:
                    goto label_23;
                  default:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    predicate = c5ac1c83c6771f1d2ec2730d47af7105b.\u003C\u003Ec.cd8eb5ab47043e58b9ae39d42f7bcb156 = new Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool>(c5ac1c83c6771f1d2ec2730d47af7105b.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c8a78d477b91bc7582713b6bd2a84c33d);
                    break;
                }
              }
              num2 = updates.Any<ce64fe4baff0b285aaecd02e2cae2ea2c>(predicate) ? 1 : 0;
              break;
          }
        }
        else
          num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11984);
        ((Control) ccfeb6fdd817438a960ed83fed86bda50).Enabled = num2 != 0;
        RadCheckBox c9454a5157d9a45a9ac8ddd9ea1de4a2c = this.c9454a5157d9a45a9ac8ddd9ea1de4a2c;
        int num3;
        if (c89cbac13be511053120093fce8049319.Dlc != null)
        {
label_28:
          switch (4)
          {
            case 0:
              goto label_28;
            default:
              num3 = (uint) c89cbac13be511053120093fce8049319.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d > (uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11988) ? 1 : 0;
              break;
          }
        }
        else
          num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11992);
        ((Control) c9454a5157d9a45a9ac8ddd9ea1de4a2c).Enabled = num3 != 0;
      }
      ((Form) this).Opacity = cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(11996);
    }

    private void c40d736fc970a087b664d32bf9c0d15ed(object c5382ad5461e274fda51b358802fc3910, StateChangedEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      if (!this.ccfeb6fdd817438a960ed83fed86bda50.get_Checked())
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c5ac1c83c6771f1d2ec2730d47af7105b.c40d736fc970a087b664d32bf9c0d15ed);
            break;
        }
      }
      else
        this.c583dafd63d1b5d34d8edcb02bf2da571();
    }

    private void c583dafd63d1b5d34d8edcb02bf2da571()
    {
      c58509175cbe634f2808d2fefd16ab8d3 c58509175cbe634f2808d2fefd16ab8d3 = new c58509175cbe634f2808d2fefd16ab8d3((IEnumerable<ce64fe4baff0b285aaecd02e2cae2ea2c>) this.c96b8e6f4e9f5e44b2fe699369d544613.Updates, this.c081ad20c5e4d89c184edf191af8142ba);
      if (((Form) c58509175cbe634f2808d2fefd16ab8d3).ShowDialog() == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11712))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c5ac1c83c6771f1d2ec2730d47af7105b.c583dafd63d1b5d34d8edcb02bf2da571);
            }
            this.cb917dff3a4bc5ccb946b4a838034a862 = c58509175cbe634f2808d2fefd16ab8d3.cb917dff3a4bc5ccb946b4a838034a862;
            break;
        }
      }
      else
        this.ccfeb6fdd817438a960ed83fed86bda50.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11716) != 0);
    }

    private void cd8a2159bd70a1fb708936de6cd95399e(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Enabled)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c5ac1c83c6771f1d2ec2730d47af7105b.cd8a2159bd70a1fb708936de6cd95399e);
            }
            this.cffb0a622b0a01edd74f87e3dd6ecabe7 = this.cffb0a622b0a01edd74f87e3dd6ecabe7 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11720);
            break;
        }
      }
      if (((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).Enabled)
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            this.cffb0a622b0a01edd74f87e3dd6ecabe7 = this.cffb0a622b0a01edd74f87e3dd6ecabe7 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11724);
            break;
        }
      }
      if (((Control) this.ccfeb6fdd817438a960ed83fed86bda50).Enabled)
      {
label_9:
        switch (2)
        {
          case 0:
            goto label_9;
          default:
            this.cffb0a622b0a01edd74f87e3dd6ecabe7 = this.cffb0a622b0a01edd74f87e3dd6ecabe7 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11728);
            break;
        }
      }
      if (!this.c081ad20c5e4d89c184edf191af8142ba)
      {
label_12:
        switch (7)
        {
          case 0:
            goto label_12;
          default:
            ((Form) this).Opacity = cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(11732);
            break;
        }
      }
      else
      {
        if (this.cffb0a622b0a01edd74f87e3dd6ecabe7 == 0)
        {
label_15:
          switch (4)
          {
            case 0:
              goto label_15;
            default:
              ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11740);
              ((Form) this).Close();
              break;
          }
        }
        if (this.cffb0a622b0a01edd74f87e3dd6ecabe7 != cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11744))
        {
label_18:
          switch (3)
          {
            case 0:
              goto label_18;
            default:
              ((Form) this).Opacity = cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(11748);
              break;
          }
        }
        else
        {
          ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11756);
          this.CopyGame = ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Enabled;
          if (((Control) this.ccfeb6fdd817438a960ed83fed86bda50).Enabled)
          {
label_21:
            switch (7)
            {
              case 0:
                goto label_21;
              default:
                this.c583dafd63d1b5d34d8edcb02bf2da571();
                this.CopyUpdate = this.cb917dff3a4bc5ccb946b4a838034a862 > cd6d6fd21de3556de428d6982329e94bd.c20c00b8e97bb4c0fb2b7ac6facf98b91;
                break;
            }
          }
          this.CopyDlc = ((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).Enabled;
          ((Form) this).Close();
        }
      }
    }

    private void cd3ea5f6f49b3d27138c3508cc5d825bb(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11760);
      this.CopyGame = this.cd4db08d2fcf3456a34306eebd4dc7244.get_Checked();
      this.CopyUpdate = this.ccfeb6fdd817438a960ed83fed86bda50.get_Checked();
      this.CopyDlc = this.c9454a5157d9a45a9ac8ddd9ea1de4a2c.get_Checked();
      ((Form) this).Close();
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c5ac1c83c6771f1d2ec2730d47af7105b.Dispose);
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
      this.ce940872bf2d542451e120044788d9340 = new RadLabel();
      this.cd4db08d2fcf3456a34306eebd4dc7244 = new RadCheckBox();
      this.ccfeb6fdd817438a960ed83fed86bda50 = new RadCheckBox();
      this.c3768da1c9e17b9980d03acca3e5a19a9 = new RadButton();
      this.c9454a5157d9a45a9ac8ddd9ea1de4a2c = new RadCheckBox();
      this.c36dd98eb0c08ea087627a40c6663c9a8 = new RadLabel();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).BeginInit();
      ((ISupportInitialize) this.cd4db08d2fcf3456a34306eebd4dc7244).BeginInit();
      ((ISupportInitialize) this.ccfeb6fdd817438a960ed83fed86bda50).BeginInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).BeginInit();
      ((ISupportInitialize) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).BeginInit();
      ((ISupportInitialize) this.c36dd98eb0c08ea087627a40c6663c9a8).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.ce940872bf2d542451e120044788d9340).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11764), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11768));
      ((Control) this.ce940872bf2d542451e120044788d9340).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10090);
      ((Control) this.ce940872bf2d542451e120044788d9340).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11772), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11776));
      ((Control) this.ce940872bf2d542451e120044788d9340).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11780);
      ((Control) this.ce940872bf2d542451e120044788d9340).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18616);
      ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11784), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11788));
      ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18689);
      ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11792), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11796));
      ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11800);
      ((Control) this.cd4db08d2fcf3456a34306eebd4dc7244).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18712);
      ((Control) this.ccfeb6fdd817438a960ed83fed86bda50).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11804), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11808));
      ((Control) this.ccfeb6fdd817438a960ed83fed86bda50).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18721);
      ((Control) this.ccfeb6fdd817438a960ed83fed86bda50).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11812), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11816));
      ((Control) this.ccfeb6fdd817438a960ed83fed86bda50).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11820);
      ((Control) this.ccfeb6fdd817438a960ed83fed86bda50).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18748);
      // ISSUE: method pointer
      ((RadToggleButton) this.ccfeb6fdd817438a960ed83fed86bda50).add_ToggleStateChanged(new StateChangedEventHandler((object) this, __methodptr(c40d736fc970a087b664d32bf9c0d15ed)));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11824), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11828));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7473);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11832), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11836));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11840);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14002);
      ((RadControl) this.c3768da1c9e17b9980d03acca3e5a19a9).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Click += new EventHandler(this.cd3ea5f6f49b3d27138c3508cc5d825bb);
      ((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11844), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11848));
      ((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18761);
      ((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11852), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11856));
      ((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11860);
      ((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18782);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11864) != 0;
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11868);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11872), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11876), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11880), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11884));
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11888), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11892));
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7417);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11896), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11900));
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11904);
      ((Control) this.c36dd98eb0c08ea087627a40c6663c9a8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18789);
      this.c36dd98eb0c08ea087627a40c6663c9a8.set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11908));
      this.c36dd98eb0c08ea087627a40c6663c9a8.set_UseMnemonic(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11912) != 0);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11916), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(11920));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11924));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11928), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11932));
      ((Control) this).Controls.Add((Control) this.c36dd98eb0c08ea087627a40c6663c9a8);
      ((Control) this).Controls.Add((Control) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c);
      ((Control) this).Controls.Add((Control) this.c3768da1c9e17b9980d03acca3e5a19a9);
      ((Control) this).Controls.Add((Control) this.ccfeb6fdd817438a960ed83fed86bda50);
      ((Control) this).Controls.Add((Control) this.cd4db08d2fcf3456a34306eebd4dc7244);
      ((Control) this).Controls.Add((Control) this.ce940872bf2d542451e120044788d9340);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11936));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18802);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11940) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11944) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11948);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18829);
      ((RadFormControlBase) this).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13418));
      ((Form) this).Load += new EventHandler(this.cd8a2159bd70a1fb708936de6cd95399e);
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).EndInit();
      ((ISupportInitialize) this.cd4db08d2fcf3456a34306eebd4dc7244).EndInit();
      ((ISupportInitialize) this.ccfeb6fdd817438a960ed83fed86bda50).EndInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).EndInit();
      ((ISupportInitialize) this.c9454a5157d9a45a9ac8ddd9ea1de4a2c).EndInit();
      ((ISupportInitialize) this.c36dd98eb0c08ea087627a40c6663c9a8).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(11952) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
