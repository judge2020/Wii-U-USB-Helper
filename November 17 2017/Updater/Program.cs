using System;
using System.Windows.Forms;

namespace Updater
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000042A4 File Offset: 0x000024A4
		[STAThread]
		private static void Main(string[] args)
		{
			if (args.Length == 1)
			{
				CommonVar.installPath = args[0];
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
