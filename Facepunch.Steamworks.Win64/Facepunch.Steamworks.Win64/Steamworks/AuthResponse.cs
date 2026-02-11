using System;

namespace Steamworks
{
	// Token: 0x02000036 RID: 54
	public enum AuthResponse
	{
		// Token: 0x040008F6 RID: 2294
		OK,
		// Token: 0x040008F7 RID: 2295
		UserNotConnectedToSteam,
		// Token: 0x040008F8 RID: 2296
		NoLicenseOrExpired,
		// Token: 0x040008F9 RID: 2297
		VACBanned,
		// Token: 0x040008FA RID: 2298
		LoggedInElseWhere,
		// Token: 0x040008FB RID: 2299
		VACCheckTimedOut,
		// Token: 0x040008FC RID: 2300
		AuthTicketCanceled,
		// Token: 0x040008FD RID: 2301
		AuthTicketInvalidAlreadyUsed,
		// Token: 0x040008FE RID: 2302
		AuthTicketInvalid,
		// Token: 0x040008FF RID: 2303
		PublisherIssuedBan
	}
}
