using System;

namespace UnityEngine.AI
{
	// Token: 0x02000010 RID: 16
	public enum NavMeshBuildDebugFlags
	{
		// Token: 0x040000B7 RID: 183
		None,
		// Token: 0x040000B8 RID: 184
		InputGeometry,
		// Token: 0x040000B9 RID: 185
		Voxels,
		// Token: 0x040000BA RID: 186
		Regions = 4,
		// Token: 0x040000BB RID: 187
		RawContours = 8,
		// Token: 0x040000BC RID: 188
		SimplifiedContours = 16,
		// Token: 0x040000BD RID: 189
		PolygonMeshes = 32,
		// Token: 0x040000BE RID: 190
		PolygonMeshesDetail = 64,
		// Token: 0x040000BF RID: 191
		All = 127
	}
}
