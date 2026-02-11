using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020002DF RID: 735
	public static class StringUtilsExtensions
	{
		// Token: 0x06003429 RID: 13353 RVA: 0x00015422 File Offset: 0x00013622
		public static string ToPascalCase(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x0001542F File Offset: 0x0001362F
		public static string ToCamelCase(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000DA334 File Offset: 0x000D8534
		public static string ToKebabCase(string text)
		{
			return StringUtilsExtensions.ConvertCase(text, '-', new Func<char, char>(Char.ToLowerInvariant), new Func<char, char>(Char.ToLowerInvariant));
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000DA368 File Offset: 0x000D8568
		public static string ToTrainCase(string text)
		{
			return StringUtilsExtensions.ConvertCase(text, '-', new Func<char, char>(Char.ToUpperInvariant), new Func<char, char>(Char.ToUpperInvariant));
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x000DA39C File Offset: 0x000D859C
		public static string ToSnakeCase(string text)
		{
			return StringUtilsExtensions.ConvertCase(text, '_', new Func<char, char>(Char.ToLowerInvariant), new Func<char, char>(Char.ToLowerInvariant));
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x0001543C File Offset: 0x0001363C
		public static string ConvertCase(string text, char outputWordDelimiter, Func<char, char> startOfStringCaseHandler, Func<char, char> middleStringCaseHandler)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x000DA3D0 File Offset: 0x000D85D0
		public static bool EndsWithIgnoreCaseFast(string a, string b)
		{
			int num = a.Length - 1;
			int num2 = b.Length - 1;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			while (num >= 0 && num2 >= 0 && (a.get_Chars(num) == b.get_Chars(num2) || Char.ToLower(a.get_Chars(num), invariantCulture) == Char.ToLower(b.get_Chars(num2), invariantCulture)))
			{
				num--;
				num2--;
			}
			return num2 < 0;
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x000DA44C File Offset: 0x000D864C
		public static bool StartsWithIgnoreCaseFast(string a, string b)
		{
			int length = a.Length;
			int length2 = b.Length;
			int num = 0;
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			while (num < length && num2 < length2 && (a.get_Chars(num) == b.get_Chars(num2) || Char.ToLower(a.get_Chars(num), invariantCulture) == Char.ToLower(b.get_Chars(num2), invariantCulture)))
			{
				num++;
				num2++;
			}
			return num2 == length2;
		}
	}
}
