using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021B RID: 539
	[Flags]
	public enum BatchDrawCommandFlags
	{
		// Token: 0x04001FFD RID: 8189
		None = 0,
		// Token: 0x04001FFE RID: 8190
		FlipWinding = 1,
		// Token: 0x04001FFF RID: 8191
		HasMotion = 2,
		// Token: 0x04002000 RID: 8192
		IsLightMapped = 4,
		// Token: 0x04002001 RID: 8193
		HasSortingPosition = 8,
		// Token: 0x04002002 RID: 8194
		LODCrossFade = 16
	}
}
