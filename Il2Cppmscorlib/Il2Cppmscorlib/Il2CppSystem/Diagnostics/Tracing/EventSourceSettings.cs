using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004AD RID: 1197
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceSettings")]
	[Flags]
	public enum EventSourceSettings
	{
		// Token: 0x04003CBF RID: 15551
		Default = 0,
		// Token: 0x04003CC0 RID: 15552
		ThrowOnEventWriteErrors = 1,
		// Token: 0x04003CC1 RID: 15553
		EtwManifestEventFormat = 4,
		// Token: 0x04003CC2 RID: 15554
		EtwSelfDescribingEventFormat = 8
	}
}
