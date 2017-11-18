using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using NusHelper;
using NusHelper.Server;

namespace A
{
	// Token: 0x0200002B RID: 43
	public static class c6a5e9b85d86b4e098a511017a1073d71
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000DD RID: 221 RVA: 0x0000A008 File Offset: 0x00008208
		// (remove) Token: 0x060000DE RID: 222 RVA: 0x0000A054 File Offset: 0x00008254
		public static event EventHandler<Exception> c1f84333d7942c2315ee42eb2b5f59625
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Exception> eventHandler = c6a5e9b85d86b4e098a511017a1073d71.c1f84333d7942c2315ee42eb2b5f59625;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = c4752e9f82839b466091b53b1b27929cc.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref c6a5e9b85d86b4e098a511017a1073d71.c1f84333d7942c2315ee42eb2b5f59625, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6a5e9b85d86b4e098a511017a1073d71.add_c1f84333d7942c2315ee42eb2b5f59625(EventHandler<Exception>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Exception> eventHandler = c6a5e9b85d86b4e098a511017a1073d71.c1f84333d7942c2315ee42eb2b5f59625;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = c4752e9f82839b466091b53b1b27929cc.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref c6a5e9b85d86b4e098a511017a1073d71.c1f84333d7942c2315ee42eb2b5f59625, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6a5e9b85d86b4e098a511017a1073d71.remove_c1f84333d7942c2315ee42eb2b5f59625(EventHandler<Exception>)).MethodHandle;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000A0A0 File Offset: 0x000082A0
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000A0B4 File Offset: 0x000082B4
		public static List<c5409344e1c2b74fa8c9a4d620ccb8d48> NewTitles { get; internal set; } = new List<c5409344e1c2b74fa8c9a4d620ccb8d48>();

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000A0C8 File Offset: 0x000082C8
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000A0DC File Offset: 0x000082DC
		public static List<c6a2f8acae5ff1a8a909193a5c5de6687> NewUpdates { get; internal set; } = new List<c6a2f8acae5ff1a8a909193a5c5de6687>();

