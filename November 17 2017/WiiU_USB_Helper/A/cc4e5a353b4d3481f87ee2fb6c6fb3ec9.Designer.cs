using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000BB RID: 187
	public class cc4e5a353b4d3481f87ee2fb6c6fb3ec9 : RadForm
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x000307C8 File Offset: 0x0002E9C8
		public cc4e5a353b4d3481f87ee2fb6c6fb3ec9()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000307E4 File Offset: 0x0002E9E4
		private void ca4fd266539b28416295e5ea943313fcb(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000307F4 File Offset: 0x0002E9F4
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13984);
			base.Close();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00030818 File Offset: 0x0002EA18
		private void c0b961a93651ab95be91c5bbe046e48f0(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			if (string.IsNullOrEmpty(this.c33bdb1509d9d96221f852429af216e7f.Text.Trim()))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc4e5a353b4d3481f87ee2fb6c6fb3ec9.c0b961a93651ab95be91c5bbe046e48f0(object, EventArgs)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52154));
				return;
			}
			this.c31b5179e91518e056df31f49ab65715a = this.c33bdb1509d9d96221f852429af216e7f.Text.Trim();
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13988);
			base.Close();
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0003089C File Offset: 0x0002EA9C
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc4e5a353b4d3481f87ee2fb6c6fb3ec9.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000308E4 File Offset: 0x0002EAE4
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c33bdb1509d9d96221f852429af216e7f = new RadTextBox();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.c2c8d44779f98bfe24d29fc0ee952d02d = new RadButton();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c33bdb1509d9d96221f852429af216e7f.BeginInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			this.c2c8d44779f98bfe24d29fc0ee952d02d.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.c4553ed186725b714efcccc71bbe10a0f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13992) != 0);
			this.c4553ed186725b714efcccc71bbe10a0f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13996);
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14000), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14004));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14008), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14012));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14016);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52219);
			this.c4553ed186725b714efcccc71bbe10a0f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14020);
			this.c33bdb1509d9d96221f852429af216e7f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14024) != 0);
			this.c33bdb1509d9d96221f852429af216e7f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14028);
			this.c33bdb1509d9d96221f852429af216e7f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14032), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14036));
			this.c33bdb1509d9d96221f852429af216e7f.Multiline = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14040) != 0);
			this.c33bdb1509d9d96221f852429af216e7f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52342);
			this.c33bdb1509d9d96221f852429af216e7f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14044), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14048));
			this.c33bdb1509d9d96221f852429af216e7f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14052);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14056);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14060), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14064));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14068), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14072));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14076);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52081);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14080);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14084), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14088));
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52047);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14092), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14096));
			this.c2c8d44779f98bfe24d29fc0ee952d02d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14100);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52371);
			this.c2c8d44779f98bfe24d29fc0ee952d02d.Click += this.c0b961a93651ab95be91c5bbe046e48f0;
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14104), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(14108));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14112);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14116), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14120));
			base.Controls.Add(this.c33bdb1509d9d96221f852429af216e7f);
			base.Controls.Add(this.c2c8d44779f98bfe24d29fc0ee952d02d);
			base.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			base.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14124);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52384);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14128));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14132) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14136) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14140);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(52411);
			base.Load += this.ca4fd266539b28416295e5ea943313fcb;
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c33bdb1509d9d96221f852429af216e7f.EndInit();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			this.c2c8d44779f98bfe24d29fc0ee952d02d.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(14144) != 0);
		}

		// Token: 0x04000389 RID: 905
		public string c31b5179e91518e056df31f49ab65715a;

		// Token: 0x0400038A RID: 906
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x0400038B RID: 907
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x0400038C RID: 908
		private RadTextBox c33bdb1509d9d96221f852429af216e7f;

		// Token: 0x0400038D RID: 909
		private RadButton c2c8d44779f98bfe24d29fc0ee952d02d;

		// Token: 0x0400038E RID: 910
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;
	}
}
