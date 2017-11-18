using System;
using A;

namespace NusHelper
{
	// Token: 0x0200002D RID: 45
	public class TitleId : IEquatable<TitleId>
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x0000A124 File Offset: 0x00008324
		public TitleId(string id)
		{
			id = id.ToUpper();
			this.IdRaw = id.Substring(0, 16);
			string text = id.Substring(0, 8);
			uint num = ce5aad7d87667873eee3134c0bd54fb2c.cc7b24b22d6237310b31a6d79c5698b7c(text);
			if (num <= 769560898u)
			{
				if (num != 307253171u)
				{
					if (num != 407918885u)
					{
						if (num == 769560898u)
						{
							if (text == "0004000E")
							{
								this.System = ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b;
								this.IdType = 0;
								goto IL_194;
							}
						}
					}
					else if (text == "0005000E")
					{
						this.System = ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd;
						this.IdType = 0;
						goto IL_194;
					}
				}
				else if (text == "0005000C")
				{
					this.System = ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd;
					this.IdType = 2;
					goto IL_194;
				}
			}
			else if (num <= 3135102009u)
			{
				if (num != 2583915261u)
				{
					if (num == 3135102009u)
					{
						if (text == "00040000")
						{
							this.System = ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b;
							this.IdType = 3;
							goto IL_194;
						}
					}
				}
				else if (text == "00048004")
				{
					this.System = ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b;
					this.IdType = 4;
					goto IL_194;
				}
			}
			else if (num != 3276788566u)
			{
				if (num == 3622932888u)
				{
					if (text == "0004008C")
					{
						this.System = ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b;
						this.IdType = 2;
						goto IL_194;
					}
				}
			}
			else if (text == "00050000")
			{
				this.System = ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd;
				this.IdType = 1;
				goto IL_194;
			}
			this.System = ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd;
			this.IdType = 5;
			IL_194:
			this.Low = id.Substring(0, 8);
			this.High = id.Substring(8, 8);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000A2E4 File Offset: 0x000084E4
		public TitleId FullDlc
		{
			get
			{
				switch (this.System)
				{
				case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
					return new TitleId("0004008C" + this.High);
				case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
					return new TitleId("0005000C" + this.High);
				case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000A344 File Offset: 0x00008544
		public TitleId FullGame
		{
			get
			{
				switch (this.System)
				{
				case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
					return new TitleId(((this.IdType != c4646e2a6e2ad7e5620e9ecf229259217.cc1497055f98bea140f4753d720a66191) ? "00040000" : "00048004") + this.High);
				case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
					return new TitleId("00050000" + this.High);
				case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000A3B4 File Offset: 0x000085B4
		public TitleId FullUpdate
		{
			get
			{
				switch (this.System)
				{
				case ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b:
					return new TitleId("0004000E" + this.High);
				case ceee61848167c1ade885c85db30acc060.cf90a45df3f845193b593256082077ecd:
					return new TitleId("0005000E" + this.High);
				case ceee61848167c1ade885c85db30acc060.c2f00fd6125eb2b20294f07bf7da7ca41:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000A414 File Offset: 0x00008614
		public c4646e2a6e2ad7e5620e9ecf229259217 IdType { get; }

		// Token: 0x060000E9 RID: 233 RVA: 0x0000A428 File Offset: 0x00008628
		public static explicit operator TitleId(string id)
		{
			return new TitleId(id);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000A43C File Offset: 0x0000863C
		public static implicit operator string(TitleId id)
		{
			return id.IdRaw;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000A450 File Offset: 0x00008650
		public bool Equals(TitleId other)
		{
			return other != null && other.IdRaw == this.IdRaw;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000A474 File Offset: 0x00008674
		public override bool Equals(object other)
		{
			return other is TitleId && ((TitleId)other).IdRaw == this.IdRaw;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000A4A4 File Offset: 0x000086A4
		public override int GetHashCode()
		{
			return this.IdRaw.GetHashCode();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000A4BC File Offset: 0x000086BC
		public string ToSplitString()
		{
			return this.IdRaw.Insert(8, "-");
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000A4DC File Offset: 0x000086DC
		public override string ToString()
		{
			return this.IdRaw;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000A4F0 File Offset: 0x000086F0
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000A504 File Offset: 0x00008704
		internal string High { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000A518 File Offset: 0x00008718
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000A52C File Offset: 0x0000872C
		internal string Low { get; set; }

		// Token: 0x0400008E RID: 142
		public readonly string IdRaw;

		// Token: 0x04000092 RID: 146
		private const string DlcLow3DS = "0004008C";

		// Token: 0x04000093 RID: 147
		private const string DlcLowSwitch = null;

		// Token: 0x04000094 RID: 148
		private const string DlcLowWiiu = "0005000C";

		// Token: 0x04000095 RID: 149
		private const string GameLow3DS = "00040000";

		// Token: 0x04000096 RID: 150
		private const string GameLowDsi = "00048004";

		// Token: 0x04000097 RID: 151
		private const string GameLowSwitch = null;

		// Token: 0x04000098 RID: 152
		private const string GameLowWiiu = "00050000";

		// Token: 0x04000099 RID: 153
		private const string UpdateLow3DS = "0004000E";

		// Token: 0x0400009A RID: 154
		private const string UpdateLowSwitch = null;

		// Token: 0x0400009B RID: 155
		private const string UpdateLowWiiu = "0005000E";

		// Token: 0x0400009C RID: 156
		private readonly ceee61848167c1ade885c85db30acc060 System;
	}
}
