using System;

namespace Unity.Burst
{
	// Token: 0x0200000C RID: 12
	public enum BurstTargetCpu
	{
		// Token: 0x040000FB RID: 251
		Auto,
		// Token: 0x040000FC RID: 252
		X86_SSE2,
		// Token: 0x040000FD RID: 253
		X86_SSE4,
		// Token: 0x040000FE RID: 254
		X64_SSE2,
		// Token: 0x040000FF RID: 255
		X64_SSE4,
		// Token: 0x04000100 RID: 256
		AVX,
		// Token: 0x04000101 RID: 257
		AVX2,
		// Token: 0x04000102 RID: 258
		WASM32,
		// Token: 0x04000103 RID: 259
		ARMV7A_NEON32,
		// Token: 0x04000104 RID: 260
		ARMV8A_AARCH64,
		// Token: 0x04000105 RID: 261
		THUMB2_NEON32,
		// Token: 0x04000106 RID: 262
		ARMV8A_AARCH64_HALFFP,
		// Token: 0x04000107 RID: 263
		ARMV9A
	}
}
