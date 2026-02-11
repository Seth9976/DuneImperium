using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Data
{
	// Token: 0x0200004A RID: 74
	[OriginalName("System.Data.dll", "System.Data", "DataViewRowState")]
	[Flags]
	public enum DataViewRowState
	{
		// Token: 0x0400068F RID: 1679
		None = 0,
		// Token: 0x04000690 RID: 1680
		Unchanged = 2,
		// Token: 0x04000691 RID: 1681
		Added = 4,
		// Token: 0x04000692 RID: 1682
		Deleted = 8,
		// Token: 0x04000693 RID: 1683
		ModifiedCurrent = 16,
		// Token: 0x04000694 RID: 1684
		ModifiedOriginal = 32,
		// Token: 0x04000695 RID: 1685
		OriginalRows = 42,
		// Token: 0x04000696 RID: 1686
		CurrentRows = 22
	}
}
