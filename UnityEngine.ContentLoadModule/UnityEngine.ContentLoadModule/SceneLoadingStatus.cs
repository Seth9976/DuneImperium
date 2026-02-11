using System;

namespace Unity.Loading
{
	// Token: 0x02000005 RID: 5
	public enum SceneLoadingStatus
	{
		// Token: 0x04000009 RID: 9
		InProgress,
		// Token: 0x0400000A RID: 10
		WaitingForIntegrate,
		// Token: 0x0400000B RID: 11
		WillIntegrateNextFrame,
		// Token: 0x0400000C RID: 12
		Complete,
		// Token: 0x0400000D RID: 13
		Failed
	}
}
