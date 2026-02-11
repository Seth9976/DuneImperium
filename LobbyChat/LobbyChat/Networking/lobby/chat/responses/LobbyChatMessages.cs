using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lobbychat.data;

namespace Networking.lobby.chat.responses
{
	// Token: 0x02000009 RID: 9
	public class LobbyChatMessages : NetworkMessageEvent
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002998 File Offset: 0x00000B98
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatMessages()
		{
			Il2CppClassPointerStore<LobbyChatMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "Networking.lobby.chat.responses", "LobbyChatMessages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatMessages>.NativeClassPtr);
			LobbyChatMessages.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMessages>.NativeClassPtr, "Messages");
			LobbyChatMessages.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatMessages>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000029F0 File Offset: 0x00000BF0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyChatMessages()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyChatMessages>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatMessages.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000215F File Offset: 0x0000035F
		public LobbyChatMessages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002A2C File Offset: 0x00000C2C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002168 File Offset: 0x00000368
		public unsafe Il2CppReferenceArray<ChatMessage> Messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyChatMessages.NativeFieldInfoPtr_Messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyChatMessages.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_Messages;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
