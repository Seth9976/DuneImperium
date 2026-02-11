using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lobbychat.data;

namespace Networking.lobby.chat.responses
{
	// Token: 0x02000007 RID: 7
	public class GameLobbyChatMessages : NetworkMessageEvent
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002810 File Offset: 0x00000A10
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbyChatMessages()
		{
			Il2CppClassPointerStore<GameLobbyChatMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "Networking.lobby.chat.responses", "GameLobbyChatMessages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbyChatMessages>.NativeClassPtr);
			GameLobbyChatMessages.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyChatMessages>.NativeClassPtr, "Messages");
			GameLobbyChatMessages.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatMessages>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002868 File Offset: 0x00000A68
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLobbyChatMessages()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLobbyChatMessages>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyChatMessages.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000210F File Offset: 0x0000030F
		public GameLobbyChatMessages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000028A4 File Offset: 0x00000AA4
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe Il2CppReferenceArray<ChatMessage> Messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatMessages.NativeFieldInfoPtr_Messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatMessages.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_Messages;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
