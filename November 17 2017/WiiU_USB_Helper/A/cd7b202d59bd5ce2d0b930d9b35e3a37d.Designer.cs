using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000BE RID: 190
	public class cd7b202d59bd5ce2d0b930d9b35e3a37d : RadForm
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x00031D8C File Offset: 0x0002FF8C
		public cd7b202d59bd5ce2d0b930d9b35e3a37d(c5409344e1c2b74fa8c9a4d620ccb8d48 ce6591d75ff64e43faf8c563a2a657abe)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			if (!ce6591d75ff64e43faf8c563a2a657abe.c9e33774c6343e7c7fe83022678b014ae)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d..ctor(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				throw new ArgumentException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(56268));
			}
			this.c21c18a763402a75241db42319702676a = ce6591d75ff64e43faf8c563a2a657abe;
			this.c37d2facd9960e8126dd1ced72f3b8686 = ce6591d75ff64e43faf8c563a2a657abe.c9defc57488e57eae7e78baf97af93d96();
			this.c8861d7dda4ce3c892b8aabbaf69cf6a1 = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(56347), this.c37d2facd9960e8126dd1ced72f3b8686.cf96188d52085ca12da85c38a0cbd94c5);
			Control control = this.cfbf47a059c73dd11f631963362e53c2f;
			string format = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(57611);
			object[] array = c03afd7759879ce2659a1d311b66f5509.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15092));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15096)] = this.c37d2facd9960e8126dd1ced72f3b8686.cf96188d52085ca12da85c38a0cbd94c5;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15100)] = this.c21c18a763402a75241db42319702676a.Name;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15104)] = this.c21c18a763402a75241db42319702676a.ProductId;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15108)] = this.c21c18a763402a75241db42319702676a.Region;
			control.Text = string.Format(format, array);
			Control control2 = this.c15ff06bceba4a352a6336f85a53d9362;
			string format2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(57611);
			object[] array2 = c03afd7759879ce2659a1d311b66f5509.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15112));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15116)] = this.c37d2facd9960e8126dd1ced72f3b8686.cf96188d52085ca12da85c38a0cbd94c5;
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15120)] = this.c21c18a763402a75241db42319702676a.Name;
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15124)] = this.c21c18a763402a75241db42319702676a.ProductId;
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15128)] = this.c21c18a763402a75241db42319702676a.Region;
			control2.Text = string.Format(format2, array2);
			if (this.c21c18a763402a75241db42319702676a.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15132))
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
				this.c17d8b285e03a5f7ce51ad362751d6783.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15136) != 0);
			}
			if (this.c21c18a763402a75241db42319702676a.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15140))
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
				this.c6abfbd30528d76e1d6eea1ee59f2a5e4.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(57686);
			}
			else
			{
				this.c6abfbd30528d76e1d6eea1ee59f2a5e4.Text = this.c8861d7dda4ce3c892b8aabbaf69cf6a1;
			}
			this.c731c0b98a147a78705ccab2fa0779d57();
			if (this.c21c18a763402a75241db42319702676a.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15144))
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
				base.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15148), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15152));
				return;
			}
			base.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15156), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15160));
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00032024 File Offset: 0x00030224
		private void ca54e4e0ca68a6bd9efde0a284f454ccf(object cd7b28952603b35a45c555982e677363a, StateChangingEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			if (c3c9260886a6db15de49329a9f5b9836c.NewValue == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d.ca54e4e0ca68a6bd9efde0a284f454ccf(object, StateChangingEventArgs)).MethodHandle;
				}
				if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54176), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54352), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14564)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14568))
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
					c3c9260886a6db15de49329a9f5b9836c.Cancel = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14572) != 0);
				}
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000320A0 File Offset: 0x000302A0
		private void ca7388291853951a253ad9259a84b82b3(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Multiselect = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14576) != 0),
				CheckFileExists = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14580) != 0)
			};
			openFileDialog.Filter = this.c37d2facd9960e8126dd1ced72f3b8686.c41ca02dc0bc33eb67cf1568c3466b35e;
			if (openFileDialog.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14584))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d.ca7388291853951a253ad9259a84b82b3(object, EventArgs)).MethodHandle;
				}
				this.c1d625f9437708c741d77b29465f7170d(openFileDialog.FileName);
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0003211C File Offset: 0x0003031C
		private void cb1aed5a5240e442510f74197c00a9c4f(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c9e3b15e0906fc28b9aaaafda91843cfe c9e3b15e0906fc28b9aaaafda91843cfe = new c9e3b15e0906fc28b9aaaafda91843cfe(new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14588))));
			if (c9e3b15e0906fc28b9aaaafda91843cfe.ShowDialog() == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14592))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d.cb1aed5a5240e442510f74197c00a9c4f(object, EventArgs)).MethodHandle;
				}
				cb4e425f2d70132d57f01f6cf60a868ac.c89dae8cdccd0587e25828a58231f8ad0(c9e3b15e0906fc28b9aaaafda91843cfe.cdeb88a4da0e27c7f39e2cad0c950f4b0);
				cb4e425f2d70132d57f01f6cf60a868ac.c555a48103171855abc9fafd6075bc76e(c9e3b15e0906fc28b9aaaafda91843cfe.cdeb88a4da0e27c7f39e2cad0c950f4b0);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0003217C File Offset: 0x0003037C
		private void c5537739175d27c853c0a5f97bc0bb6b7(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c1e664eedc77244516df32f78879cbd6a.ImageLocation = this.c21c18a763402a75241db42319702676a.IconUrl;
			if (!c4c1cf20119750bfee2a0bb499f990883.ccbe887e33d0daef830980e7dc1e518ad)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d.c5537739175d27c853c0a5f97bc0bb6b7(object, EventArgs)).MethodHandle;
				}
				if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54379), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12311), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14596)) != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14600))
				{
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54719));
					base.Close();
					return;
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
				Process.Start(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54565));
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54614));
				base.Close();
			}
			else
			{
				try
				{
					string c7b0be042b6d2a0b606dd5328403bf5e = c4c1cf20119750bfee2a0bb499f990883.c7b0be042b6d2a0b606dd5328403bf5e1;
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						RedirectStandardError = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14604) != 0),
						FileName = c7b0be042b6d2a0b606dd5328403bf5e,
						WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14608),
						UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14612) != 0),
						Arguments = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12267)
					};
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Start();
					string text = process.StandardError.ReadToEnd();
					int num = text.IndexOf((char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14616)) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14620);
					int length = text.IndexOf((char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14624), text.IndexOf((char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14628)) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14632)) - num;
					string text2 = text.Substring(num, length);
					char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14636));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14640)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14644);
					if (int.Parse(text2.Split(array)[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14648)]) < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14652))
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
						this.cd17a4999b5cbfeadd987c71a7c7f44c8();
						return;
					}
				}
				catch
				{
					this.cd17a4999b5cbfeadd987c71a7c7f44c8();
					return;
				}
			}
			cb4e425f2d70132d57f01f6cf60a868ac cb4e425f2d70132d57f01f6cf60a868ac;
			if ((cb4e425f2d70132d57f01f6cf60a868ac = cb52f3f28150b9e69891d97167fde8262.c0b398ab350e72b0d64d512bae8520b85(this.c37d2facd9960e8126dd1ced72f3b8686)) != null)
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
				if (cb4e425f2d70132d57f01f6cf60a868ac.PatchGame != null)
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
					if (cb4e425f2d70132d57f01f6cf60a868ac.c2b816dcbf8a2459e537fcf15305d3146())
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
						base.Close();
					}
				}
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000323F4 File Offset: 0x000305F4
		private void c574c199a7302de653999709d63fc43e7(object cd7b28952603b35a45c555982e677363a, DragEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			string c9ee5d0e059de6242d29e3c2faa703baf = c3dabc61d794f91548c16dc424947af9e.cd24593c859565ebb8c9faabbc5c75bef(cdf15457ee4816989343b6e6e96dd4cfe.Data.GetData(DataFormats.FileDrop))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14656)];
			this.c1d625f9437708c741d77b29465f7170d(c9ee5d0e059de6242d29e3c2faa703baf);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00032430 File Offset: 0x00030630
		private void c1b6365c78be8ea43e774523941a1b177(object cd7b28952603b35a45c555982e677363a, DragEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (cdf15457ee4816989343b6e6e96dd4cfe.Data.GetDataPresent(DataFormats.FileDrop))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d.c1b6365c78be8ea43e774523941a1b177(object, DragEventArgs)).MethodHandle;
				}
				cdf15457ee4816989343b6e6e96dd4cfe.Effect = (DragDropEffects)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14660);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00032478 File Offset: 0x00030678
		private void cd69ba9f5438e59e0a659dd8885fb8b7e()
		{
			new c3e89d2b199cb88db040c1d3093faf8e0(this.c37d2facd9960e8126dd1ced72f3b8686).ShowDialog();
			base.Close();
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000324A0 File Offset: 0x000306A0
		private void cd17a4999b5cbfeadd987c71a7c7f44c8()
		{
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(54802));
			base.Close();
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000324C8 File Offset: 0x000306C8
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			Process.Start(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55026));
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000324EC File Offset: 0x000306EC
		private void cfb303f644e0e273ff69672d0f5b913d8(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55137));
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00032510 File Offset: 0x00030710
		private void c731c0b98a147a78705ccab2fa0779d57()
		{
			this.ccee9ac085d34eeefb76f29b1f32f1c8c.Text = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55403), this.c37d2facd9960e8126dd1ced72f3b8686.cbcb9d6cee1025057c982e8c00b728c3c(), this.c37d2facd9960e8126dd1ced72f3b8686.cf96188d52085ca12da85c38a0cbd94c5, this.c37d2facd9960e8126dd1ced72f3b8686.RomCount);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0003256C File Offset: 0x0003076C
		private void c1d625f9437708c741d77b29465f7170d(string c9ee5d0e059de6242d29e3c2faa703baf)
		{
			if (this.c37d2facd9960e8126dd1ced72f3b8686.c04e04f3d41ac5cbe5e7491c6164e7158(c9ee5d0e059de6242d29e3c2faa703baf))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d.c1d625f9437708c741d77b29465f7170d(string)).MethodHandle;
				}
				this.cd69ba9f5438e59e0a659dd8885fb8b7e();
			}
			this.c731c0b98a147a78705ccab2fa0779d57();
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000325A8 File Offset: 0x000307A8
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd7b202d59bd5ce2d0b930d9b35e3a37d.Dispose(bool)).MethodHandle;
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

		// Token: 0x060006BC RID: 1724 RVA: 0x000325F0 File Offset: 0x000307F0
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c59ea372352f196d964b1974937367d9a.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.ca6c1cea062503a0a580756cf1f1f0961 = new RadGroupBox();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.c17d8b285e03a5f7ce51ad362751d6783 = new RadCheckBox();
			this.cfbf47a059c73dd11f631963362e53c2f = new RadGroupBox();
			this.c15ff06bceba4a352a6336f85a53d9362 = new RadLabel();
			this.ccee9ac085d34eeefb76f29b1f32f1c8c = new Label();
			this.c8c959c736abffa00d6a86ecc9972d912 = new RadButton();
			this.cd792ac67bdacd5b7947dd1479f77c2a6 = new RadButton();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c90e121b7434f8af2291ea96c07d8818e = new PictureBox();
			this.c1e664eedc77244516df32f78879cbd6a = new PictureBox();
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4 = new RadLabel();
			this.ca6c1cea062503a0a580756cf1f1f0961.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.SuspendLayout();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.c17d8b285e03a5f7ce51ad362751d6783.BeginInit();
			this.cfbf47a059c73dd11f631963362e53c2f.BeginInit();
			this.cfbf47a059c73dd11f631963362e53c2f.SuspendLayout();
			this.c15ff06bceba4a352a6336f85a53d9362.BeginInit();
			this.c15ff06bceba4a352a6336f85a53d9362.SuspendLayout();
			this.c8c959c736abffa00d6a86ecc9972d912.BeginInit();
			this.cd792ac67bdacd5b7947dd1479f77c2a6.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			((ISupportInitialize)this.c90e121b7434f8af2291ea96c07d8818e).BeginInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).BeginInit();
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.ca6c1cea062503a0a580756cf1f1f0961.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14664);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c17d8b285e03a5f7ce51ad362751d6783);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.cfbf47a059c73dd11f631963362e53c2f);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.cd792ac67bdacd5b7947dd1479f77c2a6);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c90e121b7434f8af2291ea96c07d8818e);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c1e664eedc77244516df32f78879cbd6a);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c6abfbd30528d76e1d6eea1ee59f2a5e4);
			this.ca6c1cea062503a0a580756cf1f1f0961.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14668);
			this.ca6c1cea062503a0a580756cf1f1f0961.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55464);
			this.ca6c1cea062503a0a580756cf1f1f0961.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14672), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14676));
			this.ca6c1cea062503a0a580756cf1f1f0961.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48088);
			this.ca6c1cea062503a0a580756cf1f1f0961.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14680), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14684));
			this.ca6c1cea062503a0a580756cf1f1f0961.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14688);
			this.ca6c1cea062503a0a580756cf1f1f0961.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55464);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14692), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14696));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14700), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14704));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14708);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55483);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14712), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14716), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14720));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14724), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14728));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14732), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14736));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14740);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55532);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Click += this.cfb303f644e0e273ff69672d0f5b913d8;
			this.c17d8b285e03a5f7ce51ad362751d6783.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14744), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14748));
			this.c17d8b285e03a5f7ce51ad362751d6783.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55577);
			this.c17d8b285e03a5f7ce51ad362751d6783.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14752), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14756));
			this.c17d8b285e03a5f7ce51ad362751d6783.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14760);
			this.c17d8b285e03a5f7ce51ad362751d6783.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55594);
			this.cfbf47a059c73dd11f631963362e53c2f.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14764);
			this.cfbf47a059c73dd11f631963362e53c2f.AllowDrop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14768) != 0);
			this.cfbf47a059c73dd11f631963362e53c2f.Controls.Add(this.c15ff06bceba4a352a6336f85a53d9362);
			this.cfbf47a059c73dd11f631963362e53c2f.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55625);
			this.cfbf47a059c73dd11f631963362e53c2f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14772), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14776));
			this.cfbf47a059c73dd11f631963362e53c2f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55664);
			this.cfbf47a059c73dd11f631963362e53c2f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14784));
			this.cfbf47a059c73dd11f631963362e53c2f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14788);
			this.cfbf47a059c73dd11f631963362e53c2f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55625);
			this.cfbf47a059c73dd11f631963362e53c2f.DragDrop += this.c574c199a7302de653999709d63fc43e7;
			this.cfbf47a059c73dd11f631963362e53c2f.DragEnter += this.c1b6365c78be8ea43e774523941a1b177;
			this.c15ff06bceba4a352a6336f85a53d9362.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14792) != 0);
			this.c15ff06bceba4a352a6336f85a53d9362.Controls.Add(this.ccee9ac085d34eeefb76f29b1f32f1c8c);
			this.c15ff06bceba4a352a6336f85a53d9362.Controls.Add(this.c8c959c736abffa00d6a86ecc9972d912);
			this.c15ff06bceba4a352a6336f85a53d9362.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14796);
			this.c15ff06bceba4a352a6336f85a53d9362.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14800), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14804), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14808), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14812));
			this.c15ff06bceba4a352a6336f85a53d9362.ForeColor = Color.FromArgb(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14816), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14820), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14824));
			this.c15ff06bceba4a352a6336f85a53d9362.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14828), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14832));
			this.c15ff06bceba4a352a6336f85a53d9362.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55679);
			this.c15ff06bceba4a352a6336f85a53d9362.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14836), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14840));
			this.c15ff06bceba4a352a6336f85a53d9362.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14844);
			this.c15ff06bceba4a352a6336f85a53d9362.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55694);
			this.c15ff06bceba4a352a6336f85a53d9362.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14848);
			this.ccee9ac085d34eeefb76f29b1f32f1c8c.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14852) != 0);
			this.ccee9ac085d34eeefb76f29b1f32f1c8c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14856), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14860));
			this.ccee9ac085d34eeefb76f29b1f32f1c8c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55733);
			this.ccee9ac085d34eeefb76f29b1f32f1c8c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14864), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14868));
			this.ccee9ac085d34eeefb76f29b1f32f1c8c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14872);
			this.ccee9ac085d34eeefb76f29b1f32f1c8c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55750);
			this.c8c959c736abffa00d6a86ecc9972d912.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14876), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14880));
			this.c8c959c736abffa00d6a86ecc9972d912.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55811);
			this.c8c959c736abffa00d6a86ecc9972d912.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14884), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14888));
			this.c8c959c736abffa00d6a86ecc9972d912.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14892);
			this.c8c959c736abffa00d6a86ecc9972d912.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55830);
			this.c8c959c736abffa00d6a86ecc9972d912.Click += this.ca7388291853951a253ad9259a84b82b3;
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Image = c6faa5467be1a4874657b372a49b7c927.icnSd;
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14896), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14900));
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55849);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14904));
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14908), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14912));
			this.cd792ac67bdacd5b7947dd1479f77c2a6.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14916);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55874);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14920);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.TextImageRelation = (TextImageRelation)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14924);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.cd792ac67bdacd5b7947dd1479f77c2a6.Click += this.cb1aed5a5240e442510f74197c00a9c4f;
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14928), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14932));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14936), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14940));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14944);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55901);
			this.c90e121b7434f8af2291ea96c07d8818e.Image = c6faa5467be1a4874657b372a49b7c927.warning;
			this.c90e121b7434f8af2291ea96c07d8818e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14948), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14952));
			this.c90e121b7434f8af2291ea96c07d8818e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43738);
			this.c90e121b7434f8af2291ea96c07d8818e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14956), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14960));
			this.c90e121b7434f8af2291ea96c07d8818e.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14964);
			this.c90e121b7434f8af2291ea96c07d8818e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14968);
			this.c90e121b7434f8af2291ea96c07d8818e.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14972) != 0);
			this.c1e664eedc77244516df32f78879cbd6a.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14976), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14980));
			this.c1e664eedc77244516df32f78879cbd6a.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43700);
			this.c1e664eedc77244516df32f78879cbd6a.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14984), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14988));
			this.c1e664eedc77244516df32f78879cbd6a.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14992);
			this.c1e664eedc77244516df32f78879cbd6a.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14996);
			this.c1e664eedc77244516df32f78879cbd6a.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15000) != 0);
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15004), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15008), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15012), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15016));
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15024));
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(56199);
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15028), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15032));
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15036);
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.Text = componentResourceManager.GetString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(56216));
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15040), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(15044));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15048);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15052), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15056));
			base.Controls.Add(this.ca6c1cea062503a0a580756cf1f1f0961);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15060);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(56243);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15064) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15068) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15072);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(55464);
			base.Load += this.c5537739175d27c853c0a5f97bc0bb6b7;
			this.ca6c1cea062503a0a580756cf1f1f0961.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15076) != 0);
			this.ca6c1cea062503a0a580756cf1f1f0961.PerformLayout();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.c17d8b285e03a5f7ce51ad362751d6783.EndInit();
			this.cfbf47a059c73dd11f631963362e53c2f.EndInit();
			this.cfbf47a059c73dd11f631963362e53c2f.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15080) != 0);
			this.c15ff06bceba4a352a6336f85a53d9362.EndInit();
			this.c15ff06bceba4a352a6336f85a53d9362.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15084) != 0);
			this.c15ff06bceba4a352a6336f85a53d9362.PerformLayout();
			this.c8c959c736abffa00d6a86ecc9972d912.EndInit();
			this.cd792ac67bdacd5b7947dd1479f77c2a6.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			((ISupportInitialize)this.c90e121b7434f8af2291ea96c07d8818e).EndInit();
			((ISupportInitialize)this.c1e664eedc77244516df32f78879cbd6a).EndInit();
			this.c6abfbd30528d76e1d6eea1ee59f2a5e4.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15088) != 0);
		}

		// Token: 0x0400039C RID: 924
		private const string ca5072543a15a01e80eded63f497c223a = "<html><p><strong><span style=\"font-size: 10pt\">Welcome to the USB Helper Injection Tool!</span></strong></p><p></p><p>You have selected a title which is normally not available on the eShop.</p><p>USB Helper allows you to build a game that will be launchable from the home menu.</p><p>This way you can enjoy Gamecube games with your Wii U Gamepad!</p><p>USB Helper will take care of almost everything for you!</p><p><span style=\"color: #ff8000\">The only thing you have to do is to provide the required ISO.</span></p><p>Just drop it in the box below and have fun!<br /><span style=\"color: #000000\"> <p></p><p></p></span></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p></html>";

		// Token: 0x0400039D RID: 925
		private string c8861d7dda4ce3c892b8aabbaf69cf6a1;

		// Token: 0x0400039E RID: 926
		private c4c1cf20119750bfee2a0bb499f990883 c37d2facd9960e8126dd1ced72f3b8686;

		// Token: 0x0400039F RID: 927
		private c5409344e1c2b74fa8c9a4d620ccb8d48 c21c18a763402a75241db42319702676a;

		// Token: 0x040003A0 RID: 928
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x040003A1 RID: 929
		private RadGroupBox ca6c1cea062503a0a580756cf1f1f0961;

		// Token: 0x040003A2 RID: 930
		private RadLabel c6abfbd30528d76e1d6eea1ee59f2a5e4;

		// Token: 0x040003A3 RID: 931
		private RadGroupBox cfbf47a059c73dd11f631963362e53c2f;

		// Token: 0x040003A4 RID: 932
		private PictureBox c1e664eedc77244516df32f78879cbd6a;

		// Token: 0x040003A5 RID: 933
		private RadLabel c15ff06bceba4a352a6336f85a53d9362;

		// Token: 0x040003A6 RID: 934
		private PictureBox c90e121b7434f8af2291ea96c07d8818e;

		// Token: 0x040003A7 RID: 935
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;

		// Token: 0x040003A8 RID: 936
		private RadButton cd792ac67bdacd5b7947dd1479f77c2a6;

		// Token: 0x040003A9 RID: 937
		private RadButton c8c959c736abffa00d6a86ecc9972d912;

		// Token: 0x040003AA RID: 938
		private RadCheckBox c17d8b285e03a5f7ce51ad362751d6783;

		// Token: 0x040003AB RID: 939
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x040003AC RID: 940
		private Label ccee9ac085d34eeefb76f29b1f32f1c8c;

		// Token: 0x040003AD RID: 941
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;

		// Token: 0x02000158 RID: 344
		internal sealed class c412f4868af2e393a341d625838ac19a3
		{
			// Token: 0x0400070F RID: 1807
			[JsonProperty("force43")]
			public bool cb379f244d5d80f6856a299c93cb57e68;
		}
	}
}
