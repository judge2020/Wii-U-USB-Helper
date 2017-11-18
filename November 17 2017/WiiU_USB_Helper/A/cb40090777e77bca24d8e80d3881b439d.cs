using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using NusHelper;
using NusHelper.Server;

namespace A
{
	// Token: 0x02000088 RID: 136
	internal class cb40090777e77bca24d8e80d3881b439d
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x000197CC File Offset: 0x000179CC
		public cb40090777e77bca24d8e80d3881b439d(string c163dcde01fbc21028efc7d8b71dea58a, string cee4584cccd1add7449358c77def61c7b, string cfb3d877e8a0d5221698c0542d310364e, string c7f19abd9146d40d0012f1ece53410cea)
		{
			this.c08685ee7f941db1450fa53aa73582c6c = c163dcde01fbc21028efc7d8b71dea58a;
			this.cf89f58d496153416df7df17edfca1b38 = cfb3d877e8a0d5221698c0542d310364e;
			this.c538e04269d4285c1d7702e67006b1235 = cee4584cccd1add7449358c77def61c7b;
			this.c8da09cb1a7e91059b90f39384c03a412 = c7f19abd9146d40d0012f1ece53410cea;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000197FC File Offset: 0x000179FC
		public List<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed> c463073137d619444f37f3b34ad884c70()
		{
			if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.cf89f58d496153416df7df17edfca1b38, ""))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb40090777e77bca24d8e80d3881b439d.c463073137d619444f37f3b34ad884c70()).MethodHandle;
				}
				return new List<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed>();
			}
			IEnumerable<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed> source = JsonConvert.DeserializeObject<List<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed>>(this.cf89f58d496153416df7df17edfca1b38);
			Func<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed, bool> predicate;
			if ((predicate = cb40090777e77bca24d8e80d3881b439d.<>c.c5e57be654d50df4c034b8f0b917ceb75) == null)
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
				predicate = (cb40090777e77bca24d8e80d3881b439d.<>c.c5e57be654d50df4c034b8f0b917ceb75 = new Func<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed, bool>(cb40090777e77bca24d8e80d3881b439d.<>c.cdfab1996eb8651828de2a4469aa3481e.c5878ee9e36ecf96a5f513773e54f58ba));
			}
			return source.Where(predicate).ToList<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed>();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001987C File Offset: 0x00017A7C
		private c5409344e1c2b74fa8c9a4d620ccb8d48 c7af5877c67711c66db9c103e324f6c90(TitleId c6635772b43d7433ef9f821ace0e92574, string ce7d298d73bab0df9bcfdc208996dceec, string c0ae48386f017a7b0f2f09804789f3cac, string c925dbfbdd530f02db1c238d83908ace4, DataSize c5db06f710879d10bd98fa2c1adf0deb8)
		{
			c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = new c5409344e1c2b74fa8c9a4d620ccb8d48(ce7d298d73bab0df9bcfdc208996dceec, c6635772b43d7433ef9f821ace0e92574, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10990), null, c5db06f710879d10bd98fa2c1adf0deb8, null, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10997), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11000), "", ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11021), (Platform)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6332), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6336));
			c5409344e1c2b74fa8c9a4d620ccb8d.CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6340) != 0);
			c5409344e1c2b74fa8c9a4d620ccb8d.TicketArray = c9538952b0224ea717b33e0e4e7ae98c5.c96134dbaf770717cf693cafad29ba9e3(c6635772b43d7433ef9f821ace0e92574.IdRaw, c925dbfbdd530f02db1c238d83908ace4, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6344));
			c5409344e1c2b74fa8c9a4d620ccb8d.c88d6390a80f08a2c7ac4a268c95a94a2 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(c0ae48386f017a7b0f2f09804789f3cac);
			c5409344e1c2b74fa8c9a4d620ccb8d.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(c5409344e1c2b74fa8c9a4d620ccb8d.TicketArray, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6348));
			c5409344e1c2b74fa8c9a4d620ccb8d.Ticket.cc0eab3c8af7b4aa29c084139a1df3c14 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(c0ae48386f017a7b0f2f09804789f3cac);
			return c5409344e1c2b74fa8c9a4d620ccb8d;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00019950 File Offset: 0x00017B50
		public void cce9af53283cfef7a284b260db9a1d817()
		{
			cb40090777e77bca24d8e80d3881b439d.c25b9a75cc8ada58a488f6f9d08f0ea41 c25b9a75cc8ada58a488f6f9d08f0ea = new cb40090777e77bca24d8e80d3881b439d.c25b9a75cc8ada58a488f6f9d08f0ea41();
			c25b9a75cc8ada58a488f6f9d08f0ea.c4404a159870bf55bb6f111e66e59e82d = this;
			c25b9a75cc8ada58a488f6f9d08f0ea.cf80aed8e439da0ff41b571df22072ddc = new c60797b4f8bfa489df1954dcdc88ad77d(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11126), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6352) != 0);
			Task.Run(new Action(c25b9a75cc8ada58a488f6f9d08f0ea.c98eebf06440cb6df9188594cb10de556));
			c25b9a75cc8ada58a488f6f9d08f0ea.cf80aed8e439da0ff41b571df22072ddc.TopMost = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6356) != 0);
			c25b9a75cc8ada58a488f6f9d08f0ea.cf80aed8e439da0ff41b571df22072ddc.ShowDialog();
			if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c8da09cb1a7e91059b90f39384c03a412, ""))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cb40090777e77bca24d8e80d3881b439d.cce9af53283cfef7a284b260db9a1d817()).MethodHandle;
				}
				return;
			}
			List<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067> list = JsonConvert.DeserializeObject<List<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067>>(this.c8da09cb1a7e91059b90f39384c03a412);
			IEnumerable<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067> source = list;
			Func<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067, bool> predicate;
			if ((predicate = cb40090777e77bca24d8e80d3881b439d.<>c.cc16ad3556d7cc4d24b7e23130bbe29bd) == null)
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
				predicate = (cb40090777e77bca24d8e80d3881b439d.<>c.cc16ad3556d7cc4d24b7e23130bbe29bd = new Func<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067, bool>(cb40090777e77bca24d8e80d3881b439d.<>c.cdfab1996eb8651828de2a4469aa3481e.cd580d14bab556f9c01e206d2d5212eb5));
			}
			IEnumerator<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067> enumerator = source.Where(predicate).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067 cbf04caf97637135b09eb86e = enumerator.Current;
					TitleId key = new TitleId(cbf04caf97637135b09eb86e.titleID);
					if (c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.ContainsKey(key))
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
						for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6360); i < c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea[key].Count; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6364))
						{
							cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e c88be22e7b98870bdaf063358234dbd5e = c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea[key][i];
							c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea[key][i] = new cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e
							{
								c029cb26b0aae604f5c2d4c53cbc49f62 = c88be22e7b98870bdaf063358234dbd5e.c029cb26b0aae604f5c2d4c53cbc49f62,
								cced90bbc7aa0995aa10924a12b207d73 = c88be22e7b98870bdaf063358234dbd5e.cced90bbc7aa0995aa10924a12b207d73,
								c0b9a995f9c2313cad22315173d49b769 = c88be22e7b98870bdaf063358234dbd5e.c0b9a995f9c2313cad22315173d49b769,
								cc0eab3c8af7b4aa29c084139a1df3c14 = cbf04caf97637135b09eb86e.titleKey,
								c00bbf2c37f24662356c32f585e666e5a = cbf04caf97637135b09eb86e.encTitleKey
							};
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
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			IEnumerable<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067> source2 = list;
			Func<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067, bool> predicate2;
			if ((predicate2 = cb40090777e77bca24d8e80d3881b439d.<>c.c283481ed2d44c2e66e4f4ca83f91d315) == null)
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
				predicate2 = (cb40090777e77bca24d8e80d3881b439d.<>c.c283481ed2d44c2e66e4f4ca83f91d315 = new Func<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067, bool>(cb40090777e77bca24d8e80d3881b439d.<>c.cdfab1996eb8651828de2a4469aa3481e.c69d0e06125bfb610453cb82e92aedf3e));
			}
			enumerator = source2.Where(predicate2).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067 cbf04caf97637135b09eb86e2 = enumerator.Current;
					TitleId titleId = new TitleId(cbf04caf97637135b09eb86e2.titleID);
					if (c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282.ContainsKey(titleId))
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
						cdb02a77cadec7790d5c7c433ab736a12.cfbcf84e3bd62575a5abcb876df342eb4 cfbcf84e3bd62575a5abcb876df342eb = c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282[titleId];
						string c12d0d8e4a348d50592ec186ea66a67ef = HttpUtility.HtmlDecode(cbf04caf97637135b09eb86e2.name.Trim()).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11207), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11210));
						string cc3f904a2c5ba8f87204592c77530a0a = cbf04caf97637135b09eb86e2.region.Trim();
						c2b8ef1783ae572d19956814809070e24 c2b8ef1783ae572d19956814809070e = new c2b8ef1783ae572d19956814809070e24(c12d0d8e4a348d50592ec186ea66a67ef, titleId, cc3f904a2c5ba8f87204592c77530a0a, null, cfbcf84e3bd62575a5abcb876df342eb.c029cb26b0aae604f5c2d4c53cbc49f62, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6368))
						{
							CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6372) != 0)
						};
						c2b8ef1783ae572d19956814809070e.TicketArray = c9538952b0224ea717b33e0e4e7ae98c5.c96134dbaf770717cf693cafad29ba9e3(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId), cbf04caf97637135b09eb86e2.encTitleKey, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6376));
						c2b8ef1783ae572d19956814809070e.c88d6390a80f08a2c7ac4a268c95a94a2 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(cbf04caf97637135b09eb86e2.titleKey);
						c2b8ef1783ae572d19956814809070e.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(c2b8ef1783ae572d19956814809070e.TicketArray, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6380));
						c2b8ef1783ae572d19956814809070e.Ticket.cc0eab3c8af7b4aa29c084139a1df3c14 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(cbf04caf97637135b09eb86e2.titleKey);
						c6a5e9b85d86b4e098a511017a1073d71.c29f65ab0f6b6de174c408644bf172abe.Add(c2b8ef1783ae572d19956814809070e);
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
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			IEnumerable<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067> source3 = list;
			Func<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067, bool> predicate3;
			if ((predicate3 = cb40090777e77bca24d8e80d3881b439d.<>c.cfd7bc47819467c4407e9d54f961569a3) == null)
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
				predicate3 = (cb40090777e77bca24d8e80d3881b439d.<>c.cfd7bc47819467c4407e9d54f961569a3 = new Func<cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067, bool>(cb40090777e77bca24d8e80d3881b439d.<>c.cdfab1996eb8651828de2a4469aa3481e.cf71c0ec1ec88149399d2d48f0605814f));
			}
			enumerator = source3.Where(predicate3).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					cb40090777e77bca24d8e80d3881b439d.cbf04caf97637135b09eb86e521918067 cbf04caf97637135b09eb86e3 = enumerator.Current;
					TitleId titleId2 = new TitleId(cbf04caf97637135b09eb86e3.titleID);
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId2.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11213)))
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
						c6a5e9b85d86b4e098a511017a1073d71.c99ac45cfb12f02773ff8738dcbee1a4a = this.c7af5877c67711c66db9c103e324f6c90(titleId2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11246), cbf04caf97637135b09eb86e3.titleKey, cbf04caf97637135b09eb86e3.encTitleKey, new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6384))));
					}
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId2.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11269)))
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
						c6a5e9b85d86b4e098a511017a1073d71.cfc010356f4abbfd6616a07cb36c09d69 = this.c7af5877c67711c66db9c103e324f6c90(titleId2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11302), cbf04caf97637135b09eb86e3.titleKey, cbf04caf97637135b09eb86e3.encTitleKey, new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6388))));
					}
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId2.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11321)))
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
						c6a5e9b85d86b4e098a511017a1073d71.cca9ff917fe281ce8adb390af187767ba = this.c7af5877c67711c66db9c103e324f6c90(titleId2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11354), cbf04caf97637135b09eb86e3.titleKey, cbf04caf97637135b09eb86e3.encTitleKey, new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6392))));
					}
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId2.IdRaw, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11373)))
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
						c6a5e9b85d86b4e098a511017a1073d71.c7526f0cd997f7f6664e00009cd5c18a1 = (c6a5e9b85d86b4e098a511017a1073d71.cca9ff917fe281ce8adb390af187767ba = this.c7af5877c67711c66db9c103e324f6c90(titleId2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11406), cbf04caf97637135b09eb86e3.titleKey, cbf04caf97637135b09eb86e3.encTitleKey, new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6396)))));
					}
					if (titleId2.IdType != (c4646e2a6e2ad7e5620e9ecf229259217)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6400))
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
						if (titleId2.IdType != (c4646e2a6e2ad7e5620e9ecf229259217)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6404))
						{
							continue;
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
					if (c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7.ContainsKey(titleId2))
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
						DbRow dbRow = c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId2];
						string c12d0d8e4a348d50592ec186ea66a67ef2 = HttpUtility.HtmlDecode(cbf04caf97637135b09eb86e3.name.Trim()).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11207), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11210));
						string cc3f904a2c5ba8f87204592c77530a0a2 = cbf04caf97637135b09eb86e3.region.Trim();
						List<c6a2f8acae5ff1a8a909193a5c5de6687> list2 = new List<c6a2f8acae5ff1a8a909193a5c5de6687>();
						if (c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.ContainsKey(new TitleId(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId2.FullUpdate))))
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
							using (List<cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e>.Enumerator enumerator2 = c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea[titleId2.FullUpdate].GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e c88be22e7b98870bdaf063358234dbd5e2 = enumerator2.Current;
									if (c88be22e7b98870bdaf063358234dbd5e2.cc0eab3c8af7b4aa29c084139a1df3c14 != null)
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
										if (c88be22e7b98870bdaf063358234dbd5e2.c00bbf2c37f24662356c32f585e666e5a != null)
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
											c6a2f8acae5ff1a8a909193a5c5de6687 c6a2f8acae5ff1a8a909193a5c5de = new c6a2f8acae5ff1a8a909193a5c5de6687(c12d0d8e4a348d50592ec186ea66a67ef2, c88be22e7b98870bdaf063358234dbd5e2.cced90bbc7aa0995aa10924a12b207d73, cc3f904a2c5ba8f87204592c77530a0a2, null, c88be22e7b98870bdaf063358234dbd5e2.c029cb26b0aae604f5c2d4c53cbc49f62, c88be22e7b98870bdaf063358234dbd5e2.c0b9a995f9c2313cad22315173d49b769, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6408))
											{
												CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6412) != 0)
											};
											c6a2f8acae5ff1a8a909193a5c5de.TicketArray = c9538952b0224ea717b33e0e4e7ae98c5.c96134dbaf770717cf693cafad29ba9e3(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c88be22e7b98870bdaf063358234dbd5e2.cced90bbc7aa0995aa10924a12b207d73), c88be22e7b98870bdaf063358234dbd5e2.c00bbf2c37f24662356c32f585e666e5a, int.Parse(c88be22e7b98870bdaf063358234dbd5e2.c0b9a995f9c2313cad22315173d49b769));
											c6a2f8acae5ff1a8a909193a5c5de.c88d6390a80f08a2c7ac4a268c95a94a2 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(c88be22e7b98870bdaf063358234dbd5e2.cc0eab3c8af7b4aa29c084139a1df3c14);
											c6a2f8acae5ff1a8a909193a5c5de.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(c6a2f8acae5ff1a8a909193a5c5de.TicketArray, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6416));
											c6a2f8acae5ff1a8a909193a5c5de.Ticket.cc0eab3c8af7b4aa29c084139a1df3c14 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(c88be22e7b98870bdaf063358234dbd5e2.cc0eab3c8af7b4aa29c084139a1df3c14);
											list2.Add(c6a2f8acae5ff1a8a909193a5c5de);
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
						c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = new c5409344e1c2b74fa8c9a4d620ccb8d48(c12d0d8e4a348d50592ec186ea66a67ef2, titleId2, dbRow.Region, null, dbRow.Size, list2, dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11021), dbRow.Platform, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6420))
						{
							CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6424) != 0)
						};
						c5409344e1c2b74fa8c9a4d620ccb8d.TicketArray = c9538952b0224ea717b33e0e4e7ae98c5.c96134dbaf770717cf693cafad29ba9e3(titleId2.IdRaw, cbf04caf97637135b09eb86e3.encTitleKey, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6428));
						c5409344e1c2b74fa8c9a4d620ccb8d.c88d6390a80f08a2c7ac4a268c95a94a2 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(cbf04caf97637135b09eb86e3.titleKey);
						c5409344e1c2b74fa8c9a4d620ccb8d.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(c5409344e1c2b74fa8c9a4d620ccb8d.TicketArray, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6432));
						c5409344e1c2b74fa8c9a4d620ccb8d.Ticket.cc0eab3c8af7b4aa29c084139a1df3c14 = cd4880843d42f3dd634ca35c8e909b573.c6507f192257143b77a08ca9528ea8b8c(cbf04caf97637135b09eb86e3.titleKey);
						c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Add(titleId2, c5409344e1c2b74fa8c9a4d620ccb8d);
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

		// Token: 0x04000258 RID: 600
		private readonly string c8da09cb1a7e91059b90f39384c03a412;

		// Token: 0x04000259 RID: 601
		private readonly string cf89f58d496153416df7df17edfca1b38;

		// Token: 0x0400025A RID: 602
		private readonly string c538e04269d4285c1d7702e67006b1235;

		// Token: 0x0400025B RID: 603
		private readonly string c08685ee7f941db1450fa53aa73582c6c;

		// Token: 0x02000120 RID: 288
		internal class cbf04caf97637135b09eb86e521918067
		{
			// Token: 0x17000201 RID: 513
			// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0005CEB4 File Offset: 0x0005B0B4
			// (set) Token: 0x060008D2 RID: 2258 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
			public string encTitleKey { get; set; }

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0005CEDC File Offset: 0x0005B0DC
			// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0005CEF0 File Offset: 0x0005B0F0
			public string name { get; set; }

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0005CF04 File Offset: 0x0005B104
			// (set) Token: 0x060008D6 RID: 2262 RVA: 0x0005CF18 File Offset: 0x0005B118
			public string region { get; set; }

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0005CF2C File Offset: 0x0005B12C
			// (set) Token: 0x060008D8 RID: 2264 RVA: 0x0005CF40 File Offset: 0x0005B140
			public string serial { get; set; }

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0005CF54 File Offset: 0x0005B154
			// (set) Token: 0x060008DA RID: 2266 RVA: 0x0005CF68 File Offset: 0x0005B168
			public object size { get; set; }

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x060008DB RID: 2267 RVA: 0x0005CF7C File Offset: 0x0005B17C
			// (set) Token: 0x060008DC RID: 2268 RVA: 0x0005CF90 File Offset: 0x0005B190
			public string titleID { get; set; }

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x060008DD RID: 2269 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
			// (set) Token: 0x060008DE RID: 2270 RVA: 0x0005CFB8 File Offset: 0x0005B1B8
			public string titleKey { get; set; }

			// Token: 0x04000674 RID: 1652
			[CompilerGenerated]
			private string cc05e3a8a8a8c96a38044222e779fa523;

			// Token: 0x04000675 RID: 1653
			[CompilerGenerated]
			private string cc83ab7ace4e8da2683e6eb0d09c083dc;

			// Token: 0x04000676 RID: 1654
			[CompilerGenerated]
			private string c0b3da1f34c16c0350859be6ea721e170;

			// Token: 0x04000677 RID: 1655
			[CompilerGenerated]
			private string c19586fbf91f2d75bf0c26341d1421baa;

			// Token: 0x04000678 RID: 1656
			[CompilerGenerated]
			private object c91c6116290a97620d68880a733777f23;

			// Token: 0x04000679 RID: 1657
			[CompilerGenerated]
			private string cebcd10de7891c37a04514046ecab4c00;

			// Token: 0x0400067A RID: 1658
			[CompilerGenerated]
			private string c8ce4a1d9ef31d8f3cddb018e23bcd426;
		}

		// Token: 0x02000121 RID: 289
		internal class c716ebbcdf98fa5974ff7fe646c3a55ed
		{
			// Token: 0x17000208 RID: 520
			// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0005CFE0 File Offset: 0x0005B1E0
			// (set) Token: 0x060008E1 RID: 2273 RVA: 0x0005CFF4 File Offset: 0x0005B1F4
			public string name { get; set; }

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0005D008 File Offset: 0x0005B208
			// (set) Token: 0x060008E3 RID: 2275 RVA: 0x0005D01C File Offset: 0x0005B21C
			public string region { get; set; }

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0005D030 File Offset: 0x0005B230
			// (set) Token: 0x060008E5 RID: 2277 RVA: 0x0005D044 File Offset: 0x0005B244
			public string ticket { get; set; }

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0005D058 File Offset: 0x0005B258
			// (set) Token: 0x060008E7 RID: 2279 RVA: 0x0005D06C File Offset: 0x0005B26C
			public string titleID { get; set; }

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0005D080 File Offset: 0x0005B280
			// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0005D094 File Offset: 0x0005B294
			public string titleKey { get; set; }

			// Token: 0x0400067B RID: 1659
			[CompilerGenerated]
			private string cc83ab7ace4e8da2683e6eb0d09c083dc;

			// Token: 0x0400067C RID: 1660
			[CompilerGenerated]
			private string c0b3da1f34c16c0350859be6ea721e170;

			// Token: 0x0400067D RID: 1661
			[CompilerGenerated]
			private string c870e477db9664a13e35d84e3899f33da;

			// Token: 0x0400067E RID: 1662
			[CompilerGenerated]
			private string cebcd10de7891c37a04514046ecab4c00;

			// Token: 0x0400067F RID: 1663
			[CompilerGenerated]
			private string c8ce4a1d9ef31d8f3cddb018e23bcd426;
		}

		// Token: 0x02000123 RID: 291
		[CompilerGenerated]
		private sealed class c25b9a75cc8ada58a488f6f9d08f0ea41
		{
			// Token: 0x060008F3 RID: 2291 RVA: 0x0005D3B8 File Offset: 0x0005B5B8
			internal void c98eebf06440cb6df9188594cb10de556()
			{
				bool flag = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30268) != 0;
				ce07c379a1090dd9de869aa5e3a694e98.c639a106f7d220ed90d0c1210ca33d844();
				string text = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5880));
				Directory.CreateDirectory(text);
				List<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed> list = this.c4404a159870bf55bb6f111e66e59e82d.c463073137d619444f37f3b34ad884c70();
				IEnumerable<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed> source = list;
				Func<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed, bool> predicate;
				if ((predicate = cb40090777e77bca24d8e80d3881b439d.<>c.cc6bc90bf71aefcda6c0d7eb382c335c0) == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cb40090777e77bca24d8e80d3881b439d.c25b9a75cc8ada58a488f6f9d08f0ea41.c98eebf06440cb6df9188594cb10de556()).MethodHandle;
					}
					predicate = (cb40090777e77bca24d8e80d3881b439d.<>c.cc6bc90bf71aefcda6c0d7eb382c335c0 = new Func<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed, bool>(cb40090777e77bca24d8e80d3881b439d.<>c.cdfab1996eb8651828de2a4469aa3481e.c16b4c3913a5d0b53bfff1ef6f0d4cb4e));
				}
				int num = source.Count(predicate);
				int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30272);
				IEnumerable<KeyValuePair<TitleId, DbRow>> cf35e41cb61fd81c8c697d3d88352a9f = c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7;
				Func<KeyValuePair<TitleId, DbRow>, bool> predicate2;
				if ((predicate2 = cb40090777e77bca24d8e80d3881b439d.<>c.c90a9023a7b2e6e024403044ee43c43ce) == null)
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
					predicate2 = (cb40090777e77bca24d8e80d3881b439d.<>c.c90a9023a7b2e6e024403044ee43c43ce = new Func<KeyValuePair<TitleId, DbRow>, bool>(cb40090777e77bca24d8e80d3881b439d.<>c.cdfab1996eb8651828de2a4469aa3481e.c2af63502c5f2f21b74c0fbb9ba3aaa34));
				}
				IEnumerator<KeyValuePair<TitleId, DbRow>> enumerator = cf35e41cb61fd81c8c697d3d88352a9f.Where(predicate2).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<TitleId, DbRow> keyValuePair = enumerator.Current;
						DbRow value = keyValuePair.Value;
						c5409344e1c2b74fa8c9a4d620ccb8d48 value2 = new c5409344e1c2b74fa8c9a4d620ccb8d48(value.Name, value.TitleId, value.Region, null, value.Size, new List<c6a2f8acae5ff1a8a909193a5c5de6687>(), value.EshopId, value.ProductCode, value.IconUrl, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98067), value.Platform, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30276))
						{
							CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30280) != 0)
						};
						c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Add(value.TitleId, value2);
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
				finally
				{
					if (enumerator != null)
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
						enumerator.Dispose();
					}
				}
				using (List<cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						cb40090777e77bca24d8e80d3881b439d.c716ebbcdf98fa5974ff7fe646c3a55ed c716ebbcdf98fa5974ff7fe646c3a55ed = enumerator2.Current;
						cb40090777e77bca24d8e80d3881b439d.c7198742693d06e9253663787ca482aa0 c7198742693d06e9253663787ca482aa = new cb40090777e77bca24d8e80d3881b439d.c7198742693d06e9253663787ca482aa0();
						TitleId titleId = new TitleId(c716ebbcdf98fa5974ff7fe646c3a55ed.titleID.Trim());
						string titleKey = c716ebbcdf98fa5974ff7fe646c3a55ed.titleKey;
						string text2;
						if (titleKey == null)
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
							text2 = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
						}
						else
						{
							text2 = titleKey.Trim();
						}
						string text3 = text2;
						c7198742693d06e9253663787ca482aa.ce7d298d73bab0df9bcfdc208996dceec = HttpUtility.HtmlDecode(c716ebbcdf98fa5974ff7fe646c3a55ed.name.Trim()).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11207), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11210));
						c7198742693d06e9253663787ca482aa.cc3f904a2c5ba8f87204592c77530a0a6 = c716ebbcdf98fa5974ff7fe646c3a55ed.region.Trim();
						if (c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7.ContainsKey(titleId.FullGame))
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
							DbRow dbRow = c6a5e9b85d86b4e098a511017a1073d71.cf35e41cb61fd81c8c697d3d88352a9f7[titleId.FullGame];
							c4646e2a6e2ad7e5620e9ecf229259217 idType = titleId.IdType;
							if (idType != (c4646e2a6e2ad7e5620e9ecf229259217)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30284))
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
								if (idType != (c4646e2a6e2ad7e5620e9ecf229259217)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30288))
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
								}
								else if (c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282.ContainsKey(titleId))
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
									byte[] c2bdc0253794dde45b70b2d85ceddacde = c9538952b0224ea717b33e0e4e7ae98c5.ca2730dc934b9cae0800f2e13849880ee(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId), text3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30340), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30344) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30348) != 0);
									c2b8ef1783ae572d19956814809070e24 item = new c2b8ef1783ae572d19956814809070e24(c7198742693d06e9253663787ca482aa.ce7d298d73bab0df9bcfdc208996dceec, titleId, c7198742693d06e9253663787ca482aa.cc3f904a2c5ba8f87204592c77530a0a6, c2bdc0253794dde45b70b2d85ceddacde, c6a5e9b85d86b4e098a511017a1073d71.c42f758cd8472507f92089c00ec59e282[titleId].c029cb26b0aae604f5c2d4c53cbc49f62, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30352))
									{
										CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30356) != 0)
									};
									c6a5e9b85d86b4e098a511017a1073d71.c29f65ab0f6b6de174c408644bf172abe.Add(item);
								}
							}
							else
							{
								List<c6a2f8acae5ff1a8a909193a5c5de6687> list2 = new List<c6a2f8acae5ff1a8a909193a5c5de6687>();
								if (c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea.ContainsKey(new TitleId(c27149d2c37c4a21b17fc94e970c55ec7.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(titleId.FullUpdate))))
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
									list2.AddRange(c6a5e9b85d86b4e098a511017a1073d71.cb361ddeb07e659a9e98515e1e625aaea[titleId.FullUpdate].Select(new Func<cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e, c6a2f8acae5ff1a8a909193a5c5de6687>(c7198742693d06e9253663787ca482aa.ccf2a138a189015e37745a272b3a5a57b)));
								}
								c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d = new c5409344e1c2b74fa8c9a4d620ccb8d48(c7198742693d06e9253663787ca482aa.ce7d298d73bab0df9bcfdc208996dceec, titleId, c7198742693d06e9253663787ca482aa.cc3f904a2c5ba8f87204592c77530a0a6, null, dbRow.Size, list2, dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), dbRow.Platform, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30292));
								bool discOnly;
								if (!dbRow.DiscOnly)
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
									discOnly = (text3 == cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9);
								}
								else
								{
									discOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30296) != 0);
								}
								c5409344e1c2b74fa8c9a4d620ccb8d.DiscOnly = discOnly;
								c5409344e1c2b74fa8c9a4d620ccb8d48 c5409344e1c2b74fa8c9a4d620ccb8d2 = c5409344e1c2b74fa8c9a4d620ccb8d;
								if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c716ebbcdf98fa5974ff7fe646c3a55ed.ticket, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98064)))
								{
									goto IL_552;
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
								Platform[] array = c23355a94bfad5e025bd92d5dd735da36.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30300));
								RuntimeHelpers.InitializeArray(array, fieldof(ce5aad7d87667873eee3134c0bd54fb2c.ccc65f4a7db8a08e6dc1dae146cda06a5).FieldHandle);
								if (array.Contains(dbRow.Platform))
								{
									goto IL_552;
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
								if (c6a5e9b85d86b4e098a511017a1073d71.cd086372afa56d57a77509bb9fba66a52.Contains(c716ebbcdf98fa5974ff7fe646c3a55ed.titleID.ToUpper()))
								{
									goto IL_552;
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
								string text4 = c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(98154), this.c4404a159870bf55bb6f111e66e59e82d.c08685ee7f941db1450fa53aa73582c6c), c716ebbcdf98fa5974ff7fe646c3a55ed.titleID, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5895));
								c5409344e1c2b74fa8c9a4d620ccb8d2.cf7f2b1967398c4cc0c607544f80499bc = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30304) != 0);
								c5409344e1c2b74fa8c9a4d620ccb8d2.cad1dd58d3844f8fa6ceed9a0fcd16398 = text4;
								string text5 = Path.Combine(text, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c716ebbcdf98fa5974ff7fe646c3a55ed.titleID.ToUpper(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(5895)));
								if (flag)
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
									if (File.Exists(text5))
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
										if (new FileInfo(text5).Length != 0L)
										{
											goto IL_522;
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
									new WebClient().DownloadFile(text4, text5);
								}
								IL_522:
								num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30308);
								this.cf80aed8e439da0ff41b571df22072ddc.cf1cbd6c013fa578db4f915226e6472b7((int)((double)num2 / (double)num * cebbdeae8341a51f374f3ef4c993a069a.c939ab866f16e312f9914e20d87206d56(30312)));
								IL_5CB:
								c6a5e9b85d86b4e098a511017a1073d71.cdf6d9c9c11df33b26da7f099398aff64.Add(titleId, c5409344e1c2b74fa8c9a4d620ccb8d2);
								continue;
								IL_552:
								if (text3 != null)
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
									byte[] ticketArray = c9538952b0224ea717b33e0e4e7ae98c5.ca2730dc934b9cae0800f2e13849880ee(titleId.IdRaw, text3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30320), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30324) != 0, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30328) != 0);
									c5409344e1c2b74fa8c9a4d620ccb8d2.CfwOnly = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30332) != 0);
									c5409344e1c2b74fa8c9a4d620ccb8d2.TicketArray = ticketArray;
									c5409344e1c2b74fa8c9a4d620ccb8d2.Ticket = c9538952b0224ea717b33e0e4e7ae98c5.cca035b5773e1c7bd4eb2ebb87879807e(c5409344e1c2b74fa8c9a4d620ccb8d2.TicketArray, (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30336));
									goto IL_5CB;
								}
								goto IL_5CB;
							}
						}
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
				this.cf80aed8e439da0ff41b571df22072ddc.cc5957c0b466d791dc387469fda39883c();
			}

			// Token: 0x04000687 RID: 1671
			public c60797b4f8bfa489df1954dcdc88ad77d cf80aed8e439da0ff41b571df22072ddc;

			// Token: 0x04000688 RID: 1672
			public cb40090777e77bca24d8e80d3881b439d c4404a159870bf55bb6f111e66e59e82d;
		}

		// Token: 0x02000124 RID: 292
		[CompilerGenerated]
		private sealed class c7198742693d06e9253663787ca482aa0
		{
			// Token: 0x060008F5 RID: 2293 RVA: 0x0005DACC File Offset: 0x0005BCCC
			internal c6a2f8acae5ff1a8a909193a5c5de6687 ccf2a138a189015e37745a272b3a5a57b(cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e c3d3f8be678d55ec756d5d3661ff98846)
			{
				return new c6a2f8acae5ff1a8a909193a5c5de6687(this.ce7d298d73bab0df9bcfdc208996dceec, c3d3f8be678d55ec756d5d3661ff98846.cced90bbc7aa0995aa10924a12b207d73, this.cc3f904a2c5ba8f87204592c77530a0a6, null, c3d3f8be678d55ec756d5d3661ff98846.c029cb26b0aae604f5c2d4c53cbc49f62, c3d3f8be678d55ec756d5d3661ff98846.c0b9a995f9c2313cad22315173d49b769, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3002), (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(30360));
			}

			// Token: 0x04000689 RID: 1673
			public string ce7d298d73bab0df9bcfdc208996dceec;

			// Token: 0x0400068A RID: 1674
			public string cc3f904a2c5ba8f87204592c77530a0a6;
		}
	}
}
