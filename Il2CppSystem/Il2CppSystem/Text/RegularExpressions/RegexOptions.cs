using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000085 RID: 133
	[OriginalName("System.dll", "System.Text.RegularExpressions", "RegexOptions")]
	[Flags]
	public enum RegexOptions
	{
		// Token: 0x040007C3 RID: 1987
		None = 0,
		// Token: 0x040007C4 RID: 1988
		IgnoreCase = 1,
		// Token: 0x040007C5 RID: 1989
		Multiline = 2,
		// Token: 0x040007C6 RID: 1990
		ExplicitCapture = 4,
		// Token: 0x040007C7 RID: 1991
		Compiled = 8,
		// Token: 0x040007C8 RID: 1992
		Singleline = 16,
		// Token: 0x040007C9 RID: 1993
		IgnorePatternWhitespace = 32,
		// Token: 0x040007CA RID: 1994
		RightToLeft = 64,
		// Token: 0x040007CB RID: 1995
		ECMAScript = 256,
		// Token: 0x040007CC RID: 1996
		CultureInvariant = 512
	}
}
