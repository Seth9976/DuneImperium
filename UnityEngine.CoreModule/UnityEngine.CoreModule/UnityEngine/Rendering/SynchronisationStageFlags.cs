using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000210 RID: 528
	public enum SynchronisationStageFlags
	{
		// Token: 0x04001E7C RID: 7804
		VertexProcessing = 1,
		// Token: 0x04001E7D RID: 7805
		PixelProcessing,
		// Token: 0x04001E7E RID: 7806
		ComputeProcessing = 4,
		// Token: 0x04001E7F RID: 7807
		AllGPUOperations = 7
	}
}
