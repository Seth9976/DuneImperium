using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000035 RID: 53
	[Flags]
	public enum ClearFlag
	{
		// Token: 0x04000336 RID: 822
		None = 0,
		// Token: 0x04000337 RID: 823
		Color = 1,
		// Token: 0x04000338 RID: 824
		Depth = 2,
		// Token: 0x04000339 RID: 825
		Stencil = 4,
		// Token: 0x0400033A RID: 826
		DepthStencil = 6,
		// Token: 0x0400033B RID: 827
		ColorStencil = 5,
		// Token: 0x0400033C RID: 828
		All = 7
	}
}
