using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AD RID: 173
	[Flags]
	public enum JsonSchemaType
	{
		// Token: 0x04000C88 RID: 3208
		None = 0,
		// Token: 0x04000C89 RID: 3209
		String = 1,
		// Token: 0x04000C8A RID: 3210
		Float = 2,
		// Token: 0x04000C8B RID: 3211
		Integer = 4,
		// Token: 0x04000C8C RID: 3212
		Boolean = 8,
		// Token: 0x04000C8D RID: 3213
		Object = 16,
		// Token: 0x04000C8E RID: 3214
		Array = 32,
		// Token: 0x04000C8F RID: 3215
		Null = 64,
		// Token: 0x04000C90 RID: 3216
		Any = 127
	}
}
