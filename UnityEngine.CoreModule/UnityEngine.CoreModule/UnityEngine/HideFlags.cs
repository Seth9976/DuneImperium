using System;

namespace UnityEngine
{
	// Token: 0x02000154 RID: 340
	[Flags]
	public enum HideFlags
	{
		// Token: 0x0400168A RID: 5770
		None = 0,
		// Token: 0x0400168B RID: 5771
		HideInHierarchy = 1,
		// Token: 0x0400168C RID: 5772
		HideInInspector = 2,
		// Token: 0x0400168D RID: 5773
		DontSaveInEditor = 4,
		// Token: 0x0400168E RID: 5774
		NotEditable = 8,
		// Token: 0x0400168F RID: 5775
		DontSaveInBuild = 16,
		// Token: 0x04001690 RID: 5776
		DontUnloadUnusedAsset = 32,
		// Token: 0x04001691 RID: 5777
		DontSave = 52,
		// Token: 0x04001692 RID: 5778
		HideAndDontSave = 61
	}
}
