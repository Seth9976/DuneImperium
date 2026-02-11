using System;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[Flags]
	public enum ParticleSystemBakeTextureOptions
	{
		// Token: 0x04000103 RID: 259
		BakeRotationAndScale = 1,
		// Token: 0x04000104 RID: 260
		BakePosition = 2,
		// Token: 0x04000105 RID: 261
		PerVertex = 4,
		// Token: 0x04000106 RID: 262
		PerParticle = 8,
		// Token: 0x04000107 RID: 263
		IncludeParticleIndices = 16,
		// Token: 0x04000108 RID: 264
		Default = 4
	}
}
