using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200006A RID: 106
	[OriginalName("System.dll", "System", "UriSyntaxFlags")]
	[Flags]
	public enum UriSyntaxFlags
	{
		// Token: 0x04000593 RID: 1427
		None = 0,
		// Token: 0x04000594 RID: 1428
		MustHaveAuthority = 1,
		// Token: 0x04000595 RID: 1429
		OptionalAuthority = 2,
		// Token: 0x04000596 RID: 1430
		MayHaveUserInfo = 4,
		// Token: 0x04000597 RID: 1431
		MayHavePort = 8,
		// Token: 0x04000598 RID: 1432
		MayHavePath = 16,
		// Token: 0x04000599 RID: 1433
		MayHaveQuery = 32,
		// Token: 0x0400059A RID: 1434
		MayHaveFragment = 64,
		// Token: 0x0400059B RID: 1435
		AllowEmptyHost = 128,
		// Token: 0x0400059C RID: 1436
		AllowUncHost = 256,
		// Token: 0x0400059D RID: 1437
		AllowDnsHost = 512,
		// Token: 0x0400059E RID: 1438
		AllowIPv4Host = 1024,
		// Token: 0x0400059F RID: 1439
		AllowIPv6Host = 2048,
		// Token: 0x040005A0 RID: 1440
		AllowAnInternetHost = 3584,
		// Token: 0x040005A1 RID: 1441
		AllowAnyOtherHost = 4096,
		// Token: 0x040005A2 RID: 1442
		FileLikeUri = 8192,
		// Token: 0x040005A3 RID: 1443
		MailToLikeUri = 16384,
		// Token: 0x040005A4 RID: 1444
		V1_UnknownUri = 65536,
		// Token: 0x040005A5 RID: 1445
		SimpleUserSyntax = 131072,
		// Token: 0x040005A6 RID: 1446
		BuiltInSyntax = 262144,
		// Token: 0x040005A7 RID: 1447
		ParserSchemeOnly = 524288,
		// Token: 0x040005A8 RID: 1448
		AllowDOSPath = 1048576,
		// Token: 0x040005A9 RID: 1449
		PathIsRooted = 2097152,
		// Token: 0x040005AA RID: 1450
		ConvertPathSlashes = 4194304,
		// Token: 0x040005AB RID: 1451
		CompressPath = 8388608,
		// Token: 0x040005AC RID: 1452
		CanonicalizeAsFilePath = 16777216,
		// Token: 0x040005AD RID: 1453
		UnEscapeDotsAndSlashes = 33554432,
		// Token: 0x040005AE RID: 1454
		AllowIdn = 67108864,
		// Token: 0x040005AF RID: 1455
		AllowIriParsing = 268435456
	}
}
