using System;

namespace UnityEngine.Experimental.AI
{
	// Token: 0x02000004 RID: 4
	public enum PathQueryStatus
	{
		// Token: 0x04000020 RID: 32
		Failure = -2147483648,
		// Token: 0x04000021 RID: 33
		Success = 1073741824,
		// Token: 0x04000022 RID: 34
		InProgress = 536870912,
		// Token: 0x04000023 RID: 35
		StatusDetailMask = 16777215,
		// Token: 0x04000024 RID: 36
		WrongMagic = 1,
		// Token: 0x04000025 RID: 37
		WrongVersion,
		// Token: 0x04000026 RID: 38
		OutOfMemory = 4,
		// Token: 0x04000027 RID: 39
		InvalidParam = 8,
		// Token: 0x04000028 RID: 40
		BufferTooSmall = 16,
		// Token: 0x04000029 RID: 41
		OutOfNodes = 32,
		// Token: 0x0400002A RID: 42
		PartialResult = 64
	}
}
