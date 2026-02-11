using System;

namespace Unity.Burst
{
	// Token: 0x0200000D RID: 13
	[Flags]
	public enum NativeDumpFlags
	{
		// Token: 0x04000109 RID: 265
		None = 0,
		// Token: 0x0400010A RID: 266
		IL = 1,
		// Token: 0x0400010B RID: 267
		Unused = 2,
		// Token: 0x0400010C RID: 268
		IR = 4,
		// Token: 0x0400010D RID: 269
		IROptimized = 8,
		// Token: 0x0400010E RID: 270
		Asm = 16,
		// Token: 0x0400010F RID: 271
		Function = 32,
		// Token: 0x04000110 RID: 272
		Analysis = 64,
		// Token: 0x04000111 RID: 273
		IRPassAnalysis = 128,
		// Token: 0x04000112 RID: 274
		ILPre = 256,
		// Token: 0x04000113 RID: 275
		IRPerEntryPoint = 512,
		// Token: 0x04000114 RID: 276
		All = 1021
	}
}
