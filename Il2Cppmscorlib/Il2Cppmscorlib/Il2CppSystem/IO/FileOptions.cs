using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000523 RID: 1315
	[OriginalName("mscorlib.dll", "System.IO", "FileOptions")]
	[Flags]
	public enum FileOptions
	{
		// Token: 0x0400414D RID: 16717
		None = 0,
		// Token: 0x0400414E RID: 16718
		WriteThrough = -2147483648,
		// Token: 0x0400414F RID: 16719
		Asynchronous = 1073741824,
		// Token: 0x04004150 RID: 16720
		RandomAccess = 268435456,
		// Token: 0x04004151 RID: 16721
		DeleteOnClose = 67108864,
		// Token: 0x04004152 RID: 16722
		SequentialScan = 134217728,
		// Token: 0x04004153 RID: 16723
		Encrypted = 16384
	}
}
