using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200044D RID: 1101
	[OriginalName("mscorlib.dll", "System.Reflection", "PInfo")]
	[Flags]
	public enum PInfo
	{
		// Token: 0x040034E0 RID: 13536
		Attributes = 1,
		// Token: 0x040034E1 RID: 13537
		GetMethod = 2,
		// Token: 0x040034E2 RID: 13538
		SetMethod = 4,
		// Token: 0x040034E3 RID: 13539
		ReflectedType = 8,
		// Token: 0x040034E4 RID: 13540
		DeclaringType = 16,
		// Token: 0x040034E5 RID: 13541
		Name = 32
	}
}
