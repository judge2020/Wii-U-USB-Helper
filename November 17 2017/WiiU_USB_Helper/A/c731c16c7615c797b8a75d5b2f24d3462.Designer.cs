using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000C9 RID: 201
	public class c731c16c7615c797b8a75d5b2f24d3462 : RadForm
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x00039E3C File Offset: 0x0003803C
		public c731c16c7615c797b8a75d5b2f24d3462()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x0600070E RID: 1806
		[DllImport("user32.dll", EntryPoint = "GetScrollInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool ccf6666e92cbd9b456dd9085d5f28f539(IntPtr c8339e9554eac7811c7ef22d9dacebaad, int c7cb3be851d8ea8d086bbeeb56f37c9ef, ref c731c16c7615c797b8a75d5b2f24d3462.c72ed4a66badb846f8c40da13d65acfdc c20e48bd6312f205ced64c643a0d1eb54);

		// Token: 0x0600070F RID: 1807 RVA: 0x00039E58 File Offset: 0x00038058
		private static void c8bc49d7d6beeb87cef54cb62255ca9fc(IntPtr c20ee3374c3cfbfb78542f213ffdd2b9c, int ccba3d08be05b492402261f04c6e71b8e)
		{
			c731c16c7615c797b8a75d5b2f24d3462.c72ed4a66badb846f8c40da13d65acfdc c72ed4a66badb846f8c40da13d65acfdc = default(c731c16c7615c797b8a75d5b2f24d3462.c72ed4a66badb846f8c40da13d65acfdc);
			c72ed4a66badb846f8c40da13d65acfdc.cb2ad79aa66a43d0571ab9c839619b95c = (uint)Marshal.SizeOf(c72ed4a66badb846f8c40da13d65acfdc);
			c72ed4a66badb846f8c40da13d65acfdc.c53726ff795f876c82341ce1d3880c27e = (uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17884);
			c731c16c7615c797b8a75d5b2f24d3462.ccf6666e92cbd9b456dd9085d5f28f539(c20ee3374c3cfbfb78542f213ffdd2b9c, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17888), ref c72ed4a66badb846f8c40da13d65acfdc);
			c72ed4a66badb846f8c40da13d65acfdc.cd103062584118c84af7dd52494a5e8fb += ccba3d08be05b492402261f04c6e71b8e;
			c731c16c7615c797b8a75d5b2f24d3462.c96eecb40480334bdded84d0191d0f8a6(c20ee3374c3cfbfb78542f213ffdd2b9c, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17892), ref c72ed4a66badb846f8c40da13d65acfdc, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17896) != 0);
			IntPtr cd10980add324e80f2f79116324e769d = new IntPtr(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17900) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17904) * c72ed4a66badb846f8c40da13d65acfdc.cd103062584118c84af7dd52494a5e8fb);
			IntPtr c2cdf8244d951d04da5a7e193561fc1df = new IntPtr(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17908));
			c731c16c7615c797b8a75d5b2f24d3462.cf69975d7319145423da6771b69e40db4(c20ee3374c3cfbfb78542f213ffdd2b9c, (uint)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17912), cd10980add324e80f2f79116324e769d, c2cdf8244d951d04da5a7e193561fc1df);
		}

		// Token: 0x06000710 RID: 1808
		[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
		private static extern IntPtr cf69975d7319145423da6771b69e40db4(IntPtr c066891678a283862c572a0812e4bc95a, uint cf1dfc521a527a5e2e72f6ee8288adaee, IntPtr cd10980add324e80f2f79116324e769d1, IntPtr c2cdf8244d951d04da5a7e193561fc1df);

		// Token: 0x06000711 RID: 1809
		[DllImport("user32.dll", EntryPoint = "SetScrollInfo")]
		private static extern int c96eecb40480334bdded84d0191d0f8a6(IntPtr c8339e9554eac7811c7ef22d9dacebaad, int c7cb3be851d8ea8d086bbeeb56f37c9ef, [In] ref c731c16c7615c797b8a75d5b2f24d3462.c72ed4a66badb846f8c40da13d65acfdc c20e48bd6312f205ced64c643a0d1eb54, bool c8d7daa8b364a0a08b77e4a3745454d08);

		// Token: 0x06000712 RID: 1810 RVA: 0x00039F1C File Offset: 0x0003811C
		private void c9e238964b0d8df00c8c3038739c91eb5(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			List<string> list = new List<string>();
			this.c37fc900ace92f944fb65ff327da7a633.BackColor = this.BackColor;
			string text = new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65811));
			char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17916));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17920)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17924);
			string[] array2 = text.Split(array, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17928));
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17932); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array2); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17948))
			{
				string text2 = array2[i];
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text2.Substring(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17940)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65926)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c731c16c7615c797b8a75d5b2f24d3462.c9e238964b0d8df00c8c3038739c91eb5(object, EventArgs)).MethodHandle;
					}
					text2 = text2.Substring(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17944));
					list.Add(text2);
				}
				RichTextBox richTextBox = this.c37fc900ace92f944fb65ff327da7a633;
				richTextBox.Text = c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(richTextBox.Text, text2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11207));
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
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string str = enumerator.Current;
					this.c37fc900ace92f944fb65ff327da7a633.Find(str);
					this.c37fc900ace92f944fb65ff327da7a633.SelectionColor = Color.Gold;
				}
				for (;;)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			this.c37fc900ace92f944fb65ff327da7a633.SelectAll();
			this.c37fc900ace92f944fb65ff327da7a633.SelectionAlignment = (HorizontalAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17952);
			this.c86452818ff0d57f9ce337540c1db4839.Start();
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0003A0EC File Offset: 0x000382EC
		private void c9a64d34ac941d404d430cebfc642ed66(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c731c16c7615c797b8a75d5b2f24d3462.c8bc49d7d6beeb87cef54cb62255ca9fc(this.c37fc900ace92f944fb65ff327da7a633.Handle, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17956));
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0003A118 File Offset: 0x00038318
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c731c16c7615c797b8a75d5b2f24d3462.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0003A160 File Offset: 0x00038360
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c66944218dc6924b147fbc6b0f72a424f = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c5de277a38cb35e93f8cd11509bc8b8ae.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.c86452818ff0d57f9ce337540c1db4839 = new Timer(this.c66944218dc6924b147fbc6b0f72a424f);
			this.c37fc900ace92f944fb65ff327da7a633 = new RichTextBox();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c86452818ff0d57f9ce337540c1db4839.Interval = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17960);
			this.c86452818ff0d57f9ce337540c1db4839.Tick += this.c9a64d34ac941d404d430cebfc642ed66;
			this.c37fc900ace92f944fb65ff327da7a633.BorderStyle = (BorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17964);
			this.c37fc900ace92f944fb65ff327da7a633.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17968);
			this.c37fc900ace92f944fb65ff327da7a633.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65929), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(17972), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17976), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17980), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17984));
			this.c37fc900ace92f944fb65ff327da7a633.ForeColor = Color.White;
			this.c37fc900ace92f944fb65ff327da7a633.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17988), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17992));
			this.c37fc900ace92f944fb65ff327da7a633.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65944);
			this.c37fc900ace92f944fb65ff327da7a633.ReadOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(17996) != 0);
			this.c37fc900ace92f944fb65ff327da7a633.ScrollBars = (RichTextBoxScrollBars)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18000);
			this.c37fc900ace92f944fb65ff327da7a633.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18004), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18008));
			this.c37fc900ace92f944fb65ff327da7a633.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18012);
			this.c37fc900ace92f944fb65ff327da7a633.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18016) != 0);
			this.c37fc900ace92f944fb65ff327da7a633.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(65959);
			this.c4553ed186725b714efcccc71bbe10a0f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18020) != 0);
			this.c4553ed186725b714efcccc71bbe10a0f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18024);
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18028), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18032));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18036), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18040));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18044);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66002);
			this.c4553ed186725b714efcccc71bbe10a0f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18048);
			this.c4553ed186725b714efcccc71bbe10a0f.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18052) != 0);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18056);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18064));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18072));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18076);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66214);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18080);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18084), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18088));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18092);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18096), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18100));
			base.Controls.Add(this.c37fc900ace92f944fb65ff327da7a633);
			base.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			base.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18104);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66295);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18108) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18112) != 0);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66322);
			base.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			base.Load += this.c9e238964b0d8df00c8c3038739c91eb5;
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18116) != 0);
		}

		// Token: 0x04000416 RID: 1046
		private const int c279881d9afa585f269840bcf7bb39eac = 7;

		// Token: 0x04000417 RID: 1047
		private const int c86de419d577d75811dd4ddee283297e8 = 8;

		// Token: 0x04000418 RID: 1048
		private const int c8314cb821aa543eacdc9297d6e71c83b = 1;

		// Token: 0x04000419 RID: 1049
		private const int ca676b4d1f7f581859dfc185413f466ec = 0;

		// Token: 0x0400041A RID: 1050
		private const int c2acbf8a42aeb4db6c36c47b6f454a511 = 4;

		// Token: 0x0400041B RID: 1051
		private const int c5b98f7cb06d39f36ffad3498ebc7c276 = 5;

		// Token: 0x0400041C RID: 1052
		private const int cbb7921a9dd91c54a54d59850e31c690f = 6;

		// Token: 0x0400041D RID: 1053
		private const int c66ea849184a0a748aa00ecc59420e0b0 = 277;

		// Token: 0x0400041E RID: 1054
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x0400041F RID: 1055
		private Timer c86452818ff0d57f9ce337540c1db4839;

		// Token: 0x04000420 RID: 1056
		private RichTextBox c37fc900ace92f944fb65ff327da7a633;

		// Token: 0x04000421 RID: 1057
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x04000422 RID: 1058
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x02000161 RID: 353
		private enum cae5f47daf7f32b7f6848227bd3837502
		{
			// Token: 0x04000722 RID: 1826
			c593731180ba8e7388de7e3c38b9f6e10,
			// Token: 0x04000723 RID: 1827
			c9755555fb8e3a725c64200364ad1d7fb,
			// Token: 0x04000724 RID: 1828
			c86b123ffe396d9e6b9064a05c4ddf7ad,
			// Token: 0x04000725 RID: 1829
			cf9063dcd91e490f216a105418296e8f4
		}

		// Token: 0x02000162 RID: 354
		private enum c48fadde3f4914ec816787fb7d84e2b50
		{
			// Token: 0x04000727 RID: 1831
			cbf0cd68ffb92dbbd3c19fb8753d01b14 = 1,
			// Token: 0x04000728 RID: 1832
			cab0be854d6a9b7b408d13e19ca33e193,
			// Token: 0x04000729 RID: 1833
			cd26547d63beb200d6ccab5eb78eb1e19 = 4,
			// Token: 0x0400072A RID: 1834
			c953edf2f08f0f048277b7bbf192553f4 = 8,
			// Token: 0x0400072B RID: 1835
			ce4b586c62efaf172a6a0a4b99122645a = 16,
			// Token: 0x0400072C RID: 1836
			ced54ca4e6b031d1d1938dbfc8d46a876 = 23
		}

		// Token: 0x02000163 RID: 355
		private struct c72ed4a66badb846f8c40da13d65acfdc
		{
			// Token: 0x0400072D RID: 1837
			public uint cb2ad79aa66a43d0571ab9c839619b95c;

			// Token: 0x0400072E RID: 1838
			public uint c53726ff795f876c82341ce1d3880c27e;

			// Token: 0x0400072F RID: 1839
			public int c46ffb8be8660952f8ec5a1751a530216;

			// Token: 0x04000730 RID: 1840
			public int c26b5f85d547cd8800d2eed6c4ffbd7ca;

			// Token: 0x04000731 RID: 1841
			public uint c417ffdc411a443605cceebda0cdd0039;

			// Token: 0x04000732 RID: 1842
			public int cd103062584118c84af7dd52494a5e8fb;

			// Token: 0x04000733 RID: 1843
			public int c7254506233ffed9ccca158f6ef7db0fd;
		}
	}
}
