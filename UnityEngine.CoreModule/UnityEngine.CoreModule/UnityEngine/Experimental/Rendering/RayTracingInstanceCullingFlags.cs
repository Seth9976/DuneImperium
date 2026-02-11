using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200036E RID: 878
	public enum RayTracingInstanceCullingFlags
	{
		// Token: 0x04002A7E RID: 10878
		None,
		// Token: 0x04002A7F RID: 10879
		EnableSphereCulling,
		// Token: 0x04002A80 RID: 10880
		EnablePlaneCulling,
		// Token: 0x04002A81 RID: 10881
		EnableLODCulling = 4,
		// Token: 0x04002A82 RID: 10882
		ComputeMaterialsCRC = 8,
		// Token: 0x04002A83 RID: 10883
		IgnoreReflectionProbes = 16
	}
}
