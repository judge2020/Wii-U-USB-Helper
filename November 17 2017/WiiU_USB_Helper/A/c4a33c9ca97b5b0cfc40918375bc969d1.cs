using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace A
{
	// Token: 0x020000AA RID: 170
	internal static class c4a33c9ca97b5b0cfc40918375bc969d1
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x00025910 File Offset: 0x00023B10
		private static void c81f82cdaf359d3144690150488dce250()
		{
			try
			{
				string text = new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43823));
				if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ""))
				{
					for (;;)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4a33c9ca97b5b0cfc40918375bc969d1.c81f82cdaf359d3144690150488dce250()).MethodHandle;
					}
					new ccf27d2a38d7279e84184e152bc50d544(text.Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11207), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43485))).ShowDialog();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002599C File Offset: 0x00023B9C
		private static void cbc20d8197ec9b9312ec1dabc2242404f()
		{
			try
			{
				HttpWebRequest httpWebRequest = WebRequest.CreateHttp(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43932));
				httpWebRequest.Method = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(9933);
				WebResponse response = httpWebRequest.GetResponse();
				try
				{
				}
				finally
				{
					if (response != null)
					{
						for (;;)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle runtimeMethodHandle = methodof(c4a33c9ca97b5b0cfc40918375bc969d1.cbc20d8197ec9b9312ec1dabc2242404f()).MethodHandle;
						}
						((IDisposable)response).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				if (ex2 != null)
				{
					for (;;)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					WebException ex3;
					if ((ex3 = c1a0e05096a9007e4437df07306380634.c0b398ab350e72b0d64d512bae8520b85(ex2)) != null)
					{
						for (;;)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						WebException ex4 = ex3;
						HttpWebResponse httpWebResponse = c4f91ec7ebe53f25040a850a9a67b22b7.c0b398ab350e72b0d64d512bae8520b85(ex4.Response);
						bool flag;
						if (httpWebResponse == null)
						{
							for (;;)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10284) != 0);
						}
						else
						{
							flag = (httpWebResponse.StatusCode == (HttpStatusCode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10288));
						}
						if (flag)
						{
							for (;;)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							RadMessageBox.Show(c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43981), ex4.Response.Headers[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44393)], ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44406)));
							Environment.Exit(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10292));
							return;
						}
					}
				}
				RadMessageBox.Show(c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44493), ex));
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00025B08 File Offset: 0x00023D08
		[STAThread]
		private static void ce0be635e443d424596522127e6756824(string[] c3c9260886a6db15de49329a9f5b9836c)
		{
			cd16a919e13d3f63e4ae6d8f0fb0e6017.ca7ac84818622788abf514a30d9edc7bc();
			c67726bc94fb4dd43c5c00e863a4fed19.c92d03d65be2d0258da80fddaecea1a40(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10296)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44554)));
			c4a33c9ca97b5b0cfc40918375bc969d1.c1d1bf7fd10328c2b4e43179136ec587b.Start();
			AppDomain currentDomain = AppDomain.CurrentDomain;
			UnhandledExceptionEventHandler value;
			if ((value = c4a33c9ca97b5b0cfc40918375bc969d1.<>c.c5e57be654d50df4c034b8f0b917ceb75) == null)
			{
				for (;;)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4a33c9ca97b5b0cfc40918375bc969d1.ce0be635e443d424596522127e6756824(string[])).MethodHandle;
				}
				value = (c4a33c9ca97b5b0cfc40918375bc969d1.<>c.c5e57be654d50df4c034b8f0b917ceb75 = new UnhandledExceptionEventHandler(c4a33c9ca97b5b0cfc40918375bc969d1.<>c.cdfab1996eb8651828de2a4469aa3481e.c20b3e5c3da456487c582579fb13956f8));
			}
			currentDomain.UnhandledException += value;
			if ((int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(c3c9260886a6db15de49329a9f5b9836c) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10300))
			{
				for (;;)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				c34ce0b034187983362ba58cc8c72233a.c0b9a995f9c2313cad22315173d49b769 = c3c9260886a6db15de49329a9f5b9836c[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10304)];
			}
			if (!ApplicationDeployment.IsNetworkDeployed)
			{
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (c34ce0b034187983362ba58cc8c72233a.c0b9a995f9c2313cad22315173d49b769 == null)
				{
					for (;;)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44579));
					Application.Exit();
					return;
				}
			}
			IEnumerable<string> manifestResourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
			Func<string, bool> predicate;
			if ((predicate = c4a33c9ca97b5b0cfc40918375bc969d1.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0) == null)
			{
				for (;;)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				predicate = (c4a33c9ca97b5b0cfc40918375bc969d1.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0 = new Func<string, bool>(c4a33c9ca97b5b0cfc40918375bc969d1.<>c.cdfab1996eb8651828de2a4469aa3481e.c9538a363c214751d80393935a16cc40d));
			}
			IEnumerator<string> enumerator = manifestResourceNames.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					ThemeResolutionService.LoadPackageResource(text);
				}
				for (;;)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					for (;;)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					enumerator.Dispose();
				}
			}
			Application.EnableVisualStyles();
			if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.ThemeName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564)))
			{
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				Settings.Default.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44813);
			}
			if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.ThemeName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44830)))
			{
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				Settings.Default.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44873);
			}
			Settings.Default.Save();
			ThemeResolutionService.ApplicationThemeName = Settings.Default.ThemeName;
			if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Settings.Default.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44884)))
			{
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				c4a33c9ca97b5b0cfc40918375bc969d1.ce7a67aa39a960de2776e66c7972f14b2 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10308) != 0);
				cd12741190acbe9c40d9e4da0a5a8e496 cd12741190acbe9c40d9e4da0a5a8e = new cd12741190acbe9c40d9e4da0a5a8e496();
				cd12741190acbe9c40d9e4da0a5a8e.ShowDialog();
				if (cd12741190acbe9c40d9e4da0a5a8e.cd2877d0bf929a7d7adb972e5b527870b)
				{
					for (;;)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					Application.Exit();
					return;
				}
			}
			Mutex mutex = new Mutex(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10312) != 0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44893));
			try
			{
				try
				{
					if (!mutex.WaitOne(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10316), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10320) != 0))
					{
						for (;;)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(44938));
						return;
					}
				}
				catch (AbandonedMutexException)
				{
				}
				Application.Run(new cb6cc9a5b122137bc5f2718f61ab49e59());
			}
			finally
			{
				if (mutex != null)
				{
					for (;;)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					((IDisposable)mutex).Dispose();
				}
			}
		}

		// Token: 0x040002DB RID: 731
		public static bool ce7a67aa39a960de2776e66c7972f14b2;

		// Token: 0x040002DC RID: 732
		public static Stopwatch c1d1bf7fd10328c2b4e43179136ec587b = new Stopwatch();

		// Token: 0x040002DD RID: 733
		private static volatile bool c76575353b7b5315605bf2ba998256a89;
	}
}
