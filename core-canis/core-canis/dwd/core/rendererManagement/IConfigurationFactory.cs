using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.rendererManagement
{
	// Token: 0x020000FB RID: 251
	public class IConfigurationFactory : Il2CppObjectBase
	{
		// Token: 0x06000EC4 RID: 3780 RVA: 0x0004E648 File Offset: 0x0004C848
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigurationFactory()
		{
			Il2CppClassPointerStore<IConfigurationFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.rendererManagement", "IConfigurationFactory");
			IConfigurationFactory.NativeMethodInfoPtr_PrimeConfigurations_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurationFactory>.NativeClassPtr, 100665442);
			IConfigurationFactory.NativeMethodInfoPtr_GetConfiguration_Public_Abstract_Virtual_New_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurationFactory>.NativeClassPtr, 100665443);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0004E698 File Offset: 0x0004C898
		[CallerCount(0)]
		public unsafe virtual void PrimeConfigurations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurationFactory.NativeMethodInfoPtr_PrimeConfigurations_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0004E6D4 File Offset: 0x0004C8D4
		[CallerCount(0)]
		public unsafe virtual VisibilityConfiguration GetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurationFactory.NativeMethodInfoPtr_GetConfiguration_Public_Abstract_Virtual_New_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisibilityConfiguration>(intPtr3) : null;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0000700F File Offset: 0x0000520F
		public IConfigurationFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_PrimeConfigurations_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_GetConfiguration_Public_Abstract_Virtual_New_VisibilityConfiguration_0;
	}
}
