using System;
using dwd.core.platform.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000038 RID: 56
	public class ChatReceived : TypedMessage
	{
		// Token: 0x060001DA RID: 474 RVA: 0x0000B518 File Offset: 0x00009718
		// Note: this type is marked as 'beforefieldinit'.
		static ChatReceived()
		{
			Il2CppClassPointerStore<ChatReceived>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "ChatReceived");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatReceived>.NativeClassPtr);
			ChatReceived.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatReceived>.NativeClassPtr, "Message");
			ChatReceived.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatReceived>.NativeClassPtr, 100663611);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000B570 File Offset: 0x00009770
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatReceived()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatReceived>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatReceived.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002E8C File Offset: 0x0000108C
		public ChatReceived(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000B5AC File Offset: 0x000097AC
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002E95 File Offset: 0x00001095
		public unsafe FriendChatMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatReceived.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatReceived.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
