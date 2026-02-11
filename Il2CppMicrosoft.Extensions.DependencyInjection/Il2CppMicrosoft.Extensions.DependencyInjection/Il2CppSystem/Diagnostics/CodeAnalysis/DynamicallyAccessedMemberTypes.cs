using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000A RID: 10
	[OriginalName("Microsoft.Extensions.DependencyInjection.dll", "System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMemberTypes")]
	[Flags]
	public enum DynamicallyAccessedMemberTypes
	{
		// Token: 0x0400002D RID: 45
		None = 0,
		// Token: 0x0400002E RID: 46
		PublicParameterlessConstructor = 1,
		// Token: 0x0400002F RID: 47
		PublicConstructors = 3,
		// Token: 0x04000030 RID: 48
		NonPublicConstructors = 4,
		// Token: 0x04000031 RID: 49
		PublicMethods = 8,
		// Token: 0x04000032 RID: 50
		NonPublicMethods = 16,
		// Token: 0x04000033 RID: 51
		PublicFields = 32,
		// Token: 0x04000034 RID: 52
		NonPublicFields = 64,
		// Token: 0x04000035 RID: 53
		PublicNestedTypes = 128,
		// Token: 0x04000036 RID: 54
		NonPublicNestedTypes = 256,
		// Token: 0x04000037 RID: 55
		PublicProperties = 512,
		// Token: 0x04000038 RID: 56
		NonPublicProperties = 1024,
		// Token: 0x04000039 RID: 57
		PublicEvents = 2048,
		// Token: 0x0400003A RID: 58
		NonPublicEvents = 4096,
		// Token: 0x0400003B RID: 59
		Interfaces = 8192,
		// Token: 0x0400003C RID: 60
		All = -1
	}
}
