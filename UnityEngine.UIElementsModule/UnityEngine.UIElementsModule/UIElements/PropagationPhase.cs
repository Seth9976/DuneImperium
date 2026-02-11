using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E5 RID: 229
	public enum PropagationPhase
	{
		// Token: 0x04000D2D RID: 3373
		None,
		// Token: 0x04000D2E RID: 3374
		TrickleDown,
		// Token: 0x04000D2F RID: 3375
		AtTarget,
		// Token: 0x04000D30 RID: 3376
		DefaultActionAtTarget = 5,
		// Token: 0x04000D31 RID: 3377
		BubbleUp = 3,
		// Token: 0x04000D32 RID: 3378
		DefaultAction
	}
}
