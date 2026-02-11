using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200033B RID: 827
	public enum PassType
	{
		// Token: 0x040029CF RID: 10703
		Normal,
		// Token: 0x040029D0 RID: 10704
		Vertex,
		// Token: 0x040029D1 RID: 10705
		VertexLM,
		// Token: 0x040029D2 RID: 10706
		VertexLMRGBM,
		// Token: 0x040029D3 RID: 10707
		ForwardBase,
		// Token: 0x040029D4 RID: 10708
		ForwardAdd,
		// Token: 0x040029D5 RID: 10709
		LightPrePassBase,
		// Token: 0x040029D6 RID: 10710
		LightPrePassFinal,
		// Token: 0x040029D7 RID: 10711
		ShadowCaster,
		// Token: 0x040029D8 RID: 10712
		Deferred = 10,
		// Token: 0x040029D9 RID: 10713
		Meta,
		// Token: 0x040029DA RID: 10714
		MotionVectors,
		// Token: 0x040029DB RID: 10715
		ScriptableRenderPipeline,
		// Token: 0x040029DC RID: 10716
		ScriptableRenderPipelineDefaultUnlit,
		// Token: 0x040029DD RID: 10717
		GrabPass
	}
}
