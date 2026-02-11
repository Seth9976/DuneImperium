using System;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200000F RID: 15
	[Flags]
	public enum DebugLightingFeatureFlags
	{
		// Token: 0x0400004E RID: 78
		None = 0,
		// Token: 0x0400004F RID: 79
		GlobalIllumination = 1,
		// Token: 0x04000050 RID: 80
		MainLight = 2,
		// Token: 0x04000051 RID: 81
		AdditionalLights = 4,
		// Token: 0x04000052 RID: 82
		VertexLighting = 8,
		// Token: 0x04000053 RID: 83
		Emission = 16,
		// Token: 0x04000054 RID: 84
		AmbientOcclusion = 32
	}
}
