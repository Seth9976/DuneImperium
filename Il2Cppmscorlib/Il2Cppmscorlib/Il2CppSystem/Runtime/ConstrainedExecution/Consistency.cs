using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x020003A4 RID: 932
	[OriginalName("mscorlib.dll", "System.Runtime.ConstrainedExecution", "Consistency")]
	public enum Consistency
	{
		// Token: 0x04002E47 RID: 11847
		MayCorruptProcess,
		// Token: 0x04002E48 RID: 11848
		MayCorruptAppDomain,
		// Token: 0x04002E49 RID: 11849
		MayCorruptInstance,
		// Token: 0x04002E4A RID: 11850
		WillNotCorruptState
	}
}
