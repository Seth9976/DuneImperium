using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000009 RID: 9
	[OriginalName("Microsoft.Extensions.Options.dll", "System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMemberTypes")]
	[Flags]
	public enum DynamicallyAccessedMemberTypes
	{
		// Token: 0x04000010 RID: 16
		None = 0,
		// Token: 0x04000011 RID: 17
		PublicParameterlessConstructor = 1,
		// Token: 0x04000012 RID: 18
		PublicConstructors = 3,
		// Token: 0x04000013 RID: 19
		NonPublicConstructors = 4,
		// Token: 0x04000014 RID: 20
		PublicMethods = 8,
		// Token: 0x04000015 RID: 21
		NonPublicMethods = 16,
		// Token: 0x04000016 RID: 22
		PublicFields = 32,
		// Token: 0x04000017 RID: 23
		NonPublicFields = 64,
		// Token: 0x04000018 RID: 24
		PublicNestedTypes = 128,
		// Token: 0x04000019 RID: 25
		NonPublicNestedTypes = 256,
		// Token: 0x0400001A RID: 26
		PublicProperties = 512,
		// Token: 0x0400001B RID: 27
		NonPublicProperties = 1024,
		// Token: 0x0400001C RID: 28
		PublicEvents = 2048,
		// Token: 0x0400001D RID: 29
		NonPublicEvents = 4096,
		// Token: 0x0400001E RID: 30
		Interfaces = 8192,
		// Token: 0x0400001F RID: 31
		All = -1
	}
}
