using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021E RID: 542
	[Flags]
	public enum VisualElementFlags
	{
		// Token: 0x04001D1A RID: 7450
		WorldTransformDirty = 1,
		// Token: 0x04001D1B RID: 7451
		WorldTransformInverseDirty = 2,
		// Token: 0x04001D1C RID: 7452
		WorldClipDirty = 4,
		// Token: 0x04001D1D RID: 7453
		BoundingBoxDirty = 8,
		// Token: 0x04001D1E RID: 7454
		WorldBoundingBoxDirty = 16,
		// Token: 0x04001D1F RID: 7455
		EventCallbackParentCategoriesDirty = 32,
		// Token: 0x04001D20 RID: 7456
		LayoutManual = 64,
		// Token: 0x04001D21 RID: 7457
		CompositeRoot = 128,
		// Token: 0x04001D22 RID: 7458
		RequireMeasureFunction = 256,
		// Token: 0x04001D23 RID: 7459
		EnableViewDataPersistence = 512,
		// Token: 0x04001D24 RID: 7460
		DisableClipping = 1024,
		// Token: 0x04001D25 RID: 7461
		NeedsAttachToPanelEvent = 2048,
		// Token: 0x04001D26 RID: 7462
		HierarchyDisplayed = 4096,
		// Token: 0x04001D27 RID: 7463
		StyleInitialized = 8192,
		// Token: 0x04001D28 RID: 7464
		Init = 4159
	}
}
