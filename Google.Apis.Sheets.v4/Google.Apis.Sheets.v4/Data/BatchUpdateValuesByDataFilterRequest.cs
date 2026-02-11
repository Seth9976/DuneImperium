using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200002C RID: 44
	public class BatchUpdateValuesByDataFilterRequest : Object
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x000162EC File Offset: 0x000144EC
		// Note: this type is marked as 'beforefieldinit'.
		static BatchUpdateValuesByDataFilterRequest()
		{
			Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchUpdateValuesByDataFilterRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr);
			BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, "<Data>k__BackingField");
			BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, "<IncludeValuesInResponse>k__BackingField");
			BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, "<ResponseDateTimeRenderOption>k__BackingField");
			BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, "<ResponseValueRenderOption>k__BackingField");
			BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, "<ValueInputOption>k__BackingField");
			BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, "<ETag>k__BackingField");
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_DataFilterValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663876);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_DataFilterValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663877);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663878);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663879);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663880);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663881);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663882);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663883);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663884);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663885);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663886);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663887);
			BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr, 100663888);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00016498 File Offset: 0x00014698
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000164E4 File Offset: 0x000146E4
		public unsafe virtual IList<DataFilterValueRange> Data
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_DataFilterValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DataFilterValueRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_DataFilterValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00016534 File Offset: 0x00014734
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00016578 File Offset: 0x00014778
		public unsafe virtual Nullable<bool> IncludeValuesInResponse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000165CC File Offset: 0x000147CC
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00016610 File Offset: 0x00014810
		public unsafe virtual string ResponseDateTimeRenderOption
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00016660 File Offset: 0x00014860
		// (set) Token: 0x060002FB RID: 763 RVA: 0x000166A4 File Offset: 0x000148A4
		public unsafe virtual string ResponseValueRenderOption
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000166F4 File Offset: 0x000148F4
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00016738 File Offset: 0x00014938
		public unsafe virtual string ValueInputOption
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00016788 File Offset: 0x00014988
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000167CC File Offset: 0x000149CC
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0001681C File Offset: 0x00014A1C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchUpdateValuesByDataFilterRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchUpdateValuesByDataFilterRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchUpdateValuesByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003592 File Offset: 0x00001792
		public BatchUpdateValuesByDataFilterRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00016858 File Offset: 0x00014A58
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0000359B File Offset: 0x0000179B
		public unsafe IList<DataFilterValueRange> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DataFilterValueRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00016888 File Offset: 0x00014A88
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000035BA File Offset: 0x000017BA
		public Nullable<bool> _IncludeValuesInResponse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000168B8 File Offset: 0x00014AB8
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000035E8 File Offset: 0x000017E8
		public unsafe string _ResponseDateTimeRenderOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000168E0 File Offset: 0x00014AE0
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00003607 File Offset: 0x00001807
		public unsafe string _ResponseValueRenderOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00016908 File Offset: 0x00014B08
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003626 File Offset: 0x00001826
		public unsafe string _ValueInputOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00016930 File Offset: 0x00014B30
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003645 File Offset: 0x00001845
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr__ValueInputOption_k__BackingField;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_DataFilterValueRange_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_DataFilterValueRange_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_String_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_String_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_String_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
