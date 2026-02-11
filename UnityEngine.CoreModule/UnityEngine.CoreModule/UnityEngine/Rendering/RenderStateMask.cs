using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000244 RID: 580
	[Flags]
	public enum RenderStateMask
	{
		// Token: 0x040022C5 RID: 8901
		Nothing = 0,
		// Token: 0x040022C6 RID: 8902
		Blend = 1,
		// Token: 0x040022C7 RID: 8903
		Raster = 2,
		// Token: 0x040022C8 RID: 8904
		Depth = 4,
		// Token: 0x040022C9 RID: 8905
		Stencil = 8,
		// Token: 0x040022CA RID: 8906
		Everything = 15
	}
}
