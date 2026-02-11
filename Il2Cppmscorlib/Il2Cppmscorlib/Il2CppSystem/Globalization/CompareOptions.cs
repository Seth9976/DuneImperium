using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200046B RID: 1131
	[OriginalName("mscorlib.dll", "System.Globalization", "CompareOptions")]
	[Flags]
	public enum CompareOptions
	{
		// Token: 0x040037DA RID: 14298
		None = 0,
		// Token: 0x040037DB RID: 14299
		IgnoreCase = 1,
		// Token: 0x040037DC RID: 14300
		IgnoreNonSpace = 2,
		// Token: 0x040037DD RID: 14301
		IgnoreSymbols = 4,
		// Token: 0x040037DE RID: 14302
		IgnoreKanaType = 8,
		// Token: 0x040037DF RID: 14303
		IgnoreWidth = 16,
		// Token: 0x040037E0 RID: 14304
		OrdinalIgnoreCase = 268435456,
		// Token: 0x040037E1 RID: 14305
		StringSort = 536870912,
		// Token: 0x040037E2 RID: 14306
		Ordinal = 1073741824
	}
}
