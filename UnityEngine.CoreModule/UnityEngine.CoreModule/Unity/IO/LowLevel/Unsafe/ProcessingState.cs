using System;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200002B RID: 43
	public enum ProcessingState
	{
		// Token: 0x04000155 RID: 341
		Unknown,
		// Token: 0x04000156 RID: 342
		InQueue,
		// Token: 0x04000157 RID: 343
		Reading,
		// Token: 0x04000158 RID: 344
		Completed,
		// Token: 0x04000159 RID: 345
		Failed,
		// Token: 0x0400015A RID: 346
		Canceled
	}
}
