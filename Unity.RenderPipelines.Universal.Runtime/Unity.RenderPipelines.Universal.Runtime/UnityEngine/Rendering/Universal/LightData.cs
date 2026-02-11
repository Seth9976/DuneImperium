using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000FA RID: 250
	public sealed class LightData : ValueType
	{
		// Token: 0x060013B8 RID: 5048 RVA: 0x000599A8 File Offset: 0x00057BA8
		// Note: this type is marked as 'beforefieldinit'.
		static LightData()
		{
			Il2CppClassPointerStore<LightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightData>.NativeClassPtr);
			LightData.NativeFieldInfoPtr_mainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "mainLightIndex");
			LightData.NativeFieldInfoPtr_additionalLightsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "additionalLightsCount");
			LightData.NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "maxPerObjectAdditionalLightsCount");
			LightData.NativeFieldInfoPtr_visibleLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "visibleLights");
			LightData.NativeFieldInfoPtr_shadeAdditionalLightsPerVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "shadeAdditionalLightsPerVertex");
			LightData.NativeFieldInfoPtr_supportsMixedLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "supportsMixedLighting");
			LightData.NativeFieldInfoPtr_reflectionProbeBoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "reflectionProbeBoxProjection");
			LightData.NativeFieldInfoPtr_reflectionProbeBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "reflectionProbeBlending");
			LightData.NativeFieldInfoPtr_supportsLightLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "supportsLightLayers");
			LightData.NativeFieldInfoPtr_supportsAdditionalLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "supportsAdditionalLights");
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0000B851 File Offset: 0x00009A51
		public LightData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0000B85A File Offset: 0x00009A5A
		public LightData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightData>.NativeClassPtr))
		{
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x00059AA0 File Offset: 0x00057CA0
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x0000B86C File Offset: 0x00009A6C
		public unsafe int mainLightIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_mainLightIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_mainLightIndex)) = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00059AC8 File Offset: 0x00057CC8
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0000B887 File Offset: 0x00009A87
		public unsafe int additionalLightsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_additionalLightsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_additionalLightsCount)) = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00059AF0 File Offset: 0x00057CF0
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0000B8A2 File Offset: 0x00009AA2
		public unsafe int maxPerObjectAdditionalLightsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount)) = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00059B18 File Offset: 0x00057D18
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000B8BD File Offset: 0x00009ABD
		public NativeArray<VisibleLight> visibleLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_visibleLights);
				return new NativeArray<VisibleLight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_visibleLights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00059B48 File Offset: 0x00057D48
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000B8EB File Offset: 0x00009AEB
		public unsafe bool shadeAdditionalLightsPerVertex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_shadeAdditionalLightsPerVertex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_shadeAdditionalLightsPerVertex)) = value;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00059B70 File Offset: 0x00057D70
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000B906 File Offset: 0x00009B06
		public unsafe bool supportsMixedLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_supportsMixedLighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_supportsMixedLighting)) = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00059B98 File Offset: 0x00057D98
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0000B921 File Offset: 0x00009B21
		public unsafe bool reflectionProbeBoxProjection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_reflectionProbeBoxProjection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_reflectionProbeBoxProjection)) = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00059BC0 File Offset: 0x00057DC0
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0000B93C File Offset: 0x00009B3C
		public unsafe bool reflectionProbeBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_reflectionProbeBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_reflectionProbeBlending)) = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00059BE8 File Offset: 0x00057DE8
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0000B957 File Offset: 0x00009B57
		public unsafe bool supportsLightLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_supportsLightLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_supportsLightLayers)) = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00059C10 File Offset: 0x00057E10
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x0000B972 File Offset: 0x00009B72
		public unsafe bool supportsAdditionalLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_supportsAdditionalLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightData.NativeFieldInfoPtr_supportsAdditionalLights)) = value;
			}
		}

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeFieldInfoPtr_mainLightIndex;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr_additionalLightsCount;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr_visibleLights;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr_shadeAdditionalLightsPerVertex;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr_supportsMixedLighting;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeBoxProjection;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeBlending;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_supportsLightLayers;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_supportsAdditionalLights;
	}
}
