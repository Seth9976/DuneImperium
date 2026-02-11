using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000474 RID: 1140
	[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeStyles")]
	[Flags]
	public enum DateTimeStyles
	{
		// Token: 0x040038EB RID: 14571
		None = 0,
		// Token: 0x040038EC RID: 14572
		AllowLeadingWhite = 1,
		// Token: 0x040038ED RID: 14573
		AllowTrailingWhite = 2,
		// Token: 0x040038EE RID: 14574
		AllowInnerWhite = 4,
		// Token: 0x040038EF RID: 14575
		AllowWhiteSpaces = 7,
		// Token: 0x040038F0 RID: 14576
		NoCurrentDateDefault = 8,
		// Token: 0x040038F1 RID: 14577
		AdjustToUniversal = 16,
		// Token: 0x040038F2 RID: 14578
		AssumeLocal = 32,
		// Token: 0x040038F3 RID: 14579
		AssumeUniversal = 64,
		// Token: 0x040038F4 RID: 14580
		RoundtripKind = 128
	}
}
