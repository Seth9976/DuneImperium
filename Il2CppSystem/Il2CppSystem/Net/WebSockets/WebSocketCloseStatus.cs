using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000258 RID: 600
	[OriginalName("System.dll", "System.Net.WebSockets", "WebSocketCloseStatus")]
	public enum WebSocketCloseStatus
	{
		// Token: 0x04002007 RID: 8199
		NormalClosure = 1000,
		// Token: 0x04002008 RID: 8200
		EndpointUnavailable,
		// Token: 0x04002009 RID: 8201
		ProtocolError,
		// Token: 0x0400200A RID: 8202
		InvalidMessageType,
		// Token: 0x0400200B RID: 8203
		Empty = 1005,
		// Token: 0x0400200C RID: 8204
		InvalidPayloadData = 1007,
		// Token: 0x0400200D RID: 8205
		PolicyViolation,
		// Token: 0x0400200E RID: 8206
		MessageTooBig,
		// Token: 0x0400200F RID: 8207
		MandatoryExtension,
		// Token: 0x04002010 RID: 8208
		InternalServerError
	}
}
