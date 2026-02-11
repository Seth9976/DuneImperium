using System;
using Google.Apis.Logging;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Responses
{
	// Token: 0x02000024 RID: 36
	public class TokenResponse : Object
	{
		// Token: 0x06000203 RID: 515 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		// Note: this type is marked as 'beforefieldinit'.
		static TokenResponse()
		{
			Il2CppClassPointerStore<TokenResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Responses", "TokenResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr);
			TokenResponse.NativeFieldInfoPtr_TokenRefreshTimeWindowSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "TokenRefreshTimeWindowSeconds");
			TokenResponse.NativeFieldInfoPtr_TokenHardExpiryTimeWindowSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "TokenHardExpiryTimeWindowSeconds");
			TokenResponse.NativeFieldInfoPtr__AccessToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<AccessToken>k__BackingField");
			TokenResponse.NativeFieldInfoPtr__TokenType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<TokenType>k__BackingField");
			TokenResponse.NativeFieldInfoPtr__ExpiresInSeconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<ExpiresInSeconds>k__BackingField");
			TokenResponse.NativeFieldInfoPtr__RefreshToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<RefreshToken>k__BackingField");
			TokenResponse.NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<Scope>k__BackingField");
			TokenResponse.NativeFieldInfoPtr__IdToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<IdToken>k__BackingField");
			TokenResponse.NativeFieldInfoPtr__IssuedUtc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<IssuedUtc>k__BackingField");
			TokenResponse.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663773);
			TokenResponse.NativeMethodInfoPtr_set_AccessToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663774);
			TokenResponse.NativeMethodInfoPtr_get_TokenType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663775);
			TokenResponse.NativeMethodInfoPtr_set_TokenType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663776);
			TokenResponse.NativeMethodInfoPtr_get_ExpiresInSeconds_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663777);
			TokenResponse.NativeMethodInfoPtr_set_ExpiresInSeconds_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663778);
			TokenResponse.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663779);
			TokenResponse.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663780);
			TokenResponse.NativeMethodInfoPtr_get_Scope_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663781);
			TokenResponse.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663782);
			TokenResponse.NativeMethodInfoPtr_get_IdToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663783);
			TokenResponse.NativeMethodInfoPtr_set_IdToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663784);
			TokenResponse.NativeMethodInfoPtr_get_Issued_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663785);
			TokenResponse.NativeMethodInfoPtr_set_Issued_Public_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663786);
			TokenResponse.NativeMethodInfoPtr_get_IssuedUtc_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663787);
			TokenResponse.NativeMethodInfoPtr_set_IssuedUtc_Public_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663788);
			TokenResponse.NativeMethodInfoPtr_IsExpired_Public_Boolean_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663789);
			TokenResponse.NativeMethodInfoPtr_IsEffectivelyExpired_Internal_Boolean_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663790);
			TokenResponse.NativeMethodInfoPtr_FromHttpResponseAsync_Public_Static_Task_1_TokenResponse_HttpResponseMessage_IClock_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663791);
			TokenResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, 100663792);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000E320 File Offset: 0x0000C520
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0000E358 File Offset: 0x0000C558
		public unsafe string AccessToken
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_AccessToken_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000E39C File Offset: 0x0000C59C
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000E3D4 File Offset: 0x0000C5D4
		public unsafe string TokenType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_TokenType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_TokenType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000E418 File Offset: 0x0000C618
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000E450 File Offset: 0x0000C650
		public unsafe Nullable<long> ExpiresInSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_ExpiresInSeconds_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_ExpiresInSeconds_Public_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000E498 File Offset: 0x0000C698
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		public unsafe string RefreshToken
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000E514 File Offset: 0x0000C714
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000E54C File Offset: 0x0000C74C
		public unsafe string Scope
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_Scope_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000E590 File Offset: 0x0000C790
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		public unsafe string IdToken
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_IdToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_IdToken_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000E60C File Offset: 0x0000C80C
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000E648 File Offset: 0x0000C848
		public unsafe DateTime Issued
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156859, XrefRangeEnd = 1156863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_Issued_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156863, XrefRangeEnd = 1156867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_Issued_Public_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000E688 File Offset: 0x0000C888
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000E6C4 File Offset: 0x0000C8C4
		public unsafe DateTime IssuedUtc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_get_IssuedUtc_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_set_IssuedUtc_Public_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000E704 File Offset: 0x0000C904
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1156879, RefRangeEnd = 1156882, XrefRangeStart = 1156867, XrefRangeEnd = 1156879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExpired(IClock clock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_IsExpired_Public_Boolean_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000E754 File Offset: 0x0000C954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156882, XrefRangeEnd = 1156894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEffectivelyExpired(IClock clock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_IsEffectivelyExpired_Internal_Boolean_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156894, XrefRangeEnd = 1156910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TokenResponse> FromHttpResponseAsync(HttpResponseMessage response, IClock clock, ILogger logger)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr_FromHttpResponseAsync_Public_Static_Task_1_TokenResponse_HttpResponseMessage_IClock_ILogger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000E80C File Offset: 0x0000CA0C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002DFF File Offset: 0x00000FFF
		public TokenResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000E848 File Offset: 0x0000CA48
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002E08 File Offset: 0x00001008
		public unsafe static int TokenRefreshTimeWindowSeconds
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TokenResponse.NativeFieldInfoPtr_TokenRefreshTimeWindowSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TokenResponse.NativeFieldInfoPtr_TokenRefreshTimeWindowSeconds, (void*)(&value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000E864 File Offset: 0x0000CA64
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002E16 File Offset: 0x00001016
		public unsafe static int TokenHardExpiryTimeWindowSeconds
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TokenResponse.NativeFieldInfoPtr_TokenHardExpiryTimeWindowSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TokenResponse.NativeFieldInfoPtr_TokenHardExpiryTimeWindowSeconds, (void*)(&value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000E880 File Offset: 0x0000CA80
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002E24 File Offset: 0x00001024
		public unsafe string _AccessToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__AccessToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__AccessToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002E43 File Offset: 0x00001043
		public unsafe string _TokenType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__TokenType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__TokenType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002E62 File Offset: 0x00001062
		public Nullable<long> _ExpiresInSeconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__ExpiresInSeconds_k__BackingField);
				return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__ExpiresInSeconds_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000E900 File Offset: 0x0000CB00
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002E90 File Offset: 0x00001090
		public unsafe string _RefreshToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__RefreshToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__RefreshToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000E928 File Offset: 0x0000CB28
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002EAF File Offset: 0x000010AF
		public unsafe string _Scope_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__Scope_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__Scope_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000E950 File Offset: 0x0000CB50
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002ECE File Offset: 0x000010CE
		public unsafe string _IdToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__IdToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__IdToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000E978 File Offset: 0x0000CB78
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002EED File Offset: 0x000010ED
		public unsafe DateTime _IssuedUtc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__IssuedUtc_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse.NativeFieldInfoPtr__IssuedUtc_k__BackingField)) = value;
			}
		}

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_TokenRefreshTimeWindowSeconds;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_TokenHardExpiryTimeWindowSeconds;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr__AccessToken_k__BackingField;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr__TokenType_k__BackingField;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr__ExpiresInSeconds_k__BackingField;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr__RefreshToken_k__BackingField;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr__IdToken_k__BackingField;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr__IssuedUtc_k__BackingField;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessToken_Public_set_Void_String_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenType_Public_get_String_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_set_TokenType_Public_set_Void_String_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpiresInSeconds_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_set_ExpiresInSeconds_Public_set_Void_Nullable_1_Int64_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_Scope_Public_get_String_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_IdToken_Public_get_String_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_set_IdToken_Public_set_Void_String_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_get_Issued_Public_get_DateTime_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_set_Issued_Public_set_Void_DateTime_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuedUtc_Public_get_DateTime_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_set_IssuedUtc_Public_set_Void_DateTime_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_IsExpired_Public_Boolean_IClock_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_IsEffectivelyExpired_Internal_Boolean_IClock_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_FromHttpResponseAsync_Public_Static_Task_1_TokenResponse_HttpResponseMessage_IClock_ILogger_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000068 RID: 104
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Responses.TokenResponse+<FromHttpResponseAsync>d__35")]
		public sealed class _FromHttpResponseAsync_d__35 : ValueType
		{
			// Token: 0x06000665 RID: 1637 RVA: 0x0001AE88 File Offset: 0x00019088
			// Note: this type is marked as 'beforefieldinit'.
			static _FromHttpResponseAsync_d__35()
			{
				Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenResponse>.NativeClassPtr, "<FromHttpResponseAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr);
				TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, "<>1__state");
				TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, "<>t__builder");
				TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, "response");
				TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, "clock");
				TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, "logger");
				TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, "<>u__1");
				TokenResponse._FromHttpResponseAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, 100663793);
				TokenResponse._FromHttpResponseAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr, 100663794);
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x0001AF54 File Offset: 0x00019154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156816, XrefRangeEnd = 1156853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse._FromHttpResponseAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x0001AF8C File Offset: 0x0001918C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156853, XrefRangeEnd = 1156859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponse._FromHttpResponseAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x00005BD7 File Offset: 0x00003DD7
			public _FromHttpResponseAsync_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x00005BE0 File Offset: 0x00003DE0
			public _FromHttpResponseAsync_d__35()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenResponse._FromHttpResponseAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001AFD4 File Offset: 0x000191D4
			// (set) Token: 0x0600066B RID: 1643 RVA: 0x00005BF2 File Offset: 0x00003DF2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001AFFC File Offset: 0x000191FC
			// (set) Token: 0x0600066D RID: 1645 RVA: 0x00005C0D File Offset: 0x00003E0D
			public AsyncTaskMethodBuilder<TokenResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TokenResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001B02C File Offset: 0x0001922C
			// (set) Token: 0x0600066F RID: 1647 RVA: 0x00005C3B File Offset: 0x00003E3B
			public unsafe HttpResponseMessage response
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_response);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001B05C File Offset: 0x0001925C
			// (set) Token: 0x06000671 RID: 1649 RVA: 0x00005C5A File Offset: 0x00003E5A
			public unsafe IClock clock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_clock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_clock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001B08C File Offset: 0x0001928C
			// (set) Token: 0x06000673 RID: 1651 RVA: 0x00005C79 File Offset: 0x00003E79
			public unsafe ILogger logger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_logger);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr_logger), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x0001B0BC File Offset: 0x000192BC
			// (set) Token: 0x06000675 RID: 1653 RVA: 0x00005C98 File Offset: 0x00003E98
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponse._FromHttpResponseAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003D3 RID: 979
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003D4 RID: 980
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003D5 RID: 981
			private static readonly IntPtr NativeFieldInfoPtr_response;

			// Token: 0x040003D6 RID: 982
			private static readonly IntPtr NativeFieldInfoPtr_clock;

			// Token: 0x040003D7 RID: 983
			private static readonly IntPtr NativeFieldInfoPtr_logger;

			// Token: 0x040003D8 RID: 984
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003D9 RID: 985
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003DA RID: 986
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
