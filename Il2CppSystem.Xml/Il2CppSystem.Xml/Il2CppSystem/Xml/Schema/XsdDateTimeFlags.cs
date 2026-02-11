using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001FA RID: 506
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XsdDateTimeFlags")]
	[Flags]
	public enum XsdDateTimeFlags
	{
		// Token: 0x040021C2 RID: 8642
		DateTime = 1,
		// Token: 0x040021C3 RID: 8643
		Time = 2,
		// Token: 0x040021C4 RID: 8644
		Date = 4,
		// Token: 0x040021C5 RID: 8645
		GYearMonth = 8,
		// Token: 0x040021C6 RID: 8646
		GYear = 16,
		// Token: 0x040021C7 RID: 8647
		GMonthDay = 32,
		// Token: 0x040021C8 RID: 8648
		GDay = 64,
		// Token: 0x040021C9 RID: 8649
		GMonth = 128,
		// Token: 0x040021CA RID: 8650
		XdrDateTimeNoTz = 256,
		// Token: 0x040021CB RID: 8651
		XdrDateTime = 512,
		// Token: 0x040021CC RID: 8652
		XdrTimeNoTz = 1024,
		// Token: 0x040021CD RID: 8653
		AllXsd = 255
	}
}
