using System;

namespace Unity.Collections
{
	// Token: 0x02000039 RID: 57
	public enum Allocator
	{
		// Token: 0x04000186 RID: 390
		Invalid,
		// Token: 0x04000187 RID: 391
		None,
		// Token: 0x04000188 RID: 392
		Temp,
		// Token: 0x04000189 RID: 393
		TempJob,
		// Token: 0x0400018A RID: 394
		Persistent,
		// Token: 0x0400018B RID: 395
		AudioKernel,
		// Token: 0x0400018C RID: 396
		FirstUserIndex = 64
	}
}
