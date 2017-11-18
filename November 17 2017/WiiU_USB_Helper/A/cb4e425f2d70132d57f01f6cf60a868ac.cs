using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alphaleonis.Win32.Filesystem;
using Newtonsoft.Json;
using NusHelper;
using Telerik.WinControls;

namespace A
{
	// Token: 0x0200008C RID: 140
	public class cb4e425f2d70132d57f01f6cf60a868ac : c4c1cf20119750bfee2a0bb499f990883
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x0001C748 File Offset: 0x0001A948
		public cb4e425f2d70132d57f01f6cf60a868ac(c5409344e1c2b74fa8c9a4d620ccb8d48 ce6591d75ff64e43faf8c563a2a657abe) : base(ce6591d75ff64e43faf8c563a2a657abe)
		{
			try
			{
				base.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39212));
				base.RomCount = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7600);
			}
			catch
			{
			}
			try
			{
				base.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39229));
				this.CompressIso = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7604) != 0);
			}
			catch
			{
			}
			if (ce6591d75ff64e43faf8c563a2a657abe.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7608))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac..ctor(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				base.UseGamepad = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7612) != 0);
				try
				{
					base.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39252));
					base.UseGamepad = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7616) != 0);
				}
				catch
				{
				}
				try
				{
					base.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39267));
					this.PatchWifi = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7620) != 0);
				}
				catch
				{
				}
				try
				{
					string text = base.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39280));
					string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7624));
					array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7628)] = Environment.NewLine;
					string[] array2 = text.Split(array, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7632));
					this.PatchGame = new TitleId(array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7636)]);
					this.PatchSize = array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7640)];
				}
				catch
				{
				}
			}
			this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(base.RomCount);
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0001C920 File Offset: 0x0001AB20
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0001C934 File Offset: 0x0001AB34
		public bool CompressIso { get; set; } = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7596) != 0;

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0001C948 File Offset: 0x0001AB48
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0001C95C File Offset: 0x0001AB5C
		public bool PatchWifi { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0001C970 File Offset: 0x0001AB70
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0001C984 File Offset: 0x0001AB84
		public bool Force43 { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0001C998 File Offset: 0x0001AB98
		public override string[] cb36ab33fd8ccca41b540a9363d46e846
		{
			get
			{
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7036));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7040)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12533);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7044)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(34490);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7048)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(34525);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7052)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12644);
				return array;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001CA18 File Offset: 0x0001AC18
		public TitleId PatchGame { get; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		public string PatchSize { get; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0001CA40 File Offset: 0x0001AC40
		public override string cf96188d52085ca12da85c38a0cbd94c5
		{
			get
			{
				return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(34562);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0001CA5C File Offset: 0x0001AC5C
		public override string c41ca02dc0bc33eb67cf1568c3466b35e
		{
			get
			{
				if (base.ToInject.Platform != (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7056))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.get_c41ca02dc0bc33eb67cf1568c3466b35e()).MethodHandle;
					}
					return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(34569);
				}
				return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(34688);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
		public bool c2b816dcbf8a2459e537fcf15305d3146()
		{
			if (this.PatchGame == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.c2b816dcbf8a2459e537fcf15305d3146()).MethodHandle;
				}
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(34759));
			}
			c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[this.PatchGame];
			if (RadMessageBox.Show(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(34814), c6114b34ba4893a53ebb4b599e0e2e3fc.Name, this.PatchSize), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35270), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7060)) != (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7064))
			{
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7176) != 0;
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
			cb4e425f2d70132d57f01f6cf60a868ac.c1d2cf2bf6cbed901d896cd48f20b8d62 c1d2cf2bf6cbed901d896cd48f20b8d = new cb4e425f2d70132d57f01f6cf60a868ac.c1d2cf2bf6cbed901d896cd48f20b8d62();
			if (c6114b34ba4893a53ebb4b599e0e2e3fc.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7068))
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
				cb4e425f2d70132d57f01f6cf60a868ac.ccca08fdb093a512c6020c82e185be026 ccca08fdb093a512c6020c82e185be = new cb4e425f2d70132d57f01f6cf60a868ac.ccca08fdb093a512c6020c82e185be026();
				cdb02a77cadec7790d5c7c433ab736a12 cdb02a77cadec7790d5c7c433ab736a = new cdb02a77cadec7790d5c7c433ab736a12(null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7072) != 0);
				ccca08fdb093a512c6020c82e185be.c7cf943cf1b668441bf1566e9acf72d35 = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35287), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7076) != 0);
				cdb02a77cadec7790d5c7c433ab736a.c2484bd018cc259ebf6256e671a3c8276 += ccca08fdb093a512c6020c82e185be.cd6e50a5f8af76402cd9065d465f4f3a2;
				cdb02a77cadec7790d5c7c433ab736a.cdcc2c8329c5e63d415472bd3bd0a99aa += ccca08fdb093a512c6020c82e185be.cce5e5a137084a5712ca41882576d9c1f;
				c6114b34ba4893a53ebb4b599e0e2e3fc[] array = c4ac7b1ff726812ebb6cc8b1485582880.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7080));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7084)] = c6114b34ba4893a53ebb4b599e0e2e3fc;
				cdb02a77cadec7790d5c7c433ab736a.cd5841496c51e4ccda38bf5370111aeaa(array.ToList<c6114b34ba4893a53ebb4b599e0e2e3fc>(), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7088), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7092));
				ccca08fdb093a512c6020c82e185be.c7cf943cf1b668441bf1566e9acf72d35.ShowDialog();
			}
			c92405b00606e9a36e1850edbf7e174fe c92405b00606e9a36e1850edbf7e174fe = new c92405b00606e9a36e1850edbf7e174fe(c6114b34ba4893a53ebb4b599e0e2e3fc, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7096) != 0);
			c92405b00606e9a36e1850edbf7e174fe.ce08d3fcff1ec6badc424f2432fc6e909();
			string text = c92405b00606e9a36e1850edbf7e174fe.c010f80182206bd1b4a523f2e99f7657a();
			c1d2cf2bf6cbed901d896cd48f20b8d.ccb074d6b874e810ff5ea2528e5315eb4 = new DirectoryInfo(text).Parent.FullName;
			cb4e425f2d70132d57f01f6cf60a868ac.c1d2cf2bf6cbed901d896cd48f20b8d62 c1d2cf2bf6cbed901d896cd48f20b8d2 = c1d2cf2bf6cbed901d896cd48f20b8d;
			string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7100));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7104)] = c1d2cf2bf6cbed901d896cd48f20b8d.ccb074d6b874e810ff5ea2528e5315eb4;
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7108)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35366);
			c1d2cf2bf6cbed901d896cd48f20b8d2.ca1d8ec0d7d355334535e412c1ff4c2b7 = Path.Combine(array2);
			cb4e425f2d70132d57f01f6cf60a868ac.c1d2cf2bf6cbed901d896cd48f20b8d62 c1d2cf2bf6cbed901d896cd48f20b8d3 = c1d2cf2bf6cbed901d896cd48f20b8d;
			string[] array3 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7112));
			array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7116)] = c1d2cf2bf6cbed901d896cd48f20b8d.ccb074d6b874e810ff5ea2528e5315eb4;
			array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7120)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35389);
			c1d2cf2bf6cbed901d896cd48f20b8d3.c5a0274dabc49615bccaeb09a9b7df690 = Path.Combine(array3);
			c92405b00606e9a36e1850edbf7e174fe.c54f221133eb526d693ab1f91ea0d82db(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7124) != 0);
			string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35408);
			Action c594146923b42642ebf4bf2a5cd = new Action(c1d2cf2bf6cbed901d896cd48f20b8d.ced20de1c6b3d8c7d814b14ae5dc90a87);
			Action<Exception> c62f902d27574ffccbd029fee23622bc;
			if ((c62f902d27574ffccbd029fee23622bc = cb4e425f2d70132d57f01f6cf60a868ac.<>c.cfb92118fe44960bbfbf7290592f520bd) == null)
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
				c62f902d27574ffccbd029fee23622bc = (cb4e425f2d70132d57f01f6cf60a868ac.<>c.cfb92118fe44960bbfbf7290592f520bd = new Action<Exception>(cb4e425f2d70132d57f01f6cf60a868ac.<>c.cdfab1996eb8651828de2a4469aa3481e.c096325c2aa7e109a8933ecd554c3d582));
			}
			new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
			c1d2cf2bf6cbed901d896cd48f20b8d.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35479), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7128) != 0);
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += c1d2cf2bf6cbed901d896cd48f20b8d.c2aa8a248120aa19a8ba02abac7cabd5e;
			webClient.DownloadFileCompleted += c1d2cf2bf6cbed901d896cd48f20b8d.c3d239786daef2ecf50916a72c319c897;
			webClient.DownloadFileAsync(new Uri(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35574), base.ToInject.ProductId)), c1d2cf2bf6cbed901d896cd48f20b8d.c5a0274dabc49615bccaeb09a9b7df690);
			c1d2cf2bf6cbed901d896cd48f20b8d.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
			string cfeefea196000bed18adf05bf7727db2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35695);
			Action c594146923b42642ebf4bf2a5cd2 = new Action(c1d2cf2bf6cbed901d896cd48f20b8d.c68bb99626c04286ccfd18ffbfee1b094);
			Action<Exception> c62f902d27574ffccbd029fee23622bc2;
			if ((c62f902d27574ffccbd029fee23622bc2 = cb4e425f2d70132d57f01f6cf60a868ac.<>c.cff4258a00542faf2ccc71baf1854ed53) == null)
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
				c62f902d27574ffccbd029fee23622bc2 = (cb4e425f2d70132d57f01f6cf60a868ac.<>c.cff4258a00542faf2ccc71baf1854ed53 = new Action<Exception>(cb4e425f2d70132d57f01f6cf60a868ac.<>c.cdfab1996eb8651828de2a4469aa3481e.c9bbeb1fd90396c3be3b3c37bc1780acf));
			}
			new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db2, c594146923b42642ebf4bf2a5cd2, c62f902d27574ffccbd029fee23622bc2);
			File.Delete(c1d2cf2bf6cbed901d896cd48f20b8d.c5a0274dabc49615bccaeb09a9b7df690);
			Directory.Delete(c1d2cf2bf6cbed901d896cd48f20b8d.ca1d8ec0d7d355334535e412c1ff4c2b7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7132) != 0);
			string[] array4 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7136));
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7140)] = c1d2cf2bf6cbed901d896cd48f20b8d.ccb074d6b874e810ff5ea2528e5315eb4;
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7144)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35764);
			if (!this.c04e04f3d41ac5cbe5e7491c6164e7158(new DirectoryInfo(Path.Combine(array4)).GetFiles()[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7148)].FullName))
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
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35783));
			}
			new c3e89d2b199cb88db040c1d3093faf8e0(this).ShowDialog();
			c92405b00606e9a36e1850edbf7e174fe.c54f221133eb526d693ab1f91ea0d82db(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7152) != 0);
			string[] array5 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7156));
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7160)] = c1d2cf2bf6cbed901d896cd48f20b8d.ccb074d6b874e810ff5ea2528e5315eb4;
			array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7164)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13080);
			Directory.Delete(Path.Combine(array5), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7168) != 0);
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7172) != 0;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001CF4C File Offset: 0x0001B14C
		private void c7c9f1f3356a18c9c83798b35c38fb67a(string cad48e7cec482eb202b35baba9979de2f, string c2e59f973437ea79c9b95a2c0ce2d33db)
		{
			c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35852)), new DirectoryInfo(cad48e7cec482eb202b35baba9979de2f).Parent.FullName, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35867), cad48e7cec482eb202b35baba9979de2f, c2e59f973437ea79c9b95a2c0ce2d33db));
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001CF9C File Offset: 0x0001B19C
		private static string ceadf66f6114574c64c843b4c3d417086(string c9ee5d0e059de6242d29e3c2faa703baf)
		{
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7180));
			FileStream fileStream = File.OpenRead(c9ee5d0e059de6242d29e3c2faa703baf);
			string @string;
			try
			{
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Path.GetExtension(c9ee5d0e059de6242d29e3c2faa703baf), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35898)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.ceadf66f6114574c64c843b4c3d417086(string)).MethodHandle;
					}
					fileStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7184), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7188));
				}
				else if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Path.GetExtension(c9ee5d0e059de6242d29e3c2faa703baf), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35909)))
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
					fileStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7192), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7196));
				}
				fileStream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7200), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7204));
				@string = Encoding.ASCII.GetString(array);
			}
			finally
			{
				if (fileStream != null)
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
					((IDisposable)fileStream).Dispose();
				}
			}
			return @string;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
		private static int c1fd77194af01e1fa4b76f09139d156e9(string c9ee5d0e059de6242d29e3c2faa703baf)
		{
			c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7208));
			BinaryReader binaryReader = new BinaryReader(File.OpenRead(c9ee5d0e059de6242d29e3c2faa703baf));
			int result;
			try
			{
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Path.GetExtension(c9ee5d0e059de6242d29e3c2faa703baf), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35898)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.c1fd77194af01e1fa4b76f09139d156e9(string)).MethodHandle;
					}
					binaryReader.BaseStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7212), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7216));
				}
				else if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Path.GetExtension(c9ee5d0e059de6242d29e3c2faa703baf), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35909)))
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
					binaryReader.BaseStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7220), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7224));
				}
				binaryReader.BaseStream.Seek((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7228), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7232));
				result = (int)binaryReader.ReadByte();
			}
			finally
			{
				if (binaryReader != null)
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
					((IDisposable)binaryReader).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
		private int cbc9b899a3ab270adcf84e052112cc806(string c9ee5d0e059de6242d29e3c2faa703baf)
		{
			int result;
			try
			{
				string item = cb4e425f2d70132d57f01f6cf60a868ac.ceadf66f6114574c64c843b4c3d417086(c9ee5d0e059de6242d29e3c2faa703baf);
				if (base.c81daca9f1ced3fd535f021403efc61e1.Contains(item))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.cbc9b899a3ab270adcf84e052112cc806(string)).MethodHandle;
					}
					result = cb4e425f2d70132d57f01f6cf60a868ac.c1fd77194af01e1fa4b76f09139d156e9(c9ee5d0e059de6242d29e3c2faa703baf);
				}
				else
				{
					result = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7236);
				}
			}
			catch
			{
				result = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7240);
			}
			return result;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001D24C File Offset: 0x0001B44C
		private static void c98385f0f3f095d751af565718987df10(DriveInfo cb33decdc9e5663a9827f5479abd1bd77)
		{
			string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7244));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7248)] = cb33decdc9e5663a9827f5479abd1bd77.Name;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7252)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35920);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7256)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35929);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7260)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35950);
			string text = Path.Combine(array);
			bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7264) != 0;
			WebClient webClient = new WebClient();
			webClient.Headers.Add(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35967), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35988));
			try
			{
				if (!File.Exists(text))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.c98385f0f3f095d751af565718987df10(DriveInfo)).MethodHandle;
					}
					flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7268) != 0);
				}
				else
				{
					byte[] c20fab7e86d17e97f35dc746ef5fadd = c2db560c30ba5b8be65c4f33abfcc27de.cab55a050df275722227783d6686266c9;
					byte[] array2 = File.ReadAllBytes(text);
					byte[] bytes = Encoding.ASCII.GetBytes(c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36130), ((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array2)).ToString(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36141)));
					byte[] array3 = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array2) + (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(bytes));
					Buffer.BlockCopy(bytes, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7272), array3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7276), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(bytes));
					Buffer.BlockCopy(array2, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7280), array3, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(bytes), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array2));
					SHA1 sha = SHA1.Create();
					try
					{
						c20fab7e86d17e97f35dc746ef5fadd = sha.ComputeHash(array3);
					}
					finally
					{
						if (sha != null)
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
							((IDisposable)sha).Dispose();
						}
					}
					IEnumerable<c869260ca940fbfbf13d160ec468e0bb2> source = JsonConvert.DeserializeObject<c869260ca940fbfbf13d160ec468e0bb2[]>(webClient.DownloadString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36144)));
					Func<c869260ca940fbfbf13d160ec468e0bb2, bool> predicate;
					if ((predicate = cb4e425f2d70132d57f01f6cf60a868ac.<>c.c1f09dcdbb820f8556a072fe9c01d0440) == null)
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
						predicate = (cb4e425f2d70132d57f01f6cf60a868ac.<>c.c1f09dcdbb820f8556a072fe9c01d0440 = new Func<c869260ca940fbfbf13d160ec468e0bb2, bool>(cb4e425f2d70132d57f01f6cf60a868ac.<>c.cdfab1996eb8651828de2a4469aa3481e.cf503eee8b20c1a41074c24c27d29ba60));
					}
					byte[] c6f8140eb9b80b7c7ef08f7739ee3e6fc = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(source.First(predicate).sha);
					flag = ((cd4880843d42f3dd634ca35c8e909b573.c8518de460ad2904ffe3ce945c07d2a14(c20fab7e86d17e97f35dc746ef5fadd, c6f8140eb9b80b7c7ef08f7739ee3e6fc) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7284));
				}
				if (flag)
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
					if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36269), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36605), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7288)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7292))
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
						cb4e425f2d70132d57f01f6cf60a868ac.c89dae8cdccd0587e25828a58231f8ad0(cb33decdc9e5663a9827f5479abd1bd77);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001D51C File Offset: 0x0001B71C
		public static void c2c5c44b01ed5eae110838fea588a0da6(DriveInfo c85fa46dee7ef9473f93c9fb47da11f4d)
		{
			string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7296));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7300)] = c85fa46dee7ef9473f93c9fb47da11f4d.Name;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7304)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35920);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7308)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35929);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7312)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35950);
			Path.Combine(array);
			string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7316));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7320)] = c85fa46dee7ef9473f93c9fb47da11f4d.Name;
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7324)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36626);
			string text = Path.Combine(array2);
			cb4e425f2d70132d57f01f6cf60a868ac.c98385f0f3f095d751af565718987df10(c85fa46dee7ef9473f93c9fb47da11f4d);
			if (!File.Exists(text))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.c2c5c44b01ed5eae110838fea588a0da6(DriveInfo)).MethodHandle;
				}
				if (RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36647), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36605), (MessageBoxButtons)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7328)) == (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7332))
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
					cb4e425f2d70132d57f01f6cf60a868ac.c555a48103171855abc9fafd6075bc76e(c85fa46dee7ef9473f93c9fb47da11f4d);
				}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001D64C File Offset: 0x0001B84C
		public static void c89dae8cdccd0587e25828a58231f8ad0(DriveInfo cb33decdc9e5663a9827f5479abd1bd77)
		{
			string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7336));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7340)] = cb33decdc9e5663a9827f5479abd1bd77.Name;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7344)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35920);
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7348)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35929);
			Directory.CreateDirectory(Path.Combine(array));
			string cbc47e314a0f1d7d5f1d07b50ba2bb8c = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36977);
			string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7352));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7356)] = cb33decdc9e5663a9827f5479abd1bd77.Name;
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7360)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35920);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7364)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35929);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7368)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(35950);
			cd4880843d42f3dd634ca35c8e909b573.c378cdebefe84e39cd3de9fc6cd731412(cbc47e314a0f1d7d5f1d07b50ba2bb8c, Path.Combine(array2));
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001D744 File Offset: 0x0001B944
		public static void c555a48103171855abc9fafd6075bc76e(DriveInfo cb33decdc9e5663a9827f5479abd1bd77)
		{
			cd4880843d42f3dd634ca35c8e909b573.c378cdebefe84e39cd3de9fc6cd731412(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37127), c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cb33decdc9e5663a9827f5479abd1bd77.Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(36626)));
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001D780 File Offset: 0x0001B980
		public override void c25dba10ffdbe2b55fe4809bdf44094f2()
		{
			base.c25dba10ffdbe2b55fe4809bdf44094f2();
			Task.Run(new Action(this.c07ea97514a70d0cee08d808cdbc1cdf7));
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
		public override bool c04e04f3d41ac5cbe5e7491c6164e7158(string cbd32cc27f8c4c9bc43284da3fafd5979)
		{
			int num = this.cbc9b899a3ab270adcf84e052112cc806(cbd32cc27f8c4c9bc43284da3fafd5979);
			if (num > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7372))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.c04e04f3d41ac5cbe5e7491c6164e7158(string)).MethodHandle;
				}
				this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[num] = cbd32cc27f8c4c9bc43284da3fafd5979;
				IEnumerable<string> source = this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a;
				Func<string, bool> predicate;
				if ((predicate = cb4e425f2d70132d57f01f6cf60a868ac.<>c.cbab2a190f9418fd5110efb372268b986) == null)
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
					predicate = (cb4e425f2d70132d57f01f6cf60a868ac.<>c.cbab2a190f9418fd5110efb372268b986 = new Func<string, bool>(cb4e425f2d70132d57f01f6cf60a868ac.<>c.cdfab1996eb8651828de2a4469aa3481e.cac8ec4877ec2d915312a98a7342b2409));
				}
				if (source.All(predicate))
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
					return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7376) != 0;
				}
			}
			else
			{
				RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37238));
			}
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7380) != 0;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001D854 File Offset: 0x0001BA54
		public override int cbcb9d6cee1025057c982e8c00b728c3c()
		{
			IEnumerable<string> source = this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a;
			Func<string, bool> predicate;
			if ((predicate = cb4e425f2d70132d57f01f6cf60a868ac.<>c.c5595a58b0ac80c36b7c7d25ea729498d) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.cbcb9d6cee1025057c982e8c00b728c3c()).MethodHandle;
				}
				predicate = (cb4e425f2d70132d57f01f6cf60a868ac.<>c.c5595a58b0ac80c36b7c7d25ea729498d = new Func<string, bool>(cb4e425f2d70132d57f01f6cf60a868ac.<>c.cdfab1996eb8651828de2a4469aa3481e.cca308e133ccaa55a67395a7d6ad90b8c));
			}
			return source.Count(predicate);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
		protected override void ce2698f6d61a96883244b8453f3f33a3c()
		{
			base.c50e1e386dda5532ec9d5a526d6221de1(c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[new TitleId(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37512))]);
			c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(c4c1cf20119750bfee2a0bb499f990883.c7b0be042b6d2a0b606dd5328403bf5e1, base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13423), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13470)));
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001D904 File Offset: 0x0001BB04
		[CompilerGenerated]
		private void c07ea97514a70d0cee08d808cdbc1cdf7()
		{
			try
			{
				string text;
				if (!this.Force43)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb4e425f2d70132d57f01f6cf60a868ac.c07ea97514a70d0cee08d808cdbc1cdf7()).MethodHandle;
					}
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37545);
				}
				else
				{
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37660);
				}
				string c80cb7b5c7ed3120dee341dfb2dca6ee = text;
				base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7384));
				string cbd0b99b96bcec2882811add3e39c28bb = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37779));
				string text2 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37842));
				string text3 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37893));
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7388));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7392)] = text3;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7396)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37914);
				string text4 = base.cfd54917ce0039040d91a9d1ac2e44c93(Path.Combine(array));
				string text5 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37953));
				string text6 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37984));
				string text7 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(37779));
				string text8 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38049));
				string text9 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38096));
				string text10 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38141));
				string text11 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38182));
				string text12 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38227));
				string text13 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11461));
				string text14 = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38262));
				string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7400));
				array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7404)] = text14;
				array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7408)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38287);
				array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7412)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38294);
				string c970b31fe4f307e557ac948e45eecc = base.cfd54917ce0039040d91a9d1ac2e44c93(Path.Combine(array2));
				string[] array3 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7416));
				array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7420)] = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38311));
				array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7424)] = base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38364));
				string[] array4 = array3;
				c4c1cf20119750bfee2a0bb499f990883.c1add8d63ef8501f3f59df9167bc45133(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38419), base.WorkPath);
				base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38540)));
				base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(text12);
				base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(text13);
				base.c18286cd58f49629141bc091b7af215fe(text11);
				base.c18286cd58f49629141bc091b7af215fe(text9);
				base.c18286cd58f49629141bc091b7af215fe(cbd0b99b96bcec2882811add3e39c28bb);
				base.c18286cd58f49629141bc091b7af215fe(text2);
				base.c18286cd58f49629141bc091b7af215fe(text6);
				Thread thread = base.cc736a37572c9ecd084d9e909d97c23c4();
				base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7428));
				if (this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a != null)
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
					if (base.ToInject.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7432))
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
						new c866035f717c1c145e269422264e8f519().c0ddecd1ce433b283de66e0c68db8aa47(c80cb7b5c7ed3120dee341dfb2dca6ee, c970b31fe4f307e557ac948e45eecc, (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7436)), (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7440), null, null, null, (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7444), (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7448));
						for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7452); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7456))
						{
							if (this.CompressIso)
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
								this.c7c9f1f3356a18c9c83798b35c38fb67a(this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[i], array4[i]);
							}
							else
							{
								File.Copy(this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[i], array4[i]);
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
						if (!File.Exists(array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7460)]))
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
							throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38565));
						}
					}
				}
				if (base.ToInject.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7464))
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
					if (this.PatchWifi)
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
						string[] array5 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7468));
						array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7472)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38674);
						array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7476)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38687);
						array5[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7480)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38700);
						if (array5.Contains(base.ToInject.ProductId))
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
							File.Copy(this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7484)], base.cfd54917ce0039040d91a9d1ac2e44c93(Path.GetFileName(this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7488)])));
							MemoryStream memoryStream = new MemoryStream(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38713)));
							try
							{
								ZipArchive zipArchive = new ZipArchive(memoryStream);
								try
								{
									zipArchive.c811907eb2abb4733dea06da0e2bcc423(base.WorkPath, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7492) != 0);
								}
								finally
								{
									if (zipArchive != null)
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
										((IDisposable)zipArchive).Dispose();
									}
								}
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
							c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38818), base.WorkPath);
							File.Delete(base.cfd54917ce0039040d91a9d1ac2e44c93(Path.GetFileName(this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7496)])));
							text4 = new DirectoryInfo(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38853))).GetFiles()[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7500)].FullName;
						}
						else
						{
							string[] array6 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7504));
							array6[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7508)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38884);
							array6[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7512)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38897);
							array6[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7516)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38910);
							if (array6.Contains(base.ToInject.ProductId))
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
								c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38923)), base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38952), this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7520)]));
								string[] array7 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7524));
								array7[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7528)] = text3;
								array7[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7532)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38963);
								text4 = Path.Combine(array7);
							}
							else
							{
								base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(text14);
								c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38986)), base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38952), this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7536)]));
								c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39009)), base.WorkPath);
								base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(text14);
								text4 = new DirectoryInfo(text3).GetFiles()[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7540)].FullName;
								c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38923)), base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38952), text4));
								base.c18286cd58f49629141bc091b7af215fe(text4);
								string[] array8 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7544));
								array8[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7548)] = text3;
								array8[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7552)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38963);
								text4 = Path.Combine(array8);
							}
						}
					}
					else
					{
						base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(text14);
						c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38986)), base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38952), this.c6bfbfe5d3f3d9f925ea047e0fa39cd9a[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7556)]));
						c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39009)), base.WorkPath);
						base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(text14);
						text4 = new DirectoryInfo(text3).GetFiles()[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7560)].FullName;
					}
				}
				else if (base.ToInject.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7564))
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
					c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39009)), base.WorkPath);
					base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(text14);
					text4 = new DirectoryInfo(text3).GetFiles()[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7568)].FullName;
				}
				base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7572));
				c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39026)), base.WorkPath, string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38952), text4));
				base.c18286cd58f49629141bc091b7af215fe(array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7576)]);
				base.c18286cd58f49629141bc091b7af215fe(array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7580)]);
				File.Copy(text8, text9);
				File.Copy(text10, text11);
				File.Move(text4, text2);
				File.Copy(text5, text6);
				if (base.ToInject.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7584))
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
					c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(text6, Path.GetDirectoryName(text6), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39047));
				}
				else if (base.ToInject.Platform == (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7588))
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
					c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(text6, Path.GetDirectoryName(text6));
				}
				if (!File.Exists(text7))
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
					throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39092));
				}
				base.c18286cd58f49629141bc091b7af215fe(text2);
				base.c18286cd58f49629141bc091b7af215fe(text6);
				base.c7edf1b3f88145bc9d58df301f738705a(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(7592));
				thread.Join();
				this.ce2698f6d61a96883244b8453f3f33a3c();
				if (base.Production)
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
					base.c7ae8f46123fff8448a639de3acad6d5f(text13, text12);
				}
				base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38540)));
				base.cf3d4c5f6a1ce4f53ba9211544c7c1a16(base.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39205)));
				base.c18286cd58f49629141bc091b7af215fe(cbd0b99b96bcec2882811add3e39c28bb);
				base.c232fcc851b0115da370b4acb1c9d0e05();
				base.ca1394714ad264b382e2c09206f569348();
			}
			catch (Exception c08b391577522100e1046cacdb2283fb)
			{
				base.c3475132295323f8a31a663ad2110a7d2(c08b391577522100e1046cacdb2283fb);
			}
		}

		// Token: 0x0400026E RID: 622
		[CompilerGenerated]
		private bool c3da52cf1567286e8539bfc282b1265d3;

		// Token: 0x0400026F RID: 623
		[CompilerGenerated]
		private bool c96abcc81436fc3888efab42e4a01881e;

		// Token: 0x04000270 RID: 624
		[CompilerGenerated]
		private bool c24c9bdc64e30603d4824e224b3d7ac66;

		// Token: 0x04000271 RID: 625
		private string[] c6bfbfe5d3f3d9f925ea047e0fa39cd9a;

		// Token: 0x04000272 RID: 626
		[CompilerGenerated]
		private readonly TitleId c34f561f9e08e37a8a8f0b079eb4bec43;

		// Token: 0x04000273 RID: 627
		[CompilerGenerated]
		private readonly string ca3b62999065ee18f7739b446c02b4cec;

		// Token: 0x02000129 RID: 297
		[CompilerGenerated]
		private sealed class ccca08fdb093a512c6020c82e185be026
		{
			// Token: 0x06000901 RID: 2305 RVA: 0x0005DC48 File Offset: 0x0005BE48
			internal void cd6e50a5f8af76402cd9065d465f4f3a2(object cb0d7b0b893a41a39e281ddc32fc698bd, ce91c3ee3b6503970820b59a90b300d72 cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.c7cf943cf1b668441bf1566e9acf72d35.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe.GameProgress);
			}

			// Token: 0x06000902 RID: 2306 RVA: 0x0005DC68 File Offset: 0x0005BE68
			internal void cce5e5a137084a5712ca41882576d9c1f(object cd020a9448b1902e4410f2e9f4a256959, c8e60ceced0ce323f661e853233d10ec2 c920e624ed3f68a7518020d25dc06be2d)
			{
				this.c7cf943cf1b668441bf1566e9acf72d35.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x04000697 RID: 1687
			public c60797b4f8bfa489df1954dcdc88ad77d c7cf943cf1b668441bf1566e9acf72d35;
		}

		// Token: 0x0200012A RID: 298
		[CompilerGenerated]
		private sealed class c1d2cf2bf6cbed901d896cd48f20b8d62
		{
			// Token: 0x06000904 RID: 2308 RVA: 0x0005DC94 File Offset: 0x0005BE94
			internal void ced20de1c6b3d8c7d814b14ae5dc90a87()
			{
				c4c1cf20119750bfee2a0bb499f990883.c1add8d63ef8501f3f59df9167bc45133(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38419), this.ccb074d6b874e810ff5ea2528e5315eb4);
				Directory.Delete(this.ca1d8ec0d7d355334535e412c1ff4c2b7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30364) != 0);
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30368));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30372)] = this.ccb074d6b874e810ff5ea2528e5315eb4;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30376)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38986);
				c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(Path.Combine(array), this.ccb074d6b874e810ff5ea2528e5315eb4, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1550));
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x0005DD28 File Offset: 0x0005BF28
			internal void c2aa8a248120aa19a8ba02abac7cabd5e(object cb0d7b0b893a41a39e281ddc32fc698bd, DownloadProgressChangedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cf1cbd6c013fa578db4f915226e6472b7(cdf15457ee4816989343b6e6e96dd4cfe.ProgressPercentage);
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x0005DD48 File Offset: 0x0005BF48
			internal void c3d239786daef2ecf50916a72c319c897(object cb0d7b0b893a41a39e281ddc32fc698bd, AsyncCompletedEventArgs cdf15457ee4816989343b6e6e96dd4cfe)
			{
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x0005DD60 File Offset: 0x0005BF60
			internal void c68bb99626c04286ccfd18ffbfee1b094()
			{
				string cdb43528d5e5a70b8801ab74795c78e = this.ca1d8ec0d7d355334535e412c1ff4c2b7;
				string cba76a39de77da530172391108797878f = this.c5a0274dabc49615bccaeb09a9b7df690;
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30380));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30384)] = this.ccb074d6b874e810ff5ea2528e5315eb4;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30388)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98201);
				c729dffd0908d9394e2ff50a1f9588119.c69bf8280727747918cb0bd4499e9adf4(cdb43528d5e5a70b8801ab74795c78e, cba76a39de77da530172391108797878f, Path.Combine(array));
				Directory.Delete(this.ca1d8ec0d7d355334535e412c1ff4c2b7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30392) != 0);
				string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30396));
				array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30400)] = this.ccb074d6b874e810ff5ea2528e5315eb4;
				array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30404)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98201);
				Directory.Move(Path.Combine(array2), this.ca1d8ec0d7d355334535e412c1ff4c2b7);
				string[] array3 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30408));
				array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30412)] = this.ccb074d6b874e810ff5ea2528e5315eb4;
				array3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30416)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(39009);
				c4c1cf20119750bfee2a0bb499f990883.c6992720ca5d3063aba6514cee9e8f4f1(Path.Combine(array3), this.ccb074d6b874e810ff5ea2528e5315eb4);
			}

			// Token: 0x04000698 RID: 1688
			public string ccb074d6b874e810ff5ea2528e5315eb4;

			// Token: 0x04000699 RID: 1689
			public string ca1d8ec0d7d355334535e412c1ff4c2b7;

			// Token: 0x0400069A RID: 1690
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;

			// Token: 0x0400069B RID: 1691
			public string c5a0274dabc49615bccaeb09a9b7df690;
		}
	}
}
