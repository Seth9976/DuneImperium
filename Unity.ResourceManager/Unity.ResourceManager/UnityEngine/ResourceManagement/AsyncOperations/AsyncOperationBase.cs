using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x0200004F RID: 79
	public class AsyncOperationBase<TObject> : Object
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x00014998 File Offset: 0x00012B98
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperationBase()
		{
			Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "AsyncOperationBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr);
			AsyncOperationBase<TObject>.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "<Result>k__BackingField");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_referenceCount");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_Status");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_Error");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_RM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_RM");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_Version");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_DestroyedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_DestroyedAction");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_CompletedActionT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_CompletedActionT");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_OnDestroyAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_OnDestroyAction");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_dependencyCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_dependencyCompleteAction");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_HasExecuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "HasExecuted");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_Executed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "Executed");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "<IsRunning>k__BackingField");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_taskCompletionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_taskCompletionSource");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_taskCompletionSourceTypeless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_taskCompletionSourceTypeless");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_InDeferredCallbackQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_InDeferredCallbackQueue");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_UpdateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_UpdateCallbacks");
			AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_UpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "m_UpdateCallback");
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_Execute_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663979);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663980);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663981);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663982);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_New_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663983);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Result_Public_get_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663984);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_Result_Public_set_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663985);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663986);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_CompletedEventHasListeners_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663987);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_DestroyedEventHasListeners_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663988);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_OnDestroy_Internal_set_Void_Action_1_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663989);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_Executed_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663990);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_Executed_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663991);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_ReferenceCount_FamOrAssem_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663992);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663993);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_IsRunning_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663994);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663995);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_ShortenPath_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663996);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_WaitForCompletion_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663997);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663998);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_IncrementReferenceCount_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100663999);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_DecrementReferenceCount_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664000);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Task_Internal_get_Task_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664001);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Task_Private_Virtual_Final_New_get_Task_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664002);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664003);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_RegisterForDeferredCallbackEvent_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664004);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_Completed_Internal_add_Void_Action_1_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664005);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_Completed_Internal_rem_Void_Action_1_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664006);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_Destroyed_Internal_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664007);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_Destroyed_Internal_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664008);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_CompletedTypeless_Internal_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664009);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_CompletedTypeless_Internal_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664010);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Status_Internal_get_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664011);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_OperationException_Internal_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664012);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_OperationException_Private_set_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664013);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664014);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664015);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Current_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664016);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_IsDone_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664017);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_PercentComplete_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664018);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664019);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Handle_Internal_get_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664020);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UpdateCallback_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664021);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664022);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664023);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664024);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_Start_Internal_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664025);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeExecute_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664026);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_CompletedTypeless_Private_Virtual_Final_New_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664027);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_CompletedTypeless_Private_Virtual_Final_New_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664028);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_Destroyed_Private_Virtual_Final_New_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664029);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_Destroyed_Private_Virtual_Final_New_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664030);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Version_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664031);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_ReferenceCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664032);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_PercentComplete_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664033);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Status_Private_Virtual_Final_New_get_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664034);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_OperationException_Private_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664035);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_IsDone_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664036);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Handle_Private_Virtual_Final_New_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664037);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_set_OnDestroy_Private_Virtual_Final_New_set_Void_Action_1_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664038);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_DebugName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664039);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetResultAsObject_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664040);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_ResultType_Private_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664041);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDependencies_Private_Virtual_Final_New_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664042);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_DecrementReferenceCount_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664043);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_IncrementReferenceCount_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664044);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_InvokeCompletionEvent_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664045);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_Start_Private_Virtual_Final_New_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664046);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664047);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDownloadStatus_Private_Virtual_Final_New_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664048);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_New_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664049);
			AsyncOperationBase<TObject>.NativeMethodInfoPtr___ctor_b__38_0_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, 100664050);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001510C File Offset: 0x0001330C
		[CallerCount(0)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_Execute_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00015148 File Offset: 0x00013348
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00015184 File Offset: 0x00013384
		public unsafe virtual float Progress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x000151CC File Offset: 0x000133CC
		public unsafe virtual string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141728, XrefRangeEnd = 1141729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00015210 File Offset: 0x00013410
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_New_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00015260 File Offset: 0x00013460
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0001529C File Offset: 0x0001349C
		public unsafe TObject Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Result_Public_get_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TObject).IsValueType)
					{
						TObject tobject = value;
						intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_Result_Public_set_Void_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00015314 File Offset: 0x00013514
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00015350 File Offset: 0x00013550
		public unsafe bool CompletedEventHasListeners
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_CompletedEventHasListeners_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001538C File Offset: 0x0001358C
		public unsafe bool DestroyedEventHasListeners
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141729, XrefRangeEnd = 1141730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_DestroyedEventHasListeners_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x000153C8 File Offset: 0x000135C8
		public unsafe Action<IAsyncOperation> OnDestroy
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_OnDestroy_Internal_set_Void_Action_1_IAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001540C File Offset: 0x0001360C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141730, XrefRangeEnd = 1141734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Executed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_Executed_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00015450 File Offset: 0x00013650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141734, XrefRangeEnd = 1141738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Executed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_Executed_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00015494 File Offset: 0x00013694
		public unsafe int ReferenceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_ReferenceCount_FamOrAssem_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x000154D0 File Offset: 0x000136D0
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0001550C File Offset: 0x0001370C
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_IsRunning_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001554C File Offset: 0x0001374C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141749, RefRangeEnd = 1141750, XrefRangeStart = 1141738, XrefRangeEnd = 1141749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00015588 File Offset: 0x00013788
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1141754, RefRangeEnd = 1141757, XrefRangeStart = 1141750, XrefRangeEnd = 1141754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ShortenPath(string p, bool keepExtension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepExtension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_ShortenPath_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000155D4 File Offset: 0x000137D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141762, RefRangeEnd = 1141763, XrefRangeStart = 1141757, XrefRangeEnd = 1141762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_WaitForCompletion_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00015608 File Offset: 0x00013808
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00015650 File Offset: 0x00013850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141766, RefRangeEnd = 1141767, XrefRangeStart = 1141763, XrefRangeEnd = 1141766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementReferenceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_IncrementReferenceCount_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00015684 File Offset: 0x00013884
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1141787, RefRangeEnd = 1141790, XrefRangeStart = 1141767, XrefRangeEnd = 1141787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementReferenceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_DecrementReferenceCount_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x000156B8 File Offset: 0x000138B8
		public unsafe Task<TObject> Task
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1141796, RefRangeEnd = 1141797, XrefRangeStart = 1141790, XrefRangeEnd = 1141796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Task_Internal_get_Task_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TObject>>(intPtr3) : null;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x000156F8 File Offset: 0x000138F8
		public unsafe virtual Task<Object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Task
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141797, XrefRangeEnd = 1141810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Task_Private_Virtual_Final_New_get_Task_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00015738 File Offset: 0x00013938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141810, XrefRangeEnd = 1141838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001577C File Offset: 0x0001397C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141838, XrefRangeEnd = 1141839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref incrementReferenceCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_RegisterForDeferredCallbackEvent_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000157BC File Offset: 0x000139BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141843, RefRangeEnd = 1141844, XrefRangeStart = 1141839, XrefRangeEnd = 1141843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Completed(Action<AsyncOperationHandle<TObject>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_Completed_Internal_add_Void_Action_1_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00015800 File Offset: 0x00013A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141845, RefRangeEnd = 1141846, XrefRangeStart = 1141844, XrefRangeEnd = 1141845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Completed(Action<AsyncOperationHandle<TObject>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_Completed_Internal_rem_Void_Action_1_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00015844 File Offset: 0x00013A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141854, RefRangeEnd = 1141855, XrefRangeStart = 1141846, XrefRangeEnd = 1141854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_Destroyed_Internal_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00015888 File Offset: 0x00013A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141858, RefRangeEnd = 1141859, XrefRangeStart = 1141855, XrefRangeEnd = 1141858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_Destroyed_Internal_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000158CC File Offset: 0x00013ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141870, RefRangeEnd = 1141871, XrefRangeStart = 1141859, XrefRangeEnd = 1141870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_add_CompletedTypeless_Internal_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00015910 File Offset: 0x00013B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141879, RefRangeEnd = 1141880, XrefRangeStart = 1141871, XrefRangeEnd = 1141879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_remove_CompletedTypeless_Internal_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00015954 File Offset: 0x00013B54
		public unsafe AsyncOperationStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Status_Internal_get_AsyncOperationStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00015990 File Offset: 0x00013B90
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x000159D0 File Offset: 0x00013BD0
		public unsafe Exception OperationException
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_OperationException_Internal_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141880, XrefRangeEnd = 1141894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_set_OperationException_Private_set_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00015A14 File Offset: 0x00013C14
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00015A50 File Offset: 0x00013C50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00015A84 File Offset: 0x00013C84
		public unsafe Object Current
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Current_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00015AC4 File Offset: 0x00013CC4
		public unsafe bool IsDone
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1141894, RefRangeEnd = 1141898, XrefRangeStart = 1141894, XrefRangeEnd = 1141894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_IsDone_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00015B00 File Offset: 0x00013D00
		public unsafe float PercentComplete
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1141898, RefRangeEnd = 1141900, XrefRangeStart = 1141898, XrefRangeEnd = 1141898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_PercentComplete_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00015B3C File Offset: 0x00013D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141900, XrefRangeEnd = 1141908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCompletionEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00015B70 File Offset: 0x00013D70
		public unsafe AsyncOperationHandle<TObject> Handle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1141909, RefRangeEnd = 1141912, XrefRangeStart = 1141908, XrefRangeEnd = 1141909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Handle_Internal_get_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00015BA8 File Offset: 0x00013DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141912, XrefRangeEnd = 1141921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCallback(float unscaledDeltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledDeltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UpdateCallback_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00015BE8 File Offset: 0x00013DE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1141928, RefRangeEnd = 1141931, XrefRangeStart = 1141921, XrefRangeEnd = 1141928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(TObject result, bool success, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00015C80 File Offset: 0x00013E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141931, XrefRangeEnd = 1141938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00015D28 File Offset: 0x00013F28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1141978, RefRangeEnd = 1141980, XrefRangeStart = 1141938, XrefRangeEnd = 1141978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00015DD0 File Offset: 0x00013FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1141994, RefRangeEnd = 1141996, XrefRangeStart = 1141980, XrefRangeEnd = 1141994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependency));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updateCallbacks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_Start_Internal_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00015E3C File Offset: 0x0001403C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141996, XrefRangeEnd = 1142002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeExecute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeExecute_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00015E70 File Offset: 0x00014070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142002, XrefRangeEnd = 1142013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_CompletedTypeless_Private_Virtual_Final_New_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00015EB4 File Offset: 0x000140B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142013, XrefRangeEnd = 1142021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_CompletedTypeless_Private_Virtual_Final_New_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00015EF8 File Offset: 0x000140F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141854, RefRangeEnd = 1141855, XrefRangeStart = 1141854, XrefRangeEnd = 1141855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_Destroyed_Private_Virtual_Final_New_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00015F3C File Offset: 0x0001413C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141858, RefRangeEnd = 1141859, XrefRangeStart = 1141858, XrefRangeEnd = 1141859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_Destroyed_Private_Virtual_Final_New_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00015F80 File Offset: 0x00014180
		public unsafe virtual int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Version_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00015FBC File Offset: 0x000141BC
		public unsafe virtual int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ReferenceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_ReferenceCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00015FF8 File Offset: 0x000141F8
		public unsafe virtual float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.PercentComplete
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142021, XrefRangeEnd = 1142022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_PercentComplete_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00016034 File Offset: 0x00014234
		public unsafe virtual AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Status_Private_Virtual_Final_New_get_AsyncOperationStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00016070 File Offset: 0x00014270
		public unsafe virtual Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OperationException
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_OperationException_Private_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000160B0 File Offset: 0x000142B0
		public unsafe virtual bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IsDone
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1141894, RefRangeEnd = 1141898, XrefRangeStart = 1141894, XrefRangeEnd = 1141898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_IsDone_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000160EC File Offset: 0x000142EC
		public unsafe virtual AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Handle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142022, XrefRangeEnd = 1142024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Handle_Private_Virtual_Final_New_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x1700015C RID: 348
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00016124 File Offset: 0x00014324
		public unsafe virtual Action<IAsyncOperation> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OnDestroy
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_set_OnDestroy_Private_Virtual_Final_New_set_Void_Action_1_IAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00016168 File Offset: 0x00014368
		public unsafe virtual string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DebugName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_DebugName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000161A0 File Offset: 0x000143A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142024, XrefRangeEnd = 1142025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetResultAsObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetResultAsObject_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x000161E0 File Offset: 0x000143E0
		public unsafe virtual Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ResultType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142025, XrefRangeEnd = 1142029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_ResultType_Private_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00016220 File Offset: 0x00014420
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDependencies_Private_Virtual_Final_New_Void_List_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00016264 File Offset: 0x00014464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142029, XrefRangeEnd = 1142030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_DecrementReferenceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_DecrementReferenceCount_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00016298 File Offset: 0x00014498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142030, XrefRangeEnd = 1142031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_IncrementReferenceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_IncrementReferenceCount_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000162CC File Offset: 0x000144CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142031, XrefRangeEnd = 1142032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_InvokeCompletionEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_InvokeCompletionEvent_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00016300 File Offset: 0x00014500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142032, XrefRangeEnd = 1142033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependency));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updateCallbacks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_Start_Private_Virtual_Final_New_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001636C File Offset: 0x0001456C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000163A8 File Offset: 0x000145A8
		[CallerCount(0)]
		public unsafe virtual DownloadStatus UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDownloadStatus_Private_Virtual_Final_New_DownloadStatus_HashSet_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000163F8 File Offset: 0x000145F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142033, XrefRangeEnd = 1142037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperationBase<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_New_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00016450 File Offset: 0x00014650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142037, XrefRangeEnd = 1142038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__38_0(AsyncOperationHandle o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(o));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.NativeMethodInfoPtr___ctor_b__38_0_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000391E File Offset: 0x00001B1E
		public AsyncOperationBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00016498 File Offset: 0x00014698
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x000164C0 File Offset: 0x000146C0
		public unsafe TObject _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr__Result_k__BackingField);
				return IL2CPP.PointerToValueGeneric<TObject>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr__Result_k__BackingField);
				Type typeFromHandle = typeof(TObject);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00016568 File Offset: 0x00014768
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00003927 File Offset: 0x00001B27
		public unsafe int m_referenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_referenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_referenceCount)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00016590 File Offset: 0x00014790
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00003942 File Offset: 0x00001B42
		public unsafe AsyncOperationStatus m_Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Status)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000165B8 File Offset: 0x000147B8
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0000395D File Offset: 0x00001B5D
		public unsafe Exception m_Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x000165E8 File Offset: 0x000147E8
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000397C File Offset: 0x00001B7C
		public unsafe ResourceManager m_RM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_RM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_RM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00016618 File Offset: 0x00014818
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0000399B File Offset: 0x00001B9B
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00016640 File Offset: 0x00014840
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000039B6 File Offset: 0x00001BB6
		public unsafe DelegateList<AsyncOperationHandle> m_DestroyedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_DestroyedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateList<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_DestroyedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00016670 File Offset: 0x00014870
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x000039D5 File Offset: 0x00001BD5
		public unsafe DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_CompletedActionT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateList<AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_CompletedActionT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000166A0 File Offset: 0x000148A0
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x000039F4 File Offset: 0x00001BF4
		public unsafe Action<IAsyncOperation> m_OnDestroyAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_OnDestroyAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_OnDestroyAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000166D0 File Offset: 0x000148D0
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00003A13 File Offset: 0x00001C13
		public unsafe Action<AsyncOperationHandle> m_dependencyCompleteAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_dependencyCompleteAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_dependencyCompleteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00016700 File Offset: 0x00014900
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00003A32 File Offset: 0x00001C32
		public unsafe bool HasExecuted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_HasExecuted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_HasExecuted)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00016728 File Offset: 0x00014928
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00003A4D File Offset: 0x00001C4D
		public unsafe Action Executed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_Executed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_Executed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00016758 File Offset: 0x00014958
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00003A6C File Offset: 0x00001C6C
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00016780 File Offset: 0x00014980
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00003A87 File Offset: 0x00001C87
		public unsafe TaskCompletionSource<TObject> m_taskCompletionSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_taskCompletionSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<TObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_taskCompletionSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x000167B0 File Offset: 0x000149B0
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00003AA6 File Offset: 0x00001CA6
		public unsafe TaskCompletionSource<Object> m_taskCompletionSourceTypeless
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_taskCompletionSourceTypeless);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_taskCompletionSourceTypeless), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000167E0 File Offset: 0x000149E0
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00003AC5 File Offset: 0x00001CC5
		public unsafe bool m_InDeferredCallbackQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_InDeferredCallbackQueue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_InDeferredCallbackQueue)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00016808 File Offset: 0x00014A08
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public unsafe DelegateList<float> m_UpdateCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_UpdateCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateList<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_UpdateCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00016838 File Offset: 0x00014A38
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00003AFF File Offset: 0x00001CFF
		public unsafe Action<float> m_UpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_UpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.NativeFieldInfoPtr_m_UpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_m_referenceCount;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_m_Status;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_m_Error;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_m_RM;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_m_DestroyedAction;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_m_CompletedActionT;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDestroyAction;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_m_dependencyCompleteAction;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_HasExecuted;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_Executed;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_m_taskCompletionSource;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_m_taskCompletionSourceTypeless;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_m_InDeferredCallbackQueue;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateCallbacks;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateCallback;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_New_Void_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_New_get_Single_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_New_get_String_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_New_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_TObject_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Public_set_Void_TObject_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedEventHasListeners_Internal_get_Boolean_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_DestroyedEventHasListeners_Internal_get_Boolean_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_set_OnDestroy_Internal_set_Void_Action_1_IAsyncOperation_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_add_Executed_Internal_add_Void_Action_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_remove_Executed_Internal_rem_Void_Action_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceCount_FamOrAssem_get_Int32_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunning_Internal_set_Void_Boolean_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_ShortenPath_Internal_Static_String_String_Boolean_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_New_Boolean_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_IncrementReferenceCount_FamOrAssem_Void_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_DecrementReferenceCount_FamOrAssem_Void_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Internal_get_Task_1_TObject_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Task_Private_Virtual_Final_New_get_Task_1_Object_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_RegisterForDeferredCallbackEvent_Private_Void_Boolean_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_add_Completed_Internal_add_Void_Action_1_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_remove_Completed_Internal_rem_Void_Action_1_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_add_Destroyed_Internal_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_remove_Destroyed_Internal_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_add_CompletedTypeless_Internal_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_remove_CompletedTypeless_Internal_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Internal_get_AsyncOperationStatus_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_OperationException_Internal_get_Exception_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_set_OperationException_Private_set_Void_Exception_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Object_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Internal_get_Boolean_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentComplete_Internal_get_Single_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCallback_Private_Void_Single_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_String_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_String_Boolean_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_TObject_Boolean_Exception_Boolean_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_Start_Internal_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_InvokeExecute_Internal_Void_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_CompletedTypeless_Private_Virtual_Final_New_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_CompletedTypeless_Private_Virtual_Final_New_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_add_Destroyed_Private_Virtual_Final_New_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_remove_Destroyed_Private_Virtual_Final_New_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Version_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_ReferenceCount_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_PercentComplete_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Status_Private_Virtual_Final_New_get_AsyncOperationStatus_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_OperationException_Private_Virtual_Final_New_get_Exception_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_IsDone_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_Handle_Private_Virtual_Final_New_get_AsyncOperationHandle_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_set_OnDestroy_Private_Virtual_Final_New_set_Void_Action_1_IAsyncOperation_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_DebugName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetResultAsObject_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_get_ResultType_Private_Virtual_Final_New_get_Type_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDependencies_Private_Virtual_Final_New_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_DecrementReferenceCount_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_IncrementReferenceCount_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_InvokeCompletionEvent_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_Start_Private_Virtual_Final_New_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_New_Void_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_IAsyncOperation_GetDownloadStatus_Private_Virtual_Final_New_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_New_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__38_0_Private_Void_AsyncOperationHandle_0;

		// Token: 0x0200008D RID: 141
		[ObfuscatedName("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Object
		{
			// Token: 0x060006E7 RID: 1767 RVA: 0x0002022C File Offset: 0x0001E42C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "<>c__DisplayClass60_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass60_0>.NativeClassPtr);
				AsyncOperationBase<TObject>.__c__DisplayClass60_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass60_0>.NativeClassPtr, "value");
				AsyncOperationBase<TObject>.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass60_0>.NativeClassPtr, 100664051);
				AsyncOperationBase<TObject>.__c__DisplayClass60_0.NativeMethodInfoPtr__add_CompletedTypeless_b__0_Internal_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass60_0>.NativeClassPtr, 100664052);
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x000202D0 File Offset: 0x0001E4D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x0002030C File Offset: 0x0001E50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141727, XrefRangeEnd = 1141728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _add_CompletedTypeless_b__0(AsyncOperationHandle<TObject> s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.__c__DisplayClass60_0.NativeMethodInfoPtr__add_CompletedTypeless_b__0_Internal_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006EA RID: 1770 RVA: 0x00004B08 File Offset: 0x00002D08
			public __c__DisplayClass60_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x060006EB RID: 1771 RVA: 0x00020354 File Offset: 0x0001E554
			// (set) Token: 0x060006EC RID: 1772 RVA: 0x00004B11 File Offset: 0x00002D11
			public unsafe Action<AsyncOperationHandle> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.__c__DisplayClass60_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.__c__DisplayClass60_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E2 RID: 1250
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040004E3 RID: 1251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E4 RID: 1252
			private static readonly IntPtr NativeMethodInfoPtr__add_CompletedTypeless_b__0_Internal_Void_AsyncOperationHandle_1_TObject_0;
		}

		// Token: 0x0200008E RID: 142
		[ObfuscatedName("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Object
		{
			// Token: 0x060006ED RID: 1773 RVA: 0x00020384 File Offset: 0x0001E584
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncOperationBase<TObject>>.NativeClassPtr, "<>c__DisplayClass61_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass61_0>.NativeClassPtr);
				AsyncOperationBase<TObject>.__c__DisplayClass61_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass61_0>.NativeClassPtr, "value");
				AsyncOperationBase<TObject>.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass61_0>.NativeClassPtr, 100664053);
				AsyncOperationBase<TObject>.__c__DisplayClass61_0.NativeMethodInfoPtr__remove_CompletedTypeless_b__0_Internal_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass61_0>.NativeClassPtr, 100664054);
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x00020428 File Offset: 0x0001E628
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationBase<TObject>.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006EF RID: 1775 RVA: 0x00020464 File Offset: 0x0001E664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _remove_CompletedTypeless_b__0(AsyncOperationHandle<TObject> s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationBase<TObject>.__c__DisplayClass61_0.NativeMethodInfoPtr__remove_CompletedTypeless_b__0_Internal_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x00004B30 File Offset: 0x00002D30
			public __c__DisplayClass61_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000204AC File Offset: 0x0001E6AC
			// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00004B39 File Offset: 0x00002D39
			public unsafe Action<AsyncOperationHandle> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.__c__DisplayClass61_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationBase<TObject>.__c__DisplayClass61_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E5 RID: 1253
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040004E6 RID: 1254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E7 RID: 1255
			private static readonly IntPtr NativeMethodInfoPtr__remove_CompletedTypeless_b__0_Internal_Void_AsyncOperationHandle_1_TObject_0;
		}
	}
}
