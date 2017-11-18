using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000CF RID: 207
	public class c60797b4f8bfa489df1954dcdc88ad77d : RadForm
	{
		// Token: 0x06000734 RID: 1844 RVA: 0x0003D5F4 File Offset: 0x0003B7F4
		public c60797b4f8bfa489df1954dcdc88ad77d(string cfeefea196000bed18adf05bf7727db15, bool cb31ca6936d25ee8375ba9efd6bf62348)
		{
			this.c9b4199040e6eb8bfec0158f3733ad4ae = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19408);
			this.c209a4605eb9cdcc6048183f4c9e778f8 = c6faa5467be1a4874657b372a49b7c927.logo;
			this.c48d08a9785563def4929b4d631599cd6 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19412);
			this.cff89be58a87dcf8b5f19587eb5159049 = new PrivateFontCollection();
			base..ctor();
			this.c82b8091adcf720aa7a90631953c644c8();
			this.c8bf1c83e2c774deb1a302af01d60cd0c.Text = cfeefea196000bed18adf05bf7727db15;
			if (cb31ca6936d25ee8375ba9efd6bf62348)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d..ctor(string, bool)).MethodHandle;
				}
				base.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19416), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19420));
			}
			else
			{
				base.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19424), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19428));
			}
			this.c3d40ffdb403fedd495a85e0c040d1147 = new Timer
			{
				Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19432)
			};
			this.c3d40ffdb403fedd495a85e0c040d1147.Tick += this.cdc13f3e230d3484c2cb0667c567d126f;
			this.c3d40ffdb403fedd495a85e0c040d1147.Start();
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0003D6E4 File Offset: 0x0003B8E4
		public c60797b4f8bfa489df1954dcdc88ad77d(string cfeefea196000bed18adf05bf7727db15, Action c594146923b42642ebf4bf2a5cd943917, Action<Exception> c62f902d27574ffccbd029fee23622bc9)
		{
			c60797b4f8bfa489df1954dcdc88ad77d.cd975e09932c2febe217ae4acc69646e3 cd975e09932c2febe217ae4acc69646e = new c60797b4f8bfa489df1954dcdc88ad77d.cd975e09932c2febe217ae4acc69646e3();
			cd975e09932c2febe217ae4acc69646e.c594146923b42642ebf4bf2a5cd943917 = c594146923b42642ebf4bf2a5cd943917;
			cd975e09932c2febe217ae4acc69646e.c62f902d27574ffccbd029fee23622bc9 = c62f902d27574ffccbd029fee23622bc9;
			this..ctor(cfeefea196000bed18adf05bf7727db15, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19436) != 0);
			cd975e09932c2febe217ae4acc69646e.c4404a159870bf55bb6f111e66e59e82d = this;
			Task.Run(new Action(cd975e09932c2febe217ae4acc69646e.c4670d8c076c4b83ac083b6ed3c520b53));
			base.ShowDialog();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0003D738 File Offset: 0x0003B938
		public void cc5957c0b466d791dc387469fda39883c()
		{
			this.cda6b865a21f15aef8ebc2cc36d9120ab = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19068) != 0);
			try
			{
				base.BeginInvoke(new Action(base.Close));
			}
			catch
			{
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0003D784 File Offset: 0x0003B984
		public void cf1cbd6c013fa578db4f915226e6472b7(int cdc2df70fc41ec746908194e6c2324250)
		{
			c60797b4f8bfa489df1954dcdc88ad77d.c9ef700e1961a5848c38068364aef5b25 c9ef700e1961a5848c38068364aef5b = new c60797b4f8bfa489df1954dcdc88ad77d.c9ef700e1961a5848c38068364aef5b25();
			c9ef700e1961a5848c38068364aef5b.c4404a159870bf55bb6f111e66e59e82d = this;
			c9ef700e1961a5848c38068364aef5b.cdc2df70fc41ec746908194e6c2324250 = cdc2df70fc41ec746908194e6c2324250;
			try
			{
				base.Invoke(new Action(c9ef700e1961a5848c38068364aef5b.c7968a81588aef2578b54bce7366fd895));
			}
			catch
			{
			}
		}

		// Token: 0x06000738 RID: 1848
		[DllImport("gdi32.dll", EntryPoint = "AddFontMemResourceEx")]
		private static extern IntPtr c9fbf9c64153f9d05835c0112f1f1b5bb(IntPtr c1f169638dd2f48a8bfaf4a227e83dbbe, uint c206f77846c1aa761a0b0190df38b86ed, IntPtr c1c2b0c1403aec529c67c3da4a085c020, [In] ref uint c9475709354da6f2b4f874a1fd8a9c22f);

		// Token: 0x06000739 RID: 1849 RVA: 0x0003D7D0 File Offset: 0x0003B9D0
		private void c98778cb347fd0bcfd8e9c88163224629()
		{
			this.c53b449beab125663cc288daa17916502 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19072);
			if (this.c53b449beab125663cc288daa17916502 == this.cb72998a5432e19863295febdd04b9d5d.Count)
			{
				for (;;)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d.c98778cb347fd0bcfd8e9c88163224629()).MethodHandle;
				}
				this.c53b449beab125663cc288daa17916502 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19076);
			}
			if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cb72998a5432e19863295febdd04b9d5d[this.c53b449beab125663cc288daa17916502].Text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11210)))
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
				this.c98778cb347fd0bcfd8e9c88163224629();
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0003D86C File Offset: 0x0003BA6C
		private void c4be26d4d4976fb4269f067e375726f03(object cd7b28952603b35a45c555982e677363a, FormClosingEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c3d40ffdb403fedd495a85e0c040d1147.Stop();
			try
			{
				this.c6dfddf0cdda0232354bc9a3f374808e1.Dispose();
				this.cff89be58a87dcf8b5f19587eb5159049.Dispose();
			}
			catch
			{
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0003D8B0 File Offset: 0x0003BAB0
		private void cf95213694c0d134ac96086b2eb248b01(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.FormElement.TitleBar.CloseButton.Visibility = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19080);
			this.caf43b0816cb9cfbaf9c97aeab60c9c3c.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19084);
			this.caf43b0816cb9cfbaf9c97aeab60c9c3c.Start();
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0003D904 File Offset: 0x0003BB04
		private void c088f21b6f5e5aa682d194e5d3fd433c1(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c6663afbaedcf5310c20e3ccc49505ce3.cae83e75b541f1dda9d43a148b59fa365 = (cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19088);
			this.c6663afbaedcf5310c20e3ccc49505ce3.cb16116662e3a8236c6a68ec685d11a59 = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19096), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19100));
			this.c6663afbaedcf5310c20e3ccc49505ce3.BackColor = Color.Transparent;
			this.c6663afbaedcf5310c20e3ccc49505ce3.c73ce297cbfb29ef5051ff1843029f73b = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19104) != 0);
			this.c6663afbaedcf5310c20e3ccc49505ce3.c7efec4a1ea06adc0a6c671b2079a2607 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19108);
			this.c6663afbaedcf5310c20e3ccc49505ce3.c9250165d8b7b8d7b7ed5f5e67f5e8192 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19112);
			this.c6663afbaedcf5310c20e3ccc49505ce3.c23fbeac2e1953c7f7a41021beb474f3e = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19116);
			this.c6663afbaedcf5310c20e3ccc49505ce3.ca949dc179b4669f635c5dc702034156f = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19120);
			this.c6663afbaedcf5310c20e3ccc49505ce3.c1c3a2846f4ede6cd2085bf69650e3270 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19124);
			this.c6663afbaedcf5310c20e3ccc49505ce3.SendToBack();
			byte[] contb = c6faa5467be1a4874657b372a49b7c927.contb;
			IntPtr intPtr = Marshal.AllocCoTaskMem((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(contb));
			Marshal.Copy(contb, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19128), intPtr, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(contb));
			uint num = (uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19132);
			this.cff89be58a87dcf8b5f19587eb5159049.AddMemoryFont(intPtr, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c6faa5467be1a4874657b372a49b7c927.contb));
			c60797b4f8bfa489df1954dcdc88ad77d.c9fbf9c64153f9d05835c0112f1f1b5bb(intPtr, (uint)((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(c6faa5467be1a4874657b372a49b7c927.contb)), IntPtr.Zero, ref num);
			Marshal.FreeCoTaskMem(intPtr);
			this.c6dfddf0cdda0232354bc9a3f374808e1 = new Font(this.cff89be58a87dcf8b5f19587eb5159049.Families[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19136)], cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19140));
			Graphics graphics = base.CreateGraphics();
			try
			{
				SizeF sizeF = base.CreateGraphics().MeasureString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69155), this.c6dfddf0cdda0232354bc9a3f374808e1);
				float num2 = (float)(this.c6663afbaedcf5310c20e3ccc49505ce3.Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19144)) - sizeF.Height / cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19148);
				this.cb72998a5432e19863295febdd04b9d5d = new List<RadLabel>();
				List<SizeF> list = new List<SizeF>();
				string text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69155);
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19152); i < text.Length; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19156))
				{
					list.Add(graphics.MeasureString(text[i].ToString(), this.c6dfddf0cdda0232354bc9a3f374808e1));
				}
				for (;;)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d.c088f21b6f5e5aa682d194e5d3fd433c1(object, EventArgs)).MethodHandle;
				}
				float num3 = (float)(base.Width / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19160));
				IEnumerable<SizeF> source = list;
				Func<SizeF, float> selector;
				if ((selector = c60797b4f8bfa489df1954dcdc88ad77d.<>c.c7a55b29771e6d48c9f768e2958763ca5) == null)
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
					selector = (c60797b4f8bfa489df1954dcdc88ad77d.<>c.c7a55b29771e6d48c9f768e2958763ca5 = new Func<SizeF, float>(c60797b4f8bfa489df1954dcdc88ad77d.<>c.cdfab1996eb8651828de2a4469aa3481e.c760f3edfdd282a99c9ae9c37711b752d));
				}
				float num4 = num3 - source.Sum(selector) / cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19164);
				int num5 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19168);
				text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69155);
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19172); i < text.Length; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19196))
				{
					char c = text[i];
					RadLabel radLabel = new RadLabel
					{
						Text = c.ToString(),
						Font = this.c6dfddf0cdda0232354bc9a3f374808e1,
						AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19176) != 0),
						ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19180), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19184), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19188)),
						BackColor = Color.Transparent
					};
					radLabel.Left = (int)num4;
					num4 += list[num5].Width;
					radLabel.Top = (int)num2;
					radLabel.Size = new Size((int)list[num5].Width, (int)list[num5].Height);
					base.Controls.Add(radLabel);
					radLabel.Parent = this.c6663afbaedcf5310c20e3ccc49505ce3;
					this.cb72998a5432e19863295febdd04b9d5d.Add(radLabel);
					radLabel.BringToFront();
					num5 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19192);
				}
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (graphics != null)
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
					((IDisposable)graphics).Dispose();
				}
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0003DD80 File Offset: 0x0003BF80
		private void ceabab1dc01b4e7a256304a13fdbe4609(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0003DD90 File Offset: 0x0003BF90
		private void cd70e46f4f638339baba9b755af035561(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c8bf1c83e2c774deb1a302af01d60cd0c.Location = new Point(base.Width / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19200) - this.c8bf1c83e2c774deb1a302af01d60cd0c.Width / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19204), this.c8bf1c83e2c774deb1a302af01d60cd0c.Location.Y);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0003DDF0 File Offset: 0x0003BFF0
		private void c2eb34dfee140a248326787ebdd0ee79d(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			RadLabel radLabel = this.cb72998a5432e19863295febdd04b9d5d[this.c53b449beab125663cc288daa17916502];
			if (this.c9b4199040e6eb8bfec0158f3733ad4ae != this.c53b449beab125663cc288daa17916502)
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d.c2eb34dfee140a248326787ebdd0ee79d(object, EventArgs)).MethodHandle;
				}
				this.c48d08a9785563def4929b4d631599cd6 *= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19208);
				this.c9fa8aec31e7e7a74fa17d51e6c12f632 = radLabel.Top;
				radLabel.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19212), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19216), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19220));
				if (this.c53b449beab125663cc288daa17916502 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19224))
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
					this.cb72998a5432e19863295febdd04b9d5d[this.c53b449beab125663cc288daa17916502 - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19228)].LabelElement.Opacity = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(19232);
				}
				this.c9b4199040e6eb8bfec0158f3733ad4ae = this.c53b449beab125663cc288daa17916502;
			}
			radLabel.Top += this.c48d08a9785563def4929b4d631599cd6;
			if (this.c9fa8aec31e7e7a74fa17d51e6c12f632 - radLabel.Top > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19240))
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
				this.c48d08a9785563def4929b4d631599cd6 *= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19244);
			}
			if (this.c9fa8aec31e7e7a74fa17d51e6c12f632 == radLabel.Top)
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
				radLabel.Font = this.c6dfddf0cdda0232354bc9a3f374808e1;
				if (this.c53b449beab125663cc288daa17916502 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19248))
				{
					for (;;)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					this.cb72998a5432e19863295febdd04b9d5d[this.c53b449beab125663cc288daa17916502 - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19252)].LabelElement.Opacity = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(19256);
				}
				radLabel.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19264), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19268), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19272));
				this.c98778cb347fd0bcfd8e9c88163224629();
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0003E028 File Offset: 0x0003C228
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c66944218dc6924b147fbc6b0f72a424f = new Container();
			this.c8bf1c83e2c774deb1a302af01d60cd0c = new RadLabel();
			this.c85ea689075639e9b68e63c0631f9c4ba = new RadProgressBar();
			this.caf43b0816cb9cfbaf9c97aeab60c9c3c = new Timer(this.c66944218dc6924b147fbc6b0f72a424f);
			this.c6663afbaedcf5310c20e3ccc49505ce3 = new cd5c09c7b57f3aa6b224c611a72ca3b10();
			this.c8bf1c83e2c774deb1a302af01d60cd0c.BeginInit();
			this.c85ea689075639e9b68e63c0631f9c4ba.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c8bf1c83e2c774deb1a302af01d60cd0c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19276), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19280));
			this.c8bf1c83e2c774deb1a302af01d60cd0c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69186);
			this.c8bf1c83e2c774deb1a302af01d60cd0c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19288));
			this.c8bf1c83e2c774deb1a302af01d60cd0c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19292);
			this.c8bf1c83e2c774deb1a302af01d60cd0c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69186);
			this.c8bf1c83e2c774deb1a302af01d60cd0c.SizeChanged += this.cd70e46f4f638339baba9b755af035561;
			this.c85ea689075639e9b68e63c0631f9c4ba.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19296), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19300));
			this.c85ea689075639e9b68e63c0631f9c4ba.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43605);
			this.c85ea689075639e9b68e63c0631f9c4ba.ShowProgressIndicators = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19304) != 0);
			this.c85ea689075639e9b68e63c0631f9c4ba.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19308), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19312));
			this.c85ea689075639e9b68e63c0631f9c4ba.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19316);
			this.c85ea689075639e9b68e63c0631f9c4ba.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43636);
			this.caf43b0816cb9cfbaf9c97aeab60c9c3c.Tick += this.c2eb34dfee140a248326787ebdd0ee79d;
			this.c6663afbaedcf5310c20e3ccc49505ce3.c73ce297cbfb29ef5051ff1843029f73b = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19320) != 0);
			this.c6663afbaedcf5310c20e3ccc49505ce3.cb16116662e3a8236c6a68ec685d11a59 = Color.DarkGray;
			this.c6663afbaedcf5310c20e3ccc49505ce3.c7efec4a1ea06adc0a6c671b2079a2607 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19324);
			this.c6663afbaedcf5310c20e3ccc49505ce3.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19328), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19332));
			this.c6663afbaedcf5310c20e3ccc49505ce3.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69207);
			this.c6663afbaedcf5310c20e3ccc49505ce3.c23fbeac2e1953c7f7a41021beb474f3e = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19336);
			this.c6663afbaedcf5310c20e3ccc49505ce3.c9250165d8b7b8d7b7ed5f5e67f5e8192 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19340);
			this.c6663afbaedcf5310c20e3ccc49505ce3.c1c3a2846f4ede6cd2085bf69650e3270 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19344);
			this.c6663afbaedcf5310c20e3ccc49505ce3.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19348), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19352));
			this.c6663afbaedcf5310c20e3ccc49505ce3.ca949dc179b4669f635c5dc702034156f = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19356);
			this.c6663afbaedcf5310c20e3ccc49505ce3.cae83e75b541f1dda9d43a148b59fa365 = (cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19360);
			this.c6663afbaedcf5310c20e3ccc49505ce3.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19364);
			this.c6663afbaedcf5310c20e3ccc49505ce3.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69207);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19368), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(19372));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19376);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19380), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19384));
			base.Controls.Add(this.c6663afbaedcf5310c20e3ccc49505ce3);
			base.Controls.Add(this.c85ea689075639e9b68e63c0631f9c4ba);
			base.Controls.Add(this.c8bf1c83e2c774deb1a302af01d60cd0c);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19388);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69236);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19392) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19396) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19400);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(69251);
			base.FormClosing += this.c4be26d4d4976fb4269f067e375726f03;
			base.Load += this.cf95213694c0d134ac96086b2eb248b01;
			base.Shown += this.c088f21b6f5e5aa682d194e5d3fd433c1;
			base.SizeChanged += this.ceabab1dc01b4e7a256304a13fdbe4609;
			this.c8bf1c83e2c774deb1a302af01d60cd0c.EndInit();
			this.c85ea689075639e9b68e63c0631f9c4ba.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(19404) != 0);
			base.PerformLayout();
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0003E490 File Offset: 0x0003C690
		[CompilerGenerated]
		private void cdc13f3e230d3484c2cb0667c567d126f(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			if (this.cda6b865a21f15aef8ebc2cc36d9120ab)
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d.cdc13f3e230d3484c2cb0667c567d126f(object, EventArgs)).MethodHandle;
				}
				this.cc5957c0b466d791dc387469fda39883c();
			}
		}

		// Token: 0x0400044B RID: 1099
		private const string c5c6e7ed8ff852e2481f72d1583e57150 = "WiiU USB Helper";

		// Token: 0x0400044C RID: 1100
		private volatile bool cda6b865a21f15aef8ebc2cc36d9120ab;

		// Token: 0x0400044D RID: 1101
		private Font c6dfddf0cdda0232354bc9a3f374808e1;

		// Token: 0x0400044E RID: 1102
		private int c53b449beab125663cc288daa17916502;

		// Token: 0x0400044F RID: 1103
		private List<RadLabel> cb72998a5432e19863295febdd04b9d5d;

		// Token: 0x04000450 RID: 1104
		private int c9b4199040e6eb8bfec0158f3733ad4ae;

		// Token: 0x04000451 RID: 1105
		private Image c209a4605eb9cdcc6048183f4c9e778f8;

		// Token: 0x04000452 RID: 1106
		private int c48d08a9785563def4929b4d631599cd6;

		// Token: 0x04000453 RID: 1107
		private int c9fa8aec31e7e7a74fa17d51e6c12f632;

		// Token: 0x04000454 RID: 1108
		private Timer c3d40ffdb403fedd495a85e0c040d1147;

		// Token: 0x04000455 RID: 1109
		private PrivateFontCollection cff89be58a87dcf8b5f19587eb5159049;

		// Token: 0x04000456 RID: 1110
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000457 RID: 1111
		private RadLabel c8bf1c83e2c774deb1a302af01d60cd0c;

		// Token: 0x04000458 RID: 1112
		private RadProgressBar c85ea689075639e9b68e63c0631f9c4ba;

		// Token: 0x04000459 RID: 1113
		private Timer caf43b0816cb9cfbaf9c97aeab60c9c3c;

		// Token: 0x0400045A RID: 1114
		private cd5c09c7b57f3aa6b224c611a72ca3b10 c6663afbaedcf5310c20e3ccc49505ce3;

		// Token: 0x0200016B RID: 363
		[CompilerGenerated]
		private sealed class cd975e09932c2febe217ae4acc69646e3
		{
			// Token: 0x060009AF RID: 2479 RVA: 0x00060CF4 File Offset: 0x0005EEF4
			internal void c4670d8c076c4b83ac083b6ed3c520b53()
			{
				try
				{
					this.c594146923b42642ebf4bf2a5cd943917();
				}
				catch (Exception obj)
				{
					Action<Exception> action = this.c62f902d27574ffccbd029fee23622bc9;
					if (action == null)
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
						if (!true)
						{
							RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d.cd975e09932c2febe217ae4acc69646e3.c4670d8c076c4b83ac083b6ed3c520b53()).MethodHandle;
						}
					}
					else
					{
						action(obj);
					}
				}
				this.c4404a159870bf55bb6f111e66e59e82d.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x04000748 RID: 1864
			public Action c594146923b42642ebf4bf2a5cd943917;

			// Token: 0x04000749 RID: 1865
			public Action<Exception> c62f902d27574ffccbd029fee23622bc9;

			// Token: 0x0400074A RID: 1866
			public c60797b4f8bfa489df1954dcdc88ad77d c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200016C RID: 364
		[CompilerGenerated]
		private sealed class c9ef700e1961a5848c38068364aef5b25
		{
			// Token: 0x060009B1 RID: 2481 RVA: 0x00060D68 File Offset: 0x0005EF68
			internal void c7968a81588aef2578b54bce7366fd895()
			{
				if (this.cdc2df70fc41ec746908194e6c2324250 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30776))
				{
					for (;;)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(c60797b4f8bfa489df1954dcdc88ad77d.c9ef700e1961a5848c38068364aef5b25.c7968a81588aef2578b54bce7366fd895()).MethodHandle;
					}
					this.cdc2df70fc41ec746908194e6c2324250 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30780);
				}
				this.c4404a159870bf55bb6f111e66e59e82d.c85ea689075639e9b68e63c0631f9c4ba.Value1 = this.cdc2df70fc41ec746908194e6c2324250;
			}

			// Token: 0x0400074B RID: 1867
			public int cdc2df70fc41ec746908194e6c2324250;

			// Token: 0x0400074C RID: 1868
			public c60797b4f8bfa489df1954dcdc88ad77d c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
