using System;

namespace Unity.Collections
{
	// Token: 0x0200003A RID: 58
	public enum LeakCategory
	{
		// Token: 0x0400018E RID: 398
		Invalid,
		// Token: 0x0400018F RID: 399
		Malloc,
		// Token: 0x04000190 RID: 400
		TempJob,
		// Token: 0x04000191 RID: 401
		Persistent,
		// Token: 0x04000192 RID: 402
		LightProbesQuery,
		// Token: 0x04000193 RID: 403
		NativeTest,
		// Token: 0x04000194 RID: 404
		MeshDataArray,
		// Token: 0x04000195 RID: 405
		TransformAccessArray,
		// Token: 0x04000196 RID: 406
		NavMeshQuery
	}
}
