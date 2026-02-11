using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000010 RID: 16
	public static class ShaderInput : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderInput()
		{
			Il2CppClassPointerStore<ShaderInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipeline.Universal.ShaderLibrary.dll", "UnityEngine.Rendering.Universal", "ShaderInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInput>.NativeClassPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
		public ShaderInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000013 RID: 19
		[StructLayout(2)]
		public struct ShadowData
		{
			// Token: 0x0600001A RID: 26 RVA: 0x0000247C File Offset: 0x0000067C
			// Note: this type is marked as 'beforefieldinit'.
			static ShadowData()
			{
				Il2CppClassPointerStore<ShaderInput.ShadowData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderInput>.NativeClassPtr, "ShadowData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInput.ShadowData>.NativeClassPtr);
				ShaderInput.ShadowData.NativeFieldInfoPtr_worldToShadowMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.ShadowData>.NativeClassPtr, "worldToShadowMatrix");
				ShaderInput.ShadowData.NativeFieldInfoPtr_shadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.ShadowData>.NativeClassPtr, "shadowParams");
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00002156 File Offset: 0x00000356
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderInput.ShadowData>.NativeClassPtr, ref this));
			}

			// Token: 0x0400005C RID: 92
			private static readonly IntPtr NativeFieldInfoPtr_worldToShadowMatrix;

			// Token: 0x0400005D RID: 93
			private static readonly IntPtr NativeFieldInfoPtr_shadowParams;

			// Token: 0x0400005E RID: 94
			[FieldOffset(0)]
			public Matrix4x4 worldToShadowMatrix;

			// Token: 0x0400005F RID: 95
			[FieldOffset(64)]
			public Vector4 shadowParams;
		}

		// Token: 0x02000014 RID: 20
		[StructLayout(2)]
		public struct LightData
		{
			// Token: 0x0600001C RID: 28 RVA: 0x000024D0 File Offset: 0x000006D0
			// Note: this type is marked as 'beforefieldinit'.
			static LightData()
			{
				Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderInput>.NativeClassPtr, "LightData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr);
				ShaderInput.LightData.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr, "position");
				ShaderInput.LightData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr, "color");
				ShaderInput.LightData.NativeFieldInfoPtr_attenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr, "attenuation");
				ShaderInput.LightData.NativeFieldInfoPtr_spotDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr, "spotDirection");
				ShaderInput.LightData.NativeFieldInfoPtr_occlusionProbeChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr, "occlusionProbeChannels");
				ShaderInput.LightData.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr, "layerMask");
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00002168 File Offset: 0x00000368
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderInput.LightData>.NativeClassPtr, ref this));
			}

			// Token: 0x04000060 RID: 96
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04000061 RID: 97
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04000062 RID: 98
			private static readonly IntPtr NativeFieldInfoPtr_attenuation;

			// Token: 0x04000063 RID: 99
			private static readonly IntPtr NativeFieldInfoPtr_spotDirection;

			// Token: 0x04000064 RID: 100
			private static readonly IntPtr NativeFieldInfoPtr_occlusionProbeChannels;

			// Token: 0x04000065 RID: 101
			private static readonly IntPtr NativeFieldInfoPtr_layerMask;

			// Token: 0x04000066 RID: 102
			[FieldOffset(0)]
			public Vector4 position;

			// Token: 0x04000067 RID: 103
			[FieldOffset(16)]
			public Vector4 color;

			// Token: 0x04000068 RID: 104
			[FieldOffset(32)]
			public Vector4 attenuation;

			// Token: 0x04000069 RID: 105
			[FieldOffset(48)]
			public Vector4 spotDirection;

			// Token: 0x0400006A RID: 106
			[FieldOffset(64)]
			public Vector4 occlusionProbeChannels;

			// Token: 0x0400006B RID: 107
			[FieldOffset(80)]
			public uint layerMask;
		}
	}
}
