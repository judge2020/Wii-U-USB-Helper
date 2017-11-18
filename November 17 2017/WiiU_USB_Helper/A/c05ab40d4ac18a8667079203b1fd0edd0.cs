using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace A
{
	// Token: 0x02000002 RID: 2
	public static class c05ab40d4ac18a8667079203b1fd0edd0
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		internal static void cca035b5773e1c7bd4eb2ebb87879807e()
		{
			try
			{
				string text = Path.Combine(c67726bc94fb4dd43c5c00e863a4fed19.CachePath, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(1));
				Directory.CreateDirectory(text);
				cd4880843d42f3dd634ca35c8e909b573.c1ed128e8bdc7109d913800afc41fb9f6(ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(12), text);
				IEnumerable<string> files = Directory.GetFiles(text, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(144), (System.IO.SearchOption)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(0));
				string text2 = Path.Combine(new c835740eb09051bccacfad4c551fdd155(null, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(4) != 0).cbc2836ea62c32bc8df1f63f72af3a491, ceffa389ee86c0ee26f31dd3efacbdd38.c5dd75c94760bfb37727a44ddc794d278(147));
				Directory.CreateDirectory(text2);
				Func<string, bool> predicate;
				if ((predicate = c05ab40d4ac18a8667079203b1fd0edd0.<>c.c91d5f3c4da7899dd62ffa8332da1ec8e) == null)
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(c05ab40d4ac18a8667079203b1fd0edd0.cca035b5773e1c7bd4eb2ebb87879807e()).MethodHandle;
					}
					predicate = (c05ab40d4ac18a8667079203b1fd0edd0.<>c.c91d5f3c4da7899dd62ffa8332da1ec8e = new Func<string, bool>(c05ab40d4ac18a8667079203b1fd0edd0.<>c.cdfab1996eb8651828de2a4469aa3481e.c61b350bfa8dd37651f1456598a83ff7b));
				}
				IEnumerator<string> enumerator = files.Where(predicate).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string path = enumerator.Current;
						string directoryName = Path.GetDirectoryName(path);
						string text3 = Path.Combine(text2, new DirectoryInfo(Path.GetDirectoryName(path)).Name);
						if (Directory.Exists(Path.Combine(text2, text3)))
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
							Directory.Delete(text3, cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(8) != 0);
						}
						try
						{
							FileSystem.MoveDirectory(directoryName, text3);
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
			}
			catch
			{
			}
		}
	}
}
