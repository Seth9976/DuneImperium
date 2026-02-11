using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000E RID: 14
	[OriginalName("Mono.Security.dll", "Mono.Security.X509", "X509ChainStatusFlags")]
	[Flags]
	[Serializable]
	public enum X509ChainStatusFlags
	{
		// Token: 0x040000D6 RID: 214
		InvalidBasicConstraints = 1024,
		// Token: 0x040000D7 RID: 215
		NoError = 0,
		// Token: 0x040000D8 RID: 216
		NotSignatureValid = 8,
		// Token: 0x040000D9 RID: 217
		NotTimeNested = 2,
		// Token: 0x040000DA RID: 218
		NotTimeValid = 1,
		// Token: 0x040000DB RID: 219
		PartialChain = 65536,
		// Token: 0x040000DC RID: 220
		UntrustedRoot = 32
	}
}
