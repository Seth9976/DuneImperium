using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003AB RID: 939
	public sealed class AsyncValueTaskMethodBuilder<TResult> : ValueType
	{
		// Token: 0x060038CF RID: 14543 RVA: 0x001141CC File Offset: 0x001123CC
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncValueTaskMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncValueTaskMethodBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr);
			AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__methodBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_methodBuilder");
			AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_result");
			AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__haveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_haveResult");
			AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__useBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_useBuilder");
			AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671783);
			AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671784);
			AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671785);
			AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671786);
			AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671787);
			AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_get_Task_Public_get_ValueTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671788);
			AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671789);
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00114314 File Offset: 0x00112514
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1063108, RefRangeEnd = 1063114, XrefRangeStart = 1063108, XrefRangeEnd = 1063114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncValueTaskMethodBuilder<TResult> Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_1_TResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncValueTaskMethodBuilder<TResult>(intPtr);
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00114340 File Offset: 0x00112540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392680, XrefRangeEnd = 1392685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TStateMachine>.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x001143A0 File Offset: 0x001125A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392729, RefRangeEnd = 1392731, XrefRangeStart = 1392685, XrefRangeEnd = 1392729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x001143E8 File Offset: 0x001125E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392731, RefRangeEnd = 1392733, XrefRangeStart = 1392731, XrefRangeEnd = 1392731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x00114468 File Offset: 0x00112668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392733, XrefRangeEnd = 1392739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x001144B0 File Offset: 0x001126B0
		public unsafe ValueTask<TResult> Task
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1392750, RefRangeEnd = 1392753, XrefRangeStart = 1392739, XrefRangeEnd = 1392750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_get_Task_Public_get_ValueTask_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTask<TResult>(intPtr);
			}
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x001144EC File Offset: 0x001126EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392753, XrefRangeEnd = 1392794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00014DE5 File Offset: 0x00012FE5
		public AsyncValueTaskMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x00014DEE File Offset: 0x00012FEE
		public AsyncValueTaskMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x00114578 File Offset: 0x00112778
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x00014E00 File Offset: 0x00013000
		public AsyncTaskMethodBuilder<TResult> _methodBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__methodBuilder);
				return new AsyncTaskMethodBuilder<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__methodBuilder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x001145A8 File Offset: 0x001127A8
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x001145D0 File Offset: 0x001127D0
		public unsafe TResult _result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__result);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__result);
				Type typeFromHandle = typeof(TResult);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x00114678 File Offset: 0x00112878
		// (set) Token: 0x060038DE RID: 14558 RVA: 0x00014E2E File Offset: 0x0001302E
		public unsafe bool _haveResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__haveResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__haveResult)) = value;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x001146A0 File Offset: 0x001128A0
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x00014E49 File Offset: 0x00013049
		public unsafe bool _useBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__useBuilder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder<TResult>.NativeFieldInfoPtr__useBuilder)) = value;
			}
		}

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeFieldInfoPtr__methodBuilder;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeFieldInfoPtr__result;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeFieldInfoPtr__haveResult;

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeFieldInfoPtr__useBuilder;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_1_TResult_0;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_TResult_0;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_ValueTask_1_TResult_0;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x02000687 RID: 1671
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0
		{
			// Token: 0x04004A9C RID: 19100
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncValueTaskMethodBuilder<TStateMachine>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TStateMachine>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000688 RID: 1672
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004A9D RID: 19101
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncValueTaskMethodBuilder<TAwaiter>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TAwaiter>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
