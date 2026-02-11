using System;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x0200003C RID: 60
	public struct ParticleSystemNativeArray3
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000088DC File Offset: 0x00006ADC
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002339 File Offset: 0x00000539
		public Vector3 Item
		{
			get
			{
				return new Vector3(this.x[index], this.y[index], this.z[index]);
			}
			set
			{
				this.x[index] = value.x;
				this.y[index] = value.y;
				this.z[index] = value.z;
			}
		}

		// Token: 0x04000240 RID: 576
		public NativeArray<float> x;

		// Token: 0x04000241 RID: 577
		public NativeArray<float> y;

		// Token: 0x04000242 RID: 578
		public NativeArray<float> z;
	}
}
