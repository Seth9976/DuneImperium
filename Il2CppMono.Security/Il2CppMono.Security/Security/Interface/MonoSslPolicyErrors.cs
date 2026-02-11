using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000027 RID: 39
	[OriginalName("Mono.Security.dll", "Mono.Security.Interface", "MonoSslPolicyErrors")]
	[Flags]
	public enum MonoSslPolicyErrors
	{
		// Token: 0x040002BD RID: 701
		None = 0,
		// Token: 0x040002BE RID: 702
		RemoteCertificateNotAvailable = 1,
		// Token: 0x040002BF RID: 703
		RemoteCertificateNameMismatch = 2,
		// Token: 0x040002C0 RID: 704
		RemoteCertificateChainErrors = 4
	}
}
