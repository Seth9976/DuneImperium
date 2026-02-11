using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000AB RID: 171
	[StructLayout(2)]
	public struct LightBakingOutput
	{
		// Token: 0x06000E29 RID: 3625 RVA: 0x000464D8 File Offset: 0x000446D8
		// Note: this type is marked as 'beforefieldinit'.
		static LightBakingOutput()
		{
			Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightBakingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr);
			LightBakingOutput.NativeFieldInfoPtr_probeOcclusionLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "probeOcclusionLightIndex");
			LightBakingOutput.NativeFieldInfoPtr_occlusionMaskChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "occlusionMaskChannel");
			LightBakingOutput.NativeFieldInfoPtr_lightmapBakeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "lightmapBakeType");
			LightBakingOutput.NativeFieldInfoPtr_mixedLightingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "mixedLightingMode");
			LightBakingOutput.NativeFieldInfoPtr_isBaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "isBaked");
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0000711D File Offset: 0x0000531D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeFieldInfoPtr_probeOcclusionLightIndex;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMaskChannel;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_lightmapBakeType;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeFieldInfoPtr_mixedLightingMode;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_isBaked;

		// Token: 0x04000B2B RID: 2859
		[FieldOffset(0)]
		public int probeOcclusionLightIndex;

		// Token: 0x04000B2C RID: 2860
		[FieldOffset(4)]
		public int occlusionMaskChannel;

		// Token: 0x04000B2D RID: 2861
		[FieldOffset(8)]
		public LightmapBakeType lightmapBakeType;

		// Token: 0x04000B2E RID: 2862
		[FieldOffset(12)]
		public MixedLightingMode mixedLightingMode;

		// Token: 0x04000B2F RID: 2863
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool isBaked;
	}
}
