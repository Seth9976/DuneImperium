using System;

namespace UnityEngine
{
	// Token: 0x020000B4 RID: 180
	[Flags]
	public enum ComputeBufferType
	{
		// Token: 0x04000BB4 RID: 2996
		Default = 0,
		// Token: 0x04000BB5 RID: 2997
		Raw = 1,
		// Token: 0x04000BB6 RID: 2998
		Append = 2,
		// Token: 0x04000BB7 RID: 2999
		Counter = 4,
		// Token: 0x04000BB8 RID: 3000
		Constant = 8,
		// Token: 0x04000BB9 RID: 3001
		Structured = 16,
		// Token: 0x04000BBA RID: 3002
		DrawIndirect = 256,
		// Token: 0x04000BBB RID: 3003
		IndirectArguments = 256,
		// Token: 0x04000BBC RID: 3004
		GPUMemory = 512
	}
}
