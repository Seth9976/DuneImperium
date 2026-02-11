using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200009E RID: 158
	[OriginalName("mscorlib.dll", "System", "ParseFailureKind")]
	public enum ParseFailureKind
	{
		// Token: 0x040008AF RID: 2223
		None,
		// Token: 0x040008B0 RID: 2224
		ArgumentNull,
		// Token: 0x040008B1 RID: 2225
		Format,
		// Token: 0x040008B2 RID: 2226
		FormatWithParameter,
		// Token: 0x040008B3 RID: 2227
		FormatWithOriginalDateTime,
		// Token: 0x040008B4 RID: 2228
		FormatWithFormatSpecifier,
		// Token: 0x040008B5 RID: 2229
		FormatWithOriginalDateTimeAndParameter,
		// Token: 0x040008B6 RID: 2230
		FormatBadDateTimeCalendar
	}
}
