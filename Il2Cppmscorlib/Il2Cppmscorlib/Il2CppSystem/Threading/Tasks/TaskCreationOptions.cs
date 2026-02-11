using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D6 RID: 470
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskCreationOptions")]
	[Flags]
	public enum TaskCreationOptions
	{
		// Token: 0x04001BE6 RID: 7142
		None = 0,
		// Token: 0x04001BE7 RID: 7143
		PreferFairness = 1,
		// Token: 0x04001BE8 RID: 7144
		LongRunning = 2,
		// Token: 0x04001BE9 RID: 7145
		AttachedToParent = 4,
		// Token: 0x04001BEA RID: 7146
		DenyChildAttach = 8,
		// Token: 0x04001BEB RID: 7147
		HideScheduler = 16,
		// Token: 0x04001BEC RID: 7148
		RunContinuationsAsynchronously = 64
	}
}
