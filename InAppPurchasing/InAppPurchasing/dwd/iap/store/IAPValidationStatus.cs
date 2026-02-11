using System;

namespace dwd.iap.store
{
	// Token: 0x0200000F RID: 15
	public enum IAPValidationStatus
	{
		// Token: 0x0400004D RID: 77
		Validating,
		// Token: 0x0400004E RID: 78
		Valid,
		// Token: 0x0400004F RID: 79
		Failed,
		// Token: 0x04000050 RID: 80
		Invalid,
		// Token: 0x04000051 RID: 81
		AlreadyPurchased,
		// Token: 0x04000052 RID: 82
		Timeout,
		// Token: 0x04000053 RID: 83
		ServerError
	}
}
