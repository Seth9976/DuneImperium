using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200009D RID: 157
	public class SearchDeveloperMetadataRequest : Object
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x0003D7E0 File Offset: 0x0003B9E0
		// Note: this type is marked as 'beforefieldinit'.
		static SearchDeveloperMetadataRequest()
		{
			Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "SearchDeveloperMetadataRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr);
			SearchDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr, "<DataFilters>k__BackingField");
			SearchDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr, "<ETag>k__BackingField");
			SearchDeveloperMetadataRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr, 100665127);
			SearchDeveloperMetadataRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr, 100665128);
			SearchDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr, 100665129);
			SearchDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr, 100665130);
			SearchDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr, 100665131);
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0003D89C File Offset: 0x0003BA9C
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x0003D8E8 File Offset: 0x0003BAE8
		public unsafe virtual IList<DataFilter> DataFilters
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0003D938 File Offset: 0x0003BB38
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x0003D97C File Offset: 0x0003BB7C
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0003D9CC File Offset: 0x0003BBCC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchDeveloperMetadataRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchDeveloperMetadataRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0000854D File Offset: 0x0000674D
		public SearchDeveloperMetadataRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0003DA08 File Offset: 0x0003BC08
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00008556 File Offset: 0x00006756
		public unsafe IList<DataFilter> _DataFilters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DataFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x0003DA38 File Offset: 0x0003BC38
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00008575 File Offset: 0x00006775
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr__DataFilters_k__BackingField;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
