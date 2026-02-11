using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200009E RID: 158
	public sealed class QualitySettings : Object
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x00035A88 File Offset: 0x00033C88
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySettings()
		{
			Il2CppClassPointerStore<QualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "QualitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr);
			QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, "activeQualityLevelChanged");
			QualitySettings.NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664403);
			QualitySettings.NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664404);
			QualitySettings.NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664405);
			QualitySettings.NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664406);
			QualitySettings.NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664407);
			QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664408);
			QualitySettings.NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664409);
			QualitySettings.NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664410);
			QualitySettings.NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664411);
			QualitySettings.NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664412);
			QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664413);
			QualitySettings.NativeMethodInfoPtr_get_desiredColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664414);
			QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664415);
			QualitySettings.get_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowsDelegate>("UnityEngine.QualitySettings::get_shadows");
			QualitySettings.set_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowsDelegate>("UnityEngine.QualitySettings::set_shadows");
			QualitySettings.get_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowProjectionDelegate>("UnityEngine.QualitySettings::get_shadowProjection");
			QualitySettings.set_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowProjectionDelegate>("UnityEngine.QualitySettings::set_shadowProjection");
			QualitySettings.get_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascadesDelegate>("UnityEngine.QualitySettings::get_shadowCascades");
			QualitySettings.set_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascadesDelegate>("UnityEngine.QualitySettings::set_shadowCascades");
			QualitySettings.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowDistanceDelegate>("UnityEngine.QualitySettings::get_shadowDistance");
			QualitySettings.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowDistanceDelegate>("UnityEngine.QualitySettings::set_shadowDistance");
			QualitySettings.get_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowResolutionDelegate>("UnityEngine.QualitySettings::get_shadowResolution");
			QualitySettings.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowResolutionDelegate>("UnityEngine.QualitySettings::set_shadowResolution");
			QualitySettings.set_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowmaskModeDelegate>("UnityEngine.QualitySettings::set_shadowmaskMode");
			QualitySettings.get_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::get_shadowNearPlaneOffset");
			QualitySettings.set_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::set_shadowNearPlaneOffset");
			QualitySettings.get_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::get_shadowCascade2Split");
			QualitySettings.set_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::set_shadowCascade2Split");
			QualitySettings.get_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_lodBiasDelegate>("UnityEngine.QualitySettings::get_lodBias");
			QualitySettings.set_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_lodBiasDelegate>("UnityEngine.QualitySettings::set_lodBias");
			QualitySettings.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.get_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::get_anisotropicFiltering");
			QualitySettings.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.set_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::set_anisotropicFiltering");
			QualitySettings.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_masterTextureLimitDelegate>("UnityEngine.QualitySettings::get_masterTextureLimit");
			QualitySettings.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_masterTextureLimitDelegate>("UnityEngine.QualitySettings::set_masterTextureLimit");
			QualitySettings.get_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::get_globalTextureMipmapLimit");
			QualitySettings.set_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::set_globalTextureMipmapLimit");
			QualitySettings.get_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maximumLODLevelDelegate>("UnityEngine.QualitySettings::get_maximumLODLevel");
			QualitySettings.set_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maximumLODLevelDelegate>("UnityEngine.QualitySettings::set_maximumLODLevel");
			QualitySettings.get_enableLODCrossFadeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_enableLODCrossFadeDelegate>("UnityEngine.QualitySettings::get_enableLODCrossFade");
			QualitySettings.get_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::get_particleRaycastBudget");
			QualitySettings.set_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::set_particleRaycastBudget");
			QualitySettings.get_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softParticlesDelegate>("UnityEngine.QualitySettings::get_softParticles");
			QualitySettings.set_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softParticlesDelegate>("UnityEngine.QualitySettings::set_softParticles");
			QualitySettings.get_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softVegetationDelegate>("UnityEngine.QualitySettings::get_softVegetation");
			QualitySettings.set_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softVegetationDelegate>("UnityEngine.QualitySettings::set_softVegetation");
			QualitySettings.get_vSyncCountDelegateField = IL2CPP.ResolveICall<QualitySettings.get_vSyncCountDelegate>("UnityEngine.QualitySettings::get_vSyncCount");
			QualitySettings.get_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::get_realtimeGICPUUsage");
			QualitySettings.set_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::set_realtimeGICPUUsage");
			QualitySettings.get_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::get_asyncUploadTimeSlice");
			QualitySettings.set_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::set_asyncUploadTimeSlice");
			QualitySettings.get_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::get_asyncUploadBufferSize");
			QualitySettings.set_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::set_asyncUploadBufferSize");
			QualitySettings.get_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::get_asyncUploadPersistentBuffer");
			QualitySettings.set_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::set_asyncUploadPersistentBuffer");
			QualitySettings.SetLODSettingsDelegateField = IL2CPP.ResolveICall<QualitySettings.SetLODSettingsDelegate>("UnityEngine.QualitySettings::SetLODSettings");
			QualitySettings.get_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::get_realtimeReflectionProbes");
			QualitySettings.set_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::set_realtimeReflectionProbes");
			QualitySettings.set_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::set_billboardsFaceCameraPosition");
			QualitySettings.get_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::get_useLegacyDetailDistribution");
			QualitySettings.set_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::set_useLegacyDetailDistribution");
			QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::get_resolutionScalingFixedDPIFactor");
			QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::set_resolutionScalingFixedDPIFactor");
			QualitySettings.get_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::get_terrainQualityOverrides");
			QualitySettings.set_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::set_terrainQualityOverrides");
			QualitySettings.get_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::get_terrainPixelError");
			QualitySettings.set_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::set_terrainPixelError");
			QualitySettings.get_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::get_terrainDetailDensityScale");
			QualitySettings.set_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::set_terrainDetailDensityScale");
			QualitySettings.get_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::get_terrainBasemapDistance");
			QualitySettings.set_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::set_terrainBasemapDistance");
			QualitySettings.get_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::get_terrainDetailDistance");
			QualitySettings.set_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::set_terrainDetailDistance");
			QualitySettings.get_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::get_terrainTreeDistance");
			QualitySettings.set_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::set_terrainTreeDistance");
			QualitySettings.get_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::get_terrainBillboardStart");
			QualitySettings.set_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::set_terrainBillboardStart");
			QualitySettings.get_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::get_terrainFadeLength");
			QualitySettings.set_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::set_terrainFadeLength");
			QualitySettings.get_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::get_terrainMaxTrees");
			QualitySettings.set_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::set_terrainMaxTrees");
			QualitySettings.get_INTERNAL_renderPipelineDelegateField = IL2CPP.ResolveICall<QualitySettings.get_INTERNAL_renderPipelineDelegate>("UnityEngine.QualitySettings::get_INTERNAL_renderPipeline");
			QualitySettings.set_INTERNAL_renderPipelineDelegateField = IL2CPP.ResolveICall<QualitySettings.set_INTERNAL_renderPipelineDelegate>("UnityEngine.QualitySettings::set_INTERNAL_renderPipeline");
			QualitySettings.InternalGetRenderPipelineAssetAtDelegateField = IL2CPP.ResolveICall<QualitySettings.InternalGetRenderPipelineAssetAtDelegate>("UnityEngine.QualitySettings::InternalGetRenderPipelineAssetAt");
			QualitySettings.get_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_blendWeightsDelegate>("UnityEngine.QualitySettings::get_blendWeights");
			QualitySettings.set_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_blendWeightsDelegate>("UnityEngine.QualitySettings::set_blendWeights");
			QualitySettings.get_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_skinWeightsDelegate>("UnityEngine.QualitySettings::get_skinWeights");
			QualitySettings.set_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_skinWeightsDelegate>("UnityEngine.QualitySettings::set_skinWeights");
			QualitySettings.get_countDelegateField = IL2CPP.ResolveICall<QualitySettings.get_countDelegate>("UnityEngine.QualitySettings::get_count");
			QualitySettings.get_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsActive");
			QualitySettings.set_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsActive");
			QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMemoryBudget");
			QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMemoryBudget");
			QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsRenderersPerFrame");
			QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsRenderersPerFrame");
			QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxLevelReduction");
			QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxLevelReduction");
			QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsAddAllCameras");
			QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsAddAllCameras");
			QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxFileIORequests");
			QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxFileIORequests");
			QualitySettings.get_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::get_maxQueuedFrames");
			QualitySettings.set_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::set_maxQueuedFrames");
			QualitySettings.GetQualitySettingsDelegateField = IL2CPP.ResolveICall<QualitySettings.GetQualitySettingsDelegate>("UnityEngine.QualitySettings::GetQualitySettings");
			QualitySettings.get_namesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_namesDelegate>("UnityEngine.QualitySettings::get_names");
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::get_shadowCascade4Split_Injected");
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::set_shadowCascade4Split_Injected");
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00036144 File Offset: 0x00034344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650162, XrefRangeEnd = 650164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref previousQualityLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentQualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00036184 File Offset: 0x00034384
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x000361B4 File Offset: 0x000343B4
		public unsafe static int pixelLightCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650166, RefRangeEnd = 650167, XrefRangeStart = 650164, XrefRangeEnd = 650166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650169, RefRangeEnd = 650170, XrefRangeStart = 650167, XrefRangeEnd = 650169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000361E8 File Offset: 0x000343E8
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public unsafe static ShadowmaskMode shadowmaskMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650172, RefRangeEnd = 650174, XrefRangeStart = 650170, XrefRangeEnd = 650172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				QualitySettings.set_shadowmaskModeDelegateField(value);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00005D69 File Offset: 0x00003F69
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00036218 File Offset: 0x00034418
		public unsafe static bool enableLODCrossFade
		{
			get
			{
				return QualitySettings.get_enableLODCrossFadeDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650176, RefRangeEnd = 650177, XrefRangeStart = 650174, XrefRangeEnd = 650176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00005DC0 File Offset: 0x00003FC0
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x0003624C File Offset: 0x0003444C
		public unsafe static int vSyncCount
		{
			get
			{
				return QualitySettings.get_vSyncCountDelegateField();
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 650179, RefRangeEnd = 650183, XrefRangeStart = 650177, XrefRangeEnd = 650179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00036280 File Offset: 0x00034480
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x000362B0 File Offset: 0x000344B0
		public unsafe static int antiAliasing
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650185, RefRangeEnd = 650188, XrefRangeStart = 650183, XrefRangeEnd = 650185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650190, RefRangeEnd = 650191, XrefRangeStart = 650188, XrefRangeEnd = 650190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x000362E4 File Offset: 0x000344E4
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00005E58 File Offset: 0x00004058
		public unsafe static bool billboardsFaceCameraPosition
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650193, RefRangeEnd = 650195, XrefRangeStart = 650191, XrefRangeEnd = 650193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				QualitySettings.set_billboardsFaceCameraPositionDelegateField(value);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00036314 File Offset: 0x00034514
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 650197, RefRangeEnd = 650204, XrefRangeStart = 650195, XrefRangeEnd = 650197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetQualityLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00036344 File Offset: 0x00034544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 650206, RefRangeEnd = 650207, XrefRangeStart = 650204, XrefRangeEnd = 650206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetQualityLevel(int index, bool applyExpensiveChanges)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyExpensiveChanges;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00036384 File Offset: 0x00034584
		public unsafe static ColorSpace desiredColorSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_desiredColorSpace_Public_Static_get_ColorSpace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000363B4 File Offset: 0x000345B4
		public unsafe static ColorSpace activeColorSpace
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 650209, RefRangeEnd = 650224, XrefRangeStart = 650207, XrefRangeEnd = 650209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00005B99 File Offset: 0x00003D99
		public QualitySettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000363E4 File Offset: 0x000345E4
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00005BA2 File Offset: 0x00003DA2
		public unsafe static Action<int, int> activeQualityLevelChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00005BB4 File Offset: 0x00003DB4
		public static void add_activeQualityLevelChanged(Action<int, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00005BC1 File Offset: 0x00003DC1
		public static void remove_activeQualityLevelChanged(Action<int, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00005BCE File Offset: 0x00003DCE
		public static void IncreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() + 1, applyExpensiveChanges);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00005BDF File Offset: 0x00003DDF
		public static void DecreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() - 1, applyExpensiveChanges);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00005BF0 File Offset: 0x00003DF0
		public static void SetQualityLevel(int index)
		{
			QualitySettings.SetQualityLevel(index, true);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00005BFB File Offset: 0x00003DFB
		public static void IncreaseLevel()
		{
			QualitySettings.IncreaseLevel(false);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00005C05 File Offset: 0x00003E05
		public static void DecreaseLevel()
		{
			QualitySettings.DecreaseLevel(false);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0003640C File Offset: 0x0003460C
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00005C0F File Offset: 0x00003E0F
		public static QualityLevel currentLevel
		{
			get
			{
				return (QualityLevel)QualitySettings.GetQualityLevel();
			}
			set
			{
				QualitySettings.SetQualityLevel((int)value, true);
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00036424 File Offset: 0x00034624
		public static void ForEach(Action callback)
		{
			bool flag = callback == null;
			if (!flag)
			{
				int qualityLevel = QualitySettings.GetQualityLevel();
				try
				{
					for (int i = 0; i < QualitySettings.count; i++)
					{
						QualitySettings.SetQualityLevel(i, false);
						callback.Invoke();
					}
				}
				finally
				{
					QualitySettings.SetQualityLevel(qualityLevel, false);
				}
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00005C1A File Offset: 0x00003E1A
		public static void ForEach(Action<int, string> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00005C27 File Offset: 0x00003E27
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00005C33 File Offset: 0x00003E33
		public static ShadowQuality shadows
		{
			get
			{
				return QualitySettings.get_shadowsDelegateField();
			}
			set
			{
				QualitySettings.set_shadowsDelegateField(value);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00005C40 File Offset: 0x00003E40
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00005C4C File Offset: 0x00003E4C
		public static ShadowProjection shadowProjection
		{
			get
			{
				return QualitySettings.get_shadowProjectionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowProjectionDelegateField(value);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00005C59 File Offset: 0x00003E59
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00005C65 File Offset: 0x00003E65
		public static int shadowCascades
		{
			get
			{
				return QualitySettings.get_shadowCascadesDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascadesDelegateField(value);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00005C72 File Offset: 0x00003E72
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00005C7E File Offset: 0x00003E7E
		public static float shadowDistance
		{
			get
			{
				return QualitySettings.get_shadowDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_shadowDistanceDelegateField(value);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00005C8B File Offset: 0x00003E8B
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00005C97 File Offset: 0x00003E97
		public static ShadowResolution shadowResolution
		{
			get
			{
				return QualitySettings.get_shadowResolutionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowResolutionDelegateField(value);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00005CB1 File Offset: 0x00003EB1
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00005CBD File Offset: 0x00003EBD
		public static float shadowNearPlaneOffset
		{
			get
			{
				return QualitySettings.get_shadowNearPlaneOffsetDelegateField();
			}
			set
			{
				QualitySettings.set_shadowNearPlaneOffsetDelegateField(value);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00005CCA File Offset: 0x00003ECA
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00005CD6 File Offset: 0x00003ED6
		public static float shadowCascade2Split
		{
			get
			{
				return QualitySettings.get_shadowCascade2SplitDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascade2SplitDelegateField(value);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00036488 File Offset: 0x00034688
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00005CE3 File Offset: 0x00003EE3
		public static Vector3 shadowCascade4Split
		{
			get
			{
				Vector3 vector;
				QualitySettings.get_shadowCascade4Split_Injected(out vector);
				return vector;
			}
			set
			{
				QualitySettings.set_shadowCascade4Split_Injected(ref value);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00005CEC File Offset: 0x00003EEC
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public static float lodBias
		{
			get
			{
				return QualitySettings.get_lodBiasDelegateField();
			}
			set
			{
				QualitySettings.set_lodBiasDelegateField(value);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00005D05 File Offset: 0x00003F05
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00005D11 File Offset: 0x00003F11
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return QualitySettings.get_anisotropicFilteringDelegateField();
			}
			set
			{
				QualitySettings.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00005D1E File Offset: 0x00003F1E
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00005D2A File Offset: 0x00003F2A
		public static int masterTextureLimit
		{
			get
			{
				return QualitySettings.get_masterTextureLimitDelegateField();
			}
			set
			{
				QualitySettings.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00005D37 File Offset: 0x00003F37
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00005D43 File Offset: 0x00003F43
		public static int globalTextureMipmapLimit
		{
			get
			{
				return QualitySettings.get_globalTextureMipmapLimitDelegateField();
			}
			set
			{
				QualitySettings.set_globalTextureMipmapLimitDelegateField(value);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00005D50 File Offset: 0x00003F50
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00005D5C File Offset: 0x00003F5C
		public static int maximumLODLevel
		{
			get
			{
				return QualitySettings.get_maximumLODLevelDelegateField();
			}
			set
			{
				QualitySettings.set_maximumLODLevelDelegateField(value);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00005D75 File Offset: 0x00003F75
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00005D81 File Offset: 0x00003F81
		public static int particleRaycastBudget
		{
			get
			{
				return QualitySettings.get_particleRaycastBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_particleRaycastBudgetDelegateField(value);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00005D8E File Offset: 0x00003F8E
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00005D9A File Offset: 0x00003F9A
		public static bool softParticles
		{
			get
			{
				return QualitySettings.get_softParticlesDelegateField();
			}
			set
			{
				QualitySettings.set_softParticlesDelegateField(value);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00005DA7 File Offset: 0x00003FA7
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00005DB3 File Offset: 0x00003FB3
		public static bool softVegetation
		{
			get
			{
				return QualitySettings.get_softVegetationDelegateField();
			}
			set
			{
				QualitySettings.set_softVegetationDelegateField(value);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00005DCC File Offset: 0x00003FCC
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public static int realtimeGICPUUsage
		{
			get
			{
				return QualitySettings.get_realtimeGICPUUsageDelegateField();
			}
			set
			{
				QualitySettings.set_realtimeGICPUUsageDelegateField(value);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00005DE5 File Offset: 0x00003FE5
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00005DF1 File Offset: 0x00003FF1
		public static int asyncUploadTimeSlice
		{
			get
			{
				return QualitySettings.get_asyncUploadTimeSliceDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadTimeSliceDelegateField(value);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00005DFE File Offset: 0x00003FFE
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00005E0A File Offset: 0x0000400A
		public static int asyncUploadBufferSize
		{
			get
			{
				return QualitySettings.get_asyncUploadBufferSizeDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadBufferSizeDelegateField(value);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00005E17 File Offset: 0x00004017
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00005E23 File Offset: 0x00004023
		public static bool asyncUploadPersistentBuffer
		{
			get
			{
				return QualitySettings.get_asyncUploadPersistentBufferDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadPersistentBufferDelegateField(value);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00005E30 File Offset: 0x00004030
		public static void SetLODSettings(float lodBias, int maximumLODLevel, [Optional] bool setDirty)
		{
			QualitySettings.SetLODSettingsDelegateField(lodBias, maximumLODLevel, setDirty);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00005E3F File Offset: 0x0000403F
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00005E4B File Offset: 0x0000404B
		public static bool realtimeReflectionProbes
		{
			get
			{
				return QualitySettings.get_realtimeReflectionProbesDelegateField();
			}
			set
			{
				QualitySettings.set_realtimeReflectionProbesDelegateField(value);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00005E65 File Offset: 0x00004065
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00005E71 File Offset: 0x00004071
		public static bool useLegacyDetailDistribution
		{
			get
			{
				return QualitySettings.get_useLegacyDetailDistributionDelegateField();
			}
			set
			{
				QualitySettings.set_useLegacyDetailDistributionDelegateField(value);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00005E7E File Offset: 0x0000407E
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00005E8A File Offset: 0x0000408A
		public static float resolutionScalingFixedDPIFactor
		{
			get
			{
				return QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField();
			}
			set
			{
				QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField(value);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00005E97 File Offset: 0x00004097
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00005EA3 File Offset: 0x000040A3
		public static TerrainQualityOverrides terrainQualityOverrides
		{
			get
			{
				return QualitySettings.get_terrainQualityOverridesDelegateField();
			}
			set
			{
				QualitySettings.set_terrainQualityOverridesDelegateField(value);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00005EB0 File Offset: 0x000040B0
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00005EBC File Offset: 0x000040BC
		public static float terrainPixelError
		{
			get
			{
				return QualitySettings.get_terrainPixelErrorDelegateField();
			}
			set
			{
				QualitySettings.set_terrainPixelErrorDelegateField(value);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00005EC9 File Offset: 0x000040C9
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00005ED5 File Offset: 0x000040D5
		public static float terrainDetailDensityScale
		{
			get
			{
				return QualitySettings.get_terrainDetailDensityScaleDelegateField();
			}
			set
			{
				QualitySettings.set_terrainDetailDensityScaleDelegateField(value);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00005EE2 File Offset: 0x000040E2
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00005EEE File Offset: 0x000040EE
		public static float terrainBasemapDistance
		{
			get
			{
				return QualitySettings.get_terrainBasemapDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_terrainBasemapDistanceDelegateField(value);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00005EFB File Offset: 0x000040FB
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00005F07 File Offset: 0x00004107
		public static float terrainDetailDistance
		{
			get
			{
				return QualitySettings.get_terrainDetailDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_terrainDetailDistanceDelegateField(value);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00005F14 File Offset: 0x00004114
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00005F20 File Offset: 0x00004120
		public static float terrainTreeDistance
		{
			get
			{
				return QualitySettings.get_terrainTreeDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_terrainTreeDistanceDelegateField(value);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00005F2D File Offset: 0x0000412D
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00005F39 File Offset: 0x00004139
		public static float terrainBillboardStart
		{
			get
			{
				return QualitySettings.get_terrainBillboardStartDelegateField();
			}
			set
			{
				QualitySettings.set_terrainBillboardStartDelegateField(value);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00005F46 File Offset: 0x00004146
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00005F52 File Offset: 0x00004152
		public static float terrainFadeLength
		{
			get
			{
				return QualitySettings.get_terrainFadeLengthDelegateField();
			}
			set
			{
				QualitySettings.set_terrainFadeLengthDelegateField(value);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00005F5F File Offset: 0x0000415F
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00005F6B File Offset: 0x0000416B
		public static float terrainMaxTrees
		{
			get
			{
				return QualitySettings.get_terrainMaxTreesDelegateField();
			}
			set
			{
				QualitySettings.set_terrainMaxTreesDelegateField(value);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000364A0 File Offset: 0x000346A0
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00005F78 File Offset: 0x00004178
		public static ScriptableObject INTERNAL_renderPipeline
		{
			get
			{
				IntPtr intPtr = QualitySettings.get_INTERNAL_renderPipelineDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				QualitySettings.set_INTERNAL_renderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000364C8 File Offset: 0x000346C8
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00005F8A File Offset: 0x0000418A
		public static UnityEngine.Rendering.RenderPipelineAsset renderPipeline
		{
			get
			{
				return QualitySettings.INTERNAL_renderPipeline.TryCast<UnityEngine.Rendering.RenderPipelineAsset>();
			}
			set
			{
				QualitySettings.INTERNAL_renderPipeline = value;
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000364E4 File Offset: 0x000346E4
		public static ScriptableObject InternalGetRenderPipelineAssetAt(int index)
		{
			IntPtr intPtr = QualitySettings.InternalGetRenderPipelineAssetAtDelegateField(index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0003650C File Offset: 0x0003470C
		public static UnityEngine.Rendering.RenderPipelineAsset GetRenderPipelineAssetAt(int index)
		{
			bool flag = index < 0 || index >= QualitySettings.names.Length;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("{0} is out of range [0..{1}[", "index", QualitySettings.names.Length));
			}
			return QualitySettings.InternalGetRenderPipelineAssetAt(index).TryCast<UnityEngine.Rendering.RenderPipelineAsset>();
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00005F94 File Offset: 0x00004194
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00005FA0 File Offset: 0x000041A0
		public static BlendWeights blendWeights
		{
			get
			{
				return QualitySettings.get_blendWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_blendWeightsDelegateField(value);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00005FAD File Offset: 0x000041AD
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00005FB9 File Offset: 0x000041B9
		public static SkinWeights skinWeights
		{
			get
			{
				return QualitySettings.get_skinWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_skinWeightsDelegateField(value);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00005FC6 File Offset: 0x000041C6
		public static int count
		{
			get
			{
				return QualitySettings.get_countDelegateField();
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00005FD2 File Offset: 0x000041D2
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00005FDE File Offset: 0x000041DE
		public static bool streamingMipmapsActive
		{
			get
			{
				return QualitySettings.get_streamingMipmapsActiveDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsActiveDelegateField(value);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00005FEB File Offset: 0x000041EB
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00005FF7 File Offset: 0x000041F7
		public static float streamingMipmapsMemoryBudget
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField(value);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00006004 File Offset: 0x00004204
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00006010 File Offset: 0x00004210
		public static int streamingMipmapsRenderersPerFrame
		{
			get
			{
				return QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField(value);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0000601D File Offset: 0x0000421D
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00006029 File Offset: 0x00004229
		public static int streamingMipmapsMaxLevelReduction
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField(value);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00006036 File Offset: 0x00004236
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00006042 File Offset: 0x00004242
		public static bool streamingMipmapsAddAllCameras
		{
			get
			{
				return QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField(value);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0000604F File Offset: 0x0000424F
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0000605B File Offset: 0x0000425B
		public static int streamingMipmapsMaxFileIORequests
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField(value);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00006068 File Offset: 0x00004268
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00006074 File Offset: 0x00004274
		public static int maxQueuedFrames
		{
			get
			{
				return QualitySettings.get_maxQueuedFramesDelegateField();
			}
			set
			{
				QualitySettings.set_maxQueuedFramesDelegateField(value);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0003656C File Offset: 0x0003476C
		public static Object GetQualitySettings()
		{
			IntPtr intPtr = QualitySettings.GetQualitySettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00036594 File Offset: 0x00034794
		public static Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = QualitySettings.get_namesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00006081 File Offset: 0x00004281
		public static void get_shadowCascade4Split_Injected(out Vector3 ret)
		{
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField(out ret);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0000608E File Offset: 0x0000428E
		public static void set_shadowCascade4Split_Injected(ref Vector3 value)
		{
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField(ref value);
		}

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr_activeQualityLevelChanged;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_get_desiredColorSpace_Public_Static_get_ColorSpace_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0;

		// Token: 0x040007AC RID: 1964
		private static readonly QualitySettings.get_shadowsDelegate get_shadowsDelegateField;

		// Token: 0x040007AD RID: 1965
		private static readonly QualitySettings.set_shadowsDelegate set_shadowsDelegateField;

		// Token: 0x040007AE RID: 1966
		private static readonly QualitySettings.get_shadowProjectionDelegate get_shadowProjectionDelegateField;

		// Token: 0x040007AF RID: 1967
		private static readonly QualitySettings.set_shadowProjectionDelegate set_shadowProjectionDelegateField;

		// Token: 0x040007B0 RID: 1968
		private static readonly QualitySettings.get_shadowCascadesDelegate get_shadowCascadesDelegateField;

		// Token: 0x040007B1 RID: 1969
		private static readonly QualitySettings.set_shadowCascadesDelegate set_shadowCascadesDelegateField;

		// Token: 0x040007B2 RID: 1970
		private static readonly QualitySettings.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x040007B3 RID: 1971
		private static readonly QualitySettings.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x040007B4 RID: 1972
		private static readonly QualitySettings.get_shadowResolutionDelegate get_shadowResolutionDelegateField;

		// Token: 0x040007B5 RID: 1973
		private static readonly QualitySettings.set_shadowResolutionDelegate set_shadowResolutionDelegateField;

		// Token: 0x040007B6 RID: 1974
		private static readonly QualitySettings.set_shadowmaskModeDelegate set_shadowmaskModeDelegateField;

		// Token: 0x040007B7 RID: 1975
		private static readonly QualitySettings.get_shadowNearPlaneOffsetDelegate get_shadowNearPlaneOffsetDelegateField;

		// Token: 0x040007B8 RID: 1976
		private static readonly QualitySettings.set_shadowNearPlaneOffsetDelegate set_shadowNearPlaneOffsetDelegateField;

		// Token: 0x040007B9 RID: 1977
		private static readonly QualitySettings.get_shadowCascade2SplitDelegate get_shadowCascade2SplitDelegateField;

		// Token: 0x040007BA RID: 1978
		private static readonly QualitySettings.set_shadowCascade2SplitDelegate set_shadowCascade2SplitDelegateField;

		// Token: 0x040007BB RID: 1979
		private static readonly QualitySettings.get_lodBiasDelegate get_lodBiasDelegateField;

		// Token: 0x040007BC RID: 1980
		private static readonly QualitySettings.set_lodBiasDelegate set_lodBiasDelegateField;

		// Token: 0x040007BD RID: 1981
		private static readonly QualitySettings.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x040007BE RID: 1982
		private static readonly QualitySettings.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x040007BF RID: 1983
		private static readonly QualitySettings.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x040007C0 RID: 1984
		private static readonly QualitySettings.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x040007C1 RID: 1985
		private static readonly QualitySettings.get_globalTextureMipmapLimitDelegate get_globalTextureMipmapLimitDelegateField;

		// Token: 0x040007C2 RID: 1986
		private static readonly QualitySettings.set_globalTextureMipmapLimitDelegate set_globalTextureMipmapLimitDelegateField;

		// Token: 0x040007C3 RID: 1987
		private static readonly QualitySettings.get_maximumLODLevelDelegate get_maximumLODLevelDelegateField;

		// Token: 0x040007C4 RID: 1988
		private static readonly QualitySettings.set_maximumLODLevelDelegate set_maximumLODLevelDelegateField;

		// Token: 0x040007C5 RID: 1989
		private static readonly QualitySettings.get_enableLODCrossFadeDelegate get_enableLODCrossFadeDelegateField;

		// Token: 0x040007C6 RID: 1990
		private static readonly QualitySettings.get_particleRaycastBudgetDelegate get_particleRaycastBudgetDelegateField;

		// Token: 0x040007C7 RID: 1991
		private static readonly QualitySettings.set_particleRaycastBudgetDelegate set_particleRaycastBudgetDelegateField;

		// Token: 0x040007C8 RID: 1992
		private static readonly QualitySettings.get_softParticlesDelegate get_softParticlesDelegateField;

		// Token: 0x040007C9 RID: 1993
		private static readonly QualitySettings.set_softParticlesDelegate set_softParticlesDelegateField;

		// Token: 0x040007CA RID: 1994
		private static readonly QualitySettings.get_softVegetationDelegate get_softVegetationDelegateField;

		// Token: 0x040007CB RID: 1995
		private static readonly QualitySettings.set_softVegetationDelegate set_softVegetationDelegateField;

		// Token: 0x040007CC RID: 1996
		private static readonly QualitySettings.get_vSyncCountDelegate get_vSyncCountDelegateField;

		// Token: 0x040007CD RID: 1997
		private static readonly QualitySettings.get_realtimeGICPUUsageDelegate get_realtimeGICPUUsageDelegateField;

		// Token: 0x040007CE RID: 1998
		private static readonly QualitySettings.set_realtimeGICPUUsageDelegate set_realtimeGICPUUsageDelegateField;

		// Token: 0x040007CF RID: 1999
		private static readonly QualitySettings.get_asyncUploadTimeSliceDelegate get_asyncUploadTimeSliceDelegateField;

		// Token: 0x040007D0 RID: 2000
		private static readonly QualitySettings.set_asyncUploadTimeSliceDelegate set_asyncUploadTimeSliceDelegateField;

		// Token: 0x040007D1 RID: 2001
		private static readonly QualitySettings.get_asyncUploadBufferSizeDelegate get_asyncUploadBufferSizeDelegateField;

		// Token: 0x040007D2 RID: 2002
		private static readonly QualitySettings.set_asyncUploadBufferSizeDelegate set_asyncUploadBufferSizeDelegateField;

		// Token: 0x040007D3 RID: 2003
		private static readonly QualitySettings.get_asyncUploadPersistentBufferDelegate get_asyncUploadPersistentBufferDelegateField;

		// Token: 0x040007D4 RID: 2004
		private static readonly QualitySettings.set_asyncUploadPersistentBufferDelegate set_asyncUploadPersistentBufferDelegateField;

		// Token: 0x040007D5 RID: 2005
		private static readonly QualitySettings.SetLODSettingsDelegate SetLODSettingsDelegateField;

		// Token: 0x040007D6 RID: 2006
		private static readonly QualitySettings.get_realtimeReflectionProbesDelegate get_realtimeReflectionProbesDelegateField;

		// Token: 0x040007D7 RID: 2007
		private static readonly QualitySettings.set_realtimeReflectionProbesDelegate set_realtimeReflectionProbesDelegateField;

		// Token: 0x040007D8 RID: 2008
		private static readonly QualitySettings.set_billboardsFaceCameraPositionDelegate set_billboardsFaceCameraPositionDelegateField;

		// Token: 0x040007D9 RID: 2009
		private static readonly QualitySettings.get_useLegacyDetailDistributionDelegate get_useLegacyDetailDistributionDelegateField;

		// Token: 0x040007DA RID: 2010
		private static readonly QualitySettings.set_useLegacyDetailDistributionDelegate set_useLegacyDetailDistributionDelegateField;

		// Token: 0x040007DB RID: 2011
		private static readonly QualitySettings.get_resolutionScalingFixedDPIFactorDelegate get_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x040007DC RID: 2012
		private static readonly QualitySettings.set_resolutionScalingFixedDPIFactorDelegate set_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x040007DD RID: 2013
		private static readonly QualitySettings.get_terrainQualityOverridesDelegate get_terrainQualityOverridesDelegateField;

		// Token: 0x040007DE RID: 2014
		private static readonly QualitySettings.set_terrainQualityOverridesDelegate set_terrainQualityOverridesDelegateField;

		// Token: 0x040007DF RID: 2015
		private static readonly QualitySettings.get_terrainPixelErrorDelegate get_terrainPixelErrorDelegateField;

		// Token: 0x040007E0 RID: 2016
		private static readonly QualitySettings.set_terrainPixelErrorDelegate set_terrainPixelErrorDelegateField;

		// Token: 0x040007E1 RID: 2017
		private static readonly QualitySettings.get_terrainDetailDensityScaleDelegate get_terrainDetailDensityScaleDelegateField;

		// Token: 0x040007E2 RID: 2018
		private static readonly QualitySettings.set_terrainDetailDensityScaleDelegate set_terrainDetailDensityScaleDelegateField;

		// Token: 0x040007E3 RID: 2019
		private static readonly QualitySettings.get_terrainBasemapDistanceDelegate get_terrainBasemapDistanceDelegateField;

		// Token: 0x040007E4 RID: 2020
		private static readonly QualitySettings.set_terrainBasemapDistanceDelegate set_terrainBasemapDistanceDelegateField;

		// Token: 0x040007E5 RID: 2021
		private static readonly QualitySettings.get_terrainDetailDistanceDelegate get_terrainDetailDistanceDelegateField;

		// Token: 0x040007E6 RID: 2022
		private static readonly QualitySettings.set_terrainDetailDistanceDelegate set_terrainDetailDistanceDelegateField;

		// Token: 0x040007E7 RID: 2023
		private static readonly QualitySettings.get_terrainTreeDistanceDelegate get_terrainTreeDistanceDelegateField;

		// Token: 0x040007E8 RID: 2024
		private static readonly QualitySettings.set_terrainTreeDistanceDelegate set_terrainTreeDistanceDelegateField;

		// Token: 0x040007E9 RID: 2025
		private static readonly QualitySettings.get_terrainBillboardStartDelegate get_terrainBillboardStartDelegateField;

		// Token: 0x040007EA RID: 2026
		private static readonly QualitySettings.set_terrainBillboardStartDelegate set_terrainBillboardStartDelegateField;

		// Token: 0x040007EB RID: 2027
		private static readonly QualitySettings.get_terrainFadeLengthDelegate get_terrainFadeLengthDelegateField;

		// Token: 0x040007EC RID: 2028
		private static readonly QualitySettings.set_terrainFadeLengthDelegate set_terrainFadeLengthDelegateField;

		// Token: 0x040007ED RID: 2029
		private static readonly QualitySettings.get_terrainMaxTreesDelegate get_terrainMaxTreesDelegateField;

		// Token: 0x040007EE RID: 2030
		private static readonly QualitySettings.set_terrainMaxTreesDelegate set_terrainMaxTreesDelegateField;

		// Token: 0x040007EF RID: 2031
		private static readonly QualitySettings.get_INTERNAL_renderPipelineDelegate get_INTERNAL_renderPipelineDelegateField;

		// Token: 0x040007F0 RID: 2032
		private static readonly QualitySettings.set_INTERNAL_renderPipelineDelegate set_INTERNAL_renderPipelineDelegateField;

		// Token: 0x040007F1 RID: 2033
		private static readonly QualitySettings.InternalGetRenderPipelineAssetAtDelegate InternalGetRenderPipelineAssetAtDelegateField;

		// Token: 0x040007F2 RID: 2034
		private static readonly QualitySettings.get_blendWeightsDelegate get_blendWeightsDelegateField;

		// Token: 0x040007F3 RID: 2035
		private static readonly QualitySettings.set_blendWeightsDelegate set_blendWeightsDelegateField;

		// Token: 0x040007F4 RID: 2036
		private static readonly QualitySettings.get_skinWeightsDelegate get_skinWeightsDelegateField;

		// Token: 0x040007F5 RID: 2037
		private static readonly QualitySettings.set_skinWeightsDelegate set_skinWeightsDelegateField;

		// Token: 0x040007F6 RID: 2038
		private static readonly QualitySettings.get_countDelegate get_countDelegateField;

		// Token: 0x040007F7 RID: 2039
		private static readonly QualitySettings.get_streamingMipmapsActiveDelegate get_streamingMipmapsActiveDelegateField;

		// Token: 0x040007F8 RID: 2040
		private static readonly QualitySettings.set_streamingMipmapsActiveDelegate set_streamingMipmapsActiveDelegateField;

		// Token: 0x040007F9 RID: 2041
		private static readonly QualitySettings.get_streamingMipmapsMemoryBudgetDelegate get_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x040007FA RID: 2042
		private static readonly QualitySettings.set_streamingMipmapsMemoryBudgetDelegate set_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x040007FB RID: 2043
		private static readonly QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate get_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x040007FC RID: 2044
		private static readonly QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate set_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x040007FD RID: 2045
		private static readonly QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate get_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x040007FE RID: 2046
		private static readonly QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate set_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x040007FF RID: 2047
		private static readonly QualitySettings.get_streamingMipmapsAddAllCamerasDelegate get_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000800 RID: 2048
		private static readonly QualitySettings.set_streamingMipmapsAddAllCamerasDelegate set_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000801 RID: 2049
		private static readonly QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate get_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x04000802 RID: 2050
		private static readonly QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate set_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x04000803 RID: 2051
		private static readonly QualitySettings.get_maxQueuedFramesDelegate get_maxQueuedFramesDelegateField;

		// Token: 0x04000804 RID: 2052
		private static readonly QualitySettings.set_maxQueuedFramesDelegate set_maxQueuedFramesDelegateField;

		// Token: 0x04000805 RID: 2053
		private static readonly QualitySettings.GetQualitySettingsDelegate GetQualitySettingsDelegateField;

		// Token: 0x04000806 RID: 2054
		private static readonly QualitySettings.get_namesDelegate get_namesDelegateField;

		// Token: 0x04000807 RID: 2055
		private static readonly QualitySettings.get_shadowCascade4Split_InjectedDelegate get_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x04000808 RID: 2056
		private static readonly QualitySettings.set_shadowCascade4Split_InjectedDelegate set_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x02000520 RID: 1312
		// (Invoke) Token: 0x06003351 RID: 13137
		private delegate ShadowQuality get_shadowsDelegate();

		// Token: 0x02000521 RID: 1313
		// (Invoke) Token: 0x06003353 RID: 13139
		private delegate void set_shadowsDelegate(ShadowQuality value);

		// Token: 0x02000522 RID: 1314
		// (Invoke) Token: 0x06003355 RID: 13141
		private delegate ShadowProjection get_shadowProjectionDelegate();

		// Token: 0x02000523 RID: 1315
		// (Invoke) Token: 0x06003357 RID: 13143
		private delegate void set_shadowProjectionDelegate(ShadowProjection value);

		// Token: 0x02000524 RID: 1316
		// (Invoke) Token: 0x06003359 RID: 13145
		private delegate int get_shadowCascadesDelegate();

		// Token: 0x02000525 RID: 1317
		// (Invoke) Token: 0x0600335B RID: 13147
		private delegate void set_shadowCascadesDelegate(int value);

		// Token: 0x02000526 RID: 1318
		// (Invoke) Token: 0x0600335D RID: 13149
		private delegate float get_shadowDistanceDelegate();

		// Token: 0x02000527 RID: 1319
		// (Invoke) Token: 0x0600335F RID: 13151
		private delegate void set_shadowDistanceDelegate(float value);

		// Token: 0x02000528 RID: 1320
		// (Invoke) Token: 0x06003361 RID: 13153
		private delegate ShadowResolution get_shadowResolutionDelegate();

		// Token: 0x02000529 RID: 1321
		// (Invoke) Token: 0x06003363 RID: 13155
		private delegate void set_shadowResolutionDelegate(ShadowResolution value);

		// Token: 0x0200052A RID: 1322
		// (Invoke) Token: 0x06003365 RID: 13157
		private delegate void set_shadowmaskModeDelegate(ShadowmaskMode value);

		// Token: 0x0200052B RID: 1323
		// (Invoke) Token: 0x06003367 RID: 13159
		private delegate float get_shadowNearPlaneOffsetDelegate();

		// Token: 0x0200052C RID: 1324
		// (Invoke) Token: 0x06003369 RID: 13161
		private delegate void set_shadowNearPlaneOffsetDelegate(float value);

		// Token: 0x0200052D RID: 1325
		// (Invoke) Token: 0x0600336B RID: 13163
		private delegate float get_shadowCascade2SplitDelegate();

		// Token: 0x0200052E RID: 1326
		// (Invoke) Token: 0x0600336D RID: 13165
		private delegate void set_shadowCascade2SplitDelegate(float value);

		// Token: 0x0200052F RID: 1327
		// (Invoke) Token: 0x0600336F RID: 13167
		private delegate float get_lodBiasDelegate();

		// Token: 0x02000530 RID: 1328
		// (Invoke) Token: 0x06003371 RID: 13169
		private delegate void set_lodBiasDelegate(float value);

		// Token: 0x02000531 RID: 1329
		// (Invoke) Token: 0x06003373 RID: 13171
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x02000532 RID: 1330
		// (Invoke) Token: 0x06003375 RID: 13173
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x02000533 RID: 1331
		// (Invoke) Token: 0x06003377 RID: 13175
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x02000534 RID: 1332
		// (Invoke) Token: 0x06003379 RID: 13177
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x02000535 RID: 1333
		// (Invoke) Token: 0x0600337B RID: 13179
		private delegate int get_globalTextureMipmapLimitDelegate();

		// Token: 0x02000536 RID: 1334
		// (Invoke) Token: 0x0600337D RID: 13181
		private delegate void set_globalTextureMipmapLimitDelegate(int value);

		// Token: 0x02000537 RID: 1335
		// (Invoke) Token: 0x0600337F RID: 13183
		private delegate int get_maximumLODLevelDelegate();

		// Token: 0x02000538 RID: 1336
		// (Invoke) Token: 0x06003381 RID: 13185
		private delegate void set_maximumLODLevelDelegate(int value);

		// Token: 0x02000539 RID: 1337
		// (Invoke) Token: 0x06003383 RID: 13187
		private delegate bool get_enableLODCrossFadeDelegate();

		// Token: 0x0200053A RID: 1338
		// (Invoke) Token: 0x06003385 RID: 13189
		private delegate int get_particleRaycastBudgetDelegate();

		// Token: 0x0200053B RID: 1339
		// (Invoke) Token: 0x06003387 RID: 13191
		private delegate void set_particleRaycastBudgetDelegate(int value);

		// Token: 0x0200053C RID: 1340
		// (Invoke) Token: 0x06003389 RID: 13193
		private delegate bool get_softParticlesDelegate();

		// Token: 0x0200053D RID: 1341
		// (Invoke) Token: 0x0600338B RID: 13195
		private delegate void set_softParticlesDelegate(bool value);

		// Token: 0x0200053E RID: 1342
		// (Invoke) Token: 0x0600338D RID: 13197
		private delegate bool get_softVegetationDelegate();

		// Token: 0x0200053F RID: 1343
		// (Invoke) Token: 0x0600338F RID: 13199
		private delegate void set_softVegetationDelegate(bool value);

		// Token: 0x02000540 RID: 1344
		// (Invoke) Token: 0x06003391 RID: 13201
		private delegate int get_vSyncCountDelegate();

		// Token: 0x02000541 RID: 1345
		// (Invoke) Token: 0x06003393 RID: 13203
		private delegate int get_realtimeGICPUUsageDelegate();

		// Token: 0x02000542 RID: 1346
		// (Invoke) Token: 0x06003395 RID: 13205
		private delegate void set_realtimeGICPUUsageDelegate(int value);

		// Token: 0x02000543 RID: 1347
		// (Invoke) Token: 0x06003397 RID: 13207
		private delegate int get_asyncUploadTimeSliceDelegate();

		// Token: 0x02000544 RID: 1348
		// (Invoke) Token: 0x06003399 RID: 13209
		private delegate void set_asyncUploadTimeSliceDelegate(int value);

		// Token: 0x02000545 RID: 1349
		// (Invoke) Token: 0x0600339B RID: 13211
		private delegate int get_asyncUploadBufferSizeDelegate();

		// Token: 0x02000546 RID: 1350
		// (Invoke) Token: 0x0600339D RID: 13213
		private delegate void set_asyncUploadBufferSizeDelegate(int value);

		// Token: 0x02000547 RID: 1351
		// (Invoke) Token: 0x0600339F RID: 13215
		private delegate bool get_asyncUploadPersistentBufferDelegate();

		// Token: 0x02000548 RID: 1352
		// (Invoke) Token: 0x060033A1 RID: 13217
		private delegate void set_asyncUploadPersistentBufferDelegate(bool value);

		// Token: 0x02000549 RID: 1353
		// (Invoke) Token: 0x060033A3 RID: 13219
		private delegate void SetLODSettingsDelegate(float lodBias, int maximumLODLevel, bool setDirty);

		// Token: 0x0200054A RID: 1354
		// (Invoke) Token: 0x060033A5 RID: 13221
		private delegate bool get_realtimeReflectionProbesDelegate();

		// Token: 0x0200054B RID: 1355
		// (Invoke) Token: 0x060033A7 RID: 13223
		private delegate void set_realtimeReflectionProbesDelegate(bool value);

		// Token: 0x0200054C RID: 1356
		// (Invoke) Token: 0x060033A9 RID: 13225
		private delegate void set_billboardsFaceCameraPositionDelegate(bool value);

		// Token: 0x0200054D RID: 1357
		// (Invoke) Token: 0x060033AB RID: 13227
		private delegate bool get_useLegacyDetailDistributionDelegate();

		// Token: 0x0200054E RID: 1358
		// (Invoke) Token: 0x060033AD RID: 13229
		private delegate void set_useLegacyDetailDistributionDelegate(bool value);

		// Token: 0x0200054F RID: 1359
		// (Invoke) Token: 0x060033AF RID: 13231
		private delegate float get_resolutionScalingFixedDPIFactorDelegate();

		// Token: 0x02000550 RID: 1360
		// (Invoke) Token: 0x060033B1 RID: 13233
		private delegate void set_resolutionScalingFixedDPIFactorDelegate(float value);

		// Token: 0x02000551 RID: 1361
		// (Invoke) Token: 0x060033B3 RID: 13235
		private delegate TerrainQualityOverrides get_terrainQualityOverridesDelegate();

		// Token: 0x02000552 RID: 1362
		// (Invoke) Token: 0x060033B5 RID: 13237
		private delegate void set_terrainQualityOverridesDelegate(TerrainQualityOverrides value);

		// Token: 0x02000553 RID: 1363
		// (Invoke) Token: 0x060033B7 RID: 13239
		private delegate float get_terrainPixelErrorDelegate();

		// Token: 0x02000554 RID: 1364
		// (Invoke) Token: 0x060033B9 RID: 13241
		private delegate void set_terrainPixelErrorDelegate(float value);

		// Token: 0x02000555 RID: 1365
		// (Invoke) Token: 0x060033BB RID: 13243
		private delegate float get_terrainDetailDensityScaleDelegate();

		// Token: 0x02000556 RID: 1366
		// (Invoke) Token: 0x060033BD RID: 13245
		private delegate void set_terrainDetailDensityScaleDelegate(float value);

		// Token: 0x02000557 RID: 1367
		// (Invoke) Token: 0x060033BF RID: 13247
		private delegate float get_terrainBasemapDistanceDelegate();

		// Token: 0x02000558 RID: 1368
		// (Invoke) Token: 0x060033C1 RID: 13249
		private delegate void set_terrainBasemapDistanceDelegate(float value);

		// Token: 0x02000559 RID: 1369
		// (Invoke) Token: 0x060033C3 RID: 13251
		private delegate float get_terrainDetailDistanceDelegate();

		// Token: 0x0200055A RID: 1370
		// (Invoke) Token: 0x060033C5 RID: 13253
		private delegate void set_terrainDetailDistanceDelegate(float value);

		// Token: 0x0200055B RID: 1371
		// (Invoke) Token: 0x060033C7 RID: 13255
		private delegate float get_terrainTreeDistanceDelegate();

		// Token: 0x0200055C RID: 1372
		// (Invoke) Token: 0x060033C9 RID: 13257
		private delegate void set_terrainTreeDistanceDelegate(float value);

		// Token: 0x0200055D RID: 1373
		// (Invoke) Token: 0x060033CB RID: 13259
		private delegate float get_terrainBillboardStartDelegate();

		// Token: 0x0200055E RID: 1374
		// (Invoke) Token: 0x060033CD RID: 13261
		private delegate void set_terrainBillboardStartDelegate(float value);

		// Token: 0x0200055F RID: 1375
		// (Invoke) Token: 0x060033CF RID: 13263
		private delegate float get_terrainFadeLengthDelegate();

		// Token: 0x02000560 RID: 1376
		// (Invoke) Token: 0x060033D1 RID: 13265
		private delegate void set_terrainFadeLengthDelegate(float value);

		// Token: 0x02000561 RID: 1377
		// (Invoke) Token: 0x060033D3 RID: 13267
		private delegate float get_terrainMaxTreesDelegate();

		// Token: 0x02000562 RID: 1378
		// (Invoke) Token: 0x060033D5 RID: 13269
		private delegate void set_terrainMaxTreesDelegate(float value);

		// Token: 0x02000563 RID: 1379
		// (Invoke) Token: 0x060033D7 RID: 13271
		private delegate IntPtr get_INTERNAL_renderPipelineDelegate();

		// Token: 0x02000564 RID: 1380
		// (Invoke) Token: 0x060033D9 RID: 13273
		private delegate void set_INTERNAL_renderPipelineDelegate(IntPtr value);

		// Token: 0x02000565 RID: 1381
		// (Invoke) Token: 0x060033DB RID: 13275
		private delegate IntPtr InternalGetRenderPipelineAssetAtDelegate(int index);

		// Token: 0x02000566 RID: 1382
		// (Invoke) Token: 0x060033DD RID: 13277
		private delegate BlendWeights get_blendWeightsDelegate();

		// Token: 0x02000567 RID: 1383
		// (Invoke) Token: 0x060033DF RID: 13279
		private delegate void set_blendWeightsDelegate(BlendWeights value);

		// Token: 0x02000568 RID: 1384
		// (Invoke) Token: 0x060033E1 RID: 13281
		private delegate SkinWeights get_skinWeightsDelegate();

		// Token: 0x02000569 RID: 1385
		// (Invoke) Token: 0x060033E3 RID: 13283
		private delegate void set_skinWeightsDelegate(SkinWeights value);

		// Token: 0x0200056A RID: 1386
		// (Invoke) Token: 0x060033E5 RID: 13285
		private delegate int get_countDelegate();

		// Token: 0x0200056B RID: 1387
		// (Invoke) Token: 0x060033E7 RID: 13287
		private delegate bool get_streamingMipmapsActiveDelegate();

		// Token: 0x0200056C RID: 1388
		// (Invoke) Token: 0x060033E9 RID: 13289
		private delegate void set_streamingMipmapsActiveDelegate(bool value);

		// Token: 0x0200056D RID: 1389
		// (Invoke) Token: 0x060033EB RID: 13291
		private delegate float get_streamingMipmapsMemoryBudgetDelegate();

		// Token: 0x0200056E RID: 1390
		// (Invoke) Token: 0x060033ED RID: 13293
		private delegate void set_streamingMipmapsMemoryBudgetDelegate(float value);

		// Token: 0x0200056F RID: 1391
		// (Invoke) Token: 0x060033EF RID: 13295
		private delegate int get_streamingMipmapsRenderersPerFrameDelegate();

		// Token: 0x02000570 RID: 1392
		// (Invoke) Token: 0x060033F1 RID: 13297
		private delegate void set_streamingMipmapsRenderersPerFrameDelegate(int value);

		// Token: 0x02000571 RID: 1393
		// (Invoke) Token: 0x060033F3 RID: 13299
		private delegate int get_streamingMipmapsMaxLevelReductionDelegate();

		// Token: 0x02000572 RID: 1394
		// (Invoke) Token: 0x060033F5 RID: 13301
		private delegate void set_streamingMipmapsMaxLevelReductionDelegate(int value);

		// Token: 0x02000573 RID: 1395
		// (Invoke) Token: 0x060033F7 RID: 13303
		private delegate bool get_streamingMipmapsAddAllCamerasDelegate();

		// Token: 0x02000574 RID: 1396
		// (Invoke) Token: 0x060033F9 RID: 13305
		private delegate void set_streamingMipmapsAddAllCamerasDelegate(bool value);

		// Token: 0x02000575 RID: 1397
		// (Invoke) Token: 0x060033FB RID: 13307
		private delegate int get_streamingMipmapsMaxFileIORequestsDelegate();

		// Token: 0x02000576 RID: 1398
		// (Invoke) Token: 0x060033FD RID: 13309
		private delegate void set_streamingMipmapsMaxFileIORequestsDelegate(int value);

		// Token: 0x02000577 RID: 1399
		// (Invoke) Token: 0x060033FF RID: 13311
		private delegate int get_maxQueuedFramesDelegate();

		// Token: 0x02000578 RID: 1400
		// (Invoke) Token: 0x06003401 RID: 13313
		private delegate void set_maxQueuedFramesDelegate(int value);

		// Token: 0x02000579 RID: 1401
		// (Invoke) Token: 0x06003403 RID: 13315
		private delegate IntPtr GetQualitySettingsDelegate();

		// Token: 0x0200057A RID: 1402
		// (Invoke) Token: 0x06003405 RID: 13317
		private delegate IntPtr get_namesDelegate();

		// Token: 0x0200057B RID: 1403
		// (Invoke) Token: 0x06003407 RID: 13319
		private delegate void get_shadowCascade4Split_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200057C RID: 1404
		// (Invoke) Token: 0x06003409 RID: 13321
		private delegate void set_shadowCascade4Split_InjectedDelegate(IntPtr value);
	}
}
