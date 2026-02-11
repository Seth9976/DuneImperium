using System;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000013 RID: 19
	public class ICodeReceiver : Il2CppObjectBase
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000A040 File Offset: 0x00008240
		// Note: this type is marked as 'beforefieldinit'.
		static ICodeReceiver()
		{
			Il2CppClassPointerStore<ICodeReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "ICodeReceiver");
			ICodeReceiver.NativeMethodInfoPtr_get_RedirectUri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICodeReceiver>.NativeClassPtr, 100663514);
			ICodeReceiver.NativeMethodInfoPtr_ReceiveCodeAsync_Public_Abstract_Virtual_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICodeReceiver>.NativeClassPtr, 100663515);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000A090 File Offset: 0x00008290
		public unsafe virtual string RedirectUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICodeReceiver.NativeMethodInfoPtr_get_RedirectUri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000A0D4 File Offset: 0x000082D4
		[CallerCount(0)]
		public unsafe virtual Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICodeReceiver.NativeMethodInfoPtr_ReceiveCodeAsync_Public_Abstract_Virtual_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AuthorizationCodeResponseUrl>>(intPtr3) : null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000025A5 File Offset: 0x000007A5
		public ICodeReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectUri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCodeAsync_Public_Abstract_Virtual_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0;
	}
}
