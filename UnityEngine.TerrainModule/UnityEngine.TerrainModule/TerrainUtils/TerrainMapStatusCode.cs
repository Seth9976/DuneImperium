using System;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x02000005 RID: 5
	public enum TerrainMapStatusCode
	{
		// Token: 0x040000BF RID: 191
		OK,
		// Token: 0x040000C0 RID: 192
		Overlapping,
		// Token: 0x040000C1 RID: 193
		SizeMismatch = 4,
		// Token: 0x040000C2 RID: 194
		EdgeAlignmentMismatch = 8
	}
}
