using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200012A RID: 298
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "RestrictionFlags")]
	[Flags]
	public enum RestrictionFlags
	{
		// Token: 0x04001403 RID: 5123
		Length = 1,
		// Token: 0x04001404 RID: 5124
		MinLength = 2,
		// Token: 0x04001405 RID: 5125
		MaxLength = 4,
		// Token: 0x04001406 RID: 5126
		Pattern = 8,
		// Token: 0x04001407 RID: 5127
		Enumeration = 16,
		// Token: 0x04001408 RID: 5128
		WhiteSpace = 32,
		// Token: 0x04001409 RID: 5129
		MaxInclusive = 64,
		// Token: 0x0400140A RID: 5130
		MaxExclusive = 128,
		// Token: 0x0400140B RID: 5131
		MinInclusive = 256,
		// Token: 0x0400140C RID: 5132
		MinExclusive = 512,
		// Token: 0x0400140D RID: 5133
		TotalDigits = 1024,
		// Token: 0x0400140E RID: 5134
		FractionDigits = 2048
	}
}
