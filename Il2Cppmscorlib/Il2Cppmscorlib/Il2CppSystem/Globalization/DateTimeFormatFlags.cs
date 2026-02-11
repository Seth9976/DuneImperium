using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200046F RID: 1135
	[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeFormatFlags")]
	[Flags]
	public enum DateTimeFormatFlags
	{
		// Token: 0x040037FC RID: 14332
		None = 0,
		// Token: 0x040037FD RID: 14333
		UseGenitiveMonth = 1,
		// Token: 0x040037FE RID: 14334
		UseLeapYearMonth = 2,
		// Token: 0x040037FF RID: 14335
		UseSpacesInMonthNames = 4,
		// Token: 0x04003800 RID: 14336
		UseHebrewRule = 8,
		// Token: 0x04003801 RID: 14337
		UseSpacesInDayNames = 16,
		// Token: 0x04003802 RID: 14338
		UseDigitPrefixInTokens = 32,
		// Token: 0x04003803 RID: 14339
		NotInitialized = -1
	}
}
