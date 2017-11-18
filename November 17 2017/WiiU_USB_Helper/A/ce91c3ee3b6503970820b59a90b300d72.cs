using System;
using System.Runtime.CompilerServices;

namespace A
{
	// Token: 0x0200006C RID: 108
	public class ce91c3ee3b6503970820b59a90b300d72 : EventArgs
	{
		// Token: 0x0600031F RID: 799 RVA: 0x00014C70 File Offset: 0x00012E70
		internal ce91c3ee3b6503970820b59a90b300d72(int c94ef51a05a17c81ac793e4e25099d37c, int c613e913e5fa5d192878921b50a8ac21f, int ca09ff184392b8f33e17c60209ec3438f, TimeSpan cdb3e718088eb1365b1af8e9fe62e8e38, TimeSpan c55bd5d33098a80b8dcdfdc4d2e8b8b19, TimeSpan cb3e1a064ee5521266d8dcb6b28fa432e, c8d217bce073ddc882212f4d0e016403a cef94e12d085457557bbcac9bef54a336, c6114b34ba4893a53ebb4b599e0e2e3fc ca490ca7ea6cc5d1aa5a6e0b9a0390eba)
		{
			this.GameProgress = c94ef51a05a17c81ac793e4e25099d37c;
			this.TotalProgress = c613e913e5fa5d192878921b50a8ac21f;
			this.GameEta = cdb3e718088eb1365b1af8e9fe62e8e38;
			this.TotalEta = c55bd5d33098a80b8dcdfdc4d2e8b8b19;
			this.Speed = cef94e12d085457557bbcac9bef54a336;
			this.FileEta = cb3e1a064ee5521266d8dcb6b28fa432e;
			this.FileProgress = ca09ff184392b8f33e17c60209ec3438f;
			this.Title = ca490ca7ea6cc5d1aa5a6e0b9a0390eba;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00014CC0 File Offset: 0x00012EC0
		public TimeSpan FileEta { get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00014CD4 File Offset: 0x00012ED4
		public int FileProgress { get; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00014CE8 File Offset: 0x00012EE8
		public TimeSpan GameEta { get; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00014CFC File Offset: 0x00012EFC
		public int GameProgress { get; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00014D10 File Offset: 0x00012F10
		public c8d217bce073ddc882212f4d0e016403a Speed { get; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00014D24 File Offset: 0x00012F24
		public c6114b34ba4893a53ebb4b599e0e2e3fc Title { get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00014D38 File Offset: 0x00012F38
		public TimeSpan TotalEta { get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00014D4C File Offset: 0x00012F4C
		public int TotalProgress { get; }

		// Token: 0x040001C7 RID: 455
		[CompilerGenerated]
		private readonly TimeSpan ce784c4382c17d232fac4e01ed5fa0604;

		// Token: 0x040001C8 RID: 456
		[CompilerGenerated]
		private readonly int ceb17c32e884707157220a9ab342e0b47;

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		private readonly TimeSpan c39b85ae9db7dd49b29f1c572e67a72eb;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private readonly int c0a0e377e89b1f35fcbcb865e61a0ee5d;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private readonly c8d217bce073ddc882212f4d0e016403a c4c57231d55aca6955a354b47dc87547e;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private readonly c6114b34ba4893a53ebb4b599e0e2e3fc cd80645f9c53153f7ba5f1d8bae67d7ed;

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		private readonly TimeSpan c06f718bd2c046f856d98f4d77bb5a5d5;

		// Token: 0x040001CE RID: 462
		[CompilerGenerated]
		private readonly int c95496b504c314d8b86b1816644557cf0;
	}
}
