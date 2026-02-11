using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000024 RID: 36
	[OriginalName("System.Net.Http.dll", "System.Net.Http.Headers", "HttpHeaderKind")]
	[Flags]
	public enum HttpHeaderKind
	{
		// Token: 0x04000197 RID: 407
		None = 0,
		// Token: 0x04000198 RID: 408
		Request = 1,
		// Token: 0x04000199 RID: 409
		Response = 2,
		// Token: 0x0400019A RID: 410
		Content = 4
	}
}
