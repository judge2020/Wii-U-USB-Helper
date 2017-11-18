using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Alphaleonis.Win32.Filesystem;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using Telerik.WinControls;

namespace A
{
	// Token: 0x02000089 RID: 137
	public abstract class c4c1cf20119750bfee2a0bb499f990883
	{
		// Token: 0x060003FC RID: 1020 RVA: 0x0001A2CC File Offset: 0x000184CC
		protected c4c1cf20119750bfee2a0bb499f990883(c5409344e1c2b74fa8c9a4d620ccb8d48 ce6591d75ff64e43faf8c563a2a657abe)
		{
			this.WorkPath = ce6591d75ff64e43faf8c563a2a657abe.c2ad07a436599cb91427b2e5fc8b7d4e5;
			this.ToInject = ce6591d75ff64e43faf8c563a2a657abe;
			if (!c4c1cf20119750bfee2a0bb499f990883.c708cf006cf52fddbe76aea65e3f552b0)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883..ctor(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				if (c4c1cf20119750bfee2a0bb499f990883.cbfd2993ac65bfcb50a33504559efa52a() == null)
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
					throw new FileNotFoundException(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12474));
				}
			}
			this.Name = this.ToInject.Name;
			try
			{
				this.Name = this.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12519)).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12528), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11207));
			}
			catch
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060003FD RID: 1021 RVA: 0x0001A3CC File Offset: 0x000185CC
		// (remove) Token: 0x060003FE RID: 1022 RVA: 0x0001A41C File Offset: 0x0001861C
		public event EventHandler cf17bde800c5bc0fdb2c1a7449fe20155
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.cf17bde800c5bc0fdb2c1a7449fe20155;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.cf17bde800c5bc0fdb2c1a7449fe20155, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.add_cf17bde800c5bc0fdb2c1a7449fe20155(EventHandler)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.cf17bde800c5bc0fdb2c1a7449fe20155;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.cf17bde800c5bc0fdb2c1a7449fe20155, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.remove_cf17bde800c5bc0fdb2c1a7449fe20155(EventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060003FF RID: 1023 RVA: 0x0001A46C File Offset: 0x0001866C
		// (remove) Token: 0x06000400 RID: 1024 RVA: 0x0001A4BC File Offset: 0x000186BC
		public event EventHandler<Exception> c4afed2c174634df66f49254235a75930
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Exception> eventHandler = this.c4afed2c174634df66f49254235a75930;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = c4752e9f82839b466091b53b1b27929cc.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.c4afed2c174634df66f49254235a75930, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.add_c4afed2c174634df66f49254235a75930(EventHandler<Exception>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Exception> eventHandler = this.c4afed2c174634df66f49254235a75930;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = c4752e9f82839b466091b53b1b27929cc.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.c4afed2c174634df66f49254235a75930, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.remove_c4afed2c174634df66f49254235a75930(EventHandler<Exception>)).MethodHandle;
				}
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000401 RID: 1025 RVA: 0x0001A50C File Offset: 0x0001870C
		// (remove) Token: 0x06000402 RID: 1026 RVA: 0x0001A55C File Offset: 0x0001875C
		public event EventHandler<int> cce1f142fb0ccce87121f70ee9e5e86ec
		{
			[CompilerGenerated]
			add
			{
				EventHandler<int> eventHandler = this.cce1f142fb0ccce87121f70ee9e5e86ec;
				EventHandler<int> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<int> value2 = c923f9891af8d2e3d429496b6f6f88167.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<int>>(ref this.cce1f142fb0ccce87121f70ee9e5e86ec, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.add_cce1f142fb0ccce87121f70ee9e5e86ec(EventHandler<int>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<int> eventHandler = this.cce1f142fb0ccce87121f70ee9e5e86ec;
				EventHandler<int> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<int> value2 = c923f9891af8d2e3d429496b6f6f88167.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<int>>(ref this.cce1f142fb0ccce87121f70ee9e5e86ec, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.remove_cce1f142fb0ccce87121f70ee9e5e86ec(EventHandler<int>)).MethodHandle;
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000403 RID: 1027
		public abstract string cf96188d52085ca12da85c38a0cbd94c5 { get; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001A5AC File Offset: 0x000187AC
		public static string c7b0be042b6d2a0b606dd5328403bf5e1
		{
			get
			{
				if (c4c1cf20119750bfee2a0bb499f990883.c708cf006cf52fddbe76aea65e3f552b0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.get_c7b0be042b6d2a0b606dd5328403bf5e1()).MethodHandle;
					}
					return ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11425);
				}
				return c4c1cf20119750bfee2a0bb499f990883.cbfd2993ac65bfcb50a33504559efa52a();
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0001A5EC File Offset: 0x000187EC
		public static bool ccbe887e33d0daef830980e7dc1e518ad
		{
			get
			{
				if (c4c1cf20119750bfee2a0bb499f990883.c708cf006cf52fddbe76aea65e3f552b0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.get_ccbe887e33d0daef830980e7dc1e518ad()).MethodHandle;
					}
					return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6436) != 0;
				}
				return File.Exists(c4c1cf20119750bfee2a0bb499f990883.cbfd2993ac65bfcb50a33504559efa52a());
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001A630 File Offset: 0x00018830
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x0001A644 File Offset: 0x00018844
		public string Name { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001A658 File Offset: 0x00018858
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0001A66C File Offset: 0x0001886C
		public bool Production { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001A680 File Offset: 0x00018880
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x0001A694 File Offset: 0x00018894
		public string Publisher { get; set; } = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11722);

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001A6A8 File Offset: 0x000188A8
		public List<string> c81daca9f1ced3fd535f021403efc61e1
		{
			get
			{
				if (this.c65f7036c23df03fbf81cbcf211f4f7a1 == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.get_c81daca9f1ced3fd535f021403efc61e1()).MethodHandle;
					}
					this.c65f7036c23df03fbf81cbcf211f4f7a1 = new List<string>();
					this.c65f7036c23df03fbf81cbcf211f4f7a1.Add(this.ToInject.ProductId);
					try
					{
						string text = this.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11434));
						List<string> list = this.c65f7036c23df03fbf81cbcf211f4f7a1;
						string text2 = text;
						string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6440));
						array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6444)] = Environment.NewLine;
						list.AddRange(text2.Split(array, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6448)));
					}
					catch
					{
					}
				}
				return this.c65f7036c23df03fbf81cbcf211f4f7a1;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600040D RID: 1037
		public abstract string c41ca02dc0bc33eb67cf1568c3466b35e { get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001A76C File Offset: 0x0001896C
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0001A780 File Offset: 0x00018980
		public int RomCount { get; set; } = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6712);

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000410 RID: 1040
		public abstract string[] cb36ab33fd8ccca41b540a9363d46e846 { get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001A794 File Offset: 0x00018994
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0001A7A8 File Offset: 0x000189A8
		public c5409344e1c2b74fa8c9a4d620ccb8d48 ToInject { get; protected set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001A7BC File Offset: 0x000189BC
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0001A7D0 File Offset: 0x000189D0
		public bool UseGamepad { get; set; } = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6716) != 0;

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0001A7E4 File Offset: 0x000189E4
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0001A7F8 File Offset: 0x000189F8
		public string WorkPath { get; set; }

		// Token: 0x06000417 RID: 1047 RVA: 0x0001A80C File Offset: 0x00018A0C
		public static void c6992720ca5d3063aba6514cee9e8f4f1(string c46eff30db82531897d1b8cc73656d8ee, string c48e97359a697f997fd6d6ff36b281983)
		{
			Process.Start(new ProcessStartInfo(c46eff30db82531897d1b8cc73656d8ee)
			{
				WorkingDirectory = c48e97359a697f997fd6d6ff36b281983,
				UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6452) != 0),
				WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6456)
			}).WaitForExit();
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001A854 File Offset: 0x00018A54
		public static void c6992720ca5d3063aba6514cee9e8f4f1(string c46eff30db82531897d1b8cc73656d8ee, string c48e97359a697f997fd6d6ff36b281983, string c9197930d1c0db813352b85301cede199)
		{
			Process.Start(new ProcessStartInfo(c46eff30db82531897d1b8cc73656d8ee)
			{
				Arguments = c9197930d1c0db813352b85301cede199,
				WorkingDirectory = c48e97359a697f997fd6d6ff36b281983,
				UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6460) != 0),
				WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6464)
			}).WaitForExit();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001A8A4 File Offset: 0x00018AA4
		public static void c6992720ca5d3063aba6514cee9e8f4f1(string c46eff30db82531897d1b8cc73656d8ee, string c48e97359a697f997fd6d6ff36b281983, string c9197930d1c0db813352b85301cede199, string c86ee2faecb86a58ee5571f617a5123da, string c6aa8461dd1cb5035c109ca4a1cf905ff)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(c46eff30db82531897d1b8cc73656d8ee);
			processStartInfo.Arguments = c9197930d1c0db813352b85301cede199;
			processStartInfo.WorkingDirectory = c48e97359a697f997fd6d6ff36b281983;
			processStartInfo.UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6468) != 0);
			processStartInfo.WindowStyle = (ProcessWindowStyle)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6472);
			processStartInfo.EnvironmentVariables[c86ee2faecb86a58ee5571f617a5123da] = c6aa8461dd1cb5035c109ca4a1cf905ff;
			Process.Start(processStartInfo).WaitForExit();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001A904 File Offset: 0x00018B04
		public static void c1add8d63ef8501f3f59df9167bc45133(string cd01b667eed28e4e5eefe8d16ba575231, string cecb84d60cb88da8288c5451520aba1a8)
		{
			MemoryStream memoryStream = new MemoryStream(new c866035f717c1c145e269422264e8f519().cd13dfe553208f0b407836d345c6897d0(cd01b667eed28e4e5eefe8d16ba575231));
			try
			{
				ZipArchive zipArchive = new ZipArchive(memoryStream);
				try
				{
					zipArchive.c811907eb2abb4733dea06da0e2bcc423(cecb84d60cb88da8288c5451520aba1a8, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6476) != 0);
				}
				finally
				{
					if (zipArchive != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c1add8d63ef8501f3f59df9167bc45133(string, string)).MethodHandle;
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
						switch (6)
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

		// Token: 0x0600041B RID: 1051
		public abstract bool c04e04f3d41ac5cbe5e7491c6164e7158(string cbd32cc27f8c4c9bc43284da3fafd5979);

		// Token: 0x0600041C RID: 1052 RVA: 0x0001A98C File Offset: 0x00018B8C
		public void c6cb58d996c74b16ae7fa324b24db42b9()
		{
			FileInfo[] files = new DirectoryInfo(this.WorkPath).GetFiles(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(144), (System.IO.SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6480));
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6484); i < (int)cc2fe70e981e842d8789498e1a2725495.cfeb04651f165d0166e7c10ab1acf8b28(files); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6488))
			{
				FileInfo fileInfo = files[i];
				if (c0205eb4c3263b432cea09f9440ee3304.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Directory.GetParent(fileInfo.FullName).Name, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11461)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c6cb58d996c74b16ae7fa324b24db42b9()).MethodHandle;
					}
					File.Delete(fileInfo.FullName);
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
			files = new DirectoryInfo(Path.Combine(this.WorkPath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11461))).GetFiles();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6492); i < (int)cc2fe70e981e842d8789498e1a2725495.cfeb04651f165d0166e7c10ab1acf8b28(files); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6496))
			{
				FileInfo fileInfo2 = files[i];
				FileSystem.MoveFile(fileInfo2.FullName, fileInfo2.FullName.Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11474), ""));
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
			DirectoryInfo[] directories = new DirectoryInfo(this.WorkPath).GetDirectories();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6500); i < (int)c2a38c4e9fc4f2f8e755c11e19049af52.cfeb04651f165d0166e7c10ab1acf8b28(directories); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6508))
			{
				directories[i].Delete(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6504) != 0);
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

		// Token: 0x0600041D RID: 1053
		public abstract int cbcb9d6cee1025057c982e8c00b728c3c();

		// Token: 0x0600041E RID: 1054 RVA: 0x0001AB28 File Offset: 0x00018D28
		public virtual void c25dba10ffdbe2b55fe4809bdf44094f2()
		{
			this.cf3d4c5f6a1ce4f53ba9211544c7c1a16(this.WorkPath);
			Directory.CreateDirectory(this.WorkPath);
			this.cf3d4c5f6a1ce4f53ba9211544c7c1a16(this.ToInject.OutputPath);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001AB68 File Offset: 0x00018D68
		protected void c50e1e386dda5532ec9d5a526d6221de1(c5409344e1c2b74fa8c9a4d620ccb8d48 cadfbf5fafd784197d055275ba7724668)
		{
			TitleId titleId = new TitleId(this.ToInject.TitleId.IdRaw.Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11489), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11508)).Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11527), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11508)));
			c017566fd8fc3339eccefb42cd6629468 c017566fd8fc3339eccefb42cd = new c017566fd8fc3339eccefb42cd6629468(cadfbf5fafd784197d055275ba7724668);
			ce462f8df7ccb876a2d3bd500ac1c174f ce462f8df7ccb876a2d3bd500ac1c174f = cadfbf5fafd784197d055275ba7724668.c88e4a51a8d0b3e7d29a28576dde32c38();
			Encoding utf = Encoding.UTF8;
			c017566fd8fc3339eccefb42cd6629468 c017566fd8fc3339eccefb42cd2 = c017566fd8fc3339eccefb42cd;
			IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> files = ce462f8df7ccb876a2d3bd500ac1c174f.Files;
			Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate;
			if ((predicate = c4c1cf20119750bfee2a0bb499f990883.<>c.c572ab09a052804f57f745b58b414a848) == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c50e1e386dda5532ec9d5a526d6221de1(c5409344e1c2b74fa8c9a4d620ccb8d48)).MethodHandle;
				}
				predicate = (c4c1cf20119750bfee2a0bb499f990883.<>c.c572ab09a052804f57f745b58b414a848 = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(c4c1cf20119750bfee2a0bb499f990883.<>c.cdfab1996eb8651828de2a4469aa3481e.c745e0be2f099c09ea106076e4f2e39f5));
			}
			string @string = utf.GetString(c017566fd8fc3339eccefb42cd2.cc85b988b622afd8b85847f6752187a18(files.First(predicate), (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6512))));
			Encoding utf2 = Encoding.UTF8;
			c017566fd8fc3339eccefb42cd6629468 c017566fd8fc3339eccefb42cd3 = c017566fd8fc3339eccefb42cd;
			IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> files2 = ce462f8df7ccb876a2d3bd500ac1c174f.Files;
			Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate2;
			if ((predicate2 = c4c1cf20119750bfee2a0bb499f990883.<>c.ceb795f9448a0920841b70ce242caadc8) == null)
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
				predicate2 = (c4c1cf20119750bfee2a0bb499f990883.<>c.ceb795f9448a0920841b70ce242caadc8 = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(c4c1cf20119750bfee2a0bb499f990883.<>c.cdfab1996eb8651828de2a4469aa3481e.cddec63003263001c422cef72b1dbd041));
			}
			string string2 = utf2.GetString(c017566fd8fc3339eccefb42cd3.cc85b988b622afd8b85847f6752187a18(files2.First(predicate2), (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6516))));
			XmlDocument xmlDocument = new XmlDocument();
			XmlDocument xmlDocument2 = xmlDocument;
			string text = string2;
			char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6520));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6524)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6528);
			xmlDocument2.LoadXml(text.Trim(array));
			xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11546))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6532)].InnerText = titleId.IdRaw;
			xmlDocument.Save(this.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11563)));
			string[] array2 = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6536));
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6540)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11606);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6544)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11611);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6548)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11616);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6552)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11621);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6556)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11626);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6560)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11631);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6564)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11636);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6568)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11643);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6572)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11648);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6576)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11653);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6580)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11658);
			array2[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6584)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11663);
			string[] array3 = array2;
			XmlDocument xmlDocument3 = xmlDocument;
			string text2 = @string;
			char[] array4 = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6588));
			array4[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6592)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6596);
			xmlDocument3.LoadXml(text2.Trim(array4));
			xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11546))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6600)].InnerText = titleId.IdRaw;
			xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11670))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6604)].InnerText = this.ToInject.ProductId;
			string[] array5 = array3;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6608); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array5); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6616))
			{
				string arg = array5[i];
				xmlDocument.GetElementsByTagName(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11695), arg))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6612)].InnerText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11722);
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
			array5 = array3;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6620); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array5); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6628))
			{
				string arg2 = array5[i];
				xmlDocument.GetElementsByTagName(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11739), arg2))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6624)].InnerText = this.Name;
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
			array5 = array3;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6632); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array5); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6640))
			{
				string arg3 = array5[i];
				xmlDocument.GetElementsByTagName(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11764), arg3))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6636)].InnerText = this.Name;
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
			try
			{
				if (this.UseGamepad)
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
					xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11791))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6644)].InnerText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11806);
				}
				else
				{
					xmlDocument.GetElementsByTagName(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11791))[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6648)].InnerText = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(10997);
				}
			}
			catch
			{
			}
			xmlDocument.Save(this.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11817)));
		}

		// Token: 0x06000420 RID: 1056
		protected abstract void ce2698f6d61a96883244b8453f3f33a3c();

		// Token: 0x06000421 RID: 1057 RVA: 0x0001B128 File Offset: 0x00019328
		protected void c7ae8f46123fff8448a639de3acad6d5f(string cad48e7cec482eb202b35baba9979de2f, string c85fa46dee7ef9473f93c9fb47da11f4d)
		{
			Directory.CreateDirectory(c85fa46dee7ef9473f93c9fb47da11f4d);
			FileInfo[] files = new DirectoryInfo(cad48e7cec482eb202b35baba9979de2f).GetFiles();
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6652); i < (int)c74808c84b2bffe4869b9b9d484057f82.cfeb04651f165d0166e7c10ab1acf8b28(files); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6656))
			{
				FileInfo fileInfo = files[i];
				string text = fileInfo.Name.ToLower().Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6299), "");
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(2767)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c7ae8f46123fff8448a639de3acad6d5f(string, string)).MethodHandle;
					}
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1286);
				}
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6259)))
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
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1305);
				}
				if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6278)))
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
					text = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11862);
				}
				File.Copy(fileInfo.FullName, Path.Combine(c85fa46dee7ef9473f93c9fb47da11f4d, text));
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

		// Token: 0x06000422 RID: 1058 RVA: 0x0001B254 File Offset: 0x00019454
		protected void cf3d4c5f6a1ce4f53ba9211544c7c1a16(string cece6fb881ead60e40aa1c79bbb950fd7)
		{
			if (Directory.Exists(cece6fb881ead60e40aa1c79bbb950fd7))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.cf3d4c5f6a1ce4f53ba9211544c7c1a16(string)).MethodHandle;
				}
				Directory.Delete(cece6fb881ead60e40aa1c79bbb950fd7, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6660) != 0);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001B290 File Offset: 0x00019490
		protected void c18286cd58f49629141bc091b7af215fe(string cbd0b99b96bcec2882811add3e39c28bb)
		{
			if (File.Exists(cbd0b99b96bcec2882811add3e39c28bb))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c18286cd58f49629141bc091b7af215fe(string)).MethodHandle;
				}
				File.Delete(cbd0b99b96bcec2882811add3e39c28bb);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001B2C0 File Offset: 0x000194C0
		protected string cfd54917ce0039040d91a9d1ac2e44c93(string cc9f36ab8599957a993eea667b1cca61f)
		{
			return Path.Combine(this.WorkPath, cc9f36ab8599957a993eea667b1cca61f);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001B2E0 File Offset: 0x000194E0
		protected void cfbd48740aaad7ce9ccb4b854669b2538(string c4d6abdac9d3efb16a0adcf6a56cd5ad0, string c9c842da39360986cc45faaf4f8c0e047)
		{
			new c866035f717c1c145e269422264e8f519().c0ddecd1ce433b283de66e0c68db8aa47(this.c128f7bdb383ddb764cda0ab9a8fe94c0(c4d6abdac9d3efb16a0adcf6a56cd5ad0), Path.Combine(c9c842da39360986cc45faaf4f8c0e047, c4d6abdac9d3efb16a0adcf6a56cd5ad0), (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6664)), (c866035f717c1c145e269422264e8f519.c42cdf34b156232e923e120d1e027381b)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6668), null, null, null, (byte)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6672), (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6676));
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001B338 File Offset: 0x00019538
		protected string cfbd48740aaad7ce9ccb4b854669b2538(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			return new c866035f717c1c145e269422264e8f519().c90d21f0d803ed867f4420adf5ed63604(this.c128f7bdb383ddb764cda0ab9a8fe94c0(c4d6abdac9d3efb16a0adcf6a56cd5ad0));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0001B35C File Offset: 0x0001955C
		protected Thread cc736a37572c9ecd084d9e909d97c23c4()
		{
			Thread thread = new Thread(new ThreadStart(this.c8ed419aa0826f572340e9defe34c79ed));
			thread.IsBackground = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6680) != 0);
			thread.Name = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11871);
			thread.Start();
			return thread;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001B3A4 File Offset: 0x000195A4
		protected void c232fcc851b0115da370b4acb1c9d0e05()
		{
			try
			{
				this.c6cb58d996c74b16ae7fa324b24db42b9();
				FileSystem.MoveDirectory(this.WorkPath, this.ToInject.OutputPath);
			}
			catch (Exception c0d6c37d812d5d4b610705a6421056252)
			{
				RadMessageBox.Show(c023ef59998c1544cc2d1887c8e5ee879.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(11892), Environment.NewLine, c0d6c37d812d5d4b610705a6421056252));
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001B40C File Offset: 0x0001960C
		protected void ca1394714ad264b382e2c09206f569348()
		{
			EventHandler eventHandler = this.cf17bde800c5bc0fdb2c1a7449fe20155;
			if (eventHandler == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.ca1394714ad264b382e2c09206f569348()).MethodHandle;
				}
				return;
			}
			eventHandler(this, caa194a1ddc67cd543957fd94f509f2e3.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001B444 File Offset: 0x00019644
		protected void c3475132295323f8a31a663ad2110a7d2(Exception c08b391577522100e1046cacdb2283fb0)
		{
			EventHandler<Exception> eventHandler = this.c4afed2c174634df66f49254235a75930;
			if (eventHandler == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c3475132295323f8a31a663ad2110a7d2(Exception)).MethodHandle;
				}
				return;
			}
			eventHandler(this, c08b391577522100e1046cacdb2283fb0);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001B478 File Offset: 0x00019678
		protected void c7edf1b3f88145bc9d58df301f738705a(int c34b57f0f9f0739ada1d7d09ea110e9b9)
		{
			EventHandler<int> eventHandler = this.cce1f142fb0ccce87121f70ee9e5e86ec;
			if (eventHandler == null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c7edf1b3f88145bc9d58df301f738705a(int)).MethodHandle;
				}
				return;
			}
			eventHandler(this, c34b57f0f9f0739ada1d7d09ea110e9b9);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001B4AC File Offset: 0x000196AC
		private static bool c708cf006cf52fddbe76aea65e3f552b0
		{
			get
			{
				bool result;
				try
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12250),
						Arguments = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12267),
						RedirectStandardError = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6684) != 0),
						UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6688) != 0),
						CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6692) != 0)
					});
					result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6696) != 0);
				}
				catch
				{
					result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6700) != 0);
				}
				return result;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0001B548 File Offset: 0x00019748
		private static string c3b2d2a0c05675e9eb35ce2b651a80b18(string c70f1064222fa2c281974a7b7a2035e61, string c32053d44c8d1dcaa73f780b2a239314c)
		{
			string result;
			try
			{
				c4c1cf20119750bfee2a0bb499f990883.ca0feed8a05b2b6b9d032da31a68f10bd ca0feed8a05b2b6b9d032da31a68f10bd = new c4c1cf20119750bfee2a0bb499f990883.ca0feed8a05b2b6b9d032da31a68f10bd();
				FileInfo[] files = new DirectoryInfo(c70f1064222fa2c281974a7b7a2035e61).GetFiles(c32053d44c8d1dcaa73f780b2a239314c, (System.IO.SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6704));
				c4c1cf20119750bfee2a0bb499f990883.ca0feed8a05b2b6b9d032da31a68f10bd ca0feed8a05b2b6b9d032da31a68f10bd2 = ca0feed8a05b2b6b9d032da31a68f10bd;
				IEnumerable<FileInfo> source = files;
				Func<FileInfo, DateTime> selector;
				if ((selector = c4c1cf20119750bfee2a0bb499f990883.<>c.c7d85276606b9aa1643555b1aeb8a9194) == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.c3b2d2a0c05675e9eb35ce2b651a80b18(string, string)).MethodHandle;
					}
					selector = (c4c1cf20119750bfee2a0bb499f990883.<>c.c7d85276606b9aa1643555b1aeb8a9194 = new Func<FileInfo, DateTime>(c4c1cf20119750bfee2a0bb499f990883.<>c.cdfab1996eb8651828de2a4469aa3481e.c0f98efde6bd509a56ffd04d061e3533b));
				}
				ca0feed8a05b2b6b9d032da31a68f10bd2.c2e2274d496b951416e1e7d8c4785931b = source.Max(selector);
				result = files.First(new Func<FileInfo, bool>(ca0feed8a05b2b6b9d032da31a68f10bd.c5d3d06698d357a9a29cba63a0b5de6fd)).FullName;
			}
			catch
			{
				result = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			}
			return result;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001B5EC File Offset: 0x000197EC
		private static string cbfd2993ac65bfcb50a33504559efa52a()
		{
			string text = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
			if (Environment.Is64BitOperatingSystem)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4c1cf20119750bfee2a0bb499f990883.cbfd2993ac65bfcb50a33504559efa52a()).MethodHandle;
				}
				text = c4c1cf20119750bfee2a0bb499f990883.c3b2d2a0c05675e9eb35ce2b651a80b18(Path.Combine(Environment.GetEnvironmentVariable(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12286)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12311)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12250));
			}
			if (text == null)
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
				text = c4c1cf20119750bfee2a0bb499f990883.c3b2d2a0c05675e9eb35ce2b651a80b18(Path.Combine(Environment.GetFolderPath((Environment.SpecialFolder)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(6708)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12311)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12250));
			}
			return text;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001B69C File Offset: 0x0001989C
		private string c128f7bdb383ddb764cda0ab9a8fe94c0(string c4d6abdac9d3efb16a0adcf6a56cd5ad0)
		{
			return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12320), this.ToInject.cae8945ad667defbe7c150465d2c8aaba, c4d6abdac9d3efb16a0adcf6a56cd5ad0);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001B6CC File Offset: 0x000198CC
		[CompilerGenerated]
		private void c8ed419aa0826f572340e9defe34c79ed()
		{
			this.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12335), this.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12364)));
			this.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12393), this.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12364)));
			this.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12420), this.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12364)));
			this.cfbd48740aaad7ce9ccb4b854669b2538(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12443), this.cfd54917ce0039040d91a9d1ac2e44c93(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12364)));
		}

		// Token: 0x0400025F RID: 607
		[CompilerGenerated]
		private string c7c4a2eb69dbaeafc270bce8e84ade7cb;

		// Token: 0x04000260 RID: 608
		[CompilerGenerated]
		private bool c1b34e7134651dfbec4a2329c40af36e7;

		// Token: 0x04000261 RID: 609
		[CompilerGenerated]
		private string c0bffbe36684de6cee5017141723fdfba;

		// Token: 0x04000262 RID: 610
		private List<string> c65f7036c23df03fbf81cbcf211f4f7a1;

		// Token: 0x04000263 RID: 611
		[CompilerGenerated]
		private int c40f1641ceff0071bb71588091f14ce51;

		// Token: 0x04000264 RID: 612
		[CompilerGenerated]
		private c5409344e1c2b74fa8c9a4d620ccb8d48 c85a9ed3b68bc9934490a18763132a9cb;

		// Token: 0x04000265 RID: 613
		[CompilerGenerated]
		private bool c804805c20b264c846f91b440c814bad2;

		// Token: 0x04000266 RID: 614
		[CompilerGenerated]
		private string c5dc51d60825ea40fba81b27a7e8057c9;

		// Token: 0x02000126 RID: 294
		[CompilerGenerated]
		private sealed class ca0feed8a05b2b6b9d032da31a68f10bd
		{
			// Token: 0x060008FC RID: 2300 RVA: 0x0005DBBC File Offset: 0x0005BDBC
			internal bool c5d3d06698d357a9a29cba63a0b5de6fd(FileInfo ced17f5fac5de96d8d690dac7cea067a7)
			{
				return c71d56cf919573942125a92aa3a5a772b.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ced17f5fac5de96d8d690dac7cea067a7.CreationTime, this.c2e2274d496b951416e1e7d8c4785931b);
			}

			// Token: 0x0400068F RID: 1679
			public DateTime c2e2274d496b951416e1e7d8c4785931b;
		}
	}
}
