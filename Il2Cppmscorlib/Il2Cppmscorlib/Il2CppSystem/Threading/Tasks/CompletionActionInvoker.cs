using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D4 RID: 468
	public sealed class CompletionActionInvoker : Object
	{
		// Token: 0x06001F4C RID: 8012 RVA: 0x000B4BA0 File Offset: 0x000B2DA0
		// Note: this type is marked as 'beforefieldinit'.
		static CompletionActionInvoker()
		{
			Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "CompletionActionInvoker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr);
			CompletionActionInvoker.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, "m_action");
			CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, "m_completingTask");
			CompletionActionInvoker.NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100668635);
			CompletionActionInvoker.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100668636);
			CompletionActionInvoker.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100668637);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x000B4C34 File Offset: 0x000B2E34
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x000B4C94 File Offset: 0x000B2E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361113, XrefRangeEnd = 1361117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x000B4CC8 File Offset: 0x000B2EC8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAborted(ThreadAbortException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0000A212 File Offset: 0x00008412
		public CompletionActionInvoker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x000B4D0C File Offset: 0x000B2F0C
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x0000A21B File Offset: 0x0000841B
		public unsafe ITaskCompletionAction m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITaskCompletionAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x000B4D3C File Offset: 0x000B2F3C
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x0000A23A File Offset: 0x0000843A
		public unsafe Task m_completingTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeFieldInfoPtr_m_completingTask;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0;
	}
}
