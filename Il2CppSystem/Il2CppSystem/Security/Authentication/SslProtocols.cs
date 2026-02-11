using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Authentication
{
	// Token: 0x020000AE RID: 174
	[OriginalName("System.dll", "System.Security.Authentication", "SslProtocols")]
	[Flags]
	public enum SslProtocols
	{
		// Token: 0x040009CD RID: 2509
		None = 0,
		// Token: 0x040009CE RID: 2510
		Ssl2 = 12,
		// Token: 0x040009CF RID: 2511
		Ssl3 = 48,
		// Token: 0x040009D0 RID: 2512
		Tls = 192,
		// Token: 0x040009D1 RID: 2513
		Tls11 = 768,
		// Token: 0x040009D2 RID: 2514
		Tls12 = 3072,
		// Token: 0x040009D3 RID: 2515
		Tls13 = 12288,
		// Token: 0x040009D4 RID: 2516
		Default = 240
	}
}
