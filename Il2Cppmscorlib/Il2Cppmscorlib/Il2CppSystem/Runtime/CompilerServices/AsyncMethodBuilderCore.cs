using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D3 RID: 979
	public sealed class AsyncMethodBuilderCore : ValueType
	{
		// Token: 0x060039DD RID: 14813 RVA: 0x001177A0 File Offset: 0x001159A0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncMethodBuilderCore()
		{
			Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncMethodBuilderCore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr);
			AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "m_stateMachine");
			AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "m_defaultContextAction");
			AsyncMethodBuilderCore.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100671925);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100671926);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100671927);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100671928);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100671929);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100671930);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100671931);
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00117884 File Offset: 0x00115A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1395583, RefRangeEnd = 1395585, XrefRangeStart = 1395569, XrefRangeEnd = 1395583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x001178CC File Offset: 0x00115ACC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1395622, RefRangeEnd = 1395625, XrefRangeStart = 1395585, XrefRangeEnd = 1395622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(taskForTracing);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(runnerToInitialize);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			runnerToInitialize = ((intPtr4 == 0) ? null : new AsyncMethodBuilderCore.MoveNextRunner(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Action>(intPtr5) : null;
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x0011794C File Offset: 0x00115B4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1395653, RefRangeEnd = 1395655, XrefRangeStart = 1395625, XrefRangeEnd = 1395653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action OutputAsyncCausalityEvents(Task innerTask, Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x001179B4 File Offset: 0x00115BB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1395675, RefRangeEnd = 1395678, XrefRangeStart = 1395655, XrefRangeEnd = 1395675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builtTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00117A20 File Offset: 0x00115C20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1395720, RefRangeEnd = 1395726, XrefRangeStart = 1395678, XrefRangeEnd = 1395720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsync(Exception exception, SynchronizationContext targetContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x00117A68 File Offset: 0x00115C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395726, XrefRangeEnd = 1395742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invokeAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00117AD0 File Offset: 0x00115CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395742, XrefRangeEnd = 1395745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task TryGetContinuationTask(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x000157D9 File Offset: 0x000139D9
		public AsyncMethodBuilderCore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x000157E2 File Offset: 0x000139E2
		public AsyncMethodBuilderCore()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr))
		{
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x060039E7 RID: 14823 RVA: 0x00117B14 File Offset: 0x00115D14
		// (set) Token: 0x060039E8 RID: 14824 RVA: 0x000157F4 File Offset: 0x000139F4
		public unsafe IAsyncStateMachine m_stateMachine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x060039E9 RID: 14825 RVA: 0x00117B44 File Offset: 0x00115D44
		// (set) Token: 0x060039EA RID: 14826 RVA: 0x00015813 File Offset: 0x00013A13
		public unsafe Action m_defaultContextAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeFieldInfoPtr_m_stateMachine;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContextAction;

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0;

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0;

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0;

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0;

		// Token: 0x02000699 RID: 1689
		public sealed class MoveNextRunner : Object
		{
			// Token: 0x06005BF6 RID: 23542 RVA: 0x001A1D64 File Offset: 0x0019FF64
			// Note: this type is marked as 'beforefieldinit'.
			static MoveNextRunner()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "MoveNextRunner");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr);
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "m_context");
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "m_stateMachine");
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "s_invokeMoveNext");
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100671932);
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100671933);
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100671934);
			}

			// Token: 0x06005BF7 RID: 23543 RVA: 0x001A1E08 File Offset: 0x001A0008
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BF8 RID: 23544 RVA: 0x001A1E68 File Offset: 0x001A0068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395491, XrefRangeEnd = 1395512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Run()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BF9 RID: 23545 RVA: 0x001A1E9C File Offset: 0x001A009C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395512, XrefRangeEnd = 1395522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InvokeMoveNext(Object stateMachine)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BFA RID: 23546 RVA: 0x0002157D File Offset: 0x0001F77D
			public MoveNextRunner(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001785 RID: 6021
			// (get) Token: 0x06005BFB RID: 23547 RVA: 0x001A1ED4 File Offset: 0x001A00D4
			// (set) Token: 0x06005BFC RID: 23548 RVA: 0x00021586 File Offset: 0x0001F786
			public unsafe ExecutionContext m_context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001786 RID: 6022
			// (get) Token: 0x06005BFD RID: 23549 RVA: 0x001A1F04 File Offset: 0x001A0104
			// (set) Token: 0x06005BFE RID: 23550 RVA: 0x000215A5 File Offset: 0x0001F7A5
			public unsafe IAsyncStateMachine m_stateMachine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncStateMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001787 RID: 6023
			// (get) Token: 0x06005BFF RID: 23551 RVA: 0x001A1F34 File Offset: 0x001A0134
			// (set) Token: 0x06005C00 RID: 23552 RVA: 0x000215C4 File Offset: 0x0001F7C4
			public unsafe static ContextCallback s_invokeMoveNext
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004AD0 RID: 19152
			private static readonly IntPtr NativeFieldInfoPtr_m_context;

			// Token: 0x04004AD1 RID: 19153
			private static readonly IntPtr NativeFieldInfoPtr_m_stateMachine;

			// Token: 0x04004AD2 RID: 19154
			private static readonly IntPtr NativeFieldInfoPtr_s_invokeMoveNext;

			// Token: 0x04004AD3 RID: 19155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0;

			// Token: 0x04004AD4 RID: 19156
			private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

			// Token: 0x04004AD5 RID: 19157
			private static readonly IntPtr NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0;
		}

		// Token: 0x0200069A RID: 1690
		public class ContinuationWrapper : Object
		{
			// Token: 0x06005C01 RID: 23553 RVA: 0x001A1F5C File Offset: 0x001A015C
			// Note: this type is marked as 'beforefieldinit'.
			static ContinuationWrapper()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "ContinuationWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr);
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_continuation");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_invokeAction");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_innerTask");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, 100671935);
				AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr_Invoke_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, 100671936);
			}

			// Token: 0x06005C02 RID: 23554 RVA: 0x001A1FEC File Offset: 0x001A01EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395522, XrefRangeEnd = 1395529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invokeAction);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C03 RID: 23555 RVA: 0x001A205C File Offset: 0x001A025C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395529, XrefRangeEnd = 1395530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr_Invoke_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C04 RID: 23556 RVA: 0x000215D6 File Offset: 0x0001F7D6
			public ContinuationWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001788 RID: 6024
			// (get) Token: 0x06005C05 RID: 23557 RVA: 0x001A2090 File Offset: 0x001A0290
			// (set) Token: 0x06005C06 RID: 23558 RVA: 0x000215DF File Offset: 0x0001F7DF
			public unsafe Action m_continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001789 RID: 6025
			// (get) Token: 0x06005C07 RID: 23559 RVA: 0x001A20C0 File Offset: 0x001A02C0
			// (set) Token: 0x06005C08 RID: 23560 RVA: 0x000215FE File Offset: 0x0001F7FE
			public unsafe Action m_invokeAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700178A RID: 6026
			// (get) Token: 0x06005C09 RID: 23561 RVA: 0x001A20F0 File Offset: 0x001A02F0
			// (set) Token: 0x06005C0A RID: 23562 RVA: 0x0002161D File Offset: 0x0001F81D
			public unsafe Task m_innerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004AD6 RID: 19158
			private static readonly IntPtr NativeFieldInfoPtr_m_continuation;

			// Token: 0x04004AD7 RID: 19159
			private static readonly IntPtr NativeFieldInfoPtr_m_invokeAction;

			// Token: 0x04004AD8 RID: 19160
			private static readonly IntPtr NativeFieldInfoPtr_m_innerTask;

			// Token: 0x04004AD9 RID: 19161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0;

			// Token: 0x04004ADA RID: 19162
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Void_0;
		}

		// Token: 0x0200069B RID: 1691
		[ObfuscatedName("System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06005C0B RID: 23563 RVA: 0x001A2120 File Offset: 0x001A0320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass5_0>.NativeClassPtr);
				AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeFieldInfoPtr_innerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass5_0>.NativeClassPtr, "innerTask");
				AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeFieldInfoPtr_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass5_0>.NativeClassPtr, "continuation");
				AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass5_0>.NativeClassPtr, 100671937);
				AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass5_0>.NativeClassPtr, 100671938);
			}

			// Token: 0x06005C0C RID: 23564 RVA: 0x001A219C File Offset: 0x001A039C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C0D RID: 23565 RVA: 0x001A21D8 File Offset: 0x001A03D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395530, XrefRangeEnd = 1395555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OutputAsyncCausalityEvents_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C0E RID: 23566 RVA: 0x0002163C File Offset: 0x0001F83C
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700178B RID: 6027
			// (get) Token: 0x06005C0F RID: 23567 RVA: 0x001A220C File Offset: 0x001A040C
			// (set) Token: 0x06005C10 RID: 23568 RVA: 0x00021645 File Offset: 0x0001F845
			public unsafe Task innerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeFieldInfoPtr_innerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeFieldInfoPtr_innerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700178C RID: 6028
			// (get) Token: 0x06005C11 RID: 23569 RVA: 0x001A223C File Offset: 0x001A043C
			// (set) Token: 0x06005C12 RID: 23570 RVA: 0x00021664 File Offset: 0x0001F864
			public unsafe Action continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeFieldInfoPtr_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass5_0.NativeFieldInfoPtr_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004ADB RID: 19163
			private static readonly IntPtr NativeFieldInfoPtr_innerTask;

			// Token: 0x04004ADC RID: 19164
			private static readonly IntPtr NativeFieldInfoPtr_continuation;

			// Token: 0x04004ADD RID: 19165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004ADE RID: 19166
			private static readonly IntPtr NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0;
		}

		// Token: 0x0200069C RID: 1692
		[ObfuscatedName("System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005C13 RID: 23571 RVA: 0x001A226C File Offset: 0x001A046C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr);
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9");
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9__7_0");
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9__7_1");
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100671940);
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__7_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100671941);
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__7_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100671942);
			}

			// Token: 0x06005C14 RID: 23572 RVA: 0x001A2310 File Offset: 0x001A0510
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C15 RID: 23573 RVA: 0x001A234C File Offset: 0x001A054C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395555, XrefRangeEnd = 1395562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsync_b__7_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__7_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C16 RID: 23574 RVA: 0x001A2390 File Offset: 0x001A0590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395562, XrefRangeEnd = 1395569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsync_b__7_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__7_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C17 RID: 23575 RVA: 0x00021683 File Offset: 0x0001F883
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700178D RID: 6029
			// (get) Token: 0x06005C18 RID: 23576 RVA: 0x001A23D4 File Offset: 0x001A05D4
			// (set) Token: 0x06005C19 RID: 23577 RVA: 0x0002168C File Offset: 0x0001F88C
			public unsafe static AsyncMethodBuilderCore.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncMethodBuilderCore.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700178E RID: 6030
			// (get) Token: 0x06005C1A RID: 23578 RVA: 0x001A23FC File Offset: 0x001A05FC
			// (set) Token: 0x06005C1B RID: 23579 RVA: 0x0002169E File Offset: 0x0001F89E
			public unsafe static SendOrPostCallback __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700178F RID: 6031
			// (get) Token: 0x06005C1C RID: 23580 RVA: 0x001A2424 File Offset: 0x001A0624
			// (set) Token: 0x06005C1D RID: 23581 RVA: 0x000216B0 File Offset: 0x0001F8B0
			public unsafe static WaitCallback __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004ADF RID: 19167
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004AE0 RID: 19168
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04004AE1 RID: 19169
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04004AE2 RID: 19170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004AE3 RID: 19171
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsync_b__7_0_Internal_Void_Object_0;

			// Token: 0x04004AE4 RID: 19172
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsync_b__7_1_Internal_Void_Object_0;
		}
	}
}
