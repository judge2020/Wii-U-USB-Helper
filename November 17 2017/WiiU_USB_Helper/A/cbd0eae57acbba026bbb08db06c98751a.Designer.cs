using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace A
{
	// Token: 0x020000C3 RID: 195
	public class cbd0eae57acbba026bbb08db06c98751a : RadForm
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x000354CC File Offset: 0x000336CC
		public cbd0eae57acbba026bbb08db06c98751a()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000354E8 File Offset: 0x000336E8
		private void c8fc101fc09e3f9846095879beb172cb3(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			IEnumerator enumerator = ThemeResolutionService.GetAvailableThemes().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object c0d6c37d812d5d4b610705a6421056252 = enumerator.Current;
					Theme theme = c2f33e217ef363f33c50a85e733ee1300.c0b398ab350e72b0d64d512bae8520b85(c0d6c37d812d5d4b610705a6421056252);
					string text = theme.Name;
					bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15952) != 0;
					if ((int)text[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15956)] == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15960))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cbd0eae57acbba026bbb08db06c98751a.c8fc101fc09e3f9846095879beb172cb3(object, EventArgs)).MethodHandle;
						}
						text = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text.Substring(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15964)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60342));
						flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15968) != 0);
					}
					ListViewDataItem listViewDataItem = new ListViewDataItem(text)
					{
						Tag = new cbd0eae57acbba026bbb08db06c98751a.ca6dec164295c44b24d711daf36d67bb5
						{
							c8885065b43918fb8e7228cb4b79488c4 = flag,
							cbf8c6ddbcadcae3a9a8281db3be762c1 = theme
						}
					};
					if (flag)
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
						listViewDataItem.ForeColor = Color.DarkOrange;
					}
					this.ccdbe2b08245f0a51e2b64b1e5400d167.Items.Add(listViewDataItem);
				}
				for (;;)
				{
					switch (7)
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
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					disposable.Dispose();
				}
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00035640 File Offset: 0x00033840
		private void cf119e967eacb82b01238717ed6221aeb(object cd7b28952603b35a45c555982e677363a, ListViewItemEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cbd0eae57acbba026bbb08db06c98751a.ca6dec164295c44b24d711daf36d67bb5 ca6dec164295c44b24d711daf36d67bb = (cbd0eae57acbba026bbb08db06c98751a.ca6dec164295c44b24d711daf36d67bb5)cdf15457ee4816989343b6e6e96dd4cfe.Item.Tag;
			if (ca6dec164295c44b24d711daf36d67bb.c8885065b43918fb8e7228cb4b79488c4)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cbd0eae57acbba026bbb08db06c98751a.cf119e967eacb82b01238717ed6221aeb(object, ListViewItemEventArgs)).MethodHandle;
				}
				if (!cacd6f8420e56d296adef754f4a362ae7.c3fcf5c54f75fc17c7e5ebe876702d817)
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
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60371));
					return;
				}
			}
			Settings.Default.ThemeName = ca6dec164295c44b24d711daf36d67bb.cbf8c6ddbcadcae3a9a8281db3be762c1.Name;
			Settings.Default.Save();
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60647));
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000356E0 File Offset: 0x000338E0
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cbd0eae57acbba026bbb08db06c98751a.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00035728 File Offset: 0x00033928
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.ccdbe2b08245f0a51e2b64b1e5400d167 = new RadListView();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.ccdbe2b08245f0a51e2b64b1e5400d167.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c4553ed186725b714efcccc71bbe10a0f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15972) != 0);
			this.c4553ed186725b714efcccc71bbe10a0f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15976);
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15980), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15984));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15988), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15992));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(15996);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60756);
			this.c4553ed186725b714efcccc71bbe10a0f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16000);
			this.ccdbe2b08245f0a51e2b64b1e5400d167.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16004);
			this.ccdbe2b08245f0a51e2b64b1e5400d167.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16008), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16012));
			this.ccdbe2b08245f0a51e2b64b1e5400d167.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60799);
			this.ccdbe2b08245f0a51e2b64b1e5400d167.SelectLastAddedItem = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16016) != 0);
			this.ccdbe2b08245f0a51e2b64b1e5400d167.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16020), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16024));
			this.ccdbe2b08245f0a51e2b64b1e5400d167.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16028);
			this.ccdbe2b08245f0a51e2b64b1e5400d167.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50356);
			this.ccdbe2b08245f0a51e2b64b1e5400d167.ItemMouseClick += new ListViewItemEventHandler(this.cf119e967eacb82b01238717ed6221aeb);
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(16032), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(16036));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16040);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16044), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16048));
			base.Controls.Add(this.ccdbe2b08245f0a51e2b64b1e5400d167);
			base.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16052);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60818);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16056));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16060) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16064) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16068);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(60847);
			base.Load += this.c8fc101fc09e3f9846095879beb172cb3;
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.ccdbe2b08245f0a51e2b64b1e5400d167.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(16072) != 0);
		}

		// Token: 0x040003CE RID: 974
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x040003CF RID: 975
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x040003D0 RID: 976
		private RadListView ccdbe2b08245f0a51e2b64b1e5400d167;

		// Token: 0x0200015D RID: 349
		internal struct ca6dec164295c44b24d711daf36d67bb5
		{
			// Token: 0x04000719 RID: 1817
			public bool c8885065b43918fb8e7228cb4b79488c4;

			// Token: 0x0400071A RID: 1818
			public Theme cbf8c6ddbcadcae3a9a8281db3be762c1;
		}
	}
}
