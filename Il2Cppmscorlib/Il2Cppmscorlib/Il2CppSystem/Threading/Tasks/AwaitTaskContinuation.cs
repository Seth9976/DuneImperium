using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E4 RID: 484
	public class AwaitTaskContinuation : TaskContinuation
	{
		// Token: 0x06001FA7 RID: 8103 RVA: 0x000B5F2C File Offset: 0x000B412C
		// Note: this type is marked as 'beforefieldinit'.
		static AwaitTaskContinuation()
		{
			Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr);
			AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_capturedContext");
			AwaitTaskContinuation.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_action");
			AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "s_invokeActionCallback");
			AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668678);
			AwaitTaskContinuation.NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668679);
			AwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668680);
			AwaitTaskContinuation.NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668681);
			AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668682);
			AwaitTaskContinuation.NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668683);
			AwaitTaskContinuation.NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668684);
			AwaitTaskContinuation.NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668685);
			AwaitTaskContinuation.NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668686);
			AwaitTaskContinuation.NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668687);
			AwaitTaskContinuation.NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668688);
			AwaitTaskContinuation.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668689);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000B6088 File Offset: 0x000B4288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1361508, RefRangeEnd = 1361511, XrefRangeStart = 1361501, XrefRangeEnd = 1361508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitTaskContinuation(Action action, bool flowExecutionContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000B60E4 File Offset: 0x000B42E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361511, XrefRangeEnd = 1361516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CreateTask(Action<Object> action, Object state, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000B6158 File Offset: 0x000B4358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361516, XrefRangeEnd = 1361524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task ignored, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ignored);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x000B61B4 File Offset: 0x000B43B4
		public unsafe static bool IsValidLocationForInlining
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1361534, RefRangeEnd = 1361537, XrefRangeStart = 1361524, XrefRangeEnd = 1361534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x000B61E4 File Offset: 0x000B43E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361537, XrefRangeEnd = 1361543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x000B6218 File Offset: 0x000B4418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361543, XrefRangeEnd = 1361547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeAction(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x000B6250 File Offset: 0x000B4450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361547, XrefRangeEnd = 1361558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextCallback GetInvokeActionCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr3) : null;
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000B6284 File Offset: 0x000B4484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1361566, RefRangeEnd = 1361569, XrefRangeStart = 1361558, XrefRangeEnd = 1361566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCallback(ContextCallback callback, Object state, ref Task currentTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTask);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentTask = ((intPtr4 == 0) ? null : new Task(intPtr4));
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x000B6300 File Offset: 0x000B4500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361569, XrefRangeEnd = 1361579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInlining;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTask);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentTask = ((intPtr4 == 0) ? null : new Task(intPtr4));
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x000B636C File Offset: 0x000B456C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361586, RefRangeEnd = 1361588, XrefRangeStart = 1361579, XrefRangeEnd = 1361586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnsafeScheduleAction(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x000B63A4 File Offset: 0x000B45A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1361592, RefRangeEnd = 1361595, XrefRangeStart = 1361588, XrefRangeEnd = 1361592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsyncIfNecessary(Exception exc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000B63DC File Offset: 0x000B45DC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0000A48F File Offset: 0x0000868F
		public AwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000B6420 File Offset: 0x000B4620
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0000A498 File Offset: 0x00008698
		public unsafe ExecutionContext m_capturedContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000B6450 File Offset: 0x000B4650
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0000A4B7 File Offset: 0x000086B7
		public unsafe Action m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000B6480 File Offset: 0x000B4680
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0000A4D6 File Offset: 0x000086D6
		public unsafe static ContextCallback s_invokeActionCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeFieldInfoPtr_m_capturedContext;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeFieldInfoPtr_s_invokeActionCallback;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0;
	}
}
