using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D1 RID: 465
	public class TaskFactory<TResult> : Object
	{
		// Token: 0x06001E66 RID: 7782 RVA: 0x000B0980 File Offset: 0x000AEB80
		// Note: this type is marked as 'beforefieldinit'.
		static TaskFactory()
		{
			Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr);
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCancellationToken");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultScheduler");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCreationOptions");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultContinuationOptions");
			TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668468);
			TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668469);
			TaskFactory<TResult>.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668470);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668471);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668472);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668473);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668474);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668475);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_TArg2_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668476);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668477);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668478);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000B0B18 File Offset: 0x000AED18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358769, RefRangeEnd = 1358770, XrefRangeStart = 1358764, XrefRangeEnd = 1358769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x000B0B54 File Offset: 0x000AED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358770, XrefRangeEnd = 1358775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000B0BD4 File Offset: 0x000AEDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358775, XrefRangeEnd = 1358780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> StartNew(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000B0C70 File Offset: 0x000AEE70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1358790, RefRangeEnd = 1358792, XrefRangeStart = 1358780, XrefRangeEnd = 1358790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(promise);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresSynchronization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000B0CEC File Offset: 0x000AEEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358792, XrefRangeEnd = 1358793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> FromAsync(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000B0D60 File Offset: 0x000AEF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358830, RefRangeEnd = 1358831, XrefRangeStart = 1358793, XrefRangeEnd = 1358830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncImpl(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Object state, TaskCreationOptions creationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000B0DE8 File Offset: 0x000AEFE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358833, RefRangeEnd = 1358834, XrefRangeStart = 1358831, XrefRangeEnd = 1358833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg1).IsValueType)
			{
				TArg1 targ = arg1;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000B0EA8 File Offset: 0x000AF0A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358869, RefRangeEnd = 1358870, XrefRangeStart = 1358834, XrefRangeEnd = 1358869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg1).IsValueType)
			{
				TArg1 targ = arg1;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000B0F7C File Offset: 0x000AF17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358872, RefRangeEnd = 1358873, XrefRangeStart = 1358870, XrefRangeEnd = 1358872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg1).IsValueType)
			{
				TArg1 targ = arg1;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TArg2).IsValueType)
			{
				TArg2 targ2 = arg2;
				intPtr2 = ((targ2 is string) ? IL2CPP.ManagedStringToIl2Cpp(targ2 as string) : IL2CPP.Il2CppObjectBaseToPtr(targ2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsync_Public_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_TArg2_Object_0<TArg2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr5) : null;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000B1084 File Offset: 0x000AF284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358908, RefRangeEnd = 1358909, XrefRangeStart = 1358873, XrefRangeEnd = 1358908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg1).IsValueType)
			{
				TArg1 targ = arg1;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TArg2).IsValueType)
			{
				TArg2 targ2 = arg2;
				intPtr2 = ((targ2 is string) ? IL2CPP.ManagedStringToIl2Cpp(targ2 as string) : IL2CPP.Il2CppObjectBaseToPtr(targ2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg2>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr5) : null;
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x000B11A0 File Offset: 0x000AF3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358920, RefRangeEnd = 1358921, XrefRangeStart = 1358909, XrefRangeEnd = 1358920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, Object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TInstance).IsValueType)
				{
					TInstance tinstance = thisRef;
					intPtr = ((tinstance is string) ? IL2CPP.ManagedStringToIl2Cpp(tinstance as string) : IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref thisRef;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TArgs).IsValueType)
			{
				TArgs targs = args;
				intPtr2 = ((targs is string) ? IL2CPP.ManagedStringToIl2Cpp(targs as string) : IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref args;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TInstance>.MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr5) : null;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00009EAC File Offset: 0x000080AC
		public TaskFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x000B1288 File Offset: 0x000AF488
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x00009EB5 File Offset: 0x000080B5
		public CancellationToken m_defaultCancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x000B12B8 File Offset: 0x000AF4B8
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x00009EE3 File Offset: 0x000080E3
		public unsafe TaskScheduler m_defaultScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x000B12E8 File Offset: 0x000AF4E8
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x00009F02 File Offset: 0x00008102
		public unsafe TaskCreationOptions m_defaultCreationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x000B1310 File Offset: 0x000AF510
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x00009F1D File Offset: 0x0000811D
		public unsafe TaskContinuationOptions m_defaultContinuationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
			}
		}

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultScheduler;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_TArg2_Object_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0;

		// Token: 0x02000629 RID: 1577
		public sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x0600590B RID: 22795 RVA: 0x001988F8 File Offset: 0x00196AF8
			// Note: this type is marked as 'beforefieldinit'.
			static FromAsyncTrimPromise()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "FromAsyncTrimPromise`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "s_completeFromAsyncResult");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_thisRef");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_endMethod");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100668479);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100668480);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100668481);
			}

			// Token: 0x0600590C RID: 22796 RVA: 0x001989E8 File Offset: 0x00196BE8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1358734, RefRangeEnd = 1358735, XrefRangeStart = 1358725, XrefRangeEnd = 1358734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TInstance).IsValueType)
					{
						TInstance tinstance = thisRef;
						intPtr = ((tinstance is string) ? IL2CPP.ManagedStringToIl2Cpp(tinstance as string) : IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref thisRef;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600590D RID: 22797 RVA: 0x00198A7C File Offset: 0x00196C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358735, XrefRangeEnd = 1358745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CompleteFromAsyncResult(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600590E RID: 22798 RVA: 0x00198AB4 File Offset: 0x00196CB4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1358750, RefRangeEnd = 1358752, XrefRangeStart = 1358745, XrefRangeEnd = 1358750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TInstance).IsValueType)
					{
						TInstance tinstance = thisRef;
						intPtr = ((tinstance is string) ? IL2CPP.ManagedStringToIl2Cpp(tinstance as string) : IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref thisRef;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresSynchronization;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600590F RID: 22799 RVA: 0x0001FD10 File Offset: 0x0001DF10
			public FromAsyncTrimPromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016B3 RID: 5811
			// (get) Token: 0x06005910 RID: 22800 RVA: 0x00198B60 File Offset: 0x00196D60
			// (set) Token: 0x06005911 RID: 22801 RVA: 0x0001FD19 File Offset: 0x0001DF19
			public unsafe static AsyncCallback s_completeFromAsyncResult
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016B4 RID: 5812
			// (get) Token: 0x06005912 RID: 22802 RVA: 0x00198B88 File Offset: 0x00196D88
			// (set) Token: 0x06005913 RID: 22803 RVA: 0x00198BB0 File Offset: 0x00196DB0
			public unsafe TInstance m_thisRef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef);
					return IL2CPP.PointerToValueGeneric<TInstance>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef);
					Type typeFromHandle = typeof(TInstance);
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

			// Token: 0x170016B5 RID: 5813
			// (get) Token: 0x06005914 RID: 22804 RVA: 0x00198C58 File Offset: 0x00196E58
			// (set) Token: 0x06005915 RID: 22805 RVA: 0x0001FD2B File Offset: 0x0001DF2B
			public unsafe Func<TInstance, IAsyncResult, TResult> m_endMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TInstance, IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400491A RID: 18714
			private static readonly IntPtr NativeFieldInfoPtr_s_completeFromAsyncResult;

			// Token: 0x0400491B RID: 18715
			private static readonly IntPtr NativeFieldInfoPtr_m_thisRef;

			// Token: 0x0400491C RID: 18716
			private static readonly IntPtr NativeFieldInfoPtr_m_endMethod;

			// Token: 0x0400491D RID: 18717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0;

			// Token: 0x0400491E RID: 18718
			private static readonly IntPtr NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0;

			// Token: 0x0400491F RID: 18719
			private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0;
		}

		// Token: 0x0200062A RID: 1578
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Object
		{
			// Token: 0x06005916 RID: 22806 RVA: 0x00198C88 File Offset: 0x00196E88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass35_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "endFunction");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "endAction");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "promise");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, 100668483);
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, 100668484);
			}

			// Token: 0x06005917 RID: 22807 RVA: 0x00198D54 File Offset: 0x00196F54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005918 RID: 22808 RVA: 0x00198D90 File Offset: 0x00196F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358752, XrefRangeEnd = 1358756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005919 RID: 22809 RVA: 0x0001FD4A File Offset: 0x0001DF4A
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016B6 RID: 5814
			// (get) Token: 0x0600591A RID: 22810 RVA: 0x00198DD4 File Offset: 0x00196FD4
			// (set) Token: 0x0600591B RID: 22811 RVA: 0x0001FD53 File Offset: 0x0001DF53
			public unsafe Func<IAsyncResult, TResult> endFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016B7 RID: 5815
			// (get) Token: 0x0600591C RID: 22812 RVA: 0x00198E04 File Offset: 0x00197004
			// (set) Token: 0x0600591D RID: 22813 RVA: 0x0001FD72 File Offset: 0x0001DF72
			public unsafe Action<IAsyncResult> endAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016B8 RID: 5816
			// (get) Token: 0x0600591E RID: 22814 RVA: 0x00198E34 File Offset: 0x00197034
			// (set) Token: 0x0600591F RID: 22815 RVA: 0x0001FD91 File Offset: 0x0001DF91
			public unsafe Task<TResult> promise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004920 RID: 18720
			private static readonly IntPtr NativeFieldInfoPtr_endFunction;

			// Token: 0x04004921 RID: 18721
			private static readonly IntPtr NativeFieldInfoPtr_endAction;

			// Token: 0x04004922 RID: 18722
			private static readonly IntPtr NativeFieldInfoPtr_promise;

			// Token: 0x04004923 RID: 18723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004924 RID: 18724
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x0200062B RID: 1579
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass38_0`1")]
		public sealed class __c__DisplayClass38_0<TArg1> : Object
		{
			// Token: 0x06005920 RID: 22816 RVA: 0x00198E64 File Offset: 0x00197064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass38_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endFunction");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endAction");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "promise");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100668485);
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100668486);
			}

			// Token: 0x06005921 RID: 22817 RVA: 0x00198F40 File Offset: 0x00197140
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005922 RID: 22818 RVA: 0x00198F7C File Offset: 0x0019717C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358756, XrefRangeEnd = 1358760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005923 RID: 22819 RVA: 0x0001FDB0 File Offset: 0x0001DFB0
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016B9 RID: 5817
			// (get) Token: 0x06005924 RID: 22820 RVA: 0x00198FC0 File Offset: 0x001971C0
			// (set) Token: 0x06005925 RID: 22821 RVA: 0x0001FDB9 File Offset: 0x0001DFB9
			public unsafe Func<IAsyncResult, TResult> endFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016BA RID: 5818
			// (get) Token: 0x06005926 RID: 22822 RVA: 0x00198FF0 File Offset: 0x001971F0
			// (set) Token: 0x06005927 RID: 22823 RVA: 0x0001FDD8 File Offset: 0x0001DFD8
			public unsafe Action<IAsyncResult> endAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016BB RID: 5819
			// (get) Token: 0x06005928 RID: 22824 RVA: 0x00199020 File Offset: 0x00197220
			// (set) Token: 0x06005929 RID: 22825 RVA: 0x0001FDF7 File Offset: 0x0001DFF7
			public unsafe Task<TResult> promise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004925 RID: 18725
			private static readonly IntPtr NativeFieldInfoPtr_endFunction;

			// Token: 0x04004926 RID: 18726
			private static readonly IntPtr NativeFieldInfoPtr_endAction;

			// Token: 0x04004927 RID: 18727
			private static readonly IntPtr NativeFieldInfoPtr_promise;

			// Token: 0x04004928 RID: 18728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004929 RID: 18729
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x0200062C RID: 1580
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass41_0`2")]
		public sealed class __c__DisplayClass41_0<TArg1, TArg2> : Object
		{
			// Token: 0x0600592A RID: 22826 RVA: 0x00199050 File Offset: 0x00197250
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass41_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, "endFunction");
				TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, "endAction");
				TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, "promise");
				TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, 100668487);
				TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, 100668488);
			}

			// Token: 0x0600592B RID: 22827 RVA: 0x00199140 File Offset: 0x00197340
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600592C RID: 22828 RVA: 0x0019917C File Offset: 0x0019737C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358760, XrefRangeEnd = 1358764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600592D RID: 22829 RVA: 0x0001FE16 File Offset: 0x0001E016
			public __c__DisplayClass41_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016BC RID: 5820
			// (get) Token: 0x0600592E RID: 22830 RVA: 0x001991C0 File Offset: 0x001973C0
			// (set) Token: 0x0600592F RID: 22831 RVA: 0x0001FE1F File Offset: 0x0001E01F
			public unsafe Func<IAsyncResult, TResult> endFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_endFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_endFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016BD RID: 5821
			// (get) Token: 0x06005930 RID: 22832 RVA: 0x001991F0 File Offset: 0x001973F0
			// (set) Token: 0x06005931 RID: 22833 RVA: 0x0001FE3E File Offset: 0x0001E03E
			public unsafe Action<IAsyncResult> endAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_endAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_endAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016BE RID: 5822
			// (get) Token: 0x06005932 RID: 22834 RVA: 0x00199220 File Offset: 0x00197420
			// (set) Token: 0x06005933 RID: 22835 RVA: 0x0001FE5D File Offset: 0x0001E05D
			public unsafe Task<TResult> promise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_promise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass41_0<TArg1, TArg2>.NativeFieldInfoPtr_promise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400492A RID: 18730
			private static readonly IntPtr NativeFieldInfoPtr_endFunction;

			// Token: 0x0400492B RID: 18731
			private static readonly IntPtr NativeFieldInfoPtr_endAction;

			// Token: 0x0400492C RID: 18732
			private static readonly IntPtr NativeFieldInfoPtr_promise;

			// Token: 0x0400492D RID: 18733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400492E RID: 18734
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x0200062D RID: 1581
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0
		{
			// Token: 0x0400492F RID: 18735
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TArg1>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0, Il2CppClassPointerStore<TaskFactory<TArg1>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x0200062E RID: 1582
		private sealed class MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0
		{
			// Token: 0x04004930 RID: 18736
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TArg1>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory<TArg1>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x0200062F RID: 1583
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_TArg2_Object_0<TArg2>
		{
			// Token: 0x04004931 RID: 18737
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TArg1>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_TArg2_Object_0, Il2CppClassPointerStore<TaskFactory<TArg1>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000630 RID: 1584
		private sealed class MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg2>
		{
			// Token: 0x04004932 RID: 18738
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TArg1>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory<TArg1>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000631 RID: 1585
		private sealed class MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>
		{
			// Token: 0x04004933 RID: 18739
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TInstance>.NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0, Il2CppClassPointerStore<TaskFactory<TInstance>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
			}))));
		}
	}
}
