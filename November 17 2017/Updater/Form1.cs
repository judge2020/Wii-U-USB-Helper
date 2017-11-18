using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using IWshRuntimeLibrary;
using Microsoft.CSharp.RuntimeBinder;
using ProgressBarEx;
using Updater.Properties;

namespace Updater
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002C59 File Offset: 0x00000E59
		public Form1()
		{
			this.InitializeComponent();
			base.Region = Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C8C File Offset: 0x00000E8C
		public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string iconLocation, string description)
		{
			string pathLink = Path.Combine(shortcutPath, shortcutName + ".lnk");
			WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			if (Form1.<>o__1.<>p__0 == null)
			{
				Form1.<>o__1.<>p__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(Form1)));
			}
			IWshShortcut wshShortcut = Form1.<>o__1.<>p__0.Target(Form1.<>o__1.<>p__0, wshShell.CreateShortcut(pathLink));
			wshShortcut.Description = description;
			wshShortcut.IconLocation = iconLocation;
			wshShortcut.TargetPath = targetFileLocation;
			wshShortcut.WorkingDirectory = Path.GetDirectoryName(targetFileLocation);
			wshShortcut.Save();
		}

		// Token: 0x06000036 RID: 54
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000037 RID: 55 RVA: 0x00002D34 File Offset: 0x00000F34
		private static void CreateStartShortCut(string targetFileLocation, string shortcutName, string iconLocation, string description)
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Programs), shortcutName);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string pathLink = Path.Combine(text, shortcutName + ".lnk");
			WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			if (Form1.<>o__7.<>p__0 == null)
			{
				Form1.<>o__7.<>p__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(Form1)));
			}
			IWshShortcut wshShortcut = Form1.<>o__7.<>p__0.Target(Form1.<>o__7.<>p__0, wshShell.CreateShortcut(pathLink));
			wshShortcut.WorkingDirectory = Path.GetDirectoryName(targetFileLocation);
			wshShortcut.Description = description;
			wshShortcut.IconLocation = iconLocation;
			wshShortcut.TargetPath = targetFileLocation;
			wshShortcut.Save();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002DF8 File Offset: 0x00000FF8
		private static bool TestWritePermission(string path)
		{
			try
			{
				File.WriteAllText(Path.Combine(path, "test"), "0");
			}
			catch (Exception ex)
			{
				if (ex is UnauthorizedAccessException)
				{
					ProcessStartInfo startInfo = new ProcessStartInfo(Application.ExecutablePath)
					{
						WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath),
						Verb = "runas",
						Arguments = string.Format("\"{0}\"", path)
					};
					try
					{
						Process.Start(startInfo);
					}
					catch
					{
					}
				}
				Application.Exit();
				return false;
			}
			return true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002E90 File Offset: 0x00001090
		private void Form1_Load(object sender, EventArgs e)
		{
			AppDomain.CurrentDomain.UnhandledException += delegate(object s, UnhandledExceptionEventArgs arg)
			{
				new frmError((Exception)arg.ExceptionObject).ShowDialog();
				base.Close();
			};
			using (Mutex mutex = new Mutex(true, "Global\\WIIU_USB_HELPER"))
			{
				try
				{
					if (!mutex.WaitOne(0, true))
					{
						MessageBox.Show("An instance of WiiU USB Helper is already running.");
						Application.Exit();
						return;
					}
				}
				catch (AbandonedMutexException)
				{
				}
			}
			Application.Idle += this.Update;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002F18 File Offset: 0x00001118
		[STAThread]
		private void Update(object sender, EventArgs args)
		{
			Application.Idle -= this.Update;
			new Thread(new ThreadStart(this.UpdateAsync))
			{
				IsBackground = true,
				ApartmentState = ApartmentState.STA
			}.Start();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002F50 File Offset: 0x00001150
		[STAThread]
		private void UpdateAsync()
		{
			SHA256 sha = SHA256.Create();
			List<FileToDownload> list = new List<FileToDownload>();
			if (File.Exists("ver"))
			{
				if (!Form1.TestWritePermission(""))
				{
					return;
				}
				File.ReadAllText("ver");
				WebClient webClient = new WebClient();
				string xml = "";
				try
				{
					xml = webClient.DownloadString(string.Format("{0}{1}", "https://application.wiiuusbhelper.com/", "WiiU_USB_Helper.application"));
				}
				catch (Exception ex)
				{
					Exception ex2 = ex;
					WebException ex3;
					if (ex2 != null && (ex3 = (ex2 as WebException)) != null)
					{
						WebException ex4 = ex3;
						HttpWebResponse httpWebResponse = ex4.Response as HttpWebResponse;
						if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.Forbidden)
						{
							new frmBanned(ex4.Response.Headers["CF-RAY"]).ShowDialog();
							Environment.Exit(-1);
							return;
						}
					}
					MessageBox.Show("An error occured while contacting the server. Please check your internet connection and try again. Make sure your firewall and/or antivirus is not not blocking this app.\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Application.Exit();
					return;
				}
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				string value = xmlDocument.GetElementsByTagName("assemblyIdentity")[0].Attributes["version"].Value;
				string value2 = xmlDocument.GetElementsByTagName("assemblyIdentity")[1].Attributes["name"].Value;
				string value3 = xmlDocument.GetElementsByTagName("dependentAssembly")[0].Attributes["codebase"].Value;
				string arg = string.Format("{0}{1}/{2}/", "https://application.wiiuusbhelper.com/", value3.Split(new char[]
				{
					'\\'
				})[0], value3.Split(new char[]
				{
					'\\'
				})[1]);
				string xml2 = new WebClient().DownloadString(string.Format("{0}{1}", "https://application.wiiuusbhelper.com/", value3));
				XmlDocument xmlDocument2 = new XmlDocument();
				xmlDocument2.LoadXml(xml2);
				list.AddRange(from XmlNode dependency in xmlDocument2.GetElementsByTagName("dependentAssembly")
				where dependency.Attributes["dependencyType"].Value == "install"
				select new FileToDownload(dependency.Attributes["codebase"].Value, dependency.ChildNodes[1].ChildNodes[2].InnerText, long.Parse(dependency.Attributes["size"].Value)));
				list.AddRange(from XmlNode file in xmlDocument2.GetElementsByTagName("file")
				select new FileToDownload(file.Attributes["name"].Value, file.ChildNodes[0].ChildNodes[2].InnerText, long.Parse(file.Attributes["size"].Value)));
				long totalSize = (long)list.Sum((FileToDownload x) => (int)x.Size);
				long lastSize = 0L;
				long totalDownloaded = 0L;
				Action <>9__5;
				webClient.DownloadProgressChanged += delegate(object s, DownloadProgressChangedEventArgs e)
				{
					long num = e.BytesReceived - lastSize;
					lastSize = e.BytesReceived;
					totalDownloaded += num;
					Control <>4__this = this;
					Action method2;
					if ((method2 = <>9__5) == null)
					{
						method2 = (<>9__5 = delegate
						{
							this.pgBar.Value = (int)((double)totalDownloaded / (double)totalSize * 100.0);
						});
					}
					<>4__this.Invoke(method2);
				};
				webClient.DownloadFileCompleted += delegate(object s, AsyncCompletedEventArgs e)
				{
					this.downloadComplete = true;
				};
				Action <>9__7;
				foreach (FileToDownload fileToDownload in list)
				{
					if (File.Exists(fileToDownload.Name) && Convert.ToBase64String(sha.ComputeHash(File.ReadAllBytes(fileToDownload.Name))) == fileToDownload.Hash)
					{
						totalDownloaded += fileToDownload.Size;
						Action method;
						if ((method = <>9__7) == null)
						{
							method = (<>9__7 = delegate
							{
								this.pgBar.Value = (int)((double)totalDownloaded / (double)totalSize * 100.0);
							});
						}
						base.Invoke(method);
					}
					else
					{
						string directoryName = Path.GetDirectoryName(fileToDownload.Name);
						if (directoryName != "")
						{
							Directory.CreateDirectory(directoryName);
						}
						lastSize = 0L;
						this.downloadComplete = false;
						webClient.DownloadFileAsync(new Uri(string.Format("{0}{1}.deploy", arg, fileToDownload.Name)), fileToDownload.Name);
						while (!this.downloadComplete)
						{
							Thread.Sleep(10);
						}
					}
				}
				string[] files = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath));
				string iconLocation = "";
				try
				{
					iconLocation = files.First((string x) => Path.GetExtension(x) == ".ico");
				}
				catch
				{
				}
				try
				{
					if (!File.Exists("NOSHORTCUT"))
					{
						Form1.CreateShortcut(Path.GetFileNameWithoutExtension(value2), Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Application.ExecutablePath, iconLocation, value2);
					}
					Form1.CreateStartShortCut(Application.ExecutablePath, Path.GetFileNameWithoutExtension(value2), iconLocation, value2);
				}
				catch
				{
				}
				File.WriteAllText("ver", value);
				Process.Start(new ProcessStartInfo(value2)
				{
					WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath),
					Arguments = value
				});
			}
			else
			{
				string text = CommonVar.installPath;
				if (text == null)
				{
					FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
					{
						Description = "Please select the directory in which the application should be installed. If you chose to install in Program Files (not recommended, it may cause issues), the updater will ask you for admin permissions."
					};
					if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
					{
						text = folderBrowserDialog.SelectedPath;
					}
				}
				if (text != null)
				{
					if (!Form1.TestWritePermission(text))
					{
						return;
					}
					string text2 = Path.Combine(text, "Updater.exe");
					File.WriteAllText(Path.Combine(text, "ver"), "0");
					if (!File.Exists(text2))
					{
						File.Copy(Application.ExecutablePath, text2, true);
					}
					Process.Start(new ProcessStartInfo(text2)
					{
						WorkingDirectory = text
					});
				}
			}
			base.Invoke(new Action(base.Close));
		}

		// Token: 0x04000019 RID: 25
		private const string MAIN_APP = "WiiU_USB_Helper.application";

		// Token: 0x0400001A RID: 26
		private const string ROOT_URL = "https://application.wiiuusbhelper.com/";

		// Token: 0x0400001B RID: 27
		private const string VersionFilePath = "ver";

		// Token: 0x0400001C RID: 28
		private volatile bool downloadComplete;
	}
}
