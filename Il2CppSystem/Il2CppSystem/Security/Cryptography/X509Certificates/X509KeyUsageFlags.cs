using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C0 RID: 192
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageFlags")]
	[Flags]
	public enum X509KeyUsageFlags
	{
		// Token: 0x04000A94 RID: 2708
		None = 0,
		// Token: 0x04000A95 RID: 2709
		EncipherOnly = 1,
		// Token: 0x04000A96 RID: 2710
		CrlSign = 2,
		// Token: 0x04000A97 RID: 2711
		KeyCertSign = 4,
		// Token: 0x04000A98 RID: 2712
		KeyAgreement = 8,
		// Token: 0x04000A99 RID: 2713
		DataEncipherment = 16,
		// Token: 0x04000A9A RID: 2714
		KeyEncipherment = 32,
		// Token: 0x04000A9B RID: 2715
		NonRepudiation = 64,
		// Token: 0x04000A9C RID: 2716
		DigitalSignature = 128,
		// Token: 0x04000A9D RID: 2717
		DecipherOnly = 32768
	}
}
