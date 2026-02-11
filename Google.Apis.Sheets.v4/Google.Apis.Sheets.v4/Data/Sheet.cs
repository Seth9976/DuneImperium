using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000A1 RID: 161
	public class Sheet : Object
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x0003E2E8 File Offset: 0x0003C4E8
		// Note: this type is marked as 'beforefieldinit'.
		static Sheet()
		{
			Il2CppClassPointerStore<Sheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "Sheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sheet>.NativeClassPtr);
			Sheet.NativeFieldInfoPtr__BandedRanges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<BandedRanges>k__BackingField");
			Sheet.NativeFieldInfoPtr__BasicFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<BasicFilter>k__BackingField");
			Sheet.NativeFieldInfoPtr__Charts_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<Charts>k__BackingField");
			Sheet.NativeFieldInfoPtr__ColumnGroups_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<ColumnGroups>k__BackingField");
			Sheet.NativeFieldInfoPtr__ConditionalFormats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<ConditionalFormats>k__BackingField");
			Sheet.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<Data>k__BackingField");
			Sheet.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<DeveloperMetadata>k__BackingField");
			Sheet.NativeFieldInfoPtr__FilterViews_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<FilterViews>k__BackingField");
			Sheet.NativeFieldInfoPtr__Merges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<Merges>k__BackingField");
			Sheet.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<Properties>k__BackingField");
			Sheet.NativeFieldInfoPtr__ProtectedRanges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<ProtectedRanges>k__BackingField");
			Sheet.NativeFieldInfoPtr__RowGroups_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<RowGroups>k__BackingField");
			Sheet.NativeFieldInfoPtr__Slicers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<Slicers>k__BackingField");
			Sheet.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sheet>.NativeClassPtr, "<ETag>k__BackingField");
			Sheet.NativeMethodInfoPtr_get_BandedRanges_Public_Virtual_New_get_IList_1_BandedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665149);
			Sheet.NativeMethodInfoPtr_set_BandedRanges_Public_Virtual_New_set_Void_IList_1_BandedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665150);
			Sheet.NativeMethodInfoPtr_get_BasicFilter_Public_Virtual_New_get_BasicFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665151);
			Sheet.NativeMethodInfoPtr_set_BasicFilter_Public_Virtual_New_set_Void_BasicFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665152);
			Sheet.NativeMethodInfoPtr_get_Charts_Public_Virtual_New_get_IList_1_EmbeddedChart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665153);
			Sheet.NativeMethodInfoPtr_set_Charts_Public_Virtual_New_set_Void_IList_1_EmbeddedChart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665154);
			Sheet.NativeMethodInfoPtr_get_ColumnGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665155);
			Sheet.NativeMethodInfoPtr_set_ColumnGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665156);
			Sheet.NativeMethodInfoPtr_get_ConditionalFormats_Public_Virtual_New_get_IList_1_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665157);
			Sheet.NativeMethodInfoPtr_set_ConditionalFormats_Public_Virtual_New_set_Void_IList_1_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665158);
			Sheet.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_GridData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665159);
			Sheet.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_GridData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665160);
			Sheet.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665161);
			Sheet.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665162);
			Sheet.NativeMethodInfoPtr_get_FilterViews_Public_Virtual_New_get_IList_1_FilterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665163);
			Sheet.NativeMethodInfoPtr_set_FilterViews_Public_Virtual_New_set_Void_IList_1_FilterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665164);
			Sheet.NativeMethodInfoPtr_get_Merges_Public_Virtual_New_get_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665165);
			Sheet.NativeMethodInfoPtr_set_Merges_Public_Virtual_New_set_Void_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665166);
			Sheet.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665167);
			Sheet.NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665168);
			Sheet.NativeMethodInfoPtr_get_ProtectedRanges_Public_Virtual_New_get_IList_1_ProtectedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665169);
			Sheet.NativeMethodInfoPtr_set_ProtectedRanges_Public_Virtual_New_set_Void_IList_1_ProtectedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665170);
			Sheet.NativeMethodInfoPtr_get_RowGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665171);
			Sheet.NativeMethodInfoPtr_set_RowGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665172);
			Sheet.NativeMethodInfoPtr_get_Slicers_Public_Virtual_New_get_IList_1_Slicer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665173);
			Sheet.NativeMethodInfoPtr_set_Slicers_Public_Virtual_New_set_Void_IList_1_Slicer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665174);
			Sheet.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665175);
			Sheet.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665176);
			Sheet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sheet>.NativeClassPtr, 100665177);
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0003E674 File Offset: 0x0003C874
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x0003E6C0 File Offset: 0x0003C8C0
		public unsafe virtual IList<BandedRange> BandedRanges
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_BandedRanges_Public_Virtual_New_get_IList_1_BandedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<BandedRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_BandedRanges_Public_Virtual_New_set_Void_IList_1_BandedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0003E710 File Offset: 0x0003C910
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x0003E75C File Offset: 0x0003C95C
		public unsafe virtual BasicFilter BasicFilter
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_BasicFilter_Public_Virtual_New_get_BasicFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicFilter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_BasicFilter_Public_Virtual_New_set_Void_BasicFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0003E7AC File Offset: 0x0003C9AC
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x0003E7F8 File Offset: 0x0003C9F8
		public unsafe virtual IList<EmbeddedChart> Charts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_Charts_Public_Virtual_New_get_IList_1_EmbeddedChart_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EmbeddedChart>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_Charts_Public_Virtual_New_set_Void_IList_1_EmbeddedChart_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0003E848 File Offset: 0x0003CA48
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x0003E894 File Offset: 0x0003CA94
		public unsafe virtual IList<DimensionGroup> ColumnGroups
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_ColumnGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_ColumnGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0003E8E4 File Offset: 0x0003CAE4
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x0003E930 File Offset: 0x0003CB30
		public unsafe virtual IList<ConditionalFormatRule> ConditionalFormats
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_ConditionalFormats_Public_Virtual_New_get_IList_1_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ConditionalFormatRule>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_ConditionalFormats_Public_Virtual_New_set_Void_IList_1_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0003E980 File Offset: 0x0003CB80
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x0003E9CC File Offset: 0x0003CBCC
		public unsafe virtual IList<GridData> Data
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_GridData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<GridData>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_GridData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x0003EA68 File Offset: 0x0003CC68
		public unsafe virtual IList<DeveloperMetadata> DeveloperMetadata
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DeveloperMetadata>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0003EAB8 File Offset: 0x0003CCB8
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x0003EB04 File Offset: 0x0003CD04
		public unsafe virtual IList<FilterView> FilterViews
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_FilterViews_Public_Virtual_New_get_IList_1_FilterView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<FilterView>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_FilterViews_Public_Virtual_New_set_Void_IList_1_FilterView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0003EB54 File Offset: 0x0003CD54
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x0003EBA0 File Offset: 0x0003CDA0
		public unsafe virtual IList<GridRange> Merges
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_Merges_Public_Virtual_New_get_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_Merges_Public_Virtual_New_set_Void_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0003EBF0 File Offset: 0x0003CDF0
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x0003EC3C File Offset: 0x0003CE3C
		public unsafe virtual SheetProperties Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SheetProperties>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0003EC8C File Offset: 0x0003CE8C
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x0003ECD8 File Offset: 0x0003CED8
		public unsafe virtual IList<ProtectedRange> ProtectedRanges
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_ProtectedRanges_Public_Virtual_New_get_IList_1_ProtectedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ProtectedRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_ProtectedRanges_Public_Virtual_New_set_Void_IList_1_ProtectedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0003ED28 File Offset: 0x0003CF28
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x0003ED74 File Offset: 0x0003CF74
		public unsafe virtual IList<DimensionGroup> RowGroups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_RowGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_RowGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0003EDC4 File Offset: 0x0003CFC4
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x0003EE10 File Offset: 0x0003D010
		public unsafe virtual IList<Slicer> Slicers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_Slicers_Public_Virtual_New_get_IList_1_Slicer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Slicer>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_Slicers_Public_Virtual_New_set_Void_IList_1_Slicer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0003EE60 File Offset: 0x0003D060
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x0003EEA4 File Offset: 0x0003D0A4
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sheet.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0003EEF4 File Offset: 0x0003D0F4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sheet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sheet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sheet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00008688 File Offset: 0x00006888
		public Sheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0003EF30 File Offset: 0x0003D130
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00008691 File Offset: 0x00006891
		public unsafe IList<BandedRange> _BandedRanges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__BandedRanges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<BandedRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__BandedRanges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x0003EF60 File Offset: 0x0003D160
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x000086B0 File Offset: 0x000068B0
		public unsafe BasicFilter _BasicFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__BasicFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__BasicFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0003EF90 File Offset: 0x0003D190
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x000086CF File Offset: 0x000068CF
		public unsafe IList<EmbeddedChart> _Charts_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Charts_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EmbeddedChart>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Charts_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0003EFC0 File Offset: 0x0003D1C0
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x000086EE File Offset: 0x000068EE
		public unsafe IList<DimensionGroup> _ColumnGroups_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ColumnGroups_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ColumnGroups_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0003EFF0 File Offset: 0x0003D1F0
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x0000870D File Offset: 0x0000690D
		public unsafe IList<ConditionalFormatRule> _ConditionalFormats_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ConditionalFormats_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ConditionalFormatRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ConditionalFormats_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0003F020 File Offset: 0x0003D220
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x0000872C File Offset: 0x0000692C
		public unsafe IList<GridData> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<GridData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0003F050 File Offset: 0x0003D250
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0000874B File Offset: 0x0000694B
		public unsafe IList<DeveloperMetadata> _DeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DeveloperMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0003F080 File Offset: 0x0003D280
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x0000876A File Offset: 0x0000696A
		public unsafe IList<FilterView> _FilterViews_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__FilterViews_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<FilterView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__FilterViews_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x0003F0B0 File Offset: 0x0003D2B0
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00008789 File Offset: 0x00006989
		public unsafe IList<GridRange> _Merges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Merges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Merges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x0003F0E0 File Offset: 0x0003D2E0
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x000087A8 File Offset: 0x000069A8
		public unsafe SheetProperties _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetProperties>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0003F110 File Offset: 0x0003D310
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x000087C7 File Offset: 0x000069C7
		public unsafe IList<ProtectedRange> _ProtectedRanges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ProtectedRanges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ProtectedRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ProtectedRanges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0003F140 File Offset: 0x0003D340
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x000087E6 File Offset: 0x000069E6
		public unsafe IList<DimensionGroup> _RowGroups_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__RowGroups_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__RowGroups_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0003F170 File Offset: 0x0003D370
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x00008805 File Offset: 0x00006A05
		public unsafe IList<Slicer> _Slicers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Slicers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Slicer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__Slicers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0003F1A0 File Offset: 0x0003D3A0
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00008824 File Offset: 0x00006A24
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sheet.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr__BandedRanges_k__BackingField;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr__BasicFilter_k__BackingField;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr__Charts_k__BackingField;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr__ColumnGroups_k__BackingField;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr__ConditionalFormats_k__BackingField;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr__DeveloperMetadata_k__BackingField;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr__FilterViews_k__BackingField;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr__Merges_k__BackingField;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr__ProtectedRanges_k__BackingField;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr__RowGroups_k__BackingField;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr__Slicers_k__BackingField;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_get_BandedRanges_Public_Virtual_New_get_IList_1_BandedRange_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_set_BandedRanges_Public_Virtual_New_set_Void_IList_1_BandedRange_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_get_BasicFilter_Public_Virtual_New_get_BasicFilter_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_set_BasicFilter_Public_Virtual_New_set_Void_BasicFilter_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_get_Charts_Public_Virtual_New_get_IList_1_EmbeddedChart_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_set_Charts_Public_Virtual_New_set_Void_IList_1_EmbeddedChart_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_set_ColumnGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_get_ConditionalFormats_Public_Virtual_New_get_IList_1_ConditionalFormatRule_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_set_ConditionalFormats_Public_Virtual_New_set_Void_IList_1_ConditionalFormatRule_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_GridData_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_GridData_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterViews_Public_Virtual_New_get_IList_1_FilterView_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_set_FilterViews_Public_Virtual_New_set_Void_IList_1_FilterView_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_get_Merges_Public_Virtual_New_get_IList_1_GridRange_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_set_Merges_Public_Virtual_New_set_Void_IList_1_GridRange_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtectedRanges_Public_Virtual_New_get_IList_1_ProtectedRange_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtectedRanges_Public_Virtual_New_set_Void_IList_1_ProtectedRange_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_get_RowGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_set_RowGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_get_Slicers_Public_Virtual_New_get_IList_1_Slicer_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_set_Slicers_Public_Virtual_New_set_Void_IList_1_Slicer_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
