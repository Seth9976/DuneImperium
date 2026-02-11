using System;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public enum TerrainChangedFlags
	{
		// Token: 0x040000D9 RID: 217
		Heightmap = 1,
		// Token: 0x040000DA RID: 218
		TreeInstances,
		// Token: 0x040000DB RID: 219
		DelayedHeightmapUpdate = 4,
		// Token: 0x040000DC RID: 220
		FlushEverythingImmediately = 8,
		// Token: 0x040000DD RID: 221
		RemoveDirtyDetailsImmediately = 16,
		// Token: 0x040000DE RID: 222
		HeightmapResolution = 32,
		// Token: 0x040000DF RID: 223
		Holes = 64,
		// Token: 0x040000E0 RID: 224
		DelayedHolesUpdate = 128,
		// Token: 0x040000E1 RID: 225
		WillBeDestroyed = 256
	}
}
