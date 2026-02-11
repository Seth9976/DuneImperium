using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200020F RID: 527
	public class WebCompletionSource<T> : Object
	{
		// Token: 0x060022F0 RID: 8944 RVA: 0x000A2748 File Offset: 0x000A0948
		// Note: this type is marked as 'beforefieldinit'.
		static WebCompletionSource()
		{
			Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebCompletionSource`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr);
			WebCompletionSource<T>.NativeFieldInfoPtr_completion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, "completion");
			WebCompletionSource<T>.NativeFieldInfoPtr_currentResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, "currentResult");
			WebCompletionSource<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668481);
			WebCompletionSource<T>.NativeMethodInfoPtr_get_CurrentResult_Internal_get_Result_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668482);
			WebCompletionSource<T>.NativeMethodInfoPtr_get_Task_Internal_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668483);
			WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668484);
			WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668485);
			WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668486);
			WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_OperationCanceledException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668487);
			WebCompletionSource<T>.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668488);
			WebCompletionSource<T>.NativeMethodInfoPtr_ThrowOnError_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668489);
			WebCompletionSource<T>.NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, 100668490);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x000A28A4 File Offset: 0x000A0AA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 484332, RefRangeEnd = 484338, XrefRangeStart = 484321, XrefRangeEnd = 484332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebCompletionSource(bool runAsync = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref runAsync;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x000A28EC File Offset: 0x000A0AEC
		public unsafe WebCompletionSource<T>.Result CurrentResult
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_get_CurrentResult_Internal_get_Result_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<T>.Result>(intPtr3) : null;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x000A292C File Offset: 0x000A0B2C
		public unsafe Task Task
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 399714, RefRangeEnd = 399719, XrefRangeStart = 399714, XrefRangeEnd = 399719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_get_Task_Internal_get_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x000A296C File Offset: 0x000A0B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484344, RefRangeEnd = 484345, XrefRangeStart = 484338, XrefRangeEnd = 484344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCompleted(T argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = argument;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref argument;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x000A29F0 File Offset: 0x000A0BF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 484350, RefRangeEnd = 484354, XrefRangeStart = 484345, XrefRangeEnd = 484350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000A2A2C File Offset: 0x000A0C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484354, XrefRangeEnd = 484365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000A2A68 File Offset: 0x000A0C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 484372, RefRangeEnd = 484375, XrefRangeStart = 484365, XrefRangeEnd = 484372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(OperationCanceledException error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_OperationCanceledException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000A2AB8 File Offset: 0x000A0CB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 484382, RefRangeEnd = 484385, XrefRangeStart = 484375, XrefRangeEnd = 484382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Exception error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000A2B08 File Offset: 0x000A0D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484388, RefRangeEnd = 484389, XrefRangeStart = 484385, XrefRangeEnd = 484388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOnError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_ThrowOnError_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x000A2B3C File Offset: 0x000A0D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484389, XrefRangeEnd = 484396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<T> WaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0000F1E2 File Offset: 0x0000D3E2
		public WebCompletionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x000A2B7C File Offset: 0x000A0D7C
		// (set) Token: 0x060022FD RID: 8957 RVA: 0x0000F1EB File Offset: 0x0000D3EB
		public unsafe TaskCompletionSource<WebCompletionSource<T>.Result> completion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.NativeFieldInfoPtr_completion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebCompletionSource<T>.Result>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.NativeFieldInfoPtr_completion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x000A2BAC File Offset: 0x000A0DAC
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x0000F20A File Offset: 0x0000D40A
		public unsafe WebCompletionSource<T>.Result currentResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.NativeFieldInfoPtr_currentResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<T>.Result>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.NativeFieldInfoPtr_currentResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeFieldInfoPtr_completion;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeFieldInfoPtr_currentResult;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentResult_Internal_get_Result_T_0;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Internal_get_Task_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_T_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_OperationCanceledException_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnError_Public_Void_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_T_0;

		// Token: 0x0200034D RID: 845
		public enum Status
		{
			// Token: 0x040025DB RID: 9691
			Running,
			// Token: 0x040025DC RID: 9692
			Completed,
			// Token: 0x040025DD RID: 9693
			Canceled,
			// Token: 0x040025DE RID: 9694
			Faulted
		}

		// Token: 0x0200034E RID: 846
		public class Result : Object
		{
			// Token: 0x060030AE RID: 12462 RVA: 0x000D1BC8 File Offset: 0x000CFDC8
			// Note: this type is marked as 'beforefieldinit'.
			static Result()
			{
				Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, "Result"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr);
				WebCompletionSource<T>.Result.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, "<Status>k__BackingField");
				WebCompletionSource<T>.Result.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, "<Error>k__BackingField");
				WebCompletionSource<T>.Result.NativeFieldInfoPtr__Argument_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, "<Argument>k__BackingField");
				WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Status_Public_get_Status_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, 100668491);
				WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, 100668492);
				WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, 100668493);
				WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Argument_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, 100668494);
				WebCompletionSource<T>.Result.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, 100668495);
				WebCompletionSource<T>.Result.NativeMethodInfoPtr__ctor_Public_Void_Status_T_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr, 100668496);
			}

			// Token: 0x17000F47 RID: 3911
			// (get) Token: 0x060030AF RID: 12463 RVA: 0x000D1CE4 File Offset: 0x000CFEE4
			public unsafe WebCompletionSource<T>.Status Status
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Status_Public_get_Status_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000F48 RID: 3912
			// (get) Token: 0x060030B0 RID: 12464 RVA: 0x000D1D20 File Offset: 0x000CFF20
			public unsafe bool Success
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 484236, RefRangeEnd = 484237, XrefRangeStart = 484236, XrefRangeEnd = 484236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000F49 RID: 3913
			// (get) Token: 0x060030B1 RID: 12465 RVA: 0x000D1D5C File Offset: 0x000CFF5C
			public unsafe ExceptionDispatchInfo Error
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
				}
			}

			// Token: 0x17000F4A RID: 3914
			// (get) Token: 0x060030B2 RID: 12466 RVA: 0x000D1D9C File Offset: 0x000CFF9C
			public unsafe T Argument
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.Result.NativeMethodInfoPtr_get_Argument_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060030B3 RID: 12467 RVA: 0x000D1DD8 File Offset: 0x000CFFD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 484253, RefRangeEnd = 484254, XrefRangeStart = 484237, XrefRangeEnd = 484253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Result(T argument)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = argument;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref argument;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.Result.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060030B4 RID: 12468 RVA: 0x000D1E5C File Offset: 0x000D005C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Result(WebCompletionSource<T>.Status state, ExceptionDispatchInfo error)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource<T>.Result>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>.Result.NativeMethodInfoPtr__ctor_Public_Void_Status_T_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030B5 RID: 12469 RVA: 0x00016445 File Offset: 0x00014645
			public Result(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F44 RID: 3908
			// (get) Token: 0x060030B6 RID: 12470 RVA: 0x000D1EB8 File Offset: 0x000D00B8
			// (set) Token: 0x060030B7 RID: 12471 RVA: 0x0001644E File Offset: 0x0001464E
			public unsafe WebCompletionSource<T>.Status _Status_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.Result.NativeFieldInfoPtr__Status_k__BackingField);
					return *intPtr;
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.Result.NativeFieldInfoPtr__Status_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WebCompletionSource<T>.Status>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F45 RID: 3909
			// (get) Token: 0x060030B8 RID: 12472 RVA: 0x000D1EE0 File Offset: 0x000D00E0
			// (set) Token: 0x060030B9 RID: 12473 RVA: 0x0001647C File Offset: 0x0001467C
			public unsafe ExceptionDispatchInfo _Error_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.Result.NativeFieldInfoPtr__Error_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.Result.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F46 RID: 3910
			// (get) Token: 0x060030BA RID: 12474 RVA: 0x000D1F10 File Offset: 0x000D0110
			// (set) Token: 0x060030BB RID: 12475 RVA: 0x000D1F38 File Offset: 0x000D0138
			public unsafe T _Argument_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.Result.NativeFieldInfoPtr__Argument_k__BackingField);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>.Result.NativeFieldInfoPtr__Argument_k__BackingField);
					Type typeFromHandle = typeof(T);
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

			// Token: 0x040025DF RID: 9695
			private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

			// Token: 0x040025E0 RID: 9696
			private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

			// Token: 0x040025E1 RID: 9697
			private static readonly IntPtr NativeFieldInfoPtr__Argument_k__BackingField;

			// Token: 0x040025E2 RID: 9698
			private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_Status_T_0;

			// Token: 0x040025E3 RID: 9699
			private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

			// Token: 0x040025E4 RID: 9700
			private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0;

			// Token: 0x040025E5 RID: 9701
			private static readonly IntPtr NativeMethodInfoPtr_get_Argument_Public_get_T_0;

			// Token: 0x040025E6 RID: 9702
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x040025E7 RID: 9703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Status_T_ExceptionDispatchInfo_0;
		}

		// Token: 0x0200034F RID: 847
		[ObfuscatedName("System.Net.WebCompletionSource`1+<WaitForCompletion>d__15")]
		public sealed class _WaitForCompletion_d__15 : ValueType
		{
			// Token: 0x060030BC RID: 12476 RVA: 0x000D1FE0 File Offset: 0x000D01E0
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletion_d__15()
			{
				Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebCompletionSource<T>>.NativeClassPtr, "<WaitForCompletion>d__15"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr);
				WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr, "<>1__state");
				WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr, "<>t__builder");
				WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr, "<>4__this");
				WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr, "<>u__1");
				WebCompletionSource<T>._WaitForCompletion_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr, 100668497);
				WebCompletionSource<T>._WaitForCompletion_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr, 100668498);
			}

			// Token: 0x060030BD RID: 12477 RVA: 0x000D20C0 File Offset: 0x000D02C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484254, XrefRangeEnd = 484270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>._WaitForCompletion_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030BE RID: 12478 RVA: 0x000D20F8 File Offset: 0x000D02F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484270, XrefRangeEnd = 484321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource<T>._WaitForCompletion_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030BF RID: 12479 RVA: 0x0001649B File Offset: 0x0001469B
			public _WaitForCompletion_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x000164A4 File Offset: 0x000146A4
			public _WaitForCompletion_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource<T>._WaitForCompletion_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17000F4B RID: 3915
			// (get) Token: 0x060030C1 RID: 12481 RVA: 0x000D2140 File Offset: 0x000D0340
			// (set) Token: 0x060030C2 RID: 12482 RVA: 0x000164B6 File Offset: 0x000146B6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F4C RID: 3916
			// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000D2168 File Offset: 0x000D0368
			// (set) Token: 0x060030C4 RID: 12484 RVA: 0x000164D1 File Offset: 0x000146D1
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F4D RID: 3917
			// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000D2198 File Offset: 0x000D0398
			// (set) Token: 0x060030C6 RID: 12486 RVA: 0x000164FF File Offset: 0x000146FF
			public unsafe WebCompletionSource<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4E RID: 3918
			// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000D21C8 File Offset: 0x000D03C8
			// (set) Token: 0x060030C8 RID: 12488 RVA: 0x0001651E File Offset: 0x0001471E
			public ConfiguredTaskAwaitable<WebCompletionSource<T>.Result>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebCompletionSource<T>.Result>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebCompletionSource<T>.Result>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource<T>._WaitForCompletion_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebCompletionSource<T>.Result>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025E8 RID: 9704
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040025E9 RID: 9705
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040025EA RID: 9706
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040025EB RID: 9707
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040025EC RID: 9708
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025ED RID: 9709
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
