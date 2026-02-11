using System;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200001F RID: 31
	public class UserCredential : Object
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x0000C954 File Offset: 0x0000AB54
		// Note: this type is marked as 'beforefieldinit'.
		static UserCredential()
		{
			Il2CppClassPointerStore<UserCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "UserCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCredential>.NativeClassPtr);
			UserCredential.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "Logger");
			UserCredential.NativeFieldInfoPtr__Flow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<Flow>k__BackingField");
			UserCredential.NativeFieldInfoPtr__UserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<UserId>k__BackingField");
			UserCredential.NativeFieldInfoPtr__QuotaProject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<QuotaProject>k__BackingField");
			UserCredential.NativeFieldInfoPtr__refreshManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "_refreshManager");
			UserCredential.NativeMethodInfoPtr_get_Token_Public_get_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663703);
			UserCredential.NativeMethodInfoPtr_set_Token_Public_set_Void_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663704);
			UserCredential.NativeMethodInfoPtr_get_Flow_Public_get_IAuthorizationCodeFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663705);
			UserCredential.NativeMethodInfoPtr_get_UserId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663706);
			UserCredential.NativeMethodInfoPtr_get_QuotaProject_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663707);
			UserCredential.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663708);
			UserCredential.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_TokenResponse_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663709);
			UserCredential.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663710);
			UserCredential.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663711);
			UserCredential.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663712);
			UserCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_New_Task_1_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663713);
			UserCredential.NativeMethodInfoPtr_GetAccessTokenWithHeadersForRequestAsync_Public_Virtual_Final_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663714);
			UserCredential.NativeMethodInfoPtr_RefreshTokenAsync_Public_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663715);
			UserCredential.NativeMethodInfoPtr_RevokeTokenAsync_Public_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, 100663716);
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000CB00 File Offset: 0x0000AD00
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0000CB40 File Offset: 0x0000AD40
		public unsafe TokenResponse Token
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156435, XrefRangeEnd = 1156437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_get_Token_Public_get_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156437, XrefRangeEnd = 1156439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_set_Token_Public_set_Void_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000CB84 File Offset: 0x0000AD84
		public unsafe IAuthorizationCodeFlow Flow
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_get_Flow_Public_get_IAuthorizationCodeFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAuthorizationCodeFlow>(intPtr3) : null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		public unsafe string UserId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_get_UserId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		public unsafe string QuotaProject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_get_QuotaProject_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000CC34 File Offset: 0x0000AE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156439, XrefRangeEnd = 1156440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserCredential(IAuthorizationCodeFlow flow, string userId, TokenResponse token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCredential>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1156464, RefRangeEnd = 1156468, XrefRangeStart = 1156440, XrefRangeEnd = 1156464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserCredential(IAuthorizationCodeFlow flow, string userId, TokenResponse token, string quotaProjectId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCredential>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(token);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quotaProjectId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_TokenResponse_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000CD28 File Offset: 0x0000AF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156468, XrefRangeEnd = 1156480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task InterceptAsync(HttpRequestMessage request, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000CD90 File Offset: 0x0000AF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156480, XrefRangeEnd = 1156495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ConfigurableHttpClient httpClient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpClient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000CE24 File Offset: 0x0000B024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156495, XrefRangeEnd = 1156497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_New_Task_1_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000CE98 File Offset: 0x0000B098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156497, XrefRangeEnd = 1156513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(string authUri = null, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_GetAccessTokenWithHeadersForRequestAsync_Public_Virtual_Final_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AccessTokenWithHeaders>>(intPtr3) : null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000CF00 File Offset: 0x0000B100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156513, XrefRangeEnd = 1156528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> RefreshTokenAsync(CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_RefreshTokenAsync_Public_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000CF58 File Offset: 0x0000B158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156528, XrefRangeEnd = 1156543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> RevokeTokenAsync(CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential.NativeMethodInfoPtr_RevokeTokenAsync_Public_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002BCF File Offset: 0x00000DCF
		public UserCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000CFB0 File Offset: 0x0000B1B0
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UserCredential.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserCredential.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002BEA File Offset: 0x00000DEA
		public unsafe IAuthorizationCodeFlow _Flow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__Flow_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAuthorizationCodeFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__Flow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000D008 File Offset: 0x0000B208
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002C09 File Offset: 0x00000E09
		public unsafe string _UserId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__UserId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__UserId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000D030 File Offset: 0x0000B230
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002C28 File Offset: 0x00000E28
		public unsafe string _QuotaProject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__QuotaProject_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__QuotaProject_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000D058 File Offset: 0x0000B258
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002C47 File Offset: 0x00000E47
		public unsafe TokenRefreshManager _refreshManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__refreshManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenRefreshManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential.NativeFieldInfoPtr__refreshManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr__Flow_k__BackingField;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr__UserId_k__BackingField;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr__QuotaProject_k__BackingField;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr__refreshManager;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_TokenResponse_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_TokenResponse_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_get_Flow_Public_get_IAuthorizationCodeFlow_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_get_String_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_get_QuotaProject_Public_get_String_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_TokenResponse_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_TokenResponse_String_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_New_Task_1_String_String_CancellationToken_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenWithHeadersForRequestAsync_Public_Virtual_Final_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTokenAsync_Public_Task_1_Boolean_CancellationToken_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_RevokeTokenAsync_Public_Task_1_Boolean_CancellationToken_0;

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("Google.Apis.Auth.OAuth2.UserCredential+<InterceptAsync>d__16")]
		public sealed class _InterceptAsync_d__16 : ValueType
		{
			// Token: 0x060005DD RID: 1501 RVA: 0x00019AEC File Offset: 0x00017CEC
			// Note: this type is marked as 'beforefieldinit'.
			static _InterceptAsync_d__16()
			{
				Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<InterceptAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr);
				UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, "<>1__state");
				UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, "<>t__builder");
				UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, "<>4__this");
				UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, "request");
				UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, "taskCancellationToken");
				UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, "<>u__1");
				UserCredential._InterceptAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, 100663718);
				UserCredential._InterceptAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr, 100663719);
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x00019BB8 File Offset: 0x00017DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156181, XrefRangeEnd = 1156242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._InterceptAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x00019BF0 File Offset: 0x00017DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156242, XrefRangeEnd = 1156246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._InterceptAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x00005441 File Offset: 0x00003641
			public _InterceptAsync_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x0000544A File Offset: 0x0000364A
			public _InterceptAsync_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCredential._InterceptAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00019C38 File Offset: 0x00017E38
			// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0000545C File Offset: 0x0000365C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700021F RID: 543
			// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00019C60 File Offset: 0x00017E60
			// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00005477 File Offset: 0x00003677
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000220 RID: 544
			// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00019C90 File Offset: 0x00017E90
			// (set) Token: 0x060005E7 RID: 1511 RVA: 0x000054A5 File Offset: 0x000036A5
			public unsafe UserCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000221 RID: 545
			// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00019CC0 File Offset: 0x00017EC0
			// (set) Token: 0x060005E9 RID: 1513 RVA: 0x000054C4 File Offset: 0x000036C4
			public unsafe HttpRequestMessage request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x060005EA RID: 1514 RVA: 0x00019CF0 File Offset: 0x00017EF0
			// (set) Token: 0x060005EB RID: 1515 RVA: 0x000054E3 File Offset: 0x000036E3
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x060005EC RID: 1516 RVA: 0x00019D20 File Offset: 0x00017F20
			// (set) Token: 0x060005ED RID: 1517 RVA: 0x00005511 File Offset: 0x00003711
			public ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._InterceptAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000391 RID: 913
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000392 RID: 914
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000393 RID: 915
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000394 RID: 916
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000395 RID: 917
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x04000396 RID: 918
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000397 RID: 919
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000398 RID: 920
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000061 RID: 97
		[ObfuscatedName("Google.Apis.Auth.OAuth2.UserCredential+<HandleResponseAsync>d__17")]
		public sealed class _HandleResponseAsync_d__17 : ValueType
		{
			// Token: 0x060005EE RID: 1518 RVA: 0x00019D50 File Offset: 0x00017F50
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleResponseAsync_d__17()
			{
				Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<HandleResponseAsync>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr);
				UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr, "<>1__state");
				UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr, "<>t__builder");
				UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr, "args");
				UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr, "<>4__this");
				UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr, "<>u__1");
				UserCredential._HandleResponseAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr, 100663720);
				UserCredential._HandleResponseAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr, 100663721);
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x00019E08 File Offset: 0x00018008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156246, XrefRangeEnd = 1156288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._HandleResponseAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x00019E40 File Offset: 0x00018040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156288, XrefRangeEnd = 1156294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._HandleResponseAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x0000553F File Offset: 0x0000373F
			public _HandleResponseAsync_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x00005548 File Offset: 0x00003748
			public _HandleResponseAsync_d__17()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCredential._HandleResponseAsync_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00019E88 File Offset: 0x00018088
			// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0000555A File Offset: 0x0000375A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00019EB0 File Offset: 0x000180B0
			// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00005575 File Offset: 0x00003775
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00019EE0 File Offset: 0x000180E0
			// (set) Token: 0x060005F8 RID: 1528 RVA: 0x000055A3 File Offset: 0x000037A3
			public unsafe HandleUnsuccessfulResponseArgs args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandleUnsuccessfulResponseArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000227 RID: 551
			// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00019F10 File Offset: 0x00018110
			// (set) Token: 0x060005FA RID: 1530 RVA: 0x000055C2 File Offset: 0x000037C2
			public unsafe UserCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000228 RID: 552
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x00019F40 File Offset: 0x00018140
			// (set) Token: 0x060005FC RID: 1532 RVA: 0x000055E1 File Offset: 0x000037E1
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._HandleResponseAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000399 RID: 921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400039A RID: 922
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400039B RID: 923
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x0400039C RID: 924
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400039D RID: 925
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400039E RID: 926
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400039F RID: 927
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000062 RID: 98
		[ObfuscatedName("Google.Apis.Auth.OAuth2.UserCredential+<GetAccessTokenWithHeadersForRequestAsync>d__20")]
		public sealed class _GetAccessTokenWithHeadersForRequestAsync_d__20 : ValueType
		{
			// Token: 0x060005FD RID: 1533 RVA: 0x00019F70 File Offset: 0x00018170
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAccessTokenWithHeadersForRequestAsync_d__20()
			{
				Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<GetAccessTokenWithHeadersForRequestAsync>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr);
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, "<>1__state");
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, "<>t__builder");
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, "<>4__this");
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr_authUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, "authUri");
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, "cancellationToken");
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, "<>u__1");
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, 100663722);
				UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr, 100663723);
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x0001A03C File Offset: 0x0001823C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156294, XrefRangeEnd = 1156316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x0001A074 File Offset: 0x00018274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156316, XrefRangeEnd = 1156322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x0000560F File Offset: 0x0000380F
			public _GetAccessTokenWithHeadersForRequestAsync_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x00005618 File Offset: 0x00003818
			public _GetAccessTokenWithHeadersForRequestAsync_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17000229 RID: 553
			// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001A0BC File Offset: 0x000182BC
			// (set) Token: 0x06000603 RID: 1539 RVA: 0x0000562A File Offset: 0x0000382A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001A0E4 File Offset: 0x000182E4
			// (set) Token: 0x06000605 RID: 1541 RVA: 0x00005645 File Offset: 0x00003845
			public AsyncTaskMethodBuilder<AccessTokenWithHeaders> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AccessTokenWithHeaders>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AccessTokenWithHeaders>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AccessTokenWithHeaders>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700022B RID: 555
			// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001A114 File Offset: 0x00018314
			// (set) Token: 0x06000607 RID: 1543 RVA: 0x00005673 File Offset: 0x00003873
			public unsafe UserCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001A144 File Offset: 0x00018344
			// (set) Token: 0x06000609 RID: 1545 RVA: 0x00005692 File Offset: 0x00003892
			public unsafe string authUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr_authUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr_authUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700022D RID: 557
			// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001A16C File Offset: 0x0001836C
			// (set) Token: 0x0600060B RID: 1547 RVA: 0x000056B1 File Offset: 0x000038B1
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700022E RID: 558
			// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001A19C File Offset: 0x0001839C
			// (set) Token: 0x0600060D RID: 1549 RVA: 0x000056DF File Offset: 0x000038DF
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._GetAccessTokenWithHeadersForRequestAsync_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003A0 RID: 928
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003A1 RID: 929
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003A2 RID: 930
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003A3 RID: 931
			private static readonly IntPtr NativeFieldInfoPtr_authUri;

			// Token: 0x040003A4 RID: 932
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040003A5 RID: 933
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003A6 RID: 934
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003A7 RID: 935
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000063 RID: 99
		[ObfuscatedName("Google.Apis.Auth.OAuth2.UserCredential+<RefreshTokenAsync>d__21")]
		public sealed class _RefreshTokenAsync_d__21 : ValueType
		{
			// Token: 0x0600060E RID: 1550 RVA: 0x0001A1CC File Offset: 0x000183CC
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshTokenAsync_d__21()
			{
				Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<RefreshTokenAsync>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr);
				UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr, "<>1__state");
				UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr, "<>t__builder");
				UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr, "<>4__this");
				UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr, "taskCancellationToken");
				UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr, "<>u__1");
				UserCredential._RefreshTokenAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr, 100663724);
				UserCredential._RefreshTokenAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr, 100663725);
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x0001A284 File Offset: 0x00018484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156322, XrefRangeEnd = 1156378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._RefreshTokenAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x0001A2BC File Offset: 0x000184BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156378, XrefRangeEnd = 1156384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._RefreshTokenAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x0000570D File Offset: 0x0000390D
			public _RefreshTokenAsync_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x00005716 File Offset: 0x00003916
			public _RefreshTokenAsync_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCredential._RefreshTokenAsync_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001A304 File Offset: 0x00018504
			// (set) Token: 0x06000614 RID: 1556 RVA: 0x00005728 File Offset: 0x00003928
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001A32C File Offset: 0x0001852C
			// (set) Token: 0x06000616 RID: 1558 RVA: 0x00005743 File Offset: 0x00003943
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001A35C File Offset: 0x0001855C
			// (set) Token: 0x06000618 RID: 1560 RVA: 0x00005771 File Offset: 0x00003971
			public unsafe UserCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001A38C File Offset: 0x0001858C
			// (set) Token: 0x0600061A RID: 1562 RVA: 0x00005790 File Offset: 0x00003990
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001A3BC File Offset: 0x000185BC
			// (set) Token: 0x0600061C RID: 1564 RVA: 0x000057BE File Offset: 0x000039BE
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RefreshTokenAsync_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003A8 RID: 936
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003A9 RID: 937
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003AA RID: 938
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003AB RID: 939
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040003AC RID: 940
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003AD RID: 941
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003AE RID: 942
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000064 RID: 100
		[ObfuscatedName("Google.Apis.Auth.OAuth2.UserCredential+<RevokeTokenAsync>d__22")]
		public sealed class _RevokeTokenAsync_d__22 : ValueType
		{
			// Token: 0x0600061D RID: 1565 RVA: 0x0001A3EC File Offset: 0x000185EC
			// Note: this type is marked as 'beforefieldinit'.
			static _RevokeTokenAsync_d__22()
			{
				Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserCredential>.NativeClassPtr, "<RevokeTokenAsync>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr);
				UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr, "<>1__state");
				UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr, "<>t__builder");
				UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr, "<>4__this");
				UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr, "taskCancellationToken");
				UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr, "<>u__1");
				UserCredential._RevokeTokenAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr, 100663726);
				UserCredential._RevokeTokenAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr, 100663727);
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x0001A4A4 File Offset: 0x000186A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156384, XrefRangeEnd = 1156429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._RevokeTokenAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x0001A4DC File Offset: 0x000186DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156429, XrefRangeEnd = 1156435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserCredential._RevokeTokenAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x000057EC File Offset: 0x000039EC
			public _RevokeTokenAsync_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000621 RID: 1569 RVA: 0x000057F5 File Offset: 0x000039F5
			public _RevokeTokenAsync_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCredential._RevokeTokenAsync_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x06000622 RID: 1570 RVA: 0x0001A524 File Offset: 0x00018724
			// (set) Token: 0x06000623 RID: 1571 RVA: 0x00005807 File Offset: 0x00003A07
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001A54C File Offset: 0x0001874C
			// (set) Token: 0x06000625 RID: 1573 RVA: 0x00005822 File Offset: 0x00003A22
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001A57C File Offset: 0x0001877C
			// (set) Token: 0x06000627 RID: 1575 RVA: 0x00005850 File Offset: 0x00003A50
			public unsafe UserCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x06000628 RID: 1576 RVA: 0x0001A5AC File Offset: 0x000187AC
			// (set) Token: 0x06000629 RID: 1577 RVA: 0x0000586F File Offset: 0x00003A6F
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001A5DC File Offset: 0x000187DC
			// (set) Token: 0x0600062B RID: 1579 RVA: 0x0000589D File Offset: 0x00003A9D
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserCredential._RevokeTokenAsync_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003AF RID: 943
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003B0 RID: 944
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003B1 RID: 945
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003B2 RID: 946
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040003B3 RID: 947
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003B4 RID: 948
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003B5 RID: 949
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
