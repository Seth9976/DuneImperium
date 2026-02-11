using System;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x02000037 RID: 55
	public static class IJobParticleSystemExtensions
	{
		// Token: 0x06000131 RID: 305 RVA: 0x000022C4 File Offset: 0x000004C4
		public static void EarlyJobInit<T>() where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000022D1 File Offset: 0x000004D1
		public static IntPtr GetReflectionData<T>() where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
