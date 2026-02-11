using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001C7 RID: 455
	public class TaskCompletionSource<TResult> : Object
	{
		// Token: 0x06001DD5 RID: 7637 RVA: 0x000ADC64 File Offset: 0x000ABE64
		// Note: this type is marked as 'beforefieldinit'.
		static TaskCompletionSource()
		{
			Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskCompletionSource`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr);
			TaskCompletionSource<TResult>.NativeFieldInfoPtr__task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, "_task");
			TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668358);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668359);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668360);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668361);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668362);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_SpinUntilCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668363);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668364);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668365);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetResult_Public_Boolean_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668366);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668367);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668368);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668369);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_SetCanceled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100668370);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000ADDE8 File Offset: 0x000ABFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357783, XrefRangeEnd = 1357790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCompletionSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x000ADE24 File Offset: 0x000AC024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357797, RefRangeEnd = 1357798, XrefRangeStart = 1357790, XrefRangeEnd = 1357797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCompletionSource(TaskCreationOptions creationOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000ADE6C File Offset: 0x000AC06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357798, XrefRangeEnd = 1357848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCompletionSource(Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x000ADEB8 File Offset: 0x000AC0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357848, XrefRangeEnd = 1357870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCompletionSource(Object state, TaskCreationOptions creationOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000ADF14 File Offset: 0x000AC114
		public unsafe Task<TResult> Task
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000ADF54 File Offset: 0x000AC154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357870, XrefRangeEnd = 1357876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpinUntilCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_SpinUntilCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000ADF88 File Offset: 0x000AC188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357876, XrefRangeEnd = 1357880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000ADFD8 File Offset: 0x000AC1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357880, XrefRangeEnd = 1357887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000AE01C File Offset: 0x000AC21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357889, RefRangeEnd = 1357890, XrefRangeStart = 1357887, XrefRangeEnd = 1357889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetResult(TResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetResult_Public_Boolean_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000AE0A0 File Offset: 0x000AC2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357893, RefRangeEnd = 1357894, XrefRangeStart = 1357890, XrefRangeEnd = 1357893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult(TResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000AE118 File Offset: 0x000AC318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357894, XrefRangeEnd = 1357897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000AE154 File Offset: 0x000AC354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357897, XrefRangeEnd = 1357900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000AE1A8 File Offset: 0x000AC3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357900, XrefRangeEnd = 1357904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_SetCanceled_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00009C93 File Offset: 0x00007E93
		public TaskCompletionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000AE1DC File Offset: 0x000AC3DC
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00009C9C File Offset: 0x00007E9C
		public unsafe Task<TResult> _task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCompletionSource<TResult>.NativeFieldInfoPtr__task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCompletionSource<TResult>.NativeFieldInfoPtr__task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeFieldInfoPtr__task;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TaskCreationOptions_0;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_TaskCreationOptions_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_SpinUntilCompleted_Private_Void_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_TrySetResult_Public_Boolean_TResult_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_TResult_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_CancellationToken_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_SetCanceled_Public_Void_0;
	}
}
