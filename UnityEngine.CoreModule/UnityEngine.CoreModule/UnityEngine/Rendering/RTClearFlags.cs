using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200020C RID: 524
	[Flags]
	public enum RTClearFlags
	{
		// Token: 0x04001E62 RID: 7778
		None = 0,
		// Token: 0x04001E63 RID: 7779
		Color = 1,
		// Token: 0x04001E64 RID: 7780
		Depth = 2,
		// Token: 0x04001E65 RID: 7781
		Stencil = 4,
		// Token: 0x04001E66 RID: 7782
		All = 7,
		// Token: 0x04001E67 RID: 7783
		DepthStencil = 6,
		// Token: 0x04001E68 RID: 7784
		ColorDepth = 3,
		// Token: 0x04001E69 RID: 7785
		ColorStencil = 5
	}
}
