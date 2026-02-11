using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x02000020 RID: 32
	[Flags]
	public enum MarkerFlags : ushort
	{
		// Token: 0x040000C5 RID: 197
		Default = 0,
		// Token: 0x040000C6 RID: 198
		Script = 2,
		// Token: 0x040000C7 RID: 199
		ScriptInvoke = 32,
		// Token: 0x040000C8 RID: 200
		ScriptDeepProfiler = 64,
		// Token: 0x040000C9 RID: 201
		AvailabilityEditor = 4,
		// Token: 0x040000CA RID: 202
		AvailabilityNonDevelopment = 8,
		// Token: 0x040000CB RID: 203
		Warning = 16,
		// Token: 0x040000CC RID: 204
		Counter = 128,
		// Token: 0x040000CD RID: 205
		SampleGPU = 256
	}
}
