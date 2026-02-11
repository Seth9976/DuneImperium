using System;

namespace NativeWebSocket
{
	// Token: 0x02000008 RID: 8
	public enum WebSocketCloseCode
	{
		// Token: 0x0400001A RID: 26
		NotSet,
		// Token: 0x0400001B RID: 27
		Normal = 1000,
		// Token: 0x0400001C RID: 28
		Away,
		// Token: 0x0400001D RID: 29
		ProtocolError,
		// Token: 0x0400001E RID: 30
		UnsupportedData,
		// Token: 0x0400001F RID: 31
		Undefined,
		// Token: 0x04000020 RID: 32
		NoStatus,
		// Token: 0x04000021 RID: 33
		Abnormal,
		// Token: 0x04000022 RID: 34
		InvalidData,
		// Token: 0x04000023 RID: 35
		PolicyViolation,
		// Token: 0x04000024 RID: 36
		TooBig,
		// Token: 0x04000025 RID: 37
		MandatoryExtension,
		// Token: 0x04000026 RID: 38
		ServerError,
		// Token: 0x04000027 RID: 39
		TlsHandshakeFailure = 1015
	}
}
