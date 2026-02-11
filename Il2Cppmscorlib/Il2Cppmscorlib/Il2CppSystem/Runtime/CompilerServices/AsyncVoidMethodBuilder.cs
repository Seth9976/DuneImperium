using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003CF RID: 975
	public sealed class AsyncVoidMethodBuilder : ValueType
	{
		// Token: 0x060039A0 RID: 14752 RVA: 0x00116838 File Offset: 0x00114A38
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncVoidMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncVoidMethodBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr);
			AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_synchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, "m_synchronizationContext");
			AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_coreState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, "m_coreState");
			AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, "m_task");
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncVoidMethodBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671894);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671895);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671896);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671897);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671898);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671899);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_NotifySynchronizationContextOfCompletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671900);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_get_Task_Internal_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100671901);
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00116944 File Offset: 0x00114B44
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1394124, RefRangeEnd = 1394133, XrefRangeStart = 1394122, XrefRangeEnd = 1394124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncVoidMethodBuilder Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncVoidMethodBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncVoidMethodBuilder(intPtr);
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00116970 File Offset: 0x00114B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1394133, XrefRangeEnd = 1394149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x001169D0 File Offset: 0x00114BD0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1394163, RefRangeEnd = 1394170, XrefRangeStart = 1394149, XrefRangeEnd = 1394163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x00116A18 File Offset: 0x00114C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1394189, RefRangeEnd = 1394190, XrefRangeStart = 1394170, XrefRangeEnd = 1394189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00116AA4 File Offset: 0x00114CA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1394195, RefRangeEnd = 1394202, XrefRangeStart = 1394190, XrefRangeEnd = 1394195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x00116ADC File Offset: 0x00114CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1394202, XrefRangeEnd = 1394211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x00116B24 File Offset: 0x00114D24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1394213, RefRangeEnd = 1394216, XrefRangeStart = 1394211, XrefRangeEnd = 1394213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySynchronizationContextOfCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_NotifySynchronizationContextOfCompletion_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x00116B5C File Offset: 0x00114D5C
		public unsafe Task Task
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1394221, RefRangeEnd = 1394225, XrefRangeStart = 1394216, XrefRangeEnd = 1394221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_get_Task_Internal_get_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x0001563E File Offset: 0x0001383E
		public AsyncVoidMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x00015647 File Offset: 0x00013847
		public AsyncVoidMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x00116BA0 File Offset: 0x00114DA0
		// (set) Token: 0x060039AC RID: 14764 RVA: 0x00015659 File Offset: 0x00013859
		public unsafe SynchronizationContext m_synchronizationContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_synchronizationContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_synchronizationContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x00116BD0 File Offset: 0x00114DD0
		// (set) Token: 0x060039AE RID: 14766 RVA: 0x00015678 File Offset: 0x00013878
		public AsyncMethodBuilderCore m_coreState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_coreState);
				return new AsyncMethodBuilderCore(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_coreState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x00116C00 File Offset: 0x00114E00
		// (set) Token: 0x060039B0 RID: 14768 RVA: 0x000156A6 File Offset: 0x000138A6
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeFieldInfoPtr_m_synchronizationContext;

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeFieldInfoPtr_m_coreState;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncVoidMethodBuilder_0;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_0;

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeMethodInfoPtr_NotifySynchronizationContextOfCompletion_Private_Void_0;

		// Token: 0x04002ECD RID: 11981
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Internal_get_Task_0;

		// Token: 0x02000690 RID: 1680
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004AC7 RID: 19143
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncVoidMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000691 RID: 1681
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
		{
			// Token: 0x04004AC8 RID: 19144
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncVoidMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
