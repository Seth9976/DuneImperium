using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200007C RID: 124
	public class ScriptableRenderPass : Object
	{
		// Token: 0x06000A72 RID: 2674 RVA: 0x00038F0C File Offset: 0x0003710C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRenderPass()
		{
			Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScriptableRenderPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr);
			ScriptableRenderPass.NativeFieldInfoPtr_k_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "k_CameraTarget");
			ScriptableRenderPass.NativeFieldInfoPtr__renderPassEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<renderPassEvent>k__BackingField");
			ScriptableRenderPass.NativeFieldInfoPtr_m_ColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ColorStoreActions");
			ScriptableRenderPass.NativeFieldInfoPtr_m_DepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_DepthStoreAction");
			ScriptableRenderPass.NativeFieldInfoPtr_m_OverriddenColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_OverriddenColorStoreActions");
			ScriptableRenderPass.NativeFieldInfoPtr_m_OverriddenDepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_OverriddenDepthStoreAction");
			ScriptableRenderPass.NativeFieldInfoPtr__profilingSampler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<profilingSampler>k__BackingField");
			ScriptableRenderPass.NativeFieldInfoPtr__overrideCameraTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<overrideCameraTarget>k__BackingField");
			ScriptableRenderPass.NativeFieldInfoPtr__isBlitRenderPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<isBlitRenderPass>k__BackingField");
			ScriptableRenderPass.NativeFieldInfoPtr__useNativeRenderPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<useNativeRenderPass>k__BackingField");
			ScriptableRenderPass.NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<renderPassQueueIndex>k__BackingField");
			ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachmentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ColorAttachmentIndices");
			ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachmentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_InputAttachmentIndices");
			ScriptableRenderPass.NativeFieldInfoPtr__renderTargetFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<renderTargetFormat>k__BackingField");
			ScriptableRenderPass.NativeFieldInfoPtr_m_UsesRTHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_UsesRTHandles");
			ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ColorAttachments");
			ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachmentIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ColorAttachmentIds");
			ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_InputAttachments");
			ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachmentIsTransient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_InputAttachmentIsTransient");
			ScriptableRenderPass.NativeFieldInfoPtr_m_DepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_DepthAttachment");
			ScriptableRenderPass.NativeFieldInfoPtr_m_DepthAttachmentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_DepthAttachmentId");
			ScriptableRenderPass.NativeFieldInfoPtr_m_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_Input");
			ScriptableRenderPass.NativeFieldInfoPtr_m_ClearFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ClearFlag");
			ScriptableRenderPass.NativeFieldInfoPtr_m_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ClearColor");
			ScriptableRenderPass.NativeMethodInfoPtr_FrameCleanup_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664647);
			ScriptableRenderPass.NativeMethodInfoPtr_get_renderPassEvent_Public_get_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664648);
			ScriptableRenderPass.NativeMethodInfoPtr_set_renderPassEvent_Public_set_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664649);
			ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachments_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664650);
			ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachment_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664651);
			ScriptableRenderPass.NativeMethodInfoPtr_get_depthAttachment_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664652);
			ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachmentHandles_Public_get_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664653);
			ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachmentHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664654);
			ScriptableRenderPass.NativeMethodInfoPtr_get_depthAttachmentHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664655);
			ScriptableRenderPass.NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664656);
			ScriptableRenderPass.NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664657);
			ScriptableRenderPass.NativeMethodInfoPtr_get_overriddenColorStoreActions_Internal_get_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664658);
			ScriptableRenderPass.NativeMethodInfoPtr_get_overriddenDepthStoreAction_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664659);
			ScriptableRenderPass.NativeMethodInfoPtr_get_input_Public_get_ScriptableRenderPassInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664660);
			ScriptableRenderPass.NativeMethodInfoPtr_get_clearFlag_Public_get_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664661);
			ScriptableRenderPass.NativeMethodInfoPtr_get_clearColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664662);
			ScriptableRenderPass.NativeMethodInfoPtr_get_profilingSampler_FamOrAssem_get_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664663);
			ScriptableRenderPass.NativeMethodInfoPtr_set_profilingSampler_FamOrAssem_set_Void_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664664);
			ScriptableRenderPass.NativeMethodInfoPtr_get_overrideCameraTarget_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664665);
			ScriptableRenderPass.NativeMethodInfoPtr_set_overrideCameraTarget_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664666);
			ScriptableRenderPass.NativeMethodInfoPtr_get_isBlitRenderPass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664667);
			ScriptableRenderPass.NativeMethodInfoPtr_set_isBlitRenderPass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664668);
			ScriptableRenderPass.NativeMethodInfoPtr_get_useNativeRenderPass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664669);
			ScriptableRenderPass.NativeMethodInfoPtr_set_useNativeRenderPass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664670);
			ScriptableRenderPass.NativeMethodInfoPtr_get_renderPassQueueIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664671);
			ScriptableRenderPass.NativeMethodInfoPtr_set_renderPassQueueIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664672);
			ScriptableRenderPass.NativeMethodInfoPtr_get_renderTargetFormat_Internal_get_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664673);
			ScriptableRenderPass.NativeMethodInfoPtr_set_renderTargetFormat_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664674);
			ScriptableRenderPass.NativeMethodInfoPtr_GetActiveDebugHandler_Internal_Static_DebugHandler_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664675);
			ScriptableRenderPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664676);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInput_Public_Void_ScriptableRenderPassInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664677);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureColorStoreAction_Public_Void_RenderBufferStoreAction_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664678);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureColorStoreActions_Public_Void_Il2CppStructArray_1_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664679);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureDepthStoreAction_Public_Void_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664680);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664681);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664682);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664683);
			ScriptableRenderPass.NativeMethodInfoPtr_SetInputAttachmentTransient_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664684);
			ScriptableRenderPass.NativeMethodInfoPtr_IsInputAttachmentTransient_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664685);
			ScriptableRenderPass.NativeMethodInfoPtr_ResetTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664686);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664687);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664688);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664689);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664690);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Internal_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664691);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664692);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664693);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664694);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664695);
			ScriptableRenderPass.NativeMethodInfoPtr_ConfigureClear_Public_Void_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664696);
			ScriptableRenderPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_New_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664697);
			ScriptableRenderPass.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664698);
			ScriptableRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664699);
			ScriptableRenderPass.NativeMethodInfoPtr_OnFinishCameraStackRendering_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664700);
			ScriptableRenderPass.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664701);
			ScriptableRenderPass.NativeMethodInfoPtr_RecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664702);
			ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664703);
			ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664704);
			ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664705);
			ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_RTHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664706);
			ScriptableRenderPass.NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664707);
			ScriptableRenderPass.NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664708);
			ScriptableRenderPass.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664709);
			ScriptableRenderPass.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664710);
			ScriptableRenderPass.NativeMethodInfoPtr_GetRenderPassEventRange_Internal_Static_Int32_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664711);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00039630 File Offset: 0x00037830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283233, RefRangeEnd = 283236, XrefRangeStart = 283233, XrefRangeEnd = 283236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FrameCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderPass.NativeMethodInfoPtr_FrameCleanup_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00039680 File Offset: 0x00037880
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x000396BC File Offset: 0x000378BC
		public unsafe RenderPassEvent renderPassEvent
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_renderPassEvent_Public_get_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_set_renderPassEvent_Public_set_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000396FC File Offset: 0x000378FC
		public unsafe Il2CppStructArray<RenderTargetIdentifier> colorAttachments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachments_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0003973C File Offset: 0x0003793C
		public unsafe RenderTargetIdentifier colorAttachment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachment_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00039778 File Offset: 0x00037978
		public unsafe RenderTargetIdentifier depthAttachment
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 608339, RefRangeEnd = 608340, XrefRangeStart = 608338, XrefRangeEnd = 608339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_depthAttachment_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000397B4 File Offset: 0x000379B4
		public unsafe Il2CppReferenceArray<RTHandle> colorAttachmentHandles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachmentHandles_Public_get_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr3) : null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x000397F4 File Offset: 0x000379F4
		public unsafe RTHandle colorAttachmentHandle
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 608340, RefRangeEnd = 608346, XrefRangeStart = 608340, XrefRangeEnd = 608340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_colorAttachmentHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00039834 File Offset: 0x00037A34
		public unsafe RTHandle depthAttachmentHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_depthAttachmentHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00039874 File Offset: 0x00037A74
		public unsafe Il2CppStructArray<RenderBufferStoreAction> colorStoreActions
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr3) : null;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000398B4 File Offset: 0x00037AB4
		public unsafe RenderBufferStoreAction depthStoreAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000398F0 File Offset: 0x00037AF0
		public unsafe Il2CppStructArray<bool> overriddenColorStoreActions
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_overriddenColorStoreActions_Internal_get_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00039930 File Offset: 0x00037B30
		public unsafe bool overriddenDepthStoreAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_overriddenDepthStoreAction_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0003996C File Offset: 0x00037B6C
		public unsafe ScriptableRenderPassInput input
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_input_Public_get_ScriptableRenderPassInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000399A8 File Offset: 0x00037BA8
		public unsafe ClearFlag clearFlag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_clearFlag_Public_get_ClearFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000399E4 File Offset: 0x00037BE4
		public unsafe Color clearColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_clearColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00039A20 File Offset: 0x00037C20
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00039A60 File Offset: 0x00037C60
		public unsafe ProfilingSampler profilingSampler
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_profilingSampler_FamOrAssem_get_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_set_profilingSampler_FamOrAssem_set_Void_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00039AA4 File Offset: 0x00037CA4
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00039AE0 File Offset: 0x00037CE0
		public unsafe bool overrideCameraTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_overrideCameraTarget_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_set_overrideCameraTarget_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00039B20 File Offset: 0x00037D20
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00039B5C File Offset: 0x00037D5C
		public unsafe bool isBlitRenderPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_isBlitRenderPass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_set_isBlitRenderPass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00039B9C File Offset: 0x00037D9C
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00039BD8 File Offset: 0x00037DD8
		public unsafe bool useNativeRenderPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_useNativeRenderPass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_set_useNativeRenderPass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00039C18 File Offset: 0x00037E18
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00039C54 File Offset: 0x00037E54
		public unsafe int renderPassQueueIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_renderPassQueueIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_set_renderPassQueueIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00039C94 File Offset: 0x00037E94
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00039CD4 File Offset: 0x00037ED4
		public unsafe Il2CppStructArray<GraphicsFormat> renderTargetFormat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_get_renderTargetFormat_Internal_get_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_set_renderTargetFormat_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00039D18 File Offset: 0x00037F18
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 608347, RefRangeEnd = 608358, XrefRangeStart = 608346, XrefRangeEnd = 608347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DebugHandler GetActiveDebugHandler(ref RenderingData renderingData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_GetActiveDebugHandler_Internal_Static_DebugHandler_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00039D60 File Offset: 0x00037F60
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 608426, RefRangeEnd = 608465, XrefRangeStart = 608358, XrefRangeEnd = 608426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRenderPass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00039D9C File Offset: 0x00037F9C
		[CallerCount(0)]
		public unsafe void ConfigureInput(ScriptableRenderPassInput passInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passInput;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInput_Public_Void_ScriptableRenderPassInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00039DDC File Offset: 0x00037FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 608465, RefRangeEnd = 608467, XrefRangeStart = 608465, XrefRangeEnd = 608465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0U)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref storeAction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attachmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureColorStoreAction_Public_Void_RenderBufferStoreAction_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00039E28 File Offset: 0x00038028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608467, XrefRangeEnd = 608471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureColorStoreActions(Il2CppStructArray<RenderBufferStoreAction> storeActions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeActions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureColorStoreActions_Public_Void_Il2CppStructArray_1_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00039E6C File Offset: 0x0003806C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 608471, RefRangeEnd = 608474, XrefRangeStart = 608471, XrefRangeEnd = 608471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref storeAction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureDepthStoreAction_Public_Void_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00039EAC File Offset: 0x000380AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608474, XrefRangeEnd = 608476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInputAttachments(RTHandle input, bool isTransient = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTransient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_RTHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00039EFC File Offset: 0x000380FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInputAttachments(Il2CppReferenceArray<RTHandle> inputs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00039F40 File Offset: 0x00038140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608478, RefRangeEnd = 608479, XrefRangeStart = 608476, XrefRangeEnd = 608478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInputAttachments(Il2CppReferenceArray<RTHandle> inputs, Il2CppStructArray<bool> isTransient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isTransient);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00039F94 File Offset: 0x00038194
		[CallerCount(0)]
		public unsafe void SetInputAttachmentTransient(int idx, bool isTransient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTransient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_SetInputAttachmentTransient_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00039FE0 File Offset: 0x000381E0
		[CallerCount(0)]
		public unsafe bool IsInputAttachmentTransient(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_IsInputAttachmentTransient_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0003A02C File Offset: 0x0003822C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608486, RefRangeEnd = 608487, XrefRangeStart = 608479, XrefRangeEnd = 608486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ResetTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0003A060 File Offset: 0x00038260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608487, XrefRangeEnd = 608490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorAttachment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0003A0AC File Offset: 0x000382AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 608496, RefRangeEnd = 608500, XrefRangeStart = 608490, XrefRangeEnd = 608496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0003A100 File Offset: 0x00038300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608500, XrefRangeEnd = 608518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(Il2CppStructArray<RenderTargetIdentifier> colorAttachments, RenderTargetIdentifier depthAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0003A150 File Offset: 0x00038350
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 608543, RefRangeEnd = 608549, XrefRangeStart = 608518, XrefRangeEnd = 608543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(Il2CppReferenceArray<RTHandle> colorAttachments, RTHandle depthAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0003A1A4 File Offset: 0x000383A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608551, RefRangeEnd = 608552, XrefRangeStart = 608549, XrefRangeEnd = 608551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(Il2CppReferenceArray<RTHandle> colorAttachments, RTHandle depthAttachment, Il2CppStructArray<GraphicsFormat> formats)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Internal_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0003A20C File Offset: 0x0003840C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608552, XrefRangeEnd = 608554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(RenderTargetIdentifier colorAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorAttachment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003A24C File Offset: 0x0003844C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 608565, RefRangeEnd = 608572, XrefRangeStart = 608554, XrefRangeEnd = 608565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(RTHandle colorAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0003A290 File Offset: 0x00038490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608572, XrefRangeEnd = 608594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(Il2CppStructArray<RenderTargetIdentifier> colorAttachments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0003A2D4 File Offset: 0x000384D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608594, XrefRangeEnd = 608599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(Il2CppReferenceArray<RTHandle> colorAttachments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0003A318 File Offset: 0x00038518
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 608599, RefRangeEnd = 608609, XrefRangeStart = 608599, XrefRangeEnd = 608599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureClear(ClearFlag clearFlag, Color clearColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearFlag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_ConfigureClear_Public_Void_ClearFlag_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0003A364 File Offset: 0x00038564
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_New_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0003A3C4 File Offset: 0x000385C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderPass.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0003A420 File Offset: 0x00038620
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0003A470 File Offset: 0x00038670
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderPass.NativeMethodInfoPtr_OnFinishCameraStackRendering_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003A4C0 File Offset: 0x000386C0
		[CallerCount(0)]
		public unsafe virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderPass.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0003A51C File Offset: 0x0003871C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608609, XrefRangeEnd = 608618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRenderPass.NativeMethodInfoPtr_RecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0003A57C File Offset: 0x0003877C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608618, XrefRangeEnd = 608624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0003A5FC File Offset: 0x000387FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 608632, RefRangeEnd = 608635, XrefRangeStart = 608624, XrefRangeEnd = 608632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0003A684 File Offset: 0x00038884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608635, XrefRangeEnd = 608638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0003A6FC File Offset: 0x000388FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608638, XrefRangeEnd = 608641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_RTHandle_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0003A784 File Offset: 0x00038984
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 608645, RefRangeEnd = 608648, XrefRangeStart = 608641, XrefRangeEnd = 608645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shaderTagId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingCriteria;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0003A7F0 File Offset: 0x000389F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 608652, RefRangeEnd = 608660, XrefRangeStart = 608648, XrefRangeEnd = 608652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shaderTagIdList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingCriteria;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003A860 File Offset: 0x00038A60
		[CallerCount(0)]
		public unsafe static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0003A8B4 File Offset: 0x00038AB4
		[CallerCount(0)]
		public unsafe static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0003A908 File Offset: 0x00038B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608660, XrefRangeEnd = 608672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRenderPassEventRange(RenderPassEvent renderPassEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderPassEvent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderPass.NativeMethodInfoPtr_GetRenderPassEventRange_Internal_Static_Int32_RenderPassEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00006CDF File Offset: 0x00004EDF
		public ScriptableRenderPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0003A948 File Offset: 0x00038B48
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00006CE8 File Offset: 0x00004EE8
		public unsafe static RTHandle k_CameraTarget
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderPass.NativeFieldInfoPtr_k_CameraTarget, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderPass.NativeFieldInfoPtr_k_CameraTarget, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0003A970 File Offset: 0x00038B70
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00006CFA File Offset: 0x00004EFA
		public unsafe RenderPassEvent _renderPassEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__renderPassEvent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__renderPassEvent_k__BackingField)) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0003A998 File Offset: 0x00038B98
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00006D15 File Offset: 0x00004F15
		public unsafe Il2CppStructArray<RenderBufferStoreAction> m_ColorStoreActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorStoreActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorStoreActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0003A9C8 File Offset: 0x00038BC8
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00006D34 File Offset: 0x00004F34
		public unsafe RenderBufferStoreAction m_DepthStoreAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_DepthStoreAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_DepthStoreAction)) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00006D4F File Offset: 0x00004F4F
		public unsafe Il2CppStructArray<bool> m_OverriddenColorStoreActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_OverriddenColorStoreActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_OverriddenColorStoreActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0003AA20 File Offset: 0x00038C20
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00006D6E File Offset: 0x00004F6E
		public unsafe bool m_OverriddenDepthStoreAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_OverriddenDepthStoreAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_OverriddenDepthStoreAction)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0003AA48 File Offset: 0x00038C48
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00006D89 File Offset: 0x00004F89
		public unsafe ProfilingSampler _profilingSampler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__profilingSampler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__profilingSampler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0003AA78 File Offset: 0x00038C78
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00006DA8 File Offset: 0x00004FA8
		public unsafe bool _overrideCameraTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__overrideCameraTarget_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__overrideCameraTarget_k__BackingField)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0003AAA0 File Offset: 0x00038CA0
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00006DC3 File Offset: 0x00004FC3
		public unsafe bool _isBlitRenderPass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__isBlitRenderPass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__isBlitRenderPass_k__BackingField)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0003AAC8 File Offset: 0x00038CC8
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00006DDE File Offset: 0x00004FDE
		public unsafe bool _useNativeRenderPass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__useNativeRenderPass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__useNativeRenderPass_k__BackingField)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0003AAF0 File Offset: 0x00038CF0
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00006DF9 File Offset: 0x00004FF9
		public unsafe int _renderPassQueueIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0003AB18 File Offset: 0x00038D18
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00006E14 File Offset: 0x00005014
		public NativeArray<int> m_ColorAttachmentIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachmentIndices);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachmentIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0003AB48 File Offset: 0x00038D48
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00006E42 File Offset: 0x00005042
		public NativeArray<int> m_InputAttachmentIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachmentIndices);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachmentIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0003AB78 File Offset: 0x00038D78
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00006E70 File Offset: 0x00005070
		public unsafe Il2CppStructArray<GraphicsFormat> _renderTargetFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__renderTargetFormat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr__renderTargetFormat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0003ABA8 File Offset: 0x00038DA8
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00006E8F File Offset: 0x0000508F
		public unsafe bool m_UsesRTHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_UsesRTHandles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_UsesRTHandles)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0003ABD0 File Offset: 0x00038DD0
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00006EAA File Offset: 0x000050AA
		public unsafe Il2CppReferenceArray<RTHandle> m_ColorAttachments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0003AC00 File Offset: 0x00038E00
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00006EC9 File Offset: 0x000050C9
		public unsafe Il2CppStructArray<RenderTargetIdentifier> m_ColorAttachmentIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachmentIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ColorAttachmentIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0003AC30 File Offset: 0x00038E30
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00006EE8 File Offset: 0x000050E8
		public unsafe Il2CppReferenceArray<RTHandle> m_InputAttachments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0003AC60 File Offset: 0x00038E60
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00006F07 File Offset: 0x00005107
		public unsafe Il2CppStructArray<bool> m_InputAttachmentIsTransient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachmentIsTransient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_InputAttachmentIsTransient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0003AC90 File Offset: 0x00038E90
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00006F26 File Offset: 0x00005126
		public unsafe RTHandle m_DepthAttachment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_DepthAttachment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_DepthAttachment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0003ACC0 File Offset: 0x00038EC0
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00006F45 File Offset: 0x00005145
		public unsafe RenderTargetIdentifier m_DepthAttachmentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_DepthAttachmentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_DepthAttachmentId)) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0003ACE8 File Offset: 0x00038EE8
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00006F60 File Offset: 0x00005160
		public unsafe ScriptableRenderPassInput m_Input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_Input);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_Input)) = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0003AD10 File Offset: 0x00038F10
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00006F7B File Offset: 0x0000517B
		public unsafe ClearFlag m_ClearFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ClearFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ClearFlag)) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0003AD38 File Offset: 0x00038F38
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00006F96 File Offset: 0x00005196
		public unsafe Color m_ClearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ClearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRenderPass.NativeFieldInfoPtr_m_ClearColor)) = value;
			}
		}

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeFieldInfoPtr_k_CameraTarget;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeFieldInfoPtr__renderPassEvent_k__BackingField;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorStoreActions;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthStoreAction;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_m_OverriddenColorStoreActions;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_m_OverriddenDepthStoreAction;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr__profilingSampler_k__BackingField;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr__overrideCameraTarget_k__BackingField;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr__isBlitRenderPass_k__BackingField;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr__useNativeRenderPass_k__BackingField;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorAttachmentIndices;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_m_InputAttachmentIndices;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr__renderTargetFormat_k__BackingField;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr_m_UsesRTHandles;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorAttachments;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorAttachmentIds;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_m_InputAttachments;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_m_InputAttachmentIsTransient;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthAttachment;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthAttachmentId;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_m_Input;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearFlag;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearColor;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_FrameCleanup_Public_Virtual_New_Void_CommandBuffer_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPassEvent_Public_get_RenderPassEvent_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_set_renderPassEvent_Public_set_Void_RenderPassEvent_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_get_colorAttachments_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_get_colorAttachment_Public_get_RenderTargetIdentifier_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAttachment_Public_get_RenderTargetIdentifier_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_get_colorAttachmentHandles_Public_get_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_get_colorAttachmentHandle_Public_get_RTHandle_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAttachmentHandle_Public_get_RTHandle_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_get_overriddenColorStoreActions_Internal_get_Il2CppStructArray_1_Boolean_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_overriddenDepthStoreAction_Internal_get_Boolean_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_get_input_Public_get_ScriptableRenderPassInput_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_clearFlag_Public_get_ClearFlag_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_get_clearColor_Public_get_Color_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_get_profilingSampler_FamOrAssem_get_ProfilingSampler_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_set_profilingSampler_FamOrAssem_set_Void_ProfilingSampler_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideCameraTarget_Internal_get_Boolean_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideCameraTarget_Internal_set_Void_Boolean_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_isBlitRenderPass_Internal_get_Boolean_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_set_isBlitRenderPass_Internal_set_Void_Boolean_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_get_useNativeRenderPass_Internal_get_Boolean_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_set_useNativeRenderPass_Internal_set_Void_Boolean_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPassQueueIndex_Internal_get_Int32_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_set_renderPassQueueIndex_Internal_set_Void_Int32_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_get_renderTargetFormat_Internal_get_Il2CppStructArray_1_GraphicsFormat_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_set_renderTargetFormat_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveDebugHandler_Internal_Static_DebugHandler_byref_RenderingData_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInput_Public_Void_ScriptableRenderPassInput_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureColorStoreAction_Public_Void_RenderBufferStoreAction_UInt32_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureColorStoreActions_Public_Void_Il2CppStructArray_1_RenderBufferStoreAction_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDepthStoreAction_Public_Void_RenderBufferStoreAction_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_RTHandle_Boolean_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_Boolean_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_SetInputAttachmentTransient_Internal_Void_Int32_Boolean_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_IsInputAttachmentTransient_Internal_Boolean_Int32_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_ResetTarget_Public_Void_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_RTHandle_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Internal_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_Il2CppStructArray_1_GraphicsFormat_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureClear_Public_Void_ClearFlag_Color_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_New_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_New_Void_CommandBuffer_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishCameraStackRendering_Public_Virtual_New_Void_CommandBuffer_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_RecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_byref_RenderingData_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_Material_Int32_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_RTHandle_Material_Int32_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderPassEventRange_Internal_Static_Int32_RenderPassEvent_0;
	}
}
