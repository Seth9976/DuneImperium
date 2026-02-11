using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D2 RID: 466
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskStatus")]
	public enum TaskStatus
	{
		// Token: 0x04001B30 RID: 6960
		Created,
		// Token: 0x04001B31 RID: 6961
		WaitingForActivation,
		// Token: 0x04001B32 RID: 6962
		WaitingToRun,
		// Token: 0x04001B33 RID: 6963
		Running,
		// Token: 0x04001B34 RID: 6964
		WaitingForChildrenToComplete,
		// Token: 0x04001B35 RID: 6965
		RanToCompletion,
		// Token: 0x04001B36 RID: 6966
		Canceled,
		// Token: 0x04001B37 RID: 6967
		Faulted
	}
}
