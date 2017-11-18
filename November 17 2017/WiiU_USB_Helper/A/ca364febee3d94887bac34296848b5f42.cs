using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace A
{
	// Token: 0x02000021 RID: 33
	public static class ca364febee3d94887bac34296848b5f42
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00008780 File Offset: 0x00006980
		public static void c811907eb2abb4733dea06da0e2bcc423(this ZipArchive cd01b667eed28e4e5eefe8d16ba575231, string cd689e0706cca0859a201b8a43eb66ddf, bool c60c499286e64ccc77dcc32a82aba7885)
		{
			if (!c60c499286e64ccc77dcc32a82aba7885)
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
					RuntimeMethodHandle runtimeMethodHandle = methodof(ZipArchive.c811907eb2abb4733dea06da0e2bcc423(string, bool)).MethodHandle;
				}
				cd01b667eed28e4e5eefe8d16ba575231.ExtractToDirectory(cd689e0706cca0859a201b8a43eb66ddf);
				return;
			}
			IEnumerator<ZipArchiveEntry> enumerator = cd01b667eed28e4e5eefe8d16ba575231.Entries.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ZipArchiveEntry zipArchiveEntry = enumerator.Current;
					try
					{
						Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(cd689e0706cca0859a201b8a43eb66ddf, zipArchiveEntry.FullName)));
					}
					catch
					{
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
			enumerator = cd01b667eed28e4e5eefe8d16ba575231.Entries.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ZipArchiveEntry zipArchiveEntry2 = enumerator.Current;
					string text = Path.Combine(cd689e0706cca0859a201b8a43eb66ddf, zipArchiveEntry2.FullName);
					if (c65c252d08c00d64b46298b4434860139.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(zipArchiveEntry2.Name, ""))
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
						Directory.CreateDirectory(Path.GetDirectoryName(text));
					}
					else
					{
						zipArchiveEntry2.ExtractToFile(text, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(2904) != 0);
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
	}
}
