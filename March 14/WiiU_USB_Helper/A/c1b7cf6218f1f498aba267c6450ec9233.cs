// Decompiled with JetBrains decompiler
// Type: A.c1b7cf6218f1f498aba267c6450ec9233
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Microsoft.VisualBasic.Devices;
using Microsoft.WindowsAPICodePack.Taskbar;
using NusHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using WIIU_Downloader.Forms;
using WIIU_Downloader.Properties;

namespace A
{
  public class c1b7cf6218f1f498aba267c6450ec9233 : RadForm
  {
    private static string cbcdc1c9bf8b0cdf7ffca04e9093f518e = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(Environment.GetFolderPath((Environment.SpecialFolder) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19578)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34805));
    private const string ca338ce53f4b4b235be6c8b2d0bc1f371 = "Powered by Willzor's wiiuusbhelper.com (No Wii U found, please launch Wii U USB Helper Transfer Tool)";
    private const string c061fec7d759fe617820059cf68fc6958 = "Powered by Willzor's wiiuusbhelper.com (Connected to your Wii U!)";
    private readonly ListViewDataItemGroup c345b87dcdd353817ec1c2dcc203013dd;
    private readonly ListViewDataItemGroup cd41603f532612b3c4db58836b4123799;
    private readonly ListViewDataItemGroup c372877fe2d9144e1cb18b2595dc22d35;
    private readonly ListViewDataItemGroup cff1795ccc74a7799df34e56a77438ae5;
    private c495b5dc2a5615c018cbf60b86f239eff cf03615c721382f9adb018993489259dd;
    private c2e2f19e8cde9983e4129b4a047c9f5c6 cbd687f998e72be3a53e9ec30b343fc9f;
    private bool cc22795a3b7f696da1cccaeeed1defe68;
    private bool c76571b1a21c9b1e3056dd0f0d80a9904;
    private bool c66999e5a68a24c16cb0de28ab6e00616;
    private bool c2470a1761b7a4b98e303cce88a107056;
    private bool c1c0a981ac1bdbf0aa08a2a0e2f51b1d9;
    private volatile bool ce80e9c4fe52e3d87d4027237a6cc9bb1;
    private IPAddress ca5aed60c2dab3ff1d5478c9ff4d2e495;
    private DateTime c57c5f34001f875aedca31488d7c223d5;
    private const int c7603ac6f45a5ae9c0ce737414e4971dc = 4000;
    private DriveInfo c42224d31ee8c98989a38799893782473;
    private IContainer ce2dde71ac55aad4a9ce23a50ce61cd89;
    private RadButton cf8a1dc8cf7f73143ea81640d7645c738;
    private RadTextBox cef99ac773757daa1842ee58c7914a0cc;
    private RadListView ced13435d37c83d5695f389153255d7aa;
    private OpenFileDialog c2399b7113e731f78fc41e13b97230ba2;
    private RadButton ca649489ce70abf72060d3b333298ed77;
    private RadButton ce5de00809f1e6aab265b64623d9bc1a5;
    private RadButton c4f9790e49b5c17eba6614a7824f1741c;
    private RadLabel c544236c90282c9157c1c7d7d9ff1369c;
    private RadListView c80abb9b1c6ac93efa1bec9b52c6e0411;
    private RadLabel c3aec1f92fc33a551b592c8b2a7adf9ec;
    private RadLabel cef22dcb29373b4f99e89eb28166e5dc2;
    private PictureBox c0c0e712d5ca94f2910e3ec339b2e600f;
    private RadLabel c8af15fc87ff7fad3b7d70b37794c0516;
    private RadButton c8c95b6e3f74e541d66aa845a751279d2;
    private RadGroupBox c799de9bbe8c05dd37f1ae092015d68e1;
    private RadCheckBox c6e68d4163e92bbc6a33bc1e07bf15a4f;
    private RadCheckBox c62f555309ebbf190dea30e5a84cef1bf;
    private RadGroupBox c80b1c299c05614f9c782a38b86c99494;
    private RadLabel c7ab9d9b723e77867834f5b804c1e8d84;
    private RadButton c16be2b426e8d997c5d2b8f1d3becf90b;
    private RadProgressBar cf7bf7ed27e5378895056f9c4e22fa991;
    private RadListView cbc2eee5df02616fd21fbc91bc233cdcd;
    private RadLabel ca5a2b6669f9034e5fc384b9781cd6dd6;
    private PictureBox cc5109af75315520586ca50d6cd84c973;
    private PictureBox ccd11edb9d36850a5cccf6849cebf8790;
    private PictureBox c0c519a92c14db391cc60009c355f6c77;
    private PictureBox c9828af810645b7cadbb5e7f90ebdc726;
    private RadLabel c738f1dd7afbbfdc20629834298bed929;
    private RadLabel c659877bdbb8d30820909c7b85d4f6330;
    private RadGroupBox c8827d4c0d7431a9890c547ec78a2c02c;
    private RadButton c089f82a5bb56d907790079762415ad00;
    private RadButton c1f709ff5165e5433056bda30bb571911;
    private RadButton c9c662a4a0b9d44555b1f70db28046f61;
    private RadGroupBox c0b6ff62997904dd44189c4cb17f2ab15;
    private RadLabel c743d2a65362475553a562cf35b254c43;
    private RadLabel c3a32d8bd5fe0b6b703d373c8ec023149;
    private RadLabel c207af470f351635895849de23ece3abc;
    private RadLabel ced6aa7f9911c4707f69ec112a4e51672;
    private RadLabel c489dec79b6c4a36ad71b2dd683ba4003;
    private RadLabel c0bc74edb9773f357b639b398786841b3;
    private RadLabel cdf03a2ca811ef49688b58b7e317a430a;
    private RadLabel ce940872bf2d542451e120044788d9340;
    private RadGroupBox c4f28cce9069ce7d56aa80dce66bd91fc;
    private RadLabel c5539dab8a40e8d2e2a7b970e134631c8;
    private RadProgressBar c50c3a23f9473947fa39e14b6b066f539;
    private RadCheckBox c02f822b4a13df9d2c2d9666d3986f346;
    private RadLabel cfa8badb30bc978147487352167d51546;
    private RadLabel cee9946355c6a614ff90b875d32801e38;
    private RadButton c139823df8e929f346d6de8a9db1cae22;
    private RadLabel c05e1ef1d0f2e5250a57c757370b74d83;
    private RadLabel c713a3cd0f5b5e9ff3d443ae80f12e3c8;
    private RadLabel c38925728235576f0c42cd968bde792d6;
    private RadLabel cba34b2a0111f6e5bc303375f968bc295;
    private Label c0aaf89283992def05decf8054f449068;
    private RadGroupBox cd21917de552da0d5fa4c6079cd71111f;
    private RadLabel c73cd2a39bc535b70ef0ec0e9f35ddb8d;
    private RadProgressBar c38668e2d3dc450be2fe10e8cdead5a82;
    private RadDock cb5983a9ef6bb031c7f34108a205a5729;
    private ToolWindow c44e1112bbc33afd80a87709982a149c4;
    private DocumentContainer c6f51d70787b53494b9f2a90f93e5091c;
    private ToolWindow cf6bb2c04c0ce1a4090efd4990bc2a4d6;
    private RadPanel cf273feb18353b8a5aca9b1d1f46844c6;
    private ToolWindow c48844a2ef256637729bbfeba6c14b1ba;
    private DocumentTabStrip cfda0f7e74c13d6b7f59b7c808dd15331;
    private RadGroupBox c39e7e88f29f2018d9aa6c123a5da05b9;
    private ToolWindow c28c4210040b2b3298484f4b1697ed477;
    private RadGroupBox cddad6496d4e1c285617512daf16ee740;
    private ToolWindow ccf9a1c650ea674b5d9aff1def6334db2;
    private RadPanel cb6204fff3792b968130bf39d7e003531;
    private RadButton c2ccfe80606082cc7f5920727b308bf4d;
    private RadButton c0b71e1da7d09a3789bead9e0ff8feda4;
    private RadButton ce2e62cad203b8927cba774d40cc26e1e;
    private RadButton c414a01a9d1ea6f9447f9d5fee7291bd3;
    private RadButton c8d4d0749ecd032b3b3c0ef4542ed6d97;
    private ToolWindow cf18cb5dad0d928f1718d2705e894530d;
    private RadPanel ca17c92fca2120e58e5f8f7c1e444d324;
    private RadButton c7970189ca187b55d3e75631f17e4b67c;
    private WebBrowser c714cda224c0867b81d88c3a87f7b805d;
    private RadGroupBox cbb44104e6cbbb2680035694332b80a01;
    private RadDock c2769778d069bafd899ea27ebc8b3b6f7;
    private ToolWindow ce4834f41a2d4bf23a4afa6097bd2e65a;
    private DocumentContainer c830db343ebd6db124b1b541a729f89ad;
    private DocumentTabStrip c9c9e7026dfacf9cea6739b2eb22bb1b0;
    private ToolWindow c3f18d02c9bc1b341ea22f160d501e795;
    private ToolWindow c7c2ca4c94e8d95132cb789b411fcc27b;
    private RadGroupBox c8feaaff2cfc11c5e9956aac64eb58b35;
    private RadButton c357bfd7fc69acf74548222098fb25669;
    private RadButton c2847a413b553d4c7de02d6550eafde3c;
    private RadGroupBox cc823a5ecc3a0639558b6b92439679149;
    private RadButton c7730aeebdbd664b38e5f8bbc1437a2c2;
    private RadButton c7a8633bba80a50b81c114da3ab992208;
    private RadSplitContainer cae3beaf3bc9f066d134288b1cc6a2ab6;
    private ToolTabStrip c5b062d1e6fbb1c9186310faefca6b2fa;
    private ToolTabStrip c0185dca1f25fc3c2cc62921a9050d18f;
    private ToolTabStrip c91e9024abe6202a1b65e9677c8b82412;
    private ToolWindow cc1bf6cfe06c7e943de81a144b94d908c;
    private RadGroupBox ccc252ce44a8e5cefbd8cd949ece215e5;
    private RadLabel cd036f2b2868b103e71bd7b4fbe25a603;
    private RadButton c3768da1c9e17b9980d03acca3e5a19a9;
    private RadLabel c14d5ba9c8d3dcbc17433b50217356b5a;
    private RadListView c0ebc97b073a7d0dba554313d3f62139d;
    private RadLabel c0b8c323aae75c040334498c5efcb96f4;
    private RadButton ce1a2609d728bf5b02ebcce5d0d03abac;
    private ToolTabStrip ceb25ec87df1d957dbabc08d3338713dd;
    private CheckBox c39e3350d94cbb712a33276b179006506;
    private RadButton cba8de59d8af22ab73fe624faad5b1c0d;
    private RadButton c4533e25263801abd1cc5792ca28f28c1;
    private CheckBox ce9d74c4a67920ea005ae0e9c3e550195;
    private CheckBox c6e10857a44dfe29229689f6f14eb8736;
    private CheckBox cb09f0c811e9c104f30d9bdb57f5e4472;
    private RadContextMenu cede9e5be54b12de354ccc761ad4fc4a1;
    private RadMenuItem cb2e65fdb3dbc553302280f07b5ad39c6;
    private RadMenuItem ccf6a2ae401b49d2712eabf1f3d73b706;
    private RadMenuItem c30f1c4d08b6e85057a60708401020f66;
    private RadMenuItem c8c72e702b57548c1958f16299f426252;
    private RadMenuItem c1b66238ca4e5fb0c40c7756554ee7321;
    private RadMenuItem c6651d3ca26654e3b924967485e5cd357;
    private RadButton c2d265ee1256f88eddf3baa3887d2c91d;
    private RadTextBoxControl c74ae2563a72edeef646bba38ebdd0ce8;
    private ToolWindow c78b2def3d06d6b5a4d21846a0d787eee;
    private Label cc9d166d46812474925d4574ed649e971;
    private PictureBox c20125c1e72d687c9063a72becb2b139c;
    private Label c91d2e830a71a1148124277bd799d126c;
    private RadProgressBar cbd1041f8be005d147b5e93849f76b59d;
    private RadListView c8692650f24b3012c232c930089f0258c;
    private Label c66c0f7f85b853fc9a2258f078c613edd;
    private Label cfd811e4de46986ea5fd1a90c4e25b17a;
    private RadListView c2f140be112f4d6280c6d8b3f548ccb8a;
    private RadLabel c6c17c59699d09a6deff3affeead81921;
    private RadLabel c9e453c2e79f4fc55124ccb1fd3603902;
    private ToolWindow c24e3e0bc5926188969ef6ed35bca3f48;
    private RadListView cdff096b93bcf8895ef6ce933c902940d;
    private RadLabel ce0e7fe2dec7b73af921b84452e573154;
    private RadGroupBox ceb0fc808ac3cea091a2bf8db3cf9f1c5;
    private RadButton c6b7d903aa965d47e2f39fa93f9aa3134;
    private System.Windows.Forms.Timer c11eb1c4d76d9d3f27d002b636b540897;
    private RadButton c264210f8880117c5d13694e2bdf33135;
    private Label c2b75e78467422d822cfdace19fced8b4;
    private RadListView c00cbac6f52b66fe9075f2e2d10af540a;
    private System.Windows.Forms.Timer c0edd068ee51dc000d1e5630da9f32887;
    private RadCheckBox c68b8f2723032c53a16a489755afa9f3d;
    private RadButton ceb095b069074eddeeb1ad92edcc4ec95;
    private RadMenuItem c4587b5b95b0f054ed931ca93214ad4b4;
    private RadMenuItem c682b9a9146723389d400ba86d9cc4e13;
    private RadButton c99759b9e421322e16d5c36b476bb666f;
    private RadCheckBox c3ecd11fc9291e6c3176323b62baedac8;
    private RadCheckBox c29c9611cee072e30c8d766c88964ac2b;
    private ToolWindow c89ff289eea7f33d04edb7f11d666c144;
    private RadCheckedListBox ca9c68e79493f9e09d605914c6cd6edd5;
    private RadButton c51175a4a3b6b11c0eee765ad7effd076;
    private RadButton cf152d3e6147dc4e0112582d0f6097ce3;
    private RadGroupBox cbe00b03ee2347f9756848babd446e36c;
    private CheckBox c4562184f7a172fc18d58e50d7047938d;
    private CheckBox cf582d9fa2e47e4f8707ea4db5c09db97;
    private CheckBox c290ca0dbd67a1dd201c0b196fec00bc4;
    private RadGroupBox c422900b304a63407dfa05f2f233b004e;
    private RadLabel c2e00ce37891acd500b28d73704f69b35;
    private RadSpinEditor c560a6e04507a6b91381df70d8ba999e6;
    private RadCheckBox c93a99fb1c1183d9875099b634bd270a6;
    private RadLabel c97c4e0fb1efa8799a0b6c47d1e86000e;
    private System.Windows.Forms.Timer cee1c0c7304084325bbf547e952525117;
    private RadButton cc4a40b1385deb54376434c71c8e76b81;
    private RadButton c6c840f966d621484314eb45e43e34565;
    private RadButton c101d57e697d17803583217bbb889b590;
    private ToolTabStrip c453acc1433bd9ed8673278dbdd4bee00;
    private ToolWindow c3ec3e29a74c0f512f2935f1207d1a895;
    private RadLabel c03788d88eb825d0e4375ff91a470e965;
    private ToolWindow c2f75881f4e3a569756004ecd1f3c8da3;
    private RadGroupBox ca380231837e2eafdb42e81f47a24d226;
    private RadButton c4fda90ba27d8ac9ff70115293efc7b38;
    private RadTextBox c0770534b75ebeea0c4e695dfdb7677d0;
    private RadTextBox c67131d5ebad4559120841e7d6afbf050;
    private RadLabel cadd2602239e2a87754cb1203ec048ce7;
    private RadLabel cf9e2786454699a4c03d6a769f423882e;
    private RadTextBox ceb96360e1866456699fd2a748e058db6;
    private RadLabel c1b58d84e7b46cb77f175ef1b94421baf;
    private DockWindowPlaceholder c53cbb17a05b0cbad7d563b1e9b75cd53;
    private DockWindowPlaceholder c8c4139dc5bdf8baad6014fa6ae28608e;
    private RadButton cd8a4426aac26fd0166c7b44e9f731455;
    private RadLabel cded9ed150a9ac47f6949a468fac193a6;
    private RadLabel c340f7ccf001170543c57999fd96d4b38;
    private RadGroupBox c101a585c2bc6dfb0b62b86bd680ce2b2;
    private RadGroupBox c780e6034938558087f1ea7ad59d1d853;
    private RadLabel c86ce7f867a560282470decd22cec0860;
    private RadLabel cfda9a98a11ebdc24a447457307015f17;
    private RadLabel c979c76a51f33de27b2440305fd60fd38;
    private RadLabel ce55c0c71a3136c1bba91d488db23a660;
    private RadLabel cb92ad5a7459656fe7b6fd86ff472b5c5;
    private RadLabel c22d04ce1034d647a95d30b01a54768c4;
    private RadLabel c77ab4cca03476e6662d72295ae2a18d0;
    private RadButton c28cccb4bc1305f639acf2d457aeedad8;
    private PictureBox c4ffe800d52986b27d66e2886fadad952;
    private RadButton c8e4e933c1082ae051c164f38f5d1cb14;
    private ToolWindow c969e7ecbcc3e5f2b58f9abd63fd43607;
    private RadButton cf1bbdaba14013386fcabe835941101b9;
    private RadLabel c58eefb73a902712c6fd5929e97bd4b97;
    private DateTimePicker c761bc48a0ac5352d2a79834b62d8e9c7;

    private static string OutputPath { get; } = Path.Combine(Settings.Default.Path, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1277));

    private bool CurrentlyDownloading { get; set; }

    private int IndexGameCurrentlyDownloaded { get; set; }

    private List<Platform> Platforms { get; set; }

    private WebProxy Proxy { get; set; }

    private cce1cf1e0b6971ed6f7ef86a83b0959b6 SelectedGame { get; set; }

    private List<cba6aa8f767d2e8dfbca2d43d7148c173> TitlesToCopy { get; }

    private List<cba6aa8f767d2e8dfbca2d43d7148c173> TitlesToDownload { get; }

    private ca5f1a19f078eb23ced887c232d971b13 frmWait { get; set; }

    public c1b7cf6218f1f498aba267c6450ec9233()
    {
      base.\u002Ector();
      if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8320)))
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.\u002Ector);
            }
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34752));
            System.Windows.Forms.Application.Restart();
            break;
        }
      }
      this.cfb5cf413352ed4044535eb4a62d2e98f();
      ((Form) this).WindowState = (FormWindowState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19562);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19566);
      if (cd1319eedebbda8d27578756acdafa044.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.WindowPosition, Rectangle.Empty))
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
          default:
            if (this.cac3854ffc00bdbcb3343f5d4bec4796d(Settings.Default.WindowPosition))
            {
label_8:
              switch (1)
              {
                case 0:
                  goto label_8;
                default:
                  ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19570);
                  ((Form) this).DesktopBounds = Settings.Default.WindowPosition;
                  ((Form) this).WindowState = Settings.Default.WindowState;
                  goto label_11;
              }
            }
            else
              break;
        }
      }
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19574);
      ((Form) this).Size = Settings.Default.WindowPosition.Size;
label_11:
      RadDock cb5983a9ef6bb031c7f34108a205a5729 = this.cb5983a9ef6bb031c7f34108a205a5729;
      // ISSUE: reference to a compiler-generated field
      FloatingWindowEventHandler windowEventHandler1 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c6f21967be2e2bf8983a0ab8f6f02fc46;
      if (windowEventHandler1 == null)
      {
label_12:
        switch (5)
        {
          case 0:
            goto label_12;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            windowEventHandler1 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c6f21967be2e2bf8983a0ab8f6f02fc46 = new FloatingWindowEventHandler((object) c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38, __methodptr(cf7e1cb8311724c73c4e8d43fdee602f1));
            break;
        }
      }
      cb5983a9ef6bb031c7f34108a205a5729.add_FloatingWindowCreated(windowEventHandler1);
      RadDock c2769778d069bafd899ea27ebc8b3b6f7 = this.c2769778d069bafd899ea27ebc8b3b6f7;
      // ISSUE: reference to a compiler-generated field
      FloatingWindowEventHandler windowEventHandler2 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.ce4fba04837d29717df1c1b88514a2b08;
      if (windowEventHandler2 == null)
      {
label_15:
        switch (4)
        {
          case 0:
            goto label_15;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            windowEventHandler2 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.ce4fba04837d29717df1c1b88514a2b08 = new FloatingWindowEventHandler((object) c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38, __methodptr(cc678674d34fa4a4749c66e6e93dbd870));
            break;
        }
      }
      c2769778d069bafd899ea27ebc8b3b6f7.add_FloatingWindowCreated(windowEventHandler2);
      this.c9828af810645b7cadbb5e7f90ebdc726.MouseDoubleClick += new MouseEventHandler(c1b7cf6218f1f498aba267c6450ec9233.c5b778d749271b9b59aec519aa5213607);
      this.c0c519a92c14db391cc60009c355f6c77.MouseDoubleClick += new MouseEventHandler(c1b7cf6218f1f498aba267c6450ec9233.c5b778d749271b9b59aec519aa5213607);
      this.ccd11edb9d36850a5cccf6849cebf8790.MouseDoubleClick += new MouseEventHandler(c1b7cf6218f1f498aba267c6450ec9233.c5b778d749271b9b59aec519aa5213607);
      System.Windows.Forms.Application.Idle += new EventHandler(this.c3517bb571e42308785461c40df02c473);
    }

    private bool cac3854ffc00bdbcb3343f5d4bec4796d(Rectangle c03f1b543f7f695f66fbf410afb44e80d)
    {
      Screen[] allScreens = Screen.AllScreens;
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12084);
      while (index < (int) ce736a80887e29adc3acc71bfb416f8b5.c572aba370be49804cbdb0b35312bea94(allScreens))
      {
        if (allScreens[index].WorkingArea.IntersectsWith(c03f1b543f7f695f66fbf410afb44e80d))
        {
label_2:
          switch (3)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cac3854ffc00bdbcb3343f5d4bec4796d);
              }
              return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12088) != 0;
          }
        }
        else
          index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12092);
      }
label_8:
      switch (5)
      {
        case 0:
          goto label_8;
        default:
          return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12096) != 0;
      }
    }

    protected virtual void OnClosed(EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).OnClosed(e));
      FormWindowState windowState = ((Form) this).WindowState;
      if (windowState != FormWindowState.Normal)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.OnClosed);
            }
            if (windowState == (FormWindowState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12100))
            {
label_5:
              switch (6)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              Settings.Default.WindowState = (FormWindowState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12104);
              goto label_8;
            }
        }
      }
      Settings.Default.WindowState = ((Form) this).WindowState;
label_8:
      ((Control) this).Visible = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12108) != 0;
      ((Form) this).WindowState = (FormWindowState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12112);
      Settings.Default.WindowPosition = ((Form) this).DesktopBounds;
      Settings.Default.Save();
    }

    private static Color cb8c81e3b10f664ccf79099edfbe9a77b(cba6aa8f767d2e8dfbca2d43d7148c173 c89cbac13be511053120093fce8049319)
    {
      if (c89cbac13be511053120093fce8049319.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12116))
        return Color.Green;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cb8c81e3b10f664ccf79099edfbe9a77b);
          }
          if (c89cbac13be511053120093fce8049319.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12120))
            return Color.DarkOrange;
label_5:
          switch (7)
          {
            case 0:
              goto label_5;
            default:
              if (ThemeResolutionService.get_ApplicationThemeName().Contains(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19013)))
                return Color.White;
label_7:
              switch (2)
              {
                case 0:
                  goto label_7;
                default:
                  return Color.Black;
              }
          }
      }
    }

    private static void c2a51f84d855205a3cb0bad2cdcac5eb4(cce1cf1e0b6971ed6f7ef86a83b0959b6 c3cab5319dc016deb050deb101e927b2f)
    {
      if (c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.Image == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c2a51f84d855205a3cb0bad2cdcac5eb4);
            break;
        }
      }
      else
      {
        if (c3cab5319dc016deb050deb101e927b2f.c2485b5906efc569b1c867e5c900b2e4e)
        {
label_5:
          switch (7)
          {
            case 0:
              goto label_5;
            default:
              c29f686fe3fab48150f240b6f3fa06309 cee7644d811ec48c3e6a2526d09e8524b = c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b;
              Image image;
              if (c3cab5319dc016deb050deb101e927b2f.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>().c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12124))
              {
label_7:
                switch (7)
                {
                  case 0:
                    goto label_7;
                  default:
                    image = c1b7cf6218f1f498aba267c6450ec9233.c0b11082f73f7ecc0ab650a4bf24cac50(c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.Image, (Image) c27603360ccc8374975348defb9eee9fc.hasUpdate);
                    break;
                }
              }
              else
                image = c1b7cf6218f1f498aba267c6450ec9233.c0b11082f73f7ecc0ab650a4bf24cac50(c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.Image, (Image) c27603360ccc8374975348defb9eee9fc.hasUpdateOk);
              cee7644d811ec48c3e6a2526d09e8524b.Image = image;
              break;
          }
        }
        if (c3cab5319dc016deb050deb101e927b2f.cf062de84cde10d9e953c8091a0e1b42b)
        {
label_12:
          switch (2)
          {
            case 0:
              goto label_12;
            default:
              c29f686fe3fab48150f240b6f3fa06309 cee7644d811ec48c3e6a2526d09e8524b = c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b;
              Image image;
              if (c3cab5319dc016deb050deb101e927b2f.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12128))
              {
label_14:
                switch (2)
                {
                  case 0:
                    goto label_14;
                  default:
                    image = c1b7cf6218f1f498aba267c6450ec9233.c0b11082f73f7ecc0ab650a4bf24cac50(c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.Image, (Image) c27603360ccc8374975348defb9eee9fc.hasDLC);
                    break;
                }
              }
              else
                image = c1b7cf6218f1f498aba267c6450ec9233.c0b11082f73f7ecc0ab650a4bf24cac50(c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.Image, (Image) c27603360ccc8374975348defb9eee9fc.hasDLCOk);
              cee7644d811ec48c3e6a2526d09e8524b.Image = image;
              break;
          }
        }
        c29f686fe3fab48150f240b6f3fa06309 cee7644d811ec48c3e6a2526d09e8524b1 = c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b;
        Image image1 = c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.Image;
        Bitmap bitmap;
        if (c3cab5319dc016deb050deb101e927b2f.System != caff792dac5a5e2f17b0e81e59bba386d.cd640a3b52f646cee482c685f1e6d0f8b)
        {
label_19:
          switch (5)
          {
            case 0:
              goto label_19;
            default:
              bitmap = c27603360ccc8374975348defb9eee9fc.tagWiiU;
              break;
          }
        }
        else
          bitmap = c27603360ccc8374975348defb9eee9fc.tag3ds;
        Image image2 = c1b7cf6218f1f498aba267c6450ec9233.c0b11082f73f7ecc0ab650a4bf24cac50(image1, (Image) bitmap);
        cee7644d811ec48c3e6a2526d09e8524b1.Image = image2;
      }
    }

    private static bool ca6def4aca61451eb9bcd4b0af24cfb38(string cd882bdfcde69377e6616f3b1f8b305c6)
    {
      try
      {
        Directory.GetAccessControl(cd882bdfcde69377e6616f3b1f8b305c6);
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12132) != 0;
      }
      catch (UnauthorizedAccessException ex)
      {
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12136) != 0;
      }
    }

    private static void c6122b55a0f5768d890cfe4cf2c0b6543(string cd882bdfcde69377e6616f3b1f8b305c6)
    {
      if (!System.IO.File.Exists(cd882bdfcde69377e6616f3b1f8b305c6))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c6122b55a0f5768d890cfe4cf2c0b6543);
          }
          System.IO.File.Delete(cd882bdfcde69377e6616f3b1f8b305c6);
          break;
      }
    }

    private static void cc11d49a7901374e719632513e58f6f0a()
    {
      try
      {
        long binary = c179aeb93132d5f039d0cd3a1439d3823.cc8e287d5350b43026d33bb80beb131a0((object) WebRequest.CreateHttp(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19022)).GetResponse()).LastModified.ToBinary();
        if (binary == Settings.Default.LastNewsDate)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cc11d49a7901374e719632513e58f6f0a);
              break;
          }
        }
        else
        {
          Settings.Default.LastNewsDate = binary;
          Settings.Default.Save();
          int num = (int) ((Form) new cdbc99a48928ffee3d676afdba59fd654()).ShowDialog();
        }
      }
      catch
      {
      }
    }

    private static bool ca46a22c647de151513cba1115840f945(string cd882bdfcde69377e6616f3b1f8b305c6)
    {
      if (!string.IsNullOrEmpty(cd882bdfcde69377e6616f3b1f8b305c6))
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945);
            }
            if (Directory.Exists(cd882bdfcde69377e6616f3b1f8b305c6))
            {
label_5:
              switch (3)
              {
                case 0:
                  goto label_5;
                default:
                  return c1b7cf6218f1f498aba267c6450ec9233.ca6def4aca61451eb9bcd4b0af24cfb38(cd882bdfcde69377e6616f3b1f8b305c6);
              }
            }
            else
              break;
        }
      }
      return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12140) != 0;
    }

    private static bool c07a06fae0e63ec59953e00dc6e46e231(string c7927af27b9cde3902e98e8d96c5a3200)
    {
      try
      {
        return cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(c7927af27b9cde3902e98e8d96c5a3200.Substring(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12144), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12148)), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19099));
      }
      catch
      {
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12152) != 0;
      }
    }

    private static Image c0b11082f73f7ecc0ab650a4bf24cac50(Image c935d4b283e27bbc99f81d436bbc53258, Image c8faa0fd2e9b7e57750badf6ae1bd33c4)
    {
      Bitmap bitmap = new Bitmap(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12156), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12160));
      try
      {
        Graphics graphics = Graphics.FromImage((Image) bitmap);
        try
        {
          graphics.InterpolationMode = (InterpolationMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12164);
          graphics.DrawImage(c935d4b283e27bbc99f81d436bbc53258, new PointF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(12168), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(12172)));
          graphics.DrawImage(c8faa0fd2e9b7e57750badf6ae1bd33c4, new PointF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(12176), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(12180)));
          graphics.Save();
        }
        finally
        {
          if (graphics != null)
          {
label_4:
            switch (5)
            {
              case 0:
                goto label_4;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c0b11082f73f7ecc0ab650a4bf24cac50);
                }
                graphics.Dispose();
                break;
            }
          }
        }
        try
        {
          MemoryStream memoryStream = new MemoryStream();
          bitmap.Save((Stream) memoryStream, ImageFormat.Bmp);
          return Image.FromStream((Stream) memoryStream);
        }
        catch
        {
          return c4a6a533bd83fb141986de6f6a05d666d.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        }
      }
      finally
      {
        if (bitmap != null)
        {
label_12:
          switch (6)
          {
            case 0:
              goto label_12;
            default:
              bitmap.Dispose();
              break;
          }
        }
      }
    }

    private void c08dac6046107bebae64a6a51d0d5c9fd()
    {
      if (c745d89fddb05a30e8ef1babd26557977.c1df95097ffa57d753c5fe1353cf65e86(DateTime.Now, this.c57c5f34001f875aedca31488d7c223d5).TotalMilliseconds > cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(12184))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c08dac6046107bebae64a6a51d0d5c9fd);
            }
            this.ca5aed60c2dab3ff1d5478c9ff4d2e495 = ce43cb821ac290a500299c4cb4a0c3882.c20c00b8e97bb4c0fb2b7ac6facf98b91;
            break;
        }
      }
      RadLabel c03788d88eb825d0e4375ff91a470e965 = this.c03788d88eb825d0e4375ff91a470e965;
      string str;
      if (this.ca5aed60c2dab3ff1d5478c9ff4d2e495 != null)
      {
label_6:
        switch (4)
        {
          case 0:
            goto label_6;
          default:
            str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19108);
            break;
        }
      }
      else
        str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19240);
      ((Control) c03788d88eb825d0e4375ff91a470e965).Text = str;
    }

    private static void c5b778d749271b9b59aec519aa5213607(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      PictureBox pictureBox = c00ca4200eb9a71ea3acea5565a8b3017.cc8e287d5350b43026d33bb80beb131a0(c5382ad5461e274fda51b358802fc3910);
      if (pictureBox.Image == null)
        return;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c5b778d749271b9b59aec519aa5213607);
          }
          int num = (int) ((Form) new c62da81ddb30b6dbfb000378010a467b6(pictureBox.Image)).ShowDialog();
          break;
      }
    }

    private static bool cc280c8ccf354d2ee7188ab5afd61f109(bool ca7221f21a24b86977a02c71d096349d6)
    {
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
      folderBrowserDialog1.Description = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19444);
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12192);
      folderBrowserDialog1.ShowNewFolderButton = num != 0;
      FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog1;
      while (folderBrowserDialog2.ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12196))
      {
        if (c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(folderBrowserDialog2.SelectedPath))
        {
label_7:
          switch (5)
          {
            case 0:
              goto label_7;
            default:
              Settings.Default.Path = folderBrowserDialog2.SelectedPath;
              Settings.Default.Save();
              return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12204) != 0;
          }
        }
      }
label_2:
      switch (6)
      {
        case 0:
          goto label_2;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cc280c8ccf354d2ee7188ab5afd61f109);
          }
          return (ca7221f21a24b86977a02c71d096349d6 ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12200);
      }
    }

    private static void c88defa97c672d8c577a72a9df2ecf3ac(TimeSpan c90049187e289e3799fa866138e5467c5, RadLabel ce339ec8e4e59ae4d366ecde058dba451)
    {
      RadLabel radLabel = ce339ec8e4e59ae4d366ecde058dba451;
      string str;
      if (c90049187e289e3799fa866138e5467c5.TotalSeconds <= cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(12208))
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c88defa97c672d8c577a72a9df2ecf3ac);
            }
            str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19537);
            break;
        }
      }
      else
        str = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19584), (object) c90049187e289e3799fa866138e5467c5.Hours, (object) c90049187e289e3799fa866138e5467c5.Minutes, (object) c90049187e289e3799fa866138e5467c5.Seconds);
      ((Control) radLabel).Text = str;
    }

    private static void c761cac2dca99bb62b83352a5055d6c08()
    {
      try
      {
        string str = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19625));
        string c33ad1bd311fd4b32b85377e9e15a9d93 = new WebClient().DownloadString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19648));
        SHA256 shA256 = SHA256.Create();
        try
        {
          if (System.IO.File.Exists(str))
          {
label_2:
            switch (1)
            {
              case 0:
                goto label_2;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c761cac2dca99bb62b83352a5055d6c08);
                }
                if (!cdf6c91719eae5a38c64a7fd64afdf5e1.c1df95097ffa57d753c5fe1353cf65e86(Convert.ToBase64String(shA256.ComputeHash(System.IO.File.ReadAllBytes(str))), c33ad1bd311fd4b32b85377e9e15a9d93))
                  return;
label_6:
                switch (2)
                {
                  case 0:
                    goto label_6;
                }
            }
          }
          new WebClient().DownloadFile(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19747), str);
        }
        finally
        {
          if (shA256 != null)
          {
label_10:
            switch (2)
            {
              case 0:
                goto label_10;
              default:
                shA256.Dispose();
                break;
            }
          }
        }
      }
      catch
      {
      }
    }

    private void cd660ef369e4674e4d70b339bf2da51d1(cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319)
    {
      this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319);
      try
      {
        if (c89cbac13be511053120093fce8049319.c2485b5906efc569b1c867e5c900b2e4e)
        {
label_2:
          switch (2)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cd660ef369e4674e4d70b339bf2da51d1);
              }
              if (!this.c80abb9b1c6ac93efa1bec9b52c6e0411.c1de2c5d31ef8b332ef39d04f3d8a5a6c((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>()))
              {
label_6:
                switch (2)
                {
                  case 0:
                    goto label_6;
                  default:
                    if (c89cbac13be511053120093fce8049319.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>().c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12216))
                    {
label_8:
                      switch (1)
                      {
                        case 0:
                          goto label_8;
                        default:
                          if (RadMessageBox.Show(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(19844), (object) c89cbac13be511053120093fce8049319), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20032), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12220)) == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12224))
                          {
label_10:
                            switch (1)
                            {
                              case 0:
                                goto label_10;
                              default:
                                this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>());
                                break;
                            }
                          }
                          else
                            break;
                      }
                    }
                    else
                      break;
                }
              }
              else
                break;
          }
        }
        if (!c89cbac13be511053120093fce8049319.cf062de84cde10d9e953c8091a0e1b42b)
          return;
label_13:
        switch (1)
        {
          case 0:
            goto label_13;
          default:
            if (this.c80abb9b1c6ac93efa1bec9b52c6e0411.c1de2c5d31ef8b332ef39d04f3d8a5a6c((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319.Dlc))
              break;
label_15:
            switch (7)
            {
              case 0:
                goto label_15;
              default:
                if (c89cbac13be511053120093fce8049319.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12228))
                {
label_17:
                  switch (2)
                  {
                    case 0:
                      goto label_17;
                    default:
                      return;
                  }
                }
                else
                {
                  if (RadMessageBox.Show(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20055), (object) c89cbac13be511053120093fce8049319), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20235), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12232)) != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12236))
                    return;
label_20:
                  switch (1)
                  {
                    case 0:
                      goto label_20;
                    default:
                      this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319.Dlc);
                      return;
                  }
                }
            }
        }
      }
      catch
      {
      }
    }

    private ListViewDataItem c7102e7b79712edad16cc7df08327e444(cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319, RadListView cc6435b78a93f22a72c53f47773ba2802)
    {
      ListViewDataItem listViewDataItem1 = new ListViewDataItem((object) c89cbac13be511053120093fce8049319);
      ListViewDataItemGroup viewDataItemGroup = this.c4199b0948a18e6cbed051a872f241ae7(c89cbac13be511053120093fce8049319);
      listViewDataItem1.set_Group(viewDataItemGroup);
      Color color = c1b7cf6218f1f498aba267c6450ec9233.cb8c81e3b10f664ccf79099edfbe9a77b((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319);
      listViewDataItem1.set_ForeColor(color);
      cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c89cbac13be511053120093fce8049319;
      listViewDataItem1.set_Tag((object) cce1cf1e0b6971ed6f7ef86a83b0959b6);
      ListViewDataItem listViewDataItem2 = listViewDataItem1;
      cc6435b78a93f22a72c53f47773ba2802.get_Items().Add(listViewDataItem2);
      listViewDataItem2.set_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12240), (object) c89cbac13be511053120093fce8049319.Name);
      listViewDataItem2.set_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12244), (object) c89cbac13be511053120093fce8049319.Region);
      listViewDataItem2.set_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12248), (object) c89cbac13be511053120093fce8049319.Size);
      listViewDataItem2.set_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12252), (object) c1bbcad09f7d3f69ee1d8850af68486c5.c1df95097ffa57d753c5fe1353cf65e86((object) c89cbac13be511053120093fce8049319.c38dee32ccaa64d9ac65631acafd39f04, (object) c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20252)));
      ListViewDataItem listViewDataItem3 = listViewDataItem2;
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12256);
      string str1;
      if (!c89cbac13be511053120093fce8049319.c2485b5906efc569b1c867e5c900b2e4e)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c7102e7b79712edad16cc7df08327e444);
            }
            str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20255);
            break;
        }
      }
      else
        str1 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20260);
      listViewDataItem3.set_Item(num1, (object) str1);
      ListViewDataItem listViewDataItem4 = listViewDataItem2;
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12260);
      string str2;
      if (!c89cbac13be511053120093fce8049319.cf062de84cde10d9e953c8091a0e1b42b)
      {
label_7:
        switch (5)
        {
          case 0:
            goto label_7;
          default:
            str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20255);
            break;
        }
      }
      else
        str2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20260);
      listViewDataItem4.set_Item(num2, (object) str2);
      return listViewDataItem2;
    }

    private void c9ebdd2bff5f91eb70ae39a82398a3a59(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      if (this.TitlesToCopy.Contains(c36dd98eb0c08ea087627a40c6663c9a8))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c9ebdd2bff5f91eb70ae39a82398a3a59);
            break;
        }
      }
      else
      {
        this.TitlesToCopy.Add(c36dd98eb0c08ea087627a40c6663c9a8);
        ListViewDataItem listViewDataItem = new ListViewDataItem((object) c36dd98eb0c08ea087627a40c6663c9a8);
        cba6aa8f767d2e8dfbca2d43d7148c173 cba6aa8f767d2e8dfbca2d43d7148c173 = c36dd98eb0c08ea087627a40c6663c9a8;
        listViewDataItem.set_Tag((object) cba6aa8f767d2e8dfbca2d43d7148c173);
        this.c0ebc97b073a7d0dba554313d3f62139d.get_Items().Add(listViewDataItem);
        this.c0920b14ec7a66a99cdce1ebbad123147();
      }
    }

    private void ce39b083943b82bec0d4c1cda5219595a(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      if (!this.TitlesToDownload.Contains(c36dd98eb0c08ea087627a40c6663c9a8))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ce39b083943b82bec0d4c1cda5219595a);
            }
            this.TitlesToDownload.Add(c36dd98eb0c08ea087627a40c6663c9a8);
            ListViewDataItem listViewDataItem = new ListViewDataItem((object) c36dd98eb0c08ea087627a40c6663c9a8);
            cba6aa8f767d2e8dfbca2d43d7148c173 cba6aa8f767d2e8dfbca2d43d7148c173 = c36dd98eb0c08ea087627a40c6663c9a8;
            listViewDataItem.set_Tag((object) cba6aa8f767d2e8dfbca2d43d7148c173);
            this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items().Add(listViewDataItem);
            this.c2c99ff079ae47d1aebf76d3b9b2ab83c();
            if (this.CurrentlyDownloading)
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  this.cbd687f998e72be3a53e9ec30b343fc9f.c3a2a56c07789f3efbf5efbd6ef8ea3f5();
                  break;
              }
            }
            this.cce20c4049fbcb70a9f55c7c45157b2cf();
            break;
        }
      }
      if (this.SelectedGame != null)
      {
label_9:
        switch (2)
        {
          case 0:
            goto label_9;
          default:
            if (!this.SelectedGame.cd2d93bc97fb6620c2b12a80a66e62291(c36dd98eb0c08ea087627a40c6663c9a8))
            {
label_11:
              switch (4)
              {
                case 0:
                  goto label_11;
                default:
                  return;
              }
            }
            else
              break;
        }
      }
      if (c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5((object) c36dd98eb0c08ea087627a40c6663c9a8) != null)
      {
label_14:
        switch (4)
        {
          case 0:
            goto label_14;
          default:
            ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12264) != 0;
            break;
        }
      }
      else
      {
        if (cfe3e635f9e08b3ae3599c69d079b1799.cc50e3aad2c922bb7d7e65938629ab7b5((object) c36dd98eb0c08ea087627a40c6663c9a8) == null)
          return;
label_17:
        switch (3)
        {
          case 0:
            goto label_17;
          default:
            ((Control) this.c139823df8e929f346d6de8a9db1cae22).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12268) != 0;
            break;
        }
      }
    }

    private ListViewDataItemGroup c4199b0948a18e6cbed051a872f241ae7(cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319)
    {
      if (c89cbac13be511053120093fce8049319.cd61c5f51f587495941f329dc6bffec54)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c4199b0948a18e6cbed051a872f241ae7);
            }
            return this.c372877fe2d9144e1cb18b2595dc22d35;
        }
      }
      else
      {
        switch (c89cbac13be511053120093fce8049319.c7adb0b831ae9d44c1bc321f4993f8d5d)
        {
          case cb48a6650cad6d81c80da89dfe58b703a.c83db08052b4defd7f123a5703adcaf4a:
            return this.cff1795ccc74a7799df34e56a77438ae5;
          case cb48a6650cad6d81c80da89dfe58b703a.ca4635737d0de96678db48b9d01ce5b3a:
            return this.cd41603f532612b3c4db58836b4123799;
          case cb48a6650cad6d81c80da89dfe58b703a.ccbbe095bbcb593f1ae7554d054de8de1:
            return this.c345b87dcdd353817ec1c2dcc203013dd;
          default:
            return this.cff1795ccc74a7799df34e56a77438ae5;
        }
      }
    }

    private void cd0c9263fcd991c77542f5cf4fbd60b91(object c5382ad5461e274fda51b358802fc3910, StateChangedEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      if (cccf482ee689904a1a8630dac14e0a6a0.get_ToggleState() == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12272))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cd0c9263fcd991c77542f5cf4fbd60b91);
            }
            DriveInfo driveInfo = cce1cf1e0b6971ed6f7ef86a83b0959b6.ca075787b36b06b9d1b25036d8fd4559d(new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12276)));
            if (driveInfo == null)
            {
label_5:
              switch (5)
              {
                case 0:
                  goto label_5;
                default:
                  this.c3ecd11fc9291e6c3176323b62baedac8.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12280) != 0);
                  return;
              }
            }
            else
            {
              this.c42224d31ee8c98989a38799893782473 = driveInfo;
              break;
            }
        }
      }
      else
        this.c42224d31ee8c98989a38799893782473 = cf387d9495cc5b9941fba94edf097b32b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    private void c2491a646585438568668fb0ad065076f(object c5382ad5461e274fda51b358802fc3910, StateChangedEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Enabled = this.c93a99fb1c1183d9875099b634bd270a6.get_Checked();
    }

    private void c720c4ba238d63954d20328054195c8ed(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.cc22795a3b7f696da1cccaeeed1defe68)
        return;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c720c4ba238d63954d20328054195c8ed);
          }
          this.c6450bee67c17aaeb724d7d72619d430e();
          break;
      }
    }

    private void cb5ff5cf4fa3c141ce748b8ed4ad5dd29(object c5382ad5461e274fda51b358802fc3910, StateChangedEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      if (this.c62f555309ebbf190dea30e5a84cef1bf.get_Checked())
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cb5ff5cf4fa3c141ce748b8ed4ad5dd29);
            }
            this.c02f822b4a13df9d2c2d9666d3986f346.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12284) != 0);
            this.c02f822b4a13df9d2c2d9666d3986f346.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12288) != 0);
            this.cf03615c721382f9adb018993489259dd = (c495b5dc2a5615c018cbf60b86f239eff) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12292);
            break;
        }
      }
      else
        this.cf03615c721382f9adb018993489259dd = (c495b5dc2a5615c018cbf60b86f239eff) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12296);
    }

    private void c4c90044666ad7a16ad6a190754bfda15(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.cc22795a3b7f696da1cccaeeed1defe68)
        return;
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c4c90044666ad7a16ad6a190754bfda15);
          }
          this.c6450bee67c17aaeb724d7d72619d430e();
          break;
      }
    }

    private void ca57b7cb89c01c4290728107c653aab2d(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c88d834acb00e4a8edcf574571764dde9(this.SelectedGame, this.c39e3350d94cbb712a33276b179006506.Checked, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12300) != 0);
    }

    private void c31d6db800cdafd2057d06118b91113b8(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c6450bee67c17aaeb724d7d72619d430e();
    }

    private void c71d6bd36bb677ebf43d09757e4a0a479(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c6450bee67c17aaeb724d7d72619d430e();
    }

    private void cad2910925cb864d1ece1a497da80194c(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c6450bee67c17aaeb724d7d72619d430e();
    }

    private void cdaf14beb5078d3d484015916b39121af(object c5382ad5461e274fda51b358802fc3910, StateChangedEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      if (this.c6e68d4163e92bbc6a33bc1e07bf15a4f.get_Checked())
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cdaf14beb5078d3d484015916b39121af);
            }
            this.c02f822b4a13df9d2c2d9666d3986f346.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12304) != 0);
            this.c62f555309ebbf190dea30e5a84cef1bf.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12308) != 0);
            this.cf03615c721382f9adb018993489259dd = (c495b5dc2a5615c018cbf60b86f239eff) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12312);
            break;
        }
      }
      else
        this.cf03615c721382f9adb018993489259dd = (c495b5dc2a5615c018cbf60b86f239eff) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12316);
    }

    private void c3d2d7b5364902602a5665ae731a9a0ec(object c5382ad5461e274fda51b358802fc3910, StateChangedEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      if (this.c02f822b4a13df9d2c2d9666d3986f346.get_Checked())
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c3d2d7b5364902602a5665ae731a9a0ec);
            }
            this.c6e68d4163e92bbc6a33bc1e07bf15a4f.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12320) != 0);
            this.c62f555309ebbf190dea30e5a84cef1bf.set_Checked(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12324) != 0);
            this.cf03615c721382f9adb018993489259dd = (c495b5dc2a5615c018cbf60b86f239eff) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12328);
            break;
        }
      }
      else
        this.cf03615c721382f9adb018993489259dd = (c495b5dc2a5615c018cbf60b86f239eff) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12332);
    }

    private void cebd8804c59f3a04ec634d1e48ff28d8b(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.cc22795a3b7f696da1cccaeeed1defe68)
        return;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cebd8804c59f3a04ec634d1e48ff28d8b);
          }
          this.c6450bee67c17aaeb724d7d72619d430e();
          break;
      }
    }

    private void ccf9c4063095a326f0e9a94c33d08bf8e(object c5382ad5461e274fda51b358802fc3910, StateChangedEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      Settings.Default.CompactView = this.c68b8f2723032c53a16a489755afa9f3d.get_Checked();
      Settings.Default.Save();
      if (this.c68b8f2723032c53a16a489755afa9f3d.get_Checked())
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ccf9c4063095a326f0e9a94c33d08bf8e);
            }
            this.ced13435d37c83d5695f389153255d7aa.set_ViewType((ListViewType) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12336));
            this.ced13435d37c83d5695f389153255d7aa.set_FullRowSelect(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12340) != 0);
            break;
        }
      }
      else
      {
        this.ced13435d37c83d5695f389153255d7aa.set_ViewType((ListViewType) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12344));
        this.ced13435d37c83d5695f389153255d7aa.set_ItemSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12348), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12352)));
      }
      this.ced13435d37c83d5695f389153255d7aa.set_MultiSelect(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12356) != 0);
    }

    private void c04fbff1e4daf62ad1f425e35e4c03f19()
    {
      c6a07387c2f827de6ca155929a5452624.c6122b55a0f5768d890cfe4cf2c0b6543(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20267));
    }

    private void cbc7a5c8395621b199b687bcf2d150166(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (!this.CurrentlyDownloading)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cbc7a5c8395621b199b687bcf2d150166);
          }
          if (RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20272), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7494), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12360)) != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12364))
          {
label_5:
            switch (6)
            {
              case 0:
                goto label_5;
              default:
                return;
            }
          }
          else
          {
            this.cbd687f998e72be3a53e9ec30b343fc9f.cede7d54d5e26788af0d6a69eca29fa85();
            Thread.Sleep(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12368));
            this.c2c3a87d3035837f5b8eeb5f239b8bde0((object) this, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20335));
            break;
          }
      }
    }

    private void c1c8f0e7a14b8a30b8cab7c4bff0e2c99(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cdde109e3201a2b780690d19cc7c62973();
      this.cce20c4049fbcb70a9f55c7c45157b2cf();
      this.c836356d79f13f041ccb9894cfd5f74bf(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12372) != 0);
    }

    private void c30b03ae489223abe0feeb95c8904c2f0(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20376), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20702), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12376)) != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12380))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c30b03ae489223abe0feeb95c8904c2f0);
            break;
        }
      }
      else
      {
        IEnumerator<ListViewDataItem> enumerator = this.ced13435d37c83d5695f389153255d7aa.get_Items().GetEnumerator();
        try
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            ListViewDataItem current = enumerator.Current;
            cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(current.get_Tag());
            if (cce1cf1e0b6971ed6f7ef86a83b0959b6.cf062de84cde10d9e953c8091a0e1b42b)
            {
label_8:
              switch (7)
              {
                case 0:
                  goto label_8;
                default:
                  if (cce1cf1e0b6971ed6f7ef86a83b0959b6.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12384))
                  {
label_10:
                    switch (1)
                    {
                      case 0:
                        goto label_10;
                      default:
                        if (current.get_Visible())
                        {
label_12:
                          switch (5)
                          {
                            case 0:
                              goto label_12;
                            default:
                              this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) cce1cf1e0b6971ed6f7ef86a83b0959b6.Dlc);
                              continue;
                          }
                        }
                        else
                          continue;
                    }
                  }
                  else
                    continue;
              }
            }
          }
label_15:
          switch (1)
          {
            case 0:
              goto label_15;
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_18:
            switch (4)
            {
              case 0:
                goto label_18;
              default:
                ((IDisposable) enumerator).Dispose();
                break;
            }
          }
        }
      }
    }

    private void c4a1f2e7bf3546566e4ec3384be1ab1ce(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20721), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20702), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12388)) != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12392))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c4a1f2e7bf3546566e4ec3384be1ab1ce);
            break;
        }
      }
      else
      {
        bool flag = RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(21053), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(21160), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12396)) == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12400);
        IEnumerator<ListViewDataItem> enumerator1 = this.ced13435d37c83d5695f389153255d7aa.get_Items().GetEnumerator();
        try
        {
          while (((IEnumerator) enumerator1).MoveNext())
          {
            ListViewDataItem current = enumerator1.Current;
            cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(current.get_Tag());
            if (cce1cf1e0b6971ed6f7ef86a83b0959b6.c2485b5906efc569b1c867e5c900b2e4e)
            {
label_8:
              switch (3)
              {
                case 0:
                  goto label_8;
                default:
                  if (current.get_Visible())
                  {
label_10:
                    switch (1)
                    {
                      case 0:
                        goto label_10;
                      default:
                        if (flag)
                        {
label_12:
                          switch (5)
                          {
                            case 0:
                              goto label_12;
                            default:
                              List<ce64fe4baff0b285aaecd02e2cae2ea2c> updates = cce1cf1e0b6971ed6f7ef86a83b0959b6.Updates;
                              // ISSUE: reference to a compiler-generated field
                              Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool> predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cb67c158171fa88dcc0de758be9d3ce30;
                              if (predicate == null)
                              {
label_14:
                                switch (2)
                                {
                                  case 0:
                                    goto label_14;
                                  default:
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cb67c158171fa88dcc0de758be9d3ce30 = new Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c56691789c93f1d7616ddd64c544eb186);
                                    break;
                                }
                              }
                              IEnumerator<ce64fe4baff0b285aaecd02e2cae2ea2c> enumerator2 = updates.Where<ce64fe4baff0b285aaecd02e2cae2ea2c>(predicate).GetEnumerator();
                              try
                              {
                                while (enumerator2.MoveNext())
                                  this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) enumerator2.Current);
label_20:
                                switch (2)
                                {
                                  case 0:
                                    goto label_20;
                                  default:
                                    continue;
                                }
                              }
                              finally
                              {
                                if (enumerator2 != null)
                                {
label_22:
                                  switch (1)
                                  {
                                    case 0:
                                      goto label_22;
                                    default:
                                      enumerator2.Dispose();
                                      break;
                                  }
                                }
                              }
                          }
                        }
                        else if (cce1cf1e0b6971ed6f7ef86a83b0959b6.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>().c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12404))
                        {
label_26:
                          switch (4)
                          {
                            case 0:
                              goto label_26;
                            default:
                              this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) cce1cf1e0b6971ed6f7ef86a83b0959b6.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>());
                              continue;
                          }
                        }
                        else
                          continue;
                    }
                  }
                  else
                    continue;
              }
            }
          }
label_29:
          switch (6)
          {
            case 0:
              goto label_29;
          }
        }
        finally
        {
          if (enumerator1 != null)
          {
label_32:
            switch (5)
            {
              case 0:
                goto label_32;
              default:
                ((IDisposable) enumerator1).Dispose();
                break;
            }
          }
        }
      }
    }

    private void c25d8652f001605d69f6df0b4a0d26af7(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) this.SelectedGame.Dlc);
    }

    private void c68fa9f7ed23f21a338b0a8c32e6b2db1(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cd660ef369e4674e4d70b339bf2da51d1(this.SelectedGame);
    }

    private void c6732bfb0119127fad590752ecfe2efa3(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      c58509175cbe634f2808d2fefd16ab8d3 c58509175cbe634f2808d2fefd16ab8d3 = new c58509175cbe634f2808d2fefd16ab8d3((IEnumerable<ce64fe4baff0b285aaecd02e2cae2ea2c>) this.SelectedGame.Updates, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12408) != 0);
      if (((Form) c58509175cbe634f2808d2fefd16ab8d3).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12412))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c6732bfb0119127fad590752ecfe2efa3);
            break;
        }
      }
      else
      {
        using (List<ce64fe4baff0b285aaecd02e2cae2ea2c>.Enumerator enumerator = c58509175cbe634f2808d2fefd16ab8d3.cb917dff3a4bc5ccb946b4a838034a862.GetEnumerator())
        {
          while (enumerator.MoveNext())
            this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) enumerator.Current);
label_9:
          switch (3)
          {
            case 0:
              goto label_9;
          }
        }
      }
    }

    private void c9ef71cbbd73862240b6affa8ee095fd2(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Control) new cbb595cd1ce73bd1b906cfc6ca8385bb8()).Show();
    }

    private void cd9a9ad96757ebd3cc07b49ec781e0bc8(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      c1b7cf6218f1f498aba267c6450ec9233.cc280c8ccf354d2ee7188ab5afd61f109(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12416) != 0);
      this.cc70181fca6ee40942c7d38cbe021f365();
    }

    private void c95491d79f5fba95e0fa7597e14b222fe(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      Settings.Default.Region = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8320);
      Settings.Default.Save();
      System.Windows.Forms.Application.Restart();
    }

    private void ce23c7b4a21a3bc2bfe930891c1af1451(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      int num = (int) ((Form) new cc63ab87eedc7d55bfe2aeaa2107ae2fc()).ShowDialog();
    }

    private void c3c62c4e1b695596139040f6223b53199(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      Settings.Default.TicketsPath = "";
      Settings.Default.TicketsPath3DS = "";
      Settings.Default.Save();
      System.Windows.Forms.Application.Restart();
    }

    private void c73a91aa5e28f9899f28a0eb26c625fd5(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12420) != 0;
      IEnumerator<ListViewDataItem> enumerator = ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).get_Items().GetEnumerator();
      try
      {
        while (((IEnumerator) enumerator).MoveNext())
          enumerator.Current.set_CheckState((ToggleState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12424));
label_4:
        switch (6)
        {
          case 0:
            goto label_4;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c73a91aa5e28f9899f28a0eb26c625fd5);
              break;
            }
            break;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_8:
          switch (1)
          {
            case 0:
              goto label_8;
            default:
              ((IDisposable) enumerator).Dispose();
              break;
          }
        }
      }
      this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12428) != 0;
      this.c6450bee67c17aaeb724d7d72619d430e();
    }

    private void cfa697369a444f380ae43cb2510ff83cc(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ListViewDataItem[] array = ((IEnumerable<ListViewDataItem>) this.c0ebc97b073a7d0dba554313d3f62139d.get_Items()).ToArray<ListViewDataItem>();
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12432);
      while (index < (int) cc3c66262e74964bfd7eb3ee85bcaca64.c572aba370be49804cbdb0b35312bea94(array))
      {
        this.c1737c2fea7bc70c3217f485e866febe6(c2c70c34e9090df0cdefc483e35740e07.cc50e3aad2c922bb7d7e65938629ab7b5(array[index].get_Tag()));
        index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12436);
      }
label_3:
      switch (3)
      {
        case 0:
          goto label_3;
        default:
          if (1 != 0)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cfa697369a444f380ae43cb2510ff83cc);
          break;
      }
    }

    private void ce6966d95da94f2c9113bf75a09b503cf(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ListViewDataItem[] array = ((IEnumerable<ListViewDataItem>) this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items()).ToArray<ListViewDataItem>();
      int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12440);
      while (index < (int) cc3c66262e74964bfd7eb3ee85bcaca64.c572aba370be49804cbdb0b35312bea94(array))
      {
        this.cbc50580a57af8c859936f77b72544977(c2c70c34e9090df0cdefc483e35740e07.cc50e3aad2c922bb7d7e65938629ab7b5(array[index].get_Tag()));
        index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12444);
      }
label_3:
      switch (6)
      {
        case 0:
          goto label_3;
        default:
          if (1 != 0)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ce6966d95da94f2c9113bf75a09b503cf);
          break;
      }
    }

    private void c27c10f6cd1daa7cac3cf201e3540c2a7(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c4d42c560b9fe1667228666289ee2012d();
    }

    private void c58d2f8fc315dc501ba3a7de121a2bc95(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c5f56f279f7c240ac9c4a9351a66b1049(this.SelectedGame);
    }

    private void c94dd3a90255de1f485df820c8a22b1ab(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(21199), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20702), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12448)) != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12452))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c94dd3a90255de1f485df820c8a22b1ab);
            break;
        }
      }
      else
      {
        ListViewDataItemCollection items = this.ced13435d37c83d5695f389153255d7aa.get_Items();
        // ISSUE: reference to a compiler-generated field
        Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c5b03ebb4959695cfbd08c7633a69e904;
        if (selector == null)
        {
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c5b03ebb4959695cfbd08c7633a69e904 = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c921c42cfe76fda4bb847e7244f997c1c);
              break;
          }
        }
        IEnumerator<cce1cf1e0b6971ed6f7ef86a83b0959b6> enumerator1 = ((IEnumerable<ListViewDataItem>) items).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector).GetEnumerator();
        try
        {
          while (enumerator1.MoveNext())
          {
            cce1cf1e0b6971ed6f7ef86a83b0959b6 current = enumerator1.Current;
            if (current.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12456))
            {
label_10:
              switch (7)
              {
                case 0:
                  goto label_10;
                default:
                  this.c9ebdd2bff5f91eb70ae39a82398a3a59((cba6aa8f767d2e8dfbca2d43d7148c173) current);
                  break;
              }
            }
            if (current.c2485b5906efc569b1c867e5c900b2e4e)
            {
label_13:
              switch (1)
              {
                case 0:
                  goto label_13;
                default:
                  List<ce64fe4baff0b285aaecd02e2cae2ea2c> updates = current.Updates;
                  // ISSUE: reference to a compiler-generated field
                  Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool> predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c730ebbb5ce5b66757bbdd612382c3a44;
                  if (predicate == null)
                  {
label_15:
                    switch (2)
                    {
                      case 0:
                        goto label_15;
                      default:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c730ebbb5ce5b66757bbdd612382c3a44 = new Func<ce64fe4baff0b285aaecd02e2cae2ea2c, bool>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c9030a8a24ad60d2fcd1dc2510a9c2cfa);
                        break;
                    }
                  }
                  IEnumerator<ce64fe4baff0b285aaecd02e2cae2ea2c> enumerator2 = updates.Where<ce64fe4baff0b285aaecd02e2cae2ea2c>(predicate).GetEnumerator();
                  try
                  {
                    while (enumerator2.MoveNext())
                      this.c9ebdd2bff5f91eb70ae39a82398a3a59((cba6aa8f767d2e8dfbca2d43d7148c173) enumerator2.Current);
label_21:
                    switch (5)
                    {
                      case 0:
                        goto label_21;
                    }
                  }
                  finally
                  {
                    if (enumerator2 != null)
                    {
label_23:
                      switch (3)
                      {
                        case 0:
                          goto label_23;
                        default:
                          enumerator2.Dispose();
                          break;
                      }
                    }
                  }
              }
            }
            if (current.cf062de84cde10d9e953c8091a0e1b42b)
            {
label_27:
              switch (5)
              {
                case 0:
                  goto label_27;
                default:
                  if (current.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12460))
                  {
label_29:
                    switch (6)
                    {
                      case 0:
                        goto label_29;
                      default:
                        this.c9ebdd2bff5f91eb70ae39a82398a3a59((cba6aa8f767d2e8dfbca2d43d7148c173) current.Dlc);
                        continue;
                    }
                  }
                  else
                    continue;
              }
            }
          }
label_32:
          switch (4)
          {
            case 0:
              goto label_32;
          }
        }
        finally
        {
          if (enumerator1 != null)
          {
label_35:
            switch (5)
            {
              case 0:
                goto label_35;
              default:
                enumerator1.Dispose();
                break;
            }
          }
        }
        ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Select();
      }
    }

    private void c46256fe3803456a592ab764c4f77e686(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cb6779a12dc18aa08dc1f9edef1bd2a32(this.SelectedGame);
    }

    private void ce2ea68eb9c0d4049a372275378d48be5(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      int num = (int) ((Form) new c7790279ae51d5c2ddf66e645bbeeef44()).ShowDialog();
      this.c311e8fc3018c9512f3d0c01c298c037e();
    }

    private void c9d6a6359bdaa8bfb408f277ae45099e3(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(21379), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20702), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12464)) != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12468))
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c9d6a6359bdaa8bfb408f277ae45099e3);
            break;
        }
      }
      else
      {
        IEnumerator<ListViewDataItem> enumerator = this.ced13435d37c83d5695f389153255d7aa.get_Items().GetEnumerator();
        try
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            ListViewDataItem current = enumerator.Current;
            cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(current.get_Tag());
            if (cce1cf1e0b6971ed6f7ef86a83b0959b6.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12472))
            {
label_8:
              switch (5)
              {
                case 0:
                  goto label_8;
                default:
                  if (current.get_Visible())
                  {
label_10:
                    switch (2)
                    {
                      case 0:
                        goto label_10;
                      default:
                        this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) cce1cf1e0b6971ed6f7ef86a83b0959b6);
                        continue;
                    }
                  }
                  else
                    continue;
              }
            }
          }
label_13:
          switch (3)
          {
            case 0:
              goto label_13;
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_16:
            switch (2)
            {
              case 0:
                goto label_16;
              default:
                ((IDisposable) enumerator).Dispose();
                break;
            }
          }
        }
      }
    }

    private void c19835ae6c6fd13fd547baabc4427caa2(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c714cda224c0867b81d88c3a87f7b805d.GoBack();
    }

    private void cf1d07eec0ff2b3ebc25d71173ed6414e(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c714cda224c0867b81d88c3a87f7b805d.GoForward();
    }

    private void cd49b1edc754a0a47f5bb49a58fba51b8(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      int num = (int) ((Form) new c40ece8fa5bfed221fc1f86983d53de2d()).ShowDialog();
    }

    private void c13f5c11df9c459a2a7d3f3b326593596(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
      {
        Description = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(21667)
      };
      if (folderBrowserDialog.ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12476))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c13f5c11df9c459a2a7d3f3b326593596);
            break;
        }
      }
      else if (((Form) new c2bb169b5d4236d69228785cc89207733(folderBrowserDialog.SelectedPath, ca377ebace9a9e1ffac7b0c5a9158e838.ca32b8c3bef10c492a2adefe52dea03d4)).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12480))
      {
label_6:
        switch (2)
        {
          case 0:
            goto label_6;
        }
      }
      else
      {
        this.cfca5afdf2670089d1cdac0de57c626aa(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(21744));
        this.c97f25335d6752a51249adc3a07b8266a(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12484) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12488) != 0);
      }
    }

    private void ccae678647ec6ce2724f22ff3c88365db(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.c0ebc97b073a7d0dba554313d3f62139d.get_Items().get_Count() == 0)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ccae678647ec6ce2724f22ff3c88365db);
            break;
        }
      }
      else
      {
        DriveInfo c0e9711de842cf1e7bad5b0d9e38cb2bf = cce1cf1e0b6971ed6f7ef86a83b0959b6.ca075787b36b06b9d1b25036d8fd4559d(c7e7c7f5bf8574bd41bf2c8eec93ee3f2.c266cc793747f741ea3de85f7a5f5e6a8(((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Tag));
        if (c0e9711de842cf1e7bad5b0d9e38cb2bf == null)
        {
label_6:
          switch (5)
          {
            case 0:
              goto label_6;
          }
        }
        else
        {
          this.c13ba80c7e74d29b02f44adecc28c16b7(this.TitlesToCopy, c0e9711de842cf1e7bad5b0d9e38cb2bf, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12492) != 0);
          this.c97f25335d6752a51249adc3a07b8266a(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12496) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12500) != 0);
          this.cfa697369a444f380ae43cb2510ff83cc((object) null, c3978a42df3e901949e27aa5a5768ff04.c20c00b8e97bb4c0fb2b7ac6facf98b91);
        }
      }
    }

    private void c78e5b51eda7d64d090944308c1539594()
    {
      this.cfca5afdf2670089d1cdac0de57c626aa(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(21825));
    }

    private void c06223b0ff78e229a36421fbcd064759e(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.ca5aed60c2dab3ff1d5478c9ff4d2e495 == null)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c06223b0ff78e229a36421fbcd064759e);
            }
            this.c78e5b51eda7d64d090944308c1539594();
            break;
        }
      }
      else
        Process.Start(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22091), string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22116), (object) this.ca5aed60c2dab3ff1d5478c9ff4d2e495));
    }

    private void c78734060d236c637def3f7446ea85000(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.SelectedGame.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12504))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c78734060d236c637def3f7446ea85000);
            }
            int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22159));
            this.cd660ef369e4674e4d70b339bf2da51d1(this.SelectedGame);
            if (this.CurrentlyDownloading)
              break;
label_5:
            switch (4)
            {
              case 0:
                goto label_5;
              default:
                this.c28f7f62249a89e72682657aeeb6b80a6();
                return;
            }
        }
      }
      else
      {
        cc6dede17deea63b67c3e0eb84bf12bb3 c5a5bec978796537a0d12234195422a66 = this.SelectedGame.c37fb779a19244202a98c4e2c8832a407();
        if (c5a5bec978796537a0d12234195422a66 == null)
        {
label_8:
          switch (2)
          {
            case 0:
              goto label_8;
            default:
              int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22413));
              break;
          }
        }
        else
        {
          int num = (int) ((Form) new c98e0d27acc5782eb4a0620faffca05d3(c5a5bec978796537a0d12234195422a66)).ShowDialog();
          this.SelectedGame.c754046fef40adf702b22895f45ed9448(c5a5bec978796537a0d12234195422a66);
        }
      }
    }

    private void c884bc8ac4a1f786b3291d2be37bd5f1b(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cc70181fca6ee40942c7d38cbe021f365();
    }

    private void c2ff8dad80aaaddc681d75648bdec83ef(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      c6a07387c2f827de6ca155929a5452624.c6122b55a0f5768d890cfe4cf2c0b6543(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22538));
      this.c76571b1a21c9b1e3056dd0f0d80a9904 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12508) != 0;
      this.cfce1c4d8eaef6f0803abe344f8ff58cd();
    }

    private void c113e80b8ef6ddbbbeb2b901b16fe6b8d(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ((Control) new c45079d4b21d1c7eab1527a05fb2c7e91()).Show();
    }

    private void cb7a699612516f8f5554c5ce6e3c3e29c(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c8b03bd9d9a57dec6b913e126b7b6746d c8b03bd9d9a57dec6b913e126b7b6746d = new c1b7cf6218f1f498aba267c6450ec9233.c8b03bd9d9a57dec6b913e126b7b6746d();
      if (this.c0ebc97b073a7d0dba554313d3f62139d.get_Items().get_Count() == 0)
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cb7a699612516f8f5554c5ce6e3c3e29c);
            break;
        }
      }
      else if (this.ca5aed60c2dab3ff1d5478c9ff4d2e495 == null)
      {
label_5:
        switch (7)
        {
          case 0:
            goto label_5;
          default:
            this.c78e5b51eda7d64d090944308c1539594();
            break;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        c8b03bd9d9a57dec6b913e126b7b6746d.c573478f18a5912d9584df82d6501aa9f = "";
        string c33ad1bd311fd4b32b85377e9e15a9d93 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22551), Environment.NewLine);
        bool c9fa97f64d5af3c34a9bbdb0637e49788 = RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22582), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22936), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12512)) == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12516);
        using (List<cba6aa8f767d2e8dfbca2d43d7148c173>.Enumerator enumerator = this.TitlesToCopy.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            c1b7cf6218f1f498aba267c6450ec9233.c693593d9ea4359c5341a5b37d96825b8 c693593d9ea4359c5341a5b37d96825b8 = new c1b7cf6218f1f498aba267c6450ec9233.c693593d9ea4359c5341a5b37d96825b8();
            // ISSUE: reference to a compiler-generated field
            c693593d9ea4359c5341a5b37d96825b8.c10051687c186d4463c40ec142db943cf = c8b03bd9d9a57dec6b913e126b7b6746d;
            // ISSUE: reference to a compiler-generated field
            c693593d9ea4359c5341a5b37d96825b8.c36dd98eb0c08ea087627a40c6663c9a8 = enumerator.Current;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            c1b7cf6218f1f498aba267c6450ec9233.c7782faa7613faac53baa7018ae784d0c c7782faa7613faac53baa7018ae784d0c = new c1b7cf6218f1f498aba267c6450ec9233.c7782faa7613faac53baa7018ae784d0c();
            // ISSUE: reference to a compiler-generated field
            c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2 = c693593d9ea4359c5341a5b37d96825b8;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8.System != (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12520))
            {
label_10:
              switch (1)
              {
                case 0:
                  goto label_10;
                default:
                  return;
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              c7782faa7613faac53baa7018ae784d0c.c6461dc757fcb2e72806723940bccd205 = new cd529c52ba6e98034731193f1e0be6af5(c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8.Name);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8.c31cd36c62c73b80a1d5c5ab19a9c6298 += new EventHandler<cdf40c9764a014ff068a86edd8ace4556>(c7782faa7613faac53baa7018ae784d0c.c48330808fe57fa7115b1097cc36c3037);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8.c943f81e9c8c38b48def08f2dd55c66db += new EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1>(c7782faa7613faac53baa7018ae784d0c.c33887a23462ec77b761c2e04a291fa14);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              c7782faa7613faac53baa7018ae784d0c.c6461dc757fcb2e72806723940bccd205.c0d9efa80e829b2df6f87a574df10245a += new EventHandler(c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.ce02e6cd90ab9df902accfb2d9ab93e5b);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8.c383b419adeff39108be6b9097bc3c315(c9fa97f64d5af3c34a9bbdb0637e49788, this.ca5aed60c2dab3ff1d5478c9ff4d2e495);
              // ISSUE: reference to a compiler-generated field
              int num = (int) ((Form) c7782faa7613faac53baa7018ae784d0c.c6461dc757fcb2e72806723940bccd205).ShowDialog();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c10051687c186d4463c40ec142db943cf.c573478f18a5912d9584df82d6501aa9f, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2236)))
              {
label_12:
                switch (6)
                {
                  case 0:
                    goto label_12;
                  default:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5((object) c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8) != null)
                    {
label_14:
                      switch (5)
                      {
                        case 0:
                          goto label_14;
                        default:
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5((object) c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8).cd61c5f51f587495941f329dc6bffec54 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12524) != 0;
                          break;
                      }
                    }
                    else
                      break;
                }
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              c33ad1bd311fd4b32b85377e9e15a9d93 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93, string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22969), (object) c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c36dd98eb0c08ea087627a40c6663c9a8, (object) c7782faa7613faac53baa7018ae784d0c.c5bf0273358253d4f13533201842261a2.c10051687c186d4463c40ec142db943cf.c573478f18a5912d9584df82d6501aa9f, (object) Environment.NewLine));
            }
          }
label_18:
          switch (7)
          {
            case 0:
              goto label_18;
          }
        }
        this.cfca5afdf2670089d1cdac0de57c626aa(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22998)));
        this.c97f25335d6752a51249adc3a07b8266a(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12528) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12532) != 0);
        this.cfa697369a444f380ae43cb2510ff83cc((object) null, c3978a42df3e901949e27aa5a5768ff04.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      }
    }

    private void cd5fa4dcfadcc93d74350c51c0986e380(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c297af215a9d7fad2a9905d615aecb285(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12536) != 0);
    }

    private void c8fcfb9313406612acf3d10f41963833f(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12540) != 0;
      IEnumerator<ListViewDataItem> enumerator = ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).get_Items().GetEnumerator();
      try
      {
        while (((IEnumerator) enumerator).MoveNext())
          enumerator.Current.set_CheckState((ToggleState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12544));
label_4:
        switch (4)
        {
          case 0:
            goto label_4;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c8fcfb9313406612acf3d10f41963833f);
              break;
            }
            break;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_8:
          switch (1)
          {
            case 0:
              goto label_8;
            default:
              ((IDisposable) enumerator).Dispose();
              break;
          }
        }
      }
      this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12548) != 0;
      this.c6450bee67c17aaeb724d7d72619d430e();
    }

    private void c0920b14ec7a66a99cdce1ebbad123147()
    {
      DataSize dataSize1 = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12552));
      ListViewDataItemCollection items = this.c0ebc97b073a7d0dba554313d3f62139d.get_Items();
      DataSize seed = dataSize1;
      // ISSUE: reference to a compiler-generated field
      Func<DataSize, ListViewDataItem, DataSize> func = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cc77c55c9ab727b8bf96aedce0e88910b;
      if (func == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c0920b14ec7a66a99cdce1ebbad123147);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            func = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cc77c55c9ab727b8bf96aedce0e88910b = new Func<DataSize, ListViewDataItem, DataSize>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cd02ef0556d45a44e1cc83963a9e3c779);
            break;
        }
      }
      DataSize dataSize2 = ((IEnumerable<ListViewDataItem>) items).Aggregate<ListViewDataItem, DataSize>(seed, func);
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Text = dataSize2.ToString();
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Tag = (object) dataSize2;
    }

    private void c2c99ff079ae47d1aebf76d3b9b2ab83c()
    {
      DataSize dataSize = new DataSize((ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12556));
      ListViewDataItemCollection items = this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items();
      DataSize seed = dataSize;
      // ISSUE: reference to a compiler-generated field
      Func<DataSize, ListViewDataItem, DataSize> func = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cf06a488512cfba54d81e07b21551b0c1;
      if (func == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c2c99ff079ae47d1aebf76d3b9b2ab83c);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            func = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cf06a488512cfba54d81e07b21551b0c1 = new Func<DataSize, ListViewDataItem, DataSize>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cc921f11ae7c58f23dc8f96ea5337e42c);
            break;
        }
      }
      ((Control) this.cef22dcb29373b4f99e89eb28166e5dc2).Text = ((IEnumerable<ListViewDataItem>) items).Aggregate<ListViewDataItem, DataSize>(seed, func).ToString();
    }

    private void c13ba80c7e74d29b02f44adecc28c16b7(List<cba6aa8f767d2e8dfbca2d43d7148c173> c7f279dcec6016add56ea225f380666c1, DriveInfo c0e9711de842cf1e7bad5b0d9e38cb2bf, bool cc1139cf96b6c5b6b7ca39208551d3bd1)
    {
      string c33ad1bd311fd4b32b85377e9e15a9d93_1 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22551), Environment.NewLine);
      using (List<cba6aa8f767d2e8dfbca2d43d7148c173>.Enumerator enumerator = c7f279dcec6016add56ea225f380666c1.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          cba6aa8f767d2e8dfbca2d43d7148c173 current = enumerator.Current;
          string c33ad1bd311fd4b32b85377e9e15a9d93_2 = current.c67a77144991678dc8a5c260dc2993b06(cc1139cf96b6c5b6b7ca39208551d3bd1, c0e9711de842cf1e7bad5b0d9e38cb2bf);
          if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93_2, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2236)))
          {
label_3:
            switch (3)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c13ba80c7e74d29b02f44adecc28c16b7);
                }
                if (c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5((object) current) != null)
                {
label_7:
                  switch (2)
                  {
                    case 0:
                      goto label_7;
                    default:
                      c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5((object) current).cd61c5f51f587495941f329dc6bffec54 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12560) != 0;
                      break;
                  }
                }
                else
                  break;
            }
          }
          c33ad1bd311fd4b32b85377e9e15a9d93_1 = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93_1, string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22969), (object) current, (object) c33ad1bd311fd4b32b85377e9e15a9d93_2, (object) Environment.NewLine));
        }
label_11:
        switch (5)
        {
          case 0:
            goto label_11;
        }
      }
      this.cfca5afdf2670089d1cdac0de57c626aa(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93_1, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(22998)));
    }

    private void cce20c4049fbcb70a9f55c7c45157b2cf()
    {
      RadButton cf8a1dc8cf7f73143ea81640d7645c738 = this.cf8a1dc8cf7f73143ea81640d7645c738;
      int num;
      if (this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items().get_Count() > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12564))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cce20c4049fbcb70a9f55c7c45157b2cf);
            }
            num = (this.CurrentlyDownloading ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12568) ? 1 : 0;
            break;
        }
      }
      else
        num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12572);
      ((Control) cf8a1dc8cf7f73143ea81640d7645c738).Enabled = num != 0;
    }

    private void c38398a8ddfd723e7a6f8149362fb466f(object c5382ad5461e274fda51b358802fc3910, ListViewItemEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.CurrentlyDownloading)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c38398a8ddfd723e7a6f8149362fb466f);
            }
            if (this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_SelectedIndex() <= this.IndexGameCurrentlyDownloaded)
            {
label_5:
              switch (4)
              {
                case 0:
                  goto label_5;
                default:
                  int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23154));
                  return;
              }
            }
            else
              break;
        }
      }
      this.cbc50580a57af8c859936f77b72544977(c2c70c34e9090df0cdefc483e35740e07.cc50e3aad2c922bb7d7e65938629ab7b5(c9572d7ff9cd6a116e4a6f248ca68a831.get_Item().get_Tag()));
    }

    private void c28f7f62249a89e72682657aeeb6b80a6()
    {
      this.c836356d79f13f041ccb9894cfd5f74bf(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12576) != 0);
      this.CurrentlyDownloading = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12580) != 0;
      this.cbc2eee5df02616fd21fbc91bc233cdcd.get_Items().Clear();
      this.cce20c4049fbcb70a9f55c7c45157b2cf();
      this.cb5983a9ef6bb031c7f34108a205a5729.set_ActiveWindow((DockWindow) this.c48844a2ef256637729bbfeba6c14b1ba);
      if (this.c93a99fb1c1183d9875099b634bd270a6.get_Checked())
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c28f7f62249a89e72682657aeeb6b80a6);
            }
            if (this.c761bc48a0ac5352d2a79834b62d8e9c7.Value.CompareTo(DateTime.Now) > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12584))
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12588) != 0;
                  this.cee1c0c7304084325bbf547e952525117.Start();
                  return;
              }
            }
            else
              break;
        }
      }
      this.cbd2d1dd4e92c4af7fa4405eb1a93d398();
    }

    private void c9959d048e2fe4826cfdded21647cf98f(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c28f7f62249a89e72682657aeeb6b80a6();
    }

    private void ca654510b5e40795e5c6c9411c02fda00(object c5382ad5461e274fda51b358802fc3910, c9d5fc374dcd742d4aee7811bbe7ee2e1 c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c763d4ecf9efe6e7927cf45aeb499dcac c763d4ecf9efe6e7927cf45aeb499dcac = new c1b7cf6218f1f498aba267c6450ec9233.c763d4ecf9efe6e7927cf45aeb499dcac();
      // ISSUE: reference to a compiler-generated field
      c763d4ecf9efe6e7927cf45aeb499dcac.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      c763d4ecf9efe6e7927cf45aeb499dcac.c9572d7ff9cd6a116e4a6f248ca68a831 = c9572d7ff9cd6a116e4a6f248ca68a831;
      try
      {
        // ISSUE: reference to a compiler-generated method
        ((Control) this).Invoke((Delegate) new Action(c763d4ecf9efe6e7927cf45aeb499dcac.c1440fdb629767c34f07a16d0f3f883e6));
      }
      catch
      {
      }
    }

    private byte[] c484ff7e6b78ef56e7450a23903dd19b9(string c5272f076b419bee04eaa2f4ef6b812d1)
    {
      string path = Path.Combine(c1b7cf6218f1f498aba267c6450ec9233.cbcdc1c9bf8b0cdf7ffca04e9093f518e, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23288));
      if (c1b7cf6218f1f498aba267c6450ec9233.c07a06fae0e63ec59953e00dc6e46e231(c5272f076b419bee04eaa2f4ef6b812d1))
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c484ff7e6b78ef56e7450a23903dd19b9);
            }
            if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(c5272f076b419bee04eaa2f4ef6b812d1, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12822)))
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  this.c1c0a981ac1bdbf0aa08a2a0e2f51b1d9 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12592) != 0;
                  break;
              }
            }
            if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(c5272f076b419bee04eaa2f4ef6b812d1, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12912)))
            {
label_8:
              switch (3)
              {
                case 0:
                  goto label_8;
                default:
                  this.c2470a1761b7a4b98e303cce88a107056 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12596) != 0;
                  break;
              }
            }
            WebClient webClient1 = new WebClient();
            try
            {
              WebClient webClient2 = webClient1;
              string c33ad1bd311fd4b32b85377e9e15a9d93_1 = c5272f076b419bee04eaa2f4ef6b812d1;
              string c33ad1bd311fd4b32b85377e9e15a9d93_2;
              if (!this.c1c0a981ac1bdbf0aa08a2a0e2f51b1d9)
              {
label_12:
                switch (5)
                {
                  case 0:
                    goto label_12;
                  default:
                    if (!this.c2470a1761b7a4b98e303cce88a107056)
                    {
label_14:
                      switch (4)
                      {
                        case 0:
                          goto label_14;
                        default:
                          c33ad1bd311fd4b32b85377e9e15a9d93_2 = "";
                          goto label_17;
                      }
                    }
                    else
                      break;
                }
              }
              c33ad1bd311fd4b32b85377e9e15a9d93_2 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23309);
label_17:
              string address = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(c33ad1bd311fd4b32b85377e9e15a9d93_1, c33ad1bd311fd4b32b85377e9e15a9d93_2);
              byte[] bytes = webClient2.DownloadData(address);
              Directory.CreateDirectory(c1b7cf6218f1f498aba267c6450ec9233.cbcdc1c9bf8b0cdf7ffca04e9093f518e);
              System.IO.File.WriteAllBytes(path, bytes);
              return bytes;
            }
            catch
            {
              if (System.IO.File.Exists(path))
              {
label_19:
                switch (5)
                {
                  case 0:
                    goto label_19;
                  default:
                    return System.IO.File.ReadAllBytes(path);
                }
              }
              else
                break;
            }
        }
      }
      else if (System.IO.File.Exists(c5272f076b419bee04eaa2f4ef6b812d1))
      {
label_22:
        switch (2)
        {
          case 0:
            goto label_22;
          default:
            return System.IO.File.ReadAllBytes(c5272f076b419bee04eaa2f4ef6b812d1);
        }
      }
      return (byte[]) null;
    }

    private void c1b3342d3caba36a1ab8d04032698545d()
    {
      this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12600) != 0;
      ListViewDataItemCollection items = ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).get_Items();
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, bool> predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c141a62bf00cda6259693f77c8f2c9746;
      if (predicate == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c1b3342d3caba36a1ab8d04032698545d);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c141a62bf00cda6259693f77c8f2c9746 = new Func<ListViewDataItem, bool>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cf55947f9a169a0b50f0c15680a2927e7);
            break;
        }
      }
      IEnumerable<ListViewDataItem> source = ((IEnumerable<ListViewDataItem>) items).Where<ListViewDataItem>(predicate);
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, Platform> selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c60f8a2ac0bce4a352939c30b1956fec3;
      if (selector == null)
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c60f8a2ac0bce4a352939c30b1956fec3 = new Func<ListViewDataItem, Platform>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cb3227db1f1cc38cf138014f9ddc29ac6);
            break;
        }
      }
      this.Platforms = source.Select<ListViewDataItem, Platform>(selector).ToList<Platform>();
      ((Collection<FilterDescriptor>) this.ced13435d37c83d5695f389153255d7aa.get_FilterDescriptors()).Clear();
      this.ced13435d37c83d5695f389153255d7aa.set_FilterPredicate(new Predicate<ListViewDataItem>(this.cdc28eeb64f8e76cccdc1639f3551e100));
      ((Collection<FilterDescriptor>) this.ced13435d37c83d5695f389153255d7aa.get_FilterDescriptors()).Add(new FilterDescriptor(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23320), (FilterOperator) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12604), (object) ((Control) this.cef99ac773757daa1842ee58c7914a0cc).Text));
    }

    private void cca1e6f0c118a015c36011e89157d564b(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c6450bee67c17aaeb724d7d72619d430e();
      this.c11eb1c4d76d9d3f27d002b636b540897.Stop();
    }

    private void c33de508dba0445c362e54c4418c0d9e8(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.c11eb1c4d76d9d3f27d002b636b540897.Enabled)
        return;
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c33de508dba0445c362e54c4418c0d9e8);
          }
          this.c11eb1c4d76d9d3f27d002b636b540897.Start();
          break;
      }
    }

    private void cea05945d86958650bad9e917dca33c76(c0c29f108584f137c614f55b15004c742 c407606821fe6034b43e547a4ca232678, cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c71e75d3bf46185de297d66ffe2da119d c71e75d3bf46185de297d66ffe2da119d = new c1b7cf6218f1f498aba267c6450ec9233.c71e75d3bf46185de297d66ffe2da119d();
      // ISSUE: reference to a compiler-generated field
      c71e75d3bf46185de297d66ffe2da119d.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      c71e75d3bf46185de297d66ffe2da119d.c407606821fe6034b43e547a4ca232678 = c407606821fe6034b43e547a4ca232678;
      // ISSUE: reference to a compiler-generated field
      c71e75d3bf46185de297d66ffe2da119d.c89cbac13be511053120093fce8049319 = c89cbac13be511053120093fce8049319;
      try
      {
        if (((Control) this).IsDisposed)
        {
label_2:
          switch (7)
          {
            case 0:
              goto label_2;
            default:
              if (1 != 0)
                break;
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cea05945d86958650bad9e917dca33c76);
              break;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          ((Control) this).Invoke((Delegate) new Action(c71e75d3bf46185de297d66ffe2da119d.c508bb80f404b6085ae10276785223496));
        }
      }
      catch
      {
      }
    }

    private Tuple<byte[], byte[]> ca49e343059937757238af8fad310c16f()
    {
      byte[] numArray1 = this.c484ff7e6b78ef56e7450a23903dd19b9(Settings.Default.TicketsPath);
      byte[] numArray2 = this.c484ff7e6b78ef56e7450a23903dd19b9(Settings.Default.TicketsPath3DS);
      while (numArray1 == null)
      {
label_7:
        switch (2)
        {
          case 0:
            goto label_7;
          default:
            if (numArray2 == null)
            {
              cfd95a277f4e8e0f3410cd92c0ae4f453 cfd95a277f4e8e0f3410cd92c0ae4f453 = new cfd95a277f4e8e0f3410cd92c0ae4f453();
              if (((Form) cfd95a277f4e8e0f3410cd92c0ae4f453).ShowDialog() == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12608))
              {
label_2:
                switch (1)
                {
                  case 0:
                    goto label_2;
                  default:
                    if (1 == 0)
                    {
                      // ISSUE: method reference
                      RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ca49e343059937757238af8fad310c16f);
                    }
                    Settings.Default.TicketsPath = cfd95a277f4e8e0f3410cd92c0ae4f453.FileLocationWiiU;
                    Settings.Default.TicketsPath3DS = cfd95a277f4e8e0f3410cd92c0ae4f453.FileLocation3DS;
                    numArray1 = this.c484ff7e6b78ef56e7450a23903dd19b9(Settings.Default.TicketsPath);
                    numArray2 = this.c484ff7e6b78ef56e7450a23903dd19b9(Settings.Default.TicketsPath3DS);
                    continue;
                }
              }
              else
                goto label_10;
            }
            else
            {
label_9:
              switch (1)
              {
                case 0:
                  goto label_9;
                default:
                  goto label_10;
              }
            }
        }
      }
label_10:
      return new Tuple<byte[], byte[]>(numArray1, numArray2);
    }

    private void cd7b8a84bcc59ebd89e4f9f7d58e2f137(byte[] cfe775995964ea67226aedd3e8fb0c4e1, byte[] c60cfcd0e145c756f358be58106535f84)
    {
      Settings.Default.LaunchCount += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12612);
      if (c1b0822c22b951c8a567b56dd01e313bf.c542b07bca4ac71d6066fe0b566b1b3f9(Settings.Default.LaunchCount, Settings.Default.DonationKey, c27603360ccc8374975348defb9eee9fc.keysPub))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cd7b8a84bcc59ebd89e4f9f7d58e2f137);
            }
            int num = (int) ((Form) new c7790279ae51d5c2ddf66e645bbeeef44()).ShowDialog();
            Settings.Default.LaunchCount = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12616);
            break;
        }
      }
      this.c311e8fc3018c9512f3d0c01c298c037e();
      Settings.Default.Save();
      if ((int) ThemeResolutionService.get_ApplicationThemeName()[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12620)] == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12624))
      {
label_6:
        switch (1)
        {
          case 0:
            goto label_6;
          default:
            if (!c1b0822c22b951c8a567b56dd01e313bf.c727abdef873c71ae15e67e1b27e2ad96)
            {
label_8:
              switch (4)
              {
                case 0:
                  goto label_8;
                default:
                  int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23329));
                  Settings.Default.ThemeName = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8249);
                  Settings.Default.Save();
                  System.Windows.Forms.Application.Exit();
                  return;
              }
            }
            else
              break;
        }
      }
      this.frmWait = new ca5f1a19f078eb23ced887c232d971b13(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23723));
      int num1;
      Thread thread1 = new Thread((ThreadStart) (() => num1 = (int) ((Form) this.frmWait).ShowDialog()));
      int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12628);
      thread1.IsBackground = num2 != 0;
      thread1.Start();
      try
      {
        string str;
        if (!ApplicationDeployment.IsNetworkDeployed)
        {
label_12:
          switch (6)
          {
            case 0:
              goto label_12;
            default:
              str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23752);
              break;
          }
        }
        else
          str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23767);
        string ce22c2191b13ae926aee83fc64ccc9ce3 = str;
        string c907ca8ffa30661318a7e29e77519ea57;
        if (!ApplicationDeployment.IsNetworkDeployed)
        {
label_16:
          switch (6)
          {
            case 0:
              goto label_16;
            default:
              c907ca8ffa30661318a7e29e77519ea57 = c2d4baf2bd055f4368cf2297e4ff33900.c907ca8ffa30661318a7e29e77519ea57;
              break;
          }
        }
        else
          c907ca8ffa30661318a7e29e77519ea57 = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
        string c6a4d854d81ed0a6f5eb3b1be41c30655 = c907ca8ffa30661318a7e29e77519ea57;
        string osFullName = new ComputerInfo().OSFullName;
        string path = Settings.Default.Path;
        string cbcdc1c9bf8b0cdf7ffca04e9093f518e = c1b7cf6218f1f498aba267c6450ec9233.cbcdc1c9bf8b0cdf7ffca04e9093f518e;
        string ticketsPath = Settings.Default.TicketsPath;
        string ticketsPath3Ds = Settings.Default.TicketsPath3DS;
        string cf4aa55fb2a36f741b24b85717845da03 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23786);
        string cda2bd9797089b13f541a5b30e4b8ae9b = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23859);
        int num3;
        if (!this.c1c0a981ac1bdbf0aa08a2a0e2f51b1d9)
        {
label_20:
          switch (5)
          {
            case 0:
              goto label_20;
            default:
              num3 = this.c2470a1761b7a4b98e303cce88a107056 ? 1 : 0;
              break;
          }
        }
        else
          num3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12632);
        byte[] c6356b0b4c9258e23f0592cfcdf551f54 = cfe775995964ea67226aedd3e8fb0c4e1;
        byte[] c3531e4173c1d73d4b06813464a3417fb = c60cfcd0e145c756f358be58106535f84;
        c29e22175cc06867453fe39a41ed5a7cc cac46efa5d476f5c1af2a8f0384a04fda = new c29e22175cc06867453fe39a41ed5a7cc(ce22c2191b13ae926aee83fc64ccc9ce3, osFullName, c6a4d854d81ed0a6f5eb3b1be41c30655);
        c6c48948a2ba87f2018a8803e9e4364dd.c5673db9ceda1345589497796ee375f9b(path, cbcdc1c9bf8b0cdf7ffca04e9093f518e, ticketsPath, ticketsPath3Ds, cf4aa55fb2a36f741b24b85717845da03, cda2bd9797089b13f541a5b30e4b8ae9b, num3 != 0, c6356b0b4c9258e23f0592cfcdf551f54, c3531e4173c1d73d4b06813464a3417fb, cac46efa5d476f5c1af2a8f0384a04fda);
      }
      catch (Exception ex)
      {
        int num3 = (int) RadMessageBox.Show(ex.Message);
        System.Windows.Forms.Application.Exit();
        return;
      }
      RadButton c8d4d0749ecd032b3b3c0ef4542ed6d97 = this.c8d4d0749ecd032b3b3c0ef4542ed6d97;
      int num4;
      if (!this.c1c0a981ac1bdbf0aa08a2a0e2f51b1d9)
      {
label_26:
        switch (2)
        {
          case 0:
            goto label_26;
          default:
            num4 = this.c2470a1761b7a4b98e303cce88a107056 ? 1 : 0;
            break;
        }
      }
      else
        num4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12636);
      ((Control) c8d4d0749ecd032b3b3c0ef4542ed6d97).Enabled = num4 != 0;
      this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items().Clear();
      try
      {
        this.ced13435d37c83d5695f389153255d7aa.get_Items().Clear();
      }
      catch
      {
      }
      Settings.Default.Save();
      this.ced13435d37c83d5695f389153255d7aa.set_EnableCustomGrouping(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12640) != 0);
      this.ced13435d37c83d5695f389153255d7aa.set_ShowGroups(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12644) != 0);
      this.ced13435d37c83d5695f389153255d7aa.set_EnableFiltering(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12648) != 0);
      this.ced13435d37c83d5695f389153255d7aa.BeginUpdate();
      Dictionary<TitleId, cce1cf1e0b6971ed6f7ef86a83b0959b6>.ValueCollection values = ca377ebace9a9e1ffac7b0c5a9158e838.ca32b8c3bef10c492a2adefe52dea03d4.Values;
      // ISSUE: reference to a compiler-generated field
      Func<cce1cf1e0b6971ed6f7ef86a83b0959b6, string> keySelector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c60dfd0fd75c220e1455c5171cabe00e0;
      if (keySelector == null)
      {
label_33:
        switch (4)
        {
          case 0:
            goto label_33;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            keySelector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c60dfd0fd75c220e1455c5171cabe00e0 = new Func<cce1cf1e0b6971ed6f7ef86a83b0959b6, string>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.ccc5ea9f17bfaf1908e4bb522b3633c05);
            break;
        }
      }
      IEnumerator<cce1cf1e0b6971ed6f7ef86a83b0959b6> enumerator = values.OrderBy<cce1cf1e0b6971ed6f7ef86a83b0959b6, string>(keySelector).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.c7102e7b79712edad16cc7df08327e444(enumerator.Current, this.ced13435d37c83d5695f389153255d7aa);
label_39:
        switch (6)
        {
          case 0:
            goto label_39;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_41:
          switch (6)
          {
            case 0:
              goto label_41;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
      this.ced13435d37c83d5695f389153255d7aa.EndUpdate();
      this.ce4d6376ef01990d7bbe70ddab4f01102();
      this.c04fbff1e4daf62ad1f425e35e4c03f19();
      Thread thread2 = new Thread(new ThreadStart(this.cf9caca46a59e7b29ca89c7aa99541646));
      int num5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12652);
      thread2.IsBackground = num5 != 0;
      thread2.Start();
      Thread.Sleep(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12656));
      this.cb09f0c811e9c104f30d9bdb57f5e4472.Checked = Settings.Default.ShowEvents;
      this.c6e10857a44dfe29229689f6f14eb8736.Checked = Settings.Default.ShowLegit;
      this.ce9d74c4a67920ea005ae0e9c3e550195.Checked = Settings.Default.ShowCFW;
      this.frmWait.ce064f93ebcf9a6f22e14fc4dbf62aa2c();
      this.c62202a47a535c097128224561be81ca7();
      c1b7cf6218f1f498aba267c6450ec9233.cc11d49a7901374e719632513e58f6f0a();
      string region = Settings.Default.Region;
      if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338)))
      {
label_45:
        switch (1)
        {
          case 0:
            goto label_45;
          default:
            if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9240)))
            {
label_47:
              switch (7)
              {
                case 0:
                  goto label_47;
                default:
                  if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345)))
                  {
label_49:
                    switch (1)
                    {
                      case 0:
                        goto label_49;
                    }
                  }
                  else
                  {
                    Settings.Default.USA = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12668) != 0;
                    break;
                  }
              }
            }
            else
            {
              Settings.Default.JPN = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12664) != 0;
              break;
            }
        }
      }
      else
        Settings.Default.EUR = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12660) != 0;
      this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12672) != 0;
      this.c290ca0dbd67a1dd201c0b196fec00bc4.Checked = Settings.Default.EUR;
      this.c4562184f7a172fc18d58e50d7047938d.Checked = Settings.Default.JPN;
      this.cf582d9fa2e47e4f8707ea4db5c09db97.Checked = Settings.Default.USA;
      this.c6450bee67c17aaeb724d7d72619d430e();
      try
      {
        ListViewDataItemCollection items = this.ced13435d37c83d5695f389153255d7aa.get_Items();
        // ISSUE: reference to a compiler-generated field
        Func<ListViewDataItem, bool> predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c7d43d4734be53380617201cb0610478f;
        if (predicate == null)
        {
label_55:
          switch (1)
          {
            case 0:
              goto label_55;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              predicate = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c7d43d4734be53380617201cb0610478f = new Func<ListViewDataItem, bool>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c6fb1d5eff64c609fa3336b53deaef0bc);
              break;
          }
        }
        ListViewDataItem listViewDataItem = ((IEnumerable<ListViewDataItem>) items).First<ListViewDataItem>(predicate);
        this.ced13435d37c83d5695f389153255d7aa.get_ListViewElement().EnsureItemVisible(listViewDataItem);
        this.ced13435d37c83d5695f389153255d7aa.set_SelectedItem(listViewDataItem);
      }
      catch
      {
      }
      this.c68b8f2723032c53a16a489755afa9f3d.set_Checked(Settings.Default.CompactView);
      c1b7cf6218f1f498aba267c6450ec9233.c761cac2dca99bb62b83352a5055d6c08();
    }

    private void c62202a47a535c097128224561be81ca7()
    {
      if (!ca377ebace9a9e1ffac7b0c5a9158e838.NewTitles.Any<cce1cf1e0b6971ed6f7ef86a83b0959b6>())
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c62202a47a535c097128224561be81ca7);
            break;
        }
      }
      else
      {
        c080cfc6ad1dbb46ae8cbd29bbf8919e2 c080cfc6ad1dbb46ae8cbd29bbf8919e2 = new c080cfc6ad1dbb46ae8cbd29bbf8919e2(ca377ebace9a9e1ffac7b0c5a9158e838.NewTitles);
        if (((Form) c080cfc6ad1dbb46ae8cbd29bbf8919e2).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12676))
        {
label_6:
          switch (7)
          {
            case 0:
              goto label_6;
          }
        }
        else
        {
          using (List<cce1cf1e0b6971ed6f7ef86a83b0959b6>.Enumerator enumerator = c080cfc6ad1dbb46ae8cbd29bbf8919e2.ce5be2c2084a0a5097f4942fe5b6d67b4.GetEnumerator())
          {
            while (enumerator.MoveNext())
              this.cd660ef369e4674e4d70b339bf2da51d1(enumerator.Current);
label_12:
            switch (2)
            {
              case 0:
                goto label_12;
            }
          }
        }
      }
    }

    private void cd1e3caaaf8a38e7bf3058dd00a55fdc0(List<cba6aa8f767d2e8dfbca2d43d7148c173> c8081e7b23c9b7a2c1932218177f9033b)
    {
      this.IndexGameCurrentlyDownloaded = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12680);
      c2e2f19e8cde9983e4129b4a047c9f5c6 c2e2f19e8cde9983e4129b4a047c9f5c6 = new c2e2f19e8cde9983e4129b4a047c9f5c6(this.Proxy, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12684) != 0);
      this.cbd687f998e72be3a53e9ec30b343fc9f = c2e2f19e8cde9983e4129b4a047c9f5c6;
      this.cbd687f998e72be3a53e9ec30b343fc9f.ccca69f3508da99605b80cc92c45f56bb(c0097b67418072fc17ee5f6b628c5e30b.c1df95097ffa57d753c5fe1353cf65e86(this.c560a6e04507a6b91381df70d8ba999e6.get_Value()) * (ulong) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12688));
      this.CurrentlyDownloading = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12692) != 0;
      c2e2f19e8cde9983e4129b4a047c9f5c6.cacb2e6beade608d802439f475aa2171a += new EventHandler<cdf40c9764a014ff068a86edd8ace4556>(this.c8d16b41b307bf2496c3316a03cdcf259);
      c2e2f19e8cde9983e4129b4a047c9f5c6.ca7b3d3646c1ef6f0d20e46cd000e997a += new EventHandler<string>(this.c2c3a87d3035837f5b8eeb5f239b8bde0);
      c2e2f19e8cde9983e4129b4a047c9f5c6.ce805193897570a50f04c96b162564f8f += (EventHandler<c7f5d91bc3961f40a7d6fb86e445fe3a4>) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        c1b7cf6218f1f498aba267c6450ec9233.c72efdedc919c0e1f70583d35d626b367 c72efdedc919c0e1f70583d35d626b367 = new c1b7cf6218f1f498aba267c6450ec9233.c72efdedc919c0e1f70583d35d626b367();
        // ISSUE: reference to a compiler-generated field
        c72efdedc919c0e1f70583d35d626b367.ccb669e105f1c11f33e60c076fc8cca42 = this;
        // ISSUE: reference to a compiler-generated field
        c72efdedc919c0e1f70583d35d626b367.c35ef8b45dc1b4f9c689c88c6aa3b9c3c = c35ef8b45dc1b4f9c689c88c6aa3b9c3c;
        try
        {
          // ISSUE: reference to a compiler-generated method
          ((Control) this).Invoke((Delegate) new Action(c72efdedc919c0e1f70583d35d626b367.cd4fc861f694a7f1e24c9ad50ff2778f5));
        }
        catch
        {
        }
      });
      c2e2f19e8cde9983e4129b4a047c9f5c6.c60346b7eb87c5b6c53ae83177066862b += new EventHandler<c9d5fc374dcd742d4aee7811bbe7ee2e1>(this.ca654510b5e40795e5c6c9411c02fda00);
      c2e2f19e8cde9983e4129b4a047c9f5c6.cd8b923b0d22ab0a178b88c37e9d3994a(c8081e7b23c9b7a2c1932218177f9033b, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12696), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12700));
    }

    private void c3517bb571e42308785461c40df02c473(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      System.Windows.Forms.Application.Idle -= new EventHandler(this.c3517bb571e42308785461c40df02c473);
      Tuple<byte[], byte[]> tuple = this.ca49e343059937757238af8fad310c16f();
      bool flag = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12704) != 0;
      while (true)
      {
        int num1;
        if (tuple.Item1 == null)
        {
label_8:
          switch (1)
          {
            case 0:
              goto label_8;
            default:
              num1 = tuple.Item2 == null ? 1 : 0;
              break;
          }
        }
        else
          num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12720);
        int num2 = flag ? 1 : 0;
        if ((num1 & num2) != 0)
        {
          if (RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23934), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24178), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12708)) == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12712))
          {
label_2:
            switch (1)
            {
              case 0:
                goto label_2;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c3517bb571e42308785461c40df02c473);
                }
                tuple = this.ca49e343059937757238af8fad310c16f();
                continue;
            }
          }
          else
          {
            int num3 = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24193));
            flag = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12716) != 0;
          }
        }
        else
          break;
      }
label_12:
      switch (3)
      {
        case 0:
          goto label_12;
        default:
          if (flag)
          {
label_14:
            switch (5)
            {
              case 0:
                goto label_14;
              default:
                this.cd7b8a84bcc59ebd89e4f9f7d58e2f137(tuple.Item1, tuple.Item2);
                return;
            }
          }
          else
          {
            ((Form) this).Close();
            break;
          }
      }
    }

    private void c0926fcb31053ec6082be2553bc552bf8(object c5382ad5461e274fda51b358802fc3910, ListViewItemEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c1737c2fea7bc70c3217f485e866febe6(c2c70c34e9090df0cdefc483e35740e07.cc50e3aad2c922bb7d7e65938629ab7b5(c9572d7ff9cd6a116e4a6f248ca68a831.get_Item().get_Tag()));
    }

    private void cdfad1e711ba827f4de7386494f8844a2(object c5382ad5461e274fda51b358802fc3910, ListViewItemMouseEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (c9572d7ff9cd6a116e4a6f248ca68a831.get_OriginalEventArgs().Button != (MouseButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12724))
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cdfad1e711ba827f4de7386494f8844a2);
            break;
        }
      }
      else
      {
        cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(((ListViewItemEventArgs) c9572d7ff9cd6a116e4a6f248ca68a831).get_Item().get_Tag());
        if (cce1cf1e0b6971ed6f7ef86a83b0959b6 == null)
        {
label_6:
          switch (2)
          {
            case 0:
              goto label_6;
          }
        }
        else
        {
          if (((ReadOnlyCollection<ListViewDataItem>) this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems()).Count < cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12728))
          {
label_9:
            switch (2)
            {
              case 0:
                goto label_9;
              default:
                this.ced13435d37c83d5695f389153255d7aa.set_SelectedItem(((ListViewItemEventArgs) c9572d7ff9cd6a116e4a6f248ca68a831).get_Item());
                break;
            }
          }
          if (((ReadOnlyCollection<ListViewDataItem>) this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems()).Count == 0)
          {
label_12:
            switch (4)
            {
              case 0:
                goto label_12;
            }
          }
          else
          {
            RadItem radItem1 = ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12732));
            int num1;
            if (cce1cf1e0b6971ed6f7ef86a83b0959b6.c2485b5906efc569b1c867e5c900b2e4e)
            {
label_14:
              switch (1)
              {
                case 0:
                  goto label_14;
                default:
                  num1 = ((ReadOnlyCollection<ListViewDataItem>) this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems()).Count == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12736) ? 1 : 0;
                  break;
              }
            }
            else
              num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12740);
            ((RadElement) radItem1).set_Enabled(num1 != 0);
            RadItem radItem2 = ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12744));
            int num2;
            if (cce1cf1e0b6971ed6f7ef86a83b0959b6.cf062de84cde10d9e953c8091a0e1b42b)
            {
label_18:
              switch (7)
              {
                case 0:
                  goto label_18;
                default:
                  num2 = ((ReadOnlyCollection<ListViewDataItem>) this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems()).Count == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12748) ? 1 : 0;
                  break;
              }
            }
            else
              num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12752);
            ((RadElement) radItem2).set_Enabled(num2 != 0);
            RadContextMenu cede9e5be54b12de354ccc761ad4fc4a1 = this.cede9e5be54b12de354ccc761ad4fc4a1;
            int x1 = c9572d7ff9cd6a116e4a6f248ca68a831.get_OriginalEventArgs().X;
            Point location = ((Form) this).Location;
            int x2 = location.X;
            int num3 = x1 + x2;
            location = ((Control) this.ced13435d37c83d5695f389153255d7aa).Location;
            int x3 = location.X;
            int num4 = num3 + x3;
            int y1 = c9572d7ff9cd6a116e4a6f248ca68a831.get_OriginalEventArgs().Y;
            location = ((Form) this).Location;
            int y2 = location.Y;
            int num5 = y1 + y2;
            location = ((Control) this.ced13435d37c83d5695f389153255d7aa).Location;
            int y3 = location.Y;
            int num6 = num5 + y3 + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12756);
            cede9e5be54b12de354ccc761ad4fc4a1.Show(num4, num6);
          }
        }
      }
    }

    private void c8de4f763b730f04a68cdf4528711bf9a(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ListViewDataItem selectedItem = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItem();
      object c33ad1bd311fd4b32b85377e9e15a9d93;
      if (selectedItem == null)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c8de4f763b730f04a68cdf4528711bf9a);
            }
            c33ad1bd311fd4b32b85377e9e15a9d93 = (object) null;
            break;
        }
      }
      else
        c33ad1bd311fd4b32b85377e9e15a9d93 = selectedItem.get_Tag();
      cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(c33ad1bd311fd4b32b85377e9e15a9d93);
      if (cce1cf1e0b6971ed6f7ef86a83b0959b6 == null)
      {
label_7:
        switch (4)
        {
          case 0:
            goto label_7;
        }
      }
      else
      {
        this.SelectedGame = cce1cf1e0b6971ed6f7ef86a83b0959b6;
        this.cbbe2a25a9e1bd7c18f28caea73bee829();
      }
    }

    private void cd14926deced4992ca415ad87542200ef(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      ListViewDetailColumn column = ((Collection<ListViewDetailColumn>) this.ced13435d37c83d5695f389153255d7aa.get_Columns())[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12760)];
      double num1 = (double) (((Control) this.ced13435d37c83d5695f389153255d7aa).Width - cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12764));
      ListViewColumnCollection columns = this.ced13435d37c83d5695f389153255d7aa.get_Columns();
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDetailColumn, float> selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c1ff935d5b5a85856d84288ea5fa37502;
      if (selector == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cd14926deced4992ca415ad87542200ef);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c1ff935d5b5a85856d84288ea5fa37502 = new Func<ListViewDetailColumn, float>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c2bc6764509561ee91f6aa0ef4fd5e370);
            break;
        }
      }
      double num2 = (double) ((IEnumerable<ListViewDetailColumn>) columns).Sum<ListViewDetailColumn>(selector) - (double) ((Collection<ListViewDetailColumn>) this.ced13435d37c83d5695f389153255d7aa.get_Columns())[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12768)].get_Width();
      double num3 = num1 - num2;
      column.set_Width((float) num3);
    }

    private void cb1cdf7eac43f1c6ca024640a68b13f1a(object c5382ad5461e274fda51b358802fc3910, ListViewItemEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.cc22795a3b7f696da1cccaeeed1defe68)
        return;
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cb1cdf7eac43f1c6ca024640a68b13f1a);
          }
          this.c6450bee67c17aaeb724d7d72619d430e();
          break;
      }
    }

    private void ca0665eaf182937ae3fc1ce08f55979f7(object c5382ad5461e274fda51b358802fc3910, ListViewItemMouseEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (c4c354a5c29e03443b4bf3413b3b1255c.cc50e3aad2c922bb7d7e65938629ab7b5((object) ((ListViewItemEventArgs) c9572d7ff9cd6a116e4a6f248ca68a831).get_Item()) != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ca0665eaf182937ae3fc1ce08f55979f7);
            }
            this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12772) != 0;
            IEnumerator<ListViewDataItem> enumerator = ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).get_Items().GetEnumerator();
            try
            {
              while (((IEnumerator) enumerator).MoveNext())
              {
                ListViewDataItem current = enumerator.Current;
                int num;
                if (current.get_Group() != ((ListViewItemEventArgs) c9572d7ff9cd6a116e4a6f248ca68a831).get_Item())
                {
label_7:
                  switch (6)
                  {
                    case 0:
                      goto label_7;
                    default:
                      num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12776);
                      break;
                  }
                }
                else
                  num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12780);
                current.set_CheckState((ToggleState) num);
              }
label_12:
              switch (1)
              {
                case 0:
                  goto label_12;
              }
            }
            finally
            {
              if (enumerator != null)
              {
label_14:
                switch (5)
                {
                  case 0:
                    goto label_14;
                  default:
                    ((IDisposable) enumerator).Dispose();
                    break;
                }
              }
            }
            this.cc22795a3b7f696da1cccaeeed1defe68 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12784) != 0;
            break;
        }
      }
      this.c6450bee67c17aaeb724d7d72619d430e();
    }

    private void c88d834acb00e4a8edcf574571764dde9(cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319, bool cddfa76a28ca10945f4e8559694979925, bool ceed3d316b73940c5c0ee0dc4beb18c17 = true)
    {
      c89cbac13be511053120093fce8049319.cd61c5f51f587495941f329dc6bffec54 = cddfa76a28ca10945f4e8559694979925;
      if (!ceed3d316b73940c5c0ee0dc4beb18c17)
        return;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c88d834acb00e4a8edcf574571764dde9);
          }
          this.c97f25335d6752a51249adc3a07b8266a(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12788) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12792) != 0);
          break;
      }
    }

    private void c4d7603f44e182524e7af57fd50e8d9af(object c5382ad5461e274fda51b358802fc3910, FormClosingEventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      try
      {
        Settings.Default.ShowCFW = this.ce9d74c4a67920ea005ae0e9c3e550195.Enabled;
        Settings.Default.ShowLegit = this.c6e10857a44dfe29229689f6f14eb8736.Enabled;
        Settings.Default.ShowEvents = this.cb09f0c811e9c104f30d9bdb57f5e4472.Enabled;
        Settings.Default.EUR = this.c290ca0dbd67a1dd201c0b196fec00bc4.Checked;
        Settings.Default.JPN = this.c4562184f7a172fc18d58e50d7047938d.Checked;
        Settings.Default.USA = this.cf582d9fa2e47e4f8707ea4db5c09db97.Checked;
        // ISSUE: variable of a compiler-generated type
        Settings settings = Settings.Default;
        string separator = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24302);
        List<Platform> platforms = this.Platforms;
        // ISSUE: reference to a compiler-generated field
        Func<Platform, int> selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cdde75e0b132b3f8bc365379954af5ade;
        if (selector == null)
        {
label_1:
          switch (7)
          {
            case 0:
              goto label_1;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c4d7603f44e182524e7af57fd50e8d9af);
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cdde75e0b132b3f8bc365379954af5ade = new Func<Platform, int>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cb08447c90f9506eaea8b9f5dbc8a9064);
              break;
          }
        }
        int[] array = platforms.Select<Platform, int>(selector).ToArray<int>();
        string str = string.Join<int>(separator, (IEnumerable<int>) array);
        settings.Platforms = str;
        Settings.Default.Save();
        this.cf784819be9ce7badf71e6945943fd72f();
        cba6aa8f767d2e8dfbca2d43d7148c173.cfa0952d727a09330dbc279563d1f513d();
        c4cd3182c1a92620e92b027ad11674ef9.cb6adf0c73c9376d391adb646e5fc3866((IEnumerable<c4cd3182c1a92620e92b027ad11674ef9>) ca377ebace9a9e1ffac7b0c5a9158e838.c21073ebf43998f89fc3064972034ee86);
      }
      catch
      {
      }
    }

    private void cc18fbaf5773c17b1ab5bace35c6a9199(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
      timer.Interval = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12796);
      EventHandler eventHandler1 = (EventHandler) ((ce62683be73de9c3f0be42a38f443ff33, c6849f16d3b35b1ad8eb6920cd50f7abf) => this.c08dac6046107bebae64a6a51d0d5c9fd());
      timer.Tick += eventHandler1;
      timer.Start();
      c6b6cd1274db5c3760ebd273284d15464 c6b6cd1274db5c3760ebd273284d15464 = new c6b6cd1274db5c3760ebd273284d15464();
      EventHandler<IPAddress> eventHandler2 = (EventHandler<IPAddress>) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, cc993020431218dd1868140562b121eea) =>
      {
        this.c57c5f34001f875aedca31488d7c223d5 = DateTime.Now;
        this.ca5aed60c2dab3ff1d5478c9ff4d2e495 = cc993020431218dd1868140562b121eea;
      });
      c6b6cd1274db5c3760ebd273284d15464.c216fa6b5069ca26468baa8aeee5f77bc += eventHandler2;
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12800);
      c6b6cd1274db5c3760ebd273284d15464.cf7908bdf1ba3f188e6255a17595c90c9(num1 != 0);
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Value = DateTime.Now;
      this.c761bc48a0ac5352d2a79834b62d8e9c7.MinDate = DateTime.Now;
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Format = (DateTimePickerFormat) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12804);
      this.c761bc48a0ac5352d2a79834b62d8e9c7.CustomFormat = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24305);
      ((Control) this).Text = c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(((Control) this).Text, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24338), Settings.Default.Region);
      this.Platforms = new List<Platform>();
      if (string.IsNullOrEmpty(Settings.Default.Platforms))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cc18fbaf5773c17b1ab5bace35c6a9199);
            }
            this.Platforms.AddRange(Enumerable.Cast<Platform>(System.Enum.GetValues(Type.GetTypeFromHandle(c2b595ab2309f3f58d01122973ca60e99.c6804baa30a51e813a45fabcfa2b27b79()))));
            break;
        }
      }
      else
      {
        try
        {
          List<Platform> platforms1 = this.Platforms;
          string platforms2 = Settings.Default.Platforms;
          char[] chArray = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12808));
          int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12812);
          int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12816);
          chArray[index] = (char) num2;
          string[] strArray = platforms2.Split(chArray);
          // ISSUE: reference to a compiler-generated field
          Func<string, Platform> selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c864d97fd39f4e229df944b08616c57f7;
          if (selector == null)
          {
label_6:
            switch (3)
            {
              case 0:
                goto label_6;
              default:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c864d97fd39f4e229df944b08616c57f7 = new Func<string, Platform>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c0e4c6002e76dc055671bcad19c9e1379);
                break;
            }
          }
          IEnumerable<Platform> collection = ((IEnumerable<string>) strArray).Select<string, Platform>(selector);
          platforms1.AddRange(collection);
        }
        catch
        {
          Settings.Default.Platforms = cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        }
      }
      int[] numArray1 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12820));
      int cecb96267e559a56c4f543488b117e4fc1 = 12824;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) numArray1, cecb96267e559a56c4f543488b117e4fc1);
      // ISSUE: reference to a compiler-generated field
      Func<int, Platform> selector1 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c4b77b5c1379e23a549258cd76a1b1fc8;
      if (selector1 == null)
      {
label_11:
        switch (6)
        {
          case 0:
            goto label_11;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            selector1 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c4b77b5c1379e23a549258cd76a1b1fc8 = new Func<int, Platform>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c2d76b1f87c13f29d973c490d34681d83);
            break;
        }
      }
      List<Platform> list1 = ((IEnumerable<int>) numArray1).Select<int, Platform>(selector1).ToList<Platform>();
      int[] numArray2 = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12873));
      int cecb96267e559a56c4f543488b117e4fc2 = 12877;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) numArray2, cecb96267e559a56c4f543488b117e4fc2);
      // ISSUE: reference to a compiler-generated field
      Func<int, Platform> selector2 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c1bcddeb53a9edfb06adbfcca46a1a32f;
      if (selector2 == null)
      {
label_14:
        switch (6)
        {
          case 0:
            goto label_14;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            selector2 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c1bcddeb53a9edfb06adbfcca46a1a32f = new Func<int, Platform>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c69f442f6619cc6bc4f4fc1d51eea59c2);
            break;
        }
      }
      List<Platform> list2 = ((IEnumerable<int>) numArray2).Select<int, Platform>(selector2).ToList<Platform>();
      ListViewDataItemGroup viewDataItemGroup1 = new ListViewDataItemGroup(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24379));
      ListViewDataItemGroup viewDataItemGroup2 = new ListViewDataItemGroup(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24390));
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).set_EnableCustomGrouping(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12934) != 0);
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).set_EnableGrouping(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12938) != 0);
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).set_ShowGroups(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12942) != 0);
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).get_Groups().Add(viewDataItemGroup1);
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).get_Groups().Add(viewDataItemGroup2);
      string[] names = System.Enum.GetNames(Type.GetTypeFromHandle(c2b595ab2309f3f58d01122973ca60e99.c6804baa30a51e813a45fabcfa2b27b79()));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12946);
      while (index1 < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(names))
      {
        string str = names[index1];
        ListViewDataItem listViewDataItem1 = new ListViewDataItem(str.Replace((char) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12950), (char) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12954)));
        object obj = System.Enum.Parse(Type.GetTypeFromHandle(c2b595ab2309f3f58d01122973ca60e99.c6804baa30a51e813a45fabcfa2b27b79()), str);
        listViewDataItem1.set_Tag(obj);
        int num2;
        if (!this.Platforms.Contains(cf7b2699f772083447367b2772237767c.c266cc793747f741ea3de85f7a5f5e6a8(System.Enum.Parse(Type.GetTypeFromHandle(c2b595ab2309f3f58d01122973ca60e99.c6804baa30a51e813a45fabcfa2b27b79()), str))))
        {
label_18:
          switch (7)
          {
            case 0:
              goto label_18;
            default:
              num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12958);
              break;
          }
        }
        else
          num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12962);
        listViewDataItem1.set_CheckState((ToggleState) num2);
        ListViewDataItem listViewDataItem2 = listViewDataItem1;
        if (list1.Contains(cf7b2699f772083447367b2772237767c.c266cc793747f741ea3de85f7a5f5e6a8(listViewDataItem2.get_Tag())))
        {
label_22:
          switch (6)
          {
            case 0:
              goto label_22;
            default:
              listViewDataItem2.set_Group(viewDataItemGroup1);
              break;
          }
        }
        if (list2.Contains(cf7b2699f772083447367b2772237767c.c266cc793747f741ea3de85f7a5f5e6a8(listViewDataItem2.get_Tag())))
        {
label_25:
          switch (2)
          {
            case 0:
              goto label_25;
            default:
              listViewDataItem2.set_Group(viewDataItemGroup2);
              break;
          }
        }
        if (listViewDataItem2.get_Group() != null)
        {
label_28:
          switch (1)
          {
            case 0:
              goto label_28;
            default:
              ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).get_Items().Add(listViewDataItem2);
              break;
          }
        }
        index1 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12966);
      }
label_32:
      switch (7)
      {
        case 0:
          goto label_32;
        default:
          RadMessageBox.set_ShowInTaskbar(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12970) != 0);
          if (ApplicationDeployment.IsNetworkDeployed)
          {
label_34:
            switch (7)
            {
              case 0:
                goto label_34;
              default:
                ((Control) this).Text = cd51fd1e6acc9fb6d0cf7503c15cb0a6f.c1df95097ffa57d753c5fe1353cf65e86((object) ((Control) this).Text, (object) c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24415), (object) ApplicationDeployment.CurrentDeployment.CurrentVersion);
                break;
            }
          }
          else if (c2d4baf2bd055f4368cf2297e4ff33900.c907ca8ffa30661318a7e29e77519ea57 != null)
          {
label_37:
            switch (5)
            {
              case 0:
                goto label_37;
              default:
                ((Control) this).Text = c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(((Control) this).Text, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24415), c2d4baf2bd055f4368cf2297e4ff33900.c907ca8ffa30661318a7e29e77519ea57);
                break;
            }
          }
          if (!c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(Settings.Default.Path))
          {
label_40:
            switch (7)
            {
              case 0:
                goto label_40;
              default:
                if (!c1b7cf6218f1f498aba267c6450ec9233.cc280c8ccf354d2ee7188ab5afd61f109(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12974) != 0))
                {
label_42:
                  switch (6)
                  {
                    case 0:
                      goto label_42;
                    default:
                      ((Form) this).Close();
                      return;
                  }
                }
                else
                  break;
            }
          }
          ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).BackColor = ((Control) this).BackColor;
          ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).Select();
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12978))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
          {
            ListViewSelectedItemCollection selectedItems = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems();
            // ISSUE: reference to a compiler-generated field
            Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c5c1224a7c0bf250ef0981a04ec593ee0;
            if (selector3 == null)
            {
label_1:
              switch (7)
              {
                case 0:
                  goto label_1;
                default:
                  if (1 == 0)
                  {
                    // ISSUE: method reference
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c5ee93eeec16e5b0cefcef9e8018a4e4d);
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c5c1224a7c0bf250ef0981a04ec593ee0 = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c4fd0e78e598a1a7399382fae5e1c47fa);
                  break;
              }
            }
            IEnumerator<cce1cf1e0b6971ed6f7ef86a83b0959b6> enumerator = ((IEnumerable<ListViewDataItem>) selectedItems).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector3).GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
                this.cd660ef369e4674e4d70b339bf2da51d1(enumerator.Current);
label_9:
              switch (7)
              {
                case 0:
                  goto label_9;
              }
            }
            finally
            {
              if (enumerator != null)
              {
label_12:
                switch (5)
                {
                  case 0:
                    goto label_12;
                  default:
                    enumerator.Dispose();
                    break;
                }
              }
            }
          }));
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12982))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
          {
            c58509175cbe634f2808d2fefd16ab8d3 c58509175cbe634f2808d2fefd16ab8d3 = new c58509175cbe634f2808d2fefd16ab8d3((IEnumerable<ce64fe4baff0b285aaecd02e2cae2ea2c>) c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(((ReadOnlyCollection<ListViewDataItem>) this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems())[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19470)].get_Tag()).Updates, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19474) != 0);
            if (((Form) c58509175cbe634f2808d2fefd16ab8d3).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19478))
            {
label_1:
              switch (3)
              {
                case 0:
                  goto label_1;
                default:
                  if (1 != 0)
                    break;
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cae49c01b3a89c7fc4bb0e3fb9a9ef585);
                  break;
              }
            }
            else
            {
              using (List<ce64fe4baff0b285aaecd02e2cae2ea2c>.Enumerator enumerator = c58509175cbe634f2808d2fefd16ab8d3.cb917dff3a4bc5ccb946b4a838034a862.GetEnumerator())
              {
                while (enumerator.MoveNext())
                  this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) enumerator.Current);
label_9:
                switch (2)
                {
                  case 0:
                    goto label_9;
                }
              }
            }
          }));
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12986))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) => this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(((ReadOnlyCollection<ListViewDataItem>) this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems())[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19482)].get_Tag()).Dlc)));
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12990))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
          {
            ListViewSelectedItemCollection selectedItems = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems();
            // ISSUE: reference to a compiler-generated field
            Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c16a9d417078d34a8046a836b67073cef;
            if (selector3 == null)
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
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cbf2c5c83e798a32708f07353248e1607);
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c16a9d417078d34a8046a836b67073cef = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c40c7796c6cf07894bb6a7b061d3e3ba8);
                  break;
              }
            }
            IEnumerator<cce1cf1e0b6971ed6f7ef86a83b0959b6> enumerator = ((IEnumerable<ListViewDataItem>) selectedItems).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector3).GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
                this.c5f56f279f7c240ac9c4a9351a66b1049(enumerator.Current);
label_9:
              switch (3)
              {
                case 0:
                  goto label_9;
              }
            }
            finally
            {
              if (enumerator != null)
              {
label_12:
                switch (1)
                {
                  case 0:
                    goto label_12;
                  default:
                    enumerator.Dispose();
                    break;
                }
              }
            }
          }));
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12994))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
          {
            ListViewSelectedItemCollection selectedItems = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems();
            // ISSUE: reference to a compiler-generated field
            Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cad18a6058c38e078ac43b2fb1ea8daef;
            if (selector3 == null)
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
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c0bee80570faf08025572a1a82ab73866);
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cad18a6058c38e078ac43b2fb1ea8daef = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c008546f89a324ec9739a4c57d9ef5279);
                  break;
              }
            }
            cce1cf1e0b6971ed6f7ef86a83b0959b6[] array = ((IEnumerable<ListViewDataItem>) selectedItems).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector3).ToArray<cce1cf1e0b6971ed6f7ef86a83b0959b6>();
            int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19486);
            while (index2 < (int) c684002ae514b990dbb262e614e17a28f.c572aba370be49804cbdb0b35312bea94(array))
            {
              this.cb6779a12dc18aa08dc1f9edef1bd2a32(array[index2]);
              index2 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19490);
            }
label_8:
            switch (5)
            {
              case 0:
                goto label_8;
            }
          }));
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(12998))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
          {
            ListViewSelectedItemCollection selectedItems = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems();
            // ISSUE: reference to a compiler-generated field
            Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c678aed4fcd8db1f679d6fbc342bafa96;
            if (selector3 == null)
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
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c909c40d13ba74e87d48924397e159bfa);
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c678aed4fcd8db1f679d6fbc342bafa96 = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c700258f88babf95514acf1492840043b);
                  break;
              }
            }
            cce1cf1e0b6971ed6f7ef86a83b0959b6[] array = ((IEnumerable<ListViewDataItem>) selectedItems).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector3).ToArray<cce1cf1e0b6971ed6f7ef86a83b0959b6>();
            int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19494);
            while (index2 < (int) c684002ae514b990dbb262e614e17a28f.c572aba370be49804cbdb0b35312bea94(array))
            {
              this.c88d834acb00e4a8edcf574571764dde9(array[index2], cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19498) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19502) != 0);
              index2 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19506);
            }
label_8:
            switch (2)
            {
              case 0:
                goto label_8;
              default:
                this.cbbe2a25a9e1bd7c18f28caea73bee829();
                this.c97f25335d6752a51249adc3a07b8266a(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19510) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19514) != 0);
                break;
            }
          }));
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13002))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
          {
            ListViewSelectedItemCollection selectedItems = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems();
            // ISSUE: reference to a compiler-generated field
            Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cc2ae87522264594c133dcdddc50a0acf;
            if (selector3 == null)
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
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c2864122729a7483602ba9dc6f276a4f5);
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.cc2ae87522264594c133dcdddc50a0acf = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c1233d61fd7a5c90c7b971c41240411a2);
                  break;
              }
            }
            cce1cf1e0b6971ed6f7ef86a83b0959b6[] array = ((IEnumerable<ListViewDataItem>) selectedItems).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector3).ToArray<cce1cf1e0b6971ed6f7ef86a83b0959b6>();
            int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19518);
            while (index2 < (int) c684002ae514b990dbb262e614e17a28f.c572aba370be49804cbdb0b35312bea94(array))
            {
              this.c88d834acb00e4a8edcf574571764dde9(array[index2], cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19522) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19526) != 0);
              index2 += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19530);
            }
label_8:
            switch (2)
            {
              case 0:
                goto label_8;
              default:
                this.cbbe2a25a9e1bd7c18f28caea73bee829();
                this.c97f25335d6752a51249adc3a07b8266a(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19534) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19538) != 0);
                break;
            }
          }));
          ((RadElement) ((RadItemCollection) this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items()).get_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13006))).add_Click((EventHandler) ((c6b3a8e204bc8a56126ccc5bdce46b0e4, c35ef8b45dc1b4f9c689c88c6aa3b9c3c) =>
          {
            ListViewSelectedItemCollection selectedItems1 = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems();
            // ISSUE: reference to a compiler-generated field
            Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c2fe4b835305ee2e61641fd703b5f3a73;
            if (selector3 == null)
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
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cbe5ad5354ad792fbab2c1e49b2323434);
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  selector3 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c2fe4b835305ee2e61641fd703b5f3a73 = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c1ba7aac27bc1f0af166acec64b98f554);
                  break;
              }
            }
            IEnumerable<cce1cf1e0b6971ed6f7ef86a83b0959b6> source1 = ((IEnumerable<ListViewDataItem>) selectedItems1).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector3);
            // ISSUE: reference to a compiler-generated field
            Func<cce1cf1e0b6971ed6f7ef86a83b0959b6, bool> predicate1 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c8f43468e07d5963085bb1c199feb18f2;
            if (predicate1 == null)
            {
label_6:
              switch (5)
              {
                case 0:
                  goto label_6;
                default:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  predicate1 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c8f43468e07d5963085bb1c199feb18f2 = new Func<cce1cf1e0b6971ed6f7ef86a83b0959b6, bool>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c4668c5335e6857fa852ce46ac2339276);
                  break;
              }
            }
            if (!source1.All<cce1cf1e0b6971ed6f7ef86a83b0959b6>(predicate1))
            {
label_9:
              switch (6)
              {
                case 0:
                  goto label_9;
                default:
                  if (!c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(Settings.Default.ExtractFolder))
                  {
label_11:
                    switch (7)
                    {
                      case 0:
                        goto label_11;
                      default:
                        this.c297af215a9d7fad2a9905d615aecb285(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19542) != 0);
                        break;
                    }
                  }
                  if (!c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(Settings.Default.ExtractFolder))
                  {
label_14:
                    switch (7)
                    {
                      case 0:
                        goto label_14;
                      default:
                        this.cfca5afdf2670089d1cdac0de57c626aa(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34582));
                        return;
                    }
                  }
                  else
                    break;
              }
            }
            ListViewSelectedItemCollection selectedItems2 = this.ced13435d37c83d5695f389153255d7aa.get_SelectedItems();
            // ISSUE: reference to a compiler-generated field
            Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6> selector4 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c9e420d42d8d4d9220912119bd3b37b5b;
            if (selector4 == null)
            {
label_17:
              switch (1)
              {
                case 0:
                  goto label_17;
                default:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  selector4 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c9e420d42d8d4d9220912119bd3b37b5b = new Func<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c1c32699165d00efc6f7186ce42aeac50);
                  break;
              }
            }
            IEnumerable<cce1cf1e0b6971ed6f7ef86a83b0959b6> source2 = ((IEnumerable<ListViewDataItem>) selectedItems2).Select<ListViewDataItem, cce1cf1e0b6971ed6f7ef86a83b0959b6>(selector4);
            // ISSUE: reference to a compiler-generated field
            Func<cce1cf1e0b6971ed6f7ef86a83b0959b6, bool> predicate2 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c2f7706d93c10a7e00df720b4d67ace09;
            if (predicate2 == null)
            {
label_20:
              switch (3)
              {
                case 0:
                  goto label_20;
                default:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  predicate2 = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c2f7706d93c10a7e00df720b4d67ace09 = new Func<cce1cf1e0b6971ed6f7ef86a83b0959b6, bool>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cf946fc1f230c7d0b3533d6ae27a5713c);
                  break;
              }
            }
            IEnumerator<cce1cf1e0b6971ed6f7ef86a83b0959b6> enumerator1 = source2.Where<cce1cf1e0b6971ed6f7ef86a83b0959b6>(predicate2).GetEnumerator();
            try
            {
              while (enumerator1.MoveNext())
              {
                cce1cf1e0b6971ed6f7ef86a83b0959b6 current = enumerator1.Current;
                if (current.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19546))
                {
label_25:
                  switch (7)
                  {
                    case 0:
                      goto label_25;
                    default:
                      c5ac1c83c6771f1d2ec2730d47af7105b c5ac1c83c6771f1d2ec2730d47af7105b = new c5ac1c83c6771f1d2ec2730d47af7105b(current, (WhatToAction) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19550));
                      if (((Form) c5ac1c83c6771f1d2ec2730d47af7105b).ShowDialog() == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19554))
                      {
label_27:
                        switch (6)
                        {
                          case 0:
                            goto label_27;
                          default:
                            if (c5ac1c83c6771f1d2ec2730d47af7105b.CopyDlc)
                            {
label_29:
                              switch (2)
                              {
                                case 0:
                                  goto label_29;
                                default:
                                  int num2 = (int) ((Form) new cd31cf38d8c521c96d342d3061f93a308((cba6aa8f767d2e8dfbca2d43d7148c173) current.Dlc, Settings.Default.ExtractFolder)).ShowDialog();
                                  break;
                              }
                            }
                            if (c5ac1c83c6771f1d2ec2730d47af7105b.CopyGame)
                            {
label_32:
                              switch (5)
                              {
                                case 0:
                                  goto label_32;
                                default:
                                  int num2 = (int) ((Form) new cd31cf38d8c521c96d342d3061f93a308((cba6aa8f767d2e8dfbca2d43d7148c173) current, Settings.Default.ExtractFolder)).ShowDialog();
                                  break;
                              }
                            }
                            if (c5ac1c83c6771f1d2ec2730d47af7105b.CopyUpdate)
                            {
label_35:
                              switch (6)
                              {
                                case 0:
                                  goto label_35;
                                default:
                                  using (List<ce64fe4baff0b285aaecd02e2cae2ea2c>.Enumerator enumerator2 = c5ac1c83c6771f1d2ec2730d47af7105b.cb917dff3a4bc5ccb946b4a838034a862.GetEnumerator())
                                  {
                                    while (enumerator2.MoveNext())
                                    {
                                      int num2 = (int) ((Form) new cd31cf38d8c521c96d342d3061f93a308((cba6aa8f767d2e8dfbca2d43d7148c173) enumerator2.Current, Settings.Default.ExtractFolder)).ShowDialog();
                                    }
label_40:
                                    switch (6)
                                    {
                                      case 0:
                                        goto label_40;
                                      default:
                                        continue;
                                    }
                                  }
                              }
                            }
                            else
                              continue;
                        }
                      }
                      else
                        continue;
                  }
                }
                else
                {
                  SaveFileDialog saveFileDialog = new SaveFileDialog()
                  {
                    Filter = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34619),
                    DefaultExt = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34664),
                    FileName = current.Name
                  };
                  if (saveFileDialog.ShowDialog() == (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19558))
                  {
label_43:
                    switch (6)
                    {
                      case 0:
                        goto label_43;
                      default:
                        current.cf3c2ef6791ee577bd0d826b0b9bfb71e(Path.GetDirectoryName(saveFileDialog.FileName), current.Name);
                        continue;
                    }
                  }
                }
              }
label_46:
              switch (4)
              {
                case 0:
                  goto label_46;
              }
            }
            finally
            {
              if (enumerator1 != null)
              {
label_49:
                switch (3)
                {
                  case 0:
                    goto label_49;
                  default:
                    enumerator1.Dispose();
                    break;
                }
              }
            }
          }));
          this.ced13435d37c83d5695f389153255d7aa.get_Groups().Add(this.c372877fe2d9144e1cb18b2595dc22d35);
          this.ced13435d37c83d5695f389153255d7aa.get_Groups().Add(this.c345b87dcdd353817ec1c2dcc203013dd);
          this.ced13435d37c83d5695f389153255d7aa.get_Groups().Add(this.cd41603f532612b3c4db58836b4123799);
          this.ced13435d37c83d5695f389153255d7aa.get_Groups().Add(this.cff1795ccc74a7799df34e56a77438ae5);
          break;
      }
    }

    private void c728ee9a33a735d47aaedf0f96c773b94(object c5382ad5461e274fda51b358802fc3910, c08d29affad9d3e42fb3f986fdfc029ee c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.ccb8c69fc68341618821131d83b16a768 ccb8c69fc68341618821131d83b16a768 = new c1b7cf6218f1f498aba267c6450ec9233.ccb8c69fc68341618821131d83b16a768();
      // ISSUE: reference to a compiler-generated field
      ccb8c69fc68341618821131d83b16a768.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      ccb8c69fc68341618821131d83b16a768.c9572d7ff9cd6a116e4a6f248ca68a831 = c9572d7ff9cd6a116e4a6f248ca68a831;
      try
      {
        // ISSUE: reference to a compiler-generated method
        ((Control) this).Invoke((Delegate) new Action(ccb8c69fc68341618821131d83b16a768.c03ea52e3ea354dbecd6160da1f5afc02));
        cfe932de17c0b76a7d538ca2ed7c3f2c6.cc50e3aad2c922bb7d7e65938629ab7b5(c5382ad5461e274fda51b358802fc3910).c5846ace0cdb1d06c3c6526c2cd7db94c -= new EventHandler<c08d29affad9d3e42fb3f986fdfc029ee>(this.c728ee9a33a735d47aaedf0f96c773b94);
      }
      catch
      {
      }
    }

    private void ca302469de2ea989713b3a18d5c5f6628(object c5382ad5461e274fda51b358802fc3910, c08d29affad9d3e42fb3f986fdfc029ee c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c2a66b43d65d349ab8870700f61e27da9 c2a66b43d65d349ab8870700f61e27da9 = new c1b7cf6218f1f498aba267c6450ec9233.c2a66b43d65d349ab8870700f61e27da9();
      // ISSUE: reference to a compiler-generated field
      c2a66b43d65d349ab8870700f61e27da9.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      c2a66b43d65d349ab8870700f61e27da9.c9572d7ff9cd6a116e4a6f248ca68a831 = c9572d7ff9cd6a116e4a6f248ca68a831;
      try
      {
        // ISSUE: reference to a compiler-generated method
        ((Control) this).Invoke((Delegate) new Action(c2a66b43d65d349ab8870700f61e27da9.c260d005da9bba25463b1d67524cab4f6));
        cfe932de17c0b76a7d538ca2ed7c3f2c6.cc50e3aad2c922bb7d7e65938629ab7b5(c5382ad5461e274fda51b358802fc3910).c5846ace0cdb1d06c3c6526c2cd7db94c -= new EventHandler<c08d29affad9d3e42fb3f986fdfc029ee>(this.ca302469de2ea989713b3a18d5c5f6628);
      }
      catch
      {
      }
    }

    private void c5096bbd2f3958dfbc93f74090981758b(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      if (this.SelectedGame == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c5096bbd2f3958dfbc93f74090981758b);
            break;
        }
      }
      else
      {
        DialogResult dialogResult = RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24426), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24628), (MessageBoxButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13010));
        if (dialogResult != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13014))
        {
label_6:
          switch (3)
          {
            case 0:
              goto label_6;
            default:
              if (dialogResult != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13018))
                break;
label_8:
              switch (1)
              {
                case 0:
                  goto label_8;
                default:
                  OpenFileDialog openFileDialog1 = new OpenFileDialog();
                  int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13022);
                  openFileDialog1.CheckFileExists = num != 0;
                  string str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24653);
                  openFileDialog1.Filter = str;
                  OpenFileDialog openFileDialog2 = openFileDialog1;
                  if (openFileDialog2.ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13026))
                  {
label_10:
                    switch (6)
                    {
                      case 0:
                        goto label_10;
                      default:
                        return;
                    }
                  }
                  else
                  {
                    Image image = Image.FromStream((Stream) new MemoryStream(System.IO.File.ReadAllBytes(openFileDialog2.FileName)));
                    this.cc5109af75315520586ca50d6cd84c973.Image = image;
                    MemoryStream memoryStream = new MemoryStream();
                    try
                    {
                      image.Save((Stream) memoryStream, ImageFormat.Png);
                      c6a07387c2f827de6ca155929a5452624.cafcbd78f0cd6b1f81f0258dccfdc655f(new Uri(this.SelectedGame.c98811397437cb243dba328d121c6f691), memoryStream.ToArray());
                      return;
                    }
                    finally
                    {
                      if (memoryStream != null)
                      {
label_15:
                        switch (5)
                        {
                          case 0:
                            goto label_15;
                          default:
                            memoryStream.Dispose();
                            break;
                        }
                      }
                    }
                  }
              }
          }
        }
        else
        {
          byte[] buffer = cee3593822ec8de8fac12bd472c140bd6.ccefa4e680ce6690d29bb083197d0983e(this.SelectedGame.c98811397437cb243dba328d121c6f691, TimeSpan.Zero);
          if (buffer == null)
          {
label_19:
            switch (7)
            {
              case 0:
                goto label_19;
            }
          }
          else
            this.cc5109af75315520586ca50d6cd84c973.Image = Image.FromStream((Stream) new MemoryStream(buffer));
        }
      }
    }

    private void cf9caca46a59e7b29ca89c7aa99541646()
    {
      try
      {
        this.ce80e9c4fe52e3d87d4027237a6cc9bb1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13030) != 0;
        IEnumerator<ListViewDataItem> enumerator = this.ced13435d37c83d5695f389153255d7aa.get_Items().GetEnumerator();
        try
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            c1b7cf6218f1f498aba267c6450ec9233.c8462ea4e3c703eed5415e7fad1acee68 c8462ea4e3c703eed5415e7fad1acee68 = new c1b7cf6218f1f498aba267c6450ec9233.c8462ea4e3c703eed5415e7fad1acee68();
            // ISSUE: reference to a compiler-generated field
            c8462ea4e3c703eed5415e7fad1acee68.ccb669e105f1c11f33e60c076fc8cca42 = this;
            // ISSUE: reference to a compiler-generated field
            c8462ea4e3c703eed5415e7fad1acee68.c128bc9ed4fdbc6f9ff47c5824fa8152e = enumerator.Current;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            c1b7cf6218f1f498aba267c6450ec9233.cf7aa23d72c28da99e2dc3047956e6d97 cf7aa23d72c28da99e2dc3047956e6d97 = new c1b7cf6218f1f498aba267c6450ec9233.cf7aa23d72c28da99e2dc3047956e6d97();
            // ISSUE: reference to a compiler-generated field
            cf7aa23d72c28da99e2dc3047956e6d97.c10051687c186d4463c40ec142db943cf = c8462ea4e3c703eed5415e7fad1acee68;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            cf7aa23d72c28da99e2dc3047956e6d97.c3cab5319dc016deb050deb101e927b2f = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(cf7aa23d72c28da99e2dc3047956e6d97.c10051687c186d4463c40ec142db943cf.c128bc9ed4fdbc6f9ff47c5824fa8152e.get_Tag());
            // ISSUE: reference to a compiler-generated field
            if (cf7aa23d72c28da99e2dc3047956e6d97.c3cab5319dc016deb050deb101e927b2f != null)
            {
label_3:
              switch (5)
              {
                case 0:
                  goto label_3;
                default:
                  if (1 == 0)
                  {
                    // ISSUE: method reference
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cf9caca46a59e7b29ca89c7aa99541646);
                  }
                  Thread.Sleep(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13034));
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  cf7aa23d72c28da99e2dc3047956e6d97.c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.c5846ace0cdb1d06c3c6526c2cd7db94c += new EventHandler<c08d29affad9d3e42fb3f986fdfc029ee>(cf7aa23d72c28da99e2dc3047956e6d97.cdebce8f58accd4f3049a3d4a8b90904d);
                  if (this.ce80e9c4fe52e3d87d4027237a6cc9bb1)
                  {
label_7:
                    switch (1)
                    {
                      case 0:
                        goto label_7;
                      default:
                        return;
                    }
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    ((Control) this).Invoke((Delegate) new Action(cf7aa23d72c28da99e2dc3047956e6d97.c10051687c186d4463c40ec142db943cf.c071c1eb0e82810fd6db7bb5e2b7cb7d6));
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    cf7aa23d72c28da99e2dc3047956e6d97.c3cab5319dc016deb050deb101e927b2f.cee7644d811ec48c3e6a2526d09e8524b.cf94a1c9fccab23f0d9a24711be16790b(cf7aa23d72c28da99e2dc3047956e6d97.c3cab5319dc016deb050deb101e927b2f.IconUrl, TimeSpan.FromDays(cb85779efa5f9c78fa841b92dceca9094.cc355471519aa13f05c72ce1708ca5624(13038)));
                    continue;
                  }
              }
            }
          }
label_11:
          switch (1)
          {
            case 0:
              goto label_11;
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_14:
            switch (5)
            {
              case 0:
                goto label_14;
              default:
                ((IDisposable) enumerator).Dispose();
                break;
            }
          }
        }
      }
      catch
      {
      }
    }

    private void c8d16b41b307bf2496c3316a03cdcf259(object c5382ad5461e274fda51b358802fc3910, cdf40c9764a014ff068a86edd8ace4556 cccf482ee689904a1a8630dac14e0a6a0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c49dfe1568d405e9df7eaaeb5d98d64ac c49dfe1568d405e9df7eaaeb5d98d64ac = new c1b7cf6218f1f498aba267c6450ec9233.c49dfe1568d405e9df7eaaeb5d98d64ac();
      // ISSUE: reference to a compiler-generated field
      c49dfe1568d405e9df7eaaeb5d98d64ac.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      c49dfe1568d405e9df7eaaeb5d98d64ac.cccf482ee689904a1a8630dac14e0a6a0 = cccf482ee689904a1a8630dac14e0a6a0;
      try
      {
        // ISSUE: explicit non-virtual call
        if (!__nonvirtual (((Control) this).InvokeRequired))
          return;
label_2:
        switch (2)
        {
          case 0:
            goto label_2;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c8d16b41b307bf2496c3316a03cdcf259);
            }
            // ISSUE: reference to a compiler-generated method
            ((Control) this).Invoke((Delegate) new Action(c49dfe1568d405e9df7eaaeb5d98d64ac.c514e43161e6dc6407f4670d03f52b9f5));
            break;
        }
      }
      catch
      {
      }
    }

    private void c0a6ea2a725f4eff55eb6f116b2de4d29(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      int num = (int) ((Form) new ca8dab5d81ce3d2e8a9d2db0335274513(ca377ebace9a9e1ffac7b0c5a9158e838.c21073ebf43998f89fc3064972034ee86)).ShowDialog();
      this.c884bc8ac4a1f786b3291d2be37bd5f1b((object) this, c3978a42df3e901949e27aa5a5768ff04.c20c00b8e97bb4c0fb2b7ac6facf98b91);
    }

    private void c3dca125ca7d692247db92e4c3f5495c3(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      try
      {
        Uri uri = new Uri(((Control) this.ceb96360e1866456699fd2a748e058db6).Text);
        NetworkCredential networkCredential = new NetworkCredential(((Control) this.c67131d5ebad4559120841e7d6afbf050).Text, ((Control) this.cadd2602239e2a87754cb1203ec048ce7).Text);
        WebProxy webProxy1 = new WebProxy()
        {
          Address = uri,
          Credentials = (ICredentials) networkCredential
        };
        HttpWebRequest httpWebRequest = ce6f57d5474e6cfc49a8cf815a40f0eb6.cc8e287d5350b43026d33bb80beb131a0((object) WebRequest.Create(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24829)));
        WebProxy webProxy2 = webProxy1;
        httpWebRequest.Proxy = (IWebProxy) webProxy2;
        int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13046);
        httpWebRequest.Timeout = num;
        string str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(3104);
        httpWebRequest.Method = str;
        WebResponse response = httpWebRequest.GetResponse();
        try
        {
          this.Proxy = webProxy1;
        }
        finally
        {
          if (response != null)
          {
label_3:
            switch (3)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c3dca125ca7d692247db92e4c3f5495c3);
                }
                response.Dispose();
                break;
            }
          }
        }
        ((Control) this.cded9ed150a9ac47f6949a468fac193a6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24874);
        ((Control) this.cded9ed150a9ac47f6949a468fac193a6).ForeColor = Color.Green;
      }
      catch (Exception ex)
      {
        this.c4d42c560b9fe1667228666289ee2012d();
        int num = (int) RadMessageBox.Show(ex.Message);
      }
    }

    private void c2c926829a79cf57c9424a7fb0b168dee(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      c2e2f19e8cde9983e4129b4a047c9f5c6 cbd687f998e72be3a53e9ec30b343fc9f = this.cbd687f998e72be3a53e9ec30b343fc9f;
      if (cbd687f998e72be3a53e9ec30b343fc9f == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c2c926829a79cf57c9424a7fb0b168dee);
            }
            break;
        }
      }
      else
      {
        long num = (long) c0097b67418072fc17ee5f6b628c5e30b.c1df95097ffa57d753c5fe1353cf65e86(this.c560a6e04507a6b91381df70d8ba999e6.get_Value()) * (long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13050);
        cbd687f998e72be3a53e9ec30b343fc9f.ccca69f3508da99605b80cc92c45f56bb((ulong) num);
      }
    }

    private void c6450bee67c17aaeb724d7d72619d430e()
    {
      this.c1b3342d3caba36a1ab8d04032698545d();
      ((ListViewDataItem) this.c345b87dcdd353817ec1c2dcc203013dd).set_Text(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24881), (object) this.c345b87dcdd353817ec1c2dcc203013dd.get_Items().get_Count()));
      ((ListViewDataItem) this.c372877fe2d9144e1cb18b2595dc22d35).set_Text(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24914), (object) this.c372877fe2d9144e1cb18b2595dc22d35.get_Items().get_Count()));
      ((ListViewDataItem) this.cd41603f532612b3c4db58836b4123799).set_Text(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24945), (object) this.cd41603f532612b3c4db58836b4123799.get_Items().get_Count()));
      ((ListViewDataItem) this.cff1795ccc74a7799df34e56a77438ae5).set_Text(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24998), (object) this.cff1795ccc74a7799df34e56a77438ae5.get_Items().get_Count()));
      ((Control) this.c659877bdbb8d30820909c7b85d4f6330).Text = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25039), (object) this.ced13435d37c83d5695f389153255d7aa.get_Items().get_Count());
    }

    private void c1737c2fea7bc70c3217f485e866febe6(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.cb0f67784935952658081b2611e3a8b87 cb0f67784935952658081b2611e3a8b87 = new c1b7cf6218f1f498aba267c6450ec9233.cb0f67784935952658081b2611e3a8b87();
      // ISSUE: reference to a compiler-generated field
      cb0f67784935952658081b2611e3a8b87.c36dd98eb0c08ea087627a40c6663c9a8 = c36dd98eb0c08ea087627a40c6663c9a8;
      // ISSUE: reference to a compiler-generated field
      this.TitlesToCopy.Remove(cb0f67784935952658081b2611e3a8b87.c36dd98eb0c08ea087627a40c6663c9a8);
      // ISSUE: reference to a compiler-generated method
      this.c0ebc97b073a7d0dba554313d3f62139d.get_Items().Remove(((IEnumerable<ListViewDataItem>) this.c0ebc97b073a7d0dba554313d3f62139d.get_Items()).First<ListViewDataItem>(new Func<ListViewDataItem, bool>(cb0f67784935952658081b2611e3a8b87.c78ead72462d4fc47b045f81101e0cd80)));
      this.c0920b14ec7a66a99cdce1ebbad123147();
    }

    private void cbc50580a57af8c859936f77b72544977(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c616076ac14a47ddc86586e992ec2a03d c616076ac14a47ddc86586e992ec2a03d = new c1b7cf6218f1f498aba267c6450ec9233.c616076ac14a47ddc86586e992ec2a03d();
      // ISSUE: reference to a compiler-generated field
      c616076ac14a47ddc86586e992ec2a03d.c36dd98eb0c08ea087627a40c6663c9a8 = c36dd98eb0c08ea087627a40c6663c9a8;
      // ISSUE: reference to a compiler-generated field
      this.TitlesToDownload.Remove(c616076ac14a47ddc86586e992ec2a03d.c36dd98eb0c08ea087627a40c6663c9a8);
      // ISSUE: reference to a compiler-generated method
      this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items().Remove(((IEnumerable<ListViewDataItem>) this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items()).First<ListViewDataItem>(new Func<ListViewDataItem, bool>(c616076ac14a47ddc86586e992ec2a03d.cfc546dd96bd7920293952c13712e0308)));
      this.c2c99ff079ae47d1aebf76d3b9b2ab83c();
      this.cce20c4049fbcb70a9f55c7c45157b2cf();
      if (this.CurrentlyDownloading)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cbc50580a57af8c859936f77b72544977);
            }
            this.cbd687f998e72be3a53e9ec30b343fc9f.c3a2a56c07789f3efbf5efbd6ef8ea3f5();
            break;
        }
      }
      if (this.SelectedGame != null)
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            // ISSUE: reference to a compiler-generated field
            if (!this.SelectedGame.cd2d93bc97fb6620c2b12a80a66e62291(c616076ac14a47ddc86586e992ec2a03d.c36dd98eb0c08ea087627a40c6663c9a8))
            {
label_8:
              switch (4)
              {
                case 0:
                  goto label_8;
                default:
                  return;
              }
            }
            else
              break;
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (c50c5ab6d2aca52507a5f6d83f26a1a97.cc50e3aad2c922bb7d7e65938629ab7b5((object) c616076ac14a47ddc86586e992ec2a03d.c36dd98eb0c08ea087627a40c6663c9a8) != null)
      {
label_10:
        switch (3)
        {
          case 0:
            goto label_10;
          default:
            ((Control) this.c1f709ff5165e5433056bda30bb571911).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13054) != 0;
            break;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (cfe3e635f9e08b3ae3599c69d079b1799.cc50e3aad2c922bb7d7e65938629ab7b5((object) c616076ac14a47ddc86586e992ec2a03d.c36dd98eb0c08ea087627a40c6663c9a8) != null)
        {
label_13:
          switch (5)
          {
            case 0:
              goto label_13;
            default:
              ((Control) this.c139823df8e929f346d6de8a9db1cae22).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13058) != 0;
              break;
          }
        }
        else
          ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13062) != 0;
      }
    }

    private void cc70181fca6ee40942c7d38cbe021f365()
    {
      this.ce80e9c4fe52e3d87d4027237a6cc9bb1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13066) != 0;
      Thread.Sleep(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13070));
      try
      {
        byte[] cfe775995964ea67226aedd3e8fb0c4e1 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        byte[] c60cfcd0e145c756f358be58106535f84 = c6bf4460cf9059ccb034f7e25da0c9e5b.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        if (cdf6c91719eae5a38c64a7fd64afdf5e1.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.TicketsPath, ""))
        {
label_2:
          switch (5)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cc70181fca6ee40942c7d38cbe021f365);
              }
              cfe775995964ea67226aedd3e8fb0c4e1 = new WebClient().DownloadData(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.TicketsPath, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23309)));
              break;
          }
        }
        if (cdf6c91719eae5a38c64a7fd64afdf5e1.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.TicketsPath3DS, ""))
        {
label_7:
          switch (4)
          {
            case 0:
              goto label_7;
            default:
              c60cfcd0e145c756f358be58106535f84 = new WebClient().DownloadData(cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.TicketsPath3DS, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(23309)));
              break;
          }
        }
        this.cd7b8a84bcc59ebd89e4f9f7d58e2f137(cfe775995964ea67226aedd3e8fb0c4e1, c60cfcd0e145c756f358be58106535f84);
      }
      catch
      {
      }
    }

    private void ce4d6376ef01990d7bbe70ddab4f01102()
    {
      string[] strArray = c6a07387c2f827de6ca155929a5452624.c79f3734e186fa26ca45e21833e734d4e(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20267));
      if (strArray == null)
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.ce4d6376ef01990d7bbe70ddab4f01102);
            break;
        }
      }
      else
      {
        string[] c33ad1bd311fd4b32b85377e9e15a9d93 = strArray;
        int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13074);
        while (index < (int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(c33ad1bd311fd4b32b85377e9e15a9d93))
        {
          TitleId titleId = new TitleId(c33ad1bd311fd4b32b85377e9e15a9d93[index]);
          if (ca377ebace9a9e1ffac7b0c5a9158e838.ca32b8c3bef10c492a2adefe52dea03d4.ContainsKey(new TitleId(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(titleId.FullGame))))
          {
label_7:
            switch (6)
            {
              case 0:
                goto label_7;
              default:
                cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = ca377ebace9a9e1ffac7b0c5a9158e838.ca32b8c3bef10c492a2adefe52dea03d4[new TitleId(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(titleId.FullGame))];
                switch (titleId.IdType)
                {
                  case cfcd12ee63ba7d661f4ab310574290bf9.c9506d0fd83bf15f08302a35bc6ce2547:
                    if (cce1cf1e0b6971ed6f7ef86a83b0959b6.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13082))
                    {
label_16:
                      switch (3)
                      {
                        case 0:
                          goto label_16;
                        default:
                          this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) cce1cf1e0b6971ed6f7ef86a83b0959b6);
                          break;
                      }
                    }
                    else
                      break;
                  case cfcd12ee63ba7d661f4ab310574290bf9.c171a4a3dc0f5f061bd920529c13faa2a:
                    if (cce1cf1e0b6971ed6f7ef86a83b0959b6.cf062de84cde10d9e953c8091a0e1b42b)
                    {
label_11:
                      switch (7)
                      {
                        case 0:
                          goto label_11;
                        default:
                          if (cce1cf1e0b6971ed6f7ef86a83b0959b6.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13078))
                          {
label_13:
                            switch (3)
                            {
                              case 0:
                                goto label_13;
                              default:
                                this.ce39b083943b82bec0d4c1cda5219595a((cba6aa8f767d2e8dfbca2d43d7148c173) cce1cf1e0b6971ed6f7ef86a83b0959b6.Dlc);
                                break;
                            }
                          }
                          else
                            break;
                      }
                    }
                    else
                      break;
                }
            }
          }
          index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13086);
        }
label_20:
        switch (3)
        {
          case 0:
            goto label_20;
        }
      }
    }

    private void cf784819be9ce7badf71e6945943fd72f()
    {
      string c9a465051c588cdd36e3ac168b6fd7267 = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20267);
      ListViewDataItemCollection items = this.c80abb9b1c6ac93efa1bec9b52c6e0411.get_Items();
      // ISSUE: reference to a compiler-generated field
      Func<ListViewDataItem, string> selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c7dd730eb13926a53f1d72d08a1f528b7;
      if (selector == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cf784819be9ce7badf71e6945943fd72f);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            selector = c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c7dd730eb13926a53f1d72d08a1f528b7 = new Func<ListViewDataItem, string>(c1b7cf6218f1f498aba267c6450ec9233.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c00c6a0e6dc80d9a9cbaa7ab7364f18ba);
            break;
        }
      }
      string[] array = ((IEnumerable<ListViewDataItem>) items).Select<ListViewDataItem, string>(selector).ToArray<string>();
      c6a07387c2f827de6ca155929a5452624.cc0d9971a7869dcbc8bb5a89e4f263c2a(c9a465051c588cdd36e3ac168b6fd7267, array);
    }

    private void c836356d79f13f041ccb9894cfd5f74bf(bool ccab3dc74330fe2f266c944b3563b4580)
    {
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).Enabled = ccab3dc74330fe2f266c944b3563b4580;
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).Enabled = ccab3dc74330fe2f266c944b3563b4580;
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).Enabled = ccab3dc74330fe2f266c944b3563b4580;
      RadButton c8d4d0749ecd032b3b3c0ef4542ed6d97 = this.c8d4d0749ecd032b3b3c0ef4542ed6d97;
      int num;
      if (!this.c1c0a981ac1bdbf0aa08a2a0e2f51b1d9)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c836356d79f13f041ccb9894cfd5f74bf);
            }
            num = this.c2470a1761b7a4b98e303cce88a107056 ? 1 : 0;
            break;
        }
      }
      else
        num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13090);
      ((Control) c8d4d0749ecd032b3b3c0ef4542ed6d97).Enabled = num != 0;
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).Enabled = ccab3dc74330fe2f266c944b3563b4580;
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).Enabled = ccab3dc74330fe2f266c944b3563b4580;
      ((Control) this.ca649489ce70abf72060d3b333298ed77).Enabled = ccab3dc74330fe2f266c944b3563b4580;
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).Enabled = ccab3dc74330fe2f266c944b3563b4580;
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).Enabled = ccab3dc74330fe2f266c944b3563b4580;
    }

    private bool c297af215a9d7fad2a9905d615aecb285(bool ca7221f21a24b86977a02c71d096349d6)
    {
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
      folderBrowserDialog1.Description = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25082);
      int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13094);
      folderBrowserDialog1.ShowNewFolderButton = num != 0;
      FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog1;
      while (folderBrowserDialog2.ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13098))
      {
        if (c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(folderBrowserDialog2.SelectedPath))
        {
label_7:
          switch (3)
          {
            case 0:
              goto label_7;
            default:
              Settings.Default.ExtractFolder = folderBrowserDialog2.SelectedPath;
              Settings.Default.Save();
              return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13106) != 0;
          }
        }
      }
label_2:
      switch (6)
      {
        case 0:
          goto label_2;
        default:
          if (1 == 0)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c297af215a9d7fad2a9905d615aecb285);
          }
          return (ca7221f21a24b86977a02c71d096349d6 ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13102);
      }
    }

    private void c5f56f279f7c240ac9c4a9351a66b1049(cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319)
    {
      ca167c1c151adfd56785ba09bfd59360f ca167c1c151adfd56785ba09bfd59360f = c89cbac13be511053120093fce8049319.c9008a71c59aaea253e594b6dc2131318();
      if (ca167c1c151adfd56785ba09bfd59360f == null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c5f56f279f7c240ac9c4a9351a66b1049);
            break;
        }
      }
      else
      {
        if (ca167c1c151adfd56785ba09bfd59360f.ce6597316994d4dd99ff0504acc6d6648)
        {
label_5:
          switch (5)
          {
            case 0:
              goto label_5;
            default:
              this.c9ebdd2bff5f91eb70ae39a82398a3a59((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319);
              break;
          }
        }
        if (ca167c1c151adfd56785ba09bfd59360f.cec1cee4ccee706b13118e0e0c2415b43)
        {
label_8:
          switch (3)
          {
            case 0:
              goto label_8;
            default:
              using (List<ce64fe4baff0b285aaecd02e2cae2ea2c>.Enumerator enumerator = ca167c1c151adfd56785ba09bfd59360f.cde4b372b03cbbac0bb98de6e528db6d4.GetEnumerator())
              {
                while (enumerator.MoveNext())
                  this.c9ebdd2bff5f91eb70ae39a82398a3a59((cba6aa8f767d2e8dfbca2d43d7148c173) enumerator.Current);
label_13:
                switch (3)
                {
                  case 0:
                    goto label_13;
                }
              }
          }
        }
        if (ca167c1c151adfd56785ba09bfd59360f.cd3417c2b7b6160d6ba39fd665a563500)
        {
label_17:
          switch (6)
          {
            case 0:
              goto label_17;
            default:
              this.c9ebdd2bff5f91eb70ae39a82398a3a59((cba6aa8f767d2e8dfbca2d43d7148c173) c89cbac13be511053120093fce8049319.Dlc);
              break;
          }
        }
        this.cb5983a9ef6bb031c7f34108a205a5729.set_ActiveWindow((DockWindow) this.cc1bf6cfe06c7e943de81a144b94d908c);
      }
    }

    private void cb6779a12dc18aa08dc1f9edef1bd2a32(cce1cf1e0b6971ed6f7ef86a83b0959b6 c89cbac13be511053120093fce8049319)
    {
      c5ac1c83c6771f1d2ec2730d47af7105b c5ac1c83c6771f1d2ec2730d47af7105b = new c5ac1c83c6771f1d2ec2730d47af7105b(c89cbac13be511053120093fce8049319, (WhatToAction) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13110));
      if (((Form) c5ac1c83c6771f1d2ec2730d47af7105b).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13114))
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cb6779a12dc18aa08dc1f9edef1bd2a32);
            break;
        }
      }
      else
      {
        if (c5ac1c83c6771f1d2ec2730d47af7105b.CopyDlc)
        {
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              c89cbac13be511053120093fce8049319.Dlc.ca0f0ce4a1c83bf79f0422b8a25b09420();
              break;
          }
        }
        if (c5ac1c83c6771f1d2ec2730d47af7105b.CopyGame)
        {
label_8:
          switch (1)
          {
            case 0:
              goto label_8;
            default:
              c89cbac13be511053120093fce8049319.ca0f0ce4a1c83bf79f0422b8a25b09420();
              break;
          }
        }
        if (c5ac1c83c6771f1d2ec2730d47af7105b.CopyUpdate)
        {
label_11:
          switch (4)
          {
            case 0:
              goto label_11;
            default:
              using (List<ce64fe4baff0b285aaecd02e2cae2ea2c>.Enumerator enumerator = c5ac1c83c6771f1d2ec2730d47af7105b.cb917dff3a4bc5ccb946b4a838034a862.GetEnumerator())
              {
                while (enumerator.MoveNext())
                  enumerator.Current.ca0f0ce4a1c83bf79f0422b8a25b09420();
label_16:
                switch (6)
                {
                  case 0:
                    goto label_16;
                }
              }
          }
        }
        this.c97f25335d6752a51249adc3a07b8266a(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13118) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13122) != 0);
        this.cbbe2a25a9e1bd7c18f28caea73bee829();
      }
    }

    private void cfca5afdf2670089d1cdac0de57c626aa(string c74359205abcb0d3c69ba3393bd045531)
    {
      ((Control) this).BringToFront();
      int num = (int) RadMessageBox.Show(c74359205abcb0d3c69ba3393bd045531);
    }

    private void cfce1c4d8eaef6f0803abe344f8ff58cd()
    {
      this.cfca5afdf2670089d1cdac0de57c626aa(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25173));
    }

    private bool cdc28eeb64f8e76cccdc1639f3551e100(ListViewDataItem c128bc9ed4fdbc6f9ff47c5824fa8152e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c2b63e415adead9ff00772974cbc2e654 c2b63e415adead9ff00772974cbc2e654_1 = new c1b7cf6218f1f498aba267c6450ec9233.c2b63e415adead9ff00772974cbc2e654();
      cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(c128bc9ed4fdbc6f9ff47c5824fa8152e.get_Tag());
      if (cce1cf1e0b6971ed6f7ef86a83b0959b6 == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cdc28eeb64f8e76cccdc1639f3551e100);
            }
            return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13126) != 0;
        }
      }
      else
      {
        // ISSUE: variable of a compiler-generated type
        c1b7cf6218f1f498aba267c6450ec9233.c2b63e415adead9ff00772974cbc2e654 c2b63e415adead9ff00772974cbc2e654_2 = c2b63e415adead9ff00772974cbc2e654_1;
        string lower1 = cce1cf1e0b6971ed6f7ef86a83b0959b6.Name.Trim().ToLower();
        char[] chArray1 = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13130));
        int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13134);
        int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13138);
        chArray1[index1] = (char) num1;
        string[] strArray = lower1.Split(chArray1);
        // ISSUE: reference to a compiler-generated field
        c2b63e415adead9ff00772974cbc2e654_2.c100c4b04e322826757fe6fb6e5638211 = strArray;
        if (cce1cf1e0b6971ed6f7ef86a83b0959b6.CfwOnly)
        {
label_6:
          switch (7)
          {
            case 0:
              goto label_6;
            default:
              if (this.ce9d74c4a67920ea005ae0e9c3e550195.Checked)
              {
label_8:
                switch (2)
                {
                  case 0:
                    goto label_8;
                }
              }
              else
                goto label_32;
          }
        }
        if (!cce1cf1e0b6971ed6f7ef86a83b0959b6.CfwOnly)
        {
label_10:
          switch (3)
          {
            case 0:
              goto label_10;
            default:
              if (this.c6e10857a44dfe29229689f6f14eb8736.Checked)
              {
label_12:
                switch (5)
                {
                  case 0:
                    goto label_12;
                }
              }
              else
                goto label_32;
          }
        }
        if (cce1cf1e0b6971ed6f7ef86a83b0959b6.Name.Contains(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25280)))
        {
label_14:
          switch (6)
          {
            case 0:
              goto label_14;
            default:
              if (this.cb09f0c811e9c104f30d9bdb57f5e4472.Checked)
              {
label_16:
                switch (2)
                {
                  case 0:
                    goto label_16;
                }
              }
              else
                goto label_32;
          }
        }
        if (!this.c290ca0dbd67a1dd201c0b196fec00bc4.Checked)
        {
label_18:
          switch (4)
          {
            case 0:
              goto label_18;
            default:
              if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(cce1cf1e0b6971ed6f7ef86a83b0959b6.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338)))
              {
label_20:
                switch (3)
                {
                  case 0:
                    goto label_20;
                }
              }
              else
                goto label_32;
          }
        }
        if (!this.cf582d9fa2e47e4f8707ea4db5c09db97.Checked)
        {
label_22:
          switch (1)
          {
            case 0:
              goto label_22;
            default:
              if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(cce1cf1e0b6971ed6f7ef86a83b0959b6.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345)))
              {
label_24:
                switch (7)
                {
                  case 0:
                    goto label_24;
                }
              }
              else
                goto label_32;
          }
        }
        if (!this.c4562184f7a172fc18d58e50d7047938d.Checked)
        {
label_26:
          switch (5)
          {
            case 0:
              goto label_26;
            default:
              if (!cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(cce1cf1e0b6971ed6f7ef86a83b0959b6.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9240)))
              {
label_28:
                switch (1)
                {
                  case 0:
                    goto label_28;
                }
              }
              else
                goto label_32;
          }
        }
        if (this.Platforms.Contains(cce1cf1e0b6971ed6f7ef86a83b0959b6.Platform))
        {
label_30:
          switch (7)
          {
            case 0:
              goto label_30;
            default:
              string lower2 = ((Control) this.cef99ac773757daa1842ee58c7914a0cc).Text.Trim().ToLower();
              char[] chArray2 = c7c875b2f6d2a62be40cc160d349201b3.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13142));
              int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13146);
              int num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13150);
              chArray2[index2] = (char) num2;
              // ISSUE: reference to a compiler-generated method
              return ((IEnumerable<string>) lower2.Split(chArray2)).All<string>(new Func<string, bool>(c2b63e415adead9ff00772974cbc2e654_1.c97e85efca0bb6112f8ae6a9d63553188));
          }
        }
label_32:
        return cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13154) != 0;
      }
    }

    private void cbd2d1dd4e92c4af7fa4405eb1a93d398()
    {
      TaskbarManager.get_Instance().SetProgressState((TaskbarProgressBarState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13158));
      this.cd1e3caaaf8a38e7bf3058dd00a55fdc0(this.TitlesToDownload);
    }

    private void cdde109e3201a2b780690d19cc7c62973()
    {
      this.CurrentlyDownloading = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13162) != 0;
      ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      this.cee1c0c7304084325bbf547e952525117.Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13166) != 0;
    }

    private void c2c3a87d3035837f5b8eeb5f239b8bde0(object c5382ad5461e274fda51b358802fc3910, string ccc5b7a75b49697be2f86a8c41c8ef464)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c77f886f5179d53bff07744cdca61081c c77f886f5179d53bff07744cdca61081c = new c1b7cf6218f1f498aba267c6450ec9233.c77f886f5179d53bff07744cdca61081c();
      // ISSUE: reference to a compiler-generated field
      c77f886f5179d53bff07744cdca61081c.ccb669e105f1c11f33e60c076fc8cca42 = this;
      // ISSUE: reference to a compiler-generated field
      c77f886f5179d53bff07744cdca61081c.ccc5b7a75b49697be2f86a8c41c8ef464 = ccc5b7a75b49697be2f86a8c41c8ef464;
      try
      {
        // ISSUE: explicit non-virtual call
        if (__nonvirtual (((Control) this).InvokeRequired))
        {
label_2:
          switch (6)
          {
            case 0:
              goto label_2;
            default:
              if (1 == 0)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c2c3a87d3035837f5b8eeb5f239b8bde0);
              }
              // ISSUE: reference to a compiler-generated method
              ((Control) this).Invoke((Delegate) new Action(c77f886f5179d53bff07744cdca61081c.c4830b2cf6b72aec1da02b22058a098b5));
              break;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.cbc2eee5df02616fd21fbc91bc233cdcd.get_Items().Add(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25307), (object) (this.cbc2eee5df02616fd21fbc91bc233cdcd.get_Items().get_Count() + cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13170)), (object) c77f886f5179d53bff07744cdca61081c.ccc5b7a75b49697be2f86a8c41c8ef464));
        }
      }
      catch
      {
      }
    }

    private void c4b53578253dc8af44089b6406c1f217a(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Value.CompareTo(DateTime.Now);
      if (this.c761bc48a0ac5352d2a79834b62d8e9c7.Value.CompareTo(DateTime.Now) > cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13174))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c4b53578253dc8af44089b6406c1f217a);
            }
            ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).Text = string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25324), (object) c745d89fddb05a30e8ef1babd26557977.c1df95097ffa57d753c5fe1353cf65e86(this.c761bc48a0ac5352d2a79834b62d8e9c7.Value, DateTime.Now).ToString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25341)));
            break;
        }
      }
      else
      {
        this.cdde109e3201a2b780690d19cc7c62973();
        this.cbd2d1dd4e92c4af7fa4405eb1a93d398();
      }
    }

    private void cbc9a48cabf7b4a128a9180dd88330fbc(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      try
      {
        cba6aa8f767d2e8dfbca2d43d7148c173.cfa0952d727a09330dbc279563d1f513d();
      }
      catch
      {
      }
    }

    private void c4d42c560b9fe1667228666289ee2012d()
    {
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25362);
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).ForeColor = Color.Red;
      this.Proxy = c926afa9c5872b067bdbf2416102700e4.c20c00b8e97bb4c0fb2b7ac6facf98b91;
    }

    private void c311e8fc3018c9512f3d0c01c298c037e()
    {
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c311e8fc3018c9512f3d0c01c298c037e);
            }
            ((Control) this.c22d04ce1034d647a95d30b01a54768c4).ForeColor = Color.Green;
            ((Control) this.c22d04ce1034d647a95d30b01a54768c4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25377);
            ((Control) this.c979c76a51f33de27b2440305fd60fd38).Text = c1b0822c22b951c8a567b56dd01e313bf.Donator.Email;
            ((Control) this.c86ce7f867a560282470decd22cec0860).Text = c1b0822c22b951c8a567b56dd01e313bf.Donator.DonationDate;
            break;
        }
      }
      else
      {
        ((Control) this.c22d04ce1034d647a95d30b01a54768c4).ForeColor = Color.Red;
        ((Control) this.c22d04ce1034d647a95d30b01a54768c4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25434);
        ((Control) this.c979c76a51f33de27b2440305fd60fd38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
        ((Control) this.c86ce7f867a560282470decd22cec0860).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      }
    }

    private void c97f25335d6752a51249adc3a07b8266a(bool c8a333ef9a097b84055bd0572caa5f96f = false, bool cc1139cf96b6c5b6b7ca39208551d3bd1 = true)
    {
      this.ced13435d37c83d5695f389153255d7aa.BeginUpdate();
      IEnumerator<ListViewDataItem> enumerator = this.ced13435d37c83d5695f389153255d7aa.get_Items().GetEnumerator();
      try
      {
        while (((IEnumerator) enumerator).MoveNext())
        {
          ListViewDataItem current = enumerator.Current;
          cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = c703209e3fe1c856d59fc93b4c479b315.cc50e3aad2c922bb7d7e65938629ab7b5(current.get_Tag());
          if (cc1139cf96b6c5b6b7ca39208551d3bd1)
          {
label_3:
            switch (7)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.c97f25335d6752a51249adc3a07b8266a);
                }
                current.set_Group(this.c4199b0948a18e6cbed051a872f241ae7(cce1cf1e0b6971ed6f7ef86a83b0959b6));
                current.set_Item(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13178), (object) c1bbcad09f7d3f69ee1d8850af68486c5.c1df95097ffa57d753c5fe1353cf65e86((object) cce1cf1e0b6971ed6f7ef86a83b0959b6.c38dee32ccaa64d9ac65631acafd39f04, (object) c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(20252)));
                if (c8a333ef9a097b84055bd0572caa5f96f)
                {
label_7:
                  switch (2)
                  {
                    case 0:
                      goto label_7;
                    default:
                      c1b7cf6218f1f498aba267c6450ec9233.c2a51f84d855205a3cb0bad2cdcac5eb4(cce1cf1e0b6971ed6f7ef86a83b0959b6);
                      current.set_Image(cce1cf1e0b6971ed6f7ef86a83b0959b6.cee7644d811ec48c3e6a2526d09e8524b.Image);
                      break;
                  }
                }
                else
                  break;
            }
          }
          current.set_ForeColor(c1b7cf6218f1f498aba267c6450ec9233.cb8c81e3b10f664ccf79099edfbe9a77b((cba6aa8f767d2e8dfbca2d43d7148c173) cce1cf1e0b6971ed6f7ef86a83b0959b6));
        }
label_11:
        switch (1)
        {
          case 0:
            goto label_11;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_13:
          switch (2)
          {
            case 0:
              goto label_13;
            default:
              ((IDisposable) enumerator).Dispose();
              break;
          }
        }
      }
      this.c6450bee67c17aaeb724d7d72619d430e();
      this.ced13435d37c83d5695f389153255d7aa.EndUpdate();
    }

    private void cbbe2a25a9e1bd7c18f28caea73bee829()
    {
      if (this.SelectedGame == null)
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (1 != 0)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cbbe2a25a9e1bd7c18f28caea73bee829);
            break;
        }
      }
      else
      {
        this.cc5109af75315520586ca50d6cd84c973.Image = c4a6a533bd83fb141986de6f6a05d666d.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        this.c39e3350d94cbb712a33276b179006506.Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13182) != 0;
        this.c39e3350d94cbb712a33276b179006506.Checked = this.SelectedGame.cd61c5f51f587495941f329dc6bffec54;
        ((Control) this.cdf03a2ca811ef49688b58b7e317a430a).Text = this.SelectedGame.Size.ToString();
        ((Control) this.c207af470f351635895849de23ece3abc).Text = this.SelectedGame.c1cd3f03faaa582cb55a64d18b0c07fb3;
        ((Control) this.c207af470f351635895849de23ece3abc).ForeColor = this.SelectedGame.cfed4875cfd556dd488b4a4d828cb7bc5;
        ((Control) this.cfa8badb30bc978147487352167d51546).Text = this.SelectedGame.TitleId.ToSplitString();
        ((Control) this.cf1bbdaba14013386fcabe835941101b9).Enabled = this.SelectedGame.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13186);
        ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).Enabled = this.SelectedGame.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13190);
        this.c714cda224c0867b81d88c3a87f7b805d.Url = new Uri(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25487), (object) HttpUtility.UrlEncode(this.SelectedGame.Name)).Replace(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2716), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2719)), (UriKind) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13194));
        RadButton c9c662a4a0b9d44555b1f70db28046f61 = this.c9c662a4a0b9d44555b1f70db28046f61;
        string str;
        if (this.SelectedGame.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13198))
        {
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25556);
              break;
          }
        }
        else
          str = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25569);
        ((Control) c9c662a4a0b9d44555b1f70db28046f61).Text = str;
        if (this.SelectedGame.c2485b5906efc569b1c867e5c900b2e4e)
        {
label_9:
          switch (3)
          {
            case 0:
              goto label_9;
            default:
              ((Control) this.c489dec79b6c4a36ad71b2dd683ba4003).Text = this.SelectedGame.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>().Size.ToString();
              ((Control) this.c743d2a65362475553a562cf35b254c43).Text = this.SelectedGame.c4654bf96b305503a608a75dba19b18db;
              ((Control) this.c743d2a65362475553a562cf35b254c43).ForeColor = this.SelectedGame.Updates.Last<ce64fe4baff0b285aaecd02e2cae2ea2c>().cfed4875cfd556dd488b4a4d828cb7bc5;
              ((Control) this.c1f709ff5165e5433056bda30bb571911).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13202) != 0;
              ((Control) this.c1f709ff5165e5433056bda30bb571911).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25582);
              break;
          }
        }
        else
        {
          ((Control) this.c743d2a65362475553a562cf35b254c43).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25603);
          ((Control) this.c743d2a65362475553a562cf35b254c43).ForeColor = Color.Red;
          ((Control) this.c489dec79b6c4a36ad71b2dd683ba4003).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
          ((Control) this.c1f709ff5165e5433056bda30bb571911).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25672);
          ((Control) this.c1f709ff5165e5433056bda30bb571911).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13206) != 0;
        }
        if (this.SelectedGame.cf062de84cde10d9e953c8091a0e1b42b)
        {
label_13:
          switch (1)
          {
            case 0:
              goto label_13;
            default:
              ((Control) this.c05e1ef1d0f2e5250a57c757370b74d83).Text = this.SelectedGame.Dlc.Size.ToString();
              ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).Text = this.SelectedGame.Dlc.c1cd3f03faaa582cb55a64d18b0c07fb3;
              ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).ForeColor = this.SelectedGame.Dlc.cfed4875cfd556dd488b4a4d828cb7bc5;
              ((Control) this.c139823df8e929f346d6de8a9db1cae22).Enabled = (this.c80abb9b1c6ac93efa1bec9b52c6e0411.c1de2c5d31ef8b332ef39d04f3d8a5a6c((cba6aa8f767d2e8dfbca2d43d7148c173) this.SelectedGame.Dlc) ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13210);
              ((Control) this.c139823df8e929f346d6de8a9db1cae22).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25711);
              break;
          }
        }
        else
        {
          ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25726);
          ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).ForeColor = Color.Red;
          ((Control) this.c05e1ef1d0f2e5250a57c757370b74d83).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
          ((Control) this.c139823df8e929f346d6de8a9db1cae22).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25835);
          ((Control) this.c139823df8e929f346d6de8a9db1cae22).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13214) != 0;
        }
        ((Control) this.c6c840f966d621484314eb45e43e34565).Enabled = this.SelectedGame.System == (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13218);
        ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Enabled = (this.c80abb9b1c6ac93efa1bec9b52c6e0411.c1de2c5d31ef8b332ef39d04f3d8a5a6c((cba6aa8f767d2e8dfbca2d43d7148c173) this.SelectedGame) ? 1 : 0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13222);
        ((Control) this.c738f1dd7afbbfdc20629834298bed929).Text = this.SelectedGame.Name;
        if (this.SelectedGame.CfwOnly)
        {
label_17:
          switch (7)
          {
            case 0:
              goto label_17;
            default:
              ((Control) this.c738f1dd7afbbfdc20629834298bed929).Text = cc7421d8915e6aa8f9f0698b6a9c0bda2.c1df95097ffa57d753c5fe1353cf65e86(((Control) this.c738f1dd7afbbfdc20629834298bed929).Text, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(2213));
              break;
          }
        }
        RadButton c089f82a5bb56d907790079762415ad00 = this.c089f82a5bb56d907790079762415ad00;
        int num1;
        if (this.SelectedGame.c7adb0b831ae9d44c1bc321f4993f8d5d != (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13226))
        {
label_20:
          switch (7)
          {
            case 0:
              goto label_20;
            default:
              if (!this.SelectedGame.c2485b5906efc569b1c867e5c900b2e4e)
              {
label_22:
                switch (7)
                {
                  case 0:
                    goto label_22;
                  default:
                    if (this.SelectedGame.cf062de84cde10d9e953c8091a0e1b42b)
                    {
label_24:
                      switch (3)
                      {
                        case 0:
                          goto label_24;
                        default:
                          num1 = this.SelectedGame.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d == (cb48a6650cad6d81c80da89dfe58b703a) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13230) ? 1 : 0;
                          goto label_28;
                      }
                    }
                    else
                    {
                      num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13234);
                      goto label_28;
                    }
                }
              }
              else
                break;
          }
        }
        num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13238);
label_28:
        ((Control) c089f82a5bb56d907790079762415ad00).Enabled = num1 != 0;
        RadButton cba8de59d8af22ab73fe624faad5b1c0d = this.cba8de59d8af22ab73fe624faad5b1c0d;
        int num2;
        if (this.SelectedGame.c7adb0b831ae9d44c1bc321f4993f8d5d == cb48a6650cad6d81c80da89dfe58b703a.c83db08052b4defd7f123a5703adcaf4a)
        {
label_29:
          switch (3)
          {
            case 0:
              goto label_29;
            default:
              if (!this.SelectedGame.c2485b5906efc569b1c867e5c900b2e4e)
              {
label_31:
                switch (4)
                {
                  case 0:
                    goto label_31;
                  default:
                    if (this.SelectedGame.cf062de84cde10d9e953c8091a0e1b42b)
                    {
label_33:
                      switch (2)
                      {
                        case 0:
                          goto label_33;
                        default:
                          num2 = (uint) this.SelectedGame.Dlc.c7adb0b831ae9d44c1bc321f4993f8d5d > (uint) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13242) ? 1 : 0;
                          goto label_37;
                      }
                    }
                    else
                    {
                      num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13246);
                      goto label_37;
                    }
                }
              }
              else
                break;
          }
        }
        num2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13250);
label_37:
        ((Control) cba8de59d8af22ab73fe624faad5b1c0d).Enabled = num2 != 0;
        ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).Text = "";
        this.c9828af810645b7cadbb5e7f90ebdc726.Image = c4a6a533bd83fb141986de6f6a05d666d.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        this.c0c519a92c14db391cc60009c355f6c77.Image = c4a6a533bd83fb141986de6f6a05d666d.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        this.ccd11edb9d36850a5cccf6849cebf8790.Image = c4a6a533bd83fb141986de6f6a05d666d.c20c00b8e97bb4c0fb2b7ac6facf98b91;
        this.c0c0e712d5ca94f2910e3ec339b2e600f.Image = (Image) c27603360ccc8374975348defb9eee9fc.banner;
        PictureBox c4ffe800d52986b27d66e2886fadad952 = this.c4ffe800d52986b27d66e2886fadad952;
        Bitmap bitmap;
        if (this.SelectedGame.System != caff792dac5a5e2f17b0e81e59bba386d.cd640a3b52f646cee482c685f1e6d0f8b)
        {
label_38:
          switch (5)
          {
            case 0:
              goto label_38;
            default:
              bitmap = c27603360ccc8374975348defb9eee9fc.logoWiiU;
              break;
          }
        }
        else
          bitmap = c27603360ccc8374975348defb9eee9fc.logo3ds;
        c4ffe800d52986b27d66e2886fadad952.Image = (Image) bitmap;
        this.SelectedGame.ce9797d2d22ac7c2f896a63451420d43d(new Action<c0c29f108584f137c614f55b15004c742, cce1cf1e0b6971ed6f7ef86a83b0959b6>(this.cea05945d86958650bad9e917dca33c76));
      }
    }

    private void cb3c0eb294ec216be897d38e42a835065(object c5382ad5461e274fda51b358802fc3910, StateChangingEventArgs cccf482ee689904a1a8630dac14e0a6a0)
    {
      if (this.c29c9611cee072e30c8d766c88964ac2b.get_Checked())
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cb3c0eb294ec216be897d38e42a835065);
          }
          if (c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(Settings.Default.ExtractFolder))
          {
label_5:
            switch (4)
            {
              case 0:
                goto label_5;
              default:
                return;
            }
          }
          else
          {
            if (!c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(Settings.Default.ExtractFolder))
            {
label_8:
              switch (6)
              {
                case 0:
                  goto label_8;
                default:
                  this.c297af215a9d7fad2a9905d615aecb285(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13254) != 0);
                  break;
              }
            }
            if (c1b7cf6218f1f498aba267c6450ec9233.ca46a22c647de151513cba1115840f945(Settings.Default.ExtractFolder))
              break;
label_11:
            switch (7)
            {
              case 0:
                goto label_11;
              default:
                ((CancelEventArgs) cccf482ee689904a1a8630dac14e0a6a0).Cancel = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13258) != 0;
                return;
            }
          }
      }
    }

    private void cb896ac5c44acce323c2f49079bd9b95a(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.caef69280af2a72d9ec79d747e3a699ad caef69280af2a72d9ec79d747e3a699ad = new c1b7cf6218f1f498aba267c6450ec9233.caef69280af2a72d9ec79d747e3a699ad();
      if (this.ca5aed60c2dab3ff1d5478c9ff4d2e495 == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cb896ac5c44acce323c2f49079bd9b95a);
            }
            this.c78e5b51eda7d64d090944308c1539594();
            break;
        }
      }
      else
      {
        c00d1c3fff546998b244f73cd80af6e96 c00d1c3fff546998b244f73cd80af6e96 = new c00d1c3fff546998b244f73cd80af6e96();
        if (((Form) c00d1c3fff546998b244f73cd80af6e96).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13262))
        {
label_6:
          switch (7)
          {
            case 0:
              goto label_6;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          caef69280af2a72d9ec79d747e3a699ad.c95c88ea8b0e6ffe0e90d31a476f68494 = new ca5f1a19f078eb23ced887c232d971b13(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25868));
          try
          {
            // ISSUE: reference to a compiler-generated method
            Thread thread = new Thread(new ThreadStart(caef69280af2a72d9ec79d747e3a699ad.c28c3ce69beae8afe7e6baa6e66703e25));
            int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13266);
            thread.IsBackground = num != 0;
            thread.Start();
            this.SelectedGame.c5c286a0a03836226fa1828dd64728e88(this.ca5aed60c2dab3ff1d5478c9ff4d2e495, c00d1c3fff546998b244f73cd80af6e96.c0344195c5dcec47703262019eec927f2);
          }
          catch (c9d98206b36522903c9380884ee3ed7a2 ex)
          {
            // ISSUE: reference to a compiler-generated field
            caef69280af2a72d9ec79d747e3a699ad.c95c88ea8b0e6ffe0e90d31a476f68494.ce064f93ebcf9a6f22e14fc4dbf62aa2c();
            this.cfca5afdf2670089d1cdac0de57c626aa(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25967));
            return;
          }
          catch (Exception ex)
          {
            // ISSUE: reference to a compiler-generated field
            caef69280af2a72d9ec79d747e3a699ad.c95c88ea8b0e6ffe0e90d31a476f68494.ce064f93ebcf9a6f22e14fc4dbf62aa2c();
            this.cfca5afdf2670089d1cdac0de57c626aa(ex.Message);
            return;
          }
          // ISSUE: reference to a compiler-generated field
          caef69280af2a72d9ec79d747e3a699ad.c95c88ea8b0e6ffe0e90d31a476f68494.ce064f93ebcf9a6f22e14fc4dbf62aa2c();
        }
      }
    }

    private void cae13de9b9651dd0155f4a16d9235bec3(object c5382ad5461e274fda51b358802fc3910, EventArgs c9572d7ff9cd6a116e4a6f248ca68a831)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      c1b7cf6218f1f498aba267c6450ec9233.c9e718aac5a61a61d92399022d9dcb079 c9e718aac5a61a61d92399022d9dcb079 = new c1b7cf6218f1f498aba267c6450ec9233.c9e718aac5a61a61d92399022d9dcb079();
      if (this.ca5aed60c2dab3ff1d5478c9ff4d2e495 == null)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.cae13de9b9651dd0155f4a16d9235bec3);
            }
            this.c78e5b51eda7d64d090944308c1539594();
            break;
        }
      }
      else
      {
        ced0676f39cd3a801adcb57c382323f74 ced0676f39cd3a801adcb57c382323f74 = new ced0676f39cd3a801adcb57c382323f74(this.SelectedGame);
        if (((Form) ced0676f39cd3a801adcb57c382323f74).ShowDialog() != (DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13270))
        {
label_6:
          switch (2)
          {
            case 0:
              goto label_6;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          c9e718aac5a61a61d92399022d9dcb079.c95c88ea8b0e6ffe0e90d31a476f68494 = new ca5f1a19f078eb23ced887c232d971b13(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26060));
          // ISSUE: reference to a compiler-generated method
          Thread thread = new Thread(new ThreadStart(c9e718aac5a61a61d92399022d9dcb079.c82b83ec5f04ee7c8688bc2d7e2d7ea34));
          int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13274);
          thread.IsBackground = num != 0;
          thread.Start();
          try
          {
            this.SelectedGame.c8437a524abfdc6166da7d43f19b1b01f(this.ca5aed60c2dab3ff1d5478c9ff4d2e495, ced0676f39cd3a801adcb57c382323f74.cff7d080c674720b9970ada1d15664bae.Timestamp);
          }
          catch (Exception ex)
          {
            // ISSUE: reference to a compiler-generated field
            c9e718aac5a61a61d92399022d9dcb079.c95c88ea8b0e6ffe0e90d31a476f68494.ce064f93ebcf9a6f22e14fc4dbf62aa2c();
            this.cfca5afdf2670089d1cdac0de57c626aa(ex.Message);
            return;
          }
          // ISSUE: reference to a compiler-generated field
          c9e718aac5a61a61d92399022d9dcb079.c95c88ea8b0e6ffe0e90d31a476f68494.ce064f93ebcf9a6f22e14fc4dbf62aa2c();
        }
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c1b7cf6218f1f498aba267c6450ec9233.Dispose);
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
      this.ce2dde71ac55aad4a9ce23a50ce61cd89 = (IContainer) new Container();
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9583), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26155));
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9609), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9029));
      ListViewDetailColumn viewDetailColumn3 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26164), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26181));
      ListViewDetailColumn viewDetailColumn4 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26190), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26207));
      ListViewDetailColumn viewDetailColumn5 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26228), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18748));
      ListViewDetailColumn viewDetailColumn6 = new ListViewDetailColumn(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26245), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26262));
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(ccf2165d6690226a187de7b777ca5a724.c6804baa30a51e813a45fabcfa2b27b79()));
      AutoHideGroup autoHideGroup1 = new AutoHideGroup();
      AutoHideGroup autoHideGroup2 = new AutoHideGroup();
      this.c53cbb17a05b0cbad7d563b1e9b75cd53 = new DockWindowPlaceholder();
      this.c8c4139dc5bdf8baad6014fa6ae28608e = new DockWindowPlaceholder();
      this.cef99ac773757daa1842ee58c7914a0cc = new RadTextBox();
      this.ced13435d37c83d5695f389153255d7aa = new RadListView();
      this.c2399b7113e731f78fc41e13b97230ba2 = new OpenFileDialog();
      this.c544236c90282c9157c1c7d7d9ff1369c = new RadLabel();
      this.c80abb9b1c6ac93efa1bec9b52c6e0411 = new RadListView();
      this.c3aec1f92fc33a551b592c8b2a7adf9ec = new RadLabel();
      this.cef22dcb29373b4f99e89eb28166e5dc2 = new RadLabel();
      this.c8af15fc87ff7fad3b7d70b37794c0516 = new RadLabel();
      this.c659877bdbb8d30820909c7b85d4f6330 = new RadLabel();
      this.c799de9bbe8c05dd37f1ae092015d68e1 = new RadGroupBox();
      this.c761bc48a0ac5352d2a79834b62d8e9c7 = new DateTimePicker();
      this.cc4a40b1385deb54376434c71c8e76b81 = new RadButton();
      this.c97c4e0fb1efa8799a0b6c47d1e86000e = new RadLabel();
      this.c29c9611cee072e30c8d766c88964ac2b = new RadCheckBox();
      this.c3ecd11fc9291e6c3176323b62baedac8 = new RadCheckBox();
      this.c02f822b4a13df9d2c2d9666d3986f346 = new RadCheckBox();
      this.c6e68d4163e92bbc6a33bc1e07bf15a4f = new RadCheckBox();
      this.c93a99fb1c1183d9875099b634bd270a6 = new RadCheckBox();
      this.c62f555309ebbf190dea30e5a84cef1bf = new RadCheckBox();
      this.c80b1c299c05614f9c782a38b86c99494 = new RadGroupBox();
      this.c2e00ce37891acd500b28d73704f69b35 = new RadLabel();
      this.c560a6e04507a6b91381df70d8ba999e6 = new RadSpinEditor();
      this.c7ab9d9b723e77867834f5b804c1e8d84 = new RadLabel();
      this.cf7bf7ed27e5378895056f9c4e22fa991 = new RadProgressBar();
      this.c16be2b426e8d997c5d2b8f1d3becf90b = new RadButton();
      this.cbc2eee5df02616fd21fbc91bc233cdcd = new RadListView();
      this.c8827d4c0d7431a9890c547ec78a2c02c = new RadGroupBox();
      this.cba8de59d8af22ab73fe624faad5b1c0d = new RadButton();
      this.c089f82a5bb56d907790079762415ad00 = new RadButton();
      this.c139823df8e929f346d6de8a9db1cae22 = new RadButton();
      this.c0aaf89283992def05decf8054f449068 = new Label();
      this.c1f709ff5165e5433056bda30bb571911 = new RadButton();
      this.c9c662a4a0b9d44555b1f70db28046f61 = new RadButton();
      this.c0b6ff62997904dd44189c4cb17f2ab15 = new RadGroupBox();
      this.c6c17c59699d09a6deff3affeead81921 = new RadLabel();
      this.c9e453c2e79f4fc55124ccb1fd3603902 = new RadLabel();
      this.c39e3350d94cbb712a33276b179006506 = new CheckBox();
      this.c38925728235576f0c42cd968bde792d6 = new RadLabel();
      this.c05e1ef1d0f2e5250a57c757370b74d83 = new RadLabel();
      this.c713a3cd0f5b5e9ff3d443ae80f12e3c8 = new RadLabel();
      this.cba34b2a0111f6e5bc303375f968bc295 = new RadLabel();
      this.cfa8badb30bc978147487352167d51546 = new RadLabel();
      this.cee9946355c6a614ff90b875d32801e38 = new RadLabel();
      this.c743d2a65362475553a562cf35b254c43 = new RadLabel();
      this.c3a32d8bd5fe0b6b703d373c8ec023149 = new RadLabel();
      this.c207af470f351635895849de23ece3abc = new RadLabel();
      this.ced6aa7f9911c4707f69ec112a4e51672 = new RadLabel();
      this.c489dec79b6c4a36ad71b2dd683ba4003 = new RadLabel();
      this.c0bc74edb9773f357b639b398786841b3 = new RadLabel();
      this.cdf03a2ca811ef49688b58b7e317a430a = new RadLabel();
      this.ce940872bf2d542451e120044788d9340 = new RadLabel();
      this.c6c840f966d621484314eb45e43e34565 = new RadButton();
      this.c738f1dd7afbbfdc20629834298bed929 = new RadLabel();
      this.cd21917de552da0d5fa4c6079cd71111f = new RadGroupBox();
      this.c73cd2a39bc535b70ef0ec0e9f35ddb8d = new RadLabel();
      this.c38668e2d3dc450be2fe10e8cdead5a82 = new RadProgressBar();
      this.ca5a2b6669f9034e5fc384b9781cd6dd6 = new RadLabel();
      this.c4f28cce9069ce7d56aa80dce66bd91fc = new RadGroupBox();
      this.c5539dab8a40e8d2e2a7b970e134631c8 = new RadLabel();
      this.c50c3a23f9473947fa39e14b6b066f539 = new RadProgressBar();
      this.cb5983a9ef6bb031c7f34108a205a5729 = new RadDock();
      this.cc1bf6cfe06c7e943de81a144b94d908c = new ToolWindow();
      this.ceb095b069074eddeeb1ad92edcc4ec95 = new RadButton();
      this.c101d57e697d17803583217bbb889b590 = new RadButton();
      this.ce1a2609d728bf5b02ebcce5d0d03abac = new RadButton();
      this.ccc252ce44a8e5cefbd8cd949ece215e5 = new RadGroupBox();
      this.c14d5ba9c8d3dcbc17433b50217356b5a = new RadLabel();
      this.cd036f2b2868b103e71bd7b4fbe25a603 = new RadLabel();
      this.c3768da1c9e17b9980d03acca3e5a19a9 = new RadButton();
      this.c0ebc97b073a7d0dba554313d3f62139d = new RadListView();
      this.c0b8c323aae75c040334498c5efcb96f4 = new RadLabel();
      this.c453acc1433bd9ed8673278dbdd4bee00 = new ToolTabStrip();
      this.c3ec3e29a74c0f512f2935f1207d1a895 = new ToolWindow();
      this.c0c0e712d5ca94f2910e3ec339b2e600f = new PictureBox();
      this.cae3beaf3bc9f066d134288b1cc6a2ab6 = new RadSplitContainer();
      this.c6f51d70787b53494b9f2a90f93e5091c = new DocumentContainer();
      this.cfda0f7e74c13d6b7f59b7c808dd15331 = new DocumentTabStrip();
      this.c44e1112bbc33afd80a87709982a149c4 = new ToolWindow();
      this.c39e7e88f29f2018d9aa6c123a5da05b9 = new RadGroupBox();
      this.c68b8f2723032c53a16a489755afa9f3d = new RadCheckBox();
      this.cb09f0c811e9c104f30d9bdb57f5e4472 = new CheckBox();
      this.ce9d74c4a67920ea005ae0e9c3e550195 = new CheckBox();
      this.c6e10857a44dfe29229689f6f14eb8736 = new CheckBox();
      this.cc823a5ecc3a0639558b6b92439679149 = new RadGroupBox();
      this.c414a01a9d1ea6f9447f9d5fee7291bd3 = new RadButton();
      this.c89ff289eea7f33d04edb7f11d666c144 = new ToolWindow();
      this.c422900b304a63407dfa05f2f233b004e = new RadGroupBox();
      this.ca9c68e79493f9e09d605914c6cd6edd5 = new RadCheckedListBox();
      this.c51175a4a3b6b11c0eee765ad7effd076 = new RadButton();
      this.cf152d3e6147dc4e0112582d0f6097ce3 = new RadButton();
      this.cbe00b03ee2347f9756848babd446e36c = new RadGroupBox();
      this.c4562184f7a172fc18d58e50d7047938d = new CheckBox();
      this.cf582d9fa2e47e4f8707ea4db5c09db97 = new CheckBox();
      this.c290ca0dbd67a1dd201c0b196fec00bc4 = new CheckBox();
      this.c2f75881f4e3a569756004ecd1f3c8da3 = new ToolWindow();
      this.c101a585c2bc6dfb0b62b86bd680ce2b2 = new RadGroupBox();
      this.c780e6034938558087f1ea7ad59d1d853 = new RadGroupBox();
      this.c86ce7f867a560282470decd22cec0860 = new RadLabel();
      this.c22d04ce1034d647a95d30b01a54768c4 = new RadLabel();
      this.cfda9a98a11ebdc24a447457307015f17 = new RadLabel();
      this.c979c76a51f33de27b2440305fd60fd38 = new RadLabel();
      this.ce55c0c71a3136c1bba91d488db23a660 = new RadLabel();
      this.cb92ad5a7459656fe7b6fd86ff472b5c5 = new RadLabel();
      this.c77ab4cca03476e6662d72295ae2a18d0 = new RadLabel();
      this.c28cccb4bc1305f639acf2d457aeedad8 = new RadButton();
      this.ca380231837e2eafdb42e81f47a24d226 = new RadGroupBox();
      this.cded9ed150a9ac47f6949a468fac193a6 = new RadLabel();
      this.c340f7ccf001170543c57999fd96d4b38 = new RadLabel();
      this.cd8a4426aac26fd0166c7b44e9f731455 = new RadButton();
      this.c4fda90ba27d8ac9ff70115293efc7b38 = new RadButton();
      this.c0770534b75ebeea0c4e695dfdb7677d0 = new RadTextBox();
      this.c67131d5ebad4559120841e7d6afbf050 = new RadTextBox();
      this.cadd2602239e2a87754cb1203ec048ce7 = new RadLabel();
      this.cf9e2786454699a4c03d6a769f423882e = new RadLabel();
      this.ceb96360e1866456699fd2a748e058db6 = new RadTextBox();
      this.c1b58d84e7b46cb77f175ef1b94421baf = new RadLabel();
      this.c5b062d1e6fbb1c9186310faefca6b2fa = new ToolTabStrip();
      this.cf6bb2c04c0ce1a4090efd4990bc2a4d6 = new ToolWindow();
      this.cbb44104e6cbbb2680035694332b80a01 = new RadGroupBox();
      this.c2769778d069bafd899ea27ebc8b3b6f7 = new RadDock();
      this.c3f18d02c9bc1b341ea22f160d501e795 = new ToolWindow();
      this.c4ffe800d52986b27d66e2886fadad952 = new PictureBox();
      this.c74ae2563a72edeef646bba38ebdd0ce8 = new RadTextBoxControl();
      this.cc5109af75315520586ca50d6cd84c973 = new PictureBox();
      this.c830db343ebd6db124b1b541a729f89ad = new DocumentContainer();
      this.c9c9e7026dfacf9cea6739b2eb22bb1b0 = new DocumentTabStrip();
      this.c78b2def3d06d6b5a4d21846a0d787eee = new ToolWindow();
      this.ceb0fc808ac3cea091a2bf8db3cf9f1c5 = new RadGroupBox();
      this.c2b75e78467422d822cfdace19fced8b4 = new Label();
      this.c00cbac6f52b66fe9075f2e2d10af540a = new RadListView();
      this.c20125c1e72d687c9063a72becb2b139c = new PictureBox();
      this.cfd811e4de46986ea5fd1a90c4e25b17a = new Label();
      this.cc9d166d46812474925d4574ed649e971 = new Label();
      this.c2f140be112f4d6280c6d8b3f548ccb8a = new RadListView();
      this.cbd1041f8be005d147b5e93849f76b59d = new RadProgressBar();
      this.c8692650f24b3012c232c930089f0258c = new RadListView();
      this.c91d2e830a71a1148124277bd799d126c = new Label();
      this.c66c0f7f85b853fc9a2258f078c613edd = new Label();
      this.c7c2ca4c94e8d95132cb789b411fcc27b = new ToolWindow();
      this.ccd11edb9d36850a5cccf6849cebf8790 = new PictureBox();
      this.c9828af810645b7cadbb5e7f90ebdc726 = new PictureBox();
      this.c0c519a92c14db391cc60009c355f6c77 = new PictureBox();
      this.ce4834f41a2d4bf23a4afa6097bd2e65a = new ToolWindow();
      this.c714cda224c0867b81d88c3a87f7b805d = new WebBrowser();
      this.c8feaaff2cfc11c5e9956aac64eb58b35 = new RadGroupBox();
      this.c2847a413b553d4c7de02d6550eafde3c = new RadButton();
      this.c357bfd7fc69acf74548222098fb25669 = new RadButton();
      this.c24e3e0bc5926188969ef6ed35bca3f48 = new ToolWindow();
      this.cdff096b93bcf8895ef6ce933c902940d = new RadListView();
      this.ce0e7fe2dec7b73af921b84452e573154 = new RadLabel();
      this.c969e7ecbcc3e5f2b58f9abd63fd43607 = new ToolWindow();
      this.c58eefb73a902712c6fd5929e97bd4b97 = new RadLabel();
      this.cf1bbdaba14013386fcabe835941101b9 = new RadButton();
      this.c8e4e933c1082ae051c164f38f5d1cb14 = new RadButton();
      this.c0185dca1f25fc3c2cc62921a9050d18f = new ToolTabStrip();
      this.c48844a2ef256637729bbfeba6c14b1ba = new ToolWindow();
      this.cddad6496d4e1c285617512daf16ee740 = new RadGroupBox();
      this.ceb25ec87df1d957dbabc08d3338713dd = new ToolTabStrip();
      this.c91e9024abe6202a1b65e9677c8b82412 = new ToolTabStrip();
      this.c28c4210040b2b3298484f4b1697ed477 = new ToolWindow();
      this.cf273feb18353b8a5aca9b1d1f46844c6 = new RadPanel();
      this.ca649489ce70abf72060d3b333298ed77 = new RadButton();
      this.c8c95b6e3f74e541d66aa845a751279d2 = new RadButton();
      this.c4f9790e49b5c17eba6614a7824f1741c = new RadButton();
      this.ce5de00809f1e6aab265b64623d9bc1a5 = new RadButton();
      this.cf8a1dc8cf7f73143ea81640d7645c738 = new RadButton();
      this.ccf9a1c650ea674b5d9aff1def6334db2 = new ToolWindow();
      this.cb6204fff3792b968130bf39d7e003531 = new RadPanel();
      this.c264210f8880117c5d13694e2bdf33135 = new RadButton();
      this.c7730aeebdbd664b38e5f8bbc1437a2c2 = new RadButton();
      this.c8d4d0749ecd032b3b3c0ef4542ed6d97 = new RadButton();
      this.c2ccfe80606082cc7f5920727b308bf4d = new RadButton();
      this.c0b71e1da7d09a3789bead9e0ff8feda4 = new RadButton();
      this.ce2e62cad203b8927cba774d40cc26e1e = new RadButton();
      this.cf18cb5dad0d928f1718d2705e894530d = new ToolWindow();
      this.ca17c92fca2120e58e5f8f7c1e444d324 = new RadPanel();
      this.c99759b9e421322e16d5c36b476bb666f = new RadButton();
      this.c6b7d903aa965d47e2f39fa93f9aa3134 = new RadButton();
      this.c2d265ee1256f88eddf3baa3887d2c91d = new RadButton();
      this.c4533e25263801abd1cc5792ca28f28c1 = new RadButton();
      this.c7a8633bba80a50b81c114da3ab992208 = new RadButton();
      this.c7970189ca187b55d3e75631f17e4b67c = new RadButton();
      this.cede9e5be54b12de354ccc761ad4fc4a1 = new RadContextMenu(this.ce2dde71ac55aad4a9ce23a50ce61cd89);
      this.cb2e65fdb3dbc553302280f07b5ad39c6 = new RadMenuItem();
      this.ccf6a2ae401b49d2712eabf1f3d73b706 = new RadMenuItem();
      this.c30f1c4d08b6e85057a60708401020f66 = new RadMenuItem();
      this.c8c72e702b57548c1958f16299f426252 = new RadMenuItem();
      this.c1b66238ca4e5fb0c40c7756554ee7321 = new RadMenuItem();
      this.c6651d3ca26654e3b924967485e5cd357 = new RadMenuItem();
      this.c4587b5b95b0f054ed931ca93214ad4b4 = new RadMenuItem();
      this.c682b9a9146723389d400ba86d9cc4e13 = new RadMenuItem();
      this.c11eb1c4d76d9d3f27d002b636b540897 = new System.Windows.Forms.Timer(this.ce2dde71ac55aad4a9ce23a50ce61cd89);
      this.c0edd068ee51dc000d1e5630da9f32887 = new System.Windows.Forms.Timer(this.ce2dde71ac55aad4a9ce23a50ce61cd89);
      this.cee1c0c7304084325bbf547e952525117 = new System.Windows.Forms.Timer(this.ce2dde71ac55aad4a9ce23a50ce61cd89);
      this.c03788d88eb825d0e4375ff91a470e965 = new RadLabel();
      ((ISupportInitialize) this.cef99ac773757daa1842ee58c7914a0cc).BeginInit();
      ((ISupportInitialize) this.ced13435d37c83d5695f389153255d7aa).BeginInit();
      ((ISupportInitialize) this.c544236c90282c9157c1c7d7d9ff1369c).BeginInit();
      ((ISupportInitialize) this.c80abb9b1c6ac93efa1bec9b52c6e0411).BeginInit();
      ((ISupportInitialize) this.c3aec1f92fc33a551b592c8b2a7adf9ec).BeginInit();
      ((ISupportInitialize) this.cef22dcb29373b4f99e89eb28166e5dc2).BeginInit();
      ((ISupportInitialize) this.c8af15fc87ff7fad3b7d70b37794c0516).BeginInit();
      ((ISupportInitialize) this.c659877bdbb8d30820909c7b85d4f6330).BeginInit();
      ((ISupportInitialize) this.c799de9bbe8c05dd37f1ae092015d68e1).BeginInit();
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).SuspendLayout();
      ((ISupportInitialize) this.cc4a40b1385deb54376434c71c8e76b81).BeginInit();
      ((ISupportInitialize) this.c97c4e0fb1efa8799a0b6c47d1e86000e).BeginInit();
      ((ISupportInitialize) this.c29c9611cee072e30c8d766c88964ac2b).BeginInit();
      ((ISupportInitialize) this.c3ecd11fc9291e6c3176323b62baedac8).BeginInit();
      ((ISupportInitialize) this.c02f822b4a13df9d2c2d9666d3986f346).BeginInit();
      ((ISupportInitialize) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).BeginInit();
      ((ISupportInitialize) this.c93a99fb1c1183d9875099b634bd270a6).BeginInit();
      ((ISupportInitialize) this.c62f555309ebbf190dea30e5a84cef1bf).BeginInit();
      ((ISupportInitialize) this.c80b1c299c05614f9c782a38b86c99494).BeginInit();
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).SuspendLayout();
      ((ISupportInitialize) this.c2e00ce37891acd500b28d73704f69b35).BeginInit();
      ((ISupportInitialize) this.c560a6e04507a6b91381df70d8ba999e6).BeginInit();
      ((ISupportInitialize) this.c7ab9d9b723e77867834f5b804c1e8d84).BeginInit();
      ((ISupportInitialize) this.cf7bf7ed27e5378895056f9c4e22fa991).BeginInit();
      ((ISupportInitialize) this.c16be2b426e8d997c5d2b8f1d3becf90b).BeginInit();
      ((ISupportInitialize) this.cbc2eee5df02616fd21fbc91bc233cdcd).BeginInit();
      ((ISupportInitialize) this.c8827d4c0d7431a9890c547ec78a2c02c).BeginInit();
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).SuspendLayout();
      ((ISupportInitialize) this.cba8de59d8af22ab73fe624faad5b1c0d).BeginInit();
      ((ISupportInitialize) this.c089f82a5bb56d907790079762415ad00).BeginInit();
      ((ISupportInitialize) this.c139823df8e929f346d6de8a9db1cae22).BeginInit();
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).SuspendLayout();
      ((ISupportInitialize) this.c1f709ff5165e5433056bda30bb571911).BeginInit();
      ((ISupportInitialize) this.c9c662a4a0b9d44555b1f70db28046f61).BeginInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).BeginInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).SuspendLayout();
      ((ISupportInitialize) this.c6c17c59699d09a6deff3affeead81921).BeginInit();
      ((ISupportInitialize) this.c9e453c2e79f4fc55124ccb1fd3603902).BeginInit();
      ((ISupportInitialize) this.c38925728235576f0c42cd968bde792d6).BeginInit();
      ((ISupportInitialize) this.c05e1ef1d0f2e5250a57c757370b74d83).BeginInit();
      ((ISupportInitialize) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).BeginInit();
      ((ISupportInitialize) this.cba34b2a0111f6e5bc303375f968bc295).BeginInit();
      ((ISupportInitialize) this.cfa8badb30bc978147487352167d51546).BeginInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).BeginInit();
      ((ISupportInitialize) this.c743d2a65362475553a562cf35b254c43).BeginInit();
      ((ISupportInitialize) this.c3a32d8bd5fe0b6b703d373c8ec023149).BeginInit();
      ((ISupportInitialize) this.c207af470f351635895849de23ece3abc).BeginInit();
      ((ISupportInitialize) this.ced6aa7f9911c4707f69ec112a4e51672).BeginInit();
      ((ISupportInitialize) this.c489dec79b6c4a36ad71b2dd683ba4003).BeginInit();
      ((ISupportInitialize) this.c0bc74edb9773f357b639b398786841b3).BeginInit();
      ((ISupportInitialize) this.cdf03a2ca811ef49688b58b7e317a430a).BeginInit();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).BeginInit();
      ((ISupportInitialize) this.c6c840f966d621484314eb45e43e34565).BeginInit();
      ((ISupportInitialize) this.c738f1dd7afbbfdc20629834298bed929).BeginInit();
      ((ISupportInitialize) this.cd21917de552da0d5fa4c6079cd71111f).BeginInit();
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).SuspendLayout();
      ((ISupportInitialize) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).BeginInit();
      ((ISupportInitialize) this.c38668e2d3dc450be2fe10e8cdead5a82).BeginInit();
      ((ISupportInitialize) this.ca5a2b6669f9034e5fc384b9781cd6dd6).BeginInit();
      ((ISupportInitialize) this.c4f28cce9069ce7d56aa80dce66bd91fc).BeginInit();
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).SuspendLayout();
      ((ISupportInitialize) this.c5539dab8a40e8d2e2a7b970e134631c8).BeginInit();
      ((ISupportInitialize) this.c50c3a23f9473947fa39e14b6b066f539).BeginInit();
      ((ISupportInitialize) this.cb5983a9ef6bb031c7f34108a205a5729).BeginInit();
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).SuspendLayout();
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).SuspendLayout();
      ((ISupportInitialize) this.ceb095b069074eddeeb1ad92edcc4ec95).BeginInit();
      ((ISupportInitialize) this.c101d57e697d17803583217bbb889b590).BeginInit();
      ((ISupportInitialize) this.ce1a2609d728bf5b02ebcce5d0d03abac).BeginInit();
      ((ISupportInitialize) this.ccc252ce44a8e5cefbd8cd949ece215e5).BeginInit();
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).SuspendLayout();
      ((ISupportInitialize) this.c14d5ba9c8d3dcbc17433b50217356b5a).BeginInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).BeginInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).BeginInit();
      ((ISupportInitialize) this.c0ebc97b073a7d0dba554313d3f62139d).BeginInit();
      ((ISupportInitialize) this.c0b8c323aae75c040334498c5efcb96f4).BeginInit();
      ((ISupportInitialize) this.c453acc1433bd9ed8673278dbdd4bee00).BeginInit();
      ((Control) this.c453acc1433bd9ed8673278dbdd4bee00).SuspendLayout();
      ((Control) this.c3ec3e29a74c0f512f2935f1207d1a895).SuspendLayout();
      ((ISupportInitialize) this.c0c0e712d5ca94f2910e3ec339b2e600f).BeginInit();
      ((ISupportInitialize) this.cae3beaf3bc9f066d134288b1cc6a2ab6).BeginInit();
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).SuspendLayout();
      ((ISupportInitialize) this.c6f51d70787b53494b9f2a90f93e5091c).BeginInit();
      ((Control) this.c6f51d70787b53494b9f2a90f93e5091c).SuspendLayout();
      ((ISupportInitialize) this.cfda0f7e74c13d6b7f59b7c808dd15331).BeginInit();
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).SuspendLayout();
      ((Control) this.c44e1112bbc33afd80a87709982a149c4).SuspendLayout();
      ((ISupportInitialize) this.c39e7e88f29f2018d9aa6c123a5da05b9).BeginInit();
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).SuspendLayout();
      ((ISupportInitialize) this.c68b8f2723032c53a16a489755afa9f3d).BeginInit();
      ((ISupportInitialize) this.cc823a5ecc3a0639558b6b92439679149).BeginInit();
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).SuspendLayout();
      ((ISupportInitialize) this.c414a01a9d1ea6f9447f9d5fee7291bd3).BeginInit();
      ((Control) this.c89ff289eea7f33d04edb7f11d666c144).SuspendLayout();
      ((ISupportInitialize) this.c422900b304a63407dfa05f2f233b004e).BeginInit();
      ((Control) this.c422900b304a63407dfa05f2f233b004e).SuspendLayout();
      ((ISupportInitialize) this.ca9c68e79493f9e09d605914c6cd6edd5).BeginInit();
      ((ISupportInitialize) this.c51175a4a3b6b11c0eee765ad7effd076).BeginInit();
      ((ISupportInitialize) this.cf152d3e6147dc4e0112582d0f6097ce3).BeginInit();
      ((ISupportInitialize) this.cbe00b03ee2347f9756848babd446e36c).BeginInit();
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).SuspendLayout();
      ((Control) this.c2f75881f4e3a569756004ecd1f3c8da3).SuspendLayout();
      ((ISupportInitialize) this.c101a585c2bc6dfb0b62b86bd680ce2b2).BeginInit();
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).SuspendLayout();
      ((ISupportInitialize) this.c780e6034938558087f1ea7ad59d1d853).BeginInit();
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).SuspendLayout();
      ((ISupportInitialize) this.c86ce7f867a560282470decd22cec0860).BeginInit();
      ((ISupportInitialize) this.c22d04ce1034d647a95d30b01a54768c4).BeginInit();
      ((ISupportInitialize) this.cfda9a98a11ebdc24a447457307015f17).BeginInit();
      ((ISupportInitialize) this.c979c76a51f33de27b2440305fd60fd38).BeginInit();
      ((ISupportInitialize) this.ce55c0c71a3136c1bba91d488db23a660).BeginInit();
      ((ISupportInitialize) this.cb92ad5a7459656fe7b6fd86ff472b5c5).BeginInit();
      ((ISupportInitialize) this.c77ab4cca03476e6662d72295ae2a18d0).BeginInit();
      ((ISupportInitialize) this.c28cccb4bc1305f639acf2d457aeedad8).BeginInit();
      ((ISupportInitialize) this.ca380231837e2eafdb42e81f47a24d226).BeginInit();
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).SuspendLayout();
      ((ISupportInitialize) this.cded9ed150a9ac47f6949a468fac193a6).BeginInit();
      ((ISupportInitialize) this.c340f7ccf001170543c57999fd96d4b38).BeginInit();
      ((ISupportInitialize) this.cd8a4426aac26fd0166c7b44e9f731455).BeginInit();
      ((ISupportInitialize) this.c4fda90ba27d8ac9ff70115293efc7b38).BeginInit();
      ((ISupportInitialize) this.c0770534b75ebeea0c4e695dfdb7677d0).BeginInit();
      ((ISupportInitialize) this.c67131d5ebad4559120841e7d6afbf050).BeginInit();
      ((ISupportInitialize) this.cadd2602239e2a87754cb1203ec048ce7).BeginInit();
      ((ISupportInitialize) this.cf9e2786454699a4c03d6a769f423882e).BeginInit();
      ((ISupportInitialize) this.ceb96360e1866456699fd2a748e058db6).BeginInit();
      ((ISupportInitialize) this.c1b58d84e7b46cb77f175ef1b94421baf).BeginInit();
      ((ISupportInitialize) this.c5b062d1e6fbb1c9186310faefca6b2fa).BeginInit();
      ((Control) this.c5b062d1e6fbb1c9186310faefca6b2fa).SuspendLayout();
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).SuspendLayout();
      ((ISupportInitialize) this.cbb44104e6cbbb2680035694332b80a01).BeginInit();
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).SuspendLayout();
      ((ISupportInitialize) this.c2769778d069bafd899ea27ebc8b3b6f7).BeginInit();
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).SuspendLayout();
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).SuspendLayout();
      ((ISupportInitialize) this.c4ffe800d52986b27d66e2886fadad952).BeginInit();
      ((ISupportInitialize) this.c74ae2563a72edeef646bba38ebdd0ce8).BeginInit();
      ((ISupportInitialize) this.cc5109af75315520586ca50d6cd84c973).BeginInit();
      ((ISupportInitialize) this.c830db343ebd6db124b1b541a729f89ad).BeginInit();
      ((Control) this.c830db343ebd6db124b1b541a729f89ad).SuspendLayout();
      ((ISupportInitialize) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).BeginInit();
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).SuspendLayout();
      ((Control) this.c78b2def3d06d6b5a4d21846a0d787eee).SuspendLayout();
      ((ISupportInitialize) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).BeginInit();
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).SuspendLayout();
      ((ISupportInitialize) this.c00cbac6f52b66fe9075f2e2d10af540a).BeginInit();
      ((ISupportInitialize) this.c20125c1e72d687c9063a72becb2b139c).BeginInit();
      ((ISupportInitialize) this.c2f140be112f4d6280c6d8b3f548ccb8a).BeginInit();
      ((ISupportInitialize) this.cbd1041f8be005d147b5e93849f76b59d).BeginInit();
      ((ISupportInitialize) this.c8692650f24b3012c232c930089f0258c).BeginInit();
      ((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b).SuspendLayout();
      ((ISupportInitialize) this.ccd11edb9d36850a5cccf6849cebf8790).BeginInit();
      ((ISupportInitialize) this.c9828af810645b7cadbb5e7f90ebdc726).BeginInit();
      ((ISupportInitialize) this.c0c519a92c14db391cc60009c355f6c77).BeginInit();
      ((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a).SuspendLayout();
      ((ISupportInitialize) this.c8feaaff2cfc11c5e9956aac64eb58b35).BeginInit();
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).SuspendLayout();
      ((ISupportInitialize) this.c2847a413b553d4c7de02d6550eafde3c).BeginInit();
      ((ISupportInitialize) this.c357bfd7fc69acf74548222098fb25669).BeginInit();
      ((Control) this.c24e3e0bc5926188969ef6ed35bca3f48).SuspendLayout();
      ((ISupportInitialize) this.cdff096b93bcf8895ef6ce933c902940d).BeginInit();
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).SuspendLayout();
      ((ISupportInitialize) this.ce0e7fe2dec7b73af921b84452e573154).BeginInit();
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).SuspendLayout();
      ((ISupportInitialize) this.c58eefb73a902712c6fd5929e97bd4b97).BeginInit();
      ((ISupportInitialize) this.cf1bbdaba14013386fcabe835941101b9).BeginInit();
      ((ISupportInitialize) this.c8e4e933c1082ae051c164f38f5d1cb14).BeginInit();
      ((ISupportInitialize) this.c0185dca1f25fc3c2cc62921a9050d18f).BeginInit();
      ((Control) this.c0185dca1f25fc3c2cc62921a9050d18f).SuspendLayout();
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).SuspendLayout();
      ((ISupportInitialize) this.cddad6496d4e1c285617512daf16ee740).BeginInit();
      ((Control) this.cddad6496d4e1c285617512daf16ee740).SuspendLayout();
      ((ISupportInitialize) this.ceb25ec87df1d957dbabc08d3338713dd).BeginInit();
      ((Control) this.ceb25ec87df1d957dbabc08d3338713dd).SuspendLayout();
      ((ISupportInitialize) this.c91e9024abe6202a1b65e9677c8b82412).BeginInit();
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).SuspendLayout();
      ((Control) this.c28c4210040b2b3298484f4b1697ed477).SuspendLayout();
      ((ISupportInitialize) this.cf273feb18353b8a5aca9b1d1f46844c6).BeginInit();
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).SuspendLayout();
      ((ISupportInitialize) this.ca649489ce70abf72060d3b333298ed77).BeginInit();
      ((ISupportInitialize) this.c8c95b6e3f74e541d66aa845a751279d2).BeginInit();
      ((ISupportInitialize) this.c4f9790e49b5c17eba6614a7824f1741c).BeginInit();
      ((ISupportInitialize) this.ce5de00809f1e6aab265b64623d9bc1a5).BeginInit();
      ((ISupportInitialize) this.cf8a1dc8cf7f73143ea81640d7645c738).BeginInit();
      ((Control) this.ccf9a1c650ea674b5d9aff1def6334db2).SuspendLayout();
      ((ISupportInitialize) this.cb6204fff3792b968130bf39d7e003531).BeginInit();
      ((Control) this.cb6204fff3792b968130bf39d7e003531).SuspendLayout();
      ((ISupportInitialize) this.c264210f8880117c5d13694e2bdf33135).BeginInit();
      ((ISupportInitialize) this.c7730aeebdbd664b38e5f8bbc1437a2c2).BeginInit();
      ((ISupportInitialize) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).BeginInit();
      ((ISupportInitialize) this.c2ccfe80606082cc7f5920727b308bf4d).BeginInit();
      ((ISupportInitialize) this.c0b71e1da7d09a3789bead9e0ff8feda4).BeginInit();
      ((ISupportInitialize) this.ce2e62cad203b8927cba774d40cc26e1e).BeginInit();
      ((Control) this.cf18cb5dad0d928f1718d2705e894530d).SuspendLayout();
      ((ISupportInitialize) this.ca17c92fca2120e58e5f8f7c1e444d324).BeginInit();
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).SuspendLayout();
      ((ISupportInitialize) this.c99759b9e421322e16d5c36b476bb666f).BeginInit();
      ((ISupportInitialize) this.c6b7d903aa965d47e2f39fa93f9aa3134).BeginInit();
      ((ISupportInitialize) this.c2d265ee1256f88eddf3baa3887d2c91d).BeginInit();
      ((ISupportInitialize) this.c4533e25263801abd1cc5792ca28f28c1).BeginInit();
      ((ISupportInitialize) this.c7a8633bba80a50b81c114da3ab992208).BeginInit();
      ((ISupportInitialize) this.c7970189ca187b55d3e75631f17e4b67c).BeginInit();
      ((ISupportInitialize) this.c03788d88eb825d0e4375ff91a470e965).BeginInit();
      ((ISupportInitialize) this).BeginInit();
      ((RadFormControlBase) this).SuspendLayout();
      ((DockWindow) this.c53cbb17a05b0cbad7d563b1e9b75cd53).set_AutoHideSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13278), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13282)));
      this.c53cbb17a05b0cbad7d563b1e9b75cd53.set_DockWindowName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26269));
      this.c53cbb17a05b0cbad7d563b1e9b75cd53.set_DockWindowText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26294));
      ((Control) this.c53cbb17a05b0cbad7d563b1e9b75cd53).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13286));
      ((TabPanel) this.c53cbb17a05b0cbad7d563b1e9b75cd53).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13290), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13294)));
      ((DockWindow) this.c53cbb17a05b0cbad7d563b1e9b75cd53).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26368));
      ((DockWindow) this.c53cbb17a05b0cbad7d563b1e9b75cd53).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13298));
      ((TabPanel) this.c53cbb17a05b0cbad7d563b1e9b75cd53).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13302), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13306)));
      ((Control) this.c53cbb17a05b0cbad7d563b1e9b75cd53).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26368);
      ((DockWindow) this.c8c4139dc5bdf8baad6014fa6ae28608e).set_AutoHideSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13310), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13314)));
      this.c8c4139dc5bdf8baad6014fa6ae28608e.set_DockWindowName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26413));
      this.c8c4139dc5bdf8baad6014fa6ae28608e.set_DockWindowText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26430));
      ((Control) this.c8c4139dc5bdf8baad6014fa6ae28608e).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13318));
      ((TabPanel) this.c8c4139dc5bdf8baad6014fa6ae28608e).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13322), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13326)));
      ((DockWindow) this.c8c4139dc5bdf8baad6014fa6ae28608e).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26451));
      ((DockWindow) this.c8c4139dc5bdf8baad6014fa6ae28608e).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13330));
      ((TabPanel) this.c8c4139dc5bdf8baad6014fa6ae28608e).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13334), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13338)));
      ((Control) this.c8c4139dc5bdf8baad6014fa6ae28608e).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26451);
      ((Control) this.cef99ac773757daa1842ee58c7914a0cc).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13342);
      ((Control) this.cef99ac773757daa1842ee58c7914a0cc).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13346), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13350));
      ((Control) this.cef99ac773757daa1842ee58c7914a0cc).MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13354), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13358));
      ((Control) this.cef99ac773757daa1842ee58c7914a0cc).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26496);
      ((RadElement) ((RadControl) this.cef99ac773757daa1842ee58c7914a0cc).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13362), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13366)));
      ((Control) this.cef99ac773757daa1842ee58c7914a0cc).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13370), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13374));
      ((Control) this.cef99ac773757daa1842ee58c7914a0cc).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13378);
      ((RadControl) this.cef99ac773757daa1842ee58c7914a0cc).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cef99ac773757daa1842ee58c7914a0cc).TextChanged += new EventHandler(this.c33de508dba0445c362e54c4418c0d9e8);
      this.ced13435d37c83d5695f389153255d7aa.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13382) != 0);
      this.ced13435d37c83d5695f389153255d7aa.set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13386) != 0);
      ((Control) this.ced13435d37c83d5695f389153255d7aa).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13390);
      viewDetailColumn1.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26155));
      viewDetailColumn1.set_Width(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13394));
      viewDetailColumn2.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(9029));
      viewDetailColumn2.set_Width(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13398));
      viewDetailColumn3.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26181));
      viewDetailColumn3.set_Width(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13402));
      viewDetailColumn4.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26207));
      viewDetailColumn4.set_Width(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13406));
      viewDetailColumn5.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18748));
      viewDetailColumn5.set_Width(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13410));
      viewDetailColumn6.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26262));
      viewDetailColumn6.set_Width(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13414));
      ListViewColumnCollection columns = this.ced13435d37c83d5695f389153255d7aa.get_Columns();
      ListViewDetailColumn[] viewDetailColumnArray = ccfba36ada6e0fbc3be319dd8ce6669d8.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13418));
      int index1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13422);
      ListViewDetailColumn viewDetailColumn7 = viewDetailColumn1;
      viewDetailColumnArray[index1] = viewDetailColumn7;
      int index2 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13426);
      ListViewDetailColumn viewDetailColumn8 = viewDetailColumn2;
      viewDetailColumnArray[index2] = viewDetailColumn8;
      int index3 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13430);
      ListViewDetailColumn viewDetailColumn9 = viewDetailColumn3;
      viewDetailColumnArray[index3] = viewDetailColumn9;
      int index4 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13434);
      ListViewDetailColumn viewDetailColumn10 = viewDetailColumn4;
      viewDetailColumnArray[index4] = viewDetailColumn10;
      int index5 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13438);
      ListViewDetailColumn viewDetailColumn11 = viewDetailColumn5;
      viewDetailColumnArray[index5] = viewDetailColumn11;
      int index6 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13442);
      ListViewDetailColumn viewDetailColumn12 = viewDetailColumn6;
      viewDetailColumnArray[index6] = viewDetailColumn12;
      columns.AddRange(viewDetailColumnArray);
      this.ced13435d37c83d5695f389153255d7aa.set_EnableColumnSort(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13446) != 0);
      this.ced13435d37c83d5695f389153255d7aa.set_EnableSorting(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13450) != 0);
      ((Control) this.ced13435d37c83d5695f389153255d7aa).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13454));
      this.ced13435d37c83d5695f389153255d7aa.set_FullRowSelect(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13458) != 0);
      this.ced13435d37c83d5695f389153255d7aa.set_ItemSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13462), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13466)));
      ((Control) this.ced13435d37c83d5695f389153255d7aa).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13470), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13474));
      this.ced13435d37c83d5695f389153255d7aa.set_MultiSelect(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13478) != 0);
      ((Control) this.ced13435d37c83d5695f389153255d7aa).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26519);
      this.ced13435d37c83d5695f389153255d7aa.set_SelectLastAddedItem(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13482) != 0);
      this.ced13435d37c83d5695f389153255d7aa.set_ShowGroups(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13486) != 0);
      ((Control) this.ced13435d37c83d5695f389153255d7aa).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13490), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13494));
      ((Control) this.ced13435d37c83d5695f389153255d7aa).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13498);
      ((RadControl) this.ced13435d37c83d5695f389153255d7aa).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((RadControl) this.ced13435d37c83d5695f389153255d7aa).set_UseCompatibleTextRendering(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13502) != 0);
      this.ced13435d37c83d5695f389153255d7aa.set_ViewType((ListViewType) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13506));
      this.ced13435d37c83d5695f389153255d7aa.add_SelectedItemChanged(new EventHandler(this.c8de4f763b730f04a68cdf4528711bf9a));
      // ISSUE: method pointer
      this.ced13435d37c83d5695f389153255d7aa.add_ItemMouseUp(new ListViewItemMouseEventHandler((object) this, __methodptr(cdfad1e711ba827f4de7386494f8844a2)));
      ((Control) this.ced13435d37c83d5695f389153255d7aa).SizeChanged += new EventHandler(this.cd14926deced4992ca415ad87542200ef);
      this.c2399b7113e731f78fc41e13b97230ba2.FileName = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26536);
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13510);
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13514), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13518));
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(18789);
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13522), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13526));
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13530);
      ((Control) this.c544236c90282c9157c1c7d7d9ff1369c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26553);
      ((RadControl) this.c544236c90282c9157c1c7d7d9ff1369c).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c80abb9b1c6ac93efa1bec9b52c6e0411.set_AllowColumnReorder(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13534) != 0);
      this.c80abb9b1c6ac93efa1bec9b52c6e0411.set_AllowColumnResize(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13538) != 0);
      this.c80abb9b1c6ac93efa1bec9b52c6e0411.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13542) != 0);
      this.c80abb9b1c6ac93efa1bec9b52c6e0411.set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13546) != 0);
      ((Control) this.c80abb9b1c6ac93efa1bec9b52c6e0411).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13550);
      ((Control) this.c80abb9b1c6ac93efa1bec9b52c6e0411).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(13554));
      ((Control) this.c80abb9b1c6ac93efa1bec9b52c6e0411).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13558), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13562));
      ((Control) this.c80abb9b1c6ac93efa1bec9b52c6e0411).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26630);
      ((Control) this.c80abb9b1c6ac93efa1bec9b52c6e0411).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13566), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13570));
      ((Control) this.c80abb9b1c6ac93efa1bec9b52c6e0411).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13574);
      ((RadControl) this.c80abb9b1c6ac93efa1bec9b52c6e0411).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      this.c80abb9b1c6ac93efa1bec9b52c6e0411.add_ItemMouseDoubleClick(new ListViewItemEventHandler((object) this, __methodptr(c38398a8ddfd723e7a6f8149362fb466f)));
      ((Control) this.c3aec1f92fc33a551b592c8b2a7adf9ec).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13578);
      ((Control) this.c3aec1f92fc33a551b592c8b2a7adf9ec).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13582), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13586));
      ((Control) this.c3aec1f92fc33a551b592c8b2a7adf9ec).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26645);
      ((Control) this.c3aec1f92fc33a551b592c8b2a7adf9ec).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13590), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13594));
      ((Control) this.c3aec1f92fc33a551b592c8b2a7adf9ec).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13598);
      ((Control) this.c3aec1f92fc33a551b592c8b2a7adf9ec).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26670);
      ((RadControl) this.c3aec1f92fc33a551b592c8b2a7adf9ec).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cef22dcb29373b4f99e89eb28166e5dc2).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13602);
      ((Control) this.cef22dcb29373b4f99e89eb28166e5dc2).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13606), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13610));
      ((Control) this.cef22dcb29373b4f99e89eb28166e5dc2).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26709);
      ((Control) this.cef22dcb29373b4f99e89eb28166e5dc2).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13614), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13618));
      ((Control) this.cef22dcb29373b4f99e89eb28166e5dc2).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13622);
      ((Control) this.cef22dcb29373b4f99e89eb28166e5dc2).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26730);
      ((RadControl) this.cef22dcb29373b4f99e89eb28166e5dc2).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13626), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13630));
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15097);
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13634), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13638));
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13642);
      ((Control) this.c8af15fc87ff7fad3b7d70b37794c0516).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26739);
      ((RadControl) this.c8af15fc87ff7fad3b7d70b37794c0516).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c659877bdbb8d30820909c7b85d4f6330).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13646);
      ((Control) this.c659877bdbb8d30820909c7b85d4f6330).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13650), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13654));
      ((Control) this.c659877bdbb8d30820909c7b85d4f6330).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26756);
      ((Control) this.c659877bdbb8d30820909c7b85d4f6330).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13658), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13662));
      ((Control) this.c659877bdbb8d30820909c7b85d4f6330).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13666);
      ((Control) this.c659877bdbb8d30820909c7b85d4f6330).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26773);
      ((RadControl) this.c659877bdbb8d30820909c7b85d4f6330).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13670);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c761bc48a0ac5352d2a79834b62d8e9c7);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.cc4a40b1385deb54376434c71c8e76b81);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c29c9611cee072e30c8d766c88964ac2b);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c3ecd11fc9291e6c3176323b62baedac8);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c02f822b4a13df9d2c2d9666d3986f346);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c6e68d4163e92bbc6a33bc1e07bf15a4f);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c93a99fb1c1183d9875099b634bd270a6);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Controls.Add((Control) this.c62f555309ebbf190dea30e5a84cef1bf);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13674);
      this.c799de9bbe8c05dd37f1ae092015d68e1.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26808));
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13678), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13682));
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26893);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13686), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13690));
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13694);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26808);
      ((RadControl) this.c799de9bbe8c05dd37f1ae092015d68e1).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13698);
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13702), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13706));
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26918);
      this.c761bc48a0ac5352d2a79834b62d8e9c7.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13710), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13714));
      this.c761bc48a0ac5352d2a79834b62d8e9c7.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13718);
      ((Control) this.cc4a40b1385deb54376434c71c8e76b81).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13722);
      ((Control) this.cc4a40b1385deb54376434c71c8e76b81).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13726), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13730));
      ((Control) this.cc4a40b1385deb54376434c71c8e76b81).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26933);
      ((Control) this.cc4a40b1385deb54376434c71c8e76b81).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13734), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13738));
      ((Control) this.cc4a40b1385deb54376434c71c8e76b81).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13742);
      ((Control) this.cc4a40b1385deb54376434c71c8e76b81).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7494);
      ((RadControl) this.cc4a40b1385deb54376434c71c8e76b81).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cc4a40b1385deb54376434c71c8e76b81).Click += new EventHandler(this.c1c8f0e7a14b8a30b8cab7c4bff0e2c99);
      ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13746);
      ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13750), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13754));
      ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26960);
      ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13758), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13762));
      ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13766);
      ((Control) this.c97c4e0fb1efa8799a0b6c47d1e86000e).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c97c4e0fb1efa8799a0b6c47d1e86000e).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c29c9611cee072e30c8d766c88964ac2b).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13770);
      ((Control) this.c29c9611cee072e30c8d766c88964ac2b).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13774), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13778));
      ((Control) this.c29c9611cee072e30c8d766c88964ac2b).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26983);
      ((Control) this.c29c9611cee072e30c8d766c88964ac2b).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13782), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13786));
      ((Control) this.c29c9611cee072e30c8d766c88964ac2b).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13790);
      ((Control) this.c29c9611cee072e30c8d766c88964ac2b).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27002);
      ((RadControl) this.c29c9611cee072e30c8d766c88964ac2b).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      ((RadToggleButton) this.c29c9611cee072e30c8d766c88964ac2b).add_ToggleStateChanging(new StateChangingEventHandler((object) this, __methodptr(cb3c0eb294ec216be897d38e42a835065)));
      ((Control) this.c3ecd11fc9291e6c3176323b62baedac8).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13794);
      ((Control) this.c3ecd11fc9291e6c3176323b62baedac8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13798), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13802));
      ((Control) this.c3ecd11fc9291e6c3176323b62baedac8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27031);
      ((Control) this.c3ecd11fc9291e6c3176323b62baedac8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13806), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13810));
      ((Control) this.c3ecd11fc9291e6c3176323b62baedac8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13814);
      ((Control) this.c3ecd11fc9291e6c3176323b62baedac8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27054);
      ((RadControl) this.c3ecd11fc9291e6c3176323b62baedac8).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      ((RadToggleButton) this.c3ecd11fc9291e6c3176323b62baedac8).add_ToggleStateChanged(new StateChangedEventHandler((object) this, __methodptr(cd0c9263fcd991c77542f5cf4fbd60b91)));
      ((Control) this.c02f822b4a13df9d2c2d9666d3986f346).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13818);
      ((Control) this.c02f822b4a13df9d2c2d9666d3986f346).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13822), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13826));
      ((Control) this.c02f822b4a13df9d2c2d9666d3986f346).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27075);
      ((Control) this.c02f822b4a13df9d2c2d9666d3986f346).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13830), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13834));
      ((Control) this.c02f822b4a13df9d2c2d9666d3986f346).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13838);
      ((Control) this.c02f822b4a13df9d2c2d9666d3986f346).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27092);
      ((RadControl) this.c02f822b4a13df9d2c2d9666d3986f346).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      ((RadToggleButton) this.c02f822b4a13df9d2c2d9666d3986f346).add_ToggleStateChanged(new StateChangedEventHandler((object) this, __methodptr(c3d2d7b5364902602a5665ae731a9a0ec)));
      ((Control) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13842);
      ((Control) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13846), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13850));
      ((Control) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27103);
      ((Control) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13854), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13858));
      ((Control) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13862);
      ((Control) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27126);
      ((RadControl) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      ((RadToggleButton) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).add_ToggleStateChanged(new StateChangedEventHandler((object) this, __methodptr(cdaf14beb5078d3d484015916b39121af)));
      ((Control) this.c93a99fb1c1183d9875099b634bd270a6).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13866);
      ((Control) this.c93a99fb1c1183d9875099b634bd270a6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13870), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13874));
      ((Control) this.c93a99fb1c1183d9875099b634bd270a6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27145);
      ((Control) this.c93a99fb1c1183d9875099b634bd270a6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13878), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13882));
      ((Control) this.c93a99fb1c1183d9875099b634bd270a6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13886);
      ((Control) this.c93a99fb1c1183d9875099b634bd270a6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27162);
      ((RadControl) this.c93a99fb1c1183d9875099b634bd270a6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      ((RadToggleButton) this.c93a99fb1c1183d9875099b634bd270a6).add_ToggleStateChanged(new StateChangedEventHandler((object) this, __methodptr(c2491a646585438568668fb0ad065076f)));
      ((Control) this.c62f555309ebbf190dea30e5a84cef1bf).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13890);
      ((Control) this.c62f555309ebbf190dea30e5a84cef1bf).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13894), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13898));
      ((Control) this.c62f555309ebbf190dea30e5a84cef1bf).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27187);
      ((Control) this.c62f555309ebbf190dea30e5a84cef1bf).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13902), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13906));
      ((Control) this.c62f555309ebbf190dea30e5a84cef1bf).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13910);
      ((Control) this.c62f555309ebbf190dea30e5a84cef1bf).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27212);
      ((RadControl) this.c62f555309ebbf190dea30e5a84cef1bf).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      ((RadToggleButton) this.c62f555309ebbf190dea30e5a84cef1bf).add_ToggleStateChanged(new StateChangedEventHandler((object) this, __methodptr(cb5ff5cf4fa3c141ce748b8ed4ad5dd29)));
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13914);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Controls.Add((Control) this.c2e00ce37891acd500b28d73704f69b35);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Controls.Add((Control) this.c560a6e04507a6b91381df70d8ba999e6);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Controls.Add((Control) this.c7ab9d9b723e77867834f5b804c1e8d84);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Controls.Add((Control) this.cf7bf7ed27e5378895056f9c4e22fa991);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Controls.Add((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13918);
      this.c80b1c299c05614f9c782a38b86c99494.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27231));
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13922), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13926));
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27250);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13930), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13934));
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13938);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27231);
      ((RadControl) this.c80b1c299c05614f9c782a38b86c99494).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c2e00ce37891acd500b28d73704f69b35).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13942);
      ((Control) this.c2e00ce37891acd500b28d73704f69b35).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13946), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13950));
      ((Control) this.c2e00ce37891acd500b28d73704f69b35).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27279);
      ((Control) this.c2e00ce37891acd500b28d73704f69b35).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13954), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13958));
      ((Control) this.c2e00ce37891acd500b28d73704f69b35).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13962);
      ((Control) this.c2e00ce37891acd500b28d73704f69b35).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27298);
      ((RadControl) this.c2e00ce37891acd500b28d73704f69b35).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c560a6e04507a6b91381df70d8ba999e6).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13966);
      ((Control) this.c560a6e04507a6b91381df70d8ba999e6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13970), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13974));
      RadSpinEditor c560a6e04507a6b91381df70d8ba999e6 = this.c560a6e04507a6b91381df70d8ba999e6;
      int[] bits = c6ef0b4086a9ddbe24e2ddab8d4b99374.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13978));
      int index7 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13982);
      int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13986);
      bits[index7] = num1;
      Decimal num2 = new Decimal(bits);
      c560a6e04507a6b91381df70d8ba999e6.set_Maximum(num2);
      this.c560a6e04507a6b91381df70d8ba999e6.set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27333));
      ((Control) this.c560a6e04507a6b91381df70d8ba999e6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13990), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13994));
      ((Control) this.c560a6e04507a6b91381df70d8ba999e6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(13998);
      ((Control) this.c560a6e04507a6b91381df70d8ba999e6).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14002) != 0;
      this.c560a6e04507a6b91381df70d8ba999e6.add_ValueChanged(new EventHandler(this.c2c926829a79cf57c9424a7fb0b168dee));
      ((Control) this.c7ab9d9b723e77867834f5b804c1e8d84).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14006), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14010));
      ((Control) this.c7ab9d9b723e77867834f5b804c1e8d84).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27356);
      ((Control) this.c7ab9d9b723e77867834f5b804c1e8d84).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14014), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14018));
      ((Control) this.c7ab9d9b723e77867834f5b804c1e8d84).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14022);
      ((Control) this.c7ab9d9b723e77867834f5b804c1e8d84).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27379);
      ((RadControl) this.c7ab9d9b723e77867834f5b804c1e8d84).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cf7bf7ed27e5378895056f9c4e22fa991).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14026);
      ((Control) this.cf7bf7ed27e5378895056f9c4e22fa991).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14030), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14034));
      ((Control) this.cf7bf7ed27e5378895056f9c4e22fa991).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27408);
      this.cf7bf7ed27e5378895056f9c4e22fa991.set_ShowProgressIndicators(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14038) != 0);
      ((Control) this.cf7bf7ed27e5378895056f9c4e22fa991).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14042), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14046));
      ((Control) this.cf7bf7ed27e5378895056f9c4e22fa991).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14050);
      ((Control) this.cf7bf7ed27e5378895056f9c4e22fa991).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7393);
      ((RadControl) this.cf7bf7ed27e5378895056f9c4e22fa991).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14054);
      ((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14058), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14062));
      ((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27435);
      ((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14066), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14070));
      ((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14074);
      ((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7494);
      ((RadControl) this.c16be2b426e8d997c5d2b8f1d3becf90b).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c16be2b426e8d997c5d2b8f1d3becf90b).Click += new EventHandler(this.cbc7a5c8395621b199b687bcf2d150166);
      ((Control) this.cbc2eee5df02616fd21fbc91bc233cdcd).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14078);
      ((Control) this.cbc2eee5df02616fd21fbc91bc233cdcd).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14082), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14086));
      ((Control) this.cbc2eee5df02616fd21fbc91bc233cdcd).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27458);
      ((Control) this.cbc2eee5df02616fd21fbc91bc233cdcd).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14090), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14094));
      ((Control) this.cbc2eee5df02616fd21fbc91bc233cdcd).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14098);
      ((Control) this.cbc2eee5df02616fd21fbc91bc233cdcd).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      ((RadControl) this.cbc2eee5df02616fd21fbc91bc233cdcd).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14102);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14106) != 0;
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.cba8de59d8af22ab73fe624faad5b1c0d);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c089f82a5bb56d907790079762415ad00);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c139823df8e929f346d6de8a9db1cae22);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c1f709ff5165e5433056bda30bb571911);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Controls.Add((Control) this.c9c662a4a0b9d44555b1f70db28046f61);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14110);
      this.c8827d4c0d7431a9890c547ec78a2c02c.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27471));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14114), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14118));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14311);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14122), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14126));
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14130);
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27471);
      ((RadControl) this.c8827d4c0d7431a9890c547ec78a2c02c).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14134);
      this.cba8de59d8af22ab73fe624faad5b1c0d.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14138));
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14142) != 0;
      ((RadButtonBase) this.cba8de59d8af22ab73fe624faad5b1c0d).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27486))));
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14146), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14150));
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27517);
      ((RadControl) this.cba8de59d8af22ab73fe624faad5b1c0d).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14154)));
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14158), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14162));
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14166);
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27536);
      ((RadButtonBase) this.cba8de59d8af22ab73fe624faad5b1c0d).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14170));
      ((RadButtonBase) this.cba8de59d8af22ab73fe624faad5b1c0d).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14174));
      ((RadControl) this.cba8de59d8af22ab73fe624faad5b1c0d).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cba8de59d8af22ab73fe624faad5b1c0d).Click += new EventHandler(this.c46256fe3803456a592ab764c4f77e686);
      ((Control) this.c089f82a5bb56d907790079762415ad00).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14178);
      this.c089f82a5bb56d907790079762415ad00.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14182));
      ((Control) this.c089f82a5bb56d907790079762415ad00).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14186) != 0;
      ((RadButtonBase) this.c089f82a5bb56d907790079762415ad00).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27549))));
      ((Control) this.c089f82a5bb56d907790079762415ad00).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14190), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14194));
      ((Control) this.c089f82a5bb56d907790079762415ad00).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27576);
      ((RadControl) this.c089f82a5bb56d907790079762415ad00).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14198)));
      ((Control) this.c089f82a5bb56d907790079762415ad00).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14202), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14206));
      ((Control) this.c089f82a5bb56d907790079762415ad00).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14210);
      ((Control) this.c089f82a5bb56d907790079762415ad00).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27591);
      ((RadButtonBase) this.c089f82a5bb56d907790079762415ad00).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14214));
      ((RadButtonBase) this.c089f82a5bb56d907790079762415ad00).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14218));
      ((RadControl) this.c089f82a5bb56d907790079762415ad00).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c089f82a5bb56d907790079762415ad00).Click += new EventHandler(this.c58d2f8fc315dc501ba3a7de121a2bc95);
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14222);
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Controls.Add((Control) this.c0aaf89283992def05decf8054f449068);
      this.c139823df8e929f346d6de8a9db1cae22.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14226));
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14230) != 0;
      ((RadButtonBase) this.c139823df8e929f346d6de8a9db1cae22).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27612))));
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14234), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14238));
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27643);
      ((RadControl) this.c139823df8e929f346d6de8a9db1cae22).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14242)));
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14246), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14250));
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14254);
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25711);
      ((RadButtonBase) this.c139823df8e929f346d6de8a9db1cae22).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14258));
      ((RadButtonBase) this.c139823df8e929f346d6de8a9db1cae22).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14262));
      ((RadControl) this.c139823df8e929f346d6de8a9db1cae22).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).Click += new EventHandler(this.c25d8652f001605d69f6df0b4a0d26af7);
      this.c0aaf89283992def05decf8054f449068.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14266) != 0;
      this.c0aaf89283992def05decf8054f449068.BackColor = Color.Transparent;
      this.c0aaf89283992def05decf8054f449068.ForeColor = Color.Red;
      this.c0aaf89283992def05decf8054f449068.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14270), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14274));
      this.c0aaf89283992def05decf8054f449068.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27662);
      this.c0aaf89283992def05decf8054f449068.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14278), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14282));
      this.c0aaf89283992def05decf8054f449068.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14286);
      this.c0aaf89283992def05decf8054f449068.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27675);
      ((Control) this.c1f709ff5165e5433056bda30bb571911).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14290);
      this.c1f709ff5165e5433056bda30bb571911.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14294));
      ((Control) this.c1f709ff5165e5433056bda30bb571911).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14298) != 0;
      ((RadButtonBase) this.c1f709ff5165e5433056bda30bb571911).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27694))));
      ((Control) this.c1f709ff5165e5433056bda30bb571911).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14302), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14306));
      ((Control) this.c1f709ff5165e5433056bda30bb571911).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27731);
      ((RadControl) this.c1f709ff5165e5433056bda30bb571911).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14310)));
      ((Control) this.c1f709ff5165e5433056bda30bb571911).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14314), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14318));
      ((Control) this.c1f709ff5165e5433056bda30bb571911).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14322);
      ((Control) this.c1f709ff5165e5433056bda30bb571911).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25582);
      ((RadButtonBase) this.c1f709ff5165e5433056bda30bb571911).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14326));
      ((RadButtonBase) this.c1f709ff5165e5433056bda30bb571911).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14330));
      ((RadControl) this.c1f709ff5165e5433056bda30bb571911).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c1f709ff5165e5433056bda30bb571911).Click += new EventHandler(this.c6732bfb0119127fad590752ecfe2efa3);
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14334);
      this.c9c662a4a0b9d44555b1f70db28046f61.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14338));
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14342) != 0;
      ((RadButtonBase) this.c9c662a4a0b9d44555b1f70db28046f61).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27756))));
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14346), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14350));
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27789);
      ((RadControl) this.c9c662a4a0b9d44555b1f70db28046f61).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14354)));
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14358), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14362));
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14366);
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25556);
      ((RadButtonBase) this.c9c662a4a0b9d44555b1f70db28046f61).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14370));
      ((RadButtonBase) this.c9c662a4a0b9d44555b1f70db28046f61).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14374));
      ((RadControl) this.c9c662a4a0b9d44555b1f70db28046f61).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c9c662a4a0b9d44555b1f70db28046f61).Click += new EventHandler(this.c68fa9f7ed23f21a338b0a8c32e6b2db1);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14378);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14382) != 0;
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c6c17c59699d09a6deff3affeead81921);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c9e453c2e79f4fc55124ccb1fd3603902);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c39e3350d94cbb712a33276b179006506);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c38925728235576f0c42cd968bde792d6);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c05e1ef1d0f2e5250a57c757370b74d83);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cba34b2a0111f6e5bc303375f968bc295);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cfa8badb30bc978147487352167d51546);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cee9946355c6a614ff90b875d32801e38);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c743d2a65362475553a562cf35b254c43);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c3a32d8bd5fe0b6b703d373c8ec023149);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c207af470f351635895849de23ece3abc);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.ced6aa7f9911c4707f69ec112a4e51672);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c489dec79b6c4a36ad71b2dd683ba4003);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.c0bc74edb9773f357b639b398786841b3);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.cdf03a2ca811ef49688b58b7e317a430a);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Controls.Add((Control) this.ce940872bf2d542451e120044788d9340);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14386);
      this.c0b6ff62997904dd44189c4cb17f2ab15.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27810));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14390), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14394));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14902);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14398), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14402));
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14406);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27810);
      ((RadControl) this.c0b6ff62997904dd44189c4cb17f2ab15).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c6c17c59699d09a6deff3affeead81921).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14410), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14414));
      ((Control) this.c6c17c59699d09a6deff3affeead81921).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27839);
      ((Control) this.c6c17c59699d09a6deff3affeead81921).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14418), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14422));
      ((Control) this.c6c17c59699d09a6deff3affeead81921).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14426);
      ((Control) this.c6c17c59699d09a6deff3affeead81921).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c6c17c59699d09a6deff3affeead81921).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14430), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14434));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13621);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14438), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14442));
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14446);
      ((Control) this.c9e453c2e79f4fc55124ccb1fd3603902).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27864);
      ((RadControl) this.c9e453c2e79f4fc55124ccb1fd3603902).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c39e3350d94cbb712a33276b179006506.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14450);
      this.c39e3350d94cbb712a33276b179006506.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14454) != 0;
      this.c39e3350d94cbb712a33276b179006506.Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14458) != 0;
      this.c39e3350d94cbb712a33276b179006506.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14462), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14466));
      this.c39e3350d94cbb712a33276b179006506.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27881);
      this.c39e3350d94cbb712a33276b179006506.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14470), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14474));
      this.c39e3350d94cbb712a33276b179006506.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14478);
      this.c39e3350d94cbb712a33276b179006506.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27914);
      this.c39e3350d94cbb712a33276b179006506.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14482) != 0;
      this.c39e3350d94cbb712a33276b179006506.Click += new EventHandler(this.ca57b7cb89c01c4290728107c653aab2d);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14486), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14490));
      ((Control) this.c38925728235576f0c42cd968bde792d6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14533);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14494), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14498));
      ((Control) this.c38925728235576f0c42cd968bde792d6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14502);
      ((Control) this.c38925728235576f0c42cd968bde792d6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27949);
      ((RadControl) this.c38925728235576f0c42cd968bde792d6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c05e1ef1d0f2e5250a57c757370b74d83).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14506), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14510));
      ((Control) this.c05e1ef1d0f2e5250a57c757370b74d83).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27968);
      ((Control) this.c05e1ef1d0f2e5250a57c757370b74d83).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14514), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14518));
      ((Control) this.c05e1ef1d0f2e5250a57c757370b74d83).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14522);
      ((Control) this.c05e1ef1d0f2e5250a57c757370b74d83).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c05e1ef1d0f2e5250a57c757370b74d83).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14526), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14530));
      ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27989);
      ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14534), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14538));
      ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14542);
      ((Control) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14546), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14550));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13819);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14554), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14558));
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14562);
      ((Control) this.cba34b2a0111f6e5bc303375f968bc295).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28014);
      ((RadControl) this.cba34b2a0111f6e5bc303375f968bc295).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cfa8badb30bc978147487352167d51546).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14566), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14570));
      ((Control) this.cfa8badb30bc978147487352167d51546).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28037);
      ((Control) this.cfa8badb30bc978147487352167d51546).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14574), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14578));
      ((Control) this.cfa8badb30bc978147487352167d51546).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14582);
      ((Control) this.cfa8badb30bc978147487352167d51546).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.cfa8badb30bc978147487352167d51546).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14586), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14590));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12323);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14594), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14598));
      ((Control) this.cee9946355c6a614ff90b875d32801e38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14602);
      ((Control) this.cee9946355c6a614ff90b875d32801e38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28058);
      ((RadControl) this.cee9946355c6a614ff90b875d32801e38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c743d2a65362475553a562cf35b254c43).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14606), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14610));
      ((Control) this.c743d2a65362475553a562cf35b254c43).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28079);
      ((Control) this.c743d2a65362475553a562cf35b254c43).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14614), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14618));
      ((Control) this.c743d2a65362475553a562cf35b254c43).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14622);
      ((Control) this.c743d2a65362475553a562cf35b254c43).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c743d2a65362475553a562cf35b254c43).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c3a32d8bd5fe0b6b703d373c8ec023149).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14626), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14630));
      ((Control) this.c3a32d8bd5fe0b6b703d373c8ec023149).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28110);
      ((Control) this.c3a32d8bd5fe0b6b703d373c8ec023149).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14634), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14638));
      ((Control) this.c3a32d8bd5fe0b6b703d373c8ec023149).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14642);
      ((Control) this.c3a32d8bd5fe0b6b703d373c8ec023149).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28119);
      ((RadControl) this.c3a32d8bd5fe0b6b703d373c8ec023149).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c207af470f351635895849de23ece3abc).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14646), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14650));
      ((Control) this.c207af470f351635895849de23ece3abc).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28150);
      ((Control) this.c207af470f351635895849de23ece3abc).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14654), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14658));
      ((Control) this.c207af470f351635895849de23ece3abc).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14662);
      ((Control) this.c207af470f351635895849de23ece3abc).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c207af470f351635895849de23ece3abc).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14666), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14670));
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14927);
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14674), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14678));
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14682);
      ((Control) this.ced6aa7f9911c4707f69ec112a4e51672).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28177);
      ((RadControl) this.ced6aa7f9911c4707f69ec112a4e51672).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c489dec79b6c4a36ad71b2dd683ba4003).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14686), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14690));
      ((Control) this.c489dec79b6c4a36ad71b2dd683ba4003).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28202);
      ((Control) this.c489dec79b6c4a36ad71b2dd683ba4003).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14694), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14698));
      ((Control) this.c489dec79b6c4a36ad71b2dd683ba4003).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14702);
      ((Control) this.c489dec79b6c4a36ad71b2dd683ba4003).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c489dec79b6c4a36ad71b2dd683ba4003).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14706), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14710));
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14769);
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14714), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14718));
      ((Control) this.c0bc74edb9773f357b639b398786841b3).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14722);
      ((Control) this.c0bc74edb9773f357b639b398786841b3).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28229);
      ((RadControl) this.c0bc74edb9773f357b639b398786841b3).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cdf03a2ca811ef49688b58b7e317a430a).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14726), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14730));
      ((Control) this.cdf03a2ca811ef49688b58b7e317a430a).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28256);
      ((Control) this.cdf03a2ca811ef49688b58b7e317a430a).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14734), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14738));
      ((Control) this.cdf03a2ca811ef49688b58b7e317a430a).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14742);
      ((Control) this.cdf03a2ca811ef49688b58b7e317a430a).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.cdf03a2ca811ef49688b58b7e317a430a).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ce940872bf2d542451e120044788d9340).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14746), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14750));
      ((Control) this.ce940872bf2d542451e120044788d9340).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10090);
      ((Control) this.ce940872bf2d542451e120044788d9340).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14754), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14758));
      ((Control) this.ce940872bf2d542451e120044788d9340).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14762);
      ((Control) this.ce940872bf2d542451e120044788d9340).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28279);
      ((RadControl) this.ce940872bf2d542451e120044788d9340).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c6c840f966d621484314eb45e43e34565).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14766);
      this.c6c840f966d621484314eb45e43e34565.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14770));
      ((Control) this.c6c840f966d621484314eb45e43e34565).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14774) != 0;
      ((RadButtonBase) this.c6c840f966d621484314eb45e43e34565).set_Image((Image) c27603360ccc8374975348defb9eee9fc.icnPlay);
      ((Control) this.c6c840f966d621484314eb45e43e34565).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14778), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14782));
      ((Control) this.c6c840f966d621484314eb45e43e34565).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28302);
      ((RadControl) this.c6c840f966d621484314eb45e43e34565).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14786)));
      ((Control) this.c6c840f966d621484314eb45e43e34565).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14790), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14794));
      ((Control) this.c6c840f966d621484314eb45e43e34565).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14798);
      ((Control) this.c6c840f966d621484314eb45e43e34565).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28317);
      ((RadButtonBase) this.c6c840f966d621484314eb45e43e34565).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14802));
      ((RadButtonBase) this.c6c840f966d621484314eb45e43e34565).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14806));
      ((RadControl) this.c6c840f966d621484314eb45e43e34565).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c6c840f966d621484314eb45e43e34565).Click += new EventHandler(this.c78734060d236c637def3f7446ea85000);
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14810) != 0;
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14814);
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(14818));
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14822), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14826));
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28326);
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14830), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14834));
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14838);
      ((Control) this.c738f1dd7afbbfdc20629834298bed929).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28343);
      ((RadControl) this.c738f1dd7afbbfdc20629834298bed929).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c738f1dd7afbbfdc20629834298bed929.set_UseMnemonic(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14842) != 0);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14846);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.c38668e2d3dc450be2fe10e8cdead5a82);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Controls.Add((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14850);
      this.cd21917de552da0d5fa4c6079cd71111f.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28348));
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14854), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14858));
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13478);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14862), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14866));
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14870);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28348);
      ((RadControl) this.cd21917de552da0d5fa4c6079cd71111f).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14874), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14878));
      ((Control) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28373);
      ((Control) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14882), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14886));
      ((Control) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14890);
      ((Control) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27379);
      ((RadControl) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c38668e2d3dc450be2fe10e8cdead5a82).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14894);
      ((Control) this.c38668e2d3dc450be2fe10e8cdead5a82).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14898), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14902));
      ((Control) this.c38668e2d3dc450be2fe10e8cdead5a82).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28394);
      this.c38668e2d3dc450be2fe10e8cdead5a82.set_ShowProgressIndicators(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14906) != 0);
      ((Control) this.c38668e2d3dc450be2fe10e8cdead5a82).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14910), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14914));
      ((Control) this.c38668e2d3dc450be2fe10e8cdead5a82).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14918);
      ((Control) this.c38668e2d3dc450be2fe10e8cdead5a82).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7393);
      ((RadControl) this.c38668e2d3dc450be2fe10e8cdead5a82).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14922);
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14926), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14930));
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7447);
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14934), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14938));
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14942);
      ((Control) this.ca5a2b6669f9034e5fc384b9781cd6dd6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28407);
      ((RadControl) this.ca5a2b6669f9034e5fc384b9781cd6dd6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14946);
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).Controls.Add((Control) this.c5539dab8a40e8d2e2a7b970e134631c8);
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).Controls.Add((Control) this.c50c3a23f9473947fa39e14b6b066f539);
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14950);
      this.c4f28cce9069ce7d56aa80dce66bd91fc.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28444));
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14954), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14958));
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28469);
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14962), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14966));
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14970);
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28444);
      ((RadControl) this.c4f28cce9069ce7d56aa80dce66bd91fc).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14974), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14978));
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7505);
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14982), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14986));
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14990);
      ((Control) this.c5539dab8a40e8d2e2a7b970e134631c8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27379);
      ((RadControl) this.c5539dab8a40e8d2e2a7b970e134631c8).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c50c3a23f9473947fa39e14b6b066f539).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14994);
      ((Control) this.c50c3a23f9473947fa39e14b6b066f539).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(14998), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15002));
      ((Control) this.c50c3a23f9473947fa39e14b6b066f539).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28506);
      this.c50c3a23f9473947fa39e14b6b066f539.set_ShowProgressIndicators(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15006) != 0);
      ((Control) this.c50c3a23f9473947fa39e14b6b066f539).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15010), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15014));
      ((Control) this.c50c3a23f9473947fa39e14b6b066f539).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15018);
      ((Control) this.c50c3a23f9473947fa39e14b6b066f539).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7393);
      ((RadControl) this.c50c3a23f9473947fa39e14b6b066f539).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.cb5983a9ef6bb031c7f34108a205a5729.set_ActiveWindow((DockWindow) this.cc1bf6cfe06c7e943de81a144b94d908c);
      ((RadControl) this.cb5983a9ef6bb031c7f34108a205a5729).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15022) != 0);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Controls.Add((Control) this.c453acc1433bd9ed8673278dbdd4bee00);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Controls.Add((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Controls.Add((Control) this.c91e9024abe6202a1b65e9677c8b82412);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15026);
      ((RadSplitContainer) this.cb5983a9ef6bb031c7f34108a205a5729).set_IsCleanUpTarget(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15030) != 0);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15034), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15038));
      this.cb5983a9ef6bb031c7f34108a205a5729.set_MainDocumentContainer(this.c6f51d70787b53494b9f2a90f93e5091c);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28543);
      ((RadSplitContainer) this.cb5983a9ef6bb031c7f34108a205a5729).set_Orientation((Orientation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15042));
      autoHideGroup1.get_Windows().Add((DockWindow) this.c53cbb17a05b0cbad7d563b1e9b75cd53);
      autoHideGroup2.get_Windows().Add((DockWindow) this.c8c4139dc5bdf8baad6014fa6ae28608e);
      this.cb5983a9ef6bb031c7f34108a205a5729.get_SerializableAutoHideContainer().get_RightAutoHideGroups().Add(autoHideGroup1);
      this.cb5983a9ef6bb031c7f34108a205a5729.get_SerializableAutoHideContainer().get_RightAutoHideGroups().Add(autoHideGroup2);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15046), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15050));
      ((RadSplitContainer) this.cb5983a9ef6bb031c7f34108a205a5729).set_SplitterWidth(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15054));
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15058);
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15062) != 0;
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28560);
      ((RadControl) this.cb5983a9ef6bb031c7f34108a205a5729).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.cc1bf6cfe06c7e943de81a144b94d908c.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Controls.Add((Control) this.ceb095b069074eddeeb1ad92edcc4ec95);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Controls.Add((Control) this.c101d57e697d17803583217bbb889b590);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Controls.Add((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Controls.Add((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Controls.Add((Control) this.c0ebc97b073a7d0dba554313d3f62139d);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Controls.Add((Control) this.c0b8c323aae75c040334498c5efcb96f4);
      ((DockWindow) this.cc1bf6cfe06c7e943de81a144b94d908c).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15066));
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(15070));
      ((TabPanel) this.cc1bf6cfe06c7e943de81a144b94d908c).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15074), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15078)));
      ((DockWindow) this.cc1bf6cfe06c7e943de81a144b94d908c).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26413));
      ((DockWindow) this.cc1bf6cfe06c7e943de81a144b94d908c).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15082));
      ((TabPanel) this.cc1bf6cfe06c7e943de81a144b94d908c).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15086), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15090)));
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26430);
      ((DockWindow) this.cc1bf6cfe06c7e943de81a144b94d908c).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15094));
      ((Control) this.ceb095b069074eddeeb1ad92edcc4ec95).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15098);
      ((Control) this.ceb095b069074eddeeb1ad92edcc4ec95).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15102), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15106));
      ((Control) this.ceb095b069074eddeeb1ad92edcc4ec95).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28577);
      ((Control) this.ceb095b069074eddeeb1ad92edcc4ec95).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15110), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15114));
      ((Control) this.ceb095b069074eddeeb1ad92edcc4ec95).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15118);
      ((Control) this.ceb095b069074eddeeb1ad92edcc4ec95).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28600);
      ((RadControl) this.ceb095b069074eddeeb1ad92edcc4ec95).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ceb095b069074eddeeb1ad92edcc4ec95).Click += new EventHandler(this.cb7a699612516f8f5554c5ce6e3c3e29c);
      ((Control) this.c101d57e697d17803583217bbb889b590).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15122);
      ((Control) this.c101d57e697d17803583217bbb889b590).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15126), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15130));
      ((Control) this.c101d57e697d17803583217bbb889b590).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28625);
      ((Control) this.c101d57e697d17803583217bbb889b590).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15134), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15138));
      ((Control) this.c101d57e697d17803583217bbb889b590).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15142);
      ((Control) this.c101d57e697d17803583217bbb889b590).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28660);
      ((RadControl) this.c101d57e697d17803583217bbb889b590).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c101d57e697d17803583217bbb889b590).Click += new EventHandler(this.c06223b0ff78e229a36421fbcd064759e);
      ((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15146);
      ((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15150), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15154));
      ((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28749);
      ((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15158), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15162));
      ((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15166);
      ((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27591);
      ((RadControl) this.ce1a2609d728bf5b02ebcce5d0d03abac).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ce1a2609d728bf5b02ebcce5d0d03abac).Click += new EventHandler(this.ccae678647ec6ce2724f22ff3c88365db);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15170);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Controls.Add((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Controls.Add((Control) this.cd036f2b2868b103e71bd7b4fbe25a603);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Controls.Add((Control) this.c3768da1c9e17b9980d03acca3e5a19a9);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15174);
      this.ccc252ce44a8e5cefbd8cd949ece215e5.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935));
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15178), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15182));
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28780);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15186), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15190));
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15194);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935);
      ((RadControl) this.ccc252ce44a8e5cefbd8cd949ece215e5).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15198);
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15202), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15206));
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28807);
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15210), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15214));
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15218);
      ((Control) this.c14d5ba9c8d3dcbc17433b50217356b5a).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26730);
      ((RadControl) this.c14d5ba9c8d3dcbc17433b50217356b5a).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15222);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15226), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15230));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7428);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15234), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15238));
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15242);
      ((Control) this.cd036f2b2868b103e71bd7b4fbe25a603).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28832);
      ((RadControl) this.cd036f2b2868b103e71bd7b4fbe25a603).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15246);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15250), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15254));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7473);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15258), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15262));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15266);
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28863);
      ((RadControl) this.c3768da1c9e17b9980d03acca3e5a19a9).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c3768da1c9e17b9980d03acca3e5a19a9).Click += new EventHandler(this.cfa697369a444f380ae43cb2510ff83cc);
      this.c0ebc97b073a7d0dba554313d3f62139d.set_AllowColumnReorder(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15270) != 0);
      this.c0ebc97b073a7d0dba554313d3f62139d.set_AllowColumnResize(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15274) != 0);
      this.c0ebc97b073a7d0dba554313d3f62139d.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15278) != 0);
      this.c0ebc97b073a7d0dba554313d3f62139d.set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15282) != 0);
      ((Control) this.c0ebc97b073a7d0dba554313d3f62139d).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15286);
      ((Control) this.c0ebc97b073a7d0dba554313d3f62139d).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7400), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(15290));
      ((Control) this.c0ebc97b073a7d0dba554313d3f62139d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15294), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15298));
      ((Control) this.c0ebc97b073a7d0dba554313d3f62139d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28874);
      ((Control) this.c0ebc97b073a7d0dba554313d3f62139d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15302), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15306));
      ((Control) this.c0ebc97b073a7d0dba554313d3f62139d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15310);
      ((RadControl) this.c0ebc97b073a7d0dba554313d3f62139d).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      this.c0ebc97b073a7d0dba554313d3f62139d.add_ItemMouseDoubleClick(new ListViewItemEventHandler((object) this, __methodptr(c0926fcb31053ec6082be2553bc552bf8)));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15314);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15318), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15322));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(14336);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15326), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15330));
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15334);
      ((Control) this.c0b8c323aae75c040334498c5efcb96f4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28889);
      ((RadControl) this.c0b8c323aae75c040334498c5efcb96f4).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((TabStripPanel) this.c453acc1433bd9ed8673278dbdd4bee00).set_CanUpdateChildIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15338) != 0);
      this.c453acc1433bd9ed8673278dbdd4bee00.set_CaptionVisible(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15342) != 0);
      ((RadControl) this.c453acc1433bd9ed8673278dbdd4bee00).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15346) != 0);
      ((Control) this.c453acc1433bd9ed8673278dbdd4bee00).Controls.Add((Control) this.c3ec3e29a74c0f512f2935f1207d1a895);
      ((TabStripPanel) this.c453acc1433bd9ed8673278dbdd4bee00).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15350), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15354)));
      ((Control) this.c453acc1433bd9ed8673278dbdd4bee00).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28958);
      ((RadElement) ((RadControl) this.c453acc1433bd9ed8673278dbdd4bee00).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15358), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15362)));
      ((TabStripPanel) this.c453acc1433bd9ed8673278dbdd4bee00).set_SelectedIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15366));
      ((RadControl) this.c453acc1433bd9ed8673278dbdd4bee00).set_ShowItemToolTips(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15370) != 0);
      ((TabStripPanel) this.c453acc1433bd9ed8673278dbdd4bee00).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15374), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15378)));
      ((SplitPanel) this.c453acc1433bd9ed8673278dbdd4bee00).get_SizeInfo().set_AbsoluteSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15382), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15386)));
      ((SplitPanel) this.c453acc1433bd9ed8673278dbdd4bee00).get_SizeInfo().set_SplitterCorrection(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15390), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15394)));
      ((Control) this.c453acc1433bd9ed8673278dbdd4bee00).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15398);
      ((Control) this.c453acc1433bd9ed8673278dbdd4bee00).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15402) != 0;
      ((RadControl) this.c453acc1433bd9ed8673278dbdd4bee00).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c3ec3e29a74c0f512f2935f1207d1a895.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c3ec3e29a74c0f512f2935f1207d1a895).Controls.Add((Control) this.c0c0e712d5ca94f2910e3ec339b2e600f);
      ((DockWindow) this.c3ec3e29a74c0f512f2935f1207d1a895).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15406));
      ((Control) this.c3ec3e29a74c0f512f2935f1207d1a895).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(15410));
      ((TabPanel) this.c3ec3e29a74c0f512f2935f1207d1a895).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15414), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15418)));
      ((DockWindow) this.c3ec3e29a74c0f512f2935f1207d1a895).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28985));
      ((DockWindow) this.c3ec3e29a74c0f512f2935f1207d1a895).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15422));
      ((TabPanel) this.c3ec3e29a74c0f512f2935f1207d1a895).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15426), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15430)));
      ((Control) this.c3ec3e29a74c0f512f2935f1207d1a895).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28985);
      ((DockWindow) this.c3ec3e29a74c0f512f2935f1207d1a895).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15434));
      this.c0c0e712d5ca94f2910e3ec339b2e600f.Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15438);
      this.c0c0e712d5ca94f2910e3ec339b2e600f.Image = (Image) c27603360ccc8374975348defb9eee9fc.banner;
      this.c0c0e712d5ca94f2910e3ec339b2e600f.ImageLocation = "";
      this.c0c0e712d5ca94f2910e3ec339b2e600f.ImeMode = (ImeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15442);
      this.c0c0e712d5ca94f2910e3ec339b2e600f.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15446), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15450));
      this.c0c0e712d5ca94f2910e3ec339b2e600f.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29008);
      this.c0c0e712d5ca94f2910e3ec339b2e600f.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15454), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15458));
      this.c0c0e712d5ca94f2910e3ec339b2e600f.SizeMode = (PictureBoxSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15462);
      this.c0c0e712d5ca94f2910e3ec339b2e600f.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15466);
      this.c0c0e712d5ca94f2910e3ec339b2e600f.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15470) != 0;
      ((RadControl) this.cae3beaf3bc9f066d134288b1cc6a2ab6).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15474) != 0);
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).Controls.Add((Control) this.c6f51d70787b53494b9f2a90f93e5091c);
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).Controls.Add((Control) this.c5b062d1e6fbb1c9186310faefca6b2fa);
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).Controls.Add((Control) this.c0185dca1f25fc3c2cc62921a9050d18f);
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).Controls.Add((Control) this.ceb25ec87df1d957dbabc08d3338713dd);
      this.cae3beaf3bc9f066d134288b1cc6a2ab6.set_IsCleanUpTarget(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15478) != 0);
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15482), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15486));
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29025);
      ((RadControl) this.cae3beaf3bc9f066d134288b1cc6a2ab6).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15490)));
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15494), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15498));
      ((SplitPanel) this.cae3beaf3bc9f066d134288b1cc6a2ab6).get_SizeInfo().set_AbsoluteSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15502), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15506)));
      ((SplitPanel) this.cae3beaf3bc9f066d134288b1cc6a2ab6).get_SizeInfo().set_SplitterCorrection(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15510), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15514)));
      this.cae3beaf3bc9f066d134288b1cc6a2ab6.set_SplitterWidth(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15518));
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15522);
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15526) != 0;
      ((RadControl) this.cae3beaf3bc9f066d134288b1cc6a2ab6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((RadControl) this.c6f51d70787b53494b9f2a90f93e5091c).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15530) != 0);
      ((Control) this.c6f51d70787b53494b9f2a90f93e5091c).Controls.Add((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331);
      ((Control) this.c6f51d70787b53494b9f2a90f93e5091c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29062);
      ((SplitPanel) this.c6f51d70787b53494b9f2a90f93e5091c).get_SizeInfo().set_AbsoluteSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15534), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15538)));
      ((SplitPanel) this.c6f51d70787b53494b9f2a90f93e5091c).get_SizeInfo().set_SizeMode((SplitPanelSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15542));
      ((SplitPanel) this.c6f51d70787b53494b9f2a90f93e5091c).get_SizeInfo().set_SplitterCorrection(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15546), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15550)));
      ((RadSplitContainer) this.c6f51d70787b53494b9f2a90f93e5091c).set_SplitterWidth(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15554));
      ((RadControl) this.c6f51d70787b53494b9f2a90f93e5091c).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((TabStripPanel) this.cfda0f7e74c13d6b7f59b7c808dd15331).set_CanUpdateChildIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15558) != 0);
      ((RadControl) this.cfda0f7e74c13d6b7f59b7c808dd15331).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15562) != 0);
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).Controls.Add((Control) this.c44e1112bbc33afd80a87709982a149c4);
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).Controls.Add((Control) this.c89ff289eea7f33d04edb7f11d666c144);
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).Controls.Add((Control) this.c2f75881f4e3a569756004ecd1f3c8da3);
      ((TabStripPanel) this.cfda0f7e74c13d6b7f59b7c808dd15331).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15566), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15570)));
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29099);
      ((RadElement) ((RadControl) this.cfda0f7e74c13d6b7f59b7c808dd15331).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15574), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15578)));
      ((TabStripPanel) this.cfda0f7e74c13d6b7f59b7c808dd15331).set_SelectedIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15582));
      ((TabStripPanel) this.cfda0f7e74c13d6b7f59b7c808dd15331).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15586), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15590)));
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15594);
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15598) != 0;
      ((RadControl) this.cfda0f7e74c13d6b7f59b7c808dd15331).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((ScrollableControl) this.c44e1112bbc33afd80a87709982a149c4).AutoScroll = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15602) != 0;
      this.c44e1112bbc33afd80a87709982a149c4.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c44e1112bbc33afd80a87709982a149c4).Controls.Add((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9);
      ((DockWindow) this.c44e1112bbc33afd80a87709982a149c4).set_DefaultFloatingSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15606), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15610)));
      ((DockWindow) this.c44e1112bbc33afd80a87709982a149c4).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15614));
      ((Control) this.c44e1112bbc33afd80a87709982a149c4).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(15618));
      ((TabPanel) this.c44e1112bbc33afd80a87709982a149c4).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15622), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15626)));
      ((DockWindow) this.c44e1112bbc33afd80a87709982a149c4).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29134));
      ((DockWindow) this.c44e1112bbc33afd80a87709982a149c4).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15630));
      ((TabPanel) this.c44e1112bbc33afd80a87709982a149c4).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15634), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15638)));
      ((Control) this.c44e1112bbc33afd80a87709982a149c4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29157);
      ((DockWindow) this.c44e1112bbc33afd80a87709982a149c4).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15642));
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15646);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15650) != 0;
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.c68b8f2723032c53a16a489755afa9f3d);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.cb09f0c811e9c104f30d9bdb57f5e4472);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.ce9d74c4a67920ea005ae0e9c3e550195);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.c6e10857a44dfe29229689f6f14eb8736);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.cc823a5ecc3a0639558b6b92439679149);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.ced13435d37c83d5695f389153255d7aa);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.c80abb9b1c6ac93efa1bec9b52c6e0411);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.c8af15fc87ff7fad3b7d70b37794c0516);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.c659877bdbb8d30820909c7b85d4f6330);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.cef99ac773757daa1842ee58c7914a0cc);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Controls.Add((Control) this.c544236c90282c9157c1c7d7d9ff1369c);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15654);
      this.c39e7e88f29f2018d9aa6c123a5da05b9.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29172));
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15658), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15662));
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29183);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15666), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15670));
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15674);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29172);
      ((RadControl) this.c39e7e88f29f2018d9aa6c123a5da05b9).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c68b8f2723032c53a16a489755afa9f3d).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15678);
      ((Control) this.c68b8f2723032c53a16a489755afa9f3d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15682), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15686));
      ((Control) this.c68b8f2723032c53a16a489755afa9f3d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29208);
      ((Control) this.c68b8f2723032c53a16a489755afa9f3d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15690), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15694));
      ((Control) this.c68b8f2723032c53a16a489755afa9f3d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15698);
      ((Control) this.c68b8f2723032c53a16a489755afa9f3d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29237);
      // ISSUE: method pointer
      ((RadToggleButton) this.c68b8f2723032c53a16a489755afa9f3d).add_ToggleStateChanged(new StateChangedEventHandler((object) this, __methodptr(ccf9c4063095a326f0e9a94c33d08bf8e)));
      this.cb09f0c811e9c104f30d9bdb57f5e4472.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15702);
      this.cb09f0c811e9c104f30d9bdb57f5e4472.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15706) != 0;
      this.cb09f0c811e9c104f30d9bdb57f5e4472.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15710), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15714));
      this.cb09f0c811e9c104f30d9bdb57f5e4472.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29262);
      this.cb09f0c811e9c104f30d9bdb57f5e4472.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15718), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15722));
      this.cb09f0c811e9c104f30d9bdb57f5e4472.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15726);
      this.cb09f0c811e9c104f30d9bdb57f5e4472.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29293);
      this.cb09f0c811e9c104f30d9bdb57f5e4472.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15730) != 0;
      this.cb09f0c811e9c104f30d9bdb57f5e4472.CheckedChanged += new EventHandler(this.c71d6bd36bb677ebf43d09757e4a0a479);
      this.ce9d74c4a67920ea005ae0e9c3e550195.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15734);
      this.ce9d74c4a67920ea005ae0e9c3e550195.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15738) != 0;
      this.ce9d74c4a67920ea005ae0e9c3e550195.Checked = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15742) != 0;
      this.ce9d74c4a67920ea005ae0e9c3e550195.CheckState = (CheckState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15746);
      this.ce9d74c4a67920ea005ae0e9c3e550195.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15750), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15754));
      this.ce9d74c4a67920ea005ae0e9c3e550195.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29322);
      this.ce9d74c4a67920ea005ae0e9c3e550195.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15758), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15762));
      this.ce9d74c4a67920ea005ae0e9c3e550195.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15766);
      this.ce9d74c4a67920ea005ae0e9c3e550195.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29351);
      this.ce9d74c4a67920ea005ae0e9c3e550195.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15770) != 0;
      this.ce9d74c4a67920ea005ae0e9c3e550195.CheckedChanged += new EventHandler(this.cad2910925cb864d1ece1a497da80194c);
      this.c6e10857a44dfe29229689f6f14eb8736.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15774);
      this.c6e10857a44dfe29229689f6f14eb8736.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15778) != 0;
      this.c6e10857a44dfe29229689f6f14eb8736.Checked = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15782) != 0;
      this.c6e10857a44dfe29229689f6f14eb8736.CheckState = (CheckState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15786);
      this.c6e10857a44dfe29229689f6f14eb8736.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15790), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15794));
      this.c6e10857a44dfe29229689f6f14eb8736.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29370);
      this.c6e10857a44dfe29229689f6f14eb8736.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15798), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15802));
      this.c6e10857a44dfe29229689f6f14eb8736.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15806);
      this.c6e10857a44dfe29229689f6f14eb8736.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29395);
      this.c6e10857a44dfe29229689f6f14eb8736.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15810) != 0;
      this.c6e10857a44dfe29229689f6f14eb8736.CheckedChanged += new EventHandler(this.c31d6db800cdafd2057d06118b91113b8);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15814);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Controls.Add((Control) this.c3aec1f92fc33a551b592c8b2a7adf9ec);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Controls.Add((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Controls.Add((Control) this.cef22dcb29373b4f99e89eb28166e5dc2);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15818);
      this.cc823a5ecc3a0639558b6b92439679149.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935));
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15822), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15826));
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29418);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15830), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15834));
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15838);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935);
      ((RadControl) this.cc823a5ecc3a0639558b6b92439679149).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15842);
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15846), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15850));
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(10499);
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15854), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15858));
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15862);
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28863);
      ((RadControl) this.c414a01a9d1ea6f9447f9d5fee7291bd3).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c414a01a9d1ea6f9447f9d5fee7291bd3).Click += new EventHandler(this.ce6966d95da94f2c9113bf75a09b503cf);
      this.c89ff289eea7f33d04edb7f11d666c144.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c89ff289eea7f33d04edb7f11d666c144).Controls.Add((Control) this.c422900b304a63407dfa05f2f233b004e);
      ((Control) this.c89ff289eea7f33d04edb7f11d666c144).Controls.Add((Control) this.cbe00b03ee2347f9756848babd446e36c);
      ((DockWindow) this.c89ff289eea7f33d04edb7f11d666c144).set_DefaultFloatingSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15866), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15870)));
      ((DockWindow) this.c89ff289eea7f33d04edb7f11d666c144).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15874));
      ((Control) this.c89ff289eea7f33d04edb7f11d666c144).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(15878));
      ((TabPanel) this.c89ff289eea7f33d04edb7f11d666c144).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15882), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15886)));
      ((DockWindow) this.c89ff289eea7f33d04edb7f11d666c144).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29443));
      ((DockWindow) this.c89ff289eea7f33d04edb7f11d666c144).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15890));
      ((TabPanel) this.c89ff289eea7f33d04edb7f11d666c144).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15894), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15898)));
      ((Control) this.c89ff289eea7f33d04edb7f11d666c144).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29466);
      ((DockWindow) this.c89ff289eea7f33d04edb7f11d666c144).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15902));
      ((Control) this.c422900b304a63407dfa05f2f233b004e).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15906);
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Controls.Add((Control) this.ca9c68e79493f9e09d605914c6cd6edd5);
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Controls.Add((Control) this.c51175a4a3b6b11c0eee765ad7effd076);
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Controls.Add((Control) this.cf152d3e6147dc4e0112582d0f6097ce3);
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15910);
      this.c422900b304a63407dfa05f2f233b004e.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29481));
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15914), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15918));
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29639);
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15922), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15926));
      ((Control) this.c422900b304a63407dfa05f2f233b004e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15930);
      ((Control) this.c422900b304a63407dfa05f2f233b004e).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29481);
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).set_AllowRemove(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15934) != 0);
      ((Control) this.ca9c68e79493f9e09d605914c6cd6edd5).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15938);
      ((Control) this.ca9c68e79493f9e09d605914c6cd6edd5).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15942), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15946));
      ((Control) this.ca9c68e79493f9e09d605914c6cd6edd5).Margin = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15950), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15954), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15958), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15962));
      ((Control) this.ca9c68e79493f9e09d605914c6cd6edd5).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29666);
      ((Control) this.ca9c68e79493f9e09d605914c6cd6edd5).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15966), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15970));
      ((Control) this.ca9c68e79493f9e09d605914c6cd6edd5).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15974);
      ((Control) this.ca9c68e79493f9e09d605914c6cd6edd5).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7221);
      ((RadControl) this.ca9c68e79493f9e09d605914c6cd6edd5).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      // ISSUE: method pointer
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).add_ItemMouseUp(new ListViewItemMouseEventHandler((object) this, __methodptr(ca0665eaf182937ae3fc1ce08f55979f7)));
      // ISSUE: method pointer
      ((RadListView) this.ca9c68e79493f9e09d605914c6cd6edd5).add_ItemCheckedChanged(new ListViewItemEventHandler((object) this, __methodptr(cb1cdf7eac43f1c6ca024640a68b13f1a)));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15978);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15982), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15986));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Margin = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15990), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15994), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(15998), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16002));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16429);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16006), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16010));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16014);
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(16452);
      ((RadControl) this.c51175a4a3b6b11c0eee765ad7effd076).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c51175a4a3b6b11c0eee765ad7effd076).Click += new EventHandler(this.c73a91aa5e28f9899f28a0eb26c625fd5);
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16018);
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16022), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16026));
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).Margin = new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16030), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16034), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16038), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16042));
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29691);
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16046), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16050));
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16054);
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29712);
      ((RadControl) this.cf152d3e6147dc4e0112582d0f6097ce3).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cf152d3e6147dc4e0112582d0f6097ce3).Click += new EventHandler(this.c8fcfb9313406612acf3d10f41963833f);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16058);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Controls.Add((Control) this.c4562184f7a172fc18d58e50d7047938d);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Controls.Add((Control) this.cf582d9fa2e47e4f8707ea4db5c09db97);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Controls.Add((Control) this.c290ca0dbd67a1dd201c0b196fec00bc4);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16062);
      this.cbe00b03ee2347f9756848babd446e36c.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29737));
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16066), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16070));
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29752);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16074), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16078));
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16082);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29737);
      this.c4562184f7a172fc18d58e50d7047938d.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16086);
      this.c4562184f7a172fc18d58e50d7047938d.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16090) != 0;
      this.c4562184f7a172fc18d58e50d7047938d.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16094), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16098));
      this.c4562184f7a172fc18d58e50d7047938d.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29779);
      this.c4562184f7a172fc18d58e50d7047938d.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16102), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16106));
      this.c4562184f7a172fc18d58e50d7047938d.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16110);
      this.c4562184f7a172fc18d58e50d7047938d.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29792);
      this.c4562184f7a172fc18d58e50d7047938d.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16114) != 0;
      this.c4562184f7a172fc18d58e50d7047938d.CheckedChanged += new EventHandler(this.c4c90044666ad7a16ad6a190754bfda15);
      this.cf582d9fa2e47e4f8707ea4db5c09db97.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16118);
      this.cf582d9fa2e47e4f8707ea4db5c09db97.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16122) != 0;
      this.cf582d9fa2e47e4f8707ea4db5c09db97.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16126), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16130));
      this.cf582d9fa2e47e4f8707ea4db5c09db97.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29799);
      this.cf582d9fa2e47e4f8707ea4db5c09db97.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16134), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16138));
      this.cf582d9fa2e47e4f8707ea4db5c09db97.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16142);
      this.cf582d9fa2e47e4f8707ea4db5c09db97.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1345);
      this.cf582d9fa2e47e4f8707ea4db5c09db97.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16146) != 0;
      this.cf582d9fa2e47e4f8707ea4db5c09db97.CheckedChanged += new EventHandler(this.cebd8804c59f3a04ec634d1e48ff28d8b);
      this.c290ca0dbd67a1dd201c0b196fec00bc4.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16150);
      this.c290ca0dbd67a1dd201c0b196fec00bc4.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16154) != 0;
      this.c290ca0dbd67a1dd201c0b196fec00bc4.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16158), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16162));
      this.c290ca0dbd67a1dd201c0b196fec00bc4.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29812);
      this.c290ca0dbd67a1dd201c0b196fec00bc4.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16166), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16170));
      this.c290ca0dbd67a1dd201c0b196fec00bc4.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16174);
      this.c290ca0dbd67a1dd201c0b196fec00bc4.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(1338);
      this.c290ca0dbd67a1dd201c0b196fec00bc4.UseVisualStyleBackColor = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16178) != 0;
      this.c290ca0dbd67a1dd201c0b196fec00bc4.CheckedChanged += new EventHandler(this.c720c4ba238d63954d20328054195c8ed);
      this.c2f75881f4e3a569756004ecd1f3c8da3.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c2f75881f4e3a569756004ecd1f3c8da3).Controls.Add((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2);
      ((Control) this.c2f75881f4e3a569756004ecd1f3c8da3).Controls.Add((Control) this.ca380231837e2eafdb42e81f47a24d226);
      ((DockWindow) this.c2f75881f4e3a569756004ecd1f3c8da3).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16182));
      ((Control) this.c2f75881f4e3a569756004ecd1f3c8da3).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(16186));
      ((TabPanel) this.c2f75881f4e3a569756004ecd1f3c8da3).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16190), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16194)));
      ((DockWindow) this.c2f75881f4e3a569756004ecd1f3c8da3).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29825));
      ((DockWindow) this.c2f75881f4e3a569756004ecd1f3c8da3).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16198));
      ((TabPanel) this.c2f75881f4e3a569756004ecd1f3c8da3).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16202), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16206)));
      ((Control) this.c2f75881f4e3a569756004ecd1f3c8da3).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29848);
      ((DockWindow) this.c2f75881f4e3a569756004ecd1f3c8da3).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16210));
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16214);
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Controls.Add((Control) this.c780e6034938558087f1ea7ad59d1d853);
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Controls.Add((Control) this.c77ab4cca03476e6662d72295ae2a18d0);
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Controls.Add((Control) this.c28cccb4bc1305f639acf2d457aeedad8);
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16218);
      this.c101a585c2bc6dfb0b62b86bd680ce2b2.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11531));
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16222), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16226));
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29883);
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16230), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16234));
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16238);
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11531);
      ((RadControl) this.c101a585c2bc6dfb0b62b86bd680ce2b2).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16242);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Controls.Add((Control) this.c86ce7f867a560282470decd22cec0860);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Controls.Add((Control) this.c22d04ce1034d647a95d30b01a54768c4);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Controls.Add((Control) this.cfda9a98a11ebdc24a447457307015f17);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Controls.Add((Control) this.c979c76a51f33de27b2440305fd60fd38);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Controls.Add((Control) this.ce55c0c71a3136c1bba91d488db23a660);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Controls.Add((Control) this.cb92ad5a7459656fe7b6fd86ff472b5c5);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16246);
      this.c780e6034938558087f1ea7ad59d1d853.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935));
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16250), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16254));
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29910);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16258), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16262));
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16266);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(15935);
      ((RadControl) this.c780e6034938558087f1ea7ad59d1d853).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c86ce7f867a560282470decd22cec0860).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16270), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16274));
      ((Control) this.c86ce7f867a560282470decd22cec0860).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29937);
      ((Control) this.c86ce7f867a560282470decd22cec0860).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16278), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16282));
      ((Control) this.c86ce7f867a560282470decd22cec0860).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16286);
      ((Control) this.c86ce7f867a560282470decd22cec0860).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c86ce7f867a560282470decd22cec0860).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c22d04ce1034d647a95d30b01a54768c4).ForeColor = Color.Red;
      ((Control) this.c22d04ce1034d647a95d30b01a54768c4).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16290), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16294));
      ((Control) this.c22d04ce1034d647a95d30b01a54768c4).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29966);
      ((Control) this.c22d04ce1034d647a95d30b01a54768c4).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16298), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16302));
      ((Control) this.c22d04ce1034d647a95d30b01a54768c4).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16306);
      ((Control) this.c22d04ce1034d647a95d30b01a54768c4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(29999);
      ((RadControl) this.c22d04ce1034d647a95d30b01a54768c4).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cfda9a98a11ebdc24a447457307015f17).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16310), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16314));
      ((Control) this.cfda9a98a11ebdc24a447457307015f17).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30044);
      ((Control) this.cfda9a98a11ebdc24a447457307015f17).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16318), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16322));
      ((Control) this.cfda9a98a11ebdc24a447457307015f17).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16326);
      ((Control) this.cfda9a98a11ebdc24a447457307015f17).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30065);
      ((RadControl) this.cfda9a98a11ebdc24a447457307015f17).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c979c76a51f33de27b2440305fd60fd38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16330), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16334));
      ((Control) this.c979c76a51f33de27b2440305fd60fd38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30096);
      ((Control) this.c979c76a51f33de27b2440305fd60fd38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16338), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16342));
      ((Control) this.c979c76a51f33de27b2440305fd60fd38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16346);
      ((Control) this.c979c76a51f33de27b2440305fd60fd38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6165);
      ((RadControl) this.c979c76a51f33de27b2440305fd60fd38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ce55c0c71a3136c1bba91d488db23a660).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16350), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16354));
      ((Control) this.ce55c0c71a3136c1bba91d488db23a660).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30127);
      ((Control) this.ce55c0c71a3136c1bba91d488db23a660).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16358), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16362));
      ((Control) this.ce55c0c71a3136c1bba91d488db23a660).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16366);
      ((Control) this.ce55c0c71a3136c1bba91d488db23a660).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30148);
      ((RadControl) this.ce55c0c71a3136c1bba91d488db23a660).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cb92ad5a7459656fe7b6fd86ff472b5c5).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16370), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16374));
      ((Control) this.cb92ad5a7459656fe7b6fd86ff472b5c5).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30179);
      ((Control) this.cb92ad5a7459656fe7b6fd86ff472b5c5).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16378), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16382));
      ((Control) this.cb92ad5a7459656fe7b6fd86ff472b5c5).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16386);
      ((Control) this.cb92ad5a7459656fe7b6fd86ff472b5c5).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30200);
      ((RadControl) this.cb92ad5a7459656fe7b6fd86ff472b5c5).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c77ab4cca03476e6662d72295ae2a18d0).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16390), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16394));
      ((Control) this.c77ab4cca03476e6662d72295ae2a18d0).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30235);
      ((Control) this.c77ab4cca03476e6662d72295ae2a18d0).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16398), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16402));
      ((Control) this.c77ab4cca03476e6662d72295ae2a18d0).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16406);
      ((Control) this.c77ab4cca03476e6662d72295ae2a18d0).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30200);
      ((RadControl) this.c77ab4cca03476e6662d72295ae2a18d0).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16410);
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16414), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16418));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(11346);
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16422), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16426));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16430);
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30256);
      ((RadControl) this.c28cccb4bc1305f639acf2d457aeedad8).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c28cccb4bc1305f639acf2d457aeedad8).Click += new EventHandler(this.ce2ea68eb9c0d4049a372275378d48be5);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16434);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.cded9ed150a9ac47f6949a468fac193a6);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.c340f7ccf001170543c57999fd96d4b38);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.cd8a4426aac26fd0166c7b44e9f731455);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.c4fda90ba27d8ac9ff70115293efc7b38);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.c0770534b75ebeea0c4e695dfdb7677d0);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.c67131d5ebad4559120841e7d6afbf050);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.cadd2602239e2a87754cb1203ec048ce7);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.cf9e2786454699a4c03d6a769f423882e);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.ceb96360e1866456699fd2a748e058db6);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Controls.Add((Control) this.c1b58d84e7b46cb77f175ef1b94421baf);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16438);
      this.ca380231837e2eafdb42e81f47a24d226.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30307));
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16442), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16446));
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30328);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16450), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16454));
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16458);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30307);
      ((RadControl) this.ca380231837e2eafdb42e81f47a24d226).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).ForeColor = Color.Red;
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16462), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16466));
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30355);
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16470), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16474));
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16478);
      ((Control) this.cded9ed150a9ac47f6949a468fac193a6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(25362);
      ((RadControl) this.cded9ed150a9ac47f6949a468fac193a6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c340f7ccf001170543c57999fd96d4b38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16482), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16486));
      ((Control) this.c340f7ccf001170543c57999fd96d4b38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30384);
      ((Control) this.c340f7ccf001170543c57999fd96d4b38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16490), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16494));
      ((Control) this.c340f7ccf001170543c57999fd96d4b38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16498);
      ((Control) this.c340f7ccf001170543c57999fd96d4b38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30405);
      ((RadControl) this.c340f7ccf001170543c57999fd96d4b38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cd8a4426aac26fd0166c7b44e9f731455).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16502);
      ((Control) this.cd8a4426aac26fd0166c7b44e9f731455).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16506), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16510));
      ((Control) this.cd8a4426aac26fd0166c7b44e9f731455).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30434);
      ((Control) this.cd8a4426aac26fd0166c7b44e9f731455).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16514), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16518));
      ((Control) this.cd8a4426aac26fd0166c7b44e9f731455).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16522);
      ((Control) this.cd8a4426aac26fd0166c7b44e9f731455).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(28863);
      ((RadControl) this.cd8a4426aac26fd0166c7b44e9f731455).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cd8a4426aac26fd0166c7b44e9f731455).Click += new EventHandler(this.c27c10f6cd1daa7cac3cf201e3540c2a7);
      ((Control) this.c4fda90ba27d8ac9ff70115293efc7b38).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16526);
      ((Control) this.c4fda90ba27d8ac9ff70115293efc7b38).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16530), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16534));
      ((Control) this.c4fda90ba27d8ac9ff70115293efc7b38).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30461);
      ((Control) this.c4fda90ba27d8ac9ff70115293efc7b38).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16538), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16542));
      ((Control) this.c4fda90ba27d8ac9ff70115293efc7b38).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16546);
      ((Control) this.c4fda90ba27d8ac9ff70115293efc7b38).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(24874);
      ((RadControl) this.c4fda90ba27d8ac9ff70115293efc7b38).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c4fda90ba27d8ac9ff70115293efc7b38).Click += new EventHandler(this.c3dca125ca7d692247db92e4c3f5495c3);
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16550);
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16554), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16558));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16562), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16566));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13503);
      ((RadElement) ((RadControl) this.c0770534b75ebeea0c4e695dfdb7677d0).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16570), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16574)));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16578), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16582));
      ((Control) this.c0770534b75ebeea0c4e695dfdb7677d0).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16586);
      ((RadControl) this.c0770534b75ebeea0c4e695dfdb7677d0).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c67131d5ebad4559120841e7d6afbf050).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16590), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16594));
      ((Control) this.c67131d5ebad4559120841e7d6afbf050).MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16598), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16602));
      ((Control) this.c67131d5ebad4559120841e7d6afbf050).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30484);
      ((RadElement) ((RadControl) this.c67131d5ebad4559120841e7d6afbf050).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16606), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16610)));
      ((Control) this.c67131d5ebad4559120841e7d6afbf050).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16614), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16618));
      ((Control) this.c67131d5ebad4559120841e7d6afbf050).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16622);
      ((RadControl) this.c67131d5ebad4559120841e7d6afbf050).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cadd2602239e2a87754cb1203ec048ce7).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16626);
      ((Control) this.cadd2602239e2a87754cb1203ec048ce7).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16630), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16634));
      ((Control) this.cadd2602239e2a87754cb1203ec048ce7).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30507);
      ((Control) this.cadd2602239e2a87754cb1203ec048ce7).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16638), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16642));
      ((Control) this.cadd2602239e2a87754cb1203ec048ce7).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16646);
      ((Control) this.cadd2602239e2a87754cb1203ec048ce7).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30540);
      ((RadControl) this.cadd2602239e2a87754cb1203ec048ce7).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cf9e2786454699a4c03d6a769f423882e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16650), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16654));
      ((Control) this.cf9e2786454699a4c03d6a769f423882e).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30561);
      ((Control) this.cf9e2786454699a4c03d6a769f423882e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16658), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16662));
      ((Control) this.cf9e2786454699a4c03d6a769f423882e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16666);
      ((Control) this.cf9e2786454699a4c03d6a769f423882e).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30582);
      ((RadControl) this.cf9e2786454699a4c03d6a769f423882e).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ceb96360e1866456699fd2a748e058db6).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16670);
      ((Control) this.ceb96360e1866456699fd2a748e058db6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16674), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16678));
      ((Control) this.ceb96360e1866456699fd2a748e058db6).MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16682), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16686));
      ((Control) this.ceb96360e1866456699fd2a748e058db6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30603);
      ((RadTextBoxBase) this.ceb96360e1866456699fd2a748e058db6).set_NullText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30626));
      ((RadElement) ((RadControl) this.ceb96360e1866456699fd2a748e058db6).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16690), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16694)));
      ((Control) this.ceb96360e1866456699fd2a748e058db6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16698), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16702));
      ((Control) this.ceb96360e1866456699fd2a748e058db6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16706);
      ((RadControl) this.ceb96360e1866456699fd2a748e058db6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c1b58d84e7b46cb77f175ef1b94421baf).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16710), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16714));
      ((Control) this.c1b58d84e7b46cb77f175ef1b94421baf).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30677);
      ((Control) this.c1b58d84e7b46cb77f175ef1b94421baf).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16718), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16722));
      ((Control) this.c1b58d84e7b46cb77f175ef1b94421baf).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16726);
      ((Control) this.c1b58d84e7b46cb77f175ef1b94421baf).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30698);
      ((RadControl) this.c1b58d84e7b46cb77f175ef1b94421baf).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((TabStripPanel) this.c5b062d1e6fbb1c9186310faefca6b2fa).set_CanUpdateChildIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16730) != 0);
      ((Control) this.c5b062d1e6fbb1c9186310faefca6b2fa).Controls.Add((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6);
      ((TabStripPanel) this.c5b062d1e6fbb1c9186310faefca6b2fa).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16734), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16738)));
      ((Control) this.c5b062d1e6fbb1c9186310faefca6b2fa).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30709);
      ((TabStripPanel) this.c5b062d1e6fbb1c9186310faefca6b2fa).set_SelectedIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16742));
      ((TabStripPanel) this.c5b062d1e6fbb1c9186310faefca6b2fa).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16746), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16750)));
      ((SplitPanel) this.c5b062d1e6fbb1c9186310faefca6b2fa).get_SizeInfo().set_AbsoluteSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16754), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16758)));
      ((SplitPanel) this.c5b062d1e6fbb1c9186310faefca6b2fa).get_SizeInfo().set_SplitterCorrection(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16762), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16766)));
      ((Control) this.c5b062d1e6fbb1c9186310faefca6b2fa).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16770);
      ((Control) this.c5b062d1e6fbb1c9186310faefca6b2fa).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16774) != 0;
      ((RadControl) this.c5b062d1e6fbb1c9186310faefca6b2fa).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((ScrollableControl) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).AutoScroll = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16778) != 0;
      this.cf6bb2c04c0ce1a4090efd4990bc2a4d6.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).Controls.Add((Control) this.cbb44104e6cbbb2680035694332b80a01);
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).Controls.Add((Control) this.c0b6ff62997904dd44189c4cb17f2ab15);
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).Controls.Add((Control) this.c8827d4c0d7431a9890c547ec78a2c02c);
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).Controls.Add((Control) this.c738f1dd7afbbfdc20629834298bed929);
      ((DockWindow) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).set_DefaultFloatingSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16782), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16786)));
      ((DockWindow) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16790));
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(16794));
      ((TabPanel) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16798), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16802)));
      ((DockWindow) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30736));
      ((DockWindow) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16806));
      ((TabPanel) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16810), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16814)));
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30761);
      ((DockWindow) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16818));
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16822);
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).Controls.Add((Control) this.c2769778d069bafd899ea27ebc8b3b6f7);
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16826);
      this.cbb44104e6cbbb2680035694332b80a01.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30780));
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16830), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16834));
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30791);
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16838), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16842));
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16846);
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30780);
      ((RadControl) this.cbb44104e6cbbb2680035694332b80a01).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c2769778d069bafd899ea27ebc8b3b6f7.set_ActiveWindow((DockWindow) this.c3f18d02c9bc1b341ea22f160d501e795);
      ((RadControl) this.c2769778d069bafd899ea27ebc8b3b6f7).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16850) != 0);
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).Controls.Add((Control) this.c830db343ebd6db124b1b541a729f89ad);
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16854);
      this.c2769778d069bafd899ea27ebc8b3b6f7.get_DocumentManager().set_ActiveDocumentMenuSortOrder((ActiveDocumentListSortOrder) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16858));
      ((RadSplitContainer) this.c2769778d069bafd899ea27ebc8b3b6f7).set_IsCleanUpTarget(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16862) != 0);
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16866), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16870));
      this.c2769778d069bafd899ea27ebc8b3b6f7.set_MainDocumentContainer(this.c830db343ebd6db124b1b541a729f89ad);
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30816);
      ((RadElement) ((RadControl) this.c2769778d069bafd899ea27ebc8b3b6f7).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16874), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16878)));
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16882), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16886));
      ((RadSplitContainer) this.c2769778d069bafd899ea27ebc8b3b6f7).set_SplitterWidth(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16890));
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16894);
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16898) != 0;
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30833);
      ((RadControl) this.c2769778d069bafd899ea27ebc8b3b6f7).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c3f18d02c9bc1b341ea22f160d501e795.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).Controls.Add((Control) this.c4ffe800d52986b27d66e2886fadad952);
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).Controls.Add((Control) this.c6c840f966d621484314eb45e43e34565);
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).Controls.Add((Control) this.c74ae2563a72edeef646bba38ebdd0ce8);
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).Controls.Add((Control) this.cc5109af75315520586ca50d6cd84c973);
      ((DockWindow) this.c3f18d02c9bc1b341ea22f160d501e795).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16902));
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(16906));
      ((TabPanel) this.c3f18d02c9bc1b341ea22f160d501e795).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16910), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16914)));
      ((DockWindow) this.c3f18d02c9bc1b341ea22f160d501e795).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30850));
      ((DockWindow) this.c3f18d02c9bc1b341ea22f160d501e795).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16918));
      ((TabPanel) this.c3f18d02c9bc1b341ea22f160d501e795).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16922), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16926)));
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30761);
      ((DockWindow) this.c3f18d02c9bc1b341ea22f160d501e795).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16930));
      this.c4ffe800d52986b27d66e2886fadad952.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16934);
      this.c4ffe800d52986b27d66e2886fadad952.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16938), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16942));
      this.c4ffe800d52986b27d66e2886fadad952.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30875);
      this.c4ffe800d52986b27d66e2886fadad952.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16946), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16950));
      this.c4ffe800d52986b27d66e2886fadad952.SizeMode = (PictureBoxSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16954);
      this.c4ffe800d52986b27d66e2886fadad952.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16958);
      this.c4ffe800d52986b27d66e2886fadad952.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16962) != 0;
      ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16966);
      ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30898), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(16970), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16974), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16978), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16982));
      this.c74ae2563a72edeef646bba38ebdd0ce8.set_IsReadOnly(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16986) != 0);
      ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16990), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16994));
      this.c74ae2563a72edeef646bba38ebdd0ce8.set_Multiline(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(16998) != 0);
      ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30913);
      ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17002), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17006));
      ((Control) this.c74ae2563a72edeef646bba38ebdd0ce8).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17010);
      ((RadControl) this.c74ae2563a72edeef646bba38ebdd0ce8).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.cc5109af75315520586ca50d6cd84c973.Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17014);
      this.cc5109af75315520586ca50d6cd84c973.ImeMode = (ImeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17018);
      this.cc5109af75315520586ca50d6cd84c973.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17022), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17026));
      this.cc5109af75315520586ca50d6cd84c973.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30928);
      this.cc5109af75315520586ca50d6cd84c973.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17030), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17034));
      this.cc5109af75315520586ca50d6cd84c973.SizeMode = (PictureBoxSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17038);
      this.cc5109af75315520586ca50d6cd84c973.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17042);
      this.cc5109af75315520586ca50d6cd84c973.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17046) != 0;
      this.cc5109af75315520586ca50d6cd84c973.DoubleClick += new EventHandler(this.c5096bbd2f3958dfbc93f74090981758b);
      ((RadControl) this.c830db343ebd6db124b1b541a729f89ad).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17050) != 0);
      ((Control) this.c830db343ebd6db124b1b541a729f89ad).Controls.Add((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0);
      ((Control) this.c830db343ebd6db124b1b541a729f89ad).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30943);
      ((RadElement) ((RadControl) this.c830db343ebd6db124b1b541a729f89ad).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17054), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17058)));
      ((SplitPanel) this.c830db343ebd6db124b1b541a729f89ad).get_SizeInfo().set_SizeMode((SplitPanelSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17062));
      ((RadSplitContainer) this.c830db343ebd6db124b1b541a729f89ad).set_SplitterWidth(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17066));
      ((RadControl) this.c830db343ebd6db124b1b541a729f89ad).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((TabStripPanel) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).set_CanUpdateChildIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17070) != 0);
      ((RadControl) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17074) != 0);
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).Controls.Add((Control) this.c3f18d02c9bc1b341ea22f160d501e795);
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).Controls.Add((Control) this.c78b2def3d06d6b5a4d21846a0d787eee);
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).Controls.Add((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b);
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).Controls.Add((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a);
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).Controls.Add((Control) this.c24e3e0bc5926188969ef6ed35bca3f48);
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).Controls.Add((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607);
      ((TabStripPanel) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17078), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17082)));
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(30980);
      ((RadElement) ((RadControl) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17086), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17090)));
      ((TabStripPanel) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).set_SelectedIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17094));
      ((TabStripPanel) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17098), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17102)));
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17106);
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17110) != 0;
      ((RadControl) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c78b2def3d06d6b5a4d21846a0d787eee.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c78b2def3d06d6b5a4d21846a0d787eee).Controls.Add((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5);
      ((DockWindow) this.c78b2def3d06d6b5a4d21846a0d787eee).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17114));
      ((Control) this.c78b2def3d06d6b5a4d21846a0d787eee).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(17118));
      ((TabPanel) this.c78b2def3d06d6b5a4d21846a0d787eee).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17122), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17126)));
      ((DockWindow) this.c78b2def3d06d6b5a4d21846a0d787eee).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31015));
      ((DockWindow) this.c78b2def3d06d6b5a4d21846a0d787eee).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17130));
      ((TabPanel) this.c78b2def3d06d6b5a4d21846a0d787eee).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17134), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17138)));
      ((Control) this.c78b2def3d06d6b5a4d21846a0d787eee).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31042);
      ((DockWindow) this.c78b2def3d06d6b5a4d21846a0d787eee).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17142));
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17146);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.c2b75e78467422d822cfdace19fced8b4);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.c00cbac6f52b66fe9075f2e2d10af540a);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.c20125c1e72d687c9063a72becb2b139c);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.cfd811e4de46986ea5fd1a90c4e25b17a);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.cc9d166d46812474925d4574ed649e971);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.c2f140be112f4d6280c6d8b3f548ccb8a);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.cbd1041f8be005d147b5e93849f76b59d);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.c8692650f24b3012c232c930089f0258c);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.c91d2e830a71a1148124277bd799d126c);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Controls.Add((Control) this.c66c0f7f85b853fc9a2258f078c613edd);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17150);
      this.ceb0fc808ac3cea091a2bf8db3cf9f1c5.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31053));
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17154), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17158));
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31082);
      this.ceb0fc808ac3cea091a2bf8db3cf9f1c5.set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17162)));
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17166), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17170));
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17174);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31053);
      this.c2b75e78467422d822cfdace19fced8b4.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17178);
      this.c2b75e78467422d822cfdace19fced8b4.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17182) != 0;
      this.c2b75e78467422d822cfdace19fced8b4.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17186), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17190));
      this.c2b75e78467422d822cfdace19fced8b4.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31109);
      this.c2b75e78467422d822cfdace19fced8b4.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17194), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17198));
      this.c2b75e78467422d822cfdace19fced8b4.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17202);
      this.c2b75e78467422d822cfdace19fced8b4.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31124);
      this.c00cbac6f52b66fe9075f2e2d10af540a.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17206) != 0);
      ((Control) this.c00cbac6f52b66fe9075f2e2d10af540a).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17210);
      this.c00cbac6f52b66fe9075f2e2d10af540a.set_HorizontalScrollState((ScrollState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17214));
      ((Control) this.c00cbac6f52b66fe9075f2e2d10af540a).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17218), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17222));
      ((Control) this.c00cbac6f52b66fe9075f2e2d10af540a).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31143);
      this.c00cbac6f52b66fe9075f2e2d10af540a.set_SelectLastAddedItem(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17226) != 0);
      ((Control) this.c00cbac6f52b66fe9075f2e2d10af540a).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17230), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17234));
      ((Control) this.c00cbac6f52b66fe9075f2e2d10af540a).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17238);
      ((Control) this.c00cbac6f52b66fe9075f2e2d10af540a).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      this.c20125c1e72d687c9063a72becb2b139c.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17242);
      this.c20125c1e72d687c9063a72becb2b139c.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17246), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17250));
      this.c20125c1e72d687c9063a72becb2b139c.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31168);
      this.c20125c1e72d687c9063a72becb2b139c.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17254), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17258));
      this.c20125c1e72d687c9063a72becb2b139c.SizeMode = (PictureBoxSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17262);
      this.c20125c1e72d687c9063a72becb2b139c.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17266);
      this.c20125c1e72d687c9063a72becb2b139c.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17270) != 0;
      this.cfd811e4de46986ea5fd1a90c4e25b17a.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17274);
      this.cfd811e4de46986ea5fd1a90c4e25b17a.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17278) != 0;
      this.cfd811e4de46986ea5fd1a90c4e25b17a.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17282), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17286));
      this.cfd811e4de46986ea5fd1a90c4e25b17a.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31185);
      this.cfd811e4de46986ea5fd1a90c4e25b17a.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17290), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17294));
      this.cfd811e4de46986ea5fd1a90c4e25b17a.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17298);
      this.cfd811e4de46986ea5fd1a90c4e25b17a.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31200);
      this.cc9d166d46812474925d4574ed649e971.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17302);
      this.cc9d166d46812474925d4574ed649e971.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17306) != 0;
      this.cc9d166d46812474925d4574ed649e971.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17310), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17314));
      this.cc9d166d46812474925d4574ed649e971.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31211);
      this.cc9d166d46812474925d4574ed649e971.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17318), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17322));
      this.cc9d166d46812474925d4574ed649e971.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17326);
      this.cc9d166d46812474925d4574ed649e971.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31224);
      this.c2f140be112f4d6280c6d8b3f548ccb8a.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17330) != 0);
      ((Control) this.c2f140be112f4d6280c6d8b3f548ccb8a).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17334);
      ((Control) this.c2f140be112f4d6280c6d8b3f548ccb8a).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17338), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17342));
      ((Control) this.c2f140be112f4d6280c6d8b3f548ccb8a).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31237);
      this.c2f140be112f4d6280c6d8b3f548ccb8a.set_SelectLastAddedItem(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17346) != 0);
      ((Control) this.c2f140be112f4d6280c6d8b3f548ccb8a).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17350), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17354));
      ((Control) this.c2f140be112f4d6280c6d8b3f548ccb8a).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17358);
      ((Control) this.c2f140be112f4d6280c6d8b3f548ccb8a).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      ((Control) this.cbd1041f8be005d147b5e93849f76b59d).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17362);
      ((Control) this.cbd1041f8be005d147b5e93849f76b59d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17366), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17370));
      ((Control) this.cbd1041f8be005d147b5e93849f76b59d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31254);
      this.cbd1041f8be005d147b5e93849f76b59d.set_ProgressOrientation((ProgressOrientation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17374));
      this.cbd1041f8be005d147b5e93849f76b59d.set_ShowProgressIndicators(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17378) != 0);
      ((Control) this.cbd1041f8be005d147b5e93849f76b59d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17382), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17386));
      ((Control) this.cbd1041f8be005d147b5e93849f76b59d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17390);
      ((Control) this.cbd1041f8be005d147b5e93849f76b59d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7393);
      this.c8692650f24b3012c232c930089f0258c.set_AllowEdit(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17394) != 0);
      ((Control) this.c8692650f24b3012c232c930089f0258c).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17398);
      ((Control) this.c8692650f24b3012c232c930089f0258c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17402), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17406));
      ((Control) this.c8692650f24b3012c232c930089f0258c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31269);
      this.c8692650f24b3012c232c930089f0258c.set_SelectLastAddedItem(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17410) != 0);
      ((Control) this.c8692650f24b3012c232c930089f0258c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17414), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17418));
      ((Control) this.c8692650f24b3012c232c930089f0258c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17422);
      ((Control) this.c8692650f24b3012c232c930089f0258c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      this.c91d2e830a71a1148124277bd799d126c.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17426);
      this.c91d2e830a71a1148124277bd799d126c.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17430) != 0;
      this.c91d2e830a71a1148124277bd799d126c.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17434), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17438));
      this.c91d2e830a71a1148124277bd799d126c.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31298);
      this.c91d2e830a71a1148124277bd799d126c.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17442), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17446));
      this.c91d2e830a71a1148124277bd799d126c.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17450);
      this.c91d2e830a71a1148124277bd799d126c.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31311);
      this.c66c0f7f85b853fc9a2258f078c613edd.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17454);
      this.c66c0f7f85b853fc9a2258f078c613edd.AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17458) != 0;
      this.c66c0f7f85b853fc9a2258f078c613edd.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17462), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17466));
      this.c66c0f7f85b853fc9a2258f078c613edd.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31322);
      this.c66c0f7f85b853fc9a2258f078c613edd.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17470), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17474));
      this.c66c0f7f85b853fc9a2258f078c613edd.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17478);
      this.c66c0f7f85b853fc9a2258f078c613edd.Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31335);
      this.c7c2ca4c94e8d95132cb789b411fcc27b.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b).Controls.Add((Control) this.ccd11edb9d36850a5cccf6849cebf8790);
      ((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b).Controls.Add((Control) this.c9828af810645b7cadbb5e7f90ebdc726);
      ((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b).Controls.Add((Control) this.c0c519a92c14db391cc60009c355f6c77);
      ((DockWindow) this.c7c2ca4c94e8d95132cb789b411fcc27b).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17482));
      ((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(17486));
      ((TabPanel) this.c7c2ca4c94e8d95132cb789b411fcc27b).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17490), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17494)));
      ((DockWindow) this.c7c2ca4c94e8d95132cb789b411fcc27b).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31380));
      ((DockWindow) this.c7c2ca4c94e8d95132cb789b411fcc27b).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17498));
      ((TabPanel) this.c7c2ca4c94e8d95132cb789b411fcc27b).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17502), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17506)));
      ((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31409);
      ((DockWindow) this.c7c2ca4c94e8d95132cb789b411fcc27b).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17510));
      this.ccd11edb9d36850a5cccf6849cebf8790.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17514);
      this.ccd11edb9d36850a5cccf6849cebf8790.ImeMode = (ImeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17518);
      this.ccd11edb9d36850a5cccf6849cebf8790.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17522), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17526));
      this.ccd11edb9d36850a5cccf6849cebf8790.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31432);
      this.ccd11edb9d36850a5cccf6849cebf8790.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17530), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17534));
      this.ccd11edb9d36850a5cccf6849cebf8790.SizeMode = (PictureBoxSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17538);
      this.ccd11edb9d36850a5cccf6849cebf8790.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17542);
      this.ccd11edb9d36850a5cccf6849cebf8790.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17546) != 0;
      this.c9828af810645b7cadbb5e7f90ebdc726.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17550);
      this.c9828af810645b7cadbb5e7f90ebdc726.ImeMode = (ImeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17554);
      this.c9828af810645b7cadbb5e7f90ebdc726.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17558), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17562));
      this.c9828af810645b7cadbb5e7f90ebdc726.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31453);
      this.c9828af810645b7cadbb5e7f90ebdc726.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17566), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17570));
      this.c9828af810645b7cadbb5e7f90ebdc726.SizeMode = (PictureBoxSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17574);
      this.c9828af810645b7cadbb5e7f90ebdc726.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17578);
      this.c9828af810645b7cadbb5e7f90ebdc726.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17582) != 0;
      this.c0c519a92c14db391cc60009c355f6c77.Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17586);
      this.c0c519a92c14db391cc60009c355f6c77.ImeMode = (ImeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17590);
      this.c0c519a92c14db391cc60009c355f6c77.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17594), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17598));
      this.c0c519a92c14db391cc60009c355f6c77.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31474);
      this.c0c519a92c14db391cc60009c355f6c77.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17602), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17606));
      this.c0c519a92c14db391cc60009c355f6c77.SizeMode = (PictureBoxSizeMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17610);
      this.c0c519a92c14db391cc60009c355f6c77.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17614);
      this.c0c519a92c14db391cc60009c355f6c77.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17618) != 0;
      this.ce4834f41a2d4bf23a4afa6097bd2e65a.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a).Controls.Add((Control) this.c714cda224c0867b81d88c3a87f7b805d);
      ((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a).Controls.Add((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35);
      ((DockWindow) this.ce4834f41a2d4bf23a4afa6097bd2e65a).set_DefaultFloatingSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17622), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17626)));
      ((DockWindow) this.ce4834f41a2d4bf23a4afa6097bd2e65a).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17630));
      ((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(17634));
      ((TabPanel) this.ce4834f41a2d4bf23a4afa6097bd2e65a).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17638), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17642)));
      ((DockWindow) this.ce4834f41a2d4bf23a4afa6097bd2e65a).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31495));
      ((DockWindow) this.ce4834f41a2d4bf23a4afa6097bd2e65a).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17646));
      ((TabPanel) this.ce4834f41a2d4bf23a4afa6097bd2e65a).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17650), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17654)));
      ((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31510);
      ((DockWindow) this.ce4834f41a2d4bf23a4afa6097bd2e65a).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17658));
      this.c714cda224c0867b81d88c3a87f7b805d.AllowWebBrowserDrop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17662) != 0;
      this.c714cda224c0867b81d88c3a87f7b805d.Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17666);
      this.c714cda224c0867b81d88c3a87f7b805d.Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17670), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17674));
      this.c714cda224c0867b81d88c3a87f7b805d.MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17678), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17682));
      this.c714cda224c0867b81d88c3a87f7b805d.Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31531);
      this.c714cda224c0867b81d88c3a87f7b805d.ScriptErrorsSuppressed = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17686) != 0;
      this.c714cda224c0867b81d88c3a87f7b805d.Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17690), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17694));
      this.c714cda224c0867b81d88c3a87f7b805d.TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17698);
      this.c714cda224c0867b81d88c3a87f7b805d.TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17702) != 0;
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17706);
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17710) != 0;
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).Controls.Add((Control) this.c2847a413b553d4c7de02d6550eafde3c);
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).Controls.Add((Control) this.c357bfd7fc69acf74548222098fb25669);
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17714);
      this.c8feaaff2cfc11c5e9956aac64eb58b35.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31552));
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17718), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17722));
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31569);
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17726), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17730));
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17734);
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31552);
      ((RadControl) this.c8feaaff2cfc11c5e9956aac64eb58b35).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c2847a413b553d4c7de02d6550eafde3c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17738), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17742));
      ((Control) this.c2847a413b553d4c7de02d6550eafde3c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31594);
      ((Control) this.c2847a413b553d4c7de02d6550eafde3c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17746), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17750));
      ((Control) this.c2847a413b553d4c7de02d6550eafde3c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17754);
      ((Control) this.c2847a413b553d4c7de02d6550eafde3c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31613);
      ((RadControl) this.c2847a413b553d4c7de02d6550eafde3c).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c2847a413b553d4c7de02d6550eafde3c).Click += new EventHandler(this.cf1d07eec0ff2b3ebc25d71173ed6414e);
      ((Control) this.c357bfd7fc69acf74548222098fb25669).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17758), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17762));
      ((Control) this.c357bfd7fc69acf74548222098fb25669).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31616);
      ((Control) this.c357bfd7fc69acf74548222098fb25669).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17766), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17770));
      ((Control) this.c357bfd7fc69acf74548222098fb25669).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17774);
      ((Control) this.c357bfd7fc69acf74548222098fb25669).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31635);
      ((RadControl) this.c357bfd7fc69acf74548222098fb25669).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c357bfd7fc69acf74548222098fb25669).Click += new EventHandler(this.c19835ae6c6fd13fd547baabc4427caa2);
      this.c24e3e0bc5926188969ef6ed35bca3f48.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c24e3e0bc5926188969ef6ed35bca3f48).Controls.Add((Control) this.cdff096b93bcf8895ef6ce933c902940d);
      ((DockWindow) this.c24e3e0bc5926188969ef6ed35bca3f48).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17778));
      ((Control) this.c24e3e0bc5926188969ef6ed35bca3f48).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(17782));
      ((TabPanel) this.c24e3e0bc5926188969ef6ed35bca3f48).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17786), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17790)));
      ((DockWindow) this.c24e3e0bc5926188969ef6ed35bca3f48).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31638));
      ((DockWindow) this.c24e3e0bc5926188969ef6ed35bca3f48).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17794));
      ((TabPanel) this.c24e3e0bc5926188969ef6ed35bca3f48).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17798), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17802)));
      ((Control) this.c24e3e0bc5926188969ef6ed35bca3f48).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31659);
      ((DockWindow) this.c24e3e0bc5926188969ef6ed35bca3f48).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17806));
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).Controls.Add((Control) this.ce0e7fe2dec7b73af921b84452e573154);
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17810);
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17814), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17818));
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31672);
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17822), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17826));
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17830);
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(12100);
      ((Control) this.ce0e7fe2dec7b73af921b84452e573154).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17834) != 0;
      ((Control) this.ce0e7fe2dec7b73af921b84452e573154).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17838);
      ((Control) this.ce0e7fe2dec7b73af921b84452e573154).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17842), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17846));
      ((Control) this.ce0e7fe2dec7b73af921b84452e573154).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31691);
      ((Control) this.ce0e7fe2dec7b73af921b84452e573154).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17850), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17854));
      ((Control) this.ce0e7fe2dec7b73af921b84452e573154).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17858);
      ((Control) this.ce0e7fe2dec7b73af921b84452e573154).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31710);
      ((RadControl) this.ce0e7fe2dec7b73af921b84452e573154).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c969e7ecbcc3e5f2b58f9abd63fd43607.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).Controls.Add((Control) this.c58eefb73a902712c6fd5929e97bd4b97);
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).Controls.Add((Control) this.cf1bbdaba14013386fcabe835941101b9);
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).Controls.Add((Control) this.c8e4e933c1082ae051c164f38f5d1cb14);
      ((DockWindow) this.c969e7ecbcc3e5f2b58f9abd63fd43607).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17862));
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(17866));
      ((TabPanel) this.c969e7ecbcc3e5f2b58f9abd63fd43607).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17870), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17874)));
      ((DockWindow) this.c969e7ecbcc3e5f2b58f9abd63fd43607).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31767));
      ((DockWindow) this.c969e7ecbcc3e5f2b58f9abd63fd43607).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17878));
      ((TabPanel) this.c969e7ecbcc3e5f2b58f9abd63fd43607).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17882), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17886)));
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31798);
      ((DockWindow) this.c969e7ecbcc3e5f2b58f9abd63fd43607).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17890));
      ((Control) this.c58eefb73a902712c6fd5929e97bd4b97).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17894);
      ((Control) this.c58eefb73a902712c6fd5929e97bd4b97).ForeColor = Color.Red;
      ((Control) this.c58eefb73a902712c6fd5929e97bd4b97).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17898), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17902));
      ((Control) this.c58eefb73a902712c6fd5929e97bd4b97).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31823);
      ((Control) this.c58eefb73a902712c6fd5929e97bd4b97).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17906), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17910));
      ((Control) this.c58eefb73a902712c6fd5929e97bd4b97).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17914);
      ((Control) this.c58eefb73a902712c6fd5929e97bd4b97).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31842);
      ((Control) this.cf1bbdaba14013386fcabe835941101b9).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17918);
      this.cf1bbdaba14013386fcabe835941101b9.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17922));
      ((RadButtonBase) this.cf1bbdaba14013386fcabe835941101b9).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31851))));
      ((Control) this.cf1bbdaba14013386fcabe835941101b9).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17926), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17930));
      ((Control) this.cf1bbdaba14013386fcabe835941101b9).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31892);
      ((RadControl) this.cf1bbdaba14013386fcabe835941101b9).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17934)));
      ((Control) this.cf1bbdaba14013386fcabe835941101b9).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17938), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17942));
      ((Control) this.cf1bbdaba14013386fcabe835941101b9).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17946);
      ((Control) this.cf1bbdaba14013386fcabe835941101b9).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31921);
      ((RadButtonBase) this.cf1bbdaba14013386fcabe835941101b9).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17950));
      ((RadButtonBase) this.cf1bbdaba14013386fcabe835941101b9).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17954));
      ((RadControl) this.cf1bbdaba14013386fcabe835941101b9).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cf1bbdaba14013386fcabe835941101b9).Click += new EventHandler(this.cae13de9b9651dd0155f4a16d9235bec3);
      ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17958);
      this.c8e4e933c1082ae051c164f38f5d1cb14.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17962));
      ((RadButtonBase) this.c8e4e933c1082ae051c164f38f5d1cb14).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31946))));
      ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17966), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17970));
      ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31985);
      ((RadControl) this.c8e4e933c1082ae051c164f38f5d1cb14).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17974)));
      ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17978), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17982));
      ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17986);
      ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32012);
      ((RadButtonBase) this.c8e4e933c1082ae051c164f38f5d1cb14).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17990));
      ((RadButtonBase) this.c8e4e933c1082ae051c164f38f5d1cb14).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17994));
      ((RadControl) this.c8e4e933c1082ae051c164f38f5d1cb14).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c8e4e933c1082ae051c164f38f5d1cb14).Click += new EventHandler(this.cb896ac5c44acce323c2f49079bd9b95a);
      ((TabStripPanel) this.c0185dca1f25fc3c2cc62921a9050d18f).set_CanUpdateChildIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(17998) != 0);
      ((Control) this.c0185dca1f25fc3c2cc62921a9050d18f).Controls.Add((Control) this.c48844a2ef256637729bbfeba6c14b1ba);
      ((TabStripPanel) this.c0185dca1f25fc3c2cc62921a9050d18f).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18002), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18006)));
      ((Control) this.c0185dca1f25fc3c2cc62921a9050d18f).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32035);
      ((TabStripPanel) this.c0185dca1f25fc3c2cc62921a9050d18f).set_SelectedIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18010));
      ((TabStripPanel) this.c0185dca1f25fc3c2cc62921a9050d18f).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18014), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18018)));
      ((SplitPanel) this.c0185dca1f25fc3c2cc62921a9050d18f).get_SizeInfo().set_AbsoluteSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18022), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18026)));
      ((SplitPanel) this.c0185dca1f25fc3c2cc62921a9050d18f).get_SizeInfo().set_SplitterCorrection(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18030), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18034)));
      ((Control) this.c0185dca1f25fc3c2cc62921a9050d18f).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18038);
      ((Control) this.c0185dca1f25fc3c2cc62921a9050d18f).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18042) != 0;
      ((RadControl) this.c0185dca1f25fc3c2cc62921a9050d18f).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c48844a2ef256637729bbfeba6c14b1ba.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).Controls.Add((Control) this.cddad6496d4e1c285617512daf16ee740);
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).Controls.Add((Control) this.cd21917de552da0d5fa4c6079cd71111f);
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).Controls.Add((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc);
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).Controls.Add((Control) this.c80b1c299c05614f9c782a38b86c99494);
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).Controls.Add((Control) this.c799de9bbe8c05dd37f1ae092015d68e1);
      ((DockWindow) this.c48844a2ef256637729bbfeba6c14b1ba).set_DefaultFloatingSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18046), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18050)));
      ((DockWindow) this.c48844a2ef256637729bbfeba6c14b1ba).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18054));
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(18058));
      ((TabPanel) this.c48844a2ef256637729bbfeba6c14b1ba).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18062), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18066)));
      ((DockWindow) this.c48844a2ef256637729bbfeba6c14b1ba).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26269));
      ((DockWindow) this.c48844a2ef256637729bbfeba6c14b1ba).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18070));
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).RightToLeft = (RightToLeft) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18074);
      ((TabPanel) this.c48844a2ef256637729bbfeba6c14b1ba).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18078), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18082)));
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26294);
      ((DockWindow) this.c48844a2ef256637729bbfeba6c14b1ba).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18086));
      ((Control) this.cddad6496d4e1c285617512daf16ee740).AccessibleRole = (AccessibleRole) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18090);
      ((Control) this.cddad6496d4e1c285617512daf16ee740).Controls.Add((Control) this.cbc2eee5df02616fd21fbc91bc233cdcd);
      ((Control) this.cddad6496d4e1c285617512daf16ee740).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18094);
      this.cddad6496d4e1c285617512daf16ee740.set_HeaderText(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32062));
      ((Control) this.cddad6496d4e1c285617512daf16ee740).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18098), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18102));
      ((Control) this.cddad6496d4e1c285617512daf16ee740).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32093);
      ((Control) this.cddad6496d4e1c285617512daf16ee740).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18106), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18110));
      ((Control) this.cddad6496d4e1c285617512daf16ee740).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18114);
      ((Control) this.cddad6496d4e1c285617512daf16ee740).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32062);
      ((RadControl) this.cddad6496d4e1c285617512daf16ee740).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((TabStripPanel) this.ceb25ec87df1d957dbabc08d3338713dd).set_CanUpdateChildIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18118) != 0);
      ((Control) this.ceb25ec87df1d957dbabc08d3338713dd).Controls.Add((Control) this.cc1bf6cfe06c7e943de81a144b94d908c);
      ((TabStripPanel) this.ceb25ec87df1d957dbabc08d3338713dd).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18122), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18126)));
      ((Control) this.ceb25ec87df1d957dbabc08d3338713dd).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32118);
      ((RadElement) ((RadControl) this.ceb25ec87df1d957dbabc08d3338713dd).get_RootElement()).set_MinSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18130), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18134)));
      ((TabStripPanel) this.ceb25ec87df1d957dbabc08d3338713dd).set_SelectedIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18138));
      ((TabStripPanel) this.ceb25ec87df1d957dbabc08d3338713dd).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18142), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18146)));
      ((SplitPanel) this.ceb25ec87df1d957dbabc08d3338713dd).get_SizeInfo().set_AbsoluteSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18150), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18154)));
      ((SplitPanel) this.ceb25ec87df1d957dbabc08d3338713dd).get_SizeInfo().set_SplitterCorrection(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18158), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18162)));
      ((Control) this.ceb25ec87df1d957dbabc08d3338713dd).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18166);
      ((Control) this.ceb25ec87df1d957dbabc08d3338713dd).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18170) != 0;
      ((RadControl) this.ceb25ec87df1d957dbabc08d3338713dd).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((TabStripPanel) this.c91e9024abe6202a1b65e9677c8b82412).set_CanUpdateChildIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18174) != 0);
      ((RadControl) this.c91e9024abe6202a1b65e9677c8b82412).set_CausesValidation(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18178) != 0);
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).Controls.Add((Control) this.c28c4210040b2b3298484f4b1697ed477);
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).Controls.Add((Control) this.ccf9a1c650ea674b5d9aff1def6334db2);
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).Controls.Add((Control) this.cf18cb5dad0d928f1718d2705e894530d);
      ((TabStripPanel) this.c91e9024abe6202a1b65e9677c8b82412).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18182), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18186)));
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32145);
      ((TabStripPanel) this.c91e9024abe6202a1b65e9677c8b82412).set_SelectedIndex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18190));
      ((TabStripPanel) this.c91e9024abe6202a1b65e9677c8b82412).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18194), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18198)));
      ((SplitPanel) this.c91e9024abe6202a1b65e9677c8b82412).get_SizeInfo().set_AbsoluteSize(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18202), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18206)));
      ((SplitPanel) this.c91e9024abe6202a1b65e9677c8b82412).get_SizeInfo().set_SplitterCorrection(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18210), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18214)));
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18218);
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).TabStop = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18222) != 0;
      ((RadControl) this.c91e9024abe6202a1b65e9677c8b82412).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c28c4210040b2b3298484f4b1697ed477.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.c28c4210040b2b3298484f4b1697ed477).Controls.Add((Control) this.cf273feb18353b8a5aca9b1d1f46844c6);
      ((DockWindow) this.c28c4210040b2b3298484f4b1697ed477).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18226));
      ((Control) this.c28c4210040b2b3298484f4b1697ed477).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(18230));
      ((TabPanel) this.c28c4210040b2b3298484f4b1697ed477).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18234), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18238)));
      ((DockWindow) this.c28c4210040b2b3298484f4b1697ed477).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32172));
      ((DockWindow) this.c28c4210040b2b3298484f4b1697ed477).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18242));
      ((TabPanel) this.c28c4210040b2b3298484f4b1697ed477).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18246), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18250)));
      ((Control) this.c28c4210040b2b3298484f4b1697ed477).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(31552);
      ((DockWindow) this.c28c4210040b2b3298484f4b1697ed477).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18254));
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18258) != 0;
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Controls.Add((Control) this.ca649489ce70abf72060d3b333298ed77);
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Controls.Add((Control) this.c8c95b6e3f74e541d66aa845a751279d2);
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Controls.Add((Control) this.c4f9790e49b5c17eba6614a7824f1741c);
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Controls.Add((Control) this.ce5de00809f1e6aab265b64623d9bc1a5);
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Controls.Add((Control) this.cf8a1dc8cf7f73143ea81640d7645c738);
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18262);
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18266), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18270));
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32195);
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18274), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18278));
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18282);
      ((RadControl) this.cf273feb18353b8a5aca9b1d1f46844c6).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ca649489ce70abf72060d3b333298ed77).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18286);
      this.ca649489ce70abf72060d3b333298ed77.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18290));
      ((RadButtonBase) this.ca649489ce70abf72060d3b333298ed77).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32214))));
      ((Control) this.ca649489ce70abf72060d3b333298ed77).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18294), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18298));
      ((Control) this.ca649489ce70abf72060d3b333298ed77).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32257);
      ((RadControl) this.ca649489ce70abf72060d3b333298ed77).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18302)));
      ((Control) this.ca649489ce70abf72060d3b333298ed77).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18306), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18310));
      ((Control) this.ca649489ce70abf72060d3b333298ed77).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18314);
      ((Control) this.ca649489ce70abf72060d3b333298ed77).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32288);
      ((RadButtonBase) this.ca649489ce70abf72060d3b333298ed77).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18318));
      ((RadButtonBase) this.ca649489ce70abf72060d3b333298ed77).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18322));
      ((RadControl) this.ca649489ce70abf72060d3b333298ed77).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ca649489ce70abf72060d3b333298ed77).Click += new EventHandler(this.c95491d79f5fba95e0fa7597e14b222fe);
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18326);
      this.c8c95b6e3f74e541d66aa845a751279d2.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18330));
      ((RadButtonBase) this.c8c95b6e3f74e541d66aa845a751279d2).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32315))));
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18334), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18338));
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32358);
      ((RadControl) this.c8c95b6e3f74e541d66aa845a751279d2).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18342)));
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18346), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18350));
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18354);
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32389);
      ((RadButtonBase) this.c8c95b6e3f74e541d66aa845a751279d2).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18358));
      ((RadButtonBase) this.c8c95b6e3f74e541d66aa845a751279d2).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18362));
      ((RadControl) this.c8c95b6e3f74e541d66aa845a751279d2).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c8c95b6e3f74e541d66aa845a751279d2).Click += new EventHandler(this.c3c62c4e1b695596139040f6223b53199);
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18366);
      this.c4f9790e49b5c17eba6614a7824f1741c.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18370));
      ((RadButtonBase) this.c4f9790e49b5c17eba6614a7824f1741c).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32436))));
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18374), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18378));
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32479);
      ((RadControl) this.c4f9790e49b5c17eba6614a7824f1741c).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18382)));
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18386), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18390));
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18394);
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32510);
      ((RadButtonBase) this.c4f9790e49b5c17eba6614a7824f1741c).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18398));
      ((RadButtonBase) this.c4f9790e49b5c17eba6614a7824f1741c).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18402));
      ((RadControl) this.c4f9790e49b5c17eba6614a7824f1741c).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c4f9790e49b5c17eba6614a7824f1741c).Click += new EventHandler(this.cd9a9ad96757ebd3cc07b49ec781e0bc8);
      ((Control) this.ce5de00809f1e6aab265b64623d9bc1a5).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18406);
      this.ce5de00809f1e6aab265b64623d9bc1a5.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18410));
      ((RadButtonBase) this.ce5de00809f1e6aab265b64623d9bc1a5).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32531))));
      ((Control) this.ce5de00809f1e6aab265b64623d9bc1a5).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18414), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18418));
      ((Control) this.ce5de00809f1e6aab265b64623d9bc1a5).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32582);
      ((RadControl) this.ce5de00809f1e6aab265b64623d9bc1a5).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18422)));
      ((Control) this.ce5de00809f1e6aab265b64623d9bc1a5).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18426), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18430));
      ((Control) this.ce5de00809f1e6aab265b64623d9bc1a5).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18434);
      ((Control) this.ce5de00809f1e6aab265b64623d9bc1a5).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32621);
      ((RadButtonBase) this.ce5de00809f1e6aab265b64623d9bc1a5).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18438));
      ((RadButtonBase) this.ce5de00809f1e6aab265b64623d9bc1a5).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18442));
      ((RadControl) this.ce5de00809f1e6aab265b64623d9bc1a5).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ce5de00809f1e6aab265b64623d9bc1a5).Click += new EventHandler(this.cd5fa4dcfadcc93d74350c51c0986e380);
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18446);
      this.cf8a1dc8cf7f73143ea81640d7645c738.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18450));
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18454) != 0;
      ((RadButtonBase) this.cf8a1dc8cf7f73143ea81640d7645c738).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32658))));
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18458), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18462));
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32699);
      ((RadControl) this.cf8a1dc8cf7f73143ea81640d7645c738).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18466)));
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18470), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18474));
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18478);
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32728);
      ((RadButtonBase) this.cf8a1dc8cf7f73143ea81640d7645c738).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18482));
      ((RadButtonBase) this.cf8a1dc8cf7f73143ea81640d7645c738).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18486));
      ((RadControl) this.cf8a1dc8cf7f73143ea81640d7645c738).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.cf8a1dc8cf7f73143ea81640d7645c738).Click += new EventHandler(this.c9959d048e2fe4826cfdded21647cf98f);
      this.ccf9a1c650ea674b5d9aff1def6334db2.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.ccf9a1c650ea674b5d9aff1def6334db2).Controls.Add((Control) this.cb6204fff3792b968130bf39d7e003531);
      ((DockWindow) this.ccf9a1c650ea674b5d9aff1def6334db2).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18490));
      ((Control) this.ccf9a1c650ea674b5d9aff1def6334db2).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(18494));
      ((TabPanel) this.ccf9a1c650ea674b5d9aff1def6334db2).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18498), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18502)));
      ((DockWindow) this.ccf9a1c650ea674b5d9aff1def6334db2).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32761));
      ((DockWindow) this.ccf9a1c650ea674b5d9aff1def6334db2).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18506));
      ((TabPanel) this.ccf9a1c650ea674b5d9aff1def6334db2).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18510), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18514)));
      ((Control) this.ccf9a1c650ea674b5d9aff1def6334db2).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32784);
      ((DockWindow) this.ccf9a1c650ea674b5d9aff1def6334db2).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18518));
      ((Control) this.cb6204fff3792b968130bf39d7e003531).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18522) != 0;
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Controls.Add((Control) this.c264210f8880117c5d13694e2bdf33135);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Controls.Add((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Controls.Add((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Controls.Add((Control) this.c2ccfe80606082cc7f5920727b308bf4d);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Controls.Add((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Controls.Add((Control) this.ce2e62cad203b8927cba774d40cc26e1e);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18526);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18530), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18534));
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32813);
      ((Control) this.cb6204fff3792b968130bf39d7e003531).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18538), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18542));
      ((Control) this.cb6204fff3792b968130bf39d7e003531).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18546);
      ((RadControl) this.cb6204fff3792b968130bf39d7e003531).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c264210f8880117c5d13694e2bdf33135).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18550);
      this.c264210f8880117c5d13694e2bdf33135.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18554));
      ((RadButtonBase) this.c264210f8880117c5d13694e2bdf33135).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32832))));
      ((Control) this.c264210f8880117c5d13694e2bdf33135).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18558), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18562));
      ((Control) this.c264210f8880117c5d13694e2bdf33135).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32865);
      ((RadControl) this.c264210f8880117c5d13694e2bdf33135).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18566)));
      ((Control) this.c264210f8880117c5d13694e2bdf33135).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18570), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18574));
      ((Control) this.c264210f8880117c5d13694e2bdf33135).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18578);
      ((Control) this.c264210f8880117c5d13694e2bdf33135).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32886);
      ((RadButtonBase) this.c264210f8880117c5d13694e2bdf33135).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18582));
      ((RadButtonBase) this.c264210f8880117c5d13694e2bdf33135).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18586));
      ((RadControl) this.c264210f8880117c5d13694e2bdf33135).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c264210f8880117c5d13694e2bdf33135).Click += new EventHandler(this.c94dd3a90255de1f485df820c8a22b1ab);
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18590);
      this.c7730aeebdbd664b38e5f8bbc1437a2c2.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18594));
      ((RadButtonBase) this.c7730aeebdbd664b38e5f8bbc1437a2c2).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32903))));
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18598), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18602));
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32944);
      ((RadControl) this.c7730aeebdbd664b38e5f8bbc1437a2c2).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18606)));
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18610), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18614));
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18618);
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32973);
      ((RadButtonBase) this.c7730aeebdbd664b38e5f8bbc1437a2c2).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18622));
      ((RadButtonBase) this.c7730aeebdbd664b38e5f8bbc1437a2c2).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18626));
      ((RadControl) this.c7730aeebdbd664b38e5f8bbc1437a2c2).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c7730aeebdbd664b38e5f8bbc1437a2c2).Click += new EventHandler(this.c13f5c11df9c459a2a7d3f3b326593596);
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18630);
      this.c8d4d0749ecd032b3b3c0ef4542ed6d97.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18634));
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18638) != 0;
      ((RadButtonBase) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32998))));
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18642), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18646));
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33031);
      ((RadControl) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18650)));
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18654), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18658));
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18662);
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33052);
      ((RadButtonBase) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18666));
      ((RadButtonBase) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18670));
      ((RadControl) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).Click += new EventHandler(this.c884bc8ac4a1f786b3291d2be37bd5f1b);
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18674);
      this.c2ccfe80606082cc7f5920727b308bf4d.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18678));
      ((RadButtonBase) this.c2ccfe80606082cc7f5920727b308bf4d).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33067))));
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18682), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18686));
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33108);
      ((RadControl) this.c2ccfe80606082cc7f5920727b308bf4d).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18690)));
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18694), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18698));
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18702);
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33137);
      ((RadButtonBase) this.c2ccfe80606082cc7f5920727b308bf4d).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18706));
      ((RadButtonBase) this.c2ccfe80606082cc7f5920727b308bf4d).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18710));
      ((RadControl) this.c2ccfe80606082cc7f5920727b308bf4d).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c2ccfe80606082cc7f5920727b308bf4d).Click += new EventHandler(this.c9d6a6359bdaa8bfb408f277ae45099e3);
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18714);
      this.c0b71e1da7d09a3789bead9e0ff8feda4.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18718));
      ((RadButtonBase) this.c0b71e1da7d09a3789bead9e0ff8feda4).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33164))));
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18722), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18726));
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33209);
      ((RadControl) this.c0b71e1da7d09a3789bead9e0ff8feda4).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18730)));
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18734), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18738));
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18742);
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33242);
      ((RadButtonBase) this.c0b71e1da7d09a3789bead9e0ff8feda4).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18746));
      ((RadButtonBase) this.c0b71e1da7d09a3789bead9e0ff8feda4).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18750));
      ((RadControl) this.c0b71e1da7d09a3789bead9e0ff8feda4).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c0b71e1da7d09a3789bead9e0ff8feda4).Click += new EventHandler(this.c4a1f2e7bf3546566e4ec3384be1ab1ce);
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18754);
      this.ce2e62cad203b8927cba774d40cc26e1e.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18758));
      ((RadButtonBase) this.ce2e62cad203b8927cba774d40cc26e1e).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33273))));
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18762), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18766));
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33312);
      ((RadControl) this.ce2e62cad203b8927cba774d40cc26e1e).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18770)));
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18774), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18778));
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18782);
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33339);
      ((RadButtonBase) this.ce2e62cad203b8927cba774d40cc26e1e).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18786));
      ((RadButtonBase) this.ce2e62cad203b8927cba774d40cc26e1e).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18790));
      ((RadControl) this.ce2e62cad203b8927cba774d40cc26e1e).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.ce2e62cad203b8927cba774d40cc26e1e).Click += new EventHandler(this.c30b03ae489223abe0feeb95c8904c2f0);
      this.cf18cb5dad0d928f1718d2705e894530d.set_Caption(cbc37c11913f6155524e269a386b425d5.c20c00b8e97bb4c0fb2b7ac6facf98b91);
      ((Control) this.cf18cb5dad0d928f1718d2705e894530d).Controls.Add((Control) this.ca17c92fca2120e58e5f8f7c1e444d324);
      ((DockWindow) this.cf18cb5dad0d928f1718d2705e894530d).set_DocumentButtons((DocumentStripButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18794));
      ((Control) this.cf18cb5dad0d928f1718d2705e894530d).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(18798));
      ((TabPanel) this.cf18cb5dad0d928f1718d2705e894530d).set_Location(new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18802), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18806)));
      ((DockWindow) this.cf18cb5dad0d928f1718d2705e894530d).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33372));
      ((DockWindow) this.cf18cb5dad0d928f1718d2705e894530d).set_PreviousDockState((DockState) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18810));
      ((TabPanel) this.cf18cb5dad0d928f1718d2705e894530d).set_Size(new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18814), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18818)));
      ((Control) this.cf18cb5dad0d928f1718d2705e894530d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33395);
      ((DockWindow) this.cf18cb5dad0d928f1718d2705e894530d).set_ToolCaptionButtons((ToolStripCaptionButtons) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18822));
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18826) != 0;
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Controls.Add((Control) this.c99759b9e421322e16d5c36b476bb666f);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Controls.Add((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Controls.Add((Control) this.c2d265ee1256f88eddf3baa3887d2c91d);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Controls.Add((Control) this.c4533e25263801abd1cc5792ca28f28c1);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Controls.Add((Control) this.c7a8633bba80a50b81c114da3ab992208);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Controls.Add((Control) this.c7970189ca187b55d3e75631f17e4b67c);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18830);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18834), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18838));
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33406);
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18842), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18846));
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18850);
      ((RadControl) this.ca17c92fca2120e58e5f8f7c1e444d324).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c99759b9e421322e16d5c36b476bb666f).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18854);
      this.c99759b9e421322e16d5c36b476bb666f.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18858));
      ((RadButtonBase) this.c99759b9e421322e16d5c36b476bb666f).set_Image((Image) c27603360ccc8374975348defb9eee9fc.icnBug);
      ((Control) this.c99759b9e421322e16d5c36b476bb666f).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18862), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18866));
      ((Control) this.c99759b9e421322e16d5c36b476bb666f).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33425);
      ((RadControl) this.c99759b9e421322e16d5c36b476bb666f).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18870)));
      ((Control) this.c99759b9e421322e16d5c36b476bb666f).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18874), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18878));
      ((Control) this.c99759b9e421322e16d5c36b476bb666f).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18882);
      ((Control) this.c99759b9e421322e16d5c36b476bb666f).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33446);
      ((RadButtonBase) this.c99759b9e421322e16d5c36b476bb666f).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18886));
      ((RadButtonBase) this.c99759b9e421322e16d5c36b476bb666f).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18890));
      ((RadControl) this.c99759b9e421322e16d5c36b476bb666f).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c99759b9e421322e16d5c36b476bb666f).Click += new EventHandler(this.c9ef71cbbd73862240b6affa8ee095fd2);
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18894);
      this.c6b7d903aa965d47e2f39fa93f9aa3134.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18898));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18902) != 0;
      ((RadButtonBase) this.c6b7d903aa965d47e2f39fa93f9aa3134).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33475))));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18906), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18910));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(13981);
      ((RadControl) this.c6b7d903aa965d47e2f39fa93f9aa3134).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18914)));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18918), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18922));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18926);
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33508);
      ((RadButtonBase) this.c6b7d903aa965d47e2f39fa93f9aa3134).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18930));
      ((RadButtonBase) this.c6b7d903aa965d47e2f39fa93f9aa3134).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18934));
      ((RadControl) this.c6b7d903aa965d47e2f39fa93f9aa3134).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c6b7d903aa965d47e2f39fa93f9aa3134).Click += new EventHandler(this.c0a6ea2a725f4eff55eb6f116b2de4d29);
      ((Control) this.c2d265ee1256f88eddf3baa3887d2c91d).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18938);
      this.c2d265ee1256f88eddf3baa3887d2c91d.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18942));
      ((RadButtonBase) this.c2d265ee1256f88eddf3baa3887d2c91d).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33551))));
      ((Control) this.c2d265ee1256f88eddf3baa3887d2c91d).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18946), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18950));
      ((Control) this.c2d265ee1256f88eddf3baa3887d2c91d).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33590);
      ((RadControl) this.c2d265ee1256f88eddf3baa3887d2c91d).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18954)));
      ((Control) this.c2d265ee1256f88eddf3baa3887d2c91d).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18958), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18962));
      ((Control) this.c2d265ee1256f88eddf3baa3887d2c91d).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18966);
      ((Control) this.c2d265ee1256f88eddf3baa3887d2c91d).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33617);
      ((RadButtonBase) this.c2d265ee1256f88eddf3baa3887d2c91d).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18970));
      ((RadButtonBase) this.c2d265ee1256f88eddf3baa3887d2c91d).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18974));
      ((RadControl) this.c2d265ee1256f88eddf3baa3887d2c91d).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c2d265ee1256f88eddf3baa3887d2c91d).Click += new EventHandler(this.cd49b1edc754a0a47f5bb49a58fba51b8);
      ((Control) this.c4533e25263801abd1cc5792ca28f28c1).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18978);
      this.c4533e25263801abd1cc5792ca28f28c1.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18982));
      ((RadButtonBase) this.c4533e25263801abd1cc5792ca28f28c1).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33658))));
      ((Control) this.c4533e25263801abd1cc5792ca28f28c1).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18986), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18990));
      ((Control) this.c4533e25263801abd1cc5792ca28f28c1).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33701);
      ((RadControl) this.c4533e25263801abd1cc5792ca28f28c1).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18994)));
      ((Control) this.c4533e25263801abd1cc5792ca28f28c1).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(18998), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19002));
      ((Control) this.c4533e25263801abd1cc5792ca28f28c1).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19006);
      ((Control) this.c4533e25263801abd1cc5792ca28f28c1).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33732);
      ((RadButtonBase) this.c4533e25263801abd1cc5792ca28f28c1).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19010));
      ((RadButtonBase) this.c4533e25263801abd1cc5792ca28f28c1).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19014));
      ((RadControl) this.c4533e25263801abd1cc5792ca28f28c1).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c4533e25263801abd1cc5792ca28f28c1).Click += new EventHandler(this.c113e80b8ef6ddbbbeb2b901b16fe6b8d);
      ((Control) this.c7a8633bba80a50b81c114da3ab992208).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19018);
      this.c7a8633bba80a50b81c114da3ab992208.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19022));
      ((RadButtonBase) this.c7a8633bba80a50b81c114da3ab992208).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33759))));
      ((Control) this.c7a8633bba80a50b81c114da3ab992208).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19026), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19030));
      ((Control) this.c7a8633bba80a50b81c114da3ab992208).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33800);
      ((RadControl) this.c7a8633bba80a50b81c114da3ab992208).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19034)));
      ((Control) this.c7a8633bba80a50b81c114da3ab992208).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19038), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19042));
      ((Control) this.c7a8633bba80a50b81c114da3ab992208).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19046);
      ((Control) this.c7a8633bba80a50b81c114da3ab992208).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33829);
      ((RadButtonBase) this.c7a8633bba80a50b81c114da3ab992208).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19050));
      ((RadButtonBase) this.c7a8633bba80a50b81c114da3ab992208).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19054));
      ((RadControl) this.c7a8633bba80a50b81c114da3ab992208).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c7a8633bba80a50b81c114da3ab992208).Click += new EventHandler(this.c2ff8dad80aaaddc681d75648bdec83ef);
      ((Control) this.c7970189ca187b55d3e75631f17e4b67c).Anchor = (AnchorStyles) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19058);
      this.c7970189ca187b55d3e75631f17e4b67c.set_DialogResult((DialogResult) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19062));
      ((RadButtonBase) this.c7970189ca187b55d3e75631f17e4b67c).set_Image(cfef913925dbcb138b6254aca5895c785.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33854))));
      ((Control) this.c7970189ca187b55d3e75631f17e4b67c).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19066), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19070));
      ((Control) this.c7970189ca187b55d3e75631f17e4b67c).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33895);
      ((RadControl) this.c7970189ca187b55d3e75631f17e4b67c).set_Padding(new Padding(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19074)));
      ((Control) this.c7970189ca187b55d3e75631f17e4b67c).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19078), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19082));
      ((Control) this.c7970189ca187b55d3e75631f17e4b67c).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19086);
      ((Control) this.c7970189ca187b55d3e75631f17e4b67c).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33924);
      ((RadButtonBase) this.c7970189ca187b55d3e75631f17e4b67c).set_TextAlignment((ContentAlignment) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19090));
      ((RadButtonBase) this.c7970189ca187b55d3e75631f17e4b67c).set_TextImageRelation((TextImageRelation) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19094));
      ((RadControl) this.c7970189ca187b55d3e75631f17e4b67c).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      ((Control) this.c7970189ca187b55d3e75631f17e4b67c).Click += new EventHandler(this.ce23c7b4a21a3bc2bfe930891c1af1451);
      RadItemOwnerCollection items = this.cede9e5be54b12de354ccc761ad4fc4a1.get_Items();
      RadItem[] radItemArray = c94f5ec1863162ab34d60da6089b77f03.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19098));
      int index8 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19102);
      RadMenuItem cb2e65fdb3dbc553302280f07b5ad39c6 = this.cb2e65fdb3dbc553302280f07b5ad39c6;
      radItemArray[index8] = (RadItem) cb2e65fdb3dbc553302280f07b5ad39c6;
      int index9 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19106);
      RadMenuItem ccf6a2ae401b49d2712eabf1f3d73b706 = this.ccf6a2ae401b49d2712eabf1f3d73b706;
      radItemArray[index9] = (RadItem) ccf6a2ae401b49d2712eabf1f3d73b706;
      int index10 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19110);
      RadMenuItem c30f1c4d08b6e85057a60708401020f66 = this.c30f1c4d08b6e85057a60708401020f66;
      radItemArray[index10] = (RadItem) c30f1c4d08b6e85057a60708401020f66;
      int index11 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19114);
      RadMenuItem c8c72e702b57548c1958f16299f426252 = this.c8c72e702b57548c1958f16299f426252;
      radItemArray[index11] = (RadItem) c8c72e702b57548c1958f16299f426252;
      int index12 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19118);
      RadMenuItem c1b66238ca4e5fb0c40c7756554ee7321 = this.c1b66238ca4e5fb0c40c7756554ee7321;
      radItemArray[index12] = (RadItem) c1b66238ca4e5fb0c40c7756554ee7321;
      int index13 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19122);
      RadMenuItem c6651d3ca26654e3b924967485e5cd357 = this.c6651d3ca26654e3b924967485e5cd357;
      radItemArray[index13] = (RadItem) c6651d3ca26654e3b924967485e5cd357;
      int index14 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19126);
      RadMenuItem c4587b5b95b0f054ed931ca93214ad4b4 = this.c4587b5b95b0f054ed931ca93214ad4b4;
      radItemArray[index14] = (RadItem) c4587b5b95b0f054ed931ca93214ad4b4;
      int index15 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19130);
      RadMenuItem c682b9a9146723389d400ba86d9cc4e13 = this.c682b9a9146723389d400ba86d9cc4e13;
      radItemArray[index15] = (RadItem) c682b9a9146723389d400ba86d9cc4e13;
      ((RadItemCollection) items).AddRange(radItemArray);
      ((RadElement) this.cb2e65fdb3dbc553302280f07b5ad39c6).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33949));
      ((RadItem) this.cb2e65fdb3dbc553302280f07b5ad39c6).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(32728));
      ((RadElement) this.ccf6a2ae401b49d2712eabf1f3d73b706).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33970));
      ((RadItem) this.ccf6a2ae401b49d2712eabf1f3d73b706).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(33995));
      ((RadElement) this.c30f1c4d08b6e85057a60708401020f66).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34026));
      ((RadItem) this.c30f1c4d08b6e85057a60708401020f66).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34045));
      ((RadElement) this.c8c72e702b57548c1958f16299f426252).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34070));
      ((RadItem) this.c8c72e702b57548c1958f16299f426252).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27591));
      ((RadElement) this.c1b66238ca4e5fb0c40c7756554ee7321).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34087));
      ((RadItem) this.c1b66238ca4e5fb0c40c7756554ee7321).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27536));
      ((RadElement) this.c6651d3ca26654e3b924967485e5cd357).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34108));
      ((RadItem) this.c6651d3ca26654e3b924967485e5cd357).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(27914));
      ((RadElement) this.c4587b5b95b0f054ed931ca93214ad4b4).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34139));
      ((RadItem) this.c4587b5b95b0f054ed931ca93214ad4b4).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34178));
      ((RadElement) this.c682b9a9146723389d400ba86d9cc4e13).set_Name(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34221));
      ((RadItem) this.c682b9a9146723389d400ba86d9cc4e13).set_Text(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34240));
      this.c11eb1c4d76d9d3f27d002b636b540897.Interval = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19134);
      this.c11eb1c4d76d9d3f27d002b636b540897.Tick += new EventHandler(this.cca1e6f0c118a015c36011e89157d564b);
      this.c0edd068ee51dc000d1e5630da9f32887.Enabled = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19138) != 0;
      this.c0edd068ee51dc000d1e5630da9f32887.Interval = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19142);
      this.c0edd068ee51dc000d1e5630da9f32887.Tick += new EventHandler(this.cbc9a48cabf7b4a128a9180dd88330fbc);
      this.cee1c0c7304084325bbf547e952525117.Interval = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19146);
      this.cee1c0c7304084325bbf547e952525117.Tick += new EventHandler(this.c4b53578253dc8af44089b6406c1f217a);
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).AutoSize = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19150) != 0;
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).Dock = (DockStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19154);
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).Font = new Font(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(26327), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(19158), (FontStyle) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19162), (GraphicsUnit) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19166), (byte) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19170));
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).ForeColor = Color.FromArgb(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19174), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19178), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19182));
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).Location = new Point(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19186), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19190));
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34299);
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).Size = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19194), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19198));
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).TabIndex = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19202);
      ((Control) this.c03788d88eb825d0e4375ff91a470e965).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34318);
      ((RadControl) this.c03788d88eb825d0e4375ff91a470e965).set_ThemeName(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321));
      this.c03788d88eb825d0e4375ff91a470e965.set_UseMnemonic(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19206) != 0);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(19210), cb85779efa5f9c78fa841b92dceca9094.c8c83a3807da60b9f032d40f2b5665e27(19214));
      ((RadFormControlBase) this).set_AutoScaleMode((AutoScaleMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19218));
      ((RadFormControlBase) this).set_AutoSize(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19222) != 0);
      ((Form) this).ClientSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19226), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19230));
      ((Control) this).Controls.Add((Control) this.cb5983a9ef6bb031c7f34108a205a5729);
      ((Control) this).Controls.Add((Control) this.c03788d88eb825d0e4375ff91a470e965);
      ((Control) this).ForeColor = Color.FromArgb(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19234), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19238), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19242));
      ((Form) this).Icon = cead0b4edd540ba7cac4363706aa68fb6.cc8e287d5350b43026d33bb80beb131a0(componentResourceManager.GetObject(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7256)));
      ((Control) this).MinimumSize = new Size(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19246), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19250));
      ((Control) this).Name = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34520);
      ((RadFormControlBase) this).get_RootElement().set_ApplyShapeToControl(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19254) != 0);
      ((Form) this).StartPosition = (FormStartPosition) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19258);
      ((Control) this).Text = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(34549);
      ((Form) this).FormClosing += new FormClosingEventHandler(this.c4d7603f44e182524e7af57fd50e8d9af);
      ((Form) this).Load += new EventHandler(this.cc18fbaf5773c17b1ab5bace35c6a9199);
      ((ISupportInitialize) this.cef99ac773757daa1842ee58c7914a0cc).EndInit();
      ((ISupportInitialize) this.ced13435d37c83d5695f389153255d7aa).EndInit();
      ((ISupportInitialize) this.c544236c90282c9157c1c7d7d9ff1369c).EndInit();
      ((ISupportInitialize) this.c80abb9b1c6ac93efa1bec9b52c6e0411).EndInit();
      ((ISupportInitialize) this.c3aec1f92fc33a551b592c8b2a7adf9ec).EndInit();
      ((ISupportInitialize) this.cef22dcb29373b4f99e89eb28166e5dc2).EndInit();
      ((ISupportInitialize) this.c8af15fc87ff7fad3b7d70b37794c0516).EndInit();
      ((ISupportInitialize) this.c659877bdbb8d30820909c7b85d4f6330).EndInit();
      ((ISupportInitialize) this.c799de9bbe8c05dd37f1ae092015d68e1).EndInit();
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19262) != 0);
      ((Control) this.c799de9bbe8c05dd37f1ae092015d68e1).PerformLayout();
      ((ISupportInitialize) this.cc4a40b1385deb54376434c71c8e76b81).EndInit();
      ((ISupportInitialize) this.c97c4e0fb1efa8799a0b6c47d1e86000e).EndInit();
      ((ISupportInitialize) this.c29c9611cee072e30c8d766c88964ac2b).EndInit();
      ((ISupportInitialize) this.c3ecd11fc9291e6c3176323b62baedac8).EndInit();
      ((ISupportInitialize) this.c02f822b4a13df9d2c2d9666d3986f346).EndInit();
      ((ISupportInitialize) this.c6e68d4163e92bbc6a33bc1e07bf15a4f).EndInit();
      ((ISupportInitialize) this.c93a99fb1c1183d9875099b634bd270a6).EndInit();
      ((ISupportInitialize) this.c62f555309ebbf190dea30e5a84cef1bf).EndInit();
      ((ISupportInitialize) this.c80b1c299c05614f9c782a38b86c99494).EndInit();
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19266) != 0);
      ((Control) this.c80b1c299c05614f9c782a38b86c99494).PerformLayout();
      ((ISupportInitialize) this.c2e00ce37891acd500b28d73704f69b35).EndInit();
      ((ISupportInitialize) this.c560a6e04507a6b91381df70d8ba999e6).EndInit();
      ((ISupportInitialize) this.c7ab9d9b723e77867834f5b804c1e8d84).EndInit();
      ((ISupportInitialize) this.cf7bf7ed27e5378895056f9c4e22fa991).EndInit();
      ((ISupportInitialize) this.c16be2b426e8d997c5d2b8f1d3becf90b).EndInit();
      ((ISupportInitialize) this.cbc2eee5df02616fd21fbc91bc233cdcd).EndInit();
      ((ISupportInitialize) this.c8827d4c0d7431a9890c547ec78a2c02c).EndInit();
      ((Control) this.c8827d4c0d7431a9890c547ec78a2c02c).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19270) != 0);
      ((ISupportInitialize) this.cba8de59d8af22ab73fe624faad5b1c0d).EndInit();
      ((ISupportInitialize) this.c089f82a5bb56d907790079762415ad00).EndInit();
      ((ISupportInitialize) this.c139823df8e929f346d6de8a9db1cae22).EndInit();
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19274) != 0);
      ((Control) this.c139823df8e929f346d6de8a9db1cae22).PerformLayout();
      ((ISupportInitialize) this.c1f709ff5165e5433056bda30bb571911).EndInit();
      ((ISupportInitialize) this.c9c662a4a0b9d44555b1f70db28046f61).EndInit();
      ((ISupportInitialize) this.c0b6ff62997904dd44189c4cb17f2ab15).EndInit();
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19278) != 0);
      ((Control) this.c0b6ff62997904dd44189c4cb17f2ab15).PerformLayout();
      ((ISupportInitialize) this.c6c17c59699d09a6deff3affeead81921).EndInit();
      ((ISupportInitialize) this.c9e453c2e79f4fc55124ccb1fd3603902).EndInit();
      ((ISupportInitialize) this.c38925728235576f0c42cd968bde792d6).EndInit();
      ((ISupportInitialize) this.c05e1ef1d0f2e5250a57c757370b74d83).EndInit();
      ((ISupportInitialize) this.c713a3cd0f5b5e9ff3d443ae80f12e3c8).EndInit();
      ((ISupportInitialize) this.cba34b2a0111f6e5bc303375f968bc295).EndInit();
      ((ISupportInitialize) this.cfa8badb30bc978147487352167d51546).EndInit();
      ((ISupportInitialize) this.cee9946355c6a614ff90b875d32801e38).EndInit();
      ((ISupportInitialize) this.c743d2a65362475553a562cf35b254c43).EndInit();
      ((ISupportInitialize) this.c3a32d8bd5fe0b6b703d373c8ec023149).EndInit();
      ((ISupportInitialize) this.c207af470f351635895849de23ece3abc).EndInit();
      ((ISupportInitialize) this.ced6aa7f9911c4707f69ec112a4e51672).EndInit();
      ((ISupportInitialize) this.c489dec79b6c4a36ad71b2dd683ba4003).EndInit();
      ((ISupportInitialize) this.c0bc74edb9773f357b639b398786841b3).EndInit();
      ((ISupportInitialize) this.cdf03a2ca811ef49688b58b7e317a430a).EndInit();
      ((ISupportInitialize) this.ce940872bf2d542451e120044788d9340).EndInit();
      ((ISupportInitialize) this.c6c840f966d621484314eb45e43e34565).EndInit();
      ((ISupportInitialize) this.c738f1dd7afbbfdc20629834298bed929).EndInit();
      ((ISupportInitialize) this.cd21917de552da0d5fa4c6079cd71111f).EndInit();
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19282) != 0);
      ((Control) this.cd21917de552da0d5fa4c6079cd71111f).PerformLayout();
      ((ISupportInitialize) this.c73cd2a39bc535b70ef0ec0e9f35ddb8d).EndInit();
      ((ISupportInitialize) this.c38668e2d3dc450be2fe10e8cdead5a82).EndInit();
      ((ISupportInitialize) this.ca5a2b6669f9034e5fc384b9781cd6dd6).EndInit();
      ((ISupportInitialize) this.c4f28cce9069ce7d56aa80dce66bd91fc).EndInit();
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19286) != 0);
      ((Control) this.c4f28cce9069ce7d56aa80dce66bd91fc).PerformLayout();
      ((ISupportInitialize) this.c5539dab8a40e8d2e2a7b970e134631c8).EndInit();
      ((ISupportInitialize) this.c50c3a23f9473947fa39e14b6b066f539).EndInit();
      ((ISupportInitialize) this.cb5983a9ef6bb031c7f34108a205a5729).EndInit();
      ((Control) this.cb5983a9ef6bb031c7f34108a205a5729).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19290) != 0);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19294) != 0);
      ((Control) this.cc1bf6cfe06c7e943de81a144b94d908c).PerformLayout();
      ((ISupportInitialize) this.ceb095b069074eddeeb1ad92edcc4ec95).EndInit();
      ((ISupportInitialize) this.c101d57e697d17803583217bbb889b590).EndInit();
      ((ISupportInitialize) this.ce1a2609d728bf5b02ebcce5d0d03abac).EndInit();
      ((ISupportInitialize) this.ccc252ce44a8e5cefbd8cd949ece215e5).EndInit();
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19298) != 0);
      ((Control) this.ccc252ce44a8e5cefbd8cd949ece215e5).PerformLayout();
      ((ISupportInitialize) this.c14d5ba9c8d3dcbc17433b50217356b5a).EndInit();
      ((ISupportInitialize) this.cd036f2b2868b103e71bd7b4fbe25a603).EndInit();
      ((ISupportInitialize) this.c3768da1c9e17b9980d03acca3e5a19a9).EndInit();
      ((ISupportInitialize) this.c0ebc97b073a7d0dba554313d3f62139d).EndInit();
      ((ISupportInitialize) this.c0b8c323aae75c040334498c5efcb96f4).EndInit();
      ((ISupportInitialize) this.c453acc1433bd9ed8673278dbdd4bee00).EndInit();
      ((Control) this.c453acc1433bd9ed8673278dbdd4bee00).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19302) != 0);
      ((Control) this.c3ec3e29a74c0f512f2935f1207d1a895).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19306) != 0);
      ((ISupportInitialize) this.c0c0e712d5ca94f2910e3ec339b2e600f).EndInit();
      ((ISupportInitialize) this.cae3beaf3bc9f066d134288b1cc6a2ab6).EndInit();
      ((Control) this.cae3beaf3bc9f066d134288b1cc6a2ab6).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19310) != 0);
      ((ISupportInitialize) this.c6f51d70787b53494b9f2a90f93e5091c).EndInit();
      ((Control) this.c6f51d70787b53494b9f2a90f93e5091c).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19314) != 0);
      ((ISupportInitialize) this.cfda0f7e74c13d6b7f59b7c808dd15331).EndInit();
      ((Control) this.cfda0f7e74c13d6b7f59b7c808dd15331).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19318) != 0);
      ((Control) this.c44e1112bbc33afd80a87709982a149c4).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19322) != 0);
      ((Control) this.c44e1112bbc33afd80a87709982a149c4).PerformLayout();
      ((ISupportInitialize) this.c39e7e88f29f2018d9aa6c123a5da05b9).EndInit();
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19326) != 0);
      ((Control) this.c39e7e88f29f2018d9aa6c123a5da05b9).PerformLayout();
      ((ISupportInitialize) this.c68b8f2723032c53a16a489755afa9f3d).EndInit();
      ((ISupportInitialize) this.cc823a5ecc3a0639558b6b92439679149).EndInit();
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19330) != 0);
      ((Control) this.cc823a5ecc3a0639558b6b92439679149).PerformLayout();
      ((ISupportInitialize) this.c414a01a9d1ea6f9447f9d5fee7291bd3).EndInit();
      ((Control) this.c89ff289eea7f33d04edb7f11d666c144).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19334) != 0);
      ((ISupportInitialize) this.c422900b304a63407dfa05f2f233b004e).EndInit();
      ((Control) this.c422900b304a63407dfa05f2f233b004e).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19338) != 0);
      ((ISupportInitialize) this.ca9c68e79493f9e09d605914c6cd6edd5).EndInit();
      ((ISupportInitialize) this.c51175a4a3b6b11c0eee765ad7effd076).EndInit();
      ((ISupportInitialize) this.cf152d3e6147dc4e0112582d0f6097ce3).EndInit();
      ((ISupportInitialize) this.cbe00b03ee2347f9756848babd446e36c).EndInit();
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19342) != 0);
      ((Control) this.cbe00b03ee2347f9756848babd446e36c).PerformLayout();
      ((Control) this.c2f75881f4e3a569756004ecd1f3c8da3).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19346) != 0);
      ((ISupportInitialize) this.c101a585c2bc6dfb0b62b86bd680ce2b2).EndInit();
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19350) != 0);
      ((Control) this.c101a585c2bc6dfb0b62b86bd680ce2b2).PerformLayout();
      ((ISupportInitialize) this.c780e6034938558087f1ea7ad59d1d853).EndInit();
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19354) != 0);
      ((Control) this.c780e6034938558087f1ea7ad59d1d853).PerformLayout();
      ((ISupportInitialize) this.c86ce7f867a560282470decd22cec0860).EndInit();
      ((ISupportInitialize) this.c22d04ce1034d647a95d30b01a54768c4).EndInit();
      ((ISupportInitialize) this.cfda9a98a11ebdc24a447457307015f17).EndInit();
      ((ISupportInitialize) this.c979c76a51f33de27b2440305fd60fd38).EndInit();
      ((ISupportInitialize) this.ce55c0c71a3136c1bba91d488db23a660).EndInit();
      ((ISupportInitialize) this.cb92ad5a7459656fe7b6fd86ff472b5c5).EndInit();
      ((ISupportInitialize) this.c77ab4cca03476e6662d72295ae2a18d0).EndInit();
      ((ISupportInitialize) this.c28cccb4bc1305f639acf2d457aeedad8).EndInit();
      ((ISupportInitialize) this.ca380231837e2eafdb42e81f47a24d226).EndInit();
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19358) != 0);
      ((Control) this.ca380231837e2eafdb42e81f47a24d226).PerformLayout();
      ((ISupportInitialize) this.cded9ed150a9ac47f6949a468fac193a6).EndInit();
      ((ISupportInitialize) this.c340f7ccf001170543c57999fd96d4b38).EndInit();
      ((ISupportInitialize) this.cd8a4426aac26fd0166c7b44e9f731455).EndInit();
      ((ISupportInitialize) this.c4fda90ba27d8ac9ff70115293efc7b38).EndInit();
      ((ISupportInitialize) this.c0770534b75ebeea0c4e695dfdb7677d0).EndInit();
      ((ISupportInitialize) this.c67131d5ebad4559120841e7d6afbf050).EndInit();
      ((ISupportInitialize) this.cadd2602239e2a87754cb1203ec048ce7).EndInit();
      ((ISupportInitialize) this.cf9e2786454699a4c03d6a769f423882e).EndInit();
      ((ISupportInitialize) this.ceb96360e1866456699fd2a748e058db6).EndInit();
      ((ISupportInitialize) this.c1b58d84e7b46cb77f175ef1b94421baf).EndInit();
      ((ISupportInitialize) this.c5b062d1e6fbb1c9186310faefca6b2fa).EndInit();
      ((Control) this.c5b062d1e6fbb1c9186310faefca6b2fa).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19362) != 0);
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19366) != 0);
      ((Control) this.cf6bb2c04c0ce1a4090efd4990bc2a4d6).PerformLayout();
      ((ISupportInitialize) this.cbb44104e6cbbb2680035694332b80a01).EndInit();
      ((Control) this.cbb44104e6cbbb2680035694332b80a01).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19370) != 0);
      ((ISupportInitialize) this.c2769778d069bafd899ea27ebc8b3b6f7).EndInit();
      ((Control) this.c2769778d069bafd899ea27ebc8b3b6f7).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19374) != 0);
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19378) != 0);
      ((Control) this.c3f18d02c9bc1b341ea22f160d501e795).PerformLayout();
      ((ISupportInitialize) this.c4ffe800d52986b27d66e2886fadad952).EndInit();
      ((ISupportInitialize) this.c74ae2563a72edeef646bba38ebdd0ce8).EndInit();
      ((ISupportInitialize) this.cc5109af75315520586ca50d6cd84c973).EndInit();
      ((ISupportInitialize) this.c830db343ebd6db124b1b541a729f89ad).EndInit();
      ((Control) this.c830db343ebd6db124b1b541a729f89ad).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19382) != 0);
      ((ISupportInitialize) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).EndInit();
      ((Control) this.c9c9e7026dfacf9cea6739b2eb22bb1b0).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19386) != 0);
      ((Control) this.c78b2def3d06d6b5a4d21846a0d787eee).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19390) != 0);
      ((ISupportInitialize) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).EndInit();
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19394) != 0);
      ((Control) this.ceb0fc808ac3cea091a2bf8db3cf9f1c5).PerformLayout();
      ((ISupportInitialize) this.c00cbac6f52b66fe9075f2e2d10af540a).EndInit();
      ((ISupportInitialize) this.c20125c1e72d687c9063a72becb2b139c).EndInit();
      ((ISupportInitialize) this.c2f140be112f4d6280c6d8b3f548ccb8a).EndInit();
      ((ISupportInitialize) this.cbd1041f8be005d147b5e93849f76b59d).EndInit();
      ((ISupportInitialize) this.c8692650f24b3012c232c930089f0258c).EndInit();
      ((Control) this.c7c2ca4c94e8d95132cb789b411fcc27b).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19398) != 0);
      ((ISupportInitialize) this.ccd11edb9d36850a5cccf6849cebf8790).EndInit();
      ((ISupportInitialize) this.c9828af810645b7cadbb5e7f90ebdc726).EndInit();
      ((ISupportInitialize) this.c0c519a92c14db391cc60009c355f6c77).EndInit();
      ((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19402) != 0);
      ((Control) this.ce4834f41a2d4bf23a4afa6097bd2e65a).PerformLayout();
      ((ISupportInitialize) this.c8feaaff2cfc11c5e9956aac64eb58b35).EndInit();
      ((Control) this.c8feaaff2cfc11c5e9956aac64eb58b35).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19406) != 0);
      ((ISupportInitialize) this.c2847a413b553d4c7de02d6550eafde3c).EndInit();
      ((ISupportInitialize) this.c357bfd7fc69acf74548222098fb25669).EndInit();
      ((Control) this.c24e3e0bc5926188969ef6ed35bca3f48).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19410) != 0);
      ((ISupportInitialize) this.cdff096b93bcf8895ef6ce933c902940d).EndInit();
      ((Control) this.cdff096b93bcf8895ef6ce933c902940d).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19414) != 0);
      ((ISupportInitialize) this.ce0e7fe2dec7b73af921b84452e573154).EndInit();
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19418) != 0);
      ((Control) this.c969e7ecbcc3e5f2b58f9abd63fd43607).PerformLayout();
      ((ISupportInitialize) this.c58eefb73a902712c6fd5929e97bd4b97).EndInit();
      ((ISupportInitialize) this.cf1bbdaba14013386fcabe835941101b9).EndInit();
      ((ISupportInitialize) this.c8e4e933c1082ae051c164f38f5d1cb14).EndInit();
      ((ISupportInitialize) this.c0185dca1f25fc3c2cc62921a9050d18f).EndInit();
      ((Control) this.c0185dca1f25fc3c2cc62921a9050d18f).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19422) != 0);
      ((Control) this.c48844a2ef256637729bbfeba6c14b1ba).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19426) != 0);
      ((ISupportInitialize) this.cddad6496d4e1c285617512daf16ee740).EndInit();
      ((Control) this.cddad6496d4e1c285617512daf16ee740).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19430) != 0);
      ((ISupportInitialize) this.ceb25ec87df1d957dbabc08d3338713dd).EndInit();
      ((Control) this.ceb25ec87df1d957dbabc08d3338713dd).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19434) != 0);
      ((ISupportInitialize) this.c91e9024abe6202a1b65e9677c8b82412).EndInit();
      ((Control) this.c91e9024abe6202a1b65e9677c8b82412).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19438) != 0);
      ((Control) this.c28c4210040b2b3298484f4b1697ed477).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19442) != 0);
      ((Control) this.c28c4210040b2b3298484f4b1697ed477).PerformLayout();
      ((ISupportInitialize) this.cf273feb18353b8a5aca9b1d1f46844c6).EndInit();
      ((Control) this.cf273feb18353b8a5aca9b1d1f46844c6).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19446) != 0);
      ((ISupportInitialize) this.ca649489ce70abf72060d3b333298ed77).EndInit();
      ((ISupportInitialize) this.c8c95b6e3f74e541d66aa845a751279d2).EndInit();
      ((ISupportInitialize) this.c4f9790e49b5c17eba6614a7824f1741c).EndInit();
      ((ISupportInitialize) this.ce5de00809f1e6aab265b64623d9bc1a5).EndInit();
      ((ISupportInitialize) this.cf8a1dc8cf7f73143ea81640d7645c738).EndInit();
      ((Control) this.ccf9a1c650ea674b5d9aff1def6334db2).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19450) != 0);
      ((Control) this.ccf9a1c650ea674b5d9aff1def6334db2).PerformLayout();
      ((ISupportInitialize) this.cb6204fff3792b968130bf39d7e003531).EndInit();
      ((Control) this.cb6204fff3792b968130bf39d7e003531).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19454) != 0);
      ((ISupportInitialize) this.c264210f8880117c5d13694e2bdf33135).EndInit();
      ((ISupportInitialize) this.c7730aeebdbd664b38e5f8bbc1437a2c2).EndInit();
      ((ISupportInitialize) this.c8d4d0749ecd032b3b3c0ef4542ed6d97).EndInit();
      ((ISupportInitialize) this.c2ccfe80606082cc7f5920727b308bf4d).EndInit();
      ((ISupportInitialize) this.c0b71e1da7d09a3789bead9e0ff8feda4).EndInit();
      ((ISupportInitialize) this.ce2e62cad203b8927cba774d40cc26e1e).EndInit();
      ((Control) this.cf18cb5dad0d928f1718d2705e894530d).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19458) != 0);
      ((Control) this.cf18cb5dad0d928f1718d2705e894530d).PerformLayout();
      ((ISupportInitialize) this.ca17c92fca2120e58e5f8f7c1e444d324).EndInit();
      ((Control) this.ca17c92fca2120e58e5f8f7c1e444d324).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19462) != 0);
      ((ISupportInitialize) this.c99759b9e421322e16d5c36b476bb666f).EndInit();
      ((ISupportInitialize) this.c6b7d903aa965d47e2f39fa93f9aa3134).EndInit();
      ((ISupportInitialize) this.c2d265ee1256f88eddf3baa3887d2c91d).EndInit();
      ((ISupportInitialize) this.c4533e25263801abd1cc5792ca28f28c1).EndInit();
      ((ISupportInitialize) this.c7a8633bba80a50b81c114da3ab992208).EndInit();
      ((ISupportInitialize) this.c7970189ca187b55d3e75631f17e4b67c).EndInit();
      ((ISupportInitialize) this.c03788d88eb825d0e4375ff91a470e965).EndInit();
      ((ISupportInitialize) this).EndInit();
      ((RadFormControlBase) this).ResumeLayout(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(19466) != 0);
    }
  }
}
