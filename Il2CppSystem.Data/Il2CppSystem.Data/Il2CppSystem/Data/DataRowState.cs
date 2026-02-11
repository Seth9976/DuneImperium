using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Data
{
	// Token: 0x0200003A RID: 58
	[OriginalName("System.Data.dll", "System.Data", "DataRowState")]
	[Flags]
	public enum DataRowState
	{
		// Token: 0x0400059B RID: 1435
		Detached = 1,
		// Token: 0x0400059C RID: 1436
		Unchanged = 2,
		// Token: 0x0400059D RID: 1437
		Added = 4,
		// Token: 0x0400059E RID: 1438
		Deleted = 8,
		// Token: 0x0400059F RID: 1439
		Modified = 16
	}
}
