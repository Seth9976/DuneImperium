using System;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000103 RID: 259
	public enum URPProfileId
	{
		// Token: 0x04000FA8 RID: 4008
		UniversalRenderTotal,
		// Token: 0x04000FA9 RID: 4009
		UpdateVolumeFramework,
		// Token: 0x04000FAA RID: 4010
		RenderCameraStack,
		// Token: 0x04000FAB RID: 4011
		AdditionalLightsShadow,
		// Token: 0x04000FAC RID: 4012
		ColorGradingLUT,
		// Token: 0x04000FAD RID: 4013
		CopyColor,
		// Token: 0x04000FAE RID: 4014
		CopyDepth,
		// Token: 0x04000FAF RID: 4015
		DepthNormalPrepass,
		// Token: 0x04000FB0 RID: 4016
		DepthPrepass,
		// Token: 0x04000FB1 RID: 4017
		UpdateReflectionProbeAtlas,
		// Token: 0x04000FB2 RID: 4018
		DrawOpaqueObjects,
		// Token: 0x04000FB3 RID: 4019
		DrawTransparentObjects,
		// Token: 0x04000FB4 RID: 4020
		DrawScreenSpaceUI,
		// Token: 0x04000FB5 RID: 4021
		LightCookies,
		// Token: 0x04000FB6 RID: 4022
		MainLightShadow,
		// Token: 0x04000FB7 RID: 4023
		ResolveShadows,
		// Token: 0x04000FB8 RID: 4024
		SSAO,
		// Token: 0x04000FB9 RID: 4025
		StopNaNs,
		// Token: 0x04000FBA RID: 4026
		SMAA,
		// Token: 0x04000FBB RID: 4027
		GaussianDepthOfField,
		// Token: 0x04000FBC RID: 4028
		BokehDepthOfField,
		// Token: 0x04000FBD RID: 4029
		TemporalAA,
		// Token: 0x04000FBE RID: 4030
		MotionBlur,
		// Token: 0x04000FBF RID: 4031
		PaniniProjection,
		// Token: 0x04000FC0 RID: 4032
		UberPostProcess,
		// Token: 0x04000FC1 RID: 4033
		Bloom,
		// Token: 0x04000FC2 RID: 4034
		LensFlareDataDrivenComputeOcclusion,
		// Token: 0x04000FC3 RID: 4035
		LensFlareDataDriven,
		// Token: 0x04000FC4 RID: 4036
		MotionVectors,
		// Token: 0x04000FC5 RID: 4037
		DrawFullscreen,
		// Token: 0x04000FC6 RID: 4038
		FinalBlit
	}
}
