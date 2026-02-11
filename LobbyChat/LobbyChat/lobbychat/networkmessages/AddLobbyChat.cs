using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lobbychat.data;

namespace lobbychat.networkmessages
{
	// Token: 0x0200000A RID: 10
	public class AddLobbyChat : NetworkMessageEvent
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002A5C File Offset: 0x00000C5C
		// Note: this type is marked as 'beforefieldinit'.
		static AddLobbyChat()
		{
			Il2CppClassPointerStore<AddLobbyChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "lobbychat.networkmessages", "AddLobbyChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddLobbyChat>.NativeClassPtr);
			AddLobbyChat.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddLobbyChat>.NativeClassPtr, "Message");
			AddLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddLobbyChat>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002AB4 File Offset: 0x00000CB4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddLobbyChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddLobbyChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddLobbyChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002187 File Offset: 0x00000387
		public AddLobbyChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002190 File Offset: 0x00000390
		public unsafe ChatMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddLobbyChat.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddLobbyChat.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
