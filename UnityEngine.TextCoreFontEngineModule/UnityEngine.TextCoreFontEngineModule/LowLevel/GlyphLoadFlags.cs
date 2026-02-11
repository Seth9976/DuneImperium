using System;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000007 RID: 7
	[Flags]
	public enum GlyphLoadFlags
	{
		// Token: 0x0400007B RID: 123
		LOAD_DEFAULT = 0,
		// Token: 0x0400007C RID: 124
		LOAD_NO_SCALE = 1,
		// Token: 0x0400007D RID: 125
		LOAD_NO_HINTING = 2,
		// Token: 0x0400007E RID: 126
		LOAD_RENDER = 4,
		// Token: 0x0400007F RID: 127
		LOAD_NO_BITMAP = 8,
		// Token: 0x04000080 RID: 128
		LOAD_FORCE_AUTOHINT = 32,
		// Token: 0x04000081 RID: 129
		LOAD_MONOCHROME = 4096,
		// Token: 0x04000082 RID: 130
		LOAD_NO_AUTOHINT = 32768,
		// Token: 0x04000083 RID: 131
		LOAD_COLOR = 1048576,
		// Token: 0x04000084 RID: 132
		LOAD_COMPUTE_METRICS = 2097152,
		// Token: 0x04000085 RID: 133
		LOAD_BITMAP_METRICS_ONLY = 4194304
	}
}
