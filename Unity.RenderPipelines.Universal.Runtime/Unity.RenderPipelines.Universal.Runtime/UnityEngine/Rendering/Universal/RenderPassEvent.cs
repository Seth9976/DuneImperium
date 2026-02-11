using System;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B5 RID: 181
	public enum RenderPassEvent
	{
		// Token: 0x04000A98 RID: 2712
		BeforeRendering,
		// Token: 0x04000A99 RID: 2713
		BeforeRenderingShadows = 50,
		// Token: 0x04000A9A RID: 2714
		AfterRenderingShadows = 100,
		// Token: 0x04000A9B RID: 2715
		BeforeRenderingPrePasses = 150,
		// Token: 0x04000A9C RID: 2716
		AfterRenderingPrePasses = 200,
		// Token: 0x04000A9D RID: 2717
		BeforeRenderingGbuffer = 210,
		// Token: 0x04000A9E RID: 2718
		AfterRenderingGbuffer = 220,
		// Token: 0x04000A9F RID: 2719
		BeforeRenderingDeferredLights = 230,
		// Token: 0x04000AA0 RID: 2720
		AfterRenderingDeferredLights = 240,
		// Token: 0x04000AA1 RID: 2721
		BeforeRenderingOpaques = 250,
		// Token: 0x04000AA2 RID: 2722
		AfterRenderingOpaques = 300,
		// Token: 0x04000AA3 RID: 2723
		BeforeRenderingSkybox = 350,
		// Token: 0x04000AA4 RID: 2724
		AfterRenderingSkybox = 400,
		// Token: 0x04000AA5 RID: 2725
		BeforeRenderingTransparents = 450,
		// Token: 0x04000AA6 RID: 2726
		AfterRenderingTransparents = 500,
		// Token: 0x04000AA7 RID: 2727
		BeforeRenderingPostProcessing = 550,
		// Token: 0x04000AA8 RID: 2728
		AfterRenderingPostProcessing = 600,
		// Token: 0x04000AA9 RID: 2729
		AfterRendering = 1000
	}
}
