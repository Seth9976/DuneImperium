using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BA RID: 186
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "OpenFlags")]
	[Flags]
	public enum OpenFlags
	{
		// Token: 0x04000A4C RID: 2636
		ReadOnly = 0,
		// Token: 0x04000A4D RID: 2637
		ReadWrite = 1,
		// Token: 0x04000A4E RID: 2638
		MaxAllowed = 2,
		// Token: 0x04000A4F RID: 2639
		OpenExistingOnly = 4,
		// Token: 0x04000A50 RID: 2640
		IncludeArchived = 8
	}
}
