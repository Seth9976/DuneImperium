using System;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Flags]
	public enum EventModifiers
	{
		// Token: 0x0400006F RID: 111
		None = 0,
		// Token: 0x04000070 RID: 112
		Shift = 1,
		// Token: 0x04000071 RID: 113
		Control = 2,
		// Token: 0x04000072 RID: 114
		Alt = 4,
		// Token: 0x04000073 RID: 115
		Command = 8,
		// Token: 0x04000074 RID: 116
		Numeric = 16,
		// Token: 0x04000075 RID: 117
		CapsLock = 32,
		// Token: 0x04000076 RID: 118
		FunctionKey = 64
	}
}
