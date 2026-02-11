using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x02000136 RID: 310
	public static class TaskExtensions : Object
	{
		// Token: 0x06001286 RID: 4742 RVA: 0x00007A8B File Offset: 0x00005C8B
		// Note: this type is marked as 'beforefieldinit'.
		static TaskExtensions()
		{
			Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Threading.Tasks", "TaskExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr);
			TaskExtensions.NativeMethodInfoPtr_Unwrap_Public_Static_Task_1_TResult_Task_1_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr, 100666778);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0005FE0C File Offset: 0x0005E00C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032284, RefRangeEnd = 1032285, XrefRangeStart = 1032273, XrefRangeEnd = 1032284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Unwrap<TResult>(this Task<Task<TResult>> task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions.MethodInfoStoreGeneric_Unwrap_Public_Static_Task_1_TResult_Task_1_Task_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public TaskExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_Unwrap_Public_Static_Task_1_TResult_Task_1_Task_1_TResult_0;

		// Token: 0x0200035B RID: 859
		private sealed class MethodInfoStoreGeneric_Unwrap_Public_Static_Task_1_TResult_Task_1_Task_1_TResult_0<TResult>
		{
			// Token: 0x04001319 RID: 4889
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskExtensions.NativeMethodInfoPtr_Unwrap_Public_Static_Task_1_TResult_Task_1_Task_1_TResult_0, Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
