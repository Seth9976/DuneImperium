using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000024 RID: 36
	public class BatchClearValuesByDataFilterResponse : Object
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00014314 File Offset: 0x00012514
		// Note: this type is marked as 'beforefieldinit'.
		static BatchClearValuesByDataFilterResponse()
		{
			Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchClearValuesByDataFilterResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr);
			BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__ClearedRanges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, "<ClearedRanges>k__BackingField");
			BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
			BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, "<ETag>k__BackingField");
			BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_get_ClearedRanges_Public_Virtual_New_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, 100663812);
			BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_set_ClearedRanges_Public_Virtual_New_set_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, 100663813);
			BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, 100663814);
			BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, 100663815);
			BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, 100663816);
			BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, 100663817);
			BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr, 100663818);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001440C File Offset: 0x0001260C
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00014458 File Offset: 0x00012658
		public unsafe virtual IList<string> ClearedRanges
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_get_ClearedRanges_Public_Virtual_New_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_set_ClearedRanges_Public_Virtual_New_set_Void_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000144A8 File Offset: 0x000126A8
		// (set) Token: 0x0600026F RID: 623 RVA: 0x000144EC File Offset: 0x000126EC
		public unsafe virtual string SpreadsheetId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001453C File Offset: 0x0001273C
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00014580 File Offset: 0x00012780
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000145D0 File Offset: 0x000127D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchClearValuesByDataFilterResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchClearValuesByDataFilterResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchClearValuesByDataFilterResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000031C8 File Offset: 0x000013C8
		public BatchClearValuesByDataFilterResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0001460C File Offset: 0x0001280C
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000031D1 File Offset: 0x000013D1
		public unsafe IList<string> _ClearedRanges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__ClearedRanges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__ClearedRanges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0001463C File Offset: 0x0001283C
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000031F0 File Offset: 0x000013F0
		public unsafe string _SpreadsheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00014664 File Offset: 0x00012864
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0000320F File Offset: 0x0000140F
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchClearValuesByDataFilterResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr__ClearedRanges_k__BackingField;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_ClearedRanges_Public_Virtual_New_get_IList_1_String_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_set_ClearedRanges_Public_Virtual_New_set_Void_IList_1_String_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
