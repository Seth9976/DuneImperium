using System;

namespace Steamworks
{
	// Token: 0x0200003A RID: 58
	public enum RoomEnter
	{
		// Token: 0x0400091F RID: 2335
		Success = 1,
		// Token: 0x04000920 RID: 2336
		DoesntExist,
		// Token: 0x04000921 RID: 2337
		NotAllowed,
		// Token: 0x04000922 RID: 2338
		Full,
		// Token: 0x04000923 RID: 2339
		Error,
		// Token: 0x04000924 RID: 2340
		Banned,
		// Token: 0x04000925 RID: 2341
		Limited,
		// Token: 0x04000926 RID: 2342
		ClanDisabled,
		// Token: 0x04000927 RID: 2343
		CommunityBan,
		// Token: 0x04000928 RID: 2344
		MemberBlockedYou,
		// Token: 0x04000929 RID: 2345
		YouBlockedMember,
		// Token: 0x0400092A RID: 2346
		RatelimitExceeded = 15
	}
}
