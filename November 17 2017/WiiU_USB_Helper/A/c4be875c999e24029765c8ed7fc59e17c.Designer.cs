using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000B8 RID: 184
	internal class c4be875c999e24029765c8ed7fc59e17c : RadForm
	{
		// Token: 0x06000686 RID: 1670 RVA: 0x0002EFF4 File Offset: 0x0002D1F4
		public c4be875c999e24029765c8ed7fc59e17c()
		{
			this.c82b8091adcf720aa7a90631953c644c8();
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002F010 File Offset: 0x0002D210
		private void c064a0b0c8b43d3439d0664e45ae17098(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.Close();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002F024 File Offset: 0x0002D224
		private void ce2ad4d9a42de9e2858bc6463a40fb74d(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			this.c69c02b75e055d1022e343285796759de.IsChecked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13360) != 0);
			this.c7693210541537011fe9531fa6bd1afc9.IsChecked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13364) != 0);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002F05C File Offset: 0x0002D25C
		private void c39699796513ab4cd1687c91efcfcb570(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			this.ca46047bdbc67199ac953e6f2ad4fd9df.IsChecked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13368) != 0);
			this.c7693210541537011fe9531fa6bd1afc9.IsChecked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13372) != 0);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002F094 File Offset: 0x0002D294
		private void c5706e153d693050936faa019a37bc682(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002F0A4 File Offset: 0x0002D2A4
		private void c18f5ad753944d1bcf2958bc4f2ef83e5(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			c4be875c999e24029765c8ed7fc59e17c.c5722ae2bebaa3bfd9ddd390ef029a9e4 c5722ae2bebaa3bfd9ddd390ef029a9e = new c4be875c999e24029765c8ed7fc59e17c.c5722ae2bebaa3bfd9ddd390ef029a9e4();
			c5722ae2bebaa3bfd9ddd390ef029a9e.c4404a159870bf55bb6f111e66e59e82d = this;
			this.c27f701090694564c1f319d5605e9744e.Text = this.c27f701090694564c1f319d5605e9744e.Text.Trim();
			if (this.c27f701090694564c1f319d5605e9744e.Text.Length < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13376))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4be875c999e24029765c8ed7fc59e17c.c18f5ad753944d1bcf2958bc4f2ef83e5(object, EventArgs)).MethodHandle;
				}
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50552));
				return;
			}
			string cda8d357f97f2881c4f16f3cd2f24580c;
			if (this.ca46047bdbc67199ac953e6f2ad4fd9df.IsChecked)
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
				cda8d357f97f2881c4f16f3cd2f24580c = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50651);
			}
			else if (this.c69c02b75e055d1022e343285796759de.IsChecked)
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
				cda8d357f97f2881c4f16f3cd2f24580c = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50674);
			}
			else
			{
				cda8d357f97f2881c4f16f3cd2f24580c = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50713);
			}
			c80c398cf4e6b2fb091b88536098e2d6b c80c398cf4e6b2fb091b88536098e2d6b = new c80c398cf4e6b2fb091b88536098e2d6b(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50742), cda8d357f97f2881c4f16f3cd2f24580c, this.c27f701090694564c1f319d5605e9744e.Text, this.c8a05c92f77763b22cbd205811e828e9e.Text.Trim());
			c5722ae2bebaa3bfd9ddd390ef029a9e.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50795), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13380) != 0);
			c80c398cf4e6b2fb091b88536098e2d6b.c5d9ebe1d817df2cbd911e6ff282ee099 += c5722ae2bebaa3bfd9ddd390ef029a9e.c9f248b26419aaa9a4e82d4a452400181;
			c80c398cf4e6b2fb091b88536098e2d6b.c6ab500c9dee17a8b7221ca64ea543b6d();
			c5722ae2bebaa3bfd9ddd390ef029a9e.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0002F204 File Offset: 0x0002D404
		private void cf31b0196f5047f6080f0b95d577e1854(object cd7b28952603b35a45c555982e677363a, StateChangedEventArgs c3c9260886a6db15de49329a9f5b9836c)
		{
			this.c69c02b75e055d1022e343285796759de.IsChecked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13384) != 0);
			this.ca46047bdbc67199ac953e6f2ad4fd9df.IsChecked = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13388) != 0);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0002F23C File Offset: 0x0002D43C
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4be875c999e24029765c8ed7fc59e17c.Dispose(bool)).MethodHandle;
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

		// Token: 0x0600068E RID: 1678 RVA: 0x0002F284 File Offset: 0x0002D484
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cf0e1ccede3cecdb492e215e1e460c040.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9 = new RadGroupBox();
			this.c69c02b75e055d1022e343285796759de = new RadRadioButton();
			this.ca46047bdbc67199ac953e6f2ad4fd9df = new RadRadioButton();
			this.c7693210541537011fe9531fa6bd1afc9 = new RadRadioButton();
			this.cc322a26d8faeea856bbff3807a162463 = new RadLabel();
			this.c592f692f8daf7265b8c262403f950fb2 = new PictureBox();
			this.c7ec1f8ef4425fd983e05da9fcb205ade = new RadLabel();
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d = new RadLabel();
			this.c8a05c92f77763b22cbd205811e828e9e = new RadTextBox();
			this.c27f701090694564c1f319d5605e9744e = new RadTextBox();
			this.c80dc0c21b9c29539eabce849089ab43c = new RadButton();
			this.cde04604bc941a29effc5e70b9bec7abf = new RadButton();
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.BeginInit();
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.SuspendLayout();
			this.c69c02b75e055d1022e343285796759de.BeginInit();
			this.ca46047bdbc67199ac953e6f2ad4fd9df.BeginInit();
			this.c7693210541537011fe9531fa6bd1afc9.BeginInit();
			this.cc322a26d8faeea856bbff3807a162463.BeginInit();
			((ISupportInitialize)this.c592f692f8daf7265b8c262403f950fb2).BeginInit();
			this.c7ec1f8ef4425fd983e05da9fcb205ade.BeginInit();
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.BeginInit();
			this.c8a05c92f77763b22cbd205811e828e9e.BeginInit();
			this.c27f701090694564c1f319d5605e9744e.BeginInit();
			this.c80dc0c21b9c29539eabce849089ab43c.BeginInit();
			this.cde04604bc941a29effc5e70b9bec7abf.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13392);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.Controls.Add(this.c69c02b75e055d1022e343285796759de);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.Controls.Add(this.ca46047bdbc67199ac953e6f2ad4fd9df);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.Controls.Add(this.c7693210541537011fe9531fa6bd1afc9);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50880);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13396), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13400));
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50913);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13404), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13408));
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13412);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13416) != 0);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50880);
			this.c69c02b75e055d1022e343285796759de.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13420), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13424));
			this.c69c02b75e055d1022e343285796759de.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(50958);
			this.c69c02b75e055d1022e343285796759de.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13428), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13432));
			this.c69c02b75e055d1022e343285796759de.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13436);
			this.c69c02b75e055d1022e343285796759de.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13440) != 0);
			this.c69c02b75e055d1022e343285796759de.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51009);
			this.c69c02b75e055d1022e343285796759de.ToggleStateChanged += new StateChangedEventHandler(this.c39699796513ab4cd1687c91efcfcb570);
			this.ca46047bdbc67199ac953e6f2ad4fd9df.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13444), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13448));
			this.ca46047bdbc67199ac953e6f2ad4fd9df.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51040);
			this.ca46047bdbc67199ac953e6f2ad4fd9df.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13452), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13456));
			this.ca46047bdbc67199ac953e6f2ad4fd9df.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13460);
			this.ca46047bdbc67199ac953e6f2ad4fd9df.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13464) != 0);
			this.ca46047bdbc67199ac953e6f2ad4fd9df.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51077);
			this.ca46047bdbc67199ac953e6f2ad4fd9df.ToggleStateChanged += new StateChangedEventHandler(this.ce2ad4d9a42de9e2858bc6463a40fb74d);
			this.c7693210541537011fe9531fa6bd1afc9.CheckState = (CheckState)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13468);
			this.c7693210541537011fe9531fa6bd1afc9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13472), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13476));
			this.c7693210541537011fe9531fa6bd1afc9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51092);
			this.c7693210541537011fe9531fa6bd1afc9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13480), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13484));
			this.c7693210541537011fe9531fa6bd1afc9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13488);
			this.c7693210541537011fe9531fa6bd1afc9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51135);
			this.c7693210541537011fe9531fa6bd1afc9.ToggleState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13492);
			this.c7693210541537011fe9531fa6bd1afc9.ToggleStateChanged += new StateChangedEventHandler(this.cf31b0196f5047f6080f0b95d577e1854);
			this.cc322a26d8faeea856bbff3807a162463.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13496), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13500));
			this.cc322a26d8faeea856bbff3807a162463.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51156);
			this.cc322a26d8faeea856bbff3807a162463.ShowItemToolTips = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13504) != 0);
			this.cc322a26d8faeea856bbff3807a162463.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13508), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13512));
			this.cc322a26d8faeea856bbff3807a162463.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13516);
			this.cc322a26d8faeea856bbff3807a162463.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51183);
			this.c592f692f8daf7265b8c262403f950fb2.Image = c6faa5467be1a4874657b372a49b7c927.logo;
			this.c592f692f8daf7265b8c262403f950fb2.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13520), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13524));
			this.c592f692f8daf7265b8c262403f950fb2.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51457);
			this.c592f692f8daf7265b8c262403f950fb2.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13528), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13532));
			this.c592f692f8daf7265b8c262403f950fb2.SizeMode = (PictureBoxSizeMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13536);
			this.c592f692f8daf7265b8c262403f950fb2.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13540);
			this.c592f692f8daf7265b8c262403f950fb2.TabStop = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13544) != 0);
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13548), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13552));
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51494);
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13556), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13560));
			this.c7ec1f8ef4425fd983e05da9fcb205ade.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13564);
			this.c7ec1f8ef4425fd983e05da9fcb205ade.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51515);
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13568), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13572));
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51568);
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13576), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13580));
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13584);
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51593);
			this.c8a05c92f77763b22cbd205811e828e9e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13588), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13592));
			this.c8a05c92f77763b22cbd205811e828e9e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51610);
			this.c8a05c92f77763b22cbd205811e828e9e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13596), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13600));
			this.c8a05c92f77763b22cbd205811e828e9e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13604);
			this.c27f701090694564c1f319d5605e9744e.AutoSize = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13608) != 0);
			this.c27f701090694564c1f319d5605e9744e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13612), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13616));
			this.c27f701090694564c1f319d5605e9744e.Multiline = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13620) != 0);
			this.c27f701090694564c1f319d5605e9744e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51627);
			this.c27f701090694564c1f319d5605e9744e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13624), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13628));
			this.c27f701090694564c1f319d5605e9744e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13632);
			this.c80dc0c21b9c29539eabce849089ab43c.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13636), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13640));
			this.c80dc0c21b9c29539eabce849089ab43c.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51648);
			this.c80dc0c21b9c29539eabce849089ab43c.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13644), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13648));
			this.c80dc0c21b9c29539eabce849089ab43c.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13652);
			this.c80dc0c21b9c29539eabce849089ab43c.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51669);
			this.c80dc0c21b9c29539eabce849089ab43c.Click += this.c18f5ad753944d1bcf2958bc4f2ef83e5;
			this.cde04604bc941a29effc5e70b9bec7abf.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13656), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13660));
			this.cde04604bc941a29effc5e70b9bec7abf.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51688);
			this.cde04604bc941a29effc5e70b9bec7abf.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13664), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13668));
			this.cde04604bc941a29effc5e70b9bec7abf.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13672);
			this.cde04604bc941a29effc5e70b9bec7abf.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51711);
			this.cde04604bc941a29effc5e70b9bec7abf.Click += this.c064a0b0c8b43d3439d0664e45ae17098;
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13676), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(13680));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13684);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13688), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13692));
			base.Controls.Add(this.c592f692f8daf7265b8c262403f950fb2);
			base.Controls.Add(this.cde04604bc941a29effc5e70b9bec7abf);
			base.Controls.Add(this.c80dc0c21b9c29539eabce849089ab43c);
			base.Controls.Add(this.c27f701090694564c1f319d5605e9744e);
			base.Controls.Add(this.c8a05c92f77763b22cbd205811e828e9e);
			base.Controls.Add(this.cf5e2be23bd773eb6fca2c7e8ea20a44d);
			base.Controls.Add(this.c7ec1f8ef4425fd983e05da9fcb205ade);
			base.Controls.Add(this.cc322a26d8faeea856bbff3807a162463);
			base.Controls.Add(this.cb2f4ceb9b2e1c9b8fcb07126de1833c9);
			base.FormBorderStyle = (FormBorderStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13696);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			base.MaximizeBox = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13700) != 0);
			base.MinimizeBox = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13704) != 0);
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51724);
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13708) != 0);
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13712);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51747);
			base.Load += this.c5706e153d693050936faa019a37bc682;
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.EndInit();
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13716) != 0);
			this.cb2f4ceb9b2e1c9b8fcb07126de1833c9.PerformLayout();
			this.c69c02b75e055d1022e343285796759de.EndInit();
			this.ca46047bdbc67199ac953e6f2ad4fd9df.EndInit();
			this.c7693210541537011fe9531fa6bd1afc9.EndInit();
			this.cc322a26d8faeea856bbff3807a162463.EndInit();
			((ISupportInitialize)this.c592f692f8daf7265b8c262403f950fb2).EndInit();
			this.c7ec1f8ef4425fd983e05da9fcb205ade.EndInit();
			this.cf5e2be23bd773eb6fca2c7e8ea20a44d.EndInit();
			this.c8a05c92f77763b22cbd205811e828e9e.EndInit();
			this.c27f701090694564c1f319d5605e9744e.EndInit();
			this.c80dc0c21b9c29539eabce849089ab43c.EndInit();
			this.cde04604bc941a29effc5e70b9bec7abf.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(13720) != 0);
			base.PerformLayout();
		}

		// Token: 0x04000375 RID: 885
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000376 RID: 886
		private RadGroupBox cb2f4ceb9b2e1c9b8fcb07126de1833c9;

		// Token: 0x04000377 RID: 887
		private RadRadioButton c69c02b75e055d1022e343285796759de;

		// Token: 0x04000378 RID: 888
		private RadRadioButton ca46047bdbc67199ac953e6f2ad4fd9df;

		// Token: 0x04000379 RID: 889
		private RadRadioButton c7693210541537011fe9531fa6bd1afc9;

		// Token: 0x0400037A RID: 890
		private RadLabel cc322a26d8faeea856bbff3807a162463;

		// Token: 0x0400037B RID: 891
		private PictureBox c592f692f8daf7265b8c262403f950fb2;

		// Token: 0x0400037C RID: 892
		private RadLabel c7ec1f8ef4425fd983e05da9fcb205ade;

		// Token: 0x0400037D RID: 893
		private RadLabel cf5e2be23bd773eb6fca2c7e8ea20a44d;

		// Token: 0x0400037E RID: 894
		private RadTextBox c8a05c92f77763b22cbd205811e828e9e;

		// Token: 0x0400037F RID: 895
		private RadTextBox c27f701090694564c1f319d5605e9744e;

		// Token: 0x04000380 RID: 896
		private RadButton c80dc0c21b9c29539eabce849089ab43c;

		// Token: 0x04000381 RID: 897
		private RadButton cde04604bc941a29effc5e70b9bec7abf;

		// Token: 0x02000156 RID: 342
		[CompilerGenerated]
		private sealed class c5722ae2bebaa3bfd9ddd390ef029a9e4
		{
			// Token: 0x06000981 RID: 2433 RVA: 0x00060318 File Offset: 0x0005E518
			internal void c9f248b26419aaa9a4e82d4a452400181(object cb0d7b0b893a41a39e281ddc32fc698bd, string ccb00690a4dbd11fab9ea8415c60a3154)
			{
				c4be875c999e24029765c8ed7fc59e17c.c6927eaf4d730d50ad1a33702fdce8046 c6927eaf4d730d50ad1a33702fdce = new c4be875c999e24029765c8ed7fc59e17c.c6927eaf4d730d50ad1a33702fdce8046();
				c6927eaf4d730d50ad1a33702fdce.c8c38354cddaefb45b9cfcd9ed2838c37 = this;
				c6927eaf4d730d50ad1a33702fdce.ccb00690a4dbd11fab9ea8415c60a3154 = ccb00690a4dbd11fab9ea8415c60a3154;
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
				this.c4404a159870bf55bb6f111e66e59e82d.Invoke(new Action(c6927eaf4d730d50ad1a33702fdce.c96104c7506d4733f5a333739d8ac8488));
			}

			// Token: 0x0400070B RID: 1803
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;

			// Token: 0x0400070C RID: 1804
			public c4be875c999e24029765c8ed7fc59e17c c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000157 RID: 343
		[CompilerGenerated]
		private sealed class c6927eaf4d730d50ad1a33702fdce8046
		{
			// Token: 0x06000983 RID: 2435 RVA: 0x00060374 File Offset: 0x0005E574
			internal void c96104c7506d4733f5a333739d8ac8488()
			{
				RadMessageBox.Show(this.ccb00690a4dbd11fab9ea8415c60a3154);
				this.c8c38354cddaefb45b9cfcd9ed2838c37.c4404a159870bf55bb6f111e66e59e82d.Close();
			}

			// Token: 0x0400070D RID: 1805
			public string ccb00690a4dbd11fab9ea8415c60a3154;

			// Token: 0x0400070E RID: 1806
			public c4be875c999e24029765c8ed7fc59e17c.c5722ae2bebaa3bfd9ddd390ef029a9e4 c8c38354cddaefb45b9cfcd9ed2838c37;
		}
	}
}
