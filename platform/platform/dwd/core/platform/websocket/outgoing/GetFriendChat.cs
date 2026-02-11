using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000027 RID: 39
	public class GetFriendChat : OutgoingWebSocketMessage
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// Note: this type is marked as 'beforefieldinit'.
		static GetFriendChat()
		{
			Il2CppClassPointerStore<GetFriendChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "GetFriendChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetFriendChat>.NativeClassPtr);
			GetFriendChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendChat>.NativeClassPtr, 100663592);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000AB38 File Offset: 0x00008D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167835, XrefRangeEnd = 1167838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetFriendChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetFriendChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetFriendChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public GetFriendChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
