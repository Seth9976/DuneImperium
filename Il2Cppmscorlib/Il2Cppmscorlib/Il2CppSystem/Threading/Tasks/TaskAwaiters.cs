using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001CC RID: 460
	public static class TaskAwaiters : Object
	{
		// Token: 0x06001E26 RID: 7718 RVA: 0x00009DD1 File Offset: 0x00007FD1
		// Note: this type is marked as 'beforefieldinit'.
		static TaskAwaiters()
		{
			Il2CppClassPointerStore<TaskAwaiters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskAwaiters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskAwaiters>.NativeClassPtr);
			TaskAwaiters.NativeMethodInfoPtr_ForceAsync_Public_Static_ForceAsyncAwaiter_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiters>.NativeClassPtr, 100668425);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x000AF3FC File Offset: 0x000AD5FC
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ForceAsyncAwaiter ForceAsync(this Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiters.NativeMethodInfoPtr_ForceAsync_Public_Static_ForceAsyncAwaiter_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ForceAsyncAwaiter(intPtr);
			}
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00009E0A File Offset: 0x0000800A
		public TaskAwaiters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_ForceAsync_Public_Static_ForceAsyncAwaiter_Task_0;
	}
}
