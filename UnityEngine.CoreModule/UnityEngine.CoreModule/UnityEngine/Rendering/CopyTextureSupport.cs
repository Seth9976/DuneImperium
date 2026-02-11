using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000206 RID: 518
	[Flags]
	public enum CopyTextureSupport
	{
		// Token: 0x04001E48 RID: 7752
		None = 0,
		// Token: 0x04001E49 RID: 7753
		Basic = 1,
		// Token: 0x04001E4A RID: 7754
		Copy3D = 2,
		// Token: 0x04001E4B RID: 7755
		DifferentTypes = 4,
		// Token: 0x04001E4C RID: 7756
		TextureToRT = 8,
		// Token: 0x04001E4D RID: 7757
		RTToTexture = 16
	}
}
