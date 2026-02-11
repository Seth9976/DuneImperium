using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D8 RID: 472
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskContinuationOptions")]
	[Flags]
	public enum TaskContinuationOptions
	{
		// Token: 0x04001BF6 RID: 7158
		None = 0,
		// Token: 0x04001BF7 RID: 7159
		PreferFairness = 1,
		// Token: 0x04001BF8 RID: 7160
		LongRunning = 2,
		// Token: 0x04001BF9 RID: 7161
		AttachedToParent = 4,
		// Token: 0x04001BFA RID: 7162
		DenyChildAttach = 8,
		// Token: 0x04001BFB RID: 7163
		HideScheduler = 16,
		// Token: 0x04001BFC RID: 7164
		LazyCancellation = 32,
		// Token: 0x04001BFD RID: 7165
		RunContinuationsAsynchronously = 64,
		// Token: 0x04001BFE RID: 7166
		NotOnRanToCompletion = 65536,
		// Token: 0x04001BFF RID: 7167
		NotOnFaulted = 131072,
		// Token: 0x04001C00 RID: 7168
		NotOnCanceled = 262144,
		// Token: 0x04001C01 RID: 7169
		OnlyOnRanToCompletion = 393216,
		// Token: 0x04001C02 RID: 7170
		OnlyOnFaulted = 327680,
		// Token: 0x04001C03 RID: 7171
		OnlyOnCanceled = 196608,
		// Token: 0x04001C04 RID: 7172
		ExecuteSynchronously = 524288
	}
}
