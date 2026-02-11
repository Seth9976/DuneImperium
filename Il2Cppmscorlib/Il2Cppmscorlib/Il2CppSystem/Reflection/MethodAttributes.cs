using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000417 RID: 1047
	[OriginalName("mscorlib.dll", "System.Reflection", "MethodAttributes")]
	[Flags]
	public enum MethodAttributes
	{
		// Token: 0x040030E7 RID: 12519
		MemberAccessMask = 7,
		// Token: 0x040030E8 RID: 12520
		PrivateScope = 0,
		// Token: 0x040030E9 RID: 12521
		Private = 1,
		// Token: 0x040030EA RID: 12522
		FamANDAssem = 2,
		// Token: 0x040030EB RID: 12523
		Assembly = 3,
		// Token: 0x040030EC RID: 12524
		Family = 4,
		// Token: 0x040030ED RID: 12525
		FamORAssem = 5,
		// Token: 0x040030EE RID: 12526
		Public = 6,
		// Token: 0x040030EF RID: 12527
		Static = 16,
		// Token: 0x040030F0 RID: 12528
		Final = 32,
		// Token: 0x040030F1 RID: 12529
		Virtual = 64,
		// Token: 0x040030F2 RID: 12530
		HideBySig = 128,
		// Token: 0x040030F3 RID: 12531
		CheckAccessOnOverride = 512,
		// Token: 0x040030F4 RID: 12532
		VtableLayoutMask = 256,
		// Token: 0x040030F5 RID: 12533
		ReuseSlot = 0,
		// Token: 0x040030F6 RID: 12534
		NewSlot = 256,
		// Token: 0x040030F7 RID: 12535
		Abstract = 1024,
		// Token: 0x040030F8 RID: 12536
		SpecialName = 2048,
		// Token: 0x040030F9 RID: 12537
		PinvokeImpl = 8192,
		// Token: 0x040030FA RID: 12538
		UnmanagedExport = 8,
		// Token: 0x040030FB RID: 12539
		RTSpecialName = 4096,
		// Token: 0x040030FC RID: 12540
		HasSecurity = 16384,
		// Token: 0x040030FD RID: 12541
		RequireSecObject = 32768,
		// Token: 0x040030FE RID: 12542
		ReservedMask = 53248
	}
}
