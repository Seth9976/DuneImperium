using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000028 RID: 40
	public class BatchGetValuesByDataFilterResponse : Object
	{
		// Token: 0x060002AB RID: 683 RVA: 0x000151EC File Offset: 0x000133EC
		// Note: this type is marked as 'beforefieldinit'.
		static BatchGetValuesByDataFilterResponse()
		{
			Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchGetValuesByDataFilterResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr);
			BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
			BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__ValueRanges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, "<ValueRanges>k__BackingField");
			BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, "<ETag>k__BackingField");
			BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, 100663842);
			BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, 100663843);
			BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_get_ValueRanges_Public_Virtual_New_get_IList_1_MatchedValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, 100663844);
			BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_set_ValueRanges_Public_Virtual_New_set_Void_IList_1_MatchedValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, 100663845);
			BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, 100663846);
			BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, 100663847);
			BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr, 100663848);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000152E4 File Offset: 0x000134E4
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00015328 File Offset: 0x00013528
		public unsafe virtual string SpreadsheetId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00015378 File Offset: 0x00013578
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000153C4 File Offset: 0x000135C4
		public unsafe virtual IList<MatchedValueRange> ValueRanges
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_get_ValueRanges_Public_Virtual_New_get_IList_1_MatchedValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<MatchedValueRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_set_ValueRanges_Public_Virtual_New_set_Void_IList_1_MatchedValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00015414 File Offset: 0x00013614
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00015458 File Offset: 0x00013658
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000154A8 File Offset: 0x000136A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchGetValuesByDataFilterResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchGetValuesByDataFilterResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchGetValuesByDataFilterResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000337F File Offset: 0x0000157F
		public BatchGetValuesByDataFilterResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000154E4 File Offset: 0x000136E4
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00003388 File Offset: 0x00001588
		public unsafe string _SpreadsheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001550C File Offset: 0x0001370C
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x000033A7 File Offset: 0x000015A7
		public unsafe IList<MatchedValueRange> _ValueRanges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__ValueRanges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<MatchedValueRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__ValueRanges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0001553C File Offset: 0x0001373C
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x000033C6 File Offset: 0x000015C6
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchGetValuesByDataFilterResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr__ValueRanges_k__BackingField;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueRanges_Public_Virtual_New_get_IList_1_MatchedValueRange_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueRanges_Public_Virtual_New_set_Void_IList_1_MatchedValueRange_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
