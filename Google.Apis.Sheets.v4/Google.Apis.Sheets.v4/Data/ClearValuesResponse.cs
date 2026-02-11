using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000042 RID: 66
	public class ClearValuesResponse : Object
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x0001EE90 File Offset: 0x0001D090
		// Note: this type is marked as 'beforefieldinit'.
		static ClearValuesResponse()
		{
			Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ClearValuesResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr);
			ClearValuesResponse.NativeFieldInfoPtr__ClearedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, "<ClearedRange>k__BackingField");
			ClearValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
			ClearValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, "<ETag>k__BackingField");
			ClearValuesResponse.NativeMethodInfoPtr_get_ClearedRange_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, 100664154);
			ClearValuesResponse.NativeMethodInfoPtr_set_ClearedRange_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, 100664155);
			ClearValuesResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, 100664156);
			ClearValuesResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, 100664157);
			ClearValuesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, 100664158);
			ClearValuesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, 100664159);
			ClearValuesResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr, 100664160);
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001EF88 File Offset: 0x0001D188
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		public unsafe virtual string ClearedRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearValuesResponse.NativeMethodInfoPtr_get_ClearedRange_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearValuesResponse.NativeMethodInfoPtr_set_ClearedRange_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0001F01C File Offset: 0x0001D21C
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x0001F060 File Offset: 0x0001D260
		public unsafe virtual string SpreadsheetId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearValuesResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearValuesResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x0001F0F4 File Offset: 0x0001D2F4
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearValuesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearValuesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001F144 File Offset: 0x0001D344
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearValuesResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearValuesResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearValuesResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000046F5 File Offset: 0x000028F5
		public ClearValuesResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0001F180 File Offset: 0x0001D380
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x000046FE File Offset: 0x000028FE
		public unsafe string _ClearedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearValuesResponse.NativeFieldInfoPtr__ClearedRange_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearValuesResponse.NativeFieldInfoPtr__ClearedRange_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x0000471D File Offset: 0x0000291D
		public unsafe string _SpreadsheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0000473C File Offset: 0x0000293C
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr__ClearedRange_k__BackingField;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_get_ClearedRange_Public_Virtual_New_get_String_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_set_ClearedRange_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
