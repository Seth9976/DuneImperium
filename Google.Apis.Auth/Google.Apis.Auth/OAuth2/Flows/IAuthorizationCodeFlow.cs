using System;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Flows
{
	// Token: 0x02000031 RID: 49
	public class IAuthorizationCodeFlow : Il2CppObjectBase
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00011670 File Offset: 0x0000F870
		// Note: this type is marked as 'beforefieldinit'.
		static IAuthorizationCodeFlow()
		{
			Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Flows", "IAuthorizationCodeFlow");
			IAuthorizationCodeFlow.NativeMethodInfoPtr_get_AccessMethod_Public_Abstract_Virtual_New_get_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663945);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_get_Clock_Public_Abstract_Virtual_New_get_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663946);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_get_DataStore_Public_Abstract_Virtual_New_get_IDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663947);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_LoadTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663948);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_DeleteTokenAsync_Public_Abstract_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663949);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Abstract_Virtual_New_AuthorizationCodeRequestUrl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663950);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_ExchangeCodeForTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663951);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_RefreshTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663952);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_RevokeTokenAsync_Public_Abstract_Virtual_New_Task_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663953);
			IAuthorizationCodeFlow.NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeFlow>.NativeClassPtr, 100663954);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00011760 File Offset: 0x0000F960
		public unsafe virtual IAccessMethod AccessMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_get_AccessMethod_Public_Abstract_Virtual_New_get_IAccessMethod_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr3) : null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000117AC File Offset: 0x0000F9AC
		public unsafe virtual IClock Clock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_get_Clock_Public_Abstract_Virtual_New_get_IClock_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr3) : null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000117F8 File Offset: 0x0000F9F8
		public unsafe virtual IDataStore DataStore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_get_DataStore_Public_Abstract_Virtual_New_get_IDataStore_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr3) : null;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00011844 File Offset: 0x0000FA44
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_LoadTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000118B8 File Offset: 0x0000FAB8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_DeleteTokenAsync_Public_Abstract_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001192C File Offset: 0x0000FB2C
		[CallerCount(0)]
		public unsafe virtual AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(redirectUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Abstract_Virtual_New_AuthorizationCodeRequestUrl_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeRequestUrl>(intPtr3) : null;
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00011988 File Offset: 0x0000FB88
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_ExchangeCodeForTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00011A20 File Offset: 0x0000FC20
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_RefreshTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_RevokeTokenAsync_Public_Abstract_Virtual_New_Task_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00011B28 File Offset: 0x0000FD28
		[CallerCount(0)]
		public unsafe virtual bool ShouldForceTokenRetrieval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeFlow.NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000034B5 File Offset: 0x000016B5
		public IAuthorizationCodeFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMethod_Public_Abstract_Virtual_New_get_IAccessMethod_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_Clock_Public_Abstract_Virtual_New_get_IClock_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_get_DataStore_Public_Abstract_Virtual_New_get_IDataStore_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_LoadTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_CancellationToken_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_DeleteTokenAsync_Public_Abstract_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_CreateAuthorizationCodeRequest_Public_Abstract_Virtual_New_AuthorizationCodeRequestUrl_String_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_ExchangeCodeForTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_String_String_CancellationToken_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTokenAsync_Public_Abstract_Virtual_New_Task_1_TokenResponse_String_String_CancellationToken_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_RevokeTokenAsync_Public_Abstract_Virtual_New_Task_String_String_CancellationToken_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_ShouldForceTokenRetrieval_Public_Abstract_Virtual_New_Boolean_0;
	}
}
