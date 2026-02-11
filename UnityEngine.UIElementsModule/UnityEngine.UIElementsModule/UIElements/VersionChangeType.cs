using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000154 RID: 340
	[Flags]
	public enum VersionChangeType
	{
		// Token: 0x0400110D RID: 4365
		Bindings = 1,
		// Token: 0x0400110E RID: 4366
		ViewData = 2,
		// Token: 0x0400110F RID: 4367
		Hierarchy = 4,
		// Token: 0x04001110 RID: 4368
		Layout = 8,
		// Token: 0x04001111 RID: 4369
		StyleSheet = 16,
		// Token: 0x04001112 RID: 4370
		Styles = 32,
		// Token: 0x04001113 RID: 4371
		Overflow = 64,
		// Token: 0x04001114 RID: 4372
		BorderRadius = 128,
		// Token: 0x04001115 RID: 4373
		BorderWidth = 256,
		// Token: 0x04001116 RID: 4374
		Transform = 512,
		// Token: 0x04001117 RID: 4375
		Size = 1024,
		// Token: 0x04001118 RID: 4376
		Repaint = 2048,
		// Token: 0x04001119 RID: 4377
		Opacity = 4096,
		// Token: 0x0400111A RID: 4378
		Color = 8192,
		// Token: 0x0400111B RID: 4379
		RenderHints = 16384,
		// Token: 0x0400111C RID: 4380
		TransitionProperty = 32768,
		// Token: 0x0400111D RID: 4381
		EventCallbackCategories = 65536,
		// Token: 0x0400111E RID: 4382
		Picking = 1048576
	}
}
