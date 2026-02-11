using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B0 RID: 432
	public class IAuthenticationModule : Il2CppObjectBase
	{
		// Token: 0x06001AE2 RID: 6882 RVA: 0x0008599C File Offset: 0x00083B9C
		// Note: this type is marked as 'beforefieldinit'.
		static IAuthenticationModule()
		{
			Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IAuthenticationModule");
			IAuthenticationModule.NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100667472);
			IAuthenticationModule.NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100667473);
			IAuthenticationModule.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100667474);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00085A00 File Offset: 0x00083C00
		[CallerCount(0)]
		public unsafe virtual Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00085A80 File Offset: 0x00083C80
		[CallerCount(0)]
		public unsafe virtual Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x00085AF0 File Offset: 0x00083CF0
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0000B830 File Offset: 0x00009A30
		public IAuthenticationModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0;
	}
}
