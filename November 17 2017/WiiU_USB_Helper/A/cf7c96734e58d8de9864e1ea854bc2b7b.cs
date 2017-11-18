using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using NusHelper;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace A
{
	// Token: 0x02000091 RID: 145
	public abstract class cf7c96734e58d8de9864e1ea854bc2b7b
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00020564 File Offset: 0x0001E764
		internal cf7c96734e58d8de9864e1ea854bc2b7b(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76, string ce7d298d73bab0df9bcfdc208996dceec, string cbc47e314a0f1d7d5f1d07b50ba2bb8c7, bool c07532d90fa519783a3736afc4d48beb9 = true, bool c11e4e8c7e06a3bc593aefa84d54feebb = false)
		{
			this.cbd119e33552f6e7eda45b0c64e636c3a = c804bc52f7f79bffee6fd394ef382eb76;
			this.FullScreen = c11e4e8c7e06a3bc593aefa84d54feebb;
			this.Name = ce7d298d73bab0df9bcfdc208996dceec;
			if (!Directory.Exists(this.ceab5b7abb10583fc226e8459ce78bc86))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b..ctor(c6114b34ba4893a53ebb4b599e0e2e3fc, string, string, bool, bool)).MethodHandle;
				}
				Directory.CreateDirectory(this.ceab5b7abb10583fc226e8459ce78bc86);
			}
			if (!Directory.Exists(this.c4d68e2c283dbf2783383a0a1d0aaa75a))
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
				Directory.CreateDirectory(this.c4d68e2c283dbf2783383a0a1d0aaa75a);
			}
			if (!Directory.Exists(this.cbc2836ea62c32bc8df1f63f72af3a491))
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
				Directory.CreateDirectory(this.cbc2836ea62c32bc8df1f63f72af3a491);
			}
			this.Url = cbc47e314a0f1d7d5f1d07b50ba2bb8c7;
			this.c3d9ea706751b7382a00d3ab9302ccbf9 = c07532d90fa519783a3736afc4d48beb9;
			if (c07532d90fa519783a3736afc4d48beb9)
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
				this.c9a97a9b02f735137b7d889075e2595fe();
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0002063C File Offset: 0x0001E83C
		public void c5b82a34802a427f61b7a0d683e9456b9()
		{
			ce07c379a1090dd9de869aa5e3a694e98.ca1590def1ff8bdbed62121a24e1f5074(this);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00020650 File Offset: 0x0001E850
		public void c9a97a9b02f735137b7d889075e2595fe()
		{
			if (this != null)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c9a97a9b02f735137b7d889075e2595fe()).MethodHandle;
				}
				if (caba6aae6ba2ea6ef470113eba0e94821.c0b398ab350e72b0d64d512bae8520b85(this) == null)
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
					if (c335c9afc89f8b38416ea326e29397e4f.c0b398ab350e72b0d64d512bae8520b85(this) == null)
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
						if (cc9862cf4c5479bb7da17a0039b59b2b5.c0b398ab350e72b0d64d512bae8520b85(this) != null)
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
							if (Settings.Default.ForceUpdatesDolphin)
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
								this.c5b82a34802a427f61b7a0d683e9456b9();
								return;
							}
							return;
						}
					}
					else
					{
						if (Settings.Default.ForceUpdatesCitra)
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
							this.c5b82a34802a427f61b7a0d683e9456b9();
							return;
						}
						return;
					}
				}
				else
				{
					if (Settings.Default.ForceUpdates)
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
						this.c5b82a34802a427f61b7a0d683e9456b9();
						return;
					}
					return;
				}
			}
			this.c5b82a34802a427f61b7a0d683e9456b9();
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00020728 File Offset: 0x0001E928
		public string Name { get; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0002073C File Offset: 0x0001E93C
		public string Url { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00020750 File Offset: 0x0001E950
		public string c0a254255436def68504b708355d89587
		{
			get
			{
				return Path.Combine(this.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6105), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12393));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00020784 File Offset: 0x0001E984
		public string cd4bc1cb5288cbdc39ea878f29ae4794b
		{
			get
			{
				return Path.Combine(this.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6105), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12443));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000207B8 File Offset: 0x0001E9B8
		public string c6c81a687812a72cf6d69a1b2b1f51dee
		{
			get
			{
				return Path.Combine(this.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6105), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(40449));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000207EC File Offset: 0x0001E9EC
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00020800 File Offset: 0x0001EA00
		public bool FullScreen { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00020814 File Offset: 0x0001EA14
		internal string ce62321b4e96fa914081f8f8cc2f87d3c
		{
			get
			{
				return Path.Combine(this.c4d68e2c283dbf2783383a0a1d0aaa75a, this.cbd119e33552f6e7eda45b0c64e636c3a.caf5c2281268b0d9649319527ceb47238());
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00020840 File Offset: 0x0001EA40
		internal string cbc2836ea62c32bc8df1f63f72af3a491
		{
			get
			{
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8804));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8808)] = c6a5e9b85d86b4e098a511017a1073d71.c2eaf0dbe8bd11ef4cc2db5c557fe1f2f;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8812)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8816)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6086);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8820)] = this.Name;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8824)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(40476);
				return Path.Combine(array);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000208D4 File Offset: 0x0001EAD4
		internal string c4d68e2c283dbf2783383a0a1d0aaa75a
		{
			get
			{
				string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8828));
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8832)] = c6a5e9b85d86b4e098a511017a1073d71.c2eaf0dbe8bd11ef4cc2db5c557fe1f2f;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8836)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8840)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6086);
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8844)] = this.Name;
				array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8848)] = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3961);
				return Path.Combine(array);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00020968 File Offset: 0x0001EB68
		internal string ceab5b7abb10583fc226e8459ce78bc86
		{
			get
			{
				return Path.Combine(c6a5e9b85d86b4e098a511017a1073d71.c2eaf0dbe8bd11ef4cc2db5c557fe1f2f, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(3613), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6086), this.Name);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x000209A4 File Offset: 0x0001EBA4
		public bool c529da0940d4ea14c178fe93b48b61b96
		{
			get
			{
				return File.Exists(this.c9ad9e3ddcd7e5e324cd01b2dfad9f78d());
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000209C0 File Offset: 0x0001EBC0
		public bool c8a01a4300b89e645a23909a3d4f8ec38
		{
			get
			{
				bool result;
				try
				{
					bool flag;
					if (File.Exists(this.c010f80182206bd1b4a523f2e99f7657a()))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.get_c8a01a4300b89e645a23909a3d4f8ec38()).MethodHandle;
						}
						flag = (new FileInfo(this.c010f80182206bd1b4a523f2e99f7657a()).Length > (long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8852));
					}
					else
					{
						flag = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8856) != 0);
					}
					result = flag;
				}
				catch
				{
					result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8860) != 0);
				}
				return result;
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00020A40 File Offset: 0x0001EC40
		public virtual void c37b3d3a9ef4a26c65a3fac4aa3cda6c2()
		{
			try
			{
				if (!this.cbd119e33552f6e7eda45b0c64e636c3a.c1083de0b8d92c5fcbdd7005111d34bb9)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c37b3d3a9ef4a26c65a3fac4aa3cda6c2()).MethodHandle;
					}
					if (this.cbd119e33552f6e7eda45b0c64e636c3a.ca435006c85356cb7385a782de8889a0a != (c59ff87f6bdc69ff3440c18f170633236)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8864))
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
						this.c710ab1f9325e526a3c4ef872ab290b94();
						goto IL_53;
					}
				}
				this.ce08d3fcff1ec6badc424f2432fc6e909();
				IL_53:
				this.c57d8c53c26088bcba39b12aebd5cfb69(this.c725acc3eddb72d7ac90f323bc7845e34());
			}
			catch (Exception c0d6c37d812d5d4b610705a6421056252)
			{
				RadMessageBox.Show(c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(40483), c0d6c37d812d5d4b610705a6421056252));
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		public void ce08d3fcff1ec6badc424f2432fc6e909()
		{
			ce07c379a1090dd9de869aa5e3a694e98.cd77410813e3b3b3daf462e4390ee5c85();
			this.c0af5c4e148a68a530b83d61893c72e0e(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8868) != 0);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00020B04 File Offset: 0x0001ED04
		public void c710ab1f9325e526a3c4ef872ab290b94()
		{
			ce07c379a1090dd9de869aa5e3a694e98.cd77410813e3b3b3daf462e4390ee5c85();
			this.c0af5c4e148a68a530b83d61893c72e0e(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8872) != 0);
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060004A5 RID: 1189 RVA: 0x00020B28 File Offset: 0x0001ED28
		// (remove) Token: 0x060004A6 RID: 1190 RVA: 0x00020B78 File Offset: 0x0001ED78
		public event EventHandler c2abf7733dfa8f63c28711c4d4fdf3389
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.c2abf7733dfa8f63c28711c4d4fdf3389;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.c2abf7733dfa8f63c28711c4d4fdf3389, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.add_c2abf7733dfa8f63c28711c4d4fdf3389(EventHandler)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.c2abf7733dfa8f63c28711c4d4fdf3389;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.c2abf7733dfa8f63c28711c4d4fdf3389, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.remove_c2abf7733dfa8f63c28711c4d4fdf3389(EventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		protected void c04f1aa642aa20ea0b5ffb57a12c86780()
		{
			EventHandler eventHandler = this.c2abf7733dfa8f63c28711c4d4fdf3389;
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c04f1aa642aa20ea0b5ffb57a12c86780()).MethodHandle;
				}
				return;
			}
			eventHandler(this, caa194a1ddc67cd543957fd94f509f2e3.cab55a050df275722227783d6686266c9);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00020C00 File Offset: 0x0001EE00
		protected void c57d8c53c26088bcba39b12aebd5cfb69(string c9197930d1c0db813352b85301cede199)
		{
			if (!this.c529da0940d4ea14c178fe93b48b61b96)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c57d8c53c26088bcba39b12aebd5cfb69(string)).MethodHandle;
				}
				throw new FileNotFoundException(string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(40839), this.c9ad9e3ddcd7e5e324cd01b2dfad9f78d()));
			}
			Process process = new Process();
			process.StartInfo.FileName = this.c9ad9e3ddcd7e5e324cd01b2dfad9f78d();
			process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8876) != 0);
			process.StartInfo.Arguments = c9197930d1c0db813352b85301cede199;
			process.StartInfo.WorkingDirectory = this.c4d68e2c283dbf2783383a0a1d0aaa75a;
			process.StartInfo.UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8880) != 0);
			process.StartInfo.RedirectStandardOutput = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8884) != 0);
			process.Exited += this.c1004e0e3cff97c77af7f075c625d1e3e;
			process.Start();
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00020CE0 File Offset: 0x0001EEE0
		protected static long c2b2a1122416abf41d177f55ba843a0cc(Stream c73f1dae9f6f82bed94bc7a9992b25324, byte[] cdb86489ef926dbc8e598053351d62697)
		{
			long position = c73f1dae9f6f82bed94bc7a9992b25324.Position;
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8888));
			int num = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8892);
			int num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8896);
			int num3 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8900);
			int i;
			for (;;)
			{
				IL_3D:
				num = c73f1dae9f6f82bed94bc7a9992b25324.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8904), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
				num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8908);
				i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8912);
				while (i < num)
				{
					num3 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8916);
					if (array[i] == cdb86489ef926dbc8e598053351d62697[num2])
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c2b2a1122416abf41d177f55ba843a0cc(Stream, byte[])).MethodHandle;
						}
						num2 += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8920);
					}
					else
					{
						num2 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8924);
					}
					if (num2 != (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cdb86489ef926dbc8e598053351d62697))
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
						i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8928);
					}
					else
					{
						IL_EC:
						if (num <= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8932))
						{
							goto IL_11C;
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
						if (num2 == (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cdb86489ef926dbc8e598053351d62697))
						{
							goto IL_112;
						}
						goto IL_3D;
					}
				}
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					goto IL_EC;
				}
			}
			for (;;)
			{
				IL_112:
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			IL_11C:
			c73f1dae9f6f82bed94bc7a9992b25324.Seek(position + (long)num3 - (long)((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cdb86489ef926dbc8e598053351d62697)), (SeekOrigin)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8936));
			return position + (long)i - (long)((int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(cdb86489ef926dbc8e598053351d62697));
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00020E3C File Offset: 0x0001F03C
		public virtual void c917b7d52124974f13178d266d3018f48()
		{
			try
			{
				Directory.Delete(this.ce62321b4e96fa914081f8f8cc2f87d3c, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8940) != 0);
			}
			catch
			{
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00020E78 File Offset: 0x0001F078
		public virtual void c6b3ff55a7c487618bd5b51ee9721b004()
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00020E88 File Offset: 0x0001F088
		public virtual void c317968580438da6ad9f9dc9eec9e6f21()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00020E98 File Offset: 0x0001F098
		protected static DataSize c03173681cb66233029beadb803f04b74(string c8b6d5b25fa11e2a17b3e9cd7cf6b464f)
		{
			if (!Directory.Exists(c8b6d5b25fa11e2a17b3e9cd7cf6b464f))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c03173681cb66233029beadb803f04b74(string)).MethodHandle;
				}
				return new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8944)));
			}
			string[] files = Directory.GetFiles(c8b6d5b25fa11e2a17b3e9cd7cf6b464f, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(898), (SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8948));
			ulong num = (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8952));
			string[] array = files;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8956); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8960))
			{
				FileInfo fileInfo = new FileInfo(array[i]);
				num += (ulong)fileInfo.Length;
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
			return new DataSize(num);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00020F48 File Offset: 0x0001F148
		public virtual DataSize c5620567a227ba8fb76f2c8a8b6f0eea3()
		{
			return cf7c96734e58d8de9864e1ea854bc2b7b.c03173681cb66233029beadb803f04b74(this.ce62321b4e96fa914081f8f8cc2f87d3c);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00020F64 File Offset: 0x0001F164
		public virtual DataSize c59792486d0bd6862618a19710cb7f523()
		{
			return new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8964)));
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00020F84 File Offset: 0x0001F184
		public virtual DataSize c8a1b0d2c9e11b3a523f48cce77365f7c()
		{
			return new DataSize((ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8968)));
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		public virtual ulong cd432dc5c6962dc6093ffdf141c495abd()
		{
			return (ulong)((long)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8972));
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00020FBC File Offset: 0x0001F1BC
		protected void c4b1d0ff2a4e5958927cf4a855fe65dab(bool c3c7497942acfe55b365013a6254dd980)
		{
			string text = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13506));
			if (!File.Exists(text))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c4b1d0ff2a4e5958927cf4a855fe65dab(bool)).MethodHandle;
				}
				File.WriteAllBytes(text, c6faa5467be1a4874657b372a49b7c927.rpl2elf);
			}
			ce462f8df7ccb876a2d3bd500ac1c174f ce462f8df7ccb876a2d3bd500ac1c174f = this.cbd119e33552f6e7eda45b0c64e636c3a.c88e4a51a8d0b3e7d29a28576dde32c38();
			IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> files = ce462f8df7ccb876a2d3bd500ac1c174f.Files;
			Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate;
			if ((predicate = cf7c96734e58d8de9864e1ea854bc2b7b.<>c.c55737f9595f09d126f57e223064dac0e) == null)
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
				predicate = (cf7c96734e58d8de9864e1ea854bc2b7b.<>c.c55737f9595f09d126f57e223064dac0e = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(cf7c96734e58d8de9864e1ea854bc2b7b.<>c.cdfab1996eb8651828de2a4469aa3481e.c616ebd9c4499c613e17ff3b9bcc340e8));
			}
			c362f27bc84ea5b6692418fbdaf79e992 c362f27bc84ea5b6692418fbdaf79e = files.First(predicate);
			IEnumerable<c362f27bc84ea5b6692418fbdaf79e992> files2 = ce462f8df7ccb876a2d3bd500ac1c174f.Files;
			Func<c362f27bc84ea5b6692418fbdaf79e992, bool> predicate2;
			if ((predicate2 = cf7c96734e58d8de9864e1ea854bc2b7b.<>c.c8233c9f9915d9314308f99bc2ddaf24a) == null)
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
				predicate2 = (cf7c96734e58d8de9864e1ea854bc2b7b.<>c.c8233c9f9915d9314308f99bc2ddaf24a = new Func<c362f27bc84ea5b6692418fbdaf79e992, bool>(cf7c96734e58d8de9864e1ea854bc2b7b.<>c.cdfab1996eb8651828de2a4469aa3481e.ce8627b517dd13151321db2d2c8110644));
			}
			c362f27bc84ea5b6692418fbdaf79e992 c362f27bc84ea5b6692418fbdaf79e2 = files2.First(predicate2);
			c6114b34ba4893a53ebb4b599e0e2e3fc c6114b34ba4893a53ebb4b599e0e2e3fc = this.cbd119e33552f6e7eda45b0c64e636c3a;
			string c4d68e2c283dbf2783383a0a1d0aaa75a = this.c4d68e2c283dbf2783383a0a1d0aaa75a;
			bool c39287c15a6e8c6c70cc44cbd62c7f22d = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8976) != 0;
			c362f27bc84ea5b6692418fbdaf79e992[] array = cb62f89df70fbc1a6ea491fc391fd54ac.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8980));
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8984)] = c362f27bc84ea5b6692418fbdaf79e;
			array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8988)] = c362f27bc84ea5b6692418fbdaf79e2;
			c6114b34ba4893a53ebb4b599e0e2e3fc.cf08369cbb3a626a84f05ff893b78fed7(c4d68e2c283dbf2783383a0a1d0aaa75a, c39287c15a6e8c6c70cc44cbd62c7f22d, c3c7497942acfe55b365013a6254dd980, array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8992) != 0);
			Process process = new Process();
			string text2 = this.c01f07c49f1e015426bb7975f0ae6d0f7();
			string arg = this.c2bde6b24c3a9f7e1c4da8f930b4419a9();
			process.StartInfo.FileName = text;
			process.EnableRaisingEvents = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8996) != 0);
			process.StartInfo.CreateNoWindow = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9000) != 0);
			process.StartInfo.Arguments = string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41099), text2, arg);
			process.StartInfo.WorkingDirectory = Path.GetDirectoryName(text2);
			process.StartInfo.UseShellExecute = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9004) != 0);
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0002118C File Offset: 0x0001F38C
		public virtual string c725acc3eddb72d7ac90f323bc7845e34()
		{
			return string.Format(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(38952), this.c010f80182206bd1b4a523f2e99f7657a());
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000211B4 File Offset: 0x0001F3B4
		protected string c2bde6b24c3a9f7e1c4da8f930b4419a9()
		{
			return c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c01f07c49f1e015426bb7975f0ae6d0f7(), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(41122));
		}

		// Token: 0x060004B5 RID: 1205
		public abstract string c9ad9e3ddcd7e5e324cd01b2dfad9f78d();

		// Token: 0x060004B6 RID: 1206
		public abstract string c010f80182206bd1b4a523f2e99f7657a();

		// Token: 0x060004B7 RID: 1207 RVA: 0x000211DC File Offset: 0x0001F3DC
		protected string c01f07c49f1e015426bb7975f0ae6d0f7()
		{
			string path = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Path.Combine(this.ce62321b4e96fa914081f8f8cc2f87d3c, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(13647)), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7118));
			if (!Directory.Exists(path))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c01f07c49f1e015426bb7975f0ae6d0f7()).MethodHandle;
				}
				return "";
			}
			IEnumerable<string> files = Directory.GetFiles(path);
			Func<string, bool> predicate;
			if ((predicate = cf7c96734e58d8de9864e1ea854bc2b7b.<>c.c370b7e960c544120ad056af42ba2e395) == null)
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
				predicate = (cf7c96734e58d8de9864e1ea854bc2b7b.<>c.c370b7e960c544120ad056af42ba2e395 = new Func<string, bool>(cf7c96734e58d8de9864e1ea854bc2b7b.<>c.cdfab1996eb8651828de2a4469aa3481e.cbf680ecc6415ea59ce91746256afb451));
			}
			List<string> list = files.Where(predicate).ToList<string>();
			if (list.Count <= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9008))
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
				return "";
			}
			return list[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9012)];
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000212B4 File Offset: 0x0001F4B4
		private static void cceccb6dcb718e2d591b6f856f761ad12(string c89b185acdd2af51d8e322ce8a7b453bc)
		{
			string[] directories = Directory.GetDirectories(c89b185acdd2af51d8e322ce8a7b453bc);
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9016); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(directories); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9024))
			{
				string text = directories[i];
				cf7c96734e58d8de9864e1ea854bc2b7b.cceccb6dcb718e2d591b6f856f761ad12(text);
				if (c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(Directory.GetFiles(text)) == 0)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.cceccb6dcb718e2d591b6f856f761ad12(string)).MethodHandle;
					}
					if (c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(Directory.GetDirectories(text)) == 0)
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
						Directory.Delete(text, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9020) != 0);
					}
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

		// Token: 0x060004B9 RID: 1209 RVA: 0x00021354 File Offset: 0x0001F554
		public static void c54f221133eb526d693ab1f91ea0d82db(string c70f1064222fa2c281974a7b7a2035e61, string c8343a0111b91397d34fed6d38ff7a3eb, bool c275b1bcf8db38ca13d2c882e0f6e6c6b = true)
		{
			string[] files = Directory.GetFiles(c70f1064222fa2c281974a7b7a2035e61, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(898), (SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9028));
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9032); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(files); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9036))
			{
				string text = files[i];
				if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text, c8343a0111b91397d34fed6d38ff7a3eb))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c54f221133eb526d693ab1f91ea0d82db(string, string, bool)).MethodHandle;
					}
					if (c275b1bcf8db38ca13d2c882e0f6e6c6b)
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
						if (text.Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6105)))
						{
							goto IL_89;
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
					try
					{
						File.Delete(text);
					}
					catch
					{
					}
				}
				IL_89:;
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
			cf7c96734e58d8de9864e1ea854bc2b7b.cceccb6dcb718e2d591b6f856f761ad12(c70f1064222fa2c281974a7b7a2035e61);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00021424 File Offset: 0x0001F624
		public void c54f221133eb526d693ab1f91ea0d82db(bool c275b1bcf8db38ca13d2c882e0f6e6c6b = true)
		{
			cf7c96734e58d8de9864e1ea854bc2b7b.c54f221133eb526d693ab1f91ea0d82db(this.ce62321b4e96fa914081f8f8cc2f87d3c, this.c010f80182206bd1b4a523f2e99f7657a(), c275b1bcf8db38ca13d2c882e0f6e6c6b);
		}

		// Token: 0x060004BB RID: 1211
		public abstract bool c1313a3694d9d4cbd109dd5b1b1fe94b1();

		// Token: 0x060004BC RID: 1212
		public abstract bool cab66f65884757b260d3cede7f6adcb72();

		// Token: 0x060004BD RID: 1213 RVA: 0x00021448 File Offset: 0x0001F648
		protected virtual void c0af5c4e148a68a530b83d61893c72e0e(bool c3c7497942acfe55b365013a6254dd980)
		{
			if (!this.c8a01a4300b89e645a23909a3d4f8ec38)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cf7c96734e58d8de9864e1ea854bc2b7b.c0af5c4e148a68a530b83d61893c72e0e(bool)).MethodHandle;
				}
				if (this.cbd119e33552f6e7eda45b0c64e636c3a.System == (ceee61848167c1ade885c85db30acc060)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9040))
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
					this.cbd119e33552f6e7eda45b0c64e636c3a.cf08369cbb3a626a84f05ff893b78fed7(this.c4d68e2c283dbf2783383a0a1d0aaa75a, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9044) != 0, c3c7497942acfe55b365013a6254dd980, null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9048) != 0);
				}
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000214C4 File Offset: 0x0001F6C4
		[CompilerGenerated]
		private void c1004e0e3cff97c77af7f075c625d1e3e(object cd020a9448b1902e4410f2e9f4a256959, EventArgs c920e624ed3f68a7518020d25dc06be2d)
		{
			this.c04f1aa642aa20ea0b5ffb57a12c86780();
		}

		// Token: 0x0400027C RID: 636
		protected readonly c6114b34ba4893a53ebb4b599e0e2e3fc cbd119e33552f6e7eda45b0c64e636c3a;

		// Token: 0x0400027D RID: 637
		protected bool c3d9ea706751b7382a00d3ab9302ccbf9;

		// Token: 0x0400027E RID: 638
		[CompilerGenerated]
		private readonly string c7c4a2eb69dbaeafc270bce8e84ade7cb;

		// Token: 0x0400027F RID: 639
		[CompilerGenerated]
		private readonly string c02a36b7e6f910c81835a71f93b50b18b;

		// Token: 0x04000280 RID: 640
		[CompilerGenerated]
		private bool c07e955b09bbc3b5dfab087273860901f;
	}
}
