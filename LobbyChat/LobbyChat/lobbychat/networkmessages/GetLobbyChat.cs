using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lobbychat.networkmessages
{
	// Token: 0x0200000C RID: 12
	public class GetLobbyChat : NetworkMessageEvent
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000021F1 File Offset: 0x000003F1
		// Note: this type is marked as 'beforefieldinit'.
		static GetLobbyChat()
		{
			Il2CppClassPointerStore<GetLobbyChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "lobbychat.networkmessages", "GetLobbyChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetLobbyChat>.NativeClassPtr);
			GetLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLobbyChat>.NativeClassPtr, 100663309);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B5C File Offset: 0x00000D5C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetLobbyChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLobbyChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000222A File Offset: 0x0000042A
		public GetLobbyChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
