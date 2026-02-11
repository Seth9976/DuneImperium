using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000272 RID: 626
	[StructLayout(2)]
	public struct PointLight
	{
		// Token: 0x06002B0F RID: 11023 RVA: 0x000AE6F4 File Offset: 0x000AC8F4
		// Note: this type is marked as 'beforefieldinit'.
		static PointLight()
		{
			Il2CppClassPointerStore<PointLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "PointLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointLight>.NativeClassPtr);
			PointLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "instanceID");
			PointLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "shadow");
			PointLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "mode");
			PointLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "position");
			PointLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "orientation");
			PointLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "color");
			PointLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "indirectColor");
			PointLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "range");
			PointLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "sphereRadius");
			PointLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x00010D8B File Offset: 0x0000EF8B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040025CB RID: 9675
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040025CC RID: 9676
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040025CD RID: 9677
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040025CE RID: 9678
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040025CF RID: 9679
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040025D0 RID: 9680
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040025D1 RID: 9681
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040025D2 RID: 9682
		[FieldOffset(68)]
		public float range;

		// Token: 0x040025D3 RID: 9683
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x040025D4 RID: 9684
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}
