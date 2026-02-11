using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000094 RID: 148
	[OriginalName("System.dll", "System.Diagnostics", "TraceEventType")]
	public enum TraceEventType
	{
		// Token: 0x040008AE RID: 2222
		Critical = 1,
		// Token: 0x040008AF RID: 2223
		Error,
		// Token: 0x040008B0 RID: 2224
		Warning = 4,
		// Token: 0x040008B1 RID: 2225
		Information = 8,
		// Token: 0x040008B2 RID: 2226
		Verbose = 16,
		// Token: 0x040008B3 RID: 2227
		Start = 256,
		// Token: 0x040008B4 RID: 2228
		Stop = 512,
		// Token: 0x040008B5 RID: 2229
		Suspend = 1024,
		// Token: 0x040008B6 RID: 2230
		Resume = 2048,
		// Token: 0x040008B7 RID: 2231
		Transfer = 4096
	}
}
