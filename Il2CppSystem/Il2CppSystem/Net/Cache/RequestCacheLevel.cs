using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200022D RID: 557
	[OriginalName("System.dll", "System.Net.Cache", "RequestCacheLevel")]
	public enum RequestCacheLevel
	{
		// Token: 0x04001C8E RID: 7310
		Default,
		// Token: 0x04001C8F RID: 7311
		BypassCache,
		// Token: 0x04001C90 RID: 7312
		CacheOnly,
		// Token: 0x04001C91 RID: 7313
		CacheIfAvailable,
		// Token: 0x04001C92 RID: 7314
		Revalidate,
		// Token: 0x04001C93 RID: 7315
		Reload,
		// Token: 0x04001C94 RID: 7316
		NoCacheNoStore
	}
}
