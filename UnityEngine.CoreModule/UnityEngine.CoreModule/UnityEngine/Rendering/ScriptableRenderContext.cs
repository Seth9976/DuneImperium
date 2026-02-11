using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering
{
	// Token: 0x02000246 RID: 582
	[StructLayout(2)]
	public struct ScriptableRenderContext
	{
		// Token: 0x06002706 RID: 9990 RVA: 0x000A4D28 File Offset: 0x000A2F28
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRenderContext()
		{
			Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableRenderContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr);
			ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "kRenderTypeTag");
			ScriptableRenderContext.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "m_Ptr");
			ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668292);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668293);
			ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668294);
			ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668295);
			ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668296);
			ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668297);
			ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668298);
			ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668299);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668300);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Private_Void_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668301);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668302);
			ScriptableRenderContext.NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668303);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668304);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668305);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668306);
			ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668307);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668308);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668309);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668310);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668311);
			ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668312);
			ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668313);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668315);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668316);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668317);
			ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668318);
			ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668319);
			ScriptableRenderContext.NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668320);
			ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668321);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668322);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668323);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668324);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_NativeArray_1_ShaderTagId_NativeArray_1_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668325);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Public_Void_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668326);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668327);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668328);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668329);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668330);
			ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668331);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668332);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668333);
			ScriptableRenderContext.NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668334);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668335);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668336);
			ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668337);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668338);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668339);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668340);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668341);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668342);
			ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668343);
			ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668344);
			ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668346);
			ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668347);
			ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Injected_Private_Static_Boolean_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668348);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668349);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668350);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668351);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668352);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668353);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668354);
			ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668355);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668356);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668357);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668358);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668359);
			ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668360);
			ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668361);
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StereoEndRender_Internal_Injected");
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StartMultiEye_Internal_Injected");
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StopMultiEye_Internal_Injected");
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected");
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawGizmos_Internal_Injected");
			ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::CreateShadowRendererList_Internal_Injected");
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000A532C File Offset: 0x000A352C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684420, XrefRangeEnd = 684422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginRenderPass_Internal(IntPtr self, int width, int height, int volumeDepth, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samples;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colors;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000A53C0 File Offset: 0x000A35C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684422, XrefRangeEnd = 684424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colors;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputs;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDepthReadOnly;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStencilReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000A5448 File Offset: 0x000A3648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684424, XrefRangeEnd = 684426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSubPass_Internal(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000A547C File Offset: 0x000A367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684426, XrefRangeEnd = 684428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndRenderPass_Internal(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x000A54B0 File Offset: 0x000A36B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684428, XrefRangeEnd = 684433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderLoop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref results;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000A5500 File Offset: 0x000A3700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684433, XrefRangeEnd = 684435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sortingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x000A5544 File Offset: 0x000A3744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684435, XrefRangeEnd = 684440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000A556C File Offset: 0x000A376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684440, XrefRangeEnd = 684445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SubmitForRenderPassValidation_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000A559C File Offset: 0x000A379C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684450, RefRangeEnd = 684451, XrefRangeStart = 684445, XrefRangeEnd = 684450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCameras_Internal(Type listType, Object resultList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x000A55E4 File Offset: 0x000A37E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 684456, RefRangeEnd = 684459, XrefRangeStart = 684451, XrefRangeEnd = 684456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Private_Void_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x000A5678 File Offset: 0x000A3878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684464, RefRangeEnd = 684465, XrefRangeStart = 684459, XrefRangeEnd = 684464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawShadows_Internal(IntPtr shadowDrawingSettings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shadowDrawingSettings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Private_Void_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000A56AC File Offset: 0x000A38AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684465, XrefRangeEnd = 684467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EmitGeometryForCamera(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x000A56E4 File Offset: 0x000A38E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684472, RefRangeEnd = 684473, XrefRangeStart = 684467, XrefRangeEnd = 684472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000A571C File Offset: 0x000A391C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684478, RefRangeEnd = 684479, XrefRangeStart = 684473, XrefRangeEnd = 684478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000A5760 File Offset: 0x000A3960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684484, RefRangeEnd = 684485, XrefRangeStart = 684479, XrefRangeEnd = 684484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000A57B4 File Offset: 0x000A39B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684485, XrefRangeEnd = 684490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnRenderObjectCallback_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000A57DC File Offset: 0x000A39DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684495, RefRangeEnd = 684496, XrefRangeStart = 684490, XrefRangeEnd = 684495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWireOverlay_Impl(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000A5814 File Offset: 0x000A3A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684501, RefRangeEnd = 684502, XrefRangeStart = 684496, XrefRangeEnd = 684501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawUIOverlay_Internal(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Private_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000A584C File Offset: 0x000A3A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684507, RefRangeEnd = 684508, XrefRangeStart = 684502, XrefRangeEnd = 684507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000A58EC File Offset: 0x000A3AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684508, XrefRangeEnd = 684513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList_Internal(Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proj;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projR;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000A5974 File Offset: 0x000A3B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684518, RefRangeEnd = 684519, XrefRangeStart = 684513, XrefRangeEnd = 684518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareRendererListsAsync_Internal(Object rendererLists)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000A59AC File Offset: 0x000A3BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684519, XrefRangeEnd = 684524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListStatus QueryRendererListStatus_Internal(RendererList handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000A59EC File Offset: 0x000A3BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684533, RefRangeEnd = 684534, XrefRangeStart = 684524, XrefRangeEnd = 684533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samples;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(attachments));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000A5A60 File Offset: 0x000A3C60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 684546, RefRangeEnd = 684548, XrefRangeStart = 684534, XrefRangeEnd = 684546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthStencilReadOnly = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(colors));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inputs));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDepthStencilReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000A5AC0 File Offset: 0x000A3CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 684557, RefRangeEnd = 684559, XrefRangeStart = 684548, XrefRangeEnd = 684557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthStencilReadOnly = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(colors));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDepthStencilReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000A5B0C File Offset: 0x000A3D0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 684564, RefRangeEnd = 684567, XrefRangeStart = 684559, XrefRangeEnd = 684564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSubPass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000A5B34 File Offset: 0x000A3D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684572, RefRangeEnd = 684573, XrefRangeStart = 684567, XrefRangeEnd = 684572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndRenderPass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000A5B5C File Offset: 0x000A3D5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 684586, RefRangeEnd = 684593, XrefRangeStart = 684573, XrefRangeEnd = 684586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000A5B84 File Offset: 0x000A3D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684593, XrefRangeEnd = 684601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SubmitForRenderPassValidation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000A5BB4 File Offset: 0x000A3DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684601, XrefRangeEnd = 684611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCameras(List<Camera> results)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000A5BEC File Offset: 0x000A3DEC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 684617, RefRangeEnd = 684627, XrefRangeStart = 684611, XrefRangeEnd = 684617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000A5C3C File Offset: 0x000A3E3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 684635, RefRangeEnd = 684642, XrefRangeStart = 684627, XrefRangeEnd = 684635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stateBlock;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000A5C9C File Offset: 0x000A3E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684654, RefRangeEnd = 684655, XrefRangeStart = 684642, XrefRangeEnd = 684654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, Unity.Collections.NativeArray<ShaderTagId> tagValues, Unity.Collections.NativeArray<RenderStateBlock> stateBlocks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tagValues));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(stateBlocks));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_NativeArray_1_ShaderTagId_NativeArray_1_RenderStateBlock_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000A5D38 File Offset: 0x000A3F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 684660, RefRangeEnd = 684662, XrefRangeStart = 684655, XrefRangeEnd = 684660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawShadows(ref ShadowDrawingSettings settings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Public_Void_byref_ShadowDrawingSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000A5D6C File Offset: 0x000A3F6C
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 684679, RefRangeEnd = 684748, XrefRangeStart = 684662, XrefRangeEnd = 684679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBuffer(CommandBuffer commandBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000A5DA4 File Offset: 0x000A3FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684765, RefRangeEnd = 684766, XrefRangeStart = 684748, XrefRangeEnd = 684765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x000A5DE8 File Offset: 0x000A3FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 684770, RefRangeEnd = 684772, XrefRangeStart = 684766, XrefRangeEnd = 684770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000A5E2C File Offset: 0x000A402C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684776, RefRangeEnd = 684777, XrefRangeStart = 684772, XrefRangeEnd = 684776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000A5E80 File Offset: 0x000A4080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 684785, RefRangeEnd = 684787, XrefRangeStart = 684777, XrefRangeEnd = 684785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnRenderObjectCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000A5EA8 File Offset: 0x000A40A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684791, RefRangeEnd = 684792, XrefRangeStart = 684787, XrefRangeEnd = 684791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWireOverlay(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000A5EE0 File Offset: 0x000A40E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 684796, RefRangeEnd = 684800, XrefRangeStart = 684792, XrefRangeEnd = 684796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawUIOverlay(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Public_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000A5F18 File Offset: 0x000A4118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684800, XrefRangeEnd = 684809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CullingResults Cull(ref ScriptableCullingParameters parameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000A5F58 File Offset: 0x000A4158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684813, RefRangeEnd = 684814, XrefRangeStart = 684809, XrefRangeEnd = 684813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptableRenderContext other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000A5F98 File Offset: 0x000A4198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684814, XrefRangeEnd = 684820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000A5FDC File Offset: 0x000A41DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000A600C File Offset: 0x000A420C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684833, RefRangeEnd = 684834, XrefRangeStart = 684820, XrefRangeEnd = 684833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(desc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000A6054 File Offset: 0x000A4254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684849, RefRangeEnd = 684850, XrefRangeStart = 684834, XrefRangeEnd = 684849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateRendererList(ref RendererListParams param)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000A6098 File Offset: 0x000A4298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684858, RefRangeEnd = 684859, XrefRangeStart = 684850, XrefRangeEnd = 684858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrixL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrixL;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrixR;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrixR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x000A6114 File Offset: 0x000A4314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684871, RefRangeEnd = 684872, XrefRangeStart = 684859, XrefRangeEnd = 684871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000A6174 File Offset: 0x000A4374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684888, RefRangeEnd = 684889, XrefRangeStart = 684872, XrefRangeEnd = 684888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000A61B8 File Offset: 0x000A43B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684893, RefRangeEnd = 684894, XrefRangeStart = 684889, XrefRangeEnd = 684893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareRendererListsAsync(List<RendererList> rendererLists)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000A61F0 File Offset: 0x000A43F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684902, RefRangeEnd = 684903, XrefRangeStart = 684894, XrefRangeEnd = 684902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListStatus QueryRendererListStatus(RendererList rendererList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rendererList;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x000A6230 File Offset: 0x000A4430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684903, XrefRangeEnd = 684905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderLoop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref results;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000A6280 File Offset: 0x000A4480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684905, XrefRangeEnd = 684907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000A62B4 File Offset: 0x000A44B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684907, XrefRangeEnd = 684909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SubmitForRenderPassValidation_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Injected_Private_Static_Boolean_byref_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000A62F4 File Offset: 0x000A44F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684909, XrefRangeEnd = 684911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, Object resultList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000A634C File Offset: 0x000A454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684911, XrefRangeEnd = 684913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullResults;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000A63F0 File Offset: 0x000A45F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684913, XrefRangeEnd = 684915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowDrawingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000A6430 File Offset: 0x000A4630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684915, XrefRangeEnd = 684917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000A6474 File Offset: 0x000A4674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684917, XrefRangeEnd = 684919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_ComputeQueueType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000A64C8 File Offset: 0x000A46C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684919, XrefRangeEnd = 684921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000A6528 File Offset: 0x000A4728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684921, XrefRangeEnd = 684923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000A655C File Offset: 0x000A475C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684923, XrefRangeEnd = 684925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000A65A0 File Offset: 0x000A47A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684925, XrefRangeEnd = 684927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000A65E4 File Offset: 0x000A47E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684927, XrefRangeEnd = 684929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullResults;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000A6698 File Offset: 0x000A4898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684929, XrefRangeEnd = 684931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int mode, ref Matrix4x4 proj, ref Matrix4x4 view, ref Matrix4x4 projR, ref Matrix4x4 viewR, out RendererList ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &proj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &view;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projR;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewR;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000A6734 File Offset: 0x000A4934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684931, XrefRangeEnd = 684933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareRendererListsAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, Object rendererLists)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000A6778 File Offset: 0x000A4978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684933, XrefRangeEnd = 684935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, ref RendererList handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0000F39D File Offset: 0x0000D59D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, ref this));
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000A67C4 File Offset: 0x000A49C4
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x0000F3AF File Offset: 0x0000D5AF
		public unsafe static ShaderTagId kRenderTypeTag
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&value));
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0000F3BD File Offset: 0x0000D5BD
		public void StereoEndRender_Internal(Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_Injected(ref this, camera, eye, isFinalPass);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public void StartMultiEye_Internal(Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_Injected(ref this, camera, eye);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0000F3D2 File Offset: 0x0000D5D2
		public void StopMultiEye_Internal(Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_Injected(ref this, camera);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0000F3DB File Offset: 0x0000D5DB
		public void DrawSkybox_Internal(Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_Injected(ref this, camera);
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x0000F3E4 File Offset: 0x0000D5E4
		public void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_Injected(ref this, camera, gizmoSubset);
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000A67E0 File Offset: 0x000A49E0
		public IntPtr Internal_GetPtr()
		{
			return this.m_Ptr;
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000A67F8 File Offset: 0x000A49F8
		public RendererList CreateShadowRendererList_Internal(IntPtr shadowDrawinSettings)
		{
			RendererList rendererList;
			ScriptableRenderContext.CreateShadowRendererList_Internal_Injected(ref this, shadowDrawinSettings, out rendererList);
			return rendererList;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0000F3EE File Offset: 0x0000D5EE
		public void BeginRenderPass(int width, int height, int volumeDepth, int samples, Unity.Collections.NativeArray<AttachmentDescriptor> attachments, [Optional] int depthAttachmentIndex)
		{
			ScriptableRenderContext.BeginRenderPass_Internal(this.m_Ptr, width, height, volumeDepth, samples, (IntPtr)attachments.GetUnsafeReadOnlyPtr<AttachmentDescriptor>(), attachments.Length, depthAttachmentIndex);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x000A6810 File Offset: 0x000A4A10
		public ScopedRenderPass BeginScopedRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<AttachmentDescriptor> attachments, [Optional] int depthAttachmentIndex)
		{
			this.BeginRenderPass(width, height, samples, attachments, depthAttachmentIndex);
			return new ScopedRenderPass(this);
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x0000F417 File Offset: 0x0000D617
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, (IntPtr)inputs.GetUnsafeReadOnlyPtr<int>(), inputs.Length, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0000F44D File Offset: 0x0000D64D
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, IntPtr.Zero, 0, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000A683C File Offset: 0x000A4A3C
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000A6868 File Offset: 0x000A4A68
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000A6890 File Offset: 0x000A4A90
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000A68B8 File Offset: 0x000A4AB8
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0000F476 File Offset: 0x0000D676
		public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, Unity.Collections.NativeArray<ShaderTagId> renderTypes, Unity.Collections.NativeArray<RenderStateBlock> stateBlocks)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x0000F483 File Offset: 0x0000D683
		public void StereoEndRender(Camera camera)
		{
			this.StereoEndRender(camera, 0, true);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x0000F490 File Offset: 0x0000D690
		public void StereoEndRender(Camera camera, int eye)
		{
			this.StereoEndRender(camera, eye, true);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0000F49D File Offset: 0x0000D69D
		public void StereoEndRender(Camera camera, int eye, bool isFinalPass)
		{
			this.StereoEndRender_Internal(camera, eye, isFinalPass);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0000F4AA File Offset: 0x0000D6AA
		public void StartMultiEye(Camera camera)
		{
			this.StartMultiEye(camera, 0);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0000F4B6 File Offset: 0x0000D6B6
		public void StartMultiEye(Camera camera, int eye)
		{
			this.StartMultiEye_Internal(camera, eye);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0000F4C2 File Offset: 0x0000D6C2
		public void StopMultiEye(Camera camera)
		{
			this.StopMultiEye_Internal(camera);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0000F4CD File Offset: 0x0000D6CD
		public void DrawSkybox(Camera camera)
		{
			this.DrawSkybox_Internal(camera);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0000F4D8 File Offset: 0x0000D6D8
		public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset)
		{
			this.DrawGizmos_Internal(camera, gizmoSubset);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
		public void Validate()
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000A68E0 File Offset: 0x000A4AE0
		public static bool operator ==(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000A68FC File Offset: 0x000A4AFC
		public static bool operator !=(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000A691C File Offset: 0x000A4B1C
		public unsafe RendererList CreateShadowRendererList(ref ShadowDrawingSettings settings)
		{
			fixed (ShadowDrawingSettings* ptr = &settings)
			{
				ShadowDrawingSettings* ptr2 = ptr;
				return this.CreateShadowRendererList_Internal((IntPtr)((void*)ptr2));
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0000F4E7 File Offset: 0x0000D6E7
		public static void StereoEndRender_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye, isFinalPass);
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0000F4FC File Offset: 0x0000D6FC
		public static void StartMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0000F510 File Offset: 0x0000D710
		public static void StopMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0000F523 File Offset: 0x0000D723
		public static void DrawSkybox_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0000F536 File Offset: 0x0000D736
		public static void DrawGizmos_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), gizmoSubset);
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x0000F54A File Offset: 0x0000D74A
		public static void CreateShadowRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawinSettings, out RendererList ret)
		{
			ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegateField(ref _unity_self, shadowDrawinSettings, out ret);
		}

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeFieldInfoPtr_kRenderTypeTag;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Internal_Private_Void_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Internal_Private_Void_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_DrawShadows_Internal_Private_Void_IntPtr_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Private_Void_0;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_DrawUIOverlay_Internal_Private_Void_Camera_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_EndSubPass_Public_Void_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderPass_Public_Void_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_NativeArray_1_ShaderTagId_NativeArray_1_RenderStateBlock_0;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_DrawShadows_Public_Void_byref_ShadowDrawingSettings_0;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Public_Void_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_DrawUIOverlay_Public_Void_Camera_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Injected_Private_Static_Boolean_byref_ScriptableRenderContext_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_DrawShadows_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_ComputeQueueType_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Boolean_Int32_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_DrawUIOverlay_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Object_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0;

		// Token: 0x04002326 RID: 8998
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x04002327 RID: 8999
		private static readonly ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate StereoEndRender_Internal_InjectedDelegateField;

		// Token: 0x04002328 RID: 9000
		private static readonly ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate StartMultiEye_Internal_InjectedDelegateField;

		// Token: 0x04002329 RID: 9001
		private static readonly ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate StopMultiEye_Internal_InjectedDelegateField;

		// Token: 0x0400232A RID: 9002
		private static readonly ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate DrawSkybox_Internal_InjectedDelegateField;

		// Token: 0x0400232B RID: 9003
		private static readonly ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate DrawGizmos_Internal_InjectedDelegateField;

		// Token: 0x0400232C RID: 9004
		private static readonly ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegate CreateShadowRendererList_Internal_InjectedDelegateField;

		// Token: 0x020009E0 RID: 2528
		public enum SkyboxXRMode
		{
			// Token: 0x04002D37 RID: 11575
			Off,
			// Token: 0x04002D38 RID: 11576
			Enabled,
			// Token: 0x04002D39 RID: 11577
			LegacySinglePass
		}

		// Token: 0x020009E1 RID: 2529
		// (Invoke) Token: 0x06003CE3 RID: 15587
		private delegate void StereoEndRender_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye, bool isFinalPass);

		// Token: 0x020009E2 RID: 2530
		// (Invoke) Token: 0x06003CE5 RID: 15589
		private delegate void StartMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye);

		// Token: 0x020009E3 RID: 2531
		// (Invoke) Token: 0x06003CE7 RID: 15591
		private delegate void StopMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009E4 RID: 2532
		// (Invoke) Token: 0x06003CE9 RID: 15593
		private delegate void DrawSkybox_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009E5 RID: 2533
		// (Invoke) Token: 0x06003CEB RID: 15595
		private delegate void DrawGizmos_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, GizmoSubset gizmoSubset);

		// Token: 0x020009E6 RID: 2534
		// (Invoke) Token: 0x06003CED RID: 15597
		private delegate void CreateShadowRendererList_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr shadowDrawinSettings, [Out] IntPtr ret);
	}
}
