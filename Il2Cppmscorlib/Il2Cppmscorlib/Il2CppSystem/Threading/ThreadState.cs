using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000190 RID: 400
	[OriginalName("mscorlib.dll", "System.Threading", "ThreadState")]
	[Flags]
	public enum ThreadState
	{
		// Token: 0x04001828 RID: 6184
		Running = 0,
		// Token: 0x04001829 RID: 6185
		StopRequested = 1,
		// Token: 0x0400182A RID: 6186
		SuspendRequested = 2,
		// Token: 0x0400182B RID: 6187
		Background = 4,
		// Token: 0x0400182C RID: 6188
		Unstarted = 8,
		// Token: 0x0400182D RID: 6189
		Stopped = 16,
		// Token: 0x0400182E RID: 6190
		WaitSleepJoin = 32,
		// Token: 0x0400182F RID: 6191
		Suspended = 64,
		// Token: 0x04001830 RID: 6192
		AbortRequested = 128,
		// Token: 0x04001831 RID: 6193
		Aborted = 256
	}
}
