using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200040E RID: 1038
	[OriginalName("mscorlib.dll", "System.Reflection", "GenericParameterAttributes")]
	[Flags]
	public enum GenericParameterAttributes
	{
		// Token: 0x040030B3 RID: 12467
		None = 0,
		// Token: 0x040030B4 RID: 12468
		VarianceMask = 3,
		// Token: 0x040030B5 RID: 12469
		Covariant = 1,
		// Token: 0x040030B6 RID: 12470
		Contravariant = 2,
		// Token: 0x040030B7 RID: 12471
		SpecialConstraintMask = 28,
		// Token: 0x040030B8 RID: 12472
		ReferenceTypeConstraint = 4,
		// Token: 0x040030B9 RID: 12473
		NotNullableValueTypeConstraint = 8,
		// Token: 0x040030BA RID: 12474
		DefaultConstructorConstraint = 16
	}
}
