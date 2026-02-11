using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000BC RID: 188
	public class UpdateDeveloperMetadataRequest : Object
	{
		// Token: 0x0600100B RID: 4107 RVA: 0x000489E4 File Offset: 0x00046BE4
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateDeveloperMetadataRequest()
		{
			Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateDeveloperMetadataRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr);
			UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, "<DataFilters>k__BackingField");
			UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, "<DeveloperMetadata>k__BackingField");
			UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, "<Fields>k__BackingField");
			UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665480);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665481);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665482);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665483);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665484);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665485);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665486);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665487);
			UpdateDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr, 100665488);
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00048B18 File Offset: 0x00046D18
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00048B64 File Offset: 0x00046D64
		public unsafe virtual IList<DataFilter> DataFilters
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DataFilter>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00048BB4 File Offset: 0x00046DB4
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00048C00 File Offset: 0x00046E00
		public unsafe virtual DeveloperMetadata DeveloperMetadata
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeveloperMetadata>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00048C50 File Offset: 0x00046E50
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00048C9C File Offset: 0x00046E9C
		public unsafe virtual Object Fields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00048CEC File Offset: 0x00046EEC
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00048D30 File Offset: 0x00046F30
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00048D80 File Offset: 0x00046F80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateDeveloperMetadataRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDeveloperMetadataRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00009B96 File Offset: 0x00007D96
		public UpdateDeveloperMetadataRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00048DBC File Offset: 0x00046FBC
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00009B9F File Offset: 0x00007D9F
		public unsafe IList<DataFilter> _DataFilters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DataFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00048DEC File Offset: 0x00046FEC
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00009BBE File Offset: 0x00007DBE
		public unsafe DeveloperMetadata _DeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeveloperMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x00048E1C File Offset: 0x0004701C
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00009BDD File Offset: 0x00007DDD
		public unsafe Object _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00048E4C File Offset: 0x0004704C
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00009BFC File Offset: 0x00007DFC
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeFieldInfoPtr__DataFilters_k__BackingField;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeFieldInfoPtr__DeveloperMetadata_k__BackingField;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadata_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_DeveloperMetadata_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
