using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000064 RID: 100
	[OriginalName("System.dll", "System", "UnescapeMode")]
	[Flags]
	public enum UnescapeMode
	{
		// Token: 0x04000527 RID: 1319
		CopyOnly = 0,
		// Token: 0x04000528 RID: 1320
		Escape = 1,
		// Token: 0x04000529 RID: 1321
		Unescape = 2,
		// Token: 0x0400052A RID: 1322
		EscapeUnescape = 3,
		// Token: 0x0400052B RID: 1323
		V1ToStringFlag = 4,
		// Token: 0x0400052C RID: 1324
		UnescapeAll = 8,
		// Token: 0x0400052D RID: 1325
		UnescapeAllOrThrow = 24
	}
}
