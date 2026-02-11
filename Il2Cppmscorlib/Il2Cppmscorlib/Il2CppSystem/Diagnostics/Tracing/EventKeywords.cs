using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004A9 RID: 1193
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventKeywords")]
	[Flags]
	public enum EventKeywords : long
	{
		// Token: 0x04003C8E RID: 15502
		None = 0L,
		// Token: 0x04003C8F RID: 15503
		All = -1L,
		// Token: 0x04003C90 RID: 15504
		MicrosoftTelemetry = 562949953421312L,
		// Token: 0x04003C91 RID: 15505
		WdiContext = 562949953421312L,
		// Token: 0x04003C92 RID: 15506
		WdiDiagnostic = 1125899906842624L,
		// Token: 0x04003C93 RID: 15507
		Sqm = 2251799813685248L,
		// Token: 0x04003C94 RID: 15508
		AuditFailure = 4503599627370496L,
		// Token: 0x04003C95 RID: 15509
		AuditSuccess = 9007199254740992L,
		// Token: 0x04003C96 RID: 15510
		CorrelationHint = 4503599627370496L,
		// Token: 0x04003C97 RID: 15511
		EventLogClassic = 36028797018963968L
	}
}
