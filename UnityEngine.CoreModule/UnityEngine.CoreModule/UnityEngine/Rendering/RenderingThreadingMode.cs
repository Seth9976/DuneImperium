using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000347 RID: 839
	public enum RenderingThreadingMode
	{
		// Token: 0x04002A0E RID: 10766
		Direct,
		// Token: 0x04002A0F RID: 10767
		SingleThreaded,
		// Token: 0x04002A10 RID: 10768
		MultiThreaded,
		// Token: 0x04002A11 RID: 10769
		LegacyJobified,
		// Token: 0x04002A12 RID: 10770
		NativeGraphicsJobs,
		// Token: 0x04002A13 RID: 10771
		NativeGraphicsJobsWithoutRenderThread
	}
}
