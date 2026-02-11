using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x02000028 RID: 40
	public class AuthorizationRequestUrl : Object
	{
		// Token: 0x06000244 RID: 580 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorizationRequestUrl()
		{
			Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "AuthorizationRequestUrl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr);
			AuthorizationRequestUrl.NativeFieldInfoPtr__ResponseType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, "<ResponseType>k__BackingField");
			AuthorizationRequestUrl.NativeFieldInfoPtr__ClientId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, "<ClientId>k__BackingField");
			AuthorizationRequestUrl.NativeFieldInfoPtr__RedirectUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, "<RedirectUri>k__BackingField");
			AuthorizationRequestUrl.NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, "<Scope>k__BackingField");
			AuthorizationRequestUrl.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, "<State>k__BackingField");
			AuthorizationRequestUrl.NativeFieldInfoPtr_authorizationServerUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, "authorizationServerUrl");
			AuthorizationRequestUrl.NativeMethodInfoPtr_get_ResponseType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663806);
			AuthorizationRequestUrl.NativeMethodInfoPtr_set_ResponseType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663807);
			AuthorizationRequestUrl.NativeMethodInfoPtr_get_ClientId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663808);
			AuthorizationRequestUrl.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663809);
			AuthorizationRequestUrl.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663810);
			AuthorizationRequestUrl.NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663811);
			AuthorizationRequestUrl.NativeMethodInfoPtr_get_Scope_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663812);
			AuthorizationRequestUrl.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663813);
			AuthorizationRequestUrl.NativeMethodInfoPtr_get_State_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663814);
			AuthorizationRequestUrl.NativeMethodInfoPtr_set_State_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663815);
			AuthorizationRequestUrl.NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663816);
			AuthorizationRequestUrl.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr, 100663817);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000F08C File Offset: 0x0000D28C
		// (set) Token: 0x06000246 RID: 582 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public unsafe string ResponseType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_get_ResponseType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_set_ResponseType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000F108 File Offset: 0x0000D308
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000F140 File Offset: 0x0000D340
		public unsafe string ClientId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_get_ClientId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000F184 File Offset: 0x0000D384
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		public unsafe string RedirectUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000F200 File Offset: 0x0000D400
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000F238 File Offset: 0x0000D438
		public unsafe string Scope
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_get_Scope_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000F27C File Offset: 0x0000D47C
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		public unsafe string State
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_get_State_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_set_State_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000F2F8 File Offset: 0x0000D4F8
		public unsafe Uri AuthorizationServerUrl
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000F338 File Offset: 0x0000D538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156944, XrefRangeEnd = 1156946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationRequestUrl(Uri authorizationServerUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationRequestUrl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(authorizationServerUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationRequestUrl.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002FAE File Offset: 0x000011AE
		public AuthorizationRequestUrl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000F384 File Offset: 0x0000D584
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002FB7 File Offset: 0x000011B7
		public unsafe string _ResponseType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__ResponseType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__ResponseType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002FD6 File Offset: 0x000011D6
		public unsafe string _ClientId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__ClientId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__ClientId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002FF5 File Offset: 0x000011F5
		public unsafe string _RedirectUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__RedirectUri_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__RedirectUri_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000F3FC File Offset: 0x0000D5FC
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00003014 File Offset: 0x00001214
		public unsafe string _Scope_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__Scope_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__Scope_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000F424 File Offset: 0x0000D624
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00003033 File Offset: 0x00001233
		public unsafe string _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__State_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr__State_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000F44C File Offset: 0x0000D64C
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00003052 File Offset: 0x00001252
		public unsafe Uri authorizationServerUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr_authorizationServerUrl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationRequestUrl.NativeFieldInfoPtr_authorizationServerUrl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr__ResponseType_k__BackingField;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr__ClientId_k__BackingField;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr__RedirectUri_k__BackingField;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_authorizationServerUrl;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseType_Public_get_String_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseType_Public_set_Void_String_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_String_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_get_Scope_Public_get_String_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_String_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_String_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_Uri_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;
	}
}
