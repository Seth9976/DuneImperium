using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000013 RID: 19
	public enum VFXTaskType
	{
		// Token: 0x04000195 RID: 405
		None,
		// Token: 0x04000196 RID: 406
		Spawner = 268435456,
		// Token: 0x04000197 RID: 407
		Initialize = 536870912,
		// Token: 0x04000198 RID: 408
		Update = 805306368,
		// Token: 0x04000199 RID: 409
		Output = 1073741824,
		// Token: 0x0400019A RID: 410
		CameraSort = 805306369,
		// Token: 0x0400019B RID: 411
		PerCameraUpdate,
		// Token: 0x0400019C RID: 412
		PerCameraSort,
		// Token: 0x0400019D RID: 413
		PerOutputSort,
		// Token: 0x0400019E RID: 414
		GlobalSort,
		// Token: 0x0400019F RID: 415
		ParticlePointOutput = 1073741824,
		// Token: 0x040001A0 RID: 416
		ParticleLineOutput,
		// Token: 0x040001A1 RID: 417
		ParticleQuadOutput,
		// Token: 0x040001A2 RID: 418
		ParticleHexahedronOutput,
		// Token: 0x040001A3 RID: 419
		ParticleMeshOutput,
		// Token: 0x040001A4 RID: 420
		ParticleTriangleOutput,
		// Token: 0x040001A5 RID: 421
		ParticleOctagonOutput,
		// Token: 0x040001A6 RID: 422
		ConstantRateSpawner = 268435456,
		// Token: 0x040001A7 RID: 423
		BurstSpawner,
		// Token: 0x040001A8 RID: 424
		PeriodicBurstSpawner,
		// Token: 0x040001A9 RID: 425
		VariableRateSpawner,
		// Token: 0x040001AA RID: 426
		CustomCallbackSpawner,
		// Token: 0x040001AB RID: 427
		SetAttributeSpawner,
		// Token: 0x040001AC RID: 428
		EvaluateExpressionsSpawner
	}
}
