using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using SharpCompress.Readers;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace A
{
	// Token: 0x02000028 RID: 40
	public static class cc84e78656043d401078b58e0ff35dd48
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00008AE4 File Offset: 0x00006CE4
		public static string DbVersionCode { get; } = "";

		// Token: 0x060000C4 RID: 196 RVA: 0x00008AF8 File Offset: 0x00006CF8
		public static void c92d03d65be2d0258da80fddaecea1a40(string cdfa8e5617f0f17ad7922772c65a24101, string cf5ebc69cfa72da3a26dd73059f240e22, string c36a183e2dbd0d173787c2e03a4f16f7b, string c3029528951ef0168af81715363b76fec, string c1dea91e157f97a9723b73437947ae71e, string ca3f713b6e43c226a506a88182c1e9082, bool c84f82f13ff05d0c550c815f6d47dc853, byte[] c1e9648e54295aa0c92cd31a9812e8b5d, byte[] c7f19abd9146d40d0012f1ece53410cea, c33b9cfba40fb236bddfe6249d60760cf cbdeb41ecef96a7236d7770ceee883278)
		{
			Delegate serverCertificateValidationCallback = ServicePointManager.ServerCertificateValidationCallback;
			RemoteCertificateValidationCallback b;
			if ((b = cc84e78656043d401078b58e0ff35dd48.<>c.c5929ec01864da35c99819e07058761e4) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc84e78656043d401078b58e0ff35dd48.c92d03d65be2d0258da80fddaecea1a40(string, string, string, string, string, string, bool, byte[], byte[], c33b9cfba40fb236bddfe6249d60760cf)).MethodHandle;
				}
				b = (cc84e78656043d401078b58e0ff35dd48.<>c.c5929ec01864da35c99819e07058761e4 = new RemoteCertificateValidationCallback(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.c3f0ea33149086cb2dade0dfad5bbe860));
			}
			ServicePointManager.ServerCertificateValidationCallback = cb0176d5dd315b12982875473bccc9c7e.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(serverCertificateValidationCallback, b));
			ServicePointManager.DefaultConnectionLimit = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2920);
			cc84e78656043d401078b58e0ff35dd48.c451217115889dd151ec6f18570cfe42d = cf5ebc69cfa72da3a26dd73059f240e22;
			cc84e78656043d401078b58e0ff35dd48.c985f97e3483128b5825107afbe19b710 = c36a183e2dbd0d173787c2e03a4f16f7b;
			cc84e78656043d401078b58e0ff35dd48.c97ba73bc3b68a1b51c922decd5239b5d = c3029528951ef0168af81715363b76fec;
			c67726bc94fb4dd43c5c00e863a4fed19.c92d03d65be2d0258da80fddaecea1a40(cc84e78656043d401078b58e0ff35dd48.c451217115889dd151ec6f18570cfe42d);
			ce07c379a1090dd9de869aa5e3a694e98.cb738a85c88d0291dd4f7bfc618a306e1 = c1dea91e157f97a9723b73437947ae71e;
			c6a5e9b85d86b4e098a511017a1073d71.c1152591410dbe9c7e6a47a5d8b0a69b5 = ce07c379a1090dd9de869aa5e3a694e98.c14433fd00664056e4068455a5dbab2a4();
			c6a5e9b85d86b4e098a511017a1073d71.cd086372afa56d57a77509bb9fba66a52 = ce07c379a1090dd9de869aa5e3a694e98.c0e3f1d536ae7128b270bd0913dbe2faf();
			c6a5e9b85d86b4e098a511017a1073d71.c2eaf0dbe8bd11ef4cc2db5c557fe1f2f = cdfa8e5617f0f17ad7922772c65a24101;
			c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Clear();
			c6a5e9b85d86b4e098a511017a1073d71.c29f65ab0f6b6de174c408644bf172abe.Clear();
			c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.Clear();
			c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282.Clear();
			c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7.Clear();
			c6114b34ba4893a53ebb4b599e0e2e3fc.c547b9b2c939170ad144a18e7dbded18d();
			ce07c379a1090dd9de869aa5e3a694e98.cd0aaf0323cfd397657b21a5c8f1b3111();
			ce07c379a1090dd9de869aa5e3a694e98.c140148ec07c360a403ba7395ace7bc19(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1821));
			ce07c379a1090dd9de869aa5e3a694e98.c140148ec07c360a403ba7395ace7bc19(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1850));
			ce07c379a1090dd9de869aa5e3a694e98.c140148ec07c360a403ba7395ace7bc19(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1883));
			ce07c379a1090dd9de869aa5e3a694e98.c140148ec07c360a403ba7395ace7bc19(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1922));
			ce07c379a1090dd9de869aa5e3a694e98.c5f35610ada9f2e6fa922772ed7be1a01(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1957));
			ce07c379a1090dd9de869aa5e3a694e98.c5f35610ada9f2e6fa922772ed7be1a01(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1990));
			ce07c379a1090dd9de869aa5e3a694e98.c7fa50420699e204537941d08eea98ec4(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2029));
			ce07c379a1090dd9de869aa5e3a694e98.c7fa50420699e204537941d08eea98ec4(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2056));
			if (!c84f82f13ff05d0c550c815f6d47dc853)
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
				try
				{
					cc84e78656043d401078b58e0ff35dd48.c78c8cd9ce3906a1b31d7847405ec16e7(c1e9648e54295aa0c92cd31a9812e8b5d);
					goto IL_20C;
				}
				catch
				{
					Settings.Default.TicketsPath = "";
					Settings.Default.TicketsPath3DS = "";
					RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2089));
					Application.Restart();
					return;
				}
			}
			string c271a832e629a79991d9eda7a270cb = "";
			string c7f19abd9146d40d0012f1ece53410cea2 = "";
			if (c1e9648e54295aa0c92cd31a9812e8b5d != null)
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
				c271a832e629a79991d9eda7a270cb = Encoding.UTF8.GetString(c1e9648e54295aa0c92cd31a9812e8b5d);
			}
			if (c7f19abd9146d40d0012f1ece53410cea != null)
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
				c7f19abd9146d40d0012f1ece53410cea2 = Encoding.UTF8.GetString(c7f19abd9146d40d0012f1ece53410cea);
			}
			cc84e78656043d401078b58e0ff35dd48.c6182e4a600094c9e3a8bb56fad508c36(c271a832e629a79991d9eda7a270cb, c7f19abd9146d40d0012f1ece53410cea2);
			IL_20C:
			if (c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Count == 0)
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
				throw new Exception(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2417));
			}
			using (Dictionary<TitleId, c5409344e1c2b74fa8c9a4d620ccb8d48>.ValueCollection.Enumerator enumerator = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Values.GetEnumerator())
			{
				IL_304:
				while (enumerator.MoveNext())
				{
					c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = enumerator.Current;
					using (List<c2b8ef1783ae572d19956814809070e24>.Enumerator enumerator2 = c6a5e9b85d86b4e098a511017a1073d71.c29f65ab0f6b6de174c408644bf172abe.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							c2b8ef1783ae572d19956814809070e24 c2b8ef1783ae572d19956814809070e = enumerator2.Current;
							if (!c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c5409344e1c2b74fa8c9a4d620ccb8d.TitleId.High, c2b8ef1783ae572d19956814809070e.TitleId.High))
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
								if (c5409344e1c2b74fa8c9a4d620ccb8d.System == c2b8ef1783ae572d19956814809070e.System)
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
									c2b8ef1783ae572d19956814809070e.Name = c5409344e1c2b74fa8c9a4d620ccb8d.Name;
									c5409344e1c2b74fa8c9a4d620ccb8d.Dlc = c2b8ef1783ae572d19956814809070e;
									goto IL_304;
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
				}
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2524)))
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
				cc84e78656043d401078b58e0ff35dd48.cc2049761f3b597d5eed090e39a71b271 cc2049761f3b597d5eed090e39a71b = new cc84e78656043d401078b58e0ff35dd48.cc2049761f3b597d5eed090e39a71b271();
				cc2049761f3b597d5eed090e39a71b.c9d24e30d225341cf74ba49b4280fb6e7 = c67726bc94fb4dd43c5c00e863a4fed19.c8334ccea7202097a0899b9cb1fac251e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2524));
				c6a5e9b85d86b4e098a511017a1073d71.NewTitles = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Values.Where(new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(cc2049761f3b597d5eed090e39a71b.cfdf2a3e1e468a05b4106916014e9a010)).ToList<c5409344e1c2b74fa8c9a4d620ccb8d48>();
			}
			string c4d6abdac9d3efb16a0adcf6a56cd5ad = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2524);
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> values = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Values;
			Func<c5409344e1c2b74fa8c9a4d620ccb8d48, string> selector;
			if ((selector = cc84e78656043d401078b58e0ff35dd48.<>c.c0434aac7811ffa3494aede98a2b47a66) == null)
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
				selector = (cc84e78656043d401078b58e0ff35dd48.<>c.c0434aac7811ffa3494aede98a2b47a66 = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, string>(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.cf16556c4dbe24327aa99a354236c4ec4));
			}
			c67726bc94fb4dd43c5c00e863a4fed19.c6be8a9a2e62443fd1e448c28bd8dad3e(c4d6abdac9d3efb16a0adcf6a56cd5ad, values.Select(selector).ToArray<string>());
			if (c67726bc94fb4dd43c5c00e863a4fed19.c005d865de5ac02579ca8398dd0288abf(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2545)))
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
				cc84e78656043d401078b58e0ff35dd48.c694704e1803a376db02bc8181519907b c694704e1803a376db02bc8181519907b = new cc84e78656043d401078b58e0ff35dd48.c694704e1803a376db02bc8181519907b();
				c694704e1803a376db02bc8181519907b.cc21f2ee3aaae8977c3ef7471abed7bc8 = c67726bc94fb4dd43c5c00e863a4fed19.c8334ccea7202097a0899b9cb1fac251e(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2545));
				IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> values2 = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Values;
				Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool> predicate;
				if ((predicate = cc84e78656043d401078b58e0ff35dd48.<>c.c3fc8ab063c36a33a9fbe469776603b0c) == null)
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
					predicate = (cc84e78656043d401078b58e0ff35dd48.<>c.c3fc8ab063c36a33a9fbe469776603b0c = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.cebc693dff8e105a36173b13d1307fed5));
				}
				IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> source = values2.Where(predicate);
				Func<c5409344e1c2b74fa8c9a4d620ccb8d48, c6a2f8acae5ff1a8a909193a5c5de6687> selector2;
				if ((selector2 = cc84e78656043d401078b58e0ff35dd48.<>c.c5b44637840c2cdb179a554500678e72c) == null)
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
					selector2 = (cc84e78656043d401078b58e0ff35dd48.<>c.c5b44637840c2cdb179a554500678e72c = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, c6a2f8acae5ff1a8a909193a5c5de6687>(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.cbd40525a45a01c83ad359bb97773df74));
				}
				c6a5e9b85d86b4e098a511017a1073d71.NewUpdates = source.Select(selector2).Where(new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(c694704e1803a376db02bc8181519907b.c1a83a0bea25d07278f307cd18fd4aee6)).ToList<c6a2f8acae5ff1a8a909193a5c5de6687>();
			}
			string c4d6abdac9d3efb16a0adcf6a56cd5ad2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2545);
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> values3 = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Values;
			Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool> predicate2;
			if ((predicate2 = cc84e78656043d401078b58e0ff35dd48.<>c.ca4dec225b17e4b090e2351bb6b75dda9) == null)
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
				predicate2 = (cc84e78656043d401078b58e0ff35dd48.<>c.ca4dec225b17e4b090e2351bb6b75dda9 = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, bool>(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.c1841006952498e9d4a8df45b315286a3));
			}
			IEnumerable<c5409344e1c2b74fa8c9a4d620ccb8d48> source2 = values3.Where(predicate2);
			Func<c5409344e1c2b74fa8c9a4d620ccb8d48, string> selector3;
			if ((selector3 = cc84e78656043d401078b58e0ff35dd48.<>c.c04b765de985f39ffe740a764e18ad50b) == null)
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
				selector3 = (cc84e78656043d401078b58e0ff35dd48.<>c.c04b765de985f39ffe740a764e18ad50b = new Func<c5409344e1c2b74fa8c9a4d620ccb8d48, string>(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.ca1daab4eb7cb03ce0c387c876af3d4ea));
			}
			c67726bc94fb4dd43c5c00e863a4fed19.c6be8a9a2e62443fd1e448c28bd8dad3e(c4d6abdac9d3efb16a0adcf6a56cd5ad2, source2.Select(selector3).ToArray<string>());
			cc84e78656043d401078b58e0ff35dd48.ce59b039daa08418115eedbcbad0a3483(cbdeb41ecef96a7236d7770ceee883278);
			try
			{
				cc84e78656043d401078b58e0ff35dd48.c55966b80969a9cd760ff436c15571902(new DirectoryInfo(Path.Combine(cdfa8e5617f0f17ad7922772c65a24101, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2568))).GetDirectories(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(898), (System.IO.SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2924)));
			}
			catch
			{
			}
			cc84e78656043d401078b58e0ff35dd48.cd73ba1aadf295cccfa1e390911bd5c82(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2585));
			cc84e78656043d401078b58e0ff35dd48.cd73ba1aadf295cccfa1e390911bd5c82(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2642));
			cc986a36f7534edc08e2f8221002d522a.cca035b5773e1c7bd4eb2ebb87879807e();
			c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282.Clear();
			c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7.Clear();
			c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.Clear();
			c6a5e9b85d86b4e098a511017a1073d71.c1152591410dbe9c7e6a47a5d8b0a69b5 = c885752f0ba103b0c8ad11bede25dddd4.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00009110 File Offset: 0x00007310
		private static void cd73ba1aadf295cccfa1e390911bd5c82(string cbc47e314a0f1d7d5f1d07b50ba2bb8c7)
		{
			try
			{
				string xml = new c866035f717c1c145e269422264e8f519().c8fde2f16b504e6f2d61ca9ffff7c28f6(cbc47e314a0f1d7d5f1d07b50ba2bb8c7);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				IEnumerator enumerator = xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2697)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object c0d6c37d812d5d4b610705a6421056252 = enumerator.Current;
						string innerXml = c75fdfaf36a6cfd5544847dc9c3b8c6fc.cd24593c859565ebb8c9faabbc5c75bef(c0d6c37d812d5d4b610705a6421056252).InnerXml;
						if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(innerXml, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2720)))
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(cc84e78656043d401078b58e0ff35dd48.cd73ba1aadf295cccfa1e390911bd5c82(string)).MethodHandle;
							}
							TitleId key = new TitleId(innerXml.Substring(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2928), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2932)));
							if (c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.ContainsKey(key))
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
								c6a5e9b85d86b4e098a511017a1073d71.cba492c136fe5dbb7b4a1e75e12490067.Add(c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[key]);
							}
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
				finally
				{
					IDisposable disposable = c2f4016fa04d8c2b2a9dba60e295715d5.c0b398ab350e72b0d64d512bae8520b85(enumerator);
					if (disposable != null)
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
						disposable.Dispose();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000925C File Offset: 0x0000745C
		private static void c2d9770b2e98517460a49d23cf64029a0(IEnumerable<DirectoryInfo> c790357de5a140c3310f7f6e585a9e01c)
		{
			Func<DirectoryInfo, bool> predicate;
			if ((predicate = cc84e78656043d401078b58e0ff35dd48.<>c.ce9e58ff3492c7ce54d17214d8beaab5c) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc84e78656043d401078b58e0ff35dd48.c2d9770b2e98517460a49d23cf64029a0(IEnumerable<DirectoryInfo>)).MethodHandle;
				}
				predicate = (cc84e78656043d401078b58e0ff35dd48.<>c.ce9e58ff3492c7ce54d17214d8beaab5c = new Func<DirectoryInfo, bool>(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.c2faa847aff8c51ef93f0536b391fd5ae));
			}
			IEnumerator<DirectoryInfo> enumerator = c790357de5a140c3310f7f6e585a9e01c.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DirectoryInfo directoryInfo = enumerator.Current;
					try
					{
						int num = directoryInfo.Name.IndexOf((char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2936)) + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2940);
						string text = directoryInfo.Name.Substring(num, directoryInfo.Name.IndexOf((char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2944)) - num);
						if (text.Length != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2948))
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
						}
						else
						{
							TitleId titleId = new TitleId(text);
							if (titleId.IdType != (c4646e2a6e2ad7e5620e9ecf229259217)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2952))
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
								if (titleId.IdType != (c4646e2a6e2ad7e5620e9ecf229259217)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2956))
								{
									continue;
								}
								for (;;)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							if (!c6a5e9b85d86b4e098a511017a1073d71.cfa0453d3b4ceddc251b00992c05d2355.Contains(titleId))
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
								c6a5e9b85d86b4e098a511017a1073d71.cfa0453d3b4ceddc251b00992c05d2355.Add(titleId);
							}
						}
					}
					catch
					{
					}
				}
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
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009400 File Offset: 0x00007600
		private static void c55966b80969a9cd760ff436c15571902(IEnumerable<DirectoryInfo> c790357de5a140c3310f7f6e585a9e01c)
		{
			Func<DirectoryInfo, bool> predicate;
			if ((predicate = cc84e78656043d401078b58e0ff35dd48.<>c.c6ef5f159df1e335193dc671bc70dd746) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc84e78656043d401078b58e0ff35dd48.c55966b80969a9cd760ff436c15571902(IEnumerable<DirectoryInfo>)).MethodHandle;
				}
				predicate = (cc84e78656043d401078b58e0ff35dd48.<>c.c6ef5f159df1e335193dc671bc70dd746 = new Func<DirectoryInfo, bool>(cc84e78656043d401078b58e0ff35dd48.<>c.cdfab1996eb8651828de2a4469aa3481e.c1ed6a2494fbc23570d762324e0f69063));
			}
			IEnumerator<DirectoryInfo> enumerator = c790357de5a140c3310f7f6e585a9e01c.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DirectoryInfo directoryInfo = enumerator.Current;
					TitleId titleId = new TitleId(directoryInfo.Name);
					c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = c0e041e021e04e712883cd11308c15013.cab55a050df275722227783d6686266c9;
					try
					{
						cc84e78656043d401078b58e0ff35dd48.c4ec7ada716e78a3408c6e14fe693f1d6 c4ec7ada716e78a3408c6e14fe693f1d = new cc84e78656043d401078b58e0ff35dd48.c4ec7ada716e78a3408c6e14fe693f1d6();
						switch (titleId.IdType)
						{
						case c4646e2a6e2ad7e5620e9ecf229259217.c24a909f37d52e349b85b05af7ea35021:
						{
							cbcbdbfc95367bfec4c11b371d883aa2d cbcbdbfc95367bfec4c11b371d883aa2d = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(Path.Combine(directoryInfo.FullName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767)), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2960));
							c4ec7ada716e78a3408c6e14fe693f1d.cb9752ebbe18b2ad5c3dc365914dc024b = cbcbdbfc95367bfec4c11b371d883aa2d.TitleVersion;
							c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame].Updates.First(new Func<c6a2f8acae5ff1a8a909193a5c5de6687, bool>(c4ec7ada716e78a3408c6e14fe693f1d.cad11ff3accfd9d98d983b8ffac9d2072));
							break;
						}
						case c4646e2a6e2ad7e5620e9ecf229259217.cf3ffecff4696059f416ae6bc384a621a:
							c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId];
							break;
						case c4646e2a6e2ad7e5620e9ecf229259217.cfcd2a9c7ebb0515632c1fccbd0310e52:
							c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame].Dlc;
							break;
						case c4646e2a6e2ad7e5620e9ecf229259217.cce1ca64aa0800a9df01b06d31f2d1fd6:
							c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId];
							break;
						}
					}
					catch
					{
						continue;
					}
					try
					{
						FileSystem.MoveDirectory(directoryInfo.FullName, c6114b34ba4893a53ebb4b599e0e2e3fc.OutputPath);
					}
					catch
					{
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
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000095EC File Offset: 0x000077EC
		private static void ce59b039daa08418115eedbcbad0a3483(c33b9cfba40fb236bddfe6249d60760cf cbdeb41ecef96a7236d7770ceee883278)
		{
			try
			{
				new WebClient().DownloadStringAsync(new Uri(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2786), cbdeb41ecef96a7236d7770ceee883278.c455419c9797ab5ceb912e02a60c8912c, cbdeb41ecef96a7236d7770ceee883278.ca38b3a46b67915c10d580c6fde93e588, cbdeb41ecef96a7236d7770ceee883278.cab9e9604c37e945741c3504d78c010a1)));
			}
			catch
			{
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00009644 File Offset: 0x00007844
		private static void c78c8cd9ce3906a1b31d7847405ec16e7(byte[] cd01b667eed28e4e5eefe8d16ba575231)
		{
			try
			{
				Stream stream = new MemoryStream(cd01b667eed28e4e5eefe8d16ba575231);
				try
				{
					IReader reader = ReaderFactory.Open(stream, c14d40c2b2a764567b6cd18c56bb984f4.cab55a050df275722227783d6686266c9);
					try
					{
						char c;
						if (reader.ArchiveType != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2964))
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(cc84e78656043d401078b58e0ff35dd48.c78c8cd9ce3906a1b31d7847405ec16e7(byte[])).MethodHandle;
							}
							c = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2968);
						}
						else
						{
							c = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2972);
						}
						char c2 = c;
						while (reader.MoveToNextEntry())
						{
							cc84e78656043d401078b58e0ff35dd48.c1f0a4fc53f3fad871ba4397135c1a42d c1f0a4fc53f3fad871ba4397135c1a42d = new cc84e78656043d401078b58e0ff35dd48.c1f0a4fc53f3fad871ba4397135c1a42d();
							if (!reader.Entry.IsDirectory)
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
								cc84e78656043d401078b58e0ff35dd48.c1f0a4fc53f3fad871ba4397135c1a42d c1f0a4fc53f3fad871ba4397135c1a42d2 = c1f0a4fc53f3fad871ba4397135c1a42d;
								string key = reader.Entry.Key;
								char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2976));
								array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2980)] = c2;
								c1f0a4fc53f3fad871ba4397135c1a42d2.caa2acf682213c839c21c4e4f91173a4d = key.Split(array, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2984));
								if ((int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(c1f0a4fc53f3fad871ba4397135c1a42d.caa2acf682213c839c21c4e4f91173a4d) >= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2988))
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
									TitleId titleId = new TitleId(c1f0a4fc53f3fad871ba4397135c1a42d.caa2acf682213c839c21c4e4f91173a4d[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2992)]);
									if (c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7.ContainsKey(titleId.FullGame))
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
										if (titleId.IdType != c4646e2a6e2ad7e5620e9ecf229259217.c24a909f37d52e349b85b05af7ea35021)
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
											if (!c6a5e9b85d86b4e098a511017a1073d71.c1152591410dbe9c7e6a47a5d8b0a69b5.Contains(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId.FullGame)))
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
												MemoryStream memoryStream = new MemoryStream();
												byte[] buffer;
												try
												{
													reader.WriteEntryTo(memoryStream);
													buffer = memoryStream.GetBuffer();
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
												c4646e2a6e2ad7e5620e9ecf229259217 idType = titleId.IdType;
												int num = (int)idType;
												if (num != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2996))
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
													if (num == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3000))
													{
														continue;
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
												else if (c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282.ContainsKey(titleId))
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
													c2b8ef1783ae572d19956814809070e24 item = new c2b8ef1783ae572d19956814809070e24("", titleId, c1f0a4fc53f3fad871ba4397135c1a42d.caa2acf682213c839c21c4e4f91173a4d[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3004)], buffer, c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282[titleId].c029cb26b0aae604f5c2d4c53cbc49f62, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3008))
													{
														CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3012) != 0)
													};
													c6a5e9b85d86b4e098a511017a1073d71.c29f65ab0f6b6de174c408644bf172abe.Add(item);
													continue;
												}
												List<c6a2f8acae5ff1a8a909193a5c5de6687> list = new List<c6a2f8acae5ff1a8a909193a5c5de6687>();
												if (c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.ContainsKey(new TitleId(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId.FullUpdate))))
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
													list.AddRange(c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea[titleId.FullUpdate].Select(new Func<cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e, c6a2f8acae5ff1a8a909193a5c5de6687>(c1f0a4fc53f3fad871ba4397135c1a42d.c8246c588cf6e213ac5439583d4b2a51b)));
												}
												c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = new c5409344e1c2b74fa8c9a4d620ccb8d48(c1f0a4fc53f3fad871ba4397135c1a42d.caa2acf682213c839c21c4e4f91173a4d[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3016)], titleId, c1f0a4fc53f3fad871ba4397135c1a42d.caa2acf682213c839c21c4e4f91173a4d[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3020)], buffer, c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId].Size, list, c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId].EshopId, c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId].ProductCode, c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId].IconUrl, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId].Platform, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3024));
												if (c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId.FullGame].ProductCode.Length < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3028))
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
													Console.WriteLine(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3103), c5409344e1c2b74fa8c9a4d620ccb8d.Name, c5409344e1c2b74fa8c9a4d620ccb8d.TitleId, c5409344e1c2b74fa8c9a4d620ccb8d.EshopId));
												}
												if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId.FullGame].IconUrl, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3170)))
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
													Console.WriteLine(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3179), c5409344e1c2b74fa8c9a4d620ccb8d.Name, c5409344e1c2b74fa8c9a4d620ccb8d.TitleId, c5409344e1c2b74fa8c9a4d620ccb8d.EshopId));
												}
												if (!c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.ContainsKey(c5409344e1c2b74fa8c9a4d620ccb8d.TitleId))
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
													c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Add(c5409344e1c2b74fa8c9a4d620ccb8d.TitleId, c5409344e1c2b74fa8c9a4d620ccb8d);
												}
											}
										}
									}
								}
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
					}
					finally
					{
						if (reader != null)
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
							reader.Dispose();
						}
					}
				}
				finally
				{
					if (stream != null)
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
						((IDisposable)stream).Dispose();
					}
				}
			}
			catch
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00009B88 File Offset: 0x00007D88
		private static void c6182e4a600094c9e3a8bb56fad508c36(string c271a832e629a79991d9eda7a270cb125, string c7f19abd9146d40d0012f1ece53410cea)
		{
			new cb40090777e77bca24d8e80d3881b439d(cc84e78656043d401078b58e0ff35dd48.c985f97e3483128b5825107afbe19b710, cc84e78656043d401078b58e0ff35dd48.c97ba73bc3b68a1b51c922decd5239b5d, c271a832e629a79991d9eda7a270cb125, c7f19abd9146d40d0012f1ece53410cea).cce9af53283cfef7a284b260db9a1d817();
		}

		// Token: 0x04000069 RID: 105
		private static string c451217115889dd151ec6f18570cfe42d;

		// Token: 0x0400006A RID: 106
		private static string c985f97e3483128b5825107afbe19b710;

		// Token: 0x0400006B RID: 107
		private static string c97ba73bc3b68a1b51c922decd5239b5d;

		// Token: 0x0400006C RID: 108
		[CompilerGenerated]
		private static readonly string c3d78e5601317c96e9f853569eaa81917;

		// Token: 0x020000F2 RID: 242
		[CompilerGenerated]
		private sealed class cc2049761f3b597d5eed090e39a71b271
		{
			// Token: 0x06000866 RID: 2150 RVA: 0x0005AB10 File Offset: 0x00058D10
			internal bool cfdf2a3e1e468a05b4106916014e9a010(c5409344e1c2b74fa8c9a4d620ccb8d48 ced17f5fac5de96d8d690dac7cea067a7)
			{
				return (this.c9d24e30d225341cf74ba49b4280fb6e7.Contains(ced17f5fac5de96d8d690dac7cea067a7.TitleId.IdRaw) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29856);
			}

			// Token: 0x040005EA RID: 1514
			public string[] c9d24e30d225341cf74ba49b4280fb6e7;
		}

		// Token: 0x020000F3 RID: 243
		[CompilerGenerated]
		private sealed class c694704e1803a376db02bc8181519907b
		{
			// Token: 0x06000868 RID: 2152 RVA: 0x0005AB58 File Offset: 0x00058D58
			internal bool c1a83a0bea25d07278f307cd18fd4aee6(c6a2f8acae5ff1a8a909193a5c5de6687 ced17f5fac5de96d8d690dac7cea067a7)
			{
				if (!this.cc21f2ee3aaae8977c3ef7471abed7bc8.Contains(ced17f5fac5de96d8d690dac7cea067a7.ToString()))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cc84e78656043d401078b58e0ff35dd48.c694704e1803a376db02bc8181519907b.c1a83a0bea25d07278f307cd18fd4aee6(c6a2f8acae5ff1a8a909193a5c5de6687)).MethodHandle;
					}
					return ((ced17f5fac5de96d8d690dac7cea067a7.ca435006c85356cb7385a782de8889a0a == (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29860)) ? 1 : 0) == cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29864);
				}
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29868) != 0;
			}

			// Token: 0x040005EB RID: 1515
			public string[] cc21f2ee3aaae8977c3ef7471abed7bc8;
		}

		// Token: 0x020000F5 RID: 245
		[CompilerGenerated]
		private sealed class c4ec7ada716e78a3408c6e14fe693f1d6
		{
			// Token: 0x06000874 RID: 2164 RVA: 0x0005AE54 File Offset: 0x00059054
			internal bool cad11ff3accfd9d98d983b8ffac9d2072(c6a2f8acae5ff1a8a909193a5c5de6687 ced17f5fac5de96d8d690dac7cea067a7)
			{
				return c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ced17f5fac5de96d8d690dac7cea067a7.Version, this.cb9752ebbe18b2ad5c3dc365914dc024b.ToString());
			}

			// Token: 0x040005F5 RID: 1525
			public ushort cb9752ebbe18b2ad5c3dc365914dc024b;
		}

		// Token: 0x020000F6 RID: 246
		[CompilerGenerated]
		private sealed class c1f0a4fc53f3fad871ba4397135c1a42d
		{
			// Token: 0x06000876 RID: 2166 RVA: 0x0005AE94 File Offset: 0x00059094
			internal c6a2f8acae5ff1a8a909193a5c5de6687 c8246c588cf6e213ac5439583d4b2a51b(cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e c3d3f8be678d55ec756d5d3661ff98846)
			{
				return new c6a2f8acae5ff1a8a909193a5c5de6687(this.caa2acf682213c839c21c4e4f91173a4d[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29908)], c3d3f8be678d55ec756d5d3661ff98846.cced90bbc7aa0995aa10924a12b207d73, this.caa2acf682213c839c21c4e4f91173a4d[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29912)], null, c3d3f8be678d55ec756d5d3661ff98846.c029cb26b0aae604f5c2d4c53cbc49f62, c3d3f8be678d55ec756d5d3661ff98846.c0b9a995f9c2313cad22315173d49b769, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(29916));
			}

			// Token: 0x040005F6 RID: 1526
			public string[] caa2acf682213c839c21c4e4f91173a4d;
		}
	}
}
