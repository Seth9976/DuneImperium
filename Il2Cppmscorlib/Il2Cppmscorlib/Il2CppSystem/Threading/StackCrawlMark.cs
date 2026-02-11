using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001AF RID: 431
	[OriginalName("mscorlib.dll", "System.Threading", "StackCrawlMark")]
	[Serializable]
	public enum StackCrawlMark
	{
		// Token: 0x040019CC RID: 6604
		LookForMe,
		// Token: 0x040019CD RID: 6605
		LookForMyCaller,
		// Token: 0x040019CE RID: 6606
		LookForMyCallersCaller,
		// Token: 0x040019CF RID: 6607
		LookForThread
	}
}
