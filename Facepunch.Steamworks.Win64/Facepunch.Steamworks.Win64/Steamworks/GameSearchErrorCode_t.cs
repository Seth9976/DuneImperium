using System;

namespace Steamworks
{
	// Token: 0x02000042 RID: 66
	public enum GameSearchErrorCode_t
	{
		// Token: 0x04000976 RID: 2422
		OK = 1,
		// Token: 0x04000977 RID: 2423
		Failed_Search_Already_In_Progress,
		// Token: 0x04000978 RID: 2424
		Failed_No_Search_In_Progress,
		// Token: 0x04000979 RID: 2425
		Failed_Not_Lobby_Leader,
		// Token: 0x0400097A RID: 2426
		Failed_No_Host_Available,
		// Token: 0x0400097B RID: 2427
		Failed_Search_Params_Invalid,
		// Token: 0x0400097C RID: 2428
		Failed_Offline,
		// Token: 0x0400097D RID: 2429
		Failed_NotAuthorized,
		// Token: 0x0400097E RID: 2430
		Failed_Unknown_Error
	}
}
