using System;

namespace NusHelper.Server
{
	// Token: 0x02000085 RID: 133
	public sealed class DbRow
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000187A0 File Offset: 0x000169A0
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000187B4 File Offset: 0x000169B4
		public bool DiscOnly { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000187C8 File Offset: 0x000169C8
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000187DC File Offset: 0x000169DC
		public string EshopId { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000187F0 File Offset: 0x000169F0
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00018804 File Offset: 0x00016A04
		public string IconUrl { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00018818 File Offset: 0x00016A18
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0001882C File Offset: 0x00016A2C
		public string Name { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00018840 File Offset: 0x00016A40
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00018854 File Offset: 0x00016A54
		public Platform Platform { get; set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00018868 File Offset: 0x00016A68
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0001887C File Offset: 0x00016A7C
		public bool PreLoad { get; set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00018890 File Offset: 0x00016A90
		// (set) Token: 0x060003CF RID: 975 RVA: 0x000188A4 File Offset: 0x00016AA4
		public string ProductCode { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000188B8 File Offset: 0x00016AB8
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000188CC File Offset: 0x00016ACC
		public string Region { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000188E0 File Offset: 0x00016AE0
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x000188F4 File Offset: 0x00016AF4
		public DataSize Size { get; set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00018908 File Offset: 0x00016B08
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0001891C File Offset: 0x00016B1C
		public TitleId TitleId { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00018930 File Offset: 0x00016B30
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00018944 File Offset: 0x00016B44
		public string Version { get; set; }
	}
}
