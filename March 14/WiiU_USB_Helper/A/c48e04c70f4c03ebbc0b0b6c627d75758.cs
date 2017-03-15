// Decompiled with JetBrains decompiler
// Type: A.c48e04c70f4c03ebbc0b0b6c627d75758
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
  public class c48e04c70f4c03ebbc0b0b6c627d75758 : RadForm
  {
    public IPAddress c822a74f59886365c6601e3f4fcf03497;
    private readonly c6b6cd1274db5c3760ebd273284d15464 cffdfbd8b745c68369d345553a1d5b9a7;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadSpinEditor c043655c49351198d53937bceaedc9259;
    private RadSpinEditor cbf64a879ae2aa334872c401083f6135e;
    private RadSpinEditor cdcac4e94628a385a08e4e7c77a84487c;
    private RadSpinEditor c4f7923b753673b9ed6ba494072ddfc60;
    private RadButton c3768da1c9e17b9980d03acca3e5a19a9;

    public c48e04c70f4c03ebbc0b0b6c627d75758()
    {
      base.\u002Ector();
      this.cfb5cf413352ed4044535eb4a62d2e98f();
    }

    private void c86d4f48c6888f128ea89c29edc8a9aec(object c5382ad5461e274fda51b358802fc3910, FormClosingEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cffdfbd8b745c68369d345553a1d5b9a7.c5434ee3bcfd63c0e82b7bf977619f848();
    }

    private void c5a9236f6f28eb5fdcc94a3cc9e0add54(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.cffdfbd8b745c68369d345553a1d5b9a7.c216fa6b5069ca26468baa8aeee5f77bc += (EventHandler<IPAddress>) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, cc993020431218dd1868140562b121eea) => ((Control) this).Invoke((Delegate) new Action(new c48e04c70f4c03ebbc0b0b6c627d75758.cc49b9a81c259ebea4be0e6c69673d6ae()
      {
        ccb669e105f1c11f33e60c076fc8cca42 = this,
        cc993020431218dd1868140562b121eea = cc993020431218dd1868140562b121eea
      }.cc40e4b7b5225bbcb2554669ea56df6d0)));
      this.cffdfbd8b745c68369d345553a1d5b9a7.cf7908bdf1ba3f188e6255a17595c90c9(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10460) != 0);
    }

    private void cd3ea5f6f49b3d27138c3508cc5d825bb(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Form) this).DialogResult = (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10464);
      byte[] address = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10468));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10472);
      int num1 = (int) cddb8ed830277950927807194493d8596.c1df95097ffa57d753c5fe1353cf65e86(this.c043655c49351198d53937bceaedc9259.get_Value());
      address[index1] = (byte) num1;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10476);
      int num2 = (int) cddb8ed830277950927807194493d8596.c1df95097ffa57d753c5fe1353cf65e86(this.cbf64a879ae2aa334872c401083f6135e.get_Value());
      address[index2] = (byte) num2;
      int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10480);
      int num3 = (int) cddb8ed830277950927807194493d8596.c1df95097ffa57d753c5fe1353cf65e86(this.cdcac4e94628a385a08e4e7c77a84487c.get_Value());
      address[index3] = (byte) num3;
      int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10484);
      int num4 = (int) cddb8ed830277950927807194493d8596.c1df95097ffa57d753c5fe1353cf65e86(this.c4f7923b753673b9ed6ba494072ddfc60.get_Value());
      address[index4] = (byte) num4;
      this.c822a74f59886365c6601e3f4fcf03497 = new IPAddress(address);
      ((Form) this).Close();
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c48e04c70f4c03ebbc0b0b6c627d75758.Dispose);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(ca7f59f7aa9ae1de5fae3e55a26e6045b.c6804baa30a51e813a45fabcfa2b27b79()));
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.c043655c49351198d53937bceaedc9259 = new RadSpinEditor();
      this.cbf64a879ae2aa334872c401083f6135e = new RadSpinEditor();
      this.cdcac4e94628a385a08e4e7c77a84487c = new RadSpinEditor();
      this.c4f7923b753673b9ed6ba494072ddfc60 = new RadSpinEditor();
      this.c3768da1c9e17b9980d03acca3e5a19a9 = new RadButton();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.c043655c49351198d53937bceaedc9259).BeginInit();
      ((ISupportInitialize) this.cbf64a879ae2aa334872c401083f6135e).BeginInit();
      ((ISupportInitialize) this.cdcac4e94628a385a08e4e7c77a84487c).BeginInit();
      ((ISupportInitialize) this.c4f7923b753673b9ed6ba494072ddfc60).BeginInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10488), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10492));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10496), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10500));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10504);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16517);
      ((Control) this.c043655c49351198d53937bceaedc9259).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10508), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10512), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10516), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10520));
      ((Control) this.c043655c49351198d53937bceaedc9259).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10524), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10528));
      RadSpinEditor c043655c49351198d53937bceaedc9259_1 = this.c043655c49351198d53937bceaedc9259;
      int[] bits1 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10532));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10536);
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10540);
      bits1[index1] = num1;
      Decimal num2 = new Decimal(bits1);
      c043655c49351198d53937bceaedc9259_1.set_Maximum(num2);
      this.c043655c49351198d53937bceaedc9259.set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16592));
      RadSpinEditor c043655c49351198d53937bceaedc9259_2 = this.c043655c49351198d53937bceaedc9259;
      int[] bits2 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10544));
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10548);
      int num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10552);
      bits2[index2] = num3;
      Decimal? nullable1 = new Decimal?(new Decimal(bits2));
      c043655c49351198d53937bceaedc9259_2.set_NullableValue(nullable1);
      ((Control) this.c043655c49351198d53937bceaedc9259).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10556), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10560));
      ((Control) this.c043655c49351198d53937bceaedc9259).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10564);
      ((Control) this.c043655c49351198d53937bceaedc9259).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10568) != 0;
      RadSpinEditor c043655c49351198d53937bceaedc9259_3 = this.c043655c49351198d53937bceaedc9259;
      int[] bits3 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10572));
      int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10576);
      int num4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10580);
      bits3[index3] = num4;
      Decimal num5 = new Decimal(bits3);
      c043655c49351198d53937bceaedc9259_3.set_Value(num5);
      ((Control) this.cbf64a879ae2aa334872c401083f6135e).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10584), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10588), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10592), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10596));
      ((Control) this.cbf64a879ae2aa334872c401083f6135e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10600), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10604));
      RadSpinEditor cbf64a879ae2aa334872c401083f6135e1 = this.cbf64a879ae2aa334872c401083f6135e;
      int[] bits4 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10608));
      int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10612);
      int num6 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10616);
      bits4[index4] = num6;
      Decimal num7 = new Decimal(bits4);
      cbf64a879ae2aa334872c401083f6135e1.set_Maximum(num7);
      this.cbf64a879ae2aa334872c401083f6135e.set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16599));
      RadSpinEditor cbf64a879ae2aa334872c401083f6135e2 = this.cbf64a879ae2aa334872c401083f6135e;
      int[] bits5 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10620));
      int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10624);
      int num8 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10628);
      bits5[index5] = num8;
      Decimal? nullable2 = new Decimal?(new Decimal(bits5));
      cbf64a879ae2aa334872c401083f6135e2.set_NullableValue(nullable2);
      ((Control) this.cbf64a879ae2aa334872c401083f6135e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10632), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10636));
      ((Control) this.cbf64a879ae2aa334872c401083f6135e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10640);
      ((Control) this.cbf64a879ae2aa334872c401083f6135e).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10644) != 0;
      RadSpinEditor cbf64a879ae2aa334872c401083f6135e3 = this.cbf64a879ae2aa334872c401083f6135e;
      int[] bits6 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10648));
      int index6 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10652);
      int num9 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10656);
      bits6[index6] = num9;
      Decimal num10 = new Decimal(bits6);
      cbf64a879ae2aa334872c401083f6135e3.set_Value(num10);
      ((Control) this.cdcac4e94628a385a08e4e7c77a84487c).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10660), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10664), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10668), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10672));
      ((Control) this.cdcac4e94628a385a08e4e7c77a84487c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10676), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10680));
      RadSpinEditor cdcac4e94628a385a08e4e7c77a84487c1 = this.cdcac4e94628a385a08e4e7c77a84487c;
      int[] bits7 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10684));
      int index7 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10688);
      int num11 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10692);
      bits7[index7] = num11;
      Decimal num12 = new Decimal(bits7);
      cdcac4e94628a385a08e4e7c77a84487c1.set_Maximum(num12);
      this.cdcac4e94628a385a08e4e7c77a84487c.set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16606));
      RadSpinEditor cdcac4e94628a385a08e4e7c77a84487c2 = this.cdcac4e94628a385a08e4e7c77a84487c;
      int[] bits8 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10696));
      int index8 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10700);
      int num13 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10704);
      bits8[index8] = num13;
      Decimal? nullable3 = new Decimal?(new Decimal(bits8));
      cdcac4e94628a385a08e4e7c77a84487c2.set_NullableValue(nullable3);
      ((Control) this.cdcac4e94628a385a08e4e7c77a84487c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10708), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10712));
      ((Control) this.cdcac4e94628a385a08e4e7c77a84487c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10716);
      ((Control) this.cdcac4e94628a385a08e4e7c77a84487c).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10720) != 0;
      RadSpinEditor cdcac4e94628a385a08e4e7c77a84487c3 = this.cdcac4e94628a385a08e4e7c77a84487c;
      int[] bits9 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10724));
      int index9 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10728);
      int num14 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10732);
      bits9[index9] = num14;
      Decimal num15 = new Decimal(bits9);
      cdcac4e94628a385a08e4e7c77a84487c3.set_Value(num15);
      ((Control) this.c4f7923b753673b9ed6ba494072ddfc60).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10736), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10740), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10744), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10748));
      ((Control) this.c4f7923b753673b9ed6ba494072ddfc60).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10752), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10756));
      RadSpinEditor c4f7923b753673b9ed6ba494072ddfc60 = this.c4f7923b753673b9ed6ba494072ddfc60;
      int[] bits10 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10760));
      int index10 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10764);
      int num16 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10768);
      bits10[index10] = num16;
      Decimal num17 = new Decimal(bits10);
      c4f7923b753673b9ed6ba494072ddfc60.set_Maximum(num17);
      this.c4f7923b753673b9ed6ba494072ddfc60.set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16613));
      ((Control) this.c4f7923b753673b9ed6ba494072ddfc60).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10772), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10776));
      ((Control) this.c4f7923b753673b9ed6ba494072ddfc60).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10780);
      ((Control) this.c4f7923b753673b9ed6ba494072ddfc60).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10784) != 0;
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10788), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10792));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7473);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10796), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10800));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10804);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14002);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Click += new EventHandler(this.cd3ea5f6f49b3d27138c3508cc5d825bb);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10808), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(10812));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10816));
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10820), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10824));
      ((Control) this).Controls.Add((Control) this.c3768da1c9e17b9980d03acca3e5a19a9);
      ((Control) this).Controls.Add((Control) this.c4f7923b753673b9ed6ba494072ddfc60);
      ((Control) this).Controls.Add((Control) this.cdcac4e94628a385a08e4e7c77a84487c);
      ((Control) this).Controls.Add((Control) this.cbf64a879ae2aa334872c401083f6135e);
      ((Control) this).Controls.Add((Control) this.c043655c49351198d53937bceaedc9259);
      ((Control) this).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((RadFormControlBase) this).set_FormBorderStyle((FormBorderStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10828));
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16620);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10832) != 0);
      this.set_ShowIcon(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10836) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10840);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16631);
      ((Form) this).FormClosing += new FormClosingEventHandler(this.c86d4f48c6888f128ea89c29edc8a9aec);
      ((Form) this).Load += new EventHandler(this.c5a9236f6f28eb5fdcc94a3cc9e0add54);
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.c043655c49351198d53937bceaedc9259).EndInit();
      ((ISupportInitialize) this.cbf64a879ae2aa334872c401083f6135e).EndInit();
      ((ISupportInitialize) this.cdcac4e94628a385a08e4e7c77a84487c).EndInit();
      ((ISupportInitialize) this.c4f7923b753673b9ed6ba494072ddfc60).EndInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(10844) != 0);
      ((Control) this).PerformLayout();
    }
  }
}
