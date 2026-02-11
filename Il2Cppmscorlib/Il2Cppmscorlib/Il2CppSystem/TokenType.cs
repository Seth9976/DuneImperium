using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x020000A2 RID: 162
	[OriginalName("mscorlib.dll", "System", "TokenType")]
	public enum TokenType
	{
		// Token: 0x040008EC RID: 2284
		NumberToken = 1,
		// Token: 0x040008ED RID: 2285
		YearNumberToken,
		// Token: 0x040008EE RID: 2286
		Am,
		// Token: 0x040008EF RID: 2287
		Pm,
		// Token: 0x040008F0 RID: 2288
		MonthToken,
		// Token: 0x040008F1 RID: 2289
		EndOfString,
		// Token: 0x040008F2 RID: 2290
		DayOfWeekToken,
		// Token: 0x040008F3 RID: 2291
		TimeZoneToken,
		// Token: 0x040008F4 RID: 2292
		EraToken,
		// Token: 0x040008F5 RID: 2293
		DateWordToken,
		// Token: 0x040008F6 RID: 2294
		UnknownToken,
		// Token: 0x040008F7 RID: 2295
		HebrewNumber,
		// Token: 0x040008F8 RID: 2296
		JapaneseEraToken,
		// Token: 0x040008F9 RID: 2297
		TEraToken,
		// Token: 0x040008FA RID: 2298
		IgnorableSymbol,
		// Token: 0x040008FB RID: 2299
		SEP_Unk = 256,
		// Token: 0x040008FC RID: 2300
		SEP_End = 512,
		// Token: 0x040008FD RID: 2301
		SEP_Space = 768,
		// Token: 0x040008FE RID: 2302
		SEP_Am = 1024,
		// Token: 0x040008FF RID: 2303
		SEP_Pm = 1280,
		// Token: 0x04000900 RID: 2304
		SEP_Date = 1536,
		// Token: 0x04000901 RID: 2305
		SEP_Time = 1792,
		// Token: 0x04000902 RID: 2306
		SEP_YearSuff = 2048,
		// Token: 0x04000903 RID: 2307
		SEP_MonthSuff = 2304,
		// Token: 0x04000904 RID: 2308
		SEP_DaySuff = 2560,
		// Token: 0x04000905 RID: 2309
		SEP_HourSuff = 2816,
		// Token: 0x04000906 RID: 2310
		SEP_MinuteSuff = 3072,
		// Token: 0x04000907 RID: 2311
		SEP_SecondSuff = 3328,
		// Token: 0x04000908 RID: 2312
		SEP_LocalTimeMark = 3584,
		// Token: 0x04000909 RID: 2313
		SEP_DateOrOffset = 3840,
		// Token: 0x0400090A RID: 2314
		RegularTokenMask = 255,
		// Token: 0x0400090B RID: 2315
		SeparatorTokenMask = 65280
	}
}
