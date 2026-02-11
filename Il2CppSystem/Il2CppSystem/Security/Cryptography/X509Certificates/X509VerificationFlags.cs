using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C5 RID: 197
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509VerificationFlags")]
	[Flags]
	public enum X509VerificationFlags
	{
		// Token: 0x04000AB2 RID: 2738
		NoFlag = 0,
		// Token: 0x04000AB3 RID: 2739
		IgnoreNotTimeValid = 1,
		// Token: 0x04000AB4 RID: 2740
		IgnoreCtlNotTimeValid = 2,
		// Token: 0x04000AB5 RID: 2741
		IgnoreNotTimeNested = 4,
		// Token: 0x04000AB6 RID: 2742
		IgnoreInvalidBasicConstraints = 8,
		// Token: 0x04000AB7 RID: 2743
		AllowUnknownCertificateAuthority = 16,
		// Token: 0x04000AB8 RID: 2744
		IgnoreWrongUsage = 32,
		// Token: 0x04000AB9 RID: 2745
		IgnoreInvalidName = 64,
		// Token: 0x04000ABA RID: 2746
		IgnoreInvalidPolicy = 128,
		// Token: 0x04000ABB RID: 2747
		IgnoreEndRevocationUnknown = 256,
		// Token: 0x04000ABC RID: 2748
		IgnoreCtlSignerRevocationUnknown = 512,
		// Token: 0x04000ABD RID: 2749
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		// Token: 0x04000ABE RID: 2750
		IgnoreRootRevocationUnknown = 2048,
		// Token: 0x04000ABF RID: 2751
		AllFlags = 4095
	}
}
