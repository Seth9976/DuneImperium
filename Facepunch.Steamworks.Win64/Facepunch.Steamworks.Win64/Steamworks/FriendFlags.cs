using System;

namespace Steamworks
{
	// Token: 0x02000048 RID: 72
	public enum FriendFlags
	{
		// Token: 0x040009A2 RID: 2466
		None,
		// Token: 0x040009A3 RID: 2467
		Blocked,
		// Token: 0x040009A4 RID: 2468
		FriendshipRequested,
		// Token: 0x040009A5 RID: 2469
		Immediate = 4,
		// Token: 0x040009A6 RID: 2470
		ClanMember = 8,
		// Token: 0x040009A7 RID: 2471
		OnGameServer = 16,
		// Token: 0x040009A8 RID: 2472
		RequestingFriendship = 128,
		// Token: 0x040009A9 RID: 2473
		RequestingInfo = 256,
		// Token: 0x040009AA RID: 2474
		Ignored = 512,
		// Token: 0x040009AB RID: 2475
		IgnoredFriend = 1024,
		// Token: 0x040009AC RID: 2476
		ChatMember = 4096,
		// Token: 0x040009AD RID: 2477
		All = 65535
	}
}
