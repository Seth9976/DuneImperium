using System;

namespace Steamworks
{
	// Token: 0x02000034 RID: 52
	public enum DenyReason
	{
		// Token: 0x040008DE RID: 2270
		Invalid,
		// Token: 0x040008DF RID: 2271
		InvalidVersion,
		// Token: 0x040008E0 RID: 2272
		Generic,
		// Token: 0x040008E1 RID: 2273
		NotLoggedOn,
		// Token: 0x040008E2 RID: 2274
		NoLicense,
		// Token: 0x040008E3 RID: 2275
		Cheater,
		// Token: 0x040008E4 RID: 2276
		LoggedInElseWhere,
		// Token: 0x040008E5 RID: 2277
		UnknownText,
		// Token: 0x040008E6 RID: 2278
		IncompatibleAnticheat,
		// Token: 0x040008E7 RID: 2279
		MemoryCorruption,
		// Token: 0x040008E8 RID: 2280
		IncompatibleSoftware,
		// Token: 0x040008E9 RID: 2281
		SteamConnectionLost,
		// Token: 0x040008EA RID: 2282
		SteamConnectionError,
		// Token: 0x040008EB RID: 2283
		SteamResponseTimedOut,
		// Token: 0x040008EC RID: 2284
		SteamValidationStalled,
		// Token: 0x040008ED RID: 2285
		SteamOwnerLeftGuestUser
	}
}
