using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000266 RID: 614
	[OriginalName("System.dll", "System.Net.Security", "SslPolicyErrors")]
	[Flags]
	public enum SslPolicyErrors
	{
		// Token: 0x0400207F RID: 8319
		None = 0,
		// Token: 0x04002080 RID: 8320
		RemoteCertificateNotAvailable = 1,
		// Token: 0x04002081 RID: 8321
		RemoteCertificateNameMismatch = 2,
		// Token: 0x04002082 RID: 8322
		RemoteCertificateChainErrors = 4
	}
}
