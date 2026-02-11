using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E7 RID: 487
	public class TaskScheduler : Object
	{
		// Token: 0x06001FEB RID: 8171 RVA: 0x000B7400 File Offset: 0x000B5600
		// Note: this type is marked as 'beforefieldinit'.
		static TaskScheduler()
		{
			Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr);
			TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_activeTaskSchedulers");
			TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_defaultTaskScheduler");
			TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_taskSchedulerIdCounter");
			TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "m_taskSchedulerId");
			TaskScheduler.NativeFieldInfoPtr__unobservedTaskException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskException");
			TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskExceptionLockObject");
			TaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668720);
			TaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668721);
			TaskScheduler.NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668722);
			TaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668723);
			TaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668724);
			TaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668725);
			TaskScheduler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668726);
			TaskScheduler.NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668727);
			TaskScheduler.NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668728);
			TaskScheduler.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668729);
			TaskScheduler.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668730);
			TaskScheduler.NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668731);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x000B7598 File Offset: 0x000B5798
		[CallerCount(0)]
		public unsafe virtual void QueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000B75E8 File Offset: 0x000B57E8
		[CallerCount(0)]
		public unsafe virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskWasPreviouslyQueued;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000B7650 File Offset: 0x000B5850
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1361890, RefRangeEnd = 1361893, XrefRangeStart = 1361888, XrefRangeEnd = 1361890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskWasPreviouslyQueued;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000B76AC File Offset: 0x000B58AC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryDequeue(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000B7704 File Offset: 0x000B5904
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyWorkItemProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x000B7740 File Offset: 0x000B5940
		public unsafe virtual bool RequiresAtomicStartTransition
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000B7788 File Offset: 0x000B5988
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x000B77C4 File Offset: 0x000B59C4
		public unsafe static TaskScheduler Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361893, XrefRangeEnd = 1361897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x000B77F8 File Offset: 0x000B59F8
		public unsafe static TaskScheduler Current
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1361907, RefRangeEnd = 1361910, XrefRangeStart = 1361897, XrefRangeEnd = 1361907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x000B782C File Offset: 0x000B5A2C
		public unsafe static TaskScheduler InternalCurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1361922, RefRangeEnd = 1361926, XrefRangeStart = 1361910, XrefRangeEnd = 1361922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x000B7860 File Offset: 0x000B5A60
		public unsafe int Id
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1361935, RefRangeEnd = 1361944, XrefRangeStart = 1361926, XrefRangeEnd = 1361935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000B789C File Offset: 0x000B5A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361956, RefRangeEnd = 1361957, XrefRangeStart = 1361944, XrefRangeEnd = 1361956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PublishUnobservedTaskException(Object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ueea);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0000A603 File Offset: 0x00008803
		public TaskScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x000B78E4 File Offset: 0x000B5AE4
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x0000A60C File Offset: 0x0000880C
		public unsafe static ConditionalWeakTable<TaskScheduler, Object> s_activeTaskSchedulers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<TaskScheduler, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x000B790C File Offset: 0x000B5B0C
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x0000A61E File Offset: 0x0000881E
		public unsafe static TaskScheduler s_defaultTaskScheduler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x000B7934 File Offset: 0x000B5B34
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x0000A630 File Offset: 0x00008830
		public unsafe static int s_taskSchedulerIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x000B7950 File Offset: 0x000B5B50
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x0000A63E File Offset: 0x0000883E
		public unsafe int m_taskSchedulerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId)) = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x000B7978 File Offset: 0x000B5B78
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x0000A659 File Offset: 0x00008859
		public unsafe static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskException, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<UnobservedTaskExceptionEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskException, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x000B79A0 File Offset: 0x000B5BA0
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x0000A66B File Offset: 0x0000886B
		public unsafe static Lock _unobservedTaskExceptionLockObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTaskSchedulers;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultTaskScheduler;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeFieldInfoPtr_s_taskSchedulerIdCounter;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeFieldInfoPtr_m_taskSchedulerId;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeFieldInfoPtr__unobservedTaskException;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeFieldInfoPtr__unobservedTaskExceptionLockObject;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0;

		// Token: 0x02000649 RID: 1609
		public sealed class SystemThreadingTasks_TaskSchedulerDebugView : Object
		{
			// Token: 0x06005997 RID: 22935 RVA: 0x000200ED File Offset: 0x0001E2ED
			// Note: this type is marked as 'beforefieldinit'.
			static SystemThreadingTasks_TaskSchedulerDebugView()
			{
				Il2CppClassPointerStore<TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "SystemThreadingTasks_TaskSchedulerDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr);
			}

			// Token: 0x06005998 RID: 22936 RVA: 0x0002010D File Offset: 0x0001E30D
			public SystemThreadingTasks_TaskSchedulerDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
