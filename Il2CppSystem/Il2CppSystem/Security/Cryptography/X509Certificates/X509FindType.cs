using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BF RID: 191
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509FindType")]
	public enum X509FindType
	{
		// Token: 0x04000A84 RID: 2692
		FindByThumbprint,
		// Token: 0x04000A85 RID: 2693
		FindBySubjectName,
		// Token: 0x04000A86 RID: 2694
		FindBySubjectDistinguishedName,
		// Token: 0x04000A87 RID: 2695
		FindByIssuerName,
		// Token: 0x04000A88 RID: 2696
		FindByIssuerDistinguishedName,
		// Token: 0x04000A89 RID: 2697
		FindBySerialNumber,
		// Token: 0x04000A8A RID: 2698
		FindByTimeValid,
		// Token: 0x04000A8B RID: 2699
		FindByTimeNotYetValid,
		// Token: 0x04000A8C RID: 2700
		FindByTimeExpired,
		// Token: 0x04000A8D RID: 2701
		FindByTemplateName,
		// Token: 0x04000A8E RID: 2702
		FindByApplicationPolicy,
		// Token: 0x04000A8F RID: 2703
		FindByCertificatePolicy,
		// Token: 0x04000A90 RID: 2704
		FindByExtension,
		// Token: 0x04000A91 RID: 2705
		FindByKeyUsage,
		// Token: 0x04000A92 RID: 2706
		FindBySubjectKeyIdentifier
	}
}
