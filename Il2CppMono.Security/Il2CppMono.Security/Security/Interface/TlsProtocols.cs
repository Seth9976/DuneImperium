using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200002F RID: 47
	[OriginalName("Mono.Security.dll", "Mono.Security.Interface", "TlsProtocols")]
	[Flags]
	public enum TlsProtocols
	{
		// Token: 0x0400030B RID: 779
		Zero = 0,
		// Token: 0x0400030C RID: 780
		Tls10Client = 128,
		// Token: 0x0400030D RID: 781
		Tls10Server = 64,
		// Token: 0x0400030E RID: 782
		Tls10 = 192,
		// Token: 0x0400030F RID: 783
		Tls11Client = 512,
		// Token: 0x04000310 RID: 784
		Tls11Server = 256,
		// Token: 0x04000311 RID: 785
		Tls11 = 768,
		// Token: 0x04000312 RID: 786
		Tls12Client = 2048,
		// Token: 0x04000313 RID: 787
		Tls12Server = 1024,
		// Token: 0x04000314 RID: 788
		Tls12 = 3072,
		// Token: 0x04000315 RID: 789
		ClientMask = 2688,
		// Token: 0x04000316 RID: 790
		ServerMask = 1344
	}
}
