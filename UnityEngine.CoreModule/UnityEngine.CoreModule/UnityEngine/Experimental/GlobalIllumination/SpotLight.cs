using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000273 RID: 627
	[StructLayout(2)]
	public struct SpotLight
	{
		// Token: 0x06002B11 RID: 11025 RVA: 0x000AE7EC File Offset: 0x000AC9EC
		// Note: this type is marked as 'beforefieldinit'.
		static SpotLight()
		{
			Il2CppClassPointerStore<SpotLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "SpotLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLight>.NativeClassPtr);
			SpotLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "instanceID");
			SpotLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "shadow");
			SpotLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "mode");
			SpotLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "position");
			SpotLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "orientation");
			SpotLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "color");
			SpotLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "indirectColor");
			SpotLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "range");
			SpotLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "sphereRadius");
			SpotLight.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "coneAngle");
			SpotLight.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "innerConeAngle");
			SpotLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "falloff");
			SpotLight.NativeFieldInfoPtr_angularFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "angularFalloff");
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00010D9D File Offset: 0x0000EF9D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeFieldInfoPtr_angularFalloff;

		// Token: 0x040025E2 RID: 9698
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040025E3 RID: 9699
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040025E4 RID: 9700
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040025E5 RID: 9701
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040025E6 RID: 9702
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040025E7 RID: 9703
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040025E8 RID: 9704
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040025E9 RID: 9705
		[FieldOffset(68)]
		public float range;

		// Token: 0x040025EA RID: 9706
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x040025EB RID: 9707
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x040025EC RID: 9708
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x040025ED RID: 9709
		[FieldOffset(84)]
		public FalloffType falloff;

		// Token: 0x040025EE RID: 9710
		[FieldOffset(85)]
		public AngularFalloffType angularFalloff;
	}
}
