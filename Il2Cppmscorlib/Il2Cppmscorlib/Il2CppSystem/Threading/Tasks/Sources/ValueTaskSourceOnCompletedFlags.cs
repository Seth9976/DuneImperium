using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks.Sources
{
	// Token: 0x020001EF RID: 495
	[OriginalName("mscorlib.dll", "System.Threading.Tasks.Sources", "ValueTaskSourceOnCompletedFlags")]
	[Flags]
	public enum ValueTaskSourceOnCompletedFlags
	{
		// Token: 0x04001C98 RID: 7320
		None = 0,
		// Token: 0x04001C99 RID: 7321
		UseSchedulingContext = 1,
		// Token: 0x04001C9A RID: 7322
		FlowExecutionContext = 2
	}
}
