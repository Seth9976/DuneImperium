using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000162 RID: 354
	public class IRuntimePanelComponent : Il2CppObjectBase
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x0000BF11 File Offset: 0x0000A111
		// Note: this type is marked as 'beforefieldinit'.
		static IRuntimePanelComponent()
		{
			Il2CppClassPointerStore<IRuntimePanelComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IRuntimePanelComponent");
			IRuntimePanelComponent.NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRuntimePanelComponent>.NativeClassPtr, 100667132);
		}

		// Token: 0x170007F6 RID: 2038
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x00079DF4 File Offset: 0x00077FF4
		public unsafe virtual IPanel panel
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRuntimePanelComponent.NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0000BF40 File Offset: 0x0000A140
		public IRuntimePanelComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_IPanel_0;
	}
}
