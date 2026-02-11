using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200002A RID: 42
	public class BatchUpdateSpreadsheetRequest : Object
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x000158DC File Offset: 0x00013ADC
		// Note: this type is marked as 'beforefieldinit'.
		static BatchUpdateSpreadsheetRequest()
		{
			Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchUpdateSpreadsheetRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr);
			BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__IncludeSpreadsheetInResponse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, "<IncludeSpreadsheetInResponse>k__BackingField");
			BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__Requests_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, "<Requests>k__BackingField");
			BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ResponseIncludeGridData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, "<ResponseIncludeGridData>k__BackingField");
			BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ResponseRanges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, "<ResponseRanges>k__BackingField");
			BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, "<ETag>k__BackingField");
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_IncludeSpreadsheetInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663856);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_IncludeSpreadsheetInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663857);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_Requests_Public_Virtual_New_get_IList_1_Request_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663858);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_Requests_Public_Virtual_New_set_Void_IList_1_Request_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663859);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_ResponseIncludeGridData_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663860);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_ResponseIncludeGridData_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663861);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_ResponseRanges_Public_Virtual_New_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663862);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_ResponseRanges_Public_Virtual_New_set_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663863);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663864);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663865);
			BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr, 100663866);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00015A4C File Offset: 0x00013C4C
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00015A90 File Offset: 0x00013C90
		public unsafe virtual Nullable<bool> IncludeSpreadsheetInResponse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_IncludeSpreadsheetInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_IncludeSpreadsheetInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00015AE4 File Offset: 0x00013CE4
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00015B30 File Offset: 0x00013D30
		public unsafe virtual IList<Request> Requests
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_Requests_Public_Virtual_New_get_IList_1_Request_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Request>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_Requests_Public_Virtual_New_set_Void_IList_1_Request_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00015B80 File Offset: 0x00013D80
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00015BC4 File Offset: 0x00013DC4
		public unsafe virtual Nullable<bool> ResponseIncludeGridData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_ResponseIncludeGridData_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_ResponseIncludeGridData_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00015C18 File Offset: 0x00013E18
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00015C64 File Offset: 0x00013E64
		public unsafe virtual IList<string> ResponseRanges
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_ResponseRanges_Public_Virtual_New_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_ResponseRanges_Public_Virtual_New_set_Void_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00015CB4 File Offset: 0x00013EB4
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00015D48 File Offset: 0x00013F48
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchUpdateSpreadsheetRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchUpdateSpreadsheetRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchUpdateSpreadsheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000344B File Offset: 0x0000164B
		public BatchUpdateSpreadsheetRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00015D84 File Offset: 0x00013F84
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00003454 File Offset: 0x00001654
		public Nullable<bool> _IncludeSpreadsheetInResponse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__IncludeSpreadsheetInResponse_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__IncludeSpreadsheetInResponse_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00015DB4 File Offset: 0x00013FB4
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00003482 File Offset: 0x00001682
		public unsafe IList<Request> _Requests_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__Requests_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Request>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__Requests_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00015DE4 File Offset: 0x00013FE4
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000034A1 File Offset: 0x000016A1
		public Nullable<bool> _ResponseIncludeGridData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ResponseIncludeGridData_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ResponseIncludeGridData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00015E14 File Offset: 0x00014014
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000034CF File Offset: 0x000016CF
		public unsafe IList<string> _ResponseRanges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ResponseRanges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ResponseRanges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00015E44 File Offset: 0x00014044
		// (set) Token: 0x060002DF RID: 735 RVA: 0x000034EE File Offset: 0x000016EE
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateSpreadsheetRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr__IncludeSpreadsheetInResponse_k__BackingField;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr__Requests_k__BackingField;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr__ResponseIncludeGridData_k__BackingField;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr__ResponseRanges_k__BackingField;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeSpreadsheetInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludeSpreadsheetInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_Requests_Public_Virtual_New_get_IList_1_Request_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_set_Requests_Public_Virtual_New_set_Void_IList_1_Request_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseIncludeGridData_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseIncludeGridData_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseRanges_Public_Virtual_New_get_IList_1_String_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseRanges_Public_Virtual_New_set_Void_IList_1_String_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
