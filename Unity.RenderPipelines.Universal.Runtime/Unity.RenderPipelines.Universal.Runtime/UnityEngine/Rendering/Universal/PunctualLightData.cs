using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000FF RID: 255
	[StructLayout(2)]
	public struct PunctualLightData
	{
		// Token: 0x0600147D RID: 5245 RVA: 0x0005B840 File Offset: 0x00059A40
		// Note: this type is marked as 'beforefieldinit'.
		static PunctualLightData()
		{
			Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PunctualLightData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr);
			PunctualLightData.NativeFieldInfoPtr_wsPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "wsPos");
			PunctualLightData.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "radius");
			PunctualLightData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "color");
			PunctualLightData.NativeFieldInfoPtr_attenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "attenuation");
			PunctualLightData.NativeFieldInfoPtr_spotDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "spotDirection");
			PunctualLightData.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "flags");
			PunctualLightData.NativeFieldInfoPtr_occlusionProbeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "occlusionProbeInfo");
			PunctualLightData.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "layerMask");
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0000C13B File Offset: 0x0000A33B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeFieldInfoPtr_wsPos;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr_attenuation;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeFieldInfoPtr_spotDirection;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_occlusionProbeInfo;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x04000F00 RID: 3840
		[FieldOffset(0)]
		public Vector3 wsPos;

		// Token: 0x04000F01 RID: 3841
		[FieldOffset(12)]
		public float radius;

		// Token: 0x04000F02 RID: 3842
		[FieldOffset(16)]
		public Vector4 color;

		// Token: 0x04000F03 RID: 3843
		[FieldOffset(32)]
		public Vector4 attenuation;

		// Token: 0x04000F04 RID: 3844
		[FieldOffset(48)]
		public Vector3 spotDirection;

		// Token: 0x04000F05 RID: 3845
		[FieldOffset(60)]
		public int flags;

		// Token: 0x04000F06 RID: 3846
		[FieldOffset(64)]
		public Vector4 occlusionProbeInfo;

		// Token: 0x04000F07 RID: 3847
		[FieldOffset(80)]
		public uint layerMask;
	}
}
