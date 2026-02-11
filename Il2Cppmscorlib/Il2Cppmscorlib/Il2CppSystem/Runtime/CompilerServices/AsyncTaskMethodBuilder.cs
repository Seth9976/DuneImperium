using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D0 RID: 976
	public sealed class AsyncTaskMethodBuilder : ValueType
	{
		// Token: 0x060039B1 RID: 14769 RVA: 0x00116C30 File Offset: 0x00114E30
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskMethodBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr);
			AsyncTaskMethodBuilder.NativeFieldInfoPtr_s_cachedCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, "s_cachedCompleted");
			AsyncTaskMethodBuilder.NativeFieldInfoPtr_m_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, "m_builder");
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671902);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671903);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671904);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671905);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671906);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_get_Task_Public_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671907);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671908);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100671909);
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00116D28 File Offset: 0x00114F28
		[CallerCount(492)]
		[CachedScanResults(RefRangeStart = 547521, RefRangeEnd = 548013, XrefRangeStart = 547521, XrefRangeEnd = 548013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncTaskMethodBuilder Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncTaskMethodBuilder(intPtr);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00116D54 File Offset: 0x00114F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1394235, RefRangeEnd = 1394236, XrefRangeStart = 1394225, XrefRangeEnd = 1394235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00116DB4 File Offset: 0x00114FB4
		[CallerCount(127)]
		[CachedScanResults(RefRangeStart = 1394250, RefRangeEnd = 1394377, XrefRangeStart = 1394236, XrefRangeEnd = 1394250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x00116DFC File Offset: 0x00114FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1394387, RefRangeEnd = 1394388, XrefRangeStart = 1394377, XrefRangeEnd = 1394387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x00116E88 File Offset: 0x00115088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1394623, RefRangeEnd = 1394625, XrefRangeStart = 1394388, XrefRangeEnd = 1394623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060039B7 RID: 14775 RVA: 0x00116F14 File Offset: 0x00115114
		public unsafe Task Task
		{
			[CallerCount(185)]
			[CachedScanResults(RefRangeStart = 1394631, RefRangeEnd = 1394816, XrefRangeStart = 1394625, XrefRangeEnd = 1394631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_get_Task_Public_get_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00116F58 File Offset: 0x00115158
		[CallerCount(124)]
		[CachedScanResults(RefRangeStart = 1394826, RefRangeEnd = 1394950, XrefRangeStart = 1394816, XrefRangeEnd = 1394826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x00116F90 File Offset: 0x00115190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1394956, RefRangeEnd = 1394957, XrefRangeStart = 1394950, XrefRangeEnd = 1394956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x000156C5 File Offset: 0x000138C5
		public AsyncTaskMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x000156CE File Offset: 0x000138CE
		public AsyncTaskMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x00116FD8 File Offset: 0x001151D8
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x000156E0 File Offset: 0x000138E0
		public unsafe static Task<VoidTaskResult> s_cachedCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskMethodBuilder.NativeFieldInfoPtr_s_cachedCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<VoidTaskResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskMethodBuilder.NativeFieldInfoPtr_s_cachedCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x00117000 File Offset: 0x00115200
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x000156F2 File Offset: 0x000138F2
		public AsyncTaskMethodBuilder<VoidTaskResult> m_builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder.NativeFieldInfoPtr_m_builder);
				return new AsyncTaskMethodBuilder<VoidTaskResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<VoidTaskResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder.NativeFieldInfoPtr_m_builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<VoidTaskResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002ECE RID: 11982
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedCompleted;

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeFieldInfoPtr_m_builder;

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_0;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_0;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_0;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x02000692 RID: 1682
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004AC9 RID: 19145
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000693 RID: 1683
		private sealed class MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
		{
			// Token: 0x04004ACA RID: 19146
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000694 RID: 1684
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
		{
			// Token: 0x04004ACB RID: 19147
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
