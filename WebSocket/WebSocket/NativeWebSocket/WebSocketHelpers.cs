using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace NativeWebSocket
{
	// Token: 0x0200000A RID: 10
	public static class WebSocketHelpers : Object
	{
		// Token: 0x0600002A RID: 42 RVA: 0x0000212B File Offset: 0x0000032B
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocketHelpers()
		{
			Il2CppClassPointerStore<WebSocketHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("WebSocket.dll", "NativeWebSocket", "WebSocketHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHelpers>.NativeClassPtr);
			WebSocketHelpers.NativeMethodInfoPtr_ParseCloseCodeEnum_Public_Static_WebSocketCloseCode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHelpers>.NativeClassPtr, 100663332);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003360 File Offset: 0x00001560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262472, XrefRangeEnd = 1262485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebSocketCloseCode ParseCloseCodeEnum(int closeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHelpers.NativeMethodInfoPtr_ParseCloseCodeEnum_Public_Static_WebSocketCloseCode_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002164 File Offset: 0x00000364
		public WebSocketHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_ParseCloseCodeEnum_Public_Static_WebSocketCloseCode_Int32_0;
	}
}
