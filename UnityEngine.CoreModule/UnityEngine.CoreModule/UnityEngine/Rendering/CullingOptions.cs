using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022D RID: 557
	[Flags]
	public enum CullingOptions
	{
		// Token: 0x0400212A RID: 8490
		None = 0,
		// Token: 0x0400212B RID: 8491
		ForceEvenIfCameraIsNotActive = 1,
		// Token: 0x0400212C RID: 8492
		OcclusionCull = 2,
		// Token: 0x0400212D RID: 8493
		NeedsLighting = 4,
		// Token: 0x0400212E RID: 8494
		NeedsReflectionProbes = 8,
		// Token: 0x0400212F RID: 8495
		Stereo = 16,
		// Token: 0x04002130 RID: 8496
		DisablePerObjectCulling = 32,
		// Token: 0x04002131 RID: 8497
		ShadowCasters = 64
	}
}
