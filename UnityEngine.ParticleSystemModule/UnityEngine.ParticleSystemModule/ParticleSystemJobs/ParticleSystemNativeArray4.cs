using System;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x0200003D RID: 61
	public struct ParticleSystemNativeArray4
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00008918 File Offset: 0x00006B18
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00008960 File Offset: 0x00006B60
		public Vector4 Item
		{
			get
			{
				return new Vector4(this.x[index], this.y[index], this.z[index], this.w[index]);
			}
			set
			{
				this.x[index] = value.x;
				this.y[index] = value.y;
				this.z[index] = value.z;
				this.w[index] = value.w;
			}
		}

		// Token: 0x04000243 RID: 579
		public NativeArray<float> x;

		// Token: 0x04000244 RID: 580
		public NativeArray<float> y;

		// Token: 0x04000245 RID: 581
		public NativeArray<float> z;

		// Token: 0x04000246 RID: 582
		public NativeArray<float> w;
	}
}
