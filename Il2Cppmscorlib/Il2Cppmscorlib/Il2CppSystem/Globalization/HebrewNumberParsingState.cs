using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000477 RID: 1143
	[OriginalName("mscorlib.dll", "System.Globalization", "HebrewNumberParsingState")]
	public enum HebrewNumberParsingState
	{
		// Token: 0x04003902 RID: 14594
		InvalidHebrewNumber,
		// Token: 0x04003903 RID: 14595
		NotHebrewDigit,
		// Token: 0x04003904 RID: 14596
		FoundEndOfHebrewNumber,
		// Token: 0x04003905 RID: 14597
		ContinueParsing
	}
}
