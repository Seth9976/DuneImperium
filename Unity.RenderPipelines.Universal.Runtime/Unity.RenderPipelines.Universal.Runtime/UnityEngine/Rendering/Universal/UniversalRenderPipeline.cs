using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000F4 RID: 244
	public sealed class UniversalRenderPipeline : RenderPipeline
	{
		// Token: 0x06001335 RID: 4917 RVA: 0x000578C8 File Offset: 0x00055AC8
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalRenderPipeline()
		{
			Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr);
			UniversalRenderPipeline.NativeFieldInfoPtr_k_ShaderTagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_ShaderTagName");
			UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultRenderingLayerMask");
			UniversalRenderPipeline.NativeFieldInfoPtr_m_DebugDisplaySettingsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_DebugDisplaySettingsUI");
			UniversalRenderPipeline.NativeFieldInfoPtr_m_GlobalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_GlobalSettings");
			UniversalRenderPipeline.NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "cameraStackRequiresDepthForPostprocessing");
			UniversalRenderPipeline.NativeFieldInfoPtr_s_RenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "s_RenderGraph");
			UniversalRenderPipeline.NativeFieldInfoPtr_s_RTHandlePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "s_RTHandlePool");
			UniversalRenderPipeline.NativeFieldInfoPtr_useRenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "useRenderGraph");
			UniversalRenderPipeline.NativeFieldInfoPtr_pipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "pipelineAsset");
			UniversalRenderPipeline.NativeFieldInfoPtr_enableHDROnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "enableHDROnce");
			UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightPosition");
			UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightColor");
			UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightAttenuation");
			UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightSpotDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightSpotDirection");
			UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightsProbeChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightsProbeChannel");
			UniversalRenderPipeline.NativeFieldInfoPtr_m_ShadowBiasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_ShadowBiasData");
			UniversalRenderPipeline.NativeFieldInfoPtr_m_ShadowResolutionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_ShadowResolutionData");
			UniversalRenderPipeline.NativeFieldInfoPtr_cameraComparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "cameraComparison");
			UniversalRenderPipeline.NativeFieldInfoPtr_lightsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "lightsDelegate");
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxShadowBias_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665688);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_minRenderScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665689);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxRenderScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665690);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxNumIterationsEnclosingSphere_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665691);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxPerObjectLights_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665692);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxVisibleAdditionalLights_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665693);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_lightsPerTile_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665694);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxZBinWords_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665695);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxTileWords_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665696);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_maxVisibleReflectionProbes_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665697);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_get_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665698);
			UniversalRenderPipeline.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665699);
			UniversalRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665700);
			UniversalRenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665701);
			UniversalRenderPipeline.NativeMethodInfoPtr_DisposeAdditionalCameraData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665702);
			UniversalRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665703);
			UniversalRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665704);
			UniversalRenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665705);
			UniversalRenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665706);
			UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCamera_Public_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665707);
			UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665708);
			UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_byref_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665709);
			UniversalRenderPipeline.NativeMethodInfoPtr_TryGetCullingParameters_Private_Static_Boolean_CameraData_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665710);
			UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCamera_Private_Static_Void_ScriptableRenderContext_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665711);
			UniversalRenderPipeline.NativeMethodInfoPtr_RenderCameraStack_Private_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665712);
			UniversalRenderPipeline.NativeMethodInfoPtr_UpdateCameraData_Private_Static_Void_byref_CameraData_byref_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665713);
			UniversalRenderPipeline.NativeMethodInfoPtr_UpdateVolumeFramework_Private_Static_Void_Camera_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665714);
			UniversalRenderPipeline.NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665715);
			UniversalRenderPipeline.NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665716);
			UniversalRenderPipeline.NativeMethodInfoPtr_SetSupportedRenderingFeatures_Private_Static_Void_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665717);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializeCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665718);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializeStackedCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665719);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializeAdditionalCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665720);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializeRenderingData_Private_Static_Void_UniversalRenderPipelineAsset_byref_CameraData_byref_CullingResults_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665721);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializeShadowData_Private_Static_Void_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_Boolean_Boolean_Boolean_byref_ShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665722);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializePostProcessingData_Private_Static_Void_UniversalRenderPipelineAsset_Boolean_byref_PostProcessingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665723);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializeLightData_Private_Static_Void_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_Int32_byref_LightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665724);
			UniversalRenderPipeline.NativeMethodInfoPtr_ApplyTaaRenderingDebugOverrides_Private_Static_Void_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665725);
			UniversalRenderPipeline.NativeMethodInfoPtr_UpdateTemporalAAData_Private_Static_Void_byref_CameraData_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665726);
			UniversalRenderPipeline.NativeMethodInfoPtr_UpdateTemporalAATargets_Private_Static_Void_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665727);
			UniversalRenderPipeline.NativeMethodInfoPtr_UpdateCameraStereoMatrices_Private_Static_Void_Camera_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665728);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetPerObjectLightFlags_Private_Static_PerObjectData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665729);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetMainLightIndex_Private_Static_Int32_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665730);
			UniversalRenderPipeline.NativeMethodInfoPtr_SetupPerFrameShaderConstants_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665731);
			UniversalRenderPipeline.NativeMethodInfoPtr_SetupPerCameraShaderConstants_Private_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665732);
			UniversalRenderPipeline.NativeMethodInfoPtr_CheckAndApplyDebugSettings_Private_Static_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665733);
			UniversalRenderPipeline.NativeMethodInfoPtr_ResolveUpscalingFilterSelection_Private_Static_ImageUpscalingFilter_Vector2_Single_UpscalingFilterSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665734);
			UniversalRenderPipeline.NativeMethodInfoPtr_HDROutputForMainDisplayIsActive_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665735);
			UniversalRenderPipeline.NativeMethodInfoPtr_HDROutputForAnyDisplayIsActive_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665736);
			UniversalRenderPipeline.NativeMethodInfoPtr_SetHDRState_Private_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665737);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetHDROutputLuminanceParameters_Internal_Static_Void_HDRDisplayInformation_ColorGamut_Tonemapping_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665738);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetHDROutputGradingParameters_Internal_Static_Void_Tonemapping_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665739);
			UniversalRenderPipeline.NativeMethodInfoPtr_IsGameCamera_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665740);
			UniversalRenderPipeline.NativeMethodInfoPtr_IsStereoEnabled_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665741);
			UniversalRenderPipeline.NativeMethodInfoPtr_get_asset_Public_Static_get_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665742);
			UniversalRenderPipeline.NativeMethodInfoPtr_SortCameras_Private_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665743);
			UniversalRenderPipeline.NativeMethodInfoPtr_MakeRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_Boolean_HDRColorBufferPrecision_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665744);
			UniversalRenderPipeline.NativeMethodInfoPtr_MakeUnormRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665745);
			UniversalRenderPipeline.NativeMethodInfoPtr_CreateRenderTextureDescriptor_Internal_Static_RenderTextureDescriptor_Camera_byref_CameraData_Boolean_HDRColorBufferPrecision_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665746);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetLightAttenuationAndSpotDirection_Public_Static_Void_LightType_Single_Matrix4x4_Single_Nullable_1_Single_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665747);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetPunctualLightDistanceAttenuation_Internal_Static_Void_Single_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665748);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetSpotAngleAttenuation_Internal_Static_Void_Single_Nullable_1_Single_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665749);
			UniversalRenderPipeline.NativeMethodInfoPtr_GetSpotDirection_Internal_Static_Void_byref_Matrix4x4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665750);
			UniversalRenderPipeline.NativeMethodInfoPtr_InitializeLightConstants_Common_Public_Static_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665751);
			UniversalRenderPipeline.NativeMethodInfoPtr_RecordRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665752);
			UniversalRenderPipeline.NativeMethodInfoPtr_RecordAndExecuteRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665753);
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00057F9C File Offset: 0x0005619C
		public unsafe static float maxShadowBias
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 620595, RefRangeEnd = 620598, XrefRangeStart = 620595, XrefRangeEnd = 620595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxShadowBias_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00057FCC File Offset: 0x000561CC
		public unsafe static float minRenderScale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 620598, RefRangeEnd = 620600, XrefRangeStart = 620598, XrefRangeEnd = 620598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_minRenderScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00057FFC File Offset: 0x000561FC
		public unsafe static float maxRenderScale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 620600, RefRangeEnd = 620602, XrefRangeStart = 620600, XrefRangeEnd = 620600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxRenderScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0005802C File Offset: 0x0005622C
		public unsafe static int maxNumIterationsEnclosingSphere
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxNumIterationsEnclosingSphere_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0005805C File Offset: 0x0005625C
		public unsafe static int maxPerObjectLights
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 620603, RefRangeEnd = 620605, XrefRangeStart = 620602, XrefRangeEnd = 620603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxPerObjectLights_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0005808C File Offset: 0x0005628C
		public unsafe static int maxVisibleAdditionalLights
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 620612, RefRangeEnd = 620625, XrefRangeStart = 620605, XrefRangeEnd = 620612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxVisibleAdditionalLights_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000580BC File Offset: 0x000562BC
		public unsafe static int lightsPerTile
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620625, XrefRangeEnd = 620629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_lightsPerTile_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x000580EC File Offset: 0x000562EC
		public unsafe static int maxZBinWords
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 620629, RefRangeEnd = 620634, XrefRangeStart = 620629, XrefRangeEnd = 620629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxZBinWords_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0005811C File Offset: 0x0005631C
		public unsafe static int maxTileWords
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 620638, RefRangeEnd = 620643, XrefRangeStart = 620634, XrefRangeEnd = 620638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxTileWords_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x0005814C File Offset: 0x0005634C
		public unsafe static int maxVisibleReflectionProbes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 620651, RefRangeEnd = 620654, XrefRangeStart = 620643, XrefRangeEnd = 620651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_maxVisibleReflectionProbes_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x0005817C File Offset: 0x0005637C
		public unsafe override RenderPipelineGlobalSettings defaultSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_get_RenderPipelineGlobalSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000581BC File Offset: 0x000563BC
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000581F4 File Offset: 0x000563F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 620787, RefRangeEnd = 620788, XrefRangeStart = 620654, XrefRangeEnd = 620787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRenderPipeline(UniversalRenderPipelineAsset asset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_UniversalRenderPipelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00058240 File Offset: 0x00056440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620788, XrefRangeEnd = 620841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00058280 File Offset: 0x00056480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620841, XrefRangeEnd = 620847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeAdditionalCameraData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_DisposeAdditionalCameraData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000582B4 File Offset: 0x000564B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620847, XrefRangeEnd = 620853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(ScriptableRenderContext renderContext, Il2CppReferenceArray<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00058304 File Offset: 0x00056504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620853, XrefRangeEnd = 620983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(ScriptableRenderContext renderContext, List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00058354 File Offset: 0x00056554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620983, XrefRangeEnd = 620987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = data;
				intPtr = ((requestData is string) ? IL2CPP.ManagedStringToIl2Cpp(requestData as string) : IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref data;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.MethodInfoStoreGeneric_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x000583EC File Offset: 0x000565EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620987, XrefRangeEnd = 621094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = renderRequest;
				intPtr = ((requestData is string) ? IL2CPP.ManagedStringToIl2Cpp(requestData as string) : IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref renderRequest;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00058484 File Offset: 0x00056684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621094, XrefRangeEnd = 621098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderSingleCamera(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCamera_Public_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000584C8 File Offset: 0x000566C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 621126, RefRangeEnd = 621128, XrefRangeStart = 621098, XrefRangeEnd = 621126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0005850C File Offset: 0x0005670C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 621146, RefRangeEnd = 621147, XrefRangeStart = 621128, XrefRangeEnd = 621146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(additionalCameraData);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_byref_UniversalAdditionalCameraData_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			additionalCameraData = ((intPtr4 == 0) ? null : new UniversalAdditionalCameraData(intPtr4));
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00058578 File Offset: 0x00056778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621147, XrefRangeEnd = 621151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cullingParams;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_TryGetCullingParameters_Private_Static_Boolean_CameraData_byref_ScriptableCullingParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000585CC File Offset: 0x000567CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 621173, RefRangeEnd = 621177, XrefRangeStart = 621151, XrefRangeEnd = 621173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderSingleCamera(ScriptableRenderContext context, ref CameraData cameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_RenderSingleCamera_Private_Static_Void_ScriptableRenderContext_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00058614 File Offset: 0x00056814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 621444, RefRangeEnd = 621445, XrefRangeStart = 621177, XrefRangeEnd = 621444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_RenderCameraStack_Private_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00058658 File Offset: 0x00056858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 621457, RefRangeEnd = 621458, XrefRangeStart = 621445, XrefRangeEnd = 621457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateCameraData(ref CameraData baseCameraData, [In] ref XRPass xr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(baseCameraData);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(xr);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_UpdateCameraData_Private_Static_Void_byref_CameraData_byref_XRPass_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			xr = ((intPtr4 == 0) ? null : new XRPass(intPtr4));
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000586B8 File Offset: 0x000568B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 621494, RefRangeEnd = 621497, XrefRangeStart = 621458, XrefRangeEnd = 621494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_UpdateVolumeFramework_Private_Static_Void_Camera_UniversalAdditionalCameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00058700 File Offset: 0x00056900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621497, XrefRangeEnd = 621502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckPostProcessForDepth(ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00058744 File Offset: 0x00056944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 621514, RefRangeEnd = 621517, XrefRangeStart = 621502, XrefRangeEnd = 621514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckPostProcessForDepth()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00058774 File Offset: 0x00056974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621517, XrefRangeEnd = 621521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_SetSupportedRenderingFeatures_Private_Static_Void_UniversalRenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x000587AC File Offset: 0x000569AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 621581, RefRangeEnd = 621584, XrefRangeStart = 621521, XrefRangeEnd = 621581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, out CameraData cameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolveFinalTarget;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializeCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_byref_CameraData_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cameraData = ((intPtr4 == 0) ? null : new CameraData(intPtr4));
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00058824 File Offset: 0x00056A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 621671, RefRangeEnd = 621672, XrefRangeStart = 621584, XrefRangeEnd = 621671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, ref CameraData cameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCamera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAdditionalCameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializeStackedCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00058880 File Offset: 0x00056A80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 621762, RefRangeEnd = 621766, XrefRangeStart = 621672, XrefRangeEnd = 621762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref CameraData cameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolveFinalTarget;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializeAdditionalCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000588EC File Offset: 0x00056AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621766, XrefRangeEnd = 621814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeRenderingData(UniversalRenderPipelineAsset settings, ref CameraData cameraData, ref CullingResults cullResults, CommandBuffer cmd, out RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cullResults;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializeRenderingData_Private_Static_Void_UniversalRenderPipelineAsset_byref_CameraData_byref_CullingResults_CommandBuffer_byref_RenderingData_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			renderingData = ((intPtr4 == 0) ? null : new RenderingData(intPtr4));
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00058978 File Offset: 0x00056B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 621916, RefRangeEnd = 621917, XrefRangeStart = 621814, XrefRangeEnd = 621916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeShadowData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, bool isForwardPlus, out ShadowData shadowData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(visibleLights));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainLightCastShadows;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalLightsCastShadows;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForwardPlus;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializeShadowData_Private_Static_Void_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_Boolean_Boolean_Boolean_byref_ShadowData_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			shadowData = ((intPtr4 == 0) ? null : new ShadowData(intPtr4));
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00058A14 File Offset: 0x00056C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621917, XrefRangeEnd = 621918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializePostProcessingData(UniversalRenderPipelineAsset settings, bool isHDROutputActive, out PostProcessingData postProcessingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHDROutputActive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &postProcessingData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializePostProcessingData_Private_Static_Void_UniversalRenderPipelineAsset_Boolean_byref_PostProcessingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00058A68 File Offset: 0x00056C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 621943, RefRangeEnd = 621944, XrefRangeStart = 621918, XrefRangeEnd = 621943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeLightData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, int mainLightIndex, out LightData lightData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(visibleLights));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainLightIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializeLightData_Private_Static_Void_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_Int32_byref_LightData_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lightData = ((intPtr4 == 0) ? null : new LightData(intPtr4));
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00058AE4 File Offset: 0x00056CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621944, XrefRangeEnd = 621950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyTaaRenderingDebugOverrides(ref TemporalAA.Settings taaSettings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &taaSettings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_ApplyTaaRenderingDebugOverrides_Private_Static_Void_byref_Settings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00058B18 File Offset: 0x00056D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621950, XrefRangeEnd = 621954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateTemporalAAData(ref CameraData cameraData, UniversalAdditionalCameraData additionalCameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_UpdateTemporalAAData_Private_Static_Void_byref_CameraData_UniversalAdditionalCameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00058B64 File Offset: 0x00056D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 621954, XrefRangeEnd = 621956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateTemporalAATargets(ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_UpdateTemporalAATargets_Private_Static_Void_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00058B9C File Offset: 0x00056D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 621962, RefRangeEnd = 621964, XrefRangeStart = 621956, XrefRangeEnd = 621962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateCameraStereoMatrices(Camera camera, XRPass xr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_UpdateCameraStereoMatrices_Private_Static_Void_Camera_XRPass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00058BE4 File Offset: 0x00056DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 621976, RefRangeEnd = 621977, XrefRangeStart = 621964, XrefRangeEnd = 621976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref additionalLightsCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForwardPlus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetPerObjectLightFlags_Private_Static_PerObjectData_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00058C30 File Offset: 0x00056E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622005, RefRangeEnd = 622006, XrefRangeStart = 621977, XrefRangeEnd = 622005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(visibleLights));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetMainLightIndex_Private_Static_Int32_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00058C88 File Offset: 0x00056E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622052, RefRangeEnd = 622053, XrefRangeStart = 622006, XrefRangeEnd = 622052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupPerFrameShaderConstants()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_SetupPerFrameShaderConstants_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00058CB0 File Offset: 0x00056EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622053, XrefRangeEnd = 622101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupPerCameraShaderConstants(CommandBuffer cmd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_SetupPerCameraShaderConstants_Private_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00058CE8 File Offset: 0x00056EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622128, RefRangeEnd = 622129, XrefRangeStart = 622101, XrefRangeEnd = 622128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAndApplyDebugSettings(ref RenderingData renderingData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_CheckAndApplyDebugSettings_Private_Static_Void_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00058D20 File Offset: 0x00056F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622129, XrefRangeEnd = 622137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref imageSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_ResolveUpscalingFilterSelection_Private_Static_ImageUpscalingFilter_Vector2_Single_UpscalingFilterSelection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00058D7C File Offset: 0x00056F7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 622157, RefRangeEnd = 622161, XrefRangeStart = 622137, XrefRangeEnd = 622157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HDROutputForMainDisplayIsActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_HDROutputForMainDisplayIsActive_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00058DAC File Offset: 0x00056FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622161, XrefRangeEnd = 622172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HDROutputForAnyDisplayIsActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_HDROutputForAnyDisplayIsActive_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00058DDC File Offset: 0x00056FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622172, XrefRangeEnd = 622196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHDRState(List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameras);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_SetHDRState_Private_Void_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00058E20 File Offset: 0x00057020
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 622196, RefRangeEnd = 622201, XrefRangeStart = 622196, XrefRangeEnd = 622196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetHDROutputLuminanceParameters(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hdrDisplayInformation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdrDisplayColorGamut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tonemapping);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hdrOutputParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetHDROutputLuminanceParameters_Internal_Static_Void_HDRDisplayInformation_ColorGamut_Tonemapping_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00058E80 File Offset: 0x00057080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622202, RefRangeEnd = 622203, XrefRangeStart = 622201, XrefRangeEnd = 622202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tonemapping);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hdrOutputParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetHDROutputGradingParameters_Internal_Static_Void_Tonemapping_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00058EC4 File Offset: 0x000570C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 622208, RefRangeEnd = 622210, XrefRangeStart = 622203, XrefRangeEnd = 622208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGameCamera(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_IsGameCamera_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00058F08 File Offset: 0x00057108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622210, XrefRangeEnd = 622218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsStereoEnabled(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_IsStereoEnabled_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00058F4C File Offset: 0x0005714C
		public unsafe static UniversalRenderPipelineAsset asset
		{
			[CallerCount(62)]
			[CachedScanResults(RefRangeStart = 622220, RefRangeEnd = 622282, XrefRangeStart = 622218, XrefRangeEnd = 622220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_get_asset_Public_Static_get_UniversalRenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineAsset>(intPtr3) : null;
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00058F80 File Offset: 0x00057180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622282, XrefRangeEnd = 622286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCameras(List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameras);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_SortCameras_Private_Void_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00058FC4 File Offset: 0x000571C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 622291, RefRangeEnd = 622295, XrefRangeStart = 622286, XrefRangeEnd = 622291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHdrEnabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestHDRColorBufferPrecision;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_MakeRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_Boolean_HDRColorBufferPrecision_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00059020 File Offset: 0x00057220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622299, RefRangeEnd = 622300, XrefRangeStart = 622295, XrefRangeEnd = 622299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat MakeUnormRenderTextureGraphicsFormat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_MakeUnormRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00059050 File Offset: 0x00057250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622330, RefRangeEnd = 622331, XrefRangeStart = 622300, XrefRangeEnd = 622330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, ref CameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHdrEnabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestHDRColorBufferPrecision;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsAlpha;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresOpaqueTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_CreateRenderTextureDescriptor_Internal_Static_RenderTextureDescriptor_Camera_byref_CameraData_Boolean_HDRColorBufferPrecision_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000590EC File Offset: 0x000572EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622331, XrefRangeEnd = 622342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, Nullable<float> innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightLocalToWorldMatrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotAngle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(innerSpotAngle));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightAttenuation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightSpotDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetLightAttenuationAndSpotDirection_Public_Static_Void_LightType_Single_Matrix4x4_Single_Nullable_1_Single_byref_Vector4_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00059180 File Offset: 0x00057380
		[CallerCount(0)]
		public unsafe static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightRange;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightAttenuation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetPunctualLightDistanceAttenuation_Internal_Static_Void_Single_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x000591C0 File Offset: 0x000573C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 622351, RefRangeEnd = 622353, XrefRangeStart = 622342, XrefRangeEnd = 622351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSpotAngleAttenuation(float spotAngle, Nullable<float> innerSpotAngle, ref Vector4 lightAttenuation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spotAngle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(innerSpotAngle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightAttenuation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetSpotAngleAttenuation_Internal_Static_Void_Single_Nullable_1_Single_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00059218 File Offset: 0x00057418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622354, RefRangeEnd = 622355, XrefRangeStart = 622353, XrefRangeEnd = 622354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lightLocalToWorldMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightSpotDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_GetSpotDirection_Internal_Static_Void_byref_Matrix4x4_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00059258 File Offset: 0x00057458
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 622394, RefRangeEnd = 622400, XrefRangeStart = 622355, XrefRangeEnd = 622394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lights));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightColor;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightAttenuation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightSpotDir;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightOcclusionProbeChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_InitializeLightConstants_Common_Public_Static_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x000592EC File Offset: 0x000574EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622400, XrefRangeEnd = 622401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_RecordRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00059344 File Offset: 0x00057544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622401, XrefRangeEnd = 622416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.NativeMethodInfoPtr_RecordAndExecuteRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0000B581 File Offset: 0x00009781
		public UniversalRenderPipeline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0005939C File Offset: 0x0005759C
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x0000B58A File Offset: 0x0000978A
		public unsafe static string k_ShaderTagName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_ShaderTagName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_ShaderTagName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x000593BC File Offset: 0x000575BC
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x0000B59C File Offset: 0x0000979C
		public unsafe static int k_DefaultRenderingLayerMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultRenderingLayerMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultRenderingLayerMask, (void*)(&value));
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x000593D8 File Offset: 0x000575D8
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x0000B5AA File Offset: 0x000097AA
		public unsafe DebugDisplaySettingsUI m_DebugDisplaySettingsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_m_DebugDisplaySettingsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_m_DebugDisplaySettingsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00059408 File Offset: 0x00057608
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0000B5C9 File Offset: 0x000097C9
		public unsafe UniversalRenderPipelineGlobalSettings m_GlobalSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_m_GlobalSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineGlobalSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_m_GlobalSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00059438 File Offset: 0x00057638
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x0000B5E8 File Offset: 0x000097E8
		public unsafe static bool cameraStackRequiresDepthForPostprocessing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing, (void*)(&value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00059454 File Offset: 0x00057654
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0000B5F6 File Offset: 0x000097F6
		public unsafe static RenderGraph s_RenderGraph
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_s_RenderGraph, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_s_RenderGraph, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0005947C File Offset: 0x0005767C
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0000B608 File Offset: 0x00009808
		public unsafe static RTHandleResourcePool s_RTHandlePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_s_RTHandlePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandleResourcePool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_s_RTHandlePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x000594A4 File Offset: 0x000576A4
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0000B61A File Offset: 0x0000981A
		public unsafe static bool useRenderGraph
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_useRenderGraph, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_useRenderGraph, (void*)(&value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x000594C0 File Offset: 0x000576C0
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x0000B628 File Offset: 0x00009828
		public unsafe UniversalRenderPipelineAsset pipelineAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_pipelineAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_pipelineAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x000594F0 File Offset: 0x000576F0
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x0000B647 File Offset: 0x00009847
		public unsafe bool enableHDROnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_enableHDROnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_enableHDROnce)) = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00059518 File Offset: 0x00057718
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x0000B662 File Offset: 0x00009862
		public unsafe static Vector4 k_DefaultLightPosition
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightPosition, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightPosition, (void*)(&value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00059534 File Offset: 0x00057734
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x0000B670 File Offset: 0x00009870
		public unsafe static Vector4 k_DefaultLightColor
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightColor, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightColor, (void*)(&value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00059550 File Offset: 0x00057750
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x0000B67E File Offset: 0x0000987E
		public unsafe static Vector4 k_DefaultLightAttenuation
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightAttenuation, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightAttenuation, (void*)(&value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0005956C File Offset: 0x0005776C
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x0000B68C File Offset: 0x0000988C
		public unsafe static Vector4 k_DefaultLightSpotDirection
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightSpotDirection, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightSpotDirection, (void*)(&value));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00059588 File Offset: 0x00057788
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x0000B69A File Offset: 0x0000989A
		public unsafe static Vector4 k_DefaultLightsProbeChannel
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightsProbeChannel, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_k_DefaultLightsProbeChannel, (void*)(&value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x000595A4 File Offset: 0x000577A4
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public unsafe static List<Vector4> m_ShadowBiasData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_m_ShadowBiasData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_m_ShadowBiasData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x000595CC File Offset: 0x000577CC
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x0000B6BA File Offset: 0x000098BA
		public unsafe static List<int> m_ShadowResolutionData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_m_ShadowResolutionData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_m_ShadowResolutionData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x000595F4 File Offset: 0x000577F4
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x0000B6CC File Offset: 0x000098CC
		public unsafe Comparison<Camera> cameraComparison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_cameraComparison);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.NativeFieldInfoPtr_cameraComparison), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00059624 File Offset: 0x00057824
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x0000B6EB File Offset: 0x000098EB
		public unsafe static Lightmapping.RequestLightsDelegate lightsDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.NativeFieldInfoPtr_lightsDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.NativeFieldInfoPtr_lightsDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderTagName;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultRenderingLayerMask;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugDisplaySettingsUI;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalSettings;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeFieldInfoPtr_s_RenderGraph;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeFieldInfoPtr_s_RTHandlePool;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeFieldInfoPtr_useRenderGraph;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeFieldInfoPtr_pipelineAsset;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr_enableHDROnce;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultLightPosition;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultLightColor;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultLightAttenuation;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultLightSpotDirection;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultLightsProbeChannel;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowBiasData;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowResolutionData;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr_cameraComparison;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr_lightsDelegate;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_get_maxShadowBias_Public_Static_get_Single_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_get_minRenderScale_Public_Static_get_Single_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_get_maxRenderScale_Public_Static_get_Single_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_get_maxNumIterationsEnclosingSphere_Public_Static_get_Int32_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_get_maxPerObjectLights_Public_Static_get_Int32_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleAdditionalLights_Public_Static_get_Int32_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_get_lightsPerTile_Internal_Static_get_Int32_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_get_maxZBinWords_Internal_Static_get_Int32_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTileWords_Internal_Static_get_Int32_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleReflectionProbes_Internal_Static_get_Int32_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_get_RenderPipelineGlobalSettings_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UniversalRenderPipelineAsset_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAdditionalCameraData_Private_Void_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_RenderSingleCamera_Public_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_byref_UniversalAdditionalCameraData_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCullingParameters_Private_Static_Boolean_CameraData_byref_ScriptableCullingParameters_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_RenderSingleCamera_Private_Static_Void_ScriptableRenderContext_byref_CameraData_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_RenderCameraStack_Private_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraData_Private_Static_Void_byref_CameraData_byref_XRPass_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumeFramework_Private_Static_Void_Camera_UniversalAdditionalCameraData_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_byref_CameraData_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_SetSupportedRenderingFeatures_Private_Static_Void_UniversalRenderPipelineAsset_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_byref_CameraData_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStackedCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_byref_CameraData_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAdditionalCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_byref_CameraData_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRenderingData_Private_Static_Void_UniversalRenderPipelineAsset_byref_CameraData_byref_CullingResults_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_InitializeShadowData_Private_Static_Void_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_Boolean_Boolean_Boolean_byref_ShadowData_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_InitializePostProcessingData_Private_Static_Void_UniversalRenderPipelineAsset_Boolean_byref_PostProcessingData_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLightData_Private_Static_Void_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_Int32_byref_LightData_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTaaRenderingDebugOverrides_Private_Static_Void_byref_Settings_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTemporalAAData_Private_Static_Void_byref_CameraData_UniversalAdditionalCameraData_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTemporalAATargets_Private_Static_Void_byref_CameraData_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraStereoMatrices_Private_Static_Void_Camera_XRPass_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_GetPerObjectLightFlags_Private_Static_PerObjectData_Int32_Boolean_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_GetMainLightIndex_Private_Static_Int32_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_SetupPerFrameShaderConstants_Private_Static_Void_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_SetupPerCameraShaderConstants_Private_Static_Void_CommandBuffer_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndApplyDebugSettings_Private_Static_Void_byref_RenderingData_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_ResolveUpscalingFilterSelection_Private_Static_ImageUpscalingFilter_Vector2_Single_UpscalingFilterSelection_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_HDROutputForMainDisplayIsActive_Internal_Static_Boolean_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_HDROutputForAnyDisplayIsActive_Internal_Static_Boolean_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_SetHDRState_Private_Void_List_1_Camera_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_GetHDROutputLuminanceParameters_Internal_Static_Void_HDRDisplayInformation_ColorGamut_Tonemapping_byref_Vector4_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_GetHDROutputGradingParameters_Internal_Static_Void_Tonemapping_byref_Vector4_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_IsGameCamera_Public_Static_Boolean_Camera_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_IsStereoEnabled_Public_Static_Boolean_Camera_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_Static_get_UniversalRenderPipelineAsset_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_SortCameras_Private_Void_List_1_Camera_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_MakeRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_Boolean_HDRColorBufferPrecision_Boolean_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_MakeUnormRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderTextureDescriptor_Internal_Static_RenderTextureDescriptor_Camera_byref_CameraData_Boolean_HDRColorBufferPrecision_Int32_Boolean_Boolean_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_GetLightAttenuationAndSpotDirection_Public_Static_Void_LightType_Single_Matrix4x4_Single_Nullable_1_Single_byref_Vector4_byref_Vector4_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_GetPunctualLightDistanceAttenuation_Internal_Static_Void_Single_byref_Vector4_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotAngleAttenuation_Internal_Static_Void_Single_Nullable_1_Single_byref_Vector4_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotDirection_Internal_Static_Void_byref_Matrix4x4_byref_Vector4_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLightConstants_Common_Public_Static_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_RecordRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_RecordAndExecuteRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x020001D0 RID: 464
		public static class Profiling : Object
		{
			// Token: 0x060020CE RID: 8398 RVA: 0x0007F6F0 File Offset: 0x0007D8F0
			// Note: this type is marked as 'beforefieldinit'.
			static Profiling()
			{
				Il2CppClassPointerStore<UniversalRenderPipeline.Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "Profiling");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling>.NativeClassPtr);
				UniversalRenderPipeline.Profiling.NativeFieldInfoPtr_s_HashSamplerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling>.NativeClassPtr, "s_HashSamplerCache");
				UniversalRenderPipeline.Profiling.NativeFieldInfoPtr_unknownSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling>.NativeClassPtr, "unknownSampler");
				UniversalRenderPipeline.Profiling.NativeMethodInfoPtr_TryGetOrAddCameraSampler_Public_Static_ProfilingSampler_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling>.NativeClassPtr, 100665755);
			}

			// Token: 0x060020CF RID: 8399 RVA: 0x0007F758 File Offset: 0x0007D958
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 620567, RefRangeEnd = 620568, XrefRangeStart = 620546, XrefRangeEnd = 620567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ProfilingSampler TryGetOrAddCameraSampler(Camera camera)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.Profiling.NativeMethodInfoPtr_TryGetOrAddCameraSampler_Public_Static_ProfilingSampler_Camera_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr3) : null;
				}
			}

			// Token: 0x060020D0 RID: 8400 RVA: 0x00012D4C File Offset: 0x00010F4C
			public Profiling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0007F79C File Offset: 0x0007D99C
			// (set) Token: 0x060020D2 RID: 8402 RVA: 0x00012D55 File Offset: 0x00010F55
			public unsafe static Dictionary<int, ProfilingSampler> s_HashSamplerCache
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.NativeFieldInfoPtr_s_HashSamplerCache, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ProfilingSampler>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.NativeFieldInfoPtr_s_HashSamplerCache, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD3 RID: 3027
			// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0007F7C4 File Offset: 0x0007D9C4
			// (set) Token: 0x060020D4 RID: 8404 RVA: 0x00012D67 File Offset: 0x00010F67
			public unsafe static ProfilingSampler unknownSampler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.NativeFieldInfoPtr_unknownSampler, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.NativeFieldInfoPtr_unknownSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001757 RID: 5975
			private static readonly IntPtr NativeFieldInfoPtr_s_HashSamplerCache;

			// Token: 0x04001758 RID: 5976
			private static readonly IntPtr NativeFieldInfoPtr_unknownSampler;

			// Token: 0x04001759 RID: 5977
			private static readonly IntPtr NativeMethodInfoPtr_TryGetOrAddCameraSampler_Public_Static_ProfilingSampler_Camera_0;

			// Token: 0x0200024E RID: 590
			public static class Pipeline : Object
			{
				// Token: 0x06002533 RID: 9523 RVA: 0x0008ADF0 File Offset: 0x00088FF0
				// Note: this type is marked as 'beforefieldinit'.
				static Pipeline()
				{
					Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling>.NativeClassPtr, "Pipeline");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr);
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_beginContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "beginContextRendering");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_endContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "endContextRendering");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_beginCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "beginCameraRendering");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_endCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "endCameraRendering");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "k_Name");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "initializeCameraData");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeStackedCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "initializeStackedCameraData");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeAdditionalCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "initializeAdditionalCameraData");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeRenderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "initializeRenderingData");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeShadowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "initializeShadowData");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeLightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "initializeLightData");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_getPerObjectLightFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "getPerObjectLightFlags");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_getMainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "getMainLightIndex");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_setupPerFrameShaderConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "setupPerFrameShaderConstants");
					UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_setupPerCameraShaderConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "setupPerCameraShaderConstants");
				}

				// Token: 0x06002534 RID: 9524 RVA: 0x0001520B File Offset: 0x0001340B
				public Pipeline(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D22 RID: 3362
				// (get) Token: 0x06002535 RID: 9525 RVA: 0x0008AF48 File Offset: 0x00089148
				// (set) Token: 0x06002536 RID: 9526 RVA: 0x00015214 File Offset: 0x00013414
				public unsafe static ProfilingSampler beginContextRendering
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_beginContextRendering, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_beginContextRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D23 RID: 3363
				// (get) Token: 0x06002537 RID: 9527 RVA: 0x0008AF70 File Offset: 0x00089170
				// (set) Token: 0x06002538 RID: 9528 RVA: 0x00015226 File Offset: 0x00013426
				public unsafe static ProfilingSampler endContextRendering
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_endContextRendering, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_endContextRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D24 RID: 3364
				// (get) Token: 0x06002539 RID: 9529 RVA: 0x0008AF98 File Offset: 0x00089198
				// (set) Token: 0x0600253A RID: 9530 RVA: 0x00015238 File Offset: 0x00013438
				public unsafe static ProfilingSampler beginCameraRendering
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_beginCameraRendering, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_beginCameraRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D25 RID: 3365
				// (get) Token: 0x0600253B RID: 9531 RVA: 0x0008AFC0 File Offset: 0x000891C0
				// (set) Token: 0x0600253C RID: 9532 RVA: 0x0001524A File Offset: 0x0001344A
				public unsafe static ProfilingSampler endCameraRendering
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_endCameraRendering, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_endCameraRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D26 RID: 3366
				// (get) Token: 0x0600253D RID: 9533 RVA: 0x0008AFE8 File Offset: 0x000891E8
				// (set) Token: 0x0600253E RID: 9534 RVA: 0x0001525C File Offset: 0x0001345C
				public unsafe static string k_Name
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_k_Name, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000D27 RID: 3367
				// (get) Token: 0x0600253F RID: 9535 RVA: 0x0008B008 File Offset: 0x00089208
				// (set) Token: 0x06002540 RID: 9536 RVA: 0x0001526E File Offset: 0x0001346E
				public unsafe static ProfilingSampler initializeCameraData
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeCameraData, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeCameraData, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D28 RID: 3368
				// (get) Token: 0x06002541 RID: 9537 RVA: 0x0008B030 File Offset: 0x00089230
				// (set) Token: 0x06002542 RID: 9538 RVA: 0x00015280 File Offset: 0x00013480
				public unsafe static ProfilingSampler initializeStackedCameraData
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeStackedCameraData, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeStackedCameraData, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D29 RID: 3369
				// (get) Token: 0x06002543 RID: 9539 RVA: 0x0008B058 File Offset: 0x00089258
				// (set) Token: 0x06002544 RID: 9540 RVA: 0x00015292 File Offset: 0x00013492
				public unsafe static ProfilingSampler initializeAdditionalCameraData
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeAdditionalCameraData, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeAdditionalCameraData, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D2A RID: 3370
				// (get) Token: 0x06002545 RID: 9541 RVA: 0x0008B080 File Offset: 0x00089280
				// (set) Token: 0x06002546 RID: 9542 RVA: 0x000152A4 File Offset: 0x000134A4
				public unsafe static ProfilingSampler initializeRenderingData
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeRenderingData, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeRenderingData, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D2B RID: 3371
				// (get) Token: 0x06002547 RID: 9543 RVA: 0x0008B0A8 File Offset: 0x000892A8
				// (set) Token: 0x06002548 RID: 9544 RVA: 0x000152B6 File Offset: 0x000134B6
				public unsafe static ProfilingSampler initializeShadowData
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeShadowData, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeShadowData, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D2C RID: 3372
				// (get) Token: 0x06002549 RID: 9545 RVA: 0x0008B0D0 File Offset: 0x000892D0
				// (set) Token: 0x0600254A RID: 9546 RVA: 0x000152C8 File Offset: 0x000134C8
				public unsafe static ProfilingSampler initializeLightData
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeLightData, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_initializeLightData, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D2D RID: 3373
				// (get) Token: 0x0600254B RID: 9547 RVA: 0x0008B0F8 File Offset: 0x000892F8
				// (set) Token: 0x0600254C RID: 9548 RVA: 0x000152DA File Offset: 0x000134DA
				public unsafe static ProfilingSampler getPerObjectLightFlags
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_getPerObjectLightFlags, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_getPerObjectLightFlags, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D2E RID: 3374
				// (get) Token: 0x0600254D RID: 9549 RVA: 0x0008B120 File Offset: 0x00089320
				// (set) Token: 0x0600254E RID: 9550 RVA: 0x000152EC File Offset: 0x000134EC
				public unsafe static ProfilingSampler getMainLightIndex
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_getMainLightIndex, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_getMainLightIndex, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D2F RID: 3375
				// (get) Token: 0x0600254F RID: 9551 RVA: 0x0008B148 File Offset: 0x00089348
				// (set) Token: 0x06002550 RID: 9552 RVA: 0x000152FE File Offset: 0x000134FE
				public unsafe static ProfilingSampler setupPerFrameShaderConstants
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_setupPerFrameShaderConstants, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_setupPerFrameShaderConstants, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D30 RID: 3376
				// (get) Token: 0x06002551 RID: 9553 RVA: 0x0008B170 File Offset: 0x00089370
				// (set) Token: 0x06002552 RID: 9554 RVA: 0x00015310 File Offset: 0x00013510
				public unsafe static ProfilingSampler setupPerCameraShaderConstants
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_setupPerCameraShaderConstants, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.NativeFieldInfoPtr_setupPerCameraShaderConstants, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040019E1 RID: 6625
				private static readonly IntPtr NativeFieldInfoPtr_beginContextRendering;

				// Token: 0x040019E2 RID: 6626
				private static readonly IntPtr NativeFieldInfoPtr_endContextRendering;

				// Token: 0x040019E3 RID: 6627
				private static readonly IntPtr NativeFieldInfoPtr_beginCameraRendering;

				// Token: 0x040019E4 RID: 6628
				private static readonly IntPtr NativeFieldInfoPtr_endCameraRendering;

				// Token: 0x040019E5 RID: 6629
				private static readonly IntPtr NativeFieldInfoPtr_k_Name;

				// Token: 0x040019E6 RID: 6630
				private static readonly IntPtr NativeFieldInfoPtr_initializeCameraData;

				// Token: 0x040019E7 RID: 6631
				private static readonly IntPtr NativeFieldInfoPtr_initializeStackedCameraData;

				// Token: 0x040019E8 RID: 6632
				private static readonly IntPtr NativeFieldInfoPtr_initializeAdditionalCameraData;

				// Token: 0x040019E9 RID: 6633
				private static readonly IntPtr NativeFieldInfoPtr_initializeRenderingData;

				// Token: 0x040019EA RID: 6634
				private static readonly IntPtr NativeFieldInfoPtr_initializeShadowData;

				// Token: 0x040019EB RID: 6635
				private static readonly IntPtr NativeFieldInfoPtr_initializeLightData;

				// Token: 0x040019EC RID: 6636
				private static readonly IntPtr NativeFieldInfoPtr_getPerObjectLightFlags;

				// Token: 0x040019ED RID: 6637
				private static readonly IntPtr NativeFieldInfoPtr_getMainLightIndex;

				// Token: 0x040019EE RID: 6638
				private static readonly IntPtr NativeFieldInfoPtr_setupPerFrameShaderConstants;

				// Token: 0x040019EF RID: 6639
				private static readonly IntPtr NativeFieldInfoPtr_setupPerCameraShaderConstants;

				// Token: 0x0200024F RID: 591
				public static class Renderer : Object
				{
					// Token: 0x06002553 RID: 9555 RVA: 0x0008B198 File Offset: 0x00089398
					// Note: this type is marked as 'beforefieldinit'.
					static Renderer()
					{
						Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Renderer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "Renderer");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Renderer>.NativeClassPtr);
						UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Renderer>.NativeClassPtr, "k_Name");
						UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_setupCullingParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Renderer>.NativeClassPtr, "setupCullingParameters");
						UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_setup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Renderer>.NativeClassPtr, "setup");
					}

					// Token: 0x06002554 RID: 9556 RVA: 0x00015322 File Offset: 0x00013522
					public Renderer(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x17000D31 RID: 3377
					// (get) Token: 0x06002555 RID: 9557 RVA: 0x0008B200 File Offset: 0x00089400
					// (set) Token: 0x06002556 RID: 9558 RVA: 0x0001532B File Offset: 0x0001352B
					public unsafe static string k_Name
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
							return IL2CPP.Il2CppStringToManaged(intPtr);
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_k_Name, IL2CPP.ManagedStringToIl2Cpp(value));
						}
					}

					// Token: 0x17000D32 RID: 3378
					// (get) Token: 0x06002557 RID: 9559 RVA: 0x0008B220 File Offset: 0x00089420
					// (set) Token: 0x06002558 RID: 9560 RVA: 0x0001533D File Offset: 0x0001353D
					public unsafe static ProfilingSampler setupCullingParameters
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_setupCullingParameters, (void*)(&intPtr));
							IntPtr intPtr2 = intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_setupCullingParameters, IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x17000D33 RID: 3379
					// (get) Token: 0x06002559 RID: 9561 RVA: 0x0008B248 File Offset: 0x00089448
					// (set) Token: 0x0600255A RID: 9562 RVA: 0x0001534F File Offset: 0x0001354F
					public unsafe static ProfilingSampler setup
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_setup, (void*)(&intPtr));
							IntPtr intPtr2 = intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.Renderer.NativeFieldInfoPtr_setup, IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x040019F0 RID: 6640
					private static readonly IntPtr NativeFieldInfoPtr_k_Name;

					// Token: 0x040019F1 RID: 6641
					private static readonly IntPtr NativeFieldInfoPtr_setupCullingParameters;

					// Token: 0x040019F2 RID: 6642
					private static readonly IntPtr NativeFieldInfoPtr_setup;
				}

				// Token: 0x02000250 RID: 592
				public static class Context : Object
				{
					// Token: 0x0600255B RID: 9563 RVA: 0x0008B270 File Offset: 0x00089470
					// Note: this type is marked as 'beforefieldinit'.
					static Context()
					{
						Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline>.NativeClassPtr, "Context");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Context>.NativeClassPtr);
						UniversalRenderPipeline.Profiling.Pipeline.Context.NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Context>.NativeClassPtr, "k_Name");
						UniversalRenderPipeline.Profiling.Pipeline.Context.NativeFieldInfoPtr_submit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.Profiling.Pipeline.Context>.NativeClassPtr, "submit");
					}

					// Token: 0x0600255C RID: 9564 RVA: 0x00015361 File Offset: 0x00013561
					public Context(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x17000D34 RID: 3380
					// (get) Token: 0x0600255D RID: 9565 RVA: 0x0008B2C4 File Offset: 0x000894C4
					// (set) Token: 0x0600255E RID: 9566 RVA: 0x0001536A File Offset: 0x0001356A
					public unsafe static string k_Name
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.Context.NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
							return IL2CPP.Il2CppStringToManaged(intPtr);
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.Context.NativeFieldInfoPtr_k_Name, IL2CPP.ManagedStringToIl2Cpp(value));
						}
					}

					// Token: 0x17000D35 RID: 3381
					// (get) Token: 0x0600255F RID: 9567 RVA: 0x0008B2E4 File Offset: 0x000894E4
					// (set) Token: 0x06002560 RID: 9568 RVA: 0x0001537C File Offset: 0x0001357C
					public unsafe static ProfilingSampler submit
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.Profiling.Pipeline.Context.NativeFieldInfoPtr_submit, (void*)(&intPtr));
							IntPtr intPtr2 = intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.Profiling.Pipeline.Context.NativeFieldInfoPtr_submit, IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x040019F3 RID: 6643
					private static readonly IntPtr NativeFieldInfoPtr_k_Name;

					// Token: 0x040019F4 RID: 6644
					private static readonly IntPtr NativeFieldInfoPtr_submit;
				}
			}
		}

		// Token: 0x020001D1 RID: 465
		public class SingleCameraRequest : Object
		{
			// Token: 0x060020D5 RID: 8405 RVA: 0x0007F7EC File Offset: 0x0007D9EC
			// Note: this type is marked as 'beforefieldinit'.
			static SingleCameraRequest()
			{
				Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "SingleCameraRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr);
				UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr, "destination");
				UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_mipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr, "mipLevel");
				UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr, "face");
				UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr, "slice");
				UniversalRenderPipeline.SingleCameraRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr, 100665760);
			}

			// Token: 0x060020D6 RID: 8406 RVA: 0x0007F87C File Offset: 0x0007DA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620568, XrefRangeEnd = 620569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleCameraRequest()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipeline.SingleCameraRequest>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.SingleCameraRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020D7 RID: 8407 RVA: 0x00012D79 File Offset: 0x00010F79
			public SingleCameraRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD4 RID: 3028
			// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0007F8B8 File Offset: 0x0007DAB8
			// (set) Token: 0x060020D9 RID: 8409 RVA: 0x00012D82 File Offset: 0x00010F82
			public unsafe RenderTexture destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD5 RID: 3029
			// (get) Token: 0x060020DA RID: 8410 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
			// (set) Token: 0x060020DB RID: 8411 RVA: 0x00012DA1 File Offset: 0x00010FA1
			public unsafe int mipLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_mipLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_mipLevel)) = value;
				}
			}

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x060020DC RID: 8412 RVA: 0x0007F910 File Offset: 0x0007DB10
			// (set) Token: 0x060020DD RID: 8413 RVA: 0x00012DBC File Offset: 0x00010FBC
			public unsafe CubemapFace face
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_face);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_face)) = value;
				}
			}

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x060020DE RID: 8414 RVA: 0x0007F938 File Offset: 0x0007DB38
			// (set) Token: 0x060020DF RID: 8415 RVA: 0x00012DD7 File Offset: 0x00010FD7
			public unsafe int slice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_slice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipeline.SingleCameraRequest.NativeFieldInfoPtr_slice)) = value;
				}
			}

			// Token: 0x0400175A RID: 5978
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x0400175B RID: 5979
			private static readonly IntPtr NativeFieldInfoPtr_mipLevel;

			// Token: 0x0400175C RID: 5980
			private static readonly IntPtr NativeFieldInfoPtr_face;

			// Token: 0x0400175D RID: 5981
			private static readonly IntPtr NativeFieldInfoPtr_slice;

			// Token: 0x0400175E RID: 5982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001D2 RID: 466
		[ObfuscatedName("UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060020E0 RID: 8416 RVA: 0x0007F960 File Offset: 0x0007DB60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr);
				UniversalRenderPipeline.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr, "<>9");
				UniversalRenderPipeline.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr, "<>9__33_0");
				UniversalRenderPipeline.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr, 100665762);
				UniversalRenderPipeline.__c.NativeMethodInfoPtr___ctor_b__33_0_Internal_Int32_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr, 100665763);
				UniversalRenderPipeline.__c.NativeMethodInfoPtr___cctor_b__99_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr, 100665764);
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x0007F9F0 File Offset: 0x0007DBF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipeline.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020E2 RID: 8418 RVA: 0x0007FA2C File Offset: 0x0007DC2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620569, XrefRangeEnd = 620571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __ctor_b__33_0(Camera camera1, Camera camera2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.__c.NativeMethodInfoPtr___ctor_b__33_0_Internal_Int32_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060020E3 RID: 8419 RVA: 0x0007FA8C File Offset: 0x0007DC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620571, XrefRangeEnd = 620595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__99_0(Il2CppReferenceArray<Light> requests, NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipeline.__c.NativeMethodInfoPtr___cctor_b__99_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020E4 RID: 8420 RVA: 0x00012DF2 File Offset: 0x00010FF2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0007FAE8 File Offset: 0x0007DCE8
			// (set) Token: 0x060020E6 RID: 8422 RVA: 0x00012DFB File Offset: 0x00010FFB
			public unsafe static UniversalRenderPipeline.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipeline.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD9 RID: 3033
			// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0007FB10 File Offset: 0x0007DD10
			// (set) Token: 0x060020E8 RID: 8424 RVA: 0x00012E0D File Offset: 0x0001100D
			public unsafe static Comparison<Camera> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipeline.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Camera>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipeline.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400175F RID: 5983
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001760 RID: 5984
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04001761 RID: 5985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001762 RID: 5986
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__33_0_Internal_Int32_Camera_Camera_0;

			// Token: 0x04001763 RID: 5987
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__99_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x020001D3 RID: 467
		private sealed class MethodInfoStoreGeneric_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04001764 RID: 5988
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalRenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0, Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
		}

		// Token: 0x020001D4 RID: 468
		private sealed class MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04001765 RID: 5989
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalRenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
		}
	}
}
