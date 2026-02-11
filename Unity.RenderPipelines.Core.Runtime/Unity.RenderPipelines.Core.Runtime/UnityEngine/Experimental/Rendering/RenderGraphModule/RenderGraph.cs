using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000015 RID: 21
	public class RenderGraph : Object
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00012C08 File Offset: 0x00010E08
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraph()
		{
			Il2CppClassPointerStore<RenderGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr);
			RenderGraph.NativeFieldInfoPtr_kMaxMRTCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "kMaxMRTCount");
			RenderGraph.NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_Resources");
			RenderGraph.NativeFieldInfoPtr_m_RenderGraphPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RenderGraphPool");
			RenderGraph.NativeFieldInfoPtr_m_RenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RenderPasses");
			RenderGraph.NativeFieldInfoPtr_m_RendererLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RendererLists");
			RenderGraph.NativeFieldInfoPtr_m_DebugParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DebugParameters");
			RenderGraph.NativeFieldInfoPtr_m_FrameInformationLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_FrameInformationLogger");
			RenderGraph.NativeFieldInfoPtr_m_DefaultResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DefaultResources");
			RenderGraph.NativeFieldInfoPtr_m_DefaultProfilingSamplers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DefaultProfilingSamplers");
			RenderGraph.NativeFieldInfoPtr_m_ExecutionExceptionWasRaised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_ExecutionExceptionWasRaised");
			RenderGraph.NativeFieldInfoPtr_m_RenderGraphContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RenderGraphContext");
			RenderGraph.NativeFieldInfoPtr_m_PreviousCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_PreviousCommandBuffer");
			RenderGraph.NativeFieldInfoPtr_m_CurrentImmediatePassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CurrentImmediatePassIndex");
			RenderGraph.NativeFieldInfoPtr_m_ImmediateModeResourceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_ImmediateModeResourceList");
			RenderGraph.NativeFieldInfoPtr_m_CompiledResourcesInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CompiledResourcesInfos");
			RenderGraph.NativeFieldInfoPtr_m_CompiledPassInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CompiledPassInfos");
			RenderGraph.NativeFieldInfoPtr_m_CullingStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CullingStack");
			RenderGraph.NativeFieldInfoPtr_m_ExecutionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_ExecutionCount");
			RenderGraph.NativeFieldInfoPtr_m_CurrentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CurrentFrameIndex");
			RenderGraph.NativeFieldInfoPtr_m_HasRenderGraphBegun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_HasRenderGraphBegun");
			RenderGraph.NativeFieldInfoPtr_m_CurrentExecutionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CurrentExecutionName");
			RenderGraph.NativeFieldInfoPtr_m_RendererListCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RendererListCulling");
			RenderGraph.NativeFieldInfoPtr_m_DebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DebugData");
			RenderGraph.NativeFieldInfoPtr_s_RegisteredGraphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "s_RegisteredGraphs");
			RenderGraph.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<name>k__BackingField");
			RenderGraph.NativeFieldInfoPtr__requireDebugData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<requireDebugData>k__BackingField");
			RenderGraph.NativeFieldInfoPtr_onGraphRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onGraphRegistered");
			RenderGraph.NativeFieldInfoPtr_onGraphUnregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onGraphUnregistered");
			RenderGraph.NativeFieldInfoPtr_onExecutionRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onExecutionRegistered");
			RenderGraph.NativeFieldInfoPtr_onExecutionUnregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onExecutionUnregistered");
			RenderGraph.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663439);
			RenderGraph.NativeMethodInfoPtr_set_name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663440);
			RenderGraph.NativeMethodInfoPtr_get_requireDebugData_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663441);
			RenderGraph.NativeMethodInfoPtr_set_requireDebugData_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663442);
			RenderGraph.NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663443);
			RenderGraph.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663444);
			RenderGraph.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663445);
			RenderGraph.NativeMethodInfoPtr_RegisterDebug_Public_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663446);
			RenderGraph.NativeMethodInfoPtr_UnRegisterDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663447);
			RenderGraph.NativeMethodInfoPtr_GetRegisteredRenderGraphs_Public_Static_List_1_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663448);
			RenderGraph.NativeMethodInfoPtr_GetDebugData_Internal_RenderGraphDebugData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663449);
			RenderGraph.NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663450);
			RenderGraph.NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663451);
			RenderGraph.NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663452);
			RenderGraph.NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663453);
			RenderGraph.NativeMethodInfoPtr_CreateSharedTexture_Public_TextureHandle_byref_TextureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663454);
			RenderGraph.NativeMethodInfoPtr_RefreshSharedTextureDesc_Public_Void_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663455);
			RenderGraph.NativeMethodInfoPtr_ReleaseSharedTexture_Public_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663456);
			RenderGraph.NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663457);
			RenderGraph.NativeMethodInfoPtr_CreateTextureIfInvalid_Public_Void_byref_TextureDesc_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663458);
			RenderGraph.NativeMethodInfoPtr_GetTextureDesc_Public_TextureDesc_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663459);
			RenderGraph.NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663460);
			RenderGraph.NativeMethodInfoPtr_ImportComputeBuffer_Public_ComputeBufferHandle_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663461);
			RenderGraph.NativeMethodInfoPtr_CreateComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663462);
			RenderGraph.NativeMethodInfoPtr_CreateComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663463);
			RenderGraph.NativeMethodInfoPtr_GetComputeBufferDesc_Public_ComputeBufferDesc_byref_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663464);
			RenderGraph.NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663465);
			RenderGraph.NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663466);
			RenderGraph.NativeMethodInfoPtr_RecordAndExecute_Public_RenderGraphExecution_byref_RenderGraphParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663467);
			RenderGraph.NativeMethodInfoPtr_Execute_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663468);
			RenderGraph.NativeMethodInfoPtr_BeginProfilingSampler_Public_Void_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663469);
			RenderGraph.NativeMethodInfoPtr_EndProfilingSampler_Public_Void_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663470);
			RenderGraph.NativeMethodInfoPtr_GetCompiledPassInfos_Internal_DynamicArray_1_CompiledPassInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663471);
			RenderGraph.NativeMethodInfoPtr_ClearCompiledGraph_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663472);
			RenderGraph.NativeMethodInfoPtr_InvalidateContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663473);
			RenderGraph.NativeMethodInfoPtr_OnPassAdded_Internal_Void_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663474);
			RenderGraph.NativeMethodInfoPtr_add_onGraphRegistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663475);
			RenderGraph.NativeMethodInfoPtr_remove_onGraphRegistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663476);
			RenderGraph.NativeMethodInfoPtr_add_onGraphUnregistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663477);
			RenderGraph.NativeMethodInfoPtr_remove_onGraphUnregistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663478);
			RenderGraph.NativeMethodInfoPtr_add_onExecutionRegistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663479);
			RenderGraph.NativeMethodInfoPtr_remove_onExecutionRegistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663480);
			RenderGraph.NativeMethodInfoPtr_add_onExecutionUnregistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663481);
			RenderGraph.NativeMethodInfoPtr_remove_onExecutionUnregistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663482);
			RenderGraph.NativeMethodInfoPtr_InitResourceInfosData_Private_Void_DynamicArray_1_CompiledResourceInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663483);
			RenderGraph.NativeMethodInfoPtr_InitializeCompilationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663484);
			RenderGraph.NativeMethodInfoPtr_CountReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663485);
			RenderGraph.NativeMethodInfoPtr_CullUnusedPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663486);
			RenderGraph.NativeMethodInfoPtr_UpdatePassSynchronization_Private_Void_byref_CompiledPassInfo_byref_CompiledPassInfo_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663487);
			RenderGraph.NativeMethodInfoPtr_UpdateResourceSynchronization_Private_Void_byref_Int32_byref_Int32_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663488);
			RenderGraph.NativeMethodInfoPtr_GetFirstValidConsumerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663489);
			RenderGraph.NativeMethodInfoPtr_FindTextureProducer_Private_Int32_Int32_byref_CompiledResourceInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663490);
			RenderGraph.NativeMethodInfoPtr_GetLatestProducerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663491);
			RenderGraph.NativeMethodInfoPtr_GetLatestValidReadIndex_Private_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663492);
			RenderGraph.NativeMethodInfoPtr_GetFirstValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663493);
			RenderGraph.NativeMethodInfoPtr_GetLatestValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663494);
			RenderGraph.NativeMethodInfoPtr_CreateRendererLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663495);
			RenderGraph.NativeMethodInfoPtr_GetImportedFallback_Internal_Boolean_TextureDesc_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663496);
			RenderGraph.NativeMethodInfoPtr_AllocateCulledPassResources_Private_Void_byref_CompiledPassInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663497);
			RenderGraph.NativeMethodInfoPtr_UpdateResourceAllocationAndSynchronization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663498);
			RenderGraph.NativeMethodInfoPtr_AreRendererListsEmpty_Private_Boolean_List_1_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663499);
			RenderGraph.NativeMethodInfoPtr_TryCullPassAtIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663500);
			RenderGraph.NativeMethodInfoPtr_CullRendererLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663501);
			RenderGraph.NativeMethodInfoPtr_CompileRenderGraph_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663502);
			RenderGraph.NativeMethodInfoPtr_CompilePassImmediatly_Private_byref_CompiledPassInfo_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663503);
			RenderGraph.NativeMethodInfoPtr_ExecutePassImmediately_Private_Void_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663504);
			RenderGraph.NativeMethodInfoPtr_ExecuteCompiledPass_Private_Void_byref_CompiledPassInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663505);
			RenderGraph.NativeMethodInfoPtr_ExecuteRenderGraph_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663506);
			RenderGraph.NativeMethodInfoPtr_PreRenderPassSetRenderTargets_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663507);
			RenderGraph.NativeMethodInfoPtr_PreRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663508);
			RenderGraph.NativeMethodInfoPtr_PostRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663509);
			RenderGraph.NativeMethodInfoPtr_ClearRenderPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663510);
			RenderGraph.NativeMethodInfoPtr_ReleaseImmediateModeResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663511);
			RenderGraph.NativeMethodInfoPtr_LogFrameInformation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663512);
			RenderGraph.NativeMethodInfoPtr_LogRendererListsCreation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663513);
			RenderGraph.NativeMethodInfoPtr_LogRenderPassBegin_Private_Void_byref_CompiledPassInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663514);
			RenderGraph.NativeMethodInfoPtr_LogCulledPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663515);
			RenderGraph.NativeMethodInfoPtr_GetDefaultProfilingSampler_Private_ProfilingSampler_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663516);
			RenderGraph.NativeMethodInfoPtr_UpdateImportedResourceLifeTime_Private_Void_byref_ResourceDebugData_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663517);
			RenderGraph.NativeMethodInfoPtr_GenerateDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663518);
			RenderGraph.NativeMethodInfoPtr_CleanupDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100663519);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000134E4 File Offset: 0x000116E4
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0001351C File Offset: 0x0001171C
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_set_name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00013560 File Offset: 0x00011760
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00013590 File Offset: 0x00011790
		public unsafe static bool requireDebugData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954841, XrefRangeEnd = 954845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_get_requireDebugData_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954845, XrefRangeEnd = 954849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_set_requireDebugData_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000135C4 File Offset: 0x000117C4
		public unsafe RenderGraphDefaultResources defaultResources
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderGraphDefaultResources>(intPtr3) : null;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00013604 File Offset: 0x00011804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954987, RefRangeEnd = 954988, XrefRangeStart = 954849, XrefRangeEnd = 954987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraph(string name = "RenderGraph")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00013650 File Offset: 0x00011850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955017, RefRangeEnd = 955018, XrefRangeStart = 954988, XrefRangeEnd = 955017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00013684 File Offset: 0x00011884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955018, XrefRangeEnd = 955020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDebug(DebugUI.Panel panel = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_RegisterDebug_Public_Void_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000136C8 File Offset: 0x000118C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955020, XrefRangeEnd = 955026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnRegisterDebug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_UnRegisterDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000136FC File Offset: 0x000118FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955026, XrefRangeEnd = 955030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<RenderGraph> GetRegisteredRenderGraphs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetRegisteredRenderGraphs_Public_Static_List_1_RenderGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RenderGraph>>(intPtr3) : null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00013730 File Offset: 0x00011930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955030, XrefRangeEnd = 955033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphDebugData GetDebugData(string executionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(executionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetDebugData_Internal_RenderGraphDebugData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderGraphDebugData>(intPtr3) : null;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00013780 File Offset: 0x00011980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955043, RefRangeEnd = 955044, XrefRangeStart = 955033, XrefRangeEnd = 955043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_EndFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000137B4 File Offset: 0x000119B4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 955053, RefRangeEnd = 955066, XrefRangeStart = 955044, XrefRangeEnd = 955053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle ImportTexture(RTHandle rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00013804 File Offset: 0x00011A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955084, RefRangeEnd = 955085, XrefRangeStart = 955066, XrefRangeEnd = 955084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00013850 File Offset: 0x00011A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 955087, RefRangeEnd = 955090, XrefRangeStart = 955085, XrefRangeEnd = 955087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle CreateTexture([In] ref TextureDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000138A0 File Offset: 0x00011AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955090, XrefRangeEnd = 955098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle CreateSharedTexture([In] ref TextureDesc desc, bool explicitRelease = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref explicitRelease;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateSharedTexture_Public_TextureHandle_byref_TextureDesc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000138FC File Offset: 0x00011AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955098, XrefRangeEnd = 955118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSharedTextureDesc(TextureHandle handle, [In] ref TextureDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_RefreshSharedTextureDesc_Public_Void_TextureHandle_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00013950 File Offset: 0x00011B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955118, XrefRangeEnd = 955144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseSharedTexture(TextureHandle texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ReleaseSharedTexture_Public_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00013990 File Offset: 0x00011B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955144, XrefRangeEnd = 955146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle CreateTexture(TextureHandle texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000139DC File Offset: 0x00011BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955146, XrefRangeEnd = 955154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTextureIfInvalid([In] ref TextureDesc desc, ref TextureHandle texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &texture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateTextureIfInvalid_Public_Void_byref_TextureDesc_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00013A30 File Offset: 0x00011C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955154, XrefRangeEnd = 955155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureDesc GetTextureDesc(TextureHandle texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetTextureDesc_Public_TextureDesc_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TextureDesc(intPtr);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00013A74 File Offset: 0x00011C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955155, XrefRangeEnd = 955160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListHandle CreateRendererList([In] ref RendererListDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00013AC4 File Offset: 0x00011CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955160, XrefRangeEnd = 955169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ImportComputeBuffer_Public_ComputeBufferHandle_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00013B14 File Offset: 0x00011D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955169, XrefRangeEnd = 955171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle CreateComputeBuffer([In] ref ComputeBufferDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00013B64 File Offset: 0x00011D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955171, XrefRangeEnd = 955173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle CreateComputeBuffer([In] ref ComputeBufferHandle computeBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &computeBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00013BB0 File Offset: 0x00011DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955173, XrefRangeEnd = 955174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferDesc GetComputeBufferDesc([In] ref ComputeBufferHandle computeBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &computeBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetComputeBufferDesc_Public_ComputeBufferDesc_byref_ComputeBufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ComputeBufferDesc(intPtr);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00013BF4 File Offset: 0x00011DF4
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 955186, RefRangeEnd = 955221, XrefRangeStart = 955174, XrefRangeEnd = 955186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler) where PassData : class, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(PassData).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref passData;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sampler);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RenderGraph.MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(PassData).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				passData = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>(intPtr5, false, false));
			}
			return new RenderGraphBuilder(intPtr3);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00013CA0 File Offset: 0x00011EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955221, XrefRangeEnd = 955235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) where PassData : class, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(PassData).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref passData;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RenderGraph.MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(PassData).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				passData = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>(intPtr5, false, false));
			}
			return new RenderGraphBuilder(intPtr3);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00013D38 File Offset: 0x00011F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955278, RefRangeEnd = 955279, XrefRangeStart = 955235, XrefRangeEnd = 955278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphExecution RecordAndExecute([In] ref RenderGraphParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_RecordAndExecute_Public_RenderGraphExecution_byref_RenderGraphParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RenderGraphExecution(intPtr);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00013D84 File Offset: 0x00011F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955295, RefRangeEnd = 955296, XrefRangeStart = 955279, XrefRangeEnd = 955295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_Execute_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955323, RefRangeEnd = 955324, XrefRangeStart = 955296, XrefRangeEnd = 955323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginProfilingSampler(ProfilingSampler sampler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sampler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_BeginProfilingSampler_Public_Void_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00013DFC File Offset: 0x00011FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 955351, RefRangeEnd = 955353, XrefRangeStart = 955324, XrefRangeEnd = 955351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndProfilingSampler(ProfilingSampler sampler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sampler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_EndProfilingSampler_Public_Void_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00013E40 File Offset: 0x00012040
		[CallerCount(0)]
		public unsafe DynamicArray<RenderGraph.CompiledPassInfo> GetCompiledPassInfos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetCompiledPassInfos_Internal_DynamicArray_1_CompiledPassInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicArray<RenderGraph.CompiledPassInfo>>(intPtr3) : null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00013E80 File Offset: 0x00012080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955353, XrefRangeEnd = 955371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCompiledGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ClearCompiledGraph_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00013EB4 File Offset: 0x000120B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955371, XrefRangeEnd = 955375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvalidateContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_InvalidateContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00013EE8 File Offset: 0x000120E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955375, XrefRangeEnd = 955377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPassAdded(RenderGraphPass pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_OnPassAdded_Internal_Void_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00013F2C File Offset: 0x0001212C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955377, XrefRangeEnd = 955388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_add_onGraphRegistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00013F64 File Offset: 0x00012164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955388, XrefRangeEnd = 955399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_remove_onGraphRegistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00013F9C File Offset: 0x0001219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955399, XrefRangeEnd = 955410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_add_onGraphUnregistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00013FD4 File Offset: 0x000121D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955410, XrefRangeEnd = 955421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_remove_onGraphUnregistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001400C File Offset: 0x0001220C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955421, XrefRangeEnd = 955432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onExecutionRegistered(RenderGraph.OnExecutionRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_add_onExecutionRegistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00014044 File Offset: 0x00012244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955432, XrefRangeEnd = 955443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onExecutionRegistered(RenderGraph.OnExecutionRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_remove_onExecutionRegistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001407C File Offset: 0x0001227C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955443, XrefRangeEnd = 955454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onExecutionUnregistered(RenderGraph.OnExecutionRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_add_onExecutionUnregistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000140B4 File Offset: 0x000122B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955454, XrefRangeEnd = 955465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onExecutionUnregistered(RenderGraph.OnExecutionRegisteredDelegate value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_remove_onExecutionUnregistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000140EC File Offset: 0x000122EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 955486, RefRangeEnd = 955488, XrefRangeStart = 955465, XrefRangeEnd = 955486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitResourceInfosData(DynamicArray<RenderGraph.CompiledResourceInfo> resourceInfos, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceInfos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_InitResourceInfosData_Private_Void_DynamicArray_1_CompiledResourceInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001413C File Offset: 0x0001233C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955505, RefRangeEnd = 955506, XrefRangeStart = 955488, XrefRangeEnd = 955505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCompilationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_InitializeCompilationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00014170 File Offset: 0x00012370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955574, RefRangeEnd = 955575, XrefRangeStart = 955506, XrefRangeEnd = 955574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CountReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CountReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000141A4 File Offset: 0x000123A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955639, RefRangeEnd = 955640, XrefRangeStart = 955575, XrefRangeEnd = 955639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CullUnusedPasses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CullUnusedPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000141D8 File Offset: 0x000123D8
		[CallerCount(0)]
		public unsafe void UpdatePassSynchronization(ref RenderGraph.CompiledPassInfo currentPassInfo, ref RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(currentPassInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(producerPassInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPassIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastProducer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intLastSyncIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_UpdatePassSynchronization_Private_Void_byref_CompiledPassInfo_byref_CompiledPassInfo_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001425C File Offset: 0x0001245C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 955651, RefRangeEnd = 955653, XrefRangeStart = 955640, XrefRangeEnd = 955651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, [In] ref RenderGraph.CompiledResourceInfo resource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lastGraphicsPipeSync;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastComputePipeSync;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPassIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(resource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_UpdateResourceSynchronization_Private_Void_byref_Int32_byref_Int32_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000142CC File Offset: 0x000124CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955666, RefRangeEnd = 955667, XrefRangeStart = 955653, XrefRangeEnd = 955666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFirstValidConsumerIndex(int passIndex, [In] ref RenderGraph.CompiledResourceInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetFirstValidConsumerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00014328 File Offset: 0x00012528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955675, RefRangeEnd = 955676, XrefRangeStart = 955667, XrefRangeEnd = 955675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindTextureProducer(int consumerPass, [In] ref RenderGraph.CompiledResourceInfo info, out int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref consumerPass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_FindTextureProducer_Private_Int32_Int32_byref_CompiledResourceInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00014394 File Offset: 0x00012594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955696, RefRangeEnd = 955697, XrefRangeStart = 955676, XrefRangeEnd = 955696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLatestProducerIndex(int passIndex, [In] ref RenderGraph.CompiledResourceInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetLatestProducerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000143F0 File Offset: 0x000125F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 955704, RefRangeEnd = 955706, XrefRangeStart = 955697, XrefRangeEnd = 955704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLatestValidReadIndex([In] ref RenderGraph.CompiledResourceInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetLatestValidReadIndex_Private_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00014440 File Offset: 0x00012640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955716, RefRangeEnd = 955717, XrefRangeStart = 955706, XrefRangeEnd = 955716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFirstValidWriteIndex([In] ref RenderGraph.CompiledResourceInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetFirstValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00014490 File Offset: 0x00012690
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 955724, RefRangeEnd = 955726, XrefRangeStart = 955717, XrefRangeEnd = 955724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLatestValidWriteIndex([In] ref RenderGraph.CompiledResourceInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetLatestValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000144E0 File Offset: 0x000126E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955726, XrefRangeEnd = 955735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateRendererLists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CreateRendererLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00014514 File Offset: 0x00012714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 955760, RefRangeEnd = 955762, XrefRangeStart = 955735, XrefRangeEnd = 955760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(desc));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetImportedFallback_Internal_Boolean_TextureDesc_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00014574 File Offset: 0x00012774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955795, RefRangeEnd = 955796, XrefRangeStart = 955762, XrefRangeEnd = 955795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateCulledPassResources(ref RenderGraph.CompiledPassInfo passInfo, int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(passInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_AllocateCulledPassResources_Private_Void_byref_CompiledPassInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000145C8 File Offset: 0x000127C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955890, RefRangeEnd = 955891, XrefRangeStart = 955796, XrefRangeEnd = 955890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateResourceAllocationAndSynchronization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_UpdateResourceAllocationAndSynchronization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000145FC File Offset: 0x000127FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955915, RefRangeEnd = 955916, XrefRangeStart = 955891, XrefRangeEnd = 955915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreRendererListsEmpty(List<RendererListHandle> rendererLists)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_AreRendererListsEmpty_Private_Boolean_List_1_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001464C File Offset: 0x0001284C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 955928, RefRangeEnd = 955930, XrefRangeStart = 955916, XrefRangeEnd = 955928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCullPassAtIndex(int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_TryCullPassAtIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001468C File Offset: 0x0001288C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955930, XrefRangeEnd = 955941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CullRendererLists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CullRendererLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000146C0 File Offset: 0x000128C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 955984, RefRangeEnd = 955985, XrefRangeStart = 955941, XrefRangeEnd = 955984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileRenderGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CompileRenderGraph_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000146F4 File Offset: 0x000128F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 956075, RefRangeEnd = 956079, XrefRangeStart = 955985, XrefRangeEnd = 956075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref RenderGraph.CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CompilePassImmediatly_Private_byref_CompiledPassInfo_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00014738 File Offset: 0x00012938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956079, XrefRangeEnd = 956081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecutePassImmediately(RenderGraphPass pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ExecutePassImmediately_Private_Void_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001477C File Offset: 0x0001297C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 956096, RefRangeEnd = 956101, XrefRangeStart = 956081, XrefRangeEnd = 956096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCompiledPass(ref RenderGraph.CompiledPassInfo passInfo, int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(passInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ExecuteCompiledPass_Private_Void_byref_CompiledPassInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000147D0 File Offset: 0x000129D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956114, RefRangeEnd = 956115, XrefRangeStart = 956101, XrefRangeEnd = 956114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteRenderGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ExecuteRenderGraph_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00014804 File Offset: 0x00012A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956136, RefRangeEnd = 956137, XrefRangeStart = 956115, XrefRangeEnd = 956136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreRenderPassSetRenderTargets([In] ref RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(passInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_PreRenderPassSetRenderTargets_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001485C File Offset: 0x00012A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956172, RefRangeEnd = 956173, XrefRangeStart = 956137, XrefRangeEnd = 956172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreRenderPassExecute([In] ref RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(passInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_PreRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000148B4 File Offset: 0x00012AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956200, RefRangeEnd = 956201, XrefRangeStart = 956173, XrefRangeEnd = 956200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostRenderPassExecute(ref RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(passInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_PostRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001490C File Offset: 0x00012B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956217, RefRangeEnd = 956218, XrefRangeStart = 956201, XrefRangeEnd = 956217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRenderPasses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ClearRenderPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00014940 File Offset: 0x00012B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956218, XrefRangeEnd = 956234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseImmediateModeResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_ReleaseImmediateModeResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00014974 File Offset: 0x00012B74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 956255, RefRangeEnd = 956257, XrefRangeStart = 956234, XrefRangeEnd = 956255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFrameInformation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_LogFrameInformation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000149A8 File Offset: 0x00012BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956257, XrefRangeEnd = 956269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogRendererListsCreation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_LogRendererListsCreation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000149DC File Offset: 0x00012BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956304, RefRangeEnd = 956305, XrefRangeStart = 956269, XrefRangeEnd = 956304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogRenderPassBegin([In] ref RenderGraph.CompiledPassInfo passInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(passInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_LogRenderPassBegin_Private_Void_byref_CompiledPassInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00014A20 File Offset: 0x00012C20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956347, RefRangeEnd = 956348, XrefRangeStart = 956305, XrefRangeEnd = 956347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogCulledPasses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_LogCulledPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00014A54 File Offset: 0x00012C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956358, RefRangeEnd = 956359, XrefRangeStart = 956348, XrefRangeEnd = 956358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingSampler GetDefaultProfilingSampler(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GetDefaultProfilingSampler_Private_ProfilingSampler_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr3) : null;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00014AA4 File Offset: 0x00012CA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 956382, RefRangeEnd = 956384, XrefRangeStart = 956359, XrefRangeEnd = 956382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_UpdateImportedResourceLifeTime_Private_Void_byref_ResourceDebugData_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00014AFC File Offset: 0x00012CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956384, XrefRangeEnd = 956542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateDebugData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_GenerateDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00014B30 File Offset: 0x00012D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956564, RefRangeEnd = 956565, XrefRangeStart = 956542, XrefRangeEnd = 956564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupDebugData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.NativeMethodInfoPtr_CleanupDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002B2C File Offset: 0x00000D2C
		public RenderGraph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00014B64 File Offset: 0x00012D64
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002B35 File Offset: 0x00000D35
		public unsafe static int kMaxMRTCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderGraph.NativeFieldInfoPtr_kMaxMRTCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraph.NativeFieldInfoPtr_kMaxMRTCount, (void*)(&value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00014B80 File Offset: 0x00012D80
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002B43 File Offset: 0x00000D43
		public unsafe RenderGraphResourceRegistry m_Resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_Resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_Resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00014BB0 File Offset: 0x00012DB0
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002B62 File Offset: 0x00000D62
		public unsafe RenderGraphObjectPool m_RenderGraphPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RenderGraphPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphObjectPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RenderGraphPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00014BE0 File Offset: 0x00012DE0
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002B81 File Offset: 0x00000D81
		public unsafe List<RenderGraphPass> m_RenderPasses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RenderPasses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderGraphPass>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RenderPasses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00014C10 File Offset: 0x00012E10
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public unsafe List<RendererListHandle> m_RendererLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RendererLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RendererListHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RendererLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00014C40 File Offset: 0x00012E40
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002BBF File Offset: 0x00000DBF
		public unsafe RenderGraphDebugParams m_DebugParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DebugParameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphDebugParams>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DebugParameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00014C70 File Offset: 0x00012E70
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002BDE File Offset: 0x00000DDE
		public unsafe RenderGraphLogger m_FrameInformationLogger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_FrameInformationLogger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphLogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_FrameInformationLogger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00014CA0 File Offset: 0x00012EA0
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002BFD File Offset: 0x00000DFD
		public unsafe RenderGraphDefaultResources m_DefaultResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DefaultResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphDefaultResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DefaultResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00014CD0 File Offset: 0x00012ED0
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002C1C File Offset: 0x00000E1C
		public unsafe Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DefaultProfilingSamplers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ProfilingSampler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DefaultProfilingSamplers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00014D00 File Offset: 0x00012F00
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002C3B File Offset: 0x00000E3B
		public unsafe bool m_ExecutionExceptionWasRaised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_ExecutionExceptionWasRaised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_ExecutionExceptionWasRaised)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00014D28 File Offset: 0x00012F28
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002C56 File Offset: 0x00000E56
		public unsafe RenderGraphContext m_RenderGraphContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RenderGraphContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RenderGraphContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00014D58 File Offset: 0x00012F58
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002C75 File Offset: 0x00000E75
		public unsafe CommandBuffer m_PreviousCommandBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_PreviousCommandBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_PreviousCommandBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00014D88 File Offset: 0x00012F88
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002C94 File Offset: 0x00000E94
		public unsafe int m_CurrentImmediatePassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CurrentImmediatePassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CurrentImmediatePassIndex)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00014DB0 File Offset: 0x00012FB0
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002CAF File Offset: 0x00000EAF
		public unsafe Il2CppReferenceArray<List<int>> m_ImmediateModeResourceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_ImmediateModeResourceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_ImmediateModeResourceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00014DE0 File Offset: 0x00012FE0
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002CCE File Offset: 0x00000ECE
		public unsafe Il2CppReferenceArray<DynamicArray<RenderGraph.CompiledResourceInfo>> m_CompiledResourcesInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CompiledResourcesInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicArray<RenderGraph.CompiledResourceInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CompiledResourcesInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00014E10 File Offset: 0x00013010
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002CED File Offset: 0x00000EED
		public unsafe DynamicArray<RenderGraph.CompiledPassInfo> m_CompiledPassInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CompiledPassInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<RenderGraph.CompiledPassInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CompiledPassInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00014E40 File Offset: 0x00013040
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002D0C File Offset: 0x00000F0C
		public unsafe Stack<int> m_CullingStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CullingStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CullingStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00014E70 File Offset: 0x00013070
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002D2B File Offset: 0x00000F2B
		public unsafe int m_ExecutionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_ExecutionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_ExecutionCount)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00014E98 File Offset: 0x00013098
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002D46 File Offset: 0x00000F46
		public unsafe int m_CurrentFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CurrentFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CurrentFrameIndex)) = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00014EC0 File Offset: 0x000130C0
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002D61 File Offset: 0x00000F61
		public unsafe bool m_HasRenderGraphBegun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_HasRenderGraphBegun);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_HasRenderGraphBegun)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00014EE8 File Offset: 0x000130E8
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002D7C File Offset: 0x00000F7C
		public unsafe string m_CurrentExecutionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CurrentExecutionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_CurrentExecutionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00014F10 File Offset: 0x00013110
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002D9B File Offset: 0x00000F9B
		public unsafe bool m_RendererListCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RendererListCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_RendererListCulling)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00014F38 File Offset: 0x00013138
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public unsafe Dictionary<string, RenderGraphDebugData> m_DebugData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DebugData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, RenderGraphDebugData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr_m_DebugData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00014F68 File Offset: 0x00013168
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002DD5 File Offset: 0x00000FD5
		public unsafe static List<RenderGraph> s_RegisteredGraphs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderGraph.NativeFieldInfoPtr_s_RegisteredGraphs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderGraph>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraph.NativeFieldInfoPtr_s_RegisteredGraphs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00014F90 File Offset: 0x00013190
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002DE7 File Offset: 0x00000FE7
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00014FB8 File Offset: 0x000131B8
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002E06 File Offset: 0x00001006
		public unsafe static bool _requireDebugData_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RenderGraph.NativeFieldInfoPtr__requireDebugData_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraph.NativeFieldInfoPtr__requireDebugData_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00014FD4 File Offset: 0x000131D4
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002E14 File Offset: 0x00001014
		public unsafe static RenderGraph.OnGraphRegisteredDelegate onGraphRegistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderGraph.NativeFieldInfoPtr_onGraphRegistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph.OnGraphRegisteredDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraph.NativeFieldInfoPtr_onGraphRegistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00014FFC File Offset: 0x000131FC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002E26 File Offset: 0x00001026
		public unsafe static RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderGraph.NativeFieldInfoPtr_onGraphUnregistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph.OnGraphRegisteredDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraph.NativeFieldInfoPtr_onGraphUnregistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00015024 File Offset: 0x00013224
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002E38 File Offset: 0x00001038
		public unsafe static RenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderGraph.NativeFieldInfoPtr_onExecutionRegistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph.OnExecutionRegisteredDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraph.NativeFieldInfoPtr_onExecutionRegistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0001504C File Offset: 0x0001324C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002E4A File Offset: 0x0000104A
		public unsafe static RenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderGraph.NativeFieldInfoPtr_onExecutionUnregistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph.OnExecutionRegisteredDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraph.NativeFieldInfoPtr_onExecutionUnregistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_kMaxMRTCount;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_m_Resources;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraphPool;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPasses;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererLists;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugParameters;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameInformationLogger;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultResources;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultProfilingSamplers;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionExceptionWasRaised;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraphContext;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousCommandBuffer;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentImmediatePassIndex;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_m_ImmediateModeResourceList;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_m_CompiledResourcesInfos;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_m_CompiledPassInfos;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingStack;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionCount;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFrameIndex;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_m_HasRenderGraphBegun;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentExecutionName;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererListCulling;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugData;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_s_RegisteredGraphs;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr__requireDebugData_k__BackingField;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_onGraphRegistered;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_onGraphUnregistered;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_onExecutionRegistered;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_onExecutionUnregistered;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Private_set_Void_String_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_requireDebugData_Internal_Static_get_Boolean_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_set_requireDebugData_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDebug_Public_Void_Panel_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterDebug_Public_Void_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredRenderGraphs_Public_Static_List_1_RenderGraph_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_GetDebugData_Internal_RenderGraphDebugData_String_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_byref_TextureDesc_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_CreateSharedTexture_Public_TextureHandle_byref_TextureDesc_Boolean_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSharedTextureDesc_Public_Void_TextureHandle_byref_TextureDesc_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSharedTexture_Public_Void_TextureHandle_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextureIfInvalid_Public_Void_byref_TextureDesc_byref_TextureHandle_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureDesc_Public_TextureDesc_TextureHandle_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListDesc_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_ImportComputeBuffer_Public_ComputeBufferHandle_ComputeBuffer_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_CreateComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferDesc_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_CreateComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_GetComputeBufferDesc_Public_ComputeBufferDesc_byref_ComputeBufferHandle_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_RecordAndExecute_Public_RenderGraphExecution_byref_RenderGraphParameters_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Internal_Void_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_BeginProfilingSampler_Public_Void_ProfilingSampler_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_EndProfilingSampler_Public_Void_ProfilingSampler_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_GetCompiledPassInfos_Internal_DynamicArray_1_CompiledPassInfo_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_ClearCompiledGraph_Internal_Void_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_InvalidateContext_Private_Void_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_OnPassAdded_Internal_Void_RenderGraphPass_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_add_onGraphRegistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_remove_onGraphRegistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_add_onGraphUnregistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_remove_onGraphUnregistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_add_onExecutionRegistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_remove_onExecutionRegistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_add_onExecutionUnregistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_remove_onExecutionUnregistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_InitResourceInfosData_Private_Void_DynamicArray_1_CompiledResourceInfo_Int32_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCompilationData_Private_Void_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_CountReferences_Private_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_CullUnusedPasses_Private_Void_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePassSynchronization_Private_Void_byref_CompiledPassInfo_byref_CompiledPassInfo_Int32_Int32_byref_Int32_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_UpdateResourceSynchronization_Private_Void_byref_Int32_byref_Int32_Int32_byref_CompiledResourceInfo_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstValidConsumerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_FindTextureProducer_Private_Int32_Int32_byref_CompiledResourceInfo_byref_Int32_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestProducerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestValidReadIndex_Private_Int32_byref_CompiledResourceInfo_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererLists_Private_Void_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_GetImportedFallback_Internal_Boolean_TextureDesc_byref_TextureHandle_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_AllocateCulledPassResources_Private_Void_byref_CompiledPassInfo_Int32_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_UpdateResourceAllocationAndSynchronization_Private_Void_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_AreRendererListsEmpty_Private_Boolean_List_1_RendererListHandle_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_TryCullPassAtIndex_Private_Void_Int32_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_CullRendererLists_Private_Void_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_CompileRenderGraph_Internal_Void_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_CompilePassImmediatly_Private_byref_CompiledPassInfo_RenderGraphPass_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePassImmediately_Private_Void_RenderGraphPass_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCompiledPass_Private_Void_byref_CompiledPassInfo_Int32_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteRenderGraph_Private_Void_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_PreRenderPassSetRenderTargets_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_PreRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_PostRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphContext_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_ClearRenderPasses_Private_Void_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseImmediateModeResources_Private_Void_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_LogFrameInformation_Private_Void_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_LogRendererListsCreation_Private_Void_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_LogRenderPassBegin_Private_Void_byref_CompiledPassInfo_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_LogCulledPasses_Private_Void_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProfilingSampler_Private_ProfilingSampler_String_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_UpdateImportedResourceLifeTime_Private_Void_byref_ResourceDebugData_List_1_Int32_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_GenerateDebugData_Private_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_CleanupDebugData_Private_Void_0;

		// Token: 0x02000148 RID: 328
		public sealed class CompiledResourceInfo : ValueType
		{
			// Token: 0x06001552 RID: 5458 RVA: 0x0005D474 File Offset: 0x0005B674
			// Note: this type is marked as 'beforefieldinit'.
			static CompiledResourceInfo()
			{
				Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "CompiledResourceInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr);
				RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_producers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr, "producers");
				RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_consumers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr, "consumers");
				RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_refCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr, "refCount");
				RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_imported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr, "imported");
				RenderGraph.CompiledResourceInfo.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr, 100663521);
			}

			// Token: 0x06001553 RID: 5459 RVA: 0x0005D504 File Offset: 0x0005B704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954792, XrefRangeEnd = 954805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.CompiledResourceInfo.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001554 RID: 5460 RVA: 0x0000ACD9 File Offset: 0x00008ED9
			public CompiledResourceInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001555 RID: 5461 RVA: 0x0000ACE2 File Offset: 0x00008EE2
			public CompiledResourceInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph.CompiledResourceInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06001556 RID: 5462 RVA: 0x0005D53C File Offset: 0x0005B73C
			// (set) Token: 0x06001557 RID: 5463 RVA: 0x0000ACF4 File Offset: 0x00008EF4
			public unsafe List<int> producers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_producers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_producers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06001558 RID: 5464 RVA: 0x0005D56C File Offset: 0x0005B76C
			// (set) Token: 0x06001559 RID: 5465 RVA: 0x0000AD13 File Offset: 0x00008F13
			public unsafe List<int> consumers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_consumers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_consumers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x0600155A RID: 5466 RVA: 0x0005D59C File Offset: 0x0005B79C
			// (set) Token: 0x0600155B RID: 5467 RVA: 0x0000AD32 File Offset: 0x00008F32
			public unsafe int refCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_refCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_refCount)) = value;
				}
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x0600155C RID: 5468 RVA: 0x0005D5C4 File Offset: 0x0005B7C4
			// (set) Token: 0x0600155D RID: 5469 RVA: 0x0000AD4D File Offset: 0x00008F4D
			public unsafe bool imported
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_imported);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledResourceInfo.NativeFieldInfoPtr_imported)) = value;
				}
			}

			// Token: 0x04000FA4 RID: 4004
			private static readonly IntPtr NativeFieldInfoPtr_producers;

			// Token: 0x04000FA5 RID: 4005
			private static readonly IntPtr NativeFieldInfoPtr_consumers;

			// Token: 0x04000FA6 RID: 4006
			private static readonly IntPtr NativeFieldInfoPtr_refCount;

			// Token: 0x04000FA7 RID: 4007
			private static readonly IntPtr NativeFieldInfoPtr_imported;

			// Token: 0x04000FA8 RID: 4008
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
		}

		// Token: 0x02000149 RID: 329
		public sealed class CompiledPassInfo : ValueType
		{
			// Token: 0x0600155E RID: 5470 RVA: 0x0005D5EC File Offset: 0x0005B7EC
			// Note: this type is marked as 'beforefieldinit'.
			static CompiledPassInfo()
			{
				Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "CompiledPassInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr);
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "pass");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_resourceCreateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "resourceCreateList");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_resourceReleaseList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "resourceReleaseList");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_refCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "refCount");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "culled");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_culledByRendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "culledByRendererList");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_hasSideEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "hasSideEffect");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_syncToPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "syncToPassIndex");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_syncFromPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "syncFromPassIndex");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_needGraphicsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "needGraphicsFence");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_fence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "fence");
				RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_enableAsyncCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, "enableAsyncCompute");
				RenderGraph.CompiledPassInfo.NativeMethodInfoPtr_get_allowPassCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, 100663522);
				RenderGraph.CompiledPassInfo.NativeMethodInfoPtr_Reset_Public_Void_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr, 100663523);
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x0600155F RID: 5471 RVA: 0x0005D730 File Offset: 0x0005B930
			public unsafe bool allowPassCulling
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.CompiledPassInfo.NativeMethodInfoPtr_get_allowPassCulling_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001560 RID: 5472 RVA: 0x0005D774 File Offset: 0x0005B974
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 954828, RefRangeEnd = 954830, XrefRangeStart = 954805, XrefRangeEnd = 954828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset(RenderGraphPass pass)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.CompiledPassInfo.NativeMethodInfoPtr_Reset_Public_Void_RenderGraphPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001561 RID: 5473 RVA: 0x0000AD68 File Offset: 0x00008F68
			public CompiledPassInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001562 RID: 5474 RVA: 0x0000AD71 File Offset: 0x00008F71
			public CompiledPassInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph.CompiledPassInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x06001563 RID: 5475 RVA: 0x0005D7BC File Offset: 0x0005B9BC
			// (set) Token: 0x06001564 RID: 5476 RVA: 0x0000AD83 File Offset: 0x00008F83
			public unsafe RenderGraphPass pass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_pass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphPass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_pass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x06001565 RID: 5477 RVA: 0x0005D7EC File Offset: 0x0005B9EC
			// (set) Token: 0x06001566 RID: 5478 RVA: 0x0000ADA2 File Offset: 0x00008FA2
			public unsafe Il2CppReferenceArray<List<int>> resourceCreateList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_resourceCreateList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_resourceCreateList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x06001567 RID: 5479 RVA: 0x0005D81C File Offset: 0x0005BA1C
			// (set) Token: 0x06001568 RID: 5480 RVA: 0x0000ADC1 File Offset: 0x00008FC1
			public unsafe Il2CppReferenceArray<List<int>> resourceReleaseList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_resourceReleaseList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_resourceReleaseList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x06001569 RID: 5481 RVA: 0x0005D84C File Offset: 0x0005BA4C
			// (set) Token: 0x0600156A RID: 5482 RVA: 0x0000ADE0 File Offset: 0x00008FE0
			public unsafe int refCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_refCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_refCount)) = value;
				}
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x0600156B RID: 5483 RVA: 0x0005D874 File Offset: 0x0005BA74
			// (set) Token: 0x0600156C RID: 5484 RVA: 0x0000ADFB File Offset: 0x00008FFB
			public unsafe bool culled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_culled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_culled)) = value;
				}
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x0600156D RID: 5485 RVA: 0x0005D89C File Offset: 0x0005BA9C
			// (set) Token: 0x0600156E RID: 5486 RVA: 0x0000AE16 File Offset: 0x00009016
			public unsafe bool culledByRendererList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_culledByRendererList);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_culledByRendererList)) = value;
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x0600156F RID: 5487 RVA: 0x0005D8C4 File Offset: 0x0005BAC4
			// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000AE31 File Offset: 0x00009031
			public unsafe bool hasSideEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_hasSideEffect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_hasSideEffect)) = value;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001571 RID: 5489 RVA: 0x0005D8EC File Offset: 0x0005BAEC
			// (set) Token: 0x06001572 RID: 5490 RVA: 0x0000AE4C File Offset: 0x0000904C
			public unsafe int syncToPassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_syncToPassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_syncToPassIndex)) = value;
				}
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x06001573 RID: 5491 RVA: 0x0005D914 File Offset: 0x0005BB14
			// (set) Token: 0x06001574 RID: 5492 RVA: 0x0000AE67 File Offset: 0x00009067
			public unsafe int syncFromPassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_syncFromPassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_syncFromPassIndex)) = value;
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x06001575 RID: 5493 RVA: 0x0005D93C File Offset: 0x0005BB3C
			// (set) Token: 0x06001576 RID: 5494 RVA: 0x0000AE82 File Offset: 0x00009082
			public unsafe bool needGraphicsFence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_needGraphicsFence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_needGraphicsFence)) = value;
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06001577 RID: 5495 RVA: 0x0005D964 File Offset: 0x0005BB64
			// (set) Token: 0x06001578 RID: 5496 RVA: 0x0000AE9D File Offset: 0x0000909D
			public unsafe GraphicsFence fence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_fence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_fence)) = value;
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06001579 RID: 5497 RVA: 0x0005D98C File Offset: 0x0005BB8C
			// (set) Token: 0x0600157A RID: 5498 RVA: 0x0000AEB8 File Offset: 0x000090B8
			public unsafe bool enableAsyncCompute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_enableAsyncCompute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.CompiledPassInfo.NativeFieldInfoPtr_enableAsyncCompute)) = value;
				}
			}

			// Token: 0x04000FA9 RID: 4009
			private static readonly IntPtr NativeFieldInfoPtr_pass;

			// Token: 0x04000FAA RID: 4010
			private static readonly IntPtr NativeFieldInfoPtr_resourceCreateList;

			// Token: 0x04000FAB RID: 4011
			private static readonly IntPtr NativeFieldInfoPtr_resourceReleaseList;

			// Token: 0x04000FAC RID: 4012
			private static readonly IntPtr NativeFieldInfoPtr_refCount;

			// Token: 0x04000FAD RID: 4013
			private static readonly IntPtr NativeFieldInfoPtr_culled;

			// Token: 0x04000FAE RID: 4014
			private static readonly IntPtr NativeFieldInfoPtr_culledByRendererList;

			// Token: 0x04000FAF RID: 4015
			private static readonly IntPtr NativeFieldInfoPtr_hasSideEffect;

			// Token: 0x04000FB0 RID: 4016
			private static readonly IntPtr NativeFieldInfoPtr_syncToPassIndex;

			// Token: 0x04000FB1 RID: 4017
			private static readonly IntPtr NativeFieldInfoPtr_syncFromPassIndex;

			// Token: 0x04000FB2 RID: 4018
			private static readonly IntPtr NativeFieldInfoPtr_needGraphicsFence;

			// Token: 0x04000FB3 RID: 4019
			private static readonly IntPtr NativeFieldInfoPtr_fence;

			// Token: 0x04000FB4 RID: 4020
			private static readonly IntPtr NativeFieldInfoPtr_enableAsyncCompute;

			// Token: 0x04000FB5 RID: 4021
			private static readonly IntPtr NativeMethodInfoPtr_get_allowPassCulling_Public_get_Boolean_0;

			// Token: 0x04000FB6 RID: 4022
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_RenderGraphPass_0;
		}

		// Token: 0x0200014A RID: 330
		public class ProfilingScopePassData : Object
		{
			// Token: 0x0600157B RID: 5499 RVA: 0x0005D9B4 File Offset: 0x0005BBB4
			// Note: this type is marked as 'beforefieldinit'.
			static ProfilingScopePassData()
			{
				Il2CppClassPointerStore<RenderGraph.ProfilingScopePassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "ProfilingScopePassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraph.ProfilingScopePassData>.NativeClassPtr);
				RenderGraph.ProfilingScopePassData.NativeFieldInfoPtr_sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.ProfilingScopePassData>.NativeClassPtr, "sampler");
				RenderGraph.ProfilingScopePassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.ProfilingScopePassData>.NativeClassPtr, 100663524);
			}

			// Token: 0x0600157C RID: 5500 RVA: 0x0005DA08 File Offset: 0x0005BC08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProfilingScopePassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph.ProfilingScopePassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.ProfilingScopePassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600157D RID: 5501 RVA: 0x0000AED3 File Offset: 0x000090D3
			public ProfilingScopePassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x0600157E RID: 5502 RVA: 0x0005DA44 File Offset: 0x0005BC44
			// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000AEDC File Offset: 0x000090DC
			public unsafe ProfilingSampler sampler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.ProfilingScopePassData.NativeFieldInfoPtr_sampler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraph.ProfilingScopePassData.NativeFieldInfoPtr_sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FB7 RID: 4023
			private static readonly IntPtr NativeFieldInfoPtr_sampler;

			// Token: 0x04000FB8 RID: 4024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200014B RID: 331
		public sealed class OnGraphRegisteredDelegate : MulticastDelegate
		{
			// Token: 0x06001580 RID: 5504 RVA: 0x0005DA74 File Offset: 0x0005BC74
			// Note: this type is marked as 'beforefieldinit'.
			static OnGraphRegisteredDelegate()
			{
				Il2CppClassPointerStore<RenderGraph.OnGraphRegisteredDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "OnGraphRegisteredDelegate");
				RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnGraphRegisteredDelegate>.NativeClassPtr, 100663525);
				RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnGraphRegisteredDelegate>.NativeClassPtr, 100663526);
				RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnGraphRegisteredDelegate>.NativeClassPtr, 100663527);
				RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnGraphRegisteredDelegate>.NativeClassPtr, 100663528);
			}

			// Token: 0x06001581 RID: 5505 RVA: 0x0005DAE8 File Offset: 0x0005BCE8
			[CallerCount(431)]
			[CachedScanResults(RefRangeStart = 436687, RefRangeEnd = 437118, XrefRangeStart = 436687, XrefRangeEnd = 437118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnGraphRegisteredDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph.OnGraphRegisteredDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001582 RID: 5506 RVA: 0x0005DB44 File Offset: 0x0005BD44
			[CallerCount(0)]
			public unsafe void Invoke(RenderGraph graph)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001583 RID: 5507 RVA: 0x0005DB88 File Offset: 0x0005BD88
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RenderGraph graph, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001584 RID: 5508 RVA: 0x0005DBFC File Offset: 0x0005BDFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnGraphRegisteredDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001585 RID: 5509 RVA: 0x0000AEFB File Offset: 0x000090FB
			public OnGraphRegisteredDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001586 RID: 5510 RVA: 0x0000AF04 File Offset: 0x00009104
			public static implicit operator RenderGraph.OnGraphRegisteredDelegate(Action<RenderGraph> A_0)
			{
				return DelegateSupport.ConvertDelegate<RenderGraph.OnGraphRegisteredDelegate>(A_0);
			}

			// Token: 0x06001587 RID: 5511 RVA: 0x0000AF0C File Offset: 0x0000910C
			public static RenderGraph.OnGraphRegisteredDelegate operator +(RenderGraph.OnGraphRegisteredDelegate A_0, RenderGraph.OnGraphRegisteredDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RenderGraph.OnGraphRegisteredDelegate>();
			}

			// Token: 0x06001588 RID: 5512 RVA: 0x0000AF1A File Offset: 0x0000911A
			public static RenderGraph.OnGraphRegisteredDelegate operator -(RenderGraph.OnGraphRegisteredDelegate A_0, RenderGraph.OnGraphRegisteredDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RenderGraph.OnGraphRegisteredDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04000FB9 RID: 4025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000FBA RID: 4026
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_0;

			// Token: 0x04000FBB RID: 4027
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_AsyncCallback_Object_0;

			// Token: 0x04000FBC RID: 4028
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200014C RID: 332
		public sealed class OnExecutionRegisteredDelegate : MulticastDelegate
		{
			// Token: 0x06001589 RID: 5513 RVA: 0x0005DC40 File Offset: 0x0005BE40
			// Note: this type is marked as 'beforefieldinit'.
			static OnExecutionRegisteredDelegate()
			{
				Il2CppClassPointerStore<RenderGraph.OnExecutionRegisteredDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "OnExecutionRegisteredDelegate");
				RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnExecutionRegisteredDelegate>.NativeClassPtr, 100663529);
				RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnExecutionRegisteredDelegate>.NativeClassPtr, 100663530);
				RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnExecutionRegisteredDelegate>.NativeClassPtr, 100663531);
				RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.OnExecutionRegisteredDelegate>.NativeClassPtr, 100663532);
			}

			// Token: 0x0600158A RID: 5514 RVA: 0x0005DCB4 File Offset: 0x0005BEB4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnExecutionRegisteredDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph.OnExecutionRegisteredDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600158B RID: 5515 RVA: 0x0005DD10 File Offset: 0x0005BF10
			[CallerCount(0)]
			public unsafe void Invoke(RenderGraph graph, string executionName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(executionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600158C RID: 5516 RVA: 0x0005DD64 File Offset: 0x0005BF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RenderGraph graph, string executionName, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(executionName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600158D RID: 5517 RVA: 0x0005DDEC File Offset: 0x0005BFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.OnExecutionRegisteredDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600158E RID: 5518 RVA: 0x0000AF2B File Offset: 0x0000912B
			public OnExecutionRegisteredDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600158F RID: 5519 RVA: 0x0000AF34 File Offset: 0x00009134
			public static implicit operator RenderGraph.OnExecutionRegisteredDelegate(Action<RenderGraph, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<RenderGraph.OnExecutionRegisteredDelegate>(A_0);
			}

			// Token: 0x06001590 RID: 5520 RVA: 0x0000AF3C File Offset: 0x0000913C
			public static RenderGraph.OnExecutionRegisteredDelegate operator +(RenderGraph.OnExecutionRegisteredDelegate A_0, RenderGraph.OnExecutionRegisteredDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RenderGraph.OnExecutionRegisteredDelegate>();
			}

			// Token: 0x06001591 RID: 5521 RVA: 0x0000AF4A File Offset: 0x0000914A
			public static RenderGraph.OnExecutionRegisteredDelegate operator -(RenderGraph.OnExecutionRegisteredDelegate A_0, RenderGraph.OnExecutionRegisteredDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RenderGraph.OnExecutionRegisteredDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04000FBD RID: 4029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000FBE RID: 4030
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_String_0;

			// Token: 0x04000FBF RID: 4031
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_String_AsyncCallback_Object_0;

			// Token: 0x04000FC0 RID: 4032
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200014D RID: 333
		[ObfuscatedName("UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001592 RID: 5522 RVA: 0x0005DE30 File Offset: 0x0005C030
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr);
				RenderGraph.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr, "<>9");
				RenderGraph.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr, "<>9__62_0");
				RenderGraph.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr, "<>9__63_0");
				RenderGraph.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr, 100663534);
				RenderGraph.__c.NativeMethodInfoPtr__BeginProfilingSampler_b__62_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr, 100663535);
				RenderGraph.__c.NativeMethodInfoPtr__EndProfilingSampler_b__63_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr, 100663536);
			}

			// Token: 0x06001593 RID: 5523 RVA: 0x0005DED4 File Offset: 0x0005C0D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001594 RID: 5524 RVA: 0x0005DF10 File Offset: 0x0005C110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954830, XrefRangeEnd = 954832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginProfilingSampler_b__62_0(RenderGraph.ProfilingScopePassData data, RenderGraphContext ctx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.__c.NativeMethodInfoPtr__BeginProfilingSampler_b__62_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001595 RID: 5525 RVA: 0x0005DF64 File Offset: 0x0005C164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954832, XrefRangeEnd = 954841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EndProfilingSampler_b__63_0(RenderGraph.ProfilingScopePassData data, RenderGraphContext ctx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraph.__c.NativeMethodInfoPtr__EndProfilingSampler_b__63_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001596 RID: 5526 RVA: 0x0000AF5B File Offset: 0x0000915B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001597 RID: 5527 RVA: 0x0005DFB8 File Offset: 0x0005C1B8
			// (set) Token: 0x06001598 RID: 5528 RVA: 0x0000AF64 File Offset: 0x00009164
			public unsafe static RenderGraph.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderGraph.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraph.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001599 RID: 5529 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
			// (set) Token: 0x0600159A RID: 5530 RVA: 0x0000AF76 File Offset: 0x00009176
			public unsafe static RenderFunc<RenderGraph.ProfilingScopePassData> __9__62_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderGraph.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<RenderGraph.ProfilingScopePassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraph.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x0600159B RID: 5531 RVA: 0x0005E008 File Offset: 0x0005C208
			// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000AF88 File Offset: 0x00009188
			public unsafe static RenderFunc<RenderGraph.ProfilingScopePassData> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderGraph.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<RenderGraph.ProfilingScopePassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraph.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FC1 RID: 4033
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FC2 RID: 4034
			private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

			// Token: 0x04000FC3 RID: 4035
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x04000FC4 RID: 4036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FC5 RID: 4037
			private static readonly IntPtr NativeMethodInfoPtr__BeginProfilingSampler_b__62_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0;

			// Token: 0x04000FC6 RID: 4038
			private static readonly IntPtr NativeMethodInfoPtr__EndProfilingSampler_b__63_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0;
		}

		// Token: 0x0200014E RID: 334
		private sealed class MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_0<PassData>
		{
			// Token: 0x04000FC7 RID: 4039
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraph.NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
		}

		// Token: 0x0200014F RID: 335
		private sealed class MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_0<PassData>
		{
			// Token: 0x04000FC8 RID: 4040
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraph.NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
		}
	}
}
