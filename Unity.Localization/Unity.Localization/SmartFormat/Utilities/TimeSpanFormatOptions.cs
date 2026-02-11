using System;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x0200003F RID: 63
	[Flags]
	public enum TimeSpanFormatOptions
	{
		// Token: 0x040002DA RID: 730
		InheritDefaults = 0,
		// Token: 0x040002DB RID: 731
		Abbreviate = 1,
		// Token: 0x040002DC RID: 732
		AbbreviateOff = 2,
		// Token: 0x040002DD RID: 733
		LessThan = 4,
		// Token: 0x040002DE RID: 734
		LessThanOff = 8,
		// Token: 0x040002DF RID: 735
		TruncateShortest = 16,
		// Token: 0x040002E0 RID: 736
		TruncateAuto = 32,
		// Token: 0x040002E1 RID: 737
		TruncateFill = 64,
		// Token: 0x040002E2 RID: 738
		TruncateFull = 128,
		// Token: 0x040002E3 RID: 739
		RangeMilliSeconds = 256,
		// Token: 0x040002E4 RID: 740
		RangeSeconds = 512,
		// Token: 0x040002E5 RID: 741
		RangeMinutes = 1024,
		// Token: 0x040002E6 RID: 742
		RangeHours = 2048,
		// Token: 0x040002E7 RID: 743
		RangeDays = 4096,
		// Token: 0x040002E8 RID: 744
		RangeWeeks = 8192
	}
}
