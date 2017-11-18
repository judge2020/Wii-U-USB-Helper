using System;
using System.Globalization;
using System.Text;

namespace A
{
	// Token: 0x020000A5 RID: 165
	internal static class c34ce0b034187983362ba58cc8c72233a
	{
		// Token: 0x06000573 RID: 1395 RVA: 0x00023560 File Offset: 0x00021760
		private static string c73431f4774d61864045aacd01324f78c(this string c0bf3c8814cbe78eaaa0a6866d15f1fe3)
		{
			string text = c0bf3c8814cbe78eaaa0a6866d15f1fe3.Normalize((NormalizationForm)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9428));
			StringBuilder stringBuilder = new StringBuilder();
			string text2 = text;
			for (int i = cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9432); i < text2.Length; i += cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9440))
			{
				char c = text2[i];
				if (CharUnicodeInfo.GetUnicodeCategory(c) != (UnicodeCategory)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9436))
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
						RuntimeMethodHandle runtimeMethodHandle = methodof(string.c73431f4774d61864045aacd01324f78c()).MethodHandle;
					}
					stringBuilder.Append(c);
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
			return stringBuilder.ToString().Normalize((NormalizationForm)cebbdeae8341a51f374f3ef4c993a069a.c6bc1c09ec46e3a402ca1f5ca208c573e(9444));
		}

		// Token: 0x040002C1 RID: 705
		public static string c0b9a995f9c2313cad22315173d49b769;
	}
}
