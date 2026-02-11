using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000063 RID: 99
	[OriginalName("System.dll", "System", "ParsingError")]
	public enum ParsingError
	{
		// Token: 0x04000518 RID: 1304
		None,
		// Token: 0x04000519 RID: 1305
		BadFormat,
		// Token: 0x0400051A RID: 1306
		BadScheme,
		// Token: 0x0400051B RID: 1307
		BadAuthority,
		// Token: 0x0400051C RID: 1308
		EmptyUriString,
		// Token: 0x0400051D RID: 1309
		LastRelativeUriOkErrIndex = 4,
		// Token: 0x0400051E RID: 1310
		SchemeLimit,
		// Token: 0x0400051F RID: 1311
		SizeLimit,
		// Token: 0x04000520 RID: 1312
		MustRootedPath,
		// Token: 0x04000521 RID: 1313
		BadHostName,
		// Token: 0x04000522 RID: 1314
		NonEmptyHost,
		// Token: 0x04000523 RID: 1315
		BadPort,
		// Token: 0x04000524 RID: 1316
		BadAuthorityTerminator,
		// Token: 0x04000525 RID: 1317
		CannotCreateRelative
	}
}
