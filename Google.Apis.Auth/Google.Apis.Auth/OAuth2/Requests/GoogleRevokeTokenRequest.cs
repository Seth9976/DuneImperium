using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x0200002B RID: 43
	public class GoogleRevokeTokenRequest : Object
	{
		// Token: 0x06000284 RID: 644 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleRevokeTokenRequest()
		{
			Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "GoogleRevokeTokenRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr);
			GoogleRevokeTokenRequest.NativeFieldInfoPtr_revokeTokenUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr, "revokeTokenUrl");
			GoogleRevokeTokenRequest.NativeFieldInfoPtr__Token_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr, "<Token>k__BackingField");
			GoogleRevokeTokenRequest.NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr, 100663836);
			GoogleRevokeTokenRequest.NativeMethodInfoPtr_get_Token_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr, 100663837);
			GoogleRevokeTokenRequest.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr, 100663838);
			GoogleRevokeTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr, 100663839);
			GoogleRevokeTokenRequest.NativeMethodInfoPtr_Build_Public_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr, 100663840);
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000FD58 File Offset: 0x0000DF58
		public unsafe Uri RevokeTokenUrl
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleRevokeTokenRequest.NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000FD98 File Offset: 0x0000DF98
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000FDD0 File Offset: 0x0000DFD0
		public unsafe string Token
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleRevokeTokenRequest.NativeMethodInfoPtr_get_Token_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleRevokeTokenRequest.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000FE14 File Offset: 0x0000E014
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleRevokeTokenRequest(Uri revokeTokenUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleRevokeTokenRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(revokeTokenUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleRevokeTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000FE60 File Offset: 0x0000E060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1156970, RefRangeEnd = 1156971, XrefRangeStart = 1156959, XrefRangeEnd = 1156970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleRevokeTokenRequest.NativeMethodInfoPtr_Build_Public_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000317B File Offset: 0x0000137B
		public GoogleRevokeTokenRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003184 File Offset: 0x00001384
		public unsafe Uri revokeTokenUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleRevokeTokenRequest.NativeFieldInfoPtr_revokeTokenUrl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleRevokeTokenRequest.NativeFieldInfoPtr_revokeTokenUrl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		// (set) Token: 0x0600028E RID: 654 RVA: 0x000031A3 File Offset: 0x000013A3
		public unsafe string _Token_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleRevokeTokenRequest.NativeFieldInfoPtr__Token_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleRevokeTokenRequest.NativeFieldInfoPtr__Token_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_revokeTokenUrl;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr__Token_k__BackingField;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_Uri_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_String_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_String_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Uri_0;
	}
}
