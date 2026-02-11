using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001E4 RID: 484
	[Flags]
	public enum MeshUpdateFlags
	{
		// Token: 0x04001CBA RID: 7354
		Default = 0,
		// Token: 0x04001CBB RID: 7355
		DontValidateIndices = 1,
		// Token: 0x04001CBC RID: 7356
		DontResetBoneBounds = 2,
		// Token: 0x04001CBD RID: 7357
		DontNotifyMeshUsers = 4,
		// Token: 0x04001CBE RID: 7358
		DontRecalculateBounds = 8
	}
}
