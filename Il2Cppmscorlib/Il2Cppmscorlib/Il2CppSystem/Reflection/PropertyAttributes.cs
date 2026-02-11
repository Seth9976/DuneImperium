using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000423 RID: 1059
	[OriginalName("mscorlib.dll", "System.Reflection", "PropertyAttributes")]
	[Flags]
	public enum PropertyAttributes
	{
		// Token: 0x0400318D RID: 12685
		None = 0,
		// Token: 0x0400318E RID: 12686
		SpecialName = 512,
		// Token: 0x0400318F RID: 12687
		RTSpecialName = 1024,
		// Token: 0x04003190 RID: 12688
		HasDefault = 4096,
		// Token: 0x04003191 RID: 12689
		Reserved2 = 8192,
		// Token: 0x04003192 RID: 12690
		Reserved3 = 16384,
		// Token: 0x04003193 RID: 12691
		Reserved4 = 32768,
		// Token: 0x04003194 RID: 12692
		ReservedMask = 62464
	}
}
