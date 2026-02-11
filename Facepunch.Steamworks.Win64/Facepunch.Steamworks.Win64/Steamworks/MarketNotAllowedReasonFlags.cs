using System;

namespace Steamworks
{
	// Token: 0x0200003E RID: 62
	public enum MarketNotAllowedReasonFlags
	{
		// Token: 0x0400094F RID: 2383
		None,
		// Token: 0x04000950 RID: 2384
		TemporaryFailure,
		// Token: 0x04000951 RID: 2385
		AccountDisabled,
		// Token: 0x04000952 RID: 2386
		AccountLockedDown = 4,
		// Token: 0x04000953 RID: 2387
		AccountLimited = 8,
		// Token: 0x04000954 RID: 2388
		TradeBanned = 16,
		// Token: 0x04000955 RID: 2389
		AccountNotTrusted = 32,
		// Token: 0x04000956 RID: 2390
		SteamGuardNotEnabled = 64,
		// Token: 0x04000957 RID: 2391
		SteamGuardOnlyRecentlyEnabled = 128,
		// Token: 0x04000958 RID: 2392
		RecentPasswordReset = 256,
		// Token: 0x04000959 RID: 2393
		NewPaymentMethod = 512,
		// Token: 0x0400095A RID: 2394
		InvalidCookie = 1024,
		// Token: 0x0400095B RID: 2395
		UsingNewDevice = 2048,
		// Token: 0x0400095C RID: 2396
		RecentSelfRefund = 4096,
		// Token: 0x0400095D RID: 2397
		NewPaymentMethodCannotBeVerified = 8192,
		// Token: 0x0400095E RID: 2398
		NoRecentPurchases = 16384,
		// Token: 0x0400095F RID: 2399
		AcceptedWalletGift = 32768
	}
}
