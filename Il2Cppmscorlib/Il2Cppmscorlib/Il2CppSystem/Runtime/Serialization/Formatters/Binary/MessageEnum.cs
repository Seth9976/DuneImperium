using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000377 RID: 887
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MessageEnum")]
	[Flags]
	[Serializable]
	public enum MessageEnum
	{
		// Token: 0x04002CE8 RID: 11496
		NoArgs = 1,
		// Token: 0x04002CE9 RID: 11497
		ArgsInline = 2,
		// Token: 0x04002CEA RID: 11498
		ArgsIsArray = 4,
		// Token: 0x04002CEB RID: 11499
		ArgsInArray = 8,
		// Token: 0x04002CEC RID: 11500
		NoContext = 16,
		// Token: 0x04002CED RID: 11501
		ContextInline = 32,
		// Token: 0x04002CEE RID: 11502
		ContextInArray = 64,
		// Token: 0x04002CEF RID: 11503
		MethodSignatureInArray = 128,
		// Token: 0x04002CF0 RID: 11504
		PropertyInArray = 256,
		// Token: 0x04002CF1 RID: 11505
		NoReturnValue = 512,
		// Token: 0x04002CF2 RID: 11506
		ReturnValueVoid = 1024,
		// Token: 0x04002CF3 RID: 11507
		ReturnValueInline = 2048,
		// Token: 0x04002CF4 RID: 11508
		ReturnValueInArray = 4096,
		// Token: 0x04002CF5 RID: 11509
		ExceptionInArray = 8192,
		// Token: 0x04002CF6 RID: 11510
		GenericMethod = 32768
	}
}
