using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Flags]
	public enum MeshColliderCookingOptions
	{
		// Token: 0x04000007 RID: 7
		None = 0,
		// Token: 0x04000008 RID: 8
		InflateConvexMesh = 1,
		// Token: 0x04000009 RID: 9
		CookForFasterSimulation = 2,
		// Token: 0x0400000A RID: 10
		EnableMeshCleaning = 4,
		// Token: 0x0400000B RID: 11
		WeldColocatedVertices = 8,
		// Token: 0x0400000C RID: 12
		UseFastMidphase = 16
	}
}
