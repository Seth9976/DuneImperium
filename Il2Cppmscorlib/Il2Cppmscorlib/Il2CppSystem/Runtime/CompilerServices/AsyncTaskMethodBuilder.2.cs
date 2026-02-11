using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D1 RID: 977
	public sealed class AsyncTaskMethodBuilder<TResult> : ValueType
	{
		// Token: 0x060039C0 RID: 14784 RVA: 0x00117030 File Offset: 0x00115230
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskMethodBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr);
			AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_s_defaultResultTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, "s_defaultResultTask");
			AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_coreState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, "m_coreState");
			AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, "m_task");
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671911);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671912);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671913);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671914);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671915);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671916);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671917);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Internal_Void_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671918);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671919);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_GetTaskForResult_Internal_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100671920);
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x001171A0 File Offset: 0x001153A0
		[CallerCount(492)]
		[CachedScanResults(RefRangeStart = 547521, RefRangeEnd = 548013, XrefRangeStart = 547521, XrefRangeEnd = 548013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncTaskMethodBuilder<TResult> Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_1_TResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncTaskMethodBuilder<TResult>(intPtr);
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x001171CC File Offset: 0x001153CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1394967, RefRangeEnd = 1394969, XrefRangeStart = 1394957, XrefRangeEnd = 1394967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start<TStateMachine>(ref TStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TStateMachine>.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x0011722C File Offset: 0x0011542C
		[CallerCount(248)]
		[CachedScanResults(RefRangeStart = 1395096, RefRangeEnd = 1395344, XrefRangeStart = 1394969, XrefRangeEnd = 1395096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x00117274 File Offset: 0x00115474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395344, XrefRangeEnd = 1395363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00117300 File Offset: 0x00115500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1395382, RefRangeEnd = 1395385, XrefRangeStart = 1395363, XrefRangeEnd = 1395382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x0011738C File Offset: 0x0011558C
		public unsafe Task<TResult> Task
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1395391, RefRangeEnd = 1395398, XrefRangeStart = 1395385, XrefRangeEnd = 1395391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x001173D0 File Offset: 0x001155D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1395418, RefRangeEnd = 1395421, XrefRangeStart = 1395398, XrefRangeEnd = 1395418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x00117450 File Offset: 0x00115650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395421, XrefRangeEnd = 1395432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult(Task<TResult> completedTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Internal_Void_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00117498 File Offset: 0x00115698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395432, XrefRangeEnd = 1395442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x001174E0 File Offset: 0x001156E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1395473, RefRangeEnd = 1395474, XrefRangeStart = 1395442, XrefRangeEnd = 1395473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> GetTaskForResult(TResult result)
		{
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_GetTaskForResult_Internal_Static_Task_1_TResult_TResult_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00015720 File Offset: 0x00013920
		public AsyncTaskMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00015729 File Offset: 0x00013929
		public AsyncTaskMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060039CD RID: 14797 RVA: 0x0011755C File Offset: 0x0011575C
		// (set) Token: 0x060039CE RID: 14798 RVA: 0x0001573B File Offset: 0x0001393B
		public unsafe static Task<TResult> s_defaultResultTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_s_defaultResultTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_s_defaultResultTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x00117584 File Offset: 0x00115784
		// (set) Token: 0x060039D0 RID: 14800 RVA: 0x0001574D File Offset: 0x0001394D
		public AsyncMethodBuilderCore m_coreState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_coreState);
				return new AsyncMethodBuilderCore(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_coreState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x001175B4 File Offset: 0x001157B4
		// (set) Token: 0x060039D2 RID: 14802 RVA: 0x0001577B File Offset: 0x0001397B
		public unsafe Task<TResult> m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultResultTask;

		// Token: 0x04002ED9 RID: 11993
		private static readonly IntPtr NativeFieldInfoPtr_m_coreState;

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_1_TResult_0;

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04002EE0 RID: 12000
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0;

		// Token: 0x04002EE1 RID: 12001
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_TResult_0;

		// Token: 0x04002EE2 RID: 12002
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Internal_Void_Task_1_TResult_0;

		// Token: 0x04002EE3 RID: 12003
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x04002EE4 RID: 12004
		private static readonly IntPtr NativeMethodInfoPtr_GetTaskForResult_Internal_Static_Task_1_TResult_TResult_0;

		// Token: 0x02000695 RID: 1685
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0
		{
			// Token: 0x04004ACC RID: 19148
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder<TStateMachine>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder<TStateMachine>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000696 RID: 1686
		private sealed class MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004ACD RID: 19149
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder<TAwaiter>.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder<TAwaiter>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000697 RID: 1687
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004ACE RID: 19150
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder<TAwaiter>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder<TAwaiter>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
