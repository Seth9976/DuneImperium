using System;

namespace UnityEngine.Android
{
	// Token: 0x02000011 RID: 17
	public enum AndroidAssetPackError
	{
		// Token: 0x0400017E RID: 382
		NoError,
		// Token: 0x0400017F RID: 383
		AppUnavailable = -1,
		// Token: 0x04000180 RID: 384
		PackUnavailable = -2,
		// Token: 0x04000181 RID: 385
		InvalidRequest = -3,
		// Token: 0x04000182 RID: 386
		DownloadNotFound = -4,
		// Token: 0x04000183 RID: 387
		ApiNotAvailable = -5,
		// Token: 0x04000184 RID: 388
		NetworkError = -6,
		// Token: 0x04000185 RID: 389
		AccessDenied = -7,
		// Token: 0x04000186 RID: 390
		InsufficientStorage = -10,
		// Token: 0x04000187 RID: 391
		PlayStoreNotFound = -11,
		// Token: 0x04000188 RID: 392
		NetworkUnrestricted = -12,
		// Token: 0x04000189 RID: 393
		AppNotOwned = -13,
		// Token: 0x0400018A RID: 394
		InternalError = -100
	}
}
