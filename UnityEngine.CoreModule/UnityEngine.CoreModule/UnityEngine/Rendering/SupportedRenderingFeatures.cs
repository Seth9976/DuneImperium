using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024F RID: 591
	public class SupportedRenderingFeatures : Object
	{
		// Token: 0x060027ED RID: 10221 RVA: 0x000A8528 File Offset: 0x000A6728
		// Note: this type is marked as 'beforefieldinit'.
		static SupportedRenderingFeatures()
		{
			Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SupportedRenderingFeatures");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr);
			SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "s_Active");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbeModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultMixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<mixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapBakeTypes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapsModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlightenLightmapper>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlighten>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightProbeProxyVolumes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<motionVectors>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<receiveShadows>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbesBlendDistance>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererPriority>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendersUIOverlay>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnvironmentLighting>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesFog>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesRealtimeReflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesOtherLightingSettings>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<editableMaterialRenderQueue>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLODBias>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesMaximumLODLevel>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnableLODCrossFade>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<particleSystemInstancing>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoAmbientProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoDefaultReflectionProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesShadowmask>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystem>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<supportsHDR>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystemWarningMessage>k__BackingField");
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668431);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668432);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668433);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668434);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668435);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668436);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlightenLightmapper_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668437);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668438);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_motionVectors_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668439);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668440);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668441);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668442);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668443);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668444);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668445);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668446);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668447);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668448);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668449);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668450);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668451);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668452);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668453);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668454);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668455);
			SupportedRenderingFeatures.NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668456);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668457);
			SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668458);
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x000A89F4 File Offset: 0x000A6BF4
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x000A8A28 File Offset: 0x000A6C28
		public unsafe static SupportedRenderingFeatures active
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 685176, RefRangeEnd = 685203, XrefRangeStart = 685162, XrefRangeEnd = 685176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685209, RefRangeEnd = 685210, XrefRangeStart = 685203, XrefRangeEnd = 685209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x000A8A60 File Offset: 0x000A6C60
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._defaultMixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000A8A9C File Offset: 0x000A6C9C
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x0000F9CD File Offset: 0x0000DBCD
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._mixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000A8AD8 File Offset: 0x000A6CD8
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x0000F9D6 File Offset: 0x0000DBD6
		public unsafe LightmapBakeType lightmapBakeTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapBakeTypes_k__BackingField = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x000A8B14 File Offset: 0x000A6D14
		// (set) Token: 0x0600284E RID: 10318 RVA: 0x0000F9DF File Offset: 0x0000DBDF
		public unsafe LightmapsMode lightmapsModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapsModes_k__BackingField = value;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x000A8B50 File Offset: 0x000A6D50
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
		public unsafe bool enlightenLightmapper
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlightenLightmapper_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._enlightenLightmapper_k__BackingField = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x000A8B8C File Offset: 0x000A6D8C
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x0000F9F1 File Offset: 0x0000DBF1
		public unsafe bool enlighten
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._enlighten_k__BackingField = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x0000FA0B File Offset: 0x0000DC0B
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x000A8BC8 File Offset: 0x000A6DC8
		public unsafe bool motionVectors
		{
			get
			{
				return this._motionVectors_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_motionVectors_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x000A8C08 File Offset: 0x000A6E08
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x000A8C44 File Offset: 0x000A6E44
		public unsafe bool rendersUIOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000A8C84 File Offset: 0x000A6E84
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x0000FB01 File Offset: 0x0000DD01
		public unsafe bool autoAmbientProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoAmbientProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x000A8CC0 File Offset: 0x000A6EC0
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x0000FB0A File Offset: 0x0000DD0A
		public unsafe bool autoDefaultReflectionProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoDefaultReflectionProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x000A8CFC File Offset: 0x000A6EFC
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x0000FB24 File Offset: 0x0000DD24
		public unsafe bool overridesLightProbeSystem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._overridesLightProbeSystem_k__BackingField = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x0000FB2D File Offset: 0x0000DD2D
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x000A8D38 File Offset: 0x000A6F38
		public unsafe bool supportsHDR
		{
			get
			{
				return this._supportsHDR_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000A8D78 File Offset: 0x000A6F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685210, XrefRangeEnd = 685223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fallbackModePtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000A8DAC File Offset: 0x000A6FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685223, XrefRangeEnd = 685244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mixedMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000A8DEC File Offset: 0x000A6FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685244, XrefRangeEnd = 685252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mixedMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000A8E2C File Offset: 0x000A702C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 685269, RefRangeEnd = 685273, XrefRangeStart = 685252, XrefRangeEnd = 685269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bakeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000A8E6C File Offset: 0x000A706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685273, XrefRangeEnd = 685287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bakeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000A8EAC File Offset: 0x000A70AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685287, XrefRangeEnd = 685292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000A8EEC File Offset: 0x000A70EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685292, XrefRangeEnd = 685294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightmapper;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000A8F2C File Offset: 0x000A712C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685294, XrefRangeEnd = 685299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000A8F60 File Offset: 0x000A7160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685299, XrefRangeEnd = 685304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000A8F94 File Offset: 0x000A7194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685304, XrefRangeEnd = 685309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000A8FC8 File Offset: 0x000A71C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685309, XrefRangeEnd = 685314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OverridesLightProbeSystem(IntPtr overridesPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overridesPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000A8FFC File Offset: 0x000A71FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685314, XrefRangeEnd = 685315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightmapperPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000A9030 File Offset: 0x000A7230
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 685320, RefRangeEnd = 685323, XrefRangeStart = 685315, XrefRangeEnd = 685320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupportedRenderingFeatures()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x0000F66A File Offset: 0x0000D86A
		public SupportedRenderingFeatures(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000A906C File Offset: 0x000A726C
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x0000F673 File Offset: 0x0000D873
		public unsafe static SupportedRenderingFeatures s_Active
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000A9094 File Offset: 0x000A7294
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x0000F685 File Offset: 0x0000D885
		public unsafe SupportedRenderingFeatures.ReflectionProbeModes _reflectionProbeModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x000A90BC File Offset: 0x000A72BC
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _defaultMixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x000A90E4 File Offset: 0x000A72E4
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x0000F6BB File Offset: 0x0000D8BB
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _mixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x000A910C File Offset: 0x000A730C
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x0000F6D6 File Offset: 0x0000D8D6
		public unsafe LightmapBakeType _lightmapBakeTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x000A9134 File Offset: 0x000A7334
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
		public unsafe LightmapsMode _lightmapsModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x000A915C File Offset: 0x000A735C
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x0000F70C File Offset: 0x0000D90C
		public unsafe bool _enlightenLightmapper_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x000A9184 File Offset: 0x000A7384
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x0000F727 File Offset: 0x0000D927
		public unsafe bool _enlighten_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000A91AC File Offset: 0x000A73AC
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x0000F742 File Offset: 0x0000D942
		public unsafe bool _lightProbeProxyVolumes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000A91D4 File Offset: 0x000A73D4
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x0000F75D File Offset: 0x0000D95D
		public unsafe bool _motionVectors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField)) = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000A91FC File Offset: 0x000A73FC
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x0000F778 File Offset: 0x0000D978
		public unsafe bool _receiveShadows_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField)) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000A9224 File Offset: 0x000A7424
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x0000F793 File Offset: 0x0000D993
		public unsafe bool _reflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000A924C File Offset: 0x000A744C
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x0000F7AE File Offset: 0x0000D9AE
		public unsafe bool _reflectionProbesBlendDistance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField)) = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000A9274 File Offset: 0x000A7474
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x0000F7C9 File Offset: 0x0000D9C9
		public unsafe bool _rendererPriority_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField)) = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x000A929C File Offset: 0x000A749C
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
		public unsafe bool _rendersUIOverlay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField)) = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x000A92C4 File Offset: 0x000A74C4
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x0000F7FF File Offset: 0x0000D9FF
		public unsafe bool _overridesEnvironmentLighting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField)) = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x000A92EC File Offset: 0x000A74EC
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x0000F81A File Offset: 0x0000DA1A
		public unsafe bool _overridesFog_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField)) = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000A9314 File Offset: 0x000A7514
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0000F835 File Offset: 0x0000DA35
		public unsafe bool _overridesRealtimeReflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x000A933C File Offset: 0x000A753C
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x0000F850 File Offset: 0x0000DA50
		public unsafe bool _overridesOtherLightingSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x000A9364 File Offset: 0x000A7564
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x0000F86B File Offset: 0x0000DA6B
		public unsafe bool _editableMaterialRenderQueue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000A938C File Offset: 0x000A758C
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x0000F886 File Offset: 0x0000DA86
		public unsafe bool _overridesLODBias_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000A93B4 File Offset: 0x000A75B4
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x0000F8A1 File Offset: 0x0000DAA1
		public unsafe bool _overridesMaximumLODLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x000A93DC File Offset: 0x000A75DC
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x0000F8BC File Offset: 0x0000DABC
		public unsafe bool _overridesEnableLODCrossFade_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x000A9404 File Offset: 0x000A7604
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x0000F8D7 File Offset: 0x0000DAD7
		public unsafe bool _rendererProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x000A942C File Offset: 0x000A762C
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x0000F8F2 File Offset: 0x0000DAF2
		public unsafe bool _particleSystemInstancing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x000A9454 File Offset: 0x000A7654
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x0000F90D File Offset: 0x0000DB0D
		public unsafe bool _autoAmbientProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x000A947C File Offset: 0x000A767C
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x0000F928 File Offset: 0x0000DB28
		public unsafe bool _autoDefaultReflectionProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x000A94A4 File Offset: 0x000A76A4
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x0000F943 File Offset: 0x0000DB43
		public unsafe bool _overridesShadowmask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField)) = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x000A94CC File Offset: 0x000A76CC
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x0000F95E File Offset: 0x0000DB5E
		public unsafe bool _overridesLightProbeSystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField)) = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x000A94F4 File Offset: 0x000A76F4
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x0000F979 File Offset: 0x0000DB79
		public unsafe bool _supportsHDR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField)) = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x000A951C File Offset: 0x000A771C
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x0000F994 File Offset: 0x0000DB94
		public unsafe string _overridesLightProbeSystemWarningMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x0000F9B3 File Offset: 0x0000DBB3
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x0000F9BB File Offset: 0x0000DBBB
		public SupportedRenderingFeatures.ReflectionProbeModes reflectionProbeModes
		{
			get
			{
				return this._reflectionProbeModes_k__BackingField;
			}
			set
			{
				this._reflectionProbeModes_k__BackingField = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x0000F9FA File Offset: 0x0000DBFA
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x0000FA02 File Offset: 0x0000DC02
		public bool lightProbeProxyVolumes
		{
			get
			{
				return this._lightProbeProxyVolumes_k__BackingField;
			}
			set
			{
				this._lightProbeProxyVolumes_k__BackingField = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x0000FA13 File Offset: 0x0000DC13
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x0000FA1B File Offset: 0x0000DC1B
		public bool receiveShadows
		{
			get
			{
				return this._receiveShadows_k__BackingField;
			}
			set
			{
				this._receiveShadows_k__BackingField = value;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x0000FA24 File Offset: 0x0000DC24
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		public bool reflectionProbes
		{
			get
			{
				return this._reflectionProbes_k__BackingField;
			}
			set
			{
				this._reflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x0000FA35 File Offset: 0x0000DC35
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x0000FA3D File Offset: 0x0000DC3D
		public bool reflectionProbesBlendDistance
		{
			get
			{
				return this._reflectionProbesBlendDistance_k__BackingField;
			}
			set
			{
				this._reflectionProbesBlendDistance_k__BackingField = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x0000FA46 File Offset: 0x0000DC46
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x0000FA4E File Offset: 0x0000DC4E
		public bool rendererPriority
		{
			get
			{
				return this._rendererPriority_k__BackingField;
			}
			set
			{
				this._rendererPriority_k__BackingField = value;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x0000FA57 File Offset: 0x0000DC57
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x0000FA5F File Offset: 0x0000DC5F
		public bool overridesEnvironmentLighting
		{
			get
			{
				return this._overridesEnvironmentLighting_k__BackingField;
			}
			set
			{
				this._overridesEnvironmentLighting_k__BackingField = value;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x0000FA68 File Offset: 0x0000DC68
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x0000FA70 File Offset: 0x0000DC70
		public bool overridesFog
		{
			get
			{
				return this._overridesFog_k__BackingField;
			}
			set
			{
				this._overridesFog_k__BackingField = value;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x0000FA79 File Offset: 0x0000DC79
		// (set) Token: 0x06002861 RID: 10337 RVA: 0x0000FA81 File Offset: 0x0000DC81
		public bool overridesRealtimeReflectionProbes
		{
			get
			{
				return this._overridesRealtimeReflectionProbes_k__BackingField;
			}
			set
			{
				this._overridesRealtimeReflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x0000FA8A File Offset: 0x0000DC8A
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x0000FA92 File Offset: 0x0000DC92
		public bool overridesOtherLightingSettings
		{
			get
			{
				return this._overridesOtherLightingSettings_k__BackingField;
			}
			set
			{
				this._overridesOtherLightingSettings_k__BackingField = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x0000FA9B File Offset: 0x0000DC9B
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x0000FAA3 File Offset: 0x0000DCA3
		public bool editableMaterialRenderQueue
		{
			get
			{
				return this._editableMaterialRenderQueue_k__BackingField;
			}
			set
			{
				this._editableMaterialRenderQueue_k__BackingField = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x0000FAB4 File Offset: 0x0000DCB4
		public bool overridesLODBias
		{
			get
			{
				return this._overridesLODBias_k__BackingField;
			}
			set
			{
				this._overridesLODBias_k__BackingField = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x0000FABD File Offset: 0x0000DCBD
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x0000FAC5 File Offset: 0x0000DCC5
		public bool overridesMaximumLODLevel
		{
			get
			{
				return this._overridesMaximumLODLevel_k__BackingField;
			}
			set
			{
				this._overridesMaximumLODLevel_k__BackingField = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x0000FACE File Offset: 0x0000DCCE
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x0000FAD6 File Offset: 0x0000DCD6
		public bool overridesEnableLODCrossFade
		{
			get
			{
				return this._overridesEnableLODCrossFade_k__BackingField;
			}
			set
			{
				this._overridesEnableLODCrossFade_k__BackingField = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x0000FADF File Offset: 0x0000DCDF
		// (set) Token: 0x0600286D RID: 10349 RVA: 0x0000FAE7 File Offset: 0x0000DCE7
		public bool rendererProbes
		{
			get
			{
				return this._rendererProbes_k__BackingField;
			}
			set
			{
				this._rendererProbes_k__BackingField = value;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		// (set) Token: 0x0600286F RID: 10351 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		public bool particleSystemInstancing
		{
			get
			{
				return this._particleSystemInstancing_k__BackingField;
			}
			set
			{
				this._particleSystemInstancing_k__BackingField = value;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x0000FB13 File Offset: 0x0000DD13
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x0000FB1B File Offset: 0x0000DD1B
		public bool overridesShadowmask
		{
			get
			{
				return this._overridesShadowmask_k__BackingField;
			}
			set
			{
				this._overridesShadowmask_k__BackingField = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x0000FB35 File Offset: 0x0000DD35
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x0000FB3D File Offset: 0x0000DD3D
		public string overridesLightProbeSystemWarningMessage
		{
			get
			{
				return this._overridesLightProbeSystemWarningMessage_k__BackingField;
			}
			set
			{
				this._overridesLightProbeSystemWarningMessage_k__BackingField = value;
			}
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000A9544 File Offset: 0x000A7744
		public unsafe static MixedLightingMode FallbackMixedLightingMode()
		{
			MixedLightingMode mixedLightingMode;
			SupportedRenderingFeatures.FallbackMixedLightingModeByRef(new IntPtr((void*)(&mixedLightingMode)));
			return mixedLightingMode;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000A9568 File Offset: 0x000A7768
		public unsafe static bool IsLightmapsModeSupported(LightmapsMode mode)
		{
			bool flag;
			SupportedRenderingFeatures.IsLightmapsModeSupportedByRef(mode, new IntPtr((void*)(&flag)));
			return flag;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000A958C File Offset: 0x000A778C
		public unsafe static bool IsLightmapperSupported(int lightmapper)
		{
			bool flag;
			SupportedRenderingFeatures.IsLightmapperSupportedByRef(lightmapper, new IntPtr((void*)(&flag)));
			return flag;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000A95B0 File Offset: 0x000A77B0
		public unsafe static int FallbackLightmapper()
		{
			int num;
			SupportedRenderingFeatures.FallbackLightmapperByRef(new IntPtr((void*)(&num)));
			return num;
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000A95D4 File Offset: 0x000A77D4
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0000FB46 File Offset: 0x0000DD46
		public bool terrainDetailUnsupported
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeFieldInfoPtr_s_Active;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbeModes_k__BackingField;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeFieldInfoPtr__mixedLightingModes_k__BackingField;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeFieldInfoPtr__lightmapsModes_k__BackingField;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeFieldInfoPtr__enlightenLightmapper_k__BackingField;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeFieldInfoPtr__enlighten_k__BackingField;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeFieldInfoPtr__motionVectors_k__BackingField;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeFieldInfoPtr__receiveShadows_k__BackingField;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbes_k__BackingField;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField;

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeFieldInfoPtr__rendererPriority_k__BackingField;

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeFieldInfoPtr__rendersUIOverlay_k__BackingField;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField;

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeFieldInfoPtr__overridesFog_k__BackingField;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeFieldInfoPtr__overridesLODBias_k__BackingField;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField;

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField;

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeFieldInfoPtr__rendererProbes_k__BackingField;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeFieldInfoPtr__particleSystemInstancing_k__BackingField;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeFieldInfoPtr__overridesShadowmask_k__BackingField;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeFieldInfoPtr__supportsHDR_k__BackingField;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_get_enlightenLightmapper_Public_get_Boolean_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_set_motionVectors_Public_set_Void_Boolean_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E8 RID: 2536
		[Flags]
		public enum ReflectionProbeModes
		{
			// Token: 0x04002D3D RID: 11581
			None = 0,
			// Token: 0x04002D3E RID: 11582
			Rotation = 1
		}

		// Token: 0x020009E9 RID: 2537
		[Flags]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x04002D40 RID: 11584
			None = 0,
			// Token: 0x04002D41 RID: 11585
			IndirectOnly = 1,
			// Token: 0x04002D42 RID: 11586
			Subtractive = 2,
			// Token: 0x04002D43 RID: 11587
			Shadowmask = 4
		}
	}
}
