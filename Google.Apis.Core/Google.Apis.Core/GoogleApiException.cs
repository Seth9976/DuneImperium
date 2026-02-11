using System;
using Google.Apis.Requests;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Google
{
	// Token: 0x02000003 RID: 3
	public class GoogleApiException : Exception
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000042E0 File Offset: 0x000024E0
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleApiException()
		{
			Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google", "GoogleApiException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr);
			GoogleApiException.NativeFieldInfoPtr_serviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, "serviceName");
			GoogleApiException.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, "<Error>k__BackingField");
			GoogleApiException.NativeFieldInfoPtr__HttpStatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, "<HttpStatusCode>k__BackingField");
			GoogleApiException.NativeMethodInfoPtr_get_ServiceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663300);
			GoogleApiException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663301);
			GoogleApiException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663302);
			GoogleApiException.NativeMethodInfoPtr_get_Error_Public_get_RequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663303);
			GoogleApiException.NativeMethodInfoPtr_set_Error_Public_set_Void_RequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663304);
			GoogleApiException.NativeMethodInfoPtr_get_HttpStatusCode_Public_get_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663305);
			GoogleApiException.NativeMethodInfoPtr_set_HttpStatusCode_Public_set_Void_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663306);
			GoogleApiException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr, 100663307);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000043EC File Offset: 0x000025EC
		public unsafe string ServiceName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleApiException.NativeMethodInfoPtr_get_ServiceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00004424 File Offset: 0x00002624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209851, XrefRangeEnd = 1209861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleApiException(string serviceName, string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serviceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleApiException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00004494 File Offset: 0x00002694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1209871, RefRangeEnd = 1209872, XrefRangeStart = 1209861, XrefRangeEnd = 1209871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleApiException(string serviceName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleApiException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serviceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleApiException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000044F4 File Offset: 0x000026F4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00004534 File Offset: 0x00002734
		public unsafe RequestError Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleApiException.NativeMethodInfoPtr_get_Error_Public_get_RequestError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestError>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleApiException.NativeMethodInfoPtr_set_Error_Public_set_Void_RequestError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00004578 File Offset: 0x00002778
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000045B4 File Offset: 0x000027B4
		public unsafe HttpStatusCode HttpStatusCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315963, RefRangeEnd = 315964, XrefRangeStart = 315963, XrefRangeEnd = 315964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleApiException.NativeMethodInfoPtr_get_HttpStatusCode_Public_get_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 315964, RefRangeEnd = 315969, XrefRangeStart = 315964, XrefRangeEnd = 315969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleApiException.NativeMethodInfoPtr_set_HttpStatusCode_Public_set_Void_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000045F4 File Offset: 0x000027F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209872, XrefRangeEnd = 1209876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleApiException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000206B File Offset: 0x0000026B
		public GoogleApiException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00004638 File Offset: 0x00002838
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe string serviceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleApiException.NativeFieldInfoPtr_serviceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleApiException.NativeFieldInfoPtr_serviceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00004660 File Offset: 0x00002860
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002093 File Offset: 0x00000293
		public unsafe RequestError _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleApiException.NativeFieldInfoPtr__Error_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestError>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleApiException.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00004690 File Offset: 0x00002890
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe HttpStatusCode _HttpStatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleApiException.NativeFieldInfoPtr__HttpStatusCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleApiException.NativeFieldInfoPtr__HttpStatusCode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_serviceName;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr__HttpStatusCode_k__BackingField;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceName_Public_get_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_RequestError_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Public_set_Void_RequestError_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpStatusCode_Public_get_HttpStatusCode_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_set_HttpStatusCode_Public_set_Void_HttpStatusCode_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
