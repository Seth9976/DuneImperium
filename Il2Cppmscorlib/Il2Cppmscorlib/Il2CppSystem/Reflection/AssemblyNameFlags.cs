using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003FF RID: 1023
	[OriginalName("mscorlib.dll", "System.Reflection", "AssemblyNameFlags")]
	[Flags]
	public enum AssemblyNameFlags
	{
		// Token: 0x0400302A RID: 12330
		None = 0,
		// Token: 0x0400302B RID: 12331
		PublicKey = 1,
		// Token: 0x0400302C RID: 12332
		EnableJITcompileOptimizer = 16384,
		// Token: 0x0400302D RID: 12333
		EnableJITcompileTracking = 32768,
		// Token: 0x0400302E RID: 12334
		Retargetable = 256
	}
}
