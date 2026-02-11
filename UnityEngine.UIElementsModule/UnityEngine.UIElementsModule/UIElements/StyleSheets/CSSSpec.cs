using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F3 RID: 755
	public static class CSSSpec
	{
		// Token: 0x0600349A RID: 13466 RVA: 0x000DC7E0 File Offset: 0x000DA9E0
		public static int GetSelectorSpecificity(string selector)
		{
			int num = 0;
			Il2CppReferenceArray<StyleSelectorPart> il2CppReferenceArray;
			bool flag = CSSSpec.ParseSelector(selector, out il2CppReferenceArray);
			if (flag)
			{
				num = CSSSpec.GetSelectorSpecificity(il2CppReferenceArray);
			}
			return num;
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x000155F1 File Offset: 0x000137F1
		public static int GetSelectorSpecificity(Il2CppReferenceArray<StyleSelectorPart> parts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x000155FE File Offset: 0x000137FE
		public static bool ParseSelector(string selector, out Il2CppReferenceArray<StyleSelectorPart> parts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04002623 RID: 9763
		public const int typeSelectorWeight = 1;

		// Token: 0x04002624 RID: 9764
		public const int classSelectorWeight = 10;

		// Token: 0x04002625 RID: 9765
		public const int idSelectorWeight = 100;
	}
}
