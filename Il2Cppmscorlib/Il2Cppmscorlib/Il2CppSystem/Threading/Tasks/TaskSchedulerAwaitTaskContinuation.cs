using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E3 RID: 483
	public sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06001FA1 RID: 8097 RVA: 0x000B5DD4 File Offset: 0x000B3FD4
		// Note: this type is marked as 'beforefieldinit'.
		static TaskSchedulerAwaitTaskContinuation()
		{
			Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskSchedulerAwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr);
			TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, "m_scheduler");
			TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, 100668673);
			TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, 100668674);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000B5E40 File Offset: 0x000B4040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000B5EAC File Offset: 0x000B40AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361449, XrefRangeEnd = 1361501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0000A467 File Offset: 0x00008667
		public TaskSchedulerAwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000B5EFC File Offset: 0x000B40FC
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0000A470 File Offset: 0x00008670
		public unsafe TaskScheduler m_scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeFieldInfoPtr_m_scheduler;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0;

		// Token: 0x02000641 RID: 1601
		[ObfuscatedName("System.Threading.Tasks.TaskSchedulerAwaitTaskContinuation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005982 RID: 22914 RVA: 0x0019A290 File Offset: 0x00198490
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr);
				TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, "<>9__2_0");
				TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, 100668676);
				TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, 100668677);
			}

			// Token: 0x06005983 RID: 22915 RVA: 0x0019A30C File Offset: 0x0019850C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005984 RID: 22916 RVA: 0x0019A348 File Offset: 0x00198548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361445, XrefRangeEnd = 1361449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Run_b__2_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005985 RID: 22917 RVA: 0x00020098 File Offset: 0x0001E298
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016D1 RID: 5841
			// (get) Token: 0x06005986 RID: 22918 RVA: 0x0019A38C File Offset: 0x0019858C
			// (set) Token: 0x06005987 RID: 22919 RVA: 0x000200A1 File Offset: 0x0001E2A1
			public unsafe static TaskSchedulerAwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskSchedulerAwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016D2 RID: 5842
			// (get) Token: 0x06005988 RID: 22920 RVA: 0x0019A3B4 File Offset: 0x001985B4
			// (set) Token: 0x06005989 RID: 22921 RVA: 0x000200B3 File Offset: 0x0001E2B3
			public unsafe static Action<Object> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004960 RID: 18784
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004961 RID: 18785
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04004962 RID: 18786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004963 RID: 18787
			private static readonly IntPtr NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0;
		}
	}
}
