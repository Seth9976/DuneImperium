using System;

namespace UnityEngine
{
	// Token: 0x020000D5 RID: 213
	[Flags]
	public enum MaterialGlobalIlluminationFlags
	{
		// Token: 0x04000CBC RID: 3260
		None = 0,
		// Token: 0x04000CBD RID: 3261
		RealtimeEmissive = 1,
		// Token: 0x04000CBE RID: 3262
		BakedEmissive = 2,
		// Token: 0x04000CBF RID: 3263
		EmissiveIsBlack = 4,
		// Token: 0x04000CC0 RID: 3264
		AnyEmissive = 3
	}
}
