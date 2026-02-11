using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001F3 RID: 499
	public enum CameraEvent
	{
		// Token: 0x04001D43 RID: 7491
		BeforeDepthTexture,
		// Token: 0x04001D44 RID: 7492
		AfterDepthTexture,
		// Token: 0x04001D45 RID: 7493
		BeforeDepthNormalsTexture,
		// Token: 0x04001D46 RID: 7494
		AfterDepthNormalsTexture,
		// Token: 0x04001D47 RID: 7495
		BeforeGBuffer,
		// Token: 0x04001D48 RID: 7496
		AfterGBuffer,
		// Token: 0x04001D49 RID: 7497
		BeforeLighting,
		// Token: 0x04001D4A RID: 7498
		AfterLighting,
		// Token: 0x04001D4B RID: 7499
		BeforeFinalPass,
		// Token: 0x04001D4C RID: 7500
		AfterFinalPass,
		// Token: 0x04001D4D RID: 7501
		BeforeForwardOpaque,
		// Token: 0x04001D4E RID: 7502
		AfterForwardOpaque,
		// Token: 0x04001D4F RID: 7503
		BeforeImageEffectsOpaque,
		// Token: 0x04001D50 RID: 7504
		AfterImageEffectsOpaque,
		// Token: 0x04001D51 RID: 7505
		BeforeSkybox,
		// Token: 0x04001D52 RID: 7506
		AfterSkybox,
		// Token: 0x04001D53 RID: 7507
		BeforeForwardAlpha,
		// Token: 0x04001D54 RID: 7508
		AfterForwardAlpha,
		// Token: 0x04001D55 RID: 7509
		BeforeImageEffects,
		// Token: 0x04001D56 RID: 7510
		AfterImageEffects,
		// Token: 0x04001D57 RID: 7511
		AfterEverything,
		// Token: 0x04001D58 RID: 7512
		BeforeReflections,
		// Token: 0x04001D59 RID: 7513
		AfterReflections,
		// Token: 0x04001D5A RID: 7514
		BeforeHaloAndLensFlares,
		// Token: 0x04001D5B RID: 7515
		AfterHaloAndLensFlares
	}
}
