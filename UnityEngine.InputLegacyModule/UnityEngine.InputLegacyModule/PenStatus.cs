using System;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum PenStatus
	{
		// Token: 0x0400003D RID: 61
		None = 0,
		// Token: 0x0400003E RID: 62
		Contact = 1,
		// Token: 0x0400003F RID: 63
		Barrel = 2,
		// Token: 0x04000040 RID: 64
		Inverted = 4,
		// Token: 0x04000041 RID: 65
		Eraser = 8
	}
}
