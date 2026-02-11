using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000156 RID: 342
	[Flags]
	public enum RenderHints
	{
		// Token: 0x04001126 RID: 4390
		None = 0,
		// Token: 0x04001127 RID: 4391
		GroupTransform = 1,
		// Token: 0x04001128 RID: 4392
		BoneTransform = 2,
		// Token: 0x04001129 RID: 4393
		ClipWithScissors = 4,
		// Token: 0x0400112A RID: 4394
		MaskContainer = 8,
		// Token: 0x0400112B RID: 4395
		DynamicColor = 16,
		// Token: 0x0400112C RID: 4396
		DirtyOffset = 5,
		// Token: 0x0400112D RID: 4397
		DirtyGroupTransform = 32,
		// Token: 0x0400112E RID: 4398
		DirtyBoneTransform = 64,
		// Token: 0x0400112F RID: 4399
		DirtyClipWithScissors = 128,
		// Token: 0x04001130 RID: 4400
		DirtyMaskContainer = 256,
		// Token: 0x04001131 RID: 4401
		DirtyDynamicColor = 512,
		// Token: 0x04001132 RID: 4402
		DirtyAll = 992
	}
}
