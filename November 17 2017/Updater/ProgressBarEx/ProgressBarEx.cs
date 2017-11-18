using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProgressBarEx
{
	// Token: 0x02000003 RID: 3
	[ToolboxBitmap("PBEX.bmp")]
	public class ProgressBarEx : Control
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021A8 File Offset: 0x000003A8
		public ProgressBarEx()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
			base.TabStop = false;
			base.Size = new Size(200, 23);
			this.bBlend.Positions = new float[]
			{
				0f,
				0.2f,
				0.4f,
				0.6f,
				0.8f,
				1f
			};
			this.GradiantPosition = ProgressBarEx.GradiantArea.Top;
			base.BackColor = Color.Transparent;
			this._ForeColorBrush = new SolidBrush(base.ForeColor);
			this._BorderPen = new Pen(Color.Black);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002284 File Offset: 0x00000484
		[Category("Appearance")]
		[Description("The foreground color of the ProgressBars text.")]
		[Browsable(true)]
		public override Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				if (value == Color.Transparent)
				{
					value = this._ForeColorBrush.Color;
				}
				base.ForeColor = value;
				this._ForeColorBrush.Color = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000022B3 File Offset: 0x000004B3
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000022BB File Offset: 0x000004BB
		[Category("Appearance")]
		[Description("The background color of the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "DarkGray")]
		public Color BackgroundColor
		{
			get
			{
				return this._BackColor;
			}
			set
			{
				if (value == Color.Transparent)
				{
					value = this._BackColor;
				}
				this._BackColor = value;
				this.Refresh();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000022DF File Offset: 0x000004DF
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000022E7 File Offset: 0x000004E7
		[Category("Appearance")]
		[Description("The progress color of the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "Lime")]
		public Color ProgressColor
		{
			get
			{
				return this._ProgressColor;
			}
			set
			{
				if (value == Color.Transparent)
				{
					value = this._ProgressColor;
				}
				this._ProgressColor = value;
				this.Refresh();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000230B File Offset: 0x0000050B
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002313 File Offset: 0x00000513
		[Category("Appearance")]
		[Description("The gradiant highlight color of the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "White")]
		public Color GradiantColor
		{
			get
			{
				return this._GradiantColor;
			}
			set
			{
				this._GradiantColor = value;
				this.Refresh();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002322 File Offset: 0x00000522
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000232A File Offset: 0x0000052A
		[Category("Behavior")]
		[Description("The minimum value of the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(0)]
		public int Minimum
		{
			get
			{
				return this._Minimum;
			}
			set
			{
				if (value > this._Maximum)
				{
					value = this._Maximum - 1;
				}
				this._Minimum = value;
				this.Refresh();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000234C File Offset: 0x0000054C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002354 File Offset: 0x00000554
		[Category("Behavior")]
		[Description("The maximum value of the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(100)]
		public int Maximum
		{
			get
			{
				return this._Maximum;
			}
			set
			{
				if (value <= this._Minimum)
				{
					value = this._Minimum + 1;
				}
				this._Maximum = value;
				this.Refresh();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002376 File Offset: 0x00000576
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000237E File Offset: 0x0000057E
		[Category("Behavior")]
		[Description("The current value of the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(0)]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if (value < this._Minimum)
				{
					value = this._Minimum;
				}
				if (value > this._Maximum)
				{
					value = this._Maximum;
				}
				this._Value = value;
				this.Refresh();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000023AF File Offset: 0x000005AF
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000023B7 File Offset: 0x000005B7
		[Category("Appearance")]
		[Description("Draw a border around the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(true)]
		public bool Border
		{
			get
			{
				return this._Border;
			}
			set
			{
				this._Border = value;
				this.Refresh();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000023C6 File Offset: 0x000005C6
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000023CE File Offset: 0x000005CE
		[Category("Appearance")]
		[Description("The color of the border around the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "Black")]
		public Color BorderColor
		{
			get
			{
				return this._BorderColor;
			}
			set
			{
				if (value == Color.Transparent)
				{
					value = this._BorderColor;
				}
				this._BorderColor = value;
				this._BorderPen.Color = value;
				this.Refresh();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000023FE File Offset: 0x000005FE
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002406 File Offset: 0x00000606
		[Category("Appearance")]
		[Description("Shows the progress percentge as text in the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(false)]
		public bool ShowPercentage
		{
			get
			{
				return this._ShowPercentage;
			}
			set
			{
				this._ShowPercentage = value;
				this.Refresh();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002415 File Offset: 0x00000615
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000241D File Offset: 0x0000061D
		[Category("Appearance")]
		[Description("Shows the text of the Text property in the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(false)]
		public bool ShowText
		{
			get
			{
				return this._ShowText;
			}
			set
			{
				this._ShowText = value;
				this.Refresh();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000242C File Offset: 0x0000062C
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002434 File Offset: 0x00000634
		[Category("Appearance")]
		[Description("Determins the position of the gradiant shine in the ProgressBar.")]
		[Browsable(true)]
		[DefaultValue(typeof(ProgressBarEx.GradiantArea), "Top")]
		public ProgressBarEx.GradiantArea GradiantPosition
		{
			get
			{
				return this._GradiantPosition;
			}
			set
			{
				this._GradiantPosition = value;
				if (value == ProgressBarEx.GradiantArea.None)
				{
					this.bBlend.Factors = new float[6];
				}
				else if (value == ProgressBarEx.GradiantArea.Top)
				{
					this.bBlend.Factors = new float[]
					{
						0.8f,
						0.7f,
						0.6f,
						0.4f,
						0f,
						0f
					};
				}
				else if (value == ProgressBarEx.GradiantArea.Center)
				{
					this.bBlend.Factors = new float[]
					{
						0f,
						0.4f,
						0.6f,
						0.6f,
						0.4f,
						0f
					};
				}
				else
				{
					this.bBlend.Factors = new float[]
					{
						0f,
						0f,
						0.4f,
						0.6f,
						0.7f,
						0.8f
					};
				}
				this.Refresh();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000024C4 File Offset: 0x000006C4
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000024CC File Offset: 0x000006CC
		[Category("Appearance")]
		[Description("An image to display on the ProgressBarEx.")]
		[Browsable(true)]
		public Bitmap Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				this._Image = value;
				this.Refresh();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000024DB File Offset: 0x000006DB
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000024E3 File Offset: 0x000006E3
		[Category("Appearance")]
		[Description("Determins how the image is displayed in the ProgressBarEx.")]
		[Browsable(true)]
		[DefaultValue(typeof(ProgressBarEx.ImageLayoutType), "None")]
		public ProgressBarEx.ImageLayoutType ImageLayout
		{
			get
			{
				return this._ImageLayout;
			}
			set
			{
				this._ImageLayout = value;
				if (this._Image != null)
				{
					this.Refresh();
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000024FA File Offset: 0x000006FA
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002502 File Offset: 0x00000702
		[Category("Appearance")]
		[Description("True to draw corners rounded. False to draw square corners.")]
		[Browsable(true)]
		[DefaultValue(true)]
		public bool RoundedCorners
		{
			get
			{
				return this._RoundedCorners;
			}
			set
			{
				this._RoundedCorners = value;
				this.Refresh();
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002511 File Offset: 0x00000711
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002519 File Offset: 0x00000719
		[Category("Appearance")]
		[Description("Determins the direction of progress displayed in the ProgressBarEx.")]
		[Browsable(true)]
		[DefaultValue(typeof(ProgressBarEx.ProgressDir), "Horizontal")]
		public ProgressBarEx.ProgressDir ProgressDirection
		{
			get
			{
				return this._ProgressDirection;
			}
			set
			{
				this._ProgressDirection = value;
				this.Refresh();
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002528 File Offset: 0x00000728
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Point point = new Point(0, 0);
			Point point2 = new Point(0, base.Height);
			if (this._ProgressDirection == ProgressBarEx.ProgressDir.Vertical)
			{
				point2 = new Point(base.Width, 0);
			}
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
				int num = Convert.ToInt32((double)rect.Height / 2.5);
				if (rect.Width < rect.Height)
				{
					num = Convert.ToInt32((double)rect.Width / 2.5);
				}
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(point, point2, this._BackColor, this._GradiantColor))
				{
					linearGradientBrush.Blend = this.bBlend;
					if (this._RoundedCorners)
					{
						graphicsPath.AddArc(rect.X, rect.Y, num, num, 180f, 90f);
						graphicsPath.AddArc(rect.Right - num, rect.Y, num, num, 270f, 90f);
						graphicsPath.AddArc(rect.Right - num, rect.Bottom - num, num, num, 0f, 90f);
						graphicsPath.AddArc(rect.X, rect.Bottom - num, num, num, 90f, 90f);
						graphicsPath.CloseFigure();
						e.Graphics.FillPath(linearGradientBrush, graphicsPath);
					}
					else
					{
						e.Graphics.FillRectangle(linearGradientBrush, rect);
					}
				}
				if (this._Value > this._Minimum)
				{
					int num2 = Convert.ToInt32((double)base.Width / (double)(this._Maximum - this._Minimum) * (double)this._Value);
					if (this._ProgressDirection == ProgressBarEx.ProgressDir.Vertical)
					{
						num2 = Convert.ToInt32((double)base.Height / (double)(this._Maximum - this._Minimum) * (double)this._Value);
						rect.Y = rect.Height - num2;
						rect.Height = num2;
					}
					else
					{
						rect.Width = num2;
					}
					using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(point, point2, this._ProgressColor, this._GradiantColor))
					{
						linearGradientBrush2.Blend = this.bBlend;
						if (this._RoundedCorners)
						{
							if (this._ProgressDirection == ProgressBarEx.ProgressDir.Horizontal)
							{
								rect.Height--;
							}
							else
							{
								rect.Width--;
							}
							using (GraphicsPath graphicsPath2 = new GraphicsPath())
							{
								graphicsPath2.AddArc(rect.X, rect.Y, num, num, 180f, 90f);
								graphicsPath2.AddArc(rect.Right - num, rect.Y, num, num, 270f, 90f);
								graphicsPath2.AddArc(rect.Right - num, rect.Bottom - num, num, num, 0f, 90f);
								graphicsPath2.AddArc(rect.X, rect.Bottom - num, num, num, 90f, 90f);
								graphicsPath2.CloseFigure();
								using (GraphicsPath graphicsPath3 = new GraphicsPath())
								{
									using (Region region = new Region(graphicsPath))
									{
										region.Intersect(graphicsPath2);
										graphicsPath3.AddRectangles(region.GetRegionScans(new Matrix()));
									}
									e.Graphics.FillPath(linearGradientBrush2, graphicsPath3);
									goto IL_38E;
								}
							}
						}
						e.Graphics.FillRectangle(linearGradientBrush2, rect);
					}
				}
				IL_38E:
				if (this._Image != null)
				{
					if (this._ImageLayout == ProgressBarEx.ImageLayoutType.Stretch)
					{
						e.Graphics.DrawImage(this._Image, 0, 0, base.Width, base.Height);
					}
					else if (this._ImageLayout == ProgressBarEx.ImageLayoutType.None)
					{
						e.Graphics.DrawImage(this._Image, 0, 0);
					}
					else
					{
						int x = Convert.ToInt32(base.Width / 2 - this._Image.Width / 2);
						int y = Convert.ToInt32(base.Height / 2 - this._Image.Height / 2);
						e.Graphics.DrawImage(this._Image, x, y);
					}
				}
				if (this._ShowPercentage | this._ShowText)
				{
					string text = "";
					if (this._ShowText)
					{
						text = this.Text;
					}
					if (this._ShowPercentage)
					{
						text = text + Convert.ToString(Convert.ToInt32(100.0 / (double)(this._Maximum - this._Minimum) * (double)this._Value)) + "%";
					}
					using (StringFormat stringFormat = new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					})
					{
						e.Graphics.DrawString(text, this.Font, this._ForeColorBrush, new Rectangle(0, 0, base.Width, base.Height), stringFormat);
					}
				}
				if (this._Border)
				{
					rect = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
					if (this._RoundedCorners)
					{
						graphicsPath.Reset();
						graphicsPath.AddArc(rect.X, rect.Y, num, num, 180f, 90f);
						graphicsPath.AddArc(rect.Right - num, rect.Y, num, num, 270f, 90f);
						graphicsPath.AddArc(rect.Right - num, rect.Bottom - num, num, num, 0f, 90f);
						graphicsPath.AddArc(rect.X, rect.Bottom - num, num, num, 90f, 90f);
						graphicsPath.CloseFigure();
						e.Graphics.DrawPath(this._BorderPen, graphicsPath);
					}
					else
					{
						e.Graphics.DrawRectangle(this._BorderPen, rect);
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002BD0 File Offset: 0x00000DD0
		protected override void OnTextChanged(EventArgs e)
		{
			this.Refresh();
			base.OnTextChanged(e);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002BDF File Offset: 0x00000DDF
		protected override void Dispose(bool disposing)
		{
			this._ForeColorBrush.Dispose();
			this._BorderPen.Dispose();
			base.Dispose(disposing);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002BFE File Offset: 0x00000DFE
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002C06 File Offset: 0x00000E06
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = Color.Transparent;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002C13 File Offset: 0x00000E13
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002C1B File Offset: 0x00000E1B
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Obsolete("BackgroundImageLayout is not implemented.", true)]
		public new ImageLayout BackgroundImageLayout
		{
			get
			{
				return base.BackgroundImageLayout;
			}
			set
			{
				throw new NotImplementedException("BackgroundImageLayout is not implemented.");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002C27 File Offset: 0x00000E27
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002C2A File Offset: 0x00000E2A
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Obsolete("BackgroundImage is not implemented.", true)]
		public new Image BackgroundImage
		{
			get
			{
				return null;
			}
			set
			{
				throw new NotImplementedException("BackgroundImage is not implemented.");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002C36 File Offset: 0x00000E36
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002C39 File Offset: 0x00000E39
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Obsolete("TabStop is not implemented.", true)]
		public new bool TabStop
		{
			get
			{
				return false;
			}
			set
			{
				throw new NotImplementedException("TabStop is not implemented.");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002C45 File Offset: 0x00000E45
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002C4D File Offset: 0x00000E4D
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Obsolete("TabIndex is not implemented.", true)]
		public new int TabIndex
		{
			get
			{
				return base.TabIndex;
			}
			set
			{
				throw new NotImplementedException("TabIndex is not implemented.");
			}
		}

		// Token: 0x04000006 RID: 6
		private Blend bBlend = new Blend();

		// Token: 0x04000007 RID: 7
		private int _Minimum;

		// Token: 0x04000008 RID: 8
		private int _Maximum = 100;

		// Token: 0x04000009 RID: 9
		private int _Value;

		// Token: 0x0400000A RID: 10
		private bool _Border = true;

		// Token: 0x0400000B RID: 11
		private Pen _BorderPen;

		// Token: 0x0400000C RID: 12
		private Color _BorderColor = Color.Black;

		// Token: 0x0400000D RID: 13
		private ProgressBarEx.GradiantArea _GradiantPosition;

		// Token: 0x0400000E RID: 14
		private Color _GradiantColor = Color.White;

		// Token: 0x0400000F RID: 15
		private Color _BackColor = Color.DarkGray;

		// Token: 0x04000010 RID: 16
		private Color _ProgressColor = Color.Lime;

		// Token: 0x04000011 RID: 17
		private SolidBrush _ForeColorBrush;

		// Token: 0x04000012 RID: 18
		private bool _ShowPercentage;

		// Token: 0x04000013 RID: 19
		private bool _ShowText;

		// Token: 0x04000014 RID: 20
		private ProgressBarEx.ImageLayoutType _ImageLayout;

		// Token: 0x04000015 RID: 21
		private Bitmap _Image;

		// Token: 0x04000016 RID: 22
		private bool _RoundedCorners = true;

		// Token: 0x04000017 RID: 23
		private ProgressBarEx.ProgressDir _ProgressDirection;

		// Token: 0x02000012 RID: 18
		public enum GradiantArea
		{
			// Token: 0x0400003A RID: 58
			None,
			// Token: 0x0400003B RID: 59
			Top,
			// Token: 0x0400003C RID: 60
			Center,
			// Token: 0x0400003D RID: 61
			Bottom
		}

		// Token: 0x02000013 RID: 19
		public enum ImageLayoutType
		{
			// Token: 0x0400003F RID: 63
			None,
			// Token: 0x04000040 RID: 64
			Center,
			// Token: 0x04000041 RID: 65
			Stretch
		}

		// Token: 0x02000014 RID: 20
		public enum ProgressDir
		{
			// Token: 0x04000043 RID: 67
			Horizontal,
			// Token: 0x04000044 RID: 68
			Vertical
		}
	}
}
