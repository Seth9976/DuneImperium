using System;

namespace Steamworks
{
	// Token: 0x02000086 RID: 134
	public enum SteamNetworkingAvailability
	{
		// Token: 0x04000EA1 RID: 3745
		CannotTry = -102,
		// Token: 0x04000EA2 RID: 3746
		Failed,
		// Token: 0x04000EA3 RID: 3747
		Previously,
		// Token: 0x04000EA4 RID: 3748
		Retrying = -10,
		// Token: 0x04000EA5 RID: 3749
		NeverTried = 1,
		// Token: 0x04000EA6 RID: 3750
		Waiting,
		// Token: 0x04000EA7 RID: 3751
		Attempting,
		// Token: 0x04000EA8 RID: 3752
		Current = 100,
		// Token: 0x04000EA9 RID: 3753
		Unknown = 0,
		// Token: 0x04000EAA RID: 3754
		Force32bit = 2147483647
	}
}
