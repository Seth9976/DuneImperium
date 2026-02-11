using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000019 RID: 25
	public enum VFXInstancingDisabledReason
	{
		// Token: 0x040001D0 RID: 464
		None,
		// Token: 0x040001D1 RID: 465
		IndirectDraw,
		// Token: 0x040001D2 RID: 466
		OutputEvent,
		// Token: 0x040001D3 RID: 467
		GPUEvent = 4,
		// Token: 0x040001D4 RID: 468
		AutomaticBounds = 8,
		// Token: 0x040001D5 RID: 469
		MeshOutput = 16,
		// Token: 0x040001D6 RID: 470
		ExposedObject = 32,
		// Token: 0x040001D7 RID: 471
		Unknown = -1
	}
}
