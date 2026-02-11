using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033C RID: 828
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization", "StreamingContextStates")]
	[Flags]
	[Serializable]
	public enum StreamingContextStates
	{
		// Token: 0x0400297D RID: 10621
		CrossProcess = 1,
		// Token: 0x0400297E RID: 10622
		CrossMachine = 2,
		// Token: 0x0400297F RID: 10623
		File = 4,
		// Token: 0x04002980 RID: 10624
		Persistence = 8,
		// Token: 0x04002981 RID: 10625
		Remoting = 16,
		// Token: 0x04002982 RID: 10626
		Other = 32,
		// Token: 0x04002983 RID: 10627
		Clone = 64,
		// Token: 0x04002984 RID: 10628
		CrossAppDomain = 128,
		// Token: 0x04002985 RID: 10629
		All = 255
	}
}
