using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000015 RID: 21
	public enum VFXSystemFlag
	{
		// Token: 0x040001B3 RID: 435
		SystemDefault,
		// Token: 0x040001B4 RID: 436
		SystemHasKill,
		// Token: 0x040001B5 RID: 437
		SystemHasIndirectBuffer,
		// Token: 0x040001B6 RID: 438
		SystemReceivedEventGPU = 4,
		// Token: 0x040001B7 RID: 439
		SystemHasStrips = 8,
		// Token: 0x040001B8 RID: 440
		SystemNeedsComputeBounds = 16,
		// Token: 0x040001B9 RID: 441
		SystemAutomaticBounds = 32,
		// Token: 0x040001BA RID: 442
		SystemInWorldSpace = 64,
		// Token: 0x040001BB RID: 443
		SystemHasDirectLink = 128,
		// Token: 0x040001BC RID: 444
		SystemHasAttributeBuffer = 256,
		// Token: 0x040001BD RID: 445
		SystemUsesInstancedRendering = 512
	}
}
