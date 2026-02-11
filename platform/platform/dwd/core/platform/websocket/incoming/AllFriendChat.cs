using System;
using dwd.core.platform.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000033 RID: 51
	public class AllFriendChat : TypedMessage
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0000B044 File Offset: 0x00009244
		// Note: this type is marked as 'beforefieldinit'.
		static AllFriendChat()
		{
			Il2CppClassPointerStore<AllFriendChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "AllFriendChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllFriendChat>.NativeClassPtr);
			AllFriendChat.NativeFieldInfoPtr_MessageMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllFriendChat>.NativeClassPtr, "MessageMap");
			AllFriendChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllFriendChat>.NativeClassPtr, 100663605);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000B09C File Offset: 0x0000929C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllFriendChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllFriendChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllFriendChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002D6B File Offset: 0x00000F6B
		public AllFriendChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000B0D8 File Offset: 0x000092D8
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002D74 File Offset: 0x00000F74
		public unsafe Dictionary<string, List<FriendChatMessage>> MessageMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllFriendChat.NativeFieldInfoPtr_MessageMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<FriendChatMessage>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllFriendChat.NativeFieldInfoPtr_MessageMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_MessageMap;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
