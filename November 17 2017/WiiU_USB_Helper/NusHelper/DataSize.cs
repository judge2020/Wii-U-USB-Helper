using System;

namespace NusHelper
{
	// Token: 0x02000020 RID: 32
	public struct DataSize : IComparable<DataSize>
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00008498 File Offset: 0x00006698
		public DataSize(ulong sz)
		{
			this.TotalBytes = sz;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000084AC File Offset: 0x000066AC
		public ulong TotalBytes { get; }

		// Token: 0x0600009D RID: 157 RVA: 0x000084C0 File Offset: 0x000066C0
		public static explicit operator DataSize(string number)
		{
			return new DataSize(ulong.Parse(number));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000084D8 File Offset: 0x000066D8
		public static DataSize operator -(DataSize size1, DataSize size2)
		{
			if (size2.TotalBytes >= size1.TotalBytes)
			{
				return new DataSize(0UL);
			}
			return new DataSize(size1.TotalBytes - size2.TotalBytes);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008514 File Offset: 0x00006714
		public static bool operator !=(DataSize size1, ulong size2)
		{
			return size1.TotalBytes != size2;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008530 File Offset: 0x00006730
		public static bool operator !=(DataSize size1, DataSize size2)
		{
			return size1.TotalBytes != size2.TotalBytes;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008550 File Offset: 0x00006750
		public static DataSize operator +(DataSize size, ulong bt)
		{
			return new DataSize(size.TotalBytes + bt);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000856C File Offset: 0x0000676C
		public static DataSize operator +(DataSize size, DataSize bt)
		{
			return new DataSize(size.TotalBytes + bt.TotalBytes);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008590 File Offset: 0x00006790
		public static DataSize operator +(ulong bt, DataSize size)
		{
			return new DataSize(size.TotalBytes + bt);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000085AC File Offset: 0x000067AC
		public static bool operator ==(DataSize size1, DataSize size2)
		{
			return size1.TotalBytes == size2.TotalBytes;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000085CC File Offset: 0x000067CC
		public static bool operator ==(DataSize size1, ulong size2)
		{
			return size1.TotalBytes == size2;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000085E4 File Offset: 0x000067E4
		public int CompareTo(DataSize other)
		{
			return this.TotalBytes.CompareTo(other.TotalBytes);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008608 File Offset: 0x00006808
		public DataSize Diff(DataSize size2)
		{
			return new DataSize((ulong)Math.Abs((long)(this.TotalBytes - size2.TotalBytes)));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008630 File Offset: 0x00006830
		public override string ToString()
		{
			if (this.TotalBytes < Math.Pow(10.0, 6.0))
			{
				return (this.TotalBytes / Math.Pow(10.0, 3.0)).ToString("F3") + " KB";
			}
			if (this.TotalBytes < Math.Pow(10.0, 9.0))
			{
				return (this.TotalBytes / Math.Pow(10.0, 6.0)).ToString("F3") + " MB";
			}
			if (this.TotalBytes < Math.Pow(10.0, 12.0))
			{
				return (this.TotalBytes / Math.Pow(10.0, 9.0)).ToString("F3") + " GB";
			}
			return (this.TotalBytes / Math.Pow(10.0, 12.0)).ToString("F3") + " TB";
		}
	}
}
