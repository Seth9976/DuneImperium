using System;

namespace UnityEngine
{
	// Token: 0x020000D0 RID: 208
	[Flags]
	public enum RenderTextureCreationFlags
	{
		// Token: 0x04000CA0 RID: 3232
		MipMap = 1,
		// Token: 0x04000CA1 RID: 3233
		AutoGenerateMips = 2,
		// Token: 0x04000CA2 RID: 3234
		SRGB = 4,
		// Token: 0x04000CA3 RID: 3235
		EyeTexture = 8,
		// Token: 0x04000CA4 RID: 3236
		EnableRandomWrite = 16,
		// Token: 0x04000CA5 RID: 3237
		CreatedFromScript = 32,
		// Token: 0x04000CA6 RID: 3238
		AllowVerticalFlip = 128,
		// Token: 0x04000CA7 RID: 3239
		NoResolvedColorSurface = 256,
		// Token: 0x04000CA8 RID: 3240
		DynamicallyScalable = 1024,
		// Token: 0x04000CA9 RID: 3241
		BindMS = 2048
	}
}
