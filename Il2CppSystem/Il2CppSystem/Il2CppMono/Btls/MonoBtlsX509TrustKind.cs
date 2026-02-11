using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Btls
{
	// Token: 0x0200004A RID: 74
	[OriginalName("System.dll", "Mono.Btls", "MonoBtlsX509TrustKind")]
	[Flags]
	public enum MonoBtlsX509TrustKind
	{
		// Token: 0x0400039B RID: 923
		DEFAULT = 0,
		// Token: 0x0400039C RID: 924
		TRUST_CLIENT = 1,
		// Token: 0x0400039D RID: 925
		TRUST_SERVER = 2,
		// Token: 0x0400039E RID: 926
		TRUST_ALL = 4,
		// Token: 0x0400039F RID: 927
		REJECT_CLIENT = 32,
		// Token: 0x040003A0 RID: 928
		REJECT_SERVER = 64,
		// Token: 0x040003A1 RID: 929
		REJECT_ALL = 128
	}
}
