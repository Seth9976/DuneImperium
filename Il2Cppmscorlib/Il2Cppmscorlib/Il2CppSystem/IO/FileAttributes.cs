using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x0200053D RID: 1341
	[OriginalName("mscorlib.dll", "System.IO", "FileAttributes")]
	[Flags]
	public enum FileAttributes
	{
		// Token: 0x040042F2 RID: 17138
		ReadOnly = 1,
		// Token: 0x040042F3 RID: 17139
		Hidden = 2,
		// Token: 0x040042F4 RID: 17140
		System = 4,
		// Token: 0x040042F5 RID: 17141
		Directory = 16,
		// Token: 0x040042F6 RID: 17142
		Archive = 32,
		// Token: 0x040042F7 RID: 17143
		Device = 64,
		// Token: 0x040042F8 RID: 17144
		Normal = 128,
		// Token: 0x040042F9 RID: 17145
		Temporary = 256,
		// Token: 0x040042FA RID: 17146
		SparseFile = 512,
		// Token: 0x040042FB RID: 17147
		ReparsePoint = 1024,
		// Token: 0x040042FC RID: 17148
		Compressed = 2048,
		// Token: 0x040042FD RID: 17149
		Offline = 4096,
		// Token: 0x040042FE RID: 17150
		NotContentIndexed = 8192,
		// Token: 0x040042FF RID: 17151
		Encrypted = 16384,
		// Token: 0x04004300 RID: 17152
		IntegrityStream = 32768,
		// Token: 0x04004301 RID: 17153
		NoScrubData = 131072
	}
}
