using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000340 RID: 832
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryHeaderEnum")]
	public enum BinaryHeaderEnum
	{
		// Token: 0x04002991 RID: 10641
		SerializedStreamHeader,
		// Token: 0x04002992 RID: 10642
		Object,
		// Token: 0x04002993 RID: 10643
		ObjectWithMap,
		// Token: 0x04002994 RID: 10644
		ObjectWithMapAssemId,
		// Token: 0x04002995 RID: 10645
		ObjectWithMapTyped,
		// Token: 0x04002996 RID: 10646
		ObjectWithMapTypedAssemId,
		// Token: 0x04002997 RID: 10647
		ObjectString,
		// Token: 0x04002998 RID: 10648
		Array,
		// Token: 0x04002999 RID: 10649
		MemberPrimitiveTyped,
		// Token: 0x0400299A RID: 10650
		MemberReference,
		// Token: 0x0400299B RID: 10651
		ObjectNull,
		// Token: 0x0400299C RID: 10652
		MessageEnd,
		// Token: 0x0400299D RID: 10653
		Assembly,
		// Token: 0x0400299E RID: 10654
		ObjectNullMultiple256,
		// Token: 0x0400299F RID: 10655
		ObjectNullMultiple,
		// Token: 0x040029A0 RID: 10656
		ArraySinglePrimitive,
		// Token: 0x040029A1 RID: 10657
		ArraySingleObject,
		// Token: 0x040029A2 RID: 10658
		ArraySingleString,
		// Token: 0x040029A3 RID: 10659
		CrossAppDomainMap,
		// Token: 0x040029A4 RID: 10660
		CrossAppDomainString,
		// Token: 0x040029A5 RID: 10661
		CrossAppDomainAssembly,
		// Token: 0x040029A6 RID: 10662
		MethodCall,
		// Token: 0x040029A7 RID: 10663
		MethodReturn
	}
}
