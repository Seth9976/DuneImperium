using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024A RID: 586
	[Flags]
	public enum SortingCriteria
	{
		// Token: 0x04002360 RID: 9056
		None = 0,
		// Token: 0x04002361 RID: 9057
		SortingLayer = 1,
		// Token: 0x04002362 RID: 9058
		RenderQueue = 2,
		// Token: 0x04002363 RID: 9059
		BackToFront = 4,
		// Token: 0x04002364 RID: 9060
		QuantizedFrontToBack = 8,
		// Token: 0x04002365 RID: 9061
		OptimizeStateChanges = 16,
		// Token: 0x04002366 RID: 9062
		CanvasOrder = 32,
		// Token: 0x04002367 RID: 9063
		RendererPriority = 64,
		// Token: 0x04002368 RID: 9064
		CommonOpaque = 59,
		// Token: 0x04002369 RID: 9065
		CommonTransparent = 23
	}
}
