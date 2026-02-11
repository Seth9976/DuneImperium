using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000039 RID: 57
	public class CellData : Object
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		// Note: this type is marked as 'beforefieldinit'.
		static CellData()
		{
			Il2CppClassPointerStore<CellData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "CellData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellData>.NativeClassPtr);
			CellData.NativeFieldInfoPtr__DataValidation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<DataValidation>k__BackingField");
			CellData.NativeFieldInfoPtr__EffectiveFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<EffectiveFormat>k__BackingField");
			CellData.NativeFieldInfoPtr__EffectiveValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<EffectiveValue>k__BackingField");
			CellData.NativeFieldInfoPtr__FormattedValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<FormattedValue>k__BackingField");
			CellData.NativeFieldInfoPtr__Hyperlink_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<Hyperlink>k__BackingField");
			CellData.NativeFieldInfoPtr__Note_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<Note>k__BackingField");
			CellData.NativeFieldInfoPtr__PivotTable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<PivotTable>k__BackingField");
			CellData.NativeFieldInfoPtr__TextFormatRuns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<TextFormatRuns>k__BackingField");
			CellData.NativeFieldInfoPtr__UserEnteredFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<UserEnteredFormat>k__BackingField");
			CellData.NativeFieldInfoPtr__UserEnteredValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<UserEnteredValue>k__BackingField");
			CellData.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<ETag>k__BackingField");
			CellData.NativeMethodInfoPtr_get_DataValidation_Public_Virtual_New_get_DataValidationRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664025);
			CellData.NativeMethodInfoPtr_set_DataValidation_Public_Virtual_New_set_Void_DataValidationRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664026);
			CellData.NativeMethodInfoPtr_get_EffectiveFormat_Public_Virtual_New_get_CellFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664027);
			CellData.NativeMethodInfoPtr_set_EffectiveFormat_Public_Virtual_New_set_Void_CellFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664028);
			CellData.NativeMethodInfoPtr_get_EffectiveValue_Public_Virtual_New_get_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664029);
			CellData.NativeMethodInfoPtr_set_EffectiveValue_Public_Virtual_New_set_Void_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664030);
			CellData.NativeMethodInfoPtr_get_FormattedValue_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664031);
			CellData.NativeMethodInfoPtr_set_FormattedValue_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664032);
			CellData.NativeMethodInfoPtr_get_Hyperlink_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664033);
			CellData.NativeMethodInfoPtr_set_Hyperlink_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664034);
			CellData.NativeMethodInfoPtr_get_Note_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664035);
			CellData.NativeMethodInfoPtr_set_Note_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664036);
			CellData.NativeMethodInfoPtr_get_PivotTable_Public_Virtual_New_get_PivotTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664037);
			CellData.NativeMethodInfoPtr_set_PivotTable_Public_Virtual_New_set_Void_PivotTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664038);
			CellData.NativeMethodInfoPtr_get_TextFormatRuns_Public_Virtual_New_get_IList_1_TextFormatRun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664039);
			CellData.NativeMethodInfoPtr_set_TextFormatRuns_Public_Virtual_New_set_Void_IList_1_TextFormatRun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664040);
			CellData.NativeMethodInfoPtr_get_UserEnteredFormat_Public_Virtual_New_get_CellFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664041);
			CellData.NativeMethodInfoPtr_set_UserEnteredFormat_Public_Virtual_New_set_Void_CellFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664042);
			CellData.NativeMethodInfoPtr_get_UserEnteredValue_Public_Virtual_New_get_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664043);
			CellData.NativeMethodInfoPtr_set_UserEnteredValue_Public_Virtual_New_set_Void_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664044);
			CellData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664045);
			CellData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664046);
			CellData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100664047);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001B0A8 File Offset: 0x000192A8
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0001B0F4 File Offset: 0x000192F4
		public unsafe virtual DataValidationRule DataValidation
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_DataValidation_Public_Virtual_New_get_DataValidationRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataValidationRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_DataValidation_Public_Virtual_New_set_Void_DataValidationRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001B144 File Offset: 0x00019344
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0001B190 File Offset: 0x00019390
		public unsafe virtual CellFormat EffectiveFormat
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_EffectiveFormat_Public_Virtual_New_get_CellFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CellFormat>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_EffectiveFormat_Public_Virtual_New_set_Void_CellFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001B1E0 File Offset: 0x000193E0
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0001B22C File Offset: 0x0001942C
		public unsafe virtual ExtendedValue EffectiveValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_EffectiveValue_Public_Virtual_New_get_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_EffectiveValue_Public_Virtual_New_set_Void_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0001B27C File Offset: 0x0001947C
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0001B2C0 File Offset: 0x000194C0
		public unsafe virtual string FormattedValue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_FormattedValue_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_FormattedValue_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001B310 File Offset: 0x00019510
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0001B354 File Offset: 0x00019554
		public unsafe virtual string Hyperlink
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_Hyperlink_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_Hyperlink_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0001B3A4 File Offset: 0x000195A4
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x0001B3E8 File Offset: 0x000195E8
		public unsafe virtual string Note
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_Note_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_Note_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0001B438 File Offset: 0x00019638
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0001B484 File Offset: 0x00019684
		public unsafe virtual PivotTable PivotTable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_PivotTable_Public_Virtual_New_get_PivotTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PivotTable>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_PivotTable_Public_Virtual_New_set_Void_PivotTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001B4D4 File Offset: 0x000196D4
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0001B520 File Offset: 0x00019720
		public unsafe virtual IList<TextFormatRun> TextFormatRuns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_TextFormatRuns_Public_Virtual_New_get_IList_1_TextFormatRun_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TextFormatRun>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_TextFormatRuns_Public_Virtual_New_set_Void_IList_1_TextFormatRun_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001B570 File Offset: 0x00019770
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0001B5BC File Offset: 0x000197BC
		public unsafe virtual CellFormat UserEnteredFormat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_UserEnteredFormat_Public_Virtual_New_get_CellFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CellFormat>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_UserEnteredFormat_Public_Virtual_New_set_Void_CellFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0001B60C File Offset: 0x0001980C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0001B658 File Offset: 0x00019858
		public unsafe virtual ExtendedValue UserEnteredValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_UserEnteredValue_Public_Virtual_New_get_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_UserEnteredValue_Public_Virtual_New_set_Void_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0001B6A8 File Offset: 0x000198A8
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0001B6EC File Offset: 0x000198EC
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CellData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0001B73C File Offset: 0x0001993C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CellData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00003F24 File Offset: 0x00002124
		public CellData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001B778 File Offset: 0x00019978
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00003F2D File Offset: 0x0000212D
		public unsafe DataValidationRule _DataValidation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__DataValidation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataValidationRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__DataValidation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0001B7A8 File Offset: 0x000199A8
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00003F4C File Offset: 0x0000214C
		public unsafe CellFormat _EffectiveFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__EffectiveFormat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CellFormat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__EffectiveFormat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0001B7D8 File Offset: 0x000199D8
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00003F6B File Offset: 0x0000216B
		public unsafe ExtendedValue _EffectiveValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__EffectiveValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__EffectiveValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001B808 File Offset: 0x00019A08
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00003F8A File Offset: 0x0000218A
		public unsafe string _FormattedValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__FormattedValue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__FormattedValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001B830 File Offset: 0x00019A30
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00003FA9 File Offset: 0x000021A9
		public unsafe string _Hyperlink_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__Hyperlink_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__Hyperlink_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001B858 File Offset: 0x00019A58
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003FC8 File Offset: 0x000021C8
		public unsafe string _Note_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__Note_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__Note_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001B880 File Offset: 0x00019A80
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00003FE7 File Offset: 0x000021E7
		public unsafe PivotTable _PivotTable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__PivotTable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PivotTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__PivotTable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00004006 File Offset: 0x00002206
		public unsafe IList<TextFormatRun> _TextFormatRuns_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__TextFormatRuns_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<TextFormatRun>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__TextFormatRuns_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0001B8E0 File Offset: 0x00019AE0
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00004025 File Offset: 0x00002225
		public unsafe CellFormat _UserEnteredFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__UserEnteredFormat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CellFormat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__UserEnteredFormat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0001B910 File Offset: 0x00019B10
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00004044 File Offset: 0x00002244
		public unsafe ExtendedValue _UserEnteredValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__UserEnteredValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__UserEnteredValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0001B940 File Offset: 0x00019B40
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00004063 File Offset: 0x00002263
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CellData.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr__DataValidation_k__BackingField;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr__EffectiveFormat_k__BackingField;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr__EffectiveValue_k__BackingField;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr__FormattedValue_k__BackingField;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr__Hyperlink_k__BackingField;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr__Note_k__BackingField;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr__PivotTable_k__BackingField;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr__TextFormatRuns_k__BackingField;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr__UserEnteredFormat_k__BackingField;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr__UserEnteredValue_k__BackingField;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_get_DataValidation_Public_Virtual_New_get_DataValidationRule_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_set_DataValidation_Public_Virtual_New_set_Void_DataValidationRule_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveFormat_Public_Virtual_New_get_CellFormat_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_set_EffectiveFormat_Public_Virtual_New_set_Void_CellFormat_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveValue_Public_Virtual_New_get_ExtendedValue_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_set_EffectiveValue_Public_Virtual_New_set_Void_ExtendedValue_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_FormattedValue_Public_Virtual_New_get_String_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_set_FormattedValue_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_get_Hyperlink_Public_Virtual_New_get_String_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_set_Hyperlink_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_get_Note_Public_Virtual_New_get_String_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_set_Note_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotTable_Public_Virtual_New_get_PivotTable_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotTable_Public_Virtual_New_set_Void_PivotTable_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_get_TextFormatRuns_Public_Virtual_New_get_IList_1_TextFormatRun_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_set_TextFormatRuns_Public_Virtual_New_set_Void_IList_1_TextFormatRun_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_UserEnteredFormat_Public_Virtual_New_get_CellFormat_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_set_UserEnteredFormat_Public_Virtual_New_set_Void_CellFormat_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_UserEnteredValue_Public_Virtual_New_get_ExtendedValue_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_set_UserEnteredValue_Public_Virtual_New_set_Void_ExtendedValue_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
