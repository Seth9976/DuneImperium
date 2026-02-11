using System;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[Flags]
	public enum ParticleSystemVertexStreams
	{
		// Token: 0x0400010A RID: 266
		Position = 1,
		// Token: 0x0400010B RID: 267
		Normal = 2,
		// Token: 0x0400010C RID: 268
		Tangent = 4,
		// Token: 0x0400010D RID: 269
		Color = 8,
		// Token: 0x0400010E RID: 270
		UV = 16,
		// Token: 0x0400010F RID: 271
		UV2BlendAndFrame = 32,
		// Token: 0x04000110 RID: 272
		CenterAndVertexID = 64,
		// Token: 0x04000111 RID: 273
		Size = 128,
		// Token: 0x04000112 RID: 274
		Rotation = 256,
		// Token: 0x04000113 RID: 275
		Velocity = 512,
		// Token: 0x04000114 RID: 276
		Lifetime = 1024,
		// Token: 0x04000115 RID: 277
		Custom1 = 2048,
		// Token: 0x04000116 RID: 278
		Custom2 = 4096,
		// Token: 0x04000117 RID: 279
		Random = 8192,
		// Token: 0x04000118 RID: 280
		None = 0,
		// Token: 0x04000119 RID: 281
		All = 2147483647
	}
}
