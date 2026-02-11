using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000F0 RID: 240
	public sealed class UniversalRenderer : ScriptableRenderer
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x00054A9C File Offset: 0x00052C9C
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalRenderer()
		{
			Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr);
			UniversalRenderer.NativeFieldInfoPtr_k_DepthStencilFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_DepthStencilFormat");
			UniversalRenderer.NativeFieldInfoPtr_k_DepthBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_DepthBufferBits");
			UniversalRenderer.NativeFieldInfoPtr_k_FinalBlitPassQueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_FinalBlitPassQueueOffset");
			UniversalRenderer.NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_AfterFinalBlitPassQueueOffset");
			UniversalRenderer.NativeFieldInfoPtr_k_DepthNormalsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_DepthNormalsOnly");
			UniversalRenderer.NativeFieldInfoPtr_m_Clustering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_Clustering");
			UniversalRenderer.NativeFieldInfoPtr_m_DepthPrepass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthPrepass");
			UniversalRenderer.NativeFieldInfoPtr_m_DepthNormalPrepass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthNormalPrepass");
			UniversalRenderer.NativeFieldInfoPtr_m_PrimedDepthCopyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_PrimedDepthCopyPass");
			UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MotionVectorPass");
			UniversalRenderer.NativeFieldInfoPtr_m_MainLightShadowCasterPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MainLightShadowCasterPass");
			UniversalRenderer.NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_AdditionalLightsShadowCasterPass");
			UniversalRenderer.NativeFieldInfoPtr_m_GBufferPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_GBufferPass");
			UniversalRenderer.NativeFieldInfoPtr_m_GBufferCopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_GBufferCopyDepthPass");
			UniversalRenderer.NativeFieldInfoPtr_m_DeferredPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DeferredPass");
			UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderOpaqueForwardOnlyPass");
			UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderOpaqueForwardPass");
			UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderOpaqueForwardWithRenderingLayersPass");
			UniversalRenderer.NativeFieldInfoPtr_m_DrawSkyboxPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DrawSkyboxPass");
			UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CopyDepthPass");
			UniversalRenderer.NativeFieldInfoPtr_m_CopyColorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CopyColorPass");
			UniversalRenderer.NativeFieldInfoPtr_m_TransparentSettingsPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_TransparentSettingsPass");
			UniversalRenderer.NativeFieldInfoPtr_m_RenderTransparentForwardPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderTransparentForwardPass");
			UniversalRenderer.NativeFieldInfoPtr_m_OnRenderObjectCallbackPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_OnRenderObjectCallbackPass");
			UniversalRenderer.NativeFieldInfoPtr_m_FinalBlitPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_FinalBlitPass");
			UniversalRenderer.NativeFieldInfoPtr_m_CapturePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CapturePass");
			UniversalRenderer.NativeFieldInfoPtr_m_XROcclusionMeshPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_XROcclusionMeshPass");
			UniversalRenderer.NativeFieldInfoPtr_m_XRCopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_XRCopyDepthPass");
			UniversalRenderer.NativeFieldInfoPtr_m_DrawOffscreenUIPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DrawOffscreenUIPass");
			UniversalRenderer.NativeFieldInfoPtr_m_DrawOverlayUIPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DrawOverlayUIPass");
			UniversalRenderer.NativeFieldInfoPtr_m_ColorBufferSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ColorBufferSystem");
			UniversalRenderer.NativeFieldInfoPtr_m_ActiveCameraColorAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ActiveCameraColorAttachment");
			UniversalRenderer.NativeFieldInfoPtr_m_ColorFrontBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ColorFrontBuffer");
			UniversalRenderer.NativeFieldInfoPtr_m_ActiveCameraDepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ActiveCameraDepthAttachment");
			UniversalRenderer.NativeFieldInfoPtr_m_CameraDepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraDepthAttachment");
			UniversalRenderer.NativeFieldInfoPtr_m_XRTargetHandleAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_XRTargetHandleAlias");
			UniversalRenderer.NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraDepthAttachment_D3d_11");
			UniversalRenderer.NativeFieldInfoPtr_m_DepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthTexture");
			UniversalRenderer.NativeFieldInfoPtr_m_NormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_NormalsTexture");
			UniversalRenderer.NativeFieldInfoPtr_m_DecalLayersTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DecalLayersTexture");
			UniversalRenderer.NativeFieldInfoPtr_m_OpaqueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_OpaqueColor");
			UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MotionVectorColor");
			UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MotionVectorDepth");
			UniversalRenderer.NativeFieldInfoPtr_m_ForwardLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ForwardLights");
			UniversalRenderer.NativeFieldInfoPtr_m_DeferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DeferredLights");
			UniversalRenderer.NativeFieldInfoPtr_m_RenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderingMode");
			UniversalRenderer.NativeFieldInfoPtr_m_DepthPrimingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthPrimingMode");
			UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CopyDepthMode");
			UniversalRenderer.NativeFieldInfoPtr_m_DepthPrimingRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthPrimingRecommended");
			UniversalRenderer.NativeFieldInfoPtr_m_DefaultStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DefaultStencilState");
			UniversalRenderer.NativeFieldInfoPtr_m_LightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_LightCookieManager");
			UniversalRenderer.NativeFieldInfoPtr_m_IntermediateTextureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_IntermediateTextureMode");
			UniversalRenderer.NativeFieldInfoPtr_m_VulkanEnablePreTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_VulkanEnablePreTransform");
			UniversalRenderer.NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_BlitMaterial");
			UniversalRenderer.NativeFieldInfoPtr_m_BlitHDRMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_BlitHDRMaterial");
			UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CopyDepthMaterial");
			UniversalRenderer.NativeFieldInfoPtr_m_SamplingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_SamplingMaterial");
			UniversalRenderer.NativeFieldInfoPtr_m_StencilDeferredMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_StencilDeferredMaterial");
			UniversalRenderer.NativeFieldInfoPtr_m_CameraMotionVecMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraMotionVecMaterial");
			UniversalRenderer.NativeFieldInfoPtr_m_ObjectMotionVecMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ObjectMotionVecMaterial");
			UniversalRenderer.NativeFieldInfoPtr_m_PostProcessPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_PostProcessPasses");
			UniversalRenderer.NativeFieldInfoPtr_m_RenderGraphCameraColorHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderGraphCameraColorHandle");
			UniversalRenderer.NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderGraphCameraDepthHandle");
			UniversalRenderer.NativeFieldInfoPtr_m_ActiveRenderGraphColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ActiveRenderGraphColor");
			UniversalRenderer.NativeFieldInfoPtr_m_ActiveRenderGraphDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ActiveRenderGraphDepth");
			UniversalRenderer.NativeFieldInfoPtr_m_TargetIsBackbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_TargetIsBackbuffer");
			UniversalRenderer.NativeFieldInfoPtr_frameResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "frameResources");
			UniversalRenderer.NativeFieldInfoPtr_m_UseIntermediateTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_UseIntermediateTexture");
			UniversalRenderer.NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665606);
			UniversalRenderer.NativeMethodInfoPtr_get_renderingModeRequested_Internal_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665607);
			UniversalRenderer.NativeMethodInfoPtr_get_renderingModeActual_Internal_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665608);
			UniversalRenderer.NativeMethodInfoPtr_get_accurateGbufferNormals_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665609);
			UniversalRenderer.NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665610);
			UniversalRenderer.NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665611);
			UniversalRenderer.NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665612);
			UniversalRenderer.NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665613);
			UniversalRenderer.NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665614);
			UniversalRenderer.NativeMethodInfoPtr_get_colorGradingLut_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665615);
			UniversalRenderer.NativeMethodInfoPtr_get_deferredLights_Internal_get_DeferredLights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665616);
			UniversalRenderer.NativeMethodInfoPtr__ctor_Public_Void_UniversalRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665617);
			UniversalRenderer.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665618);
			UniversalRenderer.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665619);
			UniversalRenderer.NativeMethodInfoPtr_SetupFinalPassDebug_Private_Void_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665620);
			UniversalRenderer.NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665621);
			UniversalRenderer.NativeMethodInfoPtr_IsDepthPrimingEnabled_Private_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665622);
			UniversalRenderer.NativeMethodInfoPtr_IsWebGL_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665623);
			UniversalRenderer.NativeMethodInfoPtr_IsGLESDevice_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665624);
			UniversalRenderer.NativeMethodInfoPtr_IsGLDevice_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665625);
			UniversalRenderer.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665626);
			UniversalRenderer.NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665627);
			UniversalRenderer.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665628);
			UniversalRenderer.NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665629);
			UniversalRenderer.NativeMethodInfoPtr_EnqueueDeferred_Private_Void_byref_RenderingData_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665630);
			UniversalRenderer.NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665631);
			UniversalRenderer.NativeMethodInfoPtr_CreateCameraRenderTarget_Private_Void_ScriptableRenderContext_byref_RenderTextureDescriptor_Boolean_CommandBuffer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665632);
			UniversalRenderer.NativeMethodInfoPtr_PlatformRequiresExplicitMsaaResolve_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665633);
			UniversalRenderer.NativeMethodInfoPtr_RequiresIntermediateColorTexture_Private_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665634);
			UniversalRenderer.NativeMethodInfoPtr_CanCopyDepth_Private_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665635);
			UniversalRenderer.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665636);
			UniversalRenderer.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665637);
			UniversalRenderer.NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665638);
			UniversalRenderer.NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665639);
			UniversalRenderer.NativeMethodInfoPtr_CleanupRenderGraphResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665640);
			UniversalRenderer.NativeMethodInfoPtr_CreateRenderGraphTexture_Internal_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_FilterMode_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665641);
			UniversalRenderer.NativeMethodInfoPtr_RequiresColorAndDepthTextures_Private_Boolean_byref_Boolean_byref_Boolean_byref_RenderingData_RenderPassInputSummary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665642);
			UniversalRenderer.NativeMethodInfoPtr_CreateRenderGraphCameraRenderTargets_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665643);
			UniversalRenderer.NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665644);
			UniversalRenderer.NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665645);
			UniversalRenderer.NativeMethodInfoPtr_OnBeforeRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665646);
			UniversalRenderer.NativeMethodInfoPtr_OnMainRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665647);
			UniversalRenderer.NativeMethodInfoPtr_OnAfterRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665648);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00055378 File Offset: 0x00053578
		[CallerCount(0)]
		public unsafe override int SupportedCameraStackingTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000553B4 File Offset: 0x000535B4
		public unsafe RenderingMode renderingModeRequested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_renderingModeRequested_Internal_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x000553F0 File Offset: 0x000535F0
		public unsafe RenderingMode renderingModeActual
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 619250, RefRangeEnd = 619281, XrefRangeStart = 619247, XrefRangeEnd = 619250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_renderingModeActual_Internal_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x0005542C File Offset: 0x0005362C
		public unsafe bool accurateGbufferNormals
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 619281, RefRangeEnd = 619284, XrefRangeStart = 619281, XrefRangeEnd = 619281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_accurateGbufferNormals_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00055468 File Offset: 0x00053668
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x000554A4 File Offset: 0x000536A4
		public unsafe DepthPrimingMode depthPrimingMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000554E4 File Offset: 0x000536E4
		public unsafe ColorGradingLutPass colorGradingLutPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorGradingLutPass>(intPtr3) : null;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00055524 File Offset: 0x00053724
		public unsafe PostProcessPass postProcessPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr3) : null;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00055564 File Offset: 0x00053764
		public unsafe PostProcessPass finalPostProcessPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr3) : null;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x000555A4 File Offset: 0x000537A4
		public unsafe RTHandle colorGradingLut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_colorGradingLut_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x000555E4 File Offset: 0x000537E4
		public unsafe DeferredLights deferredLights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_get_deferredLights_Internal_get_DeferredLights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr3) : null;
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00055624 File Offset: 0x00053824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 619565, RefRangeEnd = 619566, XrefRangeStart = 619284, XrefRangeEnd = 619565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRenderer(UniversalRendererData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr__ctor_Public_Void_UniversalRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00055670 File Offset: 0x00053870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619566, XrefRangeEnd = 619598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000556B0 File Offset: 0x000538B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619598, XrefRangeEnd = 619611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseRenderTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000556E4 File Offset: 0x000538E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619611, XrefRangeEnd = 619622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFinalPassDebug(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_SetupFinalPassDebug_Private_Void_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00055728 File Offset: 0x00053928
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 619626, RefRangeEnd = 619634, XrefRangeStart = 619622, XrefRangeEnd = 619626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOffscreenDepthTexture([In] ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0005576C File Offset: 0x0005396C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 619641, RefRangeEnd = 619644, XrefRangeStart = 619634, XrefRangeEnd = 619641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDepthPrimingEnabled(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_IsDepthPrimingEnabled_Private_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000557BC File Offset: 0x000539BC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWebGL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_IsWebGL_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000557F8 File Offset: 0x000539F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619644, XrefRangeEnd = 619645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGLESDevice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_IsGLESDevice_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00055834 File Offset: 0x00053A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 615017, RefRangeEnd = 615018, XrefRangeStart = 615017, XrefRangeEnd = 615018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGLDevice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_IsGLDevice_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00055870 File Offset: 0x00053A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619645, XrefRangeEnd = 620030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000558C4 File Offset: 0x00053AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620030, XrefRangeEnd = 620033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00055918 File Offset: 0x00053B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620033, XrefRangeEnd = 620081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullingParameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0005596C File Offset: 0x00053B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620081, XrefRangeEnd = 620085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinishRendering(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000559B0 File Offset: 0x00053BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620085, XrefRangeEnd = 620093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasDepthPrepass;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasNormalPrepass;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRenderingLayerPrepass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyMainShadow;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyAdditionalShadow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_EnqueueDeferred_Private_Void_byref_RenderingData_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00055A3C File Offset: 0x00053C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 620102, RefRangeEnd = 620104, XrefRangeStart = 620093, XrefRangeEnd = 620102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRenderer.RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00055A8C File Offset: 0x00053C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 620167, RefRangeEnd = 620168, XrefRangeStart = 620104, XrefRangeEnd = 620167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool primedDepth, CommandBuffer cmd, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref primedDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_CreateCameraRenderTarget_Private_Void_ScriptableRenderContext_byref_RenderTextureDescriptor_Boolean_CommandBuffer_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00055B10 File Offset: 0x00053D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620168, XrefRangeEnd = 620173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PlatformRequiresExplicitMsaaResolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_PlatformRequiresExplicitMsaaResolve_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00055B4C File Offset: 0x00053D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 620192, RefRangeEnd = 620194, XrefRangeStart = 620173, XrefRangeEnd = 620192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequiresIntermediateColorTexture(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_RequiresIntermediateColorTexture_Private_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00055B9C File Offset: 0x00053D9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 620204, RefRangeEnd = 620207, XrefRangeStart = 620194, XrefRangeEnd = 620204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCopyDepth(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_CanCopyDepth_Private_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00055BEC File Offset: 0x00053DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620207, XrefRangeEnd = 620223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SwapColorBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00055C30 File Offset: 0x00053E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620223, XrefRangeEnd = 620225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00055C80 File Offset: 0x00053E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620225, XrefRangeEnd = 620227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00055CD0 File Offset: 0x00053ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620227, XrefRangeEnd = 620229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EnableSwapBufferMSAA(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00055D10 File Offset: 0x00053F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620229, XrefRangeEnd = 620238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupRenderGraphResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_CleanupRenderGraphResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00055D44 File Offset: 0x00053F44
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 620244, RefRangeEnd = 620255, XrefRangeStart = 620238, XrefRangeEnd = 620244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clear;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_CreateRenderGraphTexture_Internal_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_FilterMode_TextureWrapMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00055DD0 File Offset: 0x00053FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 620271, RefRangeEnd = 620272, XrefRangeStart = 620255, XrefRangeEnd = 620271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequiresColorAndDepthTextures(out bool createColorTexture, out bool createDepthTexture, ref RenderingData renderingData, UniversalRenderer.RenderPassInputSummary renderPassInputs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &createColorTexture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &createDepthTexture;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderPassInputs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_RequiresColorAndDepthTextures_Private_Boolean_byref_Boolean_byref_Boolean_byref_RenderingData_RenderPassInputSummary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00055E48 File Offset: 0x00054048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 620378, RefRangeEnd = 620379, XrefRangeStart = 620272, XrefRangeEnd = 620378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_CreateRenderGraphCameraRenderTargets_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00055EAC File Offset: 0x000540AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620379, XrefRangeEnd = 620404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00055F10 File Offset: 0x00054110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620404, XrefRangeEnd = 620406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00055F64 File Offset: 0x00054164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620406, XrefRangeEnd = 620412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeforeRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_OnBeforeRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00055FC8 File Offset: 0x000541C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 620461, RefRangeEnd = 620462, XrefRangeStart = 620412, XrefRangeEnd = 620461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_OnMainRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0005602C File Offset: 0x0005422C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620462, XrefRangeEnd = 620478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAfterRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.NativeMethodInfoPtr_OnAfterRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0000AC4E File Offset: 0x00008E4E
		public UniversalRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00056090 File Offset: 0x00054290
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x0000AC57 File Offset: 0x00008E57
		public unsafe static GraphicsFormat k_DepthStencilFormat
		{
			get
			{
				GraphicsFormat graphicsFormat;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_k_DepthStencilFormat, (void*)(&graphicsFormat));
				return graphicsFormat;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_k_DepthStencilFormat, (void*)(&value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000560AC File Offset: 0x000542AC
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x0000AC65 File Offset: 0x00008E65
		public unsafe static int k_DepthBufferBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_k_DepthBufferBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_k_DepthBufferBits, (void*)(&value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000560C8 File Offset: 0x000542C8
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x0000AC73 File Offset: 0x00008E73
		public unsafe static int k_FinalBlitPassQueueOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_k_FinalBlitPassQueueOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_k_FinalBlitPassQueueOffset, (void*)(&value));
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x000560E4 File Offset: 0x000542E4
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0000AC81 File Offset: 0x00008E81
		public unsafe static int k_AfterFinalBlitPassQueueOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset, (void*)(&value));
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00056100 File Offset: 0x00054300
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0000AC8F File Offset: 0x00008E8F
		public unsafe static List<ShaderTagId> k_DepthNormalsOnly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_k_DepthNormalsOnly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_k_DepthNormalsOnly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00056128 File Offset: 0x00054328
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x0000ACA1 File Offset: 0x00008EA1
		public unsafe bool m_Clustering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_Clustering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_Clustering)) = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00056150 File Offset: 0x00054350
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x0000ACBC File Offset: 0x00008EBC
		public unsafe DepthOnlyPass m_DepthPrepass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthPrepass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOnlyPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthPrepass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00056180 File Offset: 0x00054380
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x0000ACDB File Offset: 0x00008EDB
		public unsafe DepthNormalOnlyPass m_DepthNormalPrepass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthNormalPrepass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthNormalOnlyPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthNormalPrepass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000561B0 File Offset: 0x000543B0
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x0000ACFA File Offset: 0x00008EFA
		public unsafe CopyDepthPass m_PrimedDepthCopyPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_PrimedDepthCopyPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_PrimedDepthCopyPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x000561E0 File Offset: 0x000543E0
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0000AD19 File Offset: 0x00008F19
		public unsafe MotionVectorRenderPass m_MotionVectorPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionVectorRenderPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00056210 File Offset: 0x00054410
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0000AD38 File Offset: 0x00008F38
		public unsafe MainLightShadowCasterPass m_MainLightShadowCasterPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MainLightShadowCasterPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainLightShadowCasterPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MainLightShadowCasterPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00056240 File Offset: 0x00054440
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0000AD57 File Offset: 0x00008F57
		public unsafe AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditionalLightsShadowCasterPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00056270 File Offset: 0x00054470
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x0000AD76 File Offset: 0x00008F76
		public unsafe GBufferPass m_GBufferPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_GBufferPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GBufferPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_GBufferPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000562A0 File Offset: 0x000544A0
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x0000AD95 File Offset: 0x00008F95
		public unsafe CopyDepthPass m_GBufferCopyDepthPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_GBufferCopyDepthPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_GBufferCopyDepthPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000562D0 File Offset: 0x000544D0
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		public unsafe DeferredPass m_DeferredPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DeferredPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DeferredPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00056300 File Offset: 0x00054500
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x0000ADD3 File Offset: 0x00008FD3
		public unsafe DrawObjectsPass m_RenderOpaqueForwardOnlyPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawObjectsPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00056330 File Offset: 0x00054530
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x0000ADF2 File Offset: 0x00008FF2
		public unsafe DrawObjectsPass m_RenderOpaqueForwardPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawObjectsPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00056360 File Offset: 0x00054560
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x0000AE11 File Offset: 0x00009011
		public unsafe DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawObjectsWithRenderingLayersPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00056390 File Offset: 0x00054590
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x0000AE30 File Offset: 0x00009030
		public unsafe DrawSkyboxPass m_DrawSkyboxPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DrawSkyboxPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawSkyboxPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DrawSkyboxPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000563C0 File Offset: 0x000545C0
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x0000AE4F File Offset: 0x0000904F
		public unsafe CopyDepthPass m_CopyDepthPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000563F0 File Offset: 0x000545F0
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0000AE6E File Offset: 0x0000906E
		public unsafe CopyColorPass m_CopyColorPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyColorPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyColorPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyColorPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00056420 File Offset: 0x00054620
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x0000AE8D File Offset: 0x0000908D
		public unsafe TransparentSettingsPass m_TransparentSettingsPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_TransparentSettingsPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransparentSettingsPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_TransparentSettingsPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x00056450 File Offset: 0x00054650
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x0000AEAC File Offset: 0x000090AC
		public unsafe DrawObjectsPass m_RenderTransparentForwardPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderTransparentForwardPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawObjectsPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderTransparentForwardPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x00056480 File Offset: 0x00054680
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x0000AECB File Offset: 0x000090CB
		public unsafe InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_OnRenderObjectCallbackPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokeOnRenderObjectCallbackPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_OnRenderObjectCallbackPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000564B0 File Offset: 0x000546B0
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x0000AEEA File Offset: 0x000090EA
		public unsafe FinalBlitPass m_FinalBlitPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_FinalBlitPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalBlitPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_FinalBlitPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x000564E0 File Offset: 0x000546E0
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0000AF09 File Offset: 0x00009109
		public unsafe CapturePass m_CapturePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CapturePass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CapturePass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CapturePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00056510 File Offset: 0x00054710
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0000AF28 File Offset: 0x00009128
		public unsafe XROcclusionMeshPass m_XROcclusionMeshPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_XROcclusionMeshPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XROcclusionMeshPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_XROcclusionMeshPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00056540 File Offset: 0x00054740
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x0000AF47 File Offset: 0x00009147
		public unsafe CopyDepthPass m_XRCopyDepthPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_XRCopyDepthPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_XRCopyDepthPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00056570 File Offset: 0x00054770
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x0000AF66 File Offset: 0x00009166
		public unsafe DrawScreenSpaceUIPass m_DrawOffscreenUIPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DrawOffscreenUIPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DrawOffscreenUIPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x000565A0 File Offset: 0x000547A0
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x0000AF85 File Offset: 0x00009185
		public unsafe DrawScreenSpaceUIPass m_DrawOverlayUIPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DrawOverlayUIPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DrawOverlayUIPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x000565D0 File Offset: 0x000547D0
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0000AFA4 File Offset: 0x000091A4
		public unsafe RenderTargetBufferSystem m_ColorBufferSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ColorBufferSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTargetBufferSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ColorBufferSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00056600 File Offset: 0x00054800
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0000AFC3 File Offset: 0x000091C3
		public unsafe RTHandle m_ActiveCameraColorAttachment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ActiveCameraColorAttachment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ActiveCameraColorAttachment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00056630 File Offset: 0x00054830
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0000AFE2 File Offset: 0x000091E2
		public unsafe RTHandle m_ColorFrontBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ColorFrontBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ColorFrontBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00056660 File Offset: 0x00054860
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0000B001 File Offset: 0x00009201
		public unsafe RTHandle m_ActiveCameraDepthAttachment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ActiveCameraDepthAttachment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ActiveCameraDepthAttachment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00056690 File Offset: 0x00054890
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x0000B020 File Offset: 0x00009220
		public unsafe RTHandle m_CameraDepthAttachment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CameraDepthAttachment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CameraDepthAttachment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000566C0 File Offset: 0x000548C0
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x0000B03F File Offset: 0x0000923F
		public unsafe RTHandle m_XRTargetHandleAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_XRTargetHandleAlias);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_XRTargetHandleAlias), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000566F0 File Offset: 0x000548F0
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x0000B05E File Offset: 0x0000925E
		public unsafe RTHandle m_CameraDepthAttachment_D3d_11
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00056720 File Offset: 0x00054920
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x0000B07D File Offset: 0x0000927D
		public unsafe RTHandle m_DepthTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00056750 File Offset: 0x00054950
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x0000B09C File Offset: 0x0000929C
		public unsafe RTHandle m_NormalsTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_NormalsTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_NormalsTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00056780 File Offset: 0x00054980
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x0000B0BB File Offset: 0x000092BB
		public unsafe RTHandle m_DecalLayersTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DecalLayersTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DecalLayersTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000567B0 File Offset: 0x000549B0
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x0000B0DA File Offset: 0x000092DA
		public unsafe RTHandle m_OpaqueColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_OpaqueColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_OpaqueColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x000567E0 File Offset: 0x000549E0
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x0000B0F9 File Offset: 0x000092F9
		public unsafe RTHandle m_MotionVectorColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00056810 File Offset: 0x00054A10
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x0000B118 File Offset: 0x00009318
		public unsafe RTHandle m_MotionVectorDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorDepth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_MotionVectorDepth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00056840 File Offset: 0x00054A40
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0000B137 File Offset: 0x00009337
		public unsafe ForwardLights m_ForwardLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ForwardLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ForwardLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ForwardLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00056870 File Offset: 0x00054A70
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0000B156 File Offset: 0x00009356
		public unsafe DeferredLights m_DeferredLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DeferredLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DeferredLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000568A0 File Offset: 0x00054AA0
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x0000B175 File Offset: 0x00009375
		public unsafe RenderingMode m_RenderingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_RenderingMode)) = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x000568C8 File Offset: 0x00054AC8
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x0000B190 File Offset: 0x00009390
		public unsafe DepthPrimingMode m_DepthPrimingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthPrimingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthPrimingMode)) = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000568F0 File Offset: 0x00054AF0
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x0000B1AB File Offset: 0x000093AB
		public unsafe CopyDepthMode m_CopyDepthMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthMode)) = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00056918 File Offset: 0x00054B18
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x0000B1C6 File Offset: 0x000093C6
		public unsafe bool m_DepthPrimingRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthPrimingRecommended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DepthPrimingRecommended)) = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00056940 File Offset: 0x00054B40
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0000B1E1 File Offset: 0x000093E1
		public unsafe StencilState m_DefaultStencilState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DefaultStencilState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_DefaultStencilState)) = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00056968 File Offset: 0x00054B68
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x0000B1FC File Offset: 0x000093FC
		public unsafe LightCookieManager m_LightCookieManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_LightCookieManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_LightCookieManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00056998 File Offset: 0x00054B98
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x0000B21B File Offset: 0x0000941B
		public unsafe IntermediateTextureMode m_IntermediateTextureMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_IntermediateTextureMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_IntermediateTextureMode)) = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000569C0 File Offset: 0x00054BC0
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0000B236 File Offset: 0x00009436
		public unsafe bool m_VulkanEnablePreTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_VulkanEnablePreTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_VulkanEnablePreTransform)) = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000569E8 File Offset: 0x00054BE8
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x0000B251 File Offset: 0x00009451
		public unsafe Material m_BlitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_BlitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_BlitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00056A18 File Offset: 0x00054C18
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x0000B270 File Offset: 0x00009470
		public unsafe Material m_BlitHDRMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_BlitHDRMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_BlitHDRMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00056A48 File Offset: 0x00054C48
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0000B28F File Offset: 0x0000948F
		public unsafe Material m_CopyDepthMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CopyDepthMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00056A78 File Offset: 0x00054C78
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0000B2AE File Offset: 0x000094AE
		public unsafe Material m_SamplingMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_SamplingMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_SamplingMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00056AA8 File Offset: 0x00054CA8
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0000B2CD File Offset: 0x000094CD
		public unsafe Material m_StencilDeferredMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_StencilDeferredMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_StencilDeferredMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00056AD8 File Offset: 0x00054CD8
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x0000B2EC File Offset: 0x000094EC
		public unsafe Material m_CameraMotionVecMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CameraMotionVecMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_CameraMotionVecMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00056B08 File Offset: 0x00054D08
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x0000B30B File Offset: 0x0000950B
		public unsafe Material m_ObjectMotionVecMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ObjectMotionVecMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_ObjectMotionVecMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00056B38 File Offset: 0x00054D38
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x0000B32A File Offset: 0x0000952A
		public PostProcessPasses m_PostProcessPasses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_PostProcessPasses);
				return new PostProcessPasses(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_PostProcessPasses), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00056B68 File Offset: 0x00054D68
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x0000B358 File Offset: 0x00009558
		public unsafe static RTHandle m_RenderGraphCameraColorHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_m_RenderGraphCameraColorHandle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_m_RenderGraphCameraColorHandle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00056B90 File Offset: 0x00054D90
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0000B36A File Offset: 0x0000956A
		public unsafe static RTHandle m_RenderGraphCameraDepthHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00056BB8 File Offset: 0x00054DB8
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x0000B37C File Offset: 0x0000957C
		public unsafe static TextureHandle m_ActiveRenderGraphColor
		{
			get
			{
				TextureHandle textureHandle;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_m_ActiveRenderGraphColor, (void*)(&textureHandle));
				return textureHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_m_ActiveRenderGraphColor, (void*)(&value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00056BD4 File Offset: 0x00054DD4
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x0000B38A File Offset: 0x0000958A
		public unsafe static TextureHandle m_ActiveRenderGraphDepth
		{
			get
			{
				TextureHandle textureHandle;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_m_ActiveRenderGraphDepth, (void*)(&textureHandle));
				return textureHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_m_ActiveRenderGraphDepth, (void*)(&value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00056BF0 File Offset: 0x00054DF0
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x0000B398 File Offset: 0x00009598
		public unsafe bool m_TargetIsBackbuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_TargetIsBackbuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_m_TargetIsBackbuffer)) = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00056C18 File Offset: 0x00054E18
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x0000B3B3 File Offset: 0x000095B3
		public unsafe UniversalRenderer.RenderGraphFrameResources frameResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_frameResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderer.RenderGraphFrameResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.NativeFieldInfoPtr_frameResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00056C48 File Offset: 0x00054E48
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x0000B3D2 File Offset: 0x000095D2
		public unsafe static bool m_UseIntermediateTexture
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.NativeFieldInfoPtr_m_UseIntermediateTexture, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.NativeFieldInfoPtr_m_UseIntermediateTexture, (void*)(&value));
			}
		}

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeFieldInfoPtr_k_DepthStencilFormat;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeFieldInfoPtr_k_DepthBufferBits;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeFieldInfoPtr_k_FinalBlitPassQueueOffset;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeFieldInfoPtr_k_DepthNormalsOnly;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeFieldInfoPtr_m_Clustering;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthPrepass;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthNormalPrepass;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeFieldInfoPtr_m_PrimedDepthCopyPass;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionVectorPass;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeFieldInfoPtr_m_MainLightShadowCasterPass;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeFieldInfoPtr_m_GBufferPass;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeFieldInfoPtr_m_GBufferCopyDepthPass;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredPass;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderOpaqueForwardPass;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawSkyboxPass;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthPass;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyColorPass;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeFieldInfoPtr_m_TransparentSettingsPass;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTransparentForwardPass;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeFieldInfoPtr_m_OnRenderObjectCallbackPass;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalBlitPass;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeFieldInfoPtr_m_CapturePass;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr_m_XROcclusionMeshPass;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_m_XRCopyDepthPass;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawOffscreenUIPass;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawOverlayUIPass;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorBufferSystem;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveCameraColorAttachment;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorFrontBuffer;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveCameraDepthAttachment;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraDepthAttachment;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_m_XRTargetHandleAlias;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthTexture;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalsTexture;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalLayersTexture;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeFieldInfoPtr_m_OpaqueColor;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionVectorColor;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionVectorDepth;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeFieldInfoPtr_m_ForwardLights;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredLights;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingMode;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthPrimingMode;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthMode;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthPrimingRecommended;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultStencilState;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieManager;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_m_IntermediateTextureMode;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr_m_VulkanEnablePreTransform;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterial;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitHDRMaterial;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthMaterial;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_m_SamplingMaterial;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilDeferredMaterial;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraMotionVecMaterial;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectMotionVecMaterial;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_m_PostProcessPasses;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraphCameraColorHandle;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveRenderGraphColor;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveRenderGraphDepth;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetIsBackbuffer;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeFieldInfoPtr_frameResources;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeFieldInfoPtr_m_UseIntermediateTexture;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingModeRequested_Internal_get_RenderingMode_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingModeActual_Internal_get_RenderingMode_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_get_accurateGbufferNormals_Internal_get_Boolean_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradingLut_Internal_get_RTHandle_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_get_deferredLights_Internal_get_DeferredLights_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UniversalRendererData_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_SetupFinalPassDebug_Private_Void_byref_CameraData_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_byref_CameraData_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_IsDepthPrimingEnabled_Private_Boolean_byref_CameraData_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_IsWebGL_Private_Boolean_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_IsGLESDevice_Private_Boolean_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_IsGLDevice_Private_Boolean_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_EnqueueDeferred_Private_Void_byref_RenderingData_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_byref_RenderingData_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_CreateCameraRenderTarget_Private_Void_ScriptableRenderContext_byref_RenderTextureDescriptor_Boolean_CommandBuffer_byref_CameraData_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_PlatformRequiresExplicitMsaaResolve_Private_Boolean_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_RequiresIntermediateColorTexture_Private_Boolean_byref_CameraData_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_CanCopyDepth_Private_Boolean_byref_CameraData_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRenderGraphResources_Private_Void_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderGraphTexture_Internal_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_FilterMode_TextureWrapMode_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_RequiresColorAndDepthTextures_Private_Boolean_byref_Boolean_byref_Boolean_byref_RenderingData_RenderPassInputSummary_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderGraphCameraRenderTargets_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_OnMainRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterRendering_Private_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x020001C8 RID: 456
		public new static class Profiling : Object
		{
			// Token: 0x06002062 RID: 8290 RVA: 0x0007E810 File Offset: 0x0007CA10
			// Note: this type is marked as 'beforefieldinit'.
			static Profiling()
			{
				Il2CppClassPointerStore<UniversalRenderer.Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "Profiling");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderer.Profiling>.NativeClassPtr);
				UniversalRenderer.Profiling.NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.Profiling>.NativeClassPtr, "k_Name");
				UniversalRenderer.Profiling.NativeFieldInfoPtr_createCameraRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.Profiling>.NativeClassPtr, "createCameraRenderTarget");
			}

			// Token: 0x06002063 RID: 8291 RVA: 0x00012859 File Offset: 0x00010A59
			public Profiling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA8 RID: 2984
			// (get) Token: 0x06002064 RID: 8292 RVA: 0x0007E864 File Offset: 0x0007CA64
			// (set) Token: 0x06002065 RID: 8293 RVA: 0x00012862 File Offset: 0x00010A62
			public unsafe static string k_Name
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.Profiling.NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.Profiling.NativeFieldInfoPtr_k_Name, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BA9 RID: 2985
			// (get) Token: 0x06002066 RID: 8294 RVA: 0x0007E884 File Offset: 0x0007CA84
			// (set) Token: 0x06002067 RID: 8295 RVA: 0x00012874 File Offset: 0x00010A74
			public unsafe static ProfilingSampler createCameraRenderTarget
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.Profiling.NativeFieldInfoPtr_createCameraRenderTarget, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.Profiling.NativeFieldInfoPtr_createCameraRenderTarget, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001715 RID: 5909
			private static readonly IntPtr NativeFieldInfoPtr_k_Name;

			// Token: 0x04001716 RID: 5910
			private static readonly IntPtr NativeFieldInfoPtr_createCameraRenderTarget;
		}

		// Token: 0x020001C9 RID: 457
		[StructLayout(2)]
		public struct RenderPassInputSummary
		{
			// Token: 0x06002068 RID: 8296 RVA: 0x0007E8AC File Offset: 0x0007CAAC
			// Note: this type is marked as 'beforefieldinit'.
			static RenderPassInputSummary()
			{
				Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "RenderPassInputSummary");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr);
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresDepthTexture");
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresDepthPrepass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresDepthPrepass");
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresNormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresNormalsTexture");
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresColorTexture");
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresColorTextureCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresColorTextureCreated");
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresMotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresMotionVectors");
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresDepthNormalAtEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresDepthNormalAtEvent");
				UniversalRenderer.RenderPassInputSummary.NativeFieldInfoPtr_requiresDepthTextureEarliestEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, "requiresDepthTextureEarliestEvent");
			}

			// Token: 0x06002069 RID: 8297 RVA: 0x00012886 File Offset: 0x00010A86
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniversalRenderer.RenderPassInputSummary>.NativeClassPtr, ref this));
			}

			// Token: 0x04001717 RID: 5911
			private static readonly IntPtr NativeFieldInfoPtr_requiresDepthTexture;

			// Token: 0x04001718 RID: 5912
			private static readonly IntPtr NativeFieldInfoPtr_requiresDepthPrepass;

			// Token: 0x04001719 RID: 5913
			private static readonly IntPtr NativeFieldInfoPtr_requiresNormalsTexture;

			// Token: 0x0400171A RID: 5914
			private static readonly IntPtr NativeFieldInfoPtr_requiresColorTexture;

			// Token: 0x0400171B RID: 5915
			private static readonly IntPtr NativeFieldInfoPtr_requiresColorTextureCreated;

			// Token: 0x0400171C RID: 5916
			private static readonly IntPtr NativeFieldInfoPtr_requiresMotionVectors;

			// Token: 0x0400171D RID: 5917
			private static readonly IntPtr NativeFieldInfoPtr_requiresDepthNormalAtEvent;

			// Token: 0x0400171E RID: 5918
			private static readonly IntPtr NativeFieldInfoPtr_requiresDepthTextureEarliestEvent;

			// Token: 0x0400171F RID: 5919
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool requiresDepthTexture;

			// Token: 0x04001720 RID: 5920
			[FieldOffset(1)]
			[MarshalAs(4)]
			public bool requiresDepthPrepass;

			// Token: 0x04001721 RID: 5921
			[FieldOffset(2)]
			[MarshalAs(4)]
			public bool requiresNormalsTexture;

			// Token: 0x04001722 RID: 5922
			[FieldOffset(3)]
			[MarshalAs(4)]
			public bool requiresColorTexture;

			// Token: 0x04001723 RID: 5923
			[FieldOffset(4)]
			[MarshalAs(4)]
			public bool requiresColorTextureCreated;

			// Token: 0x04001724 RID: 5924
			[FieldOffset(5)]
			[MarshalAs(4)]
			public bool requiresMotionVectors;

			// Token: 0x04001725 RID: 5925
			[FieldOffset(8)]
			public RenderPassEvent requiresDepthNormalAtEvent;

			// Token: 0x04001726 RID: 5926
			[FieldOffset(12)]
			public RenderPassEvent requiresDepthTextureEarliestEvent;
		}

		// Token: 0x020001CA RID: 458
		public class RenderGraphFrameResources : Object
		{
			// Token: 0x0600206A RID: 8298 RVA: 0x0007E978 File Offset: 0x0007CB78
			// Note: this type is marked as 'beforefieldinit'.
			static RenderGraphFrameResources()
			{
				Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "RenderGraphFrameResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr);
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_backBufferColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "backBufferColor");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "cameraColor");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "cameraDepth");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_mainShadowsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "mainShadowsTexture");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_additionalShadowsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "additionalShadowsTexture");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_gbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "gbuffer");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraOpaqueTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "cameraOpaqueTexture");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "cameraDepthTexture");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraNormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "cameraNormalsTexture");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_motionVectorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "motionVectorColor");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_motionVectorDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "motionVectorDepth");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_internalColorLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "internalColorLut");
				UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_overlayUITexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, "overlayUITexture");
				UniversalRenderer.RenderGraphFrameResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr, 100665651);
			}

			// Token: 0x0600206B RID: 8299 RVA: 0x0007EABC File Offset: 0x0007CCBC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderGraphFrameResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderer.RenderGraphFrameResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.RenderGraphFrameResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600206C RID: 8300 RVA: 0x00012898 File Offset: 0x00010A98
			public RenderGraphFrameResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAA RID: 2986
			// (get) Token: 0x0600206D RID: 8301 RVA: 0x0007EAF8 File Offset: 0x0007CCF8
			// (set) Token: 0x0600206E RID: 8302 RVA: 0x000128A1 File Offset: 0x00010AA1
			public unsafe TextureHandle backBufferColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_backBufferColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_backBufferColor)) = value;
				}
			}

			// Token: 0x17000BAB RID: 2987
			// (get) Token: 0x0600206F RID: 8303 RVA: 0x0007EB20 File Offset: 0x0007CD20
			// (set) Token: 0x06002070 RID: 8304 RVA: 0x000128BC File Offset: 0x00010ABC
			public unsafe TextureHandle cameraColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraColor)) = value;
				}
			}

			// Token: 0x17000BAC RID: 2988
			// (get) Token: 0x06002071 RID: 8305 RVA: 0x0007EB48 File Offset: 0x0007CD48
			// (set) Token: 0x06002072 RID: 8306 RVA: 0x000128D7 File Offset: 0x00010AD7
			public unsafe TextureHandle cameraDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraDepth)) = value;
				}
			}

			// Token: 0x17000BAD RID: 2989
			// (get) Token: 0x06002073 RID: 8307 RVA: 0x0007EB70 File Offset: 0x0007CD70
			// (set) Token: 0x06002074 RID: 8308 RVA: 0x000128F2 File Offset: 0x00010AF2
			public unsafe TextureHandle mainShadowsTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_mainShadowsTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_mainShadowsTexture)) = value;
				}
			}

			// Token: 0x17000BAE RID: 2990
			// (get) Token: 0x06002075 RID: 8309 RVA: 0x0007EB98 File Offset: 0x0007CD98
			// (set) Token: 0x06002076 RID: 8310 RVA: 0x0001290D File Offset: 0x00010B0D
			public unsafe TextureHandle additionalShadowsTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_additionalShadowsTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_additionalShadowsTexture)) = value;
				}
			}

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x06002077 RID: 8311 RVA: 0x0007EBC0 File Offset: 0x0007CDC0
			// (set) Token: 0x06002078 RID: 8312 RVA: 0x00012928 File Offset: 0x00010B28
			public unsafe Il2CppStructArray<TextureHandle> gbuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_gbuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_gbuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06002079 RID: 8313 RVA: 0x0007EBF0 File Offset: 0x0007CDF0
			// (set) Token: 0x0600207A RID: 8314 RVA: 0x00012947 File Offset: 0x00010B47
			public unsafe TextureHandle cameraOpaqueTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraOpaqueTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraOpaqueTexture)) = value;
				}
			}

			// Token: 0x17000BB1 RID: 2993
			// (get) Token: 0x0600207B RID: 8315 RVA: 0x0007EC18 File Offset: 0x0007CE18
			// (set) Token: 0x0600207C RID: 8316 RVA: 0x00012962 File Offset: 0x00010B62
			public unsafe TextureHandle cameraDepthTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraDepthTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraDepthTexture)) = value;
				}
			}

			// Token: 0x17000BB2 RID: 2994
			// (get) Token: 0x0600207D RID: 8317 RVA: 0x0007EC40 File Offset: 0x0007CE40
			// (set) Token: 0x0600207E RID: 8318 RVA: 0x0001297D File Offset: 0x00010B7D
			public unsafe TextureHandle cameraNormalsTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraNormalsTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_cameraNormalsTexture)) = value;
				}
			}

			// Token: 0x17000BB3 RID: 2995
			// (get) Token: 0x0600207F RID: 8319 RVA: 0x0007EC68 File Offset: 0x0007CE68
			// (set) Token: 0x06002080 RID: 8320 RVA: 0x00012998 File Offset: 0x00010B98
			public unsafe TextureHandle motionVectorColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_motionVectorColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_motionVectorColor)) = value;
				}
			}

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x06002081 RID: 8321 RVA: 0x0007EC90 File Offset: 0x0007CE90
			// (set) Token: 0x06002082 RID: 8322 RVA: 0x000129B3 File Offset: 0x00010BB3
			public unsafe TextureHandle motionVectorDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_motionVectorDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_motionVectorDepth)) = value;
				}
			}

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x06002083 RID: 8323 RVA: 0x0007ECB8 File Offset: 0x0007CEB8
			// (set) Token: 0x06002084 RID: 8324 RVA: 0x000129CE File Offset: 0x00010BCE
			public unsafe TextureHandle internalColorLut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_internalColorLut);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_internalColorLut)) = value;
				}
			}

			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x06002085 RID: 8325 RVA: 0x0007ECE0 File Offset: 0x0007CEE0
			// (set) Token: 0x06002086 RID: 8326 RVA: 0x000129E9 File Offset: 0x00010BE9
			public unsafe TextureHandle overlayUITexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_overlayUITexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderer.RenderGraphFrameResources.NativeFieldInfoPtr_overlayUITexture)) = value;
				}
			}

			// Token: 0x04001727 RID: 5927
			private static readonly IntPtr NativeFieldInfoPtr_backBufferColor;

			// Token: 0x04001728 RID: 5928
			private static readonly IntPtr NativeFieldInfoPtr_cameraColor;

			// Token: 0x04001729 RID: 5929
			private static readonly IntPtr NativeFieldInfoPtr_cameraDepth;

			// Token: 0x0400172A RID: 5930
			private static readonly IntPtr NativeFieldInfoPtr_mainShadowsTexture;

			// Token: 0x0400172B RID: 5931
			private static readonly IntPtr NativeFieldInfoPtr_additionalShadowsTexture;

			// Token: 0x0400172C RID: 5932
			private static readonly IntPtr NativeFieldInfoPtr_gbuffer;

			// Token: 0x0400172D RID: 5933
			private static readonly IntPtr NativeFieldInfoPtr_cameraOpaqueTexture;

			// Token: 0x0400172E RID: 5934
			private static readonly IntPtr NativeFieldInfoPtr_cameraDepthTexture;

			// Token: 0x0400172F RID: 5935
			private static readonly IntPtr NativeFieldInfoPtr_cameraNormalsTexture;

			// Token: 0x04001730 RID: 5936
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorColor;

			// Token: 0x04001731 RID: 5937
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorDepth;

			// Token: 0x04001732 RID: 5938
			private static readonly IntPtr NativeFieldInfoPtr_internalColorLut;

			// Token: 0x04001733 RID: 5939
			private static readonly IntPtr NativeFieldInfoPtr_overlayUITexture;

			// Token: 0x04001734 RID: 5940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001CB RID: 459
		[ObfuscatedName("UnityEngine.Rendering.Universal.UniversalRenderer+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002087 RID: 8327 RVA: 0x00012A04 File Offset: 0x00010C04
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<UniversalRenderer.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderer.__O>.NativeClassPtr);
				UniversalRenderer.__O.NativeFieldInfoPtr__0___Create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.__O>.NativeClassPtr, "<0>__Create");
			}

			// Token: 0x06002088 RID: 8328 RVA: 0x00012A38 File Offset: 0x00010C38
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB7 RID: 2999
			// (get) Token: 0x06002089 RID: 8329 RVA: 0x0007ED08 File Offset: 0x0007CF08
			// (set) Token: 0x0600208A RID: 8330 RVA: 0x00012A41 File Offset: 0x00010C41
			public unsafe static Func<XRPassCreateInfo, XRPass> _0___Create
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.__O.NativeFieldInfoPtr__0___Create, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<XRPassCreateInfo, XRPass>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.__O.NativeFieldInfoPtr__0___Create, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001735 RID: 5941
			private static readonly IntPtr NativeFieldInfoPtr__0___Create;
		}

		// Token: 0x020001CC RID: 460
		[ObfuscatedName("UnityEngine.Rendering.Universal.UniversalRenderer+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600208B RID: 8331 RVA: 0x0007ED30 File Offset: 0x0007CF30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr);
				UniversalRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr, "<>9");
				UniversalRenderer.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr, "<>9__91_0");
				UniversalRenderer.__c.NativeFieldInfoPtr___9__91_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr, "<>9__91_1");
				UniversalRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr, 100665653);
				UniversalRenderer.__c.NativeMethodInfoPtr__Setup_b__91_0_Internal_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr, 100665654);
				UniversalRenderer.__c.NativeMethodInfoPtr__Setup_b__91_1_Internal_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr, 100665655);
			}

			// Token: 0x0600208C RID: 8332 RVA: 0x0007EDD4 File Offset: 0x0007CFD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600208D RID: 8333 RVA: 0x0007EE10 File Offset: 0x0007D010
			[CallerCount(0)]
			public unsafe bool _Setup_b__91_0(ScriptableRenderPass x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.__c.NativeMethodInfoPtr__Setup_b__91_0_Internal_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600208E RID: 8334 RVA: 0x0007EE60 File Offset: 0x0007D060
			[CallerCount(0)]
			public unsafe bool _Setup_b__91_1(ScriptableRenderPass x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderer.__c.NativeMethodInfoPtr__Setup_b__91_1_Internal_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600208F RID: 8335 RVA: 0x00012A53 File Offset: 0x00010C53
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB8 RID: 3000
			// (get) Token: 0x06002090 RID: 8336 RVA: 0x0007EEB0 File Offset: 0x0007D0B0
			// (set) Token: 0x06002091 RID: 8337 RVA: 0x00012A5C File Offset: 0x00010C5C
			public unsafe static UniversalRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB9 RID: 3001
			// (get) Token: 0x06002092 RID: 8338 RVA: 0x0007EED8 File Offset: 0x0007D0D8
			// (set) Token: 0x06002093 RID: 8339 RVA: 0x00012A6E File Offset: 0x00010C6E
			public unsafe static Predicate<ScriptableRenderPass> __9__91_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRenderPass>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBA RID: 3002
			// (get) Token: 0x06002094 RID: 8340 RVA: 0x0007EF00 File Offset: 0x0007D100
			// (set) Token: 0x06002095 RID: 8341 RVA: 0x00012A80 File Offset: 0x00010C80
			public unsafe static Predicate<ScriptableRenderPass> __9__91_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalRenderer.__c.NativeFieldInfoPtr___9__91_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRenderPass>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalRenderer.__c.NativeFieldInfoPtr___9__91_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001736 RID: 5942
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001737 RID: 5943
			private static readonly IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x04001738 RID: 5944
			private static readonly IntPtr NativeFieldInfoPtr___9__91_1;

			// Token: 0x04001739 RID: 5945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400173A RID: 5946
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__91_0_Internal_Boolean_ScriptableRenderPass_0;

			// Token: 0x0400173B RID: 5947
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__91_1_Internal_Boolean_ScriptableRenderPass_0;
		}
	}
}
