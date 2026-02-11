using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A5 RID: 421
	[OriginalName("System.dll", "System.Net", "SecurityProtocolType")]
	[Flags]
	public enum SecurityProtocolType
	{
		// Token: 0x040014E6 RID: 5350
		SystemDefault = 0,
		// Token: 0x040014E7 RID: 5351
		Ssl3 = 48,
		// Token: 0x040014E8 RID: 5352
		Tls = 192,
		// Token: 0x040014E9 RID: 5353
		Tls11 = 768,
		// Token: 0x040014EA RID: 5354
		Tls12 = 3072,
		// Token: 0x040014EB RID: 5355
		Tls13 = 12288
	}
}
