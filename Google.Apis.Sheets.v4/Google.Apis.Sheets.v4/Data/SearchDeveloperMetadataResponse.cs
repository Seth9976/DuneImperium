using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200009E RID: 158
	public class SearchDeveloperMetadataResponse : Object
	{
		// Token: 0x06000D35 RID: 3381 RVA: 0x0003DA60 File Offset: 0x0003BC60
		// Note: this type is marked as 'beforefieldinit'.
		static SearchDeveloperMetadataResponse()
		{
			Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "SearchDeveloperMetadataResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr);
			SearchDeveloperMetadataResponse.NativeFieldInfoPtr__MatchedDeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr, "<MatchedDeveloperMetadata>k__BackingField");
			SearchDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr, "<ETag>k__BackingField");
			SearchDeveloperMetadataResponse.NativeMethodInfoPtr_get_MatchedDeveloperMetadata_Public_Virtual_New_get_IList_1_MatchedDeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr, 100665132);
			SearchDeveloperMetadataResponse.NativeMethodInfoPtr_set_MatchedDeveloperMetadata_Public_Virtual_New_set_Void_IList_1_MatchedDeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr, 100665133);
			SearchDeveloperMetadataResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr, 100665134);
			SearchDeveloperMetadataResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr, 100665135);
			SearchDeveloperMetadataResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr, 100665136);
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0003DB1C File Offset: 0x0003BD1C
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0003DB68 File Offset: 0x0003BD68
		public unsafe virtual IList<MatchedDeveloperMetadata> MatchedDeveloperMetadata
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataResponse.NativeMethodInfoPtr_get_MatchedDeveloperMetadata_Public_Virtual_New_get_IList_1_MatchedDeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<MatchedDeveloperMetadata>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataResponse.NativeMethodInfoPtr_set_MatchedDeveloperMetadata_Public_Virtual_New_set_Void_IList_1_MatchedDeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0003DBB8 File Offset: 0x0003BDB8
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0003DC4C File Offset: 0x0003BE4C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchDeveloperMetadataResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchDeveloperMetadataResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchDeveloperMetadataResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00008594 File Offset: 0x00006794
		public SearchDeveloperMetadataResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0003DC88 File Offset: 0x0003BE88
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x0000859D File Offset: 0x0000679D
		public unsafe IList<MatchedDeveloperMetadata> _MatchedDeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataResponse.NativeFieldInfoPtr__MatchedDeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<MatchedDeveloperMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataResponse.NativeFieldInfoPtr__MatchedDeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x000085BC File Offset: 0x000067BC
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr__MatchedDeveloperMetadata_k__BackingField;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchedDeveloperMetadata_Public_Virtual_New_get_IList_1_MatchedDeveloperMetadata_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchedDeveloperMetadata_Public_Virtual_New_set_Void_IList_1_MatchedDeveloperMetadata_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
