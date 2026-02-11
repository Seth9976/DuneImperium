using System;

namespace UnityEngine
{
	// Token: 0x02000173 RID: 371
	[Flags]
	public enum DrivenTransformProperties
	{
		// Token: 0x0400187B RID: 6267
		None = 0,
		// Token: 0x0400187C RID: 6268
		All = -1,
		// Token: 0x0400187D RID: 6269
		AnchoredPositionX = 2,
		// Token: 0x0400187E RID: 6270
		AnchoredPositionY = 4,
		// Token: 0x0400187F RID: 6271
		AnchoredPositionZ = 8,
		// Token: 0x04001880 RID: 6272
		Rotation = 16,
		// Token: 0x04001881 RID: 6273
		ScaleX = 32,
		// Token: 0x04001882 RID: 6274
		ScaleY = 64,
		// Token: 0x04001883 RID: 6275
		ScaleZ = 128,
		// Token: 0x04001884 RID: 6276
		AnchorMinX = 256,
		// Token: 0x04001885 RID: 6277
		AnchorMinY = 512,
		// Token: 0x04001886 RID: 6278
		AnchorMaxX = 1024,
		// Token: 0x04001887 RID: 6279
		AnchorMaxY = 2048,
		// Token: 0x04001888 RID: 6280
		SizeDeltaX = 4096,
		// Token: 0x04001889 RID: 6281
		SizeDeltaY = 8192,
		// Token: 0x0400188A RID: 6282
		PivotX = 16384,
		// Token: 0x0400188B RID: 6283
		PivotY = 32768,
		// Token: 0x0400188C RID: 6284
		AnchoredPosition = 6,
		// Token: 0x0400188D RID: 6285
		AnchoredPosition3D = 14,
		// Token: 0x0400188E RID: 6286
		Scale = 224,
		// Token: 0x0400188F RID: 6287
		AnchorMin = 768,
		// Token: 0x04001890 RID: 6288
		AnchorMax = 3072,
		// Token: 0x04001891 RID: 6289
		Anchors = 3840,
		// Token: 0x04001892 RID: 6290
		SizeDelta = 12288,
		// Token: 0x04001893 RID: 6291
		Pivot = 49152
	}
}
