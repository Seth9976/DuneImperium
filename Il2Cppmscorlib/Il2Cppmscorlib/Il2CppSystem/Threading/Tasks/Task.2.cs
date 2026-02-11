using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D3 RID: 467
	public class Task : Object
	{
		// Token: 0x06001E7B RID: 7803 RVA: 0x000B1338 File Offset: 0x000AF538
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "Task");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task>.NativeClassPtr);
			Task.NativeFieldInfoPtr_s_taskIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskIdCounter");
			Task.NativeFieldInfoPtr_m_taskId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_taskId");
			Task.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_action");
			Task.NativeFieldInfoPtr_m_stateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_stateObject");
			Task.NativeFieldInfoPtr_m_taskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_taskScheduler");
			Task.NativeFieldInfoPtr_m_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_parent");
			Task.NativeFieldInfoPtr_m_stateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_stateFlags");
			Task.NativeFieldInfoPtr_OptionsMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "OptionsMask");
			Task.NativeFieldInfoPtr_TASK_STATE_STARTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_STARTED");
			Task.NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_DELEGATE_INVOKED");
			Task.NativeFieldInfoPtr_TASK_STATE_DISPOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_DISPOSED");
			Task.NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_EXCEPTIONOBSERVEDBYPARENT");
			Task.NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_CANCELLATIONACKNOWLEDGED");
			Task.NativeFieldInfoPtr_TASK_STATE_FAULTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_FAULTED");
			Task.NativeFieldInfoPtr_TASK_STATE_CANCELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_CANCELED");
			Task.NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_WAITING_ON_CHILDREN");
			Task.NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_RAN_TO_COMPLETION");
			Task.NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_WAITINGFORACTIVATION");
			Task.NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_COMPLETION_RESERVED");
			Task.NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_THREAD_WAS_ABORTED");
			Task.NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_WAIT_COMPLETION_NOTIFICATION");
			Task.NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_COMPLETED_MASK");
			Task.NativeFieldInfoPtr_CANCELLATION_REQUESTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "CANCELLATION_REQUESTED");
			Task.NativeFieldInfoPtr_m_continuationObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_continuationObject");
			Task.NativeFieldInfoPtr_s_taskCompletionSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskCompletionSentinel");
			Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_asyncDebuggingEnabled");
			Task.NativeFieldInfoPtr_m_contingentProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_contingentProperties");
			Task.NativeFieldInfoPtr_s_taskCancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskCancelCallback");
			Task.NativeFieldInfoPtr_t_currentTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "t_currentTask");
			Task.NativeFieldInfoPtr_t_stackGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "t_stackGuard");
			Task.NativeFieldInfoPtr_s_createContingentProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_createContingentProperties");
			Task.NativeFieldInfoPtr__Factory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<Factory>k__BackingField");
			Task.NativeFieldInfoPtr__CompletedTask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<CompletedTask>k__BackingField");
			Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_IsExceptionObservedByParentPredicate");
			Task.NativeFieldInfoPtr_s_ecCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_ecCallback");
			Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_IsTaskContinuationNullPredicate");
			Task.NativeFieldInfoPtr_s_currentActiveTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_currentActiveTasks");
			Task.NativeFieldInfoPtr_s_activeTasksLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_activeTasksLock");
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668489);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668490);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668491);
			Task.NativeMethodInfoPtr__ctor_Public_Void_Action_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668492);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668493);
			Task.NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668494);
			Task.NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668495);
			Task.NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668496);
			Task.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668497);
			Task.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668498);
			Task.NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668499);
			Task.NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668500);
			Task.NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668501);
			Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668502);
			Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668503);
			Task.NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668504);
			Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668505);
			Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668506);
			Task.NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668507);
			Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668508);
			Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668509);
			Task.NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668510);
			Task.NativeMethodInfoPtr_AddNewChild_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668511);
			Task.NativeMethodInfoPtr_DisregardChild_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668512);
			Task.NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668513);
			Task.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668514);
			Task.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668515);
			Task.NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668516);
			Task.NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668517);
			Task.NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668518);
			Task.NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668519);
			Task.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668520);
			Task.NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668521);
			Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668522);
			Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668523);
			Task.NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668524);
			Task.NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668525);
			Task.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668526);
			Task.NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668527);
			Task.NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668528);
			Task.NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668529);
			Task.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668530);
			Task.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668531);
			Task.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668532);
			Task.NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668533);
			Task.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668534);
			Task.NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668535);
			Task.NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668536);
			Task.NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668537);
			Task.NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668538);
			Task.NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668539);
			Task.NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668540);
			Task.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668541);
			Task.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668542);
			Task.NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668543);
			Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668544);
			Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668545);
			Task.NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668546);
			Task.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668547);
			Task.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668548);
			Task.NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668549);
			Task.NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668550);
			Task.NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668551);
			Task.NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668552);
			Task.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668553);
			Task.NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668554);
			Task.NativeMethodInfoPtr_FinishStageThree_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668555);
			Task.NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668556);
			Task.NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668557);
			Task.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668558);
			Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668559);
			Task.NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668560);
			Task.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668561);
			Task.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668562);
			Task.NativeMethodInfoPtr_HandleException_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668563);
			Task.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668564);
			Task.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668565);
			Task.NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668566);
			Task.NativeMethodInfoPtr_Yield_Public_Static_YieldAwaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668567);
			Task.NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668568);
			Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668569);
			Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668570);
			Task.NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668571);
			Task.NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668572);
			Task.NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668573);
			Task.NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668574);
			Task.NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668575);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668576);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668577);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668578);
			Task.NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668579);
			Task.NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668580);
			Task.NativeMethodInfoPtr_FinishContinuations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668581);
			Task.NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668582);
			Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668583);
			Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_CancellationToken_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668584);
			Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668585);
			Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668586);
			Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668587);
			Task.NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668588);
			Task.NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668589);
			Task.NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668590);
			Task.NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668591);
			Task.NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668592);
			Task.NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668593);
			Task.NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668594);
			Task.NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668595);
			Task.NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668596);
			Task.NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668597);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668598);
			Task.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668599);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668600);
			Task.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668601);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668602);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668603);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668604);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_Func_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668605);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_Func_1_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668606);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668607);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668608);
			Task.NativeMethodInfoPtr_Delay_Public_Static_Task_TimeSpan_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668609);
			Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668610);
			Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668611);
			Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668612);
			Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668613);
			Task.NativeMethodInfoPtr_CreateUnwrapPromise_Public_Static_Task_1_TResult_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668614);
			Task.NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668615);
			Task.NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668616);
			Task.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668617);
			Task.NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668618);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000B2088 File Offset: 0x000B0288
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1358998, RefRangeEnd = 1359003, XrefRangeStart = 1358986, XrefRangeEnd = 1358998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canceled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000B20F4 File Offset: 0x000B02F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1359005, RefRangeEnd = 1359009, XrefRangeStart = 1359003, XrefRangeEnd = 1359005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000B2130 File Offset: 0x000B0330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1359020, RefRangeEnd = 1359021, XrefRangeStart = 1359009, XrefRangeEnd = 1359020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Object state, TaskCreationOptions creationOptions, bool promiseStyle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promiseStyle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000B2198 File Offset: 0x000B0398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1359023, RefRangeEnd = 1359024, XrefRangeStart = 1359021, XrefRangeEnd = 1359023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Action action, CancellationToken cancellationToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Public_Void_Action_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000B21FC File Offset: 0x000B03FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1359027, RefRangeEnd = 1359032, XrefRangeStart = 1359024, XrefRangeEnd = 1359027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Delegate action, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000B22B4 File Offset: 0x000B04B4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1359069, RefRangeEnd = 1359081, XrefRangeStart = 1359032, XrefRangeEnd = 1359069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TaskConstructorCore(Delegate action, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000B2350 File Offset: 0x000B0550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359116, RefRangeEnd = 1359119, XrefRangeStart = 1359081, XrefRangeEnd = 1359116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000B23BC File Offset: 0x000B05BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359119, XrefRangeEnd = 1359131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TaskCancelCallback(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000B23F4 File Offset: 0x000B05F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1359132, RefRangeEnd = 1359136, XrefRangeStart = 1359131, XrefRangeEnd = 1359132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000B2448 File Offset: 0x000B0648
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1359146, RefRangeEnd = 1359156, XrefRangeStart = 1359136, XrefRangeEnd = 1359146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken tokenToRecord, Object cancellationException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000B24AC File Offset: 0x000B06AC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1359169, RefRangeEnd = 1359176, XrefRangeStart = 1359156, XrefRangeEnd = 1359169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000B24FC File Offset: 0x000B06FC
		public unsafe TaskCreationOptions Options
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359176, XrefRangeEnd = 1359180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000B2538 File Offset: 0x000B0738
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TaskCreationOptions OptionsMethod(int flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000B2578 File Offset: 0x000B0778
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1359188, RefRangeEnd = 1359197, XrefRangeStart = 1359180, XrefRangeEnd = 1359188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref illegalBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x000B25D0 File Offset: 0x000B07D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359197, XrefRangeEnd = 1359205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref illegalBits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &oldFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x000B2638 File Offset: 0x000B0838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1359215, RefRangeEnd = 1359216, XrefRangeStart = 1359205, XrefRangeEnd = 1359215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotificationForWaitCompletion(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000B2678 File Offset: 0x000B0878
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1359218, RefRangeEnd = 1359224, XrefRangeStart = 1359216, XrefRangeEnd = 1359218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x000B26B4 File Offset: 0x000B08B4
		public unsafe bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359224, XrefRangeEnd = 1359225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000B26F0 File Offset: 0x000B08F0
		public unsafe virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359225, XrefRangeEnd = 1359226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x000B2738 File Offset: 0x000B0938
		public unsafe bool IsWaitNotificationEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000B2774 File Offset: 0x000B0974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1359227, RefRangeEnd = 1359229, XrefRangeStart = 1359226, XrefRangeEnd = 1359227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDebuggerOfWaitCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000B27A8 File Offset: 0x000B09A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359229, XrefRangeEnd = 1359230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MarkStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x000B27E4 File Offset: 0x000B09E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359230, XrefRangeEnd = 1359246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNewChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddNewChild_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000B2818 File Offset: 0x000B0A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359246, XrefRangeEnd = 1359259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisregardChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_DisregardChild_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000B284C File Offset: 0x000B0A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359259, XrefRangeEnd = 1359266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task InternalStartNew(Task creatingTask, Delegate action, Object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(creatingTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x000B28FC File Offset: 0x000B0AFC
		public unsafe int Id
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1359275, RefRangeEnd = 1359297, XrefRangeStart = 1359266, XrefRangeEnd = 1359275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000B2938 File Offset: 0x000B0B38
		public unsafe static Task InternalCurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359297, XrefRangeEnd = 1359302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000B296C File Offset: 0x000B0B6C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1359310, RefRangeEnd = 1359321, XrefRangeStart = 1359302, XrefRangeEnd = 1359310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000B29AC File Offset: 0x000B0BAC
		public unsafe static StackGuard CurrentStackGuard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1359337, RefRangeEnd = 1359338, XrefRangeStart = 1359321, XrefRangeEnd = 1359337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr3) : null;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x000B29E0 File Offset: 0x000B0BE0
		public unsafe AggregateException Exception
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1359340, RefRangeEnd = 1359343, XrefRangeStart = 1359338, XrefRangeEnd = 1359340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x000B2A20 File Offset: 0x000B0C20
		public unsafe TaskStatus Status
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1359344, RefRangeEnd = 1359352, XrefRangeStart = 1359343, XrefRangeEnd = 1359344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x000B2A5C File Offset: 0x000B0C5C
		public unsafe bool IsCanceled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1359353, RefRangeEnd = 1359354, XrefRangeStart = 1359352, XrefRangeEnd = 1359353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x000B2A98 File Offset: 0x000B0C98
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1359356, RefRangeEnd = 1359359, XrefRangeStart = 1359354, XrefRangeEnd = 1359356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x000B2AD4 File Offset: 0x000B0CD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359376, RefRangeEnd = 1359379, XrefRangeStart = 1359359, XrefRangeEnd = 1359376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x000B2B20 File Offset: 0x000B0D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359379, XrefRangeEnd = 1359388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x000B2B6C File Offset: 0x000B0D6C
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1359389, RefRangeEnd = 1359390, XrefRangeStart = 1359388, XrefRangeEnd = 1359389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x000B2BA4 File Offset: 0x000B0DA4
		public unsafe bool IsCancellationAcknowledged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359390, XrefRangeEnd = 1359391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x000B2BE0 File Offset: 0x000B0DE0
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 1359395, RefRangeEnd = 1359454, XrefRangeStart = 1359391, XrefRangeEnd = 1359395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000B2C1C File Offset: 0x000B0E1C
		[CallerCount(0)]
		public unsafe static bool IsCompletedMethod(int flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x000B2C5C File Offset: 0x000B0E5C
		public unsafe bool IsCompletedSuccessfully
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1359455, RefRangeEnd = 1359462, XrefRangeStart = 1359454, XrefRangeEnd = 1359455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x000B2C98 File Offset: 0x000B0E98
		public unsafe TaskCreationOptions CreationOptions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1359466, RefRangeEnd = 1359468, XrefRangeStart = 1359462, XrefRangeEnd = 1359466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x000B2CD4 File Offset: 0x000B0ED4
		public unsafe virtual WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359468, XrefRangeEnd = 1359503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x000B2D14 File Offset: 0x000B0F14
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x000B2D54 File Offset: 0x000B0F54
		public unsafe virtual bool System.IAsyncResult.CompletedSynchronously
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x000B2D90 File Offset: 0x000B0F90
		public unsafe TaskScheduler ExecutingTaskScheduler
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x000B2DD0 File Offset: 0x000B0FD0
		public unsafe static TaskFactory Factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359503, XrefRangeEnd = 1359507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskFactory>(intPtr3) : null;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x000B2E04 File Offset: 0x000B1004
		public unsafe static Task CompletedTask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359507, XrefRangeEnd = 1359511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x000B2E38 File Offset: 0x000B1038
		public unsafe ManualResetEventSlim CompletedEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359511, XrefRangeEnd = 1359537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr3) : null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x000B2E78 File Offset: 0x000B1078
		public unsafe bool ExceptionRecorded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359537, XrefRangeEnd = 1359541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x000B2EB4 File Offset: 0x000B10B4
		public unsafe bool IsFaulted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1359542, RefRangeEnd = 1359543, XrefRangeStart = 1359541, XrefRangeEnd = 1359542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x000B2EF0 File Offset: 0x000B10F0
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x000B2F30 File Offset: 0x000B1130
		public unsafe ExecutionContext CapturedContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359543, XrefRangeEnd = 1359545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359545, XrefRangeEnd = 1359551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x000B2F74 File Offset: 0x000B1174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359551, XrefRangeEnd = 1359555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x000B2FA8 File Offset: 0x000B11A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359555, XrefRangeEnd = 1359573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x000B2FF4 File Offset: 0x000B11F4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1359582, RefRangeEnd = 1359590, XrefRangeStart = 1359573, XrefRangeEnd = 1359582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleAndStart(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000B3034 File Offset: 0x000B1234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359590, XrefRangeEnd = 1359591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000B3078 File Offset: 0x000B1278
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1359636, RefRangeEnd = 1359643, XrefRangeStart = 1359591, XrefRangeEnd = 1359636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddException(Object exceptionObject, bool representsCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref representsCancellation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x000B30C8 File Offset: 0x000B12C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359661, RefRangeEnd = 1359664, XrefRangeStart = 1359643, XrefRangeEnd = 1359661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeTaskCanceledExceptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000B3114 File Offset: 0x000B1314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359688, RefRangeEnd = 1359691, XrefRangeStart = 1359664, XrefRangeEnd = 1359688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ExceptionDispatchInfo>>(intPtr3) : null;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x000B3154 File Offset: 0x000B1354
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359693, RefRangeEnd = 1359696, XrefRangeStart = 1359691, XrefRangeEnd = 1359693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000B3194 File Offset: 0x000B1394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1359697, RefRangeEnd = 1359699, XrefRangeStart = 1359696, XrefRangeEnd = 1359697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeTaskCanceledExceptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000B31D4 File Offset: 0x000B13D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359699, XrefRangeEnd = 1359713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExceptionObservedStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000B3208 File Offset: 0x000B1408
		public unsafe bool IsExceptionObservedByParent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359713, XrefRangeEnd = 1359714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x000B3244 File Offset: 0x000B1444
		public unsafe bool IsDelegateInvoked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359714, XrefRangeEnd = 1359715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000B3280 File Offset: 0x000B1480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359736, RefRangeEnd = 1359739, XrefRangeStart = 1359715, XrefRangeEnd = 1359736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish(bool bUserDelegateExecuted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bUserDelegateExecuted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000B32C0 File Offset: 0x000B14C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359762, RefRangeEnd = 1359765, XrefRangeStart = 1359739, XrefRangeEnd = 1359762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishStageTwo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000B32F4 File Offset: 0x000B14F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1359774, RefRangeEnd = 1359777, XrefRangeStart = 1359765, XrefRangeEnd = 1359774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishStageThree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishStageThree_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x000B3328 File Offset: 0x000B1528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1359801, RefRangeEnd = 1359802, XrefRangeStart = 1359777, XrefRangeEnd = 1359801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessChildCompletion(Task childTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000B336C File Offset: 0x000B156C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1359840, RefRangeEnd = 1359841, XrefRangeStart = 1359802, XrefRangeEnd = 1359840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExceptionsFromChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000B33A0 File Offset: 0x000B15A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1359843, RefRangeEnd = 1359845, XrefRangeStart = 1359841, XrefRangeEnd = 1359843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000B33D4 File Offset: 0x000B15D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359845, XrefRangeEnd = 1359846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000B3408 File Offset: 0x000B1608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1359856, RefRangeEnd = 1359858, XrefRangeStart = 1359846, XrefRangeEnd = 1359856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bPreventDoubleExecution;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000B3454 File Offset: 0x000B1654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359858, XrefRangeEnd = 1359862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutionContextCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000B348C File Offset: 0x000B168C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1359862, XrefRangeEnd = 1359867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000B34C8 File Offset: 0x000B16C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1359881, RefRangeEnd = 1359882, XrefRangeStart = 1359867, XrefRangeEnd = 1359881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleException(Exception unhandledException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unhandledException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_HandleException_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000B350C File Offset: 0x000B170C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TaskAwaiter(intPtr);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x000B3544 File Offset: 0x000B1744
		[CallerCount(263)]
		[CachedScanResults(RefRangeStart = 1359883, RefRangeEnd = 1360146, XrefRangeStart = 1359882, XrefRangeEnd = 1359883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredTaskAwaitable(intPtr);
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000B3588 File Offset: 0x000B1788
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1360174, RefRangeEnd = 1360179, XrefRangeStart = 1360146, XrefRangeEnd = 1360174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x000B35E8 File Offset: 0x000B17E8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldAwaitable Yield()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Yield_Public_Static_YieldAwaitable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x000B3618 File Offset: 0x000B1818
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1360180, RefRangeEnd = 1360190, XrefRangeStart = 1360179, XrefRangeEnd = 1360180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x000B364C File Offset: 0x000B184C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360191, RefRangeEnd = 1360192, XrefRangeStart = 1360190, XrefRangeEnd = 1360191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x000B3698 File Offset: 0x000B1898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1360203, RefRangeEnd = 1360205, XrefRangeStart = 1360192, XrefRangeEnd = 1360203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x000B36F8 File Offset: 0x000B18F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360206, RefRangeEnd = 1360207, XrefRangeStart = 1360205, XrefRangeEnd = 1360206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WrappedTryRunInline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000B3734 File Offset: 0x000B1934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1360279, RefRangeEnd = 1360283, XrefRangeStart = 1360207, XrefRangeEnd = 1360279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x000B3794 File Offset: 0x000B1994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360323, RefRangeEnd = 1360324, XrefRangeStart = 1360283, XrefRangeEnd = 1360323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x000B37F4 File Offset: 0x000B19F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1360324, XrefRangeEnd = 1360342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SpinWait(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000B3840 File Offset: 0x000B1A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1360355, RefRangeEnd = 1360358, XrefRangeStart = 1360342, XrefRangeEnd = 1360355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bCancelNonExecutingOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x000B388C File Offset: 0x000B1A8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1360369, RefRangeEnd = 1360373, XrefRangeStart = 1360358, XrefRangeEnd = 1360369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000B38C0 File Offset: 0x000B1AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1360373, XrefRangeEnd = 1360380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000B3908 File Offset: 0x000B1B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1360380, XrefRangeEnd = 1360388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest(CancellationToken tokenToRecord, Object cancellationException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000B3964 File Offset: 0x000B1B64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1360402, RefRangeEnd = 1360404, XrefRangeStart = 1360388, XrefRangeEnd = 1360402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCleanupLogic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000B3998 File Offset: 0x000B1B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1360404, XrefRangeEnd = 1360406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCancellationAcknowledged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000B39CC File Offset: 0x000B1BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360432, RefRangeEnd = 1360433, XrefRangeStart = 1360406, XrefRangeEnd = 1360432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishContinuations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishContinuations_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000B3A00 File Offset: 0x000B1C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1360433, XrefRangeEnd = 1360436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFinishCompletionNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000B3A34 File Offset: 0x000B1C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360450, RefRangeEnd = 1360451, XrefRangeStart = 1360436, XrefRangeEnd = 1360450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task> continuationAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000B3A84 File Offset: 0x000B1C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360452, RefRangeEnd = 1360453, XrefRangeStart = 1360451, XrefRangeEnd = 1360452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_CancellationToken_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000B3B0C File Offset: 0x000B1D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1360477, RefRangeEnd = 1360479, XrefRangeStart = 1360453, XrefRangeEnd = 1360477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000B3B94 File Offset: 0x000B1D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360480, RefRangeEnd = 1360481, XrefRangeStart = 1360479, XrefRangeEnd = 1360480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task, Object> continuationAction, Object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000B3C30 File Offset: 0x000B1E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360505, RefRangeEnd = 1360506, XrefRangeStart = 1360481, XrefRangeEnd = 1360505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task, Object> continuationAction, Object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1360506, RefRangeEnd = 1360512, XrefRangeStart = 1360506, XrefRangeEnd = 1360506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continuationOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &internalOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000B3D1C File Offset: 0x000B1F1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1360545, RefRangeEnd = 1360551, XrefRangeStart = 1360512, XrefRangeEnd = 1360545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000B3D98 File Offset: 0x000B1F98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1360555, RefRangeEnd = 1360559, XrefRangeStart = 1360551, XrefRangeEnd = 1360555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCompletionAction(ITaskCompletionAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000B3DDC File Offset: 0x000B1FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1360559, XrefRangeEnd = 1360563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000B3E2C File Offset: 0x000B202C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360607, RefRangeEnd = 1360608, XrefRangeStart = 1360563, XrefRangeEnd = 1360607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddTaskContinuationComplex(Object tc, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x000B3E88 File Offset: 0x000B2088
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1360618, RefRangeEnd = 1360625, XrefRangeStart = 1360608, XrefRangeEnd = 1360618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddTaskContinuation(Object tc, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000B3EE4 File Offset: 0x000B20E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1360657, RefRangeEnd = 1360660, XrefRangeStart = 1360625, XrefRangeEnd = 1360657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveContinuation(Object continuationObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000B3F28 File Offset: 0x000B2128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360664, RefRangeEnd = 1360665, XrefRangeStart = 1360660, XrefRangeEnd = 1360664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromResult<TResult>(TResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromResult_Public_Static_Task_1_TResult_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000B3FA4 File Offset: 0x000B21A4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1360671, RefRangeEnd = 1360685, XrefRangeStart = 1360665, XrefRangeEnd = 1360671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000B3FE8 File Offset: 0x000B21E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1360690, RefRangeEnd = 1360695, XrefRangeStart = 1360685, XrefRangeEnd = 1360690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromException<TResult>(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromException_Public_Static_Task_1_TResult_Exception_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000B402C File Offset: 0x000B222C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1360703, RefRangeEnd = 1360705, XrefRangeStart = 1360695, XrefRangeEnd = 1360703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromCancellation(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000B4078 File Offset: 0x000B2278
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1360709, RefRangeEnd = 1360719, XrefRangeStart = 1360705, XrefRangeEnd = 1360709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromCanceled(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000B40C4 File Offset: 0x000B22C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360727, RefRangeEnd = 1360728, XrefRangeStart = 1360719, XrefRangeEnd = 1360727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000B4110 File Offset: 0x000B2310
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1360740, RefRangeEnd = 1360744, XrefRangeStart = 1360728, XrefRangeEnd = 1360740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromCanceled_Public_Static_Task_1_TResult_CancellationToken_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000B415C File Offset: 0x000B235C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1360749, RefRangeEnd = 1360751, XrefRangeStart = 1360744, XrefRangeEnd = 1360749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000B41A0 File Offset: 0x000B23A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1360767, RefRangeEnd = 1360771, XrefRangeStart = 1360751, XrefRangeEnd = 1360767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Run(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Run_Public_Static_Task_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000B41E4 File Offset: 0x000B23E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360780, RefRangeEnd = 1360781, XrefRangeStart = 1360771, XrefRangeEnd = 1360780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000B4228 File Offset: 0x000B2428
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1360785, RefRangeEnd = 1360792, XrefRangeStart = 1360781, XrefRangeEnd = 1360785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Run(Func<Task> function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Run_Public_Static_Task_Func_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000B426C File Offset: 0x000B246C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1360819, RefRangeEnd = 1360821, XrefRangeStart = 1360792, XrefRangeEnd = 1360819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Run_Public_Static_Task_Func_1_Task_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000B42C8 File Offset: 0x000B24C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1360835, RefRangeEnd = 1360837, XrefRangeStart = 1360821, XrefRangeEnd = 1360835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000B430C File Offset: 0x000B250C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1360860, RefRangeEnd = 1360861, XrefRangeStart = 1360837, XrefRangeEnd = 1360860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000B4368 File Offset: 0x000B2568
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1360869, RefRangeEnd = 1360874, XrefRangeStart = 1360861, XrefRangeEnd = 1360869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Delay(TimeSpan delay, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Delay_Public_Static_Task_TimeSpan_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000B43C0 File Offset: 0x000B25C0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1360878, RefRangeEnd = 1360897, XrefRangeStart = 1360874, XrefRangeEnd = 1360878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Delay(int millisecondsDelay)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000B4400 File Offset: 0x000B2600
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1360972, RefRangeEnd = 1360980, XrefRangeStart = 1360897, XrefRangeEnd = 1360972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000B4458 File Offset: 0x000B2658
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1361010, RefRangeEnd = 1361017, XrefRangeStart = 1360980, XrefRangeEnd = 1361010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> WhenAny([Optional] Il2CppReferenceArray<Task> tasks)
		{
			if (tasks == null)
			{
				tasks = new Il2CppReferenceArray<Task>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000B44AC File Offset: 0x000B26AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361044, RefRangeEnd = 1361045, XrefRangeStart = 1361017, XrefRangeEnd = 1361044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000B44F0 File Offset: 0x000B26F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361045, XrefRangeEnd = 1361049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookForOce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_CreateUnwrapPromise_Public_Static_Task_1_TResult_Task_Boolean_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000B4544 File Offset: 0x000B2744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361064, RefRangeEnd = 1361065, XrefRangeStart = 1361049, XrefRangeEnd = 1361064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddToActiveTasks(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000B4588 File Offset: 0x000B2788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361079, RefRangeEnd = 1361080, XrefRangeStart = 1361065, XrefRangeEnd = 1361079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromActiveTasks(int taskId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref taskId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000B45BC File Offset: 0x000B27BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MarkAborted(ThreadAbortException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000B4600 File Offset: 0x000B2800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361112, RefRangeEnd = 1361113, XrefRangeStart = 1361080, XrefRangeEnd = 1361112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTaskSlot);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				currentTaskSlot = ((intPtr4 == 0) ? null : new Task(intPtr4));
			}
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00009F38 File Offset: 0x00008138
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return Task.WhenAny(new Il2CppReferenceArray<Task>(tasks));
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00009F45 File Offset: 0x00008145
		public Task(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x000B4658 File Offset: 0x000B2858
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00009F4E File Offset: 0x0000814E
		public unsafe static int s_taskIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskIdCounter, (void*)(&value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x000B4674 File Offset: 0x000B2874
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00009F5C File Offset: 0x0000815C
		public unsafe int m_taskId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskId)) = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x000B469C File Offset: 0x000B289C
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00009F77 File Offset: 0x00008177
		public unsafe Delegate m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000B46CC File Offset: 0x000B28CC
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x00009F96 File Offset: 0x00008196
		public unsafe Object m_stateObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000B46FC File Offset: 0x000B28FC
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x00009FB5 File Offset: 0x000081B5
		public unsafe TaskScheduler m_taskScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000B472C File Offset: 0x000B292C
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x00009FD4 File Offset: 0x000081D4
		public unsafe Task m_parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000B475C File Offset: 0x000B295C
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00009FF3 File Offset: 0x000081F3
		public unsafe int m_stateFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateFlags)) = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000B4784 File Offset: 0x000B2984
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x0000A00E File Offset: 0x0000820E
		public unsafe static int OptionsMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_OptionsMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_OptionsMask, (void*)(&value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000B47A0 File Offset: 0x000B29A0
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x0000A01C File Offset: 0x0000821C
		public unsafe static int TASK_STATE_STARTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_STARTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_STARTED, (void*)(&value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x000B47BC File Offset: 0x000B29BC
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x0000A02A File Offset: 0x0000822A
		public unsafe static int TASK_STATE_DELEGATE_INVOKED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED, (void*)(&value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x000B47D8 File Offset: 0x000B29D8
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x0000A038 File Offset: 0x00008238
		public unsafe static int TASK_STATE_DISPOSED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_DISPOSED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_DISPOSED, (void*)(&value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x000B47F4 File Offset: 0x000B29F4
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x0000A046 File Offset: 0x00008246
		public unsafe static int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT, (void*)(&value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x000B4810 File Offset: 0x000B2A10
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x0000A054 File Offset: 0x00008254
		public unsafe static int TASK_STATE_CANCELLATIONACKNOWLEDGED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED, (void*)(&value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x000B482C File Offset: 0x000B2A2C
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x0000A062 File Offset: 0x00008262
		public unsafe static int TASK_STATE_FAULTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_FAULTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_FAULTED, (void*)(&value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x000B4848 File Offset: 0x000B2A48
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x0000A070 File Offset: 0x00008270
		public unsafe static int TASK_STATE_CANCELED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELED, (void*)(&value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x000B4864 File Offset: 0x000B2A64
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x0000A07E File Offset: 0x0000827E
		public unsafe static int TASK_STATE_WAITING_ON_CHILDREN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN, (void*)(&value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000B4880 File Offset: 0x000B2A80
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x0000A08C File Offset: 0x0000828C
		public unsafe static int TASK_STATE_RAN_TO_COMPLETION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION, (void*)(&value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x000B489C File Offset: 0x000B2A9C
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0000A09A File Offset: 0x0000829A
		public unsafe static int TASK_STATE_WAITINGFORACTIVATION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION, (void*)(&value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x000B48B8 File Offset: 0x000B2AB8
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x0000A0A8 File Offset: 0x000082A8
		public unsafe static int TASK_STATE_COMPLETION_RESERVED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED, (void*)(&value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x000B48D4 File Offset: 0x000B2AD4
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0000A0B6 File Offset: 0x000082B6
		public unsafe static int TASK_STATE_THREAD_WAS_ABORTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED, (void*)(&value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x000B48F0 File Offset: 0x000B2AF0
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0000A0C4 File Offset: 0x000082C4
		public unsafe static int TASK_STATE_WAIT_COMPLETION_NOTIFICATION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION, (void*)(&value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x000B490C File Offset: 0x000B2B0C
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x0000A0D2 File Offset: 0x000082D2
		public unsafe static int TASK_STATE_COMPLETED_MASK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK, (void*)(&value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x000B4928 File Offset: 0x000B2B28
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x0000A0E0 File Offset: 0x000082E0
		public unsafe static int CANCELLATION_REQUESTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_CANCELLATION_REQUESTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_CANCELLATION_REQUESTED, (void*)(&value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x000B4944 File Offset: 0x000B2B44
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0000A0EE File Offset: 0x000082EE
		public unsafe Object m_continuationObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_continuationObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_continuationObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x000B4974 File Offset: 0x000B2B74
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0000A10D File Offset: 0x0000830D
		public unsafe static Object s_taskCompletionSentinel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskCompletionSentinel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskCompletionSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x000B499C File Offset: 0x000B2B9C
		// (set) Token: 0x06001F33 RID: 7987 RVA: 0x0000A11F File Offset: 0x0000831F
		public unsafe static bool s_asyncDebuggingEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled, (void*)(&value));
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x000B49B8 File Offset: 0x000B2BB8
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0000A12D File Offset: 0x0000832D
		public unsafe Task.ContingentProperties m_contingentProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_contingentProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_contingentProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x000B49E8 File Offset: 0x000B2BE8
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x0000A14C File Offset: 0x0000834C
		public unsafe static Action<Object> s_taskCancelCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskCancelCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskCancelCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x000B4A10 File Offset: 0x000B2C10
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x0000A15E File Offset: 0x0000835E
		public unsafe static Task t_currentTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_t_currentTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_t_currentTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000B4A38 File Offset: 0x000B2C38
		// (set) Token: 0x06001F3B RID: 7995 RVA: 0x0000A170 File Offset: 0x00008370
		public unsafe static StackGuard t_stackGuard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_t_stackGuard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_t_stackGuard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x000B4A60 File Offset: 0x000B2C60
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x0000A182 File Offset: 0x00008382
		public unsafe static Func<Task.ContingentProperties> s_createContingentProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_createContingentProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task.ContingentProperties>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_createContingentProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x000B4A88 File Offset: 0x000B2C88
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x0000A194 File Offset: 0x00008394
		public unsafe static TaskFactory _Factory_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr__Factory_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr__Factory_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x000B4AB0 File Offset: 0x000B2CB0
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x0000A1A6 File Offset: 0x000083A6
		public unsafe static Task _CompletedTask_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr__CompletedTask_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr__CompletedTask_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x000B4AD8 File Offset: 0x000B2CD8
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0000A1B8 File Offset: 0x000083B8
		public unsafe static Predicate<Task> s_IsExceptionObservedByParentPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Task>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x000B4B00 File Offset: 0x000B2D00
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x0000A1CA File Offset: 0x000083CA
		public unsafe static ContextCallback s_ecCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_ecCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_ecCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x000B4B28 File Offset: 0x000B2D28
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0000A1DC File Offset: 0x000083DC
		public unsafe static Predicate<Object> s_IsTaskContinuationNullPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x000B4B50 File Offset: 0x000B2D50
		// (set) Token: 0x06001F49 RID: 8009 RVA: 0x0000A1EE File Offset: 0x000083EE
		public unsafe static Dictionary<int, Task> s_currentActiveTasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_currentActiveTasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Task>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_currentActiveTasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x000B4B78 File Offset: 0x000B2D78
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x0000A200 File Offset: 0x00008400
		public unsafe static Object s_activeTasksLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_activeTasksLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_activeTasksLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeFieldInfoPtr_s_taskIdCounter;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr_m_taskId;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_m_stateObject;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr_m_taskScheduler;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_m_parent;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr_m_stateFlags;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr_OptionsMask;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_STARTED;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_DISPOSED;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_FAULTED;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_CANCELED;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr_CANCELLATION_REQUESTED;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr_m_continuationObject;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeFieldInfoPtr_s_taskCompletionSentinel;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncDebuggingEnabled;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeFieldInfoPtr_m_contingentProperties;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeFieldInfoPtr_s_taskCancelCallback;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeFieldInfoPtr_t_currentTask;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeFieldInfoPtr_t_stackGuard;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeFieldInfoPtr_s_createContingentProperties;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeFieldInfoPtr__Factory_k__BackingField;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeFieldInfoPtr__CompletedTask_k__BackingField;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeFieldInfoPtr_s_ecCallback;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeFieldInfoPtr_s_currentActiveTasks;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTasksLock;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_CancellationToken_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_AddNewChild_Internal_Void_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_DisregardChild_Internal_Void_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_AddException_Internal_Void_Object_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeMethodInfoPtr_FinishStageThree_Internal_Void_0;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_HandleException_Private_Void_Exception_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_0;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_Yield_Public_Static_YieldAwaitable_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_FinishContinuations_Internal_Void_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_CancellationToken_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_FromCanceled_Public_Static_Task_CancellationToken_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeMethodInfoPtr_FromCanceled_Public_Static_Task_1_TResult_CancellationToken_0;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_Action_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_Func_1_Task_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_Func_1_Task_CancellationToken_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Task_TimeSpan_CancellationToken_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnwrapPromise_Public_Static_Task_1_TResult_Task_Boolean_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0;

		// Token: 0x02000632 RID: 1586
		public class ContingentProperties : Object
		{
			// Token: 0x06005939 RID: 22841 RVA: 0x00199424 File Offset: 0x00197624
			// Note: this type is marked as 'beforefieldinit'.
			static ContingentProperties()
			{
				Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "ContingentProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr);
				Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_capturedContext");
				Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_completionEvent");
				Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_exceptionsHolder");
				Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_cancellationToken");
				Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_cancellationRegistration");
				Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_internalCancellationRequested");
				Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_completionCountdown");
				Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_exceptionalChildren");
				Task.ContingentProperties.NativeMethodInfoPtr_SetCompleted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100668620);
				Task.ContingentProperties.NativeMethodInfoPtr_UnregisterCancellationCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100668621);
				Task.ContingentProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100668622);
			}

			// Token: 0x0600593A RID: 22842 RVA: 0x0019952C File Offset: 0x0019772C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1358923, RefRangeEnd = 1358924, XrefRangeStart = 1358921, XrefRangeEnd = 1358923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetCompleted()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr_SetCompleted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600593B RID: 22843 RVA: 0x00199560 File Offset: 0x00197760
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1358930, RefRangeEnd = 1358932, XrefRangeStart = 1358924, XrefRangeEnd = 1358930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnregisterCancellationCallback()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr_UnregisterCancellationCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600593C RID: 22844 RVA: 0x00199594 File Offset: 0x00197794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358932, XrefRangeEnd = 1358934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContingentProperties()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600593D RID: 22845 RVA: 0x0001FE7C File Offset: 0x0001E07C
			public ContingentProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016BF RID: 5823
			// (get) Token: 0x0600593E RID: 22846 RVA: 0x001995D0 File Offset: 0x001977D0
			// (set) Token: 0x0600593F RID: 22847 RVA: 0x0001FE85 File Offset: 0x0001E085
			public unsafe ExecutionContext m_capturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016C0 RID: 5824
			// (get) Token: 0x06005940 RID: 22848 RVA: 0x00199600 File Offset: 0x00197800
			// (set) Token: 0x06005941 RID: 22849 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
			public unsafe ManualResetEventSlim m_completionEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016C1 RID: 5825
			// (get) Token: 0x06005942 RID: 22850 RVA: 0x00199630 File Offset: 0x00197830
			// (set) Token: 0x06005943 RID: 22851 RVA: 0x0001FEC3 File Offset: 0x0001E0C3
			public unsafe TaskExceptionHolder m_exceptionsHolder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskExceptionHolder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016C2 RID: 5826
			// (get) Token: 0x06005944 RID: 22852 RVA: 0x00199660 File Offset: 0x00197860
			// (set) Token: 0x06005945 RID: 22853 RVA: 0x0001FEE2 File Offset: 0x0001E0E2
			public CancellationToken m_cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170016C3 RID: 5827
			// (get) Token: 0x06005946 RID: 22854 RVA: 0x00199690 File Offset: 0x00197890
			// (set) Token: 0x06005947 RID: 22855 RVA: 0x0001FF10 File Offset: 0x0001E110
			public unsafe Object m_cancellationRegistration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016C4 RID: 5828
			// (get) Token: 0x06005948 RID: 22856 RVA: 0x001996C0 File Offset: 0x001978C0
			// (set) Token: 0x06005949 RID: 22857 RVA: 0x0001FF2F File Offset: 0x0001E12F
			public unsafe int m_internalCancellationRequested
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested)) = value;
				}
			}

			// Token: 0x170016C5 RID: 5829
			// (get) Token: 0x0600594A RID: 22858 RVA: 0x001996E8 File Offset: 0x001978E8
			// (set) Token: 0x0600594B RID: 22859 RVA: 0x0001FF4A File Offset: 0x0001E14A
			public unsafe int m_completionCountdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown)) = value;
				}
			}

			// Token: 0x170016C6 RID: 5830
			// (get) Token: 0x0600594C RID: 22860 RVA: 0x00199710 File Offset: 0x00197910
			// (set) Token: 0x0600594D RID: 22861 RVA: 0x0001FF65 File Offset: 0x0001E165
			public unsafe LowLevelListWithIList<Task> m_exceptionalChildren
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelListWithIList<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004934 RID: 18740
			private static readonly IntPtr NativeFieldInfoPtr_m_capturedContext;

			// Token: 0x04004935 RID: 18741
			private static readonly IntPtr NativeFieldInfoPtr_m_completionEvent;

			// Token: 0x04004936 RID: 18742
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionsHolder;

			// Token: 0x04004937 RID: 18743
			private static readonly IntPtr NativeFieldInfoPtr_m_cancellationToken;

			// Token: 0x04004938 RID: 18744
			private static readonly IntPtr NativeFieldInfoPtr_m_cancellationRegistration;

			// Token: 0x04004939 RID: 18745
			private static readonly IntPtr NativeFieldInfoPtr_m_internalCancellationRequested;

			// Token: 0x0400493A RID: 18746
			private static readonly IntPtr NativeFieldInfoPtr_m_completionCountdown;

			// Token: 0x0400493B RID: 18747
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionalChildren;

			// Token: 0x0400493C RID: 18748
			private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_0;

			// Token: 0x0400493D RID: 18749
			private static readonly IntPtr NativeMethodInfoPtr_UnregisterCancellationCallback_Internal_Void_0;

			// Token: 0x0400493E RID: 18750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000633 RID: 1587
		public sealed class SetOnInvokeMres : ManualResetEventSlim
		{
			// Token: 0x0600594E RID: 22862 RVA: 0x00199740 File Offset: 0x00197940
			// Note: this type is marked as 'beforefieldinit'.
			static SetOnInvokeMres()
			{
				Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "SetOnInvokeMres");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr);
				Task.SetOnInvokeMres.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr, 100668623);
				Task.SetOnInvokeMres.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr, 100668624);
				Task.SetOnInvokeMres.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr, 100668625);
			}

			// Token: 0x0600594F RID: 22863 RVA: 0x001997A8 File Offset: 0x001979A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358934, XrefRangeEnd = 1358938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetOnInvokeMres()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.SetOnInvokeMres.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005950 RID: 22864 RVA: 0x001997E4 File Offset: 0x001979E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358938, XrefRangeEnd = 1358939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.SetOnInvokeMres.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170016C7 RID: 5831
			// (get) Token: 0x06005951 RID: 22865 RVA: 0x00199828 File Offset: 0x00197A28
			public unsafe bool InvokeMayRunArbitraryCode
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.SetOnInvokeMres.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005952 RID: 22866 RVA: 0x0001FF84 File Offset: 0x0001E184
			public SetOnInvokeMres(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400493F RID: 18751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004940 RID: 18752
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;

			// Token: 0x04004941 RID: 18753
			private static readonly IntPtr NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0;
		}

		// Token: 0x02000634 RID: 1588
		public sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x06005953 RID: 22867 RVA: 0x00199864 File Offset: 0x00197A64
			// Note: this type is marked as 'beforefieldinit'.
			static DelayPromise()
			{
				Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "DelayPromise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr);
				Task.DelayPromise.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Token");
				Task.DelayPromise.NativeFieldInfoPtr_Registration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Registration");
				Task.DelayPromise.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Timer");
				Task.DelayPromise.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, 100668626);
				Task.DelayPromise.NativeMethodInfoPtr_Complete_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, 100668627);
			}

			// Token: 0x06005954 RID: 22868 RVA: 0x001998F4 File Offset: 0x00197AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358939, XrefRangeEnd = 1358950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelayPromise(CancellationToken token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.DelayPromise.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005955 RID: 22869 RVA: 0x00199944 File Offset: 0x00197B44
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1358968, RefRangeEnd = 1358970, XrefRangeStart = 1358950, XrefRangeEnd = 1358968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Complete()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.DelayPromise.NativeMethodInfoPtr_Complete_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005956 RID: 22870 RVA: 0x0001FF8D File Offset: 0x0001E18D
			public DelayPromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016C8 RID: 5832
			// (get) Token: 0x06005957 RID: 22871 RVA: 0x00199978 File Offset: 0x00197B78
			// (set) Token: 0x06005958 RID: 22872 RVA: 0x0001FF96 File Offset: 0x0001E196
			public CancellationToken Token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Token);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Token), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170016C9 RID: 5833
			// (get) Token: 0x06005959 RID: 22873 RVA: 0x001999A8 File Offset: 0x00197BA8
			// (set) Token: 0x0600595A RID: 22874 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
			public CancellationTokenRegistration Registration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Registration);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Registration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170016CA RID: 5834
			// (get) Token: 0x0600595B RID: 22875 RVA: 0x001999D8 File Offset: 0x00197BD8
			// (set) Token: 0x0600595C RID: 22876 RVA: 0x0001FFF2 File Offset: 0x0001E1F2
			public unsafe Timer Timer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Timer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Timer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004942 RID: 18754
			private static readonly IntPtr NativeFieldInfoPtr_Token;

			// Token: 0x04004943 RID: 18755
			private static readonly IntPtr NativeFieldInfoPtr_Registration;

			// Token: 0x04004944 RID: 18756
			private static readonly IntPtr NativeFieldInfoPtr_Timer;

			// Token: 0x04004945 RID: 18757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0;

			// Token: 0x04004946 RID: 18758
			private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_0;
		}

		// Token: 0x02000635 RID: 1589
		[ObfuscatedName("System.Threading.Tasks.Task+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600595D RID: 22877 RVA: 0x00199A08 File Offset: 0x00197C08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Task.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.__c>.NativeClassPtr);
				Task.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9");
				Task.__c.NativeFieldInfoPtr___9__247_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9__247_0");
				Task.__c.NativeFieldInfoPtr___9__247_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9__247_1");
				Task.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100668629);
				Task.__c.NativeMethodInfoPtr__Delay_b__247_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100668630);
				Task.__c.NativeMethodInfoPtr__Delay_b__247_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100668631);
				Task.__c.NativeMethodInfoPtr___cctor_b__271_0_Internal_ContingentProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100668632);
				Task.__c.NativeMethodInfoPtr___cctor_b__271_1_Internal_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100668633);
				Task.__c.NativeMethodInfoPtr___cctor_b__271_2_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100668634);
			}

			// Token: 0x0600595E RID: 22878 RVA: 0x00199AE8 File Offset: 0x00197CE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600595F RID: 22879 RVA: 0x00199B24 File Offset: 0x00197D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358970, XrefRangeEnd = 1358975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Delay_b__247_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__Delay_b__247_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005960 RID: 22880 RVA: 0x00199B68 File Offset: 0x00197D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358975, XrefRangeEnd = 1358980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Delay_b__247_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__Delay_b__247_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005961 RID: 22881 RVA: 0x00199BAC File Offset: 0x00197DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358980, XrefRangeEnd = 1358985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task.ContingentProperties __cctor_b__271_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__271_0_Internal_ContingentProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}

			// Token: 0x06005962 RID: 22882 RVA: 0x00199BEC File Offset: 0x00197DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358985, XrefRangeEnd = 1358986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__271_1(Task t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__271_1_Internal_Boolean_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005963 RID: 22883 RVA: 0x00199C3C File Offset: 0x00197E3C
			[CallerCount(0)]
			public unsafe bool __cctor_b__271_2(Object tc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__271_2_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005964 RID: 22884 RVA: 0x00020011 File Offset: 0x0001E211
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016CB RID: 5835
			// (get) Token: 0x06005965 RID: 22885 RVA: 0x00199C8C File Offset: 0x00197E8C
			// (set) Token: 0x06005966 RID: 22886 RVA: 0x0002001A File Offset: 0x0001E21A
			public unsafe static Task.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016CC RID: 5836
			// (get) Token: 0x06005967 RID: 22887 RVA: 0x00199CB4 File Offset: 0x00197EB4
			// (set) Token: 0x06005968 RID: 22888 RVA: 0x0002002C File Offset: 0x0001E22C
			public unsafe static Action<Object> __9__247_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9__247_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9__247_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016CD RID: 5837
			// (get) Token: 0x06005969 RID: 22889 RVA: 0x00199CDC File Offset: 0x00197EDC
			// (set) Token: 0x0600596A RID: 22890 RVA: 0x0002003E File Offset: 0x0001E23E
			public unsafe static TimerCallback __9__247_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9__247_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9__247_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004947 RID: 18759
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004948 RID: 18760
			private static readonly IntPtr NativeFieldInfoPtr___9__247_0;

			// Token: 0x04004949 RID: 18761
			private static readonly IntPtr NativeFieldInfoPtr___9__247_1;

			// Token: 0x0400494A RID: 18762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400494B RID: 18763
			private static readonly IntPtr NativeMethodInfoPtr__Delay_b__247_0_Internal_Void_Object_0;

			// Token: 0x0400494C RID: 18764
			private static readonly IntPtr NativeMethodInfoPtr__Delay_b__247_1_Internal_Void_Object_0;

			// Token: 0x0400494D RID: 18765
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__271_0_Internal_ContingentProperties_0;

			// Token: 0x0400494E RID: 18766
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__271_1_Internal_Boolean_Task_0;

			// Token: 0x0400494F RID: 18767
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__271_2_Internal_Boolean_Object_0;
		}

		// Token: 0x02000636 RID: 1590
		private sealed class MethodInfoStoreGeneric_FromResult_Public_Static_Task_1_TResult_TResult_0<TResult>
		{
			// Token: 0x04004950 RID: 18768
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000637 RID: 1591
		private sealed class MethodInfoStoreGeneric_FromException_Public_Static_Task_1_TResult_Exception_0<TResult>
		{
			// Token: 0x04004951 RID: 18769
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000638 RID: 1592
		private sealed class MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0<TResult>
		{
			// Token: 0x04004952 RID: 18770
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000639 RID: 1593
		private sealed class MethodInfoStoreGeneric_FromCanceled_Public_Static_Task_1_TResult_CancellationToken_0<TResult>
		{
			// Token: 0x04004953 RID: 18771
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_1_TResult_CancellationToken_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063A RID: 1594
		private sealed class MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0<TResult>
		{
			// Token: 0x04004954 RID: 18772
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063B RID: 1595
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_TResult_0<TResult>
		{
			// Token: 0x04004955 RID: 18773
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063C RID: 1596
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0<TResult>
		{
			// Token: 0x04004956 RID: 18774
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063D RID: 1597
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0<TResult>
		{
			// Token: 0x04004957 RID: 18775
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063E RID: 1598
		private sealed class MethodInfoStoreGeneric_CreateUnwrapPromise_Public_Static_Task_1_TResult_Task_Boolean_0<TResult>
		{
			// Token: 0x04004958 RID: 18776
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_CreateUnwrapPromise_Public_Static_Task_1_TResult_Task_Boolean_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
