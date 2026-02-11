using System;

namespace Unity.Profiling
{
	// Token: 0x0200001B RID: 27
	[Flags]
	public enum ProfilerRecorderOptions
	{
		// Token: 0x0400008A RID: 138
		None = 0,
		// Token: 0x0400008B RID: 139
		StartImmediately = 1,
		// Token: 0x0400008C RID: 140
		KeepAliveDuringDomainReload = 2,
		// Token: 0x0400008D RID: 141
		CollectOnlyOnCurrentThread = 4,
		// Token: 0x0400008E RID: 142
		WrapAroundWhenCapacityReached = 8,
		// Token: 0x0400008F RID: 143
		SumAllSamplesInFrame = 16,
		// Token: 0x04000090 RID: 144
		GpuRecorder = 64,
		// Token: 0x04000091 RID: 145
		Default = 24
	}
}
