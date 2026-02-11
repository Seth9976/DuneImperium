using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200007A RID: 122
	[OriginalName("mscorlib.dll", "System", "AttributeTargets")]
	[Flags]
	public enum AttributeTargets
	{
		// Token: 0x040004DB RID: 1243
		Assembly = 1,
		// Token: 0x040004DC RID: 1244
		Module = 2,
		// Token: 0x040004DD RID: 1245
		Class = 4,
		// Token: 0x040004DE RID: 1246
		Struct = 8,
		// Token: 0x040004DF RID: 1247
		Enum = 16,
		// Token: 0x040004E0 RID: 1248
		Constructor = 32,
		// Token: 0x040004E1 RID: 1249
		Method = 64,
		// Token: 0x040004E2 RID: 1250
		Property = 128,
		// Token: 0x040004E3 RID: 1251
		Field = 256,
		// Token: 0x040004E4 RID: 1252
		Event = 512,
		// Token: 0x040004E5 RID: 1253
		Interface = 1024,
		// Token: 0x040004E6 RID: 1254
		Parameter = 2048,
		// Token: 0x040004E7 RID: 1255
		Delegate = 4096,
		// Token: 0x040004E8 RID: 1256
		ReturnValue = 8192,
		// Token: 0x040004E9 RID: 1257
		GenericParameter = 16384,
		// Token: 0x040004EA RID: 1258
		All = 32767
	}
}
