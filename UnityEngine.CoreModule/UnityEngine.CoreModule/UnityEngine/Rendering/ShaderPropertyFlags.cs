using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000259 RID: 601
	[Flags]
	public enum ShaderPropertyFlags
	{
		// Token: 0x04002482 RID: 9346
		None = 0,
		// Token: 0x04002483 RID: 9347
		HideInInspector = 1,
		// Token: 0x04002484 RID: 9348
		PerRendererData = 2,
		// Token: 0x04002485 RID: 9349
		NoScaleOffset = 4,
		// Token: 0x04002486 RID: 9350
		Normal = 8,
		// Token: 0x04002487 RID: 9351
		HDR = 16,
		// Token: 0x04002488 RID: 9352
		Gamma = 32,
		// Token: 0x04002489 RID: 9353
		NonModifiableTextureData = 64,
		// Token: 0x0400248A RID: 9354
		MainTexture = 128,
		// Token: 0x0400248B RID: 9355
		MainColor = 256
	}
}
