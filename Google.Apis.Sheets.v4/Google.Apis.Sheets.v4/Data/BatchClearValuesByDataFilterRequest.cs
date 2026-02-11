using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000023 RID: 35
	public class BatchClearValuesByDataFilterRequest : Object
	{
		// Token: 0x06000260 RID: 608 RVA: 0x00014094 File Offset: 0x00012294
		// Note: this type is marked as 'beforefieldinit'.
		static BatchClearValuesByDataFilterRequest()
		{
			Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchClearValuesByDataFilterRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr);
			BatchClearValuesByDataFilterRequest.NativeFieldInfoPtr__DataFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr, "<DataFilters>k__BackingField");
			BatchClearValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr, "<ETag>k__BackingField");
			BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr, 100663807);
			BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr, 100663808);
			BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr, 100663809);
			BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr, 100663810);
			BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr, 100663811);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00014150 File Offset: 0x00012350
		// (set) Token: 0x06000262 RID: 610 RVA: 0x0001419C File Offset: 0x0001239C
		public unsafe virtual IList<DataFilter> DataFilters
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000141EC File Offset: 0x000123EC
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00014230 File Offset: 0x00012430
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00014280 File Offset: 0x00012480
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchClearValuesByDataFilterRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchClearValuesByDataFilterRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchClearValuesByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003181 File Offset: 0x00001381
		public BatchClearValuesByDataFilterRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000267 RID: 615 RVA: 0x000142BC File Offset: 0x000124BC
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000318A File Offset: 0x0000138A
		public unsafe IList<DataFilter> _DataFilters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterRequest.NativeFieldInfoPtr__DataFilters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DataFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterRequest.NativeFieldInfoPtr__DataFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000142EC File Offset: 0x000124EC
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000031A9 File Offset: 0x000013A9
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr__DataFilters_k__BackingField;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
