using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001C6 RID: 454
	[Serializable]
	public class TaskCanceledException : OperationCanceledException
	{
		// Token: 0x06001DCE RID: 7630 RVA: 0x000ADAC8 File Offset: 0x000ABCC8
		// Note: this type is marked as 'beforefieldinit'.
		static TaskCanceledException()
		{
			Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskCanceledException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr);
			TaskCanceledException.NativeFieldInfoPtr__canceledTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, "_canceledTask");
			TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100668355);
			TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100668356);
			TaskCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100668357);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000ADB48 File Offset: 0x000ABD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357773, XrefRangeEnd = 1357776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000ADB84 File Offset: 0x000ABD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357776, XrefRangeEnd = 1357783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x000ADBD0 File Offset: 0x000ABDD0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00009C6B File Offset: 0x00007E6B
		public TaskCanceledException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000ADC34 File Offset: 0x000ABE34
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00009C74 File Offset: 0x00007E74
		public unsafe Task _canceledTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCanceledException.NativeFieldInfoPtr__canceledTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCanceledException.NativeFieldInfoPtr__canceledTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr__canceledTask;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_0;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
