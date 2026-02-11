using System;
using Google.Apis.Auth.OAuth2.Flows;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000012 RID: 18
	public class IAuthorizationCodeInstalledApp : Il2CppObjectBase
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00009ED0 File Offset: 0x000080D0
		// Note: this type is marked as 'beforefieldinit'.
		static IAuthorizationCodeInstalledApp()
		{
			Il2CppClassPointerStore<IAuthorizationCodeInstalledApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "IAuthorizationCodeInstalledApp");
			IAuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_Flow_Public_Abstract_Virtual_New_get_IAuthorizationCodeFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeInstalledApp>.NativeClassPtr, 100663511);
			IAuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_CodeReceiver_Public_Abstract_Virtual_New_get_ICodeReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeInstalledApp>.NativeClassPtr, 100663512);
			IAuthorizationCodeInstalledApp.NativeMethodInfoPtr_AuthorizeAsync_Public_Abstract_Virtual_New_Task_1_UserCredential_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthorizationCodeInstalledApp>.NativeClassPtr, 100663513);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00009F34 File Offset: 0x00008134
		public unsafe virtual IAuthorizationCodeFlow Flow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_Flow_Public_Abstract_Virtual_New_get_IAuthorizationCodeFlow_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAuthorizationCodeFlow>(intPtr3) : null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00009F80 File Offset: 0x00008180
		public unsafe virtual ICodeReceiver CodeReceiver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_CodeReceiver_Public_Abstract_Virtual_New_get_ICodeReceiver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICodeReceiver>(intPtr3) : null;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00009FCC File Offset: 0x000081CC
		[CallerCount(0)]
		public unsafe virtual Task<UserCredential> AuthorizeAsync(string userId, CancellationToken taskCancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthorizationCodeInstalledApp.NativeMethodInfoPtr_AuthorizeAsync_Public_Abstract_Virtual_New_Task_1_UserCredential_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<UserCredential>>(intPtr3) : null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000259C File Offset: 0x0000079C
		public IAuthorizationCodeInstalledApp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_Flow_Public_Abstract_Virtual_New_get_IAuthorizationCodeFlow_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_CodeReceiver_Public_Abstract_Virtual_New_get_ICodeReceiver_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_AuthorizeAsync_Public_Abstract_Virtual_New_Task_1_UserCredential_String_CancellationToken_0;
	}
}
