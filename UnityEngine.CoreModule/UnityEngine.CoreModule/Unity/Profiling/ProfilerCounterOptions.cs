using System;

namespace Unity.Profiling
{
	// Token: 0x0200001A RID: 26
	[Flags]
	public enum ProfilerCounterOptions : ushort
	{
		// Token: 0x04000086 RID: 134
		None = 0,
		// Token: 0x04000087 RID: 135
		FlushOnEndOfFrame = 2,
		// Token: 0x04000088 RID: 136
		ResetToZeroOnFlush = 4
	}
}
