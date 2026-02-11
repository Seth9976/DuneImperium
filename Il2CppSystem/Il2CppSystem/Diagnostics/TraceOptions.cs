using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200009A RID: 154
	[OriginalName("System.dll", "System.Diagnostics", "TraceOptions")]
	[Flags]
	public enum TraceOptions
	{
		// Token: 0x040008F8 RID: 2296
		None = 0,
		// Token: 0x040008F9 RID: 2297
		LogicalOperationStack = 1,
		// Token: 0x040008FA RID: 2298
		DateTime = 2,
		// Token: 0x040008FB RID: 2299
		Timestamp = 4,
		// Token: 0x040008FC RID: 2300
		ProcessId = 8,
		// Token: 0x040008FD RID: 2301
		ThreadId = 16,
		// Token: 0x040008FE RID: 2302
		Callstack = 32
	}
}
