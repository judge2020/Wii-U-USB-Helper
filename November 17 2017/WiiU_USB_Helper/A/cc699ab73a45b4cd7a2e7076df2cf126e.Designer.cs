using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000B7 RID: 183
	public class cc699ab73a45b4cd7a2e7076df2cf126e : RadForm
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x0002E350 File Offset: 0x0002C550
		public cc699ab73a45b4cd7a2e7076df2cf126e()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0002E36C File Offset: 0x0002C56C
		private void c575f8d12fcef3eee352ca96a41736b5c()
		{
			cc699ab73a45b4cd7a2e7076df2cf126e.ce4a5ffd4e2610578f67609ed6efd8b01 ce4a5ffd4e2610578f67609ed6efd8b = new cc699ab73a45b4cd7a2e7076df2cf126e.ce4a5ffd4e2610578f67609ed6efd8b01();
			cc699ab73a45b4cd7a2e7076df2cf126e.ce4a5ffd4e2610578f67609ed6efd8b01 ce4a5ffd4e2610578f67609ed6efd8b2 = ce4a5ffd4e2610578f67609ed6efd8b;
			string text = this.c62b3fe468fae62c29132ec7e562ac038.Text.ToLower();
			char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12972));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12976)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12980);
			ce4a5ffd4e2610578f67609ed6efd8b2.c032518bcce8eb4b1dfdc5a4b273b5174 = text.Split(array);
			IEnumerable<cbfa477cacc0f7b226e325a3d45e91591> enumerable = this.cde80bc016291b22699c166b9b2075cc6.Where(new Func<cbfa477cacc0f7b226e325a3d45e91591, bool>(ce4a5ffd4e2610578f67609ed6efd8b.c1ace4823f1a392e7260ad7f3febe34be));
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.BeginUpdate();
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.Items.Clear();
			IEnumerator<cbfa477cacc0f7b226e325a3d45e91591> enumerator = enumerable.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					cbfa477cacc0f7b226e325a3d45e91591 cbfa477cacc0f7b226e325a3d45e = enumerator.Current;
					this.c7bdda13c00d8de32ed8a888f4d7fefdf.Items.Add(new ListViewDataItem(cbfa477cacc0f7b226e325a3d45e));
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc699ab73a45b4cd7a2e7076df2cf126e.c575f8d12fcef3eee352ca96a41736b5c()).MethodHandle;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.EndUpdate();
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002E478 File Offset: 0x0002C678
		private void c57b70a70819e119b2e6cb6b8eaacaa58(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.cde80bc016291b22699c166b9b2075cc6 = ce07c379a1090dd9de869aa5e3a694e98.c2bc36dd5b2f881cf591e4912315784fa();
			this.c575f8d12fcef3eee352ca96a41736b5c();
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0002E498 File Offset: 0x0002C698
		private void c8cf26a8be037c0d7e35e6e34e1b1dec7(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
		private void c473406daea7f703eb5748d7ad725611d(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (this.c7bdda13c00d8de32ed8a888f4d7fefdf.SelectedItem == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc699ab73a45b4cd7a2e7076df2cf126e.c473406daea7f703eb5748d7ad725611d(object, EventArgs)).MethodHandle;
				}
				return;
			}
			string answer = cf4e7b532a4dd6f2addd2a2faf098796e.c0b398ab350e72b0d64d512bae8520b85(this.c7bdda13c00d8de32ed8a888f4d7fefdf.SelectedItem.Value).Answer;
			StringBuilder stringBuilder = new StringBuilder(answer.Length + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12984));
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12988);
			string text = answer;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12992); i < text.Length; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13008))
			{
				char c = text[i];
				if ((int)c != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12996))
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
					stringBuilder.Append(c);
				}
				else
				{
					int num2 = num;
					num = num2 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13000);
					if (num2 % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13004) == 0)
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
						stringBuilder.Append(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50100));
					}
					else
					{
						stringBuilder.Append(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50159));
					}
				}
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
			this.c67dff421d20335f64aa4a6f076980a08.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50174), stringBuilder);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		private void cfb303f644e0e273ff69672d0f5b913d8(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0002E604 File Offset: 0x0002C804
		private void cd12499ef2413321cb629521a4118ee19(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c575f8d12fcef3eee352ca96a41736b5c();
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0002E618 File Offset: 0x0002C818
		private void c82adfa22983068c78f816b49dd805cb3(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c575f8d12fcef3eee352ca96a41736b5c();
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002E62C File Offset: 0x0002C82C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc699ab73a45b4cd7a2e7076df2cf126e.Dispose(bool)).MethodHandle;
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

		// Token: 0x06000685 RID: 1669 RVA: 0x0002E674 File Offset: 0x0002C874
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c4fef8a4a120bcd2c5fad693f18270fad.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c7bdda13c00d8de32ed8a888f4d7fefdf = new RadListView();
			this.c62b3fe468fae62c29132ec7e562ac038 = new RadTextBoxControl();
			this.c67dff421d20335f64aa4a6f076980a08 = new RadLabel();
			this.c362e39f066aef56acd25812b83e7da57 = new RadLabel();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.BeginInit();
			this.c62b3fe468fae62c29132ec7e562ac038.BeginInit();
			this.c67dff421d20335f64aa4a6f076980a08.BeginInit();
			this.c362e39f066aef56acd25812b83e7da57.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c4553ed186725b714efcccc71bbe10a0f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13012) != 0);
			this.c4553ed186725b714efcccc71bbe10a0f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13016);
			this.c4553ed186725b714efcccc71bbe10a0f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13020), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13024), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13028), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13032));
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13036), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13040));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13044), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13048));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13052);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50221);
			this.c4553ed186725b714efcccc71bbe10a0f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13056);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13060) != 0);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13064);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13072));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Margin = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13076), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13080), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13088));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13096));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13100);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50244);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13104);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Click += this.cfb303f644e0e273ff69672d0f5b913d8;
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.AllowEdit = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13108) != 0);
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13112) != 0);
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13116);
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13120), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13124), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13128), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13132));
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.ItemSpacing = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13136);
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13140), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13144));
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50331);
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13148), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13152));
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13156);
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.SelectedItemChanged += this.c473406daea7f703eb5748d7ad725611d;
			this.c62b3fe468fae62c29132ec7e562ac038.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13160);
			this.c62b3fe468fae62c29132ec7e562ac038.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13164), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13168), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13172), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13176));
			this.c62b3fe468fae62c29132ec7e562ac038.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13180), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13184));
			this.c62b3fe468fae62c29132ec7e562ac038.Margin = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13188), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13192), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13196), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13200));
			this.c62b3fe468fae62c29132ec7e562ac038.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50381);
			this.c62b3fe468fae62c29132ec7e562ac038.NullText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50404);
			this.c62b3fe468fae62c29132ec7e562ac038.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13204), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13208));
			this.c62b3fe468fae62c29132ec7e562ac038.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13212);
			this.c62b3fe468fae62c29132ec7e562ac038.TextChanged += this.c82adfa22983068c78f816b49dd805cb3;
			this.c67dff421d20335f64aa4a6f076980a08.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13216) != 0);
			this.c67dff421d20335f64aa4a6f076980a08.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13220);
			this.c67dff421d20335f64aa4a6f076980a08.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13224), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13228), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13232), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13236));
			this.c67dff421d20335f64aa4a6f076980a08.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13240), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13244));
			this.c67dff421d20335f64aa4a6f076980a08.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50487);
			this.c67dff421d20335f64aa4a6f076980a08.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13248));
			this.c67dff421d20335f64aa4a6f076980a08.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13252), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13256));
			this.c67dff421d20335f64aa4a6f076980a08.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13260);
			this.c67dff421d20335f64aa4a6f076980a08.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13264);
			this.c362e39f066aef56acd25812b83e7da57.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13268) != 0);
			this.c362e39f066aef56acd25812b83e7da57.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13272);
			this.c362e39f066aef56acd25812b83e7da57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13276), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13280));
			this.c362e39f066aef56acd25812b83e7da57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42983);
			this.c362e39f066aef56acd25812b83e7da57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13288));
			this.c362e39f066aef56acd25812b83e7da57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13292);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13296) != 0);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13300);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13304), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13308));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13316));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13320);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13324), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13328));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13332);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13336), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13340));
			base.Controls.Add(this.c67dff421d20335f64aa4a6f076980a08);
			base.Controls.Add(this.c7bdda13c00d8de32ed8a888f4d7fefdf);
			base.Controls.Add(this.c362e39f066aef56acd25812b83e7da57);
			base.Controls.Add(this.c62b3fe468fae62c29132ec7e562ac038);
			base.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			base.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			base.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50506);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13344));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13348) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13352);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50519);
			base.Load += this.c57b70a70819e119b2e6cb6b8eaacaa58;
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.c7bdda13c00d8de32ed8a888f4d7fefdf.EndInit();
			this.c62b3fe468fae62c29132ec7e562ac038.EndInit();
			this.c67dff421d20335f64aa4a6f076980a08.EndInit();
			this.c362e39f066aef56acd25812b83e7da57.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13356) != 0);
		}

		// Token: 0x0400036C RID: 876
		private List<cbfa477cacc0f7b226e325a3d45e91591> cde80bc016291b22699c166b9b2075cc6;

		// Token: 0x0400036D RID: 877
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x0400036E RID: 878
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x0400036F RID: 879
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x04000370 RID: 880
		private RadListView c7bdda13c00d8de32ed8a888f4d7fefdf;

		// Token: 0x04000371 RID: 881
		private RadTextBoxControl c62b3fe468fae62c29132ec7e562ac038;

		// Token: 0x04000372 RID: 882
		private RadLabel c67dff421d20335f64aa4a6f076980a08;

		// Token: 0x04000373 RID: 883
		private RadLabel c362e39f066aef56acd25812b83e7da57;

		// Token: 0x04000374 RID: 884
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;

		// Token: 0x02000154 RID: 340
		[CompilerGenerated]
		private sealed class ce4a5ffd4e2610578f67609ed6efd8b01
		{
			// Token: 0x0600097C RID: 2428 RVA: 0x0006022C File Offset: 0x0005E42C
			internal bool c1ace4823f1a392e7260ad7f3febe34be(cbfa477cacc0f7b226e325a3d45e91591 c41ad439f02d283ff6930e1fd4a707bd5)
			{
				cc699ab73a45b4cd7a2e7076df2cf126e.c50b1be2be9fc051f5c213346896812b1 c50b1be2be9fc051f5c213346896812b = new cc699ab73a45b4cd7a2e7076df2cf126e.c50b1be2be9fc051f5c213346896812b1();
				c50b1be2be9fc051f5c213346896812b.c41ad439f02d283ff6930e1fd4a707bd5 = c41ad439f02d283ff6930e1fd4a707bd5;
				if (!this.c032518bcce8eb4b1dfdc5a4b273b5174.Any(new Func<string, bool>(c50b1be2be9fc051f5c213346896812b.c2c45410e752728d2d5bf4a6363a96986)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cc699ab73a45b4cd7a2e7076df2cf126e.ce4a5ffd4e2610578f67609ed6efd8b01.c1ace4823f1a392e7260ad7f3febe34be(cbfa477cacc0f7b226e325a3d45e91591)).MethodHandle;
					}
					return this.c032518bcce8eb4b1dfdc5a4b273b5174.Any(new Func<string, bool>(c50b1be2be9fc051f5c213346896812b.caeb1950c99a0b9ce37f567c33cb7b731));
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30704) != 0;
			}

			// Token: 0x04000709 RID: 1801
			public string[] c032518bcce8eb4b1dfdc5a4b273b5174;
		}

		// Token: 0x02000155 RID: 341
		[CompilerGenerated]
		private sealed class c50b1be2be9fc051f5c213346896812b1
		{
			// Token: 0x0600097E RID: 2430 RVA: 0x000602AC File Offset: 0x0005E4AC
			internal bool c2c45410e752728d2d5bf4a6363a96986(string ced17f5fac5de96d8d690dac7cea067a7)
			{
				return this.c41ad439f02d283ff6930e1fd4a707bd5.Question.ToLower().Contains(ced17f5fac5de96d8d690dac7cea067a7);
			}

			// Token: 0x0600097F RID: 2431 RVA: 0x000602D8 File Offset: 0x0005E4D8
			internal bool caeb1950c99a0b9ce37f567c33cb7b731(string ced17f5fac5de96d8d690dac7cea067a7)
			{
				return this.c41ad439f02d283ff6930e1fd4a707bd5.Answer.ToLower().Contains(ced17f5fac5de96d8d690dac7cea067a7);
			}

			// Token: 0x0400070A RID: 1802
			public cbfa477cacc0f7b226e325a3d45e91591 c41ad439f02d283ff6930e1fd4a707bd5;
		}
	}
}
