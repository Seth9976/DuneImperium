using System;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Flows
{
	// Token: 0x0200002F RID: 47
	public class AuthorizationCodeFlow : Object
	{
		// Token: 0x060002AC RID: 684 RVA: 0x000104EC File Offset: 0x0000E6EC
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorizationCodeFlow()
		{
			Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Flows", "AuthorizationCodeFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr);
			AuthorizationCodeFlow.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "Logger");
			AuthorizationCodeFlow.NativeFieldInfoPtr_accessMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "accessMethod");
			AuthorizationCodeFlow.NativeFieldInfoPtr_tokenServerUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "tokenServerUrl");
			AuthorizationCodeFlow.NativeFieldInfoPtr_authorizationServerUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "authorizationServerUrl");
			AuthorizationCodeFlow.NativeFieldInfoPtr_clientSecrets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "clientSecrets");
			AuthorizationCodeFlow.NativeFieldInfoPtr_dataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "dataStore");
			AuthorizationCodeFlow.NativeFieldInfoPtr_scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "scopes");
			AuthorizationCodeFlow.NativeFieldInfoPtr_httpClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "httpClient");
			AuthorizationCodeFlow.NativeFieldInfoPtr_clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "clock");
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663856);
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663857);
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_ClientSecrets_Public_get_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663858);
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_DataStore_Public_Virtual_Final_New_get_IDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663859);
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663860);
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_HttpClient_Public_get_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663861);
			AuthorizationCodeFlow.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663862);
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_AccessMethod_Public_Virtual_Final_New_get_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663863);
			AuthorizationCodeFlow.NativeMethodInfoPtr_get_Clock_Public_Virtual_Final_New_get_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663864);
			AuthorizationCodeFlow.NativeMethodInfoPtr_LoadTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663865);
			AuthorizationCodeFlow.NativeMethodInfoPtr_DeleteTokenAsync_Public_Virtual_Final_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663866);
			AuthorizationCodeFlow.NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Virtual_New_AuthorizationCodeRequestUrl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663867);
			AuthorizationCodeFlow.NativeMethodInfoPtr_ExchangeCodeForTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663868);
			AuthorizationCodeFlow.NativeMethodInfoPtr_RefreshTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663869);
			AuthorizationCodeFlow.NativeMethodInfoPtr_RevokeTokenAsync_Public_Virtual_New_Task_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663870);
			AuthorizationCodeFlow.NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663871);
			AuthorizationCodeFlow.NativeMethodInfoPtr_StoreTokenAsync_Private_Task_String_TokenResponse_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663872);
			AuthorizationCodeFlow.NativeMethodInfoPtr_FetchTokenAsync_Public_Task_1_TokenResponse_String_TokenRequest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663873);
			AuthorizationCodeFlow.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, 100663874);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0001074C File Offset: 0x0000E94C
		public unsafe string TokenServerUrl
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00010784 File Offset: 0x0000E984
		public unsafe string AuthorizationServerUrl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002AF RID: 687 RVA: 0x000107BC File Offset: 0x0000E9BC
		public unsafe ClientSecrets ClientSecrets
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_ClientSecrets_Public_get_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr3) : null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000107FC File Offset: 0x0000E9FC
		public unsafe virtual IDataStore DataStore
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_DataStore_Public_Virtual_Final_New_get_IDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr3) : null;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001083C File Offset: 0x0000EA3C
		public unsafe IEnumerable<string> Scopes
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001087C File Offset: 0x0000EA7C
		public unsafe ConfigurableHttpClient HttpClient
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_HttpClient_Public_get_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000108BC File Offset: 0x0000EABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1157391, RefRangeEnd = 1157392, XrefRangeStart = 1157304, XrefRangeEnd = 1157391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeFlow(AuthorizationCodeFlow.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00010908 File Offset: 0x0000EB08
		public unsafe virtual IAccessMethod AccessMethod
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_AccessMethod_Public_Virtual_Final_New_get_IAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr3) : null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00010948 File Offset: 0x0000EB48
		public unsafe virtual IClock Clock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_get_Clock_Public_Virtual_Final_New_get_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr3) : null;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00010988 File Offset: 0x0000EB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157392, XrefRangeEnd = 1157408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<TokenResponse> LoadTokenAsync(string userId, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_LoadTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000109F0 File Offset: 0x0000EBF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1157420, RefRangeEnd = 1157422, XrefRangeStart = 1157408, XrefRangeEnd = 1157420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task DeleteTokenAsync(string userId, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_DeleteTokenAsync_Public_Virtual_Final_New_Task_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00010A58 File Offset: 0x0000EC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157422, XrefRangeEnd = 1157441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(redirectUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthorizationCodeFlow.NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Virtual_New_AuthorizationCodeRequestUrl_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeRequestUrl>(intPtr3) : null;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00010AB4 File Offset: 0x0000ECB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157441, XrefRangeEnd = 1157459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string redirectUri, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(redirectUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_ExchangeCodeForTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_String_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00010B40 File Offset: 0x0000ED40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157459, XrefRangeEnd = 1157476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<TokenResponse> RefreshTokenAsync(string userId, string refreshToken, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(refreshToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_RefreshTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00010BBC File Offset: 0x0000EDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157476, XrefRangeEnd = 1157482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task RevokeTokenAsync(string userId, string token, CancellationToken taskCancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthorizationCodeFlow.NativeMethodInfoPtr_RevokeTokenAsync_Public_Virtual_New_Task_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00010C40 File Offset: 0x0000EE40
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldForceTokenRetrieval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthorizationCodeFlow.NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00010C88 File Offset: 0x0000EE88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1157495, RefRangeEnd = 1157497, XrefRangeStart = 1157482, XrefRangeEnd = 1157495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task StoreTokenAsync(string userId, TokenResponse token, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(token);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_StoreTokenAsync_Private_Task_String_TokenResponse_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00010D04 File Offset: 0x0000EF04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1157514, RefRangeEnd = 1157516, XrefRangeStart = 1157497, XrefRangeEnd = 1157514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TokenResponse> FetchTokenAsync(string userId, TokenRequest request, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_FetchTokenAsync_Public_Task_1_TokenResponse_String_TokenRequest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00010D80 File Offset: 0x0000EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157516, XrefRangeEnd = 1157517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000032B1 File Offset: 0x000014B1
		public AuthorizationCodeFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000032BA File Offset: 0x000014BA
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthorizationCodeFlow.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthorizationCodeFlow.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00010DDC File Offset: 0x0000EFDC
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x000032CC File Offset: 0x000014CC
		public unsafe IAccessMethod accessMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_accessMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_accessMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00010E0C File Offset: 0x0000F00C
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000032EB File Offset: 0x000014EB
		public unsafe string tokenServerUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_tokenServerUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_tokenServerUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00010E34 File Offset: 0x0000F034
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0000330A File Offset: 0x0000150A
		public unsafe string authorizationServerUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_authorizationServerUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_authorizationServerUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00010E5C File Offset: 0x0000F05C
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00003329 File Offset: 0x00001529
		public unsafe ClientSecrets clientSecrets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_clientSecrets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_clientSecrets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00010E8C File Offset: 0x0000F08C
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003348 File Offset: 0x00001548
		public unsafe IDataStore dataStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_dataStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_dataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00010EBC File Offset: 0x0000F0BC
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00003367 File Offset: 0x00001567
		public unsafe IEnumerable<string> scopes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_scopes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00010EEC File Offset: 0x0000F0EC
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003386 File Offset: 0x00001586
		public unsafe ConfigurableHttpClient httpClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_httpClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_httpClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00010F1C File Offset: 0x0000F11C
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000033A5 File Offset: 0x000015A5
		public unsafe IClock clock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_clock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.NativeFieldInfoPtr_clock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_accessMethod;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_tokenServerUrl;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_authorizationServerUrl;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_clientSecrets;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_dataStore;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_scopes;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_httpClient;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_clock;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_String_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientSecrets_Public_get_ClientSecrets_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_DataStore_Public_Virtual_Final_New_get_IDataStore_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClient_Public_get_ConfigurableHttpClient_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Initializer_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMethod_Public_Virtual_Final_New_get_IAccessMethod_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_Clock_Public_Virtual_Final_New_get_IClock_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_LoadTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_CancellationToken_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_DeleteTokenAsync_Public_Virtual_Final_New_Task_String_CancellationToken_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Virtual_New_AuthorizationCodeRequestUrl_String_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_ExchangeCodeForTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_String_String_CancellationToken_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTokenAsync_Public_Virtual_Final_New_Task_1_TokenResponse_String_String_CancellationToken_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_RevokeTokenAsync_Public_Virtual_New_Task_String_String_CancellationToken_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Virtual_New_Boolean_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_StoreTokenAsync_Private_Task_String_TokenResponse_CancellationToken_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_FetchTokenAsync_Public_Task_1_TokenResponse_String_TokenRequest_CancellationToken_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200006A RID: 106
		public class Initializer : Object
		{
			// Token: 0x0600068F RID: 1679 RVA: 0x0001B458 File Offset: 0x00019658
			// Note: this type is marked as 'beforefieldinit'.
			static Initializer()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "Initializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr);
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__AccessMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<AccessMethod>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__TokenServerUrl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<TokenServerUrl>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__AuthorizationServerUrl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<AuthorizationServerUrl>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ClientSecrets_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<ClientSecrets>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ClientSecretsStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<ClientSecretsStream>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__DataStore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<DataStore>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Scopes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<Scopes>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<HttpClientFactory>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<DefaultExponentialBackOffPolicy>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Clock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, "<Clock>k__BackingField");
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663876);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_AccessMethod_Public_set_Void_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663877);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663878);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_TokenServerUrl_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663879);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663880);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_AuthorizationServerUrl_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663881);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_ClientSecrets_Public_get_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663882);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_ClientSecrets_Public_set_Void_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663883);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_ClientSecretsStream_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663884);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_ClientSecretsStream_Public_set_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663885);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_DataStore_Public_get_IDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663886);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_DataStore_Public_set_Void_IDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663887);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663888);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Scopes_Public_set_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663889);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663890);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663891);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663892);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663893);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663894);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663895);
				AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr, 100663896);
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000690 RID: 1680 RVA: 0x0001B6F0 File Offset: 0x000198F0
			// (set) Token: 0x06000691 RID: 1681 RVA: 0x0001B730 File Offset: 0x00019930
			public unsafe IAccessMethod AccessMethod
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_AccessMethod_Public_set_Void_IAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000692 RID: 1682 RVA: 0x0001B774 File Offset: 0x00019974
			// (set) Token: 0x06000693 RID: 1683 RVA: 0x0001B7AC File Offset: 0x000199AC
			public unsafe string TokenServerUrl
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_TokenServerUrl_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000694 RID: 1684 RVA: 0x0001B7F0 File Offset: 0x000199F0
			// (set) Token: 0x06000695 RID: 1685 RVA: 0x0001B828 File Offset: 0x00019A28
			public unsafe string AuthorizationServerUrl
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_AuthorizationServerUrl_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000696 RID: 1686 RVA: 0x0001B86C File Offset: 0x00019A6C
			// (set) Token: 0x06000697 RID: 1687 RVA: 0x0001B8AC File Offset: 0x00019AAC
			public unsafe ClientSecrets ClientSecrets
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_ClientSecrets_Public_get_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_ClientSecrets_Public_set_Void_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001B8F0 File Offset: 0x00019AF0
			// (set) Token: 0x06000699 RID: 1689 RVA: 0x0001B930 File Offset: 0x00019B30
			public unsafe Stream ClientSecretsStream
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_ClientSecretsStream_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_ClientSecretsStream_Public_set_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x0600069A RID: 1690 RVA: 0x0001B974 File Offset: 0x00019B74
			// (set) Token: 0x0600069B RID: 1691 RVA: 0x0001B9B4 File Offset: 0x00019BB4
			public unsafe IDataStore DataStore
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_DataStore_Public_get_IDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_DataStore_Public_set_Void_IDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001B9F8 File Offset: 0x00019BF8
			// (set) Token: 0x0600069D RID: 1693 RVA: 0x0001BA38 File Offset: 0x00019C38
			public unsafe IEnumerable<string> Scopes
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Scopes_Public_set_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001BA7C File Offset: 0x00019C7C
			// (set) Token: 0x0600069F RID: 1695 RVA: 0x0001BABC File Offset: 0x00019CBC
			public unsafe IHttpClientFactory HttpClientFactory
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0001BB00 File Offset: 0x00019D00
			// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0001BB3C File Offset: 0x00019D3C
			public unsafe ExponentialBackOffPolicy DefaultExponentialBackOffPolicy
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0001BB7C File Offset: 0x00019D7C
			// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0001BBBC File Offset: 0x00019DBC
			public unsafe IClock Clock
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x0001BC00 File Offset: 0x00019E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157063, XrefRangeEnd = 1157083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(string authorizationServerUrl, string tokenServerUrl)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow.Initializer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(authorizationServerUrl);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tokenServerUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00005E4F File Offset: 0x0000404F
			public Initializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0001BC60 File Offset: 0x00019E60
			// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00005E58 File Offset: 0x00004058
			public unsafe IAccessMethod _AccessMethod_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__AccessMethod_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__AccessMethod_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0001BC90 File Offset: 0x00019E90
			// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00005E77 File Offset: 0x00004077
			public unsafe string _TokenServerUrl_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__TokenServerUrl_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__TokenServerUrl_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x060006AA RID: 1706 RVA: 0x0001BCB8 File Offset: 0x00019EB8
			// (set) Token: 0x060006AB RID: 1707 RVA: 0x00005E96 File Offset: 0x00004096
			public unsafe string _AuthorizationServerUrl_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__AuthorizationServerUrl_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__AuthorizationServerUrl_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x060006AC RID: 1708 RVA: 0x0001BCE0 File Offset: 0x00019EE0
			// (set) Token: 0x060006AD RID: 1709 RVA: 0x00005EB5 File Offset: 0x000040B5
			public unsafe ClientSecrets _ClientSecrets_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ClientSecrets_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ClientSecrets_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x060006AE RID: 1710 RVA: 0x0001BD10 File Offset: 0x00019F10
			// (set) Token: 0x060006AF RID: 1711 RVA: 0x00005ED4 File Offset: 0x000040D4
			public unsafe Stream _ClientSecretsStream_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ClientSecretsStream_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__ClientSecretsStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0001BD40 File Offset: 0x00019F40
			// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00005EF3 File Offset: 0x000040F3
			public unsafe IDataStore _DataStore_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__DataStore_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__DataStore_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0001BD70 File Offset: 0x00019F70
			// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00005F12 File Offset: 0x00004112
			public unsafe IEnumerable<string> _Scopes_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Scopes_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Scopes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0001BDA0 File Offset: 0x00019FA0
			// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00005F31 File Offset: 0x00004131
			public unsafe IHttpClientFactory _HttpClientFactory_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0001BDD0 File Offset: 0x00019FD0
			// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00005F50 File Offset: 0x00004150
			public unsafe ExponentialBackOffPolicy _DefaultExponentialBackOffPolicy_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField)) = value;
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001BDF8 File Offset: 0x00019FF8
			// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00005F6B File Offset: 0x0000416B
			public unsafe IClock _Clock_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Clock_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow.Initializer.NativeFieldInfoPtr__Clock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003E7 RID: 999
			private static readonly IntPtr NativeFieldInfoPtr__AccessMethod_k__BackingField;

			// Token: 0x040003E8 RID: 1000
			private static readonly IntPtr NativeFieldInfoPtr__TokenServerUrl_k__BackingField;

			// Token: 0x040003E9 RID: 1001
			private static readonly IntPtr NativeFieldInfoPtr__AuthorizationServerUrl_k__BackingField;

			// Token: 0x040003EA RID: 1002
			private static readonly IntPtr NativeFieldInfoPtr__ClientSecrets_k__BackingField;

			// Token: 0x040003EB RID: 1003
			private static readonly IntPtr NativeFieldInfoPtr__ClientSecretsStream_k__BackingField;

			// Token: 0x040003EC RID: 1004
			private static readonly IntPtr NativeFieldInfoPtr__DataStore_k__BackingField;

			// Token: 0x040003ED RID: 1005
			private static readonly IntPtr NativeFieldInfoPtr__Scopes_k__BackingField;

			// Token: 0x040003EE RID: 1006
			private static readonly IntPtr NativeFieldInfoPtr__HttpClientFactory_k__BackingField;

			// Token: 0x040003EF RID: 1007
			private static readonly IntPtr NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField;

			// Token: 0x040003F0 RID: 1008
			private static readonly IntPtr NativeFieldInfoPtr__Clock_k__BackingField;

			// Token: 0x040003F1 RID: 1009
			private static readonly IntPtr NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0;

			// Token: 0x040003F2 RID: 1010
			private static readonly IntPtr NativeMethodInfoPtr_set_AccessMethod_Public_set_Void_IAccessMethod_0;

			// Token: 0x040003F3 RID: 1011
			private static readonly IntPtr NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0;

			// Token: 0x040003F4 RID: 1012
			private static readonly IntPtr NativeMethodInfoPtr_set_TokenServerUrl_Private_set_Void_String_0;

			// Token: 0x040003F5 RID: 1013
			private static readonly IntPtr NativeMethodInfoPtr_get_AuthorizationServerUrl_Public_get_String_0;

			// Token: 0x040003F6 RID: 1014
			private static readonly IntPtr NativeMethodInfoPtr_set_AuthorizationServerUrl_Private_set_Void_String_0;

			// Token: 0x040003F7 RID: 1015
			private static readonly IntPtr NativeMethodInfoPtr_get_ClientSecrets_Public_get_ClientSecrets_0;

			// Token: 0x040003F8 RID: 1016
			private static readonly IntPtr NativeMethodInfoPtr_set_ClientSecrets_Public_set_Void_ClientSecrets_0;

			// Token: 0x040003F9 RID: 1017
			private static readonly IntPtr NativeMethodInfoPtr_get_ClientSecretsStream_Public_get_Stream_0;

			// Token: 0x040003FA RID: 1018
			private static readonly IntPtr NativeMethodInfoPtr_set_ClientSecretsStream_Public_set_Void_Stream_0;

			// Token: 0x040003FB RID: 1019
			private static readonly IntPtr NativeMethodInfoPtr_get_DataStore_Public_get_IDataStore_0;

			// Token: 0x040003FC RID: 1020
			private static readonly IntPtr NativeMethodInfoPtr_set_DataStore_Public_set_Void_IDataStore_0;

			// Token: 0x040003FD RID: 1021
			private static readonly IntPtr NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0;

			// Token: 0x040003FE RID: 1022
			private static readonly IntPtr NativeMethodInfoPtr_set_Scopes_Public_set_Void_IEnumerable_1_String_0;

			// Token: 0x040003FF RID: 1023
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0;

			// Token: 0x04000400 RID: 1024
			private static readonly IntPtr NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0;

			// Token: 0x04000401 RID: 1025
			private static readonly IntPtr NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0;

			// Token: 0x04000402 RID: 1026
			private static readonly IntPtr NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0;

			// Token: 0x04000403 RID: 1027
			private static readonly IntPtr NativeMethodInfoPtr_get_Clock_Public_get_IClock_0;

			// Token: 0x04000404 RID: 1028
			private static readonly IntPtr NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0;

			// Token: 0x04000405 RID: 1029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
		}

		// Token: 0x0200006B RID: 107
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.AuthorizationCodeFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060006BA RID: 1722 RVA: 0x0001BE28 File Offset: 0x0001A028
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow.__c>.NativeClassPtr);
				AuthorizationCodeFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.__c>.NativeClassPtr, "<>9");
				AuthorizationCodeFlow.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow.__c>.NativeClassPtr, "<>9__22_0");
				AuthorizationCodeFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.__c>.NativeClassPtr, 100663898);
				AuthorizationCodeFlow.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_BackOffHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow.__c>.NativeClassPtr, 100663899);
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x0001BEE0 File Offset: 0x0001A0E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157083, XrefRangeEnd = 1157091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BackOffHandler __ctor_b__22_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_BackOffHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BackOffHandler>(intPtr3) : null;
			}

			// Token: 0x060006BD RID: 1725 RVA: 0x00005F8A File Offset: 0x0000418A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x060006BE RID: 1726 RVA: 0x0001BF20 File Offset: 0x0001A120
			// (set) Token: 0x060006BF RID: 1727 RVA: 0x00005F93 File Offset: 0x00004193
			public unsafe static AuthorizationCodeFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AuthorizationCodeFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AuthorizationCodeFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001BF48 File Offset: 0x0001A148
			// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00005FA5 File Offset: 0x000041A5
			public unsafe static Func<BackOffHandler> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AuthorizationCodeFlow.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BackOffHandler>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AuthorizationCodeFlow.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000406 RID: 1030
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000407 RID: 1031
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04000408 RID: 1032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000409 RID: 1033
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__22_0_Internal_BackOffHandler_0;
		}

		// Token: 0x0200006C RID: 108
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.AuthorizationCodeFlow+<LoadTokenAsync>d__27")]
		public sealed class _LoadTokenAsync_d__27 : ValueType
		{
			// Token: 0x060006C2 RID: 1730 RVA: 0x0001BF70 File Offset: 0x0001A170
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadTokenAsync_d__27()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "<LoadTokenAsync>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr);
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, "<>1__state");
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, "<>4__this");
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, "userId");
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, "<>u__1");
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, 100663900);
				AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr, 100663901);
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x0001C03C File Offset: 0x0001A23C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157091, XrefRangeEnd = 1157125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x0001C074 File Offset: 0x0001A274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157125, XrefRangeEnd = 1157131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x00005FB7 File Offset: 0x000041B7
			public _LoadTokenAsync_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x00005FC0 File Offset: 0x000041C0
			public _LoadTokenAsync_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow._LoadTokenAsync_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0001C0BC File Offset: 0x0001A2BC
			// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00005FD2 File Offset: 0x000041D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
			// (set) Token: 0x060006CA RID: 1738 RVA: 0x00005FED File Offset: 0x000041ED
			public AsyncTaskMethodBuilder<TokenResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TokenResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x060006CB RID: 1739 RVA: 0x0001C114 File Offset: 0x0001A314
			// (set) Token: 0x060006CC RID: 1740 RVA: 0x0000601B File Offset: 0x0000421B
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x060006CD RID: 1741 RVA: 0x0001C144 File Offset: 0x0001A344
			// (set) Token: 0x060006CE RID: 1742 RVA: 0x00006049 File Offset: 0x00004249
			public unsafe AuthorizationCodeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x060006CF RID: 1743 RVA: 0x0001C174 File Offset: 0x0001A374
			// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00006068 File Offset: 0x00004268
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001C19C File Offset: 0x0001A39C
			// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00006087 File Offset: 0x00004287
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._LoadTokenAsync_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400040A RID: 1034
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400040B RID: 1035
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400040C RID: 1036
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x0400040D RID: 1037
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400040E RID: 1038
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x0400040F RID: 1039
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000410 RID: 1040
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000411 RID: 1041
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200006D RID: 109
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.AuthorizationCodeFlow+<DeleteTokenAsync>d__28")]
		public sealed class _DeleteTokenAsync_d__28 : ValueType
		{
			// Token: 0x060006D3 RID: 1747 RVA: 0x0001C1CC File Offset: 0x0001A3CC
			// Note: this type is marked as 'beforefieldinit'.
			static _DeleteTokenAsync_d__28()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "<DeleteTokenAsync>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr);
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, "<>1__state");
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, "<>4__this");
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, "userId");
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, "<>u__1");
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, 100663902);
				AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr, 100663903);
			}

			// Token: 0x060006D4 RID: 1748 RVA: 0x0001C298 File Offset: 0x0001A498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157131, XrefRangeEnd = 1157148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006D5 RID: 1749 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157148, XrefRangeEnd = 1157152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x000060B5 File Offset: 0x000042B5
			public _DeleteTokenAsync_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x000060BE File Offset: 0x000042BE
			public _DeleteTokenAsync_d__28()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow._DeleteTokenAsync_d__28>.NativeClassPtr))
			{
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0001C318 File Offset: 0x0001A518
			// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000060D0 File Offset: 0x000042D0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001C340 File Offset: 0x0001A540
			// (set) Token: 0x060006DB RID: 1755 RVA: 0x000060EB File Offset: 0x000042EB
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001C370 File Offset: 0x0001A570
			// (set) Token: 0x060006DD RID: 1757 RVA: 0x00006119 File Offset: 0x00004319
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001C3A0 File Offset: 0x0001A5A0
			// (set) Token: 0x060006DF RID: 1759 RVA: 0x00006147 File Offset: 0x00004347
			public unsafe AuthorizationCodeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
			// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00006166 File Offset: 0x00004366
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
			// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00006185 File Offset: 0x00004385
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._DeleteTokenAsync_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000412 RID: 1042
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000413 RID: 1043
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000414 RID: 1044
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x04000415 RID: 1045
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000416 RID: 1046
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04000417 RID: 1047
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000418 RID: 1048
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000419 RID: 1049
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200006E RID: 110
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.AuthorizationCodeFlow+<ExchangeCodeForTokenAsync>d__30")]
		public sealed class _ExchangeCodeForTokenAsync_d__30 : ValueType
		{
			// Token: 0x060006E4 RID: 1764 RVA: 0x0001C428 File Offset: 0x0001A628
			// Note: this type is marked as 'beforefieldinit'.
			static _ExchangeCodeForTokenAsync_d__30()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "<ExchangeCodeForTokenAsync>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr);
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "<>1__state");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "<>4__this");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_redirectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "redirectUri");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "code");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "userId");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr__token_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "<token>5__2");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "<>u__1");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, "<>u__2");
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, 100663904);
				AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr, 100663905);
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x0001C544 File Offset: 0x0001A744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157152, XrefRangeEnd = 1157189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006E6 RID: 1766 RVA: 0x0001C57C File Offset: 0x0001A77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157189, XrefRangeEnd = 1157195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x000061B3 File Offset: 0x000043B3
			public _ExchangeCodeForTokenAsync_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x000061BC File Offset: 0x000043BC
			public _ExchangeCodeForTokenAsync_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
			// (set) Token: 0x060006EA RID: 1770 RVA: 0x000061CE File Offset: 0x000043CE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x060006EB RID: 1771 RVA: 0x0001C5EC File Offset: 0x0001A7EC
			// (set) Token: 0x060006EC RID: 1772 RVA: 0x000061E9 File Offset: 0x000043E9
			public AsyncTaskMethodBuilder<TokenResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TokenResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x060006ED RID: 1773 RVA: 0x0001C61C File Offset: 0x0001A81C
			// (set) Token: 0x060006EE RID: 1774 RVA: 0x00006217 File Offset: 0x00004417
			public unsafe AuthorizationCodeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x060006EF RID: 1775 RVA: 0x0001C64C File Offset: 0x0001A84C
			// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00006236 File Offset: 0x00004436
			public unsafe string redirectUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_redirectUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_redirectUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0001C674 File Offset: 0x0001A874
			// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00006255 File Offset: 0x00004455
			public unsafe string code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_code);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0001C69C File Offset: 0x0001A89C
			// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00006274 File Offset: 0x00004474
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0001C6C4 File Offset: 0x0001A8C4
			// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00006293 File Offset: 0x00004493
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
			// (set) Token: 0x060006F8 RID: 1784 RVA: 0x000062C1 File Offset: 0x000044C1
			public unsafe TokenResponse _token_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr__token_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr__token_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0001C724 File Offset: 0x0001A924
			// (set) Token: 0x060006FA RID: 1786 RVA: 0x000062E0 File Offset: 0x000044E0
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x060006FB RID: 1787 RVA: 0x0001C754 File Offset: 0x0001A954
			// (set) Token: 0x060006FC RID: 1788 RVA: 0x0000630E File Offset: 0x0000450E
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._ExchangeCodeForTokenAsync_d__30.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400041A RID: 1050
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400041B RID: 1051
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400041C RID: 1052
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400041D RID: 1053
			private static readonly IntPtr NativeFieldInfoPtr_redirectUri;

			// Token: 0x0400041E RID: 1054
			private static readonly IntPtr NativeFieldInfoPtr_code;

			// Token: 0x0400041F RID: 1055
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04000420 RID: 1056
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x04000421 RID: 1057
			private static readonly IntPtr NativeFieldInfoPtr__token_5__2;

			// Token: 0x04000422 RID: 1058
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000423 RID: 1059
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000424 RID: 1060
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000425 RID: 1061
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200006F RID: 111
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.AuthorizationCodeFlow+<RefreshTokenAsync>d__31")]
		public sealed class _RefreshTokenAsync_d__31 : ValueType
		{
			// Token: 0x060006FD RID: 1789 RVA: 0x0001C784 File Offset: 0x0001A984
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshTokenAsync_d__31()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "<RefreshTokenAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr);
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "<>1__state");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_refreshToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "refreshToken");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "<>4__this");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "userId");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr__token_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "<token>5__2");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "<>u__1");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, "<>u__2");
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, 100663906);
				AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr, 100663907);
			}

			// Token: 0x060006FE RID: 1790 RVA: 0x0001C88C File Offset: 0x0001AA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157195, XrefRangeEnd = 1157227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006FF RID: 1791 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157227, XrefRangeEnd = 1157233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000700 RID: 1792 RVA: 0x0000633C File Offset: 0x0000453C
			public _RefreshTokenAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x00006345 File Offset: 0x00004545
			public _RefreshTokenAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow._RefreshTokenAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001C90C File Offset: 0x0001AB0C
			// (set) Token: 0x06000703 RID: 1795 RVA: 0x00006357 File Offset: 0x00004557
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000704 RID: 1796 RVA: 0x0001C934 File Offset: 0x0001AB34
			// (set) Token: 0x06000705 RID: 1797 RVA: 0x00006372 File Offset: 0x00004572
			public AsyncTaskMethodBuilder<TokenResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TokenResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000706 RID: 1798 RVA: 0x0001C964 File Offset: 0x0001AB64
			// (set) Token: 0x06000707 RID: 1799 RVA: 0x000063A0 File Offset: 0x000045A0
			public unsafe string refreshToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_refreshToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_refreshToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000708 RID: 1800 RVA: 0x0001C98C File Offset: 0x0001AB8C
			// (set) Token: 0x06000709 RID: 1801 RVA: 0x000063BF File Offset: 0x000045BF
			public unsafe AuthorizationCodeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x0600070A RID: 1802 RVA: 0x0001C9BC File Offset: 0x0001ABBC
			// (set) Token: 0x0600070B RID: 1803 RVA: 0x000063DE File Offset: 0x000045DE
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x0600070C RID: 1804 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
			// (set) Token: 0x0600070D RID: 1805 RVA: 0x000063FD File Offset: 0x000045FD
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x0600070E RID: 1806 RVA: 0x0001CA14 File Offset: 0x0001AC14
			// (set) Token: 0x0600070F RID: 1807 RVA: 0x0000642B File Offset: 0x0000462B
			public unsafe TokenResponse _token_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr__token_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr__token_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001CA44 File Offset: 0x0001AC44
			// (set) Token: 0x06000711 RID: 1809 RVA: 0x0000644A File Offset: 0x0000464A
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001CA74 File Offset: 0x0001AC74
			// (set) Token: 0x06000713 RID: 1811 RVA: 0x00006478 File Offset: 0x00004678
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._RefreshTokenAsync_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000426 RID: 1062
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000427 RID: 1063
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000428 RID: 1064
			private static readonly IntPtr NativeFieldInfoPtr_refreshToken;

			// Token: 0x04000429 RID: 1065
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400042A RID: 1066
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x0400042B RID: 1067
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x0400042C RID: 1068
			private static readonly IntPtr NativeFieldInfoPtr__token_5__2;

			// Token: 0x0400042D RID: 1069
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400042E RID: 1070
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400042F RID: 1071
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000430 RID: 1072
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000070 RID: 112
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.AuthorizationCodeFlow+<StoreTokenAsync>d__34")]
		public sealed class _StoreTokenAsync_d__34 : ValueType
		{
			// Token: 0x06000714 RID: 1812 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
			// Note: this type is marked as 'beforefieldinit'.
			static _StoreTokenAsync_d__34()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "<StoreTokenAsync>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr);
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, "<>1__state");
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, "<>4__this");
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, "userId");
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, "token");
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, "<>u__1");
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, 100663908);
				AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr, 100663909);
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x0001CB84 File Offset: 0x0001AD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157233, XrefRangeEnd = 1157250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000716 RID: 1814 RVA: 0x0001CBBC File Offset: 0x0001ADBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157250, XrefRangeEnd = 1157254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000717 RID: 1815 RVA: 0x000064A6 File Offset: 0x000046A6
			public _StoreTokenAsync_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000718 RID: 1816 RVA: 0x000064AF File Offset: 0x000046AF
			public _StoreTokenAsync_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow._StoreTokenAsync_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x06000719 RID: 1817 RVA: 0x0001CC04 File Offset: 0x0001AE04
			// (set) Token: 0x0600071A RID: 1818 RVA: 0x000064C1 File Offset: 0x000046C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x0600071B RID: 1819 RVA: 0x0001CC2C File Offset: 0x0001AE2C
			// (set) Token: 0x0600071C RID: 1820 RVA: 0x000064DC File Offset: 0x000046DC
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x0600071D RID: 1821 RVA: 0x0001CC5C File Offset: 0x0001AE5C
			// (set) Token: 0x0600071E RID: 1822 RVA: 0x0000650A File Offset: 0x0000470A
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x0600071F RID: 1823 RVA: 0x0001CC8C File Offset: 0x0001AE8C
			// (set) Token: 0x06000720 RID: 1824 RVA: 0x00006538 File Offset: 0x00004738
			public unsafe AuthorizationCodeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000721 RID: 1825 RVA: 0x0001CCBC File Offset: 0x0001AEBC
			// (set) Token: 0x06000722 RID: 1826 RVA: 0x00006557 File Offset: 0x00004757
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001CCE4 File Offset: 0x0001AEE4
			// (set) Token: 0x06000724 RID: 1828 RVA: 0x00006576 File Offset: 0x00004776
			public unsafe TokenResponse token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_token);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr_token), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000725 RID: 1829 RVA: 0x0001CD14 File Offset: 0x0001AF14
			// (set) Token: 0x06000726 RID: 1830 RVA: 0x00006595 File Offset: 0x00004795
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._StoreTokenAsync_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000431 RID: 1073
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000432 RID: 1074
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000433 RID: 1075
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x04000434 RID: 1076
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000435 RID: 1077
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04000436 RID: 1078
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x04000437 RID: 1079
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000438 RID: 1080
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000439 RID: 1081
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000071 RID: 113
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Flows.AuthorizationCodeFlow+<FetchTokenAsync>d__35")]
		public sealed class _FetchTokenAsync_d__35 : ValueType
		{
			// Token: 0x06000727 RID: 1831 RVA: 0x0001CD44 File Offset: 0x0001AF44
			// Note: this type is marked as 'beforefieldinit'.
			static _FetchTokenAsync_d__35()
			{
				Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeFlow>.NativeClassPtr, "<FetchTokenAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr);
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "<>1__state");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "request");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "<>4__this");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "userId");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "<>7__wrap1");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "<>u__1");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, "<>u__2");
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, 100663910);
				AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr, 100663911);
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x0001CE4C File Offset: 0x0001B04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157254, XrefRangeEnd = 1157298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000729 RID: 1833 RVA: 0x0001CE84 File Offset: 0x0001B084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157298, XrefRangeEnd = 1157304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x000065C3 File Offset: 0x000047C3
			public _FetchTokenAsync_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x000065CC File Offset: 0x000047CC
			public _FetchTokenAsync_d__35()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeFlow._FetchTokenAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x0600072C RID: 1836 RVA: 0x0001CECC File Offset: 0x0001B0CC
			// (set) Token: 0x0600072D RID: 1837 RVA: 0x000065DE File Offset: 0x000047DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x0600072E RID: 1838 RVA: 0x0001CEF4 File Offset: 0x0001B0F4
			// (set) Token: 0x0600072F RID: 1839 RVA: 0x000065F9 File Offset: 0x000047F9
			public AsyncTaskMethodBuilder<TokenResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TokenResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000730 RID: 1840 RVA: 0x0001CF24 File Offset: 0x0001B124
			// (set) Token: 0x06000731 RID: 1841 RVA: 0x00006627 File Offset: 0x00004827
			public unsafe TokenRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000732 RID: 1842 RVA: 0x0001CF54 File Offset: 0x0001B154
			// (set) Token: 0x06000733 RID: 1843 RVA: 0x00006646 File Offset: 0x00004846
			public unsafe AuthorizationCodeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000734 RID: 1844 RVA: 0x0001CF84 File Offset: 0x0001B184
			// (set) Token: 0x06000735 RID: 1845 RVA: 0x00006665 File Offset: 0x00004865
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000736 RID: 1846 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
			// (set) Token: 0x06000737 RID: 1847 RVA: 0x00006693 File Offset: 0x00004893
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000738 RID: 1848 RVA: 0x0001CFDC File Offset: 0x0001B1DC
			// (set) Token: 0x06000739 RID: 1849 RVA: 0x000066B2 File Offset: 0x000048B2
			public unsafe Object __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001D00C File Offset: 0x0001B20C
			// (set) Token: 0x0600073B RID: 1851 RVA: 0x000066D1 File Offset: 0x000048D1
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001D03C File Offset: 0x0001B23C
			// (set) Token: 0x0600073D RID: 1853 RVA: 0x000066FF File Offset: 0x000048FF
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeFlow._FetchTokenAsync_d__35.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400043A RID: 1082
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400043B RID: 1083
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400043C RID: 1084
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x0400043D RID: 1085
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400043E RID: 1086
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x0400043F RID: 1087
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04000440 RID: 1088
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000441 RID: 1089
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000442 RID: 1090
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000443 RID: 1091
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000444 RID: 1092
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
