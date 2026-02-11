using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D1 RID: 209
	public static class ColorSpaceUtils : Object
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x000464BC File Offset: 0x000446BC
		// Note: this type is marked as 'beforefieldinit'.
		static ColorSpaceUtils()
		{
			Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ColorSpaceUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr);
			ColorSpaceUtils.NativeFieldInfoPtr_Rec709ToRec2020Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec709ToRec2020Mat");
			ColorSpaceUtils.NativeFieldInfoPtr_Rec709ToP3D65Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec709ToP3D65Mat");
			ColorSpaceUtils.NativeFieldInfoPtr_Rec2020ToRec709Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec2020ToRec709Mat");
			ColorSpaceUtils.NativeFieldInfoPtr_Rec2020ToP3D65Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec2020ToP3D65Mat");
			ColorSpaceUtils.NativeFieldInfoPtr_P3D65ToRec2020Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "P3D65ToRec2020Mat");
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0000852E File Offset: 0x0000672E
		public ColorSpaceUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00046550 File Offset: 0x00044750
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00008537 File Offset: 0x00006737
		public unsafe static Matrix4x4 Rec709ToRec2020Mat
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec709ToRec2020Mat, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec709ToRec2020Mat, (void*)(&value));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0004656C File Offset: 0x0004476C
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00008545 File Offset: 0x00006745
		public unsafe static Matrix4x4 Rec709ToP3D65Mat
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec709ToP3D65Mat, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec709ToP3D65Mat, (void*)(&value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00046588 File Offset: 0x00044788
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00008553 File Offset: 0x00006753
		public unsafe static Matrix4x4 Rec2020ToRec709Mat
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec2020ToRec709Mat, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec2020ToRec709Mat, (void*)(&value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000465A4 File Offset: 0x000447A4
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00008561 File Offset: 0x00006761
		public unsafe static Matrix4x4 Rec2020ToP3D65Mat
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec2020ToP3D65Mat, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorSpaceUtils.NativeFieldInfoPtr_Rec2020ToP3D65Mat, (void*)(&value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000465C0 File Offset: 0x000447C0
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x0000856F File Offset: 0x0000676F
		public unsafe static Matrix4x4 P3D65ToRec2020Mat
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(ColorSpaceUtils.NativeFieldInfoPtr_P3D65ToRec2020Mat, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorSpaceUtils.NativeFieldInfoPtr_P3D65ToRec2020Mat, (void*)(&value));
			}
		}

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr_Rec709ToRec2020Mat;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_Rec709ToP3D65Mat;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr_Rec2020ToRec709Mat;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_Rec2020ToP3D65Mat;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr_P3D65ToRec2020Mat;
	}
}
