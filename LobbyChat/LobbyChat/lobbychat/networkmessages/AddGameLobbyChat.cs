using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lobbychat.data;

namespace lobbychat.networkmessages
{
	// Token: 0x0200000D RID: 13
	public class AddGameLobbyChat : NetworkMessageEvent
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002B98 File Offset: 0x00000D98
		// Note: this type is marked as 'beforefieldinit'.
		static AddGameLobbyChat()
		{
			Il2CppClassPointerStore<AddGameLobbyChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "lobbychat.networkmessages", "AddGameLobbyChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddGameLobbyChat>.NativeClassPtr);
			AddGameLobbyChat.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddGameLobbyChat>.NativeClassPtr, "Message");
			AddGameLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddGameLobbyChat>.NativeClassPtr, 100663310);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002BF0 File Offset: 0x00000DF0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddGameLobbyChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddGameLobbyChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddGameLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002233 File Offset: 0x00000433
		public AddGameLobbyChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002C2C File Offset: 0x00000E2C
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000223C File Offset: 0x0000043C
		public unsafe ChatMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddGameLobbyChat.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddGameLobbyChat.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
