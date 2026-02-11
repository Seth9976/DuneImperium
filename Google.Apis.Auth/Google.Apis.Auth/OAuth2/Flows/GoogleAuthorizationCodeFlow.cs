using System;
using Google.Apis.Auth.OAuth2.Requests;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Flows
{
	// Token: 0x02000030 RID: 48
	public class GoogleAuthorizationCodeFlow : AuthorizationCodeFlow
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x00010F4C File Offset: 0x0000F14C
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleAuthorizationCodeFlow()
		{
			Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Flows", "GoogleAuthorizationCodeFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr);
			GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__ProjectId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "<ProjectId>k__BackingField");
			GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_revokeTokenUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "revokeTokenUrl");
			GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_includeGrantedScopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "includeGrantedScopes");
			GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__LoginHint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "<LoginHint>k__BackingField");
			GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__Prompt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "<Prompt>k__BackingField");
			GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__Nonce_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "<Nonce>k__BackingField");
			GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_userDefinedQueryParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "userDefinedQueryParams");
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663912);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_ProjectId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663913);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663914);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663915);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_LoginHint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663916);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_LoginHint_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663917);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_Prompt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663918);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_Prompt_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663919);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663920);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_Nonce_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663921);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663922);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663923);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Virtual_AuthorizationCodeRequestUrl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663924);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_RevokeTokenAsync_Public_Virtual_Task_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663925);
			GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, 100663926);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00011134 File Offset: 0x0000F334
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x0001116C File Offset: 0x0000F36C
		public unsafe string ProjectId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_ProjectId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x000111B0 File Offset: 0x0000F3B0
		public unsafe string RevokeTokenUrl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x000111E8 File Offset: 0x0000F3E8
		public unsafe Nullable<bool> IncludeGrantedScopes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00011220 File Offset: 0x0000F420
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00011258 File Offset: 0x0000F458
		public unsafe string LoginHint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_LoginHint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_LoginHint_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0001129C File Offset: 0x0000F49C
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000112D4 File Offset: 0x0000F4D4
		public unsafe string Prompt
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_Prompt_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_Prompt_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00011318 File Offset: 0x0000F518
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00011350 File Offset: 0x0000F550
		public unsafe string Nonce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_set_Nonce_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00011394 File Offset: 0x0000F594
		public unsafe IEnumerable<KeyValuePair<string, string>> UserDefinedQueryParams
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000113D4 File Offset: 0x0000F5D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1157639, RefRangeEnd = 1157641, XrefRangeStart = 1157628, XrefRangeEnd = 1157639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleAuthorizationCodeFlow(GoogleAuthorizationCodeFlow.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00011420 File Offset: 0x0000F620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157641, XrefRangeEnd = 1157670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(redirectUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Virtual_AuthorizationCodeRequestUrl_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeRequestUrl>(intPtr3) : null;
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001147C File Offset: 0x0000F67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157670, XrefRangeEnd = 1157683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task RevokeTokenAsync(string userId, string token, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(token);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_RevokeTokenAsync_Public_Virtual_Task_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00011500 File Offset: 0x0000F700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157683, XrefRangeEnd = 1157685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldForceTokenRetrieval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleAuthorizationCodeFlow.NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000033C4 File Offset: 0x000015C4
		public GoogleAuthorizationCodeFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00011548 File Offset: 0x0000F748
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x000033CD File Offset: 0x000015CD
		public unsafe string _ProjectId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__ProjectId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__ProjectId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00011570 File Offset: 0x0000F770
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000033EC File Offset: 0x000015EC
		public unsafe string revokeTokenUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_revokeTokenUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_revokeTokenUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00011598 File Offset: 0x0000F798
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000340B File Offset: 0x0000160B
		public Nullable<bool> includeGrantedScopes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_includeGrantedScopes);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_includeGrantedScopes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000115C8 File Offset: 0x0000F7C8
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00003439 File Offset: 0x00001639
		public unsafe string _LoginHint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__LoginHint_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__LoginHint_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000115F0 File Offset: 0x0000F7F0
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00003458 File Offset: 0x00001658
		public unsafe string _Prompt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__Prompt_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__Prompt_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00011618 File Offset: 0x0000F818
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00003477 File Offset: 0x00001677
		public unsafe string _Nonce_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__Nonce_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr__Nonce_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00011640 File Offset: 0x0000F840
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003496 File Offset: 0x00001696
		public unsafe IEnumerable<KeyValuePair<string, string>> userDefinedQueryParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_userDefinedQueryParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.NativeFieldInfoPtr_userDefinedQueryParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr__ProjectId_k__BackingField;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_revokeTokenUrl;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_includeGrantedScopes;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr__LoginHint_k__BackingField;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr__Prompt_k__BackingField;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr__Nonce_k__BackingField;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_userDefinedQueryParams;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_ProjectId_Public_get_String_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_set_ProjectId_Private_set_Void_String_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_String_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_LoginHint_Public_get_String_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_set_LoginHint_Private_set_Void_String_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_String_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_set_Prompt_Private_set_Void_String_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_set_Nonce_Private_set_Void_String_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Initializer_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Virtual_AuthorizationCodeRequestUrl_String_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_RevokeTokenAsync_Public_Virtual_Task_String_String_CancellationToken_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Virtual_Boolean_0;

		// Token: 0x02000072 RID: 114
		public new class Initializer : AuthorizationCodeFlow.Initializer
		{
			// Token: 0x0600073E RID: 1854 RVA: 0x0001D06C File Offset: 0x0001B26C
			// Note: this type is marked as 'beforefieldinit'.
			static Initializer()
			{
				Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "Initializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr);
				GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ProjectId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, "<ProjectId>k__BackingField");
				GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__RevokeTokenUrl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, "<RevokeTokenUrl>k__BackingField");
				GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, "<IncludeGrantedScopes>k__BackingField");
				GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__LoginHint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, "<LoginHint>k__BackingField");
				GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Prompt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, "<Prompt>k__BackingField");
				GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Nonce_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, "<Nonce>k__BackingField");
				GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, "<UserDefinedQueryParams>k__BackingField");
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663927);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_ProjectId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663928);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663929);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_RevokeTokenUrl_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663930);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663931);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_IncludeGrantedScopes_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663932);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_LoginHint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663933);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_LoginHint_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663934);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Prompt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663935);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Prompt_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663936);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663937);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663938);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663939);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_UserDefinedQueryParams_Public_set_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663940);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663941);
				GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663942);
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x0600073F RID: 1855 RVA: 0x0001D264 File Offset: 0x0001B464
			// (set) Token: 0x06000740 RID: 1856 RVA: 0x0001D29C File Offset: 0x0001B49C
			public unsafe string ProjectId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_ProjectId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000741 RID: 1857 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
			// (set) Token: 0x06000742 RID: 1858 RVA: 0x0001D318 File Offset: 0x0001B518
			public unsafe string RevokeTokenUrl
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_RevokeTokenUrl_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000743 RID: 1859 RVA: 0x0001D35C File Offset: 0x0001B55C
			// (set) Token: 0x06000744 RID: 1860 RVA: 0x0001D394 File Offset: 0x0001B594
			public unsafe Nullable<bool> IncludeGrantedScopes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_IncludeGrantedScopes_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001D3DC File Offset: 0x0001B5DC
			// (set) Token: 0x06000746 RID: 1862 RVA: 0x0001D414 File Offset: 0x0001B614
			public unsafe string LoginHint
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_LoginHint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_LoginHint_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000747 RID: 1863 RVA: 0x0001D458 File Offset: 0x0001B658
			// (set) Token: 0x06000748 RID: 1864 RVA: 0x0001D490 File Offset: 0x0001B690
			public unsafe string Prompt
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Prompt_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Prompt_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000749 RID: 1865 RVA: 0x0001D4D4 File Offset: 0x0001B6D4
			// (set) Token: 0x0600074A RID: 1866 RVA: 0x0001D50C File Offset: 0x0001B70C
			public unsafe string Nonce
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x0600074B RID: 1867 RVA: 0x0001D550 File Offset: 0x0001B750
			// (set) Token: 0x0600074C RID: 1868 RVA: 0x0001D590 File Offset: 0x0001B790
			public unsafe IEnumerable<KeyValuePair<string, string>> UserDefinedQueryParams
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_UserDefinedQueryParams_Public_set_Void_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x0001D5D4 File Offset: 0x0001B7D4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1157544, RefRangeEnd = 1157547, XrefRangeStart = 1157517, XrefRangeEnd = 1157544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x0001D610 File Offset: 0x0001B810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157547, XrefRangeEnd = 1157568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(string authorizationServerUrl, string tokenServerUrl, string revokeTokenUrl)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow.Initializer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(authorizationServerUrl);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tokenServerUrl);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(revokeTokenUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow.Initializer.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x0000672D File Offset: 0x0000492D
			public Initializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000750 RID: 1872 RVA: 0x0001D680 File Offset: 0x0001B880
			// (set) Token: 0x06000751 RID: 1873 RVA: 0x00006736 File Offset: 0x00004936
			public unsafe string _ProjectId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ProjectId_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ProjectId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000752 RID: 1874 RVA: 0x0001D6A8 File Offset: 0x0001B8A8
			// (set) Token: 0x06000753 RID: 1875 RVA: 0x00006755 File Offset: 0x00004955
			public unsafe string _RevokeTokenUrl_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__RevokeTokenUrl_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__RevokeTokenUrl_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000754 RID: 1876 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
			// (set) Token: 0x06000755 RID: 1877 RVA: 0x00006774 File Offset: 0x00004974
			public Nullable<bool> _IncludeGrantedScopes_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField);
					return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000756 RID: 1878 RVA: 0x0001D700 File Offset: 0x0001B900
			// (set) Token: 0x06000757 RID: 1879 RVA: 0x000067A2 File Offset: 0x000049A2
			public unsafe string _LoginHint_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__LoginHint_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__LoginHint_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000758 RID: 1880 RVA: 0x0001D728 File Offset: 0x0001B928
			// (set) Token: 0x06000759 RID: 1881 RVA: 0x000067C1 File Offset: 0x000049C1
			public unsafe string _Prompt_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Prompt_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Prompt_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x0600075A RID: 1882 RVA: 0x0001D750 File Offset: 0x0001B950
			// (set) Token: 0x0600075B RID: 1883 RVA: 0x000067E0 File Offset: 0x000049E0
			public unsafe string _Nonce_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Nonce_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Nonce_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x0600075C RID: 1884 RVA: 0x0001D778 File Offset: 0x0001B978
			// (set) Token: 0x0600075D RID: 1885 RVA: 0x000067FF File Offset: 0x000049FF
			public unsafe IEnumerable<KeyValuePair<string, string>> _UserDefinedQueryParams_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000445 RID: 1093
			private static readonly IntPtr NativeFieldInfoPtr__ProjectId_k__BackingField;

			// Token: 0x04000446 RID: 1094
			private static readonly IntPtr NativeFieldInfoPtr__RevokeTokenUrl_k__BackingField;

			// Token: 0x04000447 RID: 1095
			private static readonly IntPtr NativeFieldInfoPtr__IncludeGrantedScopes_k__BackingField;

			// Token: 0x04000448 RID: 1096
			private static readonly IntPtr NativeFieldInfoPtr__LoginHint_k__BackingField;

			// Token: 0x04000449 RID: 1097
			private static readonly IntPtr NativeFieldInfoPtr__Prompt_k__BackingField;

			// Token: 0x0400044A RID: 1098
			private static readonly IntPtr NativeFieldInfoPtr__Nonce_k__BackingField;

			// Token: 0x0400044B RID: 1099
			private static readonly IntPtr NativeFieldInfoPtr__UserDefinedQueryParams_k__BackingField;

			// Token: 0x0400044C RID: 1100
			private static readonly IntPtr NativeMethodInfoPtr_get_ProjectId_Public_get_String_0;

			// Token: 0x0400044D RID: 1101
			private static readonly IntPtr NativeMethodInfoPtr_set_ProjectId_Public_set_Void_String_0;

			// Token: 0x0400044E RID: 1102
			private static readonly IntPtr NativeMethodInfoPtr_get_RevokeTokenUrl_Public_get_String_0;

			// Token: 0x0400044F RID: 1103
			private static readonly IntPtr NativeMethodInfoPtr_set_RevokeTokenUrl_Public_set_Void_String_0;

			// Token: 0x04000450 RID: 1104
			private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGrantedScopes_Public_get_Nullable_1_Boolean_0;

			// Token: 0x04000451 RID: 1105
			private static readonly IntPtr NativeMethodInfoPtr_set_IncludeGrantedScopes_Public_set_Void_Nullable_1_Boolean_0;

			// Token: 0x04000452 RID: 1106
			private static readonly IntPtr NativeMethodInfoPtr_get_LoginHint_Public_get_String_0;

			// Token: 0x04000453 RID: 1107
			private static readonly IntPtr NativeMethodInfoPtr_set_LoginHint_Public_set_Void_String_0;

			// Token: 0x04000454 RID: 1108
			private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_String_0;

			// Token: 0x04000455 RID: 1109
			private static readonly IntPtr NativeMethodInfoPtr_set_Prompt_Public_set_Void_String_0;

			// Token: 0x04000456 RID: 1110
			private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

			// Token: 0x04000457 RID: 1111
			private static readonly IntPtr NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0;

			// Token: 0x04000458 RID: 1112
			private static readonly IntPtr NativeMethodInfoPtr_get_UserDefinedQueryParams_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0;

			// Token: 0x04000459 RID: 1113
			private static readonly IntPtr NativeMethodInfoPtr_set_UserDefinedQueryParams_Public_set_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

			// Token: 0x0400045A RID: 1114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400045B RID: 1115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_0;
		}

		// Token: 0x02000073 RID: 115
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.GoogleAuthorizationCodeFlow+<RevokeTokenAsync>d__27")]
		public sealed class _RevokeTokenAsync_d__27 : ValueType
		{
			// Token: 0x0600075E RID: 1886 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
			// Note: this type is marked as 'beforefieldinit'.
			static _RevokeTokenAsync_d__27()
			{
				Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow>.NativeClassPtr, "<RevokeTokenAsync>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr);
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "<>1__state");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "<>t__builder");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "<>4__this");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "token");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "taskCancellationToken");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "userId");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr__response_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "<response>5__2");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "<>u__1");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "<>u__2");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, "<>u__3");
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, 100663943);
				GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr, 100663944);
			}

			// Token: 0x0600075F RID: 1887 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157568, XrefRangeEnd = 1157624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000760 RID: 1888 RVA: 0x0001D8FC File Offset: 0x0001BAFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157624, XrefRangeEnd = 1157628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000761 RID: 1889 RVA: 0x0000681E File Offset: 0x00004A1E
			public _RevokeTokenAsync_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x00006827 File Offset: 0x00004A27
			public _RevokeTokenAsync_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000763 RID: 1891 RVA: 0x0001D944 File Offset: 0x0001BB44
			// (set) Token: 0x06000764 RID: 1892 RVA: 0x00006839 File Offset: 0x00004A39
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000765 RID: 1893 RVA: 0x0001D96C File Offset: 0x0001BB6C
			// (set) Token: 0x06000766 RID: 1894 RVA: 0x00006854 File Offset: 0x00004A54
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000767 RID: 1895 RVA: 0x0001D99C File Offset: 0x0001BB9C
			// (set) Token: 0x06000768 RID: 1896 RVA: 0x00006882 File Offset: 0x00004A82
			public unsafe GoogleAuthorizationCodeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleAuthorizationCodeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000769 RID: 1897 RVA: 0x0001D9CC File Offset: 0x0001BBCC
			// (set) Token: 0x0600076A RID: 1898 RVA: 0x000068A1 File Offset: 0x00004AA1
			public unsafe string token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_token);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_token), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x0600076B RID: 1899 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
			// (set) Token: 0x0600076C RID: 1900 RVA: 0x000068C0 File Offset: 0x00004AC0
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x0600076D RID: 1901 RVA: 0x0001DA24 File Offset: 0x0001BC24
			// (set) Token: 0x0600076E RID: 1902 RVA: 0x000068EE File Offset: 0x00004AEE
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x0600076F RID: 1903 RVA: 0x0001DA4C File Offset: 0x0001BC4C
			// (set) Token: 0x06000770 RID: 1904 RVA: 0x0000690D File Offset: 0x00004B0D
			public unsafe HttpResponseMessage _response_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr__response_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr__response_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000771 RID: 1905 RVA: 0x0001DA7C File Offset: 0x0001BC7C
			// (set) Token: 0x06000772 RID: 1906 RVA: 0x0000692C File Offset: 0x00004B2C
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000773 RID: 1907 RVA: 0x0001DAAC File Offset: 0x0001BCAC
			// (set) Token: 0x06000774 RID: 1908 RVA: 0x0000695A File Offset: 0x00004B5A
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000775 RID: 1909 RVA: 0x0001DADC File Offset: 0x0001BCDC
			// (set) Token: 0x06000776 RID: 1910 RVA: 0x00006988 File Offset: 0x00004B88
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAuthorizationCodeFlow._RevokeTokenAsync_d__27.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400045C RID: 1116
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400045D RID: 1117
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400045E RID: 1118
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400045F RID: 1119
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x04000460 RID: 1120
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x04000461 RID: 1121
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04000462 RID: 1122
			private static readonly IntPtr NativeFieldInfoPtr__response_5__2;

			// Token: 0x04000463 RID: 1123
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000464 RID: 1124
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000465 RID: 1125
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04000466 RID: 1126
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000467 RID: 1127
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
