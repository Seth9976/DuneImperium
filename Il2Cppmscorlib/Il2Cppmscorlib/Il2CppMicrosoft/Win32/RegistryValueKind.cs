using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000041 RID: 65
	[OriginalName("mscorlib.dll", "Microsoft.Win32", "RegistryValueKind")]
	public enum RegistryValueKind
	{
		// Token: 0x040002CA RID: 714
		String = 1,
		// Token: 0x040002CB RID: 715
		ExpandString,
		// Token: 0x040002CC RID: 716
		Binary,
		// Token: 0x040002CD RID: 717
		DWord,
		// Token: 0x040002CE RID: 718
		MultiString = 7,
		// Token: 0x040002CF RID: 719
		QWord = 11,
		// Token: 0x040002D0 RID: 720
		Unknown = 0,
		// Token: 0x040002D1 RID: 721
		None = -1
	}
}
