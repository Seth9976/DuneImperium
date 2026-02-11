using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono
{
	// Token: 0x02000008 RID: 8
	public class ISystemDependencyProvider : Il2CppObjectBase
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002113 File Offset: 0x00000313
		// Note: this type is marked as 'beforefieldinit'.
		static ISystemDependencyProvider()
		{
			Il2CppClassPointerStore<ISystemDependencyProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "ISystemDependencyProvider");
			ISystemDependencyProvider.NativeMethodInfoPtr_get_CertificateProvider_Public_Abstract_Virtual_New_get_ISystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemDependencyProvider>.NativeClassPtr, 100663383);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00025DE0 File Offset: 0x00023FE0
		public unsafe virtual ISystemCertificateProvider CertificateProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISystemDependencyProvider.NativeMethodInfoPtr_get_CertificateProvider_Public_Abstract_Virtual_New_get_ISystemCertificateProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISystemCertificateProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002142 File Offset: 0x00000342
		public ISystemDependencyProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateProvider_Public_Abstract_Virtual_New_get_ISystemCertificateProvider_0;
	}
}
