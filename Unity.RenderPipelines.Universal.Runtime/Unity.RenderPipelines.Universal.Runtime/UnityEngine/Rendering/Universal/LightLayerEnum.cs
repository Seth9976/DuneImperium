using System;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000EB RID: 235
	[Flags]
	public enum LightLayerEnum
	{
		// Token: 0x04000D37 RID: 3383
		Nothing = 0,
		// Token: 0x04000D38 RID: 3384
		LightLayerDefault = 1,
		// Token: 0x04000D39 RID: 3385
		LightLayer1 = 2,
		// Token: 0x04000D3A RID: 3386
		LightLayer2 = 4,
		// Token: 0x04000D3B RID: 3387
		LightLayer3 = 8,
		// Token: 0x04000D3C RID: 3388
		LightLayer4 = 16,
		// Token: 0x04000D3D RID: 3389
		LightLayer5 = 32,
		// Token: 0x04000D3E RID: 3390
		LightLayer6 = 64,
		// Token: 0x04000D3F RID: 3391
		LightLayer7 = 128,
		// Token: 0x04000D40 RID: 3392
		Everything = 255
	}
}
