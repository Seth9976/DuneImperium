using System;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200029E RID: 670
	public enum ReadStatus
	{
		// Token: 0x040027F7 RID: 10231
		Complete,
		// Token: 0x040027F8 RID: 10232
		InProgress,
		// Token: 0x040027F9 RID: 10233
		Failed,
		// Token: 0x040027FA RID: 10234
		Truncated = 4,
		// Token: 0x040027FB RID: 10235
		Canceled
	}
}
