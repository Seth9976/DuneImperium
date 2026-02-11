using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001F6 RID: 502
	[Flags]
	public enum ShadowMapPass
	{
		// Token: 0x04001D67 RID: 7527
		PointlightPositiveX = 1,
		// Token: 0x04001D68 RID: 7528
		PointlightNegativeX = 2,
		// Token: 0x04001D69 RID: 7529
		PointlightPositiveY = 4,
		// Token: 0x04001D6A RID: 7530
		PointlightNegativeY = 8,
		// Token: 0x04001D6B RID: 7531
		PointlightPositiveZ = 16,
		// Token: 0x04001D6C RID: 7532
		PointlightNegativeZ = 32,
		// Token: 0x04001D6D RID: 7533
		DirectionalCascade0 = 64,
		// Token: 0x04001D6E RID: 7534
		DirectionalCascade1 = 128,
		// Token: 0x04001D6F RID: 7535
		DirectionalCascade2 = 256,
		// Token: 0x04001D70 RID: 7536
		DirectionalCascade3 = 512,
		// Token: 0x04001D71 RID: 7537
		Spotlight = 1024,
		// Token: 0x04001D72 RID: 7538
		Pointlight = 63,
		// Token: 0x04001D73 RID: 7539
		Directional = 960,
		// Token: 0x04001D74 RID: 7540
		All = 2047
	}
}
