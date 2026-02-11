using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000262 RID: 610
	[Flags]
	public enum RenderDataDirtyTypes
	{
		// Token: 0x04002097 RID: 8343
		None = 0,
		// Token: 0x04002098 RID: 8344
		Transform = 1,
		// Token: 0x04002099 RID: 8345
		ClipRectSize = 2,
		// Token: 0x0400209A RID: 8346
		Clipping = 4,
		// Token: 0x0400209B RID: 8347
		ClippingHierarchy = 8,
		// Token: 0x0400209C RID: 8348
		Visuals = 16,
		// Token: 0x0400209D RID: 8349
		VisualsHierarchy = 32,
		// Token: 0x0400209E RID: 8350
		VisualsOpacityId = 64,
		// Token: 0x0400209F RID: 8351
		Opacity = 128,
		// Token: 0x040020A0 RID: 8352
		OpacityHierarchy = 256,
		// Token: 0x040020A1 RID: 8353
		Color = 512,
		// Token: 0x040020A2 RID: 8354
		AllVisuals = 112
	}
}
