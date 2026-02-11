using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Internal.Runtime.Augments;

namespace Internal.Threading.Tasks.Tracing
{
	// Token: 0x0200004F RID: 79
	public static class TaskTrace : Object
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00035B38 File Offset: 0x00033D38
		// Note: this type is marked as 'beforefieldinit'.
		static TaskTrace()
		{
			Il2CppClassPointerStore<TaskTrace>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Threading.Tasks.Tracing", "TaskTrace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr);
			TaskTrace.NativeFieldInfoPtr_s_callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, "s_callbacks");
			TaskTrace.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663908);
			TaskTrace.NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663909);
			TaskTrace.NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663910);
			TaskTrace.NativeMethodInfoPtr_TaskWaitEnd_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663911);
			TaskTrace.NativeMethodInfoPtr_TaskScheduled_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663912);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00035BE0 File Offset: 0x00033DE0
		public unsafe static bool Enabled
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1281131, RefRangeEnd = 1281140, XrefRangeStart = 1281129, XrefRangeEnd = 1281131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskTrace.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00035C10 File Offset: 0x00033E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281142, RefRangeEnd = 1281143, XrefRangeStart = 1281140, XrefRangeEnd = 1281142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OriginatingTaskSchedulerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OriginatingTaskID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskTrace.NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00035C60 File Offset: 0x00033E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281145, RefRangeEnd = 1281146, XrefRangeStart = 1281143, XrefRangeEnd = 1281145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OriginatingTaskSchedulerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OriginatingTaskID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskTrace.NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00035CB0 File Offset: 0x00033EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1281148, RefRangeEnd = 1281151, XrefRangeStart = 1281146, XrefRangeEnd = 1281148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OriginatingTaskSchedulerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OriginatingTaskID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskTrace.NativeMethodInfoPtr_TaskWaitEnd_Public_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00035D00 File Offset: 0x00033F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281153, RefRangeEnd = 1281154, XrefRangeStart = 1281151, XrefRangeEnd = 1281153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OriginatingTaskSchedulerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OriginatingTaskID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CreatingTaskID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskCreationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskTrace.NativeMethodInfoPtr_TaskScheduled_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000037CB File Offset: 0x000019CB
		public TaskTrace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00035D6C File Offset: 0x00033F6C
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x000037D4 File Offset: 0x000019D4
		public unsafe static TaskTraceCallbacks s_callbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskTrace.NativeFieldInfoPtr_s_callbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskTraceCallbacks>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskTrace.NativeFieldInfoPtr_s_callbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_s_callbacks;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_TaskWaitEnd_Public_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_TaskScheduled_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_0;
	}
}
