using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000A6 RID: 166
	public class c8182050bde64f716a9855055b4bd295b : RadForm
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x0002360C File Offset: 0x0002180C
		public c8182050bde64f716a9855055b4bd295b()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00023628 File Offset: 0x00021828
		private static bool ce09dadc97335bd2a78e65370a288fa39(EventArrivedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			PropertyDataCollection.PropertyDataEnumerator enumerator = c3c9260886a6db15de49329a9f5b9836c.NewEvent.Properties.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(enumerator.Current.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41871)))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.ce09dadc97335bd2a78e65370a288fa39(EventArrivedEventArgs)).MethodHandle;
						}
						return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9448) != 0;
					}
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
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9452) != 0;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000236E4 File Offset: 0x000218E4
		private void c06776b45189a50812777a1c227a63a3b(object cd7b28952603b35a45c555982e677363a, EventArrivedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			PropertyDataCollection.PropertyDataEnumerator enumerator = c8b71d35a8b17aa98ded59f739c7fca9e.cd24593c859565ebb8c9faabbc5c75bef(cdf15457ee4816989343b6e6e96dd4cfe.NewEvent[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41890)]).Properties.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					PropertyData propertyData = enumerator.Current;
					Console.WriteLine(c023ef59998c1544cc2d1887c8e5ee879.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(propertyData.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41919), propertyData.Value));
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.c06776b45189a50812777a1c227a63a3b(object, EventArrivedEventArgs)).MethodHandle;
				}
			}
			finally
			{
				IDisposable disposable = c2f4016fa04d8c2b2a9dba60e295715d5.c0b398ab350e72b0d64d512bae8520b85(enumerator);
				if (disposable != null)
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
					disposable.Dispose();
				}
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000237A4 File Offset: 0x000219A4
		private void c82d7883a7abe25a854af6e4bac88d356(object cd7b28952603b35a45c555982e677363a, EventArrivedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			PropertyDataCollection.PropertyDataEnumerator enumerator = c8b71d35a8b17aa98ded59f739c7fca9e.cd24593c859565ebb8c9faabbc5c75bef(cdf15457ee4816989343b6e6e96dd4cfe.NewEvent[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41890)]).Properties.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					PropertyData propertyData = enumerator.Current;
					Console.WriteLine(c023ef59998c1544cc2d1887c8e5ee879.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(propertyData.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41919), propertyData.Value));
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.c82d7883a7abe25a854af6e4bac88d356(object, EventArrivedEventArgs)).MethodHandle;
				}
			}
			finally
			{
				IDisposable disposable = c2f4016fa04d8c2b2a9dba60e295715d5.c0b398ab350e72b0d64d512bae8520b85(enumerator);
				if (disposable != null)
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
					disposable.Dispose();
				}
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00023864 File Offset: 0x00021A64
		private void ca2d6512d11cdd3b7dfbc112a9e4f998c(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c1a131d2bb02b92f346def88860c4b10c();
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00023878 File Offset: 0x00021A78
		private void c51b6fd66e245f7f987701a5bc8e13dc9(DriveInfo cb33decdc9e5663a9827f5479abd1bd77, Action c77655bda83ba64796b2ce8793906f33b, Action cb7444d505bc0fa01c1036e4dc732770a)
		{
			string path = Path.Combine(cb33decdc9e5663a9827f5479abd1bd77.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41926));
			string path2 = Path.Combine(cb33decdc9e5663a9827f5479abd1bd77.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41941));
			if (File.Exists(path))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.c51b6fd66e245f7f987701a5bc8e13dc9(DriveInfo, Action, Action)).MethodHandle;
				}
				if (File.Exists(path2))
				{
					goto IL_7C;
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
			if (cb7444d505bc0fa01c1036e4dc732770a != null)
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
				cb7444d505bc0fa01c1036e4dc732770a();
			}
			IL_7C:
			this.c0ad8b7b12aeceb9a89e5159284ac7ed2 = File.ReadAllBytes(path);
			this.cea98f5326b814d9bec873ad8315313df = File.ReadAllBytes(path2);
			if (c77655bda83ba64796b2ce8793906f33b != null)
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
				c77655bda83ba64796b2ce8793906f33b();
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00023930 File Offset: 0x00021B30
		private void c5219955baedc5bea94f35915314962fe(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.Close();
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00023944 File Offset: 0x00021B44
		private void c1a131d2bb02b92f346def88860c4b10c()
		{
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SelectedPage = this.ccbb46cbb0c94f616726f6fe2c6382b04.Pages[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9456)];
			this.ce1d892d8057ff475a77b5adc3b033e04(new Action<EventArrivedEventArgs>(this.c4078e568a27972494b3db4a02f87147d), c4422d25e7997ab98f050776daca5ac6c.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00023994 File Offset: 0x00021B94
		private void c8dea81106f5fe1831b61b3a6732cf76b()
		{
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SelectedPage = this.ccbb46cbb0c94f616726f6fe2c6382b04.Pages[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9460)];
			this.ce1d892d8057ff475a77b5adc3b033e04(new Action<EventArrivedEventArgs>(this.c24ab236f741a3c87b0c48f44caaf0357), c4422d25e7997ab98f050776daca5ac6c.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000239E4 File Offset: 0x00021BE4
		private void cd443db314b2afe5d78d72ac4d55861f2()
		{
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SelectedPage = this.ccbb46cbb0c94f616726f6fe2c6382b04.Pages[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9464)];
			cc01ff6ada6bedc91d308c62d456e9145.c8fb9472a0ed26842fb80c89d8f70efd8(new Action<c58b5beca5c1ecb9bea001c3625c4c2bd>(this.ca7f962edd2593f567eff34c65c478f70));
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00023A2C File Offset: 0x00021C2C
		private void ca7f962edd2593f567eff34c65c478f70(c58b5beca5c1ecb9bea001c3625c4c2bd cfaf1debf3a970d5952403821f47faf6f)
		{
			c8182050bde64f716a9855055b4bd295b.c764c192438aaf63d1b7d5af37f775833 c764c192438aaf63d1b7d5af37f = new c8182050bde64f716a9855055b4bd295b.c764c192438aaf63d1b7d5af37f775833();
			c764c192438aaf63d1b7d5af37f.c4404a159870bf55bb6f111e66e59e82d = this;
			c764c192438aaf63d1b7d5af37f.cfaf1debf3a970d5952403821f47faf6f = cfaf1debf3a970d5952403821f47faf6f;
			try
			{
				base.Invoke(new MethodInvoker(c764c192438aaf63d1b7d5af37f.c5379b002c2d6cd75344a454e2127e637));
			}
			catch
			{
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00023A78 File Offset: 0x00021C78
		private void ce1d892d8057ff475a77b5adc3b033e04(Action<EventArrivedEventArgs> cc5311ae3fb065285d00d648f1e2c499f, Action<EventArrivedEventArgs> c66af968a63bc828758428a58a4220347 = null)
		{
			c8182050bde64f716a9855055b4bd295b.ca166dc58c6225570137b6dff36d44d67 ca166dc58c6225570137b6dff36d44d = new c8182050bde64f716a9855055b4bd295b.ca166dc58c6225570137b6dff36d44d67();
			ca166dc58c6225570137b6dff36d44d.c4404a159870bf55bb6f111e66e59e82d = this;
			ca166dc58c6225570137b6dff36d44d.cc5311ae3fb065285d00d648f1e2c499f = cc5311ae3fb065285d00d648f1e2c499f;
			ca166dc58c6225570137b6dff36d44d.c66af968a63bc828758428a58a4220347 = c66af968a63bc828758428a58a4220347;
			WqlEventQuery query = new WqlEventQuery(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41964));
			ca166dc58c6225570137b6dff36d44d.c775ecebe54de6681e30b2fbca1266e01 = new ManagementEventWatcher(query);
			ca166dc58c6225570137b6dff36d44d.c775ecebe54de6681e30b2fbca1266e01.EventArrived += ca166dc58c6225570137b6dff36d44d.c01ec3af5e565e7531ea9daa785193240;
			ca166dc58c6225570137b6dff36d44d.c775ecebe54de6681e30b2fbca1266e01.Start();
			WqlEventQuery query2 = new WqlEventQuery(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42079));
			ca166dc58c6225570137b6dff36d44d.ca595951501f754c52f6ba39b8ccf3c97 = new ManagementEventWatcher(query2);
			ca166dc58c6225570137b6dff36d44d.ca595951501f754c52f6ba39b8ccf3c97.EventArrived += ca166dc58c6225570137b6dff36d44d.c35f66702a2b097b5dcc8b463f9f7230d;
			ca166dc58c6225570137b6dff36d44d.ca595951501f754c52f6ba39b8ccf3c97.Start();
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00023B20 File Offset: 0x00021D20
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00023B68 File Offset: 0x00021D68
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cdd2def75b501bdd47fe0bc95335ac6db.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.ccbb46cbb0c94f616726f6fe2c6382b04 = new RadPageView();
			this.c35044d42a83bc018f2691f443a7b5ddc = new RadPageViewPage();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f = new RadPageViewPage();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.cee9eb68f8e87aee9d3246553c1d77f82 = new RadPageViewPage();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c9bdeb87a4d379c2ee399a4438fe91509 = new RadPageViewPage();
			this.c362e39f066aef56acd25812b83e7da57 = new RadLabel();
			this.c7b9b66d26c7a44b0116c83b78c5d70da = new RadButton();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.BeginInit();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SuspendLayout();
			this.c35044d42a83bc018f2691f443a7b5ddc.SuspendLayout();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.SuspendLayout();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.cee9eb68f8e87aee9d3246553c1d77f82.SuspendLayout();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			this.c9bdeb87a4d379c2ee399a4438fe91509.SuspendLayout();
			this.c362e39f066aef56acd25812b83e7da57.BeginInit();
			this.c362e39f066aef56acd25812b83e7da57.SuspendLayout();
			this.c7b9b66d26c7a44b0116c83b78c5d70da.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Controls.Add(this.c35044d42a83bc018f2691f443a7b5ddc);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Controls.Add(this.c19da0748e0f5dbdcc73ede3a18a2ef9f);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Controls.Add(this.cee9eb68f8e87aee9d3246553c1d77f82);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Controls.Add(this.c9bdeb87a4d379c2ee399a4438fe91509);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9468);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.ImeMode = (ImeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9472);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9476), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9480));
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42194);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.SelectedPage = this.c35044d42a83bc018f2691f443a7b5ddc;
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9484), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9488));
			this.ccbb46cbb0c94f616726f6fe2c6382b04.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9492);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42194);
			this.ccbb46cbb0c94f616726f6fe2c6382b04.ViewMode = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9496);
			this.c35044d42a83bc018f2691f443a7b5ddc.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			this.c35044d42a83bc018f2691f443a7b5ddc.ItemSize = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9500), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9504));
			this.c35044d42a83bc018f2691f443a7b5ddc.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9508), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9512));
			this.c35044d42a83bc018f2691f443a7b5ddc.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42219);
			this.c35044d42a83bc018f2691f443a7b5ddc.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9516), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9520));
			this.c35044d42a83bc018f2691f443a7b5ddc.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42230);
			this.c4553ed186725b714efcccc71bbe10a0f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9524) != 0);
			this.c4553ed186725b714efcccc71bbe10a0f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9528);
			this.c4553ed186725b714efcccc71bbe10a0f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9532), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9536), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9540), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9544));
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9548), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9552));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9556), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9560));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9564);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = componentResourceManager.GetString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42299));
			this.c4553ed186725b714efcccc71bbe10a0f.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9568);
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.ItemSize = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9572), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9576));
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9580), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9584));
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42328);
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9588), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9592));
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42339);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9596) != 0);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9600);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9604), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9608), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9612), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9616));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9620), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9624));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9628), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9632));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9636);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Text = componentResourceManager.GetString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42407));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			this.cee9eb68f8e87aee9d3246553c1d77f82.ItemSize = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9640), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9644));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9648), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9652));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42436);
			this.cee9eb68f8e87aee9d3246553c1d77f82.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9656), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9660));
			this.cee9eb68f8e87aee9d3246553c1d77f82.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42469);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9664) != 0);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9668);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9672), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9676), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9680), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9684));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9688), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9692));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9696), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9700));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9704);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42553);
			this.c9bdeb87a4d379c2ee399a4438fe91509.Controls.Add(this.c362e39f066aef56acd25812b83e7da57);
			this.c9bdeb87a4d379c2ee399a4438fe91509.ItemSize = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9708), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9712));
			this.c9bdeb87a4d379c2ee399a4438fe91509.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9716), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9720));
			this.c9bdeb87a4d379c2ee399a4438fe91509.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42921);
			this.c9bdeb87a4d379c2ee399a4438fe91509.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9724), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9728));
			this.c9bdeb87a4d379c2ee399a4438fe91509.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42954);
			this.c362e39f066aef56acd25812b83e7da57.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9732) != 0);
			this.c362e39f066aef56acd25812b83e7da57.Controls.Add(this.c7b9b66d26c7a44b0116c83b78c5d70da);
			this.c362e39f066aef56acd25812b83e7da57.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9736);
			this.c362e39f066aef56acd25812b83e7da57.Font = new Font(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42263), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9740), (FontStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9744), (GraphicsUnit)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9748), (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9752));
			this.c362e39f066aef56acd25812b83e7da57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9756), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9760));
			this.c362e39f066aef56acd25812b83e7da57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42983);
			this.c362e39f066aef56acd25812b83e7da57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9764), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9768));
			this.c362e39f066aef56acd25812b83e7da57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9772);
			this.c362e39f066aef56acd25812b83e7da57.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43002);
			this.c362e39f066aef56acd25812b83e7da57.TextAlignment = (ContentAlignment)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9776);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9780), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9784));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43101);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9788), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9792));
			this.c7b9b66d26c7a44b0116c83b78c5d70da.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9796);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43122);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.Click += this.c5219955baedc5bea94f35915314962fe;
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9800), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(9804));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9808);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9812), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9816));
			base.Controls.Add(this.ccbb46cbb0c94f616726f6fe2c6382b04);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9820);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43152);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9824) != 0);
			base.ShowIcon = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9828) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9832);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43179);
			base.Load += this.ca2d6512d11cdd3b7dfbc112a9e4f998c;
			this.ccbb46cbb0c94f616726f6fe2c6382b04.EndInit();
			this.ccbb46cbb0c94f616726f6fe2c6382b04.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9836) != 0);
			this.c35044d42a83bc018f2691f443a7b5ddc.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9840) != 0);
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c19da0748e0f5dbdcc73ede3a18a2ef9f.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9844) != 0);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.cee9eb68f8e87aee9d3246553c1d77f82.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9848) != 0);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			this.c9bdeb87a4d379c2ee399a4438fe91509.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9852) != 0);
			this.c362e39f066aef56acd25812b83e7da57.EndInit();
			this.c362e39f066aef56acd25812b83e7da57.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9856) != 0);
			this.c7b9b66d26c7a44b0116c83b78c5d70da.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9860) != 0);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00024754 File Offset: 0x00022954
		[CompilerGenerated]
		private void c4078e568a27972494b3db4a02f87147d(EventArrivedEventArgs c26822581df016083af37ec10f7059fe9)
		{
			c8182050bde64f716a9855055b4bd295b.cbb2644fad8a94ad2f11bf6e76fb1b74a cbb2644fad8a94ad2f11bf6e76fb1b74a = new c8182050bde64f716a9855055b4bd295b.cbb2644fad8a94ad2f11bf6e76fb1b74a();
			cbb2644fad8a94ad2f11bf6e76fb1b74a.c4404a159870bf55bb6f111e66e59e82d = this;
			cbb2644fad8a94ad2f11bf6e76fb1b74a.cb33decdc9e5663a9827f5479abd1bd77 = new DriveInfo(c26822581df016083af37ec10f7059fe9.NewEvent.Properties[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41871)].Value.ToString());
			this.c51b6fd66e245f7f987701a5bc8e13dc9(cbb2644fad8a94ad2f11bf6e76fb1b74a.cb33decdc9e5663a9827f5479abd1bd77, new Action(this.c959e6755d50a3ed78c876a6501a1a3e1), new Action(cbb2644fad8a94ad2f11bf6e76fb1b74a.c166fc909bfeee561d4665e8f90d647ae));
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000247D0 File Offset: 0x000229D0
		[CompilerGenerated]
		private void c959e6755d50a3ed78c876a6501a1a3e1()
		{
			this.cd443db314b2afe5d78d72ac4d55861f2();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000247E4 File Offset: 0x000229E4
		[CompilerGenerated]
		private void c24ab236f741a3c87b0c48f44caaf0357(EventArrivedEventArgs c26822581df016083af37ec10f7059fe9)
		{
			DriveInfo cb33decdc9e5663a9827f5479abd1bd = new DriveInfo(c26822581df016083af37ec10f7059fe9.NewEvent.Properties[ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41871)].Value.ToString());
			this.c51b6fd66e245f7f987701a5bc8e13dc9(cb33decdc9e5663a9827f5479abd1bd, new Action(this.c6e01f4eb6fb6e86f08644cc93004c438), new Action(this.c05b8a7a480a757cb6c5a5e32352641b1));
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00024848 File Offset: 0x00022A48
		[CompilerGenerated]
		private void c6e01f4eb6fb6e86f08644cc93004c438()
		{
			this.cd443db314b2afe5d78d72ac4d55861f2();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0002485C File Offset: 0x00022A5C
		[CompilerGenerated]
		private void c05b8a7a480a757cb6c5a5e32352641b1()
		{
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43210));
			this.c8dea81106f5fe1831b61b3a6732cf76b();
		}

		// Token: 0x040002C2 RID: 706
		private byte[] c0ad8b7b12aeceb9a89e5159284ac7ed2;

		// Token: 0x040002C3 RID: 707
		private byte[] cea98f5326b814d9bec873ad8315313df;

		// Token: 0x040002C4 RID: 708
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x040002C5 RID: 709
		private RadPageView ccbb46cbb0c94f616726f6fe2c6382b04;

		// Token: 0x040002C6 RID: 710
		private RadPageViewPage c35044d42a83bc018f2691f443a7b5ddc;

		// Token: 0x040002C7 RID: 711
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x040002C8 RID: 712
		private RadPageViewPage c19da0748e0f5dbdcc73ede3a18a2ef9f;

		// Token: 0x040002C9 RID: 713
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x040002CA RID: 714
		private RadPageViewPage cee9eb68f8e87aee9d3246553c1d77f82;

		// Token: 0x040002CB RID: 715
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;

		// Token: 0x040002CC RID: 716
		private RadPageViewPage c9bdeb87a4d379c2ee399a4438fe91509;

		// Token: 0x040002CD RID: 717
		private RadLabel c362e39f066aef56acd25812b83e7da57;

		// Token: 0x040002CE RID: 718
		private RadButton c7b9b66d26c7a44b0116c83b78c5d70da;

		// Token: 0x0200013A RID: 314
		[CompilerGenerated]
		private sealed class cbb2644fad8a94ad2f11bf6e76fb1b74a
		{
			// Token: 0x06000942 RID: 2370 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
			internal void c166fc909bfeee561d4665e8f90d647ae()
			{
				if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cb33decdc9e5663a9827f5479abd1bd77.DriveFormat, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75201)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.cbb2644fad8a94ad2f11bf6e76fb1b74a.c166fc909bfeee561d4665e8f90d647ae()).MethodHandle;
					}
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(75212));
					this.c4404a159870bf55bb6f111e66e59e82d.c1a131d2bb02b92f346def88860c4b10c();
					return;
				}
				cd4880843d42f3dd634ca35c8e909b573.c45cbdcfae4ad6f5a5c450c69a0162043(this.cb33decdc9e5663a9827f5479abd1bd77.Name);
				this.c4404a159870bf55bb6f111e66e59e82d.c8dea81106f5fe1831b61b3a6732cf76b();
			}

			// Token: 0x040006CC RID: 1740
			public DriveInfo cb33decdc9e5663a9827f5479abd1bd77;

			// Token: 0x040006CD RID: 1741
			public c8182050bde64f716a9855055b4bd295b c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200013B RID: 315
		[CompilerGenerated]
		private sealed class c764c192438aaf63d1b7d5af37f775833
		{
			// Token: 0x06000944 RID: 2372 RVA: 0x0005EF84 File Offset: 0x0005D184
			internal void c5379b002c2d6cd75344a454e2127e637()
			{
				this.cfaf1debf3a970d5952403821f47faf6f.cf75119406f595a9c0c866f4d485a223d(this.c4404a159870bf55bb6f111e66e59e82d.c0ad8b7b12aeceb9a89e5159284ac7ed2, this.c4404a159870bf55bb6f111e66e59e82d.cea98f5326b814d9bec873ad8315313df);
				this.c4404a159870bf55bb6f111e66e59e82d.ccbb46cbb0c94f616726f6fe2c6382b04.SelectedPage = this.c4404a159870bf55bb6f111e66e59e82d.ccbb46cbb0c94f616726f6fe2c6382b04.Pages[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30576)];
			}

			// Token: 0x040006CE RID: 1742
			public c58b5beca5c1ecb9bea001c3625c4c2bd cfaf1debf3a970d5952403821f47faf6f;

			// Token: 0x040006CF RID: 1743
			public c8182050bde64f716a9855055b4bd295b c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200013C RID: 316
		[CompilerGenerated]
		private sealed class ca166dc58c6225570137b6dff36d44d67
		{
			// Token: 0x06000946 RID: 2374 RVA: 0x0005EFFC File Offset: 0x0005D1FC
			internal void c01ec3af5e565e7531ea9daa785193240(object cb0d7b0b893a41a39e281ddc32fc698bd, EventArrivedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				c8182050bde64f716a9855055b4bd295b.c8c33abb353a0689d83865a38c8cd419e c8c33abb353a0689d83865a38c8cd419e = new c8182050bde64f716a9855055b4bd295b.c8c33abb353a0689d83865a38c8cd419e();
				c8c33abb353a0689d83865a38c8cd419e.c8c38354cddaefb45b9cfcd9ed2838c37 = this;
				c8c33abb353a0689d83865a38c8cd419e.cdf15457ee4816989343b6e6e96dd4cfe = cdf15457ee4816989343b6e6e96dd4cfe;
				if (!c8182050bde64f716a9855055b4bd295b.ce09dadc97335bd2a78e65370a288fa39(c8c33abb353a0689d83865a38c8cd419e.cdf15457ee4816989343b6e6e96dd4cfe))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.ca166dc58c6225570137b6dff36d44d67.c01ec3af5e565e7531ea9daa785193240(object, EventArrivedEventArgs)).MethodHandle;
					}
					return;
				}
				this.c775ecebe54de6681e30b2fbca1266e01.Stop();
				this.c775ecebe54de6681e30b2fbca1266e01.Dispose();
				this.c4404a159870bf55bb6f111e66e59e82d.Invoke(new MethodInvoker(c8c33abb353a0689d83865a38c8cd419e.cf05b07fe96fc07392434cbbc7a1017f8));
			}

			// Token: 0x06000947 RID: 2375 RVA: 0x0005F070 File Offset: 0x0005D270
			internal void c35f66702a2b097b5dcc8b463f9f7230d(object cb0d7b0b893a41a39e281ddc32fc698bd, EventArrivedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				c8182050bde64f716a9855055b4bd295b.c0074a0b15015abd20b244b0f8c3098ee c0074a0b15015abd20b244b0f8c3098ee = new c8182050bde64f716a9855055b4bd295b.c0074a0b15015abd20b244b0f8c3098ee();
				c0074a0b15015abd20b244b0f8c3098ee.c9def284befdb85aa51808c134f9b5700 = this;
				c0074a0b15015abd20b244b0f8c3098ee.cdf15457ee4816989343b6e6e96dd4cfe = cdf15457ee4816989343b6e6e96dd4cfe;
				if (!c8182050bde64f716a9855055b4bd295b.ce09dadc97335bd2a78e65370a288fa39(c0074a0b15015abd20b244b0f8c3098ee.cdf15457ee4816989343b6e6e96dd4cfe))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.ca166dc58c6225570137b6dff36d44d67.c35f66702a2b097b5dcc8b463f9f7230d(object, EventArrivedEventArgs)).MethodHandle;
					}
					return;
				}
				this.ca595951501f754c52f6ba39b8ccf3c97.Stop();
				this.ca595951501f754c52f6ba39b8ccf3c97.Dispose();
				this.c4404a159870bf55bb6f111e66e59e82d.Invoke(new MethodInvoker(c0074a0b15015abd20b244b0f8c3098ee.c9b7e67f86f426c9bd3ffbb2e003b093f));
			}

			// Token: 0x040006D0 RID: 1744
			public ManagementEventWatcher c775ecebe54de6681e30b2fbca1266e01;

			// Token: 0x040006D1 RID: 1745
			public Action<EventArrivedEventArgs> cc5311ae3fb065285d00d648f1e2c499f;

			// Token: 0x040006D2 RID: 1746
			public ManagementEventWatcher ca595951501f754c52f6ba39b8ccf3c97;

			// Token: 0x040006D3 RID: 1747
			public Action<EventArrivedEventArgs> c66af968a63bc828758428a58a4220347;

			// Token: 0x040006D4 RID: 1748
			public c8182050bde64f716a9855055b4bd295b c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x0200013D RID: 317
		[CompilerGenerated]
		private sealed class c8c33abb353a0689d83865a38c8cd419e
		{
			// Token: 0x06000949 RID: 2377 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
			internal void cf05b07fe96fc07392434cbbc7a1017f8()
			{
				Action<EventArrivedEventArgs> cc5311ae3fb065285d00d648f1e2c499f = this.c8c38354cddaefb45b9cfcd9ed2838c37.cc5311ae3fb065285d00d648f1e2c499f;
				if (cc5311ae3fb065285d00d648f1e2c499f == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.c8c33abb353a0689d83865a38c8cd419e.cf05b07fe96fc07392434cbbc7a1017f8()).MethodHandle;
					}
					return;
				}
				cc5311ae3fb065285d00d648f1e2c499f(this.cdf15457ee4816989343b6e6e96dd4cfe);
			}

			// Token: 0x040006D5 RID: 1749
			public EventArrivedEventArgs cdf15457ee4816989343b6e6e96dd4cfe;

			// Token: 0x040006D6 RID: 1750
			public c8182050bde64f716a9855055b4bd295b.ca166dc58c6225570137b6dff36d44d67 c8c38354cddaefb45b9cfcd9ed2838c37;
		}

		// Token: 0x0200013E RID: 318
		[CompilerGenerated]
		private sealed class c0074a0b15015abd20b244b0f8c3098ee
		{
			// Token: 0x0600094B RID: 2379 RVA: 0x0005F148 File Offset: 0x0005D348
			internal void c9b7e67f86f426c9bd3ffbb2e003b093f()
			{
				Action<EventArrivedEventArgs> c66af968a63bc828758428a58a = this.c9def284befdb85aa51808c134f9b5700.c66af968a63bc828758428a58a4220347;
				if (c66af968a63bc828758428a58a == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c8182050bde64f716a9855055b4bd295b.c0074a0b15015abd20b244b0f8c3098ee.c9b7e67f86f426c9bd3ffbb2e003b093f()).MethodHandle;
					}
					return;
				}
				c66af968a63bc828758428a58a(this.cdf15457ee4816989343b6e6e96dd4cfe);
			}

			// Token: 0x040006D7 RID: 1751
			public EventArrivedEventArgs cdf15457ee4816989343b6e6e96dd4cfe;

			// Token: 0x040006D8 RID: 1752
			public c8182050bde64f716a9855055b4bd295b.ca166dc58c6225570137b6dff36d44d67 c9def284befdb85aa51808c134f9b5700;
		}
	}
}
