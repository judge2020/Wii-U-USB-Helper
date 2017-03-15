// Decompiled with JetBrains decompiler
// Type: Updater.Form1
// Assembly: Updater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7FC3B5C5-5FF7-42B2-B7F0-8C213AAF0FEC
// Assembly location: C:\Users\hunte\Documents\DECompiles\Updater.exe

using IWshRuntimeLibrary;
using Microsoft.CSharp.RuntimeBinder;
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
using Updater.Properties;

namespace Updater
{
  public class Form1 : Form
  {
    private const string MAIN_APP = "WiiU_USB_Helper.application";
    private const string ROOT_URL = "http://application.wiiuusbhelper.com/";
    private const string VersionFilePath = "ver";
    private volatile bool downloadComplete;
    private IContainer components;
    private Label label1;
    private PictureBox pictureBox1;
    private ProgressBar pgBar;
    private Label label2;

    public Form1()
    {
      this.InitializeComponent();
    }

    public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string iconLocation, string description)
    {
      string PathLink = Path.Combine(shortcutPath, shortcutName + ".lnk");
      // ISSUE: variable of a compiler-generated type
      WshShell instance = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
      // ISSUE: reference to a compiler-generated field
      if (Form1.\u003C\u003Eo__1.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Form1.\u003C\u003Eo__1.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (IWshShortcut), typeof (Form1)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      IWshShortcut wshShortcut = Form1.\u003C\u003Eo__1.\u003C\u003Ep__0.Target((CallSite) Form1.\u003C\u003Eo__1.\u003C\u003Ep__0, instance.CreateShortcut(PathLink));
      string str1 = description;
      wshShortcut.Description = str1;
      string str2 = iconLocation;
      wshShortcut.IconLocation = str2;
      string str3 = targetFileLocation;
      wshShortcut.TargetPath = str3;
      string directoryName = Path.GetDirectoryName(targetFileLocation);
      wshShortcut.WorkingDirectory = directoryName;
      // ISSUE: reference to a compiler-generated method
      wshShortcut.Save();
    }

    private static void CreateStartShortCut(string targetFileLocation, string shortcutName, string iconLocation, string description)
    {
      string str1 = targetFileLocation;
      string str2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Programs), shortcutName);
      if (!Directory.Exists(str2))
        Directory.CreateDirectory(str2);
      string PathLink = Path.Combine(str2, shortcutName + ".lnk");
      // ISSUE: variable of a compiler-generated type
      WshShell instance = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
      // ISSUE: reference to a compiler-generated field
      if (Form1.\u003C\u003Eo__6.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Form1.\u003C\u003Eo__6.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (IWshShortcut), typeof (Form1)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      IWshShortcut wshShortcut = Form1.\u003C\u003Eo__6.\u003C\u003Ep__0.Target((CallSite) Form1.\u003C\u003Eo__6.\u003C\u003Ep__0, instance.CreateShortcut(PathLink));
      string directoryName = Path.GetDirectoryName(targetFileLocation);
      wshShortcut.WorkingDirectory = directoryName;
      string str3 = description;
      wshShortcut.Description = str3;
      string str4 = iconLocation;
      wshShortcut.IconLocation = str4;
      string str5 = str1;
      wshShortcut.TargetPath = str5;
      // ISSUE: reference to a compiler-generated method
      wshShortcut.Save();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      using (Mutex mutex = new Mutex(false, "Global\\WIIU_USB_HELPER"))
      {
        try
        {
          if (!mutex.WaitOne(0, false))
          {
            int num = (int) MessageBox.Show("An instance of WiiU USB Helper is already running.");
            Application.Exit();
            return;
          }
        }
        catch (AbandonedMutexException ex)
        {
        }
      }
      Application.Idle += new EventHandler(this.Update);
    }

