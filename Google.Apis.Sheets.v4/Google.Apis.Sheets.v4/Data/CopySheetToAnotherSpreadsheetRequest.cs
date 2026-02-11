using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000048 RID: 72
	public class CopySheetToAnotherSpreadsheetRequest : Object
	{
		// Token: 0x060005A3 RID: 1443 RVA: 0x00020868 File Offset: 0x0001EA68
		// Note: this type is marked as 'beforefieldinit'.
		static CopySheetToAnotherSpreadsheetRequest()
		{
			Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "CopySheetToAnotherSpreadsheetRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr);
			CopySheetToAnotherSpreadsheetRequest.NativeFieldInfoPtr__DestinationSpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr, "<DestinationSpreadsheetId>k__BackingField");
			CopySheetToAnotherSpreadsheetRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr, "<ETag>k__BackingField");
			CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_get_DestinationSpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr, 100664206);
			CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_set_DestinationSpreadsheetId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr, 100664207);
			CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr, 100664208);
			CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr, 100664209);
			CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr, 100664210);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00020924 File Offset: 0x0001EB24
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00020968 File Offset: 0x0001EB68
		public unsafe virtual string DestinationSpreadsheetId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_get_DestinationSpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_set_DestinationSpreadsheetId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x000209B8 File Offset: 0x0001EBB8
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x000209FC File Offset: 0x0001EBFC
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00020A4C File Offset: 0x0001EC4C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopySheetToAnotherSpreadsheetRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopySheetToAnotherSpreadsheetRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopySheetToAnotherSpreadsheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00004A30 File Offset: 0x00002C30
		public CopySheetToAnotherSpreadsheetRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00020A88 File Offset: 0x0001EC88
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00004A39 File Offset: 0x00002C39
		public unsafe string _DestinationSpreadsheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopySheetToAnotherSpreadsheetRequest.NativeFieldInfoPtr__DestinationSpreadsheetId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopySheetToAnotherSpreadsheetRequest.NativeFieldInfoPtr__DestinationSpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00004A58 File Offset: 0x00002C58
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopySheetToAnotherSpreadsheetRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopySheetToAnotherSpreadsheetRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr__DestinationSpreadsheetId_k__BackingField;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationSpreadsheetId_Public_Virtual_New_get_String_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationSpreadsheetId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
