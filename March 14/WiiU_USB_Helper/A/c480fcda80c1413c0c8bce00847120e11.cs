// Decompiled with JetBrains decompiler
// Type: A.c480fcda80c1413c0c8bce00847120e11
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using NBug;
using NBug.Enums;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace A
{
  internal static class c480fcda80c1413c0c8bce00847120e11
  {
    [STAThread]
    private static void cf4ec72ecc2382dbb738547df5b95051e(string[] cccf482ee689904a1a8630dac14e0a6a0)
    {
      c641344460c4912d7feb758c824455611.c384b68a3ce05d01196ef82b6e76bbcf2();
      Settings.set_ReleaseMode(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7996) != 0);
      Settings.set_UIMode((UIMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8000));
      Settings.AddDestinationFromConnectionString(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7587));
      AppDomain.CurrentDomain.UnhandledException += Handler.get_UnhandledException();
      if ((int) cdaee2d37f7effe0581f827ac9195da99.c572aba370be49804cbdb0b35312bea94(cccf482ee689904a1a8630dac14e0a6a0) == cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8004))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c480fcda80c1413c0c8bce00847120e11.cf4ec72ecc2382dbb738547df5b95051e);
            }
            c2d4baf2bd055f4368cf2297e4ff33900.c907ca8ffa30661318a7e29e77519ea57 = cccf482ee689904a1a8630dac14e0a6a0[cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8008)];
            break;
        }
      }
      if (!ApplicationDeployment.IsNetworkDeployed)
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            if (c2d4baf2bd055f4368cf2297e4ff33900.c907ca8ffa30661318a7e29e77519ea57 == null)
            {
label_8:
              switch (1)
              {
                case 0:
                  goto label_8;
                default:
                  int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8013));
                  System.Windows.Forms.Application.Exit();
                  return;
              }
            }
            else
              break;
        }
      }
      string[] manifestResourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
      // ISSUE: reference to a compiler-generated field
      Func<string, bool> predicate = c480fcda80c1413c0c8bce00847120e11.\u003C\u003Ec.cf2acbfc0f255ba43c475c7d28711caf1;
      if (predicate == null)
      {
label_11:
        switch (2)
        {
          case 0:
            goto label_11;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            predicate = c480fcda80c1413c0c8bce00847120e11.\u003C\u003Ec.cf2acbfc0f255ba43c475c7d28711caf1 = new Func<string, bool>(c480fcda80c1413c0c8bce00847120e11.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c797cf6dfee08775708a9f28fa7f75cae);
            break;
        }
      }
      IEnumerator<string> enumerator = ((IEnumerable<string>) manifestResourceNames).Where<string>(predicate).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          ThemeResolutionService.LoadPackageResource(enumerator.Current);
label_17:
        switch (5)
        {
          case 0:
            goto label_17;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_19:
          switch (7)
          {
            case 0:
              goto label_19;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
      System.Windows.Forms.Application.EnableVisualStyles();
      if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.ThemeName, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(7321)))
      {
label_23:
        switch (4)
        {
          case 0:
            goto label_23;
          default:
            Settings.Default.ThemeName = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8249);
            break;
        }
      }
      if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.ThemeName, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8266)))
      {
label_26:
        switch (3)
        {
          case 0:
            goto label_26;
          default:
            Settings.Default.ThemeName = c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8309);
            break;
        }
      }
      Settings.Default.Save();
      ThemeResolutionService.set_ApplicationThemeName(Settings.Default.ThemeName);
      RemoteCertificateValidationCallback validationCallback1 = ServicePointManager.ServerCertificateValidationCallback;
      // ISSUE: reference to a compiler-generated field
      RemoteCertificateValidationCallback validationCallback2 = c480fcda80c1413c0c8bce00847120e11.\u003C\u003Ec.c6048d9e2c14b5dbee7326758737ce668;
      if (validationCallback2 == null)
      {
label_29:
        switch (5)
        {
          case 0:
            goto label_29;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            validationCallback2 = c480fcda80c1413c0c8bce00847120e11.\u003C\u003Ec.c6048d9e2c14b5dbee7326758737ce668 = new RemoteCertificateValidationCallback(c480fcda80c1413c0c8bce00847120e11.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.c30f98e0e5ad9a87c97719e146f54d618);
            break;
        }
      }
      ServicePointManager.ServerCertificateValidationCallback = ccc8319fb70be18e117edb5a68f6d77a8.cc8e287d5350b43026d33bb80beb131a0((object) Delegate.Combine((Delegate) validationCallback1, (Delegate) validationCallback2));
      if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(Settings.Default.Region, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8320)))
      {
label_32:
        switch (3)
        {
          case 0:
            goto label_32;
          default:
            int num = (int) ((Form) new cf9c4a065a8a6c1226fbf48aa58d35c4c()).ShowDialog();
            break;
        }
      }
      Mutex mutex = new Mutex(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8012) != 0, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8329));
      try
      {
        try
        {
          if (!mutex.WaitOne(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8016), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(8020) != 0))
          {
label_36:
            switch (7)
            {
              case 0:
                goto label_36;
              default:
                int num = (int) RadMessageBox.Show(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(8374));
                return;
            }
          }
        }
        catch (AbandonedMutexException ex)
        {
        }
        System.Windows.Forms.Application.Run((Form) new c1b7cf6218f1f498aba267c6450ec9233());
      }
      finally
      {
        if (mutex != null)
        {
label_41:
          switch (5)
          {
            case 0:
              goto label_41;
            default:
              mutex.Dispose();
              break;
          }
        }
      }
    }
  }
}
