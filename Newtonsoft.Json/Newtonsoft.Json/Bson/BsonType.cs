using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200010F RID: 271
	public enum BsonType : sbyte
	{
		// Token: 0x040011C1 RID: 4545
		Number = 1,
		// Token: 0x040011C2 RID: 4546
		String,
		// Token: 0x040011C3 RID: 4547
		Object,
		// Token: 0x040011C4 RID: 4548
		Array,
		// Token: 0x040011C5 RID: 4549
		Binary,
		// Token: 0x040011C6 RID: 4550
		Undefined,
		// Token: 0x040011C7 RID: 4551
		Oid,
		// Token: 0x040011C8 RID: 4552
		Boolean,
		// Token: 0x040011C9 RID: 4553
		Date,
		// Token: 0x040011CA RID: 4554
		Null,
		// Token: 0x040011CB RID: 4555
		Regex,
		// Token: 0x040011CC RID: 4556
		Reference,
		// Token: 0x040011CD RID: 4557
		Code,
		// Token: 0x040011CE RID: 4558
		Symbol,
		// Token: 0x040011CF RID: 4559
		CodeWScope,
		// Token: 0x040011D0 RID: 4560
		Integer,
		// Token: 0x040011D1 RID: 4561
		TimeStamp,
		// Token: 0x040011D2 RID: 4562
		Long,
		// Token: 0x040011D3 RID: 4563
		MinKey = -1,
		// Token: 0x040011D4 RID: 4564
		MaxKey = 127
	}
}
