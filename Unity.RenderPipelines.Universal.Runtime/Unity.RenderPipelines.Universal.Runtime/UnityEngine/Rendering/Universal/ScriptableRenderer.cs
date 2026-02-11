using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000080 RID: 128
	public class ScriptableRenderer : Object
	{
		// Token: 0x06000AF0 RID: 2800 RVA: 0x0003B070 File Offset: 0x00039270
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRenderer()
		{
			Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScriptableRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr);
			ScriptableRenderer.NativeFieldInfoPtr_kRenderPassMapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "kRenderPassMapSize");
			ScriptableRenderer.NativeFieldInfoPtr_kRenderPassMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "kRenderPassMaxCount");
			ScriptableRenderer.NativeFieldInfoPtr_m_LastBeginSubpassPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_LastBeginSubpassPassIndex");
			ScriptableRenderer.NativeFieldInfoPtr_m_MergeableRenderPassesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_MergeableRenderPassesMap");
			ScriptableRenderer.NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_MergeableRenderPassesMapArrays");
			ScriptableRenderer.NativeFieldInfoPtr_m_PassIndexToPassHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_PassIndexToPassHash");
			ScriptableRenderer.NativeFieldInfoPtr_m_RenderPassesAttachmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_RenderPassesAttachmentCount");
			ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveColorAttachmentDescriptors");
			ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveDepthAttachmentDescriptor");
			ScriptableRenderer.NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_IsActiveColorAttachmentTransient");
			ScriptableRenderer.NativeFieldInfoPtr_m_FinalColorStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FinalColorStoreAction");
			ScriptableRenderer.NativeFieldInfoPtr_m_FinalDepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FinalDepthStoreAction");
			ScriptableRenderer.NativeFieldInfoPtr__profilingExecute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<profilingExecute>k__BackingField");
			ScriptableRenderer.NativeFieldInfoPtr_hasReleasedRTs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "hasReleasedRTs");
			ScriptableRenderer.NativeFieldInfoPtr__DebugHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<DebugHandler>k__BackingField");
			ScriptableRenderer.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "current");
			ScriptableRenderer.NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<supportedRenderingFeatures>k__BackingField");
			ScriptableRenderer.NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<unsupportedGraphicsDeviceTypes>k__BackingField");
			ScriptableRenderer.NativeFieldInfoPtr_m_StoreActionsOptimizationSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_StoreActionsOptimizationSetting");
			ScriptableRenderer.NativeFieldInfoPtr_m_UseOptimizedStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_UseOptimizedStoreActions");
			ScriptableRenderer.NativeFieldInfoPtr_k_RenderPassBlockCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "k_RenderPassBlockCount");
			ScriptableRenderer.NativeFieldInfoPtr_k_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "k_CameraTarget");
			ScriptableRenderer.NativeFieldInfoPtr_m_ActiveRenderPassQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveRenderPassQueue");
			ScriptableRenderer.NativeFieldInfoPtr_m_RendererFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_RendererFeatures");
			ScriptableRenderer.NativeFieldInfoPtr_m_CameraColorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_CameraColorTarget");
			ScriptableRenderer.NativeFieldInfoPtr_m_CameraDepthTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_CameraDepthTarget");
			ScriptableRenderer.NativeFieldInfoPtr_m_CameraResolveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_CameraResolveTarget");
			ScriptableRenderer.NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FirstTimeCameraColorTargetIsBound");
			ScriptableRenderer.NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FirstTimeCameraDepthTargetIsBound");
			ScriptableRenderer.NativeFieldInfoPtr_m_IsPipelineExecuting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_IsPipelineExecuting");
			ScriptableRenderer.NativeFieldInfoPtr_disableNativeRenderPassInFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "disableNativeRenderPassInFeatures");
			ScriptableRenderer.NativeFieldInfoPtr_useRenderPassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "useRenderPassEnabled");
			ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveColorAttachments");
			ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveDepthAttachment");
			ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveColorStoreActions");
			ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveDepthStoreAction");
			ScriptableRenderer.NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_TrimmedColorAttachmentCopies");
			ScriptableRenderer.NativeFieldInfoPtr_s_Planes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "s_Planes");
			ScriptableRenderer.NativeFieldInfoPtr_s_VectorPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "s_VectorPlanes");
			ScriptableRenderer.NativeFieldInfoPtr__useDepthPriming_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<useDepthPriming>k__BackingField");
			ScriptableRenderer.NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<stripShadowsOffVariants>k__BackingField");
			ScriptableRenderer.NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<stripAdditionalLightOffVariants>k__BackingField");
			ScriptableRenderer.NativeMethodInfoPtr_get_cameraDepth_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664721);
			ScriptableRenderer.NativeMethodInfoPtr_ResetNativeRenderPassFrameData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664722);
			ScriptableRenderer.NativeMethodInfoPtr_SetupNativeRenderPassFrameData_Internal_Void_byref_CameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664723);
			ScriptableRenderer.NativeMethodInfoPtr_UpdateFinalStoreActions_Internal_Void_Il2CppStructArray_1_Int32_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664724);
			ScriptableRenderer.NativeMethodInfoPtr_SetNativeRenderPassMRTAttachmentList_Internal_Void_ScriptableRenderPass_byref_CameraData_Boolean_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664725);
			ScriptableRenderer.NativeMethodInfoPtr_IsDepthOnlyRenderTexture_Private_Boolean_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664726);
			ScriptableRenderer.NativeMethodInfoPtr_SetNativeRenderPassAttachmentList_Internal_Void_ScriptableRenderPass_byref_CameraData_RTHandle_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664727);
			ScriptableRenderer.NativeMethodInfoPtr_ExecuteNativeRenderPass_Internal_Void_ScriptableRenderContext_ScriptableRenderPass_byref_CameraData_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664728);
			ScriptableRenderer.NativeMethodInfoPtr_SetupInputAttachmentIndices_Internal_Void_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664729);
			ScriptableRenderer.NativeMethodInfoPtr_SetupTransientInputAttachments_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664730);
			ScriptableRenderer.NativeMethodInfoPtr_GetSubPassAttachmentIndicesCount_Internal_Static_UInt32_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664731);
			ScriptableRenderer.NativeMethodInfoPtr_AreAttachmentIndicesCompatible_Internal_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664732);
			ScriptableRenderer.NativeMethodInfoPtr_GetValidColorAttachmentCount_Internal_Static_UInt32_Il2CppStructArray_1_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664733);
			ScriptableRenderer.NativeMethodInfoPtr_GetValidInputAttachmentCount_Internal_Static_Int32_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664734);
			ScriptableRenderer.NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_Int32_AttachmentDescriptor_Il2CppStructArray_1_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664735);
			ScriptableRenderer.NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_RenderTargetIdentifier_Il2CppStructArray_1_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664736);
			ScriptableRenderer.NativeMethodInfoPtr_GetValidPassIndexCount_Internal_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664737);
			ScriptableRenderer.NativeMethodInfoPtr_GetFirstAllocatedRTHandle_Internal_Static_RTHandle_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664738);
			ScriptableRenderer.NativeMethodInfoPtr_PassHasInputAttachments_Internal_Static_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664739);
			ScriptableRenderer.NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_Int32_Int32_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664740);
			ScriptableRenderer.NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_RenderPassDescriptor_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664741);
			ScriptableRenderer.NativeMethodInfoPtr_GetRenderTextureDescriptor_Internal_Static_Void_byref_CameraData_ScriptableRenderPass_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664742);
			ScriptableRenderer.NativeMethodInfoPtr_InitializeRenderPassDescriptor_Private_RenderPassDescriptor_byref_CameraData_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664743);
			ScriptableRenderer.NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664744);
			ScriptableRenderer.NativeMethodInfoPtr_SupportsCameraStackingType_Public_Boolean_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664745);
			ScriptableRenderer.NativeMethodInfoPtr_get_profilingExecute_Protected_get_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664746);
			ScriptableRenderer.NativeMethodInfoPtr_set_profilingExecute_Protected_set_Void_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664747);
			ScriptableRenderer.NativeMethodInfoPtr_get_DebugHandler_Internal_get_DebugHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664748);
			ScriptableRenderer.NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_byref_CameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664749);
			ScriptableRenderer.NativeMethodInfoPtr_SetCameraMatrices_Internal_Static_Void_CommandBuffer_byref_CameraData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664750);
			ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_CommandBuffer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664751);
			ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_CommandBuffer_byref_CameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664752);
			ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraBillboardProperties_Private_Void_CommandBuffer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664753);
			ScriptableRenderer.NativeMethodInfoPtr_CalculateBillboardProperties_Private_Static_Void_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664754);
			ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_CommandBuffer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664755);
			ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_CommandBuffer_byref_CameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664756);
			ScriptableRenderer.NativeMethodInfoPtr_SetShaderTimeValues_Private_Static_Void_CommandBuffer_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664757);
			ScriptableRenderer.NativeMethodInfoPtr_get_cameraColorTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664758);
			ScriptableRenderer.NativeMethodInfoPtr_get_cameraColorTargetHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664759);
			ScriptableRenderer.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664760);
			ScriptableRenderer.NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664761);
			ScriptableRenderer.NativeMethodInfoPtr_get_cameraDepthTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664762);
			ScriptableRenderer.NativeMethodInfoPtr_get_cameraDepthTargetHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664763);
			ScriptableRenderer.NativeMethodInfoPtr_get_rendererFeatures_Protected_get_List_1_ScriptableRendererFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664764);
			ScriptableRenderer.NativeMethodInfoPtr_get_activeRenderPassQueue_Protected_get_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664765);
			ScriptableRenderer.NativeMethodInfoPtr_get_supportedRenderingFeatures_Public_get_RenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664766);
			ScriptableRenderer.NativeMethodInfoPtr_set_supportedRenderingFeatures_Public_set_Void_RenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664767);
			ScriptableRenderer.NativeMethodInfoPtr_get_unsupportedGraphicsDeviceTypes_Public_get_Il2CppStructArray_1_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664768);
			ScriptableRenderer.NativeMethodInfoPtr_set_unsupportedGraphicsDeviceTypes_Public_set_Void_Il2CppStructArray_1_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664769);
			ScriptableRenderer.NativeMethodInfoPtr_ConfigureActiveTarget_Internal_Static_Void_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664770);
			ScriptableRenderer.NativeMethodInfoPtr_get_useDepthPriming_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664771);
			ScriptableRenderer.NativeMethodInfoPtr_set_useDepthPriming_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664772);
			ScriptableRenderer.NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664773);
			ScriptableRenderer.NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664774);
			ScriptableRenderer.NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664775);
			ScriptableRenderer.NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664776);
			ScriptableRenderer.NativeMethodInfoPtr__ctor_Public_Void_ScriptableRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664777);
			ScriptableRenderer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664778);
			ScriptableRenderer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664779);
			ScriptableRenderer.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664780);
			ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664781);
			ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664782);
			ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664783);
			ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RTHandle_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664784);
			ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664785);
			ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664786);
			ScriptableRenderer.NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664787);
			ScriptableRenderer.NativeMethodInfoPtr_SetupLights_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664788);
			ScriptableRenderer.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_New_Void_byref_ScriptableCullingParameters_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664789);
			ScriptableRenderer.NativeMethodInfoPtr_FinishRendering_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664790);
			ScriptableRenderer.NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664791);
			ScriptableRenderer.NativeMethodInfoPtr_InitRenderGraphFrame_Private_Void_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664792);
			ScriptableRenderer.NativeMethodInfoPtr_ProcessVFXCameraCommand_Internal_Void_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664793);
			ScriptableRenderer.NativeMethodInfoPtr_SetupRenderGraphCameraProperties_Internal_Void_RenderGraph_byref_RenderingData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664794);
			ScriptableRenderer.NativeMethodInfoPtr_DrawRenderGraphGizmos_Internal_Void_RenderGraph_TextureHandle_TextureHandle_GizmoSubset_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664795);
			ScriptableRenderer.NativeMethodInfoPtr_BeginRenderGraphXRRendering_Private_Void_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664796);
			ScriptableRenderer.NativeMethodInfoPtr_EndRenderGraphXRRendering_Private_Void_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664797);
			ScriptableRenderer.NativeMethodInfoPtr_RecordRenderGraph_Internal_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664798);
			ScriptableRenderer.NativeMethodInfoPtr_FinishRenderGraphRendering_Internal_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664799);
			ScriptableRenderer.NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664800);
			ScriptableRenderer.NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664801);
			ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraProperties_Internal_Void_ScriptableRenderContext_byref_CameraData_Camera_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664802);
			ScriptableRenderer.NativeMethodInfoPtr_Execute_Public_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664803);
			ScriptableRenderer.NativeMethodInfoPtr_EnqueuePass_Public_Void_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664804);
			ScriptableRenderer.NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664805);
			ScriptableRenderer.NativeMethodInfoPtr_OnPreCullRenderPasses_Internal_Void_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664806);
			ScriptableRenderer.NativeMethodInfoPtr_AddRenderPasses_Internal_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664807);
			ScriptableRenderer.NativeMethodInfoPtr_SetupRenderPasses_Protected_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664808);
			ScriptableRenderer.NativeMethodInfoPtr_ClearRenderingState_Private_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664809);
			ScriptableRenderer.NativeMethodInfoPtr_Clear_Internal_Void_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664810);
			ScriptableRenderer.NativeMethodInfoPtr_ExecuteBlock_Private_Void_Int32_byref_RenderBlocks_ScriptableRenderContext_byref_RenderingData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664811);
			ScriptableRenderer.NativeMethodInfoPtr_IsRenderPassEnabled_Private_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664812);
			ScriptableRenderer.NativeMethodInfoPtr_ExecuteRenderPass_Private_Void_ScriptableRenderContext_ScriptableRenderPass_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664813);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderPassAttachments_Private_Void_CommandBuffer_ScriptableRenderPass_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664814);
			ScriptableRenderer.NativeMethodInfoPtr_BeginXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664815);
			ScriptableRenderer.NativeMethodInfoPtr_EndXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664816);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664817);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664818);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664819);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664820);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664821);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664822);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664823);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664824);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664825);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664826);
			ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppReferenceArray_1_RTHandle_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664827);
			ScriptableRenderer.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664828);
			ScriptableRenderer.NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664829);
			ScriptableRenderer.NativeMethodInfoPtr_DrawGizmos_Private_Void_ScriptableRenderContext_Camera_GizmoSubset_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664830);
			ScriptableRenderer.NativeMethodInfoPtr_DrawWireOverlay_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664831);
			ScriptableRenderer.NativeMethodInfoPtr_InternalStartRendering_Private_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664832);
			ScriptableRenderer.NativeMethodInfoPtr_InternalFinishRendering_Private_Void_Boolean_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664833);
			ScriptableRenderer.NativeMethodInfoPtr_InternalFinishRendering_Private_Void_ScriptableRenderContext_Boolean_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664834);
			ScriptableRenderer.NativeMethodInfoPtr_SortStable_Internal_Static_Void_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664835);
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0003BCE4 File Offset: 0x00039EE4
		public unsafe RenderTargetIdentifier cameraDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608887, XrefRangeEnd = 608888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_cameraDepth_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0003BD20 File Offset: 0x00039F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 608896, RefRangeEnd = 608899, XrefRangeStart = 608888, XrefRangeEnd = 608896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetNativeRenderPassFrameData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ResetNativeRenderPassFrameData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0003BD54 File Offset: 0x00039F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608976, RefRangeEnd = 608977, XrefRangeStart = 608899, XrefRangeEnd = 608976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupNativeRenderPassFrameData(ref CameraData cameraData, bool isRenderPassEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRenderPassEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetupNativeRenderPassFrameData_Internal_Void_byref_CameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0003BDA8 File Offset: 0x00039FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609000, RefRangeEnd = 609002, XrefRangeStart = 608977, XrefRangeEnd = 609000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFinalStoreActions(Il2CppStructArray<int> currentMergeablePasses, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentMergeablePasses);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_UpdateFinalStoreActions_Internal_Void_Il2CppStructArray_1_Int32_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0003BE00 File Offset: 0x0003A000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609002, XrefRangeEnd = 609085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needCustomCameraColorClear;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraClearFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetNativeRenderPassMRTAttachmentList_Internal_Void_ScriptableRenderPass_byref_CameraData_Boolean_ClearFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0003BE74 File Offset: 0x0003A074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609085, XrefRangeEnd = 609086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDepthOnlyRenderTexture(RenderTexture t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_IsDepthOnlyRenderTexture_Private_Boolean_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 609184, RefRangeEnd = 609185, XrefRangeStart = 609086, XrefRangeEnd = 609184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passColorAttachment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passDepthAttachment);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finalClearFlag;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finalClearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetNativeRenderPassAttachmentList_Internal_Void_ScriptableRenderPass_byref_CameraData_RTHandle_RTHandle_ClearFlag_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0003BF5C File Offset: 0x0003A15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 609314, RefRangeEnd = 609315, XrefRangeStart = 609185, XrefRangeEnd = 609314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref CameraData cameraData, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ExecuteNativeRenderPass_Internal_Void_ScriptableRenderContext_ScriptableRenderPass_byref_CameraData_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0003BFD4 File Offset: 0x0003A1D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609332, RefRangeEnd = 609334, XrefRangeStart = 609315, XrefRangeEnd = 609332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupInputAttachmentIndices(ScriptableRenderPass pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetupInputAttachmentIndices_Internal_Void_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0003C018 File Offset: 0x0003A218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609334, XrefRangeEnd = 609338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupTransientInputAttachments(int attachmentCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attachmentCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetupTransientInputAttachments_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0003C058 File Offset: 0x0003A258
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 609352, RefRangeEnd = 609357, XrefRangeStart = 609338, XrefRangeEnd = 609352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_GetSubPassAttachmentIndicesCount_Internal_Static_UInt32_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0003C09C File Offset: 0x0003A29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609357, XrefRangeEnd = 609362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastSubPass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSubPass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_AreAttachmentIndicesCompatible_Internal_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0003C0F0 File Offset: 0x0003A2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609362, XrefRangeEnd = 609371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetValidColorAttachmentCount(Il2CppStructArray<AttachmentDescriptor> colorAttachments)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_GetValidColorAttachmentCount_Internal_Static_UInt32_Il2CppStructArray_1_AttachmentDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0003C134 File Offset: 0x0003A334
		[CallerCount(0)]
		public unsafe static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_GetValidInputAttachmentCount_Internal_Static_Int32_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0003C178 File Offset: 0x0003A378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 609376, RefRangeEnd = 609377, XrefRangeStart = 609371, XrefRangeEnd = 609376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, Il2CppStructArray<AttachmentDescriptor> attachmentDescriptors)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attachmentIdx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attachmentDescriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attachmentDescriptors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_Int32_AttachmentDescriptor_Il2CppStructArray_1_AttachmentDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003C1D8 File Offset: 0x0003A3D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609380, RefRangeEnd = 609382, XrefRangeStart = 609377, XrefRangeEnd = 609380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, Il2CppStructArray<AttachmentDescriptor> attachmentDescriptors)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attachmentDescriptors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_RenderTargetIdentifier_Il2CppStructArray_1_AttachmentDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0003C228 File Offset: 0x0003A428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609382, XrefRangeEnd = 609383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetValidPassIndexCount(Il2CppStructArray<int> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_GetValidPassIndexCount_Internal_Static_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0003C26C File Offset: 0x0003A46C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609388, RefRangeEnd = 609390, XrefRangeStart = 609383, XrefRangeEnd = 609388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_GetFirstAllocatedRTHandle_Internal_Static_RTHandle_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003C2B0 File Offset: 0x0003A4B0
		[CallerCount(0)]
		public unsafe static bool PassHasInputAttachments(ScriptableRenderPass renderPass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_PassHasInputAttachments_Internal_Static_Boolean_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0003C2F4 File Offset: 0x0003A4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609390, XrefRangeEnd = 609391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sample;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_Int32_Int32_Int32_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003C36C File Offset: 0x0003A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609391, XrefRangeEnd = 609395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hash128 CreateRenderPassHash(ScriptableRenderer.RenderPassDescriptor desc, uint hashIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_RenderPassDescriptor_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0003C3B8 File Offset: 0x0003A5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 609411, RefRangeEnd = 609412, XrefRangeStart = 609395, XrefRangeEnd = 609411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderTextureDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetRT;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_GetRenderTextureDescriptor_Internal_Static_Void_byref_CameraData_ScriptableRenderPass_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0003C410 File Offset: 0x0003A610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609427, RefRangeEnd = 609429, XrefRangeStart = 609412, XrefRangeEnd = 609427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRenderer.RenderPassDescriptor InitializeRenderPassDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_InitializeRenderPassDescriptor_Private_RenderPassDescriptor_byref_CameraData_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0003C470 File Offset: 0x0003A670
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int SupportedCameraStackingTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0003C4B8 File Offset: 0x0003A6B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609429, RefRangeEnd = 609431, XrefRangeStart = 609429, XrefRangeEnd = 609429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SupportsCameraStackingType(CameraRenderType cameraRenderType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cameraRenderType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SupportsCameraStackingType_Public_Boolean_CameraRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0003C504 File Offset: 0x0003A704
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x0003C544 File Offset: 0x0003A744
		public unsafe ProfilingSampler profilingExecute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_profilingExecute_Protected_get_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_set_profilingExecute_Protected_set_Void_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0003C588 File Offset: 0x0003A788
		public unsafe DebugHandler DebugHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_DebugHandler_Internal_get_DebugHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0003C5C8 File Offset: 0x0003A7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609431, XrefRangeEnd = 609436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setInverseMatrices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_byref_CameraData_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0003C620 File Offset: 0x0003A820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609462, RefRangeEnd = 609464, XrefRangeStart = 609436, XrefRangeEnd = 609462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices, bool isTargetFlipped)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setInverseMatrices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTargetFlipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetCameraMatrices_Internal_Static_Void_CommandBuffer_byref_CameraData_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0003C688 File Offset: 0x0003A888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609464, XrefRangeEnd = 609466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_CommandBuffer_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 609533, RefRangeEnd = 609538, XrefRangeStart = 609466, XrefRangeEnd = 609533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData, bool isTargetFlipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTargetFlipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_CommandBuffer_byref_CameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0003C744 File Offset: 0x0003A944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 609559, RefRangeEnd = 609560, XrefRangeStart = 609538, XrefRangeEnd = 609559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerCameraBillboardProperties(CommandBuffer cmd, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraBillboardProperties_Private_Void_CommandBuffer_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0003C79C File Offset: 0x0003A99C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609570, RefRangeEnd = 609572, XrefRangeStart = 609560, XrefRangeEnd = 609570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateBillboardProperties([In] ref Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &worldToCameraMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &billboardTangent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &billboardNormal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cameraXZAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_CalculateBillboardProperties_Private_Static_Void_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0003C7F8 File Offset: 0x0003A9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609572, XrefRangeEnd = 609574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_CommandBuffer_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0003C850 File Offset: 0x0003AA50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 609590, RefRangeEnd = 609593, XrefRangeStart = 609574, XrefRangeEnd = 609590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, [In] ref CameraData cameraData, bool isTargetFlipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTargetFlipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_CommandBuffer_byref_CameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0003C8B4 File Offset: 0x0003AAB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 609616, RefRangeEnd = 609620, XrefRangeStart = 609593, XrefRangeEnd = 609616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetShaderTimeValues(CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothDeltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetShaderTimeValues_Private_Static_Void_CommandBuffer_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0003C914 File Offset: 0x0003AB14
		public unsafe RenderTargetIdentifier cameraColorTarget
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 609629, RefRangeEnd = 609630, XrefRangeStart = 609620, XrefRangeEnd = 609629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_cameraColorTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0003C950 File Offset: 0x0003AB50
		public unsafe RTHandle cameraColorTargetHandle
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 609632, RefRangeEnd = 609645, XrefRangeStart = 609630, XrefRangeEnd = 609632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_cameraColorTargetHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0003C990 File Offset: 0x0003AB90
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0003C9EC File Offset: 0x0003ABEC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0003CA48 File Offset: 0x0003AC48
		public unsafe RenderTargetIdentifier cameraDepthTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609645, XrefRangeEnd = 609654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_cameraDepthTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0003CA84 File Offset: 0x0003AC84
		public unsafe RTHandle cameraDepthTargetHandle
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 609656, RefRangeEnd = 609660, XrefRangeStart = 609654, XrefRangeEnd = 609656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_cameraDepthTargetHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0003CAC4 File Offset: 0x0003ACC4
		public unsafe List<ScriptableRendererFeature> rendererFeatures
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_rendererFeatures_Protected_get_List_1_ScriptableRendererFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ScriptableRendererFeature>>(intPtr3) : null;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003CB04 File Offset: 0x0003AD04
		public unsafe List<ScriptableRenderPass> activeRenderPassQueue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_activeRenderPassQueue_Protected_get_List_1_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ScriptableRenderPass>>(intPtr3) : null;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0003CB44 File Offset: 0x0003AD44
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x0003CB84 File Offset: 0x0003AD84
		public unsafe ScriptableRenderer.RenderingFeatures supportedRenderingFeatures
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_supportedRenderingFeatures_Public_get_RenderingFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer.RenderingFeatures>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_set_supportedRenderingFeatures_Public_set_Void_RenderingFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0003CBC8 File Offset: 0x0003ADC8
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0003CC08 File Offset: 0x0003AE08
		public unsafe Il2CppStructArray<GraphicsDeviceType> unsupportedGraphicsDeviceTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_unsupportedGraphicsDeviceTypes_Public_get_Il2CppStructArray_1_GraphicsDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsDeviceType>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_set_unsupportedGraphicsDeviceTypes_Public_set_Void_Il2CppStructArray_1_GraphicsDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0003CC4C File Offset: 0x0003AE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609660, XrefRangeEnd = 609673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureActiveTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorAttachment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ConfigureActiveTarget_Internal_Static_Void_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0003CC8C File Offset: 0x0003AE8C
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x0003CCC8 File Offset: 0x0003AEC8
		public unsafe bool useDepthPriming
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_useDepthPriming_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_set_useDepthPriming_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0003CD08 File Offset: 0x0003AF08
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0003CD44 File Offset: 0x0003AF44
		public unsafe bool stripShadowsOffVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0003CD84 File Offset: 0x0003AF84
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0003CDC0 File Offset: 0x0003AFC0
		public unsafe bool stripAdditionalLightOffVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0003CE00 File Offset: 0x0003B000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 609813, RefRangeEnd = 609816, XrefRangeStart = 609673, XrefRangeEnd = 609813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRenderer(ScriptableRendererData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr__ctor_Public_Void_ScriptableRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0003CE4C File Offset: 0x0003B04C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 609833, RefRangeEnd = 609836, XrefRangeStart = 609816, XrefRangeEnd = 609833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0003CE80 File Offset: 0x0003B080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 609837, RefRangeEnd = 609839, XrefRangeStart = 609836, XrefRangeEnd = 609837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0003CECC File Offset: 0x0003B0CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseRenderTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0003CF08 File Offset: 0x0003B108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609839, XrefRangeEnd = 609841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorTarget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTarget;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0003CF54 File Offset: 0x0003B154
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 609845, RefRangeEnd = 609854, XrefRangeStart = 609841, XrefRangeEnd = 609845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609854, XrefRangeEnd = 609857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget, RenderTargetIdentifier resolveTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorTarget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolveTarget;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0003D004 File Offset: 0x0003B204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609857, XrefRangeEnd = 609863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolveTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RTHandle_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0003D06C File Offset: 0x0003B26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609863, XrefRangeEnd = 609864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureCameraColorTarget(RenderTargetIdentifier colorTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorTarget;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0003D0AC File Offset: 0x0003B2AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 609866, RefRangeEnd = 609872, XrefRangeStart = 609864, XrefRangeEnd = 609866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureCameraColorTarget(RTHandle colorTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0003D0F0 File Offset: 0x0003B2F0
		[CallerCount(0)]
		public unsafe virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0003D14C File Offset: 0x0003B34C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_SetupLights_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0003D1A8 File Offset: 0x0003B3A8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_New_Void_byref_ScriptableCullingParameters_byref_CameraData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0003D204 File Offset: 0x0003B404
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinishRendering(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_FinishRendering_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0003D254 File Offset: 0x0003B454
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0003D2C4 File Offset: 0x0003B4C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 609905, RefRangeEnd = 609906, XrefRangeStart = 609872, XrefRangeEnd = 609905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitRenderGraphFrame(RenderGraph renderGraph, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_InitRenderGraphFrame_Private_Void_RenderGraph_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0003D31C File Offset: 0x0003B51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 609906, XrefRangeEnd = 609938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVFXCameraCommand(RenderGraph renderGraph, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ProcessVFXCameraCommand_Internal_Void_RenderGraph_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0003D374 File Offset: 0x0003B574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 609972, RefRangeEnd = 609975, XrefRangeStart = 609938, XrefRangeEnd = 609972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupRenderGraphCameraProperties(RenderGraph renderGraph, ref RenderingData renderingData, bool isTargetBackbuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTargetBackbuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetupRenderGraphCameraProperties_Internal_Void_RenderGraph_byref_RenderingData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0003D3D8 File Offset: 0x0003B5D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 610010, RefRangeEnd = 610014, XrefRangeStart = 609975, XrefRangeEnd = 610010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderGraphGizmos(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gizmoSubset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_DrawRenderGraphGizmos_Internal_Void_RenderGraph_TextureHandle_TextureHandle_GizmoSubset_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0003D458 File Offset: 0x0003B658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610047, RefRangeEnd = 610048, XrefRangeStart = 610014, XrefRangeEnd = 610047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_BeginRenderGraphXRRendering_Private_Void_RenderGraph_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610081, RefRangeEnd = 610082, XrefRangeStart = 610048, XrefRangeEnd = 610081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_EndRenderGraphXRRendering_Private_Void_RenderGraph_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0003D508 File Offset: 0x0003B708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 610097, RefRangeEnd = 610099, XrefRangeStart = 610082, XrefRangeEnd = 610097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_RecordRenderGraph_Internal_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0003D56C File Offset: 0x0003B76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610099, XrefRangeEnd = 610100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_FinishRenderGraphRendering_Internal_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0003D5C0 File Offset: 0x0003B7C0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0003D61C File Offset: 0x0003B81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610133, RefRangeEnd = 610134, XrefRangeStart = 610100, XrefRangeEnd = 610133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordCustomRenderGraphPasses(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData, RenderPassEvent injectionPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref injectionPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0003D690 File Offset: 0x0003B890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610166, RefRangeEnd = 610167, XrefRangeStart = 610134, XrefRangeEnd = 610166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerCameraProperties(ScriptableRenderContext context, ref CameraData cameraData, Camera camera, CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetPerCameraProperties_Internal_Void_ScriptableRenderContext_byref_CameraData_Camera_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0003D708 File Offset: 0x0003B908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610167, XrefRangeEnd = 610395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_Execute_Public_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0003D75C File Offset: 0x0003B95C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 610400, RefRangeEnd = 610439, XrefRangeStart = 610395, XrefRangeEnd = 610400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnqueuePass(ScriptableRenderPass pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_EnqueuePass_Public_Void_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0003D7A0 File Offset: 0x0003B9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610439, XrefRangeEnd = 610452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClearFlag GetCameraClearFlag(ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0003D7E4 File Offset: 0x0003B9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610452, XrefRangeEnd = 610459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreCullRenderPasses([In] ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_OnPreCullRenderPasses_Internal_Void_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0003D828 File Offset: 0x0003BA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610459, XrefRangeEnd = 610488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRenderPasses(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_AddRenderPasses_Internal_Void_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0003D86C File Offset: 0x0003BA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610503, RefRangeEnd = 610504, XrefRangeStart = 610488, XrefRangeEnd = 610503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupRenderPasses([In] ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetupRenderPasses_Protected_Void_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0003D8B0 File Offset: 0x0003BAB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 610570, RefRangeEnd = 610572, XrefRangeStart = 610504, XrefRangeEnd = 610570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearRenderingState(CommandBuffer cmd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ClearRenderingState_Private_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0003D8E8 File Offset: 0x0003BAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610594, RefRangeEnd = 610595, XrefRangeStart = 610572, XrefRangeEnd = 610594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(CameraRenderType cameraType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cameraType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_Clear_Internal_Void_CameraRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0003D928 File Offset: 0x0003BB28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 610610, RefRangeEnd = 610614, XrefRangeStart = 610595, XrefRangeEnd = 610610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteBlock(int blockIndex, [In] ref ScriptableRenderer.RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blockIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderBlocks);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ExecuteBlock_Private_Void_Int32_byref_RenderBlocks_ScriptableRenderContext_byref_RenderingData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0003D9AC File Offset: 0x0003BBAC
		[CallerCount(0)]
		public unsafe bool IsRenderPassEnabled(ScriptableRenderPass renderPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_IsRenderPassEnabled_Private_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0003D9FC File Offset: 0x0003BBFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610653, RefRangeEnd = 610654, XrefRangeStart = 610614, XrefRangeEnd = 610653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_ExecuteRenderPass_Private_Void_ScriptableRenderContext_ScriptableRenderPass_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0003DA60 File Offset: 0x0003BC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610716, RefRangeEnd = 610717, XrefRangeStart = 610654, XrefRangeEnd = 610716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderPassAttachments_Private_Void_CommandBuffer_ScriptableRenderPass_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0003DAC8 File Offset: 0x0003BCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610717, XrefRangeEnd = 610738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_BeginXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0003DB2C File Offset: 0x0003BD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610738, XrefRangeEnd = 610761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_EndXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0003DB90 File Offset: 0x0003BD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610786, RefRangeEnd = 610787, XrefRangeStart = 610761, XrefRangeEnd = 610786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorAttachment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachment;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0003DC00 File Offset: 0x0003BE00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 610826, RefRangeEnd = 610828, XrefRangeStart = 610787, XrefRangeEnd = 610826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0003DC78 File Offset: 0x0003BE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610828, XrefRangeEnd = 610855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorAttachment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachment;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0003DD04 File Offset: 0x0003BF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610855, XrefRangeEnd = 610885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0003DD98 File Offset: 0x0003BF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610885, XrefRangeEnd = 610889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorAttachment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0003DE14 File Offset: 0x0003C014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610889, XrefRangeEnd = 610893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0003DE94 File Offset: 0x0003C094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 610902, RefRangeEnd = 610904, XrefRangeStart = 610893, XrefRangeEnd = 610902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorAttachment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachment;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlags;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0003DF3C File Offset: 0x0003C13C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 610912, RefRangeEnd = 610914, XrefRangeStart = 610904, XrefRangeEnd = 610912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlags;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0003DFEC File Offset: 0x0003C1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610914, XrefRangeEnd = 610925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorAttachments, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachment;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0003E060 File Offset: 0x0003C260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610925, XrefRangeEnd = 610937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0003E0D8 File Offset: 0x0003C2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610937, XrefRangeEnd = 610961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppReferenceArray<RTHandle> colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppReferenceArray_1_RTHandle_RTHandle_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003E150 File Offset: 0x0003C350
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SwapColorBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0003E1A0 File Offset: 0x0003C3A0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EnableSwapBufferMSAA(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderer.NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0003E1EC File Offset: 0x0003C3EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gizmoSubset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_DrawGizmos_Private_Void_ScriptableRenderContext_Camera_GizmoSubset_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0003E260 File Offset: 0x0003C460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 610961, XrefRangeEnd = 610965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWireOverlay(ScriptableRenderContext context, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_DrawWireOverlay_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0003E2B0 File Offset: 0x0003C4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 610983, RefRangeEnd = 610984, XrefRangeStart = 610965, XrefRangeEnd = 610983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_InternalStartRendering_Private_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0003E304 File Offset: 0x0003C504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 611002, RefRangeEnd = 611005, XrefRangeStart = 610984, XrefRangeEnd = 611002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalFinishRendering(bool resolveFinalTarget, RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resolveFinalTarget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_InternalFinishRendering_Private_Void_Boolean_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0003E35C File Offset: 0x0003C55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611005, XrefRangeEnd = 611012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalFinishRendering(ScriptableRenderContext context, bool resolveFinalTarget, RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolveFinalTarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_InternalFinishRendering_Private_Void_ScriptableRenderContext_Boolean_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0003E3C0 File Offset: 0x0003C5C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 611029, RefRangeEnd = 611031, XrefRangeStart = 611012, XrefRangeEnd = 611029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortStable(List<ScriptableRenderPass> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.NativeMethodInfoPtr_SortStable_Internal_Static_Void_List_1_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00006FCC File Offset: 0x000051CC
		public ScriptableRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0003E3F8 File Offset: 0x0003C5F8
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00006FD5 File Offset: 0x000051D5
		public unsafe static int kRenderPassMapSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_kRenderPassMapSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_kRenderPassMapSize, (void*)(&value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0003E414 File Offset: 0x0003C614
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00006FE3 File Offset: 0x000051E3
		public unsafe static int kRenderPassMaxCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_kRenderPassMaxCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_kRenderPassMaxCount, (void*)(&value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0003E430 File Offset: 0x0003C630
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00006FF1 File Offset: 0x000051F1
		public unsafe int m_LastBeginSubpassPassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_LastBeginSubpassPassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_LastBeginSubpassPassIndex)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0003E458 File Offset: 0x0003C658
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x0000700C File Offset: 0x0000520C
		public unsafe Dictionary<Hash128, Il2CppStructArray<int>> m_MergeableRenderPassesMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_MergeableRenderPassesMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Hash128, Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_MergeableRenderPassesMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0003E488 File Offset: 0x0003C688
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0000702B File Offset: 0x0000522B
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> m_MergeableRenderPassesMapArrays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0003E4B8 File Offset: 0x0003C6B8
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0000704A File Offset: 0x0000524A
		public unsafe Il2CppStructArray<Hash128> m_PassIndexToPassHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_PassIndexToPassHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Hash128>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_PassIndexToPassHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0003E4E8 File Offset: 0x0003C6E8
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00007069 File Offset: 0x00005269
		public unsafe Dictionary<Hash128, int> m_RenderPassesAttachmentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_RenderPassesAttachmentCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Hash128, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_RenderPassesAttachmentCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0003E518 File Offset: 0x0003C718
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00007088 File Offset: 0x00005288
		public unsafe Il2CppStructArray<AttachmentDescriptor> m_ActiveColorAttachmentDescriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AttachmentDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0003E548 File Offset: 0x0003C748
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x000070A7 File Offset: 0x000052A7
		public unsafe AttachmentDescriptor m_ActiveDepthAttachmentDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0003E570 File Offset: 0x0003C770
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x000070C2 File Offset: 0x000052C2
		public unsafe Il2CppStructArray<bool> m_IsActiveColorAttachmentTransient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0003E5A0 File Offset: 0x0003C7A0
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x000070E1 File Offset: 0x000052E1
		public unsafe Il2CppStructArray<RenderBufferStoreAction> m_FinalColorStoreAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FinalColorStoreAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FinalColorStoreAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0003E5D0 File Offset: 0x0003C7D0
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00007100 File Offset: 0x00005300
		public unsafe RenderBufferStoreAction m_FinalDepthStoreAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FinalDepthStoreAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FinalDepthStoreAction)) = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0003E5F8 File Offset: 0x0003C7F8
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x0000711B File Offset: 0x0000531B
		public unsafe ProfilingSampler _profilingExecute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__profilingExecute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__profilingExecute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0003E628 File Offset: 0x0003C828
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0000713A File Offset: 0x0000533A
		public unsafe bool hasReleasedRTs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_hasReleasedRTs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_hasReleasedRTs)) = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0003E650 File Offset: 0x0003C850
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00007155 File Offset: 0x00005355
		public unsafe DebugHandler _DebugHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__DebugHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__DebugHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0003E680 File Offset: 0x0003C880
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00007174 File Offset: 0x00005374
		public unsafe static ScriptableRenderer current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0003E6A8 File Offset: 0x0003C8A8
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00007186 File Offset: 0x00005386
		public unsafe ScriptableRenderer.RenderingFeatures _supportedRenderingFeatures_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer.RenderingFeatures>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0003E6D8 File Offset: 0x0003C8D8
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x000071A5 File Offset: 0x000053A5
		public unsafe Il2CppStructArray<GraphicsDeviceType> _unsupportedGraphicsDeviceTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsDeviceType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0003E708 File Offset: 0x0003C908
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x000071C4 File Offset: 0x000053C4
		public unsafe StoreActionsOptimization m_StoreActionsOptimizationSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_StoreActionsOptimizationSetting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_StoreActionsOptimizationSetting)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0003E730 File Offset: 0x0003C930
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x000071DF File Offset: 0x000053DF
		public unsafe static bool m_UseOptimizedStoreActions
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_m_UseOptimizedStoreActions, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_m_UseOptimizedStoreActions, (void*)(&value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0003E74C File Offset: 0x0003C94C
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000071ED File Offset: 0x000053ED
		public unsafe static int k_RenderPassBlockCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_k_RenderPassBlockCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_k_RenderPassBlockCount, (void*)(&value));
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0003E768 File Offset: 0x0003C968
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x000071FB File Offset: 0x000053FB
		public unsafe static RTHandle k_CameraTarget
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_k_CameraTarget, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_k_CameraTarget, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0003E790 File Offset: 0x0003C990
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0000720D File Offset: 0x0000540D
		public unsafe List<ScriptableRenderPass> m_ActiveRenderPassQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveRenderPassQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScriptableRenderPass>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveRenderPassQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0003E7C0 File Offset: 0x0003C9C0
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0000722C File Offset: 0x0000542C
		public unsafe List<ScriptableRendererFeature> m_RendererFeatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_RendererFeatures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScriptableRendererFeature>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_RendererFeatures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0000724B File Offset: 0x0000544B
		public ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraColorTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_CameraColorTarget);
				return new ScriptableRenderer.RTHandleRenderTargetIdentifierCompat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_CameraColorTarget), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0003E820 File Offset: 0x0003CA20
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00007279 File Offset: 0x00005479
		public ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraDepthTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_CameraDepthTarget);
				return new ScriptableRenderer.RTHandleRenderTargetIdentifierCompat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_CameraDepthTarget), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0003E850 File Offset: 0x0003CA50
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x000072A7 File Offset: 0x000054A7
		public ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraResolveTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_CameraResolveTarget);
				return new ScriptableRenderer.RTHandleRenderTargetIdentifierCompat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_CameraResolveTarget), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0003E880 File Offset: 0x0003CA80
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000072D5 File Offset: 0x000054D5
		public unsafe bool m_FirstTimeCameraColorTargetIsBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound)) = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0003E8A8 File Offset: 0x0003CAA8
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x000072F0 File Offset: 0x000054F0
		public unsafe bool m_FirstTimeCameraDepthTargetIsBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound)) = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0003E8D0 File Offset: 0x0003CAD0
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0000730B File Offset: 0x0000550B
		public unsafe bool m_IsPipelineExecuting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_IsPipelineExecuting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_m_IsPipelineExecuting)) = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0003E8F8 File Offset: 0x0003CAF8
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00007326 File Offset: 0x00005526
		public unsafe bool disableNativeRenderPassInFeatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_disableNativeRenderPassInFeatures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_disableNativeRenderPassInFeatures)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0003E920 File Offset: 0x0003CB20
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00007341 File Offset: 0x00005541
		public unsafe bool useRenderPassEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_useRenderPassEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr_useRenderPassEnabled)) = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0003E948 File Offset: 0x0003CB48
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0000735C File Offset: 0x0000555C
		public unsafe static Il2CppStructArray<RenderTargetIdentifier> m_ActiveColorAttachments
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorAttachments, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorAttachments, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0003E970 File Offset: 0x0003CB70
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x0000736E File Offset: 0x0000556E
		public unsafe static RenderTargetIdentifier m_ActiveDepthAttachment
		{
			get
			{
				RenderTargetIdentifier renderTargetIdentifier;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthAttachment, (void*)(&renderTargetIdentifier));
				return renderTargetIdentifier;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthAttachment, (void*)(&value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0003E98C File Offset: 0x0003CB8C
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x0000737C File Offset: 0x0000557C
		public unsafe static Il2CppStructArray<RenderBufferStoreAction> m_ActiveColorStoreActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorStoreActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveColorStoreActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0003E9B4 File Offset: 0x0003CBB4
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x0000738E File Offset: 0x0000558E
		public unsafe static RenderBufferStoreAction m_ActiveDepthStoreAction
		{
			get
			{
				RenderBufferStoreAction renderBufferStoreAction;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthStoreAction, (void*)(&renderBufferStoreAction));
				return renderBufferStoreAction;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_m_ActiveDepthStoreAction, (void*)(&value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0003E9D0 File Offset: 0x0003CBD0
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x0000739C File Offset: 0x0000559C
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<RenderTargetIdentifier>> m_TrimmedColorAttachmentCopies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<RenderTargetIdentifier>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x0003E9F8 File Offset: 0x0003CBF8
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000073AE File Offset: 0x000055AE
		public unsafe static Il2CppStructArray<Plane> s_Planes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_s_Planes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_s_Planes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0003EA20 File Offset: 0x0003CC20
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000073C0 File Offset: 0x000055C0
		public unsafe static Il2CppStructArray<Vector4> s_VectorPlanes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.NativeFieldInfoPtr_s_VectorPlanes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.NativeFieldInfoPtr_s_VectorPlanes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0003EA48 File Offset: 0x0003CC48
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000073D2 File Offset: 0x000055D2
		public unsafe bool _useDepthPriming_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__useDepthPriming_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__useDepthPriming_k__BackingField)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0003EA70 File Offset: 0x0003CC70
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x000073ED File Offset: 0x000055ED
		public unsafe bool _stripShadowsOffVariants_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField)) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0003EA98 File Offset: 0x0003CC98
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00007408 File Offset: 0x00005608
		public unsafe bool _stripAdditionalLightOffVariants_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField)) = value;
			}
		}

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr_kRenderPassMapSize;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr_kRenderPassMaxCount;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeFieldInfoPtr_m_LastBeginSubpassPassIndex;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr_m_MergeableRenderPassesMap;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr_m_PassIndexToPassHash;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPassesAttachmentCount;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalColorStoreAction;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalDepthStoreAction;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeFieldInfoPtr__profilingExecute_k__BackingField;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr_hasReleasedRTs;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeFieldInfoPtr__DebugHandler_k__BackingField;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreActionsOptimizationSetting;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr_m_UseOptimizedStoreActions;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_k_RenderPassBlockCount;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_k_CameraTarget;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveRenderPassQueue;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererFeatures;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraColorTarget;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraDepthTarget;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraResolveTarget;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_m_IsPipelineExecuting;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_disableNativeRenderPassInFeatures;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_useRenderPassEnabled;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveColorAttachments;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDepthAttachment;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveColorStoreActions;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDepthStoreAction;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr_s_Planes;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr_s_VectorPlanes;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr__useDepthPriming_k__BackingField;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraDepth_Public_get_RenderTargetIdentifier_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_ResetNativeRenderPassFrameData_Internal_Void_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_SetupNativeRenderPassFrameData_Internal_Void_byref_CameraData_Boolean_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFinalStoreActions_Internal_Void_Il2CppStructArray_1_Int32_byref_CameraData_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeRenderPassMRTAttachmentList_Internal_Void_ScriptableRenderPass_byref_CameraData_Boolean_ClearFlag_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_IsDepthOnlyRenderTexture_Private_Boolean_RenderTexture_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeRenderPassAttachmentList_Internal_Void_ScriptableRenderPass_byref_CameraData_RTHandle_RTHandle_ClearFlag_Color_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteNativeRenderPass_Internal_Void_ScriptableRenderContext_ScriptableRenderPass_byref_CameraData_byref_RenderingData_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_SetupInputAttachmentIndices_Internal_Void_ScriptableRenderPass_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_SetupTransientInputAttachments_Internal_Void_Int32_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_GetSubPassAttachmentIndicesCount_Internal_Static_UInt32_ScriptableRenderPass_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_AreAttachmentIndicesCompatible_Internal_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_GetValidColorAttachmentCount_Internal_Static_UInt32_Il2CppStructArray_1_AttachmentDescriptor_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_GetValidInputAttachmentCount_Internal_Static_Int32_ScriptableRenderPass_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_Int32_AttachmentDescriptor_Il2CppStructArray_1_AttachmentDescriptor_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_RenderTargetIdentifier_Il2CppStructArray_1_AttachmentDescriptor_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_GetValidPassIndexCount_Internal_Static_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAllocatedRTHandle_Internal_Static_RTHandle_ScriptableRenderPass_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_PassHasInputAttachments_Internal_Static_Boolean_ScriptableRenderPass_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_Int32_Int32_Int32_Int32_UInt32_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_RenderPassDescriptor_UInt32_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureDescriptor_Internal_Static_Void_byref_CameraData_ScriptableRenderPass_byref_RenderTextureDescriptor_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRenderPassDescriptor_Private_RenderPassDescriptor_byref_CameraData_ScriptableRenderPass_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_New_Int32_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_SupportsCameraStackingType_Public_Boolean_CameraRenderType_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_get_profilingExecute_Protected_get_ProfilingSampler_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_set_profilingExecute_Protected_set_Void_ProfilingSampler_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugHandler_Internal_get_DebugHandler_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_byref_CameraData_Boolean_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraMatrices_Internal_Static_Void_CommandBuffer_byref_CameraData_Boolean_Boolean_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_CommandBuffer_byref_CameraData_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_CommandBuffer_byref_CameraData_Boolean_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_SetPerCameraBillboardProperties_Private_Void_CommandBuffer_byref_CameraData_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_CalculateBillboardProperties_Private_Static_Void_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Single_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_CommandBuffer_byref_CameraData_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_CommandBuffer_byref_CameraData_Boolean_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderTimeValues_Private_Static_Void_CommandBuffer_Single_Single_Single_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraColorTarget_Public_get_RenderTargetIdentifier_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraColorTargetHandle_Public_get_RTHandle_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraDepthTarget_Public_get_RenderTargetIdentifier_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraDepthTargetHandle_Public_get_RTHandle_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_get_rendererFeatures_Protected_get_List_1_ScriptableRendererFeature_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_get_activeRenderPassQueue_Protected_get_List_1_ScriptableRenderPass_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_get_supportedRenderingFeatures_Public_get_RenderingFeatures_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_set_supportedRenderingFeatures_Public_set_Void_RenderingFeatures_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_get_unsupportedGraphicsDeviceTypes_Public_get_Il2CppStructArray_1_GraphicsDeviceType_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_set_unsupportedGraphicsDeviceTypes_Public_set_Void_Il2CppStructArray_1_GraphicsDeviceType_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureActiveTarget_Internal_Static_Void_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_get_useDepthPriming_Internal_get_Boolean_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_set_useDepthPriming_Internal_set_Void_Boolean_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_get_Boolean_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_set_Void_Boolean_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_get_Boolean_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_set_Void_Boolean_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptableRendererData_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_New_Void_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RTHandle_RTHandle_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RTHandle_RTHandle_RTHandle_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RenderTargetIdentifier_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RTHandle_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_SetupLights_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_New_Void_byref_ScriptableCullingParameters_byref_CameraData_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_FinishRendering_Public_Virtual_New_Void_CommandBuffer_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_InitRenderGraphFrame_Private_Void_RenderGraph_byref_RenderingData_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVFXCameraCommand_Internal_Void_RenderGraph_byref_RenderingData_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_SetupRenderGraphCameraProperties_Internal_Void_RenderGraph_byref_RenderingData_Boolean_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderGraphGizmos_Internal_Void_RenderGraph_TextureHandle_TextureHandle_GizmoSubset_byref_RenderingData_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderGraphXRRendering_Private_Void_RenderGraph_byref_RenderingData_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderGraphXRRendering_Private_Void_RenderGraph_byref_RenderingData_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_RecordRenderGraph_Internal_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_FinishRenderGraphRendering_Internal_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_ScriptableRenderContext_byref_RenderingData_RenderPassEvent_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_SetPerCameraProperties_Internal_Void_ScriptableRenderContext_byref_CameraData_Camera_CommandBuffer_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_EnqueuePass_Public_Void_ScriptableRenderPass_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_byref_CameraData_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_OnPreCullRenderPasses_Internal_Void_byref_CameraData_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Internal_Void_byref_RenderingData_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_SetupRenderPasses_Protected_Void_byref_RenderingData_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_ClearRenderingState_Private_Static_Void_CommandBuffer_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_CameraRenderType_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteBlock_Private_Void_Int32_byref_RenderBlocks_ScriptableRenderContext_byref_RenderingData_Boolean_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderPassEnabled_Private_Boolean_ScriptableRenderPass_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteRenderPass_Private_Void_ScriptableRenderContext_ScriptableRenderPass_byref_RenderingData_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderPassAttachments_Private_Void_CommandBuffer_ScriptableRenderPass_byref_CameraData_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_BeginXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_EndXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppReferenceArray_1_RTHandle_RTHandle_ClearFlag_Color_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_New_Void_CommandBuffer_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_New_Void_Boolean_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Private_Void_ScriptableRenderContext_Camera_GizmoSubset_byref_RenderingData_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireOverlay_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_InternalStartRendering_Private_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_InternalFinishRendering_Private_Void_Boolean_RenderingData_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_InternalFinishRendering_Private_Void_ScriptableRenderContext_Boolean_RenderingData_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_SortStable_Internal_Static_Void_List_1_ScriptableRenderPass_0;

		// Token: 0x02000185 RID: 389
		public static class Profiling : Object
		{
			// Token: 0x06001D0C RID: 7436 RVA: 0x00076858 File Offset: 0x00074A58
			// Note: this type is marked as 'beforefieldinit'.
			static Profiling()
			{
				Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "Profiling");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr);
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_setMRTAttachmentsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "setMRTAttachmentsList");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_setAttachmentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "setAttachmentList");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_execute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "execute");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupFrameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "setupFrameData");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "k_Name");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_setPerCameraShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "setPerCameraShaderVariables");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_sortRenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "sortRenderPasses");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "setupLights");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "setupCamera");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_vfxProcessCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "vfxProcessCamera");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_addRenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "addRenderPasses");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupRenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "setupRenderPasses");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_clearRenderingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "clearRenderingState");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_internalStartRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "internalStartRendering");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_internalFinishRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "internalFinishRendering");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_drawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "drawGizmos");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_beginXRRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "beginXRRendering");
				ScriptableRenderer.Profiling.NativeFieldInfoPtr_endXRRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "endXRRendering");
			}

			// Token: 0x06001D0D RID: 7437 RVA: 0x00010AA6 File Offset: 0x0000ECA6
			public Profiling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000769EC File Offset: 0x00074BEC
			// (set) Token: 0x06001D0F RID: 7439 RVA: 0x00010AAF File Offset: 0x0000ECAF
			public unsafe static ProfilingSampler setMRTAttachmentsList
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setMRTAttachmentsList, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setMRTAttachmentsList, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00076A14 File Offset: 0x00074C14
			// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00010AC1 File Offset: 0x0000ECC1
			public unsafe static ProfilingSampler setAttachmentList
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setAttachmentList, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setAttachmentList, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00076A3C File Offset: 0x00074C3C
			// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00010AD3 File Offset: 0x0000ECD3
			public unsafe static ProfilingSampler execute
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_execute, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_execute, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00076A64 File Offset: 0x00074C64
			// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00010AE5 File Offset: 0x0000ECE5
			public unsafe static ProfilingSampler setupFrameData
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupFrameData, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupFrameData, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00076A8C File Offset: 0x00074C8C
			// (set) Token: 0x06001D17 RID: 7447 RVA: 0x00010AF7 File Offset: 0x0000ECF7
			public unsafe static string k_Name
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_k_Name, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00076AAC File Offset: 0x00074CAC
			// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00010B09 File Offset: 0x0000ED09
			public unsafe static ProfilingSampler setPerCameraShaderVariables
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setPerCameraShaderVariables, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setPerCameraShaderVariables, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00076AD4 File Offset: 0x00074CD4
			// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00010B1B File Offset: 0x0000ED1B
			public unsafe static ProfilingSampler sortRenderPasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_sortRenderPasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_sortRenderPasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00076AFC File Offset: 0x00074CFC
			// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00010B2D File Offset: 0x0000ED2D
			public unsafe static ProfilingSampler setupLights
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupLights, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupLights, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00076B24 File Offset: 0x00074D24
			// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00010B3F File Offset: 0x0000ED3F
			public unsafe static ProfilingSampler setupCamera
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupCamera, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupCamera, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00076B4C File Offset: 0x00074D4C
			// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00010B51 File Offset: 0x0000ED51
			public unsafe static ProfilingSampler vfxProcessCamera
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_vfxProcessCamera, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_vfxProcessCamera, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00076B74 File Offset: 0x00074D74
			// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00010B63 File Offset: 0x0000ED63
			public unsafe static ProfilingSampler addRenderPasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_addRenderPasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_addRenderPasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00076B9C File Offset: 0x00074D9C
			// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00010B75 File Offset: 0x0000ED75
			public unsafe static ProfilingSampler setupRenderPasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupRenderPasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_setupRenderPasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00076BC4 File Offset: 0x00074DC4
			// (set) Token: 0x06001D27 RID: 7463 RVA: 0x00010B87 File Offset: 0x0000ED87
			public unsafe static ProfilingSampler clearRenderingState
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_clearRenderingState, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_clearRenderingState, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00076BEC File Offset: 0x00074DEC
			// (set) Token: 0x06001D29 RID: 7465 RVA: 0x00010B99 File Offset: 0x0000ED99
			public unsafe static ProfilingSampler internalStartRendering
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_internalStartRendering, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_internalStartRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00076C14 File Offset: 0x00074E14
			// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00010BAB File Offset: 0x0000EDAB
			public unsafe static ProfilingSampler internalFinishRendering
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_internalFinishRendering, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_internalFinishRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00076C3C File Offset: 0x00074E3C
			// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00010BBD File Offset: 0x0000EDBD
			public unsafe static ProfilingSampler drawGizmos
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_drawGizmos, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_drawGizmos, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00076C64 File Offset: 0x00074E64
			// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00010BCF File Offset: 0x0000EDCF
			public unsafe static ProfilingSampler beginXRRendering
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_beginXRRendering, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_beginXRRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00076C8C File Offset: 0x00074E8C
			// (set) Token: 0x06001D31 RID: 7473 RVA: 0x00010BE1 File Offset: 0x0000EDE1
			public unsafe static ProfilingSampler endXRRendering
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_endXRRendering, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.NativeFieldInfoPtr_endXRRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001507 RID: 5383
			private static readonly IntPtr NativeFieldInfoPtr_setMRTAttachmentsList;

			// Token: 0x04001508 RID: 5384
			private static readonly IntPtr NativeFieldInfoPtr_setAttachmentList;

			// Token: 0x04001509 RID: 5385
			private static readonly IntPtr NativeFieldInfoPtr_execute;

			// Token: 0x0400150A RID: 5386
			private static readonly IntPtr NativeFieldInfoPtr_setupFrameData;

			// Token: 0x0400150B RID: 5387
			private static readonly IntPtr NativeFieldInfoPtr_k_Name;

			// Token: 0x0400150C RID: 5388
			private static readonly IntPtr NativeFieldInfoPtr_setPerCameraShaderVariables;

			// Token: 0x0400150D RID: 5389
			private static readonly IntPtr NativeFieldInfoPtr_sortRenderPasses;

			// Token: 0x0400150E RID: 5390
			private static readonly IntPtr NativeFieldInfoPtr_setupLights;

			// Token: 0x0400150F RID: 5391
			private static readonly IntPtr NativeFieldInfoPtr_setupCamera;

			// Token: 0x04001510 RID: 5392
			private static readonly IntPtr NativeFieldInfoPtr_vfxProcessCamera;

			// Token: 0x04001511 RID: 5393
			private static readonly IntPtr NativeFieldInfoPtr_addRenderPasses;

			// Token: 0x04001512 RID: 5394
			private static readonly IntPtr NativeFieldInfoPtr_setupRenderPasses;

			// Token: 0x04001513 RID: 5395
			private static readonly IntPtr NativeFieldInfoPtr_clearRenderingState;

			// Token: 0x04001514 RID: 5396
			private static readonly IntPtr NativeFieldInfoPtr_internalStartRendering;

			// Token: 0x04001515 RID: 5397
			private static readonly IntPtr NativeFieldInfoPtr_internalFinishRendering;

			// Token: 0x04001516 RID: 5398
			private static readonly IntPtr NativeFieldInfoPtr_drawGizmos;

			// Token: 0x04001517 RID: 5399
			private static readonly IntPtr NativeFieldInfoPtr_beginXRRendering;

			// Token: 0x04001518 RID: 5400
			private static readonly IntPtr NativeFieldInfoPtr_endXRRendering;

			// Token: 0x0200023E RID: 574
			public static class RenderBlock : Object
			{
				// Token: 0x060024FE RID: 9470 RVA: 0x0008A4D4 File Offset: 0x000886D4
				// Note: this type is marked as 'beforefieldinit'.
				static RenderBlock()
				{
					Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "RenderBlock");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderBlock>.NativeClassPtr);
					ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderBlock>.NativeClassPtr, "k_Name");
					ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_beforeRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderBlock>.NativeClassPtr, "beforeRendering");
					ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_mainRenderingOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderBlock>.NativeClassPtr, "mainRenderingOpaque");
					ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_mainRenderingTransparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderBlock>.NativeClassPtr, "mainRenderingTransparent");
					ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_afterRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderBlock>.NativeClassPtr, "afterRendering");
				}

				// Token: 0x060024FF RID: 9471 RVA: 0x00015064 File Offset: 0x00013264
				public RenderBlock(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D15 RID: 3349
				// (get) Token: 0x06002500 RID: 9472 RVA: 0x0008A564 File Offset: 0x00088764
				// (set) Token: 0x06002501 RID: 9473 RVA: 0x0001506D File Offset: 0x0001326D
				public unsafe static string k_Name
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_k_Name, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000D16 RID: 3350
				// (get) Token: 0x06002502 RID: 9474 RVA: 0x0008A584 File Offset: 0x00088784
				// (set) Token: 0x06002503 RID: 9475 RVA: 0x0001507F File Offset: 0x0001327F
				public unsafe static ProfilingSampler beforeRendering
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_beforeRendering, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_beforeRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D17 RID: 3351
				// (get) Token: 0x06002504 RID: 9476 RVA: 0x0008A5AC File Offset: 0x000887AC
				// (set) Token: 0x06002505 RID: 9477 RVA: 0x00015091 File Offset: 0x00013291
				public unsafe static ProfilingSampler mainRenderingOpaque
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_mainRenderingOpaque, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_mainRenderingOpaque, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D18 RID: 3352
				// (get) Token: 0x06002506 RID: 9478 RVA: 0x0008A5D4 File Offset: 0x000887D4
				// (set) Token: 0x06002507 RID: 9479 RVA: 0x000150A3 File Offset: 0x000132A3
				public unsafe static ProfilingSampler mainRenderingTransparent
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_mainRenderingTransparent, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_mainRenderingTransparent, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D19 RID: 3353
				// (get) Token: 0x06002508 RID: 9480 RVA: 0x0008A5FC File Offset: 0x000887FC
				// (set) Token: 0x06002509 RID: 9481 RVA: 0x000150B5 File Offset: 0x000132B5
				public unsafe static ProfilingSampler afterRendering
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_afterRendering, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderBlock.NativeFieldInfoPtr_afterRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040019AA RID: 6570
				private static readonly IntPtr NativeFieldInfoPtr_k_Name;

				// Token: 0x040019AB RID: 6571
				private static readonly IntPtr NativeFieldInfoPtr_beforeRendering;

				// Token: 0x040019AC RID: 6572
				private static readonly IntPtr NativeFieldInfoPtr_mainRenderingOpaque;

				// Token: 0x040019AD RID: 6573
				private static readonly IntPtr NativeFieldInfoPtr_mainRenderingTransparent;

				// Token: 0x040019AE RID: 6574
				private static readonly IntPtr NativeFieldInfoPtr_afterRendering;
			}

			// Token: 0x0200023F RID: 575
			public static class RenderPass : Object
			{
				// Token: 0x0600250A RID: 9482 RVA: 0x0008A624 File Offset: 0x00088824
				// Note: this type is marked as 'beforefieldinit'.
				static RenderPass()
				{
					Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer.Profiling>.NativeClassPtr, "RenderPass");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderPass>.NativeClassPtr);
					ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderPass>.NativeClassPtr, "k_Name");
					ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_configure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderPass>.NativeClassPtr, "configure");
					ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_setRenderPassAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.Profiling.RenderPass>.NativeClassPtr, "setRenderPassAttachments");
				}

				// Token: 0x0600250B RID: 9483 RVA: 0x000150C7 File Offset: 0x000132C7
				public RenderPass(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D1A RID: 3354
				// (get) Token: 0x0600250C RID: 9484 RVA: 0x0008A68C File Offset: 0x0008888C
				// (set) Token: 0x0600250D RID: 9485 RVA: 0x000150D0 File Offset: 0x000132D0
				public unsafe static string k_Name
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_k_Name, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000D1B RID: 3355
				// (get) Token: 0x0600250E RID: 9486 RVA: 0x0008A6AC File Offset: 0x000888AC
				// (set) Token: 0x0600250F RID: 9487 RVA: 0x000150E2 File Offset: 0x000132E2
				public unsafe static ProfilingSampler configure
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_configure, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_configure, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D1C RID: 3356
				// (get) Token: 0x06002510 RID: 9488 RVA: 0x0008A6D4 File Offset: 0x000888D4
				// (set) Token: 0x06002511 RID: 9489 RVA: 0x000150F4 File Offset: 0x000132F4
				public unsafe static ProfilingSampler setRenderPassAttachments
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_setRenderPassAttachments, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.Profiling.RenderPass.NativeFieldInfoPtr_setRenderPassAttachments, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040019AF RID: 6575
				private static readonly IntPtr NativeFieldInfoPtr_k_Name;

				// Token: 0x040019B0 RID: 6576
				private static readonly IntPtr NativeFieldInfoPtr_configure;

				// Token: 0x040019B1 RID: 6577
				private static readonly IntPtr NativeFieldInfoPtr_setRenderPassAttachments;
			}
		}

		// Token: 0x02000186 RID: 390
		[StructLayout(2)]
		public struct RenderPassDescriptor
		{
			// Token: 0x06001D32 RID: 7474 RVA: 0x00076CB4 File Offset: 0x00074EB4
			// Note: this type is marked as 'beforefieldinit'.
			static RenderPassDescriptor()
			{
				Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderPassDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr);
				ScriptableRenderer.RenderPassDescriptor.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr, "w");
				ScriptableRenderer.RenderPassDescriptor.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr, "h");
				ScriptableRenderer.RenderPassDescriptor.NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr, "samples");
				ScriptableRenderer.RenderPassDescriptor.NativeFieldInfoPtr_depthID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr, "depthID");
				ScriptableRenderer.RenderPassDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr, 100664840);
			}

			// Token: 0x06001D33 RID: 7475 RVA: 0x00076D44 File Offset: 0x00074F44
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderPassDescriptor(int width, int height, int sampleCount, int rtID)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref width;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rtID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderPassDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x00010BF3 File Offset: 0x0000EDF3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderer.RenderPassDescriptor>.NativeClassPtr, ref this));
			}

			// Token: 0x04001519 RID: 5401
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x0400151A RID: 5402
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x0400151B RID: 5403
			private static readonly IntPtr NativeFieldInfoPtr_samples;

			// Token: 0x0400151C RID: 5404
			private static readonly IntPtr NativeFieldInfoPtr_depthID;

			// Token: 0x0400151D RID: 5405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0;

			// Token: 0x0400151E RID: 5406
			[FieldOffset(0)]
			public int w;

			// Token: 0x0400151F RID: 5407
			[FieldOffset(4)]
			public int h;

			// Token: 0x04001520 RID: 5408
			[FieldOffset(8)]
			public int samples;

			// Token: 0x04001521 RID: 5409
			[FieldOffset(12)]
			public int depthID;
		}

		// Token: 0x02000187 RID: 391
		public class RenderingFeatures : Object
		{
			// Token: 0x06001D35 RID: 7477 RVA: 0x00076DA0 File Offset: 0x00074FA0
			// Note: this type is marked as 'beforefieldinit'.
			static RenderingFeatures()
			{
				Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderingFeatures");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr);
				ScriptableRenderer.RenderingFeatures.NativeFieldInfoPtr__cameraStacking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr, "<cameraStacking>k__BackingField");
				ScriptableRenderer.RenderingFeatures.NativeFieldInfoPtr__msaa_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr, "<msaa>k__BackingField");
				ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_get_cameraStacking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr, 100664841);
				ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_set_cameraStacking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr, 100664842);
				ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_get_msaa_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr, 100664843);
				ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_set_msaa_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr, 100664844);
				ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr, 100664845);
			}

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00076E58 File Offset: 0x00075058
			// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00076E94 File Offset: 0x00075094
			public unsafe bool cameraStacking
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_get_cameraStacking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_set_cameraStacking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00076ED4 File Offset: 0x000750D4
			// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00076F10 File Offset: 0x00075110
			public unsafe bool msaa
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_get_msaa_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr_set_msaa_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x00076F50 File Offset: 0x00075150
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 608769, RefRangeEnd = 608772, XrefRangeStart = 608768, XrefRangeEnd = 608769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderingFeatures()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.RenderingFeatures>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D3B RID: 7483 RVA: 0x00010C05 File Offset: 0x0000EE05
			public RenderingFeatures(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00076F8C File Offset: 0x0007518C
			// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00010C0E File Offset: 0x0000EE0E
			public unsafe bool _cameraStacking_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderingFeatures.NativeFieldInfoPtr__cameraStacking_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderingFeatures.NativeFieldInfoPtr__cameraStacking_k__BackingField)) = value;
				}
			}

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00076FB4 File Offset: 0x000751B4
			// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00010C29 File Offset: 0x0000EE29
			public unsafe bool _msaa_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderingFeatures.NativeFieldInfoPtr__msaa_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderingFeatures.NativeFieldInfoPtr__msaa_k__BackingField)) = value;
				}
			}

			// Token: 0x04001522 RID: 5410
			private static readonly IntPtr NativeFieldInfoPtr__cameraStacking_k__BackingField;

			// Token: 0x04001523 RID: 5411
			private static readonly IntPtr NativeFieldInfoPtr__msaa_k__BackingField;

			// Token: 0x04001524 RID: 5412
			private static readonly IntPtr NativeMethodInfoPtr_get_cameraStacking_Public_get_Boolean_0;

			// Token: 0x04001525 RID: 5413
			private static readonly IntPtr NativeMethodInfoPtr_set_cameraStacking_Public_set_Void_Boolean_0;

			// Token: 0x04001526 RID: 5414
			private static readonly IntPtr NativeMethodInfoPtr_get_msaa_Public_get_Boolean_0;

			// Token: 0x04001527 RID: 5415
			private static readonly IntPtr NativeMethodInfoPtr_set_msaa_Public_set_Void_Boolean_0;

			// Token: 0x04001528 RID: 5416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000188 RID: 392
		public static class RenderPassBlock : Object
		{
			// Token: 0x06001D40 RID: 7488 RVA: 0x00076FDC File Offset: 0x000751DC
			// Note: this type is marked as 'beforefieldinit'.
			static RenderPassBlock()
			{
				Il2CppClassPointerStore<ScriptableRenderer.RenderPassBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderPassBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.RenderPassBlock>.NativeClassPtr);
				ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_BeforeRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassBlock>.NativeClassPtr, "BeforeRendering");
				ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_MainRenderingOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassBlock>.NativeClassPtr, "MainRenderingOpaque");
				ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_MainRenderingTransparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassBlock>.NativeClassPtr, "MainRenderingTransparent");
				ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_AfterRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderPassBlock>.NativeClassPtr, "AfterRendering");
			}

			// Token: 0x06001D41 RID: 7489 RVA: 0x00010C44 File Offset: 0x0000EE44
			public RenderPassBlock(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00077058 File Offset: 0x00075258
			// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00010C4D File Offset: 0x0000EE4D
			public unsafe static int BeforeRendering
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_BeforeRendering, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_BeforeRendering, (void*)(&value));
				}
			}

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00077074 File Offset: 0x00075274
			// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00010C5B File Offset: 0x0000EE5B
			public unsafe static int MainRenderingOpaque
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_MainRenderingOpaque, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_MainRenderingOpaque, (void*)(&value));
				}
			}

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00077090 File Offset: 0x00075290
			// (set) Token: 0x06001D47 RID: 7495 RVA: 0x00010C69 File Offset: 0x0000EE69
			public unsafe static int MainRenderingTransparent
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_MainRenderingTransparent, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_MainRenderingTransparent, (void*)(&value));
				}
			}

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000770AC File Offset: 0x000752AC
			// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00010C77 File Offset: 0x0000EE77
			public unsafe static int AfterRendering
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_AfterRendering, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.RenderPassBlock.NativeFieldInfoPtr_AfterRendering, (void*)(&value));
				}
			}

			// Token: 0x04001529 RID: 5417
			private static readonly IntPtr NativeFieldInfoPtr_BeforeRendering;

			// Token: 0x0400152A RID: 5418
			private static readonly IntPtr NativeFieldInfoPtr_MainRenderingOpaque;

			// Token: 0x0400152B RID: 5419
			private static readonly IntPtr NativeFieldInfoPtr_MainRenderingTransparent;

			// Token: 0x0400152C RID: 5420
			private static readonly IntPtr NativeFieldInfoPtr_AfterRendering;
		}

		// Token: 0x02000189 RID: 393
		public sealed class RTHandleRenderTargetIdentifierCompat : ValueType
		{
			// Token: 0x06001D4A RID: 7498 RVA: 0x000770C8 File Offset: 0x000752C8
			// Note: this type is marked as 'beforefieldinit'.
			static RTHandleRenderTargetIdentifierCompat()
			{
				Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RTHandleRenderTargetIdentifierCompat");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr);
				ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, "handle");
				ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeFieldInfoPtr_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, "fallback");
				ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeMethodInfoPtr_get_useRTHandle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, 100664847);
				ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeMethodInfoPtr_get_nameID_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr, 100664848);
			}

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00077144 File Offset: 0x00075344
			public unsafe bool useRTHandle
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 608772, RefRangeEnd = 608784, XrefRangeStart = 608772, XrefRangeEnd = 608772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeMethodInfoPtr_get_useRTHandle_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00077188 File Offset: 0x00075388
			public unsafe RenderTargetIdentifier nameID
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 608785, RefRangeEnd = 608797, XrefRangeStart = 608784, XrefRangeEnd = 608785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeMethodInfoPtr_get_nameID_Public_get_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D4D RID: 7501 RVA: 0x00010C85 File Offset: 0x0000EE85
			public RTHandleRenderTargetIdentifierCompat(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D4E RID: 7502 RVA: 0x00010C8E File Offset: 0x0000EE8E
			public RTHandleRenderTargetIdentifierCompat()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.RTHandleRenderTargetIdentifierCompat>.NativeClassPtr))
			{
			}

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x06001D4F RID: 7503 RVA: 0x000771CC File Offset: 0x000753CC
			// (set) Token: 0x06001D50 RID: 7504 RVA: 0x00010CA0 File Offset: 0x0000EEA0
			public unsafe RTHandle handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeFieldInfoPtr_handle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x06001D51 RID: 7505 RVA: 0x000771FC File Offset: 0x000753FC
			// (set) Token: 0x06001D52 RID: 7506 RVA: 0x00010CBF File Offset: 0x0000EEBF
			public unsafe RenderTargetIdentifier fallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeFieldInfoPtr_fallback);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RTHandleRenderTargetIdentifierCompat.NativeFieldInfoPtr_fallback)) = value;
				}
			}

			// Token: 0x0400152D RID: 5421
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x0400152E RID: 5422
			private static readonly IntPtr NativeFieldInfoPtr_fallback;

			// Token: 0x0400152F RID: 5423
			private static readonly IntPtr NativeMethodInfoPtr_get_useRTHandle_Public_get_Boolean_0;

			// Token: 0x04001530 RID: 5424
			private static readonly IntPtr NativeMethodInfoPtr_get_nameID_Public_get_RenderTargetIdentifier_0;
		}

		// Token: 0x0200018A RID: 394
		public class VFXProcessCameraPassData : Object
		{
			// Token: 0x06001D53 RID: 7507 RVA: 0x00077224 File Offset: 0x00075424
			// Note: this type is marked as 'beforefieldinit'.
			static VFXProcessCameraPassData()
			{
				Il2CppClassPointerStore<ScriptableRenderer.VFXProcessCameraPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "VFXProcessCameraPassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.VFXProcessCameraPassData>.NativeClassPtr);
				ScriptableRenderer.VFXProcessCameraPassData.NativeFieldInfoPtr_cullResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.VFXProcessCameraPassData>.NativeClassPtr, "cullResults");
				ScriptableRenderer.VFXProcessCameraPassData.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.VFXProcessCameraPassData>.NativeClassPtr, "camera");
				ScriptableRenderer.VFXProcessCameraPassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.VFXProcessCameraPassData>.NativeClassPtr, 100664849);
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0007728C File Offset: 0x0007548C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VFXProcessCameraPassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.VFXProcessCameraPassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.VFXProcessCameraPassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D55 RID: 7509 RVA: 0x00010CDA File Offset: 0x0000EEDA
			public VFXProcessCameraPassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000772C8 File Offset: 0x000754C8
			// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00010CE3 File Offset: 0x0000EEE3
			public unsafe CullingResults cullResults
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.VFXProcessCameraPassData.NativeFieldInfoPtr_cullResults);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.VFXProcessCameraPassData.NativeFieldInfoPtr_cullResults)) = value;
				}
			}

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000772F0 File Offset: 0x000754F0
			// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00010CFE File Offset: 0x0000EEFE
			public unsafe Camera camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.VFXProcessCameraPassData.NativeFieldInfoPtr_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.VFXProcessCameraPassData.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001531 RID: 5425
			private static readonly IntPtr NativeFieldInfoPtr_cullResults;

			// Token: 0x04001532 RID: 5426
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x04001533 RID: 5427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018B RID: 395
		public class DrawGizmosPassData : Object
		{
			// Token: 0x06001D5A RID: 7514 RVA: 0x00077320 File Offset: 0x00075520
			// Note: this type is marked as 'beforefieldinit'.
			static DrawGizmosPassData()
			{
				Il2CppClassPointerStore<ScriptableRenderer.DrawGizmosPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "DrawGizmosPassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.DrawGizmosPassData>.NativeClassPtr);
				ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.DrawGizmosPassData>.NativeClassPtr, "renderingData");
				ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.DrawGizmosPassData>.NativeClassPtr, "renderer");
				ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_gizmoSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.DrawGizmosPassData>.NativeClassPtr, "gizmoSubset");
				ScriptableRenderer.DrawGizmosPassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.DrawGizmosPassData>.NativeClassPtr, 100664850);
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x0007739C File Offset: 0x0007559C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrawGizmosPassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.DrawGizmosPassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.DrawGizmosPassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D5C RID: 7516 RVA: 0x00010D1D File Offset: 0x0000EF1D
			public DrawGizmosPassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x06001D5D RID: 7517 RVA: 0x000773D8 File Offset: 0x000755D8
			// (set) Token: 0x06001D5E RID: 7518 RVA: 0x00010D26 File Offset: 0x0000EF26
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00077408 File Offset: 0x00075608
			// (set) Token: 0x06001D60 RID: 7520 RVA: 0x00010D54 File Offset: 0x0000EF54
			public unsafe ScriptableRenderer renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00077438 File Offset: 0x00075638
			// (set) Token: 0x06001D62 RID: 7522 RVA: 0x00010D73 File Offset: 0x0000EF73
			public unsafe GizmoSubset gizmoSubset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_gizmoSubset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.DrawGizmosPassData.NativeFieldInfoPtr_gizmoSubset)) = value;
				}
			}

			// Token: 0x04001534 RID: 5428
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x04001535 RID: 5429
			private static readonly IntPtr NativeFieldInfoPtr_renderer;

			// Token: 0x04001536 RID: 5430
			private static readonly IntPtr NativeFieldInfoPtr_gizmoSubset;

			// Token: 0x04001537 RID: 5431
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018C RID: 396
		public class BeginXRPassData : Object
		{
			// Token: 0x06001D63 RID: 7523 RVA: 0x00077460 File Offset: 0x00075660
			// Note: this type is marked as 'beforefieldinit'.
			static BeginXRPassData()
			{
				Il2CppClassPointerStore<ScriptableRenderer.BeginXRPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "BeginXRPassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.BeginXRPassData>.NativeClassPtr);
				ScriptableRenderer.BeginXRPassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.BeginXRPassData>.NativeClassPtr, "renderingData");
				ScriptableRenderer.BeginXRPassData.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.BeginXRPassData>.NativeClassPtr, "cameraData");
				ScriptableRenderer.BeginXRPassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.BeginXRPassData>.NativeClassPtr, 100664851);
			}

			// Token: 0x06001D64 RID: 7524 RVA: 0x000774C8 File Offset: 0x000756C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BeginXRPassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.BeginXRPassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.BeginXRPassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D65 RID: 7525 RVA: 0x00010D8E File Offset: 0x0000EF8E
			public BeginXRPassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00077504 File Offset: 0x00075704
			// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00010D97 File Offset: 0x0000EF97
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.BeginXRPassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.BeginXRPassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00077534 File Offset: 0x00075734
			// (set) Token: 0x06001D69 RID: 7529 RVA: 0x00010DC5 File Offset: 0x0000EFC5
			public CameraData cameraData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.BeginXRPassData.NativeFieldInfoPtr_cameraData);
					return new CameraData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.BeginXRPassData.NativeFieldInfoPtr_cameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001538 RID: 5432
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x04001539 RID: 5433
			private static readonly IntPtr NativeFieldInfoPtr_cameraData;

			// Token: 0x0400153A RID: 5434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018D RID: 397
		public class EndXRPassData : Object
		{
			// Token: 0x06001D6A RID: 7530 RVA: 0x00077564 File Offset: 0x00075764
			// Note: this type is marked as 'beforefieldinit'.
			static EndXRPassData()
			{
				Il2CppClassPointerStore<ScriptableRenderer.EndXRPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "EndXRPassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.EndXRPassData>.NativeClassPtr);
				ScriptableRenderer.EndXRPassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.EndXRPassData>.NativeClassPtr, "renderingData");
				ScriptableRenderer.EndXRPassData.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.EndXRPassData>.NativeClassPtr, "cameraData");
				ScriptableRenderer.EndXRPassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.EndXRPassData>.NativeClassPtr, 100664852);
			}

			// Token: 0x06001D6B RID: 7531 RVA: 0x000775CC File Offset: 0x000757CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EndXRPassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.EndXRPassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.EndXRPassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D6C RID: 7532 RVA: 0x00010DF3 File Offset: 0x0000EFF3
			public EndXRPassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00077608 File Offset: 0x00075808
			// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00010DFC File Offset: 0x0000EFFC
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.EndXRPassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.EndXRPassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00077638 File Offset: 0x00075838
			// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00010E2A File Offset: 0x0000F02A
			public CameraData cameraData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.EndXRPassData.NativeFieldInfoPtr_cameraData);
					return new CameraData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.EndXRPassData.NativeFieldInfoPtr_cameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400153B RID: 5435
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x0400153C RID: 5436
			private static readonly IntPtr NativeFieldInfoPtr_cameraData;

			// Token: 0x0400153D RID: 5437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018E RID: 398
		public class PassData : Object
		{
			// Token: 0x06001D71 RID: 7537 RVA: 0x00077668 File Offset: 0x00075868
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr);
				ScriptableRenderer.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr, "renderingData");
				ScriptableRenderer.PassData.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr, "renderer");
				ScriptableRenderer.PassData.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr, "cameraData");
				ScriptableRenderer.PassData.NativeFieldInfoPtr_isTargetBackbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr, "isTargetBackbuffer");
				ScriptableRenderer.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr, 100664853);
			}

			// Token: 0x06001D72 RID: 7538 RVA: 0x000776F8 File Offset: 0x000758F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D73 RID: 7539 RVA: 0x00010E58 File Offset: 0x0000F058
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00077734 File Offset: 0x00075934
			// (set) Token: 0x06001D75 RID: 7541 RVA: 0x00010E61 File Offset: 0x0000F061
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00077764 File Offset: 0x00075964
			// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00010E8F File Offset: 0x0000F08F
			public unsafe ScriptableRenderer renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00077794 File Offset: 0x00075994
			// (set) Token: 0x06001D79 RID: 7545 RVA: 0x00010EAE File Offset: 0x0000F0AE
			public CameraData cameraData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_cameraData);
					return new CameraData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_cameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000777C4 File Offset: 0x000759C4
			// (set) Token: 0x06001D7B RID: 7547 RVA: 0x00010EDC File Offset: 0x0000F0DC
			public unsafe bool isTargetBackbuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_isTargetBackbuffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.PassData.NativeFieldInfoPtr_isTargetBackbuffer)) = value;
				}
			}

			// Token: 0x0400153E RID: 5438
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x0400153F RID: 5439
			private static readonly IntPtr NativeFieldInfoPtr_renderer;

			// Token: 0x04001540 RID: 5440
			private static readonly IntPtr NativeFieldInfoPtr_cameraData;

			// Token: 0x04001541 RID: 5441
			private static readonly IntPtr NativeFieldInfoPtr_isTargetBackbuffer;

			// Token: 0x04001542 RID: 5442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018F RID: 399
		public sealed class RenderBlocks : ValueType
		{
			// Token: 0x06001D7C RID: 7548 RVA: 0x000777EC File Offset: 0x000759EC
			// Note: this type is marked as 'beforefieldinit'.
			static RenderBlocks()
			{
				Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderBlocks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr);
				ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockEventLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, "m_BlockEventLimits");
				ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, "m_BlockRanges");
				ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockRangeLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, "m_BlockRangeLengths");
				ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr__ctor_Public_Void_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, 100664854);
				ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, 100664855);
				ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_FillBlockRanges_Private_Void_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, 100664856);
				ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, 100664857);
				ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_GetRange_Public_BlockRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, 100664858);
			}

			// Token: 0x06001D7D RID: 7549 RVA: 0x000778B8 File Offset: 0x00075AB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 608822, RefRangeEnd = 608823, XrefRangeStart = 608798, XrefRangeEnd = 608822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeRenderPassQueue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr__ctor_Public_Void_List_1_ScriptableRenderPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D7E RID: 7550 RVA: 0x00077908 File Offset: 0x00075B08
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 608828, RefRangeEnd = 608830, XrefRangeStart = 608823, XrefRangeEnd = 608828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D7F RID: 7551 RVA: 0x00077940 File Offset: 0x00075B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608830, XrefRangeEnd = 608836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeRenderPassQueue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_FillBlockRanges_Private_Void_List_1_ScriptableRenderPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D80 RID: 7552 RVA: 0x00077988 File Offset: 0x00075B88
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 608836, RefRangeEnd = 608840, XrefRangeStart = 608836, XrefRangeEnd = 608836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetLength(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D81 RID: 7553 RVA: 0x000779D8 File Offset: 0x00075BD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 608840, RefRangeEnd = 608841, XrefRangeStart = 608840, XrefRangeEnd = 608840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.NativeMethodInfoPtr_GetRange_Public_BlockRange_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D82 RID: 7554 RVA: 0x00010EF7 File Offset: 0x0000F0F7
			public RenderBlocks(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D83 RID: 7555 RVA: 0x00010F00 File Offset: 0x0000F100
			public RenderBlocks()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr))
			{
			}

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00077A28 File Offset: 0x00075C28
			// (set) Token: 0x06001D85 RID: 7557 RVA: 0x00010F12 File Offset: 0x0000F112
			public NativeArray<RenderPassEvent> m_BlockEventLimits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockEventLimits);
					return new NativeArray<RenderPassEvent>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RenderPassEvent>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockEventLimits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RenderPassEvent>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x06001D86 RID: 7558 RVA: 0x00077A58 File Offset: 0x00075C58
			// (set) Token: 0x06001D87 RID: 7559 RVA: 0x00010F40 File Offset: 0x0000F140
			public NativeArray<int> m_BlockRanges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockRanges);
					return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00077A88 File Offset: 0x00075C88
			// (set) Token: 0x06001D89 RID: 7561 RVA: 0x00010F6E File Offset: 0x0000F16E
			public NativeArray<int> m_BlockRangeLengths
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockRangeLengths);
					return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderer.RenderBlocks.NativeFieldInfoPtr_m_BlockRangeLengths), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001543 RID: 5443
			private static readonly IntPtr NativeFieldInfoPtr_m_BlockEventLimits;

			// Token: 0x04001544 RID: 5444
			private static readonly IntPtr NativeFieldInfoPtr_m_BlockRanges;

			// Token: 0x04001545 RID: 5445
			private static readonly IntPtr NativeFieldInfoPtr_m_BlockRangeLengths;

			// Token: 0x04001546 RID: 5446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ScriptableRenderPass_0;

			// Token: 0x04001547 RID: 5447
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001548 RID: 5448
			private static readonly IntPtr NativeMethodInfoPtr_FillBlockRanges_Private_Void_List_1_ScriptableRenderPass_0;

			// Token: 0x04001549 RID: 5449
			private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0;

			// Token: 0x0400154A RID: 5450
			private static readonly IntPtr NativeMethodInfoPtr_GetRange_Public_BlockRange_Int32_0;

			// Token: 0x02000240 RID: 576
			[StructLayout(2)]
			public struct BlockRange
			{
				// Token: 0x06002512 RID: 9490 RVA: 0x0008A6FC File Offset: 0x000888FC
				// Note: this type is marked as 'beforefieldinit'.
				static BlockRange()
				{
					Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks>.NativeClassPtr, "BlockRange");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr);
					ScriptableRenderer.RenderBlocks.BlockRange.NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, "m_Current");
					ScriptableRenderer.RenderBlocks.BlockRange.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, "m_End");
					ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, 100664859);
					ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_GetEnumerator_Public_BlockRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, 100664860);
					ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, 100664861);
					ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_get_Current_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, 100664862);
					ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, 100664863);
				}

				// Token: 0x06002513 RID: 9491 RVA: 0x0008A7B4 File Offset: 0x000889B4
				[CallerCount(0)]
				public unsafe BlockRange(int begin, int end)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref begin;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002514 RID: 9492 RVA: 0x0008A7F4 File Offset: 0x000889F4
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ScriptableRenderer.RenderBlocks.BlockRange GetEnumerator()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_GetEnumerator_Public_BlockRange_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002515 RID: 9493 RVA: 0x0008A824 File Offset: 0x00088A24
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 608797, RefRangeEnd = 608798, XrefRangeStart = 608797, XrefRangeEnd = 608797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000D1D RID: 3357
				// (get) Token: 0x06002516 RID: 9494 RVA: 0x0008A854 File Offset: 0x00088A54
				public unsafe int Current
				{
					[CallerCount(200)]
					[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_get_Current_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06002517 RID: 9495 RVA: 0x0008A884 File Offset: 0x00088A84
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.RenderBlocks.BlockRange.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002518 RID: 9496 RVA: 0x00015106 File Offset: 0x00013306
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderer.RenderBlocks.BlockRange>.NativeClassPtr, ref this));
				}

				// Token: 0x040019B2 RID: 6578
				private static readonly IntPtr NativeFieldInfoPtr_m_Current;

				// Token: 0x040019B3 RID: 6579
				private static readonly IntPtr NativeFieldInfoPtr_m_End;

				// Token: 0x040019B4 RID: 6580
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

				// Token: 0x040019B5 RID: 6581
				private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_BlockRange_0;

				// Token: 0x040019B6 RID: 6582
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

				// Token: 0x040019B7 RID: 6583
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_Int32_0;

				// Token: 0x040019B8 RID: 6584
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x040019B9 RID: 6585
				[FieldOffset(0)]
				public int m_Current;

				// Token: 0x040019BA RID: 6586
				[FieldOffset(4)]
				public int m_End;
			}
		}

		// Token: 0x02000190 RID: 400
		[ObfuscatedName("UnityEngine.Rendering.Universal.ScriptableRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D8A RID: 7562 RVA: 0x00077AB8 File Offset: 0x00075CB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr);
				ScriptableRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, "<>9");
				ScriptableRenderer.__c.NativeFieldInfoPtr___9__132_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, "<>9__132_0");
				ScriptableRenderer.__c.NativeFieldInfoPtr___9__134_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, "<>9__134_0");
				ScriptableRenderer.__c.NativeFieldInfoPtr___9__135_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, "<>9__135_0");
				ScriptableRenderer.__c.NativeFieldInfoPtr___9__137_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, "<>9__137_0");
				ScriptableRenderer.__c.NativeFieldInfoPtr___9__139_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, "<>9__139_0");
				ScriptableRenderer.__c.NativeFieldInfoPtr___9__141_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, "<>9__141_0");
				ScriptableRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, 100664865);
				ScriptableRenderer.__c.NativeMethodInfoPtr__InitRenderGraphFrame_b__132_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, 100664866);
				ScriptableRenderer.__c.NativeMethodInfoPtr__ProcessVFXCameraCommand_b__134_0_Internal_Void_VFXProcessCameraPassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, 100664867);
				ScriptableRenderer.__c.NativeMethodInfoPtr__SetupRenderGraphCameraProperties_b__135_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, 100664868);
				ScriptableRenderer.__c.NativeMethodInfoPtr__DrawRenderGraphGizmos_b__137_0_Internal_Void_DrawGizmosPassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, 100664869);
				ScriptableRenderer.__c.NativeMethodInfoPtr__BeginRenderGraphXRRendering_b__139_0_Internal_Void_BeginXRPassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, 100664870);
				ScriptableRenderer.__c.NativeMethodInfoPtr__EndRenderGraphXRRendering_b__141_0_Internal_Void_EndXRPassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr, 100664871);
			}

			// Token: 0x06001D8B RID: 7563 RVA: 0x00077BFC File Offset: 0x00075DFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D8C RID: 7564 RVA: 0x00077C38 File Offset: 0x00075E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608841, XrefRangeEnd = 608850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRenderGraphFrame_b__132_0(ScriptableRenderer.PassData data, RenderGraphContext rgContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.__c.NativeMethodInfoPtr__InitRenderGraphFrame_b__132_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D8D RID: 7565 RVA: 0x00077C8C File Offset: 0x00075E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608850, XrefRangeEnd = 608854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessVFXCameraCommand_b__134_0(ScriptableRenderer.VFXProcessCameraPassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.__c.NativeMethodInfoPtr__ProcessVFXCameraCommand_b__134_0_Internal_Void_VFXProcessCameraPassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D8E RID: 7566 RVA: 0x00077CE0 File Offset: 0x00075EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608854, XrefRangeEnd = 608870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupRenderGraphCameraProperties_b__135_0(ScriptableRenderer.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.__c.NativeMethodInfoPtr__SetupRenderGraphCameraProperties_b__135_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D8F RID: 7567 RVA: 0x00077D34 File Offset: 0x00075F34
			[CallerCount(0)]
			public unsafe void _DrawRenderGraphGizmos_b__137_0(ScriptableRenderer.DrawGizmosPassData data, RenderGraphContext rgContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.__c.NativeMethodInfoPtr__DrawRenderGraphGizmos_b__137_0_Internal_Void_DrawGizmosPassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D90 RID: 7568 RVA: 0x00077D88 File Offset: 0x00075F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608870, XrefRangeEnd = 608880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginRenderGraphXRRendering_b__139_0(ScriptableRenderer.BeginXRPassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.__c.NativeMethodInfoPtr__BeginRenderGraphXRRendering_b__139_0_Internal_Void_BeginXRPassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D91 RID: 7569 RVA: 0x00077DDC File Offset: 0x00075FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608880, XrefRangeEnd = 608887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EndRenderGraphXRRendering_b__141_0(ScriptableRenderer.EndXRPassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderer.__c.NativeMethodInfoPtr__EndRenderGraphXRRendering_b__141_0_Internal_Void_EndXRPassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D92 RID: 7570 RVA: 0x00010F9C File Offset: 0x0000F19C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00077E30 File Offset: 0x00076030
			// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00010FA5 File Offset: 0x0000F1A5
			public unsafe static ScriptableRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00077E58 File Offset: 0x00076058
			// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00010FB7 File Offset: 0x0000F1B7
			public unsafe static RenderFunc<ScriptableRenderer.PassData> __9__132_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__132_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ScriptableRenderer.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__132_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A90 RID: 2704
			// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00077E80 File Offset: 0x00076080
			// (set) Token: 0x06001D98 RID: 7576 RVA: 0x00010FC9 File Offset: 0x0000F1C9
			public unsafe static RenderFunc<ScriptableRenderer.VFXProcessCameraPassData> __9__134_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__134_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ScriptableRenderer.VFXProcessCameraPassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__134_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A91 RID: 2705
			// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00077EA8 File Offset: 0x000760A8
			// (set) Token: 0x06001D9A RID: 7578 RVA: 0x00010FDB File Offset: 0x0000F1DB
			public unsafe static RenderFunc<ScriptableRenderer.PassData> __9__135_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__135_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ScriptableRenderer.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__135_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A92 RID: 2706
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00077ED0 File Offset: 0x000760D0
			// (set) Token: 0x06001D9C RID: 7580 RVA: 0x00010FED File Offset: 0x0000F1ED
			public unsafe static RenderFunc<ScriptableRenderer.DrawGizmosPassData> __9__137_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__137_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ScriptableRenderer.DrawGizmosPassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__137_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A93 RID: 2707
			// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00077EF8 File Offset: 0x000760F8
			// (set) Token: 0x06001D9E RID: 7582 RVA: 0x00010FFF File Offset: 0x0000F1FF
			public unsafe static RenderFunc<ScriptableRenderer.BeginXRPassData> __9__139_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__139_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ScriptableRenderer.BeginXRPassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__139_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A94 RID: 2708
			// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00077F20 File Offset: 0x00076120
			// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x00011011 File Offset: 0x0000F211
			public unsafe static RenderFunc<ScriptableRenderer.EndXRPassData> __9__141_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__141_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ScriptableRenderer.EndXRPassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptableRenderer.__c.NativeFieldInfoPtr___9__141_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400154B RID: 5451
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400154C RID: 5452
			private static readonly IntPtr NativeFieldInfoPtr___9__132_0;

			// Token: 0x0400154D RID: 5453
			private static readonly IntPtr NativeFieldInfoPtr___9__134_0;

			// Token: 0x0400154E RID: 5454
			private static readonly IntPtr NativeFieldInfoPtr___9__135_0;

			// Token: 0x0400154F RID: 5455
			private static readonly IntPtr NativeFieldInfoPtr___9__137_0;

			// Token: 0x04001550 RID: 5456
			private static readonly IntPtr NativeFieldInfoPtr___9__139_0;

			// Token: 0x04001551 RID: 5457
			private static readonly IntPtr NativeFieldInfoPtr___9__141_0;

			// Token: 0x04001552 RID: 5458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeMethodInfoPtr__InitRenderGraphFrame_b__132_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeMethodInfoPtr__ProcessVFXCameraCommand_b__134_0_Internal_Void_VFXProcessCameraPassData_RenderGraphContext_0;

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeMethodInfoPtr__SetupRenderGraphCameraProperties_b__135_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x04001556 RID: 5462
			private static readonly IntPtr NativeMethodInfoPtr__DrawRenderGraphGizmos_b__137_0_Internal_Void_DrawGizmosPassData_RenderGraphContext_0;

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeMethodInfoPtr__BeginRenderGraphXRRendering_b__139_0_Internal_Void_BeginXRPassData_RenderGraphContext_0;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeMethodInfoPtr__EndRenderGraphXRRendering_b__141_0_Internal_Void_EndXRPassData_RenderGraphContext_0;
		}
	}
}
