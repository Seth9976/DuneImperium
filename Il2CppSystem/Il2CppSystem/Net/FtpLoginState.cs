using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x0200019B RID: 411
	[OriginalName("System.dll", "System.Net", "FtpLoginState")]
	public enum FtpLoginState : byte
	{
		// Token: 0x040013D8 RID: 5080
		NotLoggedIn,
		// Token: 0x040013D9 RID: 5081
		LoggedIn,
		// Token: 0x040013DA RID: 5082
		LoggedInButNeedsRelogin,
		// Token: 0x040013DB RID: 5083
		ReloginFailed
	}
}
