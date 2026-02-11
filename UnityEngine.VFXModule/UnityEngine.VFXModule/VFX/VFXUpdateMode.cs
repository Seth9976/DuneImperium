using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000016 RID: 22
	public enum VFXUpdateMode
	{
		// Token: 0x040001BF RID: 447
		FixedDeltaTime,
		// Token: 0x040001C0 RID: 448
		DeltaTime,
		// Token: 0x040001C1 RID: 449
		IgnoreTimeScale,
		// Token: 0x040001C2 RID: 450
		ExactFixedTimeStep = 4,
		// Token: 0x040001C3 RID: 451
		DeltaTimeAndIgnoreTimeScale = 3,
		// Token: 0x040001C4 RID: 452
		FixedDeltaAndExactTime,
		// Token: 0x040001C5 RID: 453
		FixedDeltaAndExactTimeAndIgnoreTimeScale = 6
	}
}
