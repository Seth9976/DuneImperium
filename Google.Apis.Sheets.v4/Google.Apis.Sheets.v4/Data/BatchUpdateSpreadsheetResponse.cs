using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200002B RID: 43
	public class BatchUpdateSpreadsheetResponse : Object
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00015E6C File Offset: 0x0001406C
		// Note: this type is marked as 'beforefieldinit'.
		static BatchUpdateSpreadsheetResponse()
		{
			Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchUpdateSpreadsheetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr);
			BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__Replies_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, "<Replies>k__BackingField");
			BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
			BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__UpdatedSpreadsheet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, "<UpdatedSpreadsheet>k__BackingField");
			BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, "<ETag>k__BackingField");
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_Replies_Public_Virtual_New_get_IList_1_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663867);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_Replies_Public_Virtual_New_set_Void_IList_1_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663868);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663869);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663870);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_UpdatedSpreadsheet_Public_Virtual_New_get_Spreadsheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663871);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_UpdatedSpreadsheet_Public_Virtual_New_set_Void_Spreadsheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663872);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663873);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663874);
			BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr, 100663875);
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00015FA0 File Offset: 0x000141A0
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00015FEC File Offset: 0x000141EC
		public unsafe virtual IList<Response> Replies
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_Replies_Public_Virtual_New_get_IList_1_Response_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Response>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_Replies_Public_Virtual_New_set_Void_IList_1_Response_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0001603C File Offset: 0x0001423C
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00016080 File Offset: 0x00014280
		public unsafe virtual string SpreadsheetId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000160D0 File Offset: 0x000142D0
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0001611C File Offset: 0x0001431C
		public unsafe virtual Spreadsheet UpdatedSpreadsheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_UpdatedSpreadsheet_Public_Virtual_New_get_Spreadsheet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Spreadsheet>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_UpdatedSpreadsheet_Public_Virtual_New_set_Void_Spreadsheet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0001616C File Offset: 0x0001436C
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000161B0 File Offset: 0x000143B0
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00016200 File Offset: 0x00014400
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchUpdateSpreadsheetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchUpdateSpreadsheetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchUpdateSpreadsheetResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000350D File Offset: 0x0000170D
		public BatchUpdateSpreadsheetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0001623C File Offset: 0x0001443C
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00003516 File Offset: 0x00001716
		public unsafe IList<Response> _Replies_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__Replies_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Response>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__Replies_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0001626C File Offset: 0x0001446C
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00003535 File Offset: 0x00001735
		public unsafe string _SpreadsheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00016294 File Offset: 0x00014494
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00003554 File Offset: 0x00001754
		public unsafe Spreadsheet _UpdatedSpreadsheet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__UpdatedSpreadsheet_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spreadsheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__UpdatedSpreadsheet_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000162C4 File Offset: 0x000144C4
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003573 File Offset: 0x00001773
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr__Replies_k__BackingField;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr__UpdatedSpreadsheet_k__BackingField;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_get_Replies_Public_Virtual_New_get_IList_1_Response_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_set_Replies_Public_Virtual_New_set_Void_IList_1_Response_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdatedSpreadsheet_Public_Virtual_New_get_Spreadsheet_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdatedSpreadsheet_Public_Virtual_New_set_Void_Spreadsheet_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
