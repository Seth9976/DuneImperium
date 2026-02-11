using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200009A RID: 154
	[StructLayout(2)]
	public struct ShaderVariablesProbeVolumes
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x00036B3C File Offset: 0x00034D3C
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderVariablesProbeVolumes()
		{
			Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderVariablesProbeVolumes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr);
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__PoolDim_CellInMeters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_PoolDim_CellInMeters");
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__MinCellPos_Noise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_MinCellPos_Noise");
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__IndicesDim_IndexChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_IndicesDim_IndexChunkSize");
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__Biases_CellInMinBrick_MinBrickSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_Biases_CellInMinBrick_MinBrickSize");
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__LeakReductionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_LeakReductionParams");
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__Weight_MinLoadedCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_Weight_MinLoadedCell");
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__MaxLoadedCell_FrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_MaxLoadedCell_FrameIndex");
			ShaderVariablesProbeVolumes.NativeFieldInfoPtr__NormalizationClamp_Padding12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_NormalizationClamp_Padding12");
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00006F45 File Offset: 0x00005145
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, ref this));
		}

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr__PoolDim_CellInMeters;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr__MinCellPos_Noise;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr__IndicesDim_IndexChunkSize;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr__Biases_CellInMinBrick_MinBrickSize;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr__LeakReductionParams;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeFieldInfoPtr__Weight_MinLoadedCell;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeFieldInfoPtr__MaxLoadedCell_FrameIndex;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeFieldInfoPtr__NormalizationClamp_Padding12;

		// Token: 0x04000886 RID: 2182
		[FieldOffset(0)]
		public Vector4 _PoolDim_CellInMeters;

		// Token: 0x04000887 RID: 2183
		[FieldOffset(16)]
		public Vector4 _MinCellPos_Noise;

		// Token: 0x04000888 RID: 2184
		[FieldOffset(32)]
		public Vector4 _IndicesDim_IndexChunkSize;

		// Token: 0x04000889 RID: 2185
		[FieldOffset(48)]
		public Vector4 _Biases_CellInMinBrick_MinBrickSize;

		// Token: 0x0400088A RID: 2186
		[FieldOffset(64)]
		public Vector4 _LeakReductionParams;

		// Token: 0x0400088B RID: 2187
		[FieldOffset(80)]
		public Vector4 _Weight_MinLoadedCell;

		// Token: 0x0400088C RID: 2188
		[FieldOffset(96)]
		public Vector4 _MaxLoadedCell_FrameIndex;

		// Token: 0x0400088D RID: 2189
		[FieldOffset(112)]
		public Vector4 _NormalizationClamp_Padding12;
	}
}
