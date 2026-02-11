using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000339 RID: 825
	public enum RenderQueue
	{
		// Token: 0x040029C4 RID: 10692
		Background = 1000,
		// Token: 0x040029C5 RID: 10693
		Geometry = 2000,
		// Token: 0x040029C6 RID: 10694
		AlphaTest = 2450,
		// Token: 0x040029C7 RID: 10695
		GeometryLast = 2500,
		// Token: 0x040029C8 RID: 10696
		Transparent = 3000,
		// Token: 0x040029C9 RID: 10697
		Overlay = 4000
	}
}
