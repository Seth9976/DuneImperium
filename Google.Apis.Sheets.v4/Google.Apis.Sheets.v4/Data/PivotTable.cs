using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000094 RID: 148
	public class PivotTable : Object
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x000357CC File Offset: 0x000339CC
		// Note: this type is marked as 'beforefieldinit'.
		static PivotTable()
		{
			Il2CppClassPointerStore<PivotTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PivotTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotTable>.NativeClassPtr);
			PivotTable.NativeFieldInfoPtr__Columns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, "<Columns>k__BackingField");
			PivotTable.NativeFieldInfoPtr__Criteria_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, "<Criteria>k__BackingField");
			PivotTable.NativeFieldInfoPtr__Rows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, "<Rows>k__BackingField");
			PivotTable.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, "<Source>k__BackingField");
			PivotTable.NativeFieldInfoPtr__ValueLayout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, "<ValueLayout>k__BackingField");
			PivotTable.NativeFieldInfoPtr__Values_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, "<Values>k__BackingField");
			PivotTable.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, "<ETag>k__BackingField");
			PivotTable.NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_IList_1_PivotGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664876);
			PivotTable.NativeMethodInfoPtr_set_Columns_Public_Virtual_New_set_Void_IList_1_PivotGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664877);
			PivotTable.NativeMethodInfoPtr_get_Criteria_Public_Virtual_New_get_IDictionary_2_String_PivotFilterCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664878);
			PivotTable.NativeMethodInfoPtr_set_Criteria_Public_Virtual_New_set_Void_IDictionary_2_String_PivotFilterCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664879);
			PivotTable.NativeMethodInfoPtr_get_Rows_Public_Virtual_New_get_IList_1_PivotGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664880);
			PivotTable.NativeMethodInfoPtr_set_Rows_Public_Virtual_New_set_Void_IList_1_PivotGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664881);
			PivotTable.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664882);
			PivotTable.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664883);
			PivotTable.NativeMethodInfoPtr_get_ValueLayout_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664884);
			PivotTable.NativeMethodInfoPtr_set_ValueLayout_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664885);
			PivotTable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_PivotValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664886);
			PivotTable.NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_PivotValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664887);
			PivotTable.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664888);
			PivotTable.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664889);
			PivotTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotTable>.NativeClassPtr, 100664890);
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x000359B4 File Offset: 0x00033BB4
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00035A00 File Offset: 0x00033C00
		public unsafe virtual IList<PivotGroup> Columns
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_IList_1_PivotGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PivotGroup>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_set_Columns_Public_Virtual_New_set_Void_IList_1_PivotGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00035A50 File Offset: 0x00033C50
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00035A9C File Offset: 0x00033C9C
		public unsafe virtual IDictionary<string, PivotFilterCriteria> Criteria
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_get_Criteria_Public_Virtual_New_get_IDictionary_2_String_PivotFilterCriteria_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, PivotFilterCriteria>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_set_Criteria_Public_Virtual_New_set_Void_IDictionary_2_String_PivotFilterCriteria_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00035AEC File Offset: 0x00033CEC
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00035B38 File Offset: 0x00033D38
		public unsafe virtual IList<PivotGroup> Rows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_get_Rows_Public_Virtual_New_get_IList_1_PivotGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PivotGroup>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_set_Rows_Public_Virtual_New_set_Void_IList_1_PivotGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00035B88 File Offset: 0x00033D88
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00035BD4 File Offset: 0x00033DD4
		public unsafe virtual GridRange Source
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00035C24 File Offset: 0x00033E24
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00035C68 File Offset: 0x00033E68
		public unsafe virtual string ValueLayout
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_get_ValueLayout_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_set_ValueLayout_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00035CB8 File Offset: 0x00033EB8
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00035D04 File Offset: 0x00033F04
		public unsafe virtual IList<PivotValue> Values
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_PivotValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PivotValue>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_PivotValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00035D54 File Offset: 0x00033F54
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00035D98 File Offset: 0x00033F98
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotTable.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00035DE8 File Offset: 0x00033FE8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0000760A File Offset: 0x0000580A
		public PivotTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00035E24 File Offset: 0x00034024
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00007613 File Offset: 0x00005813
		public unsafe IList<PivotGroup> _Columns_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Columns_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<PivotGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Columns_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x00035E54 File Offset: 0x00034054
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00007632 File Offset: 0x00005832
		public unsafe IDictionary<string, PivotFilterCriteria> _Criteria_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Criteria_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, PivotFilterCriteria>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Criteria_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00035E84 File Offset: 0x00034084
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00007651 File Offset: 0x00005851
		public unsafe IList<PivotGroup> _Rows_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Rows_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<PivotGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Rows_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00035EB4 File Offset: 0x000340B4
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00007670 File Offset: 0x00005870
		public unsafe GridRange _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00035EE4 File Offset: 0x000340E4
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x0000768F File Offset: 0x0000588F
		public unsafe string _ValueLayout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__ValueLayout_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__ValueLayout_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00035F0C File Offset: 0x0003410C
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x000076AE File Offset: 0x000058AE
		public unsafe IList<PivotValue> _Values_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Values_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<PivotValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__Values_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00035F3C File Offset: 0x0003413C
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x000076CD File Offset: 0x000058CD
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotTable.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr__Columns_k__BackingField;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr__Criteria_k__BackingField;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr__Rows_k__BackingField;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeFieldInfoPtr__ValueLayout_k__BackingField;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeFieldInfoPtr__Values_k__BackingField;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_IList_1_PivotGroup_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_set_Columns_Public_Virtual_New_set_Void_IList_1_PivotGroup_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_get_Criteria_Public_Virtual_New_get_IDictionary_2_String_PivotFilterCriteria_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_set_Criteria_Public_Virtual_New_set_Void_IDictionary_2_String_PivotFilterCriteria_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_get_Rows_Public_Virtual_New_get_IList_1_PivotGroup_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_set_Rows_Public_Virtual_New_set_Void_IList_1_PivotGroup_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLayout_Public_Virtual_New_get_String_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueLayout_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_PivotValue_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_PivotValue_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
