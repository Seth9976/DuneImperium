using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003CB RID: 971
	public sealed class TaskAwaiter<TResult> : ValueType, INotifyCompletion
	{
		// Token: 0x06003984 RID: 14724 RVA: 0x001162D8 File Offset: 0x001144D8
		// Note: this type is marked as 'beforefieldinit'.
		static TaskAwaiter()
		{
			Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TaskAwaiter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr);
			TaskAwaiter<TResult>.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, "m_task");
			TaskAwaiter<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100671874);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100671875);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100671876);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100671877);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_GetResult_Public_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100671878);
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x001163BC File Offset: 0x001145BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskAwaiter(Task<TResult> task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06003986 RID: 14726 RVA: 0x0011640C File Offset: 0x0011460C
		public unsafe bool IsCompleted
		{
			[CallerCount(604)]
			[CachedScanResults(RefRangeStart = 1393084, RefRangeEnd = 1393688, XrefRangeStart = 1393084, XrefRangeEnd = 1393688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00116450 File Offset: 0x00114650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1394092, XrefRangeEnd = 1394093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00116498 File Offset: 0x00114698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1394093, XrefRangeEnd = 1394094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x001164E0 File Offset: 0x001146E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1394096, RefRangeEnd = 1394097, XrefRangeStart = 1394094, XrefRangeEnd = 1394096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_GetResult_Public_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00015522 File Offset: 0x00013722
		public TaskAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0001552B File Offset: 0x0001372B
		public TaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600398C RID: 14732 RVA: 0x00116520 File Offset: 0x00114720
		// (set) Token: 0x0600398D RID: 14733 RVA: 0x0001553D File Offset: 0x0001373D
		public unsafe Task<TResult> m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter<TResult>.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter<TResult>.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x0001555C File Offset: 0x0001375C
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_0;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_TResult_0;
	}
}
