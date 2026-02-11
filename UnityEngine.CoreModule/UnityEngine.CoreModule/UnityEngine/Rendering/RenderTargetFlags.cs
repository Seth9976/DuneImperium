using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000200 RID: 512
	[Flags]
	public enum RenderTargetFlags
	{
		// Token: 0x04001E08 RID: 7688
		None = 0,
		// Token: 0x04001E09 RID: 7689
		ReadOnlyDepth = 1,
		// Token: 0x04001E0A RID: 7690
		ReadOnlyStencil = 2,
		// Token: 0x04001E0B RID: 7691
		ReadOnlyDepthStencil = 3
	}
}
