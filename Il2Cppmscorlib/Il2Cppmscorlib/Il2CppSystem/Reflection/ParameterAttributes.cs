using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200041E RID: 1054
	[OriginalName("mscorlib.dll", "System.Reflection", "ParameterAttributes")]
	[Flags]
	public enum ParameterAttributes
	{
		// Token: 0x0400315D RID: 12637
		None = 0,
		// Token: 0x0400315E RID: 12638
		In = 1,
		// Token: 0x0400315F RID: 12639
		Out = 2,
		// Token: 0x04003160 RID: 12640
		Lcid = 4,
		// Token: 0x04003161 RID: 12641
		Retval = 8,
		// Token: 0x04003162 RID: 12642
		Optional = 16,
		// Token: 0x04003163 RID: 12643
		HasDefault = 4096,
		// Token: 0x04003164 RID: 12644
		HasFieldMarshal = 8192,
		// Token: 0x04003165 RID: 12645
		Reserved3 = 16384,
		// Token: 0x04003166 RID: 12646
		Reserved4 = 32768,
		// Token: 0x04003167 RID: 12647
		ReservedMask = 61440
	}
}
