using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000419 RID: 1049
	[OriginalName("mscorlib.dll", "System.Reflection", "MethodImplAttributes")]
	public enum MethodImplAttributes
	{
		// Token: 0x0400311E RID: 12574
		CodeTypeMask = 3,
		// Token: 0x0400311F RID: 12575
		IL = 0,
		// Token: 0x04003120 RID: 12576
		Native,
		// Token: 0x04003121 RID: 12577
		OPTIL,
		// Token: 0x04003122 RID: 12578
		Runtime,
		// Token: 0x04003123 RID: 12579
		ManagedMask,
		// Token: 0x04003124 RID: 12580
		Unmanaged = 4,
		// Token: 0x04003125 RID: 12581
		Managed = 0,
		// Token: 0x04003126 RID: 12582
		ForwardRef = 16,
		// Token: 0x04003127 RID: 12583
		PreserveSig = 128,
		// Token: 0x04003128 RID: 12584
		InternalCall = 4096,
		// Token: 0x04003129 RID: 12585
		Synchronized = 32,
		// Token: 0x0400312A RID: 12586
		NoInlining = 8,
		// Token: 0x0400312B RID: 12587
		AggressiveInlining = 256,
		// Token: 0x0400312C RID: 12588
		NoOptimization = 64,
		// Token: 0x0400312D RID: 12589
		MaxMethodImplVal = 65535,
		// Token: 0x0400312E RID: 12590
		SecurityMitigations = 1024
	}
}
