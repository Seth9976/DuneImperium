using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200040C RID: 1036
	[OriginalName("mscorlib.dll", "System.Reflection", "FieldAttributes")]
	[Flags]
	public enum FieldAttributes
	{
		// Token: 0x04003084 RID: 12420
		FieldAccessMask = 7,
		// Token: 0x04003085 RID: 12421
		PrivateScope = 0,
		// Token: 0x04003086 RID: 12422
		Private = 1,
		// Token: 0x04003087 RID: 12423
		FamANDAssem = 2,
		// Token: 0x04003088 RID: 12424
		Assembly = 3,
		// Token: 0x04003089 RID: 12425
		Family = 4,
		// Token: 0x0400308A RID: 12426
		FamORAssem = 5,
		// Token: 0x0400308B RID: 12427
		Public = 6,
		// Token: 0x0400308C RID: 12428
		Static = 16,
		// Token: 0x0400308D RID: 12429
		InitOnly = 32,
		// Token: 0x0400308E RID: 12430
		Literal = 64,
		// Token: 0x0400308F RID: 12431
		NotSerialized = 128,
		// Token: 0x04003090 RID: 12432
		SpecialName = 512,
		// Token: 0x04003091 RID: 12433
		PinvokeImpl = 8192,
		// Token: 0x04003092 RID: 12434
		RTSpecialName = 1024,
		// Token: 0x04003093 RID: 12435
		HasFieldMarshal = 4096,
		// Token: 0x04003094 RID: 12436
		HasDefault = 32768,
		// Token: 0x04003095 RID: 12437
		HasFieldRVA = 256,
		// Token: 0x04003096 RID: 12438
		ReservedMask = 38144
	}
}
