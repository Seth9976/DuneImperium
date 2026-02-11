using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000070 RID: 112
	public class IDebugDisplaySettingsData : Il2CppObjectBase
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x0000511D File Offset: 0x0000331D
		// Note: this type is marked as 'beforefieldinit'.
		static IDebugDisplaySettingsData()
		{
			Il2CppClassPointerStore<IDebugDisplaySettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDebugDisplaySettingsData");
			IDebugDisplaySettingsData.NativeMethodInfoPtr_CreatePanel_Public_Abstract_Virtual_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsData>.NativeClassPtr, 100664522);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0002A5A8 File Offset: 0x000287A8
		[CallerCount(0)]
		public unsafe virtual IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsData.NativeMethodInfoPtr_CreatePanel_Public_Abstract_Virtual_New_IDebugDisplaySettingsPanelDisposable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr3) : null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000514C File Offset: 0x0000334C
		public IDebugDisplaySettingsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Abstract_Virtual_New_IDebugDisplaySettingsPanelDisposable_0;
	}
}
