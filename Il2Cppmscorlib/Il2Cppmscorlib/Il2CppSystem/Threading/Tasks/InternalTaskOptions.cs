using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D7 RID: 471
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "InternalTaskOptions")]
	[Flags]
	public enum InternalTaskOptions
	{
		// Token: 0x04001BEE RID: 7150
		None = 0,
		// Token: 0x04001BEF RID: 7151
		InternalOptionsMask = 65280,
		// Token: 0x04001BF0 RID: 7152
		ContinuationTask = 512,
		// Token: 0x04001BF1 RID: 7153
		PromiseTask = 1024,
		// Token: 0x04001BF2 RID: 7154
		LazyCancellation = 4096,
		// Token: 0x04001BF3 RID: 7155
		QueuedByRuntime = 8192,
		// Token: 0x04001BF4 RID: 7156
		DoNotDispose = 16384
	}
}
