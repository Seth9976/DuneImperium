using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A6 RID: 422
	[OriginalName("System.dll", "System.Net", "AuthenticationSchemes")]
	[Flags]
	public enum AuthenticationSchemes
	{
		// Token: 0x040014ED RID: 5357
		None = 0,
		// Token: 0x040014EE RID: 5358
		Digest = 1,
		// Token: 0x040014EF RID: 5359
		Negotiate = 2,
		// Token: 0x040014F0 RID: 5360
		Ntlm = 4,
		// Token: 0x040014F1 RID: 5361
		Basic = 8,
		// Token: 0x040014F2 RID: 5362
		Anonymous = 32768,
		// Token: 0x040014F3 RID: 5363
		IntegratedWindowsAuthentication = 6
	}
}
