using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001CF RID: 463
	public class Task<TResult> : Task
	{
		// Token: 0x06001E45 RID: 7749 RVA: 0x000AFADC File Offset: 0x000ADCDC
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "Task`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr);
			Task<TResult>.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "m_result");
			Task<TResult>.NativeFieldInfoPtr_s_defaultFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "s_defaultFactory");
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668443);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668444);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668445);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668446);
			Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668447);
			Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668448);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668449);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668450);
			Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668451);
			Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668452);
			Task<TResult>.NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668453);
			Task<TResult>.NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668454);
			Task<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668455);
			Task<TResult>.NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668456);
			Task<TResult>.NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668457);
			Task<TResult>.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668458);
			Task<TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668459);
			Task<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668460);
			Task<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668461);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_1_TResult_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668462);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_Action_1_Task_1_TResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668463);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668464);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668465);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_CancellationToken_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668466);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100668467);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x000AFD64 File Offset: 0x000ADF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358252, XrefRangeEnd = 1358260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x000AFDA0 File Offset: 0x000ADFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358264, RefRangeEnd = 1358265, XrefRangeStart = 1358260, XrefRangeEnd = 1358264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Object state, TaskCreationOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000AFDFC File Offset: 0x000ADFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358265, XrefRangeEnd = 1358282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(TResult result)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000AFE80 File Offset: 0x000AE080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358282, XrefRangeEnd = 1358287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canceled;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000AFF38 File Offset: 0x000AE138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358287, XrefRangeEnd = 1358288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<TResult> function, CancellationToken cancellationToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_TResult_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000AFF9C File Offset: 0x000AE19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358288, XrefRangeEnd = 1358296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000B0020 File Offset: 0x000AE220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358296, XrefRangeEnd = 1358300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000B00C4 File Offset: 0x000AE2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358300, XrefRangeEnd = 1358312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Delegate valueSelector, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000B017C File Offset: 0x000AE37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358318, RefRangeEnd = 1358319, XrefRangeStart = 1358312, XrefRangeEnd = 1358318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000B0218 File Offset: 0x000AE418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358325, RefRangeEnd = 1358326, XrefRangeStart = 1358319, XrefRangeEnd = 1358325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> StartNew(Task parent, Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000B02C8 File Offset: 0x000AE4C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1358335, RefRangeEnd = 1358337, XrefRangeStart = 1358326, XrefRangeEnd = 1358335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000B034C File Offset: 0x000AE54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358337, XrefRangeEnd = 1358340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousSetResult(TResult result)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x000B03C4 File Offset: 0x000AE5C4
		public unsafe TResult Result
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358340, XrefRangeEnd = 1358346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x000B0400 File Offset: 0x000AE600
		public unsafe TResult ResultOnSuccess
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000B043C File Offset: 0x000AE63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358346, XrefRangeEnd = 1358351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult GetResultCore(bool waitCompletionNotification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waitCompletionNotification;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x000B0484 File Offset: 0x000AE684
		public new unsafe static TaskFactory<TResult> Factory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1358362, RefRangeEnd = 1358363, XrefRangeStart = 1358351, XrefRangeEnd = 1358362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000B04B8 File Offset: 0x000AE6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358363, XrefRangeEnd = 1358369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task<TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000B04F4 File Offset: 0x000AE6F4
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 1358370, RefRangeEnd = 1358442, XrefRangeStart = 1358369, XrefRangeEnd = 1358370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe TaskAwaiter<TResult> GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TaskAwaiter<TResult>(intPtr);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000B052C File Offset: 0x000AE72C
		[CallerCount(233)]
		[CachedScanResults(RefRangeStart = 1358443, RefRangeEnd = 1358676, XrefRangeStart = 1358442, XrefRangeEnd = 1358443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredTaskAwaitable<TResult>(intPtr);
			}
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000B0570 File Offset: 0x000AE770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358676, XrefRangeEnd = 1358684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_1_TResult_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000B05D4 File Offset: 0x000AE7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358684, XrefRangeEnd = 1358692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_Action_1_Task_1_TResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000B065C File Offset: 0x000AE85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358698, RefRangeEnd = 1358699, XrefRangeStart = 1358692, XrefRangeEnd = 1358698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000B06AC File Offset: 0x000AE8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358699, XrefRangeEnd = 1358713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000B070C File Offset: 0x000AE90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358715, RefRangeEnd = 1358716, XrefRangeStart = 1358713, XrefRangeEnd = 1358715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_CancellationToken_TaskContinuationOptions_TaskScheduler_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000B0794 File Offset: 0x000AE994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358716, XrefRangeEnd = 1358725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00009E88 File Offset: 0x00008088
		public Task(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x000B081C File Offset: 0x000AEA1C
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x000B0844 File Offset: 0x000AEA44
		public unsafe TResult m_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task<TResult>.NativeFieldInfoPtr_m_result);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task<TResult>.NativeFieldInfoPtr_m_result);
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000B08EC File Offset: 0x000AEAEC
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00009E91 File Offset: 0x00008091
		public unsafe static TaskFactory<TResult> s_defaultFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task<TResult>.NativeFieldInfoPtr_s_defaultFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task<TResult>.NativeFieldInfoPtr_s_defaultFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultFactory;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TResult_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_TResult_CancellationToken_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_TResult_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_1_TResult_TaskScheduler_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Internal_Task_Action_1_Task_1_TResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_CancellationToken_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0;

		// Token: 0x02000625 RID: 1573
		private sealed class MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_0
		{
			// Token: 0x04004916 RID: 18710
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000626 RID: 1574
		private sealed class MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0
		{
			// Token: 0x04004917 RID: 18711
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000627 RID: 1575
		private sealed class MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_CancellationToken_TaskContinuationOptions_TaskScheduler_0
		{
			// Token: 0x04004918 RID: 18712
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_CancellationToken_TaskContinuationOptions_TaskScheduler_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000628 RID: 1576
		private sealed class MethodInfoStoreGeneric_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0
		{
			// Token: 0x04004919 RID: 18713
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}
	}
}
