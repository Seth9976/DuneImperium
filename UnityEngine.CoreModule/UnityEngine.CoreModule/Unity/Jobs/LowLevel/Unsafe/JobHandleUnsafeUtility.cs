using System;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000298 RID: 664
	public static class JobHandleUnsafeUtility
	{
		// Token: 0x06002C87 RID: 11399 RVA: 0x000B27B4 File Offset: 0x000B09B4
		public unsafe static JobHandle CombineDependencies(JobHandle* jobs, int count)
		{
			return JobHandle.CombineDependenciesInternalPtr((void*)jobs, count);
		}
	}
}
