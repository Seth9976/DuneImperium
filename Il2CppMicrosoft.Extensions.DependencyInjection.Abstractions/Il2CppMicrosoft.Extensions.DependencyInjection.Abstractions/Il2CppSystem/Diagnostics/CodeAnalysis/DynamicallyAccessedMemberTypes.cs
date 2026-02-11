using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000B RID: 11
	[OriginalName("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMemberTypes")]
	[Flags]
	public enum DynamicallyAccessedMemberTypes
	{
		// Token: 0x0400001C RID: 28
		None = 0,
		// Token: 0x0400001D RID: 29
		PublicParameterlessConstructor = 1,
		// Token: 0x0400001E RID: 30
		PublicConstructors = 3,
		// Token: 0x0400001F RID: 31
		NonPublicConstructors = 4,
		// Token: 0x04000020 RID: 32
		PublicMethods = 8,
		// Token: 0x04000021 RID: 33
		NonPublicMethods = 16,
		// Token: 0x04000022 RID: 34
		PublicFields = 32,
		// Token: 0x04000023 RID: 35
		NonPublicFields = 64,
		// Token: 0x04000024 RID: 36
		PublicNestedTypes = 128,
		// Token: 0x04000025 RID: 37
		NonPublicNestedTypes = 256,
		// Token: 0x04000026 RID: 38
		PublicProperties = 512,
		// Token: 0x04000027 RID: 39
		NonPublicProperties = 1024,
		// Token: 0x04000028 RID: 40
		PublicEvents = 2048,
		// Token: 0x04000029 RID: 41
		NonPublicEvents = 4096,
		// Token: 0x0400002A RID: 42
		Interfaces = 8192,
		// Token: 0x0400002B RID: 43
		All = -1
	}
}
