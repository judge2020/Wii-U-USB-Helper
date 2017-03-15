// Decompiled with JetBrains decompiler
// Type: Updater.Program
// Assembly: Updater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7FC3B5C5-5FF7-42B2-B7F0-8C213AAF0FEC
// Assembly location: C:\Users\hunte\Documents\DECompiles\Updater.exe

using System;
using System.Windows.Forms;

namespace Updater
{
  internal static class Program
  {
    [STAThread]
    private static void Main(string[] args)
    {
      if (args.Length == 1)
        CommonVar.installPath = args[0];
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
