using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200023C RID: 572
	[OriginalName("System.dll", "System.Net.Sockets", "SocketFlags")]
	[Flags]
	public enum SocketFlags
	{
		// Token: 0x04001E3C RID: 7740
		None = 0,
		// Token: 0x04001E3D RID: 7741
		OutOfBand = 1,
		// Token: 0x04001E3E RID: 7742
		Peek = 2,
		// Token: 0x04001E3F RID: 7743
		DontRoute = 4,
		// Token: 0x04001E40 RID: 7744
		MaxIOVectorLength = 16,
		// Token: 0x04001E41 RID: 7745
		Truncated = 256,
		// Token: 0x04001E42 RID: 7746
		ControlDataTruncated = 512,
		// Token: 0x04001E43 RID: 7747
		Broadcast = 1024,
		// Token: 0x04001E44 RID: 7748
		Multicast = 2048,
		// Token: 0x04001E45 RID: 7749
		Partial = 32768
	}
}
