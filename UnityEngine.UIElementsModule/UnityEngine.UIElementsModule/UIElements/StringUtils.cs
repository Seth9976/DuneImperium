using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020002DE RID: 734
	public static class StringUtils
	{
		// Token: 0x06003428 RID: 13352 RVA: 0x000DA1B4 File Offset: 0x000D83B4
		public unsafe static int LevenshteinDistance(string s, string t)
		{
			int length = s.Length;
			int length2 = t.Length;
			bool flag = length == 0;
			int num;
			if (flag)
			{
				num = length2;
			}
			else
			{
				bool flag2 = length2 == 0;
				if (flag2)
				{
					num = length;
				}
				else
				{
					int num2 = length + 1;
					int num3 = length2 + 1;
					int* ptr;
					checked
					{
						ptr = stackalloc int[unchecked((UIntPtr)(num2 * num3)) * 4];
					}
					for (int i = 0; i <= length; i++)
					{
						ptr[num3 * i] = i;
					}
					for (int j = 0; j <= length2; j++)
					{
						ptr[j] = j;
					}
					for (int k = 1; k <= length2; k++)
					{
						for (int l = 1; l <= length; l++)
						{
							bool flag3 = s.get_Chars(l - 1) == t.get_Chars(k - 1);
							if (flag3)
							{
								ptr[num3 * l + k] = ptr[num3 * (l - 1) + k - 1];
							}
							else
							{
								ptr[num3 * l + k] = Math.Min(Math.Min(ptr[num3 * (l - 1) + k] + 1, ptr[num3 * l + k - 1] + 1), ptr[num3 * (l - 1) + k - 1] + 1);
							}
						}
					}
					num = ptr[num3 * length + length2];
				}
			}
			return num;
		}
	}
}
