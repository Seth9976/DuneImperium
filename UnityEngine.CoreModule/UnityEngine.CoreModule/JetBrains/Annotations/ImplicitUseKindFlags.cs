using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200005C RID: 92
	[Flags]
	public enum ImplicitUseKindFlags
	{
		// Token: 0x0400023C RID: 572
		Default = 7,
		// Token: 0x0400023D RID: 573
		Access = 1,
		// Token: 0x0400023E RID: 574
		Assign = 2,
		// Token: 0x0400023F RID: 575
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x04000240 RID: 576
		InstantiatedNoFixedConstructorSignature = 8
	}
}
