using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000011 RID: 17
	public class IAccessMethod : Il2CppObjectBase
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00009DCC File Offset: 0x00007FCC
		// Note: this type is marked as 'beforefieldinit'.
		static IAccessMethod()
		{
			Il2CppClassPointerStore<IAccessMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "IAccessMethod");
			IAccessMethod.NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_Void_HttpRequestMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccessMethod>.NativeClassPtr, 100663509);
			IAccessMethod.NativeMethodInfoPtr_GetAccessToken_Public_Abstract_Virtual_New_String_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccessMethod>.NativeClassPtr, 100663510);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00009E1C File Offset: 0x0000801C
		[CallerCount(0)]
		public unsafe virtual void Intercept(HttpRequestMessage request, string accessToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAccessMethod.NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_Void_HttpRequestMessage_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00009E7C File Offset: 0x0000807C
		[CallerCount(0)]
		public unsafe virtual string GetAccessToken(HttpRequestMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAccessMethod.NativeMethodInfoPtr_GetAccessToken_Public_Abstract_Virtual_New_String_HttpRequestMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002593 File Offset: 0x00000793
		public IAccessMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_Void_HttpRequestMessage_String_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessToken_Public_Abstract_Virtual_New_String_HttpRequestMessage_0;
	}
}
