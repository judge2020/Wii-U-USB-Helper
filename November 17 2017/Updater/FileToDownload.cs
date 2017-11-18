using System;

namespace Updater
{
	// Token: 0x02000006 RID: 6
	internal sealed class FileToDownload
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000376F File Offset: 0x0000196F
		public FileToDownload(string name, string hash, long size)
		{
			this.Name = name;
			this.Hash = hash;
			this.Size = size;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000378C File Offset: 0x0000198C
		public string Hash { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003794 File Offset: 0x00001994
		public string Name { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000379C File Offset: 0x0000199C
		public long Size { get; }
	}
}
