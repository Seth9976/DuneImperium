using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003AA RID: 938
	public sealed class AsyncValueTaskMethodBuilder : ValueType
	{
		// Token: 0x060038BF RID: 14527 RVA: 0x00113E38 File Offset: 0x00112038
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncValueTaskMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncValueTaskMethodBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr);
			AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__methodBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, "_methodBuilder");
			AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__haveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, "_haveResult");
			AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__useBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, "_useBuilder");
			AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, 100671776);
			AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, 100671777);
			AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, 100671778);
			AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, 100671779);
			AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, 100671780);
			AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_get_Task_Public_get_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, 100671781);
			AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, 100671782);
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00113F30 File Offset: 0x00112130
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1063108, RefRangeEnd = 1063114, XrefRangeStart = 1063108, XrefRangeEnd = 1063114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncValueTaskMethodBuilder Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncValueTaskMethodBuilder(intPtr);
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00113F5C File Offset: 0x0011215C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392625, XrefRangeEnd = 1392639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00113FBC File Offset: 0x001121BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392648, RefRangeEnd = 1392650, XrefRangeStart = 1392639, XrefRangeEnd = 1392648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00114004 File Offset: 0x00112204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392651, RefRangeEnd = 1392653, XrefRangeStart = 1392650, XrefRangeEnd = 1392651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0011403C File Offset: 0x0011223C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392653, XrefRangeEnd = 1392662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x00114084 File Offset: 0x00112284
		public unsafe ValueTask Task
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1392673, RefRangeEnd = 1392676, XrefRangeStart = 1392662, XrefRangeEnd = 1392673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_get_Task_Public_get_ValueTask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTask(intPtr);
			}
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x001140C0 File Offset: 0x001122C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392676, XrefRangeEnd = 1392680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00014D66 File Offset: 0x00012F66
		public AsyncValueTaskMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x00014D6F File Offset: 0x00012F6F
		public AsyncValueTaskMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x0011414C File Offset: 0x0011234C
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x00014D81 File Offset: 0x00012F81
		public AsyncTaskMethodBuilder _methodBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__methodBuilder);
				return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__methodBuilder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0011417C File Offset: 0x0011237C
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x00014DAF File Offset: 0x00012FAF
		public unsafe bool _haveResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__haveResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__haveResult)) = value;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x001141A4 File Offset: 0x001123A4
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x00014DCA File Offset: 0x00012FCA
		public unsafe bool _useBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__useBuilder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncValueTaskMethodBuilder.NativeFieldInfoPtr__useBuilder)) = value;
			}
		}

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeFieldInfoPtr__methodBuilder;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeFieldInfoPtr__haveResult;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeFieldInfoPtr__useBuilder;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_0;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_0;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_ValueTask_0;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x02000685 RID: 1669
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004A9A RID: 19098
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000686 RID: 1670
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
		{
			// Token: 0x04004A9B RID: 19099
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncValueTaskMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
