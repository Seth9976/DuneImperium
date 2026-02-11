using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BE RID: 190
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainStatusFlags")]
	[Flags]
	public enum X509ChainStatusFlags
	{
		// Token: 0x04000A69 RID: 2665
		NoError = 0,
		// Token: 0x04000A6A RID: 2666
		NotTimeValid = 1,
		// Token: 0x04000A6B RID: 2667
		NotTimeNested = 2,
		// Token: 0x04000A6C RID: 2668
		Revoked = 4,
		// Token: 0x04000A6D RID: 2669
		NotSignatureValid = 8,
		// Token: 0x04000A6E RID: 2670
		NotValidForUsage = 16,
		// Token: 0x04000A6F RID: 2671
		UntrustedRoot = 32,
		// Token: 0x04000A70 RID: 2672
		RevocationStatusUnknown = 64,
		// Token: 0x04000A71 RID: 2673
		Cyclic = 128,
		// Token: 0x04000A72 RID: 2674
		InvalidExtension = 256,
		// Token: 0x04000A73 RID: 2675
		InvalidPolicyConstraints = 512,
		// Token: 0x04000A74 RID: 2676
		InvalidBasicConstraints = 1024,
		// Token: 0x04000A75 RID: 2677
		InvalidNameConstraints = 2048,
		// Token: 0x04000A76 RID: 2678
		HasNotSupportedNameConstraint = 4096,
		// Token: 0x04000A77 RID: 2679
		HasNotDefinedNameConstraint = 8192,
		// Token: 0x04000A78 RID: 2680
		HasNotPermittedNameConstraint = 16384,
		// Token: 0x04000A79 RID: 2681
		HasExcludedNameConstraint = 32768,
		// Token: 0x04000A7A RID: 2682
		PartialChain = 65536,
		// Token: 0x04000A7B RID: 2683
		CtlNotTimeValid = 131072,
		// Token: 0x04000A7C RID: 2684
		CtlNotSignatureValid = 262144,
		// Token: 0x04000A7D RID: 2685
		CtlNotValidForUsage = 524288,
		// Token: 0x04000A7E RID: 2686
		OfflineRevocation = 16777216,
		// Token: 0x04000A7F RID: 2687
		NoIssuanceChainPolicy = 33554432,
		// Token: 0x04000A80 RID: 2688
		ExplicitDistrust = 67108864,
		// Token: 0x04000A81 RID: 2689
		HasNotSupportedCriticalExtension = 134217728,
		// Token: 0x04000A82 RID: 2690
		HasWeakSignature = 1048576
	}
}
