using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Paloma;

namespace A
{
	// Token: 0x020000AE RID: 174
	public class c35f868ba35d5c51ce5a72f140870f944 : Game
	{
		// Token: 0x060005C1 RID: 1473 RVA: 0x00026C64 File Offset: 0x00024E64
		public c35f868ba35d5c51ce5a72f140870f944()
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11308));
			RuntimeHelpers.InitializeArray(array, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c864e1843af5f6bb94b9536fda2a765a5).FieldHandle);
			this.c872a360c8405ca33019203d2a384cbf3 = array;
			byte[] array2 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11312));
			RuntimeHelpers.InitializeArray(array2, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.c90a373e6c6c914cf8719e11fcc98129e).FieldHandle);
			this.c363cf68286a3d05767e684fe0bd36e16 = array2;
			this.cd1965857520cad98fb5dec6e13316d69 = new object();
			this.cda73ad01def0f0eb093487ab944e47f6 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11316);
			this.cf35a0cc4d235b83b3e7ba7b334cff889 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11320);
			this.c02290f8607a9ba8797f700b1b66ec0fd = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11324);
			this.c6f18cec0938fad27246b19219b647f7e = c049d2fd5839d8f87efe26223b47d7e92.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11328));
			base..ctor();
			this.c0808e5b6a0c9b426158f81b10e07e8a6 = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11332),
				PreferredBackBufferHeight = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11336),
				IsFullScreen = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11340) != 0),
				HardwareModeSwitch = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11344) != 0)
			};
			this.c0808e5b6a0c9b426158f81b10e07e8a6.ApplyChanges();
			base.Content.RootDirectory = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45221);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00026DAC File Offset: 0x00024FAC
		public void cbdd7a75e348cb852622ecf3ce3761260()
		{
			this.cf92cd1508967a84c645ff752d7540bf0();
			this.c38b3d68da402fa449ae70ea24a7a135f();
			new Thread(new ThreadStart(this.c906844a7cd2ef267dd46074512f35775))
			{
				IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10656) != 0)
			}.Start();
			this.c5f1cd24dc26e3f5d3385bbf360d8758f = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10660) != 0);
			this.c94a1f33ce3ca5392850bd63ff3984811 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10664) != 0);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00026E0C File Offset: 0x0002500C
		protected override void Draw(GameTime gameTime)
		{
			if (this.c94a1f33ce3ca5392850bd63ff3984811)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.Draw(GameTime)).MethodHandle;
				}
				return;
			}
			if (this.c5f1cd24dc26e3f5d3385bbf360d8758f)
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
				c35f868ba35d5c51ce5a72f140870f944.c6b07817cc4a154a9b9eebc12ed666060(base.Window.Handle, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10668));
				c35f868ba35d5c51ce5a72f140870f944.c38a4a9c5a781b6481be8dffbeca5e11f(base.Window.Handle);
				this.c5f1cd24dc26e3f5d3385bbf360d8758f = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10672) != 0);
			}
			if (!this.c0808e5b6a0c9b426158f81b10e07e8a6.IsFullScreen)
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
				this.c0808e5b6a0c9b426158f81b10e07e8a6.ToggleFullScreen();
			}
			base.GraphicsDevice.Clear(Color.Black);
			SpriteBatch spriteBatch = this.cd1c996b39b95f6d1ad7b246dd9cdbe22;
			SpriteSortMode spriteSortMode = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10676);
			BlendState alphaBlend = BlendState.AlphaBlend;
			SamplerState samplerState = null;
			DepthStencilState depthStencilState = null;
			RasterizerState rasterizerState = null;
			Effect effect = null;
			Matrix? matrix;
			cd95843a79444472b64e3924802a4fba4.c6333b8d01cc2ac0ec4fe13624a14dfc7(ref matrix);
			spriteBatch.Begin(spriteSortMode, alphaBlend, samplerState, depthStencilState, rasterizerState, effect, matrix);
			this.cd1c996b39b95f6d1ad7b246dd9cdbe22.Draw(this.ce1675bad66333e659e3a78ebac3c70ff, new Vector2(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10680), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10684)), Color.White);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10688); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10716); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10712))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10692); j < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10708); j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10704))
				{
					if (this.cb157f83b3809f2b42ef16034e7efc63b[i, j] != null)
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
						this.cd1c996b39b95f6d1ad7b246dd9cdbe22.Draw(this.cb157f83b3809f2b42ef16034e7efc63b[i, j], new Rectangle((int)this.c12f69801a4830f20c47d11cb0e8e1fef(j, i).X, (int)this.c12f69801a4830f20c47d11cb0e8e1fef(j, i).Y, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10696), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10700)), Color.White);
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
			for (;;)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			Vector2 vector = this.c9964a154d0eb036f6c6e37b87cd4ddd6(this.c6c7c0533d846f9356f0ddf2cfcba5c9d, this.c1672508575d0a793a6fd2e84ee8aea8c);
			this.cd1c996b39b95f6d1ad7b246dd9cdbe22.Draw(this.c0754862db64ef51d68cba87b32ea21fe, new Rectangle((int)vector.X - this.cf35a0cc4d235b83b3e7ba7b334cff889 / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10720), (int)vector.Y - this.cf35a0cc4d235b83b3e7ba7b334cff889 / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10724), this.cf35a0cc4d235b83b3e7ba7b334cff889, this.cf35a0cc4d235b83b3e7ba7b334cff889), Color.White);
			this.cf35a0cc4d235b83b3e7ba7b334cff889 += this.cda73ad01def0f0eb093487ab944e47f6;
			if (this.cf35a0cc4d235b83b3e7ba7b334cff889 != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10728))
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
				if (this.cf35a0cc4d235b83b3e7ba7b334cff889 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10732))
				{
					goto IL_2BE;
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
			this.cda73ad01def0f0eb093487ab944e47f6 *= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10736);
			IL_2BE:
			if (this.c6bf7d922b0de22e49f447c8d0fb987ad != null)
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
				string text = new string(this.c6bf7d922b0de22e49f447c8d0fb987ad.Name.Where(new Func<char, bool>(this.ca12695c05ce21770e640c4dd8df5dc7f)).ToArray<char>());
				Vector2 vector2 = this.c2c22d6040ed94b3a855229b12c9fb28f.MeasureString(text);
				int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10740);
				float num2 = vector2.X + (float)(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10744) * num);
				float num3 = vector2.Y + (float)(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10748) * num);
				this.cd1c996b39b95f6d1ad7b246dd9cdbe22.c4c424fca08431fec3662770783ae3961(new Rectangle((int)(vector.X - num2 / cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10752)), (int)(vector.Y + cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10756) + cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10760)), (int)num2, (int)num3), this.cc1ca4aa6963a01bc70831eff572746e1, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10764), Color.White);
				this.cd1c996b39b95f6d1ad7b246dd9cdbe22.DrawString(this.c2c22d6040ed94b3a855229b12c9fb28f, text, new Vector2(vector.X - num2 / cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10768) + (float)num, vector.Y + cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10772) + cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10776) + (float)num), Color.Black);
			}
			if (this.c442312d6c1f06e61e21cc841730b6907)
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
				if (this.c54fe05eaad068abc39c326095cfeac64 < cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10780))
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
					this.cd1c996b39b95f6d1ad7b246dd9cdbe22.Draw(this.cae7d9ab04158c81e2ff210e16d0bb7fa, new Rectangle(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10784), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10788), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10792), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10796)), c6527c2bfb4fd3c4ba37fb81728484d72.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Color.White, this.c54fe05eaad068abc39c326095cfeac64));
					this.c54fe05eaad068abc39c326095cfeac64 += cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10800);
				}
				else
				{
					MediaPlayer.Stop();
					this.cd1c996b39b95f6d1ad7b246dd9cdbe22.Draw(this.cae7d9ab04158c81e2ff210e16d0bb7fa, new Rectangle(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10804), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10808), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10812), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10816)), Color.White);
					if (this.c68aa41a5cf0b21bf35472d579b6219bb != null)
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
						this.cd1c996b39b95f6d1ad7b246dd9cdbe22.Draw(this.c68aa41a5cf0b21bf35472d579b6219bb, new Rectangle(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10820), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10824), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10828), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10832)), Color.White);
						this.cd1c996b39b95f6d1ad7b246dd9cdbe22.Draw(this.c1952df75909aa99797fba5e80c5baf58, new Vector2(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10836), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(10840)), Color.White);
					}
					if (this.c14210024308787faa409e401aaf1197e == null)
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
						c35f868ba35d5c51ce5a72f140870f944.c5cd2b1ccdf0a31739076c89f0f37927f c5cd2b1ccdf0a31739076c89f0f37927f = new c35f868ba35d5c51ce5a72f140870f944.c5cd2b1ccdf0a31739076c89f0f37927f();
						c5cd2b1ccdf0a31739076c89f0f37927f.c4404a159870bf55bb6f111e66e59e82d = this;
						c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474 = this.c6bf7d922b0de22e49f447c8d0fb987ad.c04a799c99dd357cf35ae2407537c3d1c(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10844) != 0);
						c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.FullScreen = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10848) != 0);
						c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.c2abf7733dfa8f63c28711c4d4fdf3389 += this.cb5126274a6da75d5d70f475d61a38e00;
						if (File.Exists(c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.c0a254255436def68504b708355d89587))
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
							if (File.Exists(c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.cd4bc1cb5288cbdc39ea878f29ae4794b))
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
								if (!File.Exists(c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.c6c81a687812a72cf6d69a1b2b1f51dee))
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
									BinaryWriter binaryWriter = new BinaryWriter(File.Create(c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.c6c81a687812a72cf6d69a1b2b1f51dee));
									try
									{
										byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10852));
										FileStream fileStream = File.Open(c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.cd4bc1cb5288cbdc39ea878f29ae4794b, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10856));
										try
										{
											binaryWriter.Write(this.c872a360c8405ca33019203d2a384cbf3);
											binaryWriter.Write((int)(fileStream.Length + (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10860) - (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10864)));
											binaryWriter.Write(this.c363cf68286a3d05767e684fe0bd36e16);
											binaryWriter.Write((int)fileStream.Length - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10868));
											while (fileStream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10872), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10876)) != 0)
											{
												binaryWriter.Write(array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10880)]);
												binaryWriter.Write(array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10884)]);
											}
											for (;;)
											{
												switch (1)
												{
												case 0:
													continue;
												}
												break;
											}
										}
										finally
										{
											if (fileStream != null)
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
												((IDisposable)fileStream).Dispose();
											}
										}
									}
									finally
									{
										if (binaryWriter != null)
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
											((IDisposable)binaryWriter).Dispose();
										}
									}
								}
								this.c9db896fcda046842bb2c199dd6d04928 = new SoundPlayer(c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.c6c81a687812a72cf6d69a1b2b1f51dee);
								SoundPlayer soundPlayer = this.c9db896fcda046842bb2c199dd6d04928;
								if (soundPlayer == null)
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
								}
								else
								{
									soundPlayer.Play();
								}
								Bitmap bitmap = TargaImage.LoadTargaImage(c5cd2b1ccdf0a31739076c89f0f37927f.c6cfe4a6a4a47430d95db2df361685474.c0a254255436def68504b708355d89587);
								try
								{
									MemoryStream memoryStream = new MemoryStream();
									try
									{
										bitmap.Save(memoryStream, ImageFormat.Png);
										this.c68aa41a5cf0b21bf35472d579b6219bb = Texture2D.FromStream(base.GraphicsDevice, memoryStream);
									}
									finally
									{
										if (memoryStream != null)
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
											((IDisposable)memoryStream).Dispose();
										}
									}
								}
								finally
								{
									if (bitmap != null)
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
										((IDisposable)bitmap).Dispose();
									}
								}
							}
						}
						int millisecondsDelay;
						if (this.c6bf7d922b0de22e49f447c8d0fb987ad.System != (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10888))
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
							millisecondsDelay = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10892);
						}
						else
						{
							millisecondsDelay = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10896);
						}
						this.c14210024308787faa409e401aaf1197e = Task.Delay(millisecondsDelay).ContinueWith(new Action<Task>(c5cd2b1ccdf0a31739076c89f0f37927f.c2362fc84bddc180334a2c1ad170938ed));
					}
				}
			}
			this.cd1c996b39b95f6d1ad7b246dd9cdbe22.End();
			base.Draw(gameTime);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00027730 File Offset: 0x00025930
		protected override void Initialize()
		{
			MediaPlayer.IsRepeating = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10900) != 0);
			this.cae7d9ab04158c81e2ff210e16d0bb7fa = new Texture2D(base.GraphicsDevice, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10904), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10908));
			Texture2D texture2D = this.cae7d9ab04158c81e2ff210e16d0bb7fa;
			Color[] array = c31beb92a20cb9f47360118ffb6eb9f44.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10912));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10916)] = Color.Black;
			texture2D.SetData<Color>(array);
			this.c29f8c721d33733efc8c8d2c1e306b333 = (this.c0808e5b6a0c9b426158f81b10e07e8a6.PreferredBackBufferHeight - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10920) * (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10924) + this.c3a4ba1e43fc18bf5464d0fc468844aa5)) / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10928);
			this.c32dc831909d43d6eb5b58a09644606d4 = (this.c0808e5b6a0c9b426158f81b10e07e8a6.PreferredBackBufferWidth - cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10932) * (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10936) + this.c3a4ba1e43fc18bf5464d0fc468844aa5)) / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10940);
			base.Initialize();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00027824 File Offset: 0x00025A24
		protected override void LoadContent()
		{
			this.ceaca090d9a326c0de90d19efc270e5d2 = base.Content.Load<SoundEffect>(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45039));
			this.ce9d29eae156a003cb83ca4518efb45c3 = base.Content.Load<SoundEffect>(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45060));
			this.cd1c996b39b95f6d1ad7b246dd9cdbe22 = new SpriteBatch(base.GraphicsDevice);
			this.c2c22d6040ed94b3a855229b12c9fb28f = base.Content.Load<SpriteFont>(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45077));
			this.ce1675bad66333e659e3a78ebac3c70ff = base.Content.Load<Texture2D>(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45086));
			this.c1952df75909aa99797fba5e80c5baf58 = base.Content.Load<Texture2D>(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45113));
			this.cc1ca4aa6963a01bc70831eff572746e1 = base.Content.Load<Texture2D>(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45142));
			this.c0754862db64ef51d68cba87b32ea21fe = base.Content.Load<Texture2D>(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45183));
			this.cbdd7a75e348cb852622ecf3ce3761260();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00027934 File Offset: 0x00025B34
		protected override void UnloadContent()
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00027944 File Offset: 0x00025B44
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10944)).Buttons.Back != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10948))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.Update(GameTime)).MethodHandle;
				}
				if (!Keyboard.GetState().IsKeyDown(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10952)))
				{
					goto IL_CD;
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
			}
			this.c94a1f33ce3ca5392850bd63ff3984811 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10956) != 0);
			this.c0808e5b6a0c9b426158f81b10e07e8a6.ToggleFullScreen();
			IntPtr handle = base.Window.Handle;
			if (!handle.Equals(IntPtr.Zero))
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
				c35f868ba35d5c51ce5a72f140870f944.c6b07817cc4a154a9b9eebc12ed666060(handle, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10960));
			}
			MediaPlayer.Stop();
			IL_CD:
			if (!this.c442312d6c1f06e61e21cc841730b6907)
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
				KeyboardState state = Keyboard.GetState();
				if (this.c6d928daff83014169455fea469554ec1.IsKeyUp(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10964)))
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
					if (state.IsKeyDown(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10968)))
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
						this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10972) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10976) != 0);
					}
				}
				if (this.c6d928daff83014169455fea469554ec1.IsKeyUp(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10980)))
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
					if (state.IsKeyDown(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10984)))
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
						this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10988) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10992) != 0);
					}
				}
				if (this.c6d928daff83014169455fea469554ec1.IsKeyUp(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(10996)))
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
					if (state.IsKeyDown(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11000)))
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
						this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11004) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11008) != 0);
					}
				}
				if (this.c6d928daff83014169455fea469554ec1.IsKeyUp(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11012)))
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
					if (state.IsKeyDown(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11016)))
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
						this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11020) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11024) != 0);
					}
				}
				if (this.c6d928daff83014169455fea469554ec1.IsKeyUp(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11028)))
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
					if (state.IsKeyDown(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11032)))
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
						if (this.c6bf7d922b0de22e49f447c8d0fb987ad != null)
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
							SoundEffect soundEffect = this.ce9d29eae156a003cb83ca4518efb45c3;
							if (soundEffect == null)
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
							}
							else
							{
								soundEffect.Play();
							}
							this.c442312d6c1f06e61e21cc841730b6907 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11036) != 0);
						}
					}
				}
				if (this.c6d928daff83014169455fea469554ec1.IsKeyUp(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11040)))
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
					if (state.IsKeyDown(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11044)))
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
						if (this.cac9236972b1f92a0a39840e2b94c0918 > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11048))
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
							if (this.c9e45e7408647c11a91f8f2194f006d79 == 0)
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
								this.c02290f8607a9ba8797f700b1b66ec0fd = this.cac9236972b1f92a0a39840e2b94c0918;
								this.c9e45e7408647c11a91f8f2194f006d79 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11052);
							}
							else if (this.c9e45e7408647c11a91f8f2194f006d79 == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11056))
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
								c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = this.c6f18cec0938fad27246b19219b647f7e[this.c02290f8607a9ba8797f700b1b66ec0fd];
								this.c6f18cec0938fad27246b19219b647f7e[this.c02290f8607a9ba8797f700b1b66ec0fd] = this.c6f18cec0938fad27246b19219b647f7e[this.cac9236972b1f92a0a39840e2b94c0918];
								this.c6f18cec0938fad27246b19219b647f7e[this.cac9236972b1f92a0a39840e2b94c0918] = c5409344e1c2b74fa8c9a4d620ccb8d;
								Vector2 vector = this.c80abcd3648346e89942120932de01edf(this.c02290f8607a9ba8797f700b1b66ec0fd);
								Vector2 vector2 = this.c80abcd3648346e89942120932de01edf(this.cac9236972b1f92a0a39840e2b94c0918);
								Texture2D texture2D = this.cb157f83b3809f2b42ef16034e7efc63b[(int)vector.Y, (int)vector.X];
								this.cb157f83b3809f2b42ef16034e7efc63b[(int)vector.Y, (int)vector.X] = this.cb157f83b3809f2b42ef16034e7efc63b[(int)vector2.Y, (int)vector2.X];
								this.cb157f83b3809f2b42ef16034e7efc63b[(int)vector2.Y, (int)vector2.X] = texture2D;
								this.c38b3d68da402fa449ae70ea24a7a135f();
								this.c9e45e7408647c11a91f8f2194f006d79 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11060);
							}
						}
					}
				}
				this.c6d928daff83014169455fea469554ec1 = state;
				try
				{
					if (GamePad.GetCapabilities(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11064)).IsConnected)
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
						GamePadState state2 = GamePad.GetState(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11068));
						if (state2.ThumbSticks.Left.X < cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(11072))
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
							this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11076) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11080) != 0);
						}
						if (state2.ThumbSticks.Left.X > cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(11084))
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
							this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11088) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11092) != 0);
						}
						if (state2.ThumbSticks.Left.Y < cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(11096))
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
							this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11100) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11104) != 0);
						}
						if (state2.ThumbSticks.Left.Y > cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(11108))
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
							this.cf67b32a904de2cbe74dd46d85548fa7d(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11112) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11116) != 0);
						}
					}
				}
				catch
				{
				}
			}
			base.Update(gameTime);
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00027F78 File Offset: 0x00026178
		private c5409344e1c2b74fa8c9a4d620ccb8d48 c6bf7d922b0de22e49f447c8d0fb987ad
		{
			get
			{
				if (this.c1672508575d0a793a6fd2e84ee8aea8c * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11120) + this.c6c7c0533d846f9356f0ddf2cfcba5c9d < (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(this.c6f18cec0938fad27246b19219b647f7e))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.get_c6bf7d922b0de22e49f447c8d0fb987ad()).MethodHandle;
					}
					return this.c6f18cec0938fad27246b19219b647f7e[this.c1672508575d0a793a6fd2e84ee8aea8c * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11124) + this.c6c7c0533d846f9356f0ddf2cfcba5c9d];
				}
				return null;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00027FE4 File Offset: 0x000261E4
		private int cac9236972b1f92a0a39840e2b94c0918
		{
			get
			{
				return this.c1672508575d0a793a6fd2e84ee8aea8c * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11128) + this.c6c7c0533d846f9356f0ddf2cfcba5c9d;
			}
		}

		// Token: 0x060005CA RID: 1482
		[DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true)]
		private static extern bool c38a4a9c5a781b6481be8dffbeca5e11f(IntPtr c066891678a283862c572a0812e4bc95a);

		// Token: 0x060005CB RID: 1483
		[DllImport("user32.dll", EntryPoint = "ShowWindow")]
		private static extern bool c6b07817cc4a154a9b9eebc12ed666060(IntPtr c066891678a283862c572a0812e4bc95a, int cdbda10057dd77f6ddd26d4ab595448c6);

		// Token: 0x060005CC RID: 1484 RVA: 0x0002800C File Offset: 0x0002620C
		private Vector2 c80abcd3648346e89942120932de01edf(int c495a48f0aebe7c42738c327c27ca1bf3)
		{
			return new Vector2((float)(c495a48f0aebe7c42738c327c27ca1bf3 % cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11132)), (float)(c495a48f0aebe7c42738c327c27ca1bf3 / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11136)));
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00028038 File Offset: 0x00026238
		private Vector2 c12f69801a4830f20c47d11cb0e8e1fef(int ced17f5fac5de96d8d690dac7cea067a7, int c6af8c3f2221db51dc69e06457ad9f859)
		{
			return new Vector2((float)this.c9bfe76468d033805c58a9faea1502a78(ced17f5fac5de96d8d690dac7cea067a7, this.c32dc831909d43d6eb5b58a09644606d4), (float)this.c9bfe76468d033805c58a9faea1502a78(c6af8c3f2221db51dc69e06457ad9f859, this.c29f8c721d33733efc8c8d2c1e306b333));
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0002806C File Offset: 0x0002626C
		private Vector2 c9964a154d0eb036f6c6e37b87cd4ddd6(int ced17f5fac5de96d8d690dac7cea067a7, int c6af8c3f2221db51dc69e06457ad9f859)
		{
			return new Vector2((float)(this.c9bfe76468d033805c58a9faea1502a78(ced17f5fac5de96d8d690dac7cea067a7, this.c32dc831909d43d6eb5b58a09644606d4) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11140)), (float)(this.c9bfe76468d033805c58a9faea1502a78(c6af8c3f2221db51dc69e06457ad9f859, this.c29f8c721d33733efc8c8d2c1e306b333) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11144)));
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000280B4 File Offset: 0x000262B4
		private int c9bfe76468d033805c58a9faea1502a78(int c48e42be55fb577e9d92a658479c49ba7, int c39a7f585667d01e0c9b43a5fc70a862d)
		{
			return this.c3a4ba1e43fc18bf5464d0fc468844aa5 / cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11148) + c39a7f585667d01e0c9b43a5fc70a862d + c48e42be55fb577e9d92a658479c49ba7 * (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11152) + this.c3a4ba1e43fc18bf5464d0fc468844aa5);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000280E8 File Offset: 0x000262E8
		private void cf92cd1508967a84c645ff752d7540bf0()
		{
			this.c6f18cec0938fad27246b19219b647f7e = c049d2fd5839d8f87efe26223b47d7e92.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11156));
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> values = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Values;
			Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool> predicate;
			if ((predicate = c35f868ba35d5c51ce5a72f140870f944.<>c.c39b4dd839ff5a49b823c81709ad086fa) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.cf92cd1508967a84c645ff752d7540bf0()).MethodHandle;
				}
				predicate = (c35f868ba35d5c51ce5a72f140870f944.<>c.c39b4dd839ff5a49b823c81709ad086fa = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(c35f868ba35d5c51ce5a72f140870f944.<>c.cdfab1996eb8651828de2a4469aa3481e.cba87a0e483914b993fb5c89ed1680b1c));
			}
			List<c5409344e1c2b74fa8c9a4d620ccb8d48> list = values.Where(predicate).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11160); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11180); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11176))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11164); j < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11172); j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11168))
				{
					this.cb157f83b3809f2b42ef16034e7efc63b[i, j] = c5de679d1063c860586cedeea0687914f.cab55a050df275722227783d6686266c9;
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
			for (;;)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			try
			{
				c35f868ba35d5c51ce5a72f140870f944.c7ad8d72eda2abd543786ae7272bf64d9 c7ad8d72eda2abd543786ae7272bf64d = new c35f868ba35d5c51ce5a72f140870f944.c7ad8d72eda2abd543786ae7272bf64d9();
				c7ad8d72eda2abd543786ae7272bf64d.c2f96c93fa27152aa1fada5cc926dd1a8 = c67726bc94fb4dd43c5c00e863a4fed19.c8334ccea7202097a0899b9cb1fac251e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45204));
				c7ad8d72eda2abd543786ae7272bf64d.cd5961f5606cd76e95b9b6611f7dd165e = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11184);
				int k;
				while (c7ad8d72eda2abd543786ae7272bf64d.cd5961f5606cd76e95b9b6611f7dd165e < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(c7ad8d72eda2abd543786ae7272bf64d.c2f96c93fa27152aa1fada5cc926dd1a8))
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
					if (c7ad8d72eda2abd543786ae7272bf64d.cd5961f5606cd76e95b9b6611f7dd165e >= (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(this.c6f18cec0938fad27246b19219b647f7e))
					{
						for (;;)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							goto IL_1D8;
						}
					}
					else
					{
						List<c5409344e1c2b74fa8c9a4d620ccb8d48> list2 = list;
						Predicate<c5409344e1c2b74fa8c9a4d620ccb8d48> match;
						if ((match = c7ad8d72eda2abd543786ae7272bf64d.cac9765e7f8695e8272de3db1470e0933) == null)
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
							match = (c7ad8d72eda2abd543786ae7272bf64d.cac9765e7f8695e8272de3db1470e0933 = new Predicate<c5409344e1c2b74fa8c9a4d620ccb8d48>(c7ad8d72eda2abd543786ae7272bf64d.c72ab314fa6e16360ca94abc76f132702));
						}
						c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = list2.Find(match);
						if (c5409344e1c2b74fa8c9a4d620ccb8d != null)
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
							if (!this.c6f18cec0938fad27246b19219b647f7e.Contains(c5409344e1c2b74fa8c9a4d620ccb8d))
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
								this.c6f18cec0938fad27246b19219b647f7e[c7ad8d72eda2abd543786ae7272bf64d.cd5961f5606cd76e95b9b6611f7dd165e] = c5409344e1c2b74fa8c9a4d620ccb8d;
							}
						}
						k = c7ad8d72eda2abd543786ae7272bf64d.cd5961f5606cd76e95b9b6611f7dd165e;
						c7ad8d72eda2abd543786ae7272bf64d.cd5961f5606cd76e95b9b6611f7dd165e = k + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11188);
					}
				}
				IL_1D8:
				c5409344e1c2b74fa8c9a4d620ccb8d48[] array = list.Where(new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(this.c2c940d05b5ad78481c61919fdd00685e)).ToArray<c5409344e1c2b74fa8c9a4d620ccb8d48>();
				k = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11192);
				IL_274:
				while (k < (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(array))
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d2 = array[k];
					for (int l = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11196); l < (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(this.c6f18cec0938fad27246b19219b647f7e); l += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11200))
					{
						if (this.c6f18cec0938fad27246b19219b647f7e[l] == null)
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
							this.c6f18cec0938fad27246b19219b647f7e[l] = c5409344e1c2b74fa8c9a4d620ccb8d2;
							IL_265:
							k += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11204);
							goto IL_274;
						}
					}
					for (;;)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						goto IL_265;
					}
				}
				for (;;)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			catch
			{
				int m = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11208);
				while (m < (int)cbd3745968a9a575ce5b013ba4ada8ce8.cfeb04651f165d0166e7c10ab1acf8b28(this.c6f18cec0938fad27246b19219b647f7e))
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
					if (m >= list.Count)
					{
						for (;;)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							goto IL_2F4;
						}
					}
					else
					{
						this.c6f18cec0938fad27246b19219b647f7e[m] = list[m];
						m += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11212);
					}
				}
				IL_2F4:;
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00028408 File Offset: 0x00026608
		private void cf67b32a904de2cbe74dd46d85548fa7d(bool c9c6ab24b0135164623c420b279b6233e, bool ca8cc030f28ba54db9f836f0cd9bb186b)
		{
			SoundEffect soundEffect = this.ceaca090d9a326c0de90d19efc270e5d2;
			if (soundEffect == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.cf67b32a904de2cbe74dd46d85548fa7d(bool, bool)).MethodHandle;
				}
			}
			else
			{
				soundEffect.Play();
			}
			if (c9c6ab24b0135164623c420b279b6233e && ca8cc030f28ba54db9f836f0cd9bb186b)
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
				if (this.c6c7c0533d846f9356f0ddf2cfcba5c9d > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11216))
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
					this.c6c7c0533d846f9356f0ddf2cfcba5c9d -= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11220);
				}
			}
			if (c9c6ab24b0135164623c420b279b6233e)
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
				if (!ca8cc030f28ba54db9f836f0cd9bb186b)
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
					if (this.c6c7c0533d846f9356f0ddf2cfcba5c9d < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11224))
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
						this.c6c7c0533d846f9356f0ddf2cfcba5c9d += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11228);
					}
				}
			}
			if ((c9c6ab24b0135164623c420b279b6233e ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11232) && ca8cc030f28ba54db9f836f0cd9bb186b)
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
				if (this.c1672508575d0a793a6fd2e84ee8aea8c > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11236))
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
					this.c1672508575d0a793a6fd2e84ee8aea8c -= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11240);
				}
			}
			if (!c9c6ab24b0135164623c420b279b6233e)
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
				if (!ca8cc030f28ba54db9f836f0cd9bb186b)
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
					if (this.c1672508575d0a793a6fd2e84ee8aea8c < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11244))
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
						this.c1672508575d0a793a6fd2e84ee8aea8c += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11248);
					}
				}
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00028568 File Offset: 0x00026768
		private void c38b3d68da402fa449ae70ea24a7a135f()
		{
			object obj = this.cd1965857520cad98fb5dec6e13316d69;
			bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11252) != 0;
			try
			{
				Monitor.Enter(obj, ref flag);
				string c4d6abdac9d3efb16a0adcf6a56cd5ad = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(45204);
				IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> source = this.c6f18cec0938fad27246b19219b647f7e;
				Func<c5409344e1c2b74fa8c9a4d620ccb8d48, string> selector;
				if ((selector = c35f868ba35d5c51ce5a72f140870f944.<>c.cfcfd28011559d1de77abd7dfa26cf9c6) == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.c38b3d68da402fa449ae70ea24a7a135f()).MethodHandle;
					}
					selector = (c35f868ba35d5c51ce5a72f140870f944.<>c.cfcfd28011559d1de77abd7dfa26cf9c6 = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, string>(c35f868ba35d5c51ce5a72f140870f944.<>c.cdfab1996eb8651828de2a4469aa3481e.c397fc9cf73a3d6ef9a0cbbe028543314));
				}
				c67726bc94fb4dd43c5c00e863a4fed19.c6be8a9a2e62443fd1e448c28bd8dad3e(c4d6abdac9d3efb16a0adcf6a56cd5ad, source.Select(selector).ToArray<string>());
			}
			finally
			{
				if (flag)
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
					Monitor.Exit(obj);
				}
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0002860C File Offset: 0x0002680C
		[CompilerGenerated]
		private void c906844a7cd2ef267dd46074512f35775()
		{
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11256); i < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11284); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11280))
			{
				for (int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11260); j < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11276); j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11272))
				{
					if (this.c6f18cec0938fad27246b19219b647f7e[i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11264) + j] != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.c906844a7cd2ef267dd46074512f35775()).MethodHandle;
						}
						try
						{
							MemoryStream memoryStream = new MemoryStream(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(this.c6f18cec0938fad27246b19219b647f7e[i * cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11268) + j].IconUrl));
							try
							{
								this.cb157f83b3809f2b42ef16034e7efc63b[i, j] = Texture2D.FromStream(base.GraphicsDevice, memoryStream);
							}
							finally
							{
								if (memoryStream != null)
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
									((IDisposable)memoryStream).Dispose();
								}
							}
						}
						catch
						{
						}
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
			for (;;)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00028738 File Offset: 0x00026938
		[CompilerGenerated]
		private bool ca12695c05ce21770e640c4dd8df5dc7f(char ced17f5fac5de96d8d690dac7cea067a7)
		{
			return this.c2c22d6040ed94b3a855229b12c9fb28f.Characters.Contains(ced17f5fac5de96d8d690dac7cea067a7);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0002875C File Offset: 0x0002695C
		[CompilerGenerated]
		private void cb5126274a6da75d5d70f475d61a38e00(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			this.c5f1cd24dc26e3f5d3385bbf360d8758f = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11288) != 0);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0002877C File Offset: 0x0002697C
		[CompilerGenerated]
		private bool c2c940d05b5ad78481c61919fdd00685e(c5409344e1c2b74fa8c9a4d620ccb8d48 ced17f5fac5de96d8d690dac7cea067a7)
		{
			return (this.c6f18cec0938fad27246b19219b647f7e.Contains(ced17f5fac5de96d8d690dac7cea067a7) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11292);
		}

		// Token: 0x040002FE RID: 766
		private const int c4a59163993a666d3b0d4690c609a5b0b = 10;

		// Token: 0x040002FF RID: 767
		private const int c0c6cb5f795f7e6f5aebc2a3c71df8c4e = 5;

		// Token: 0x04000300 RID: 768
		private const int c1bd86e8c3c7c896800472cc88bb0c4e3 = 5;

		// Token: 0x04000301 RID: 769
		private const int ce9a3c406a2fc84c9b723d8e581502cf8 = 3;

		// Token: 0x04000302 RID: 770
		private const int c56626670a046660ce76411d8f5388d6c = 2;

		// Token: 0x04000303 RID: 771
		private const int c4ec37c17d99f9986381056b5c337bbad = 1;

		// Token: 0x04000304 RID: 772
		private readonly Texture2D[,] cb157f83b3809f2b42ef16034e7efc63b = new Texture2D[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11296), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11300)];

		// Token: 0x04000305 RID: 773
		private readonly int c3a4ba1e43fc18bf5464d0fc468844aa5 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(11304);

		// Token: 0x04000306 RID: 774
		private readonly GraphicsDeviceManager c0808e5b6a0c9b426158f81b10e07e8a6;

		// Token: 0x04000307 RID: 775
		private readonly byte[] c872a360c8405ca33019203d2a384cbf3;

		// Token: 0x04000308 RID: 776
		private readonly byte[] c363cf68286a3d05767e684fe0bd36e16;

		// Token: 0x04000309 RID: 777
		private Texture2D ce1675bad66333e659e3a78ebac3c70ff;

		// Token: 0x0400030A RID: 778
		private Texture2D c68aa41a5cf0b21bf35472d579b6219bb;

		// Token: 0x0400030B RID: 779
		private bool c5f1cd24dc26e3f5d3385bbf360d8758f;

		// Token: 0x0400030C RID: 780
		private SoundEffect ceaca090d9a326c0de90d19efc270e5d2;

		// Token: 0x0400030D RID: 781
		private SoundEffect ce9d29eae156a003cb83ca4518efb45c3;

		// Token: 0x0400030E RID: 782
		private Texture2D c209a4605eb9cdcc6048183f4c9e778f8;

		// Token: 0x0400030F RID: 783
		private int c29f8c721d33733efc8c8d2c1e306b333;

		// Token: 0x04000310 RID: 784
		private int c32dc831909d43d6eb5b58a09644606d4;

		// Token: 0x04000311 RID: 785
		private bool c94a1f33ce3ca5392850bd63ff3984811;

		// Token: 0x04000312 RID: 786
		private Texture2D cc1ca4aa6963a01bc70831eff572746e1;

		// Token: 0x04000313 RID: 787
		private object cd1965857520cad98fb5dec6e13316d69;

		// Token: 0x04000314 RID: 788
		private Texture2D c0754862db64ef51d68cba87b32ea21fe;

		// Token: 0x04000315 RID: 789
		private int cda73ad01def0f0eb093487ab944e47f6;

		// Token: 0x04000316 RID: 790
		private int cf35a0cc4d235b83b3e7ba7b334cff889;

		// Token: 0x04000317 RID: 791
		private Texture2D c1952df75909aa99797fba5e80c5baf58;

		// Token: 0x04000318 RID: 792
		private float c54fe05eaad068abc39c326095cfeac64;

		// Token: 0x04000319 RID: 793
		private SoundPlayer c9db896fcda046842bb2c199dd6d04928;

		// Token: 0x0400031A RID: 794
		private Texture2D cae7d9ab04158c81e2ff210e16d0bb7fa;

		// Token: 0x0400031B RID: 795
		private SpriteFont c2c22d6040ed94b3a855229b12c9fb28f;

		// Token: 0x0400031C RID: 796
		private int c02290f8607a9ba8797f700b1b66ec0fd;

		// Token: 0x0400031D RID: 797
		private c5409344e1c2b74fa8c9a4d620ccb8d48[] c6f18cec0938fad27246b19219b647f7e;

		// Token: 0x0400031E RID: 798
		private KeyboardState c6d928daff83014169455fea469554ec1;

		// Token: 0x0400031F RID: 799
		private bool c442312d6c1f06e61e21cc841730b6907;

		// Token: 0x04000320 RID: 800
		private Task c14210024308787faa409e401aaf1197e;

		// Token: 0x04000321 RID: 801
		private int c9e45e7408647c11a91f8f2194f006d79;

		// Token: 0x04000322 RID: 802
		private int c6c7c0533d846f9356f0ddf2cfcba5c9d;

		// Token: 0x04000323 RID: 803
		private int c1672508575d0a793a6fd2e84ee8aea8c;

		// Token: 0x04000324 RID: 804
		private SpriteBatch cd1c996b39b95f6d1ad7b246dd9cdbe22;

		// Token: 0x02000143 RID: 323
		[CompilerGenerated]
		private sealed class c5cd2b1ccdf0a31739076c89f0f37927f
		{
			// Token: 0x06000955 RID: 2389 RVA: 0x0005F660 File Offset: 0x0005D860
			internal void c2362fc84bddc180334a2c1ad170938ed(Task c0d301987ae5e67ad4f8ccfb9e2edb469)
			{
				SoundPlayer c9db896fcda046842bb2c199dd6d = this.c4404a159870bf55bb6f111e66e59e82d.c9db896fcda046842bb2c199dd6d04928;
				if (c9db896fcda046842bb2c199dd6d == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c35f868ba35d5c51ce5a72f140870f944.c5cd2b1ccdf0a31739076c89f0f37927f.c2362fc84bddc180334a2c1ad170938ed(Task)).MethodHandle;
					}
				}
				else
				{
					c9db896fcda046842bb2c199dd6d.Stop();
				}
				this.c4404a159870bf55bb6f111e66e59e82d.c9db896fcda046842bb2c199dd6d04928 = c9a26d91d8eac8623f43f5e1febfb0f47.cab55a050df275722227783d6686266c9;
				this.c4404a159870bf55bb6f111e66e59e82d.c68aa41a5cf0b21bf35472d579b6219bb = c5de679d1063c860586cedeea0687914f.cab55a050df275722227783d6686266c9;
				this.c4404a159870bf55bb6f111e66e59e82d.c54fe05eaad068abc39c326095cfeac64 = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(30600);
				this.c4404a159870bf55bb6f111e66e59e82d.c14210024308787faa409e401aaf1197e = ce1579191a34f7c6eb27bbdc097c1c96a.cab55a050df275722227783d6686266c9;
				this.c4404a159870bf55bb6f111e66e59e82d.c442312d6c1f06e61e21cc841730b6907 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30604) != 0);
				this.c4404a159870bf55bb6f111e66e59e82d.c6bf7d922b0de22e49f447c8d0fb987ad.c37b3d3a9ef4a26c65a3fac4aa3cda6c2(this.c6cfe4a6a4a47430d95db2df361685474);
			}

			// Token: 0x040006E6 RID: 1766
			public cf7c96734e58d8de9864e1ea854bc2b7b c6cfe4a6a4a47430d95db2df361685474;

			// Token: 0x040006E7 RID: 1767
			public c35f868ba35d5c51ce5a72f140870f944 c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000144 RID: 324
		[CompilerGenerated]
		private sealed class c7ad8d72eda2abd543786ae7272bf64d9
		{
			// Token: 0x06000957 RID: 2391 RVA: 0x0005F720 File Offset: 0x0005D920
			internal bool c72ab314fa6e16360ca94abc76f132702(c5409344e1c2b74fa8c9a4d620ccb8d48 ced17f5fac5de96d8d690dac7cea067a7)
			{
				return c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ced17f5fac5de96d8d690dac7cea067a7.TitleId.IdRaw, this.c2f96c93fa27152aa1fada5cc926dd1a8[this.cd5961f5606cd76e95b9b6611f7dd165e]);
			}

			// Token: 0x040006E8 RID: 1768
			public string[] c2f96c93fa27152aa1fada5cc926dd1a8;

			// Token: 0x040006E9 RID: 1769
			public int cd5961f5606cd76e95b9b6611f7dd165e;

			// Token: 0x040006EA RID: 1770
			public Predicate<c5409344e1c2b74fa8c9a4d620ccb8d48> cac9765e7f8695e8272de3db1470e0933;
		}
	}
}
