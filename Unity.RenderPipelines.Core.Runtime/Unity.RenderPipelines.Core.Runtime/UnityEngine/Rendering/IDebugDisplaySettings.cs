using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200006F RID: 111
	public class IDebugDisplaySettings : Il2CppObjectBase
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x0002A4CC File Offset: 0x000286CC
		// Note: this type is marked as 'beforefieldinit'.
		static IDebugDisplaySettings()
		{
			Il2CppClassPointerStore<IDebugDisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDebugDisplaySettings");
			IDebugDisplaySettings.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettings>.NativeClassPtr, 100664520);
			IDebugDisplaySettings.NativeMethodInfoPtr_ForEach_Public_Abstract_Virtual_New_Void_Action_1_IDebugDisplaySettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettings>.NativeClassPtr, 100664521);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002A51C File Offset: 0x0002871C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettings.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0002A558 File Offset: 0x00028758
		[CallerCount(0)]
		public unsafe virtual void ForEach(Action<IDebugDisplaySettingsData> onExecute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onExecute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettings.NativeMethodInfoPtr_ForEach_Public_Abstract_Virtual_New_Void_Action_1_IDebugDisplaySettingsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00005114 File Offset: 0x00003314
		public IDebugDisplaySettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_ForEach_Public_Abstract_Virtual_New_Void_Action_1_IDebugDisplaySettingsData_0;
	}
}
