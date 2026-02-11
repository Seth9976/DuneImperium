using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lobbychat.data;

namespace Networking.lobby.chat.responses
{
	// Token: 0x02000006 RID: 6
	public class GameLobbyChatMessageAdded : NetworkMessageEvent
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0000274C File Offset: 0x0000094C
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbyChatMessageAdded()
		{
			Il2CppClassPointerStore<GameLobbyChatMessageAdded>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "Networking.lobby.chat.responses", "GameLobbyChatMessageAdded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbyChatMessageAdded>.NativeClassPtr);
			GameLobbyChatMessageAdded.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyChatMessageAdded>.NativeClassPtr, "Message");
			GameLobbyChatMessageAdded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatMessageAdded>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000027A4 File Offset: 0x000009A4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLobbyChatMessageAdded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLobbyChatMessageAdded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyChatMessageAdded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020E7 File Offset: 0x000002E7
		public GameLobbyChatMessageAdded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000027E0 File Offset: 0x000009E0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe ChatMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatMessageAdded.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatMessageAdded.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
