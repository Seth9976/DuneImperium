using System;

namespace Steamworks
{
	// Token: 0x02000033 RID: 51
	public enum VoiceResult
	{
		// Token: 0x040008D3 RID: 2259
		OK,
		// Token: 0x040008D4 RID: 2260
		NotInitialized,
		// Token: 0x040008D5 RID: 2261
		NotRecording,
		// Token: 0x040008D6 RID: 2262
		NoData,
		// Token: 0x040008D7 RID: 2263
		BufferTooSmall,
		// Token: 0x040008D8 RID: 2264
		DataCorrupted,
		// Token: 0x040008D9 RID: 2265
		Restricted,
		// Token: 0x040008DA RID: 2266
		UnsupportedCodec,
		// Token: 0x040008DB RID: 2267
		ReceiverOutOfDate,
		// Token: 0x040008DC RID: 2268
		ReceiverDidNotAnswer
	}
}
