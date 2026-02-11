using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000282 RID: 642
	[Flags]
	public enum TextureCreationFlags
	{
		// Token: 0x04002686 RID: 9862
		None = 0,
		// Token: 0x04002687 RID: 9863
		MipChain = 1,
		// Token: 0x04002688 RID: 9864
		DontInitializePixels = 4,
		// Token: 0x04002689 RID: 9865
		Crunch = 64,
		// Token: 0x0400268A RID: 9866
		DontUploadUponCreate = 1024,
		// Token: 0x0400268B RID: 9867
		IgnoreMipmapLimit = 2048
	}
}
