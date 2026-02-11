using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E4 RID: 484
	public class IWebProxy : Il2CppObjectBase
	{
		// Token: 0x06001E42 RID: 7746 RVA: 0x00091978 File Offset: 0x0008FB78
		// Note: this type is marked as 'beforefieldinit'.
		static IWebProxy()
		{
			Il2CppClassPointerStore<IWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebProxy");
			IWebProxy.NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100667906);
			IWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100667907);
			IWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100667908);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x000919DC File Offset: 0x0008FBDC
		[CallerCount(0)]
		public unsafe virtual Uri GetProxy(Uri destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00091A38 File Offset: 0x0008FC38
		[CallerCount(0)]
		public unsafe virtual bool IsBypassed(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x00091A90 File Offset: 0x0008FC90
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0000CDFE File Offset: 0x0000AFFE
		public IWebProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0;
	}
}
