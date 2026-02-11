using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200002E RID: 46
	public class BatchUpdateValuesRequest : Object
	{
		// Token: 0x0600032D RID: 813 RVA: 0x000170E0 File Offset: 0x000152E0
		// Note: this type is marked as 'beforefieldinit'.
		static BatchUpdateValuesRequest()
		{
			Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BatchUpdateValuesRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr);
			BatchUpdateValuesRequest.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, "<Data>k__BackingField");
			BatchUpdateValuesRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, "<IncludeValuesInResponse>k__BackingField");
			BatchUpdateValuesRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, "<ResponseDateTimeRenderOption>k__BackingField");
			BatchUpdateValuesRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, "<ResponseValueRenderOption>k__BackingField");
			BatchUpdateValuesRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, "<ValueInputOption>k__BackingField");
			BatchUpdateValuesRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, "<ETag>k__BackingField");
			BatchUpdateValuesRequest.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663904);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663905);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663906);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663907);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663908);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663909);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663910);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663911);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663912);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663913);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663914);
			BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663915);
			BatchUpdateValuesRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr, 100663916);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001728C File Offset: 0x0001548C
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000172D8 File Offset: 0x000154D8
		public unsafe virtual IList<ValueRange> Data
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_ValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ValueRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_ValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00017328 File Offset: 0x00015528
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0001736C File Offset: 0x0001556C
		public unsafe virtual Nullable<bool> IncludeValuesInResponse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000173C0 File Offset: 0x000155C0
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00017404 File Offset: 0x00015604
		public unsafe virtual string ResponseDateTimeRenderOption
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00017454 File Offset: 0x00015654
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00017498 File Offset: 0x00015698
		public unsafe virtual string ResponseValueRenderOption
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000336 RID: 822 RVA: 0x000174E8 File Offset: 0x000156E8
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0001752C File Offset: 0x0001572C
		public unsafe virtual string ValueInputOption
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001757C File Offset: 0x0001577C
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000175C0 File Offset: 0x000157C0
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchUpdateValuesRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00017610 File Offset: 0x00015810
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchUpdateValuesRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchUpdateValuesRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchUpdateValuesRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003782 File Offset: 0x00001982
		public BatchUpdateValuesRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001764C File Offset: 0x0001584C
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0000378B File Offset: 0x0000198B
		public unsafe IList<ValueRange> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ValueRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001767C File Offset: 0x0001587C
		// (set) Token: 0x0600033F RID: 831 RVA: 0x000037AA File Offset: 0x000019AA
		public Nullable<bool> _IncludeValuesInResponse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000340 RID: 832 RVA: 0x000176AC File Offset: 0x000158AC
		// (set) Token: 0x06000341 RID: 833 RVA: 0x000037D8 File Offset: 0x000019D8
		public unsafe string _ResponseDateTimeRenderOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000176D4 File Offset: 0x000158D4
		// (set) Token: 0x06000343 RID: 835 RVA: 0x000037F7 File Offset: 0x000019F7
		public unsafe string _ResponseValueRenderOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000176FC File Offset: 0x000158FC
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003816 File Offset: 0x00001A16
		public unsafe string _ValueInputOption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ValueInputOption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00017724 File Offset: 0x00015924
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003835 File Offset: 0x00001A35
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchUpdateValuesRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr__IncludeValuesInResponse_k__BackingField;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr__ResponseDateTimeRenderOption_k__BackingField;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr__ResponseValueRenderOption_k__BackingField;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr__ValueInputOption_k__BackingField;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_ValueRange_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_ValueRange_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeValuesInResponse_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludeValuesInResponse_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseDateTimeRenderOption_Public_Virtual_New_get_String_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseDateTimeRenderOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseValueRenderOption_Public_Virtual_New_get_String_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseValueRenderOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueInputOption_Public_Virtual_New_get_String_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueInputOption_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
