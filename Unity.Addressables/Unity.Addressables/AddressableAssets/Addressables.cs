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
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000009 RID: 9
	public static class Addressables : Object
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00006160 File Offset: 0x00004360
		// Note: this type is marked as 'beforefieldinit'.
		static Addressables()
		{
			Il2CppClassPointerStore<Addressables>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "Addressables");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Addressables>.NativeClassPtr);
			Addressables.NativeFieldInfoPtr_reinitializeAddressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Addressables>.NativeClassPtr, "reinitializeAddressables");
			Addressables.NativeFieldInfoPtr_m_AddressablesInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Addressables>.NativeClassPtr, "m_AddressablesInstance");
			Addressables.NativeFieldInfoPtr_kAddressablesRuntimeDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Addressables>.NativeClassPtr, "kAddressablesRuntimeDataPath");
			Addressables.NativeFieldInfoPtr_k_AddressablesLogConditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Addressables>.NativeClassPtr, "k_AddressablesLogConditional");
			Addressables.NativeFieldInfoPtr_kAddressablesRuntimeBuildLogPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Addressables>.NativeClassPtr, "kAddressablesRuntimeBuildLogPath");
			Addressables.NativeFieldInfoPtr_LibraryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Addressables>.NativeClassPtr, "LibraryPath");
			Addressables.NativeFieldInfoPtr_BuildReportPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Addressables>.NativeClassPtr, "BuildReportPath");
			Addressables.NativeMethodInfoPtr_get_m_Addressables_Private_Static_get_AddressablesImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663352);
			Addressables.NativeMethodInfoPtr_get_Version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663353);
			Addressables.NativeMethodInfoPtr_get_ResourceManager_Public_Static_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663354);
			Addressables.NativeMethodInfoPtr_get_Instance_Internal_Static_get_AddressablesImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663355);
			Addressables.NativeMethodInfoPtr_get_InstanceProvider_Public_Static_get_IInstanceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663356);
			Addressables.NativeMethodInfoPtr_ResolveInternalId_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663357);
			Addressables.NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_Static_get_Func_2_IResourceLocation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663358);
			Addressables.NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_Static_set_Void_Func_2_IResourceLocation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663359);
			Addressables.NativeMethodInfoPtr_get_WebRequestOverride_Public_Static_get_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663360);
			Addressables.NativeMethodInfoPtr_set_WebRequestOverride_Public_Static_set_Void_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663361);
			Addressables.NativeMethodInfoPtr_get_StreamingAssetsSubFolder_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663362);
			Addressables.NativeMethodInfoPtr_get_BuildPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663363);
			Addressables.NativeMethodInfoPtr_get_PlayerBuildDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663364);
			Addressables.NativeMethodInfoPtr_get_RuntimePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663365);
			Addressables.NativeMethodInfoPtr_get_ResourceLocators_Public_Static_get_IEnumerable_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663366);
			Addressables.NativeMethodInfoPtr_InternalSafeSerializationLog_Internal_Static_Void_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663367);
			Addressables.NativeMethodInfoPtr_InternalSafeSerializationLogFormat_Internal_Static_Void_String_LogType_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663368);
			Addressables.NativeMethodInfoPtr_Log_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663369);
			Addressables.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663370);
			Addressables.NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663371);
			Addressables.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663372);
			Addressables.NativeMethodInfoPtr_LogError_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663373);
			Addressables.NativeMethodInfoPtr_LogException_Public_Static_Void_AsyncOperationHandle_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663374);
			Addressables.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663375);
			Addressables.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663376);
			Addressables.NativeMethodInfoPtr_Initialize_Public_Static_AsyncOperationHandle_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663377);
			Addressables.NativeMethodInfoPtr_InitializeAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663378);
			Addressables.NativeMethodInfoPtr_InitializeAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663379);
			Addressables.NativeMethodInfoPtr_LoadContentCatalog_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663380);
			Addressables.NativeMethodInfoPtr_LoadContentCatalogAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663381);
			Addressables.NativeMethodInfoPtr_LoadContentCatalogAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663382);
			Addressables.NativeMethodInfoPtr_get_InitializationOperation_Public_Static_get_AsyncOperationHandle_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663383);
			Addressables.NativeMethodInfoPtr_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663384);
			Addressables.NativeMethodInfoPtr_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663385);
			Addressables.NativeMethodInfoPtr_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663386);
			Addressables.NativeMethodInfoPtr_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663387);
			Addressables.NativeMethodInfoPtr_LoadResourceLocations_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IList_1_Object_MergeMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663388);
			Addressables.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IList_1_Object_MergeMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663389);
			Addressables.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663390);
			Addressables.NativeMethodInfoPtr_LoadResourceLocations_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663391);
			Addressables.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663392);
			Addressables.NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663393);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663394);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663395);
			Addressables.NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663396);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663397);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663398);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663399);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663400);
			Addressables.NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663401);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663402);
			Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663403);
			Addressables.NativeMethodInfoPtr_Release_Public_Static_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663404);
			Addressables.NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663405);
			Addressables.NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663406);
			Addressables.NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663407);
			Addressables.NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663408);
			Addressables.NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_AsyncOperationHandle_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663409);
			Addressables.NativeMethodInfoPtr_GetDownloadSize_Public_Static_AsyncOperationHandle_1_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663410);
			Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663411);
			Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663412);
			Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663413);
			Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663414);
			Addressables.NativeMethodInfoPtr_DownloadDependencies_Public_Static_AsyncOperationHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663415);
			Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663416);
			Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663417);
			Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IList_1_Object_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663418);
			Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663419);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663420);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663421);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663422);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663423);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663424);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663425);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IList_1_IResourceLocation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663426);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IList_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663427);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IEnumerable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663428);
			Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663429);
			Addressables.NativeMethodInfoPtr_GetLocatorInfo_Public_Static_ResourceLocatorInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663430);
			Addressables.NativeMethodInfoPtr_GetLocatorInfo_Public_Static_ResourceLocatorInfo_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663431);
			Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663432);
			Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663433);
			Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663434);
			Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663435);
			Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663436);
			Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663437);
			Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663438);
			Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663439);
			Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663440);
			Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663441);
			Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663442);
			Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663443);
			Addressables.NativeMethodInfoPtr_LoadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663444);
			Addressables.NativeMethodInfoPtr_LoadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663445);
			Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663446);
			Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneParameters_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663447);
			Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663448);
			Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneParameters_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663449);
			Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663450);
			Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663451);
			Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663452);
			Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663453);
			Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663454);
			Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663455);
			Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663456);
			Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663457);
			Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663458);
			Addressables.NativeMethodInfoPtr_CheckForCatalogUpdates_Public_Static_AsyncOperationHandle_1_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663459);
			Addressables.NativeMethodInfoPtr_UpdateCatalogs_Public_Static_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663460);
			Addressables.NativeMethodInfoPtr_UpdateCatalogs_Public_Static_AsyncOperationHandle_1_List_1_IResourceLocator_Boolean_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663461);
			Addressables.NativeMethodInfoPtr_AddResourceLocator_Public_Static_Void_IResourceLocator_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663462);
			Addressables.NativeMethodInfoPtr_RemoveResourceLocator_Public_Static_Void_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663463);
			Addressables.NativeMethodInfoPtr_ClearResourceLocators_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663464);
			Addressables.NativeMethodInfoPtr_CleanBundleCache_Public_Static_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663465);
			Addressables.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663466);
			Addressables.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663467);
			Addressables.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Addressables>.NativeClassPtr, 100663468);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006B40 File Offset: 0x00004D40
		public unsafe static AddressablesImpl m_Addressables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158470, XrefRangeEnd = 1158474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_m_Addressables_Private_Static_get_AddressablesImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr3) : null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00006B74 File Offset: 0x00004D74
		public unsafe static string Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158474, XrefRangeEnd = 1158476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_Version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public unsafe static ResourceManager ResourceManager
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1158483, RefRangeEnd = 1158490, XrefRangeStart = 1158476, XrefRangeEnd = 1158483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_ResourceManager_Public_Static_get_ResourceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public unsafe static AddressablesImpl Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158490, XrefRangeEnd = 1158498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_Instance_Internal_Static_get_AddressablesImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr3) : null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006C08 File Offset: 0x00004E08
		public unsafe static IInstanceProvider InstanceProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158498, XrefRangeEnd = 1158505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_InstanceProvider_Public_Static_get_IInstanceProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInstanceProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006C3C File Offset: 0x00004E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1158514, RefRangeEnd = 1158518, XrefRangeStart = 1158505, XrefRangeEnd = 1158514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ResolveInternalId(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ResolveInternalId_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00006CAC File Offset: 0x00004EAC
		public unsafe static Func<IResourceLocation, string> InternalIdTransformFunc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158518, XrefRangeEnd = 1158525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_Static_get_Func_2_IResourceLocation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IResourceLocation, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158525, XrefRangeEnd = 1158534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_Static_set_Void_Func_2_IResourceLocation_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00006CE4 File Offset: 0x00004EE4
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00006D18 File Offset: 0x00004F18
		public unsafe static Action<UnityWebRequest> WebRequestOverride
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158534, XrefRangeEnd = 1158541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_WebRequestOverride_Public_Static_get_Action_1_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158541, XrefRangeEnd = 1158550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_set_WebRequestOverride_Public_Static_set_Void_Action_1_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00006D50 File Offset: 0x00004F50
		public unsafe static string StreamingAssetsSubFolder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158550, XrefRangeEnd = 1158559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_StreamingAssetsSubFolder_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00006D7C File Offset: 0x00004F7C
		public unsafe static string BuildPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158559, XrefRangeEnd = 1158568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_BuildPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00006DA8 File Offset: 0x00004FA8
		public unsafe static string PlayerBuildDataPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158568, XrefRangeEnd = 1158577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_PlayerBuildDataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00006DD4 File Offset: 0x00004FD4
		public unsafe static string RuntimePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158577, XrefRangeEnd = 1158586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_RuntimePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00006E00 File Offset: 0x00005000
		public unsafe static IEnumerable<IResourceLocator> ResourceLocators
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1158595, RefRangeEnd = 1158596, XrefRangeStart = 1158586, XrefRangeEnd = 1158595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_ResourceLocators_Public_Static_get_IEnumerable_1_IResourceLocator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IResourceLocator>>(intPtr3) : null;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006E34 File Offset: 0x00005034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158596, XrefRangeEnd = 1158603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSafeSerializationLog(string msg, LogType logType = LogType.Log)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InternalSafeSerializationLog_Internal_Static_Void_String_LogType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00006E78 File Offset: 0x00005078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158603, XrefRangeEnd = 1158610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSafeSerializationLogFormat(string format, LogType logType = LogType.Log, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InternalSafeSerializationLogFormat_Internal_Static_Void_String_LogType_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006EDC File Offset: 0x000050DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158610, XrefRangeEnd = 1158622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(string msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Log_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006F14 File Offset: 0x00005114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158622, XrefRangeEnd = 1158634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006F6C File Offset: 0x0000516C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1158646, RefRangeEnd = 1158650, XrefRangeStart = 1158634, XrefRangeEnd = 1158646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(string msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006FA4 File Offset: 0x000051A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1158662, RefRangeEnd = 1158665, XrefRangeStart = 1158650, XrefRangeEnd = 1158662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006FFC File Offset: 0x000051FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1158677, RefRangeEnd = 1158682, XrefRangeStart = 1158665, XrefRangeEnd = 1158677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(string msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LogError_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007034 File Offset: 0x00005234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158682, XrefRangeEnd = 1158694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(AsyncOperationHandle op, Exception ex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LogException_Public_Static_Void_AsyncOperationHandle_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007084 File Offset: 0x00005284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158694, XrefRangeEnd = 1158701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception ex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000070BC File Offset: 0x000052BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1158713, RefRangeEnd = 1158715, XrefRangeStart = 1158701, XrefRangeEnd = 1158713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007114 File Offset: 0x00005314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158715, XrefRangeEnd = 1158731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Initialize_Public_Static_AsyncOperationHandle_1_IResourceLocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007140 File Offset: 0x00005340
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1158744, RefRangeEnd = 1158747, XrefRangeStart = 1158731, XrefRangeEnd = 1158744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> InitializeAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InitializeAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000716C File Offset: 0x0000536C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158747, XrefRangeEnd = 1158760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoReleaseHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InitializeAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<IResourceLocator>(intPtr);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000071A4 File Offset: 0x000053A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158760, XrefRangeEnd = 1158771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(catalogPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadContentCatalog_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000071F4 File Offset: 0x000053F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158771, XrefRangeEnd = 1158779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(catalogPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadContentCatalogAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007244 File Offset: 0x00005444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158779, XrefRangeEnd = 1158787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(catalogPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadContentCatalogAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000072A0 File Offset: 0x000054A0
		public unsafe static AsyncOperationHandle<IResourceLocator> InitializationOperation
		{
			[CallerCount(492)]
			[CachedScanResults(RefRangeStart = 547521, RefRangeEnd = 548013, XrefRangeStart = 547521, XrefRangeEnd = 548013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_get_InitializationOperation_Public_Static_get_AsyncOperationHandle_1_IResourceLocator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<IResourceLocator>(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000072CC File Offset: 0x000054CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158787, XrefRangeEnd = 1158791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007308 File Offset: 0x00005508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<TObject> LoadAsset<TObject>(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_Object_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007344 File Offset: 0x00005544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1158800, RefRangeEnd = 1158801, XrefRangeStart = 1158791, XrefRangeEnd = 1158800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007380 File Offset: 0x00005580
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1158810, RefRangeEnd = 1158817, XrefRangeStart = 1158801, XrefRangeEnd = 1158810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_Object_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000073BC File Offset: 0x000055BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158817, XrefRangeEnd = 1158828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<Object> keys, Addressables.MergeMode mode, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadResourceLocations_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IList_1_Object_MergeMode_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007418 File Offset: 0x00005618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158828, XrefRangeEnd = 1158836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<Object> keys, Addressables.MergeMode mode, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IList_1_Object_MergeMode_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007474 File Offset: 0x00005674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1158844, RefRangeEnd = 1158846, XrefRangeStart = 1158836, XrefRangeEnd = 1158844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000074D0 File Offset: 0x000056D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158846, XrefRangeEnd = 1158857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(Object key, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadResourceLocations_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00007520 File Offset: 0x00005720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1158865, RefRangeEnd = 1158866, XrefRangeStart = 1158857, XrefRangeEnd = 1158865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(Object key, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00007570 File Offset: 0x00005770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158866, XrefRangeEnd = 1158870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000075C0 File Offset: 0x000057C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158870, XrefRangeEnd = 1158878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007610 File Offset: 0x00005810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158878, XrefRangeEnd = 1158886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000766C File Offset: 0x0000586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158886, XrefRangeEnd = 1158890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<Object> keys, Action<TObject> callback, Addressables.MergeMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000076C8 File Offset: 0x000058C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158890, XrefRangeEnd = 1158898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<Object> keys, Action<TObject> callback, Addressables.MergeMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007724 File Offset: 0x00005924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007780 File Offset: 0x00005980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158898, XrefRangeEnd = 1158906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<Object> keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_Boolean_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000077EC File Offset: 0x000059EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007858 File Offset: 0x00005A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(Object key, Action<TObject> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000078A8 File Offset: 0x00005AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1158915, RefRangeEnd = 1158916, XrefRangeStart = 1158906, XrefRangeEnd = 1158915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(Object key, Action<TObject> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000078F8 File Offset: 0x00005AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(Object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00007954 File Offset: 0x00005B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158916, XrefRangeEnd = 1158926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release<TObject>(TObject obj)
		{
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_Release_Public_Static_Void_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000079C0 File Offset: 0x00005BC0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1158928, RefRangeEnd = 1158937, XrefRangeStart = 1158926, XrefRangeEnd = 1158928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release<TObject>(AsyncOperationHandle<TObject> handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_Release_Public_Static_Void_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000079FC File Offset: 0x00005BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1158938, RefRangeEnd = 1158939, XrefRangeStart = 1158937, XrefRangeEnd = 1158938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(AsyncOperationHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007A38 File Offset: 0x00005C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158939, XrefRangeEnd = 1158955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseInstance(GameObject instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007A7C File Offset: 0x00005C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158955, XrefRangeEnd = 1158956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseInstance(AsyncOperationHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_AsyncOperationHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00007AC4 File Offset: 0x00005CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158956, XrefRangeEnd = 1158959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_AsyncOperationHandle_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007B0C File Offset: 0x00005D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158959, XrefRangeEnd = 1158975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<long> GetDownloadSize(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_GetDownloadSize_Public_Static_AsyncOperationHandle_1_Int64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007B48 File Offset: 0x00005D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158975, XrefRangeEnd = 1158988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<long> GetDownloadSizeAsync(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007B84 File Offset: 0x00005D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158988, XrefRangeEnd = 1159001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<long> GetDownloadSizeAsync(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159001, XrefRangeEnd = 1159009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<Object> keys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_IList_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007BFC File Offset: 0x00005DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159009, XrefRangeEnd = 1159017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_IEnumerable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<long>(intPtr);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007C38 File Offset: 0x00005E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159017, XrefRangeEnd = 1159028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle DownloadDependencies(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_DownloadDependencies_Public_Static_AsyncOperationHandle_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007C74 File Offset: 0x00005E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159028, XrefRangeEnd = 1159036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle DownloadDependenciesAsync(Object key, bool autoReleaseHandle = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007CC0 File Offset: 0x00005EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159036, XrefRangeEnd = 1159044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007D0C File Offset: 0x00005F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159044, XrefRangeEnd = 1159052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle DownloadDependenciesAsync(IList<Object> keys, Addressables.MergeMode mode, bool autoReleaseHandle = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IList_1_Object_MergeMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007D64 File Offset: 0x00005F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159052, XrefRangeEnd = 1159060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007DBC File Offset: 0x00005FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159060, XrefRangeEnd = 1159068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearDependencyCacheAsync(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00007DF4 File Offset: 0x00005FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159068, XrefRangeEnd = 1159076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearDependencyCacheAsync(IList<IResourceLocation> locations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IList_1_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007E2C File Offset: 0x0000602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159076, XrefRangeEnd = 1159084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearDependencyCacheAsync(IList<Object> keys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IList_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007E64 File Offset: 0x00006064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159084, XrefRangeEnd = 1159092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearDependencyCacheAsync(IEnumerable keys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IEnumerable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007E9C File Offset: 0x0000609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159092, XrefRangeEnd = 1159100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearDependencyCacheAsync(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007ED4 File Offset: 0x000060D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159100, XrefRangeEnd = 1159108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<bool> ClearDependencyCacheAsync(Object key, bool autoReleaseHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007F20 File Offset: 0x00006120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159108, XrefRangeEnd = 1159116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IList_1_IResourceLocation_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007F6C File Offset: 0x0000616C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159116, XrefRangeEnd = 1159124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<Object> keys, bool autoReleaseHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IList_1_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007FB8 File Offset: 0x000061B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159124, XrefRangeEnd = 1159132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IEnumerable_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00008004 File Offset: 0x00006204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159132, XrefRangeEnd = 1159140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00008050 File Offset: 0x00006250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159140, XrefRangeEnd = 1159149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceLocatorInfo GetLocatorInfo(string locatorId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(locatorId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_GetLocatorInfo_Public_Static_ResourceLocatorInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocatorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008094 File Offset: 0x00006294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159149, XrefRangeEnd = 1159161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_GetLocatorInfo_Public_Static_ResourceLocatorInfo_IResourceLocator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocatorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000080D8 File Offset: 0x000062D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159161, XrefRangeEnd = 1159166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00008144 File Offset: 0x00006344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159166, XrefRangeEnd = 1159178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000081BC File Offset: 0x000063BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159178, XrefRangeEnd = 1159182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> Instantiate(Object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008228 File Offset: 0x00006428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159182, XrefRangeEnd = 1159186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> Instantiate(Object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000082A0 File Offset: 0x000064A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159186, XrefRangeEnd = 1159197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> Instantiate(Object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00008304 File Offset: 0x00006504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159197, XrefRangeEnd = 1159201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00008368 File Offset: 0x00006568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159201, XrefRangeEnd = 1159210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000083D4 File Offset: 0x000065D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159210, XrefRangeEnd = 1159219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000844C File Offset: 0x0000664C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1159228, RefRangeEnd = 1159230, XrefRangeStart = 1159219, XrefRangeEnd = 1159228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(Object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000084B8 File Offset: 0x000066B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1159239, RefRangeEnd = 1159241, XrefRangeStart = 1159230, XrefRangeEnd = 1159239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(Object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00008530 File Offset: 0x00006730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159241, XrefRangeEnd = 1159249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(Object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00008594 File Offset: 0x00006794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1159257, RefRangeEnd = 1159259, XrefRangeStart = 1159249, XrefRangeEnd = 1159257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000085F8 File Offset: 0x000067F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159259, XrefRangeEnd = 1159263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> LoadScene(Object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneMode_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008660 File Offset: 0x00006860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159263, XrefRangeEnd = 1159275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000086C8 File Offset: 0x000068C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1159284, RefRangeEnd = 1159288, XrefRangeStart = 1159275, XrefRangeEnd = 1159284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> LoadSceneAsync(Object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneMode_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008730 File Offset: 0x00006930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159288, XrefRangeEnd = 1159296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> LoadSceneAsync(Object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneParameters_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008798 File Offset: 0x00006998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159296, XrefRangeEnd = 1159305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00008800 File Offset: 0x00006A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159305, XrefRangeEnd = 1159313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneParameters_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008868 File Offset: 0x00006A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159313, XrefRangeEnd = 1159324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(scene));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000088B8 File Offset: 0x00006AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159324, XrefRangeEnd = 1159335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00008908 File Offset: 0x00006B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159335, XrefRangeEnd = 1159346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00008958 File Offset: 0x00006B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159346, XrefRangeEnd = 1159360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000089B8 File Offset: 0x00006BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159360, XrefRangeEnd = 1159368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(scene));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_UnloadSceneOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00008A18 File Offset: 0x00006C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159368, XrefRangeEnd = 1159376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00008A78 File Offset: 0x00006C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159376, XrefRangeEnd = 1159384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(scene));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00008AC8 File Offset: 0x00006CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159384, XrefRangeEnd = 1159392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00008B18 File Offset: 0x00006D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159392, XrefRangeEnd = 1159400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00008B68 File Offset: 0x00006D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159400, XrefRangeEnd = 1159408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoReleaseHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_CheckForCatalogUpdates_Public_Static_AsyncOperationHandle_1_List_1_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<List<string>>(intPtr);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00008BA0 File Offset: 0x00006DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159408, XrefRangeEnd = 1159416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs = null, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UpdateCatalogs_Public_Static_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<List<IResourceLocator>>(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00008BEC File Offset: 0x00006DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159416, XrefRangeEnd = 1159424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, IEnumerable<string> catalogs = null, bool autoReleaseHandle = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoCleanBundleCache;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(catalogs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoReleaseHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_UpdateCatalogs_Public_Static_AsyncOperationHandle_1_List_1_IResourceLocator_Boolean_IEnumerable_1_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<List<IResourceLocator>>(intPtr);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00008C44 File Offset: 0x00006E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159424, XrefRangeEnd = 1159432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddResourceLocator(IResourceLocator locator, string localCatalogHash = null, IResourceLocation remoteCatalogLocation = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localCatalogHash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCatalogLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_AddResourceLocator_Public_Static_Void_IResourceLocator_String_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159432, XrefRangeEnd = 1159441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveResourceLocator(IResourceLocator locator)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_RemoveResourceLocator_Public_Static_Void_IResourceLocator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00008CD8 File Offset: 0x00006ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159441, XrefRangeEnd = 1159450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearResourceLocators()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_ClearResourceLocators_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00008D00 File Offset: 0x00006F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159450, XrefRangeEnd = 1159458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogsIds = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogsIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.NativeMethodInfoPtr_CleanBundleCache_Public_Static_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<bool>(intPtr);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00008D3C File Offset: 0x00006F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159458, XrefRangeEnd = 1159475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(remoteCatalogPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationBase>(intPtr3) : null;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00008D80 File Offset: 0x00006F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation remoteCatalogLocation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteCatalogLocation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_IResourceLocation_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationBase>(intPtr3) : null;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00008DC4 File Offset: 0x00006FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159475, XrefRangeEnd = 1159484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(remoteCatalogPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(remoteHashPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Addressables.MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationBase>(intPtr3) : null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000228A File Offset: 0x0000048A
		public static void InternalSafeSerializationLogFormat(string format, [Optional] LogType logType, params Object[] args)
		{
			Addressables.InternalSafeSerializationLogFormat(format, logType, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002299 File Offset: 0x00000499
		public static void LogFormat(string format, params Object[] args)
		{
			Addressables.LogFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000022A7 File Offset: 0x000004A7
		public static void LogWarningFormat(string format, params Object[] args)
		{
			Addressables.LogWarningFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000022B5 File Offset: 0x000004B5
		public static void LogErrorFormat(string format, params Object[] args)
		{
			Addressables.LogErrorFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000022C3 File Offset: 0x000004C3
		public Addressables(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00008E1C File Offset: 0x0000701C
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000022CC File Offset: 0x000004CC
		public unsafe static bool reinitializeAddressables
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Addressables.NativeFieldInfoPtr_reinitializeAddressables, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Addressables.NativeFieldInfoPtr_reinitializeAddressables, (void*)(&value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00008E38 File Offset: 0x00007038
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000022DA File Offset: 0x000004DA
		public unsafe static AddressablesImpl m_AddressablesInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Addressables.NativeFieldInfoPtr_m_AddressablesInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Addressables.NativeFieldInfoPtr_m_AddressablesInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00008E60 File Offset: 0x00007060
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000022EC File Offset: 0x000004EC
		public unsafe static string kAddressablesRuntimeDataPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Addressables.NativeFieldInfoPtr_kAddressablesRuntimeDataPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Addressables.NativeFieldInfoPtr_kAddressablesRuntimeDataPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00008E80 File Offset: 0x00007080
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000022FE File Offset: 0x000004FE
		public unsafe static string k_AddressablesLogConditional
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Addressables.NativeFieldInfoPtr_k_AddressablesLogConditional, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Addressables.NativeFieldInfoPtr_k_AddressablesLogConditional, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00008EA0 File Offset: 0x000070A0
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002310 File Offset: 0x00000510
		public unsafe static string kAddressablesRuntimeBuildLogPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Addressables.NativeFieldInfoPtr_kAddressablesRuntimeBuildLogPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Addressables.NativeFieldInfoPtr_kAddressablesRuntimeBuildLogPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00008EC0 File Offset: 0x000070C0
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002322 File Offset: 0x00000522
		public unsafe static string LibraryPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Addressables.NativeFieldInfoPtr_LibraryPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Addressables.NativeFieldInfoPtr_LibraryPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00008EE0 File Offset: 0x000070E0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002334 File Offset: 0x00000534
		public unsafe static string BuildReportPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Addressables.NativeFieldInfoPtr_BuildReportPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Addressables.NativeFieldInfoPtr_BuildReportPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_reinitializeAddressables;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_m_AddressablesInstance;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_kAddressablesRuntimeDataPath;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_k_AddressablesLogConditional;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_kAddressablesRuntimeBuildLogPath;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_LibraryPath;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_BuildReportPath;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_m_Addressables_Private_Static_get_AddressablesImpl_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Static_get_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceManager_Public_Static_get_ResourceManager_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_AddressablesImpl_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceProvider_Public_Static_get_IInstanceProvider_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_ResolveInternalId_Public_Static_String_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_Static_get_Func_2_IResourceLocation_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_Static_set_Void_Func_2_IResourceLocation_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_WebRequestOverride_Public_Static_get_Action_1_UnityWebRequest_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_WebRequestOverride_Public_Static_set_Void_Action_1_UnityWebRequest_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_StreamingAssetsSubFolder_Public_Static_get_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildPath_Public_Static_get_String_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerBuildDataPath_Public_Static_get_String_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_RuntimePath_Public_Static_get_String_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceLocators_Public_Static_get_IEnumerable_1_IResourceLocator_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_InternalSafeSerializationLog_Internal_Static_Void_String_LogType_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_InternalSafeSerializationLogFormat_Internal_Static_Void_String_LogType_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_AsyncOperationHandle_Exception_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_AsyncOperationHandle_1_IResourceLocator_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentCatalog_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentCatalogAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentCatalogAsync_Public_Static_AsyncOperationHandle_1_IResourceLocator_String_Boolean_String_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializationOperation_Public_Static_get_AsyncOperationHandle_1_IResourceLocator_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_Object_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_Object_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocations_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IList_1_Object_MergeMode_Type_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IList_1_Object_MergeMode_Type_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocations_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_Object_Type_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_TObject_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_GameObject_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_AsyncOperationHandle_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Public_Static_Boolean_AsyncOperationHandle_1_GameObject_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSize_Public_Static_AsyncOperationHandle_1_Int64_Object_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_Object_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_IList_1_Object_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadSizeAsync_Public_Static_AsyncOperationHandle_1_Int64_IEnumerable_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependencies_Public_Static_AsyncOperationHandle_Object_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_Object_Boolean_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IList_1_Object_MergeMode_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_DownloadDependenciesAsync_Public_Static_AsyncOperationHandle_IEnumerable_MergeMode_Boolean_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_Object_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IList_1_IResourceLocation_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IList_1_Object_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_IEnumerable_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_Void_String_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_Object_Boolean_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IList_1_IResourceLocation_Boolean_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IList_1_Object_Boolean_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_IEnumerable_Boolean_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_ClearDependencyCacheAsync_Public_Static_AsyncOperationHandle_1_Boolean_String_Boolean_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_GetLocatorInfo_Public_Static_ResourceLocatorInfo_String_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetLocatorInfo_Public_Static_ResourceLocatorInfo_IResourceLocator_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Transform_Boolean_Boolean_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_Vector3_Quaternion_Transform_Boolean_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_Transform_Boolean_Boolean_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_Vector3_Quaternion_Transform_Boolean_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_Object_InstantiationParameters_Boolean_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncOperationHandle_1_GameObject_IResourceLocation_InstantiationParameters_Boolean_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_Object_LoadSceneParameters_Boolean_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_IResourceLocation_LoadSceneParameters_Boolean_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_Boolean_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_Boolean_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_UnloadScene_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_Boolean_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_UnloadSceneOptions_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_UnloadSceneOptions_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_SceneInstance_Boolean_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_Boolean_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperationHandle_1_SceneInstance_AsyncOperationHandle_1_SceneInstance_Boolean_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_CheckForCatalogUpdates_Public_Static_AsyncOperationHandle_1_List_1_String_Boolean_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCatalogs_Public_Static_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCatalogs_Public_Static_AsyncOperationHandle_1_List_1_IResourceLocator_Boolean_IEnumerable_1_String_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceLocator_Public_Static_Void_IResourceLocator_String_IResourceLocation_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_RemoveResourceLocator_Public_Static_Void_IResourceLocator_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_ClearResourceLocators_Public_Static_Void_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_CleanBundleCache_Public_Static_AsyncOperationHandle_1_Boolean_IEnumerable_1_String_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_IResourceLocation_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_String_0;

		// Token: 0x0200002D RID: 45
		public enum MergeMode
		{
			// Token: 0x0400029F RID: 671
			None,
			// Token: 0x040002A0 RID: 672
			UseFirst = 0,
			// Token: 0x040002A1 RID: 673
			Union,
			// Token: 0x040002A2 RID: 674
			Intersection
		}

		// Token: 0x0200002E RID: 46
		private sealed class MethodInfoStoreGeneric_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>
		{
			// Token: 0x040002A3 RID: 675
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002F RID: 47
		private sealed class MethodInfoStoreGeneric_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_Object_0<TObject>
		{
			// Token: 0x040002A4 RID: 676
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAsset_Public_Static_AsyncOperationHandle_1_TObject_Object_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000030 RID: 48
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>
		{
			// Token: 0x040002A5 RID: 677
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000031 RID: 49
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_Object_0<TObject>
		{
			// Token: 0x040002A6 RID: 678
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetAsync_Public_Static_AsyncOperationHandle_1_TObject_Object_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000032 RID: 50
		private sealed class MethodInfoStoreGeneric_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>
		{
			// Token: 0x040002A7 RID: 679
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000033 RID: 51
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>
		{
			// Token: 0x040002A8 RID: 680
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000034 RID: 52
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0<TObject>
		{
			// Token: 0x040002A9 RID: 681
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_Boolean_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000035 RID: 53
		private sealed class MethodInfoStoreGeneric_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0<TObject>
		{
			// Token: 0x040002AA RID: 682
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000036 RID: 54
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0<TObject>
		{
			// Token: 0x040002AB RID: 683
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000037 RID: 55
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_0<TObject>
		{
			// Token: 0x040002AC RID: 684
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000038 RID: 56
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_Boolean_0<TObject>
		{
			// Token: 0x040002AD RID: 685
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_Object_Action_1_TObject_MergeMode_Boolean_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000039 RID: 57
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0<TObject>
		{
			// Token: 0x040002AE RID: 686
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IEnumerable_Action_1_TObject_MergeMode_Boolean_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003A RID: 58
		private sealed class MethodInfoStoreGeneric_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0<TObject>
		{
			// Token: 0x040002AF RID: 687
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssets_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003B RID: 59
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0<TObject>
		{
			// Token: 0x040002B0 RID: 688
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003C RID: 60
		private sealed class MethodInfoStoreGeneric_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0<TObject>
		{
			// Token: 0x040002B1 RID: 689
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_LoadAssetsAsync_Public_Static_AsyncOperationHandle_1_IList_1_TObject_Object_Action_1_TObject_Boolean_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003D RID: 61
		private sealed class MethodInfoStoreGeneric_Release_Public_Static_Void_TObject_0<TObject>
		{
			// Token: 0x040002B2 RID: 690
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_Release_Public_Static_Void_TObject_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003E RID: 62
		private sealed class MethodInfoStoreGeneric_Release_Public_Static_Void_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x040002B3 RID: 691
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003F RID: 63
		private sealed class MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_0<T>
		{
			// Token: 0x040002B4 RID: 692
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000040 RID: 64
		private sealed class MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_IResourceLocation_0<T>
		{
			// Token: 0x040002B5 RID: 693
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_IResourceLocation_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000041 RID: 65
		private sealed class MethodInfoStoreGeneric_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_String_0<T>
		{
			// Token: 0x040002B6 RID: 694
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Addressables.NativeMethodInfoPtr_CreateCatalogLocationWithHashDependencies_Public_Static_ResourceLocationBase_String_String_0, Il2CppClassPointerStore<Addressables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
