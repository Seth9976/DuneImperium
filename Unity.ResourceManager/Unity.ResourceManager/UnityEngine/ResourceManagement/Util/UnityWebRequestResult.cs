using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200002B RID: 43
	public class UnityWebRequestResult : Object
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestResult()
		{
			Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "UnityWebRequestResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr);
			UnityWebRequestResult.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, "<Error>k__BackingField");
			UnityWebRequestResult.NativeFieldInfoPtr__ResponseCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, "<ResponseCode>k__BackingField");
			UnityWebRequestResult.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, "<Result>k__BackingField");
			UnityWebRequestResult.NativeFieldInfoPtr__Method_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, "<Method>k__BackingField");
			UnityWebRequestResult.NativeFieldInfoPtr__Url_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, "<Url>k__BackingField");
			UnityWebRequestResult.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663665);
			UnityWebRequestResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663666);
			UnityWebRequestResult.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663667);
			UnityWebRequestResult.NativeMethodInfoPtr_set_Error_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663668);
			UnityWebRequestResult.NativeMethodInfoPtr_get_ResponseCode_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663669);
			UnityWebRequestResult.NativeMethodInfoPtr_get_Result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663670);
			UnityWebRequestResult.NativeMethodInfoPtr_get_Method_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663671);
			UnityWebRequestResult.NativeMethodInfoPtr_get_Url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663672);
			UnityWebRequestResult.NativeMethodInfoPtr_ShouldRetryDownloadError_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr, 100663673);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000D728 File Offset: 0x0000B928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139185, RefRangeEnd = 1139186, XrefRangeStart = 1139168, XrefRangeEnd = 1139185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestResult(UnityWebRequest request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequestResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000D774 File Offset: 0x0000B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139186, XrefRangeEnd = 1139208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityWebRequestResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
		public unsafe string Error
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr_set_Error_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000D834 File Offset: 0x0000BA34
		public unsafe long ResponseCode
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr_get_ResponseCode_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000D870 File Offset: 0x0000BA70
		public unsafe UnityWebRequest.Result Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr_get_Result_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000D8AC File Offset: 0x0000BAAC
		public unsafe string Method
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr_get_Method_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		public unsafe string Url
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr_get_Url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000D91C File Offset: 0x0000BB1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1139260, RefRangeEnd = 1139262, XrefRangeStart = 1139208, XrefRangeEnd = 1139260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldRetryDownloadError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestResult.NativeMethodInfoPtr_ShouldRetryDownloadError_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002D9F File Offset: 0x00000F9F
		public UnityWebRequestResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000D958 File Offset: 0x0000BB58
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public unsafe string _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Error_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000D980 File Offset: 0x0000BB80
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002DC7 File Offset: 0x00000FC7
		public unsafe long _ResponseCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__ResponseCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__ResponseCode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002DE2 File Offset: 0x00000FE2
		public unsafe UnityWebRequest.Result _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002DFD File Offset: 0x00000FFD
		public unsafe string _Method_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Method_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Method_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002E1C File Offset: 0x0000101C
		public unsafe string _Url_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Url_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestResult.NativeFieldInfoPtr__Url_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr__ResponseCode_k__BackingField;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr__Method_k__BackingField;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr__Url_k__BackingField;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Public_set_Void_String_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseCode_Public_get_Int64_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Result_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_String_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Public_get_String_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRetryDownloadError_Public_Boolean_0;
	}
}
