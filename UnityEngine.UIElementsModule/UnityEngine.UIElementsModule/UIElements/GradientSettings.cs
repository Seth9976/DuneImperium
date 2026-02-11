using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021B RID: 539
	[Serializable]
	[StructLayout(2)]
	public struct GradientSettings
	{
		// Token: 0x060028F8 RID: 10488 RVA: 0x000B39FC File Offset: 0x000B1BFC
		// Note: this type is marked as 'beforefieldinit'.
		static GradientSettings()
		{
			Il2CppClassPointerStore<GradientSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GradientSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr);
			GradientSettings.NativeFieldInfoPtr_gradientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "gradientType");
			GradientSettings.NativeFieldInfoPtr_addressMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "addressMode");
			GradientSettings.NativeFieldInfoPtr_radialFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "radialFocus");
			GradientSettings.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "location");
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00010860 File Offset: 0x0000EA60
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeFieldInfoPtr_gradientType;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeFieldInfoPtr_addressMode;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeFieldInfoPtr_radialFocus;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x04001D05 RID: 7429
		[FieldOffset(0)]
		public GradientType gradientType;

		// Token: 0x04001D06 RID: 7430
		[FieldOffset(4)]
		public AddressMode addressMode;

		// Token: 0x04001D07 RID: 7431
		[FieldOffset(8)]
		public Vector2 radialFocus;

		// Token: 0x04001D08 RID: 7432
		[FieldOffset(16)]
		public RectInt location;
	}
}
