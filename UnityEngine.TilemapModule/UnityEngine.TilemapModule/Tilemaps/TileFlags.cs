using System;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum TileFlags
	{
		// Token: 0x04000079 RID: 121
		None = 0,
		// Token: 0x0400007A RID: 122
		LockColor = 1,
		// Token: 0x0400007B RID: 123
		LockTransform = 2,
		// Token: 0x0400007C RID: 124
		InstantiateGameObjectRuntimeOnly = 4,
		// Token: 0x0400007D RID: 125
		KeepGameObjectRuntimeOnly = 8,
		// Token: 0x0400007E RID: 126
		LockAll = 3
	}
}
