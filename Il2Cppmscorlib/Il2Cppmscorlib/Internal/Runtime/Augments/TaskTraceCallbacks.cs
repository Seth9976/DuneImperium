using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000051 RID: 81
	public class TaskTraceCallbacks : Object
	{
		// Token: 0x06000419 RID: 1049 RVA: 0x00035D94 File Offset: 0x00033F94
		// Note: this type is marked as 'beforefieldinit'.
		static TaskTraceCallbacks()
		{
			Il2CppClassPointerStore<TaskTraceCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Runtime.Augments", "TaskTraceCallbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskTraceCallbacks>.NativeClassPtr);
			TaskTraceCallbacks.NativeMethodInfoPtr_get_Enabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTraceCallbacks>.NativeClassPtr, 100663913);
			TaskTraceCallbacks.NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTraceCallbacks>.NativeClassPtr, 100663914);
			TaskTraceCallbacks.NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTraceCallbacks>.NativeClassPtr, 100663915);
			TaskTraceCallbacks.NativeMethodInfoPtr_TaskWaitEnd_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTraceCallbacks>.NativeClassPtr, 100663916);
			TaskTraceCallbacks.NativeMethodInfoPtr_TaskScheduled_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTraceCallbacks>.NativeClassPtr, 100663917);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00035E28 File Offset: 0x00034028
		public unsafe virtual bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskTraceCallbacks.NativeMethodInfoPtr_get_Enabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00035E70 File Offset: 0x00034070
		[CallerCount(0)]
		public unsafe virtual void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OriginatingTaskSchedulerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OriginatingTaskID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskTraceCallbacks.NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00035ED8 File Offset: 0x000340D8
		[CallerCount(0)]
		public unsafe virtual void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OriginatingTaskSchedulerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OriginatingTaskID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskTraceCallbacks.NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00035F40 File Offset: 0x00034140
		[CallerCount(0)]
		public unsafe virtual void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OriginatingTaskSchedulerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OriginatingTaskID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TaskID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskTraceCallbacks.NativeMethodInfoPtr_TaskWaitEnd_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00035FA8 File Offset: 0x000341A8
		[CallerCount(0)]
		public unsafe virtual void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskTraceCallbacks.NativeMethodInfoPtr_TaskScheduled_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000037E6 File Offset: 0x000019E6
		public TaskTraceCallbacks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_TaskWaitEnd_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_TaskScheduled_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_Int32_0;
	}
}
