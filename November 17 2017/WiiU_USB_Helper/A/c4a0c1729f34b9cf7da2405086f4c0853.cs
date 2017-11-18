using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A
{
	// Token: 0x02000068 RID: 104
	internal class c4a0c1729f34b9cf7da2405086f4c0853
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x000118FC File Offset: 0x0000FAFC
		public c4a0c1729f34b9cf7da2405086f4c0853(string c139298ff9599e809a51346ed71ceca10, string ca78ceddef7cf7dcdd94998b19837439c, string cf845f14860b0c1f2c73686cad8b25dcb)
		{
			this.cb689e652eac22c54ef570b384f0df229 = c139298ff9599e809a51346ed71ceca10;
			this.c21098acb888c82ef2b629b42053d074d = c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7261), c139298ff9599e809a51346ed71ceca10);
			this.c2aa98903225e761a898797a5200175c8 = ca78ceddef7cf7dcdd94998b19837439c;
			this.c5c00f899bf19c222fc739a91f684d7eb = cf845f14860b0c1f2c73686cad8b25dcb;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0001197C File Offset: 0x0000FB7C
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00011990 File Offset: 0x0000FB90
		public c8e60ceced0ce323f661e853233d10ec2 TransferStatus { get; private set; } = new c8e60ceced0ce323f661e853233d10ec2(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7228), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4456) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4460));

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060002DB RID: 731 RVA: 0x000119A4 File Offset: 0x0000FBA4
		// (remove) Token: 0x060002DC RID: 732 RVA: 0x000119F4 File Offset: 0x0000FBF4
		public event EventHandler<long> cdc6a6882963655f3dac51fd371d2e6bb
		{
			[CompilerGenerated]
			add
			{
				EventHandler<long> eventHandler = this.cdc6a6882963655f3dac51fd371d2e6bb;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = ca25a4d53cddcc6bc7545bb1022695103.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.cdc6a6882963655f3dac51fd371d2e6bb, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.add_cdc6a6882963655f3dac51fd371d2e6bb(EventHandler<long>)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<long> eventHandler = this.cdc6a6882963655f3dac51fd371d2e6bb;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = ca25a4d53cddcc6bc7545bb1022695103.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.cdc6a6882963655f3dac51fd371d2e6bb, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.remove_cdc6a6882963655f3dac51fd371d2e6bb(EventHandler<long>)).MethodHandle;
				}
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060002DD RID: 733 RVA: 0x00011A44 File Offset: 0x0000FC44
		// (remove) Token: 0x060002DE RID: 734 RVA: 0x00011A94 File Offset: 0x0000FC94
		public event EventHandler c3dc25cbd6cf2e00bfcf0b299e3cd1eaa
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.c3dc25cbd6cf2e00bfcf0b299e3cd1eaa;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Combine(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.c3dc25cbd6cf2e00bfcf0b299e3cd1eaa, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.add_c3dc25cbd6cf2e00bfcf0b299e3cd1eaa(EventHandler)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.c3dc25cbd6cf2e00bfcf0b299e3cd1eaa;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = c7687a4dfdaa199dfff40397fbccd9fdd.cd24593c859565ebb8c9faabbc5c75bef(Delegate.Remove(eventHandler2, value));
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.c3dc25cbd6cf2e00bfcf0b299e3cd1eaa, value2, eventHandler2);
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.remove_c3dc25cbd6cf2e00bfcf0b299e3cd1eaa(EventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		public void c6889450a48d299ebf2287450e166d567()
		{
			this.TransferStatus = new c8e60ceced0ce323f661e853233d10ec2(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(6995), cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4224) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4228));
			this.c2f6566ff223bd28fed0177b260b31800 = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4232) != 0);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00011B30 File Offset: 0x0000FD30
		public bool c4275fb0a38c52fbd88cf4f2b6c5659da()
		{
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1145), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7026));
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0.Timeout = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4236);
			try
			{
				this.c40df0c631e1e9c7ad682e096252a45bc = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
			}
			catch (Exception)
			{
				return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4240) != 0;
			}
			finally
			{
				FtpWebResponse ftpWebResponse = this.c40df0c631e1e9c7ad682e096252a45bc;
				if (ftpWebResponse == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c4275fb0a38c52fbd88cf4f2b6c5659da()).MethodHandle;
					}
				}
				else
				{
					ftpWebResponse.Close();
				}
			}
			return cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4244) != 0;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00011BF0 File Offset: 0x0000FDF0
		public void cbb7a4a6d58a8a360abcf15e1aae3eb6e(string cbd5a5805a7e7fb070256c4d8bb045978)
		{
			try
			{
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(cbd5a5805a7e7fb070256c4d8bb045978, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7035));
				this.c40df0c631e1e9c7ad682e096252a45bc = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
				this.c40df0c631e1e9c7ad682e096252a45bc.Close();
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00011C68 File Offset: 0x0000FE68
		public void c3e9844232914e2f1ccf3d192ecfca2bd(string c530948db1c85922c4fcd27396ed623fd)
		{
			try
			{
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c530948db1c85922c4fcd27396ed623fd, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7042));
				this.c40df0c631e1e9c7ad682e096252a45bc = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
				this.c40df0c631e1e9c7ad682e096252a45bc.Close();
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00011CE0 File Offset: 0x0000FEE0
		public List<string> cc18548f4a692947f5caa2bf9e8480539(string c080fc526914529016145ec8ceb99b498)
		{
			List<string> list = new List<string>();
			try
			{
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c080fc526914529016145ec8ceb99b498, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7026));
				FtpWebResponse ftpWebResponse = this.c40df0c631e1e9c7ad682e096252a45bc = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
				try
				{
					Stream stream = this.cbb84e5180e8fe2b04507fe9d24a3587c = this.c40df0c631e1e9c7ad682e096252a45bc.GetResponseStream();
					try
					{
						StreamReader streamReader = new StreamReader(this.cbb84e5180e8fe2b04507fe9d24a3587c);
						try
						{
							List<string> list2 = list;
							string text = streamReader.ReadToEnd();
							string[] array = c0e4fbbd9d84d9421a3acc98e626b3813.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4248));
							array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4252)] = Environment.NewLine;
							list2.AddRange(text.Split(array, (StringSplitOptions)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4256)));
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
						finally
						{
							if (streamReader != null)
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
									RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.cc18548f4a692947f5caa2bf9e8480539(string)).MethodHandle;
								}
								((IDisposable)streamReader).Dispose();
							}
						}
					}
					finally
					{
						if (stream != null)
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
							((IDisposable)stream).Dispose();
						}
					}
				}
				finally
				{
					if (ftpWebResponse != null)
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
						((IDisposable)ftpWebResponse).Dispose();
					}
				}
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
				return list;
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			return list;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00011E90 File Offset: 0x00010090
		public void ca0deb4313b3486e1a76640a9a4da62b2(string c080fc526914529016145ec8ceb99b498, string cbec00f3f6f2668a13e880f71d2d8ef8a)
		{
			FileStream fileStream = File.Create(cbec00f3f6f2668a13e880f71d2d8ef8a);
			try
			{
				ZipArchive zipArchive = new ZipArchive(fileStream, (ZipArchiveMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4260));
				try
				{
					this.c4a15bf822e1535307cea65e2672952a6(c080fc526914529016145ec8ceb99b498, zipArchive, "");
				}
				finally
				{
					if (zipArchive != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.ca0deb4313b3486e1a76640a9a4da62b2(string, string)).MethodHandle;
						}
						((IDisposable)zipArchive).Dispose();
					}
				}
			}
			finally
			{
				if (fileStream != null)
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
					((IDisposable)fileStream).Dispose();
				}
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00011F14 File Offset: 0x00010114
		public void c5f478ac7033b25a8d24283aa2fe7bcad(string c11e3cf5b95dfacb423823dc56a866d2d, string c134edc596b0005af53bcbf61ce83dab3)
		{
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c11e3cf5b95dfacb423823dc56a866d2d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7051));
			FtpWebResponse ftpWebResponse = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
			try
			{
				Stream responseStream = ftpWebResponse.GetResponseStream();
				try
				{
					FileStream fileStream = new FileStream(c134edc596b0005af53bcbf61ce83dab3, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4264));
					try
					{
						byte[] buffer = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(this.c92811a0281cf3624f1ee607a1be1dfd0);
						int i = responseStream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4268), this.c92811a0281cf3624f1ee607a1be1dfd0);
						try
						{
							while (i > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4280))
							{
								fileStream.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4272), i);
								i = responseStream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4276), this.c92811a0281cf3624f1ee607a1be1dfd0);
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
							if (!true)
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c5f478ac7033b25a8d24283aa2fe7bcad(string, string)).MethodHandle;
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
					finally
					{
						if (fileStream != null)
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
							((IDisposable)fileStream).Dispose();
						}
					}
				}
				finally
				{
					if (responseStream != null)
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
						((IDisposable)responseStream).Dispose();
					}
				}
			}
			finally
			{
				if (ftpWebResponse != null)
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
					((IDisposable)ftpWebResponse).Dispose();
				}
			}
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00012070 File Offset: 0x00010270
		public void c4a15bf822e1535307cea65e2672952a6(string c080fc526914529016145ec8ceb99b498, ZipArchive cbec00f3f6f2668a13e880f71d2d8ef8a, string c1c4b7f6b4f15f24e28916634ae6333ae)
		{
			using (List<string>.Enumerator enumerator = this.cc18548f4a692947f5caa2bf9e8480539(c080fc526914529016145ec8ceb99b498).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					string text2 = Path.Combine(c1c4b7f6b4f15f24e28916634ae6333ae, text);
					if (c4a0c1729f34b9cf7da2405086f4c0853.c866dc63e87d738ad8646b85d6e6adbd3(text))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c4a15bf822e1535307cea65e2672952a6(string, ZipArchive, string)).MethodHandle;
						}
						this.c4a15bf822e1535307cea65e2672952a6(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Path.Combine(c080fc526914529016145ec8ceb99b498, text), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1145)), cbec00f3f6f2668a13e880f71d2d8ef8a, text2);
					}
					else
					{
						this.c5f478ac7033b25a8d24283aa2fe7bcad(Path.Combine(c080fc526914529016145ec8ceb99b498, text), cbec00f3f6f2668a13e880f71d2d8ef8a, text2);
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
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00012130 File Offset: 0x00010330
		public string ceb1ea276d0ecc91c176a8d33e07e0231(string c158ce8059478abee6d499bdc639f98e0)
		{
			try
			{
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c158ce8059478abee6d499bdc639f98e0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7060));
				this.c40df0c631e1e9c7ad682e096252a45bc = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
				this.cbb84e5180e8fe2b04507fe9d24a3587c = this.c40df0c631e1e9c7ad682e096252a45bc.GetResponseStream();
				StreamReader streamReader = new StreamReader(this.cbb84e5180e8fe2b04507fe9d24a3587c);
				string result = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
				try
				{
					result = streamReader.ReadToEnd();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
				streamReader.Close();
				this.cbb84e5180e8fe2b04507fe9d24a3587c.Close();
				this.c40df0c631e1e9c7ad682e096252a45bc.Close();
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
				return result;
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			return "";
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00012208 File Offset: 0x00010408
		public string cb54434938e872dc0a935e0958a79e703(string c158ce8059478abee6d499bdc639f98e0)
		{
			try
			{
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c158ce8059478abee6d499bdc639f98e0, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7069));
				this.c40df0c631e1e9c7ad682e096252a45bc = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
				this.cbb84e5180e8fe2b04507fe9d24a3587c = this.c40df0c631e1e9c7ad682e096252a45bc.GetResponseStream();
				StreamReader streamReader = new StreamReader(this.cbb84e5180e8fe2b04507fe9d24a3587c);
				string result = cebe4618707cda8768cff8656169fe7ae.cab55a050df275722227783d6686266c9;
				try
				{
					while (streamReader.Peek() != cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4284))
					{
						result = streamReader.ReadToEnd();
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.cb54434938e872dc0a935e0958a79e703(string)).MethodHandle;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
				streamReader.Close();
				this.cbb84e5180e8fe2b04507fe9d24a3587c.Close();
				this.c40df0c631e1e9c7ad682e096252a45bc.Close();
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
				return result;
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			return "";
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001230C File Offset: 0x0001050C
		public void ce53f604320791eb84314a48924f3f55d(string caea6c1886e701ac4f505601e09291631, string c8bd99d7fd2e4154ed4d7fcc903fc496e)
		{
			try
			{
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c8bd99d7fd2e4154ed4d7fcc903fc496e, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7078));
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0.RenameTo = c8bd99d7fd2e4154ed4d7fcc903fc496e;
				this.c40df0c631e1e9c7ad682e096252a45bc = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
				this.c40df0c631e1e9c7ad682e096252a45bc.Close();
				this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00012390 File Offset: 0x00010590
		public void c0278fefdcda956b0326d374499bb002b(string c9b75f6ba06c0e9f0da24aef64cde37be)
		{
			try
			{
				c4a0c1729f34b9cf7da2405086f4c0853.c0deec38a6598b564417432a609b26283(this.cb689e652eac22c54ef570b384f0df229, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4288), this.c2aa98903225e761a898797a5200175c8, this.c5c00f899bf19c222fc739a91f684d7eb, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7091), c9b75f6ba06c0e9f0da24aef64cde37be));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000123F4 File Offset: 0x000105F4
		public void ccc0709f01e7727f761fd4044909cf094(string c648fff4d42c125a1d7713de867cc89ff, string c0fb99d2283dc886d0c7891b596dc2ca9)
		{
			c4a0c1729f34b9cf7da2405086f4c0853.cf777a4eb66c7865b3b4db0c8ea396a28 cf777a4eb66c7865b3b4db0c8ea396a = new c4a0c1729f34b9cf7da2405086f4c0853.cf777a4eb66c7865b3b4db0c8ea396a28();
			cf777a4eb66c7865b3b4db0c8ea396a.c4404a159870bf55bb6f111e66e59e82d = this;
			cf777a4eb66c7865b3b4db0c8ea396a.c648fff4d42c125a1d7713de867cc89ff = c648fff4d42c125a1d7713de867cc89ff;
			cf777a4eb66c7865b3b4db0c8ea396a.c0fb99d2283dc886d0c7891b596dc2ca9 = c0fb99d2283dc886d0c7891b596dc2ca9;
			Task.Run(new Action(cf777a4eb66c7865b3b4db0c8ea396a.cb065dac830af49261bccecfd8aed15a4));
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00012430 File Offset: 0x00010630
		public void c096bb34616f42313f075f0a552d93d2a(string c648fff4d42c125a1d7713de867cc89ff, ZipArchive cd01b667eed28e4e5eefe8d16ba575231)
		{
			this.cbb7a4a6d58a8a360abcf15e1aae3eb6e(c648fff4d42c125a1d7713de867cc89ff);
			List<string> list = new List<string>();
			IEnumerator<ZipArchiveEntry> enumerator = cd01b667eed28e4e5eefe8d16ba575231.Entries.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ZipArchiveEntry zipArchiveEntry = enumerator.Current;
					string directoryName = Path.GetDirectoryName(zipArchiveEntry.FullName);
					if (!list.Contains(directoryName))
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c096bb34616f42313f075f0a552d93d2a(string, ZipArchive)).MethodHandle;
						}
						list.Add(directoryName);
						string text = directoryName;
						char[] array = c79caed728c3efc32d12ed7d388c559a7.cad714a49573fd585a8ab14c80a23536b(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4292));
						array[cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4296)] = (char)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4300);
						string[] array2 = text.Split(array);
						string text2 = c648fff4d42c125a1d7713de867cc89ff;
						string[] array3 = array2;
						for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4304); i < (int)c35e85ecdf822c0628c4ba6d3d6570767.cfeb04651f165d0166e7c10ab1acf8b28(array3); i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4308))
						{
							string c0d6c37d812d5d4b610705a6421056252 = array3[i];
							text2 = c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(text2, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1145), c0d6c37d812d5d4b610705a6421056252);
							this.cbb7a4a6d58a8a360abcf15e1aae3eb6e(text2);
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
			enumerator = cd01b667eed28e4e5eefe8d16ba575231.Entries.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ZipArchiveEntry zipArchiveEntry2 = enumerator.Current;
					if (!c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(zipArchiveEntry2.FullName, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(4438)))
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
						string text3 = Path.Combine(c648fff4d42c125a1d7713de867cc89ff, zipArchiveEntry2.FullName.Replace(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7118), ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1145)));
						if (!c4a0c1729f34b9cf7da2405086f4c0853.c866dc63e87d738ad8646b85d6e6adbd3(text3))
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
							this.ce56bcb559e478b1178a8c402b97e2926(text3, zipArchiveEntry2);
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
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001263C File Offset: 0x0001083C
		private static void c1f2876406529ee0cd34da77d1156df6b(TcpClient c4c111e1c48f808111fb7521fb423132e)
		{
			try
			{
				NetworkStream stream = c4c111e1c48f808111fb7521fb423132e.GetStream();
				if (!(stream.CanWrite & stream.CanRead))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c1f2876406529ee0cd34da77d1156df6b(TcpClient)).MethodHandle;
					}
				}
				else
				{
					byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(c4c111e1c48f808111fb7521fb423132e.ReceiveBufferSize + cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4312));
					stream.ReadTimeout = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4316);
					stream.Read(array, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4320), Convert.ToInt32(c4c111e1c48f808111fb7521fb423132e.ReceiveBufferSize));
					Encoding.ASCII.GetString(array);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000126F0 File Offset: 0x000108F0
		private static bool c866dc63e87d738ad8646b85d6e6adbd3(string ce7d298d73bab0df9bcfdc208996dceec)
		{
			return c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(Path.GetExtension(ce7d298d73bab0df9bcfdc208996dceec), string.Empty);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00012714 File Offset: 0x00010914
		private static bool c0deec38a6598b564417432a609b26283(string c9e537f9967ec9409ad1acfe5e8a7dc1b, int c2491962cff0630545ac948da180b9f4c, string c16c25c174720b821fe65e33eeb79fc60, string c117a444830ca6af3cd189f5ec5115b9e, string ce8fecb6d37fd2f95a6a5e2a8e971cc42)
		{
			bool result = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4324) != 0;
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(c9e537f9967ec9409ad1acfe5e8a7dc1b, c2491962cff0630545ac948da180b9f4c);
				c4a0c1729f34b9cf7da2405086f4c0853.c1f2876406529ee0cd34da77d1156df6b(tcpClient);
				if (c4a0c1729f34b9cf7da2405086f4c0853.cbc36783badfb41c513f14d4e6d2e1fb8(tcpClient, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7121), c16c25c174720b821fe65e33eeb79fc60)).Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7132)))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c0deec38a6598b564417432a609b26283(string, int, string, string, string)).MethodHandle;
					}
					if (c4a0c1729f34b9cf7da2405086f4c0853.cbc36783badfb41c513f14d4e6d2e1fb8(tcpClient, c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7139), c117a444830ca6af3cd189f5ec5115b9e)).Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7150)))
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
						if (c4a0c1729f34b9cf7da2405086f4c0853.cbc36783badfb41c513f14d4e6d2e1fb8(tcpClient, ce8fecb6d37fd2f95a6a5e2a8e971cc42).Contains(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7157)))
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
							result = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4328) != 0);
						}
					}
				}
				tcpClient.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7164), ex.Message));
			}
			return result;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00012834 File Offset: 0x00010A34
		private static string cbc36783badfb41c513f14d4e6d2e1fb8(TcpClient c4c111e1c48f808111fb7521fb423132e, string c30f0603de0dda0273308305b9cdc9c99)
		{
			string result = "";
			try
			{
				NetworkStream stream = c4c111e1c48f808111fb7521fb423132e.GetStream();
				if (stream.CanWrite & stream.CanRead)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.cbc36783badfb41c513f14d4e6d2e1fb8(TcpClient, string)).MethodHandle;
					}
					byte[] bytes = Encoding.ASCII.GetBytes(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(c30f0603de0dda0273308305b9cdc9c99, Environment.NewLine));
					stream.Write(bytes, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4332), (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(bytes));
					result = new StreamReader(stream).ReadLine();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(c72c3e9a0cc00ee2de6a9f6d658d0ca09.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7164), ex.Message));
			}
			return result;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000128F4 File Offset: 0x00010AF4
		private FtpWebRequest c83ed1b92e39e28fccdc702a2156fe951(string c11e3cf5b95dfacb423823dc56a866d2d, string c349afe24756c2022fc84606a1e6d3419)
		{
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cc09e546912236fe58e73aa9152fa3e9b.cd24593c859565ebb8c9faabbc5c75bef(WebRequest.Create(c425bd02e62fe6f0f6895b17f61cfe0f0.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(this.c21098acb888c82ef2b629b42053d074d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1145), c11e3cf5b95dfacb423823dc56a866d2d)));
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0.Credentials = new NetworkCredential(this.c2aa98903225e761a898797a5200175c8, this.c5c00f899bf19c222fc739a91f684d7eb);
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0.UseBinary = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4336) != 0);
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0.UsePassive = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4340) != 0);
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0.KeepAlive = (cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4344) != 0);
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0.Method = c349afe24756c2022fc84606a1e6d3419;
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0.Timeout = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4348);
			return this.cb3ceccfbe9e2753e61f6d0c9586bedf0;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000129B4 File Offset: 0x00010BB4
		private void c5f478ac7033b25a8d24283aa2fe7bcad(string c11e3cf5b95dfacb423823dc56a866d2d, ZipArchive cd01b667eed28e4e5eefe8d16ba575231, string cc9f36ab8599957a993eea667b1cca61f)
		{
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c11e3cf5b95dfacb423823dc56a866d2d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7051));
			FtpWebResponse ftpWebResponse = ca3c4c66076f7f10ebaea1747b70c7f21.cd24593c859565ebb8c9faabbc5c75bef(this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetResponse());
			try
			{
				Stream responseStream = ftpWebResponse.GetResponseStream();
				try
				{
					Stream stream = cd01b667eed28e4e5eefe8d16ba575231.CreateEntry(cc9f36ab8599957a993eea667b1cca61f).Open();
					try
					{
						byte[] buffer = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(this.c92811a0281cf3624f1ee607a1be1dfd0);
						int i = responseStream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4352), this.c92811a0281cf3624f1ee607a1be1dfd0);
						try
						{
							while (i > cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4364))
							{
								stream.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4356), i);
								i = responseStream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4360), this.c92811a0281cf3624f1ee607a1be1dfd0);
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
							if (!true)
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c5f478ac7033b25a8d24283aa2fe7bcad(string, ZipArchive, string)).MethodHandle;
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
					finally
					{
						if (stream != null)
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
							((IDisposable)stream).Dispose();
						}
					}
				}
				finally
				{
					if (responseStream != null)
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
						((IDisposable)responseStream).Dispose();
					}
				}
			}
			finally
			{
				if (ftpWebResponse != null)
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
					((IDisposable)ftpWebResponse).Dispose();
				}
			}
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00012B10 File Offset: 0x00010D10
		private void c60210e846c25d16035d52a4168da6fac(long c0aea6afefa0b359db23b567ca305333c)
		{
			EventHandler<long> eventHandler = this.cdc6a6882963655f3dac51fd371d2e6bb;
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
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c60210e846c25d16035d52a4168da6fac(long)).MethodHandle;
				}
				return;
			}
			eventHandler(this, c0aea6afefa0b359db23b567ca305333c);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00012B44 File Offset: 0x00010D44
		private void ce56bcb559e478b1178a8c402b97e2926(string c11e3cf5b95dfacb423823dc56a866d2d, ZipArchiveEntry c3d57b353c405c58b3e7b1741fb443d42)
		{
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c11e3cf5b95dfacb423823dc56a866d2d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7219));
			Stream requestStream = this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetRequestStream();
			try
			{
				Stream stream = c3d57b353c405c58b3e7b1741fb443d42.Open();
				try
				{
					byte[] buffer = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(this.c92811a0281cf3624f1ee607a1be1dfd0);
					int num = stream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4368), this.c92811a0281cf3624f1ee607a1be1dfd0);
					try
					{
						while (num != 0)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.ce56bcb559e478b1178a8c402b97e2926(string, ZipArchiveEntry)).MethodHandle;
							}
							if (this.c2f6566ff223bd28fed0177b260b31800)
							{
								for (;;)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									goto IL_BA;
								}
							}
							else
							{
								requestStream.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4372), num);
								num = stream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4376), this.c92811a0281cf3624f1ee607a1be1dfd0);
								this.c60210e846c25d16035d52a4168da6fac((long)num);
							}
						}
						IL_BA:;
					}
					catch (Exception ex)
					{
						if (cecee0c60d6da21ad1c7d911787ab8274.c0b398ab350e72b0d64d512bae8520b85(ex) == null)
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
							this.TransferStatus = new c8e60ceced0ce323f661e853233d10ec2(ex.Message, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4380) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4384));
						}
					}
				}
				finally
				{
					if (stream != null)
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
						((IDisposable)stream).Dispose();
					}
				}
			}
			finally
			{
				if (requestStream != null)
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
					((IDisposable)requestStream).Dispose();
				}
			}
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00012CAC File Offset: 0x00010EAC
		private void ce56bcb559e478b1178a8c402b97e2926(string c11e3cf5b95dfacb423823dc56a866d2d, string c134edc596b0005af53bcbf61ce83dab3)
		{
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = this.c83ed1b92e39e28fccdc702a2156fe951(c11e3cf5b95dfacb423823dc56a866d2d, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(7219));
			Stream requestStream = this.cb3ceccfbe9e2753e61f6d0c9586bedf0.GetRequestStream();
			try
			{
				FileStream fileStream = new FileStream(c134edc596b0005af53bcbf61ce83dab3, (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4388));
				try
				{
					byte[] buffer = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(this.c92811a0281cf3624f1ee607a1be1dfd0);
					int num = fileStream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4392), this.c92811a0281cf3624f1ee607a1be1dfd0);
					try
					{
						while (num != 0)
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
								RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.ce56bcb559e478b1178a8c402b97e2926(string, string)).MethodHandle;
							}
							if (this.c2f6566ff223bd28fed0177b260b31800)
							{
								for (;;)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									goto IL_C2;
								}
							}
							else
							{
								requestStream.Write(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4396), num);
								num = fileStream.Read(buffer, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4400), this.c92811a0281cf3624f1ee607a1be1dfd0);
								this.c60210e846c25d16035d52a4168da6fac((long)num);
							}
						}
						IL_C2:;
					}
					catch (Exception ex)
					{
						if (cecee0c60d6da21ad1c7d911787ab8274.c0b398ab350e72b0d64d512bae8520b85(ex) == null)
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
							this.TransferStatus = new c8e60ceced0ce323f661e853233d10ec2(ex.Message, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4404) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4408));
						}
					}
				}
				finally
				{
					if (fileStream != null)
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
						((IDisposable)fileStream).Dispose();
					}
				}
			}
			finally
			{
				if (requestStream != null)
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
					((IDisposable)requestStream).Dispose();
				}
			}
			this.cb3ceccfbe9e2753e61f6d0c9586bedf0 = cdb6f4a3ed6575bebc7f4581157aa8732.cab55a050df275722227783d6686266c9;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00012E1C File Offset: 0x0001101C
		private void c5048ef689ffb0ea56bce17bff9d32b32(string c648fff4d42c125a1d7713de867cc89ff, string c0fb99d2283dc886d0c7891b596dc2ca9)
		{
			FileInfo[] files = new DirectoryInfo(c0fb99d2283dc886d0c7891b596dc2ca9).GetFiles();
			int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4412);
			while (i < (int)c74808c84b2bffe4869b9b9d484057f82.cfeb04651f165d0166e7c10ab1acf8b28(files))
			{
				FileInfo fileInfo = files[i];
				Thread.Sleep(cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4416));
				int j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4420);
				if (!this.c2f6566ff223bd28fed0177b260b31800)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c4a0c1729f34b9cf7da2405086f4c0853.c5048ef689ffb0ea56bce17bff9d32b32(string, string)).MethodHandle;
					}
					if (!this.TransferStatus.Error)
					{
						while (j < cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4444))
						{
							try
							{
								this.ce56bcb559e478b1178a8c402b97e2926(Path.Combine(c648fff4d42c125a1d7713de867cc89ff, fileInfo.Name), fileInfo.FullName);
								j = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4424);
							}
							catch (Exception ex)
							{
								j += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4428);
								if (j >= cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4432))
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
									this.TransferStatus = new c8e60ceced0ce323f661e853233d10ec2(ex.Message, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4436) != 0, (cf00b8d3686971bcd30227efeb92f5320)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4440));
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
						i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4448);
						continue;
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
				IL_13B:
				EventHandler eventHandler = this.c3dc25cbd6cf2e00bfcf0b299e3cd1eaa;
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
					return;
				}
				eventHandler(this, caa194a1ddc67cd543957fd94f509f2e3.cab55a050df275722227783d6686266c9);
				return;
			}
			for (;;)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				goto IL_13B;
			}
		}

		// Token: 0x040001A0 RID: 416
		private const int ca9cdc344fdd97a9d227414b15e4fbc30 = 5;

		// Token: 0x040001A1 RID: 417
		private readonly int c92811a0281cf3624f1ee607a1be1dfd0 = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4452);

		// Token: 0x040001A2 RID: 418
		private volatile bool c2f6566ff223bd28fed0177b260b31800;

		// Token: 0x040001A3 RID: 419
		private FtpWebRequest cb3ceccfbe9e2753e61f6d0c9586bedf0;

		// Token: 0x040001A4 RID: 420
		private FtpWebResponse c40df0c631e1e9c7ad682e096252a45bc;

		// Token: 0x040001A5 RID: 421
		private Stream cbb84e5180e8fe2b04507fe9d24a3587c;

		// Token: 0x040001A6 RID: 422
		private readonly string c21098acb888c82ef2b629b42053d074d;

		// Token: 0x040001A7 RID: 423
		private readonly string cb689e652eac22c54ef570b384f0df229;

		// Token: 0x040001A8 RID: 424
		private readonly string c5c00f899bf19c222fc739a91f684d7eb;

		// Token: 0x040001A9 RID: 425
		private readonly string c2aa98903225e761a898797a5200175c8;

		// Token: 0x040001AA RID: 426
		[CompilerGenerated]
		private c8e60ceced0ce323f661e853233d10ec2 c73ae6bbef6715cf169d06e335641b9c7;

		// Token: 0x0200010D RID: 269
		[CompilerGenerated]
		private sealed class cf777a4eb66c7865b3b4db0c8ea396a28
		{
			// Token: 0x060008B3 RID: 2227 RVA: 0x0005C6A4 File Offset: 0x0005A8A4
			internal void cb065dac830af49261bccecfd8aed15a4()
			{
				this.c4404a159870bf55bb6f111e66e59e82d.c5048ef689ffb0ea56bce17bff9d32b32(this.c648fff4d42c125a1d7713de867cc89ff, this.c0fb99d2283dc886d0c7891b596dc2ca9);
			}

			// Token: 0x04000644 RID: 1604
			public string c648fff4d42c125a1d7713de867cc89ff;

			// Token: 0x04000645 RID: 1605
			public string c0fb99d2283dc886d0c7891b596dc2ca9;

			// Token: 0x04000646 RID: 1606
			public c4a0c1729f34b9cf7da2405086f4c0853 c4404a159870bf55bb6f111e66e59e82d;
		}
	}
}
