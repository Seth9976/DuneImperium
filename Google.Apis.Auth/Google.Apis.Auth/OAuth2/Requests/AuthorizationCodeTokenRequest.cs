using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x02000027 RID: 39
	public class AuthorizationCodeTokenRequest : TokenRequest
	{
		// Token: 0x06000239 RID: 569 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorizationCodeTokenRequest()
		{
			Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "AuthorizationCodeTokenRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr);
			AuthorizationCodeTokenRequest.NativeFieldInfoPtr__Code_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr, "<Code>k__BackingField");
			AuthorizationCodeTokenRequest.NativeFieldInfoPtr__RedirectUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr, "<RedirectUri>k__BackingField");
			AuthorizationCodeTokenRequest.NativeMethodInfoPtr_get_Code_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr, 100663801);
			AuthorizationCodeTokenRequest.NativeMethodInfoPtr_set_Code_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr, 100663802);
			AuthorizationCodeTokenRequest.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr, 100663803);
			AuthorizationCodeTokenRequest.NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr, 100663804);
			AuthorizationCodeTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr, 100663805);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000ED70 File Offset: 0x0000CF70
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		public unsafe string Code
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeTokenRequest.NativeMethodInfoPtr_get_Code_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeTokenRequest.NativeMethodInfoPtr_set_Code_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000EE24 File Offset: 0x0000D024
		public unsafe string RedirectUri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeTokenRequest.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeTokenRequest.NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000EE68 File Offset: 0x0000D068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1156943, RefRangeEnd = 1156944, XrefRangeStart = 1156939, XrefRangeEnd = 1156943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeTokenRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeTokenRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002F67 File Offset: 0x00001167
		public AuthorizationCodeTokenRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002F70 File Offset: 0x00001170
		public unsafe string _Code_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeTokenRequest.NativeFieldInfoPtr__Code_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeTokenRequest.NativeFieldInfoPtr__Code_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000EECC File Offset: 0x0000D0CC
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002F8F File Offset: 0x0000118F
		public unsafe string _RedirectUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeTokenRequest.NativeFieldInfoPtr__RedirectUri_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeTokenRequest.NativeFieldInfoPtr__RedirectUri_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr__Code_k__BackingField;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr__RedirectUri_k__BackingField;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_String_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_set_Code_Public_set_Void_String_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
