using System;
using boardgames.prompts.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.dataRenderers
{
	// Token: 0x02000156 RID: 342
	public class SetSelectedFriendEntry : Subscriber
	{
		// Token: 0x06000F67 RID: 3943 RVA: 0x0004E86C File Offset: 0x0004CA6C
		// Note: this type is marked as 'beforefieldinit'.
		static SetSelectedFriendEntry()
		{
			Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "SetSelectedFriendEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr);
			SetSelectedFriendEntry.NativeFieldInfoPtr_friendsListPromptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr, "friendsListPromptBehaviour");
			SetSelectedFriendEntry.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr, 100665511);
			SetSelectedFriendEntry.NativeMethodInfoPtr_Event_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr, 100665512);
			SetSelectedFriendEntry.NativeMethodInfoPtr_Event_ToggleSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr, 100665513);
			SetSelectedFriendEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr, 100665514);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0004E900 File Offset: 0x0004CB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513320, XrefRangeEnd = 513323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetSelectedFriendEntry.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0004E93C File Offset: 0x0004CB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513323, XrefRangeEnd = 513324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedFriendEntry.NativeMethodInfoPtr_Event_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0004E970 File Offset: 0x0004CB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513324, XrefRangeEnd = 513326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleSelected(bool selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedFriendEntry.NativeMethodInfoPtr_Event_ToggleSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0004E9B0 File Offset: 0x0004CBB0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetSelectedFriendEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSelectedFriendEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedFriendEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000096D8 File Offset: 0x000078D8
		public SetSelectedFriendEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0004E9EC File Offset: 0x0004CBEC
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x000096E1 File Offset: 0x000078E1
		public unsafe FriendsListPromptBehaviour friendsListPromptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedFriendEntry.NativeFieldInfoPtr_friendsListPromptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedFriendEntry.NativeFieldInfoPtr_friendsListPromptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_friendsListPromptBehaviour;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_Event_Select_Public_Void_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleSelected_Public_Void_Boolean_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
