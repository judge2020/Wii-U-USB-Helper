using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using NusHelper;
using Telerik.WinControls;

namespace A
{
	// Token: 0x0200008B RID: 139
	public class c36ae571439d6691c1084666cd8f1610a : c4c1cf20119750bfee2a0bb499f990883
	{
		// Token: 0x06000442 RID: 1090 RVA: 0x0001C010 File Offset: 0x0001A210
		public c36ae571439d6691c1084666cd8f1610a(c5409344e1c2b74fa8c9a4d620ccb8d48 ce6591d75ff64e43faf8c563a2a657abe) : base(ce6591d75ff64e43faf8c563a2a657abe)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001C048 File Offset: 0x0001A248
		public override string[] cb36ab33fd8ccca41b540a9363d46e846
		{
			get
			{
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6916));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6920)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12533);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6924)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12574);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6928)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12609);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6932)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12644);
				return array;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		public override bool c04e04f3d41ac5cbe5e7491c6164e7158(string cbd32cc27f8c4c9bc43284da3fafd5979)
		{
			if (this.c69381d6014b68f5c61f850a282a93cdf(cbd32cc27f8c4c9bc43284da3fafd5979))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.c04e04f3d41ac5cbe5e7491c6164e7158(string)).MethodHandle;
				}
				this.c1730bce84be4248aa0a7d8cbed088f90 = cbd32cc27f8c4c9bc43284da3fafd5979;
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6936) != 0;
			}
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12677));
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6940) != 0;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001C124 File Offset: 0x0001A324
		public override int cbcb9d6cee1025057c982e8c00b728c3c()
		{
			if (!File.Exists(this.c1730bce84be4248aa0a7d8cbed088f90))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.cbcb9d6cee1025057c982e8c00b728c3c()).MethodHandle;
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6944);
			}
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6948);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001C168 File Offset: 0x0001A368
		public override void c25dba10ffdbe2b55fe4809bdf44094f2()
		{
			base.c25dba10ffdbe2b55fe4809bdf44094f2();
			Task.Run(new Action(this.ce05dd565ff46ec4e1a9946beb5b263fa));
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001C190 File Offset: 0x0001A390
		public bool c69381d6014b68f5c61f850a282a93cdf(string cbd32cc27f8c4c9bc43284da3fafd5979)
		{
			bool result;
			try
			{
				if (this.cb0241b42721411c8d204f578074bdc2f(File.ReadAllBytes(cbd32cc27f8c4c9bc43284da3fafd5979), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6952)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.c69381d6014b68f5c61f850a282a93cdf(string)).MethodHandle;
					}
					result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6956) != 0);
				}
				else
				{
					result = this.cb0241b42721411c8d204f578074bdc2f(File.ReadAllBytes(cbd32cc27f8c4c9bc43284da3fafd5979), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6960));
				}
			}
			catch
			{
				result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6964) != 0);
			}
			return result;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0001C218 File Offset: 0x0001A418
		private byte[] c5cefcda1fd7acd974105722d4f686c7b
		{
			get
			{
				if (this.c457d6ed97a0c9a4c99e2fe21958eb2c2 == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.get_c5cefcda1fd7acd974105722d4f686c7b()).MethodHandle;
					}
					this.c457d6ed97a0c9a4c99e2fe21958eb2c2 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(base.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13497)));
				}
				return this.c457d6ed97a0c9a4c99e2fe21958eb2c2;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001C268 File Offset: 0x0001A468
		private c6114b34ba4893a53ebb4b599e0e2e3fc c989f82e0467c3cafc25f71c46f15154b
		{
			get
			{
				if (this.ca1e9e6655732581772cff4774161a1eb == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.get_c989f82e0467c3cafc25f71c46f15154b()).MethodHandle;
					}
					this.ca1e9e6655732581772cff4774161a1eb = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[new TitleId(base.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12949)))];
				}
				return this.ca1e9e6655732581772cff4774161a1eb;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0001C2C4 File Offset: 0x0001A4C4
		public override string cf96188d52085ca12da85c38a0cbd94c5
		{
			get
			{
				return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12966);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001C2E0 File Offset: 0x0001A4E0
		public override string c41ca02dc0bc33eb67cf1568c3466b35e
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001C2F4 File Offset: 0x0001A4F4
		private void c7db69138c243dba08484b02063f5e992()
		{
			string text = Path.Combine(base.WorkPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13080));
			Directory.CreateDirectory(text);
			this.c989f82e0467c3cafc25f71c46f15154b.cf08369cbb3a626a84f05ff893b78fed7(text, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6968) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6972) != 0, null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6976) != 0);
			string c46eff30db82531897d1b8cc73656d8ee = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13506));
			string c46eff30db82531897d1b8cc73656d8ee2 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13529));
			string text2 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13560));
			string text3 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13577));
			string sourceFileName = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13612));
			IEnumerable<FileInfo> files = new DirectoryInfo(Path.Combine(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13647))).GetFiles();
			Func<FileInfo, bool> predicate;
			if ((predicate = c36ae571439d6691c1084666cd8f1610a.<>c.cd8e50864b3aa372dca7592087c39406f) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.c7db69138c243dba08484b02063f5e992()).MethodHandle;
				}
				predicate = (c36ae571439d6691c1084666cd8f1610a.<>c.cd8e50864b3aa372dca7592087c39406f = new Func<FileInfo, bool>(c36ae571439d6691c1084666cd8f1610a.<>c.cdfab1996eb8651828de2a4469aa3481e.cb3b368fa9026c2e3e7db7cb33103b13f));
			}
			string fullName = files.First(predicate).FullName;
			c4c1cf20119750bfee2a0bb499f990883.c1add8d63ef8501f3f59df9167bc45133(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13126), base.WorkPath);
			Thread thread = base.cc736a37572c9ecd084d9e909d97c23c4();
			base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6980));
			c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(c46eff30db82531897d1b8cc73656d8ee, base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13656), fullName, text2));
			c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(c46eff30db82531897d1b8cc73656d8ee2, base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13683), text2, this.c1730bce84be4248aa0a7d8cbed088f90, text3));
			base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6984));
			this.cbacf11f12136a6469db0cdd17faeb42c(text3);
			File.Delete(fullName);
			File.Move(sourceFileName, fullName);
			thread.Join();
			base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6988));
			this.ce2698f6d61a96883244b8453f3f33a3c();
			base.c232fcc851b0115da370b4acb1c9d0e05();
			base.ca1394714ad264b382e2c09206f569348();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0001C4F4 File Offset: 0x0001A6F4
		private bool cb0241b42721411c8d204f578074bdc2f(byte[] cbd32cc27f8c4c9bc43284da3fafd5979, int c6d90c75477d966c1350c18dcdfa11588 = 0)
		{
			SHA1 sha = SHA1.Create();
			bool result;
			try
			{
				sha.TransformFinalBlock(cbd32cc27f8c4c9bc43284da3fafd5979, c6d90c75477d966c1350c18dcdfa11588, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cbd32cc27f8c4c9bc43284da3fafd5979) - c6d90c75477d966c1350c18dcdfa11588);
				result = cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(this.c5cefcda1fd7acd974105722d4f686c7b, sha.Hash);
			}
			finally
			{
				if (sha != null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.cb0241b42721411c8d204f578074bdc2f(byte[], int)).MethodHandle;
					}
					((IDisposable)sha).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001C568 File Offset: 0x0001A768
		private void cbacf11f12136a6469db0cdd17faeb42c(string cad48e7cec482eb202b35baba9979de2f)
		{
			string text = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13235));
			new c866035f717c1c145e269422264e8f519().c0ddecd1ce433b283de66e0c68db8aa47(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13258), text, (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6992)), (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6996), null, null, null, (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7000), (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7004));
			c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(text, base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13359), cad48e7cec482eb202b35baba9979de2f), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13404), base.WorkPath);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001C604 File Offset: 0x0001A804
		protected override void ce2698f6d61a96883244b8453f3f33a3c()
		{
			base.c50e1e386dda5532ec9d5a526d6221de1(c933d8f390d7a245458355cef338c6754.cd24593c859565ebb8c9faabbc5c75bef(this.c989f82e0467c3cafc25f71c46f15154b));
			c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(c4c1cf20119750bfee2a0bb499f990883.c7b0be042b6d2a0b606dd5328403bf5e1, base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13423), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13470)));
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001C65C File Offset: 0x0001A85C
		[CompilerGenerated]
		private void ce05dd565ff46ec4e1a9946beb5b263fa()
		{
			try
			{
				base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7008));
				if (this.c989f82e0467c3cafc25f71c46f15154b.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7012))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c36ae571439d6691c1084666cd8f1610a.ce05dd565ff46ec4e1a9946beb5b263fa()).MethodHandle;
					}
					cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = new cdb02a77cadec7790d5c7c433ab736a12(null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7016) != 0);
					cdb02a77cadec7790d5c7c433ab736a.cdcc2c8329c5e63d415472bd3bd0a99aa += this.cbceeeb9a89c7499ff891c694a3ed811a;
					c6114b34ba4893a53ebb4b599e0e2e3fc[] array = c4ac7b1ff726812ebb6cc8b1485582880.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7020));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7024)] = this.c989f82e0467c3cafc25f71c46f15154b;
					cdb02a77cadec7790d5c7c433ab736a.cd5841496c51e4ccda38bf5370111aeaa(new List<c6114b34ba4893a53ebb4b599e0e2e3fc>(array), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7028), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7032));
				}
				else
				{
					this.c7db69138c243dba08484b02063f5e992();
				}
			}
			catch (Exception c08b391577522100e1046cacdb2283fb)
			{
				base.c3475132295323f8a31a663ad2110a7d2(c08b391577522100e1046cacdb2283fb);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001C734 File Offset: 0x0001A934
		[CompilerGenerated]
		private void cbceeeb9a89c7499ff891c694a3ed811a(object cb0d7b0b893a41a39e281ddc32fc698bd, c8e60ceced0ce323f661e853233d10ec2 cdf15457ee4816989343b6e6e96dd4cfe)
		{
			this.c7db69138c243dba08484b02063f5e992();
		}

		// Token: 0x04000269 RID: 617
		private byte[] c457d6ed97a0c9a4c99e2fe21958eb2c2;

		// Token: 0x0400026A RID: 618
		private string c1730bce84be4248aa0a7d8cbed088f90;

		// Token: 0x0400026B RID: 619
		private c6114b34ba4893a53ebb4b599e0e2e3fc ca1e9e6655732581772cff4774161a1eb;

		// Token: 0x0400026C RID: 620
		private string ccbacb060829ce225c43ea2b3461d17c7 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13728);

		// Token: 0x0400026D RID: 621
		private string c83ab65c8e017e71af1591200c68b13e0 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(14782);
	}
}
