using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200000D RID: 13
	[OriginalName("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "ActivityTrackingOptions")]
	[Flags]
	public enum ActivityTrackingOptions
	{
		// Token: 0x0400001B RID: 27
		None = 0,
		// Token: 0x0400001C RID: 28
		SpanId = 1,
		// Token: 0x0400001D RID: 29
		TraceId = 2,
		// Token: 0x0400001E RID: 30
		ParentId = 4,
		// Token: 0x0400001F RID: 31
		TraceState = 8,
		// Token: 0x04000020 RID: 32
		TraceFlags = 16,
		// Token: 0x04000021 RID: 33
		Tags = 32,
		// Token: 0x04000022 RID: 34
		Baggage = 64
	}
}
