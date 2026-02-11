using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000054 RID: 84
	public class DeleteDeveloperMetadataResponse : Object
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x00023044 File Offset: 0x00021244
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteDeveloperMetadataResponse()
		{
			Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteDeveloperMetadataResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr);
			DeleteDeveloperMetadataResponse.NativeFieldInfoPtr__DeletedDeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr, "<DeletedDeveloperMetadata>k__BackingField");
			DeleteDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_get_DeletedDeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr, 100664286);
			DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_set_DeletedDeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr, 100664287);
			DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr, 100664288);
			DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr, 100664289);
			DeleteDeveloperMetadataResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr, 100664290);
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00023100 File Offset: 0x00021300
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x0002314C File Offset: 0x0002134C
		public unsafe virtual IList<DeveloperMetadata> DeletedDeveloperMetadata
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_get_DeletedDeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DeveloperMetadata>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_set_DeletedDeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0002319C File Offset: 0x0002139C
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x000231E0 File Offset: 0x000213E0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00023230 File Offset: 0x00021430
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteDeveloperMetadataResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDeveloperMetadataResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDeveloperMetadataResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00004F05 File Offset: 0x00003105
		public DeleteDeveloperMetadataResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0002326C File Offset: 0x0002146C
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00004F0E File Offset: 0x0000310E
		public unsafe IList<DeveloperMetadata> _DeletedDeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataResponse.NativeFieldInfoPtr__DeletedDeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DeveloperMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataResponse.NativeFieldInfoPtr__DeletedDeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0002329C File Offset: 0x0002149C
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00004F2D File Offset: 0x0000312D
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr__DeletedDeveloperMetadata_k__BackingField;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_get_DeletedDeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_set_DeletedDeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
