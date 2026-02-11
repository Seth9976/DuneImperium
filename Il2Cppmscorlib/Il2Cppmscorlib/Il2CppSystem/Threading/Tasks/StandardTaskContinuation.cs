using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E1 RID: 481
	public class StandardTaskContinuation : TaskContinuation
	{
		// Token: 0x06001F8B RID: 8075 RVA: 0x000B598C File Offset: 0x000B3B8C
		// Note: this type is marked as 'beforefieldinit'.
		static StandardTaskContinuation()
		{
			Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "StandardTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr);
			StandardTaskContinuation.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_task");
			StandardTaskContinuation.NativeFieldInfoPtr_m_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_options");
			StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_taskScheduler");
			StandardTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, 100668663);
			StandardTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, 100668664);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000B5A20 File Offset: 0x000B3C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361330, XrefRangeEnd = 1361340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000B5A8C File Offset: 0x000B3C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361340, XrefRangeEnd = 1361346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCanInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0000A3B9 File Offset: 0x000085B9
		public StandardTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x000B5AE8 File Offset: 0x000B3CE8
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0000A3C2 File Offset: 0x000085C2
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x000B5B18 File Offset: 0x000B3D18
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0000A3E1 File Offset: 0x000085E1
		public unsafe TaskContinuationOptions m_options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_options)) = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x000B5B40 File Offset: 0x000B3D40
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0000A3FC File Offset: 0x000085FC
		public unsafe TaskScheduler m_taskScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeFieldInfoPtr_m_options;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeFieldInfoPtr_m_taskScheduler;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0;
	}
}
