using System;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B4 RID: 180
	[Flags]
	public enum ScriptableRenderPassInput
	{
		// Token: 0x04000A92 RID: 2706
		None = 0,
		// Token: 0x04000A93 RID: 2707
		Depth = 1,
		// Token: 0x04000A94 RID: 2708
		Normal = 2,
		// Token: 0x04000A95 RID: 2709
		Color = 4,
		// Token: 0x04000A96 RID: 2710
		Motion = 8
	}
}
