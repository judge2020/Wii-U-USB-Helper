using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace A
{
	// Token: 0x0200007E RID: 126
	public sealed class c6e4901274630d05cbbf6924f95d2edfb : c105c88e162b3faac8e1371ca90f921c5
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00017DD4 File Offset: 0x00015FD4
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00017DE8 File Offset: 0x00015FE8
		public Image Image { get; set; }

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600039A RID: 922 RVA: 0x00017DFC File Offset: 0x00015FFC
		// (remove) Token: 0x0600039B RID: 923 RVA: 0x00017E4C File Offset: 0x0001604C
		public event EventHandler<c797ec1388c1af11408ef86282cc1652a> cfa21bb8cd0447cf1c81dd418c08ca898
		{
			[CompilerGenerated]
			add
			{
				EventHandler<c797ec1388c1af11408ef86282cc1652a> eventHandler = this.cfa21bb8cd0447cf1c81dd418c08ca898;
				EventHandler<c797ec1388c1af11408ef86282cc1652a> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c797ec1388c1af11408ef86282cc1652a> value2 = ce192df8d19c4cb5418e5355903df0836.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c797ec1388c1af11408ef86282cc1652a>>(ref this.cfa21bb8cd0447cf1c81dd418c08ca898, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6e4901274630d05cbbf6924f95d2edfb.add_cfa21bb8cd0447cf1c81dd418c08ca898(EventHandler<c797ec1388c1af11408ef86282cc1652a>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<c797ec1388c1af11408ef86282cc1652a> eventHandler = this.cfa21bb8cd0447cf1c81dd418c08ca898;
				EventHandler<c797ec1388c1af11408ef86282cc1652a> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<c797ec1388c1af11408ef86282cc1652a> value2 = ce192df8d19c4cb5418e5355903df0836.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<c797ec1388c1af11408ef86282cc1652a>>(ref this.cfa21bb8cd0447cf1c81dd418c08ca898, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6e4901274630d05cbbf6924f95d2edfb.remove_cfa21bb8cd0447cf1c81dd418c08ca898(EventHandler<c797ec1388c1af11408ef86282cc1652a>)).MethodHandle;
				}
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00017E9C File Offset: 0x0001609C
		public void cbc2757b15fa364cd3daff84375688dfe(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7, TimeSpan c4d599a5909490aa7a123c02887140b4d)
		{
			base.cec41dce7fd7f95a99bbdd1673e6fd941 += this.c067a54a01ebe9cb504eab35ec2a54ec6;
			base.c142384818e91b48255429b5c59e8b8c7(cbc47e314a0f1d7d5f1d07b50ba2bb8c7, c4d599a5909490aa7a123c02887140b4d);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00017EC4 File Offset: 0x000160C4
		public override void c142384818e91b48255429b5c59e8b8c7(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7, TimeSpan c4d599a5909490aa7a123c02887140b4d)
		{
			base.cec41dce7fd7f95a99bbdd1673e6fd941 += this.c09ee17c32cacaa30563f239eb95795e3;
			base.c142384818e91b48255429b5c59e8b8c7(cbc47e314a0f1d7d5f1d07b50ba2bb8c7, c4d599a5909490aa7a123c02887140b4d);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00017EEC File Offset: 0x000160EC
		private void c09ee17c32cacaa30563f239eb95795e3(object cd7b28952603b35a45c555982e677363a, ca4dbe4e221059deb4f3786c044e4860a cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.cec41dce7fd7f95a99bbdd1673e6fd941 -= this.c09ee17c32cacaa30563f239eb95795e3;
			try
			{
				this.Image = Image.FromStream(new MemoryStream(cdf15457ee4816989343b6e6e96dd4cfe.caeffd3849144328b734943407be65764));
			}
			catch (Exception)
			{
				if (File.Exists(cdf15457ee4816989343b6e6e96dd4cfe.c644292fda0733c5b8003747ebe56e175))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c6e4901274630d05cbbf6924f95d2edfb.c09ee17c32cacaa30563f239eb95795e3(object, ca4dbe4e221059deb4f3786c044e4860a)).MethodHandle;
					}
					File.Delete(cdf15457ee4816989343b6e6e96dd4cfe.c644292fda0733c5b8003747ebe56e175);
				}
				return;
			}
			EventHandler<c797ec1388c1af11408ef86282cc1652a> eventHandler = this.cfa21bb8cd0447cf1c81dd418c08ca898;
			if (eventHandler == null)
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
				return;
			}
			eventHandler(this, new c797ec1388c1af11408ef86282cc1652a(this.Image));
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00017F90 File Offset: 0x00016190
		private void c067a54a01ebe9cb504eab35ec2a54ec6(object cd7b28952603b35a45c555982e677363a, ca4dbe4e221059deb4f3786c044e4860a cdf15457ee4816989343b6e6e96dd4cfe)
		{
			base.cec41dce7fd7f95a99bbdd1673e6fd941 -= this.c067a54a01ebe9cb504eab35ec2a54ec6;
			if (!cdf15457ee4816989343b6e6e96dd4cfe.cde6cec2ed396ff4d00b14d7ad85a2b09)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6e4901274630d05cbbf6924f95d2edfb.c067a54a01ebe9cb504eab35ec2a54ec6(object, ca4dbe4e221059deb4f3786c044e4860a)).MethodHandle;
				}
				MemoryStream memoryStream = new MemoryStream(cdf15457ee4816989343b6e6e96dd4cfe.caeffd3849144328b734943407be65764);
				try
				{
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						new Bitmap(Image.FromStream(memoryStream), new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6172), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6176))).Save(memoryStream2, ImageFormat.Png);
						File.WriteAllBytes(cdf15457ee4816989343b6e6e96dd4cfe.c644292fda0733c5b8003747ebe56e175, memoryStream2.ToArray());
						this.Image = Image.FromStream(memoryStream2);
						goto IL_EB;
					}
					catch (Exception)
					{
						if (File.Exists(cdf15457ee4816989343b6e6e96dd4cfe.c644292fda0733c5b8003747ebe56e175))
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
							File.Delete(cdf15457ee4816989343b6e6e96dd4cfe.c644292fda0733c5b8003747ebe56e175);
						}
						return;
					}
				}
				finally
				{
					if (memoryStream != null)
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
						((IDisposable)memoryStream).Dispose();
					}
				}
			}
			this.Image = Image.FromStream(new MemoryStream(cdf15457ee4816989343b6e6e96dd4cfe.caeffd3849144328b734943407be65764));
			IL_EB:
			EventHandler<c797ec1388c1af11408ef86282cc1652a> eventHandler = this.cfa21bb8cd0447cf1c81dd418c08ca898;
			if (eventHandler == null)
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
				return;
			}
			eventHandler(this, new c797ec1388c1af11408ef86282cc1652a(this.Image));
		}

		// Token: 0x04000237 RID: 567
		[CompilerGenerated]
		private Image c20e87170712534725e273aa255be1566;
	}
}
