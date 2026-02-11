using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000118 RID: 280
	public class DeferredLights : Object
	{
		// Token: 0x06001728 RID: 5928 RVA: 0x00062EEC File Offset: 0x000610EC
		// Note: this type is marked as 'beforefieldinit'.
		static DeferredLights()
		{
			Il2CppClassPointerStore<DeferredLights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DeferredLights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr);
			DeferredLights.NativeFieldInfoPtr_k_GBufferNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_GBufferNames");
			DeferredLights.NativeFieldInfoPtr_k_StencilDeferredPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_StencilDeferredPassNames");
			DeferredLights.NativeFieldInfoPtr_k_InvalidLightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_InvalidLightOffset");
			DeferredLights.NativeFieldInfoPtr_k_SetupLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_SetupLights");
			DeferredLights.NativeFieldInfoPtr_k_DeferredPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_DeferredPass");
			DeferredLights.NativeFieldInfoPtr_k_DeferredStencilPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_DeferredStencilPass");
			DeferredLights.NativeFieldInfoPtr_k_DeferredFogPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_DeferredFogPass");
			DeferredLights.NativeFieldInfoPtr_k_ClearStencilPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_ClearStencilPartial");
			DeferredLights.NativeFieldInfoPtr_k_SetupLightConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "k_SetupLightConstants");
			DeferredLights.NativeFieldInfoPtr_kStencilShapeGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "kStencilShapeGuard");
			DeferredLights.NativeFieldInfoPtr_m_ProfilingSetupLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_ProfilingSetupLights");
			DeferredLights.NativeFieldInfoPtr_m_ProfilingDeferredPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_ProfilingDeferredPass");
			DeferredLights.NativeFieldInfoPtr_m_ProfilingSetupLightConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_ProfilingSetupLightConstants");
			DeferredLights.NativeFieldInfoPtr__RenderingLayerMaskSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<RenderingLayerMaskSize>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__UseDecalLayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<UseDecalLayers>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__UseRenderPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<UseRenderPass>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__HasDepthPrepass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<HasDepthPrepass>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__HasNormalPrepass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<HasNormalPrepass>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__HasRenderingLayerPrepass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<HasRenderingLayerPrepass>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__IsOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<IsOverlay>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__AccurateGbufferNormals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<AccurateGbufferNormals>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__MixedLightingSetup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<MixedLightingSetup>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__UseJobSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<UseJobSystem>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__RenderWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<RenderWidth>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__RenderHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<RenderHeight>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__GbufferAttachments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<GbufferAttachments>k__BackingField");
			DeferredLights.NativeFieldInfoPtr_GbufferRTHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "GbufferRTHandles");
			DeferredLights.NativeFieldInfoPtr__GbufferTextureHandles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<GbufferTextureHandles>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__DeferredInputAttachments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<DeferredInputAttachments>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__DeferredInputIsTransient_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<DeferredInputIsTransient>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__DepthAttachment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<DepthAttachment>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__DepthCopyTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<DepthCopyTexture>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__GbufferFormats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<GbufferFormats>k__BackingField");
			DeferredLights.NativeFieldInfoPtr__DepthAttachmentHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "<DepthAttachmentHandle>k__BackingField");
			DeferredLights.NativeFieldInfoPtr_m_stencilVisLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_stencilVisLights");
			DeferredLights.NativeFieldInfoPtr_m_stencilVisLightOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_stencilVisLightOffsets");
			DeferredLights.NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_AdditionalLightsShadowCasterPass");
			DeferredLights.NativeFieldInfoPtr_m_SphereMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_SphereMesh");
			DeferredLights.NativeFieldInfoPtr_m_HemisphereMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_HemisphereMesh");
			DeferredLights.NativeFieldInfoPtr_m_FullscreenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_FullscreenMesh");
			DeferredLights.NativeFieldInfoPtr_m_StencilDeferredMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_StencilDeferredMaterial");
			DeferredLights.NativeFieldInfoPtr_m_StencilDeferredPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_StencilDeferredPasses");
			DeferredLights.NativeFieldInfoPtr_m_ScreenToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_ScreenToWorld");
			DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerDeferredStencilPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_ProfilingSamplerDeferredStencilPass");
			DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerDeferredFogPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_ProfilingSamplerDeferredFogPass");
			DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerClearStencilPartialPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_ProfilingSamplerClearStencilPartialPass");
			DeferredLights.NativeFieldInfoPtr_m_LightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "m_LightCookieManager");
			DeferredLights.NativeMethodInfoPtr_get_GBufferAlbedoIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666026);
			DeferredLights.NativeMethodInfoPtr_get_GBufferSpecularMetallicIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666027);
			DeferredLights.NativeMethodInfoPtr_get_GBufferNormalSmoothnessIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666028);
			DeferredLights.NativeMethodInfoPtr_get_GBufferLightingIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666029);
			DeferredLights.NativeMethodInfoPtr_get_GbufferDepthIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666030);
			DeferredLights.NativeMethodInfoPtr_get_GBufferRenderingLayers_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666031);
			DeferredLights.NativeMethodInfoPtr_get_GBufferShadowMask_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666032);
			DeferredLights.NativeMethodInfoPtr_get_GBufferSliceCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666033);
			DeferredLights.NativeMethodInfoPtr_GetGBufferFormat_Internal_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666034);
			DeferredLights.NativeMethodInfoPtr_get_UseShadowMask_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666035);
			DeferredLights.NativeMethodInfoPtr_get_UseRenderingLayers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666036);
			DeferredLights.NativeMethodInfoPtr_get_RenderingLayerMaskSize_Internal_get_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666037);
			DeferredLights.NativeMethodInfoPtr_set_RenderingLayerMaskSize_Internal_set_Void_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666038);
			DeferredLights.NativeMethodInfoPtr_get_UseDecalLayers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666039);
			DeferredLights.NativeMethodInfoPtr_set_UseDecalLayers_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666040);
			DeferredLights.NativeMethodInfoPtr_get_UseLightLayers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666041);
			DeferredLights.NativeMethodInfoPtr_get_UseRenderPass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666042);
			DeferredLights.NativeMethodInfoPtr_set_UseRenderPass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666043);
			DeferredLights.NativeMethodInfoPtr_get_HasDepthPrepass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666044);
			DeferredLights.NativeMethodInfoPtr_set_HasDepthPrepass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666045);
			DeferredLights.NativeMethodInfoPtr_get_HasNormalPrepass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666046);
			DeferredLights.NativeMethodInfoPtr_set_HasNormalPrepass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666047);
			DeferredLights.NativeMethodInfoPtr_get_HasRenderingLayerPrepass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666048);
			DeferredLights.NativeMethodInfoPtr_set_HasRenderingLayerPrepass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666049);
			DeferredLights.NativeMethodInfoPtr_get_IsOverlay_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666050);
			DeferredLights.NativeMethodInfoPtr_set_IsOverlay_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666051);
			DeferredLights.NativeMethodInfoPtr_get_AccurateGbufferNormals_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666052);
			DeferredLights.NativeMethodInfoPtr_set_AccurateGbufferNormals_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666053);
			DeferredLights.NativeMethodInfoPtr_get_MixedLightingSetup_Internal_get_MixedLightingSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666054);
			DeferredLights.NativeMethodInfoPtr_set_MixedLightingSetup_Internal_set_Void_MixedLightingSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666055);
			DeferredLights.NativeMethodInfoPtr_get_UseJobSystem_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666056);
			DeferredLights.NativeMethodInfoPtr_set_UseJobSystem_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666057);
			DeferredLights.NativeMethodInfoPtr_get_RenderWidth_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666058);
			DeferredLights.NativeMethodInfoPtr_set_RenderWidth_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666059);
			DeferredLights.NativeMethodInfoPtr_get_RenderHeight_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666060);
			DeferredLights.NativeMethodInfoPtr_set_RenderHeight_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666061);
			DeferredLights.NativeMethodInfoPtr_get_GbufferAttachments_Internal_get_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666062);
			DeferredLights.NativeMethodInfoPtr_set_GbufferAttachments_Internal_set_Void_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666063);
			DeferredLights.NativeMethodInfoPtr_get_GbufferTextureHandles_Internal_get_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666064);
			DeferredLights.NativeMethodInfoPtr_set_GbufferTextureHandles_Internal_set_Void_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666065);
			DeferredLights.NativeMethodInfoPtr_get_DeferredInputAttachments_Internal_get_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666066);
			DeferredLights.NativeMethodInfoPtr_set_DeferredInputAttachments_Internal_set_Void_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666067);
			DeferredLights.NativeMethodInfoPtr_get_DeferredInputIsTransient_Internal_get_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666068);
			DeferredLights.NativeMethodInfoPtr_set_DeferredInputIsTransient_Internal_set_Void_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666069);
			DeferredLights.NativeMethodInfoPtr_get_DepthAttachment_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666070);
			DeferredLights.NativeMethodInfoPtr_set_DepthAttachment_Internal_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666071);
			DeferredLights.NativeMethodInfoPtr_get_DepthCopyTexture_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666072);
			DeferredLights.NativeMethodInfoPtr_set_DepthCopyTexture_Internal_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666073);
			DeferredLights.NativeMethodInfoPtr_get_GbufferFormats_Internal_get_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666074);
			DeferredLights.NativeMethodInfoPtr_set_GbufferFormats_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666075);
			DeferredLights.NativeMethodInfoPtr_get_DepthAttachmentHandle_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666076);
			DeferredLights.NativeMethodInfoPtr_set_DepthAttachmentHandle_Internal_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666077);
			DeferredLights.NativeMethodInfoPtr__ctor_Internal_Void_InitParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666078);
			DeferredLights.NativeMethodInfoPtr_SetupLights_Internal_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666079);
			DeferredLights.NativeMethodInfoPtr_ResolveMixedLightingMode_Internal_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666080);
			DeferredLights.NativeMethodInfoPtr_DisableFramebufferFetchInput_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666081);
			DeferredLights.NativeMethodInfoPtr_ReleaseGbufferResources_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666082);
			DeferredLights.NativeMethodInfoPtr_ReAllocateGBufferIfNeeded_Internal_Void_RenderTextureDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666083);
			DeferredLights.NativeMethodInfoPtr_CreateGbufferResources_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666084);
			DeferredLights.NativeMethodInfoPtr_UpdateDeferredInputAttachments_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666085);
			DeferredLights.NativeMethodInfoPtr_IsRuntimeSupportedThisFrame_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666086);
			DeferredLights.NativeMethodInfoPtr_Setup_Public_Void_byref_RenderingData_AdditionalLightsShadowCasterPass_Boolean_Boolean_Boolean_RTHandle_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666087);
			DeferredLights.NativeMethodInfoPtr_Setup_Internal_Void_AdditionalLightsShadowCasterPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666088);
			DeferredLights.NativeMethodInfoPtr_OnCameraCleanup_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666089);
			DeferredLights.NativeMethodInfoPtr_OverwriteStencil_Internal_Static_StencilState_StencilState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666090);
			DeferredLights.NativeMethodInfoPtr_OverwriteStencil_Internal_Static_RenderStateBlock_RenderStateBlock_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666091);
			DeferredLights.NativeMethodInfoPtr_ClearStencilPartial_Internal_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666092);
			DeferredLights.NativeMethodInfoPtr_ExecuteDeferredPass_Internal_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666093);
			DeferredLights.NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666094);
			DeferredLights.NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_CommandBuffer_byref_LightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666095);
			DeferredLights.NativeMethodInfoPtr_GetScreenToWorldMatrix_Internal_Il2CppStructArray_1_Matrix4x4_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666096);
			DeferredLights.NativeMethodInfoPtr_SetupMatrixConstants_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666097);
			DeferredLights.NativeMethodInfoPtr_PrecomputeLights_Private_Void_byref_NativeArray_1_UInt16_byref_NativeArray_1_UInt16_byref_NativeArray_1_VisibleLight_Boolean_Matrix4x4_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666098);
			DeferredLights.NativeMethodInfoPtr_HasStencilLightsOfType_Private_Boolean_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666099);
			DeferredLights.NativeMethodInfoPtr_RenderStencilLights_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666100);
			DeferredLights.NativeMethodInfoPtr_SetAdditionalLightsShadowsKeyword_Private_Void_byref_CommandBuffer_byref_RenderingData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666101);
			DeferredLights.NativeMethodInfoPtr_RenderStencilDirectionalLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666102);
			DeferredLights.NativeMethodInfoPtr_RenderStencilPointLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666103);
			DeferredLights.NativeMethodInfoPtr_RenderStencilSpotLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666104);
			DeferredLights.NativeMethodInfoPtr_RenderSSAOBeforeShading_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666105);
			DeferredLights.NativeMethodInfoPtr_RenderFog_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666106);
			DeferredLights.NativeMethodInfoPtr_InitStencilDeferredMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666107);
			DeferredLights.NativeMethodInfoPtr_CreateSphereMesh_Private_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666108);
			DeferredLights.NativeMethodInfoPtr_CreateHemisphereMesh_Private_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666109);
			DeferredLights.NativeMethodInfoPtr_CreateFullscreenMesh_Private_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, 100666110);
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0006396C File Offset: 0x00061B6C
		public unsafe int GBufferAlbedoIndex
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GBufferAlbedoIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000639A8 File Offset: 0x00061BA8
		public unsafe int GBufferSpecularMetallicIndex
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GBufferSpecularMetallicIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x000639E4 File Offset: 0x00061BE4
		public unsafe int GBufferNormalSmoothnessIndex
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GBufferNormalSmoothnessIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00063A20 File Offset: 0x00061C20
		public unsafe int GBufferLightingIndex
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GBufferLightingIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00063A5C File Offset: 0x00061C5C
		public unsafe int GbufferDepthIndex
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 624339, RefRangeEnd = 624344, XrefRangeStart = 624339, XrefRangeEnd = 624339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GbufferDepthIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00063A98 File Offset: 0x00061C98
		public unsafe int GBufferRenderingLayers
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 624348, RefRangeEnd = 624354, XrefRangeStart = 624344, XrefRangeEnd = 624348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GBufferRenderingLayers_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00063AD4 File Offset: 0x00061CD4
		public unsafe int GBufferShadowMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 624358, RefRangeEnd = 624359, XrefRangeStart = 624354, XrefRangeEnd = 624358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GBufferShadowMask_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00063B10 File Offset: 0x00061D10
		public unsafe int GBufferSliceCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 624363, RefRangeEnd = 624366, XrefRangeStart = 624359, XrefRangeEnd = 624363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GBufferSliceCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00063B4C File Offset: 0x00061D4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 624374, RefRangeEnd = 624379, XrefRangeStart = 624366, XrefRangeEnd = 624374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsFormat GetGBufferFormat(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_GetGBufferFormat_Internal_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00063B98 File Offset: 0x00061D98
		public unsafe bool UseShadowMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_UseShadowMask_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00063BD4 File Offset: 0x00061DD4
		public unsafe bool UseRenderingLayers
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 624383, RefRangeEnd = 624389, XrefRangeStart = 624379, XrefRangeEnd = 624383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_UseRenderingLayers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00063C10 File Offset: 0x00061E10
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00063C4C File Offset: 0x00061E4C
		public unsafe RenderingLayerUtils.MaskSize RenderingLayerMaskSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_RenderingLayerMaskSize_Internal_get_MaskSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_RenderingLayerMaskSize_Internal_set_Void_MaskSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00063C8C File Offset: 0x00061E8C
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00063CC8 File Offset: 0x00061EC8
		public unsafe bool UseDecalLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_UseDecalLayers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_UseDecalLayers_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00063D08 File Offset: 0x00061F08
		public unsafe bool UseLightLayers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624389, XrefRangeEnd = 624393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_UseLightLayers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00063D44 File Offset: 0x00061F44
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x00063D80 File Offset: 0x00061F80
		public unsafe bool UseRenderPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_UseRenderPass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_UseRenderPass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00063DC0 File Offset: 0x00061FC0
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x00063DFC File Offset: 0x00061FFC
		public unsafe bool HasDepthPrepass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_HasDepthPrepass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_HasDepthPrepass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00063E3C File Offset: 0x0006203C
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x00063E78 File Offset: 0x00062078
		public unsafe bool HasNormalPrepass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_HasNormalPrepass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_HasNormalPrepass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00063EB8 File Offset: 0x000620B8
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x00063EF4 File Offset: 0x000620F4
		public unsafe bool HasRenderingLayerPrepass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_HasRenderingLayerPrepass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_HasRenderingLayerPrepass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00063F34 File Offset: 0x00062134
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x00063F70 File Offset: 0x00062170
		public unsafe bool IsOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_IsOverlay_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_IsOverlay_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00063FB0 File Offset: 0x000621B0
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x00063FEC File Offset: 0x000621EC
		public unsafe bool AccurateGbufferNormals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_AccurateGbufferNormals_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_AccurateGbufferNormals_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x0006402C File Offset: 0x0006222C
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x00064068 File Offset: 0x00062268
		public unsafe MixedLightingSetup MixedLightingSetup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_MixedLightingSetup_Internal_get_MixedLightingSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_MixedLightingSetup_Internal_set_Void_MixedLightingSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x000640A8 File Offset: 0x000622A8
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x000640E4 File Offset: 0x000622E4
		public unsafe bool UseJobSystem
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_UseJobSystem_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_UseJobSystem_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00064124 File Offset: 0x00062324
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x00064160 File Offset: 0x00062360
		public unsafe int RenderWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_RenderWidth_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_RenderWidth_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000641A0 File Offset: 0x000623A0
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x000641DC File Offset: 0x000623DC
		public unsafe int RenderHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_RenderHeight_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_RenderHeight_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x0006421C File Offset: 0x0006241C
		// (set) Token: 0x0600174E RID: 5966 RVA: 0x0006425C File Offset: 0x0006245C
		public unsafe Il2CppReferenceArray<RTHandle> GbufferAttachments
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GbufferAttachments_Internal_get_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_GbufferAttachments_Internal_set_Void_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000642A0 File Offset: 0x000624A0
		// (set) Token: 0x06001750 RID: 5968 RVA: 0x000642E0 File Offset: 0x000624E0
		public unsafe Il2CppStructArray<TextureHandle> GbufferTextureHandles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GbufferTextureHandles_Internal_get_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_GbufferTextureHandles_Internal_set_Void_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x00064324 File Offset: 0x00062524
		// (set) Token: 0x06001752 RID: 5970 RVA: 0x00064364 File Offset: 0x00062564
		public unsafe Il2CppReferenceArray<RTHandle> DeferredInputAttachments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_DeferredInputAttachments_Internal_get_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_DeferredInputAttachments_Internal_set_Void_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x000643A8 File Offset: 0x000625A8
		// (set) Token: 0x06001754 RID: 5972 RVA: 0x000643E8 File Offset: 0x000625E8
		public unsafe Il2CppStructArray<bool> DeferredInputIsTransient
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_DeferredInputIsTransient_Internal_get_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_DeferredInputIsTransient_Internal_set_Void_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0006442C File Offset: 0x0006262C
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x0006446C File Offset: 0x0006266C
		public unsafe RTHandle DepthAttachment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_DepthAttachment_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_DepthAttachment_Internal_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x000644B0 File Offset: 0x000626B0
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x000644F0 File Offset: 0x000626F0
		public unsafe RTHandle DepthCopyTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_DepthCopyTexture_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_DepthCopyTexture_Internal_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x00064534 File Offset: 0x00062734
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x00064574 File Offset: 0x00062774
		public unsafe Il2CppStructArray<GraphicsFormat> GbufferFormats
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_GbufferFormats_Internal_get_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_GbufferFormats_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x000645B8 File Offset: 0x000627B8
		// (set) Token: 0x0600175C RID: 5980 RVA: 0x000645F8 File Offset: 0x000627F8
		public unsafe RTHandle DepthAttachmentHandle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_get_DepthAttachmentHandle_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_set_DepthAttachmentHandle_Internal_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0006463C File Offset: 0x0006283C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624438, RefRangeEnd = 624439, XrefRangeStart = 624393, XrefRangeEnd = 624438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeferredLights(DeferredLights.InitParams initParams, bool useNativeRenderPass = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(initParams));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useNativeRenderPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr__ctor_Internal_Void_InitParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0006469C File Offset: 0x0006289C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624512, RefRangeEnd = 624513, XrefRangeStart = 624439, XrefRangeEnd = 624512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_SetupLights_Internal_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000646F0 File Offset: 0x000628F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624527, RefRangeEnd = 624529, XrefRangeStart = 624513, XrefRangeEnd = 624527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveMixedLightingMode(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_ResolveMixedLightingMode_Internal_Void_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00064734 File Offset: 0x00062934
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 624530, RefRangeEnd = 624533, XrefRangeStart = 624529, XrefRangeEnd = 624530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableFramebufferFetchInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_DisableFramebufferFetchInput_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00064768 File Offset: 0x00062968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624538, RefRangeEnd = 624539, XrefRangeStart = 624533, XrefRangeEnd = 624538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseGbufferResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_ReleaseGbufferResources_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0006479C File Offset: 0x0006299C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 624554, RefRangeEnd = 624557, XrefRangeStart = 624539, XrefRangeEnd = 624554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReAllocateGBufferIfNeeded(RenderTextureDescriptor gbufferSlice, int gbufferIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gbufferSlice;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gbufferIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_ReAllocateGBufferIfNeeded_Internal_Void_RenderTextureDescriptor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000647E8 File Offset: 0x000629E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624596, RefRangeEnd = 624598, XrefRangeStart = 624557, XrefRangeEnd = 624596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateGbufferResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_CreateGbufferResources_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0006481C File Offset: 0x00062A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624612, RefRangeEnd = 624613, XrefRangeStart = 624598, XrefRangeEnd = 624612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeferredInputAttachments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_UpdateDeferredInputAttachments_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00064850 File Offset: 0x00062A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624619, RefRangeEnd = 624620, XrefRangeStart = 624613, XrefRangeEnd = 624619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRuntimeSupportedThisFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_IsRuntimeSupportedThisFrame_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0006488C File Offset: 0x00062A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624643, RefRangeEnd = 624645, XrefRangeStart = 624620, XrefRangeEnd = 624643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(ref RenderingData renderingData, AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, RTHandle depthCopyTexture, RTHandle depthAttachment, RTHandle colorAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalLightsShadowCasterPass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasDepthPrepass;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasNormalPrepass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRenderingLayerPrepass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthCopyTexture);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_Setup_Public_Void_byref_RenderingData_AdditionalLightsShadowCasterPass_Boolean_Boolean_Boolean_RTHandle_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00064944 File Offset: 0x00062B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(additionalLightsShadowCasterPass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_Setup_Internal_Void_AdditionalLightsShadowCasterPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00064988 File Offset: 0x00062B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624657, RefRangeEnd = 624658, XrefRangeStart = 624645, XrefRangeEnd = 624657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_OnCameraCleanup_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000649CC File Offset: 0x00062BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624673, RefRangeEnd = 624674, XrefRangeStart = 624658, XrefRangeEnd = 624673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StencilState OverwriteStencil(StencilState s, int stencilWriteMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilWriteMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_OverwriteStencil_Internal_Static_StencilState_StencilState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00064A18 File Offset: 0x00062C18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 624699, RefRangeEnd = 624703, XrefRangeStart = 624674, XrefRangeEnd = 624699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref block;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilWriteMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_OverwriteStencil_Internal_Static_RenderStateBlock_RenderStateBlock_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00064A74 File Offset: 0x00062C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624719, RefRangeEnd = 624720, XrefRangeStart = 624703, XrefRangeEnd = 624719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStencilPartial(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_ClearStencilPartial_Internal_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00064AB8 File Offset: 0x00062CB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624777, RefRangeEnd = 624779, XrefRangeStart = 624720, XrefRangeEnd = 624777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteDeferredPass(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_ExecuteDeferredPass_Internal_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00064B0C File Offset: 0x00062D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624779, XrefRangeEnd = 624780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00064B64 File Offset: 0x00062D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624796, RefRangeEnd = 624798, XrefRangeStart = 624780, XrefRangeEnd = 624796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_CommandBuffer_byref_LightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00064BBC File Offset: 0x00062DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624810, RefRangeEnd = 624812, XrefRangeStart = 624798, XrefRangeEnd = 624810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Matrix4x4> GetScreenToWorldMatrix(CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_GetScreenToWorldMatrix_Internal_Il2CppStructArray_1_Matrix4x4_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00064C14 File Offset: 0x00062E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624812, XrefRangeEnd = 624819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMatrixConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_SetupMatrixConstants_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00064C6C File Offset: 0x00062E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624851, RefRangeEnd = 624852, XrefRangeStart = 624819, XrefRangeEnd = 624851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrecomputeLights(out NativeArray<ushort> stencilVisLights, out NativeArray<ushort> stencilVisLightOffsets, ref NativeArray<VisibleLight> visibleLights, bool hasAdditionalLights, Matrix4x4 view, bool isOrthographic, float zNear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(visibleLights);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasAdditionalLights;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOrthographic;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_PrecomputeLights_Private_Void_byref_NativeArray_1_UInt16_byref_NativeArray_1_UInt16_byref_NativeArray_1_VisibleLight_Boolean_Matrix4x4_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			stencilVisLights = ((intPtr5 == 0) ? null : new NativeArray<ushort>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			stencilVisLightOffsets = ((intPtr6 == 0) ? null : new NativeArray<ushort>(intPtr6));
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00064D2C File Offset: 0x00062F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 624856, RefRangeEnd = 624859, XrefRangeStart = 624852, XrefRangeEnd = 624856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasStencilLightsOfType(LightType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_HasStencilLightsOfType_Private_Boolean_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00064D78 File Offset: 0x00062F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624888, RefRangeEnd = 624889, XrefRangeStart = 624859, XrefRangeEnd = 624888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderStencilLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_RenderStencilLights_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00064DDC File Offset: 0x00062FDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 624897, RefRangeEnd = 624900, XrefRangeStart = 624889, XrefRangeEnd = 624897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditionalLightsShadowsKeyword(ref CommandBuffer cmd, ref RenderingData renderingData, bool hasDeferredShadows)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasDeferredShadows;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_SetAdditionalLightsShadowsKeyword_Private_Void_byref_CommandBuffer_byref_RenderingData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cmd = ((intPtr4 == 0) ? null : new CommandBuffer(intPtr4));
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00064E54 File Offset: 0x00063054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624977, RefRangeEnd = 624978, XrefRangeStart = 624900, XrefRangeEnd = 624977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderStencilDirectionalLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights, int mainLightIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(visibleLights));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainLightIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_RenderStencilDirectionalLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00064ED0 File Offset: 0x000630D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625055, RefRangeEnd = 625056, XrefRangeStart = 624978, XrefRangeEnd = 625055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderStencilPointLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(visibleLights));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_RenderStencilPointLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00064F3C File Offset: 0x0006313C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625149, RefRangeEnd = 625150, XrefRangeStart = 625056, XrefRangeEnd = 625149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderStencilSpotLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(visibleLights));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_RenderStencilSpotLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00064FA8 File Offset: 0x000631A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625150, XrefRangeEnd = 625162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderSSAOBeforeShading(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_RenderSSAOBeforeShading_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00065000 File Offset: 0x00063200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625180, RefRangeEnd = 625181, XrefRangeStart = 625162, XrefRangeEnd = 625180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderFog(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_RenderFog_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00065064 File Offset: 0x00063264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 625232, RefRangeEnd = 625234, XrefRangeStart = 625181, XrefRangeEnd = 625232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStencilDeferredMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_InitStencilDeferredMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00065098 File Offset: 0x00063298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625250, RefRangeEnd = 625251, XrefRangeStart = 625234, XrefRangeEnd = 625250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateSphereMesh()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_CreateSphereMesh_Private_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x000650CC File Offset: 0x000632CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625267, RefRangeEnd = 625268, XrefRangeStart = 625251, XrefRangeEnd = 625267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateHemisphereMesh()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_CreateHemisphereMesh_Private_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00065100 File Offset: 0x00063300
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 625281, RefRangeEnd = 625286, XrefRangeStart = 625268, XrefRangeEnd = 625281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateFullscreenMesh()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredLights.NativeMethodInfoPtr_CreateFullscreenMesh_Private_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0000D457 File Offset: 0x0000B657
		public DeferredLights(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x00065134 File Offset: 0x00063334
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x0000D460 File Offset: 0x0000B660
		public unsafe static Il2CppStringArray k_GBufferNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_GBufferNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_GBufferNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x0006515C File Offset: 0x0006335C
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x0000D472 File Offset: 0x0000B672
		public unsafe static Il2CppStringArray k_StencilDeferredPassNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_StencilDeferredPassNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_StencilDeferredPassNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00065184 File Offset: 0x00063384
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x0000D484 File Offset: 0x0000B684
		public unsafe static ushort k_InvalidLightOffset
		{
			get
			{
				ushort num;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_InvalidLightOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_InvalidLightOffset, (void*)(&value));
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x000651A0 File Offset: 0x000633A0
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0000D492 File Offset: 0x0000B692
		public unsafe static string k_SetupLights
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_SetupLights, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_SetupLights, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000651C0 File Offset: 0x000633C0
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public unsafe static string k_DeferredPass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_DeferredPass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_DeferredPass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x000651E0 File Offset: 0x000633E0
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
		public unsafe static string k_DeferredStencilPass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_DeferredStencilPass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_DeferredStencilPass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x00065200 File Offset: 0x00063400
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		public unsafe static string k_DeferredFogPass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_DeferredFogPass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_DeferredFogPass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x00065220 File Offset: 0x00063420
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x0000D4DA File Offset: 0x0000B6DA
		public unsafe static string k_ClearStencilPartial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_ClearStencilPartial, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_ClearStencilPartial, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x00065240 File Offset: 0x00063440
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		public unsafe static string k_SetupLightConstants
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_k_SetupLightConstants, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_k_SetupLightConstants, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x00065260 File Offset: 0x00063460
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x0000D4FE File Offset: 0x0000B6FE
		public unsafe static float kStencilShapeGuard
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_kStencilShapeGuard, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_kStencilShapeGuard, (void*)(&value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x0006527C File Offset: 0x0006347C
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x0000D50C File Offset: 0x0000B70C
		public unsafe static ProfilingSampler m_ProfilingSetupLights
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_m_ProfilingSetupLights, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_m_ProfilingSetupLights, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x000652A4 File Offset: 0x000634A4
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x0000D51E File Offset: 0x0000B71E
		public unsafe static ProfilingSampler m_ProfilingDeferredPass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_m_ProfilingDeferredPass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_m_ProfilingDeferredPass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x000652CC File Offset: 0x000634CC
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000D530 File Offset: 0x0000B730
		public unsafe static ProfilingSampler m_ProfilingSetupLightConstants
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeferredLights.NativeFieldInfoPtr_m_ProfilingSetupLightConstants, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredLights.NativeFieldInfoPtr_m_ProfilingSetupLightConstants, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x000652F4 File Offset: 0x000634F4
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000D542 File Offset: 0x0000B742
		public unsafe RenderingLayerUtils.MaskSize _RenderingLayerMaskSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__RenderingLayerMaskSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__RenderingLayerMaskSize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0006531C File Offset: 0x0006351C
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000D55D File Offset: 0x0000B75D
		public unsafe bool _UseDecalLayers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__UseDecalLayers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__UseDecalLayers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00065344 File Offset: 0x00063544
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x0000D578 File Offset: 0x0000B778
		public unsafe bool _UseRenderPass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__UseRenderPass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__UseRenderPass_k__BackingField)) = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0006536C File Offset: 0x0006356C
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0000D593 File Offset: 0x0000B793
		public unsafe bool _HasDepthPrepass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__HasDepthPrepass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__HasDepthPrepass_k__BackingField)) = value;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00065394 File Offset: 0x00063594
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0000D5AE File Offset: 0x0000B7AE
		public unsafe bool _HasNormalPrepass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__HasNormalPrepass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__HasNormalPrepass_k__BackingField)) = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x000653BC File Offset: 0x000635BC
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000D5C9 File Offset: 0x0000B7C9
		public unsafe bool _HasRenderingLayerPrepass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__HasRenderingLayerPrepass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__HasRenderingLayerPrepass_k__BackingField)) = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000653E4 File Offset: 0x000635E4
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		public unsafe bool _IsOverlay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__IsOverlay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__IsOverlay_k__BackingField)) = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0006540C File Offset: 0x0006360C
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0000D5FF File Offset: 0x0000B7FF
		public unsafe bool _AccurateGbufferNormals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__AccurateGbufferNormals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__AccurateGbufferNormals_k__BackingField)) = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00065434 File Offset: 0x00063634
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x0000D61A File Offset: 0x0000B81A
		public unsafe MixedLightingSetup _MixedLightingSetup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__MixedLightingSetup_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__MixedLightingSetup_k__BackingField)) = value;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x0006545C File Offset: 0x0006365C
		// (set) Token: 0x060017AC RID: 6060 RVA: 0x0000D635 File Offset: 0x0000B835
		public unsafe bool _UseJobSystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__UseJobSystem_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__UseJobSystem_k__BackingField)) = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x00065484 File Offset: 0x00063684
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x0000D650 File Offset: 0x0000B850
		public unsafe int _RenderWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__RenderWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__RenderWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x000654AC File Offset: 0x000636AC
		// (set) Token: 0x060017B0 RID: 6064 RVA: 0x0000D66B File Offset: 0x0000B86B
		public unsafe int _RenderHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__RenderHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__RenderHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x000654D4 File Offset: 0x000636D4
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x0000D686 File Offset: 0x0000B886
		public unsafe Il2CppReferenceArray<RTHandle> _GbufferAttachments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__GbufferAttachments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__GbufferAttachments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00065504 File Offset: 0x00063704
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x0000D6A5 File Offset: 0x0000B8A5
		public unsafe Il2CppReferenceArray<RTHandle> GbufferRTHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_GbufferRTHandles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_GbufferRTHandles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00065534 File Offset: 0x00063734
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		public unsafe Il2CppStructArray<TextureHandle> _GbufferTextureHandles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__GbufferTextureHandles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__GbufferTextureHandles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00065564 File Offset: 0x00063764
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x0000D6E3 File Offset: 0x0000B8E3
		public unsafe Il2CppReferenceArray<RTHandle> _DeferredInputAttachments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DeferredInputAttachments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DeferredInputAttachments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00065594 File Offset: 0x00063794
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x0000D702 File Offset: 0x0000B902
		public unsafe Il2CppStructArray<bool> _DeferredInputIsTransient_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DeferredInputIsTransient_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DeferredInputIsTransient_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x000655C4 File Offset: 0x000637C4
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x0000D721 File Offset: 0x0000B921
		public unsafe RTHandle _DepthAttachment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DepthAttachment_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DepthAttachment_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x000655F4 File Offset: 0x000637F4
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0000D740 File Offset: 0x0000B940
		public unsafe RTHandle _DepthCopyTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DepthCopyTexture_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DepthCopyTexture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x00065624 File Offset: 0x00063824
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x0000D75F File Offset: 0x0000B95F
		public unsafe Il2CppStructArray<GraphicsFormat> _GbufferFormats_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__GbufferFormats_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__GbufferFormats_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00065654 File Offset: 0x00063854
		// (set) Token: 0x060017C2 RID: 6082 RVA: 0x0000D77E File Offset: 0x0000B97E
		public unsafe RTHandle _DepthAttachmentHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DepthAttachmentHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr__DepthAttachmentHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x00065684 File Offset: 0x00063884
		// (set) Token: 0x060017C4 RID: 6084 RVA: 0x0000D79D File Offset: 0x0000B99D
		public NativeArray<ushort> m_stencilVisLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_stencilVisLights);
				return new NativeArray<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_stencilVisLights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x000656B4 File Offset: 0x000638B4
		// (set) Token: 0x060017C6 RID: 6086 RVA: 0x0000D7CB File Offset: 0x0000B9CB
		public NativeArray<ushort> m_stencilVisLightOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_stencilVisLightOffsets);
				return new NativeArray<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_stencilVisLightOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x000656E4 File Offset: 0x000638E4
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0000D7F9 File Offset: 0x0000B9F9
		public unsafe AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditionalLightsShadowCasterPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x00065714 File Offset: 0x00063914
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x0000D818 File Offset: 0x0000BA18
		public unsafe Mesh m_SphereMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_SphereMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_SphereMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x00065744 File Offset: 0x00063944
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x0000D837 File Offset: 0x0000BA37
		public unsafe Mesh m_HemisphereMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_HemisphereMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_HemisphereMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00065774 File Offset: 0x00063974
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x0000D856 File Offset: 0x0000BA56
		public unsafe Mesh m_FullscreenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_FullscreenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_FullscreenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x000657A4 File Offset: 0x000639A4
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x0000D875 File Offset: 0x0000BA75
		public unsafe Material m_StencilDeferredMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_StencilDeferredMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_StencilDeferredMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x000657D4 File Offset: 0x000639D4
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0000D894 File Offset: 0x0000BA94
		public unsafe Il2CppStructArray<int> m_StencilDeferredPasses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_StencilDeferredPasses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_StencilDeferredPasses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00065804 File Offset: 0x00063A04
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0000D8B3 File Offset: 0x0000BAB3
		public unsafe Il2CppStructArray<Matrix4x4> m_ScreenToWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ScreenToWorld);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ScreenToWorld), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00065834 File Offset: 0x00063A34
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0000D8D2 File Offset: 0x0000BAD2
		public unsafe ProfilingSampler m_ProfilingSamplerDeferredStencilPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerDeferredStencilPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerDeferredStencilPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00065864 File Offset: 0x00063A64
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0000D8F1 File Offset: 0x0000BAF1
		public unsafe ProfilingSampler m_ProfilingSamplerDeferredFogPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerDeferredFogPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerDeferredFogPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x00065894 File Offset: 0x00063A94
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x0000D910 File Offset: 0x0000BB10
		public unsafe ProfilingSampler m_ProfilingSamplerClearStencilPartialPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerClearStencilPartialPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_ProfilingSamplerClearStencilPartialPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x000658C4 File Offset: 0x00063AC4
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x0000D92F File Offset: 0x0000BB2F
		public unsafe LightCookieManager m_LightCookieManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_LightCookieManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.NativeFieldInfoPtr_m_LightCookieManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeFieldInfoPtr_k_GBufferNames;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeFieldInfoPtr_k_StencilDeferredPassNames;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeFieldInfoPtr_k_InvalidLightOffset;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeFieldInfoPtr_k_SetupLights;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeFieldInfoPtr_k_DeferredPass;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_k_DeferredStencilPass;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr_k_DeferredFogPass;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_k_ClearStencilPartial;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeFieldInfoPtr_k_SetupLightConstants;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeFieldInfoPtr_kStencilShapeGuard;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSetupLights;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingDeferredPass;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSetupLightConstants;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr__RenderingLayerMaskSize_k__BackingField;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeFieldInfoPtr__UseDecalLayers_k__BackingField;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeFieldInfoPtr__UseRenderPass_k__BackingField;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeFieldInfoPtr__HasDepthPrepass_k__BackingField;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr__HasNormalPrepass_k__BackingField;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeFieldInfoPtr__HasRenderingLayerPrepass_k__BackingField;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeFieldInfoPtr__IsOverlay_k__BackingField;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr__AccurateGbufferNormals_k__BackingField;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr__MixedLightingSetup_k__BackingField;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr__UseJobSystem_k__BackingField;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr__RenderWidth_k__BackingField;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr__RenderHeight_k__BackingField;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeFieldInfoPtr__GbufferAttachments_k__BackingField;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr_GbufferRTHandles;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr__GbufferTextureHandles_k__BackingField;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeFieldInfoPtr__DeferredInputAttachments_k__BackingField;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeFieldInfoPtr__DeferredInputIsTransient_k__BackingField;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeFieldInfoPtr__DepthAttachment_k__BackingField;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeFieldInfoPtr__DepthCopyTexture_k__BackingField;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr__GbufferFormats_k__BackingField;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeFieldInfoPtr__DepthAttachmentHandle_k__BackingField;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeFieldInfoPtr_m_stencilVisLights;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr_m_stencilVisLightOffsets;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeFieldInfoPtr_m_SphereMesh;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeFieldInfoPtr_m_HemisphereMesh;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeFieldInfoPtr_m_FullscreenMesh;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilDeferredMaterial;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilDeferredPasses;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenToWorld;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerDeferredStencilPass;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerDeferredFogPass;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerClearStencilPartialPass;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieManager;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_get_GBufferAlbedoIndex_Internal_get_Int32_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_get_GBufferSpecularMetallicIndex_Internal_get_Int32_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_get_GBufferNormalSmoothnessIndex_Internal_get_Int32_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_get_GBufferLightingIndex_Internal_get_Int32_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_get_GbufferDepthIndex_Internal_get_Int32_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_get_GBufferRenderingLayers_Internal_get_Int32_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_get_GBufferShadowMask_Internal_get_Int32_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_get_GBufferSliceCount_Internal_get_Int32_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_GetGBufferFormat_Internal_GraphicsFormat_Int32_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_get_UseShadowMask_Internal_get_Boolean_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_get_UseRenderingLayers_Internal_get_Boolean_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderingLayerMaskSize_Internal_get_MaskSize_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_set_RenderingLayerMaskSize_Internal_set_Void_MaskSize_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDecalLayers_Internal_get_Boolean_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_set_UseDecalLayers_Internal_set_Void_Boolean_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_get_UseLightLayers_Internal_get_Boolean_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_get_UseRenderPass_Internal_get_Boolean_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_set_UseRenderPass_Internal_set_Void_Boolean_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDepthPrepass_Internal_get_Boolean_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_set_HasDepthPrepass_Internal_set_Void_Boolean_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNormalPrepass_Internal_get_Boolean_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_set_HasNormalPrepass_Internal_set_Void_Boolean_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRenderingLayerPrepass_Internal_get_Boolean_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_set_HasRenderingLayerPrepass_Internal_set_Void_Boolean_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOverlay_Internal_get_Boolean_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOverlay_Internal_set_Void_Boolean_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_get_AccurateGbufferNormals_Internal_get_Boolean_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_set_AccurateGbufferNormals_Internal_set_Void_Boolean_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_get_MixedLightingSetup_Internal_get_MixedLightingSetup_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_set_MixedLightingSetup_Internal_set_Void_MixedLightingSetup_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_get_UseJobSystem_Internal_get_Boolean_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_set_UseJobSystem_Internal_set_Void_Boolean_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderWidth_Internal_get_Int32_0;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr_set_RenderWidth_Internal_set_Void_Int32_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderHeight_Internal_get_Int32_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_set_RenderHeight_Internal_set_Void_Int32_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_get_GbufferAttachments_Internal_get_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_set_GbufferAttachments_Internal_set_Void_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_get_GbufferTextureHandles_Internal_get_Il2CppStructArray_1_TextureHandle_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_set_GbufferTextureHandles_Internal_set_Void_Il2CppStructArray_1_TextureHandle_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_get_DeferredInputAttachments_Internal_get_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_set_DeferredInputAttachments_Internal_set_Void_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr_get_DeferredInputIsTransient_Internal_get_Il2CppStructArray_1_Boolean_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_set_DeferredInputIsTransient_Internal_set_Void_Il2CppStructArray_1_Boolean_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_get_DepthAttachment_Internal_get_RTHandle_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_set_DepthAttachment_Internal_set_Void_RTHandle_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_get_DepthCopyTexture_Internal_get_RTHandle_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_set_DepthCopyTexture_Internal_set_Void_RTHandle_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_get_GbufferFormats_Internal_get_Il2CppStructArray_1_GraphicsFormat_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_set_GbufferFormats_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_get_DepthAttachmentHandle_Internal_get_RTHandle_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_set_DepthAttachmentHandle_Internal_set_Void_RTHandle_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InitParams_Boolean_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_SetupLights_Internal_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_ResolveMixedLightingMode_Internal_Void_byref_RenderingData_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_DisableFramebufferFetchInput_Internal_Void_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseGbufferResources_Internal_Void_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_ReAllocateGBufferIfNeeded_Internal_Void_RenderTextureDescriptor_Int32_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_CreateGbufferResources_Internal_Void_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeferredInputAttachments_Internal_Void_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_IsRuntimeSupportedThisFrame_Internal_Boolean_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_RenderingData_AdditionalLightsShadowCasterPass_Boolean_Boolean_Boolean_RTHandle_RTHandle_RTHandle_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Void_AdditionalLightsShadowCasterPass_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Void_CommandBuffer_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_OverwriteStencil_Internal_Static_StencilState_StencilState_Int32_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_OverwriteStencil_Internal_Static_RenderStateBlock_RenderStateBlock_Int32_Int32_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_ClearStencilPartial_Internal_Void_CommandBuffer_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDeferredPass_Internal_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_CommandBuffer_byref_LightData_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenToWorldMatrix_Internal_Il2CppStructArray_1_Matrix4x4_CameraData_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_SetupMatrixConstants_Private_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_PrecomputeLights_Private_Void_byref_NativeArray_1_UInt16_byref_NativeArray_1_UInt16_byref_NativeArray_1_VisibleLight_Boolean_Matrix4x4_Boolean_Single_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_HasStencilLightsOfType_Private_Boolean_LightType_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_RenderStencilLights_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalLightsShadowsKeyword_Private_Void_byref_CommandBuffer_byref_RenderingData_Boolean_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_RenderStencilDirectionalLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_Int32_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_RenderStencilPointLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_RenderStencilSpotLights_Private_Void_CommandBuffer_byref_RenderingData_NativeArray_1_VisibleLight_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_RenderSSAOBeforeShading_Private_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_RenderFog_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_InitStencilDeferredMaterial_Private_Void_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_CreateSphereMesh_Private_Static_Mesh_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_CreateHemisphereMesh_Private_Static_Mesh_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_CreateFullscreenMesh_Private_Static_Mesh_0;

		// Token: 0x020001E3 RID: 483
		public static class ShaderConstants : Object
		{
			// Token: 0x06002190 RID: 8592 RVA: 0x00081D64 File Offset: 0x0007FF64
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderConstants()
			{
				Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "ShaderConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr);
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitStencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitStencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitStencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitStencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitStencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitStencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_StencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_StencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_StencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitPunctualStencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitPunctualStencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitPunctualStencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitPunctualStencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitPunctualStencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitPunctualStencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitDirStencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitDirStencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LitDirStencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitDirStencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitDirStencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SimpleLitDirStencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_ClearStencilRef");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_ClearStencilReadMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_ClearStencilWriteMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__ScreenToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_ScreenToWorld");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_MainLightPosition");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_MainLightColor");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_MainLightLayerMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SpotLightScale");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SpotLightBias");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_SpotLightGuard");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightPosWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LightPosWS");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LightColor");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LightAttenuation");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightOcclusionProbInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LightOcclusionProbInfo");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LightDirection");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LightFlags");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__ShadowLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_ShadowLightIndex");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_LightLayerMask");
				DeferredLights.ShaderConstants.NativeFieldInfoPtr__CookieLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.ShaderConstants>.NativeClassPtr, "_CookieLightIndex");
			}

			// Token: 0x06002191 RID: 8593 RVA: 0x000133C7 File Offset: 0x000115C7
			public ShaderConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C11 RID: 3089
			// (get) Token: 0x06002192 RID: 8594 RVA: 0x000820B0 File Offset: 0x000802B0
			// (set) Token: 0x06002193 RID: 8595 RVA: 0x000133D0 File Offset: 0x000115D0
			public unsafe static int _LitStencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C12 RID: 3090
			// (get) Token: 0x06002194 RID: 8596 RVA: 0x000820CC File Offset: 0x000802CC
			// (set) Token: 0x06002195 RID: 8597 RVA: 0x000133DE File Offset: 0x000115DE
			public unsafe static int _LitStencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C13 RID: 3091
			// (get) Token: 0x06002196 RID: 8598 RVA: 0x000820E8 File Offset: 0x000802E8
			// (set) Token: 0x06002197 RID: 8599 RVA: 0x000133EC File Offset: 0x000115EC
			public unsafe static int _LitStencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitStencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C14 RID: 3092
			// (get) Token: 0x06002198 RID: 8600 RVA: 0x00082104 File Offset: 0x00080304
			// (set) Token: 0x06002199 RID: 8601 RVA: 0x000133FA File Offset: 0x000115FA
			public unsafe static int _SimpleLitStencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C15 RID: 3093
			// (get) Token: 0x0600219A RID: 8602 RVA: 0x00082120 File Offset: 0x00080320
			// (set) Token: 0x0600219B RID: 8603 RVA: 0x00013408 File Offset: 0x00011608
			public unsafe static int _SimpleLitStencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C16 RID: 3094
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x0008213C File Offset: 0x0008033C
			// (set) Token: 0x0600219D RID: 8605 RVA: 0x00013416 File Offset: 0x00011616
			public unsafe static int _SimpleLitStencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitStencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C17 RID: 3095
			// (get) Token: 0x0600219E RID: 8606 RVA: 0x00082158 File Offset: 0x00080358
			// (set) Token: 0x0600219F RID: 8607 RVA: 0x00013424 File Offset: 0x00011624
			public unsafe static int _StencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C18 RID: 3096
			// (get) Token: 0x060021A0 RID: 8608 RVA: 0x00082174 File Offset: 0x00080374
			// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00013432 File Offset: 0x00011632
			public unsafe static int _StencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C19 RID: 3097
			// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00082190 File Offset: 0x00080390
			// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00013440 File Offset: 0x00011640
			public unsafe static int _StencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__StencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C1A RID: 3098
			// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000821AC File Offset: 0x000803AC
			// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0001344E File Offset: 0x0001164E
			public unsafe static int _LitPunctualStencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C1B RID: 3099
			// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000821C8 File Offset: 0x000803C8
			// (set) Token: 0x060021A7 RID: 8615 RVA: 0x0001345C File Offset: 0x0001165C
			public unsafe static int _LitPunctualStencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C1C RID: 3100
			// (get) Token: 0x060021A8 RID: 8616 RVA: 0x000821E4 File Offset: 0x000803E4
			// (set) Token: 0x060021A9 RID: 8617 RVA: 0x0001346A File Offset: 0x0001166A
			public unsafe static int _LitPunctualStencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitPunctualStencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x060021AA RID: 8618 RVA: 0x00082200 File Offset: 0x00080400
			// (set) Token: 0x060021AB RID: 8619 RVA: 0x00013478 File Offset: 0x00011678
			public unsafe static int _SimpleLitPunctualStencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C1E RID: 3102
			// (get) Token: 0x060021AC RID: 8620 RVA: 0x0008221C File Offset: 0x0008041C
			// (set) Token: 0x060021AD RID: 8621 RVA: 0x00013486 File Offset: 0x00011686
			public unsafe static int _SimpleLitPunctualStencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C1F RID: 3103
			// (get) Token: 0x060021AE RID: 8622 RVA: 0x00082238 File Offset: 0x00080438
			// (set) Token: 0x060021AF RID: 8623 RVA: 0x00013494 File Offset: 0x00011694
			public unsafe static int _SimpleLitPunctualStencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitPunctualStencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00082254 File Offset: 0x00080454
			// (set) Token: 0x060021B1 RID: 8625 RVA: 0x000134A2 File Offset: 0x000116A2
			public unsafe static int _LitDirStencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00082270 File Offset: 0x00080470
			// (set) Token: 0x060021B3 RID: 8627 RVA: 0x000134B0 File Offset: 0x000116B0
			public unsafe static int _LitDirStencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0008228C File Offset: 0x0008048C
			// (set) Token: 0x060021B5 RID: 8629 RVA: 0x000134BE File Offset: 0x000116BE
			public unsafe static int _LitDirStencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LitDirStencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C23 RID: 3107
			// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000822A8 File Offset: 0x000804A8
			// (set) Token: 0x060021B7 RID: 8631 RVA: 0x000134CC File Offset: 0x000116CC
			public unsafe static int _SimpleLitDirStencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C24 RID: 3108
			// (get) Token: 0x060021B8 RID: 8632 RVA: 0x000822C4 File Offset: 0x000804C4
			// (set) Token: 0x060021B9 RID: 8633 RVA: 0x000134DA File Offset: 0x000116DA
			public unsafe static int _SimpleLitDirStencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C25 RID: 3109
			// (get) Token: 0x060021BA RID: 8634 RVA: 0x000822E0 File Offset: 0x000804E0
			// (set) Token: 0x060021BB RID: 8635 RVA: 0x000134E8 File Offset: 0x000116E8
			public unsafe static int _SimpleLitDirStencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SimpleLitDirStencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C26 RID: 3110
			// (get) Token: 0x060021BC RID: 8636 RVA: 0x000822FC File Offset: 0x000804FC
			// (set) Token: 0x060021BD RID: 8637 RVA: 0x000134F6 File Offset: 0x000116F6
			public unsafe static int _ClearStencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000C27 RID: 3111
			// (get) Token: 0x060021BE RID: 8638 RVA: 0x00082318 File Offset: 0x00080518
			// (set) Token: 0x060021BF RID: 8639 RVA: 0x00013504 File Offset: 0x00011704
			public unsafe static int _ClearStencilReadMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilReadMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilReadMask, (void*)(&value));
				}
			}

			// Token: 0x17000C28 RID: 3112
			// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00082334 File Offset: 0x00080534
			// (set) Token: 0x060021C1 RID: 8641 RVA: 0x00013512 File Offset: 0x00011712
			public unsafe static int _ClearStencilWriteMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilWriteMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ClearStencilWriteMask, (void*)(&value));
				}
			}

			// Token: 0x17000C29 RID: 3113
			// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00082350 File Offset: 0x00080550
			// (set) Token: 0x060021C3 RID: 8643 RVA: 0x00013520 File Offset: 0x00011720
			public unsafe static int _ScreenToWorld
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ScreenToWorld, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ScreenToWorld, (void*)(&value));
				}
			}

			// Token: 0x17000C2A RID: 3114
			// (get) Token: 0x060021C4 RID: 8644 RVA: 0x0008236C File Offset: 0x0008056C
			// (set) Token: 0x060021C5 RID: 8645 RVA: 0x0001352E File Offset: 0x0001172E
			public unsafe static int _MainLightPosition
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightPosition, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightPosition, (void*)(&value));
				}
			}

			// Token: 0x17000C2B RID: 3115
			// (get) Token: 0x060021C6 RID: 8646 RVA: 0x00082388 File Offset: 0x00080588
			// (set) Token: 0x060021C7 RID: 8647 RVA: 0x0001353C File Offset: 0x0001173C
			public unsafe static int _MainLightColor
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightColor, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightColor, (void*)(&value));
				}
			}

			// Token: 0x17000C2C RID: 3116
			// (get) Token: 0x060021C8 RID: 8648 RVA: 0x000823A4 File Offset: 0x000805A4
			// (set) Token: 0x060021C9 RID: 8649 RVA: 0x0001354A File Offset: 0x0001174A
			public unsafe static int _MainLightLayerMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightLayerMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__MainLightLayerMask, (void*)(&value));
				}
			}

			// Token: 0x17000C2D RID: 3117
			// (get) Token: 0x060021CA RID: 8650 RVA: 0x000823C0 File Offset: 0x000805C0
			// (set) Token: 0x060021CB RID: 8651 RVA: 0x00013558 File Offset: 0x00011758
			public unsafe static int _SpotLightScale
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightScale, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightScale, (void*)(&value));
				}
			}

			// Token: 0x17000C2E RID: 3118
			// (get) Token: 0x060021CC RID: 8652 RVA: 0x000823DC File Offset: 0x000805DC
			// (set) Token: 0x060021CD RID: 8653 RVA: 0x00013566 File Offset: 0x00011766
			public unsafe static int _SpotLightBias
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightBias, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightBias, (void*)(&value));
				}
			}

			// Token: 0x17000C2F RID: 3119
			// (get) Token: 0x060021CE RID: 8654 RVA: 0x000823F8 File Offset: 0x000805F8
			// (set) Token: 0x060021CF RID: 8655 RVA: 0x00013574 File Offset: 0x00011774
			public unsafe static int _SpotLightGuard
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightGuard, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__SpotLightGuard, (void*)(&value));
				}
			}

			// Token: 0x17000C30 RID: 3120
			// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00082414 File Offset: 0x00080614
			// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00013582 File Offset: 0x00011782
			public unsafe static int _LightPosWS
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightPosWS, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightPosWS, (void*)(&value));
				}
			}

			// Token: 0x17000C31 RID: 3121
			// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00082430 File Offset: 0x00080630
			// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00013590 File Offset: 0x00011790
			public unsafe static int _LightColor
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightColor, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightColor, (void*)(&value));
				}
			}

			// Token: 0x17000C32 RID: 3122
			// (get) Token: 0x060021D4 RID: 8660 RVA: 0x0008244C File Offset: 0x0008064C
			// (set) Token: 0x060021D5 RID: 8661 RVA: 0x0001359E File Offset: 0x0001179E
			public unsafe static int _LightAttenuation
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightAttenuation, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightAttenuation, (void*)(&value));
				}
			}

			// Token: 0x17000C33 RID: 3123
			// (get) Token: 0x060021D6 RID: 8662 RVA: 0x00082468 File Offset: 0x00080668
			// (set) Token: 0x060021D7 RID: 8663 RVA: 0x000135AC File Offset: 0x000117AC
			public unsafe static int _LightOcclusionProbInfo
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightOcclusionProbInfo, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightOcclusionProbInfo, (void*)(&value));
				}
			}

			// Token: 0x17000C34 RID: 3124
			// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00082484 File Offset: 0x00080684
			// (set) Token: 0x060021D9 RID: 8665 RVA: 0x000135BA File Offset: 0x000117BA
			public unsafe static int _LightDirection
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightDirection, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightDirection, (void*)(&value));
				}
			}

			// Token: 0x17000C35 RID: 3125
			// (get) Token: 0x060021DA RID: 8666 RVA: 0x000824A0 File Offset: 0x000806A0
			// (set) Token: 0x060021DB RID: 8667 RVA: 0x000135C8 File Offset: 0x000117C8
			public unsafe static int _LightFlags
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightFlags, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightFlags, (void*)(&value));
				}
			}

			// Token: 0x17000C36 RID: 3126
			// (get) Token: 0x060021DC RID: 8668 RVA: 0x000824BC File Offset: 0x000806BC
			// (set) Token: 0x060021DD RID: 8669 RVA: 0x000135D6 File Offset: 0x000117D6
			public unsafe static int _ShadowLightIndex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ShadowLightIndex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__ShadowLightIndex, (void*)(&value));
				}
			}

			// Token: 0x17000C37 RID: 3127
			// (get) Token: 0x060021DE RID: 8670 RVA: 0x000824D8 File Offset: 0x000806D8
			// (set) Token: 0x060021DF RID: 8671 RVA: 0x000135E4 File Offset: 0x000117E4
			public unsafe static int _LightLayerMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightLayerMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__LightLayerMask, (void*)(&value));
				}
			}

			// Token: 0x17000C38 RID: 3128
			// (get) Token: 0x060021E0 RID: 8672 RVA: 0x000824F4 File Offset: 0x000806F4
			// (set) Token: 0x060021E1 RID: 8673 RVA: 0x000135F2 File Offset: 0x000117F2
			public unsafe static int _CookieLightIndex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__CookieLightIndex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredLights.ShaderConstants.NativeFieldInfoPtr__CookieLightIndex, (void*)(&value));
				}
			}

			// Token: 0x040017C1 RID: 6081
			private static readonly IntPtr NativeFieldInfoPtr__LitStencilRef;

			// Token: 0x040017C2 RID: 6082
			private static readonly IntPtr NativeFieldInfoPtr__LitStencilReadMask;

			// Token: 0x040017C3 RID: 6083
			private static readonly IntPtr NativeFieldInfoPtr__LitStencilWriteMask;

			// Token: 0x040017C4 RID: 6084
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitStencilRef;

			// Token: 0x040017C5 RID: 6085
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitStencilReadMask;

			// Token: 0x040017C6 RID: 6086
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitStencilWriteMask;

			// Token: 0x040017C7 RID: 6087
			private static readonly IntPtr NativeFieldInfoPtr__StencilRef;

			// Token: 0x040017C8 RID: 6088
			private static readonly IntPtr NativeFieldInfoPtr__StencilReadMask;

			// Token: 0x040017C9 RID: 6089
			private static readonly IntPtr NativeFieldInfoPtr__StencilWriteMask;

			// Token: 0x040017CA RID: 6090
			private static readonly IntPtr NativeFieldInfoPtr__LitPunctualStencilRef;

			// Token: 0x040017CB RID: 6091
			private static readonly IntPtr NativeFieldInfoPtr__LitPunctualStencilReadMask;

			// Token: 0x040017CC RID: 6092
			private static readonly IntPtr NativeFieldInfoPtr__LitPunctualStencilWriteMask;

			// Token: 0x040017CD RID: 6093
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitPunctualStencilRef;

			// Token: 0x040017CE RID: 6094
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitPunctualStencilReadMask;

			// Token: 0x040017CF RID: 6095
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitPunctualStencilWriteMask;

			// Token: 0x040017D0 RID: 6096
			private static readonly IntPtr NativeFieldInfoPtr__LitDirStencilRef;

			// Token: 0x040017D1 RID: 6097
			private static readonly IntPtr NativeFieldInfoPtr__LitDirStencilReadMask;

			// Token: 0x040017D2 RID: 6098
			private static readonly IntPtr NativeFieldInfoPtr__LitDirStencilWriteMask;

			// Token: 0x040017D3 RID: 6099
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitDirStencilRef;

			// Token: 0x040017D4 RID: 6100
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitDirStencilReadMask;

			// Token: 0x040017D5 RID: 6101
			private static readonly IntPtr NativeFieldInfoPtr__SimpleLitDirStencilWriteMask;

			// Token: 0x040017D6 RID: 6102
			private static readonly IntPtr NativeFieldInfoPtr__ClearStencilRef;

			// Token: 0x040017D7 RID: 6103
			private static readonly IntPtr NativeFieldInfoPtr__ClearStencilReadMask;

			// Token: 0x040017D8 RID: 6104
			private static readonly IntPtr NativeFieldInfoPtr__ClearStencilWriteMask;

			// Token: 0x040017D9 RID: 6105
			private static readonly IntPtr NativeFieldInfoPtr__ScreenToWorld;

			// Token: 0x040017DA RID: 6106
			private static readonly IntPtr NativeFieldInfoPtr__MainLightPosition;

			// Token: 0x040017DB RID: 6107
			private static readonly IntPtr NativeFieldInfoPtr__MainLightColor;

			// Token: 0x040017DC RID: 6108
			private static readonly IntPtr NativeFieldInfoPtr__MainLightLayerMask;

			// Token: 0x040017DD RID: 6109
			private static readonly IntPtr NativeFieldInfoPtr__SpotLightScale;

			// Token: 0x040017DE RID: 6110
			private static readonly IntPtr NativeFieldInfoPtr__SpotLightBias;

			// Token: 0x040017DF RID: 6111
			private static readonly IntPtr NativeFieldInfoPtr__SpotLightGuard;

			// Token: 0x040017E0 RID: 6112
			private static readonly IntPtr NativeFieldInfoPtr__LightPosWS;

			// Token: 0x040017E1 RID: 6113
			private static readonly IntPtr NativeFieldInfoPtr__LightColor;

			// Token: 0x040017E2 RID: 6114
			private static readonly IntPtr NativeFieldInfoPtr__LightAttenuation;

			// Token: 0x040017E3 RID: 6115
			private static readonly IntPtr NativeFieldInfoPtr__LightOcclusionProbInfo;

			// Token: 0x040017E4 RID: 6116
			private static readonly IntPtr NativeFieldInfoPtr__LightDirection;

			// Token: 0x040017E5 RID: 6117
			private static readonly IntPtr NativeFieldInfoPtr__LightFlags;

			// Token: 0x040017E6 RID: 6118
			private static readonly IntPtr NativeFieldInfoPtr__ShadowLightIndex;

			// Token: 0x040017E7 RID: 6119
			private static readonly IntPtr NativeFieldInfoPtr__LightLayerMask;

			// Token: 0x040017E8 RID: 6120
			private static readonly IntPtr NativeFieldInfoPtr__CookieLightIndex;
		}

		// Token: 0x020001E4 RID: 484
		public enum StencilDeferredPasses
		{
			// Token: 0x040017EA RID: 6122
			StencilVolume,
			// Token: 0x040017EB RID: 6123
			PunctualLit,
			// Token: 0x040017EC RID: 6124
			PunctualSimpleLit,
			// Token: 0x040017ED RID: 6125
			DirectionalLit,
			// Token: 0x040017EE RID: 6126
			DirectionalSimpleLit,
			// Token: 0x040017EF RID: 6127
			ClearStencilPartial,
			// Token: 0x040017F0 RID: 6128
			Fog,
			// Token: 0x040017F1 RID: 6129
			SSAOOnly
		}

		// Token: 0x020001E5 RID: 485
		public sealed class InitParams : ValueType
		{
			// Token: 0x060021E2 RID: 8674 RVA: 0x00082510 File Offset: 0x00080710
			// Note: this type is marked as 'beforefieldinit'.
			static InitParams()
			{
				Il2CppClassPointerStore<DeferredLights.InitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeferredLights>.NativeClassPtr, "InitParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredLights.InitParams>.NativeClassPtr);
				DeferredLights.InitParams.NativeFieldInfoPtr_stencilDeferredMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.InitParams>.NativeClassPtr, "stencilDeferredMaterial");
				DeferredLights.InitParams.NativeFieldInfoPtr_lightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredLights.InitParams>.NativeClassPtr, "lightCookieManager");
			}

			// Token: 0x060021E3 RID: 8675 RVA: 0x00013600 File Offset: 0x00011800
			public InitParams(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060021E4 RID: 8676 RVA: 0x00013609 File Offset: 0x00011809
			public InitParams()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeferredLights.InitParams>.NativeClassPtr))
			{
			}

			// Token: 0x17000C39 RID: 3129
			// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00082564 File Offset: 0x00080764
			// (set) Token: 0x060021E6 RID: 8678 RVA: 0x0001361B File Offset: 0x0001181B
			public unsafe Material stencilDeferredMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.InitParams.NativeFieldInfoPtr_stencilDeferredMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.InitParams.NativeFieldInfoPtr_stencilDeferredMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C3A RID: 3130
			// (get) Token: 0x060021E7 RID: 8679 RVA: 0x00082594 File Offset: 0x00080794
			// (set) Token: 0x060021E8 RID: 8680 RVA: 0x0001363A File Offset: 0x0001183A
			public unsafe LightCookieManager lightCookieManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.InitParams.NativeFieldInfoPtr_lightCookieManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredLights.InitParams.NativeFieldInfoPtr_lightCookieManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017F2 RID: 6130
			private static readonly IntPtr NativeFieldInfoPtr_stencilDeferredMaterial;

			// Token: 0x040017F3 RID: 6131
			private static readonly IntPtr NativeFieldInfoPtr_lightCookieManager;
		}
	}
}
