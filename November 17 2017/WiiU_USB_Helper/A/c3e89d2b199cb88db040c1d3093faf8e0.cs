using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WMPLib;

namespace A
{
	// Token: 0x020000BF RID: 191
	public partial class c3e89d2b199cb88db040c1d3093faf8e0 : Form
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x0003346C File Offset: 0x0003166C
		public c3e89d2b199cb88db040c1d3093faf8e0(c4c1cf20119750bfee2a0bb499f990883 c85fe5f831da40cbc431d1c9e9d5b7035)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			base.Region = Region.FromHrgn(c3e89d2b199cb88db040c1d3093faf8e0.c388289584d9fae83921f1863a3e30313(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15544), base.Width, base.Height, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15548), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15552)));
			this.c1e46d70f6d24492d9c5c673c1d226323 = c85fe5f831da40cbc431d1c9e9d5b7035;
			try
			{
				this.c349124be9afdb0cce6f81854673c5b78 = this.cde1f5bab75cd285618406d4e8c84eb3c.Left;
				this.cd472e7f2777db76011c51b50e8217625.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15556);
				this.cd472e7f2777db76011c51b50e8217625.Start();
				c866035f717c1c145e269422264e8f519 c866035f717c1c145e269422264e8f = new c866035f717c1c145e269422264e8f519();
				string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59625);
				object arg;
				if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c1e46d70f6d24492d9c5c673c1d226323.ToInject.Region, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3759)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c3e89d2b199cb88db040c1d3093faf8e0..ctor(c4c1cf20119750bfee2a0bb499f990883)).MethodHandle;
					}
					arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3776);
				}
				else
				{
					arg = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3771);
				}
				this.c1d162cb6d8e7a645a3bc05b229a1c0fc = c32037f571be75ec9395b718eab8129e7.cd24593c859565ebb8c9faabbc5c75bef(Image.FromStream(new MemoryStream(c866035f717c1c145e269422264e8f.cd13dfe553208f0b407836d345c6897d0(string.Format(format, arg, this.c1e46d70f6d24492d9c5c673c1d226323.ToInject.ProductId)))));
				this.c1d162cb6d8e7a645a3bc05b229a1c0fc.SetResolution(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15560), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15564));
				this.caf43b0816cb9cfbaf9c97aeab60c9c3c.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15568);
				this.caf43b0816cb9cfbaf9c97aeab60c9c3c.Start();
			}
			catch
			{
			}
			try
			{
				this.cc232b19312386f0e5ad9c5f2750e8caf = c264a2ea08d3ec2547037749b11bf2d0a.cd24593c859565ebb8c9faabbc5c75bef(Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59712)))));
				new ComAwareEventInfo(Type.GetTypeFromHandle(c481c252751fe8828b5c9a5ad622f488f.cde4d1aeffe0e705b07e1b3d74e931465()), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59785)).AddEventHandler(this.cc232b19312386f0e5ad9c5f2750e8caf, new _WMPOCXEvents_PlayStateChangeEventHandler(this, (UIntPtr)ldftn(cdc13f3e230d3484c2cb0667c567d126f)));
			}
			catch
			{
			}
		}

		// Token: 0x060006BE RID: 1726
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr c388289584d9fae83921f1863a3e30313(int cadb31f4055f01bbd77076cd02b27ef41, int c5e1c3ef0f3ef1167f1491b16ef19995c, int c6603e1a9d11a44ba6daa1b47c1c89f01, int c2a447a3030aad7a38677ab4b559e1e52, int cbde125ca01037eda0b794a07e37ebc29, int ca74434916c341744e00c977222e9a37a);

		// Token: 0x060006BF RID: 1727 RVA: 0x000336C4 File Offset: 0x000318C4
		private void c3d2f00d3af0c8aa221b59a13734066de(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			try
			{
				if (c3c9260886a6db15de49329a9f5b9836c.ToggleState == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15164))
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(c3e89d2b199cb88db040c1d3093faf8e0.c3d2f00d3af0c8aa221b59a13734066de(object, StateChangedEventArgs)).MethodHandle;
					}
					this.cc42b018aee9a0a7f4d9fd258d504a302();
				}
				else
				{
					this.cc232b19312386f0e5ad9c5f2750e8caf.controls.stop();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00033728 File Offset: 0x00031928
		private void ca968d5d59e1db35438e5cb28f51d4bf8(object cd7b28952603b35a45c555982e677363a, FormClosingEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			try
			{
				this.cc232b19312386f0e5ad9c5f2750e8caf.controls.stop();
				this.cc232b19312386f0e5ad9c5f2750e8caf.close();
			}
			catch
			{
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00033768 File Offset: 0x00031968
		private void ca62a611db70a405b857e993aba83b054(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c3e89d2b199cb88db040c1d3093faf8e0.c01c2ca1b82ced3f16a070ce74d7822e2 c01c2ca1b82ced3f16a070ce74d7822e = new c3e89d2b199cb88db040c1d3093faf8e0.c01c2ca1b82ced3f16a070ce74d7822e2();
			c01c2ca1b82ced3f16a070ce74d7822e.c4404a159870bf55bb6f111e66e59e82d = this;
			this.c1e46d70f6d24492d9c5c673c1d226323.cf17bde800c5bc0fdb2c1a7449fe20155 += this.cfbeebe37f4f5c14e68cce3a21ec62c35;
			this.c1e46d70f6d24492d9c5c673c1d226323.c4afed2c174634df66f49254235a75930 += this.c3d6687b246167b0b0cf8f0dfe31626de;
			c01c2ca1b82ced3f16a070ce74d7822e.c832bb5717a513a562cc398fed110b06a = new List<RadLabel>();
			IEnumerator enumerator = base.Controls.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object c0d6c37d812d5d4b610705a6421056252 = enumerator.Current;
					if (c38174b97ad843d8e09893661e5d680b2.c0b398ab350e72b0d64d512bae8520b85(c0d6c37d812d5d4b610705a6421056252) != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c3e89d2b199cb88db040c1d3093faf8e0.ca62a611db70a405b857e993aba83b054(object, EventArgs)).MethodHandle;
						}
						c01c2ca1b82ced3f16a070ce74d7822e.c832bb5717a513a562cc398fed110b06a.Add(c38174b97ad843d8e09893661e5d680b2.c0b398ab350e72b0d64d512bae8520b85(c0d6c37d812d5d4b610705a6421056252));
					}
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
				IDisposable disposable = c2f4016fa04d8c2b2a9dba60e295715d5.c0b398ab350e72b0d64d512bae8520b85(enumerator);
				if (disposable != null)
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
					disposable.Dispose();
				}
			}
			c01c2ca1b82ced3f16a070ce74d7822e.c832bb5717a513a562cc398fed110b06a.Reverse();
			string[] cb36ab33fd8ccca41b540a9363d46e = this.c1e46d70f6d24492d9c5c673c1d226323.cb36ab33fd8ccca41b540a9363d46e846;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15168); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15180); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15176))
			{
				c01c2ca1b82ced3f16a070ce74d7822e.c832bb5717a513a562cc398fed110b06a[i].Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59088), i + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15172), cb36ab33fd8ccca41b540a9363d46e[i]);
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
			this.c1e46d70f6d24492d9c5c673c1d226323.cce1f142fb0ccce87121f70ee9e5e86ec += c01c2ca1b82ced3f16a070ce74d7822e.c53a3476ec492dc379bd10c12605f85c8;
			this.c1e46d70f6d24492d9c5c673c1d226323.c25dba10ffdbe2b55fe4809bdf44094f2();
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000338FC File Offset: 0x00031AFC
		private string c38127d395e5c57790d19fc6f3d58c2d6()
		{
			return new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59121), this.c1e46d70f6d24492d9c5c673c1d226323.ToInject.cae8945ad667defbe7c150465d2c8aaba));
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0003393C File Offset: 0x00031B3C
		private string c311081bce376d71dfe182b9e27b95f0e(string c1b30e39d83ce129e358c7cee6b393f7b)
		{
			HtmlDocument htmlDocument = new HtmlDocument();
			htmlDocument.LoadHtml(new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(c1b30e39d83ce129e358c7cee6b393f7b));
			return htmlDocument.DocumentNode.Descendants(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59140)).First<HtmlNode>().Attributes[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59151)].Value;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000339A4 File Offset: 0x00031BA4
		private void cc42b018aee9a0a7f4d9fd258d504a302()
		{
			Task.Run(new Action(this.c786013f59c01d5b01da5c41e1aa4aea6));
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000339C8 File Offset: 0x00031BC8
		private void c744c7cf28d1a2684be86c2b1fc374e55(object cd7b28952603b35a45c555982e677363a, PaintEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c1d162cb6d8e7a645a3bc05b229a1c0fc == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3e89d2b199cb88db040c1d3093faf8e0.c744c7cf28d1a2684be86c2b1fc374e55(object, PaintEventArgs)).MethodHandle;
				}
				return;
			}
			Graphics graphics = cdf15457ee4816989343b6e6e96dd4cfe.Graphics;
			graphics.TranslateTransform(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15184), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15188));
			graphics.RotateTransform((float)this.c3342cbd830131ac33d7febcd0918fc29);
			graphics.DrawImage(this.c1d162cb6d8e7a645a3bc05b229a1c0fc, new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15192), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15196)));
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00033A48 File Offset: 0x00031C48
		private void c2eb34dfee140a248326787ebdd0ee79d(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c3342cbd830131ac33d7febcd0918fc29 = (this.c3342cbd830131ac33d7febcd0918fc29 + this.cd5f9ff715fc8c2a6e742720c988f4926) % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15200);
			this.c1e664eedc77244516df32f78879cbd6a.Refresh();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00033A80 File Offset: 0x00031C80
		private void c8dbf7c4d8121a99fae4f49058bae7d40(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.cde1f5bab75cd285618406d4e8c84eb3c.Left - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15204) >= this.c349124be9afdb0cce6f81854673c5b78)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3e89d2b199cb88db040c1d3093faf8e0.c8dbf7c4d8121a99fae4f49058bae7d40(object, EventArgs)).MethodHandle;
				}
				if (this.cde1f5bab75cd285618406d4e8c84eb3c.Left + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15208) <= this.c349124be9afdb0cce6f81854673c5b78 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15212))
				{
					goto IL_7F;
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
			this.c60986f3bb919a4c9fcc376a9f27cc3af *= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15216);
			IL_7F:
			this.cde1f5bab75cd285618406d4e8c84eb3c.Left += this.c60986f3bb919a4c9fcc376a9f27cc3af;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00033B70 File Offset: 0x00031D70
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c66944218dc6924b147fbc6b0f72a424f = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cb1d7493f791f48c2917f09c33ea65904.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.cde1f5bab75cd285618406d4e8c84eb3c = new PictureBox();
			this.c362e39f066aef56acd25812b83e7da57 = new RadLabel();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.caf43b0816cb9cfbaf9c97aeab60c9c3c = new Timer(this.c66944218dc6924b147fbc6b0f72a424f);
			this.c1e664eedc77244516df32f78879cbd6a = new PictureBox();
			this.cd472e7f2777db76011c51b50e8217625 = new Timer(this.c66944218dc6924b147fbc6b0f72a424f);
			this.c3e59bee63412a9e620fccb76ef2a7f5f = new RadCheckBox();
			((ISupportInitialize)this.cde1f5bab75cd285618406d4e8c84eb3c).BeginInit();
			this.c362e39f066aef56acd25812b83e7da57.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).BeginInit();
			this.c3e59bee63412a9e620fccb76ef2a7f5f.BeginInit();
			base.SuspendLayout();
			this.cde1f5bab75cd285618406d4e8c84eb3c.BackColor = Color.Transparent;
			this.cde1f5bab75cd285618406d4e8c84eb3c.Image = c6faa5467be1a4874657b372a49b7c927.icnArrow;
			this.cde1f5bab75cd285618406d4e8c84eb3c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15220), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15224));
			this.cde1f5bab75cd285618406d4e8c84eb3c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59158);
			this.cde1f5bab75cd285618406d4e8c84eb3c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15228), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15232));
			this.cde1f5bab75cd285618406d4e8c84eb3c.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15236);
			this.cde1f5bab75cd285618406d4e8c84eb3c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15240);
			this.cde1f5bab75cd285618406d4e8c84eb3c.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15244) != 0);
			this.c362e39f066aef56acd25812b83e7da57.BackColor = Color.Transparent;
			this.c362e39f066aef56acd25812b83e7da57.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59177), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15248), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15252), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15256), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15260));
			this.c362e39f066aef56acd25812b83e7da57.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15264), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15268), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15272));
			this.c362e39f066aef56acd25812b83e7da57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15276), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15280));
			this.c362e39f066aef56acd25812b83e7da57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42983);
			this.c362e39f066aef56acd25812b83e7da57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15288));
			this.c362e39f066aef56acd25812b83e7da57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15292);
			this.c362e39f066aef56acd25812b83e7da57.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59202);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BackColor = Color.Transparent;
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59177), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15296), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15300), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15304), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15308));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15316), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15320));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15324), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15328));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15332), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15336));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15340);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59259);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BackColor = Color.Transparent;
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59177), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15344), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15348), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15352), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15356));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15360), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15364), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15368));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15372), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15376));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15380), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15384));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59320);
			this.c4553ed186725b714efcccc71bbe10a0f.BackColor = Color.Transparent;
			this.c4553ed186725b714efcccc71bbe10a0f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59177), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15392), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15396), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15400), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15404));
			this.c4553ed186725b714efcccc71bbe10a0f.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15408), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15412), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15416));
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15420), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15424));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15428), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15432));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15436);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59379);
			this.caf43b0816cb9cfbaf9c97aeab60c9c3c.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15440);
			this.caf43b0816cb9cfbaf9c97aeab60c9c3c.Tick += this.c2eb34dfee140a248326787ebdd0ee79d;
			this.c1e664eedc77244516df32f78879cbd6a.BackColor = Color.Transparent;
			this.c1e664eedc77244516df32f78879cbd6a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15444), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15448));
			this.c1e664eedc77244516df32f78879cbd6a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43700);
			this.c1e664eedc77244516df32f78879cbd6a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15452), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15456));
			this.c1e664eedc77244516df32f78879cbd6a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15460);
			this.c1e664eedc77244516df32f78879cbd6a.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15464) != 0);
			this.c1e664eedc77244516df32f78879cbd6a.Paint += this.c744c7cf28d1a2684be86c2b1fc374e55;
			this.cd472e7f2777db76011c51b50e8217625.Tick += this.c8dbf7c4d8121a99fae4f49058bae7d40;
			this.c3e59bee63412a9e620fccb76ef2a7f5f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15468), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15472));
			this.c3e59bee63412a9e620fccb76ef2a7f5f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59444);
			this.c3e59bee63412a9e620fccb76ef2a7f5f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15476), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15480));
			this.c3e59bee63412a9e620fccb76ef2a7f5f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15484);
			this.c3e59bee63412a9e620fccb76ef2a7f5f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59477);
			this.c3e59bee63412a9e620fccb76ef2a7f5f.ToggleStateChanged += new StateChangedEventHandler(this.c3d2f00d3af0c8aa221b59a13734066de);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15488), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15492));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15496);
			this.BackgroundImage = c6faa5467be1a4874657b372a49b7c927.bg;
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15500), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15504));
			base.Controls.Add(this.c3e59bee63412a9e620fccb76ef2a7f5f);
			base.Controls.Add(this.cde1f5bab75cd285618406d4e8c84eb3c);
			base.Controls.Add(this.c362e39f066aef56acd25812b83e7da57);
			base.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			base.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			base.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			base.Controls.Add(this.c1e664eedc77244516df32f78879cbd6a);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15508);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59554);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15512);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59597);
			base.FormClosing += this.ca968d5d59e1db35438e5cb28f51d4bf8;
			base.Shown += this.ca62a611db70a405b857e993aba83b054;
			((ISupportInitialize)this.cde1f5bab75cd285618406d4e8c84eb3c).EndInit();
			this.c362e39f066aef56acd25812b83e7da57.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).EndInit();
			this.c3e59bee63412a9e620fccb76ef2a7f5f.EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15516) != 0);
			base.PerformLayout();
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000344D4 File Offset: 0x000326D4
		[CompilerGenerated]
		private void cdc13f3e230d3484c2cb0667c567d126f(int cb0d7b0b893a41a39e281ddc32fc698bd)
		{
			if (this.cc232b19312386f0e5ad9c5f2750e8caf.playState == (WMPPlayState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15520))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c3e89d2b199cb88db040c1d3093faf8e0.cdc13f3e230d3484c2cb0667c567d126f(int)).MethodHandle;
				}
				this.cc42b018aee9a0a7f4d9fd258d504a302();
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00034514 File Offset: 0x00032714
		[CompilerGenerated]
		private void cfbeebe37f4f5c14e68cce3a21ec62c35(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			base.Invoke(new MethodInvoker(this.cf11b11ec4462b87a5064859afd8eaf76));
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00034538 File Offset: 0x00032738
		[CompilerGenerated]
		private void cf11b11ec4462b87a5064859afd8eaf76()
		{
			base.Close();
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0003454C File Offset: 0x0003274C
		[CompilerGenerated]
		private void c3d6687b246167b0b0cf8f0dfe31626de(object cb0d7b0b893a41a39e281ddc32fc698bd, Exception c08b391577522100e1046cacdb2283fb0)
		{
			c3e89d2b199cb88db040c1d3093faf8e0.c17150bf57828385d95838312f08db49f c17150bf57828385d95838312f08db49f = new c3e89d2b199cb88db040c1d3093faf8e0.c17150bf57828385d95838312f08db49f();
			c17150bf57828385d95838312f08db49f.c4404a159870bf55bb6f111e66e59e82d = this;
			c17150bf57828385d95838312f08db49f.c08b391577522100e1046cacdb2283fb0 = c08b391577522100e1046cacdb2283fb0;
			base.Invoke(new MethodInvoker(c17150bf57828385d95838312f08db49f.c6a3bbd164e93712873dc646595da85e7));
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00034584 File Offset: 0x00032784
		[CompilerGenerated]
		private void c786013f59c01d5b01da5c41e1aa4aea6()
		{
			try
			{
				this.cc232b19312386f0e5ad9c5f2750e8caf.controls.stop();
				if (this.c3dab97613008914b2f5678ebbbcbecd6 == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c3e89d2b199cb88db040c1d3093faf8e0.c786013f59c01d5b01da5c41e1aa4aea6()).MethodHandle;
					}
					HtmlDocument htmlDocument = new HtmlDocument();
					this.c3dab97613008914b2f5678ebbbcbecd6 = new List<string>();
					htmlDocument.LoadHtml(new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(this.c38127d395e5c57790d19fc6f3d58c2d6()));
					List<string> list = this.c3dab97613008914b2f5678ebbbcbecd6;
					IEnumerable<HtmlNode> source = htmlDocument.DocumentNode.Descendants(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(59622));
					Func<HtmlNode, bool> predicate;
					if ((predicate = c3e89d2b199cb88db040c1d3093faf8e0.<>c.cc5a1a769950fdc613f5cb3a41eaea41f) == null)
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
						predicate = (c3e89d2b199cb88db040c1d3093faf8e0.<>c.cc5a1a769950fdc613f5cb3a41eaea41f = new Func<HtmlNode, bool>(c3e89d2b199cb88db040c1d3093faf8e0.<>c.cdfab1996eb8651828de2a4469aa3481e.c95d8e2b9301dfddafeffd27798225685));
					}
					IEnumerable<HtmlNode> source2 = source.Where(predicate);
					Func<HtmlNode, string> selector;
					if ((selector = c3e89d2b199cb88db040c1d3093faf8e0.<>c.cb655fc60d556b33bf5a885606abe4223) == null)
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
						selector = (c3e89d2b199cb88db040c1d3093faf8e0.<>c.cb655fc60d556b33bf5a885606abe4223 = new Func<HtmlNode, string>(c3e89d2b199cb88db040c1d3093faf8e0.<>c.cdfab1996eb8651828de2a4469aa3481e.c9c4fb8361efcd96bd6b8b295ce5ffecc));
					}
					list.AddRange(source2.Select(selector).ToArray<string>());
				}
				this.cc232b19312386f0e5ad9c5f2750e8caf.settings.volume = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15524);
				this.cc232b19312386f0e5ad9c5f2750e8caf.URL = this.c311081bce376d71dfe182b9e27b95f0e(this.c3dab97613008914b2f5678ebbbcbecd6[new Random().Next(this.c3dab97613008914b2f5678ebbbcbecd6.Count)]);
				this.cc232b19312386f0e5ad9c5f2750e8caf.controls.play();
			}
			catch
			{
			}
		}

		// Token: 0x040003AE RID: 942
		private const int cc63bcba0db9ede7ec3762473352d52de = 8;

		// Token: 0x040003AF RID: 943
		private int c3342cbd830131ac33d7febcd0918fc29 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15528);

		// Token: 0x040003B0 RID: 944
		private int cd5f9ff715fc8c2a6e742720c988f4926 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15532);

		// Token: 0x040003B1 RID: 945
		private Bitmap c1d162cb6d8e7a645a3bc05b229a1c0fc;

		// Token: 0x040003B2 RID: 946
		private c4c1cf20119750bfee2a0bb499f990883 c1e46d70f6d24492d9c5c673c1d226323;

		// Token: 0x040003B3 RID: 947
		private WindowsMediaPlayer cc232b19312386f0e5ad9c5f2750e8caf;

		// Token: 0x040003B4 RID: 948
		private List<string> c3dab97613008914b2f5678ebbbcbecd6;

		// Token: 0x040003B5 RID: 949
		private int c349124be9afdb0cce6f81854673c5b78;

		// Token: 0x040003B6 RID: 950
		private int c60986f3bb919a4c9fcc376a9f27cc3af = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15536);

		// Token: 0x040003B8 RID: 952
		private PictureBox cde1f5bab75cd285618406d4e8c84eb3c;

		// Token: 0x040003B9 RID: 953
		private RadLabel c362e39f066aef56acd25812b83e7da57;

		// Token: 0x040003BA RID: 954
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;

		// Token: 0x040003BB RID: 955
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x040003BC RID: 956
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x040003BD RID: 957
		private Timer caf43b0816cb9cfbaf9c97aeab60c9c3c;

		// Token: 0x040003BE RID: 958
		private PictureBox c1e664eedc77244516df32f78879cbd6a;

		// Token: 0x040003BF RID: 959
		private Timer cd472e7f2777db76011c51b50e8217625;

		// Token: 0x040003C0 RID: 960
		private RadCheckBox c3e59bee63412a9e620fccb76ef2a7f5f;

		// Token: 0x02000159 RID: 345
		[CompilerGenerated]
		private sealed class c17150bf57828385d95838312f08db49f
		{
			// Token: 0x06000986 RID: 2438 RVA: 0x000603C8 File Offset: 0x0005E5C8
			internal void c6a3bbd164e93712873dc646595da85e7()
			{
				RadMessageBox.Show(c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(97022), this.c08b391577522100e1046cacdb2283fb0));
				this.c4404a159870bf55bb6f111e66e59e82d.Close();
			}

			// Token: 0x04000710 RID: 1808
			public Exception c08b391577522100e1046cacdb2283fb0;

			// Token: 0x04000711 RID: 1809
			public c3e89d2b199cb88db040c1d3093faf8e0 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200015A RID: 346
		[CompilerGenerated]
		private sealed class c01c2ca1b82ced3f16a070ce74d7822e2
		{
			// Token: 0x06000988 RID: 2440 RVA: 0x00060418 File Offset: 0x0005E618
			internal void c53a3476ec492dc379bd10c12605f85c8(object cb0d7b0b893a41a39e281ddc32fc698bd, int c08b391577522100e1046cacdb2283fb0)
			{
				c3e89d2b199cb88db040c1d3093faf8e0.cb911d26592fbf6b94d8671c3f8fd2fb0 cb911d26592fbf6b94d8671c3f8fd2fb = new c3e89d2b199cb88db040c1d3093faf8e0.cb911d26592fbf6b94d8671c3f8fd2fb0();
				cb911d26592fbf6b94d8671c3f8fd2fb.c8c38354cddaefb45b9cfcd9ed2838c37 = this;
				cb911d26592fbf6b94d8671c3f8fd2fb.c08b391577522100e1046cacdb2283fb0 = c08b391577522100e1046cacdb2283fb0;
				this.c4404a159870bf55bb6f111e66e59e82d.Invoke(new MethodInvoker(cb911d26592fbf6b94d8671c3f8fd2fb.ca9ca3653eab3542520a68ccd83ad0ca5));
			}

			// Token: 0x04000712 RID: 1810
			public List<RadLabel> c832bb5717a513a562cc398fed110b06a;

			// Token: 0x04000713 RID: 1811
			public c3e89d2b199cb88db040c1d3093faf8e0 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200015B RID: 347
		[CompilerGenerated]
		private sealed class cb911d26592fbf6b94d8671c3f8fd2fb0
		{
			// Token: 0x0600098A RID: 2442 RVA: 0x00060468 File Offset: 0x0005E668
			internal void ca9ca3653eab3542520a68ccd83ad0ca5()
			{
				switch (this.c08b391577522100e1046cacdb2283fb0)
				{
				case 0:
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cd5f9ff715fc8c2a6e742720c988f4926 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30708);
					break;
				case 1:
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cd5f9ff715fc8c2a6e742720c988f4926 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30712);
					break;
				case 2:
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cd5f9ff715fc8c2a6e742720c988f4926 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30716);
					break;
				case 3:
					this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cd5f9ff715fc8c2a6e742720c988f4926 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30720);
					break;
				}
				this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cde1f5bab75cd285618406d4e8c84eb3c.Location = new Point(this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cde1f5bab75cd285618406d4e8c84eb3c.Left, this.c8c38354cddaefb45b9cfcd9ed2838c37.c832bb5717a513a562cc398fed110b06a[this.c08b391577522100e1046cacdb2283fb0].Top + this.c8c38354cddaefb45b9cfcd9ed2838c37.c832bb5717a513a562cc398fed110b06a[this.c08b391577522100e1046cacdb2283fb0].Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30724) - this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.cde1f5bab75cd285618406d4e8c84eb3c.Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30728));
			}

			// Token: 0x04000714 RID: 1812
			public int c08b391577522100e1046cacdb2283fb0;

			// Token: 0x04000715 RID: 1813
			public c3e89d2b199cb88db040c1d3093faf8e0.c01c2ca1b82ced3f16a070ce74d7822e2 c8c38354cddaefb45b9cfcd9ed2838c37;
		}
	}
}
