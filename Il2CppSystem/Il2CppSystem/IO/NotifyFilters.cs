using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000185 RID: 389
	[OriginalName("System.dll", "System.IO", "NotifyFilters")]
	[Flags]
	public enum NotifyFilters
	{
		// Token: 0x04001266 RID: 4710
		Attributes = 4,
		// Token: 0x04001267 RID: 4711
		CreationTime = 64,
		// Token: 0x04001268 RID: 4712
		DirectoryName = 2,
		// Token: 0x04001269 RID: 4713
		FileName = 1,
		// Token: 0x0400126A RID: 4714
		LastAccess = 32,
		// Token: 0x0400126B RID: 4715
		LastWrite = 16,
		// Token: 0x0400126C RID: 4716
		Security = 256,
		// Token: 0x0400126D RID: 4717
		Size = 8
	}
}
