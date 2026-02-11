using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x0200000A RID: 10
	public class AddressablesImpl : Object
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00008F00 File Offset: 0x00007100
		// Note: this type is marked as 'beforefieldinit'.
		static AddressablesImpl()
		{
			Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AddressablesImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr);
			AddressablesImpl.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_ResourceManager");
			AddressablesImpl.NativeFieldInfoPtr_m_InstanceProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_InstanceProvider");
			AddressablesImpl.NativeFieldInfoPtr_m_CatalogRequestsTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_CatalogRequestsTimeout");
			AddressablesImpl.NativeFieldInfoPtr_kCacheDataFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "kCacheDataFolder");
			AddressablesImpl.NativeFieldInfoPtr_SceneProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "SceneProvider");
			AddressablesImpl.NativeFieldInfoPtr_m_ResourceLocators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_ResourceLocators");
			AddressablesImpl.NativeFieldInfoPtr_m_InitializationOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_InitializationOperation");
			AddressablesImpl.NativeFieldInfoPtr_m_ActiveCheckUpdateOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_ActiveCheckUpdateOperation");
			AddressablesImpl.NativeFieldInfoPtr_m_ActiveUpdateOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_ActiveUpdateOperation");
			AddressablesImpl.NativeFieldInfoPtr_m_OnHandleCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_OnHandleCompleteAction");
			AddressablesImpl.NativeFieldInfoPtr_m_OnSceneHandleCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_OnSceneHandleCompleteAction");
			AddressablesImpl.NativeFieldInfoPtr_m_OnHandleDestroyedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_OnHandleDestroyedAction");
			AddressablesImpl.NativeFieldInfoPtr_m_resultToHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_resultToHandle");
			AddressablesImpl.NativeFieldInfoPtr_m_SceneInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_SceneInstances");
			AddressablesImpl.NativeFieldInfoPtr_m_ActiveCleanBundleCacheOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "m_ActiveCleanBundleCacheOperation");
			AddressablesImpl.NativeFieldInfoPtr_hasStartedInitialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "hasStartedInitialization");
			AddressablesImpl.NativeMethodInfoPtr_get_InstanceProvider_Public_get_IInstanceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663470);
			AddressablesImpl.NativeMethodInfoPtr_set_InstanceProvider_Public_set_Void_IInstanceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663471);
			AddressablesImpl.NativeMethodInfoPtr_get_ResourceManager_Public_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663472);
			AddressablesImpl.NativeMethodInfoPtr_get_CatalogRequestsTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663473);
			AddressablesImpl.NativeMethodInfoPtr_set_CatalogRequestsTimeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663474);
			AddressablesImpl.NativeMethodInfoPtr_get_SceneOperationCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663475);
			AddressablesImpl.NativeMethodInfoPtr_get_TrackedHandleCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663476);
			AddressablesImpl.NativeMethodInfoPtr__ctor_Public_Void_IAllocationStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663477);
			AddressablesImpl.NativeMethodInfoPtr_ReleaseSceneManagerOperation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663478);
			AddressablesImpl.NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_get_Func_2_IResourceLocation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663479);
			AddressablesImpl.NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_set_Void_Func_2_IResourceLocation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663480);
			AddressablesImpl.NativeMethodInfoPtr_get_WebRequestOverride_Public_get_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663481);
			AddressablesImpl.NativeMethodInfoPtr_set_WebRequestOverride_Public_set_Void_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663482);
			AddressablesImpl.NativeMethodInfoPtr_get_ChainOperation_Public_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663483);
			AddressablesImpl.NativeMethodInfoPtr_get_ShouldChainRequest_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663484);
			AddressablesImpl.NativeMethodInfoPtr_OnSceneUnloaded_Internal_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663485);
			AddressablesImpl.NativeMethodInfoPtr_get_StreamingAssetsSubFolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663486);
			AddressablesImpl.NativeMethodInfoPtr_get_BuildPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663487);
			AddressablesImpl.NativeMethodInfoPtr_get_PlayerBuildDataPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663488);
			AddressablesImpl.NativeMethodInfoPtr_get_RuntimePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663489);
			AddressablesImpl.NativeMethodInfoPtr_Log_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663490);
			AddressablesImpl.NativeMethodInfoPtr_LogFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663491);
			AddressablesImpl.NativeMethodInfoPtr_LogWarning_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663492);
			AddressablesImpl.NativeMethodInfoPtr_LogWarningFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663493);
			AddressablesImpl.NativeMethodInfoPtr_LogError_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663494);
			AddressablesImpl.NativeMethodInfoPtr_LogException_Public_Void_AsyncOperationHandle_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663495);
			AddressablesImpl.NativeMethodInfoPtr_LogException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663496);
			AddressablesImpl.NativeMethodInfoPtr_LogErrorFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663497);
			AddressablesImpl.NativeMethodInfoPtr_ResolveInternalId_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663498);
			AddressablesImpl.NativeMethodInfoPtr_get_ResourceLocators_Public_get_IEnumerable_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663499);
			AddressablesImpl.NativeMethodInfoPtr_AddResourceLocator_Public_Void_IResourceLocator_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663500);
			AddressablesImpl.NativeMethodInfoPtr_RemoveResourceLocator_Public_Void_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663501);
			AddressablesImpl.NativeMethodInfoPtr_ClearResourceLocators_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663502);
			AddressablesImpl.NativeMethodInfoPtr_GetResourceLocations_Internal_Boolean_Object_Type_byref_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663503);
			AddressablesImpl.NativeMethodInfoPtr_GetResourceLocations_Internal_Boolean_IEnumerable_Type_MergeMode_byref_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663504);
			AddressablesImpl.NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663505);
			AddressablesImpl.NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663506);
			AddressablesImpl.NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663507);
			AddressablesImpl.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663508);
			AddressablesImpl.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663509);
			AddressablesImpl.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663510);
			AddressablesImpl.NativeMethodInfoPtr_QueueEditorUpdateIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663511);
			AddressablesImpl.NativeMethodInfoPtr_LoadContentCatalogAsync_Public_AsyncOperationHandle_1_IResourceLocator_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663512);
			AddressablesImpl.NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663513);
			AddressablesImpl.NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663514);
			AddressablesImpl.NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663515);
			AddressablesImpl.NativeMethodInfoPtr_ClearTrackHandles_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663516);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663517);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663518);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663519);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663520);
			AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsWithChain_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_IEnumerable_MergeMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663521);
			AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663522);
			AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsWithChain_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663523);
			AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663524);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663525);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IList_1_IResourceLocation_Action_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663526);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IEnumerable_Action_1_TObject_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663527);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663528);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_Object_Action_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663529);
			AddressablesImpl.NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663530);
			AddressablesImpl.NativeMethodInfoPtr_OnHandleDestroyed_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663531);
			AddressablesImpl.NativeMethodInfoPtr_OnSceneHandleCompleted_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663532);
			AddressablesImpl.NativeMethodInfoPtr_OnHandleCompleted_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663533);
			AddressablesImpl.NativeMethodInfoPtr_Release_Public_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663534);
			AddressablesImpl.NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663535);
			AddressablesImpl.NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663536);
			AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeWithChain_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663537);
			AddressablesImpl.NativeMethodInfoPtr_ComputeCatalogSizeWithChain_Private_AsyncOperationHandle_1_Int64_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663538);
			AddressablesImpl.NativeMethodInfoPtr_IsCatalogCached_Internal_Boolean_IResourceLocation_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663539);
			AddressablesImpl.NativeMethodInfoPtr_GetRemoteCatalogHeaderSize_Internal_AsyncOperationHandle_1_Int64_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663540);
			AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeWithChain_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663541);
			AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_AsyncOperationHandle_1_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663542);
			AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_AsyncOperationHandle_1_Int64_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663543);
			AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663544);
			AddressablesImpl.NativeMethodInfoPtr_WrapAsDownloadLocations_Internal_Static_Void_List_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663545);
			AddressablesImpl.NativeMethodInfoPtr_GatherDependenciesFromLocations_Private_Static_List_1_IResourceLocation_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663546);
			AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663547);
			AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663548);
			AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663549);
			AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663550);
			AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663551);
			AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheForKey_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663552);
			AddressablesImpl.NativeMethodInfoPtr_AutoReleaseHandleOnTypelessCompletion_Internal_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663553);
			AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663554);
			AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_IList_1_IResourceLocation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663555);
			AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_IEnumerable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663556);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663557);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663558);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663559);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663560);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateWithChain_Private_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_Object_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663561);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663562);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateWithChain_Private_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_IResourceLocation_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663563);
			AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663564);
			AddressablesImpl.NativeMethodInfoPtr_ReleaseInstance_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663565);
			AddressablesImpl.NativeMethodInfoPtr_LoadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Object_LoadSceneParameters_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663566);
			AddressablesImpl.NativeMethodInfoPtr_LoadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_IResourceLocation_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663567);
			AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663568);
			AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneParameters_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663569);
			AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663570);
			AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663571);
			AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneParameters_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663572);
			AddressablesImpl.NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_SceneInstance_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663573);
			AddressablesImpl.NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663574);
			AddressablesImpl.NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663575);
			AddressablesImpl.NativeMethodInfoPtr_CreateUnloadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663576);
			AddressablesImpl.NativeMethodInfoPtr_CreateUnloadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663577);
			AddressablesImpl.NativeMethodInfoPtr_InternalUnloadScene_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663578);
			AddressablesImpl.NativeMethodInfoPtr_EvaluateKey_Private_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663579);
			AddressablesImpl.NativeMethodInfoPtr_CheckForCatalogUpdates_Internal_AsyncOperationHandle_1_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663580);
			AddressablesImpl.NativeMethodInfoPtr_CheckForCatalogUpdatesWithChain_Internal_AsyncOperationHandle_1_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663581);
			AddressablesImpl.NativeMethodInfoPtr_GetLocatorInfo_Public_ResourceLocatorInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663582);
			AddressablesImpl.NativeMethodInfoPtr_get_CatalogsWithAvailableUpdates_Internal_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663583);
			AddressablesImpl.NativeMethodInfoPtr_UpdateCatalogs_Internal_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663584);
			AddressablesImpl.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IResourceLocation_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663585);
			AddressablesImpl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663586);
			AddressablesImpl.NativeMethodInfoPtr_CleanBundleCache_Internal_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663587);
			AddressablesImpl.NativeMethodInfoPtr_CleanBundleCache_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663588);
			AddressablesImpl.NativeMethodInfoPtr_CleanBundleCacheWithChain_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663589);
			AddressablesImpl.NativeMethodInfoPtr_CleanBundleCacheWithChain_Internal_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663590);
			AddressablesImpl.NativeMethodInfoPtr__TrackHandle_b__73_0_Private_Void_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663591);
			AddressablesImpl.NativeMethodInfoPtr__GetRemoteCatalogHeaderSize_b__102_0_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, 100663592);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00009A0C File Offset: 0x00007C0C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00009A4C File Offset: 0x00007C4C
		public unsafe IInstanceProvider InstanceProvider
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_InstanceProvider_Public_get_IInstanceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInstanceProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159606, XrefRangeEnd = 1159611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_set_InstanceProvider_Public_set_Void_IInstanceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00009A90 File Offset: 0x00007C90
		public unsafe ResourceManager ResourceManager
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_ResourceManager_Public_get_ResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00009AD0 File Offset: 0x00007CD0
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00009B0C File Offset: 0x00007D0C
		public unsafe int CatalogRequestsTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_CatalogRequestsTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_set_CatalogRequestsTimeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00009B4C File Offset: 0x00007D4C
		public unsafe int SceneOperationCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159611, XrefRangeEnd = 1159612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_SceneOperationCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00009B88 File Offset: 0x00007D88
		public unsafe int TrackedHandleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159612, XrefRangeEnd = 1159616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_TrackedHandleCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00009BC4 File Offset: 0x00007DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159616, XrefRangeEnd = 1159653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddressablesImpl(IAllocationStrategy alloc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alloc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr__ctor_Public_Void_IAllocationStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00009C10 File Offset: 0x00007E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159653, XrefRangeEnd = 1159663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseSceneManagerOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ReleaseSceneManagerOperation_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00009C44 File Offset: 0x00007E44
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00009C84 File Offset: 0x00007E84
		public unsafe Func<IResourceLocation, string> InternalIdTransformFunc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_get_Func_2_IResourceLocation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IResourceLocation, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159663, XrefRangeEnd = 1159665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_set_Void_Func_2_IResourceLocation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00009CC8 File Offset: 0x00007EC8
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00009D08 File Offset: 0x00007F08
		public unsafe Action<UnityWebRequest> WebRequestOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_WebRequestOverride_Public_get_Action_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159665, XrefRangeEnd = 1159667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_set_WebRequestOverride_Public_set_Void_Action_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00009D4C File Offset: 0x00007F4C
		public unsafe AsyncOperationHandle ChainOperation
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1159692, RefRangeEnd = 1159704, XrefRangeStart = 1159667, XrefRangeEnd = 1159692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_ChainOperation_Public_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00009D84 File Offset: 0x00007F84
		public unsafe bool ShouldChainRequest
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1159714, RefRangeEnd = 1159738, XrefRangeStart = 1159704, XrefRangeEnd = 1159714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_ShouldChainRequest_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00009DC0 File Offset: 0x00007FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159738, XrefRangeEnd = 1159781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneUnloaded(Scene scene)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_OnSceneUnloaded_Internal_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00009E00 File Offset: 0x00008000
		public unsafe string StreamingAssetsSubFolder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159781, XrefRangeEnd = 1159783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_StreamingAssetsSubFolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00009E38 File Offset: 0x00008038
		public unsafe string BuildPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1159821, RefRangeEnd = 1159822, XrefRangeStart = 1159783, XrefRangeEnd = 1159821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_BuildPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00009E70 File Offset: 0x00008070
		public unsafe string PlayerBuildDataPath
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1159831, RefRangeEnd = 1159839, XrefRangeStart = 1159822, XrefRangeEnd = 1159831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_PlayerBuildDataPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00009EA8 File Offset: 0x000080A8
		public unsafe string RuntimePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159839, XrefRangeEnd = 1159840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_RuntimePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00009EE0 File Offset: 0x000080E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1159844, RefRangeEnd = 1159845, XrefRangeStart = 1159840, XrefRangeEnd = 1159844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Log(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_Log_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00009F24 File Offset: 0x00008124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1159849, RefRangeEnd = 1159850, XrefRangeStart = 1159845, XrefRangeEnd = 1159849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LogFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00009F88 File Offset: 0x00008188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1159854, RefRangeEnd = 1159855, XrefRangeStart = 1159850, XrefRangeEnd = 1159854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogWarning(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LogWarning_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00009FCC File Offset: 0x000081CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159855, XrefRangeEnd = 1159859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LogWarningFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000A030 File Offset: 0x00008230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1159863, RefRangeEnd = 1159864, XrefRangeStart = 1159859, XrefRangeEnd = 1159863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogError(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LogError_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000A074 File Offset: 0x00008274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159864, XrefRangeEnd = 1159869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogException(AsyncOperationHandle op, Exception ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LogException_Public_Void_AsyncOperationHandle_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000A0D0 File Offset: 0x000082D0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogException(Exception ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LogException_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000A114 File Offset: 0x00008314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159869, XrefRangeEnd = 1159873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LogErrorFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000A178 File Offset: 0x00008378
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1159900, RefRangeEnd = 1159907, XrefRangeStart = 1159873, XrefRangeEnd = 1159900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ResolveInternalId(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ResolveInternalId_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public unsafe IEnumerable<IResourceLocator> ResourceLocators
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1159925, RefRangeEnd = 1159927, XrefRangeStart = 1159907, XrefRangeEnd = 1159925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_ResourceLocators_Public_get_IEnumerable_1_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IResourceLocator>>(intPtr3) : null;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000A200 File Offset: 0x00008400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1159937, RefRangeEnd = 1159941, XrefRangeStart = 1159927, XrefRangeEnd = 1159937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddResourceLocator(IResourceLocator loc, string localCatalogHash = null, IResourceLocation remoteCatalogLocation = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localCatalogHash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCatalogLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_AddResourceLocator_Public_Void_IResourceLocator_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000A268 File Offset: 0x00008468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1159956, RefRangeEnd = 1159959, XrefRangeStart = 1159941, XrefRangeEnd = 1159956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveResourceLocator(IResourceLocator loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_RemoveResourceLocator_Public_Void_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000A2AC File Offset: 0x000084AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159959, XrefRangeEnd = 1159961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResourceLocators()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ClearResourceLocators_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000A2E0 File Offset: 0x000084E0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1160024, RefRangeEnd = 1160033, XrefRangeStart = 1159961, XrefRangeEnd = 1160024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetResourceLocations(Object key, Type type, out IList<IResourceLocation> locations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetResourceLocations_Internal_Boolean_Object_Type_byref_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			locations = ((intPtr4 == 0) ? null : new IList<IResourceLocation>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000A364 File Offset: 0x00008564
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1160066, RefRangeEnd = 1160069, XrefRangeStart = 1160033, XrefRangeEnd = 1160066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref merge;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetResourceLocations_Internal_Boolean_IEnumerable_Type_MergeMode_byref_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			locations = ((intPtr4 == 0) ? null : new IList<IResourceLocation>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1160128, RefRangeEnd = 1160133, XrefRangeStart = 1160069, XrefRangeEnd = 1160128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix = null, bool autoReleaseHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(runtimeDataPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000A460 File Offset: 0x00008660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160133, XrefRangeEnd = 1160139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IResourceLocator> InitializeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000A498 File Offset: 0x00008698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160139, XrefRangeEnd = 1160145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoReleaseHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<IResourceLocator>(intPtr);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000A4DC File Offset: 0x000086DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160145, XrefRangeEnd = 1160151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation catalogLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogLocation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_IResourceLocation_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationBase>(intPtr3) : null;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000A52C File Offset: 0x0000872C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1160163, RefRangeEnd = 1160164, XrefRangeStart = 1160151, XrefRangeEnd = 1160163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(catalogLocation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationBase>(intPtr3) : null;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000A57C File Offset: 0x0000877C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1160228, RefRangeEnd = 1160229, XrefRangeStart = 1160164, XrefRangeEnd = 1160228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogPath, string hashFilePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(catalogPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hashFilePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationBase>(intPtr3) : null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000A5E0 File Offset: 0x000087E0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueEditorUpdateIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_QueueEditorUpdateIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000A614 File Offset: 0x00008814
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1160247, RefRangeEnd = 1160251, XrefRangeStart = 1160229, XrefRangeEnd = 1160247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = true, string providerSuffix = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(catalogPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadContentCatalogAsync_Public_AsyncOperationHandle_1_IResourceLocator_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000A67C File Offset: 0x0000887C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160251, XrefRangeEnd = 1160260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<SceneInstance>(intPtr);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000A6CC File Offset: 0x000088CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1160262, RefRangeEnd = 1160264, XrefRangeStart = 1160260, XrefRangeEnd = 1160262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_TrackHandle_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000A71C File Offset: 0x0000891C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160264, XrefRangeEnd = 1160265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle TrackHandle(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000A76C File Offset: 0x0000896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160265, XrefRangeEnd = 1160269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTrackHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ClearTrackHandles_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1160286, RefRangeEnd = 1160288, XrefRangeStart = 1160269, XrefRangeEnd = 1160286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160288, XrefRangeEnd = 1160298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, IResourceLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_IResourceLocation_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000A848 File Offset: 0x00008A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Object_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1160363, RefRangeEnd = 1160365, XrefRangeStart = 1160298, XrefRangeEnd = 1160363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_Object_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160365, XrefRangeEnd = 1160381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keys);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsWithChain_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_IEnumerable_MergeMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000A970 File Offset: 0x00008B70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1160397, RefRangeEnd = 1160401, XrefRangeStart = 1160381, XrefRangeEnd = 1160397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160401, XrefRangeEnd = 1160417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, Object key, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsWithChain_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000AA4C File Offset: 0x00008C4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1160433, RefRangeEnd = 1160436, XrefRangeStart = 1160417, XrefRangeEnd = 1160433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(Object key, Type type = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000AAA8 File Offset: 0x00008CA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1160454, RefRangeEnd = 1160459, XrefRangeStart = 1160436, XrefRangeEnd = 1160454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000AB10 File Offset: 0x00008D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160459, XrefRangeEnd = 1160470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IList_1_IResourceLocation_Action_1_TObject_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000AB90 File Offset: 0x00008D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160470, XrefRangeEnd = 1160478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keys);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IEnumerable_Action_1_TObject_MergeMode_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000AC20 File Offset: 0x00008E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160478, XrefRangeEnd = 1160486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000AC98 File Offset: 0x00008E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, Object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_Object_Action_1_TObject_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000AD18 File Offset: 0x00008F18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1160518, RefRangeEnd = 1160520, XrefRangeStart = 1160486, XrefRangeEnd = 1160518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(Object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000AD80 File Offset: 0x00008F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160520, XrefRangeEnd = 1160525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHandleDestroyed(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_OnHandleDestroyed_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160525, XrefRangeEnd = 1160538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneHandleCompleted(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_OnSceneHandleCompleted_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000AE10 File Offset: 0x00009010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160538, XrefRangeEnd = 1160548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHandleCompleted(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_OnHandleCompleted_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000AE58 File Offset: 0x00009058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160548, XrefRangeEnd = 1160566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release<TObject>(TObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = obj;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_Release_Public_Void_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000AED0 File Offset: 0x000090D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160566, XrefRangeEnd = 1160568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release<TObject>(AsyncOperationHandle<TObject> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_Release_Public_Void_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000AF18 File Offset: 0x00009118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160568, XrefRangeEnd = 1160569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000AF60 File Offset: 0x00009160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160569, XrefRangeEnd = 1160584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeWithChain_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<long>(intPtr);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000AFC0 File Offset: 0x000091C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1160616, RefRangeEnd = 1160617, XrefRangeStart = 1160584, XrefRangeEnd = 1160616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<long> ComputeCatalogSizeWithChain(IResourceLocation catalogLoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogLoc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ComputeCatalogSizeWithChain_Private_AsyncOperationHandle_1_Int64_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000B008 File Offset: 0x00009208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1160642, RefRangeEnd = 1160643, XrefRangeStart = 1160617, XrefRangeEnd = 1160642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCatalogCached(IResourceLocation catalogLoc, Hash128 remoteHash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogLoc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remoteHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_IsCatalogCached_Internal_Boolean_IResourceLocation_Hash128_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000B064 File Offset: 0x00009264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160643, XrefRangeEnd = 1160690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<long> GetRemoteCatalogHeaderSize(IResourceLocation catalogLoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogLoc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetRemoteCatalogHeaderSize_Internal_AsyncOperationHandle_1_Int64_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000B0AC File Offset: 0x000092AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160690, XrefRangeEnd = 1160705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keys);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeWithChain_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_IEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<long>(intPtr);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000B10C File Offset: 0x0000930C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160705, XrefRangeEnd = 1160711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<long> GetDownloadSizeAsync(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_AsyncOperationHandle_1_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000B154 File Offset: 0x00009354
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1160847, RefRangeEnd = 1160855, XrefRangeStart = 1160711, XrefRangeEnd = 1160847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_AsyncOperationHandle_1_Int64_IEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000B19C File Offset: 0x0000939C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160855, XrefRangeEnd = 1160876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, Object key, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000B20C File Offset: 0x0000940C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1160888, RefRangeEnd = 1160891, XrefRangeStart = 1160876, XrefRangeEnd = 1160888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WrapAsDownloadLocations(List<IResourceLocation> locations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_WrapAsDownloadLocations_Internal_Static_Void_List_1_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000B244 File Offset: 0x00009444
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1160957, RefRangeEnd = 1160961, XrefRangeStart = 1160891, XrefRangeEnd = 1160957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GatherDependenciesFromLocations_Private_Static_List_1_IResourceLocation_IList_1_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IResourceLocation>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000B288 File Offset: 0x00009488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1160994, RefRangeEnd = 1160997, XrefRangeStart = 1160961, XrefRangeEnd = 1160994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle DownloadDependenciesAsync(Object key, bool autoReleaseHandle = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160997, XrefRangeEnd = 1161018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000B350 File Offset: 0x00009550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1161051, RefRangeEnd = 1161053, XrefRangeStart = 1161018, XrefRangeEnd = 1161051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000B3A8 File Offset: 0x000095A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161053, XrefRangeEnd = 1161074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keys);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000B424 File Offset: 0x00009624
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161137, RefRangeEnd = 1161140, XrefRangeStart = 1161074, XrefRangeEnd = 1161137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000B488 File Offset: 0x00009688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161219, RefRangeEnd = 1161222, XrefRangeStart = 1161140, XrefRangeEnd = 1161219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ClearDependencyCacheForKey(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheForKey_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1161237, RefRangeEnd = 1161238, XrefRangeStart = 1161222, XrefRangeEnd = 1161237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoReleaseHandleOnTypelessCompletion<TObject>(AsyncOperationHandle<TObject> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.MethodInfoStoreGeneric_AutoReleaseHandleOnTypelessCompletion_Internal_Void_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000B520 File Offset: 0x00009720
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1161260, RefRangeEnd = 1161265, XrefRangeStart = 1161238, XrefRangeEnd = 1161260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> ClearDependencyCacheAsync(Object key, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000B578 File Offset: 0x00009778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161305, RefRangeEnd = 1161308, XrefRangeStart = 1161265, XrefRangeEnd = 1161305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_IList_1_IResourceLocation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000B5D0 File Offset: 0x000097D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1161348, RefRangeEnd = 1161353, XrefRangeStart = 1161308, XrefRangeEnd = 1161348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_IEnumerable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000B628 File Offset: 0x00009828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161353, XrefRangeEnd = 1161355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161355, XrefRangeEnd = 1161357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000B728 File Offset: 0x00009928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161357, XrefRangeEnd = 1161359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateAsync(Object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000B7A0 File Offset: 0x000099A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161359, XrefRangeEnd = 1161361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateAsync(Object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000B828 File Offset: 0x00009A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161361, XrefRangeEnd = 1161380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, Object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateWithChain_Private_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_Object_InstantiationParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B8AC File Offset: 0x00009AAC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1161423, RefRangeEnd = 1161430, XrefRangeStart = 1161380, XrefRangeEnd = 1161423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateAsync(Object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000B91C File Offset: 0x00009B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161430, XrefRangeEnd = 1161449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateWithChain_Private_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_IResourceLocation_InstantiationParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1161476, RefRangeEnd = 1161484, XrefRangeStart = 1161449, XrefRangeEnd = 1161476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000BA10 File Offset: 0x00009C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161484, XrefRangeEnd = 1161493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReleaseInstance(GameObject instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_ReleaseInstance_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000BA60 File Offset: 0x00009C60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1161517, RefRangeEnd = 1161519, XrefRangeStart = 1161493, XrefRangeEnd = 1161517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, Object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Object_LoadSceneParameters_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000BAEC File Offset: 0x00009CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161519, XrefRangeEnd = 1161543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, IResourceLocation key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dep));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_IResourceLocation_LoadSceneMode_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000BB78 File Offset: 0x00009D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161543, XrefRangeEnd = 1161545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadSceneAsync(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<SceneInstance>(intPtr);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000BBC0 File Offset: 0x00009DC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1161559, RefRangeEnd = 1161563, XrefRangeStart = 1161545, XrefRangeEnd = 1161559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadSceneAsync(Object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneParameters_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000BC40 File Offset: 0x00009E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161563, XrefRangeEnd = 1161565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<SceneInstance>(intPtr);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000BC88 File Offset: 0x00009E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161565, XrefRangeEnd = 1161567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000BD08 File Offset: 0x00009F08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1161581, RefRangeEnd = 1161587, XrefRangeStart = 1161567, XrefRangeEnd = 1161581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneParameters_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000BD88 File Offset: 0x00009F88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161601, RefRangeEnd = 1161604, XrefRangeStart = 1161587, XrefRangeEnd = 1161601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions = UnloadSceneOptions.None, bool autoReleaseHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(scene));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_SceneInstance_UnloadSceneOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1161613, RefRangeEnd = 1161619, XrefRangeStart = 1161604, XrefRangeEnd = 1161613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions = UnloadSceneOptions.None, bool autoReleaseHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000BE60 File Offset: 0x0000A060
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161624, RefRangeEnd = 1161627, XrefRangeStart = 1161619, XrefRangeEnd = 1161624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions = UnloadSceneOptions.None, bool autoReleaseHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000BECC File Offset: 0x0000A0CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1161641, RefRangeEnd = 1161643, XrefRangeStart = 1161627, XrefRangeEnd = 1161641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CreateUnloadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000BF38 File Offset: 0x0000A138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161643, XrefRangeEnd = 1161657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CreateUnloadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161657, XrefRangeEnd = 1161661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_InternalUnloadScene_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000C010 File Offset: 0x0000A210
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161664, RefRangeEnd = 1161667, XrefRangeStart = 1161661, XrefRangeEnd = 1161664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EvaluateKey(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_EvaluateKey_Private_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000C060 File Offset: 0x0000A260
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161686, RefRangeEnd = 1161689, XrefRangeStart = 1161667, XrefRangeEnd = 1161686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoReleaseHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CheckForCatalogUpdates_Internal_AsyncOperationHandle_1_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<List<string>>(intPtr);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161689, XrefRangeEnd = 1161704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<List<string>> CheckForCatalogUpdatesWithChain(bool autoReleaseHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoReleaseHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CheckForCatalogUpdatesWithChain_Internal_AsyncOperationHandle_1_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<List<string>>(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1161718, RefRangeEnd = 1161722, XrefRangeStart = 1161704, XrefRangeEnd = 1161718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocatorInfo GetLocatorInfo(string c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetLocatorInfo_Public_ResourceLocatorInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocatorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000C138 File Offset: 0x0000A338
		public unsafe IEnumerable<string> CatalogsWithAvailableUpdates
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1161757, RefRangeEnd = 1161759, XrefRangeStart = 1161722, XrefRangeEnd = 1161757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_get_CatalogsWithAvailableUpdates_Internal_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000C178 File Offset: 0x0000A378
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161783, RefRangeEnd = 1161786, XrefRangeStart = 1161759, XrefRangeEnd = 1161783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogIds = null, bool autoReleaseHandle = true, bool autoCleanBundleCache = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoCleanBundleCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_UpdateCatalogs_Internal_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<List<IResourceLocator>>(intPtr);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161786, XrefRangeEnd = 1161801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(IResourceLocation x, IResourceLocation y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IResourceLocation_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000C23C File Offset: 0x0000A43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161801, XrefRangeEnd = 1161806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(IResourceLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000C28C File Offset: 0x0000A48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1161859, RefRangeEnd = 1161861, XrefRangeStart = 1161806, XrefRangeEnd = 1161859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogIds, bool forceSingleThreading)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSingleThreading;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CleanBundleCache_Internal_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1161874, RefRangeEnd = 1161877, XrefRangeStart = 1161861, XrefRangeEnd = 1161874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> CleanBundleCache(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSingleThreading;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CleanBundleCache_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000C340 File Offset: 0x0000A540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161877, XrefRangeEnd = 1161893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> CleanBundleCacheWithChain(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSingleThreading;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CleanBundleCacheWithChain_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000C39C File Offset: 0x0000A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161893, XrefRangeEnd = 1161909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> CleanBundleCacheWithChain(IEnumerable<string> catalogIds, bool forceSingleThreading)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSingleThreading;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr_CleanBundleCacheWithChain_Internal_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161909, XrefRangeEnd = 1161912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TrackHandle_b__73_0(AsyncOperationHandle<SceneInstance> sceneHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr__TrackHandle_b__73_0_Private_Void_AsyncOperationHandle_1_SceneInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000C43C File Offset: 0x0000A63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161912, XrefRangeEnd = 1161925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<long> _GetRemoteCatalogHeaderSize_b__102_0(AsyncOperationHandle<UnityWebRequest> getOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(getOp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.NativeMethodInfoPtr__GetRemoteCatalogHeaderSize_b__102_0_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002346 File Offset: 0x00000546
		public void LogFormat(string format, params Object[] args)
		{
			this.LogFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002355 File Offset: 0x00000555
		public void LogWarningFormat(string format, params Object[] args)
		{
			this.LogWarningFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002364 File Offset: 0x00000564
		public void LogErrorFormat(string format, params Object[] args)
		{
			this.LogErrorFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002373 File Offset: 0x00000573
		public AddressablesImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000C48C File Offset: 0x0000A68C
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000237C File Offset: 0x0000057C
		public unsafe ResourceManager m_ResourceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ResourceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000239B File Offset: 0x0000059B
		public unsafe IInstanceProvider m_InstanceProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_InstanceProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInstanceProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_InstanceProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000023BA File Offset: 0x000005BA
		public unsafe int m_CatalogRequestsTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_CatalogRequestsTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_CatalogRequestsTimeout)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000C514 File Offset: 0x0000A714
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000023D5 File Offset: 0x000005D5
		public unsafe static string kCacheDataFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.NativeFieldInfoPtr_kCacheDataFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.NativeFieldInfoPtr_kCacheDataFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000C534 File Offset: 0x0000A734
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000023E7 File Offset: 0x000005E7
		public unsafe ISceneProvider SceneProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_SceneProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISceneProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_SceneProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000C564 File Offset: 0x0000A764
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002406 File Offset: 0x00000606
		public unsafe List<ResourceLocatorInfo> m_ResourceLocators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ResourceLocators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResourceLocatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ResourceLocators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000C594 File Offset: 0x0000A794
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002425 File Offset: 0x00000625
		public AsyncOperationHandle<IResourceLocator> m_InitializationOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_InitializationOperation);
				return new AsyncOperationHandle<IResourceLocator>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IResourceLocator>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_InitializationOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IResourceLocator>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002453 File Offset: 0x00000653
		public AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ActiveCheckUpdateOperation);
				return new AsyncOperationHandle<List<string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<List<string>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ActiveCheckUpdateOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<List<string>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002481 File Offset: 0x00000681
		public AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ActiveUpdateOperation);
				return new AsyncOperationHandle<List<IResourceLocator>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<List<IResourceLocator>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ActiveUpdateOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<List<IResourceLocator>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000C624 File Offset: 0x0000A824
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000024AF File Offset: 0x000006AF
		public unsafe Action<AsyncOperationHandle> m_OnHandleCompleteAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_OnHandleCompleteAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_OnHandleCompleteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000C654 File Offset: 0x0000A854
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000024CE File Offset: 0x000006CE
		public unsafe Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_OnSceneHandleCompleteAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_OnSceneHandleCompleteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000C684 File Offset: 0x0000A884
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000024ED File Offset: 0x000006ED
		public unsafe Action<AsyncOperationHandle> m_OnHandleDestroyedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_OnHandleDestroyedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_OnHandleDestroyedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000250C File Offset: 0x0000070C
		public unsafe Dictionary<Object, AsyncOperationHandle> m_resultToHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_resultToHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_resultToHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000252B File Offset: 0x0000072B
		public unsafe HashSet<AsyncOperationHandle> m_SceneInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_SceneInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_SceneInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000C714 File Offset: 0x0000A914
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000254A File Offset: 0x0000074A
		public AsyncOperationHandle<bool> m_ActiveCleanBundleCacheOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ActiveCleanBundleCacheOperation);
				return new AsyncOperationHandle<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_m_ActiveCleanBundleCacheOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000C744 File Offset: 0x0000A944
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002578 File Offset: 0x00000778
		public unsafe bool hasStartedInitialization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_hasStartedInitialization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.NativeFieldInfoPtr_hasStartedInitialization)) = value;
			}
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceProvider;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_m_CatalogRequestsTimeout;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_kCacheDataFolder;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_SceneProvider;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceLocators;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_m_InitializationOperation;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveCheckUpdateOperation;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveUpdateOperation;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_m_OnHandleCompleteAction;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSceneHandleCompleteAction;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_m_OnHandleDestroyedAction;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_m_resultToHandle;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_m_SceneInstances;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveCleanBundleCacheOperation;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_hasStartedInitialization;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceProvider_Public_get_IInstanceProvider_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_set_InstanceProvider_Public_set_Void_IInstanceProvider_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceManager_Public_get_ResourceManager_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_CatalogRequestsTimeout_Public_get_Int32_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_set_CatalogRequestsTimeout_Public_set_Void_Int32_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneOperationCount_Internal_get_Int32_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackedHandleCount_Internal_get_Int32_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAllocationStrategy_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSceneManagerOperation_Internal_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_get_Func_2_IResourceLocation_String_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_set_Void_Func_2_IResourceLocation_String_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_get_WebRequestOverride_Public_get_Action_1_UnityWebRequest_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_set_WebRequestOverride_Public_set_Void_Action_1_UnityWebRequest_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainOperation_Public_get_AsyncOperationHandle_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldChainRequest_Internal_get_Boolean_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneUnloaded_Internal_Void_Scene_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_StreamingAssetsSubFolder_Public_get_String_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildPath_Public_get_String_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerBuildDataPath_Public_get_String_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_RuntimePath_Public_get_String_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Void_String_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Void_String_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Void_String_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Void_AsyncOperationHandle_Exception_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Void_Exception_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_ResolveInternalId_Public_String_String_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceLocators_Public_get_IEnumerable_1_IResourceLocator_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceLocator_Public_Void_IResourceLocator_String_IResourceLocation_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_RemoveResourceLocator_Public_Void_IResourceLocator_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_ClearResourceLocators_Public_Void_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceLocations_Internal_Boolean_Object_Type_byref_IList_1_IResourceLocation_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceLocations_Internal_Boolean_IEnumerable_Type_MergeMode_byref_IList_1_IResourceLocation_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_String_String_Boolean_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_AsyncOperationHandle_1_IResourceLocator_Boolean_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_IResourceLocation_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_String_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_QueueEditorUpdateIfNeeded_Private_Void_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentCatalogAsync_Public_AsyncOperationHandle_1_IResourceLocator_String_Boolean_String_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_AsyncOperationHandle_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_ClearTrackHandles_Internal_Void_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_IResourceLocation_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Object_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_Object_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsWithChain_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_IEnumerable_MergeMode_Type_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsWithChain_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_Object_Type_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IList_1_IResourceLocation_Action_1_TObject_Boolean_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IEnumerable_Action_1_TObject_MergeMode_Boolean_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_Object_Action_1_TObject_Boolean_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_OnHandleDestroyed_Private_Void_AsyncOperationHandle_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneHandleCompleted_Private_Void_AsyncOperationHandle_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_OnHandleCompleted_Private_Void_AsyncOperationHandle_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_TObject_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeWithChain_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_Object_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_ComputeCatalogSizeWithChain_Private_AsyncOperationHandle_1_Int64_IResourceLocation_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_IsCatalogCached_Internal_Boolean_IResourceLocation_Hash128_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoteCatalogHeaderSize_Internal_AsyncOperationHandle_1_Int64_IResourceLocation_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeWithChain_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_IEnumerable_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeAsync_Public_AsyncOperationHandle_1_Int64_Object_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeAsync_Public_AsyncOperationHandle_1_Int64_IEnumerable_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_Object_Boolean_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_WrapAsDownloadLocations_Internal_Static_Void_List_1_IResourceLocation_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_GatherDependenciesFromLocations_Private_Static_List_1_IResourceLocation_IList_1_IResourceLocation_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_Object_Boolean_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsyncWithChain_Private_AsyncOperationHandle_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsync_Public_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheForKey_Internal_Boolean_Object_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_AutoReleaseHandleOnTypelessCompletion_Internal_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_Object_Boolean_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_IList_1_IResourceLocation_Boolean_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_AsyncOperationHandle_1_Boolean_IEnumerable_Boolean_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithChain_Private_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_Object_InstantiationParameters_Boolean_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithChain_Private_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_IResourceLocation_InstantiationParameters_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Public_Boolean_GameObject_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Object_LoadSceneParameters_Boolean_Int32_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_IResourceLocation_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_Object_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneParameters_Boolean_Int32_Boolean_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_Boolean_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneParameters_Boolean_Int32_Boolean_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_SceneInstance_UnloadSceneOptions_Boolean_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnloadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnloadSceneWithChain_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnloadScene_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateKey_Private_Object_Object_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_CheckForCatalogUpdates_Internal_AsyncOperationHandle_1_List_1_String_Boolean_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_CheckForCatalogUpdatesWithChain_Internal_AsyncOperationHandle_1_List_1_String_Boolean_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_GetLocatorInfo_Public_ResourceLocatorInfo_String_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_CatalogsWithAvailableUpdates_Internal_get_IEnumerable_1_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCatalogs_Internal_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_Boolean_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IResourceLocation_IResourceLocation_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_IResourceLocation_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_CleanBundleCache_Internal_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_Boolean_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_CleanBundleCache_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_CleanBundleCacheWithChain_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_CleanBundleCacheWithChain_Internal_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_Boolean_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr__TrackHandle_b__73_0_Private_Void_AsyncOperationHandle_1_SceneInstance_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr__GetRemoteCatalogHeaderSize_b__102_0_Private_AsyncOperationHandle_1_Int64_AsyncOperationHandle_1_UnityWebRequest_0;

		// Token: 0x02000042 RID: 66
		public class LoadResourceLocationKeyOp : AsyncOperationBase<IList<IResourceLocation>>
		{
			// Token: 0x06000393 RID: 915 RVA: 0x00013D9C File Offset: 0x00011F9C
			// Note: this type is marked as 'beforefieldinit'.
			static LoadResourceLocationKeyOp()
			{
				Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "LoadResourceLocationKeyOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr);
				AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, "m_Keys");
				AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, "m_locations");
				AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, "m_Addressables");
				AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_ResourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, "m_ResourceType");
				AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, 100663593);
				AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_Init_Public_Void_AddressablesImpl_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, 100663594);
				AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, 100663595);
				AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, 100663596);
				AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr, 100663597);
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000394 RID: 916 RVA: 0x00013E7C File Offset: 0x0001207C
			public unsafe override string DebugName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159484, XrefRangeEnd = 1159485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000395 RID: 917 RVA: 0x00013EC0 File Offset: 0x000120C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159485, XrefRangeEnd = 1159488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(AddressablesImpl aa, Type t, Object keys)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_Init_Public_Void_AddressablesImpl_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000396 RID: 918 RVA: 0x00013F28 File Offset: 0x00012128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159488, XrefRangeEnd = 1159493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000397 RID: 919 RVA: 0x00013F70 File Offset: 0x00012170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159493, XrefRangeEnd = 1159506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000398 RID: 920 RVA: 0x00013FAC File Offset: 0x000121AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159506, XrefRangeEnd = 1159509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadResourceLocationKeyOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeyOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.LoadResourceLocationKeyOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000399 RID: 921 RVA: 0x000033FA File Offset: 0x000015FA
			public LoadResourceLocationKeyOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x0600039A RID: 922 RVA: 0x00013FE8 File Offset: 0x000121E8
			// (set) Token: 0x0600039B RID: 923 RVA: 0x00003403 File Offset: 0x00001603
			public unsafe Object m_Keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_Keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_Keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x0600039C RID: 924 RVA: 0x00014018 File Offset: 0x00012218
			// (set) Token: 0x0600039D RID: 925 RVA: 0x00003422 File Offset: 0x00001622
			public unsafe IList<IResourceLocation> m_locations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_locations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_locations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x0600039E RID: 926 RVA: 0x00014048 File Offset: 0x00012248
			// (set) Token: 0x0600039F RID: 927 RVA: 0x00003441 File Offset: 0x00001641
			public unsafe AddressablesImpl m_Addressables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_Addressables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060003A0 RID: 928 RVA: 0x00014078 File Offset: 0x00012278
			// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003460 File Offset: 0x00001660
			public unsafe Type m_ResourceType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_ResourceType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeyOp.NativeFieldInfoPtr_m_ResourceType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeFieldInfoPtr_m_Keys;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeFieldInfoPtr_m_locations;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeFieldInfoPtr_m_ResourceType;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

			// Token: 0x040002BC RID: 700
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AddressablesImpl_Type_Object_0;

			// Token: 0x040002BD RID: 701
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040002BE RID: 702
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040002BF RID: 703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000043 RID: 67
		public class LoadResourceLocationKeysOp : AsyncOperationBase<IList<IResourceLocation>>
		{
			// Token: 0x060003A2 RID: 930 RVA: 0x000140A8 File Offset: 0x000122A8
			// Note: this type is marked as 'beforefieldinit'.
			static LoadResourceLocationKeysOp()
			{
				Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "LoadResourceLocationKeysOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr);
				AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, "m_Key");
				AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_MergeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, "m_MergeMode");
				AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, "m_locations");
				AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, "m_Addressables");
				AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_ResourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, "m_ResourceType");
				AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, 100663598);
				AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_Init_Public_Void_AddressablesImpl_Type_IEnumerable_MergeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, 100663599);
				AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, 100663600);
				AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, 100663601);
				AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr, 100663602);
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060003A3 RID: 931 RVA: 0x0001419C File Offset: 0x0001239C
			public unsafe override string DebugName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159509, XrefRangeEnd = 1159511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x000141E0 File Offset: 0x000123E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159511, XrefRangeEnd = 1159514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(AddressablesImpl aa, Type t, IEnumerable key, Addressables.MergeMode mergeMode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_Init_Public_Void_AddressablesImpl_Type_IEnumerable_MergeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x00014254 File Offset: 0x00012454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159514, XrefRangeEnd = 1159527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x00014290 File Offset: 0x00012490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159527, XrefRangeEnd = 1159532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x000142D8 File Offset: 0x000124D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159532, XrefRangeEnd = 1159535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadResourceLocationKeysOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.LoadResourceLocationKeysOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.LoadResourceLocationKeysOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x0000347F File Offset: 0x0000167F
			public LoadResourceLocationKeysOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060003A9 RID: 937 RVA: 0x00014314 File Offset: 0x00012514
			// (set) Token: 0x060003AA RID: 938 RVA: 0x00003488 File Offset: 0x00001688
			public unsafe IEnumerable m_Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_Key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_Key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060003AB RID: 939 RVA: 0x00014344 File Offset: 0x00012544
			// (set) Token: 0x060003AC RID: 940 RVA: 0x000034A7 File Offset: 0x000016A7
			public unsafe Addressables.MergeMode m_MergeMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_MergeMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_MergeMode)) = value;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060003AD RID: 941 RVA: 0x0001436C File Offset: 0x0001256C
			// (set) Token: 0x060003AE RID: 942 RVA: 0x000034C2 File Offset: 0x000016C2
			public unsafe IList<IResourceLocation> m_locations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_locations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_locations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060003AF RID: 943 RVA: 0x0001439C File Offset: 0x0001259C
			// (set) Token: 0x060003B0 RID: 944 RVA: 0x000034E1 File Offset: 0x000016E1
			public unsafe AddressablesImpl m_Addressables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_Addressables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x000143CC File Offset: 0x000125CC
			// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003500 File Offset: 0x00001700
			public unsafe Type m_ResourceType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_ResourceType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.LoadResourceLocationKeysOp.NativeFieldInfoPtr_m_ResourceType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002C0 RID: 704
			private static readonly IntPtr NativeFieldInfoPtr_m_Key;

			// Token: 0x040002C1 RID: 705
			private static readonly IntPtr NativeFieldInfoPtr_m_MergeMode;

			// Token: 0x040002C2 RID: 706
			private static readonly IntPtr NativeFieldInfoPtr_m_locations;

			// Token: 0x040002C3 RID: 707
			private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

			// Token: 0x040002C4 RID: 708
			private static readonly IntPtr NativeFieldInfoPtr_m_ResourceType;

			// Token: 0x040002C5 RID: 709
			private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

			// Token: 0x040002C6 RID: 710
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AddressablesImpl_Type_IEnumerable_MergeMode_0;

			// Token: 0x040002C7 RID: 711
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040002C8 RID: 712
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040002C9 RID: 713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060003B3 RID: 947 RVA: 0x000143FC File Offset: 0x000125FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr);
				AddressablesImpl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, "<>9");
				AddressablesImpl.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, "<>9__59_0");
				AddressablesImpl.__c.NativeFieldInfoPtr___9__146_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, "<>9__146_0");
				AddressablesImpl.__c.NativeFieldInfoPtr___9__146_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, "<>9__146_1");
				AddressablesImpl.__c.NativeFieldInfoPtr___9__150_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, "<>9__150_0");
				AddressablesImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, 100663604);
				AddressablesImpl.__c.NativeMethodInfoPtr__get_ResourceLocators_b__59_0_Internal_IResourceLocator_ResourceLocatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, 100663605);
				AddressablesImpl.__c.NativeMethodInfoPtr__get_CatalogsWithAvailableUpdates_b__146_0_Internal_Boolean_ResourceLocatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, 100663606);
				AddressablesImpl.__c.NativeMethodInfoPtr__get_CatalogsWithAvailableUpdates_b__146_1_Internal_String_ResourceLocatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, 100663607);
				AddressablesImpl.__c.NativeMethodInfoPtr__CleanBundleCache_b__150_0_Internal_String_ResourceLocatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr, 100663608);
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x000144F0 File Offset: 0x000126F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0001452C File Offset: 0x0001272C
			[CallerCount(0)]
			public unsafe IResourceLocator _get_ResourceLocators_b__59_0(ResourceLocatorInfo l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c.NativeMethodInfoPtr__get_ResourceLocators_b__59_0_Internal_IResourceLocator_ResourceLocatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocator>(intPtr3) : null;
				}
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x0001457C File Offset: 0x0001277C
			[CallerCount(0)]
			public unsafe bool _get_CatalogsWithAvailableUpdates_b__146_0(ResourceLocatorInfo s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c.NativeMethodInfoPtr__get_CatalogsWithAvailableUpdates_b__146_0_Internal_Boolean_ResourceLocatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x000145CC File Offset: 0x000127CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159535, XrefRangeEnd = 1159539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _get_CatalogsWithAvailableUpdates_b__146_1(ResourceLocatorInfo s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c.NativeMethodInfoPtr__get_CatalogsWithAvailableUpdates_b__146_1_Internal_String_ResourceLocatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00014614 File Offset: 0x00012814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159539, XrefRangeEnd = 1159543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CleanBundleCache_b__150_0(ResourceLocatorInfo s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c.NativeMethodInfoPtr__CleanBundleCache_b__150_0_Internal_String_ResourceLocatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0000351F File Offset: 0x0000171F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060003BA RID: 954 RVA: 0x0001465C File Offset: 0x0001285C
			// (set) Token: 0x060003BB RID: 955 RVA: 0x00003528 File Offset: 0x00001728
			public unsafe static AddressablesImpl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060003BC RID: 956 RVA: 0x00014684 File Offset: 0x00012884
			// (set) Token: 0x060003BD RID: 957 RVA: 0x0000353A File Offset: 0x0000173A
			public unsafe static Func<ResourceLocatorInfo, IResourceLocator> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ResourceLocatorInfo, IResourceLocator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060003BE RID: 958 RVA: 0x000146AC File Offset: 0x000128AC
			// (set) Token: 0x060003BF RID: 959 RVA: 0x0000354C File Offset: 0x0000174C
			public unsafe static Func<ResourceLocatorInfo, bool> __9__146_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__146_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ResourceLocatorInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__146_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x000146D4 File Offset: 0x000128D4
			// (set) Token: 0x060003C1 RID: 961 RVA: 0x0000355E File Offset: 0x0000175E
			public unsafe static Func<ResourceLocatorInfo, string> __9__146_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__146_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ResourceLocatorInfo, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__146_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x000146FC File Offset: 0x000128FC
			// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003570 File Offset: 0x00001770
			public unsafe static Func<ResourceLocatorInfo, string> __9__150_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__150_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ResourceLocatorInfo, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.__c.NativeFieldInfoPtr___9__150_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002CA RID: 714
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002CB RID: 715
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x040002CC RID: 716
			private static readonly IntPtr NativeFieldInfoPtr___9__146_0;

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeFieldInfoPtr___9__146_1;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeFieldInfoPtr___9__150_0;

			// Token: 0x040002CF RID: 719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002D0 RID: 720
			private static readonly IntPtr NativeMethodInfoPtr__get_ResourceLocators_b__59_0_Internal_IResourceLocator_ResourceLocatorInfo_0;

			// Token: 0x040002D1 RID: 721
			private static readonly IntPtr NativeMethodInfoPtr__get_CatalogsWithAvailableUpdates_b__146_0_Internal_Boolean_ResourceLocatorInfo_0;

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeMethodInfoPtr__get_CatalogsWithAvailableUpdates_b__146_1_Internal_String_ResourceLocatorInfo_0;

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeMethodInfoPtr__CleanBundleCache_b__150_0_Internal_String_ResourceLocatorInfo_0;
		}

		// Token: 0x02000045 RID: 69
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__115`1")]
		[Serializable]
		public sealed class __c__115<TObject> : Object
		{
			// Token: 0x060003C4 RID: 964 RVA: 0x00014724 File Offset: 0x00012924
			// Note: this type is marked as 'beforefieldinit'.
			static __c__115()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__115<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__115`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__115<TObject>>.NativeClassPtr);
				AddressablesImpl.__c__115<TObject>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__115<TObject>>.NativeClassPtr, "<>9");
				AddressablesImpl.__c__115<TObject>.NativeFieldInfoPtr___9__115_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__115<TObject>>.NativeClassPtr, "<>9__115_0");
				AddressablesImpl.__c__115<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__115<TObject>>.NativeClassPtr, 100663610);
				AddressablesImpl.__c__115<TObject>.NativeMethodInfoPtr__AutoReleaseHandleOnTypelessCompletion_b__115_0_Internal_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__115<TObject>>.NativeClassPtr, 100663611);
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x000147DC File Offset: 0x000129DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__115()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__115<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__115<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00014818 File Offset: 0x00012A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159543, XrefRangeEnd = 1159544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AutoReleaseHandleOnTypelessCompletion_b__115_0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__115<TObject>.NativeMethodInfoPtr__AutoReleaseHandleOnTypelessCompletion_b__115_0_Internal_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00003582 File Offset: 0x00001782
			public __c__115(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x00014860 File Offset: 0x00012A60
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000358B File Offset: 0x0000178B
			public unsafe static AddressablesImpl.__c__115<TObject> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.__c__115<TObject>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl.__c__115<TObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.__c__115<TObject>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060003CA RID: 970 RVA: 0x00014888 File Offset: 0x00012A88
			// (set) Token: 0x060003CB RID: 971 RVA: 0x0000359D File Offset: 0x0000179D
			public unsafe static Action<AsyncOperationHandle> __9__115_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesImpl.__c__115<TObject>.NativeFieldInfoPtr___9__115_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesImpl.__c__115<TObject>.NativeFieldInfoPtr___9__115_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002D5 RID: 725
			private static readonly IntPtr NativeFieldInfoPtr___9__115_0;

			// Token: 0x040002D6 RID: 726
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002D7 RID: 727
			private static readonly IntPtr NativeMethodInfoPtr__AutoReleaseHandleOnTypelessCompletion_b__115_0_Internal_Void_AsyncOperationHandle_0;
		}

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass100_0")]
		public sealed class __c__DisplayClass100_0 : Object
		{
			// Token: 0x060003CC RID: 972 RVA: 0x000148B0 File Offset: 0x00012AB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass100_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass100_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass100_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass100_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass100_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass100_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass100_0.NativeFieldInfoPtr_catalogLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass100_0>.NativeClassPtr, "catalogLoc");
				AddressablesImpl.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass100_0>.NativeClassPtr, 100663612);
				AddressablesImpl.__c__DisplayClass100_0.NativeMethodInfoPtr__ComputeCatalogSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass100_0>.NativeClassPtr, 100663613);
			}

			// Token: 0x060003CD RID: 973 RVA: 0x0001492C File Offset: 0x00012B2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass100_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass100_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00014968 File Offset: 0x00012B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159544, XrefRangeEnd = 1159552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<long> _ComputeCatalogSizeWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass100_0.NativeMethodInfoPtr__ComputeCatalogSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<long>(intPtr);
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x000035AF File Offset: 0x000017AF
			public __c__DisplayClass100_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060003D0 RID: 976 RVA: 0x000149B8 File Offset: 0x00012BB8
			// (set) Token: 0x060003D1 RID: 977 RVA: 0x000035B8 File Offset: 0x000017B8
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass100_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass100_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x000149E8 File Offset: 0x00012BE8
			// (set) Token: 0x060003D3 RID: 979 RVA: 0x000035D7 File Offset: 0x000017D7
			public unsafe IResourceLocation catalogLoc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass100_0.NativeFieldInfoPtr_catalogLoc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass100_0.NativeFieldInfoPtr_catalogLoc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002D8 RID: 728
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002D9 RID: 729
			private static readonly IntPtr NativeFieldInfoPtr_catalogLoc;

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002DB RID: 731
			private static readonly IntPtr NativeMethodInfoPtr__ComputeCatalogSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0;
		}

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass103_0")]
		public sealed class __c__DisplayClass103_0 : Object
		{
			// Token: 0x060003D4 RID: 980 RVA: 0x00014A18 File Offset: 0x00012C18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass103_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass103_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass103_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass103_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass103_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass103_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass103_0.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass103_0>.NativeClassPtr, "keys");
				AddressablesImpl.__c__DisplayClass103_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass103_0>.NativeClassPtr, 100663614);
				AddressablesImpl.__c__DisplayClass103_0.NativeMethodInfoPtr__GetDownloadSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass103_0>.NativeClassPtr, 100663615);
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x00014A94 File Offset: 0x00012C94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass103_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass103_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass103_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x00014AD0 File Offset: 0x00012CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159552, XrefRangeEnd = 1159553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<long> _GetDownloadSizeWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass103_0.NativeMethodInfoPtr__GetDownloadSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<long>(intPtr);
				}
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x000035F6 File Offset: 0x000017F6
			public __c__DisplayClass103_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x00014B20 File Offset: 0x00012D20
			// (set) Token: 0x060003D9 RID: 985 RVA: 0x000035FF File Offset: 0x000017FF
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass103_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass103_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x060003DA RID: 986 RVA: 0x00014B50 File Offset: 0x00012D50
			// (set) Token: 0x060003DB RID: 987 RVA: 0x0000361E File Offset: 0x0000181E
			public unsafe IEnumerable keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass103_0.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass103_0.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeMethodInfoPtr__GetDownloadSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0;
		}

		// Token: 0x02000048 RID: 72
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass106_0")]
		public sealed class __c__DisplayClass106_0 : Object
		{
			// Token: 0x060003DC RID: 988 RVA: 0x00014B80 File Offset: 0x00012D80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass106_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass106_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass106_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass106_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass106_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass106_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass106_0>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass106_0>.NativeClassPtr, 100663616);
				AddressablesImpl.__c__DisplayClass106_0.NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass106_0>.NativeClassPtr, 100663617);
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00014BFC File Offset: 0x00012DFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass106_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass106_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00014C38 File Offset: 0x00012E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159553, XrefRangeEnd = 1159557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<IAssetBundleResource>> _DownloadDependenciesAsyncWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass106_0.NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<IAssetBundleResource>>(intPtr);
				}
			}

			// Token: 0x060003DF RID: 991 RVA: 0x0000363D File Offset: 0x0000183D
			public __c__DisplayClass106_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x00014C88 File Offset: 0x00012E88
			// (set) Token: 0x060003E1 RID: 993 RVA: 0x00003646 File Offset: 0x00001846
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00014CB8 File Offset: 0x00012EB8
			// (set) Token: 0x060003E3 RID: 995 RVA: 0x00003665 File Offset: 0x00001865
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass106_0.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass106_0.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0;
		}

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass110_0")]
		public sealed class __c__DisplayClass110_0 : Object
		{
			// Token: 0x060003E4 RID: 996 RVA: 0x00014CE8 File Offset: 0x00012EE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass110_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass110_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass110_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass110_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass110_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass110_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass110_0.NativeFieldInfoPtr_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass110_0>.NativeClassPtr, "locations");
				AddressablesImpl.__c__DisplayClass110_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass110_0>.NativeClassPtr, 100663618);
				AddressablesImpl.__c__DisplayClass110_0.NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass110_0>.NativeClassPtr, 100663619);
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x00014D64 File Offset: 0x00012F64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass110_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass110_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass110_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00014DA0 File Offset: 0x00012FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159557, XrefRangeEnd = 1159561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<IAssetBundleResource>> _DownloadDependenciesAsyncWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass110_0.NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<IAssetBundleResource>>(intPtr);
				}
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00003684 File Offset: 0x00001884
			public __c__DisplayClass110_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00014DF0 File Offset: 0x00012FF0
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0000368D File Offset: 0x0000188D
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass110_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass110_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00014E20 File Offset: 0x00013020
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x000036AC File Offset: 0x000018AC
			public unsafe IList<IResourceLocation> locations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass110_0.NativeFieldInfoPtr_locations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass110_0.NativeFieldInfoPtr_locations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeFieldInfoPtr_locations;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002E7 RID: 743
			private static readonly IntPtr NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0;
		}

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass112_0")]
		public sealed class __c__DisplayClass112_0 : Object
		{
			// Token: 0x060003EC RID: 1004 RVA: 0x00014E50 File Offset: 0x00013050
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass112_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass112_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr, "keys");
				AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr, "mode");
				AddressablesImpl.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr, 100663620);
				AddressablesImpl.__c__DisplayClass112_0.NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr, 100663621);
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x00014EE0 File Offset: 0x000130E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass112_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass112_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x00014F1C File Offset: 0x0001311C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159561, XrefRangeEnd = 1159565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<IAssetBundleResource>> _DownloadDependenciesAsyncWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass112_0.NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<IAssetBundleResource>>(intPtr);
				}
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x000036CB File Offset: 0x000018CB
			public __c__DisplayClass112_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00014F6C File Offset: 0x0001316C
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x000036D4 File Offset: 0x000018D4
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00014F9C File Offset: 0x0001319C
			// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000036F3 File Offset: 0x000018F3
			public unsafe IEnumerable keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00014FCC File Offset: 0x000131CC
			// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003712 File Offset: 0x00001912
			public unsafe Addressables.MergeMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass112_0.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x040002E8 RID: 744
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002E9 RID: 745
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x040002EA RID: 746
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x040002EB RID: 747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002EC RID: 748
			private static readonly IntPtr NativeMethodInfoPtr__DownloadDependenciesAsyncWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IAssetBundleResource_AsyncOperationHandle_0;
		}

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass116_0")]
		public sealed class __c__DisplayClass116_0 : Object
		{
			// Token: 0x060003F6 RID: 1014 RVA: 0x00014FF4 File Offset: 0x000131F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass116_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass116_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr, 100663622);
				AddressablesImpl.__c__DisplayClass116_0.NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr, 100663623);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00015084 File Offset: 0x00013284
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass116_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass116_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x000150C0 File Offset: 0x000132C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159565, XrefRangeEnd = 1159566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<bool> _ClearDependencyCacheAsync_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass116_0.NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<bool>(intPtr);
				}
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x0000372D File Offset: 0x0000192D
			public __c__DisplayClass116_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x00015110 File Offset: 0x00013310
			// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003736 File Offset: 0x00001936
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x060003FC RID: 1020 RVA: 0x00015140 File Offset: 0x00013340
			// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003755 File Offset: 0x00001955
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060003FE RID: 1022 RVA: 0x00015170 File Offset: 0x00013370
			// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003774 File Offset: 0x00001974
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass116_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x040002ED RID: 749
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002EE RID: 750
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040002EF RID: 751
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x040002F0 RID: 752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002F1 RID: 753
			private static readonly IntPtr NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0;
		}

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass117_0")]
		public sealed class __c__DisplayClass117_0 : Object
		{
			// Token: 0x06000400 RID: 1024 RVA: 0x00015198 File Offset: 0x00013398
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass117_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass117_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr, "locations");
				AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass117_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr, 100663624);
				AddressablesImpl.__c__DisplayClass117_0.NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr, 100663625);
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x00015228 File Offset: 0x00013428
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass117_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass117_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass117_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x00015264 File Offset: 0x00013464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159566, XrefRangeEnd = 1159567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<bool> _ClearDependencyCacheAsync_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass117_0.NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<bool>(intPtr);
				}
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x0000378F File Offset: 0x0000198F
			public __c__DisplayClass117_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x000152B4 File Offset: 0x000134B4
			// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003798 File Offset: 0x00001998
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x000152E4 File Offset: 0x000134E4
			// (set) Token: 0x06000407 RID: 1031 RVA: 0x000037B7 File Offset: 0x000019B7
			public unsafe IList<IResourceLocation> locations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr_locations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr_locations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000408 RID: 1032 RVA: 0x00015314 File Offset: 0x00013514
			// (set) Token: 0x06000409 RID: 1033 RVA: 0x000037D6 File Offset: 0x000019D6
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass117_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x040002F2 RID: 754
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002F3 RID: 755
			private static readonly IntPtr NativeFieldInfoPtr_locations;

			// Token: 0x040002F4 RID: 756
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x040002F5 RID: 757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002F6 RID: 758
			private static readonly IntPtr NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0;
		}

		// Token: 0x0200004D RID: 77
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass118_0")]
		public sealed class __c__DisplayClass118_0 : Object
		{
			// Token: 0x0600040A RID: 1034 RVA: 0x0001533C File Offset: 0x0001353C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass118_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass118_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr, "keys");
				AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr, 100663626);
				AddressablesImpl.__c__DisplayClass118_0.NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr, 100663627);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x000153CC File Offset: 0x000135CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass118_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass118_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00015408 File Offset: 0x00013608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159567, XrefRangeEnd = 1159568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<bool> _ClearDependencyCacheAsync_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass118_0.NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<bool>(intPtr);
				}
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x000037F1 File Offset: 0x000019F1
			public __c__DisplayClass118_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x00015458 File Offset: 0x00013658
			// (set) Token: 0x0600040F RID: 1039 RVA: 0x000037FA File Offset: 0x000019FA
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000410 RID: 1040 RVA: 0x00015488 File Offset: 0x00013688
			// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003819 File Offset: 0x00001A19
			public unsafe IEnumerable keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x000154B8 File Offset: 0x000136B8
			// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003838 File Offset: 0x00001A38
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass118_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x040002F7 RID: 759
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002F8 RID: 760
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x040002F9 RID: 761
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x040002FA RID: 762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002FB RID: 763
			private static readonly IntPtr NativeMethodInfoPtr__ClearDependencyCacheAsync_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0;
		}

		// Token: 0x0200004E RID: 78
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass123_0")]
		public sealed class __c__DisplayClass123_0 : Object
		{
			// Token: 0x06000414 RID: 1044 RVA: 0x000154E0 File Offset: 0x000136E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass123_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass123_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr_instantiateParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr, "instantiateParameters");
				AddressablesImpl.__c__DisplayClass123_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr, 100663628);
				AddressablesImpl.__c__DisplayClass123_0.NativeMethodInfoPtr__InstantiateWithChain_b__0_Internal_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr, 100663629);
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00015570 File Offset: 0x00013770
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass123_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass123_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass123_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x000155AC File Offset: 0x000137AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159568, XrefRangeEnd = 1159569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<GameObject> _InstantiateWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass123_0.NativeMethodInfoPtr__InstantiateWithChain_b__0_Internal_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<GameObject>(intPtr);
				}
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x00003853 File Offset: 0x00001A53
			public __c__DisplayClass123_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x000155FC File Offset: 0x000137FC
			// (set) Token: 0x06000419 RID: 1049 RVA: 0x0000385C File Offset: 0x00001A5C
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001562C File Offset: 0x0001382C
			// (set) Token: 0x0600041B RID: 1051 RVA: 0x0000387B File Offset: 0x00001A7B
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001565C File Offset: 0x0001385C
			// (set) Token: 0x0600041D RID: 1053 RVA: 0x0000389A File Offset: 0x00001A9A
			public InstantiationParameters instantiateParameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr_instantiateParameters);
					return new InstantiationParameters(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass123_0.NativeFieldInfoPtr_instantiateParameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002FC RID: 764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002FD RID: 765
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040002FE RID: 766
			private static readonly IntPtr NativeFieldInfoPtr_instantiateParameters;

			// Token: 0x040002FF RID: 767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000300 RID: 768
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateWithChain_b__0_Internal_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_0;
		}

		// Token: 0x0200004F RID: 79
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass125_0")]
		public sealed class __c__DisplayClass125_0 : Object
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x0001568C File Offset: 0x0001388C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass125_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass125_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr, "location");
				AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr_instantiateParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr, "instantiateParameters");
				AddressablesImpl.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr, 100663630);
				AddressablesImpl.__c__DisplayClass125_0.NativeMethodInfoPtr__InstantiateWithChain_b__0_Internal_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr, 100663631);
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x0001571C File Offset: 0x0001391C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass125_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass125_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00015758 File Offset: 0x00013958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159569, XrefRangeEnd = 1159570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<GameObject> _InstantiateWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass125_0.NativeMethodInfoPtr__InstantiateWithChain_b__0_Internal_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<GameObject>(intPtr);
				}
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x000038C8 File Offset: 0x00001AC8
			public __c__DisplayClass125_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x000157A8 File Offset: 0x000139A8
			// (set) Token: 0x06000423 RID: 1059 RVA: 0x000038D1 File Offset: 0x00001AD1
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x000157D8 File Offset: 0x000139D8
			// (set) Token: 0x06000425 RID: 1061 RVA: 0x000038F0 File Offset: 0x00001AF0
			public unsafe IResourceLocation location
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr_location);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr_location), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x00015808 File Offset: 0x00013A08
			// (set) Token: 0x06000427 RID: 1063 RVA: 0x0000390F File Offset: 0x00001B0F
			public InstantiationParameters instantiateParameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr_instantiateParameters);
					return new InstantiationParameters(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass125_0.NativeFieldInfoPtr_instantiateParameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000301 RID: 769
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000302 RID: 770
			private static readonly IntPtr NativeFieldInfoPtr_location;

			// Token: 0x04000303 RID: 771
			private static readonly IntPtr NativeFieldInfoPtr_instantiateParameters;

			// Token: 0x04000304 RID: 772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000305 RID: 773
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateWithChain_b__0_Internal_AsyncOperationHandle_1_GameObject_AsyncOperationHandle_0;
		}

		// Token: 0x02000050 RID: 80
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass128_0")]
		public sealed class __c__DisplayClass128_0 : Object
		{
			// Token: 0x06000428 RID: 1064 RVA: 0x00015838 File Offset: 0x00013A38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass128_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass128_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_loadSceneParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr, "loadSceneParameters");
				AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_activateOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr, "activateOnLoad");
				AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr, "priority");
				AddressablesImpl.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr, 100663632);
				AddressablesImpl.__c__DisplayClass128_0.NativeMethodInfoPtr__LoadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr, 100663633);
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x000158F0 File Offset: 0x00013AF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass128_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass128_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x0001592C File Offset: 0x00013B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159570, XrefRangeEnd = 1159571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<SceneInstance> _LoadSceneWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass128_0.NativeMethodInfoPtr__LoadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<SceneInstance>(intPtr);
				}
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0000393D File Offset: 0x00001B3D
			public __c__DisplayClass128_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001597C File Offset: 0x00013B7C
			// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003946 File Offset: 0x00001B46
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x000159AC File Offset: 0x00013BAC
			// (set) Token: 0x0600042F RID: 1071 RVA: 0x00003965 File Offset: 0x00001B65
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x000159DC File Offset: 0x00013BDC
			// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003984 File Offset: 0x00001B84
			public unsafe LoadSceneParameters loadSceneParameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_loadSceneParameters);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_loadSceneParameters)) = value;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x00015A04 File Offset: 0x00013C04
			// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000399F File Offset: 0x00001B9F
			public unsafe bool activateOnLoad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_activateOnLoad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_activateOnLoad)) = value;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x00015A2C File Offset: 0x00013C2C
			// (set) Token: 0x06000435 RID: 1077 RVA: 0x000039BA File Offset: 0x00001BBA
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass128_0.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x04000306 RID: 774
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000307 RID: 775
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04000308 RID: 776
			private static readonly IntPtr NativeFieldInfoPtr_loadSceneParameters;

			// Token: 0x04000309 RID: 777
			private static readonly IntPtr NativeFieldInfoPtr_activateOnLoad;

			// Token: 0x0400030A RID: 778
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x0400030B RID: 779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400030C RID: 780
			private static readonly IntPtr NativeMethodInfoPtr__LoadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0;
		}

		// Token: 0x02000051 RID: 81
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass129_0")]
		public sealed class __c__DisplayClass129_0 : Object
		{
			// Token: 0x06000436 RID: 1078 RVA: 0x00015A54 File Offset: 0x00013C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass129_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass129_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_loadMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr, "loadMode");
				AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_activateOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr, "activateOnLoad");
				AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr, "priority");
				AddressablesImpl.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr, 100663634);
				AddressablesImpl.__c__DisplayClass129_0.NativeMethodInfoPtr__LoadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr, 100663635);
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x00015B0C File Offset: 0x00013D0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass129_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass129_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00015B48 File Offset: 0x00013D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159571, XrefRangeEnd = 1159577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<SceneInstance> _LoadSceneWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass129_0.NativeMethodInfoPtr__LoadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<SceneInstance>(intPtr);
				}
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x000039D5 File Offset: 0x00001BD5
			public __c__DisplayClass129_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x0600043A RID: 1082 RVA: 0x00015B98 File Offset: 0x00013D98
			// (set) Token: 0x0600043B RID: 1083 RVA: 0x000039DE File Offset: 0x00001BDE
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x0600043C RID: 1084 RVA: 0x00015BC8 File Offset: 0x00013DC8
			// (set) Token: 0x0600043D RID: 1085 RVA: 0x000039FD File Offset: 0x00001BFD
			public unsafe IResourceLocation key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600043E RID: 1086 RVA: 0x00015BF8 File Offset: 0x00013DF8
			// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003A1C File Offset: 0x00001C1C
			public unsafe LoadSceneMode loadMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_loadMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_loadMode)) = value;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000440 RID: 1088 RVA: 0x00015C20 File Offset: 0x00013E20
			// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003A37 File Offset: 0x00001C37
			public unsafe bool activateOnLoad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_activateOnLoad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_activateOnLoad)) = value;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00015C48 File Offset: 0x00013E48
			// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003A52 File Offset: 0x00001C52
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass129_0.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeFieldInfoPtr_loadMode;

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeFieldInfoPtr_activateOnLoad;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000313 RID: 787
			private static readonly IntPtr NativeMethodInfoPtr__LoadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0;
		}

		// Token: 0x02000052 RID: 82
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass138_0")]
		public sealed class __c__DisplayClass138_0 : Object
		{
			// Token: 0x06000444 RID: 1092 RVA: 0x00015C70 File Offset: 0x00013E70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass138_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass138_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr_unloadOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr, "unloadOptions");
				AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr, 100663636);
				AddressablesImpl.__c__DisplayClass138_0.NativeMethodInfoPtr__CreateUnloadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr, 100663637);
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x00015D00 File Offset: 0x00013F00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass138_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass138_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00015D3C File Offset: 0x00013F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159577, XrefRangeEnd = 1159584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<SceneInstance> _CreateUnloadSceneWithChain_b__0(AsyncOperationHandle completedHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(completedHandle));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass138_0.NativeMethodInfoPtr__CreateUnloadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<SceneInstance>(intPtr);
				}
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00003A6D File Offset: 0x00001C6D
			public __c__DisplayClass138_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000448 RID: 1096 RVA: 0x00015D8C File Offset: 0x00013F8C
			// (set) Token: 0x06000449 RID: 1097 RVA: 0x00003A76 File Offset: 0x00001C76
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x00015DBC File Offset: 0x00013FBC
			// (set) Token: 0x0600044B RID: 1099 RVA: 0x00003A95 File Offset: 0x00001C95
			public unsafe UnloadSceneOptions unloadOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr_unloadOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr_unloadOptions)) = value;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00015DE4 File Offset: 0x00013FE4
			// (set) Token: 0x0600044D RID: 1101 RVA: 0x00003AB0 File Offset: 0x00001CB0
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass138_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x04000314 RID: 788
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeFieldInfoPtr_unloadOptions;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x04000317 RID: 791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000318 RID: 792
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnloadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_0;
		}

		// Token: 0x02000053 RID: 83
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass139_0")]
		public sealed class __c__DisplayClass139_0 : Object
		{
			// Token: 0x0600044E RID: 1102 RVA: 0x00015E0C File Offset: 0x0001400C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass139_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass139_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr_unloadOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr, "unloadOptions");
				AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr, 100663638);
				AddressablesImpl.__c__DisplayClass139_0.NativeMethodInfoPtr__CreateUnloadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr, 100663639);
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00015E9C File Offset: 0x0001409C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass139_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass139_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x00015ED8 File Offset: 0x000140D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159584, XrefRangeEnd = 1159588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<SceneInstance> _CreateUnloadSceneWithChain_b__0(AsyncOperationHandle<SceneInstance> completedHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(completedHandle));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass139_0.NativeMethodInfoPtr__CreateUnloadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<SceneInstance>(intPtr);
				}
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x00003ACB File Offset: 0x00001CCB
			public __c__DisplayClass139_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00015F28 File Offset: 0x00014128
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003AD4 File Offset: 0x00001CD4
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x00015F58 File Offset: 0x00014158
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003AF3 File Offset: 0x00001CF3
			public unsafe UnloadSceneOptions unloadOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr_unloadOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr_unloadOptions)) = value;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x00015F80 File Offset: 0x00014180
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x00003B0E File Offset: 0x00001D0E
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass139_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x04000319 RID: 793
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400031A RID: 794
			private static readonly IntPtr NativeFieldInfoPtr_unloadOptions;

			// Token: 0x0400031B RID: 795
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x0400031C RID: 796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400031D RID: 797
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnloadSceneWithChain_b__0_Internal_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_0;
		}

		// Token: 0x02000054 RID: 84
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass143_0")]
		public sealed class __c__DisplayClass143_0 : Object
		{
			// Token: 0x06000458 RID: 1112 RVA: 0x00015FA8 File Offset: 0x000141A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass143_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass143_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass143_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass143_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass143_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass143_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass143_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass143_0>.NativeClassPtr, 100663640);
				AddressablesImpl.__c__DisplayClass143_0.NativeMethodInfoPtr__CheckForCatalogUpdatesWithChain_b__0_Internal_AsyncOperationHandle_1_List_1_String_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass143_0>.NativeClassPtr, 100663641);
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00016024 File Offset: 0x00014224
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass143_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass143_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00016060 File Offset: 0x00014260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159588, XrefRangeEnd = 1159589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<List<string>> _CheckForCatalogUpdatesWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass143_0.NativeMethodInfoPtr__CheckForCatalogUpdatesWithChain_b__0_Internal_AsyncOperationHandle_1_List_1_String_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<List<string>>(intPtr);
				}
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00003B29 File Offset: 0x00001D29
			public __c__DisplayClass143_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x000160B0 File Offset: 0x000142B0
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003B32 File Offset: 0x00001D32
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x000160E0 File Offset: 0x000142E0
			// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003B51 File Offset: 0x00001D51
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass143_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass143_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x0400031E RID: 798
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400031F RID: 799
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x04000320 RID: 800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000321 RID: 801
			private static readonly IntPtr NativeMethodInfoPtr__CheckForCatalogUpdatesWithChain_b__0_Internal_AsyncOperationHandle_1_List_1_String_AsyncOperationHandle_0;
		}

		// Token: 0x02000055 RID: 85
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass147_0")]
		public sealed class __c__DisplayClass147_0 : Object
		{
			// Token: 0x06000460 RID: 1120 RVA: 0x00016108 File Offset: 0x00014308
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass147_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass147_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr_autoCleanBundleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr, "autoCleanBundleCache");
				AddressablesImpl.__c__DisplayClass147_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr, 100663642);
				AddressablesImpl.__c__DisplayClass147_0.NativeMethodInfoPtr__UpdateCatalogs_b__0_Internal_AsyncOperationHandle_1_List_1_IResourceLocator_AsyncOperationHandle_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr, 100663643);
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00016198 File Offset: 0x00014398
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass147_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass147_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass147_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x000161D4 File Offset: 0x000143D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159589, XrefRangeEnd = 1159591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<List<IResourceLocator>> _UpdateCatalogs_b__0(AsyncOperationHandle<List<string>> depOp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass147_0.NativeMethodInfoPtr__UpdateCatalogs_b__0_Internal_AsyncOperationHandle_1_List_1_IResourceLocator_AsyncOperationHandle_1_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<List<IResourceLocator>>(intPtr);
				}
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00003B6C File Offset: 0x00001D6C
			public __c__DisplayClass147_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000464 RID: 1124 RVA: 0x00016224 File Offset: 0x00014424
			// (set) Token: 0x06000465 RID: 1125 RVA: 0x00003B75 File Offset: 0x00001D75
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x00016254 File Offset: 0x00014454
			// (set) Token: 0x06000467 RID: 1127 RVA: 0x00003B94 File Offset: 0x00001D94
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001627C File Offset: 0x0001447C
			// (set) Token: 0x06000469 RID: 1129 RVA: 0x00003BAF File Offset: 0x00001DAF
			public unsafe bool autoCleanBundleCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr_autoCleanBundleCache);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass147_0.NativeFieldInfoPtr_autoCleanBundleCache)) = value;
				}
			}

			// Token: 0x04000322 RID: 802
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000323 RID: 803
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x04000324 RID: 804
			private static readonly IntPtr NativeFieldInfoPtr_autoCleanBundleCache;

			// Token: 0x04000325 RID: 805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000326 RID: 806
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCatalogs_b__0_Internal_AsyncOperationHandle_1_List_1_IResourceLocator_AsyncOperationHandle_1_List_1_String_0;
		}

		// Token: 0x02000056 RID: 86
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass152_0")]
		public sealed class __c__DisplayClass152_0 : Object
		{
			// Token: 0x0600046A RID: 1130 RVA: 0x000162A4 File Offset: 0x000144A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass152_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass152_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr_depOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr, "depOp");
				AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr_forceSingleThreading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr, "forceSingleThreading");
				AddressablesImpl.__c__DisplayClass152_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr, 100663644);
				AddressablesImpl.__c__DisplayClass152_0.NativeMethodInfoPtr__CleanBundleCacheWithChain_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr, 100663645);
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x00016334 File Offset: 0x00014534
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass152_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass152_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass152_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00016370 File Offset: 0x00014570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159591, XrefRangeEnd = 1159592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<bool> _CleanBundleCacheWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass152_0.NativeMethodInfoPtr__CleanBundleCacheWithChain_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<bool>(intPtr);
				}
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00003BCA File Offset: 0x00001DCA
			public __c__DisplayClass152_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x0600046E RID: 1134 RVA: 0x000163C0 File Offset: 0x000145C0
			// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003BD3 File Offset: 0x00001DD3
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x000163F0 File Offset: 0x000145F0
			// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003BF2 File Offset: 0x00001DF2
			public AsyncOperationHandle<IList<AsyncOperationHandle>> depOp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr_depOp);
					return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr_depOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x00016420 File Offset: 0x00014620
			// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003C20 File Offset: 0x00001E20
			public unsafe bool forceSingleThreading
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr_forceSingleThreading);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass152_0.NativeFieldInfoPtr_forceSingleThreading)) = value;
				}
			}

			// Token: 0x04000327 RID: 807
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000328 RID: 808
			private static readonly IntPtr NativeFieldInfoPtr_depOp;

			// Token: 0x04000329 RID: 809
			private static readonly IntPtr NativeFieldInfoPtr_forceSingleThreading;

			// Token: 0x0400032A RID: 810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400032B RID: 811
			private static readonly IntPtr NativeMethodInfoPtr__CleanBundleCacheWithChain_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0;
		}

		// Token: 0x02000057 RID: 87
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass153_0")]
		public sealed class __c__DisplayClass153_0 : Object
		{
			// Token: 0x06000474 RID: 1140 RVA: 0x00016448 File Offset: 0x00014648
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass153_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass153_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr_catalogIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr, "catalogIds");
				AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr_forceSingleThreading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr, "forceSingleThreading");
				AddressablesImpl.__c__DisplayClass153_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr, 100663646);
				AddressablesImpl.__c__DisplayClass153_0.NativeMethodInfoPtr__CleanBundleCacheWithChain_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr, 100663647);
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x000164D8 File Offset: 0x000146D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass153_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass153_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass153_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x00016514 File Offset: 0x00014714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159592, XrefRangeEnd = 1159593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<bool> _CleanBundleCacheWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass153_0.NativeMethodInfoPtr__CleanBundleCacheWithChain_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<bool>(intPtr);
				}
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x00003C3B File Offset: 0x00001E3B
			public __c__DisplayClass153_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x00016564 File Offset: 0x00014764
			// (set) Token: 0x06000479 RID: 1145 RVA: 0x00003C44 File Offset: 0x00001E44
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x00016594 File Offset: 0x00014794
			// (set) Token: 0x0600047B RID: 1147 RVA: 0x00003C63 File Offset: 0x00001E63
			public unsafe IEnumerable<string> catalogIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr_catalogIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr_catalogIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x000165C4 File Offset: 0x000147C4
			// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003C82 File Offset: 0x00001E82
			public unsafe bool forceSingleThreading
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr_forceSingleThreading);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass153_0.NativeFieldInfoPtr_forceSingleThreading)) = value;
				}
			}

			// Token: 0x0400032C RID: 812
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400032D RID: 813
			private static readonly IntPtr NativeFieldInfoPtr_catalogIds;

			// Token: 0x0400032E RID: 814
			private static readonly IntPtr NativeFieldInfoPtr_forceSingleThreading;

			// Token: 0x0400032F RID: 815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000330 RID: 816
			private static readonly IntPtr NativeMethodInfoPtr__CleanBundleCacheWithChain_b__0_Internal_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_0;
		}

		// Token: 0x02000058 RID: 88
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Object
		{
			// Token: 0x0600047E RID: 1150 RVA: 0x000165EC File Offset: 0x000147EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass61_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass61_0.NativeFieldInfoPtr_loc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass61_0>.NativeClassPtr, "loc");
				AddressablesImpl.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass61_0>.NativeClassPtr, 100663648);
				AddressablesImpl.__c__DisplayClass61_0.NativeMethodInfoPtr__RemoveResourceLocator_b__0_Internal_Boolean_ResourceLocatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass61_0>.NativeClassPtr, 100663649);
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00016654 File Offset: 0x00014854
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00016690 File Offset: 0x00014890
			[CallerCount(0)]
			public unsafe bool _RemoveResourceLocator_b__0(ResourceLocatorInfo l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass61_0.NativeMethodInfoPtr__RemoveResourceLocator_b__0_Internal_Boolean_ResourceLocatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00003C9D File Offset: 0x00001E9D
			public __c__DisplayClass61_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x000166E0 File Offset: 0x000148E0
			// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003CA6 File Offset: 0x00001EA6
			public unsafe IResourceLocator loc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass61_0.NativeFieldInfoPtr_loc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass61_0.NativeFieldInfoPtr_loc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000331 RID: 817
			private static readonly IntPtr NativeFieldInfoPtr_loc;

			// Token: 0x04000332 RID: 818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000333 RID: 819
			private static readonly IntPtr NativeMethodInfoPtr__RemoveResourceLocator_b__0_Internal_Boolean_ResourceLocatorInfo_0;
		}

		// Token: 0x02000059 RID: 89
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : Object
		{
			// Token: 0x06000484 RID: 1156 RVA: 0x00016710 File Offset: 0x00014910
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_catalogPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr, "catalogPath");
				AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_autoReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr, "autoReleaseHandle");
				AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_providerSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr, "providerSuffix");
				AddressablesImpl.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr, 100663650);
				AddressablesImpl.__c__DisplayClass72_0.NativeMethodInfoPtr__LoadContentCatalogAsync_b__0_Internal_AsyncOperationHandle_1_IResourceLocator_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr, 100663651);
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x000167B4 File Offset: 0x000149B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass72_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x000167F0 File Offset: 0x000149F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159593, XrefRangeEnd = 1159594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IResourceLocator> _LoadContentCatalogAsync_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass72_0.NativeMethodInfoPtr__LoadContentCatalogAsync_b__0_Internal_AsyncOperationHandle_1_IResourceLocator_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IResourceLocator>(intPtr);
				}
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x00003CC5 File Offset: 0x00001EC5
			public __c__DisplayClass72_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000488 RID: 1160 RVA: 0x00016840 File Offset: 0x00014A40
			// (set) Token: 0x06000489 RID: 1161 RVA: 0x00003CCE File Offset: 0x00001ECE
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600048A RID: 1162 RVA: 0x00016870 File Offset: 0x00014A70
			// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003CED File Offset: 0x00001EED
			public unsafe string catalogPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_catalogPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_catalogPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x00016898 File Offset: 0x00014A98
			// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003D0C File Offset: 0x00001F0C
			public unsafe bool autoReleaseHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_autoReleaseHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_autoReleaseHandle)) = value;
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x0600048E RID: 1166 RVA: 0x000168C0 File Offset: 0x00014AC0
			// (set) Token: 0x0600048F RID: 1167 RVA: 0x00003D27 File Offset: 0x00001F27
			public unsafe string providerSuffix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_providerSuffix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass72_0.NativeFieldInfoPtr_providerSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000334 RID: 820
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000335 RID: 821
			private static readonly IntPtr NativeFieldInfoPtr_catalogPath;

			// Token: 0x04000336 RID: 822
			private static readonly IntPtr NativeFieldInfoPtr_autoReleaseHandle;

			// Token: 0x04000337 RID: 823
			private static readonly IntPtr NativeFieldInfoPtr_providerSuffix;

			// Token: 0x04000338 RID: 824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000339 RID: 825
			private static readonly IntPtr NativeMethodInfoPtr__LoadContentCatalogAsync_b__0_Internal_AsyncOperationHandle_1_IResourceLocator_AsyncOperationHandle_0;
		}

		// Token: 0x0200005A RID: 90
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass78_0`1")]
		public sealed class __c__DisplayClass78_0<TObject> : Object
		{
			// Token: 0x06000490 RID: 1168 RVA: 0x000168E8 File Offset: 0x00014AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass78_0<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass78_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass78_0<TObject>>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass78_0<TObject>>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeFieldInfoPtr_loc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass78_0<TObject>>.NativeClassPtr, "loc");
				AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass78_0<TObject>>.NativeClassPtr, 100663652);
				AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeMethodInfoPtr__LoadAssetWithChain_b__0_Internal_AsyncOperationHandle_1_TObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass78_0<TObject>>.NativeClassPtr, 100663653);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x000169A0 File Offset: 0x00014BA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass78_0<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x000169DC File Offset: 0x00014BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159594, XrefRangeEnd = 1159595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<TObject> _LoadAssetWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeMethodInfoPtr__LoadAssetWithChain_b__0_Internal_AsyncOperationHandle_1_TObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<TObject>(intPtr);
				}
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x00003D46 File Offset: 0x00001F46
			public __c__DisplayClass78_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000494 RID: 1172 RVA: 0x00016A2C File Offset: 0x00014C2C
			// (set) Token: 0x06000495 RID: 1173 RVA: 0x00003D4F File Offset: 0x00001F4F
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x00016A5C File Offset: 0x00014C5C
			// (set) Token: 0x06000497 RID: 1175 RVA: 0x00003D6E File Offset: 0x00001F6E
			public unsafe IResourceLocation loc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeFieldInfoPtr_loc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass78_0<TObject>.NativeFieldInfoPtr_loc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400033A RID: 826
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400033B RID: 827
			private static readonly IntPtr NativeFieldInfoPtr_loc;

			// Token: 0x0400033C RID: 828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400033D RID: 829
			private static readonly IntPtr NativeMethodInfoPtr__LoadAssetWithChain_b__0_Internal_AsyncOperationHandle_1_TObject_AsyncOperationHandle_0;
		}

		// Token: 0x0200005B RID: 91
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass79_0`1")]
		public sealed class __c__DisplayClass79_0<TObject> : Object
		{
			// Token: 0x06000498 RID: 1176 RVA: 0x00016A8C File Offset: 0x00014C8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass79_0<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass79_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass79_0<TObject>>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass79_0<TObject>>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass79_0<TObject>>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass79_0<TObject>>.NativeClassPtr, 100663654);
				AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeMethodInfoPtr__LoadAssetWithChain_b__0_Internal_AsyncOperationHandle_1_TObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass79_0<TObject>>.NativeClassPtr, 100663655);
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x00016B44 File Offset: 0x00014D44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass79_0<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x00016B80 File Offset: 0x00014D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159595, XrefRangeEnd = 1159596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<TObject> _LoadAssetWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeMethodInfoPtr__LoadAssetWithChain_b__0_Internal_AsyncOperationHandle_1_TObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<TObject>(intPtr);
				}
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x00003D8D File Offset: 0x00001F8D
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x0600049C RID: 1180 RVA: 0x00016BD0 File Offset: 0x00014DD0
			// (set) Token: 0x0600049D RID: 1181 RVA: 0x00003D96 File Offset: 0x00001F96
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x0600049E RID: 1182 RVA: 0x00016C00 File Offset: 0x00014E00
			// (set) Token: 0x0600049F RID: 1183 RVA: 0x00003DB5 File Offset: 0x00001FB5
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass79_0<TObject>.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400033E RID: 830
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400033F RID: 831
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04000340 RID: 832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000341 RID: 833
			private static readonly IntPtr NativeMethodInfoPtr__LoadAssetWithChain_b__0_Internal_AsyncOperationHandle_1_TObject_AsyncOperationHandle_0;
		}

		// Token: 0x0200005C RID: 92
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Object
		{
			// Token: 0x060004A0 RID: 1184 RVA: 0x00016C30 File Offset: 0x00014E30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr, "keys");
				AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr, "mode");
				AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr, "type");
				AddressablesImpl.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr, 100663656);
				AddressablesImpl.__c__DisplayClass83_0.NativeMethodInfoPtr__LoadResourceLocationsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr, 100663657);
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x00016CD4 File Offset: 0x00014ED4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x00016D10 File Offset: 0x00014F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159596, XrefRangeEnd = 1159597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<IResourceLocation>> _LoadResourceLocationsWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass83_0.NativeMethodInfoPtr__LoadResourceLocationsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
				}
			}

			// Token: 0x060004A3 RID: 1187 RVA: 0x00003DD4 File Offset: 0x00001FD4
			public __c__DisplayClass83_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00016D60 File Offset: 0x00014F60
			// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00003DDD File Offset: 0x00001FDD
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00016D90 File Offset: 0x00014F90
			// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00003DFC File Offset: 0x00001FFC
			public unsafe IEnumerable keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00016DC0 File Offset: 0x00014FC0
			// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00003E1B File Offset: 0x0000201B
			public unsafe Addressables.MergeMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x00016DE8 File Offset: 0x00014FE8
			// (set) Token: 0x060004AB RID: 1195 RVA: 0x00003E36 File Offset: 0x00002036
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass83_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000342 RID: 834
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000343 RID: 835
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x04000344 RID: 836
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04000345 RID: 837
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04000346 RID: 838
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000347 RID: 839
			private static readonly IntPtr NativeMethodInfoPtr__LoadResourceLocationsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_0;
		}

		// Token: 0x0200005D RID: 93
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Object
		{
			// Token: 0x060004AC RID: 1196 RVA: 0x00016E18 File Offset: 0x00015018
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr, "type");
				AddressablesImpl.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr, 100663658);
				AddressablesImpl.__c__DisplayClass85_0.NativeMethodInfoPtr__LoadResourceLocationsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr, 100663659);
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x00016EA8 File Offset: 0x000150A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x00016EE4 File Offset: 0x000150E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159597, XrefRangeEnd = 1159598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<IResourceLocation>> _LoadResourceLocationsWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass85_0.NativeMethodInfoPtr__LoadResourceLocationsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
				}
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x00003E55 File Offset: 0x00002055
			public __c__DisplayClass85_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00016F34 File Offset: 0x00015134
			// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00003E5E File Offset: 0x0000205E
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00016F64 File Offset: 0x00015164
			// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003E7D File Offset: 0x0000207D
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00016F94 File Offset: 0x00015194
			// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003E9C File Offset: 0x0000209C
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass85_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeMethodInfoPtr__LoadResourceLocationsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_IResourceLocation_AsyncOperationHandle_0;
		}

		// Token: 0x0200005E RID: 94
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass88_0`1")]
		public sealed class __c__DisplayClass88_0<TObject> : Object
		{
			// Token: 0x060004B6 RID: 1206 RVA: 0x00016FC4 File Offset: 0x000151C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass88_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr, "locations");
				AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr, "callback");
				AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr, "releaseDependenciesOnFailure");
				AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr, 100663660);
				AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr, 100663661);
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x000170A4 File Offset: 0x000152A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass88_0<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x000170E0 File Offset: 0x000152E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159598, XrefRangeEnd = 1159599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<TObject>> _LoadAssetsWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<TObject>>(intPtr);
				}
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x00003EBB File Offset: 0x000020BB
			public __c__DisplayClass88_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060004BA RID: 1210 RVA: 0x00017130 File Offset: 0x00015330
			// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003EC4 File Offset: 0x000020C4
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x00017160 File Offset: 0x00015360
			// (set) Token: 0x060004BD RID: 1213 RVA: 0x00003EE3 File Offset: 0x000020E3
			public unsafe IList<IResourceLocation> locations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_locations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_locations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060004BE RID: 1214 RVA: 0x00017190 File Offset: 0x00015390
			// (set) Token: 0x060004BF RID: 1215 RVA: 0x00003F02 File Offset: 0x00002102
			public unsafe Action<TObject> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000171C0 File Offset: 0x000153C0
			// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00003F21 File Offset: 0x00002121
			public unsafe bool releaseDependenciesOnFailure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass88_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure)) = value;
				}
			}

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeFieldInfoPtr_locations;

			// Token: 0x0400034F RID: 847
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000350 RID: 848
			private static readonly IntPtr NativeFieldInfoPtr_releaseDependenciesOnFailure;

			// Token: 0x04000351 RID: 849
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000352 RID: 850
			private static readonly IntPtr NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0;
		}

		// Token: 0x0200005F RID: 95
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass89_0`1")]
		public sealed class __c__DisplayClass89_0<TObject> : Object
		{
			// Token: 0x060004C2 RID: 1218 RVA: 0x000171E8 File Offset: 0x000153E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass89_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass89_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr, "keys");
				AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr, "callback");
				AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr, "mode");
				AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr, "releaseDependenciesOnFailure");
				AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr, 100663662);
				AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr, 100663663);
			}

			// Token: 0x060004C3 RID: 1219 RVA: 0x000172DC File Offset: 0x000154DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass89_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass89_0<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x00017318 File Offset: 0x00015518
			[CallerCount(0)]
			public unsafe AsyncOperationHandle<IList<TObject>> _LoadAssetsWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<TObject>>(intPtr);
				}
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x00003F3C File Offset: 0x0000213C
			public __c__DisplayClass89_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00017368 File Offset: 0x00015568
			// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00003F45 File Offset: 0x00002145
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00017398 File Offset: 0x00015598
			// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00003F64 File Offset: 0x00002164
			public unsafe IEnumerable keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060004CA RID: 1226 RVA: 0x000173C8 File Offset: 0x000155C8
			// (set) Token: 0x060004CB RID: 1227 RVA: 0x00003F83 File Offset: 0x00002183
			public unsafe Action<TObject> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060004CC RID: 1228 RVA: 0x000173F8 File Offset: 0x000155F8
			// (set) Token: 0x060004CD RID: 1229 RVA: 0x00003FA2 File Offset: 0x000021A2
			public unsafe Addressables.MergeMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060004CE RID: 1230 RVA: 0x00017420 File Offset: 0x00015620
			// (set) Token: 0x060004CF RID: 1231 RVA: 0x00003FBD File Offset: 0x000021BD
			public unsafe bool releaseDependenciesOnFailure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass89_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure)) = value;
				}
			}

			// Token: 0x04000353 RID: 851
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000354 RID: 852
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x04000355 RID: 853
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000356 RID: 854
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr_releaseDependenciesOnFailure;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0;
		}

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass91_0`1")]
		public sealed class __c__DisplayClass91_0<TObject> : Object
		{
			// Token: 0x060004D0 RID: 1232 RVA: 0x00017448 File Offset: 0x00015648
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass91_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass91_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr, "callback");
				AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr, "releaseDependenciesOnFailure");
				AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr, 100663664);
				AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr, 100663665);
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00017528 File Offset: 0x00015728
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass91_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass91_0<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00017564 File Offset: 0x00015764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159599, XrefRangeEnd = 1159600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<TObject>> _LoadAssetsWithChain_b__0(AsyncOperationHandle op2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op2));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<TObject>>(intPtr);
				}
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x00003FD8 File Offset: 0x000021D8
			public __c__DisplayClass91_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x060004D4 RID: 1236 RVA: 0x000175B4 File Offset: 0x000157B4
			// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00003FE1 File Offset: 0x000021E1
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000175E4 File Offset: 0x000157E4
			// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00004000 File Offset: 0x00002200
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00017614 File Offset: 0x00015814
			// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0000401F File Offset: 0x0000221F
			public unsafe Action<TObject> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x060004DA RID: 1242 RVA: 0x00017644 File Offset: 0x00015844
			// (set) Token: 0x060004DB RID: 1243 RVA: 0x0000403E File Offset: 0x0000223E
			public unsafe bool releaseDependenciesOnFailure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass91_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure)) = value;
				}
			}

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400035C RID: 860
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400035D RID: 861
			private static readonly IntPtr NativeFieldInfoPtr_releaseDependenciesOnFailure;

			// Token: 0x0400035E RID: 862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeMethodInfoPtr__LoadAssetsWithChain_b__0_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0;
		}

		// Token: 0x02000061 RID: 97
		[ObfuscatedName("UnityEngine.AddressableAssets.AddressablesImpl+<>c__DisplayClass99_0")]
		public sealed class __c__DisplayClass99_0 : Object
		{
			// Token: 0x060004DC RID: 1244 RVA: 0x0001766C File Offset: 0x0001586C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass99_0()
			{
				Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass99_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr, "<>c__DisplayClass99_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass99_0>.NativeClassPtr);
				AddressablesImpl.__c__DisplayClass99_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass99_0>.NativeClassPtr, "<>4__this");
				AddressablesImpl.__c__DisplayClass99_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass99_0>.NativeClassPtr, "key");
				AddressablesImpl.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass99_0>.NativeClassPtr, 100663666);
				AddressablesImpl.__c__DisplayClass99_0.NativeMethodInfoPtr__GetDownloadSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass99_0>.NativeClassPtr, 100663667);
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x000176E8 File Offset: 0x000158E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass99_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesImpl.__c__DisplayClass99_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x00017724 File Offset: 0x00015924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159600, XrefRangeEnd = 1159606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<long> _GetDownloadSizeWithChain_b__0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesImpl.__c__DisplayClass99_0.NativeMethodInfoPtr__GetDownloadSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<long>(intPtr);
				}
			}

			// Token: 0x060004DF RID: 1247 RVA: 0x00004059 File Offset: 0x00002259
			public __c__DisplayClass99_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00017774 File Offset: 0x00015974
			// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00004062 File Offset: 0x00002262
			public unsafe AddressablesImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass99_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass99_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000177A4 File Offset: 0x000159A4
			// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004081 File Offset: 0x00002281
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass99_0.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressablesImpl.__c__DisplayClass99_0.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000360 RID: 864
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000361 RID: 865
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04000362 RID: 866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000363 RID: 867
			private static readonly IntPtr NativeMethodInfoPtr__GetDownloadSizeWithChain_b__0_Internal_AsyncOperationHandle_1_Int64_AsyncOperationHandle_0;
		}

		// Token: 0x02000062 RID: 98
		private sealed class MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_IResourceLocation_0<T>
		{
			// Token: 0x04000364 RID: 868
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_IResourceLocation_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000063 RID: 99
		private sealed class MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_0<T>
		{
			// Token: 0x04000365 RID: 869
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000064 RID: 100
		private sealed class MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_String_0<T>
		{
			// Token: 0x04000366 RID: 870
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_ResourceLocationBase_String_String_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000065 RID: 101
		private sealed class MethodInfoStoreGeneric_TrackHandle_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x04000367 RID: 871
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_TrackHandle_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000066 RID: 102
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>
		{
			// Token: 0x04000368 RID: 872
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000067 RID: 103
		private sealed class MethodInfoStoreGeneric_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_IResourceLocation_0<TObject>
		{
			// Token: 0x04000369 RID: 873
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_IResourceLocation_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000068 RID: 104
		private sealed class MethodInfoStoreGeneric_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Object_0<TObject>
		{
			// Token: 0x0400036A RID: 874
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetWithChain_Private_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Object_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000069 RID: 105
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_Object_0<TObject>
		{
			// Token: 0x0400036B RID: 875
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_Object_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006A RID: 106
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0<TObject>
		{
			// Token: 0x0400036C RID: 876
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006B RID: 107
		private sealed class MethodInfoStoreGeneric_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IList_1_IResourceLocation_Action_1_TObject_Boolean_0<TObject>
		{
			// Token: 0x0400036D RID: 877
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IList_1_IResourceLocation_Action_1_TObject_Boolean_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006C RID: 108
		private sealed class MethodInfoStoreGeneric_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IEnumerable_Action_1_TObject_MergeMode_Boolean_0<TObject>
		{
			// Token: 0x0400036E RID: 878
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_IEnumerable_Action_1_TObject_MergeMode_Boolean_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006D RID: 109
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0<TObject>
		{
			// Token: 0x0400036F RID: 879
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006E RID: 110
		private sealed class MethodInfoStoreGeneric_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_Object_Action_1_TObject_Boolean_0<TObject>
		{
			// Token: 0x04000370 RID: 880
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetsWithChain_Private_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_Object_Action_1_TObject_Boolean_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006F RID: 111
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0<TObject>
		{
			// Token: 0x04000371 RID: 881
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_LoadAssetsAsync_Public_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000070 RID: 112
		private sealed class MethodInfoStoreGeneric_Release_Public_Void_TObject_0<TObject>
		{
			// Token: 0x04000372 RID: 882
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_Release_Public_Void_TObject_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000071 RID: 113
		private sealed class MethodInfoStoreGeneric_Release_Public_Void_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x04000373 RID: 883
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000072 RID: 114
		private sealed class MethodInfoStoreGeneric_AutoReleaseHandleOnTypelessCompletion_Internal_Void_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x04000374 RID: 884
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesImpl.NativeMethodInfoPtr_AutoReleaseHandleOnTypelessCompletion_Internal_Void_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<AddressablesImpl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
