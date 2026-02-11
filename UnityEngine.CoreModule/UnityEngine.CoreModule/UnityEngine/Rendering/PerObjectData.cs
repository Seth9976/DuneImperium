using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000238 RID: 568
	[Flags]
	public enum PerObjectData
	{
		// Token: 0x04002209 RID: 8713
		None = 0,
		// Token: 0x0400220A RID: 8714
		LightProbe = 1,
		// Token: 0x0400220B RID: 8715
		ReflectionProbes = 2,
		// Token: 0x0400220C RID: 8716
		LightProbeProxyVolume = 4,
		// Token: 0x0400220D RID: 8717
		Lightmaps = 8,
		// Token: 0x0400220E RID: 8718
		LightData = 16,
		// Token: 0x0400220F RID: 8719
		MotionVectors = 32,
		// Token: 0x04002210 RID: 8720
		LightIndices = 64,
		// Token: 0x04002211 RID: 8721
		ReflectionProbeData = 128,
		// Token: 0x04002212 RID: 8722
		OcclusionProbe = 256,
		// Token: 0x04002213 RID: 8723
		OcclusionProbeProxyVolume = 512,
		// Token: 0x04002214 RID: 8724
		ShadowMask = 1024
	}
}
