using System;

namespace Steamworks
{
	// Token: 0x02000080 RID: 128
	public enum ItemState
	{
		// Token: 0x04000E6A RID: 3690
		None,
		// Token: 0x04000E6B RID: 3691
		Subscribed,
		// Token: 0x04000E6C RID: 3692
		LegacyItem,
		// Token: 0x04000E6D RID: 3693
		Installed = 4,
		// Token: 0x04000E6E RID: 3694
		NeedsUpdate = 8,
		// Token: 0x04000E6F RID: 3695
		Downloading = 16,
		// Token: 0x04000E70 RID: 3696
		DownloadPending = 32
	}
}
