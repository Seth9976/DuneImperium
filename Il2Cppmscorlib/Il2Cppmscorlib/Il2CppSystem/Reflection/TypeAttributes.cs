using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000431 RID: 1073
	[OriginalName("mscorlib.dll", "System.Reflection", "TypeAttributes")]
	[Flags]
	public enum TypeAttributes
	{
		// Token: 0x04003267 RID: 12903
		VisibilityMask = 7,
		// Token: 0x04003268 RID: 12904
		NotPublic = 0,
		// Token: 0x04003269 RID: 12905
		Public = 1,
		// Token: 0x0400326A RID: 12906
		NestedPublic = 2,
		// Token: 0x0400326B RID: 12907
		NestedPrivate = 3,
		// Token: 0x0400326C RID: 12908
		NestedFamily = 4,
		// Token: 0x0400326D RID: 12909
		NestedAssembly = 5,
		// Token: 0x0400326E RID: 12910
		NestedFamANDAssem = 6,
		// Token: 0x0400326F RID: 12911
		NestedFamORAssem = 7,
		// Token: 0x04003270 RID: 12912
		LayoutMask = 24,
		// Token: 0x04003271 RID: 12913
		AutoLayout = 0,
		// Token: 0x04003272 RID: 12914
		SequentialLayout = 8,
		// Token: 0x04003273 RID: 12915
		ExplicitLayout = 16,
		// Token: 0x04003274 RID: 12916
		ClassSemanticsMask = 32,
		// Token: 0x04003275 RID: 12917
		Class = 0,
		// Token: 0x04003276 RID: 12918
		Interface = 32,
		// Token: 0x04003277 RID: 12919
		Abstract = 128,
		// Token: 0x04003278 RID: 12920
		Sealed = 256,
		// Token: 0x04003279 RID: 12921
		SpecialName = 1024,
		// Token: 0x0400327A RID: 12922
		Import = 4096,
		// Token: 0x0400327B RID: 12923
		Serializable = 8192,
		// Token: 0x0400327C RID: 12924
		WindowsRuntime = 16384,
		// Token: 0x0400327D RID: 12925
		StringFormatMask = 196608,
		// Token: 0x0400327E RID: 12926
		AnsiClass = 0,
		// Token: 0x0400327F RID: 12927
		UnicodeClass = 65536,
		// Token: 0x04003280 RID: 12928
		AutoClass = 131072,
		// Token: 0x04003281 RID: 12929
		CustomFormatClass = 196608,
		// Token: 0x04003282 RID: 12930
		CustomFormatMask = 12582912,
		// Token: 0x04003283 RID: 12931
		BeforeFieldInit = 1048576,
		// Token: 0x04003284 RID: 12932
		RTSpecialName = 2048,
		// Token: 0x04003285 RID: 12933
		HasSecurity = 262144,
		// Token: 0x04003286 RID: 12934
		ReservedMask = 264192
	}
}
