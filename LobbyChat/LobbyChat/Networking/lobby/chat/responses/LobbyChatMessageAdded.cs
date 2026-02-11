using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lobbychat.data;

namespace Networking.lobby.chat.responses
{
	// Token: 0x02000008 RID: 8
	public class LobbyChatMessageAdded : NetworkMessageEvent
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000028D4 File Offset: 0x00000AD4
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatMessageAdded()
		{
			Il2CppClassPointerStore<LobbyChatMessageAdded>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "Networking.lobby.chat.responses", "LobbyChatMessageAdded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatMessageAdded>.NativeClassPtr);
			LobbyChatMessageAdded.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMessageAdded>.NativeClassPtr, "Message");
			LobbyChatMessageAdded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatMessageAdded>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000292C File Offset: 0x00000B2C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyChatMessageAdded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyChatMessageAdded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatMessageAdded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002137 File Offset: 0x00000337
		public LobbyChatMessageAdded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002968 File Offset: 0x00000B68
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002140 File Offset: 0x00000340
		public unsafe ChatMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyChatMessageAdded.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyChatMessageAdded.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
