using System;

namespace Unity.Profiling.Memory
{
	// Token: 0x0200029C RID: 668
	public enum CaptureFlags : uint
	{
		// Token: 0x040027EC RID: 10220
		ManagedObjects = 1U,
		// Token: 0x040027ED RID: 10221
		NativeObjects,
		// Token: 0x040027EE RID: 10222
		NativeAllocations = 4U,
		// Token: 0x040027EF RID: 10223
		NativeAllocationSites = 8U,
		// Token: 0x040027F0 RID: 10224
		NativeStackTraces = 16U
	}
}
