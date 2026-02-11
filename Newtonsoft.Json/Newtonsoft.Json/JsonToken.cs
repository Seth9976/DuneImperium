using System;

namespace Newtonsoft.Json
{
	// Token: 0x02000030 RID: 48
	public enum JsonToken
	{
		// Token: 0x04000405 RID: 1029
		None,
		// Token: 0x04000406 RID: 1030
		StartObject,
		// Token: 0x04000407 RID: 1031
		StartArray,
		// Token: 0x04000408 RID: 1032
		StartConstructor,
		// Token: 0x04000409 RID: 1033
		PropertyName,
		// Token: 0x0400040A RID: 1034
		Comment,
		// Token: 0x0400040B RID: 1035
		Raw,
		// Token: 0x0400040C RID: 1036
		Integer,
		// Token: 0x0400040D RID: 1037
		Float,
		// Token: 0x0400040E RID: 1038
		String,
		// Token: 0x0400040F RID: 1039
		Boolean,
		// Token: 0x04000410 RID: 1040
		Null,
		// Token: 0x04000411 RID: 1041
		Undefined,
		// Token: 0x04000412 RID: 1042
		EndObject,
		// Token: 0x04000413 RID: 1043
		EndArray,
		// Token: 0x04000414 RID: 1044
		EndConstructor,
		// Token: 0x04000415 RID: 1045
		Date,
		// Token: 0x04000416 RID: 1046
		Bytes
	}
}
