using System;

namespace Steamworks.Data
{
	// Token: 0x020000E0 RID: 224
	[Flags]
	public enum SendType
	{
		// Token: 0x040014C3 RID: 5315
		Unreliable = 0,
		// Token: 0x040014C4 RID: 5316
		NoNagle = 1,
		// Token: 0x040014C5 RID: 5317
		NoDelay = 4,
		// Token: 0x040014C6 RID: 5318
		Reliable = 8
	}
}
