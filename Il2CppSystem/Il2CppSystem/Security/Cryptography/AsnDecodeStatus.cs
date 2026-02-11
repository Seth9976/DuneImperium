using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000B8 RID: 184
	[OriginalName("System.dll", "System.Security.Cryptography", "AsnDecodeStatus")]
	public enum AsnDecodeStatus
	{
		// Token: 0x04000A31 RID: 2609
		NotDecoded = -1,
		// Token: 0x04000A32 RID: 2610
		Ok,
		// Token: 0x04000A33 RID: 2611
		BadAsn,
		// Token: 0x04000A34 RID: 2612
		BadTag,
		// Token: 0x04000A35 RID: 2613
		BadLength,
		// Token: 0x04000A36 RID: 2614
		InformationNotAvailable
	}
}
