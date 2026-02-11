using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement
{
	// Token: 0x0200000A RID: 10
	public class ResourceManager : Object
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00006D44 File Offset: 0x00004F44
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManager()
		{
			Il2CppClassPointerStore<ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement", "ResourceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr);
			ResourceManager.NativeFieldInfoPtr_postProfilerEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "postProfilerEvents");
			ResourceManager.NativeFieldInfoPtr__ExceptionHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "<ExceptionHandler>k__BackingField");
			ResourceManager.NativeFieldInfoPtr__InternalIdTransformFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "<InternalIdTransformFunc>k__BackingField");
			ResourceManager.NativeFieldInfoPtr__WebRequestOverride_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "<WebRequestOverride>k__BackingField");
			ResourceManager.NativeFieldInfoPtr_CallbackHooksEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "CallbackHooksEnabled");
			ResourceManager.NativeFieldInfoPtr_m_ResourceProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_ResourceProviders");
			ResourceManager.NativeFieldInfoPtr_m_allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_allocator");
			ResourceManager.NativeFieldInfoPtr_m_UpdateReceivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_UpdateReceivers");
			ResourceManager.NativeFieldInfoPtr_m_UpdateReceiversToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_UpdateReceiversToRemove");
			ResourceManager.NativeFieldInfoPtr_m_UpdatingReceivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_UpdatingReceivers");
			ResourceManager.NativeFieldInfoPtr_m_InsideUpdateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_InsideUpdateMethod");
			ResourceManager.NativeFieldInfoPtr_m_providerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_providerMap");
			ResourceManager.NativeFieldInfoPtr_m_AssetOperationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_AssetOperationCache");
			ResourceManager.NativeFieldInfoPtr_m_TrackedInstanceOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_TrackedInstanceOperations");
			ResourceManager.NativeFieldInfoPtr_m_UpdateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_UpdateCallbacks");
			ResourceManager.NativeFieldInfoPtr_m_DeferredCompleteCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_DeferredCompleteCallbacks");
			ResourceManager.NativeFieldInfoPtr_m_InsideExecuteDeferredCallbacksMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_InsideExecuteDeferredCallbacksMethod");
			ResourceManager.NativeFieldInfoPtr_m_DeferredCallbacksToRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_DeferredCallbacksToRegister");
			ResourceManager.NativeFieldInfoPtr_m_obsoleteDiagnosticsHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_obsoleteDiagnosticsHandler");
			ResourceManager.NativeFieldInfoPtr_m_diagnosticsHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_diagnosticsHandler");
			ResourceManager.NativeFieldInfoPtr_m_ReleaseOpNonCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_ReleaseOpNonCached");
			ResourceManager.NativeFieldInfoPtr_m_ReleaseOpCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_ReleaseOpCached");
			ResourceManager.NativeFieldInfoPtr_m_ReleaseInstanceOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_ReleaseInstanceOp");
			ResourceManager.NativeFieldInfoPtr_s_GroupOperationTypeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "s_GroupOperationTypeHash");
			ResourceManager.NativeFieldInfoPtr_s_InstanceOperationTypeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "s_InstanceOperationTypeHash");
			ResourceManager.NativeFieldInfoPtr__CertificateHandlerInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "<CertificateHandlerInstance>k__BackingField");
			ResourceManager.NativeFieldInfoPtr_m_RegisteredForCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_RegisteredForCallbacks");
			ResourceManager.NativeFieldInfoPtr_m_ProviderOperationTypeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_ProviderOperationTypeCache");
			ResourceManager.NativeMethodInfoPtr_get_ExceptionHandler_Public_Static_get_Action_2_AsyncOperationHandle_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663362);
			ResourceManager.NativeMethodInfoPtr_set_ExceptionHandler_Public_Static_set_Void_Action_2_AsyncOperationHandle_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663363);
			ResourceManager.NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_get_Func_2_IResourceLocation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663364);
			ResourceManager.NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_set_Void_Func_2_IResourceLocation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663365);
			ResourceManager.NativeMethodInfoPtr_TransformInternalId_Public_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663366);
			ResourceManager.NativeMethodInfoPtr_get_WebRequestOverride_Public_get_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663367);
			ResourceManager.NativeMethodInfoPtr_set_WebRequestOverride_Public_set_Void_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663368);
			ResourceManager.NativeMethodInfoPtr_get_OperationCacheCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663369);
			ResourceManager.NativeMethodInfoPtr_get_InstanceOperationCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663370);
			ResourceManager.NativeMethodInfoPtr_get_DeferredCompleteCallbacksCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663371);
			ResourceManager.NativeMethodInfoPtr_get_DeferredCallbackCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663372);
			ResourceManager.NativeMethodInfoPtr_AddUpdateReceiver_Public_Void_IUpdateReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663373);
			ResourceManager.NativeMethodInfoPtr_RemoveUpdateReciever_Public_Void_IUpdateReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663374);
			ResourceManager.NativeMethodInfoPtr_get_Allocator_Public_get_IAllocationStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663375);
			ResourceManager.NativeMethodInfoPtr_set_Allocator_Public_set_Void_IAllocationStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663376);
			ResourceManager.NativeMethodInfoPtr_get_ResourceProviders_Public_get_IList_1_IResourceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663377);
			ResourceManager.NativeMethodInfoPtr_get_CertificateHandlerInstance_Public_get_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663378);
			ResourceManager.NativeMethodInfoPtr_set_CertificateHandlerInstance_Public_set_Void_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663379);
			ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_IAllocationStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663380);
			ResourceManager.NativeMethodInfoPtr_OnObjectAdded_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663381);
			ResourceManager.NativeMethodInfoPtr_OnObjectRemoved_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663382);
			ResourceManager.NativeMethodInfoPtr_RegisterForCallbacks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663383);
			ResourceManager.NativeMethodInfoPtr_ClearDiagnosticsCallback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663384);
			ResourceManager.NativeMethodInfoPtr_ClearDiagnosticCallbacks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663385);
			ResourceManager.NativeMethodInfoPtr_UnregisterDiagnosticCallback_Public_Void_Action_1_DiagnosticEventContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663386);
			ResourceManager.NativeMethodInfoPtr_RegisterDiagnosticCallback_Public_Void_Action_4_AsyncOperationHandle_DiagnosticEventType_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663387);
			ResourceManager.NativeMethodInfoPtr_RegisterDiagnosticCallback_Public_Void_Action_1_DiagnosticEventContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663388);
			ResourceManager.NativeMethodInfoPtr_PostDiagnosticEvent_Internal_Void_DiagnosticEventContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663389);
			ResourceManager.NativeMethodInfoPtr_GetResourceProvider_Public_IResourceProvider_Type_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663390);
			ResourceManager.NativeMethodInfoPtr_GetDefaultTypeForLocation_Private_Type_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663391);
			ResourceManager.NativeMethodInfoPtr_CalculateLocationsHash_Private_Int32_IList_1_IResourceLocation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663392);
			ResourceManager.NativeMethodInfoPtr_ProvideResource_Private_AsyncOperationHandle_IResourceLocation_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663393);
			ResourceManager.NativeMethodInfoPtr_GetOperationFromCache_Internal_IAsyncOperation_IResourceLocation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663394);
			ResourceManager.NativeMethodInfoPtr_CreateCacheKeyForLocation_Internal_IOperationCacheKey_IResourceProvider_IResourceLocation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663395);
			ResourceManager.NativeMethodInfoPtr_ProvideResource_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663396);
			ResourceManager.NativeMethodInfoPtr_StartOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationBase_1_TObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663397);
			ResourceManager.NativeMethodInfoPtr_StartOperation_Internal_AsyncOperationHandle_IAsyncOperation_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663398);
			ResourceManager.NativeMethodInfoPtr_OnInstanceOperationDestroy_Private_Void_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663399);
			ResourceManager.NativeMethodInfoPtr_OnOperationDestroyNonCached_Private_Void_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663400);
			ResourceManager.NativeMethodInfoPtr_OnOperationDestroyCached_Private_Void_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663401);
			ResourceManager.NativeMethodInfoPtr_CreateOperation_Internal_T_Type_Int32_IOperationCacheKey_Action_1_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663402);
			ResourceManager.NativeMethodInfoPtr_AddOperationToCache_Internal_Void_IOperationCacheKey_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663403);
			ResourceManager.NativeMethodInfoPtr_RemoveOperationFromCache_Internal_Boolean_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663404);
			ResourceManager.NativeMethodInfoPtr_IsOperationCached_Internal_Boolean_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663405);
			ResourceManager.NativeMethodInfoPtr_CachedOperationCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663406);
			ResourceManager.NativeMethodInfoPtr_ClearOperationCache_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663407);
			ResourceManager.NativeMethodInfoPtr_CreateCompletedOperation_Public_AsyncOperationHandle_1_TObject_TObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663408);
			ResourceManager.NativeMethodInfoPtr_CreateCompletedOperationWithException_Public_AsyncOperationHandle_1_TObject_TObject_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663409);
			ResourceManager.NativeMethodInfoPtr_CreateCompletedOperationInternal_Internal_AsyncOperationHandle_1_TObject_TObject_Boolean_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663410);
			ResourceManager.NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663411);
			ResourceManager.NativeMethodInfoPtr_Acquire_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663412);
			ResourceManager.NativeMethodInfoPtr_Acquire_Public_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663413);
			ResourceManager.NativeMethodInfoPtr_AcquireGroupOpFromCache_Private_GroupOperation_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663414);
			ResourceManager.NativeMethodInfoPtr_CreateGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663415);
			ResourceManager.NativeMethodInfoPtr_CreateGroupOperation_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663416);
			ResourceManager.NativeMethodInfoPtr_CreateGenericGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_List_1_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663417);
			ResourceManager.NativeMethodInfoPtr_ProvideResourceGroupCached_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Int32_Type_Action_1_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663418);
			ResourceManager.NativeMethodInfoPtr_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663419);
			ResourceManager.NativeMethodInfoPtr_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Boolean_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663420);
			ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663421);
			ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663422);
			ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663423);
			ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663424);
			ResourceManager.NativeMethodInfoPtr_ProvideScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_IResourceLocation_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663425);
			ResourceManager.NativeMethodInfoPtr_ProvideScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_IResourceLocation_LoadSceneParameters_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663426);
			ResourceManager.NativeMethodInfoPtr_ReleaseScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663427);
			ResourceManager.NativeMethodInfoPtr_ProvideInstance_Public_AsyncOperationHandle_1_GameObject_IInstanceProvider_IResourceLocation_InstantiationParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663428);
			ResourceManager.NativeMethodInfoPtr_CleanupSceneInstances_Public_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663429);
			ResourceManager.NativeMethodInfoPtr_ExecuteDeferredCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663430);
			ResourceManager.NativeMethodInfoPtr_RegisterForDeferredCallback_Internal_Void_IAsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663431);
			ResourceManager.NativeMethodInfoPtr_Update_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663432);
			ResourceManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663433);
			ResourceManager.NativeMethodInfoPtr___ctor_b__57_0_Private_Void_IUpdateReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100663435);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00007558 File Offset: 0x00005758
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000758C File Offset: 0x0000578C
		public unsafe static Action<AsyncOperationHandle, Exception> ExceptionHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136113, XrefRangeEnd = 1136117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_ExceptionHandler_Public_Static_get_Action_2_AsyncOperationHandle_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle, Exception>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136117, XrefRangeEnd = 1136123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_set_ExceptionHandler_Public_Static_set_Void_Action_2_AsyncOperationHandle_Exception_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000075C4 File Offset: 0x000057C4
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00007604 File Offset: 0x00005804
		public unsafe Func<IResourceLocation, string> InternalIdTransformFunc
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_get_Func_2_IResourceLocation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IResourceLocation, string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_set_Void_Func_2_IResourceLocation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007648 File Offset: 0x00005848
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1136127, RefRangeEnd = 1136131, XrefRangeStart = 1136123, XrefRangeEnd = 1136127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TransformInternalId(IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_TransformInternalId_Public_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00007690 File Offset: 0x00005890
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000076D0 File Offset: 0x000058D0
		public unsafe Action<UnityWebRequest> WebRequestOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_WebRequestOverride_Public_get_Action_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_set_WebRequestOverride_Public_set_Void_Action_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00007714 File Offset: 0x00005914
		public unsafe int OperationCacheCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136131, XrefRangeEnd = 1136135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_OperationCacheCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00007750 File Offset: 0x00005950
		public unsafe int InstanceOperationCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136135, XrefRangeEnd = 1136136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_InstanceOperationCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000778C File Offset: 0x0000598C
		public unsafe int DeferredCompleteCallbacksCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136136, XrefRangeEnd = 1136137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_DeferredCompleteCallbacksCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000077C8 File Offset: 0x000059C8
		public unsafe int DeferredCallbackCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136137, XrefRangeEnd = 1136138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_DeferredCallbackCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007804 File Offset: 0x00005A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136141, RefRangeEnd = 1136143, XrefRangeStart = 1136138, XrefRangeEnd = 1136141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUpdateReceiver(IUpdateReceiver receiver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(receiver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_AddUpdateReceiver_Public_Void_IUpdateReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00007848 File Offset: 0x00005A48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1136149, RefRangeEnd = 1136152, XrefRangeStart = 1136143, XrefRangeEnd = 1136149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveUpdateReciever(IUpdateReceiver receiver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(receiver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_RemoveUpdateReciever_Public_Void_IUpdateReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000788C File Offset: 0x00005A8C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000078CC File Offset: 0x00005ACC
		public unsafe IAllocationStrategy Allocator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_Allocator_Public_get_IAllocationStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAllocationStrategy>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_set_Allocator_Public_set_Void_IAllocationStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00007910 File Offset: 0x00005B10
		public unsafe IList<IResourceProvider> ResourceProviders
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_ResourceProviders_Public_get_IList_1_IResourceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IResourceProvider>>(intPtr3) : null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00007950 File Offset: 0x00005B50
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00007990 File Offset: 0x00005B90
		public unsafe CertificateHandler CertificateHandlerInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_CertificateHandlerInstance_Public_get_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_set_CertificateHandlerInstance_Public_set_Void_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000079D4 File Offset: 0x00005BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136257, RefRangeEnd = 1136258, XrefRangeStart = 1136152, XrefRangeEnd = 1136257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager(IAllocationStrategy alloc = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alloc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_IAllocationStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007A20 File Offset: 0x00005C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136258, XrefRangeEnd = 1136264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectAdded(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnObjectAdded_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00007A64 File Offset: 0x00005C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136264, XrefRangeEnd = 1136268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectRemoved(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnObjectRemoved_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007AA8 File Offset: 0x00005CA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1136285, RefRangeEnd = 1136288, XrefRangeStart = 1136268, XrefRangeEnd = 1136285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterForCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_RegisterForCallbacks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00007ADC File Offset: 0x00005CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136290, RefRangeEnd = 1136291, XrefRangeStart = 1136288, XrefRangeEnd = 1136290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDiagnosticsCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ClearDiagnosticsCallback_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00007B10 File Offset: 0x00005D10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136290, RefRangeEnd = 1136291, XrefRangeStart = 1136290, XrefRangeEnd = 1136291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDiagnosticCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ClearDiagnosticCallbacks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00007B44 File Offset: 0x00005D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136307, RefRangeEnd = 1136309, XrefRangeStart = 1136291, XrefRangeEnd = 1136307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_UnregisterDiagnosticCallback_Public_Void_Action_1_DiagnosticEventContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00007B88 File Offset: 0x00005D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDiagnosticCallback(Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, Object> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_RegisterDiagnosticCallback_Public_Void_Action_4_AsyncOperationHandle_DiagnosticEventType_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00007BCC File Offset: 0x00005DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1136319, RefRangeEnd = 1136322, XrefRangeStart = 1136309, XrefRangeEnd = 1136319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_RegisterDiagnosticCallback_Public_Void_Action_1_DiagnosticEventContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007C10 File Offset: 0x00005E10
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1136324, RefRangeEnd = 1136332, XrefRangeStart = 1136322, XrefRangeEnd = 1136324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostDiagnosticEvent(ResourceManager.DiagnosticEventContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_PostDiagnosticEvent_Internal_Void_DiagnosticEventContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007C58 File Offset: 0x00005E58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1136339, RefRangeEnd = 1136344, XrefRangeStart = 1136332, XrefRangeEnd = 1136339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IResourceProvider GetResourceProvider(Type t, IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetResourceProvider_Public_IResourceProvider_Type_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceProvider>(intPtr3) : null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00007CBC File Offset: 0x00005EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136353, RefRangeEnd = 1136354, XrefRangeStart = 1136344, XrefRangeEnd = 1136353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetDefaultTypeForLocation(IResourceLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetDefaultTypeForLocation_Private_Type_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007D0C File Offset: 0x00005F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136384, RefRangeEnd = 1136385, XrefRangeStart = 1136354, XrefRangeEnd = 1136384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateLocationsHash(IList<IResourceLocation> locations, Type t = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CalculateLocationsHash_Private_Int32_IList_1_IResourceLocation_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007D6C File Offset: 0x00005F6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1136465, RefRangeEnd = 1136469, XrefRangeStart = 1136385, XrefRangeEnd = 1136465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType = null, bool releaseDependenciesOnFailure = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ProvideResource_Private_AsyncOperationHandle_IResourceLocation_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007DD4 File Offset: 0x00005FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136474, RefRangeEnd = 1136475, XrefRangeStart = 1136469, XrefRangeEnd = 1136474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncOperation GetOperationFromCache(IResourceLocation location, Type desiredType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetOperationFromCache_Internal_IAsyncOperation_IResourceLocation_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007E38 File Offset: 0x00006038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136479, RefRangeEnd = 1136481, XrefRangeStart = 1136475, XrefRangeEnd = 1136479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOperationCacheKey CreateCacheKeyForLocation(IResourceProvider provider, IResourceLocation location, Type desiredType = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CreateCacheKeyForLocation_Internal_IOperationCacheKey_IResourceProvider_IResourceLocation_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOperationCacheKey>(intPtr3) : null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007EAC File Offset: 0x000060AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1136488, RefRangeEnd = 1136494, XrefRangeStart = 1136481, XrefRangeEnd = 1136488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_ProvideResource_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007EF4 File Offset: 0x000060F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136497, RefRangeEnd = 1136498, XrefRangeStart = 1136494, XrefRangeEnd = 1136497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependency));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_StartOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationBase_1_TObject_AsyncOperationHandle_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007F54 File Offset: 0x00006154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136498, XrefRangeEnd = 1136503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependency));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_StartOperation_Internal_AsyncOperationHandle_IAsyncOperation_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007FB4 File Offset: 0x000061B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136503, XrefRangeEnd = 1136513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInstanceOperationDestroy(IAsyncOperation o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnInstanceOperationDestroy_Private_Void_IAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007FF8 File Offset: 0x000061F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136513, XrefRangeEnd = 1136517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOperationDestroyNonCached(IAsyncOperation o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnOperationDestroyNonCached_Private_Void_IAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000803C File Offset: 0x0000623C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136517, XrefRangeEnd = 1136536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOperationDestroyCached(IAsyncOperation o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnOperationDestroyCached_Private_Void_IAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008080 File Offset: 0x00006280
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1136551, RefRangeEnd = 1136561, XrefRangeStart = 1136536, XrefRangeEnd = 1136551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateOperation<T>(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actualType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeHash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cacheKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDestroyAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateOperation_Internal_T_Type_Int32_IOperationCacheKey_Action_1_IAsyncOperation_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008100 File Offset: 0x00006300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136567, RefRangeEnd = 1136568, XrefRangeStart = 1136561, XrefRangeEnd = 1136567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_AddOperationToCache_Internal_Void_IOperationCacheKey_IAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008154 File Offset: 0x00006354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136574, RefRangeEnd = 1136575, XrefRangeStart = 1136568, XrefRangeEnd = 1136574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveOperationFromCache(IOperationCacheKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_RemoveOperationFromCache_Internal_Boolean_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000081A4 File Offset: 0x000063A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136575, XrefRangeEnd = 1136579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOperationCached(IOperationCacheKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_IsOperationCached_Internal_Boolean_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000081F4 File Offset: 0x000063F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136579, XrefRangeEnd = 1136583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CachedOperationCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CachedOperationCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008230 File Offset: 0x00006430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136583, XrefRangeEnd = 1136587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOperationCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ClearOperationCache_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008264 File Offset: 0x00006464
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1136605, RefRangeEnd = 1136609, XrefRangeStart = 1136587, XrefRangeEnd = 1136605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = result;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateCompletedOperation_Public_AsyncOperationHandle_1_TObject_TObject_String_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return new AsyncOperationHandle<TObject>(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000082F4 File Offset: 0x000064F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136611, RefRangeEnd = 1136612, XrefRangeStart = 1136609, XrefRangeEnd = 1136611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = result;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateCompletedOperationWithException_Public_AsyncOperationHandle_1_TObject_TObject_Exception_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return new AsyncOperationHandle<TObject>(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00008384 File Offset: 0x00006584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136612, XrefRangeEnd = 1136623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = result;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateCompletedOperationInternal_Internal_AsyncOperationHandle_1_TObject_TObject_Boolean_Exception_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return new AsyncOperationHandle<TObject>(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00008430 File Offset: 0x00006630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136628, RefRangeEnd = 1136630, XrefRangeStart = 1136623, XrefRangeEnd = 1136628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00008478 File Offset: 0x00006678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136632, RefRangeEnd = 1136633, XrefRangeStart = 1136630, XrefRangeEnd = 1136632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> Acquire<TObject>(AsyncOperationHandle<TObject> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_Acquire_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000084C8 File Offset: 0x000066C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136638, RefRangeEnd = 1136639, XrefRangeStart = 1136633, XrefRangeEnd = 1136638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Acquire(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Acquire_Public_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00008510 File Offset: 0x00006710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136639, XrefRangeEnd = 1136644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_AcquireGroupOpFromCache_Private_GroupOperation_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupOperation>(intPtr3) : null;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00008560 File Offset: 0x00006760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1136703, RefRangeEnd = 1136706, XrefRangeStart = 1136644, XrefRangeEnd = 1136703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(intPtr);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000085A8 File Offset: 0x000067A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136765, RefRangeEnd = 1136766, XrefRangeStart = 1136706, XrefRangeEnd = 1136765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowFailedDependencies;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateGroupOperation_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<AsyncOperationHandle>>(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008600 File Offset: 0x00006800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136802, RefRangeEnd = 1136803, XrefRangeStart = 1136766, XrefRangeEnd = 1136802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releasedCachedOpOnComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CreateGenericGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_List_1_AsyncOperationHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<AsyncOperationHandle>>(intPtr);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00008658 File Offset: 0x00006858
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1136893, RefRangeEnd = 1136896, XrefRangeStart = 1136803, XrefRangeEnd = 1136893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref groupHash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ProvideResourceGroupCached_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Int32_Type_Action_1_AsyncOperationHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<AsyncOperationHandle>>(intPtr);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000086E4 File Offset: 0x000068E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136896, XrefRangeEnd = 1136897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, Action<TObject> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00008740 File Offset: 0x00006940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136932, RefRangeEnd = 1136933, XrefRangeStart = 1136897, XrefRangeEnd = 1136932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Boolean_Action_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000087A8 File Offset: 0x000069A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136945, RefRangeEnd = 1136946, XrefRangeStart = 1136933, XrefRangeEnd = 1136945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependentOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_0<TObject, TObjectDependency>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00008808 File Offset: 0x00006A08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136954, RefRangeEnd = 1136956, XrefRangeStart = 1136946, XrefRangeEnd = 1136954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependentOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00008868 File Offset: 0x00006A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136956, XrefRangeEnd = 1136962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependentOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0<TObject, TObjectDependency>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000088D8 File Offset: 0x00006AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136962, XrefRangeEnd = 1136970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependentOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00008948 File Offset: 0x00006B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136970, XrefRangeEnd = 1136974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ProvideScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_IResourceLocation_LoadSceneMode_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000089CC File Offset: 0x00006BCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136977, RefRangeEnd = 1136979, XrefRangeStart = 1136974, XrefRangeEnd = 1136977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ProvideScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_IResourceLocation_LoadSceneParameters_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008A50 File Offset: 0x00006C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136979, XrefRangeEnd = 1136982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneLoadHandle));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ReleaseScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_AsyncOperationHandle_1_SceneInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008AB0 File Offset: 0x00006CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1137011, RefRangeEnd = 1137012, XrefRangeStart = 1136982, XrefRangeEnd = 1137011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ProvideInstance_Public_AsyncOperationHandle_1_GameObject_IInstanceProvider_IResourceLocation_InstantiationParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008B24 File Offset: 0x00006D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1137061, RefRangeEnd = 1137062, XrefRangeStart = 1137012, XrefRangeEnd = 1137061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupSceneInstances(Scene scene)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CleanupSceneInstances_Public_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008B64 File Offset: 0x00006D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1137078, RefRangeEnd = 1137079, XrefRangeStart = 1137062, XrefRangeEnd = 1137078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteDeferredCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ExecuteDeferredCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00008B98 File Offset: 0x00006D98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1137092, RefRangeEnd = 1137098, XrefRangeStart = 1137079, XrefRangeEnd = 1137092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref incrementRefCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_RegisterForDeferredCallback_Internal_Void_IAsyncOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008BE8 File Offset: 0x00006DE8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1137147, RefRangeEnd = 1137173, XrefRangeStart = 1137098, XrefRangeEnd = 1137147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(float unscaledDeltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledDeltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Update_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00008C28 File Offset: 0x00006E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137173, XrefRangeEnd = 1137193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00008C5C File Offset: 0x00006E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137193, XrefRangeEnd = 1137194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__57_0(IUpdateReceiver x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr___ctor_b__57_0_Private_Void_IUpdateReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000023F3 File Offset: 0x000005F3
		public ResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00008CA0 File Offset: 0x00006EA0
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000023FC File Offset: 0x000005FC
		public unsafe bool postProfilerEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_postProfilerEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_postProfilerEvents)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00008CC8 File Offset: 0x00006EC8
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002417 File Offset: 0x00000617
		public unsafe static Action<AsyncOperationHandle, Exception> _ExceptionHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr__ExceptionHandler_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle, Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr__ExceptionHandler_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00008CF0 File Offset: 0x00006EF0
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002429 File Offset: 0x00000629
		public unsafe Func<IResourceLocation, string> _InternalIdTransformFunc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__InternalIdTransformFunc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IResourceLocation, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__InternalIdTransformFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00008D20 File Offset: 0x00006F20
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002448 File Offset: 0x00000648
		public unsafe Action<UnityWebRequest> _WebRequestOverride_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__WebRequestOverride_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__WebRequestOverride_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00008D50 File Offset: 0x00006F50
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002467 File Offset: 0x00000667
		public unsafe bool CallbackHooksEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_CallbackHooksEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_CallbackHooksEnabled)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00008D78 File Offset: 0x00006F78
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002482 File Offset: 0x00000682
		public unsafe ListWithEvents<IResourceProvider> m_ResourceProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ResourceProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListWithEvents<IResourceProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ResourceProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00008DA8 File Offset: 0x00006FA8
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000024A1 File Offset: 0x000006A1
		public unsafe IAllocationStrategy m_allocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_allocator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAllocationStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00008DD8 File Offset: 0x00006FD8
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000024C0 File Offset: 0x000006C0
		public unsafe ListWithEvents<IUpdateReceiver> m_UpdateReceivers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdateReceivers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListWithEvents<IUpdateReceiver>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdateReceivers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00008E08 File Offset: 0x00007008
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000024DF File Offset: 0x000006DF
		public unsafe List<IUpdateReceiver> m_UpdateReceiversToRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdateReceiversToRemove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IUpdateReceiver>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdateReceiversToRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00008E38 File Offset: 0x00007038
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000024FE File Offset: 0x000006FE
		public unsafe bool m_UpdatingReceivers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdatingReceivers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdatingReceivers)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00008E60 File Offset: 0x00007060
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002519 File Offset: 0x00000719
		public unsafe bool m_InsideUpdateMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_InsideUpdateMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_InsideUpdateMethod)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00008E88 File Offset: 0x00007088
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002534 File Offset: 0x00000734
		public unsafe Dictionary<int, IResourceProvider> m_providerMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_providerMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IResourceProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_providerMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00008EB8 File Offset: 0x000070B8
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002553 File Offset: 0x00000753
		public unsafe Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_AssetOperationCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IOperationCacheKey, IAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_AssetOperationCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00008EE8 File Offset: 0x000070E8
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002572 File Offset: 0x00000772
		public unsafe HashSet<ResourceManager.InstanceOperation> m_TrackedInstanceOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_TrackedInstanceOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ResourceManager.InstanceOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_TrackedInstanceOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00008F18 File Offset: 0x00007118
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002591 File Offset: 0x00000791
		public unsafe DelegateList<float> m_UpdateCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdateCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateList<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_UpdateCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00008F48 File Offset: 0x00007148
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000025B0 File Offset: 0x000007B0
		public unsafe List<IAsyncOperation> m_DeferredCompleteCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_DeferredCompleteCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_DeferredCompleteCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00008F78 File Offset: 0x00007178
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000025CF File Offset: 0x000007CF
		public unsafe bool m_InsideExecuteDeferredCallbacksMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_InsideExecuteDeferredCallbacksMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_InsideExecuteDeferredCallbacksMethod)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00008FA0 File Offset: 0x000071A0
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000025EA File Offset: 0x000007EA
		public unsafe List<ResourceManager.DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_DeferredCallbacksToRegister);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResourceManager.DeferredCallbackRegisterRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_DeferredCallbacksToRegister), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00008FD0 File Offset: 0x000071D0
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002609 File Offset: 0x00000809
		public unsafe Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, Object> m_obsoleteDiagnosticsHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_obsoleteDiagnosticsHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_obsoleteDiagnosticsHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00009000 File Offset: 0x00007200
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002628 File Offset: 0x00000828
		public unsafe Action<ResourceManager.DiagnosticEventContext> m_diagnosticsHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_diagnosticsHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ResourceManager.DiagnosticEventContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_diagnosticsHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00009030 File Offset: 0x00007230
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002647 File Offset: 0x00000847
		public unsafe Action<IAsyncOperation> m_ReleaseOpNonCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ReleaseOpNonCached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ReleaseOpNonCached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00009060 File Offset: 0x00007260
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002666 File Offset: 0x00000866
		public unsafe Action<IAsyncOperation> m_ReleaseOpCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ReleaseOpCached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ReleaseOpCached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00009090 File Offset: 0x00007290
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002685 File Offset: 0x00000885
		public unsafe Action<IAsyncOperation> m_ReleaseInstanceOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ReleaseInstanceOp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ReleaseInstanceOp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000090C0 File Offset: 0x000072C0
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000026A4 File Offset: 0x000008A4
		public unsafe static int s_GroupOperationTypeHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_s_GroupOperationTypeHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_s_GroupOperationTypeHash, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000090DC File Offset: 0x000072DC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000026B2 File Offset: 0x000008B2
		public unsafe static int s_InstanceOperationTypeHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_s_InstanceOperationTypeHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_s_InstanceOperationTypeHash, (void*)(&value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000090F8 File Offset: 0x000072F8
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe CertificateHandler _CertificateHandlerInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__CertificateHandlerInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__CertificateHandlerInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00009128 File Offset: 0x00007328
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000026DF File Offset: 0x000008DF
		public unsafe bool m_RegisteredForCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_RegisteredForCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_RegisteredForCallbacks)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00009150 File Offset: 0x00007350
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000026FA File Offset: 0x000008FA
		public unsafe Dictionary<Type, Type> m_ProviderOperationTypeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ProviderOperationTypeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_ProviderOperationTypeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_postProfilerEvents;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr__ExceptionHandler_k__BackingField;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr__InternalIdTransformFunc_k__BackingField;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__WebRequestOverride_k__BackingField;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_CallbackHooksEnabled;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceProviders;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_m_allocator;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateReceivers;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateReceiversToRemove;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdatingReceivers;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_m_InsideUpdateMethod;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_providerMap;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetOperationCache;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedInstanceOperations;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateCallbacks;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredCompleteCallbacks;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_m_InsideExecuteDeferredCallbacksMethod;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredCallbacksToRegister;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_m_obsoleteDiagnosticsHandler;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_m_diagnosticsHandler;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseOpNonCached;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseOpCached;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseInstanceOp;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_s_GroupOperationTypeHash;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_s_InstanceOperationTypeHash;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__CertificateHandlerInstance_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredForCallbacks;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_m_ProviderOperationTypeCache;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionHandler_Public_Static_get_Action_2_AsyncOperationHandle_Exception_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_ExceptionHandler_Public_Static_set_Void_Action_2_AsyncOperationHandle_Exception_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalIdTransformFunc_Public_get_Func_2_IResourceLocation_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalIdTransformFunc_Public_set_Void_Func_2_IResourceLocation_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_TransformInternalId_Public_String_IResourceLocation_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_WebRequestOverride_Public_get_Action_1_UnityWebRequest_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_set_WebRequestOverride_Public_set_Void_Action_1_UnityWebRequest_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_OperationCacheCount_Internal_get_Int32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceOperationCount_Internal_get_Int32_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_DeferredCompleteCallbacksCount_Internal_get_Int32_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_DeferredCallbackCount_Internal_get_Int32_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_AddUpdateReceiver_Public_Void_IUpdateReceiver_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_RemoveUpdateReciever_Public_Void_IUpdateReceiver_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_Allocator_Public_get_IAllocationStrategy_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_set_Allocator_Public_set_Void_IAllocationStrategy_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceProviders_Public_get_IList_1_IResourceProvider_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateHandlerInstance_Public_get_CertificateHandler_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateHandlerInstance_Public_set_Void_CertificateHandler_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAllocationStrategy_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectAdded_Private_Void_Object_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectRemoved_Private_Void_Object_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_RegisterForCallbacks_Internal_Void_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_ClearDiagnosticsCallback_Public_Void_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_ClearDiagnosticCallbacks_Public_Void_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDiagnosticCallback_Public_Void_Action_1_DiagnosticEventContext_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDiagnosticCallback_Public_Void_Action_4_AsyncOperationHandle_DiagnosticEventType_Int32_Object_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDiagnosticCallback_Public_Void_Action_1_DiagnosticEventContext_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_PostDiagnosticEvent_Internal_Void_DiagnosticEventContext_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceProvider_Public_IResourceProvider_Type_IResourceLocation_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultTypeForLocation_Private_Type_IResourceLocation_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLocationsHash_Private_Int32_IList_1_IResourceLocation_Type_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_ProvideResource_Private_AsyncOperationHandle_IResourceLocation_Type_Boolean_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_GetOperationFromCache_Internal_IAsyncOperation_IResourceLocation_Type_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CreateCacheKeyForLocation_Internal_IOperationCacheKey_IResourceProvider_IResourceLocation_Type_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_ProvideResource_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationBase_1_TObject_AsyncOperationHandle_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Internal_AsyncOperationHandle_IAsyncOperation_AsyncOperationHandle_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceOperationDestroy_Private_Void_IAsyncOperation_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_OnOperationDestroyNonCached_Private_Void_IAsyncOperation_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_OnOperationDestroyCached_Private_Void_IAsyncOperation_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_CreateOperation_Internal_T_Type_Int32_IOperationCacheKey_Action_1_IAsyncOperation_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_AddOperationToCache_Internal_Void_IOperationCacheKey_IAsyncOperation_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOperationFromCache_Internal_Boolean_IOperationCacheKey_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_IsOperationCached_Internal_Boolean_IOperationCacheKey_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_CachedOperationCount_Internal_Int32_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_ClearOperationCache_Internal_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_CreateCompletedOperation_Public_AsyncOperationHandle_1_TObject_TObject_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_CreateCompletedOperationWithException_Public_AsyncOperationHandle_1_TObject_TObject_Exception_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_CreateCompletedOperationInternal_Internal_AsyncOperationHandle_1_TObject_TObject_Boolean_Exception_Boolean_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_AsyncOperationHandle_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Void_AsyncOperationHandle_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_AcquireGroupOpFromCache_Private_GroupOperation_IOperationCacheKey_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupOperation_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_CreateGenericGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_List_1_AsyncOperationHandle_Boolean_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_ProvideResourceGroupCached_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Int32_Type_Action_1_AsyncOperationHandle_Boolean_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Boolean_Action_1_TObject_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_ProvideScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_IResourceLocation_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_ProvideScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_IResourceLocation_LoadSceneParameters_Boolean_Int32_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseScene_Public_AsyncOperationHandle_1_SceneInstance_ISceneProvider_AsyncOperationHandle_1_SceneInstance_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_ProvideInstance_Public_AsyncOperationHandle_1_GameObject_IInstanceProvider_IResourceLocation_InstantiationParameters_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_CleanupSceneInstances_Public_Void_Scene_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDeferredCallbacks_Private_Void_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_RegisterForDeferredCallback_Internal_Void_IAsyncOperation_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_Single_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__57_0_Private_Void_IUpdateReceiver_0;

		// Token: 0x0200005B RID: 91
		public enum DiagnosticEventType
		{
			// Token: 0x040003D2 RID: 978
			AsyncOperationFail,
			// Token: 0x040003D3 RID: 979
			AsyncOperationCreate,
			// Token: 0x040003D4 RID: 980
			AsyncOperationPercentComplete,
			// Token: 0x040003D5 RID: 981
			AsyncOperationComplete,
			// Token: 0x040003D6 RID: 982
			AsyncOperationReferenceCount,
			// Token: 0x040003D7 RID: 983
			AsyncOperationDestroy
		}

		// Token: 0x0200005C RID: 92
		public sealed class DiagnosticEventContext : ValueType
		{
			// Token: 0x0600055E RID: 1374 RVA: 0x0001A3C4 File Offset: 0x000185C4
			// Note: this type is marked as 'beforefieldinit'.
			static DiagnosticEventContext()
			{
				Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "DiagnosticEventContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr);
				ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__OperationHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, "<OperationHandle>k__BackingField");
				ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, "<Type>k__BackingField");
				ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__EventValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, "<EventValue>k__BackingField");
				ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, "<Location>k__BackingField");
				ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, "<Context>k__BackingField");
				ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, "<Error>k__BackingField");
				ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_OperationHandle_Public_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, 100663436);
				ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Type_Public_get_DiagnosticEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, 100663437);
				ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_EventValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, 100663438);
				ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, 100663439);
				ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Context_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, 100663440);
				ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, 100663441);
				ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr__ctor_Public_Void_AsyncOperationHandle_DiagnosticEventType_Int32_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr, 100663442);
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001A4F4 File Offset: 0x000186F4
			public unsafe AsyncOperationHandle OperationHandle
			{
				[CallerCount(49)]
				[CachedScanResults(RefRangeStart = 681416, RefRangeEnd = 681465, XrefRangeStart = 681416, XrefRangeEnd = 681465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_OperationHandle_Public_get_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle(intPtr);
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x0001A530 File Offset: 0x00018730
			public unsafe ResourceManager.DiagnosticEventType Type
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Type_Public_get_DiagnosticEventType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001A574 File Offset: 0x00018774
			public unsafe int EventValue
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_EventValue_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001A5B8 File Offset: 0x000187B8
			public unsafe IResourceLocation Location
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x06000563 RID: 1379 RVA: 0x0001A5FC File Offset: 0x000187FC
			public unsafe Object Context
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Context_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001A640 File Offset: 0x00018840
			public unsafe string Error
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0001A67C File Offset: 0x0001887C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1135931, RefRangeEnd = 1135939, XrefRangeStart = 1135921, XrefRangeEnd = 1135931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DiagnosticEventContext(AsyncOperationHandle op, ResourceManager.DiagnosticEventType type, int eventValue = 0, string error = null, Object context = null)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventValue;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.DiagnosticEventContext.NativeMethodInfoPtr__ctor_Public_Void_AsyncOperationHandle_DiagnosticEventType_Int32_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x00003FE1 File Offset: 0x000021E1
			public DiagnosticEventContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00003FEA File Offset: 0x000021EA
			public DiagnosticEventContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.DiagnosticEventContext>.NativeClassPtr))
			{
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001A714 File Offset: 0x00018914
			// (set) Token: 0x06000569 RID: 1385 RVA: 0x00003FFC File Offset: 0x000021FC
			public AsyncOperationHandle _OperationHandle_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__OperationHandle_k__BackingField);
					return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__OperationHandle_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001A744 File Offset: 0x00018944
			// (set) Token: 0x0600056B RID: 1387 RVA: 0x0000402A File Offset: 0x0000222A
			public unsafe ResourceManager.DiagnosticEventType _Type_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Type_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Type_k__BackingField)) = value;
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001A76C File Offset: 0x0001896C
			// (set) Token: 0x0600056D RID: 1389 RVA: 0x00004045 File Offset: 0x00002245
			public unsafe int _EventValue_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__EventValue_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__EventValue_k__BackingField)) = value;
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x0600056E RID: 1390 RVA: 0x0001A794 File Offset: 0x00018994
			// (set) Token: 0x0600056F RID: 1391 RVA: 0x00004060 File Offset: 0x00002260
			public unsafe IResourceLocation _Location_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Location_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Location_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001A7C4 File Offset: 0x000189C4
			// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000407F File Offset: 0x0000227F
			public unsafe Object _Context_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Context_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Context_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001A7F4 File Offset: 0x000189F4
			// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000409E File Offset: 0x0000229E
			public unsafe string _Error_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Error_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DiagnosticEventContext.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040003D8 RID: 984
			private static readonly IntPtr NativeFieldInfoPtr__OperationHandle_k__BackingField;

			// Token: 0x040003D9 RID: 985
			private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

			// Token: 0x040003DA RID: 986
			private static readonly IntPtr NativeFieldInfoPtr__EventValue_k__BackingField;

			// Token: 0x040003DB RID: 987
			private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

			// Token: 0x040003DC RID: 988
			private static readonly IntPtr NativeFieldInfoPtr__Context_k__BackingField;

			// Token: 0x040003DD RID: 989
			private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

			// Token: 0x040003DE RID: 990
			private static readonly IntPtr NativeMethodInfoPtr_get_OperationHandle_Public_get_AsyncOperationHandle_0;

			// Token: 0x040003DF RID: 991
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_DiagnosticEventType_0;

			// Token: 0x040003E0 RID: 992
			private static readonly IntPtr NativeMethodInfoPtr_get_EventValue_Public_get_Int32_0;

			// Token: 0x040003E1 RID: 993
			private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0;

			// Token: 0x040003E2 RID: 994
			private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_Object_0;

			// Token: 0x040003E3 RID: 995
			private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;

			// Token: 0x040003E4 RID: 996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsyncOperationHandle_DiagnosticEventType_Int32_String_Object_0;
		}

		// Token: 0x0200005D RID: 93
		public sealed class DeferredCallbackRegisterRequest : ValueType
		{
			// Token: 0x06000574 RID: 1396 RVA: 0x0001A81C File Offset: 0x00018A1C
			// Note: this type is marked as 'beforefieldinit'.
			static DeferredCallbackRegisterRequest()
			{
				Il2CppClassPointerStore<ResourceManager.DeferredCallbackRegisterRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "DeferredCallbackRegisterRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.DeferredCallbackRegisterRequest>.NativeClassPtr);
				ResourceManager.DeferredCallbackRegisterRequest.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DeferredCallbackRegisterRequest>.NativeClassPtr, "operation");
				ResourceManager.DeferredCallbackRegisterRequest.NativeFieldInfoPtr_incrementRefCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.DeferredCallbackRegisterRequest>.NativeClassPtr, "incrementRefCount");
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x000040BD File Offset: 0x000022BD
			public DeferredCallbackRegisterRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x000040C6 File Offset: 0x000022C6
			public DeferredCallbackRegisterRequest()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.DeferredCallbackRegisterRequest>.NativeClassPtr))
			{
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001A870 File Offset: 0x00018A70
			// (set) Token: 0x06000578 RID: 1400 RVA: 0x000040D8 File Offset: 0x000022D8
			public unsafe IAsyncOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DeferredCallbackRegisterRequest.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DeferredCallbackRegisterRequest.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001A8A0 File Offset: 0x00018AA0
			// (set) Token: 0x0600057A RID: 1402 RVA: 0x000040F7 File Offset: 0x000022F7
			public unsafe bool incrementRefCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DeferredCallbackRegisterRequest.NativeFieldInfoPtr_incrementRefCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.DeferredCallbackRegisterRequest.NativeFieldInfoPtr_incrementRefCount)) = value;
				}
			}

			// Token: 0x040003E5 RID: 997
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x040003E6 RID: 998
			private static readonly IntPtr NativeFieldInfoPtr_incrementRefCount;
		}

		// Token: 0x0200005E RID: 94
		public class CompletedOperation<TObject> : AsyncOperationBase<TObject>
		{
			// Token: 0x0600057B RID: 1403 RVA: 0x0001A8C8 File Offset: 0x00018AC8
			// Note: this type is marked as 'beforefieldinit'.
			static CompletedOperation()
			{
				Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "CompletedOperation`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr);
				ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, "m_Success");
				ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, "m_Exception");
				ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, "m_ReleaseDependenciesOnFailure");
				ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, 100663443);
				ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_TObject_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, 100663444);
				ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_TObject_Boolean_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, 100663445);
				ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, 100663446);
				ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, 100663447);
				ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr, 100663448);
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x0001A9E4 File Offset: 0x00018BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135939, XrefRangeEnd = 1135943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CompletedOperation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.CompletedOperation<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x0001AA20 File Offset: 0x00018C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135943, XrefRangeEnd = 1135950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TObject).IsValueType)
					{
						TObject tobject = result;
						intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref result;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_TObject_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x0001AAC8 File Offset: 0x00018CC8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1135951, RefRangeEnd = 1135953, XrefRangeStart = 1135950, XrefRangeEnd = 1135951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TObject).IsValueType)
					{
						TObject tobject = result;
						intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref result;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_TObject_Boolean_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001AB70 File Offset: 0x00018D70
			public unsafe override string DebugName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135953, XrefRangeEnd = 1135955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x0001ABB4 File Offset: 0x00018DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135955, XrefRangeEnd = 1135958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x0001ABFC File Offset: 0x00018DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135958, XrefRangeEnd = 1135959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.CompletedOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00004112 File Offset: 0x00002312
			public CompletedOperation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001AC38 File Offset: 0x00018E38
			// (set) Token: 0x06000584 RID: 1412 RVA: 0x0000411B File Offset: 0x0000231B
			public unsafe bool m_Success
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_Success);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_Success)) = value;
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001AC60 File Offset: 0x00018E60
			// (set) Token: 0x06000586 RID: 1414 RVA: 0x00004136 File Offset: 0x00002336
			public unsafe Exception m_Exception
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_Exception);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x06000587 RID: 1415 RVA: 0x0001AC90 File Offset: 0x00018E90
			// (set) Token: 0x06000588 RID: 1416 RVA: 0x00004155 File Offset: 0x00002355
			public unsafe bool m_ReleaseDependenciesOnFailure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CompletedOperation<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure)) = value;
				}
			}

			// Token: 0x040003E7 RID: 999
			private static readonly IntPtr NativeFieldInfoPtr_m_Success;

			// Token: 0x040003E8 RID: 1000
			private static readonly IntPtr NativeFieldInfoPtr_m_Exception;

			// Token: 0x040003E9 RID: 1001
			private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure;

			// Token: 0x040003EA RID: 1002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003EB RID: 1003
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_TObject_Boolean_String_Boolean_0;

			// Token: 0x040003EC RID: 1004
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_TObject_Boolean_Exception_Boolean_0;

			// Token: 0x040003ED RID: 1005
			private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

			// Token: 0x040003EE RID: 1006
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040003EF RID: 1007
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;
		}

		// Token: 0x0200005F RID: 95
		public class InstanceOperation : AsyncOperationBase<GameObject>
		{
			// Token: 0x06000589 RID: 1417 RVA: 0x0001ACB8 File Offset: 0x00018EB8
			// Note: this type is marked as 'beforefieldinit'.
			static InstanceOperation()
			{
				Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "InstanceOperation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr);
				ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, "m_dependency");
				ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instantiationParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, "m_instantiationParams");
				ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instanceProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, "m_instanceProvider");
				ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, "m_instance");
				ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, "m_scene");
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_Init_Public_Void_ResourceManager_IInstanceProvider_InstantiationParameters_AsyncOperationHandle_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663449);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663450);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663451);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663452);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_InstanceScene_Public_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663453);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663454);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663455);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663456);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663457);
				ResourceManager.InstanceOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr, 100663458);
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x0001AE10 File Offset: 0x00019010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135959, XrefRangeEnd = 1135963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instanceProvider);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiationParams));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependency));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.InstanceOperation.NativeMethodInfoPtr_Init_Public_Void_ResourceManager_IInstanceProvider_InstantiationParameters_AsyncOperationHandle_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x0001AE94 File Offset: 0x00019094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135963, XrefRangeEnd = 1135970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DownloadStatus GetDownloadStatus(HashSet<Object> visited)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.InstanceOperation.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x0001AEEC File Offset: 0x000190EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135970, XrefRangeEnd = 1135976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void GetDependencies(List<AsyncOperationHandle> deps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.InstanceOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001AF3C File Offset: 0x0001913C
			public unsafe override string DebugName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135976, XrefRangeEnd = 1135991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.InstanceOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x0001AF80 File Offset: 0x00019180
			[CallerCount(0)]
			public unsafe Scene InstanceScene()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.InstanceOperation.NativeMethodInfoPtr_InstanceScene_Public_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600058F RID: 1423 RVA: 0x0001AFBC File Offset: 0x000191BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135991, XrefRangeEnd = 1135996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Destroy()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.InstanceOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001AFF8 File Offset: 0x000191F8
			public unsafe override float Progress
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135996, XrefRangeEnd = 1135999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.InstanceOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x0001B040 File Offset: 0x00019240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135999, XrefRangeEnd = 1136020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.InstanceOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x0001B088 File Offset: 0x00019288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136020, XrefRangeEnd = 1136034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.InstanceOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x0001B0C4 File Offset: 0x000192C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136034, XrefRangeEnd = 1136037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InstanceOperation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.InstanceOperation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.InstanceOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x00004170 File Offset: 0x00002370
			public InstanceOperation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001B100 File Offset: 0x00019300
			// (set) Token: 0x06000596 RID: 1430 RVA: 0x00004179 File Offset: 0x00002379
			public AsyncOperationHandle<GameObject> m_dependency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_dependency);
					return new AsyncOperationHandle<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<GameObject>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_dependency), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<GameObject>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001B130 File Offset: 0x00019330
			// (set) Token: 0x06000598 RID: 1432 RVA: 0x000041A7 File Offset: 0x000023A7
			public InstantiationParameters m_instantiationParams
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instantiationParams);
					return new InstantiationParameters(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instantiationParams), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001B160 File Offset: 0x00019360
			// (set) Token: 0x0600059A RID: 1434 RVA: 0x000041D5 File Offset: 0x000023D5
			public unsafe IInstanceProvider m_instanceProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instanceProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInstanceProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instanceProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001B190 File Offset: 0x00019390
			// (set) Token: 0x0600059C RID: 1436 RVA: 0x000041F4 File Offset: 0x000023F4
			public unsafe GameObject m_instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x0600059D RID: 1437 RVA: 0x0001B1C0 File Offset: 0x000193C0
			// (set) Token: 0x0600059E RID: 1438 RVA: 0x00004213 File Offset: 0x00002413
			public unsafe Scene m_scene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_scene);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.InstanceOperation.NativeFieldInfoPtr_m_scene)) = value;
				}
			}

			// Token: 0x040003F0 RID: 1008
			private static readonly IntPtr NativeFieldInfoPtr_m_dependency;

			// Token: 0x040003F1 RID: 1009
			private static readonly IntPtr NativeFieldInfoPtr_m_instantiationParams;

			// Token: 0x040003F2 RID: 1010
			private static readonly IntPtr NativeFieldInfoPtr_m_instanceProvider;

			// Token: 0x040003F3 RID: 1011
			private static readonly IntPtr NativeFieldInfoPtr_m_instance;

			// Token: 0x040003F4 RID: 1012
			private static readonly IntPtr NativeFieldInfoPtr_m_scene;

			// Token: 0x040003F5 RID: 1013
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_ResourceManager_IInstanceProvider_InstantiationParameters_AsyncOperationHandle_1_GameObject_0;

			// Token: 0x040003F6 RID: 1014
			private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0;

			// Token: 0x040003F7 RID: 1015
			private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

			// Token: 0x040003F8 RID: 1016
			private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

			// Token: 0x040003F9 RID: 1017
			private static readonly IntPtr NativeMethodInfoPtr_InstanceScene_Public_Scene_0;

			// Token: 0x040003FA RID: 1018
			private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

			// Token: 0x040003FB RID: 1019
			private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

			// Token: 0x040003FC RID: 1020
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040003FD RID: 1021
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040003FE RID: 1022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("UnityEngine.ResourceManagement.ResourceManager+<>c__DisplayClass100_0`1")]
		public sealed class __c__DisplayClass100_0<TObject> : Object
		{
			// Token: 0x0600059F RID: 1439 RVA: 0x0001B1E8 File Offset: 0x000193E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass100_0()
			{
				Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "<>c__DisplayClass100_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr);
				ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr, "callback");
				ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr, "releaseDependenciesOnFailure");
				ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr, "<>4__this");
				ResourceManager.__c__DisplayClass100_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr, 100663459);
				ResourceManager.__c__DisplayClass100_0<TObject>.NativeMethodInfoPtr__ProvideResources_b__0_Internal_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr, 100663460);
				ResourceManager.__c__DisplayClass100_0<TObject>.NativeMethodInfoPtr__ProvideResources_b__1_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr, 100663461);
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x0001B2C8 File Offset: 0x000194C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass100_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.__c__DisplayClass100_0<TObject>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.__c__DisplayClass100_0<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x0001B304 File Offset: 0x00019504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136037, XrefRangeEnd = 1136041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProvideResources_b__0(AsyncOperationHandle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.__c__DisplayClass100_0<TObject>.NativeMethodInfoPtr__ProvideResources_b__0_Internal_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005A2 RID: 1442 RVA: 0x0001B34C File Offset: 0x0001954C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136041, XrefRangeEnd = 1136113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IList<TObject>> _ProvideResources_b__1(AsyncOperationHandle resultHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resultHandle));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.__c__DisplayClass100_0<TObject>.NativeMethodInfoPtr__ProvideResources_b__1_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IList<TObject>>(intPtr);
				}
			}

			// Token: 0x060005A3 RID: 1443 RVA: 0x0000422E File Offset: 0x0000242E
			public __c__DisplayClass100_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001B39C File Offset: 0x0001959C
			// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00004237 File Offset: 0x00002437
			public unsafe Action<TObject> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001B3CC File Offset: 0x000195CC
			// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00004256 File Offset: 0x00002456
			public unsafe bool releaseDependenciesOnFailure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr_releaseDependenciesOnFailure)) = value;
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001B3F4 File Offset: 0x000195F4
			// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00004271 File Offset: 0x00002471
			public unsafe ResourceManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.__c__DisplayClass100_0<TObject>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003FF RID: 1023
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000400 RID: 1024
			private static readonly IntPtr NativeFieldInfoPtr_releaseDependenciesOnFailure;

			// Token: 0x04000401 RID: 1025
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000402 RID: 1026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000403 RID: 1027
			private static readonly IntPtr NativeMethodInfoPtr__ProvideResources_b__0_Internal_Void_AsyncOperationHandle_0;

			// Token: 0x04000404 RID: 1028
			private static readonly IntPtr NativeMethodInfoPtr__ProvideResources_b__1_Internal_AsyncOperationHandle_1_IList_1_TObject_AsyncOperationHandle_0;
		}

		// Token: 0x02000061 RID: 97
		private sealed class MethodInfoStoreGeneric_ProvideResource_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>
		{
			// Token: 0x04000405 RID: 1029
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_ProvideResource_Public_AsyncOperationHandle_1_TObject_IResourceLocation_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000062 RID: 98
		private sealed class MethodInfoStoreGeneric_StartOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationBase_1_TObject_AsyncOperationHandle_0<TObject>
		{
			// Token: 0x04000406 RID: 1030
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_StartOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationBase_1_TObject_AsyncOperationHandle_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000063 RID: 99
		private sealed class MethodInfoStoreGeneric_CreateOperation_Internal_T_Type_Int32_IOperationCacheKey_Action_1_IAsyncOperation_0<T>
		{
			// Token: 0x04000407 RID: 1031
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateOperation_Internal_T_Type_Int32_IOperationCacheKey_Action_1_IAsyncOperation_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000064 RID: 100
		private sealed class MethodInfoStoreGeneric_CreateCompletedOperation_Public_AsyncOperationHandle_1_TObject_TObject_String_0<TObject>
		{
			// Token: 0x04000408 RID: 1032
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateCompletedOperation_Public_AsyncOperationHandle_1_TObject_TObject_String_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000065 RID: 101
		private sealed class MethodInfoStoreGeneric_CreateCompletedOperationWithException_Public_AsyncOperationHandle_1_TObject_TObject_Exception_0<TObject>
		{
			// Token: 0x04000409 RID: 1033
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateCompletedOperationWithException_Public_AsyncOperationHandle_1_TObject_TObject_Exception_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000066 RID: 102
		private sealed class MethodInfoStoreGeneric_CreateCompletedOperationInternal_Internal_AsyncOperationHandle_1_TObject_TObject_Boolean_Exception_Boolean_0<TObject>
		{
			// Token: 0x0400040A RID: 1034
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateCompletedOperationInternal_Internal_AsyncOperationHandle_1_TObject_TObject_Boolean_Exception_Boolean_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000067 RID: 103
		private sealed class MethodInfoStoreGeneric_Acquire_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x0400040B RID: 1035
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_Acquire_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000068 RID: 104
		private sealed class MethodInfoStoreGeneric_CreateGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_0<T>
		{
			// Token: 0x0400040C RID: 1036
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateGroupOperation_Public_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000069 RID: 105
		private sealed class MethodInfoStoreGeneric_CreateGroupOperation_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0<T>
		{
			// Token: 0x0400040D RID: 1037
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateGroupOperation_Internal_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_IList_1_IResourceLocation_Boolean_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006A RID: 106
		private sealed class MethodInfoStoreGeneric_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>
		{
			// Token: 0x0400040E RID: 1038
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006B RID: 107
		private sealed class MethodInfoStoreGeneric_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Boolean_Action_1_TObject_0<TObject>
		{
			// Token: 0x0400040F RID: 1039
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_ProvideResources_Public_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Boolean_Action_1_TObject_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006C RID: 108
		private sealed class MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_0<TObject, TObjectDependency>
		{
			// Token: 0x04000410 RID: 1040
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObjectDependency>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200006D RID: 109
		private sealed class MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x04000411 RID: 1041
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006E RID: 110
		private sealed class MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0<TObject, TObjectDependency>
		{
			// Token: 0x04000412 RID: 1042
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObjectDependency>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200006F RID: 111
		private sealed class MethodInfoStoreGeneric_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0<TObject>
		{
			// Token: 0x04000413 RID: 1043
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_CreateChainOperation_Public_AsyncOperationHandle_1_TObject_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
