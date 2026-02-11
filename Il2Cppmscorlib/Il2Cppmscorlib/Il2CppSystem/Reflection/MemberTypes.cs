using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000416 RID: 1046
	[OriginalName("mscorlib.dll", "System.Reflection", "MemberTypes")]
	[Flags]
	public enum MemberTypes
	{
		// Token: 0x040030DD RID: 12509
		Constructor = 1,
		// Token: 0x040030DE RID: 12510
		Event = 2,
		// Token: 0x040030DF RID: 12511
		Field = 4,
		// Token: 0x040030E0 RID: 12512
		Method = 8,
		// Token: 0x040030E1 RID: 12513
		Property = 16,
		// Token: 0x040030E2 RID: 12514
		TypeInfo = 32,
		// Token: 0x040030E3 RID: 12515
		Custom = 64,
		// Token: 0x040030E4 RID: 12516
		NestedType = 128,
		// Token: 0x040030E5 RID: 12517
		All = 191
	}
}
