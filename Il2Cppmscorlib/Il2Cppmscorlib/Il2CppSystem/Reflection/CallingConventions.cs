using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000405 RID: 1029
	[OriginalName("mscorlib.dll", "System.Reflection", "CallingConventions")]
	[Flags]
	public enum CallingConventions
	{
		// Token: 0x04003053 RID: 12371
		Standard = 1,
		// Token: 0x04003054 RID: 12372
		VarArgs = 2,
		// Token: 0x04003055 RID: 12373
		Any = 3,
		// Token: 0x04003056 RID: 12374
		HasThis = 32,
		// Token: 0x04003057 RID: 12375
		ExplicitThis = 64
	}
}
