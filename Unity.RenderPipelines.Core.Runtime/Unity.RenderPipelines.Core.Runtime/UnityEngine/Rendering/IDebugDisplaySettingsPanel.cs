using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000071 RID: 113
	public class IDebugDisplaySettingsPanel : Il2CppObjectBase
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x0002A5F4 File Offset: 0x000287F4
		// Note: this type is marked as 'beforefieldinit'.
		static IDebugDisplaySettingsPanel()
		{
			Il2CppClassPointerStore<IDebugDisplaySettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDebugDisplaySettingsPanel");
			IDebugDisplaySettingsPanel.NativeMethodInfoPtr_get_PanelName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsPanel>.NativeClassPtr, 100664523);
			IDebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Widgets_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsPanel>.NativeClassPtr, 100664524);
			IDebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Flags_Public_Abstract_Virtual_New_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsPanel>.NativeClassPtr, 100664525);
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0002A658 File Offset: 0x00028858
		public unsafe virtual string PanelName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsPanel.NativeMethodInfoPtr_get_PanelName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0002A69C File Offset: 0x0002889C
		public unsafe virtual Il2CppReferenceArray<DebugUI.Widget> Widgets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Widgets_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr3) : null;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0002A6E8 File Offset: 0x000288E8
		public unsafe virtual DebugUI.Flags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Flags_Public_Abstract_Virtual_New_get_Flags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00005155 File Offset: 0x00003355
		public IDebugDisplaySettingsPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_get_Widgets_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Widget_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_Abstract_Virtual_New_get_Flags_0;
	}
}
