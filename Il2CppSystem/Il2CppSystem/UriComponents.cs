using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000060 RID: 96
	[OriginalName("System.dll", "System", "UriComponents")]
	[Flags]
	public enum UriComponents
	{
		// Token: 0x040004FE RID: 1278
		Scheme = 1,
		// Token: 0x040004FF RID: 1279
		UserInfo = 2,
		// Token: 0x04000500 RID: 1280
		Host = 4,
		// Token: 0x04000501 RID: 1281
		Port = 8,
		// Token: 0x04000502 RID: 1282
		Path = 16,
		// Token: 0x04000503 RID: 1283
		Query = 32,
		// Token: 0x04000504 RID: 1284
		Fragment = 64,
		// Token: 0x04000505 RID: 1285
		StrongPort = 128,
		// Token: 0x04000506 RID: 1286
		NormalizedHost = 256,
		// Token: 0x04000507 RID: 1287
		KeepDelimiter = 1073741824,
		// Token: 0x04000508 RID: 1288
		SerializationInfoString = -2147483648,
		// Token: 0x04000509 RID: 1289
		AbsoluteUri = 127,
		// Token: 0x0400050A RID: 1290
		HostAndPort = 132,
		// Token: 0x0400050B RID: 1291
		StrongAuthority = 134,
		// Token: 0x0400050C RID: 1292
		SchemeAndServer = 13,
		// Token: 0x0400050D RID: 1293
		HttpRequestUrl = 61,
		// Token: 0x0400050E RID: 1294
		PathAndQuery = 48
	}
}
