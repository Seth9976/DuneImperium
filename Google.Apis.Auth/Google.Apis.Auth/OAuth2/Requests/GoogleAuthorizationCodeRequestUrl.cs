using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x0200002A RID: 42
	public class GoogleAuthorizationCodeRequestUrl : AuthorizationCodeRequestUrl
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0000F5DC File Offset: 0x0000D7DC
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleAuthorizationCodeRequestUrl()
		{
			Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "GoogleAuthorizationCodeRequestUrl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr);
			GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__AccessType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, "<AccessType>k__BackingField");
			GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__Prompt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, "<Prompt>k__BackingField");
			GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__ApprovalPrompt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, "<ApprovalPrompt>k__BackingField");
			GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__LoginHint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, "<LoginHint>k__BackingField");
			GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, "<IncludeGrantedScopes>k__BackingField");
			GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__Nonce_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, "<Nonce>k__BackingField");
			GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, "<UserDefinedQueryParams>k__BackingField");
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_AccessType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663821);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_AccessType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663822);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_Prompt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663823);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_Prompt_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663824);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_ApprovalPrompt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663825);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_ApprovalPrompt_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663826);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_LoginHint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663827);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_LoginHint_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663828);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663829);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_IncludeGrantedScopes_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663830);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663831);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663832);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663833);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_UserDefinedQueryParams_Public_set_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663834);
			GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr, 100663835);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public unsafe string AccessType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_AccessType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_AccessType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000F840 File Offset: 0x0000DA40
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000F878 File Offset: 0x0000DA78
		public unsafe string Prompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_Prompt_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_Prompt_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000F8BC File Offset: 0x0000DABC
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000F8F4 File Offset: 0x0000DAF4
		public unsafe string ApprovalPrompt
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_ApprovalPrompt_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_ApprovalPrompt_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000F938 File Offset: 0x0000DB38
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0000F970 File Offset: 0x0000DB70
		public unsafe string LoginHint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_LoginHint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_LoginHint_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		public unsafe string IncludeGrantedScopes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_IncludeGrantedScopes_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000FA30 File Offset: 0x0000DC30
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000FA68 File Offset: 0x0000DC68
		public unsafe string Nonce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		public unsafe IEnumerable<KeyValuePair<string, string>> UserDefinedQueryParams
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr_set_UserDefinedQueryParams_Public_set_Void_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000FB30 File Offset: 0x0000DD30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1156958, RefRangeEnd = 1156959, XrefRangeStart = 1156950, XrefRangeEnd = 1156958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleAuthorizationCodeRequestUrl(Uri authorizationServerUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAuthorizationCodeRequestUrl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(authorizationServerUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeRequestUrl.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003099 File Offset: 0x00001299
		public GoogleAuthorizationCodeRequestUrl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000030A2 File Offset: 0x000012A2
		public unsafe string _AccessType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__AccessType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__AccessType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000FBA4 File Offset: 0x0000DDA4
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000030C1 File Offset: 0x000012C1
		public unsafe string _Prompt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__Prompt_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__Prompt_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		// (set) Token: 0x0600027B RID: 635 RVA: 0x000030E0 File Offset: 0x000012E0
		public unsafe string _ApprovalPrompt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__ApprovalPrompt_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__ApprovalPrompt_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		// (set) Token: 0x0600027D RID: 637 RVA: 0x000030FF File Offset: 0x000012FF
		public unsafe string _LoginHint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__LoginHint_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__LoginHint_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000FC1C File Offset: 0x0000DE1C
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000311E File Offset: 0x0000131E
		public unsafe string _IncludeGrantedScopes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000FC44 File Offset: 0x0000DE44
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000313D File Offset: 0x0000133D
		public unsafe string _Nonce_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__Nonce_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__Nonce_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000FC6C File Offset: 0x0000DE6C
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000315C File Offset: 0x0000135C
		public unsafe IEnumerable<KeyValuePair<string, string>> _UserDefinedQueryParams_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeRequestUrl.NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr__AccessType_k__BackingField;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr__Prompt_k__BackingField;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr__ApprovalPrompt_k__BackingField;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr__LoginHint_k__BackingField;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr__Nonce_k__BackingField;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessType_Public_get_String_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessType_Public_set_Void_String_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_String_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_set_Prompt_Public_set_Void_String_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_ApprovalPrompt_Public_get_String_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_set_ApprovalPrompt_Public_set_Void_String_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_get_LoginHint_Public_get_String_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_set_LoginHint_Public_set_Void_String_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_String_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludeGrantedScopes_Public_set_Void_String_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_set_UserDefinedQueryParams_Public_set_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;
	}
}
