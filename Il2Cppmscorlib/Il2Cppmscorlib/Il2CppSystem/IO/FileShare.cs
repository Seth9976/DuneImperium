using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000524 RID: 1316
	[OriginalName("mscorlib.dll", "System.IO", "FileShare")]
	[Flags]
	public enum FileShare
	{
		// Token: 0x04004155 RID: 16725
		None = 0,
		// Token: 0x04004156 RID: 16726
		Read = 1,
		// Token: 0x04004157 RID: 16727
		Write = 2,
		// Token: 0x04004158 RID: 16728
		ReadWrite = 3,
		// Token: 0x04004159 RID: 16729
		Delete = 4,
		// Token: 0x0400415A RID: 16730
		Inheritable = 16
	}
}
