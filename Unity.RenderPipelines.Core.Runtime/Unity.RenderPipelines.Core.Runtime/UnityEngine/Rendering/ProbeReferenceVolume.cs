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
using UnityEngine.Events;

namespace UnityEngine.Rendering
{
	// Token: 0x0200008B RID: 139
	public class ProbeReferenceVolume : Object
	{
		// Token: 0x06000990 RID: 2448 RVA: 0x00030B24 File Offset: 0x0002ED24
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeReferenceVolume()
		{
			Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeReferenceVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr);
			ProbeReferenceVolume.NativeFieldInfoPtr_m_IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_IsInitialized");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_SupportStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_SupportStreaming");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_Transform");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_MaxSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_MaxSubdivision");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_Pool");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_Index");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_CellIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CellIndices");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_BlendingPool");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TmpSrcChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TmpSrcChunks");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_PositionOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_PositionOffsets");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_CurrGlobalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CurrGlobalBounds");
			ProbeReferenceVolume.NativeFieldInfoPtr_cells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "cells");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_CellInfoPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CellInfoPool");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingCellInfoPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_BlendingCellInfoPool");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TemporaryDataLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TemporaryDataLocation");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TemporaryDataLocationMemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TemporaryDataLocationMemCost");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_CurrentProbeVolumeChunkSizeInBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CurrentProbeVolumeChunkSizeInBricks");
			ProbeReferenceVolume.NativeFieldInfoPtr_sceneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "sceneData");
			ProbeReferenceVolume.NativeFieldInfoPtr_minLoadedCellPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "minLoadedCellPos");
			ProbeReferenceVolume.NativeFieldInfoPtr_maxLoadedCellPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "maxLoadedCellPos");
			ProbeReferenceVolume.NativeFieldInfoPtr_retrieveExtraDataAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "retrieveExtraDataAction");
			ProbeReferenceVolume.NativeFieldInfoPtr_checksDuringBakeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "checksDuringBakeAction");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_BricksLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_BricksLoaded");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingAssetsToBeLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_PendingAssetsToBeLoaded");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingAssetsToBeUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_PendingAssetsToBeUnloaded");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_ActiveAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ActiveAssets");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_NeedLoadAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NeedLoadAsset");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_ProbeReferenceVolumeInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ProbeReferenceVolumeInit");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_EnabledBySRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_EnabledBySRP");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingInitInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_PendingInitInfo");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_NeedsIndexRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NeedsIndexRebuild");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_HasChangedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_HasChangedIndex");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_CBShaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CBShaderID");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NumberOfCellsLoadedPerFrame");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NumberOfCellsBlendedPerFrame");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TurnoverRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TurnoverRate");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_MemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_MemoryBudget");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingMemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_BlendingMemoryBudget");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_SHBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_SHBands");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_ProbeVolumesWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ProbeVolumesWeight");
			ProbeReferenceVolume.NativeFieldInfoPtr_clearAssetsOnVolumeClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "clearAssetsOnVolumeClear");
			ProbeReferenceVolume.NativeFieldInfoPtr_defaultLightingScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "defaultLightingScenario");
			ProbeReferenceVolume.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "_instance");
			ProbeReferenceVolume.NativeFieldInfoPtr__perSceneDataList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<perSceneDataList>k__BackingField");
			ProbeReferenceVolume.NativeFieldInfoPtr_kProbesPerBatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "kProbesPerBatch");
			ProbeReferenceVolume.NativeFieldInfoPtr_k_DebugPanelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "k_DebugPanelName");
			ProbeReferenceVolume.NativeFieldInfoPtr__probeVolumeDebug_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<probeVolumeDebug>k__BackingField");
			ProbeReferenceVolume.NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<subdivisionDebugColors>k__BackingField");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugItems");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugMesh");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugMaterial");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugOffsetMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugOffsetMesh");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugOffsetMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugOffsetMaterial");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugFrustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugFrustumPlanes");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugScenarioNames");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugScenarioValues");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugActiveSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugActiveSceneGUID");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugActiveScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugActiveScenario");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugScenarioField");
			ProbeReferenceVolume.NativeFieldInfoPtr_bakingProcessSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "bakingProcessSettings");
			ProbeReferenceVolume.NativeFieldInfoPtr_realtimeSubdivisionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "realtimeSubdivisionInfo");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_MaxSubdivVisualizedIsMaxAvailable");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_LoadedCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_LoadedCells");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_ToBeLoadedCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ToBeLoadedCells");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TempCellToLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempCellToLoadList");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TempCellToUnloadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempCellToUnloadList");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_LoadedBlendingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_LoadedBlendingCells");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_ToBeLoadedBlendingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ToBeLoadedBlendingCells");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TempBlendingCellToLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempBlendingCellToLoadList");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_TempBlendingCellToUnloadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempBlendingCellToUnloadList");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_FrozenCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_FrozenCameraPosition");
			ProbeReferenceVolume.NativeFieldInfoPtr_m_HasRemainingCellsToBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_HasRemainingCellsToBlend");
			ProbeReferenceVolume.NativeMethodInfoPtr_get_globalBounds_Internal_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664743);
			ProbeReferenceVolume.NativeMethodInfoPtr_set_globalBounds_Internal_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664744);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664745);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_enabledBySRP_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664746);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_hasUnloadedCells_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664747);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_enableScenarioBlending_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664748);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_numberOfCellsLoadedPerFrame_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664749);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_numberOfCellsBlendedPerFrame_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664750);
			ProbeReferenceVolume.NativeMethodInfoPtr_set_numberOfCellsBlendedPerFrame_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664751);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_turnoverRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664752);
			ProbeReferenceVolume.NativeMethodInfoPtr_set_turnoverRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664753);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_shBands_Public_get_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664754);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_lightingScenario_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664755);
			ProbeReferenceVolume.NativeMethodInfoPtr_set_lightingScenario_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664756);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_scenarioBlendingFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664757);
			ProbeReferenceVolume.NativeMethodInfoPtr_set_scenarioBlendingFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664758);
			ProbeReferenceVolume.NativeMethodInfoPtr_BlendLightingScenario_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664759);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_memoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664760);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_probeVolumesWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664761);
			ProbeReferenceVolume.NativeMethodInfoPtr_set_probeVolumesWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664762);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_perSceneDataList_Internal_get_List_1_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664763);
			ProbeReferenceVolume.NativeMethodInfoPtr_set_perSceneDataList_Private_set_Void_List_1_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664764);
			ProbeReferenceVolume.NativeMethodInfoPtr_RegisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664765);
			ProbeReferenceVolume.NativeMethodInfoPtr_UnregisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664766);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_instance_Public_Static_get_ProbeReferenceVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664767);
			ProbeReferenceVolume.NativeMethodInfoPtr_Initialize_Public_Void_byref_ProbeVolumeSystemParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664768);
			ProbeReferenceVolume.NativeMethodInfoPtr_SetEnableStateFromSRP_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664769);
			ProbeReferenceVolume.NativeMethodInfoPtr_ForceSHBand_Internal_Void_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664770);
			ProbeReferenceVolume.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664771);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetVideoMemoryCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664772);
			ProbeReferenceVolume.NativeMethodInfoPtr_RemoveCell_Private_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664773);
			ProbeReferenceVolume.NativeMethodInfoPtr_UnloadCell_Internal_Void_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664774);
			ProbeReferenceVolume.NativeMethodInfoPtr_UnloadBlendingCell_Internal_Void_BlendingCellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664775);
			ProbeReferenceVolume.NativeMethodInfoPtr_UnloadAllCells_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664776);
			ProbeReferenceVolume.NativeMethodInfoPtr_UnloadAllBlendingCells_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664777);
			ProbeReferenceVolume.NativeMethodInfoPtr_AddCell_Private_Void_Cell_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664778);
			ProbeReferenceVolume.NativeMethodInfoPtr_LoadCell_Internal_Boolean_CellInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664779);
			ProbeReferenceVolume.NativeMethodInfoPtr_LoadAllCells_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664780);
			ProbeReferenceVolume.NativeMethodInfoPtr_RecomputeMinMaxLoadedCellPos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664781);
			ProbeReferenceVolume.NativeMethodInfoPtr_CheckCompatibilityWithCollection_Private_Boolean_ProbeVolumeAsset_Dictionary_2_String_ProbeVolumeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664782);
			ProbeReferenceVolume.NativeMethodInfoPtr_AddPendingAssetLoading_Internal_Void_ProbeVolumeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664783);
			ProbeReferenceVolume.NativeMethodInfoPtr_AddPendingAssetRemoval_Internal_Void_ProbeVolumeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664784);
			ProbeReferenceVolume.NativeMethodInfoPtr_RemovePendingAsset_Internal_Void_ProbeVolumeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664785);
			ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingIndexChangeAndInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664786);
			ProbeReferenceVolume.NativeMethodInfoPtr_SetMinBrickAndMaxSubdiv_Internal_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664787);
			ProbeReferenceVolume.NativeMethodInfoPtr_LoadAsset_Private_Void_ProbeVolumeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664788);
			ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingLoading_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664789);
			ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingDeletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664790);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetNumberOfBricksAtSubdiv_Internal_Int32_Vector3Int_Int32_byref_Vector3Int_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664791);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetCellIndexUpdate_Private_Boolean_Cell_byref_CellIndexUpdateInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664792);
			ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingOperations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664793);
			ProbeReferenceVolume.NativeMethodInfoPtr_InitProbeReferenceVolume_Private_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664794);
			ProbeReferenceVolume.NativeMethodInfoPtr_AllocateTemporaryDataLocation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664795);
			ProbeReferenceVolume.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664796);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetRuntimeResources_Public_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664797);
			ProbeReferenceVolume.NativeMethodInfoPtr_SetTRS_Internal_Void_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664798);
			ProbeReferenceVolume.NativeMethodInfoPtr_SetMaxSubdivision_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664799);
			ProbeReferenceVolume.NativeMethodInfoPtr_CellSize_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664800);
			ProbeReferenceVolume.NativeMethodInfoPtr_BrickSize_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664801);
			ProbeReferenceVolume.NativeMethodInfoPtr_MinBrickSize_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664802);
			ProbeReferenceVolume.NativeMethodInfoPtr_MaxBrickSize_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664803);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetTransform_Internal_RefVolTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664804);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664805);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664806);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetDistanceBetweenProbes_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664807);
			ProbeReferenceVolume.NativeMethodInfoPtr_MinDistanceBetweenProbes_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664808);
			ProbeReferenceVolume.NativeMethodInfoPtr_DataHasBeenLoaded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664809);
			ProbeReferenceVolume.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664810);
			ProbeReferenceVolume.NativeMethodInfoPtr_GetSourceLocations_Private_List_1_BrickChunkAlloc_Int32_Int32_DataLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664811);
			ProbeReferenceVolume.NativeMethodInfoPtr_UpdatePool_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664812);
			ProbeReferenceVolume.NativeMethodInfoPtr_UpdatePoolValidity_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664813);
			ProbeReferenceVolume.NativeMethodInfoPtr_AddBlendingBricks_Private_Boolean_BlendingCellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664814);
			ProbeReferenceVolume.NativeMethodInfoPtr_AddBricks_Private_Boolean_CellInfo_CellIndexUpdateInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664815);
			ProbeReferenceVolume.NativeMethodInfoPtr_UpdateCellIndex_Private_Void_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664816);
			ProbeReferenceVolume.NativeMethodInfoPtr_ReleaseBricks_Private_Void_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664817);
			ProbeReferenceVolume.NativeMethodInfoPtr_UpdateConstantBuffer_Public_Void_CommandBuffer_ProbeVolumeShadingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664818);
			ProbeReferenceVolume.NativeMethodInfoPtr_CleanupLoadedData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664819);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_probeVolumeDebug_Internal_get_ProbeVolumeDebug_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664820);
			ProbeReferenceVolume.NativeMethodInfoPtr_get_subdivisionDebugColors_Public_get_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664821);
			ProbeReferenceVolume.NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664822);
			ProbeReferenceVolume.NativeMethodInfoPtr_InitializeDebug_Private_Void_byref_ProbeVolumeSystemParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664823);
			ProbeReferenceVolume.NativeMethodInfoPtr_CleanupDebug_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664824);
			ProbeReferenceVolume.NativeMethodInfoPtr_DebugCellIndexChanged_Private_Void_Field_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664825);
			ProbeReferenceVolume.NativeMethodInfoPtr_RegisterDebug_Private_Void_ProbeVolumeSystemParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664826);
			ProbeReferenceVolume.NativeMethodInfoPtr_UnregisterDebug_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664827);
			ProbeReferenceVolume.NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Transform_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664828);
			ProbeReferenceVolume.NativeMethodInfoPtr_DrawProbeDebug_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664829);
			ProbeReferenceVolume.NativeMethodInfoPtr_ResetDebugViewToMaxSubdiv_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664830);
			ProbeReferenceVolume.NativeMethodInfoPtr_ClearDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664831);
			ProbeReferenceVolume.NativeMethodInfoPtr_CreateInstancedProbes_Private_CellInstancedDebugProbes_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664832);
			ProbeReferenceVolume.NativeMethodInfoPtr_OnClearLightingdata_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664833);
			ProbeReferenceVolume.NativeMethodInfoPtr_ScenarioBlendingChanged_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664834);
			ProbeReferenceVolume.NativeMethodInfoPtr_SetNumberOfCellsLoadedPerFrame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664835);
			ProbeReferenceVolume.NativeMethodInfoPtr_ComputeCellCameraDistance_Private_Void_Vector3_DynamicArray_1_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664836);
			ProbeReferenceVolume.NativeMethodInfoPtr_ComputeStreamingScoreForBlending_Private_Void_DynamicArray_1_BlendingCellInfo_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664837);
			ProbeReferenceVolume.NativeMethodInfoPtr_TryLoadCell_Private_Boolean_CellInfo_byref_Int32_byref_Int32_DynamicArray_1_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664838);
			ProbeReferenceVolume.NativeMethodInfoPtr_UnloadBlendingCell_Private_Void_BlendingCellInfo_DynamicArray_1_BlendingCellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664839);
			ProbeReferenceVolume.NativeMethodInfoPtr_TryLoadBlendingCell_Private_Boolean_BlendingCellInfo_DynamicArray_1_BlendingCellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664840);
			ProbeReferenceVolume.NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664841);
			ProbeReferenceVolume.NativeMethodInfoPtr_FindWorstBlendingCellToBeLoaded_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664842);
			ProbeReferenceVolume.NativeMethodInfoPtr_UpdateBlendingCellStreaming_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100664843);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x000318D8 File Offset: 0x0002FAD8
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00031914 File Offset: 0x0002FB14
		public unsafe Bounds globalBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_globalBounds_Internal_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_set_globalBounds_Internal_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00031954 File Offset: 0x0002FB54
		public unsafe bool isInitialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00031990 File Offset: 0x0002FB90
		public unsafe bool enabledBySRP
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_enabledBySRP_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x000319CC File Offset: 0x0002FBCC
		public unsafe bool hasUnloadedCells
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967266, XrefRangeEnd = 967267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_hasUnloadedCells_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00031A08 File Offset: 0x0002FC08
		public unsafe bool enableScenarioBlending
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 967268, RefRangeEnd = 967274, XrefRangeStart = 967267, XrefRangeEnd = 967268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_enableScenarioBlending_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00031A44 File Offset: 0x0002FC44
		public unsafe int numberOfCellsLoadedPerFrame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_numberOfCellsLoadedPerFrame_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00031A80 File Offset: 0x0002FC80
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00031ABC File Offset: 0x0002FCBC
		public unsafe int numberOfCellsBlendedPerFrame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_numberOfCellsBlendedPerFrame_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967274, RefRangeEnd = 967275, XrefRangeStart = 967274, XrefRangeEnd = 967274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_set_numberOfCellsBlendedPerFrame_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00031AFC File Offset: 0x0002FCFC
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00031B38 File Offset: 0x0002FD38
		public unsafe float turnoverRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_turnoverRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967275, RefRangeEnd = 967276, XrefRangeStart = 967275, XrefRangeEnd = 967275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_set_turnoverRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00031B78 File Offset: 0x0002FD78
		public unsafe ProbeVolumeSHBands shBands
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_shBands_Public_get_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00031BB4 File Offset: 0x0002FDB4
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00031BEC File Offset: 0x0002FDEC
		public unsafe string lightingScenario
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_lightingScenario_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967276, XrefRangeEnd = 967278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_set_lightingScenario_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00031C30 File Offset: 0x0002FE30
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x00031C6C File Offset: 0x0002FE6C
		public unsafe float scenarioBlendingFactor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967278, RefRangeEnd = 967279, XrefRangeStart = 967278, XrefRangeEnd = 967278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_scenarioBlendingFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967281, RefRangeEnd = 967282, XrefRangeStart = 967279, XrefRangeEnd = 967281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_set_scenarioBlendingFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00031CAC File Offset: 0x0002FEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967282, XrefRangeEnd = 967284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendLightingScenario(string otherScenario, float blendingFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(otherScenario);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendingFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_BlendLightingScenario_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00031CFC File Offset: 0x0002FEFC
		public unsafe ProbeVolumeTextureMemoryBudget memoryBudget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_memoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00031D38 File Offset: 0x0002FF38
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00031D74 File Offset: 0x0002FF74
		public unsafe float probeVolumesWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_probeVolumesWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_set_probeVolumesWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00031DB4 File Offset: 0x0002FFB4
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00031DF4 File Offset: 0x0002FFF4
		public unsafe List<ProbeVolumePerSceneData> perSceneDataList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_perSceneDataList_Internal_get_List_1_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumePerSceneData>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_set_perSceneDataList_Private_set_Void_List_1_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00031E38 File Offset: 0x00030038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967290, RefRangeEnd = 967291, XrefRangeStart = 967284, XrefRangeEnd = 967290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterPerSceneData(ProbeVolumePerSceneData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_RegisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00031E7C File Offset: 0x0003007C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967295, RefRangeEnd = 967296, XrefRangeStart = 967291, XrefRangeEnd = 967295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterPerSceneData(ProbeVolumePerSceneData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UnregisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00031EC0 File Offset: 0x000300C0
		public unsafe static ProbeReferenceVolume instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967296, XrefRangeEnd = 967300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_instance_Public_Static_get_ProbeReferenceVolume_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume>(intPtr3) : null;
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00031EF4 File Offset: 0x000300F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967300, XrefRangeEnd = 967356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize([In] ref ProbeVolumeSystemParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_Initialize_Public_Void_byref_ProbeVolumeSystemParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00031F38 File Offset: 0x00030138
		[CallerCount(0)]
		public unsafe void SetEnableStateFromSRP(bool srpEnablesPV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srpEnablesPV;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_SetEnableStateFromSRP_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00031F78 File Offset: 0x00030178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967356, XrefRangeEnd = 967358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceSHBand(ProbeVolumeSHBands shBands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shBands;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ForceSHBand_Internal_Void_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00031FB8 File Offset: 0x000301B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967358, XrefRangeEnd = 967376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00031FEC File Offset: 0x000301EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967376, XrefRangeEnd = 967377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVideoMemoryCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetVideoMemoryCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00032028 File Offset: 0x00030228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967417, RefRangeEnd = 967418, XrefRangeStart = 967377, XrefRangeEnd = 967417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCell(ProbeReferenceVolume.Cell cell)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_RemoveCell_Private_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0003206C File Offset: 0x0003026C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967440, RefRangeEnd = 967442, XrefRangeStart = 967418, XrefRangeEnd = 967440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadCell(ProbeReferenceVolume.CellInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UnloadCell_Internal_Void_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000320B0 File Offset: 0x000302B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 967445, RefRangeEnd = 967449, XrefRangeStart = 967442, XrefRangeEnd = 967445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendingCell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UnloadBlendingCell_Internal_Void_BlendingCellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000320F4 File Offset: 0x000302F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 967462, RefRangeEnd = 967465, XrefRangeStart = 967449, XrefRangeEnd = 967462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadAllCells()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UnloadAllCells_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00032128 File Offset: 0x00030328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967465, XrefRangeEnd = 967480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadAllBlendingCells()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UnloadAllBlendingCells_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0003215C File Offset: 0x0003035C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967487, RefRangeEnd = 967488, XrefRangeStart = 967480, XrefRangeEnd = 967487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCell(ProbeReferenceVolume.Cell cell, int assetInstanceID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assetInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_AddCell_Private_Void_Cell_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000321AC File Offset: 0x000303AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 967494, RefRangeEnd = 967499, XrefRangeStart = 967488, XrefRangeEnd = 967494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadCell(ProbeReferenceVolume.CellInfo cellInfo, bool ignoreErrorLog = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrorLog;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_LoadCell_Internal_Boolean_CellInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00032208 File Offset: 0x00030408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967499, XrefRangeEnd = 967514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAllCells()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_LoadAllCells_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0003223C File Offset: 0x0003043C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967531, RefRangeEnd = 967533, XrefRangeStart = 967514, XrefRangeEnd = 967531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecomputeMinMaxLoadedCellPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_RecomputeMinMaxLoadedCellPos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00032270 File Offset: 0x00030470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967553, RefRangeEnd = 967555, XrefRangeStart = 967533, XrefRangeEnd = 967553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_CheckCompatibilityWithCollection_Private_Boolean_ProbeVolumeAsset_Dictionary_2_String_ProbeVolumeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000322D0 File Offset: 0x000304D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967613, RefRangeEnd = 967614, XrefRangeStart = 967555, XrefRangeEnd = 967613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPendingAssetLoading(ProbeVolumeAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_AddPendingAssetLoading_Internal_Void_ProbeVolumeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00032314 File Offset: 0x00030514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967625, RefRangeEnd = 967626, XrefRangeStart = 967614, XrefRangeEnd = 967625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPendingAssetRemoval(ProbeVolumeAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_AddPendingAssetRemoval_Internal_Void_ProbeVolumeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00032358 File Offset: 0x00030558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967660, RefRangeEnd = 967661, XrefRangeStart = 967626, XrefRangeEnd = 967660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePendingAsset(ProbeVolumeAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_RemovePendingAsset_Internal_Void_ProbeVolumeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0003239C File Offset: 0x0003059C
		[CallerCount(0)]
		public unsafe void PerformPendingIndexChangeAndInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingIndexChangeAndInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000323D0 File Offset: 0x000305D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967661, XrefRangeEnd = 967669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minBrickSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSubdiv;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_SetMinBrickAndMaxSubdiv_Internal_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0003241C File Offset: 0x0003061C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967695, RefRangeEnd = 967697, XrefRangeStart = 967669, XrefRangeEnd = 967695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(ProbeVolumeAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_LoadAsset_Private_Void_ProbeVolumeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00032460 File Offset: 0x00030660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967745, RefRangeEnd = 967746, XrefRangeStart = 967697, XrefRangeEnd = 967745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformPendingLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingLoading_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00032494 File Offset: 0x00030694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967769, RefRangeEnd = 967770, XrefRangeStart = 967746, XrefRangeEnd = 967769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformPendingDeletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingDeletion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000324C8 File Offset: 0x000306C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967808, RefRangeEnd = 967810, XrefRangeStart = 967770, XrefRangeEnd = 967808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumberOfBricksAtSubdiv(Vector3Int position, int minSubdiv, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minSubdiv;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minValidLocalIdxAtMaxRes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sizeOfValidIndicesAtMaxRes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetNumberOfBricksAtSubdiv_Internal_Int32_Vector3Int_Int32_byref_Vector3Int_byref_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0003253C File Offset: 0x0003073C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967810, XrefRangeEnd = 967817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCellIndexUpdate(ProbeReferenceVolume.Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cellUpdateInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrorLog;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetCellIndexUpdate_Private_Boolean_Cell_byref_CellIndexUpdateInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000325A8 File Offset: 0x000307A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967817, XrefRangeEnd = 967822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformPendingOperations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_PerformPendingOperations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000325DC File Offset: 0x000307DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 967858, RefRangeEnd = 967861, XrefRangeStart = 967822, XrefRangeEnd = 967858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitProbeReferenceVolume(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget, ProbeVolumeSHBands shBands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memoryBudget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendingMemoryBudget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shBands;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_InitProbeReferenceVolume_Private_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00032638 File Offset: 0x00030838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967866, RefRangeEnd = 967868, XrefRangeStart = 967861, XrefRangeEnd = 967866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateTemporaryDataLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_AllocateTemporaryDataLocation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0003266C File Offset: 0x0003086C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967868, XrefRangeEnd = 968033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeReferenceVolume()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000326A8 File Offset: 0x000308A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968033, XrefRangeEnd = 968038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeReferenceVolume.RuntimeResources GetRuntimeResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetRuntimeResources_Public_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ProbeReferenceVolume.RuntimeResources(intPtr);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000326E0 File Offset: 0x000308E0
		[CallerCount(0)]
		public unsafe void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minBrickSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_SetTRS_Internal_Void_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0003273C File Offset: 0x0003093C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968038, XrefRangeEnd = 968042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxSubdivision(int maxSubdivision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxSubdivision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_SetMaxSubdivision_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0003277C File Offset: 0x0003097C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 968043, RefRangeEnd = 968044, XrefRangeStart = 968042, XrefRangeEnd = 968043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CellSize(int subdivisionLevel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subdivisionLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_CellSize_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000327BC File Offset: 0x000309BC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 968048, RefRangeEnd = 968060, XrefRangeStart = 968044, XrefRangeEnd = 968048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float BrickSize(int subdivisionLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subdivisionLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_BrickSize_Internal_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00032808 File Offset: 0x00030A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MinBrickSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_MinBrickSize_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00032844 File Offset: 0x00030A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968060, XrefRangeEnd = 968061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MaxBrickSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_MaxBrickSize_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00032880 File Offset: 0x00030A80
		[CallerCount(0)]
		public unsafe ProbeReferenceVolume.RefVolTransform GetTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetTransform_Internal_RefVolTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000328BC File Offset: 0x00030ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMaxSubdivision()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000328F8 File Offset: 0x00030AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968061, XrefRangeEnd = 968065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMaxSubdivision(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00032944 File Offset: 0x00030B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968065, XrefRangeEnd = 968066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDistanceBetweenProbes(int subdivisionLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subdivisionLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetDistanceBetweenProbes_Internal_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00032990 File Offset: 0x00030B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968066, XrefRangeEnd = 968067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MinDistanceBetweenProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_MinDistanceBetweenProbes_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000329CC File Offset: 0x00030BCC
		[CallerCount(0)]
		public unsafe bool DataHasBeenLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_DataHasBeenLoaded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00032A08 File Offset: 0x00030C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968067, XrefRangeEnd = 968083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00032A3C File Offset: 0x00030C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 968090, RefRangeEnd = 968092, XrefRangeStart = 968083, XrefRangeEnd = 968090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, ProbeBrickPool.DataLocation dataLoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataLoc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_GetSourceLocations_Private_List_1_BrickChunkAlloc_Int32_Int32_DataLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr3) : null;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00032AB0 File Offset: 0x00030CB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 968155, RefRangeEnd = 968159, XrefRangeStart = 968092, XrefRangeEnd = 968155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePool(List<ProbeBrickPool.BrickChunkAlloc> chunkList, ProbeReferenceVolume.Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex, int poolIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunkList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(validityNeighMaskData));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UpdatePool_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00032B3C File Offset: 0x00030D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 968178, RefRangeEnd = 968179, XrefRangeStart = 968159, XrefRangeEnd = 968178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePoolValidity(List<ProbeBrickPool.BrickChunkAlloc> chunkList, ProbeReferenceVolume.Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunkList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(validityNeighMaskData));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UpdatePoolValidity_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00032BBC File Offset: 0x00030DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 968217, RefRangeEnd = 968219, XrefRangeStart = 968179, XrefRangeEnd = 968217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddBlendingBricks(ProbeReferenceVolume.BlendingCellInfo blendingCell)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendingCell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_AddBlendingBricks_Private_Boolean_BlendingCellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00032C0C File Offset: 0x00030E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968219, XrefRangeEnd = 968249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddBricks(ProbeReferenceVolume.CellInfo cellInfo, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellUpdateInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrorLog;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_AddBricks_Private_Boolean_CellInfo_CellIndexUpdateInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00032C78 File Offset: 0x00030E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 968251, RefRangeEnd = 968253, XrefRangeStart = 968249, XrefRangeEnd = 968251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCellIndex(ProbeReferenceVolume.CellInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UpdateCellIndex_Private_Void_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00032CBC File Offset: 0x00030EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968253, XrefRangeEnd = 968259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseBricks(ProbeReferenceVolume.CellInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ReleaseBricks_Private_Void_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00032D00 File Offset: 0x00030F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968259, XrefRangeEnd = 968269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UpdateConstantBuffer_Public_Void_CommandBuffer_ProbeVolumeShadingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00032D50 File Offset: 0x00030F50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 968288, RefRangeEnd = 968291, XrefRangeStart = 968269, XrefRangeEnd = 968288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupLoadedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_CleanupLoadedData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00032D84 File Offset: 0x00030F84
		public unsafe ProbeVolumeDebug probeVolumeDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_probeVolumeDebug_Internal_get_ProbeVolumeDebug_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProbeVolumeDebug>(intPtr3) : null;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00032DC4 File Offset: 0x00030FC4
		public unsafe Il2CppStructArray<Color> subdivisionDebugColors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_get_subdivisionDebugColors_Public_get_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00032E04 File Offset: 0x00031004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968291, XrefRangeEnd = 968294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderDebug(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00032E48 File Offset: 0x00031048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 968306, RefRangeEnd = 968307, XrefRangeStart = 968294, XrefRangeEnd = 968306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDebug([In] ref ProbeVolumeSystemParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_InitializeDebug_Private_Void_byref_ProbeVolumeSystemParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00032E8C File Offset: 0x0003108C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968307, XrefRangeEnd = 968323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupDebug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_CleanupDebug_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00032EC0 File Offset: 0x000310C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968323, XrefRangeEnd = 968324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.MethodInfoStoreGeneric_DebugCellIndexChanged_Private_Void_Field_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00032F4C File Offset: 0x0003114C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 969142, RefRangeEnd = 969144, XrefRangeStart = 968324, XrefRangeEnd = 969142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDebug(ProbeVolumeSystemParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_RegisterDebug_Private_Void_ProbeVolumeSystemParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00032F94 File Offset: 0x00031194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969163, RefRangeEnd = 969164, XrefRangeStart = 969144, XrefRangeEnd = 969163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDebug(bool destroyPanel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref destroyPanel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UnregisterDebug_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00032FD4 File Offset: 0x000311D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969180, RefRangeEnd = 969181, XrefRangeStart = 969164, XrefRangeEnd = 969180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Il2CppStructArray<Plane> frustumPlanes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cellPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frustumPlanes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Transform_Il2CppStructArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00033044 File Offset: 0x00031244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969293, RefRangeEnd = 969294, XrefRangeStart = 969181, XrefRangeEnd = 969293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawProbeDebug(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_DrawProbeDebug_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00033088 File Offset: 0x00031288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969294, XrefRangeEnd = 969301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetDebugViewToMaxSubdiv()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ResetDebugViewToMaxSubdiv_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000330BC File Offset: 0x000312BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969305, RefRangeEnd = 969306, XrefRangeStart = 969301, XrefRangeEnd = 969305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDebugData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ClearDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000330F0 File Offset: 0x000312F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969421, RefRangeEnd = 969422, XrefRangeStart = 969306, XrefRangeEnd = 969421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeReferenceVolume.CellInstancedDebugProbes CreateInstancedProbes(ProbeReferenceVolume.CellInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_CreateInstancedProbes_Private_CellInstancedDebugProbes_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.CellInstancedDebugProbes>(intPtr3) : null;
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00033140 File Offset: 0x00031340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969305, RefRangeEnd = 969306, XrefRangeStart = 969305, XrefRangeEnd = 969306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClearLightingdata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_OnClearLightingdata_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00033174 File Offset: 0x00031374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969442, RefRangeEnd = 969443, XrefRangeStart = 969422, XrefRangeEnd = 969442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScenarioBlendingChanged(bool scenarioChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scenarioChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ScenarioBlendingChanged_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000331B4 File Offset: 0x000313B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969443, RefRangeEnd = 969444, XrefRangeStart = 969443, XrefRangeEnd = 969443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNumberOfCellsLoadedPerFrame(int numberOfCells)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numberOfCells;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_SetNumberOfCellsLoadedPerFrame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000331F4 File Offset: 0x000313F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 969454, RefRangeEnd = 969456, XrefRangeStart = 969444, XrefRangeEnd = 969454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeCellCameraDistance(Vector3 cameraPosition, DynamicArray<ProbeReferenceVolume.CellInfo> cells)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cameraPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cells);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ComputeCellCameraDistance_Private_Void_Vector3_DynamicArray_1_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00033244 File Offset: 0x00031444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 969464, RefRangeEnd = 969466, XrefRangeStart = 969456, XrefRangeEnd = 969464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeStreamingScoreForBlending(DynamicArray<ProbeReferenceVolume.BlendingCellInfo> cells, float worstScore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cells);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worstScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_ComputeStreamingScoreForBlending_Private_Void_DynamicArray_1_BlendingCellInfo_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00033294 File Offset: 0x00031494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969466, XrefRangeEnd = 969470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryLoadCell(ProbeReferenceVolume.CellInfo cellInfo, ref int shBudget, ref int indexBudget, DynamicArray<ProbeReferenceVolume.CellInfo> loadedCells)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shBudget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexBudget;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedCells);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_TryLoadCell_Private_Boolean_CellInfo_byref_Int32_byref_Int32_DynamicArray_1_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00033310 File Offset: 0x00031510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969470, XrefRangeEnd = 969474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell, DynamicArray<ProbeReferenceVolume.BlendingCellInfo> unloadedCells)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendingCell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unloadedCells);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UnloadBlendingCell_Private_Void_BlendingCellInfo_DynamicArray_1_BlendingCellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00033364 File Offset: 0x00031564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969478, RefRangeEnd = 969479, XrefRangeStart = 969474, XrefRangeEnd = 969478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryLoadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell, DynamicArray<ProbeReferenceVolume.BlendingCellInfo> loadedCells)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendingCell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedCells);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_TryLoadBlendingCell_Private_Boolean_BlendingCellInfo_DynamicArray_1_BlendingCellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000333C4 File Offset: 0x000315C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969479, XrefRangeEnd = 969545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCellStreaming(CommandBuffer cmd, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00033418 File Offset: 0x00031618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969553, RefRangeEnd = 969554, XrefRangeStart = 969545, XrefRangeEnd = 969553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindWorstBlendingCellToBeLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_FindWorstBlendingCellToBeLoaded_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00033454 File Offset: 0x00031654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969631, RefRangeEnd = 969632, XrefRangeStart = 969554, XrefRangeEnd = 969631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlendingCellStreaming(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.NativeMethodInfoPtr_UpdateBlendingCellStreaming_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00005DC9 File Offset: 0x00003FC9
		public ProbeReferenceVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00033498 File Offset: 0x00031698
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public unsafe bool m_IsInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_IsInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_IsInitialized)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000334C0 File Offset: 0x000316C0
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00005DED File Offset: 0x00003FED
		public unsafe bool m_SupportStreaming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_SupportStreaming);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_SupportStreaming)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000334E8 File Offset: 0x000316E8
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00005E08 File Offset: 0x00004008
		public unsafe ProbeReferenceVolume.RefVolTransform m_Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_Transform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_Transform)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00033510 File Offset: 0x00031710
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00005E23 File Offset: 0x00004023
		public unsafe int m_MaxSubdivision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_MaxSubdivision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_MaxSubdivision)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00033538 File Offset: 0x00031738
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00005E3E File Offset: 0x0000403E
		public unsafe ProbeBrickPool m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeBrickPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00033568 File Offset: 0x00031768
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00005E5D File Offset: 0x0000405D
		public unsafe ProbeBrickIndex m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_Index);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeBrickIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_Index), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00033598 File Offset: 0x00031798
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00005E7C File Offset: 0x0000407C
		public unsafe ProbeCellIndices m_CellIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CellIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeCellIndices>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CellIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x000335C8 File Offset: 0x000317C8
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00005E9B File Offset: 0x0000409B
		public unsafe ProbeBrickBlendingPool m_BlendingPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeBrickBlendingPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000335F8 File Offset: 0x000317F8
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00005EBA File Offset: 0x000040BA
		public unsafe List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TmpSrcChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TmpSrcChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00033628 File Offset: 0x00031828
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00005ED9 File Offset: 0x000040D9
		public unsafe Il2CppStructArray<float> m_PositionOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PositionOffsets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PositionOffsets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00033658 File Offset: 0x00031858
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00005EF8 File Offset: 0x000040F8
		public unsafe Bounds m_CurrGlobalBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CurrGlobalBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CurrGlobalBounds)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00033680 File Offset: 0x00031880
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00005F13 File Offset: 0x00004113
		public unsafe Dictionary<int, ProbeReferenceVolume.CellInfo> cells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_cells);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ProbeReferenceVolume.CellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_cells), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000336B0 File Offset: 0x000318B0
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00005F32 File Offset: 0x00004132
		public unsafe ObjectPool<ProbeReferenceVolume.CellInfo> m_CellInfoPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CellInfoPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<ProbeReferenceVolume.CellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CellInfoPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000336E0 File Offset: 0x000318E0
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00005F51 File Offset: 0x00004151
		public unsafe ObjectPool<ProbeReferenceVolume.BlendingCellInfo> m_BlendingCellInfoPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingCellInfoPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<ProbeReferenceVolume.BlendingCellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingCellInfoPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00033710 File Offset: 0x00031910
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00005F70 File Offset: 0x00004170
		public ProbeBrickPool.DataLocation m_TemporaryDataLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TemporaryDataLocation);
				return new ProbeBrickPool.DataLocation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TemporaryDataLocation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00033740 File Offset: 0x00031940
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00005F9E File Offset: 0x0000419E
		public unsafe int m_TemporaryDataLocationMemCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TemporaryDataLocationMemCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TemporaryDataLocationMemCost)) = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00033768 File Offset: 0x00031968
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00005FB9 File Offset: 0x000041B9
		public unsafe int m_CurrentProbeVolumeChunkSizeInBricks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CurrentProbeVolumeChunkSizeInBricks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CurrentProbeVolumeChunkSizeInBricks)) = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00033790 File Offset: 0x00031990
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00005FD4 File Offset: 0x000041D4
		public unsafe ProbeVolumeSceneData sceneData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_sceneData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_sceneData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x000337C0 File Offset: 0x000319C0
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00005FF3 File Offset: 0x000041F3
		public unsafe Vector3Int minLoadedCellPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_minLoadedCellPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_minLoadedCellPos)) = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000337E8 File Offset: 0x000319E8
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x0000600E File Offset: 0x0000420E
		public unsafe Vector3Int maxLoadedCellPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_maxLoadedCellPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_maxLoadedCellPos)) = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00033810 File Offset: 0x00031A10
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00006029 File Offset: 0x00004229
		public unsafe Action<ProbeReferenceVolume.ExtraDataActionInput> retrieveExtraDataAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_retrieveExtraDataAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProbeReferenceVolume.ExtraDataActionInput>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_retrieveExtraDataAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00033840 File Offset: 0x00031A40
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00006048 File Offset: 0x00004248
		public unsafe Action checksDuringBakeAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_checksDuringBakeAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_checksDuringBakeAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00033870 File Offset: 0x00031A70
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00006067 File Offset: 0x00004267
		public unsafe bool m_BricksLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BricksLoaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BricksLoaded)) = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00033898 File Offset: 0x00031A98
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00006082 File Offset: 0x00004282
		public unsafe Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingAssetsToBeLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProbeVolumeAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingAssetsToBeLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000338C8 File Offset: 0x00031AC8
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x000060A1 File Offset: 0x000042A1
		public unsafe Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingAssetsToBeUnloaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProbeVolumeAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingAssetsToBeUnloaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x000338F8 File Offset: 0x00031AF8
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x000060C0 File Offset: 0x000042C0
		public unsafe Dictionary<string, ProbeVolumeAsset> m_ActiveAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ActiveAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProbeVolumeAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ActiveAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00033928 File Offset: 0x00031B28
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x000060DF File Offset: 0x000042DF
		public unsafe bool m_NeedLoadAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NeedLoadAsset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NeedLoadAsset)) = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00033950 File Offset: 0x00031B50
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x000060FA File Offset: 0x000042FA
		public unsafe bool m_ProbeReferenceVolumeInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ProbeReferenceVolumeInit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ProbeReferenceVolumeInit)) = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00033978 File Offset: 0x00031B78
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00006115 File Offset: 0x00004315
		public unsafe bool m_EnabledBySRP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_EnabledBySRP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_EnabledBySRP)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000339A0 File Offset: 0x00031BA0
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00006130 File Offset: 0x00004330
		public unsafe ProbeReferenceVolume.InitInfo m_PendingInitInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingInitInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_PendingInitInfo)) = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000339C8 File Offset: 0x00031BC8
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x0000614B File Offset: 0x0000434B
		public unsafe bool m_NeedsIndexRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NeedsIndexRebuild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NeedsIndexRebuild)) = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000339F0 File Offset: 0x00031BF0
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00006166 File Offset: 0x00004366
		public unsafe bool m_HasChangedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_HasChangedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_HasChangedIndex)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00033A18 File Offset: 0x00031C18
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00006181 File Offset: 0x00004381
		public unsafe int m_CBShaderID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CBShaderID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_CBShaderID)) = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00033A40 File Offset: 0x00031C40
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0000619C File Offset: 0x0000439C
		public unsafe int m_NumberOfCellsLoadedPerFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00033A68 File Offset: 0x00031C68
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x000061B7 File Offset: 0x000043B7
		public unsafe int m_NumberOfCellsBlendedPerFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame)) = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00033A90 File Offset: 0x00031C90
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x000061D2 File Offset: 0x000043D2
		public unsafe float m_TurnoverRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TurnoverRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TurnoverRate)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00033AB8 File Offset: 0x00031CB8
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x000061ED File Offset: 0x000043ED
		public unsafe ProbeVolumeTextureMemoryBudget m_MemoryBudget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_MemoryBudget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_MemoryBudget)) = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00033AE0 File Offset: 0x00031CE0
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00006208 File Offset: 0x00004408
		public unsafe ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingMemoryBudget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_BlendingMemoryBudget)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00033B08 File Offset: 0x00031D08
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00006223 File Offset: 0x00004423
		public unsafe ProbeVolumeSHBands m_SHBands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_SHBands);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_SHBands)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00033B30 File Offset: 0x00031D30
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0000623E File Offset: 0x0000443E
		public unsafe float m_ProbeVolumesWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ProbeVolumesWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ProbeVolumesWeight)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00033B58 File Offset: 0x00031D58
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00006259 File Offset: 0x00004459
		public unsafe bool clearAssetsOnVolumeClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_clearAssetsOnVolumeClear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_clearAssetsOnVolumeClear)) = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00033B80 File Offset: 0x00031D80
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00006274 File Offset: 0x00004474
		public unsafe static string defaultLightingScenario
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.NativeFieldInfoPtr_defaultLightingScenario, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.NativeFieldInfoPtr_defaultLightingScenario, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00033BA0 File Offset: 0x00031DA0
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00006286 File Offset: 0x00004486
		public unsafe static ProbeReferenceVolume _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00033BC8 File Offset: 0x00031DC8
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00006298 File Offset: 0x00004498
		public unsafe List<ProbeVolumePerSceneData> _perSceneDataList_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr__perSceneDataList_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumePerSceneData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr__perSceneDataList_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00033BF8 File Offset: 0x00031DF8
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000062B7 File Offset: 0x000044B7
		public unsafe static int kProbesPerBatch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.NativeFieldInfoPtr_kProbesPerBatch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.NativeFieldInfoPtr_kProbesPerBatch, (void*)(&value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00033C14 File Offset: 0x00031E14
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000062C5 File Offset: 0x000044C5
		public unsafe static string k_DebugPanelName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.NativeFieldInfoPtr_k_DebugPanelName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.NativeFieldInfoPtr_k_DebugPanelName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00033C34 File Offset: 0x00031E34
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x000062D7 File Offset: 0x000044D7
		public unsafe ProbeVolumeDebug _probeVolumeDebug_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr__probeVolumeDebug_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeVolumeDebug>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr__probeVolumeDebug_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00033C64 File Offset: 0x00031E64
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x000062F6 File Offset: 0x000044F6
		public unsafe Il2CppStructArray<Color> _subdivisionDebugColors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00033C94 File Offset: 0x00031E94
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00006315 File Offset: 0x00004515
		public unsafe Il2CppReferenceArray<DebugUI.Widget> m_DebugItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00033CC4 File Offset: 0x00031EC4
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00006334 File Offset: 0x00004534
		public unsafe Mesh m_DebugMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00033CF4 File Offset: 0x00031EF4
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00006353 File Offset: 0x00004553
		public unsafe Material m_DebugMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00033D24 File Offset: 0x00031F24
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00006372 File Offset: 0x00004572
		public unsafe Mesh m_DebugOffsetMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugOffsetMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugOffsetMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00033D54 File Offset: 0x00031F54
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00006391 File Offset: 0x00004591
		public unsafe Material m_DebugOffsetMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugOffsetMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugOffsetMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00033D84 File Offset: 0x00031F84
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x000063B0 File Offset: 0x000045B0
		public unsafe Il2CppStructArray<Plane> m_DebugFrustumPlanes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugFrustumPlanes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugFrustumPlanes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00033DB4 File Offset: 0x00031FB4
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000063CF File Offset: 0x000045CF
		public unsafe Il2CppReferenceArray<GUIContent> m_DebugScenarioNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00033DE4 File Offset: 0x00031FE4
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x000063EE File Offset: 0x000045EE
		public unsafe Il2CppStructArray<int> m_DebugScenarioValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00033E14 File Offset: 0x00032014
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0000640D File Offset: 0x0000460D
		public unsafe string m_DebugActiveSceneGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugActiveSceneGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugActiveSceneGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00033E3C File Offset: 0x0003203C
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0000642C File Offset: 0x0000462C
		public unsafe string m_DebugActiveScenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugActiveScenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugActiveScenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00033E64 File Offset: 0x00032064
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0000644B File Offset: 0x0000464B
		public unsafe DebugUI.EnumField m_DebugScenarioField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.EnumField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_DebugScenarioField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00033E94 File Offset: 0x00032094
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0000646A File Offset: 0x0000466A
		public unsafe ProbeVolumeBakingProcessSettings bakingProcessSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_bakingProcessSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_bakingProcessSettings)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00033EBC File Offset: 0x000320BC
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00006485 File Offset: 0x00004685
		public unsafe Dictionary<Bounds, Il2CppStructArray<ProbeBrickIndex.Brick>> realtimeSubdivisionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_realtimeSubdivisionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Bounds, Il2CppStructArray<ProbeBrickIndex.Brick>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_realtimeSubdivisionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00033EEC File Offset: 0x000320EC
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x000064A4 File Offset: 0x000046A4
		public unsafe bool m_MaxSubdivVisualizedIsMaxAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00033F14 File Offset: 0x00032114
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x000064BF File Offset: 0x000046BF
		public unsafe DynamicArray<ProbeReferenceVolume.CellInfo> m_LoadedCells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_LoadedCells);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.CellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_LoadedCells), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00033F44 File Offset: 0x00032144
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x000064DE File Offset: 0x000046DE
		public unsafe DynamicArray<ProbeReferenceVolume.CellInfo> m_ToBeLoadedCells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ToBeLoadedCells);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.CellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ToBeLoadedCells), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00033F74 File Offset: 0x00032174
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x000064FD File Offset: 0x000046FD
		public unsafe DynamicArray<ProbeReferenceVolume.CellInfo> m_TempCellToLoadList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempCellToLoadList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.CellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempCellToLoadList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00033FA4 File Offset: 0x000321A4
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0000651C File Offset: 0x0000471C
		public unsafe DynamicArray<ProbeReferenceVolume.CellInfo> m_TempCellToUnloadList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempCellToUnloadList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.CellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempCellToUnloadList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00033FD4 File Offset: 0x000321D4
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0000653B File Offset: 0x0000473B
		public unsafe DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_LoadedBlendingCells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_LoadedBlendingCells);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.BlendingCellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_LoadedBlendingCells), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00034004 File Offset: 0x00032204
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0000655A File Offset: 0x0000475A
		public unsafe DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_ToBeLoadedBlendingCells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ToBeLoadedBlendingCells);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.BlendingCellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_ToBeLoadedBlendingCells), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00034034 File Offset: 0x00032234
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00006579 File Offset: 0x00004779
		public unsafe DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToLoadList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempBlendingCellToLoadList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.BlendingCellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempBlendingCellToLoadList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00034064 File Offset: 0x00032264
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00006598 File Offset: 0x00004798
		public unsafe DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToUnloadList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempBlendingCellToUnloadList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<ProbeReferenceVolume.BlendingCellInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_TempBlendingCellToUnloadList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00034094 File Offset: 0x00032294
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x000065B7 File Offset: 0x000047B7
		public unsafe Vector3 m_FrozenCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_FrozenCameraPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_FrozenCameraPosition)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000340BC File Offset: 0x000322BC
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000065D2 File Offset: 0x000047D2
		public unsafe bool m_HasRemainingCellsToBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_HasRemainingCellsToBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.NativeFieldInfoPtr_m_HasRemainingCellsToBlend)) = value;
			}
		}

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_m_IsInitialized;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_m_SupportStreaming;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSubdivision;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_m_CellIndices;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendingPool;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_m_TmpSrcChunks;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionOffsets;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrGlobalBounds;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_cells;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_m_CellInfoPool;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendingCellInfoPool;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_m_TemporaryDataLocation;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_m_TemporaryDataLocationMemCost;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentProbeVolumeChunkSizeInBricks;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_sceneData;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_minLoadedCellPos;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_maxLoadedCellPos;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_retrieveExtraDataAction;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_checksDuringBakeAction;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_m_BricksLoaded;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingAssetsToBeLoaded;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingAssetsToBeUnloaded;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveAssets;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedLoadAsset;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_m_ProbeReferenceVolumeInit;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_m_EnabledBySRP;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingInitInfo;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsIndexRebuild;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_m_HasChangedIndex;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_m_CBShaderID;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_m_TurnoverRate;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_m_MemoryBudget;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendingMemoryBudget;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_m_SHBands;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_m_ProbeVolumesWeight;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_clearAssetsOnVolumeClear;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_defaultLightingScenario;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr__perSceneDataList_k__BackingField;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_kProbesPerBatch;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugPanelName;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr__probeVolumeDebug_k__BackingField;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugItems;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugMesh;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugMaterial;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugOffsetMesh;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugOffsetMaterial;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugFrustumPlanes;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugScenarioNames;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugScenarioValues;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugActiveSceneGUID;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugActiveScenario;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugScenarioField;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_bakingProcessSettings;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_realtimeSubdivisionInfo;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedCells;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_m_ToBeLoadedCells;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_m_TempCellToLoadList;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr_m_TempCellToUnloadList;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedBlendingCells;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_m_ToBeLoadedBlendingCells;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_m_TempBlendingCellToLoadList;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeFieldInfoPtr_m_TempBlendingCellToUnloadList;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_m_FrozenCameraPosition;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeFieldInfoPtr_m_HasRemainingCellsToBlend;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_get_globalBounds_Internal_get_Bounds_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_set_globalBounds_Internal_set_Void_Bounds_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_get_enabledBySRP_Internal_get_Boolean_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_get_hasUnloadedCells_Internal_get_Boolean_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_get_enableScenarioBlending_Internal_get_Boolean_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_get_numberOfCellsLoadedPerFrame_Internal_get_Int32_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_get_numberOfCellsBlendedPerFrame_Public_get_Int32_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_set_numberOfCellsBlendedPerFrame_Public_set_Void_Int32_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_get_turnoverRate_Public_get_Single_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_set_turnoverRate_Public_set_Void_Single_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_get_shBands_Public_get_ProbeVolumeSHBands_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_get_lightingScenario_Public_get_String_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_set_lightingScenario_Public_set_Void_String_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_get_scenarioBlendingFactor_Public_get_Single_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_set_scenarioBlendingFactor_Public_set_Void_Single_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_BlendLightingScenario_Public_Void_String_Single_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_get_memoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_get_probeVolumesWeight_Public_get_Single_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_set_probeVolumesWeight_Public_set_Void_Single_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_get_perSceneDataList_Internal_get_List_1_ProbeVolumePerSceneData_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_set_perSceneDataList_Private_set_Void_List_1_ProbeVolumePerSceneData_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ProbeReferenceVolume_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_byref_ProbeVolumeSystemParameters_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_SetEnableStateFromSRP_Public_Void_Boolean_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_ForceSHBand_Internal_Void_ProbeVolumeSHBands_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_GetVideoMemoryCost_Public_Int32_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCell_Private_Void_Cell_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_UnloadCell_Internal_Void_CellInfo_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_UnloadBlendingCell_Internal_Void_BlendingCellInfo_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAllCells_Internal_Void_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAllBlendingCells_Internal_Void_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_AddCell_Private_Void_Cell_Int32_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_LoadCell_Internal_Boolean_CellInfo_Boolean_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllCells_Internal_Void_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeMinMaxLoadedCellPos_Private_Void_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_CheckCompatibilityWithCollection_Private_Boolean_ProbeVolumeAsset_Dictionary_2_String_ProbeVolumeAsset_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_AddPendingAssetLoading_Internal_Void_ProbeVolumeAsset_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_AddPendingAssetRemoval_Internal_Void_ProbeVolumeAsset_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_RemovePendingAsset_Internal_Void_ProbeVolumeAsset_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_PerformPendingIndexChangeAndInit_Private_Void_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_SetMinBrickAndMaxSubdiv_Internal_Void_Single_Int32_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Private_Void_ProbeVolumeAsset_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_PerformPendingLoading_Private_Void_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_PerformPendingDeletion_Private_Void_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfBricksAtSubdiv_Internal_Int32_Vector3Int_Int32_byref_Vector3Int_byref_Vector3Int_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_GetCellIndexUpdate_Private_Boolean_Cell_byref_CellIndexUpdateInfo_Boolean_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_PerformPendingOperations_Public_Void_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_InitProbeReferenceVolume_Private_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_AllocateTemporaryDataLocation_Private_Void_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeResources_Public_RuntimeResources_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_SetTRS_Internal_Void_Vector3_Quaternion_Single_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxSubdivision_Internal_Void_Int32_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_CellSize_Internal_Static_Int32_Int32_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_BrickSize_Internal_Single_Int32_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_MinBrickSize_Internal_Single_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_MaxBrickSize_Internal_Single_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_GetTransform_Internal_RefVolTransform_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_Single_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceBetweenProbes_Internal_Single_Int32_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_MinDistanceBetweenProbes_Internal_Single_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_DataHasBeenLoaded_Public_Boolean_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceLocations_Private_List_1_BrickChunkAlloc_Int32_Int32_DataLocation_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePool_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_Int32_Int32_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePoolValidity_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_Int32_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_AddBlendingBricks_Private_Boolean_BlendingCellInfo_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_AddBricks_Private_Boolean_CellInfo_CellIndexUpdateInfo_Boolean_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCellIndex_Private_Void_CellInfo_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBricks_Private_Void_CellInfo_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConstantBuffer_Public_Void_CommandBuffer_ProbeVolumeShadingParameters_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_CleanupLoadedData_Private_Void_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_probeVolumeDebug_Internal_get_ProbeVolumeDebug_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_get_subdivisionDebugColors_Public_get_Il2CppStructArray_1_Color_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDebug_Private_Void_byref_ProbeVolumeSystemParameters_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_CleanupDebug_Private_Void_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_DebugCellIndexChanged_Private_Void_Field_1_T_T_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDebug_Private_Void_ProbeVolumeSystemParameters_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDebug_Private_Void_Boolean_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Transform_Il2CppStructArray_1_Plane_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_DrawProbeDebug_Private_Void_Camera_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_ResetDebugViewToMaxSubdiv_Internal_Void_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_ClearDebugData_Private_Void_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstancedProbes_Private_CellInstancedDebugProbes_CellInfo_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_OnClearLightingdata_Private_Void_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_ScenarioBlendingChanged_Internal_Void_Boolean_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_SetNumberOfCellsLoadedPerFrame_Public_Void_Int32_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_ComputeCellCameraDistance_Private_Void_Vector3_DynamicArray_1_CellInfo_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStreamingScoreForBlending_Private_Void_DynamicArray_1_BlendingCellInfo_Single_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadCell_Private_Boolean_CellInfo_byref_Int32_byref_Int32_DynamicArray_1_CellInfo_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_UnloadBlendingCell_Private_Void_BlendingCellInfo_DynamicArray_1_BlendingCellInfo_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadBlendingCell_Private_Boolean_BlendingCellInfo_DynamicArray_1_BlendingCellInfo_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_FindWorstBlendingCellToBeLoaded_Private_Int32_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlendingCellStreaming_Private_Void_CommandBuffer_0;

		// Token: 0x020001C4 RID: 452
		[Serializable]
		public class Cell : Object
		{
			// Token: 0x060018B8 RID: 6328 RVA: 0x00068554 File Offset: 0x00066754
			// Note: this type is marked as 'beforefieldinit'.
			static Cell()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "Cell");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr);
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "position");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "index");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_probeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "probeCount");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_minSubdiv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "minSubdiv");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_maxSubdiv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "maxSubdiv");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_indexChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "indexChunkCount");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_shChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "shChunkCount");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_hasTwoScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "hasTwoScenarios");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_shBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "shBands");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr__bricks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "<bricks>k__BackingField");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr__validityNeighMaskData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "<validityNeighMaskData>k__BackingField");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr__probePositions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "<probePositions>k__BackingField");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "<touchupVolumeInteraction>k__BackingField");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr__offsetVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "<offsetVectors>k__BackingField");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr__validity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "<validity>k__BackingField");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_scenario0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "scenario0");
				ProbeReferenceVolume.Cell.NativeFieldInfoPtr_scenario1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "scenario1");
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_bricks_Public_get_NativeArray_1_Brick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664845);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_bricks_Internal_set_Void_NativeArray_1_Brick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664846);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_validityNeighMaskData_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664847);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_validityNeighMaskData_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664848);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_probePositions_Public_get_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664849);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_probePositions_Internal_set_Void_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664850);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_touchupVolumeInteraction_Public_get_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664851);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_touchupVolumeInteraction_Internal_set_Void_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664852);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_offsetVectors_Public_get_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664853);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_offsetVectors_Internal_set_Void_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664854);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_validity_Public_get_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664855);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_validity_Internal_set_Void_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664856);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_bakingScenario_Public_get_PerScenarioData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664857);
				ProbeReferenceVolume.Cell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, 100664858);
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x060018B9 RID: 6329 RVA: 0x000687EC File Offset: 0x000669EC
			// (set) Token: 0x060018BA RID: 6330 RVA: 0x00068824 File Offset: 0x00066A24
			public unsafe NativeArray<ProbeBrickIndex.Brick> bricks
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_bricks_Public_get_NativeArray_1_Brick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new NativeArray<ProbeBrickIndex.Brick>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_bricks_Internal_set_Void_NativeArray_1_Brick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x060018BB RID: 6331 RVA: 0x0006886C File Offset: 0x00066A6C
			// (set) Token: 0x060018BC RID: 6332 RVA: 0x000688A4 File Offset: 0x00066AA4
			public unsafe NativeArray<byte> validityNeighMaskData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_validityNeighMaskData_Public_get_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new NativeArray<byte>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_validityNeighMaskData_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x060018BD RID: 6333 RVA: 0x000688EC File Offset: 0x00066AEC
			// (set) Token: 0x060018BE RID: 6334 RVA: 0x00068924 File Offset: 0x00066B24
			public unsafe NativeArray<Vector3> probePositions
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_probePositions_Public_get_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new NativeArray<Vector3>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_probePositions_Internal_set_Void_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x060018BF RID: 6335 RVA: 0x0006896C File Offset: 0x00066B6C
			// (set) Token: 0x060018C0 RID: 6336 RVA: 0x000689A4 File Offset: 0x00066BA4
			public unsafe NativeArray<float> touchupVolumeInteraction
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_touchupVolumeInteraction_Public_get_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new NativeArray<float>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_touchupVolumeInteraction_Internal_set_Void_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x060018C1 RID: 6337 RVA: 0x000689EC File Offset: 0x00066BEC
			// (set) Token: 0x060018C2 RID: 6338 RVA: 0x00068A24 File Offset: 0x00066C24
			public unsafe NativeArray<Vector3> offsetVectors
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_offsetVectors_Public_get_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new NativeArray<Vector3>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_offsetVectors_Internal_set_Void_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00068A6C File Offset: 0x00066C6C
			// (set) Token: 0x060018C4 RID: 6340 RVA: 0x00068AA4 File Offset: 0x00066CA4
			public unsafe NativeArray<float> validity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_validity_Public_get_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new NativeArray<float>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_set_validity_Internal_set_Void_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x060018C5 RID: 6341 RVA: 0x00068AEC File Offset: 0x00066CEC
			public unsafe ProbeReferenceVolume.Cell.PerScenarioData bakingScenario
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr_get_bakingScenario_Public_get_PerScenarioData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ProbeReferenceVolume.Cell.PerScenarioData(intPtr);
				}
			}

			// Token: 0x060018C6 RID: 6342 RVA: 0x00068B24 File Offset: 0x00066D24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cell()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018C7 RID: 6343 RVA: 0x0000C4D5 File Offset: 0x0000A6D5
			public Cell(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00068B60 File Offset: 0x00066D60
			// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0000C4DE File Offset: 0x0000A6DE
			public unsafe Vector3Int position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x060018CA RID: 6346 RVA: 0x00068B88 File Offset: 0x00066D88
			// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000C4F9 File Offset: 0x0000A6F9
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x060018CC RID: 6348 RVA: 0x00068BB0 File Offset: 0x00066DB0
			// (set) Token: 0x060018CD RID: 6349 RVA: 0x0000C514 File Offset: 0x0000A714
			public unsafe int probeCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_probeCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_probeCount)) = value;
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x060018CE RID: 6350 RVA: 0x00068BD8 File Offset: 0x00066DD8
			// (set) Token: 0x060018CF RID: 6351 RVA: 0x0000C52F File Offset: 0x0000A72F
			public unsafe int minSubdiv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_minSubdiv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_minSubdiv)) = value;
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00068C00 File Offset: 0x00066E00
			// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0000C54A File Offset: 0x0000A74A
			public unsafe int maxSubdiv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_maxSubdiv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_maxSubdiv)) = value;
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00068C28 File Offset: 0x00066E28
			// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0000C565 File Offset: 0x0000A765
			public unsafe int indexChunkCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_indexChunkCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_indexChunkCount)) = value;
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00068C50 File Offset: 0x00066E50
			// (set) Token: 0x060018D5 RID: 6357 RVA: 0x0000C580 File Offset: 0x0000A780
			public unsafe int shChunkCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_shChunkCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_shChunkCount)) = value;
				}
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00068C78 File Offset: 0x00066E78
			// (set) Token: 0x060018D7 RID: 6359 RVA: 0x0000C59B File Offset: 0x0000A79B
			public unsafe bool hasTwoScenarios
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_hasTwoScenarios);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_hasTwoScenarios)) = value;
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00068CA0 File Offset: 0x00066EA0
			// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0000C5B6 File Offset: 0x0000A7B6
			public unsafe ProbeVolumeSHBands shBands
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_shBands);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_shBands)) = value;
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x060018DA RID: 6362 RVA: 0x00068CC8 File Offset: 0x00066EC8
			// (set) Token: 0x060018DB RID: 6363 RVA: 0x0000C5D1 File Offset: 0x0000A7D1
			public NativeArray<ProbeBrickIndex.Brick> _bricks_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__bricks_k__BackingField);
					return new NativeArray<ProbeBrickIndex.Brick>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ProbeBrickIndex.Brick>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__bricks_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ProbeBrickIndex.Brick>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x060018DC RID: 6364 RVA: 0x00068CF8 File Offset: 0x00066EF8
			// (set) Token: 0x060018DD RID: 6365 RVA: 0x0000C5FF File Offset: 0x0000A7FF
			public NativeArray<byte> _validityNeighMaskData_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__validityNeighMaskData_k__BackingField);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__validityNeighMaskData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x060018DE RID: 6366 RVA: 0x00068D28 File Offset: 0x00066F28
			// (set) Token: 0x060018DF RID: 6367 RVA: 0x0000C62D File Offset: 0x0000A82D
			public NativeArray<Vector3> _probePositions_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__probePositions_k__BackingField);
					return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__probePositions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00068D58 File Offset: 0x00066F58
			// (set) Token: 0x060018E1 RID: 6369 RVA: 0x0000C65B File Offset: 0x0000A85B
			public NativeArray<float> _touchupVolumeInteraction_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField);
					return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00068D88 File Offset: 0x00066F88
			// (set) Token: 0x060018E3 RID: 6371 RVA: 0x0000C689 File Offset: 0x0000A889
			public NativeArray<Vector3> _offsetVectors_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__offsetVectors_k__BackingField);
					return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__offsetVectors_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00068DB8 File Offset: 0x00066FB8
			// (set) Token: 0x060018E5 RID: 6373 RVA: 0x0000C6B7 File Offset: 0x0000A8B7
			public NativeArray<float> _validity_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__validity_k__BackingField);
					return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr__validity_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00068DE8 File Offset: 0x00066FE8
			// (set) Token: 0x060018E7 RID: 6375 RVA: 0x0000C6E5 File Offset: 0x0000A8E5
			public ProbeReferenceVolume.Cell.PerScenarioData scenario0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_scenario0);
					return new ProbeReferenceVolume.Cell.PerScenarioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_scenario0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00068E18 File Offset: 0x00067018
			// (set) Token: 0x060018E9 RID: 6377 RVA: 0x0000C713 File Offset: 0x0000A913
			public ProbeReferenceVolume.Cell.PerScenarioData scenario1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_scenario1);
					return new ProbeReferenceVolume.Cell.PerScenarioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.NativeFieldInfoPtr_scenario1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040011EF RID: 4591
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040011F0 RID: 4592
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040011F1 RID: 4593
			private static readonly IntPtr NativeFieldInfoPtr_probeCount;

			// Token: 0x040011F2 RID: 4594
			private static readonly IntPtr NativeFieldInfoPtr_minSubdiv;

			// Token: 0x040011F3 RID: 4595
			private static readonly IntPtr NativeFieldInfoPtr_maxSubdiv;

			// Token: 0x040011F4 RID: 4596
			private static readonly IntPtr NativeFieldInfoPtr_indexChunkCount;

			// Token: 0x040011F5 RID: 4597
			private static readonly IntPtr NativeFieldInfoPtr_shChunkCount;

			// Token: 0x040011F6 RID: 4598
			private static readonly IntPtr NativeFieldInfoPtr_hasTwoScenarios;

			// Token: 0x040011F7 RID: 4599
			private static readonly IntPtr NativeFieldInfoPtr_shBands;

			// Token: 0x040011F8 RID: 4600
			private static readonly IntPtr NativeFieldInfoPtr__bricks_k__BackingField;

			// Token: 0x040011F9 RID: 4601
			private static readonly IntPtr NativeFieldInfoPtr__validityNeighMaskData_k__BackingField;

			// Token: 0x040011FA RID: 4602
			private static readonly IntPtr NativeFieldInfoPtr__probePositions_k__BackingField;

			// Token: 0x040011FB RID: 4603
			private static readonly IntPtr NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField;

			// Token: 0x040011FC RID: 4604
			private static readonly IntPtr NativeFieldInfoPtr__offsetVectors_k__BackingField;

			// Token: 0x040011FD RID: 4605
			private static readonly IntPtr NativeFieldInfoPtr__validity_k__BackingField;

			// Token: 0x040011FE RID: 4606
			private static readonly IntPtr NativeFieldInfoPtr_scenario0;

			// Token: 0x040011FF RID: 4607
			private static readonly IntPtr NativeFieldInfoPtr_scenario1;

			// Token: 0x04001200 RID: 4608
			private static readonly IntPtr NativeMethodInfoPtr_get_bricks_Public_get_NativeArray_1_Brick_0;

			// Token: 0x04001201 RID: 4609
			private static readonly IntPtr NativeMethodInfoPtr_set_bricks_Internal_set_Void_NativeArray_1_Brick_0;

			// Token: 0x04001202 RID: 4610
			private static readonly IntPtr NativeMethodInfoPtr_get_validityNeighMaskData_Public_get_NativeArray_1_Byte_0;

			// Token: 0x04001203 RID: 4611
			private static readonly IntPtr NativeMethodInfoPtr_set_validityNeighMaskData_Internal_set_Void_NativeArray_1_Byte_0;

			// Token: 0x04001204 RID: 4612
			private static readonly IntPtr NativeMethodInfoPtr_get_probePositions_Public_get_NativeArray_1_Vector3_0;

			// Token: 0x04001205 RID: 4613
			private static readonly IntPtr NativeMethodInfoPtr_set_probePositions_Internal_set_Void_NativeArray_1_Vector3_0;

			// Token: 0x04001206 RID: 4614
			private static readonly IntPtr NativeMethodInfoPtr_get_touchupVolumeInteraction_Public_get_NativeArray_1_Single_0;

			// Token: 0x04001207 RID: 4615
			private static readonly IntPtr NativeMethodInfoPtr_set_touchupVolumeInteraction_Internal_set_Void_NativeArray_1_Single_0;

			// Token: 0x04001208 RID: 4616
			private static readonly IntPtr NativeMethodInfoPtr_get_offsetVectors_Public_get_NativeArray_1_Vector3_0;

			// Token: 0x04001209 RID: 4617
			private static readonly IntPtr NativeMethodInfoPtr_set_offsetVectors_Internal_set_Void_NativeArray_1_Vector3_0;

			// Token: 0x0400120A RID: 4618
			private static readonly IntPtr NativeMethodInfoPtr_get_validity_Public_get_NativeArray_1_Single_0;

			// Token: 0x0400120B RID: 4619
			private static readonly IntPtr NativeMethodInfoPtr_set_validity_Internal_set_Void_NativeArray_1_Single_0;

			// Token: 0x0400120C RID: 4620
			private static readonly IntPtr NativeMethodInfoPtr_get_bakingScenario_Public_get_PerScenarioData_0;

			// Token: 0x0400120D RID: 4621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000236 RID: 566
			public sealed class PerScenarioData : ValueType
			{
				// Token: 0x06001BFC RID: 7164 RVA: 0x00071430 File Offset: 0x0006F630
				// Note: this type is marked as 'beforefieldinit'.
				static PerScenarioData()
				{
					Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume.Cell>.NativeClassPtr, "PerScenarioData");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL0L1RxData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, "<shL0L1RxData>k__BackingField");
					ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL1GL1RyData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, "<shL1GL1RyData>k__BackingField");
					ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL1BL1RzData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, "<shL1BL1RzData>k__BackingField");
					ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_0_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, "<shL2Data_0>k__BackingField");
					ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, "<shL2Data_1>k__BackingField");
					ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, "<shL2Data_2>k__BackingField");
					ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_3_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, "<shL2Data_3>k__BackingField");
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL0L1RxData_Public_get_NativeArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664859);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL0L1RxData_Internal_set_Void_NativeArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664860);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL1GL1RyData_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664861);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL1GL1RyData_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664862);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL1BL1RzData_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664863);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL1BL1RzData_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664864);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_0_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664865);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_0_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664866);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_1_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664867);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_1_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664868);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_2_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664869);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_2_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664870);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_3_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664871);
					ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_3_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr, 100664872);
				}

				// Token: 0x170007E3 RID: 2019
				// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00071600 File Offset: 0x0006F800
				// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0007163C File Offset: 0x0006F83C
				public unsafe NativeArray<ushort> shL0L1RxData
				{
					[CallerCount(11)]
					[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL0L1RxData_Public_get_NativeArray_1_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new NativeArray<ushort>(intPtr);
					}
					[CallerCount(13)]
					[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL0L1RxData_Internal_set_Void_NativeArray_1_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E4 RID: 2020
				// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00071688 File Offset: 0x0006F888
				// (set) Token: 0x06001C00 RID: 7168 RVA: 0x000716C4 File Offset: 0x0006F8C4
				public unsafe NativeArray<byte> shL1GL1RyData
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL1GL1RyData_Public_get_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new NativeArray<byte>(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL1GL1RyData_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E5 RID: 2021
				// (get) Token: 0x06001C01 RID: 7169 RVA: 0x00071710 File Offset: 0x0006F910
				// (set) Token: 0x06001C02 RID: 7170 RVA: 0x0007174C File Offset: 0x0006F94C
				public unsafe NativeArray<byte> shL1BL1RzData
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL1BL1RzData_Public_get_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new NativeArray<byte>(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL1BL1RzData_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E6 RID: 2022
				// (get) Token: 0x06001C03 RID: 7171 RVA: 0x00071798 File Offset: 0x0006F998
				// (set) Token: 0x06001C04 RID: 7172 RVA: 0x000717D4 File Offset: 0x0006F9D4
				public unsafe NativeArray<byte> shL2Data_0
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_0_Public_get_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new NativeArray<byte>(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_0_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E7 RID: 2023
				// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00071820 File Offset: 0x0006FA20
				// (set) Token: 0x06001C06 RID: 7174 RVA: 0x0007185C File Offset: 0x0006FA5C
				public unsafe NativeArray<byte> shL2Data_1
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_1_Public_get_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new NativeArray<byte>(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_1_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E8 RID: 2024
				// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000718A8 File Offset: 0x0006FAA8
				// (set) Token: 0x06001C08 RID: 7176 RVA: 0x000718E4 File Offset: 0x0006FAE4
				public unsafe NativeArray<byte> shL2Data_2
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_2_Public_get_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new NativeArray<byte>(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_2_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x170007E9 RID: 2025
				// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00071930 File Offset: 0x0006FB30
				// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0007196C File Offset: 0x0006FB6C
				public unsafe NativeArray<byte> shL2Data_3
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_get_shL2Data_3_Public_get_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new NativeArray<byte>(intPtr);
					}
					[CallerCount(0)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Cell.PerScenarioData.NativeMethodInfoPtr_set_shL2Data_3_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x06001C0B RID: 7179 RVA: 0x0000E074 File Offset: 0x0000C274
				public PerScenarioData(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001C0C RID: 7180 RVA: 0x0000E07D File Offset: 0x0000C27D
				public PerScenarioData()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.Cell.PerScenarioData>.NativeClassPtr))
				{
				}

				// Token: 0x170007DC RID: 2012
				// (get) Token: 0x06001C0D RID: 7181 RVA: 0x000719B8 File Offset: 0x0006FBB8
				// (set) Token: 0x06001C0E RID: 7182 RVA: 0x0000E08F File Offset: 0x0000C28F
				public NativeArray<ushort> _shL0L1RxData_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL0L1RxData_k__BackingField);
						return new NativeArray<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL0L1RxData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007DD RID: 2013
				// (get) Token: 0x06001C0F RID: 7183 RVA: 0x000719E8 File Offset: 0x0006FBE8
				// (set) Token: 0x06001C10 RID: 7184 RVA: 0x0000E0BD File Offset: 0x0000C2BD
				public NativeArray<byte> _shL1GL1RyData_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL1GL1RyData_k__BackingField);
						return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL1GL1RyData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007DE RID: 2014
				// (get) Token: 0x06001C11 RID: 7185 RVA: 0x00071A18 File Offset: 0x0006FC18
				// (set) Token: 0x06001C12 RID: 7186 RVA: 0x0000E0EB File Offset: 0x0000C2EB
				public NativeArray<byte> _shL1BL1RzData_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL1BL1RzData_k__BackingField);
						return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL1BL1RzData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007DF RID: 2015
				// (get) Token: 0x06001C13 RID: 7187 RVA: 0x00071A48 File Offset: 0x0006FC48
				// (set) Token: 0x06001C14 RID: 7188 RVA: 0x0000E119 File Offset: 0x0000C319
				public NativeArray<byte> _shL2Data_0_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_0_k__BackingField);
						return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_0_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007E0 RID: 2016
				// (get) Token: 0x06001C15 RID: 7189 RVA: 0x00071A78 File Offset: 0x0006FC78
				// (set) Token: 0x06001C16 RID: 7190 RVA: 0x0000E147 File Offset: 0x0000C347
				public NativeArray<byte> _shL2Data_1_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_1_k__BackingField);
						return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_1_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007E1 RID: 2017
				// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00071AA8 File Offset: 0x0006FCA8
				// (set) Token: 0x06001C18 RID: 7192 RVA: 0x0000E175 File Offset: 0x0000C375
				public NativeArray<byte> _shL2Data_2_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_2_k__BackingField);
						return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_2_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007E2 RID: 2018
				// (get) Token: 0x06001C19 RID: 7193 RVA: 0x00071AD8 File Offset: 0x0006FCD8
				// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0000E1A3 File Offset: 0x0000C3A3
				public NativeArray<byte> _shL2Data_3_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_3_k__BackingField);
						return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.Cell.PerScenarioData.NativeFieldInfoPtr__shL2Data_3_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x04001439 RID: 5177
				private static readonly IntPtr NativeFieldInfoPtr__shL0L1RxData_k__BackingField;

				// Token: 0x0400143A RID: 5178
				private static readonly IntPtr NativeFieldInfoPtr__shL1GL1RyData_k__BackingField;

				// Token: 0x0400143B RID: 5179
				private static readonly IntPtr NativeFieldInfoPtr__shL1BL1RzData_k__BackingField;

				// Token: 0x0400143C RID: 5180
				private static readonly IntPtr NativeFieldInfoPtr__shL2Data_0_k__BackingField;

				// Token: 0x0400143D RID: 5181
				private static readonly IntPtr NativeFieldInfoPtr__shL2Data_1_k__BackingField;

				// Token: 0x0400143E RID: 5182
				private static readonly IntPtr NativeFieldInfoPtr__shL2Data_2_k__BackingField;

				// Token: 0x0400143F RID: 5183
				private static readonly IntPtr NativeFieldInfoPtr__shL2Data_3_k__BackingField;

				// Token: 0x04001440 RID: 5184
				private static readonly IntPtr NativeMethodInfoPtr_get_shL0L1RxData_Public_get_NativeArray_1_UInt16_0;

				// Token: 0x04001441 RID: 5185
				private static readonly IntPtr NativeMethodInfoPtr_set_shL0L1RxData_Internal_set_Void_NativeArray_1_UInt16_0;

				// Token: 0x04001442 RID: 5186
				private static readonly IntPtr NativeMethodInfoPtr_get_shL1GL1RyData_Public_get_NativeArray_1_Byte_0;

				// Token: 0x04001443 RID: 5187
				private static readonly IntPtr NativeMethodInfoPtr_set_shL1GL1RyData_Internal_set_Void_NativeArray_1_Byte_0;

				// Token: 0x04001444 RID: 5188
				private static readonly IntPtr NativeMethodInfoPtr_get_shL1BL1RzData_Public_get_NativeArray_1_Byte_0;

				// Token: 0x04001445 RID: 5189
				private static readonly IntPtr NativeMethodInfoPtr_set_shL1BL1RzData_Internal_set_Void_NativeArray_1_Byte_0;

				// Token: 0x04001446 RID: 5190
				private static readonly IntPtr NativeMethodInfoPtr_get_shL2Data_0_Public_get_NativeArray_1_Byte_0;

				// Token: 0x04001447 RID: 5191
				private static readonly IntPtr NativeMethodInfoPtr_set_shL2Data_0_Internal_set_Void_NativeArray_1_Byte_0;

				// Token: 0x04001448 RID: 5192
				private static readonly IntPtr NativeMethodInfoPtr_get_shL2Data_1_Public_get_NativeArray_1_Byte_0;

				// Token: 0x04001449 RID: 5193
				private static readonly IntPtr NativeMethodInfoPtr_set_shL2Data_1_Internal_set_Void_NativeArray_1_Byte_0;

				// Token: 0x0400144A RID: 5194
				private static readonly IntPtr NativeMethodInfoPtr_get_shL2Data_2_Public_get_NativeArray_1_Byte_0;

				// Token: 0x0400144B RID: 5195
				private static readonly IntPtr NativeMethodInfoPtr_set_shL2Data_2_Internal_set_Void_NativeArray_1_Byte_0;

				// Token: 0x0400144C RID: 5196
				private static readonly IntPtr NativeMethodInfoPtr_get_shL2Data_3_Public_get_NativeArray_1_Byte_0;

				// Token: 0x0400144D RID: 5197
				private static readonly IntPtr NativeMethodInfoPtr_set_shL2Data_3_Internal_set_Void_NativeArray_1_Byte_0;
			}
		}

		// Token: 0x020001C5 RID: 453
		public class CellInfo : Object
		{
			// Token: 0x060018EA RID: 6378 RVA: 0x00068E48 File Offset: 0x00067048
			// Note: this type is marked as 'beforefieldinit'.
			static CellInfo()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr);
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_cell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "cell");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_blendingCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "blendingCell");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_chunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "chunkList");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_flatIdxInCellIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "flatIdxInCellIndices");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "loaded");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_updateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "updateInfo");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_indexUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "indexUpdated");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_tempUpdateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "tempUpdateInfo");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_sourceAssetInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "sourceAssetInstanceID");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_streamingScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "streamingScore");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "referenceCount");
				ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_debugProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, "debugProbes");
				ProbeReferenceVolume.CellInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, 100664873);
				ProbeReferenceVolume.CellInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, 100664874);
				ProbeReferenceVolume.CellInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr, 100664875);
			}

			// Token: 0x060018EB RID: 6379 RVA: 0x00068FA0 File Offset: 0x000671A0
			[CallerCount(0)]
			public unsafe virtual int CompareTo(ProbeReferenceVolume.CellInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.CellInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018EC RID: 6380 RVA: 0x00068FF0 File Offset: 0x000671F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966986, XrefRangeEnd = 966991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.CellInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018ED RID: 6381 RVA: 0x00069024 File Offset: 0x00067224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966991, XrefRangeEnd = 966999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CellInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.CellInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.CellInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018EE RID: 6382 RVA: 0x0000C741 File Offset: 0x0000A941
			public CellInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x060018EF RID: 6383 RVA: 0x00069060 File Offset: 0x00067260
			// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0000C74A File Offset: 0x0000A94A
			public unsafe ProbeReferenceVolume.Cell cell
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_cell);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.Cell>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_cell), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00069090 File Offset: 0x00067290
			// (set) Token: 0x060018F2 RID: 6386 RVA: 0x0000C769 File Offset: 0x0000A969
			public unsafe ProbeReferenceVolume.BlendingCellInfo blendingCell
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_blendingCell);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.BlendingCellInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_blendingCell), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x060018F3 RID: 6387 RVA: 0x000690C0 File Offset: 0x000672C0
			// (set) Token: 0x060018F4 RID: 6388 RVA: 0x0000C788 File Offset: 0x0000A988
			public unsafe List<ProbeBrickPool.BrickChunkAlloc> chunkList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_chunkList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_chunkList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x060018F5 RID: 6389 RVA: 0x000690F0 File Offset: 0x000672F0
			// (set) Token: 0x060018F6 RID: 6390 RVA: 0x0000C7A7 File Offset: 0x0000A9A7
			public unsafe int flatIdxInCellIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_flatIdxInCellIndices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_flatIdxInCellIndices)) = value;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00069118 File Offset: 0x00067318
			// (set) Token: 0x060018F8 RID: 6392 RVA: 0x0000C7C2 File Offset: 0x0000A9C2
			public unsafe bool loaded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_loaded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_loaded)) = value;
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00069140 File Offset: 0x00067340
			// (set) Token: 0x060018FA RID: 6394 RVA: 0x0000C7DD File Offset: 0x0000A9DD
			public unsafe ProbeBrickIndex.CellIndexUpdateInfo updateInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_updateInfo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_updateInfo)) = value;
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x060018FB RID: 6395 RVA: 0x00069168 File Offset: 0x00067368
			// (set) Token: 0x060018FC RID: 6396 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
			public unsafe bool indexUpdated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_indexUpdated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_indexUpdated)) = value;
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x060018FD RID: 6397 RVA: 0x00069190 File Offset: 0x00067390
			// (set) Token: 0x060018FE RID: 6398 RVA: 0x0000C813 File Offset: 0x0000AA13
			public unsafe ProbeBrickIndex.CellIndexUpdateInfo tempUpdateInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_tempUpdateInfo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_tempUpdateInfo)) = value;
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x060018FF RID: 6399 RVA: 0x000691B8 File Offset: 0x000673B8
			// (set) Token: 0x06001900 RID: 6400 RVA: 0x0000C82E File Offset: 0x0000AA2E
			public unsafe int sourceAssetInstanceID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_sourceAssetInstanceID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_sourceAssetInstanceID)) = value;
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06001901 RID: 6401 RVA: 0x000691E0 File Offset: 0x000673E0
			// (set) Token: 0x06001902 RID: 6402 RVA: 0x0000C849 File Offset: 0x0000AA49
			public unsafe float streamingScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_streamingScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_streamingScore)) = value;
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001903 RID: 6403 RVA: 0x00069208 File Offset: 0x00067408
			// (set) Token: 0x06001904 RID: 6404 RVA: 0x0000C864 File Offset: 0x0000AA64
			public unsafe int referenceCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_referenceCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_referenceCount)) = value;
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06001905 RID: 6405 RVA: 0x00069230 File Offset: 0x00067430
			// (set) Token: 0x06001906 RID: 6406 RVA: 0x0000C87F File Offset: 0x0000AA7F
			public unsafe ProbeReferenceVolume.CellInstancedDebugProbes debugProbes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_debugProbes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.CellInstancedDebugProbes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInfo.NativeFieldInfoPtr_debugProbes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400120E RID: 4622
			private static readonly IntPtr NativeFieldInfoPtr_cell;

			// Token: 0x0400120F RID: 4623
			private static readonly IntPtr NativeFieldInfoPtr_blendingCell;

			// Token: 0x04001210 RID: 4624
			private static readonly IntPtr NativeFieldInfoPtr_chunkList;

			// Token: 0x04001211 RID: 4625
			private static readonly IntPtr NativeFieldInfoPtr_flatIdxInCellIndices;

			// Token: 0x04001212 RID: 4626
			private static readonly IntPtr NativeFieldInfoPtr_loaded;

			// Token: 0x04001213 RID: 4627
			private static readonly IntPtr NativeFieldInfoPtr_updateInfo;

			// Token: 0x04001214 RID: 4628
			private static readonly IntPtr NativeFieldInfoPtr_indexUpdated;

			// Token: 0x04001215 RID: 4629
			private static readonly IntPtr NativeFieldInfoPtr_tempUpdateInfo;

			// Token: 0x04001216 RID: 4630
			private static readonly IntPtr NativeFieldInfoPtr_sourceAssetInstanceID;

			// Token: 0x04001217 RID: 4631
			private static readonly IntPtr NativeFieldInfoPtr_streamingScore;

			// Token: 0x04001218 RID: 4632
			private static readonly IntPtr NativeFieldInfoPtr_referenceCount;

			// Token: 0x04001219 RID: 4633
			private static readonly IntPtr NativeFieldInfoPtr_debugProbes;

			// Token: 0x0400121A RID: 4634
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CellInfo_0;

			// Token: 0x0400121B RID: 4635
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x0400121C RID: 4636
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001C6 RID: 454
		public class BlendingCellInfo : Object
		{
			// Token: 0x06001907 RID: 6407 RVA: 0x00069260 File Offset: 0x00067460
			// Note: this type is marked as 'beforefieldinit'.
			static BlendingCellInfo()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "BlendingCellInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr);
				ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_cellInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, "cellInfo");
				ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_chunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, "chunkList");
				ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_streamingScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, "streamingScore");
				ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_blendingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, "blendingFactor");
				ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_blending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, "blending");
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlendingCellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664876);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664877);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_MarkUpToDate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664878);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_IsUpToDate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664879);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_ForceReupload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664880);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_ShouldReupload_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664881);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_Prioritize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664882);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_ShouldPrioritize_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664883);
				ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr, 100664884);
			}

			// Token: 0x06001908 RID: 6408 RVA: 0x000693A4 File Offset: 0x000675A4
			[CallerCount(0)]
			public unsafe virtual int CompareTo(ProbeReferenceVolume.BlendingCellInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlendingCellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001909 RID: 6409 RVA: 0x000693F4 File Offset: 0x000675F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966999, XrefRangeEnd = 967001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600190A RID: 6410 RVA: 0x00069428 File Offset: 0x00067628
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967001, RefRangeEnd = 967002, XrefRangeStart = 967001, XrefRangeEnd = 967001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MarkUpToDate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_MarkUpToDate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600190B RID: 6411 RVA: 0x0006945C File Offset: 0x0006765C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967002, RefRangeEnd = 967003, XrefRangeStart = 967002, XrefRangeEnd = 967002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsUpToDate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_IsUpToDate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600190C RID: 6412 RVA: 0x00069498 File Offset: 0x00067698
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967003, RefRangeEnd = 967004, XrefRangeStart = 967003, XrefRangeEnd = 967003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ForceReupload()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_ForceReupload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600190D RID: 6413 RVA: 0x000694CC File Offset: 0x000676CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967004, RefRangeEnd = 967005, XrefRangeStart = 967004, XrefRangeEnd = 967004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ShouldReupload()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_ShouldReupload_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600190E RID: 6414 RVA: 0x00069508 File Offset: 0x00067708
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967005, RefRangeEnd = 967006, XrefRangeStart = 967005, XrefRangeEnd = 967005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Prioritize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_Prioritize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600190F RID: 6415 RVA: 0x0006953C File Offset: 0x0006773C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967006, RefRangeEnd = 967007, XrefRangeStart = 967006, XrefRangeEnd = 967006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ShouldPrioritize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr_ShouldPrioritize_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001910 RID: 6416 RVA: 0x00069578 File Offset: 0x00067778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967007, XrefRangeEnd = 967015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BlendingCellInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.BlendingCellInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.BlendingCellInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001911 RID: 6417 RVA: 0x0000C89E File Offset: 0x0000AA9E
			public BlendingCellInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06001912 RID: 6418 RVA: 0x000695B4 File Offset: 0x000677B4
			// (set) Token: 0x06001913 RID: 6419 RVA: 0x0000C8A7 File Offset: 0x0000AAA7
			public unsafe ProbeReferenceVolume.CellInfo cellInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_cellInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.CellInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_cellInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001914 RID: 6420 RVA: 0x000695E4 File Offset: 0x000677E4
			// (set) Token: 0x06001915 RID: 6421 RVA: 0x0000C8C6 File Offset: 0x0000AAC6
			public unsafe List<ProbeBrickPool.BrickChunkAlloc> chunkList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_chunkList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_chunkList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06001916 RID: 6422 RVA: 0x00069614 File Offset: 0x00067814
			// (set) Token: 0x06001917 RID: 6423 RVA: 0x0000C8E5 File Offset: 0x0000AAE5
			public unsafe float streamingScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_streamingScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_streamingScore)) = value;
				}
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06001918 RID: 6424 RVA: 0x0006963C File Offset: 0x0006783C
			// (set) Token: 0x06001919 RID: 6425 RVA: 0x0000C900 File Offset: 0x0000AB00
			public unsafe float blendingFactor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_blendingFactor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_blendingFactor)) = value;
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x0600191A RID: 6426 RVA: 0x00069664 File Offset: 0x00067864
			// (set) Token: 0x0600191B RID: 6427 RVA: 0x0000C91B File Offset: 0x0000AB1B
			public unsafe bool blending
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_blending);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.BlendingCellInfo.NativeFieldInfoPtr_blending)) = value;
				}
			}

			// Token: 0x0400121D RID: 4637
			private static readonly IntPtr NativeFieldInfoPtr_cellInfo;

			// Token: 0x0400121E RID: 4638
			private static readonly IntPtr NativeFieldInfoPtr_chunkList;

			// Token: 0x0400121F RID: 4639
			private static readonly IntPtr NativeFieldInfoPtr_streamingScore;

			// Token: 0x04001220 RID: 4640
			private static readonly IntPtr NativeFieldInfoPtr_blendingFactor;

			// Token: 0x04001221 RID: 4641
			private static readonly IntPtr NativeFieldInfoPtr_blending;

			// Token: 0x04001222 RID: 4642
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlendingCellInfo_0;

			// Token: 0x04001223 RID: 4643
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x04001224 RID: 4644
			private static readonly IntPtr NativeMethodInfoPtr_MarkUpToDate_Public_Void_0;

			// Token: 0x04001225 RID: 4645
			private static readonly IntPtr NativeMethodInfoPtr_IsUpToDate_Public_Boolean_0;

			// Token: 0x04001226 RID: 4646
			private static readonly IntPtr NativeMethodInfoPtr_ForceReupload_Public_Void_0;

			// Token: 0x04001227 RID: 4647
			private static readonly IntPtr NativeMethodInfoPtr_ShouldReupload_Public_Boolean_0;

			// Token: 0x04001228 RID: 4648
			private static readonly IntPtr NativeMethodInfoPtr_Prioritize_Public_Void_0;

			// Token: 0x04001229 RID: 4649
			private static readonly IntPtr NativeMethodInfoPtr_ShouldPrioritize_Public_Boolean_0;

			// Token: 0x0400122A RID: 4650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001C7 RID: 455
		[StructLayout(2)]
		public struct Volume
		{
			// Token: 0x0600191C RID: 6428 RVA: 0x0006968C File Offset: 0x0006788C
			// Note: this type is marked as 'beforefieldinit'.
			static Volume()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "Volume");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr);
				ProbeReferenceVolume.Volume.NativeFieldInfoPtr_corner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, "corner");
				ProbeReferenceVolume.Volume.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, "X");
				ProbeReferenceVolume.Volume.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, "Y");
				ProbeReferenceVolume.Volume.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, "Z");
				ProbeReferenceVolume.Volume.NativeFieldInfoPtr_maxSubdivisionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, "maxSubdivisionMultiplier");
				ProbeReferenceVolume.Volume.NativeFieldInfoPtr_minSubdivisionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, "minSubdivisionMultiplier");
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664885);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664886);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664887);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664888);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr_CalculateAABB_Public_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664889);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr_CalculateCenterAndSize_Public_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664890);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664891);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664892);
				ProbeReferenceVolume.Volume.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, 100664893);
			}

			// Token: 0x0600191D RID: 6429 RVA: 0x000697E4 File Offset: 0x000679E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967015, XrefRangeEnd = 967019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref trs;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSubdivision;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minSubdivision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600191E RID: 6430 RVA: 0x00069834 File Offset: 0x00067A34
			[CallerCount(0)]
			public unsafe Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f, float minSubdivision = 0f)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref corner;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref X;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Y;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Z;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSubdivision;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minSubdivision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600191F RID: 6431 RVA: 0x000698AC File Offset: 0x00067AAC
			[CallerCount(0)]
			public unsafe Volume(ProbeReferenceVolume.Volume copy)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref copy;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Volume_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001920 RID: 6432 RVA: 0x000698E0 File Offset: 0x00067AE0
			[CallerCount(0)]
			public unsafe Volume(Bounds bounds)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bounds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr__ctor_Public_Void_Bounds_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001921 RID: 6433 RVA: 0x00069914 File Offset: 0x00067B14
			[CallerCount(0)]
			public unsafe Bounds CalculateAABB()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr_CalculateAABB_Public_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001922 RID: 6434 RVA: 0x00069944 File Offset: 0x00067B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967019, XrefRangeEnd = 967022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CalculateCenterAndSize(out Vector3 center, out Vector3 size)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &center;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr_CalculateCenterAndSize_Public_Void_byref_Vector3_byref_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001923 RID: 6435 RVA: 0x00069984 File Offset: 0x00067B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967022, XrefRangeEnd = 967026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Transform(Matrix4x4 trs)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref trs;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001924 RID: 6436 RVA: 0x000699B8 File Offset: 0x00067BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967026, XrefRangeEnd = 967054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001925 RID: 6437 RVA: 0x000699E4 File Offset: 0x00067BE4
			[CallerCount(0)]
			public unsafe bool Equals(ProbeReferenceVolume.Volume other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.Volume.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Volume_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001926 RID: 6438 RVA: 0x0000C936 File Offset: 0x0000AB36
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeReferenceVolume.Volume>.NativeClassPtr, ref this));
			}

			// Token: 0x0400122B RID: 4651
			private static readonly IntPtr NativeFieldInfoPtr_corner;

			// Token: 0x0400122C RID: 4652
			private static readonly IntPtr NativeFieldInfoPtr_X;

			// Token: 0x0400122D RID: 4653
			private static readonly IntPtr NativeFieldInfoPtr_Y;

			// Token: 0x0400122E RID: 4654
			private static readonly IntPtr NativeFieldInfoPtr_Z;

			// Token: 0x0400122F RID: 4655
			private static readonly IntPtr NativeFieldInfoPtr_maxSubdivisionMultiplier;

			// Token: 0x04001230 RID: 4656
			private static readonly IntPtr NativeFieldInfoPtr_minSubdivisionMultiplier;

			// Token: 0x04001231 RID: 4657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Single_Single_0;

			// Token: 0x04001232 RID: 4658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_Single_0;

			// Token: 0x04001233 RID: 4659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Volume_0;

			// Token: 0x04001234 RID: 4660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Bounds_0;

			// Token: 0x04001235 RID: 4661
			private static readonly IntPtr NativeMethodInfoPtr_CalculateAABB_Public_Bounds_0;

			// Token: 0x04001236 RID: 4662
			private static readonly IntPtr NativeMethodInfoPtr_CalculateCenterAndSize_Public_Void_byref_Vector3_byref_Vector3_0;

			// Token: 0x04001237 RID: 4663
			private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0;

			// Token: 0x04001238 RID: 4664
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04001239 RID: 4665
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Volume_0;

			// Token: 0x0400123A RID: 4666
			[FieldOffset(0)]
			public Vector3 corner;

			// Token: 0x0400123B RID: 4667
			[FieldOffset(12)]
			public Vector3 X;

			// Token: 0x0400123C RID: 4668
			[FieldOffset(24)]
			public Vector3 Y;

			// Token: 0x0400123D RID: 4669
			[FieldOffset(36)]
			public Vector3 Z;

			// Token: 0x0400123E RID: 4670
			[FieldOffset(48)]
			public float maxSubdivisionMultiplier;

			// Token: 0x0400123F RID: 4671
			[FieldOffset(52)]
			public float minSubdivisionMultiplier;
		}

		// Token: 0x020001C8 RID: 456
		[StructLayout(2)]
		public struct RefVolTransform
		{
			// Token: 0x06001927 RID: 6439 RVA: 0x00069A24 File Offset: 0x00067C24
			// Note: this type is marked as 'beforefieldinit'.
			static RefVolTransform()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.RefVolTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "RefVolTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.RefVolTransform>.NativeClassPtr);
				ProbeReferenceVolume.RefVolTransform.NativeFieldInfoPtr_posWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RefVolTransform>.NativeClassPtr, "posWS");
				ProbeReferenceVolume.RefVolTransform.NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RefVolTransform>.NativeClassPtr, "rot");
				ProbeReferenceVolume.RefVolTransform.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RefVolTransform>.NativeClassPtr, "scale");
			}

			// Token: 0x06001928 RID: 6440 RVA: 0x0000C948 File Offset: 0x0000AB48
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeReferenceVolume.RefVolTransform>.NativeClassPtr, ref this));
			}

			// Token: 0x04001240 RID: 4672
			private static readonly IntPtr NativeFieldInfoPtr_posWS;

			// Token: 0x04001241 RID: 4673
			private static readonly IntPtr NativeFieldInfoPtr_rot;

			// Token: 0x04001242 RID: 4674
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04001243 RID: 4675
			[FieldOffset(0)]
			public Vector3 posWS;

			// Token: 0x04001244 RID: 4676
			[FieldOffset(12)]
			public Quaternion rot;

			// Token: 0x04001245 RID: 4677
			[FieldOffset(28)]
			public float scale;
		}

		// Token: 0x020001C9 RID: 457
		public sealed class RuntimeResources : ValueType
		{
			// Token: 0x06001929 RID: 6441 RVA: 0x00069A8C File Offset: 0x00067C8C
			// Note: this type is marked as 'beforefieldinit'.
			static RuntimeResources()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "RuntimeResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr);
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "index");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_cellIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "cellIndices");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L0_L1rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "L0_L1rx");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L1_G_ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "L1_G_ry");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L1_B_rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "L1_B_rz");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "L2_0");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "L2_1");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "L2_2");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "L2_3");
				ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_Validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr, "Validity");
			}

			// Token: 0x0600192A RID: 6442 RVA: 0x0000C95A File Offset: 0x0000AB5A
			public RuntimeResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600192B RID: 6443 RVA: 0x0000C963 File Offset: 0x0000AB63
			public RuntimeResources()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.RuntimeResources>.NativeClassPtr))
			{
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x0600192C RID: 6444 RVA: 0x00069B80 File Offset: 0x00067D80
			// (set) Token: 0x0600192D RID: 6445 RVA: 0x0000C975 File Offset: 0x0000AB75
			public unsafe ComputeBuffer index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_index);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_index), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x0600192E RID: 6446 RVA: 0x00069BB0 File Offset: 0x00067DB0
			// (set) Token: 0x0600192F RID: 6447 RVA: 0x0000C994 File Offset: 0x0000AB94
			public unsafe ComputeBuffer cellIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_cellIndices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_cellIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06001930 RID: 6448 RVA: 0x00069BE0 File Offset: 0x00067DE0
			// (set) Token: 0x06001931 RID: 6449 RVA: 0x0000C9B3 File Offset: 0x0000ABB3
			public unsafe RenderTexture L0_L1rx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L0_L1rx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L0_L1rx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06001932 RID: 6450 RVA: 0x00069C10 File Offset: 0x00067E10
			// (set) Token: 0x06001933 RID: 6451 RVA: 0x0000C9D2 File Offset: 0x0000ABD2
			public unsafe RenderTexture L1_G_ry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L1_G_ry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L1_G_ry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06001934 RID: 6452 RVA: 0x00069C40 File Offset: 0x00067E40
			// (set) Token: 0x06001935 RID: 6453 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
			public unsafe RenderTexture L1_B_rz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L1_B_rz);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L1_B_rz), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06001936 RID: 6454 RVA: 0x00069C70 File Offset: 0x00067E70
			// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000CA10 File Offset: 0x0000AC10
			public unsafe RenderTexture L2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06001938 RID: 6456 RVA: 0x00069CA0 File Offset: 0x00067EA0
			// (set) Token: 0x06001939 RID: 6457 RVA: 0x0000CA2F File Offset: 0x0000AC2F
			public unsafe RenderTexture L2_1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x0600193A RID: 6458 RVA: 0x00069CD0 File Offset: 0x00067ED0
			// (set) Token: 0x0600193B RID: 6459 RVA: 0x0000CA4E File Offset: 0x0000AC4E
			public unsafe RenderTexture L2_2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x0600193C RID: 6460 RVA: 0x00069D00 File Offset: 0x00067F00
			// (set) Token: 0x0600193D RID: 6461 RVA: 0x0000CA6D File Offset: 0x0000AC6D
			public unsafe RenderTexture L2_3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_L2_3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x0600193E RID: 6462 RVA: 0x00069D30 File Offset: 0x00067F30
			// (set) Token: 0x0600193F RID: 6463 RVA: 0x0000CA8C File Offset: 0x0000AC8C
			public unsafe Texture3D Validity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_Validity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.RuntimeResources.NativeFieldInfoPtr_Validity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001246 RID: 4678
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04001247 RID: 4679
			private static readonly IntPtr NativeFieldInfoPtr_cellIndices;

			// Token: 0x04001248 RID: 4680
			private static readonly IntPtr NativeFieldInfoPtr_L0_L1rx;

			// Token: 0x04001249 RID: 4681
			private static readonly IntPtr NativeFieldInfoPtr_L1_G_ry;

			// Token: 0x0400124A RID: 4682
			private static readonly IntPtr NativeFieldInfoPtr_L1_B_rz;

			// Token: 0x0400124B RID: 4683
			private static readonly IntPtr NativeFieldInfoPtr_L2_0;

			// Token: 0x0400124C RID: 4684
			private static readonly IntPtr NativeFieldInfoPtr_L2_1;

			// Token: 0x0400124D RID: 4685
			private static readonly IntPtr NativeFieldInfoPtr_L2_2;

			// Token: 0x0400124E RID: 4686
			private static readonly IntPtr NativeFieldInfoPtr_L2_3;

			// Token: 0x0400124F RID: 4687
			private static readonly IntPtr NativeFieldInfoPtr_Validity;
		}

		// Token: 0x020001CA RID: 458
		[StructLayout(2)]
		public struct ExtraDataActionInput
		{
			// Token: 0x06001940 RID: 6464 RVA: 0x0000CAAB File Offset: 0x0000ACAB
			// Note: this type is marked as 'beforefieldinit'.
			static ExtraDataActionInput()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.ExtraDataActionInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "ExtraDataActionInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.ExtraDataActionInput>.NativeClassPtr);
			}

			// Token: 0x06001941 RID: 6465 RVA: 0x0000CACB File Offset: 0x0000ACCB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeReferenceVolume.ExtraDataActionInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020001CB RID: 459
		[StructLayout(2)]
		public struct InitInfo
		{
			// Token: 0x06001942 RID: 6466 RVA: 0x00069D60 File Offset: 0x00067F60
			// Note: this type is marked as 'beforefieldinit'.
			static InitInfo()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.InitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "InitInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.InitInfo>.NativeClassPtr);
				ProbeReferenceVolume.InitInfo.NativeFieldInfoPtr_pendingMinCellPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.InitInfo>.NativeClassPtr, "pendingMinCellPosition");
				ProbeReferenceVolume.InitInfo.NativeFieldInfoPtr_pendingMaxCellPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.InitInfo>.NativeClassPtr, "pendingMaxCellPosition");
			}

			// Token: 0x06001943 RID: 6467 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeReferenceVolume.InitInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x04001250 RID: 4688
			private static readonly IntPtr NativeFieldInfoPtr_pendingMinCellPosition;

			// Token: 0x04001251 RID: 4689
			private static readonly IntPtr NativeFieldInfoPtr_pendingMaxCellPosition;

			// Token: 0x04001252 RID: 4690
			[FieldOffset(0)]
			public Vector3Int pendingMinCellPosition;

			// Token: 0x04001253 RID: 4691
			[FieldOffset(12)]
			public Vector3Int pendingMaxCellPosition;
		}

		// Token: 0x020001CC RID: 460
		public class CellInstancedDebugProbes : Object
		{
			// Token: 0x06001944 RID: 6468 RVA: 0x00069DB4 File Offset: 0x00067FB4
			// Note: this type is marked as 'beforefieldinit'.
			static CellInstancedDebugProbes()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.CellInstancedDebugProbes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellInstancedDebugProbes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.CellInstancedDebugProbes>.NativeClassPtr);
				ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_probeBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInstancedDebugProbes>.NativeClassPtr, "probeBuffers");
				ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_offsetBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInstancedDebugProbes>.NativeClassPtr, "offsetBuffers");
				ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.CellInstancedDebugProbes>.NativeClassPtr, "props");
				ProbeReferenceVolume.CellInstancedDebugProbes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.CellInstancedDebugProbes>.NativeClassPtr, 100664894);
			}

			// Token: 0x06001945 RID: 6469 RVA: 0x00069E30 File Offset: 0x00068030
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CellInstancedDebugProbes()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.CellInstancedDebugProbes>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.CellInstancedDebugProbes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001946 RID: 6470 RVA: 0x0000CAEF File Offset: 0x0000ACEF
			public CellInstancedDebugProbes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06001947 RID: 6471 RVA: 0x00069E6C File Offset: 0x0006806C
			// (set) Token: 0x06001948 RID: 6472 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
			public unsafe List<Il2CppStructArray<Matrix4x4>> probeBuffers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_probeBuffers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<Matrix4x4>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_probeBuffers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06001949 RID: 6473 RVA: 0x00069E9C File Offset: 0x0006809C
			// (set) Token: 0x0600194A RID: 6474 RVA: 0x0000CB17 File Offset: 0x0000AD17
			public unsafe List<Il2CppStructArray<Matrix4x4>> offsetBuffers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_offsetBuffers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<Matrix4x4>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_offsetBuffers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x0600194B RID: 6475 RVA: 0x00069ECC File Offset: 0x000680CC
			// (set) Token: 0x0600194C RID: 6476 RVA: 0x0000CB36 File Offset: 0x0000AD36
			public unsafe List<MaterialPropertyBlock> props
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_props);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialPropertyBlock>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.CellInstancedDebugProbes.NativeFieldInfoPtr_props), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001254 RID: 4692
			private static readonly IntPtr NativeFieldInfoPtr_probeBuffers;

			// Token: 0x04001255 RID: 4693
			private static readonly IntPtr NativeFieldInfoPtr_offsetBuffers;

			// Token: 0x04001256 RID: 4694
			private static readonly IntPtr NativeFieldInfoPtr_props;

			// Token: 0x04001257 RID: 4695
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001CD RID: 461
		[ObfuscatedName("UnityEngine.Rendering.ProbeReferenceVolume+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600194D RID: 6477 RVA: 0x00069EFC File Offset: 0x000680FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr);
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__120_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__120_0");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__120_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__120_1");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_7");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_16");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_17");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_22");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_23");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_26");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_27");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_32");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_33");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_36");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_39 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_39");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_40 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_40");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_41 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_41");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_43 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_43");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_44 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_44");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_45");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_46 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_46");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_47");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_48");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_49");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_54 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_54");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_55 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_55");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_56 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_56");
				ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, "<>9__171_57");
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664896);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr___ctor_b__120_0_Internal_Void_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664897);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr___ctor_b__120_1_Internal_Void_BlendingCellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664898);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_7_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664899);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_16_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664900);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_17_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664901);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_22_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664902);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_23_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664903);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_26_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664904);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_27_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664905);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_32_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664906);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_33_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664907);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_36_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664908);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_39_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664909);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_40_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664910);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_41_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664911);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_43_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664912);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_44_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664913);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_45_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664914);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_46_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664915);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_47_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664916);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_48_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664917);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_49_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664918);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_54_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664919);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_55_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664920);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_56_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664921);
				ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_57_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr, 100664922);
			}

			// Token: 0x0600194E RID: 6478 RVA: 0x0006A360 File Offset: 0x00068560
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600194F RID: 6479 RVA: 0x0006A39C File Offset: 0x0006859C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967054, XrefRangeEnd = 967059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__120_0(ProbeReferenceVolume.CellInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr___ctor_b__120_0_Internal_Void_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001950 RID: 6480 RVA: 0x0006A3E0 File Offset: 0x000685E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967059, XrefRangeEnd = 967061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__120_1(ProbeReferenceVolume.BlendingCellInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr___ctor_b__120_1_Internal_Void_BlendingCellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001951 RID: 6481 RVA: 0x0006A424 File Offset: 0x00068624
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_7_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001952 RID: 6482 RVA: 0x0006A460 File Offset: 0x00068660
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__171_16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_16_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001953 RID: 6483 RVA: 0x0006A49C File Offset: 0x0006869C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 620595, RefRangeEnd = 620598, XrefRangeStart = 620595, XrefRangeEnd = 620598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_17()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_17_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001954 RID: 6484 RVA: 0x0006A4D8 File Offset: 0x000686D8
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_22()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_22_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001955 RID: 6485 RVA: 0x0006A514 File Offset: 0x00068714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967061, XrefRangeEnd = 967068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_23()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_23_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001956 RID: 6486 RVA: 0x0006A550 File Offset: 0x00068750
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_26()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_26_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001957 RID: 6487 RVA: 0x0006A58C File Offset: 0x0006878C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967068, XrefRangeEnd = 967075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_27()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_27_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001958 RID: 6488 RVA: 0x0006A5C8 File Offset: 0x000687C8
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__171_32()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_32_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001959 RID: 6489 RVA: 0x0006A604 File Offset: 0x00068804
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 620598, RefRangeEnd = 620600, XrefRangeStart = 620598, XrefRangeEnd = 620600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_33()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_33_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600195A RID: 6490 RVA: 0x0006A640 File Offset: 0x00068840
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_36()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_36_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600195B RID: 6491 RVA: 0x0006A67C File Offset: 0x0006887C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967075, XrefRangeEnd = 967082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_39()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_39_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600195C RID: 6492 RVA: 0x0006A6B8 File Offset: 0x000688B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967082, XrefRangeEnd = 967091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__171_40(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_40_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600195D RID: 6493 RVA: 0x0006A6F8 File Offset: 0x000688F8
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_41()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_41_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600195E RID: 6494 RVA: 0x0006A734 File Offset: 0x00068934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967091, XrefRangeEnd = 967098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_43()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_43_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600195F RID: 6495 RVA: 0x0006A770 File Offset: 0x00068970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967098, XrefRangeEnd = 967107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__171_44(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_44_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001960 RID: 6496 RVA: 0x0006A7B0 File Offset: 0x000689B0
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__171_45()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_45_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001961 RID: 6497 RVA: 0x0006A7EC File Offset: 0x000689EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967107, XrefRangeEnd = 967114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_46()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_46_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001962 RID: 6498 RVA: 0x0006A828 File Offset: 0x00068A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967114, XrefRangeEnd = 967123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__171_47(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_47_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001963 RID: 6499 RVA: 0x0006A868 File Offset: 0x00068A68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_48()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_48_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001964 RID: 6500 RVA: 0x0006A8A4 File Offset: 0x00068AA4
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__171_49()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_49_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001965 RID: 6501 RVA: 0x0006A8E0 File Offset: 0x00068AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967123, XrefRangeEnd = 967132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_54()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_54_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001966 RID: 6502 RVA: 0x0006A91C File Offset: 0x00068B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967132, XrefRangeEnd = 967141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__171_55(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_55_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001967 RID: 6503 RVA: 0x0006A95C File Offset: 0x00068B5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _RegisterDebug_b__171_56()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_56_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001968 RID: 6504 RVA: 0x0006A998 File Offset: 0x00068B98
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__171_57()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c.NativeMethodInfoPtr__RegisterDebug_b__171_57_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001969 RID: 6505 RVA: 0x0000CB55 File Offset: 0x0000AD55
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x0600196A RID: 6506 RVA: 0x0006A9D4 File Offset: 0x00068BD4
			// (set) Token: 0x0600196B RID: 6507 RVA: 0x0000CB5E File Offset: 0x0000AD5E
			public unsafe static ProbeReferenceVolume.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x0600196C RID: 6508 RVA: 0x0006A9FC File Offset: 0x00068BFC
			// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000CB70 File Offset: 0x0000AD70
			public unsafe static UnityAction<ProbeReferenceVolume.CellInfo> __9__120_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__120_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ProbeReferenceVolume.CellInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__120_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x0600196E RID: 6510 RVA: 0x0006AA24 File Offset: 0x00068C24
			// (set) Token: 0x0600196F RID: 6511 RVA: 0x0000CB82 File Offset: 0x0000AD82
			public unsafe static UnityAction<ProbeReferenceVolume.BlendingCellInfo> __9__120_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__120_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ProbeReferenceVolume.BlendingCellInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__120_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06001970 RID: 6512 RVA: 0x0006AA4C File Offset: 0x00068C4C
			// (set) Token: 0x06001971 RID: 6513 RVA: 0x0000CB94 File Offset: 0x0000AD94
			public unsafe static Func<float> __9__171_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06001972 RID: 6514 RVA: 0x0006AA74 File Offset: 0x00068C74
			// (set) Token: 0x06001973 RID: 6515 RVA: 0x0000CBA6 File Offset: 0x0000ADA6
			public unsafe static Func<float> __9__171_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06001974 RID: 6516 RVA: 0x0006AA9C File Offset: 0x00068C9C
			// (set) Token: 0x06001975 RID: 6517 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
			public unsafe static Func<float> __9__171_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06001976 RID: 6518 RVA: 0x0006AAC4 File Offset: 0x00068CC4
			// (set) Token: 0x06001977 RID: 6519 RVA: 0x0000CBCA File Offset: 0x0000ADCA
			public unsafe static Func<int> __9__171_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06001978 RID: 6520 RVA: 0x0006AAEC File Offset: 0x00068CEC
			// (set) Token: 0x06001979 RID: 6521 RVA: 0x0000CBDC File Offset: 0x0000ADDC
			public unsafe static Func<int> __9__171_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x0600197A RID: 6522 RVA: 0x0006AB14 File Offset: 0x00068D14
			// (set) Token: 0x0600197B RID: 6523 RVA: 0x0000CBEE File Offset: 0x0000ADEE
			public unsafe static Func<int> __9__171_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x0600197C RID: 6524 RVA: 0x0006AB3C File Offset: 0x00068D3C
			// (set) Token: 0x0600197D RID: 6525 RVA: 0x0000CC00 File Offset: 0x0000AE00
			public unsafe static Func<int> __9__171_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x0600197E RID: 6526 RVA: 0x0006AB64 File Offset: 0x00068D64
			// (set) Token: 0x0600197F RID: 6527 RVA: 0x0000CC12 File Offset: 0x0000AE12
			public unsafe static Func<float> __9__171_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06001980 RID: 6528 RVA: 0x0006AB8C File Offset: 0x00068D8C
			// (set) Token: 0x06001981 RID: 6529 RVA: 0x0000CC24 File Offset: 0x0000AE24
			public unsafe static Func<float> __9__171_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x06001982 RID: 6530 RVA: 0x0006ABB4 File Offset: 0x00068DB4
			// (set) Token: 0x06001983 RID: 6531 RVA: 0x0000CC36 File Offset: 0x0000AE36
			public unsafe static Func<float> __9__171_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06001984 RID: 6532 RVA: 0x0006ABDC File Offset: 0x00068DDC
			// (set) Token: 0x06001985 RID: 6533 RVA: 0x0000CC48 File Offset: 0x0000AE48
			public unsafe static Func<int> __9__171_39
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_39, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_39, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06001986 RID: 6534 RVA: 0x0006AC04 File Offset: 0x00068E04
			// (set) Token: 0x06001987 RID: 6535 RVA: 0x0000CC5A File Offset: 0x0000AE5A
			public unsafe static Action<int> __9__171_40
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_40, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_40, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06001988 RID: 6536 RVA: 0x0006AC2C File Offset: 0x00068E2C
			// (set) Token: 0x06001989 RID: 6537 RVA: 0x0000CC6C File Offset: 0x0000AE6C
			public unsafe static Func<int> __9__171_41
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_41, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_41, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x0600198A RID: 6538 RVA: 0x0006AC54 File Offset: 0x00068E54
			// (set) Token: 0x0600198B RID: 6539 RVA: 0x0000CC7E File Offset: 0x0000AE7E
			public unsafe static Func<int> __9__171_43
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_43, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_43, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x0600198C RID: 6540 RVA: 0x0006AC7C File Offset: 0x00068E7C
			// (set) Token: 0x0600198D RID: 6541 RVA: 0x0000CC90 File Offset: 0x0000AE90
			public unsafe static Action<int> __9__171_44
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_44, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_44, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x0600198E RID: 6542 RVA: 0x0006ACA4 File Offset: 0x00068EA4
			// (set) Token: 0x0600198F RID: 6543 RVA: 0x0000CCA2 File Offset: 0x0000AEA2
			public unsafe static Func<int> __9__171_45
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_45, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_45, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06001990 RID: 6544 RVA: 0x0006ACCC File Offset: 0x00068ECC
			// (set) Token: 0x06001991 RID: 6545 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
			public unsafe static Func<float> __9__171_46
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_46, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_46, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06001992 RID: 6546 RVA: 0x0006ACF4 File Offset: 0x00068EF4
			// (set) Token: 0x06001993 RID: 6547 RVA: 0x0000CCC6 File Offset: 0x0000AEC6
			public unsafe static Action<float> __9__171_47
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_47, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_47, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06001994 RID: 6548 RVA: 0x0006AD1C File Offset: 0x00068F1C
			// (set) Token: 0x06001995 RID: 6549 RVA: 0x0000CCD8 File Offset: 0x0000AED8
			public unsafe static Func<float> __9__171_48
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_48, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_48, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06001996 RID: 6550 RVA: 0x0006AD44 File Offset: 0x00068F44
			// (set) Token: 0x06001997 RID: 6551 RVA: 0x0000CCEA File Offset: 0x0000AEEA
			public unsafe static Func<float> __9__171_49
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_49, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_49, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001998 RID: 6552 RVA: 0x0006AD6C File Offset: 0x00068F6C
			// (set) Token: 0x06001999 RID: 6553 RVA: 0x0000CCFC File Offset: 0x0000AEFC
			public unsafe static Func<float> __9__171_54
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_54, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_54, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x0600199A RID: 6554 RVA: 0x0006AD94 File Offset: 0x00068F94
			// (set) Token: 0x0600199B RID: 6555 RVA: 0x0000CD0E File Offset: 0x0000AF0E
			public unsafe static Action<float> __9__171_55
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_55, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_55, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x0600199C RID: 6556 RVA: 0x0006ADBC File Offset: 0x00068FBC
			// (set) Token: 0x0600199D RID: 6557 RVA: 0x0000CD20 File Offset: 0x0000AF20
			public unsafe static Func<float> __9__171_56
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_56, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_56, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x0600199E RID: 6558 RVA: 0x0006ADE4 File Offset: 0x00068FE4
			// (set) Token: 0x0600199F RID: 6559 RVA: 0x0000CD32 File Offset: 0x0000AF32
			public unsafe static Func<float> __9__171_57
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_57, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeReferenceVolume.__c.NativeFieldInfoPtr___9__171_57, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001258 RID: 4696
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001259 RID: 4697
			private static readonly IntPtr NativeFieldInfoPtr___9__120_0;

			// Token: 0x0400125A RID: 4698
			private static readonly IntPtr NativeFieldInfoPtr___9__120_1;

			// Token: 0x0400125B RID: 4699
			private static readonly IntPtr NativeFieldInfoPtr___9__171_7;

			// Token: 0x0400125C RID: 4700
			private static readonly IntPtr NativeFieldInfoPtr___9__171_16;

			// Token: 0x0400125D RID: 4701
			private static readonly IntPtr NativeFieldInfoPtr___9__171_17;

			// Token: 0x0400125E RID: 4702
			private static readonly IntPtr NativeFieldInfoPtr___9__171_22;

			// Token: 0x0400125F RID: 4703
			private static readonly IntPtr NativeFieldInfoPtr___9__171_23;

			// Token: 0x04001260 RID: 4704
			private static readonly IntPtr NativeFieldInfoPtr___9__171_26;

			// Token: 0x04001261 RID: 4705
			private static readonly IntPtr NativeFieldInfoPtr___9__171_27;

			// Token: 0x04001262 RID: 4706
			private static readonly IntPtr NativeFieldInfoPtr___9__171_32;

			// Token: 0x04001263 RID: 4707
			private static readonly IntPtr NativeFieldInfoPtr___9__171_33;

			// Token: 0x04001264 RID: 4708
			private static readonly IntPtr NativeFieldInfoPtr___9__171_36;

			// Token: 0x04001265 RID: 4709
			private static readonly IntPtr NativeFieldInfoPtr___9__171_39;

			// Token: 0x04001266 RID: 4710
			private static readonly IntPtr NativeFieldInfoPtr___9__171_40;

			// Token: 0x04001267 RID: 4711
			private static readonly IntPtr NativeFieldInfoPtr___9__171_41;

			// Token: 0x04001268 RID: 4712
			private static readonly IntPtr NativeFieldInfoPtr___9__171_43;

			// Token: 0x04001269 RID: 4713
			private static readonly IntPtr NativeFieldInfoPtr___9__171_44;

			// Token: 0x0400126A RID: 4714
			private static readonly IntPtr NativeFieldInfoPtr___9__171_45;

			// Token: 0x0400126B RID: 4715
			private static readonly IntPtr NativeFieldInfoPtr___9__171_46;

			// Token: 0x0400126C RID: 4716
			private static readonly IntPtr NativeFieldInfoPtr___9__171_47;

			// Token: 0x0400126D RID: 4717
			private static readonly IntPtr NativeFieldInfoPtr___9__171_48;

			// Token: 0x0400126E RID: 4718
			private static readonly IntPtr NativeFieldInfoPtr___9__171_49;

			// Token: 0x0400126F RID: 4719
			private static readonly IntPtr NativeFieldInfoPtr___9__171_54;

			// Token: 0x04001270 RID: 4720
			private static readonly IntPtr NativeFieldInfoPtr___9__171_55;

			// Token: 0x04001271 RID: 4721
			private static readonly IntPtr NativeFieldInfoPtr___9__171_56;

			// Token: 0x04001272 RID: 4722
			private static readonly IntPtr NativeFieldInfoPtr___9__171_57;

			// Token: 0x04001273 RID: 4723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001274 RID: 4724
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__120_0_Internal_Void_CellInfo_0;

			// Token: 0x04001275 RID: 4725
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__120_1_Internal_Void_BlendingCellInfo_0;

			// Token: 0x04001276 RID: 4726
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_7_Internal_Single_0;

			// Token: 0x04001277 RID: 4727
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_16_Internal_Single_0;

			// Token: 0x04001278 RID: 4728
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_17_Internal_Single_0;

			// Token: 0x04001279 RID: 4729
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_22_Internal_Int32_0;

			// Token: 0x0400127A RID: 4730
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_23_Internal_Int32_0;

			// Token: 0x0400127B RID: 4731
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_26_Internal_Int32_0;

			// Token: 0x0400127C RID: 4732
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_27_Internal_Int32_0;

			// Token: 0x0400127D RID: 4733
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_32_Internal_Single_0;

			// Token: 0x0400127E RID: 4734
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_33_Internal_Single_0;

			// Token: 0x0400127F RID: 4735
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_36_Internal_Single_0;

			// Token: 0x04001280 RID: 4736
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_39_Internal_Int32_0;

			// Token: 0x04001281 RID: 4737
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_40_Internal_Void_Int32_0;

			// Token: 0x04001282 RID: 4738
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_41_Internal_Int32_0;

			// Token: 0x04001283 RID: 4739
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_43_Internal_Int32_0;

			// Token: 0x04001284 RID: 4740
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_44_Internal_Void_Int32_0;

			// Token: 0x04001285 RID: 4741
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_45_Internal_Int32_0;

			// Token: 0x04001286 RID: 4742
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_46_Internal_Single_0;

			// Token: 0x04001287 RID: 4743
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_47_Internal_Void_Single_0;

			// Token: 0x04001288 RID: 4744
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_48_Internal_Single_0;

			// Token: 0x04001289 RID: 4745
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_49_Internal_Single_0;

			// Token: 0x0400128A RID: 4746
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_54_Internal_Single_0;

			// Token: 0x0400128B RID: 4747
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_55_Internal_Void_Single_0;

			// Token: 0x0400128C RID: 4748
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_56_Internal_Single_0;

			// Token: 0x0400128D RID: 4749
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__171_57_Internal_Single_0;
		}

		// Token: 0x020001CE RID: 462
		[ObfuscatedName("UnityEngine.Rendering.ProbeReferenceVolume+<>c__DisplayClass171_0")]
		public sealed class __c__DisplayClass171_0 : Object
		{
			// Token: 0x060019A0 RID: 6560 RVA: 0x0006AE0C File Offset: 0x0006900C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass171_0()
			{
				Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<>c__DisplayClass171_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, "<>4__this");
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, "parameters");
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664923);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_Void_Field_1_T_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664924);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664925);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664926);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664927);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__4_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664928);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__5_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664929);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__6_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664930);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__8_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664931);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__9_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664932);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__10_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664933);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__11_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664934);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__12_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664935);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__13_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664936);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__14_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664937);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__15_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664938);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__18_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664939);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__19_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664940);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__20_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664941);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__21_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664942);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__24_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664943);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__25_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664944);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__28_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664945);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__29_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664946);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__30_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664947);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__31_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664948);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__34_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664949);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__35_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664950);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__37_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664951);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__38_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664952);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664953);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__50_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664954);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__51_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664955);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__52_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664956);
				ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__53_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr, 100664957);
			}

			// Token: 0x060019A1 RID: 6561 RVA: 0x0006B11C File Offset: 0x0006931C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass171_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019A2 RID: 6562 RVA: 0x0006B158 File Offset: 0x00069358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967141, XrefRangeEnd = 967143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Field_1_T_T_PDM_0<T>(DebugUI.Field<T> field, T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.MethodInfoStoreGeneric_Method_Internal_Void_Field_1_T_T_PDM_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060019A3 RID: 6563 RVA: 0x0006B1E4 File Offset: 0x000693E4
			[CallerCount(0)]
			public unsafe bool _RegisterDebug_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019A4 RID: 6564 RVA: 0x0006B220 File Offset: 0x00069420
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__2(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019A5 RID: 6565 RVA: 0x0006B260 File Offset: 0x00069460
			[CallerCount(0)]
			public unsafe bool _RegisterDebug_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019A6 RID: 6566 RVA: 0x0006B29C File Offset: 0x0006949C
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__4(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__4_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019A7 RID: 6567 RVA: 0x0006B2DC File Offset: 0x000694DC
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__5_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019A8 RID: 6568 RVA: 0x0006B318 File Offset: 0x00069518
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__6(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__6_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019A9 RID: 6569 RVA: 0x0006B358 File Offset: 0x00069558
			[CallerCount(0)]
			public unsafe bool _RegisterDebug_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__8_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019AA RID: 6570 RVA: 0x0006B394 File Offset: 0x00069594
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__9(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__9_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019AB RID: 6571 RVA: 0x0006B3D4 File Offset: 0x000695D4
			[CallerCount(0)]
			public unsafe int _RegisterDebug_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__10_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019AC RID: 6572 RVA: 0x0006B410 File Offset: 0x00069610
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__11(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__11_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019AD RID: 6573 RVA: 0x0006B450 File Offset: 0x00069650
			[CallerCount(0)]
			public unsafe int _RegisterDebug_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__12_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019AE RID: 6574 RVA: 0x0006B48C File Offset: 0x0006968C
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__13(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__13_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019AF RID: 6575 RVA: 0x0006B4CC File Offset: 0x000696CC
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__14_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019B0 RID: 6576 RVA: 0x0006B508 File Offset: 0x00069708
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__15(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__15_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B1 RID: 6577 RVA: 0x0006B548 File Offset: 0x00069748
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__18_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019B2 RID: 6578 RVA: 0x0006B584 File Offset: 0x00069784
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__19(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__19_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B3 RID: 6579 RVA: 0x0006B5C4 File Offset: 0x000697C4
			[CallerCount(0)]
			public unsafe int _RegisterDebug_b__20()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__20_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019B4 RID: 6580 RVA: 0x0006B600 File Offset: 0x00069800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967143, XrefRangeEnd = 967150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__21(int v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__21_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B5 RID: 6581 RVA: 0x0006B640 File Offset: 0x00069840
			[CallerCount(0)]
			public unsafe int _RegisterDebug_b__24()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__24_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019B6 RID: 6582 RVA: 0x0006B67C File Offset: 0x0006987C
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__25(int v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__25_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B7 RID: 6583 RVA: 0x0006B6BC File Offset: 0x000698BC
			[CallerCount(0)]
			public unsafe bool _RegisterDebug_b__28()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__28_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019B8 RID: 6584 RVA: 0x0006B6F8 File Offset: 0x000698F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967150, XrefRangeEnd = 967155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__29(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__29_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B9 RID: 6585 RVA: 0x0006B738 File Offset: 0x00069938
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__30()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__30_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019BA RID: 6586 RVA: 0x0006B774 File Offset: 0x00069974
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__31(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__31_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019BB RID: 6587 RVA: 0x0006B7B4 File Offset: 0x000699B4
			[CallerCount(0)]
			public unsafe float _RegisterDebug_b__34()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__34_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019BC RID: 6588 RVA: 0x0006B7F0 File Offset: 0x000699F0
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__35(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__35_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019BD RID: 6589 RVA: 0x0006B830 File Offset: 0x00069A30
			[CallerCount(0)]
			public unsafe bool _RegisterDebug_b__37()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__37_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019BE RID: 6590 RVA: 0x0006B86C File Offset: 0x00069A6C
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__38(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__38_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019BF RID: 6591 RVA: 0x0006B8AC File Offset: 0x00069AAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 967240, RefRangeEnd = 967241, XrefRangeStart = 967155, XrefRangeEnd = 967240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_String_0(string guid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019C0 RID: 6592 RVA: 0x0006B8F0 File Offset: 0x00069AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967241, XrefRangeEnd = 967263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegisterDebug_b__50()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__50_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019C1 RID: 6593 RVA: 0x0006B92C File Offset: 0x00069B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967263, XrefRangeEnd = 967266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__51(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__51_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019C2 RID: 6594 RVA: 0x0006B96C File Offset: 0x00069B6C
			[CallerCount(0)]
			public unsafe int _RegisterDebug_b__52()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__52_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019C3 RID: 6595 RVA: 0x0006B9A8 File Offset: 0x00069BA8
			[CallerCount(0)]
			public unsafe void _RegisterDebug_b__53(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr__RegisterDebug_b__53_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019C4 RID: 6596 RVA: 0x0000CD44 File Offset: 0x0000AF44
			public __c__DisplayClass171_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0006B9E8 File Offset: 0x00069BE8
			// (set) Token: 0x060019C6 RID: 6598 RVA: 0x0000CD4D File Offset: 0x0000AF4D
			public unsafe ProbeReferenceVolume __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.__c__DisplayClass171_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.__c__DisplayClass171_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0006BA18 File Offset: 0x00069C18
			// (set) Token: 0x060019C8 RID: 6600 RVA: 0x0000CD6C File Offset: 0x0000AF6C
			public ProbeVolumeSystemParameters parameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.__c__DisplayClass171_0.NativeFieldInfoPtr_parameters);
					return new ProbeVolumeSystemParameters(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolume.__c__DisplayClass171_0.NativeFieldInfoPtr_parameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400128E RID: 4750
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400128F RID: 4751
			private static readonly IntPtr NativeFieldInfoPtr_parameters;

			// Token: 0x04001290 RID: 4752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001291 RID: 4753
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Field_1_T_T_PDM_0;

			// Token: 0x04001292 RID: 4754
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__1_Internal_Boolean_0;

			// Token: 0x04001293 RID: 4755
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__2_Internal_Void_Boolean_0;

			// Token: 0x04001294 RID: 4756
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__3_Internal_Boolean_0;

			// Token: 0x04001295 RID: 4757
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__4_Internal_Void_Boolean_0;

			// Token: 0x04001296 RID: 4758
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__5_Internal_Single_0;

			// Token: 0x04001297 RID: 4759
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__6_Internal_Void_Single_0;

			// Token: 0x04001298 RID: 4760
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__8_Internal_Boolean_0;

			// Token: 0x04001299 RID: 4761
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__9_Internal_Void_Boolean_0;

			// Token: 0x0400129A RID: 4762
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_Internal_Int32_0;

			// Token: 0x0400129B RID: 4763
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__11_Internal_Void_Int32_0;

			// Token: 0x0400129C RID: 4764
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__12_Internal_Int32_0;

			// Token: 0x0400129D RID: 4765
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__13_Internal_Void_Int32_0;

			// Token: 0x0400129E RID: 4766
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__14_Internal_Single_0;

			// Token: 0x0400129F RID: 4767
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__15_Internal_Void_Single_0;

			// Token: 0x040012A0 RID: 4768
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__18_Internal_Single_0;

			// Token: 0x040012A1 RID: 4769
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__19_Internal_Void_Single_0;

			// Token: 0x040012A2 RID: 4770
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__20_Internal_Int32_0;

			// Token: 0x040012A3 RID: 4771
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__21_Internal_Void_Int32_0;

			// Token: 0x040012A4 RID: 4772
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__24_Internal_Int32_0;

			// Token: 0x040012A5 RID: 4773
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__25_Internal_Void_Int32_0;

			// Token: 0x040012A6 RID: 4774
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__28_Internal_Boolean_0;

			// Token: 0x040012A7 RID: 4775
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__29_Internal_Void_Boolean_0;

			// Token: 0x040012A8 RID: 4776
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__30_Internal_Single_0;

			// Token: 0x040012A9 RID: 4777
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__31_Internal_Void_Single_0;

			// Token: 0x040012AA RID: 4778
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__34_Internal_Single_0;

			// Token: 0x040012AB RID: 4779
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__35_Internal_Void_Single_0;

			// Token: 0x040012AC RID: 4780
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__37_Internal_Boolean_0;

			// Token: 0x040012AD RID: 4781
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__38_Internal_Void_Boolean_0;

			// Token: 0x040012AE RID: 4782
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_String_0;

			// Token: 0x040012AF RID: 4783
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__50_Internal_Int32_0;

			// Token: 0x040012B0 RID: 4784
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__51_Internal_Void_Int32_0;

			// Token: 0x040012B1 RID: 4785
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__52_Internal_Int32_0;

			// Token: 0x040012B2 RID: 4786
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__53_Internal_Void_Int32_0;

			// Token: 0x02000237 RID: 567
			private sealed class MethodInfoStoreGeneric_Method_Internal_Void_Field_1_T_T_PDM_0<T>
			{
				// Token: 0x0400144E RID: 5198
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProbeReferenceVolume.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_Void_Field_1_T_T_PDM_0, Il2CppClassPointerStore<ProbeReferenceVolume.__c__DisplayClass171_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x020001CF RID: 463
		private sealed class MethodInfoStoreGeneric_DebugCellIndexChanged_Private_Void_Field_1_T_T_0<T>
		{
			// Token: 0x040012B3 RID: 4787
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProbeReferenceVolume.NativeMethodInfoPtr_DebugCellIndexChanged_Private_Void_Field_1_T_T_0, Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
