using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace A
{
	// Token: 0x02000004 RID: 4
	public static class cc986a36f7534edc08e2f8221002d522a
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002238 File Offset: 0x00000438
		public static void c933e2a6c940f0f1609a3545e0a3e52c8(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			if (!cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c.Contains(c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc986a36f7534edc08e2f8221002d522a.c933e2a6c940f0f1609a3545e0a3e52c8(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c.Add(c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw);
			}
			cc986a36f7534edc08e2f8221002d522a.c1f5db0a1fb213260e52a32680152313c();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002290 File Offset: 0x00000490
		public static void ccc1e3db2b76294a8d8f3475682c27268(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			if (cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c.Contains(c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw))
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(cc986a36f7534edc08e2f8221002d522a.ccc1e3db2b76294a8d8f3475682c27268(c6114b34ba4893a53ebb4b599e0e2e3fc)).MethodHandle;
				}
				cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c.Remove(c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw);
			}
			cc986a36f7534edc08e2f8221002d522a.c1f5db0a1fb213260e52a32680152313c();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022EC File Offset: 0x000004EC
		private static void c1f5db0a1fb213260e52a32680152313c()
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			FileStream fileStream = File.Create(Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, cc986a36f7534edc08e2f8221002d522a.c723fe043f529924223356a2a3cbb8d2f));
			try
			{
				binaryFormatter.Serialize(fileStream, cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c);
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
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(cc986a36f7534edc08e2f8221002d522a.c1f5db0a1fb213260e52a32680152313c()).MethodHandle;
					}
					((IDisposable)fileStream).Dispose();
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002358 File Offset: 0x00000558
		public static bool c13b4c491030e28a0f262267b54ab959c(c6114b34ba4893a53ebb4b599e0e2e3fc c804bc52f7f79bffee6fd394ef382eb76)
		{
			return cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c.Contains(c804bc52f7f79bffee6fd394ef382eb76.TitleId.IdRaw);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002380 File Offset: 0x00000580
		internal static void cca035b5773e1c7bd4eb2ebb87879807e()
		{
			try
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				FileStream fileStream = File.Open(Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, cc986a36f7534edc08e2f8221002d522a.c723fe043f529924223356a2a3cbb8d2f), (FileMode)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(12));
				try
				{
					cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c = cbbee9ed377c1ca44a8493b94c3a630be.cd24593c859565ebb8c9faabbc5c75bef(binaryFormatter.Deserialize(fileStream));
				}
				finally
				{
					if (fileStream != null)
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
							RuntimeMethodHandle runtimeMethodHandle = methodof(cc986a36f7534edc08e2f8221002d522a.cca035b5773e1c7bd4eb2ebb87879807e()).MethodHandle;
						}
						((IDisposable)fileStream).Dispose();
					}
				}
			}
			catch
			{
				cc986a36f7534edc08e2f8221002d522a.ce4a0e3c837a0b96a2b89886adbd4409c = new List<string>();
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly string c723fe043f529924223356a2a3cbb8d2f = ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(172);

		// Token: 0x04000002 RID: 2
		private static List<string> ce4a0e3c837a0b96a2b89886adbd4409c = new List<string>();
	}
}
