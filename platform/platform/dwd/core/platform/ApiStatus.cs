using System;

namespace dwd.core.platform
{
	// Token: 0x02000012 RID: 18
	public enum ApiStatus
	{
		// Token: 0x040000C9 RID: 201
		Success = 200,
		// Token: 0x040000CA RID: 202
		BadRequest = 400,
		// Token: 0x040000CB RID: 203
		EmailNotVerified,
		// Token: 0x040000CC RID: 204
		Forbidden = 403,
		// Token: 0x040000CD RID: 205
		Unreachable,
		// Token: 0x040000CE RID: 206
		Timeout = 408,
		// Token: 0x040000CF RID: 207
		InternalServerError = 500,
		// Token: 0x040000D0 RID: 208
		ServiceUnavailable = 503,
		// Token: 0x040000D1 RID: 209
		UnknownError = 1
	}
}
