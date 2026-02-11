using System;

namespace Steamworks
{
	// Token: 0x02000049 RID: 73
	public enum UserRestriction
	{
		// Token: 0x040009AF RID: 2479
		None,
		// Token: 0x040009B0 RID: 2480
		Unknown,
		// Token: 0x040009B1 RID: 2481
		AnyChat,
		// Token: 0x040009B2 RID: 2482
		VoiceChat = 4,
		// Token: 0x040009B3 RID: 2483
		GroupChat = 8,
		// Token: 0x040009B4 RID: 2484
		Rating = 16,
		// Token: 0x040009B5 RID: 2485
		GameInvites = 32,
		// Token: 0x040009B6 RID: 2486
		Trading = 64
	}
}
