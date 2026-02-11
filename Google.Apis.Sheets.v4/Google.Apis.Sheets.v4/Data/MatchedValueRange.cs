using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000085 RID: 133
	public class MatchedValueRange : Object
	{
		// Token: 0x060009EA RID: 2538 RVA: 0x00030B18 File Offset: 0x0002ED18
		// Note: this type is marked as 'beforefieldinit'.
		static MatchedValueRange()
		{
			Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "MatchedValueRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr);
			MatchedValueRange.NativeFieldInfoPtr__DataFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, "<DataFilters>k__BackingField");
			MatchedValueRange.NativeFieldInfoPtr__ValueRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, "<ValueRange>k__BackingField");
			MatchedValueRange.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, "<ETag>k__BackingField");
			MatchedValueRange.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, 100664723);
			MatchedValueRange.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, 100664724);
			MatchedValueRange.NativeMethodInfoPtr_get_ValueRange_Public_Virtual_New_get_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, 100664725);
			MatchedValueRange.NativeMethodInfoPtr_set_ValueRange_Public_Virtual_New_set_Void_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, 100664726);
			MatchedValueRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, 100664727);
			MatchedValueRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, 100664728);
			MatchedValueRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr, 100664729);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00030C10 File Offset: 0x0002EE10
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00030C5C File Offset: 0x0002EE5C
		public unsafe virtual IList<DataFilter> DataFilters
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchedValueRange.NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchedValueRange.NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00030CAC File Offset: 0x0002EEAC
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00030CF8 File Offset: 0x0002EEF8
		public unsafe virtual ValueRange ValueRange
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchedValueRange.NativeMethodInfoPtr_get_ValueRange_Public_Virtual_New_get_ValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchedValueRange.NativeMethodInfoPtr_set_ValueRange_Public_Virtual_New_set_Void_ValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00030D48 File Offset: 0x0002EF48
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00030D8C File Offset: 0x0002EF8C
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchedValueRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchedValueRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00030DDC File Offset: 0x0002EFDC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchedValueRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchedValueRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchedValueRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00006C29 File Offset: 0x00004E29
		public MatchedValueRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00030E18 File Offset: 0x0002F018
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00006C32 File Offset: 0x00004E32
		public unsafe IList<DataFilter> _DataFilters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchedValueRange.NativeFieldInfoPtr__DataFilters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DataFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchedValueRange.NativeFieldInfoPtr__DataFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00030E48 File Offset: 0x0002F048
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00006C51 File Offset: 0x00004E51
		public unsafe ValueRange _ValueRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchedValueRange.NativeFieldInfoPtr__ValueRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchedValueRange.NativeFieldInfoPtr__ValueRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00030E78 File Offset: 0x0002F078
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00006C70 File Offset: 0x00004E70
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchedValueRange.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchedValueRange.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr__DataFilters_k__BackingField;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr__ValueRange_k__BackingField;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_get_DataFilters_Public_Virtual_New_get_IList_1_DataFilter_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_set_DataFilters_Public_Virtual_New_set_Void_IList_1_DataFilter_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueRange_Public_Virtual_New_get_ValueRange_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueRange_Public_Virtual_New_set_Void_ValueRange_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
