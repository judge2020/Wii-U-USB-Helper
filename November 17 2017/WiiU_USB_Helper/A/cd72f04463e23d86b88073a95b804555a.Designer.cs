using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace A
{
	// Token: 0x020000CA RID: 202
	public class cd72f04463e23d86b88073a95b804555a : RadForm
	{
		// Token: 0x06000716 RID: 1814 RVA: 0x0003A674 File Offset: 0x00038874
		public cd72f04463e23d86b88073a95b804555a(string cfe996d6f042df50b724be2885cb5d42e)
		{
			this.c82b8091adcf720aa7a90631953c644c8();
			this.cafa217929242adeb0ff634aed8ac34f0 = cfe996d6f042df50b724be2885cb5d42e;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0003A6A0 File Offset: 0x000388A0
		private void c46b6ded173670d3a80a210dd349eb95a(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			IEnumerable<ListViewDataItem> items = this.cee54c856c7e63e5fbea3d765715af7a0.Items;
			Func<ListViewDataItem, bool> predicate;
			if ((predicate = cd72f04463e23d86b88073a95b804555a.<>c.cadbf4f9ea59e10f9dc757b4f75444253) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd72f04463e23d86b88073a95b804555a.c46b6ded173670d3a80a210dd349eb95a(object, EventArgs)).MethodHandle;
				}
				predicate = (cd72f04463e23d86b88073a95b804555a.<>c.cadbf4f9ea59e10f9dc757b4f75444253 = new Func<ListViewDataItem, bool>(cd72f04463e23d86b88073a95b804555a.<>c.cdfab1996eb8651828de2a4469aa3481e.c30d673888ac0f795277b05e135347ed9));
			}
			IEnumerator<ListViewDataItem> enumerator = items.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListViewDataItem listViewDataItem = enumerator.Current;
					listViewDataItem.CheckState = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18120);
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
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0003A750 File Offset: 0x00038950
		private void cfb9fd2addd333e8c28d4aff66027ee10(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			IEnumerable<ListViewDataItem> items = this.cee54c856c7e63e5fbea3d765715af7a0.Items;
			Func<ListViewDataItem, bool> predicate;
			if ((predicate = cd72f04463e23d86b88073a95b804555a.<>c.c69ed08d21168e18e148b76fb23dffc22) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd72f04463e23d86b88073a95b804555a.cfb9fd2addd333e8c28d4aff66027ee10(object, EventArgs)).MethodHandle;
				}
				predicate = (cd72f04463e23d86b88073a95b804555a.<>c.c69ed08d21168e18e148b76fb23dffc22 = new Func<ListViewDataItem, bool>(cd72f04463e23d86b88073a95b804555a.<>c.cdfab1996eb8651828de2a4469aa3481e.c8d04a6a3de80a454e7b8cd1d9f61b568));
			}
			IEnumerator<ListViewDataItem> enumerator = items.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					cd72f04463e23d86b88073a95b804555a.cdb7b2d79f9dca333bf35c29225cd63da cdb7b2d79f9dca333bf35c29225cd63da = new cd72f04463e23d86b88073a95b804555a.cdb7b2d79f9dca333bf35c29225cd63da();
					cdb7b2d79f9dca333bf35c29225cd63da.c4404a159870bf55bb6f111e66e59e82d = this;
					cdb7b2d79f9dca333bf35c29225cd63da.c804bc52f7f79bffee6fd394ef382eb76 = enumerator.Current;
					string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66347);
					Action c594146923b42642ebf4bf2a5cd = new Action(cdb7b2d79f9dca333bf35c29225cd63da.c3207d0000188d4e5388b8acad65977c2);
					Action<Exception> c62f902d27574ffccbd029fee23622bc;
					if ((c62f902d27574ffccbd029fee23622bc = cd72f04463e23d86b88073a95b804555a.<>c.c22eb86bd2311f4b1894e69fa631e1a60) == null)
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
						c62f902d27574ffccbd029fee23622bc = (cd72f04463e23d86b88073a95b804555a.<>c.c22eb86bd2311f4b1894e69fa631e1a60 = new Action<Exception>(cd72f04463e23d86b88073a95b804555a.<>c.cdfab1996eb8651828de2a4469aa3481e.c41c6278122b17853e11f853fe520b165));
					}
					new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
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
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18124);
			base.Close();
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0003A860 File Offset: 0x00038A60
		private void cef36783c8274edea6244951ed1ea1b7e(object cd7b28952603b35a45c555982e677363a, EventArgs cdf15457ee4816989343b6e6e96dd4cfe)
		{
			cd72f04463e23d86b88073a95b804555a.cb2edd72f5c24a98e665ed0aba5073b19 cb2edd72f5c24a98e665ed0aba5073b = new cd72f04463e23d86b88073a95b804555a.cb2edd72f5c24a98e665ed0aba5073b19();
			cb2edd72f5c24a98e665ed0aba5073b.c4404a159870bf55bb6f111e66e59e82d = this;
			this.cee54c856c7e63e5fbea3d765715af7a0.SortDescriptors.Add(new SortDescriptor(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66422), (ListSortDirection)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18128)));
			cb2edd72f5c24a98e665ed0aba5073b.c727ad0bf79a3dbabc9ec7018f2e78199 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18132));
			string cfeefea196000bed18adf05bf7727db = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66433);
			Action c594146923b42642ebf4bf2a5cd = new Action(cb2edd72f5c24a98e665ed0aba5073b.cac1a6ee2050de5f27a17fef2acf0b8fe);
			Action<Exception> c62f902d27574ffccbd029fee23622bc;
			if ((c62f902d27574ffccbd029fee23622bc = cd72f04463e23d86b88073a95b804555a.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd72f04463e23d86b88073a95b804555a.cef36783c8274edea6244951ed1ea1b7e(object, EventArgs)).MethodHandle;
				}
				c62f902d27574ffccbd029fee23622bc = (cd72f04463e23d86b88073a95b804555a.<>c.ca6b3bce60a6464e6f649e5051bf8c5d0 = new Action<Exception>(cd72f04463e23d86b88073a95b804555a.<>c.cdfab1996eb8651828de2a4469aa3481e.c9ad044f527ca0d72064b85e26bac695c));
			}
			new c60797b4f8bfa489df1954dcdc88ad77d(cfeefea196000bed18adf05bf7727db, c594146923b42642ebf4bf2a5cd, c62f902d27574ffccbd029fee23622bc);
			string[] c727ad0bf79a3dbabc9ec7018f2e = cb2edd72f5c24a98e665ed0aba5073b.c727ad0bf79a3dbabc9ec7018f2e78199;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18136); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(c727ad0bf79a3dbabc9ec7018f2e); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18172))
			{
				string text = c727ad0bf79a3dbabc9ec7018f2e[i];
				string text2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66526);
				cbcbdbfc95367bfec4c11b371d883aa2d cbcbdbfc95367bfec4c11b371d883aa2d = cbcbdbfc95367bfec4c11b371d883aa2d.cca035b5773e1c7bd4eb2ebb87879807e(text, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18140));
				TitleId titleId = new TitleId(cbcbdbfc95367bfec4c11b371d883aa2d.TitleId.ToString(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66557)));
				if (c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.ContainsKey(titleId.FullGame))
				{
					c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = c0e041e021e04e712883cd11308c15013.cab55a050df275722227783d6686266c9;
					switch (titleId.IdType)
					{
					case c4646e2a6e2ad7e5620e9ecf229259217.c24a909f37d52e349b85b05af7ea35021:
						c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame];
						if (c6114b34ba4893a53ebb4b599e0e2e3fc.System == ceee61848167c1ade885c85db30acc060.c976b35b0c4e8e6521c01617e67f4550b)
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
							c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame].Updates.Last<c6a2f8acae5ff1a8a909193a5c5de6687>();
						}
						else if (c6114b34ba4893a53ebb4b599e0e2e3fc.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18156))
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
							cd72f04463e23d86b88073a95b804555a.cef0d9a6dff0a80e0101dc8fff3170e31 cef0d9a6dff0a80e0101dc8fff3170e = new cd72f04463e23d86b88073a95b804555a.cef0d9a6dff0a80e0101dc8fff3170e31();
							cef0d9a6dff0a80e0101dc8fff3170e.cb9752ebbe18b2ad5c3dc365914dc024b = cbcbdbfc95367bfec4c11b371d883aa2d.TitleVersion;
							try
							{
								c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame].Updates.Find(new Predicate<c6a2f8acae5ff1a8a909193a5c5de6687>(cef0d9a6dff0a80e0101dc8fff3170e.c9b84fb92c525b314aa5f1523339706a3));
								break;
							}
							catch
							{
								c6114b34ba4893a53ebb4b599e0e2e3fc = c0e041e021e04e712883cd11308c15013.cab55a050df275722227783d6686266c9;
								break;
							}
							goto IL_2E4;
						}
						break;
					case c4646e2a6e2ad7e5620e9ecf229259217.cf3ffecff4696059f416ae6bc384a621a:
						c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame];
						break;
					case c4646e2a6e2ad7e5620e9ecf229259217.cfcd2a9c7ebb0515632c1fccbd0310e52:
						c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame].Dlc;
						break;
					case c4646e2a6e2ad7e5620e9ecf229259217.cce1ca64aa0800a9df01b06d31f2d1fd6:
						goto IL_2E4;
					case c4646e2a6e2ad7e5620e9ecf229259217.cc1497055f98bea140f4753d720a66191:
						c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame];
						break;
					}
					IL_314:
					if (c6114b34ba4893a53ebb4b599e0e2e3fc != null)
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
						ListViewDataItem listViewDataItem = new ListViewDataItem();
						cef6c0abffd4c77eb21f799d5eddaf127 cef6c0abffd4c77eb21f799d5eddaf;
						c793a8ac5c8e22138553e8edbe4f7092f.c6333b8d01cc2ac0ec4fe13624a14dfc7(ref cef6c0abffd4c77eb21f799d5eddaf);
						cef6c0abffd4c77eb21f799d5eddaf.ce982993aea6e7c98bde3b5ebab09d6fe = cbcbdbfc95367bfec4c11b371d883aa2d;
						cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716 = c6114b34ba4893a53ebb4b599e0e2e3fc;
						cef6c0abffd4c77eb21f799d5eddaf.c08f95d2c6b325a66160e456d3da3c9c9 = Path.GetDirectoryName(text);
						listViewDataItem.Tag = cef6c0abffd4c77eb21f799d5eddaf;
						ListViewDataItem listViewDataItem2 = listViewDataItem;
						if (c6114b34ba4893a53ebb4b599e0e2e3fc.ca435006c85356cb7385a782de8889a0a != c59ff87f6bdc69ff3440c18f170633236.c75de07cf35dca1805ba630578576f097)
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
							text2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66670);
							listViewDataItem2.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18160) != 0);
						}
						this.cee54c856c7e63e5fbea3d765715af7a0.Items.Add(listViewDataItem2);
						listViewDataItem2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18164)] = c6114b34ba4893a53ebb4b599e0e2e3fc.ToString();
						listViewDataItem2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18168)] = text2;
						goto IL_3D6;
					}
					goto IL_3D6;
					IL_2E4:
					c6114b34ba4893a53ebb4b599e0e2e3fc = c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[titleId.FullGame];
					goto IL_314;
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
				text2 = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66564);
				ListViewDataItem listViewDataItem3 = new ListViewDataItem();
				this.cee54c856c7e63e5fbea3d765715af7a0.Items.Add(listViewDataItem3);
				listViewDataItem3.Enabled = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18144) != 0);
				listViewDataItem3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18148)] = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66643), titleId.IdRaw);
				listViewDataItem3[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18152)] = text2;
				IL_3D6:;
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
			if (this.cee54c856c7e63e5fbea3d765715af7a0.Items.Count != 0)
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
				return;
			}
			RadMessageBox.Show(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66755));
			base.DialogResult = (DialogResult)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18176);
			base.Close();
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0003ACC4 File Offset: 0x00038EC4
		private void c363c53af07db4bf75c8d083a8983d695(string c42374f457c370ad8b927de710d6dae79, string c193850c1b9a788fb302353030312eaf4)
		{
			try
			{
				FileSystem.MoveFile(c42374f457c370ad8b927de710d6dae79, Path.Combine(c193850c1b9a788fb302353030312eaf4, new FileInfo(c42374f457c370ad8b927de710d6dae79).Name), (UIOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18180));
			}
			catch
			{
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0003AD0C File Offset: 0x00038F0C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cd72f04463e23d86b88073a95b804555a.Dispose(bool)).MethodHandle;
				}
				if (this.c66944218dc6924b147fbc6b0f72a424f != null)
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
					this.c66944218dc6924b147fbc6b0f72a424f.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0003AD54 File Offset: 0x00038F54
		private void c82b8091adcf720aa7a90631953c644c8()
		{
			ListViewDetailColumn listViewDetailColumn = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51927), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66854));
			ListViewDetailColumn listViewDetailColumn2 = new ListViewDetailColumn(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(51953), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66865));
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cc50fd4eb0ca1167864832d9d90242c2d.cde4d1aeffe0e705b07e1b3d74e931465()));
			this.cee54c856c7e63e5fbea3d765715af7a0 = new RadCheckedListBox();
			this.c4553ed186725b714efcccc71bbe10a0f = new RadLabel();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e = new RadLabel();
			this.ceefeeb905146bf2684e227ccf9dcbb43 = new RadButton();
			this.ca6c1cea062503a0a580756cf1f1f0961 = new RadGroupBox();
			this.c052ccf41a3ad1f787a00eeef2d674c87 = new RadLabel();
			this.c129f9645be9dc9fb646c5432e51db9a5 = new RadLabel();
			this.c362e39f066aef56acd25812b83e7da57 = new RadLabel();
			this.c4a31dd2abe6d27ce482d0a083dd7311f = new RadLabel();
			this.c0e7bde0280df56351440f1954d87e7a9 = new RadButton();
			this.cee54c856c7e63e5fbea3d765715af7a0.BeginInit();
			this.c4553ed186725b714efcccc71bbe10a0f.BeginInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.BeginInit();
			this.ceefeeb905146bf2684e227ccf9dcbb43.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.BeginInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.SuspendLayout();
			this.c052ccf41a3ad1f787a00eeef2d674c87.BeginInit();
			this.c129f9645be9dc9fb646c5432e51db9a5.BeginInit();
			this.c362e39f066aef56acd25812b83e7da57.BeginInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.BeginInit();
			this.c0e7bde0280df56351440f1954d87e7a9.BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.cee54c856c7e63e5fbea3d765715af7a0.AllowRemove = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18184) != 0);
			listViewDetailColumn.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66854);
			listViewDetailColumn.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18188);
			listViewDetailColumn2.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66865);
			listViewDetailColumn2.Width = cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18192);
			ListViewColumnCollection columns = this.cee54c856c7e63e5fbea3d765715af7a0.Columns;
			ListViewDetailColumn[] array = c6188cbae417ac84374cf19bfcad5d59b.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18196));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18200)] = listViewDetailColumn;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18204)] = listViewDetailColumn2;
			columns.AddRange(array);
			this.cee54c856c7e63e5fbea3d765715af7a0.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18208);
			this.cee54c856c7e63e5fbea3d765715af7a0.ItemSpacing = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18212);
			this.cee54c856c7e63e5fbea3d765715af7a0.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18216), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18220));
			this.cee54c856c7e63e5fbea3d765715af7a0.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66878);
			this.cee54c856c7e63e5fbea3d765715af7a0.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18224), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18228));
			this.cee54c856c7e63e5fbea3d765715af7a0.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18232);
			this.cee54c856c7e63e5fbea3d765715af7a0.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43485);
			this.cee54c856c7e63e5fbea3d765715af7a0.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.cee54c856c7e63e5fbea3d765715af7a0.ViewType = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18236);
			this.c4553ed186725b714efcccc71bbe10a0f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18240), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18244));
			this.c4553ed186725b714efcccc71bbe10a0f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42280);
			this.c4553ed186725b714efcccc71bbe10a0f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18248), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18252));
			this.c4553ed186725b714efcccc71bbe10a0f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18256);
			this.c4553ed186725b714efcccc71bbe10a0f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66897);
			this.c4553ed186725b714efcccc71bbe10a0f.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18260), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18264));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42388);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18268), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18272));
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18276);
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18280);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18284), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18288));
			this.ceefeeb905146bf2684e227ccf9dcbb43.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(66988);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18292), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18296));
			this.ceefeeb905146bf2684e227ccf9dcbb43.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18300);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67007);
			this.ceefeeb905146bf2684e227ccf9dcbb43.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.ceefeeb905146bf2684e227ccf9dcbb43.Click += this.cfb9fd2addd333e8c28d4aff66027ee10;
			this.ca6c1cea062503a0a580756cf1f1f0961.AccessibleRole = (AccessibleRole)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18304);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c052ccf41a3ad1f787a00eeef2d674c87);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c129f9645be9dc9fb646c5432e51db9a5);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c362e39f066aef56acd25812b83e7da57);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c4a31dd2abe6d27ce482d0a083dd7311f);
			this.ca6c1cea062503a0a580756cf1f1f0961.Controls.Add(this.c4553ed186725b714efcccc71bbe10a0f);
			this.ca6c1cea062503a0a580756cf1f1f0961.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18308);
			this.ca6c1cea062503a0a580756cf1f1f0961.HeaderText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.ca6c1cea062503a0a580756cf1f1f0961.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18312), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18316));
			this.ca6c1cea062503a0a580756cf1f1f0961.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(48088);
			this.ca6c1cea062503a0a580756cf1f1f0961.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18320), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18324));
			this.ca6c1cea062503a0a580756cf1f1f0961.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18328);
			this.ca6c1cea062503a0a580756cf1f1f0961.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49152);
			this.ca6c1cea062503a0a580756cf1f1f0961.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18332), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18336));
			this.c052ccf41a3ad1f787a00eeef2d674c87.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(49484);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18344));
			this.c052ccf41a3ad1f787a00eeef2d674c87.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18348);
			this.c052ccf41a3ad1f787a00eeef2d674c87.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67020);
			this.c052ccf41a3ad1f787a00eeef2d674c87.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c129f9645be9dc9fb646c5432e51db9a5.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18352), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18356));
			this.c129f9645be9dc9fb646c5432e51db9a5.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(62504);
			this.c129f9645be9dc9fb646c5432e51db9a5.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18360), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18364));
			this.c129f9645be9dc9fb646c5432e51db9a5.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18368);
			this.c129f9645be9dc9fb646c5432e51db9a5.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67147);
			this.c129f9645be9dc9fb646c5432e51db9a5.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c362e39f066aef56acd25812b83e7da57.ForeColor = Color.Red;
			this.c362e39f066aef56acd25812b83e7da57.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18372), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18376));
			this.c362e39f066aef56acd25812b83e7da57.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42983);
			this.c362e39f066aef56acd25812b83e7da57.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18380), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18384));
			this.c362e39f066aef56acd25812b83e7da57.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18388);
			this.c362e39f066aef56acd25812b83e7da57.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67299);
			this.c362e39f066aef56acd25812b83e7da57.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18392), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18396));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(42534);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18400), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18404));
			this.c4a31dd2abe6d27ce482d0a083dd7311f.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18408);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67418);
			this.c4a31dd2abe6d27ce482d0a083dd7311f.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c0e7bde0280df56351440f1954d87e7a9.Dock = (DockStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18412);
			this.c0e7bde0280df56351440f1954d87e7a9.Location = new Point(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18416), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18420));
			this.c0e7bde0280df56351440f1954d87e7a9.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67505);
			this.c0e7bde0280df56351440f1954d87e7a9.Size = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18424), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18428));
			this.c0e7bde0280df56351440f1954d87e7a9.TabIndex = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18432);
			this.c0e7bde0280df56351440f1954d87e7a9.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67528);
			this.c0e7bde0280df56351440f1954d87e7a9.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			this.c0e7bde0280df56351440f1954d87e7a9.Click += this.c46b6ded173670d3a80a210dd349eb95a;
			base.AutoScaleDimensions = new SizeF(cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18436), cebbdeae8341a51f374f3ef4c993a069a.cabf61ab14a85b3360133efd96ff22140(18440));
			base.AutoScaleMode = (AutoScaleMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18444);
			base.ClientSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18448), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18452));
			base.Controls.Add(this.cee54c856c7e63e5fbea3d765715af7a0);
			base.Controls.Add(this.c0e7bde0280df56351440f1954d87e7a9);
			base.Controls.Add(this.ceefeeb905146bf2684e227ccf9dcbb43);
			base.Controls.Add(this.ca6c1cea062503a0a580756cf1f1f0961);
			base.Controls.Add(this.c4fdf528cc4655fdd2d6b81f0d1928e8e);
			base.Icon = ccd80025a308fe111a2b56a5a34e1a7e7.cd24593c859565ebb8c9faabbc5c75bef(componentResourceManager.GetObject(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43131)));
			this.MinimumSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18456), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18460));
			base.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67549);
			base.Padding = new Padding(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18464));
			base.RootElement.ApplyShapeToControl = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18468) != 0);
			base.RootElement.MaxSize = new Size(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18472), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18476));
			base.StartPosition = (FormStartPosition)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18480);
			this.Text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(67568);
			base.ThemeName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(43564);
			base.Load += this.cef36783c8274edea6244951ed1ea1b7e;
			this.cee54c856c7e63e5fbea3d765715af7a0.EndInit();
			this.c4553ed186725b714efcccc71bbe10a0f.EndInit();
			this.c4fdf528cc4655fdd2d6b81f0d1928e8e.EndInit();
			this.ceefeeb905146bf2684e227ccf9dcbb43.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.EndInit();
			this.ca6c1cea062503a0a580756cf1f1f0961.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18484) != 0);
			this.ca6c1cea062503a0a580756cf1f1f0961.PerformLayout();
			this.c052ccf41a3ad1f787a00eeef2d674c87.EndInit();
			this.c129f9645be9dc9fb646c5432e51db9a5.EndInit();
			this.c362e39f066aef56acd25812b83e7da57.EndInit();
			this.c4a31dd2abe6d27ce482d0a083dd7311f.EndInit();
			this.c0e7bde0280df56351440f1954d87e7a9.EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(18488) != 0);
			base.PerformLayout();
		}

		// Token: 0x04000423 RID: 1059
		public List<c5409344e1c2b74fa8c9a4d620ccb8d48> cae64f5cf1ac3ad308dcd6ea8285230ae = new List<c5409344e1c2b74fa8c9a4d620ccb8d48>();

		// Token: 0x04000424 RID: 1060
		private readonly string cafa217929242adeb0ff634aed8ac34f0;

		// Token: 0x04000425 RID: 1061
		private IContainer c66944218dc6924b147fbc6b0f72a424f;

		// Token: 0x04000426 RID: 1062
		private RadCheckedListBox cee54c856c7e63e5fbea3d765715af7a0;

		// Token: 0x04000427 RID: 1063
		private RadLabel c4553ed186725b714efcccc71bbe10a0f;

		// Token: 0x04000428 RID: 1064
		private RadLabel c4fdf528cc4655fdd2d6b81f0d1928e8e;

		// Token: 0x04000429 RID: 1065
		private RadButton ceefeeb905146bf2684e227ccf9dcbb43;

		// Token: 0x0400042A RID: 1066
		private RadGroupBox ca6c1cea062503a0a580756cf1f1f0961;

		// Token: 0x0400042B RID: 1067
		private RadLabel c362e39f066aef56acd25812b83e7da57;

		// Token: 0x0400042C RID: 1068
		private RadLabel c4a31dd2abe6d27ce482d0a083dd7311f;

		// Token: 0x0400042D RID: 1069
		private RadButton c0e7bde0280df56351440f1954d87e7a9;

		// Token: 0x0400042E RID: 1070
		private RadLabel c052ccf41a3ad1f787a00eeef2d674c87;

		// Token: 0x0400042F RID: 1071
		private RadLabel c129f9645be9dc9fb646c5432e51db9a5;

		// Token: 0x02000165 RID: 357
		[CompilerGenerated]
		private sealed class cdb7b2d79f9dca333bf35c29225cd63da
		{
			// Token: 0x0600099C RID: 2460 RVA: 0x000608AC File Offset: 0x0005EAAC
			internal void c3207d0000188d4e5388b8acad65977c2()
			{
				cef6c0abffd4c77eb21f799d5eddaf127 cef6c0abffd4c77eb21f799d5eddaf = c9c36324383af5efe32cfc37aefd05a8e.cb93115e3b63933899699d0ee8696f152(this.c804bc52f7f79bffee6fd394ef382eb76.Tag);
				if (!this.c4404a159870bf55bb6f111e66e59e82d.cae64f5cf1ac3ad308dcd6ea8285230ae.Contains(c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.TitleId.FullGame]))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cd72f04463e23d86b88073a95b804555a.cdb7b2d79f9dca333bf35c29225cd63da.c3207d0000188d4e5388b8acad65977c2()).MethodHandle;
					}
					this.c4404a159870bf55bb6f111e66e59e82d.cae64f5cf1ac3ad308dcd6ea8285230ae.Add(c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64[cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.TitleId.FullGame]);
				}
				Directory.CreateDirectory(cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.OutputPath);
				cd161c587b229cb9747bf073c6e98b0b9[] ca41cd3b028585a369298639868832973 = cef6c0abffd4c77eb21f799d5eddaf.ce982993aea6e7c98bde3b5ebab09d6fe.ca41cd3b028585a369298639868832973;
				for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30748); i < (int)c6039f0790413b5e04707059b16777215.cfeb04651f165d0166e7c10ab1acf8b28(ca41cd3b028585a369298639868832973); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30752))
				{
					cd161c587b229cb9747bf073c6e98b0b9 cd161c587b229cb9747bf073c6e98b0b = ca41cd3b028585a369298639868832973[i];
					this.c4404a159870bf55bb6f111e66e59e82d.c363c53af07db4bf75c8d083a8983d695(Path.Combine(cef6c0abffd4c77eb21f799d5eddaf.c08f95d2c6b325a66160e456d3da3c9c9, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cd161c587b229cb9747bf073c6e98b0b.c644292fda0733c5b8003747ebe56e175, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299))), cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.OutputPath);
					this.c4404a159870bf55bb6f111e66e59e82d.c363c53af07db4bf75c8d083a8983d695(Path.Combine(cef6c0abffd4c77eb21f799d5eddaf.c08f95d2c6b325a66160e456d3da3c9c9, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(cd161c587b229cb9747bf073c6e98b0b.c644292fda0733c5b8003747ebe56e175, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6308))), cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.OutputPath);
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
				this.c4404a159870bf55bb6f111e66e59e82d.c363c53af07db4bf75c8d083a8983d695(Path.Combine(cef6c0abffd4c77eb21f799d5eddaf.c08f95d2c6b325a66160e456d3da3c9c9, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6259)), cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.OutputPath);
				this.c4404a159870bf55bb6f111e66e59e82d.c363c53af07db4bf75c8d083a8983d695(Path.Combine(cef6c0abffd4c77eb21f799d5eddaf.c08f95d2c6b325a66160e456d3da3c9c9, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767)), cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.OutputPath);
				this.c4404a159870bf55bb6f111e66e59e82d.c363c53af07db4bf75c8d083a8983d695(Path.Combine(cef6c0abffd4c77eb21f799d5eddaf.c08f95d2c6b325a66160e456d3da3c9c9, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6278)), cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.OutputPath);
				cef6c0abffd4c77eb21f799d5eddaf.cbff63bc76813d445bdebbfc2e5c01716.c7ff9b69ed99c1e935069737f80db9054();
			}

			// Token: 0x04000739 RID: 1849
			public ListViewDataItem c804bc52f7f79bffee6fd394ef382eb76;

			// Token: 0x0400073A RID: 1850
			public cd72f04463e23d86b88073a95b804555a c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000166 RID: 358
		[CompilerGenerated]
		private sealed class cb2edd72f5c24a98e665ed0aba5073b19
		{
			// Token: 0x0600099E RID: 2462 RVA: 0x00060AD4 File Offset: 0x0005ECD4
			internal void cac1a6ee2050de5f27a17fef2acf0b8fe()
			{
				try
				{
					this.c727ad0bf79a3dbabc9ec7018f2e78199 = Directory.GetFiles(this.c4404a159870bf55bb6f111e66e59e82d.cafa217929242adeb0ff634aed8ac34f0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767), (System.IO.SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30756));
				}
				catch
				{
				}
			}

			// Token: 0x0400073B RID: 1851
			public string[] c727ad0bf79a3dbabc9ec7018f2e78199;

			// Token: 0x0400073C RID: 1852
			public cd72f04463e23d86b88073a95b804555a c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000167 RID: 359
		[CompilerGenerated]
		private sealed class cef0d9a6dff0a80e0101dc8fff3170e31
		{
			// Token: 0x060009A0 RID: 2464 RVA: 0x00060B38 File Offset: 0x0005ED38
			internal bool c9b84fb92c525b314aa5f1523339706a3(c6a2f8acae5ff1a8a909193a5c5de6687 ced17f5fac5de96d8d690dac7cea067a7)
			{
				return c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ced17f5fac5de96d8d690dac7cea067a7.Version, this.cb9752ebbe18b2ad5c3dc365914dc024b.ToString());
			}

			// Token: 0x0400073D RID: 1853
			public ushort cb9752ebbe18b2ad5c3dc365914dc024b;
		}
	}
}
