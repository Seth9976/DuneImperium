using System;
using dbgclient.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000C1 RID: 193
	public class SetSelectedFriendInviteEntry : Subscriber
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x00036174 File Offset: 0x00034374
		// Note: this type is marked as 'beforefieldinit'.
		static SetSelectedFriendInviteEntry()
		{
			Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "SetSelectedFriendInviteEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr);
			SetSelectedFriendInviteEntry.NativeFieldInfoPtr_friendGameInvitePromptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr, "friendGameInvitePromptBehaviour");
			SetSelectedFriendInviteEntry.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr, 100664466);
			SetSelectedFriendInviteEntry.NativeMethodInfoPtr_Event_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr, 100664467);
			SetSelectedFriendInviteEntry.NativeMethodInfoPtr_Event_ToggleSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr, 100664468);
			SetSelectedFriendInviteEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr, 100664469);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00036208 File Offset: 0x00034408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504602, XrefRangeEnd = 504605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetSelectedFriendInviteEntry.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00036244 File Offset: 0x00034444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504605, XrefRangeEnd = 504609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedFriendInviteEntry.NativeMethodInfoPtr_Event_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00036278 File Offset: 0x00034478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504609, XrefRangeEnd = 504614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleSelected(bool selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedFriendInviteEntry.NativeMethodInfoPtr_Event_ToggleSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000362B8 File Offset: 0x000344B8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetSelectedFriendInviteEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSelectedFriendInviteEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedFriendInviteEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00005AC1 File Offset: 0x00003CC1
		public SetSelectedFriendInviteEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x000362F4 File Offset: 0x000344F4
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00005ACA File Offset: 0x00003CCA
		public unsafe FriendGameInvitePromptBehaviour friendGameInvitePromptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedFriendInviteEntry.NativeFieldInfoPtr_friendGameInvitePromptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendGameInvitePromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedFriendInviteEntry.NativeFieldInfoPtr_friendGameInvitePromptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_friendGameInvitePromptBehaviour;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_Event_Select_Public_Void_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleSelected_Public_Void_Boolean_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
