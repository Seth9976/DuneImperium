using System;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000020 RID: 32
	[Flags]
	public enum FontStyles
	{
		// Token: 0x04000313 RID: 787
		Normal = 0,
		// Token: 0x04000314 RID: 788
		Bold = 1,
		// Token: 0x04000315 RID: 789
		Italic = 2,
		// Token: 0x04000316 RID: 790
		Underline = 4,
		// Token: 0x04000317 RID: 791
		LowerCase = 8,
		// Token: 0x04000318 RID: 792
		UpperCase = 16,
		// Token: 0x04000319 RID: 793
		SmallCaps = 32,
		// Token: 0x0400031A RID: 794
		Strikethrough = 64,
		// Token: 0x0400031B RID: 795
		Superscript = 128,
		// Token: 0x0400031C RID: 796
		Subscript = 256,
		// Token: 0x0400031D RID: 797
		Highlight = 512
	}
}
