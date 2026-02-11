using System;

namespace Google.Apis.Http
{
	// Token: 0x02000029 RID: 41
	[Flags]
	public enum ExponentialBackOffPolicy
	{
		// Token: 0x0400014A RID: 330
		None = 0,
		// Token: 0x0400014B RID: 331
		Exception = 1,
		// Token: 0x0400014C RID: 332
		UnsuccessfulResponse503 = 2
	}
}
