using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000259 RID: 601
	[OriginalName("System.dll", "System.Net.WebSockets", "WebSocketError")]
	public enum WebSocketError
	{
		// Token: 0x04002012 RID: 8210
		Success,
		// Token: 0x04002013 RID: 8211
		InvalidMessageType,
		// Token: 0x04002014 RID: 8212
		Faulted,
		// Token: 0x04002015 RID: 8213
		NativeError,
		// Token: 0x04002016 RID: 8214
		NotAWebSocket,
		// Token: 0x04002017 RID: 8215
		UnsupportedVersion,
		// Token: 0x04002018 RID: 8216
		UnsupportedProtocol,
		// Token: 0x04002019 RID: 8217
		HeaderError,
		// Token: 0x0400201A RID: 8218
		ConnectionClosedPrematurely,
		// Token: 0x0400201B RID: 8219
		InvalidState
	}
}
