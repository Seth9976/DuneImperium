using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000101 RID: 257
	public enum BsonBinaryType : byte
	{
		// Token: 0x0400113C RID: 4412
		Binary,
		// Token: 0x0400113D RID: 4413
		Function,
		// Token: 0x0400113E RID: 4414
		BinaryOld,
		// Token: 0x0400113F RID: 4415
		UuidOld,
		// Token: 0x04001140 RID: 4416
		Uuid,
		// Token: 0x04001141 RID: 4417
		Md5,
		// Token: 0x04001142 RID: 4418
		UserDefined = 128
	}
}
