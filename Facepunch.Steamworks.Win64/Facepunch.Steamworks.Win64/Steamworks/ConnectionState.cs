using System;

namespace Steamworks
{
	// Token: 0x02000089 RID: 137
	public enum ConnectionState
	{
		// Token: 0x04000EBC RID: 3772
		None,
		// Token: 0x04000EBD RID: 3773
		Connecting,
		// Token: 0x04000EBE RID: 3774
		FindingRoute,
		// Token: 0x04000EBF RID: 3775
		Connected,
		// Token: 0x04000EC0 RID: 3776
		ClosedByPeer,
		// Token: 0x04000EC1 RID: 3777
		ProblemDetectedLocally,
		// Token: 0x04000EC2 RID: 3778
		FinWait = -1,
		// Token: 0x04000EC3 RID: 3779
		Linger = -2,
		// Token: 0x04000EC4 RID: 3780
		Dead = -3
	}
}
