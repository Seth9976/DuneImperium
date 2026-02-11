using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000087 RID: 135
	[StructLayout(2)]
	public struct ProbeVolumeShadingParameters
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00030A18 File Offset: 0x0002EC18
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolumeShadingParameters()
		{
			Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeShadingParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr);
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_normalBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "normalBias");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_viewBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "viewBias");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_scaleBiasByMinDistanceBetweenProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "scaleBiasByMinDistanceBetweenProbes");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_samplingNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "samplingNoise");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "weight");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_leakReductionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "leakReductionMode");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_occlusionWeightContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "occlusionWeightContribution");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_minValidNormalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "minValidNormalWeight");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_frameIndexForNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "frameIndexForNoise");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_reflNormalizationLowerClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "reflNormalizationLowerClamp");
			ProbeVolumeShadingParameters.NativeFieldInfoPtr_reflNormalizationUpperClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "reflNormalizationUpperClamp");
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr_normalBias;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr_viewBias;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr_scaleBiasByMinDistanceBetweenProbes;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_samplingNoise;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr_weight;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr_leakReductionMode;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr_occlusionWeightContribution;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr_minValidNormalWeight;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeFieldInfoPtr_frameIndexForNoise;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr_reflNormalizationLowerClamp;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr_reflNormalizationUpperClamp;

		// Token: 0x04000703 RID: 1795
		[FieldOffset(0)]
		public float normalBias;

		// Token: 0x04000704 RID: 1796
		[FieldOffset(4)]
		public float viewBias;

		// Token: 0x04000705 RID: 1797
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool scaleBiasByMinDistanceBetweenProbes;

		// Token: 0x04000706 RID: 1798
		[FieldOffset(12)]
		public float samplingNoise;

		// Token: 0x04000707 RID: 1799
		[FieldOffset(16)]
		public float weight;

		// Token: 0x04000708 RID: 1800
		[FieldOffset(20)]
		public APVLeakReductionMode leakReductionMode;

		// Token: 0x04000709 RID: 1801
		[FieldOffset(24)]
		public float occlusionWeightContribution;

		// Token: 0x0400070A RID: 1802
		[FieldOffset(28)]
		public float minValidNormalWeight;

		// Token: 0x0400070B RID: 1803
		[FieldOffset(32)]
		public int frameIndexForNoise;

		// Token: 0x0400070C RID: 1804
		[FieldOffset(36)]
		public float reflNormalizationLowerClamp;

		// Token: 0x0400070D RID: 1805
		[FieldOffset(40)]
		public float reflNormalizationUpperClamp;
	}
}
