using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x02000021 RID: 33
	public enum ProfilerMarkerDataType : byte
	{
		// Token: 0x040000CF RID: 207
		InstanceId = 1,
		// Token: 0x040000D0 RID: 208
		Int32,
		// Token: 0x040000D1 RID: 209
		UInt32,
		// Token: 0x040000D2 RID: 210
		Int64,
		// Token: 0x040000D3 RID: 211
		UInt64,
		// Token: 0x040000D4 RID: 212
		Float,
		// Token: 0x040000D5 RID: 213
		Double,
		// Token: 0x040000D6 RID: 214
		String16 = 9,
		// Token: 0x040000D7 RID: 215
		Blob8 = 11,
		// Token: 0x040000D8 RID: 216
		GfxResourceId
	}
}