    private static bool TestWritePermission(string path)
    {
      try
      {
        System.IO.File.WriteAllText(Path.Combine(path, "test"), "0");
      }
      catch (Exception ex)
      {
        if (ex is UnauthorizedAccessException)
        {
          ProcessStartInfo startInfo = new ProcessStartInfo(Application.ExecutablePath)
          {
            WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath),
            Verb = "runas",
            Arguments = string.Format("\"{0}\"", (object) path)
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

    [STAThread]
    private void Update(object sender, EventArgs args)
    {
      Application.Idle -= new EventHandler(this.Update);
      new Thread(new ThreadStart(this.UpdateAsync))
      {
        IsBackground = true,
        ApartmentState = ApartmentState.STA
      }.Start();
    }

    [STAThread]
    private void UpdateAsync()
    {
      SHA256 shA256 = SHA256.Create();
      List<FileToDownload> source = new List<FileToDownload>();
      if (System.IO.File.Exists("ver"))
      {
        if (!Form1.TestWritePermission(""))
          return;
        string str1 = System.IO.File.ReadAllText("ver");
        WebClient webClient = new WebClient();
        string xml1;
        try
        {
          xml1 = webClient.DownloadString(string.Format("{0}{1}", (object) "http://application.wiiuusbhelper.com/", (object) "WiiU_USB_Helper.application"));
        }
        catch
        {
          int num = (int) MessageBox.Show("An error occured while contacting the server. Please check your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          Application.Exit();
          return;
        }
        XmlDocument xmlDocument1 = new XmlDocument();
        xmlDocument1.LoadXml(xml1);
        string contents = xmlDocument1.GetElementsByTagName("assemblyIdentity")[0].Attributes["version"].Value;
        string str2 = xmlDocument1.GetElementsByTagName("assemblyIdentity")[1].Attributes["name"].Value;
        if (contents != str1)
        {
          string str3 = xmlDocument1.GetElementsByTagName("dependentAssembly")[0].Attributes["codebase"].Value;
          string str4 = string.Format("{0}{1}/{2}/", (object) "http://application.wiiuusbhelper.com/", (object) str3.Split('\\')[0], (object) str3.Split('\\')[1]);
          string xml2 = new WebClient().DownloadString(string.Format("{0}{1}", (object) "http://application.wiiuusbhelper.com/", (object) str3));
          XmlDocument xmlDocument2 = new XmlDocument();
          xmlDocument2.LoadXml(xml2);
          source.AddRange(xmlDocument2.GetElementsByTagName("dependentAssembly").Cast<XmlNode>().Where<XmlNode>((Func<XmlNode, bool>) (dependency => dependency.Attributes["dependencyType"].Value == "install")).Select<XmlNode, FileToDownload>((Func<XmlNode, FileToDownload>) (dependency => new FileToDownload(dependency.Attributes["codebase"].Value, dependency.ChildNodes[1].ChildNodes[2].InnerText, long.Parse(dependency.Attributes["size"].Value)))));
          source.AddRange(xmlDocument2.GetElementsByTagName("file").Cast<XmlNode>().Select<XmlNode, FileToDownload>((Func<XmlNode, FileToDownload>) (file => new FileToDownload(file.Attributes["name"].Value, file.ChildNodes[0].ChildNodes[2].InnerText, long.Parse(file.Attributes["size"].Value)))));
          long totalSize = (long) source.Sum<FileToDownload>((Func<FileToDownload, int>) (x => (int) x.Size));
          long lastSize = 0;
          long totalDownloaded = 0;
          webClient.DownloadProgressChanged += (DownloadProgressChangedEventHandler) ((s, e) =>
          {
            long num = e.BytesReceived - lastSize;
            lastSize = e.BytesReceived;
            totalDownloaded += num;
            this.Invoke((Delegate) (() => this.pgBar.Value = (int) ((double) totalDownloaded / (double) totalSize * 100.0)));
          });
          webClient.DownloadFileCompleted += (AsyncCompletedEventHandler) ((s, e) => this.downloadComplete = true);
          foreach (FileToDownload fileToDownload in source)
          {
            if (System.IO.File.Exists(fileToDownload.Name) && Convert.ToBase64String(shA256.ComputeHash(System.IO.File.ReadAllBytes(fileToDownload.Name))) == fileToDownload.Hash)
            {
              totalDownloaded += fileToDownload.Size;
              this.Invoke((Delegate) (() => this.pgBar.Value = (int) ((double) totalDownloaded / (double) totalSize * 100.0)));
            }
            else
            {
              string directoryName = Path.GetDirectoryName(fileToDownload.Name);
              if (directoryName != "")
                Directory.CreateDirectory(directoryName);
              lastSize = 0L;
              this.downloadComplete = false;
              webClient.DownloadFileAsync(new Uri(string.Format("{0}{1}.deploy", (object) str4, (object) fileToDownload.Name)), fileToDownload.Name);
              while (!this.downloadComplete)
                Thread.Sleep(10);
            }
          }
          string[] files = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath));
          string iconLocation = "";
          try
          {
            iconLocation = ((IEnumerable<string>) files).First<string>((Func<string, bool>) (x => Path.GetExtension(x) == ".ico"));
          }
          catch
          {
          }
          try
          {
            Form1.CreateShortcut(Path.GetFileNameWithoutExtension(str2), Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Application.ExecutablePath, iconLocation, str2);
            Form1.CreateStartShortCut(Application.ExecutablePath, Path.GetFileNameWithoutExtension(str2), iconLocation, str2);
          }
          catch
          {
          }
        }
        System.IO.File.WriteAllText("ver", contents);
        Process.Start(new ProcessStartInfo(str2)
        {
          WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath),
          Arguments = contents
        });
      }
      else
      {
        string str1 = CommonVar.installPath;
        if (str1 == null)
        {
          FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
          {
            Description = "Please select the directory in which the application should be installed. If you chose to install in Program Files, the updater will ask you for admin permissions."
          };
          if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            str1 = folderBrowserDialog.SelectedPath;
        }
        if (str1 != null)
        {
          if (!Form1.TestWritePermission(str1))
            return;
          string str2 = Path.Combine(str1, "Updater.exe");
          System.IO.File.WriteAllText(Path.Combine(str1, "ver"), "0");
          if (!System.IO.File.Exists(str2))
            System.IO.File.Copy(Application.ExecutablePath, str2, true);
          Process.Start(new ProcessStartInfo(str2)
          {
            WorkingDirectory = str1
          });
        }
      }
      this.Invoke((Delegate) new Action(((Form) this).Close));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.label1 = new Label();
      this.pictureBox1 = new PictureBox();
      this.pgBar = new ProgressBar();
      this.label2 = new Label();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.BackColor = Color.Transparent;
      this.label1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(27, 31);
      this.label1.Name = "label1";
      this.label1.Size = new Size(362, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Please wait while the installer updates your application...";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.pictureBox1.BackColor = Color.Transparent;
      this.pictureBox1.Image = (Image) Resources.squares;
      this.pictureBox1.Location = new Point(401, 41);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(45, 45);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.pgBar.BackColor = SystemColors.Control;
      this.pgBar.Location = new Point(30, 56);
      this.pgBar.Name = "pgBar";
      this.pgBar.Size = new Size(365, 23);
      this.pgBar.Style = ProgressBarStyle.Continuous;
      this.pgBar.TabIndex = 2;
      this.label2.BackColor = Color.FromArgb(0, 0, 64);
      this.label2.Dock = DockStyle.Top;
      this.label2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(456, 27);
      this.label2.TabIndex = 3;
      this.label2.Text = "    UPDATER";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) Resources.Back;
      this.ClientSize = new Size(456, 93);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.pgBar);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form1";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Installer";
      this.Load += new EventHandler(this.Form1_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
