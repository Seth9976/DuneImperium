using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E0 RID: 480
	public class TaskContinuation : Object
	{
		// Token: 0x06001F86 RID: 8070 RVA: 0x000B5844 File Offset: 0x000B3A44
		// Note: this type is marked as 'beforefieldinit'.
		static TaskContinuation()
		{
			Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr);
			TaskContinuation.NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100668660);
			TaskContinuation.NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100668661);
			TaskContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100668662);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x000B58B0 File Offset: 0x000B3AB0
		[CallerCount(0)]
		public unsafe virtual void Run(Task completedTask, bool bCanInlineContinuationTask)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskContinuation.NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000B590C File Offset: 0x000B3B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361329, RefRangeEnd = 1361330, XrefRangeStart = 1361318, XrefRangeEnd = 1361329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsProtection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskContinuation.NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000B5950 File Offset: 0x000B3B50
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskContinuation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0000A3B0 File Offset: 0x000085B0
		public TaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
