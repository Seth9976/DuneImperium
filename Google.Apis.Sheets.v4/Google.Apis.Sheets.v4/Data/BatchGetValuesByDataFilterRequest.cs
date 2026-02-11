using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000027 RID: 39
	public class BatchGetValuesByDataFilterRequest : Object
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00014C84 File Offset: 0x00012E84
		// Note: this type is marked as 'beforefieldinit'.
		static BatchGetValuesByDataFilterRequest()
		{
			Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchGetValuesByDataFilterRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr);
			BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__DataFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, "<DataFilters>k__BackingField");
			BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, "<DateTimeRenderOption>k__BackingField");
			BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, "<MajorDimension>k__BackingField");
			BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, "<ValueRenderOption>k__BackingField");
			BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, "<ETag>k__BackingField");
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663831);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663832);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663833);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663834);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663835);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663836);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663837);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663838);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663839);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663840);
			BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr, 100663841);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00014DF4 File Offset: 0x00012FF4
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00014E40 File Offset: 0x00013040
		public unsafe virtual IList<DataFilter> DataFilters
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00014E90 File Offset: 0x00013090
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00014ED4 File Offset: 0x000130D4
		public unsafe virtual string DateTimeRenderOption
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00014F24 File Offset: 0x00013124
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00014F68 File Offset: 0x00013168
		public unsafe virtual string MajorDimension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00014FB8 File Offset: 0x000131B8
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00014FFC File Offset: 0x000131FC
		public unsafe virtual string ValueRenderOption
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0001504C File Offset: 0x0001324C
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00015090 File Offset: 0x00013290
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000150E0 File Offset: 0x000132E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchGetValuesByDataFilterRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchGetValuesByDataFilterRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchGetValuesByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000032DB File Offset: 0x000014DB
		public BatchGetValuesByDataFilterRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001511C File Offset: 0x0001331C
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000032E4 File Offset: 0x000014E4
		public unsafe IList<DataFilter> _DataFilters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__DataFilters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DataFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__DataFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001514C File Offset: 0x0001334C
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003303 File Offset: 0x00001503
		public unsafe string _DateTimeRenderOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00015174 File Offset: 0x00013374
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003322 File Offset: 0x00001522
		public unsafe string _MajorDimension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001519C File Offset: 0x0001339C
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003341 File Offset: 0x00001541
		public unsafe string _ValueRenderOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000151C4 File Offset: 0x000133C4
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00003360 File Offset: 0x00001560
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr__DataFilters_k__BackingField;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr__MajorDimension_k__BackingField;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr__ValueRenderOption_k__BackingField;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_String_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_String_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_String_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
