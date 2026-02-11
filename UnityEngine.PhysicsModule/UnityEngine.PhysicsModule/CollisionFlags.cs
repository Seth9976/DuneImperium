using System;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public enum CollisionFlags
	{
		// Token: 0x040001FE RID: 510
		None,
		// Token: 0x040001FF RID: 511
		Sides,
		// Token: 0x04000200 RID: 512
		Above,
		// Token: 0x04000201 RID: 513
		Below = 4,
		// Token: 0x04000202 RID: 514
		CollidedSides = 1,
		// Token: 0x04000203 RID: 515
		CollidedAbove,
		// Token: 0x04000204 RID: 516
		CollidedBelow = 4
	}
}
