using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lobbychat.networkmessages
{
	// Token: 0x0200000B RID: 11
	public class GetGameLobbyChat : NetworkMessageEvent
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000021AF File Offset: 0x000003AF
		// Note: this type is marked as 'beforefieldinit'.
		static GetGameLobbyChat()
		{
			Il2CppClassPointerStore<GetGameLobbyChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "lobbychat.networkmessages", "GetGameLobbyChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameLobbyChat>.NativeClassPtr);
			GetGameLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameLobbyChat>.NativeClassPtr, 100663308);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002B20 File Offset: 0x00000D20
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetGameLobbyChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameLobbyChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021E8 File Offset: 0x000003E8
		public GetGameLobbyChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
