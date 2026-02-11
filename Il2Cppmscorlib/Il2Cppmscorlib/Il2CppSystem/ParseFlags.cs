using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200009F RID: 159
	[OriginalName("mscorlib.dll", "System", "ParseFlags")]
	[Flags]
	public enum ParseFlags
	{
		// Token: 0x040008B8 RID: 2232
		HaveYear = 1,
		// Token: 0x040008B9 RID: 2233
		HaveMonth = 2,
		// Token: 0x040008BA RID: 2234
		HaveDay = 4,
		// Token: 0x040008BB RID: 2235
		HaveHour = 8,
		// Token: 0x040008BC RID: 2236
		HaveMinute = 16,
		// Token: 0x040008BD RID: 2237
		HaveSecond = 32,
		// Token: 0x040008BE RID: 2238
		HaveTime = 64,
		// Token: 0x040008BF RID: 2239
		HaveDate = 128,
		// Token: 0x040008C0 RID: 2240
		TimeZoneUsed = 256,
		// Token: 0x040008C1 RID: 2241
		TimeZoneUtc = 512,
		// Token: 0x040008C2 RID: 2242
		ParsedMonthName = 1024,
		// Token: 0x040008C3 RID: 2243
		CaptureOffset = 2048,
		// Token: 0x040008C4 RID: 2244
		YearDefault = 4096,
		// Token: 0x040008C5 RID: 2245
		Rfc1123Pattern = 8192,
		// Token: 0x040008C6 RID: 2246
		UtcSortPattern = 16384
	}
}
