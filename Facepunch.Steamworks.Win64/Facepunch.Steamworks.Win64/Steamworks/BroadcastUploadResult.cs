using System;

namespace Steamworks
{
	// Token: 0x0200003D RID: 61
	public enum BroadcastUploadResult
	{
		// Token: 0x04000936 RID: 2358
		None,
		// Token: 0x04000937 RID: 2359
		OK,
		// Token: 0x04000938 RID: 2360
		InitFailed,
		// Token: 0x04000939 RID: 2361
		FrameFailed,
		// Token: 0x0400093A RID: 2362
		Timeout,
		// Token: 0x0400093B RID: 2363
		BandwidthExceeded,
		// Token: 0x0400093C RID: 2364
		LowFPS,
		// Token: 0x0400093D RID: 2365
		MissingKeyFrames,
		// Token: 0x0400093E RID: 2366
		NoConnection,
		// Token: 0x0400093F RID: 2367
		RelayFailed,
		// Token: 0x04000940 RID: 2368
		SettingsChanged,
		// Token: 0x04000941 RID: 2369
		MissingAudio,
		// Token: 0x04000942 RID: 2370
		TooFarBehind,
		// Token: 0x04000943 RID: 2371
		TranscodeBehind,
		// Token: 0x04000944 RID: 2372
		NotAllowedToPlay,
		// Token: 0x04000945 RID: 2373
		Busy,
		// Token: 0x04000946 RID: 2374
		Banned,
		// Token: 0x04000947 RID: 2375
		AlreadyActive,
		// Token: 0x04000948 RID: 2376
		ForcedOff,
		// Token: 0x04000949 RID: 2377
		AudioBehind,
		// Token: 0x0400094A RID: 2378
		Shutdown,
		// Token: 0x0400094B RID: 2379
		Disconnect,
		// Token: 0x0400094C RID: 2380
		VideoInitFailed,
		// Token: 0x0400094D RID: 2381
		AudioInitFailed
	}
}
