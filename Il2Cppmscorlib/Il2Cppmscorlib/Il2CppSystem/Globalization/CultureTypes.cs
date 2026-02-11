using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200046D RID: 1133
	[OriginalName("mscorlib.dll", "System.Globalization", "CultureTypes")]
	[Flags]
	public enum CultureTypes
	{
		// Token: 0x040037EF RID: 14319
		NeutralCultures = 1,
		// Token: 0x040037F0 RID: 14320
		SpecificCultures = 2,
		// Token: 0x040037F1 RID: 14321
		InstalledWin32Cultures = 4,
		// Token: 0x040037F2 RID: 14322
		AllCultures = 7,
		// Token: 0x040037F3 RID: 14323
		UserCustomCulture = 8,
		// Token: 0x040037F4 RID: 14324
		ReplacementCultures = 16,
		// Token: 0x040037F5 RID: 14325
		WindowsOnlyCultures = 32,
		// Token: 0x040037F6 RID: 14326
		FrameworkCultures = 64
	}
}
