using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace A
{
	// Token: 0x020000AB RID: 171
	public class cd5c09c7b57f3aa6b224c611a72ca3b10 : Control
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x00025E34 File Offset: 0x00024034
		public cd5c09c7b57f3aa6b224c611a72ca3b10()
		{
			base.SetStyle((ControlStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10540), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10544) != 0);
			base.SetStyle((ControlStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10548), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10552) != 0);
			base.SetStyle((ControlStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10556), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10560) != 0);
			base.SetStyle((ControlStyles)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10564), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10568) != 0);
			this.c8410eadaf0ffc79957c57cf6a31b228d = this.ca5d89f0d5027d2b82e081af1bcccdaa6;
			this.c5e3df5df92c260fe3ca198a2c5b54b73();
			this.c3166b7cb7114153a701e428607fa823b();
			this.c6e2ae0192e44a6cbb9f1955b002a1bfe();
			this.c8aa4d87ff32fe95cb62656bd082f0fba = new Timer();
			this.c8aa4d87ff32fe95cb62656bd082f0fba.Tick += this.cbd914d060b22d002006435986591dd1a;
			this.c546a3367b3d9c25adfd82fcab874ebdc();
			base.Resize += this.c6e2431fdb4c5ed8fcfd02a8c076db774;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00025F14 File Offset: 0x00024114
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00025F28 File Offset: 0x00024128
		[Description("Sets the color of spoke.")]
		[TypeConverter("System.Drawing.ColorConverter")]
		[Category("LoadingCircle")]
		public Color cb16116662e3a8236c6a68ec685d11a59
		{
			get
			{
				return this.c8410eadaf0ffc79957c57cf6a31b228d;
			}
			set
			{
				this.c8410eadaf0ffc79957c57cf6a31b228d = value;
				this.c5e3df5df92c260fe3ca198a2c5b54b73();
				base.Invalidate();
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00025F48 File Offset: 0x00024148
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00025F88 File Offset: 0x00024188
		[Description("Gets or sets the radius of outer circle.")]
		[Category("LoadingCircle")]
		public int c9250165d8b7b8d7b7ed5f5e67f5e8192
		{
			get
			{
				if (this.cf3bb812f4918696be098923430f1f449 == 0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.get_c9250165d8b7b8d7b7ed5f5e67f5e8192()).MethodHandle;
					}
					this.cf3bb812f4918696be098923430f1f449 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10324);
				}
				return this.cf3bb812f4918696be098923430f1f449;
			}
			set
			{
				this.cf3bb812f4918696be098923430f1f449 = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00025FA4 File Offset: 0x000241A4
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00025FE4 File Offset: 0x000241E4
		[Category("LoadingCircle")]
		[Description("Gets or sets the radius of inner circle.")]
		public int c7efec4a1ea06adc0a6c671b2079a2607
		{
			get
			{
				if (this.c6aa94ecc32757eb1e1540058e8c1ce2c == 0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.get_c7efec4a1ea06adc0a6c671b2079a2607()).MethodHandle;
					}
					this.c6aa94ecc32757eb1e1540058e8c1ce2c = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10328);
				}
				return this.c6aa94ecc32757eb1e1540058e8c1ce2c;
			}
			set
			{
				this.c6aa94ecc32757eb1e1540058e8c1ce2c = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00026000 File Offset: 0x00024200
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00026040 File Offset: 0x00024240
		[Description("Gets or sets the number of spoke.")]
		[Category("LoadingCircle")]
		public int c23fbeac2e1953c7f7a41021beb474f3e
		{
			get
			{
				if (this.cba7a1619e1a0535b6a014df9cc6a1dad == 0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.get_c23fbeac2e1953c7f7a41021beb474f3e()).MethodHandle;
					}
					this.cba7a1619e1a0535b6a014df9cc6a1dad = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10332);
				}
				return this.cba7a1619e1a0535b6a014df9cc6a1dad;
			}
			set
			{
				if (this.cba7a1619e1a0535b6a014df9cc6a1dad != value)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.set_c23fbeac2e1953c7f7a41021beb474f3e(int)).MethodHandle;
					}
					if (this.cba7a1619e1a0535b6a014df9cc6a1dad > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10336))
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
						this.cba7a1619e1a0535b6a014df9cc6a1dad = value;
						this.c5e3df5df92c260fe3ca198a2c5b54b73();
						this.c3166b7cb7114153a701e428607fa823b();
						base.Invalidate();
					}
				}
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000260A0 File Offset: 0x000242A0
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x000260B4 File Offset: 0x000242B4
		[Description("Gets or sets the number of spoke.")]
		[Category("LoadingCircle")]
		public bool c73ce297cbfb29ef5051ff1843029f73b
		{
			get
			{
				return this.ce29576cb1c086c28bfa64df15a19e92d;
			}
			set
			{
				this.ce29576cb1c086c28bfa64df15a19e92d = value;
				this.c546a3367b3d9c25adfd82fcab874ebdc();
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000260D0 File Offset: 0x000242D0
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00026118 File Offset: 0x00024318
		[Description("Gets or sets the thickness of a spoke.")]
		[Category("LoadingCircle")]
		public int ca949dc179b4669f635c5dc702034156f
		{
			get
			{
				if (this.c393036924c854f77d3827aa0efb96ebb <= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10340))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.get_ca949dc179b4669f635c5dc702034156f()).MethodHandle;
					}
					this.c393036924c854f77d3827aa0efb96ebb = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10344);
				}
				return this.c393036924c854f77d3827aa0efb96ebb;
			}
			set
			{
				this.c393036924c854f77d3827aa0efb96ebb = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00026134 File Offset: 0x00024334
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00026150 File Offset: 0x00024350
		[Description("Gets or sets the rotation speed. Higher the slower.")]
		[Category("LoadingCircle")]
		public int c1c3a2846f4ede6cd2085bf69650e3270
		{
			get
			{
				return this.c8aa4d87ff32fe95cb62656bd082f0fba.Interval;
			}
			set
			{
				if (value > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10348))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.set_c1c3a2846f4ede6cd2085bf69650e3270(int)).MethodHandle;
					}
					this.c8aa4d87ff32fe95cb62656bd082f0fba.Interval = value;
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0002618C File Offset: 0x0002438C
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x000261A0 File Offset: 0x000243A0
		[DefaultValue(typeof(cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa), "Custom")]
		[Description("Quickly sets the style to one of these presets, or a custom style if desired")]
		[Category("LoadingCircle")]
		public cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa cae83e75b541f1dda9d43a148b59fa365
		{
			get
			{
				return this.c1076465ba8f64828d941389b1fc7b19c;
			}
			set
			{
				this.c1076465ba8f64828d941389b1fc7b19c = value;
				switch (this.c1076465ba8f64828d941389b1fc7b19c)
				{
				case cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa.c0db28bb27c902c537cc9975a22eaac57:
					this.c399504ef610a91736e47e7630827b3b2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10352), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10356), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10360), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10364));
					return;
				case cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa.c798bef15e899ceef090b51c381875e10:
					this.c399504ef610a91736e47e7630827b3b2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10368), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10372), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10376), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10380));
					return;
				case cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa.cc24f625763db7b76c6fad787ae69d3e5:
					this.c399504ef610a91736e47e7630827b3b2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10384), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10388), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10392), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10396));
					return;
				case cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa.ca04de2b154e75e2bc43e6a89576be910:
					this.c399504ef610a91736e47e7630827b3b2(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10400), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10404), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10408), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10412));
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00026290 File Offset: 0x00024490
		private void c6e2431fdb4c5ed8fcfd02a8c076db774(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c6e2ae0192e44a6cbb9f1955b002a1bfe();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000262A4 File Offset: 0x000244A4
		private void cbd914d060b22d002006435986591dd1a(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			int num = this.c72db3522f1fd0fd03874693c208f4623 + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10416);
			this.c72db3522f1fd0fd03874693c208f4623 = num;
			this.c72db3522f1fd0fd03874693c208f4623 = num % this.cba7a1619e1a0535b6a014df9cc6a1dad;
			base.Invalidate();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000262E0 File Offset: 0x000244E0
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.cba7a1619e1a0535b6a014df9cc6a1dad > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10420))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.OnPaint(PaintEventArgs)).MethodHandle;
				}
				e.Graphics.SmoothingMode = (SmoothingMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10424);
				int num = this.c72db3522f1fd0fd03874693c208f4623;
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10428); i < this.cba7a1619e1a0535b6a014df9cc6a1dad; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10436))
				{
					num %= this.cba7a1619e1a0535b6a014df9cc6a1dad;
					this.cfdbb3fe6fa3735a636b37cee0b05a1eb(e.Graphics, this.c21504dc667537ca55fcbdf09f17307b5(this.c5dee11657cfeee1736cf55cd5606da1a, this.c6aa94ecc32757eb1e1540058e8c1ce2c, this.cf958100d4a50df1286c01b75950201da[num]), this.c21504dc667537ca55fcbdf09f17307b5(this.c5dee11657cfeee1736cf55cd5606da1a, this.cf3bb812f4918696be098923430f1f449, this.cf958100d4a50df1286c01b75950201da[num]), this.c080ca013f761163f6d8bdacffd5f6956[i], this.c393036924c854f77d3827aa0efb96ebb);
					num += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10432);
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
			base.OnPaint(e);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000263D8 File Offset: 0x000245D8
		public override Size GetPreferredSize(Size proposedSize)
		{
			proposedSize.Width = (this.cf3bb812f4918696be098923430f1f449 + this.c393036924c854f77d3827aa0efb96ebb) * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10440);
			return proposedSize;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00026408 File Offset: 0x00024608
		private Color c0303ed3ea4c1e1d32b6d0f78ace5fa7d(Color ca289086ee08ced57c0f3cec327564b50, int c4bbf4efc09086cdee7dc79553b9d798c)
		{
			int r = (int)ca289086ee08ced57c0f3cec327564b50.R;
			int g = (int)ca289086ee08ced57c0f3cec327564b50.G;
			int b = (int)ca289086ee08ced57c0f3cec327564b50.B;
			return Color.FromArgb(c4bbf4efc09086cdee7dc79553b9d798c, Math.Min(r, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10444)), Math.Min(g, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10448)), Math.Min(b, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10452)));
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00026474 File Offset: 0x00024674
		private void c5e3df5df92c260fe3ca198a2c5b54b73()
		{
			this.c080ca013f761163f6d8bdacffd5f6956 = this.c5e3df5df92c260fe3ca198a2c5b54b73(this.c8410eadaf0ffc79957c57cf6a31b228d, this.c73ce297cbfb29ef5051ff1843029f73b, this.cba7a1619e1a0535b6a014df9cc6a1dad);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000264A4 File Offset: 0x000246A4
		private Color[] c5e3df5df92c260fe3ca198a2c5b54b73(Color ca289086ee08ced57c0f3cec327564b50, bool c20d352db1da21b2790de91b866aae350, int ccf6f39431379897dc9f6e6e155425af4)
		{
			Color[] array = c9d860ca0f65446f408b1908c86efc88c.cad714a49573fd585a8ab14c80a23536b(this.c23fbeac2e1953c7f7a41021beb474f3e);
			byte b = (byte)(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10456) / this.c23fbeac2e1953c7f7a41021beb474f3e);
			byte b2 = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10460);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10464); i < this.c23fbeac2e1953c7f7a41021beb474f3e; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10476))
			{
				if (c20d352db1da21b2790de91b866aae350)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.c5e3df5df92c260fe3ca198a2c5b54b73(Color, bool, int)).MethodHandle;
					}
					if (i != 0)
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
						if (i >= this.c23fbeac2e1953c7f7a41021beb474f3e - ccf6f39431379897dc9f6e6e155425af4)
						{
							b2 += b;
							if ((int)b2 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10468))
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
								b2 = (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10472);
							}
							array[i] = this.c0303ed3ea4c1e1d32b6d0f78ace5fa7d(ca289086ee08ced57c0f3cec327564b50, (int)b2);
							goto IL_C9;
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
					array[i] = ca289086ee08ced57c0f3cec327564b50;
				}
				else
				{
					array[i] = ca289086ee08ced57c0f3cec327564b50;
				}
				IL_C9:;
			}
			for (;;)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			return array;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000265A0 File Offset: 0x000247A0
		private void c6e2ae0192e44a6cbb9f1955b002a1bfe()
		{
			this.c5dee11657cfeee1736cf55cd5606da1a = this.c6e2ae0192e44a6cbb9f1955b002a1bfe(this);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000265BC File Offset: 0x000247BC
		private PointF c6e2ae0192e44a6cbb9f1955b002a1bfe(Control cf881afe860c82f834d1d176449c52bfd)
		{
			return new PointF((float)(cf881afe860c82f834d1d176449c52bfd.Width / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10480)), (float)(cf881afe860c82f834d1d176449c52bfd.Height / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10484) - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10488)));
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00026604 File Offset: 0x00024804
		private void cfdbb3fe6fa3735a636b37cee0b05a1eb(Graphics c45846416f5abfbadaa44054086ca448e, PointF c46d90aa2791dd9f267a304fc8fcc7a8d, PointF cc97cb86ea5f411d7d0e7890d058cdfad, Color ca289086ee08ced57c0f3cec327564b50, int c22902b69c16f7cb8e105540bc177067a)
		{
			Pen pen = new Pen(new SolidBrush(ca289086ee08ced57c0f3cec327564b50), (float)c22902b69c16f7cb8e105540bc177067a);
			try
			{
				pen.StartCap = (LineCap)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10492);
				pen.EndCap = (LineCap)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10496);
				c45846416f5abfbadaa44054086ca448e.DrawLine(pen, c46d90aa2791dd9f267a304fc8fcc7a8d, cc97cb86ea5f411d7d0e7890d058cdfad);
			}
			finally
			{
				if (pen != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.cfdbb3fe6fa3735a636b37cee0b05a1eb(Graphics, PointF, PointF, Color, int)).MethodHandle;
					}
					((IDisposable)pen).Dispose();
				}
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0002667C File Offset: 0x0002487C
		private PointF c21504dc667537ca55fcbdf09f17307b5(PointF ccbdeb1261a73f8e56b86fdfcb7082a99, int cec0d52640b9b5ca75177b453ad527000, double c260b6de402ae07afc55b2ae22778f41c)
		{
			double num = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(10500) * c260b6de402ae07afc55b2ae22778f41c / cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(10508);
			return new PointF(ccbdeb1261a73f8e56b86fdfcb7082a99.X + (float)cec0d52640b9b5ca75177b453ad527000 * (float)Math.Cos(num), ccbdeb1261a73f8e56b86fdfcb7082a99.Y + (float)cec0d52640b9b5ca75177b453ad527000 * (float)Math.Sin(num));
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000266D8 File Offset: 0x000248D8
		private void c3166b7cb7114153a701e428607fa823b()
		{
			this.cf958100d4a50df1286c01b75950201da = this.c3166b7cb7114153a701e428607fa823b(this.c23fbeac2e1953c7f7a41021beb474f3e);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000266FC File Offset: 0x000248FC
		private double[] c3166b7cb7114153a701e428607fa823b(int c8d4b6317d5ff4561119a501aa5ba28cd)
		{
			double[] array = c0f2935fe414da8de28aae3858c34bcba.cad714a49573fd585a8ab14c80a23536b(c8d4b6317d5ff4561119a501aa5ba28cd);
			double num = cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(10516) / (double)c8d4b6317d5ff4561119a501aa5ba28cd;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10524); i < c8d4b6317d5ff4561119a501aa5ba28cd; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10532))
			{
				double[] array2 = array;
				int num2 = i;
				double num3;
				if (i != 0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.c3166b7cb7114153a701e428607fa823b(int)).MethodHandle;
					}
					num3 = array[i - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10528)] + num;
				}
				else
				{
					num3 = num;
				}
				array2[num2] = num3;
			}
			for (;;)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			return array;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00026778 File Offset: 0x00024978
		private void c546a3367b3d9c25adfd82fcab874ebdc()
		{
			if (this.ce29576cb1c086c28bfa64df15a19e92d)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.c546a3367b3d9c25adfd82fcab874ebdc()).MethodHandle;
				}
				this.c8aa4d87ff32fe95cb62656bd082f0fba.Start();
			}
			else
			{
				this.c8aa4d87ff32fe95cb62656bd082f0fba.Stop();
				this.c72db3522f1fd0fd03874693c208f4623 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10536);
			}
			this.c5e3df5df92c260fe3ca198a2c5b54b73();
			base.Invalidate();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000267D4 File Offset: 0x000249D4
		public void c399504ef610a91736e47e7630827b3b2(int c8574fc14ad736e7cc921f1267ce534be, int c5e2367029607d2ee84b1165310bf0109, int cdb4ae6d93f66dd7f78d952d414570e33, int c8b5959dd6abcc29a6b78a7c709ef27d7)
		{
			this.c23fbeac2e1953c7f7a41021beb474f3e = c8574fc14ad736e7cc921f1267ce534be;
			this.ca949dc179b4669f635c5dc702034156f = c5e2367029607d2ee84b1165310bf0109;
			this.c7efec4a1ea06adc0a6c671b2079a2607 = cdb4ae6d93f66dd7f78d952d414570e33;
			this.c9250165d8b7b8d7b7ed5f5e67f5e8192 = c8b5959dd6abcc29a6b78a7c709ef27d7;
			base.Invalidate();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00026804 File Offset: 0x00024A04
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd5c09c7b57f3aa6b224c611a72ca3b10.Dispose(bool)).MethodHandle;
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

		// Token: 0x040002DE RID: 734
		private const double cd88387c4fd767a333ec07d1f6d953ac6 = 360.0;

		// Token: 0x040002DF RID: 735
		private const double c18c227e4a4cbf25fa5ca29546dbb389d = 180.0;

		// Token: 0x040002E0 RID: 736
		private const int c9d3ab7a2fbc057a659a4fb8f52ae8497 = 8;

		// Token: 0x040002E1 RID: 737
		private const int cd2b40939d9b5e61261f2f9a7522abd60 = 10;

		// Token: 0x040002E2 RID: 738
		private const int c33073d5e45d6f9ea1a5fb1ae2f921581 = 10;

		// Token: 0x040002E3 RID: 739
		private const int c272904caad1b5b3eee5a5eb8c37f8811 = 4;

		// Token: 0x040002E4 RID: 740
		private const int cb6a718e04479573f20b931827a5b9d44 = 5;

		// Token: 0x040002E5 RID: 741
		private const int c81db98d6a919a0d76e5e70a1086d8952 = 11;

		// Token: 0x040002E6 RID: 742
		private const int c4fc316666bf7e4aea036b2619117b456 = 12;

		// Token: 0x040002E7 RID: 743
		private const int c597591fd30a4225d35dc96f5dcfb5bac = 2;

		// Token: 0x040002E8 RID: 744
		private const int c3a2079c214d683c6ebf8d2ff2d847e0c = 6;

		// Token: 0x040002E9 RID: 745
		private const int c1147745d924d7f6419cd541ab59f159b = 7;

		// Token: 0x040002EA RID: 746
		private const int c94d405fe43a83cfc8519f3f0c7017707 = 9;

		// Token: 0x040002EB RID: 747
		private const int c44937f287f49a362c67de17473cfcec6 = 4;

		// Token: 0x040002EC RID: 748
		private const int c6d677aecb7c5cbb8cddbfa0677e283d8 = 8;

		// Token: 0x040002ED RID: 749
		private const int ccb1c2dd36f3932a64d6192b58e5ca669 = 9;

		// Token: 0x040002EE RID: 750
		private const int ce222af2b478ab0840e5e189cfa9c3eeb = 24;

		// Token: 0x040002EF RID: 751
		private const int c5b0a14d80b059ae867e41069b4af4989 = 4;

		// Token: 0x040002F0 RID: 752
		private readonly Color ca5d89f0d5027d2b82e081af1bcccdaa6 = Color.DarkGray;

		// Token: 0x040002F1 RID: 753
		private double[] cf958100d4a50df1286c01b75950201da;

		// Token: 0x040002F2 RID: 754
		private PointF c5dee11657cfeee1736cf55cd5606da1a;

		// Token: 0x040002F3 RID: 755
		private Color c8410eadaf0ffc79957c57cf6a31b228d;

		// Token: 0x040002F4 RID: 756
		private Color[] c080ca013f761163f6d8bdacffd5f6956;

		// Token: 0x040002F5 RID: 757
		private int c6aa94ecc32757eb1e1540058e8c1ce2c;

		// Token: 0x040002F6 RID: 758
		private bool ce29576cb1c086c28bfa64df15a19e92d;

		// Token: 0x040002F7 RID: 759
		private int cba7a1619e1a0535b6a014df9cc6a1dad;

		// Token: 0x040002F8 RID: 760
		private int cf3bb812f4918696be098923430f1f449;

		// Token: 0x040002F9 RID: 761
		private int c72db3522f1fd0fd03874693c208f4623;

		// Token: 0x040002FA RID: 762
		private int c393036924c854f77d3827aa0efb96ebb;

		// Token: 0x040002FB RID: 763
		private cd5c09c7b57f3aa6b224c611a72ca3b10.c314a07ce2fdc323eeae3a6f2d7cc45aa c1076465ba8f64828d941389b1fc7b19c;

		// Token: 0x040002FC RID: 764
		private readonly Timer c8aa4d87ff32fe95cb62656bd082f0fba;

		// Token: 0x040002FD RID: 765
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x02000142 RID: 322
		public enum c314a07ce2fdc323eeae3a6f2d7cc45aa
		{
			// Token: 0x040006E2 RID: 1762
			c0db28bb27c902c537cc9975a22eaac57,
			// Token: 0x040006E3 RID: 1763
			c798bef15e899ceef090b51c381875e10,
			// Token: 0x040006E4 RID: 1764
			cc24f625763db7b76c6fad787ae69d3e5,
			// Token: 0x040006E5 RID: 1765
			ca04de2b154e75e2bc43e6a89576be910
		}
	}
}
