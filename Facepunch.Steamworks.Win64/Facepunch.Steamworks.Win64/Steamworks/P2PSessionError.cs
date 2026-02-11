using System;

namespace Steamworks
{
	// Token: 0x02000067 RID: 103
	public enum P2PSessionError
	{
		// Token: 0x04000A61 RID: 2657
		None,
		// Token: 0x04000A62 RID: 2658
		NoRightsToApp = 2,
		// Token: 0x04000A63 RID: 2659
		Timeout = 4,
		// Token: 0x04000A64 RID: 2660
		NotRunningApp_DELETED = 1,
		// Token: 0x04000A65 RID: 2661
		DestinationNotLoggedIn_DELETED = 3,
		// Token: 0x04000A66 RID: 2662
		Max = 5
	}
}
