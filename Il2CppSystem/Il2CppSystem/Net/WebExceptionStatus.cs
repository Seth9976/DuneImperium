using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020001C3 RID: 451
	[OriginalName("System.dll", "System.Net", "WebExceptionStatus")]
	public enum WebExceptionStatus
	{
		// Token: 0x040015ED RID: 5613
		Success,
		// Token: 0x040015EE RID: 5614
		NameResolutionFailure,
		// Token: 0x040015EF RID: 5615
		ConnectFailure,
		// Token: 0x040015F0 RID: 5616
		ReceiveFailure,
		// Token: 0x040015F1 RID: 5617
		SendFailure,
		// Token: 0x040015F2 RID: 5618
		PipelineFailure,
		// Token: 0x040015F3 RID: 5619
		RequestCanceled,
		// Token: 0x040015F4 RID: 5620
		ProtocolError,
		// Token: 0x040015F5 RID: 5621
		ConnectionClosed,
		// Token: 0x040015F6 RID: 5622
		TrustFailure,
		// Token: 0x040015F7 RID: 5623
		SecureChannelFailure,
		// Token: 0x040015F8 RID: 5624
		ServerProtocolViolation,
		// Token: 0x040015F9 RID: 5625
		KeepAliveFailure,
		// Token: 0x040015FA RID: 5626
		Pending,
		// Token: 0x040015FB RID: 5627
		Timeout,
		// Token: 0x040015FC RID: 5628
		ProxyNameResolutionFailure,
		// Token: 0x040015FD RID: 5629
		UnknownError,
		// Token: 0x040015FE RID: 5630
		MessageLengthLimitExceeded,
		// Token: 0x040015FF RID: 5631
		CacheEntryNotFound,
		// Token: 0x04001600 RID: 5632
		RequestProhibitedByCachePolicy,
		// Token: 0x04001601 RID: 5633
		RequestProhibitedByProxy
	}
}
