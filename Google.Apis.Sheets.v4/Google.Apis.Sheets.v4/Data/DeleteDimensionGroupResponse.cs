using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000056 RID: 86
	public class DeleteDimensionGroupResponse : Object
	{
		// Token: 0x06000665 RID: 1637 RVA: 0x00023544 File Offset: 0x00021744
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteDimensionGroupResponse()
		{
			Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteDimensionGroupResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr);
			DeleteDimensionGroupResponse.NativeFieldInfoPtr__DimensionGroups_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr, "<DimensionGroups>k__BackingField");
			DeleteDimensionGroupResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteDimensionGroupResponse.NativeMethodInfoPtr_get_DimensionGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr, 100664296);
			DeleteDimensionGroupResponse.NativeMethodInfoPtr_set_DimensionGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr, 100664297);
			DeleteDimensionGroupResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr, 100664298);
			DeleteDimensionGroupResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr, 100664299);
			DeleteDimensionGroupResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr, 100664300);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00023600 File Offset: 0x00021800
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x0002364C File Offset: 0x0002184C
		public unsafe virtual IList<DimensionGroup> DimensionGroups
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDimensionGroupResponse.NativeMethodInfoPtr_get_DimensionGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDimensionGroupResponse.NativeMethodInfoPtr_set_DimensionGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0002369C File Offset: 0x0002189C
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x000236E0 File Offset: 0x000218E0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDimensionGroupResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDimensionGroupResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00023730 File Offset: 0x00021930
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteDimensionGroupResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDimensionGroupResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDimensionGroupResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00004F93 File Offset: 0x00003193
		public DeleteDimensionGroupResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0002376C File Offset: 0x0002196C
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00004F9C File Offset: 0x0000319C
		public unsafe IList<DimensionGroup> _DimensionGroups_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDimensionGroupResponse.NativeFieldInfoPtr__DimensionGroups_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDimensionGroupResponse.NativeFieldInfoPtr__DimensionGroups_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0002379C File Offset: 0x0002199C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00004FBB File Offset: 0x000031BB
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDimensionGroupResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDimensionGroupResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr__DimensionGroups_k__BackingField;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_get_DimensionGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_set_DimensionGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
