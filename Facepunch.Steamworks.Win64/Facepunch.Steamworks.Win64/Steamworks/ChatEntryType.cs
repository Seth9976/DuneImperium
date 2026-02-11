using System;

namespace Steamworks
{
	// Token: 0x02000039 RID: 57
	public enum ChatEntryType
	{
		// Token: 0x04000912 RID: 2322
		Invalid,
		// Token: 0x04000913 RID: 2323
		ChatMsg,
		// Token: 0x04000914 RID: 2324
		Typing,
		// Token: 0x04000915 RID: 2325
		InviteGame,
		// Token: 0x04000916 RID: 2326
		Emote,
		// Token: 0x04000917 RID: 2327
		LeftConversation = 6,
		// Token: 0x04000918 RID: 2328
		Entered,
		// Token: 0x04000919 RID: 2329
		WasKicked,
		// Token: 0x0400091A RID: 2330
		WasBanned,
		// Token: 0x0400091B RID: 2331
		Disconnected,
		// Token: 0x0400091C RID: 2332
		HistoricalChat,
		// Token: 0x0400091D RID: 2333
		LinkBlocked = 14
	}
}