		// Token: 0x060000E3 RID: 227 RVA: 0x0000A0F0 File Offset: 0x000082F0
		internal static void c9c5a4bb06ee4ba7fdce7850e42b680a9(Exception c08b391577522100e1046cacdb2283fb0)
		{
			EventHandler<Exception> eventHandler = c6a5e9b85d86b4e098a511017a1073d71.c1f84333d7942c2315ee42eb2b5f59625;
			if (eventHandler == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c6a5e9b85d86b4e098a511017a1073d71.c9c5a4bb06ee4ba7fdce7850e42b680a9(Exception)).MethodHandle;
				}
				return;
			}
			eventHandler(null, c08b391577522100e1046cacdb2283fb0);
		}

		// Token: 0x0400006D RID: 109
		public const string cdc462d7972fed41e9a305e3df833b094 = "This software is brought to you, free of charge, by Hikari06 (aka Kazegaya). If you have paid any amount of money (except donations of course) to obtain it you have been SCAMMED. Please demand a refund immediately and report the seller. The only offical places to download this software are the post on gbatemp.net as well as the official site wiiuusbhelper.com.";

		// Token: 0x0400006E RID: 110
		public const string c87f7545f0f6ac55633eed00f15d624ff = "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/";

		// Token: 0x0400006F RID: 111
		public const string cf8728285451dc1d70473b4a07f5a2781 = "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/";

		// Token: 0x04000070 RID: 112
		public const string cd679868e1655a15245af22ce48e8fcff = "http://cdn.wiiuusbhelper.com/wiiu/download/";

		// Token: 0x04000071 RID: 113
		public static readonly Dictionary<TitleId, c5409344e1c2b74fa8c9a4d620ccb8d48> cdf6d9c9c11df33b26da7f099398aff64 = new Dictionary<TitleId, c5409344e1c2b74fa8c9a4d620ccb8d48>();

		// Token: 0x04000072 RID: 114
		public static c5409344e1c2b74fa8c9a4d620ccb8d48 cfc010356f4abbfd6616a07cb36c09d69;

		// Token: 0x04000073 RID: 115
		public static c5409344e1c2b74fa8c9a4d620ccb8d48 cca9ff917fe281ce8adb390af187767ba;

		// Token: 0x04000074 RID: 116
		public static c5409344e1c2b74fa8c9a4d620ccb8d48 c7526f0cd997f7f6664e00009cd5c18a1;

		// Token: 0x04000075 RID: 117
		public static List<TitleId> cfa0453d3b4ceddc251b00992c05d2355 = new List<TitleId>();

		// Token: 0x04000076 RID: 118
		public static List<string> cd086372afa56d57a77509bb9fba66a52;

		// Token: 0x04000077 RID: 119
		public static bool cd97926c82fa3cae54a0afb338e5ca487 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3072) != 0;

		// Token: 0x04000078 RID: 120
		public static bool cc55f7f0034df77b96f2d07b4452a2c71 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3076) != 0;

		// Token: 0x04000079 RID: 121
		public static string c2eaf0dbe8bd11ef4cc2db5c557fe1f2f;

		// Token: 0x0400007A RID: 122
		public static List<c5409344e1c2b74fa8c9a4d620ccb8d48> cba492c136fe5dbb7b4a1e75e12490067 = new List<c5409344e1c2b74fa8c9a4d620ccb8d48>();

		// Token: 0x0400007B RID: 123
		public static c5409344e1c2b74fa8c9a4d620ccb8d48 c99ac45cfb12f02773ff8738dcbee1a4a;

		// Token: 0x0400007C RID: 124
		public static bool c4e279d2507652407e1d6d8d867af8361 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(3080) != 0;

		// Token: 0x0400007D RID: 125
		public static IPAddress c2e5d7b8edcbe8941f24d87ff3c4197fe = IPAddress.Parse(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3566));

		// Token: 0x0400007F RID: 127
		[CompilerGenerated]
		private static List<c5409344e1c2b74fa8c9a4d620ccb8d48> c04b9898de3c0baafb3dc93b932af665b;

		// Token: 0x04000080 RID: 128
		[CompilerGenerated]
		private static List<c6a2f8acae5ff1a8a909193a5c5de6687> c39808dbb6463ae4e3373d281a2dfb7c8;

		// Token: 0x04000081 RID: 129
		internal static readonly Dictionary<TitleId, cdb02a77cadec7790d5c7c433ab736a12.cfbcf84e3bd62575a5abcb876df342eb4> c42f758cd8472507f92089c00ec59e282 = new Dictionary<TitleId, cdb02a77cadec7790d5c7c433ab736a12.cfbcf84e3bd62575a5abcb876df342eb4>();

		// Token: 0x04000082 RID: 130
		internal static readonly Dictionary<TitleId, DbRow> cf35e41cb61fd81c8c697d3d88352a9f7 = new Dictionary<TitleId, DbRow>();

		// Token: 0x04000083 RID: 131
		internal static readonly Dictionary<TitleId, List<cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e>> cb361ddeb07e659a9e98515e1e625aaea = new Dictionary<TitleId, List<cdb02a77cadec7790d5c7c433ab736a12.c88be22e7b98870bdaf063358234dbd5e>>();

		// Token: 0x04000084 RID: 132
		internal static readonly List<c2b8ef1783ae572d19956814809070e24> c29f65ab0f6b6de174c408644bf172abe = new List<c2b8ef1783ae572d19956814809070e24>();

		// Token: 0x04000085 RID: 133
		internal static c6114b34ba4893a53ebb4b599e0e2e3fc ccb05366fd81f08047514caf61a20fda3;

		// Token: 0x04000086 RID: 134
		internal static string[] c1152591410dbe9c7e6a47a5d8b0a69b5;
	}
}
