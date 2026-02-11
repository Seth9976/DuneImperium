using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020002B7 RID: 695
	[OriginalName("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseState")]
	[Serializable]
	public enum LeaseState
	{
		// Token: 0x04002569 RID: 9577
		Null,
		// Token: 0x0400256A RID: 9578
		Initial,
		// Token: 0x0400256B RID: 9579
		Active,
		// Token: 0x0400256C RID: 9580
		Renewing,
		// Token: 0x0400256D RID: 9581
		Expired
	}
}
