using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000157 RID: 343
	[StructLayout(2)]
	public struct PanelClearSettings
	{
		// Token: 0x060018CB RID: 6347 RVA: 0x000749D8 File Offset: 0x00072BD8
		// Note: this type is marked as 'beforefieldinit'.
		static PanelClearSettings()
		{
			Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PanelClearSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr);
			PanelClearSettings.NativeFieldInfoPtr_clearDepthStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, "clearDepthStencil");
			PanelClearSettings.NativeFieldInfoPtr_clearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, "clearColor");
			PanelClearSettings.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, "color");
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0000B5E9 File Offset: 0x000097E9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_clearDepthStencil;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeFieldInfoPtr_clearColor;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04001136 RID: 4406
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool clearDepthStencil;

		// Token: 0x04001137 RID: 4407
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool clearColor;

		// Token: 0x04001138 RID: 4408
		[FieldOffset(4)]
		public Color color;
	}
}
