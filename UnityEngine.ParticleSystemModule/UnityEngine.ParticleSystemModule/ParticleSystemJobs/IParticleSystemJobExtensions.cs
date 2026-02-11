using System;
using System.Runtime.InteropServices;
using Unity.Jobs;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x0200003B RID: 59
	public static class IParticleSystemJobExtensions
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00002312 File Offset: 0x00000512
		public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000231F File Offset: 0x0000051F
		public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, int minIndicesPerJobCount, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000232C File Offset: 0x0000052C
		public static JobHandle ScheduleBatch<T>(T jobData, ParticleSystem ps, int innerLoopBatchCount, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
