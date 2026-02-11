using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200009B RID: 155
	[OriginalName("System.Data.dll", "System.Data.SqlTypes", "SqlCompareOptions")]
	[Flags]
	public enum SqlCompareOptions
	{
		// Token: 0x04000D8B RID: 3467
		None = 0,
		// Token: 0x04000D8C RID: 3468
		IgnoreCase = 1,
		// Token: 0x04000D8D RID: 3469
		IgnoreNonSpace = 2,
		// Token: 0x04000D8E RID: 3470
		IgnoreKanaType = 8,
		// Token: 0x04000D8F RID: 3471
		IgnoreWidth = 16,
		// Token: 0x04000D90 RID: 3472
		BinarySort = 32768,
		// Token: 0x04000D91 RID: 3473
		BinarySort2 = 16384
	}
}
