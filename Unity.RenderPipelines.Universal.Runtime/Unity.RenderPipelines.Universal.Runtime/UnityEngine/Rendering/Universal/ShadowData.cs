using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000FC RID: 252
	public sealed class ShadowData : ValueType
	{
		// Token: 0x06001452 RID: 5202 RVA: 0x0005B2C8 File Offset: 0x000594C8
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowData()
		{
			Il2CppClassPointerStore<ShadowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowData>.NativeClassPtr);
			ShadowData.NativeFieldInfoPtr_supportsMainLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "supportsMainLightShadows");
			ShadowData.NativeFieldInfoPtr_mainLightShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "mainLightShadowsEnabled");
			ShadowData.NativeFieldInfoPtr_requiresScreenSpaceShadowResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "requiresScreenSpaceShadowResolve");
			ShadowData.NativeFieldInfoPtr_mainLightShadowmapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "mainLightShadowmapWidth");
			ShadowData.NativeFieldInfoPtr_mainLightShadowmapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "mainLightShadowmapHeight");
			ShadowData.NativeFieldInfoPtr_mainLightShadowCascadesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "mainLightShadowCascadesCount");
			ShadowData.NativeFieldInfoPtr_mainLightShadowCascadesSplit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "mainLightShadowCascadesSplit");
			ShadowData.NativeFieldInfoPtr_mainLightShadowCascadeBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "mainLightShadowCascadeBorder");
			ShadowData.NativeFieldInfoPtr_supportsAdditionalLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "supportsAdditionalLightShadows");
			ShadowData.NativeFieldInfoPtr_additionalLightShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "additionalLightShadowsEnabled");
			ShadowData.NativeFieldInfoPtr_additionalLightsShadowmapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "additionalLightsShadowmapWidth");
			ShadowData.NativeFieldInfoPtr_additionalLightsShadowmapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "additionalLightsShadowmapHeight");
			ShadowData.NativeFieldInfoPtr_supportsSoftShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "supportsSoftShadows");
			ShadowData.NativeFieldInfoPtr_shadowmapDepthBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "shadowmapDepthBufferBits");
			ShadowData.NativeFieldInfoPtr_bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "bias");
			ShadowData.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "resolution");
			ShadowData.NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "isKeywordAdditionalLightShadowsEnabled");
			ShadowData.NativeFieldInfoPtr_isKeywordSoftShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "isKeywordSoftShadowsEnabled");
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0000BF0E File Offset: 0x0000A10E
		public ShadowData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0000BF17 File Offset: 0x0000A117
		public ShadowData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowData>.NativeClassPtr))
		{
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0005B460 File Offset: 0x00059660
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x0000BF29 File Offset: 0x0000A129
		public unsafe bool supportsMainLightShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_supportsMainLightShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_supportsMainLightShadows)) = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0005B488 File Offset: 0x00059688
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0000BF44 File Offset: 0x0000A144
		public unsafe bool mainLightShadowsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowsEnabled)) = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0005B4B0 File Offset: 0x000596B0
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000BF5F File Offset: 0x0000A15F
		public unsafe bool requiresScreenSpaceShadowResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_requiresScreenSpaceShadowResolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_requiresScreenSpaceShadowResolve)) = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0005B4D8 File Offset: 0x000596D8
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0000BF7A File Offset: 0x0000A17A
		public unsafe int mainLightShadowmapWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowmapWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowmapWidth)) = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0005B500 File Offset: 0x00059700
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0000BF95 File Offset: 0x0000A195
		public unsafe int mainLightShadowmapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowmapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowmapHeight)) = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0005B528 File Offset: 0x00059728
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		public unsafe int mainLightShadowCascadesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowCascadesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowCascadesCount)) = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0005B550 File Offset: 0x00059750
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x0000BFCB File Offset: 0x0000A1CB
		public unsafe Vector3 mainLightShadowCascadesSplit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowCascadesSplit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowCascadesSplit)) = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0005B578 File Offset: 0x00059778
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0000BFE6 File Offset: 0x0000A1E6
		public unsafe float mainLightShadowCascadeBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowCascadeBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_mainLightShadowCascadeBorder)) = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0005B5A0 File Offset: 0x000597A0
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0000C001 File Offset: 0x0000A201
		public unsafe bool supportsAdditionalLightShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_supportsAdditionalLightShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_supportsAdditionalLightShadows)) = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0005B5C8 File Offset: 0x000597C8
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x0000C01C File Offset: 0x0000A21C
		public unsafe bool additionalLightShadowsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_additionalLightShadowsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_additionalLightShadowsEnabled)) = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0005B5F0 File Offset: 0x000597F0
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0000C037 File Offset: 0x0000A237
		public unsafe int additionalLightsShadowmapWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_additionalLightsShadowmapWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_additionalLightsShadowmapWidth)) = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0005B618 File Offset: 0x00059818
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x0000C052 File Offset: 0x0000A252
		public unsafe int additionalLightsShadowmapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_additionalLightsShadowmapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_additionalLightsShadowmapHeight)) = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0005B640 File Offset: 0x00059840
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0000C06D File Offset: 0x0000A26D
		public unsafe bool supportsSoftShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_supportsSoftShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_supportsSoftShadows)) = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0005B668 File Offset: 0x00059868
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000C088 File Offset: 0x0000A288
		public unsafe int shadowmapDepthBufferBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_shadowmapDepthBufferBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_shadowmapDepthBufferBits)) = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0005B690 File Offset: 0x00059890
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000C0A3 File Offset: 0x0000A2A3
		public unsafe List<Vector4> bias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_bias);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_bias), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0005B6C0 File Offset: 0x000598C0
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0000C0C2 File Offset: 0x0000A2C2
		public unsafe List<int> resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_resolution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_resolution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0005B6F0 File Offset: 0x000598F0
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
		public unsafe bool isKeywordAdditionalLightShadowsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled)) = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0005B718 File Offset: 0x00059918
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		public unsafe bool isKeywordSoftShadowsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_isKeywordSoftShadowsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowData.NativeFieldInfoPtr_isKeywordSoftShadowsEnabled)) = value;
			}
		}

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeFieldInfoPtr_supportsMainLightShadows;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowsEnabled;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeFieldInfoPtr_requiresScreenSpaceShadowResolve;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowmapWidth;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowmapHeight;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowCascadesCount;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowCascadesSplit;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowCascadeBorder;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeFieldInfoPtr_supportsAdditionalLightShadows;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeFieldInfoPtr_additionalLightShadowsEnabled;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeFieldInfoPtr_additionalLightsShadowmapWidth;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeFieldInfoPtr_additionalLightsShadowmapHeight;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeFieldInfoPtr_supportsSoftShadows;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeFieldInfoPtr_shadowmapDepthBufferBits;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeFieldInfoPtr_bias;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeFieldInfoPtr_resolution;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeFieldInfoPtr_isKeywordSoftShadowsEnabled;
	}
}
