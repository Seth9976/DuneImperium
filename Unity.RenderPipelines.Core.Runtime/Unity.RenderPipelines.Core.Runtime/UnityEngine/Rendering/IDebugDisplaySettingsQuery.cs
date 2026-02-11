using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering
{
	// Token: 0x02000073 RID: 115
	public class IDebugDisplaySettingsQuery : Il2CppObjectBase
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x0002A730 File Offset: 0x00028930
		// Note: this type is marked as 'beforefieldinit'.
		static IDebugDisplaySettingsQuery()
		{
			Il2CppClassPointerStore<IDebugDisplaySettingsQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDebugDisplaySettingsQuery");
			IDebugDisplaySettingsQuery.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsQuery>.NativeClassPtr, 100664526);
			IDebugDisplaySettingsQuery.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsQuery>.NativeClassPtr, 100664527);
			IDebugDisplaySettingsQuery.NativeMethodInfoPtr_get_IsLightingActive_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsQuery>.NativeClassPtr, 100664528);
			IDebugDisplaySettingsQuery.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Abstract_Virtual_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsQuery>.NativeClassPtr, 100664529);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0002A7A8 File Offset: 0x000289A8
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsQuery.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0002A7F0 File Offset: 0x000289F0
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsQuery.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0002A838 File Offset: 0x00028A38
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsQuery.NativeMethodInfoPtr_get_IsLightingActive_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0002A880 File Offset: 0x00028A80
		[CallerCount(0)]
		public unsafe virtual bool TryGetScreenClearColor(ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsQuery.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Abstract_Virtual_New_Boolean_byref_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00005182 File Offset: 0x00003382
		public IDebugDisplaySettingsQuery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Abstract_Virtual_New_Boolean_byref_Color_0;
	}
}
