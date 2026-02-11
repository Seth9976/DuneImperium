using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Data
{
	// Token: 0x02000034 RID: 52
	[OriginalName("System.Data.dll", "System.Data", "DataRowAction")]
	[Flags]
	public enum DataRowAction
	{
		// Token: 0x04000578 RID: 1400
		Nothing = 0,
		// Token: 0x04000579 RID: 1401
		Delete = 1,
		// Token: 0x0400057A RID: 1402
		Change = 2,
		// Token: 0x0400057B RID: 1403
		Rollback = 4,
		// Token: 0x0400057C RID: 1404
		Commit = 8,
		// Token: 0x0400057D RID: 1405
		Add = 16,
		// Token: 0x0400057E RID: 1406
		ChangeOriginal = 32,
		// Token: 0x0400057F RID: 1407
		ChangeCurrentAndOriginal = 64
	}
}
