using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BD RID: 189
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X500DistinguishedNameFlags")]
	[Flags]
	public enum X500DistinguishedNameFlags
	{
		// Token: 0x04000A5E RID: 2654
		None = 0,
		// Token: 0x04000A5F RID: 2655
		Reversed = 1,
		// Token: 0x04000A60 RID: 2656
		UseSemicolons = 16,
		// Token: 0x04000A61 RID: 2657
		DoNotUsePlusSign = 32,
		// Token: 0x04000A62 RID: 2658
		DoNotUseQuotes = 64,
		// Token: 0x04000A63 RID: 2659
		UseCommas = 128,
		// Token: 0x04000A64 RID: 2660
		UseNewLines = 256,
		// Token: 0x04000A65 RID: 2661
		UseUTF8Encoding = 4096,
		// Token: 0x04000A66 RID: 2662
		UseT61Encoding = 8192,
		// Token: 0x04000A67 RID: 2663
		ForceUTF8Encoding = 16384
	}
}
