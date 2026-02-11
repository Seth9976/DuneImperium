using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x0200025D RID: 605
	[OriginalName("System.dll", "System.Net.WebSockets", "WebSocketState")]
	public enum WebSocketState
	{
		// Token: 0x0400203A RID: 8250
		None,
		// Token: 0x0400203B RID: 8251
		Connecting,
		// Token: 0x0400203C RID: 8252
		Open,
		// Token: 0x0400203D RID: 8253
		CloseSent,
		// Token: 0x0400203E RID: 8254
		CloseReceived,
		// Token: 0x0400203F RID: 8255
		Closed,
		// Token: 0x04002040 RID: 8256
		Aborted
	}
}
