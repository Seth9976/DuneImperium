using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000028 RID: 40
	public class ILight2DCullResult : Il2CppObjectBase
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00020A60 File Offset: 0x0001EC60
		// Note: this type is marked as 'beforefieldinit'.
		static ILight2DCullResult()
		{
			Il2CppClassPointerStore<ILight2DCullResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ILight2DCullResult");
			ILight2DCullResult.NativeMethodInfoPtr_get_visibleLights_Public_Abstract_Virtual_New_get_List_1_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILight2DCullResult>.NativeClassPtr, 100663689);
			ILight2DCullResult.NativeMethodInfoPtr_get_visibleShadows_Public_Abstract_Virtual_New_get_List_1_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILight2DCullResult>.NativeClassPtr, 100663690);
			ILight2DCullResult.NativeMethodInfoPtr_GetLightStatsByLayer_Public_Abstract_Virtual_New_LightStats_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILight2DCullResult>.NativeClassPtr, 100663691);
			ILight2DCullResult.NativeMethodInfoPtr_IsSceneLit_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILight2DCullResult>.NativeClassPtr, 100663692);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		public unsafe virtual List<Light2D> visibleLights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILight2DCullResult.NativeMethodInfoPtr_get_visibleLights_Public_Abstract_Virtual_New_get_List_1_Light2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Light2D>>(intPtr3) : null;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00020B24 File Offset: 0x0001ED24
		public unsafe virtual List<ShadowCasterGroup2D> visibleShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILight2DCullResult.NativeMethodInfoPtr_get_visibleShadows_Public_Abstract_Virtual_New_get_List_1_ShadowCasterGroup2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShadowCasterGroup2D>>(intPtr3) : null;
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00020B70 File Offset: 0x0001ED70
		[CallerCount(0)]
		public unsafe virtual LightStats GetLightStatsByLayer(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILight2DCullResult.NativeMethodInfoPtr_GetLightStatsByLayer_Public_Abstract_Virtual_New_LightStats_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		[CallerCount(0)]
		public unsafe virtual bool IsSceneLit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILight2DCullResult.NativeMethodInfoPtr_IsSceneLit_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000035E2 File Offset: 0x000017E2
		public ILight2DCullResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleLights_Public_Abstract_Virtual_New_get_List_1_Light2D_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleShadows_Public_Abstract_Virtual_New_get_List_1_ShadowCasterGroup2D_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_GetLightStatsByLayer_Public_Abstract_Virtual_New_LightStats_Int32_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_IsSceneLit_Public_Abstract_Virtual_New_Boolean_0;
	}
}
