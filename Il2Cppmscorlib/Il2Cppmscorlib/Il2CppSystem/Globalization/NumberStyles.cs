using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000479 RID: 1145
	[OriginalName("mscorlib.dll", "System.Globalization", "NumberStyles")]
	[Flags]
	public enum NumberStyles
	{
		// Token: 0x0400390D RID: 14605
		None = 0,
		// Token: 0x0400390E RID: 14606
		AllowLeadingWhite = 1,
		// Token: 0x0400390F RID: 14607
		AllowTrailingWhite = 2,
		// Token: 0x04003910 RID: 14608
		AllowLeadingSign = 4,
		// Token: 0x04003911 RID: 14609
		AllowTrailingSign = 8,
		// Token: 0x04003912 RID: 14610
		AllowParentheses = 16,
		// Token: 0x04003913 RID: 14611
		AllowDecimalPoint = 32,
		// Token: 0x04003914 RID: 14612
		AllowThousands = 64,
		// Token: 0x04003915 RID: 14613
		AllowExponent = 128,
		// Token: 0x04003916 RID: 14614
		AllowCurrencySymbol = 256,
		// Token: 0x04003917 RID: 14615
		AllowHexSpecifier = 512,
		// Token: 0x04003918 RID: 14616
		Integer = 7,
		// Token: 0x04003919 RID: 14617
		HexNumber = 515,
		// Token: 0x0400391A RID: 14618
		Number = 111,
		// Token: 0x0400391B RID: 14619
		Float = 167,
		// Token: 0x0400391C RID: 14620
		Currency = 383,
		// Token: 0x0400391D RID: 14621
		Any = 511
	}
}
