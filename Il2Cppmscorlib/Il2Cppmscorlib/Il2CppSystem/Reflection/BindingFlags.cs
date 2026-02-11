using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000404 RID: 1028
	[OriginalName("mscorlib.dll", "System.Reflection", "BindingFlags")]
	[Flags]
	public enum BindingFlags
	{
		// Token: 0x0400303D RID: 12349
		Default = 0,
		// Token: 0x0400303E RID: 12350
		IgnoreCase = 1,
		// Token: 0x0400303F RID: 12351
		DeclaredOnly = 2,
		// Token: 0x04003040 RID: 12352
		Instance = 4,
		// Token: 0x04003041 RID: 12353
		Static = 8,
		// Token: 0x04003042 RID: 12354
		Public = 16,
		// Token: 0x04003043 RID: 12355
		NonPublic = 32,
		// Token: 0x04003044 RID: 12356
		FlattenHierarchy = 64,
		// Token: 0x04003045 RID: 12357
		InvokeMethod = 256,
		// Token: 0x04003046 RID: 12358
		CreateInstance = 512,
		// Token: 0x04003047 RID: 12359
		GetField = 1024,
		// Token: 0x04003048 RID: 12360
		SetField = 2048,
		// Token: 0x04003049 RID: 12361
		GetProperty = 4096,
		// Token: 0x0400304A RID: 12362
		SetProperty = 8192,
		// Token: 0x0400304B RID: 12363
		PutDispProperty = 16384,
		// Token: 0x0400304C RID: 12364
		PutRefDispProperty = 32768,
		// Token: 0x0400304D RID: 12365
		ExactBinding = 65536,
		// Token: 0x0400304E RID: 12366
		SuppressChangeType = 131072,
		// Token: 0x0400304F RID: 12367
		OptionalParamBinding = 262144,
		// Token: 0x04003050 RID: 12368
		IgnoreReturn = 16777216,
		// Token: 0x04003051 RID: 12369
		DoNotWrapExceptions = 33554432
	}
}
