using System;
using Google.Apis.Services;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4
{
	// Token: 0x02000004 RID: 4
	public class SpreadsheetsResource : Object
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000C034 File Offset: 0x0000A234
		// Note: this type is marked as 'beforefieldinit'.
		static SpreadsheetsResource()
		{
			Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4", "SpreadsheetsResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr);
			SpreadsheetsResource.NativeFieldInfoPtr_Resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "Resource");
			SpreadsheetsResource.NativeFieldInfoPtr_service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "service");
			SpreadsheetsResource.NativeFieldInfoPtr_developerMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "developerMetadata");
			SpreadsheetsResource.NativeFieldInfoPtr_sheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "sheets");
			SpreadsheetsResource.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "values");
			SpreadsheetsResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663333);
			SpreadsheetsResource.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadataResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663334);
			SpreadsheetsResource.NativeMethodInfoPtr_get_Sheets_Public_Virtual_New_get_SheetsResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663335);
			SpreadsheetsResource.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ValuesResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663336);
			SpreadsheetsResource.NativeMethodInfoPtr_BatchUpdate_Public_Virtual_New_BatchUpdateRequest_BatchUpdateSpreadsheetRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663337);
			SpreadsheetsResource.NativeMethodInfoPtr_Create_Public_Virtual_New_CreateRequest_Spreadsheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663338);
			SpreadsheetsResource.NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663339);
			SpreadsheetsResource.NativeMethodInfoPtr_GetByDataFilter_Public_Virtual_New_GetByDataFilterRequest_GetSpreadsheetByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, 100663340);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000C168 File Offset: 0x0000A368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118871, XrefRangeEnd = 1118891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpreadsheetsResource(IClientService service)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		public unsafe virtual SpreadsheetsResource.DeveloperMetadataResource DeveloperMetadata
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadataResource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.DeveloperMetadataResource>(intPtr3) : null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000C200 File Offset: 0x0000A400
		public unsafe virtual SpreadsheetsResource.SheetsResource Sheets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.NativeMethodInfoPtr_get_Sheets_Public_Virtual_New_get_SheetsResource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.SheetsResource>(intPtr3) : null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000C24C File Offset: 0x0000A44C
		public unsafe virtual SpreadsheetsResource.ValuesResource Values
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ValuesResource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource>(intPtr3) : null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000C298 File Offset: 0x0000A498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118891, XrefRangeEnd = 1118899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SpreadsheetsResource.BatchUpdateRequest BatchUpdate(BatchUpdateSpreadsheetRequest body, string spreadsheetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.NativeMethodInfoPtr_BatchUpdate_Public_Virtual_New_BatchUpdateRequest_BatchUpdateSpreadsheetRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.BatchUpdateRequest>(intPtr3) : null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000C308 File Offset: 0x0000A508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118899, XrefRangeEnd = 1118906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SpreadsheetsResource.CreateRequest Create(Spreadsheet body)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.NativeMethodInfoPtr_Create_Public_Virtual_New_CreateRequest_Spreadsheet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.CreateRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000C364 File Offset: 0x0000A564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118906, XrefRangeEnd = 1118913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SpreadsheetsResource.GetRequest Get(string spreadsheetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.GetRequest>(intPtr3) : null;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118913, XrefRangeEnd = 1118921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SpreadsheetsResource.GetByDataFilterRequest GetByDataFilter(GetSpreadsheetByDataFilterRequest body, string spreadsheetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.NativeMethodInfoPtr_GetByDataFilter_Public_Virtual_New_GetByDataFilterRequest_GetSpreadsheetByDataFilterRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.GetByDataFilterRequest>(intPtr3) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002223 File Offset: 0x00000423
		public SpreadsheetsResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000C430 File Offset: 0x0000A630
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000222C File Offset: 0x0000042C
		public unsafe static string Resource
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpreadsheetsResource.NativeFieldInfoPtr_Resource, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpreadsheetsResource.NativeFieldInfoPtr_Resource, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000C450 File Offset: 0x0000A650
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000223E File Offset: 0x0000043E
		public unsafe IClientService service
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_service);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_service), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000C480 File Offset: 0x0000A680
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000225D File Offset: 0x0000045D
		public unsafe SpreadsheetsResource.DeveloperMetadataResource developerMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_developerMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.DeveloperMetadataResource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_developerMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000227C File Offset: 0x0000047C
		public unsafe SpreadsheetsResource.SheetsResource sheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_sheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.SheetsResource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_sheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000229B File Offset: 0x0000049B
		public unsafe SpreadsheetsResource.ValuesResource values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_Resource;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_service;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_developerMetadata;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_sheets;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadataResource_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_Sheets_Public_Virtual_New_get_SheetsResource_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ValuesResource_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_BatchUpdate_Public_Virtual_New_BatchUpdateRequest_BatchUpdateSpreadsheetRequest_String_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_CreateRequest_Spreadsheet_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetByDataFilter_Public_Virtual_New_GetByDataFilterRequest_GetSpreadsheetByDataFilterRequest_String_0;

		// Token: 0x020000D4 RID: 212
		public class DeveloperMetadataResource : Object
		{
			// Token: 0x060011A4 RID: 4516 RVA: 0x0004E824 File Offset: 0x0004CA24
			// Note: this type is marked as 'beforefieldinit'.
			static DeveloperMetadataResource()
			{
				Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "DeveloperMetadataResource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr);
				SpreadsheetsResource.DeveloperMetadataResource.NativeFieldInfoPtr_Resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr, "Resource");
				SpreadsheetsResource.DeveloperMetadataResource.NativeFieldInfoPtr_service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr, "service");
				SpreadsheetsResource.DeveloperMetadataResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr, 100663341);
				SpreadsheetsResource.DeveloperMetadataResource.NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr, 100663342);
				SpreadsheetsResource.DeveloperMetadataResource.NativeMethodInfoPtr_Search_Public_Virtual_New_SearchRequest_SearchDeveloperMetadataRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr, 100663343);
			}

			// Token: 0x060011A5 RID: 4517 RVA: 0x0004E8B4 File Offset: 0x0004CAB4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeveloperMetadataResource(IClientService service)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011A6 RID: 4518 RVA: 0x0004E900 File Offset: 0x0004CB00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118014, XrefRangeEnd = 1118021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.DeveloperMetadataResource.GetRequest Get(string spreadsheetId, int metadataId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metadataId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>(intPtr3) : null;
			}

			// Token: 0x060011A7 RID: 4519 RVA: 0x0004E96C File Offset: 0x0004CB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118021, XrefRangeEnd = 1118029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.DeveloperMetadataResource.SearchRequest Search(SearchDeveloperMetadataRequest body, string spreadsheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.NativeMethodInfoPtr_Search_Public_Virtual_New_SearchRequest_SearchDeveloperMetadataRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>(intPtr3) : null;
			}

			// Token: 0x060011A8 RID: 4520 RVA: 0x0000A7B1 File Offset: 0x000089B1
			public DeveloperMetadataResource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0004E9DC File Offset: 0x0004CBDC
			// (set) Token: 0x060011AA RID: 4522 RVA: 0x0000A7BA File Offset: 0x000089BA
			public unsafe static string Resource
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpreadsheetsResource.DeveloperMetadataResource.NativeFieldInfoPtr_Resource, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpreadsheetsResource.DeveloperMetadataResource.NativeFieldInfoPtr_Resource, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x060011AB RID: 4523 RVA: 0x0004E9FC File Offset: 0x0004CBFC
			// (set) Token: 0x060011AC RID: 4524 RVA: 0x0000A7CC File Offset: 0x000089CC
			public unsafe IClientService service
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.NativeFieldInfoPtr_service);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.NativeFieldInfoPtr_service), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C39 RID: 3129
			private static readonly IntPtr NativeFieldInfoPtr_Resource;

			// Token: 0x04000C3A RID: 3130
			private static readonly IntPtr NativeFieldInfoPtr_service;

			// Token: 0x04000C3B RID: 3131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_0;

			// Token: 0x04000C3C RID: 3132
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_Int32_0;

			// Token: 0x04000C3D RID: 3133
			private static readonly IntPtr NativeMethodInfoPtr_Search_Public_Virtual_New_SearchRequest_SearchDeveloperMetadataRequest_String_0;

			// Token: 0x020000DB RID: 219
			public class GetRequest : SheetsBaseServiceRequest<DeveloperMetadata>
			{
				// Token: 0x06001205 RID: 4613 RVA: 0x000502C8 File Offset: 0x0004E4C8
				// Note: this type is marked as 'beforefieldinit'.
				static GetRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr, "GetRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeFieldInfoPtr__MetadataId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, "<MetadataId>k__BackingField");
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663344);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663345);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663346);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_MetadataId_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663347);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_set_MetadataId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663348);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663349);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663350);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663351);
					SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr, 100663352);
				}

				// Token: 0x06001206 RID: 4614 RVA: 0x000503D0 File Offset: 0x0004E5D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117940, XrefRangeEnd = 1117944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetRequest(IClientService service, string spreadsheetId, int metadataId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.GetRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metadataId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007C1 RID: 1985
				// (get) Token: 0x06001207 RID: 4615 RVA: 0x0005043C File Offset: 0x0004E63C
				// (set) Token: 0x06001208 RID: 4616 RVA: 0x00050480 File Offset: 0x0004E680
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007C2 RID: 1986
				// (get) Token: 0x06001209 RID: 4617 RVA: 0x000504C4 File Offset: 0x0004E6C4
				// (set) Token: 0x0600120A RID: 4618 RVA: 0x0005050C File Offset: 0x0004E70C
				public unsafe virtual int MetadataId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_MetadataId_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_set_MetadataId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007C3 RID: 1987
				// (get) Token: 0x0600120B RID: 4619 RVA: 0x0005054C File Offset: 0x0004E74C
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117944, XrefRangeEnd = 1117946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007C4 RID: 1988
				// (get) Token: 0x0600120C RID: 4620 RVA: 0x00050590 File Offset: 0x0004E790
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117946, XrefRangeEnd = 1117948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007C5 RID: 1989
				// (get) Token: 0x0600120D RID: 4621 RVA: 0x000505D4 File Offset: 0x0004E7D4
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117948, XrefRangeEnd = 1117950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600120E RID: 4622 RVA: 0x00050618 File Offset: 0x0004E818
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117950, XrefRangeEnd = 1117983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600120F RID: 4623 RVA: 0x0000A98A File Offset: 0x00008B8A
				public GetRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007BF RID: 1983
				// (get) Token: 0x06001210 RID: 4624 RVA: 0x00050654 File Offset: 0x0004E854
				// (set) Token: 0x06001211 RID: 4625 RVA: 0x0000A993 File Offset: 0x00008B93
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007C0 RID: 1984
				// (get) Token: 0x06001212 RID: 4626 RVA: 0x0005067C File Offset: 0x0004E87C
				// (set) Token: 0x06001213 RID: 4627 RVA: 0x0000A9B2 File Offset: 0x00008BB2
				public unsafe int _MetadataId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeFieldInfoPtr__MetadataId_k__BackingField);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.GetRequest.NativeFieldInfoPtr__MetadataId_k__BackingField)) = value;
					}
				}

				// Token: 0x04000C7E RID: 3198
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000C7F RID: 3199
				private static readonly IntPtr NativeFieldInfoPtr__MetadataId_k__BackingField;

				// Token: 0x04000C80 RID: 3200
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_Int32_0;

				// Token: 0x04000C81 RID: 3201
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000C82 RID: 3202
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000C83 RID: 3203
				private static readonly IntPtr NativeMethodInfoPtr_get_MetadataId_Public_Virtual_New_get_Int32_0;

				// Token: 0x04000C84 RID: 3204
				private static readonly IntPtr NativeMethodInfoPtr_set_MetadataId_Private_set_Void_Int32_0;

				// Token: 0x04000C85 RID: 3205
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000C86 RID: 3206
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000C87 RID: 3207
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000C88 RID: 3208
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}

			// Token: 0x020000DC RID: 220
			public class SearchRequest : SheetsBaseServiceRequest<SearchDeveloperMetadataResponse>
			{
				// Token: 0x06001214 RID: 4628 RVA: 0x000506A4 File Offset: 0x0004E8A4
				// Note: this type is marked as 'beforefieldinit'.
				static SearchRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource>.NativeClassPtr, "SearchRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_SearchDeveloperMetadataRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663353);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663354);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663355);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_Body_Private_get_SearchDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663356);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_SearchDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663357);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663358);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663359);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663360);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663361);
					SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr, 100663362);
				}

				// Token: 0x06001215 RID: 4629 RVA: 0x000507C0 File Offset: 0x0004E9C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117983, XrefRangeEnd = 1117988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SearchRequest(IClientService service, SearchDeveloperMetadataRequest body, string spreadsheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.DeveloperMetadataResource.SearchRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_SearchDeveloperMetadataRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007C8 RID: 1992
				// (get) Token: 0x06001216 RID: 4630 RVA: 0x00050830 File Offset: 0x0004EA30
				// (set) Token: 0x06001217 RID: 4631 RVA: 0x00050874 File Offset: 0x0004EA74
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007C9 RID: 1993
				// (get) Token: 0x06001218 RID: 4632 RVA: 0x000508B8 File Offset: 0x0004EAB8
				// (set) Token: 0x06001219 RID: 4633 RVA: 0x000508F8 File Offset: 0x0004EAF8
				public unsafe SearchDeveloperMetadataRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_Body_Private_get_SearchDeveloperMetadataRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<SearchDeveloperMetadataRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_SearchDeveloperMetadataRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x0600121A RID: 4634 RVA: 0x0005093C File Offset: 0x0004EB3C
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x170007CA RID: 1994
				// (get) Token: 0x0600121B RID: 4635 RVA: 0x00050988 File Offset: 0x0004EB88
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117988, XrefRangeEnd = 1117990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007CB RID: 1995
				// (get) Token: 0x0600121C RID: 4636 RVA: 0x000509CC File Offset: 0x0004EBCC
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117990, XrefRangeEnd = 1117992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007CC RID: 1996
				// (get) Token: 0x0600121D RID: 4637 RVA: 0x00050A10 File Offset: 0x0004EC10
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117992, XrefRangeEnd = 1117994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600121E RID: 4638 RVA: 0x00050A54 File Offset: 0x0004EC54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117994, XrefRangeEnd = 1118014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600121F RID: 4639 RVA: 0x0000A9CD File Offset: 0x00008BCD
				public SearchRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007C6 RID: 1990
				// (get) Token: 0x06001220 RID: 4640 RVA: 0x00050A90 File Offset: 0x0004EC90
				// (set) Token: 0x06001221 RID: 4641 RVA: 0x0000A9D6 File Offset: 0x00008BD6
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007C7 RID: 1991
				// (get) Token: 0x06001222 RID: 4642 RVA: 0x00050AB8 File Offset: 0x0004ECB8
				// (set) Token: 0x06001223 RID: 4643 RVA: 0x0000A9F5 File Offset: 0x00008BF5
				public unsafe SearchDeveloperMetadataRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchDeveloperMetadataRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.DeveloperMetadataResource.SearchRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000C89 RID: 3209
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000C8A RID: 3210
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000C8B RID: 3211
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_SearchDeveloperMetadataRequest_String_0;

				// Token: 0x04000C8C RID: 3212
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000C8D RID: 3213
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000C8E RID: 3214
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_SearchDeveloperMetadataRequest_0;

				// Token: 0x04000C8F RID: 3215
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_SearchDeveloperMetadataRequest_0;

				// Token: 0x04000C90 RID: 3216
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000C91 RID: 3217
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000C92 RID: 3218
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000C93 RID: 3219
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000C94 RID: 3220
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}
		}

		// Token: 0x020000D5 RID: 213
		public class SheetsResource : Object
		{
			// Token: 0x060011AD RID: 4525 RVA: 0x0004EA2C File Offset: 0x0004CC2C
			// Note: this type is marked as 'beforefieldinit'.
			static SheetsResource()
			{
				Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "SheetsResource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr);
				SpreadsheetsResource.SheetsResource.NativeFieldInfoPtr_Resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr, "Resource");
				SpreadsheetsResource.SheetsResource.NativeFieldInfoPtr_service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr, "service");
				SpreadsheetsResource.SheetsResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr, 100663363);
				SpreadsheetsResource.SheetsResource.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_CopyToRequest_CopySheetToAnotherSpreadsheetRequest_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr, 100663364);
			}

			// Token: 0x060011AE RID: 4526 RVA: 0x0004EAA8 File Offset: 0x0004CCA8
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SheetsResource(IClientService service)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.SheetsResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011AF RID: 4527 RVA: 0x0004EAF4 File Offset: 0x0004CCF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118073, XrefRangeEnd = 1118081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.SheetsResource.CopyToRequest CopyTo(CopySheetToAnotherSpreadsheetRequest body, string spreadsheetId, int sheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sheetId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_CopyToRequest_CopySheetToAnotherSpreadsheetRequest_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.SheetsResource.CopyToRequest>(intPtr3) : null;
			}

			// Token: 0x060011B0 RID: 4528 RVA: 0x0000A7EB File Offset: 0x000089EB
			public SheetsResource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0004EB70 File Offset: 0x0004CD70
			// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0000A7F4 File Offset: 0x000089F4
			public unsafe static string Resource
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpreadsheetsResource.SheetsResource.NativeFieldInfoPtr_Resource, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpreadsheetsResource.SheetsResource.NativeFieldInfoPtr_Resource, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0004EB90 File Offset: 0x0004CD90
			// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0000A806 File Offset: 0x00008A06
			public unsafe IClientService service
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.NativeFieldInfoPtr_service);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.NativeFieldInfoPtr_service), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C3E RID: 3134
			private static readonly IntPtr NativeFieldInfoPtr_Resource;

			// Token: 0x04000C3F RID: 3135
			private static readonly IntPtr NativeFieldInfoPtr_service;

			// Token: 0x04000C40 RID: 3136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_0;

			// Token: 0x04000C41 RID: 3137
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_CopyToRequest_CopySheetToAnotherSpreadsheetRequest_String_Int32_0;

			// Token: 0x020000DD RID: 221
			public class CopyToRequest : SheetsBaseServiceRequest<SheetProperties>
			{
				// Token: 0x06001224 RID: 4644 RVA: 0x00050AE8 File Offset: 0x0004ECE8
				// Note: this type is marked as 'beforefieldinit'.
				static CopyToRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource>.NativeClassPtr, "CopyToRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__SheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, "<SheetId>k__BackingField");
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_CopySheetToAnotherSpreadsheetRequest_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663365);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663366);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663367);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663368);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_set_SheetId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663369);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_Body_Private_get_CopySheetToAnotherSpreadsheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663370);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_CopySheetToAnotherSpreadsheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663371);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663372);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663373);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663374);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663375);
					SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr, 100663376);
				}

				// Token: 0x06001225 RID: 4645 RVA: 0x00050C40 File Offset: 0x0004EE40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118029, XrefRangeEnd = 1118034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CopyToRequest(IClientService service, CopySheetToAnotherSpreadsheetRequest body, string spreadsheetId, int sheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.SheetsResource.CopyToRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sheetId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_CopySheetToAnotherSpreadsheetRequest_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007D0 RID: 2000
				// (get) Token: 0x06001226 RID: 4646 RVA: 0x00050CC0 File Offset: 0x0004EEC0
				// (set) Token: 0x06001227 RID: 4647 RVA: 0x00050D04 File Offset: 0x0004EF04
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007D1 RID: 2001
				// (get) Token: 0x06001228 RID: 4648 RVA: 0x00050D48 File Offset: 0x0004EF48
				// (set) Token: 0x06001229 RID: 4649 RVA: 0x00050D90 File Offset: 0x0004EF90
				public unsafe virtual int SheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_set_SheetId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007D2 RID: 2002
				// (get) Token: 0x0600122A RID: 4650 RVA: 0x00050DD0 File Offset: 0x0004EFD0
				// (set) Token: 0x0600122B RID: 4651 RVA: 0x00050E10 File Offset: 0x0004F010
				public unsafe CopySheetToAnotherSpreadsheetRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_Body_Private_get_CopySheetToAnotherSpreadsheetRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<CopySheetToAnotherSpreadsheetRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_CopySheetToAnotherSpreadsheetRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x0600122C RID: 4652 RVA: 0x00050E54 File Offset: 0x0004F054
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x170007D3 RID: 2003
				// (get) Token: 0x0600122D RID: 4653 RVA: 0x00050EA0 File Offset: 0x0004F0A0
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118034, XrefRangeEnd = 1118036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007D4 RID: 2004
				// (get) Token: 0x0600122E RID: 4654 RVA: 0x00050EE4 File Offset: 0x0004F0E4
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118036, XrefRangeEnd = 1118038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007D5 RID: 2005
				// (get) Token: 0x0600122F RID: 4655 RVA: 0x00050F28 File Offset: 0x0004F128
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118038, XrefRangeEnd = 1118040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06001230 RID: 4656 RVA: 0x00050F6C File Offset: 0x0004F16C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118040, XrefRangeEnd = 1118073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.SheetsResource.CopyToRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001231 RID: 4657 RVA: 0x0000AA14 File Offset: 0x00008C14
				public CopyToRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007CD RID: 1997
				// (get) Token: 0x06001232 RID: 4658 RVA: 0x00050FA8 File Offset: 0x0004F1A8
				// (set) Token: 0x06001233 RID: 4659 RVA: 0x0000AA1D File Offset: 0x00008C1D
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007CE RID: 1998
				// (get) Token: 0x06001234 RID: 4660 RVA: 0x00050FD0 File Offset: 0x0004F1D0
				// (set) Token: 0x06001235 RID: 4661 RVA: 0x0000AA3C File Offset: 0x00008C3C
				public unsafe int _SheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__SheetId_k__BackingField);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__SheetId_k__BackingField)) = value;
					}
				}

				// Token: 0x170007CF RID: 1999
				// (get) Token: 0x06001236 RID: 4662 RVA: 0x00050FF8 File Offset: 0x0004F1F8
				// (set) Token: 0x06001237 RID: 4663 RVA: 0x0000AA57 File Offset: 0x00008C57
				public unsafe CopySheetToAnotherSpreadsheetRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopySheetToAnotherSpreadsheetRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.SheetsResource.CopyToRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000C95 RID: 3221
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000C96 RID: 3222
				private static readonly IntPtr NativeFieldInfoPtr__SheetId_k__BackingField;

				// Token: 0x04000C97 RID: 3223
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000C98 RID: 3224
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_CopySheetToAnotherSpreadsheetRequest_String_Int32_0;

				// Token: 0x04000C99 RID: 3225
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000C9A RID: 3226
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000C9B RID: 3227
				private static readonly IntPtr NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Int32_0;

				// Token: 0x04000C9C RID: 3228
				private static readonly IntPtr NativeMethodInfoPtr_set_SheetId_Private_set_Void_Int32_0;

				// Token: 0x04000C9D RID: 3229
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_CopySheetToAnotherSpreadsheetRequest_0;

				// Token: 0x04000C9E RID: 3230
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_CopySheetToAnotherSpreadsheetRequest_0;

				// Token: 0x04000C9F RID: 3231
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000CA0 RID: 3232
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000CA1 RID: 3233
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000CA2 RID: 3234
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000CA3 RID: 3235
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}
		}

		// Token: 0x020000D6 RID: 214
		public class ValuesResource : Object
		{
			// Token: 0x060011B5 RID: 4533 RVA: 0x0004EBC0 File Offset: 0x0004CDC0
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesResource()
			{
				Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "ValuesResource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr);
				SpreadsheetsResource.ValuesResource.NativeFieldInfoPtr_Resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "Resource");
				SpreadsheetsResource.ValuesResource.NativeFieldInfoPtr_service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "service");
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663377);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Append_Public_Virtual_New_AppendRequest_ValueRange_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663378);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchClear_Public_Virtual_New_BatchClearRequest_BatchClearValuesRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663379);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchClearByDataFilter_Public_Virtual_New_BatchClearByDataFilterRequest_BatchClearValuesByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663380);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchGet_Public_Virtual_New_BatchGetRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663381);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchGetByDataFilter_Public_Virtual_New_BatchGetByDataFilterRequest_BatchGetValuesByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663382);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchUpdate_Public_Virtual_New_BatchUpdateRequest_BatchUpdateValuesRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663383);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchUpdateByDataFilter_Public_Virtual_New_BatchUpdateByDataFilterRequest_BatchUpdateValuesByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663384);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Clear_Public_Virtual_New_ClearRequest_ClearValuesRequest_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663385);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663386);
				SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Update_Public_Virtual_New_UpdateRequest_ValueRange_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, 100663387);
			}

			// Token: 0x060011B6 RID: 4534 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesResource(IClientService service)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011B7 RID: 4535 RVA: 0x0004ED3C File Offset: 0x0004CF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118657, XrefRangeEnd = 1118666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.AppendRequest Append(ValueRange body, string spreadsheetId, string range)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Append_Public_Virtual_New_AppendRequest_ValueRange_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.AppendRequest>(intPtr3) : null;
			}

			// Token: 0x060011B8 RID: 4536 RVA: 0x0004EDBC File Offset: 0x0004CFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118666, XrefRangeEnd = 1118674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.BatchClearRequest BatchClear(BatchClearValuesRequest body, string spreadsheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchClear_Public_Virtual_New_BatchClearRequest_BatchClearValuesRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.BatchClearRequest>(intPtr3) : null;
			}

			// Token: 0x060011B9 RID: 4537 RVA: 0x0004EE2C File Offset: 0x0004D02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118674, XrefRangeEnd = 1118682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest BatchClearByDataFilter(BatchClearValuesByDataFilterRequest body, string spreadsheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchClearByDataFilter_Public_Virtual_New_BatchClearByDataFilterRequest_BatchClearValuesByDataFilterRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>(intPtr3) : null;
			}

			// Token: 0x060011BA RID: 4538 RVA: 0x0004EE9C File Offset: 0x0004D09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118682, XrefRangeEnd = 1118689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.BatchGetRequest BatchGet(string spreadsheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchGet_Public_Virtual_New_BatchGetRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.BatchGetRequest>(intPtr3) : null;
				}
			}

			// Token: 0x060011BB RID: 4539 RVA: 0x0004EEF8 File Offset: 0x0004D0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118689, XrefRangeEnd = 1118697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest BatchGetByDataFilter(BatchGetValuesByDataFilterRequest body, string spreadsheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchGetByDataFilter_Public_Virtual_New_BatchGetByDataFilterRequest_BatchGetValuesByDataFilterRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>(intPtr3) : null;
			}

			// Token: 0x060011BC RID: 4540 RVA: 0x0004EF68 File Offset: 0x0004D168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118697, XrefRangeEnd = 1118705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.BatchUpdateRequest BatchUpdate(BatchUpdateValuesRequest body, string spreadsheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchUpdate_Public_Virtual_New_BatchUpdateRequest_BatchUpdateValuesRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>(intPtr3) : null;
			}

			// Token: 0x060011BD RID: 4541 RVA: 0x0004EFD8 File Offset: 0x0004D1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118705, XrefRangeEnd = 1118713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest BatchUpdateByDataFilter(BatchUpdateValuesByDataFilterRequest body, string spreadsheetId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_BatchUpdateByDataFilter_Public_Virtual_New_BatchUpdateByDataFilterRequest_BatchUpdateValuesByDataFilterRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>(intPtr3) : null;
			}

			// Token: 0x060011BE RID: 4542 RVA: 0x0004F048 File Offset: 0x0004D248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118713, XrefRangeEnd = 1118722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.ClearRequest Clear(ClearValuesRequest body, string spreadsheetId, string range)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Clear_Public_Virtual_New_ClearRequest_ClearValuesRequest_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.ClearRequest>(intPtr3) : null;
			}

			// Token: 0x060011BF RID: 4543 RVA: 0x0004F0C8 File Offset: 0x0004D2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118722, XrefRangeEnd = 1118730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.GetRequest Get(string spreadsheetId, string range)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.GetRequest>(intPtr3) : null;
			}

			// Token: 0x060011C0 RID: 4544 RVA: 0x0004F138 File Offset: 0x0004D338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118730, XrefRangeEnd = 1118739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual SpreadsheetsResource.ValuesResource.UpdateRequest Update(ValueRange body, string spreadsheetId, string range)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.NativeMethodInfoPtr_Update_Public_Virtual_New_UpdateRequest_ValueRange_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource.ValuesResource.UpdateRequest>(intPtr3) : null;
			}

			// Token: 0x060011C1 RID: 4545 RVA: 0x0000A825 File Offset: 0x00008A25
			public ValuesResource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0004F1B8 File Offset: 0x0004D3B8
			// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0000A82E File Offset: 0x00008A2E
			public unsafe static string Resource
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpreadsheetsResource.ValuesResource.NativeFieldInfoPtr_Resource, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpreadsheetsResource.ValuesResource.NativeFieldInfoPtr_Resource, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0004F1D8 File Offset: 0x0004D3D8
			// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0000A840 File Offset: 0x00008A40
			public unsafe IClientService service
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.NativeFieldInfoPtr_service);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.NativeFieldInfoPtr_service), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C42 RID: 3138
			private static readonly IntPtr NativeFieldInfoPtr_Resource;

			// Token: 0x04000C43 RID: 3139
			private static readonly IntPtr NativeFieldInfoPtr_service;

			// Token: 0x04000C44 RID: 3140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_0;

			// Token: 0x04000C45 RID: 3141
			private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Virtual_New_AppendRequest_ValueRange_String_String_0;

			// Token: 0x04000C46 RID: 3142
			private static readonly IntPtr NativeMethodInfoPtr_BatchClear_Public_Virtual_New_BatchClearRequest_BatchClearValuesRequest_String_0;

			// Token: 0x04000C47 RID: 3143
			private static readonly IntPtr NativeMethodInfoPtr_BatchClearByDataFilter_Public_Virtual_New_BatchClearByDataFilterRequest_BatchClearValuesByDataFilterRequest_String_0;

			// Token: 0x04000C48 RID: 3144
			private static readonly IntPtr NativeMethodInfoPtr_BatchGet_Public_Virtual_New_BatchGetRequest_String_0;

			// Token: 0x04000C49 RID: 3145
			private static readonly IntPtr NativeMethodInfoPtr_BatchGetByDataFilter_Public_Virtual_New_BatchGetByDataFilterRequest_BatchGetValuesByDataFilterRequest_String_0;

			// Token: 0x04000C4A RID: 3146
			private static readonly IntPtr NativeMethodInfoPtr_BatchUpdate_Public_Virtual_New_BatchUpdateRequest_BatchUpdateValuesRequest_String_0;

			// Token: 0x04000C4B RID: 3147
			private static readonly IntPtr NativeMethodInfoPtr_BatchUpdateByDataFilter_Public_Virtual_New_BatchUpdateByDataFilterRequest_BatchUpdateValuesByDataFilterRequest_String_0;

			// Token: 0x04000C4C RID: 3148
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_ClearRequest_ClearValuesRequest_String_String_0;

			// Token: 0x04000C4D RID: 3149
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_GetRequest_String_String_0;

			// Token: 0x04000C4E RID: 3150
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_UpdateRequest_ValueRange_String_String_0;

			// Token: 0x020000DE RID: 222
			public class AppendRequest : SheetsBaseServiceRequest<AppendValuesResponse>
			{
				// Token: 0x06001238 RID: 4664 RVA: 0x00051028 File Offset: 0x0004F228
				// Note: this type is marked as 'beforefieldinit'.
				static AppendRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "AppendRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<Range>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<IncludeValuesInResponse>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__InsertDataOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<InsertDataOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<ResponseDateTimeRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<ResponseValueRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<ValueInputOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_ValueRange_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663388);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663389);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663390);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663391);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663392);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663393);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663394);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_InsertDataOption_Public_Virtual_New_get_Nullable_1_InsertDataOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663395);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_InsertDataOption_Public_Virtual_New_set_Void_Nullable_1_InsertDataOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663396);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_Nullable_1_ResponseDateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663397);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseDateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663398);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_Nullable_1_ResponseValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663399);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663400);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_Nullable_1_ValueInputOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663401);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_Nullable_1_ValueInputOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663402);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_Body_Private_get_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663403);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663404);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663405);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663406);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663407);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663408);
					SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr, 100663409);
				}

				// Token: 0x06001239 RID: 4665 RVA: 0x000512AC File Offset: 0x0004F4AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118081, XrefRangeEnd = 1118087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe AppendRequest(IClientService service, ValueRange body, string spreadsheetId, string range)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.AppendRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_ValueRange_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007DE RID: 2014
				// (get) Token: 0x0600123A RID: 4666 RVA: 0x00051330 File Offset: 0x0004F530
				// (set) Token: 0x0600123B RID: 4667 RVA: 0x00051374 File Offset: 0x0004F574
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007DF RID: 2015
				// (get) Token: 0x0600123C RID: 4668 RVA: 0x000513B8 File Offset: 0x0004F5B8
				// (set) Token: 0x0600123D RID: 4669 RVA: 0x000513FC File Offset: 0x0004F5FC
				public unsafe virtual string Range
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E0 RID: 2016
				// (get) Token: 0x0600123E RID: 4670 RVA: 0x00051440 File Offset: 0x0004F640
				// (set) Token: 0x0600123F RID: 4671 RVA: 0x00051484 File Offset: 0x0004F684
				public unsafe virtual Nullable<bool> IncludeValuesInResponse
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E1 RID: 2017
				// (get) Token: 0x06001240 RID: 4672 RVA: 0x000514D8 File Offset: 0x0004F6D8
				// (set) Token: 0x06001241 RID: 4673 RVA: 0x0005151C File Offset: 0x0004F71C
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum> InsertDataOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_InsertDataOption_Public_Virtual_New_get_Nullable_1_InsertDataOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_InsertDataOption_Public_Virtual_New_set_Void_Nullable_1_InsertDataOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E2 RID: 2018
				// (get) Token: 0x06001242 RID: 4674 RVA: 0x00051570 File Offset: 0x0004F770
				// (set) Token: 0x06001243 RID: 4675 RVA: 0x000515B4 File Offset: 0x0004F7B4
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseDateTimeRenderOptionEnum> ResponseDateTimeRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_Nullable_1_ResponseDateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseDateTimeRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseDateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E3 RID: 2019
				// (get) Token: 0x06001244 RID: 4676 RVA: 0x00051608 File Offset: 0x0004F808
				// (set) Token: 0x06001245 RID: 4677 RVA: 0x0005164C File Offset: 0x0004F84C
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseValueRenderOptionEnum> ResponseValueRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_Nullable_1_ResponseValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseValueRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E4 RID: 2020
				// (get) Token: 0x06001246 RID: 4678 RVA: 0x000516A0 File Offset: 0x0004F8A0
				// (set) Token: 0x06001247 RID: 4679 RVA: 0x000516E4 File Offset: 0x0004F8E4
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum> ValueInputOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_Nullable_1_ValueInputOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_Nullable_1_ValueInputOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E5 RID: 2021
				// (get) Token: 0x06001248 RID: 4680 RVA: 0x00051738 File Offset: 0x0004F938
				// (set) Token: 0x06001249 RID: 4681 RVA: 0x00051778 File Offset: 0x0004F978
				public unsafe ValueRange Body
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_Body_Private_get_ValueRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_ValueRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x0600124A RID: 4682 RVA: 0x000517BC File Offset: 0x0004F9BC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x170007E6 RID: 2022
				// (get) Token: 0x0600124B RID: 4683 RVA: 0x00051808 File Offset: 0x0004FA08
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118087, XrefRangeEnd = 1118089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007E7 RID: 2023
				// (get) Token: 0x0600124C RID: 4684 RVA: 0x0005184C File Offset: 0x0004FA4C
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118089, XrefRangeEnd = 1118091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007E8 RID: 2024
				// (get) Token: 0x0600124D RID: 4685 RVA: 0x00051890 File Offset: 0x0004FA90
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118091, XrefRangeEnd = 1118093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600124E RID: 4686 RVA: 0x000518D4 File Offset: 0x0004FAD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118093, XrefRangeEnd = 1118192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.AppendRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600124F RID: 4687 RVA: 0x0000AA76 File Offset: 0x00008C76
				public AppendRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007D6 RID: 2006
				// (get) Token: 0x06001250 RID: 4688 RVA: 0x00051910 File Offset: 0x0004FB10
				// (set) Token: 0x06001251 RID: 4689 RVA: 0x0000AA7F File Offset: 0x00008C7F
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007D7 RID: 2007
				// (get) Token: 0x06001252 RID: 4690 RVA: 0x00051938 File Offset: 0x0004FB38
				// (set) Token: 0x06001253 RID: 4691 RVA: 0x0000AA9E File Offset: 0x00008C9E
				public unsafe string _Range_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__Range_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007D8 RID: 2008
				// (get) Token: 0x06001254 RID: 4692 RVA: 0x00051960 File Offset: 0x0004FB60
				// (set) Token: 0x06001255 RID: 4693 RVA: 0x0000AABD File Offset: 0x00008CBD
				public Nullable<bool> _IncludeValuesInResponse_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField);
						return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007D9 RID: 2009
				// (get) Token: 0x06001256 RID: 4694 RVA: 0x00051990 File Offset: 0x0004FB90
				// (set) Token: 0x06001257 RID: 4695 RVA: 0x0000AAEB File Offset: 0x00008CEB
				public Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum> _InsertDataOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__InsertDataOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__InsertDataOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007DA RID: 2010
				// (get) Token: 0x06001258 RID: 4696 RVA: 0x000519C0 File Offset: 0x0004FBC0
				// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000AB19 File Offset: 0x00008D19
				public Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseDateTimeRenderOptionEnum> _ResponseDateTimeRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseDateTimeRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseDateTimeRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseDateTimeRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007DB RID: 2011
				// (get) Token: 0x0600125A RID: 4698 RVA: 0x000519F0 File Offset: 0x0004FBF0
				// (set) Token: 0x0600125B RID: 4699 RVA: 0x0000AB47 File Offset: 0x00008D47
				public Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseValueRenderOptionEnum> _ResponseValueRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseValueRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseValueRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ResponseValueRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007DC RID: 2012
				// (get) Token: 0x0600125C RID: 4700 RVA: 0x00051A20 File Offset: 0x0004FC20
				// (set) Token: 0x0600125D RID: 4701 RVA: 0x0000AB75 File Offset: 0x00008D75
				public Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum> _ValueInputOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007DD RID: 2013
				// (get) Token: 0x0600125E RID: 4702 RVA: 0x00051A50 File Offset: 0x0004FC50
				// (set) Token: 0x0600125F RID: 4703 RVA: 0x0000ABA3 File Offset: 0x00008DA3
				public unsafe ValueRange _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueRange>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.AppendRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000CA4 RID: 3236
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000CA5 RID: 3237
				private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

				// Token: 0x04000CA6 RID: 3238
				private static readonly IntPtr NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField;

				// Token: 0x04000CA7 RID: 3239
				private static readonly IntPtr NativeFieldInfoPtr__InsertDataOption_k__BackingField;

				// Token: 0x04000CA8 RID: 3240
				private static readonly IntPtr NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField;

				// Token: 0x04000CA9 RID: 3241
				private static readonly IntPtr NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField;

				// Token: 0x04000CAA RID: 3242
				private static readonly IntPtr NativeFieldInfoPtr__ValueInputOption_k__BackingField;

				// Token: 0x04000CAB RID: 3243
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000CAC RID: 3244
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_ValueRange_String_String_0;

				// Token: 0x04000CAD RID: 3245
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000CAE RID: 3246
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000CAF RID: 3247
				private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0;

				// Token: 0x04000CB0 RID: 3248
				private static readonly IntPtr NativeMethodInfoPtr_set_Range_Private_set_Void_String_0;

				// Token: 0x04000CB1 RID: 3249
				private static readonly IntPtr NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0;

				// Token: 0x04000CB2 RID: 3250
				private static readonly IntPtr NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

				// Token: 0x04000CB3 RID: 3251
				private static readonly IntPtr NativeMethodInfoPtr_get_InsertDataOption_Public_Virtual_New_get_Nullable_1_InsertDataOptionEnum_0;

				// Token: 0x04000CB4 RID: 3252
				private static readonly IntPtr NativeMethodInfoPtr_set_InsertDataOption_Public_Virtual_New_set_Void_Nullable_1_InsertDataOptionEnum_0;

				// Token: 0x04000CB5 RID: 3253
				private static readonly IntPtr NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_Nullable_1_ResponseDateTimeRenderOptionEnum_0;

				// Token: 0x04000CB6 RID: 3254
				private static readonly IntPtr NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseDateTimeRenderOptionEnum_0;

				// Token: 0x04000CB7 RID: 3255
				private static readonly IntPtr NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_Nullable_1_ResponseValueRenderOptionEnum_0;

				// Token: 0x04000CB8 RID: 3256
				private static readonly IntPtr NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseValueRenderOptionEnum_0;

				// Token: 0x04000CB9 RID: 3257
				private static readonly IntPtr NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_Nullable_1_ValueInputOptionEnum_0;

				// Token: 0x04000CBA RID: 3258
				private static readonly IntPtr NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_Nullable_1_ValueInputOptionEnum_0;

				// Token: 0x04000CBB RID: 3259
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_ValueRange_0;

				// Token: 0x04000CBC RID: 3260
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_ValueRange_0;

				// Token: 0x04000CBD RID: 3261
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000CBE RID: 3262
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000CBF RID: 3263
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000CC0 RID: 3264
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000CC1 RID: 3265
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;

				// Token: 0x020000E8 RID: 232
				public enum InsertDataOptionEnum
				{
					// Token: 0x04000D51 RID: 3409
					OVERWRITE,
					// Token: 0x04000D52 RID: 3410
					INSERTROWS
				}

				// Token: 0x020000E9 RID: 233
				public enum ResponseDateTimeRenderOptionEnum
				{
					// Token: 0x04000D54 RID: 3412
					SERIALNUMBER,
					// Token: 0x04000D55 RID: 3413
					FORMATTEDSTRING
				}

				// Token: 0x020000EA RID: 234
				public enum ResponseValueRenderOptionEnum
				{
					// Token: 0x04000D57 RID: 3415
					FORMATTEDVALUE,
					// Token: 0x04000D58 RID: 3416
					UNFORMATTEDVALUE,
					// Token: 0x04000D59 RID: 3417
					FORMULA
				}

				// Token: 0x020000EB RID: 235
				public enum ValueInputOptionEnum
				{
					// Token: 0x04000D5B RID: 3419
					INPUTVALUEOPTIONUNSPECIFIED,
					// Token: 0x04000D5C RID: 3420
					RAW,
					// Token: 0x04000D5D RID: 3421
					USERENTERED
				}
			}

			// Token: 0x020000DF RID: 223
			public class BatchClearRequest : SheetsBaseServiceRequest<BatchClearValuesResponse>
			{
				// Token: 0x06001260 RID: 4704 RVA: 0x00051A80 File Offset: 0x0004FC80
				// Note: this type is marked as 'beforefieldinit'.
				static BatchClearRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "BatchClearRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchClearValuesRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663410);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663411);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663412);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchClearValuesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663413);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchClearValuesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663414);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663415);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663416);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663417);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663418);
					SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr, 100663419);
				}

				// Token: 0x06001261 RID: 4705 RVA: 0x00051B9C File Offset: 0x0004FD9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118192, XrefRangeEnd = 1118197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BatchClearRequest(IClientService service, BatchClearValuesRequest body, string spreadsheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchClearValuesRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007EB RID: 2027
				// (get) Token: 0x06001262 RID: 4706 RVA: 0x00051C0C File Offset: 0x0004FE0C
				// (set) Token: 0x06001263 RID: 4707 RVA: 0x00051C50 File Offset: 0x0004FE50
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007EC RID: 2028
				// (get) Token: 0x06001264 RID: 4708 RVA: 0x00051C94 File Offset: 0x0004FE94
				// (set) Token: 0x06001265 RID: 4709 RVA: 0x00051CD4 File Offset: 0x0004FED4
				public unsafe BatchClearValuesRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchClearValuesRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<BatchClearValuesRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchClearValuesRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x06001266 RID: 4710 RVA: 0x00051D18 File Offset: 0x0004FF18
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x170007ED RID: 2029
				// (get) Token: 0x06001267 RID: 4711 RVA: 0x00051D64 File Offset: 0x0004FF64
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118197, XrefRangeEnd = 1118199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007EE RID: 2030
				// (get) Token: 0x06001268 RID: 4712 RVA: 0x00051DA8 File Offset: 0x0004FFA8
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118199, XrefRangeEnd = 1118201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007EF RID: 2031
				// (get) Token: 0x06001269 RID: 4713 RVA: 0x00051DEC File Offset: 0x0004FFEC
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118201, XrefRangeEnd = 1118203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600126A RID: 4714 RVA: 0x00051E30 File Offset: 0x00050030
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118203, XrefRangeEnd = 1118223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600126B RID: 4715 RVA: 0x0000ABC2 File Offset: 0x00008DC2
				public BatchClearRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007E9 RID: 2025
				// (get) Token: 0x0600126C RID: 4716 RVA: 0x00051E6C File Offset: 0x0005006C
				// (set) Token: 0x0600126D RID: 4717 RVA: 0x0000ABCB File Offset: 0x00008DCB
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007EA RID: 2026
				// (get) Token: 0x0600126E RID: 4718 RVA: 0x00051E94 File Offset: 0x00050094
				// (set) Token: 0x0600126F RID: 4719 RVA: 0x0000ABEA File Offset: 0x00008DEA
				public unsafe BatchClearValuesRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchClearValuesRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000CC2 RID: 3266
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000CC3 RID: 3267
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000CC4 RID: 3268
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchClearValuesRequest_String_0;

				// Token: 0x04000CC5 RID: 3269
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000CC6 RID: 3270
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000CC7 RID: 3271
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_BatchClearValuesRequest_0;

				// Token: 0x04000CC8 RID: 3272
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_BatchClearValuesRequest_0;

				// Token: 0x04000CC9 RID: 3273
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000CCA RID: 3274
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000CCB RID: 3275
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000CCC RID: 3276
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000CCD RID: 3277
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}

			// Token: 0x020000E0 RID: 224
			public class BatchClearByDataFilterRequest : SheetsBaseServiceRequest<BatchClearValuesByDataFilterResponse>
			{
				// Token: 0x06001270 RID: 4720 RVA: 0x00051EC4 File Offset: 0x000500C4
				// Note: this type is marked as 'beforefieldinit'.
				static BatchClearByDataFilterRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "BatchClearByDataFilterRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchClearValuesByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663420);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663421);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663422);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchClearValuesByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663423);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchClearValuesByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663424);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663425);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663426);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663427);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663428);
					SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr, 100663429);
				}

				// Token: 0x06001271 RID: 4721 RVA: 0x00051FE0 File Offset: 0x000501E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118223, XrefRangeEnd = 1118228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BatchClearByDataFilterRequest(IClientService service, BatchClearValuesByDataFilterRequest body, string spreadsheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchClearValuesByDataFilterRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007F2 RID: 2034
				// (get) Token: 0x06001272 RID: 4722 RVA: 0x00052050 File Offset: 0x00050250
				// (set) Token: 0x06001273 RID: 4723 RVA: 0x00052094 File Offset: 0x00050294
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007F3 RID: 2035
				// (get) Token: 0x06001274 RID: 4724 RVA: 0x000520D8 File Offset: 0x000502D8
				// (set) Token: 0x06001275 RID: 4725 RVA: 0x00052118 File Offset: 0x00050318
				public unsafe BatchClearValuesByDataFilterRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchClearValuesByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<BatchClearValuesByDataFilterRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchClearValuesByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x06001276 RID: 4726 RVA: 0x0005215C File Offset: 0x0005035C
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x170007F4 RID: 2036
				// (get) Token: 0x06001277 RID: 4727 RVA: 0x000521A8 File Offset: 0x000503A8
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118228, XrefRangeEnd = 1118230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007F5 RID: 2037
				// (get) Token: 0x06001278 RID: 4728 RVA: 0x000521EC File Offset: 0x000503EC
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118230, XrefRangeEnd = 1118232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x170007F6 RID: 2038
				// (get) Token: 0x06001279 RID: 4729 RVA: 0x00052230 File Offset: 0x00050430
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118232, XrefRangeEnd = 1118234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600127A RID: 4730 RVA: 0x00052274 File Offset: 0x00050474
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118234, XrefRangeEnd = 1118254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600127B RID: 4731 RVA: 0x0000AC09 File Offset: 0x00008E09
				public BatchClearByDataFilterRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007F0 RID: 2032
				// (get) Token: 0x0600127C RID: 4732 RVA: 0x000522B0 File Offset: 0x000504B0
				// (set) Token: 0x0600127D RID: 4733 RVA: 0x0000AC12 File Offset: 0x00008E12
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007F1 RID: 2033
				// (get) Token: 0x0600127E RID: 4734 RVA: 0x000522D8 File Offset: 0x000504D8
				// (set) Token: 0x0600127F RID: 4735 RVA: 0x0000AC31 File Offset: 0x00008E31
				public unsafe BatchClearValuesByDataFilterRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchClearValuesByDataFilterRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchClearByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000CCE RID: 3278
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000CCF RID: 3279
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000CD0 RID: 3280
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchClearValuesByDataFilterRequest_String_0;

				// Token: 0x04000CD1 RID: 3281
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000CD2 RID: 3282
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000CD3 RID: 3283
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_BatchClearValuesByDataFilterRequest_0;

				// Token: 0x04000CD4 RID: 3284
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_BatchClearValuesByDataFilterRequest_0;

				// Token: 0x04000CD5 RID: 3285
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000CD6 RID: 3286
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000CD7 RID: 3287
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000CD8 RID: 3288
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000CD9 RID: 3289
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}

			// Token: 0x020000E1 RID: 225
			public class BatchGetRequest : SheetsBaseServiceRequest<BatchGetValuesResponse>
			{
				// Token: 0x06001280 RID: 4736 RVA: 0x00052308 File Offset: 0x00050508
				// Note: this type is marked as 'beforefieldinit'.
				static BatchGetRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "BatchGetRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, "<DateTimeRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, "<MajorDimension>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__Ranges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, "<Ranges>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, "<ValueRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663430);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663431);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663432);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_Nullable_1_DateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663433);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_DateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663434);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_Nullable_1_MajorDimensionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663435);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_Nullable_1_MajorDimensionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663436);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_Repeatable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663437);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_Repeatable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663438);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_Nullable_1_ValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663439);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663440);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663441);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663442);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663443);
					SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr, 100663444);
				}

				// Token: 0x06001281 RID: 4737 RVA: 0x000524C4 File Offset: 0x000506C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118254, XrefRangeEnd = 1118258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BatchGetRequest(IClientService service, string spreadsheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007FC RID: 2044
				// (get) Token: 0x06001282 RID: 4738 RVA: 0x00052524 File Offset: 0x00050724
				// (set) Token: 0x06001283 RID: 4739 RVA: 0x00052568 File Offset: 0x00050768
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007FD RID: 2045
				// (get) Token: 0x06001284 RID: 4740 RVA: 0x000525AC File Offset: 0x000507AC
				// (set) Token: 0x06001285 RID: 4741 RVA: 0x000525F0 File Offset: 0x000507F0
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.DateTimeRenderOptionEnum> DateTimeRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_Nullable_1_DateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.DateTimeRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_DateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007FE RID: 2046
				// (get) Token: 0x06001286 RID: 4742 RVA: 0x00052644 File Offset: 0x00050844
				// (set) Token: 0x06001287 RID: 4743 RVA: 0x00052688 File Offset: 0x00050888
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.MajorDimensionEnum> MajorDimension
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_Nullable_1_MajorDimensionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.MajorDimensionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_Nullable_1_MajorDimensionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007FF RID: 2047
				// (get) Token: 0x06001288 RID: 4744 RVA: 0x000526DC File Offset: 0x000508DC
				// (set) Token: 0x06001289 RID: 4745 RVA: 0x00052728 File Offset: 0x00050928
				public unsafe virtual Repeatable<string> Ranges
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_Repeatable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Repeatable<string>>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_Repeatable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000800 RID: 2048
				// (get) Token: 0x0600128A RID: 4746 RVA: 0x00052778 File Offset: 0x00050978
				// (set) Token: 0x0600128B RID: 4747 RVA: 0x000527BC File Offset: 0x000509BC
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.ValueRenderOptionEnum> ValueRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_Nullable_1_ValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.ValueRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000801 RID: 2049
				// (get) Token: 0x0600128C RID: 4748 RVA: 0x00052810 File Offset: 0x00050A10
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118258, XrefRangeEnd = 1118260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000802 RID: 2050
				// (get) Token: 0x0600128D RID: 4749 RVA: 0x00052854 File Offset: 0x00050A54
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118260, XrefRangeEnd = 1118262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000803 RID: 2051
				// (get) Token: 0x0600128E RID: 4750 RVA: 0x00052898 File Offset: 0x00050A98
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118262, XrefRangeEnd = 1118264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600128F RID: 4751 RVA: 0x000528DC File Offset: 0x00050ADC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118264, XrefRangeEnd = 1118337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001290 RID: 4752 RVA: 0x0000AC50 File Offset: 0x00008E50
				public BatchGetRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007F7 RID: 2039
				// (get) Token: 0x06001291 RID: 4753 RVA: 0x00052918 File Offset: 0x00050B18
				// (set) Token: 0x06001292 RID: 4754 RVA: 0x0000AC59 File Offset: 0x00008E59
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007F8 RID: 2040
				// (get) Token: 0x06001293 RID: 4755 RVA: 0x00052940 File Offset: 0x00050B40
				// (set) Token: 0x06001294 RID: 4756 RVA: 0x0000AC78 File Offset: 0x00008E78
				public Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.DateTimeRenderOptionEnum> _DateTimeRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.DateTimeRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.DateTimeRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.DateTimeRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007F9 RID: 2041
				// (get) Token: 0x06001295 RID: 4757 RVA: 0x00052970 File Offset: 0x00050B70
				// (set) Token: 0x06001296 RID: 4758 RVA: 0x0000ACA6 File Offset: 0x00008EA6
				public Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.MajorDimensionEnum> _MajorDimension_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.MajorDimensionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.MajorDimensionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.MajorDimensionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007FA RID: 2042
				// (get) Token: 0x06001297 RID: 4759 RVA: 0x000529A0 File Offset: 0x00050BA0
				// (set) Token: 0x06001298 RID: 4760 RVA: 0x0000ACD4 File Offset: 0x00008ED4
				public unsafe Repeatable<string> _Ranges_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__Ranges_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Repeatable<string>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__Ranges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007FB RID: 2043
				// (get) Token: 0x06001299 RID: 4761 RVA: 0x000529D0 File Offset: 0x00050BD0
				// (set) Token: 0x0600129A RID: 4762 RVA: 0x0000ACF3 File Offset: 0x00008EF3
				public Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.ValueRenderOptionEnum> _ValueRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.ValueRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.ValueRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.BatchGetRequest.ValueRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x04000CDA RID: 3290
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000CDB RID: 3291
				private static readonly IntPtr NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField;

				// Token: 0x04000CDC RID: 3292
				private static readonly IntPtr NativeFieldInfoPtr__MajorDimension_k__BackingField;

				// Token: 0x04000CDD RID: 3293
				private static readonly IntPtr NativeFieldInfoPtr__Ranges_k__BackingField;

				// Token: 0x04000CDE RID: 3294
				private static readonly IntPtr NativeFieldInfoPtr__ValueRenderOption_k__BackingField;

				// Token: 0x04000CDF RID: 3295
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0;

				// Token: 0x04000CE0 RID: 3296
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000CE1 RID: 3297
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000CE2 RID: 3298
				private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_Nullable_1_DateTimeRenderOptionEnum_0;

				// Token: 0x04000CE3 RID: 3299
				private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_DateTimeRenderOptionEnum_0;

				// Token: 0x04000CE4 RID: 3300
				private static readonly IntPtr NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_Nullable_1_MajorDimensionEnum_0;

				// Token: 0x04000CE5 RID: 3301
				private static readonly IntPtr NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_Nullable_1_MajorDimensionEnum_0;

				// Token: 0x04000CE6 RID: 3302
				private static readonly IntPtr NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_Repeatable_1_String_0;

				// Token: 0x04000CE7 RID: 3303
				private static readonly IntPtr NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_Repeatable_1_String_0;

				// Token: 0x04000CE8 RID: 3304
				private static readonly IntPtr NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_Nullable_1_ValueRenderOptionEnum_0;

				// Token: 0x04000CE9 RID: 3305
				private static readonly IntPtr NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ValueRenderOptionEnum_0;

				// Token: 0x04000CEA RID: 3306
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000CEB RID: 3307
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000CEC RID: 3308
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000CED RID: 3309
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;

				// Token: 0x020000EC RID: 236
				public enum DateTimeRenderOptionEnum
				{
					// Token: 0x04000D5F RID: 3423
					SERIALNUMBER,
					// Token: 0x04000D60 RID: 3424
					FORMATTEDSTRING
				}

				// Token: 0x020000ED RID: 237
				public enum MajorDimensionEnum
				{
					// Token: 0x04000D62 RID: 3426
					DIMENSIONUNSPECIFIED,
					// Token: 0x04000D63 RID: 3427
					ROWS,
					// Token: 0x04000D64 RID: 3428
					COLUMNS
				}

				// Token: 0x020000EE RID: 238
				public enum ValueRenderOptionEnum
				{
					// Token: 0x04000D66 RID: 3430
					FORMATTEDVALUE,
					// Token: 0x04000D67 RID: 3431
					UNFORMATTEDVALUE,
					// Token: 0x04000D68 RID: 3432
					FORMULA
				}
			}

			// Token: 0x020000E2 RID: 226
			public class BatchGetByDataFilterRequest : SheetsBaseServiceRequest<BatchGetValuesByDataFilterResponse>
			{
				// Token: 0x0600129B RID: 4763 RVA: 0x00052A00 File Offset: 0x00050C00
				// Note: this type is marked as 'beforefieldinit'.
				static BatchGetByDataFilterRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "BatchGetByDataFilterRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchGetValuesByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663445);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663446);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663447);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchGetValuesByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663448);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchGetValuesByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663449);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663450);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663451);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663452);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663453);
					SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr, 100663454);
				}

				// Token: 0x0600129C RID: 4764 RVA: 0x00052B1C File Offset: 0x00050D1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118337, XrefRangeEnd = 1118342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BatchGetByDataFilterRequest(IClientService service, BatchGetValuesByDataFilterRequest body, string spreadsheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchGetValuesByDataFilterRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000806 RID: 2054
				// (get) Token: 0x0600129D RID: 4765 RVA: 0x00052B8C File Offset: 0x00050D8C
				// (set) Token: 0x0600129E RID: 4766 RVA: 0x00052BD0 File Offset: 0x00050DD0
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000807 RID: 2055
				// (get) Token: 0x0600129F RID: 4767 RVA: 0x00052C14 File Offset: 0x00050E14
				// (set) Token: 0x060012A0 RID: 4768 RVA: 0x00052C54 File Offset: 0x00050E54
				public unsafe BatchGetValuesByDataFilterRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchGetValuesByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<BatchGetValuesByDataFilterRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchGetValuesByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060012A1 RID: 4769 RVA: 0x00052C98 File Offset: 0x00050E98
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x17000808 RID: 2056
				// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00052CE4 File Offset: 0x00050EE4
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118342, XrefRangeEnd = 1118344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000809 RID: 2057
				// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00052D28 File Offset: 0x00050F28
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118344, XrefRangeEnd = 1118346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x1700080A RID: 2058
				// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00052D6C File Offset: 0x00050F6C
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118346, XrefRangeEnd = 1118348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060012A5 RID: 4773 RVA: 0x00052DB0 File Offset: 0x00050FB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118348, XrefRangeEnd = 1118368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060012A6 RID: 4774 RVA: 0x0000AD21 File Offset: 0x00008F21
				public BatchGetByDataFilterRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000804 RID: 2052
				// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00052DEC File Offset: 0x00050FEC
				// (set) Token: 0x060012A8 RID: 4776 RVA: 0x0000AD2A File Offset: 0x00008F2A
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000805 RID: 2053
				// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00052E14 File Offset: 0x00051014
				// (set) Token: 0x060012AA RID: 4778 RVA: 0x0000AD49 File Offset: 0x00008F49
				public unsafe BatchGetValuesByDataFilterRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchGetValuesByDataFilterRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchGetByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000CEE RID: 3310
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000CEF RID: 3311
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000CF0 RID: 3312
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchGetValuesByDataFilterRequest_String_0;

				// Token: 0x04000CF1 RID: 3313
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000CF2 RID: 3314
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000CF3 RID: 3315
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_BatchGetValuesByDataFilterRequest_0;

				// Token: 0x04000CF4 RID: 3316
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_BatchGetValuesByDataFilterRequest_0;

				// Token: 0x04000CF5 RID: 3317
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000CF6 RID: 3318
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000CF7 RID: 3319
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000CF8 RID: 3320
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000CF9 RID: 3321
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}

			// Token: 0x020000E3 RID: 227
			public class BatchUpdateRequest : SheetsBaseServiceRequest<BatchUpdateValuesResponse>
			{
				// Token: 0x060012AB RID: 4779 RVA: 0x00052E44 File Offset: 0x00051044
				// Note: this type is marked as 'beforefieldinit'.
				static BatchUpdateRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "BatchUpdateRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateValuesRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663455);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663456);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663457);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateValuesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663458);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateValuesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663459);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663460);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663461);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663462);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663463);
					SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr, 100663464);
				}

				// Token: 0x060012AC RID: 4780 RVA: 0x00052F60 File Offset: 0x00051160
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118368, XrefRangeEnd = 1118373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BatchUpdateRequest(IClientService service, BatchUpdateValuesRequest body, string spreadsheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateValuesRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700080D RID: 2061
				// (get) Token: 0x060012AD RID: 4781 RVA: 0x00052FD0 File Offset: 0x000511D0
				// (set) Token: 0x060012AE RID: 4782 RVA: 0x00053014 File Offset: 0x00051214
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700080E RID: 2062
				// (get) Token: 0x060012AF RID: 4783 RVA: 0x00053058 File Offset: 0x00051258
				// (set) Token: 0x060012B0 RID: 4784 RVA: 0x00053098 File Offset: 0x00051298
				public unsafe BatchUpdateValuesRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateValuesRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<BatchUpdateValuesRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateValuesRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060012B1 RID: 4785 RVA: 0x000530DC File Offset: 0x000512DC
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x1700080F RID: 2063
				// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00053128 File Offset: 0x00051328
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118373, XrefRangeEnd = 1118375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000810 RID: 2064
				// (get) Token: 0x060012B3 RID: 4787 RVA: 0x0005316C File Offset: 0x0005136C
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118375, XrefRangeEnd = 1118377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000811 RID: 2065
				// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000531B0 File Offset: 0x000513B0
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118377, XrefRangeEnd = 1118379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060012B5 RID: 4789 RVA: 0x000531F4 File Offset: 0x000513F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118379, XrefRangeEnd = 1118399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060012B6 RID: 4790 RVA: 0x0000AD68 File Offset: 0x00008F68
				public BatchUpdateRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700080B RID: 2059
				// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00053230 File Offset: 0x00051430
				// (set) Token: 0x060012B8 RID: 4792 RVA: 0x0000AD71 File Offset: 0x00008F71
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700080C RID: 2060
				// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00053258 File Offset: 0x00051458
				// (set) Token: 0x060012BA RID: 4794 RVA: 0x0000AD90 File Offset: 0x00008F90
				public unsafe BatchUpdateValuesRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchUpdateValuesRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000CFA RID: 3322
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000CFB RID: 3323
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000CFC RID: 3324
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateValuesRequest_String_0;

				// Token: 0x04000CFD RID: 3325
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000CFE RID: 3326
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000CFF RID: 3327
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateValuesRequest_0;

				// Token: 0x04000D00 RID: 3328
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateValuesRequest_0;

				// Token: 0x04000D01 RID: 3329
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000D02 RID: 3330
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000D03 RID: 3331
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000D04 RID: 3332
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000D05 RID: 3333
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}

			// Token: 0x020000E4 RID: 228
			public class BatchUpdateByDataFilterRequest : SheetsBaseServiceRequest<BatchUpdateValuesByDataFilterResponse>
			{
				// Token: 0x060012BB RID: 4795 RVA: 0x00053288 File Offset: 0x00051488
				// Note: this type is marked as 'beforefieldinit'.
				static BatchUpdateByDataFilterRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "BatchUpdateByDataFilterRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateValuesByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663465);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663466);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663467);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateValuesByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663468);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateValuesByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663469);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663470);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663471);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663472);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663473);
					SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr, 100663474);
				}

				// Token: 0x060012BC RID: 4796 RVA: 0x000533A4 File Offset: 0x000515A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118399, XrefRangeEnd = 1118404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BatchUpdateByDataFilterRequest(IClientService service, BatchUpdateValuesByDataFilterRequest body, string spreadsheetId)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateValuesByDataFilterRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000814 RID: 2068
				// (get) Token: 0x060012BD RID: 4797 RVA: 0x00053414 File Offset: 0x00051614
				// (set) Token: 0x060012BE RID: 4798 RVA: 0x00053458 File Offset: 0x00051658
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000815 RID: 2069
				// (get) Token: 0x060012BF RID: 4799 RVA: 0x0005349C File Offset: 0x0005169C
				// (set) Token: 0x060012C0 RID: 4800 RVA: 0x000534DC File Offset: 0x000516DC
				public unsafe BatchUpdateValuesByDataFilterRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateValuesByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<BatchUpdateValuesByDataFilterRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateValuesByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060012C1 RID: 4801 RVA: 0x00053520 File Offset: 0x00051720
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x17000816 RID: 2070
				// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0005356C File Offset: 0x0005176C
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118404, XrefRangeEnd = 1118406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000817 RID: 2071
				// (get) Token: 0x060012C3 RID: 4803 RVA: 0x000535B0 File Offset: 0x000517B0
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118406, XrefRangeEnd = 1118408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000818 RID: 2072
				// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000535F4 File Offset: 0x000517F4
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118408, XrefRangeEnd = 1118410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060012C5 RID: 4805 RVA: 0x00053638 File Offset: 0x00051838
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118410, XrefRangeEnd = 1118430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060012C6 RID: 4806 RVA: 0x0000ADAF File Offset: 0x00008FAF
				public BatchUpdateByDataFilterRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000812 RID: 2066
				// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00053674 File Offset: 0x00051874
				// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0000ADB8 File Offset: 0x00008FB8
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000813 RID: 2067
				// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0005369C File Offset: 0x0005189C
				// (set) Token: 0x060012CA RID: 4810 RVA: 0x0000ADD7 File Offset: 0x00008FD7
				public unsafe BatchUpdateValuesByDataFilterRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchUpdateValuesByDataFilterRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.BatchUpdateByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000D06 RID: 3334
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000D07 RID: 3335
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000D08 RID: 3336
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateValuesByDataFilterRequest_String_0;

				// Token: 0x04000D09 RID: 3337
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000D0A RID: 3338
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000D0B RID: 3339
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateValuesByDataFilterRequest_0;

				// Token: 0x04000D0C RID: 3340
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateValuesByDataFilterRequest_0;

				// Token: 0x04000D0D RID: 3341
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000D0E RID: 3342
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000D0F RID: 3343
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000D10 RID: 3344
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000D11 RID: 3345
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}

			// Token: 0x020000E5 RID: 229
			public class ClearRequest : SheetsBaseServiceRequest<ClearValuesResponse>
			{
				// Token: 0x060012CB RID: 4811 RVA: 0x000536CC File Offset: 0x000518CC
				// Note: this type is marked as 'beforefieldinit'.
				static ClearRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "ClearRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, "<Range>k__BackingField");
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_ClearValuesRequest_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663475);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663476);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663477);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663478);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663479);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_Body_Private_get_ClearValuesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663480);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_ClearValuesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663481);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663482);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663483);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663484);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663485);
					SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr, 100663486);
				}

				// Token: 0x060012CC RID: 4812 RVA: 0x00053824 File Offset: 0x00051A24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118430, XrefRangeEnd = 1118436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ClearRequest(IClientService service, ClearValuesRequest body, string spreadsheetId, string range)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.ClearRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_ClearValuesRequest_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700081C RID: 2076
				// (get) Token: 0x060012CD RID: 4813 RVA: 0x000538A8 File Offset: 0x00051AA8
				// (set) Token: 0x060012CE RID: 4814 RVA: 0x000538EC File Offset: 0x00051AEC
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700081D RID: 2077
				// (get) Token: 0x060012CF RID: 4815 RVA: 0x00053930 File Offset: 0x00051B30
				// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00053974 File Offset: 0x00051B74
				public unsafe virtual string Range
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700081E RID: 2078
				// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000539B8 File Offset: 0x00051BB8
				// (set) Token: 0x060012D2 RID: 4818 RVA: 0x000539F8 File Offset: 0x00051BF8
				public unsafe ClearValuesRequest Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_Body_Private_get_ClearValuesRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClearValuesRequest>(intPtr3) : null;
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_ClearValuesRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060012D3 RID: 4819 RVA: 0x00053A3C File Offset: 0x00051C3C
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x1700081F RID: 2079
				// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00053A88 File Offset: 0x00051C88
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118436, XrefRangeEnd = 1118438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000820 RID: 2080
				// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00053ACC File Offset: 0x00051CCC
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118438, XrefRangeEnd = 1118440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17000821 RID: 2081
				// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00053B10 File Offset: 0x00051D10
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118440, XrefRangeEnd = 1118442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060012D7 RID: 4823 RVA: 0x00053B54 File Offset: 0x00051D54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118442, XrefRangeEnd = 1118475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.ClearRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060012D8 RID: 4824 RVA: 0x0000ADF6 File Offset: 0x00008FF6
				public ClearRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000819 RID: 2073
				// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00053B90 File Offset: 0x00051D90
				// (set) Token: 0x060012DA RID: 4826 RVA: 0x0000ADFF File Offset: 0x00008FFF
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700081A RID: 2074
				// (get) Token: 0x060012DB RID: 4827 RVA: 0x00053BB8 File Offset: 0x00051DB8
				// (set) Token: 0x060012DC RID: 4828 RVA: 0x0000AE1E File Offset: 0x0000901E
				public unsafe string _Range_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__Range_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700081B RID: 2075
				// (get) Token: 0x060012DD RID: 4829 RVA: 0x00053BE0 File Offset: 0x00051DE0
				// (set) Token: 0x060012DE RID: 4830 RVA: 0x0000AE3D File Offset: 0x0000903D
				public unsafe ClearValuesRequest _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearValuesRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.ClearRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000D12 RID: 3346
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000D13 RID: 3347
				private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

				// Token: 0x04000D14 RID: 3348
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000D15 RID: 3349
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_ClearValuesRequest_String_String_0;

				// Token: 0x04000D16 RID: 3350
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000D17 RID: 3351
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000D18 RID: 3352
				private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0;

				// Token: 0x04000D19 RID: 3353
				private static readonly IntPtr NativeMethodInfoPtr_set_Range_Private_set_Void_String_0;

				// Token: 0x04000D1A RID: 3354
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_ClearValuesRequest_0;

				// Token: 0x04000D1B RID: 3355
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_ClearValuesRequest_0;

				// Token: 0x04000D1C RID: 3356
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000D1D RID: 3357
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000D1E RID: 3358
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000D1F RID: 3359
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000D20 RID: 3360
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
			}

			// Token: 0x020000E6 RID: 230
			public class GetRequest : SheetsBaseServiceRequest<ValueRange>
			{
				// Token: 0x060012DF RID: 4831 RVA: 0x00053C10 File Offset: 0x00051E10
				// Note: this type is marked as 'beforefieldinit'.
				static GetRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "GetRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, "<Range>k__BackingField");
					SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, "<DateTimeRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, "<MajorDimension>k__BackingField");
					SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, "<ValueRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663487);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663488);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663489);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663490);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663491);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_Nullable_1_DateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663492);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_DateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663493);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_Nullable_1_MajorDimensionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663494);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_Nullable_1_MajorDimensionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663495);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_Nullable_1_ValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663496);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663497);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663498);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663499);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663500);
					SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr, 100663501);
				}

				// Token: 0x060012E0 RID: 4832 RVA: 0x00053DCC File Offset: 0x00051FCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118475, XrefRangeEnd = 1118480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetRequest(IClientService service, string spreadsheetId, string range)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.GetRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000827 RID: 2087
				// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00053E3C File Offset: 0x0005203C
				// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00053E80 File Offset: 0x00052080
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000828 RID: 2088
				// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00053EC4 File Offset: 0x000520C4
				// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00053F08 File Offset: 0x00052108
				public unsafe virtual string Range
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000829 RID: 2089
				// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00053F4C File Offset: 0x0005214C
				// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00053F90 File Offset: 0x00052190
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum> DateTimeRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_Nullable_1_DateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_DateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700082A RID: 2090
				// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00053FE4 File Offset: 0x000521E4
				// (set) Token: 0x060012E8 RID: 4840 RVA: 0x00054028 File Offset: 0x00052228
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.GetRequest.MajorDimensionEnum> MajorDimension
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_Nullable_1_MajorDimensionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.GetRequest.MajorDimensionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_Nullable_1_MajorDimensionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700082B RID: 2091
				// (get) Token: 0x060012E9 RID: 4841 RVA: 0x0005407C File Offset: 0x0005227C
				// (set) Token: 0x060012EA RID: 4842 RVA: 0x000540C0 File Offset: 0x000522C0
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum> ValueRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_Nullable_1_ValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700082C RID: 2092
				// (get) Token: 0x060012EB RID: 4843 RVA: 0x00054114 File Offset: 0x00052314
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118480, XrefRangeEnd = 1118482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x1700082D RID: 2093
				// (get) Token: 0x060012EC RID: 4844 RVA: 0x00054158 File Offset: 0x00052358
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118482, XrefRangeEnd = 1118484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x1700082E RID: 2094
				// (get) Token: 0x060012ED RID: 4845 RVA: 0x0005419C File Offset: 0x0005239C
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118484, XrefRangeEnd = 1118486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060012EE RID: 4846 RVA: 0x000541E0 File Offset: 0x000523E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118486, XrefRangeEnd = 1118559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.GetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060012EF RID: 4847 RVA: 0x0000AE5C File Offset: 0x0000905C
				public GetRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000822 RID: 2082
				// (get) Token: 0x060012F0 RID: 4848 RVA: 0x0005421C File Offset: 0x0005241C
				// (set) Token: 0x060012F1 RID: 4849 RVA: 0x0000AE65 File Offset: 0x00009065
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000823 RID: 2083
				// (get) Token: 0x060012F2 RID: 4850 RVA: 0x00054244 File Offset: 0x00052444
				// (set) Token: 0x060012F3 RID: 4851 RVA: 0x0000AE84 File Offset: 0x00009084
				public unsafe string _Range_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__Range_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000824 RID: 2084
				// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0005426C File Offset: 0x0005246C
				// (set) Token: 0x060012F5 RID: 4853 RVA: 0x0000AEA3 File Offset: 0x000090A3
				public Nullable<SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum> _DateTimeRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000825 RID: 2085
				// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0005429C File Offset: 0x0005249C
				// (set) Token: 0x060012F7 RID: 4855 RVA: 0x0000AED1 File Offset: 0x000090D1
				public Nullable<SpreadsheetsResource.ValuesResource.GetRequest.MajorDimensionEnum> _MajorDimension_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.GetRequest.MajorDimensionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.GetRequest.MajorDimensionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__MajorDimension_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.GetRequest.MajorDimensionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000826 RID: 2086
				// (get) Token: 0x060012F8 RID: 4856 RVA: 0x000542CC File Offset: 0x000524CC
				// (set) Token: 0x060012F9 RID: 4857 RVA: 0x0000AEFF File Offset: 0x000090FF
				public Nullable<SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum> _ValueRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.GetRequest.NativeFieldInfoPtr__ValueRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x04000D21 RID: 3361
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000D22 RID: 3362
				private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

				// Token: 0x04000D23 RID: 3363
				private static readonly IntPtr NativeFieldInfoPtr__DateTimeRenderOption_k__BackingField;

				// Token: 0x04000D24 RID: 3364
				private static readonly IntPtr NativeFieldInfoPtr__MajorDimension_k__BackingField;

				// Token: 0x04000D25 RID: 3365
				private static readonly IntPtr NativeFieldInfoPtr__ValueRenderOption_k__BackingField;

				// Token: 0x04000D26 RID: 3366
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_String_0;

				// Token: 0x04000D27 RID: 3367
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000D28 RID: 3368
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000D29 RID: 3369
				private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0;

				// Token: 0x04000D2A RID: 3370
				private static readonly IntPtr NativeMethodInfoPtr_set_Range_Private_set_Void_String_0;

				// Token: 0x04000D2B RID: 3371
				private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeRenderOption_Public_Virtual_New_get_Nullable_1_DateTimeRenderOptionEnum_0;

				// Token: 0x04000D2C RID: 3372
				private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_DateTimeRenderOptionEnum_0;

				// Token: 0x04000D2D RID: 3373
				private static readonly IntPtr NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_Nullable_1_MajorDimensionEnum_0;

				// Token: 0x04000D2E RID: 3374
				private static readonly IntPtr NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_Nullable_1_MajorDimensionEnum_0;

				// Token: 0x04000D2F RID: 3375
				private static readonly IntPtr NativeMethodInfoPtr_get_ValueRenderOption_Public_Virtual_New_get_Nullable_1_ValueRenderOptionEnum_0;

				// Token: 0x04000D30 RID: 3376
				private static readonly IntPtr NativeMethodInfoPtr_set_ValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ValueRenderOptionEnum_0;

				// Token: 0x04000D31 RID: 3377
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000D32 RID: 3378
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000D33 RID: 3379
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000D34 RID: 3380
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;

				// Token: 0x020000EF RID: 239
				public enum DateTimeRenderOptionEnum
				{
					// Token: 0x04000D6A RID: 3434
					SERIALNUMBER,
					// Token: 0x04000D6B RID: 3435
					FORMATTEDSTRING
				}

				// Token: 0x020000F0 RID: 240
				public enum MajorDimensionEnum
				{
					// Token: 0x04000D6D RID: 3437
					DIMENSIONUNSPECIFIED,
					// Token: 0x04000D6E RID: 3438
					ROWS,
					// Token: 0x04000D6F RID: 3439
					COLUMNS
				}

				// Token: 0x020000F1 RID: 241
				public enum ValueRenderOptionEnum
				{
					// Token: 0x04000D71 RID: 3441
					FORMATTEDVALUE,
					// Token: 0x04000D72 RID: 3442
					UNFORMATTEDVALUE,
					// Token: 0x04000D73 RID: 3443
					FORMULA
				}
			}

			// Token: 0x020000E7 RID: 231
			public class UpdateRequest : SheetsBaseServiceRequest<UpdateValuesResponse>
			{
				// Token: 0x060012FA RID: 4858 RVA: 0x000542FC File Offset: 0x000524FC
				// Note: this type is marked as 'beforefieldinit'.
				static UpdateRequest()
				{
					Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource>.NativeClassPtr, "UpdateRequest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, "<Range>k__BackingField");
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, "<IncludeValuesInResponse>k__BackingField");
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, "<ResponseDateTimeRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, "<ResponseValueRenderOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, "<ValueInputOption>k__BackingField");
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, "<Body>k__BackingField");
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_ValueRange_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663502);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663503);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663504);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663505);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663506);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663507);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663508);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_Nullable_1_ResponseDateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663509);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseDateTimeRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663510);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_Nullable_1_ResponseValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663511);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseValueRenderOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663512);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_Nullable_1_ValueInputOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663513);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_Nullable_1_ValueInputOptionEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663514);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_Body_Private_get_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663515);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663516);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663517);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663518);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663519);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663520);
					SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr, 100663521);
				}

				// Token: 0x060012FB RID: 4859 RVA: 0x00054544 File Offset: 0x00052744
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118559, XrefRangeEnd = 1118565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdateRequest(IClientService service, ValueRange body, string spreadsheetId, string range)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.ValuesResource.UpdateRequest>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(range);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_ValueRange_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000836 RID: 2102
				// (get) Token: 0x060012FC RID: 4860 RVA: 0x000545C8 File Offset: 0x000527C8
				// (set) Token: 0x060012FD RID: 4861 RVA: 0x0005460C File Offset: 0x0005280C
				public unsafe virtual string SpreadsheetId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000837 RID: 2103
				// (get) Token: 0x060012FE RID: 4862 RVA: 0x00054650 File Offset: 0x00052850
				// (set) Token: 0x060012FF RID: 4863 RVA: 0x00054694 File Offset: 0x00052894
				public unsafe virtual string Range
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_Range_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000838 RID: 2104
				// (get) Token: 0x06001300 RID: 4864 RVA: 0x000546D8 File Offset: 0x000528D8
				// (set) Token: 0x06001301 RID: 4865 RVA: 0x0005471C File Offset: 0x0005291C
				public unsafe virtual Nullable<bool> IncludeValuesInResponse
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000839 RID: 2105
				// (get) Token: 0x06001302 RID: 4866 RVA: 0x00054770 File Offset: 0x00052970
				// (set) Token: 0x06001303 RID: 4867 RVA: 0x000547B4 File Offset: 0x000529B4
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseDateTimeRenderOptionEnum> ResponseDateTimeRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_Nullable_1_ResponseDateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseDateTimeRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseDateTimeRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700083A RID: 2106
				// (get) Token: 0x06001304 RID: 4868 RVA: 0x00054808 File Offset: 0x00052A08
				// (set) Token: 0x06001305 RID: 4869 RVA: 0x0005484C File Offset: 0x00052A4C
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseValueRenderOptionEnum> ResponseValueRenderOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_Nullable_1_ResponseValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseValueRenderOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseValueRenderOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700083B RID: 2107
				// (get) Token: 0x06001306 RID: 4870 RVA: 0x000548A0 File Offset: 0x00052AA0
				// (set) Token: 0x06001307 RID: 4871 RVA: 0x000548E4 File Offset: 0x00052AE4
				public unsafe virtual Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum> ValueInputOption
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_Nullable_1_ValueInputOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum>(intPtr);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_Nullable_1_ValueInputOptionEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700083C RID: 2108
				// (get) Token: 0x06001308 RID: 4872 RVA: 0x00054938 File Offset: 0x00052B38
				// (set) Token: 0x06001309 RID: 4873 RVA: 0x00054978 File Offset: 0x00052B78
				public unsafe ValueRange Body
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_Body_Private_get_ValueRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_ValueRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x0600130A RID: 4874 RVA: 0x000549BC File Offset: 0x00052BBC
				[CallerCount(0)]
				public unsafe override Object GetBody()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x1700083D RID: 2109
				// (get) Token: 0x0600130B RID: 4875 RVA: 0x00054A08 File Offset: 0x00052C08
				public unsafe override string MethodName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118565, XrefRangeEnd = 1118567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x1700083E RID: 2110
				// (get) Token: 0x0600130C RID: 4876 RVA: 0x00054A4C File Offset: 0x00052C4C
				public unsafe override string HttpMethod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118567, XrefRangeEnd = 1118569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x1700083F RID: 2111
				// (get) Token: 0x0600130D RID: 4877 RVA: 0x00054A90 File Offset: 0x00052C90
				public unsafe override string RestPath
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118569, XrefRangeEnd = 1118571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600130E RID: 4878 RVA: 0x00054AD4 File Offset: 0x00052CD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118571, XrefRangeEnd = 1118657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void InitParameters()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.ValuesResource.UpdateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600130F RID: 4879 RVA: 0x0000AF2D File Offset: 0x0000912D
				public UpdateRequest(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700082F RID: 2095
				// (get) Token: 0x06001310 RID: 4880 RVA: 0x00054B10 File Offset: 0x00052D10
				// (set) Token: 0x06001311 RID: 4881 RVA: 0x0000AF36 File Offset: 0x00009136
				public unsafe string _SpreadsheetId_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000830 RID: 2096
				// (get) Token: 0x06001312 RID: 4882 RVA: 0x00054B38 File Offset: 0x00052D38
				// (set) Token: 0x06001313 RID: 4883 RVA: 0x0000AF55 File Offset: 0x00009155
				public unsafe string _Range_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__Range_k__BackingField);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000831 RID: 2097
				// (get) Token: 0x06001314 RID: 4884 RVA: 0x00054B60 File Offset: 0x00052D60
				// (set) Token: 0x06001315 RID: 4885 RVA: 0x0000AF74 File Offset: 0x00009174
				public Nullable<bool> _IncludeValuesInResponse_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField);
						return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000832 RID: 2098
				// (get) Token: 0x06001316 RID: 4886 RVA: 0x00054B90 File Offset: 0x00052D90
				// (set) Token: 0x06001317 RID: 4887 RVA: 0x0000AFA2 File Offset: 0x000091A2
				public Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseDateTimeRenderOptionEnum> _ResponseDateTimeRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseDateTimeRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseDateTimeRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseDateTimeRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000833 RID: 2099
				// (get) Token: 0x06001318 RID: 4888 RVA: 0x00054BC0 File Offset: 0x00052DC0
				// (set) Token: 0x06001319 RID: 4889 RVA: 0x0000AFD0 File Offset: 0x000091D0
				public Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseValueRenderOptionEnum> _ResponseValueRenderOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseValueRenderOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseValueRenderOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ResponseValueRenderOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000834 RID: 2100
				// (get) Token: 0x0600131A RID: 4890 RVA: 0x00054BF0 File Offset: 0x00052DF0
				// (set) Token: 0x0600131B RID: 4891 RVA: 0x0000AFFE File Offset: 0x000091FE
				public Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum> _ValueInputOption_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField);
						return new Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000835 RID: 2101
				// (get) Token: 0x0600131C RID: 4892 RVA: 0x00054C20 File Offset: 0x00052E20
				// (set) Token: 0x0600131D RID: 4893 RVA: 0x0000B02C File Offset: 0x0000922C
				public unsafe ValueRange _Body_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__Body_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueRange>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.ValuesResource.UpdateRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000D35 RID: 3381
				private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

				// Token: 0x04000D36 RID: 3382
				private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

				// Token: 0x04000D37 RID: 3383
				private static readonly IntPtr NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField;

				// Token: 0x04000D38 RID: 3384
				private static readonly IntPtr NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField;

				// Token: 0x04000D39 RID: 3385
				private static readonly IntPtr NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField;

				// Token: 0x04000D3A RID: 3386
				private static readonly IntPtr NativeFieldInfoPtr__ValueInputOption_k__BackingField;

				// Token: 0x04000D3B RID: 3387
				private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

				// Token: 0x04000D3C RID: 3388
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_ValueRange_String_String_0;

				// Token: 0x04000D3D RID: 3389
				private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

				// Token: 0x04000D3E RID: 3390
				private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

				// Token: 0x04000D3F RID: 3391
				private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_String_0;

				// Token: 0x04000D40 RID: 3392
				private static readonly IntPtr NativeMethodInfoPtr_set_Range_Private_set_Void_String_0;

				// Token: 0x04000D41 RID: 3393
				private static readonly IntPtr NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0;

				// Token: 0x04000D42 RID: 3394
				private static readonly IntPtr NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

				// Token: 0x04000D43 RID: 3395
				private static readonly IntPtr NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_Nullable_1_ResponseDateTimeRenderOptionEnum_0;

				// Token: 0x04000D44 RID: 3396
				private static readonly IntPtr NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseDateTimeRenderOptionEnum_0;

				// Token: 0x04000D45 RID: 3397
				private static readonly IntPtr NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_Nullable_1_ResponseValueRenderOptionEnum_0;

				// Token: 0x04000D46 RID: 3398
				private static readonly IntPtr NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_Nullable_1_ResponseValueRenderOptionEnum_0;

				// Token: 0x04000D47 RID: 3399
				private static readonly IntPtr NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_Nullable_1_ValueInputOptionEnum_0;

				// Token: 0x04000D48 RID: 3400
				private static readonly IntPtr NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_Nullable_1_ValueInputOptionEnum_0;

				// Token: 0x04000D49 RID: 3401
				private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_ValueRange_0;

				// Token: 0x04000D4A RID: 3402
				private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_ValueRange_0;

				// Token: 0x04000D4B RID: 3403
				private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

				// Token: 0x04000D4C RID: 3404
				private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

				// Token: 0x04000D4D RID: 3405
				private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

				// Token: 0x04000D4E RID: 3406
				private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

				// Token: 0x04000D4F RID: 3407
				private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;

				// Token: 0x020000F2 RID: 242
				public enum ResponseDateTimeRenderOptionEnum
				{
					// Token: 0x04000D75 RID: 3445
					SERIALNUMBER,
					// Token: 0x04000D76 RID: 3446
					FORMATTEDSTRING
				}

				// Token: 0x020000F3 RID: 243
				public enum ResponseValueRenderOptionEnum
				{
					// Token: 0x04000D78 RID: 3448
					FORMATTEDVALUE,
					// Token: 0x04000D79 RID: 3449
					UNFORMATTEDVALUE,
					// Token: 0x04000D7A RID: 3450
					FORMULA
				}

				// Token: 0x020000F4 RID: 244
				public enum ValueInputOptionEnum
				{
					// Token: 0x04000D7C RID: 3452
					INPUTVALUEOPTIONUNSPECIFIED,
					// Token: 0x04000D7D RID: 3453
					RAW,
					// Token: 0x04000D7E RID: 3454
					USERENTERED
				}
			}
		}

		// Token: 0x020000D7 RID: 215
		public class BatchUpdateRequest : SheetsBaseServiceRequest<BatchUpdateSpreadsheetResponse>
		{
			// Token: 0x060011C6 RID: 4550 RVA: 0x0004F208 File Offset: 0x0004D408
			// Note: this type is marked as 'beforefieldinit'.
			static BatchUpdateRequest()
			{
				Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "BatchUpdateRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr);
				SpreadsheetsResource.BatchUpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
				SpreadsheetsResource.BatchUpdateRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, "<Body>k__BackingField");
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateSpreadsheetRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663522);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663523);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663524);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateSpreadsheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663525);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateSpreadsheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663526);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663527);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663528);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663529);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663530);
				SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr, 100663531);
			}

			// Token: 0x060011C7 RID: 4551 RVA: 0x0004F324 File Offset: 0x0004D524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118739, XrefRangeEnd = 1118744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BatchUpdateRequest(IClientService service, BatchUpdateSpreadsheetRequest body, string spreadsheetId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.BatchUpdateRequest>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateSpreadsheetRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0004F394 File Offset: 0x0004D594
			// (set) Token: 0x060011C9 RID: 4553 RVA: 0x0004F3D8 File Offset: 0x0004D5D8
			public unsafe virtual string SpreadsheetId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x060011CA RID: 4554 RVA: 0x0004F41C File Offset: 0x0004D61C
			// (set) Token: 0x060011CB RID: 4555 RVA: 0x0004F45C File Offset: 0x0004D65C
			public unsafe BatchUpdateSpreadsheetRequest Body
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateSpreadsheetRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BatchUpdateSpreadsheetRequest>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateSpreadsheetRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060011CC RID: 4556 RVA: 0x0004F4A0 File Offset: 0x0004D6A0
			[CallerCount(0)]
			public unsafe override Object GetBody()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x060011CD RID: 4557 RVA: 0x0004F4EC File Offset: 0x0004D6EC
			public unsafe override string MethodName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118744, XrefRangeEnd = 1118746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x060011CE RID: 4558 RVA: 0x0004F530 File Offset: 0x0004D730
			public unsafe override string HttpMethod
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118746, XrefRangeEnd = 1118748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x060011CF RID: 4559 RVA: 0x0004F574 File Offset: 0x0004D774
			public unsafe override string RestPath
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118748, XrefRangeEnd = 1118750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011D0 RID: 4560 RVA: 0x0004F5B8 File Offset: 0x0004D7B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118750, XrefRangeEnd = 1118770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void InitParameters()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.BatchUpdateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011D1 RID: 4561 RVA: 0x0000A85F File Offset: 0x00008A5F
			public BatchUpdateRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0004F5F4 File Offset: 0x0004D7F4
			// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0000A868 File Offset: 0x00008A68
			public unsafe string _SpreadsheetId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.BatchUpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.BatchUpdateRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0004F61C File Offset: 0x0004D81C
			// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0000A887 File Offset: 0x00008A87
			public unsafe BatchUpdateSpreadsheetRequest _Body_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.BatchUpdateRequest.NativeFieldInfoPtr__Body_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchUpdateSpreadsheetRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.BatchUpdateRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C4F RID: 3151
			private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

			// Token: 0x04000C50 RID: 3152
			private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

			// Token: 0x04000C51 RID: 3153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_BatchUpdateSpreadsheetRequest_String_0;

			// Token: 0x04000C52 RID: 3154
			private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

			// Token: 0x04000C53 RID: 3155
			private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

			// Token: 0x04000C54 RID: 3156
			private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_BatchUpdateSpreadsheetRequest_0;

			// Token: 0x04000C55 RID: 3157
			private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_BatchUpdateSpreadsheetRequest_0;

			// Token: 0x04000C56 RID: 3158
			private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

			// Token: 0x04000C57 RID: 3159
			private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

			// Token: 0x04000C58 RID: 3160
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

			// Token: 0x04000C59 RID: 3161
			private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

			// Token: 0x04000C5A RID: 3162
			private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
		}

		// Token: 0x020000D8 RID: 216
		public class CreateRequest : SheetsBaseServiceRequest<Spreadsheet>
		{
			// Token: 0x060011D6 RID: 4566 RVA: 0x0004F64C File Offset: 0x0004D84C
			// Note: this type is marked as 'beforefieldinit'.
			static CreateRequest()
			{
				Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "CreateRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr);
				SpreadsheetsResource.CreateRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, "<Body>k__BackingField");
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_Spreadsheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663532);
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_Body_Private_get_Spreadsheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663533);
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_Spreadsheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663534);
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663535);
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663536);
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663537);
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663538);
				SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr, 100663539);
			}

			// Token: 0x060011D7 RID: 4567 RVA: 0x0004F72C File Offset: 0x0004D92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118770, XrefRangeEnd = 1118774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateRequest(IClientService service, Spreadsheet body)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.CreateRequest>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_Spreadsheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0004F78C File Offset: 0x0004D98C
			// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0004F7CC File Offset: 0x0004D9CC
			public unsafe Spreadsheet Body
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_Body_Private_get_Spreadsheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_Spreadsheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060011DA RID: 4570 RVA: 0x0004F810 File Offset: 0x0004DA10
			[CallerCount(0)]
			public unsafe override Object GetBody()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x060011DB RID: 4571 RVA: 0x0004F85C File Offset: 0x0004DA5C
			public unsafe override string MethodName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118774, XrefRangeEnd = 1118776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x060011DC RID: 4572 RVA: 0x0004F8A0 File Offset: 0x0004DAA0
			public unsafe override string HttpMethod
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118776, XrefRangeEnd = 1118778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x060011DD RID: 4573 RVA: 0x0004F8E4 File Offset: 0x0004DAE4
			public unsafe override string RestPath
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118778, XrefRangeEnd = 1118780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011DE RID: 4574 RVA: 0x0004F928 File Offset: 0x0004DB28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118780, XrefRangeEnd = 1118783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void InitParameters()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.CreateRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011DF RID: 4575 RVA: 0x0000A8A6 File Offset: 0x00008AA6
			public CreateRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0004F964 File Offset: 0x0004DB64
			// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0000A8AF File Offset: 0x00008AAF
			public unsafe Spreadsheet _Body_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.CreateRequest.NativeFieldInfoPtr__Body_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spreadsheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.CreateRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C5B RID: 3163
			private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

			// Token: 0x04000C5C RID: 3164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_Spreadsheet_0;

			// Token: 0x04000C5D RID: 3165
			private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_Spreadsheet_0;

			// Token: 0x04000C5E RID: 3166
			private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_Spreadsheet_0;

			// Token: 0x04000C5F RID: 3167
			private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

			// Token: 0x04000C60 RID: 3168
			private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

			// Token: 0x04000C61 RID: 3169
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

			// Token: 0x04000C62 RID: 3170
			private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

			// Token: 0x04000C63 RID: 3171
			private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
		}

		// Token: 0x020000D9 RID: 217
		public class GetRequest : SheetsBaseServiceRequest<Spreadsheet>
		{
			// Token: 0x060011E2 RID: 4578 RVA: 0x0004F994 File Offset: 0x0004DB94
			// Note: this type is marked as 'beforefieldinit'.
			static GetRequest()
			{
				Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "GetRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr);
				SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
				SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__IncludeGridData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, "<IncludeGridData>k__BackingField");
				SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__Ranges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, "<Ranges>k__BackingField");
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663540);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663541);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663542);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_IncludeGridData_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663543);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_set_IncludeGridData_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663544);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_Repeatable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663545);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_Repeatable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663546);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663547);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663548);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663549);
				SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr, 100663550);
			}

			// Token: 0x060011E3 RID: 4579 RVA: 0x0004FAD8 File Offset: 0x0004DCD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118783, XrefRangeEnd = 1118787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRequest(IClientService service, string spreadsheetId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.GetRequest>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.GetRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0004FB38 File Offset: 0x0004DD38
			// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0004FB7C File Offset: 0x0004DD7C
			public unsafe virtual string SpreadsheetId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0004FBC0 File Offset: 0x0004DDC0
			// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0004FC04 File Offset: 0x0004DE04
			public unsafe virtual Nullable<bool> IncludeGridData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_IncludeGridData_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_set_IncludeGridData_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0004FC58 File Offset: 0x0004DE58
			// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0004FCA4 File Offset: 0x0004DEA4
			public unsafe virtual Repeatable<string> Ranges
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_Repeatable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Repeatable<string>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_Repeatable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004FCF4 File Offset: 0x0004DEF4
			public unsafe override string MethodName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118787, XrefRangeEnd = 1118789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x060011EB RID: 4587 RVA: 0x0004FD38 File Offset: 0x0004DF38
			public unsafe override string HttpMethod
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118789, XrefRangeEnd = 1118791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x060011EC RID: 4588 RVA: 0x0004FD7C File Offset: 0x0004DF7C
			public unsafe override string RestPath
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118791, XrefRangeEnd = 1118793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011ED RID: 4589 RVA: 0x0004FDC0 File Offset: 0x0004DFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118793, XrefRangeEnd = 1118840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void InitParameters()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011EE RID: 4590 RVA: 0x0000A8CE File Offset: 0x00008ACE
			public GetRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x060011EF RID: 4591 RVA: 0x0004FDFC File Offset: 0x0004DFFC
			// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0000A8D7 File Offset: 0x00008AD7
			public unsafe string _SpreadsheetId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0004FE24 File Offset: 0x0004E024
			// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0000A8F6 File Offset: 0x00008AF6
			public Nullable<bool> _IncludeGridData_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__IncludeGridData_k__BackingField);
					return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__IncludeGridData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0004FE54 File Offset: 0x0004E054
			// (set) Token: 0x060011F4 RID: 4596 RVA: 0x0000A924 File Offset: 0x00008B24
			public unsafe Repeatable<string> _Ranges_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__Ranges_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Repeatable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetRequest.NativeFieldInfoPtr__Ranges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C64 RID: 3172
			private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

			// Token: 0x04000C65 RID: 3173
			private static readonly IntPtr NativeFieldInfoPtr__IncludeGridData_k__BackingField;

			// Token: 0x04000C66 RID: 3174
			private static readonly IntPtr NativeFieldInfoPtr__Ranges_k__BackingField;

			// Token: 0x04000C67 RID: 3175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0;

			// Token: 0x04000C68 RID: 3176
			private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

			// Token: 0x04000C69 RID: 3177
			private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

			// Token: 0x04000C6A RID: 3178
			private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGridData_Public_Virtual_New_get_Nullable_1_Boolean_0;

			// Token: 0x04000C6B RID: 3179
			private static readonly IntPtr NativeMethodInfoPtr_set_IncludeGridData_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

			// Token: 0x04000C6C RID: 3180
			private static readonly IntPtr NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_Repeatable_1_String_0;

			// Token: 0x04000C6D RID: 3181
			private static readonly IntPtr NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_Repeatable_1_String_0;

			// Token: 0x04000C6E RID: 3182
			private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

			// Token: 0x04000C6F RID: 3183
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

			// Token: 0x04000C70 RID: 3184
			private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

			// Token: 0x04000C71 RID: 3185
			private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
		}

		// Token: 0x020000DA RID: 218
		public class GetByDataFilterRequest : SheetsBaseServiceRequest<Spreadsheet>
		{
			// Token: 0x060011F5 RID: 4597 RVA: 0x0004FE84 File Offset: 0x0004E084
			// Note: this type is marked as 'beforefieldinit'.
			static GetByDataFilterRequest()
			{
				Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpreadsheetsResource>.NativeClassPtr, "GetByDataFilterRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr);
				SpreadsheetsResource.GetByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
				SpreadsheetsResource.GetByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, "<Body>k__BackingField");
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_GetSpreadsheetByDataFilterRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663551);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663552);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663553);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_GetSpreadsheetByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663554);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_GetSpreadsheetByDataFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663555);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663556);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663557);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663558);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663559);
				SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr, 100663560);
			}

			// Token: 0x060011F6 RID: 4598 RVA: 0x0004FFA0 File Offset: 0x0004E1A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118840, XrefRangeEnd = 1118845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetByDataFilterRequest(IClientService service, GetSpreadsheetByDataFilterRequest body, string spreadsheetId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetsResource.GetByDataFilterRequest>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_GetSpreadsheetByDataFilterRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00050010 File Offset: 0x0004E210
			// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00050054 File Offset: 0x0004E254
			public unsafe virtual string SpreadsheetId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00050098 File Offset: 0x0004E298
			// (set) Token: 0x060011FA RID: 4602 RVA: 0x000500D8 File Offset: 0x0004E2D8
			public unsafe GetSpreadsheetByDataFilterRequest Body
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_Body_Private_get_GetSpreadsheetByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetSpreadsheetByDataFilterRequest>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_set_Body_Private_set_Void_GetSpreadsheetByDataFilterRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060011FB RID: 4603 RVA: 0x0005011C File Offset: 0x0004E31C
			[CallerCount(0)]
			public unsafe override Object GetBody()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x060011FC RID: 4604 RVA: 0x00050168 File Offset: 0x0004E368
			public unsafe override string MethodName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118845, XrefRangeEnd = 1118847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x060011FD RID: 4605 RVA: 0x000501AC File Offset: 0x0004E3AC
			public unsafe override string HttpMethod
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118847, XrefRangeEnd = 1118849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x060011FE RID: 4606 RVA: 0x000501F0 File Offset: 0x0004E3F0
			public unsafe override string RestPath
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118849, XrefRangeEnd = 1118851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011FF RID: 4607 RVA: 0x00050234 File Offset: 0x0004E434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118851, XrefRangeEnd = 1118871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void InitParameters()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetsResource.GetByDataFilterRequest.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001200 RID: 4608 RVA: 0x0000A943 File Offset: 0x00008B43
			public GetByDataFilterRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06001201 RID: 4609 RVA: 0x00050270 File Offset: 0x0004E470
			// (set) Token: 0x06001202 RID: 4610 RVA: 0x0000A94C File Offset: 0x00008B4C
			public unsafe string _SpreadsheetId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetByDataFilterRequest.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06001203 RID: 4611 RVA: 0x00050298 File Offset: 0x0004E498
			// (set) Token: 0x06001204 RID: 4612 RVA: 0x0000A96B File Offset: 0x00008B6B
			public unsafe GetSpreadsheetByDataFilterRequest _Body_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetSpreadsheetByDataFilterRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetsResource.GetByDataFilterRequest.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C72 RID: 3186
			private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

			// Token: 0x04000C73 RID: 3187
			private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

			// Token: 0x04000C74 RID: 3188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_GetSpreadsheetByDataFilterRequest_String_0;

			// Token: 0x04000C75 RID: 3189
			private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

			// Token: 0x04000C76 RID: 3190
			private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Private_set_Void_String_0;

			// Token: 0x04000C77 RID: 3191
			private static readonly IntPtr NativeMethodInfoPtr_get_Body_Private_get_GetSpreadsheetByDataFilterRequest_0;

			// Token: 0x04000C78 RID: 3192
			private static readonly IntPtr NativeMethodInfoPtr_set_Body_Private_set_Void_GetSpreadsheetByDataFilterRequest_0;

			// Token: 0x04000C79 RID: 3193
			private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_Object_0;

			// Token: 0x04000C7A RID: 3194
			private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_get_String_0;

			// Token: 0x04000C7B RID: 3195
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Virtual_get_String_0;

			// Token: 0x04000C7C RID: 3196
			private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Virtual_get_String_0;

			// Token: 0x04000C7D RID: 3197
			private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;
		}
	}
}
