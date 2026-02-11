using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000BD RID: 189
	public class UpdateDeveloperMetadataResponse : Object
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x00048E74 File Offset: 0x00047074
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateDeveloperMetadataResponse()
		{
			Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateDeveloperMetadataResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr);
			UpdateDeveloperMetadataResponse.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr, "<DeveloperMetadata>k__BackingField");
			UpdateDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr, 100665489);
			UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr, 100665490);
			UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr, 100665491);
			UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr, 100665492);
			UpdateDeveloperMetadataResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr, 100665493);
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00048F30 File Offset: 0x00047130
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x00048F7C File Offset: 0x0004717C
		public unsafe virtual IList<DeveloperMetadata> DeveloperMetadata
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00048FCC File Offset: 0x000471CC
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x00049010 File Offset: 0x00047210
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00049060 File Offset: 0x00047260
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateDeveloperMetadataResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDeveloperMetadataResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeveloperMetadataResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00009C1B File Offset: 0x00007E1B
		public UpdateDeveloperMetadataResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0004909C File Offset: 0x0004729C
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x00009C24 File Offset: 0x00007E24
		public unsafe IList<DeveloperMetadata> _DeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataResponse.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DeveloperMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataResponse.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x000490CC File Offset: 0x000472CC
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x00009C43 File Offset: 0x00007E43
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr__DeveloperMetadata_k__BackingField;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
