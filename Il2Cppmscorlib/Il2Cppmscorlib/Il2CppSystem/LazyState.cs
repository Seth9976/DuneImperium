using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x020000BB RID: 187
	[OriginalName("mscorlib.dll", "System", "LazyState")]
	public enum LazyState
	{
		// Token: 0x04000A0D RID: 2573
		NoneViaConstructor,
		// Token: 0x04000A0E RID: 2574
		NoneViaFactory,
		// Token: 0x04000A0F RID: 2575
		NoneException,
		// Token: 0x04000A10 RID: 2576
		PublicationOnlyViaConstructor,
		// Token: 0x04000A11 RID: 2577
		PublicationOnlyViaFactory,
		// Token: 0x04000A12 RID: 2578
		PublicationOnlyWait,
		// Token: 0x04000A13 RID: 2579
		PublicationOnlyException,
		// Token: 0x04000A14 RID: 2580
		ExecutionAndPublicationViaConstructor,
		// Token: 0x04000A15 RID: 2581
		ExecutionAndPublicationViaFactory,
		// Token: 0x04000A16 RID: 2582
		ExecutionAndPublicationException
	}
}
